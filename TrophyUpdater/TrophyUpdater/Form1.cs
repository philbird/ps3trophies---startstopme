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
            psnapi.psn oPSN2 = new psnapi.psn();
            psnapi.psn oPSN3 = new psnapi.psn(); 

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
                    try
                    {
                        // It has been added or updated. 
                        // Now get a list of trophies
                        psnapi.Trophy[] oTrophies = oPSN2.getListTrophies( oGame.Id);
                        foreach (psnapi.Trophy oTrophy in oTrophies)
                        {
                            // Go through each one. 
                            // Add it to the list
                            startstop.Trophy ssTrophy = new startstop.Trophy();
                            ssTrophy.Approved = true;
                            ssTrophy.Name = oTrophy.Title;
                            ssTrophy.Description = oTrophy.Description;
                            startstop.MessageResponse _addTrophyResponse = oAccessPoint.UpdateTrophy("", ssTrophy);


                            


                        }
                        
                        // Now award trophies. 
                        psnapi.Trophy[] oTrophiesAwarded = oPSN3.getTrophies(textBox1.Text, oGame.Id);
                        foreach (psnapi.Trophy oTrophy in oTrophiesAwarded)
                        {
                            if (oTrophy.DateEarned.HasValue)
                            {
                                // We need to lookup the startstop user. 
                                startstop.MessageResponse _awardtrophy = oAccessPoint.AwardTrophyByName("", 1, oTrophy.Title, oTrophy.DateEarned.GetValueOrDefault()); 
                            }
                        }

                    }
                    catch (Exception eX)
                    {
                    }

                }
            }

        }
    }
}
