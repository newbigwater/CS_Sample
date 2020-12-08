using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeSymbole();
        }

        private void InitializeSymbole()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Symbol)
                {
                    var parentSymbolName = "";

                    string[] splitDeviceCode = control.Name.Split('_');
                    for (int i = 0; i < splitDeviceCode.Length - 1; i++)
                    {
                        if (parentSymbolName.Length != 0)
                            parentSymbolName += $"_{splitDeviceCode[i]}";
                        else
                            parentSymbolName += $"{splitDeviceCode[i]}";
                    }

                    Symbol symbol = control as Symbol;
                    symbol.SymbolParent = GetParentSymbol(control, parentSymbolName);
                }
            }
            
            foreach (Control control in this.Controls)
            {
                if (control is Symbol)
                {
                    Symbol symbol = control as Symbol;
                }
            }
        }

        private Symbol GetParentSymbol(Control childControl, String parentSymbolName)
        {
            foreach (Control control in this.Controls)
            {
                if (control == childControl)
                    continue;

                if (control is Symbol)
                {
                    if (parentSymbolName == control.Name)
                    {
                        return control as Symbol;
                    }
                }
                else if (control.HasChildren)
                    return GetParentSymbol(control, parentSymbolName);
            }

            return null;
        }


    }
}
