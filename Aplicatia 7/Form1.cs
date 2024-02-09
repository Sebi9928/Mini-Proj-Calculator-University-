using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatia_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        float num, ans;
        int count;

        public void disable()
        {
            textBox1.Enabled = false;
            ON.Show();
            OFF.Hide();
            Virgula.Enabled = false;
            Nr0.Enabled = false;
            Nr1.Enabled = false;
            nr2.Enabled = false;
            Nr3.Enabled = false;
            Nr4.Enabled = false;
            Nr5.Enabled = false;
            Nr6.Enabled = false;
            Nr7.Enabled = false;
            Nr8.Enabled = false;
            Nr9.Enabled = false;
            Suma.Enabled = false;
            Inmultire.Enabled = false;
            Impartire.Enabled = false;
            Scadere.Enabled = false;
            Egal.Enabled = false;
            Clear.Enabled = false;
            button2.Enabled = false;
        }
        public void enable()
        {
            textBox1.Enabled = true;
            OFF.Show();
            ON.Hide();
            Virgula.Enabled = true;
            Nr0.Enabled = true;
            Nr1.Enabled = true;
            nr2.Enabled = true;
            Nr3.Enabled = true;
            Nr4.Enabled = true;
            Nr5.Enabled = true;
            Nr6.Enabled = true;
            Nr7.Enabled = true;
            Nr8.Enabled = true;
            Nr9.Enabled = true;
            Suma.Enabled = true;
            Inmultire.Enabled = true;
            Impartire.Enabled = true;
            Scadere.Enabled = true;
            Egal.Enabled = true;
            Clear.Enabled = true;
            button2.Enabled = true;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }

        private void Nr0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void nr2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        private void Nr9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void ON_Click(object sender, EventArgs e)
        {
            enable();
        }
        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void Scadere_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void Inmultire_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void Impartire_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}