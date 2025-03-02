namespace DSPC.SyllabusParser.Models
{
    public class EducationalComponent
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string[] Prerequisites { get; set; } = [];
        public string[] Postrequisites { get; set; } = [];
    }
}
