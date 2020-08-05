using PaperPlaneRace.Business;
using PaperPlaneRace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperPlaneRace
{
    public partial class Form1 : Form
    {
        PaperPlane[] myPaperPlanes = new PaperPlane[4];
        int[] planeStartingXPos = new int[4];

        Punter[] myPunters = new Punter[3];
        TextBox[] txtPunterBets = new TextBox[3];
        TextBox[] txtPunterBalances = new TextBox[3];

        private RadioButton selectedPunter;

        public Form1()
        {
            InitializeComponent();
            LoadGame();
        }

        /* LOADING METHODS */
        private void LoadGame()
        {
            LoadPlanes();
            LoadPunters();
            LoadPuntersBalance();
        }

        private void LoadPlanes()
        {
            // Array of front-end PictureBoxes
            PictureBox[] pbxPlanes = { pbxPlane1, pbxPlane2, pbxPlane3, pbxPlane4 };

            // Instantiate a PaperPlane for each item (Plane) in pbxPlanes
            for (int i = 0; i < pbxPlanes.Length; i++)
            {
                // +1 when assigning ID so we start at 1 not 0.
                myPaperPlanes[i] = new PaperPlane { myPictureBox = pbxPlanes[i], planeID = (i + 1), planeStartingPositionX = pbxPlanes[i].Left };
                myPaperPlanes[i].myPictureBox.BackgroundImage = Resources.paperplane;
            }
        }

        private void LoadPunters()
        {
            // Array of front-end RadioButtons
            RadioButton[] rbnPunters = { rbnAllan, rbnBrian, rbnColin };
            // Array of front-end Textboxes
            TextBox[] txtPunterBets = { txtBetAllan, txtBetBrian, txtBetColin };

            // Generate Punters and bind components
            for (int i = 0; i < myPunters.Length; i++)
            {
                myPunters[i] = Factory.GeneratePunter(i);
                myPunters[i].myRadioButton = rbnPunters[i];
                myPunters[i].myTextBoxBet = txtPunterBets[i];
            }
        }

        private void LoadPuntersBalance()
        {
            // Array of front-end Textboxes
            TextBox[] txtPunterBalances = { txtBalAllan, txtBalBrian, txtBalColin };

            CheckIfBusted();
            // Read every punters balance and display on front end
            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].punterIsBusted == true)
                {
                    txtPunterBalances[i].Text = $@"Busted";
                }
                else
                {
                    txtPunterBalances[i].Text = myPunters[i].punterBalance.ToString();
                }
            }
        }

        private void CheckIfBusted()
        {
            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].punterBalance <= 0)
                {
                    myPunters[i].punterIsBusted = true;
                }
                else
                {
                    myPunters[i].punterIsBusted = false;
                }
            }
        }


        private void rbnAll_CheckedChanged(object sender, EventArgs e) // Change numericUpDown udBet maximum value on RadioButton.Click         
        {
            selectedPunter = (RadioButton)sender;
            if (selectedPunter.Checked == true)
            {
                BettingUI(true);

                // Match RadioButton with Punter
                for (int i = 0; i < myPunters.Length; i++)
                {
                    if (selectedPunter.Text == myPunters[i].punterName)
                    {
                        // Set udBet maximum to selectedPunter balance
                        udBet.Maximum = myPunters[i].punterBalance;
                        udPlaneID.Maximum = myPaperPlanes.Length;
                    }
                }
            }
        }

        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            resetPlanePositions();
            for (int i = 0; i < myPunters.Length; i++)
            {
                // selectedPunter is set in rbnAll_CheckedChanged so will always change when one of the corrensponding RadioButtons is pressed
                // Match selectedPunter with Punter, then place bet under that punterName
                if (selectedPunter.Text == myPunters[i].punterName)
                {
                    myPunters[i].myTextBoxBet.Text = Bet.PlaceBet(myPunters, selectedPunter.Text, (int)udBet.Value, (int)udPlaneID.Value);
                }
            }

            // Once all punters have placed bets, enable btnStartRace
            if (CheckBetsPlaced(myPunters))
            {
                btnStartRace.Enabled = true;
            }
        }

        private bool CheckBetsPlaced(Punter[] myPunters)
        {
            // Checks if every Punter has placed a bet, otherwise return false.
            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].punterHasBet != true)
                    return false;
            }
            return true;
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            startRace();
        }

        /* RACE LOGIC */
        private void startRace()
        {
            // Disable BettingUI to prevent any bugs
            BettingUI(false);
            bool pastFinishLine = false;

            // While any plane is not past the finish line run this loop
            while (pastFinishLine != true)
            {
                // Calculate width of pbxRaceTrack (minus Plane width and 12px padding)
                int finishLine = pbxRaceTrack.Width - (pbxPlane1.Width);

                Random myRandom = new Random();

                // Randomize what Plane is moved and how far it is moved
                int planeID = myRandom.Next(0, 4);
                int stepDistance = myRandom.Next(1, 5);

                // Move Planes
                myPaperPlanes[planeID].myPictureBox.Left += stepDistance;

                // Check all Planes positions to see if any have cross the finishLine
                for (int i = 0; i < myPaperPlanes.Length; i++)
                {
                    // Set fields and update betLog once a Plane passes the finishLine
                    if (myPaperPlanes[i].myPictureBox.Left >= finishLine)
                    {
                        pastFinishLine = true;
                        LoadPuntersBalance();
                        PrintResults(myPaperPlanes[i].planeID);
                        CheckIfWinner(myPunters);
                    }
                }
            }
        }

        private void BettingUI(bool Clause)
        {
            // Enable UI
            udBet.Enabled = Clause;
            udPlaneID.Enabled = Clause;
            btnPlaceBet.Enabled = Clause;
        }

        private void PrintResults(int winningPlaneID)
        {
            string[] result = Bet.FindRoundResults(myPunters, winningPlaneID);
            for (int i = 0; i < result.Length; i++)
            {
                myPunters[i].myTextBoxBet.Text = result[i];
            }
        }

        private void CheckIfWinner(Punter[] myPunters)
        {
            LoadPuntersBalance();
            int bustedCount = 0;
            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].punterIsBusted == true)
                {
                    bustedCount++;
                }
            }

            if (bustedCount == (myPunters.Length - 1))
            {
                for (int i = 0; i < myPunters.Length; i++)
                {
                    if (myPunters[i].punterIsBusted != true)
                    {
                        lblWinner.Text = $@"{myPunters[i].punterName} WINS!";
                        lblWinner.Visible = true;
                    }
                }
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            resetPlanePositions();
        }

        private void resetPlanePositions()
        {
            for (int i = 0; i < myPaperPlanes.Length; i++)
            {
                myPaperPlanes[i].myPictureBox.Left = planeStartingXPos[i];
            }

            for (int i = 0; i < myPunters.Length; i++)
            {
                myPunters[i].myRadioButton.Enabled = true;
            }
        }
    }
}