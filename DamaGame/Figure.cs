using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaGame
{
    class Figure
    {
        readonly private bool isDebugMode;
        private string color;
        private PictureBox background;
        private bool isSelectable;
        private bool isSelected;
        private bool isDama;

        public Figure(bool isDebugMode, string color)
        {
            this.isDebugMode = isDebugMode;
            this.Color = color;

            this.background = new PictureBox
            {
                Size = new Size(85, 85),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = this.color == "dark" ? Properties.Resources.figure_1 : Properties.Resources.figure_0
            };

            this.background.Click += new EventHandler(Select);
        }

        private void Select(object sender, EventArgs e)
        {
            this.isSelected = true;

            //DEBUG
            if (isDebugMode) Console.WriteLine($"Figure Selected");
        }

        public bool IsSelected()
        {
            return this.isSelected == true ? true : false;
        }

        public void Deselect()
        {
            this.isSelected = false;
        }

        public void Hit()
        {
            this.background.BackgroundImage = null;
            this.background.Visible = false;
        }

        public void TurnIntoDama()
        {
            this.isDama = true;
            this.background.BackgroundImage = this.color == "dark" ? Properties.Resources.dama_1 : Properties.Resources.dama_0;
        }

        public PictureBox Background { get => background; set => background = value; }
        public string Color { get => color; set => color = value; }
        public bool IsDama { get => isDama; set => isDama = value; }
        public bool IsSelectable { get => isSelectable; set => isSelectable = value; }
    }
}
