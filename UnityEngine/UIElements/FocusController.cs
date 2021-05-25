public class FocusController // TypeDefIndex: 4112
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x11E2A0 Offset: 0x11E3A1 VA: 0x11E2A0
	[DebuggerBrowsableAttribute] // RVA: 0x11E2A0 Offset: 0x11E3A1 VA: 0x11E2A0
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private List<FocusController.FocusedElement> m_FocusedElements; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x11E2E0 Offset: 0x11E3E1 VA: 0x11E2E0
	[CompilerGeneratedAttribute] // RVA: 0x11E2E0 Offset: 0x11E3E1 VA: 0x11E2E0
	private int <imguiKeyboardControl>k__BackingField; // 0x20

	// Properties
	private IFocusRing focusRing { get; }
	internal int imguiKeyboardControl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11F750 Offset: 0x11F851 VA: 0x11F750
	// RVA: 0x15BDEE0 Offset: 0x15BDFE1 VA: 0x15BDEE0
	private IFocusRing get_focusRing() { }

	// RVA: 0x15B8680 Offset: 0x15B8781 VA: 0x15B8680
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0x15B7BA0 Offset: 0x15B7CA1 VA: 0x15B7BA0
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0x15BDEF0 Offset: 0x15BDFF1 VA: 0x15BDEF0
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0x15BE030 Offset: 0x15BE131 VA: 0x15BE030
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction) { }

	// RVA: 0x15BE170 Offset: 0x15BE271 VA: 0x15BE170
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0x15BE2B0 Offset: 0x15BE3B1 VA: 0x15BE2B0
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction) { }

	// RVA: 0x15BE3F0 Offset: 0x15BE4F1 VA: 0x15BE3F0
	private void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction) { }

	// RVA: 0x15BE7B0 Offset: 0x15BE8B1 VA: 0x15BE7B0
	internal Focusable SwitchFocusOnEvent(EventBase e) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F760 Offset: 0x11F861 VA: 0x11F760
	// RVA: 0x15BEAB0 Offset: 0x15BEBB1 VA: 0x15BEAB0
	internal int get_imguiKeyboardControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F770 Offset: 0x11F871 VA: 0x11F770
	// RVA: 0x15BEAC0 Offset: 0x15BEBC1 VA: 0x15BEAC0
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0x15BEAD0 Offset: 0x15BEBD1 VA: 0x15BEAD0
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }
}

