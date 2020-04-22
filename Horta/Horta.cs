using System;
using Server.Factions;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("He's dead Jim!")]
    public class Horta : BaseCreature
    {
        [Constructable]
        public Horta()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a Horta";
            Body = 319;
			Hue = 88;
            BaseSoundID = 357;

            SetStr(1476, 2505);
            SetDex(1276, 2595);
            SetInt(1301, 2325);

            SetHits(35626, 86333);

            SetDamage(22, 140);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 245, 460);
            SetResistance(ResistanceType.Fire, 250, 460);
            SetResistance(ResistanceType.Cold, 230, 440);
            SetResistance(ResistanceType.Poison, 220, 430);
            SetResistance(ResistanceType.Energy, 230, 440);

            SetSkill(SkillName.EvalInt, 270.1, 580.0);
            SetSkill(SkillName.Magery, 270.1, 580.0);
            SetSkill(SkillName.MagicResist, 285.1, 595.0);
            SetSkill(SkillName.Tactics, 270.1, 580.0);
            SetSkill(SkillName.Wrestling, 260.1, 580.0);

            Fame = 15000;
            Karma = -15000;

           // QLPoints = 5;

            VirtualArmor = 60;

			switch (Utility.Random(20))
            {
                case 0: PackItem(new HortaShovel()); break;
                case 1: PackItem(new GargoylesAxe()); break;
                case 2: PackItem(new LumberjacksAxe()); break;
                case 3: PackItem(new MobileForge()); break;
				case 4: PackItem(new ColoredForgeDeed()); break;
			}


            ControlSlots = Core.SE ? 4 : 5;
        }

        public Horta(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 225.0;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }
        public override Faction FactionAllegiance
        {
            get
            {
                return Shadowlords.Instance;
            }
        }
        public override Ethics.Ethic EthicAllegiance
        {
            get
            {
                return Ethics.Ethic.Evil;
            }
        }
        public override bool CanRummageCorpses
        {
            get
            {
                return true;
            }
        }
        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Lethal;
            }
        }
        public override int TreasureMapLevel
        {
            get
            {
                return 4;
            }
        }
        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override bool CanFly
        {
            get
            {
                return true;
            }
        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
            AddLoot(LootPack.Average, 1);
            AddLoot(LootPack.MedScrolls, 5);
        }
        
    //    private Item HortasBalls;

     /*   public override void OnDeath(Container c)
        {

            base.OnDeath(c);

            switch (Utility.Random(8)) // 
            {
                case 0: AddItem( new HortaicEmbrace() ); break;
                case 1: AddItem( new HortaicHeart() ); break;
                case 2: AddItem( new HortaicHooves() ); break;
                case 3: AddItem( new HortaicHorns() ); break;
                case 4: AddItem( new HortaicReaper() ); break;
                case 5: AddItem( new HortaicTouch() ); break;
                case 6: AddItem( new HortaicShroud() ); break;
                case 7: AddItem( new AutoResPotion() ); break;

            }

            if (20 > Utility.Random(20))
            {
                c.AddItem(HortasBalls);
            }
        } */
        
/*        public override void OnDeath(Container c)
        {

            base.OnDeath(c);
            Region reg = Region.Find(c.GetWorldLocation(), c.Map);
            if (0.25 > Utility.RandomDouble() && reg.Name == "Abyssal Lair Entrance")
            {
                if (Utility.RandomDouble() < 0.6)
                    c.DropItem(new EssenceAchievement());
            }
        } */
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