using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishQueenDoorNW : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorNW()
            : base(0x4D1A, 0x4D20, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishQueenDoorNW(Serial serial)
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

    public class GargishQueenDoorNE : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorNE()
            : base(0x4D1C, 0x4D20, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishQueenDoorNE(Serial serial)
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

    public class GargishQueenDoorSW : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorSW()
            : base(0x4D1A, 0x4D1D, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishQueenDoorSW(Serial serial)
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

    public class GargishQueenDoorSE : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorSE()
            : base(0x4D1C, 0x4D1D, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishQueenDoorSE(Serial serial)
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

    public class GargishQueenDoorWN : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorWN()
            : base(0x4D20, 0x4D1A, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishQueenDoorWN(Serial serial)
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

    public class GargishQueenDoorWS : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorWS()
            : base(0x4D1E, 0x4D1A, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishQueenDoorWS(Serial serial)
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

    public class GargishQueenDoorEN : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorEN()
            : base(0x4D20, 0x4D1F, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishQueenDoorEN(Serial serial)
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

    public class GargishQueenDoorES : BaseDoor
    {
        [Constructable]
        public GargishQueenDoorES()
            : base(0x4D1E, 0x4D1F, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishQueenDoorES(Serial serial)
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