using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrophyUpdater
{
    public partial class Ps3trophyupdater : Form
    {
        public Ps3trophyupdater()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startstop.AccessPoint oAccessPoint = new startstop.AccessPoint();

            psnapi.psn oPSN = new psnapi.psn();
            psnapi.Game[] oGames = oPSN.getGames(textBox1.Text); 

            foreach (psnapi.Game oGame in oGames)
            {
                startstop.StatOverView oOverview = new startstop.StatOverView();
                oOverview.CreatedOn = DateTime.Now;
                oOverview.Title = oGame.Title;
                oOverview.TypeOfOverview = startstop.OverviewType.PS3;
                oOverview.Description = oGame.Title;
                startstop.MessageResponse oResponse = new startstop.MessageResponse(); 
                oResponse =  oAccessPoint.AddStatOverview("", oOverview);
                if (oResponse.Success)
                {
                    // It has been added or updated. 

                }
            }

        }
    }
}
