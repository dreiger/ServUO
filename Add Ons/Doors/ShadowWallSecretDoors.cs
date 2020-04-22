using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class ShadowWallSecretDoorNW : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorNW()
            : base(0x3649, 0x3648, 0xED, 0xF4, new Point3D(-1, 1, 0))
        {
        }

        public ShadowWallSecretDoorNW(Serial serial)
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

    public class ShadowWallSecretDoorNE : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorNE()
            : base(0x3647, 0x3648, 0xED, 0xF4, new Point3D(0, 1, 0))
        {
        }

        public ShadowWallSecretDoorNE(Serial serial)
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

    public class ShadowWallSecretDoorSW : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorSW()
            : base(0x3649, 0x364A, 0xED, 0xF4, new Point3D(-1, 0, 0))
        {
        }

        public ShadowWallSecretDoorSW(Serial serial)
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

    public class ShadowWallSecretDoorSE : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorSE()
            : base(0x3647, 0x364A, 0xED, 0xF4, new Point3D(0, 0, 0))
        {
        }

        public ShadowWallSecretDoorSE(Serial serial)
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

    public class ShadowWallSecretDoorWN : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorWN()
            : base(0x3648, 0x3649, 0xED, 0xF4, new Point3D(1, -1, 0))
        {
        }

        public ShadowWallSecretDoorWN(Serial serial)
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

    public class ShadowWallSecretDoorWS : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorWS()
            : base(0x364A, 0x3649, 0xED, 0xF4, new Point3D(1, 0, 0))
        {
        }

        public ShadowWallSecretDoorWS(Serial serial)
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

    public class ShadowWallSecretDoorEN : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorEN()
            : base(0x3648, 0x3647, 0xED, 0xF4, new Point3D(0, -1, 0))
        {
        }

        public ShadowWallSecretDoorEN(Serial serial)
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

    public class ShadowWallSecretDoorES : BaseDoor
    {
        [Constructable]
        public ShadowWallSecretDoorES()
            : base(0x364A, 0x3647, 0xED, 0xF4, new Point3D(0, 0, 0))
        {
        }

        public ShadowWallSecretDoorES(Serial serial)
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