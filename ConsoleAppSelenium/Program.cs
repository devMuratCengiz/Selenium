using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Drawing.Imaging;


IWebDriver driver = new ChromeDriver();
string link = "https://www.zara.com/tr/en/vibrant-leather-warm-edp-100-ml---3-38%C2%A0oz-p20220092.html";
driver.Navigate().GoToUrl(link);
IWebElement stockElement = driver.FindElement(By.ClassName("product-detail-show-similar-products__action-tip"));
string text = stockElement.Text;
string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
string timeForScreenshot = DateTime.Now.ToString("MM.dd.yyyy_HH.mm.ss");
string filePath = "C:\\Users\\murat\\Desktop\\seleniumOutput.txt";
string outputText = $"[{time}] Stock = {text}";
File.AppendAllText(filePath, outputText + Environment.NewLine);
Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
string screenShotsPath = $"C:\\Users\\murat\\Desktop\\seleniumScreenshots\\{timeForScreenshot}.png";
screenshot.SaveAsFile(screenShotsPath);
driver.Quit();