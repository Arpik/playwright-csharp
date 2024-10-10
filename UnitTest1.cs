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
<<<<<<< HEAD
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
=======
        await using var browser = await playwright.Chromium.LaunchAsync();
>>>>>>> b3de7d042f281488fa53bfbe10bc668e0f57a0cd

        // Create page instance
        var page = await browser.NewPageAsync();

        // Go to particular page
        await page.GotoAsync("https://demoqa.com/");

<<<<<<< HEAD
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
=======
        // Perform a specific action
        await page.ClickAsync("text = Elements");
>>>>>>> b3de7d042f281488fa53bfbe10bc668e0f57a0cd
    }
}