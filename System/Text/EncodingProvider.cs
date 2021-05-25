[ComVisibleAttribute] // RVA: 0xAD180 Offset: 0xAD281 VA: 0xAD180
public abstract class EncodingProvider // TypeDefIndex: 471
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A792E0 Offset: 0x2A793E1 VA: 0x2A792E0
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x2A7A070 Offset: 0x2A7A171 VA: 0x2A7A070
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x2A7E730 Offset: 0x2A7E831 VA: 0x2A7E730
	private static void .cctor() { }
}

