public abstract class RestraintController : MonoBehaviour // TypeDefIndex: 6782
{
	// Fields
	[SerializeField] // RVA: 0x15F7E0 Offset: 0x15F8E1 VA: 0x15F7E0
	protected Transform m_effectPoint; // 0x18
	protected ParticleSystem m_effect; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15F7F0 Offset: 0x15F8F1 VA: 0x15F7F0
	private bool <IsRestraint>k__BackingField; // 0x28

	// Properties
	public bool IsRestraint { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CF30 Offset: 0x19D031 VA: 0x19CF30
	// RVA: 0x232B8F0 Offset: 0x232B9F1 VA: 0x232B8F0
	public bool get_IsRestraint() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CF40 Offset: 0x19D041 VA: 0x19CF40
	// RVA: 0x232B900 Offset: 0x232BA01 VA: 0x232B900
	protected void set_IsRestraint(bool value) { }

	// RVA: 0x232B910 Offset: 0x232BA11 VA: 0x232B910 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x232B920 Offset: 0x232BA21 VA: 0x232B920 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x232BA00 Offset: 0x232BB01 VA: 0x232BA00 Slot: 6
	public virtual void Setup() { }

	// RVA: 0x232BA10 Offset: 0x232BB11 VA: 0x232BA10 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x232BA20 Offset: 0x232BB21 VA: 0x232BA20 Slot: 8
	public virtual void OnRestraint() { }

	// RVA: 0x232BBE0 Offset: 0x232BCE1 VA: 0x232BBE0 Slot: 9
	public virtual void OnRelease() { }

	// RVA: 0x232BCD0 Offset: 0x232BDD1 VA: 0x232BCD0
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CF50 Offset: 0x19D051 VA: 0x19CF50
	// RVA: 0x232BCE0 Offset: 0x232BDE1 VA: 0x232BCE0
	private void <OnRestraint>b__10_0(ParticleSystem effect) { }
}

