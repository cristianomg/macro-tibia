namespace Screenshot
{
    partial class Save
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
            pbCapture = new System.Windows.Forms.PictureBox();
            btnConfirmar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pbCapture).BeginInit();
            SuspendLayout();
            // 
            // pbCapture
            // 
            pbCapture.Location = new System.Drawing.Point(10, 38);
            pbCapture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pbCapture.Name = "pbCapture";
            pbCapture.Size = new System.Drawing.Size(429, 208);
            pbCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pbCapture.TabIndex = 0;
            pbCapture.TabStop = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(9, 5);
            btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(88, 27);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(105, 5);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 2;
            button1.Text = "Re-Calibrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Save
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(519, 285);
            Controls.Add(button1);
            Controls.Add(btnConfirmar);
            Controls.Add(pbCapture);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Save";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Save";
            FormClosing += formEvent_closing;
            ((System.ComponentModel.ISupportInitialize)pbCapture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button1;
    }
}