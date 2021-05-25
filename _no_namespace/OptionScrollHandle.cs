public class OptionScrollHandle : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 8803
{
	// Fields
	[SerializeField] // RVA: 0x173960 Offset: 0x173A61 VA: 0x173960
	private CursorLinker cursorLinker; // 0x18
	private RectTransform handleRect; // 0x20
	private float scale; // 0x28
	private readonly float SPEED; // 0x2C
	private int dir; // 0x30
	private bool isDragging; // 0x34
	private readonly Key KEY; // 0x38
	private OptionScrollHandle.State state; // 0x3C

	// Methods

	// RVA: 0x1F1C7E0 Offset: 0x1F1C8E1 VA: 0x1F1C7E0
	private void Awake() { }

	// RVA: 0x1F1C850 Offset: 0x1F1C951 VA: 0x1F1C850
	private void Update() { }

	// RVA: 0x1F1CA30 Offset: 0x1F1CB31 VA: 0x1F1CA30 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1F1CAB0 Offset: 0x1F1CBB1 VA: 0x1F1CAB0 Slot: 5
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1F1CB30 Offset: 0x1F1CC31 VA: 0x1F1CB30
	public void .ctor() { }
}

