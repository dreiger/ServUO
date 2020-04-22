using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class KiaWoodDoorNW : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorNW()
            : base(0x2D6D, 0x31A8, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public KiaWoodDoorNW(Serial serial)
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

    public class KiaWoodDoorNE : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorNE()
            : base(0x31AA, 0x31A8, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public KiaWoodDoorNE(Serial serial)
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

    public class KiaWoodDoorSW : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorSW()
            : base(0x2D6D, 0x2D6B, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public KiaWoodDoorSW(Serial serial)
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

    public class KiaWoodDoorSE : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorSE()
            : base(0x31AA, 0x2D6B, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public KiaWoodDoorSE(Serial serial)
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

    public class KiaWoodDoorWN : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorWN()
            : base(0x31A8, 0x2D6D, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public KiaWoodDoorWN(Serial serial)
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

    public class KiaWoodDoorWS : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorWS()
            : base(0x2D6B, 0x2D6D, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public KiaWoodDoorWS(Serial serial)
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

    public class KiaWoodDoorEN : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorEN()
            : base(0x31A8, 0x31AA, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public KiaWoodDoorEN(Serial serial)
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

    public class KiaWoodDoorES : BaseDoor
    {
        [Constructable]
        public KiaWoodDoorES()
            : base(0x2D6B, 0x31AA, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public KiaWoodDoorES(Serial serial)
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