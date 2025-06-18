using System;
using Microsoft.Win32;
using System.IO;
using System.Reflection;

namespace FixRegistry
{
class Program
{
    static void Main(string[] args)
    {
        string protocolName = "gameproject";
        string gameExecutableName = "autoupgrade.exe";

        try
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullGamePath = Path.Combine(currentDirectory, gameExecutableName);

            if (!File.Exists(fullGamePath))
            {
                throw new FileNotFoundException($"Could not find '{gameExecutableName}'. Make sure this program is in the same folder as the game.");
            }

            string registryValue = $"\"{fullGamePath}\" \"%1\"";
            string registryPath = $@"{protocolName}\shell\open\command";

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(registryPath))
            {
                if (key == null)
                {
                    throw new System.Security.SecurityException("Could not create or access the required registry key.");
                }
                key.SetValue("", registryValue, RegistryValueKind.String);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Success fixing the registry, try to start the game again!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failure: Access denied. Please right-click the file and select 'Run as administrator'.");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Failure: An unexpected error occurred. {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
    }
}
