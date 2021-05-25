public class SaveFlagStorage // TypeDefIndex: 8232
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16DB00 Offset: 0x16DC01 VA: 0x16DB00
	private byte[] <Data>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16DB10 Offset: 0x16DC11 VA: 0x16DB10
	private int <Length>k__BackingField; // 0x18

	// Properties
	public byte[] Data { get; set; }
	public int Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6630 Offset: 0x1A6731 VA: 0x1A6630
	// RVA: 0x20FB5B0 Offset: 0x20FB6B1 VA: 0x20FB5B0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6640 Offset: 0x1A6741 VA: 0x1A6640
	// RVA: 0x20FB5C0 Offset: 0x20FB6C1 VA: 0x20FB5C0
	private void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6650 Offset: 0x1A6751 VA: 0x1A6650
	// RVA: 0x20FB5D0 Offset: 0x20FB6D1 VA: 0x20FB5D0
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6660 Offset: 0x1A6761 VA: 0x1A6660
	// RVA: 0x20FB5E0 Offset: 0x20FB6E1 VA: 0x20FB5E0
	private void set_Length(int value) { }

	// RVA: 0x20EF8E0 Offset: 0x20EF9E1 VA: 0x20EF8E0
	public void .ctor(int length) { }

	// RVA: 0x20FB710 Offset: 0x20FB811 VA: 0x20FB710
	private int GetBitSize(int length) { }

	// RVA: 0x20FB5F0 Offset: 0x20FB6F1 VA: 0x20FB5F0
	public void Alloc(int length) { }

	// RVA: 0x20EF6C0 Offset: 0x20EF7C1 VA: 0x20EF6C0
	public bool GetFlag(int id) { }

	// RVA: 0x20EF7C0 Offset: 0x20EF8C1 VA: 0x20EF7C0
	public int SetFlag(int id, bool flag) { }

	// RVA: 0x20EF970 Offset: 0x20EFA71 VA: 0x20EF970
	public void SetZero() { }

	// RVA: 0x20EFA50 Offset: 0x20EFB51 VA: 0x20EFA50
	public void Writer(BinaryWriter writer) { }

	// RVA: 0x20EFB40 Offset: 0x20EFC41 VA: 0x20EFB40
	public void Reader(BinaryReader reader) { }
}

