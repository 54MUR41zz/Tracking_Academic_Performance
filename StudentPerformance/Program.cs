using Autofac;
using StudentPerformance.Forms;
using StudentPerformance.Infrastructure;

namespace StudentPerformance;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        using IContainer container = ContainerConfig.Build();
        Application.Run(container.Resolve<MainForm>());
    }
}
