using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace Alchemy
{
    public class FuckingYams : Block
    {
        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer by_player, BlockSelection block_sel)
        {
            if (world.Side == EnumAppSide.Server)
            {
                if (by_player is IServerPlayer server_player)
                {
                    server_player.SendMessage(GlobalConstants.InfoLogChatGroup, " I AM GOING TO INSERT A WIRE BRUSH THROUGH MY EURETHRA !", EnumChatType.Notification);
                }
            }
            return true;
        }
    }
}

