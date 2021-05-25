public class MummyController : BossMonsterContoroller // TypeDefIndex: 7946
{
	// Fields
	private static readonly Vector3 SCUTION_FLOOR_EFFECT_SCALE; // 0x0
	private static readonly Vector3 SUCTION_ROTATESOUL_OFFSET; // 0xC
	private const float ROTATESOUL_DOWN_MOVE_TIME = 1;
	private const float ROTATESOUL_BACK_MOVE_SPEED = 3;
	private const float WALK_MOVE_SCALE = 0.5;
	private const float WALK_DISTANCE = 5;
	private const float FORCE_WALK_DISTANCE = 1;
	private const float BULLET_SIN_SCALE = 0.4;
	private const float UPDOWN_SCALE = 1.5;
	private bool IsSetup; // 0x510
	private bool IsDeathSmoke; // 0x511
	[CompilerGeneratedAttribute] // RVA: 0x169E10 Offset: 0x169F11 VA: 0x169E10
	private bool <IsForceLockonMove>k__BackingField; // 0x512
	private int HandPressCount; // 0x514
	private int HandPressMin; // 0x518
	private int HandPressMax; // 0x51C
	private bool IsHitHand; // 0x520
	private MummyHand MummyHandLeft; // 0x528
	private MummyHand MummyHandRight; // 0x530
	private GameObject LeftArm; // 0x538
	private GameObject RightArm; // 0x540
	private bool IsRightPress; // 0x548
	private Transform SuctionColliderTransform; // 0x550
	private bool IsSuction; // 0x558
	private float SuctionPower; // 0x55C
	private float SuctionMaxRange; // 0x560
	private float SuctionMinRange; // 0x564
	private bool IsFlying; // 0x568
	private bool IsBackSoul; // 0x569
	private string ASRestraintName; // 0x570
	private string ASEndName; // 0x578
	private int BulletCount; // 0x580
	private int TempBulletCount; // 0x584
	private int PhaseCount; // 0x588
	private Vector3 RotateSoul; // 0x58C
	private bool IsFlyingDead; // 0x598
	private float UpDownTimer; // 0x59C
	[CompilerGeneratedAttribute] // RVA: 0x169E20 Offset: 0x169F21 VA: 0x169E20
	private int <WalkIndex>k__BackingField; // 0x5A0
	public List<Transform> WalkPosList; // 0x5A8
	private bool IsForceBat; // 0x5B0
	private ParticleSystem BreathEffect; // 0x5B8
	private ParticleSystem[] BreathEffects; // 0x5C0
	private ParticleSystem SoulEffect; // 0x5C8
	private ParticleSystem RotateSoulEffect; // 0x5D0
	private ParticleSystem[] RotateSoulEffects; // 0x5D8
	private ParticleSystem SuctionEffect; // 0x5E0
	private ParticleSystem[] SuctionEffects; // 0x5E8
	private ParticleSystem FloorSuctionEffect; // 0x5F0
	private ParticleSystem[] FloorSuctionEffects; // 0x5F8

	// Properties
	public bool IsForceLockonMove { get; set; }
	public int WalkIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A4800 Offset: 0x1A4901 VA: 0x1A4800
	// RVA: 0x1FAC750 Offset: 0x1FAC851 VA: 0x1FAC750
	public bool get_IsForceLockonMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4810 Offset: 0x1A4911 VA: 0x1A4810
	// RVA: 0x1FAC760 Offset: 0x1FAC861 VA: 0x1FAC760
	public void set_IsForceLockonMove(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4820 Offset: 0x1A4921 VA: 0x1A4820
	// RVA: 0x1FAC770 Offset: 0x1FAC871 VA: 0x1FAC770
	public int get_WalkIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4830 Offset: 0x1A4931 VA: 0x1A4830
	// RVA: 0x1FAC780 Offset: 0x1FAC881 VA: 0x1FAC780
	private void set_WalkIndex(int value) { }

	// RVA: 0x1FAC790 Offset: 0x1FAC891 VA: 0x1FAC790 Slot: 107
	public override bool IsCanRestraint() { }

	// RVA: 0x1FAC7E0 Offset: 0x1FAC8E1 VA: 0x1FAC7E0 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1FAC8C0 Offset: 0x1FAC9C1 VA: 0x1FAC8C0 Slot: 12
	protected override void Start() { }

	// RVA: 0x1FACA20 Offset: 0x1FACB21 VA: 0x1FACA20 Slot: 129
	protected override void OnSetModelObject(GameObject model) { }

	// RVA: 0x1FAD0C0 Offset: 0x1FAD1C1 VA: 0x1FAD0C0 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x1FAD380 Offset: 0x1FAD481 VA: 0x1FAD380 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x1FAD4D0 Offset: 0x1FAD5D1 VA: 0x1FAD4D0 Slot: 139
	public override void OnRelease() { }

	// RVA: 0x1FAD4F0 Offset: 0x1FAD5F1 VA: 0x1FAD4F0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1FAD2F0 Offset: 0x1FAD3F1 VA: 0x1FAD2F0
	private void SetEnableEffectEmission(ParticleSystem[] particles, bool active) { }

	// RVA: 0x1FAD670 Offset: 0x1FAD771 VA: 0x1FAD670
	private void UpdateDeathSmokeMove() { }

	// RVA: 0x1FAD8B0 Offset: 0x1FAD9B1 VA: 0x1FAD8B0
	private void NextWalkIndex() { }

	// RVA: 0x1FABC50 Offset: 0x1FABD51 VA: 0x1FABC50
	public Vector3 GetNextWalkPos() { }

	// RVA: 0x1FABED0 Offset: 0x1FABFD1 VA: 0x1FABED0
	public void FetchNearWalkPosIndex() { }

	// RVA: 0x1FAD950 Offset: 0x1FADA51 VA: 0x1FAD950
	private void BatHitEvent(CharacterBase characterBase, MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1FAD9D0 Offset: 0x1FADAD1 VA: 0x1FAD9D0
	private void BatGoUp(MonsterProjectileActionScriptsController projectileActionScriptsController) { }

	// RVA: 0x1FADB10 Offset: 0x1FADC11 VA: 0x1FADB10
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1FADCB0 Offset: 0x1FADDB1 VA: 0x1FADCB0
	private void StartSuction() { }

	// RVA: 0x1FAD3D0 Offset: 0x1FAD4D1 VA: 0x1FAD3D0
	private void EndSuction() { }

	// RVA: 0x1FADE50 Offset: 0x1FADF51 VA: 0x1FADE50
	private void UpadateBackSoul() { }

	// RVA: 0x1FAE090 Offset: 0x1FAE191 VA: 0x1FAE090
	private void UpdateRotateSoul() { }

	// RVA: 0x1FAE1E0 Offset: 0x1FAE2E1 VA: 0x1FAE1E0 Slot: 140
	protected override void OnHit(CharacterBase characterBase, int actionIndex) { }

	// RVA: 0x1FAE220 Offset: 0x1FAE321 VA: 0x1FAE220 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1FAF7C0 Offset: 0x1FAF8C1 VA: 0x1FAF7C0 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1FAD7A0 Offset: 0x1FAD8A1 VA: 0x1FAD7A0
	private bool HasArrived(float dist) { }

	// RVA: 0x1FAF870 Offset: 0x1FAF971 VA: 0x1FAF870 Slot: 40
	protected override void Update() { }

	// RVA: 0x1FAFA40 Offset: 0x1FAFB41 VA: 0x1FAFA40
	public void .ctor() { }

	// RVA: 0x1FAFB30 Offset: 0x1FAFC31 VA: 0x1FAFB30
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4840 Offset: 0x1A4941 VA: 0x1A4840
	// RVA: 0x1FAFBF0 Offset: 0x1FAFCF1 VA: 0x1FAFBF0
	private void <OnSetModelObject>b__57_0(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4850 Offset: 0x1A4951 VA: 0x1A4850
	// RVA: 0x1FAFCD0 Offset: 0x1FAFDD1 VA: 0x1FAFCD0
	private void <OnSetModelObject>b__57_1(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4860 Offset: 0x1A4961 VA: 0x1A4860
	// RVA: 0x1FAFD90 Offset: 0x1FAFE91 VA: 0x1FAFD90
	private void <OnSetModelObject>b__57_2(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4870 Offset: 0x1A4971 VA: 0x1A4870
	// RVA: 0x1FAFE50 Offset: 0x1FAFF51 VA: 0x1FAFE50
	private void <OnSetModelObject>b__57_3(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4880 Offset: 0x1A4981 VA: 0x1A4880
	// RVA: 0x1FAFF50 Offset: 0x1FB0051 VA: 0x1FAFF50
	private void <OnUniqueActionCommandInternal>b__75_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4890 Offset: 0x1A4991 VA: 0x1A4890
	// RVA: 0x1FAFF90 Offset: 0x1FB0091 VA: 0x1FAFF90
	private void <OnUniqueActionCommandInternal>b__75_1() { }
}

