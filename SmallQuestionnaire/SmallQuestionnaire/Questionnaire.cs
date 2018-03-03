using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmallQuestionnaire
{
    public partial class Questionnaire : Form
    {
        public Questionnaire()
        {
            InitializeComponent();
        }

        private void buttonForSave_Click(object sender, EventArgs e)
        {
            textBoxForName.BackColor = Color.White;
            textBoxForSurname.BackColor = Color.White;
            comboBoxForGender.BackColor = Color.White;

            if (textBoxForName.Text != string.Empty && textBoxForSurname.Text != string.Empty &&
                (comboBoxForGender.Text == "Male" || comboBoxForGender.Text == "Female"))
            {
                File.AppendAllText("questionnaires.txt", "Name: " + textBoxForName.Text + "\r\n");
                File.AppendAllText("questionnaires.txt", "Surname: " + textBoxForSurname.Text + "\r\n");
                File.AppendAllText("questionnaires.txt", "Gender: " + comboBoxForGender.Text + "\r\n");
                File.AppendAllText("questionnaires.txt", "Date of Bitrh: " + DateOfBirth.Text + "\r\n");
                File.AppendAllText("questionnaires.txt", "Married: " + checkBoxForMarried.Checked + "\r\n");
                File.AppendAllText("questionnaires.txt", "=================================================\r\n");

                MessageBox.Show("Saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Errors = "Empty or incorrect fields:\r\n";
                if (textBoxForName.Text == string.Empty) { Errors += "- Surname\r\n"; textBoxForName.BackColor = Color.DarkRed; }
                if (textBoxForSurname.Text == string.Empty) { Errors += "- Name\r\n"; textBoxForSurname.BackColor = Color.DarkRed; }
                if (comboBoxForGender.Text != "Male" || comboBoxForGender.Text != "Female")
                { Errors += "- Gender\r\n"; comboBoxForGender.BackColor = Color.DarkRed; }

                MessageBox.Show(Errors, "Notice", MessageBoxButtons.OK);
            }
        }
    }
}
