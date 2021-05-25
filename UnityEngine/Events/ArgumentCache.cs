[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 3093
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCAD40 Offset: 0xCAE41 VA: 0xCAD40
	[SerializeField] // RVA: 0xCAD40 Offset: 0xCAE41 VA: 0xCAD40
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xCAD90 Offset: 0xCAE91 VA: 0xCAD90
	[SerializeField] // RVA: 0xCAD90 Offset: 0xCAE91 VA: 0xCAD90
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField] // RVA: 0xCADE0 Offset: 0xCAEE1 VA: 0xCADE0
	[FormerlySerializedAsAttribute] // RVA: 0xCADE0 Offset: 0xCAEE1 VA: 0xCADE0
	private int m_IntArgument; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xCAE30 Offset: 0xCAF31 VA: 0xCAE30
	[SerializeField] // RVA: 0xCAE30 Offset: 0xCAF31 VA: 0xCAE30
	private float m_FloatArgument; // 0x24
	[FormerlySerializedAsAttribute] // RVA: 0xCAE80 Offset: 0xCAF81 VA: 0xCAE80
	[SerializeField] // RVA: 0xCAE80 Offset: 0xCAF81 VA: 0xCAE80
	private string m_StringArgument; // 0x28
	[SerializeField] // RVA: 0xCAED0 Offset: 0xCAFD1 VA: 0xCAED0
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x2B07570 Offset: 0x2B07671 VA: 0x2B07570
	public Object get_unityObjectArgument() { }

	// RVA: 0x2B07580 Offset: 0x2B07681 VA: 0x2B07580
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x2B07590 Offset: 0x2B07691 VA: 0x2B07590
	public int get_intArgument() { }

	// RVA: 0x2B075A0 Offset: 0x2B076A1 VA: 0x2B075A0
	public float get_floatArgument() { }

	// RVA: 0x2B075B0 Offset: 0x2B076B1 VA: 0x2B075B0
	public string get_stringArgument() { }

	// RVA: 0x2B075C0 Offset: 0x2B076C1 VA: 0x2B075C0
	public bool get_boolArgument() { }

	// RVA: 0x2B075D0 Offset: 0x2B076D1 VA: 0x2B075D0
	private void TidyAssemblyTypeName() { }

	// RVA: 0x2B07820 Offset: 0x2B07921 VA: 0x2B07820 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2B07830 Offset: 0x2B07931 VA: 0x2B07830 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2B07840 Offset: 0x2B07941 VA: 0x2B07840
	public void .ctor() { }
}

