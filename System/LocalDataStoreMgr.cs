internal sealed class LocalDataStoreMgr // TypeDefIndex: 151
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x18DB720 Offset: 0x18DB821 VA: 0x18DB720
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x18DADF0 Offset: 0x18DAEF1 VA: 0x18DADF0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x18DB8B0 Offset: 0x18DB9B1 VA: 0x18DB8B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x18DBB50 Offset: 0x18DBC51 VA: 0x18DBB50
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x18DBC60 Offset: 0x18DBD61 VA: 0x18DBC60
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x18DBD80 Offset: 0x18DBE81 VA: 0x18DBD80
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x18DBE60 Offset: 0x18DBF61 VA: 0x18DBE60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x18DB070 Offset: 0x18DB171 VA: 0x18DB070
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x18DB630 Offset: 0x18DB731 VA: 0x18DB630
	internal int GetSlotTableLength() { }

	// RVA: 0x18DC050 Offset: 0x18DC151 VA: 0x18DC050
	public void .ctor() { }
}

internal sealed class LocalDataStoreMgr // TypeDefIndex: 151
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x18DB720 Offset: 0x18DB821 VA: 0x18DB720
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x18DADF0 Offset: 0x18DAEF1 VA: 0x18DADF0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x18DB8B0 Offset: 0x18DB9B1 VA: 0x18DB8B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x18DBB50 Offset: 0x18DBC51 VA: 0x18DBB50
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x18DBC60 Offset: 0x18DBD61 VA: 0x18DBC60
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x18DBD80 Offset: 0x18DBE81 VA: 0x18DBD80
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x18DBE60 Offset: 0x18DBF61 VA: 0x18DBE60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x18DB070 Offset: 0x18DB171 VA: 0x18DB070
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x18DB630 Offset: 0x18DB731 VA: 0x18DB630
	internal int GetSlotTableLength() { }

	// RVA: 0x18DC050 Offset: 0x18DC151 VA: 0x18DC050
	public void .ctor() { }
}

internal sealed class LocalDataStoreMgr // TypeDefIndex: 151
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x18DB720 Offset: 0x18DB821 VA: 0x18DB720
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x18DADF0 Offset: 0x18DAEF1 VA: 0x18DADF0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x18DB8B0 Offset: 0x18DB9B1 VA: 0x18DB8B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x18DBB50 Offset: 0x18DBC51 VA: 0x18DBB50
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x18DBC60 Offset: 0x18DBD61 VA: 0x18DBC60
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x18DBD80 Offset: 0x18DBE81 VA: 0x18DBD80
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x18DBE60 Offset: 0x18DBF61 VA: 0x18DBE60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x18DB070 Offset: 0x18DB171 VA: 0x18DB070
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x18DB630 Offset: 0x18DB731 VA: 0x18DB630
	internal int GetSlotTableLength() { }

	// RVA: 0x18DC050 Offset: 0x18DC151 VA: 0x18DC050
	public void .ctor() { }
}

internal sealed class LocalDataStoreMgr // TypeDefIndex: 151
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x18DB720 Offset: 0x18DB821 VA: 0x18DB720
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x18DADF0 Offset: 0x18DAEF1 VA: 0x18DADF0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x18DB8B0 Offset: 0x18DB9B1 VA: 0x18DB8B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x18DBB50 Offset: 0x18DBC51 VA: 0x18DBB50
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x18DBC60 Offset: 0x18DBD61 VA: 0x18DBC60
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x18DBD80 Offset: 0x18DBE81 VA: 0x18DBD80
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x18DBE60 Offset: 0x18DBF61 VA: 0x18DBE60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x18DB070 Offset: 0x18DB171 VA: 0x18DB070
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x18DB630 Offset: 0x18DB731 VA: 0x18DB630
	internal int GetSlotTableLength() { }

	// RVA: 0x18DC050 Offset: 0x18DC151 VA: 0x18DC050
	public void .ctor() { }
}

internal sealed class LocalDataStoreMgr // TypeDefIndex: 151
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x18DB720 Offset: 0x18DB821 VA: 0x18DB720
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x18DADF0 Offset: 0x18DAEF1 VA: 0x18DADF0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x18DB8B0 Offset: 0x18DB9B1 VA: 0x18DB8B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x18DBB50 Offset: 0x18DBC51 VA: 0x18DBB50
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x18DBC60 Offset: 0x18DBD61 VA: 0x18DBC60
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x18DBD80 Offset: 0x18DBE81 VA: 0x18DBD80
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x18DBE60 Offset: 0x18DBF61 VA: 0x18DBE60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x18DB070 Offset: 0x18DB171 VA: 0x18DB070
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x18DB630 Offset: 0x18DB731 VA: 0x18DB630
	internal int GetSlotTableLength() { }

	// RVA: 0x18DC050 Offset: 0x18DC151 VA: 0x18DC050
	public void .ctor() { }
}

internal sealed class LocalDataStoreMgr // TypeDefIndex: 151
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x18DB720 Offset: 0x18DB821 VA: 0x18DB720
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x18DADF0 Offset: 0x18DAEF1 VA: 0x18DADF0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x18DB8B0 Offset: 0x18DB9B1 VA: 0x18DB8B0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x18DBB50 Offset: 0x18DBC51 VA: 0x18DBB50
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x18DBC60 Offset: 0x18DBD61 VA: 0x18DBC60
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x18DBD80 Offset: 0x18DBE81 VA: 0x18DBD80
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x18DBE60 Offset: 0x18DBF61 VA: 0x18DBE60
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x18DB070 Offset: 0x18DB171 VA: 0x18DB070
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x18DB630 Offset: 0x18DB731 VA: 0x18DB630
	internal int GetSlotTableLength() { }

	// RVA: 0x18DC050 Offset: 0x18DC151 VA: 0x18DC050
	public void .ctor() { }
}

