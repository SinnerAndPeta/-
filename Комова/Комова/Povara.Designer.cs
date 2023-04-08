namespace Комова
{
    partial class Povara
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idrabotnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoljnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yP06RabotnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new Комова.DataSet4();
            this.yP_06_RabotnikTableAdapter = new Комова.DataSet4TableAdapters.YP_06_RabotnikTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Ud = new System.Windows.Forms.Button();
            this.Izmenit = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06RabotnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrabotnikaDataGridViewTextBoxColumn,
            this.iddoljnostiDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yP06RabotnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idrabotnikaDataGridViewTextBoxColumn
            // 
            this.idrabotnikaDataGridViewTextBoxColumn.DataPropertyName = "id_rabotnika";
            this.idrabotnikaDataGridViewTextBoxColumn.HeaderText = "id_rabotnika";
            this.idrabotnikaDataGridViewTextBoxColumn.Name = "idrabotnikaDataGridViewTextBoxColumn";
            this.idrabotnikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddoljnostiDataGridViewTextBoxColumn
            // 
            this.iddoljnostiDataGridViewTextBoxColumn.DataPropertyName = "id_doljnosti";
            this.iddoljnostiDataGridViewTextBoxColumn.HeaderText = "id_doljnosti";
            this.iddoljnostiDataGridViewTextBoxColumn.Name = "iddoljnostiDataGridViewTextBoxColumn";
            this.iddoljnostiDataGridViewTextBoxColumn.Visible = false;
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            // 
            // imaDataGridViewTextBoxColumn
            // 
            this.imaDataGridViewTextBoxColumn.DataPropertyName = "Ima";
            this.imaDataGridViewTextBoxColumn.HeaderText = "Ima";
            this.imaDataGridViewTextBoxColumn.Name = "imaDataGridViewTextBoxColumn";
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // yP06RabotnikBindingSource
            // 
            this.yP06RabotnikBindingSource.DataMember = "YP_06_Rabotnik";
            this.yP06RabotnikBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yP_06_RabotnikTableAdapter
            // 
            this.yP_06_RabotnikTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Повара";
            // 
            // Ud
            // 
            this.Ud.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Ud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ud.Location = new System.Drawing.Point(420, 194);
            this.Ud.Name = "Ud";
            this.Ud.Size = new System.Drawing.Size(118, 23);
            this.Ud.TabIndex = 27;
            this.Ud.Text = "Удалить";
            this.Ud.UseVisualStyleBackColor = false;
            this.Ud.Click += new System.EventHandler(this.Ud_Click);
            // 
            // Izmenit
            // 
            this.Izmenit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Izmenit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izmenit.Location = new System.Drawing.Point(296, 194);
            this.Izmenit.Name = "Izmenit";
            this.Izmenit.Size = new System.Drawing.Size(118, 23);
            this.Izmenit.TabIndex = 26;
            this.Izmenit.Text = "Изменить";
            this.Izmenit.UseVisualStyleBackColor = false;
            this.Izmenit.Click += new System.EventHandler(this.Izmenit_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.MediumAquamarine;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Location = new System.Drawing.Point(172, 194);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(118, 23);
            this.c.TabIndex = 25;
            this.c.Text = "Добавить";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // Povara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(669, 226);
            this.Controls.Add(this.Ud);
            this.Controls.Add(this.Izmenit);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Povara";
            this.Text = "Повара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Povara_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Chefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yP06RabotnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource yP06RabotnikBindingSource;
        private DataSet4TableAdapters.YP_06_RabotnikTableAdapter yP_06_RabotnikTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ud;
        private System.Windows.Forms.Button Izmenit;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrabotnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoljnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}