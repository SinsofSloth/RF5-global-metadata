internal struct IPv6AddressFormatter // TypeDefIndex: 1981
{
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x9AE0 Offset: 0x9BE1 VA: 0x9AE0
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x1794B90 Offset: 0x1794C91 VA: 0x1794B90
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x9B10 Offset: 0x9C11 VA: 0x9B10
	private uint AsIPv4Int() { }

	// RVA: 0x9B60 Offset: 0x9C61 VA: 0x9B60
	private bool IsIPv4Compatible() { }

	// RVA: 0x9B70 Offset: 0x9C71 VA: 0x9B70
	private bool IsIPv4Mapped() { }

	// RVA: 0x9C50 Offset: 0x9D51 VA: 0x9C50 Slot: 3
	public override string ToString() { }
}

