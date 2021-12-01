using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Windows
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<bangnhanvien> datanhanvien = new List<bangnhanvien>();
            datanhanvien.Add(new bangnhanvien() { ID = 001, Name = " AAA", Position = "Manager", Workplace = "HA NOI", Sex = "Male" , TotalDayoff = 0 ,TotalEarning = 1000 });
            datanhanvien.Add(new bangnhanvien() { ID = 002, Name = " BBB", Position = "Secretary", Workplace = "HA NOI", Sex = "Female", TotalDayoff = 0, TotalEarning = 1000 });
            datanhanvien.Add(new bangnhanvien() { ID = 003, Name = " CCC", Position = "Staff", Workplace = "DA NANG", Sex = "Female", TotalDayoff = 0, TotalEarning = 1000 });
            datanhanvien.Add(new bangnhanvien() { ID = 004, Name = " DDD", Position = "Staff", Workplace = "HCM", Sex = "Male", TotalDayoff = 0, TotalEarning = 1000 });
            datanhanvien.Add(new bangnhanvien() { ID = 005, Name = " EEE", Position = "Manage", Workplace = "VUNG TAU", Sex = "Male", TotalDayoff = 0, TotalEarning = 1000 });
            datanhanvien.Add(new bangnhanvien() { ID = 006, Name = " ZZZ", Position = "Staff", Workplace = "HA NOI", Sex = "Male", TotalDayoff = 0, TotalEarning = 1000 });

            dataGridView1.DataSource = datanhanvien;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string TenNV = row.Cells[1].Value + "";
            string ChucVu = row.Cells[2].Value + "";
            string DiaChi = row.Cells[3].Value + "";
            MessageBox.Show(TenNV);
            MessageBox.Show(ChucVu);
            MessageBox.Show(DiaChi);

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
