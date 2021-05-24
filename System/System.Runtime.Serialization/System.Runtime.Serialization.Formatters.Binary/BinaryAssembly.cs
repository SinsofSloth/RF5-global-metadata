internal sealed class BinaryAssembly // TypeDefIndex: 1045
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x16013B0 Offset: 0x16014B1 VA: 0x16013B0
	internal void .ctor() { }

	// RVA: 0x16013C0 Offset: 0x16014C1 VA: 0x16013C0
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x16013D0 Offset: 0x16014D1 VA: 0x16013D0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1601430 Offset: 0x1601531 VA: 0x1601430 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x1601480 Offset: 0x1601581 VA: 0x1601480
	public void Dump() { }
}

