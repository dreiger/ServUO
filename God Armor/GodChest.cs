// Created with UO Armor Generator
// Created On: 12/4/2015 10:56:46 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class GodChest : PlateChest
    {
        public override int BasePhysicalResistance{ get{ return 100; } }
        public override int BaseColdResistance{ get{ return 100; } }
        public override int BaseFireResistance{ get{ return 100; } }
        public override int BaseEnergyResistance{ get{ return 100; } }
        public override int BasePoisonResistance{ get{ return 100; } }

        [Constructable]
        public GodChest()
        {
            Name = "Godly Chest";
            Hue = 32;
            StrRequirement = 70;
            DexRequirement = 70;
            IntRequirement = 70;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 100;
            Attributes.BonusInt = 100;
            Attributes.BonusDex = 100;
            Attributes.BonusHits = 100;
            Attributes.BonusStam = 100;
            Attributes.BonusMana = 100;
            Attributes.RegenHits = 100;
            Attributes.RegenStam = 100;
            Attributes.AttackChance = 50;
            Attributes.DefendChance = 50;
            Attributes.Luck = 50;
            Attributes.EnhancePotions = 100;
            Attributes.SpellDamage = 100;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.SelfRepair = 5;
            ArmorAttributes.LowerStatReq = 100;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 6;
            Attributes.LowerManaCost = 25;
            Attributes.LowerRegCost = 25;
            SkillBonuses.SetValues( 0, SkillName.Anatomy, 100.0 );
            SkillBonuses.SetValues( 1, SkillName.Tactics, 100.0 );
            SkillBonuses.SetValues( 2, SkillName.Swords, 100.0 );
            SkillBonuses.SetValues( 3, SkillName.Magery, 100.0 );
        }

        public GodChest(Serial serial) : base( serial )
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
