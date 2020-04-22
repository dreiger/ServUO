using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishQueensRedDoorNW : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorNW()
            : base(0x50CA, 0x50CE, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishQueensRedDoorNW(Serial serial)
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

    public class GargishQueensRedDoorNE : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorNE()
            : base(0x50C8, 0x50CE, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishQueensRedDoorNE(Serial serial)
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

    public class GargishQueensRedDoorSW : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorSW()
            : base(0x50CA, 0x50C9, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishQueensRedDoorSW(Serial serial)
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

    public class GargishQueensRedDoorSE : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorSE()
            : base(0x50C8, 0x50C9, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public GargishQueensRedDoorSE(Serial serial)
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

    public class GargishQueensRedDoorWN : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorWN()
            : base(0x50CE, 0x50C8, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishQueensRedDoorWN(Serial serial)
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

    public class GargishQueensRedDoorWS : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorWS()
            : base(0x50CC, 0x50C8, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishQueensRedDoorWS(Serial serial)
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

    public class GargishQueensRedDoorEN : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorEN()
            : base(0x50CE, 0x50CD, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishQueensRedDoorEN(Serial serial)
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

    public class GargishQueensRedDoorES : BaseDoor
    {
        [Constructable]
        public GargishQueensRedDoorES()
            : base(0x50CC, 0x50CD, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishQueensRedDoorES(Serial serial)
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