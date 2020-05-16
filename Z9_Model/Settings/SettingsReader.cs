using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Z9_Model
{
    public class SettingsReader
    {
        public string FileSetting = "Settings.txt";

        public bool GetLayoutSwitching()//Читаем вторую строку - надобность 
                                        //автоматического переключения раскладки
        {
            return Boolean.Parse(TakeOnlyValue(File.ReadAllLines(FileSetting)[1]));
        }

        private string TakeOnlyValue(string strValue)//Извлечение значения из строки
        {
            return strValue.Substring(strValue.IndexOf('=') + 2);
        }
    }
}
