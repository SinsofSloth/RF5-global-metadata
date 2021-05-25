public class ResourceLocationMap : IResourceLocator // TypeDefIndex: 5731
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13E1A0 Offset: 0x13E2A1 VA: 0x13E1A0
	private string <LocatorId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x13E1B0 Offset: 0x13E2B1 VA: 0x13E1B0
	private Dictionary<object, IList<IResourceLocation>> <Locations>k__BackingField; // 0x18

	// Properties
	public string LocatorId { get; set; }
	public Dictionary<object, IList<IResourceLocation>> Locations { get; set; }
	public IEnumerable<object> Keys { get; }

	// Methods

	// RVA: 0x15EB4D0 Offset: 0x15EB5D1 VA: 0x15EB4D0
	public void .ctor(string id, int capacity = 0) { }

	[CompilerGeneratedAttribute] // RVA: 0x13EAE0 Offset: 0x13EBE1 VA: 0x13EAE0
	// RVA: 0x15EC180 Offset: 0x15EC281 VA: 0x15EC180 Slot: 4
	public string get_LocatorId() { }

	[CompilerGeneratedAttribute] // RVA: 0x13EAF0 Offset: 0x13EBF1 VA: 0x13EAF0
	// RVA: 0x15EC190 Offset: 0x15EC291 VA: 0x15EC190
	private void set_LocatorId(string value) { }

	// RVA: 0x15E7370 Offset: 0x15E7471 VA: 0x15E7370
	public void .ctor(string id, IList<ResourceLocationData> locations) { }

	[CompilerGeneratedAttribute] // RVA: 0x13EB00 Offset: 0x13EC01 VA: 0x13EB00
	// RVA: 0x15EC2F0 Offset: 0x15EC3F1 VA: 0x15EC2F0
	public Dictionary<object, IList<IResourceLocation>> get_Locations() { }

	[CompilerGeneratedAttribute] // RVA: 0x13EB10 Offset: 0x13EC11 VA: 0x13EB10
	// RVA: 0x15EC300 Offset: 0x15EC401 VA: 0x15EC300
	private void set_Locations(Dictionary<object, IList<IResourceLocation>> value) { }

	// RVA: 0x15EC310 Offset: 0x15EC411 VA: 0x15EC310 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x15E7CF0 Offset: 0x15E7DF1 VA: 0x15E7CF0 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x15EC1A0 Offset: 0x15EC2A1 VA: 0x15EC1A0
	public void Add(object key, IResourceLocation location) { }

	// RVA: 0x15EB810 Offset: 0x15EB911 VA: 0x15EB810
	public void Add(object key, IList<IResourceLocation> locations) { }
}

