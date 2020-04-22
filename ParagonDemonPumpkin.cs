using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Network;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a killer pumpkin corpse" )]
	public class ParagonDemonPumpkin : BaseCreature
	{
		public override bool IsScaredOfScaryThings{ get{ return false; } }
		public override bool IsScaryToPets{ get{ return true; } }

		[Constructable]
		public ParagonDemonPumpkin () : base( AIType.AI_NecroMage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
            this.Name = "Demon Pumpkin";
            this.Body = 1246;

            this.BaseSoundID = 357;

            this.SetStr(412, 512);
            this.SetDex(96, 115);
            this.SetInt(966, 1045);

            this.SetHits(666, 777);

            this.SetDamage(20, 27);

            this.SetDamageType(ResistanceType.Physical, 0);
            this.SetDamageType(ResistanceType.Cold, 100);

            this.SetResistance(ResistanceType.Physical, 70, 85);
            this.SetResistance(ResistanceType.Fire, 40, 55);
            this.SetResistance(ResistanceType.Cold, 90, 100);
            this.SetResistance(ResistanceType.Poison, 65, 70);
            this.SetResistance(ResistanceType.Energy, 50, 65);

            this.SetSkill(SkillName.MagicResist, 175.2, 200.0);
            this.SetSkill(SkillName.Tactics, 90.1, 100.0);
            this.SetSkill(SkillName.Wrestling, 75.1, 100.0);
            this.SetSkill(SkillName.EvalInt, 120.1, 130.0);
            this.SetSkill(SkillName.Magery, 120.1, 130.0);
            this.SetSkill(SkillName.Meditation, 100.1, 101.0);
            this.SetSkill(SkillName.Necromancy, 100.1, 110.0);
            this.SetSkill(SkillName.SpiritSpeak, 100.1, 110.0);

            this.Fame = 23000;
            this.Karma = -23000;
            this.Tamable = false;
            this.IsParagon = true;

            this.PackNecroReg(30, 40);
            this.AddItem(new LightSource());

			this.PackItem( new Bone( 3 ) );

			if ( Paragon.ChestChance > Utility.RandomDouble() )
				this.PackItem( new ParagonChest( Name, TreasureMapLevel ) );
		}

        public override void GenerateLoot()
		{
            this.AddLoot(LootPack.FilthyRich, 3);
            this.AddLoot(LootPack.MedScrolls, 2);
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			if ( Utility.RandomDouble() < 0.25 )
			{
				switch ( Utility.Random( 3 ) )
				{
					case 0: c.DropItem( new RunicDeed() );	break;//1
					case 1: c.DropItem( new AutoResPotion() ); break;//1
					case 2: c.DropItem( new EtherealTiger() ); break;//2
				}
			}
		}

        public override bool BardImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override bool BleedImmune { get { return true; } }
		public override int TreasureMapLevel { get { return 5; } }

		public ParagonDemonPumpkin( Serial serial ) : base( serial )
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
