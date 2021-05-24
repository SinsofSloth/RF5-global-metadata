public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 5553
{
	// Fields
	private readonly List<OptionsControlBase> _controls; // 0x48
	private readonly List<OptionsTabController.CategoryInstance> _categories; // 0x50
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
	private bool _queueRefresh; // 0x60
	private bool _selectionModeEnabled; // 0x61
	private Canvas _optionCanvas; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C260 Offset: 0x13C361 VA: 0x13C260
	public ActionControl ActionControlPrefab; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C270 Offset: 0x13C371 VA: 0x13C270
	public CategoryGroup CategoryGroupPrefab; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C280 Offset: 0x13C381 VA: 0x13C280
	public RectTransform ContentContainer; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C290 Offset: 0x13C391 VA: 0x13C290
	public GameObject NoOptionsNotice; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C2A0 Offset: 0x13C3A1 VA: 0x13C2A0
	public Toggle PinButton; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C2B0 Offset: 0x13C3B1 VA: 0x13C2B0
	public GameObject PinPromptSpacer; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C2C0 Offset: 0x13C3C1 VA: 0x13C2C0
	public GameObject PinPromptText; // 0xA0
	private bool _isTogglingCategory; // 0xA8

	// Methods

	// RVA: 0x1B35730 Offset: 0x1B35831 VA: 0x1B35730 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B360C0 Offset: 0x1B361C1 VA: 0x1B360C0
	private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) { }

	// RVA: 0x1B36170 Offset: 0x1B36271 VA: 0x1B36170
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x1B36340 Offset: 0x1B36441 VA: 0x1B36340
	private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x1B36350 Offset: 0x1B36451 VA: 0x1B36350 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B36460 Offset: 0x1B36561 VA: 0x1B36460 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B368F0 Offset: 0x1B369F1 VA: 0x1B368F0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B36AF0 Offset: 0x1B36BF1 VA: 0x1B36AF0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B36580 Offset: 0x1B36681 VA: 0x1B36580
	public void SetSelectionModeEnabled(bool isEnabled) { }

	// RVA: 0x1B36930 Offset: 0x1B36A31 VA: 0x1B36930
	private void Refresh() { }

	// RVA: 0x1B36DB0 Offset: 0x1B36EB1 VA: 0x1B36DB0
	private void CommitPinnedOptions() { }

	// RVA: 0x1B36BD0 Offset: 0x1B36CD1 VA: 0x1B36BD0
	private void RefreshCategorySelection() { }

	// RVA: 0x1B371C0 Offset: 0x1B372C1 VA: 0x1B371C0
	private void OnOptionSelectionToggle(bool selected) { }

	// RVA: 0x1B371F0 Offset: 0x1B372F1 VA: 0x1B371F0
	private void OnCategorySelectionToggle(OptionsTabController.CategoryInstance category, bool selected) { }

	// RVA: 0x1B35A30 Offset: 0x1B35B31 VA: 0x1B35A30
	protected void Populate() { }

	// RVA: 0x1B372C0 Offset: 0x1B373C1 VA: 0x1B372C0
	protected void CreateCategory(string title, List<OptionDefinition> options) { }

	// RVA: 0x1B361A0 Offset: 0x1B362A1 VA: 0x1B361A0
	private void Clear() { }

	// RVA: 0x1B37B40 Offset: 0x1B37C41 VA: 0x1B37B40
	public void .ctor() { }
}

