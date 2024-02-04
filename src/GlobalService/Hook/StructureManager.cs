using Hosihikari.NativeInterop.Hook.ObjectOriented;
using Hosihikari.NativeInterop.Unmanaged;

namespace Hosihikari.Minecraft.Extension.GlobalService.Hook;

internal sealed class StructureManagerHook()
    : HookBase<StructureManagerHook.HookDelegate>(StructureManager.Original.Constructor_StructureManager)
{
    public override HookDelegate HookedFunc =>
        (@this, rpManager) =>
        {
            Original(@this, rpManager);
            Global.StructureManager.Instance = @this.Target;
            TryUninstall();
        };

    internal delegate void HookDelegate(Pointer<StructureManager> @this, Reference<ResourcePackManager> rpManager);
}