[ComVisibleAttribute] // RVA: 0xB0B80 Offset: 0xB0C81 VA: 0xB0B80
public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 1129
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x15FD300 Offset: 0x15FD401 VA: 0x15FD300
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15FD470 Offset: 0x15FD571 VA: 0x15FD470
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x15FD480 Offset: 0x15FD581 VA: 0x15FD480
	public Type get_ObjectType() { }

	// RVA: 0x15FD490 Offset: 0x15FD591 VA: 0x15FD490
	public string get_ObjectUri() { }

	// RVA: 0x15FD4A0 Offset: 0x15FD5A1 VA: 0x15FD4A0 Slot: 3
	public override string ToString() { }
}

