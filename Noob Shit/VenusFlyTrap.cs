using System;
using Server;

namespace Server.Items
{
	public class VenusFlyTrap : Item //add a name before Deed(LayerDeed or HouseJoinDeed)also for the Deed below same name
	{
		[Constructable]
		public VenusFlyTrap() : base(0x9968) // check this number to be sure its for a blank deed 
		{
			Name = "A Giant Venus Flytrap";
			Hue =0;
			LootType = LootType.Blessed;
		}

		public VenusFlyTrap(Serial serial) : base( serial )
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
}