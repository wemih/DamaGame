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
        readonly bool isDebugMode;
        public Form1()
        {
            InitializeComponent();

            isDebugMode = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshViewHiearchy();
        }
        private void RefreshViewHiearchy()
        {
            NewGameButtonLBL.Parent = backgroundPNL;
            AboutButtonLBL.Parent = backgroundPNL;
            HowToPlayButtonLBL.Parent = backgroundPNL;
            ExitButtonLBL.Parent = backgroundPNL;
            PlayerNamesLBL.Parent = backgroundPNL;
            PlayerOneNameTBOX.Parent = backgroundPNL;
            PlayerTwoNameTBOX.Parent = backgroundPNL;
            PlayerNamesErrorLBL.Parent = backgroundPNL;
            StartButtonLBL.Parent = backgroundPNL;
        }
        private void RefreshGameViewHiearchy()
        {
            

            this.game.Playfield.Background.Parent = backgroundPNL;

            for (int i = 0; i < this.game.Playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.Playfield.Fields.GetLength(1); j++)
                {
                    this.game.Playfield.Fields[i, j].Background.Parent = this.game.Playfield.Background;

                    if (this.game.Playfield.Fields[i, j].Figure != null)
                    {
                        this.game.Playfield.Fields[i, j].Figure.Background.Parent = this.game.Playfield.Fields[i, j].Background;
                    }
                }
            }
        }

        private void RefreshFiguresHiearchy()
        {
            for (int i = 0; i < this.game.Playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.Playfield.Fields.GetLength(1); j++)
                {
                    if (this.game.Playfield.Fields[i,j].Figure != null)
                    {
                        
                    }
                }
            }
            if (isDebugMode) Console.WriteLine($"Figures hiearchy refreshed");
        }

        private void AddNewGameElementsControlls()
        {
            //add board controll
            this.Controls.Add(this.game.Playfield.Background);

            //add fields and figures controll
            for (int i = 0; i < this.game.Playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.Playfield.Fields.GetLength(1); j++)
                {
                    this.Controls.Add(this.game.Playfield.Fields[i, j].Background);
                    this.game.Playfield.Fields[i, j].Background.BringToFront();

                    if (this.game.Playfield.Fields[i, j].Figure != null)
                    {
                        this.Controls.Add(this.game.Playfield.Fields[i, j].Figure.Background);
                        this.game.Playfield.Fields[i, j].Figure.Background.BringToFront();
                    }
                }
            }
        }

        private void AddEventListeners()
        {
            for (int i = 0; i < this.game.Playfield.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.game.Playfield.Fields.GetLength(1); j++)
                {
                    this.game.Playfield.Fields[i, j].Background.Click += OnClickField;

                    if (this.game.Playfield.Fields[i, j].Figure != null)
                    {
                        this.game.Playfield.Fields[i, j].Figure.Background.Click += OnClickFigure;
                    }
                }
            }
            if (isDebugMode) Console.WriteLine($"View event listeners added");
        }

        private void OnClickFigure(object sender, EventArgs e)
        {

        }

        private void OnClickField(object sender, EventArgs e)
        {
            RefreshFiguresHiearchy();
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

            htpLBL01.Visible = false;
            htpLBL02.Visible = false;
            htpLBL03.Visible = false;
            htpLBL04.Visible = false;

            aboutLBL01.Visible = false;
            aboutLBL02.Visible = false;
            aboutLBL03.Visible = false;
            aboutLBL04.Visible = false;

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
                AddEventListeners();
            } else
            {
                PlayerNamesErrorLBL.Visible = true;
            }
        }

        private void HowToPlayButtonLBL_Click(object sender, EventArgs e)
        {
            HideAllMenuElements(false);

            htpLBL01.Visible = true;
            htpLBL02.Visible = true;
            htpLBL03.Visible = true;
            htpLBL04.Visible = true;

        }

        private void AboutButtonLBL_Click(object sender, EventArgs e)
        {
            HideAllMenuElements(false);

            aboutLBL01.Visible = true;
            aboutLBL02.Visible = true;
            aboutLBL03.Visible = true;
            aboutLBL04.Visible = true;

        }

        //---------------Checkings-------------------
        private bool NameIsValid (string playerOneName, string playerTwoName)
        {
            return playerOneName != "" && playerTwoName != "";
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
