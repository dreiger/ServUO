// Created with UO Weapon Generator
// Created On: 9/3/2016 11:46:21 AM
// By: daver

using System;
using Server;

namespace Server.Items
{
    public class DILLIGAFHeadBasher : WarHammer
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.InfectiousStrike; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }
        public override int ArtifactRarity{ get{ return 999; } }
        public override int InitMinHits{ get{ return 1000; } }
        public override int InitMaxHits{ get{ return 1000; } }

        [Constructable]
        public DILLIGAFHeadBasher()
        {
            Name = "DILLIGAFHeadBasher";
            Hue = 2431;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 65;
            Attributes.BonusInt = 65;
            Attributes.BonusDex = 65;
            Attributes.BonusHits = 65;
            Attributes.BonusStam = 65;
            Attributes.BonusMana = 65;
            Attributes.RegenHits = 65;
            Attributes.RegenStam = 65;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 65;
            WeaponAttributes.HitLeechStam = 65;
            WeaponAttributes.HitLeechMana = 65;
            Attributes.AttackChance = 65;
            Attributes.DefendChance = 65;
            Attributes.WeaponDamage = 65;
            Attributes.WeaponSpeed = 65;
            Attributes.Luck = 65;
            Attributes.ReflectPhysical = 6;
            Attributes.EnhancePotions = 65;
            Attributes.SpellDamage = 65;
            WeaponAttributes.ResistPhysicalBonus = 25;
            WeaponAttributes.ResistColdBonus = 25;
            WeaponAttributes.ResistFireBonus = 25;
            WeaponAttributes.ResistEnergyBonus = 25;
            WeaponAttributes.ResistPoisonBonus = 25;
            WeaponAttributes.DurabilityBonus = 65;
            WeaponAttributes.SelfRepair = 6;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 6;
            Attributes.LowerManaCost = 65;
            Attributes.LowerRegCost = 65;
            WeaponAttributes.HitLowerAttack = 65;
            WeaponAttributes.HitLowerDefend = 65;
            WeaponAttributes.HitHarm = 65;
            WeaponAttributes.HitFireball = 65;
            WeaponAttributes.HitLightning = 65;
            WeaponAttributes.HitDispel = 65;
        }

        public DILLIGAFHeadBasher(Serial serial) : base( serial )
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
