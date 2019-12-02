namespace BreakOut
{
    partial class Start
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
            this.btnStrt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrt
            // 
            this.btnStrt.BackColor = System.Drawing.Color.Transparent;
            this.btnStrt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStrt.Location = new System.Drawing.Point(308, 114);
            this.btnStrt.Name = "btnStrt";
            this.btnStrt.Size = new System.Drawing.Size(183, 45);
            this.btnStrt.TabIndex = 1;
            this.btnStrt.Text = "Start Game";
            this.btnStrt.UseVisualStyleBackColor = false;
            this.btnStrt.Click += new System.EventHandler(this.btnStrt_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(308, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbt
            // 
            this.btnAbt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAbt.Location = new System.Drawing.Point(361, 380);
            this.btnAbt.Name = "btnAbt";
            this.btnAbt.Size = new System.Drawing.Size(75, 23);
            this.btnAbt.TabIndex = 3;
            this.btnAbt.Text = "About";
            this.btnAbt.UseVisualStyleBackColor = true;
            this.btnAbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BreakOut.Properties.Resources._14131;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 444);
            this.Controls.Add(this.btnAbt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStrt);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStrt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbt;
    }
}