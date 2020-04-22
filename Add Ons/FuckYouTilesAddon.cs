#region Header
/*
 * Name: FuckYouTiles
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class FuckYouTilesAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(1180, new Point3D(-8, -9, 0), 1, 32, 0, (string)null), // 1
			Tuple.Create(1180, new Point3D(-8, -8, 0), 1, 32, 0, (string)null), // 2
			Tuple.Create(1180, new Point3D(-8, -7, 0), 1, 32, 0, (string)null), // 3
			Tuple.Create(1180, new Point3D(-8, -6, 0), 1, 32, 0, (string)null), // 4
			Tuple.Create(1180, new Point3D(-8, -5, 0), 1, 32, 0, (string)null), // 5
			Tuple.Create(1180, new Point3D(-8, -4, 0), 1, 32, 0, (string)null), // 6
			Tuple.Create(1180, new Point3D(-8, -3, 0), 1, 32, 0, (string)null), // 7
			Tuple.Create(1180, new Point3D(-8, -2, 0), 1, 32, 0, (string)null), // 8
			Tuple.Create(1180, new Point3D(-8, -1, 0), 1, 32, 0, (string)null), // 9
			Tuple.Create(1180, new Point3D(-8, 0, 0), 1, 32, 0, (string)null), // 10
			Tuple.Create(1180, new Point3D(-7, -9, 0), 1, 32, 0, (string)null), // 11
			Tuple.Create(1180, new Point3D(-6, -9, 0), 1, 32, 0, (string)null), // 12
			Tuple.Create(1180, new Point3D(-5, -9, 0), 1, 32, 0, (string)null), // 13
			Tuple.Create(1180, new Point3D(-4, -9, 0), 1, 32, 0, (string)null), // 14
			Tuple.Create(1180, new Point3D(-7, -5, 0), 1, 32, 0, (string)null), // 15
			Tuple.Create(1180, new Point3D(-6, -5, 0), 1, 32, 0, (string)null), // 16
			Tuple.Create(1180, new Point3D(-4, -5, 0), 1, 32, 0, (string)null), // 17
			Tuple.Create(1180, new Point3D(-4, -3, 0), 1, 32, 0, (string)null), // 18
			Tuple.Create(1180, new Point3D(-4, -4, 0), 1, 32, 0, (string)null), // 19
			Tuple.Create(1180, new Point3D(-4, -2, 0), 1, 32, 0, (string)null), // 20
			Tuple.Create(1180, new Point3D(-4, -1, 0), 1, 32, 0, (string)null), // 21
			Tuple.Create(1180, new Point3D(-4, 0, 0), 1, 32, 0, (string)null), // 22
			Tuple.Create(1180, new Point3D(-3, 0, 0), 1, 32, 0, (string)null), // 23
			Tuple.Create(1180, new Point3D(-2, 0, 0), 1, 32, 0, (string)null), // 24
			Tuple.Create(1180, new Point3D(-1, 0, 0), 1, 32, 0, (string)null), // 25
			Tuple.Create(1180, new Point3D(-1, -1, 0), 1, 32, 0, (string)null), // 26
			Tuple.Create(1180, new Point3D(-1, -2, 0), 1, 32, 0, (string)null), // 27
			Tuple.Create(1180, new Point3D(-1, -4, 0), 1, 32, 0, (string)null), // 28
			Tuple.Create(1180, new Point3D(-1, -3, 0), 1, 32, 0, (string)null), // 29
			Tuple.Create(1180, new Point3D(-1, -5, 0), 1, 32, 0, (string)null), // 30
			Tuple.Create(1180, new Point3D(1, -5, 0), 1, 32, 0, (string)null), // 31
			Tuple.Create(1180, new Point3D(1, -3, 0), 1, 32, 0, (string)null), // 32
			Tuple.Create(1180, new Point3D(1, -2, 0), 1, 32, 0, (string)null), // 33
			Tuple.Create(1180, new Point3D(1, 0, 0), 1, 32, 0, (string)null), // 34
			Tuple.Create(1180, new Point3D(1, -4, 0), 1, 32, 0, (string)null), // 35
			Tuple.Create(1180, new Point3D(1, -1, 0), 1, 32, 0, (string)null), // 36
			Tuple.Create(1180, new Point3D(-2, 3, 0), 1, 32, 0, (string)null), // 37
			Tuple.Create(1180, new Point3D(-2, 5, 0), 1, 32, 0, (string)null), // 38
			Tuple.Create(1180, new Point3D(-2, 6, 0), 1, 32, 0, (string)null), // 39
			Tuple.Create(1180, new Point3D(-2, 7, 0), 1, 32, 0, (string)null), // 40
			Tuple.Create(1180, new Point3D(-2, 4, 0), 1, 32, 0, (string)null), // 41
			Tuple.Create(1180, new Point3D(-2, 9, 0), 1, 32, 0, (string)null), // 42
			Tuple.Create(1180, new Point3D(-2, 8, 0), 1, 32, 0, (string)null), // 43
			Tuple.Create(1180, new Point3D(-1, 9, 0), 1, 32, 0, (string)null), // 44
			Tuple.Create(1180, new Point3D(-1, 9, 0), 1, 32, 0, (string)null), // 45
			Tuple.Create(1180, new Point3D(0, 9, 0), 1, 32, 0, (string)null), // 46
			Tuple.Create(1180, new Point3D(1, 9, 0), 1, 32, 0, (string)null), // 47
			Tuple.Create(1180, new Point3D(1, 8, 0), 1, 32, 0, (string)null), // 48
			Tuple.Create(1180, new Point3D(1, 7, 0), 1, 32, 0, (string)null), // 49
			Tuple.Create(1180, new Point3D(1, 6, 0), 1, 32, 0, (string)null), // 50
			Tuple.Create(1180, new Point3D(1, 5, 0), 1, 32, 0, (string)null), // 51
			Tuple.Create(1180, new Point3D(1, 4, 0), 1, 32, 0, (string)null), // 52
			Tuple.Create(1180, new Point3D(1, 3, 0), 1, 32, 0, (string)null), // 53
			Tuple.Create(1180, new Point3D(2, -5, 0), 1, 32, 0, (string)null), // 54
			Tuple.Create(1180, new Point3D(3, -5, 0), 1, 32, 0, (string)null), // 55
			Tuple.Create(1180, new Point3D(2, 0, 0), 1, 32, 0, (string)null), // 56
			Tuple.Create(1180, new Point3D(3, 0, 0), 1, 32, 0, (string)null), // 57
			Tuple.Create(1180, new Point3D(5, 0, 0), 1, 32, 0, (string)null), // 58
			Tuple.Create(1180, new Point3D(5, -1, 0), 1, 32, 0, (string)null), // 59
			Tuple.Create(1180, new Point3D(5, -3, 0), 1, 32, 0, (string)null), // 60
			Tuple.Create(1180, new Point3D(5, -2, 0), 1, 32, 0, (string)null), // 61
			Tuple.Create(1180, new Point3D(5, -4, 0), 1, 32, 0, (string)null), // 62
			Tuple.Create(1180, new Point3D(5, -5, 0), 1, 32, 0, (string)null), // 63
			Tuple.Create(1180, new Point3D(5, -6, 0), 1, 32, 0, (string)null), // 64
			Tuple.Create(1180, new Point3D(5, -7, 0), 1, 32, 0, (string)null), // 65
			Tuple.Create(1180, new Point3D(5, -8, 0), 1, 32, 0, (string)null), // 66
			Tuple.Create(1180, new Point3D(5, -9, 0), 1, 32, 0, (string)null), // 67
			Tuple.Create(1180, new Point3D(6, -3, 0), 1, 32, 0, (string)null), // 68
			Tuple.Create(1180, new Point3D(7, -4, 0), 1, 32, 0, (string)null), // 69
			Tuple.Create(1180, new Point3D(8, -5, 0), 1, 32, 0, (string)null), // 70
			Tuple.Create(1180, new Point3D(7, -2, 0), 1, 32, 0, (string)null), // 71
			Tuple.Create(1180, new Point3D(8, -1, 0), 1, 32, 0, (string)null), // 72
			Tuple.Create(1180, new Point3D(9, 0, 0), 1, 32, 0, (string)null) // 73
		};
		
		public override BaseAddonDeed Deed { get { return new FuckYouTilesAddonDeed(); } }

		[Constructable]
		public FuckYouTilesAddon()
		{
			Name = "FuckYouTiles Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public FuckYouTilesAddon(Serial serial) 
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

	public class FuckYouTilesAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new FuckYouTilesAddon(); } }

		[Constructable]
		public FuckYouTilesAddonDeed()
		{
			Name = "Fuck You Tiles Deed";
		}

		public FuckYouTilesAddonDeed(Serial serial) 
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
