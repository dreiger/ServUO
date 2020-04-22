using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	public class ButtPirate : BaseCreature
	{
		public override bool ClickTitle{ get{ return false; } }

		[Constructable]
		public ButtPirate() : base( AIType.AI_Archer, FightMode.Closest, 15, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Hue = Utility.RandomSkinHue();

			if ( this.Female = Utility.RandomBool() )
			{
			   	Title = "the Carpet Muncher";
				Body = 0x191;
				Name = NameList.RandomName( "female" );
				AddItem( new ThighBoots());
			}
			else
			{
				Title = "the Butt Pirate";		
				Body = 0x190;
				Name = NameList.RandomName( "male" );
				AddItem( new ThighBoots());
			}

			SetStr( 195, 200 );
			SetDex( 181, 195 );
			SetInt( 61, 75 );
			SetHits( 1288, 2308 );

			SetDamage( 20, 40 );

			SetSkill( SkillName.Fencing, 86.0, 197.5 );
			SetSkill( SkillName.Macing, 85.0, 187.5 );
			SetSkill( SkillName.MagicResist, 55.0, 167.5 );
			SetSkill( SkillName.Swords, 85.0, 187.5 );
			SetSkill( SkillName.Tactics, 85.0, 187.5 );
			SetSkill( SkillName.Wrestling, 35.0, 137.5 );
			SetSkill( SkillName.Archery, 85.0, 187.5 );

			Fame = 2000;
			Karma = -2000;
			VirtualArmor = 76;
			
			switch ( Utility.Random( 1 ))
			{
				case 0: AddItem( new LongPants ( Utility.RandomRedHue() ) ); break;
				case 1: AddItem( new AsslessChaps( Utility.RandomRedHue() ) ); break;
			}				
			
			switch ( Utility.Random( 3 ))
			{
				case 0: AddItem( new BondageShirt( Utility.RandomRedHue() ) ); break;
				case 1: AddItem( new Shirt( Utility.RandomRedHue() ) ); break;
				case 2: AddItem( new Doublet( Utility.RandomRedHue() ) ); break;
			}					
			

			switch ( Utility.Random( 4 ))
			{
				case 0: AddItem( new Bandana( Utility.RandomRedHue() ) ); break;
				case 1: AddItem( new GypsyHeaddress( Utility.RandomRedHue() ) ); break;
				case 2: AddItem( new FlowerGarland( Utility.RandomRedHue() ) ); break;
			}			

			switch ( Utility.Random( 5 ))
			{
				case 0: AddItem( new Kryss() ); break;
				case 1: AddItem( new Katana() ); break;
				case 2: AddItem( new Dagger() ); break;
				case 3: AddItem( new Scimitar() ); break;
				case 4: AddItem( new VikingSword() ); break;
			}		

			Item hair = new Item( Utility.RandomList( 0x203B, 0x2049, 0x2048, 0x204A ) );
			hair.Hue = Utility.RandomNondyedHue();
			hair.Layer = Layer.Hair;
			hair.Movable = false;
			AddItem( hair );
		}


		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }


        public ButtPirate(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
