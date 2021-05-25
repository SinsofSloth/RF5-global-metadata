public class HarinezumiController : BossMonsterContoroller // TypeDefIndex: 7874
{
	// Fields
	private const float NavmeshEdgeHitRange = 3;
	private const float ReflectionTargetCorrection = 0.15;
	private const float EscapeRange = 10;
	private SkinnedMeshRenderer _NeedleSkinnedMeshRenderer; // 0x510
	private GameObject TogeGameObject; // 0x518
	private MaterialPropertyBlock MaterialPropertyBlock; // 0x520
	private Tweener FadeTweener; // 0x528
	private bool IsActiveNeedle; // 0x530
	private bool IsReflectionNavmeshEdge; // 0x531
	private NavMeshHit NavMeshHit; // 0x534
	private MonsterControllerBase.FadeType _NeedleFadeType; // 0x558
	private DamageInfo NeedleDamageInfo; // 0x560
	private Dictionary<int, HarinezumiController.NeedleController> NeedleEnableTimeSequenceDic; // 0x5E0
	[CompilerGeneratedAttribute] // RVA: 0x169D00 Offset: 0x169E01 VA: 0x169D00
	private bool <Needle>k__BackingField; // 0x5E8
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE; // 0x0
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE_VAR; // 0xC
	private Vector3 JumpPosition; // 0x5EC
	private ParticleSystem JumpPointEffect; // 0x5F8
	private bool IsDive; // 0x600
	private float DiveSpeed; // 0x604
	private bool CanLockon; // 0x608
	private HarinezumiController.Laser LaserState; // 0x60C

	// Properties
	private SkinnedMeshRenderer NeedleSkinnedMeshRenderer { get; }
	private MonsterControllerBase.FadeType NeedleFadeType { get; set; }
	public bool ExistNeedle { get; }
	public bool Needle { get; set; }

	// Methods

	// RVA: 0x22F6730 Offset: 0x22F6831 VA: 0x22F6730
	private SkinnedMeshRenderer get_NeedleSkinnedMeshRenderer() { }

	// RVA: 0x22F6820 Offset: 0x22F6921 VA: 0x22F6820
	private MonsterControllerBase.FadeType get_NeedleFadeType() { }

	// RVA: 0x22F6830 Offset: 0x22F6931 VA: 0x22F6830
	private void set_NeedleFadeType(MonsterControllerBase.FadeType value) { }

	// RVA: 0x22F6AE0 Offset: 0x22F6BE1 VA: 0x22F6AE0
	public bool get_ExistNeedle() { }

	// RVA: 0x22F6850 Offset: 0x22F6951 VA: 0x22F6850
	private void SetEnableNeedleColliderList(bool enable) { }

	// RVA: 0x22F6AF0 Offset: 0x22F6BF1 VA: 0x22F6AF0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x22F70E0 Offset: 0x22F71E1 VA: 0x22F70E0
	public void SetDOTweenNeedle(bool isDisplay, float fadeTime) { }

	// RVA: 0x22F6BB0 Offset: 0x22F6CB1 VA: 0x22F6BB0
	public void SetupNeedle() { }

	// RVA: 0x22F73C0 Offset: 0x22F74C1 VA: 0x22F73C0 Slot: 111
	public override void SetStatusController(MonsterStatusBase statusController) { }

	// RVA: 0x22F6020 Offset: 0x22F6121 VA: 0x22F6020
	public void StartFadeNeedle(MonsterControllerBase.FadeType fadeType, float fadeTime = 0.5) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B50 Offset: 0x1A3C51 VA: 0x1A3B50
	// RVA: 0x22F7530 Offset: 0x22F7631 VA: 0x22F7530
	public bool get_Needle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B60 Offset: 0x1A3C61 VA: 0x1A3B60
	// RVA: 0x22F7540 Offset: 0x22F7641 VA: 0x22F7540
	private void set_Needle(bool value) { }

	// RVA: 0x22F7550 Offset: 0x22F7651 VA: 0x22F7550
	private void DisplayNeedle(bool isDisplay, float fadeTime) { }

	// RVA: 0x22F75F0 Offset: 0x22F76F1 VA: 0x22F75F0
	public void OnHitAttack(CharacterBase characterBase, Collider attackCollider, Vector3 hitPosition) { }

	// RVA: 0x22F7E40 Offset: 0x22F7F41 VA: 0x22F7E40 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x22F86B0 Offset: 0x22F87B1 VA: 0x22F86B0 Slot: 118
	protected override void OnResetActionScriptAction() { }

	// RVA: 0x22F86E0 Offset: 0x22F87E1 VA: 0x22F86E0
	private void UpdateNavmeshReflection() { }

	// RVA: 0x22F8940 Offset: 0x22F8A41 VA: 0x22F8940 Slot: 40
	protected override void Update() { }

	// RVA: 0x22F8AA0 Offset: 0x22F8BA1 VA: 0x22F8AA0 Slot: 12
	protected override void Start() { }

	// RVA: 0x22F8B50 Offset: 0x22F8C51 VA: 0x22F8B50 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x22F8360 Offset: 0x22F8461 VA: 0x22F8360
	private void SetJumpPoint() { }

	// RVA: 0x22F8540 Offset: 0x22F8641 VA: 0x22F8540
	private void EraseJumpPoint() { }

	// RVA: 0x22F8570 Offset: 0x22F8671 VA: 0x22F8570
	private void Dive(float speed) { }

	// RVA: 0x22F85E0 Offset: 0x22F86E1 VA: 0x22F85E0
	private void ReleaseLockon() { }

	// RVA: 0x22F85F0 Offset: 0x22F86F1 VA: 0x22F85F0
	private void StartJumpAttack(float jumpPower, float duration) { }

	// RVA: 0x22F8C30 Offset: 0x22F8D31 VA: 0x22F8C30 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x22F8690 Offset: 0x22F8791 VA: 0x22F8690
	private void StartLaser() { }

	// RVA: 0x22F86A0 Offset: 0x22F87A1 VA: 0x22F86A0
	private void EndLaser() { }

	// RVA: 0x22F8A80 Offset: 0x22F8B81 VA: 0x22F8A80
	private void UpdateLaser() { }

	// RVA: 0x22F8C80 Offset: 0x22F8D81 VA: 0x22F8C80 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x22F8CC0 Offset: 0x22F8DC1 VA: 0x22F8CC0 Slot: 133
	protected override void OnEndAnimEventGetupState() { }

	// RVA: 0x22F8D10 Offset: 0x22F8E11 VA: 0x22F8D10
	public void .ctor() { }

	// RVA: 0x22F8DB0 Offset: 0x22F8EB1 VA: 0x22F8DB0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B70 Offset: 0x1A3C71 VA: 0x1A3B70
	// RVA: 0x22F8E80 Offset: 0x22F8F81 VA: 0x22F8E80
	private float <SetDOTweenNeedle>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B80 Offset: 0x1A3C81 VA: 0x1A3B80
	// RVA: 0x22F8EE0 Offset: 0x22F8FE1 VA: 0x22F8EE0
	private void <SetDOTweenNeedle>b__23_1(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B90 Offset: 0x1A3C91 VA: 0x1A3B90
	// RVA: 0x22F8F70 Offset: 0x22F9071 VA: 0x22F8F70
	private void <SetDOTweenNeedle>b__23_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3BA0 Offset: 0x1A3CA1 VA: 0x1A3BA0
	// RVA: 0x22F8F90 Offset: 0x22F9091 VA: 0x22F8F90
	private void <SetDOTweenNeedle>b__23_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3BB0 Offset: 0x1A3CB1 VA: 0x1A3BB0
	// RVA: 0x22F9010 Offset: 0x22F9111 VA: 0x22F9010
	private float <SetDOTweenNeedle>b__23_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3BC0 Offset: 0x1A3CC1 VA: 0x1A3BC0
	// RVA: 0x22F9070 Offset: 0x22F9171 VA: 0x22F9070
	private void <SetDOTweenNeedle>b__23_5(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3BD0 Offset: 0x1A3CD1 VA: 0x1A3BD0
	// RVA: 0x22F9100 Offset: 0x22F9201 VA: 0x22F9100
	private void <SetDOTweenNeedle>b__23_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3BE0 Offset: 0x1A3CE1 VA: 0x1A3BE0
	// RVA: 0x22F9120 Offset: 0x22F9221 VA: 0x22F9120
	private void <SetDOTweenNeedle>b__23_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3BF0 Offset: 0x1A3CF1 VA: 0x1A3BF0
	// RVA: 0x22F9170 Offset: 0x22F9271 VA: 0x22F9170
	private void <OnUniqueActionCommandInternal>b__33_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3C00 Offset: 0x1A3D01 VA: 0x1A3C00
	// RVA: 0x22F91A0 Offset: 0x22F92A1 VA: 0x22F91A0
	private void <Start>b__44_0(ParticleSystem particle) { }
}

