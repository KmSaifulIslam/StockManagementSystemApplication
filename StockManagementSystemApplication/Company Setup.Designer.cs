﻿namespace StockManagementSystemApplication
{
    partial class Company_Setup
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
            this.label1 = new System.Windows.Forms.Label();
            this.CompanytextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanydataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CompanydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CompanytextBox
            // 
            this.CompanytextBox.Location = new System.Drawing.Point(129, 32);
            this.CompanytextBox.Name = "CompanytextBox";
            this.CompanytextBox.Size = new System.Drawing.Size(193, 20);
            this.CompanytextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(239, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CompanydataGridView
            // 
            this.CompanydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanydataGridView.Location = new System.Drawing.Point(37, 150);
            this.CompanydataGridView.Name = "CompanydataGridView";
            this.CompanydataGridView.Size = new System.Drawing.Size(319, 244);
            this.CompanydataGridView.TabIndex = 3;
            // 
            // Company_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 420);
            this.Controls.Add(this.CompanydataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CompanytextBox);
            this.Controls.Add(this.label1);
            this.Name = "Company_Setup";
            this.Text = "Company_Setup";
            ((System.ComponentModel.ISupportInitialize)(this.CompanydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanytextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView CompanydataGridView;
    }
}