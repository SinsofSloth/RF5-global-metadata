[AddComponentMenu] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
[RequireComponent] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5771
{
	// Fields
	[SerializeField] // RVA: 0x13F250 Offset: 0x13F351 VA: 0x13F250
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x13F260 Offset: 0x13F361 VA: 0x13F260
	private TMP_Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x13F270 Offset: 0x13F371 VA: 0x13F270
	private Image m_CaptionImage; // 0x108
	[SerializeField] // RVA: 0x13F280 Offset: 0x13F381 VA: 0x13F280
	private Graphic m_Placeholder; // 0x110
	[SpaceAttribute] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	[SerializeField] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	private TMP_Text m_ItemText; // 0x118
	[SerializeField] // RVA: 0x13F2D0 Offset: 0x13F3D1 VA: 0x13F2D0
	private Image m_ItemImage; // 0x120
	[SpaceAttribute] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	[SerializeField] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	private int m_Value; // 0x128
	[SpaceAttribute] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	[SerializeField] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	private TMP_Dropdown.OptionDataList m_Options; // 0x130
	[SpaceAttribute] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	[SerializeField] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x13F3A0 Offset: 0x13F4A1 VA: 0x13F3A0
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private Coroutine m_Coroutine; // 0x170
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x15524B0 Offset: 0x15525B1 VA: 0x15524B0
	public RectTransform get_template() { }

	// RVA: 0x1551FD0 Offset: 0x15520D1 VA: 0x1551FD0
	public void set_template(RectTransform value) { }

	// RVA: 0x15524C0 Offset: 0x15525C1 VA: 0x15524C0
	public TMP_Text get_captionText() { }

	// RVA: 0x1552000 Offset: 0x1552101 VA: 0x1552000
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x15524D0 Offset: 0x15525D1 VA: 0x15524D0
	public Image get_captionImage() { }

	// RVA: 0x15524E0 Offset: 0x15525E1 VA: 0x15524E0
	public void set_captionImage(Image value) { }

	// RVA: 0x1552510 Offset: 0x1552611 VA: 0x1552510
	public Graphic get_placeholder() { }

	// RVA: 0x1552520 Offset: 0x1552621 VA: 0x1552520
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1552550 Offset: 0x1552651 VA: 0x1552550
	public TMP_Text get_itemText() { }

	// RVA: 0x1552030 Offset: 0x1552131 VA: 0x1552030
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1552560 Offset: 0x1552661 VA: 0x1552560
	public Image get_itemImage() { }

	// RVA: 0x1552570 Offset: 0x1552671 VA: 0x1552570
	public void set_itemImage(Image value) { }

	// RVA: 0x1552060 Offset: 0x1552161 VA: 0x1552060
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x15525A0 Offset: 0x15526A1 VA: 0x15525A0
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x15525E0 Offset: 0x15526E1 VA: 0x15525E0
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x15525F0 Offset: 0x15526F1 VA: 0x15525F0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x1552600 Offset: 0x1552701 VA: 0x1552600
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1552610 Offset: 0x1552711 VA: 0x1552610
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1552620 Offset: 0x1552721 VA: 0x1552620
	public int get_value() { }

	// RVA: 0x1552630 Offset: 0x1552731 VA: 0x1552630
	public void set_value(int value) { }

	// RVA: 0x15527A0 Offset: 0x15528A1 VA: 0x15527A0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1552640 Offset: 0x1552741 VA: 0x1552640
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x15527B0 Offset: 0x15528B1 VA: 0x15527B0
	public bool get_IsExpanded() { }

	// RVA: 0x1552820 Offset: 0x1552921 VA: 0x1552820
	protected void .ctor() { }

	// RVA: 0x1552A90 Offset: 0x1552B91 VA: 0x1552A90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1552C20 Offset: 0x1552D21 VA: 0x1552C20 Slot: 6
	protected override void Start() { }

	// RVA: 0x1552C50 Offset: 0x1552D51 VA: 0x1552C50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1552090 Offset: 0x1552191 VA: 0x1552090
	public void RefreshShownValue() { }

	// RVA: 0x1552EB0 Offset: 0x1552FB1 VA: 0x1552EB0
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1552F30 Offset: 0x1553031 VA: 0x1552F30
	public void AddOptions(List<string> options) { }

	// RVA: 0x1553070 Offset: 0x1553171 VA: 0x1553070
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x15531B0 Offset: 0x15532B1 VA: 0x15531B0
	public void ClearOptions() { }

	// RVA: 0x1553250 Offset: 0x1553351 VA: 0x1553250
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264470 Offset: 0x2264571 VA: 0x2264470
	|-TMP_Dropdown.GetOrAddComponent<object>
	|-TMP_Dropdown.GetOrAddComponent<Canvas>
	|-TMP_Dropdown.GetOrAddComponent<CanvasGroup>
	|-TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x15538F0 Offset: 0x15539F1 VA: 0x15538F0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1554830 Offset: 0x1554931 VA: 0x1554830 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1554840 Offset: 0x1554941 VA: 0x1554840 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1553900 Offset: 0x1553A01 VA: 0x1553900
	public void Show() { }

	// RVA: 0x1554E70 Offset: 0x1554F71 VA: 0x1554E70 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x15552C0 Offset: 0x15553C1 VA: 0x15552C0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1555330 Offset: 0x1555431 VA: 0x1555330 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x15553A0 Offset: 0x15554A1 VA: 0x15553A0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1555410 Offset: 0x1555511 VA: 0x1555410 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1555480 Offset: 0x1555581 VA: 0x1555480 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x1554A80 Offset: 0x1554B81 VA: 0x1554A80
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1555490 Offset: 0x1555591 VA: 0x1555490
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1554D50 Offset: 0x1554E51 VA: 0x1554D50
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1555520 Offset: 0x1555621 VA: 0x1555520
	private void SetAlpha(float alpha) { }

	// RVA: 0x1554850 Offset: 0x1554951 VA: 0x1554850
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x1404B0 Offset: 0x1405B1 VA: 0x1404B0
	// RVA: 0x15555F0 Offset: 0x15556F1 VA: 0x15555F0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1552D10 Offset: 0x1552E11 VA: 0x1552D10
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x15556B0 Offset: 0x15557B1 VA: 0x15556B0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x15557F0 Offset: 0x15558F1 VA: 0x15557F0
	private static void .cctor() { }
}

