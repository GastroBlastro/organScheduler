using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organ_Schedule
{
    public partial class addEditScreen : UserControl
    {
        public addEditScreen()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();

        private void addButton_Click(object sender, EventArgs e)
        {
            hymnAddList.Items.Add(hymnBox.Text);
            f.hymns.Add(hymnBox.Text);
            hymnBox.Clear();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            f.church = churchBox.Text;
            f.prelude = preludeBox.Text;
            f.offertory = offertoryBox.Text;
            f.postlude = postludeBox.Text;
            service service = new service(f.church, f.prelude, f.offertory, f.postlude, f.selectionRange, f.hymns, f.other);
            f.services.Add(service);

            f.Controls.Remove(this);
        }

        private void otherAddButton_Click(object sender, EventArgs e)
        {
            otherAddList.Items.Add(otherBox.Text);
            f.other.Add(otherBox.Text);
            otherBox.Clear();
        }

        private void hymnRemoveButton_Click(object sender, EventArgs e)
        {
            f.hymns.RemoveAt(f.hymns.IndexOf(hymnAddList.SelectedItem.ToString()));
            hymnAddList.Items.Remove(hymnAddList.SelectedItem);
        }

        private void otherRemoveButton_Click(object sender, EventArgs e)
        {
            f.other.RemoveAt(f.other.IndexOf(otherAddList.SelectedItem.ToString()));
            otherAddList.Items.Remove(otherAddList.SelectedItem);
        }
    }
}
