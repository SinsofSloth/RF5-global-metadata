public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 5581
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	[SerializeField] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	[SerializeField] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	private ScrollRect _consoleScrollRect; // 0x50
	private bool _isDirty; // 0x58
	private Nullable<Vector2> _scrollPosition; // 0x5C
	private bool _showErrors; // 0x68
	private bool _showInfo; // 0x69
	private bool _showWarnings; // 0x6A
	public Action<ConsoleEntry> SelectedItemChanged; // 0x70
	private string _filter; // 0x78

	// Properties
	public bool ShowErrors { get; set; }
	public bool ShowWarnings { get; set; }
	public bool ShowInfo { get; set; }
	public bool EnableSelection { get; set; }
	public string Filter { get; set; }

	// Methods

	// RVA: 0x1543880 Offset: 0x1543981 VA: 0x1543880
	public bool get_ShowErrors() { }

	// RVA: 0x1543890 Offset: 0x1543991 VA: 0x1543890
	public void set_ShowErrors(bool value) { }

	// RVA: 0x15438C0 Offset: 0x15439C1 VA: 0x15438C0
	public bool get_ShowWarnings() { }

	// RVA: 0x15438D0 Offset: 0x15439D1 VA: 0x15438D0
	public void set_ShowWarnings(bool value) { }

	// RVA: 0x15438F0 Offset: 0x15439F1 VA: 0x15438F0
	public bool get_ShowInfo() { }

	// RVA: 0x1543900 Offset: 0x1543A01 VA: 0x1543900
	public void set_ShowInfo(bool value) { }

	// RVA: 0x1543920 Offset: 0x1543A21 VA: 0x1543920
	public bool get_EnableSelection() { }

	// RVA: 0x1543940 Offset: 0x1543A41 VA: 0x1543940
	public void set_EnableSelection(bool value) { }

	// RVA: 0x1543960 Offset: 0x1543A61 VA: 0x1543960
	public string get_Filter() { }

	// RVA: 0x1543970 Offset: 0x1543A71 VA: 0x1543970
	public void set_Filter(string value) { }

	// RVA: 0x15439D0 Offset: 0x1543AD1 VA: 0x15439D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1543BC0 Offset: 0x1543CC1 VA: 0x1543BC0 Slot: 5
	protected override void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CEB0 Offset: 0x13CFB1 VA: 0x13CEB0
	// RVA: 0x1543C60 Offset: 0x1543D61 VA: 0x1543C60
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x1543D10 Offset: 0x1543E11 VA: 0x1543D10 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1543F30 Offset: 0x1544031 VA: 0x1543F30
	private void OnSelectedItemChanged(object arg0) { }

	// RVA: 0x1543FF0 Offset: 0x15440F1 VA: 0x1543FF0 Slot: 6
	protected override void Update() { }

	// RVA: 0x15440A0 Offset: 0x15441A1 VA: 0x15440A0
	private void Refresh() { }

	// RVA: 0x15438B0 Offset: 0x15439B1 VA: 0x15438B0
	private void SetIsDirty() { }

	// RVA: 0x1544440 Offset: 0x1544541 VA: 0x1544440
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1544450 Offset: 0x1544551 VA: 0x1544450
	public void .ctor() { }
}

