using DataLayer.Model;
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
using WindowsForms.UserControls;

namespace WindowsForms.Forms
{
    public partial class FavouritePlayers : Form
    {
        public FavouritePlayers()
        {
            InitializeComponent();
        }

        private void PopulatePlayerControls()
        {
            //// Fetch data from the API
            //var responseData = await TeamMenApi.GetData();
            //var data = TeamMenApi.DeserializeData(responseData);

            //// Populate the ComboBox with data
            //foreach (var user in data)
            //{
            //    cbFavouriteTeam.Items.Add(user);
            //}

            //// Fetch the TeamStatistics data from the API or any other source
            //var teamStats = GetTeamStatisticsFromApi(); // Replace with the appropriate method or API call to fetch team statistics

            //// Combine starting eleven and substitutes into a single array
            //var allPlayers = teamStats.StartingEleven.Concat(teamStats.Substitutes).ToArray();

            //// Clear existing controls from the panels
            //panelFavorites.Controls.Clear();
            //panelOtherPlayers.Controls.Clear();

            //foreach (var player in allPlayers)
            //{
            //    PlayerControl playerControl = new PlayerControl();
            //    playerControl.PlayerName = player.Name;
            //    playerControl.ShirtNumber = player.ShirtNumber;
            //    playerControl.Position = player.Position;
            //    playerControl.IsCaptain = player.Captain;
            //    playerControl.IsFavorite = IsPlayerFavorite(player.Name); // Implement your logic to determine if a player is a favorite

            //    // Set the event handler for the context menu
            //    playerControl.ContextMenuStrip = playerContextMenu;

            //    // Attach the event handler for dragging the control
            //    playerControl.MouseDown += PlayerControl_MouseDown;

            //    if (playerControl.IsFavorite)
            //    {
            //        panelFavorites.Controls.Add(playerControl);
            //    }
            //    else
            //    {
            //        panelOtherPlayers.Controls.Add(playerControl);
            //    }
            }
        }
}

