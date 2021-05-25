public class ResourceLocationBase : IResourceLocation // TypeDefIndex: 4504
{
	// Fields
	private string m_Name; // 0x10
	private string m_Id; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Data; // 0x28
	private int m_DependencyHashCode; // 0x30
	private int m_HashCode; // 0x34
	private Type m_Type; // 0x38
	private List<IResourceLocation> m_Dependencies; // 0x40
	private string m_PrimaryKey; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public object Data { get; set; }
	public string PrimaryKey { get; set; }
	public int DependencyHashCode { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x19D8560 Offset: 0x19D8661 VA: 0x19D8560 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x19D8570 Offset: 0x19D8671 VA: 0x19D8570 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x19D8580 Offset: 0x19D8681 VA: 0x19D8580 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x19D8590 Offset: 0x19D8691 VA: 0x19D8590 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x19D8600 Offset: 0x19D8701 VA: 0x19D8600 Slot: 10
	public object get_Data() { }

	// RVA: 0x19D8610 Offset: 0x19D8711 VA: 0x19D8610
	public void set_Data(object value) { }

	// RVA: 0x19D8620 Offset: 0x19D8721 VA: 0x19D8620 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x19D8630 Offset: 0x19D8731 VA: 0x19D8630
	public void set_PrimaryKey(string value) { }

	// RVA: 0x19D8640 Offset: 0x19D8741 VA: 0x19D8640 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x19D8650 Offset: 0x19D8751 VA: 0x19D8650 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x19D8660 Offset: 0x19D8761 VA: 0x19D8660 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x19D86C0 Offset: 0x19D87C1 VA: 0x19D86C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19D86D0 Offset: 0x19D87D1 VA: 0x19D86D0
	public void .ctor(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	// RVA: 0x19D8920 Offset: 0x19D8A21 VA: 0x19D8920
	public void ComputeDependencyHash() { }
}

