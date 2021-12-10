
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewGameButtonLBL = new System.Windows.Forms.Label();
            this.HowToPlayButtonLBL = new System.Windows.Forms.Label();
            this.AboutButtonLBL = new System.Windows.Forms.Label();
            this.ExitButtonLBL = new System.Windows.Forms.Label();
            this.PlayerNamesLBL = new System.Windows.Forms.Label();
            this.PlayerOneNameTBOX = new System.Windows.Forms.TextBox();
            this.PlayerTwoNameTBOX = new System.Windows.Forms.TextBox();
            this.StartButtonLBL = new System.Windows.Forms.Label();
            this.PlayerNamesErrorLBL = new System.Windows.Forms.Label();
            this.htpLBL01 = new System.Windows.Forms.Label();
            this.htpLBL02 = new System.Windows.Forms.Label();
            this.htpLBL03 = new System.Windows.Forms.Label();
            this.htpLBL04 = new System.Windows.Forms.Label();
            this.aboutLBL01 = new System.Windows.Forms.Label();
            this.aboutLBL02 = new System.Windows.Forms.Label();
            this.aboutLBL03 = new System.Windows.Forms.Label();
            this.aboutLBL04 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButtonLBL
            // 
            this.NewGameButtonLBL.AutoSize = true;
            this.NewGameButtonLBL.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewGameButtonLBL.Location = new System.Drawing.Point(16, 168);
            this.NewGameButtonLBL.Name = "NewGameButtonLBL";
            this.NewGameButtonLBL.Size = new System.Drawing.Size(190, 56);
            this.NewGameButtonLBL.TabIndex = 0;
            this.NewGameButtonLBL.Text = "Új játék";
            this.NewGameButtonLBL.Click += new System.EventHandler(this.NewGameButtonLBL_Click);
            // 
            // HowToPlayButtonLBL
            // 
            this.HowToPlayButtonLBL.AutoSize = true;
            this.HowToPlayButtonLBL.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HowToPlayButtonLBL.Location = new System.Drawing.Point(16, 232);
            this.HowToPlayButtonLBL.Name = "HowToPlayButtonLBL";
            this.HowToPlayButtonLBL.Size = new System.Drawing.Size(129, 56);
            this.HowToPlayButtonLBL.TabIndex = 1;
            this.HowToPlayButtonLBL.Text = "Súgó";
            this.HowToPlayButtonLBL.Click += new System.EventHandler(this.HowToPlayButtonLBL_Click);
            // 
            // AboutButtonLBL
            // 
            this.AboutButtonLBL.AutoSize = true;
            this.AboutButtonLBL.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AboutButtonLBL.Location = new System.Drawing.Point(16, 296);
            this.AboutButtonLBL.Name = "AboutButtonLBL";
            this.AboutButtonLBL.Size = new System.Drawing.Size(193, 56);
            this.AboutButtonLBL.TabIndex = 2;
            this.AboutButtonLBL.Text = "Névjegy";
            this.AboutButtonLBL.Click += new System.EventHandler(this.AboutButtonLBL_Click);
            // 
            // ExitButtonLBL
            // 
            this.ExitButtonLBL.AutoSize = true;
            this.ExitButtonLBL.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButtonLBL.ForeColor = System.Drawing.Color.Red;
            this.ExitButtonLBL.Location = new System.Drawing.Point(16, 360);
            this.ExitButtonLBL.Name = "ExitButtonLBL";
            this.ExitButtonLBL.Size = new System.Drawing.Size(179, 56);
            this.ExitButtonLBL.TabIndex = 3;
            this.ExitButtonLBL.Text = "Kilépés";
            this.ExitButtonLBL.Click += new System.EventHandler(this.ExitButtonLBL_Click);
            // 
            // PlayerNamesLBL
            // 
            this.PlayerNamesLBL.AutoSize = true;
            this.PlayerNamesLBL.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerNamesLBL.Location = new System.Drawing.Point(496, 142);
            this.PlayerNamesLBL.Name = "PlayerNamesLBL";
            this.PlayerNamesLBL.Size = new System.Drawing.Size(260, 56);
            this.PlayerNamesLBL.TabIndex = 4;
            this.PlayerNamesLBL.Text = "Játékosok";
            this.PlayerNamesLBL.Visible = false;
            // 
            // PlayerOneNameTBOX
            // 
            this.PlayerOneNameTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PlayerOneNameTBOX.Location = new System.Drawing.Point(368, 232);
            this.PlayerOneNameTBOX.Name = "PlayerOneNameTBOX";
            this.PlayerOneNameTBOX.Size = new System.Drawing.Size(228, 62);
            this.PlayerOneNameTBOX.TabIndex = 5;
            this.PlayerOneNameTBOX.Visible = false;
            // 
            // PlayerTwoNameTBOX
            // 
            this.PlayerTwoNameTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PlayerTwoNameTBOX.Location = new System.Drawing.Point(640, 232);
            this.PlayerTwoNameTBOX.Name = "PlayerTwoNameTBOX";
            this.PlayerTwoNameTBOX.Size = new System.Drawing.Size(240, 62);
            this.PlayerTwoNameTBOX.TabIndex = 6;
            this.PlayerTwoNameTBOX.Visible = false;
            // 
            // StartButtonLBL
            // 
            this.StartButtonLBL.AutoSize = true;
            this.StartButtonLBL.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButtonLBL.Location = new System.Drawing.Point(555, 416);
            this.StartButtonLBL.Name = "StartButtonLBL";
            this.StartButtonLBL.Size = new System.Drawing.Size(134, 56);
            this.StartButtonLBL.TabIndex = 7;
            this.StartButtonLBL.Text = "Start";
            this.StartButtonLBL.Visible = false;
            this.StartButtonLBL.Click += new System.EventHandler(this.StartButtonLBL_Click);
            // 
            // PlayerNamesErrorLBL
            // 
            this.PlayerNamesErrorLBL.AutoSize = true;
            this.PlayerNamesErrorLBL.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerNamesErrorLBL.ForeColor = System.Drawing.Color.Maroon;
            this.PlayerNamesErrorLBL.Location = new System.Drawing.Point(418, 334);
            this.PlayerNamesErrorLBL.Name = "PlayerNamesErrorLBL";
            this.PlayerNamesErrorLBL.Size = new System.Drawing.Size(419, 56);
            this.PlayerNamesErrorLBL.TabIndex = 8;
            this.PlayerNamesErrorLBL.Text = "Adj meg neveket!";
            this.PlayerNamesErrorLBL.Visible = false;
            // 
            // htpLBL01
            // 
            this.htpLBL01.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.htpLBL01.ForeColor = System.Drawing.Color.OrangeRed;
            this.htpLBL01.Location = new System.Drawing.Point(318, 23);
            this.htpLBL01.Name = "htpLBL01";
            this.htpLBL01.Size = new System.Drawing.Size(718, 55);
            this.htpLBL01.TabIndex = 9;
            this.htpLBL01.Text = "A Dáma Játék szabályai";
            this.htpLBL01.Visible = false;
            // 
            // htpLBL02
            // 
            this.htpLBL02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.htpLBL02.ForeColor = System.Drawing.Color.Black;
            this.htpLBL02.Location = new System.Drawing.Point(350, 78);
            this.htpLBL02.Name = "htpLBL02";
            this.htpLBL02.Size = new System.Drawing.Size(718, 151);
            this.htpLBL02.TabIndex = 10;
            this.htpLBL02.Text = resources.GetString("htpLBL02.Text");
            this.htpLBL02.Visible = false;
            // 
            // htpLBL03
            // 
            this.htpLBL03.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.htpLBL03.ForeColor = System.Drawing.Color.Orange;
            this.htpLBL03.Location = new System.Drawing.Point(322, 229);
            this.htpLBL03.Name = "htpLBL03";
            this.htpLBL03.Size = new System.Drawing.Size(718, 35);
            this.htpLBL03.TabIndex = 11;
            this.htpLBL03.Text = "A játék menete";
            this.htpLBL03.Visible = false;
            // 
            // htpLBL04
            // 
            this.htpLBL04.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.htpLBL04.ForeColor = System.Drawing.Color.Black;
            this.htpLBL04.Location = new System.Drawing.Point(350, 264);
            this.htpLBL04.Name = "htpLBL04";
            this.htpLBL04.Size = new System.Drawing.Size(718, 519);
            this.htpLBL04.TabIndex = 12;
            this.htpLBL04.Text = resources.GetString("htpLBL04.Text");
            this.htpLBL04.Visible = false;
            // 
            // aboutLBL01
            // 
            this.aboutLBL01.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutLBL01.ForeColor = System.Drawing.Color.Tomato;
            this.aboutLBL01.Location = new System.Drawing.Point(315, 109);
            this.aboutLBL01.Name = "aboutLBL01";
            this.aboutLBL01.Size = new System.Drawing.Size(281, 33);
            this.aboutLBL01.TabIndex = 13;
            this.aboutLBL01.Text = "Major Ádám\r\n";
            this.aboutLBL01.Visible = false;
            // 
            // aboutLBL02
            // 
            this.aboutLBL02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutLBL02.Location = new System.Drawing.Point(317, 152);
            this.aboutLBL02.Name = "aboutLBL02";
            this.aboutLBL02.Size = new System.Drawing.Size(238, 72);
            this.aboutLBL02.TabIndex = 14;
            this.aboutLBL02.Text = "\r\n - Projekt Vezető\r\n - Backend Programozó\r\n";
            this.aboutLBL02.Visible = false;
            // 
            // aboutLBL03
            // 
            this.aboutLBL03.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutLBL03.ForeColor = System.Drawing.Color.Tomato;
            this.aboutLBL03.Location = new System.Drawing.Point(635, 109);
            this.aboutLBL03.Name = "aboutLBL03";
            this.aboutLBL03.Size = new System.Drawing.Size(281, 33);
            this.aboutLBL03.TabIndex = 15;
            this.aboutLBL03.Text = "Weszely Ernő";
            this.aboutLBL03.Visible = false;
            // 
            // aboutLBL04
            // 
            this.aboutLBL04.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutLBL04.Location = new System.Drawing.Point(637, 152);
            this.aboutLBL04.Name = "aboutLBL04";
            this.aboutLBL04.Size = new System.Drawing.Size(238, 72);
            this.aboutLBL04.TabIndex = 16;
            this.aboutLBL04.Text = "\r\n - Designer\r\n\r\n";
            this.aboutLBL04.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DamaGame.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 811);
            this.ControlBox = false;
            this.Controls.Add(this.aboutLBL04);
            this.Controls.Add(this.aboutLBL03);
            this.Controls.Add(this.aboutLBL02);
            this.Controls.Add(this.aboutLBL01);
            this.Controls.Add(this.PlayerNamesErrorLBL);
            this.Controls.Add(this.StartButtonLBL);
            this.Controls.Add(this.PlayerTwoNameTBOX);
            this.Controls.Add(this.PlayerOneNameTBOX);
            this.Controls.Add(this.PlayerNamesLBL);
            this.Controls.Add(this.ExitButtonLBL);
            this.Controls.Add(this.AboutButtonLBL);
            this.Controls.Add(this.HowToPlayButtonLBL);
            this.Controls.Add(this.NewGameButtonLBL);
            this.Controls.Add(this.htpLBL01);
            this.Controls.Add(this.htpLBL02);
            this.Controls.Add(this.htpLBL04);
            this.Controls.Add(this.htpLBL03);
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
        private System.Windows.Forms.Label htpLBL01;
        private System.Windows.Forms.Label htpLBL02;
        private System.Windows.Forms.Label htpLBL03;
        private System.Windows.Forms.Label htpLBL04;
        private System.Windows.Forms.Label aboutLBL01;
        private System.Windows.Forms.Label aboutLBL02;
        private System.Windows.Forms.Label aboutLBL03;
        private System.Windows.Forms.Label aboutLBL04;
    }
}

