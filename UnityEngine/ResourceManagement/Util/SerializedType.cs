[Serializable]
public struct SerializedType // TypeDefIndex: 4473
{
	// Fields
	[SerializeField] // RVA: 0x129C40 Offset: 0x129D41 VA: 0x129C40
	[FormerlySerializedAsAttribute] // RVA: 0x129C40 Offset: 0x129D41 VA: 0x129C40
	private string m_AssemblyName; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0x129C90 Offset: 0x129D91 VA: 0x129C90
	[SerializeField] // RVA: 0x129C90 Offset: 0x129D91 VA: 0x129C90
	private string m_ClassName; // 0x8
	private Type m_CachedType; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x129CE0 Offset: 0x129DE1 VA: 0x129CE0
	private bool <ValueChanged>k__BackingField; // 0x18

	// Properties
	public string AssemblyName { get; }
	public string ClassName { get; }
	public Type Value { get; set; }
	public bool ValueChanged { get; set; }

	// Methods

	// RVA: 0x16840 Offset: 0x16941 VA: 0x16840
	public string get_AssemblyName() { }

	// RVA: 0x16850 Offset: 0x16951 VA: 0x16850
	public string get_ClassName() { }

	// RVA: 0x16860 Offset: 0x16961 VA: 0x16860 Slot: 3
	public override string ToString() { }

	// RVA: 0x16870 Offset: 0x16971 VA: 0x16870
	public Type get_Value() { }

	// RVA: 0x16880 Offset: 0x16981 VA: 0x16880
	public void set_Value(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12A250 Offset: 0x12A351 VA: 0x12A250
	// RVA: 0x16890 Offset: 0x16991 VA: 0x16890
	public bool get_ValueChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A260 Offset: 0x12A361 VA: 0x12A260
	// RVA: 0x168A0 Offset: 0x169A1 VA: 0x168A0
	public void set_ValueChanged(bool value) { }
}

