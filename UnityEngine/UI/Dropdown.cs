[AddComponentMenu] // RVA: 0x119C20 Offset: 0x119D21 VA: 0x119C20
[RequireComponent] // RVA: 0x119C20 Offset: 0x119D21 VA: 0x119C20
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 3919
{
	// Fields
	[SerializeField] // RVA: 0x11B1E0 Offset: 0x11B2E1 VA: 0x11B1E0
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x11B1F0 Offset: 0x11B2F1 VA: 0x11B1F0
	private Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x11B200 Offset: 0x11B301 VA: 0x11B200
	private Image m_CaptionImage; // 0x108
	[SpaceAttribute] // RVA: 0x11B210 Offset: 0x11B311 VA: 0x11B210
	[SerializeField] // RVA: 0x11B210 Offset: 0x11B311 VA: 0x11B210
	private Text m_ItemText; // 0x110
	[SerializeField] // RVA: 0x11B250 Offset: 0x11B351 VA: 0x11B250
	private Image m_ItemImage; // 0x118
	[SpaceAttribute] // RVA: 0x11B260 Offset: 0x11B361 VA: 0x11B260
	[SerializeField] // RVA: 0x11B260 Offset: 0x11B361 VA: 0x11B260
	private int m_Value; // 0x120
	[SpaceAttribute] // RVA: 0x11B2A0 Offset: 0x11B3A1 VA: 0x11B2A0
	[SerializeField] // RVA: 0x11B2A0 Offset: 0x11B3A1 VA: 0x11B2A0
	private Dropdown.OptionDataList m_Options; // 0x128
	[SpaceAttribute] // RVA: 0x11B2E0 Offset: 0x11B3E1 VA: 0x11B2E0
	[SerializeField] // RVA: 0x11B2E0 Offset: 0x11B3E1 VA: 0x11B2E0
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x130
	[SerializeField] // RVA: 0x11B320 Offset: 0x11B421 VA: 0x11B320
	private float m_AlphaFadeSpeed; // 0x138
	private GameObject m_Dropdown; // 0x140
	private GameObject m_Blocker; // 0x148
	private List<Dropdown.DropdownItem> m_Items; // 0x150
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x158
	private bool validTemplate; // 0x160
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x164EC90 Offset: 0x164ED91 VA: 0x164EC90
	public RectTransform get_template() { }

	// RVA: 0x164DFA0 Offset: 0x164E0A1 VA: 0x164DFA0
	public void set_template(RectTransform value) { }

	// RVA: 0x164ECA0 Offset: 0x164EDA1 VA: 0x164ECA0
	public Text get_captionText() { }

	// RVA: 0x164DFD0 Offset: 0x164E0D1 VA: 0x164DFD0
	public void set_captionText(Text value) { }

	// RVA: 0x164ECB0 Offset: 0x164EDB1 VA: 0x164ECB0
	public Image get_captionImage() { }

	// RVA: 0x164ECC0 Offset: 0x164EDC1 VA: 0x164ECC0
	public void set_captionImage(Image value) { }

	// RVA: 0x164ECF0 Offset: 0x164EDF1 VA: 0x164ECF0
	public Text get_itemText() { }

	// RVA: 0x164E000 Offset: 0x164E101 VA: 0x164E000
	public void set_itemText(Text value) { }

	// RVA: 0x164ED00 Offset: 0x164EE01 VA: 0x164ED00
	public Image get_itemImage() { }

	// RVA: 0x164ED10 Offset: 0x164EE11 VA: 0x164ED10
	public void set_itemImage(Image value) { }

	// RVA: 0x164E030 Offset: 0x164E131 VA: 0x164E030
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x164ED40 Offset: 0x164EE41 VA: 0x164ED40
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x164ED80 Offset: 0x164EE81 VA: 0x164ED80
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x164ED90 Offset: 0x164EE91 VA: 0x164ED90
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x164EDA0 Offset: 0x164EEA1 VA: 0x164EDA0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x164EDB0 Offset: 0x164EEB1 VA: 0x164EDB0
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x164EDC0 Offset: 0x164EEC1 VA: 0x164EDC0
	public int get_value() { }

	// RVA: 0x164EDD0 Offset: 0x164EED1 VA: 0x164EDD0
	public void set_value(int value) { }

	// RVA: 0x164EF00 Offset: 0x164F001 VA: 0x164EF00
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x164EDE0 Offset: 0x164EEE1 VA: 0x164EDE0
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x164EF10 Offset: 0x164F011 VA: 0x164EF10
	protected void .ctor() { }

	// RVA: 0x164F010 Offset: 0x164F111 VA: 0x164F010 Slot: 4
	protected override void Awake() { }

	// RVA: 0x164F1A0 Offset: 0x164F2A1 VA: 0x164F1A0 Slot: 6
	protected override void Start() { }

	// RVA: 0x164F230 Offset: 0x164F331 VA: 0x164F230 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x164E050 Offset: 0x164E151 VA: 0x164E050
	public void RefreshShownValue() { }

	// RVA: 0x164F460 Offset: 0x164F561 VA: 0x164F460
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x164F4E0 Offset: 0x164F5E1 VA: 0x164F4E0
	public void AddOptions(List<string> options) { }

	// RVA: 0x164F5D0 Offset: 0x164F6D1 VA: 0x164F5D0
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x164F6C0 Offset: 0x164F7C1 VA: 0x164F6C0
	public void ClearOptions() { }

	// RVA: 0x164F730 Offset: 0x164F831 VA: 0x164F730
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267370 Offset: 0x2267471 VA: 0x2267370
	|-Dropdown.GetOrAddComponent<object>
	|-Dropdown.GetOrAddComponent<Canvas>
	|-Dropdown.GetOrAddComponent<CanvasGroup>
	|-Dropdown.GetOrAddComponent<GraphicRaycaster>
	*/

	// RVA: 0x164FDD0 Offset: 0x164FED1 VA: 0x164FDD0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1650CF0 Offset: 0x1650DF1 VA: 0x1650CF0 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1650D00 Offset: 0x1650E01 VA: 0x1650D00 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x164FDE0 Offset: 0x164FEE1 VA: 0x164FDE0
	public void Show() { }

	// RVA: 0x16512E0 Offset: 0x16513E1 VA: 0x16512E0 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x1651730 Offset: 0x1651831 VA: 0x1651730 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x16517A0 Offset: 0x16518A1 VA: 0x16517A0 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x1651810 Offset: 0x1651911 VA: 0x1651810 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1651880 Offset: 0x1651981 VA: 0x1651880 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x16518F0 Offset: 0x16519F1 VA: 0x16518F0 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x1650EF0 Offset: 0x1650FF1 VA: 0x1650EF0
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x1651900 Offset: 0x1651A01 VA: 0x1651900
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x16511C0 Offset: 0x16512C1 VA: 0x16511C0
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1651990 Offset: 0x1651A91 VA: 0x1651990
	private void SetAlpha(float alpha) { }

	// RVA: 0x1650D10 Offset: 0x1650E11 VA: 0x1650D10
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x11CE40 Offset: 0x11CF41 VA: 0x11CE40
	// RVA: 0x1651A60 Offset: 0x1651B61 VA: 0x1651A60
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x164F2F0 Offset: 0x164F3F1 VA: 0x164F2F0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1651AF0 Offset: 0x1651BF1 VA: 0x1651AF0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1651C30 Offset: 0x1651D31 VA: 0x1651C30
	private static void .cctor() { }
}

