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
        public ExpertMenuHids(Monitor cpu, Monitor ram, Monitor process)
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
