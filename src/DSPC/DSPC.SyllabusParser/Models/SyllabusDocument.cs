namespace DSPC.SyllabusParser.Models
{
    internal class SyllabusDocument
    {
        public List<DocElement> Elements { get; set; } = [];
    }

    public class DocElement
    {
        public DocElementType ElementType { get; set; }

        public required string Text { get; set; }
    }

    public enum DocElementType 
    {
        Paragraph,
        Table
    }
}
