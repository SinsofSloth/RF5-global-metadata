public class BasiliskController : BossMonsterContoroller // TypeDefIndex: 7814
{
	// Fields
	private const float keepOnFireTime = 8;
	private const float onFireTime = 8;
	private const float activeColliderTime = 1;
	private const float TailColliderOffVelocity = 0.1;
	private readonly int[] WearFireCountDamageDown; // 0x510
	private const float DefaultNavmeshAgentRadius = 0.5;
	private const float WaitNavmeshAgentRadius = 3;
	[SerializeField] // RVA: 0x169AD0 Offset: 0x169BD1 VA: 0x169AD0
	private BodyPartsCollision Wait_1_TailCollision; // 0x518
	[SerializeField] // RVA: 0x169AE0 Offset: 0x169BE1 VA: 0x169AE0
	private BodyPartsCollision Wait_2_TailCollision; // 0x520
	private List<BasiliskController.WearFireController> WearFireControllerList; // 0x528
	private List<int> IndexList; // 0x530
	private List<BodyPartsCollision> TailCollisionList; // 0x538
	private int LocomotionHash; // 0x540
	private bool IsTailOverwrap; // 0x544
	private DamageInfo WearFireDamageInformation; // 0x548

	// Methods

	// RVA: 0x215F6E0 Offset: 0x215F7E1 VA: 0x215F6E0
	private void SetPreWarmParticleSystem(Transform particleTransform, bool isPreWarm) { }

	// RVA: 0x215F7C0 Offset: 0x215F8C1 VA: 0x215F7C0
	private void SetupWearFire() { }

	// RVA: 0x215FD90 Offset: 0x215FE91 VA: 0x215FD90
	private void UpdateWearFire() { }

	// RVA: 0x215FE30 Offset: 0x215FF31 VA: 0x215FE30
	private int GetRandomOnWearFire() { }

	// RVA: 0x215FF40 Offset: 0x2160041 VA: 0x215FF40
	private int GetWearFireCount() { }

	// RVA: 0x215FFF0 Offset: 0x21600F1 VA: 0x215FFF0
	private float GetWearFireDamageDownRate() { }

	// RVA: 0x21600E0 Offset: 0x21601E1 VA: 0x21600E0 Slot: 135
	protected override void OnRegistCollider() { }

	// RVA: 0x2160140 Offset: 0x2160241 VA: 0x2160140 Slot: 134
	public override void OnSetBodyPartsType(BodyPartsCollision bodyPartsCollision) { }

	// RVA: 0x21601F0 Offset: 0x21602F1 VA: 0x21601F0
	private void SetTailOverwrapPlayer(bool isOverwrap) { }

	// RVA: 0x21604E0 Offset: 0x21605E1 VA: 0x21604E0
	private void UpdateTailCollider() { }

	// RVA: 0x2160590 Offset: 0x2160691 VA: 0x2160590 Slot: 118
	protected override void OnResetActionScriptAction() { }

	// RVA: 0x21605C0 Offset: 0x21606C1 VA: 0x21605C0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x2160630 Offset: 0x2160731 VA: 0x2160630 Slot: 40
	protected override void Update() { }

	// RVA: 0x21606E0 Offset: 0x21607E1 VA: 0x21606E0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x2160810 Offset: 0x2160911 VA: 0x2160810 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x21608D0 Offset: 0x21609D1 VA: 0x21608D0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x21609A0 Offset: 0x2160AA1 VA: 0x21609A0
	public void OnHitAttack(Collider other, Collider attackCollider) { }

	// RVA: 0x2161050 Offset: 0x2161151 VA: 0x2161050
	public void .ctor() { }
}

