public class GandageController : BossMonsterContoroller // TypeDefIndex: 7852
{
	// Fields
	private const float TakeBehindRange = 2;
	private const float EscapeRange = 5;
	private const string MADNESS_ADV_SCRIPT_NAME = "boss_gandage_002";
	private Transform WeaponTransform; // 0x510
	[SerializeField] // RVA: 0x169B90 Offset: 0x169C91 VA: 0x169B90
	private GandageHandController R_OpenHandController; // 0x518
	[SerializeField] // RVA: 0x169BA0 Offset: 0x169CA1 VA: 0x169BA0
	private GandageHandController L_OpenHandController; // 0x520
	[SerializeField] // RVA: 0x169BB0 Offset: 0x169CB1 VA: 0x169BB0
	private GandageHandController R_FistController; // 0x528
	[SerializeField] // RVA: 0x169BC0 Offset: 0x169CC1 VA: 0x169BC0
	private GandageHandController L_FistController; // 0x530
	[SerializeField] // RVA: 0x169BD0 Offset: 0x169CD1 VA: 0x169BD0
	private RuntimeAnimatorController AnimatorController; // 0x538
	[SerializeField] // RVA: 0x169BE0 Offset: 0x169CE1 VA: 0x169BE0
	private RuntimeAnimatorController MadnessAnimatorController; // 0x540
	private DN17BossStageInterface BossStage; // 0x548
	private bool IsHitAttack; // 0x550
	private bool CheckHitAttackNext; // 0x551
	private bool[] SelectCrackAreaArray; // 0x558
	[CompilerGeneratedAttribute] // RVA: 0x169BF0 Offset: 0x169CF1 VA: 0x169BF0
	private bool <CanRestraint>k__BackingField; // 0x560
	private readonly Vector3 FlyswatterStartPosition; // 0x564
	private readonly Vector3 FlyswatterWaitPosition; // 0x570
	private readonly Vector3 FlyswatterAttackPosition; // 0x57C
	private readonly Vector3 UpperDownStartPosition; // 0x588
	private readonly Vector3 UpperDownWaitPosition; // 0x594
	private readonly Vector3 UpperDownAttack01Position; // 0x5A0
	private readonly Vector3 UpperDownAttack02Position; // 0x5AC
	private readonly Vector3 Beatup_R1_StartPosition; // 0x5B8
	private readonly Vector3 Beatup_R1_EndPosition; // 0x5C4
	private readonly Vector3 Beatup_R2_StartPosition; // 0x5D0
	private readonly Vector3 Beatup_R2_EndPosition; // 0x5DC
	private readonly Vector3 Beatup_L1_StartPosition; // 0x5E8
	private readonly Vector3 Beatup_L1_EndPosition; // 0x5F4
	private readonly Vector3 Beatup_L2_StartPosition; // 0x600
	private readonly Vector3 Beatup_L2_EndPosition; // 0x60C
	private Tweener JumpAttack; // 0x618
	private Vector3 GroundPosition; // 0x620

