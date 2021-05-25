public class SuperArmorController : MonoBehaviour // TypeDefIndex: 6799
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15FA30 Offset: 0x15FB31 VA: 0x15FA30
	private float <Duration>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15FA40 Offset: 0x15FB41 VA: 0x15FA40
	private float <Elapsed>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x15FA50 Offset: 0x15FB51 VA: 0x15FA50
	private bool <IsPlaying>k__BackingField; // 0x20

	// Properties
	public float Duration { get; set; }
	public float Elapsed { get; set; }
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19D200 Offset: 0x19D301 VA: 0x19D200
	// RVA: 0x1C62DD0 Offset: 0x1C62ED1 VA: 0x1C62DD0
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D210 Offset: 0x19D311 VA: 0x19D210
	// RVA: 0x1C62DE0 Offset: 0x1C62EE1 VA: 0x1C62DE0
	protected void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D220 Offset: 0x19D321 VA: 0x19D220
	// RVA: 0x1C62DF0 Offset: 0x1C62EF1 VA: 0x1C62DF0
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D230 Offset: 0x19D331 VA: 0x19D230
	// RVA: 0x1C62E00 Offset: 0x1C62F01 VA: 0x1C62E00
	protected void set_Elapsed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D240 Offset: 0x19D341 VA: 0x19D240
	// RVA: 0x1C62E10 Offset: 0x1C62F11 VA: 0x1C62E10
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D250 Offset: 0x19D351 VA: 0x19D250
	// RVA: 0x1C62E20 Offset: 0x1C62F21 VA: 0x1C62E20
	public void set_IsPlaying(bool value) { }

	// RVA: 0x1C62E30 Offset: 0x1C62F31 VA: 0x1C62E30 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1C62E40 Offset: 0x1C62F41 VA: 0x1C62E40 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1C62E50 Offset: 0x1C62F51 VA: 0x1C62E50 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x1C62E60 Offset: 0x1C62F61 VA: 0x1C62E60 Slot: 7
	public virtual void DoPlay(float duration) { }

	// RVA: 0x1C62E80 Offset: 0x1C62F81 VA: 0x1C62E80 Slot: 8
	public virtual void DoStop() { }

	// RVA: 0x1C62E90 Offset: 0x1C62F91 VA: 0x1C62E90
	public void OnUpdate() { }

	// RVA: 0x1C62F00 Offset: 0x1C63001 VA: 0x1C62F00
	public void .ctor() { }
}

