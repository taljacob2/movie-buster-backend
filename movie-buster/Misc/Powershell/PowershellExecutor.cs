using System.Management.Automation;

namespace movie_buster.Misc.Powershell
{
    public class PowershellExecutor
    {
        public PowershellExecutor() { }

        public void run (string scriptPath, params string[] args)
        {
            using (PowerShell PowerShellInst = PowerShell.Create())
            {
                PowerShell ps = PowerShell.Create();

                ps.AddScript(File.ReadAllText(scriptPath));

                // Add arguments to the command.
                foreach (string arg in args) { ps.AddArgument(arg); }

                ps.Invoke();
            }
        }
    }
}
