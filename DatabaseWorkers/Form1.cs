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
            listBoxWorkes.Items.Clear();
            foreach (Worker w in DatabaseDC.Workers)
            {
                listBoxWorkes.Items.Add(w);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Worker newWorker = new Worker();
            newWorker.FirstName = textBoxFirstName.Text;
            newWorker.LastName = textBoxLastName.Text;
            newWorker.DateBegin = dateTimePickerDateBegin.Value;
            newWorker.Salary = numericUpDownSalary.Value;
            newWorker.Manager = checkBoxManager.Checked;

            DatabaseDC.Workers.InsertOnSubmit(newWorker);
            DatabaseDC.SubmitChanges();

            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerDateBegin.Value = DateTime.Today;
            numericUpDownSalary.Value = 0m;
            checkBoxManager.Checked = false;

            LoadWorkers();
        }
    }
}
