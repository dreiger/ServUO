using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishRenaissanceDoorNW : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorNW()
            : base(0x436E, 0x4378, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishRenaissanceDoorNW(Serial serial)
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

    public class GargishRenaissanceDoorNE : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorNE()
            : base(0x4370, 0x4378, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishRenaissanceDoorNE(Serial serial)
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

    public class GargishRenaissanceDoorSW : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorSW()
            : base(0x436E, 0x4378, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public GargishRenaissanceDoorSW(Serial serial)
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

    public class GargishRenaissanceDoorSE : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorSE()
            : base(0x4370, 0x4378, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishRenaissanceDoorSE(Serial serial)
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

    public class GargishRenaissanceDoorWN : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorWN()
            : base(0x4378, 0x436E, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishRenaissanceDoorWN(Serial serial)
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

    public class GargishRenaissanceDoorWS : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorWS()
            : base(0x436F, 0x436E, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishRenaissanceDoorWS(Serial serial)
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

    public class GargishRenaissanceDoorEN : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorEN()
            : base(0x4378, 0x4377, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishRenaissanceDoorEN(Serial serial)
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

    public class GargishRenaissanceDoorES : BaseDoor
    {
        [Constructable]
        public GargishRenaissanceDoorES()
            : base(0x436F, 0x4377, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishRenaissanceDoorES(Serial serial)
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