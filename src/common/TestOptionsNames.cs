internal static class TestOptionsNames
{
    internal static class Configuration
    {
        public static readonly string DiagnosticMessages = "xunit.diagnosticMessages";
        public static readonly string MaxParallelThreads = "xunit.maxParallelThreads";
        public static readonly string MethodDisplay = "xunit.methodDisplay";
        public static readonly string ParallelizeAssembly = "xunit.parallelizeAssembly";
        public static readonly string ParallelizeTestCollections = "xunit.parallelizeTestCollections";
    }

    internal static class Discovery
    {
        public static readonly string DiagnosticMessages = "xunit.discovery.DiagnosticMessages";
        public static readonly string MethodDisplay = "xunit.discovery.MethodDisplay";
    }

    internal static class Execution
    {
        public static readonly string DiagnosticMessages = "xunit.execution.DiagnosticMessages";
        public static readonly string DisableParallelization = "xunit.execution.DisableParallelization";
        public static readonly string MaxParallelThreads = "xunit.execution.MaxParallelThreads";
        public static readonly string SynchronousMessageReporting = "xunit.execution.SynchronousMessageReporting";
    }
}