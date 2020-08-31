using CommandLine;

namespace Exercism.Representers.CSharp
{
    internal class Options
    {
        [Value(0, Required = true, HelpText = "The solution's exercise")]
        public string Slug { get; }

        [Value(1, Required = true, HelpText = "The directory containing the solution")]
        public string InputDirectory { get; }

        [Value(2, Required = true, HelpText = "The directory to which the results will be written")]
        public string OutputDirectory { get; }

        [Option('s', "SuppressLogConfiguration", Required = false, HelpText = "A flag (used for unit testing) to prevent configuration of the logger")]
        public bool SuppressLogConfiguration { get; }

        public Options(string slug, string inputDirectory,
            string outputDirectory, bool suppressLogConfiguration = false) =>
            (Slug, InputDirectory, OutputDirectory, SuppressLogConfiguration) 
            = (slug, inputDirectory, outputDirectory, suppressLogConfiguration);
    }
}