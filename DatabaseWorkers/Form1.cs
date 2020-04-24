using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseWorkers
{
    public partial class Form1 : Form
    {
        DatabaseWorkersDataContext DatabaseDC = new DatabaseWorkersDataContext();
        public Form1()
        {
            InitializeComponent();
            LoadWorkers();

            //listBoxWorkes.DisplayMember = "FirstName";
        }

        private void LoadWorkers()
        {
            foreach(Worker w in DatabaseDC.Workers)
            {
                listBoxWorkes.Items.Add(w);
            }
        }
    }
}
