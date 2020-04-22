using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class ShadowDoorNW : BaseDoor
    {
        [Constructable]
        public ShadowDoorNW()
            : base(0x368B, 0x3644, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public ShadowDoorNW(Serial serial)
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

    public class ShadowDoorNE : BaseDoor
    {
        [Constructable]
        public ShadowDoorNE()
            : base(0x368D, 0x3643, 0xEA, 0xF1, new Point3D(1, 1, 0))
        {
        }

        public ShadowDoorNE(Serial serial)
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

    public class ShadowDoorSW : BaseDoor
    {
        [Constructable]
        public ShadowDoorSW()
            : base(0x368B, 0x3690, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public ShadowDoorSW(Serial serial)
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

    public class ShadowDoorSE : BaseDoor
    {
        [Constructable]
        public ShadowDoorSE()
            : base(0x368D, 0x3646, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public ShadowDoorSE(Serial serial)
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

    public class ShadowDoorWN : BaseDoor
    {
        [Constructable]
        public ShadowDoorWN()
            : base(0x368C, 0x3641, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public ShadowDoorWN(Serial serial)
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

    public class ShadowDoorWS : BaseDoor
    {
        [Constructable]
        public ShadowDoorWS()
            : base(0x3640, 0x3694, 0xEA, 0xF1, new Point3D(1, 1, 0))
        {
        }

        public ShadowDoorWS(Serial serial)
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

    public class ShadowDoorEN : BaseDoor
    {
        [Constructable]
        public ShadowDoorEN()
            : base(0x368C, 0x3645, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public ShadowDoorEN(Serial serial)
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

    public class ShadowDoorES : BaseDoor
    {
        [Constructable]
        public ShadowDoorES()
            : base(0x3640, 0x3698, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public ShadowDoorES(Serial serial)
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