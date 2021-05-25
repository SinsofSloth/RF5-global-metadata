public class HasibirokouController : BossMonsterContoroller // TypeDefIndex: 7881
{
	// Fields
	private static readonly Vector3 RAY_POS_OFFSET; // 0x0
	[SerializeField] // RVA: 0x169D10 Offset: 0x169E11 VA: 0x169D10
	private Transform LaserPointTransform; // 0x510
	[SerializeField] // RVA: 0x169D20 Offset: 0x169E21 VA: 0x169D20
	private Transform[] BulletPointTransforms; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x169D30 Offset: 0x169E31 VA: 0x169D30
	private List<HasibirokouSonicWind> <HasibirokouSonicWinds>k__BackingField; // 0x520
	private float SonicWindSweepSpeed; // 0x528

	// Properties
	public List<HasibirokouSonicWind> HasibirokouSonicWinds { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A3CE0 Offset: 0x1A3DE1 VA: 0x1A3CE0
	// RVA: 0x22FB4F0 Offset: 0x22FB5F1 VA: 0x22FB4F0
	public List<HasibirokouSonicWind> get_HasibirokouSonicWinds() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3CF0 Offset: 0x1A3DF1 VA: 0x1A3CF0
	// RVA: 0x22FB500 Offset: 0x22FB601 VA: 0x22FB500
	private void set_HasibirokouSonicWinds(List<HasibirokouSonicWind> value) { }

	// RVA: 0x22FB510 Offset: 0x22FB611 VA: 0x22FB510 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x22FB5D0 Offset: 0x22FB6D1 VA: 0x22FB5D0
	private void CreateProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x22FB950 Offset: 0x22FBA51 VA: 0x22FB950
	private void UpdateBulletPointRotation() { }

	// RVA: 0x22FBB50 Offset: 0x22FBC51 VA: 0x22FBB50
	private float GetAngleX(Transform transform, float min, float max) { }

	// RVA: 0x22FBD00 Offset: 0x22FBE01 VA: 0x22FBD00 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x22FC4F0 Offset: 0x22FC5F1 VA: 0x22FC4F0 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x22FC910 Offset: 0x22FCA11 VA: 0x22FC910 Slot: 40
	protected override void Update() { }

	// RVA: 0x22FC9B0 Offset: 0x22FCAB1 VA: 0x22FC9B0
	public void .ctor() { }

	// RVA: 0x22FCA30 Offset: 0x22FCB31 VA: 0x22FCA30
	private static void .cctor() { }
}

