public class WarpMenuController : UIScrollBoxBase // TypeDefIndex: 8638
{
	// Fields
	[SerializeField] // RVA: 0x171650 Offset: 0x171751 VA: 0x171650
	private UIMapControl mapControl; // 0x68
	[SerializeField] // RVA: 0x171660 Offset: 0x171761 VA: 0x171660
	private RectTransform windowRect; // 0x70
	[SerializeField] // RVA: 0x171670 Offset: 0x171771 VA: 0x171670
	private Text menuName; // 0x78
	[SerializeField] // RVA: 0x171680 Offset: 0x171781 VA: 0x171680
	private int WindowType; // 0x80
	private List<WarpPoints.WarpPoint> WarpableList; // 0x88
	private UIOnOffAnimate OnOffAnim; // 0x90
	private int groupId; // 0x98
	private int cashScrollHeadIndex; // 0x9C
	private int cashSlotNo; // 0xA0
	private bool OnFocus; // 0xA4
	private FieldSceneId[] FarmDragonIDList; // 0xA8
	private bool ShortCutFlg; // 0xB0

	// Methods

	// RVA: 0x1D04810 Offset: 0x1D04911 VA: 0x1D04810
	private void Awake() { }

	// RVA: 0x1D04B60 Offset: 0x1D04C61 VA: 0x1D04B60 Slot: 8
	protected override void Start() { }

	// RVA: 0x1D04B70 Offset: 0x1D04C71 VA: 0x1D04B70 Slot: 9
	protected override void Update() { }

	// RVA: 0x1D04BF0 Offset: 0x1D04CF1 VA: 0x1D04BF0 Slot: 10
	protected override void OnDisable() { }

	// RVA: 0x1D049D0 Offset: 0x1D04AD1 VA: 0x1D049D0
	public void InitWarpMenu() { }

	// RVA: 0x1D052E0 Offset: 0x1D053E1 VA: 0x1D052E0
	private void SetDispWarpButton() { }

	// RVA: 0x1D05370 Offset: 0x1D05471 VA: 0x1D05370
	private string GetFarmName(int farmNo) { }

	// RVA: 0x1D04C00 Offset: 0x1D04D01 VA: 0x1D04C00
	private void SearchWarpable() { }

	// RVA: 0x1D05280 Offset: 0x1D05381 VA: 0x1D05280
	private void OffWindow() { }

	// RVA: 0x1D05590 Offset: 0x1D05691 VA: 0x1D05590
	public bool Warp(UIMapControl UIMapControl) { }

	// RVA: 0x1D05A70 Offset: 0x1D05B71 VA: 0x1D05A70
	public int CheckWarpType() { }

	// RVA: 0x1D05B10 Offset: 0x1D05C11 VA: 0x1D05B10
	public int CheckWarpTypeNo(int warpNo) { }

	// RVA: 0x1D05BB0 Offset: 0x1D05CB1 VA: 0x1D05BB0
	public void SetGroupId(int gId) { }

	// RVA: 0x1D05BC0 Offset: 0x1D05CC1 VA: 0x1D05BC0
	public int GetGroupId() { }

	// RVA: 0x1D05BD0 Offset: 0x1D05CD1 VA: 0x1D05BD0
	public void SelectWarpMenu() { }

	// RVA: 0x1D05BE0 Offset: 0x1D05CE1 VA: 0x1D05BE0
	public void SetCursorPoint(int setNo) { }

	// RVA: 0x1D05DA0 Offset: 0x1D05EA1 VA: 0x1D05DA0
	public void SetSelectPoint(int no) { }

	// RVA: 0x1D05E90 Offset: 0x1D05F91 VA: 0x1D05E90
	public int GetWarpNo() { }

	// RVA: 0x1D05F10 Offset: 0x1D06011 VA: 0x1D05F10
	public List<WarpPoints.WarpPoint> GetWarpableList() { }

	// RVA: 0x1D05F20 Offset: 0x1D06021 VA: 0x1D05F20
	public void FocusThis(bool stat) { }

	// RVA: 0x1D05F30 Offset: 0x1D06031 VA: 0x1D05F30
	public bool getFocus() { }

	// RVA: 0x1D05F40 Offset: 0x1D06041 VA: 0x1D05F40
	public void SetMapActive(bool _flag) { }

	// RVA: 0x1D06010 Offset: 0x1D06111 VA: 0x1D06010
	public void setScale(float scale) { }

	// RVA: 0x1D06020 Offset: 0x1D06121 VA: 0x1D06020
	public void setShortCut(bool flg) { }

	// RVA: 0x1D06030 Offset: 0x1D06131 VA: 0x1D06030 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1D06080 Offset: 0x1D06181 VA: 0x1D06080 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1D06230 Offset: 0x1D06331 VA: 0x1D06230 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1D06290 Offset: 0x1D06391 VA: 0x1D06290
	public void .ctor() { }
}

