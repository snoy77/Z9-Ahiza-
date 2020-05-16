using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Z9_Model
{
    public class SettingsWriter
    {
        public void WriteInFile(Settings settings)
        {
            File.WriteAllLines("Settings.txt", new string[]{
            $"layoutSwitching = {settings.LayoutSwitching.ToString()}"
            });
        }
    }
}
