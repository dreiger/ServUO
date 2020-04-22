// Created with UO Armor Generator
// Created On: 11/29/2015 10:50:12 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class MotherfuckinNeck : LeatherGorget
    {
        public override int BasePhysicalResistance{ get{ return 70; } }
        public override int BaseColdResistance{ get{ return 70; } }
        public override int BaseFireResistance{ get{ return 70; } }
        public override int BaseEnergyResistance{ get{ return 70; } }
        public override int BasePoisonResistance{ get{ return 70; } }
        public override int InitMinHits{ get{ return 100; } }
        public override int InitMaxHits{ get{ return 100; } }

        [Constructable]
        public MotherfuckinNeck()
        {
            Name = "MotherfuckinNeck";
            Hue = 666;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 100;
            Attributes.BonusInt = 100;
            Attributes.BonusDex = 100;
            Attributes.BonusHits = 100;
            Attributes.BonusStam = 100;
            Attributes.BonusMana = 100;
            Attributes.RegenHits = 100;
            Attributes.RegenStam = 100;
            Attributes.AttackChance = 100;
            Attributes.DefendChance = 100;
            Attributes.WeaponDamage = 100;
            Attributes.WeaponSpeed = 100;
            Attributes.Luck = 100;
            Attributes.EnhancePotions = 100;
            Attributes.SpellDamage = 100;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.DurabilityBonus = 100;
            ArmorAttributes.SelfRepair = 100;
            ArmorAttributes.LowerStatReq = 100;
            Attributes.CastSpeed = 100;
            Attributes.CastRecovery = 100;
            Attributes.LowerManaCost = 100;
            Attributes.LowerRegCost = 100;
            SkillBonuses.SetValues( 0, SkillName.Anatomy, 100.0 );
            SkillBonuses.SetValues( 1, SkillName.Magery, 100.0 );
            SkillBonuses.SetValues( 2, SkillName.AnimalTaming, 100.0 );
            SkillBonuses.SetValues( 3, SkillName.Swords, 100.0 );
        }

        public MotherfuckinNeck(Serial serial) : base( serial )
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
