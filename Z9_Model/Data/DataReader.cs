using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Dynamic;

namespace Z9_Model
{
    public class DataReader
    {
        public string FileSetting = "Settings.txt";
        
        public string GetLayoutFolder()//Читаем первую строку - папка с "парами"
        {
            return TakeOnlyValue(File.ReadAllLines(FileSetting)[0]);
        }
        public bool GetLayoutSwitching()//Читаем вторую строку - надобность 
                                        //автоматического переключения раскладки
        {
            return Boolean.Parse(TakeOnlyValue(File.ReadAllLines(FileSetting)[1]));
        }
        public List<string[,]> GetListsofCouples()//Возвращает списоки пар
        {
            string[] LsitofNamesCouples = File.ReadAllLines("ActiveCouples");

        }

        private string TakeOnlyValue(string strValue)//Извлечение значения из строки
        {
            return strValue.Substring(strValue.IndexOf('=')+2);
        }
    }
}
