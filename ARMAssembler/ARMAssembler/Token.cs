using System;
using System.Collections.Generic;
using System.Text;

namespace ARMAssembler
{
    public class Token
    {
        public string Value { get; set; }
        public Token(string value)
        {
            this.Value = value;
        }
    }
}
