public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 5565
{
	// Fields
	public const float NonFocusOpacity = 0.65;
	private bool _isDirty; // 0x48
	private bool _isDragging; // 0x49
	private int _pointersOver; // 0x4C
	[RequiredFieldAttribute] // RVA: 0x13C400 Offset: 0x13C501 VA: 0x13C400
	public GameObject BottomHandle; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C410 Offset: 0x13C511 VA: 0x13C410
	public CanvasGroup CanvasGroup; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C420 Offset: 0x13C521 VA: 0x13C420
	public ConsoleLogControl Console; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C430 Offset: 0x13C531 VA: 0x13C430
	public GameObject Dropdown; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C440 Offset: 0x13C541 VA: 0x13C440
	public Image DropdownToggleSprite; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C450 Offset: 0x13C551 VA: 0x13C450
	public Text TextErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C460 Offset: 0x13C561 VA: 0x13C460
	public Text TextInfo; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C470 Offset: 0x13C571 VA: 0x13C470
	public Text TextWarnings; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C480 Offset: 0x13C581 VA: 0x13C480
	public Toggle ToggleErrors; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C490 Offset: 0x13C591 VA: 0x13C490
	public Toggle ToggleInfo; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C4A0 Offset: 0x13C5A1 VA: 0x13C4A0
	public Toggle ToggleWarnings; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C4B0 Offset: 0x13C5B1 VA: 0x13C4B0
	public GameObject TopBar; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C4C0 Offset: 0x13C5C1 VA: 0x13C4C0
	public GameObject TopHandle; // 0xB0

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	// RVA: 0x1B30DA0 Offset: 0x1B30EA1 VA: 0x1B30DA0
	public bool get_IsVisible() { }

	// RVA: 0x1B30DD0 Offset: 0x1B30ED1 VA: 0x1B30DD0
	public void set_IsVisible(bool value) { }

	// RVA: 0x1B30E10 Offset: 0x1B30F11 VA: 0x1B30E10 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B31210 Offset: 0x1B31311 VA: 0x1B31210 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B31330 Offset: 0x1B31431 VA: 0x1B31330 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B31380 Offset: 0x1B31481 VA: 0x1B31380 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B313B0 Offset: 0x1B314B1 VA: 0x1B313B0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B313F0 Offset: 0x1B314F1 VA: 0x1B313F0
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B31400 Offset: 0x1B31501 VA: 0x1B31400
	public void SetDropdownVisibility(bool visible) { }

	// RVA: 0x1B314E0 Offset: 0x1B315E1 VA: 0x1B314E0
	public void SetAlignmentMode(ConsoleAlignment alignment) { }

	// RVA: 0x1B30F60 Offset: 0x1B31061 VA: 0x1B30F60
	private void Refresh() { }

	// RVA: 0x1B311B0 Offset: 0x1B312B1 VA: 0x1B311B0
	private void RefreshAlpha() { }

	// RVA: 0x1B31720 Offset: 0x1B31821 VA: 0x1B31720
	public void ToggleDropdownVisible() { }

	// RVA: 0x1B31760 Offset: 0x1B31861 VA: 0x1B31760
	public void MenuButtonPressed() { }

	// RVA: 0x1B31820 Offset: 0x1B31921 VA: 0x1B31820
	public void ClearButtonPressed() { }

	// RVA: 0x1B318E0 Offset: 0x1B319E1 VA: 0x1B318E0
	public void TogglesUpdated() { }

	// RVA: 0x1B31960 Offset: 0x1B31A61 VA: 0x1B31960 Slot: 11
	public void OnPointerEnter(PointerEventData e) { }

	// RVA: 0x1B31990 Offset: 0x1B31A91 VA: 0x1B31990 Slot: 12
	public void OnPointerExit(PointerEventData e) { }

	// RVA: 0x1B319E0 Offset: 0x1B31AE1 VA: 0x1B319E0
	public void OnBeginDrag() { }

	// RVA: 0x1B31A10 Offset: 0x1B31B11 VA: 0x1B31A10
	public void OnEndDrag() { }

	// RVA: 0x1B31A40 Offset: 0x1B31B41 VA: 0x1B31A40
	public void .ctor() { }
}

