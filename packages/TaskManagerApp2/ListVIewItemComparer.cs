using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerApp2
{
    public class ListVIewItemComparer : IComparer
    {
        private int col;
        public ListVIewItemComparer()
        {
            col = 0;
        }
        public ListVIewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,((ListViewItem)y).SubItems[col].Text);
            return returnVal;
        }
    }
}
