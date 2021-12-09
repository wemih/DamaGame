using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaGame
{
    public partial class Form1 : Form
    {
        Game game;
        bool isDebugMode;
        public Form1()
        {
            InitializeComponent();

            isDebugMode = true;
        }

        private void RefreshGameViewHiearchy()
        {
            for (int i = 0; i < this.game.Playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.Playfield.Fields.GetLength(1); j++)
                {
                    this.game.Playfield.Fields[i, j].Background.Parent = this.game.Playfield.Background;
                }
            }
        }

        private void AddNewGameElementsControlls()
        {
            //add board controll
            this.Controls.Add(this.game.Playfield.Background);

            //add fields controll
            for (int i = 0; i < this.game.Playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.Playfield.Fields.GetLength(1); j++)
                {
                    this.Controls.Add(this.game.Playfield.Fields[i, j].Background);
                    this.game.Playfield.Fields[i, j].Background.BringToFront();
                }
            }
        }

        private void SwitchMainMenuElements()
        {
            bool mainMenuIsVisible = NewGameButtonLBL.Visible;
            mainMenuIsVisible = !mainMenuIsVisible;

            NewGameButtonLBL.Visible = mainMenuIsVisible;
            AboutButtonLBL.Visible = mainMenuIsVisible;
            HowToPlayButtonLBL.Visible = mainMenuIsVisible;
            ExitButtonLBL.Visible = mainMenuIsVisible;

            if (isDebugMode) Console.WriteLine($"Main menu elements visible set to {mainMenuIsVisible}");
        }

        private void HideAllMenuElements(bool hideMainMenu)
        {
            if (hideMainMenu)
            {
                NewGameButtonLBL.Visible = false;
                AboutButtonLBL.Visible = false;
                HowToPlayButtonLBL.Visible = false;
                ExitButtonLBL.Visible = false;
            }

            //new game
            PlayerNamesLBL.Visible = false;
            PlayerOneNameTBOX.Visible = false;
            PlayerTwoNameTBOX.Visible = false;
            PlayerNamesErrorLBL.Visible = false;
            StartButtonLBL.Visible = false;

            //about

            //how to play

            //misc.
        }


        //Main menu
        private void NewGameButtonLBL_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                //handle game clear
            }

            HideAllMenuElements(false);

            PlayerNamesLBL.Visible = true;
            PlayerOneNameTBOX.Visible = true;
            PlayerTwoNameTBOX.Visible = true;
            PlayerNamesErrorLBL.Visible = false;
            StartButtonLBL.Visible = true;
        }

        private void StartButtonLBL_Click(object sender, EventArgs e)
        {
            if (NameIsValid(PlayerOneNameTBOX.Text, PlayerTwoNameTBOX.Text))
            {
                HideAllMenuElements(true);
                game = new Game(this.isDebugMode, PlayerOneNameTBOX.Text, PlayerTwoNameTBOX.Text);
                
                AddNewGameElementsControlls();
                RefreshGameViewHiearchy();
            } else
            {
                PlayerNamesErrorLBL.Visible = true;
            }
        }

        private void HowToPlayButtonLBL_Click(object sender, EventArgs e)
        {

        }

        private void AboutButtonLBL_Click(object sender, EventArgs e)
        {

        }

        //---------------Checkings-------------------
        private bool NameIsValid (string playerOneName, string playerTwoName)
        {
            return playerOneName != "" && playerTwoName != "" ? true : false;
        }

        private bool GameIsStarted()
        {
            return this.game != null;
        }

        private void ExitButtonLBL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Overwrite ESC key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) { SwitchMainMenuElements(); }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        
    }
}