public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 5565
{
	// Fields
	public const float NonFocusOpacity = 0.65;
	private bool _isDirty; // 0x48
	private bool _isDragging; // 0x49
	private int _pointersOver; // 0x4C
	[RequiredFieldAttribute] // RVA: 0x13C400 Offset: 0x13C501 VA: 0x13C400
	public GameObject BottomHandle; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C410 Offset: 0x13C511 VA: 0x13C410
	public CanvasGroup CanvasGroup; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C420 Offset: 0x13C521 VA: 0x13C420
	public ConsoleLogControl Console; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C430 Offset: 0x13C531 VA: 0x13C430
	public GameObject Dropdown; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C440 Offset: 0x13C541 VA: 0x13C440
	public Image DropdownToggleSprite; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C450 Offset: 0x13C551 VA: 0x13C450
	public Text TextErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C460 Offset: 0x13C561 VA: 0x13C460
	public Text TextInfo; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C470 Offset: 0x13C571 VA: 0x13C470
	public Text TextWarnings; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C480 Offset: 0x13C581 VA: 0x13C480
	public Toggle ToggleErrors; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C490 Offset: 0x13C591 VA: 0x13C490
	public Toggle ToggleInfo; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C4A0 Offset: 0x13C5A1 VA: 0x13C4A0
	public Toggle ToggleWarnings; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C4B0 Offset: 0x13C5B1 VA: 0x13C4B0
	public GameObject TopBar; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C4C0 Offset: 0x13C5C1 VA: 0x13C4C0
	public GameObject TopHandle; // 0xB0

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	// RVA: 0x1B30DA0 Offset: 0x1B30EA1 VA: 0x1B30DA0
	public bool get_IsVisible() { }

	// RVA: 0x1B30DD0 Offset: 0x1B30ED1 VA: 0x1B30DD0
	public void set_IsVisible(bool value) { }

	// RVA: 0x1B30E10 Offset: 0x1B30F11 VA: 0x1B30E10 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B31210 Offset: 0x1B31311 VA: 0x1B31210 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B31330 Offset: 0x1B31431 VA: 0x1B31330 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B31380 Offset: 0x1B31481 VA: 0x1B31380 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B313B0 Offset: 0x1B314B1 VA: 0x1B313B0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B313F0 Offset: 0x1B314F1 VA: 0x1B313F0
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B31400 Offset: 0x1B31501 VA: 0x1B31400
	public void SetDropdownVisibility(bool visible) { }

	// RVA: 0x1B314E0 Offset: 0x1B315E1 VA: 0x1B314E0
	public void SetAlignmentMode(ConsoleAlignment alignment) { }

	// RVA: 0x1B30F60 Offset: 0x1B31061 VA: 0x1B30F60
	private void Refresh() { }

	// RVA: 0x1B311B0 Offset: 0x1B312B1 VA: 0x1B311B0
	private void RefreshAlpha() { }

	// RVA: 0x1B31720 Offset: 0x1B31821 VA: 0x1B31720
	public void ToggleDropdownVisible() { }

	// RVA: 0x1B31760 Offset: 0x1B31861 VA: 0x1B31760
	public void MenuButtonPressed() { }

	// RVA: 0x1B31820 Offset: 0x1B31921 VA: 0x1B31820
	public void ClearButtonPressed() { }

	// RVA: 0x1B318E0 Offset: 0x1B319E1 VA: 0x1B318E0
	public void TogglesUpdated() { }

	// RVA: 0x1B31960 Offset: 0x1B31A61 VA: 0x1B31960 Slot: 11
	public void OnPointerEnter(PointerEventData e) { }

	// RVA: 0x1B31990 Offset: 0x1B31A91 VA: 0x1B31990 Slot: 12
	public void OnPointerExit(PointerEventData e) { }

	// RVA: 0x1B319E0 Offset: 0x1B31AE1 VA: 0x1B319E0
	public void OnBeginDrag() { }

	// RVA: 0x1B31A10 Offset: 0x1B31B11 VA: 0x1B31A10
	public void OnEndDrag() { }

	// RVA: 0x1B31A40 Offset: 0x1B31B41 VA: 0x1B31A40
	public void .ctor() { }
}

