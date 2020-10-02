namespace Лабораторная_1
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.antivirus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.domain = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dom_obj = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-адрес компьютера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(369, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Операционная система";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP.Location = new System.Drawing.Point(246, 18);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(50, 20);
            this.IP.TabIndex = 2;
            this.IP.Text = "label3";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OS.Location = new System.Drawing.Point(584, 18);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(50, 20);
            this.OS.TabIndex = 3;
            this.OS.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Значение ОЗУ";
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM.Location = new System.Drawing.Point(246, 42);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(50, 20);
            this.RAM.TabIndex = 5;
            this.RAM.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(582, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Свободные порты";
            // 
            // antivirus
            // 
            this.antivirus.AutoSize = true;
            this.antivirus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.antivirus.Location = new System.Drawing.Point(246, 66);
            this.antivirus.Name = "antivirus";
            this.antivirus.Size = new System.Drawing.Size(50, 20);
            this.antivirus.TabIndex = 9;
            this.antivirus.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Название антивируса";
            // 
            // HD
            // 
            this.HD.AutoSize = true;
            this.HD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HD.Location = new System.Drawing.Point(33, 170);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(0, 20);
            this.HD.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(27, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Жесткий диск";
            // 
            // domain
            // 
            this.domain.AutoSize = true;
            this.domain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domain.Location = new System.Drawing.Point(584, 42);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(58, 20);
            this.domain.TabIndex = 13;
            this.domain.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(369, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Имя домена приложения";
            // 
            // dom_obj
            // 
            this.dom_obj.AutoSize = true;
            this.dom_obj.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dom_obj.Location = new System.Drawing.Point(314, 170);
            this.dom_obj.Name = "dom_obj";
            this.dom_obj.Size = new System.Drawing.Size(0, 20);
            this.dom_obj.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(314, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Объекты домена";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сформировать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ports
            // 
            this.ports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ports.FormattingEnabled = true;
            this.ports.ItemHeight = 17;
            this.ports.Location = new System.Drawing.Point(588, 170);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(155, 89);
            this.ports.TabIndex = 17;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.ports);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dom_obj);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.antivirus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label antivirus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label HD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label domain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dom_obj;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ports;
    }
}

