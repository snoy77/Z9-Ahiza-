using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9_Model
{
    //Переводит текст на другую раскладку, указанную в Data
    public class Translator
    {
        private string stringForTranslation = null;//Строка, которую нужно первести (для автоматизации)
        private Data myData = null;//объект Data, к которому будет ссылаться переводчик (для автоматизации)

        public string StringForTranslation { get => stringForTranslation; set => stringForTranslation = value; }
        public Data MyData { get => myData; set => myData = value; }

        public string TranslateString()
        {
            //return this.TranslateString(this.StringForTranslation, this.MyData);
        }
        public string TranslateString(string value, Data data)//Переводит текст "value" на другую раскладку
        {
            return "";
        }

        //private string[] StrokaRsbiv(string value, Data data)
        //{
        //    Dictionary<int, string> a = new Dictionary<int, string>();

        //    foreach (string[,] el in data.ListsOfCouples)
        //    {
        //        for (int i = 0; i < el.Length / 2; i++)
        //        {

        //            while (value.Contains(el[i, 0]))
        //            {
        //                int ind = value.IndexOf(el[i, 0]);
        //                a.Add(ind, el[i, 0]);
        //            }
        //        }
        //    }
        //    return new string[] { };
        //}
        //private int[] getIndexesOf(string value, string symvol)
        //{
        //    List<int> result = new List<int>();

        //    int res_index = value.IndexOf(symvol);

        //    while (res_index != -1)
        //    {
        //        result.Add(res_index);
        //        res_index = value.IndexOf(symvol,res_index);
        //    }
        //    return result.ToArray();
        //}

        //КОНСТРУКТОРЫ
        public Translator(string stringForTranslation, Data data)
        {
            this.StringForTranslation = stringForTranslation;
            this.MyData = myData;
        }
        public Translator() { }
    }
}

//Добавил:
// 1) Объявил новые переменные для удобства пользования объектом.
// 2) Написал конструкторы
