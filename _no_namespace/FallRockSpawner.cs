public class FallRockSpawner : GimmickBase // TypeDefIndex: 7552
{
	// Fields
	private const int loaderId = 16331;
	private float CurrentTime; // 0x20
	[SerializeField] // RVA: 0x167150 Offset: 0x167251 VA: 0x167150
	private float Interval; // 0x24
	[SerializeField] // RVA: 0x167160 Offset: 0x167261 VA: 0x167160
	private float DamagePercent; // 0x28
	[SerializeField] // RVA: 0x167170 Offset: 0x167271 VA: 0x167170
	private float FallAccelSpeed; // 0x2C
	private bool isSpawn; // 0x30
	private GameObject LoadPrefab; // 0x38

	// Methods

	// RVA: 0x2086F70 Offset: 0x2087071 VA: 0x2086F70 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x2087040 Offset: 0x2087141 VA: 0x2087040
	private void Update() { }

	// RVA: 0x20870A0 Offset: 0x20871A1 VA: 0x20870A0
	private void SpawnFallRock() { }

	// RVA: 0x20871C0 Offset: 0x20872C1 VA: 0x20871C0
	private void SpawnGimmickObject(GameObject baseObj) { }

	// RVA: 0x20872D0 Offset: 0x20873D1 VA: 0x20872D0 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x2087300 Offset: 0x2087401 VA: 0x2087300
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1AA0 Offset: 0x1A1BA1 VA: 0x1A1AA0
	// RVA: 0x2087320 Offset: 0x2087421 VA: 0x2087320
	private void <SpawnFallRock>b__9_0(AssetHandle<GameObject> handle) { }
}

