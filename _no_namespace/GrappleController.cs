public abstract class GrappleController : MonoBehaviour // TypeDefIndex: 6591
{
	// Fields
	[SerializeField] // RVA: 0x15D8A0 Offset: 0x15D9A1 VA: 0x15D8A0
	protected Collider m_collider; // 0x18
	[SerializeField] // RVA: 0x15D8B0 Offset: 0x15D9B1 VA: 0x15D8B0
	protected List<Transform> m_hands; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15D8C0 Offset: 0x15D9C1 VA: 0x15D8C0
	private bool <IsGrappling>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15D8D0 Offset: 0x15D9D1 VA: 0x15D8D0
	private bool <IsAttached>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x15D8E0 Offset: 0x15D9E1 VA: 0x15D8E0
	private GrapInterface <Target>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15D8F0 Offset: 0x15D9F1 VA: 0x15D8F0
	private Collider <TargetCollider>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15D900 Offset: 0x15DA01 VA: 0x15D900
	private bool <IsThrowing>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15D910 Offset: 0x15DA11 VA: 0x15D910
	private float <DirectionRate>k__BackingField; // 0x44

	// Properties
	public bool IsGrappling { get; set; }
	public bool IsAttached { get; set; }
	public GrapInterface Target { get; set; }
	public Collider TargetCollider { get; set; }
	public bool IsThrowing { get; set; }
	public float DirectionRate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B860 Offset: 0x19B961 VA: 0x19B860
	// RVA: 0x1EB34B0 Offset: 0x1EB35B1 VA: 0x1EB34B0
	public bool get_IsGrappling() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B870 Offset: 0x19B971 VA: 0x19B870
	// RVA: 0x1EB34C0 Offset: 0x1EB35C1 VA: 0x1EB34C0
	protected void set_IsGrappling(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B880 Offset: 0x19B981 VA: 0x19B880
	// RVA: 0x1EB34D0 Offset: 0x1EB35D1 VA: 0x1EB34D0
	public bool get_IsAttached() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B890 Offset: 0x19B991 VA: 0x19B890
	// RVA: 0x1EB34E0 Offset: 0x1EB35E1 VA: 0x1EB34E0
	protected void set_IsAttached(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B8A0 Offset: 0x19B9A1 VA: 0x19B8A0
	// RVA: 0x1EB34F0 Offset: 0x1EB35F1 VA: 0x1EB34F0
	public GrapInterface get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B8B0 Offset: 0x19B9B1 VA: 0x19B8B0
	// RVA: 0x1EB3500 Offset: 0x1EB3601 VA: 0x1EB3500
	protected void set_Target(GrapInterface value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B8C0 Offset: 0x19B9C1 VA: 0x19B8C0
	// RVA: 0x1EB3510 Offset: 0x1EB3611 VA: 0x1EB3510
	public Collider get_TargetCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B8D0 Offset: 0x19B9D1 VA: 0x19B8D0
	// RVA: 0x1EB3520 Offset: 0x1EB3621 VA: 0x1EB3520
	protected void set_TargetCollider(Collider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B8E0 Offset: 0x19B9E1 VA: 0x19B8E0
	// RVA: 0x1EB3530 Offset: 0x1EB3631 VA: 0x1EB3530
	public bool get_IsThrowing() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B8F0 Offset: 0x19B9F1 VA: 0x19B8F0
	// RVA: 0x1EB3540 Offset: 0x1EB3641 VA: 0x1EB3540
	protected void set_IsThrowing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B900 Offset: 0x19BA01 VA: 0x19B900
	// RVA: 0x1EB3550 Offset: 0x1EB3651 VA: 0x1EB3550
	public float get_DirectionRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B910 Offset: 0x19BA11 VA: 0x19B910
	// RVA: 0x1EB3560 Offset: 0x1EB3661 VA: 0x1EB3560
	public void set_DirectionRate(float value) { }

	// RVA: 0x1EB3570 Offset: 0x1EB3671 VA: 0x1EB3570 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1EB3680 Offset: 0x1EB3781 VA: 0x1EB3680 Slot: 5
	public virtual void Setup() { }

	// RVA: 0x1EB3690 Offset: 0x1EB3791 VA: 0x1EB3690 Slot: 6
	protected virtual void DoEnd() { }

	// RVA: 0x1EB3900 Offset: 0x1EB3A01 VA: 0x1EB3900 Slot: 7
	public virtual void DoCancel() { }

	// RVA: 0x1EB3920 Offset: 0x1EB3A21 VA: 0x1EB3920 Slot: 8
	public virtual bool DoAttach() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void ResetThrowPosition() { }

	// RVA: 0x1EB3940 Offset: 0x1EB3A41 VA: 0x1EB3940 Slot: 10
	public virtual void DoRelease() { }

	// RVA: 0x1EB3B10 Offset: 0x1EB3C11 VA: 0x1EB3B10 Slot: 11
	public virtual bool DoGrap(GrapInterface target) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void DoThrow(float angle, float power, MagicParamID id1, MagicParamID id2 = 0) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void DoPound() { }

	// RVA: 0x1EB3CC0 Offset: 0x1EB3DC1 VA: 0x1EB3CC0 Slot: 14
	public virtual void OnThrowEnd() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void DoFlung() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void DoSwing() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void DoSlam() { }

	// RVA: 0x1EB3CD0 Offset: 0x1EB3DD1 VA: 0x1EB3CD0 Slot: 18
	public virtual void UpdateTargetPosition() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void TakeDamage(MagicParamID id) { }

	// RVA: 0x1EB4080 Offset: 0x1EB4181 VA: 0x1EB4080 Slot: 20
	protected virtual void OnTakeDamage(DamageInfo damageInfo, DamageResult damageResult) { }

	// RVA: 0x1EB40A0 Offset: 0x1EB41A1 VA: 0x1EB40A0
	protected void .ctor() { }
}

