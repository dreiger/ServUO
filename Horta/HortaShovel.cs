
using Server.Engines.Harvest;

namespace Server.Items
{
	[FlipableAttribute( 0xF39, 0xF39 )]
	public class HortaShovel : BaseAxe, IUsesRemaining
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 15; } }
		public override int AosMaxDamage{ get{ return 17; } }
		public override int AosSpeed{ get{ return 33; } }
        	public override float MlSpeed { get { return 3.00f; } }

		public override int OldStrengthReq{ get{ return 35; } }
		public override int OldMinDamage{ get{ return 6; } }
		public override int OldMaxDamage{ get{ return 33; } }
		public override int OldSpeed{ get{ return 37; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 70; } }

		public override HarvestSystem HarvestSystem{ get{ return Mining.System; } }

		[Constructable]
		public HortaShovel() : this( Utility.RandomMinMax( 101, 625 ) )
		{
		}

		[Constructable]
		public HortaShovel( int uses ) : base( 0xF39 )
		{
			Weight = 4.0;
			//Hue = 0x973; //removed in RunUO
			UsesRemaining = uses;
			ShowUsesRemaining = true;
			Name = "Horta's Shovel";
		}

		public HortaShovel( Serial serial ) : base( serial )
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