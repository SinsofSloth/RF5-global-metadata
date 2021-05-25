public class FallIceSpawner : GimmickBase // TypeDefIndex: 7550
{
	// Fields
	private const int loaderId = 16330;
	private float CurrentTime; // 0x20
	[SerializeField] // RVA: 0x167060 Offset: 0x167161 VA: 0x167060
	private float Interval; // 0x24
	[SerializeField] // RVA: 0x167070 Offset: 0x167171 VA: 0x167070
	private float FallStartTime; // 0x28
	[SerializeField] // RVA: 0x167080 Offset: 0x167181 VA: 0x167080
	private float ColliderStartTime; // 0x2C
	[SerializeField] // RVA: 0x167090 Offset: 0x167191 VA: 0x167090
	[RangeAttribute] // RVA: 0x167090 Offset: 0x167191 VA: 0x167090
	private float DamagePercent; // 0x30
	[SerializeField] // RVA: 0x1670E0 Offset: 0x1671E1 VA: 0x1670E0
	private float AttackKnockbackPower; // 0x34
	[SerializeField] // RVA: 0x1670F0 Offset: 0x1671F1 VA: 0x1670F0
	private float FallAccelSpeed; // 0x38
	[SerializeField] // RVA: 0x167100 Offset: 0x167201 VA: 0x167100
	private Vector3 FallIceScale; // 0x3C
	[SerializeField] // RVA: 0x167110 Offset: 0x167211 VA: 0x167110
	private float ShadowScale5m; // 0x48
	[SerializeField] // RVA: 0x167120 Offset: 0x167221 VA: 0x167120
	private float ShadowScale0m; // 0x4C
	[SerializeField] // RVA: 0x167130 Offset: 0x167231 VA: 0x167130
	private Transform SpawmPos; // 0x50
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher; // 0x58
	protected bool stayRoom; // 0x60
	private bool isSpawn; // 0x61
	private GameObject LoadPrefab; // 0x68

	// Methods

	// RVA: 0x2085E20 Offset: 0x2085F21 VA: 0x2085E20 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x2085EF0 Offset: 0x2085FF1 VA: 0x2085EF0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2086030 Offset: 0x2086131 VA: 0x2086030
	private void Update() { }

	// RVA: 0x20860A0 Offset: 0x20861A1 VA: 0x20860A0
	private void SpawnFallIce() { }

	// RVA: 0x20861C0 Offset: 0x20862C1 VA: 0x20861C0
	private void SpawnGimmickObject(GameObject baseObj) { }

	// RVA: 0x2086320 Offset: 0x2086421 VA: 0x2086320 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x2086350 Offset: 0x2086451 VA: 0x2086350
	private void OnStayEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x2086460 Offset: 0x2086561 VA: 0x2086460
	private void OnExitEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x2086570 Offset: 0x2086671 VA: 0x2086570
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1A90 Offset: 0x1A1B91 VA: 0x1A1A90
	// RVA: 0x2086620 Offset: 0x2086721 VA: 0x2086620
	private void <SpawnFallIce>b__19_0(AssetHandle<GameObject> handle) { }
}

