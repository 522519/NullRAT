﻿namespace NullRAT.Dependencies
{
    internal class Exit
    {
        /// <summary>
        /// The program's exit point
        /// </summary>
        public static void ExitProgram()
        {
            while (ProgramData.InstalledPackages < ProgramData.PackagesToInstall)
            {
                Thread.Sleep(500);
            }
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule());

            if (ProgramData.PackagesFailed > 0)
            {
                AnsiConsole.MarkupLine("\n[maroon][[WARN]] Unable to install some packages[/]");

                for (int i = 0; i < ProgramData.FailedPackages.Count; i++)
                {
                    AnsiConsole.MarkupLine($"Run: \"pip install {ProgramData.Packages[i]}\" to install the package manually");
                }
            }
			else {
				AnsiConsole.MarkupLine("\n[green][[INFO]] All packages have been installed successfully![/]\n");
			}
            Environment.Exit(0);
        }
    }
}
