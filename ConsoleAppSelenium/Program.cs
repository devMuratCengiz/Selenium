using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

IWebDriver driver = new ChromeDriver();
string link = "https://www.zara.com/tr/en/vibrant-leather-warm-edp-100-ml---3-38%C2%A0oz-p20220092.html";
driver.Navigate().GoToUrl(link);
IWebElement stockElement = driver.FindElement(By.ClassName("product-detail-show-similar-products__action-tip"));
string text = stockElement.Text;
string dateTime = DateTime.Now.ToString("MM/dd/yyy HH:mm:ss");
string filePath = "C:\\Users\\murat\\Desktop\\seleniumOutput.txt";
string outputText = $"[{dateTime}] Stock = {text}";
File.AppendAllText(filePath, outputText + Environment.NewLine);
driver.Quit();