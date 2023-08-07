
namespace Screens
{
    partial class HomePage
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
            label1 = new System.Windows.Forms.Label();
            ComboLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            IntervalCombo21 = new System.Windows.Forms.TextBox();
            IntervalCombo22 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            IntervalCombo12 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            intervalCombo11 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            intervalHealing2 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            intervalHealing1 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            btnCalibrarHealing = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Healing (f1, f2)";
            // 
            // ComboLabel1
            // 
            ComboLabel1.AutoSize = true;
            ComboLabel1.Location = new System.Drawing.Point(304, 28);
            ComboLabel1.Name = "ComboLabel1";
            ComboLabel1.Size = new System.Drawing.Size(90, 15);
            ComboLabel1.TabIndex = 5;
            ComboLabel1.Text = "Combo1 (f3, f4)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(574, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Combo2 (f8, f9)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(574, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 15);
            label3.TabIndex = 9;
            label3.Text = "Intervalo1 (ms):";
            // 
            // IntervalCombo21
            // 
            IntervalCombo21.Location = new System.Drawing.Point(669, 47);
            IntervalCombo21.Name = "IntervalCombo21";
            IntervalCombo21.Size = new System.Drawing.Size(100, 23);
            IntervalCombo21.TabIndex = 10;
            IntervalCombo21.Text = "2200";
            IntervalCombo21.TextChanged += IntervalCombo21_TextChanged;
            // 
            // IntervalCombo22
            // 
            IntervalCombo22.Location = new System.Drawing.Point(669, 72);
            IntervalCombo22.Name = "IntervalCombo22";
            IntervalCombo22.Size = new System.Drawing.Size(100, 23);
            IntervalCombo22.TabIndex = 12;
            IntervalCombo22.Text = "2200";
            IntervalCombo22.TextChanged += IntervalCombo22_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(574, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 15);
            label4.TabIndex = 11;
            label4.Text = "Intervalo1 (ms):";
            // 
            // IntervalCombo12
            // 
            IntervalCombo12.Location = new System.Drawing.Point(400, 73);
            IntervalCombo12.Name = "IntervalCombo12";
            IntervalCombo12.Size = new System.Drawing.Size(100, 23);
            IntervalCombo12.TabIndex = 16;
            IntervalCombo12.Text = "2200";
            IntervalCombo12.TextChanged += IntervalCombo12_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(305, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 15);
            label5.TabIndex = 15;
            label5.Text = "Intervalo1 (ms):";
            // 
            // intervalCombo11
            // 
            intervalCombo11.Location = new System.Drawing.Point(400, 48);
            intervalCombo11.Name = "intervalCombo11";
            intervalCombo11.Size = new System.Drawing.Size(100, 23);
            intervalCombo11.TabIndex = 14;
            intervalCombo11.Text = "2200";
            intervalCombo11.TextChanged += intervalCombo11_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(305, 51);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 15);
            label6.TabIndex = 13;
            label6.Text = "Intervalo1 (ms):";
            // 
            // intervalHealing2
            // 
            intervalHealing2.Location = new System.Drawing.Point(107, 73);
            intervalHealing2.Name = "intervalHealing2";
            intervalHealing2.Size = new System.Drawing.Size(100, 23);
            intervalHealing2.TabIndex = 20;
            intervalHealing2.Text = "1000";
            intervalHealing2.TextChanged += intervalHealing2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 76);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(89, 15);
            label7.TabIndex = 19;
            label7.Text = "Intervalo1 (ms):";
            // 
            // intervalHealing1
            // 
            intervalHealing1.Location = new System.Drawing.Point(107, 48);
            intervalHealing1.Name = "intervalHealing1";
            intervalHealing1.Size = new System.Drawing.Size(100, 23);
            intervalHealing1.TabIndex = 18;
            intervalHealing1.Text = "1000";
            intervalHealing1.TextChanged += intervalHealing1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 51);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(89, 15);
            label8.TabIndex = 17;
            label8.Text = "Intervalo1 (ms):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(107, 104);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(80, 15);
            label9.TabIndex = 21;
            label9.Text = "Hotkey: insert";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(305, 104);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(82, 15);
            label10.TabIndex = 22;
            label10.Text = "Hotkey: home";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(574, 104);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(83, 15);
            label11.TabIndex = 23;
            label11.Text = "Hotkey: delete";
            // 
            // btnCalibrarHealing
            // 
            btnCalibrarHealing.Location = new System.Drawing.Point(12, 100);
            btnCalibrarHealing.Name = "btnCalibrarHealing";
            btnCalibrarHealing.Size = new System.Drawing.Size(75, 23);
            btnCalibrarHealing.TabIndex = 24;
            btnCalibrarHealing.Text = "Calibrar";
            btnCalibrarHealing.UseVisualStyleBackColor = true;
            btnCalibrarHealing.Click += btn_Calibrar_Healing_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 187);
            Controls.Add(btnCalibrarHealing);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(intervalHealing2);
            Controls.Add(label7);
            Controls.Add(intervalHealing1);
            Controls.Add(label8);
            Controls.Add(IntervalCombo12);
            Controls.Add(label5);
            Controls.Add(intervalCombo11);
            Controls.Add(label6);
            Controls.Add(IntervalCombo22);
            Controls.Add(label4);
            Controls.Add(IntervalCombo21);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ComboLabel1);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "HomePage";
            FormClosing += formEvent_closing;
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button HealingStart;
        private System.Windows.Forms.Button HealingStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ComboLabel1;
        private System.Windows.Forms.Button ComboStop1;
        private System.Windows.Forms.Button ComboStart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ComboStop2;
        private System.Windows.Forms.Button ComboStart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntervalCombo21;
        private System.Windows.Forms.TextBox IntervalCombo22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IntervalCombo12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox intervalCombo11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox intervalHealing2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox intervalHealing1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalibrarHealing;
    }
}