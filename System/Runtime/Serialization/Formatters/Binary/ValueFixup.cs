internal sealed class ValueFixup // TypeDefIndex: 1095
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x150B570 Offset: 0x150B671 VA: 0x150B570
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x150B5D0 Offset: 0x150B6D1 VA: 0x150B5D0
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x150B640 Offset: 0x150B741 VA: 0x150B640
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}

