//Made By Makoro Shimoro
using System;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x1410, 0x1417 )]
	public class GodsFuckinArms : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 500; } }
		public override int BaseFireResistance{ get{ return 300; } }
		public override int BaseColdResistance{ get{ return 200; } }
		public override int BasePoisonResistance{ get{ return 300; } }
		public override int BaseEnergyResistance{ get{ return 200; } }

		public override int InitMinHits{ get{ return 500; } }
		public override int InitMaxHits{ get{ return 650; } }

		public override int AosStrReq{ get{ return 800; } }
		public override int OldStrReq{ get{ return 400; } }

		public override int OldDexBonus{ get{ return 200; } }

		public override int ArmorBase{ get{ return 400; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }

		[Constructable]
		public GodsFuckinArms() : base( 0x1410 )
		{
			

			Name = "God's Fuckin Arms";
			Hue = 2288;
			Weight = 1.0;
			Attributes.DefendChance = 1500;
			Attributes.BonusHits = 1000;
			FireBonus = 7000;
			PhysicalBonus = 5000;
			ColdBonus = 8000;
			PoisonBonus = 7000;
			EnergyBonus = 8000;
		}

		public GodsFuckinArms( Serial serial ) : base( serial )
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

			if ( Weight == 1.0 )
				Weight = 5.0;
		}
	}
}