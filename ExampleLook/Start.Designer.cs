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
            this.btnCallSheet = new System.Windows.Forms.Button();
            this.btnPatLookUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallSheet
            // 
            this.btnCallSheet.Location = new System.Drawing.Point(43, 125);
            this.btnCallSheet.Name = "btnCallSheet";
            this.btnCallSheet.Size = new System.Drawing.Size(144, 53);
            this.btnCallSheet.TabIndex = 0;
            this.btnCallSheet.Text = "Call Sheet";
            this.btnCallSheet.UseVisualStyleBackColor = true;
            this.btnCallSheet.Click += new System.EventHandler(this.btnCallSheet_Click);
            // 
            // btnPatLookUp
            // 
            this.btnPatLookUp.Location = new System.Drawing.Point(256, 125);
            this.btnPatLookUp.Name = "btnPatLookUp";
            this.btnPatLookUp.Size = new System.Drawing.Size(144, 53);
            this.btnPatLookUp.TabIndex = 1;
            this.btnPatLookUp.Text = "Patient Look Up";
            this.btnPatLookUp.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 303);
            this.Controls.Add(this.btnPatLookUp);
            this.Controls.Add(this.btnCallSheet);
            this.Name = "Start";
            this.Text = "Start Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallSheet;
        private System.Windows.Forms.Button btnPatLookUp;
    }
}

