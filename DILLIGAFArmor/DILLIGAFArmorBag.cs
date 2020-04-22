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
   public class DILLIGAFArmorBag : Bag 
   { 
		[Constructable] 
		public DILLIGAFArmorBag() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "a bag of DILLIGAF Armor";
			Hue = 2431;
		}
		[Constructable]
		public DILLIGAFArmorBag( int amount )
		{
			DropItem( new DILLIGAFArms() );
			DropItem( new DILLIGAFBlade() );
			DropItem( new DILLIGAFFemaleArmor() );
			DropItem( new DILLIGAFGloves() );
			DropItem( new DILLIGAFGorget() );
			DropItem( new DILLIGAFHeadBasher() );
			DropItem( new DILLIGAFHelm() );
			DropItem( new DILLIGAFLegs() );
			DropItem( new DILLIGAFSheild() );
			DropItem( new DILLIGAFSticker() );
			DropItem( new DILLIGAFTunic() );
		}

      public DILLIGAFArmorBag( Serial serial ) : base( serial ) 
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
                                                                                    