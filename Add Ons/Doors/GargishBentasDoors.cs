using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishBentasDoorNW : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorNW()
            : base(0x50D0, 0x50D6, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishBentasDoorNW(Serial serial)
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

    public class GargishBentasDoorNE : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorNE()
            : base(0x50D2, 0x50D6, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishBentasDoorNE(Serial serial)
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

    public class GargishBentasDoorSW : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorSW()
            : base(0x50D0, 0x50D1, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public GargishBentasDoorSW(Serial serial)
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

    public class GargishBentasDoorSE : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorSE()
            : base(0x50D2, 0x50D1, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishBentasDoorSE(Serial serial)
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

    public class GargishBentasDoorWN : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorWN()
            : base(0x50D6, 0x50D0, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishBentasDoorWN(Serial serial)
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

    public class GargishBentasDoorWS : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorWS()
            : base(0x50D4, 0x50D0, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishBentasDoorWS(Serial serial)
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

    public class GargishBentasDoorEN : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorEN()
            : base(0x50D6, 0x50D5, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishBentasDoorEN(Serial serial)
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

    public class GargishBentasDoorES : BaseDoor
    {
        [Constructable]
        public GargishBentasDoorES()
            : base(0x50D4, 0x50D5, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishBentasDoorES(Serial serial)
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