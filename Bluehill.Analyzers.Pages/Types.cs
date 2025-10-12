namespace Bluehill.Analyzers.Pages;

public static class Types {
    public static IEnumerable<(string Name, string Path)> Items {
        get {
            yield return ("Rules", "/rule");
            yield return ("Refactorings", "/refactoring");
            yield return ("Source Generators", "/generator");
        }
    }
}
