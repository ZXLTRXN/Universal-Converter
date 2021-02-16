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
        Logic.History his;
        public HistoryForm()
        {
            InitializeComponent();
        }

        public HistoryForm(Logic.History his)
        {
            InitializeComponent();
            this.his = his;
            for (int i = 0; i < this.his.Count(); i++)
            {
                listBox1.Items.Add(this.his.GetRecord(i).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            his.Clear();
            listBox1.Items.Clear();
        }
    }
}
