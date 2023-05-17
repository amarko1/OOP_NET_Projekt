using DataLayer.TeamInfo;
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
    public partial class SettingsFormTest : Form
    {
        public SettingsFormTest()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedGender = rbMen.Checked ? "Men" : "Women";
            FavouriteTeam favoriteTeamForm = new FavouriteTeam(selectedGender);

            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // spremi u file i idi na iducu formu!
                //this.Hide(); //dok testiranje traje zakomentirano
                favoriteTeamForm.ShowDialog();
                //this.Close();
                try
                {
                    SaveSettingsToFile();
                }
                catch (Exception)
                {
                    throw new Exception("Something wrong with file");
                }
            }
            else
            {
                // koristiti u sljedecem ucitavanju vec postojeci file i ne ucitaj formu
            }
        }


        private void SaveSettingsToFile()
        {
            string selectedLanguage = rbEnglish.Checked ? "English" : "Croatian";
            string selectedGender = rbMen.Checked ? "Men" : "Women";

            // Save the selected settings to a text file
            string filePath = "settings.txt";
            string[] settings = { "Language: " + selectedLanguage, "Gender: " + selectedGender };
            File.WriteAllLines(filePath, settings);
        }
    }
}
