using System;

namespace Server.Items
{
    public class TinkerBag : Bag
    {
        [Constructable]
        public TinkerBag()
            : this(1)
        {
            this.Movable = true;
            this.Hue = 2276;
        }

        [Constructable]
        public TinkerBag(int amount)
        {
            this.DropItem(new IronIngot(50000));
            this.DropItem(new Board(50000));
            this.DropItem(new RecallRune(5000) );
            this.DropItem(new Axle(5000) );
            this.DropItem(new AxleGears(5000) );
            this.DropItem(new ClockFrame(5000) );
            this.DropItem(new ClockParts(5000) );
            this.DropItem(new Gears(5000) );
            this.DropItem(new Globe(5000) );
            this.DropItem(new Hinge(5000) );
            this.DropItem(new SextantParts(5000) );
            this.DropItem(new Springs(5000) );
            
        }

        public TinkerBag(Serial serial)
            : base(serial)
        {
        }

        public override string DefaultName
        {
            get
            {
                return "a Scribe Kit";
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