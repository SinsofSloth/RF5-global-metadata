public class UIShipmentRecordMain : CursorLinkConnector // TypeDefIndex: 8824
{
	// Fields
	[SerializeField] // RVA: 0x173CF0 Offset: 0x173DF1 VA: 0x173CF0
	private ShipTabButton FirstPageTab; // 0x58
	[SerializeField] // RVA: 0x173D00 Offset: 0x173E01 VA: 0x173D00
	private ShipTabButton NowPageTab; // 0x60
	[SerializeField] // RVA: 0x173D10 Offset: 0x173E11 VA: 0x173D10
	private UIOnOffAnimate TopMenuAnimatePrefab; // 0x68
	[SerializeField] // RVA: 0x173D20 Offset: 0x173E21 VA: 0x173D20
	private Text TopMenuText; // 0x70
	[SerializeField] // RVA: 0x173D30 Offset: 0x173E31 VA: 0x173D30
	private UIShipmentItemList UIShipmentItemList; // 0x78
	[SerializeField] // RVA: 0x173D40 Offset: 0x173E41 VA: 0x173D40
	private GameObject MainPage; // 0x80
	[SerializeField] // RVA: 0x173D50 Offset: 0x173E51 VA: 0x173D50
	private GameObject NoShipmentDataPage; // 0x88
	[SerializeField] // RVA: 0x173D60 Offset: 0x173E61 VA: 0x173D60
	private Text NoShipmentDataText; // 0x90
	[SerializeField] // RVA: 0x173D70 Offset: 0x173E71 VA: 0x173D70
	private UIShipmentItemRecord UIShipmentItemRecord; // 0x98
	[SerializeField] // RVA: 0x173D80 Offset: 0x173E81 VA: 0x173D80
	private UIShipmentTotalRecord UIShipmentTotalRecord; // 0xA0
	private bool isHasShipmentData; // 0xA8
	private UIOnOffAnimate TopMenuAnimate; // 0xB0
	private ShipTabButton[] shipTabButtons; // 0xB8
	private SORTTYPE sortType; // 0xC0
	private bool isSortRevert; // 0xC4
	[SerializeField] // RVA: 0x173D90 Offset: 0x173E91 VA: 0x173D90
	private NonFocusButton L_Button; // 0xC8
	[SerializeField] // RVA: 0x173DA0 Offset: 0x173EA1 VA: 0x173DA0
	private NonFocusButton R_Button; // 0xD0

	// Methods

	// RVA: 0x1DDC670 Offset: 0x1DDC771 VA: 0x1DDC670
	private void SetTopText() { }

	// RVA: 0x1DDC7C0 Offset: 0x1DDC8C1 VA: 0x1DDC7C0
	public void OpenPage(ShipTabButton tab) { }

	// RVA: 0x1DDD230 Offset: 0x1DDD331 VA: 0x1DDD230
	public void RegisTab(ShipTabButton button) { }

	// RVA: 0x1DDD2B0 Offset: 0x1DDD3B1 VA: 0x1DDD2B0
	public void ChangePage(int addNum) { }

	// RVA: 0x1DDD380 Offset: 0x1DDD481 VA: 0x1DDD380
	public void SelectSort(SORTTYPE _sortType) { }

	// RVA: 0x1DDD3F0 Offset: 0x1DDD4F1 VA: 0x1DDD3F0
	public void SwitchSort() { }

	// RVA: 0x1DDD4A0 Offset: 0x1DDD5A1 VA: 0x1DDD4A0
	private void Start() { }

	// RVA: 0x1DDD550 Offset: 0x1DDD651 VA: 0x1DDD550
	private void Update() { }

	// RVA: 0x1DDD750 Offset: 0x1DDD851 VA: 0x1DDD750
	public void .ctor() { }
}

