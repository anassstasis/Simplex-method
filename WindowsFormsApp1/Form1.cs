using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ws17Entities2 conn = new ws17Entities2();
       // elementEntities1 conn = new elementEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            element element = new element();
            element.P0 = Convert.ToInt32(textBox16.Text);
            element.P1 = Convert.ToInt32(textBox1.Text);
            element.P2 = Convert.ToInt32(textBox2.Text);
            element.P3 = Convert.ToInt32(textBox3.Text);
            element.P4 = Convert.ToInt32(textBox4.Text);
            element.P5 = Convert.ToInt32(textBox5.Text);
            
            element element1 = new element();
            element1.P0 = Convert.ToInt32(textBox17.Text);
            element1.P1 = Convert.ToInt32(textBox6.Text);
            element1.P2 = Convert.ToInt32(textBox7.Text);
            element1.P3 = Convert.ToInt32(textBox8.Text);
            element1.P4 = Convert.ToInt32(textBox9.Text);
            element1.P6 = Convert.ToInt32(textBox10.Text);
            
            element element2 = new element();
            element2.P0 = Convert.ToInt32(textBox18.Text);
            element2.P1 = Convert.ToInt32(textBox11.Text);
            element2.P2 = Convert.ToInt32(textBox12.Text);
            element2.P3 = Convert.ToInt32(textBox13.Text);
            element2.P4 = Convert.ToInt32(textBox14.Text);
            element2.P7 = Convert.ToInt32(textBox15.Text);
            
            element element3 = new element();
            element3.P1 = Convert.ToInt32(textBox19.Text);
            element3.P2 = Convert.ToInt32(textBox20.Text);
            element3.P3 = Convert.ToInt32(textBox21.Text);
            element3.P4 = Convert.ToInt32(textBox22.Text);

         
            conn.element.Add(element);
            conn.element.Add(element1);
            conn.element.Add(element2);
            conn.element.Add(element3);
            conn.SaveChanges();
            dataGridView1.DataSource = conn.element.ToList();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = conn.element.ToList();

            int m1 = Convert.ToInt32(dataGridView1[2, 3].Value);
            int m2 = Convert.ToInt32(dataGridView1[3, 3].Value);
            int m3 = Convert.ToInt32(dataGridView1[4, 3].Value);
            int m4 = Convert.ToInt32(dataGridView1[5, 3].Value);
            int max = Math.Max(Math.Max(m1, m2), Math.Max(m3, m4));

            int st1 = Convert.ToInt32(dataGridView1[1, 1].Value);
            int st11 = Convert.ToInt32(dataGridView1[2, 1].Value);
            int str1 = st1 / st11;
            int st2 = Convert.ToInt32(dataGridView1[1, 2].Value);
            int st22 = Convert.ToInt32(dataGridView1[2, 2].Value);
            int str2 = st2 / st22;
            int st3 = Convert.ToInt32(dataGridView1[1, 3].Value);
            int st33 = Convert.ToInt32(dataGridView1[2, 3].Value);
            int str3 = st3 / st33;
           
            int min = Math.Min(Math.Min(str1, str2),Math.Min(str1,str3));

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (max == m1)
                {
                    dataGridView1[2, i].Style.BackColor = Color.Red;
                }
                if (max == m2)
                {
                    dataGridView1[3, i].Style.BackColor = Color.Red;
                }
                if (max == m3)
                {
                    dataGridView1[4, i].Style.BackColor = Color.Red;
                }
                if (max == m4)
                {
                    dataGridView1[5, i].Style.BackColor = Color.Red;
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (min == str1)
                {
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (min == str2)
                {
                    dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                    
                }
                if (min == str3)
                {
                   dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                }
           
            }

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1[2, 2].Style.BackColor = Color.Green;

            dataGridView1[2, 1].Style.BackColor = Color.Green;
            dataGridView1[2, 3].Style.BackColor = Color.Green;

            dataGridView1[3, 1].Style.BackColor = Color.Green;
            dataGridView1[3, 2].Style.BackColor = Color.Green;
            dataGridView1[3, 3].Style.BackColor = Color.Green;

            dataGridView1[4, 1].Style.BackColor = Color.Green;
            dataGridView1[4, 2].Style.BackColor = Color.Green;
            dataGridView1[4, 3].Style.BackColor = Color.Green;


            dataGridView1[5, 1].Style.BackColor = Color.Green;
            dataGridView1[5, 2].Style.BackColor = Color.Green;
            dataGridView1[5, 3].Style.BackColor = Color.Green;
        }
      
    }
}