public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 5581
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	[SerializeField] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	[SerializeField] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	private ScrollRect _consoleScrollRect; // 0x50
	private bool _isDirty; // 0x58
	private Nullable<Vector2> _scrollPosition; // 0x5C
	private bool _showErrors; // 0x68
	private bool _showInfo; // 0x69
	private bool _showWarnings; // 0x6A
	public Action<ConsoleEntry> SelectedItemChanged; // 0x70
	private string _filter; // 0x78

	// Properties
	public bool ShowErrors { get; set; }
	public bool ShowWarnings { get; set; }
	public bool ShowInfo { get; set; }
	public bool EnableSelection { get; set; }
	public string Filter { get; set; }

	// Methods

	// RVA: 0x1543880 Offset: 0x1543981 VA: 0x1543880
	public bool get_ShowErrors() { }

	// RVA: 0x1543890 Offset: 0x1543991 VA: 0x1543890
	public void set_ShowErrors(bool value) { }

	// RVA: 0x15438C0 Offset: 0x15439C1 VA: 0x15438C0
	public bool get_ShowWarnings() { }

	// RVA: 0x15438D0 Offset: 0x15439D1 VA: 0x15438D0
	public void set_ShowWarnings(bool value) { }

	// RVA: 0x15438F0 Offset: 0x15439F1 VA: 0x15438F0
	public bool get_ShowInfo() { }

	// RVA: 0x1543900 Offset: 0x1543A01 VA: 0x1543900
	public void set_ShowInfo(bool value) { }

	// RVA: 0x1543920 Offset: 0x1543A21 VA: 0x1543920
	public bool get_EnableSelection() { }

	// RVA: 0x1543940 Offset: 0x1543A41 VA: 0x1543940
	public void set_EnableSelection(bool value) { }

	// RVA: 0x1543960 Offset: 0x1543A61 VA: 0x1543960
	public string get_Filter() { }

	// RVA: 0x1543970 Offset: 0x1543A71 VA: 0x1543970
	public void set_Filter(string value) { }

	// RVA: 0x15439D0 Offset: 0x1543AD1 VA: 0x15439D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1543BC0 Offset: 0x1543CC1 VA: 0x1543BC0 Slot: 5
	protected override void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CEB0 Offset: 0x13CFB1 VA: 0x13CEB0
	// RVA: 0x1543C60 Offset: 0x1543D61 VA: 0x1543C60
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x1543D10 Offset: 0x1543E11 VA: 0x1543D10 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1543F30 Offset: 0x1544031 VA: 0x1543F30
	private void OnSelectedItemChanged(object arg0) { }

	// RVA: 0x1543FF0 Offset: 0x15440F1 VA: 0x1543FF0 Slot: 6
	protected override void Update() { }

	// RVA: 0x15440A0 Offset: 0x15441A1 VA: 0x15440A0
	private void Refresh() { }

	// RVA: 0x15438B0 Offset: 0x15439B1 VA: 0x15438B0
	private void SetIsDirty() { }

	// RVA: 0x1544440 Offset: 0x1544541 VA: 0x1544440
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1544450 Offset: 0x1544551 VA: 0x1544450
	public void .ctor() { }
}

public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 5581
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	[SerializeField] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	[SerializeField] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	private ScrollRect _consoleScrollRect; // 0x50
	private bool _isDirty; // 0x58
	private Nullable<Vector2> _scrollPosition; // 0x5C
	private bool _showErrors; // 0x68
	private bool _showInfo; // 0x69
	private bool _showWarnings; // 0x6A
	public Action<ConsoleEntry> SelectedItemChanged; // 0x70
	private string _filter; // 0x78

	// Properties
	public bool ShowErrors { get; set; }
	public bool ShowWarnings { get; set; }
	public bool ShowInfo { get; set; }
	public bool EnableSelection { get; set; }
	public string Filter { get; set; }

	// Methods

	// RVA: 0x1543880 Offset: 0x1543981 VA: 0x1543880
	public bool get_ShowErrors() { }

	// RVA: 0x1543890 Offset: 0x1543991 VA: 0x1543890
	public void set_ShowErrors(bool value) { }

	// RVA: 0x15438C0 Offset: 0x15439C1 VA: 0x15438C0
	public bool get_ShowWarnings() { }

	// RVA: 0x15438D0 Offset: 0x15439D1 VA: 0x15438D0
	public void set_ShowWarnings(bool value) { }

	// RVA: 0x15438F0 Offset: 0x15439F1 VA: 0x15438F0
	public bool get_ShowInfo() { }

	// RVA: 0x1543900 Offset: 0x1543A01 VA: 0x1543900
	public void set_ShowInfo(bool value) { }

	// RVA: 0x1543920 Offset: 0x1543A21 VA: 0x1543920
	public bool get_EnableSelection() { }

	// RVA: 0x1543940 Offset: 0x1543A41 VA: 0x1543940
	public void set_EnableSelection(bool value) { }

	// RVA: 0x1543960 Offset: 0x1543A61 VA: 0x1543960
	public string get_Filter() { }

	// RVA: 0x1543970 Offset: 0x1543A71 VA: 0x1543970
	public void set_Filter(string value) { }

	// RVA: 0x15439D0 Offset: 0x1543AD1 VA: 0x15439D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1543BC0 Offset: 0x1543CC1 VA: 0x1543BC0 Slot: 5
	protected override void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CEB0 Offset: 0x13CFB1 VA: 0x13CEB0
	// RVA: 0x1543C60 Offset: 0x1543D61 VA: 0x1543C60
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x1543D10 Offset: 0x1543E11 VA: 0x1543D10 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1543F30 Offset: 0x1544031 VA: 0x1543F30
	private void OnSelectedItemChanged(object arg0) { }

	// RVA: 0x1543FF0 Offset: 0x15440F1 VA: 0x1543FF0 Slot: 6
	protected override void Update() { }

	// RVA: 0x15440A0 Offset: 0x15441A1 VA: 0x15440A0
	private void Refresh() { }

	// RVA: 0x15438B0 Offset: 0x15439B1 VA: 0x15438B0
	private void SetIsDirty() { }

	// RVA: 0x1544440 Offset: 0x1544541 VA: 0x1544440
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1544450 Offset: 0x1544551 VA: 0x1544450
	public void .ctor() { }
}

