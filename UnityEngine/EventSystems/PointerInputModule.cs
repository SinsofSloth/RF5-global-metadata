public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 4080
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
	private readonly PointerInputModule.MouseState m_MouseState; // 0x50

	// Methods

	// RVA: 0x163F000 Offset: 0x163F101 VA: 0x163F000
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x163F0F0 Offset: 0x163F1F1 VA: 0x163F0F0
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x163F160 Offset: 0x163F261 VA: 0x163F160
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x163F470 Offset: 0x163F571 VA: 0x163F470
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x163F4F0 Offset: 0x163F5F1 VA: 0x163F4F0
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x163F590 Offset: 0x163F691 VA: 0x163F590 Slot: 26
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x163F5B0 Offset: 0x163F6B1 VA: 0x163F5B0 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x163FB80 Offset: 0x163FC81 VA: 0x163FB80
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x163FC00 Offset: 0x163FD01 VA: 0x163FC00
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x163FCD0 Offset: 0x163FDD1 VA: 0x163FCD0 Slot: 28
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x163FD10 Offset: 0x163FE11 VA: 0x163FD10 Slot: 29
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x1640100 Offset: 0x1640201 VA: 0x1640100 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1640200 Offset: 0x1640301 VA: 0x1640200
	protected void ClearSelection() { }

	// RVA: 0x1640360 Offset: 0x1640461 VA: 0x1640360 Slot: 3
	public override string ToString() { }

	// RVA: 0x1640570 Offset: 0x1640671 VA: 0x1640570
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x1640660 Offset: 0x1640761 VA: 0x1640660
	protected void .ctor() { }
}

