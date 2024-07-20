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
            this.chk_search_by_name = new System.Windows.Forms.CheckBox();
            this.chk_search_by_id = new System.Windows.Forms.CheckBox();
            this.chk_search_by_all = new System.Windows.Forms.CheckBox();
            this.chk_search_by_code = new System.Windows.Forms.CheckBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_class)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr
            // 
            this.dgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr.Location = new System.Drawing.Point(244, 420);
            this.dgr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgr.Name = "dgr";
            this.dgr.RowHeadersWidth = 51;
            this.dgr.RowTemplate.Height = 24;
            this.dgr.Size = new System.Drawing.Size(1228, 367);
            this.dgr.TabIndex = 0;
            this.dgr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellContentClick);
            // 
            // dgr_class
            // 
            this.dgr_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_class.Location = new System.Drawing.Point(548, 28);
            this.dgr_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgr_class.Name = "dgr_class";
            this.dgr_class.RowHeadersWidth = 51;
            this.dgr_class.RowTemplate.Height = 24;
            this.dgr_class.Size = new System.Drawing.Size(924, 260);
            this.dgr_class.TabIndex = 0;
            this.dgr_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_CellContentClick);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(116, 27);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 16);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name";
            // 
            // lb_floor
            // 
            this.lb_floor.AutoSize = true;
            this.lb_floor.Location = new System.Drawing.Point(116, 60);
            this.lb_floor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_floor.Name = "lb_floor";
            this.lb_floor.Size = new System.Drawing.Size(38, 16);
            this.lb_floor.TabIndex = 1;
            this.lb_floor.Text = "Floor";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(214, 27);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(287, 22);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(214, 60);
            this.txt_floor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(287, 22);
            this.txt_floor.TabIndex = 2;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Location = new System.Drawing.Point(116, 109);
            this.lb_des.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(75, 16);
            this.lb_des.TabIndex = 1;
            this.lb_des.Text = "Description";
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(214, 106);
            this.txt_des.Margin = new System.Windows.Forms.Padding(4);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(287, 126);
            this.txt_des.TabIndex = 2;
            this.txt_des.TextChanged += new System.EventHandler(this.txt_des_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(396, 254);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 34);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_search_by_name
            // 
            this.chk_search_by_name.AutoSize = true;
            this.chk_search_by_name.Location = new System.Drawing.Point(548, 378);
            this.chk_search_by_name.Name = "chk_search_by_name";
            this.chk_search_by_name.Size = new System.Drawing.Size(131, 20);
            this.chk_search_by_name.TabIndex = 4;
            this.chk_search_by_name.Text = "Search By Name";
            this.chk_search_by_name.UseVisualStyleBackColor = true;
            // 
            // chk_search_by_id
            // 
            this.chk_search_by_id.AutoSize = true;
            this.chk_search_by_id.Location = new System.Drawing.Point(718, 378);
            this.chk_search_by_id.Name = "chk_search_by_id";
            this.chk_search_by_id.Size = new System.Drawing.Size(105, 20);
            this.chk_search_by_id.TabIndex = 4;
            this.chk_search_by_id.Text = "Search By Id";
            this.chk_search_by_id.UseVisualStyleBackColor = true;
            this.chk_search_by_id.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_search_by_all
            // 
            this.chk_search_by_all.AutoSize = true;
            this.chk_search_by_all.Location = new System.Drawing.Point(862, 378);
            this.chk_search_by_all.Name = "chk_search_by_all";
            this.chk_search_by_all.Size = new System.Drawing.Size(90, 20);
            this.chk_search_by_all.TabIndex = 4;
            this.chk_search_by_all.Text = "Search All";
            this.chk_search_by_all.UseVisualStyleBackColor = true;
            // 
            // chk_search_by_code
            // 
            this.chk_search_by_code.AutoSize = true;
            this.chk_search_by_code.Location = new System.Drawing.Point(991, 378);
            this.chk_search_by_code.Name = "chk_search_by_code";
            this.chk_search_by_code.Size = new System.Drawing.Size(127, 20);
            this.chk_search_by_code.TabIndex = 4;
            this.chk_search_by_code.Text = "Search By Code";
            this.chk_search_by_code.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1139, 377);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(226, 22);
            this.txt_search.TabIndex = 2;
            // 
            // btn_search_Click
            // 
            this.btn_search_Click.Location = new System.Drawing.Point(1372, 369);
            this.btn_search_Click.Name = "btn_search_Click";
            this.btn_search_Click.Size = new System.Drawing.Size(100, 38);
            this.btn_search_Click.TabIndex = 5;
            this.btn_search_Click.Text = "search";
            this.btn_search_Click.UseVisualStyleBackColor = true;
            this.btn_search_Click.Click += new System.EventHandler(this.btn_search_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 798);
            this.Controls.Add(this.btn_search_Click);
            this.Controls.Add(this.chk_search_by_code);
            this.Controls.Add(this.chk_search_by_all);
            this.Controls.Add(this.chk_search_by_id);
            this.Controls.Add(this.chk_search_by_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.txt_floor);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_floor);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.dgr_class);
            this.Controls.Add(this.dgr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckBox chk_search_by_name;
        private System.Windows.Forms.CheckBox chk_search_by_id;
        private System.Windows.Forms.CheckBox chk_search_by_all;
        private System.Windows.Forms.CheckBox chk_search_by_code;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search_Click;
    }
}

