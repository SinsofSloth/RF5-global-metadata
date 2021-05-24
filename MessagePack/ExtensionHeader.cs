public struct ExtensionHeader : IEquatable<ExtensionHeader> // TypeDefIndex: 5120
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x139850 Offset: 0x139951 VA: 0x139850
	private sbyte <TypeCode>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139860 Offset: 0x139961 VA: 0x139860
	private uint <Length>k__BackingField; // 0x4

	// Properties
	public sbyte TypeCode { get; set; }
	public uint Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x139E40 Offset: 0x139F41 VA: 0x139E40
	// RVA: 0x6170 Offset: 0x6271 VA: 0x6170
	public sbyte get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x139E50 Offset: 0x139F51 VA: 0x139E50
	// RVA: 0x6180 Offset: 0x6281 VA: 0x6180
	private void set_TypeCode(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139E60 Offset: 0x139F61 VA: 0x139E60
	// RVA: 0x6190 Offset: 0x6291 VA: 0x6190
	public uint get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x139E70 Offset: 0x139F71 VA: 0x139E70
	// RVA: 0x61A0 Offset: 0x62A1 VA: 0x61A0
	private void set_Length(uint value) { }

	// RVA: 0x61B0 Offset: 0x62B1 VA: 0x61B0
	public void .ctor(sbyte typeCode, uint length) { }

	// RVA: 0x61C0 Offset: 0x62C1 VA: 0x61C0
	public void .ctor(sbyte typeCode, int length) { }

	// RVA: 0x61D0 Offset: 0x62D1 VA: 0x61D0 Slot: 4
	public bool Equals(ExtensionHeader other) { }
}

