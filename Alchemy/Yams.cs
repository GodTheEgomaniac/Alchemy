using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;
using Vintagestory.API.Server;

namespace Alchemy
{
    public class FuckingYams : Block
    {
        // this isnt the actual rite way to handle block interactions i dont thin.k. i think you need to make a block behaviour class or something
        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer by_player, BlockSelection block_sel)
        {
            if (world.Side == EnumAppSide.Server)
            {
                if (by_player is IServerPlayer server_player)
                {
                    ItemSlot s = by_player.Entity.ActiveHandItemSlot;
                    ItemStack eat_shit = s.TakeOutWhole();  // this also deleted the item slot contents aswell as returning it
                    s.MarkDirty();  // i still entirely get why this is necessary but apparently after changing an item slot you gotta do it
                    server_player.SendMessage(GlobalConstants.InfoLogChatGroup, " I AM GOING TO INSERT A WIRE BRUSH THROUGH MY EURETHRA !", EnumChatType.Notification);
                }
            }
            return true;
        }

        public override void OnEntityCollide(IWorldAccessor world, Entity entity, BlockPos pos, BlockFacing facing, Vec3d collideSpeed, bool isImpact)
        {
            if (entity is EntityPlayer entity_player)
            {
                IServerPlayer? server_player = entity_player.Player as IServerPlayer;
                server_player?.SendMessage(GlobalConstants.InfoLogChatGroup, $" DEAR {server_player.PlayerName} YOUR IP ADDRESS IS {server_player.IpAddress} I AM COMING FOR YOU ", EnumChatType.AllGroups);
                entity.Die(EnumDespawnReason.Combusted);
            }
        }
    }
}

