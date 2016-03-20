namespace Merge
{
    partial class Merge
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
            this.btnFirstFile = new System.Windows.Forms.Button();
            this.btnSecondFile = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.textBoxFirstFullPath = new System.Windows.Forms.TextBox();
            this.textBoxSecondFullPath = new System.Windows.Forms.TextBox();
            this.richTextBoxMerge = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnFirstFile
            // 
            this.btnFirstFile.Location = new System.Drawing.Point(0, 11);
            this.btnFirstFile.Name = "btnFirstFile";
            this.btnFirstFile.Size = new System.Drawing.Size(113, 23);
            this.btnFirstFile.TabIndex = 0;
            this.btnFirstFile.Text = "Первый файл";
            this.btnFirstFile.UseVisualStyleBackColor = true;
            this.btnFirstFile.Click += new System.EventHandler(this.btnFirstFile_Click);
            // 
            // btnSecondFile
            // 
            this.btnSecondFile.Location = new System.Drawing.Point(0, 40);
            this.btnSecondFile.Name = "btnSecondFile";
            this.btnSecondFile.Size = new System.Drawing.Size(113, 23);
            this.btnSecondFile.TabIndex = 1;
            this.btnSecondFile.Text = "Второй файл";
            this.btnSecondFile.UseVisualStyleBackColor = true;
            this.btnSecondFile.Click += new System.EventHandler(this.btnSecondFile_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(521, 14);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(106, 49);
            this.btnMerge.TabIndex = 2;
            this.btnMerge.Text = "Объединить";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // textBoxFirstFullPath
            // 
            this.textBoxFirstFullPath.Location = new System.Drawing.Point(119, 14);
            this.textBoxFirstFullPath.Name = "textBoxFirstFullPath";
            this.textBoxFirstFullPath.Size = new System.Drawing.Size(379, 20);
            this.textBoxFirstFullPath.TabIndex = 3;
            // 
            // textBoxSecondFullPath
            // 
            this.textBoxSecondFullPath.Location = new System.Drawing.Point(119, 43);
            this.textBoxSecondFullPath.Name = "textBoxSecondFullPath";
            this.textBoxSecondFullPath.Size = new System.Drawing.Size(379, 20);
            this.textBoxSecondFullPath.TabIndex = 4;
            // 
            // richTextBoxMerge
            // 
            this.richTextBoxMerge.Location = new System.Drawing.Point(0, 70);
            this.richTextBoxMerge.Name = "richTextBoxMerge";
            this.richTextBoxMerge.Size = new System.Drawing.Size(627, 489);
            this.richTextBoxMerge.TabIndex = 6;
            this.richTextBoxMerge.Text = "";
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 561);
            this.Controls.Add(this.richTextBoxMerge);
            this.Controls.Add(this.textBoxSecondFullPath);
            this.Controls.Add(this.textBoxFirstFullPath);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSecondFile);
            this.Controls.Add(this.btnFirstFile);
            this.Name = "Merge";
            this.Text = "Объединение файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstFile;
        private System.Windows.Forms.Button btnSecondFile;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox textBoxFirstFullPath;
        private System.Windows.Forms.TextBox textBoxSecondFullPath;
        private System.Windows.Forms.RichTextBox richTextBoxMerge;
    }
}

