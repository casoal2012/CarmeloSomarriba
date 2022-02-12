using System;

namespace WEB_Core_Conv2.Models
{
    internal class ForeignkeyAttribute : Attribute
    {
        private string v;

        public ForeignkeyAttribute(string v)
        {
            this.v = v;
        }
    }
}