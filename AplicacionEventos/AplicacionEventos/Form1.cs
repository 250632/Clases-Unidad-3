using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AplicacionEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked==true)
            {
                label1.Text = "Selecciono el Check1";
            }
            if (this.checkBox2.Checked == true)
            {
                label1.Text = "Selecciono el Check2";
            }
            if (this.checkBox3.Checked == true)
            {
                label1.Text = "Selecciono el Check3";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton2.Checked = true;
            radioButton4.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Un solo Click";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Ha dado 2 Click";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                label1.Text = "Suma";
            }
            if (this.radioButton2.Checked == true)
            {
                label1.Text = "Resta";
            }
            if (this.radioButton3.Checked == true)
            {
                label1.Text = "Multiplicacion";
            }
            if (this.radioButton4.Checked == true)
            {
                label1.Text = "Division";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                
                label1.BackColor = Color.Blue;
                this.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                
                label1.BackColor = Color.Red;
                this.BackColor = Color.Red;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                
                label1.BackColor = Color.Green;
                this.BackColor = Color.Green;
            }
        }
    }
}
