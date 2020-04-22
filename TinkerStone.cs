using System;

namespace Server.Items
{
    public class TinkerStone : Item
    {
        [Constructable]
        public TinkerStone()
            : base(0xED4)
        {
            this.Movable = false;
            this.Hue = 2276;
        }

        public TinkerStone(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "a Tinker Supply Stone";
            }
        }
        public override void OnDoubleClick(Mobile from)
        {
            TinkerBag TinkerBag = new TinkerBag();

            if (!from.AddToBackpack(TinkerBag))
                TinkerBag.Delete();
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