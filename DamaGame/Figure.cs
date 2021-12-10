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
        private bool isSelected;
        private bool isDama;

        public Figure(bool isDebugMode, string color)
        {
            this.isDebugMode = isDebugMode;
            this.Color = color;

            this.background = new PictureBox();
            this.background.Size = new Size(85, 85);
            this.background.BackgroundImageLayout = ImageLayout.Stretch;
            this.background.BackgroundImage = this.color == "dark" ? Properties.Resources.figure_1 : Properties.Resources.figure_0;

            this.background.Click += new EventHandler(FigureSelect);
        }

        private void FigureSelect(object sender, EventArgs e)
        {
            this.isSelected = true;

            //DEBUG
            if (isDebugMode) Console.WriteLine($"Figure Selected");
        }

        public void Enable()
        {
            this.background.Enabled = true;
        }

        public void Disable()
        {
            this.background.Enabled = false;
        }

        public void Remove()
        {
            this.background.Visible = false;
        }

        public PictureBox Background { get => background; set => background = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public string Color { get => color; set => color = value; }
        public bool IsDama { get => isDama; set => isDama = value; }
    }
}
