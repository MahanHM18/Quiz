namespace Quiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.FinishQuizBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question3";
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(12, 68);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 20);
            this.A1.TabIndex = 3;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(12, 117);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 20);
            this.A2.TabIndex = 4;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(12, 166);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 20);
            this.A3.TabIndex = 5;
            // 
            // FinishQuizBtn
            // 
            this.FinishQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishQuizBtn.Location = new System.Drawing.Point(138, 198);
            this.FinishQuizBtn.Name = "FinishQuizBtn";
            this.FinishQuizBtn.Size = new System.Drawing.Size(158, 59);
            this.FinishQuizBtn.TabIndex = 6;
            this.FinishQuizBtn.Text = "Finish";
            this.FinishQuizBtn.UseVisualStyleBackColor = true;
            this.FinishQuizBtn.Click += new System.EventHandler(this.FinishQuizBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(460, 276);
            this.Controls.Add(this.FinishQuizBtn);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.Button FinishQuizBtn;

        #endregion
    }
}