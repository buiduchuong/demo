using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        test2Entities test2Entities = new test2Entities();
        DataGridView data = new DataGridView();
        DataGridView datagrd = new DataGridView();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = test2Entities.Dashbroads.ToArray();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = test2Entities.Accounts.ToArray();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(data);
            this.Controls.Add(datagrd);
            datagrd.RowCount = 5;
            datagrd.ColumnCount = 8;
            datagrd.AutoSize = true;
            //244, 353
            datagrd.Location = new Point(12, 253);
            datagrd.Columns[0].Name = "Stt";
            datagrd.Columns[1].Name = "Account";
            datagrd.Columns[2].Name = "Company";
            datagrd.Columns[3].Name = "Bookie";
            datagrd.Columns[4].Name = "Bol";
            datagrd.Columns[5].Name = "Channel";
            datagrd.Columns[6].Name = "Rule";
            datagrd.Columns[7].Name = "State";
            datagrd.Rows[0].SetValues("1", "Nội thất", "Thú cưng", "Xây dựng","Pet", "Táo", "1000/1000","Run/Stop");
            datagrd.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            datagrd.EnableHeadersVisualStyles = false;
            datagrd.RowHeadersVisible = false;
            datagrd.AllowUserToAddRows = false;
            datagrd.BackgroundColor = SystemColors.Control;
            datagrd.BorderStyle = BorderStyle.None;
            datagrd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.Controls

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(datagrd);
          
            this.Controls.Add(data);
            data.Location = new Point(12, 253);
            data.ColumnCount = 7;
            data.RowCount = 5;
            data.AutoSize = true;
            data.Columns[0].Name = "Stt";
            data.Columns[1].Name = "Account";
            data.Columns[2].Name = "Bookie";
            data.Columns[3].Name = "Channel";
            data.Columns[4].Name = "Rule";
            data.Columns[5].Name = "S";
            data.Rows[0].SetValues("1","Cam", "Xoài", "Ổi","1000/1000", "Táo","Run/Stop");
            data.RowHeadersVisible = false;
            data.AllowUserToAddRows = false;
            data.BorderStyle = BorderStyle.None;
            data.BackgroundColor = SystemColors.Control;
            data.Columns[6].Name = "Status";
            data.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            data.EnableHeadersVisualStyles = false;
        }
       
    }
}
