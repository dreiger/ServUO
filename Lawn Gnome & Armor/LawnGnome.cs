using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a Lawn Gnome corpse")]
    public class LawnGnome : BaseCreature
    {
        [Constructable]
        public LawnGnome()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.Name = "a Lawn Gnome";
            this.Body = 724;
            this.Hue = 2637;

            this.SetStr(106, 200);
            this.SetDex(130, 200);
            this.SetInt(36, 200);

            this.SetHits(70);

            this.SetDamage(15, 75);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 56);
            this.SetResistance(ResistanceType.Fire, 50);
            this.SetResistance(ResistanceType.Cold, 65);
            this.SetResistance(ResistanceType.Poison, 70);
            this.SetResistance(ResistanceType.Energy, 75);

            this.SetSkill(SkillName.Anatomy, 178.5);
            this.SetSkill(SkillName.MagicResist, 182.5);
            this.SetSkill(SkillName.Tactics, 165.3);
            this.SetSkill(SkillName.Magery, 250.0, 400.0);
            this.SetSkill(SkillName.Healing, 128.0, 225.0);

            this.AddItem(new Bow());
            this.AddItem(new Arrow(25));
            this.PackItem(new Spam());
            this.PackItem(new Apple(5));
            this.PackItem(new Bandage(25));
        }

        public LawnGnome(Serial serial)
            : base(serial)
        {
        }

        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Rich);
        }

				private Item gnomebits;

        public override void OnDeath(Container c)
        {

            base.OnDeath(c);

            switch (Utility.Random(10)) //
            {
                case 0: AddItem( new LawnGnomeArms() ); break;
                case 1: AddItem( new LawnGnomeChest() ); break;
                case 2: AddItem( new LawnGnomeGloves() ); break;
                case 3: AddItem( new LawnGnomeHelm() ); break;
                case 4: AddItem( new LawnGnomeLegs() ); break;
                case 5: AddItem( new LawnGnomePoker() ); break;
                case 6: AddItem( new LawnGnomeSmasher() ); break;
                case 7: AddItem( new LawnGnomeSticker() ); break;
                case 8: AddItem( new LawnGnomeSwatter() ); break;
                case 9: AddItem( new BodyBag() ); break;

            }

            if (10 > Utility.Random(10))
            {
                c.AddItem(gnomebits);
            }
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
