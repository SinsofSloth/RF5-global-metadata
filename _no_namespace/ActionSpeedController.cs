public class ActionSpeedController : MonoBehaviour // TypeDefIndex: 6515
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15D110 Offset: 0x15D211 VA: 0x15D110
	private float <Speed>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15D120 Offset: 0x15D221 VA: 0x15D120
	private float <Duration>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x15D130 Offset: 0x15D231 VA: 0x15D130
	private float <Elapsed>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15D140 Offset: 0x15D241 VA: 0x15D140
	private bool <IsPlaying>k__BackingField; // 0x24

	// Properties
	public float Speed { get; set; }
	public float Duration { get; set; }
	public float Elapsed { get; set; }
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B5A0 Offset: 0x19B6A1 VA: 0x19B5A0
	// RVA: 0x1BE4580 Offset: 0x1BE4681 VA: 0x1BE4580
	public float get_Speed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B5B0 Offset: 0x19B6B1 VA: 0x19B5B0
	// RVA: 0x1BE4590 Offset: 0x1BE4691 VA: 0x1BE4590
	protected void set_Speed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B5C0 Offset: 0x19B6C1 VA: 0x19B5C0
	// RVA: 0x1BE45A0 Offset: 0x1BE46A1 VA: 0x1BE45A0
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B5D0 Offset: 0x19B6D1 VA: 0x19B5D0
	// RVA: 0x1BE45B0 Offset: 0x1BE46B1 VA: 0x1BE45B0
	protected void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B5E0 Offset: 0x19B6E1 VA: 0x19B5E0
	// RVA: 0x1BE45C0 Offset: 0x1BE46C1 VA: 0x1BE45C0
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B5F0 Offset: 0x19B6F1 VA: 0x19B5F0
	// RVA: 0x1BE45D0 Offset: 0x1BE46D1 VA: 0x1BE45D0
	protected void set_Elapsed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B600 Offset: 0x19B701 VA: 0x19B600
	// RVA: 0x1BE45E0 Offset: 0x1BE46E1 VA: 0x1BE45E0
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B610 Offset: 0x19B711 VA: 0x19B610
	// RVA: 0x1BE45F0 Offset: 0x1BE46F1 VA: 0x1BE45F0
	public void set_IsPlaying(bool value) { }

	// RVA: 0x1BE4600 Offset: 0x1BE4701 VA: 0x1BE4600 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1BE4610 Offset: 0x1BE4711 VA: 0x1BE4610 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1BE4620 Offset: 0x1BE4721 VA: 0x1BE4620 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x1BE4630 Offset: 0x1BE4731 VA: 0x1BE4630 Slot: 7
	public virtual void DoPlay(float speed, float duration) { }

	// RVA: 0x1BE46D0 Offset: 0x1BE47D1 VA: 0x1BE46D0 Slot: 8
	public virtual void DoStop() { }

	// RVA: 0x1BE4710 Offset: 0x1BE4811 VA: 0x1BE4710
	public void OnUpdate() { }

	// RVA: 0x1BE4690 Offset: 0x1BE4791 VA: 0x1BE4690
	protected void ChangeSpeed(float next) { }

	// RVA: 0x1BE4780 Offset: 0x1BE4881 VA: 0x1BE4780 Slot: 9
	protected virtual void OnChangeSpeed(float current, float next) { }

	// RVA: 0x1BE4790 Offset: 0x1BE4891 VA: 0x1BE4790
	public void .ctor() { }
}

