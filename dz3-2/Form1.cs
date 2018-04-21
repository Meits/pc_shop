using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_2
{
    partial class Form1 : Form
    {
        private Form2 form;
        private bool edit = false;
        public Form1(Form2 form, bool edit = false)
        {
            InitializeComponent();
            this.form = form;
            this.edit = edit;
            if(edit)
            {
                form.getSelectIndex();
                textBox1.Text = form.parts[form.getSelectIndex()].Name;
                textBox2.Text = form.parts[form.getSelectIndex()].Characteristic;
                textBox3.Text = form.parts[form.getSelectIndex()].Description;
                textBox4.Text = form.parts[form.getSelectIndex()].Price;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.edit)
            {
                form.parts[form.getSelectIndex()].Name = textBox1.Text;
                form.parts[form.getSelectIndex()].Characteristic = textBox2.Text;
                form.parts[form.getSelectIndex()].Description = textBox3.Text;
                form.parts[form.getSelectIndex()].Price = textBox4.Text;

            }
            else
            {
                PCParts part = new PCParts(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                form.parts.Add(part);
            }
            
            form.generateCombo();
            this.Close();
        }
    }
}
