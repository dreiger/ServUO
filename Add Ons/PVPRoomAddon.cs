#region Header
/*
 * Name: PVPRoom
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class PVPRoomAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(2083, new Point3D(-15, -12, 0), 1, 0, 0, (string)null), // 1
			Tuple.Create(2083, new Point3D(-14, -12, 0), 1, 0, 0, (string)null), // 2
			Tuple.Create(2083, new Point3D(-13, -12, 0), 1, 0, 0, (string)null), // 3
			Tuple.Create(2083, new Point3D(-12, -12, 0), 1, 0, 0, (string)null), // 4
			Tuple.Create(2083, new Point3D(-11, -12, 0), 1, 0, 0, (string)null), // 5
			Tuple.Create(2083, new Point3D(-10, -12, 0), 1, 0, 0, (string)null), // 6
			Tuple.Create(2083, new Point3D(-9, -12, 0), 1, 0, 0, (string)null), // 7
			Tuple.Create(2083, new Point3D(-8, -12, 0), 1, 0, 0, (string)null), // 8
			Tuple.Create(1339, new Point3D(-15, -11, 0), 1, 32, 0, (string)null), // 9
			Tuple.Create(1339, new Point3D(-15, -10, 0), 1, 32, 0, (string)null), // 10
			Tuple.Create(1339, new Point3D(-15, -9, 0), 1, 32, 0, (string)null), // 11
			Tuple.Create(1339, new Point3D(-15, -8, 0), 1, 32, 0, (string)null), // 12
			Tuple.Create(1339, new Point3D(-15, -7, 0), 1, 32, 0, (string)null), // 13
			Tuple.Create(1339, new Point3D(-15, -6, 0), 1, 32, 0, (string)null), // 14
			Tuple.Create(1339, new Point3D(-15, -5, 0), 1, 32, 0, (string)null), // 15
			Tuple.Create(1339, new Point3D(-15, -4, 0), 1, 32, 0, (string)null), // 16
			Tuple.Create(1339, new Point3D(-15, -3, 0), 1, 32, 0, (string)null), // 17
			Tuple.Create(1339, new Point3D(-15, -2, 0), 1, 32, 0, (string)null), // 18
			Tuple.Create(1339, new Point3D(-15, -1, 0), 1, 32, 0, (string)null), // 19
			Tuple.Create(1339, new Point3D(-15, 0, 0), 1, 32, 0, (string)null), // 20
			Tuple.Create(1339, new Point3D(-15, 1, 0), 1, 32, 0, (string)null), // 21
			Tuple.Create(1339, new Point3D(-15, 2, 0), 1, 32, 0, (string)null), // 22
			Tuple.Create(1339, new Point3D(-15, 3, 0), 1, 32, 0, (string)null), // 23
			Tuple.Create(1339, new Point3D(-15, 4, 0), 1, 32, 0, (string)null), // 24
			Tuple.Create(1339, new Point3D(-14, -11, 0), 1, 32, 0, (string)null), // 25
			Tuple.Create(1339, new Point3D(-14, -10, 0), 1, 32, 0, (string)null), // 26
			Tuple.Create(1339, new Point3D(-14, -9, 0), 1, 32, 0, (string)null), // 27
			Tuple.Create(1339, new Point3D(-14, -8, 0), 1, 32, 0, (string)null), // 28
			Tuple.Create(1339, new Point3D(-14, -7, 0), 1, 32, 0, (string)null), // 29
			Tuple.Create(1339, new Point3D(-14, -6, 0), 1, 32, 0, (string)null), // 30
			Tuple.Create(1339, new Point3D(-14, -5, 0), 1, 32, 0, (string)null), // 31
			Tuple.Create(1339, new Point3D(-14, -4, 0), 1, 32, 0, (string)null), // 32
			Tuple.Create(1339, new Point3D(-14, -3, 0), 1, 32, 0, (string)null), // 33
			Tuple.Create(1339, new Point3D(-14, -2, 0), 1, 32, 0, (string)null), // 34
			Tuple.Create(1339, new Point3D(-14, -1, 0), 1, 32, 0, (string)null), // 35
			Tuple.Create(1339, new Point3D(-14, 0, 0), 1, 32, 0, (string)null), // 36
			Tuple.Create(1339, new Point3D(-14, 1, 0), 1, 32, 0, (string)null), // 37
			Tuple.Create(1339, new Point3D(-14, 2, 0), 1, 32, 0, (string)null), // 38
			Tuple.Create(1339, new Point3D(-14, 3, 0), 1, 32, 0, (string)null), // 39
			Tuple.Create(1339, new Point3D(-14, 4, 0), 1, 32, 0, (string)null), // 40
			Tuple.Create(1339, new Point3D(-13, -11, 0), 1, 32, 0, (string)null), // 41
			Tuple.Create(1339, new Point3D(-13, -10, 0), 1, 32, 0, (string)null), // 42
			Tuple.Create(1339, new Point3D(-13, -9, 0), 1, 32, 0, (string)null), // 43
			Tuple.Create(1339, new Point3D(-13, -8, 0), 1, 32, 0, (string)null), // 44
			Tuple.Create(1339, new Point3D(-13, -7, 0), 1, 32, 0, (string)null), // 45
			Tuple.Create(1339, new Point3D(-13, -6, 0), 1, 32, 0, (string)null), // 46
			Tuple.Create(1339, new Point3D(-13, -5, 0), 1, 32, 0, (string)null), // 47
			Tuple.Create(1339, new Point3D(-13, -4, 0), 1, 32, 0, (string)null), // 48
			Tuple.Create(1339, new Point3D(-13, -3, 0), 1, 32, 0, (string)null), // 49
			Tuple.Create(1339, new Point3D(-13, -2, 0), 1, 32, 0, (string)null), // 50
			Tuple.Create(1339, new Point3D(-13, -1, 0), 1, 32, 0, (string)null), // 51
			Tuple.Create(1339, new Point3D(-13, 0, 0), 1, 32, 0, (string)null), // 52
			Tuple.Create(1339, new Point3D(-13, 1, 0), 1, 32, 0, (string)null), // 53
			Tuple.Create(1339, new Point3D(-13, 2, 0), 1, 32, 0, (string)null), // 54
			Tuple.Create(1339, new Point3D(-13, 3, 0), 1, 32, 0, (string)null), // 55
			Tuple.Create(1339, new Point3D(-13, 4, 0), 1, 32, 0, (string)null), // 56
			Tuple.Create(1339, new Point3D(-12, -11, 0), 1, 32, 0, (string)null), // 57
			Tuple.Create(1339, new Point3D(-12, -10, 0), 1, 32, 0, (string)null), // 58
			Tuple.Create(1339, new Point3D(-12, -9, 0), 1, 32, 0, (string)null), // 59
			Tuple.Create(1339, new Point3D(-12, -8, 0), 1, 32, 0, (string)null), // 60
			Tuple.Create(1339, new Point3D(-12, -7, 0), 1, 32, 0, (string)null), // 61
			Tuple.Create(1339, new Point3D(-12, -6, 0), 1, 32, 0, (string)null), // 62
			Tuple.Create(1339, new Point3D(-12, -5, 0), 1, 32, 0, (string)null), // 63
			Tuple.Create(1339, new Point3D(-12, -4, 0), 1, 32, 0, (string)null), // 64
			Tuple.Create(1339, new Point3D(-12, -3, 0), 1, 32, 0, (string)null), // 65
			Tuple.Create(1339, new Point3D(-12, -2, 0), 1, 32, 0, (string)null), // 66
			Tuple.Create(1339, new Point3D(-12, -1, 0), 1, 32, 0, (string)null), // 67
			Tuple.Create(1339, new Point3D(-12, 0, 0), 1, 32, 0, (string)null), // 68
			Tuple.Create(1339, new Point3D(-12, 1, 0), 1, 32, 0, (string)null), // 69
			Tuple.Create(1339, new Point3D(-12, 2, 0), 1, 32, 0, (string)null), // 70
			Tuple.Create(1339, new Point3D(-12, 3, 0), 1, 32, 0, (string)null), // 71
			Tuple.Create(1339, new Point3D(-12, 4, 0), 1, 32, 0, (string)null), // 72
			Tuple.Create(1339, new Point3D(-11, -11, 0), 1, 32, 0, (string)null), // 73
			Tuple.Create(1339, new Point3D(-11, -10, 0), 1, 32, 0, (string)null), // 74
			Tuple.Create(1339, new Point3D(-11, -9, 0), 1, 32, 0, (string)null), // 75
			Tuple.Create(1339, new Point3D(-11, -8, 0), 1, 32, 0, (string)null), // 76
			Tuple.Create(1339, new Point3D(-11, -7, 0), 1, 32, 0, (string)null), // 77
			Tuple.Create(1339, new Point3D(-11, -6, 0), 1, 32, 0, (string)null), // 78
			Tuple.Create(1339, new Point3D(-11, -5, 0), 1, 32, 0, (string)null), // 79
			Tuple.Create(1339, new Point3D(-11, -4, 0), 1, 32, 0, (string)null), // 80
			Tuple.Create(1339, new Point3D(-11, -3, 0), 1, 32, 0, (string)null), // 81
			Tuple.Create(1339, new Point3D(-11, -2, 0), 1, 32, 0, (string)null), // 82
			Tuple.Create(1339, new Point3D(-11, -1, 0), 1, 32, 0, (string)null), // 83
			Tuple.Create(1339, new Point3D(-11, 0, 0), 1, 32, 0, (string)null), // 84
			Tuple.Create(1339, new Point3D(-11, 1, 0), 1, 32, 0, (string)null), // 85
			Tuple.Create(1339, new Point3D(-11, 2, 0), 1, 32, 0, (string)null), // 86
			Tuple.Create(1339, new Point3D(-11, 3, 0), 1, 32, 0, (string)null), // 87
			Tuple.Create(1339, new Point3D(-11, 4, 0), 1, 32, 0, (string)null), // 88
			Tuple.Create(1339, new Point3D(-10, -11, 0), 1, 32, 0, (string)null), // 89
			Tuple.Create(1339, new Point3D(-10, -10, 0), 1, 32, 0, (string)null), // 90
			Tuple.Create(1339, new Point3D(-10, -9, 0), 1, 32, 0, (string)null), // 91
			Tuple.Create(1339, new Point3D(-10, -8, 0), 1, 32, 0, (string)null), // 92
			Tuple.Create(1339, new Point3D(-10, -7, 0), 1, 32, 0, (string)null), // 93
			Tuple.Create(1339, new Point3D(-10, -6, 0), 1, 32, 0, (string)null), // 94
			Tuple.Create(1339, new Point3D(-10, -5, 0), 1, 32, 0, (string)null), // 95
			Tuple.Create(1339, new Point3D(-10, -4, 0), 1, 32, 0, (string)null), // 96
			Tuple.Create(1339, new Point3D(-10, -3, 0), 1, 32, 0, (string)null), // 97
			Tuple.Create(1339, new Point3D(-10, -2, 0), 1, 32, 0, (string)null), // 98
			Tuple.Create(1339, new Point3D(-10, -1, 0), 1, 32, 0, (string)null), // 99
			Tuple.Create(1339, new Point3D(-10, 0, 0), 1, 32, 0, (string)null), // 100
			Tuple.Create(1339, new Point3D(-10, 1, 0), 1, 32, 0, (string)null), // 101
			Tuple.Create(1339, new Point3D(-10, 2, 0), 1, 32, 0, (string)null), // 102
			Tuple.Create(1339, new Point3D(-10, 3, 0), 1, 32, 0, (string)null), // 103
			Tuple.Create(1339, new Point3D(-10, 4, 0), 1, 32, 0, (string)null), // 104
			Tuple.Create(1339, new Point3D(-9, -11, 0), 1, 32, 0, (string)null), // 105
			Tuple.Create(1339, new Point3D(-9, -10, 0), 1, 32, 0, (string)null), // 106
			Tuple.Create(1339, new Point3D(-9, -9, 0), 1, 32, 0, (string)null), // 107
			Tuple.Create(1339, new Point3D(-9, -8, 0), 1, 32, 0, (string)null), // 108
			Tuple.Create(1339, new Point3D(-9, -7, 0), 1, 32, 0, (string)null), // 109
			Tuple.Create(1339, new Point3D(-9, -6, 0), 1, 32, 0, (string)null), // 110
			Tuple.Create(1339, new Point3D(-9, -5, 0), 1, 32, 0, (string)null), // 111
			Tuple.Create(1339, new Point3D(-9, -4, 0), 1, 32, 0, (string)null), // 112
			Tuple.Create(1339, new Point3D(-9, -3, 0), 1, 32, 0, (string)null), // 113
			Tuple.Create(1339, new Point3D(-9, -2, 0), 1, 32, 0, (string)null), // 114
			Tuple.Create(1339, new Point3D(-9, -1, 0), 1, 32, 0, (string)null), // 115
			Tuple.Create(1339, new Point3D(-9, 0, 0), 1, 32, 0, (string)null), // 116
			Tuple.Create(1339, new Point3D(-9, 1, 0), 1, 32, 0, (string)null), // 117
			Tuple.Create(1339, new Point3D(-9, 2, 0), 1, 32, 0, (string)null), // 118
			Tuple.Create(1339, new Point3D(-9, 3, 0), 1, 32, 0, (string)null), // 119
			Tuple.Create(1339, new Point3D(-9, 4, 0), 1, 32, 0, (string)null), // 120
			Tuple.Create(1339, new Point3D(-8, -11, 0), 1, 32, 0, (string)null), // 121
			Tuple.Create(1339, new Point3D(-8, -10, 0), 1, 32, 0, (string)null), // 122
			Tuple.Create(1339, new Point3D(-8, -9, 0), 1, 32, 0, (string)null), // 123
			Tuple.Create(1339, new Point3D(-8, -8, 0), 1, 32, 0, (string)null), // 124
			Tuple.Create(1339, new Point3D(-8, -7, 0), 1, 32, 0, (string)null), // 125
			Tuple.Create(1339, new Point3D(-8, -6, 0), 1, 32, 0, (string)null), // 126
			Tuple.Create(1339, new Point3D(-8, -5, 0), 1, 32, 0, (string)null), // 127
			Tuple.Create(1339, new Point3D(-8, -4, 0), 1, 32, 0, (string)null), // 128
			Tuple.Create(1339, new Point3D(-8, -3, 0), 1, 32, 0, (string)null), // 129
			Tuple.Create(1339, new Point3D(-8, -2, 0), 1, 32, 0, (string)null), // 130
			Tuple.Create(1339, new Point3D(-8, -1, 0), 1, 32, 0, (string)null), // 131
			Tuple.Create(1339, new Point3D(-8, 0, 0), 1, 32, 0, (string)null), // 132
			Tuple.Create(1339, new Point3D(-8, 1, 0), 1, 32, 0, (string)null), // 133
			Tuple.Create(1339, new Point3D(-8, 2, 0), 1, 32, 0, (string)null), // 134
			Tuple.Create(1339, new Point3D(-8, 3, 0), 1, 32, 0, (string)null), // 135
			Tuple.Create(1339, new Point3D(-8, 4, 0), 1, 32, 0, (string)null), // 136
			Tuple.Create(2081, new Point3D(-16, -11, 0), 1, 0, 0, (string)null), // 137
			Tuple.Create(2081, new Point3D(-16, -10, 0), 1, 0, 0, (string)null), // 138
			Tuple.Create(2081, new Point3D(-16, -9, 0), 1, 0, 0, (string)null), // 139
			Tuple.Create(2081, new Point3D(-16, -8, 0), 1, 0, 0, (string)null), // 140
			Tuple.Create(2081, new Point3D(-16, -7, 0), 1, 0, 0, (string)null), // 141
			Tuple.Create(2081, new Point3D(-16, -6, 0), 1, 0, 0, (string)null), // 142
			Tuple.Create(2081, new Point3D(-16, -5, 0), 1, 0, 0, (string)null), // 143
			Tuple.Create(2081, new Point3D(-16, -4, 0), 1, 0, 0, (string)null), // 144
			Tuple.Create(2081, new Point3D(-16, -3, 0), 1, 0, 0, (string)null), // 145
			Tuple.Create(2081, new Point3D(-16, -2, 0), 1, 0, 0, (string)null), // 146
			Tuple.Create(2081, new Point3D(-16, -1, 0), 1, 0, 0, (string)null), // 147
			Tuple.Create(2081, new Point3D(-16, 0, 0), 1, 0, 0, (string)null), // 148
			Tuple.Create(2081, new Point3D(-16, 1, 0), 1, 0, 0, (string)null), // 149
			Tuple.Create(2081, new Point3D(-16, 2, 0), 1, 0, 0, (string)null), // 150
			Tuple.Create(2081, new Point3D(-16, 3, 0), 1, 0, 0, (string)null), // 151
			Tuple.Create(2081, new Point3D(-16, 4, 0), 1, 0, 0, (string)null), // 152
			Tuple.Create(1339, new Point3D(-15, 5, 0), 1, 32, 0, (string)null), // 153
			Tuple.Create(1339, new Point3D(-15, 6, 0), 1, 32, 0, (string)null), // 154
			Tuple.Create(1339, new Point3D(-15, 7, 0), 1, 32, 0, (string)null), // 155
			Tuple.Create(1339, new Point3D(-15, 8, 0), 1, 32, 0, (string)null), // 156
			Tuple.Create(1339, new Point3D(-15, 9, 0), 1, 32, 0, (string)null), // 157
			Tuple.Create(1339, new Point3D(-15, 10, 0), 1, 32, 0, (string)null), // 158
			Tuple.Create(1339, new Point3D(-15, 11, 0), 1, 32, 0, (string)null), // 159
			Tuple.Create(1339, new Point3D(-15, 12, 0), 1, 32, 0, (string)null), // 160
			Tuple.Create(1339, new Point3D(-14, 5, 0), 1, 32, 0, (string)null), // 161
			Tuple.Create(1339, new Point3D(-14, 6, 0), 1, 32, 0, (string)null), // 162
			Tuple.Create(1339, new Point3D(-14, 7, 0), 1, 32, 0, (string)null), // 163
			Tuple.Create(1339, new Point3D(-14, 8, 0), 1, 32, 0, (string)null), // 164
			Tuple.Create(1339, new Point3D(-14, 9, 0), 1, 32, 0, (string)null), // 165
			Tuple.Create(1339, new Point3D(-14, 10, 0), 1, 32, 0, (string)null), // 166
			Tuple.Create(1339, new Point3D(-14, 11, 0), 1, 32, 0, (string)null), // 167
			Tuple.Create(1339, new Point3D(-14, 12, 0), 1, 32, 0, (string)null), // 168
			Tuple.Create(1339, new Point3D(-13, 5, 0), 1, 32, 0, (string)null), // 169
			Tuple.Create(1339, new Point3D(-13, 6, 0), 1, 32, 0, (string)null), // 170
			Tuple.Create(1339, new Point3D(-13, 7, 0), 1, 32, 0, (string)null), // 171
			Tuple.Create(1339, new Point3D(-13, 8, 0), 1, 32, 0, (string)null), // 172
			Tuple.Create(1339, new Point3D(-13, 9, 0), 1, 32, 0, (string)null), // 173
			Tuple.Create(1339, new Point3D(-13, 10, 0), 1, 32, 0, (string)null), // 174
			Tuple.Create(1339, new Point3D(-13, 11, 0), 1, 32, 0, (string)null), // 175
			Tuple.Create(1339, new Point3D(-13, 12, 0), 1, 32, 0, (string)null), // 176
			Tuple.Create(1339, new Point3D(-12, 5, 0), 1, 32, 0, (string)null), // 177
			Tuple.Create(1339, new Point3D(-12, 6, 0), 1, 32, 0, (string)null), // 178
			Tuple.Create(1339, new Point3D(-12, 7, 0), 1, 32, 0, (string)null), // 179
			Tuple.Create(1339, new Point3D(-12, 8, 0), 1, 32, 0, (string)null), // 180
			Tuple.Create(1339, new Point3D(-12, 9, 0), 1, 32, 0, (string)null), // 181
			Tuple.Create(1339, new Point3D(-12, 10, 0), 1, 32, 0, (string)null), // 182
			Tuple.Create(1339, new Point3D(-12, 11, 0), 1, 32, 0, (string)null), // 183
			Tuple.Create(1339, new Point3D(-12, 12, 0), 1, 32, 0, (string)null), // 184
			Tuple.Create(1339, new Point3D(-11, 5, 0), 1, 32, 0, (string)null), // 185
			Tuple.Create(1339, new Point3D(-11, 6, 0), 1, 32, 0, (string)null), // 186
			Tuple.Create(1339, new Point3D(-11, 7, 0), 1, 32, 0, (string)null), // 187
			Tuple.Create(1339, new Point3D(-11, 8, 0), 1, 32, 0, (string)null), // 188
			Tuple.Create(1339, new Point3D(-11, 9, 0), 1, 32, 0, (string)null), // 189
			Tuple.Create(1339, new Point3D(-11, 10, 0), 1, 32, 0, (string)null), // 190
			Tuple.Create(1339, new Point3D(-11, 11, 0), 1, 32, 0, (string)null), // 191
			Tuple.Create(1339, new Point3D(-11, 12, 0), 1, 32, 0, (string)null), // 192
			Tuple.Create(1339, new Point3D(-10, 5, 0), 1, 32, 0, (string)null), // 193
			Tuple.Create(1339, new Point3D(-10, 6, 0), 1, 32, 0, (string)null), // 194
			Tuple.Create(1339, new Point3D(-10, 7, 0), 1, 32, 0, (string)null), // 195
			Tuple.Create(1339, new Point3D(-10, 8, 0), 1, 32, 0, (string)null), // 196
			Tuple.Create(1339, new Point3D(-10, 9, 0), 1, 32, 0, (string)null), // 197
			Tuple.Create(1339, new Point3D(-10, 10, 0), 1, 32, 0, (string)null), // 198
			Tuple.Create(1339, new Point3D(-10, 11, 0), 1, 32, 0, (string)null), // 199
			Tuple.Create(1339, new Point3D(-10, 12, 0), 1, 32, 0, (string)null), // 200
			Tuple.Create(1339, new Point3D(-9, 5, 0), 1, 32, 0, (string)null), // 201
			Tuple.Create(1339, new Point3D(-9, 6, 0), 1, 32, 0, (string)null), // 202
			Tuple.Create(1339, new Point3D(-9, 7, 0), 1, 32, 0, (string)null), // 203
			Tuple.Create(1339, new Point3D(-9, 8, 0), 1, 32, 0, (string)null), // 204
			Tuple.Create(1339, new Point3D(-9, 9, 0), 1, 32, 0, (string)null), // 205
			Tuple.Create(1339, new Point3D(-9, 10, 0), 1, 32, 0, (string)null), // 206
			Tuple.Create(1339, new Point3D(-9, 11, 0), 1, 32, 0, (string)null), // 207
			Tuple.Create(1339, new Point3D(-9, 12, 0), 1, 32, 0, (string)null), // 208
			Tuple.Create(1339, new Point3D(-8, 5, 0), 1, 32, 0, (string)null), // 209
			Tuple.Create(1339, new Point3D(-8, 6, 0), 1, 32, 0, (string)null), // 210
			Tuple.Create(1339, new Point3D(-8, 7, 0), 1, 32, 0, (string)null), // 211
			Tuple.Create(1339, new Point3D(-8, 8, 0), 1, 32, 0, (string)null), // 212
			Tuple.Create(1339, new Point3D(-8, 9, 0), 1, 32, 0, (string)null), // 213
			Tuple.Create(1339, new Point3D(-8, 10, 0), 1, 32, 0, (string)null), // 214
			Tuple.Create(1339, new Point3D(-8, 11, 0), 1, 32, 0, (string)null), // 215
			Tuple.Create(1339, new Point3D(-8, 12, 0), 1, 32, 0, (string)null), // 216
			Tuple.Create(2081, new Point3D(-16, 12, 0), 1, 0, 0, (string)null), // 217
			Tuple.Create(2083, new Point3D(-15, 12, 0), 1, 0, 0, (string)null), // 218
			Tuple.Create(2081, new Point3D(-16, 5, 0), 1, 0, 0, (string)null), // 219
			Tuple.Create(2081, new Point3D(-16, 6, 0), 1, 0, 0, (string)null), // 220
			Tuple.Create(2081, new Point3D(-16, 7, 0), 1, 0, 0, (string)null), // 221
			Tuple.Create(2081, new Point3D(-16, 8, 0), 1, 0, 0, (string)null), // 222
			Tuple.Create(2081, new Point3D(-16, 9, 0), 1, 0, 0, (string)null), // 223
			Tuple.Create(2081, new Point3D(-16, 10, 0), 1, 0, 0, (string)null), // 224
			Tuple.Create(2081, new Point3D(-16, 11, 0), 1, 0, 0, (string)null), // 225
			Tuple.Create(2081, new Point3D(-16, 12, 0), 1, 0, 0, (string)null), // 226
			Tuple.Create(2083, new Point3D(-14, 12, 0), 1, 0, 0, (string)null), // 227
			Tuple.Create(2083, new Point3D(-13, 12, 0), 1, 0, 0, (string)null), // 228
			Tuple.Create(2083, new Point3D(-12, 12, 0), 1, 0, 0, (string)null), // 229
			Tuple.Create(2083, new Point3D(-11, 12, 0), 1, 0, 0, (string)null), // 230
			Tuple.Create(2083, new Point3D(-10, 12, 0), 1, 0, 0, (string)null), // 231
			Tuple.Create(2083, new Point3D(-9, 12, 0), 1, 0, 0, (string)null), // 232
			Tuple.Create(2083, new Point3D(-8, 12, 0), 1, 0, 0, (string)null), // 233
			Tuple.Create(2083, new Point3D(-7, -12, 0), 1, 0, 0, (string)null), // 234
			Tuple.Create(2083, new Point3D(-6, -12, 0), 1, 0, 0, (string)null), // 235
			Tuple.Create(2083, new Point3D(-5, -12, 0), 1, 0, 0, (string)null), // 236
			Tuple.Create(2083, new Point3D(-4, -12, 0), 1, 0, 0, (string)null), // 237
			Tuple.Create(2083, new Point3D(-3, -12, 0), 1, 0, 0, (string)null), // 238
			Tuple.Create(2083, new Point3D(-2, -12, 0), 1, 0, 0, (string)null), // 239
			Tuple.Create(2083, new Point3D(-1, -12, 0), 1, 0, 0, (string)null), // 240
			Tuple.Create(2083, new Point3D(0, -12, 0), 1, 0, 0, (string)null), // 241
			Tuple.Create(2083, new Point3D(1, -12, 0), 1, 0, 0, (string)null), // 242
			Tuple.Create(2083, new Point3D(2, -12, 0), 1, 0, 0, (string)null), // 243
			Tuple.Create(2083, new Point3D(3, -12, 0), 1, 0, 0, (string)null), // 244
			Tuple.Create(2083, new Point3D(4, -12, 0), 1, 0, 0, (string)null), // 245
			Tuple.Create(2083, new Point3D(5, -12, 0), 1, 0, 0, (string)null), // 246
			Tuple.Create(2083, new Point3D(6, -12, 0), 1, 0, 0, (string)null), // 247
			Tuple.Create(2083, new Point3D(7, -12, 0), 1, 0, 0, (string)null), // 248
			Tuple.Create(2083, new Point3D(8, -12, 0), 1, 0, 0, (string)null), // 249
			Tuple.Create(1339, new Point3D(-7, -11, 0), 1, 32, 0, (string)null), // 250
			Tuple.Create(1339, new Point3D(-7, -10, 0), 1, 32, 0, (string)null), // 251
			Tuple.Create(1339, new Point3D(-7, -9, 0), 1, 32, 0, (string)null), // 252
			Tuple.Create(1339, new Point3D(-7, -8, 0), 1, 32, 0, (string)null), // 253
			Tuple.Create(1339, new Point3D(-7, -7, 0), 1, 32, 0, (string)null), // 254
			Tuple.Create(1339, new Point3D(-7, -6, 0), 1, 32, 0, (string)null), // 255
			Tuple.Create(1339, new Point3D(-7, -5, 0), 1, 32, 0, (string)null), // 256
			Tuple.Create(1339, new Point3D(-7, -4, 0), 1, 32, 0, (string)null), // 257
			Tuple.Create(1339, new Point3D(-7, -3, 0), 1, 32, 0, (string)null), // 258
			Tuple.Create(1339, new Point3D(-7, -2, 0), 1, 32, 0, (string)null), // 259
			Tuple.Create(1339, new Point3D(-7, -1, 0), 1, 32, 0, (string)null), // 260
			Tuple.Create(1339, new Point3D(-7, 0, 0), 1, 32, 0, (string)null), // 261
			Tuple.Create(1339, new Point3D(-7, 1, 0), 1, 32, 0, (string)null), // 262
			Tuple.Create(1339, new Point3D(-7, 2, 0), 1, 32, 0, (string)null), // 263
			Tuple.Create(1339, new Point3D(-7, 3, 0), 1, 32, 0, (string)null), // 264
			Tuple.Create(1339, new Point3D(-7, 4, 0), 1, 32, 0, (string)null), // 265
			Tuple.Create(1339, new Point3D(-6, -11, 0), 1, 32, 0, (string)null), // 266
			Tuple.Create(1339, new Point3D(-6, -10, 0), 1, 32, 0, (string)null), // 267
			Tuple.Create(1339, new Point3D(-6, -9, 0), 1, 32, 0, (string)null), // 268
			Tuple.Create(1339, new Point3D(-6, -8, 0), 1, 32, 0, (string)null), // 269
			Tuple.Create(1339, new Point3D(-6, -7, 0), 1, 32, 0, (string)null), // 270
			Tuple.Create(1339, new Point3D(-6, -6, 0), 1, 32, 0, (string)null), // 271
			Tuple.Create(1339, new Point3D(-6, -5, 0), 1, 32, 0, (string)null), // 272
			Tuple.Create(1339, new Point3D(-6, -4, 0), 1, 32, 0, (string)null), // 273
			Tuple.Create(1339, new Point3D(-6, -3, 0), 1, 32, 0, (string)null), // 274
			Tuple.Create(1339, new Point3D(-6, -2, 0), 1, 32, 0, (string)null), // 275
			Tuple.Create(1339, new Point3D(-6, -1, 0), 1, 32, 0, (string)null), // 276
			Tuple.Create(1339, new Point3D(-6, 0, 0), 1, 32, 0, (string)null), // 277
			Tuple.Create(1339, new Point3D(-6, 1, 0), 1, 32, 0, (string)null), // 278
			Tuple.Create(1339, new Point3D(-6, 2, 0), 1, 32, 0, (string)null), // 279
			Tuple.Create(1339, new Point3D(-6, 3, 0), 1, 32, 0, (string)null), // 280
			Tuple.Create(1339, new Point3D(-6, 4, 0), 1, 32, 0, (string)null), // 281
			Tuple.Create(1339, new Point3D(-5, -11, 0), 1, 32, 0, (string)null), // 282
			Tuple.Create(1339, new Point3D(-5, -10, 0), 1, 32, 0, (string)null), // 283
			Tuple.Create(1339, new Point3D(-5, -9, 0), 1, 32, 0, (string)null), // 284
			Tuple.Create(1339, new Point3D(-5, -8, 0), 1, 32, 0, (string)null), // 285
			Tuple.Create(1339, new Point3D(-5, -7, 0), 1, 32, 0, (string)null), // 286
			Tuple.Create(1339, new Point3D(-5, -6, 0), 1, 32, 0, (string)null), // 287
			Tuple.Create(1339, new Point3D(-5, -5, 0), 1, 32, 0, (string)null), // 288
			Tuple.Create(1339, new Point3D(-5, -4, 0), 1, 32, 0, (string)null), // 289
			Tuple.Create(1339, new Point3D(-5, -3, 0), 1, 32, 0, (string)null), // 290
			Tuple.Create(1339, new Point3D(-5, -2, 0), 1, 32, 0, (string)null), // 291
			Tuple.Create(1339, new Point3D(-5, -1, 0), 1, 32, 0, (string)null), // 292
			Tuple.Create(1339, new Point3D(-5, 0, 0), 1, 32, 0, (string)null), // 293
			Tuple.Create(1339, new Point3D(-5, 1, 0), 1, 32, 0, (string)null), // 294
			Tuple.Create(1339, new Point3D(-5, 2, 0), 1, 32, 0, (string)null), // 295
			Tuple.Create(1339, new Point3D(-5, 3, 0), 1, 32, 0, (string)null), // 296
			Tuple.Create(1339, new Point3D(-5, 4, 0), 1, 32, 0, (string)null), // 297
			Tuple.Create(1339, new Point3D(-4, -11, 0), 1, 32, 0, (string)null), // 298
			Tuple.Create(1339, new Point3D(-4, -10, 0), 1, 32, 0, (string)null), // 299
			Tuple.Create(1339, new Point3D(-4, -9, 0), 1, 32, 0, (string)null), // 300
			Tuple.Create(1339, new Point3D(-4, -8, 0), 1, 32, 0, (string)null), // 301
			Tuple.Create(1339, new Point3D(-4, -7, 0), 1, 32, 0, (string)null), // 302
			Tuple.Create(1339, new Point3D(-4, -6, 0), 1, 32, 0, (string)null), // 303
			Tuple.Create(1339, new Point3D(-4, -5, 0), 1, 32, 0, (string)null), // 304
			Tuple.Create(1339, new Point3D(-4, -4, 0), 1, 32, 0, (string)null), // 305
			Tuple.Create(1339, new Point3D(-4, -3, 0), 1, 32, 0, (string)null), // 306
			Tuple.Create(1339, new Point3D(-4, -2, 0), 1, 32, 0, (string)null), // 307
			Tuple.Create(1339, new Point3D(-4, -1, 0), 1, 32, 0, (string)null), // 308
			Tuple.Create(1339, new Point3D(-4, 0, 0), 1, 32, 0, (string)null), // 309
			Tuple.Create(1339, new Point3D(-4, 1, 0), 1, 32, 0, (string)null), // 310
			Tuple.Create(1339, new Point3D(-4, 2, 0), 1, 32, 0, (string)null), // 311
			Tuple.Create(1339, new Point3D(-4, 3, 0), 1, 32, 0, (string)null), // 312
			Tuple.Create(1339, new Point3D(-4, 4, 0), 1, 32, 0, (string)null), // 313
			Tuple.Create(1339, new Point3D(-3, -11, 0), 1, 32, 0, (string)null), // 314
			Tuple.Create(1339, new Point3D(-3, -10, 0), 1, 32, 0, (string)null), // 315
			Tuple.Create(1339, new Point3D(-3, -9, 0), 1, 32, 0, (string)null), // 316
			Tuple.Create(1339, new Point3D(-3, -8, 0), 1, 32, 0, (string)null), // 317
			Tuple.Create(1339, new Point3D(-3, -7, 0), 1, 32, 0, (string)null), // 318
			Tuple.Create(1339, new Point3D(-3, -6, 0), 1, 32, 0, (string)null), // 319
			Tuple.Create(1339, new Point3D(-3, -5, 0), 1, 32, 0, (string)null), // 320
			Tuple.Create(1339, new Point3D(-3, -4, 0), 1, 32, 0, (string)null), // 321
			Tuple.Create(1339, new Point3D(-3, -3, 0), 1, 32, 0, (string)null), // 322
			Tuple.Create(1339, new Point3D(-3, -2, 0), 1, 32, 0, (string)null), // 323
			Tuple.Create(1339, new Point3D(-3, -1, 0), 1, 32, 0, (string)null), // 324
			Tuple.Create(1339, new Point3D(-3, 0, 0), 1, 32, 0, (string)null), // 325
			Tuple.Create(1339, new Point3D(-3, 1, 0), 1, 32, 0, (string)null), // 326
			Tuple.Create(1339, new Point3D(-3, 2, 0), 1, 32, 0, (string)null), // 327
			Tuple.Create(1339, new Point3D(-3, 3, 0), 1, 32, 0, (string)null), // 328
			Tuple.Create(1339, new Point3D(-3, 4, 0), 1, 32, 0, (string)null), // 329
			Tuple.Create(1339, new Point3D(-2, -11, 0), 1, 32, 0, (string)null), // 330
			Tuple.Create(1339, new Point3D(-2, -10, 0), 1, 32, 0, (string)null), // 331
			Tuple.Create(1339, new Point3D(-2, -9, 0), 1, 32, 0, (string)null), // 332
			Tuple.Create(1339, new Point3D(-2, -8, 0), 1, 32, 0, (string)null), // 333
			Tuple.Create(1339, new Point3D(-2, -7, 0), 1, 32, 0, (string)null), // 334
			Tuple.Create(1339, new Point3D(-2, -6, 0), 1, 32, 0, (string)null), // 335
			Tuple.Create(1339, new Point3D(-2, -5, 0), 1, 32, 0, (string)null), // 336
			Tuple.Create(1339, new Point3D(-2, -4, 0), 1, 32, 0, (string)null), // 337
			Tuple.Create(1339, new Point3D(-2, -3, 0), 1, 32, 0, (string)null), // 338
			Tuple.Create(1339, new Point3D(-2, -2, 0), 1, 32, 0, (string)null), // 339
			Tuple.Create(1339, new Point3D(-2, -1, 0), 1, 32, 0, (string)null), // 340
			Tuple.Create(1339, new Point3D(-2, 0, 0), 1, 32, 0, (string)null), // 341
			Tuple.Create(1339, new Point3D(-2, 1, 0), 1, 32, 0, (string)null), // 342
			Tuple.Create(1339, new Point3D(-2, 2, 0), 1, 32, 0, (string)null), // 343
			Tuple.Create(1339, new Point3D(-2, 3, 0), 1, 32, 0, (string)null), // 344
			Tuple.Create(1339, new Point3D(-2, 4, 0), 1, 32, 0, (string)null), // 345
			Tuple.Create(1339, new Point3D(-1, -11, 0), 1, 32, 0, (string)null), // 346
			Tuple.Create(1339, new Point3D(-1, -10, 0), 1, 32, 0, (string)null), // 347
			Tuple.Create(1339, new Point3D(-1, -9, 0), 1, 32, 0, (string)null), // 348
			Tuple.Create(1339, new Point3D(-1, -8, 0), 1, 32, 0, (string)null), // 349
			Tuple.Create(1339, new Point3D(-1, -7, 0), 1, 32, 0, (string)null), // 350
			Tuple.Create(1339, new Point3D(-1, -6, 0), 1, 32, 0, (string)null), // 351
			Tuple.Create(1339, new Point3D(-1, -5, 0), 1, 32, 0, (string)null), // 352
			Tuple.Create(1339, new Point3D(-1, -4, 0), 1, 32, 0, (string)null), // 353
			Tuple.Create(1339, new Point3D(-1, -3, 0), 1, 32, 0, (string)null), // 354
			Tuple.Create(1339, new Point3D(-1, -2, 0), 1, 32, 0, (string)null), // 355
			Tuple.Create(1339, new Point3D(-1, -1, 0), 1, 32, 0, (string)null), // 356
			Tuple.Create(1339, new Point3D(-1, 0, 0), 1, 32, 0, (string)null), // 357
			Tuple.Create(1339, new Point3D(-1, 1, 0), 1, 32, 0, (string)null), // 358
			Tuple.Create(1339, new Point3D(-1, 2, 0), 1, 32, 0, (string)null), // 359
			Tuple.Create(1339, new Point3D(-1, 3, 0), 1, 32, 0, (string)null), // 360
			Tuple.Create(1339, new Point3D(-1, 4, 0), 1, 32, 0, (string)null), // 361
			Tuple.Create(1339, new Point3D(0, -11, 0), 1, 32, 0, (string)null), // 362
			Tuple.Create(1339, new Point3D(0, -10, 0), 1, 32, 0, (string)null), // 363
			Tuple.Create(1339, new Point3D(0, -9, 0), 1, 32, 0, (string)null), // 364
			Tuple.Create(1339, new Point3D(0, -8, 0), 1, 32, 0, (string)null), // 365
			Tuple.Create(1339, new Point3D(0, -7, 0), 1, 32, 0, (string)null), // 366
			Tuple.Create(1339, new Point3D(0, -6, 0), 1, 32, 0, (string)null), // 367
			Tuple.Create(1339, new Point3D(0, -5, 0), 1, 32, 0, (string)null), // 368
			Tuple.Create(1339, new Point3D(0, -4, 0), 1, 32, 0, (string)null), // 369
			Tuple.Create(1339, new Point3D(0, -3, 0), 1, 32, 0, (string)null), // 370
			Tuple.Create(1339, new Point3D(0, -2, 0), 1, 32, 0, (string)null), // 371
			Tuple.Create(1339, new Point3D(0, -1, 0), 1, 32, 0, (string)null), // 372
			Tuple.Create(1339, new Point3D(0, 0, 0), 1, 32, 0, (string)null), // 373
			Tuple.Create(1339, new Point3D(0, 1, 0), 1, 32, 0, (string)null), // 374
			Tuple.Create(1339, new Point3D(0, 2, 0), 1, 32, 0, (string)null), // 375
			Tuple.Create(1339, new Point3D(0, 3, 0), 1, 32, 0, (string)null), // 376
			Tuple.Create(1339, new Point3D(0, 4, 0), 1, 32, 0, (string)null), // 377
			Tuple.Create(1339, new Point3D(1, -11, 0), 1, 32, 0, (string)null), // 378
			Tuple.Create(1339, new Point3D(1, -10, 0), 1, 32, 0, (string)null), // 379
			Tuple.Create(1339, new Point3D(1, -9, 0), 1, 32, 0, (string)null), // 380
			Tuple.Create(1339, new Point3D(1, -8, 0), 1, 32, 0, (string)null), // 381
			Tuple.Create(1339, new Point3D(1, -7, 0), 1, 32, 0, (string)null), // 382
			Tuple.Create(1339, new Point3D(1, -6, 0), 1, 32, 0, (string)null), // 383
			Tuple.Create(1339, new Point3D(1, -5, 0), 1, 32, 0, (string)null), // 384
			Tuple.Create(1339, new Point3D(1, -4, 0), 1, 32, 0, (string)null), // 385
			Tuple.Create(1339, new Point3D(1, -3, 0), 1, 32, 0, (string)null), // 386
			Tuple.Create(1339, new Point3D(1, -2, 0), 1, 32, 0, (string)null), // 387
			Tuple.Create(1339, new Point3D(1, -1, 0), 1, 32, 0, (string)null), // 388
			Tuple.Create(1339, new Point3D(1, 0, 0), 1, 32, 0, (string)null), // 389
			Tuple.Create(1339, new Point3D(1, 1, 0), 1, 32, 0, (string)null), // 390
			Tuple.Create(1339, new Point3D(1, 2, 0), 1, 32, 0, (string)null), // 391
			Tuple.Create(1339, new Point3D(1, 3, 0), 1, 32, 0, (string)null), // 392
			Tuple.Create(1339, new Point3D(1, 4, 0), 1, 32, 0, (string)null), // 393
			Tuple.Create(1339, new Point3D(2, -11, 0), 1, 32, 0, (string)null), // 394
			Tuple.Create(1339, new Point3D(2, -10, 0), 1, 32, 0, (string)null), // 395
			Tuple.Create(1339, new Point3D(2, -9, 0), 1, 32, 0, (string)null), // 396
			Tuple.Create(1339, new Point3D(2, -8, 0), 1, 32, 0, (string)null), // 397
			Tuple.Create(1339, new Point3D(2, -7, 0), 1, 32, 0, (string)null), // 398
			Tuple.Create(1339, new Point3D(2, -6, 0), 1, 32, 0, (string)null), // 399
			Tuple.Create(1339, new Point3D(2, -5, 0), 1, 32, 0, (string)null), // 400
			Tuple.Create(1339, new Point3D(2, -4, 0), 1, 32, 0, (string)null), // 401
			Tuple.Create(1339, new Point3D(2, -3, 0), 1, 32, 0, (string)null), // 402
			Tuple.Create(1339, new Point3D(2, -2, 0), 1, 32, 0, (string)null), // 403
			Tuple.Create(1339, new Point3D(2, -1, 0), 1, 32, 0, (string)null), // 404
			Tuple.Create(1339, new Point3D(2, 0, 0), 1, 32, 0, (string)null), // 405
			Tuple.Create(1339, new Point3D(2, 1, 0), 1, 32, 0, (string)null), // 406
			Tuple.Create(1339, new Point3D(2, 2, 0), 1, 32, 0, (string)null), // 407
			Tuple.Create(1339, new Point3D(2, 3, 0), 1, 32, 0, (string)null), // 408
			Tuple.Create(1339, new Point3D(2, 4, 0), 1, 32, 0, (string)null), // 409
			Tuple.Create(1339, new Point3D(3, -11, 0), 1, 32, 0, (string)null), // 410
			Tuple.Create(1339, new Point3D(3, -10, 0), 1, 32, 0, (string)null), // 411
			Tuple.Create(1339, new Point3D(3, -9, 0), 1, 32, 0, (string)null), // 412
			Tuple.Create(1339, new Point3D(3, -8, 0), 1, 32, 0, (string)null), // 413
			Tuple.Create(1339, new Point3D(3, -7, 0), 1, 32, 0, (string)null), // 414
			Tuple.Create(1339, new Point3D(3, -6, 0), 1, 32, 0, (string)null), // 415
			Tuple.Create(1339, new Point3D(3, -5, 0), 1, 32, 0, (string)null), // 416
			Tuple.Create(1339, new Point3D(3, -4, 0), 1, 32, 0, (string)null), // 417
			Tuple.Create(1339, new Point3D(3, -3, 0), 1, 32, 0, (string)null), // 418
			Tuple.Create(1339, new Point3D(3, -2, 0), 1, 32, 0, (string)null), // 419
			Tuple.Create(1339, new Point3D(3, -1, 0), 1, 32, 0, (string)null), // 420
			Tuple.Create(1339, new Point3D(3, 0, 0), 1, 32, 0, (string)null), // 421
			Tuple.Create(1339, new Point3D(3, 1, 0), 1, 32, 0, (string)null), // 422
			Tuple.Create(1339, new Point3D(3, 2, 0), 1, 32, 0, (string)null), // 423
			Tuple.Create(1339, new Point3D(3, 3, 0), 1, 32, 0, (string)null), // 424
			Tuple.Create(1339, new Point3D(3, 4, 0), 1, 32, 0, (string)null), // 425
			Tuple.Create(1339, new Point3D(4, -11, 0), 1, 32, 0, (string)null), // 426
			Tuple.Create(1339, new Point3D(4, -10, 0), 1, 32, 0, (string)null), // 427
			Tuple.Create(1339, new Point3D(4, -9, 0), 1, 32, 0, (string)null), // 428
			Tuple.Create(1339, new Point3D(4, -8, 0), 1, 32, 0, (string)null), // 429
			Tuple.Create(1339, new Point3D(4, -7, 0), 1, 32, 0, (string)null), // 430
			Tuple.Create(1339, new Point3D(4, -6, 0), 1, 32, 0, (string)null), // 431
			Tuple.Create(1339, new Point3D(4, -5, 0), 1, 32, 0, (string)null), // 432
			Tuple.Create(1339, new Point3D(4, -4, 0), 1, 32, 0, (string)null), // 433
			Tuple.Create(1339, new Point3D(4, -3, 0), 1, 32, 0, (string)null), // 434
			Tuple.Create(1339, new Point3D(4, -2, 0), 1, 32, 0, (string)null), // 435
			Tuple.Create(1339, new Point3D(4, -1, 0), 1, 32, 0, (string)null), // 436
			Tuple.Create(1339, new Point3D(4, 0, 0), 1, 32, 0, (string)null), // 437
			Tuple.Create(1339, new Point3D(4, 1, 0), 1, 32, 0, (string)null), // 438
			Tuple.Create(1339, new Point3D(4, 2, 0), 1, 32, 0, (string)null), // 439
			Tuple.Create(1339, new Point3D(4, 3, 0), 1, 32, 0, (string)null), // 440
			Tuple.Create(1339, new Point3D(4, 4, 0), 1, 32, 0, (string)null), // 441
			Tuple.Create(1339, new Point3D(5, -11, 0), 1, 32, 0, (string)null), // 442
			Tuple.Create(1339, new Point3D(5, -10, 0), 1, 32, 0, (string)null), // 443
			Tuple.Create(1339, new Point3D(5, -9, 0), 1, 32, 0, (string)null), // 444
			Tuple.Create(1339, new Point3D(5, -8, 0), 1, 32, 0, (string)null), // 445
			Tuple.Create(1339, new Point3D(5, -7, 0), 1, 32, 0, (string)null), // 446
			Tuple.Create(1339, new Point3D(5, -6, 0), 1, 32, 0, (string)null), // 447
			Tuple.Create(1339, new Point3D(5, -5, 0), 1, 32, 0, (string)null), // 448
			Tuple.Create(1339, new Point3D(5, -4, 0), 1, 32, 0, (string)null), // 449
			Tuple.Create(1339, new Point3D(5, -3, 0), 1, 32, 0, (string)null), // 450
			Tuple.Create(1339, new Point3D(5, -2, 0), 1, 32, 0, (string)null), // 451
			Tuple.Create(1339, new Point3D(5, -1, 0), 1, 32, 0, (string)null), // 452
			Tuple.Create(1339, new Point3D(5, 0, 0), 1, 32, 0, (string)null), // 453
			Tuple.Create(1339, new Point3D(5, 1, 0), 1, 32, 0, (string)null), // 454
			Tuple.Create(1339, new Point3D(5, 2, 0), 1, 32, 0, (string)null), // 455
			Tuple.Create(1339, new Point3D(5, 3, 0), 1, 32, 0, (string)null), // 456
			Tuple.Create(1339, new Point3D(5, 4, 0), 1, 32, 0, (string)null), // 457
			Tuple.Create(1339, new Point3D(6, -11, 0), 1, 32, 0, (string)null), // 458
			Tuple.Create(1339, new Point3D(6, -10, 0), 1, 32, 0, (string)null), // 459
			Tuple.Create(1339, new Point3D(6, -9, 0), 1, 32, 0, (string)null), // 460
			Tuple.Create(1339, new Point3D(6, -8, 0), 1, 32, 0, (string)null), // 461
			Tuple.Create(1339, new Point3D(6, -7, 0), 1, 32, 0, (string)null), // 462
			Tuple.Create(1339, new Point3D(6, -6, 0), 1, 32, 0, (string)null), // 463
			Tuple.Create(1339, new Point3D(6, -5, 0), 1, 32, 0, (string)null), // 464
			Tuple.Create(1339, new Point3D(6, -4, 0), 1, 32, 0, (string)null), // 465
			Tuple.Create(1339, new Point3D(6, -3, 0), 1, 32, 0, (string)null), // 466
			Tuple.Create(1339, new Point3D(6, -2, 0), 1, 32, 0, (string)null), // 467
			Tuple.Create(1339, new Point3D(6, -1, 0), 1, 32, 0, (string)null), // 468
			Tuple.Create(1339, new Point3D(6, 0, 0), 1, 32, 0, (string)null), // 469
			Tuple.Create(1339, new Point3D(6, 1, 0), 1, 32, 0, (string)null), // 470
			Tuple.Create(1339, new Point3D(6, 2, 0), 1, 32, 0, (string)null), // 471
			Tuple.Create(1339, new Point3D(6, 3, 0), 1, 32, 0, (string)null), // 472
			Tuple.Create(1339, new Point3D(6, 4, 0), 1, 32, 0, (string)null), // 473
			Tuple.Create(1339, new Point3D(7, -11, 0), 1, 32, 0, (string)null), // 474
			Tuple.Create(1339, new Point3D(7, -10, 0), 1, 32, 0, (string)null), // 475
			Tuple.Create(1339, new Point3D(7, -9, 0), 1, 32, 0, (string)null), // 476
			Tuple.Create(1339, new Point3D(7, -8, 0), 1, 32, 0, (string)null), // 477
			Tuple.Create(1339, new Point3D(7, -7, 0), 1, 32, 0, (string)null), // 478
			Tuple.Create(1339, new Point3D(7, -6, 0), 1, 32, 0, (string)null), // 479
			Tuple.Create(1339, new Point3D(7, -5, 0), 1, 32, 0, (string)null), // 480
			Tuple.Create(1339, new Point3D(7, -4, 0), 1, 32, 0, (string)null), // 481
			Tuple.Create(1339, new Point3D(7, -3, 0), 1, 32, 0, (string)null), // 482
			Tuple.Create(1339, new Point3D(7, -2, 0), 1, 32, 0, (string)null), // 483
			Tuple.Create(1339, new Point3D(7, -1, 0), 1, 32, 0, (string)null), // 484
			Tuple.Create(1339, new Point3D(7, 0, 0), 1, 32, 0, (string)null), // 485
			Tuple.Create(1339, new Point3D(7, 1, 0), 1, 32, 0, (string)null), // 486
			Tuple.Create(1339, new Point3D(7, 2, 0), 1, 32, 0, (string)null), // 487
			Tuple.Create(1339, new Point3D(7, 3, 0), 1, 32, 0, (string)null), // 488
			Tuple.Create(1339, new Point3D(7, 4, 0), 1, 32, 0, (string)null), // 489
			Tuple.Create(1339, new Point3D(8, -11, 0), 1, 32, 0, (string)null), // 490
			Tuple.Create(1339, new Point3D(8, -10, 0), 1, 32, 0, (string)null), // 491
			Tuple.Create(1339, new Point3D(8, -9, 0), 1, 32, 0, (string)null), // 492
			Tuple.Create(1339, new Point3D(8, -8, 0), 1, 32, 0, (string)null), // 493
			Tuple.Create(1339, new Point3D(8, -7, 0), 1, 32, 0, (string)null), // 494
			Tuple.Create(1339, new Point3D(8, -6, 0), 1, 32, 0, (string)null), // 495
			Tuple.Create(1339, new Point3D(8, -5, 0), 1, 32, 0, (string)null), // 496
			Tuple.Create(1339, new Point3D(8, -4, 0), 1, 32, 0, (string)null), // 497
			Tuple.Create(1339, new Point3D(8, -3, 0), 1, 32, 0, (string)null), // 498
			Tuple.Create(1339, new Point3D(8, -2, 0), 1, 32, 0, (string)null), // 499
			Tuple.Create(1339, new Point3D(8, -1, 0), 1, 32, 0, (string)null), // 500
			Tuple.Create(1339, new Point3D(8, 0, 0), 1, 32, 0, (string)null), // 501
			Tuple.Create(1339, new Point3D(8, 1, 0), 1, 32, 0, (string)null), // 502
			Tuple.Create(1339, new Point3D(8, 2, 0), 1, 32, 0, (string)null), // 503
			Tuple.Create(1339, new Point3D(8, 3, 0), 1, 32, 0, (string)null), // 504
			Tuple.Create(1339, new Point3D(8, 4, 0), 1, 32, 0, (string)null), // 505
			Tuple.Create(1339, new Point3D(-7, 5, 0), 1, 32, 0, (string)null), // 506
			Tuple.Create(1339, new Point3D(-7, 6, 0), 1, 32, 0, (string)null), // 507
			Tuple.Create(1339, new Point3D(-7, 7, 0), 1, 32, 0, (string)null), // 508
			Tuple.Create(1339, new Point3D(-7, 8, 0), 1, 32, 0, (string)null), // 509
			Tuple.Create(1339, new Point3D(-7, 9, 0), 1, 32, 0, (string)null), // 510
			Tuple.Create(1339, new Point3D(-7, 10, 0), 1, 32, 0, (string)null), // 511
			Tuple.Create(1339, new Point3D(-7, 11, 0), 1, 32, 0, (string)null), // 512
			Tuple.Create(1339, new Point3D(-7, 12, 0), 1, 32, 0, (string)null), // 513
			Tuple.Create(1339, new Point3D(-6, 5, 0), 1, 32, 0, (string)null), // 514
			Tuple.Create(1339, new Point3D(-6, 6, 0), 1, 32, 0, (string)null), // 515
			Tuple.Create(1339, new Point3D(-6, 7, 0), 1, 32, 0, (string)null), // 516
			Tuple.Create(1339, new Point3D(-6, 8, 0), 1, 32, 0, (string)null), // 517
			Tuple.Create(1339, new Point3D(-6, 9, 0), 1, 32, 0, (string)null), // 518
			Tuple.Create(1339, new Point3D(-6, 10, 0), 1, 32, 0, (string)null), // 519
			Tuple.Create(1339, new Point3D(-6, 11, 0), 1, 32, 0, (string)null), // 520
			Tuple.Create(1339, new Point3D(-6, 12, 0), 1, 32, 0, (string)null), // 521
			Tuple.Create(1339, new Point3D(-5, 5, 0), 1, 32, 0, (string)null), // 522
			Tuple.Create(1339, new Point3D(-5, 6, 0), 1, 32, 0, (string)null), // 523
			Tuple.Create(1339, new Point3D(-5, 7, 0), 1, 32, 0, (string)null), // 524
			Tuple.Create(1339, new Point3D(-5, 8, 0), 1, 32, 0, (string)null), // 525
			Tuple.Create(1339, new Point3D(-5, 9, 0), 1, 32, 0, (string)null), // 526
			Tuple.Create(1339, new Point3D(-5, 10, 0), 1, 32, 0, (string)null), // 527
			Tuple.Create(1339, new Point3D(-5, 11, 0), 1, 32, 0, (string)null), // 528
			Tuple.Create(1339, new Point3D(-5, 12, 0), 1, 32, 0, (string)null), // 529
			Tuple.Create(1339, new Point3D(-4, 5, 0), 1, 32, 0, (string)null), // 530
			Tuple.Create(1339, new Point3D(-4, 6, 0), 1, 32, 0, (string)null), // 531
			Tuple.Create(1339, new Point3D(-4, 7, 0), 1, 32, 0, (string)null), // 532
			Tuple.Create(1339, new Point3D(-4, 8, 0), 1, 32, 0, (string)null), // 533
			Tuple.Create(1339, new Point3D(-4, 9, 0), 1, 32, 0, (string)null), // 534
			Tuple.Create(1339, new Point3D(-4, 10, 0), 1, 32, 0, (string)null), // 535
			Tuple.Create(1339, new Point3D(-4, 11, 0), 1, 32, 0, (string)null), // 536
			Tuple.Create(1339, new Point3D(-4, 12, 0), 1, 32, 0, (string)null), // 537
			Tuple.Create(1339, new Point3D(-3, 5, 0), 1, 32, 0, (string)null), // 538
			Tuple.Create(1339, new Point3D(-3, 6, 0), 1, 32, 0, (string)null), // 539
			Tuple.Create(1339, new Point3D(-3, 7, 0), 1, 32, 0, (string)null), // 540
			Tuple.Create(1339, new Point3D(-3, 8, 0), 1, 32, 0, (string)null), // 541
			Tuple.Create(1339, new Point3D(-3, 9, 0), 1, 32, 0, (string)null), // 542
			Tuple.Create(1339, new Point3D(-3, 10, 0), 1, 32, 0, (string)null), // 543
			Tuple.Create(1339, new Point3D(-3, 11, 0), 1, 32, 0, (string)null), // 544
			Tuple.Create(1339, new Point3D(-3, 12, 0), 1, 32, 0, (string)null), // 545
			Tuple.Create(1339, new Point3D(-2, 5, 0), 1, 32, 0, (string)null), // 546
			Tuple.Create(1339, new Point3D(-2, 6, 0), 1, 32, 0, (string)null), // 547
			Tuple.Create(1339, new Point3D(-2, 7, 0), 1, 32, 0, (string)null), // 548
			Tuple.Create(1339, new Point3D(-2, 8, 0), 1, 32, 0, (string)null), // 549
			Tuple.Create(1339, new Point3D(-2, 9, 0), 1, 32, 0, (string)null), // 550
			Tuple.Create(1339, new Point3D(-2, 10, 0), 1, 32, 0, (string)null), // 551
			Tuple.Create(1339, new Point3D(-2, 11, 0), 1, 32, 0, (string)null), // 552
			Tuple.Create(1339, new Point3D(-2, 12, 0), 1, 32, 0, (string)null), // 553
			Tuple.Create(1339, new Point3D(-1, 5, 0), 1, 32, 0, (string)null), // 554
			Tuple.Create(1339, new Point3D(-1, 6, 0), 1, 32, 0, (string)null), // 555
			Tuple.Create(1339, new Point3D(-1, 7, 0), 1, 32, 0, (string)null), // 556
			Tuple.Create(1339, new Point3D(-1, 8, 0), 1, 32, 0, (string)null), // 557
			Tuple.Create(1339, new Point3D(-1, 9, 0), 1, 32, 0, (string)null), // 558
			Tuple.Create(1339, new Point3D(-1, 10, 0), 1, 32, 0, (string)null), // 559
			Tuple.Create(1339, new Point3D(-1, 11, 0), 1, 32, 0, (string)null), // 560
			Tuple.Create(1339, new Point3D(-1, 12, 0), 1, 32, 0, (string)null), // 561
			Tuple.Create(1339, new Point3D(0, 5, 0), 1, 32, 0, (string)null), // 562
			Tuple.Create(1339, new Point3D(0, 6, 0), 1, 32, 0, (string)null), // 563
			Tuple.Create(1339, new Point3D(0, 7, 0), 1, 32, 0, (string)null), // 564
			Tuple.Create(1339, new Point3D(0, 8, 0), 1, 32, 0, (string)null), // 565
			Tuple.Create(1339, new Point3D(0, 9, 0), 1, 32, 0, (string)null), // 566
			Tuple.Create(1339, new Point3D(0, 10, 0), 1, 32, 0, (string)null), // 567
			Tuple.Create(1339, new Point3D(0, 11, 0), 1, 32, 0, (string)null), // 568
			Tuple.Create(1339, new Point3D(0, 12, 0), 1, 32, 0, (string)null), // 569
			Tuple.Create(1339, new Point3D(1, 5, 0), 1, 32, 0, (string)null), // 570
			Tuple.Create(1339, new Point3D(1, 6, 0), 1, 32, 0, (string)null), // 571
			Tuple.Create(1339, new Point3D(1, 7, 0), 1, 32, 0, (string)null), // 572
			Tuple.Create(1339, new Point3D(1, 8, 0), 1, 32, 0, (string)null), // 573
			Tuple.Create(1339, new Point3D(1, 9, 0), 1, 32, 0, (string)null), // 574
			Tuple.Create(1339, new Point3D(1, 10, 0), 1, 32, 0, (string)null), // 575
			Tuple.Create(1339, new Point3D(1, 11, 0), 1, 32, 0, (string)null), // 576
			Tuple.Create(1339, new Point3D(1, 12, 0), 1, 32, 0, (string)null), // 577
			Tuple.Create(1339, new Point3D(2, 5, 0), 1, 32, 0, (string)null), // 578
			Tuple.Create(1339, new Point3D(2, 6, 0), 1, 32, 0, (string)null), // 579
			Tuple.Create(1339, new Point3D(2, 7, 0), 1, 32, 0, (string)null), // 580
			Tuple.Create(1339, new Point3D(2, 8, 0), 1, 32, 0, (string)null), // 581
			Tuple.Create(1339, new Point3D(2, 9, 0), 1, 32, 0, (string)null), // 582
			Tuple.Create(1339, new Point3D(2, 10, 0), 1, 32, 0, (string)null), // 583
			Tuple.Create(1339, new Point3D(2, 11, 0), 1, 32, 0, (string)null), // 584
			Tuple.Create(1339, new Point3D(2, 12, 0), 1, 32, 0, (string)null), // 585
			Tuple.Create(1339, new Point3D(3, 5, 0), 1, 32, 0, (string)null), // 586
			Tuple.Create(1339, new Point3D(3, 6, 0), 1, 32, 0, (string)null), // 587
			Tuple.Create(1339, new Point3D(3, 7, 0), 1, 32, 0, (string)null), // 588
			Tuple.Create(1339, new Point3D(3, 8, 0), 1, 32, 0, (string)null), // 589
			Tuple.Create(1339, new Point3D(3, 9, 0), 1, 32, 0, (string)null), // 590
			Tuple.Create(1339, new Point3D(3, 10, 0), 1, 32, 0, (string)null), // 591
			Tuple.Create(1339, new Point3D(3, 11, 0), 1, 32, 0, (string)null), // 592
			Tuple.Create(1339, new Point3D(3, 12, 0), 1, 32, 0, (string)null), // 593
			Tuple.Create(1339, new Point3D(4, 5, 0), 1, 32, 0, (string)null), // 594
			Tuple.Create(1339, new Point3D(4, 6, 0), 1, 32, 0, (string)null), // 595
			Tuple.Create(1339, new Point3D(4, 7, 0), 1, 32, 0, (string)null), // 596
			Tuple.Create(1339, new Point3D(4, 8, 0), 1, 32, 0, (string)null), // 597
			Tuple.Create(1339, new Point3D(4, 9, 0), 1, 32, 0, (string)null), // 598
			Tuple.Create(1339, new Point3D(4, 10, 0), 1, 32, 0, (string)null), // 599
			Tuple.Create(1339, new Point3D(4, 11, 0), 1, 32, 0, (string)null), // 600
			Tuple.Create(1339, new Point3D(4, 12, 0), 1, 32, 0, (string)null), // 601
			Tuple.Create(1339, new Point3D(5, 5, 0), 1, 32, 0, (string)null), // 602
			Tuple.Create(1339, new Point3D(5, 6, 0), 1, 32, 0, (string)null), // 603
			Tuple.Create(1339, new Point3D(5, 7, 0), 1, 32, 0, (string)null), // 604
			Tuple.Create(1339, new Point3D(5, 8, 0), 1, 32, 0, (string)null), // 605
			Tuple.Create(1339, new Point3D(5, 9, 0), 1, 32, 0, (string)null), // 606
			Tuple.Create(1339, new Point3D(5, 10, 0), 1, 32, 0, (string)null), // 607
			Tuple.Create(1339, new Point3D(5, 11, 0), 1, 32, 0, (string)null), // 608
			Tuple.Create(1339, new Point3D(5, 12, 0), 1, 32, 0, (string)null), // 609
			Tuple.Create(1339, new Point3D(6, 5, 0), 1, 32, 0, (string)null), // 610
			Tuple.Create(1339, new Point3D(6, 6, 0), 1, 32, 0, (string)null), // 611
			Tuple.Create(1339, new Point3D(6, 7, 0), 1, 32, 0, (string)null), // 612
			Tuple.Create(1339, new Point3D(6, 8, 0), 1, 32, 0, (string)null), // 613
			Tuple.Create(1339, new Point3D(6, 9, 0), 1, 32, 0, (string)null), // 614
			Tuple.Create(1339, new Point3D(6, 10, 0), 1, 32, 0, (string)null), // 615
			Tuple.Create(1339, new Point3D(6, 11, 0), 1, 32, 0, (string)null), // 616
			Tuple.Create(1339, new Point3D(6, 12, 0), 1, 32, 0, (string)null), // 617
			Tuple.Create(1339, new Point3D(7, 5, 0), 1, 32, 0, (string)null), // 618
			Tuple.Create(1339, new Point3D(7, 6, 0), 1, 32, 0, (string)null), // 619
			Tuple.Create(1339, new Point3D(7, 7, 0), 1, 32, 0, (string)null), // 620
			Tuple.Create(1339, new Point3D(7, 8, 0), 1, 32, 0, (string)null), // 621
			Tuple.Create(1339, new Point3D(7, 9, 0), 1, 32, 0, (string)null), // 622
			Tuple.Create(1339, new Point3D(7, 10, 0), 1, 32, 0, (string)null), // 623
			Tuple.Create(1339, new Point3D(7, 11, 0), 1, 32, 0, (string)null), // 624
			Tuple.Create(1339, new Point3D(7, 12, 0), 1, 32, 0, (string)null), // 625
			Tuple.Create(1339, new Point3D(8, 5, 0), 1, 32, 0, (string)null), // 626
			Tuple.Create(1339, new Point3D(8, 6, 0), 1, 32, 0, (string)null), // 627
			Tuple.Create(1339, new Point3D(8, 7, 0), 1, 32, 0, (string)null), // 628
			Tuple.Create(1339, new Point3D(8, 8, 0), 1, 32, 0, (string)null), // 629
			Tuple.Create(1339, new Point3D(8, 9, 0), 1, 32, 0, (string)null), // 630
			Tuple.Create(1339, new Point3D(8, 10, 0), 1, 32, 0, (string)null), // 631
			Tuple.Create(1339, new Point3D(8, 11, 0), 1, 32, 0, (string)null), // 632
			Tuple.Create(1339, new Point3D(8, 12, 0), 1, 32, 0, (string)null), // 633
			Tuple.Create(2083, new Point3D(-7, 12, 0), 1, 0, 0, (string)null), // 634
			Tuple.Create(2083, new Point3D(-6, 12, 0), 1, 0, 0, (string)null), // 635
			Tuple.Create(2083, new Point3D(-5, 12, 0), 1, 0, 0, (string)null), // 636
			Tuple.Create(2083, new Point3D(-4, 12, 0), 1, 0, 0, (string)null), // 637
			Tuple.Create(2083, new Point3D(-3, 12, 0), 1, 0, 0, (string)null), // 638
			Tuple.Create(2083, new Point3D(-2, 12, 0), 1, 0, 0, (string)null), // 639
			Tuple.Create(2083, new Point3D(-1, 12, 0), 1, 0, 0, (string)null), // 640
			Tuple.Create(2083, new Point3D(0, 12, 0), 1, 0, 0, (string)null), // 641
			Tuple.Create(2083, new Point3D(1, 12, 0), 1, 0, 0, (string)null), // 642
			Tuple.Create(2083, new Point3D(2, 12, 0), 1, 0, 0, (string)null), // 643
			Tuple.Create(2083, new Point3D(3, 12, 0), 1, 0, 0, (string)null), // 644
			Tuple.Create(2083, new Point3D(4, 12, 0), 1, 0, 0, (string)null), // 645
			Tuple.Create(2083, new Point3D(5, 12, 0), 1, 0, 0, (string)null), // 646
			Tuple.Create(2083, new Point3D(6, 12, 0), 1, 0, 0, (string)null), // 647
			Tuple.Create(2083, new Point3D(7, 12, 0), 1, 0, 0, (string)null), // 648
			Tuple.Create(2083, new Point3D(8, 12, 0), 1, 0, 0, (string)null), // 649
			Tuple.Create(2083, new Point3D(16, -12, 0), 1, 0, 0, (string)null), // 650
			Tuple.Create(2083, new Point3D(9, -12, 0), 1, 0, 0, (string)null), // 651
			Tuple.Create(2083, new Point3D(10, -12, 0), 1, 0, 0, (string)null), // 652
			Tuple.Create(2083, new Point3D(11, -12, 0), 1, 0, 0, (string)null), // 653
			Tuple.Create(2083, new Point3D(12, -12, 0), 1, 0, 0, (string)null), // 654
			Tuple.Create(2083, new Point3D(13, -12, 0), 1, 0, 0, (string)null), // 655
			Tuple.Create(2083, new Point3D(14, -12, 0), 1, 0, 0, (string)null), // 656
			Tuple.Create(2083, new Point3D(15, -12, 0), 1, 0, 0, (string)null), // 657
			Tuple.Create(1339, new Point3D(9, -11, 0), 1, 32, 0, (string)null), // 658
			Tuple.Create(1339, new Point3D(9, -10, 0), 1, 32, 0, (string)null), // 659
			Tuple.Create(1339, new Point3D(9, -9, 0), 1, 32, 0, (string)null), // 660
			Tuple.Create(1339, new Point3D(9, -8, 0), 1, 32, 0, (string)null), // 661
			Tuple.Create(1339, new Point3D(9, -7, 0), 1, 32, 0, (string)null), // 662
			Tuple.Create(1339, new Point3D(9, -6, 0), 1, 32, 0, (string)null), // 663
			Tuple.Create(1339, new Point3D(9, -5, 0), 1, 32, 0, (string)null), // 664
			Tuple.Create(1339, new Point3D(9, -4, 0), 1, 32, 0, (string)null), // 665
			Tuple.Create(1339, new Point3D(9, -3, 0), 1, 32, 0, (string)null), // 666
			Tuple.Create(1339, new Point3D(9, -2, 0), 1, 32, 0, (string)null), // 667
			Tuple.Create(1339, new Point3D(9, -1, 0), 1, 32, 0, (string)null), // 668
			Tuple.Create(1339, new Point3D(9, 0, 0), 1, 32, 0, (string)null), // 669
			Tuple.Create(1339, new Point3D(9, 1, 0), 1, 32, 0, (string)null), // 670
			Tuple.Create(1339, new Point3D(9, 2, 0), 1, 32, 0, (string)null), // 671
			Tuple.Create(1339, new Point3D(9, 3, 0), 1, 32, 0, (string)null), // 672
			Tuple.Create(1339, new Point3D(9, 4, 0), 1, 32, 0, (string)null), // 673
			Tuple.Create(1339, new Point3D(10, -11, 0), 1, 32, 0, (string)null), // 674
			Tuple.Create(1339, new Point3D(10, -10, 0), 1, 32, 0, (string)null), // 675
			Tuple.Create(1339, new Point3D(10, -9, 0), 1, 32, 0, (string)null), // 676
			Tuple.Create(1339, new Point3D(10, -8, 0), 1, 32, 0, (string)null), // 677
			Tuple.Create(1339, new Point3D(10, -7, 0), 1, 32, 0, (string)null), // 678
			Tuple.Create(1339, new Point3D(10, -6, 0), 1, 32, 0, (string)null), // 679
			Tuple.Create(1339, new Point3D(10, -5, 0), 1, 32, 0, (string)null), // 680
			Tuple.Create(1339, new Point3D(10, -4, 0), 1, 32, 0, (string)null), // 681
			Tuple.Create(1339, new Point3D(10, -3, 0), 1, 32, 0, (string)null), // 682
			Tuple.Create(1339, new Point3D(10, -2, 0), 1, 32, 0, (string)null), // 683
			Tuple.Create(1339, new Point3D(10, -1, 0), 1, 32, 0, (string)null), // 684
			Tuple.Create(1339, new Point3D(10, 0, 0), 1, 32, 0, (string)null), // 685
			Tuple.Create(1339, new Point3D(10, 1, 0), 1, 32, 0, (string)null), // 686
			Tuple.Create(1339, new Point3D(10, 2, 0), 1, 32, 0, (string)null), // 687
			Tuple.Create(1339, new Point3D(10, 3, 0), 1, 32, 0, (string)null), // 688
			Tuple.Create(1339, new Point3D(10, 4, 0), 1, 32, 0, (string)null), // 689
			Tuple.Create(1339, new Point3D(11, -11, 0), 1, 32, 0, (string)null), // 690
			Tuple.Create(1339, new Point3D(11, -10, 0), 1, 32, 0, (string)null), // 691
			Tuple.Create(1339, new Point3D(11, -9, 0), 1, 32, 0, (string)null), // 692
			Tuple.Create(1339, new Point3D(11, -8, 0), 1, 32, 0, (string)null), // 693
			Tuple.Create(1339, new Point3D(11, -7, 0), 1, 32, 0, (string)null), // 694
			Tuple.Create(1339, new Point3D(11, -6, 0), 1, 32, 0, (string)null), // 695
			Tuple.Create(1339, new Point3D(11, -5, 0), 1, 32, 0, (string)null), // 696
			Tuple.Create(1339, new Point3D(11, -4, 0), 1, 32, 0, (string)null), // 697
			Tuple.Create(1339, new Point3D(11, -3, 0), 1, 32, 0, (string)null), // 698
			Tuple.Create(1339, new Point3D(11, -2, 0), 1, 32, 0, (string)null), // 699
			Tuple.Create(1339, new Point3D(11, -1, 0), 1, 32, 0, (string)null), // 700
			Tuple.Create(1339, new Point3D(11, 0, 0), 1, 32, 0, (string)null), // 701
			Tuple.Create(1339, new Point3D(11, 1, 0), 1, 32, 0, (string)null), // 702
			Tuple.Create(1339, new Point3D(11, 2, 0), 1, 32, 0, (string)null), // 703
			Tuple.Create(1339, new Point3D(11, 3, 0), 1, 32, 0, (string)null), // 704
			Tuple.Create(1339, new Point3D(11, 4, 0), 1, 32, 0, (string)null), // 705
			Tuple.Create(1339, new Point3D(12, -11, 0), 1, 32, 0, (string)null), // 706
			Tuple.Create(1339, new Point3D(12, -10, 0), 1, 32, 0, (string)null), // 707
			Tuple.Create(1339, new Point3D(12, -9, 0), 1, 32, 0, (string)null), // 708
			Tuple.Create(1339, new Point3D(12, -8, 0), 1, 32, 0, (string)null), // 709
			Tuple.Create(1339, new Point3D(12, -7, 0), 1, 32, 0, (string)null), // 710
			Tuple.Create(1339, new Point3D(12, -6, 0), 1, 32, 0, (string)null), // 711
			Tuple.Create(1339, new Point3D(12, -5, 0), 1, 32, 0, (string)null), // 712
			Tuple.Create(1339, new Point3D(12, -4, 0), 1, 32, 0, (string)null), // 713
			Tuple.Create(1339, new Point3D(12, -3, 0), 1, 32, 0, (string)null), // 714
			Tuple.Create(1339, new Point3D(12, -2, 0), 1, 32, 0, (string)null), // 715
			Tuple.Create(1339, new Point3D(12, -1, 0), 1, 32, 0, (string)null), // 716
			Tuple.Create(1339, new Point3D(12, 0, 0), 1, 32, 0, (string)null), // 717
			Tuple.Create(1339, new Point3D(12, 1, 0), 1, 32, 0, (string)null), // 718
			Tuple.Create(1339, new Point3D(12, 2, 0), 1, 32, 0, (string)null), // 719
			Tuple.Create(1339, new Point3D(12, 3, 0), 1, 32, 0, (string)null), // 720
			Tuple.Create(1339, new Point3D(12, 4, 0), 1, 32, 0, (string)null), // 721
			Tuple.Create(1339, new Point3D(13, -11, 0), 1, 32, 0, (string)null), // 722
			Tuple.Create(1339, new Point3D(13, -10, 0), 1, 32, 0, (string)null), // 723
			Tuple.Create(1339, new Point3D(13, -9, 0), 1, 32, 0, (string)null), // 724
			Tuple.Create(1339, new Point3D(13, -8, 0), 1, 32, 0, (string)null), // 725
			Tuple.Create(1339, new Point3D(13, -7, 0), 1, 32, 0, (string)null), // 726
			Tuple.Create(1339, new Point3D(13, -6, 0), 1, 32, 0, (string)null), // 727
			Tuple.Create(1339, new Point3D(13, -5, 0), 1, 32, 0, (string)null), // 728
			Tuple.Create(1339, new Point3D(13, -4, 0), 1, 32, 0, (string)null), // 729
			Tuple.Create(1339, new Point3D(13, -3, 0), 1, 32, 0, (string)null), // 730
			Tuple.Create(1339, new Point3D(13, -2, 0), 1, 32, 0, (string)null), // 731
			Tuple.Create(1339, new Point3D(13, -1, 0), 1, 32, 0, (string)null), // 732
			Tuple.Create(1339, new Point3D(13, 0, 0), 1, 32, 0, (string)null), // 733
			Tuple.Create(1339, new Point3D(13, 1, 0), 1, 32, 0, (string)null), // 734
			Tuple.Create(1339, new Point3D(13, 2, 0), 1, 32, 0, (string)null), // 735
			Tuple.Create(1339, new Point3D(13, 3, 0), 1, 32, 0, (string)null), // 736
			Tuple.Create(1339, new Point3D(13, 4, 0), 1, 32, 0, (string)null), // 737
			Tuple.Create(1339, new Point3D(14, -11, 0), 1, 32, 0, (string)null), // 738
			Tuple.Create(1339, new Point3D(14, -10, 0), 1, 32, 0, (string)null), // 739
			Tuple.Create(1339, new Point3D(14, -9, 0), 1, 32, 0, (string)null), // 740
			Tuple.Create(1339, new Point3D(14, -8, 0), 1, 32, 0, (string)null), // 741
			Tuple.Create(1339, new Point3D(14, -7, 0), 1, 32, 0, (string)null), // 742
			Tuple.Create(1339, new Point3D(14, -6, 0), 1, 32, 0, (string)null), // 743
			Tuple.Create(1339, new Point3D(14, -5, 0), 1, 32, 0, (string)null), // 744
			Tuple.Create(1339, new Point3D(14, -4, 0), 1, 32, 0, (string)null), // 745
			Tuple.Create(1339, new Point3D(14, -3, 0), 1, 32, 0, (string)null), // 746
			Tuple.Create(1339, new Point3D(14, -2, 0), 1, 32, 0, (string)null), // 747
			Tuple.Create(1339, new Point3D(14, -1, 0), 1, 32, 0, (string)null), // 748
			Tuple.Create(1339, new Point3D(14, 0, 0), 1, 32, 0, (string)null), // 749
			Tuple.Create(1339, new Point3D(14, 1, 0), 1, 32, 0, (string)null), // 750
			Tuple.Create(1339, new Point3D(14, 2, 0), 1, 32, 0, (string)null), // 751
			Tuple.Create(1339, new Point3D(14, 3, 0), 1, 32, 0, (string)null), // 752
			Tuple.Create(1339, new Point3D(14, 4, 0), 1, 32, 0, (string)null), // 753
			Tuple.Create(1339, new Point3D(15, -11, 0), 1, 32, 0, (string)null), // 754
			Tuple.Create(1339, new Point3D(15, -10, 0), 1, 32, 0, (string)null), // 755
			Tuple.Create(1339, new Point3D(15, -9, 0), 1, 32, 0, (string)null), // 756
			Tuple.Create(1339, new Point3D(15, -8, 0), 1, 32, 0, (string)null), // 757
			Tuple.Create(1339, new Point3D(15, -7, 0), 1, 32, 0, (string)null), // 758
			Tuple.Create(1339, new Point3D(15, -6, 0), 1, 32, 0, (string)null), // 759
			Tuple.Create(1339, new Point3D(15, -5, 0), 1, 32, 0, (string)null), // 760
			Tuple.Create(1339, new Point3D(15, -4, 0), 1, 32, 0, (string)null), // 761
			Tuple.Create(1339, new Point3D(15, -3, 0), 1, 32, 0, (string)null), // 762
			Tuple.Create(1339, new Point3D(15, -2, 0), 1, 32, 0, (string)null), // 763
			Tuple.Create(1339, new Point3D(15, -1, 0), 1, 32, 0, (string)null), // 764
			Tuple.Create(1339, new Point3D(15, 0, 0), 1, 32, 0, (string)null), // 765
			Tuple.Create(1339, new Point3D(15, 1, 0), 1, 32, 0, (string)null), // 766
			Tuple.Create(1339, new Point3D(15, 2, 0), 1, 32, 0, (string)null), // 767
			Tuple.Create(1339, new Point3D(15, 3, 0), 1, 32, 0, (string)null), // 768
			Tuple.Create(1339, new Point3D(15, 4, 0), 1, 32, 0, (string)null), // 769
			Tuple.Create(1339, new Point3D(16, -11, 0), 1, 32, 0, (string)null), // 770
			Tuple.Create(1339, new Point3D(16, -10, 0), 1, 32, 0, (string)null), // 771
			Tuple.Create(1339, new Point3D(16, -9, 0), 1, 32, 0, (string)null), // 772
			Tuple.Create(1339, new Point3D(16, -8, 0), 1, 32, 0, (string)null), // 773
			Tuple.Create(1339, new Point3D(16, -7, 0), 1, 32, 0, (string)null), // 774
			Tuple.Create(1339, new Point3D(16, -6, 0), 1, 32, 0, (string)null), // 775
			Tuple.Create(1339, new Point3D(16, -5, 0), 1, 32, 0, (string)null), // 776
			Tuple.Create(1339, new Point3D(16, -4, 0), 1, 32, 0, (string)null), // 777
			Tuple.Create(1339, new Point3D(16, -3, 0), 1, 32, 0, (string)null), // 778
			Tuple.Create(1339, new Point3D(16, -2, 0), 1, 32, 0, (string)null), // 779
			Tuple.Create(1339, new Point3D(16, -1, 0), 1, 32, 0, (string)null), // 780
			Tuple.Create(1339, new Point3D(16, 0, 0), 1, 32, 0, (string)null), // 781
			Tuple.Create(1339, new Point3D(16, 1, 0), 1, 32, 0, (string)null), // 782
			Tuple.Create(1339, new Point3D(16, 2, 0), 1, 32, 0, (string)null), // 783
			Tuple.Create(1339, new Point3D(16, 3, 0), 1, 32, 0, (string)null), // 784
			Tuple.Create(1339, new Point3D(16, 4, 0), 1, 32, 0, (string)null), // 785
			Tuple.Create(2081, new Point3D(16, -11, 0), 1, 0, 0, (string)null), // 786
			Tuple.Create(2081, new Point3D(16, -10, 0), 1, 0, 0, (string)null), // 787
			Tuple.Create(2081, new Point3D(16, -9, 0), 1, 0, 0, (string)null), // 788
			Tuple.Create(2081, new Point3D(16, -8, 0), 1, 0, 0, (string)null), // 789
			Tuple.Create(2081, new Point3D(16, -7, 0), 1, 0, 0, (string)null), // 790
			Tuple.Create(2081, new Point3D(16, -6, 0), 1, 0, 0, (string)null), // 791
			Tuple.Create(2081, new Point3D(16, -5, 0), 1, 0, 0, (string)null), // 792
			Tuple.Create(2081, new Point3D(16, -4, 0), 1, 0, 0, (string)null), // 793
			Tuple.Create(2081, new Point3D(16, -3, 0), 1, 0, 0, (string)null), // 794
			Tuple.Create(2081, new Point3D(16, -2, 0), 1, 0, 0, (string)null), // 795
			Tuple.Create(2081, new Point3D(16, -1, 0), 1, 0, 0, (string)null), // 796
			Tuple.Create(2081, new Point3D(16, 0, 0), 1, 0, 0, (string)null), // 797
			Tuple.Create(2081, new Point3D(16, 1, 0), 1, 0, 0, (string)null), // 798
			Tuple.Create(2081, new Point3D(16, 2, 0), 1, 0, 0, (string)null), // 799
			Tuple.Create(2081, new Point3D(16, 3, 0), 1, 0, 0, (string)null), // 800
			Tuple.Create(2081, new Point3D(16, 4, 0), 1, 0, 0, (string)null), // 801
			Tuple.Create(1339, new Point3D(9, 5, 0), 1, 32, 0, (string)null), // 802
			Tuple.Create(1339, new Point3D(9, 6, 0), 1, 32, 0, (string)null), // 803
			Tuple.Create(1339, new Point3D(9, 7, 0), 1, 32, 0, (string)null), // 804
			Tuple.Create(1339, new Point3D(9, 8, 0), 1, 32, 0, (string)null), // 805
			Tuple.Create(1339, new Point3D(9, 9, 0), 1, 32, 0, (string)null), // 806
			Tuple.Create(1339, new Point3D(9, 10, 0), 1, 32, 0, (string)null), // 807
			Tuple.Create(1339, new Point3D(9, 11, 0), 1, 32, 0, (string)null), // 808
			Tuple.Create(1339, new Point3D(9, 12, 0), 1, 32, 0, (string)null), // 809
			Tuple.Create(1339, new Point3D(10, 5, 0), 1, 32, 0, (string)null), // 810
			Tuple.Create(1339, new Point3D(10, 6, 0), 1, 32, 0, (string)null), // 811
			Tuple.Create(1339, new Point3D(10, 7, 0), 1, 32, 0, (string)null), // 812
			Tuple.Create(1339, new Point3D(10, 8, 0), 1, 32, 0, (string)null), // 813
			Tuple.Create(1339, new Point3D(10, 9, 0), 1, 32, 0, (string)null), // 814
			Tuple.Create(1339, new Point3D(10, 10, 0), 1, 32, 0, (string)null), // 815
			Tuple.Create(1339, new Point3D(10, 11, 0), 1, 32, 0, (string)null), // 816
			Tuple.Create(1339, new Point3D(10, 12, 0), 1, 32, 0, (string)null), // 817
			Tuple.Create(1339, new Point3D(11, 5, 0), 1, 32, 0, (string)null), // 818
			Tuple.Create(1339, new Point3D(11, 6, 0), 1, 32, 0, (string)null), // 819
			Tuple.Create(1339, new Point3D(11, 7, 0), 1, 32, 0, (string)null), // 820
			Tuple.Create(1339, new Point3D(11, 8, 0), 1, 32, 0, (string)null), // 821
			Tuple.Create(1339, new Point3D(11, 9, 0), 1, 32, 0, (string)null), // 822
			Tuple.Create(1339, new Point3D(11, 10, 0), 1, 32, 0, (string)null), // 823
			Tuple.Create(1339, new Point3D(11, 11, 0), 1, 32, 0, (string)null), // 824
			Tuple.Create(1339, new Point3D(11, 12, 0), 1, 32, 0, (string)null), // 825
			Tuple.Create(1339, new Point3D(12, 5, 0), 1, 32, 0, (string)null), // 826
			Tuple.Create(1339, new Point3D(12, 6, 0), 1, 32, 0, (string)null), // 827
			Tuple.Create(1339, new Point3D(12, 7, 0), 1, 32, 0, (string)null), // 828
			Tuple.Create(1339, new Point3D(12, 8, 0), 1, 32, 0, (string)null), // 829
			Tuple.Create(1339, new Point3D(12, 9, 0), 1, 32, 0, (string)null), // 830
			Tuple.Create(1339, new Point3D(12, 10, 0), 1, 32, 0, (string)null), // 831
			Tuple.Create(1339, new Point3D(12, 11, 0), 1, 32, 0, (string)null), // 832
			Tuple.Create(1339, new Point3D(12, 12, 0), 1, 32, 0, (string)null), // 833
			Tuple.Create(1339, new Point3D(13, 5, 0), 1, 32, 0, (string)null), // 834
			Tuple.Create(1339, new Point3D(13, 6, 0), 1, 32, 0, (string)null), // 835
			Tuple.Create(1339, new Point3D(13, 7, 0), 1, 32, 0, (string)null), // 836
			Tuple.Create(1339, new Point3D(13, 8, 0), 1, 32, 0, (string)null), // 837
			Tuple.Create(1339, new Point3D(13, 9, 0), 1, 32, 0, (string)null), // 838
			Tuple.Create(1339, new Point3D(13, 10, 0), 1, 32, 0, (string)null), // 839
			Tuple.Create(1339, new Point3D(13, 11, 0), 1, 32, 0, (string)null), // 840
			Tuple.Create(1339, new Point3D(13, 12, 0), 1, 32, 0, (string)null), // 841
			Tuple.Create(1339, new Point3D(14, 5, 0), 1, 32, 0, (string)null), // 842
			Tuple.Create(1339, new Point3D(14, 6, 0), 1, 32, 0, (string)null), // 843
			Tuple.Create(1339, new Point3D(14, 7, 0), 1, 32, 0, (string)null), // 844
			Tuple.Create(1339, new Point3D(14, 8, 0), 1, 32, 0, (string)null), // 845
			Tuple.Create(1339, new Point3D(14, 9, 0), 1, 32, 0, (string)null), // 846
			Tuple.Create(1339, new Point3D(14, 10, 0), 1, 32, 0, (string)null), // 847
			Tuple.Create(1339, new Point3D(14, 11, 0), 1, 32, 0, (string)null), // 848
			Tuple.Create(1339, new Point3D(14, 12, 0), 1, 32, 0, (string)null), // 849
			Tuple.Create(1339, new Point3D(15, 5, 0), 1, 32, 0, (string)null), // 850
			Tuple.Create(1339, new Point3D(15, 6, 0), 1, 32, 0, (string)null), // 851
			Tuple.Create(1339, new Point3D(15, 7, 0), 1, 32, 0, (string)null), // 852
			Tuple.Create(1339, new Point3D(15, 8, 0), 1, 32, 0, (string)null), // 853
			Tuple.Create(1339, new Point3D(15, 9, 0), 1, 32, 0, (string)null), // 854
			Tuple.Create(1339, new Point3D(15, 10, 0), 1, 32, 0, (string)null), // 855
			Tuple.Create(1339, new Point3D(15, 11, 0), 1, 32, 0, (string)null), // 856
			Tuple.Create(1339, new Point3D(15, 12, 0), 1, 32, 0, (string)null), // 857
			Tuple.Create(1339, new Point3D(16, 5, 0), 1, 32, 0, (string)null), // 858
			Tuple.Create(1339, new Point3D(16, 6, 0), 1, 32, 0, (string)null), // 859
			Tuple.Create(1339, new Point3D(16, 7, 0), 1, 32, 0, (string)null), // 860
			Tuple.Create(1339, new Point3D(16, 8, 0), 1, 32, 0, (string)null), // 861
			Tuple.Create(1339, new Point3D(16, 9, 0), 1, 32, 0, (string)null), // 862
			Tuple.Create(1339, new Point3D(16, 10, 0), 1, 32, 0, (string)null), // 863
			Tuple.Create(1339, new Point3D(16, 11, 0), 1, 32, 0, (string)null), // 864
			Tuple.Create(1339, new Point3D(16, 12, 0), 1, 32, 0, (string)null), // 865
			Tuple.Create(2082, new Point3D(16, 12, 0), 1, 0, 0, (string)null), // 866
			Tuple.Create(2083, new Point3D(9, 12, 0), 1, 0, 0, (string)null), // 867
			Tuple.Create(2083, new Point3D(10, 12, 0), 1, 0, 0, (string)null), // 868
			Tuple.Create(2083, new Point3D(11, 12, 0), 1, 0, 0, (string)null), // 869
			Tuple.Create(2083, new Point3D(12, 12, 0), 1, 0, 0, (string)null), // 870
			Tuple.Create(2083, new Point3D(13, 12, 0), 1, 0, 0, (string)null), // 871
			Tuple.Create(2083, new Point3D(14, 12, 0), 1, 0, 0, (string)null), // 872
			Tuple.Create(2083, new Point3D(15, 12, 0), 1, 0, 0, (string)null), // 873
			Tuple.Create(2081, new Point3D(16, 5, 0), 1, 0, 0, (string)null), // 874
			Tuple.Create(2081, new Point3D(16, 6, 0), 1, 0, 0, (string)null), // 875
			Tuple.Create(2081, new Point3D(16, 7, 0), 1, 0, 0, (string)null), // 876
			Tuple.Create(2081, new Point3D(16, 8, 0), 1, 0, 0, (string)null), // 877
			Tuple.Create(2081, new Point3D(16, 9, 0), 1, 0, 0, (string)null), // 878
			Tuple.Create(2081, new Point3D(16, 10, 0), 1, 0, 0, (string)null), // 879
			Tuple.Create(2081, new Point3D(16, 11, 0), 1, 0, 0, (string)null) // 880
		};
		
		public override BaseAddonDeed Deed { get { return new PVPRoomAddonDeed(); } }

		[Constructable]
		public PVPRoomAddon()
		{
			Name = "PVPRoom Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public PVPRoomAddon(Serial serial) 
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

	public class PVPRoomAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new PVPRoomAddon(); } }

		[Constructable]
		public PVPRoomAddonDeed()
		{
			Name = "PVP Room Deed";
		}

		public PVPRoomAddonDeed(Serial serial) 
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
