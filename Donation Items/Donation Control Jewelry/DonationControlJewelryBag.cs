using System;
using System.Collections.Generic;
using Server.ContextMenus;
using Server.Engines.Craft;
using Server.Gumps;
using Server.Mobiles;
using Server.Multis;
using Server.Network;

namespace Server.Items
{ 
   public class DonationControlJewelryBag : Bag 
   { 
		[Constructable] 
		public DonationControlJewelryBag() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "a bag of Donation Control Jewelry";
			Hue = 2485;
		}
		[Constructable]
		public DonationControlJewelryBag( int amount )
		{
			DropItem( new DonationBracelet() );
			DropItem( new DonationCirclet() );
			DropItem( new DonationEarrings() );
			DropItem( new DonationNecklace() );
			DropItem( new DonationRing() );
		}

      public DonationControlJewelryBag( Serial serial ) : base( serial ) 
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
                                                                                    