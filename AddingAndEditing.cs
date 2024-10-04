using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeWorkTydzien5Lekcja27
{
    
    public partial class AddingAndEditing : Form
    {
        private string _filePath =
            Path.Combine(Environment.CurrentDirectory, "dane.txt");
        private int _workerId;
       

        public AddingAndEditing(int id = 0)
        {
            InitializeComponent();
            tbFirstName.Select();
            _workerId = id;
            if (id != 0)
            {
                var workers = DeserializeFromFile();
                var worker = workers.FirstOrDefault(i => i.Id == id);

                if (worker == null)                
                    throw new Exception("Brak takiego pracownika");
                
                tbId.Text = worker.Id.ToString();                
                tbFirstName.Text = worker.FirstName;
                tbLastName.Text = worker.LastName;
                tbSalaryAmount.Text = worker.SalaryAmount.ToString();
                tbDateOfEmployment.Text = worker.DateOfEmployment.ToString();                
                rtbComments.Text = worker.Comments;

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
                                             
            var workers = DeserializeFromFile();

            if (_workerId !=0)
            {
                workers.RemoveAll(i => i.Id == _workerId);
            }
            else
            {
                var workerWithHighestId = workers
                .OrderByDescending(i => i.Id).FirstOrDefault();

                 _workerId = workerWithHighestId == null ?
                    1 : workerWithHighestId.Id + 1;
            }
            
            

            var worker = new Workers
            {
                Id = _workerId,                 
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                SalaryAmount = Convert.ToInt32(tbSalaryAmount.Text),
                DateOfEmployment = DateTime.Parse(tbDateOfEmployment.Text),
                Comments = rtbComments.Text,
            };

            workers.Add(worker);
            SerializeToFile(workers);

            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            tbDateOfEmployment.Text = selectedDate;
        }

        
    }
}
