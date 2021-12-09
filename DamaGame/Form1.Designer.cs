
namespace DamaGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGameButtonLBL = new System.Windows.Forms.Label();
            this.HowToPlayButtonLBL = new System.Windows.Forms.Label();
            this.AboutButtonLBL = new System.Windows.Forms.Label();
            this.ExitButtonLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButtonLBL
            // 
            this.NewGameButtonLBL.AutoSize = true;
            this.NewGameButtonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButtonLBL.Location = new System.Drawing.Point(272, 72);
            this.NewGameButtonLBL.Name = "NewGameButtonLBL";
            this.NewGameButtonLBL.Size = new System.Drawing.Size(183, 55);
            this.NewGameButtonLBL.TabIndex = 0;
            this.NewGameButtonLBL.Text = "Új játék";
            this.NewGameButtonLBL.Click += new System.EventHandler(this.NewGameButtonLBL_Click);
            // 
            // HowToPlayButtonLBL
            // 
            this.HowToPlayButtonLBL.AutoSize = true;
            this.HowToPlayButtonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlayButtonLBL.Location = new System.Drawing.Point(296, 152);
            this.HowToPlayButtonLBL.Name = "HowToPlayButtonLBL";
            this.HowToPlayButtonLBL.Size = new System.Drawing.Size(137, 55);
            this.HowToPlayButtonLBL.TabIndex = 1;
            this.HowToPlayButtonLBL.Text = "Súgó";
            this.HowToPlayButtonLBL.Click += new System.EventHandler(this.HowToPlayButtonLBL_Click);
            // 
            // AboutButtonLBL
            // 
            this.AboutButtonLBL.AutoSize = true;
            this.AboutButtonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButtonLBL.Location = new System.Drawing.Point(264, 224);
            this.AboutButtonLBL.Name = "AboutButtonLBL";
            this.AboutButtonLBL.Size = new System.Drawing.Size(198, 55);
            this.AboutButtonLBL.TabIndex = 2;
            this.AboutButtonLBL.Text = "Névjegy";
            this.AboutButtonLBL.Click += new System.EventHandler(this.AboutButtonLBL_Click);
            // 
            // ExitButtonLBL
            // 
            this.ExitButtonLBL.AutoSize = true;
            this.ExitButtonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonLBL.Location = new System.Drawing.Point(272, 296);
            this.ExitButtonLBL.Name = "ExitButtonLBL";
            this.ExitButtonLBL.Size = new System.Drawing.Size(181, 55);
            this.ExitButtonLBL.TabIndex = 3;
            this.ExitButtonLBL.Text = "Kilépés";
            this.ExitButtonLBL.Click += new System.EventHandler(this.ExitButtonLBL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButtonLBL);
            this.Controls.Add(this.AboutButtonLBL);
            this.Controls.Add(this.HowToPlayButtonLBL);
            this.Controls.Add(this.NewGameButtonLBL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewGameButtonLBL;
        private System.Windows.Forms.Label HowToPlayButtonLBL;
        private System.Windows.Forms.Label AboutButtonLBL;
        private System.Windows.Forms.Label ExitButtonLBL;
    }
}

