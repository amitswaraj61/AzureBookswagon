using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBookswagon
{
  public class Screenshot
    {
        public static string Capture(IWebDriver driver, string ScreenShotName)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            var ts = ((ITakesScreenshot)driver).GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string uptobinpath = path.Substring(0, path.LastIndexOf("bin")) + "Screenshot images\\" + (ScreenShotName + "   " + time) + ".png";
            string localPath = new Uri(uptobinpath).LocalPath;
            ts.SaveAsFile(localPath, ScreenshotImageFormat.Png);
            return localPath;
        }
    }
}
