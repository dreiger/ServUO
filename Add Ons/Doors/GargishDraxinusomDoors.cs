using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishDraxinusomDoorNW : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorNW()
            : base(0x4372, 0x437C, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishDraxinusomDoorNW(Serial serial)
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

    public class GargishDraxinusomDoorNE : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorNE()
            : base(0x4374, 0x437C, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishDraxinusomDoorNE(Serial serial)
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

    public class GargishDraxinusomDoorSW : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorSW()
            : base(0x4372, 0x4373, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public GargishDraxinusomDoorSW(Serial serial)
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

    public class GargishDraxinusomDoorSE : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorSE()
            : base(0x4374, 0x4375, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishDraxinusomDoorSE(Serial serial)
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

    public class GargishDraxinusomDoorWN : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorWN()
            : base(0x437C, 0x4372, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishDraxinusomDoorWN(Serial serial)
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

    public class GargishDraxinusomDoorWS : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorWS()
            : base(0x437A, 0x4372, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishDraxinusomDoorWS(Serial serial)
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

    public class GargishDraxinusomDoorEN : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorEN()
            : base(0x437C, 0x437D, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishDraxinusomDoorEN(Serial serial)
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

    public class GargishDraxinusomDoorES : BaseDoor
    {
        [Constructable]
        public GargishDraxinusomDoorES()
            : base(0x437A, 0x437D, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishDraxinusomDoorES(Serial serial)
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