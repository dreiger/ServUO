using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "the smoking corpse of a fire farter" )]
	public class FireFarter : BaseCreature
	{
		[Constructable]
		public FireFarter () : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.05, 0.05 )
		{
			Name = "a fire farter";
			Body = 205;
			Hue = Utility.RandomList( 44, 1102, 1109, 1111, 1141, 1148, 1153, 2213 );

			SetStr( 423, 746 );
			SetDex( 236, 459 );
			SetInt( 125, 348 );

			SetHits( 123, 246 );

			SetDamage( 16, 95 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 25 );
			SetResistance( ResistanceType.Fire, 50 );
			SetResistance( ResistanceType.Cold, 50 );
			SetResistance( ResistanceType.Poison, 50 );
			SetResistance( ResistanceType.Energy, 10 );

			SetSkill( SkillName.MagicResist, 71.2, 134.8 );
			SetSkill( SkillName.Tactics, 141.9, 250.2 );
			SetSkill( SkillName.Wrestling, 150.4, 356.7 );

			Fame = 4311;
			Karma = -4311;

			VirtualArmor = 65;

			

			
			PackItem( new FireFart() );
			PackItem( new FireFart() );
			PackItem( new FireFart() );
			PackItem( new FireFart() );
			PackItem( new FireFart() );
			PackItem( new FireFart() );

			PackItem( new BreadLoaf( 6 ) );
			PackItem( new CheeseWheel() );
			PackItem( new ChainCoif() );
		}

		public override bool HasBreath{ get{ return true; } } // fire breath enabled

		public virtual int BreathPhysicalDamage{ get{ return 100; } }
		public virtual int BreathFireDamage{ get{ return 0; } }
		public virtual int BreathColdDamage{ get{ return 0; } }
		public virtual int BreathPoisonDamage{ get{ return 0; } }
		public virtual int BreathEnergyDamage{ get{ return 0; } }

		public override int BreathEffectItemID{ get{ return 0xF62; } }
		public override int BreathEffectSound{ get{ return 792; } }
		public override int BreathAngerSound{ get{ return 809; } }

		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 1; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies; } }

		public FireFarter( Serial serial ) : base( serial )
		{
		}

		public override int GetIdleSound() { return 819; } 
		public override int GetAttackSound() { return 800; } 
		public override int GetHurtSound()  { return 787; } 
		public override int GetAngerSound() { return 783; } 
		public override int GetDeathSound()	{ return 1364; } 

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