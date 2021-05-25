public class SRTabController : SRMonoBehaviourEx // TypeDefIndex: 5572
{
	// Fields
	private readonly SRList<SRTab> _tabs; // 0x48
	private SRTab _activeTab; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C620 Offset: 0x13C721 VA: 0x13C620
	public RectTransform TabButtonContainer; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C630 Offset: 0x13C731 VA: 0x13C630
	public SRTabButton TabButtonPrefab; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C640 Offset: 0x13C741 VA: 0x13C640
	public RectTransform TabContentsContainer; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C650 Offset: 0x13C751 VA: 0x13C650
	public RectTransform TabHeaderContentContainer; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C660 Offset: 0x13C761 VA: 0x13C660
	public Text TabHeaderText; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x13C670 Offset: 0x13C771 VA: 0x13C670
	private Action<SRTabController, SRTab> ActiveTabChanged; // 0x80

	// Properties
	public SRTab ActiveTab { get; set; }
	public IList<SRTab> Tabs { get; }

	// Methods

	// RVA: 0x1B327A0 Offset: 0x1B328A1 VA: 0x1B327A0
	public SRTab get_ActiveTab() { }

	// RVA: 0x1B327B0 Offset: 0x1B328B1 VA: 0x1B327B0
	public void set_ActiveTab(SRTab value) { }

	// RVA: 0x1B32B50 Offset: 0x1B32C51 VA: 0x1B32B50
	public IList<SRTab> get_Tabs() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE90 Offset: 0x13CF91 VA: 0x13CE90
	// RVA: 0x1B2EAB0 Offset: 0x1B2EBB1 VA: 0x1B2EAB0
	public void add_ActiveTabChanged(Action<SRTabController, SRTab> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CEA0 Offset: 0x13CFA1 VA: 0x13CEA0
	// RVA: 0x1B2ED10 Offset: 0x1B2EE11 VA: 0x1B2ED10
	public void remove_ActiveTabChanged(Action<SRTabController, SRTab> value) { }

	// RVA: 0x1B32BB0 Offset: 0x1B32CB1 VA: 0x1B32BB0
	public void AddTab(SRTab tab, bool visibleInSidebar = True) { }

	// RVA: 0x1B327C0 Offset: 0x1B328C1 VA: 0x1B327C0
	private void MakeActive(SRTab tab) { }

	// RVA: 0x1B32E70 Offset: 0x1B32F71 VA: 0x1B32E70
	private void SortTabs() { }

	// RVA: 0x1B33040 Offset: 0x1B33141 VA: 0x1B33040
	public void .ctor() { }
}

