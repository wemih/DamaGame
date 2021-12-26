using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DamaGame
{
    class Field
    {
        readonly private bool isDebugMode;
        private bool isSelectable;
        private bool isSelected;
        private PictureBox background;
        private Figure figure;

        public Field(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;

            this.background = new PictureBox
            {
                Size = new Size(85, 85),
                BackColor = Color.Transparent
            };

            this.background.Click += new EventHandler(Select);
        }

        private void Select(object sender, EventArgs e)
        {
            this.isSelected = true;

            //DEBUG
            if (isDebugMode) Console.WriteLine($"Field Selected");
        }

        public bool IsSelected()
        {
            return this.isSelected == true ? true : false;
        }

        public void Deselect()
        {
            this.isSelected = false;
        }

        public void RemoveFieldIsSelectable()
        {
            this.isSelectable = false;
        }

        public void RemoveFigureIsSelectable()
        {
            if (this.figure != null)
            {
                this.figure.IsSelectable = false;
            }
        }

        public void EnableFieldForStep()
        {
            this.background.Enabled = true;
            this.background.BackgroundImage = Properties.Resources.step;
        }

        public void EnableFieldForHit()
        {
            this.background.Enabled = true;
            this.background.BackgroundImage = Properties.Resources.force;
        }

        public void DisableField()
        {
            this.background.Enabled = false;
            this.background.BackgroundImage = null;
        }

        public void EnableFigure()
        {
            if (this.figure != null)
            {
                this.background.Enabled = true;
                this.figure.Background.Enabled = true;

                if (this.figure.IsDama)
                {
                    this.figure.Background.BackgroundImage = this.figure.Color == "dark" ? Properties.Resources.dama_1_selected : Properties.Resources.dama_0_selected;
                } else
                {
                    this.figure.Background.BackgroundImage = this.figure.Color == "dark" ? Properties.Resources.figure_1_selected : Properties.Resources.figure_0_selected;
                }
            }
        }

        public void DisableFigure()
        {
            if (this.figure != null)
            {
                this.background.Enabled = false;
                this.figure.Background.Enabled = false;

                if (this.figure.IsDama)
                {
                    this.figure.Background.BackgroundImage = this.figure.Color == "dark" ? Properties.Resources.dama_1 : Properties.Resources.dama_0;
                }
                else
                {
                    this.figure.Background.BackgroundImage = this.figure.Color == "dark" ? Properties.Resources.figure_1 : Properties.Resources.figure_0;
                }

                
            }
        }

        public void Remove()
        {
            this.background.Visible = false;
        }

        public bool IsDebugMode => isDebugMode;

        public bool IsSelectable { get => isSelectable; set => isSelectable = value; }
        public PictureBox Background { get => background; set => background = value; }
        internal Figure Figure { get => figure; set => figure = value; }
    }
}
