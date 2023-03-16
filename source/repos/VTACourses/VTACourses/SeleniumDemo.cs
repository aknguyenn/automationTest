using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using System.Threading;
using OpenQA.Selenium.DevTools.V108.DOMSnapshot;

namespace VTACourses
{
    [TestFixture]
    public class SeleniumDemo
    {


        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://swm-test.smartlogvn.com/login");
        }

        //[TearDown]
        ////public void TeardownTest()
        ////{
        ////    driver.Quit();
        ////}

        public void loginAndChangeWareHouse(string user,string pass,string wareHouse)
        {
            // Nhập tên đăng nhập và mật khẩu
            IWebElement username = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Name("password"));
            username.SendKeys($"{user}");
            password.SendKeys($"{pass}");        
            IWebElement signIn = driver.FindElement(By.XPath("//button[@class='btn btn-sm btn-primary btn-block mt-3 mb-3']"));
            signIn.Click();
            WaitForElementToBeClickable(driver, By.XPath("//a[@data-cy='menu-warehouse-name']"));
            IWebElement WH = driver.FindElement(By.XPath("//a[@data-cy='menu-warehouse-name']"));
            WH.Click();
            WaitForElementToBeClickable(driver, By.XPath($"//a[@data-cy='menu-warehouse-{wareHouse}']"));
            IWebElement changeWH = driver.FindElement(By.XPath($"//a[@data-cy='menu-warehouse-{wareHouse}']"));
            changeWH.Click();
            IWebElement confirm = driver.FindElement(By.XPath("//button[@class='swal2-confirm swal2-styled']"));
            confirm.Click();
            //WaitForElementToBeClickable(driver, By.XPath("//a/span[text()='INBOUND']"));
            //IWebElement INBOUND = driver.FindElement(By.XPath("//a/span[text()='INBOUND']"));
            //INBOUND.Click();
            //WaitForElementToBeClickable(driver, By.XPath("//a/span[text()='TASK DETAIL']"));
            //IWebElement purchaseOrder = driver.FindElement(By.XPath("//a/span[text()='TASK DETAIL']"));
            //purchaseOrder.Click();
        }
        public void openDashBoard()
        {
            WaitForElementToBeClickable(driver, By.XPath("//a/span[text()='DASHBOARD']"));
            IWebElement dashBoard = driver.FindElement(By.XPath("//a/span[text()='DASHBOARD']"));
            dashBoard.Click();
            Thread.Sleep(3000);
        }
        public void openReport()
        {
            IWebElement report = driver.FindElement(By.XPath("//a/span[text()='REPORT']"));
            report.Click();
            Thread.Sleep(3000);
        }
        public void openDockScheduling()
        {
            IWebElement dockScheduling = driver.FindElement(By.XPath("//a/span[text()='DOCK SCHEDULING']"));
            dockScheduling.Click();
            driver.FindElement(By.XPath("//a/span[text()='CHECK IN']")).Click();
            Thread.Sleep(3000);
            dockScheduling.Click();
            driver.FindElement(By.XPath("//a/span[text()='DOCK MANAGEMENT']")).Click();
            Thread.Sleep(3000);
            dockScheduling.Click();
            driver.FindElement(By.XPath("//a/span[text()='APPOINTMENT']")).Click();
            Thread.Sleep(3000);
            dockScheduling.Click();
            driver.FindElement(By.XPath("//a/span[text()='TRUCK DECLARATION']")).Click();
            Thread.Sleep(3000);
            dockScheduling.Click();
            driver.FindElement(By.XPath("//a/span[text()='TRUCK MANAGEMENT']")).Click();
            Thread.Sleep(3000);
        }
        public void openInbound()
        {
            IWebElement inbound = driver.FindElement(By.XPath("//a/span[text()='INBOUND']"));
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='PURCHASE ORDER']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='ASN/RECEIPT']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='TASK DETAIL']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND REPORT']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND REPORT SUMMARY']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='ONE VIEW RECEIPT']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='RECEIPT CFS']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='PALLETIZATION']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='DECLARATION']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='RECEIVINGPLAN']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='PO TRACKING']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='POD INBOUND']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='MASTER RECEIPT']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='IMEI TRACKING']")).Click();
            Thread.Sleep(3000);
            inbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND DOCUMENT']")).Click();
            Thread.Sleep(3000);
        }
        public void openOutbound()
        {
            IWebElement outbound = driver.FindElement(By.XPath("//a/span[text()='OUTBOUND']"));
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='MASTER PICK']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='MASTER SHIP']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='SHIPMENT ORDER']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='PICK DETAIL']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='PICK DETAIL BY MASTERPICK']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='OUTBOUND REPORT']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='OUTBOUND REPORT SUMMARY']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='BOOKING']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='CONTAINER MANAGEMENT']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='BOOKING CARRIER']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='ONE VIEW SO']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='POD OUTBOUND']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='SALE ORDER']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='SALE ORDER TRACKING']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='PRE ALLOCATE DETAIL']")).Click();
            Thread.Sleep(3000);
            outbound.Click();
            driver.FindElement(By.XPath("//a/span[text()='OUTBOUND REPORT PREALLOCATE']")).Click();
            Thread.Sleep(3000);
        }
        public void openInventory()
        {
            IWebElement inventory = driver.FindElement(By.XPath("//a/span[text()='INVENTORY']"));
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY LIST']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY LIST CFS']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY WARNING']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY REPORT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY HOLD LIST']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='MOVE']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='ADJUSTMENT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='CHANGE STATUS']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='CHANGE LOT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='TRANSACTION']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='STOCK COUNT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='POST STOCK']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='PREMOVE']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INTERNAL TRANSFER']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='DETAIL STORAGE']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='GOODS REPORT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='STORAGE CHARGE']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='REPLENISHMENT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTOY SUMMARY']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='STORAGE CHARGE TIME']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='POST STOCK TIME']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='COMPARE INVT SOLOMON SML']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY TRACKING']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='TRANSFER INFORMATION']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='IN OUT REPORT LIST']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY PREALLOCATE']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='PICKFACE PALLET REPORT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='PREMOVE REPORT']")).Click();
            Thread.Sleep(3000);
            inventory.Click();
            driver.FindElement(By.XPath("//a/span[text()='TRANSFER REPORT LIST']")).Click();
            Thread.Sleep(3000);
        }
        public void openBilling()
        {
            IWebElement billing = driver.FindElement(By.XPath("//a/span[text()='BILLING']"));
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='STORAGE CHARGE TIME']")).Click();
            Thread.Sleep(3000);
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='STORAGE CHARGE BILLING']")).Click();
            Thread.Sleep(3000);
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='BILLING LIST']")).Click();
            Thread.Sleep(3000);
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='DEBIT NOTE']")).Click();
            Thread.Sleep(3000);
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='DEBIT TOTAL AMOUNT']")).Click();
            Thread.Sleep(3000);
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='DEBIT AMOUNT UPDATE']")).Click();
            Thread.Sleep(3000);
            billing.Click();
            driver.FindElement(By.XPath("//a/span[text()='BILLING FEE']")).Click();
            Thread.Sleep(3000);
        }
        public void openVisualization()
        {
            IWebElement visualization = driver.FindElement(By.XPath("//a/span[text()='VISUALIZATION']"));
            visualization.Click();
            driver.FindElement(By.XPath("//a/span[text()='CREATE VISUALIZATION']")).Click();
            Thread.Sleep(3000);
            visualization.Click();
            driver.FindElement(By.XPath("//a/span[text()='VISUALIZATION']")).Click();
            Thread.Sleep(3000);
            visualization.Click();
            driver.FindElement(By.XPath("//a/span[text()='TRUCK']")).Click();
            Thread.Sleep(3000);
        }
        public void openCofiguration()
        {
            IWebElement configuration = driver.FindElement(By.XPath("//a/span[text()='CONFIGURATION']"));
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='CUSTOMER GROUP']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='CUSTOMER']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='DESTINATION']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='SHIP & DESTINATION']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='PACK']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='CARRIER']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='LINE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='SUPPLIER']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='NOTIFY PARTY']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='ALLOCATE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='PUTAWAY']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='REPLENISHMENT']")).Click();
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='SYSTEM CODE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='ITEM']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='VALIDATION LIST']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='BOM']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='DOCK']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='VESSEL']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='PORTS']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='SHIPPINGLINE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='REPLENISHMENTSKU']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='ALTSKU']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='GROUPSKU']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='FACTORY FILE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='PICK STRATEGY']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='PRE ALLOCATE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='CONT/SEAL']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='VAS']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='BUNDLE']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='MASTERPICK']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='SKU DETAIL']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='NOTIFICATIONCONFIG']")).Click();
            Thread.Sleep(3000);
            configuration.Click();
            driver.FindElement(By.XPath("//a/span[text()='NOTIFICATION USER']")).Click();
            Thread.Sleep(3000);
        }
        public void openStatistics()
        {
            IWebElement statistic = driver.FindElement(By.XPath("//a/span[text()='STATISTICS']"));
            statistic.Click();
            driver.FindElement(By.XPath("//a/span[text()='INVENTORY']")).Click();
            Thread.Sleep(3000);
            statistic.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND REPORT']")).Click();
            Thread.Sleep(3000);
            statistic.Click();
            driver.FindElement(By.XPath("//a/span[text()='OUTBOUND REPORT']")).Click();
            Thread.Sleep(3000);
            statistic.Click();
            driver.FindElement(By.XPath("//a/span[text()='OUTBOUND QTY USED']")).Click();
            Thread.Sleep(3000);
            statistic.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND BY SUPPLIER']")).Click();
            Thread.Sleep(3000);
            statistic.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND REPORT PRODUCTION TOTAL']")).Click();
            Thread.Sleep(3000);
        }
        public void openLabor()
        {
            IWebElement labor = driver.FindElement(By.XPath("//a/span[text()='LABOR']"));
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='PRODUCTIVITY']")).Click();
            Thread.Sleep(3000);
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='PRODUCTIVITY REPORT']")).Click();
            Thread.Sleep(3000);
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='LABOR GROUP']")).Click();
            Thread.Sleep(3000);
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='LABOR EMPLOYEE']")).Click();
            Thread.Sleep(3000);
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='LABOR TEAM']")).Click();
            Thread.Sleep(3000);
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='LABOR GROUP STORER']")).Click();
            Thread.Sleep(3000);
            labor.Click();
            driver.FindElement(By.XPath("//a/span[text()='LABOR PRODUCTIVITY REPORT']")).Click();
            Thread.Sleep(3000);
        }
        public void openQcVerify()
        {
            IWebElement qcVerify = driver.FindElement(By.XPath("//a/span[text()='QCVERIFY']"));
            qcVerify.Click();
            driver.FindElement(By.XPath("//a/span[text()='QC VERIFY']")).Click();
            Thread.Sleep(3000);
            qcVerify.Click();
            driver.FindElement(By.XPath("//a/span[text()='INBOUND QC']")).Click();
            Thread.Sleep(3000);
            qcVerify.Click();
            driver.FindElement(By.XPath("//a/span[text()='OUTBOUND QC']")).Click();
            Thread.Sleep(3000);
            qcVerify.Click();
            driver.FindElement(By.XPath("//a/span[text()='QR TRACKING']")).Click();
            Thread.Sleep(3000);
            qcVerify.Click();
            driver.FindElement(By.XPath("//a/span[text()='QR TRACKINGHISTORY']")).Click();
            Thread.Sleep(3000);
        }
        public void openTask()
        {
            IWebElement task = driver.FindElement(By.XPath("//a/span[text()='TASK']"));
            task.Click();
        }
        public void openTaskManagement()
        {
            IWebElement taskManagement = driver.FindElement(By.XPath("//a/span[text()='TASK MANAGEMENT']"));
            taskManagement.Click();
            driver.FindElement(By.XPath("//a/span[text()='TASK MANAGER']")).Click();
            Thread.Sleep(3000);
            taskManagement.Click();
            driver.FindElement(By.XPath("//a/span[text()='WORKER GROUP']")).Click();
            Thread.Sleep(3000);
            taskManagement.Click();
            driver.FindElement(By.XPath("//a/span[text()='WORKER TEAM']")).Click();
            Thread.Sleep(3000);
            taskManagement.Click();
            driver.FindElement(By.XPath("//a/span[text()='PRODUCTIVITY REPORT TASKG']")).Click();
            Thread.Sleep(3000);
        }
        public void openProduction()
        {
            IWebElement production = driver.FindElement(By.XPath("//a/span[text()='PRODUCTION']"));
            production.Click();
            driver.FindElement(By.XPath("//a/span[text()='PRODUCTION TRACKING']")).Click();
            Thread.Sleep(3000);
            production.Click();
            driver.FindElement(By.XPath("//a/span[text()='QR CODE TRACKING']")).Click();
            Thread.Sleep(3000);
        }
        public void openConfigBilling()
        {
            IWebElement configBilling = driver.FindElement(By.XPath("//a/span[text()='CONFIG BILLING']"));
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='CHARGE TYPE']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='UOM']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='CONDITION']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='DATE TYPE']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='BILLING DATE']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='BILLING CONFIG DATE']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='CATEGORY CONFIG']")).Click();
            Thread.Sleep(3000);
            configBilling.Click();
            driver.FindElement(By.XPath("//a/span[text()='DEBITNOTE FILES']")).Click();
            Thread.Sleep(3000);
        }
        public void openVas()
        {
            IWebElement vas = driver.FindElement(By.XPath("//a/span[text()='VAS']"));
            vas.Click();
            driver.FindElement(By.XPath("//a/span[text()='LABELING']")).Click();
            Thread.Sleep(3000);
            vas.Click();
            driver.FindElement(By.XPath("//a/span[text()='PACKAGING']")).Click();
            Thread.Sleep(3000);
            vas.Click();
            driver.FindElement(By.XPath("//a/span[text()='BUNDLE']")).Click();
            Thread.Sleep(3000);
            vas.Click();
            driver.FindElement(By.XPath("//a/span[text()='VAS']")).Click();
            Thread.Sleep(3000);
        }
        public void openFiveView()
        {
            openDashBoard();
            openReport();
            openDockScheduling();
            openInbound();
            openOutbound();
        }
        public void open5View()
        {
            openInventory();
            openBilling();
            openVisualization();
            openCofiguration();
            openStatistics();
        }
        public void openFineView()
        {
            openLabor();
            openQcVerify();
            openTask();
            openTaskManagement();
            openProduction();
            openConfigBilling();
            openVas();
        }
        
        
            public static void WaitForElementToBeClickable(IWebDriver driver, By locator)
        {
            var waitTime = TimeSpan.FromSeconds(20);
            var startTime = DateTime.Now;

            while ((DateTime.Now - startTime) < waitTime)
            {
                try
                {
                    var element = driver.FindElement(locator);
                    if (element.Enabled && element.Displayed)
                    {
                        return;
                    }
                }
                catch
                {
                    // Do nothing
                }
            }

            throw new TimeoutException($"Element located by {locator} was not clickable within {waitTime.TotalSeconds} seconds.");
        }
        [Test]
        public void smokeTest(/*string user,string pass,string wareHouse*/)
        {
            loginAndChangeWareHouse("tbs-qa", "123", "KHO6_DC");
            
            openFiveView();
        }
        [Test]
        public void smokeTest1(/*string user,string pass,string wareHouse*/)
        {
            loginAndChangeWareHouse("tbs-qa", "123", "KHO6_DC");     
            open5View();
        }
        [Test]
        public void smokeTest2(/*string user,string pass,string wareHouse*/)
        {
            loginAndChangeWareHouse("tbs-qa", "123", "KHO6_DC");
            openFineView();
        }
    }
}