public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 5581
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	[SerializeField] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	[SerializeField] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	private ScrollRect _consoleScrollRect; // 0x50
	private bool _isDirty; // 0x58
	private Nullable<Vector2> _scrollPosition; // 0x5C
	private bool _showErrors; // 0x68
	private bool _showInfo; // 0x69
	private bool _showWarnings; // 0x6A
	public Action<ConsoleEntry> SelectedItemChanged; // 0x70
	private string _filter; // 0x78

	// Properties
	public bool ShowErrors { get; set; }
	public bool ShowWarnings { get; set; }
	public bool ShowInfo { get; set; }
	public bool EnableSelection { get; set; }
	public string Filter { get; set; }

	// Methods

	// RVA: 0x1543880 Offset: 0x1543981 VA: 0x1543880
	public bool get_ShowErrors() { }

	// RVA: 0x1543890 Offset: 0x1543991 VA: 0x1543890
	public void set_ShowErrors(bool value) { }

	// RVA: 0x15438C0 Offset: 0x15439C1 VA: 0x15438C0
	public bool get_ShowWarnings() { }

	// RVA: 0x15438D0 Offset: 0x15439D1 VA: 0x15438D0
	public void set_ShowWarnings(bool value) { }

	// RVA: 0x15438F0 Offset: 0x15439F1 VA: 0x15438F0
	public bool get_ShowInfo() { }

	// RVA: 0x1543900 Offset: 0x1543A01 VA: 0x1543900
	public void set_ShowInfo(bool value) { }

	// RVA: 0x1543920 Offset: 0x1543A21 VA: 0x1543920
	public bool get_EnableSelection() { }

	// RVA: 0x1543940 Offset: 0x1543A41 VA: 0x1543940
	public void set_EnableSelection(bool value) { }

	// RVA: 0x1543960 Offset: 0x1543A61 VA: 0x1543960
	public string get_Filter() { }

	// RVA: 0x1543970 Offset: 0x1543A71 VA: 0x1543970
	public void set_Filter(string value) { }

	// RVA: 0x15439D0 Offset: 0x1543AD1 VA: 0x15439D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1543BC0 Offset: 0x1543CC1 VA: 0x1543BC0 Slot: 5
	protected override void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CEB0 Offset: 0x13CFB1 VA: 0x13CEB0
	// RVA: 0x1543C60 Offset: 0x1543D61 VA: 0x1543C60
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x1543D10 Offset: 0x1543E11 VA: 0x1543D10 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1543F30 Offset: 0x1544031 VA: 0x1543F30
	private void OnSelectedItemChanged(object arg0) { }

	// RVA: 0x1543FF0 Offset: 0x15440F1 VA: 0x1543FF0 Slot: 6
	protected override void Update() { }

	// RVA: 0x15440A0 Offset: 0x15441A1 VA: 0x15440A0
	private void Refresh() { }

	// RVA: 0x15438B0 Offset: 0x15439B1 VA: 0x15438B0
	private void SetIsDirty() { }

	// RVA: 0x1544440 Offset: 0x1544541 VA: 0x1544440
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1544450 Offset: 0x1544551 VA: 0x1544450
	public void .ctor() { }
}

