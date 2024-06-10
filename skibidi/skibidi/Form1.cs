using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skibidi
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            this.Hide();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("You need to enter a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
                return;
            }

            if (!int.TryParse(input, out int number))
            {
                MessageBox.Show("You need to enter a number, no letters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
                return;
            }

            if (number > 60)
            {
                MessageBox.Show("Nuh uh, you are NOT that old buddy", "Inpute Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
                return;
            }

            if (number < 11)
            {
                MessageBox.Show("come in my basement if you're actually that young.", "Inpute Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
                return;
            }

            CalculatingForm calculatingForm = new CalculatingForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            calculatingForm.Show();

            await Task.Delay(5000);

            calculatingForm.Close();

            MessageBox.Show($"You are {number} years old.", "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
