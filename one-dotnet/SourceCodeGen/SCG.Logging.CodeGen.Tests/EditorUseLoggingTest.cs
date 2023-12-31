using System.Diagnostics;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace TPFive.SCG.Logging.CodeGen.Tests;

using TPFive.SCG.Logging.Abstractions;
using TPFive.SCG.Logging.CodeGen.EditorUse;

public class EditorUseLoggingTest
{
    [SetUp]
    public void Setup()
    {
    }

    private static Compilation CreateCompilation(string source)
    {
        var references = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(_ => !_.IsDynamic && !string.IsNullOrWhiteSpace(_.Location))
            .Select(_ => MetadataReference.CreateFromFile(_.Location))
            .Concat(new[]
            {
                // add your app/lib specifics, e.g.:
                MetadataReference.CreateFromFile(typeof(EditorUseLoggingAttribute).GetTypeInfo().Assembly.Location)
            })
            .ToList();

        return CSharpCompilation.Create(
            "compilation",
            new[] { CSharpSyntaxTree.ParseText(source) },
            references,
            new CSharpCompilationOptions(OutputKind.ConsoleApplication));
    }

    [Test]
    public void DefaultUsage()
    {
        var code = @"
namespace TPFive.SCG.Logging.CodeGen.Tests
{
    using TPFive.SCG.Logging.Abstractions;

    [EditorUseLogging]
    public sealed partial class Service
    {
    }
}
";
        var inputCompilation = CreateCompilation(code);

        var generator = new SourceGenerator();
        var driver = CSharpGeneratorDriver.Create(generator);
        driver = (CSharpGeneratorDriver) driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
        var runResult = driver.GetRunResult();
        var generatedSource = runResult.Results[0].GeneratedSources[0].SourceText.ToString();

        var generatedCode = @"
// <auto-generated />

using Microsoft.Extensions.Logging;
using Splat;

using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace TPFive.SCG.Logging.CodeGen.Tests
{
    /// <summary>
    /// This part deals adding logger.
    /// </summary>
    public sealed partial class Service
    {
        /// <summary>
        /// Classwide logger instance.
        /// </summary>
        private static ILogger _logger;

        private static ILogger Logger
        {
            get
            {
                _logger ??= Locator.Current
                    .GetService<ILoggerFactory>()
                    .CreateLogger<Service>();

                return _logger;
            }
        }
    }
}
";

        Assert.IsTrue(generatedSource.Contains(generatedCode));
    }
}
