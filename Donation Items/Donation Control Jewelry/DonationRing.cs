// CREATED BY FCONDON AKA EXALE ORIGINALLY FOR RUNUO UPDATED FOR SERVUO / JUSTUO

using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class DonationRing : GoldRing
	{

		[Constructable]
		public DonationRing()
		{
			Name = "Donation Ring (+3 followers)";
			Hue = 2485;
			this.Attributes.NightSight = 1;
			this.Attributes.AttackChance = 20;
			this.Attributes.LowerRegCost = 100;
			this.Attributes.LowerManaCost = 100;
			this.Attributes.RegenHits = 10;
			this.Attributes.RegenStam = 24;
			this.Attributes.RegenMana = 18;
			this.Attributes.SpellDamage = 30;
			this.Attributes.CastRecovery = 6;
			this.Attributes.CastSpeed = 4;
	//		LootType = Blessed;
		}

		public DonationRing( Serial serial ) : base( serial )
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
