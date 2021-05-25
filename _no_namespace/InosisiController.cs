public class InosisiController : BossMonsterContoroller // TypeDefIndex: 7891
{
	// Fields
	private static readonly Vector3 RAY_ORIGIN_POS_OFFSET; // 0x0
	private float rayPow; // 0x510
	public bool IsVariation; // 0x514
	private readonly List<string> ThornsNameList; // 0x518
	private const string SearchPointName = "SearchPoint";
	private List<InosisiController.ThornsController> ThornsControllerList; // 0x520
	private InosisiController.Dash dashState; // 0x528
	private bool IsHitCharacter; // 0x52C
	private bool IsRotate; // 0x52D
	private Vector3 RotateDirection; // 0x530
	private bool IsRolling; // 0x53C
	private float RollingAngle; // 0x540
	private bool IsRayCheck; // 0x544
	private Transform SearchPos; // 0x548
	private Vector3 MeteorPos; // 0x550
	[SerializeField] // RVA: 0x169D40 Offset: 0x169E41 VA: 0x169D40
	private GameObject RockObject; // 0x560
	[SerializeField] // RVA: 0x169D50 Offset: 0x169E51 VA: 0x169D50
	private GameObject Thorn1Object; // 0x568
	[SerializeField] // RVA: 0x169D60 Offset: 0x169E61 VA: 0x169D60
	private GameObject Thorn2Object; // 0x570
	[SerializeField] // RVA: 0x169D70 Offset: 0x169E71 VA: 0x169D70
	private GameObject MeteorObject; // 0x578

	// Methods

	// RVA: 0x20C8CF0 Offset: 0x20C8DF1 VA: 0x20C8CF0
	private void SetupThorns() { }

	// RVA: 0x20C8F70 Offset: 0x20C9071 VA: 0x20C8F70
	private void PressThorns(int idx) { }

	// RVA: 0x20C9000 Offset: 0x20C9101 VA: 0x20C9000
	private void UpdateThorns() { }

	// RVA: 0x20C9290 Offset: 0x20C9391 VA: 0x20C9290
	public void SetIsHitCharacter(bool isHitCharacter) { }

	// RVA: 0x20C92A0 Offset: 0x20C93A1 VA: 0x20C92A0
	private bool WallRayCast(Vector3 direction) { }

	// RVA: 0x20C9470 Offset: 0x20C9571 VA: 0x20C9470
	private bool CharaRayCast(Vector3 direction) { }

	// RVA: 0x20C96B0 Offset: 0x20C97B1 VA: 0x20C96B0
	private bool FloorRayCast() { }

	// RVA: 0x20C97F0 Offset: 0x20C98F1 VA: 0x20C97F0 Slot: 12
	protected override void Start() { }

	// RVA: 0x20C9880 Offset: 0x20C9981 VA: 0x20C9880 Slot: 40
	protected override void Update() { }

	// RVA: 0x20C9F50 Offset: 0x20CA051 VA: 0x20C9F50
	private void CreateProjectileRock(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x20CA3C0 Offset: 0x20CA4C1 VA: 0x20CA3C0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x20CA4C0 Offset: 0x20CA5C1 VA: 0x20CA4C0 Slot: 118
	protected override void OnResetActionScriptAction() { }

	// RVA: 0x20CA4F0 Offset: 0x20CA5F1 VA: 0x20CA4F0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x20CA250 Offset: 0x20CA351 VA: 0x20CA250
	private float GetGroundPos(Vector3 pos) { }

	// RVA: 0x20CA810 Offset: 0x20CA911 VA: 0x20CA810
	public void .ctor() { }

	// RVA: 0x20CA9B0 Offset: 0x20CAAB1 VA: 0x20CA9B0
	private static void .cctor() { }
}

