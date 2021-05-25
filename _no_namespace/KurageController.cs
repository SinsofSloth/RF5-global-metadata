public class KurageController : BossMonsterContoroller // TypeDefIndex: 7919
{
	// Fields
	private static readonly Vector3 RAY_POS_OFFSET; // 0x0
	private const float EscapeRange = 10;
	private const float CloseRange = 3;
	[HideInInspector] // RVA: 0x169DF0 Offset: 0x169EF1 VA: 0x169DF0
	public bool IsMadnessCharge; // 0x510
	public bool IsElectroCharge; // 0x511
	private const string ChargePointName_1 = "ElectroCharge_Effect";
	private const string ChargePointName_2 = "ElectroCharge_Effect_Head";
	private KurageController.EffectPointController ChargePoint_1; // 0x518
	private KurageController.EffectPointController ChargePoint_2; // 0x520
	public float LightningCount; // 0x528
	private List<MonsterProjectileActionScriptsController> BulletList; // 0x530

	// Methods

	// RVA: 0x209EFD0 Offset: 0x209F0D1 VA: 0x209EFD0 Slot: 12
	protected override void Start() { }

	// RVA: 0x209EFE0 Offset: 0x209F0E1 VA: 0x209EFE0 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x209EFF0 Offset: 0x209F0F1 VA: 0x209EFF0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x209F1B0 Offset: 0x209F2B1 VA: 0x209F1B0 Slot: 40
	protected override void Update() { }

	// RVA: 0x209DB80 Offset: 0x209DC81 VA: 0x209DB80
	public void SetDisplayCharge(bool isDisplay) { }

	// RVA: 0x209F1C0 Offset: 0x209F2C1 VA: 0x209F1C0
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x209FBD0 Offset: 0x209FCD1 VA: 0x209FBD0 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x209FC70 Offset: 0x209FD71 VA: 0x209FC70 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x209FE00 Offset: 0x209FF01 VA: 0x209FE00
	private void JumpProc(float range, float jumpPower, float duration) { }

	// RVA: 0x20A0160 Offset: 0x20A0261 VA: 0x20A0160 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x20A0290 Offset: 0x20A0391 VA: 0x20A0290 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x209FA60 Offset: 0x209FB61 VA: 0x209FA60
	private float GetGroundPos(Vector3 pos) { }

	// RVA: 0x20A02A0 Offset: 0x20A03A1 VA: 0x20A02A0
	public void .ctor() { }

	// RVA: 0x20A0330 Offset: 0x20A0431 VA: 0x20A0330
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4410 Offset: 0x1A4511 VA: 0x1A4410
	// RVA: 0x20A03C0 Offset: 0x20A04C1 VA: 0x20A03C0
	private void <JumpProc>b__20_0() { }
}

