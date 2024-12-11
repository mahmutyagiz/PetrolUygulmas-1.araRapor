namespace Petroluygulamsı_1
{
    partial class ürünler
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petrol = new Petroluygulamsı_1.Petrol();
            this.petrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petrolDataSet = new Petroluygulamsı_1.PetrolDataSet();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new Petroluygulamsı_1.PetrolDataSetTableAdapters.urunTableAdapter();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(153, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(153, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(153, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(153, 217);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(153, 259);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 27);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stok Durumu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(8, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(153, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(300, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 407);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // petrol
            // 
            this.petrol.DataSetName = "Petrol";
            this.petrol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petrolBindingSource
            // 
            this.petrolBindingSource.DataSource = this.petrol;
            this.petrolBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunADIDataGridViewTextBoxColumn,
            this.urunMARKADataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn,
            this.urunTipDataGridViewTextBoxColumn,
            this.stokmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(495, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 295);
            this.dataGridView1.TabIndex = 16;
            // 
            // petrolDataSet
            // 
            this.petrolDataSet.DataSetName = "PetrolDataSet";
            this.petrolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.petrolDataSet;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunADIDataGridViewTextBoxColumn
            // 
            this.urunADIDataGridViewTextBoxColumn.DataPropertyName = "UrunADI";
            this.urunADIDataGridViewTextBoxColumn.HeaderText = "UrunADI";
            this.urunADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunADIDataGridViewTextBoxColumn.Name = "urunADIDataGridViewTextBoxColumn";
            this.urunADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunMARKADataGridViewTextBoxColumn
            // 
            this.urunMARKADataGridViewTextBoxColumn.DataPropertyName = "UrunMARKA";
            this.urunMARKADataGridViewTextBoxColumn.HeaderText = "UrunMARKA";
            this.urunMARKADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunMARKADataGridViewTextBoxColumn.Name = "urunMARKADataGridViewTextBoxColumn";
            this.urunMARKADataGridViewTextBoxColumn.Width = 125;
            // 
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "Urunfiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "Urunfiyat";
            this.urunfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            this.urunfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunTipDataGridViewTextBoxColumn
            // 
            this.urunTipDataGridViewTextBoxColumn.DataPropertyName = "UrunTip";
            this.urunTipDataGridViewTextBoxColumn.HeaderText = "UrunTip";
            this.urunTipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunTipDataGridViewTextBoxColumn.Name = "urunTipDataGridViewTextBoxColumn";
            this.urunTipDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokmDataGridViewTextBoxColumn
            // 
            this.stokmDataGridViewTextBoxColumn.DataPropertyName = "Stokm";
            this.stokmDataGridViewTextBoxColumn.HeaderText = "Stokm";
            this.stokmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokmDataGridViewTextBoxColumn.Name = "stokmDataGridViewTextBoxColumn";
            this.stokmDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1322, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ürünler";
            this.Text = "ürünler";
            this.Load += new System.EventHandler(this.ürünler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource petrolBindingSource;
        private Petrol petrol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetrolDataSet petrolDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private PetrolDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmDataGridViewTextBoxColumn;
    }
}