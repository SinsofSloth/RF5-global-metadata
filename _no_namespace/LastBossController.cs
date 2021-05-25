public class LastBossController : BossMonsterContoroller // TypeDefIndex: 7934
{
	// Fields
	private const float SCALE_2M = 0.1;
	private const float SCALE_6M = 0.3;
	private const float SCALE_10M = 0.5;
	private const float SCALE_15M = 0.75;
	private const float SCALE_20M = 1;
	private const float SCALE_40M = 2;
	private static readonly string[] BonePointNames; // 0x0
	private static readonly Vector3[] LocalPosition; // 0x8
	private const float ARRIVED_LENGTH = 3;
	private const float WARP_FADE_TIME = 0.5;
	private static readonly string[] BONE_MATERIAL_NAMES; // 0x10
	private const float BONE_FADE_MIN = 0.001;
	private static readonly Vector3 PUNCH_VEC; // 0x18
	private const float PUNCH_SEC = 0.1;
	private const string MADNESS_ADV_SCRIPT_NAME = "boss_lastboss_002";
	private const string EMISSION_COLOR = "_EmissionColor";
	public float EMISSION_FADEINOUT_SPEED; // 0x510
	public float EMISSION_LOOP_SPEED; // 0x514
	private float EMISSION_LOOP_ALPHA_MIN_RATIO; // 0x518
	private float EMISSION_FLASHING_SPEED; // 0x51C
	public float CircleCount; // 0x520
	public float CircleDir; // 0x524
	public float CircleLength; // 0x528
	[CompilerGeneratedAttribute] // RVA: 0x169E00 Offset: 0x169F01 VA: 0x169E00
	private DN18BossStageManager <DN18BossStageManager>k__BackingField; // 0x530
	private Transform SuctionColliderTransform; // 0x538
	private bool IsSuction; // 0x540
	private float SuctionPower; // 0x544
	private float SuctionMaxRange; // 0x548
	private float SuctionMinRange; // 0x54C
	private Transform[] BonePoints; // 0x550
	private Transform Attack4Points; // 0x558
	private List<ParticleSystem> Attack4EffectList; // 0x560
	private static readonly string[] ATTACK4EFFECTLIST; // 0x28
	private bool IsRestaintBodyFadeIn; // 0x568
	private bool IsBoneDrop; // 0x569
	private MonsterControllerBase.FadeType BoneFadeType; // 0x56C
	private List<Material> BoneMaterialList; // 0x570
	private float BoneFadeTimer; // 0x578
	private float BoneFadeDuration; // 0x57C
	private LastBossBone PrefabLastBossBone; // 0x580
	private List<LastBossBone> LastBossBoneList; // 0x588
	private string ASReleaseName; // 0x590
	private List<Color> DefaultEmissionColors; // 0x598
	private float EmissionAlphaTimer; // 0x5A0
	private LastBossController.EmissionState _EmissionState; // 0x5A4

	// Properties
	public DN18BossStageManager DN18BossStageManager { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A4710 Offset: 0x1A4811 VA: 0x1A4710
	// RVA: 0x2186970 Offset: 0x2186A71 VA: 0x2186970
	public DN18BossStageManager get_DN18BossStageManager() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4720 Offset: 0x1A4821 VA: 0x1A4720
	// RVA: 0x2186980 Offset: 0x2186A81 VA: 0x2186980
	private void set_DN18BossStageManager(DN18BossStageManager value) { }

	// RVA: 0x2186990 Offset: 0x2186A91 VA: 0x2186990 Slot: 107
	public override bool IsCanRestraint() { }

	// RVA: 0x21869E0 Offset: 0x2186AE1 VA: 0x21869E0 Slot: 158
	public override void CreateMadnessEffect(ParticleSystem prefab, List<string> boneNameList, float scaleValue) { }

	// RVA: 0x2186B40 Offset: 0x2186C41 VA: 0x2186B40 Slot: 12
	protected override void Start() { }

	// RVA: 0x2186C00 Offset: 0x2186D01 VA: 0x2186C00 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x2186C30 Offset: 0x2186D31 VA: 0x2186C30 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x2187520 Offset: 0x2187621 VA: 0x2187520 Slot: 40
	protected override void Update() { }

	// RVA: 0x2187A90 Offset: 0x2187B91 VA: 0x2187A90
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x2187FE0 Offset: 0x21880E1 VA: 0x2187FE0 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x2188000 Offset: 0x2188101 VA: 0x2188000 Slot: 139
	public override void OnRelease() { }

	// RVA: 0x2188070 Offset: 0x2188171 VA: 0x2188070
	private void UpdateSuction() { }

	// RVA: 0x2187A60 Offset: 0x2187B61 VA: 0x2187A60
	private void UpdateBone() { }

	// RVA: 0x2188320 Offset: 0x2188421 VA: 0x2188320
	private void UpdateBonePointRotation() { }

	// RVA: 0x2188650 Offset: 0x2188751 VA: 0x2188650
	private void UpdateFadeBone() { }

	// RVA: 0x2187230 Offset: 0x2187331 VA: 0x2187230
	private void SetupEmission() { }

	// RVA: 0x2188A70 Offset: 0x2188B71 VA: 0x2188A70
	private void OnEmission() { }

	// RVA: 0x2188B00 Offset: 0x2188C01 VA: 0x2188B00
	private void OnFlashing() { }

	// RVA: 0x2188B90 Offset: 0x2188C91 VA: 0x2188B90
	private void OffEmission() { }

	// RVA: 0x2187650 Offset: 0x2187751 VA: 0x2187650
	private void UpdateEmission() { }

	// RVA: 0x2188BA0 Offset: 0x2188CA1 VA: 0x2188BA0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x2189950 Offset: 0x2189A51 VA: 0x2189950
	public void .ctor() { }

	// RVA: 0x2189AB0 Offset: 0x2189BB1 VA: 0x2189AB0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4730 Offset: 0x1A4831 VA: 0x1A4730
	// RVA: 0x218A510 Offset: 0x218A611 VA: 0x218A510
	private void <OnUniqueActionCommandInternal>b__67_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4740 Offset: 0x1A4841 VA: 0x1A4740
	// RVA: 0x218A7D0 Offset: 0x218A8D1 VA: 0x218A7D0
	private void <OnUniqueActionCommandInternal>b__67_1() { }
}

