public abstract class PersonalMotionController : MonoBehaviour // TypeDefIndex: 6600
{
	// Fields
	protected PersonalMotionDataTable m_DataTable; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15D9E0 Offset: 0x15DAE1 VA: 0x15D9E0
	private bool <IsActivated>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15D9F0 Offset: 0x15DAF1 VA: 0x15D9F0
	private bool <IsMotionPlay>k__BackingField; // 0x21
	protected float m_elapsed; // 0x24

	// Properties
	public bool IsActivated { get; set; }
	public bool IsMotionPlay { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B960 Offset: 0x19BA61 VA: 0x19B960
	// RVA: 0x1FE20E0 Offset: 0x1FE21E1 VA: 0x1FE20E0
	public bool get_IsActivated() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B970 Offset: 0x19BA71 VA: 0x19B970
	// RVA: 0x1FE20F0 Offset: 0x1FE21F1 VA: 0x1FE20F0
	protected void set_IsActivated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B980 Offset: 0x19BA81 VA: 0x19B980
	// RVA: 0x1FE2100 Offset: 0x1FE2201 VA: 0x1FE2100
	public bool get_IsMotionPlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B990 Offset: 0x19BA91 VA: 0x19B990
	// RVA: 0x1FE2110 Offset: 0x1FE2211 VA: 0x1FE2110
	protected void set_IsMotionPlay(bool value) { }

	// RVA: 0x1FE2120 Offset: 0x1FE2221 VA: 0x1FE2120 Slot: 4
	public virtual void Setup() { }

	// RVA: 0x1FE2130 Offset: 0x1FE2231 VA: 0x1FE2130 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1FE2140 Offset: 0x1FE2241 VA: 0x1FE2140 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x1FE2150 Offset: 0x1FE2251 VA: 0x1FE2150 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x1FE2160 Offset: 0x1FE2261 VA: 0x1FE2160 Slot: 8
	public virtual void SetActivate(bool active) { }

	// RVA: 0x1FE21C0 Offset: 0x1FE22C1 VA: 0x1FE21C0 Slot: 9
	public virtual void DoPlayMotion() { }

	// RVA: 0x1FE2210 Offset: 0x1FE2311 VA: 0x1FE2210 Slot: 10
	public virtual void DoStopMotion() { }

	// RVA: 0x1FE2220 Offset: 0x1FE2321 VA: 0x1FE2220 Slot: 11
	public virtual void PlayMotion(int no) { }

	// RVA: 0x1FE2230 Offset: 0x1FE2331 VA: 0x1FE2230 Slot: 12
	public virtual void OnMotionPlay(int no) { }

	// RVA: 0x1FE2240 Offset: 0x1FE2341 VA: 0x1FE2240
	protected void .ctor() { }
}

