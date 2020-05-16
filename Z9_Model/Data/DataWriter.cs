using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Z9_Model
{
    public class DataWriter
    {
        public void WriteInFile(Data data)
        {
            File.WriteAllLines("Settings.txt", new string[]{
            $"layoutSwitching = {data.LayoutSwitching.ToString()}"
            });
        }
    }
}
