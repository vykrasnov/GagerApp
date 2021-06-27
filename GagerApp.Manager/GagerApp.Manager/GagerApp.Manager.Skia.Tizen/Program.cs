using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace GagerApp.Manager.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new GagerApp.Manager.App(), args);
            host.Run();
        }
    }
}
