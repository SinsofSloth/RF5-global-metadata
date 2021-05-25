public class YadokariController : BossMonsterContoroller // TypeDefIndex: 7996
{
	// Fields
	private const float ShellRange = 5;
	private const float ThrowShellSpeed = 20;
	private const float ThrowShellPower = 8;
	private static readonly Vector3 Range_Effect_Scale; // 0x0
	private static readonly Vector3 Range_Effect_Scale_Ball; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x169ED0 Offset: 0x169FD1 VA: 0x169ED0
	private float <ShellDamageBonusRate>k__BackingField; // 0x510
	public AnimationCurve JumpAnimationCurve; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x169EE0 Offset: 0x169FE1 VA: 0x169EE0
	private YadokariShellController <YadokariShellController>k__BackingField; // 0x520
	[CompilerGeneratedAttribute] // RVA: 0x169EF0 Offset: 0x169FF1 VA: 0x169EF0
	private int <ThrowShellCount>k__BackingField; // 0x528
	[CompilerGeneratedAttribute] // RVA: 0x169F00 Offset: 0x16A001 VA: 0x169F00
	private int <RestraintThrowShellTCount>k__BackingField; // 0x52C
	public bool IsRolling; // 0x530
	public float RollingAngle; // 0x534
	public bool IsRestraint; // 0x538
	public int WaveCount; // 0x53C
	public int SafeWaveCount; // 0x540
	private ParticleSystem RangeEffect; // 0x548
	public bool IsRangeSearch; // 0x550
	public bool IsShellThrowRange; // 0x551
	public Vector3 RangePos; // 0x554

	// Properties
	public float ShellDamageBonusRate { get; set; }
	public YadokariShellController YadokariShellController { get; set; }
	public bool IsThrowShell { get; }
	public int ThrowShellCount { get; set; }
	public int RestraintThrowShellTCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A5000 Offset: 0x1A5101 VA: 0x1A5000
	// RVA: 0x26A0720 Offset: 0x26A0821 VA: 0x26A0720
	public float get_ShellDamageBonusRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5010 Offset: 0x1A5111 VA: 0x1A5010
	// RVA: 0x26A0730 Offset: 0x26A0831 VA: 0x26A0730
	public void set_ShellDamageBonusRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5020 Offset: 0x1A5121 VA: 0x1A5020
	// RVA: 0x26A0740 Offset: 0x26A0841 VA: 0x26A0740
	public YadokariShellController get_YadokariShellController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5030 Offset: 0x1A5131 VA: 0x1A5030
	// RVA: 0x26A0750 Offset: 0x26A0851 VA: 0x26A0750
	private void set_YadokariShellController(YadokariShellController value) { }

	// RVA: 0x26A0440 Offset: 0x26A0541 VA: 0x26A0440
	public bool get_IsThrowShell() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5040 Offset: 0x1A5141 VA: 0x1A5040
	// RVA: 0x26A0760 Offset: 0x26A0861 VA: 0x26A0760
	public int get_ThrowShellCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5050 Offset: 0x1A5151 VA: 0x1A5050
	// RVA: 0x26A0770 Offset: 0x26A0871 VA: 0x26A0770
	public void set_ThrowShellCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5060 Offset: 0x1A5161 VA: 0x1A5060
	// RVA: 0x26A0780 Offset: 0x26A0881 VA: 0x26A0780
	public int get_RestraintThrowShellTCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5070 Offset: 0x1A5171 VA: 0x1A5070
	// RVA: 0x26A0790 Offset: 0x26A0891 VA: 0x26A0790
	public void set_RestraintThrowShellTCount(int value) { }

	// RVA: 0x26A07A0 Offset: 0x26A08A1 VA: 0x26A07A0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x26A08C0 Offset: 0x26A09C1 VA: 0x26A08C0 Slot: 12
	protected override void Start() { }

	// RVA: 0x26A08D0 Offset: 0x26A09D1 VA: 0x26A08D0 Slot: 40
	protected override void Update() { }

	// RVA: 0x26A0960 Offset: 0x26A0A61 VA: 0x26A0960
	private void RollingUpdate() { }

	// RVA: 0x26A0C10 Offset: 0x26A0D11 VA: 0x26A0C10
	private void CreateProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x26A0E20 Offset: 0x26A0F21 VA: 0x26A0E20 Slot: 129
	protected override void OnSetModelObject(GameObject model) { }

	// RVA: 0x26A0EA0 Offset: 0x26A0FA1 VA: 0x26A0EA0 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x26A0EE0 Offset: 0x26A0FE1 VA: 0x26A0EE0 Slot: 143
	public override void OnFinishDeadEvent() { }

	// RVA: 0x26A10E0 Offset: 0x26A11E1 VA: 0x26A10E0
	public bool CheckBack() { }

	// RVA: 0x26A1250 Offset: 0x26A1351 VA: 0x26A1250
	public void SetRestraint(bool restraint) { }

	// RVA: 0x26A1260 Offset: 0x26A1361 VA: 0x26A1260 Slot: 54
	protected override float GetMoveSpeedMax() { }

	// RVA: 0x26A09D0 Offset: 0x26A0AD1 VA: 0x26A09D0
	protected void RangeEffectUpdate() { }

	// RVA: 0x26A12A0 Offset: 0x26A13A1 VA: 0x26A12A0
	public void SetRangeDisplay(bool play) { }

	// RVA: 0x26A12D0 Offset: 0x26A13D1 VA: 0x26A12D0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x26A1FF0 Offset: 0x26A20F1 VA: 0x26A1FF0
	public void .ctor() { }

	// RVA: 0x26A2070 Offset: 0x26A2171 VA: 0x26A2070
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5080 Offset: 0x1A5181 VA: 0x1A5080
	// RVA: 0x26A2140 Offset: 0x26A2241 VA: 0x26A2140
	private void <OnSetup>b__33_0(ParticleSystem particle) { }
}

