public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 5549
{
	// Fields
	private Button _closeButton; // 0x48
	[SerializeField] // RVA: 0x13C0F0 Offset: 0x13C1F1 VA: 0x13C0F0
	private float _maxMenuWidth; // 0x50
	[SerializeField] // RVA: 0x13C100 Offset: 0x13C201 VA: 0x13C100
	private float _peekAmount; // 0x54
	private float _targetXPosition; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C110 Offset: 0x13C211 VA: 0x13C110
	public RectTransform Content; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C120 Offset: 0x13C221 VA: 0x13C120
	public RectTransform Menu; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C130 Offset: 0x13C231 VA: 0x13C130
	public Button OpenButton; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C140 Offset: 0x13C241 VA: 0x13C140
	public SRTabController TabController; // 0x78

	// Properties
	public float PeekAmount { get; }
	public float MaxMenuWidth { get; }

	// Methods

	// RVA: 0x1B2E380 Offset: 0x1B2E481 VA: 0x1B2E380
	public float get_PeekAmount() { }

	// RVA: 0x1B2E390 Offset: 0x1B2E491 VA: 0x1B2E390
	public float get_MaxMenuWidth() { }

	// RVA: 0x1B2E3A0 Offset: 0x1B2E4A1 VA: 0x1B2E3A0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B2EB60 Offset: 0x1B2EC61 VA: 0x1B2EB60 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B2E700 Offset: 0x1B2E801 VA: 0x1B2E700
	private void CreateCloseButton() { }

	// RVA: 0x1B2EDC0 Offset: 0x1B2EEC1 VA: 0x1B2EDC0
	private void SetRectSize(RectTransform rect) { }

	// RVA: 0x1B2EEB0 Offset: 0x1B2EFB1 VA: 0x1B2EEB0
	private void CloseButtonClicked() { }

	// RVA: 0x1B2EF30 Offset: 0x1B2F031 VA: 0x1B2EF30 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B2F070 Offset: 0x1B2F171 VA: 0x1B2F070
	private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) { }

	[ContextMenu] // RVA: 0x13CD70 Offset: 0x13CE71 VA: 0x13CD70
	// RVA: 0x1B2F0B0 Offset: 0x1B2F1B1 VA: 0x1B2F0B0
	public void Open() { }

	[ContextMenu] // RVA: 0x13CDB0 Offset: 0x13CEB1 VA: 0x13CDB0
	// RVA: 0x1B2EEF0 Offset: 0x1B2EFF1 VA: 0x1B2EEF0
	public void Close() { }

	// RVA: 0x1B2F130 Offset: 0x1B2F231 VA: 0x1B2F130
	public void .ctor() { }
}

public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 5549
{
	// Fields
	private Button _closeButton; // 0x48
	[SerializeField] // RVA: 0x13C0F0 Offset: 0x13C1F1 VA: 0x13C0F0
	private float _maxMenuWidth; // 0x50
	[SerializeField] // RVA: 0x13C100 Offset: 0x13C201 VA: 0x13C100
	private float _peekAmount; // 0x54
	private float _targetXPosition; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C110 Offset: 0x13C211 VA: 0x13C110
	public RectTransform Content; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C120 Offset: 0x13C221 VA: 0x13C120
	public RectTransform Menu; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C130 Offset: 0x13C231 VA: 0x13C130
	public Button OpenButton; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C140 Offset: 0x13C241 VA: 0x13C140
	public SRTabController TabController; // 0x78

	// Properties
	public float PeekAmount { get; }
	public float MaxMenuWidth { get; }

	// Methods

	// RVA: 0x1B2E380 Offset: 0x1B2E481 VA: 0x1B2E380
	public float get_PeekAmount() { }

	// RVA: 0x1B2E390 Offset: 0x1B2E491 VA: 0x1B2E390
	public float get_MaxMenuWidth() { }

	// RVA: 0x1B2E3A0 Offset: 0x1B2E4A1 VA: 0x1B2E3A0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B2EB60 Offset: 0x1B2EC61 VA: 0x1B2EB60 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B2E700 Offset: 0x1B2E801 VA: 0x1B2E700
	private void CreateCloseButton() { }

	// RVA: 0x1B2EDC0 Offset: 0x1B2EEC1 VA: 0x1B2EDC0
	private void SetRectSize(RectTransform rect) { }

	// RVA: 0x1B2EEB0 Offset: 0x1B2EFB1 VA: 0x1B2EEB0
	private void CloseButtonClicked() { }

	// RVA: 0x1B2EF30 Offset: 0x1B2F031 VA: 0x1B2EF30 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B2F070 Offset: 0x1B2F171 VA: 0x1B2F070
	private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) { }

	[ContextMenu] // RVA: 0x13CD70 Offset: 0x13CE71 VA: 0x13CD70
	// RVA: 0x1B2F0B0 Offset: 0x1B2F1B1 VA: 0x1B2F0B0
	public void Open() { }

	[ContextMenu] // RVA: 0x13CDB0 Offset: 0x13CEB1 VA: 0x13CDB0
	// RVA: 0x1B2EEF0 Offset: 0x1B2EFF1 VA: 0x1B2EEF0
	public void Close() { }

	// RVA: 0x1B2F130 Offset: 0x1B2F231 VA: 0x1B2F130
	public void .ctor() { }
}

