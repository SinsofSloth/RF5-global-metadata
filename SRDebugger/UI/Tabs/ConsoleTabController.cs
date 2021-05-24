public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 5551
{
	// Fields
	private const int MaxLength = 2600;
	private Canvas _consoleCanvas; // 0x48
	private bool _isDirty; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C170 Offset: 0x13C271 VA: 0x13C170
	public ConsoleLogControl ConsoleLogControl; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C180 Offset: 0x13C281 VA: 0x13C180
	public Toggle PinToggle; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C190 Offset: 0x13C291 VA: 0x13C190
	public ScrollRect StackTraceScrollRect; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C1A0 Offset: 0x13C2A1 VA: 0x13C1A0
	public Text StackTraceText; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C1B0 Offset: 0x13C2B1 VA: 0x13C1B0
	public Toggle ToggleErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C1C0 Offset: 0x13C2C1 VA: 0x13C1C0
	public Text ToggleErrorsText; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C1D0 Offset: 0x13C2D1 VA: 0x13C1D0
	public Toggle ToggleInfo; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C1E0 Offset: 0x13C2E1 VA: 0x13C1E0
	public Text ToggleInfoText; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C1F0 Offset: 0x13C2F1 VA: 0x13C1F0
	public Toggle ToggleWarnings; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C200 Offset: 0x13C301 VA: 0x13C200
	public Text ToggleWarningsText; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C210 Offset: 0x13C311 VA: 0x13C210
	public Toggle FilterToggle; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C220 Offset: 0x13C321 VA: 0x13C220
	public InputField FilterField; // 0xB0
	[RequiredFieldAttribute] // RVA: 0x13C230 Offset: 0x13C331 VA: 0x13C230
	public GameObject FilterBarContainer; // 0xB8

	// Methods

	// RVA: 0x1B339B0 Offset: 0x1B33AB1 VA: 0x1B339B0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B342E0 Offset: 0x1B343E1 VA: 0x1B342E0
	private void FilterToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34360 Offset: 0x1B34461 VA: 0x1B34360
	private void FilterValueChanged(string filterText) { }

	// RVA: 0x1B343F0 Offset: 0x1B344F1 VA: 0x1B343F0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B344B0 Offset: 0x1B345B1 VA: 0x1B344B0
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34570 Offset: 0x1B34671 VA: 0x1B34570 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B34680 Offset: 0x1B34781 VA: 0x1B34680 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B346B0 Offset: 0x1B347B1 VA: 0x1B346B0
	private void ConsoleLogSelectedItemChanged(object item) { }

	// RVA: 0x1B34740 Offset: 0x1B34841 VA: 0x1B34740 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B33E00 Offset: 0x1B33F01 VA: 0x1B33E00
	private void PopulateStackTraceArea(ConsoleEntry entry) { }

	// RVA: 0x1B33FA0 Offset: 0x1B340A1 VA: 0x1B33FA0
	private void Refresh() { }

	// RVA: 0x1B34780 Offset: 0x1B34881 VA: 0x1B34780
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B34790 Offset: 0x1B34891 VA: 0x1B34790
	public void Clear() { }

	// RVA: 0x1B34860 Offset: 0x1B34961 VA: 0x1B34860
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CDF0 Offset: 0x13CEF1 VA: 0x13CDF0
	// RVA: 0x1B34870 Offset: 0x1B34971 VA: 0x1B34870
	private void <Start>b__16_0(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE00 Offset: 0x13CF01 VA: 0x13CE00
	// RVA: 0x1B34880 Offset: 0x1B34981 VA: 0x1B34880
	private void <Start>b__16_1(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE10 Offset: 0x13CF11 VA: 0x13CE10
	// RVA: 0x1B34890 Offset: 0x1B34991 VA: 0x1B34890
	private void <Start>b__16_2(bool isOn) { }
}

public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 5551
{
	// Fields
	private const int MaxLength = 2600;
	private Canvas _consoleCanvas; // 0x48
	private bool _isDirty; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C170 Offset: 0x13C271 VA: 0x13C170
	public ConsoleLogControl ConsoleLogControl; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C180 Offset: 0x13C281 VA: 0x13C180
	public Toggle PinToggle; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C190 Offset: 0x13C291 VA: 0x13C190
	public ScrollRect StackTraceScrollRect; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C1A0 Offset: 0x13C2A1 VA: 0x13C1A0
	public Text StackTraceText; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C1B0 Offset: 0x13C2B1 VA: 0x13C1B0
	public Toggle ToggleErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C1C0 Offset: 0x13C2C1 VA: 0x13C1C0
	public Text ToggleErrorsText; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C1D0 Offset: 0x13C2D1 VA: 0x13C1D0
	public Toggle ToggleInfo; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C1E0 Offset: 0x13C2E1 VA: 0x13C1E0
	public Text ToggleInfoText; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C1F0 Offset: 0x13C2F1 VA: 0x13C1F0
	public Toggle ToggleWarnings; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C200 Offset: 0x13C301 VA: 0x13C200
	public Text ToggleWarningsText; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C210 Offset: 0x13C311 VA: 0x13C210
	public Toggle FilterToggle; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C220 Offset: 0x13C321 VA: 0x13C220
	public InputField FilterField; // 0xB0
	[RequiredFieldAttribute] // RVA: 0x13C230 Offset: 0x13C331 VA: 0x13C230
	public GameObject FilterBarContainer; // 0xB8

	// Methods

	// RVA: 0x1B339B0 Offset: 0x1B33AB1 VA: 0x1B339B0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B342E0 Offset: 0x1B343E1 VA: 0x1B342E0
	private void FilterToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34360 Offset: 0x1B34461 VA: 0x1B34360
	private void FilterValueChanged(string filterText) { }

	// RVA: 0x1B343F0 Offset: 0x1B344F1 VA: 0x1B343F0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B344B0 Offset: 0x1B345B1 VA: 0x1B344B0
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34570 Offset: 0x1B34671 VA: 0x1B34570 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B34680 Offset: 0x1B34781 VA: 0x1B34680 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B346B0 Offset: 0x1B347B1 VA: 0x1B346B0
	private void ConsoleLogSelectedItemChanged(object item) { }

	// RVA: 0x1B34740 Offset: 0x1B34841 VA: 0x1B34740 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B33E00 Offset: 0x1B33F01 VA: 0x1B33E00
	private void PopulateStackTraceArea(ConsoleEntry entry) { }

	// RVA: 0x1B33FA0 Offset: 0x1B340A1 VA: 0x1B33FA0
	private void Refresh() { }

	// RVA: 0x1B34780 Offset: 0x1B34881 VA: 0x1B34780
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B34790 Offset: 0x1B34891 VA: 0x1B34790
	public void Clear() { }

	// RVA: 0x1B34860 Offset: 0x1B34961 VA: 0x1B34860
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CDF0 Offset: 0x13CEF1 VA: 0x13CDF0
	// RVA: 0x1B34870 Offset: 0x1B34971 VA: 0x1B34870
	private void <Start>b__16_0(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE00 Offset: 0x13CF01 VA: 0x13CE00
	// RVA: 0x1B34880 Offset: 0x1B34981 VA: 0x1B34880
	private void <Start>b__16_1(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE10 Offset: 0x13CF11 VA: 0x13CE10
	// RVA: 0x1B34890 Offset: 0x1B34991 VA: 0x1B34890
	private void <Start>b__16_2(bool isOn) { }
}

public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 5551
{
	// Fields
	private const int MaxLength = 2600;
	private Canvas _consoleCanvas; // 0x48
	private bool _isDirty; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C170 Offset: 0x13C271 VA: 0x13C170
	public ConsoleLogControl ConsoleLogControl; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C180 Offset: 0x13C281 VA: 0x13C180
	public Toggle PinToggle; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C190 Offset: 0x13C291 VA: 0x13C190
	public ScrollRect StackTraceScrollRect; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C1A0 Offset: 0x13C2A1 VA: 0x13C1A0
	public Text StackTraceText; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C1B0 Offset: 0x13C2B1 VA: 0x13C1B0
	public Toggle ToggleErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C1C0 Offset: 0x13C2C1 VA: 0x13C1C0
	public Text ToggleErrorsText; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C1D0 Offset: 0x13C2D1 VA: 0x13C1D0
	public Toggle ToggleInfo; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C1E0 Offset: 0x13C2E1 VA: 0x13C1E0
	public Text ToggleInfoText; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C1F0 Offset: 0x13C2F1 VA: 0x13C1F0
	public Toggle ToggleWarnings; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C200 Offset: 0x13C301 VA: 0x13C200
	public Text ToggleWarningsText; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C210 Offset: 0x13C311 VA: 0x13C210
	public Toggle FilterToggle; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C220 Offset: 0x13C321 VA: 0x13C220
	public InputField FilterField; // 0xB0
	[RequiredFieldAttribute] // RVA: 0x13C230 Offset: 0x13C331 VA: 0x13C230
	public GameObject FilterBarContainer; // 0xB8

	// Methods

	// RVA: 0x1B339B0 Offset: 0x1B33AB1 VA: 0x1B339B0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B342E0 Offset: 0x1B343E1 VA: 0x1B342E0
	private void FilterToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34360 Offset: 0x1B34461 VA: 0x1B34360
	private void FilterValueChanged(string filterText) { }

	// RVA: 0x1B343F0 Offset: 0x1B344F1 VA: 0x1B343F0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B344B0 Offset: 0x1B345B1 VA: 0x1B344B0
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34570 Offset: 0x1B34671 VA: 0x1B34570 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B34680 Offset: 0x1B34781 VA: 0x1B34680 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B346B0 Offset: 0x1B347B1 VA: 0x1B346B0
	private void ConsoleLogSelectedItemChanged(object item) { }

	// RVA: 0x1B34740 Offset: 0x1B34841 VA: 0x1B34740 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B33E00 Offset: 0x1B33F01 VA: 0x1B33E00
	private void PopulateStackTraceArea(ConsoleEntry entry) { }

	// RVA: 0x1B33FA0 Offset: 0x1B340A1 VA: 0x1B33FA0
	private void Refresh() { }

	// RVA: 0x1B34780 Offset: 0x1B34881 VA: 0x1B34780
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B34790 Offset: 0x1B34891 VA: 0x1B34790
	public void Clear() { }

	// RVA: 0x1B34860 Offset: 0x1B34961 VA: 0x1B34860
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CDF0 Offset: 0x13CEF1 VA: 0x13CDF0
	// RVA: 0x1B34870 Offset: 0x1B34971 VA: 0x1B34870
	private void <Start>b__16_0(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE00 Offset: 0x13CF01 VA: 0x13CE00
	// RVA: 0x1B34880 Offset: 0x1B34981 VA: 0x1B34880
	private void <Start>b__16_1(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE10 Offset: 0x13CF11 VA: 0x13CE10
	// RVA: 0x1B34890 Offset: 0x1B34991 VA: 0x1B34890
	private void <Start>b__16_2(bool isOn) { }
}

public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 5551
{
	// Fields
	private const int MaxLength = 2600;
	private Canvas _consoleCanvas; // 0x48
	private bool _isDirty; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C170 Offset: 0x13C271 VA: 0x13C170
	public ConsoleLogControl ConsoleLogControl; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C180 Offset: 0x13C281 VA: 0x13C180
	public Toggle PinToggle; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C190 Offset: 0x13C291 VA: 0x13C190
	public ScrollRect StackTraceScrollRect; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C1A0 Offset: 0x13C2A1 VA: 0x13C1A0
	public Text StackTraceText; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C1B0 Offset: 0x13C2B1 VA: 0x13C1B0
	public Toggle ToggleErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C1C0 Offset: 0x13C2C1 VA: 0x13C1C0
	public Text ToggleErrorsText; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C1D0 Offset: 0x13C2D1 VA: 0x13C1D0
	public Toggle ToggleInfo; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C1E0 Offset: 0x13C2E1 VA: 0x13C1E0
	public Text ToggleInfoText; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C1F0 Offset: 0x13C2F1 VA: 0x13C1F0
	public Toggle ToggleWarnings; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C200 Offset: 0x13C301 VA: 0x13C200
	public Text ToggleWarningsText; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C210 Offset: 0x13C311 VA: 0x13C210
	public Toggle FilterToggle; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C220 Offset: 0x13C321 VA: 0x13C220
	public InputField FilterField; // 0xB0
	[RequiredFieldAttribute] // RVA: 0x13C230 Offset: 0x13C331 VA: 0x13C230
	public GameObject FilterBarContainer; // 0xB8

	// Methods

	// RVA: 0x1B339B0 Offset: 0x1B33AB1 VA: 0x1B339B0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B342E0 Offset: 0x1B343E1 VA: 0x1B342E0
	private void FilterToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34360 Offset: 0x1B34461 VA: 0x1B34360
	private void FilterValueChanged(string filterText) { }

	// RVA: 0x1B343F0 Offset: 0x1B344F1 VA: 0x1B343F0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B344B0 Offset: 0x1B345B1 VA: 0x1B344B0
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34570 Offset: 0x1B34671 VA: 0x1B34570 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B34680 Offset: 0x1B34781 VA: 0x1B34680 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B346B0 Offset: 0x1B347B1 VA: 0x1B346B0
	private void ConsoleLogSelectedItemChanged(object item) { }

	// RVA: 0x1B34740 Offset: 0x1B34841 VA: 0x1B34740 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B33E00 Offset: 0x1B33F01 VA: 0x1B33E00
	private void PopulateStackTraceArea(ConsoleEntry entry) { }

	// RVA: 0x1B33FA0 Offset: 0x1B340A1 VA: 0x1B33FA0
	private void Refresh() { }

	// RVA: 0x1B34780 Offset: 0x1B34881 VA: 0x1B34780
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B34790 Offset: 0x1B34891 VA: 0x1B34790
	public void Clear() { }

	// RVA: 0x1B34860 Offset: 0x1B34961 VA: 0x1B34860
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CDF0 Offset: 0x13CEF1 VA: 0x13CDF0
	// RVA: 0x1B34870 Offset: 0x1B34971 VA: 0x1B34870
	private void <Start>b__16_0(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE00 Offset: 0x13CF01 VA: 0x13CE00
	// RVA: 0x1B34880 Offset: 0x1B34981 VA: 0x1B34880
	private void <Start>b__16_1(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE10 Offset: 0x13CF11 VA: 0x13CE10
	// RVA: 0x1B34890 Offset: 0x1B34991 VA: 0x1B34890
	private void <Start>b__16_2(bool isOn) { }
}

public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 5551
{
	// Fields
	private const int MaxLength = 2600;
	private Canvas _consoleCanvas; // 0x48
	private bool _isDirty; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C170 Offset: 0x13C271 VA: 0x13C170
	public ConsoleLogControl ConsoleLogControl; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C180 Offset: 0x13C281 VA: 0x13C180
	public Toggle PinToggle; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C190 Offset: 0x13C291 VA: 0x13C190
	public ScrollRect StackTraceScrollRect; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C1A0 Offset: 0x13C2A1 VA: 0x13C1A0
	public Text StackTraceText; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C1B0 Offset: 0x13C2B1 VA: 0x13C1B0
	public Toggle ToggleErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C1C0 Offset: 0x13C2C1 VA: 0x13C1C0
	public Text ToggleErrorsText; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C1D0 Offset: 0x13C2D1 VA: 0x13C1D0
	public Toggle ToggleInfo; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C1E0 Offset: 0x13C2E1 VA: 0x13C1E0
	public Text ToggleInfoText; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C1F0 Offset: 0x13C2F1 VA: 0x13C1F0
	public Toggle ToggleWarnings; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C200 Offset: 0x13C301 VA: 0x13C200
	public Text ToggleWarningsText; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C210 Offset: 0x13C311 VA: 0x13C210
	public Toggle FilterToggle; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C220 Offset: 0x13C321 VA: 0x13C220
	public InputField FilterField; // 0xB0
	[RequiredFieldAttribute] // RVA: 0x13C230 Offset: 0x13C331 VA: 0x13C230
	public GameObject FilterBarContainer; // 0xB8

	// Methods

	// RVA: 0x1B339B0 Offset: 0x1B33AB1 VA: 0x1B339B0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B342E0 Offset: 0x1B343E1 VA: 0x1B342E0
	private void FilterToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34360 Offset: 0x1B34461 VA: 0x1B34360
	private void FilterValueChanged(string filterText) { }

	// RVA: 0x1B343F0 Offset: 0x1B344F1 VA: 0x1B343F0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B344B0 Offset: 0x1B345B1 VA: 0x1B344B0
	private void PinToggleValueChanged(bool isOn) { }

	// RVA: 0x1B34570 Offset: 0x1B34671 VA: 0x1B34570 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B34680 Offset: 0x1B34781 VA: 0x1B34680 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B346B0 Offset: 0x1B347B1 VA: 0x1B346B0
	private void ConsoleLogSelectedItemChanged(object item) { }

	// RVA: 0x1B34740 Offset: 0x1B34841 VA: 0x1B34740 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B33E00 Offset: 0x1B33F01 VA: 0x1B33E00
	private void PopulateStackTraceArea(ConsoleEntry entry) { }

	// RVA: 0x1B33FA0 Offset: 0x1B340A1 VA: 0x1B33FA0
	private void Refresh() { }

	// RVA: 0x1B34780 Offset: 0x1B34881 VA: 0x1B34780
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B34790 Offset: 0x1B34891 VA: 0x1B34790
	public void Clear() { }

	// RVA: 0x1B34860 Offset: 0x1B34961 VA: 0x1B34860
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CDF0 Offset: 0x13CEF1 VA: 0x13CDF0
	// RVA: 0x1B34870 Offset: 0x1B34971 VA: 0x1B34870
	private void <Start>b__16_0(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE00 Offset: 0x13CF01 VA: 0x13CE00
	// RVA: 0x1B34880 Offset: 0x1B34981 VA: 0x1B34880
	private void <Start>b__16_1(bool isOn) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CE10 Offset: 0x13CF11 VA: 0x13CE10
	// RVA: 0x1B34890 Offset: 0x1B34991 VA: 0x1B34890
	private void <Start>b__16_2(bool isOn) { }
}

