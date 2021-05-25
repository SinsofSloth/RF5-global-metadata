public class CampPageSwitcher : MonoBehaviour // TypeDefIndex: 8656
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x171920 Offset: 0x171A21 VA: 0x171920
	private int <nowPage>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x171930 Offset: 0x171A31 VA: 0x171930
	private CursorLinkConnector CenterMenuObj; // 0x20
	private const int PageMax = 9;
	[SerializeField] // RVA: 0x171940 Offset: 0x171A41 VA: 0x171940
	private CampPageController[] PageObj; // 0x28
	[SerializeField] // RVA: 0x171950 Offset: 0x171A51 VA: 0x171950
	private CampTabButton[] CampTabButtons; // 0x30
	[SerializeField] // RVA: 0x171960 Offset: 0x171A61 VA: 0x171960
	private bool[] ActivePage; // 0x38
	[SerializeField] // RVA: 0x171970 Offset: 0x171A71 VA: 0x171970
	private UIOnOffAnimate BaseBoxNameTextBlock; // 0x40
	private UIOnOffAnimate NowBoxNameTextBlock; // 0x48
	[SerializeField] // RVA: 0x171980 Offset: 0x171A81 VA: 0x171980
	private Text BlockNameText; // 0x50
	[SerializeField] // RVA: 0x171990 Offset: 0x171A91 VA: 0x171990
	private string[] PageNameTable; // 0x58
	[SerializeField] // RVA: 0x1719A0 Offset: 0x171AA1 VA: 0x1719A0
	private NonFocusButton L_Button; // 0x60
	[SerializeField] // RVA: 0x1719B0 Offset: 0x171AB1 VA: 0x1719B0
	private NonFocusButton R_Button; // 0x68

	// Properties
	public int nowPage { get; set; }
	private UIModelLoader PlayerEquipModelLoader { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7F50 Offset: 0x1A8051 VA: 0x1A7F50
	// RVA: 0x1D39810 Offset: 0x1D39911 VA: 0x1D39810
	public int get_nowPage() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7F60 Offset: 0x1A8061 VA: 0x1A7F60
	// RVA: 0x1D39820 Offset: 0x1D39921 VA: 0x1D39820
	private void set_nowPage(int value) { }

	// RVA: 0x1D39830 Offset: 0x1D39931 VA: 0x1D39830
	private UIModelLoader get_PlayerEquipModelLoader() { }

	// RVA: 0x1D39890 Offset: 0x1D39991 VA: 0x1D39890
	private void Start() { }

	// RVA: 0x1D384C0 Offset: 0x1D385C1 VA: 0x1D384C0
	public void ResetModelEquip() { }

	// RVA: 0x1D398A0 Offset: 0x1D399A1 VA: 0x1D398A0
	private void CheckLoadModelOnEnterPage() { }

	// RVA: 0x1D39150 Offset: 0x1D39251 VA: 0x1D39150
	public void CheckDestroyModel() { }

	// RVA: 0x1D39920 Offset: 0x1D39A21 VA: 0x1D39920
	public void CloseNowPage() { }

	// RVA: 0x1D39B40 Offset: 0x1D39C41 VA: 0x1D39B40
	private void OpenPage(int nextPage) { }

	// RVA: 0x1D3A1F0 Offset: 0x1D3A2F1 VA: 0x1D3A1F0
	public bool GetPageOpened(CampPage page) { }

	// RVA: 0x1D39100 Offset: 0x1D39201 VA: 0x1D39100
	public void OpenPage(CampPage nextPage) { }

	// RVA: 0x1D3A200 Offset: 0x1D3A301 VA: 0x1D3A200
	public void ChangePage(int val) { }

	// RVA: 0x1D39F90 Offset: 0x1D3A091 VA: 0x1D39F90
	public void SwitchTopicBlock() { }

	// RVA: 0x1D3A280 Offset: 0x1D3A381 VA: 0x1D3A280
	private void OnDisable() { }

	// RVA: 0x1D3A320 Offset: 0x1D3A421 VA: 0x1D3A320
	private void Update() { }

	// RVA: 0x1D3A430 Offset: 0x1D3A531 VA: 0x1D3A430
	public void .ctor() { }
}

