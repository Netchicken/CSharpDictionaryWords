namespace CSharpDictionaryWords
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
            this.BtnLoadWords = new System.Windows.Forms.Button();
            this.txtEnterWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbxAnswer = new System.Windows.Forms.ListBox();
            this.pbxDict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDict)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadWords
            // 
            this.BtnLoadWords.Location = new System.Drawing.Point(65, 43);
            this.BtnLoadWords.Name = "BtnLoadWords";
            this.BtnLoadWords.Size = new System.Drawing.Size(144, 57);
            this.BtnLoadWords.TabIndex = 0;
            this.BtnLoadWords.Text = "Load Words";
            this.BtnLoadWords.UseVisualStyleBackColor = true;
            this.BtnLoadWords.Click += new System.EventHandler(this.BtnLoadWords_Click);
            // 
            // txtEnterWord
            // 
            this.txtEnterWord.Location = new System.Drawing.Point(70, 120);
            this.txtEnterWord.Name = "txtEnterWord";
            this.txtEnterWord.Size = new System.Drawing.Size(139, 22);
            this.txtEnterWord.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(65, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 71);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search For Word";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbxAnswer
            // 
            this.lbxAnswer.FormattingEnabled = true;
            this.lbxAnswer.ItemHeight = 16;
            this.lbxAnswer.Location = new System.Drawing.Point(241, 41);
            this.lbxAnswer.Name = "lbxAnswer";
            this.lbxAnswer.Size = new System.Drawing.Size(179, 212);
            this.lbxAnswer.TabIndex = 3;
            // 
            // pbxDict
            // 
            this.pbxDict.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxDict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDict.Image = global::CSharpDictionaryWords.Resource1.dictImage;
            this.pbxDict.Location = new System.Drawing.Point(0, 0);
            this.pbxDict.Name = "pbxDict";
            this.pbxDict.Size = new System.Drawing.Size(422, 280);
            this.pbxDict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDict.TabIndex = 4;
            this.pbxDict.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 280);
            this.Controls.Add(this.lbxAnswer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnterWord);
            this.Controls.Add(this.BtnLoadWords);
            this.Controls.Add(this.pbxDict);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadWords;
        private System.Windows.Forms.TextBox txtEnterWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxAnswer;
        private System.Windows.Forms.PictureBox pbxDict;
    }
}