public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 5549
{
	// Fields
	private Button _closeButton; // 0x48
	[SerializeField] // RVA: 0x13C0F0 Offset: 0x13C1F1 VA: 0x13C0F0
	private float _maxMenuWidth; // 0x50
	[SerializeField] // RVA: 0x13C100 Offset: 0x13C201 VA: 0x13C100
	private float _peekAmount; // 0x54
	private float _targetXPosition; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C110 Offset: 0x13C211 VA: 0x13C110
	public RectTransform Content; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C120 Offset: 0x13C221 VA: 0x13C120
	public RectTransform Menu; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C130 Offset: 0x13C231 VA: 0x13C130
	public Button OpenButton; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C140 Offset: 0x13C241 VA: 0x13C140
	public SRTabController TabController; // 0x78

	// Properties
	public float PeekAmount { get; }
	public float MaxMenuWidth { get; }

	// Methods

	// RVA: 0x1B2E380 Offset: 0x1B2E481 VA: 0x1B2E380
	public float get_PeekAmount() { }

	// RVA: 0x1B2E390 Offset: 0x1B2E491 VA: 0x1B2E390
	public float get_MaxMenuWidth() { }

	// RVA: 0x1B2E3A0 Offset: 0x1B2E4A1 VA: 0x1B2E3A0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B2EB60 Offset: 0x1B2EC61 VA: 0x1B2EB60 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B2E700 Offset: 0x1B2E801 VA: 0x1B2E700
	private void CreateCloseButton() { }

	// RVA: 0x1B2EDC0 Offset: 0x1B2EEC1 VA: 0x1B2EDC0
	private void SetRectSize(RectTransform rect) { }

	// RVA: 0x1B2EEB0 Offset: 0x1B2EFB1 VA: 0x1B2EEB0
	private void CloseButtonClicked() { }

	// RVA: 0x1B2EF30 Offset: 0x1B2F031 VA: 0x1B2EF30 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B2F070 Offset: 0x1B2F171 VA: 0x1B2F070
	private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) { }

	[ContextMenu] // RVA: 0x13CD70 Offset: 0x13CE71 VA: 0x13CD70
	// RVA: 0x1B2F0B0 Offset: 0x1B2F1B1 VA: 0x1B2F0B0
	public void Open() { }

	[ContextMenu] // RVA: 0x13CDB0 Offset: 0x13CEB1 VA: 0x13CDB0
	// RVA: 0x1B2EEF0 Offset: 0x1B2EFF1 VA: 0x1B2EEF0
	public void Close() { }

	// RVA: 0x1B2F130 Offset: 0x1B2F231 VA: 0x1B2F130
	public void .ctor() { }
}

