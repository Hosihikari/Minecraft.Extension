using System.Runtime.CompilerServices;

namespace Hosihikari.Minecraft.Extension;

internal static class EntryPoint
{
#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255
    internal static void Main() // must be loaded
    {
        LevelTick.InitHook();
        GlobalService.Global.Init();
        if (!OperatingSystem.IsWindows())
        {
            PackHelper.PackHelper.Init();
        }
    }
}