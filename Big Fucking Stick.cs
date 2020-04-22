// Staff item, with 4 open XML Sockets
//
// OP - yes.  Do I give a fuck - no.

using System;
using Server;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
    public class BigFuckingStick : GnarledStaff
    {
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }
        public override int ArtifactRarity{ get{ return 666; } }
        public override int InitMinHits{ get{ return 1000; } }
        public override int InitMaxHits{ get{ return 1000; } }

        [Constructable]
        public BigFuckingStick()
        {
            Name = "a Big Fucking Stick";
            Hue = 2431;
            XmlAttach.AttachTo(this, new XmlSocketable(4));
            XmlAttach.AttachTo(this, new XmlSockets(4));
            LootType = LootType.Blessed;
            Slayer = SlayerName.None;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 1000;
            Attributes.BonusInt = 1000;
            Attributes.BonusDex = 1000;
            Attributes.BonusHits = 1000;
            Attributes.BonusStam = 1000;
            Attributes.BonusMana = 1000;
            Attributes.RegenHits = 1000;
            Attributes.RegenStam = 1000;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 1000;
            WeaponAttributes.HitLeechStam = 1000;
            WeaponAttributes.HitLeechMana = 1000;
            Attributes.AttackChance = 100;
            Attributes.DefendChance = 100;
            Attributes.WeaponDamage = 10000;
            Attributes.WeaponSpeed = 100;
            Attributes.Luck = 500;
            Attributes.ReflectPhysical = 50;
            Attributes.EnhancePotions = 1000;
            Attributes.SpellDamage = 1000;
            WeaponAttributes.HitFireArea = 1000;
            WeaponAttributes.HitEnergyArea = 1000;
            WeaponAttributes.HitPoisonArea = 1000;
            WeaponAttributes.ResistPhysicalBonus = 45;
            WeaponAttributes.ResistColdBonus = 45;
            WeaponAttributes.ResistFireBonus = 45;
            WeaponAttributes.ResistEnergyBonus = 45;
            WeaponAttributes.ResistPoisonBonus = 45;
            WeaponAttributes.SelfRepair = 100;
            Attributes.CastSpeed = 6;
            Attributes.CastRecovery = 6;
            Attributes.LowerManaCost = 100;
            Attributes.LowerRegCost = 100;
            WeaponAttributes.HitLowerAttack = 100;
            WeaponAttributes.HitLowerDefend = 100;
            WeaponAttributes.HitHarm = 1000;
            WeaponAttributes.HitFireball = 1000;
            WeaponAttributes.HitLightning = 1000;
            WeaponAttributes.HitDispel = 1000;
        }

        public BigFuckingStick(Serial serial) : base( serial )
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
