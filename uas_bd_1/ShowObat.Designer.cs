
namespace uas_bd_1
{
    partial class ShowObat
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
            this.mydatagrid = new System.Windows.Forms.DataGridView();
            this.search_label = new System.Windows.Forms.Label();
            this.input_search = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.input_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_unit = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.input_exp = new System.Windows.Forms.DateTimePicker();
            this.input_stock = new System.Windows.Forms.NumericUpDown();
            this.label_exp = new System.Windows.Forms.Label();
            this.input_price = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.input_unit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.exitobat_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.input_delete = new System.Windows.Forms.TextBox();
            this.label_delete = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_price)).BeginInit();
            this.SuspendLayout();
            // 
            // mydatagrid
            // 
            this.mydatagrid.AllowUserToAddRows = false;
            this.mydatagrid.AllowUserToDeleteRows = false;
            this.mydatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mydatagrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.mydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydatagrid.Location = new System.Drawing.Point(12, 12);
            this.mydatagrid.Name = "mydatagrid";
            this.mydatagrid.ReadOnly = true;
            this.mydatagrid.RowHeadersWidth = 51;
            this.mydatagrid.RowTemplate.Height = 24;
            this.mydatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mydatagrid.Size = new System.Drawing.Size(910, 344);
            this.mydatagrid.TabIndex = 0;
            this.mydatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mydatagrid_CellClick);
            this.mydatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mydatagrid_CellContentClick);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Trueno", 10F);
            this.search_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_label.Location = new System.Drawing.Point(12, 359);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(115, 20);
            this.search_label.TabIndex = 1;
            this.search_label.Text = "Search by ID";
            // 
            // input_search
            // 
            this.input_search.Font = new System.Drawing.Font("Trueno", 10F);
            this.input_search.Location = new System.Drawing.Point(16, 385);
            this.input_search.MaxLength = 15;
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(192, 27);
            this.input_search.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.search_btn.Location = new System.Drawing.Point(217, 385);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(88, 27);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Go";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("Trueno", 8F);
            this.input_id.Location = new System.Drawing.Point(400, 389);
            this.input_id.MaxLength = 15;
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(205, 23);
            this.input_id.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trueno", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(343, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add/Edit New Entry";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_id.Location = new System.Drawing.Point(346, 392);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(23, 17);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "ID";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_stock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_stock.Location = new System.Drawing.Point(346, 430);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(48, 17);
            this.label_stock.TabIndex = 8;
            this.label_stock.Text = "Stock";
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_unit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_unit.Location = new System.Drawing.Point(346, 470);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(38, 17);
            this.label_unit.TabIndex = 10;
            this.label_unit.Text = "Unit";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_price.Location = new System.Drawing.Point(641, 430);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(43, 17);
            this.label_price.TabIndex = 12;
            this.label_price.Text = "Price";
            // 
            // input_exp
            // 
            this.input_exp.Location = new System.Drawing.Point(695, 467);
            this.input_exp.Name = "input_exp";
            this.input_exp.Size = new System.Drawing.Size(205, 22);
            this.input_exp.TabIndex = 14;
            // 
            // input_stock
            // 
            this.input_stock.Font = new System.Drawing.Font("Trueno", 8F);
            this.input_stock.Location = new System.Drawing.Point(400, 427);
            this.input_stock.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.input_stock.Name = "input_stock";
            this.input_stock.Size = new System.Drawing.Size(205, 23);
            this.input_stock.TabIndex = 15;
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_exp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_exp.Location = new System.Drawing.Point(641, 467);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(38, 17);
            this.label_exp.TabIndex = 16;
            this.label_exp.Text = "Exp.";
            // 
            // input_price
            // 
            this.input_price.Font = new System.Drawing.Font("Trueno", 8F);
            this.input_price.Location = new System.Drawing.Point(695, 428);
            this.input_price.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(205, 23);
            this.input_price.TabIndex = 17;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.add_btn.Location = new System.Drawing.Point(400, 509);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(111, 31);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // input_unit
            // 
            this.input_unit.FormattingEnabled = true;
            this.input_unit.Items.AddRange(new object[] {
            "Items",
            "Bottle",
            "Drops",
            "Tablets",
            "Capsules",
            "Suppositories"});
            this.input_unit.Location = new System.Drawing.Point(400, 467);
            this.input_unit.Name = "input_unit";
            this.input_unit.Size = new System.Drawing.Size(205, 24);
            this.input_unit.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trueno", 8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(641, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Trueno", 8F);
            this.input_name.Location = new System.Drawing.Point(695, 389);
            this.input_name.MaxLength = 65535;
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(205, 23);
            this.input_name.TabIndex = 21;
            // 
            // exitobat_btn
            // 
            this.exitobat_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.exitobat_btn.Location = new System.Drawing.Point(16, 509);
            this.exitobat_btn.Name = "exitobat_btn";
            this.exitobat_btn.Size = new System.Drawing.Size(111, 31);
            this.exitobat_btn.TabIndex = 22;
            this.exitobat_btn.Text = "Back";
            this.exitobat_btn.UseVisualStyleBackColor = true;
            this.exitobat_btn.Click += new System.EventHandler(this.exitobat_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.delete_btn.Location = new System.Drawing.Point(217, 457);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(88, 27);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "Go";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // input_delete
            // 
            this.input_delete.Font = new System.Drawing.Font("Trueno", 10F);
            this.input_delete.Location = new System.Drawing.Point(16, 457);
            this.input_delete.MaxLength = 15;
            this.input_delete.Name = "input_delete";
            this.input_delete.Size = new System.Drawing.Size(192, 27);
            this.input_delete.TabIndex = 24;
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.Font = new System.Drawing.Font("Trueno", 10F);
            this.label_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_delete.Location = new System.Drawing.Point(12, 431);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(111, 20);
            this.label_delete.TabIndex = 23;
            this.label_delete.Text = "Delete by ID";
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.edit_btn.Location = new System.Drawing.Point(517, 509);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(111, 31);
            this.edit_btn.TabIndex = 26;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // ShowObat
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(938, 555);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.input_delete);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.exitobat_btn);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_unit);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.input_stock);
            this.Controls.Add(this.input_exp);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.mydatagrid);
            this.Name = "ShowObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mydatagrid;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox input_search;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.DateTimePicker input_exp;
        private System.Windows.Forms.NumericUpDown input_stock;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.NumericUpDown input_price;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox input_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Button exitobat_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox input_delete;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.Button edit_btn;
    }
}

