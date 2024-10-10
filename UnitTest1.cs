using Microsoft.Playwright;

namespace PlaywrightProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        // Create playwright instance
        using var playwright = await Playwright.CreateAsync();

        // Create browser instance
        await using var browser = await playwright.Chromium.LaunchAsync();

        // Create page instance
        var page = await browser.NewPageAsync();

        // Go to particular page
        await page.GotoAsync("https://demoqa.com/");

        // Perform a specific action
        await page.ClickAsync("text = Elements");
    }
}