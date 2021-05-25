[AddComponentMenu] // RVA: 0x1273A0 Offset: 0x1274A1 VA: 0x1273A0
public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 4327
{
	// Fields
	private const float ExtraThreshold = 3;
	public const float Delay = 0.4;
	private float _delayTime; // 0x100
	private float _downTime; // 0x104
	private bool _isDown; // 0x108
	public double Amount; // 0x110
	public SRNumberSpinner TargetField; // 0x118

	// Methods

	// RVA: 0x1A8A270 Offset: 0x1A8A371 VA: 0x1A8A270 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A8A3D0 Offset: 0x1A8A4D1 VA: 0x1A8A3D0 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A8A400 Offset: 0x1A8A501 VA: 0x1A8A400 Slot: 43
	protected virtual void Update() { }

	// RVA: 0x1A8A2D0 Offset: 0x1A8A3D1 VA: 0x1A8A2D0
	private void Apply() { }

	// RVA: 0x1A8A530 Offset: 0x1A8A631 VA: 0x1A8A530
	public void .ctor() { }
}

