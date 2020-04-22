// Created with UO Armor Generator
// Created On: 9/3/2016 11:42:01 AM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class DILLIGAFGloves : LeatherGloves
    {
        public override int BasePhysicalResistance{ get{ return 65; } }
        public override int BaseColdResistance{ get{ return 65; } }
        public override int BaseFireResistance{ get{ return 65; } }
        public override int BaseEnergyResistance{ get{ return 65; } }
        public override int BasePoisonResistance{ get{ return 65; } }
        public override int ArtifactRarity{ get{ return 999; } }
        public override int InitMinHits{ get{ return 1000; } }
        public override int InitMaxHits{ get{ return 1000; } }

        [Constructable]
        public DILLIGAFGloves()
        {
            Name = "DILLIGAFGloves";
            Hue = 2431;
            StrRequirement = 25;
            DexRequirement = 25;
            IntRequirement = 25;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 65;
            Attributes.BonusInt = 65;
            Attributes.BonusDex = 65;
            Attributes.BonusHits = 65;
            Attributes.BonusStam = 65;
            Attributes.BonusMana = 65;
            Attributes.RegenHits = 65;
            Attributes.RegenStam = 65;
            Attributes.AttackChance = 65;
            Attributes.DefendChance = 65;
            Attributes.WeaponDamage = 65;
            Attributes.WeaponSpeed = 65;
            Attributes.Luck = 65;
            Attributes.EnhancePotions = 65;
            Attributes.SpellDamage = 65;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.DurabilityBonus = 5;
            ArmorAttributes.SelfRepair = 6;
            ArmorAttributes.LowerStatReq = 65;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 6;
            Attributes.LowerManaCost = 65;
            Attributes.LowerRegCost = 65;
            SkillBonuses.SetValues( 0, SkillName.MagicResist, 65.0 );
            SkillBonuses.SetValues( 1, SkillName.EvalInt, 65.0 );
            SkillBonuses.SetValues( 2, SkillName.Healing, 65.0 );
            SkillBonuses.SetValues( 3, SkillName.Magery, 65.0 );
        }

        public DILLIGAFGloves(Serial serial) : base( serial )
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
