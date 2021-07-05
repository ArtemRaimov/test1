
namespace WinFormsApp1
{
    partial class MainForm
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
            this.SMTPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ThemeTextBox = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TemplateButton = new System.Windows.Forms.Button();
            this.DraftButton = new System.Windows.Forms.Button();
            this.PostponeButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.RecipientTextBox = new System.Windows.Forms.TextBox();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SMTPTextBox
            // 
            this.SMTPTextBox.Location = new System.Drawing.Point(120, 13);
            this.SMTPTextBox.Name = "SMTPTextBox";
            this.SMTPTextBox.Size = new System.Drawing.Size(125, 27);
            this.SMTPTextBox.TabIndex = 0;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(120, 61);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(125, 27);
            this.PortTextBox.TabIndex = 1;
            // 
            // ThemeTextBox
            // 
            this.ThemeTextBox.Location = new System.Drawing.Point(120, 109);
            this.ThemeTextBox.Multiline = true;
            this.ThemeTextBox.Name = "ThemeTextBox";
            this.ThemeTextBox.Size = new System.Drawing.Size(482, 27);
            this.ThemeTextBox.TabIndex = 2;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(120, 161);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(482, 156);
            this.TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SMTP сервер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тема:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Текст:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Получатель:";
            // 
            // TemplateButton
            // 
            this.TemplateButton.Location = new System.Drawing.Point(608, 161);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(104, 48);
            this.TemplateButton.TabIndex = 9;
            this.TemplateButton.Text = "Шаблоны";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // DraftButton
            // 
            this.DraftButton.Location = new System.Drawing.Point(608, 215);
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Size = new System.Drawing.Size(104, 48);
            this.DraftButton.TabIndex = 10;
            this.DraftButton.Text = "Черновики";
            this.DraftButton.UseVisualStyleBackColor = true;
            this.DraftButton.Click += new System.EventHandler(this.DraftButton_Click);
            // 
            // PostponeButton
            // 
            this.PostponeButton.Location = new System.Drawing.Point(608, 269);
            this.PostponeButton.Name = "PostponeButton";
            this.PostponeButton.Size = new System.Drawing.Size(104, 48);
            this.PostponeButton.TabIndex = 11;
            this.PostponeButton.Text = "Отложенная отправка";
            this.PostponeButton.UseVisualStyleBackColor = true;
            this.PostponeButton.Click += new System.EventHandler(this.PostponeButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(120, 392);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(104, 48);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.Location = new System.Drawing.Point(120, 345);
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.Size = new System.Drawing.Size(125, 27);
            this.RecipientTextBox.TabIndex = 13;
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(463, 34);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(125, 27);
            this.SenderTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя отправителя:";
            // 
            // ListsButton
            // 
            this.ListsButton.Location = new System.Drawing.Point(284, 344);
            this.ListsButton.Name = "ListsButton";
            this.ListsButton.Size = new System.Drawing.Size(134, 29);
            this.ListsButton.TabIndex = 16;
            this.ListsButton.Text = "Выбрать список";
            this.ListsButton.UseVisualStyleBackColor = true;
            this.ListsButton.Click += new System.EventHandler(this.ListsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 454);
            this.Controls.Add(this.ListsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.RecipientTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.PostponeButton);
            this.Controls.Add(this.DraftButton);
            this.Controls.Add(this.TemplateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ThemeTextBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.SMTPTextBox);
            this.Name = "MainForm";
            this.Text = "Почтовый клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SMTPTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox ThemeTextBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TemplateButton;
        private System.Windows.Forms.Button DraftButton;
        private System.Windows.Forms.Button PostponeButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox RecipientTextBox;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ListsButton;
    }
}