[ComVisibleAttribute] // RVA: 0xAB6C0 Offset: 0xAB7C1 VA: 0xAB6C0
public sealed class LocalDataStoreSlot // TypeDefIndex: 150
{
	// Fields
	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	// Properties
	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }

	// Methods

	// RVA: 0x18DBB10 Offset: 0x18DBC11 VA: 0x18DBB10
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x18DC120 Offset: 0x18DC221 VA: 0x18DC120
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x18DC130 Offset: 0x18DC231 VA: 0x18DC130
	internal int get_Slot() { }

	// RVA: 0x18DC140 Offset: 0x18DC241 VA: 0x18DC140
	internal long get_Cookie() { }

	// RVA: 0x18DC150 Offset: 0x18DC251 VA: 0x18DC150 Slot: 1
	protected override void Finalize() { }
}

