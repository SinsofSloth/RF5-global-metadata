public class Settings : ScriptableObject // TypeDefIndex: 5539
{
	// Fields
	private const string ResourcesPath = "/usr/Resources/SRDebugger";
	private const string ResourcesName = "Settings";
	private static Settings _instance; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13BE00 Offset: 0x13BF01 VA: 0x13BE00
	private PropertyChangedEventHandler PropertyChanged; // 0x18
	[SerializeField] // RVA: 0x13BE10 Offset: 0x13BF11 VA: 0x13BE10
	private bool _isEnabled; // 0x20
	[SerializeField] // RVA: 0x13BE20 Offset: 0x13BF21 VA: 0x13BE20
	private DefaultTabs _defaultTab; // 0x24
	[SerializeField] // RVA: 0x13BE30 Offset: 0x13BF31 VA: 0x13BE30
	private Settings.TriggerEnableModes _triggerEnableMode; // 0x28
	[SerializeField] // RVA: 0x13BE40 Offset: 0x13BF41 VA: 0x13BE40
	private Settings.TriggerBehaviours _triggerBehaviour; // 0x2C
	[SerializeField] // RVA: 0x13BE50 Offset: 0x13BF51 VA: 0x13BE50
	private bool _errorNotification; // 0x30
	[SerializeField] // RVA: 0x13BE60 Offset: 0x13BF61 VA: 0x13BE60
	private bool _enableKeyboardShortcuts; // 0x31
	[SerializeField] // RVA: 0x13BE70 Offset: 0x13BF71 VA: 0x13BE70
	private Settings.KeyboardShortcut[] _keyboardShortcuts; // 0x38
	[SerializeField] // RVA: 0x13BE80 Offset: 0x13BF81 VA: 0x13BE80
	private Settings.KeyboardShortcut[] _newKeyboardShortcuts; // 0x40
	[SerializeField] // RVA: 0x13BE90 Offset: 0x13BF91 VA: 0x13BE90
	private bool _keyboardModifierControl; // 0x48
	[SerializeField] // RVA: 0x13BEA0 Offset: 0x13BFA1 VA: 0x13BEA0
	private bool _keyboardModifierAlt; // 0x49
	[SerializeField] // RVA: 0x13BEB0 Offset: 0x13BFB1 VA: 0x13BEB0
	private bool _keyboardModifierShift; // 0x4A
	[SerializeField] // RVA: 0x13BEC0 Offset: 0x13BFC1 VA: 0x13BEC0
	private bool _keyboardEscapeClose; // 0x4B
	[SerializeField] // RVA: 0x13BED0 Offset: 0x13BFD1 VA: 0x13BED0
	private bool _enableBackgroundTransparency; // 0x4C
	[SerializeField] // RVA: 0x13BEE0 Offset: 0x13BFE1 VA: 0x13BEE0
	private bool _collapseDuplicateLogEntries; // 0x4D
	[SerializeField] // RVA: 0x13BEF0 Offset: 0x13BFF1 VA: 0x13BEF0
	private bool _richTextInConsole; // 0x4E
	[SerializeField] // RVA: 0x13BF00 Offset: 0x13C001 VA: 0x13BF00
	private bool _requireEntryCode; // 0x4F
	[SerializeField] // RVA: 0x13BF10 Offset: 0x13C011 VA: 0x13BF10
	private bool _requireEntryCodeEveryTime; // 0x50
	[SerializeField] // RVA: 0x13BF20 Offset: 0x13C021 VA: 0x13BF20
	private int[] _entryCode; // 0x58
	[SerializeField] // RVA: 0x13BF30 Offset: 0x13C031 VA: 0x13BF30
	private bool _useDebugCamera; // 0x60
	[SerializeField] // RVA: 0x13BF40 Offset: 0x13C041 VA: 0x13BF40
	private int _debugLayer; // 0x64
	[SerializeField] // RVA: 0x13BF50 Offset: 0x13C051 VA: 0x13BF50
	[RangeAttribute] // RVA: 0x13BF50 Offset: 0x13C051 VA: 0x13BF50
	private float _debugCameraDepth; // 0x68
	[SerializeField] // RVA: 0x13BFA0 Offset: 0x13C0A1 VA: 0x13BFA0
	private string _apiKey; // 0x70
	[SerializeField] // RVA: 0x13BFB0 Offset: 0x13C0B1 VA: 0x13BFB0
	private bool _enableBugReporter; // 0x78
	[SerializeField] // RVA: 0x13BFC0 Offset: 0x13C0C1 VA: 0x13BFC0
	private DefaultTabs[] _disabledTabs; // 0x80
	[SerializeField] // RVA: 0x13BFD0 Offset: 0x13C0D1 VA: 0x13BFD0
	private PinAlignment _profilerAlignment; // 0x88
	[SerializeField] // RVA: 0x13BFE0 Offset: 0x13C0E1 VA: 0x13BFE0
	private PinAlignment _optionsAlignment; // 0x8C
	[SerializeField] // RVA: 0x13BFF0 Offset: 0x13C0F1 VA: 0x13BFF0
	private ConsoleAlignment _consoleAlignment; // 0x90
	[SerializeField] // RVA: 0x13C000 Offset: 0x13C101 VA: 0x13C000
	private PinAlignment _triggerPosition; // 0x94
	[SerializeField] // RVA: 0x13C010 Offset: 0x13C111 VA: 0x13C010
	private int _maximumConsoleEntries; // 0x98
	[SerializeField] // RVA: 0x13C020 Offset: 0x13C121 VA: 0x13C020
	private bool _enableEventSystemCreation; // 0x9C
	[SerializeField] // RVA: 0x13C030 Offset: 0x13C131 VA: 0x13C030
	private bool _automaticShowCursor; // 0x9D
	[SerializeField] // RVA: 0x13C040 Offset: 0x13C141 VA: 0x13C040
	private float _uiScale; // 0xA0
	[SerializeField] // RVA: 0x13C050 Offset: 0x13C151 VA: 0x13C050
	private bool _unloadOnClose; // 0xA4

	// Properties
	public static Settings Instance { get; }
	public bool IsEnabled { get; }
	public DefaultTabs DefaultTab { get; }
	public Settings.TriggerEnableModes EnableTrigger { get; }
	public Settings.TriggerBehaviours TriggerBehaviour { get; }
	public bool ErrorNotification { get; }
	public bool EnableKeyboardShortcuts { get; }
	public IList<Settings.KeyboardShortcut> KeyboardShortcuts { get; }
	public bool KeyboardEscapeClose { get; }
	public bool EnableBackgroundTransparency { get; }
	public bool RequireCode { get; }
	public bool RequireEntryCodeEveryTime { get; }
	public IList<int> EntryCode { get; set; }
	public bool UseDebugCamera { get; }
	public int DebugLayer { get; }
	public float DebugCameraDepth { get; }
	public bool CollapseDuplicateLogEntries { get; }
	public bool RichTextInConsole { get; }
	public string ApiKey { get; }
	public bool EnableBugReporter { get; }
	public IList<DefaultTabs> DisabledTabs { get; }
	public PinAlignment TriggerPosition { get; }
	public PinAlignment ProfilerAlignment { get; }
	public PinAlignment OptionsAlignment { get; }
	public ConsoleAlignment ConsoleAlignment { get; set; }
	public int MaximumConsoleEntries { get; set; }
	public bool EnableEventSystemGeneration { get; set; }
	public bool AutomaticallyShowCursor { get; }
	public float UIScale { get; set; }
	public bool UnloadOnClose { get; }

	// Methods

	// RVA: 0x152CDC0 Offset: 0x152CEC1 VA: 0x152CDC0
	public static Settings get_Instance() { }

	// RVA: 0x15429D0 Offset: 0x1542AD1 VA: 0x15429D0
	private static Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts() { }

	// RVA: 0x15427C0 Offset: 0x15428C1 VA: 0x15427C0
	private void UpgradeKeyboardShortcuts() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CD50 Offset: 0x13CE51 VA: 0x13CD50
	// RVA: 0x1542BF0 Offset: 0x1542CF1 VA: 0x1542BF0
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CD60 Offset: 0x13CE61 VA: 0x13CD60
	// RVA: 0x1542CA0 Offset: 0x1542DA1 VA: 0x1542CA0
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x1542D50 Offset: 0x1542E51 VA: 0x1542D50
	public bool get_IsEnabled() { }

	// RVA: 0x1542D60 Offset: 0x1542E61 VA: 0x1542D60
	public DefaultTabs get_DefaultTab() { }

	// RVA: 0x1542D70 Offset: 0x1542E71 VA: 0x1542D70
	public Settings.TriggerEnableModes get_EnableTrigger() { }

	// RVA: 0x1542D80 Offset: 0x1542E81 VA: 0x1542D80
	public Settings.TriggerBehaviours get_TriggerBehaviour() { }

	// RVA: 0x1542D90 Offset: 0x1542E91 VA: 0x1542D90
	public bool get_ErrorNotification() { }

	// RVA: 0x1542DA0 Offset: 0x1542EA1 VA: 0x1542DA0
	public bool get_EnableKeyboardShortcuts() { }

	// RVA: 0x1542DB0 Offset: 0x1542EB1 VA: 0x1542DB0
	public IList<Settings.KeyboardShortcut> get_KeyboardShortcuts() { }

	// RVA: 0x1542DC0 Offset: 0x1542EC1 VA: 0x1542DC0
	public bool get_KeyboardEscapeClose() { }

	// RVA: 0x1542DD0 Offset: 0x1542ED1 VA: 0x1542DD0
	public bool get_EnableBackgroundTransparency() { }

	// RVA: 0x1542DE0 Offset: 0x1542EE1 VA: 0x1542DE0
	public bool get_RequireCode() { }

	// RVA: 0x1542DF0 Offset: 0x1542EF1 VA: 0x1542DF0
	public bool get_RequireEntryCodeEveryTime() { }

	// RVA: 0x153C3C0 Offset: 0x153C4C1 VA: 0x153C3C0
	public IList<int> get_EntryCode() { }

	// RVA: 0x1542E00 Offset: 0x1542F01 VA: 0x1542E00
	public void set_EntryCode(IList<int> value) { }

	// RVA: 0x1543010 Offset: 0x1543111 VA: 0x1543010
	public bool get_UseDebugCamera() { }

	// RVA: 0x1543020 Offset: 0x1543121 VA: 0x1543020
	public int get_DebugLayer() { }

	// RVA: 0x1543030 Offset: 0x1543131 VA: 0x1543030
	public float get_DebugCameraDepth() { }

	// RVA: 0x1543040 Offset: 0x1543141 VA: 0x1543040
	public bool get_CollapseDuplicateLogEntries() { }

	// RVA: 0x1543050 Offset: 0x1543151 VA: 0x1543050
	public bool get_RichTextInConsole() { }

	// RVA: 0x1543060 Offset: 0x1543161 VA: 0x1543060
	public string get_ApiKey() { }

	// RVA: 0x1543070 Offset: 0x1543171 VA: 0x1543070
	public bool get_EnableBugReporter() { }

	// RVA: 0x1543080 Offset: 0x1543181 VA: 0x1543080
	public IList<DefaultTabs> get_DisabledTabs() { }

	// RVA: 0x1543090 Offset: 0x1543191 VA: 0x1543090
	public PinAlignment get_TriggerPosition() { }

	// RVA: 0x15430A0 Offset: 0x15431A1 VA: 0x15430A0
	public PinAlignment get_ProfilerAlignment() { }

	// RVA: 0x15430B0 Offset: 0x15431B1 VA: 0x15430B0
	public PinAlignment get_OptionsAlignment() { }

	// RVA: 0x15430C0 Offset: 0x15431C1 VA: 0x15430C0
	public ConsoleAlignment get_ConsoleAlignment() { }

	// RVA: 0x15430D0 Offset: 0x15431D1 VA: 0x15430D0
	public void set_ConsoleAlignment(ConsoleAlignment value) { }

	// RVA: 0x15430E0 Offset: 0x15431E1 VA: 0x15430E0
	public int get_MaximumConsoleEntries() { }

	// RVA: 0x15430F0 Offset: 0x15431F1 VA: 0x15430F0
	public void set_MaximumConsoleEntries(int value) { }

	// RVA: 0x1543100 Offset: 0x1543201 VA: 0x1543100
	public bool get_EnableEventSystemGeneration() { }

	// RVA: 0x1543110 Offset: 0x1543211 VA: 0x1543110
	public void set_EnableEventSystemGeneration(bool value) { }

	// RVA: 0x1543120 Offset: 0x1543221 VA: 0x1543120
	public bool get_AutomaticallyShowCursor() { }

	// RVA: 0x1543130 Offset: 0x1543231 VA: 0x1543130
	public float get_UIScale() { }

	// RVA: 0x1543140 Offset: 0x1543241 VA: 0x1543140
	public void set_UIScale(float value) { }

	// RVA: 0x15432C0 Offset: 0x15433C1 VA: 0x15432C0
	public bool get_UnloadOnClose() { }

	// RVA: 0x1543220 Offset: 0x1543321 VA: 0x1543220
	private void OnPropertyChanged(string propertyName) { }

	// RVA: 0x1542710 Offset: 0x1542811 VA: 0x1542710
	private static Settings GetOrCreateInstance() { }

	// RVA: 0x15432D0 Offset: 0x15433D1 VA: 0x15432D0
	public void .ctor() { }
}

