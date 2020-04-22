using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class GargishCelestialDoorNW : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorNW()
            : base(0x41C2, 0x41C8, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public GargishCelestialDoorNW(Serial serial)
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

    public class GargishCelestialDoorNE : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorNE()
            : base(0x41C4, 0x41C8, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public GargishCelestialDoorNE(Serial serial)
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

    public class GargishCelestialDoorSW : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorSW()
            : base(0x41C2, 0x41C6, 0xEA, 0xF1, new Point3D(-1, 0, 0))
        {
        }

        public GargishCelestialDoorSW(Serial serial)
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

    public class GargishCelestialDoorSE : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorSE()
            : base(0x41C4, 0x41C6, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishCelestialDoorSE(Serial serial)
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

    public class GargishCelestialDoorWN : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorWN()
            : base(0x41C8, 0x41C2, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public GargishCelestialDoorWN(Serial serial)
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

    public class GargishCelestialDoorWS : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorWS()
            : base(0x41C6, 0x41C2, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public GargishCelestialDoorWS(Serial serial)
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

    public class GargishCelestialDoorEN : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorEN()
            : base(0x41C8, 0x41C4, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public GargishCelestialDoorEN(Serial serial)
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

    public class GargishCelestialDoorES : BaseDoor
    {
        [Constructable]
        public GargishCelestialDoorES()
            : base(0x41C6, 0x41C4, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public GargishCelestialDoorES(Serial serial)
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