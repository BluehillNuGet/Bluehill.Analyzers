namespace Bluehill.Analyzers.Pages;

internal static class Program {
    private static Task<int> Main(string[] args) => Bootstrapper.Factory.CreateWeb(args).AddSetting("OptimizeContentFileNames", false).RunAsync();
}
