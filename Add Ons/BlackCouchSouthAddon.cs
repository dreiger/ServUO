﻿#region Header
/*
 * Name: BlackCouchSouth
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class BlackCouchSouthAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(19598, new Point3D(-1, 0, 0), 1, 0, 0, (string)null), // 1
			Tuple.Create(19597, new Point3D(0, 0, 0), 1, 0, 0, (string)null), // 2
			Tuple.Create(19599, new Point3D(1, 0, 0), 1, 0, 0, (string)null) // 3
		};
		
		public override BaseAddonDeed Deed { get { return new BlackCouchSouthAddonDeed(); } }

		[Constructable]
		public BlackCouchSouthAddon()
		{
			Name = "BlackCouchSouth Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public BlackCouchSouthAddon(Serial serial) 
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

	public class BlackCouchSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new BlackCouchSouthAddon(); } }

		[Constructable]
		public BlackCouchSouthAddonDeed()
		{
			Name = "Black Couch South Deed";
		}

		public BlackCouchSouthAddonDeed(Serial serial) 
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
