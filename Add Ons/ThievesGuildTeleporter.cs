using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Gumps;
using Server.Misc;
using Server.Mobiles;
using Server.Network;
using Server.SkillHandlers;
using Server.Mobiles;
using Server.Guilds;

namespace Server.Items
{

    public class ThievesGuildTeleporter : Teleporter
    { 
        [Constructable]
        public ThievesGuildTeleporter()
        {
        }

        public ThievesGuildTeleporter(Serial serial)
            : base(serial)
        {
        }

        public override bool OnMoveOver(Mobile m)
        {
 
          if (!(m is PlayerMobile))
         {
             return false;
          }
                PlayerMobile player = (PlayerMobile)m;

                if (m is PlayerMobile && ((PlayerMobile)m).NpcGuild == NpcGuild.ThievesGuild)
                {
                    m.SendMessage("Your guild status permits you entry.");
                    return base.OnMoveOver(m);
                }

                 if (Stealing.SuspendOnMurder && m.Kills > 0)
                {
                    // You are currently suspended from the thieves guild.  They would frown upon your actions.
                    m.SendLocalizedMessage(501703);
                    return false;
                }
                else
                {
                    m.SendMessage("Only active members of the Thieves Guild may enter.");
                    return false;
                }

            }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}



