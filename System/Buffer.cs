[ComVisibleAttribute] // RVA: 0xABBC0 Offset: 0xABCC1 VA: 0xABBC0
public static class Buffer // TypeDefIndex: 190
{
	// Methods

	// RVA: 0x18548D0 Offset: 0x18549D1 VA: 0x18548D0
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x18548E0 Offset: 0x18549E1 VA: 0x18548E0
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x1854AB0 Offset: 0x1854BB1 VA: 0x1854AB0
	private static int _ByteLength(Array array) { }

	// RVA: 0x1854AC0 Offset: 0x1854BC1 VA: 0x1854AC0
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContractAttribute] // RVA: 0xB5970 Offset: 0xB5A71 VA: 0xB5970
	// RVA: 0x1854AF0 Offset: 0x1854BF1 VA: 0x1854AF0
	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	[ReliabilityContractAttribute] // RVA: 0xB5990 Offset: 0xB5A91 VA: 0xB5990
	// RVA: 0x1854DB0 Offset: 0x1854EB1 VA: 0x1854DB0
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x1854DF0 Offset: 0x1854EF1 VA: 0x1854DF0
	public static int ByteLength(Array array) { }

	// RVA: 0x1854EC0 Offset: 0x1854FC1 VA: 0x1854EC0
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB59B0 Offset: 0xB5AB1 VA: 0xB59B0
	// RVA: 0x18550C0 Offset: 0x18551C1 VA: 0x18550C0
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x18552C0 Offset: 0x18553C1 VA: 0x18552C0
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x18553A0 Offset: 0x18554A1 VA: 0x18553A0
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x1855200 Offset: 0x1855301 VA: 0x1855200
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x1854B30 Offset: 0x1854C31 VA: 0x1854B30
	internal static void Memcpy(byte* dest, byte* src, int size) { }
}

