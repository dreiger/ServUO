//Made By Makoro Shimoro
using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x143D, 0x143C )]
	public class GodsFuckinHammer : BaseBashing
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 45; } }
		public override int AosMinDamage{ get{ return 1500; } }
		public override int AosMaxDamage{ get{ return 1700; } }
		public override int AosSpeed{ get{ return 280; } }

		public override int OldStrengthReq{ get{ return 35; } }
		public override int OldMinDamage{ get{ return 6; } }
		public override int OldMaxDamage{ get{ return 33; } }
		public override int OldSpeed{ get{ return 30; } }

		public override int InitMinHits{ get{ return 3100; } }
		public override int InitMaxHits{ get{ return 7000; } }

		[Constructable]
		public GodsFuckinHammer() : base( 0x143D )
		{
			Hue = 2288;
			Name = "God's Fuckin Hammer";
			Weight = 9.0;
			Layer = Layer.OneHanded;
			Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 5000;
            Attributes.BonusInt = 5000;
            Attributes.BonusDex = 5000;
            Attributes.BonusHits = 5000;
            Attributes.BonusStam = 5000;
            Attributes.BonusMana = 5000;
            Attributes.RegenHits = 5000;
            Attributes.RegenStam = 5000;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 5000;
            WeaponAttributes.HitLeechStam = 5000;
            WeaponAttributes.HitLeechMana = 5000;
            Attributes.AttackChance = 500;
            Attributes.DefendChance = 500;
            Attributes.WeaponDamage = 5000;
            Attributes.WeaponSpeed = 5000;
            Attributes.Luck = 5000;
            Attributes.EnhancePotions = 500;
            Attributes.SpellDamage = 5000;
            WeaponAttributes.HitPhysicalArea = 5000;
            WeaponAttributes.HitColdArea = 5000;
            WeaponAttributes.HitFireArea = 5000;
            WeaponAttributes.HitEnergyArea = 5000;
            WeaponAttributes.HitPoisonArea = 5000;
            WeaponAttributes.ResistPhysicalBonus = 250;
            WeaponAttributes.ResistColdBonus = 250;
            WeaponAttributes.ResistFireBonus = 250;
            WeaponAttributes.ResistEnergyBonus = 250;
            WeaponAttributes.ResistPoisonBonus = 250;
            WeaponAttributes.DurabilityBonus = 1000;
            WeaponAttributes.SelfRepair = 50;
            Attributes.CastSpeed = 50;
            Attributes.CastRecovery = 05;
            Attributes.LowerManaCost = 5000;
            Attributes.LowerRegCost = 5000;
            WeaponAttributes.HitLowerAttack = 5000;
            WeaponAttributes.HitLowerDefend = 5000;
            WeaponAttributes.HitHarm = 5000;
            WeaponAttributes.HitFireball = 5000;
            WeaponAttributes.HitLightning = 5000;
            WeaponAttributes.HitDispel = 5000;
		}

		public GodsFuckinHammer( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}