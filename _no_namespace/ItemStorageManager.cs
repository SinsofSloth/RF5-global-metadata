public class ItemStorageManager : SingletonMonoBehaviour<ItemStorageManager> // TypeDefIndex: 7684
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1688D0 Offset: 0x1689D1 VA: 0x1688D0
	private ItemStorage[] <Storages>k__BackingField; // 0x18
	public static readonly int[] MyStorageType; // 0x0
	public const int StorageUpgradeLvMax = 8;
	public static readonly int[,] StorageSize; // 0x8

	// Properties
	private ItemStorage[] Storages { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A24E0 Offset: 0x1A25E1 VA: 0x1A24E0
	// RVA: 0x20904F0 Offset: 0x20905F1 VA: 0x20904F0
	private ItemStorage[] get_Storages() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A24F0 Offset: 0x1A25F1 VA: 0x1A24F0
	// RVA: 0x2090500 Offset: 0x2090601 VA: 0x2090500
	private void set_Storages(ItemStorage[] value) { }

	// RVA: 0x2090510 Offset: 0x2090611 VA: 0x2090510 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2090600 Offset: 0x2090701 VA: 0x2090600
	private void Start() { }

	// RVA: 0x20908C0 Offset: 0x20909C1 VA: 0x20908C0
	public static int GetAmountInAllStorage(ItemID itemID) { }

	// RVA: 0x208E180 Offset: 0x208E281 VA: 0x208E180
	public static ItemStorage GetStorage(StorageType storageType) { }

	// RVA: 0x2090A80 Offset: 0x2090B81 VA: 0x2090A80
	public static string GetStorageName(StorageType storageType) { }

	// RVA: 0x2090ED0 Offset: 0x2090FD1 VA: 0x2090ED0
	public static bool CanRuckAddItem(ItemData itemData) { }

	// RVA: 0x2090FF0 Offset: 0x20910F1 VA: 0x2090FF0
	public static bool CanRuckPushItemIn(ItemData itemData) { }

	// RVA: 0x2091100 Offset: 0x2091201 VA: 0x2091100
	public static bool RuckPushItemIn(ItemData itemData) { }

	// RVA: 0x2091250 Offset: 0x2091351 VA: 0x2091250
	public static int GetStorageMax(StorageType storageType) { }

	// RVA: 0x2090610 Offset: 0x2090711 VA: 0x2090610
	public void Initialize() { }

	// RVA: 0x2091300 Offset: 0x2091401 VA: 0x2091300
	public void .ctor() { }

	// RVA: 0x2091380 Offset: 0x2091481 VA: 0x2091380
	private static void .cctor() { }
}

