// CREATED BY FCONDON AKA EXALE ORIGINALLY FOR RUNUO UPDATED FOR SERVUO / JUSTUO

using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class DonationBracelet : GoldBracelet
	{

		[Constructable]
		public DonationBracelet()
		{
			Name = "Donation Bracelet (+3 followers)";
			Hue = 2485;
		//	LootType = Blessed;
		}

		public DonationBracelet( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override bool OnEquip( Mobile from )
		{
			if ( from is PlayerMobile )
			{
				PlayerMobile m = (PlayerMobile)from;
				m.FollowersMax += 3;
				this.Movable = false;
			}
			return base.OnEquip( from );
		}

		
#if NEWPARENT
		public override void OnRemoved(IEntity parent)
#else
        public override void OnRemoved(object parent)
#endif
		//public override void OnRemoved( object parent )
		{
			if ( parent is PlayerMobile )
			{
				PlayerMobile mm = (PlayerMobile)parent;
				if (!((mm.FollowersMax - 3) < mm.Followers))
				{
					this.Movable = true;
					mm.FollowersMax -= 1;
				}
				else
				{
					mm.SendMessage( "You must reduce your followers before you can remove this." );
				}
			}
			return;
		}

		public override void OnDoubleClick( Mobile fromm ) 
		{
			if ( this.Parent == fromm ) 
			{
				if ( fromm is PlayerMobile )
				{
					PlayerMobile mmm = (PlayerMobile)fromm;
					if (!((mmm.FollowersMax - 1) < mmm.Followers))
					{
						this.Movable = true;
						mmm.AddToBackpack( this );
					}
					else
					{
						mmm.SendMessage( "You must reduce your followers before you can remove this." );
					}
				}
			}
			return;
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
