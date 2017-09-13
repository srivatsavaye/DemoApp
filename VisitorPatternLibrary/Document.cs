using System;
using System.Collections.Generic;

namespace VisitorPatternLibrary
{
    public class Document
    {
        private List<DocumentPart> _parts;

        public Document(List<DocumentPart> parts)
        {
            _parts = parts;
            Html = ToHtml();
        }

        public string Html { get; set; }

        public string ToHtml()
        {
            var ret = "";
            foreach (var v in _parts)
            {
                ret = ret + v.ToHtml();
            }
            return ret;
        }

        public string ToPlainText()
        {
            var ret = "";
            foreach(var v in _parts)
            {
                ret = ret + v.ToPlainText();
            }
            return ret;
        }

        public string ToLatex()
        {
            var ret = "";
            foreach(var v in _parts)
            {
                ret = ret + v.ToLatex();
            }
            return ret;
        }
    }
}
