[MonoTODOAttribute] // RVA: 0xAF970 Offset: 0xAFA71 VA: 0xAF970
public sealed class SecureString : IDisposable // TypeDefIndex: 887
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x263E7B0 Offset: 0x263E8B1 VA: 0x263E7B0
	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB9150 Offset: 0xB9251 VA: 0xB9150
	// RVA: 0x263E9C0 Offset: 0x263EAC1 VA: 0x263E9C0
	public void .ctor(char* value, int length) { }

	// RVA: 0x263EB40 Offset: 0x263EC41 VA: 0x263EB40
	public int get_Length() { }

	// RVA: 0x263EBD0 Offset: 0x263ECD1 VA: 0x263EBD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x263EB30 Offset: 0x263EC31 VA: 0x263EB30
	private void Encrypt() { }

	// RVA: 0x263EC30 Offset: 0x263ED31 VA: 0x263EC30
	private void Decrypt() { }

	// RVA: 0x263E820 Offset: 0x263E921 VA: 0x263E820
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x263EC40 Offset: 0x263ED41 VA: 0x263EC40
	internal byte[] GetBuffer() { }
}

