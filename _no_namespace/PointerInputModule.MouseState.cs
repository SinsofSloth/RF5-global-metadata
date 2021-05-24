protected class PointerInputModule.MouseState // TypeDefIndex: 4082
{
	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x16408F0 Offset: 0x16409F1 VA: 0x16408F0
	public bool AnyPressesThisFrame() { }

	// RVA: 0x16409B0 Offset: 0x1640AB1 VA: 0x16409B0
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x1640A70 Offset: 0x1640B71 VA: 0x1640A70
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x163FB30 Offset: 0x163FC31 VA: 0x163FB30
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x16407D0 Offset: 0x16408D1 VA: 0x16407D0
	public void .ctor() { }
}

