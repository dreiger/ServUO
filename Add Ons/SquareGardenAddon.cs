#region Header
/*
 * Name: SquareGarden
 */
#endregion

#region References
using System;
#endregion

namespace Server.Items
{
	public class SquareGardenAddon : BaseAddon
	{
		private static readonly Tuple<int, Point3D, int, int, int, string>[] _Components = new[]
		{
			Tuple.Create(12788, new Point3D(-7, -7, 0), 1, 0, 0, (string)null), // 1
			Tuple.Create(12788, new Point3D(-7, -6, 0), 1, 0, 0, (string)null), // 2
			Tuple.Create(12788, new Point3D(-7, -5, 0), 1, 0, 0, (string)null), // 3
			Tuple.Create(12788, new Point3D(-7, -4, 0), 1, 0, 0, (string)null), // 4
			Tuple.Create(12788, new Point3D(-7, -3, 0), 1, 0, 0, (string)null), // 5
			Tuple.Create(12788, new Point3D(-7, -2, 0), 1, 0, 0, (string)null), // 6
			Tuple.Create(12788, new Point3D(-7, -1, 0), 1, 0, 0, (string)null), // 7
			Tuple.Create(12788, new Point3D(-7, 0, 0), 1, 0, 0, (string)null), // 8
			Tuple.Create(12788, new Point3D(-7, 1, 0), 1, 0, 0, (string)null), // 9
			Tuple.Create(12788, new Point3D(-6, -7, 0), 1, 0, 0, (string)null), // 10
			Tuple.Create(12788, new Point3D(-6, -6, 0), 1, 0, 0, (string)null), // 11
			Tuple.Create(12788, new Point3D(-6, -5, 0), 1, 0, 0, (string)null), // 12
			Tuple.Create(12788, new Point3D(-6, -4, 0), 1, 0, 0, (string)null), // 13
			Tuple.Create(12788, new Point3D(-6, -3, 0), 1, 0, 0, (string)null), // 14
			Tuple.Create(12788, new Point3D(-6, -2, 0), 1, 0, 0, (string)null), // 15
			Tuple.Create(12788, new Point3D(-6, -1, 0), 1, 0, 0, (string)null), // 16
			Tuple.Create(12788, new Point3D(-6, 0, 0), 1, 0, 0, (string)null), // 17
			Tuple.Create(12788, new Point3D(-6, 1, 0), 1, 0, 0, (string)null), // 18
			Tuple.Create(12788, new Point3D(-5, -7, 0), 1, 0, 0, (string)null), // 19
			Tuple.Create(12788, new Point3D(-5, -6, 0), 1, 0, 0, (string)null), // 20
			Tuple.Create(12788, new Point3D(-5, -5, 0), 1, 0, 0, (string)null), // 21
			Tuple.Create(12788, new Point3D(-5, -4, 0), 1, 0, 0, (string)null), // 22
			Tuple.Create(12788, new Point3D(-5, -3, 0), 1, 0, 0, (string)null), // 23
			Tuple.Create(12788, new Point3D(-5, -2, 0), 1, 0, 0, (string)null), // 24
			Tuple.Create(12788, new Point3D(-5, -1, 0), 1, 0, 0, (string)null), // 25
			Tuple.Create(12788, new Point3D(-5, 0, 0), 1, 0, 0, (string)null), // 26
			Tuple.Create(12788, new Point3D(-5, 1, 0), 1, 0, 0, (string)null), // 27
			Tuple.Create(12788, new Point3D(-4, -7, 0), 1, 0, 0, (string)null), // 28
			Tuple.Create(12788, new Point3D(-4, -6, 0), 1, 0, 0, (string)null), // 29
			Tuple.Create(12788, new Point3D(-4, -5, 0), 1, 0, 0, (string)null), // 30
			Tuple.Create(12788, new Point3D(-4, -4, 0), 1, 0, 0, (string)null), // 31
			Tuple.Create(12788, new Point3D(-4, -3, 0), 1, 0, 0, (string)null), // 32
			Tuple.Create(12788, new Point3D(-4, -2, 0), 1, 0, 0, (string)null), // 33
			Tuple.Create(12788, new Point3D(-4, -1, 0), 1, 0, 0, (string)null), // 34
			Tuple.Create(12788, new Point3D(-4, 0, 0), 1, 0, 0, (string)null), // 35
			Tuple.Create(12788, new Point3D(-4, 1, 0), 1, 0, 0, (string)null), // 36
			Tuple.Create(12788, new Point3D(-3, -7, 0), 1, 0, 0, (string)null), // 37
			Tuple.Create(12788, new Point3D(-3, -6, 0), 1, 0, 0, (string)null), // 38
			Tuple.Create(12788, new Point3D(-3, -5, 0), 1, 0, 0, (string)null), // 39
			Tuple.Create(12788, new Point3D(-3, -4, 0), 1, 0, 0, (string)null), // 40
			Tuple.Create(12788, new Point3D(-3, -3, 0), 1, 0, 0, (string)null), // 41
			Tuple.Create(12788, new Point3D(-3, -2, 0), 1, 0, 0, (string)null), // 42
			Tuple.Create(12788, new Point3D(-3, -1, 0), 1, 0, 0, (string)null), // 43
			Tuple.Create(12788, new Point3D(-3, 0, 0), 1, 0, 0, (string)null), // 44
			Tuple.Create(12788, new Point3D(-3, 1, 0), 1, 0, 0, (string)null), // 45
			Tuple.Create(12788, new Point3D(-2, -7, 0), 1, 0, 0, (string)null), // 46
			Tuple.Create(12788, new Point3D(-2, -6, 0), 1, 0, 0, (string)null), // 47
			Tuple.Create(12788, new Point3D(-2, -5, 0), 1, 0, 0, (string)null), // 48
			Tuple.Create(12788, new Point3D(-2, -4, 0), 1, 0, 0, (string)null), // 49
			Tuple.Create(12788, new Point3D(-2, -3, 0), 1, 0, 0, (string)null), // 50
			Tuple.Create(12788, new Point3D(-2, -2, 0), 1, 0, 0, (string)null), // 51
			Tuple.Create(12788, new Point3D(-2, -1, 0), 1, 0, 0, (string)null), // 52
			Tuple.Create(12788, new Point3D(-2, 0, 0), 1, 0, 0, (string)null), // 53
			Tuple.Create(12788, new Point3D(-2, 1, 0), 1, 0, 0, (string)null), // 54
			Tuple.Create(12788, new Point3D(-1, -7, 0), 1, 0, 0, (string)null), // 55
			Tuple.Create(12788, new Point3D(-1, -6, 0), 1, 0, 0, (string)null), // 56
			Tuple.Create(12788, new Point3D(-1, -5, 0), 1, 0, 0, (string)null), // 57
			Tuple.Create(12788, new Point3D(-1, -4, 0), 1, 0, 0, (string)null), // 58
			Tuple.Create(12788, new Point3D(-1, -3, 0), 1, 0, 0, (string)null), // 59
			Tuple.Create(12788, new Point3D(-1, -2, 0), 1, 0, 0, (string)null), // 60
			Tuple.Create(12788, new Point3D(-1, -1, 0), 1, 0, 0, (string)null), // 61
			Tuple.Create(12788, new Point3D(-1, 0, 0), 1, 0, 0, (string)null), // 62
			Tuple.Create(12788, new Point3D(-1, 1, 0), 1, 0, 0, (string)null), // 63
			Tuple.Create(12788, new Point3D(0, -7, 0), 1, 0, 0, (string)null), // 64
			Tuple.Create(12788, new Point3D(0, -6, 0), 1, 0, 0, (string)null), // 65
			Tuple.Create(12788, new Point3D(0, -5, 0), 1, 0, 0, (string)null), // 66
			Tuple.Create(12788, new Point3D(0, -4, 0), 1, 0, 0, (string)null), // 67
			Tuple.Create(12788, new Point3D(0, -3, 0), 1, 0, 0, (string)null), // 68
			Tuple.Create(12788, new Point3D(0, -2, 0), 1, 0, 0, (string)null), // 69
			Tuple.Create(12788, new Point3D(0, -1, 0), 1, 0, 0, (string)null), // 70
			Tuple.Create(12788, new Point3D(0, 0, 0), 1, 0, 0, (string)null), // 71
			Tuple.Create(12788, new Point3D(0, 1, 0), 1, 0, 0, (string)null), // 72
			Tuple.Create(12788, new Point3D(1, -7, 0), 1, 0, 0, (string)null), // 73
			Tuple.Create(12788, new Point3D(1, -6, 0), 1, 0, 0, (string)null), // 74
			Tuple.Create(12788, new Point3D(1, -5, 0), 1, 0, 0, (string)null), // 75
			Tuple.Create(12788, new Point3D(1, -4, 0), 1, 0, 0, (string)null), // 76
			Tuple.Create(12788, new Point3D(1, -3, 0), 1, 0, 0, (string)null), // 77
			Tuple.Create(12788, new Point3D(1, -2, 0), 1, 0, 0, (string)null), // 78
			Tuple.Create(12788, new Point3D(1, -1, 0), 1, 0, 0, (string)null), // 79
			Tuple.Create(12788, new Point3D(1, 0, 0), 1, 0, 0, (string)null), // 80
			Tuple.Create(12788, new Point3D(1, 1, 0), 1, 0, 0, (string)null), // 81
			Tuple.Create(2147, new Point3D(-7, -8, 0), 1, 0, 0, (string)null), // 82
			Tuple.Create(2147, new Point3D(-6, -8, 0), 1, 0, 0, (string)null), // 83
			Tuple.Create(2147, new Point3D(-5, -8, 0), 1, 0, 0, (string)null), // 84
			Tuple.Create(2147, new Point3D(-4, -8, 0), 1, 0, 0, (string)null), // 85
			Tuple.Create(2147, new Point3D(-3, -8, 0), 1, 0, 0, (string)null), // 86
			Tuple.Create(2147, new Point3D(-2, -8, 0), 1, 0, 0, (string)null), // 87
			Tuple.Create(2147, new Point3D(-1, -8, 0), 1, 0, 0, (string)null), // 88
			Tuple.Create(2147, new Point3D(0, -8, 0), 1, 0, 0, (string)null), // 89
			Tuple.Create(2147, new Point3D(1, -8, 0), 1, 0, 0, (string)null), // 90
			Tuple.Create(2143, new Point3D(-8, -8, 0), 1, 0, 0, (string)null), // 91
			Tuple.Create(2148, new Point3D(-8, -7, 0), 1, 0, 0, (string)null), // 92
			Tuple.Create(2148, new Point3D(-8, -6, 0), 1, 0, 0, (string)null), // 93
			Tuple.Create(2148, new Point3D(-8, -5, 0), 1, 0, 0, (string)null), // 94
			Tuple.Create(2148, new Point3D(-8, -4, 0), 1, 0, 0, (string)null), // 95
			Tuple.Create(2148, new Point3D(-8, -3, 0), 1, 0, 0, (string)null), // 96
			Tuple.Create(2148, new Point3D(-8, -2, 0), 1, 0, 0, (string)null), // 97
			Tuple.Create(2148, new Point3D(-8, -1, 0), 1, 0, 0, (string)null), // 98
			Tuple.Create(2148, new Point3D(-8, 0, 0), 1, 0, 0, (string)null), // 99
			Tuple.Create(2148, new Point3D(-8, 1, 0), 1, 0, 0, (string)null), // 100
			Tuple.Create(12788, new Point3D(-7, 2, 0), 1, 0, 0, (string)null), // 101
			Tuple.Create(12788, new Point3D(-7, 3, 0), 1, 0, 0, (string)null), // 102
			Tuple.Create(12788, new Point3D(-7, 4, 0), 1, 0, 0, (string)null), // 103
			Tuple.Create(12788, new Point3D(-7, 5, 0), 1, 0, 0, (string)null), // 104
			Tuple.Create(12788, new Point3D(-7, 6, 0), 1, 0, 0, (string)null), // 105
			Tuple.Create(12788, new Point3D(-7, 7, 0), 1, 0, 0, (string)null), // 106
			Tuple.Create(12788, new Point3D(-7, 8, 0), 1, 0, 0, (string)null), // 107
			Tuple.Create(12788, new Point3D(-7, 9, 0), 1, 0, 0, (string)null), // 108
			Tuple.Create(12788, new Point3D(-6, 2, 0), 1, 0, 0, (string)null), // 109
			Tuple.Create(12788, new Point3D(-6, 3, 0), 1, 0, 0, (string)null), // 110
			Tuple.Create(12788, new Point3D(-6, 4, 0), 1, 0, 0, (string)null), // 111
			Tuple.Create(12788, new Point3D(-6, 5, 0), 1, 0, 0, (string)null), // 112
			Tuple.Create(12788, new Point3D(-6, 6, 0), 1, 0, 0, (string)null), // 113
			Tuple.Create(12788, new Point3D(-6, 7, 0), 1, 0, 0, (string)null), // 114
			Tuple.Create(12788, new Point3D(-6, 8, 0), 1, 0, 0, (string)null), // 115
			Tuple.Create(12788, new Point3D(-6, 9, 0), 1, 0, 0, (string)null), // 116
			Tuple.Create(12788, new Point3D(-5, 2, 0), 1, 0, 0, (string)null), // 117
			Tuple.Create(12788, new Point3D(-5, 3, 0), 1, 0, 0, (string)null), // 118
			Tuple.Create(12788, new Point3D(-5, 4, 0), 1, 0, 0, (string)null), // 119
			Tuple.Create(12788, new Point3D(-5, 5, 0), 1, 0, 0, (string)null), // 120
			Tuple.Create(12788, new Point3D(-5, 6, 0), 1, 0, 0, (string)null), // 121
			Tuple.Create(12788, new Point3D(-5, 7, 0), 1, 0, 0, (string)null), // 122
			Tuple.Create(12788, new Point3D(-5, 8, 0), 1, 0, 0, (string)null), // 123
			Tuple.Create(12788, new Point3D(-5, 9, 0), 1, 0, 0, (string)null), // 124
			Tuple.Create(12788, new Point3D(-4, 2, 0), 1, 0, 0, (string)null), // 125
			Tuple.Create(12788, new Point3D(-4, 3, 0), 1, 0, 0, (string)null), // 126
			Tuple.Create(12788, new Point3D(-4, 4, 0), 1, 0, 0, (string)null), // 127
			Tuple.Create(12788, new Point3D(-4, 5, 0), 1, 0, 0, (string)null), // 128
			Tuple.Create(12788, new Point3D(-4, 6, 0), 1, 0, 0, (string)null), // 129
			Tuple.Create(12788, new Point3D(-4, 7, 0), 1, 0, 0, (string)null), // 130
			Tuple.Create(12788, new Point3D(-4, 8, 0), 1, 0, 0, (string)null), // 131
			Tuple.Create(12788, new Point3D(-4, 9, 0), 1, 0, 0, (string)null), // 132
			Tuple.Create(12788, new Point3D(-3, 2, 0), 1, 0, 0, (string)null), // 133
			Tuple.Create(12788, new Point3D(-3, 3, 0), 1, 0, 0, (string)null), // 134
			Tuple.Create(12788, new Point3D(-3, 4, 0), 1, 0, 0, (string)null), // 135
			Tuple.Create(12788, new Point3D(-3, 5, 0), 1, 0, 0, (string)null), // 136
			Tuple.Create(12788, new Point3D(-3, 6, 0), 1, 0, 0, (string)null), // 137
			Tuple.Create(12788, new Point3D(-3, 7, 0), 1, 0, 0, (string)null), // 138
			Tuple.Create(12788, new Point3D(-3, 8, 0), 1, 0, 0, (string)null), // 139
			Tuple.Create(12788, new Point3D(-3, 9, 0), 1, 0, 0, (string)null), // 140
			Tuple.Create(12788, new Point3D(-2, 2, 0), 1, 0, 0, (string)null), // 141
			Tuple.Create(12788, new Point3D(-2, 3, 0), 1, 0, 0, (string)null), // 142
			Tuple.Create(12788, new Point3D(-2, 4, 0), 1, 0, 0, (string)null), // 143
			Tuple.Create(12788, new Point3D(-2, 5, 0), 1, 0, 0, (string)null), // 144
			Tuple.Create(12788, new Point3D(-2, 6, 0), 1, 0, 0, (string)null), // 145
			Tuple.Create(12788, new Point3D(-2, 7, 0), 1, 0, 0, (string)null), // 146
			Tuple.Create(12788, new Point3D(-2, 8, 0), 1, 0, 0, (string)null), // 147
			Tuple.Create(12788, new Point3D(-2, 9, 0), 1, 0, 0, (string)null), // 148
			Tuple.Create(12788, new Point3D(-1, 2, 0), 1, 0, 0, (string)null), // 149
			Tuple.Create(12788, new Point3D(-1, 3, 0), 1, 0, 0, (string)null), // 150
			Tuple.Create(12788, new Point3D(-1, 4, 0), 1, 0, 0, (string)null), // 151
			Tuple.Create(12788, new Point3D(-1, 5, 0), 1, 0, 0, (string)null), // 152
			Tuple.Create(12788, new Point3D(-1, 6, 0), 1, 0, 0, (string)null), // 153
			Tuple.Create(12788, new Point3D(-1, 7, 0), 1, 0, 0, (string)null), // 154
			Tuple.Create(12788, new Point3D(-1, 8, 0), 1, 0, 0, (string)null), // 155
			Tuple.Create(12788, new Point3D(-1, 9, 0), 1, 0, 0, (string)null), // 156
			Tuple.Create(12788, new Point3D(0, 2, 0), 1, 0, 0, (string)null), // 157
			Tuple.Create(12788, new Point3D(0, 3, 0), 1, 0, 0, (string)null), // 158
			Tuple.Create(12788, new Point3D(0, 4, 0), 1, 0, 0, (string)null), // 159
			Tuple.Create(12788, new Point3D(0, 5, 0), 1, 0, 0, (string)null), // 160
			Tuple.Create(12788, new Point3D(0, 6, 0), 1, 0, 0, (string)null), // 161
			Tuple.Create(12788, new Point3D(0, 7, 0), 1, 0, 0, (string)null), // 162
			Tuple.Create(12788, new Point3D(0, 8, 0), 1, 0, 0, (string)null), // 163
			Tuple.Create(12788, new Point3D(0, 9, 0), 1, 0, 0, (string)null), // 164
			Tuple.Create(12788, new Point3D(1, 2, 0), 1, 0, 0, (string)null), // 165
			Tuple.Create(12788, new Point3D(1, 3, 0), 1, 0, 0, (string)null), // 166
			Tuple.Create(12788, new Point3D(1, 4, 0), 1, 0, 0, (string)null), // 167
			Tuple.Create(12788, new Point3D(1, 5, 0), 1, 0, 0, (string)null), // 168
			Tuple.Create(12788, new Point3D(1, 6, 0), 1, 0, 0, (string)null), // 169
			Tuple.Create(12788, new Point3D(1, 7, 0), 1, 0, 0, (string)null), // 170
			Tuple.Create(12788, new Point3D(1, 8, 0), 1, 0, 0, (string)null), // 171
			Tuple.Create(12788, new Point3D(1, 9, 0), 1, 0, 0, (string)null), // 172
			Tuple.Create(2148, new Point3D(-8, 2, 0), 1, 0, 0, (string)null), // 173
			Tuple.Create(2148, new Point3D(-8, 3, 0), 1, 0, 0, (string)null), // 174
			Tuple.Create(2148, new Point3D(-8, 4, 0), 1, 0, 0, (string)null), // 175
			Tuple.Create(2148, new Point3D(-8, 5, 0), 1, 0, 0, (string)null), // 176
			Tuple.Create(2148, new Point3D(-8, 6, 0), 1, 0, 0, (string)null), // 177
			Tuple.Create(2148, new Point3D(-8, 7, 0), 1, 0, 0, (string)null), // 178
			Tuple.Create(2148, new Point3D(-8, 8, 0), 1, 0, 0, (string)null), // 179
			Tuple.Create(2148, new Point3D(-8, 9, 0), 1, 0, 0, (string)null), // 180
			Tuple.Create(2147, new Point3D(-7, 9, 0), 1, 0, 0, (string)null), // 181
			Tuple.Create(2147, new Point3D(-6, 9, 0), 1, 0, 0, (string)null), // 182
			Tuple.Create(2147, new Point3D(-5, 9, 0), 1, 0, 0, (string)null), // 183
			Tuple.Create(2147, new Point3D(-4, 9, 0), 1, 0, 0, (string)null), // 184
			Tuple.Create(2147, new Point3D(-3, 9, 0), 1, 0, 0, (string)null), // 185
			Tuple.Create(2147, new Point3D(-2, 9, 0), 1, 0, 0, (string)null), // 186
			Tuple.Create(2147, new Point3D(-1, 9, 0), 1, 0, 0, (string)null), // 187
			Tuple.Create(2143, new Point3D(1, 9, 0), 1, 0, 0, (string)null), // 188
			Tuple.Create(12788, new Point3D(2, -7, 0), 1, 0, 0, (string)null), // 189
			Tuple.Create(12788, new Point3D(2, -6, 0), 1, 0, 0, (string)null), // 190
			Tuple.Create(12788, new Point3D(2, -5, 0), 1, 0, 0, (string)null), // 191
			Tuple.Create(12788, new Point3D(2, -4, 0), 1, 0, 0, (string)null), // 192
			Tuple.Create(12788, new Point3D(2, -3, 0), 1, 0, 0, (string)null), // 193
			Tuple.Create(12788, new Point3D(2, -2, 0), 1, 0, 0, (string)null), // 194
			Tuple.Create(12788, new Point3D(2, -1, 0), 1, 0, 0, (string)null), // 195
			Tuple.Create(12788, new Point3D(2, 0, 0), 1, 0, 0, (string)null), // 196
			Tuple.Create(12788, new Point3D(2, 1, 0), 1, 0, 0, (string)null), // 197
			Tuple.Create(12788, new Point3D(3, -7, 0), 1, 0, 0, (string)null), // 198
			Tuple.Create(12788, new Point3D(3, -6, 0), 1, 0, 0, (string)null), // 199
			Tuple.Create(12788, new Point3D(3, -5, 0), 1, 0, 0, (string)null), // 200
			Tuple.Create(12788, new Point3D(3, -4, 0), 1, 0, 0, (string)null), // 201
			Tuple.Create(12788, new Point3D(3, -3, 0), 1, 0, 0, (string)null), // 202
			Tuple.Create(12788, new Point3D(3, -2, 0), 1, 0, 0, (string)null), // 203
			Tuple.Create(12788, new Point3D(3, -1, 0), 1, 0, 0, (string)null), // 204
			Tuple.Create(12788, new Point3D(3, 0, 0), 1, 0, 0, (string)null), // 205
			Tuple.Create(12788, new Point3D(3, 1, 0), 1, 0, 0, (string)null), // 206
			Tuple.Create(12788, new Point3D(4, -7, 0), 1, 0, 0, (string)null), // 207
			Tuple.Create(12788, new Point3D(4, -6, 0), 1, 0, 0, (string)null), // 208
			Tuple.Create(12788, new Point3D(4, -5, 0), 1, 0, 0, (string)null), // 209
			Tuple.Create(12788, new Point3D(4, -4, 0), 1, 0, 0, (string)null), // 210
			Tuple.Create(12788, new Point3D(4, -3, 0), 1, 0, 0, (string)null), // 211
			Tuple.Create(12788, new Point3D(4, -2, 0), 1, 0, 0, (string)null), // 212
			Tuple.Create(12788, new Point3D(4, -1, 0), 1, 0, 0, (string)null), // 213
			Tuple.Create(12788, new Point3D(4, 0, 0), 1, 0, 0, (string)null), // 214
			Tuple.Create(12788, new Point3D(4, 1, 0), 1, 0, 0, (string)null), // 215
			Tuple.Create(12788, new Point3D(5, -7, 0), 1, 0, 0, (string)null), // 216
			Tuple.Create(12788, new Point3D(5, -6, 0), 1, 0, 0, (string)null), // 217
			Tuple.Create(12788, new Point3D(5, -5, 0), 1, 0, 0, (string)null), // 218
			Tuple.Create(12788, new Point3D(5, -4, 0), 1, 0, 0, (string)null), // 219
			Tuple.Create(12788, new Point3D(5, -3, 0), 1, 0, 0, (string)null), // 220
			Tuple.Create(12788, new Point3D(5, -2, 0), 1, 0, 0, (string)null), // 221
			Tuple.Create(12788, new Point3D(5, -1, 0), 1, 0, 0, (string)null), // 222
			Tuple.Create(12788, new Point3D(5, 0, 0), 1, 0, 0, (string)null), // 223
			Tuple.Create(12788, new Point3D(5, 1, 0), 1, 0, 0, (string)null), // 224
			Tuple.Create(12788, new Point3D(6, -7, 0), 1, 0, 0, (string)null), // 225
			Tuple.Create(12788, new Point3D(6, -6, 0), 1, 0, 0, (string)null), // 226
			Tuple.Create(12788, new Point3D(6, -5, 0), 1, 0, 0, (string)null), // 227
			Tuple.Create(12788, new Point3D(6, -4, 0), 1, 0, 0, (string)null), // 228
			Tuple.Create(12788, new Point3D(6, -3, 0), 1, 0, 0, (string)null), // 229
			Tuple.Create(12788, new Point3D(6, -2, 0), 1, 0, 0, (string)null), // 230
			Tuple.Create(12788, new Point3D(6, -1, 0), 1, 0, 0, (string)null), // 231
			Tuple.Create(12788, new Point3D(6, 0, 0), 1, 0, 0, (string)null), // 232
			Tuple.Create(12788, new Point3D(6, 1, 0), 1, 0, 0, (string)null), // 233
			Tuple.Create(12788, new Point3D(7, -7, 0), 1, 0, 0, (string)null), // 234
			Tuple.Create(12788, new Point3D(7, -6, 0), 1, 0, 0, (string)null), // 235
			Tuple.Create(12788, new Point3D(7, -5, 0), 1, 0, 0, (string)null), // 236
			Tuple.Create(12788, new Point3D(7, -4, 0), 1, 0, 0, (string)null), // 237
			Tuple.Create(12788, new Point3D(7, -3, 0), 1, 0, 0, (string)null), // 238
			Tuple.Create(12788, new Point3D(7, -2, 0), 1, 0, 0, (string)null), // 239
			Tuple.Create(12788, new Point3D(7, -1, 0), 1, 0, 0, (string)null), // 240
			Tuple.Create(12788, new Point3D(7, 0, 0), 1, 0, 0, (string)null), // 241
			Tuple.Create(12788, new Point3D(7, 1, 0), 1, 0, 0, (string)null), // 242
			Tuple.Create(12788, new Point3D(8, -7, 0), 1, 0, 0, (string)null), // 243
			Tuple.Create(12788, new Point3D(8, -6, 0), 1, 0, 0, (string)null), // 244
			Tuple.Create(12788, new Point3D(8, -5, 0), 1, 0, 0, (string)null), // 245
			Tuple.Create(12788, new Point3D(8, -4, 0), 1, 0, 0, (string)null), // 246
			Tuple.Create(12788, new Point3D(8, -3, 0), 1, 0, 0, (string)null), // 247
			Tuple.Create(12788, new Point3D(8, -2, 0), 1, 0, 0, (string)null), // 248
			Tuple.Create(12788, new Point3D(8, -1, 0), 1, 0, 0, (string)null), // 249
			Tuple.Create(12788, new Point3D(8, 0, 0), 1, 0, 0, (string)null), // 250
			Tuple.Create(12788, new Point3D(8, 1, 0), 1, 0, 0, (string)null), // 251
			Tuple.Create(12788, new Point3D(9, -7, 0), 1, 0, 0, (string)null), // 252
			Tuple.Create(12788, new Point3D(9, -6, 0), 1, 0, 0, (string)null), // 253
			Tuple.Create(12788, new Point3D(9, -5, 0), 1, 0, 0, (string)null), // 254
			Tuple.Create(12788, new Point3D(9, -4, 0), 1, 0, 0, (string)null), // 255
			Tuple.Create(12788, new Point3D(9, -3, 0), 1, 0, 0, (string)null), // 256
			Tuple.Create(12788, new Point3D(9, -2, 0), 1, 0, 0, (string)null), // 257
			Tuple.Create(12788, new Point3D(9, -1, 0), 1, 0, 0, (string)null), // 258
			Tuple.Create(12788, new Point3D(9, 0, 0), 1, 0, 0, (string)null), // 259
			Tuple.Create(12788, new Point3D(9, 1, 0), 1, 0, 0, (string)null), // 260
			Tuple.Create(2147, new Point3D(9, -8, 0), 1, 0, 0, (string)null), // 261
			Tuple.Create(2147, new Point3D(2, -8, 0), 1, 0, 0, (string)null), // 262
			Tuple.Create(2147, new Point3D(3, -8, 0), 1, 0, 0, (string)null), // 263
			Tuple.Create(2147, new Point3D(4, -8, 0), 1, 0, 0, (string)null), // 264
			Tuple.Create(2147, new Point3D(5, -8, 0), 1, 0, 0, (string)null), // 265
			Tuple.Create(2147, new Point3D(6, -8, 0), 1, 0, 0, (string)null), // 266
			Tuple.Create(2147, new Point3D(7, -8, 0), 1, 0, 0, (string)null), // 267
			Tuple.Create(2147, new Point3D(8, -8, 0), 1, 0, 0, (string)null), // 268
			Tuple.Create(2148, new Point3D(9, -7, 0), 1, 0, 0, (string)null), // 269
			Tuple.Create(2148, new Point3D(9, -6, 0), 1, 0, 0, (string)null), // 270
			Tuple.Create(2148, new Point3D(9, -5, 0), 1, 0, 0, (string)null), // 271
			Tuple.Create(2148, new Point3D(9, -4, 0), 1, 0, 0, (string)null), // 272
			Tuple.Create(2148, new Point3D(9, -3, 0), 1, 0, 0, (string)null), // 273
			Tuple.Create(2148, new Point3D(9, -2, 0), 1, 0, 0, (string)null), // 274
			Tuple.Create(2148, new Point3D(9, -1, 0), 1, 0, 0, (string)null), // 275
			Tuple.Create(2148, new Point3D(9, 0, 0), 1, 0, 0, (string)null), // 276
			Tuple.Create(2148, new Point3D(9, 1, 0), 1, 0, 0, (string)null), // 277
			Tuple.Create(12788, new Point3D(2, 2, 0), 1, 0, 0, (string)null), // 278
			Tuple.Create(12788, new Point3D(2, 3, 0), 1, 0, 0, (string)null), // 279
			Tuple.Create(12788, new Point3D(2, 4, 0), 1, 0, 0, (string)null), // 280
			Tuple.Create(12788, new Point3D(2, 5, 0), 1, 0, 0, (string)null), // 281
			Tuple.Create(12788, new Point3D(2, 6, 0), 1, 0, 0, (string)null), // 282
			Tuple.Create(12788, new Point3D(2, 7, 0), 1, 0, 0, (string)null), // 283
			Tuple.Create(12788, new Point3D(2, 8, 0), 1, 0, 0, (string)null), // 284
			Tuple.Create(12788, new Point3D(2, 9, 0), 1, 0, 0, (string)null), // 285
			Tuple.Create(12788, new Point3D(3, 2, 0), 1, 0, 0, (string)null), // 286
			Tuple.Create(12788, new Point3D(3, 3, 0), 1, 0, 0, (string)null), // 287
			Tuple.Create(12788, new Point3D(3, 4, 0), 1, 0, 0, (string)null), // 288
			Tuple.Create(12788, new Point3D(3, 5, 0), 1, 0, 0, (string)null), // 289
			Tuple.Create(12788, new Point3D(3, 6, 0), 1, 0, 0, (string)null), // 290
			Tuple.Create(12788, new Point3D(3, 7, 0), 1, 0, 0, (string)null), // 291
			Tuple.Create(12788, new Point3D(3, 8, 0), 1, 0, 0, (string)null), // 292
			Tuple.Create(12788, new Point3D(3, 9, 0), 1, 0, 0, (string)null), // 293
			Tuple.Create(12788, new Point3D(4, 2, 0), 1, 0, 0, (string)null), // 294
			Tuple.Create(12788, new Point3D(4, 3, 0), 1, 0, 0, (string)null), // 295
			Tuple.Create(12788, new Point3D(4, 4, 0), 1, 0, 0, (string)null), // 296
			Tuple.Create(12788, new Point3D(4, 5, 0), 1, 0, 0, (string)null), // 297
			Tuple.Create(12788, new Point3D(4, 6, 0), 1, 0, 0, (string)null), // 298
			Tuple.Create(12788, new Point3D(4, 7, 0), 1, 0, 0, (string)null), // 299
			Tuple.Create(12788, new Point3D(4, 8, 0), 1, 0, 0, (string)null), // 300
			Tuple.Create(12788, new Point3D(4, 9, 0), 1, 0, 0, (string)null), // 301
			Tuple.Create(12788, new Point3D(5, 2, 0), 1, 0, 0, (string)null), // 302
			Tuple.Create(12788, new Point3D(5, 3, 0), 1, 0, 0, (string)null), // 303
			Tuple.Create(12788, new Point3D(5, 4, 0), 1, 0, 0, (string)null), // 304
			Tuple.Create(12788, new Point3D(5, 5, 0), 1, 0, 0, (string)null), // 305
			Tuple.Create(12788, new Point3D(5, 6, 0), 1, 0, 0, (string)null), // 306
			Tuple.Create(12788, new Point3D(5, 7, 0), 1, 0, 0, (string)null), // 307
			Tuple.Create(12788, new Point3D(5, 8, 0), 1, 0, 0, (string)null), // 308
			Tuple.Create(12788, new Point3D(5, 9, 0), 1, 0, 0, (string)null), // 309
			Tuple.Create(12788, new Point3D(6, 2, 0), 1, 0, 0, (string)null), // 310
			Tuple.Create(12788, new Point3D(6, 3, 0), 1, 0, 0, (string)null), // 311
			Tuple.Create(12788, new Point3D(6, 4, 0), 1, 0, 0, (string)null), // 312
			Tuple.Create(12788, new Point3D(6, 5, 0), 1, 0, 0, (string)null), // 313
			Tuple.Create(12788, new Point3D(6, 6, 0), 1, 0, 0, (string)null), // 314
			Tuple.Create(12788, new Point3D(6, 7, 0), 1, 0, 0, (string)null), // 315
			Tuple.Create(12788, new Point3D(6, 8, 0), 1, 0, 0, (string)null), // 316
			Tuple.Create(12788, new Point3D(6, 9, 0), 1, 0, 0, (string)null), // 317
			Tuple.Create(12788, new Point3D(7, 2, 0), 1, 0, 0, (string)null), // 318
			Tuple.Create(12788, new Point3D(7, 3, 0), 1, 0, 0, (string)null), // 319
			Tuple.Create(12788, new Point3D(7, 4, 0), 1, 0, 0, (string)null), // 320
			Tuple.Create(12788, new Point3D(7, 5, 0), 1, 0, 0, (string)null), // 321
			Tuple.Create(12788, new Point3D(7, 6, 0), 1, 0, 0, (string)null), // 322
			Tuple.Create(12788, new Point3D(7, 7, 0), 1, 0, 0, (string)null), // 323
			Tuple.Create(12788, new Point3D(7, 8, 0), 1, 0, 0, (string)null), // 324
			Tuple.Create(12788, new Point3D(7, 9, 0), 1, 0, 0, (string)null), // 325
			Tuple.Create(12788, new Point3D(8, 2, 0), 1, 0, 0, (string)null), // 326
			Tuple.Create(12788, new Point3D(8, 3, 0), 1, 0, 0, (string)null), // 327
			Tuple.Create(12788, new Point3D(8, 4, 0), 1, 0, 0, (string)null), // 328
			Tuple.Create(12788, new Point3D(8, 5, 0), 1, 0, 0, (string)null), // 329
			Tuple.Create(12788, new Point3D(8, 6, 0), 1, 0, 0, (string)null), // 330
			Tuple.Create(12788, new Point3D(8, 7, 0), 1, 0, 0, (string)null), // 331
			Tuple.Create(12788, new Point3D(8, 8, 0), 1, 0, 0, (string)null), // 332
			Tuple.Create(12788, new Point3D(8, 9, 0), 1, 0, 0, (string)null), // 333
			Tuple.Create(12788, new Point3D(9, 2, 0), 1, 0, 0, (string)null), // 334
			Tuple.Create(12788, new Point3D(9, 3, 0), 1, 0, 0, (string)null), // 335
			Tuple.Create(12788, new Point3D(9, 4, 0), 1, 0, 0, (string)null), // 336
			Tuple.Create(12788, new Point3D(9, 5, 0), 1, 0, 0, (string)null), // 337
			Tuple.Create(12788, new Point3D(9, 6, 0), 1, 0, 0, (string)null), // 338
			Tuple.Create(12788, new Point3D(9, 7, 0), 1, 0, 0, (string)null), // 339
			Tuple.Create(12788, new Point3D(9, 8, 0), 1, 0, 0, (string)null), // 340
			Tuple.Create(12788, new Point3D(9, 9, 0), 1, 0, 0, (string)null), // 341
			Tuple.Create(2146, new Point3D(9, 9, 0), 1, 0, 0, (string)null), // 342
			Tuple.Create(2148, new Point3D(9, 2, 0), 1, 0, 0, (string)null), // 343
			Tuple.Create(2148, new Point3D(9, 3, 0), 1, 0, 0, (string)null), // 344
			Tuple.Create(2148, new Point3D(9, 4, 0), 1, 0, 0, (string)null), // 345
			Tuple.Create(2148, new Point3D(9, 5, 0), 1, 0, 0, (string)null), // 346
			Tuple.Create(2148, new Point3D(9, 6, 0), 1, 0, 0, (string)null), // 347
			Tuple.Create(2148, new Point3D(9, 7, 0), 1, 0, 0, (string)null), // 348
			Tuple.Create(2148, new Point3D(9, 8, 0), 1, 0, 0, (string)null), // 349
			Tuple.Create(2147, new Point3D(2, 9, 0), 1, 0, 0, (string)null), // 350
			Tuple.Create(2147, new Point3D(3, 9, 0), 1, 0, 0, (string)null), // 351
			Tuple.Create(2147, new Point3D(4, 9, 0), 1, 0, 0, (string)null), // 352
			Tuple.Create(2147, new Point3D(5, 9, 0), 1, 0, 0, (string)null), // 353
			Tuple.Create(2147, new Point3D(6, 9, 0), 1, 0, 0, (string)null), // 354
			Tuple.Create(2147, new Point3D(7, 9, 0), 1, 0, 0, (string)null), // 355
			Tuple.Create(2147, new Point3D(8, 9, 0), 1, 0, 0, (string)null) // 356
		};
		
		public override BaseAddonDeed Deed { get { return new SquareGardenAddonDeed(); } }

		[Constructable]
		public SquareGardenAddon()
		{
			Name = "SquareGarden Deed";

			foreach(var o in _Components)
			{
				AddComponent(o.Item1, o.Item2, o.Item3, o.Item4, o.Item5, o.Item6);
			}
		}

        public SquareGardenAddon(Serial serial) 
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

	public class SquareGardenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new SquareGardenAddon(); } }

		[Constructable]
		public SquareGardenAddonDeed()
		{
			Name = "Square Garden Deed";
		}

		public SquareGardenAddonDeed(Serial serial) 
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
