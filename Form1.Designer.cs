namespace laporan1
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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sekolah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namatb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sekolahcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kotacb = new System.Windows.Forms.ComboBox();
            this.Simpanbtn = new System.Windows.Forms.Button();
            this.IDtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nama,
            this.Sekolah});
            this.datagridview.Location = new System.Drawing.Point(32, 53);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(741, 198);
            this.datagridview.TabIndex = 0;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Sekolah
            // 
            this.Sekolah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sekolah.DataPropertyName = "Sekolah";
            this.Sekolah.HeaderText = "Sekolah";
            this.Sekolah.Name = "Sekolah";
            // 
            // namatb
            // 
            this.namatb.Location = new System.Drawing.Point(121, 291);
            this.namatb.Name = "namatb";
            this.namatb.Size = new System.Drawing.Size(201, 20);
            this.namatb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            // 
            // sekolahcb
            // 
            this.sekolahcb.FormattingEnabled = true;
            this.sekolahcb.Location = new System.Drawing.Point(121, 342);
            this.sekolahcb.Name = "sekolahcb";
            this.sekolahcb.Size = new System.Drawing.Size(201, 21);
            this.sekolahcb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sekolah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kota";
            // 
            // kotacb
            // 
            this.kotacb.FormattingEnabled = true;
            this.kotacb.Location = new System.Drawing.Point(121, 396);
            this.kotacb.Name = "kotacb";
            this.kotacb.Size = new System.Drawing.Size(201, 21);
            this.kotacb.TabIndex = 5;
            // 
            // Simpanbtn
            // 
            this.Simpanbtn.Location = new System.Drawing.Point(395, 342);
            this.Simpanbtn.Name = "Simpanbtn";
            this.Simpanbtn.Size = new System.Drawing.Size(102, 23);
            this.Simpanbtn.TabIndex = 7;
            this.Simpanbtn.Text = "Simpan";
            this.Simpanbtn.UseVisualStyleBackColor = true;
            this.Simpanbtn.Click += new System.EventHandler(this.Simpanbtn_Click);
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(334, 134);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(201, 20);
            this.IDtb.TabIndex = 8;
            this.IDtb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Simpanbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kotacb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sekolahcb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namatb);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.IDtb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.TextBox namatb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sekolahcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kotacb;
        private System.Windows.Forms.Button Simpanbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sekolah;
        private System.Windows.Forms.TextBox IDtb;
    }
}

