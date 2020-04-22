using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a blue dragon corpse" )]
	public class ParagonBlueDragon : BaseCreature
	{
		[Constructable]
		public ParagonBlueDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a paragon blue dragon";
			Body = Utility.RandomList( 12, 59 );
			BaseSoundID = 362;
      Hue = 5;
      IsParagon = true;

			SetStr( 676, 700 );
			SetDex( 96, 100 );
			SetInt( 576, 595 );

			SetHits( 650, 750 );

			SetDamage( 10, 17 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 0, 05 );
			SetResistance( ResistanceType.Cold, 90, 100 );
			SetResistance( ResistanceType.Poison, 45, 55 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.EvalInt, 70.1, 80.0 );
			SetSkill( SkillName.Magery, 80.1, 90.0 );
			SetSkill( SkillName.MagicResist, 100.1, 105.0 );
			SetSkill( SkillName.Tactics, 82.6, 90.0 );
			SetSkill( SkillName.Wrestling, 80.1, 90.5 );

			Fame = 15500;
			Karma = -15500;

			VirtualArmor = 65;

			Tamable = true;
			ControlSlots = 4;
			MinTameSkill = 99.9;

                        PackItem( Loot.RandomArmor() );
                        if ( 0.01 > Utility.RandomDouble() )
				PackItem( new BlueDragonGloves() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.007 > Utility.RandomDouble() )
				PackItem( new BlueDragonChest() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.01 > Utility.RandomDouble() )
				PackItem( new BlueDragonArms() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.01 > Utility.RandomDouble() )
				PackItem( new BlueDragonLegs() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.009 > Utility.RandomDouble() )
				PackItem( new DragonHelm() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 3 );
			AddLoot( LootPack.Gems, 10 );
		}

		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 19; } }
		public override int Hides{ get{ return 5; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override int Scales{ get{ return 4; } }
		public override ScaleType ScaleType{ get{ return ( Body == 12 ? ScaleType.Yellow : ScaleType.Red ); } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override bool CanAngerOnTame { get { return true; } }

		public ParagonBlueDragon( Serial serial ) : base( serial )
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