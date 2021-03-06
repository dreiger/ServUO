// CREATED BY FCONDON AKA EXALE ORIGINALLY FOR RUNUO UPDATED FOR SERVUO / JUSTUO

using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class DonationCirclet : Circlet
	{

		[Constructable]
		public DonationCirclet()
		{
			Name = "Donation Circlet (+3 followers)";
			Hue = 2485;
	//		LootType = Blessed;
		}

		public DonationCirclet( Serial serial ) : base( serial )
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
		{
			if ( parent is PlayerMobile )
			{
				PlayerMobile m = (PlayerMobile)parent;
				if (!((m.FollowersMax - 3) < m.Followers))
				{
					this.Movable = true;
					m.FollowersMax -= 1;
				}
				else
				{
					m.SendMessage( "You must reduce your followers before you can remove this." );
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
