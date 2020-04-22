//Made By Makoro Shimoro
using System;
using Server;

namespace Server.Items
{
	public class GodsFuckinShield : BaseShield, IDyable
	{
		public override int BasePhysicalResistance{ get{ return 1000; } }
		public override int BaseFireResistance{ get{ return 1000; } }
		public override int BaseColdResistance{ get{ return 1000; } }
		public override int BasePoisonResistance{ get{ return 1000; } }
		public override int BaseEnergyResistance{ get{ return 1000; } }

		public override int InitMinHits{ get{ return 450; } }
		public override int InitMaxHits{ get{ return 600; } }

		public override int AosStrReq{ get{ return 450; } }

		public override int ArmorBase{ get{ return 160; } }

		[Constructable]
		public GodsFuckinShield() : base( 0x1B74 )
		{
			Name = "God's Fuckin Shield";
			Hue = 2288;
			Weight = 1.0;
			Attributes.DefendChance = 1500;
			Attributes.AttackChance = 1500;
			Attributes.ReflectPhysical = 1500;
			PhysicalBonus = 1000;
			FireBonus = 1000;
			ColdBonus = 1000;
			PoisonBonus = 1000;
			EnergyBonus = 900;
		}

		public GodsFuckinShield( Serial serial ) : base(serial)
		{
		}

		public bool Dye( Mobile from, DyeTub sender )
		{
			if ( Deleted )
				return false;

			Hue = sender.DyedHue;

			return true;
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( Weight == 5.0 )
				Weight = 7.0;
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );//version
		}
	}
}