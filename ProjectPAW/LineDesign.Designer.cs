
namespace ProjectPAW
{
    partial class LineDesign
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
            this.buttonDeseneaza = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeseneaza
            // 
            this.buttonDeseneaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonDeseneaza.FlatAppearance.BorderSize = 0;
            this.buttonDeseneaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeseneaza.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeseneaza.ForeColor = System.Drawing.Color.White;
            this.buttonDeseneaza.Location = new System.Drawing.Point(269, 120);
            this.buttonDeseneaza.Name = "buttonDeseneaza";
            this.buttonDeseneaza.Size = new System.Drawing.Size(127, 38);
            this.buttonDeseneaza.TabIndex = 0;
            this.buttonDeseneaza.Text = "Draw";
            this.buttonDeseneaza.UseVisualStyleBackColor = false;
            this.buttonDeseneaza.Click += new System.EventHandler(this.buttonDeseneaza_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonLeave.FlatAppearance.BorderSize = 0;
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeave.ForeColor = System.Drawing.Color.White;
            this.buttonLeave.Location = new System.Drawing.Point(269, 176);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(127, 38);
            this.buttonLeave.TabIndex = 1;
            this.buttonLeave.Text = "LEAVE";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // LineDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(426, 328);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonDeseneaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LineDesign";
            this.Text = "LineDesign";
            this.Load += new System.EventHandler(this.LineDesign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeseneaza;
        private System.Windows.Forms.Button buttonLeave;
    }
}