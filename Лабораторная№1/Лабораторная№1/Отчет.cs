using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лабораторная_1
{
    public partial class Отчет : Form
    {
        string text;
        Label[] lbls;
        List<string> prts;
        public Отчет(Label[] labels, List<string> ports)
        {
            InitializeComponent();
            this.lbls = labels;
            this.prts = ports;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
            text = "";

            foreach (Control control in check.Controls)
            {
                
                if (control is CheckBox)
                {
                    CheckBox chb = control as CheckBox;

                    if (chb.Checked)
                    {
                        for(int i=0;i<lbls.Length;i++)
                        {
                            if(chb.Name==lbls[i].Name)text = text+chb.Text+":"+ "\r\n"+lbls[i].Text + "\r\n";
                            else
                            {
                                if (chb.Name == "ports")
                                {
                                    text = text + chb.Text + ":" + "\r\n";
                                    for (i = 0; i < prts.Count; i++)
                                    {
                                        text+=prts[i] + "\r\n";
                                    }
                                }
                                
                            }
                        }
                        
                    }
                        
                }
            }
            {

            }

            foreach (Control control in radio.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rb = control as RadioButton;

                    if (rb.Checked)
                    {
                        switch (rb.Text)
                        {
                            case "*.doc":
                                SFD.Filter = "документы Word|*.doc";
                                break;
                            case "*.csv":
                                SFD.Filter = "CSV UTF-8 (разделитель - запятая)|*.csv";
                                break;
                            case "*.txt":
                                SFD.Filter = "Текстовые файлы | *.txt";
                                break;
                            case "*.pdf":
                                SFD.Filter = "PDF|*.pdf";
                                break;
                            case "*.rtf":
                                SFD.Filter = "Rich text format|*.rtf";
                                break;
                            case "*.xml":
                                SFD.Filter = "Язык разметки XML|*.xml";
                                break;

                        }
                    }
                    
                    
                }
            }
           

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                
                string filename = SFD.FileName;
                System.IO.File.WriteAllText(filename,text, Encoding.UTF8);
                
            }
            
            
        }

       

        
    }
}
