using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC_tests
{
    class News
    {

        public News()
        {           
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


       
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[1]/app-menu/div/div[6]/div")]
        public IWebElement BtnNews { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-list/div/div[2]/button/span[2]")]
        public IWebElement BtnNewNews { get; set; }
        [FindsBy(How = How.Name, Using = "title")] 
        public IWebElement Title { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-edit/div/form/div[2]/div[1]/div[2]/p-calendar[1]/span/button/span[1]")]
        public IWebElement Calendar1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-edit/div/form/div[2]/div[1]/div[2]/p-calendar[1]/span/div/table/tbody/tr[1]/td[7]/a")]
        public IWebElement num1 { get; set; }
        [FindsBy(How = How.Name, Using = "endPublishModel")]
        public IWebElement Calendar2 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-edit/div/form/div[2]/div[1]/div[2]/p-calendar[2]/span/div/table/tbody/tr[5]/td[1]/a")]
        public IWebElement num2 { get; set; } 
        [FindsBy(How = How.Name, Using = "weight")]
        public IWebElement Weight { get; set; }
        [FindsBy(How = How.Name, Using = "shortContent")]
        public IWebElement ShortContent { get; set; } 
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-edit/div/form/div[5]/div[2]/p-editor/div/div[2]/div[1]")]
        public IWebElement TextNew { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-edit/div/form/div[6]/button[1]/span[2]")]
        public IWebElement Save { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-list/div/p-datatable/div/div[1]/table/tbody/tr[1]/td[8]/span/button/span[1]")]
        public IWebElement DeleteLastNews { get; set; }
        
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-admin-panel/div[2]/div[2]/app-news-list/div/p-datatable/div/div[1]/table/tbody/tr[1]/td[7]/span/button/span[1]")]
        public IWebElement BtnEditing { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='id2']/div[3]/div[2]/span")]
        public IWebElement glaz { get; set; }




        




        public void CreatNews(string title, string weight, string shortContent, string textNew)
        {
            
            BtnNewNews.Click();
            Title.SendKeys(title);
            Calendar1.Click();
            num1.Click();          
            Calendar2.Click();
            num2.Click();
            Weight.SendKeys(weight);
            System.Threading.Thread.Sleep(4000);
            ShortContent.SendKeys(shortContent);
            TextNew.SendKeys(textNew);
            
            Save.Click();
            
        }

        public void EditingLastNew(string title, string weight, string shortContent, string textNew)
        {
            BtnEditing.Click();
            Title.Clear();
            Title.SendKeys(title);
            System.Threading.Thread.Sleep(2000);
            Calendar1.Click();
            num1.Click();
            Calendar2.Click();
            num2.Click();
            Weight.Clear();
            Weight.SendKeys(weight);
            ShortContent.Clear();
            ShortContent.SendKeys(shortContent);
            TextNew.Clear();
            TextNew.SendKeys(textNew);
            Save.Click();
            
        }


        public string GetLongTextShortContent5000()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque consectetur tempus ornare. Aliquam finibus ultrices sem, in bibendum magna convallis in. Aliquam vel posuere urna. Duis eleifend volutpat augue, sit amet fringilla sapien ullamcorper sit amet. Ut nec tristique lacus. Curabitur cursus lorem ornare leo placerat, ut congue neque condimentum. In hac habitasse platea dictumst. Donec lobortis, ante ut consequat dapibus, nisl lorem vestibulum diam, quis condimentum elit neque nec sem. Suspendisse libero augue, vulputate eu lorem in, condimentum tempor turpis.Phasellus pulvinar nibh eu odio dapibus porttitor.Vivamus molestie, nibh non ultricies mollis, lorem est varius neque, vel sollicitudin elit eros et leo.Aliquam molestie suscipit consequat. In hac habitasse platea dictumst.Pellentesque accumsan laoreet sagittis. Phasellus commodo nibh et imperdiet sollicitudin. Suspendisse luctus velit at justo sodales maximus non at felis. Mauris sed magna at nisl fringilla dapibus.Nullam aliquam felis non pulvinar eleifend.Phasellus elementum rutrum feugiat. Pellentesque consectetur purus volutpat lacus tincidunt, quis porta purus hendrerit.Nam laoreet purus sit amet venenatis mollis.Donec faucibus, purus eget lacinia euismod, ipsum quam tincidunt mauris, sit amet tristique tellus ligula vitae tellus. In elementum scelerisque suscipit. Donec ut lectus ornare, consectetur arcu nec, laoreet odio.Nullam egestas neque eu malesuada rutrum. Donec iaculis id purus ac lacinia. Praesent purus neque, pellentesque vitae dapibus a, finibus dictum turpis. Etiam vitae scelerisque nunc, non egestas nibh. Morbi varius, risus quis fermentum sodales, felis neque suscipit eros, id lacinia tortor dolor sit amet ex. Integer nec fermentum dolor.Ut consequat fermentum libero at viverra. Nunc lobortis massa nec tellus fermentum, ut porta nunc maximus.Duis pharetra nunc urna, eget gravida dui auctor sit amet.Nullam euismod massa sit amet cursus mattis.Pellentesque et libero non diam iaculis dapibus.Nam quis congue risus, quis mattis est. Donec pellentesque ligula suscipit quam sollicitudin fermentum.Fusce egestas varius ante non malesuada. Nullam tincidunt lectus quis dolor aliquet, eu efficitur libero scelerisque.Curabitur fringilla rutrum cursus. Duis consequat aliquam pellentesque. Morbi sollicitudin tellus mollis tempus bibendum. Donec rhoncus luctus ex, quis pellentesque nisi sollicitudin vitae. Quisque et tellus felis. Cras semper neque et nisl molestie, non lacinia quam faucibus.Praesent et blandit odio.Ut non varius est, vel placerat est. Vestibulum venenatis nunc luctus elementum posuere. Mauris rutrum lacus ac mi gravida tincidunt.Quisque eget est felis. Duis cursus elit justo, ut egestas tellus molestie nec. Aliquam pretium tincidunt imperdiet. Praesent pellentesque libero vel eleifend tristique. In et magna quis velit ornare accumsan.Sed porta nulla at lacus hendrerit, quis volutpat velit elementum.Integer molestie velit ut sem condimentum, sit amet pretium velit gravida. Nam efficitur ornare posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Aliquam erat volutpat.Suspendisse auctor libero quam, nec fermentum libero dignissim in. Vestibulum quis lacus metus. Etiam ut turpis eu est porta malesuada.Morbi libero odio, consequat at ipsum at, sagittis vestibulum urna. Phasellus vel massa faucibus, luctus arcu nec, dapibus ex.In placerat, mi quis tincidunt iaculis, lectus tellus porttitor turpis, at mollis sem nibh eu arcu.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam ac ligula vitae elit faucibus lobortis ac et nibh. Mauris in risus vitae mauris scelerisque feugiat.Sed suscipit, elit viverra imperdiet dapibus, mi ante porta mauris, pretium blandit magna ex ut leo.Praesent pulvinar magna risus, sit amet euismod mi convallis sed.Nunc tortor mauris, ornare quis sagittis at, vestibulum a tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse sapien nisl, hendrerit posuere metus non, placerat facilisis magna. Proin sit amet ipsum felis.Vestibulum scelerisque, nibh nec ornare convallis, tellus lectus mollis augue, eget tempus massa nulla non dolor.Etiam porta euismod urna, vehicula porta lacus imperdiet ut. Suspendisse viverra ligula sit amet arcu suscipit pharetra. Nunc id erat bibendum nulla egestas tincidunt.Fusce gravida vitae augue eu tincidunt. Quisque in rhoncus turpis, vel dapibus metus. Donec vitae lobortis dolor. Sed porttitor hendrerit ipsum vel pharetra. Mauris vulputate, enim eu convallis lacinia, nisi tortor pulvinar lectus, at vulputate eros massa ac metus.Donec iaculis luctus condimentum. Integer mollis odio quis risus consequat blandit.Integer sit amet turpis ut libero sodales vestibulum. Aenean sem metus, interdum at interdum quis, congue malesuada neque. Praesent a augue est. Suspendisse rhoncus turpis ut nunc interdum aliquet.Proin vitae justo scelerisque, tincidunt ligula et, condimentum nisl.Nullam ut ex velit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Mauris tincidunt finibus nunc. Nunc diam risus, pulvinar id felis ac, accumsan luctus ipsum. Praesent nec leo a urna tincidunt hendrerit quis vel ligula.Praesent neque arcu, vulputate at lacinia sed, gravida sed nibh. Nullam accumsan et turpis et rhoncus. Curabitur condimentum tincidunt consectetur. Quisque egestas magna eu pretium gravida. Pellentesque venenatis laoreet ante, non lacinia ante varius vel. Sed id aliquam risus, vitae aliquam lorem. Nunc convallis placerat sapien eu malesuada. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Nulla lectus erat, mattis in magna ut, pellentesque laoreet ante. Phasellus commodo ligula ac ante pretium, facilisis vulpрорролро.";
        }

        public string GetLongTextTitle500()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque consectetur tempus ornare. Aliquam finibus ultrices sem, in bibendum magna convallis in. Aliquam vel posuere urna. Duis eleifend volutpat augue, sit amet fringilla sapien ullamcorper sit amet. Ut nec tristique lacus. Curabitur cursus lorem ornare leo placerat, ut congue neque condimentum. In hac habitasse platea dictumst. Donec lobortis, ante ut consequat dapibus, nisl lorem vestibulum diam, quis condimentum elit neque nec sem. Suspendisse libero augue, vulputate eu lorem in, condimentum tempor turpis. иру";
        }



















    }
}
