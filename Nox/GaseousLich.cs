// this is some script I cobbled together from Mo Khan's Nox Drone & Rockstar's Talking Dragon
// Thanks Guy's
// Hart
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Server.ContextMenus;
using Server.Misc;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;


namespace Server.Mobiles
{
    [CorpseName("a Gaseous Lich's corpse")]
	public class GaseousLich : BaseCreature
	{
        private static bool m_Talked;
        string[] GaseousLichSay = new string[]
		{
	        "Better out than in I alway's say.",
		    "A cold beer and a plate full of bean's, there ain't nothin better",
            "Going to watch the CTF tonight on my new big screen casket",
            "Got any tums? I have a belly ache.",
            "Whew that one made my eye's water.",
            "You look like you could use a hug.",
            "LOL you should see the streak in my short's.",
            "What ? Did I say something wrong ?",
		};
        [Constructable]
		public GaseousLich() : base( AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
                        Name = "a Gaseous Lich";
			Body = 79;
                        Hue = 373;
			BaseSoundID = 0x3E9;

			SetStr( 416, 505 );
			SetDex( 146, 165 );
			SetInt( 566, 655 );

			SetHits( 350, 403 );

			SetDamage( 15, 19 );

			SetDamageType( ResistanceType.Physical, 0 );
			SetDamageType( ResistanceType.Cold, 60 );
			SetDamageType( ResistanceType.Energy, 40 );

			SetResistance( ResistanceType.Physical, 40, 50 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 50, 60 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.EvalInt, 120.1, 130.0 );
			SetSkill( SkillName.Magery, 120.1, 130.0 );
			SetSkill( SkillName.MagicResist, 150.5, 200.0 );
			SetSkill( SkillName.Tactics, 50.1, 70.0 );
			SetSkill( SkillName.Wrestling, 60.1, 80.0 );

			Fame = 18000;
			Karma = 18000;

			VirtualArmor = 75;
			PackItem( new GnarledStaff() );
			PackNecroReg( 12, 40 );
			if( Utility.RandomDouble() <= 0.05 ) PackItem( new Spam() );
		}
        public override void OnMovement(Mobile m, Point3D oldLocation)
        {
            ArrayList list = new ArrayList();

            foreach (Mobile n in this.GetMobilesInRange(15))
            {
                if (n.Player)
                    list.Add(n);
            }
            if (m_Talked == false)
            {
                if (m.InRange(this, 15) && m is PlayerMobile)
                {
                    m_Talked = true;
                    SayRandom(GaseousLichSay, this);
                    foreach (Mobile n in list)
                    {
                        n.FixedParticles(0x36CB, 1, 9, 9911, 67, 5, EffectLayer.Head);
                        n.FixedParticles(0x374A, 1, 17, 9502, 1108, 4, (EffectLayer)255);

                        n.SendMessage("Your lung's and eye's sting as you breath the noxious fumes!");

                        int toStrike = Utility.RandomMinMax(2, 5);
                        Hits += toStrike;
                        n.Damage(toStrike, this);

                        this.Move(GetDirectionTo(m.Location));
                        SpamTimer t = new SpamTimer();
                        t.Start();
                    }
                }
            }
        }
        private class SpamTimer : Timer
        {
            public SpamTimer()
                : base(TimeSpan.FromSeconds(12))
            {
                Priority = TimerPriority.OneSecond;
            }

            protected override void OnTick()
            {
                m_Talked = false;
            }
        }

        private static void SayRandom(string[] say, Mobile m)
        {
            m.PlaySound(1064);
            m.Say(say[Utility.Random(say.Length)]);
        }


		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
        }

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 4; } }

		public GaseousLich( Serial serial ) : base( serial )
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