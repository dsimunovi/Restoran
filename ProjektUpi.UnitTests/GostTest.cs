using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Web;
using ProjektUpi;


namespace ProjektUpi.UnitTests
{
    [TestClass]
    public class GostTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\38599\OneDrive\Desktop\UpiPr\ToniMarkovicc\ProjektUpi\Baza\Database1.mdf;Integrated Security=True","Osoblje_Table")]
        [TestMethod]
        public void ProvjeraSpojaNaBazu()
        {
            var target = new Prijava();

            //Access the data
            string username = TestContext.DataRow["OsobljeIme"].ToString();
            string password = TestContext.DataRow["OsobljePassword"].ToString();

            string expuser = "toni";
            string expass = "12345";

            Assert.AreEqual(password, expass);


        }


    }
}
