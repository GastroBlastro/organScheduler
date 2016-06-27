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
        }

        public string church, prelude, offertory, postlude, selectionRange;

        public List<string> hymns, other;
        public List<service> services;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectionRange = calender.SelectionRange.ToString();
            addEditScreen aes = new addEditScreen();
            this.Controls.Add(aes);
            aes.Location = new Point(addEditPlacementLabel.Location.X, addEditPlacementLabel.Location.Y);
            aes.BringToFront();
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
                writer.WriteElementString("SelectionRange", services[i].selectionRange);

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
    }
}
