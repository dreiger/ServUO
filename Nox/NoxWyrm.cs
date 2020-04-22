using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Nox wyrm corpse" )]
	public class NoxWyrm : BaseCreature
	{
		[Constructable]
		public NoxWyrm () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Body = Core.AOS ? 180 : 49;
			Name = "a Nox wyrm";
			BaseSoundID = 362;
                        Hue = 358;

			SetStr( 721, 760 );
			SetDex( 250, 270 );
			SetInt( 586, 625 );

			SetHits( 833, 956 );

			SetDamage( 22, 30 );

			SetDamageType( ResistanceType.Physical, 60 );
			SetDamageType( ResistanceType.Poison, 95 );

			SetResistance( ResistanceType.Physical, 55, 60 );
			SetResistance( ResistanceType.Fire, 45, 55 );
			SetResistance( ResistanceType.Cold, 40, 50 );
			SetResistance( ResistanceType.Poison, 95, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.EvalInt, 99.1, 100.0 );
			SetSkill( SkillName.Magery, 99.1, 100.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 18000;
			Karma = -18000;

			VirtualArmor = 80;

			Tamable = true;
			ControlSlots = 4;
			MinTameSkill = 99.9;

			if( Utility.RandomDouble() <= 0.50 ) PackItem( new Spam() );
			if( Utility.RandomDouble() <= 0.20 ) PackItem( new SpecialHairDye() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 1 );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Gems, Utility.Random( 1, 5 ) );
		}

        public override Poison PoisonImmune { get { return Poison.Deadly; } }
        public override Poison HitPoison { get { return Poison.Lethal; } }
        public override bool ReacquireOnMovement { get { return true; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 19; } }
		public override int Hides{ get{ return 20; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override int Scales{ get{ return 15; } }
		public override ScaleType ScaleType{ get{ return ScaleType.Green; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat | FoodType.Gold; } }
		public override bool CanAngerOnTame { get { return true; } }

		public NoxWyrm( Serial serial ) : base( serial )
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

			if ( Core.AOS && Body == 49 )
				Body = 180;
		}
	}
}