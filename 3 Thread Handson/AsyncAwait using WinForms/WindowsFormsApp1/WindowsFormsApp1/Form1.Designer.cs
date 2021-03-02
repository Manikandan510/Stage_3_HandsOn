
namespace WindowsFormsApp1
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
            this.btnProcessdFile = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessdFile
            // 
            this.btnProcessdFile.Location = new System.Drawing.Point(318, 226);
            this.btnProcessdFile.Name = "btnProcessdFile";
            this.btnProcessdFile.Size = new System.Drawing.Size(163, 51);
            this.btnProcessdFile.TabIndex = 0;
            this.btnProcessdFile.Text = "Process The File";
            this.btnProcessdFile.UseVisualStyleBackColor = true;
            this.btnProcessdFile.Click += new System.EventHandler(this.btnProcessFile);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(314, 141);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(0, 20);
            this.LblCount.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.btnProcessdFile);
            this.Name = "Form1";
            this.Text = "Count Characters in a File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessdFile;
        private System.Windows.Forms.Label LblCount;
    }
}

