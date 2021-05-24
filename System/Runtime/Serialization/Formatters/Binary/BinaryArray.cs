internal sealed class BinaryArray // TypeDefIndex: 1056
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x1600890 Offset: 0x1600991 VA: 0x1600890
	internal void .ctor() { }

	// RVA: 0x16008A0 Offset: 0x16009A1 VA: 0x16008A0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x16008D0 Offset: 0x16009D1 VA: 0x16008D0
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x1600990 Offset: 0x1600A91 VA: 0x1600990 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1600E20 Offset: 0x1600F21 VA: 0x1600E20 Slot: 5
	public void Read(__BinaryParser input) { }
}

