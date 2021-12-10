﻿using System;
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

            this.background = new PictureBox();
            this.background.Size = new Size(85, 85);
            this.background.BackColor = Color.Transparent;

            this.background.Click += new EventHandler(FieldSelect);
        }

        private void FieldSelect(object sender, EventArgs e)
        {
            this.isSelected = true;

            //DEBUG
            if (isDebugMode) Console.WriteLine($"Field Selected");
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

        public bool IsDebugMode => isDebugMode;

        public bool IsSelectable { get => isSelectable; set => isSelectable = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public PictureBox Background { get => background; set => background = value; }
        internal Figure Figure { get => figure; set => figure = value; }
    }
}