[AddComponentMenu] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
[RequireComponent] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5771
{
	// Fields
	[SerializeField] // RVA: 0x13F250 Offset: 0x13F351 VA: 0x13F250
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x13F260 Offset: 0x13F361 VA: 0x13F260
	private TMP_Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x13F270 Offset: 0x13F371 VA: 0x13F270
	private Image m_CaptionImage; // 0x108
	[SerializeField] // RVA: 0x13F280 Offset: 0x13F381 VA: 0x13F280
	private Graphic m_Placeholder; // 0x110
	[SpaceAttribute] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	[SerializeField] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	private TMP_Text m_ItemText; // 0x118
	[SerializeField] // RVA: 0x13F2D0 Offset: 0x13F3D1 VA: 0x13F2D0
	private Image m_ItemImage; // 0x120
	[SpaceAttribute] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	[SerializeField] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	private int m_Value; // 0x128
	[SpaceAttribute] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	[SerializeField] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	private TMP_Dropdown.OptionDataList m_Options; // 0x130
	[SpaceAttribute] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	[SerializeField] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x13F3A0 Offset: 0x13F4A1 VA: 0x13F3A0
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private Coroutine m_Coroutine; // 0x170
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x15524B0 Offset: 0x15525B1 VA: 0x15524B0
	public RectTransform get_template() { }

	// RVA: 0x1551FD0 Offset: 0x15520D1 VA: 0x1551FD0
	public void set_template(RectTransform value) { }

	// RVA: 0x15524C0 Offset: 0x15525C1 VA: 0x15524C0
	public TMP_Text get_captionText() { }

	// RVA: 0x1552000 Offset: 0x1552101 VA: 0x1552000
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x15524D0 Offset: 0x15525D1 VA: 0x15524D0
	public Image get_captionImage() { }

	// RVA: 0x15524E0 Offset: 0x15525E1 VA: 0x15524E0
	public void set_captionImage(Image value) { }

	// RVA: 0x1552510 Offset: 0x1552611 VA: 0x1552510
	public Graphic get_placeholder() { }

	// RVA: 0x1552520 Offset: 0x1552621 VA: 0x1552520
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1552550 Offset: 0x1552651 VA: 0x1552550
	public TMP_Text get_itemText() { }

	// RVA: 0x1552030 Offset: 0x1552131 VA: 0x1552030
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1552560 Offset: 0x1552661 VA: 0x1552560
	public Image get_itemImage() { }

	// RVA: 0x1552570 Offset: 0x1552671 VA: 0x1552570
	public void set_itemImage(Image value) { }

	// RVA: 0x1552060 Offset: 0x1552161 VA: 0x1552060
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x15525A0 Offset: 0x15526A1 VA: 0x15525A0
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x15525E0 Offset: 0x15526E1 VA: 0x15525E0
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x15525F0 Offset: 0x15526F1 VA: 0x15525F0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x1552600 Offset: 0x1552701 VA: 0x1552600
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1552610 Offset: 0x1552711 VA: 0x1552610
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1552620 Offset: 0x1552721 VA: 0x1552620
	public int get_value() { }

	// RVA: 0x1552630 Offset: 0x1552731 VA: 0x1552630
	public void set_value(int value) { }

	// RVA: 0x15527A0 Offset: 0x15528A1 VA: 0x15527A0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1552640 Offset: 0x1552741 VA: 0x1552640
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x15527B0 Offset: 0x15528B1 VA: 0x15527B0
	public bool get_IsExpanded() { }

	// RVA: 0x1552820 Offset: 0x1552921 VA: 0x1552820
	protected void .ctor() { }

	// RVA: 0x1552A90 Offset: 0x1552B91 VA: 0x1552A90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1552C20 Offset: 0x1552D21 VA: 0x1552C20 Slot: 6
	protected override void Start() { }

	// RVA: 0x1552C50 Offset: 0x1552D51 VA: 0x1552C50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1552090 Offset: 0x1552191 VA: 0x1552090
	public void RefreshShownValue() { }

	// RVA: 0x1552EB0 Offset: 0x1552FB1 VA: 0x1552EB0
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1552F30 Offset: 0x1553031 VA: 0x1552F30
	public void AddOptions(List<string> options) { }

	// RVA: 0x1553070 Offset: 0x1553171 VA: 0x1553070
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x15531B0 Offset: 0x15532B1 VA: 0x15531B0
	public void ClearOptions() { }

	// RVA: 0x1553250 Offset: 0x1553351 VA: 0x1553250
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264470 Offset: 0x2264571 VA: 0x2264470
	|-TMP_Dropdown.GetOrAddComponent<object>
	|-TMP_Dropdown.GetOrAddComponent<Canvas>
	|-TMP_Dropdown.GetOrAddComponent<CanvasGroup>
	|-TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x15538F0 Offset: 0x15539F1 VA: 0x15538F0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1554830 Offset: 0x1554931 VA: 0x1554830 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1554840 Offset: 0x1554941 VA: 0x1554840 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1553900 Offset: 0x1553A01 VA: 0x1553900
	public void Show() { }

	// RVA: 0x1554E70 Offset: 0x1554F71 VA: 0x1554E70 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x15552C0 Offset: 0x15553C1 VA: 0x15552C0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1555330 Offset: 0x1555431 VA: 0x1555330 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x15553A0 Offset: 0x15554A1 VA: 0x15553A0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1555410 Offset: 0x1555511 VA: 0x1555410 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1555480 Offset: 0x1555581 VA: 0x1555480 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x1554A80 Offset: 0x1554B81 VA: 0x1554A80
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1555490 Offset: 0x1555591 VA: 0x1555490
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1554D50 Offset: 0x1554E51 VA: 0x1554D50
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1555520 Offset: 0x1555621 VA: 0x1555520
	private void SetAlpha(float alpha) { }

	// RVA: 0x1554850 Offset: 0x1554951 VA: 0x1554850
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x1404B0 Offset: 0x1405B1 VA: 0x1404B0
	// RVA: 0x15555F0 Offset: 0x15556F1 VA: 0x15555F0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1552D10 Offset: 0x1552E11 VA: 0x1552D10
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x15556B0 Offset: 0x15557B1 VA: 0x15556B0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x15557F0 Offset: 0x15558F1 VA: 0x15557F0
	private static void .cctor() { }
}

