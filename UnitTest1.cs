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
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });

        // Create page instance
        var page = await browser.NewPageAsync();

        // Go to particular page
        await page.GotoAsync("https://demoqa.com/");
        await page.ClickAsync("text = Elements");
        await page.ClickAsync("text = Text Box");
        await page.FillAsync("#userName", "important user");
        await page.FillAsync("#userEmail", "importantemail@email.com");
        await page.FillAsync("#currentAddress", "Important Street 77/88BHL");
        await page.FillAsync("#permanentAddress", "This one is permanent address");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "filledform.jpg"
        });

        // Perform a specific action
        await page.ClickAsync("text = Elements");
    }
}