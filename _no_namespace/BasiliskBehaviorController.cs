public class BasiliskBehaviorController : BossBehaviorController // TypeDefIndex: 7812
{
	// Fields
	private const float StageCenterRange = 10;
	private Vector3 StageCenterPosition; // 0x1C8

	// Methods

	// RVA: 0x215D590 Offset: 0x215D691 VA: 0x215D590
	private TaskStatus CheckTargetInRange_Update() { }

	// RVA: 0x215D5A0 Offset: 0x215D6A1 VA: 0x215D5A0
	private MonsterBehaviorController.BehaviorActionParam CreateForwardMoveAction() { }

	// RVA: 0x215D6C0 Offset: 0x215D7C1 VA: 0x215D6C0
	private MonsterBehaviorController.BehaviorActionParam CreateLeftMoveAction() { }

	// RVA: 0x215D820 Offset: 0x215D921 VA: 0x215D820
	private MonsterBehaviorController.BehaviorActionParam CreateRightMoveAction() { }

	// RVA: 0x215D980 Offset: 0x215DA81 VA: 0x215D980
	private MonsterBehaviorController.BehaviorActionParam CreateFallBackAction() { }

	// RVA: 0x215DAD0 Offset: 0x215DBD1 VA: 0x215DAD0
	private MonsterBehaviorController.BehaviorActionParam CreateBite11AttackAction() { }

	// RVA: 0x215DBD0 Offset: 0x215DCD1 VA: 0x215DBD0
	private MonsterBehaviorController.BehaviorActionParam CreateBite12AttackAction() { }

	// RVA: 0x215DCD0 Offset: 0x215DDD1 VA: 0x215DCD0
	private MonsterBehaviorController.BehaviorActionParam CreateMoveBiteAttackAction() { }

	// RVA: 0x215DDD0 Offset: 0x215DED1 VA: 0x215DDD0
	private MonsterBehaviorController.BehaviorActionParam CreateRotation2AttackAction() { }

	// RVA: 0x215DED0 Offset: 0x215DFD1 VA: 0x215DED0
	private MonsterBehaviorController.BehaviorActionParam CreateRotation3AttackAction() { }

	// RVA: 0x215DFD0 Offset: 0x215E0D1 VA: 0x215DFD0
	private MonsterBehaviorController.BehaviorActionParam CreateFireShotAction() { }

	// RVA: 0x215E0D0 Offset: 0x215E1D1 VA: 0x215E0D0
	private MonsterBehaviorController.BehaviorActionParam CreateFireShotMultiAction() { }

	// RVA: 0x215E1D0 Offset: 0x215E2D1 VA: 0x215E1D0
	private MonsterBehaviorController.BehaviorActionParam CreateNapalmAction() { }

	// RVA: 0x215E2D0 Offset: 0x215E3D1 VA: 0x215E2D0
	private MonsterBehaviorController.BehaviorActionParam CreateFireShotOldMultiAction() { }

	// RVA: 0x215E3D0 Offset: 0x215E4D1 VA: 0x215E3D0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x215E630 Offset: 0x215E731 VA: 0x215E630 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x215E670 Offset: 0x215E771 VA: 0x215E670 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x215E6B0 Offset: 0x215E7B1 VA: 0x215E6B0 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x215E880 Offset: 0x215E981 VA: 0x215E880 Slot: 65
	public override void OnEndActionScript() { }

	// RVA: 0x215E890 Offset: 0x215E991 VA: 0x215E890
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2FA0 Offset: 0x1A30A1 VA: 0x1A2FA0
	// RVA: 0x215E910 Offset: 0x215EA11 VA: 0x215E910
	private void <CreateForwardMoveAction>b__3_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2FB0 Offset: 0x1A30B1 VA: 0x1A2FB0
	// RVA: 0x215EBC0 Offset: 0x215ECC1 VA: 0x215EBC0
	private void <CreateLeftMoveAction>b__4_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2FC0 Offset: 0x1A30C1 VA: 0x1A2FC0
	// RVA: 0x215EC20 Offset: 0x215ED21 VA: 0x215EC20
	private void <CreateLeftMoveAction>b__4_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2FD0 Offset: 0x1A30D1 VA: 0x1A2FD0
	// RVA: 0x215EE40 Offset: 0x215EF41 VA: 0x215EE40
	private void <CreateRightMoveAction>b__5_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2FE0 Offset: 0x1A30E1 VA: 0x1A2FE0
	// RVA: 0x215EEA0 Offset: 0x215EFA1 VA: 0x215EEA0
	private void <CreateRightMoveAction>b__5_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2FF0 Offset: 0x1A30F1 VA: 0x1A2FF0
	// RVA: 0x215F0C0 Offset: 0x215F1C1 VA: 0x215F0C0
	private void <CreateFallBackAction>b__6_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3000 Offset: 0x1A3101 VA: 0x1A3000
	// RVA: 0x215F120 Offset: 0x215F221 VA: 0x215F120
	private void <CreateFallBackAction>b__6_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3010 Offset: 0x1A3111 VA: 0x1A3010
	// RVA: 0x215F410 Offset: 0x215F511 VA: 0x215F410
	private void <CreateBite11AttackAction>b__7_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3020 Offset: 0x1A3121 VA: 0x1A3020
	// RVA: 0x215F460 Offset: 0x215F561 VA: 0x215F460
	private void <CreateBite12AttackAction>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3030 Offset: 0x1A3131 VA: 0x1A3030
	// RVA: 0x215F4B0 Offset: 0x215F5B1 VA: 0x215F4B0
	private void <CreateMoveBiteAttackAction>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3040 Offset: 0x1A3141 VA: 0x1A3040
	// RVA: 0x215F500 Offset: 0x215F601 VA: 0x215F500
	private void <CreateRotation2AttackAction>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3050 Offset: 0x1A3151 VA: 0x1A3050
	// RVA: 0x215F550 Offset: 0x215F651 VA: 0x215F550
	private void <CreateRotation3AttackAction>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3060 Offset: 0x1A3161 VA: 0x1A3060
	// RVA: 0x215F5A0 Offset: 0x215F6A1 VA: 0x215F5A0
	private void <CreateFireShotAction>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3070 Offset: 0x1A3171 VA: 0x1A3070
	// RVA: 0x215F5F0 Offset: 0x215F6F1 VA: 0x215F5F0
	private void <CreateFireShotMultiAction>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3080 Offset: 0x1A3181 VA: 0x1A3080
	// RVA: 0x215F640 Offset: 0x215F741 VA: 0x215F640
	private void <CreateNapalmAction>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3090 Offset: 0x1A3191 VA: 0x1A3090
	// RVA: 0x215F690 Offset: 0x215F791 VA: 0x215F690
	private void <CreateFireShotOldMultiAction>b__15_0() { }
}

