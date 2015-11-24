using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acIDS
{
    public partial class ExpertMenuHids : Form
    {
        private Monitor _cpu;
        private Monitor _ram;
        private Monitor _process;
        
        public ExpertMenuHids(Monitor cpu, Monitor ram, Monitor process)
        {
            _cpu = cpu;
            _ram = ram;
            _process = process;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
