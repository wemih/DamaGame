using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaGame
{
    class FigurePlace
    {
        readonly private bool isDebugMode;
        private Figure figure;
        private PictureBox picBox_ = new PictureBox();
        private bool isSelected;

        public FigurePlace(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;
            this.picBox_.BackColor = Color.Transparent;
            this.picBox_.Size = new Size(50, 50);
            this.picBox_.Click += new EventHandler(FigurePlaceSelect);
        }

        private void FigurePlaceSelect(object sender, EventArgs e)
        {
            this.isSelected = true;
            if (isDebugMode) Console.WriteLine($"Figure place selected");
        }

        public void SetLocation(int x, int y)
        {
            this.picBox_.Location = new Point(x, y);
        }

        public void Inactivate()
        {
            this.picBox_.Enabled = false;
        }

        public void Active()
        {
            this.picBox_.Enabled = true;
        }

        public PictureBox PicBox_ { get => picBox_; set => picBox_ = value; }
        internal Figure Figure { get => figure; set => figure = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
    }
}
