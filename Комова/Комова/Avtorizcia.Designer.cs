namespace Комова
{
    partial class Avtorizcia
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
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Vhod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Location = new System.Drawing.Point(176, 104);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(145, 20);
            this.password.TabIndex = 11;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login.Location = new System.Drawing.Point(176, 64);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(145, 20);
            this.login.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(103, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(103, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логин";
            // 
            // Vhod
            // 
            this.Vhod.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Vhod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Vhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Vhod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Vhod.Location = new System.Drawing.Point(107, 142);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(214, 29);
            this.Vhod.TabIndex = 7;
            this.Vhod.Text = "Вход";
            this.Vhod.UseVisualStyleBackColor = false;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Меню ресторана";
            // 
            // Avtorizcia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(404, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vhod);
            this.Name = "Avtorizcia";
            this.Text = "Авториазция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Avtorizcia_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Vhod;
        private System.Windows.Forms.Label label1;
    }
}

