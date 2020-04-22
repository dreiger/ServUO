using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class RuinWoodenDoorNW : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorNW()
            : base(0x46DD, 0x46E3, 0xEA, 0xF1, new Point3D(-1, 1, 0))
        {
        }

        public RuinWoodenDoorNW(Serial serial)
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

    public class RuinWoodenDoorNE : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorNE()
            : base(0x46DF, 0x46E3, 0xEA, 0xF1, new Point3D(0, 1, 0))
        {
        }

        public RuinWoodenDoorNE(Serial serial)
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

    public class RuinWoodenDoorSW : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorSW()
            : base(0x46DD, 0x46E0, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public RuinWoodenDoorSW(Serial serial)
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

    public class RuinWoodenDoorSE : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorSE()
            : base(0x46DF, 0x46E0, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public RuinWoodenDoorSE(Serial serial)
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

    public class RuinWoodenDoorWN : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorWN()
            : base(0x46E3, 0x46DD, 0xEA, 0xF1, new Point3D(1, -1, 0))
        {
        }

        public RuinWoodenDoorWN(Serial serial)
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

    public class RuinWoodenDoorWS : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorWS()
            : base(0x46DE, 0x46DD, 0xEA, 0xF1, new Point3D(1, 0, 0))
        {
        }

        public RuinWoodenDoorWS(Serial serial)
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

    public class RuinWoodenDoorEN : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorEN()
            : base(0x46E3, 0x46DF, 0xEA, 0xF1, new Point3D(0, -1, 0))
        {
        }

        public RuinWoodenDoorEN(Serial serial)
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

    public class RuinWoodenDoorES : BaseDoor
    {
        [Constructable]
        public RuinWoodenDoorES()
            : base(0x46DE, 0x46DF, 0xEA, 0xF1, new Point3D(0, 0, 0))
        {
        }

        public RuinWoodenDoorES(Serial serial)
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