using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace DetectorFallasSerial.LLMS.ChatGpt;

public sealed class ChatGptClient : IDisposable
{
    private const string ApiUrl = "https://api.openai.com/v1/chat/completions";

    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _model;
    private bool _disposed;

    public ChatGptClient(string? apiKey = null, string? model = null)
    {
        _apiKey = apiKey
            ?? Environment.GetEnvironmentVariable("OPENAI_API_KEY")
            ?? string.Empty;

        _model = model
            ?? Environment.GetEnvironmentVariable("OPENAI_MODEL")
            ?? "gpt-4o-mini";

        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<string> ConsultarAsync(
        string texto,
        CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        if (string.IsNullOrWhiteSpace(texto))
        {
            throw new ArgumentException(
                "El texto enviado a ChatGPT no puede estar vacio.",
                nameof(texto));
        }

        if (string.IsNullOrWhiteSpace(_apiKey))
        {
            throw new InvalidOperationException(
                "No se encontro OPENAI_API_KEY. Configure la variable de entorno antes de iniciar la aplicacion.");
        }

        using var request = new HttpRequestMessage(HttpMethod.Post, ApiUrl);
        request.Headers.Authorization =
            new AuthenticationHeaderValue("Bearer", _apiKey);

        var payload = new
        {
            model = _model,
            messages = new[]
            {
                new
                {
                    role = "system",
                    content = "Eres un asistente tecnico que analiza datos de equipos electronicos y de fallas seriales. Responde claramente en espanol."
                },
                new
                {
                    role = "user",
                    content = texto
                }
            }
        };

        request.Content = new StringContent(
            JsonSerializer.Serialize(payload),
            Encoding.UTF8,
            "application/json");

        using var response = await _httpClient.SendAsync(
            request,
            cancellationToken);

        var responseJson = await response.Content.ReadAsStringAsync(
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException(
                $"ChatGPT rechazo la consulta ({(int)response.StatusCode}): {ObtenerMensajeError(responseJson)}");
        }

        using var document = JsonDocument.Parse(responseJson);
        var choice = document.RootElement
            .GetProperty("choices")[0]
            .GetProperty("message")
            .GetProperty("content");

        var respuesta = choice.GetString();
        if (string.IsNullOrWhiteSpace(respuesta))
        {
            throw new InvalidOperationException(
                "ChatGPT devolvio una respuesta vacia.");
        }

        return respuesta;
    }

    private static string ObtenerMensajeError(string responseJson)
    {
        try
        {
            using var document = JsonDocument.Parse(responseJson);
            return document.RootElement
                .GetProperty("error")
                .GetProperty("message")
                .GetString()
                ?? "Respuesta desconocida.";
        }
        catch
        {
            return "Respuesta desconocida.";
        }
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _httpClient.Dispose();
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}
