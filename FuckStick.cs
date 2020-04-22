//Created with Script Creator By Marak & Rockstar
using System;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
	public class FuckStick : WarHammer
  {
public override int ArtifactRarity{ get{ return 666; } }
		public override int OldMinDamage{ get{ return 666; } }
		public override int AosMinDamage{ get{ return 666; } }
		public override int OldMaxDamage{ get{ return 1313; } }
		public override int AosMaxDamage{ get{ return 1313; } }

		public override int InitMinHits{ get{ return 666; } }
		public override int InitMaxHits{ get{ return 1313; } }

      [Constructable]
		public FuckStick()
		{
			Weight = 1;
          Name = "a Fuck Stick";
      WeaponAttributes.DurabilityBonus = 666;
      WeaponAttributes.HitColdArea = 666;
      WeaponAttributes.HitDispel = 666;
      WeaponAttributes.HitEnergyArea = 666;
      WeaponAttributes.HitFireArea = 666;
      WeaponAttributes.HitFireball = 666;
      WeaponAttributes.HitHarm = 666;
      WeaponAttributes.HitLeechHits = 666;
      WeaponAttributes.HitLeechMana = 666;
      WeaponAttributes.HitLeechStam = 666;
      WeaponAttributes.HitLightning = 666;
      WeaponAttributes.HitLowerAttack = 666;
      WeaponAttributes.HitLowerDefend = 666;
      WeaponAttributes.HitMagicArrow = 666;
      WeaponAttributes.HitPhysicalArea = 666;
      WeaponAttributes.HitPoisonArea = 666;
      WeaponAttributes.LowerStatReq = 666;
      WeaponAttributes.SelfRepair = 666;
      WeaponAttributes.UseBestSkill = 1;
      Attributes.AttackChance = 666;
      Attributes.BonusDex = 666;
      Attributes.BonusHits = 666;
      Attributes.BonusInt = 666;
      Attributes.BonusMana = 666;
      Attributes.BonusStam = 666;
      Attributes.CastRecovery = 6;
      Attributes.CastSpeed = 6;
      Attributes.DefendChance = 666;
      Attributes.EnhancePotions = 666;
      Attributes.Luck = 666;
      Attributes.NightSight = 1;
      Attributes.RegenHits = 666;
      Attributes.RegenMana = 666;
      Attributes.RegenStam = 666;
      Attributes.SpellChanneling = 1;
      Attributes.SpellDamage = 666;
      Attributes.WeaponDamage = 666;
      Attributes.WeaponSpeed = 666;
      Attributes.BonusMana = 666;
		}

		public FuckStick( Serial serial ) : base( serial )
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
