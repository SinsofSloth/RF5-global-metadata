[Serializable]
internal class PersistentCall // TypeDefIndex: 3102
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCB020 Offset: 0xCB121 VA: 0xCB020
	[SerializeField] // RVA: 0xCB020 Offset: 0xCB121 VA: 0xCB020
	private Object m_Target; // 0x10
	[SerializeField] // RVA: 0xCB070 Offset: 0xCB171 VA: 0xCB070
	[FormerlySerializedAsAttribute] // RVA: 0xCB070 Offset: 0xCB171 VA: 0xCB070
	private string m_MethodName; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0xCB0C0 Offset: 0xCB1C1 VA: 0xCB0C0
	[SerializeField] // RVA: 0xCB0C0 Offset: 0xCB1C1 VA: 0xCB0C0
	private PersistentListenerMode m_Mode; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xCB110 Offset: 0xCB211 VA: 0xCB110
	[SerializeField] // RVA: 0xCB110 Offset: 0xCB211 VA: 0xCB110
	private ArgumentCache m_Arguments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xCB160 Offset: 0xCB261 VA: 0xCB160
	[SerializeField] // RVA: 0xCB160 Offset: 0xCB261 VA: 0xCB160
	[FormerlySerializedAsAttribute] // RVA: 0xCB160 Offset: 0xCB261 VA: 0xCB160
	private UnityEventCallState m_CallState; // 0x30

	// Properties
	public Object target { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x2B084B0 Offset: 0x2B085B1 VA: 0x2B084B0
	public Object get_target() { }

	// RVA: 0x2B084C0 Offset: 0x2B085C1 VA: 0x2B084C0
	public string get_methodName() { }

	// RVA: 0x2B084D0 Offset: 0x2B085D1 VA: 0x2B084D0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x2B084E0 Offset: 0x2B085E1 VA: 0x2B084E0
	public ArgumentCache get_arguments() { }

	// RVA: 0x2B084F0 Offset: 0x2B085F1 VA: 0x2B084F0
	public bool IsValid() { }

	// RVA: 0x2B08590 Offset: 0x2B08691 VA: 0x2B08590
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x2B08910 Offset: 0x2B08A11 VA: 0x2B08910
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x2B08D60 Offset: 0x2B08E61 VA: 0x2B08D60
	public void .ctor() { }
}

