// Created with UO Weapon Generator
// Created On: 9/17/2016 7:45:13 AM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class Penis : WarCleaver
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }
        public override int ArtifactRarity{ get{ return 8; } }

        [Constructable]
        public Penis()
        {
            Name = "A Tiny Penis  8====D";
            Hue = 69;
            Slayer = SlayerName.SummerWind;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 5;
            WeaponAttributes.HitLeechStam = 5;
            WeaponAttributes.HitLeechMana = 5;
            Attributes.ReflectPhysical = 5;
            WeaponAttributes.HitPhysicalArea = 25;
            WeaponAttributes.HitColdArea = 25;
            WeaponAttributes.HitFireArea = 25;
            WeaponAttributes.HitEnergyArea = 25;
            WeaponAttributes.HitPoisonArea = 25;
            WeaponAttributes.ResistPhysicalBonus = 10;
            WeaponAttributes.ResistColdBonus = 10;
            WeaponAttributes.ResistFireBonus = 10;
            WeaponAttributes.ResistEnergyBonus = 30;
            WeaponAttributes.ResistPoisonBonus = 30;
            Attributes.LowerRegCost = 25;
        }

        public Penis(Serial serial) : base( serial )
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
