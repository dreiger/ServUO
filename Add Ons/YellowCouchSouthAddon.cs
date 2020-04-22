#region Header
/*
 * Name: YellowCouchSouth
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class YellowCouchSouthAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(1978, new Point3D(-3, 1, 0), 1, 53, 0, (string)null), // 1
			Tuple.Create(1978, new Point3D(-1, 0, 0), 1, 53, 0, (string)null), // 2
			Tuple.Create(1978, new Point3D(0, 0, 0), 1, 53, 0, (string)null), // 3
			Tuple.Create(1978, new Point3D(1, 0, 0), 1, 53, 0, (string)null), // 4
			Tuple.Create(1978, new Point3D(2, 0, 0), 1, 53, 0, (string)null), // 5
			Tuple.Create(1978, new Point3D(3, 1, 0), 1, 53, 0, (string)null), // 6
			Tuple.Create(1978, new Point3D(3, 0, 0), 1, 53, 0, (string)null), // 7
			Tuple.Create(1978, new Point3D(-3, 0, 0), 1, 53, 0, (string)null), // 8
			Tuple.Create(1978, new Point3D(-2, 0, 0), 1, 53, 0, (string)null), // 9
			Tuple.Create(5029, new Point3D(-3, 0, 5), 1, 53, 0, (string)null), // 10
			Tuple.Create(5029, new Point3D(-2, 0, 5), 1, 53, 0, (string)null), // 11
			Tuple.Create(5029, new Point3D(-1, 0, 5), 1, 53, 0, (string)null), // 12
			Tuple.Create(5029, new Point3D(0, 0, 5), 1, 53, 0, (string)null), // 13
			Tuple.Create(5029, new Point3D(1, 0, 5), 1, 53, 0, (string)null), // 14
			Tuple.Create(5029, new Point3D(2, 0, 5), 1, 53, 0, (string)null), // 15
			Tuple.Create(5029, new Point3D(3, 0, 5), 1, 53, 0, (string)null), // 16
			Tuple.Create(5028, new Point3D(-3, 1, 5), 1, 53, 0, (string)null), // 17
			Tuple.Create(5028, new Point3D(3, 1, 5), 1, 53, 0, (string)null) // 18
		};
		
		public override BaseAddonDeed Deed { get { return new YellowCouchSouthAddonDeed(); } }

		[Constructable]
		public YellowCouchSouthAddon()
		{
			Name = "YellowCouchSouth Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public YellowCouchSouthAddon(Serial serial) 
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

	public class YellowCouchSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new YellowCouchSouthAddon(); } }

		[Constructable]
		public YellowCouchSouthAddonDeed()
		{
			Name = "Yellow Couch South Deed";
		}

		public YellowCouchSouthAddonDeed(Serial serial) 
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
