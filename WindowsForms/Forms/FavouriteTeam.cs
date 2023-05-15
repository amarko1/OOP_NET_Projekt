﻿using DataLayer.TeamInfo;
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
    public partial class FavouriteTeam : Form
    {
        public FavouriteTeam()
        {
            InitializeComponent();
        }

        private void FavouriteTeam_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private async void FillData()
        {
            var responseData = await TeamMenApi.GetData();
            var data = TeamMenApi.DeserializeData(responseData);

            foreach (var user in data)
            {
                cbFavouriteTeam.Items.Add(user);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // spremi u file 
                SaveFile();
            }
            else
            {
                // koristiti u sljedecem ucitavanju vec postojeci file
            }
        }

        private void SaveFile()
        {
            //string odabranaReprezentacija = cbFavouriteTeam.SelectedItem.ToString();

            //string putanjaDatoteke = "odabrana_reprezentacija.txt";
            //File.WriteAllText(putanjaDatoteke, odabranaReprezentacija);

            //string putanjaDatoteke = "odabrana_reprezentacija.txt";
            //if (File.Exists(putanjaDatoteke))
            //{
            //    string spremljenaReprezentacija = File.ReadAllText(putanjaDatoteke);
            //    // Postavljanje odabrane reprezentacije u ComboBox kontrolu
            //    cbFavouriteTeam.SelectedItem = spremljenaReprezentacija;
            //}
        }
    }
}
