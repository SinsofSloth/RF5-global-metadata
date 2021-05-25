public class GenerateItemSlot : UIScrollBoxBase // TypeDefIndex: 8674
{
	// Fields
	[SerializeField] // RVA: 0x172080 Offset: 0x172181 VA: 0x172080
	private UISortBlock UISortBlock; // 0x68
	[SerializeField] // RVA: 0x172090 Offset: 0x172191 VA: 0x172090
	public GenerateItemSlot ConnectingSlot; // 0x70
	[SerializeField] // RVA: 0x1720A0 Offset: 0x1721A1 VA: 0x1720A0
	public List<UIItemSlot> ForceQuickLinkItemslots; // 0x78
	[SerializeField] // RVA: 0x1720B0 Offset: 0x1721B1 VA: 0x1720B0
	private StorageType storageType; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x1720C0 Offset: 0x1721C1 VA: 0x1720C0
	private bool <Generated>k__BackingField; // 0x84
	private CursorLinkConnector cursorConnector; // 0x88
	[SerializeField] // RVA: 0x1720D0 Offset: 0x1721D1 VA: 0x1720D0
	private Text NameText; // 0x90

	// Properties
	protected override int RowMax { get; }
	public StorageType StorageType { get; }
	public bool Generated { get; set; }
	private ItemStorage ItemStorage { get; }

	// Methods

	// RVA: 0x1E480B0 Offset: 0x1E481B1 VA: 0x1E480B0 Slot: 4
	protected override int get_RowMax() { }

	// RVA: 0x1E480C0 Offset: 0x1E481C1 VA: 0x1E480C0
	public StorageType get_StorageType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8010 Offset: 0x1A8111 VA: 0x1A8010
	// RVA: 0x1E480D0 Offset: 0x1E481D1 VA: 0x1E480D0
	public bool get_Generated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8020 Offset: 0x1A8121 VA: 0x1A8020
	// RVA: 0x1E480E0 Offset: 0x1E481E1 VA: 0x1E480E0
	private void set_Generated(bool value) { }

	// RVA: 0x1E480F0 Offset: 0x1E481F1 VA: 0x1E480F0
	private ItemStorage get_ItemStorage() { }

	// RVA: 0x1E48160 Offset: 0x1E48261 VA: 0x1E48160
	private void OnEnable() { }

	// RVA: 0x1E48460 Offset: 0x1E48561 VA: 0x1E48460
	public void SortItem() { }

	// RVA: 0x1E487C0 Offset: 0x1E488C1 VA: 0x1E487C0
	public void SetSubSortItem(int subSortType) { }

	// RVA: 0x1E48200 Offset: 0x1E48301 VA: 0x1E48200
	private void GenerateItemBlock() { }

	// RVA: 0x1E48860 Offset: 0x1E48961 VA: 0x1E48860
	private void SetNameText() { }

	// RVA: 0x1E489C0 Offset: 0x1E48AC1 VA: 0x1E489C0
	public void SetStorage(StorageType _storageType) { }

	// RVA: 0x1E48A10 Offset: 0x1E48B11 VA: 0x1E48A10
	public void ChangeStorage(StorageType _storageType) { }

	// RVA: 0x1E48AE0 Offset: 0x1E48BE1 VA: 0x1E48AE0
	public bool CheckItemFilterGuard(ItemData itemData) { }

	// RVA: 0x1E48BB0 Offset: 0x1E48CB1 VA: 0x1E48BB0
	public UIItemSlot GetEmptySlot() { }

	// RVA: 0x1E48D20 Offset: 0x1E48E21 VA: 0x1E48D20 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1E48DA0 Offset: 0x1E48EA1 VA: 0x1E48DA0 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1E48EC0 Offset: 0x1E48FC1 VA: 0x1E48EC0 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1E48ED0 Offset: 0x1E48FD1 VA: 0x1E48ED0
	public void .ctor() { }
}

