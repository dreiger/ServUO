
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class GroveStableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2187, -1, -2, 0}, {1189, -5, 5, 0}, {1189, -5, 2, 0}// 1	2	3	
			, {1189, -1, 4, 0}, {1189, -2, 2, 0}, {22, -4, 1, 20}// 4	5	6	
			, {2187, -1, -3, 0}, {2899, -3, 2, 0}, {1189, -3, 5, 0}// 7	8	9	
			, {1189, -3, 2, 0}, {1189, -1, 5, 0}, {1189, -1, 2, 0}// 10	11	12	
			, {7, -2, 1, 0}, {7, -3, 1, 0}, {1189, -2, 4, 0}// 13	14	15	
			, {21, -6, 5, 20}, {1189, -2, 5, 0}, {4613, -4, 3, 0}// 16	17	18	
			, {1189, -4, 3, 0}, {1189, -4, 4, 0}, {1189, -4, 2, 0}// 19	20	21	
			, {21, -1, 2, 20}, {1189, -5, 4, 0}, {1189, -1, 3, 0}// 22	23	24	
			, {1189, -3, 3, 0}, {1189, -3, 4, 0}, {1189, -2, 3, 0}// 25	26	27	
			, {1179, -2, 5, 20}, {1189, -4, 5, 0}, {1189, -5, 3, 0}// 28	29	30	
			, {4612, -2, 3, 0}, {12, -1, 1, 0}, {22, -1, 1, 20}// 31	32	33	
			, {22, -2, 1, 20}, {2187, -1, 0, 0}, {2187, -1, -1, 0}// 34	35	36	
			, {2187, -1, 1, 0}, {22, -3, 1, 20}, {22, -5, 1, 20}// 37	38	39	
			, {8, -1, 5, 0}, {8, -1, 2, 0}, {8, -1, 3, 0}// 40	41	42	
			, {7, -4, 1, 0}, {7, -5, 1, 0}, {9, -6, 1, 0}// 43	44	45	
			, {4614, -3, 3, 0}, {8, -6, 3, 0}, {8, -6, 4, 0}// 46	47	48	
			, {8, -6, 2, 0}, {8, -6, 5, 0}, {21, -6, 4, 20}// 49	50	51	
			, {21, -6, 3, 20}, {21, -6, 2, 20}, {1179, -4, 5, 20}// 52	53	54	
			, {1179, -4, 4, 20}, {1179, -4, 3, 20}, {1179, -4, 2, 20}// 55	56	57	
			, {21, -1, 3, 20}, {1179, -3, 5, 20}, {1179, -5, 4, 20}// 58	59	60	
			, {1179, -5, 5, 20}, {1179, -5, 2, 20}, {1179, -5, 3, 20}// 61	62	63	
			, {1179, -3, 2, 20}, {1179, -3, 3, 20}, {21, -1, 5, 20}// 64	65	66	
			, {21, -1, 4, 20}, {1179, -3, 4, 20}, {1179, -1, 5, 20}// 67	68	69	
			, {1179, -1, 3, 20}, {1179, -1, 4, 20}, {1179, -2, 4, 20}// 70	71	72	
			, {1179, -1, 2, 20}, {1179, -2, 3, 20}, {1179, -2, 2, 20}// 73	74	75	
			, {12788, 4, -3, 0}, {2187, 5, -2, 0}, {12788, 7, 4, 0}// 76	77	78	
			, {12788, 7, 5, 0}, {12788, 6, -3, 0}, {2187, 5, -1, 0}// 79	80	81	
			, {2186, 6, 3, 0}, {12788, 5, -2, 0}, {2187, 5, -3, 0}// 82	83	84	
			, {3892, 6, 4, 0}, {2186, 6, -4, 0}, {12788, 5, -1, 0}// 85	86	87	
			, {3892, 5, -1, 0}, {2186, 0, -4, 0}, {3892, 7, -2, 0}// 88	89	90	
			, {12788, 3, -2, 0}, {2186, 5, -4, 0}, {12788, 6, -1, 0}// 91	92	93	
			, {3892, 1, -2, 0}, {2186, 7, 3, 0}, {12788, 7, -3, 0}// 94	95	96	
			, {12788, 7, -2, 0}, {3892, 6, -1, 0}, {12788, 6, 4, 0}// 97	98	99	
			, {3892, 7, 5, 0}, {3896, 0, -2, 0}, {12788, 6, 5, 0}// 100	101	102	
			, {3892, 3, -1, 0}, {2186, 7, -4, 0}, {2186, 1, -4, 0}// 103	104	105	
			, {2187, 2, -1, 0}, {3892, 6, -3, 0}, {12788, 3, -3, 0}// 106	107	108	
			, {3892, 0, -3, 0}, {3892, 4, -3, 0}, {12788, 3, -1, 0}// 109	110	111	
			, {12788, 6, -2, 0}, {2881, 0, 2, 0}, {1301, 4, 5, 0}// 112	113	114	
			, {1301, 5, 5, 0}, {1301, 7, 0, 0}, {12788, 7, -1, 0}// 115	116	117	
			, {12788, 4, -2, 0}, {12788, 5, -3, 0}, {12788, 4, -1, 0}// 118	119	120	
			, {2186, 3, -4, 0}, {2186, 4, -4, 0}, {3896, 6, -2, 0}// 121	122	123	
			, {3896, 3, -2, 0}, {2186, 2, -4, 0}, {12788, 1, -3, 0}// 124	125	126	
			, {12788, 0, -2, 0}, {12788, 1, -2, 0}, {12788, 0, -3, 0}// 127	128	129	
			, {2187, 2, -2, 0}, {2187, 2, -3, 0}, {12788, 1, -1, 0}// 130	131	132	
			, {12788, 0, -1, 0}, {12788, 2, -1, 0}, {12788, 2, -2, 0}// 133	134	135	
			, {12788, 2, -3, 0}, {3892, 0, -1, 0}, {1301, 7, 1, 0}// 136	137	138	
			, {1301, 0, 4, 0}, {1301, 1, 4, 0}, {1301, 2, 4, 0}// 139	140	141	
			, {1301, 3, 4, 0}, {1301, 4, 4, 0}, {1301, 4, 3, 0}// 142	143	144	
			, {1301, 2, 1, 0}, {1301, 3, 3, 0}, {1301, 4, 2, 0}// 145	146	147	
			, {1301, 3, 2, 0}, {1301, 3, 1, 0}, {1301, 4, 1, 0}// 148	149	150	
			, {1301, 4, 0, 0}, {1301, 1, 1, 0}, {1301, 1, 0, 0}// 151	152	153	
			, {1301, 5, 1, 0}, {1301, 6, 1, 0}, {2882, 0, 3, 0}// 154	155	156	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GroveStableAddonDeed();
			}
		}

		[ Constructable ]
		public GroveStableAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GroveStableAddon( Serial serial ) : base( serial )
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

	public class GroveStableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GroveStableAddon();
			}
		}

		[Constructable]
		public GroveStableAddonDeed()
		{
			Name = "GroveStable";
		}

		public GroveStableAddonDeed( Serial serial ) : base( serial )
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