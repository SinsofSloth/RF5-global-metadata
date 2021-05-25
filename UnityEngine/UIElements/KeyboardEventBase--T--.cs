public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent // TypeDefIndex: 4185
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x11ED60 Offset: 0x11EE61 VA: 0x11ED60
	[CompilerGeneratedAttribute] // RVA: 0x11ED60 Offset: 0x11EE61 VA: 0x11ED60
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11EDA0 Offset: 0x11EEA1 VA: 0x11EDA0
	[DebuggerBrowsableAttribute] // RVA: 0x11EDA0 Offset: 0x11EEA1 VA: 0x11EDA0
	private char <character>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11EDE0 Offset: 0x11EEE1 VA: 0x11EDE0
	[DebuggerBrowsableAttribute] // RVA: 0x11EDE0 Offset: 0x11EEE1 VA: 0x11EDE0
	private KeyCode <keyCode>k__BackingField; // 0x0

	// Properties
	protected EventModifiers modifiers { set; }
	protected char character { set; }
	protected KeyCode keyCode { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FC70 Offset: 0x11FD71 VA: 0x11FC70
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEE50 Offset: 0x2AAEF51 VA: 0x2AAEE50
	|-KeyboardEventBase<object>.set_modifiers
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FC80 Offset: 0x11FD81 VA: 0x11FC80
	// RVA: -1 Offset: -1
	protected void set_character(char value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEE60 Offset: 0x2AAEF61 VA: 0x2AAEE60
	|-KeyboardEventBase<object>.set_character
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FC90 Offset: 0x11FD91 VA: 0x11FC90
	// RVA: -1 Offset: -1
	protected void set_keyCode(KeyCode value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEE70 Offset: 0x2AAEF71 VA: 0x2AAEE70
	|-KeyboardEventBase<object>.set_keyCode
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEE80 Offset: 0x2AAEF81 VA: 0x2AAEE80
	|-KeyboardEventBase<object>.Init
	|-KeyboardEventBase<KeyDownEvent>.Init
	|-KeyboardEventBase<KeyUpEvent>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEED0 Offset: 0x2AAEFD1 VA: 0x2AAEED0
	|-KeyboardEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEF50 Offset: 0x2AAF051 VA: 0x2AAEF50
	|-KeyboardEventBase<object>.GetPooled
	|-KeyboardEventBase<KeyDownEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF1D0 Offset: 0x2AAF2D1 VA: 0x2AAF1D0
	|-KeyboardEventBase<object>.GetPooled
	|-KeyboardEventBase<KeyDownEvent>.GetPooled
	|-KeyboardEventBase<KeyUpEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF480 Offset: 0x2AAF581 VA: 0x2AAF480
	|-KeyboardEventBase<object>..ctor
	|-KeyboardEventBase<KeyDownEvent>..ctor
	|-KeyboardEventBase<KeyUpEvent>..ctor
	*/
}

