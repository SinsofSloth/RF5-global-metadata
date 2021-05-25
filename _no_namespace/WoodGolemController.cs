public class WoodGolemController : BossMonsterContoroller // TypeDefIndex: 7986
{
	// Fields
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE; // 0x0
	private Vector3 JumpPosition; // 0x510
	private ParticleSystem JumpPointEffect; // 0x520
	[CompilerGeneratedAttribute] // RVA: 0x169EA0 Offset: 0x169FA1 VA: 0x169EA0
	private bool <IsLostRightArm>k__BackingField; // 0x528
	[CompilerGeneratedAttribute] // RVA: 0x169EB0 Offset: 0x169FB1 VA: 0x169EB0
	private bool <IsLostBothArm>k__BackingField; // 0x529
	private GameObject ModelLeftArm; // 0x530
	private GameObject ModelRightArm; // 0x538
	private GameObject LeftRocketPunchPrefab; // 0x540
	private GameObject RightRocketPunchPrefab; // 0x548
	private WoodGolemRocketPunchController RocketPunch; // 0x550
	private const float ROCKET_PUNCH_ROTATE_SPEED = 720;
	private int LaserCount; // 0x558
	private int MaxLaser; // 0x55C
	private SkinnedMeshRenderer SkinnedMeshRenderer; // 0x560
	[SerializeField] // RVA: 0x169EC0 Offset: 0x169FC1 VA: 0x169EC0
	private Material OffMaterial; // 0x568
	private Material DefaultMaterial; // 0x570

	// Properties
	public bool IsLostRightArm { get; set; }
	public bool IsLostBothArm { get; set; }

	// Methods

	// RVA: 0x1D0A280 Offset: 0x1D0A381 VA: 0x1D0A280 Slot: 107
	public override bool IsCanRestraint() { }

	// RVA: 0x1D0A2D0 Offset: 0x1D0A3D1 VA: 0x1D0A2D0 Slot: 12
	protected override void Start() { }

	// RVA: 0x1D0A380 Offset: 0x1D0A481 VA: 0x1D0A380 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1D0A460 Offset: 0x1D0A561 VA: 0x1D0A460
	private void SetJumpPoint() { }

	// RVA: 0x1D0A5B0 Offset: 0x1D0A6B1 VA: 0x1D0A5B0
	private void EraseJumpPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F00 Offset: 0x1A5001 VA: 0x1A4F00
	// RVA: 0x1D0A5E0 Offset: 0x1D0A6E1 VA: 0x1D0A5E0
	public bool get_IsLostRightArm() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F10 Offset: 0x1A5011 VA: 0x1A4F10
	// RVA: 0x1D0A5F0 Offset: 0x1D0A6F1 VA: 0x1D0A5F0
	private void set_IsLostRightArm(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F20 Offset: 0x1A5021 VA: 0x1A4F20
	// RVA: 0x1D0A600 Offset: 0x1D0A701 VA: 0x1D0A600
	public bool get_IsLostBothArm() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F30 Offset: 0x1A5031 VA: 0x1A4F30
	// RVA: 0x1D0A610 Offset: 0x1D0A711 VA: 0x1D0A610
	private void set_IsLostBothArm(bool value) { }

	// RVA: 0x1D0A620 Offset: 0x1D0A721 VA: 0x1D0A620 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x1D0A810 Offset: 0x1D0A911 VA: 0x1D0A810 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x1D0A880 Offset: 0x1D0A981 VA: 0x1D0A880 Slot: 69
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1D0A930 Offset: 0x1D0AA31 VA: 0x1D0A930
	private void CreateProjectileAddList(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1D0AB80 Offset: 0x1D0AC81 VA: 0x1D0AB80
	private void GrowArm() { }

	// RVA: 0x1D0A900 Offset: 0x1D0AA01 VA: 0x1D0A900
	public void SwitchOn() { }

	// RVA: 0x1D0A850 Offset: 0x1D0A951 VA: 0x1D0A850
	public void SwitchOff() { }

	// RVA: 0x1D0AC50 Offset: 0x1D0AD51 VA: 0x1D0AC50 Slot: 21
	public override void OnEvent(int index) { }

	// RVA: 0x1D0AC90 Offset: 0x1D0AD91 VA: 0x1D0AC90 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1D0B0B0 Offset: 0x1D0B1B1 VA: 0x1D0B0B0
	public void .ctor() { }

	// RVA: 0x1D0B0C0 Offset: 0x1D0B1C1 VA: 0x1D0B0C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F40 Offset: 0x1A5041 VA: 0x1A4F40
	// RVA: 0x1D0B150 Offset: 0x1D0B251 VA: 0x1D0B150
	private void <Start>b__4_0(ParticleSystem particle) { }
}

