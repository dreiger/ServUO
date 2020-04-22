using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class TangleWoodDoorNW : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorNW()
            : base(0x31AE, 0x2D46, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public TangleWoodDoorNW(Serial serial)
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

    public class TangleWoodDoorNE : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorNE()
            : base(0x31AC, 0x2D46, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public TangleWoodDoorNE(Serial serial)
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

    public class TangleWoodDoorSW : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorSW()
            : base(0x31AE, 0x2D48, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public TangleWoodDoorSW(Serial serial)
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

    public class TangleWoodDoorSE : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorSE()
            : base(0x31AC, 0x2D48, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public TangleWoodDoorSE(Serial serial)
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

    public class TangleWoodDoorWN : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorWN()
            : base(0x2D46, 0x31AE, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public TangleWoodDoorWN(Serial serial)
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

    public class TangleWoodDoorWS : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorWS()
            : base(0x2D48, 0x31AE, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public TangleWoodDoorWS(Serial serial)
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

    public class TangleWoodDoorEN : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorEN()
            : base(0x2D46, 0x31AC, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public TangleWoodDoorEN(Serial serial)
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

    public class TangleWoodDoorES : BaseDoor
    {
        [Constructable]
        public TangleWoodDoorES()
            : base(0x2D48, 0x31AC, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public TangleWoodDoorES(Serial serial)
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