namespace Dark.Console;

public static class Environment
{
    public static ImmutableDictionary<string, string> Config
    {
        get
        {
            Dictionary<string, string> config = [];
            foreach (var argument in GetCommandLineArgs())
            {
                var splittedArg = argument.Split('=', 2, StringSplitOptions.RemoveEmptyEntries);
                config.Add(splittedArg[0], splittedArg.Length == 2 ? splittedArg[1] : "");
            }
            return config.ToImmutableDictionary();
        }
    }
}
