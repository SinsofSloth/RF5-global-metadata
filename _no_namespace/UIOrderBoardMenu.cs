public class UIOrderBoardMenu : UIScrollBoxBase // TypeDefIndex: 8746
{
	// Fields
	private bool isOpening; // 0x68
	private List<UIOrderBoardMenu.OrderList> orderLists; // 0x70
	[SerializeField] // RVA: 0x1731F0 Offset: 0x1732F1 VA: 0x1731F0
	private Sprite[] IconSprite; // 0x78
	private bool isOpeningPopup; // 0x80
	private OrderCursorEvent cursorEvent; // 0x88
	[SerializeField] // RVA: 0x173200 Offset: 0x173301 VA: 0x173200
	private Text HeadText; // 0x90

	// Methods

	// RVA: 0x1DCDE20 Offset: 0x1DCDF21 VA: 0x1DCDE20
	private void SetupOrderDataList() { }

	// RVA: 0x1DCDFE0 Offset: 0x1DCE0E1 VA: 0x1DCDFE0
	private void CheckRemoveAcceptedOrderList() { }

	// RVA: 0x1DCE110 Offset: 0x1DCE211 VA: 0x1DCE110 Slot: 8
	protected override void Start() { }

	// RVA: 0x1DCE2E0 Offset: 0x1DCE3E1 VA: 0x1DCE2E0
	public bool OpenCategory() { }

	// RVA: 0x1DCED80 Offset: 0x1DCEE81 VA: 0x1DCED80 Slot: 9
	protected override void Update() { }

	// RVA: 0x1DCF200 Offset: 0x1DCF301 VA: 0x1DCF200
	public void NGSelected(bool choice) { }

	// RVA: 0x1DCF210 Offset: 0x1DCF311 VA: 0x1DCF210
	public void OnSelected(bool choice) { }

	// RVA: 0x1DCF440 Offset: 0x1DCF541 VA: 0x1DCF440
	private static int GetAcceptableOrderNum(PublicationPlace _place) { }

	// RVA: 0x1DCF590 Offset: 0x1DCF691 VA: 0x1DCF590
	public static void OpenBoard() { }

	// RVA: 0x1DCF800 Offset: 0x1DCF901 VA: 0x1DCF800
	public static bool CheckNewOrder(PublicationPlace _place) { }

	// RVA: 0x1DCF820 Offset: 0x1DCF921 VA: 0x1DCF820 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1DCF870 Offset: 0x1DCF971 VA: 0x1DCF870 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1DCF9B0 Offset: 0x1DCFAB1 VA: 0x1DCF9B0 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1DCFA50 Offset: 0x1DCFB51 VA: 0x1DCFA50
	public void .ctor() { }
}

