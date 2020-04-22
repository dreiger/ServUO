/**Created by Trying**/

using System;
using Server;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Misc;
using Server.Mobiles;

namespace Server.Items
{
	public class DontaionFollowerScroll5 : Item
	{
		[Constructable]
		public DontaionFollowerScroll5() : base( 5360 )
		{
			base.Weight = 1.0;
			base.Name = "A Donation Tamer Scroll (+5 Followers)";
      base.Hue = 0x481;
		//	LootType = LootType.Cursed;
		}

		public DontaionFollowerScroll5( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile from )
		{
		PlayerMobile mobile = from as PlayerMobile;

                if ( !IsChildOf( from.Backpack ) ) 
		 { 
			from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
		 }
			else if ( mobile == null || from.Skills[SkillName.AnimalTaming].Base < 10.0 )
			{
				mobile.SendMessage( "You must have at least 10 taming to use this scroll." );
			}
			else if ( mobile.FollowersMax >= 25 )
			{
				mobile.SendMessage( "Sorry, You Would Either Hit, Or Pass 25 Followers Using This Scroll." );
			}
			else
			{
                 	  	mobile.FollowersMax += 5;
			  	mobile.SendMessage( "You have gained 5 to your maximum control slots." );

             
            						Effects.SendLocationParticles( EffectItem.Create( from.Location, from.Map, EffectItem.DefaultDuration ), 0, 0, 0, 0, 0, 5060, 0 );
							Effects.PlaySound( from.Location, from.Map, 0x243 );
Effects.SendMovingParticles( new Entity( Serial.Zero, new Point3D( from.X - 6, from.Y - 6, from.Z + 15 ), from.Map ), from, 0x36D4, 7, 0, false, true, 0x497, 0, 9502, 1, 0, (EffectLayer)255, 0x100 );
							Effects.SendMovingParticles( new Entity( Serial.Zero, new Point3D( from.X - 4, from.Y - 6, from.Z + 15 ), from.Map ), from, 0x36D4, 7, 0, false, true, 0x497, 0, 9502, 1, 0, (EffectLayer)255, 0x100 );
							Effects.SendMovingParticles( new Entity( Serial.Zero, new Point3D( from.X - 6, from.Y - 4, from.Z + 15 ), from.Map ), from, 0x36D4, 7, 0, false, true, 0x497, 0, 9502, 1, 0, (EffectLayer)255, 0x100 );

					Delete(); 
				}
			}
		}
	
	}	

