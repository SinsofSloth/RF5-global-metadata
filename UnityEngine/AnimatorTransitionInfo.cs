[RequiredByNativeCodeAttribute] // RVA: 0xE89C0 Offset: 0xE8AC1 VA: 0xE89C0
[NativeHeaderAttribute] // RVA: 0xE89C0 Offset: 0xE8AC1 VA: 0xE89C0
public struct AnimatorTransitionInfo // TypeDefIndex: 3484
{
	// Fields
	[NativeNameAttribute] // RVA: 0xEA390 Offset: 0xEA491 VA: 0xEA390
	private int m_FullPath; // 0x0
	[NativeNameAttribute] // RVA: 0xEA3D0 Offset: 0xEA4D1 VA: 0xEA3D0
	private int m_UserName; // 0x4
	[NativeNameAttribute] // RVA: 0xEA410 Offset: 0xEA511 VA: 0xEA410
	private int m_Name; // 0x8
	[NativeNameAttribute] // RVA: 0xEA450 Offset: 0xEA551 VA: 0xEA450
	private bool m_HasFixedDuration; // 0xC
	[NativeNameAttribute] // RVA: 0xEA490 Offset: 0xEA591 VA: 0xEA490
	private float m_Duration; // 0x10
	[NativeNameAttribute] // RVA: 0xEA4D0 Offset: 0xEA5D1 VA: 0xEA4D0
	private float m_NormalizedTime; // 0x14
	[NativeNameAttribute] // RVA: 0xEA510 Offset: 0xEA611 VA: 0xEA510
	private bool m_AnyState; // 0x18
	[NativeNameAttribute] // RVA: 0xEA550 Offset: 0xEA651 VA: 0xEA550
	private int m_TransitionType; // 0x1C

	// Properties
	public float normalizedTime { get; }
	public bool anyState { get; }

	// Methods

	// RVA: 0x1DAF0 Offset: 0x1DBF1 VA: 0x1DAF0
	public float get_normalizedTime() { }

	// RVA: 0x1DB00 Offset: 0x1DC01 VA: 0x1DB00
	public bool get_anyState() { }
}

