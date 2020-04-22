//Made By Makoro Shimoro
using System;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x1414, 0x1418 )]
	public class GodsFuckinGloves : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 500; } }
		public override int BaseFireResistance{ get{ return 300; } }
		public override int BaseColdResistance{ get{ return 200; } }
		public override int BasePoisonResistance{ get{ return 300; } }
		public override int BaseEnergyResistance{ get{ return 200; } }

		public override int InitMinHits{ get{ return 500; } }
		public override int InitMaxHits{ get{ return 650; } }

		public override int AosStrReq{ get{ return 700; } }
		public override int OldStrReq{ get{ return 300; } }

		public override int OldDexBonus{ get{ return 200; } }

		public override int ArmorBase{ get{ return 400; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }

		[Constructable]
		public GodsFuckinGloves() : base( 0x1414 )
		{
			Name = "God's Fuckin Gloves";
			Hue = 2288;
			Weight = 2.0;
			Attributes.BonusHits = 5000;
			Attributes.AttackChance = 1500;
			PhysicalBonus = 5000;
			FireBonus = 7000;
			ColdBonus = 8000;
			PoisonBonus = 7000;
			EnergyBonus = 8000;
		}

		public GodsFuckinGloves( Serial serial ) : base( serial )
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
				Weight = 2.0;
		}
	}
}