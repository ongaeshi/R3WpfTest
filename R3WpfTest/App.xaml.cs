using R3;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace R3WpfTest
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // You need to set UnhandledExceptionHandler
            WpfProviderInitializer.SetDefaultObservableSystem(ex => Trace.WriteLine($"R3 UnhandledException:{ex}"));
        }
    }

}
