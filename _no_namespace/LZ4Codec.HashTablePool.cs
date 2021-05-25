internal static class LZ4Codec.HashTablePool // TypeDefIndex: 5277
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x139AB0 Offset: 0x139BB1 VA: 0x139AB0
	private static ushort[] ushortPool; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x139AC0 Offset: 0x139BC1 VA: 0x139AC0
	private static uint[] uintPool; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x139AD0 Offset: 0x139BD1 VA: 0x139AD0
	private static int[] intPool; // 0x80000010

	// Methods

	// RVA: 0x1686090 Offset: 0x1686191 VA: 0x1686090
	public static ushort[] GetUShortHashTablePool() { }

	// RVA: 0x168A160 Offset: 0x168A261 VA: 0x168A160
	public static uint[] GetUIntHashTablePool() { }

	// RVA: 0x1686A60 Offset: 0x1686B61 VA: 0x1686A60
	public static int[] GetIntHashTablePool() { }
}

