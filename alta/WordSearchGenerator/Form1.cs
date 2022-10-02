using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WordSearchGenerator
{
    public partial class Form1 : Form
    {
        public List<string> listOfWords = new List<string>(); //This will hold the list of words to be incorporated into the puzzle
        private bool debug = true; //Debug mode simply prepopulates the word list and title for quick puzzle creation

        public Form1()
        {
            InitializeComponent();
            ListaCuvinte.Items.Clear();
            totalCuvinte.Text = ListaCuvinte.Items.Count.ToString();
            statusLabel.Text = "Va rugam introduceti un titlu";
            Gata.Enabled = false;
            if (debug)
            {
                Titlu.Text = "Gaseste Cuvintele";
                string[] CuvinteDeAdaugat = new string[] { "PROGRAMARE", "ORIENTATA", "OBIECT", "ABSTRACT", "CLASA", "CONSTRUCTOR", "DESTRUCTOR", "OPERATOR", "VIRTUAL", "PUR" };
                foreach (string word in CuvinteDeAdaugat)
                {
                    ListaCuvinte.Items.Add(word);
                }
                UpdateWordCount();
                Gata.Enabled = true;
            }
            //Make "Normal" the default difficulty level for the puzzle
            if (MeniuTipNivel.SelectedIndex < 0 || MeniuTipNivel.SelectedIndex > 2)
            {
                MeniuTipNivel.SelectedIndex = 2;
            }

        }

        //Cuvintele trebuie sa aiba intre 3 si 15 caractere. Cuvantul sa nu fie de doua ori. Maxim 40 de cuvinte
        private bool ValidareCuvant(string word, out string CuvantDeValidat)
        {
            CuvantDeValidat = word.ToUpper();
            if (CuvantDeValidat.Length < 3)
            {
                MessageBox.Show("Cuvantul introdus trebuie sa aiba 3 sau mai multe caractere.", "Cuvantul este prea scurt!");
                return false;
            }
            if (CuvantDeValidat.Length > 15)
            {
                MessageBox.Show("The word you typed should have no more than 15 characters.", "Cuvantul este prea lung!");
                return false;
            }
            if (!Regex.IsMatch(CuvantDeValidat, "^[A-Z]{3,}$"))
            {
                MessageBox.Show("The word you typed should have only letters. No numbers, symbols, or spaces.", "Words only");
                return false;
            }
            if (ListaCuvinte.Items.Contains(CuvantDeValidat))
            {
                MessageBox.Show("The word you have entered already exists in the list of words.", "Duplicate word");
                return false;
            }
            if (ListaCuvinte.Items.Count > 40)
            {
                MessageBox.Show("The maximum number of words is 40.", "Max Words Reached");
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AdaugaCuvant(wordInput.Text);
        }

        private void wordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                AdaugaCuvant(wordInput.Text);
        }

        private bool AdaugaCuvant(string word)
        {
            string CuvantDeAdaugat;
            if (ValidareCuvant(word, out CuvantDeAdaugat))
            {
                ListaCuvinte.Items.Add(CuvantDeAdaugat);
                wordInput.Clear();
                UpdateWordCount();
                return true;
            }
            else
            {
                statusLabel.Text = "Please try again";
                return false;
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            for (int i = ListaCuvinte.SelectedIndices.Count - 1; i >= 0; i--)
            {
                ListaCuvinte.Items.RemoveAt(ListaCuvinte.SelectedIndices[i]);
                UpdateWordCount();
            }
        }

        private void UpdateWordCount()
        {
            int NumarulDeCuvinte = ListaCuvinte.Items.Count;
            totalCuvinte.Text = NumarulDeCuvinte.ToString();
            if (NumarulDeCuvinte > 0 && Titlu.Text.Length > 0)
                Gata.Enabled = true;
            else
                Gata.Enabled = false;
            if (NumarulDeCuvinte == 40)
                statusLabel.Text = "Word limit reached";
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            foreach (string item in ListaCuvinte.Items)
            {
                listOfWords.Add(item);
            }
            int difficultyIndex = this.MeniuTipNivel.SelectedIndex;
            int puzzleHeight = (int)this.SelecteazaInaltimea.Value;
            int puzzleWidth = (int)this.SelecteazaLatimea.Value;
            this.Hide();
            Form2 form2 = new Form2(listOfWords, Titlu.Text, difficultyIndex, puzzleWidth, puzzleHeight, this);
            form2.Show();
        }

        private void puzzleTitle_TextChanged(object sender, EventArgs e)
        {
            if (Titlu.Text.Length > 0)
            {
                statusLabel.Text = "";
                if (ListaCuvinte.Items.Count > 0)
                    Gata.Enabled = true;
            }
            else
            {
                statusLabel.Text = "Please Enter a Title";
                Gata.Enabled = false;
            }
        }

        private void puzzleTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                wordInput.Focus();
        }

        //Constrain the height and width values between 20 and 40
        private void heightSelect_ValueChanged(object sender, EventArgs e)
        {
            if (SelecteazaInaltimea.Value > 40)
                SelecteazaInaltimea.Value = 40;
            if (SelecteazaInaltimea.Value < 20)
                SelecteazaInaltimea.Value = 20;
        }

        private void widthSelect_ValueChanged(object sender, EventArgs e)
        {
            if (SelecteazaLatimea.Value > 40)
                SelecteazaLatimea.Value = 40;
            if (SelecteazaLatimea.Value < 20)
                SelecteazaLatimea.Value = 20;
        }


    }
}
