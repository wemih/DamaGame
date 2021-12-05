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

        private Figure[,] fields = new Figure[8, 8];

        public Playfield(bool isDebugMode)
        {
            this.isDebugMode = isDebugMode;

            FillPlayField();

            if (isDebugMode) Console.WriteLine($"Playfield created");
        }

        private void FillPlayField()
        {
            int offSet = 1;

            for (int i = 0; i < this.fields.GetLength(0); i++)
            {
                for (int j = offSet; j < this.fields.GetLength(1); j+=2)
                {
                    if (i <= 2)
                    {
                        this.fields[i, j] = new Figure(this.isDebugMode, "dark");
                    } else if (i >= 5)
                    {
                        this.fields[i ,j] = new Figure(this.isDebugMode, "light");
                    }
                }
                offSet = offSet == 1 ? 0 : 1;
            }
        }

        private void SwitchPlayfieldActive()
        {

        }

        private void Remove()
        {

        }
    }
}
