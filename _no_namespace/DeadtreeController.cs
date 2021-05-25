public class DeadtreeController : BossMonsterContoroller // TypeDefIndex: 7839
{
	// Fields
	private readonly List<string> ChestnutNameList; // 0x510
	private List<DeadtreeController.ChestnutController> ChestnutControllerList; // 0x518
	[SerializeField] // RVA: 0x169B40 Offset: 0x169C41 VA: 0x169B40
	private RuntimeAnimatorController InGroundRuntimeAnimatorController; // 0x520
	[SerializeField] // RVA: 0x169B50 Offset: 0x169C51 VA: 0x169B50
	private RuntimeAnimatorController RuntimeAnimatorController; // 0x528
	private bool IsDisplayBurr; // 0x530
	public float DisplayTimer; // 0x534
	public bool IsMashHeal; // 0x538
	private const string MushPointName = "MashRoomPos";
	private const string BaseMushName = "MushroomBase";
	private DeadtreeController.MashController MashPoint; // 0x540
	private DeadtreeController.MashController BaseMashPoint; // 0x548
	public float jumpCount; // 0x550
	public Vector3 JumpPos; // 0x554
	public bool JumpSearch; // 0x560
	private ParticleSystem JumpPointEffect; // 0x568
	public bool RangeSearch; // 0x570

	// Properties
	public bool ExistBurr { get; }

	// Methods

	// RVA: 0x1CE5550 Offset: 0x1CE5651 VA: 0x1CE5550
	public bool get_ExistBurr() { }

	// RVA: 0x1CE3FA0 Offset: 0x1CE40A1 VA: 0x1CE3FA0
	public void ChangeRuntimeAnimator(bool isInGround) { }

	// RVA: 0x1CE5560 Offset: 0x1CE5661 VA: 0x1CE5560
	public void SetupChestnut() { }

	// RVA: 0x1CE2E20 Offset: 0x1CE2F21 VA: 0x1CE2E20
	public void SetDisplayChestnut(bool isDisplay) { }

	// RVA: 0x1CE5910 Offset: 0x1CE5A11 VA: 0x1CE5910
	public void SetDisplayMash(bool isDisplay) { }

	// RVA: 0x1CE59F0 Offset: 0x1CE5AF1 VA: 0x1CE59F0
	public void SetHeal(bool isHeal) { }

	// RVA: 0x1CE5A00 Offset: 0x1CE5B01 VA: 0x1CE5A00
	public void SetJumpCount(bool set, float jump) { }

	// RVA: 0x1CE5A30 Offset: 0x1CE5B31 VA: 0x1CE5A30 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x1CE5C50 Offset: 0x1CE5D51 VA: 0x1CE5C50 Slot: 40
	protected override void Update() { }

	// RVA: 0x1CE5DC0 Offset: 0x1CE5EC1 VA: 0x1CE5DC0 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1CE5EE0 Offset: 0x1CE5FE1 VA: 0x1CE5EE0
	public void SetMuteki(bool isflag) { }

	// RVA: 0x1CE5F20 Offset: 0x1CE6021 VA: 0x1CE5F20
	public void SetRangeEffect(bool play) { }

	// RVA: 0x1CE5F50 Offset: 0x1CE6051 VA: 0x1CE5F50 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1CE4550 Offset: 0x1CE4651 VA: 0x1CE4550
	public bool JumpCheck() { }

	// RVA: 0x1CE6250 Offset: 0x1CE6351 VA: 0x1CE6250
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1CE6400 Offset: 0x1CE6501 VA: 0x1CE6400
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A32F0 Offset: 0x1A33F1 VA: 0x1A32F0
	// RVA: 0x1CE6580 Offset: 0x1CE6681 VA: 0x1CE6580
	private void <OnSetup>b__26_0(ParticleSystem particle) { }
}

