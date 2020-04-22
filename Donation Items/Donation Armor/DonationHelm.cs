// Created with UO Armor Generator
// Created On: 9/17/2016 3:30:20 PM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class DonationHelm : NorseHelm
    {
        public override int BasePhysicalResistance{ get{ return 70; } }
        public override int BaseColdResistance{ get{ return 70; } }
        public override int BaseFireResistance{ get{ return 70; } }
        public override int BaseEnergyResistance{ get{ return 70; } }
        public override int BasePoisonResistance{ get{ return 70; } }
        public override int InitMinHits{ get{ return 100; } }
        public override int InitMaxHits{ get{ return 100; } }

        [Constructable]
        public DonationHelm()
        {
            Name = "Donation Helm";
            Hue = 2431;
            StrRequirement = 1;
            DexRequirement = 1;
            IntRequirement = 1;
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
            Attributes.EnhancePotions = 75;
            Attributes.SpellDamage = 75;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.DurabilityBonus = 100;
            ArmorAttributes.SelfRepair = 5;
            ArmorAttributes.LowerStatReq = 100;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 6;
            Attributes.LowerManaCost = 100;
            Attributes.LowerRegCost = 100;
            SkillBonuses.SetValues( 0, SkillName.Musicianship, 100.0 );
            SkillBonuses.SetValues( 1, SkillName.Peacemaking, 100.0 );
            SkillBonuses.SetValues( 2, SkillName.Discordance, 100.0 );
            SkillBonuses.SetValues( 3, SkillName.Provocation, 100.0 );
        }

        public DonationHelm(Serial serial) : base( serial )
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
