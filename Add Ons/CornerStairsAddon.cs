#region Header
/*
 * Name: CornerStairs
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class CornerStairsAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(1978, new Point3D(-1, -1, 0), 1, 0, 0, (string)null), // 1
			Tuple.Create(1978, new Point3D(0, -1, 0), 1, 0, 0, (string)null), // 2
			Tuple.Create(1978, new Point3D(-1, 0, 0), 1, 0, 0, (string)null), // 3
			Tuple.Create(1978, new Point3D(0, 0, 0), 1, 0, 0, (string)null), // 4
			Tuple.Create(1978, new Point3D(-1, 1, 0), 1, 0, 0, (string)null), // 5
			Tuple.Create(1978, new Point3D(0, 1, 0), 1, 0, 0, (string)null), // 6
			Tuple.Create(1978, new Point3D(1, 1, 0), 1, 0, 0, (string)null), // 7
			Tuple.Create(1978, new Point3D(1, 0, 0), 1, 0, 0, (string)null), // 8
			Tuple.Create(1978, new Point3D(1, -1, 0), 1, 0, 0, (string)null), // 9
			Tuple.Create(1978, new Point3D(1, 1, 0), 1, 0, 0, (string)null), // 10
			Tuple.Create(1978, new Point3D(1, 1, 5), 1, 0, 0, (string)null), // 11
			Tuple.Create(1979, new Point3D(-1, 2, 0), 1, 0, 0, (string)null), // 12
			Tuple.Create(1979, new Point3D(0, 2, 0), 1, 0, 0, (string)null), // 13
			Tuple.Create(1980, new Point3D(2, -1, 0), 1, 0, 0, (string)null), // 14
			Tuple.Create(1980, new Point3D(2, 0, 0), 1, 0, 0, (string)null), // 15
			Tuple.Create(3203, new Point3D(1, 2, 0), 1, 0, 0, (string)null), // 16
			Tuple.Create(3203, new Point3D(2, 2, 0), 1, 0, 0, (string)null), // 17
			Tuple.Create(3203, new Point3D(2, 1, 0), 1, 0, 0, (string)null), // 18
			Tuple.Create(19525, new Point3D(1, 1, 10), 1, 0, 0, (string)null) // 19
		};
		
		public override BaseAddonDeed Deed { get { return new CornerStairsAddonDeed(); } }

		[Constructable]
		public CornerStairsAddon()
		{
			Name = "CornerStairs Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public CornerStairsAddon(Serial serial) 
			: base(serial)
        { }
		
		protected virtual void AddComponent(int itemID, Point3D offset, int amount, int hue, int light, string name)
		{
			AddonComponent ac = new AddonComponent(itemID);

			if (ac.Name != null)
			{
				ac.Name = name;
			}

			if (hue > 0)
			{
				ac.Hue = hue;
			}

			if (amount > 1)
			{
				ac.Stackable = true;
				ac.Amount = amount;
			}

			if (light > -1)
			{
				ac.Light = (LightType)light;
			}

			AddComponent(ac, offset.X, offset.Y, offset.Z);
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write(0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.ReadInt();
		}
	}

	public class CornerStairsAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new CornerStairsAddon(); } }

		[Constructable]
		public CornerStairsAddonDeed()
		{
			Name = "Corner Stairs Deed";
		}

		public CornerStairsAddonDeed(Serial serial) 
			: base(serial)
		{ }

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write(0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			reader.ReadInt();
		}
	}
}
