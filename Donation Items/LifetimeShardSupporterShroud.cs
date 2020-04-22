using System;
using Server;

namespace Server.Items
{
	public class LifetimeShardSupporterShroud : HoodedShroudOfShadows
	{
		public override int ArtifactRarity{ get{ return 1001; } }

		public override int BasePhysicalResistance{ get{ return 75; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
        public LifetimeShardSupporterShroud()
		{
      Name = "Lifetime Shard Supporter Shroud"; 
			Hue = 2971;
			Attributes.BonusHits = 100;
			Attributes.Luck = 500;
			Attributes.ReflectPhysical = 35;
			Attributes.AttackChance = 75;
      Attributes.BonusDex = 175;
      Attributes.BonusInt = 175;
      Attributes.BonusMana = 175;
      Attributes.BonusStam = 175;
      Attributes.CastRecovery = 18;
      Attributes.CastSpeed = 16;
      Attributes.DefendChance = 75;
      Attributes.EnhancePotions = 175;
      Attributes.LowerManaCost = 100;
      Attributes.LowerRegCost = 100;
      Attributes.NightSight = 1;
      Attributes.RegenHits = 175;
      Attributes.RegenMana = 175;
      Attributes.RegenStam = 175;
      Attributes.SpellDamage = 175;
      Attributes.WeaponDamage = 175;
      LootType = LootType.Blessed;
		}

		public LifetimeShardSupporterShroud( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

		}
	}
}