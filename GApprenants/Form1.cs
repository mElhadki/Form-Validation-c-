using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GApprenants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Entrer Ton Nom");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Bien Ajouter", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider2.SetError(textBox2, "Entrer ton Prenom");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider2.SetError(textBox3, "Entrer ton Numéro de Téléphone");
            }

          

            else
            {
                
                System.Text.RegularExpressions.Regex rtele = new System.Text.RegularExpressions.Regex(@"^(\+[0-9]{10})$");
                if (textBox3.Text.Length > 0)
                {
                    if (!rtele.IsMatch(textBox3.Text))
                    {
                        e.Cancel = true;
                        textBox3.Focus();
                        errorProvider2.SetError(textBox3, "Entrer ton Numéro de Téléphone");
                    }
                    else
                    {

                        e.Cancel = false;
                        errorProvider2.SetError(textBox3, null);

                    }
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Maroc")

            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Safi");
                comboBox3.Items.Add("Rabat");
                comboBox3.Items.Add("Casablanca");
                comboBox3.Items.Add("Fes");
            }

            if (comboBox2.Text == "France")

            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Paris");
                comboBox3.Items.Add("Lyon");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider2.SetError(textBox4, "Entrer ton Email");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox4, null);
                System.Text.RegularExpressions.Regex rmail = new System.Text.RegularExpressions.Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"+ @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"+ @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
                if (textBox4.Text.Length > 0)
                {
                    if (!rmail.IsMatch(textBox4.Text))
                    {
                        MessageBox.Show("Invalid Email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox4.SelectAll();
                        e.Cancel = true;
                    }
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider2.SetError(comboBox1, "choisir un champs");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(comboBox1, null);
            }

        }

        private void comboBox3_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                e.Cancel = true;
                comboBox3.Focus();
                errorProvider2.SetError(comboBox3, "choisir un champs");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(comboBox3, null);
            }

        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                e.Cancel = true;
                comboBox2.Focus();
                errorProvider2.SetError(comboBox2, "choisir un champs");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(comboBox2, null);
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {

            if (DateTime.Today > dateTimePicker1.Value)
            {

                e.Cancel = true;
                dateTimePicker1.Focus();
                errorProvider2.SetError(dateTimePicker1, "Date Invalid");

            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(dateTimePicker1, null);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
