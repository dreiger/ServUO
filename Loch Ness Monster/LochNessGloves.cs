// Created with UO Armor Generator
// Created On: 10/26/2016 8:02:24 AM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class LochNessGloves : RingmailGloves
    {
        public override int BasePhysicalResistance{ get{ return 55; } }
        public override int BaseColdResistance{ get{ return 55; } }
        public override int BaseFireResistance{ get{ return 25; } }
        public override int BaseEnergyResistance{ get{ return 25; } }
        public override int BasePoisonResistance{ get{ return 25; } }

        [Constructable]
        public LochNessGloves()
        {
            Name = "Loch Ness Gloves";
            Hue = 2431;
            Attributes.NightSight = 1;
            Attributes.AttackChance = 25;
            Attributes.DefendChance = 25;
            ArmorAttributes.LowerStatReq = 25;
            Attributes.LowerManaCost = 15;
            Attributes.LowerRegCost = 15;
            SkillBonuses.SetValues( 0, SkillName.Fishing, 25.0 );
            SkillBonuses.SetValues( 1, SkillName.Hiding, 25.0 );
            SkillBonuses.SetValues( 2, SkillName.Tracking, 25.0 );
        }

        public LochNessGloves(Serial serial) : base( serial )
        {
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }
    } // End Class
} // End Namespace
