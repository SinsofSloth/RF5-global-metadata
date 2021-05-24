[Serializable]
internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 1126
{
	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x15FAAC0 Offset: 0x15FABC1 VA: 0x15FAAC0
	public void .ctor(Type type) { }

	// RVA: 0x15FCEC0 Offset: 0x15FCFC1 VA: 0x15FCEC0 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x15FCED0 Offset: 0x15FCFD1 VA: 0x15FCED0 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }
}

