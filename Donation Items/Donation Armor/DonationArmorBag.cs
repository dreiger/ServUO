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
   public class DontaionArmorBag : Bag 
   { 
		[Constructable] 
		public DontaionArmorBag() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "SoD Donation Armor Bag";
			Hue = 2637;
		}
		[Constructable]
		public DontaionArmorBag( int amount )
		{
			DropItem( new DonationArms() );
			DropItem( new DonationChest() );
			DropItem( new DonationFemaleArmor() );
			DropItem( new DonationHands() );
			DropItem( new DonationLegs() );
			DropItem( new DonationNeck() );
			DropItem( new DonationHelm() );
		}

      public DontaionArmorBag( Serial serial ) : base( serial ) 
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
                                                                                    