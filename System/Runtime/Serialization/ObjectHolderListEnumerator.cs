internal class ObjectHolderListEnumerator // TypeDefIndex: 1016
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x1517F10 Offset: 0x1518011 VA: 0x1517F10
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x1517FA0 Offset: 0x15180A1 VA: 0x1517FA0
	internal bool MoveNext() { }

	// RVA: 0x1518060 Offset: 0x1518161 VA: 0x1518060
	internal ObjectHolder get_Current() { }
}

