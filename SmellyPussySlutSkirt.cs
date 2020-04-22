// Created with UO Armor Generator
// Created On: 10/3/2016 6:29:57 PM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class SmellyPussySlutSkirt : LeatherSkirt
    {
        public override int BasePhysicalResistance{ get{ return 25; } }
        public override int BaseColdResistance{ get{ return 25; } }
        public override int BaseFireResistance{ get{ return 25; } }
        public override int BaseEnergyResistance{ get{ return 25; } }
        public override int BasePoisonResistance{ get{ return 25; } }

        [Constructable]
        public SmellyPussySlutSkirt()
        {
            Name = "Smelly Pussy Slut Skirt (there's some ho's in this house)";
            Hue = 55;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 25;
            Attributes.BonusInt = 25;
            Attributes.BonusDex = 25;
            Attributes.BonusHits = 25;
            Attributes.BonusStam = 25;
            Attributes.BonusMana = 25;
            Attributes.RegenHits = 25;
            Attributes.RegenStam = 25;
            Attributes.AttackChance = 25;
            Attributes.DefendChance = 25;
            Attributes.WeaponDamage = 25;
            Attributes.WeaponSpeed = 25;
            Attributes.Luck = 25;
            Attributes.EnhancePotions = 25;
            Attributes.SpellDamage = 25;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.SelfRepair = 5;
            ArmorAttributes.LowerStatReq = 25;
            Attributes.CastSpeed = 5;
            Attributes.CastRecovery = 5;
            Attributes.LowerManaCost = 25;
            Attributes.LowerRegCost = 25;
        }

        public SmellyPussySlutSkirt(Serial serial) : base( serial )
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