public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 5581
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	[SerializeField] // RVA: 0x13C770 Offset: 0x13C871 VA: 0x13C770
	private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	[SerializeField] // RVA: 0x13C7B0 Offset: 0x13C8B1 VA: 0x13C7B0
	private ScrollRect _consoleScrollRect; // 0x50
	private bool _isDirty; // 0x58
	private Nullable<Vector2> _scrollPosition; // 0x5C
	private bool _showErrors; // 0x68
	private bool _showInfo; // 0x69
	private bool _showWarnings; // 0x6A
	public Action<ConsoleEntry> SelectedItemChanged; // 0x70
	private string _filter; // 0x78

	// Properties
	public bool ShowErrors { get; set; }
	public bool ShowWarnings { get; set; }
	public bool ShowInfo { get; set; }
	public bool EnableSelection { get; set; }
	public string Filter { get; set; }

	// Methods

	// RVA: 0x1543880 Offset: 0x1543981 VA: 0x1543880
	public bool get_ShowErrors() { }

	// RVA: 0x1543890 Offset: 0x1543991 VA: 0x1543890
	public void set_ShowErrors(bool value) { }

	// RVA: 0x15438C0 Offset: 0x15439C1 VA: 0x15438C0
	public bool get_ShowWarnings() { }

	// RVA: 0x15438D0 Offset: 0x15439D1 VA: 0x15438D0
	public void set_ShowWarnings(bool value) { }

	// RVA: 0x15438F0 Offset: 0x15439F1 VA: 0x15438F0
	public bool get_ShowInfo() { }

	// RVA: 0x1543900 Offset: 0x1543A01 VA: 0x1543900
	public void set_ShowInfo(bool value) { }

	// RVA: 0x1543920 Offset: 0x1543A21 VA: 0x1543920
	public bool get_EnableSelection() { }

	// RVA: 0x1543940 Offset: 0x1543A41 VA: 0x1543940
	public void set_EnableSelection(bool value) { }

	// RVA: 0x1543960 Offset: 0x1543A61 VA: 0x1543960
	public string get_Filter() { }

	// RVA: 0x1543970 Offset: 0x1543A71 VA: 0x1543970
	public void set_Filter(string value) { }

	// RVA: 0x15439D0 Offset: 0x1543AD1 VA: 0x15439D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1543BC0 Offset: 0x1543CC1 VA: 0x1543BC0 Slot: 5
	protected override void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CEB0 Offset: 0x13CFB1 VA: 0x13CEB0
	// RVA: 0x1543C60 Offset: 0x1543D61 VA: 0x1543C60
	private IEnumerator ScrollToBottom() { }

	// RVA: 0x1543D10 Offset: 0x1543E11 VA: 0x1543D10 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1543F30 Offset: 0x1544031 VA: 0x1543F30
	private void OnSelectedItemChanged(object arg0) { }

	// RVA: 0x1543FF0 Offset: 0x15440F1 VA: 0x1543FF0 Slot: 6
	protected override void Update() { }

	// RVA: 0x15440A0 Offset: 0x15441A1 VA: 0x15440A0
	private void Refresh() { }

	// RVA: 0x15438B0 Offset: 0x15439B1 VA: 0x15438B0
	private void SetIsDirty() { }

	// RVA: 0x1544440 Offset: 0x1544541 VA: 0x1544440
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1544450 Offset: 0x1544551 VA: 0x1544450
	public void .ctor() { }
}

