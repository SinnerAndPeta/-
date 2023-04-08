namespace Комова
{
    partial class SpisokReceptov
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
            this.dataSet5 = new Комова.DataSet5();
            this.yP06ReceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yP_06_ReceptTableAdapter = new Комова.DataSet5TableAdapters.YP_06_ReceptTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idBludaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreceptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yP06BludaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new Комова.DataSet6();
            this.yP_06_BludaTableAdapter = new Комова.DataSet6TableAdapters.YP_06_BludaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delblu = new System.Windows.Forms.Button();
            this.izmblu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rasblu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.izmrec = new System.Windows.Forms.Button();
            this.delrec = new System.Windows.Forms.Button();
            this.rasrec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yP06receptingridientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new Комова.DataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.yP_06_recept_ingridientTableAdapter = new Комова.DataSet7TableAdapters.YP_06_recept_ingridientTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idreceptingridientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreceptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idingridientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingridient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06ReceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06BludaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06receptingridientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yP06ReceptBindingSource
            // 
            this.yP06ReceptBindingSource.DataMember = "YP_06_Recept";
            this.yP06ReceptBindingSource.DataSource = this.dataSet5;
            // 
            // yP_06_ReceptTableAdapter
            // 
            this.yP_06_ReceptTableAdapter.ClearBeforeFill = true;
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
            this.vesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.yP06BludaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            // vesDataGridViewTextBoxColumn
            // 
            this.vesDataGridViewTextBoxColumn.DataPropertyName = "Ves";
            this.vesDataGridViewTextBoxColumn.HeaderText = "Ves";
            this.vesDataGridViewTextBoxColumn.Name = "vesDataGridViewTextBoxColumn";
            // 
            // yP06BludaBindingSource
            // 
            this.yP06BludaBindingSource.DataMember = "YP_06_Bluda";
            this.yP06BludaBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yP_06_BludaTableAdapter
            // 
            this.yP_06_BludaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delblu);
            this.panel1.Controls.Add(this.izmblu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rasblu);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(505, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 215);
            this.panel1.TabIndex = 2;
            // 
            // delblu
            // 
            this.delblu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.delblu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delblu.Location = new System.Drawing.Point(243, 184);
            this.delblu.Name = "delblu";
            this.delblu.Size = new System.Drawing.Size(118, 23);
            this.delblu.TabIndex = 28;
            this.delblu.Text = "Удалить";
            this.delblu.UseVisualStyleBackColor = false;
            this.delblu.Click += new System.EventHandler(this.delblu_Click);
            // 
            // izmblu
            // 
            this.izmblu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.izmblu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmblu.Location = new System.Drawing.Point(119, 184);
            this.izmblu.Name = "izmblu";
            this.izmblu.Size = new System.Drawing.Size(118, 23);
            this.izmblu.TabIndex = 27;
            this.izmblu.Text = "Изменить";
            this.izmblu.UseVisualStyleBackColor = false;
            this.izmblu.Click += new System.EventHandler(this.izmblu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Блюда";
            // 
            // rasblu
            // 
            this.rasblu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rasblu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rasblu.Location = new System.Drawing.Point(367, 184);
            this.rasblu.Name = "rasblu";
            this.rasblu.Size = new System.Drawing.Size(118, 23);
            this.rasblu.TabIndex = 26;
            this.rasblu.Text = "Распечатать";
            this.rasblu.UseVisualStyleBackColor = false;
            this.rasblu.Click += new System.EventHandler(this.rasblu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.izmrec);
            this.panel2.Controls.Add(this.delrec);
            this.panel2.Controls.Add(this.rasrec);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 250);
            this.panel2.TabIndex = 3;
            // 
            // izmrec
            // 
            this.izmrec.BackColor = System.Drawing.Color.MediumAquamarine;
            this.izmrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmrec.Location = new System.Drawing.Point(49, 184);
            this.izmrec.Name = "izmrec";
            this.izmrec.Size = new System.Drawing.Size(118, 23);
            this.izmrec.TabIndex = 30;
            this.izmrec.Text = "Изменить";
            this.izmrec.UseVisualStyleBackColor = false;
            this.izmrec.Click += new System.EventHandler(this.izmrec_Click);
            // 
            // delrec
            // 
            this.delrec.BackColor = System.Drawing.Color.MediumAquamarine;
            this.delrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delrec.Location = new System.Drawing.Point(173, 184);
            this.delrec.Name = "delrec";
            this.delrec.Size = new System.Drawing.Size(118, 23);
            this.delrec.TabIndex = 29;
            this.delrec.Text = "Удалить";
            this.delrec.UseVisualStyleBackColor = false;
            this.delrec.Click += new System.EventHandler(this.delrec_Click);
            // 
            // rasrec
            // 
            this.rasrec.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rasrec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rasrec.Location = new System.Drawing.Point(297, 184);
            this.rasrec.Name = "rasrec";
            this.rasrec.Size = new System.Drawing.Size(118, 23);
            this.rasrec.TabIndex = 26;
            this.rasrec.Text = "Распечатать";
            this.rasrec.UseVisualStyleBackColor = false;
            this.rasrec.Click += new System.EventHandler(this.rasrec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreceptingridientDataGridViewTextBoxColumn,
            this.idreceptDataGridViewTextBoxColumn,
            this.idingridientaDataGridViewTextBoxColumn,
            this.ingridient,
            this.vesDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.yP06receptingridientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yP06receptingridientBindingSource
            // 
            this.yP06receptingridientBindingSource.DataMember = "YP_06_recept_ingridient";
            this.yP06receptingridientBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(191, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Рецепты";
            // 
            // yP_06_recept_ingridientTableAdapter
            // 
            this.yP_06_recept_ingridientTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Блюда";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Рецепт";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Выберите ингридиент";
            // 
            // idreceptingridientDataGridViewTextBoxColumn
            // 
            this.idreceptingridientDataGridViewTextBoxColumn.DataPropertyName = "id_recept_ingridient";
            this.idreceptingridientDataGridViewTextBoxColumn.HeaderText = "id_recept_ingridient";
            this.idreceptingridientDataGridViewTextBoxColumn.Name = "idreceptingridientDataGridViewTextBoxColumn";
            this.idreceptingridientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idreceptDataGridViewTextBoxColumn
            // 
            this.idreceptDataGridViewTextBoxColumn.DataPropertyName = "id_recept";
            this.idreceptDataGridViewTextBoxColumn.HeaderText = "id_recept";
            this.idreceptDataGridViewTextBoxColumn.Name = "idreceptDataGridViewTextBoxColumn";
            // 
            // idingridientaDataGridViewTextBoxColumn
            // 
            this.idingridientaDataGridViewTextBoxColumn.DataPropertyName = "id_ingridienta";
            this.idingridientaDataGridViewTextBoxColumn.HeaderText = "id_ingridienta";
            this.idingridientaDataGridViewTextBoxColumn.Name = "idingridientaDataGridViewTextBoxColumn";
            this.idingridientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ingridient
            // 
            this.ingridient.HeaderText = "ingridient";
            this.ingridient.Name = "ingridient";
            // 
            // vesDataGridViewTextBoxColumn1
            // 
            this.vesDataGridViewTextBoxColumn1.DataPropertyName = "ves";
            this.vesDataGridViewTextBoxColumn1.HeaderText = "ves";
            this.vesDataGridViewTextBoxColumn1.Name = "vesDataGridViewTextBoxColumn1";
            // 
            // SpisokReceptov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1109, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Name = "SpisokReceptov";
            this.Text = "Список рецептов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpisokReceptov_FormClosed);
            this.Load += new System.EventHandler(this.SpisokReceptov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06ReceptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06BludaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06receptingridientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource yP06ReceptBindingSource;
        private DataSet5TableAdapters.YP_06_ReceptTableAdapter yP_06_ReceptTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource yP06BludaBindingSource;
        private DataSet6TableAdapters.YP_06_BludaTableAdapter yP_06_BludaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBludaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource yP06receptingridientBindingSource;
        private DataSet7TableAdapters.YP_06_recept_ingridientTableAdapter yP_06_recept_ingridientTableAdapter;
        private System.Windows.Forms.Button rasblu;
        private System.Windows.Forms.Button rasrec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delblu;
        private System.Windows.Forms.Button izmblu;
        private System.Windows.Forms.Button izmrec;
        private System.Windows.Forms.Button delrec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptingridientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idingridientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingridient;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesDataGridViewTextBoxColumn1;
    }
}