// Created with UO Weapon Generator
// Created On: 12/30/2015 10:58:30 AM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class FHRITP : WarHammer
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }
        public override int ArtifactRarity{ get{ return 69; } }

        [Constructable]
        public FHRITP()
        {
            Name = "FHRITP";
            Hue = 55;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            Attributes.AttackChance = 69;
            Attributes.DefendChance = 69;
            Attributes.WeaponDamage = 69;
            Attributes.WeaponSpeed = 69;
            Attributes.Luck = 69;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 9;
            WeaponAttributes.HitHarm = 69;
            WeaponAttributes.HitFireball = 69;
            WeaponAttributes.HitLightning = 69;
            WeaponAttributes.HitDispel = 69;
        }

        public FHRITP(Serial serial) : base( serial )
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