public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 5553
{
	// Fields
	private readonly List<OptionsControlBase> _controls; // 0x48
	private readonly List<OptionsTabController.CategoryInstance> _categories; // 0x50
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
	private bool _queueRefresh; // 0x60
	private bool _selectionModeEnabled; // 0x61
	private Canvas _optionCanvas; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C260 Offset: 0x13C361 VA: 0x13C260
	public ActionControl ActionControlPrefab; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C270 Offset: 0x13C371 VA: 0x13C270
	public CategoryGroup CategoryGroupPrefab; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C280 Offset: 0x13C381 VA: 0x13C280
	public RectTransform ContentContainer; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C290 Offset: 0x13C391 VA: 0x13C290
	public GameObject NoOptionsNotice; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C2A0 Offset: 0x13C3A1 VA: 0x13C2A0
	public Toggle PinButton; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C2B0 Offset: 0x13C3B1 VA: 0x13C2B0
	public GameObject PinPromptSpacer; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C2C0 Offset: 0x13C3C1 VA: 0x13C2C0
	public GameObject PinPromptText; // 0xA0
	private bool _isTogglingCategory; // 0xA8

	// Methods

	// RVA: 0x1B35730 Offset: 0x1B35831 VA: 0x1B35730 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B360C0 Offset: 0x1B361C1 VA: 0x1B360C0
	private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) { }

	// RVA: 0x1B36170 Offset: 0x1B36271 VA: 0x1B36170
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x1B36340 Offset: 0x1B36441 VA: 0x1B36340
	private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x1B36350 Offset: 0x1B36451 VA: 0x1B36350 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B36460 Offset: 0x1B36561 VA: 0x1B36460 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B368F0 Offset: 0x1B369F1 VA: 0x1B368F0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B36AF0 Offset: 0x1B36BF1 VA: 0x1B36AF0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B36580 Offset: 0x1B36681 VA: 0x1B36580
	public void SetSelectionModeEnabled(bool isEnabled) { }

	// RVA: 0x1B36930 Offset: 0x1B36A31 VA: 0x1B36930
	private void Refresh() { }

	// RVA: 0x1B36DB0 Offset: 0x1B36EB1 VA: 0x1B36DB0
	private void CommitPinnedOptions() { }

	// RVA: 0x1B36BD0 Offset: 0x1B36CD1 VA: 0x1B36BD0
	private void RefreshCategorySelection() { }

	// RVA: 0x1B371C0 Offset: 0x1B372C1 VA: 0x1B371C0
	private void OnOptionSelectionToggle(bool selected) { }

	// RVA: 0x1B371F0 Offset: 0x1B372F1 VA: 0x1B371F0
	private void OnCategorySelectionToggle(OptionsTabController.CategoryInstance category, bool selected) { }

	// RVA: 0x1B35A30 Offset: 0x1B35B31 VA: 0x1B35A30
	protected void Populate() { }

	// RVA: 0x1B372C0 Offset: 0x1B373C1 VA: 0x1B372C0
	protected void CreateCategory(string title, List<OptionDefinition> options) { }

	// RVA: 0x1B361A0 Offset: 0x1B362A1 VA: 0x1B361A0
	private void Clear() { }

	// RVA: 0x1B37B40 Offset: 0x1B37C41 VA: 0x1B37B40
	public void .ctor() { }
}

