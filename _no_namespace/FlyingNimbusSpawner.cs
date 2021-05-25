[ExecuteInEditMode] // RVA: 0x146680 Offset: 0x146781 VA: 0x146680
public class FlyingNimbusSpawner : GimmickBase // TypeDefIndex: 7558
{
	// Fields
	[SerializeField] // RVA: 0x167260 Offset: 0x167361 VA: 0x167260
	private Prefab _CloudID; // 0x20
	[SerializeField] // RVA: 0x167270 Offset: 0x167371 VA: 0x167270
	[HeaderAttribute] // RVA: 0x167270 Offset: 0x167371 VA: 0x167270
	private Vector3[] SplineLength; // 0x28
	[SerializeField] // RVA: 0x1672C0 Offset: 0x1673C1 VA: 0x1672C0
	[HeaderAttribute] // RVA: 0x1672C0 Offset: 0x1673C1 VA: 0x1672C0
	private AnimationCurve animationCurve; // 0x30
	[SerializeField] // RVA: 0x167310 Offset: 0x167411 VA: 0x167310
	[RangeAttribute] // RVA: 0x167310 Offset: 0x167411 VA: 0x167310
	private float TotalTime; // 0x38
	[SerializeField] // RVA: 0x167360 Offset: 0x167461 VA: 0x167360
	[RangeAttribute] // RVA: 0x167360 Offset: 0x167461 VA: 0x167360
	[HeaderAttribute] // RVA: 0x167360 Offset: 0x167461 VA: 0x167360
	private float LerpValue; // 0x3C
	[SerializeField] // RVA: 0x1673D0 Offset: 0x1674D1 VA: 0x1673D0
	private Vector3 Rotation; // 0x40
	[SerializeField] // RVA: 0x1673E0 Offset: 0x1674E1 VA: 0x1673E0
	private FlyingNimbus.MoveType moveType; // 0x4C
	[SerializeField] // RVA: 0x1673F0 Offset: 0x1674F1 VA: 0x1673F0
	[HeaderAttribute] // RVA: 0x1673F0 Offset: 0x1674F1 VA: 0x1673F0
	private FlyingNimbusEnter In0; // 0x50
	[SerializeField] // RVA: 0x167440 Offset: 0x167541 VA: 0x167440
	private FlyingNimbusEnter In1; // 0x58
	private Spline Spline; // 0x60
	private GameObject LoadPrefab; // 0x68
	[HideInInspector] // RVA: 0x167450 Offset: 0x167551 VA: 0x167450
	public FlyingNimbus flyingNimbus; // 0x70

	// Properties
	public Prefab CloudID { get; set; }

	// Methods

	// RVA: 0x1D53290 Offset: 0x1D53391 VA: 0x1D53290
	public Prefab get_CloudID() { }

	// RVA: 0x1D532A0 Offset: 0x1D533A1 VA: 0x1D532A0
	public void set_CloudID(Prefab value) { }

	// RVA: 0x1D532B0 Offset: 0x1D533B1 VA: 0x1D532B0 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1D533A0 Offset: 0x1D534A1 VA: 0x1D533A0
	private void Awake() { }

	// RVA: 0x1D53520 Offset: 0x1D53621 VA: 0x1D53520 Slot: 6
	protected override void Start() { }

	// RVA: 0x1D53410 Offset: 0x1D53511 VA: 0x1D53410
	private void SpawnGimmickObject() { }

	// RVA: 0x1D53530 Offset: 0x1D53631 VA: 0x1D53530
	private void SpawnGimmickObject(GameObject baseObj) { }

	// RVA: 0x1D53740 Offset: 0x1D53841 VA: 0x1D53740
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1AB0 Offset: 0x1A1BB1 VA: 0x1A1AB0
	// RVA: 0x1D53870 Offset: 0x1D53971 VA: 0x1D53870
	private void <SpawnGimmickObject>b__18_0(AssetHandle<GameObject> handle) { }
}

