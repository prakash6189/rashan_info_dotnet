using ConnectCsharpToMysql;
using Rashan_Form.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashan_Form
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConnect.Initialize();
            string macAddress = GenericUtils.GetMACAddress();
            string checkMacAddressInDb = "SELECT Passcode FROM passcode_information where Mac_Address='"+macAddress+"' and IsActive=1";
            List<object> returnArray = DBConnect.SelectSingleColumnProgram(checkMacAddressInDb, "Passcode");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (returnArray != null)
            {
                if (returnArray.Count > 0)
                    Application.Run(new Home(returnArray[0].ToString()));
                else
                    Application.Run(new Registration(macAddress));
            }



        }
    }
}
