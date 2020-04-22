/* The Picky Turkey
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
    [CorpseName("a Picky Turkey corpse")]
    public class PickyTurkey : BaseCreature
    {
        [Constructable]
        public PickyTurkey()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "a Picky Turkey";
            this.Body = 95;
            this.BaseSoundID = 1642;

            this.SetStr(13, 14);
            this.SetDex(13, 20);
            this.SetInt(5, 15);

            this.SetHits(13, 14);
            this.SetMana(5, 15);
            this.SetStam(13, 20);

            this.SetDamage(1);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 5, 7);
            this.SetResistance(ResistanceType.Fire, 7, 9);
            this.SetResistance(ResistanceType.Cold, 3, 4);
            this.SetResistance(ResistanceType.Poison, 4, 5);
            this.SetResistance(ResistanceType.Energy, 4, 5);

            this.SetSkill(SkillName.MagicResist, 8.7);
            this.SetSkill(SkillName.Tactics, 10.1);
            this.SetSkill(SkillName.Wrestling, 11.1);
            this.SetSkill(SkillName.Anatomy, 69.4);

            //this.Fame = 150;
            this.Karma = 0;

            this.VirtualArmor = 2;

            this.Tamable = true;
            this.ControlSlots = 1;
            this.MinTameSkill = 0.0;
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
        

        public PickyTurkey(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 2;
            }
        }
        public override MeatType MeatType
        {
            get
            {
                return MeatType.Bird;
            }
        }
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.GrainsAndHay;
            }
        }
        public override bool CanFly
        {
            get
            {
                return true;
            }
        }
        public override int Feathers
        {
            get
            {
                return 75;
            }
        }
        public override int GetAngerSound()
        {
            return 0x66B;
        }

        public override int GetIdleSound()
        {
            return 0x66A;
        }

        public override int GetAttackSound()
        {
            return 0x66B;
        }

        public override int GetHurtSound()
        {
            return 0x66B;
        }

        public override int GetDeathSound()
        {
            return 0x072;
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

/*    [CorpseName("a PickyTurkey corpse")]
    public class MisterGobbles : BaseCreature
    {
        [Constructable]
        public MisterGobbles()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "Mister Gobbles";
            this.Body = 95;
            this.BaseSoundID = 1642;

            this.SetStr(15, 20);
            this.SetDex(15, 25);
            this.SetInt(7, 17);

            this.SetHits(15, 20);
            this.SetMana(7, 17);
            this.SetStam(15, 25);

            this.SetDamage(3);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 5, 7);
            this.SetResistance(ResistanceType.Fire, 7, 9);
            this.SetResistance(ResistanceType.Cold, 3, 4);
            this.SetResistance(ResistanceType.Poison, 4, 5);
            this.SetResistance(ResistanceType.Energy, 4, 5);

            this.SetSkill(SkillName.MagicResist, 8.7);
            this.SetSkill(SkillName.Tactics, 10.1);
            this.SetSkill(SkillName.Wrestling, 11.1);
            this.SetSkill(SkillName.Anatomy, 69.4);

            //this.Fame = 150;
            this.Karma = 0;

            this.VirtualArmor = 2;

            this.Tamable = true;
            this.ControlSlots = 1;
            this.MinTameSkill = 0.0;
        }

        public MisterGobbles(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 2;
            }
        }
        public override MeatType MeatType
        {
            get
            {
                return MeatType.Bird;
            }
        }
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.GrainsAndHay;
            }
        }
        public override bool CanFly
        {
            get
            {
                return true;
            }
        }
        public override int Feathers
        {
            get
            {
                return 75;
            }
        }
        public override int GetAngerSound()
        {
            return 1643;
        }

        public override int GetIdleSound()
        {
            return 1642;
        }

        public override int GetAttackSound()
        {
            return 1643;
        }

        public override int GetHurtSound()
        {
            return 1643;
        }

        public override int GetDeathSound()
        {
            return 0x072;
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
        } */
    
}