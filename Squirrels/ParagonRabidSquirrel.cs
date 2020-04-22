using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a dead tree rat" )]
	public class ParagonRabidSquirrel : BaseCreature
	{
		[Constructable]
		public ParagonRabidSquirrel () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			this.Name = "a paragon rabid squirrel";
			this.Body = 0x116;
			this.Hue = 1400;
			this.IsParagon = true;

			SetStr( 225, 275 );
			SetDex( 180, 395 );
			SetInt( 250, 275 );

			SetHits( 64400, 75475 );

			SetDamage( 8, 11 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 70 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 90, 95 );
			SetResistance( ResistanceType.Energy, 70 );

			SetSkill( SkillName.EvalInt, 130.1, 335.0 );
			SetSkill( SkillName.Magery, 160.1, 370.0 );
			SetSkill( SkillName.MagicResist, 165.1, 370.0 );
			SetSkill( SkillName.Tactics, 60.6, 165.0 );
			SetSkill( SkillName.Wrestling, 100.0, 105.0 );

			Fame = 1555;
			Karma = -1555;

			VirtualArmor = 80;

			Tamable = false;


                        PackItem( Loot.RandomArmor() );
                        if ( 0.02 > Utility.RandomDouble() )
													PackItem( new FemaleGodChest() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.01 > Utility.RandomDouble() )
													PackItem( new GodArms() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.03 > Utility.RandomDouble() )
													PackItem( new GodChest() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.04 > Utility.RandomDouble() )
													PackItem( new GodGloves() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.05 > Utility.RandomDouble() )
													PackItem( new GodHelm() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.06 > Utility.RandomDouble() )
													PackItem( new GodLegs() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.07 > Utility.RandomDouble() )
													PackItem( new GodNeck() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.08 > Utility.RandomDouble() )
													PackItem( new GodShield() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.09 > Utility.RandomDouble() )
													PackItem( new DeezNuts() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.010 > Utility.RandomDouble() )
													PackItem( new AutoResStone() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.011 > Utility.RandomDouble() )
													PackItem( new BlessBag() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.012 > Utility.RandomDouble() )
													PackItem( new BongScraper() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.013 > Utility.RandomDouble() )
													PackItem( new LawnGnomeSlayer() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.014 > Utility.RandomDouble() )
													PackItem( new Peckerwood() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.015 > Utility.RandomDouble() )
													PackItem( new PeePeeWhacker() );

												PackItem( Loot.RandomArmor() );
                        if ( 0.016> Utility.RandomDouble() )
													PackItem( new PigSticker() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 2 );
		}

		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return false; } } // fire breath enabled
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 19; } }
		public override int Hides{ get{ return 3; } }
		public override HideType HideType{ get{ return HideType.Horned; } }
		public override int Scales{ get{ return 2; } }
		public override ScaleType ScaleType{ get{ return ( Body == 12 ? ScaleType.Yellow : ScaleType.Red ); } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override bool CanAngerOnTame { get { return true; } }

		public ParagonRabidSquirrel( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
