using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        private Random _ram = new Random();
        public GenerateNameForm()
        {
            InitializeComponent();
        
        }


        private void GeneratedNames()
        {

            int genarateNumber = _ram.Next(0,50)+1;
            int secondGenerate = _ram.Next(0, 50) + 1;
            FirstNameListBox.SelectedIndex = genarateNumber;
            LastNameListBox.SelectedIndex = secondGenerate;

            FirstNameTextBox.Text = FirstNameListBox.Text;
            LastNameTextBox.Text = LastNameListBox.Text;
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
           
            GeneratedNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GeneratedNames();
            Character character = Program.character;
            character.FirstName = this.FirstNameTextBox.Text;
            character.LastName = this.LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm AbilityGenerator = new AbilityGeneratorForm();

            AbilityGenerator.Show();
            this.Hide();
        }
    }
}
