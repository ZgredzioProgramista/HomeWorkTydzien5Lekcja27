using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomeWorkTydzien5Lekcja27
{
    public partial class mainForm : Form
    {
        private string _filePath =
            Path.Combine(Environment.CurrentDirectory, "dane.txt");

        public mainForm()
        {
            InitializeComponent();

            RefreshWindows();

            SetColumnsHeader();

            HideId();

        }

        private void RefreshWindows()
        {
            var workers = DeserializeFromFile();
            dgvEmployeeList.DataSource = workers;

        }


        public void SerializeToFile(List<Workers> workers)
        {
            var serializer = new XmlSerializer(typeof(List<Workers>));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, workers);
                streamWriter.Close();
            }


        }
        public List<Workers> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Workers>();
            var serializer = new XmlSerializer(typeof(List<Workers>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var workers = (List<Workers>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return workers;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addingAndEditing = new AddingAndEditing();
            addingAndEditing.ShowDialog();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshWindows();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika!");
                return;
            }
            var addingAndEditing = new AddingAndEditing
                (Convert.ToInt32(dgvEmployeeList.SelectedRows[0].Cells[0].Value));
            addingAndEditing.ShowDialog();



        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (dgvEmployeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika którego chcesz zwolnić!");
                return;
            }
            var release = new Zwolnienie_pracownika
                (Convert.ToInt32(dgvEmployeeList.SelectedRows[0].Cells[0].Value));
            release.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)              //Usuwanie robocze
        {
            if (dgvEmployeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika którego chcesz zwolnić!");
                return;
            }

            var selectedWorker = dgvEmployeeList.SelectedRows[0];

            var workers = DeserializeFromFile();
            workers.RemoveAll(x => x.Id == Convert.ToInt32(selectedWorker.Cells[0].Value));
            SerializeToFile(workers);
            dgvEmployeeList.DataSource = workers;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker1.Value;

            FilterEmployees(selectedDate);

            HideId();

            SetColumnsHeader();

        }

        private void FilterEmployees(DateTime selectedDate)
        {

            var workers = dgvEmployeeList.DataSource as List<Workers>;

            if (workers != null)
            {

                var filteredWorkers = workers.Where(w => w.DateOfEmployment <= selectedDate).ToList();

                dgvEmployeeList.DataSource = null;
                dgvEmployeeList.DataSource = filteredWorkers;
            }

        }
        private void HideId()
        {
            dgvEmployeeList.Columns[nameof(Workers.Id)].Visible = false;
        }

        private void SetColumnsHeader()
        {

            dgvEmployeeList.Columns[1].HeaderText = "Imie";
            dgvEmployeeList.Columns[2].HeaderText = "Nazwisko";
            dgvEmployeeList.Columns[3].HeaderText = "Wynagrodzenie";
            dgvEmployeeList.Columns[4].HeaderText = "Data zatrudnienia";
            dgvEmployeeList.Columns[5].HeaderText = "Data zakonczenia";
            dgvEmployeeList.Columns[6].HeaderText = "Uwagi";

        }
    }

}
