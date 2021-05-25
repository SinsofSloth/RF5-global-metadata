public class GimmickBreakeMushroomObject : GimmickBreakeObject // TypeDefIndex: 7565
{
	// Fields
	private const int loaderId = 16338;
	private const int SporeDamage = 10;
	[SerializeField] // RVA: 0x167540 Offset: 0x167641 VA: 0x167540
	private int HealHp; // 0x88
	[SerializeField] // RVA: 0x167550 Offset: 0x167651 VA: 0x167550
	private BadStatus[] BadStatuses; // 0x90
	[SerializeField] // RVA: 0x167560 Offset: 0x167661 VA: 0x167560
	private int[] BadStatusesWeight; // 0x98
	[SerializeField] // RVA: 0x167570 Offset: 0x167671 VA: 0x167570
	private int Power; // 0xA0
	[SerializeField] // RVA: 0x167580 Offset: 0x167681 VA: 0x167580
	private float SporeRadius; // 0xA4
	private DamageInfo DamageInfo; // 0xA8
	protected Collider[] Colliders; // 0x128
	private GameObject LoadPrefab; // 0x130

	// Methods

	// RVA: 0x1E4B840 Offset: 0x1E4B941 VA: 0x1E4B840 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1E4B910 Offset: 0x1E4BA11 VA: 0x1E4B910 Slot: 12
	protected override void Awake() { }

	// RVA: 0x1E4B990 Offset: 0x1E4BA91 VA: 0x1E4B990 Slot: 11
	protected override void SetEnableCollider(bool isEnable) { }

	// RVA: 0x1E4BA20 Offset: 0x1E4BB21 VA: 0x1E4BA20 Slot: 13
	public override void SetGimmickFlag(bool setValue) { }

	// RVA: 0x1E4BA30 Offset: 0x1E4BB31 VA: 0x1E4BA30 Slot: 14
	public override void Breake(Vector3 hitPoint) { }

	// RVA: 0x1E4BA60 Offset: 0x1E4BB61 VA: 0x1E4BA60
	private void OnBroken() { }

	// RVA: 0x1E4BB60 Offset: 0x1E4BC61 VA: 0x1E4BB60
	private void SpawnGimmickObject(GameObject baseObj) { }

	// RVA: 0x1E4BD80 Offset: 0x1E4BE81 VA: 0x1E4BD80
	private DamageInfo SetDamageInfo() { }

	// RVA: 0x1E4C080 Offset: 0x1E4C181 VA: 0x1E4C080
	public static int LotteryWeight(int[] weight) { }

	// RVA: 0x1E4C110 Offset: 0x1E4C211 VA: 0x1E4C110
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1AE0 Offset: 0x1A1BE1 VA: 0x1A1AE0
	// RVA: 0x1E4C120 Offset: 0x1E4C221 VA: 0x1E4C120
	private void <OnBroken>b__15_0(AssetHandle<GameObject> handle) { }
}

