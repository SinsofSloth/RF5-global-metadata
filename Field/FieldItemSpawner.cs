public class FieldItemSpawner : MonoBehaviour // TypeDefIndex: 10491
{
	// Fields
	[SerializeField] // RVA: 0x181BC0 Offset: 0x181CC1 VA: 0x181BC0
	private FieldItemSpawnID FieldItemSpawnID; // 0x18
	private FieldItemSpawnDataTable Data; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x181BD0 Offset: 0x181CD1 VA: 0x181BD0
	private OnGroundItem <OnGroundItem>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181BE0 Offset: 0x181CE1 VA: 0x181BE0
	private bool <IsInit>k__BackingField; // 0x48

	// Properties
	public OnGroundItem OnGroundItem { get; set; }
	public bool IsInit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AF8C0 Offset: 0x1AF9C1 VA: 0x1AF8C0
	// RVA: 0x1E27620 Offset: 0x1E27721 VA: 0x1E27620
	public OnGroundItem get_OnGroundItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF8D0 Offset: 0x1AF9D1 VA: 0x1AF8D0
	// RVA: 0x1E27630 Offset: 0x1E27731 VA: 0x1E27630
	private void set_OnGroundItem(OnGroundItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF8E0 Offset: 0x1AF9E1 VA: 0x1AF8E0
	// RVA: 0x1E27640 Offset: 0x1E27741 VA: 0x1E27640
	public bool get_IsInit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF8F0 Offset: 0x1AF9F1 VA: 0x1AF8F0
	// RVA: 0x1E27650 Offset: 0x1E27751 VA: 0x1E27650
	public void set_IsInit(bool value) { }

	// RVA: 0x1E27660 Offset: 0x1E27761 VA: 0x1E27660
	public FieldItemSpawnID GetFieldItemSpawnID() { }

	// RVA: 0x1E27670 Offset: 0x1E27771 VA: 0x1E27670
	private void OnDestroy() { }

	// RVA: 0x1E252A0 Offset: 0x1E253A1 VA: 0x1E252A0
	public void DestroySpawnObject() { }

	// RVA: 0x1E27750 Offset: 0x1E27851 VA: 0x1E27750
	private void Start() { }

	// RVA: 0x1E26C20 Offset: 0x1E26D21 VA: 0x1E26C20
	public void Spawn() { }

	// RVA: 0x1E277D0 Offset: 0x1E278D1 VA: 0x1E277D0
	private ItemID CheckSpawnItemID(ItemID checkItemID) { }

	// RVA: 0x1E27890 Offset: 0x1E27991 VA: 0x1E27890
	public void .ctor() { }
}

