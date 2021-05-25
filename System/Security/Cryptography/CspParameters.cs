[ComVisibleAttribute] // RVA: 0xAFDF0 Offset: 0xAFEF1 VA: 0xAFDF0
public sealed class CspParameters // TypeDefIndex: 921
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x194A1B0 Offset: 0x194A2B1 VA: 0x194A1B0
	public CspProviderFlags get_Flags() { }

	// RVA: 0x194A1C0 Offset: 0x194A2C1 VA: 0x194A1C0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x194A2D0 Offset: 0x194A3D1 VA: 0x194A2D0
	public void .ctor() { }

	// RVA: 0x194A3F0 Offset: 0x194A4F1 VA: 0x194A3F0
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x194A360 Offset: 0x194A461 VA: 0x194A360
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x194A470 Offset: 0x194A571 VA: 0x194A470
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}