public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 5565
{
	// Fields
	public const float NonFocusOpacity = 0.65;
	private bool _isDirty; // 0x48
	private bool _isDragging; // 0x49
	private int _pointersOver; // 0x4C
	[RequiredFieldAttribute] // RVA: 0x13C400 Offset: 0x13C501 VA: 0x13C400
	public GameObject BottomHandle; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C410 Offset: 0x13C511 VA: 0x13C410
	public CanvasGroup CanvasGroup; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C420 Offset: 0x13C521 VA: 0x13C420
	public ConsoleLogControl Console; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C430 Offset: 0x13C531 VA: 0x13C430
	public GameObject Dropdown; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C440 Offset: 0x13C541 VA: 0x13C440
	public Image DropdownToggleSprite; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C450 Offset: 0x13C551 VA: 0x13C450
	public Text TextErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C460 Offset: 0x13C561 VA: 0x13C460
	public Text TextInfo; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C470 Offset: 0x13C571 VA: 0x13C470
	public Text TextWarnings; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C480 Offset: 0x13C581 VA: 0x13C480
	public Toggle ToggleErrors; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C490 Offset: 0x13C591 VA: 0x13C490
	public Toggle ToggleInfo; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C4A0 Offset: 0x13C5A1 VA: 0x13C4A0
	public Toggle ToggleWarnings; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C4B0 Offset: 0x13C5B1 VA: 0x13C4B0
	public GameObject TopBar; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C4C0 Offset: 0x13C5C1 VA: 0x13C4C0
	public GameObject TopHandle; // 0xB0

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	// RVA: 0x1B30DA0 Offset: 0x1B30EA1 VA: 0x1B30DA0
	public bool get_IsVisible() { }

	// RVA: 0x1B30DD0 Offset: 0x1B30ED1 VA: 0x1B30DD0
	public void set_IsVisible(bool value) { }

	// RVA: 0x1B30E10 Offset: 0x1B30F11 VA: 0x1B30E10 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B31210 Offset: 0x1B31311 VA: 0x1B31210 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B31330 Offset: 0x1B31431 VA: 0x1B31330 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B31380 Offset: 0x1B31481 VA: 0x1B31380 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B313B0 Offset: 0x1B314B1 VA: 0x1B313B0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B313F0 Offset: 0x1B314F1 VA: 0x1B313F0
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B31400 Offset: 0x1B31501 VA: 0x1B31400
	public void SetDropdownVisibility(bool visible) { }

	// RVA: 0x1B314E0 Offset: 0x1B315E1 VA: 0x1B314E0
	public void SetAlignmentMode(ConsoleAlignment alignment) { }

	// RVA: 0x1B30F60 Offset: 0x1B31061 VA: 0x1B30F60
	private void Refresh() { }

	// RVA: 0x1B311B0 Offset: 0x1B312B1 VA: 0x1B311B0
	private void RefreshAlpha() { }

	// RVA: 0x1B31720 Offset: 0x1B31821 VA: 0x1B31720
	public void ToggleDropdownVisible() { }

	// RVA: 0x1B31760 Offset: 0x1B31861 VA: 0x1B31760
	public void MenuButtonPressed() { }

	// RVA: 0x1B31820 Offset: 0x1B31921 VA: 0x1B31820
	public void ClearButtonPressed() { }

	// RVA: 0x1B318E0 Offset: 0x1B319E1 VA: 0x1B318E0
	public void TogglesUpdated() { }

	// RVA: 0x1B31960 Offset: 0x1B31A61 VA: 0x1B31960 Slot: 11
	public void OnPointerEnter(PointerEventData e) { }

	// RVA: 0x1B31990 Offset: 0x1B31A91 VA: 0x1B31990 Slot: 12
	public void OnPointerExit(PointerEventData e) { }

	// RVA: 0x1B319E0 Offset: 0x1B31AE1 VA: 0x1B319E0
	public void OnBeginDrag() { }

	// RVA: 0x1B31A10 Offset: 0x1B31B11 VA: 0x1B31A10
	public void OnEndDrag() { }

	// RVA: 0x1B31A40 Offset: 0x1B31B41 VA: 0x1B31A40
	public void .ctor() { }
}

