public class DebuggerTabController : SRMonoBehaviourEx // TypeDefIndex: 5546
{
	// Fields
	private SRTab _aboutTabInstance; // 0x48
	private Nullable<DefaultTabs> _activeTab; // 0x50
	private bool _hasStarted; // 0x58
	public SRTab AboutTab; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C060 Offset: 0x13C161 VA: 0x13C060
	public SRTabController TabController; // 0x68

	// Properties
	public Nullable<DefaultTabs> ActiveTab { get; }

	// Methods

	// RVA: 0x15326F0 Offset: 0x15327F1 VA: 0x15326F0
	public Nullable<DefaultTabs> get_ActiveTab() { }

	// RVA: 0x1532860 Offset: 0x1532961 VA: 0x1532860 Slot: 5
	protected override void Start() { }

	// RVA: 0x1532D40 Offset: 0x1532E41 VA: 0x1532D40
	public bool OpenTab(DefaultTabs tab) { }

	// RVA: 0x1533110 Offset: 0x1533211 VA: 0x1533110
	public void ShowAboutTab() { }

	// RVA: 0x15331B0 Offset: 0x15332B1 VA: 0x15331B0
	public void .ctor() { }
}

