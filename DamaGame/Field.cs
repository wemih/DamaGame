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
        }

        public bool IsDebugMode => isDebugMode;

        public bool IsSelectable { get => isSelectable; set => isSelectable = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public PictureBox Background { get => background; set => background = value; }
        internal Figure Figure { get => figure; set => figure = value; }
    }
}
