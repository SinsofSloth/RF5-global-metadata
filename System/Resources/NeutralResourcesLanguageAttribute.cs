[ComVisibleAttribute] // RVA: 0xAD2D0 Offset: 0xAD3D1 VA: 0xAD2D0
[AttributeUsageAttribute] // RVA: 0xAD2D0 Offset: 0xAD3D1 VA: 0xAD2D0
public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 498
{
	// Fields
	private string _culture; // 0x10
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0x17F7AD0 Offset: 0x17F7BD1 VA: 0x17F7AD0
	public void .ctor(string cultureName) { }

	// RVA: 0x17F7B80 Offset: 0x17F7C81 VA: 0x17F7B80
	public string get_CultureName() { }

	// RVA: 0x17F7B90 Offset: 0x17F7C91 VA: 0x17F7B90
	public UltimateResourceFallbackLocation get_Location() { }
}

