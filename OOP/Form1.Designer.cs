﻿namespace OOP
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
            this.dgr = new System.Windows.Forms.DataGridView();
            this.dgr_class = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr
            // 
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr.Location = new System.Drawing.Point(12, 12);
            this.dgr.Name = "dgr";
            this.dgr.RowHeadersWidth = 51;
            this.dgr.RowTemplate.Height = 24;
            this.dgr.Size = new System.Drawing.Size(764, 495);
            this.dgr.TabIndex = 0;
            this.dgr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellContentClick);
            // 
            // dgr_class
            // 
            this.dgr_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_class.Location = new System.Drawing.Point(824, 12);
            this.dgr_class.Name = "dgr_class";
            this.dgr_class.RowHeadersWidth = 51;
            this.dgr_class.RowTemplate.Height = 24;
            this.dgr_class.Size = new System.Drawing.Size(406, 495);
            this.dgr_class.TabIndex = 0;
            this.dgr_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 528);
            this.Controls.Add(this.dgr_class);
            this.Controls.Add(this.dgr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.DataGridView dgr_class;
    }
}

