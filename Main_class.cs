using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_bussbolag
{
    public class Main_class
    {
        private static String host = "195.178.235.60";
        private static String user = "ad3852";
        private static String pass = "1917Lacan";
        private static String db = "ad3852";
        public static String connStr = "server=" + host + ";uid=" + user + ";pwd=" + pass + ";database=" + db + ";";
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();

            Application.Run(form);

            Console.Read();
        }
    }
}
