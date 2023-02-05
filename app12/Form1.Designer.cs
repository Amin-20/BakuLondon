namespace app12
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
            this.timeLbl = new System.Windows.Forms.Label();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.timeLbl.Location = new System.Drawing.Point(127, 9);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(96, 72);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "...";
            // 
            // LondonBtn
            // 
            this.LondonBtn.BackColor = System.Drawing.Color.Transparent;
            this.LondonBtn.Font = new System.Drawing.Font("ROG Fonts", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LondonBtn.ForeColor = System.Drawing.Color.Navy;
            this.LondonBtn.Location = new System.Drawing.Point(700, 558);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(332, 65);
            this.LondonBtn.TabIndex = 1;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = false;
            this.LondonBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LondonBtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app12.Properties.Resources.img_119157_baku_flame_tower;
            this.ClientSize = new System.Drawing.Size(1181, 727);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.timeLbl);
            this.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button LondonBtn;
    }
}

