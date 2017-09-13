using System;
namespace VisitorPatternLibrary
{
    public abstract class DocumentPart
    {
        public DocumentPart(string text)
        {
            Text = text;
        }
        public string Text { get; private set; }
        public abstract string Accept(IVisitor visitor);
    }

    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.Visitor(this);
        }
    }

    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

		public override string Accept(IVisitor visitor)
		{
			return visitor.Visitor(this);
		}
    }

    public class Hyperlink : DocumentPart
    {
        public Hyperlink(string text, string url) : base(text)
        {
            Url = url;
        }

		public string Url { get; private set; }
		public override string Accept(IVisitor visitor)
		{
			return visitor.Visitor(this);
		}
    }
}
