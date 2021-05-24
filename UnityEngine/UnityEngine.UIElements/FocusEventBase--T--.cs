public abstract class FocusEventBase<T> : EventBase<T> // TypeDefIndex: 4174
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x11ECA0 Offset: 0x11EDA1 VA: 0x11ECA0
	[DebuggerBrowsableAttribute] // RVA: 0x11ECA0 Offset: 0x11EDA1 VA: 0x11ECA0
	private Focusable <relatedTarget>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11ECE0 Offset: 0x11EDE1 VA: 0x11ECE0
	[DebuggerBrowsableAttribute] // RVA: 0x11ECE0 Offset: 0x11EDE1 VA: 0x11ECE0
	private FocusChangeDirection <direction>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11ED20 Offset: 0x11EE21 VA: 0x11ED20
	[DebuggerBrowsableAttribute] // RVA: 0x11ED20 Offset: 0x11EE21 VA: 0x11ED20
	private FocusController <focusController>k__BackingField; // 0x0

	// Properties
	public Focusable relatedTarget { get; set; }
	private FocusChangeDirection direction { set; }
	protected FocusController focusController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FC20 Offset: 0x11FD21 VA: 0x11FC20
	// RVA: -1 Offset: -1 Slot: 15
	public Focusable get_relatedTarget() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE910 Offset: 0x2AAEA11 VA: 0x2AAE910
	|-FocusEventBase<object>.get_relatedTarget
	|-FocusEventBase<BlurEvent>.get_relatedTarget
	|-FocusEventBase<FocusEvent>.get_relatedTarget
	|-FocusEventBase<FocusInEvent>.get_relatedTarget
	|-FocusEventBase<FocusOutEvent>.get_relatedTarget
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FC30 Offset: 0x11FD31 VA: 0x11FC30
	// RVA: -1 Offset: -1
	private void set_relatedTarget(Focusable value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE920 Offset: 0x2AAEA21 VA: 0x2AAE920
	|-FocusEventBase<object>.set_relatedTarget
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FC40 Offset: 0x11FD41 VA: 0x11FC40
	// RVA: -1 Offset: -1
	private void set_direction(FocusChangeDirection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE930 Offset: 0x2AAEA31 VA: 0x2AAE930
	|-FocusEventBase<object>.set_direction
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FC50 Offset: 0x11FD51 VA: 0x11FC50
	// RVA: -1 Offset: -1
	protected FocusController get_focusController() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE940 Offset: 0x2AAEA41 VA: 0x2AAE940
	|-FocusEventBase<object>.get_focusController
	|-FocusEventBase<BlurEvent>.get_focusController
	|-FocusEventBase<FocusEvent>.get_focusController
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FC60 Offset: 0x11FD61 VA: 0x11FC60
	// RVA: -1 Offset: -1
	private void set_focusController(FocusController value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE950 Offset: 0x2AAEA51 VA: 0x2AAE950
	|-FocusEventBase<object>.set_focusController
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE960 Offset: 0x2AAEA61 VA: 0x2AAE960
	|-FocusEventBase<object>.Init
	|-FocusEventBase<BlurEvent>.Init
	|-FocusEventBase<FocusEvent>.Init
	|-FocusEventBase<FocusInEvent>.Init
	|-FocusEventBase<FocusOutEvent>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE9B0 Offset: 0x2AAEAB1 VA: 0x2AAE9B0
	|-FocusEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEAF0 Offset: 0x2AAEBF1 VA: 0x2AAEAF0
	|-FocusEventBase<object>.GetPooled
	|-FocusEventBase<BlurEvent>.GetPooled
	|-FocusEventBase<FocusEvent>.GetPooled
	|-FocusEventBase<FocusInEvent>.GetPooled
	|-FocusEventBase<FocusOutEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAED80 Offset: 0x2AAEE81 VA: 0x2AAED80
	|-FocusEventBase<object>..ctor
	|-FocusEventBase<BlurEvent>..ctor
	|-FocusEventBase<FocusEvent>..ctor
	|-FocusEventBase<FocusInEvent>..ctor
	|-FocusEventBase<FocusOutEvent>..ctor
	*/
}

