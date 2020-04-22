/* The Picky Kitteh
   Pet to pickup drops for players
   Based off The Picky Beetle - though I don't know who wrote that
   12/2015 DJ Qix
*/



using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Gumps;
using Server.Network;
using Server.ContextMenus;

namespace Server.Mobiles
{
    [CorpseName("a Picky Kitteh corpse")]
    [TypeAlias("Server.Mobiles.HousePickyKitteh")]
    public class PickyKitteh : BaseCreature
    {
        [Constructable]
        public PickyKitteh()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "a Picky Kitteh";
            this.Body = 0xC9;
            this.Hue = Utility.RandomAnimalHue();
            this.BaseSoundID = 0x69;

            this.SetStr(9);
            this.SetDex(35);
            this.SetInt(5);

            this.SetHits(6);
            this.SetMana(0);

            this.SetDamage(1);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 5, 10);

            this.SetSkill(SkillName.MagicResist, 5.0);
            this.SetSkill(SkillName.Tactics, 4.0);
            this.SetSkill(SkillName.Wrestling, 5.0);

            this.Fame = 0;
            this.Karma = 150;

            this.VirtualArmor = 8;

            this.Tamable = true;
            this.ControlSlots = 1;
            this.MinTameSkill = 25.9;
            Container pack = Backpack;

								if ( pack != null )
									pack.Delete();

								pack = new StrongBackpack();
								pack.Movable = false;

								AddItem( pack );
		}

        				private DateTime m_NextPickup;

						public override void OnThink()
						{
							base.OnThink();

							if ( DateTime.Now < m_NextPickup )
								return;

						m_NextPickup = DateTime.Now + TimeSpan.FromSeconds( Utility.RandomMinMax( 0, 0 ) );

							Container pack = this.Backpack;

							if ( pack == null )
								return;

							ArrayList list = new ArrayList();

							foreach ( Item item in this.GetItemsInRange( 5 ) )  // Pickup range is set here
							{
								if ( item.Movable && item.Stackable )
								list.Add( item );
							}

							int pickedUp = 0;

							for ( int i = 0; i < list.Count; ++i )
							{
								Item item = (Item)list[i];

								if ( !pack.CheckHold( this, item, false, true ) )
									return;

								bool rejected;
									LRReason reject;

								NextActionTime = Core.TickCount;

								Lift( item, item.Amount, out rejected, out reject );

								if ( rejected )
									continue;

								Drop( this, Point3D.Zero );

								if ( ++pickedUp == 3 )
									break;
         			}
	                
      			}
          
						#region Pack Animal Methods
							public override bool OnBeforeDeath()
							{
								if ( !base.OnBeforeDeath() )
									return false;

									PackAnimal.CombineBackpacks( this );

									return true;
							}


							public override bool IsSnoop( Mobile from )
							{
								if ( PackAnimal.CheckAccess( this, from ) )
								return false;

								return base.IsSnoop( from );
							}

						public override bool OnDragDrop( Mobile from, Item item )
							{
								if ( CheckFeed( from, item ) )
									return true;

								if ( PackAnimal.CheckAccess( this, from ) )
							{
								AddToBackpack( item );
									return true;
							}

								return base.OnDragDrop( from, item );
							}

						public override bool CheckNonlocalDrop( Mobile from, Item item, Item target )
						{
							return PackAnimal.CheckAccess( this, from );
						}

						public override bool CheckNonlocalLift( Mobile from, Item item )
						{
							return PackAnimal.CheckAccess( this, from );
						}
                
        		public override void OnDoubleClick( Mobile from )
						{
							PackAnimal.TryPackOpen( this, from );
						}

						public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
						{
							base.GetContextMenuEntries( from, list );

							PackAnimal.GetContextMenuEntries( this, from, list );
						}
		#endregion
        

        public PickyKitteh(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.Meat | FoodType.Fish;
            }
        }
        public override PackInstinct PackInstinct
        {
            get
            {
                return PackInstinct.Feline;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}