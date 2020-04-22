using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class QuarterMoonDoorSW : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorSW()
            : base(0x2FE4, 0x2FE2, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public QuarterMoonDoorSW(Serial serial)
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
    public class QuarterMoonDoorSE : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorSE()
            : base(0x2FE3, 0x2FE2, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public QuarterMoonDoorSE(Serial serial)
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

    public class QuarterMoonDoorNW : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorNW()
            : base(0x2FE4, 0x319E, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public QuarterMoonDoorNW(Serial serial)
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
    public class QuarterMoonDoorNE : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorNE()
            : base(0x2FE3, 0x319E, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public QuarterMoonDoorNE(Serial serial)
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

    public class QuarterMoonDoorEN : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorEN()
            : base(0x319E, 0x319F, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public QuarterMoonDoorEN(Serial serial)
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
    public class QuarterMoonDoorES : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorES()
            : base(0x2FE5, 0x2FE3, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public QuarterMoonDoorES(Serial serial)
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

    public class QuarterMoonDoorWN : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorWN()
            : base(0x319E, 0x2FE4, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public QuarterMoonDoorWN(Serial serial)
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
    public class QuarterMoonDoorWS : BaseDoor
    {
        [Constructable]
        public QuarterMoonDoorWS()
            : base(0x2FE5, 0x2FE4, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public QuarterMoonDoorWS(Serial serial)
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