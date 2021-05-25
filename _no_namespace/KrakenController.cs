public class KrakenController : BossMonsterContoroller // TypeDefIndex: 7908
{
	// Fields
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE; // 0x0
	private const float EARTHQUAKE_SCALE = 5;
	private Vector3 StartPosition; // 0x510
	private Vector3 EndPosition; // 0x51C
	private const int MaxLeg = 4;
	private List<KrakenStickController> KrakenStickList; // 0x528
	private KrakenStickController Bluefeet; // 0x530
	private KrakenStickController Yellowfeet; // 0x538
	private int StickOutCounter; // 0x540
	private int MaxStickOut; // 0x544
	private bool IsDive; // 0x548
	private SkinnedMeshRenderer ModelSkinnedMeshRenderer; // 0x550
	public List<Transform> RandomPosList; // 0x558
	public List<Transform> SpawnPosList; // 0x560
	private ParticleSystem JumpPointEffect; // 0x568
	private Tween RotateTween; // 0x570

	// Methods

	// RVA: 0x209A5C0 Offset: 0x209A6C1 VA: 0x209A5C0 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x209A610 Offset: 0x209A711 VA: 0x209A610 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x209A6F0 Offset: 0x209A7F1 VA: 0x209A6F0 Slot: 12
	protected override void Start() { }

	// RVA: 0x209AA20 Offset: 0x209AB21 VA: 0x209AA20 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x209AAE0 Offset: 0x209ABE1 VA: 0x209AAE0 Slot: 129
	protected override void OnSetModelObject(GameObject model) { }

	// RVA: 0x209AB70 Offset: 0x209AC71 VA: 0x209AB70 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x209ADB0 Offset: 0x209AEB1 VA: 0x209ADB0 Slot: 47
	protected override void SetLocomotion(float value) { }

	// RVA: 0x209AE80 Offset: 0x209AF81 VA: 0x209AE80
	private void AttackJump(float height, float duration) { }

	// RVA: 0x209AFB0 Offset: 0x209B0B1 VA: 0x209AFB0
	private void LeaveJump(float height, float duration) { }

	// RVA: 0x209B210 Offset: 0x209B311 VA: 0x209B210
	private void CreateProjectile(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, int attackIndex) { }

	// RVA: 0x209B320 Offset: 0x209B421 VA: 0x209B320
	private void CheckTiltStickOut(string nextAction, string endAction) { }

	// RVA: 0x209B400 Offset: 0x209B501 VA: 0x209B400 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x209BB20 Offset: 0x209BC21 VA: 0x209BB20 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x209BE70 Offset: 0x209BF71 VA: 0x209BE70
	public void .ctor() { }

	// RVA: 0x209BF50 Offset: 0x209C051 VA: 0x209BF50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4330 Offset: 0x1A4431 VA: 0x1A4330
	// RVA: 0x209BFE0 Offset: 0x209C0E1 VA: 0x209BFE0
	private void <Start>b__18_0(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4340 Offset: 0x1A4441 VA: 0x1A4340
	// RVA: 0x209C110 Offset: 0x209C211 VA: 0x209C110
	private void <AttackJump>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4350 Offset: 0x1A4451 VA: 0x1A4350
	// RVA: 0x209C140 Offset: 0x209C241 VA: 0x209C140
	private void <LeaveJump>b__24_0() { }
}

