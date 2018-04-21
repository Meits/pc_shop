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
    partial class Form2 : Form
    {
        public List<PCParts> parts;
        double summ = 0;
        public Form2()
        {
            InitializeComponent();
            this.parts = new List<PCParts>();
            comboBox1.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            this.generateCombo();
        }
        public void generateCombo()
        {
            comboBox1.Items.Clear();
            foreach (PCParts part in this.parts)
            {
                comboBox1.Items.Add(part.Name);
            }
        }
        
        public int getSelectIndex()
        {
            return this.comboBox1.SelectedIndex;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(this);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(this,true);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.parts.RemoveAt(this.getSelectIndex());
            this.generateCombo();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int tmpKey = this.getSelectIndex();
            textBox1.Text = this.parts[tmpKey].Price;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.getSelectIndex() > -1)
            {
                listBox1.Items.Add(this.parts[this.getSelectIndex()].Name);
                summ += Convert.ToDouble(this.parts[this.getSelectIndex()].Price, System.Globalization.CultureInfo.InvariantCulture);
                this.changeSummText();
            }
            
        }
        private void changeSummText()
        {
            textBox2.Text = Convert.ToString(this.summ);
        }
    }
}
