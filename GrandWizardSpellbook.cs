using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class GrandWizardSpellbook : Spellbook
	{
		public override bool IsArtifact { get { return true; } }
        [Constructable]
        public GrandWizardSpellbook()
            : base()
        {
            this.Hue = 2598;
            this.Name = "Grand Wizard Spellbook";

            this.Attributes.SpellDamage = 75;
            this.Attributes.LowerManaCost = 50;
            this.Attributes.CastSpeed = 6;
            this.Attributes.CastRecovery = 8;
        }

        public GrandWizardSpellbook(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1072940;
            }
        }// scrappers compendium
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

        public override int OnCraft(int quality, bool makersMark, Mobile from, CraftSystem craftSystem, Type typeRes, BaseTool tool, CraftItem craftItem, int resHue)
        {
            double magery = from.Skills.Magery.Value - 100;

            if (magery < 0)
                magery = 0;

            int count = (int)Math.Round(magery * Utility.RandomDouble() / 5);

            if (count > 2)
                count = 2;

            if (Utility.RandomDouble() < 0.5)
                count = 0;
            else
                BaseRunicTool.ApplyAttributesTo(this, false, 0, count, 70, 80);

            this.Attributes.SpellDamage = 75;
            this.Attributes.LowerManaCost = 50;
            this.Attributes.CastSpeed = 6;
            this.Attributes.CastRecovery = 8;

            if (makersMark)
                this.Crafter = from;

            return quality;
        }
    }
}
