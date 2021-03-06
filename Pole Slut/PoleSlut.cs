using System;
using Server;
using Server.Items;
				
namespace Server.Mobiles
{
	[CorpseName( "Corpse Of Jezzebel" )]
	public class PoleSlut : BaseCreature
	{
		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public PoleSlut() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Pole Slut";
			Body = 0x191;
			Hue = 1000;
				 
			SetStr( 426, 2531 );
			SetDex( 200, 1300 );
			SetInt( 200, 2250 );
				 
			SetHits( 2000, 23235 );
				 
			SetDamage( 20, 123 );
				 
			SetDamageType( ResistanceType.Physical, 67 );
			SetDamageType( ResistanceType.Cold, 20 );
			SetDamageType( ResistanceType.Fire, 60 );
				 
			SetResistance( ResistanceType.Physical, 35, 50 );
			SetResistance( ResistanceType.Energy, 35, 50 );
			SetResistance( ResistanceType.Poison, 35, 50 );
			SetResistance( ResistanceType.Cold, 35, 50 );
			SetResistance( ResistanceType.Fire, 35, 50 );
				 
			SetSkill( SkillName.Wrestling, 95.1, 100.0 );
			SetSkill( SkillName.Anatomy, 95.1, 100.0 );
			SetSkill( SkillName.MagicResist, 95.1, 100.0 );
			SetSkill( SkillName.Swords, 95.1, 100.0 );
			SetSkill( SkillName.Tactics, 95.1, 100.0 );
			SetSkill( SkillName.Parry, 95.1, 100.0 );
			SetSkill( SkillName.Focus, 95.1, 100.0 );
				 
			Fame = 25000;
			Karma = -25000;
				 
			VirtualArmor = 40;

			PackGold( 800, 850 );

	/*		Bandana hat = new Bandana();
			hat.Name = "PoleSlut Head Gear";
			hat.Hue = 2993;
			hat.Movable = false;
			AddItem( hat );

	//		LeatherBustierArms chest = new LeatherBustierArms();
	//		chest.Name = "PoleSlut Guard";
	//		chest.Hue = 2993;
	//		chest.Movable = false;
	//		AddItem( chest );

	//		LeatherGorget gorget = new LeatherGorget();
	//		gorget.Name = "PoleSlut Collar";
	//		gorget.Hue = 2993;
	//		gorget.Movable = false;
	//		AddItem( gorget );

			LeatherGloves gloves = new LeatherGloves();
			gloves.Name = "Pole Slut Gloves";
			gloves.Hue = 2993;
			gloves.Movable = false;
			AddItem( gloves );

			LeatherSkirt skirt = new LeatherSkirt();
			skirt.Name = "Pole Slut Skirt";
			skirt.Hue = 2993;
			skirt.Movable = false;
			AddItem( skirt );

			NightsKiss weapon = new NightsKiss();
			weapon.Movable = false;
			AddItem( weapon ); */

			Sandals sandals = new Sandals();
			sandals.Name = "Fuck Me Pumps";
			sandals.Hue = 2993;
			sandals.Movable = false;
			AddItem( sandals );

	//		LanternOfSlavery shield = new LanternOfSlavery();
	//		shield.Movable = false;
	//		AddItem( shield );

			Item hair = new Item( Utility.RandomList( 8265 ) );
			hair.Hue = 1153;
			hair.Layer = Layer.Hair;
			hair.Movable = false;
			AddItem( hair );
				
		/*	switch ( Utility.Random( 90 ) )
			{
				case 0: PackItem( new PoleSlutCollar() ); break;
				case 1: PackItem( new PoleSlutGloves() ); break;
				case 2: PackItem( new PoleSlutGuard() ); break;
				case 3: PackItem( new PoleSlutSkirt() ); break;
				case 4: PackItem( new NightsKiss() ); break;
				case 5: PackItem( new PoleSlutProtection() ); break;
				case 6: PackItem( new PoleSlutHeadGear() ); break;
				case 7: PackItem( new LanternOfSlavery() ); break;
			} */
		}
			
		public override bool AlwaysAttackable{ get{ return true; } }
 
		public override void GenerateLoot()
		{
			 AddLoot( LootPack.Rich, 2 );
		}
			
		public PoleSlut( Serial serial ) : base( serial )
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
