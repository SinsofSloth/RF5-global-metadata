protected internal class TMP_Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 5772
{
	// Fields
	[SerializeField] // RVA: 0x1403D0 Offset: 0x1404D1 VA: 0x1403D0
	private TMP_Text m_Text; // 0x18
	[SerializeField] // RVA: 0x1403E0 Offset: 0x1404E1 VA: 0x1403E0
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x1403F0 Offset: 0x1404F1 VA: 0x1403F0
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x140400 Offset: 0x140501 VA: 0x140400
	private Toggle m_Toggle; // 0x30

	// Properties
	public TMP_Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x15559F0 Offset: 0x1555AF1 VA: 0x15559F0
	public TMP_Text get_text() { }

	// RVA: 0x1555A00 Offset: 0x1555B01 VA: 0x1555A00
	public void set_text(TMP_Text value) { }

	// RVA: 0x1555A10 Offset: 0x1555B11 VA: 0x1555A10
	public Image get_image() { }

	// RVA: 0x1555A20 Offset: 0x1555B21 VA: 0x1555A20
	public void set_image(Image value) { }

	// RVA: 0x1555A30 Offset: 0x1555B31 VA: 0x1555A30
	public RectTransform get_rectTransform() { }

	// RVA: 0x1555A40 Offset: 0x1555B41 VA: 0x1555A40
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1555A50 Offset: 0x1555B51 VA: 0x1555A50
	public Toggle get_toggle() { }

	// RVA: 0x1555A60 Offset: 0x1555B61 VA: 0x1555A60
	public void set_toggle(Toggle value) { }

	// RVA: 0x1555A70 Offset: 0x1555B71 VA: 0x1555A70 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1555B00 Offset: 0x1555C01 VA: 0x1555B00 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1555BB0 Offset: 0x1555CB1 VA: 0x1555BB0
	public void .ctor() { }
}

