using System;

namespace Server.Items
{
	public class CrafterRing : GoldRing
	{
		public override int ArtifactRarity{ get{ return 100; } }

		[Constructable]
		public CrafterRing()
		{
			Hue = 0x845;
			Name = "[Donation Item]Ring of Crafts";
		//	LootType = LootType.Blessed;
			
			Attributes.RegenStam = 25;
			Attributes.RegenMana = 25;
		}

		public override void OnAdded( object parent )
		{
			base.OnAdded( parent );
			if( parent is Mobile )
			{
				Mobile from = (Mobile)parent;
				from.Skills.Alchemy.Base += 50;
                                from.Skills.Blacksmith.Base += 50;
                                from.Skills.Carpentry.Base += 50;
                                from.Skills.Fletching.Base += 50;
                                from.Skills.Inscribe.Base += 50;
                                from.Skills.Tailoring.Base += 50;
                                from.Skills.Tinkering.Base += 50;
			}
		}
		public override void OnRemoved( object parent )
		{
			base.OnRemoved( parent );
			if( parent is Mobile )
			{
				Mobile from = (Mobile)parent;
				from.Skills.Alchemy.Base -= 20;
                                from.Skills.Blacksmith.Base -= 50;
                                from.Skills.Carpentry.Base -= 50;
                                from.Skills.Fletching.Base -= 50;
                                from.Skills.Inscribe.Base -= 50;
                                from.Skills.Tailoring.Base -= 50;
                                from.Skills.Tinkering.Base -= 50;
			}
			
		}

		public CrafterRing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
