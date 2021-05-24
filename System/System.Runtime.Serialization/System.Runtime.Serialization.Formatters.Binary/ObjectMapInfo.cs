internal sealed class ObjectMapInfo // TypeDefIndex: 1079
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x1608300 Offset: 0x1608401 VA: 0x1608300
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1608370 Offset: 0x1608471 VA: 0x1608370
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}

