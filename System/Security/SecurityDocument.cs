[Serializable]
internal sealed class SecurityDocument // TypeDefIndex: 886
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x263ED00 Offset: 0x263EE01 VA: 0x263ED00
	public void .ctor(int numData) { }

	// RVA: 0x263ED80 Offset: 0x263EE81 VA: 0x263ED80
	public void GuaranteeSize(int size) { }

	// RVA: 0x263EE50 Offset: 0x263EF51 VA: 0x263EE50
	public void AddString(string str, ref int position) { }

	// RVA: 0x263F030 Offset: 0x263F131 VA: 0x263F030
	public void AppendString(string str, ref int position) { }

	// RVA: 0x263F120 Offset: 0x263F221 VA: 0x263F120
	public static int EncodedStringSize(string str) { }

	// RVA: 0x263F140 Offset: 0x263F241 VA: 0x263F140
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x263FC00 Offset: 0x263FD01 VA: 0x263FC00
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x263FC70 Offset: 0x263FD71 VA: 0x263FC70
	public SecurityElement GetRootElement() { }

	// RVA: 0x263FCA0 Offset: 0x263FDA1 VA: 0x263FCA0
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x263FCD0 Offset: 0x263FDD1 VA: 0x263FCD0
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}

