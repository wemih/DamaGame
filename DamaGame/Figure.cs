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
        private PictureBox picBox_ = new PictureBox();
        private bool isSelected;

        public Figure(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;
            this.picBox_.Size = new Size(50, 50);
            this.picBox_.BackgroundImageLayout = ImageLayout.Stretch;
            this.picBox_.Click += new EventHandler(FigureSelect);
        }

        private void FigureSelect(object sender, EventArgs e)
        {
            this.isSelected = true;

            //DEBUG
            if (isDebugMode) Console.WriteLine($"Figure Selected");
        }

        public void SetLocation(int x, int y)
        {
            this.picBox_.Location = new Point(x, y);
        }

        public void Inactivate()
        {
            this.picBox_.Enabled = false;
        }

        public void Activate()
        {
            this.picBox_.Enabled = true;
        }

        public void Remove()
        {
            this.picBox_.Visible = false;
        }

        public PictureBox Panel_ { get => picBox_; set => picBox_ = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
    }
}
