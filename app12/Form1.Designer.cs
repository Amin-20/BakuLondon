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
            this.londonBtn = new System.Windows.Forms.Button();
            this.bakuBtn = new System.Windows.Forms.Button();
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
            this.timeLbl.Size = new System.Drawing.Size(217, 72);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "Time";
            // 
            // londonBtn
            // 
            this.londonBtn.BackColor = System.Drawing.Color.Transparent;
            this.londonBtn.Font = new System.Drawing.Font("ROG Fonts", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonBtn.ForeColor = System.Drawing.Color.Navy;
            this.londonBtn.Location = new System.Drawing.Point(700, 558);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(332, 65);
            this.londonBtn.TabIndex = 1;
            this.londonBtn.Text = "London";
            this.londonBtn.UseVisualStyleBackColor = false;
            this.londonBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonBtn_MouseClick);
            // 
            // bakuBtn
            // 
            this.bakuBtn.BackColor = System.Drawing.Color.Transparent;
            this.bakuBtn.Font = new System.Drawing.Font("ROG Fonts", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuBtn.ForeColor = System.Drawing.Color.Navy;
            this.bakuBtn.Location = new System.Drawing.Point(81, 558);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(332, 65);
            this.bakuBtn.TabIndex = 2;
            this.bakuBtn.Text = "BAKU";
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app12.Properties.Resources.img_119157_baku_flame_tower;
            this.ClientSize = new System.Drawing.Size(1181, 727);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.londonBtn);
            this.Controls.Add(this.timeLbl);
            this.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Button bakuBtn;
    }
}

