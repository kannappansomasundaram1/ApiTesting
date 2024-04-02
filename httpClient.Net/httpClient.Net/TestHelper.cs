namespace httpClient.Net;

public class TestHelper : IDisposable
{
    public TestHelper()
    {
        Client = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
        };
    }

    public HttpClient Client { get; }
    
    public void Dispose()
    {
        Client.Dispose();
    }
}