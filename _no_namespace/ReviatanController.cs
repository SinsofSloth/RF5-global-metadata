public class ReviatanController : BossMonsterContoroller // TypeDefIndex: 7963
{
	// Fields
	private Transform MoveCursor; // 0x510
	private Transform CursorTransform; // 0x518
	private float SeekSpeed; // 0x520
	private bool IsSeek; // 0x524
	private int GeyserCounter; // 0x528
	private int GeyserPlusRound; // 0x52C
	private int GeyserRoundMax; // 0x530
	private int PlusGeyserCount; // 0x534
	private Vector3 BlurOffset; // 0x538
	private Transform HeadTransform; // 0x548
	private Transform BulletPoint; // 0x550
	private GameObject IcePillarPrefab; // 0x558
	public List<ReviatanIcePillar> IcePillarList; // 0x560
	[CompilerGeneratedAttribute] // RVA: 0x169E40 Offset: 0x169F41 VA: 0x169E40
	private int <MaxIcePillarCount>k__BackingField; // 0x568
	private Vector3 PosOffset; // 0x56C
	private Vector3 RotOffset; // 0x578
	private Vector3 IcePillarScale; // 0x584
	private bool IsTsunami; // 0x590
	private bool IsSky; // 0x591
	private Transform TsunamiTransform; // 0x598
	private Quaternion TsunamiDirection; // 0x5A0
	private static readonly Vector3 LOCKONOFFSET; // 0x0

	// Properties
	public int MaxIcePillarCount { get; set; }
	public override Vector3 GetTakeLockonPos { get; }

	// Methods

	// RVA: 0x232E9F0 Offset: 0x232EAF1 VA: 0x232E9F0 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x232EA40 Offset: 0x232EB41 VA: 0x232EA40 Slot: 107
	public override bool IsCanRestraint() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4B10 Offset: 0x1A4C11 VA: 0x1A4B10
	// RVA: 0x232EA90 Offset: 0x232EB91 VA: 0x232EA90
	public int get_MaxIcePillarCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4B20 Offset: 0x1A4C21 VA: 0x1A4B20
	// RVA: 0x232EAA0 Offset: 0x232EBA1 VA: 0x232EAA0
	public void set_MaxIcePillarCount(int value) { }

	// RVA: 0x232EAB0 Offset: 0x232EBB1 VA: 0x232EAB0 Slot: 10
	public override Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x232EB90 Offset: 0x232EC91 VA: 0x232EB90 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x232ECD0 Offset: 0x232EDD1 VA: 0x232ECD0 Slot: 130
	protected override void OnSetup() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A4B30 Offset: 0x1A4C31 VA: 0x1A4B30
	// RVA: 0x232EEB0 Offset: 0x232EFB1 VA: 0x232EEB0 Slot: 131
	protected override IEnumerator OnSetupAsync() { }

	// RVA: 0x232EF60 Offset: 0x232F061 VA: 0x232EF60 Slot: 40
	protected override void Update() { }

	// RVA: 0x232F380 Offset: 0x232F481 VA: 0x232F380 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x232F680 Offset: 0x232F781 VA: 0x232F680
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x232EFD0 Offset: 0x232F0D1 VA: 0x232EFD0
	private void CursorUpdate() { }

	// RVA: 0x232F190 Offset: 0x232F291 VA: 0x232F190
	private void BulletPointRotateUpdate() { }

	// RVA: 0x232F340 Offset: 0x232F441 VA: 0x232F340
	private void TsunamiPointsRotateUpdate() { }

	// RVA: 0x232F930 Offset: 0x232FA31 VA: 0x232F930 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x2330100 Offset: 0x2330201 VA: 0x2330100 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x2330620 Offset: 0x2330721 VA: 0x2330620
	public void .ctor() { }

	// RVA: 0x2330760 Offset: 0x2330861 VA: 0x2330760
	private static void .cctor() { }
}

