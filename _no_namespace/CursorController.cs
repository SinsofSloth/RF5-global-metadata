public class CursorController : MonoBehaviour // TypeDefIndex: 8452
{
	// Fields
	public static CursorController NowCursor; // 0x0
	public CursorLinker NowFocusObject; // 0x18
	public CursorLinker NextFocusObject; // 0x20
	[SerializeField] // RVA: 0x16FA90 Offset: 0x16FB91 VA: 0x16FA90
	private CursorLinker FirstFocusObject; // 0x28
	[SerializeField] // RVA: 0x16FAA0 Offset: 0x16FBA1 VA: 0x16FAA0
	private float WaitDelayTime; // 0x30
	public float WaitingDelayTime; // 0x34
	public ItemData HoldedItemData; // 0x38
	private ItemData HoldedDataType; // 0x40
	private ItemData HoldedDataSlot; // 0x48
	[SerializeField] // RVA: 0x16FAB0 Offset: 0x16FBB1 VA: 0x16FAB0
	private UIMenuCanvasBase UIMenuCanvasBase; // 0x50
	[SerializeField] // RVA: 0x16FAC0 Offset: 0x16FBC1 VA: 0x16FAC0
	private Image MyPickItemImage; // 0x58
	[SerializeField] // RVA: 0x16FAD0 Offset: 0x16FBD1 VA: 0x16FAD0
	private Image CursorPointImage; // 0x60
	[SerializeField] // RVA: 0x16FAE0 Offset: 0x16FBE1 VA: 0x16FAE0
	private RectTransform CursorRect; // 0x68
	[SerializeField] // RVA: 0x16FAF0 Offset: 0x16FBF1 VA: 0x16FAF0
	private bool UsePointCursor; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x16FB00 Offset: 0x16FC01 VA: 0x16FB00
	private bool <isHide>k__BackingField; // 0x71
	[CompilerGeneratedAttribute] // RVA: 0x16FB10 Offset: 0x16FC11 VA: 0x16FB10
	private bool <IsScrollBoxTopOrBottom>k__BackingField; // 0x72
	private RectTransform CursorImageRectTransform; // 0x78
	private List<CursorEvent> _CursorEventList; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x16FB20 Offset: 0x16FC21 VA: 0x16FB20
	private bool <isActive>k__BackingField; // 0x88
	private Transform startParentObj; // 0x90
	public bool InputBlockerOnItemSortMenu; // 0x98

	// Properties
	public bool isHide { get; set; }
	public bool IsScrollBoxTopOrBottom { get; set; }
	private List<CursorEvent> CursorEventList { get; }
	public bool isActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A76E0 Offset: 0x1A77E1 VA: 0x1A76E0
	// RVA: 0x1FD4B70 Offset: 0x1FD4C71 VA: 0x1FD4B70
	public bool get_isHide() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A76F0 Offset: 0x1A77F1 VA: 0x1A76F0
	// RVA: 0x1FD4B80 Offset: 0x1FD4C81 VA: 0x1FD4B80
	private void set_isHide(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7700 Offset: 0x1A7801 VA: 0x1A7700
	// RVA: 0x1FD4B90 Offset: 0x1FD4C91 VA: 0x1FD4B90
	public bool get_IsScrollBoxTopOrBottom() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7710 Offset: 0x1A7811 VA: 0x1A7710
	// RVA: 0x1FD4BA0 Offset: 0x1FD4CA1 VA: 0x1FD4BA0
	public void set_IsScrollBoxTopOrBottom(bool value) { }

	// RVA: 0x1FD4BB0 Offset: 0x1FD4CB1 VA: 0x1FD4BB0
	private List<CursorEvent> get_CursorEventList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7720 Offset: 0x1A7821 VA: 0x1A7720
	// RVA: 0x1FD4C50 Offset: 0x1FD4D51 VA: 0x1FD4C50
	public bool get_isActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7730 Offset: 0x1A7831 VA: 0x1A7730
	// RVA: 0x1FD4C60 Offset: 0x1FD4D61 VA: 0x1FD4C60
	private void set_isActive(bool value) { }

	// RVA: 0x1FD4C70 Offset: 0x1FD4D71 VA: 0x1FD4C70
	private void InitOnStartUp() { }

	// RVA: 0x1FD4D60 Offset: 0x1FD4E61 VA: 0x1FD4D60
	private void ReInit() { }

	// RVA: 0x1FD4F60 Offset: 0x1FD5061 VA: 0x1FD4F60
	private void Awake() { }

	// RVA: 0x1FD4F70 Offset: 0x1FD5071 VA: 0x1FD4F70
	public void Activate(CursorLinker firstTargetLinker) { }

	// RVA: 0x1FD5310 Offset: 0x1FD5411 VA: 0x1FD5310
	public void Deactivate() { }

	// RVA: 0x1FD5470 Offset: 0x1FD5571 VA: 0x1FD5470
	public void SetParent(Transform parent) { }

	// RVA: 0x1FD3350 Offset: 0x1FD3451 VA: 0x1FD3350
	public void SetFocus(CursorLinker linker) { }

	// RVA: 0x1FD5150 Offset: 0x1FD5251 VA: 0x1FD5150
	public void ReFocus() { }

	// RVA: 0x1FD56C0 Offset: 0x1FD57C1 VA: 0x1FD56C0
	public void ActiveCursor(Transform parent) { }

	// RVA: 0x1FD5780 Offset: 0x1FD5881 VA: 0x1FD5780
	public void UnActiveCursor() { }

	// RVA: 0x1FD5790 Offset: 0x1FD5891 VA: 0x1FD5790
	public void AddCursorEvent(CursorEvent cursorEvent) { }

	// RVA: 0x1FD5900 Offset: 0x1FD5A01 VA: 0x1FD5900
	public void RemoveCursorEvent(CursorEvent cursorEvent) { }

	// RVA: 0x1FD59E0 Offset: 0x1FD5AE1 VA: 0x1FD59E0
	private CursorLinker.InputMoveType GetInputWay() { }

	// RVA: 0x1FD5C10 Offset: 0x1FD5D11 VA: 0x1FD5C10
	private void InputMoveCursor() { }

	// RVA: 0x1FD5D40 Offset: 0x1FD5E41 VA: 0x1FD5D40
	private void OnChangeFocus(CursorLinker targetObj) { }

	// RVA: 0x1FD54B0 Offset: 0x1FD55B1 VA: 0x1FD54B0
	private void ChangeFocusObject(CursorLinker targetObj) { }

	// RVA: 0x1FD5FF0 Offset: 0x1FD60F1 VA: 0x1FD5FF0
	private void UpdatePos() { }

	// RVA: 0x1FD6170 Offset: 0x1FD6271 VA: 0x1FD6170
	public void ForceMoveFocus(CursorLinker targetObj) { }

	// RVA: 0x1FD6180 Offset: 0x1FD6281 VA: 0x1FD6180
	public void SetCursorPoint(CursorLinker targetObj) { }

	// RVA: 0x1FD6280 Offset: 0x1FD6381 VA: 0x1FD6280
	private void SetLockFocus() { }

	// RVA: 0x1FD64B0 Offset: 0x1FD65B1 VA: 0x1FD64B0 Slot: 4
	protected virtual bool CanUpdateCursor() { }

	// RVA: 0x1FD6560 Offset: 0x1FD6661 VA: 0x1FD6560 Slot: 5
	protected virtual bool CheckItemIsSelecting() { }

	// RVA: 0x1FD65C0 Offset: 0x1FD66C1 VA: 0x1FD65C0
	private void Update() { }

	// RVA: 0x1FD6D40 Offset: 0x1FD6E41 VA: 0x1FD6D40
	private void SetItemSprite(ItemData ItemData) { }

	// RVA: 0x1FD6DE0 Offset: 0x1FD6EE1 VA: 0x1FD6DE0
	public void SetHideItemSprite(bool hideFlag) { }

	// RVA: 0x1FD6E10 Offset: 0x1FD6F11 VA: 0x1FD6E10
	private void SetItemSprite(UIItemSlot pickSlot) { }

	// RVA: 0x1FD6EE0 Offset: 0x1FD6FE1 VA: 0x1FD6EE0
	public void PickItem(UIItemSlot pickSlot) { }

	// RVA: 0x1FD6F20 Offset: 0x1FD7021 VA: 0x1FD6F20
	public void PickItem(UIItemSlotsManager.PickingItem pickItem) { }

	// RVA: 0x1FD6F40 Offset: 0x1FD7041 VA: 0x1FD6F40
	public void ReleaseItem() { }

	// RVA: 0x1FD7040 Offset: 0x1FD7141 VA: 0x1FD7040
	public void SetFirstFocusObj(CursorLinker firstFocusObj) { }

	// RVA: 0x1FD7050 Offset: 0x1FD7151 VA: 0x1FD7050
	public void ResetFocusObject(CursorLinker cursorLinker) { }

	// RVA: 0x1FD70C0 Offset: 0x1FD71C1 VA: 0x1FD70C0
	public void SetHide(bool val) { }

	// RVA: 0x1FD70F0 Offset: 0x1FD71F1 VA: 0x1FD70F0
	public void .ctor() { }
}

