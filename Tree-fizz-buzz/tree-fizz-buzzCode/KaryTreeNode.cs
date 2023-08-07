using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_fizz_buzzCode
{
    public class KaryTreeNode
    {
        public string Value { get; set; }
        public List<KaryTreeNode> Children { get; set; }

        public KaryTreeNode(string value)
        {
            Value = value;
            Children = new List<KaryTreeNode>();
        }
    }
}
