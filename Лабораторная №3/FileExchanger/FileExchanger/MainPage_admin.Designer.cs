namespace FileExchanger
{
    partial class MainPage_admin
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
            this.exit = new System.Windows.Forms.Label();
            this.psswrd = new System.Windows.Forms.TextBox();
            this.lgn = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.unlock = new System.Windows.Forms.Button();
            this.toLock = new System.Windows.Forms.Button();
            this.active_admins = new System.Windows.Forms.ListView();
            this.Locked = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.RadioButton();
            this.csv = new System.Windows.Forms.RadioButton();
            this.doc = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.report = new System.Windows.Forms.GroupBox();
            this.doings = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.report.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(645, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(143, 21);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выйти из аккаунта";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // psswrd
            // 
            this.psswrd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.psswrd.Location = new System.Drawing.Point(142, 82);
            this.psswrd.Name = "psswrd";
            this.psswrd.Size = new System.Drawing.Size(162, 25);
            this.psswrd.TabIndex = 11;
            this.psswrd.UseSystemPasswordChar = true;
            // 
            // lgn
            // 
            this.lgn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lgn.Location = new System.Drawing.Point(142, 44);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(162, 25);
            this.lgn.TabIndex = 10;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(67, 86);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(54, 17);
            this.password.TabIndex = 9;
            this.password.Text = "Пароль";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(77, 48);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(44, 17);
            this.login.TabIndex = 8;
            this.login.Text = "Логин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.lgn);
            this.groupBox1.Controls.Add(this.psswrd);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(432, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 187);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового администратора в систему";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(70, 126);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(234, 30);
            this.Add.TabIndex = 12;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // unlock
            // 
            this.unlock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unlock.Location = new System.Drawing.Point(12, 428);
            this.unlock.Name = "unlock";
            this.unlock.Size = new System.Drawing.Size(191, 30);
            this.unlock.TabIndex = 13;
            this.unlock.Text = "Разблокировать";
            this.unlock.UseVisualStyleBackColor = true;
            this.unlock.Click += new System.EventHandler(this.unlock_Click);
            // 
            // toLock
            // 
            this.toLock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLock.Location = new System.Drawing.Point(224, 428);
            this.toLock.Name = "toLock";
            this.toLock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toLock.Size = new System.Drawing.Size(191, 30);
            this.toLock.TabIndex = 14;
            this.toLock.Text = "Заблокировать";
            this.toLock.UseVisualStyleBackColor = true;
            this.toLock.Click += new System.EventHandler(this.toLock_Click);
            // 
            // active_admins
            // 
            this.active_admins.CheckBoxes = true;
            this.active_admins.HideSelection = false;
            this.active_admins.Location = new System.Drawing.Point(224, 298);
            this.active_admins.Name = "active_admins";
            this.active_admins.Size = new System.Drawing.Size(191, 124);
            this.active_admins.TabIndex = 15;
            this.active_admins.UseCompatibleStateImageBehavior = false;
            this.active_admins.View = System.Windows.Forms.View.List;
            // 
            // Locked
            // 
            this.Locked.CheckBoxes = true;
            this.Locked.HideSelection = false;
            this.Locked.Location = new System.Drawing.Point(12, 298);
            this.Locked.Name = "Locked";
            this.Locked.Size = new System.Drawing.Size(191, 124);
            this.Locked.TabIndex = 16;
            this.Locked.UseCompatibleStateImageBehavior = false;
            this.Locked.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Заблокированные \r\nадмиистраторы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(265, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Активные\r\nадминистраторы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вывести отчет в формате";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt.Location = new System.Drawing.Point(333, 21);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(48, 21);
            this.txt.TabIndex = 23;
            this.txt.TabStop = true;
            this.txt.Text = "*.txt";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.CheckedChanged += new System.EventHandler(this.txt_CheckedChanged);
            // 
            // csv
            // 
            this.csv.AutoSize = true;
            this.csv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csv.Location = new System.Drawing.Point(275, 21);
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(52, 21);
            this.csv.TabIndex = 22;
            this.csv.TabStop = true;
            this.csv.Text = "*.csv";
            this.csv.UseVisualStyleBackColor = true;
            this.csv.CheckedChanged += new System.EventHandler(this.csv_CheckedChanged);
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doc.Location = new System.Drawing.Point(213, 21);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(56, 21);
            this.doc.TabIndex = 21;
            this.doc.TabStop = true;
            this.doc.Text = "*.doc";
            this.doc.UseVisualStyleBackColor = true;
            this.doc.CheckedChanged += new System.EventHandler(this.doc_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(420, 17);
            this.Save.Name = "Save";
            this.Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Save.Size = new System.Drawing.Size(136, 30);
            this.Save.TabIndex = 24;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.LightSteelBlue;
            this.report.Controls.Add(this.Save);
            this.report.Controls.Add(this.label4);
            this.report.Controls.Add(this.txt);
            this.report.Controls.Add(this.csv);
            this.report.Controls.Add(this.doc);
            this.report.Location = new System.Drawing.Point(12, 464);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(776, 59);
            this.report.TabIndex = 25;
            this.report.TabStop = false;
            this.report.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // doings
            // 
            this.doings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doings.FormattingEnabled = true;
            this.doings.ItemHeight = 17;
            this.doings.Location = new System.Drawing.Point(12, 46);
            this.doings.Name = "doings";
            this.doings.Size = new System.Drawing.Size(776, 174);
            this.doings.TabIndex = 1;
            // 
            // MainPage_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Locked);
            this.Controls.Add(this.active_admins);
            this.Controls.Add(this.toLock);
            this.Controls.Add(this.unlock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doings);
            this.Controls.Add(this.exit);
            this.Name = "MainPage_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.report.ResumeLayout(false);
            this.report.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox psswrd;
        private System.Windows.Forms.TextBox lgn;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button unlock;
        private System.Windows.Forms.ListView active_admins;
        private System.Windows.Forms.ListView Locked;
        private System.Windows.Forms.Button toLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton csv;
        private System.Windows.Forms.RadioButton doc;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.GroupBox report;
        private System.Windows.Forms.ListBox doings;
    }
}