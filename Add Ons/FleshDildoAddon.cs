#region Header
/*
 * Name: FleshDildo
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class FleshDildoAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(6202, new Point3D(0, 0, 0), 1, 648, 0, "A Dildo") // 1
		};
		
		public override BaseAddonDeed Deed { get { return new FleshDildoAddonDeed(); } }

		[Constructable]
		public FleshDildoAddon()
		{
			Name = "FleshDildo Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public FleshDildoAddon(Serial serial) 
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

	public class FleshDildoAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new FleshDildoAddon(); } }

		[Constructable]
		public FleshDildoAddonDeed()
		{
			Name = "Flesh Dildo Deed";
		}

		public FleshDildoAddonDeed(Serial serial) 
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
