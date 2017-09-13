using System;
namespace DemoLibrary
{
    public abstract class DocumentPart
    {
        public DocumentPart(string text)
        {
            Text = text;
        }
        public string Text { get; private set; }
        public abstract string ToHtml();
        public abstract string ToPlainText();
        public abstract string ToLatex();
    }

    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public override string ToHtml()
        {
            return this.Text;
        }

        public override string ToLatex()
		{
			return this.Text;
        }

        public override string ToPlainText()
		{
			return this.Text;
        }
    }

    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

        public override string ToHtml()
        {
            return string.Format("<b>{0}</b>",this.Text);
        }

        public override string ToLatex()
        {
            return "\\textbf{" + this.Text + "}";
        }

        public override string ToPlainText()
        {
            return "**" + this.Text + "**";
        }
    }

    public class Hyperlink : DocumentPart
    {
        public Hyperlink(string text, string url) : base(text)
        {
            Url = url;
        }

        public string Url { get; private set; }
        public override string ToHtml()
        {
            return "<a href=\"" + this.Url + "\">" + this.Text + "</a>";
        }

        public override string ToLatex()
		{
			return "\\href{" + this.Url + "}{" + this.Text + "}";
        }

        public override string ToPlainText()
		{
			return this.Text + " [" + this.Url + "]";
        }
    }
}
