using System;

namespace VisitorPatternLibrary
{
    public interface IVisitor
    {
        string Visitor(PlainText text);
        string Visitor(Hyperlink text);
		string Visitor(BoldText text);
	}
}
