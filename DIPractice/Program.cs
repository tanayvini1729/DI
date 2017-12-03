using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var windsorContainer = new WindsorContainer();
            windsorContainer.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            windsorContainer.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());

            var root = windsorContainer.Resolve<ICompositionRoot>();
            root.LogMessage("Hello My first DI");
            Console.ReadLine();
        }
    }
}
