namespace DAMS
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
            button2 = new Button();
            button1 = new Button();
            txt_PASSWORD = new TextBox();
            txt_ID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(611, 565);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 14;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(766, 565);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 13;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_PASSWORD
            // 
            txt_PASSWORD.Location = new Point(636, 404);
            txt_PASSWORD.Name = "txt_PASSWORD";
            txt_PASSWORD.Size = new Size(224, 27);
            txt_PASSWORD.TabIndex = 12;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(636, 325);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(224, 27);
            txt_ID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(428, 398);
            label3.Name = "label3";
            label3.Size = new Size(153, 31);
            label3.TabIndex = 10;
            label3.Text = "PASSWORD :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(531, 325);
            label2.Name = "label2";
            label2.Size = new Size(50, 31);
            label2.TabIndex = 9;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(611, 167);
            label1.Name = "label1";
            label1.Size = new Size(135, 50);
            label1.TabIndex = 8;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 760);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_PASSWORD);
            Controls.Add(txt_ID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "DOCTOR LOGIN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox txt_PASSWORD;
        private TextBox txt_ID;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}