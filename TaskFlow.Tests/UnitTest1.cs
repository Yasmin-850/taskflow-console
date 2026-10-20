
using TaskFlow.Console.Services;
using Xunit;

namespace TaskFlow.Tests;

public class TaskManagerTests
{
    [Fact]
    public void AddTask_ShouldCreateTaskWithCorrectTitle()
    {
        // Arrange
        var manager = new TaskManager();

        // Act
        var task = manager.AddTask("Estudar C#");

        // Assert
        Assert.Equal(1, task.Id);
        Assert.Equal("Estudar C#", task.Title);
        Assert.False(task.IsCompleted);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void AddTask_ShouldRejectEmptyOrNullTitle(string? title)
    {
        // Arrange
        var manager = new TaskManager();

        // Act and Assert
        Assert.Throws<ArgumentException>(
            () => manager.AddTask(title!));
    }
}
