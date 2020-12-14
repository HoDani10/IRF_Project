using Kavek.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kavek
{
    public partial class szuroForm : Form
    {
        BindingList<kaveClass> Kavelista = new BindingList<kaveClass>();
        public szuroForm()
        {
            InitializeComponent();
            Beolvasas();
            kavekdataGridView.DataSource = Kavelista;
        }

        private void Beolvasas()
        {
            var xml = new XmlDocument();
            xml.Load("kavekexp.xml");
            foreach (XmlElement element in xml.DocumentElement)
            {
                var kv = new kaveClass();

                var firstchildElement = (XmlElement)element.ChildNodes[0];
                kv.ID = int.Parse(firstchildElement.InnerText);
                var secondchildElement = (XmlElement)element.ChildNodes[1];
                kv.Megnevezés = secondchildElement.InnerText;
                var thirdchildElement = (XmlElement)element.ChildNodes[2];
                kv.DB = int.Parse(thirdchildElement.InnerText);
                var fourthchildElement = (XmlElement)element.ChildNodes[3];
                kv.Ár = int.Parse(fourthchildElement.InnerText);
                var fifthchildElement = (XmlElement)element.ChildNodes[4];
                kv.Adó_ID = int.Parse(fifthchildElement.InnerText);
                var sixthchildElement = (XmlElement)element.ChildNodes[5];
                kv.Br_bevétel = int.Parse(sixthchildElement.InnerText);
                var seventhchildElement = (XmlElement)element.ChildNodes[6];
                kv.Össszköltség = double.Parse(seventhchildElement.InnerText);

                Kavelista.Add(kv);

            }
        }

        private void visszaallitButton_Click(object sender, EventArgs e)
        {
            kavekdataGridView.Rows.Clear();
            kavekdataGridView.Refresh();
            Beolvasas();
            kavekdataGridView.DataSource = Kavelista;
        }

        private void dragakButton_Click(object sender, EventArgs e)
        {
            BindingList<kaveClass> dragaktorles = new BindingList<kaveClass>();
            foreach (kaveClass kv in Kavelista)
            {
                if (kv.Ár>=700)
                {
                    dragaktorles.Add(kv);
                }

            }
            foreach (kaveClass kv in dragaktorles)
            {
                Kavelista.Remove(kv);
            }
            kavekdataGridView.DataSource = Kavelista;
        }

        private void decafButton_Click(object sender, EventArgs e)
        {
            BindingList<kaveClass> kvtorles = new BindingList<kaveClass>();
            foreach (kaveClass kv in Kavelista)
            {
                if (!kv.Megnevezés.Contains("DECAF"))
                {
                    kvtorles.Add(kv);
                }
            }
            foreach (kaveClass kv in kvtorles)
            {
                Kavelista.Remove(kv);
            }
            kavekdataGridView.DataSource = Kavelista;
        }

        private void olcsokButton_Click(object sender, EventArgs e)
        {
            BindingList<kaveClass> olcsoktorles = new BindingList<kaveClass>();
            foreach (kaveClass kv in Kavelista)
            {
                if (kv.Ár < 700)
                {
                    olcsoktorles.Add(kv);
                }

            }
            foreach (kaveClass kv in olcsoktorles)
            {
                Kavelista.Remove(kv);
            }
            kavekdataGridView.DataSource = Kavelista;
        }

        private void fogyhelybtn_Click(object sender, EventArgs e)
        {
            BindingList<kaveClass> elviteltorles = new BindingList<kaveClass>();
            foreach (kaveClass kv in Kavelista)
            {
                
                adoTipus el = adoTipus.elvitel;

                if (kv.Adó_ID==(int)el)
                {
                    elviteltorles.Add(kv);
                }
            }
            foreach (kaveClass kv in elviteltorles)
            {
                Kavelista.Remove(kv);
            }
            kavekdataGridView.DataSource = Kavelista;
        }

        private void kiirbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);

                sw.Write("Azonosító");
                sw.Write(';');
                sw.Write("Kávé neve");
                sw.Write(';');
                sw.Write("Eladott darabszám");
                sw.Write(';');
                sw.Write("Eladási ár");
                sw.Write(';');
                sw.Write("1-helyben, 2-elvitelre");
                sw.Write(';');
                sw.Write("Bruttó bevétel");
                sw.Write(';');
                sw.Write("Összköltség");
                sw.WriteLine();
                foreach (var kave in Kavelista)
                {
                    sw.Write(kave.ID);
                    sw.Write(';');
                    sw.Write(kave.Megnevezés);
                    sw.Write(';');
                    sw.Write(kave.DB);
                    sw.Write(';');
                    sw.Write(kave.Ár);
                    sw.Write(';');
                    sw.Write(kave.Adó_ID);
                    sw.Write(';');
                    sw.Write(kave.Br_bevétel);
                    sw.Write(';');
                    sw.Write(kave.Össszköltség);
                    sw.WriteLine();

                }
                sw.Close();

            }
            
        }

        private void fooldalButton_Click(object sender, EventArgs e)
        {
            alapForm af = new alapForm();
            af.Show();
            Hide();
        }
    }
}
