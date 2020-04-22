using System;

namespace Server.Mobiles
{
    [CorpseName("a black squirrel corpse")]
    public class BlackSquirrel : BaseCreature
    {
        [Constructable]
        public BlackSquirrel()
            : base(AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "a blacksquirrel";
            this.Body = 0x116;
            this.Hue = 1107;

            this.SetStr(444, 650);
            this.SetDex(435);
            this.SetInt(450);

            this.SetHits(402, 850);

            this.SetDamage(10, 62);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 30, 34);
            this.SetResistance(ResistanceType.Fire, 10, 14);
            this.SetResistance(ResistanceType.Cold, 30, 35);
            this.SetResistance(ResistanceType.Poison, 20, 25);
            this.SetResistance(ResistanceType.Energy, 20, 25);

            this.SetSkill(SkillName.MagicResist, 64.0);
            this.SetSkill(SkillName.Tactics, 64.0);
            this.SetSkill(SkillName.Wrestling, 64.0);
            this.SetSkill(SkillName.Magery, 225.0);

            this.Tamable = true;
            this.ControlSlots = 3;
            this.MinTameSkill = 121.3;
        }

        public BlackSquirrel(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 15;
            }
        }
        public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.FruitsAndVegies;
            }
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
