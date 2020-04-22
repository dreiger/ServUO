using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Nox Avenger corpse" )]
	public class NoxAvenger : BaseCreature
	{
		[Constructable]
		public NoxAvenger() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Nox Avenger";
			Body = 152;
			BaseSoundID = 0x24D;
            Hue = 0x300;

			SetStr( 467, 645 );
			SetDex( 77, 95 );
			SetInt( 126, 150 );

			SetHits( 396, 472 );
			SetMana( 120, 170 );

			SetDamage( 30, 40 );

			SetDamageType( ResistanceType.Physical, 60 );
			SetDamageType( ResistanceType.Poison, 100 );

			SetResistance( ResistanceType.Physical, 60, 70 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 55, 65 );
			SetResistance( ResistanceType.Poison, 100, 100 );
			SetResistance( ResistanceType.Energy, 70, 75 );

			SetSkill( SkillName.EvalInt, 100.0, 100.0 );
			SetSkill( SkillName.Magery, 100.0, 100.0 );
			SetSkill( SkillName.Poisoning, 100.0, 100.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 99.1, 100.0 );
			SetSkill( SkillName.Wrestling, 99.1, 100.0 );

			Fame = 15000;
			Karma = -15000;

            VirtualArmor = 60;


            PackItem(new Bandage(Utility.RandomMinMax(1, 15)));

            if (0.01 > Utility.RandomDouble())
                PackItem(new NameChangeDeed());       // Random Drop

        }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich, 1 );
            AddItem(new BagOfAllReagents());
            AddItem(new NoxCrystal());
       
        }

		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
        public override Poison HitPoison { get { return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 5; } }
        public override double HitPoisonChance { get { return 0.9; } }
        public override int Meat{ get{ return 2; } }

        public override OppositionGroup OppositionGroup
        {
            get { return OppositionGroup.TerathansAndOphidians; }
        }


		public NoxAvenger( Serial serial ) : base( serial )
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

			if ( BaseSoundID == 263 )
				BaseSoundID = 0x24D;
        }
	}
}
