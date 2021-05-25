public class UIItemSlotDrag : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 8614
{
	// Fields
	private static UIItemSlot DragingSlot; // 0x0
	private UIItemSlot UIItemSlot; // 0x18
	private Image ItemImg; // 0x20
	private static UIItemSlot DragToTargetSlot; // 0x8

	// Methods

	// RVA: 0x1ED5690 Offset: 0x1ED5791 VA: 0x1ED5690 Slot: 4
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1ED57A0 Offset: 0x1ED58A1 VA: 0x1ED57A0 Slot: 5
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1ED5930 Offset: 0x1ED5A31 VA: 0x1ED5930 Slot: 6
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1ED5A10 Offset: 0x1ED5B11 VA: 0x1ED5A10
	private void Start() { }

	// RVA: 0x1ED5A70 Offset: 0x1ED5B71 VA: 0x1ED5A70 Slot: 8
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1ED5C90 Offset: 0x1ED5D91 VA: 0x1ED5C90 Slot: 9
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1ED5D50 Offset: 0x1ED5E51 VA: 0x1ED5D50 Slot: 7
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1ED5F50 Offset: 0x1ED6051 VA: 0x1ED5F50 Slot: 10
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1ED6010 Offset: 0x1ED6111 VA: 0x1ED6010
	private void OnDisable() { }

	// RVA: 0x1ED61A0 Offset: 0x1ED62A1 VA: 0x1ED61A0
	private void OnDestroy() { }

	// RVA: 0x1ED6280 Offset: 0x1ED6381 VA: 0x1ED6280
	public void .ctor() { }
}

