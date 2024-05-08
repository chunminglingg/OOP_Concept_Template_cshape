namespace OOP
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_floor = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr
            // 
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr.Location = new System.Drawing.Point(367, 11);
            this.dgr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgr.Name = "dgr";
            this.dgr.RowHeadersWidth = 51;
            this.dgr.RowTemplate.Height = 24;
            this.dgr.Size = new System.Drawing.Size(383, 504);
            this.dgr.TabIndex = 0;
            this.dgr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellContentClick);
            // 
            // dgr_class
            // 
            this.dgr_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_class.Location = new System.Drawing.Point(770, 11);
            this.dgr_class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgr_class.Name = "dgr_class";
            this.dgr_class.RowHeadersWidth = 51;
            this.dgr_class.RowTemplate.Height = 24;
            this.dgr_class.Size = new System.Drawing.Size(304, 504);
            this.dgr_class.TabIndex = 0;
            this.dgr_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellContentClick);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(13, 56);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name";
            // 
            // lb_floor
            // 
            this.lb_floor.AutoSize = true;
            this.lb_floor.Location = new System.Drawing.Point(12, 100);
            this.lb_floor.Name = "lb_floor";
            this.lb_floor.Size = new System.Drawing.Size(30, 13);
            this.lb_floor.TabIndex = 1;
            this.lb_floor.Text = "Floor";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(77, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(216, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(77, 96);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(216, 20);
            this.txt_floor.TabIndex = 2;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Location = new System.Drawing.Point(12, 150);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(60, 13);
            this.lb_des.TabIndex = 1;
            this.lb_des.Text = "Description";
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(77, 150);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(216, 103);
            this.txt_des.TabIndex = 2;
            this.txt_des.TextChanged += new System.EventHandler(this.txt_des_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(214, 275);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 28);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 526);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_floor);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_floor);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.dgr_class);
            this.Controls.Add(this.dgr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr;
        private System.Windows.Forms.DataGridView dgr_class;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_floor;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_floor;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Button btn_save;
    }
}

