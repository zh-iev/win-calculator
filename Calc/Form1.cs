using System;
using System.Data;
using System.Windows.Forms;

namespace Calc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        private void button3_Click(object sender, EventArgs e) {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * (-1)).ToString();
        }
        private void button4_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && label1.Text == "") {
                label1.Text += textBox1.Text + "+";
                textBox1.Text = "";
            }
        }
        private void button5_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && label1.Text == "") {
                label1.Text += textBox1.Text + "-";
                textBox1.Text = "";
            }
        }
        private void button6_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && label1.Text == "") {
                label1.Text += textBox1.Text + "*";
                textBox1.Text = "";
            }
        }
        private void button7_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && label1.Text == "") {
                label1.Text += textBox1.Text + "/";
                textBox1.Text = "";
            }
        }
        private void button8_Click(object sender, EventArgs e) {
            if (label1.Text != "") {
                string res = label1.Text + textBox1.Text;
                res = res.Replace(",", ".");
                try {
                    object result = new DataTable().Compute(res, null);
                    textBox1.Text = result.ToString();
                    label1.Text = "";
                }
                catch {
                    textBox1.Text = "Деление на ноль запрещено!";
                    label1.Text = "";
                }
            }
        }
        private void button9_Click(object sender, EventArgs e) {
            textBox1.Text += "0";
        }
        private void button10_Click(object sender, EventArgs e) {
            textBox1.Text += "1";
        }
        private void button11_Click(object sender, EventArgs e) {
            textBox1.Text += "2";
        }
        private void button12_Click(object sender, EventArgs e) {
            textBox1.Text += "3";
        }
        private void button13_Click(object sender, EventArgs e) {
            textBox1.Text += "4";
        }
        private void button14_Click(object sender, EventArgs e) {
            textBox1.Text += "5";
        }
        private void button15_Click(object sender, EventArgs e) {
            textBox1.Text += "6";
        }
        private void button16_Click(object sender, EventArgs e) {
            textBox1.Text += "7";
        }
        private void button17_Click(object sender, EventArgs e) {
            textBox1.Text += "8";
        }
        private void button18_Click(object sender, EventArgs e) {
            textBox1.Text += "9";
        }
        private void button19_Click(object sender, EventArgs e) {
            if (textBox1.Text != "" && 
                !textBox1.Text.Contains(",")) {
                textBox1.Text += ",";
            }
        }
    }
}
