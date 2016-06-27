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

namespace Organ_Schedule
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            loadCalender();
        }

        public string church, prelude, offertory, postlude;
        public SelectionRange selectionRange;

        public List<string> hymns = new List<string>();
        public List<string> other = new List<string>();
        public List<service> services = new List<service>();

        private void calender_DateSelected(object sender, DateRangeEventArgs e)
        {
            foreach (service service in services)
            {
                if (calender.SelectionRange == service.selectionRange)
                {
                    churchLabel.Text = church = service.church; preLabel.Text = prelude = service.prelude;
                    offLabel.Text = offertory = service.offertory; postLabel.Text = postlude = service.postlude;

                    foreach (string hymn in hymns = service.hymns)
                    {
                        hymnList.Items.Add(hymn);
                    }

                    foreach (string thing in other = service.other)
                    {
                        otherList.Items.Add(thing);
                    }

                    break;
                }
                else if (services == null)
                {
                    addEditScreen aes = new addEditScreen();
                    Controls.Add(aes);
                    aes.Location = new Point(addEditPlacementLabel.Location.X, addEditPlacementLabel.Location.Y);
                    aes.BringToFront();
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Would you like to save the current Organ-izer?/nAll changes will be lost otherwise.", "Closing Program", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                writeCalender();
            }
            else if (result == DialogResult.No)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            churchLabel.Text = church; preLabel.Text = prelude; offLabel.Text = offertory;
            postLabel.Text = postlude;

            foreach (string hymn in hymns)
            {
                hymnList.Items.Add(hymn);
            }

            foreach (string thing in other)
            {
                otherList.Items.Add(thing);
            }

            Focus();
            BringToFront();
        }

        void writeCalender()
        {
            XmlTextWriter writer = new XmlTextWriter("C: /Users/Gibber/Documents/Visual Studio 2015/Projects/Organ Schedule/calender.xml", null);

            //Write the "class" element
            writer.WriteStartElement("calender");

            //Write sub-elements
            int i = 0;
            foreach (service service in services)
            {
                //Start "student" element
                writer.WriteStartElement("service");

                writer.WriteElementString("Church", services[i].church);
                writer.WriteElementString("Prelude", services[i].prelude);
                writer.WriteElementString("Offertory", services[i].offertory);
                writer.WriteElementString("Postlude", services[i].postlude);
                writer.WriteElementString("SelectionRange", services[i].selectionRange.ToString());

                int h = 0;
                int o = 0;

                foreach (string hymn in hymns)
                {
                    writer.WriteElementString("Hymn" + h, services[i].hymns[h]);
                    h++;
                }

                foreach (string thing in other)
                {
                    writer.WriteElementString("Other" + o, services[i].other[o]);
                    o++;
                }
                i++;
            }

            // end the "object" element
            writer.WriteEndElement();

            // end the "database" element
            writer.WriteEndElement();

            //close the writer
            writer.Close();
        }

        void loadCalender()
        {

        }
    }
}
