using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto.Exercises._01___Enconding
{
    public class Encoding
    {
        public Encoding(string text)
        {
            Text = text;
        }

        private string Text { get; set; }
        public Encoding Enc { get; private set; }        
    }
}
