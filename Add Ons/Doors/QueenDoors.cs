using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class QueenDoorNW : BaseDoor
    {
        [Constructable]
        public QueenDoorNW()
            : base(0x4D22, 0x4D28, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public QueenDoorNW(Serial serial)
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

    public class QueenDoorNE : BaseDoor
    {
        [Constructable]
        public QueenDoorNE()
            : base(0x4D24, 0x4D28, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public QueenDoorNE(Serial serial)
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

    public class QueenDoorSW : BaseDoor
    {
        [Constructable]
        public QueenDoorSW()
            : base(0x4D22, 0x4D23, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public QueenDoorSW(Serial serial)
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

    public class QueenDoorSE : BaseDoor
    {
        [Constructable]
        public QueenDoorSE()
            : base(0x4D24, 0x4D23, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public QueenDoorSE(Serial serial)
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

    public class QueenDoorWN : BaseDoor
    {
        [Constructable]
        public QueenDoorWN()
            : base(0x4D28, 0x4D22, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public QueenDoorWN(Serial serial)
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

    public class QueenDoorWS : BaseDoor
    {
        [Constructable]
        public QueenDoorWS()
            : base(0x4D26, 0x4D22, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public QueenDoorWS(Serial serial)
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

    public class QueenDoorEN : BaseDoor
    {
        [Constructable]
        public QueenDoorEN()
            : base(0x4D28, 0x4D27, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public QueenDoorEN(Serial serial)
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

    public class QueenDoorES : BaseDoor
    {
        [Constructable]
        public QueenDoorES()
            : base(0x4D26, 0x4D27, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public QueenDoorES(Serial serial)
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