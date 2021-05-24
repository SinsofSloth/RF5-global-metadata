public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

public static class Convert // TypeDefIndex: 206
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x2979910 Offset: 0x2979A11 VA: 0x2979910
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x29799F0 Offset: 0x2979AF1 VA: 0x29799F0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x297A270 Offset: 0x297A371 VA: 0x297A270
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x297B450 Offset: 0x297B551 VA: 0x297B450
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x297B4F0 Offset: 0x297B5F1 VA: 0x297B4F0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x297C4D0 Offset: 0x297C5D1 VA: 0x297C4D0
	public static bool ToBoolean(object value) { }

	// RVA: 0x297C5E0 Offset: 0x297C6E1 VA: 0x297C5E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB59D0 Offset: 0xB5AD1 VA: 0xB59D0
	// RVA: 0x297C700 Offset: 0x297C801 VA: 0x297C700
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x297C710 Offset: 0x297C811 VA: 0x297C710
	public static bool ToBoolean(byte value) { }

	// RVA: 0x297C720 Offset: 0x297C821 VA: 0x297C720
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB59F0 Offset: 0xB5AF1 VA: 0xB59F0
	// RVA: 0x297C730 Offset: 0x297C831 VA: 0x297C730
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x297C740 Offset: 0x297C841 VA: 0x297C740
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A10 Offset: 0xB5B11 VA: 0xB5A10
	// RVA: 0x297C750 Offset: 0x297C851 VA: 0x297C750
	public static bool ToBoolean(uint value) { }

	// RVA: 0x297C760 Offset: 0x297C861 VA: 0x297C760
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A30 Offset: 0xB5B31 VA: 0xB5A30
	// RVA: 0x297C770 Offset: 0x297C871 VA: 0x297C770
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x297C780 Offset: 0x297C881 VA: 0x297C780
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x297C800 Offset: 0x297C901 VA: 0x297C800
	public static bool ToBoolean(float value) { }

	// RVA: 0x297C810 Offset: 0x297C911 VA: 0x297C810
	public static bool ToBoolean(double value) { }

	// RVA: 0x297C820 Offset: 0x297C921 VA: 0x297C820
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x297C8B0 Offset: 0x297C9B1 VA: 0x297C8B0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5A50 Offset: 0xB5B51 VA: 0xB5A50
	// RVA: 0x297C9D0 Offset: 0x297CAD1 VA: 0x297C9D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x297CA70 Offset: 0x297CB71 VA: 0x297CA70
	public static char ToChar(byte value) { }

	// RVA: 0x297CA80 Offset: 0x297CB81 VA: 0x297CA80
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A70 Offset: 0xB5B71 VA: 0xB5A70
	// RVA: 0x297CB20 Offset: 0x297CC21 VA: 0x297CB20
	public static char ToChar(ushort value) { }

	// RVA: 0x297CB30 Offset: 0x297CC31 VA: 0x297CB30
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5A90 Offset: 0xB5B91 VA: 0xB5A90
	// RVA: 0x297CBD0 Offset: 0x297CCD1 VA: 0x297CBD0
	public static char ToChar(uint value) { }

	// RVA: 0x297CC70 Offset: 0x297CD71 VA: 0x297CC70
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5AB0 Offset: 0xB5BB1 VA: 0xB5AB0
	// RVA: 0x297CD10 Offset: 0x297CE11 VA: 0x297CD10
	public static char ToChar(ulong value) { }

	// RVA: 0x297CDB0 Offset: 0x297CEB1 VA: 0x297CDB0
	public static char ToChar(string value) { }

	// RVA: 0x297CE30 Offset: 0x297CF31 VA: 0x297CE30
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AD0 Offset: 0xB5BD1 VA: 0xB5AD0
	// RVA: 0x297CF20 Offset: 0x297D021 VA: 0x297CF20
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5AF0 Offset: 0xB5BF1 VA: 0xB5AF0
	// RVA: 0x297D040 Offset: 0x297D141 VA: 0x297D040
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B10 Offset: 0xB5C11 VA: 0xB5B10
	// RVA: 0x297D050 Offset: 0x297D151 VA: 0x297D050
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B30 Offset: 0xB5C31 VA: 0xB5B30
	// RVA: 0x297D0F0 Offset: 0x297D1F1 VA: 0x297D0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B50 Offset: 0xB5C51 VA: 0xB5B50
	// RVA: 0x297D190 Offset: 0x297D291 VA: 0x297D190
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B70 Offset: 0xB5C71 VA: 0xB5B70
	// RVA: 0x297D230 Offset: 0x297D331 VA: 0x297D230
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5B90 Offset: 0xB5C91 VA: 0xB5B90
	// RVA: 0x297D2D0 Offset: 0x297D3D1 VA: 0x297D2D0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BB0 Offset: 0xB5CB1 VA: 0xB5BB0
	// RVA: 0x297D370 Offset: 0x297D471 VA: 0x297D370
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BD0 Offset: 0xB5CD1 VA: 0xB5BD0
	// RVA: 0x297D410 Offset: 0x297D511 VA: 0x297D410
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5BF0 Offset: 0xB5CF1 VA: 0xB5BF0
	// RVA: 0x297D4B0 Offset: 0x297D5B1 VA: 0x297D4B0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C10 Offset: 0xB5D11 VA: 0xB5C10
	// RVA: 0x297D550 Offset: 0x297D651 VA: 0x297D550
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C30 Offset: 0xB5D31 VA: 0xB5C30
	// RVA: 0x297D5C0 Offset: 0x297D6C1 VA: 0x297D5C0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C50 Offset: 0xB5D51 VA: 0xB5C50
	// RVA: 0x297D7D0 Offset: 0x297D8D1 VA: 0x297D7D0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C70 Offset: 0xB5D71 VA: 0xB5C70
	// RVA: 0x297D860 Offset: 0x297D961 VA: 0x297D860
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x297D870 Offset: 0x297D971 VA: 0x297D870
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x297D990 Offset: 0x297DA91 VA: 0x297D990
	public static byte ToByte(bool value) { }

	// RVA: 0x297D9A0 Offset: 0x297DAA1 VA: 0x297D9A0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5C90 Offset: 0xB5D91 VA: 0xB5C90
	// RVA: 0x297DA40 Offset: 0x297DB41 VA: 0x297DA40
	public static byte ToByte(sbyte value) { }

	// RVA: 0x297DAE0 Offset: 0x297DBE1 VA: 0x297DAE0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CB0 Offset: 0xB5DB1 VA: 0xB5CB0
	// RVA: 0x297DB80 Offset: 0x297DC81 VA: 0x297DB80
	public static byte ToByte(ushort value) { }

	// RVA: 0x297DC20 Offset: 0x297DD21 VA: 0x297DC20
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CD0 Offset: 0xB5DD1 VA: 0xB5CD0
	// RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	public static byte ToByte(uint value) { }

	// RVA: 0x297DD60 Offset: 0x297DE61 VA: 0x297DD60
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5CF0 Offset: 0xB5DF1 VA: 0xB5CF0
	// RVA: 0x297DE00 Offset: 0x297DF01 VA: 0x297DE00
	public static byte ToByte(ulong value) { }

	// RVA: 0x297DEA0 Offset: 0x297DFA1 VA: 0x297DEA0
	public static byte ToByte(float value) { }

	// RVA: 0x297DF10 Offset: 0x297E011 VA: 0x297DF10
	public static byte ToByte(double value) { }

	// RVA: 0x297E000 Offset: 0x297E101 VA: 0x297E000
	public static byte ToByte(Decimal value) { }

	// RVA: 0x297E090 Offset: 0x297E191 VA: 0x297E090
	public static byte ToByte(string value) { }

	// RVA: 0x297E120 Offset: 0x297E221 VA: 0x297E120
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x297E140 Offset: 0x297E241 VA: 0x297E140
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x297E260 Offset: 0x297E361 VA: 0x297E260
	public static short ToInt16(bool value) { }

	// RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D10 Offset: 0xB5E11 VA: 0xB5D10
	// RVA: 0x297E310 Offset: 0x297E411 VA: 0x297E310
	public static short ToInt16(sbyte value) { }

	// RVA: 0x297E320 Offset: 0x297E421 VA: 0x297E320
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D30 Offset: 0xB5E31 VA: 0xB5D30
	// RVA: 0x297E330 Offset: 0x297E431 VA: 0x297E330
	public static short ToInt16(ushort value) { }

	// RVA: 0x297E3D0 Offset: 0x297E4D1 VA: 0x297E3D0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D50 Offset: 0xB5E51 VA: 0xB5D50
	// RVA: 0x297E470 Offset: 0x297E571 VA: 0x297E470
	public static short ToInt16(uint value) { }

	// RVA: 0x297E510 Offset: 0x297E611 VA: 0x297E510
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5D70 Offset: 0xB5E71 VA: 0xB5D70
	// RVA: 0x297E5B0 Offset: 0x297E6B1 VA: 0x297E5B0
	public static short ToInt16(ulong value) { }

	// RVA: 0x297E650 Offset: 0x297E751 VA: 0x297E650
	public static short ToInt16(float value) { }

	// RVA: 0x297E6C0 Offset: 0x297E7C1 VA: 0x297E6C0
	public static short ToInt16(double value) { }

	// RVA: 0x297E7B0 Offset: 0x297E8B1 VA: 0x297E7B0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x297E840 Offset: 0x297E941 VA: 0x297E840
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5D90 Offset: 0xB5E91 VA: 0xB5D90
	// RVA: 0x297E860 Offset: 0x297E961 VA: 0x297E860
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5DB0 Offset: 0xB5EB1 VA: 0xB5DB0
	// RVA: 0x297E980 Offset: 0x297EA81 VA: 0x297E980
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DD0 Offset: 0xB5ED1 VA: 0xB5DD0
	// RVA: 0x297E990 Offset: 0x297EA91 VA: 0x297E990
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB5DF0 Offset: 0xB5EF1 VA: 0xB5DF0
	// RVA: 0x297E9A0 Offset: 0x297EAA1 VA: 0x297E9A0
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E10 Offset: 0xB5F11 VA: 0xB5E10
	// RVA: 0x297EA40 Offset: 0x297EB41 VA: 0x297EA40
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E30 Offset: 0xB5F31 VA: 0xB5E30
	// RVA: 0x297EA50 Offset: 0x297EB51 VA: 0x297EA50
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E50 Offset: 0xB5F51 VA: 0xB5E50
	// RVA: 0x297EAF0 Offset: 0x297EBF1 VA: 0x297EAF0
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E70 Offset: 0xB5F71 VA: 0xB5E70
	// RVA: 0x297EB90 Offset: 0x297EC91 VA: 0x297EB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB5E90 Offset: 0xB5F91 VA: 0xB5E90
	// RVA: 0x297EC30 Offset: 0x297ED31 VA: 0x297EC30
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EB0 Offset: 0xB5FB1 VA: 0xB5EB0
	// RVA: 0x297ECD0 Offset: 0x297EDD1 VA: 0x297ECD0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB5ED0 Offset: 0xB5FD1 VA: 0xB5ED0
	// RVA: 0x297ED70 Offset: 0x297EE71 VA: 0x297ED70
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB5EF0 Offset: 0xB5FF1 VA: 0xB5EF0
	// RVA: 0x297EDE0 Offset: 0x297EEE1 VA: 0x297EDE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F10 Offset: 0xB6011 VA: 0xB5F10
	// RVA: 0x297EED0 Offset: 0x297EFD1 VA: 0x297EED0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F30 Offset: 0xB6031 VA: 0xB5F30
	// RVA: 0x297EF60 Offset: 0x297F061 VA: 0x297EF60
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x297EF80 Offset: 0x297F081 VA: 0x297EF80
	public static int ToInt32(object value) { }

	// RVA: 0x297F090 Offset: 0x297F191 VA: 0x297F090
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x297F1B0 Offset: 0x297F2B1 VA: 0x297F1B0
	public static int ToInt32(bool value) { }

	// RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	public static int ToInt32(char value) { }

	// RVA: 0x297F1D0 Offset: 0x297F2D1 VA: 0x297F1D0
	public static int ToInt32(byte value) { }

	// RVA: 0x297F1E0 Offset: 0x297F2E1 VA: 0x297F1E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F50 Offset: 0xB6051 VA: 0xB5F50
	// RVA: 0x297F1F0 Offset: 0x297F2F1 VA: 0x297F1F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F70 Offset: 0xB6071 VA: 0xB5F70
	// RVA: 0x297F200 Offset: 0x297F301 VA: 0x297F200
	public static int ToInt32(uint value) { }

	// RVA: 0x297F2A0 Offset: 0x297F3A1 VA: 0x297F2A0
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB5F90 Offset: 0xB6091 VA: 0xB5F90
	// RVA: 0x297F340 Offset: 0x297F441 VA: 0x297F340
	public static int ToInt32(ulong value) { }

	// RVA: 0x297F3E0 Offset: 0x297F4E1 VA: 0x297F3E0
	public static int ToInt32(float value) { }

	// RVA: 0x297D6B0 Offset: 0x297D7B1 VA: 0x297D6B0
	public static int ToInt32(double value) { }

	// RVA: 0x297F450 Offset: 0x297F551 VA: 0x297F450
	public static int ToInt32(Decimal value) { }

	// RVA: 0x297F4D0 Offset: 0x297F5D1 VA: 0x297F4D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FB0 Offset: 0xB60B1 VA: 0xB5FB0
	// RVA: 0x297F4F0 Offset: 0x297F5F1 VA: 0x297F4F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0xB5FD0 Offset: 0xB60D1 VA: 0xB5FD0
	// RVA: 0x297F600 Offset: 0x297F701 VA: 0x297F600
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB5FF0 Offset: 0xB60F1 VA: 0xB5FF0
	// RVA: 0x297F720 Offset: 0x297F821 VA: 0x297F720
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6010 Offset: 0xB6111 VA: 0xB6010
	// RVA: 0x297F730 Offset: 0x297F831 VA: 0x297F730
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6030 Offset: 0xB6131 VA: 0xB6030
	// RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6050 Offset: 0xB6151 VA: 0xB6050
	// RVA: 0x297F7E0 Offset: 0x297F8E1 VA: 0x297F7E0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6070 Offset: 0xB6171 VA: 0xB6070
	// RVA: 0x297F7F0 Offset: 0x297F8F1 VA: 0x297F7F0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6090 Offset: 0xB6191 VA: 0xB6090
	// RVA: 0x297F890 Offset: 0x297F991 VA: 0x297F890
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB60B0 Offset: 0xB61B1 VA: 0xB60B0
	// RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB60D0 Offset: 0xB61D1 VA: 0xB60D0
	// RVA: 0x297F940 Offset: 0x297FA41 VA: 0x297F940
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB60F0 Offset: 0xB61F1 VA: 0xB60F0
	// RVA: 0x297F9E0 Offset: 0x297FAE1 VA: 0x297F9E0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0xB6110 Offset: 0xB6211 VA: 0xB6110
	// RVA: 0x297FA80 Offset: 0x297FB81 VA: 0x297FA80
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6130 Offset: 0xB6231 VA: 0xB6130
	// RVA: 0x297FAF0 Offset: 0x297FBF1 VA: 0x297FAF0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6150 Offset: 0xB6251 VA: 0xB6150
	// RVA: 0x297FBE0 Offset: 0x297FCE1 VA: 0x297FBE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6170 Offset: 0xB6271 VA: 0xB6170
	// RVA: 0x297FC70 Offset: 0x297FD71 VA: 0x297FC70
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x297FC90 Offset: 0x297FD91 VA: 0x297FC90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x297FDB0 Offset: 0x297FEB1 VA: 0x297FDB0
	public static long ToInt64(bool value) { }

	// RVA: 0x297FDC0 Offset: 0x297FEC1 VA: 0x297FDC0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6190 Offset: 0xB6291 VA: 0xB6190
	// RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x297FDE0 Offset: 0x297FEE1 VA: 0x297FDE0
	public static long ToInt64(byte value) { }

	// RVA: 0x297FDF0 Offset: 0x297FEF1 VA: 0x297FDF0
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB61B0 Offset: 0xB62B1 VA: 0xB61B0
	// RVA: 0x297FE00 Offset: 0x297FF01 VA: 0x297FE00
	public static long ToInt64(ushort value) { }

	// RVA: 0x297FE10 Offset: 0x297FF11 VA: 0x297FE10
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB61D0 Offset: 0xB62D1 VA: 0xB61D0
	// RVA: 0x297FE20 Offset: 0x297FF21 VA: 0x297FE20
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB61F0 Offset: 0xB62F1 VA: 0xB61F0
	// RVA: 0x297FE30 Offset: 0x297FF31 VA: 0x297FE30
	public static long ToInt64(ulong value) { }

	// RVA: 0x297FED0 Offset: 0x297FFD1 VA: 0x297FED0
	public static long ToInt64(float value) { }

	// RVA: 0x297FF40 Offset: 0x2980041 VA: 0x297FF40
	public static long ToInt64(double value) { }

	// RVA: 0x2980060 Offset: 0x2980161 VA: 0x2980060
	public static long ToInt64(Decimal value) { }

	// RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	public static long ToInt64(string value) { }

	// RVA: 0x2980180 Offset: 0x2980281 VA: 0x2980180
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6210 Offset: 0xB6311 VA: 0xB6210
	// RVA: 0x29801A0 Offset: 0x29802A1 VA: 0x29801A0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6230 Offset: 0xB6331 VA: 0xB6230
	// RVA: 0x29802C0 Offset: 0x29803C1 VA: 0x29802C0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0xB6250 Offset: 0xB6351 VA: 0xB6250
	// RVA: 0x29802D0 Offset: 0x29803D1 VA: 0x29802D0
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0xB6270 Offset: 0xB6371 VA: 0xB6270
	// RVA: 0x29802E0 Offset: 0x29803E1 VA: 0x29802E0
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6290 Offset: 0xB6391 VA: 0xB6290
	// RVA: 0x2980380 Offset: 0x2980481 VA: 0x2980380
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB62B0 Offset: 0xB63B1 VA: 0xB62B0
	// RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB62D0 Offset: 0xB63D1 VA: 0xB62D0
	// RVA: 0x2980430 Offset: 0x2980531 VA: 0x2980430
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0xB62F0 Offset: 0xB63F1 VA: 0xB62F0
	// RVA: 0x2980440 Offset: 0x2980541 VA: 0x2980440
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6310 Offset: 0xB6411 VA: 0xB6310
	// RVA: 0x29804E0 Offset: 0x29805E1 VA: 0x29804E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0xB6330 Offset: 0xB6431 VA: 0xB6330
	// RVA: 0x29804F0 Offset: 0x29805F1 VA: 0x29804F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6350 Offset: 0xB6451 VA: 0xB6350
	// RVA: 0x2980590 Offset: 0x2980691 VA: 0x2980590
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0xB6370 Offset: 0xB6471 VA: 0xB6370
	// RVA: 0x2980600 Offset: 0x2980701 VA: 0x2980600
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0xB6390 Offset: 0xB6491 VA: 0xB6390
	// RVA: 0x2980720 Offset: 0x2980821 VA: 0x2980720
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB63B0 Offset: 0xB64B1 VA: 0xB63B0
	// RVA: 0x29807B0 Offset: 0x29808B1 VA: 0x29807B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x29807D0 Offset: 0x29808D1 VA: 0x29807D0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB63D0 Offset: 0xB64D1 VA: 0xB63D0
	// RVA: 0x29808F0 Offset: 0x29809F1 VA: 0x29808F0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2980900 Offset: 0x2980A01 VA: 0x2980900
	public static float ToSingle(byte value) { }

	// RVA: 0x2980910 Offset: 0x2980A11 VA: 0x2980910
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB63F0 Offset: 0xB64F1 VA: 0xB63F0
	// RVA: 0x2980920 Offset: 0x2980A21 VA: 0x2980920
	public static float ToSingle(ushort value) { }

	// RVA: 0x2980930 Offset: 0x2980A31 VA: 0x2980930
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6410 Offset: 0xB6511 VA: 0xB6410
	// RVA: 0x2980940 Offset: 0x2980A41 VA: 0x2980940
	public static float ToSingle(uint value) { }

	// RVA: 0x2980950 Offset: 0x2980A51 VA: 0x2980950
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6430 Offset: 0xB6531 VA: 0xB6430
	// RVA: 0x2980960 Offset: 0x2980A61 VA: 0x2980960
	public static float ToSingle(ulong value) { }

	// RVA: 0x2980970 Offset: 0x2980A71 VA: 0x2980970
	public static float ToSingle(double value) { }

	// RVA: 0x2980980 Offset: 0x2980A81 VA: 0x2980980
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2980A00 Offset: 0x2980B01 VA: 0x2980A00
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2980A20 Offset: 0x2980B21 VA: 0x2980A20
	public static float ToSingle(bool value) { }

	// RVA: 0x2980A40 Offset: 0x2980B41 VA: 0x2980A40
	public static double ToDouble(object value) { }

	// RVA: 0x2980B50 Offset: 0x2980C51 VA: 0x2980B50
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6450 Offset: 0xB6551 VA: 0xB6450
	// RVA: 0x2980C70 Offset: 0x2980D71 VA: 0x2980C70
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2980C80 Offset: 0x2980D81 VA: 0x2980C80
	public static double ToDouble(byte value) { }

	// RVA: 0x2980C90 Offset: 0x2980D91 VA: 0x2980C90
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6470 Offset: 0xB6571 VA: 0xB6470
	// RVA: 0x2980CA0 Offset: 0x2980DA1 VA: 0x2980CA0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2980CB0 Offset: 0x2980DB1 VA: 0x2980CB0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6490 Offset: 0xB6591 VA: 0xB6490
	// RVA: 0x2980CC0 Offset: 0x2980DC1 VA: 0x2980CC0
	public static double ToDouble(uint value) { }

	// RVA: 0x2980CD0 Offset: 0x2980DD1 VA: 0x2980CD0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB64B0 Offset: 0xB65B1 VA: 0xB64B0
	// RVA: 0x2980CE0 Offset: 0x2980DE1 VA: 0x2980CE0
	public static double ToDouble(ulong value) { }

	// RVA: 0x2980CF0 Offset: 0x2980DF1 VA: 0x2980CF0
	public static double ToDouble(float value) { }

	// RVA: 0x2980D00 Offset: 0x2980E01 VA: 0x2980D00
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2980D80 Offset: 0x2980E81 VA: 0x2980D80
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2980E20 Offset: 0x2980F21 VA: 0x2980E20
	public static double ToDouble(bool value) { }

	// RVA: 0x2980E40 Offset: 0x2980F41 VA: 0x2980E40
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB64D0 Offset: 0xB65D1 VA: 0xB64D0
	// RVA: 0x2980F80 Offset: 0x2981081 VA: 0x2980F80
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2980FF0 Offset: 0x29810F1 VA: 0x2980FF0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2981060 Offset: 0x2981161 VA: 0x2981060
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB64F0 Offset: 0xB65F1 VA: 0xB64F0
	// RVA: 0x29810D0 Offset: 0x29811D1 VA: 0x29810D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2981140 Offset: 0x2981241 VA: 0x2981140
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6510 Offset: 0xB6611 VA: 0xB6510
	// RVA: 0x29811B0 Offset: 0x29812B1 VA: 0x29811B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2981220 Offset: 0x2981321 VA: 0x2981220
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6530 Offset: 0xB6631 VA: 0xB6530
	// RVA: 0x2981290 Offset: 0x2981391 VA: 0x2981290
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2981300 Offset: 0x2981401 VA: 0x2981300
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2981370 Offset: 0x2981471 VA: 0x2981370
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x29813E0 Offset: 0x29814E1 VA: 0x29813E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2981490 Offset: 0x2981591 VA: 0x2981490
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2981500 Offset: 0x2981601 VA: 0x2981500
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2981720 Offset: 0x2981821 VA: 0x2981720
	public static string ToString(object value) { }

	// RVA: 0x2981790 Offset: 0x2981891 VA: 0x2981790
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2981930 Offset: 0x2981A31 VA: 0x2981930
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2981960 Offset: 0x2981A61 VA: 0x2981960
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2981990 Offset: 0x2981A91 VA: 0x2981990
	public static int ToInt32(string value, int fromBase) { }

	// RVA: 0x2981A60 Offset: 0x2981B61 VA: 0x2981A60
	public static string ToString(short value, int toBase) { }

	// RVA: 0x2981B40 Offset: 0x2981C41 VA: 0x2981B40
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2981C20 Offset: 0x2981D21 VA: 0x2981C20
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2982030 Offset: 0x2982131 VA: 0x2982030
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0xB6550 Offset: 0xB6651 VA: 0xB6550
	// RVA: 0x2981CD0 Offset: 0x2981DD1 VA: 0x2981CD0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x29821A0 Offset: 0x29822A1 VA: 0x29821A0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x29824D0 Offset: 0x29825D1 VA: 0x29824D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2982590 Offset: 0x2982691 VA: 0x2982590
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2982800 Offset: 0x2982901 VA: 0x2982800
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x29826E0 Offset: 0x29827E1 VA: 0x29826E0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2982AA0 Offset: 0x2982BA1 VA: 0x2982AA0
	private static void .cctor() { }
}

