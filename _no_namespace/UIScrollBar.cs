public class UIScrollBar : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 8472
{
	// Fields
	private Scrollbar scrollbar; // 0x18
	private Image handleImage; // 0x20
	[SerializeField] // RVA: 0x16FEC0 Offset: 0x16FFC1 VA: 0x16FEC0
	private Sprite handleSprite; // 0x28
	[SerializeField] // RVA: 0x16FED0 Offset: 0x16FFD1 VA: 0x16FED0
	private Sprite clickedSprite; // 0x30

	// Methods

	// RVA: 0x1DD9760 Offset: 0x1DD9861 VA: 0x1DD9760
	private void Awake() { }

	// RVA: 0x1DD9810 Offset: 0x1DD9911 VA: 0x1DD9810 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1DD9840 Offset: 0x1DD9941 VA: 0x1DD9840 Slot: 5
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1DD9870 Offset: 0x1DD9971 VA: 0x1DD9870
	public void .ctor() { }
}

