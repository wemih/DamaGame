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

        public Playfield(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;
            this.isActive = true;
            this.fields = new Field[8, 8];

            AddFields();
            AddFigures();

            if (isDebugMode) Console.WriteLine($"Playfield created");
        }

        private void AddFields()
        {
            for (int i = 0; i < this.fields.GetLength(0); i++)
            {
                for (int j = 0; j < this.fields.GetLength(1); j++)
                {
                    this.fields[i, j] = new Field(this.isDebugMode);
                }
            }

            if (isDebugMode) Console.WriteLine($"Fields added to the playfield");
        }

        private void AddFigures()
        {
            int offSet = 1;

            for (int i = 0; i < this.fields.GetLength(0); i++)
            {
                for (int j = offSet; j < this.fields.GetLength(1); j += 2)
                {
                    if (i <= 2) { this.fields[i, j].Figure = new Figure(this.isDebugMode, "dark"); }
                    else if (i >= 5) { this.fields[i, j].Figure = new Figure(this.isDebugMode, "light"); }
                }
                offSet = offSet == 1 ? 0 : 1;
            }

            if (isDebugMode) Console.WriteLine($"Figures added to the playfield");
        }
    }
}
