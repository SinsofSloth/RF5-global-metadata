public abstract class SlowStateController : MonoBehaviour // TypeDefIndex: 6796
{
	// Fields
	[SerializeField] // RVA: 0x15FA00 Offset: 0x15FB01 VA: 0x15FA00
	protected Transform m_effectPoint; // 0x18
	protected ParticleSystem m_effect; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15FA10 Offset: 0x15FB11 VA: 0x15FA10
	private bool <IsSlow>k__BackingField; // 0x28

	// Properties
	public bool IsSlow { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19D1D0 Offset: 0x19D2D1 VA: 0x19D1D0
	// RVA: 0x210C570 Offset: 0x210C671 VA: 0x210C570
	public bool get_IsSlow() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D1E0 Offset: 0x19D2E1 VA: 0x19D1E0
	// RVA: 0x210C580 Offset: 0x210C681 VA: 0x210C580
	protected void set_IsSlow(bool value) { }

	// RVA: 0x210C590 Offset: 0x210C691 VA: 0x210C590 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x210C5A0 Offset: 0x210C6A1 VA: 0x210C5A0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x210C670 Offset: 0x210C771 VA: 0x210C670 Slot: 6
	public virtual void Setup() { }

	// RVA: 0x210C680 Offset: 0x210C781 VA: 0x210C680 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x210C690 Offset: 0x210C791 VA: 0x210C690 Slot: 8
	public virtual void DoSlow() { }

	// RVA: 0x210C7A0 Offset: 0x210C8A1 VA: 0x210C7A0 Slot: 9
	public virtual void OnRelease() { }

	// RVA: 0x210C890 Offset: 0x210C991 VA: 0x210C890 Slot: 10
	protected virtual float AdjustmentScale() { }

	// RVA: 0x210C8A0 Offset: 0x210C9A1 VA: 0x210C8A0
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D1F0 Offset: 0x19D2F1 VA: 0x19D1F0
	// RVA: 0x210C8B0 Offset: 0x210C9B1 VA: 0x210C8B0
	private void <DoSlow>b__10_0(ParticleSystem effect) { }
}

