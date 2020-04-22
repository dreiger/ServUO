// Created with UO Weapon Generator
// Created On: 12/22/2015 6:39:36 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class FireFarterCrossbow : RepeatingCrossbow
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Dismount; } }

        [Constructable]
        public FireFarterCrossbow()
        {
            Name = "Fire Farter Crossbow";
            Hue = 1976;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 25;
            Attributes.AttackChance = 25;
            Attributes.DefendChance = 25;
            WeaponAttributes.HitPhysicalArea = 25;
            WeaponAttributes.HitHarm = 25;
            WeaponAttributes.HitFireball = 25;
            WeaponAttributes.HitLightning = 25;
        }

        public FireFarterCrossbow(Serial serial) : base( serial )
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
