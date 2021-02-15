using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalConverter
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            Logic.Control_ ctl = this.Owner.;
            Logic.History his = ctl.his;
            for (int i = 0; i < his.Count(); i++)
            {
                listBox1.Items.Add(his.GetRecord(i).ToString());
            }
        }


    }
}
