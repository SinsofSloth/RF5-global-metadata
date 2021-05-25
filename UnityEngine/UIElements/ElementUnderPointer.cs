internal class ElementUnderPointer // TypeDefIndex: 4162
{
	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0x15BA410 Offset: 0x15BA511 VA: 0x15BA410
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0x15B6B40 Offset: 0x15B6C41 VA: 0x15B6B40
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x15BA490 Offset: 0x15BA591 VA: 0x15BA490
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0x15B6BE0 Offset: 0x15B6CE1 VA: 0x15B6BE0
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0x15B6BA0 Offset: 0x15B6CA1 VA: 0x15B6BA0
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	// RVA: 0x15BA690 Offset: 0x15BA791 VA: 0x15BA690
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent, bool temporary) { }

	// RVA: 0x15B6C30 Offset: 0x15B6D31 VA: 0x15B6C30
	internal void CommitElementUnderPointers(EventDispatcher dispatcher) { }
}

