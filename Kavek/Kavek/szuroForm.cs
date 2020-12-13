using Kavek.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
