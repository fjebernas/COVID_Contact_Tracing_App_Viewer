
namespace ContactTracingViewer
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnViewData = new System.Windows.Forms.Button();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(51, 94);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(323, 84);
            this.listBox.TabIndex = 3;
            // 
            // btnViewData
            // 
            this.btnViewData.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnViewData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewData.Location = new System.Drawing.Point(164, 211);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(94, 40);
            this.btnViewData.TabIndex = 4;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = false;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle1.Location = new System.Drawing.Point(97, 22);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(223, 24);
            this.labelTitle1.TabIndex = 5;
            this.labelTitle1.Text = "Contact Tracing App";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle2.Location = new System.Drawing.Point(145, 51);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(137, 24);
            this.labelTitle2.TabIndex = 5;
            this.labelTitle2.Text = "Data Viewer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(425, 298);
            this.Controls.Add(this.labelTitle2);
            this.Controls.Add(this.labelTitle1);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelTitle2;
    }
}

