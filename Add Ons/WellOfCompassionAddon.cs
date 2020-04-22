
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class WellOfCompassionAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {16678, -3, -2, 10}, {16693, -3, -2, 2}, {16693, -1, -2, 4}// 1	2	3	
			, {16693, -2, -2, 4}, {16693, -3, -1, 2}, {16693, -3, 0, 2}// 4	5	6	
			, {16693, 0, -2, 4}, {13422, -2, -1, 12}, {13422, -2, 0, 12}// 7	8	9	
			, {13422, -1, -1, 12}, {13422, -1, 0, 12}, {13422, 0, -1, 12}// 10	11	12	
			, {13422, 0, 0, 12}, {16678, -3, -1, 10}, {16678, -3, 0, 10}// 13	14	15	
			, {16678, -3, -2, 15}, {16678, -3, -1, 15}, {16678, -3, 0, 15}// 16	17	18	
			, {16678, -3, -2, 20}, {13555, 1, -1, 1}, {13555, 1, 0, 2}// 19	20	21	
			, {16693, 1, -2, 0}, {16693, 2, -2, 0}, {16693, 3, -2, 0}// 22	23	24	
			, {13422, 2, -1, 4}, {13422, 3, -1, 4}, {13422, 3, 0, 4}// 25	26	27	
			, {13422, 2, 0, 4}, {13555, -2, -1, 14}, {13555, -2, 0, 14}// 28	29	30	
			, {16678, -2, -2, 12}, {16678, -1, -2, 12}, {16678, 0, -2, 12}// 31	32	33	
			, {16678, 1, -2, 5}, {16678, 2, -2, 5}, {16678, 3, -2, 5}// 34	35	36	
			, {16678, -3, -2, 27}, {16678, -3, -1, 28}, {16678, -3, 0, 28}// 37	38	39	
			, {8131, 0, 0, 13}, {3206, -3, -3, 2}, {18869, -2, -2, 17}// 40	41	42	
			, {18137, 1, -2, 10}, {18137, -1, -2, 17}, {16693, -3, 2, 2}// 43	44	45	
			, {16693, -3, 3, 4}, {16693, -2, 3, 3}, {16678, -3, 3, 10}// 46	47	48	
			, {16693, -3, 1, 2}, {16693, -1, 3, 3}, {16693, 0, 3, 3}// 49	50	51	
			, {13422, -2, 1, 12}, {13422, -2, 2, 12}, {13422, -1, 1, 12}// 52	53	54	
			, {13422, -1, 2, 12}, {13422, 0, 1, 13}, {13422, 0, 2, 13}// 55	56	57	
			, {16678, -3, 1, 10}, {16678, -3, 2, 10}, {16678, -3, 1, 15}// 58	59	60	
			, {16678, -3, 2, 15}, {16678, -3, 3, 15}, {16678, -3, 3, 20}// 61	62	63	
			, {13555, 1, 1, 2}, {13555, 1, 2, 2}, {16693, 1, 3, 0}// 64	65	66	
			, {16693, 2, 3, 0}, {16693, 3, 3, 0}, {13422, 2, 2, 4}// 67	68	69	
			, {13422, 3, 1, 4}, {13422, 3, 2, 4}, {13422, 2, 1, 4}// 70	71	72	
			, {13555, -2, 1, 14}, {13555, -2, 2, 14}, {16678, -2, 3, 12}// 73	74	75	
			, {16678, -1, 3, 12}, {16678, 0, 3, 12}, {16678, 1, 3, 5}// 76	77	78	
			, {16678, 2, 3, 5}, {16678, 3, 3, 5}, {16678, -3, 1, 28}// 79	80	81	
			, {16678, -3, 2, 28}, {16678, -3, 3, 28}, {8131, 0, 1, 14}// 82	83	84	
			, {8131, 0, 2, 14}, {18869, -2, 3, 17}, {18137, 1, 3, 10}// 85	86	87	
			, {18137, -1, 3, 17}, {16693, 4, -2, 0}, {16693, 4, -1, 0}// 88	89	90	
			, {16693, 4, 0, 0}, {16678, 4, -2, 5}, {16678, 4, -1, 5}// 91	92	93	
			, {16678, 4, 0, 5}, {18137, 4, -2, 10}, {16693, 4, 3, 0}// 94	95	96	
			, {16693, 4, 2, 0}, {16693, 4, 1, 0}, {16678, 4, 3, 5}// 97	98	99	
			, {16678, 4, 1, 5}, {16678, 4, 2, 5}, {18137, 4, 3, 10}// 100	101	102	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WellOfCompassionAddonDeed();
			}
		}

		[ Constructable ]
		public WellOfCompassionAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public WellOfCompassionAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class WellOfCompassionAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WellOfCompassionAddon();
			}
		}

		[Constructable]
		public WellOfCompassionAddonDeed()
		{
			Name = "Well Of Compassion";
		}

		public WellOfCompassionAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}