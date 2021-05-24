public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 4316
{
	// Fields
	private CanvasScaler _canvasScaler; // 0x18
	private float _delta; // 0x20
	private float _startValue; // 0x24
	public RectTransform.Axis Axis; // 0x28
	public bool Invert; // 0x2C
	public float MaxSize; // 0x30
	public LayoutElement TargetLayoutElement; // 0x38
	public RectTransform TargetRectTransform; // 0x40

	// Properties
	private float Mult { get; }

	// Methods

	// RVA: 0x1A85C50 Offset: 0x1A85D51 VA: 0x1A85C50
	private float get_Mult() { }

	// RVA: 0x1A85C70 Offset: 0x1A85D71 VA: 0x1A85C70 Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A85F30 Offset: 0x1A86031 VA: 0x1A85F30 Slot: 6
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A862E0 Offset: 0x1A863E1 VA: 0x1A862E0 Slot: 5
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A864C0 Offset: 0x1A865C1 VA: 0x1A864C0
	private void Start() { }

	// RVA: 0x1A85CB0 Offset: 0x1A85DB1 VA: 0x1A85CB0
	private bool Verify() { }

	// RVA: 0x1A85DD0 Offset: 0x1A85ED1 VA: 0x1A85DD0
	private float GetCurrentValue() { }

	// RVA: 0x1A86180 Offset: 0x1A86281 VA: 0x1A86180
	private void SetCurrentValue(float value) { }

	// RVA: 0x1A863A0 Offset: 0x1A864A1 VA: 0x1A863A0
	private void CommitCurrentValue() { }

	// RVA: 0x1A860A0 Offset: 0x1A861A1 VA: 0x1A860A0
	private float GetMinSize() { }

	// RVA: 0x1A86160 Offset: 0x1A86261 VA: 0x1A86160
	private float GetMaxSize() { }

	// RVA: 0x1A86530 Offset: 0x1A86631 VA: 0x1A86530
	public void .ctor() { }
}

