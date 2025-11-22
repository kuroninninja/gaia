using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

// Python script runner for use when using ANSI codes
// (because C# doesn't support them for some reason)
namespace gaia.pyrunner
{
    public class PyRunner
    {
        public static void RunPythonScript(string scriptPath)
        {
            // Make engine and run python script
            ScriptEngine engine = Python.CreateEngine();
            engine.ExecuteFile(scriptPath);
        }
    }
}
