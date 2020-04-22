using System;

namespace Server.Mobiles
{
    [CorpseName("a red squirrel corpse")]
    public class RedSquirrel : BaseCreature
    {
        [Constructable]
        public RedSquirrel()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            this.Name = "a red squirrel";
            this.Body = 0x116;
            this.Hue = 1209;

            this.SetStr(144, 250);
            this.SetDex(135);
            this.SetInt(115);

            this.SetHits(142, 450);

            this.SetDamage(10, 25);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 30, 34);
            this.SetResistance(ResistanceType.Fire, 10, 14);
            this.SetResistance(ResistanceType.Cold, 30, 35);
            this.SetResistance(ResistanceType.Poison, 20, 25);
            this.SetResistance(ResistanceType.Energy, 20, 25);

            this.SetSkill(SkillName.MagicResist, 64.0);
            this.SetSkill(SkillName.Tactics, 164.0);
            this.SetSkill(SkillName.Wrestling, 164.0);

            this.Tamable = true;
            this.ControlSlots = 3;
            this.MinTameSkill = 118.3;
        }

        public RedSquirrel(Serial serial)
            : base(serial)
        {
        }

        public override int Meat
        {
            get
            {
                return 61;
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
