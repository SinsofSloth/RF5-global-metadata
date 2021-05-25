public class AudmuraController : BossMonsterContoroller // TypeDefIndex: 7802
{
	// Fields
	private const string EMISSION_COLOR = "_EmissionColor";
	private static readonly Vector3 RAY_POS_OFFSET; // 0x0
	private AudmuraCrystal CrystalObj; // 0x510
	private List<AudmuraCrystal> AudmuraCrystalList; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x169A40 Offset: 0x169B41 VA: 0x169A40
	private int <CrystalHP>k__BackingField; // 0x520
	[HeaderAttribute] // RVA: 0x169A50 Offset: 0x169B51 VA: 0x169A50
	public float FadeInOutTime; // 0x524
	public float LoopSpeed; // 0x528
	[RangeAttribute] // RVA: 0x169A90 Offset: 0x169B91 VA: 0x169A90
	public float LoopRatio; // 0x52C
	private AudmuraController.EmissionState _EmissionState; // 0x530
	private Material BodyMaterial; // 0x538
	private Color DefaultEmissionColor; // 0x540
	private float EmissionAlphaTimer; // 0x550

	// Properties
	public int CrystalHP { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2EA0 Offset: 0x1A2FA1 VA: 0x1A2EA0
	// RVA: 0x228BAA0 Offset: 0x228BBA1 VA: 0x228BAA0
	public int get_CrystalHP() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2EB0 Offset: 0x1A2FB1 VA: 0x1A2EB0
	// RVA: 0x228BAB0 Offset: 0x228BBB1 VA: 0x228BAB0
	public void set_CrystalHP(int value) { }

	// RVA: 0x228BAC0 Offset: 0x228BBC1 VA: 0x228BAC0 Slot: 107
	public override bool IsCanRestraint() { }

	// RVA: 0x228BB10 Offset: 0x228BC11 VA: 0x228BB10 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x228BBD0 Offset: 0x228BCD1 VA: 0x228BBD0 Slot: 130
	protected override void OnSetup() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2EC0 Offset: 0x1A2FC1 VA: 0x1A2EC0
	// RVA: 0x228BD70 Offset: 0x228BE71 VA: 0x228BD70 Slot: 131
	protected override IEnumerator OnSetupAsync() { }

	// RVA: 0x228BDF0 Offset: 0x228BEF1 VA: 0x228BDF0 Slot: 40
	protected override void Update() { }

	// RVA: 0x228C110 Offset: 0x228C211 VA: 0x228C110
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x228C740 Offset: 0x228C841 VA: 0x228C740 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x228C960 Offset: 0x228CA61 VA: 0x228C960
	private void OnEmission() { }

	// RVA: 0x228C950 Offset: 0x228CA51 VA: 0x228C950
	private void OffEmission() { }

	// RVA: 0x228BE90 Offset: 0x228BF91 VA: 0x228BE90
	private void EmissionUpdate() { }

	// RVA: 0x228C5F0 Offset: 0x228C6F1 VA: 0x228C5F0
	public Vector3 GetLaserNextPos() { }

	// RVA: 0x228C970 Offset: 0x228CA71 VA: 0x228C970 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x228CF30 Offset: 0x228D031 VA: 0x228CF30 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x228D2A0 Offset: 0x228D3A1 VA: 0x228D2A0
	public void .ctor() { }

	// RVA: 0x228D340 Offset: 0x228D441 VA: 0x228D340
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F30 Offset: 0x1A3031 VA: 0x1A2F30
	// RVA: 0x228D3D0 Offset: 0x228D4D1 VA: 0x228D3D0
	private bool <CreateProjectileEvent>b__21_1(NavMeshHit hit) { }
}

