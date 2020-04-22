using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Nox matriarch corpse" )]
	public class NoxMatriarch : BaseCreature
	{
		[Constructable]
		public NoxMatriarch() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Nox matriarch";
			Body = 72;
			BaseSoundID = 599;
                        Hue = 0x300;

			SetStr( 316, 405 );
			SetDex( 96, 115 );
			SetInt( 366, 455 );

			SetHits( 190, 243 );

			SetDamage( 11, 14 );

			SetDamageType( ResistanceType.Physical, 100 );
            SetDamageType(ResistanceType.Poison, 100);

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 35, 45 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Energy, 35, 45 );

			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 90.1, 100.0 );
			SetSkill( SkillName.MagicResist, 90.1, 100.0 );
			SetSkill( SkillName.Tactics, 50.1, 70.0 );
			SetSkill( SkillName.Wrestling, 60.1, 80.0 );

			Fame = 10000;
			Karma = -10000;

			VirtualArmor = 60;

			PackItem( new SpidersSilk( 5 ) );
			PackNecroReg( Utility.RandomMinMax( 4, 10 ) );
			if( Utility.RandomDouble() <= 0.01 ) PackItem( new JadeStatueMaker() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich, 1 );
			AddLoot( LootPack.Average, 1 );
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Potions );
		}

		public override int TreasureMapLevel{ get{ return 4; } }
        public override Poison HitPoison { get { return Poison.Lethal; } }

        public override OppositionGroup OppositionGroup
        {
            get { return OppositionGroup.TerathansAndOphidians; }
        }


		public NoxMatriarch( Serial serial ) : base( serial )
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