public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 5549
{
	// Fields
	private Button _closeButton; // 0x48
	[SerializeField] // RVA: 0x13C0F0 Offset: 0x13C1F1 VA: 0x13C0F0
	private float _maxMenuWidth; // 0x50
	[SerializeField] // RVA: 0x13C100 Offset: 0x13C201 VA: 0x13C100
	private float _peekAmount; // 0x54
	private float _targetXPosition; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C110 Offset: 0x13C211 VA: 0x13C110
	public RectTransform Content; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C120 Offset: 0x13C221 VA: 0x13C120
	public RectTransform Menu; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C130 Offset: 0x13C231 VA: 0x13C130
	public Button OpenButton; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C140 Offset: 0x13C241 VA: 0x13C140
	public SRTabController TabController; // 0x78

	// Properties
	public float PeekAmount { get; }
	public float MaxMenuWidth { get; }

	// Methods

	// RVA: 0x1B2E380 Offset: 0x1B2E481 VA: 0x1B2E380
	public float get_PeekAmount() { }

	// RVA: 0x1B2E390 Offset: 0x1B2E491 VA: 0x1B2E390
	public float get_MaxMenuWidth() { }

	// RVA: 0x1B2E3A0 Offset: 0x1B2E4A1 VA: 0x1B2E3A0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B2EB60 Offset: 0x1B2EC61 VA: 0x1B2EB60 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B2E700 Offset: 0x1B2E801 VA: 0x1B2E700
	private void CreateCloseButton() { }

	// RVA: 0x1B2EDC0 Offset: 0x1B2EEC1 VA: 0x1B2EDC0
	private void SetRectSize(RectTransform rect) { }

	// RVA: 0x1B2EEB0 Offset: 0x1B2EFB1 VA: 0x1B2EEB0
	private void CloseButtonClicked() { }

	// RVA: 0x1B2EF30 Offset: 0x1B2F031 VA: 0x1B2EF30 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B2F070 Offset: 0x1B2F171 VA: 0x1B2F070
	private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) { }

	[ContextMenu] // RVA: 0x13CD70 Offset: 0x13CE71 VA: 0x13CD70
	// RVA: 0x1B2F0B0 Offset: 0x1B2F1B1 VA: 0x1B2F0B0
	public void Open() { }

	[ContextMenu] // RVA: 0x13CDB0 Offset: 0x13CEB1 VA: 0x13CDB0
	// RVA: 0x1B2EEF0 Offset: 0x1B2EFF1 VA: 0x1B2EEF0
	public void Close() { }

	// RVA: 0x1B2F130 Offset: 0x1B2F231 VA: 0x1B2F130
	public void .ctor() { }
}

public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 5549
{
	// Fields
	private Button _closeButton; // 0x48
	[SerializeField] // RVA: 0x13C0F0 Offset: 0x13C1F1 VA: 0x13C0F0
	private float _maxMenuWidth; // 0x50
	[SerializeField] // RVA: 0x13C100 Offset: 0x13C201 VA: 0x13C100
	private float _peekAmount; // 0x54
	private float _targetXPosition; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C110 Offset: 0x13C211 VA: 0x13C110
	public RectTransform Content; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C120 Offset: 0x13C221 VA: 0x13C120
	public RectTransform Menu; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C130 Offset: 0x13C231 VA: 0x13C130
	public Button OpenButton; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C140 Offset: 0x13C241 VA: 0x13C140
	public SRTabController TabController; // 0x78

	// Properties
	public float PeekAmount { get; }
	public float MaxMenuWidth { get; }

	// Methods

	// RVA: 0x1B2E380 Offset: 0x1B2E481 VA: 0x1B2E380
	public float get_PeekAmount() { }

	// RVA: 0x1B2E390 Offset: 0x1B2E491 VA: 0x1B2E390
	public float get_MaxMenuWidth() { }

	// RVA: 0x1B2E3A0 Offset: 0x1B2E4A1 VA: 0x1B2E3A0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B2EB60 Offset: 0x1B2EC61 VA: 0x1B2EB60 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B2E700 Offset: 0x1B2E801 VA: 0x1B2E700
	private void CreateCloseButton() { }

	// RVA: 0x1B2EDC0 Offset: 0x1B2EEC1 VA: 0x1B2EDC0
	private void SetRectSize(RectTransform rect) { }

	// RVA: 0x1B2EEB0 Offset: 0x1B2EFB1 VA: 0x1B2EEB0
	private void CloseButtonClicked() { }

	// RVA: 0x1B2EF30 Offset: 0x1B2F031 VA: 0x1B2EF30 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B2F070 Offset: 0x1B2F171 VA: 0x1B2F070
	private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) { }

	[ContextMenu] // RVA: 0x13CD70 Offset: 0x13CE71 VA: 0x13CD70
	// RVA: 0x1B2F0B0 Offset: 0x1B2F1B1 VA: 0x1B2F0B0
	public void Open() { }

	[ContextMenu] // RVA: 0x13CDB0 Offset: 0x13CEB1 VA: 0x13CDB0
	// RVA: 0x1B2EEF0 Offset: 0x1B2EFF1 VA: 0x1B2EEF0
	public void Close() { }

	// RVA: 0x1B2F130 Offset: 0x1B2F231 VA: 0x1B2F130
	public void .ctor() { }
}

