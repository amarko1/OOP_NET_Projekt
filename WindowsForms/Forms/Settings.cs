using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cbGender.Items.Add("Men");
            cbGender.Items.Add("Women");

            cbLanguage.Items.Add("Croatian");
            cbLanguage.Items.Add("English");

            //default 
            cbGender.SelectedIndex = 0;
            cbLanguage.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // spremi u file i idi na iducu formu!
                //SaveFile();
            }
            else
            {
                // koristiti u sljedecem ucitavanju vec postojeci file i ne ucitaj formu
            }
        }

        private void SaveFile()
        {
            string? choosenLanguage = cbLanguage.SelectedItem.ToString();
            string? choosenGender = cbGender.SelectedItem.ToString();

            string path = "odabrana_reprezentacija.txt";
            WriteLinesToFile(path, choosenLanguage, choosenGender);

            if (File.Exists(path))
            {
                // ne otvaraj settings formu vec onu koja treba ici iza nje
            }
        }

        public void WriteLinesToFile(string filePath, string language, string gender)
        {
            string[] lines = { language, gender };
            File.WriteAllLines(filePath, lines);
        }

    }
}