public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 5565
{
	// Fields
	public const float NonFocusOpacity = 0.65;
	private bool _isDirty; // 0x48
	private bool _isDragging; // 0x49
	private int _pointersOver; // 0x4C
	[RequiredFieldAttribute] // RVA: 0x13C400 Offset: 0x13C501 VA: 0x13C400
	public GameObject BottomHandle; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C410 Offset: 0x13C511 VA: 0x13C410
	public CanvasGroup CanvasGroup; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C420 Offset: 0x13C521 VA: 0x13C420
	public ConsoleLogControl Console; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C430 Offset: 0x13C531 VA: 0x13C430
	public GameObject Dropdown; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C440 Offset: 0x13C541 VA: 0x13C440
	public Image DropdownToggleSprite; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C450 Offset: 0x13C551 VA: 0x13C450
	public Text TextErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C460 Offset: 0x13C561 VA: 0x13C460
	public Text TextInfo; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C470 Offset: 0x13C571 VA: 0x13C470
	public Text TextWarnings; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C480 Offset: 0x13C581 VA: 0x13C480
	public Toggle ToggleErrors; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C490 Offset: 0x13C591 VA: 0x13C490
	public Toggle ToggleInfo; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C4A0 Offset: 0x13C5A1 VA: 0x13C4A0
	public Toggle ToggleWarnings; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C4B0 Offset: 0x13C5B1 VA: 0x13C4B0
	public GameObject TopBar; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C4C0 Offset: 0x13C5C1 VA: 0x13C4C0
	public GameObject TopHandle; // 0xB0

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	// RVA: 0x1B30DA0 Offset: 0x1B30EA1 VA: 0x1B30DA0
	public bool get_IsVisible() { }

	// RVA: 0x1B30DD0 Offset: 0x1B30ED1 VA: 0x1B30DD0
	public void set_IsVisible(bool value) { }

	// RVA: 0x1B30E10 Offset: 0x1B30F11 VA: 0x1B30E10 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B31210 Offset: 0x1B31311 VA: 0x1B31210 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B31330 Offset: 0x1B31431 VA: 0x1B31330 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B31380 Offset: 0x1B31481 VA: 0x1B31380 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B313B0 Offset: 0x1B314B1 VA: 0x1B313B0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B313F0 Offset: 0x1B314F1 VA: 0x1B313F0
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B31400 Offset: 0x1B31501 VA: 0x1B31400
	public void SetDropdownVisibility(bool visible) { }

	// RVA: 0x1B314E0 Offset: 0x1B315E1 VA: 0x1B314E0
	public void SetAlignmentMode(ConsoleAlignment alignment) { }

	// RVA: 0x1B30F60 Offset: 0x1B31061 VA: 0x1B30F60
	private void Refresh() { }

	// RVA: 0x1B311B0 Offset: 0x1B312B1 VA: 0x1B311B0
	private void RefreshAlpha() { }

	// RVA: 0x1B31720 Offset: 0x1B31821 VA: 0x1B31720
	public void ToggleDropdownVisible() { }

	// RVA: 0x1B31760 Offset: 0x1B31861 VA: 0x1B31760
	public void MenuButtonPressed() { }

	// RVA: 0x1B31820 Offset: 0x1B31921 VA: 0x1B31820
	public void ClearButtonPressed() { }

	// RVA: 0x1B318E0 Offset: 0x1B319E1 VA: 0x1B318E0
	public void TogglesUpdated() { }

	// RVA: 0x1B31960 Offset: 0x1B31A61 VA: 0x1B31960 Slot: 11
	public void OnPointerEnter(PointerEventData e) { }

	// RVA: 0x1B31990 Offset: 0x1B31A91 VA: 0x1B31990 Slot: 12
	public void OnPointerExit(PointerEventData e) { }

	// RVA: 0x1B319E0 Offset: 0x1B31AE1 VA: 0x1B319E0
	public void OnBeginDrag() { }

	// RVA: 0x1B31A10 Offset: 0x1B31B11 VA: 0x1B31A10
	public void OnEndDrag() { }

	// RVA: 0x1B31A40 Offset: 0x1B31B41 VA: 0x1B31A40
	public void .ctor() { }
}