[AddComponentMenu] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
[RequireComponent] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5771
{
	// Fields
	[SerializeField] // RVA: 0x13F250 Offset: 0x13F351 VA: 0x13F250
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x13F260 Offset: 0x13F361 VA: 0x13F260
	private TMP_Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x13F270 Offset: 0x13F371 VA: 0x13F270
	private Image m_CaptionImage; // 0x108
	[SerializeField] // RVA: 0x13F280 Offset: 0x13F381 VA: 0x13F280
	private Graphic m_Placeholder; // 0x110
	[SpaceAttribute] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	[SerializeField] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	private TMP_Text m_ItemText; // 0x118
	[SerializeField] // RVA: 0x13F2D0 Offset: 0x13F3D1 VA: 0x13F2D0
	private Image m_ItemImage; // 0x120
	[SpaceAttribute] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	[SerializeField] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	private int m_Value; // 0x128
	[SpaceAttribute] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	[SerializeField] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	private TMP_Dropdown.OptionDataList m_Options; // 0x130
	[SpaceAttribute] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	[SerializeField] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x13F3A0 Offset: 0x13F4A1 VA: 0x13F3A0
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private Coroutine m_Coroutine; // 0x170
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x15524B0 Offset: 0x15525B1 VA: 0x15524B0
	public RectTransform get_template() { }

	// RVA: 0x1551FD0 Offset: 0x15520D1 VA: 0x1551FD0
	public void set_template(RectTransform value) { }

	// RVA: 0x15524C0 Offset: 0x15525C1 VA: 0x15524C0
	public TMP_Text get_captionText() { }

	// RVA: 0x1552000 Offset: 0x1552101 VA: 0x1552000
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x15524D0 Offset: 0x15525D1 VA: 0x15524D0
	public Image get_captionImage() { }

	// RVA: 0x15524E0 Offset: 0x15525E1 VA: 0x15524E0
	public void set_captionImage(Image value) { }

	// RVA: 0x1552510 Offset: 0x1552611 VA: 0x1552510
	public Graphic get_placeholder() { }

	// RVA: 0x1552520 Offset: 0x1552621 VA: 0x1552520
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1552550 Offset: 0x1552651 VA: 0x1552550
	public TMP_Text get_itemText() { }

	// RVA: 0x1552030 Offset: 0x1552131 VA: 0x1552030
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1552560 Offset: 0x1552661 VA: 0x1552560
	public Image get_itemImage() { }

	// RVA: 0x1552570 Offset: 0x1552671 VA: 0x1552570
	public void set_itemImage(Image value) { }

	// RVA: 0x1552060 Offset: 0x1552161 VA: 0x1552060
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x15525A0 Offset: 0x15526A1 VA: 0x15525A0
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x15525E0 Offset: 0x15526E1 VA: 0x15525E0
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x15525F0 Offset: 0x15526F1 VA: 0x15525F0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x1552600 Offset: 0x1552701 VA: 0x1552600
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1552610 Offset: 0x1552711 VA: 0x1552610
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1552620 Offset: 0x1552721 VA: 0x1552620
	public int get_value() { }

	// RVA: 0x1552630 Offset: 0x1552731 VA: 0x1552630
	public void set_value(int value) { }

	// RVA: 0x15527A0 Offset: 0x15528A1 VA: 0x15527A0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1552640 Offset: 0x1552741 VA: 0x1552640
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x15527B0 Offset: 0x15528B1 VA: 0x15527B0
	public bool get_IsExpanded() { }

	// RVA: 0x1552820 Offset: 0x1552921 VA: 0x1552820
	protected void .ctor() { }

	// RVA: 0x1552A90 Offset: 0x1552B91 VA: 0x1552A90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1552C20 Offset: 0x1552D21 VA: 0x1552C20 Slot: 6
	protected override void Start() { }

	// RVA: 0x1552C50 Offset: 0x1552D51 VA: 0x1552C50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1552090 Offset: 0x1552191 VA: 0x1552090
	public void RefreshShownValue() { }

	// RVA: 0x1552EB0 Offset: 0x1552FB1 VA: 0x1552EB0
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1552F30 Offset: 0x1553031 VA: 0x1552F30
	public void AddOptions(List<string> options) { }

	// RVA: 0x1553070 Offset: 0x1553171 VA: 0x1553070
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x15531B0 Offset: 0x15532B1 VA: 0x15531B0
	public void ClearOptions() { }

	// RVA: 0x1553250 Offset: 0x1553351 VA: 0x1553250
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264470 Offset: 0x2264571 VA: 0x2264470
	|-TMP_Dropdown.GetOrAddComponent<object>
	|-TMP_Dropdown.GetOrAddComponent<Canvas>
	|-TMP_Dropdown.GetOrAddComponent<CanvasGroup>
	|-TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x15538F0 Offset: 0x15539F1 VA: 0x15538F0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1554830 Offset: 0x1554931 VA: 0x1554830 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1554840 Offset: 0x1554941 VA: 0x1554840 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1553900 Offset: 0x1553A01 VA: 0x1553900
	public void Show() { }

	// RVA: 0x1554E70 Offset: 0x1554F71 VA: 0x1554E70 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x15552C0 Offset: 0x15553C1 VA: 0x15552C0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1555330 Offset: 0x1555431 VA: 0x1555330 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x15553A0 Offset: 0x15554A1 VA: 0x15553A0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1555410 Offset: 0x1555511 VA: 0x1555410 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1555480 Offset: 0x1555581 VA: 0x1555480 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x1554A80 Offset: 0x1554B81 VA: 0x1554A80
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1555490 Offset: 0x1555591 VA: 0x1555490
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1554D50 Offset: 0x1554E51 VA: 0x1554D50
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1555520 Offset: 0x1555621 VA: 0x1555520
	private void SetAlpha(float alpha) { }

	// RVA: 0x1554850 Offset: 0x1554951 VA: 0x1554850
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x1404B0 Offset: 0x1405B1 VA: 0x1404B0
	// RVA: 0x15555F0 Offset: 0x15556F1 VA: 0x15555F0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1552D10 Offset: 0x1552E11 VA: 0x1552D10
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x15556B0 Offset: 0x15557B1 VA: 0x15556B0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x15557F0 Offset: 0x15558F1 VA: 0x15557F0
	private static void .cctor() { }
}

