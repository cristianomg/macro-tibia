namespace Screenshot
{
    partial class SelectArea
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
            panelDrag = new System.Windows.Forms.Panel();
            btnCaptureThis = new System.Windows.Forms.Button();
            panelDrag.SuspendLayout();
            SuspendLayout();
            // 
            // panelDrag
            // 
            panelDrag.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDrag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelDrag.Controls.Add(btnCaptureThis);
            panelDrag.Cursor = System.Windows.Forms.Cursors.SizeAll;
            panelDrag.ForeColor = System.Drawing.SystemColors.ControlText;
            panelDrag.Location = new System.Drawing.Point(2, 2);
            panelDrag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelDrag.Name = "panelDrag";
            panelDrag.Size = new System.Drawing.Size(532, 228);
            panelDrag.TabIndex = 0;
            panelDrag.MouseDown += panelDrag_MouseDown;
            // 
            // btnCaptureThis
            // 
            btnCaptureThis.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCaptureThis.Location = new System.Drawing.Point(5, 5);
            btnCaptureThis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCaptureThis.Name = "btnCaptureThis";
            btnCaptureThis.Size = new System.Drawing.Size(102, 31);
            btnCaptureThis.TabIndex = 0;
            btnCaptureThis.Text = "Capture this!";
            btnCaptureThis.UseVisualStyleBackColor = true;
            btnCaptureThis.Click += btnCaptureThis_Click;
            // 
            // SelectArea
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            ClientSize = new System.Drawing.Size(535, 232);
            Controls.Add(panelDrag);
            Cursor = System.Windows.Forms.Cursors.Cross;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SelectArea";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Select Area";
            panelDrag.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Button btnCaptureThis;
    }
}