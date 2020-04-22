using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a dead myth")]
    [TypeAlias("Server.Mobiles.Seaserpant")]
    public class Nessie : BaseCreature
    {
        [Constructable]
        public Nessie()
            : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.15, 0.4 )
        {
            this.Name = "Nessie - The Loch Ness Monster";
            this.Body = 150;
            this.BaseSoundID = 447;

            this.Hue = 2959;

            this.SetStr(1168, 3225);
            this.SetDex(458, 885);
            this.SetInt(453, 895);

            this.SetHits(11000, 12700);

            this.SetDamage(7, 130);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 25, 35);
            this.SetResistance(ResistanceType.Fire, 50, 60);
            this.SetResistance(ResistanceType.Cold, 30, 40);
            this.SetResistance(ResistanceType.Poison, 30, 40);
            this.SetResistance(ResistanceType.Energy, 15, 20);

            this.SetSkill(SkillName.MagicResist, 60.1, 75.0);
            this.SetSkill(SkillName.Tactics, 60.1, 70.0);
            this.SetSkill(SkillName.Wrestling, 60.1, 70.0);

            this.Fame = 6000;
            this.Karma = -6000;

            this.VirtualArmor = 60;
            this.CanSwim = true;
            this.CantWalk = false;

            if (Utility.RandomBool())
                this.PackItem(new SulfurousAsh(15));
            else
                this.PackItem(new BlackPearl(15));

            this.PackItem(new RawFishSteak());
            //PackItem( new SpecialFishingNet() );
            switch ( Utility.Random( 8 ) ) //Minor Artifacts
			         {
                case 0: PackItem( new LochNessArms()); break;
                case 1: PackItem( new LochNessGloves()); break;
                case 2: PackItem( new LochNessChest()); break;
                case 3: PackItem( new LochNessLegs()); break;
                case 4: PackItem( new Spam()); break;
              //  case 5: PackItem( new GMCap()); break;
              //  case 6: PackItem( new GMRing()); break;
              //  case 7: PackItem( new BanStick()); break;

		    	      }
        }

        public Nessie(Serial serial)
            : base(serial)
        {
        }

        public override bool HasBreath
        {
            get
            {
                return true;
            }
        }
        public override int TreasureMapLevel
        {
            get
            {
                return 2;
            }
        }
        public override int Hides
        {
            get
            {
                return 10;
            }
        }
        public override HideType HideType
        {
            get
            {
                return HideType.Horned;
            }
        }
        public override int Scales
        {
            get
            {
                return 8;
            }
        }
        public override ScaleType ScaleType
        {
            get
            {
                return ScaleType.Blue;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Meager);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