[AddComponentMenu] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
[RequireComponent] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5771
{
	// Fields
	[SerializeField] // RVA: 0x13F250 Offset: 0x13F351 VA: 0x13F250
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x13F260 Offset: 0x13F361 VA: 0x13F260
	private TMP_Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x13F270 Offset: 0x13F371 VA: 0x13F270
	private Image m_CaptionImage; // 0x108
	[SerializeField] // RVA: 0x13F280 Offset: 0x13F381 VA: 0x13F280
	private Graphic m_Placeholder; // 0x110
	[SpaceAttribute] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	[SerializeField] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	private TMP_Text m_ItemText; // 0x118
	[SerializeField] // RVA: 0x13F2D0 Offset: 0x13F3D1 VA: 0x13F2D0
	private Image m_ItemImage; // 0x120
	[SpaceAttribute] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	[SerializeField] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	private int m_Value; // 0x128
	[SpaceAttribute] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	[SerializeField] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	private TMP_Dropdown.OptionDataList m_Options; // 0x130
	[SpaceAttribute] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	[SerializeField] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x13F3A0 Offset: 0x13F4A1 VA: 0x13F3A0
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private Coroutine m_Coroutine; // 0x170
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x15524B0 Offset: 0x15525B1 VA: 0x15524B0
	public RectTransform get_template() { }

	// RVA: 0x1551FD0 Offset: 0x15520D1 VA: 0x1551FD0
	public void set_template(RectTransform value) { }

	// RVA: 0x15524C0 Offset: 0x15525C1 VA: 0x15524C0
	public TMP_Text get_captionText() { }

	// RVA: 0x1552000 Offset: 0x1552101 VA: 0x1552000
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x15524D0 Offset: 0x15525D1 VA: 0x15524D0
	public Image get_captionImage() { }

	// RVA: 0x15524E0 Offset: 0x15525E1 VA: 0x15524E0
	public void set_captionImage(Image value) { }

	// RVA: 0x1552510 Offset: 0x1552611 VA: 0x1552510
	public Graphic get_placeholder() { }

	// RVA: 0x1552520 Offset: 0x1552621 VA: 0x1552520
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1552550 Offset: 0x1552651 VA: 0x1552550
	public TMP_Text get_itemText() { }

	// RVA: 0x1552030 Offset: 0x1552131 VA: 0x1552030
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1552560 Offset: 0x1552661 VA: 0x1552560
	public Image get_itemImage() { }

	// RVA: 0x1552570 Offset: 0x1552671 VA: 0x1552570
	public void set_itemImage(Image value) { }

	// RVA: 0x1552060 Offset: 0x1552161 VA: 0x1552060
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x15525A0 Offset: 0x15526A1 VA: 0x15525A0
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x15525E0 Offset: 0x15526E1 VA: 0x15525E0
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x15525F0 Offset: 0x15526F1 VA: 0x15525F0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x1552600 Offset: 0x1552701 VA: 0x1552600
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1552610 Offset: 0x1552711 VA: 0x1552610
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1552620 Offset: 0x1552721 VA: 0x1552620
	public int get_value() { }

	// RVA: 0x1552630 Offset: 0x1552731 VA: 0x1552630
	public void set_value(int value) { }

	// RVA: 0x15527A0 Offset: 0x15528A1 VA: 0x15527A0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1552640 Offset: 0x1552741 VA: 0x1552640
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x15527B0 Offset: 0x15528B1 VA: 0x15527B0
	public bool get_IsExpanded() { }

	// RVA: 0x1552820 Offset: 0x1552921 VA: 0x1552820
	protected void .ctor() { }

	// RVA: 0x1552A90 Offset: 0x1552B91 VA: 0x1552A90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1552C20 Offset: 0x1552D21 VA: 0x1552C20 Slot: 6
	protected override void Start() { }

	// RVA: 0x1552C50 Offset: 0x1552D51 VA: 0x1552C50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1552090 Offset: 0x1552191 VA: 0x1552090
	public void RefreshShownValue() { }

	// RVA: 0x1552EB0 Offset: 0x1552FB1 VA: 0x1552EB0
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1552F30 Offset: 0x1553031 VA: 0x1552F30
	public void AddOptions(List<string> options) { }

	// RVA: 0x1553070 Offset: 0x1553171 VA: 0x1553070
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x15531B0 Offset: 0x15532B1 VA: 0x15531B0
	public void ClearOptions() { }

	// RVA: 0x1553250 Offset: 0x1553351 VA: 0x1553250
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264470 Offset: 0x2264571 VA: 0x2264470
	|-TMP_Dropdown.GetOrAddComponent<object>
	|-TMP_Dropdown.GetOrAddComponent<Canvas>
	|-TMP_Dropdown.GetOrAddComponent<CanvasGroup>
	|-TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x15538F0 Offset: 0x15539F1 VA: 0x15538F0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1554830 Offset: 0x1554931 VA: 0x1554830 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1554840 Offset: 0x1554941 VA: 0x1554840 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1553900 Offset: 0x1553A01 VA: 0x1553900
	public void Show() { }

	// RVA: 0x1554E70 Offset: 0x1554F71 VA: 0x1554E70 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x15552C0 Offset: 0x15553C1 VA: 0x15552C0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1555330 Offset: 0x1555431 VA: 0x1555330 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x15553A0 Offset: 0x15554A1 VA: 0x15553A0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1555410 Offset: 0x1555511 VA: 0x1555410 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1555480 Offset: 0x1555581 VA: 0x1555480 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x1554A80 Offset: 0x1554B81 VA: 0x1554A80
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1555490 Offset: 0x1555591 VA: 0x1555490
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1554D50 Offset: 0x1554E51 VA: 0x1554D50
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1555520 Offset: 0x1555621 VA: 0x1555520
	private void SetAlpha(float alpha) { }

	// RVA: 0x1554850 Offset: 0x1554951 VA: 0x1554850
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x1404B0 Offset: 0x1405B1 VA: 0x1404B0
	// RVA: 0x15555F0 Offset: 0x15556F1 VA: 0x15555F0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1552D10 Offset: 0x1552E11 VA: 0x1552D10
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x15556B0 Offset: 0x15557B1 VA: 0x15556B0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x15557F0 Offset: 0x15558F1 VA: 0x15557F0
	private static void .cctor() { }
}

