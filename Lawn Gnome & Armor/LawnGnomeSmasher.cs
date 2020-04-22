// Created with UO Weapon Generator
// Created On: 12/17/2015 9:07:37 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class LawnGnomeSmasher : WarHammer
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.BleedAttack; } }
        public override int ArtifactRarity{ get{ return 1313; } }

        [Constructable]
        public LawnGnomeSmasher()
        {
            Name = "Lawn Gnome Smasher";
            Hue = 2431;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 25;
            WeaponAttributes.HitLeechStam = 25;
            WeaponAttributes.HitLeechMana = 25;
            WeaponAttributes.HitPoisonArea = 25;
            Attributes.CastSpeed = 4;
            Attributes.CastRecovery = 4;
            Attributes.LowerManaCost = 25;
            Attributes.LowerRegCost = 25;
            WeaponAttributes.HitHarm = 25;
            WeaponAttributes.HitFireball = 25;
            WeaponAttributes.HitLightning = 25;
            WeaponAttributes.HitDispel = 25;
        }

        public LawnGnomeSmasher(Serial serial) : base( serial )
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
