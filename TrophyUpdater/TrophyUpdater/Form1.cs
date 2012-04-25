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

            // This gets the games based on the PSNID in the text box. 
            psnapi.Game[] oGames = oPSN.getGames(textBox1.Text);
            psnapi.psn oPSN2 = new psnapi.psn();
            psnapi.psn oPSN3 = new psnapi.psn(); 

            foreach (psnapi.Game oGame in oGames)
            {

                // Instead this should search to see if the game is already there and if not then do the add! 
                startstop.MessageResponse oResponse = new startstop.MessageResponse();
                oResponse = oAccessPoint.FindStatOverview("", oGame.Title, startstop.OverviewType.PS3);
                
                // It cannot be found 
                if (!oResponse.Success)
                {

                    #region Add the stat Overview
                    startstop.StatOverView oOverview = new startstop.StatOverView();
                    oOverview.CreatedOn = DateTime.Now;
                    oOverview.Title = oGame.Title;
                    oOverview.TypeOfOverview = startstop.OverviewType.PS3;
                    oOverview.Description = oGame.Title;

                    // the response should be updated here. 
                    oResponse = oAccessPoint.AddStatOverview("", oOverview);
                    #endregion

                }

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

                            // Now we need to link the trophies
                            startstop.TrophyDetailStatLink oLink = new startstop.TrophyDetailStatLink();
                          
            // This needs to be checked! 
                            // A few trophies have been returned linked to the incorect game. 
                            
                            
                            oLink.OverviewID = oResponse.ReturnID;
                            oLink.TrophyID = _addTrophyResponse.ReturnID;

                            startstop.MessageResponse _addLinkResponse = oAccessPoint.AssociateTrophyToStat("", oLink); 

                        }

                        #region award trophies
                        // Now award trophies. 
                        // Just turning this off for now
                        /*
                        psnapi.Trophy[] oTrophiesAwarded = oPSN3.getTrophies(textBox1.Text, oGame.Id);
                        foreach (psnapi.Trophy oTrophy in oTrophiesAwarded)
                        {
                            if (oTrophy.DateEarned.HasValue)
                            {
                                // We need to lookup the startstop user. 
                                startstop.MessageResponse _awardtrophy = oAccessPoint.AwardTrophyByName("", 1, oTrophy.Title, oTrophy.DateEarned.GetValueOrDefault()); 
                            }
                        }
                         */ 
                        #endregion 

                    }
                    catch (Exception eX)
                    {
                    }

                }
            }

        }
    }
}
