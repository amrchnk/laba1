namespace Лабораторная_1
{
    partial class Отчет
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
            this.check = new System.Windows.Forms.GroupBox();
            this.ports = new System.Windows.Forms.CheckBox();
            this.antivirus = new System.Windows.Forms.CheckBox();
            this.dom_obj = new System.Windows.Forms.CheckBox();
            this.domain = new System.Windows.Forms.CheckBox();
            this.HD = new System.Windows.Forms.CheckBox();
            this.RAM = new System.Windows.Forms.CheckBox();
            this.OS = new System.Windows.Forms.CheckBox();
            this.IP = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio = new System.Windows.Forms.GroupBox();
            this.xml = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.RadioButton();
            this.csv = new System.Windows.Forms.RadioButton();
            this.rtf = new System.Windows.Forms.RadioButton();
            this.pdf = new System.Windows.Forms.RadioButton();
            this.doc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.check.SuspendLayout();
            this.radio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Beige;
            this.check.Controls.Add(this.ports);
            this.check.Controls.Add(this.antivirus);
            this.check.Controls.Add(this.dom_obj);
            this.check.Controls.Add(this.domain);
            this.check.Controls.Add(this.HD);
            this.check.Controls.Add(this.RAM);
            this.check.Controls.Add(this.OS);
            this.check.Controls.Add(this.IP);
            this.check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.Location = new System.Drawing.Point(3, 48);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(752, 174);
            this.check.TabIndex = 0;
            this.check.TabStop = false;
            this.check.Text = "Выберите пункты, выводимые в отчете:";
            // 
            // ports
            // 
            this.ports.AutoSize = true;
            this.ports.Location = new System.Drawing.Point(227, 139);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(146, 24);
            this.ports.TabIndex = 7;
            this.ports.Text = "Сетевые порты";
            this.ports.UseVisualStyleBackColor = true;
            // 
            // antivirus
            // 
            this.antivirus.AutoSize = true;
            this.antivirus.Location = new System.Drawing.Point(227, 107);
            this.antivirus.Name = "antivirus";
            this.antivirus.Size = new System.Drawing.Size(108, 24);
            this.antivirus.TabIndex = 6;
            this.antivirus.Text = "Антивирус";
            this.antivirus.UseVisualStyleBackColor = true;
            // 
            // dom_obj
            // 
            this.dom_obj.AutoSize = true;
            this.dom_obj.Location = new System.Drawing.Point(227, 72);
            this.dom_obj.Name = "dom_obj";
            this.dom_obj.Size = new System.Drawing.Size(159, 24);
            this.dom_obj.TabIndex = 5;
            this.dom_obj.Text = "Объекты домена";
            this.dom_obj.UseVisualStyleBackColor = true;
            // 
            // domain
            // 
            this.domain.AutoSize = true;
            this.domain.Location = new System.Drawing.Point(227, 40);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(78, 24);
            this.domain.TabIndex = 4;
            this.domain.Text = "Домен";
            this.domain.UseVisualStyleBackColor = true;
            // 
            // HD
            // 
            this.HD.AutoSize = true;
            this.HD.Location = new System.Drawing.Point(9, 141);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(133, 24);
            this.HD.TabIndex = 3;
            this.HD.Text = "Жесткий диск";
            this.HD.UseVisualStyleBackColor = true;
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Location = new System.Drawing.Point(9, 108);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(61, 24);
            this.RAM.TabIndex = 2;
            this.RAM.Text = "ОЗУ";
            this.RAM.UseVisualStyleBackColor = true;
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Location = new System.Drawing.Point(9, 75);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(206, 24);
            this.OS.TabIndex = 1;
            this.OS.Text = "Операционная система";
            this.OS.UseVisualStyleBackColor = true;
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(9, 40);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(192, 24);
            this.IP.TabIndex = 0;
            this.IP.Text = "IP-адрес компьютера";
            this.IP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Страница формирования отчета";
            // 
            // radio
            // 
            this.radio.Controls.Add(this.xml);
            this.radio.Controls.Add(this.txt);
            this.radio.Controls.Add(this.csv);
            this.radio.Controls.Add(this.rtf);
            this.radio.Controls.Add(this.pdf);
            this.radio.Controls.Add(this.doc);
            this.radio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio.Location = new System.Drawing.Point(3, 228);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(752, 174);
            this.radio.TabIndex = 1;
            this.radio.TabStop = false;
            this.radio.Text = "Выберите формат отчета:";
            // 
            // xml
            // 
            this.xml.AutoSize = true;
            this.xml.Location = new System.Drawing.Point(186, 119);
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(60, 24);
            this.xml.TabIndex = 5;
            this.xml.TabStop = true;
            this.xml.Text = "*.xml";
            this.xml.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(186, 79);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(54, 24);
            this.txt.TabIndex = 4;
            this.txt.TabStop = true;
            this.txt.Text = "*.txt";
            this.txt.UseVisualStyleBackColor = true;
            // 
            // csv
            // 
            this.csv.AutoSize = true;
            this.csv.Location = new System.Drawing.Point(186, 38);
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(60, 24);
            this.csv.TabIndex = 3;
            this.csv.TabStop = true;
            this.csv.Text = "*.csv";
            this.csv.UseVisualStyleBackColor = true;
            // 
            // rtf
            // 
            this.rtf.AutoSize = true;
            this.rtf.Location = new System.Drawing.Point(6, 119);
            this.rtf.Name = "rtf";
            this.rtf.Size = new System.Drawing.Size(52, 24);
            this.rtf.TabIndex = 2;
            this.rtf.TabStop = true;
            this.rtf.Text = "*.rtf";
            this.rtf.UseVisualStyleBackColor = true;
            // 
            // pdf
            // 
            this.pdf.AutoSize = true;
            this.pdf.Location = new System.Drawing.Point(6, 79);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(60, 24);
            this.pdf.TabIndex = 1;
            this.pdf.TabStop = true;
            this.pdf.Text = "*.pdf";
            this.pdf.UseVisualStyleBackColor = true;
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Location = new System.Drawing.Point(9, 38);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(63, 24);
            this.doc.TabIndex = 0;
            this.doc.TabStop = true;
            this.doc.Text = "*.doc";
            this.doc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.check, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Отчет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Отчет";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.check.ResumeLayout(false);
            this.check.PerformLayout();
            this.radio.ResumeLayout(false);
            this.radio.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox radio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.RadioButton xml;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton csv;
        private System.Windows.Forms.RadioButton rtf;
        private System.Windows.Forms.RadioButton pdf;
        private System.Windows.Forms.RadioButton doc;
        private System.Windows.Forms.CheckBox ports;
        private System.Windows.Forms.CheckBox antivirus;
        private System.Windows.Forms.CheckBox dom_obj;
        private System.Windows.Forms.CheckBox domain;
        private System.Windows.Forms.CheckBox HD;
        private System.Windows.Forms.CheckBox RAM;
        private System.Windows.Forms.CheckBox OS;
        private System.Windows.Forms.CheckBox IP;
        private System.Windows.Forms.Button button1;
    }
}