[AddComponentMenu] // RVA: 0x11AA40 Offset: 0x11AB41 VA: 0x11AA40
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4071
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x11CBF0 Offset: 0x11CCF1 VA: 0x11CBF0
	[SerializeField] // RVA: 0x11CBF0 Offset: 0x11CCF1 VA: 0x11CBF0
	private List<EventTrigger.Entry> m_Delegates; // 0x18

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x11DB40 Offset: 0x11DC41 VA: 0x11DB40
	[ObsoleteAttribute] // RVA: 0x11DB40 Offset: 0x11DC41 VA: 0x11DB40
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x163A740 Offset: 0x163A841 VA: 0x163A740
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x163A880 Offset: 0x163A981 VA: 0x163A880
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x163A890 Offset: 0x163A991 VA: 0x163A890
	protected void .ctor() { }

	// RVA: 0x163A7E0 Offset: 0x163A8E1 VA: 0x163A7E0
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x163A8A0 Offset: 0x163A9A1 VA: 0x163A8A0
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x163A8B0 Offset: 0x163A9B1 VA: 0x163A8B0
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x163AA70 Offset: 0x163AB71 VA: 0x163AA70 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x163AA80 Offset: 0x163AB81 VA: 0x163AA80 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x163AA90 Offset: 0x163AB91 VA: 0x163AA90 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x163AAA0 Offset: 0x163ABA1 VA: 0x163AAA0 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x163AAB0 Offset: 0x163ABB1 VA: 0x163AAB0 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x163AAC0 Offset: 0x163ABC1 VA: 0x163AAC0 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x163AAD0 Offset: 0x163ABD1 VA: 0x163AAD0 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x163AAE0 Offset: 0x163ABE1 VA: 0x163AAE0 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x163AAF0 Offset: 0x163ABF1 VA: 0x163AAF0 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x163AB00 Offset: 0x163AC01 VA: 0x163AB00 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x163AB10 Offset: 0x163AC11 VA: 0x163AB10 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x163AB20 Offset: 0x163AC21 VA: 0x163AB20 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x163AB30 Offset: 0x163AC31 VA: 0x163AB30 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x163AB40 Offset: 0x163AC41 VA: 0x163AB40 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x163AB50 Offset: 0x163AC51 VA: 0x163AB50 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x163AB60 Offset: 0x163AC61 VA: 0x163AB60 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x163AB70 Offset: 0x163AC71 VA: 0x163AB70 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}

