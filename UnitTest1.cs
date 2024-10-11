using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightProject;

public class NUnitPlaywright : PageTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        // Go to particular page
        await Page.GotoAsync("https://demoqa.com/");
        await Page.ClickAsync("text = Elements");
        await Page.ClickAsync("text = Text Box");
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