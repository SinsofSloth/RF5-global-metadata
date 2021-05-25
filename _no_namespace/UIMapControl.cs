public class UIMapControl : MonoBehaviour // TypeDefIndex: 8597
{
	// Fields
	[SerializeField] // RVA: 0x170FD0 Offset: 0x1710D1 VA: 0x170FD0
	private BuildIconSelector mapCursor; // 0x18
	[SerializeField] // RVA: 0x170FE0 Offset: 0x1710E1 VA: 0x170FE0
	private MapControl mapControl; // 0x20
	[SerializeField] // RVA: 0x170FF0 Offset: 0x1710F1 VA: 0x170FF0
	private WarpMenuController warpMenuController; // 0x28
	[SerializeField] // RVA: 0x171000 Offset: 0x171101 VA: 0x171000
	private WarpMenuController warpMenuControllerFloor; // 0x30
	private List<WarpPoints.WarpPoint> WarpableList; // 0x38
	private List<WarpPoints.WarpPoint> WarpListMap; // 0x40
	private List<WarpPoints.WarpPoint> WarpListCtgr; // 0x48
	private List<WarpPoints.WarpPoint> WarpListFloor; // 0x50
	private UIMapControl.MapStep step; // 0x58
	private float stayTime; // 0x5C
	private bool BlockByPopup; // 0x60

	// Methods

	// RVA: 0x1EDF630 Offset: 0x1EDF731 VA: 0x1EDF630
	private void Awake() { }

	// RVA: 0x1EDF690 Offset: 0x1EDF791 VA: 0x1EDF690
	private void Start() { }

	// RVA: 0x1EDFCC0 Offset: 0x1EDFDC1 VA: 0x1EDFCC0
	private void Update() { }

	// RVA: 0x1EDFA30 Offset: 0x1EDFB31 VA: 0x1EDFA30
	private void SetActiveWarpMenu(UIMapControl.MapStep val, bool shortCutFlg = False) { }

	// RVA: 0x1EE04B0 Offset: 0x1EE05B1 VA: 0x1EE04B0
	private void SelectWarpIcon() { }

	// RVA: 0x1EE0DB0 Offset: 0x1EE0EB1 VA: 0x1EE0DB0
	private void setWarpParam() { }

	// RVA: 0x1EE0800 Offset: 0x1EE0901 VA: 0x1EE0800
	private void OpenWarpChoice(int type) { }

	// RVA: 0x1EDF7D0 Offset: 0x1EDF8D1 VA: 0x1EDF7D0
	private void SearchWarpable() { }

	// RVA: 0x1EE0A70 Offset: 0x1EE0B71 VA: 0x1EE0A70
	private int[] getWarpParam(int warpNo) { }

	// RVA: 0x1EE0E40 Offset: 0x1EE0F41 VA: 0x1EE0E40
	private int getWarpNo(int groupId, int floorId) { }

	// RVA: 0x1EE0FD0 Offset: 0x1EE10D1 VA: 0x1EE0FD0
	private bool IsItemHold() { }

	// RVA: 0x1EE10C0 Offset: 0x1EE11C1 VA: 0x1EE10C0
	private bool IsRiding() { }

	// RVA: 0x1EE1180 Offset: 0x1EE1281 VA: 0x1EE1180
	private bool IsWarpCnt() { }

	// RVA: 0x1EE09A0 Offset: 0x1EE0AA1 VA: 0x1EE09A0
	public void SetChangeWarpPoint() { }

	// RVA: 0x1EE0370 Offset: 0x1EE0471 VA: 0x1EE0370
	public bool IsWarpHold() { }

	// RVA: 0x1EE0420 Offset: 0x1EE0521 VA: 0x1EE0420
	public void CloseMapMenu() { }

	// RVA: 0x1EE1200 Offset: 0x1EE1301 VA: 0x1EE1200
	public void touchWarpButton(int no) { }

	// RVA: 0x1EE1310 Offset: 0x1EE1411 VA: 0x1EE1310
	public void touchWarpFloorButton(int no) { }

	// RVA: 0x1EE13D0 Offset: 0x1EE14D1 VA: 0x1EE13D0
	public void updateMapCursor() { }

	// RVA: 0x1EE1470 Offset: 0x1EE1571 VA: 0x1EE1470
	public void .ctor() { }
}

