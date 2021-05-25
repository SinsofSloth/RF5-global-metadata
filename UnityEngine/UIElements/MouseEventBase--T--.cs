public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal // TypeDefIndex: 4193
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x11EE20 Offset: 0x11EF21 VA: 0x11EE20
	[CompilerGeneratedAttribute] // RVA: 0x11EE20 Offset: 0x11EF21 VA: 0x11EE20
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EE60 Offset: 0x11EF61 VA: 0x11EE60
	[CompilerGeneratedAttribute] // RVA: 0x11EE60 Offset: 0x11EF61 VA: 0x11EE60
	private Vector2 <mousePosition>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EEA0 Offset: 0x11EFA1 VA: 0x11EEA0
	[CompilerGeneratedAttribute] // RVA: 0x11EEA0 Offset: 0x11EFA1 VA: 0x11EEA0
	private Vector2 <localMousePosition>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EEE0 Offset: 0x11EFE1 VA: 0x11EEE0
	[CompilerGeneratedAttribute] // RVA: 0x11EEE0 Offset: 0x11EFE1 VA: 0x11EEE0
	private Vector2 <mouseDelta>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EF20 Offset: 0x11F021 VA: 0x11EF20
	[CompilerGeneratedAttribute] // RVA: 0x11EF20 Offset: 0x11F021 VA: 0x11EF20
	private int <clickCount>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EF60 Offset: 0x11F061 VA: 0x11EF60
	[CompilerGeneratedAttribute] // RVA: 0x11EF60 Offset: 0x11F061 VA: 0x11EF60
	private int <button>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EFA0 Offset: 0x11F0A1 VA: 0x11EFA0
	[CompilerGeneratedAttribute] // RVA: 0x11EFA0 Offset: 0x11F0A1 VA: 0x11EFA0
	private int <pressedButtons>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11EFE0 Offset: 0x11F0E1 VA: 0x11EFE0
	[CompilerGeneratedAttribute] // RVA: 0x11EFE0 Offset: 0x11F0E1 VA: 0x11EFE0
	private bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F020 Offset: 0x11F121 VA: 0x11F020
	[CompilerGeneratedAttribute] // RVA: 0x11F020 Offset: 0x11F121 VA: 0x11F020
	private bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F060 Offset: 0x11F161 VA: 0x11F060
	[DebuggerBrowsableAttribute] // RVA: 0x11F060 Offset: 0x11F161 VA: 0x11F060
	private IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0x0

	// Properties
	public EventModifiers modifiers { get; set; }
	public Vector2 mousePosition { get; set; }
	internal Vector2 localMousePosition { set; }
	public Vector2 mouseDelta { get; set; }
	public int clickCount { get; set; }
	public int button { get; set; }
	public int pressedButtons { get; set; }
	private bool UnityEngine.UIElements.IMouseEventInternal.triggeredByOS { get; set; }
	private bool UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse { get; set; }
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent { get; set; }
	public override IEventHandler currentTarget { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FCA0 Offset: 0x11FDA1 VA: 0x11FCA0
	// RVA: -1 Offset: -1 Slot: 15
	public EventModifiers get_modifiers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF5B0 Offset: 0x2AAF6B1 VA: 0x2AAF5B0
	|-MouseEventBase<object>.get_modifiers
	|-MouseEventBase<ContextClickEvent>.get_modifiers
	|-MouseEventBase<DragEnterEvent>.get_modifiers
	|-MouseEventBase<DragExitedEvent>.get_modifiers
	|-MouseEventBase<DragLeaveEvent>.get_modifiers
	|-MouseEventBase<DragPerformEvent>.get_modifiers
	|-MouseEventBase<DragUpdatedEvent>.get_modifiers
	|-MouseEventBase<MouseDownEvent>.get_modifiers
	|-MouseEventBase<MouseEnterEvent>.get_modifiers
	|-MouseEventBase<MouseEnterWindowEvent>.get_modifiers
	|-MouseEventBase<MouseLeaveEvent>.get_modifiers
	|-MouseEventBase<MouseLeaveWindowEvent>.get_modifiers
	|-MouseEventBase<MouseMoveEvent>.get_modifiers
	|-MouseEventBase<MouseOutEvent>.get_modifiers
	|-MouseEventBase<MouseOverEvent>.get_modifiers
	|-MouseEventBase<MouseUpEvent>.get_modifiers
	|-MouseEventBase<WheelEvent>.get_modifiers
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FCB0 Offset: 0x11FDB1 VA: 0x11FCB0
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF5C0 Offset: 0x2AAF6C1 VA: 0x2AAF5C0
	|-MouseEventBase<object>.set_modifiers
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FCC0 Offset: 0x11FDC1 VA: 0x11FCC0
	// RVA: -1 Offset: -1 Slot: 16
	public Vector2 get_mousePosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF5D0 Offset: 0x2AAF6D1 VA: 0x2AAF5D0
	|-MouseEventBase<object>.get_mousePosition
	|-MouseEventBase<ContextClickEvent>.get_mousePosition
	|-MouseEventBase<DragEnterEvent>.get_mousePosition
	|-MouseEventBase<DragExitedEvent>.get_mousePosition
	|-MouseEventBase<DragLeaveEvent>.get_mousePosition
	|-MouseEventBase<DragPerformEvent>.get_mousePosition
	|-MouseEventBase<DragUpdatedEvent>.get_mousePosition
	|-MouseEventBase<MouseDownEvent>.get_mousePosition
	|-MouseEventBase<MouseEnterEvent>.get_mousePosition
	|-MouseEventBase<MouseEnterWindowEvent>.get_mousePosition
	|-MouseEventBase<MouseLeaveEvent>.get_mousePosition
	|-MouseEventBase<MouseLeaveWindowEvent>.get_mousePosition
	|-MouseEventBase<MouseMoveEvent>.get_mousePosition
	|-MouseEventBase<MouseOutEvent>.get_mousePosition
	|-MouseEventBase<MouseOverEvent>.get_mousePosition
	|-MouseEventBase<MouseUpEvent>.get_mousePosition
	|-MouseEventBase<WheelEvent>.get_mousePosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FCD0 Offset: 0x11FDD1 VA: 0x11FCD0
	// RVA: -1 Offset: -1
	protected void set_mousePosition(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF5E0 Offset: 0x2AAF6E1 VA: 0x2AAF5E0
	|-MouseEventBase<object>.set_mousePosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FCE0 Offset: 0x11FDE1 VA: 0x11FCE0
	// RVA: -1 Offset: -1
	internal void set_localMousePosition(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF5F0 Offset: 0x2AAF6F1 VA: 0x2AAF5F0
	|-MouseEventBase<object>.set_localMousePosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FCF0 Offset: 0x11FDF1 VA: 0x11FCF0
	// RVA: -1 Offset: -1 Slot: 17
	public Vector2 get_mouseDelta() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF600 Offset: 0x2AAF701 VA: 0x2AAF600
	|-MouseEventBase<object>.get_mouseDelta
	|-MouseEventBase<ContextClickEvent>.get_mouseDelta
	|-MouseEventBase<DragEnterEvent>.get_mouseDelta
	|-MouseEventBase<DragExitedEvent>.get_mouseDelta
	|-MouseEventBase<DragLeaveEvent>.get_mouseDelta
	|-MouseEventBase<DragPerformEvent>.get_mouseDelta
	|-MouseEventBase<DragUpdatedEvent>.get_mouseDelta
	|-MouseEventBase<MouseDownEvent>.get_mouseDelta
	|-MouseEventBase<MouseEnterEvent>.get_mouseDelta
	|-MouseEventBase<MouseEnterWindowEvent>.get_mouseDelta
	|-MouseEventBase<MouseLeaveEvent>.get_mouseDelta
	|-MouseEventBase<MouseLeaveWindowEvent>.get_mouseDelta
	|-MouseEventBase<MouseMoveEvent>.get_mouseDelta
	|-MouseEventBase<MouseOutEvent>.get_mouseDelta
	|-MouseEventBase<MouseOverEvent>.get_mouseDelta
	|-MouseEventBase<MouseUpEvent>.get_mouseDelta
	|-MouseEventBase<WheelEvent>.get_mouseDelta
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD00 Offset: 0x11FE01 VA: 0x11FD00
	// RVA: -1 Offset: -1
	protected void set_mouseDelta(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF610 Offset: 0x2AAF711 VA: 0x2AAF610
	|-MouseEventBase<object>.set_mouseDelta
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD10 Offset: 0x11FE11 VA: 0x11FD10
	// RVA: -1 Offset: -1 Slot: 18
	public int get_clickCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF620 Offset: 0x2AAF721 VA: 0x2AAF620
	|-MouseEventBase<object>.get_clickCount
	|-MouseEventBase<ContextClickEvent>.get_clickCount
	|-MouseEventBase<DragEnterEvent>.get_clickCount
	|-MouseEventBase<DragExitedEvent>.get_clickCount
	|-MouseEventBase<DragLeaveEvent>.get_clickCount
	|-MouseEventBase<DragPerformEvent>.get_clickCount
	|-MouseEventBase<DragUpdatedEvent>.get_clickCount
	|-MouseEventBase<MouseDownEvent>.get_clickCount
	|-MouseEventBase<MouseEnterEvent>.get_clickCount
	|-MouseEventBase<MouseEnterWindowEvent>.get_clickCount
	|-MouseEventBase<MouseLeaveEvent>.get_clickCount
	|-MouseEventBase<MouseLeaveWindowEvent>.get_clickCount
	|-MouseEventBase<MouseMoveEvent>.get_clickCount
	|-MouseEventBase<MouseOutEvent>.get_clickCount
	|-MouseEventBase<MouseOverEvent>.get_clickCount
	|-MouseEventBase<MouseUpEvent>.get_clickCount
	|-MouseEventBase<WheelEvent>.get_clickCount
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD20 Offset: 0x11FE21 VA: 0x11FD20
	// RVA: -1 Offset: -1
	protected void set_clickCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF630 Offset: 0x2AAF731 VA: 0x2AAF630
	|-MouseEventBase<object>.set_clickCount
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD30 Offset: 0x11FE31 VA: 0x11FD30
	// RVA: -1 Offset: -1 Slot: 19
	public int get_button() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF640 Offset: 0x2AAF741 VA: 0x2AAF640
	|-MouseEventBase<object>.get_button
	|-MouseEventBase<ContextClickEvent>.get_button
	|-MouseEventBase<DragEnterEvent>.get_button
	|-MouseEventBase<DragExitedEvent>.get_button
	|-MouseEventBase<DragLeaveEvent>.get_button
	|-MouseEventBase<DragPerformEvent>.get_button
	|-MouseEventBase<DragUpdatedEvent>.get_button
	|-MouseEventBase<MouseDownEvent>.get_button
	|-MouseEventBase<MouseEnterEvent>.get_button
	|-MouseEventBase<MouseEnterWindowEvent>.get_button
	|-MouseEventBase<MouseLeaveEvent>.get_button
	|-MouseEventBase<MouseLeaveWindowEvent>.get_button
	|-MouseEventBase<MouseMoveEvent>.get_button
	|-MouseEventBase<MouseOutEvent>.get_button
	|-MouseEventBase<MouseOverEvent>.get_button
	|-MouseEventBase<MouseUpEvent>.get_button
	|-MouseEventBase<WheelEvent>.get_button
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD40 Offset: 0x11FE41 VA: 0x11FD40
	// RVA: -1 Offset: -1
	protected void set_button(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF650 Offset: 0x2AAF751 VA: 0x2AAF650
	|-MouseEventBase<object>.set_button
	|-MouseEventBase<DragUpdatedEvent>.set_button
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD50 Offset: 0x11FE51 VA: 0x11FD50
	// RVA: -1 Offset: -1 Slot: 20
	public int get_pressedButtons() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF660 Offset: 0x2AAF761 VA: 0x2AAF660
	|-MouseEventBase<object>.get_pressedButtons
	|-MouseEventBase<ContextClickEvent>.get_pressedButtons
	|-MouseEventBase<DragEnterEvent>.get_pressedButtons
	|-MouseEventBase<DragExitedEvent>.get_pressedButtons
	|-MouseEventBase<DragLeaveEvent>.get_pressedButtons
	|-MouseEventBase<DragPerformEvent>.get_pressedButtons
	|-MouseEventBase<DragUpdatedEvent>.get_pressedButtons
	|-MouseEventBase<MouseDownEvent>.get_pressedButtons
	|-MouseEventBase<MouseEnterEvent>.get_pressedButtons
	|-MouseEventBase<MouseEnterWindowEvent>.get_pressedButtons
	|-MouseEventBase<MouseLeaveEvent>.get_pressedButtons
	|-MouseEventBase<MouseLeaveWindowEvent>.get_pressedButtons
	|-MouseEventBase<MouseMoveEvent>.get_pressedButtons
	|-MouseEventBase<MouseOutEvent>.get_pressedButtons
	|-MouseEventBase<MouseOverEvent>.get_pressedButtons
	|-MouseEventBase<MouseUpEvent>.get_pressedButtons
	|-MouseEventBase<WheelEvent>.get_pressedButtons
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD60 Offset: 0x11FE61 VA: 0x11FD60
	// RVA: -1 Offset: -1
	protected void set_pressedButtons(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF670 Offset: 0x2AAF771 VA: 0x2AAF670
	|-MouseEventBase<object>.set_pressedButtons
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD70 Offset: 0x11FE71 VA: 0x11FD70
	// RVA: -1 Offset: -1 Slot: 21
	private bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF680 Offset: 0x2AAF781 VA: 0x2AAF680
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<ContextClickEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<DragEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<DragExitedEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<DragLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<DragPerformEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<DragUpdatedEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseDownEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseEnterWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseLeaveWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseMoveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseOutEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseOverEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<MouseUpEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	|-MouseEventBase<WheelEvent>.UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD80 Offset: 0x11FE81 VA: 0x11FD80
	// RVA: -1 Offset: -1 Slot: 22
	private void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF690 Offset: 0x2AAF791 VA: 0x2AAF690
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<ContextClickEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<DragEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<DragExitedEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<DragLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<DragPerformEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<DragUpdatedEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseDownEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseEnterWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseLeaveWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseMoveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseOutEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseOverEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<MouseUpEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	|-MouseEventBase<WheelEvent>.UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FD90 Offset: 0x11FE91 VA: 0x11FD90
	// RVA: -1 Offset: -1 Slot: 23
	private bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF6A0 Offset: 0x2AAF7A1 VA: 0x2AAF6A0
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<ContextClickEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<DragEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<DragExitedEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<DragLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<DragPerformEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<DragUpdatedEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseDownEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseEnterWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseLeaveWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseMoveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseOutEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseOverEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseUpEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	|-MouseEventBase<WheelEvent>.UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FDA0 Offset: 0x11FEA1 VA: 0x11FDA0
	// RVA: -1 Offset: -1 Slot: 24
	private void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF6B0 Offset: 0x2AAF7B1 VA: 0x2AAF6B0
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<ContextClickEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<DragEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<DragExitedEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<DragLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<DragPerformEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<DragUpdatedEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseDownEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseEnterWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseLeaveWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseMoveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseOutEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseOverEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<MouseUpEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	|-MouseEventBase<WheelEvent>.UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FDB0 Offset: 0x11FEB1 VA: 0x11FDB0
	// RVA: -1 Offset: -1 Slot: 25
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF6C0 Offset: 0x2AAF7C1 VA: 0x2AAF6C0
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<ContextClickEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<DragEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<DragExitedEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<DragLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<DragPerformEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<DragUpdatedEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseDownEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseEnterWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseLeaveWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseMoveEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseOutEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseOverEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<MouseUpEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	|-MouseEventBase<WheelEvent>.UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FDC0 Offset: 0x11FEC1 VA: 0x11FDC0
	// RVA: -1 Offset: -1 Slot: 26
	private void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF6D0 Offset: 0x2AAF7D1 VA: 0x2AAF6D0
	|-MouseEventBase<object>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<ContextClickEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<DragEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<DragExitedEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<DragLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<DragPerformEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<DragUpdatedEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseDownEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseEnterEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseEnterWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseLeaveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseLeaveWindowEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseMoveEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseOutEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseOverEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<MouseUpEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	|-MouseEventBase<WheelEvent>.UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF6E0 Offset: 0x2AAF7E1 VA: 0x2AAF6E0
	|-MouseEventBase<object>.Init
	|-MouseEventBase<ContextClickEvent>.Init
	|-MouseEventBase<DragEnterEvent>.Init
	|-MouseEventBase<DragExitedEvent>.Init
	|-MouseEventBase<DragLeaveEvent>.Init
	|-MouseEventBase<DragPerformEvent>.Init
	|-MouseEventBase<DragUpdatedEvent>.Init
	|-MouseEventBase<MouseDownEvent>.Init
	|-MouseEventBase<MouseEnterEvent>.Init
	|-MouseEventBase<MouseEnterWindowEvent>.Init
	|-MouseEventBase<MouseLeaveEvent>.Init
	|-MouseEventBase<MouseLeaveWindowEvent>.Init
	|-MouseEventBase<MouseMoveEvent>.Init
	|-MouseEventBase<MouseOutEvent>.Init
	|-MouseEventBase<MouseOverEvent>.Init
	|-MouseEventBase<MouseUpEvent>.Init
	|-MouseEventBase<WheelEvent>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF730 Offset: 0x2AAF831 VA: 0x2AAF730
	|-MouseEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override IEventHandler get_currentTarget() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF9C0 Offset: 0x2AAFAC1 VA: 0x2AAF9C0
	|-MouseEventBase<object>.get_currentTarget
	|-MouseEventBase<ContextClickEvent>.get_currentTarget
	|-MouseEventBase<DragEnterEvent>.get_currentTarget
	|-MouseEventBase<DragExitedEvent>.get_currentTarget
	|-MouseEventBase<DragLeaveEvent>.get_currentTarget
	|-MouseEventBase<DragPerformEvent>.get_currentTarget
	|-MouseEventBase<DragUpdatedEvent>.get_currentTarget
	|-MouseEventBase<MouseDownEvent>.get_currentTarget
	|-MouseEventBase<MouseEnterEvent>.get_currentTarget
	|-MouseEventBase<MouseEnterWindowEvent>.get_currentTarget
	|-MouseEventBase<MouseLeaveEvent>.get_currentTarget
	|-MouseEventBase<MouseLeaveWindowEvent>.get_currentTarget
	|-MouseEventBase<MouseMoveEvent>.get_currentTarget
	|-MouseEventBase<MouseOutEvent>.get_currentTarget
	|-MouseEventBase<MouseOverEvent>.get_currentTarget
	|-MouseEventBase<MouseUpEvent>.get_currentTarget
	|-MouseEventBase<WheelEvent>.get_currentTarget
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override void set_currentTarget(IEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF9E0 Offset: 0x2AAFAE1 VA: 0x2AAF9E0
	|-MouseEventBase<object>.set_currentTarget
	|-MouseEventBase<ContextClickEvent>.set_currentTarget
	|-MouseEventBase<DragEnterEvent>.set_currentTarget
	|-MouseEventBase<DragExitedEvent>.set_currentTarget
	|-MouseEventBase<DragLeaveEvent>.set_currentTarget
	|-MouseEventBase<DragPerformEvent>.set_currentTarget
	|-MouseEventBase<DragUpdatedEvent>.set_currentTarget
	|-MouseEventBase<MouseDownEvent>.set_currentTarget
	|-MouseEventBase<MouseEnterEvent>.set_currentTarget
	|-MouseEventBase<MouseEnterWindowEvent>.set_currentTarget
	|-MouseEventBase<MouseLeaveEvent>.set_currentTarget
	|-MouseEventBase<MouseLeaveWindowEvent>.set_currentTarget
	|-MouseEventBase<MouseMoveEvent>.set_currentTarget
	|-MouseEventBase<MouseOutEvent>.set_currentTarget
	|-MouseEventBase<MouseOverEvent>.set_currentTarget
	|-MouseEventBase<MouseUpEvent>.set_currentTarget
	|-MouseEventBase<WheelEvent>.set_currentTarget
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected internal override void PreDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAFAB0 Offset: 0x2AAFBB1 VA: 0x2AAFAB0
	|-MouseEventBase<object>.PreDispatch
	|-MouseEventBase<ContextClickEvent>.PreDispatch
	|-MouseEventBase<DragEnterEvent>.PreDispatch
	|-MouseEventBase<DragExitedEvent>.PreDispatch
	|-MouseEventBase<DragLeaveEvent>.PreDispatch
	|-MouseEventBase<DragPerformEvent>.PreDispatch
	|-MouseEventBase<DragUpdatedEvent>.PreDispatch
	|-MouseEventBase<MouseDownEvent>.PreDispatch
	|-MouseEventBase<MouseEnterEvent>.PreDispatch
	|-MouseEventBase<MouseEnterWindowEvent>.PreDispatch
	|-MouseEventBase<MouseLeaveEvent>.PreDispatch
	|-MouseEventBase<MouseLeaveWindowEvent>.PreDispatch
	|-MouseEventBase<MouseMoveEvent>.PreDispatch
	|-MouseEventBase<MouseOutEvent>.PreDispatch
	|-MouseEventBase<MouseOverEvent>.PreDispatch
	|-MouseEventBase<MouseUpEvent>.PreDispatch
	|-MouseEventBase<WheelEvent>.PreDispatch
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override void PostDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAFC30 Offset: 0x2AAFD31 VA: 0x2AAFC30
	|-MouseEventBase<object>.PostDispatch
	|-MouseEventBase<ContextClickEvent>.PostDispatch
	|-MouseEventBase<DragEnterEvent>.PostDispatch
	|-MouseEventBase<DragExitedEvent>.PostDispatch
	|-MouseEventBase<DragLeaveEvent>.PostDispatch
	|-MouseEventBase<DragPerformEvent>.PostDispatch
	|-MouseEventBase<DragUpdatedEvent>.PostDispatch
	|-MouseEventBase<MouseDownEvent>.PostDispatch
	|-MouseEventBase<MouseEnterEvent>.PostDispatch
	|-MouseEventBase<MouseEnterWindowEvent>.PostDispatch
	|-MouseEventBase<MouseLeaveEvent>.PostDispatch
	|-MouseEventBase<MouseLeaveWindowEvent>.PostDispatch
	|-MouseEventBase<MouseMoveEvent>.PostDispatch
	|-MouseEventBase<MouseOutEvent>.PostDispatch
	|-MouseEventBase<MouseOverEvent>.PostDispatch
	|-MouseEventBase<MouseUpEvent>.PostDispatch
	|-MouseEventBase<WheelEvent>.PostDispatch
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAFDF0 Offset: 0x2AAFEF1 VA: 0x2AAFDF0
	|-MouseEventBase<object>.GetPooled
	|-MouseEventBase<ContextClickEvent>.GetPooled
	|-MouseEventBase<DragExitedEvent>.GetPooled
	|-MouseEventBase<DragPerformEvent>.GetPooled
	|-MouseEventBase<DragUpdatedEvent>.GetPooled
	|-MouseEventBase<MouseEnterWindowEvent>.GetPooled
	|-MouseEventBase<MouseLeaveWindowEvent>.GetPooled
	|-MouseEventBase<WheelEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB0380 Offset: 0x2AB0481 VA: 0x2AB0380
	|-MouseEventBase<object>.GetPooled
	|-MouseEventBase<MouseOutEvent>.GetPooled
	|-MouseEventBase<MouseOverEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IMouseEvent triggerEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB0690 Offset: 0x2AB0791 VA: 0x2AB0690
	|-MouseEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected static T GetPooled(IPointerEvent pointerEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB0EB0 Offset: 0x2AB0FB1 VA: 0x2AB0EB0
	|-MouseEventBase<object>.GetPooled
	|-MouseEventBase<MouseDownEvent>.GetPooled
	|-MouseEventBase<MouseMoveEvent>.GetPooled
	|-MouseEventBase<MouseUpEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB18B0 Offset: 0x2AB19B1 VA: 0x2AB18B0
	|-MouseEventBase<object>..ctor
	|-MouseEventBase<ContextClickEvent>..ctor
	|-MouseEventBase<MouseDownEvent>..ctor
	|-MouseEventBase<MouseEnterEvent>..ctor
	|-MouseEventBase<MouseEnterWindowEvent>..ctor
	|-MouseEventBase<MouseLeaveEvent>..ctor
	|-MouseEventBase<MouseLeaveWindowEvent>..ctor
	|-MouseEventBase<MouseMoveEvent>..ctor
	|-MouseEventBase<MouseOutEvent>..ctor
	|-MouseEventBase<MouseOverEvent>..ctor
	|-MouseEventBase<MouseUpEvent>..ctor
	|-MouseEventBase<WheelEvent>..ctor
	*/
}

