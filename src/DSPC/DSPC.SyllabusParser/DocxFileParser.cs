﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.RegularExpressions;

namespace DSPC.SyllabusParser
{
    public class DocxFileParser
    {


        public DocxFileParser() 
        {

        }

        public string Parse(string filepath)
        {
            using var docx = WordprocessingDocument.Open(filepath, false);

            var body = docx.MainDocumentPart?.Document.Body ?? throw new Exception($"Cannot read document {filepath}");

            Thread.Sleep( 5000 );

            return body.ToString();
        }

        //private List<string> GetSections(Body body)
        //{
        //    var content = body.OfType<Paragraph>()
        //                    .Select(s => s.InnerText)
        //                    .Where(s => !string.IsNullOrWhiteSpace(s));

        //    //var sections = new List<DocxFileSection>();
        //    //DocxFileSection? currentSection = null;

        //    foreach (var item in content)
        //    {
        //        var newSection = FindSectionName(item);
        //        if (newSection != null)
        //        {
        //            currentSection = new DocxFileSection
        //            {
        //                Name = item,
        //                Content = []
        //            };

        //            sections.Add(currentSection);
        //        }
        //        else
        //        {
        //            currentSection?.Content.Add(item);
        //        }
        //    }

        //    return sections;
        //}

        //private string? FindSectionName(string item)
        //{
        //    return _knownSectionNames.FirstOrDefault(s => Regex.Match(item, s, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant).Success);
        //}

        //private static List<string> GetSubjectDescription(Body body)
        //{
        //    var table = body.OfType<Table>().FirstOrDefault();
        //    var subjectDescription = table?.OfType<TableRow>().FirstOrDefault() ?? throw new Exception("Cannot find subject description");

        //    var descriptionLines = subjectDescription
        //        .OfType<TableCell>()
        //        .SelectMany(s => s.OfType<Paragraph>())
        //        .Select(s => s.InnerText)
        //        .Where(s => !string.IsNullOrWhiteSpace(s))
        //        .ToList();

        //    return descriptionLines;
        //}
    }
}
