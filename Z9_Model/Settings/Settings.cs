using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Z9_Model
{
    public class Settings
    {
        private bool layoutSwitching;//Автоматическое переключения раскладки на пк

        public bool LayoutSwitching
        { get => layoutSwitching; set => layoutSwitching = value; }

        public Settings(SettingsReader settingsReader)
        {
            this.layoutSwitching = settingsReader.GetLayoutSwitching();
        }
    }
}