	// Properties
	public bool CanRestraint { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A3650 Offset: 0x1A3751 VA: 0x1A3650
	// RVA: 0x1E34BA0 Offset: 0x1E34CA1 VA: 0x1E34BA0
	public bool get_CanRestraint() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3660 Offset: 0x1A3761 VA: 0x1A3660
	// RVA: 0x1E34BB0 Offset: 0x1E34CB1 VA: 0x1E34BB0
	private void set_CanRestraint(bool value) { }

	// RVA: 0x1E34BC0 Offset: 0x1E34CC1 VA: 0x1E34BC0
	private Vector3[] GetWaypointStartFlyswatter() { }

	// RVA: 0x1E34D30 Offset: 0x1E34E31 VA: 0x1E34D30
	private Vector3[] GetWaypointAttackFlyswatter() { }

	// RVA: 0x1E34EA0 Offset: 0x1E34FA1 VA: 0x1E34EA0
	private Vector3[] GetWaypointStartUpperDown() { }

	// RVA: 0x1E35010 Offset: 0x1E35111 VA: 0x1E35010
	private Vector3[] GetWaypointAttackUpperDown() { }

	// RVA: 0x1E352C0 Offset: 0x1E353C1 VA: 0x1E352C0
	private Vector3[] GetWaypointBeatup_R1() { }

	// RVA: 0x1E35450 Offset: 0x1E35551 VA: 0x1E35450
	private Vector3[] GetWaypointBeatup_R2() { }

	// RVA: 0x1E355E0 Offset: 0x1E356E1 VA: 0x1E355E0
	private Vector3[] GetWaypointBeatup_L1() { }

	// RVA: 0x1E35760 Offset: 0x1E35861 VA: 0x1E35760
	private Vector3[] GetWaypointBeatup_L2() { }

	// RVA: 0x1E358F0 Offset: 0x1E359F1 VA: 0x1E358F0
	private void ResetCrackAreaFlag() { }

	// RVA: 0x1E35960 Offset: 0x1E35A61 VA: 0x1E35960
	private GandageController.CrackArea SelectCrackArea() { }

	// RVA: 0x1E35B50 Offset: 0x1E35C51 VA: 0x1E35B50
	private float GetDurationTargetPosition(Vector3 targetPosition, float speed) { }

	// RVA: 0x1E35C60 Offset: 0x1E35D61 VA: 0x1E35C60
	private void PlayJumpTween(float jumpHeight, float duration) { }

	// RVA: 0x1E35DD0 Offset: 0x1E35ED1 VA: 0x1E35DD0
	private void PlayMoveTargetTween(float speed) { }

	// RVA: 0x1E360C0 Offset: 0x1E361C1 VA: 0x1E360C0
	public void ChangeRuntimeAnimator(bool isMadness) { }

	// RVA: 0x1E36120 Offset: 0x1E36221 VA: 0x1E36120
	public void SetBossStage(DN17BossStageInterface bossStage) { }

	// RVA: 0x1E36130 Offset: 0x1E36231 VA: 0x1E36130 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x1E361C0 Offset: 0x1E362C1 VA: 0x1E361C0 Slot: 140
	protected override void OnHit(CharacterBase characterBase, int actionIndex) { }

	// RVA: 0x1E36230 Offset: 0x1E36331 VA: 0x1E36230 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1E37980 Offset: 0x1E37A81 VA: 0x1E37980 Slot: 118
	protected override void OnResetActionScriptAction() { }

	// RVA: 0x1E379B0 Offset: 0x1E37AB1 VA: 0x1E379B0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1E37A70 Offset: 0x1E37B71 VA: 0x1E37A70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3670 Offset: 0x1A3771 VA: 0x1A3670
	// RVA: 0x1E37EB0 Offset: 0x1E37FB1 VA: 0x1E37EB0
	private void <PlayMoveTargetTween>b__48_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3680 Offset: 0x1A3781 VA: 0x1A3680
	// RVA: 0x1E37EF0 Offset: 0x1E37FF1 VA: 0x1E37EF0
	private void <OnUniqueActionCommandInternal>b__53_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3690 Offset: 0x1A3791 VA: 0x1A3690
	// RVA: 0x1E38080 Offset: 0x1E38181 VA: 0x1E38080
	private void <OnUniqueActionCommandInternal>b__53_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A36A0 Offset: 0x1A37A1 VA: 0x1A36A0
	// RVA: 0x1E38170 Offset: 0x1E38271 VA: 0x1E38170
	private void <OnUniqueActionCommandInternal>b__53_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A36B0 Offset: 0x1A37B1 VA: 0x1A36B0
	// RVA: 0x1E38230 Offset: 0x1E38331 VA: 0x1E38230
	private void <OnUniqueActionCommandInternal>b__53_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A36C0 Offset: 0x1A37C1 VA: 0x1A36C0
	// RVA: 0x1E382F0 Offset: 0x1E383F1 VA: 0x1E382F0
	private void <OnUniqueActionCommandInternal>b__53_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A36D0 Offset: 0x1A37D1 VA: 0x1A36D0
	// RVA: 0x1E38390 Offset: 0x1E38491 VA: 0x1E38390
	private void <OnUniqueActionCommandInternal>b__53_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A36E0 Offset: 0x1A37E1 VA: 0x1A36E0
	// RVA: 0x1E38430 Offset: 0x1E38531 VA: 0x1E38430
	private void <OnUniqueActionCommandInternal>b__53_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A36F0 Offset: 0x1A37F1 VA: 0x1A36F0
	// RVA: 0x1E384E0 Offset: 0x1E385E1 VA: 0x1E384E0
	private void <OnUniqueActionCommandInternal>b__53_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3700 Offset: 0x1A3801 VA: 0x1A3700
	// RVA: 0x1E38520 Offset: 0x1E38621 VA: 0x1E38520
	private void <OnUniqueActionCommandInternal>b__53_8() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3710 Offset: 0x1A3811 VA: 0x1A3710
	// RVA: 0x1E38560 Offset: 0x1E38661 VA: 0x1E38560
	private void <OnUniqueActionCommandInternal>b__53_9() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3720 Offset: 0x1A3821 VA: 0x1A3720
	// RVA: 0x1E385A0 Offset: 0x1E386A1 VA: 0x1E385A0
	private void <OnUniqueActionCommandInternal>b__53_10() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3730 Offset: 0x1A3831 VA: 0x1A3730
	// RVA: 0x1E385D0 Offset: 0x1E386D1 VA: 0x1E385D0
	private void <OnUniqueActionCommandInternal>b__53_11() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3740 Offset: 0x1A3841 VA: 0x1A3740
	// RVA: 0x1E38600 Offset: 0x1E38701 VA: 0x1E38600
	private void <OnUniqueActionCommandInternal>b__53_12() { }
}

