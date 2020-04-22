using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class HeartWoodDoorNW : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorNW()
            : base(0x2D69, 0x31A6, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public HeartWoodDoorNW(Serial serial)
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

    public class HeartWoodDoorNE : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorNE()
            : base(0x31A7, 0x31A6, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public HeartWoodDoorNE(Serial serial)
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

    public class HeartWoodDoorSW : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorSW()
            : base(0x2D69, 0x2D67, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public HeartWoodDoorSW(Serial serial)
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

    public class HeartWoodDoorSE : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorSE()
            : base(0x31A7, 0x2D67, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public HeartWoodDoorSE(Serial serial)
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

    public class HeartWoodDoorWN : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorWN()
            : base(0x31A6, 0x2D69, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public HeartWoodDoorWN(Serial serial)
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

    public class HeartWoodDoorWS : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorWS()
            : base(0x2D67, 0x2D69, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public HeartWoodDoorWS(Serial serial)
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

    public class HeartWoodDoorEN : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorEN()
            : base(0x31A6, 0x31A7, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public HeartWoodDoorEN(Serial serial)
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

    public class HeartWoodDoorES : BaseDoor
    {
        [Constructable]
        public HeartWoodDoorES()
            : base(0x2D67, 0x31A7, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public HeartWoodDoorES(Serial serial)
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