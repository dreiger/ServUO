using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class CrystalDoorNW : BaseDoor
    {
        [Constructable]
        public CrystalDoorNW()
            : base(0x367D, 0x3683, 0xED, 0xF4, new Point3D(-1, 1, 0))
        {
        }

        public CrystalDoorNW(Serial serial)
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

    public class CrystalDoorNE : BaseDoor
    {
        [Constructable]
        public CrystalDoorNE()
            : base(0x367F, 0x367E, 0xED, 0xF4, new Point3D(1, 1, 0))
        {
        }

        public CrystalDoorNE(Serial serial)
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

    public class CrystalDoorSW : BaseDoor
    {
        [Constructable]
        public CrystalDoorSW()
            : base(0x367D, 0x3683, 0xED, 0xF4, new Point3D(-1, 0, 0))
        {
        }

        public CrystalDoorSW(Serial serial)
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

    public class CrystalDoorSE : BaseDoor
    {
        [Constructable]
        public CrystalDoorSE()
            : base(0x367F, 0x367E, 0xED, 0xF4, new Point3D(1, 0, 0))
        {
        }

        public CrystalDoorSE(Serial serial)
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

    public class CrystalDoorWN : BaseDoor
    {
        [Constructable]
        public CrystalDoorWN()
            : base(0x35E7, 0x3681, 0xED, 0xF4, new Point3D(1, -1, 0))
        {
        }

        public CrystalDoorWN(Serial serial)
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

    public class CrystalDoorWS : BaseDoor
    {
        [Constructable]
        public CrystalDoorWS()
            : base(0x3680, 0x3681, 0xED, 0xF4, new Point3D(1, 0, 0))
        {
        }

        public CrystalDoorWS(Serial serial)
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

    public class CrystalDoorEN : BaseDoor
    {
        [Constructable]
        public CrystalDoorEN()
            : base(0x35E7, 0x367B, 0xED, 0xF4, new Point3D(0, -1, 0))
        {
        }

        public CrystalDoorEN(Serial serial)
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

    public class CrystalDoorES : BaseDoor
    {
        [Constructable]
        public CrystalDoorES()
            : base(0x3680, 0x3684, 0xED, 0xF4, new Point3D(0, 1, 0))
        {
        }

        public CrystalDoorES(Serial serial)
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