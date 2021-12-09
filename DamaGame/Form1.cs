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

        private void CreateGameBTNDEBUG_Click(object sender, EventArgs e)
        {
            this.game = new Game(true, "asd", "qwe");
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


        //Main menu
        private void NewGameButtonLBL_Click(object sender, EventArgs e)
        {
            
        }

        private void HowToPlayButtonLBL_Click(object sender, EventArgs e)
        {

        }

        private void AboutButtonLBL_Click(object sender, EventArgs e)
        {

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
