using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class TEST : Symbol
    {
        public TEST()
        {
            InitializeComponent();
        }

        public override void Initialize(Symbol symbolParent)
        {
            this.SymbolParent = symbolParent;
        }
    }
}
