using System;

namespace Server.Items
{
    public class Necronomicon : NecromancerSpellbook, ITokunoDyable
	{
		public override bool IsArtifact { get { return true; } }
        [Constructable]
        public Necronomicon()
        {
            this.LootType = LootType.Blessed;
            this.Name = "Necronomicon - The Book Of The Dead";
			this.Hue = 88;

            this.SkillBonuses.SetValues(0, SkillName.Necromancy, 55.0);
            this.Attributes.RegenMana = 15;
            this.Attributes.CastSpeed = 4;
            this.Attributes.SpellDamage = 55;
            //this.Attributes.IncreasedKarmaLoss = 5;
        }

        public Necronomicon(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1078148;
            }
        }// Ossian Grimoire
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(1); //version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();

            if (version == 0)
                this.Attributes.IncreasedKarmaLoss = 5;
        }
    }
}
