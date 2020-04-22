using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "the corpse of pigmy" )]
	public class PigmyHunter : BaseCreature
	{
		[Constructable]
		public PigmyHunter () : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.05, 0.05 )
		{
			Name = "a Pigmy Hunter";
			Body = 776;
			Hue = Utility.RandomList( 44, 1102, 1109, 1111, 1141, 1148, 1153, 2213 );

			SetStr( 3123, 6246 );
			SetDex( 336, 659 );
			SetInt( 135, 358 );

			SetHits( 12324, 24634 );

			SetDamage( 16, 99 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45 );
			SetResistance( ResistanceType.Fire, 10 );
			SetResistance( ResistanceType.Cold, 10 );
			SetResistance( ResistanceType.Poison, 70 );
			SetResistance( ResistanceType.Energy, 30 );

			SetSkill( SkillName.MagicResist, 31.2, 134.8 );
			SetSkill( SkillName.Tactics, 241.9, 450.2 );
			SetSkill( SkillName.Wrestling, 250.4, 656.7 );
			SetSkill( SkillName.Healing, 200.1, 400.1 );
			SetSkill( SkillName.DetectHidden, 200.1, 400.1 );
			SetSkill( SkillName.Poisoning, 200.1, 400.1 );
			SetSkill( SkillName.Tracking, 200.1, 400.1 );
			SetSkill( SkillName.Hiding, 200.1, 400.1 );
			SetSkill( SkillName.Stealth, 200.1, 400.1 );

			Fame = 4311;
			Karma = -4311;

			VirtualArmor = 65;

			Tamable = false;
			



			PackItem( new Bandage( 60 ) );
			PackItem( new Boomerang() );
			PackItem( new Gold( 525 ) );

			
		}

		public override void OnGaveMeleeAttack(Mobile defender) 
        {
            base.OnGaveMeleeAttack(defender);

            if (0.1 > Utility.RandomDouble())
            {
                /* Maniacal laugh
                * Cliloc: 1070840
                * Effect: Type: "3" From: "0x57D4F5B" To: "0x0" ItemId: "0x37B9" ItemIdName: "glow" FromLocation: "(884 715, 10)" ToLocation: "(884 715, 10)" Speed: "10" Duration: "5" FixedDirection: "True" Explode: "False"
                * Paralyzes for 4 seconds, or until hit
                */
                defender.FixedEffect(0x8FF, 10, 5);
                defender.SendLocalizedMessage(1070840); // You are frozen as the creature laughs maniacally.

                defender.Paralyze(TimeSpan.FromSeconds(4.0));
            }
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

		public PigmyHunter( Serial serial ) : base( serial )
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