using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Mcs.WindowConsole {
    class Program {
        static void Main(string[] args) {
            // Getting current execution directory
            var currentExecutingPath = Assembly.GetExecutingAssembly().CodeBase;
            string dirtyDirectory = Path.GetDirectoryName(currentExecutingPath);
            string directory = dirtyDirectory.Replace(@"file:\", "");

            // Loading assembly in app context
            Assembly externalAssemblyData = Assembly.LoadFrom($"{directory}\\Mcs.ControlMaster.dll");
            var externalAssembly = File.ReadAllBytes($"{directory}\\Mcs.ControlMaster.dll");
            AppDomain.CurrentDomain.Load(externalAssembly);

            // Now is loading. Creating an instance of class
            var hostTransportCommandInstance = Activator.CreateInstance("Mcs.ControlMaster", "Mcs.ControlMaster.HostTransportCommand");

            // Getting properties for validate instance creation
            var hostTransportCommandType = hostTransportCommandInstance.Unwrap().GetType();
            var hostTransportCommandProperties = hostTransportCommandInstance.Unwrap().GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var temp = 1;
        }
    }
}
