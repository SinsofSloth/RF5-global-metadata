private class ContentCatalogData.CompactLocation : IResourceLocation // TypeDefIndex: 5727
{
	// Fields
	private ResourceLocationMap m_Locator; // 0x10
	private string m_InternalId; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Dependency; // 0x28
	private object m_Data; // 0x30
	private int m_HashCode; // 0x38
	private int m_DependencyHashCode; // 0x3C
	private string m_PrimaryKey; // 0x40
	private Type m_Type; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public int DependencyHashCode { get; }
	public object Data { get; }
	public string PrimaryKey { get; set; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x15EB900 Offset: 0x15EBA01 VA: 0x15EB900 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x15EB910 Offset: 0x15EBA11 VA: 0x15EB910 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x15EB920 Offset: 0x15EBA21 VA: 0x15EB920 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x15EB9F0 Offset: 0x15EBAF1 VA: 0x15EB9F0 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x15EBA00 Offset: 0x15EBB01 VA: 0x15EBA00 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x15EBA10 Offset: 0x15EBB11 VA: 0x15EBA10 Slot: 10
	public object get_Data() { }

	// RVA: 0x15EBA20 Offset: 0x15EBB21 VA: 0x15EBA20 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x15EBA30 Offset: 0x15EBB31 VA: 0x15EBA30
	public void set_PrimaryKey(string value) { }

	// RVA: 0x15EBA40 Offset: 0x15EBB41 VA: 0x15EBA40 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x15EBA50 Offset: 0x15EBB51 VA: 0x15EBA50 Slot: 3
	public override string ToString() { }

	// RVA: 0x15EBA60 Offset: 0x15EBB61 VA: 0x15EBA60 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x15EB660 Offset: 0x15EB761 VA: 0x15EB660
	public void .ctor(ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, Type type) { }
}

