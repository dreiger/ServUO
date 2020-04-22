using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a blue dragon corpse" )]
	public class ParagonBlackDragon : BaseCreature
	{
		[Constructable]
		public ParagonBlackDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Paragon Black Dragon";
			Body = Utility.RandomList( 12, 59 );
			BaseSoundID = 362;
      Hue = 9999;
      IsParagon = true;

			SetStr( 800, 900 );
			SetDex( 126, 140 );
			SetInt( 776, 895 );

			SetHits( 850, 900 );

			SetDamage( 14, 21 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 55, 60 );
			SetResistance( ResistanceType.Fire, 40, 50 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 55, 65 );
			SetResistance( ResistanceType.Energy, 25, 30 );

			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 100.1, 105.0 );
			SetSkill( SkillName.MagicResist, 110.1, 115.0 );
			SetSkill( SkillName.Tactics, 100.0, 105.0 );
			SetSkill( SkillName.Wrestling, 100.1, 105.5 );

			Fame = 19900;
			Karma = -19900;

			VirtualArmor = 70;

			Tamable = true;
			ControlSlots = 5;
			MinTameSkill = 110.0;

                        PackItem( Loot.RandomArmor() );
                        if ( 0.001 > Utility.RandomDouble() )
				PackItem( new BlackDragonGloves() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.005 > Utility.RandomDouble() )
				PackItem( new BlackDragonChest() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.005 > Utility.RandomDouble() )
				PackItem( new BlackDragonArms() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.005 > Utility.RandomDouble() )
				PackItem( new BlackDragonLegs() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.005 > Utility.RandomDouble() )
				PackItem( new BlackDragonHelm() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.SuperBoss, 1 );
			AddLoot( LootPack.Gems, 10 );
		}

		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 19; } }
		public override int Hides{ get{ return 20; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override int Scales{ get{ return 7; } }
		public override ScaleType ScaleType{ get{ return ( Body == 12 ? ScaleType.Yellow : ScaleType.Red ); } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override bool CanAngerOnTame { get { return true; } }

		public ParagonBlackDragon( Serial serial ) : base( serial )
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