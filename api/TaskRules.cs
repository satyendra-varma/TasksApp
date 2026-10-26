namespace api;

public static class TaskRules
{
    public const int MaxTitleLength = 200;

    public static bool IsValidTitle(string? title) 
    {
        return !string.IsNullOrWhiteSpace(title) && title.Trim().Length <= MaxTitleLength;
    }
}