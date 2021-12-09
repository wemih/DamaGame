
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
            this.PlayerNamesLBL = new System.Windows.Forms.Label();
            this.PlayerOneNameTBOX = new System.Windows.Forms.TextBox();
            this.PlayerTwoNameTBOX = new System.Windows.Forms.TextBox();
            this.StartButtonLBL = new System.Windows.Forms.Label();
            this.PlayerNamesErrorLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButtonLBL
            // 
            this.NewGameButtonLBL.AutoSize = true;
            this.NewGameButtonLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButtonLBL.Location = new System.Drawing.Point(16, 168);
            this.NewGameButtonLBL.Name = "NewGameButtonLBL";
            this.NewGameButtonLBL.Size = new System.Drawing.Size(201, 55);
            this.NewGameButtonLBL.TabIndex = 0;
            this.NewGameButtonLBL.Text = "Új játék";
            this.NewGameButtonLBL.Click += new System.EventHandler(this.NewGameButtonLBL_Click);
            // 
            // HowToPlayButtonLBL
            // 
            this.HowToPlayButtonLBL.AutoSize = true;
            this.HowToPlayButtonLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlayButtonLBL.Location = new System.Drawing.Point(16, 232);
            this.HowToPlayButtonLBL.Name = "HowToPlayButtonLBL";
            this.HowToPlayButtonLBL.Size = new System.Drawing.Size(144, 55);
            this.HowToPlayButtonLBL.TabIndex = 1;
            this.HowToPlayButtonLBL.Text = "Súgó";
            this.HowToPlayButtonLBL.Click += new System.EventHandler(this.HowToPlayButtonLBL_Click);
            // 
            // AboutButtonLBL
            // 
            this.AboutButtonLBL.AutoSize = true;
            this.AboutButtonLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButtonLBL.Location = new System.Drawing.Point(16, 296);
            this.AboutButtonLBL.Name = "AboutButtonLBL";
            this.AboutButtonLBL.Size = new System.Drawing.Size(213, 55);
            this.AboutButtonLBL.TabIndex = 2;
            this.AboutButtonLBL.Text = "Névjegy";
            this.AboutButtonLBL.Click += new System.EventHandler(this.AboutButtonLBL_Click);
            // 
            // ExitButtonLBL
            // 
            this.ExitButtonLBL.AutoSize = true;
            this.ExitButtonLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonLBL.Location = new System.Drawing.Point(16, 360);
            this.ExitButtonLBL.Name = "ExitButtonLBL";
            this.ExitButtonLBL.Size = new System.Drawing.Size(200, 55);
            this.ExitButtonLBL.TabIndex = 3;
            this.ExitButtonLBL.Text = "Kilépés";
            this.ExitButtonLBL.Click += new System.EventHandler(this.ExitButtonLBL_Click);
            // 
            // PlayerNamesLBL
            // 
            this.PlayerNamesLBL.AutoSize = true;
            this.PlayerNamesLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNamesLBL.Location = new System.Drawing.Point(480, 144);
            this.PlayerNamesLBL.Name = "PlayerNamesLBL";
            this.PlayerNamesLBL.Size = new System.Drawing.Size(267, 55);
            this.PlayerNamesLBL.TabIndex = 4;
            this.PlayerNamesLBL.Text = "Játékosok";
            this.PlayerNamesLBL.Visible = false;
            // 
            // PlayerOneNameTBOX
            // 
            this.PlayerOneNameTBOX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.PlayerOneNameTBOX.Location = new System.Drawing.Point(368, 232);
            this.PlayerOneNameTBOX.Name = "PlayerOneNameTBOX";
            this.PlayerOneNameTBOX.Size = new System.Drawing.Size(228, 63);
            this.PlayerOneNameTBOX.TabIndex = 5;
            this.PlayerOneNameTBOX.Visible = false;
            // 
            // PlayerTwoNameTBOX
            // 
            this.PlayerTwoNameTBOX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.PlayerTwoNameTBOX.Location = new System.Drawing.Point(640, 232);
            this.PlayerTwoNameTBOX.Name = "PlayerTwoNameTBOX";
            this.PlayerTwoNameTBOX.Size = new System.Drawing.Size(240, 63);
            this.PlayerTwoNameTBOX.TabIndex = 6;
            this.PlayerTwoNameTBOX.Visible = false;
            // 
            // StartButtonLBL
            // 
            this.StartButtonLBL.AutoSize = true;
            this.StartButtonLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButtonLBL.Location = new System.Drawing.Point(544, 416);
            this.StartButtonLBL.Name = "StartButtonLBL";
            this.StartButtonLBL.Size = new System.Drawing.Size(140, 55);
            this.StartButtonLBL.TabIndex = 7;
            this.StartButtonLBL.Text = "Start";
            this.StartButtonLBL.Visible = false;
            this.StartButtonLBL.Click += new System.EventHandler(this.StartButtonLBL_Click);
            // 
            // PlayerNamesErrorLBL
            // 
            this.PlayerNamesErrorLBL.AutoSize = true;
            this.PlayerNamesErrorLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNamesErrorLBL.ForeColor = System.Drawing.Color.Maroon;
            this.PlayerNamesErrorLBL.Location = new System.Drawing.Point(408, 336);
            this.PlayerNamesErrorLBL.Name = "PlayerNamesErrorLBL";
            this.PlayerNamesErrorLBL.Size = new System.Drawing.Size(430, 55);
            this.PlayerNamesErrorLBL.TabIndex = 8;
            this.PlayerNamesErrorLBL.Text = "Adj meg neveket!";
            this.PlayerNamesErrorLBL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 787);
            this.ControlBox = false;
            this.Controls.Add(this.PlayerNamesErrorLBL);
            this.Controls.Add(this.StartButtonLBL);
            this.Controls.Add(this.PlayerTwoNameTBOX);
            this.Controls.Add(this.PlayerOneNameTBOX);
            this.Controls.Add(this.PlayerNamesLBL);
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
        private System.Windows.Forms.Label PlayerNamesLBL;
        private System.Windows.Forms.TextBox PlayerOneNameTBOX;
        private System.Windows.Forms.TextBox PlayerTwoNameTBOX;
        private System.Windows.Forms.Label StartButtonLBL;
        private System.Windows.Forms.Label PlayerNamesErrorLBL;
    }
}

