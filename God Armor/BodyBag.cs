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
   public class GodlyArmorBag : Bag 
   { 
		[Constructable] 
		public GodlyArmorBag() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "a bag of Godly Armor";
			Hue = 32;
		}
		[Constructable]
		public GodlyArmorBag( int amount )
		{
			DropItem( new FemaleGodChest() );
			DropItem( new GodArms() );
			DropItem( new GodChest() );
			DropItem( new GodGloves() );
			DropItem( new GodHelm() );
			DropItem( new GodLegs() );
			DropItem( new GodNeck() );
			DropItem( new GodShield() );
		}

      public GodlyArmorBag( Serial serial ) : base( serial ) 
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
                                                                                    