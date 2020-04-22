// Created with UO Armor Generator
// Created On: 12/17/2015 9:05:06 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class LawnGnomeHelm : DragonHelm
    {
        public override int BasePhysicalResistance{ get{ return 26; } }
        public override int BaseColdResistance{ get{ return 65; } }
        public override int BaseFireResistance{ get{ return 50; } }
        public override int BaseEnergyResistance{ get{ return 75; } }
        public override int BasePoisonResistance{ get{ return 70; } }
        public override int ArtifactRarity{ get{ return 1313; } }

        [Constructable]
        public LawnGnomeHelm()
        {
            Name = "Lawn Gnome Helm";
            Hue = 2431;
            Attributes.NightSight = 1;
            Attributes.Luck = 50;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.LowerStatReq = 50;
            Attributes.LowerManaCost = 25;
            Attributes.LowerRegCost = 25;
            SkillBonuses.SetValues( 0, SkillName.Magery, 45.0 );
            SkillBonuses.SetValues( 1, SkillName.MagicResist, 45.0 );
            SkillBonuses.SetValues( 2, SkillName.Meditation, 45.0 );
            SkillBonuses.SetValues( 3, SkillName.Necromancy, 45.0 );
        }

        public LawnGnomeHelm(Serial serial) : base( serial )
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
