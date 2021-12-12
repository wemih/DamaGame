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
        private Field[,] fields;
        private PictureBox background;

        public Playfield(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;
            this.Fields = new Field[8, 8];

            this.background = new PictureBox
            {
                Size = new Size(800, 800),
                Location = new Point(300, 0),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = Properties.Resources.board
            };

            AddFields();
            AddFigures();

            if (isDebugMode) Console.WriteLine($"Playfield created");
        }

        internal Field[,] Fields { get => fields; set => fields = value; }
        public PictureBox Background { get => background; set => background = value; }

        private void AddFields()
        {
            for (int i = 0; i < this.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.Fields.GetLength(1); j++)
                {
                    this.Fields[i, j] = new Field(this.isDebugMode);
                    this.fields[i, j].Background.Location = new Point(j * 98 + 15, i * 98 + 15);
                }
            }

            if (isDebugMode) Console.WriteLine($"Fields added to the playfield");
        }

        private void AddFigures()
        {
            int offSet = 1;

            for (int i = 0; i < this.Fields.GetLength(0); i++)
            {
                for (int j = offSet; j < this.Fields.GetLength(1); j += 2)
                {
                    if (i <= 2) { this.Fields[i, j].Figure = new Figure(this.isDebugMode, "dark"); }
                    else if (i >= 5) { this.Fields[i, j].Figure = new Figure(this.isDebugMode, "light"); }
                }
                offSet = offSet == 1 ? 0 : 1;
            }

            if (isDebugMode) Console.WriteLine($"Figures added to the playfield");
        }

        public void Remove()
        {
            this.Background.Visible = false;
        }

    }
}
