// Created with UO Weapon Generator
// Created On: 8/7/2015 1:33:46 AM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class DeezNuts : CompositeBow
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.InfectiousStrike; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }
        public override int ArtifactRarity{ get{ return 666; } }
        public override int InitMinHits{ get{ return 666; } }
        public override int InitMaxHits{ get{ return 1000; } }

        [Constructable]
        public DeezNuts()
        {
            Name = "Deez Nuts";
            Hue = 2156;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 66;
            Attributes.BonusInt = 66;
            Attributes.BonusDex = 66;
            Attributes.BonusHits = 66;
            Attributes.BonusStam = 66;
            Attributes.BonusMana = 66;
            Attributes.RegenHits = 100;
            Attributes.RegenStam = 100;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 100;
            WeaponAttributes.HitLeechStam = 100;
            WeaponAttributes.HitLeechMana = 100;
            Attributes.WeaponDamage = 600;
            Attributes.Luck = 666;
            Attributes.ReflectPhysical = 6;
            Attributes.EnhancePotions = 66;
            Attributes.SpellDamage = 66;
            WeaponAttributes.HitPhysicalArea = 100;
            WeaponAttributes.HitColdArea = 100;
            WeaponAttributes.HitFireArea = 100;
            WeaponAttributes.HitEnergyArea = 100;
            WeaponAttributes.HitPoisonArea = 100;
            WeaponAttributes.ResistPhysicalBonus = 45;
            WeaponAttributes.ResistColdBonus = 45;
            WeaponAttributes.ResistFireBonus = 45;
            WeaponAttributes.ResistEnergyBonus = 45;
            WeaponAttributes.ResistPoisonBonus = 5;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 6;
            Attributes.LowerManaCost = 50;
            Attributes.LowerRegCost = 50;
            WeaponAttributes.HitHarm = 100;
            WeaponAttributes.HitFireball = 100;
            WeaponAttributes.HitLightning = 100;
            WeaponAttributes.HitDispel = 100;
        }

        public DeezNuts(Serial serial) : base( serial )
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
