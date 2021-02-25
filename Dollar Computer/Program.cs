using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollar_Computer
{
    static class Program
    {
        public static StartForm startform;
        public static Select select;
        public static ProductInfo productinfo;
        public static Class1 cc;
        public static Billing bill;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startform = new StartForm();
            select = new Select();
            cc = new Class1();
            bill = new Billing();
            productinfo = new ProductInfo();
            Application.Run(new SplashForm());
        }
    }
}
