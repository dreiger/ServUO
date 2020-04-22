using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class PurpleDoorEN : BaseDoor
    {
        [Constructable]
        public PurpleDoorEN()
            : base(0x241F, 0x2423, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public PurpleDoorEN(Serial serial)
            : base(serial)
        {
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
    public class Purple2DoorEN : BaseDoor
    {
        [Constructable]
        public Purple2DoorEN()
            : base(0x2422, 0x2421, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public Purple2DoorEN(Serial serial)
            : base(serial)
        {
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
    public class PurpleDoorSE : BaseDoor
    {
        [Constructable]
        public PurpleDoorSE()
            : base(0x2423, 0x241F, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public PurpleDoorSE(Serial serial)
            : base(serial)
        {
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
    public class Purple2DoorSE : BaseDoor
    {
        [Constructable]
        public Purple2DoorSE()
            : base(0x2421, 0x2422, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public Purple2DoorSE(Serial serial)
            : base(serial)
        {
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