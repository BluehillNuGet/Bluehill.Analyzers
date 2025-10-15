namespace Bluehill.Analyzers.Pages;

public static class Types {
    public static IEnumerable<(string Path, string Name, string ShortName)> Items {
        get {
            yield return ("/rule", "Rules", "Rules");
            yield return ("/refactoring", "Refactorings", "Refactorings");
            yield return ("/generator", "Source Generators", "Generators");
        }
    }
}
