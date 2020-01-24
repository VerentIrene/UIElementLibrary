using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UIElementLibrary.BaseComponent
{
    class MyRegex : Regex
    {
        public MyRegex(string pattern) : base(pattern){ }
        public MyRegex(string pattern, RegexOptions options) : base(pattern,options){ }
        public MyRegex(string pattern, RegexOptions options, TimeSpan matchTimeout) : base(pattern, options, matchTimeout) { }
        protected MyRegex() { }
        protected MyRegex(SerializationInfo info, StreamingContext context) : base(info,context){ }

    }
}
