using System.Net.Http.Json;
using System.Text.Json;
using ApiTesting_Playwright;
using FluentAssertions;

namespace httpClient.Net;

public class TodoItemsTest_UsingHttpClient : IClassFixture<TestHelper>
{
    private readonly HttpClient _client;

    public TodoItemsTest_UsingHttpClient(TestHelper helper)
    {
        _client = helper.Client;
    }

    [Fact]
    public async Task TodoItems_Returned_From_Todos_Endpoint()
    {
        var todoItems = await _client.GetFromJsonAsync<TodoItem[]>("/todos", new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        }, CancellationToken.None);

        todoItems.Should().HaveCountGreaterThan(10);
        todoItems.First().id.Should().Be(1);
    }
}