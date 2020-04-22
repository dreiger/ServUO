using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class BarDoorNW : BaseDoor
    {
        [Constructable]
        public BarDoorNW()
            : base(0x190F, 0x190E, 0xEB, 0xF2, new Point3D(-1, 0, 0))
        {
        }

        public BarDoorNW(Serial serial)
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

    public class BarDoorNE : BaseDoor
    {
        [Constructable]
        public BarDoorNE()
            : base(0x190F, 0x190E, 0xEB, 0xF2, new Point3D(0, 0, 0))
        {
        }

        public BarDoorNE(Serial serial)
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

    public class BarDoorSW : BaseDoor
    {
        [Constructable]
        public BarDoorSW()
            : base(0x190F, 0x190E, 0xEB, 0xF2, new Point3D(-1, 1, 0))
        {
        }

        public BarDoorSW(Serial serial)
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

    public class BarDoorSE : BaseDoor
    {
        [Constructable]
        public BarDoorSE()
            : base(0x190F, 0x190E, 0xEB, 0xF2, new Point3D(0, 1, 0))
        {
        }

        public BarDoorSE(Serial serial)
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

    public class BarDoorWN : BaseDoor
    {
        [Constructable]
        public BarDoorWN()
            : base(0x190E, 0x190F, 0xEB, 0xF2, new Point3D(1, -1, 0))
        {
        }

        public BarDoorWN(Serial serial)
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

    public class BarDoorWS : BaseDoor
    {
        [Constructable]
        public BarDoorWS()
            : base(0x190E, 0x190F, 0xEB, 0xF2, new Point3D(1, 0, 0))
        {
        }

        public BarDoorWS(Serial serial)
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

    public class BarDoorEN : BaseDoor
    {
        [Constructable]
        public BarDoorEN()
            : base(0x190E, 0x190F, 0xEB, 0xF2, new Point3D(0, -1, 0))
        {
        }

        public BarDoorEN(Serial serial)
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

    public class BarDoorES : BaseDoor
    {
        [Constructable]
        public BarDoorES()
            : base(0x190E, 0x190F, 0xEB, 0xF2, new Point3D(0, 0, 0))
        {
        }

        public BarDoorES(Serial serial)
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