namespace Lab1_Discussion
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
            panel1 = new Panel();
            buttonSL1 = new Button();
            progressBarSL1 = new ProgressBar();
            labelSL1 = new Label();
            panel2 = new Panel();
            buttonST1 = new Button();
            progressBarST1 = new ProgressBar();
            labelST1 = new Label();
            panel3 = new Panel();
            buttonSL2 = new Button();
            progressBarSL2 = new ProgressBar();
            labelSL2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(buttonSL1);
            panel1.Controls.Add(progressBarSL1);
            panel1.Controls.Add(labelSL1);
            panel1.Location = new Point(61, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 134);
            panel1.TabIndex = 0;
            // 
            // buttonSL1
            // 
            buttonSL1.Location = new Point(826, 19);
            buttonSL1.Name = "buttonSL1";
            buttonSL1.Size = new Size(112, 90);
            buttonSL1.TabIndex = 2;
            buttonSL1.Text = "TURN ON";
            buttonSL1.UseVisualStyleBackColor = true;
            buttonSL1.Click += buttonSL1_Click;
            // 
            // progressBarSL1
            // 
            progressBarSL1.Location = new Point(22, 75);
            progressBarSL1.Name = "progressBarSL1";
            progressBarSL1.Size = new Size(772, 34);
            progressBarSL1.TabIndex = 1;
            // 
            // labelSL1
            // 
            labelSL1.AutoSize = true;
            labelSL1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSL1.Location = new Point(22, 18);
            labelSL1.Name = "labelSL1";
            labelSL1.Size = new Size(181, 32);
            labelSL1.TabIndex = 0;
            labelSL1.Text = "Smart Light #1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(buttonST1);
            panel2.Controls.Add(progressBarST1);
            panel2.Controls.Add(labelST1);
            panel2.Location = new Point(61, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 134);
            panel2.TabIndex = 1;
            // 
            // buttonST1
            // 
            buttonST1.Location = new Point(826, 19);
            buttonST1.Name = "buttonST1";
            buttonST1.Size = new Size(112, 90);
            buttonST1.TabIndex = 2;
            buttonST1.Text = "TURN ON";
            buttonST1.UseVisualStyleBackColor = true;
            buttonST1.Click += buttonST1_Click;
            // 
            // progressBarST1
            // 
            progressBarST1.Location = new Point(22, 75);
            progressBarST1.Maximum = 30;
            progressBarST1.Minimum = 16;
            progressBarST1.Name = "progressBarST1";
            progressBarST1.Size = new Size(772, 34);
            progressBarST1.TabIndex = 1;
            progressBarST1.Value = 16;
            // 
            // labelST1
            // 
            labelST1.AutoSize = true;
            labelST1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelST1.Location = new Point(22, 18);
            labelST1.Name = "labelST1";
            labelST1.Size = new Size(254, 32);
            labelST1.TabIndex = 0;
            labelST1.Text = "Smart Thermostat #1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(buttonSL2);
            panel3.Controls.Add(progressBarSL2);
            panel3.Controls.Add(labelSL2);
            panel3.Location = new Point(61, 351);
            panel3.Name = "panel3";
            panel3.Size = new Size(967, 134);
            panel3.TabIndex = 2;
            // 
            // buttonSL2
            // 
            buttonSL2.Location = new Point(826, 19);
            buttonSL2.Name = "buttonSL2";
            buttonSL2.Size = new Size(112, 90);
            buttonSL2.TabIndex = 2;
            buttonSL2.Text = "TURN ON";
            buttonSL2.UseVisualStyleBackColor = true;
            buttonSL2.Click += buttonSL2_Click;
            // 
            // progressBarSL2
            // 
            progressBarSL2.Location = new Point(22, 75);
            progressBarSL2.Name = "progressBarSL2";
            progressBarSL2.Size = new Size(772, 34);
            progressBarSL2.TabIndex = 1;
            // 
            // labelSL2
            // 
            labelSL2.AutoSize = true;
            labelSL2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSL2.Location = new Point(22, 18);
            labelSL2.Name = "labelSL2";
            labelSL2.Size = new Size(181, 32);
            labelSL2.TabIndex = 0;
            labelSL2.Text = "Smart Light #2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.Location = new Point(61, 506);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Progress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 610);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonSL1;
        private ProgressBar progressBarSL1;
        private Label labelSL1;
        private Panel panel2;
        private Button buttonST1;
        private ProgressBar progressBarST1;
        private Label labelST1;
        private Panel panel3;
        private Button buttonSL2;
        private ProgressBar progressBarSL2;
        private Label labelSL2;
        private Label label4;
    }
}
