using Vintagestory.API.Client;
using Vintagestory.API.Server;
using Vintagestory.API.Config;
using Vintagestory.API.Common;

namespace Alchemy;

public class AlchemyModSystem : ModSystem
{

    // Called on server and client
    // Useful for registering block/entity classes on both sides
    public override void Start(ICoreAPI api)
    {
        Mod.Logger.Notification("Hello from template mod: " + api.Side);
    }

    public override void StartServerSide(ICoreServerAPI api)
    {
        Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("alchemy:hello"));
    }

    public override void StartClientSide(ICoreClientAPI api)
    {
        api.SendChatMessage("i'm watching you boy...");
        Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("alchemy:hello"));
    }

}
