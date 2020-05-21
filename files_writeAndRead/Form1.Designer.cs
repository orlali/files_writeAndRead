namespace files_writeAndRead
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
            this.btnWriteData = new System.Windows.Forms.Button();
            this.txtDataToAdd = new System.Windows.Forms.TextBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.lblDisplayData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(238, 228);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(139, 52);
            this.btnWriteData.TabIndex = 0;
            this.btnWriteData.Text = "add text to file";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // txtDataToAdd
            // 
            this.txtDataToAdd.Location = new System.Drawing.Point(238, 153);
            this.txtDataToAdd.Name = "txtDataToAdd";
            this.txtDataToAdd.Size = new System.Drawing.Size(148, 26);
            this.txtDataToAdd.TabIndex = 1;
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(530, 153);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(152, 48);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "read text from file";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // lblDisplayData
            // 
            this.lblDisplayData.AutoSize = true;
            this.lblDisplayData.Location = new System.Drawing.Point(530, 228);
            this.lblDisplayData.Name = "lblDisplayData";
            this.lblDisplayData.Size = new System.Drawing.Size(132, 20);
            this.lblDisplayData.TabIndex = 3;
            this.lblDisplayData.Text = "This is in the file...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayData);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.txtDataToAdd);
            this.Controls.Add(this.btnWriteData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.TextBox txtDataToAdd;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Label lblDisplayData;
    }
}

