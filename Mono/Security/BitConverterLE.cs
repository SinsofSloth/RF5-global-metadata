internal sealed class BitConverterLE // TypeDefIndex: 46
{
	// Methods

	// RVA: 0x18EE520 Offset: 0x18EE621 VA: 0x18EE520
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x18EE640 Offset: 0x18EE741 VA: 0x18EE640
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x18EDAF0 Offset: 0x18EDBF1 VA: 0x18EDAF0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x18EE7E0 Offset: 0x18EE8E1 VA: 0x18EE7E0
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x18EE810 Offset: 0x18EE911 VA: 0x18EE810
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x18EE840 Offset: 0x18EE941 VA: 0x18EE840
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x18EE9B0 Offset: 0x18EEAB1 VA: 0x18EE9B0
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x18EEC10 Offset: 0x18EED11 VA: 0x18EEC10
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x18EEC40 Offset: 0x18EED41 VA: 0x18EEC40
	internal static double ToDouble(byte[] value, int startIndex) { }
}

internal sealed class BitConverterLE // TypeDefIndex: 1550
{
	// Methods

	// RVA: 0x1A670E0 Offset: 0x1A671E1 VA: 0x1A670E0
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1A67200 Offset: 0x1A67301 VA: 0x1A67200
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1A665C0 Offset: 0x1A666C1 VA: 0x1A665C0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1A673A0 Offset: 0x1A674A1 VA: 0x1A673A0
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1A673D0 Offset: 0x1A674D1 VA: 0x1A673D0
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1A674D0 Offset: 0x1A675D1 VA: 0x1A674D0
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1A67640 Offset: 0x1A67741 VA: 0x1A67640
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1A67670 Offset: 0x1A67771 VA: 0x1A67670
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

