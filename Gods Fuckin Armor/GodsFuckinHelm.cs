//Made By Makoro Shimoro
using System;
using Server;

namespace Server.Items
{
	public class GodsFuckinHelm : PlateHelm
	{
		//public override int LabelNumber{ get{ return 1061096; } } // Helm of Insight
		public override int ArtifactRarity{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public GodsFuckinHelm()
		{
			Hue = 2288;
			Name = "God's Fuckin Helm";
			Attributes.BonusDex = 100;
			Attributes.BonusStam = 500;
			Attributes.RegenStam = 200;
			Attributes.AttackChance = 500;
			PhysicalBonus = 1000;
			FireBonus = 1000;
			ColdBonus = 1000;
			PoisonBonus = 1000;
			EnergyBonus = 1000;			
		}

		public GodsFuckinHelm( Serial serial ) : base( serial )
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
	}
}
