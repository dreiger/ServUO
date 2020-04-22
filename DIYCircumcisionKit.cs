// Created with UO Weapon Generator
// Created On: 12/18/2015 10:19:23 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class DIYCircumcisionKit : RuneBlade
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.InfectiousStrike; } }
        public override int ArtifactRarity{ get{ return 68; } }

        [Constructable]
        public DIYCircumcisionKit()
        {
            Name = "DIY Circumcision Kit";
            Hue = 31;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 35;
            WeaponAttributes.HitLeechStam = 35;
            WeaponAttributes.HitLeechMana = 35;
            Attributes.AttackChance = 35;
            Attributes.DefendChance = 35;
            Attributes.WeaponDamage = 35;
            Attributes.WeaponSpeed = 35;
            Attributes.Luck = 50;
            Attributes.ReflectPhysical = 2;
            Attributes.EnhancePotions = 35;
            Attributes.SpellDamage = 35;
            WeaponAttributes.ResistPhysicalBonus = 35;
            WeaponAttributes.ResistColdBonus = 35;
            WeaponAttributes.ResistFireBonus = 35;
            WeaponAttributes.ResistEnergyBonus = 35;
            WeaponAttributes.ResistPoisonBonus = 35;
            WeaponAttributes.SelfRepair = 3;
            Attributes.CastSpeed = 3;
            Attributes.CastRecovery = 3;
            Attributes.LowerManaCost = 35;
            Attributes.LowerRegCost = 35;
            WeaponAttributes.HitLowerAttack = 35;
            WeaponAttributes.HitLowerDefend = 35;
            WeaponAttributes.HitHarm = 35;
            WeaponAttributes.HitFireball = 35;
            WeaponAttributes.HitLightning = 35;
            WeaponAttributes.HitDispel = 35;
        }

        public DIYCircumcisionKit(Serial serial) : base( serial )
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
