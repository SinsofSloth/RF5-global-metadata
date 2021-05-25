public class GansekiDragonController : BossMonsterContoroller // TypeDefIndex: 7863
{
	// Fields
	private const float RAY_DISTANCE_OFFSET = 1;
	private static readonly Vector3 RAY_ORIGIN_POS_OFFSET; // 0x0
	private const float SMOKE_TIME = 1.2;
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x169C10 Offset: 0x169D11 VA: 0x169C10
	private GameObject <MimicryModel>k__BackingField; // 0x510
	private int MimicryModelId; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x169C20 Offset: 0x169D21 VA: 0x169C20
	private bool <IsMimicry>k__BackingField; // 0x51C
	private bool IsForceReleased; // 0x51D
	private float ForceReleasedTimer; // 0x520
	private bool IsSmoke; // 0x524
	private float SmokeTimer; // 0x528
	private Transform JawEndTrans; // 0x530
	private GameObject RockPrefab; // 0x538
	private MonsterProjectileActionScriptsController[] Rocks; // 0x540
	private Transform FlyRockPoints; // 0x548
	private GansekiDragonController.RushType _RushType; // 0x550
	private bool IsRushHit; // 0x554
	private float RushRotateSpeed; // 0x558
	private bool IsRayCheck; // 0x55C
	[CompilerGeneratedAttribute] // RVA: 0x169C30 Offset: 0x169D31 VA: 0x169C30
	private float <DefenceLayerDamageRate>k__BackingField; // 0x560
	[CompilerGeneratedAttribute] // RVA: 0x169C40 Offset: 0x169D41 VA: 0x169C40
	private float <ForceReleaseDamageRate>k__BackingField; // 0x564
	[CompilerGeneratedAttribute] // RVA: 0x169C50 Offset: 0x169D51 VA: 0x169C50
	private float <ForceReleaseDamageRateTime>k__BackingField; // 0x568
	public AnimationCurve JumpAnimationCurve; // 0x570
	private ParticleSystem JumpPointEffect; // 0x578

	// Properties
	public GameObject MimicryModel { get; set; }
	public bool IsMimicry { get; set; }
	public float DefenceLayerDamageRate { get; set; }
	public float ForceReleaseDamageRate { get; set; }
	public float ForceReleaseDamageRateTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A38F0 Offset: 0x1A39F1 VA: 0x1A38F0
	// RVA: 0x1E3D0C0 Offset: 0x1E3D1C1 VA: 0x1E3D0C0
	public GameObject get_MimicryModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3900 Offset: 0x1A3A01 VA: 0x1A3900
	// RVA: 0x1E3D0D0 Offset: 0x1E3D1D1 VA: 0x1E3D0D0
	public void set_MimicryModel(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3910 Offset: 0x1A3A11 VA: 0x1A3910
	// RVA: 0x1E3D0E0 Offset: 0x1E3D1E1 VA: 0x1E3D0E0
	public bool get_IsMimicry() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3920 Offset: 0x1A3A21 VA: 0x1A3920
	// RVA: 0x1E3D0F0 Offset: 0x1E3D1F1 VA: 0x1E3D0F0
	private void set_IsMimicry(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3930 Offset: 0x1A3A31 VA: 0x1A3930
	// RVA: 0x1E3D100 Offset: 0x1E3D201 VA: 0x1E3D100
	public float get_DefenceLayerDamageRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3940 Offset: 0x1A3A41 VA: 0x1A3940
	// RVA: 0x1E3D110 Offset: 0x1E3D211 VA: 0x1E3D110
	public void set_DefenceLayerDamageRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3950 Offset: 0x1A3A51 VA: 0x1A3950
	// RVA: 0x1E3D120 Offset: 0x1E3D221 VA: 0x1E3D120
	public float get_ForceReleaseDamageRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3960 Offset: 0x1A3A61 VA: 0x1A3960
	// RVA: 0x1E3D130 Offset: 0x1E3D231 VA: 0x1E3D130
	public void set_ForceReleaseDamageRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3970 Offset: 0x1A3A71 VA: 0x1A3970
	// RVA: 0x1E3D140 Offset: 0x1E3D241 VA: 0x1E3D140
	public float get_ForceReleaseDamageRateTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3980 Offset: 0x1A3A81 VA: 0x1A3980
	// RVA: 0x1E3D150 Offset: 0x1E3D251 VA: 0x1E3D150
	public void set_ForceReleaseDamageRateTime(float value) { }

	// RVA: 0x1E3D160 Offset: 0x1E3D261 VA: 0x1E3D160 Slot: 155
	protected override bool CanReciveItem() { }

	// RVA: 0x1E3D180 Offset: 0x1E3D281 VA: 0x1E3D180 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1E3D2A0 Offset: 0x1E3D3A1 VA: 0x1E3D2A0 Slot: 12
	protected override void Start() { }

	// RVA: 0x1E3D350 Offset: 0x1E3D451 VA: 0x1E3D350 Slot: 130
	protected override void OnSetup() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A3990 Offset: 0x1A3A91 VA: 0x1A3990
	// RVA: 0x1E3D550 Offset: 0x1E3D651 VA: 0x1E3D550 Slot: 131
	protected override IEnumerator OnSetupAsync() { }

	// RVA: 0x1E3D600 Offset: 0x1E3D701 VA: 0x1E3D600 Slot: 40
	protected override void Update() { }

	// RVA: 0x1E3DCB0 Offset: 0x1E3DDB1 VA: 0x1E3DCB0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1E3E040 Offset: 0x1E3E141 VA: 0x1E3E040 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x1E3E160 Offset: 0x1E3E261 VA: 0x1E3E160 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x1E3E1A0 Offset: 0x1E3E2A1 VA: 0x1E3E1A0
	private void OnHitEvent(CharacterBase _, int __) { }

	// RVA: 0x1E3E1C0 Offset: 0x1E3E2C1 VA: 0x1E3E1C0
	private void OnEndActionScript() { }

	// RVA: 0x1E3E1D0 Offset: 0x1E3E2D1 VA: 0x1E3E1D0
	public void ReSetProjectile() { }

	// RVA: 0x1E3E1E0 Offset: 0x1E3E2E1 VA: 0x1E3E1E0
	private void CreateProjectileRock(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1E3C0E0 Offset: 0x1E3C1E1 VA: 0x1E3C0E0
	public void Shake(float _duration, float _strength) { }

	// RVA: 0x1E3E410 Offset: 0x1E3E511 VA: 0x1E3E410
	public void Punch(float _duration, Vector3 _punch) { }

	// RVA: 0x1E3DAD0 Offset: 0x1E3DBD1 VA: 0x1E3DAD0
	private void UpdateForceReleasedTimer() { }

	// RVA: 0x1E3E490 Offset: 0x1E3E591 VA: 0x1E3E490
	private void NormalToMimicry() { }

	// RVA: 0x1E3E0D0 Offset: 0x1E3E1D1 VA: 0x1E3E0D0
	private void MimicryToNormal() { }

	// RVA: 0x1E3C540 Offset: 0x1E3C641 VA: 0x1E3C540
	public void OnForceMimicryRelease() { }

	// RVA: 0x1E3E5A0 Offset: 0x1E3E6A1 VA: 0x1E3E5A0
	private bool WallRayCast(Vector3 direction) { }

	// RVA: 0x1E3D700 Offset: 0x1E3D801 VA: 0x1E3D700
	private void UpdateMimicryRush() { }

	// RVA: 0x1E3E7D0 Offset: 0x1E3E8D1 VA: 0x1E3E7D0
	private void HitWall() { }

	// RVA: 0x1E3DB50 Offset: 0x1E3DC51 VA: 0x1E3DB50
	public void UpdateSmoke() { }

	// RVA: 0x1E3E890 Offset: 0x1E3E991 VA: 0x1E3E890
	public void SmokeOn() { }

	// RVA: 0x1E3E190 Offset: 0x1E3E291 VA: 0x1E3E190
	public void SmokeOff() { }

	// RVA: 0x1E3DD80 Offset: 0x1E3DE81 VA: 0x1E3DD80
	public void DefenceLayerEffect(bool isBreak, Vector3 hitPos) { }

	// RVA: 0x1E3E9D0 Offset: 0x1E3EAD1 VA: 0x1E3E9D0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1E3F450 Offset: 0x1E3F551 VA: 0x1E3F450
	public void .ctor() { }

	// RVA: 0x1E3F500 Offset: 0x1E3F601 VA: 0x1E3F500
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3A00 Offset: 0x1A3B01 VA: 0x1A3A00
	// RVA: 0x1E3F5C0 Offset: 0x1E3F6C1 VA: 0x1E3F5C0
	private void <Start>b__42_0(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3A10 Offset: 0x1A3B11 VA: 0x1A3A10
	// RVA: 0x1E3F770 Offset: 0x1E3F871 VA: 0x1E3F770
	private void <OnUniqueActionCommandInternal>b__66_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3A20 Offset: 0x1A3B21 VA: 0x1A3A20
	// RVA: 0x1E3F7F0 Offset: 0x1E3F8F1 VA: 0x1E3F7F0
	private void <OnUniqueActionCommandInternal>b__66_0() { }
}

