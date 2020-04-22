// Created with UO Armor Generator
// Created On: 12/13/2015 9:23:15 AM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class VorpalBunnyLegs : DragonLegs
    {
        public override int BasePhysicalResistance{ get{ return 45; } }
        public override int BaseColdResistance{ get{ return 45; } }
        public override int BaseFireResistance{ get{ return 45; } }
        public override int BaseEnergyResistance{ get{ return 45; } }
        public override int BasePoisonResistance{ get{ return 45; } }
        public override int ArtifactRarity{ get{ return 69; } }

        [Constructable]
        public VorpalBunnyLegs()
        {
            Name = "Vorpal Bunny Legs";
            Hue = 0x480;
            StrRequirement = 45;
            DexRequirement = 45;
            IntRequirement = 45;
            Attributes.NightSight = 1;
            Attributes.RegenHits = 5;
            Attributes.RegenStam = 5;
            Attributes.Luck = 5;
            Attributes.EnhancePotions = 45;
            Attributes.SpellDamage = 45;
            ArmorAttributes.MageArmor = 1;
            ArmorAttributes.SelfRepair = 5;
            ArmorAttributes.LowerStatReq = 5;
            Attributes.LowerManaCost = 45;
            Attributes.LowerRegCost = 45;
            SkillBonuses.SetValues( 0, SkillName.Cooking, 45.0 );
            SkillBonuses.SetValues( 1, SkillName.Fishing, 45.0 );
            SkillBonuses.SetValues( 2, SkillName.Herding, 45.0 );
            SkillBonuses.SetValues( 3, SkillName.Inscribe, 45.0 );
        }

        public VorpalBunnyLegs(Serial serial) : base( serial )
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
