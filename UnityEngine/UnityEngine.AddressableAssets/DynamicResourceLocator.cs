internal class DynamicResourceLocator : IResourceLocator // TypeDefIndex: 5713
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x10

	// Properties
	public string LocatorId { get; }
	public virtual IEnumerable<object> Keys { get; }

	// Methods

	// RVA: 0x15E4B00 Offset: 0x15E4C01 VA: 0x15E4B00 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x15E4B50 Offset: 0x15E4C51 VA: 0x15E4B50 Slot: 7
	public virtual IEnumerable<object> get_Keys() { }

	// RVA: 0x15E4BA0 Offset: 0x15E4CA1 VA: 0x15E4BA0
	public void .ctor(AddressablesImpl addr) { }

	// RVA: 0x15E4BE0 Offset: 0x15E4CE1 VA: 0x15E4BE0 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x15E51C0 Offset: 0x15E52C1 VA: 0x15E51C0
	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }
}

