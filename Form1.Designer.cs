namespace SignalSimulatorWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_b1 = new TextBox();
            labelb = new Label();
            labela = new Label();
            txt_a1 = new TextBox();
            txt_nmax = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txt_delta = new TextBox();
            label10 = new Label();
            txt_omega = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            txt_a0 = new TextBox();
            label2 = new Label();
            txt_N = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(459, 48);
            label1.TabIndex = 1;
            label1.Text = "SIGNAL SIMULATOR";
            // 
            // txt_b1
            // 
            txt_b1.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_b1.Location = new Point(166, 99);
            txt_b1.Name = "txt_b1";
            txt_b1.Size = new Size(124, 30);
            txt_b1.TabIndex = 2;
            txt_b1.TextAlign = HorizontalAlignment.Center;
            txt_b1.TextChanged += txt_b1_TextChanged;
            // 
            // labelb
            // 
            labelb.AutoSize = true;
            labelb.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelb.Location = new Point(210, 75);
            labelb.Name = "labelb";
            labelb.Size = new Size(27, 21);
            labelb.TabIndex = 3;
            labelb.Text = "B1";
            labelb.Click += label2_Click;
            // 
            // labela
            // 
            labela.AutoSize = true;
            labela.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labela.Location = new Point(69, 75);
            labela.Name = "labela";
            labela.Size = new Size(28, 21);
            labela.TabIndex = 11;
            labela.Text = "A1";
            // 
            // txt_a1
            // 
            txt_a1.Font = new Font("Agency FB", 14.25F);
            txt_a1.Location = new Point(25, 99);
            txt_a1.Name = "txt_a1";
            txt_a1.Size = new Size(124, 30);
            txt_a1.TabIndex = 10;
            txt_a1.TextAlign = HorizontalAlignment.Center;
            txt_a1.TextChanged += textBox5_TextChanged;
            // 
            // txt_nmax
            // 
            txt_nmax.Enabled = false;
            txt_nmax.Font = new Font("Agency FB", 14.25F);
            txt_nmax.Location = new Point(392, 90);
            txt_nmax.Name = "txt_nmax";
            txt_nmax.Size = new Size(124, 30);
            txt_nmax.TabIndex = 12;
            txt_nmax.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(426, 66);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 13;
            label7.Text = "n_max";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(413, 132);
            label9.Name = "label9";
            label9.Size = new Size(84, 21);
            label9.TabIndex = 17;
            label9.Text = "DELTA_T";
            // 
            // txt_delta
            // 
            txt_delta.Enabled = false;
            txt_delta.Font = new Font("Agency FB", 14.25F);
            txt_delta.Location = new Point(392, 156);
            txt_delta.Name = "txt_delta";
            txt_delta.Size = new Size(124, 30);
            txt_delta.TabIndex = 16;
            txt_delta.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(413, 199);
            label10.Name = "label10";
            label10.Size = new Size(94, 21);
            label10.TabIndex = 19;
            label10.Text = "OMEGA_0";
            // 
            // txt_omega
            // 
            txt_omega.Enabled = false;
            txt_omega.Font = new Font("Agency FB", 14.25F);
            txt_omega.Location = new Point(391, 223);
            txt_omega.Name = "txt_omega";
            txt_omega.Size = new Size(124, 30);
            txt_omega.TabIndex = 18;
            txt_omega.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(284, 415);
            button1.Name = "button1";
            button1.Size = new Size(232, 50);
            button1.TabIndex = 20;
            button1.Text = "HESABLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(296, 99);
            button2.Name = "button2";
            button2.Size = new Size(81, 30);
            button2.TabIndex = 21;
            button2.Text = "Əlavə et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(426, 274);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 23;
            label3.Text = "A_0";
            label3.Click += label3_Click;
            // 
            // txt_a0
            // 
            txt_a0.Enabled = false;
            txt_a0.Font = new Font("Agency FB", 14.25F);
            txt_a0.Location = new Point(391, 298);
            txt_a0.Name = "txt_a0";
            txt_a0.Size = new Size(124, 30);
            txt_a0.TabIndex = 22;
            txt_a0.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(427, 340);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 25;
            label2.Text = "N";
            // 
            // txt_N
            // 
            txt_N.Enabled = false;
            txt_N.Font = new Font("Agency FB", 14.25F);
            txt_N.Location = new Point(392, 364);
            txt_N.Name = "txt_N";
            txt_N.Size = new Size(124, 30);
            txt_N.TabIndex = 24;
            txt_N.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 71, 57);
            ClientSize = new Size(656, 490);
            Controls.Add(label2);
            Controls.Add(txt_N);
            Controls.Add(label3);
            Controls.Add(txt_a0);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(txt_omega);
            Controls.Add(label9);
            Controls.Add(txt_delta);
            Controls.Add(label7);
            Controls.Add(txt_nmax);
            Controls.Add(labela);
            Controls.Add(txt_a1);
            Controls.Add(labelb);
            Controls.Add(txt_b1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_b1;
        private Label labelb;
        private Label labela;
        private TextBox txt_a1;
        private TextBox txt_nmax;
        private Label label7;
        private Label label9;
        private TextBox txt_delta;
        private Label label10;
        private TextBox txt_omega;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox txt_a0;
        private Label label2;
        private TextBox txt_N;
    }
}
