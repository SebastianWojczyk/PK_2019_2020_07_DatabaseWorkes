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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Worker workerToSave = null;
            //edycja
            if (listBoxWorkes.SelectedItems.Count == 1)
            {
                listBoxWorkes.Enabled = true;
                workerToSave = listBoxWorkes.SelectedItem as Worker;
            }
            //dodawanie
            else
            {
                workerToSave = new Worker();
                DatabaseDC.Workers.InsertOnSubmit(workerToSave);
            }

            workerToSave.FirstName = textBoxFirstName.Text;
            workerToSave.LastName = textBoxLastName.Text;
            workerToSave.DateBegin = dateTimePickerDateBegin.Value;
            workerToSave.Salary = numericUpDownSalary.Value;
            workerToSave.Manager = checkBoxManager.Checked;

            DatabaseDC.SubmitChanges();

            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerDateBegin.Value = DateTime.Today;
            numericUpDownSalary.Value = 0m;
            checkBoxManager.Checked = false;

            LoadWorkers();
        }

        private void listBoxWorkes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxWorkes.SelectedItems.Count==1)
            {
                listBoxWorkes.Enabled = false;
                buttonSave.Text = "Zmień";

                Worker selectedWorker = listBoxWorkes.SelectedItem as Worker;

                textBoxFirstName.Text = selectedWorker.FirstName;
                textBoxLastName.Text = selectedWorker.LastName;
                dateTimePickerDateBegin.Value = selectedWorker.DateBegin;
                numericUpDownSalary.Value = selectedWorker.Salary;
                checkBoxManager.Checked = selectedWorker.Manager;
            }
        }
    }
}
