namespace Комова
{
    partial class Chef
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
            this.Recept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Newrecept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zavershit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingridient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yP06receptingridientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Комова.DataSet2();
            this.yP_06_recept_ingridientTableAdapter1 = new Комова.DataSet2TableAdapters.YP_06_recept_ingridientTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idBludaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yP06BludaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new Комова.DataSet3();
            this.yP_06_BludaTableAdapter = new Комова.DataSet3TableAdapters.YP_06_BludaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yP06receptingridientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06receptingridientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06BludaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yP06receptingridientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Recept
            // 
            this.Recept.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Recept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Recept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Recept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Recept.Location = new System.Drawing.Point(57, 265);
            this.Recept.Name = "Recept";
            this.Recept.Size = new System.Drawing.Size(341, 29);
            this.Recept.TabIndex = 8;
            this.Recept.Text = "Добавить в рецепт ингридиент";
            this.Recept.UseVisualStyleBackColor = false;
            this.Recept.Click += new System.EventHandler(this.Recept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Рецепт";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите ингридиент:";
            // 
            // Newrecept
            // 
            this.Newrecept.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Newrecept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Newrecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newrecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Newrecept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Newrecept.Location = new System.Drawing.Point(12, 12);
            this.Newrecept.Name = "Newrecept";
            this.Newrecept.Size = new System.Drawing.Size(331, 29);
            this.Newrecept.TabIndex = 20;
            this.Newrecept.Text = "Создать рецепт";
            this.Newrecept.UseVisualStyleBackColor = false;
            this.Newrecept.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите вес:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 21;
            // 
            // zavershit
            // 
            this.zavershit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.zavershit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zavershit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zavershit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zavershit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zavershit.Location = new System.Drawing.Point(57, 300);
            this.zavershit.Name = "zavershit";
            this.zavershit.Size = new System.Drawing.Size(341, 29);
            this.zavershit.TabIndex = 22;
            this.zavershit.Text = "Завершить рецепт";
            this.zavershit.UseVisualStyleBackColor = false;
            this.zavershit.Click += new System.EventHandler(this.zavershit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ingridient,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.yP06receptingridientBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(62, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 154);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_recept_ingridient";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_recept_ingridient";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ingridient
            // 
            this.ingridient.DataPropertyName = "id_recept_ingridient";
            this.ingridient.HeaderText = "ingridient";
            this.ingridient.Name = "ingridient";
            this.ingridient.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_recept";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_recept";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_ingridienta";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_ingridienta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ves";
            this.dataGridViewTextBoxColumn4.HeaderText = "ves";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // yP06receptingridientBindingSource1
            // 
            this.yP06receptingridientBindingSource1.DataMember = "YP_06_recept_ingridient";
            this.yP06receptingridientBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yP_06_recept_ingridientTableAdapter1
            // 
            this.yP_06_recept_ingridientTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBludaDataGridViewTextBoxColumn,
            this.idreceptaDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.yP06BludaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 154);
            this.dataGridView2.TabIndex = 24;
            // 
            // idBludaDataGridViewTextBoxColumn
            // 
            this.idBludaDataGridViewTextBoxColumn.DataPropertyName = "id_Bluda";
            this.idBludaDataGridViewTextBoxColumn.HeaderText = "id_Bluda";
            this.idBludaDataGridViewTextBoxColumn.Name = "idBludaDataGridViewTextBoxColumn";
            this.idBludaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idreceptaDataGridViewTextBoxColumn
            // 
            this.idreceptaDataGridViewTextBoxColumn.DataPropertyName = "id_recepta";
            this.idreceptaDataGridViewTextBoxColumn.HeaderText = "id_recepta";
            this.idreceptaDataGridViewTextBoxColumn.Name = "idreceptaDataGridViewTextBoxColumn";
            this.idreceptaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ves";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ves";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // yP06BludaBindingSource
            // 
            this.yP06BludaBindingSource.DataMember = "YP_06_Bluda";
            this.yP06BludaBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yP_06_BludaTableAdapter
            // 
            this.yP_06_BludaTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(14, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Название блюда";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 20);
            this.textBox2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(15, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Закончить блюдо";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 303);
            this.panel1.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(15, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 29);
            this.button2.TabIndex = 31;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(194, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Блюда";
            // 
            // yP06receptingridientBindingSource
            // 
            this.yP06receptingridientBindingSource.DataMember = "YP_06_recept_ingridient";
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(358, 48);
            this.Controls.Add(this.zavershit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Newrecept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Recept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chef";
            this.Text = "Создание рецепта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chef_FormClosed);
            this.Load += new System.EventHandler(this.Chef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06receptingridientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06BludaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yP06receptingridientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Recept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource yP06receptingridientBindingSource;
        private DataSet1TableAdapters.YP_06_recept_ingridientTableAdapter yP_06_recept_ingridientTableAdapter;
        private System.Windows.Forms.Button Newrecept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button zavershit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptingridientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idingridientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource yP06receptingridientBindingSource1;
        private DataSet2TableAdapters.YP_06_recept_ingridientTableAdapter yP_06_recept_ingridientTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingridient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource yP06BludaBindingSource;
        private DataSet3TableAdapters.YP_06_BludaTableAdapter yP_06_BludaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBludaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}