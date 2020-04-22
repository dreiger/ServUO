/* The Grabasstic Squirrel
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
    [CorpseName("a tree rat corpse")]	
    public class GrabassSquirrel : BaseCreature
    {
        [Constructable]
        public GrabassSquirrel()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "a grabasstic squirrel";
            this.Body = 0x116;
            this.Hue = 2286;

            this.SetStr(44, 50);
            this.SetDex(35);
            this.SetInt(5);

            this.SetHits(42, 50);

            this.SetDamage(1, 2);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 30, 34);
            this.SetResistance(ResistanceType.Fire, 10, 14);
            this.SetResistance(ResistanceType.Cold, 30, 35);
            this.SetResistance(ResistanceType.Poison, 20, 25);
            this.SetResistance(ResistanceType.Energy, 20, 25);

            this.SetSkill(SkillName.MagicResist, 4.0);
            this.SetSkill(SkillName.Tactics, 4.0);
            this.SetSkill(SkillName.Wrestling, 4.0);

            this.Tamable = true;	
            this.ControlSlots = 1;
            this.MinTameSkill = 21.3;
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

							foreach ( Item item in this.GetItemsInRange( 5 ) ) // Pickup range is set here
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

        public GrabassSquirrel(Serial serial)
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
                return FoodType.FruitsAndVegies;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}