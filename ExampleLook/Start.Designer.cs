namespace ExampleLook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnCallSheet = new System.Windows.Forms.Button();
            this.btnPatLookUp = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCallSheet
            // 
            this.btnCallSheet.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCallSheet.Location = new System.Drawing.Point(34, 157);
            this.btnCallSheet.Name = "btnCallSheet";
            this.btnCallSheet.Size = new System.Drawing.Size(144, 53);
            this.btnCallSheet.TabIndex = 0;
            this.btnCallSheet.Text = "Call Sheet";
            this.btnCallSheet.UseVisualStyleBackColor = false;
            this.btnCallSheet.Click += new System.EventHandler(this.btnCallSheet_Click);
            // 
            // btnPatLookUp
            // 
            this.btnPatLookUp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPatLookUp.Location = new System.Drawing.Point(243, 157);
            this.btnPatLookUp.Name = "btnPatLookUp";
            this.btnPatLookUp.Size = new System.Drawing.Size(144, 53);
            this.btnPatLookUp.TabIndex = 1;
            this.btnPatLookUp.Text = "Patient Look Up";
            this.btnPatLookUp.UseVisualStyleBackColor = false;
            this.btnPatLookUp.Click += new System.EventHandler(this.btnPatLookUp_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(409, 97);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(433, 303);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnPatLookUp);
            this.Controls.Add(this.btnCallSheet);
            this.Name = "Start";
            this.Text = "Start Page";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallSheet;
        private System.Windows.Forms.Button btnPatLookUp;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

