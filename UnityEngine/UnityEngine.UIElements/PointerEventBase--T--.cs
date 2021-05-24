public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal // TypeDefIndex: 4214
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x11F0E0 Offset: 0x11F1E1 VA: 0x11F0E0
	[DebuggerBrowsableAttribute] // RVA: 0x11F0E0 Offset: 0x11F1E1 VA: 0x11F0E0
	private int <pointerId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F120 Offset: 0x11F221 VA: 0x11F120
	[DebuggerBrowsableAttribute] // RVA: 0x11F120 Offset: 0x11F221 VA: 0x11F120
	private string <pointerType>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F160 Offset: 0x11F261 VA: 0x11F160
	[CompilerGeneratedAttribute] // RVA: 0x11F160 Offset: 0x11F261 VA: 0x11F160
	private bool <isPrimary>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F1A0 Offset: 0x11F2A1 VA: 0x11F1A0
	[CompilerGeneratedAttribute] // RVA: 0x11F1A0 Offset: 0x11F2A1 VA: 0x11F1A0
	private int <button>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F1E0 Offset: 0x11F2E1 VA: 0x11F1E0
	[DebuggerBrowsableAttribute] // RVA: 0x11F1E0 Offset: 0x11F2E1 VA: 0x11F1E0
	private int <pressedButtons>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F220 Offset: 0x11F321 VA: 0x11F220
	[DebuggerBrowsableAttribute] // RVA: 0x11F220 Offset: 0x11F321 VA: 0x11F220
	private Vector3 <position>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F260 Offset: 0x11F361 VA: 0x11F260
	[DebuggerBrowsableAttribute] // RVA: 0x11F260 Offset: 0x11F361 VA: 0x11F260
	private Vector3 <localPosition>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F2A0 Offset: 0x11F3A1 VA: 0x11F2A0
	[DebuggerBrowsableAttribute] // RVA: 0x11F2A0 Offset: 0x11F3A1 VA: 0x11F2A0
	private Vector3 <deltaPosition>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F2E0 Offset: 0x11F3E1 VA: 0x11F2E0
	[DebuggerBrowsableAttribute] // RVA: 0x11F2E0 Offset: 0x11F3E1 VA: 0x11F2E0
	private float <deltaTime>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F320 Offset: 0x11F421 VA: 0x11F320
	[DebuggerBrowsableAttribute] // RVA: 0x11F320 Offset: 0x11F421 VA: 0x11F320
	private int <clickCount>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F360 Offset: 0x11F461 VA: 0x11F360
	[DebuggerBrowsableAttribute] // RVA: 0x11F360 Offset: 0x11F461 VA: 0x11F360
	private float <pressure>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F3A0 Offset: 0x11F4A1 VA: 0x11F3A0
	[CompilerGeneratedAttribute] // RVA: 0x11F3A0 Offset: 0x11F4A1 VA: 0x11F3A0
	private float <tangentialPressure>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F3E0 Offset: 0x11F4E1 VA: 0x11F3E0
	[CompilerGeneratedAttribute] // RVA: 0x11F3E0 Offset: 0x11F4E1 VA: 0x11F3E0
	private float <altitudeAngle>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F420 Offset: 0x11F521 VA: 0x11F420
	[DebuggerBrowsableAttribute] // RVA: 0x11F420 Offset: 0x11F521 VA: 0x11F420
	private float <azimuthAngle>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F460 Offset: 0x11F561 VA: 0x11F460
	[CompilerGeneratedAttribute] // RVA: 0x11F460 Offset: 0x11F561 VA: 0x11F460
	private float <twist>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F4A0 Offset: 0x11F5A1 VA: 0x11F4A0
	[DebuggerBrowsableAttribute] // RVA: 0x11F4A0 Offset: 0x11F5A1 VA: 0x11F4A0
	private Vector2 <radius>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F4E0 Offset: 0x11F5E1 VA: 0x11F4E0
	[DebuggerBrowsableAttribute] // RVA: 0x11F4E0 Offset: 0x11F5E1 VA: 0x11F4E0
	private Vector2 <radiusVariance>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x11F520 Offset: 0x11F621 VA: 0x11F520
	[CompilerGeneratedAttribute] // RVA: 0x11F520 Offset: 0x11F621 VA: 0x11F520
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F560 Offset: 0x11F661 VA: 0x11F560
	[DebuggerBrowsableAttribute] // RVA: 0x11F560 Offset: 0x11F661 VA: 0x11F560
	private bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F5A0 Offset: 0x11F6A1 VA: 0x11F5A0
	[DebuggerBrowsableAttribute] // RVA: 0x11F5A0 Offset: 0x11F6A1 VA: 0x11F5A0
	private bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField; // 0x0

	// Properties
	public int pointerId { get; set; }
	public string pointerType { get; set; }
	public bool isPrimary { get; set; }
	public int button { get; set; }
	public int pressedButtons { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 deltaPosition { get; set; }
	public float deltaTime { get; set; }
	public int clickCount { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public EventModifiers modifiers { get; set; }
	private bool UnityEngine.UIElements.IPointerEventInternal.triggeredByOS { get; set; }
	private bool UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer { get; set; }
	public override IEventHandler currentTarget { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FDE0 Offset: 0x11FEE1 VA: 0x11FDE0
	// RVA: -1 Offset: -1 Slot: 15
	public int get_pointerId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2130 Offset: 0x2AB2231 VA: 0x2AB2130
	|-PointerEventBase<object>.get_pointerId
	|-PointerEventBase<PointerCancelEvent>.get_pointerId
	|-PointerEventBase<PointerDownEvent>.get_pointerId
	|-PointerEventBase<PointerEnterEvent>.get_pointerId
	|-PointerEventBase<PointerLeaveEvent>.get_pointerId
	|-PointerEventBase<PointerMoveEvent>.get_pointerId
	|-PointerEventBase<PointerOutEvent>.get_pointerId
	|-PointerEventBase<PointerOverEvent>.get_pointerId
	|-PointerEventBase<PointerUpEvent>.get_pointerId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FDF0 Offset: 0x11FEF1 VA: 0x11FDF0
	// RVA: -1 Offset: -1
	protected void set_pointerId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2140 Offset: 0x2AB2241 VA: 0x2AB2140
	|-PointerEventBase<object>.set_pointerId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE00 Offset: 0x11FF01 VA: 0x11FE00
	// RVA: -1 Offset: -1 Slot: 16
	public string get_pointerType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2150 Offset: 0x2AB2251 VA: 0x2AB2150
	|-PointerEventBase<object>.get_pointerType
	|-PointerEventBase<PointerCancelEvent>.get_pointerType
	|-PointerEventBase<PointerDownEvent>.get_pointerType
	|-PointerEventBase<PointerEnterEvent>.get_pointerType
	|-PointerEventBase<PointerLeaveEvent>.get_pointerType
	|-PointerEventBase<PointerMoveEvent>.get_pointerType
	|-PointerEventBase<PointerOutEvent>.get_pointerType
	|-PointerEventBase<PointerOverEvent>.get_pointerType
	|-PointerEventBase<PointerUpEvent>.get_pointerType
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE10 Offset: 0x11FF11 VA: 0x11FE10
	// RVA: -1 Offset: -1
	protected void set_pointerType(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2160 Offset: 0x2AB2261 VA: 0x2AB2160
	|-PointerEventBase<object>.set_pointerType
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE20 Offset: 0x11FF21 VA: 0x11FE20
	// RVA: -1 Offset: -1 Slot: 17
	public bool get_isPrimary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2170 Offset: 0x2AB2271 VA: 0x2AB2170
	|-PointerEventBase<object>.get_isPrimary
	|-PointerEventBase<PointerCancelEvent>.get_isPrimary
	|-PointerEventBase<PointerDownEvent>.get_isPrimary
	|-PointerEventBase<PointerEnterEvent>.get_isPrimary
	|-PointerEventBase<PointerLeaveEvent>.get_isPrimary
	|-PointerEventBase<PointerMoveEvent>.get_isPrimary
	|-PointerEventBase<PointerOutEvent>.get_isPrimary
	|-PointerEventBase<PointerOverEvent>.get_isPrimary
	|-PointerEventBase<PointerUpEvent>.get_isPrimary
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE30 Offset: 0x11FF31 VA: 0x11FE30
	// RVA: -1 Offset: -1
	protected void set_isPrimary(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2180 Offset: 0x2AB2281 VA: 0x2AB2180
	|-PointerEventBase<object>.set_isPrimary
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE40 Offset: 0x11FF41 VA: 0x11FE40
	// RVA: -1 Offset: -1 Slot: 18
	public int get_button() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2190 Offset: 0x2AB2291 VA: 0x2AB2190
	|-PointerEventBase<object>.get_button
	|-PointerEventBase<PointerCancelEvent>.get_button
	|-PointerEventBase<PointerDownEvent>.get_button
	|-PointerEventBase<PointerEnterEvent>.get_button
	|-PointerEventBase<PointerLeaveEvent>.get_button
	|-PointerEventBase<PointerMoveEvent>.get_button
	|-PointerEventBase<PointerOutEvent>.get_button
	|-PointerEventBase<PointerOverEvent>.get_button
	|-PointerEventBase<PointerUpEvent>.get_button
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE50 Offset: 0x11FF51 VA: 0x11FE50
	// RVA: -1 Offset: -1
	protected void set_button(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB21A0 Offset: 0x2AB22A1 VA: 0x2AB21A0
	|-PointerEventBase<object>.set_button
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE60 Offset: 0x11FF61 VA: 0x11FE60
	// RVA: -1 Offset: -1 Slot: 19
	public int get_pressedButtons() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB21B0 Offset: 0x2AB22B1 VA: 0x2AB21B0
	|-PointerEventBase<object>.get_pressedButtons
	|-PointerEventBase<PointerCancelEvent>.get_pressedButtons
	|-PointerEventBase<PointerDownEvent>.get_pressedButtons
	|-PointerEventBase<PointerEnterEvent>.get_pressedButtons
	|-PointerEventBase<PointerLeaveEvent>.get_pressedButtons
	|-PointerEventBase<PointerMoveEvent>.get_pressedButtons
	|-PointerEventBase<PointerOutEvent>.get_pressedButtons
	|-PointerEventBase<PointerOverEvent>.get_pressedButtons
	|-PointerEventBase<PointerUpEvent>.get_pressedButtons
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE70 Offset: 0x11FF71 VA: 0x11FE70
	// RVA: -1 Offset: -1
	protected void set_pressedButtons(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB21C0 Offset: 0x2AB22C1 VA: 0x2AB21C0
	|-PointerEventBase<object>.set_pressedButtons
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE80 Offset: 0x11FF81 VA: 0x11FE80
	// RVA: -1 Offset: -1 Slot: 20
	public Vector3 get_position() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB21D0 Offset: 0x2AB22D1 VA: 0x2AB21D0
	|-PointerEventBase<object>.get_position
	|-PointerEventBase<PointerCancelEvent>.get_position
	|-PointerEventBase<PointerDownEvent>.get_position
	|-PointerEventBase<PointerEnterEvent>.get_position
	|-PointerEventBase<PointerLeaveEvent>.get_position
	|-PointerEventBase<PointerMoveEvent>.get_position
	|-PointerEventBase<PointerOutEvent>.get_position
	|-PointerEventBase<PointerOverEvent>.get_position
	|-PointerEventBase<PointerUpEvent>.get_position
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FE90 Offset: 0x11FF91 VA: 0x11FE90
	// RVA: -1 Offset: -1
	protected void set_position(Vector3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB21E0 Offset: 0x2AB22E1 VA: 0x2AB21E0
	|-PointerEventBase<object>.set_position
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FEA0 Offset: 0x11FFA1 VA: 0x11FEA0
	// RVA: -1 Offset: -1 Slot: 21
	public Vector3 get_localPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB21F0 Offset: 0x2AB22F1 VA: 0x2AB21F0
	|-PointerEventBase<object>.get_localPosition
	|-PointerEventBase<PointerCancelEvent>.get_localPosition
	|-PointerEventBase<PointerDownEvent>.get_localPosition
	|-PointerEventBase<PointerEnterEvent>.get_localPosition
	|-PointerEventBase<PointerLeaveEvent>.get_localPosition
	|-PointerEventBase<PointerMoveEvent>.get_localPosition
	|-PointerEventBase<PointerOutEvent>.get_localPosition
	|-PointerEventBase<PointerOverEvent>.get_localPosition
	|-PointerEventBase<PointerUpEvent>.get_localPosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FEB0 Offset: 0x11FFB1 VA: 0x11FEB0
	// RVA: -1 Offset: -1
	protected void set_localPosition(Vector3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2200 Offset: 0x2AB2301 VA: 0x2AB2200
	|-PointerEventBase<object>.set_localPosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FEC0 Offset: 0x11FFC1 VA: 0x11FEC0
	// RVA: -1 Offset: -1 Slot: 22
	public Vector3 get_deltaPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2210 Offset: 0x2AB2311 VA: 0x2AB2210
	|-PointerEventBase<object>.get_deltaPosition
	|-PointerEventBase<PointerCancelEvent>.get_deltaPosition
	|-PointerEventBase<PointerDownEvent>.get_deltaPosition
	|-PointerEventBase<PointerEnterEvent>.get_deltaPosition
	|-PointerEventBase<PointerLeaveEvent>.get_deltaPosition
	|-PointerEventBase<PointerMoveEvent>.get_deltaPosition
	|-PointerEventBase<PointerOutEvent>.get_deltaPosition
	|-PointerEventBase<PointerOverEvent>.get_deltaPosition
	|-PointerEventBase<PointerUpEvent>.get_deltaPosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FED0 Offset: 0x11FFD1 VA: 0x11FED0
	// RVA: -1 Offset: -1
	protected void set_deltaPosition(Vector3 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2220 Offset: 0x2AB2321 VA: 0x2AB2220
	|-PointerEventBase<object>.set_deltaPosition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FEE0 Offset: 0x11FFE1 VA: 0x11FEE0
	// RVA: -1 Offset: -1 Slot: 23
	public float get_deltaTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2230 Offset: 0x2AB2331 VA: 0x2AB2230
	|-PointerEventBase<object>.get_deltaTime
	|-PointerEventBase<PointerCancelEvent>.get_deltaTime
	|-PointerEventBase<PointerDownEvent>.get_deltaTime
	|-PointerEventBase<PointerEnterEvent>.get_deltaTime
	|-PointerEventBase<PointerLeaveEvent>.get_deltaTime
	|-PointerEventBase<PointerMoveEvent>.get_deltaTime
	|-PointerEventBase<PointerOutEvent>.get_deltaTime
	|-PointerEventBase<PointerOverEvent>.get_deltaTime
	|-PointerEventBase<PointerUpEvent>.get_deltaTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FEF0 Offset: 0x11FFF1 VA: 0x11FEF0
	// RVA: -1 Offset: -1
	protected void set_deltaTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2240 Offset: 0x2AB2341 VA: 0x2AB2240
	|-PointerEventBase<object>.set_deltaTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF00 Offset: 0x120001 VA: 0x11FF00
	// RVA: -1 Offset: -1 Slot: 24
	public int get_clickCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2250 Offset: 0x2AB2351 VA: 0x2AB2250
	|-PointerEventBase<object>.get_clickCount
	|-PointerEventBase<PointerCancelEvent>.get_clickCount
	|-PointerEventBase<PointerDownEvent>.get_clickCount
	|-PointerEventBase<PointerEnterEvent>.get_clickCount
	|-PointerEventBase<PointerLeaveEvent>.get_clickCount
	|-PointerEventBase<PointerMoveEvent>.get_clickCount
	|-PointerEventBase<PointerOutEvent>.get_clickCount
	|-PointerEventBase<PointerOverEvent>.get_clickCount
	|-PointerEventBase<PointerUpEvent>.get_clickCount
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF10 Offset: 0x120011 VA: 0x11FF10
	// RVA: -1 Offset: -1
	protected void set_clickCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2260 Offset: 0x2AB2361 VA: 0x2AB2260
	|-PointerEventBase<object>.set_clickCount
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF20 Offset: 0x120021 VA: 0x11FF20
	// RVA: -1 Offset: -1 Slot: 25
	public float get_pressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2270 Offset: 0x2AB2371 VA: 0x2AB2270
	|-PointerEventBase<object>.get_pressure
	|-PointerEventBase<PointerCancelEvent>.get_pressure
	|-PointerEventBase<PointerDownEvent>.get_pressure
	|-PointerEventBase<PointerEnterEvent>.get_pressure
	|-PointerEventBase<PointerLeaveEvent>.get_pressure
	|-PointerEventBase<PointerMoveEvent>.get_pressure
	|-PointerEventBase<PointerOutEvent>.get_pressure
	|-PointerEventBase<PointerOverEvent>.get_pressure
	|-PointerEventBase<PointerUpEvent>.get_pressure
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF30 Offset: 0x120031 VA: 0x11FF30
	// RVA: -1 Offset: -1
	protected void set_pressure(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2280 Offset: 0x2AB2381 VA: 0x2AB2280
	|-PointerEventBase<object>.set_pressure
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF40 Offset: 0x120041 VA: 0x11FF40
	// RVA: -1 Offset: -1 Slot: 26
	public float get_tangentialPressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2290 Offset: 0x2AB2391 VA: 0x2AB2290
	|-PointerEventBase<object>.get_tangentialPressure
	|-PointerEventBase<PointerCancelEvent>.get_tangentialPressure
	|-PointerEventBase<PointerDownEvent>.get_tangentialPressure
	|-PointerEventBase<PointerEnterEvent>.get_tangentialPressure
	|-PointerEventBase<PointerLeaveEvent>.get_tangentialPressure
	|-PointerEventBase<PointerMoveEvent>.get_tangentialPressure
	|-PointerEventBase<PointerOutEvent>.get_tangentialPressure
	|-PointerEventBase<PointerOverEvent>.get_tangentialPressure
	|-PointerEventBase<PointerUpEvent>.get_tangentialPressure
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF50 Offset: 0x120051 VA: 0x11FF50
	// RVA: -1 Offset: -1
	protected void set_tangentialPressure(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB22A0 Offset: 0x2AB23A1 VA: 0x2AB22A0
	|-PointerEventBase<object>.set_tangentialPressure
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF60 Offset: 0x120061 VA: 0x11FF60
	// RVA: -1 Offset: -1 Slot: 27
	public float get_altitudeAngle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB22B0 Offset: 0x2AB23B1 VA: 0x2AB22B0
	|-PointerEventBase<object>.get_altitudeAngle
	|-PointerEventBase<PointerCancelEvent>.get_altitudeAngle
	|-PointerEventBase<PointerDownEvent>.get_altitudeAngle
	|-PointerEventBase<PointerEnterEvent>.get_altitudeAngle
	|-PointerEventBase<PointerLeaveEvent>.get_altitudeAngle
	|-PointerEventBase<PointerMoveEvent>.get_altitudeAngle
	|-PointerEventBase<PointerOutEvent>.get_altitudeAngle
	|-PointerEventBase<PointerOverEvent>.get_altitudeAngle
	|-PointerEventBase<PointerUpEvent>.get_altitudeAngle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF70 Offset: 0x120071 VA: 0x11FF70
	// RVA: -1 Offset: -1
	protected void set_altitudeAngle(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB22C0 Offset: 0x2AB23C1 VA: 0x2AB22C0
	|-PointerEventBase<object>.set_altitudeAngle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF80 Offset: 0x120081 VA: 0x11FF80
	// RVA: -1 Offset: -1 Slot: 28
	public float get_azimuthAngle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB22D0 Offset: 0x2AB23D1 VA: 0x2AB22D0
	|-PointerEventBase<object>.get_azimuthAngle
	|-PointerEventBase<PointerCancelEvent>.get_azimuthAngle
	|-PointerEventBase<PointerDownEvent>.get_azimuthAngle
	|-PointerEventBase<PointerEnterEvent>.get_azimuthAngle
	|-PointerEventBase<PointerLeaveEvent>.get_azimuthAngle
	|-PointerEventBase<PointerMoveEvent>.get_azimuthAngle
	|-PointerEventBase<PointerOutEvent>.get_azimuthAngle
	|-PointerEventBase<PointerOverEvent>.get_azimuthAngle
	|-PointerEventBase<PointerUpEvent>.get_azimuthAngle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FF90 Offset: 0x120091 VA: 0x11FF90
	// RVA: -1 Offset: -1
	protected void set_azimuthAngle(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB22E0 Offset: 0x2AB23E1 VA: 0x2AB22E0
	|-PointerEventBase<object>.set_azimuthAngle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FFA0 Offset: 0x1200A1 VA: 0x11FFA0
	// RVA: -1 Offset: -1 Slot: 29
	public float get_twist() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB22F0 Offset: 0x2AB23F1 VA: 0x2AB22F0
	|-PointerEventBase<object>.get_twist
	|-PointerEventBase<PointerCancelEvent>.get_twist
	|-PointerEventBase<PointerDownEvent>.get_twist
	|-PointerEventBase<PointerEnterEvent>.get_twist
	|-PointerEventBase<PointerLeaveEvent>.get_twist
	|-PointerEventBase<PointerMoveEvent>.get_twist
	|-PointerEventBase<PointerOutEvent>.get_twist
	|-PointerEventBase<PointerOverEvent>.get_twist
	|-PointerEventBase<PointerUpEvent>.get_twist
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FFB0 Offset: 0x1200B1 VA: 0x11FFB0
	// RVA: -1 Offset: -1
	protected void set_twist(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2300 Offset: 0x2AB2401 VA: 0x2AB2300
	|-PointerEventBase<object>.set_twist
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FFC0 Offset: 0x1200C1 VA: 0x11FFC0
	// RVA: -1 Offset: -1 Slot: 30
	public Vector2 get_radius() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2310 Offset: 0x2AB2411 VA: 0x2AB2310
	|-PointerEventBase<object>.get_radius
	|-PointerEventBase<PointerCancelEvent>.get_radius
	|-PointerEventBase<PointerDownEvent>.get_radius
	|-PointerEventBase<PointerEnterEvent>.get_radius
	|-PointerEventBase<PointerLeaveEvent>.get_radius
	|-PointerEventBase<PointerMoveEvent>.get_radius
	|-PointerEventBase<PointerOutEvent>.get_radius
	|-PointerEventBase<PointerOverEvent>.get_radius
	|-PointerEventBase<PointerUpEvent>.get_radius
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FFD0 Offset: 0x1200D1 VA: 0x11FFD0
	// RVA: -1 Offset: -1
	protected void set_radius(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2320 Offset: 0x2AB2421 VA: 0x2AB2320
	|-PointerEventBase<object>.set_radius
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FFE0 Offset: 0x1200E1 VA: 0x11FFE0
	// RVA: -1 Offset: -1 Slot: 31
	public Vector2 get_radiusVariance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2330 Offset: 0x2AB2431 VA: 0x2AB2330
	|-PointerEventBase<object>.get_radiusVariance
	|-PointerEventBase<PointerCancelEvent>.get_radiusVariance
	|-PointerEventBase<PointerDownEvent>.get_radiusVariance
	|-PointerEventBase<PointerEnterEvent>.get_radiusVariance
	|-PointerEventBase<PointerLeaveEvent>.get_radiusVariance
	|-PointerEventBase<PointerMoveEvent>.get_radiusVariance
	|-PointerEventBase<PointerOutEvent>.get_radiusVariance
	|-PointerEventBase<PointerOverEvent>.get_radiusVariance
	|-PointerEventBase<PointerUpEvent>.get_radiusVariance
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FFF0 Offset: 0x1200F1 VA: 0x11FFF0
	// RVA: -1 Offset: -1
	protected void set_radiusVariance(Vector2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2340 Offset: 0x2AB2441 VA: 0x2AB2340
	|-PointerEventBase<object>.set_radiusVariance
	*/

	[CompilerGeneratedAttribute] // RVA: 0x120000 Offset: 0x120101 VA: 0x120000
	// RVA: -1 Offset: -1 Slot: 32
	public EventModifiers get_modifiers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2350 Offset: 0x2AB2451 VA: 0x2AB2350
	|-PointerEventBase<object>.get_modifiers
	|-PointerEventBase<PointerCancelEvent>.get_modifiers
	|-PointerEventBase<PointerDownEvent>.get_modifiers
	|-PointerEventBase<PointerEnterEvent>.get_modifiers
	|-PointerEventBase<PointerLeaveEvent>.get_modifiers
	|-PointerEventBase<PointerMoveEvent>.get_modifiers
	|-PointerEventBase<PointerOutEvent>.get_modifiers
	|-PointerEventBase<PointerOverEvent>.get_modifiers
	|-PointerEventBase<PointerUpEvent>.get_modifiers
	*/

	[CompilerGeneratedAttribute] // RVA: 0x120010 Offset: 0x120111 VA: 0x120010
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2360 Offset: 0x2AB2461 VA: 0x2AB2360
	|-PointerEventBase<object>.set_modifiers
	*/

	[CompilerGeneratedAttribute] // RVA: 0x120020 Offset: 0x120121 VA: 0x120020
	// RVA: -1 Offset: -1 Slot: 33
	private bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2370 Offset: 0x2AB2471 VA: 0x2AB2370
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerCancelEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerDownEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerEnterEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerLeaveEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerMoveEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerOutEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerOverEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	|-PointerEventBase<PointerUpEvent>.UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS
	*/

	[CompilerGeneratedAttribute] // RVA: 0x120030 Offset: 0x120131 VA: 0x120030
	// RVA: -1 Offset: -1 Slot: 34
	private void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2380 Offset: 0x2AB2481 VA: 0x2AB2380
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerCancelEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerDownEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerEnterEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerLeaveEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerMoveEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerOutEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerOverEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	|-PointerEventBase<PointerUpEvent>.UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS
	*/

	[CompilerGeneratedAttribute] // RVA: 0x120040 Offset: 0x120141 VA: 0x120040
	// RVA: -1 Offset: -1 Slot: 35
	private bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2390 Offset: 0x2AB2491 VA: 0x2AB2390
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerCancelEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerDownEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerEnterEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerLeaveEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerMoveEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerOutEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerOverEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerUpEvent>.UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer
	*/

	[CompilerGeneratedAttribute] // RVA: 0x120050 Offset: 0x120151 VA: 0x120050
	// RVA: -1 Offset: -1 Slot: 36
	private void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB23A0 Offset: 0x2AB24A1 VA: 0x2AB23A0
	|-PointerEventBase<object>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerCancelEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerDownEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerEnterEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerLeaveEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerMoveEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerOutEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerOverEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	|-PointerEventBase<PointerUpEvent>.UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB23B0 Offset: 0x2AB24B1 VA: 0x2AB23B0
	|-PointerEventBase<object>.Init
	|-PointerEventBase<PointerCancelEvent>.Init
	|-PointerEventBase<PointerDownEvent>.Init
	|-PointerEventBase<PointerEnterEvent>.Init
	|-PointerEventBase<PointerLeaveEvent>.Init
	|-PointerEventBase<PointerMoveEvent>.Init
	|-PointerEventBase<PointerOutEvent>.Init
	|-PointerEventBase<PointerOverEvent>.Init
	|-PointerEventBase<PointerUpEvent>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2400 Offset: 0x2AB2501 VA: 0x2AB2400
	|-PointerEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override IEventHandler get_currentTarget() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB27C0 Offset: 0x2AB28C1 VA: 0x2AB27C0
	|-PointerEventBase<object>.get_currentTarget
	|-PointerEventBase<PointerCancelEvent>.get_currentTarget
	|-PointerEventBase<PointerDownEvent>.get_currentTarget
	|-PointerEventBase<PointerEnterEvent>.get_currentTarget
	|-PointerEventBase<PointerLeaveEvent>.get_currentTarget
	|-PointerEventBase<PointerMoveEvent>.get_currentTarget
	|-PointerEventBase<PointerOutEvent>.get_currentTarget
	|-PointerEventBase<PointerOverEvent>.get_currentTarget
	|-PointerEventBase<PointerUpEvent>.get_currentTarget
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override void set_currentTarget(IEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB27E0 Offset: 0x2AB28E1 VA: 0x2AB27E0
	|-PointerEventBase<object>.set_currentTarget
	|-PointerEventBase<PointerCancelEvent>.set_currentTarget
	|-PointerEventBase<PointerDownEvent>.set_currentTarget
	|-PointerEventBase<PointerEnterEvent>.set_currentTarget
	|-PointerEventBase<PointerLeaveEvent>.set_currentTarget
	|-PointerEventBase<PointerMoveEvent>.set_currentTarget
	|-PointerEventBase<PointerOutEvent>.set_currentTarget
	|-PointerEventBase<PointerOverEvent>.set_currentTarget
	|-PointerEventBase<PointerUpEvent>.set_currentTarget
	*/

	// RVA: -1 Offset: -1
	private static bool IsMouse(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2920 Offset: 0x2AB2A21 VA: 0x2AB2920
	|-PointerEventBase<object>.IsMouse
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2970 Offset: 0x2AB2A71 VA: 0x2AB2970
	|-PointerEventBase<object>.GetPooled
	|-PointerEventBase<PointerDownEvent>.GetPooled
	|-PointerEventBase<PointerMoveEvent>.GetPooled
	|-PointerEventBase<PointerUpEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB38B0 Offset: 0x2AB39B1 VA: 0x2AB38B0
	|-PointerEventBase<object>.GetPooled
	|-PointerEventBase<PointerOutEvent>.GetPooled
	|-PointerEventBase<PointerOverEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IPointerEvent triggerEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB3C80 Offset: 0x2AB3D81 VA: 0x2AB3C80
	|-PointerEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected internal override void PreDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB4C10 Offset: 0x2AB4D11 VA: 0x2AB4C10
	|-PointerEventBase<object>.PreDispatch
	|-PointerEventBase<PointerCancelEvent>.PreDispatch
	|-PointerEventBase<PointerDownEvent>.PreDispatch
	|-PointerEventBase<PointerEnterEvent>.PreDispatch
	|-PointerEventBase<PointerLeaveEvent>.PreDispatch
	|-PointerEventBase<PointerMoveEvent>.PreDispatch
	|-PointerEventBase<PointerOutEvent>.PreDispatch
	|-PointerEventBase<PointerOverEvent>.PreDispatch
	|-PointerEventBase<PointerUpEvent>.PreDispatch
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override void PostDispatch(IPanel panel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB4DD0 Offset: 0x2AB4ED1 VA: 0x2AB4DD0
	|-PointerEventBase<object>.PostDispatch
	|-PointerEventBase<PointerCancelEvent>.PostDispatch
	|-PointerEventBase<PointerDownEvent>.PostDispatch
	|-PointerEventBase<PointerEnterEvent>.PostDispatch
	|-PointerEventBase<PointerLeaveEvent>.PostDispatch
	|-PointerEventBase<PointerMoveEvent>.PostDispatch
	|-PointerEventBase<PointerOutEvent>.PostDispatch
	|-PointerEventBase<PointerOverEvent>.PostDispatch
	|-PointerEventBase<PointerUpEvent>.PostDispatch
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB4F40 Offset: 0x2AB5041 VA: 0x2AB4F40
	|-PointerEventBase<object>..ctor
	|-PointerEventBase<PointerCancelEvent>..ctor
	|-PointerEventBase<PointerDownEvent>..ctor
	|-PointerEventBase<PointerEnterEvent>..ctor
	|-PointerEventBase<PointerLeaveEvent>..ctor
	|-PointerEventBase<PointerMoveEvent>..ctor
	|-PointerEventBase<PointerOutEvent>..ctor
	|-PointerEventBase<PointerOverEvent>..ctor
	|-PointerEventBase<PointerUpEvent>..ctor
	*/
}

