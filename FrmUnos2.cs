using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinqXMLDokumenti
{
    public partial class FrmUnos2 : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        string dokument = "osobe.xml";
        public FrmUnos2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Osoba os = new Osoba(txtIme.Text, txtPrezime.Text, Convert.ToInt32(txtGodRod.Text));

            DialogResult upit = MessageBox.Show("Zelite li upisati jos osoba?", "Upit", MessageBoxButtons.YesNo);
            if (upit == DialogResult.Yes)
            {

                osobe.Add(os);
                txtGodRod.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
            }
            else
            {
                if (File.Exists(dokument))
                {
                    var OsobeXML = XDocument.Load(dokument);
                 

                    
                    foreach (Osoba osoba in osobe)
                    {
                        var Osoba = new XElement("Osoba",
                            new XElement("Ime", os.Ime),
                              new XElement("Prezime", os.Prezime),
                              new XElement("Godina_rodenja", os.GodRod));
                        OsobeXML.Root.Add(Osoba);

                    }
                    OsobeXML.Save(dokument);

                }

                else
                {
                    var OsobeXML = new XDocument();



                    foreach (Osoba osoba in osobe)
                    {
                        var Osoba = new XElement("Osoba",
                            new XElement("Ime", os.Ime),
                              new XElement("Prezime", os.Prezime),
                              new XElement("Godina_rodenja", os.GodRod));
                        OsobeXML.Root.Add(Osoba);

                    }
                    OsobeXML.Save(dokument);
                }
                this.Close();
               
               
              
                 
            }
        }
    }
}

