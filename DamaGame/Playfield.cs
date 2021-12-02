using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaGame
{
    class Playfield
    {
        readonly private bool isDebugMode;
        private PictureBox background = new PictureBox();
        private FigurePlace[,] figurePlaces = new FigurePlace[8, 8];

        public Playfield(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;
            //this.Background.BackgroundImage = Properties.Resources.Board_table;
            this.Background.Size = new Size(550, 550);
            this.Background.Location = new Point(275, 100);
            this.Background.BackgroundImageLayout = ImageLayout.Stretch;
            this.Background.BackColor = Color.Transparent;

            for (int i = 0; i < this.FigurePlaces.GetLength(0); i++)
            {
                for (int j = 0; j < this.FigurePlaces.GetLength(1); j++)
                {
                    this.FigurePlaces[i, j] = new FigurePlace(this.isDebugMode);
                    //this.FigurePlaces[i, j].SetLocation(j * 122 + 63, i * 122 + 50);
                    this.figurePlaces[i, j].Inactivate();
                }
            }

            if (isDebugMode) Console.WriteLine($"Playfield created");
        }

        public void ActivateAllFigurePlaces(object sender, EventArgs e)
        {
            for (int i = 0; i < this.FigurePlaces.GetLength(0); i++)
            {
                for (int j = 0; j < this.figurePlaces.GetLength(1); j++)
                {
                    if (this.figurePlaces[i, j].Figure == null)
                    {
                        this.figurePlaces[i, j].Active();
                    }
                }
            }
        }

        public void InactivateAllfigurePlaces(object sender, EventArgs e)
        {
            for (int i = 0; i < this.figurePlaces.GetLength(0); i++)
            {
                for (int j = 0; j < this.figurePlaces.GetLength(1); j++)
                {
                    this.figurePlaces[i, j].Inactivate();
                }
            }
        }

        public void Remove()
        {
            this.background.Visible = false;

            for (int i = 0; i < this.figurePlaces.GetLength(0); i++)
            {
                for (int j = 0; j < this.figurePlaces.GetLength(1); j++)
                {
                    this.figurePlaces[i, j].PicBox_.Visible = false;

                    if (this.figurePlaces[i, j].Figure != null)
                    {
                        this.figurePlaces[i, j].Figure.PicBox_.Visible = false;
                    }
                }
            }
        }

        public PictureBox Background { get => background; set => background = value; }
        internal FigurePlace[,] FigurePlaces { get => figurePlaces; set => figurePlaces = value; }
    }
}
