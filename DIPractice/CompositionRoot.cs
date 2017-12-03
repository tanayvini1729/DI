using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPractice
{
    class CompositionRoot : ICompositionRoot
    {
        IConsoleWriter _consoleWriter;
        public CompositionRoot(IConsoleWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;
            _consoleWriter.LogMessage("Inside CTOR");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
