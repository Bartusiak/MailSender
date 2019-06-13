namespace Zadanie6
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.toText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.contentText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fromText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.attachmentText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(88, 35);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(288, 20);
            this.toText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(88, 61);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(288, 20);
            this.subjectText.TabIndex = 3;
            // 
            // contentText
            // 
            this.contentText.Location = new System.Drawing.Point(29, 123);
            this.contentText.Multiline = true;
            this.contentText.Name = "contentText";
            this.contentText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentText.Size = new System.Drawing.Size(347, 147);
            this.contentText.TabIndex = 4;
            this.contentText.WordWrap = false;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(306, 415);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content:";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(88, 10);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(288, 20);
            this.fromText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Login:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(100, 291);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(200, 20);
            this.loginBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hasło: ";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(100, 323);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(200, 20);
            this.passBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Attachment:";
            // 
            // attachmentText
            // 
            this.attachmentText.Location = new System.Drawing.Point(100, 353);
            this.attachmentText.Name = "attachmentText";
            this.attachmentText.Size = new System.Drawing.Size(200, 20);
            this.attachmentText.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attachmentText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.contentText);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.TextBox contentText;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox attachmentText;
        private System.Windows.Forms.Button button1;
    }
}

