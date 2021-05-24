private struct DelayedActionManager.DelegateInfo // TypeDefIndex: 4464
{
	// Fields
	private static int s_Id; // 0x0
	private int m_Id; // 0x0
	private Delegate m_Delegate; // 0x8
	private object[] m_Target; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x129C30 Offset: 0x129D31 VA: 0x129C30
	private float <InvocationTime>k__BackingField; // 0x18

	// Properties
	public float InvocationTime { get; set; }

	// Methods

	// RVA: 0x165E0 Offset: 0x166E1 VA: 0x165E0
	public void .ctor(Delegate d, float invocationTime, object[] p) { }

	[CompilerGeneratedAttribute] // RVA: 0x12A230 Offset: 0x12A331 VA: 0x12A230
	// RVA: 0x16680 Offset: 0x16781 VA: 0x16680
	public float get_InvocationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A240 Offset: 0x12A341 VA: 0x12A240
	// RVA: 0x16690 Offset: 0x16791 VA: 0x16690
	private void set_InvocationTime(float value) { }

	// RVA: 0x166A0 Offset: 0x167A1 VA: 0x166A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x166B0 Offset: 0x167B1 VA: 0x166B0
	public void Invoke() { }
}

