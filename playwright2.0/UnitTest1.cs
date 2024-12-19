using Microsoft.Playwright;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace playwright2._0
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
       public async Task Test1()
        {
           var playwright = await Playwright.CreateAsync();
           var browser = await playwright.Chromium.LaunchAsync(
                 new BrowserTypeLaunchOptions { Headless= false , SlowMo=50 , Timeout=80000 });

            var page = await browser.NewPageAsync();

            await page.GotoAsync("http://www.eaapp.somee.com/");

            
            await page.Locator("text=Login").ClickAsync();
            await page.ScreenshotAsync( new PageScreenshotOptions
            {
                Path = "EAApp.jpg"
            }
                );
            

        }
    }
}