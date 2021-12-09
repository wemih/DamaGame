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
        private bool isActive;
        private Field[,] fields;
        private PictureBox background;

        public Playfield(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;
            this.isActive = true;
            this.Fields = new Field[8, 8];

            AddFields();
            AddFigures();

            if (isDebugMode) Console.WriteLine($"Playfield created");
        }

        internal Field[,] Fields { get => fields; set => fields = value; }

        private void AddFields()
        {
            for (int i = 0; i < this.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.Fields.GetLength(1); j++)
                {
                    this.Fields[i, j] = new Field(this.isDebugMode);
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
            this.background.Visible = false;
        }

    }
}
