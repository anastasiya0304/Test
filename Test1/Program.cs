using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;

namespace MMC_tests
{
    class Program
    {
        

        static void Main(string[] args)
        {
    
        }

        /// <summary>
        /// ЭЛЕКТРОННЫЕ СЕРВИСЫ ММЦ
        /// </summary>
        
        
        
       //Узнать статус заявления на патент
        [Test]
        public void StatusPatent()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.client/worker/worker-main");
            Electronic_Services page = new Electronic_Services();
            page.StatusPatent("1381161");
            System.Threading.Thread.Sleep(3000);
            PropertiesCollection.driver.Close();
        }

        //Узнать необходимость оплаты НДФЛ
        [Test]
        public void NeedPaymentNDFL()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.client/worker/worker-main");
            Electronic_Services page = new Electronic_Services();
            page.NeedPaymentNDFL("77", "1602219176");
            System.Threading.Thread.Sleep(3000);
            PropertiesCollection.driver.Close();
        }

        //Узнать ИНН по номеру заявления на петент
        [Test]
        public void INN_Statement()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.client/worker/worker-main");
            Electronic_Services page = new Electronic_Services();
            page.INN("1282059","");
            System.Threading.Thread.Sleep(3000);
            PropertiesCollection.driver.Close();
        }

        //Узнать ИНН по номеру телефона
        [Test]
        public void INN_Telefon()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.client/worker/worker-main");
            Electronic_Services page = new Electronic_Services();
            page.INN("", "9660717550");
            System.Threading.Thread.Sleep(3000);
            PropertiesCollection.driver.Close();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// АДМИНКА НОВОСТИ 
        /// </summary>

        [Test]
        public void ADDNewsandDelete()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.admin/auth/login");

            Authorization login = new Authorization();
            News page = login.Login("admin","admin");                                           
            System.Threading.Thread.Sleep(2000);
            page.BtnNews.Click();
            page.CreatNews("авг", "123", "Сейчас будет проходить тестирование новостей", "ТЕСТИРОВАНИЕ 1 2 3");
            System.Threading.Thread.Sleep(3000);
            
            page.DeleteLastNews.Click();
            System.Threading.Thread.Sleep(2000);
            PropertiesCollection.driver.Close();
        }
        /// <summary>
        /// Проверка работы функционала "Добавить новость" с заголовком в 500 символов
        /// </summary>
        [Test]
        public void News500Title()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.admin/auth/login");

            var login = new Authorization();
            var page = login.Login("", "");

            page.BtnNews.Click();
            page.CreatNews(page.GetLongTextTitle500(), "100", "Сейчас будет проходить тестирование новостей", "ТЕСТИРОВАНИЕ 1 2 3");
            System.Threading.Thread.Sleep(2000);

            page.DeleteLastNews.Click();
            System.Threading.Thread.Sleep(2000);
            PropertiesCollection.driver.Close();
        }
        /// <summary>
        /// Проверка работы функционала "Добавить новость" с краткой историей в 5000 символов
        /// </summary>
        [Test]
        public void News5000ShortContent()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.admin/auth/login");

            Authorization login = new Authorization();
            News page = login.Login("admin", "admin");
            System.Threading.Thread.Sleep(2000);
            page.BtnNews.Click();
            page.CreatNews("Внимание", "123", page.GetLongTextShortContent5000(), "ТЕСТИРОВАНИЕ 1 2 3");
            System.Threading.Thread.Sleep(2000);

            page.DeleteLastNews.Click();
            System.Threading.Thread.Sleep(2000);
            PropertiesCollection.driver.Close();
        }
        
        /// <summary>
        /// Добавление новости и ее редактирование
        /// </summary>
        [Test]
        public void New_Editing()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://mmc-dev.it2g.ru/web.admin/auth/login");

            Authorization login = new Authorization();
            News page3 = login.Login("admin", "admin");

            page3.BtnNews.Click();
            page3.CreatNews("Внимание", "1001", "Сейчас будет проходить тестирование новостей", "ТЕСТИРОВАНИЕ 1 2 3");
            System.Threading.Thread.Sleep(2000);


            page3.EditingLastNew("Внимание!", "700", "Сейчас будет проходить тестирование новостей!", "Редактирование");
            System.Threading.Thread.Sleep(2000);
            page3.DeleteLastNews.Click();
            System.Threading.Thread.Sleep(2000);

            PropertiesCollection.driver.Close();
        }


        /// <summary>
        /// Добавление длинного текста для проверки счетчика символов
        /// </summary>
        private string GetLongTextShortContent5000()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque consectetur tempus ornare. Aliquam finibus ultrices sem, in bibendum magna convallis in. Aliquam vel posuere urna. Duis eleifend volutpat augue, sit amet fringilla sapien ullamcorper sit amet. Ut nec tristique lacus. Curabitur cursus lorem ornare leo placerat, ut congue neque condimentum. In hac habitasse platea dictumst. Donec lobortis, ante ut consequat dapibus, nisl lorem vestibulum diam, quis condimentum elit neque nec sem. Suspendisse libero augue, vulputate eu lorem in, condimentum tempor turpis.Phasellus pulvinar nibh eu odio dapibus porttitor.Vivamus molestie, nibh non ultricies mollis, lorem est varius neque, vel sollicitudin elit eros et leo.Aliquam molestie suscipit consequat. In hac habitasse platea dictumst.Pellentesque accumsan laoreet sagittis. Phasellus commodo nibh et imperdiet sollicitudin. Suspendisse luctus velit at justo sodales maximus non at felis. Mauris sed magna at nisl fringilla dapibus.Nullam aliquam felis non pulvinar eleifend.Phasellus elementum rutrum feugiat. Pellentesque consectetur purus volutpat lacus tincidunt, quis porta purus hendrerit.Nam laoreet purus sit amet venenatis mollis.Donec faucibus, purus eget lacinia euismod, ipsum quam tincidunt mauris, sit amet tristique tellus ligula vitae tellus. In elementum scelerisque suscipit. Donec ut lectus ornare, consectetur arcu nec, laoreet odio.Nullam egestas neque eu malesuada rutrum. Donec iaculis id purus ac lacinia. Praesent purus neque, pellentesque vitae dapibus a, finibus dictum turpis. Etiam vitae scelerisque nunc, non egestas nibh. Morbi varius, risus quis fermentum sodales, felis neque suscipit eros, id lacinia tortor dolor sit amet ex. Integer nec fermentum dolor.Ut consequat fermentum libero at viverra. Nunc lobortis massa nec tellus fermentum, ut porta nunc maximus.Duis pharetra nunc urna, eget gravida dui auctor sit amet.Nullam euismod massa sit amet cursus mattis.Pellentesque et libero non diam iaculis dapibus.Nam quis congue risus, quis mattis est. Donec pellentesque ligula suscipit quam sollicitudin fermentum.Fusce egestas varius ante non malesuada. Nullam tincidunt lectus quis dolor aliquet, eu efficitur libero scelerisque.Curabitur fringilla rutrum cursus. Duis consequat aliquam pellentesque. Morbi sollicitudin tellus mollis tempus bibendum. Donec rhoncus luctus ex, quis pellentesque nisi sollicitudin vitae. Quisque et tellus felis. Cras semper neque et nisl molestie, non lacinia quam faucibus.Praesent et blandit odio.Ut non varius est, vel placerat est. Vestibulum venenatis nunc luctus elementum posuere. Mauris rutrum lacus ac mi gravida tincidunt.Quisque eget est felis. Duis cursus elit justo, ut egestas tellus molestie nec. Aliquam pretium tincidunt imperdiet. Praesent pellentesque libero vel eleifend tristique. In et magna quis velit ornare accumsan.Sed porta nulla at lacus hendrerit, quis volutpat velit elementum.Integer molestie velit ut sem condimentum, sit amet pretium velit gravida. Nam efficitur ornare posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Aliquam erat volutpat.Suspendisse auctor libero quam, nec fermentum libero dignissim in. Vestibulum quis lacus metus. Etiam ut turpis eu est porta malesuada.Morbi libero odio, consequat at ipsum at, sagittis vestibulum urna. Phasellus vel massa faucibus, luctus arcu nec, dapibus ex.In placerat, mi quis tincidunt iaculis, lectus tellus porttitor turpis, at mollis sem nibh eu arcu.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam ac ligula vitae elit faucibus lobortis ac et nibh. Mauris in risus vitae mauris scelerisque feugiat.Sed suscipit, elit viverra imperdiet dapibus, mi ante porta mauris, pretium blandit magna ex ut leo.Praesent pulvinar magna risus, sit amet euismod mi convallis sed.Nunc tortor mauris, ornare quis sagittis at, vestibulum a tellus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse sapien nisl, hendrerit posuere metus non, placerat facilisis magna. Proin sit amet ipsum felis.Vestibulum scelerisque, nibh nec ornare convallis, tellus lectus mollis augue, eget tempus massa nulla non dolor.Etiam porta euismod urna, vehicula porta lacus imperdiet ut. Suspendisse viverra ligula sit amet arcu suscipit pharetra. Nunc id erat bibendum nulla egestas tincidunt.Fusce gravida vitae augue eu tincidunt. Quisque in rhoncus turpis, vel dapibus metus. Donec vitae lobortis dolor. Sed porttitor hendrerit ipsum vel pharetra. Mauris vulputate, enim eu convallis lacinia, nisi tortor pulvinar lectus, at vulputate eros massa ac metus.Donec iaculis luctus condimentum. Integer mollis odio quis risus consequat blandit.Integer sit amet turpis ut libero sodales vestibulum. Aenean sem metus, interdum at interdum quis, congue malesuada neque. Praesent a augue est. Suspendisse rhoncus turpis ut nunc interdum aliquet.Proin vitae justo scelerisque, tincidunt ligula et, condimentum nisl.Nullam ut ex velit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Mauris tincidunt finibus nunc. Nunc diam risus, pulvinar id felis ac, accumsan luctus ipsum. Praesent nec leo a urna tincidunt hendrerit quis vel ligula.Praesent neque arcu, vulputate at lacinia sed, gravida sed nibh. Nullam accumsan et turpis et rhoncus. Curabitur condimentum tincidunt consectetur. Quisque egestas magna eu pretium gravida. Pellentesque venenatis laoreet ante, non lacinia ante varius vel. Sed id aliquam risus, vitae aliquam lorem. Nunc convallis placerat sapien eu malesuada. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Nulla lectus erat, mattis in magna ut, pellentesque laoreet ante. Phasellus commodo ligula ac ante pretium, facilisis vulpрорролро.";
        }

        private string GetLongTextTitle500()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque consectetur tempus ornare. Aliquam finibus ultrices sem, in bibendum magna convallis in. Aliquam vel posuere urna. Duis eleifend volutpat augue, sit amet fringilla sapien ullamcorper sit amet. Ut nec tristique lacus. Curabitur cursus lorem ornare leo placerat, ut congue neque condimentum. In hac habitasse platea dictumst. Donec lobortis, ante ut consequat dapibus, nisl lorem vestibulum diam, quis condimentum elit neque nec sem. Suspendisse libero augue, vulputate eu lorem in, condimentum tempor turpis. иру";
        }


    }
}
