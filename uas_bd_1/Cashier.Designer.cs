namespace uas_bd_1
{
    partial class Cashier
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
            this.obat_list = new System.Windows.Forms.DataGridView();
            this.item_list = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.confirm_purchase = new System.Windows.Forms.Button();
            this.input_jlh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_filter = new System.Windows.Forms.Label();
            this.in_filter_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filter_id_btn = new System.Windows.Forms.Button();
            this.filter_unit_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filter_name_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.in_filter_merek = new System.Windows.Forms.TextBox();
            this.in_filter_unit = new System.Windows.Forms.ComboBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label_price_1 = new System.Windows.Forms.Label();
            this.label_price_2 = new System.Windows.Forms.Label();
            this.id_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.obat_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_jlh)).BeginInit();
            this.SuspendLayout();
            // 
            // obat_list
            // 
            this.obat_list.AllowUserToAddRows = false;
            this.obat_list.AllowUserToDeleteRows = false;
            this.obat_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obat_list.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.obat_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obat_list.Location = new System.Drawing.Point(12, 12);
            this.obat_list.Name = "obat_list";
            this.obat_list.ReadOnly = true;
            this.obat_list.RowHeadersWidth = 51;
            this.obat_list.RowTemplate.Height = 24;
            this.obat_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.obat_list.Size = new System.Drawing.Size(521, 373);
            this.obat_list.TabIndex = 0;
            this.obat_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obat_list_CellClick);
            this.obat_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item_list
            // 
            this.item_list.AllowUserToAddRows = false;
            this.item_list.AllowUserToDeleteRows = false;
            this.item_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_list.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.item_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_obat,
            this.nama_obat,
            this.satuan_obat,
            this.stok_obat,
            this.harga_obat});
            this.item_list.Location = new System.Drawing.Point(659, 12);
            this.item_list.Name = "item_list";
            this.item_list.ReadOnly = true;
            this.item_list.RowHeadersWidth = 51;
            this.item_list.RowTemplate.Height = 24;
            this.item_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_list.Size = new System.Drawing.Size(518, 373);
            this.item_list.TabIndex = 1;
            this.item_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_list_CellClick);
            this.item_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_list_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.add_btn.Location = new System.Drawing.Point(539, 159);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(114, 37);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add >";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.remove_btn.Location = new System.Drawing.Point(539, 202);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(114, 37);
            this.remove_btn.TabIndex = 3;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // confirm_purchase
            // 
            this.confirm_purchase.Font = new System.Drawing.Font("Trueno", 8F);
            this.confirm_purchase.Location = new System.Drawing.Point(659, 408);
            this.confirm_purchase.Name = "confirm_purchase";
            this.confirm_purchase.Size = new System.Drawing.Size(151, 37);
            this.confirm_purchase.TabIndex = 4;
            this.confirm_purchase.Text = "Confirm";
            this.confirm_purchase.UseVisualStyleBackColor = true;
            this.confirm_purchase.Click += new System.EventHandler(this.confirm_purchase_Click);
            // 
            // input_jlh
            // 
            this.input_jlh.Font = new System.Drawing.Font("Trueno", 8F);
            this.input_jlh.Location = new System.Drawing.Point(539, 125);
            this.input_jlh.Name = "input_jlh";
            this.input_jlh.Size = new System.Drawing.Size(114, 23);
            this.input_jlh.TabIndex = 5;
            this.input_jlh.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trueno", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(554, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "# of Items";
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.Font = new System.Drawing.Font("Trueno", 10F);
            this.label_filter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_filter.Location = new System.Drawing.Point(12, 388);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(82, 20);
            this.label_filter.TabIndex = 7;
            this.label_filter.Text = "Filter by:";
            // 
            // in_filter_id
            // 
            this.in_filter_id.Font = new System.Drawing.Font("Trueno", 8F);
            this.in_filter_id.Location = new System.Drawing.Point(84, 415);
            this.in_filter_id.Name = "in_filter_id";
            this.in_filter_id.Size = new System.Drawing.Size(183, 23);
            this.in_filter_id.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trueno", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // filter_id_btn
            // 
            this.filter_id_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.filter_id_btn.Location = new System.Drawing.Point(273, 416);
            this.filter_id_btn.Name = "filter_id_btn";
            this.filter_id_btn.Size = new System.Drawing.Size(63, 22);
            this.filter_id_btn.TabIndex = 10;
            this.filter_id_btn.Text = "Go";
            this.filter_id_btn.UseVisualStyleBackColor = true;
            this.filter_id_btn.Click += new System.EventHandler(this.filter_id_btn_Click);
            // 
            // filter_unit_btn
            // 
            this.filter_unit_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.filter_unit_btn.Location = new System.Drawing.Point(273, 465);
            this.filter_unit_btn.Name = "filter_unit_btn";
            this.filter_unit_btn.Size = new System.Drawing.Size(63, 22);
            this.filter_unit_btn.TabIndex = 16;
            this.filter_unit_btn.Text = "Go";
            this.filter_unit_btn.UseVisualStyleBackColor = true;
            this.filter_unit_btn.Click += new System.EventHandler(this.filter_unit_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trueno", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type";
            // 
            // filter_name_btn
            // 
            this.filter_name_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.filter_name_btn.Location = new System.Drawing.Point(273, 514);
            this.filter_name_btn.Name = "filter_name_btn";
            this.filter_name_btn.Size = new System.Drawing.Size(63, 22);
            this.filter_name_btn.TabIndex = 19;
            this.filter_name_btn.Text = "Go";
            this.filter_name_btn.UseVisualStyleBackColor = true;
            this.filter_name_btn.Click += new System.EventHandler(this.filter_name_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trueno", 8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Merek";
            // 
            // in_filter_merek
            // 
            this.in_filter_merek.Font = new System.Drawing.Font("Trueno", 8F);
            this.in_filter_merek.Location = new System.Drawing.Point(84, 513);
            this.in_filter_merek.Name = "in_filter_merek";
            this.in_filter_merek.Size = new System.Drawing.Size(183, 23);
            this.in_filter_merek.TabIndex = 17;
            // 
            // in_filter_unit
            // 
            this.in_filter_unit.Font = new System.Drawing.Font("Trueno", 7F);
            this.in_filter_unit.FormattingEnabled = true;
            this.in_filter_unit.Items.AddRange(new object[] {
            "Items",
            "Bottle",
            "Drops",
            "Tablets",
            "Capsules",
            "Suppositories"});
            this.in_filter_unit.Location = new System.Drawing.Point(84, 465);
            this.in_filter_unit.Name = "in_filter_unit";
            this.in_filter_unit.Size = new System.Drawing.Size(183, 22);
            this.in_filter_unit.TabIndex = 21;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.exit_btn.Location = new System.Drawing.Point(659, 506);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(151, 37);
            this.exit_btn.TabIndex = 22;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Trueno", 8F);
            this.reset_btn.Location = new System.Drawing.Point(659, 457);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(151, 37);
            this.reset_btn.TabIndex = 23;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // label_price_1
            // 
            this.label_price_1.AutoSize = true;
            this.label_price_1.BackColor = System.Drawing.Color.White;
            this.label_price_1.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_price_1.Location = new System.Drawing.Point(825, 413);
            this.label_price_1.Margin = new System.Windows.Forms.Padding(5);
            this.label_price_1.Name = "label_price_1";
            this.label_price_1.Padding = new System.Windows.Forms.Padding(5);
            this.label_price_1.Size = new System.Drawing.Size(64, 27);
            this.label_price_1.TabIndex = 24;
            this.label_price_1.Text = "Total : ";
            this.label_price_1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_price_2
            // 
            this.label_price_2.AutoSize = true;
            this.label_price_2.BackColor = System.Drawing.Color.White;
            this.label_price_2.Font = new System.Drawing.Font("Trueno", 8F);
            this.label_price_2.Location = new System.Drawing.Point(883, 413);
            this.label_price_2.Margin = new System.Windows.Forms.Padding(5);
            this.label_price_2.Name = "label_price_2";
            this.label_price_2.Padding = new System.Windows.Forms.Padding(5);
            this.label_price_2.Size = new System.Drawing.Size(28, 27);
            this.label_price_2.TabIndex = 25;
            this.label_price_2.Text = "0";
            // 
            // id_obat
            // 
            this.id_obat.HeaderText = "id";
            this.id_obat.MinimumWidth = 6;
            this.id_obat.Name = "id_obat";
            this.id_obat.ReadOnly = true;
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "merek dagang";
            this.nama_obat.MinimumWidth = 6;
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.ReadOnly = true;
            // 
            // satuan_obat
            // 
            this.satuan_obat.HeaderText = "satuan";
            this.satuan_obat.MinimumWidth = 6;
            this.satuan_obat.Name = "satuan_obat";
            this.satuan_obat.ReadOnly = true;
            // 
            // stok_obat
            // 
            this.stok_obat.HeaderText = "jumlah";
            this.stok_obat.MinimumWidth = 6;
            this.stok_obat.Name = "stok_obat";
            this.stok_obat.ReadOnly = true;
            // 
            // harga_obat
            // 
            this.harga_obat.HeaderText = "harga";
            this.harga_obat.MinimumWidth = 6;
            this.harga_obat.Name = "harga_obat";
            this.harga_obat.ReadOnly = true;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1189, 559);
            this.Controls.Add(this.label_price_2);
            this.Controls.Add(this.label_price_1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.in_filter_unit);
            this.Controls.Add(this.filter_name_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.in_filter_merek);
            this.Controls.Add(this.filter_unit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filter_id_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in_filter_id);
            this.Controls.Add(this.label_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_jlh);
            this.Controls.Add(this.confirm_purchase);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.item_list);
            this.Controls.Add(this.obat_list);
            this.Name = "Cashier";
            this.Text = "Kasir";
            ((System.ComponentModel.ISupportInitialize)(this.obat_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_jlh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView obat_list;
        private System.Windows.Forms.DataGridView item_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button confirm_purchase;
        private System.Windows.Forms.NumericUpDown input_jlh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.TextBox in_filter_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filter_id_btn;
        private System.Windows.Forms.Button filter_unit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button filter_name_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox in_filter_merek;
        private System.Windows.Forms.ComboBox in_filter_unit;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label_price_1;
        private System.Windows.Forms.Label label_price_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_obat;
    }
}