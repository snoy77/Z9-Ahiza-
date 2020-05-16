using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9_Model
{
    public class Data
    {
        private bool layoutSwitching;//Автоматическое переключения раскладки на пк
        private string layoutFolder;//Папка с раскладками программы

        public bool LayoutSwitching 
        { get => layoutSwitching; set => layoutSwitching = value; }
        public string LayoutFolder 
        { get => layoutFolder; set => layoutFolder = value; }

        public List<string[,]> 



        public Data(DataReader dataReader)
        {
            this.layoutSwitching = dataReader.GetLayoutSwitching();
            this.layoutFolder = dataReader.GetLayoutFolder();
        }
    }
}
