using System; 
using Server; 
using Server.Items;

namespace Server.Items
{ 
   public class ArrakisNoobBag : Bag 
   { 
		[Constructable] 
		public ArrakisNoobBag() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "A Bag Of Newbie Armor";
			Hue = 2803;
		}
		[Constructable]
		public ArrakisNoobBag( int amount )
		{
			DropItem( new NewbieHat() );
			DropItem( new NewbieChest() );
			DropItem( new NewbieGloves() );
            DropItem( new NewbieGorget() );
			DropItem( new NewbieLegs() );
			DropItem( new NewbieArms() );
            DropItem( new ArrakisSandals() );
            DropItem( new WelcomeShroud() );
		}

      public ArrakisNoobBag( Serial serial ) : base( serial ) 
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
