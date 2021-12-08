
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
            this.CreateGameBTNDEBUG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateGameBTNDEBUG
            // 
            this.CreateGameBTNDEBUG.Location = new System.Drawing.Point(192, 160);
            this.CreateGameBTNDEBUG.Name = "CreateGameBTNDEBUG";
            this.CreateGameBTNDEBUG.Size = new System.Drawing.Size(112, 32);
            this.CreateGameBTNDEBUG.TabIndex = 0;
            this.CreateGameBTNDEBUG.Text = "create gaem";
            this.CreateGameBTNDEBUG.UseVisualStyleBackColor = true;
            this.CreateGameBTNDEBUG.Click += new System.EventHandler(this.CreateGameBTNDEBUG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateGameBTNDEBUG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateGameBTNDEBUG;
    }
}

