internal sealed class BinaryObjectWithMap // TypeDefIndex: 1054
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x16047E0 Offset: 0x16048E1 VA: 0x16047E0
	internal void .ctor() { }

	// RVA: 0x16047F0 Offset: 0x16048F1 VA: 0x16047F0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1604820 Offset: 0x1604921 VA: 0x1604820
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x1604890 Offset: 0x1604991 VA: 0x1604890 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1604980 Offset: 0x1604A81 VA: 0x1604980 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x1604AF0 Offset: 0x1604BF1 VA: 0x1604AF0
	public void Dump() { }
}

