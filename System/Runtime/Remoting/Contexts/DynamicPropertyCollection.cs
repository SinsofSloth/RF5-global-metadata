internal class DynamicPropertyCollection // TypeDefIndex: 1145
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x1745F00 Offset: 0x1746001 VA: 0x1745F00
	public bool get_HasProperties() { }

	// RVA: 0x17462A0 Offset: 0x17463A1 VA: 0x17462A0
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x1746660 Offset: 0x1746761 VA: 0x1746660
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1746A80 Offset: 0x1746B81 VA: 0x1746A80
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x17499B0 Offset: 0x1749AB1 VA: 0x17499B0
	private int FindProperty(string name) { }

	// RVA: 0x17468D0 Offset: 0x17469D1 VA: 0x17468D0
	public void .ctor() { }
}

