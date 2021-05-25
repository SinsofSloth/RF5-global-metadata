public class CerberusController : BossMonsterContoroller // TypeDefIndex: 7830
{
	// Fields
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE; // 0x0
	[SerializeField] // RVA: 0x169B30 Offset: 0x169C31 VA: 0x169B30
	private List<AttackCollider> DogAttackColliderList; // 0x510
	private bool IsSplitAttack; // 0x518
	public bool IsOpossum; // 0x519
	public bool IsEndOpossumAnimation; // 0x51A
	private readonly List<MonsterModelDataID> DogDataIDs; // 0x520
	private List<CerberusController.DogParam> Dogs; // 0x528
	private Vector3 SplitAttackStartPosition; // 0x530
	private Vector3 EndPosition; // 0x53C
	private ParticleSystem JumpPointEffect; // 0x548

	// Methods

	// RVA: 0x1D3D110 Offset: 0x1D3D211 VA: 0x1D3D110 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x1D3D170 Offset: 0x1D3D271 VA: 0x1D3D170
	private void StartSplitAttack() { }

	// RVA: 0x1D3D3F0 Offset: 0x1D3D4F1 VA: 0x1D3D3F0
	private void EndSplitAttack() { }

	// RVA: 0x1D3D570 Offset: 0x1D3D671 VA: 0x1D3D570
	private void SetJumpPoint() { }

	// RVA: 0x1D3D6C0 Offset: 0x1D3D7C1 VA: 0x1D3D6C0
	private void EraseJumpPoint() { }

	// RVA: 0x1D3D6F0 Offset: 0x1D3D7F1 VA: 0x1D3D6F0
	private void DogsFall() { }

	// RVA: 0x1D3DDA0 Offset: 0x1D3DEA1 VA: 0x1D3DDA0
	private void DogRunTween(CerberusController.DogParam dog) { }

	// RVA: 0x1D3DF40 Offset: 0x1D3E041 VA: 0x1D3DF40 Slot: 111
	public override void SetStatusController(MonsterStatusBase statusController) { }

	// RVA: 0x1D3E100 Offset: 0x1D3E201 VA: 0x1D3E100 Slot: 12
	protected override void Start() { }

	// RVA: 0x1D3E1B0 Offset: 0x1D3E2B1 VA: 0x1D3E1B0 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1D3E320 Offset: 0x1D3E421 VA: 0x1D3E320 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1D3E5E0 Offset: 0x1D3E6E1 VA: 0x1D3E5E0 Slot: 142
	public override void StartActionScript(int actionIndex) { }

	// RVA: 0x1D3E5F0 Offset: 0x1D3E6F1 VA: 0x1D3E5F0 Slot: 25
	public override void OnEvent(int index, bool param) { }

	// RVA: 0x1D3E610 Offset: 0x1D3E711 VA: 0x1D3E610 Slot: 40
	protected override void Update() { }

	// RVA: 0x1D3E620 Offset: 0x1D3E721 VA: 0x1D3E620
	public void .ctor() { }

	// RVA: 0x1D3E720 Offset: 0x1D3E821 VA: 0x1D3E720
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A31F0 Offset: 0x1A32F1 VA: 0x1A31F0
	// RVA: 0x1D3E7B0 Offset: 0x1D3E8B1 VA: 0x1D3E7B0
	private void <StartSplitAttack>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3200 Offset: 0x1A3301 VA: 0x1A3200
	// RVA: 0x1D3E7D0 Offset: 0x1D3E8D1 VA: 0x1D3E7D0
	private void <EndSplitAttack>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3210 Offset: 0x1A3311 VA: 0x1A3210
	// RVA: 0x1D3E840 Offset: 0x1D3E941 VA: 0x1D3E840
	private void <SetStatusController>b__18_0(MonsterModelDataID id, GameObject monster) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3220 Offset: 0x1A3321 VA: 0x1A3220
	// RVA: 0x1D3E960 Offset: 0x1D3EA61 VA: 0x1D3E960
	private void <Start>b__19_0(ParticleSystem particle) { }
}