public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 5565
{
	// Fields
	public const float NonFocusOpacity = 0.65;
	private bool _isDirty; // 0x48
	private bool _isDragging; // 0x49
	private int _pointersOver; // 0x4C
	[RequiredFieldAttribute] // RVA: 0x13C400 Offset: 0x13C501 VA: 0x13C400
	public GameObject BottomHandle; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C410 Offset: 0x13C511 VA: 0x13C410
	public CanvasGroup CanvasGroup; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C420 Offset: 0x13C521 VA: 0x13C420
	public ConsoleLogControl Console; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C430 Offset: 0x13C531 VA: 0x13C430
	public GameObject Dropdown; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C440 Offset: 0x13C541 VA: 0x13C440
	public Image DropdownToggleSprite; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C450 Offset: 0x13C551 VA: 0x13C450
	public Text TextErrors; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C460 Offset: 0x13C561 VA: 0x13C460
	public Text TextInfo; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13C470 Offset: 0x13C571 VA: 0x13C470
	public Text TextWarnings; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C480 Offset: 0x13C581 VA: 0x13C480
	public Toggle ToggleErrors; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C490 Offset: 0x13C591 VA: 0x13C490
	public Toggle ToggleInfo; // 0x98
	[RequiredFieldAttribute] // RVA: 0x13C4A0 Offset: 0x13C5A1 VA: 0x13C4A0
	public Toggle ToggleWarnings; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C4B0 Offset: 0x13C5B1 VA: 0x13C4B0
	public GameObject TopBar; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13C4C0 Offset: 0x13C5C1 VA: 0x13C4C0
	public GameObject TopHandle; // 0xB0

	// Properties
	public bool IsVisible { get; set; }

	// Methods

	// RVA: 0x1B30DA0 Offset: 0x1B30EA1 VA: 0x1B30DA0
	public bool get_IsVisible() { }

	// RVA: 0x1B30DD0 Offset: 0x1B30ED1 VA: 0x1B30DD0
	public void set_IsVisible(bool value) { }

	// RVA: 0x1B30E10 Offset: 0x1B30F11 VA: 0x1B30E10 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B31210 Offset: 0x1B31311 VA: 0x1B31210 Slot: 10
	protected override void OnDestroy() { }

	// RVA: 0x1B31330 Offset: 0x1B31431 VA: 0x1B31330 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1B31380 Offset: 0x1B31481 VA: 0x1B31380 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x1B313B0 Offset: 0x1B314B1 VA: 0x1B313B0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1B313F0 Offset: 0x1B314F1 VA: 0x1B313F0
	private void ConsoleOnUpdated(IConsoleService console) { }

	// RVA: 0x1B31400 Offset: 0x1B31501 VA: 0x1B31400
	public void SetDropdownVisibility(bool visible) { }

	// RVA: 0x1B314E0 Offset: 0x1B315E1 VA: 0x1B314E0
	public void SetAlignmentMode(ConsoleAlignment alignment) { }

	// RVA: 0x1B30F60 Offset: 0x1B31061 VA: 0x1B30F60
	private void Refresh() { }

	// RVA: 0x1B311B0 Offset: 0x1B312B1 VA: 0x1B311B0
	private void RefreshAlpha() { }

	// RVA: 0x1B31720 Offset: 0x1B31821 VA: 0x1B31720
	public void ToggleDropdownVisible() { }

	// RVA: 0x1B31760 Offset: 0x1B31861 VA: 0x1B31760
	public void MenuButtonPressed() { }

	// RVA: 0x1B31820 Offset: 0x1B31921 VA: 0x1B31820
	public void ClearButtonPressed() { }

	// RVA: 0x1B318E0 Offset: 0x1B319E1 VA: 0x1B318E0
	public void TogglesUpdated() { }

	// RVA: 0x1B31960 Offset: 0x1B31A61 VA: 0x1B31960 Slot: 11
	public void OnPointerEnter(PointerEventData e) { }

	// RVA: 0x1B31990 Offset: 0x1B31A91 VA: 0x1B31990 Slot: 12
	public void OnPointerExit(PointerEventData e) { }

	// RVA: 0x1B319E0 Offset: 0x1B31AE1 VA: 0x1B319E0
	public void OnBeginDrag() { }

	// RVA: 0x1B31A10 Offset: 0x1B31B11 VA: 0x1B31A10
	public void OnEndDrag() { }

	// RVA: 0x1B31A40 Offset: 0x1B31B41 VA: 0x1B31A40
	public void .ctor() { }
}

