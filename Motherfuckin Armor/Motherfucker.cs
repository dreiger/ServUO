//Scripted By James4245
using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Targeting;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
    [CorpseName("corpse of The Motherfucker")]
   	public class Motherfucker : BaseCreature
   	{
	  	private static bool m_Talked;

      		string[] kfcsay = new string[]
      		{
			"I saw ur mom on the internet!",
			"Deez nuts!",
			"That's what she said!",
			"You like tapes and cds?  Cause I'm gonna tape this dick to your forhead so you can see deez nuts!",
			"You like dragons?  Cause I'm gonna be draggin deez nuts across your face!",
			"STFU, nobody gives a shit what you think noob.",
			"Clinton is honest, and Trump is right!",
			"You'd look so much better face down, ass up.",

      		};

      		[Constructable]
	  	public Motherfucker() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.15, 0.4 )
      		{
 			    Body = 0x190;
                Name = "The Motherfucker";
                Title = "Always Here To Piss You Off";

                SetStr( 1800, 1900 );
                SetDex( 1510, 1750 );
                SetInt( 1710, 2200 );

                SetHits( 8000, 10000 );

                SetDamage( 34, 136 );

                SetDamageType( ResistanceType.Physical, 50 );
                SetDamageType( ResistanceType.Cold, 50 );

                SetResistance( ResistanceType.Physical, 45 );
                SetResistance( ResistanceType.Fire, 65 );
                SetResistance( ResistanceType.Cold, 35 );
                SetResistance( ResistanceType.Poison, 25 );
                SetResistance( ResistanceType.Energy, 35 );

                SetSkill( SkillName.EvalInt, 670.0 );
                SetSkill( SkillName.Magery, 670.0 );
                SetSkill( SkillName.Meditation, 670.0 );
                SetSkill( SkillName.MagicResist, 630.0 );
                SetSkill( SkillName.Tactics, 620.0 );
                SetSkill( SkillName.Wrestling, 620.0 );
                SetSkill( SkillName.Swords, 475.0, 1300.0 );
                SetSkill( SkillName.Parry, 475.0, 1300.0 );


         		Fame = 10000;
		 	    Karma = -10000;

                Item stick = new BitchStick();
         		stick.LootType = LootType.Blessed;
         		stick.Movable = false;
         		AddItem(stick);



                Item legs = new MotherfuckinLegs();
         		legs.LootType = LootType.Blessed;
         		legs.Movable = false;
         		AddItem(legs);

                Item gloves = new MotherfuckinHands();
         		gloves.LootType = LootType.Blessed;
         		gloves.Movable = false;
         		AddItem(gloves);

         			Item neck = new MotherfuckinNeck();
         			neck.LootType = LootType.Blessed;
    					neck.Movable = false;
         			AddItem(neck);

    //            Item helm = new CapOfHorus();
    //     		helm.LootType = LootType.Blessed;
    //     		AddItem(helm);

                Item chest = new MotherfuckinChest();
         		chest.LootType = LootType.Blessed;
         		chest.Movable = false;
         		AddItem(chest);

			    PackGold( 100, 200);

         		switch ( Utility.Random( 10 ) ) //Minor Artifacts
			{
                case 0: PackItem( new DeezNuts()); break;
                case 1: PackItem( new MotherfuckinArms()); break;
                case 2: PackItem( new MotherfuckinChest()); break;
                case 3: PackItem( new MotherfuckinHands()); break;
                case 4: PackItem( new MotherfuckinLegs()); break;
                case 5: PackItem( new MotherfuckinNeck()); break;
                case 6: PackItem( new MotherfuckinTits()); break;
                case 7: PackItem( new Spam()); break;

		    	}
          	}
            //public override bool ShowFameTitle { get { return false; } }
       		public override bool AutoDispel { get { return true; } }
       		public override bool BardImmune { get { return true; } }
       		public override bool Unprovokable { get { return true; } }
       		public override bool Uncalmable { get { return true; } }
       		public override bool AlwaysMurderer { get { return true; } }

	  	public override void OnMovement( Mobile m, Point3D oldLocation )
               	{
		 	if( m_Talked == false )
         		{
            			if ( m.InRange( this, 4 ) )
            			{
               				m_Talked = true;
               				SayRandom( kfcsay, this );
               				this.Move( GetDirectionTo( m.Location ) );
               				SpamTimer t = new SpamTimer();
               				t.Start();
            			}
		 	}
	  	}

        public Motherfucker(Serial serial) : base(serial)
		{
		}

      		private class SpamTimer : Timer
      		{
         		public SpamTimer() : base( TimeSpan.FromSeconds( 8 ) )
         		{
				Priority = TimerPriority.OneSecond;
         		}

         		protected override void OnTick()
         		{
            			m_Talked = false;
         		}
	  	}

	  	private static void SayRandom( string[] say, Mobile m )
	  	{
		 	m.Say( say[Utility.Random( say.Length )] );
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
