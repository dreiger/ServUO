using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a green dragon corpse" )]
	public class ParagonGreenDragon : BaseCreature
	{
		[Constructable]
		public ParagonGreenDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a paragon green dragon";
			Body = Utility.RandomList( 12, 59 );
			BaseSoundID = 362;
      Hue = 163;
      IsParagon = true;

			SetStr( 225, 275 );
			SetDex( 80, 95 );
			SetInt( 250, 275 );

			SetHits( 400, 475 );

			SetDamage( 8, 11 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 90, 95 );
			SetResistance( ResistanceType.Energy, 20, 30 );

			SetSkill( SkillName.EvalInt, 30.1, 35.0 );
			SetSkill( SkillName.Magery, 60.1, 70.0 );
			SetSkill( SkillName.MagicResist, 65.1, 70.0 );
			SetSkill( SkillName.Tactics, 60.6, 65.0 );
			SetSkill( SkillName.Wrestling, 100.0, 105.0 );

			Fame = 1555;
			Karma = -1555;

			VirtualArmor = 60;

			Tamable = true;
			ControlSlots = 2;
			MinTameSkill = 80.0;

                        PackItem( Loot.RandomArmor() );
                        if ( 0.02 > Utility.RandomDouble() )
				PackItem( new GreenDragonGloves() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.01 > Utility.RandomDouble() )
				PackItem( new GreenDragonChest() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.02 > Utility.RandomDouble() )
				PackItem( new GreenDragonArms() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.02 > Utility.RandomDouble() )
				PackItem( new GreenDragonLegs() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.009 > Utility.RandomDouble() )
				PackItem( new GreenDragonHelm() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 1 );
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

		public ParagonGreenDragon( Serial serial ) : base( serial )
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