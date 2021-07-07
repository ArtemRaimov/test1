
namespace WinFormsApp1
{
    partial class RegistrationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.Pass2TB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторите пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин:";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(182, 209);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(125, 29);
            this.RegButton.TabIndex = 10;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Pass2TB
            // 
            this.Pass2TB.Location = new System.Drawing.Point(182, 150);
            this.Pass2TB.Name = "Pass2TB";
            this.Pass2TB.Size = new System.Drawing.Size(125, 27);
            this.Pass2TB.TabIndex = 9;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(182, 89);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(125, 27);
            this.PassTB.TabIndex = 8;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(182, 29);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(125, 27);
            this.LoginTB.TabIndex = 7;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.Pass2TB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.LoginTB);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox Pass2TB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LoginTB;
    }
}