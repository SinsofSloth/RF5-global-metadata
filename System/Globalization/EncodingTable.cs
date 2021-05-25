internal static class EncodingTable // TypeDefIndex: 739
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Hashtable hashByName; // 0x18
	private static Hashtable hashByCodePage; // 0x20

	// Methods

	// RVA: 0x19B77B0 Offset: 0x19B78B1 VA: 0x19B77B0
	private static int GetNumEncodingItems() { }

	// RVA: 0x19B7830 Offset: 0x19B7931 VA: 0x19B7830
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x19B7870 Offset: 0x19B7971 VA: 0x19B7870
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x19B78B0 Offset: 0x19B79B1 VA: 0x19B78B0
	private static void .cctor() { }

	// RVA: 0x19C0280 Offset: 0x19C0381 VA: 0x19C0280
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x19C0550 Offset: 0x19C0651 VA: 0x19C0550
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x19C06C0 Offset: 0x19C07C1 VA: 0x19C06C0
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}

