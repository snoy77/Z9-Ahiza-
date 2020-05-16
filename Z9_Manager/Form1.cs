using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z9_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            checkBox1.Checked = Program.data.LayoutSwitching;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.data.LayoutSwitching = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.dataWriter.WriteInFile(Program.data);
        }
    }
}
