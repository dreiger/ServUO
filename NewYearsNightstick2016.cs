// Created with UO Weapon Generator
// Created On: 12/24/2015 10:44:02 PM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class NewYearsNightstick2016 : Scepter
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
        public override int ArtifactRarity{ get{ return 2016; } }

        [Constructable]
        public NewYearsNightstick2016()
        {
            Name = "New Year's Nightstick 2018";
            Hue = 2016;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechMana = 45;
            Attributes.AttackChance = 45;
            Attributes.DefendChance = 45;
            Attributes.WeaponDamage = 45;
            Attributes.WeaponSpeed = 45;
            Attributes.SpellDamage = 45;
            WeaponAttributes.SelfRepair = 3;
            Attributes.CastSpeed = 5;
            Attributes.CastRecovery = 5;
            Attributes.LowerManaCost = 45;
            Attributes.LowerRegCost = 45;
            WeaponAttributes.HitFireball = 45;
            WeaponAttributes.HitLightning = 45;
        }

        public NewYearsNightstick2016(Serial serial) : base( serial )
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
