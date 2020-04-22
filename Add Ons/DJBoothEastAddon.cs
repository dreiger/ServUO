#region Header
/*
 * Name: DJBoothEast
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class DJBoothEastAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(30727, new Point3D(2, -4, 0), 1, 997, 0, "QSC Speaker"), // 1
			Tuple.Create(30727, new Point3D(2, -4, 5), 1, 997, 0, "QSC Speaker"), // 2
			Tuple.Create(30727, new Point3D(-2, -3, 0), 1, 1172, 0, (string)null), // 3
			Tuple.Create(30727, new Point3D(-1, -3, 0), 1, 1172, 0, (string)null), // 4
			Tuple.Create(30727, new Point3D(0, -3, 0), 1, 1172, 0, (string)null), // 5
			Tuple.Create(30727, new Point3D(1, -3, 0), 1, 1172, 0, (string)null), // 6
			Tuple.Create(30727, new Point3D(1, -2, 0), 1, 1172, 0, (string)null), // 7
			Tuple.Create(30727, new Point3D(1, 0, 0), 1, 1172, 0, (string)null), // 8
			Tuple.Create(30727, new Point3D(1, -1, 0), 1, 1172, 0, (string)null), // 9
			Tuple.Create(30727, new Point3D(1, 1, 0), 1, 0, 0, (string)null), // 10
			Tuple.Create(30727, new Point3D(1, 2, 0), 1, 1172, 0, (string)null), // 11
			Tuple.Create(30727, new Point3D(1, 3, 0), 1, 1172, 0, (string)null), // 12
			Tuple.Create(30727, new Point3D(0, 3, 0), 1, 1172, 0, (string)null), // 13
			Tuple.Create(30727, new Point3D(-1, 3, 0), 1, 1172, 0, (string)null), // 14
			Tuple.Create(30727, new Point3D(1, 1, 0), 1, 1172, 0, (string)null), // 15
			Tuple.Create(30727, new Point3D(1, -1, 2), 1, 1172, 0, (string)null), // 16
			Tuple.Create(30727, new Point3D(1, 1, 2), 1, 1172, 0, (string)null), // 17
			Tuple.Create(30727, new Point3D(2, 4, 0), 1, 997, 0, "QSC Speaker"), // 18
			Tuple.Create(10178, new Point3D(1, 1, 7), 1, 2927, 0, "Technics 1200 Turntable"), // 19
			Tuple.Create(10178, new Point3D(1, -1, 7), 1, 2927, 0, "Technics 1200 Turntable"), // 20
			Tuple.Create(10292, new Point3D(1, 0, 5), 1, 2927, 0, "Pioneer DJM-2000 Nexus Mixer"), // 21
			Tuple.Create(30727, new Point3D(2, 4, 5), 1, 997, 0, "QSC Speaker") // 22
		};
		
		public override BaseAddonDeed Deed { get { return new DJBoothEastAddonDeed(); } }

		[Constructable]
		public DJBoothEastAddon()
		{
			Name = "DJBoothEast Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public DJBoothEastAddon(Serial serial) 
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

	public class DJBoothEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new DJBoothEastAddon(); } }

		[Constructable]
		public DJBoothEastAddonDeed()
		{
			Name = "DJ Booth East Deed";
		}

		public DJBoothEastAddonDeed(Serial serial) 
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
