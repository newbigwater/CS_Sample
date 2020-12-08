using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reflection
{
    public interface ISymbol
    {
        string Code { get; set; }
        string Title { get; set; }

        void Initialize(Symbol parent);
    }

    public class Symbol : UserControl, ISymbol
    {
        public Symbol SymbolParent
        {
            get;
            set
            {

            }
        } = null;
        public List<Symbol> SymolChildSet { get; set; } = new List<Symbol>();

        private string _code = "";
        public string Code
        {
            get
            {
                if (null == SymbolParent)
                    return $"{SymbolParent._code}.{_code}";
                else
                    return $"{_code}";
            }
            set
            {
                if (_code != value)
                    _code = value;
            }
        }
        public string Title { get; set; }
        public virtual void Initialize(Symbol symbolParent)
        {
            throw new NotImplementedException();
        }

        public Symbol()
        {
        }
    }
}