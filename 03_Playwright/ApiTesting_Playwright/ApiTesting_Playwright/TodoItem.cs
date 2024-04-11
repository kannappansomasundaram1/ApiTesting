namespace ApiTesting_Playwright;
public record TodoItem(
    int userId,
    int id,
    string title,
    bool completed
);