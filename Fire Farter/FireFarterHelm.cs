// Created with UO Armor Generator
// Created On: 12/22/2015 6:38:14 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class FireFarterHelm : NorseHelm
    {
        public override int BasePhysicalResistance{ get{ return 25; } }
        public override int BaseColdResistance{ get{ return 25; } }
        public override int BaseFireResistance{ get{ return 25; } }
        public override int BaseEnergyResistance{ get{ return 25; } }

        [Constructable]
        public FireFarterHelm()
        {
            Name = "Fire Farter Helm";
            Hue = 1976;
            StrRequirement = 5;
            DexRequirement = 5;
            IntRequirement = 5;
            Attributes.BonusStr = 12;
            Attributes.BonusInt = 13;
            Attributes.BonusDex = 14;
            Attributes.BonusHits = 15;
            Attributes.BonusStam = 17;
            Attributes.BonusMana = 16;
            ArmorAttributes.MageArmor = 1;
            Attributes.LowerManaCost = 25;
            Attributes.LowerRegCost = 25;
            SkillBonuses.SetValues( 0, SkillName.Spellweaving, 25.0 );
            SkillBonuses.SetValues( 1, SkillName.Veterinary, 25.0 );
            SkillBonuses.SetValues( 2, SkillName.RemoveTrap, 25.0 );
            SkillBonuses.SetValues( 3, SkillName.Stealth, 25.0 );
        }

        public FireFarterHelm(Serial serial) : base( serial )
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
