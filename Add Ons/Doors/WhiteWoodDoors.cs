using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class WhiteWoodDoorNW : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorNW()
            : base(0x2D65, 0x31A2, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public WhiteWoodDoorNW(Serial serial)
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

    public class WhiteWoodDoorNE : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorNE()
            : base(0x31A0, 0x31A2, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public WhiteWoodDoorNE(Serial serial)
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

    public class WhiteWoodDoorSW : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorSW()
            : base(0x2D65, 0x2D63, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public WhiteWoodDoorSW(Serial serial)
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

    public class WhiteWoodDoorSE : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorSE()
            : base(0x31A0, 0x2D63, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public WhiteWoodDoorSE(Serial serial)
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

    public class WhiteWoodDoorWN : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorWN()
            : base(0x31A2, 0x2D65, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public WhiteWoodDoorWN(Serial serial)
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

    public class WhiteWoodDoorWS : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorWS()
            : base(0x2D63, 0x2D65, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public WhiteWoodDoorWS(Serial serial)
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

    public class WhiteWoodDoorEN : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorEN()
            : base(0x31A2, 0x31A0, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public WhiteWoodDoorEN(Serial serial)
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

    public class WhiteWoodDoorES : BaseDoor
    {
        [Constructable]
        public WhiteWoodDoorES()
            : base(0x2D63, 0x31A0, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public WhiteWoodDoorES(Serial serial)
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