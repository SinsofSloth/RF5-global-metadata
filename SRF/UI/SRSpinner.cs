[AddComponentMenu] // RVA: 0x1274B0 Offset: 0x1275B1 VA: 0x1274B0
public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler // TypeDefIndex: 4330
{
	// Fields
	private float _dragDelta; // 0xF8
	[SerializeField] // RVA: 0x1278C0 Offset: 0x1279C1 VA: 0x1278C0
	private SRSpinner.SpinEvent _onSpinDecrement; // 0x100
	[SerializeField] // RVA: 0x1278D0 Offset: 0x1279D1 VA: 0x1278D0
	private SRSpinner.SpinEvent _onSpinIncrement; // 0x108
	public float DragThreshold; // 0x110

	// Properties
	public SRSpinner.SpinEvent OnSpinIncrement { get; set; }
	public SRSpinner.SpinEvent OnSpinDecrement { get; set; }

	// Methods

	// RVA: 0x1A8AE10 Offset: 0x1A8AF11 VA: 0x1A8AE10
	public SRSpinner.SpinEvent get_OnSpinIncrement() { }

	// RVA: 0x1A8AE20 Offset: 0x1A8AF21 VA: 0x1A8AE20
	public void set_OnSpinIncrement(SRSpinner.SpinEvent value) { }

	// RVA: 0x1A8AE30 Offset: 0x1A8AF31 VA: 0x1A8AE30
	public SRSpinner.SpinEvent get_OnSpinDecrement() { }

	// RVA: 0x1A8AE40 Offset: 0x1A8AF41 VA: 0x1A8AE40
	public void set_OnSpinDecrement(SRSpinner.SpinEvent value) { }

	// RVA: 0x1A8AE50 Offset: 0x1A8AF51 VA: 0x1A8AE50 Slot: 40
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A8AE60 Offset: 0x1A8AF61 VA: 0x1A8AE60 Slot: 39
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A8AFE0 Offset: 0x1A8B0E1 VA: 0x1A8AFE0
	private void OnIncrement(int amount) { }

	// RVA: 0x1A8B040 Offset: 0x1A8B141 VA: 0x1A8B040
	private void OnDecrement(int amount) { }

	// RVA: 0x1A8B0A0 Offset: 0x1A8B1A1 VA: 0x1A8B0A0
	public void .ctor() { }
}

