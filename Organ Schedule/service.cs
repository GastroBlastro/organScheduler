using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organ_Schedule
{
    public class service
    {
        public string church, prelude, offertory, postlude;
        public SelectionRange selectionRange;
        public List<string> hymns, other;

        public service(string _church, string _prelude, string _offertory, string _postlude, SelectionRange _selectionRange, List<string> _hymns, List<string> _other)
        {
            church = _church;
            prelude = _prelude;
            offertory = _offertory;
            postlude = _postlude;
            selectionRange = _selectionRange;
            hymns = _hymns;
            other = _other;
        }
    }
}
