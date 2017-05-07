using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoa.UI
{
    public partial class Index : Form
    {
        int defaultTab;

        public Index()
        {
            InitializeComponent();
            panel1.Controls.Add(new Hill());
            defaultTab = 1;//default hill cypher selected
        }

        private void hillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (defaultTab == 1) return;
            panel1.Controls.Add(new Hill());
        }
    }
}
