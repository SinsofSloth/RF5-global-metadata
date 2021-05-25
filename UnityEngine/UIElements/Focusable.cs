public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 4109
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x11E1A0 Offset: 0x11E2A1 VA: 0x11E1A0
	[CompilerGeneratedAttribute] // RVA: 0x11E1A0 Offset: 0x11E2A1 VA: 0x11E1A0
	private bool <focusable>k__BackingField; // 0x18
	internal bool isIMGUIContainer; // 0x19

	// Properties
	public abstract FocusController focusController { get; }
	public bool focusable { get; }
	public virtual bool canGrabFocus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract FocusController get_focusController() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F710 Offset: 0x11F811 VA: 0x11F710
	// RVA: 0x15BEF00 Offset: 0x15BF001 VA: 0x15BEF00
	public bool get_focusable() { }

	// RVA: 0x15BEF10 Offset: 0x15BF011 VA: 0x15BEF10 Slot: 13
	public virtual bool get_canGrabFocus() { }
}

