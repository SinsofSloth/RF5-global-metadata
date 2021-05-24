protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 3920
{
	// Fields
	[SerializeField] // RVA: 0x11CD60 Offset: 0x11CE61 VA: 0x11CD60
	private Text m_Text; // 0x18
	[SerializeField] // RVA: 0x11CD70 Offset: 0x11CE71 VA: 0x11CD70
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x11CD80 Offset: 0x11CE81 VA: 0x11CD80
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x11CD90 Offset: 0x11CE91 VA: 0x11CD90
	private Toggle m_Toggle; // 0x30

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x1863A70 Offset: 0x1863B71 VA: 0x1863A70
	public Text get_text() { }

	// RVA: 0x1863A80 Offset: 0x1863B81 VA: 0x1863A80
	public void set_text(Text value) { }

	// RVA: 0x1863A90 Offset: 0x1863B91 VA: 0x1863A90
	public Image get_image() { }

	// RVA: 0x1863AA0 Offset: 0x1863BA1 VA: 0x1863AA0
	public void set_image(Image value) { }

	// RVA: 0x1863AB0 Offset: 0x1863BB1 VA: 0x1863AB0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1863AC0 Offset: 0x1863BC1 VA: 0x1863AC0
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1863AD0 Offset: 0x1863BD1 VA: 0x1863AD0
	public Toggle get_toggle() { }

	// RVA: 0x1863AE0 Offset: 0x1863BE1 VA: 0x1863AE0
	public void set_toggle(Toggle value) { }

	// RVA: 0x1863AF0 Offset: 0x1863BF1 VA: 0x1863AF0 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1863B80 Offset: 0x1863C81 VA: 0x1863B80 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1863C40 Offset: 0x1863D41 VA: 0x1863C40
	public void .ctor() { }
}

