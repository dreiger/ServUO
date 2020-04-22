#region Header
/*
 * Name: AssholeContainmentUnit
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class AssholeContainmentUnitAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(2082, new Point3D(2, 2, 0), 1, 32, 0, (string)null), // 1
			Tuple.Create(2081, new Point3D(2, 1, 0), 1, 32, 0, (string)null), // 2
			Tuple.Create(2081, new Point3D(2, 0, 0), 1, 32, 0, (string)null), // 3
			Tuple.Create(2081, new Point3D(2, -1, 0), 1, 32, 0, (string)null), // 4
			Tuple.Create(2083, new Point3D(2, -2, 0), 1, 32, 0, (string)null), // 5
			Tuple.Create(2083, new Point3D(1, -2, 0), 1, 32, 0, (string)null), // 6
			Tuple.Create(2083, new Point3D(0, -2, 0), 1, 32, 0, (string)null), // 7
			Tuple.Create(2081, new Point3D(-2, -1, 0), 1, 32, 0, (string)null), // 8
			Tuple.Create(2081, new Point3D(-2, 0, 0), 1, 32, 0, (string)null), // 9
			Tuple.Create(2081, new Point3D(-2, 2, 0), 1, 32, 0, (string)null), // 10
			Tuple.Create(2081, new Point3D(-2, 1, 0), 1, 32, 0, (string)null), // 11
			Tuple.Create(2083, new Point3D(-1, -2, 0), 1, 32, 0, (string)null), // 12
			Tuple.Create(2083, new Point3D(1, 2, 0), 1, 32, 0, (string)null), // 13
			Tuple.Create(2083, new Point3D(-1, 2, 0), 1, 32, 0, (string)null), // 14
			Tuple.Create(2083, new Point3D(0, 2, 0), 1, 32, 0, (string)null), // 15
			Tuple.Create(8511, new Point3D(-1, -1, 0), 1, 0, 0, (string)null), // 16
			Tuple.Create(8511, new Point3D(0, -1, 0), 1, 0, 0, (string)null), // 17
			Tuple.Create(8511, new Point3D(1, -1, 0), 1, 0, 0, (string)null), // 18
			Tuple.Create(8511, new Point3D(2, -1, 0), 1, 0, 0, (string)null), // 19
			Tuple.Create(8511, new Point3D(-1, 0, 0), 1, 0, 0, (string)null), // 20
			Tuple.Create(8511, new Point3D(0, 0, 0), 1, 0, 0, (string)null), // 21
			Tuple.Create(8511, new Point3D(1, 0, 0), 1, 0, 0, (string)null), // 22
			Tuple.Create(8511, new Point3D(2, 0, 0), 1, 0, 0, (string)null), // 23
			Tuple.Create(8511, new Point3D(-1, 1, 0), 1, 0, 0, (string)null), // 24
			Tuple.Create(8511, new Point3D(-1, 2, 0), 1, 0, 0, (string)null), // 25
			Tuple.Create(8511, new Point3D(0, 1, 0), 1, 0, 0, (string)null), // 26
			Tuple.Create(8511, new Point3D(1, 1, 0), 1, 0, 0, (string)null), // 27
			Tuple.Create(8511, new Point3D(2, 1, 0), 1, 0, 0, (string)null), // 28
			Tuple.Create(8511, new Point3D(2, 2, 0), 1, 0, 0, (string)null), // 29
			Tuple.Create(8511, new Point3D(1, 2, 0), 1, 0, 0, (string)null), // 30
			Tuple.Create(8511, new Point3D(0, 2, 0), 1, 0, 0, (string)null), // 31
			Tuple.Create(3025, new Point3D(1, 3, 0), 1, 0, 0, "Asshole Containment Unit") // 32
		};
		
		public override BaseAddonDeed Deed { get { return new AssholeContainmentUnitAddonDeed(); } }

		[Constructable]
		public AssholeContainmentUnitAddon()
		{
			Name = "Asshole Containment Unit Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public AssholeContainmentUnitAddon(Serial serial) 
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

	public class AssholeContainmentUnitAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new AssholeContainmentUnitAddon(); } }

		[Constructable]
		public AssholeContainmentUnitAddonDeed()
		{
			Name = "Asshole Containment Unit Deed";
		}

		public AssholeContainmentUnitAddonDeed(Serial serial) 
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
