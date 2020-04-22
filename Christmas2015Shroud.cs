using System;
using Server;

namespace Server.Items
{
	public class Christmas2015Shroud : HoodedShroudOfShadows
	{
		public override int ArtifactRarity{ get{ return 2015; } }

		public override int BasePhysicalResistance{ get{ return 35; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
        public Christmas2015Shroud()
		{
      Name = "Christmas 2018 Gift Shroud"; 
			Hue = 2914;
			Attributes.BonusHits = 20;
			Attributes.Luck = 187;
			Attributes.ReflectPhysical = 15;
			Attributes.AttackChance = 15;
      Attributes.BonusDex = 15;
      Attributes.BonusInt = 15;
      Attributes.BonusMana = 15;
      Attributes.BonusStam = 15;
      Attributes.CastRecovery = 8;
      Attributes.CastSpeed = 6;
      Attributes.DefendChance = 15;
      Attributes.EnhancePotions = 15;
      Attributes.LowerManaCost = 15;
      Attributes.LowerRegCost = 15;
      Attributes.Luck = 225;
      Attributes.NightSight = 1;
      Attributes.RegenHits = 15;
      Attributes.RegenMana = 15;
      Attributes.RegenStam = 15;
      Attributes.SpellDamage = 15;
      Attributes.WeaponDamage = 15;
      LootType = LootType.Blessed;
		}

		public Christmas2015Shroud( Serial serial ) : base( serial )
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