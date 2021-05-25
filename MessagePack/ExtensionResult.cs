public struct ExtensionResult // TypeDefIndex: 5121
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x139870 Offset: 0x139971 VA: 0x139870
	private sbyte <TypeCode>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139880 Offset: 0x139981 VA: 0x139880
	private ReadOnlySequence<byte> <Data>k__BackingField; // 0x8

	// Properties
	public sbyte TypeCode { get; set; }
	public ReadOnlySequence<byte> Data { get; set; }
	public ExtensionHeader Header { get; }

	// Methods

	// RVA: 0x6250 Offset: 0x6351 VA: 0x6250
	public void .ctor(sbyte typeCode, Memory<byte> data) { }

	// RVA: 0x6320 Offset: 0x6421 VA: 0x6320
	public void .ctor(sbyte typeCode, ReadOnlySequence<byte> data) { }

	[CompilerGeneratedAttribute] // RVA: 0x139E80 Offset: 0x139F81 VA: 0x139E80
	// RVA: 0x6360 Offset: 0x6461 VA: 0x6360
	public sbyte get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x139E90 Offset: 0x139F91 VA: 0x139E90
	// RVA: 0x6370 Offset: 0x6471 VA: 0x6370
	private void set_TypeCode(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x139EA0 Offset: 0x139FA1 VA: 0x139EA0
	// RVA: 0x6380 Offset: 0x6481 VA: 0x6380
	public ReadOnlySequence<byte> get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x139EB0 Offset: 0x139FB1 VA: 0x139EB0
	// RVA: 0x63A0 Offset: 0x64A1 VA: 0x63A0
	private void set_Data(ReadOnlySequence<byte> value) { }

	// RVA: 0x63C0 Offset: 0x64C1 VA: 0x63C0
	public ExtensionHeader get_Header() { }
}

