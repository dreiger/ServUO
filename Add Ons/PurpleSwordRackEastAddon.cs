#region Header
/*
 * Name: PurpleSwordRackEast
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class PurpleSwordRackEastAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(10524, new Point3D(0, 0, 0), 1, 0, 0, (string)null) // 1
		};
		
		public override BaseAddonDeed Deed { get { return new PurpleSwordRackEastAddonDeed(); } }

		[Constructable]
		public PurpleSwordRackEastAddon()
		{
			Name = "PurpleSwordRackEast Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public PurpleSwordRackEastAddon(Serial serial) 
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

	public class PurpleSwordRackEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new PurpleSwordRackEastAddon(); } }

		[Constructable]
		public PurpleSwordRackEastAddonDeed()
		{
			Name = "Purple Sword Rack East Deed";
		}

		public PurpleSwordRackEastAddonDeed(Serial serial) 
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
