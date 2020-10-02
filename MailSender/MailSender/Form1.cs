using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace MailSender
{
    public partial class Form1 : Form
    {
        string file = "";
        public Form1()
        {
            InitializeComponent();
        }
        

      

        private void button2_Click(object sender, EventArgs e)
        {
            string fromUser = this.text.Text;    // Получим комментарий пользователя
            string email = MyMail.Text;          // Получим Email пользователя
            string password = "yourPassword";

           
            try
            {
                MailAddress from = new MailAddress(email);
                MailAddress to = new MailAddress(this.to.Text);
                MailMessage msg = new MailMessage(from, to)
                {
                    Subject = Theme.Text,
                    IsBodyHtml = false,
                    Body = fromUser,

                };
                if (file != "") msg.Attachments.Add(new Attachment($"{file}")); ;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25)
                {
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true
                };
                smtp.Send(msg);
                MessageBox.Show("Сообщение успешно отправлено");
                Close();
            }

            catch (FormatException)
            {
                MessageBox.Show("Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие");
                this.to.Clear();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Строка с адресом не должна быть пуста");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HelpLink);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                file = OFD.FileName;
              this.fileName.Text  = OFD.FileName;
            }
        }
    }
}
