public class ProjectileBulletBase : MonoBehaviour // TypeDefIndex: 8386
{
	// Fields
	private const float GravityAccel = -9.8;
	[SerializeField] // RVA: 0x16F360 Offset: 0x16F461 VA: 0x16F360
	public bool HitAndDestory; // 0x18
	[HideInInspector] // RVA: 0x16F370 Offset: 0x16F471 VA: 0x16F370
	public CharacterBase Owner; // 0x20
	[HideInInspector] // RVA: 0x16F380 Offset: 0x16F481 VA: 0x16F380
	public DamageInfo DamageInfo; // 0x28
	[SerializeField] // RVA: 0x16F390 Offset: 0x16F491 VA: 0x16F390
	public EffectID HitEffectName; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x16F3A0 Offset: 0x16F4A1 VA: 0x16F3A0
	private bool <IsStartBehavior>k__BackingField; // 0xAC
	public Vector3 Velocity; // 0xB0
	public Vector3 Direction; // 0xBC
	public float Speed; // 0xC8
	public float LifeTime; // 0xCC
	public bool UseLifeTime; // 0xD0
	public bool IsRandomDirection; // 0xD1
	public Vector2 RandomAngle; // 0xD4
	public bool UseGravity; // 0xDC
	private Collider _Collider; // 0xE0
	public ProjectileBulletBehaviorBase ProjectileBulletBehaviorBase; // 0xE8
	public UnityEventMonsterActionHit OnHitEvent; // 0xF0
	public UnityEventCollider OnHitGroundEvent; // 0xF8
	private List<CharacterBase> HitList; // 0x100
	private float ClearHitListTime; // 0x108
	private float ClearHitListTimer; // 0x10C

	// Properties
	public bool IsStartBehavior { get; set; }
	public Collider Collider { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A73D0 Offset: 0x1A74D1 VA: 0x1A73D0
	// RVA: 0x1DEA810 Offset: 0x1DEA911 VA: 0x1DEA810
	public bool get_IsStartBehavior() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A73E0 Offset: 0x1A74E1 VA: 0x1A73E0
	// RVA: 0x1DEA820 Offset: 0x1DEA921 VA: 0x1DEA820
	private void set_IsStartBehavior(bool value) { }

	// RVA: 0x1DEA830 Offset: 0x1DEA931 VA: 0x1DEA830
	public Collider get_Collider() { }

	// RVA: 0x1DEA8E0 Offset: 0x1DEA9E1 VA: 0x1DEA8E0
	private void Awake() { }

	// RVA: 0x1DEA960 Offset: 0x1DEAA61 VA: 0x1DEA960 Slot: 4
	public virtual void Setup() { }

	// RVA: 0x1DEAB00 Offset: 0x1DEAC01 VA: 0x1DEAB00 Slot: 5
	protected virtual void InitializeDirection() { }

	// RVA: 0x1DEAE60 Offset: 0x1DEAF61 VA: 0x1DEAE60
	public void SetupBehavior(ProjectileBulletBehaviorBase projectileBulletBehaviorBase) { }

	// RVA: 0x1DEAEE0 Offset: 0x1DEAFE1 VA: 0x1DEAEE0
	public void StartBehavior() { }

	// RVA: 0x1DEAF00 Offset: 0x1DEB001 VA: 0x1DEAF00
	public void SetColliderEnable(bool enable) { }

	// RVA: 0x1DEB0B0 Offset: 0x1DEB1B1 VA: 0x1DEB0B0
	private bool IsTarget(CharacterBase characterBase) { }

	// RVA: 0x1DEB250 Offset: 0x1DEB351 VA: 0x1DEB250
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1DEBA90 Offset: 0x1DEBB91 VA: 0x1DEBA90
	private void Update() { }

	// RVA: 0x1DEBB40 Offset: 0x1DEBC41 VA: 0x1DEBB40
	public void SetClearHitListTime(float time) { }

	// RVA: 0x1DEAA90 Offset: 0x1DEAB91 VA: 0x1DEAA90
	public void ClearHitList() { }

	// RVA: 0x1DEBB50 Offset: 0x1DEBC51 VA: 0x1DEBB50
	private void UpdateClearHitList() { }

	// RVA: 0x1DEBC00 Offset: 0x1DEBD01 VA: 0x1DEBC00 Slot: 6
	protected virtual void UpdateBehavior() { }

	// RVA: 0x1DEBE10 Offset: 0x1DEBF11 VA: 0x1DEBE10
	public void SetRotationVelocity() { }

	// RVA: 0x1DEBEF0 Offset: 0x1DEBFF1 VA: 0x1DEBEF0
	public void SetRotationDirection() { }

	// RVA: 0x1DEBFD0 Offset: 0x1DEC0D1 VA: 0x1DEBFD0 Slot: 7
	protected virtual void UpdateVelocity() { }

	// RVA: 0x1DEC070 Offset: 0x1DEC171 VA: 0x1DEC070 Slot: 8
	protected virtual void UpdatePosition() { }

	// RVA: 0x1DEC170 Offset: 0x1DEC271 VA: 0x1DEC170 Slot: 9
	protected virtual void UpdateLifeTime() { }

	// RVA: 0x1DEBDA0 Offset: 0x1DEBEA1 VA: 0x1DEBDA0
	protected void UpdateAddGravityVelocity() { }

	// RVA: 0x1DEC220 Offset: 0x1DEC321 VA: 0x1DEC220
	protected void AddGravityAccel() { }

	// RVA: 0x1DEC270 Offset: 0x1DEC371 VA: 0x1DEC270
	private void OnDrawGizmos() { }

	// RVA: 0x1DEC390 Offset: 0x1DEC491 VA: 0x1DEC390
	public void .ctor() { }
}

