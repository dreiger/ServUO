using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("an earth elemental corpse")]
    public class PissedOffEarthElemental : BaseCreature
    {
        [Constructable]
        public PissedOffEarthElemental()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            this.Name = "a Pissed Off Earth Elemental";
            this.Body = 14;
            this.BaseSoundID = 268;
            this.Hue = 2938;

            this.SetStr(2147, 6155);
            this.SetDex(478, 989);
            this.SetInt(894, 23110);

            this.SetHits(35000, 64505);
						this.SetMana(1294, 3110);
						this.SetStam(1378, 5489);

            this.SetDamage(91, 160);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 59, 65);
            this.SetResistance(ResistanceType.Fire, 20, 30);
            this.SetResistance(ResistanceType.Cold, 21, 28);
            this.SetResistance(ResistanceType.Poison, 47, 51);
            this.SetResistance(ResistanceType.Energy, 30, 33);

            this.SetSkill(SkillName.MagicResist, 100.0);
            this.SetSkill(SkillName.Tactics, 100.0);
            this.SetSkill(SkillName.Wrestling, 120.0);

            this.Fame = 3500;
            this.Karma = -3500;

            this.VirtualArmor = 74;


            this.PackItem(new FertileDirt(Utility.RandomMinMax(1, 4)));
            this.PackItem(new MandrakeRoot());
			
            Item ore = new IronOre(5);
            ore.ItemID = 0x19B7;
            this.PackItem(ore);
        }

        public PissedOffEarthElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }
        public override bool BleedImmune
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
                return 1;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Average);
            this.AddLoot(LootPack.Meager);
            this.AddLoot(LootPack.Gems);
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