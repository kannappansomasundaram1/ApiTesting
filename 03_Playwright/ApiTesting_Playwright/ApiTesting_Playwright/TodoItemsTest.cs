using System.Net;
using System.Text.Json;
using FluentAssertions;
using Microsoft.Playwright;

namespace ApiTesting_Playwright;

public class TodoItemsTest
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly APIRequestNewContextOptions _apiRequestNewContextOptions;

    public TodoItemsTest()
    {
        _apiRequestNewContextOptions = new APIRequestNewContextOptions
        {
            BaseURL = "https://jsonplaceholder.typicode.com"
        };
    }

    [Fact]
    public async Task TodoItems_Returned_From_Todos_Endpoint()
    {
        var playwright = await Playwright.CreateAsync();
        var requestContext = await playwright.APIRequest.NewContextAsync(_apiRequestNewContextOptions);

        var apiResponse = await requestContext.GetAsync("todos");
        
        apiResponse.Status.Should().Be((int)HttpStatusCode.OK);
        
        var jsonResponse = await apiResponse.JsonAsync();
        var todoItems = jsonResponse.Value.Deserialize<TodoItem[]>(JsonSerializerOptions);
        todoItems.Should().HaveCountGreaterThan(10);
        todoItems.First().id.Should().Be(1);
    }
}