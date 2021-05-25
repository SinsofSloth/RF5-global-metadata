public class MoveCloudSpawner : GimmickBase // TypeDefIndex: 7603
{
	// Fields
	[SerializeField] // RVA: 0x168110 Offset: 0x168211 VA: 0x168110
	private Prefab _CloudID; // 0x20
	[SerializeField] // RVA: 0x168120 Offset: 0x168221 VA: 0x168120
	[HeaderAttribute] // RVA: 0x168120 Offset: 0x168221 VA: 0x168120
	private int Hp; // 0x24
	[SerializeField] // RVA: 0x168170 Offset: 0x168271 VA: 0x168170
	private AttackType attackType; // 0x28
	[SerializeField] // RVA: 0x168180 Offset: 0x168281 VA: 0x168180
	private AttackAttribute[] attackAttribute; // 0x30
	[SerializeField] // RVA: 0x168190 Offset: 0x168291 VA: 0x168190
	[HeaderAttribute] // RVA: 0x168190 Offset: 0x168291 VA: 0x168190
	private float MoveSpeed; // 0x38
	[SerializeField] // RVA: 0x1681E0 Offset: 0x1682E1 VA: 0x1681E0
	[RangeAttribute] // RVA: 0x1681E0 Offset: 0x1682E1 VA: 0x1681E0
	private float LerpValue; // 0x3C
	[SerializeField] // RVA: 0x168230 Offset: 0x168331 VA: 0x168230
	private Vector3 Rotation; // 0x40
	[SerializeField] // RVA: 0x168240 Offset: 0x168341 VA: 0x168240
	[HeaderAttribute] // RVA: 0x168240 Offset: 0x168341 VA: 0x168240
	private float FadeInTime; // 0x4C
	[SerializeField] // RVA: 0x168290 Offset: 0x168391 VA: 0x168290
	private float FadeOutTime; // 0x50
	private Spline Spline; // 0x58
	private float Interval; // 0x60
	private float CurrentTime; // 0x64
	[SerializeField] // RVA: 0x1682A0 Offset: 0x1683A1 VA: 0x1682A0
	private bool IsSpawn; // 0x68
	private GameObject LoadPrefab; // 0x70

	// Properties
	public Prefab CloudID { get; set; }

	// Methods

	// RVA: 0x1CDAF40 Offset: 0x1CDB041 VA: 0x1CDAF40
	public Prefab get_CloudID() { }

	// RVA: 0x1CDAF50 Offset: 0x1CDB051 VA: 0x1CDAF50
	public void set_CloudID(Prefab value) { }

	// RVA: 0x1CDAF60 Offset: 0x1CDB061 VA: 0x1CDAF60 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1CDB050 Offset: 0x1CDB151 VA: 0x1CDB050
	private void Awake() { }

	// RVA: 0x1CDB0B0 Offset: 0x1CDB1B1 VA: 0x1CDB0B0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1CDB0E0 Offset: 0x1CDB1E1 VA: 0x1CDB0E0
	private void Update() { }

	// RVA: 0x1CDB150 Offset: 0x1CDB251 VA: 0x1CDB150
	private void SpawnGimmickObject() { }

	// RVA: 0x1CDB260 Offset: 0x1CDB361 VA: 0x1CDB260
	private void SpawnGimmickObject(GameObject baseObj) { }

	// RVA: 0x1CDB4A0 Offset: 0x1CDB5A1 VA: 0x1CDB4A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2060 Offset: 0x1A2161 VA: 0x1A2060
	// RVA: 0x1CDB550 Offset: 0x1CDB651 VA: 0x1CDB550
	private void <SpawnGimmickObject>b__21_0(AssetHandle<GameObject> handle) { }
}

