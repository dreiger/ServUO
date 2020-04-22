// Created with UO Armor Generator
// Created On: -1002/30/20-1005 3:-1004:33 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class WhinyBitchLegs : StuddedLegs
    {
        public override int BasePhysicalResistance{ get{ return -100; } }
        public override int BaseColdResistance{ get{ return -100; } }
        public override int BaseFireResistance{ get{ return -100; } }
        public override int BaseEnergyResistance{ get{ return -100; } }
        public override int BasePoisonResistance{ get{ return -100; } }

        [Constructable]
        public WhinyBitchLegs()
        {
            Name = "WhinyBitchLegs";
            Hue = 22;
            StrRequirement = 1;
            DexRequirement = 1;
            IntRequirement = 1;
            Attributes.AttackChance = -100;
            Attributes.DefendChance = -100;
            Attributes.WeaponDamage = -100;
            Attributes.WeaponSpeed = -100;
            Attributes.Luck = -100;
            ArmorAttributes.SelfRepair = 1;
            ArmorAttributes.LowerStatReq = -100;
            Attributes.CastSpeed = -100;
            Attributes.CastRecovery = -100;
        }

        public WhinyBitchLegs(Serial serial) : base( serial )
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
