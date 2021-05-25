public class EquipItemPool : MonoBehaviour // TypeDefIndex: 6709
{
	// Fields
	public Dictionary<ItemID, ItemPoolData> ItemPoolDatas; // 0x18
	private List<ItemID> ItemDelDatas; // 0x20
	private List<ItemID> ItemRemainDatas; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15EF90 Offset: 0x15F091 VA: 0x15EF90
	private static EquipItemPool <Instance>k__BackingField; // 0x0

	// Properties
	private static EquipItemPool Instance { get; set; }

	// Methods

	// RVA: 0x20237C0 Offset: 0x20238C1 VA: 0x20237C0
	public static GameObject[] GetItems(ItemID item_id) { }

	// RVA: 0x2023870 Offset: 0x2023971 VA: 0x2023870
	public static void Add(ItemID item_id, Action<ItemID> action) { }

	// RVA: 0x2023A10 Offset: 0x2023B11 VA: 0x2023A10
	public static void Delete(ItemID item_id) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA60 Offset: 0x19CB61 VA: 0x19CA60
	// RVA: 0x2023AB0 Offset: 0x2023BB1 VA: 0x2023AB0
	private static EquipItemPool get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA70 Offset: 0x19CB71 VA: 0x19CA70
	// RVA: 0x2023B00 Offset: 0x2023C01 VA: 0x2023B00
	private static void set_Instance(EquipItemPool value) { }

	// RVA: 0x2023B60 Offset: 0x2023C61 VA: 0x2023B60
	private void Awake() { }

	// RVA: 0x2023BC0 Offset: 0x2023CC1 VA: 0x2023BC0
	private void OnDestroy() { }

	// RVA: 0x2023D70 Offset: 0x2023E71 VA: 0x2023D70
	private void Start() { }

	// RVA: 0x2023D80 Offset: 0x2023E81 VA: 0x2023D80
	private void Update() { }

	// RVA: 0x20240F0 Offset: 0x20241F1 VA: 0x20240F0
	public void .ctor() { }
}