[AddComponentMenu] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
[RequireComponent] // RVA: 0x13EC90 Offset: 0x13ED91 VA: 0x13EC90
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5771
{
	// Fields
	[SerializeField] // RVA: 0x13F250 Offset: 0x13F351 VA: 0x13F250
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x13F260 Offset: 0x13F361 VA: 0x13F260
	private TMP_Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x13F270 Offset: 0x13F371 VA: 0x13F270
	private Image m_CaptionImage; // 0x108
	[SerializeField] // RVA: 0x13F280 Offset: 0x13F381 VA: 0x13F280
	private Graphic m_Placeholder; // 0x110
	[SpaceAttribute] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	[SerializeField] // RVA: 0x13F290 Offset: 0x13F391 VA: 0x13F290
	private TMP_Text m_ItemText; // 0x118
	[SerializeField] // RVA: 0x13F2D0 Offset: 0x13F3D1 VA: 0x13F2D0
	private Image m_ItemImage; // 0x120
	[SpaceAttribute] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	[SerializeField] // RVA: 0x13F2E0 Offset: 0x13F3E1 VA: 0x13F2E0
	private int m_Value; // 0x128
	[SpaceAttribute] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	[SerializeField] // RVA: 0x13F320 Offset: 0x13F421 VA: 0x13F320
	private TMP_Dropdown.OptionDataList m_Options; // 0x130
	[SpaceAttribute] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	[SerializeField] // RVA: 0x13F360 Offset: 0x13F461 VA: 0x13F360
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x13F3A0 Offset: 0x13F4A1 VA: 0x13F3A0
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private Coroutine m_Coroutine; // 0x170
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x15524B0 Offset: 0x15525B1 VA: 0x15524B0
	public RectTransform get_template() { }

	// RVA: 0x1551FD0 Offset: 0x15520D1 VA: 0x1551FD0
	public void set_template(RectTransform value) { }

	// RVA: 0x15524C0 Offset: 0x15525C1 VA: 0x15524C0
	public TMP_Text get_captionText() { }

	// RVA: 0x1552000 Offset: 0x1552101 VA: 0x1552000
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x15524D0 Offset: 0x15525D1 VA: 0x15524D0
	public Image get_captionImage() { }

	// RVA: 0x15524E0 Offset: 0x15525E1 VA: 0x15524E0
	public void set_captionImage(Image value) { }

	// RVA: 0x1552510 Offset: 0x1552611 VA: 0x1552510
	public Graphic get_placeholder() { }

	// RVA: 0x1552520 Offset: 0x1552621 VA: 0x1552520
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1552550 Offset: 0x1552651 VA: 0x1552550
	public TMP_Text get_itemText() { }

	// RVA: 0x1552030 Offset: 0x1552131 VA: 0x1552030
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1552560 Offset: 0x1552661 VA: 0x1552560
	public Image get_itemImage() { }

	// RVA: 0x1552570 Offset: 0x1552671 VA: 0x1552570
	public void set_itemImage(Image value) { }

	// RVA: 0x1552060 Offset: 0x1552161 VA: 0x1552060
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x15525A0 Offset: 0x15526A1 VA: 0x15525A0
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x15525E0 Offset: 0x15526E1 VA: 0x15525E0
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x15525F0 Offset: 0x15526F1 VA: 0x15525F0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x1552600 Offset: 0x1552701 VA: 0x1552600
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1552610 Offset: 0x1552711 VA: 0x1552610
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1552620 Offset: 0x1552721 VA: 0x1552620
	public int get_value() { }

	// RVA: 0x1552630 Offset: 0x1552731 VA: 0x1552630
	public void set_value(int value) { }

	// RVA: 0x15527A0 Offset: 0x15528A1 VA: 0x15527A0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1552640 Offset: 0x1552741 VA: 0x1552640
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x15527B0 Offset: 0x15528B1 VA: 0x15527B0
	public bool get_IsExpanded() { }

	// RVA: 0x1552820 Offset: 0x1552921 VA: 0x1552820
	protected void .ctor() { }

	// RVA: 0x1552A90 Offset: 0x1552B91 VA: 0x1552A90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1552C20 Offset: 0x1552D21 VA: 0x1552C20 Slot: 6
	protected override void Start() { }

	// RVA: 0x1552C50 Offset: 0x1552D51 VA: 0x1552C50 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1552090 Offset: 0x1552191 VA: 0x1552090
	public void RefreshShownValue() { }

	// RVA: 0x1552EB0 Offset: 0x1552FB1 VA: 0x1552EB0
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1552F30 Offset: 0x1553031 VA: 0x1552F30
	public void AddOptions(List<string> options) { }

	// RVA: 0x1553070 Offset: 0x1553171 VA: 0x1553070
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x15531B0 Offset: 0x15532B1 VA: 0x15531B0
	public void ClearOptions() { }

	// RVA: 0x1553250 Offset: 0x1553351 VA: 0x1553250
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264470 Offset: 0x2264571 VA: 0x2264470
	|-TMP_Dropdown.GetOrAddComponent<object>
	|-TMP_Dropdown.GetOrAddComponent<Canvas>
	|-TMP_Dropdown.GetOrAddComponent<CanvasGroup>
	|-TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x15538F0 Offset: 0x15539F1 VA: 0x15538F0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1554830 Offset: 0x1554931 VA: 0x1554830 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1554840 Offset: 0x1554941 VA: 0x1554840 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1553900 Offset: 0x1553A01 VA: 0x1553900
	public void Show() { }

	// RVA: 0x1554E70 Offset: 0x1554F71 VA: 0x1554E70 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x15552C0 Offset: 0x15553C1 VA: 0x15552C0 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1555330 Offset: 0x1555431 VA: 0x1555330 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x15553A0 Offset: 0x15554A1 VA: 0x15553A0 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1555410 Offset: 0x1555511 VA: 0x1555410 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1555480 Offset: 0x1555581 VA: 0x1555480 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x1554A80 Offset: 0x1554B81 VA: 0x1554A80
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1555490 Offset: 0x1555591 VA: 0x1555490
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1554D50 Offset: 0x1554E51 VA: 0x1554D50
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1555520 Offset: 0x1555621 VA: 0x1555520
	private void SetAlpha(float alpha) { }

	// RVA: 0x1554850 Offset: 0x1554951 VA: 0x1554850
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x1404B0 Offset: 0x1405B1 VA: 0x1404B0
	// RVA: 0x15555F0 Offset: 0x15556F1 VA: 0x15555F0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1552D10 Offset: 0x1552E11 VA: 0x1552D10
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x15556B0 Offset: 0x15557B1 VA: 0x15556B0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x15557F0 Offset: 0x15558F1 VA: 0x15557F0
	private static void .cctor() { }
}

