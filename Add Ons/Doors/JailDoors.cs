using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class JailDoorNW : BaseDoor
    {
        [Constructable]
        public JailDoorNW() : base(0x5142, 0x5143, 0xEC, 0xF3, new Point3D(-1, 0, 0))
        {
        }

        public JailDoorNW(Serial serial) : base(serial)
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

    public class JailDoorNE : BaseDoor
    {
        [Constructable]
        public JailDoorNE()
            : base(0x5144, 0x5143, 0xEC, 0xF3, new Point3D(0, 0, 0))
        {
        }

        public JailDoorNE(Serial serial)
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

    public class JailDoorSW : BaseDoor
    {
        [Constructable]
        public JailDoorSW()
            : base(0x5142, 0x5148, 0xEC, 0xF3, new Point3D(-1, 1, 0))
        {
        }

        public JailDoorSW(Serial serial) : base(serial)
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

    public class JailDoorSE : BaseDoor
    {
        [Constructable]
        public JailDoorSE()
            : base(0x5144, 0x5148, 0xEC, 0xF3, new Point3D(0, 1, 0))
        {
        }

        public JailDoorSE(Serial serial)
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

    public class JailDoorWN : BaseDoor
    {
        [Constructable]
        public JailDoorWN()
            : base(0x5148, 0x5144, 0xEC, 0xF3, new Point3D( 0, -1, 0))
        {
        }

        public JailDoorWN(Serial serial)
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

    public class JailDoorWS : BaseDoor
    {
        [Constructable]
        public JailDoorWS()
            : base(0x5143, 0x5144, 0xEC, 0xF3, new Point3D(0, 0, 0))
        {
        }

        public JailDoorWS(Serial serial)
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

    public class JailDoorEN : BaseDoor
    {
        [Constructable]
        public JailDoorEN()
            : base(0x5148, 0x5142, 0xEC, 0xF3, new Point3D(1, -1, 0))
        {
        }

        public JailDoorEN(Serial serial)
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

    public class JailDoorES : BaseDoor
    {
        [Constructable]
        public JailDoorES()
            : base(0x5143, 0x5142, 0xEC, 0xF3, new Point3D(1, 0, 0))
        {
        }

        public JailDoorES(Serial serial)
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