using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightProject;

public class NUnitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        // Go to particular page
        await Page.GotoAsync("https://demoqa.com/");
    }

    [Test]
    public async Task Test1()
    {
        var btnElements = Page.Locator("text = Elements");
        await btnElements.ClickAsync();
        var btnTextBox = Page.Locator("text = Text Box");
        await btnTextBox.ClickAsync();
        await Page.FillAsync("#userName", "important user");
        await Page.FillAsync("#userEmail", "importantemail@email.com");
        await Page.FillAsync("#currentAddress", "Important Street 77/88BHL");
        await Page.FillAsync("#permanentAddress", "This one is permanent address");
        await Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "filledform.jpg"
        });
    }
}