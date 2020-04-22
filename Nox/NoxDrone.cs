using System;
using Server.Items;
using Server.Targeting;
using System.Collections;

namespace Server.Mobiles
{
	[CorpseName( "a Nox drone corpse" )]
	public class NoxDrone : BaseCreature
	{
		[Constructable]
		public NoxDrone() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Nox drone";
			Body = 71;
			BaseSoundID = 594;
            Hue = 0x300;

			SetStr( 65, 95 );
			SetDex( 96, 145 );
			SetInt( 21, 45 );

			SetHits( 70, 100 );
			SetMana( 0 );

			SetDamage( 15, 30 );

			SetDamageType( ResistanceType.Physical, 100 );
            SetDamageType(ResistanceType.Poison, 100);

			SetResistance( ResistanceType.Physical, 20, 25 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 100, 100 );
			SetResistance( ResistanceType.Energy, 15, 25 );

			SetSkill( SkillName.Poisoning, 100.0, 100.0 );
			SetSkill( SkillName.MagicResist, 70.1, 85.0 );
			SetSkill( SkillName.Tactics, 80.1, 90.0 );
			SetSkill( SkillName.Wrestling, 80.1, 90.0 );

			Fame = 2000;
			Karma = -2000;

			VirtualArmor = 40;
			
			PackItem( new SpidersSilk( 5 ) );

            if (0.01 > Utility.RandomDouble())
                PackItem(new Basket());       // Random Drop

        }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average, 1 );
            AddItem(new BolaBall());
            AddItem(new NoxCrystal());
       
        }

        
        public override Poison HitPoison { get { return Poison.Lethal; } }

		public override int Meat{ get{ return 4; } }

        public override OppositionGroup OppositionGroup
        {
            get { return OppositionGroup.TerathansAndOphidians; }
        }


		public NoxDrone( Serial serial ) : base( serial )
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

			if ( BaseSoundID == 589 )
				BaseSoundID = 594;
		}
	}
}