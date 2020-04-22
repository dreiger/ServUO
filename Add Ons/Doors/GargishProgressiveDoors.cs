using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishProgressiveDoorNW : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorNW()
            : base(0x41CF, 0x41D5, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishProgressiveDoorNW(Serial serial)
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

    public class GargishProgressiveDoorNE : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorNE()
            : base(0x41D1, 0x41D5, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishProgressiveDoorNE(Serial serial)
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

    public class GargishProgressiveDoorSW : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorSW()
            : base(0x41CF, 0x41D0, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public GargishProgressiveDoorSW(Serial serial)
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

    public class GargishProgressiveDoorSE : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorSE()
            : base(0x41D1, 0x41D0, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishProgressiveDoorSE(Serial serial)
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

    public class GargishProgressiveDoorWN : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorWN()
            : base(0x41D5, 0x41CF, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishProgressiveDoorWN(Serial serial)
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

    public class GargishProgressiveDoorWS : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorWS()
            : base(0x41D0, 0x41CF, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishProgressiveDoorWS(Serial serial)
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

    public class GargishProgressiveDoorEN : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorEN()
            : base(0x41D5, 0x41D1, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishProgressiveDoorEN(Serial serial)
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

    public class GargishProgressiveDoorES : BaseDoor
    {
        [Constructable]
        public GargishProgressiveDoorES()
            : base(0x41D0, 0x41D1, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishProgressiveDoorES(Serial serial)
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