// Created with UO Weapon Generator
// Created On: 12/30/2015 11:00:19 AM
// By: dave

using System;
using Server;

namespace Server.Items
{
    public class YourMomsDildo : WarMace
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
        public override int ArtifactRarity{ get{ return 68; } }

        [Constructable]
        public YourMomsDildo()
        {
            Name = "Your Mom's Dildo";
            Hue = 69;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 6;
            WeaponAttributes.HitLeechStam = 9;
            WeaponAttributes.HitLeechMana = 6;
            Attributes.WeaponDamage = 68;
            Attributes.WeaponSpeed = 68;
            Attributes.Luck = 69;
            WeaponAttributes.HitPhysicalArea = 69;
            WeaponAttributes.HitColdArea = 69;
            WeaponAttributes.HitFireArea = 69;
            WeaponAttributes.HitEnergyArea = 69;
            WeaponAttributes.HitPoisonArea = 69;
        }

        public YourMomsDildo(Serial serial) : base( serial )
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