public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 5553
{
	// Fields
	private readonly List<OptionsControlBase> _controls; // 0x48
	private readonly List<OptionsTabController.CategoryInstance> _categories; // 0x50
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
	private bool _queueRefresh; // 0x60
	private bool _selectionModeEnabled; // 0x61
	private Canvas _optionCanvas; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C260 Offset: 0x13C361 VA: 0x13C260
	public ActionControl ActionControlPrefab; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C270 Offset: 0x13C371 VA: 0x13C270
	public CategoryGroup CategoryGroupPrefab; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C280 Offset: 0x13C381 VA: 0x13C280
	public RectTransform ContentContainer; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C290 Offset: 0x13C391 VA: 0x13C290
	public GameObject NoOptionsNotice; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C2A0 Offset: 0x13C3A1 VA: 0x13C2A0
	public Toggle PinButton; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C2B0 Offset: 0x13C3B1 VA: 0x13C2B0
	public GameObject PinPromptSpacer; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C2C0 Offset: 0x13C3C1 VA: 0x13C2C0
	public GameObject PinPromptText; // 0xA0
	private bool _isTogglingCategory; // 0xA8

	// Methods

	// RVA: 0x1B35730 Offset: 0x1B35831 VA: 0x1B35730 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B360C0 Offset: 0x1B361C1 VA: 0x1B360C0
	private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) { }

	// RVA: 0x1B36170 Offset: 0x1B36271 VA: 0x1B36170
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x1B36340 Offset: 0x1B36441 VA: 0x1B36340
	private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x1B36350 Offset: 0x1B36451 VA: 0x1B36350 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B36460 Offset: 0x1B36561 VA: 0x1B36460 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B368F0 Offset: 0x1B369F1 VA: 0x1B368F0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B36AF0 Offset: 0x1B36BF1 VA: 0x1B36AF0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B36580 Offset: 0x1B36681 VA: 0x1B36580
	public void SetSelectionModeEnabled(bool isEnabled) { }

	// RVA: 0x1B36930 Offset: 0x1B36A31 VA: 0x1B36930
	private void Refresh() { }

	// RVA: 0x1B36DB0 Offset: 0x1B36EB1 VA: 0x1B36DB0
	private void CommitPinnedOptions() { }

	// RVA: 0x1B36BD0 Offset: 0x1B36CD1 VA: 0x1B36BD0
	private void RefreshCategorySelection() { }

	// RVA: 0x1B371C0 Offset: 0x1B372C1 VA: 0x1B371C0
	private void OnOptionSelectionToggle(bool selected) { }

	// RVA: 0x1B371F0 Offset: 0x1B372F1 VA: 0x1B371F0
	private void OnCategorySelectionToggle(OptionsTabController.CategoryInstance category, bool selected) { }

	// RVA: 0x1B35A30 Offset: 0x1B35B31 VA: 0x1B35A30
	protected void Populate() { }

	// RVA: 0x1B372C0 Offset: 0x1B373C1 VA: 0x1B372C0
	protected void CreateCategory(string title, List<OptionDefinition> options) { }

	// RVA: 0x1B361A0 Offset: 0x1B362A1 VA: 0x1B361A0
	private void Clear() { }

	// RVA: 0x1B37B40 Offset: 0x1B37C41 VA: 0x1B37B40
	public void .ctor() { }
}

public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 5553
{
	// Fields
	private readonly List<OptionsControlBase> _controls; // 0x48
	private readonly List<OptionsTabController.CategoryInstance> _categories; // 0x50
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
	private bool _queueRefresh; // 0x60
	private bool _selectionModeEnabled; // 0x61
	private Canvas _optionCanvas; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C260 Offset: 0x13C361 VA: 0x13C260
	public ActionControl ActionControlPrefab; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C270 Offset: 0x13C371 VA: 0x13C270
	public CategoryGroup CategoryGroupPrefab; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C280 Offset: 0x13C381 VA: 0x13C280
	public RectTransform ContentContainer; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C290 Offset: 0x13C391 VA: 0x13C290
	public GameObject NoOptionsNotice; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C2A0 Offset: 0x13C3A1 VA: 0x13C2A0
	public Toggle PinButton; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C2B0 Offset: 0x13C3B1 VA: 0x13C2B0
	public GameObject PinPromptSpacer; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C2C0 Offset: 0x13C3C1 VA: 0x13C2C0
	public GameObject PinPromptText; // 0xA0
	private bool _isTogglingCategory; // 0xA8

	// Methods

	// RVA: 0x1B35730 Offset: 0x1B35831 VA: 0x1B35730 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B360C0 Offset: 0x1B361C1 VA: 0x1B360C0
	private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) { }

	// RVA: 0x1B36170 Offset: 0x1B36271 VA: 0x1B36170
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x1B36340 Offset: 0x1B36441 VA: 0x1B36340
	private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x1B36350 Offset: 0x1B36451 VA: 0x1B36350 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B36460 Offset: 0x1B36561 VA: 0x1B36460 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B368F0 Offset: 0x1B369F1 VA: 0x1B368F0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B36AF0 Offset: 0x1B36BF1 VA: 0x1B36AF0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B36580 Offset: 0x1B36681 VA: 0x1B36580
	public void SetSelectionModeEnabled(bool isEnabled) { }

	// RVA: 0x1B36930 Offset: 0x1B36A31 VA: 0x1B36930
	private void Refresh() { }

	// RVA: 0x1B36DB0 Offset: 0x1B36EB1 VA: 0x1B36DB0
	private void CommitPinnedOptions() { }

	// RVA: 0x1B36BD0 Offset: 0x1B36CD1 VA: 0x1B36BD0
	private void RefreshCategorySelection() { }

	// RVA: 0x1B371C0 Offset: 0x1B372C1 VA: 0x1B371C0
	private void OnOptionSelectionToggle(bool selected) { }

	// RVA: 0x1B371F0 Offset: 0x1B372F1 VA: 0x1B371F0
	private void OnCategorySelectionToggle(OptionsTabController.CategoryInstance category, bool selected) { }

	// RVA: 0x1B35A30 Offset: 0x1B35B31 VA: 0x1B35A30
	protected void Populate() { }

	// RVA: 0x1B372C0 Offset: 0x1B373C1 VA: 0x1B372C0
	protected void CreateCategory(string title, List<OptionDefinition> options) { }

	// RVA: 0x1B361A0 Offset: 0x1B362A1 VA: 0x1B361A0
	private void Clear() { }

	// RVA: 0x1B37B40 Offset: 0x1B37C41 VA: 0x1B37B40
	public void .ctor() { }
}

