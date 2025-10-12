﻿namespace Bluehill.Analyzers;

public abstract class BHAnalyzer : DiagnosticAnalyzer {
    protected const string BaseUrl = "https://analyzers.bluehill.dev/rules/";

    public sealed override void Initialize(AnalysisContext context) {
        // Configure generated code analysis
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        // Enable concurrent execution
        context.EnableConcurrentExecution();

        // Register analysis actions
        RegisterActions(context);
    }

    protected abstract void RegisterActions(AnalysisContext context);
}
