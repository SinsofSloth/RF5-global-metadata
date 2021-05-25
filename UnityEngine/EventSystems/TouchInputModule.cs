[ObsoleteAttribute] // RVA: 0x11AB30 Offset: 0x11AC31 VA: 0x11AB30
[AddComponentMenu] // RVA: 0x11AB30 Offset: 0x11AC31 VA: 0x11AB30
public class TouchInputModule : PointerInputModule // TypeDefIndex: 4086
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x58
	private Vector2 m_MousePosition; // 0x60
	private PointerEventData m_InputPointerEvent; // 0x68
	[SerializeField] // RVA: 0x11CCF0 Offset: 0x11CDF1 VA: 0x11CCF0
	[FormerlySerializedAsAttribute] // RVA: 0x11CCF0 Offset: 0x11CDF1 VA: 0x11CCF0
	private bool m_ForceModuleActive; // 0x70

	// Properties
	[ObsoleteAttribute] // RVA: 0x11DC20 Offset: 0x11DD21 VA: 0x11DC20
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x16434C0 Offset: 0x16435C1 VA: 0x16434C0
	protected void .ctor() { }

	// RVA: 0x16434D0 Offset: 0x16435D1 VA: 0x16434D0
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x16434E0 Offset: 0x16435E1 VA: 0x16434E0
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x16434F0 Offset: 0x16435F1 VA: 0x16434F0
	public bool get_forceModuleActive() { }

	// RVA: 0x1643500 Offset: 0x1643601 VA: 0x1643500
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1643510 Offset: 0x1643611 VA: 0x1643510 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x1643690 Offset: 0x1643791 VA: 0x1643690 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x16436D0 Offset: 0x16437D1 VA: 0x16436D0 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x1643840 Offset: 0x1643941 VA: 0x1643840
	private bool UseFakeInput() { }

	// RVA: 0x1643880 Offset: 0x1643981 VA: 0x1643880 Slot: 17
	public override void Process() { }

	// RVA: 0x16438D0 Offset: 0x16439D1 VA: 0x16438D0
	private void FakeTouches() { }

	// RVA: 0x1643A20 Offset: 0x1643B21 VA: 0x1643A20
	private void ProcessTouchEvents() { }

	// RVA: 0x1643C00 Offset: 0x1643D01 VA: 0x1643C00
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1644510 Offset: 0x1644611 VA: 0x1644510 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x1644520 Offset: 0x1644621 VA: 0x1644520 Slot: 3
	public override string ToString() { }
}