public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 5553
{
	// Fields
	private readonly List<OptionsControlBase> _controls; // 0x48
	private readonly List<OptionsTabController.CategoryInstance> _categories; // 0x50
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
	private bool _queueRefresh; // 0x60
	private bool _selectionModeEnabled; // 0x61
	private Canvas _optionCanvas; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C260 Offset: 0x13C361 VA: 0x13C260
	public ActionControl ActionControlPrefab; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C270 Offset: 0x13C371 VA: 0x13C270
	public CategoryGroup CategoryGroupPrefab; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C280 Offset: 0x13C381 VA: 0x13C280
	public RectTransform ContentContainer; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C290 Offset: 0x13C391 VA: 0x13C290
	public GameObject NoOptionsNotice; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C2A0 Offset: 0x13C3A1 VA: 0x13C2A0
	public Toggle PinButton; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C2B0 Offset: 0x13C3B1 VA: 0x13C2B0
	public GameObject PinPromptSpacer; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C2C0 Offset: 0x13C3C1 VA: 0x13C2C0
	public GameObject PinPromptText; // 0xA0
	private bool _isTogglingCategory; // 0xA8

	// Methods

	// RVA: 0x1B35730 Offset: 0x1B35831 VA: 0x1B35730 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B360C0 Offset: 0x1B361C1 VA: 0x1B360C0
	private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) { }

	// RVA: 0x1B36170 Offset: 0x1B36271 VA: 0x1B36170
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x1B36340 Offset: 0x1B36441 VA: 0x1B36340
	private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x1B36350 Offset: 0x1B36451 VA: 0x1B36350 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B36460 Offset: 0x1B36561 VA: 0x1B36460 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B368F0 Offset: 0x1B369F1 VA: 0x1B368F0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B36AF0 Offset: 0x1B36BF1 VA: 0x1B36AF0
	private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x1B36580 Offset: 0x1B36681 VA: 0x1B36580
	public void SetSelectionModeEnabled(bool isEnabled) { }

	// RVA: 0x1B36930 Offset: 0x1B36A31 VA: 0x1B36930
	private void Refresh() { }

	// RVA: 0x1B36DB0 Offset: 0x1B36EB1 VA: 0x1B36DB0
	private void CommitPinnedOptions() { }

	// RVA: 0x1B36BD0 Offset: 0x1B36CD1 VA: 0x1B36BD0
	private void RefreshCategorySelection() { }

	// RVA: 0x1B371C0 Offset: 0x1B372C1 VA: 0x1B371C0
	private void OnOptionSelectionToggle(bool selected) { }

	// RVA: 0x1B371F0 Offset: 0x1B372F1 VA: 0x1B371F0
	private void OnCategorySelectionToggle(OptionsTabController.CategoryInstance category, bool selected) { }

	// RVA: 0x1B35A30 Offset: 0x1B35B31 VA: 0x1B35A30
	protected void Populate() { }

	// RVA: 0x1B372C0 Offset: 0x1B373C1 VA: 0x1B372C0
	protected void CreateCategory(string title, List<OptionDefinition> options) { }

	// RVA: 0x1B361A0 Offset: 0x1B362A1 VA: 0x1B361A0
	private void Clear() { }

	// RVA: 0x1B37B40 Offset: 0x1B37C41 VA: 0x1B37B40
	public void .ctor() { }
}

