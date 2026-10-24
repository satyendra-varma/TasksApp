using api;
public class TaskRulesTests
{
    [Fact]
    public void IsValidTitle_ReturnsTrue_ForNormalTitle()
    {
        var title = "This is a valid task title";
        var result = TaskRules.IsValidTitle(title);
        Assert.True(result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void IsValidTitle_ReturnsFalse_ForEmptyTitles(string? title)
    {
        Assert.False(TaskRules.IsValidTitle(title));
    }
     [Fact]
    public void IsValidTitle_ReturnsTrue_AtExactlyMaxLength()
    {
        var title = new string('a', TaskRules.MaxTitleLength);
        Assert.True(TaskRules.IsValidTitle(title));
    }

    [Fact]
    public void IsValidTitle_ReturnsFalse_WhenOneOverMax()
    {
        var title = new string('a', TaskRules.MaxTitleLength + 1);
        Assert.False(TaskRules.IsValidTitle(title));
    }


}