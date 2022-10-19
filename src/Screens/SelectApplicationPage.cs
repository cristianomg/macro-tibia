using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens
{
    public partial class SelectApplicationPage : Form
    {
        private string PROCESS_ID;
        public SelectApplicationPage()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            var process = Process.GetProcesses(".").Where(x=>x.MainWindowTitle.Contains("Tibia"));

            PROCESS_ID = process.FirstOrDefault()?.Id.ToString();

            PopulateAplicationList(process);
        }

        private void PopulateAplicationList(IEnumerable<Process> process) 
        {
            var dt = new DataTable();
            dt.Columns.Add("ProcessName");
            dt.Columns.Add("ProcessId");

            foreach (var p in process)
            {
                dt.Rows.Add(p.MainWindowTitle, p.Id.ToString());
            }

            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "ProcessName";
            this.comboBox1.ValueMember = "ProcessId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PROCESS_ID != "0")
                new HomePage(Convert.ToInt32(PROCESS_ID)).Show();

            this.Hide();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            PROCESS_ID = this.comboBox1.SelectedValue.ToString();
            this.textBox1.Text = PROCESS_ID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
