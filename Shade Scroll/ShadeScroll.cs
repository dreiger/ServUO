using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using System.Collections;

namespace Server.Items
{
   public class ShadeScroll : Item
   {
      [Constructable]
      public ShadeScroll() : base( 0x14F0 )
      {
         Name = "Guardian Summoning Scroll";
		 Hue = 2675;
 
      }
	  public override void AddNameProperty(ObjectPropertyList list)
        {
            base.AddNameProperty(list);
            list.Add("([Guardian Summoner])");
        }

      public override void OnDoubleClick( Mobile from )
      {

			PlayerMobile pm = from as PlayerMobile;

			{
				//from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}

		        {
        		ShadeGuardian ShadeGuardian = new ShadeGuardian();
        		ShadeGuardian.Location = from.Location;
        		ShadeGuardian.Map = from.Map;
        		World.AddMobile( ShadeGuardian );

                from.SendMessage( "You have woken an ancient evil!" );
				this.Delete(); 
		        } 
		        //else 
		        { 
		            from.SendLocalizedMessage( 500446 ); // That is too far away. 
		        }
      }

      public ShadeScroll( Serial serial ) : base( serial )
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
