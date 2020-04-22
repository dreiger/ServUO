// Created with UO Weapon Generator
// Created On: 8/15/2016 7:41:22 PM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class PointyFuckingStick : Spear
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.BleedAttack; } }
        public override int ArtifactRarity{ get{ return 69; } }
        public override int InitMinHits{ get{ return 1000; } }
        public override int InitMaxHits{ get{ return 1000; } }

        [Constructable]
        public PointyFuckingStick()
        {
            Name = "a Pointy Fucking Stick";
            Hue = 2431;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 500;
            Attributes.BonusInt = 500;
            Attributes.BonusDex = 500;
            Attributes.BonusHits = 500;
            Attributes.BonusStam = 500;
            Attributes.BonusMana = 500;
            Attributes.RegenHits = 500;
            Attributes.RegenStam = 500;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 50;
            WeaponAttributes.HitLeechStam = 50;
            WeaponAttributes.HitLeechMana = 50;
            Attributes.AttackChance = 50;
            Attributes.DefendChance = 50;
            Attributes.WeaponDamage = 500;
            Attributes.WeaponSpeed = 500;
            Attributes.Luck = 500;
            Attributes.EnhancePotions = 50;
            Attributes.SpellDamage = 50;
            WeaponAttributes.HitPhysicalArea = 500;
            WeaponAttributes.HitColdArea = 500;
            WeaponAttributes.HitFireArea = 500;
            WeaponAttributes.HitEnergyArea = 500;
            WeaponAttributes.HitPoisonArea = 500;
            WeaponAttributes.ResistPhysicalBonus = 25;
            WeaponAttributes.ResistColdBonus = 25;
            WeaponAttributes.ResistFireBonus = 25;
            WeaponAttributes.ResistEnergyBonus = 25;
            WeaponAttributes.ResistPoisonBonus = 25;
            WeaponAttributes.DurabilityBonus = 100;
            WeaponAttributes.SelfRepair = 5;
            Attributes.CastSpeed = 5;
            Attributes.CastRecovery = 5;
            Attributes.LowerManaCost = 50;
            Attributes.LowerRegCost = 50;
            WeaponAttributes.HitLowerAttack = 50;
            WeaponAttributes.HitLowerDefend = 50;
            WeaponAttributes.HitHarm = 500;
            WeaponAttributes.HitFireball = 500;
            WeaponAttributes.HitLightning = 500;
            WeaponAttributes.HitDispel = 500;
        }

        public PointyFuckingStick(Serial serial) : base( serial )
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
