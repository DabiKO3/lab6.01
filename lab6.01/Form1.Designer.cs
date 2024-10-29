namespace lab6._01
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
            this.btnPrintCountryName = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPrintCountryName
            // 
            this.btnPrintCountryName.Location = new System.Drawing.Point(91, 30);
            this.btnPrintCountryName.Name = "btnPrintCountryName";
            this.btnPrintCountryName.Size = new System.Drawing.Size(219, 32);
            this.btnPrintCountryName.TabIndex = 0;
            this.btnPrintCountryName.Text = "Вивести назву країни";
            this.btnPrintCountryName.UseVisualStyleBackColor = true;
            this.btnPrintCountryName.Click += new System.EventHandler(this.btnPrintCountryName_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(91, 86);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(219, 31);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Говорити рідною мовою";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(130, 141);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(126, 24);
            this.comboBoxPerson.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 227);
            this.Controls.Add(this.comboBoxPerson);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnPrintCountryName);
            this.Name = "Form1";
            this.Text = "Лабораторної роботи №6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintCountryName;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.ComboBox comboBoxPerson;
    }
}

