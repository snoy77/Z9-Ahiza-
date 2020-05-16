using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Z9_Model;
namespace Z9_Manager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        static public DataReader dataReader;
        static public DataWriter dataWriter;
        static public Data data;

        [STAThread]
        static void Main()
        {
            dataReader = new DataReader();
            dataWriter = new DataWriter();
            data = new Data(dataReader);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
