using System;
using Server.Items;

namespace Server.Mobiles
{
    public class PersonaMagelBitch : BaseCreature
    {
        [Constructable]
        public PersonaMagelBitch()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.SpeechHue = Utility.RandomDyedHue();
            this.Title = "the Slave Mage Bitch";
            this.Hue = Utility.RandomSkinHue();

            if (this.Female = Utility.RandomBool())
            {
                this.Body = 0x191;
                this.Name = NameList.RandomName("female");
                this.AddItem(new Skirt(Utility.RandomNeutralHue()));
            }
            else
            {
                this.Body = 0x190;
                this.Name = NameList.RandomName("male");
                this.AddItem(new ShortPants(Utility.RandomNeutralHue()));
            }

            this.SetStr(86, 100);
            this.SetDex(81, 95);
            this.SetInt(61, 75);

            this.SetDamage(60, 223);

            this.SetSkill(SkillName.Fencing, 166.0, 297.5);
            this.SetSkill(SkillName.Macing, 165.0, 287.5);
            this.SetSkill(SkillName.MagicResist, 125.0, 247.5);
            this.SetSkill(SkillName.Swords, 165.0, 287.5);
            this.SetSkill(SkillName.Tactics, 165.0, 287.5);
            this.SetSkill(SkillName.Wrestling, 115.0, 237.5);
            this.SetSkill(SkillName.Magery, 185.0, 325.0);

            this.Fame = 1000;
            this.Karma = -1000;
            this.VirtualArmor = 4;
            this.Tamable = true;
            this.ControlSlots = 3;
            this.MinTameSkill = 93.9;

            this.AddItem(new Boots(Utility.RandomNeutralHue()));
            this.AddItem(new FancyShirt());
            this.AddItem(new Bandana());

            switch ( Utility.Random(7))
            {
                case 0:
                    this.AddItem(new Longsword());
                    break;
                case 1:
                    this.AddItem(new Cutlass());
                    break;
                case 2:
                    this.AddItem(new Broadsword());
                    break;
                case 3:
                    this.AddItem(new Axe());
                    break;
                case 4:
                    this.AddItem(new Club());
                    break;
                case 5:
                    this.AddItem(new Dagger());
                    break;
                case 6:
                    this.AddItem(new Spear());
                    break;
            }

            Utility.AssignRandomHair(this);
        }

        public PersonaMagelBitch(Serial serial)
            : base(serial)
        {
        }

        public override bool ClickTitle
        {
            get
            {
                return false;
            }
        }
        public override bool AlwaysMurderer
        {
            get
            {
                return false;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Average);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}