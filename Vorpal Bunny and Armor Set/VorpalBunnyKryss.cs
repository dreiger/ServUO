// Created with UO Weapon Generator
// Created On: 12/13/2015 9:28:32 AM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class VorpalBunnyKryss : Kryss
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.InfectiousStrike; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.BleedAttack; } }
        public override int ArtifactRarity{ get{ return 69; } }

        [Constructable]
        public VorpalBunnyKryss()
        {
            Name = "Vorpal Bunny Kryss";
            Hue = 0x480;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 45;
            WeaponAttributes.HitLeechStam = 45;
            WeaponAttributes.HitLeechMana = 45;
            Attributes.ReflectPhysical = 5;
            Attributes.EnhancePotions = 45;
            Attributes.SpellDamage = 45;
            WeaponAttributes.HitHarm = 45;
            WeaponAttributes.HitFireball = 45;
            WeaponAttributes.HitLightning = 45;
            WeaponAttributes.HitDispel = 45;
        }

        public VorpalBunnyKryss(Serial serial) : base( serial )
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
