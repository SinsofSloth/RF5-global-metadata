public class UIItemBoxMenu : CursorLinkConnector // TypeDefIndex: 8757
{
	// Fields
	[SerializeField] // RVA: 0x1732F0 Offset: 0x1733F1 VA: 0x1732F0
	private GameObject[] ActiveOnStartObj; // 0x58
	[SerializeField] // RVA: 0x173300 Offset: 0x173401 VA: 0x173300
	private GenerateItemSlot LockedBox; // 0x60
	[SerializeField] // RVA: 0x173310 Offset: 0x173411 VA: 0x173310
	private GenerateItemSlot SwitchBox; // 0x68
	public StorageType nowStorageType; // 0x70
	private List<StorageType> storageAccessList; // 0x78
	private List<UIItemBoxWindowOpenButton> UIItemBoxWindowOpenButtonList; // 0x80
	[SerializeField] // RVA: 0x173320 Offset: 0x173421 VA: 0x173320
	private UIOnOffAnimate BaseBoxNameTextBlock; // 0x88
	private UIOnOffAnimate NowBoxNameTextBlock; // 0x90
	[SerializeField] // RVA: 0x173330 Offset: 0x173431 VA: 0x173330
	private Text BlockNameText; // 0x98
	[SerializeField] // RVA: 0x173340 Offset: 0x173441 VA: 0x173340
	private NonFocusButton L_Button; // 0xA0
	[SerializeField] // RVA: 0x173350 Offset: 0x173451 VA: 0x173350
	private NonFocusButton R_Button; // 0xA8
	[SerializeField] // RVA: 0x173360 Offset: 0x173461 VA: 0x173360
	private UIItemBoxMenu.StorageAccessType storageAccessType; // 0xB0

	// Methods

	// RVA: 0x1F16030 Offset: 0x1F16131 VA: 0x1F16030
	private void SwitchTopicBlock() { }

	// RVA: 0x1F16230 Offset: 0x1F16331 VA: 0x1F16230
	public void ChangeStorage(StorageType _storageType) { }

	// RVA: 0x1F165E0 Offset: 0x1F166E1 VA: 0x1F165E0
	public void ChangeStorage(int movePage) { }

	// RVA: 0x1F166E0 Offset: 0x1F167E1 VA: 0x1F166E0
	public void AddSwitchButton(UIItemBoxWindowOpenButton _UIItemBoxWindowOpenButton) { }

	// RVA: 0x1F16790 Offset: 0x1F16891 VA: 0x1F16790
	private void AddAccessList(StorageType _storageType) { }

	// RVA: 0x1F16850 Offset: 0x1F16951 VA: 0x1F16850 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1F171A0 Offset: 0x1F172A1 VA: 0x1F171A0
	public void SetStorageOnLoad(StorageType _storageType) { }

	// RVA: 0x1F171B0 Offset: 0x1F172B1 VA: 0x1F171B0
	private void Start() { }

	// RVA: 0x1F17630 Offset: 0x1F17731 VA: 0x1F17630
	private void Update() { }

	// RVA: 0x1F177A0 Offset: 0x1F178A1 VA: 0x1F177A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A84B0 Offset: 0x1A85B1 VA: 0x1A84B0
	// RVA: 0x1F177B0 Offset: 0x1F178B1 VA: 0x1F177B0
	private bool <ChangeStorage>b__15_0(StorageType a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A84C0 Offset: 0x1A85C1 VA: 0x1A84C0
	// RVA: 0x1F177C0 Offset: 0x1F178C1 VA: 0x1F177C0
	private void <Start>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A84D0 Offset: 0x1A85D1 VA: 0x1A84D0
	// RVA: 0x1F17830 Offset: 0x1F17931 VA: 0x1F17830
	private void <Start>b__20_1() { }
}

