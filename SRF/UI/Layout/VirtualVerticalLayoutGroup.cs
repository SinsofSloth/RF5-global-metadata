[AddComponentMenu] // RVA: 0x1276F0 Offset: 0x1277F1 VA: 0x1276F0
public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 4341
{
	// Fields
	private readonly SRList<object> _itemList; // 0x58
	private readonly SRList<int> _visibleItemList; // 0x60
	private bool _isDirty; // 0x68
	private SRList<VirtualVerticalLayoutGroup.Row> _rowCache; // 0x70
	private ScrollRect _scrollRect; // 0x78
	private int _selectedIndex; // 0x80
	private object _selectedItem; // 0x88
	[SerializeField] // RVA: 0x1279A0 Offset: 0x127AA1 VA: 0x1279A0
	private VirtualVerticalLayoutGroup.SelectedItemChangedEvent _selectedItemChanged; // 0x90
	private int _visibleItemCount; // 0x98
	private SRList<VirtualVerticalLayoutGroup.Row> _visibleRows; // 0xA0
	public StyleSheet AltRowStyleSheet; // 0xA8
	public bool EnableSelection; // 0xB0
	public RectTransform ItemPrefab; // 0xB8
	public int RowPadding; // 0xC0
	public StyleSheet RowStyleSheet; // 0xC8
	public StyleSheet SelectedRowStyleSheet; // 0xD0
	public float Spacing; // 0xD8
	public bool StickToBottom; // 0xDC
	private float _itemHeight; // 0xE0

	// Properties
	public VirtualVerticalLayoutGroup.SelectedItemChangedEvent SelectedItemChanged { get; set; }
	public object SelectedItem { get; set; }
	public override float minHeight { get; }
	private ScrollRect ScrollRect { get; }
	private bool AlignBottom { get; }
	private bool AlignTop { get; }
	private float ItemHeight { get; }

	// Methods

	// RVA: 0x1A87810 Offset: 0x1A87911 VA: 0x1A87810
	public VirtualVerticalLayoutGroup.SelectedItemChangedEvent get_SelectedItemChanged() { }

	// RVA: 0x1A87820 Offset: 0x1A87921 VA: 0x1A87820
	public void set_SelectedItemChanged(VirtualVerticalLayoutGroup.SelectedItemChangedEvent value) { }

	// RVA: 0x1A87830 Offset: 0x1A87931 VA: 0x1A87830
	public object get_SelectedItem() { }

	// RVA: 0x1A87840 Offset: 0x1A87941 VA: 0x1A87840
	public void set_SelectedItem(object value) { }

	// RVA: 0x1A87B50 Offset: 0x1A87C51 VA: 0x1A87B50 Slot: 33
	public override float get_minHeight() { }

	// RVA: 0x1A87E30 Offset: 0x1A87F31 VA: 0x1A87E30 Slot: 40
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A87FC0 Offset: 0x1A880C1 VA: 0x1A87FC0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A88270 Offset: 0x1A88371 VA: 0x1A88270
	private void OnScrollRectValueChanged(Vector2 d) { }

	// RVA: 0x1A88340 Offset: 0x1A88441 VA: 0x1A88340 Slot: 6
	protected override void Start() { }

	// RVA: 0x1A88760 Offset: 0x1A88861 VA: 0x1A88760 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A887B0 Offset: 0x1A888B1 VA: 0x1A887B0
	protected void Update() { }

	// RVA: 0x1A879B0 Offset: 0x1A87AB1 VA: 0x1A879B0
	protected void InvalidateItem(int itemIndex) { }

	// RVA: 0x1A88980 Offset: 0x1A88A81 VA: 0x1A88980
	protected void RefreshIndexCache() { }

	// RVA: 0x1A88370 Offset: 0x1A88471 VA: 0x1A88370
	protected void ScrollUpdate() { }

	// RVA: 0x1A88BF0 Offset: 0x1A88CF1 VA: 0x1A88BF0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1A88C60 Offset: 0x1A88D61 VA: 0x1A88C60 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1A88E10 Offset: 0x1A88F11 VA: 0x1A88E10 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x1A87B10 Offset: 0x1A87C11 VA: 0x1A87B10
	private void SetDirty() { }

	// RVA: 0x1A88F40 Offset: 0x1A89041 VA: 0x1A88F40
	public void AddItem(object item) { }

	// RVA: 0x1A89170 Offset: 0x1A89271 VA: 0x1A89170
	public void RemoveItem(object item) { }

	// RVA: 0x1A89270 Offset: 0x1A89371 VA: 0x1A89270
	public void ClearItems() { }

	// RVA: 0x1A881C0 Offset: 0x1A882C1 VA: 0x1A881C0
	private ScrollRect get_ScrollRect() { }

	// RVA: 0x1A888C0 Offset: 0x1A889C1 VA: 0x1A888C0
	private bool get_AlignBottom() { }

	// RVA: 0x1A888F0 Offset: 0x1A889F1 VA: 0x1A888F0
	private bool get_AlignTop() { }

	// RVA: 0x1A87C20 Offset: 0x1A87D21 VA: 0x1A87C20
	private float get_ItemHeight() { }

	// RVA: 0x1A88A50 Offset: 0x1A88B51 VA: 0x1A88A50
	private VirtualVerticalLayoutGroup.Row GetRow(int forIndex) { }

	// RVA: 0x1A88910 Offset: 0x1A88A11 VA: 0x1A88910
	private void RecycleRow(VirtualVerticalLayoutGroup.Row row) { }

	// RVA: 0x1A89560 Offset: 0x1A89661 VA: 0x1A89560
	private void PopulateRow(int index, VirtualVerticalLayoutGroup.Row row) { }

	// RVA: 0x1A89350 Offset: 0x1A89451 VA: 0x1A89350
	private VirtualVerticalLayoutGroup.Row CreateRow() { }

	// RVA: 0x1A897B0 Offset: 0x1A898B1 VA: 0x1A897B0
	public void .ctor() { }
}

