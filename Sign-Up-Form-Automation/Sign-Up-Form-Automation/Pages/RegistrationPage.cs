using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sign_Up_Form_Automation.Pages
{
    
    public class RegistrationPage 
    {
        protected readonly IWebDriver driver;

        public object Assertions { get; private set; }

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public WebElement mainHeading()
        {
            return (WebElement)driver.FindElement(By.TagName("h1"));
        }

        public void asserAccountCreatedSuccesfully() 
        {
            Assertions.Equals("Your Account Has Been Created!");
        } 
        
        
    }
}
