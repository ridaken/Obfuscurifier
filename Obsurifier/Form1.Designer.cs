namespace obscurifier
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
            btnSelectFile = new Button();
            txtFilePath = new TextBox();
            obscureBtn = new Button();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(35, 36);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(112, 34);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(153, 39);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(635, 31);
            txtFilePath.TabIndex = 1;
            // 
            // obscureBtn
            // 
            obscureBtn.Location = new Point(269, 99);
            obscureBtn.Name = "obscureBtn";
            obscureBtn.Size = new Size(252, 82);
            obscureBtn.TabIndex = 2;
            obscureBtn.Text = "Obscurify";
            obscureBtn.UseVisualStyleBackColor = true;
            obscureBtn.Click += obscureBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 212);
            Controls.Add(obscureBtn);
            Controls.Add(txtFilePath);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private TextBox txtFilePath;
        private Button obscureBtn;
    }
}
