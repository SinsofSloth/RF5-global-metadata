internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1055
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x1604B00 Offset: 0x1604C01 VA: 0x1604B00
	internal void .ctor() { }

	// RVA: 0x1604B10 Offset: 0x1604C11 VA: 0x1604B10
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1604B40 Offset: 0x1604C41 VA: 0x1604B40
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x1604C00 Offset: 0x1604D01 VA: 0x1604C00 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1604DB0 Offset: 0x1604EB1 VA: 0x1604DB0 Slot: 5
	public void Read(__BinaryParser input) { }
}

