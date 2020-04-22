// Created with UO Armor Generator
// Created On: 9/17/2016 7:48:39 AM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class PussyBitchShield : ChaosShield
    {
        public override int BasePhysicalResistance{ get{ return 100; } }
        public override int BaseColdResistance{ get{ return 100; } }
        public override int BaseFireResistance{ get{ return 100; } }
        public override int BaseEnergyResistance{ get{ return 100; } }
        public override int BasePoisonResistance{ get{ return 100; } }

        [Constructable]
        public PussyBitchShield()
        {
            Name = "Pussy Bitchass Shield";
            Hue = 68;
            Attributes.NightSight = 1;
            Attributes.AttackChance = 50;
            Attributes.DefendChance = 50;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.SelfRepair = 1;
            SkillBonuses.SetValues( 0, SkillName.Musicianship, 25.0 );
            SkillBonuses.SetValues( 1, SkillName.Peacemaking, 25.0 );
            SkillBonuses.SetValues( 2, SkillName.Discordance, 25.0 );
            SkillBonuses.SetValues( 3, SkillName.Provocation, 25.0 );
        }

        public PussyBitchShield(Serial serial) : base( serial )
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
