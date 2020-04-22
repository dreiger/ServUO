using System;
using Server;

namespace Server.Items
{
	public class DonationShroud : HoodedShroudOfShadows
	{
		public override int ArtifactRarity{ get{ return 1001; } }

		public override int BasePhysicalResistance{ get{ return 45; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
        public DonationShroud()
		{
      Name = "SoD Shard Supporter Shroud"; 
			Hue = 2929;
			Attributes.BonusHits = 100;
			Attributes.Luck = 300;
			Attributes.ReflectPhysical = 25;
			Attributes.AttackChance = 45;
      Attributes.BonusDex = 75;
      Attributes.BonusInt = 75;
      Attributes.BonusMana = 75;
      Attributes.BonusStam = 75;
      Attributes.CastRecovery = 8;
      Attributes.CastSpeed = 6;
      Attributes.DefendChance = 45;
      Attributes.EnhancePotions = 75;
      Attributes.LowerManaCost = 100;
      Attributes.LowerRegCost = 100;
      Attributes.NightSight = 1;
      Attributes.RegenHits = 75;
      Attributes.RegenMana = 75;
      Attributes.RegenStam = 75;
      Attributes.SpellDamage = 75;
      Attributes.WeaponDamage = 75;
    //  LootType = LootType.Blessed;
		}

		public DonationShroud( Serial serial ) : base( serial )
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