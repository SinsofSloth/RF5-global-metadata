public abstract class EventBase<T> : EventBase // TypeDefIndex: 4166
{
	// Fields
	private static readonly long s_TypeId; // 0x0
	private static readonly ObjectPool<T> s_Pool; // 0x0
	private int m_RefCount; // 0x0

	// Properties
	public override long eventTypeId { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADE40 Offset: 0x2AADF41 VA: 0x2AADE40
	|-EventBase<object>..ctor
	|-EventBase<IMGUIEvent>..ctor
	*/

	// RVA: -1 Offset: -1
	public static long TypeId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADEC0 Offset: 0x2AADFC1 VA: 0x2AADEC0
	|-EventBase<object>.TypeId
	|-EventBase<DragExitedEvent>.TypeId
	|-EventBase<DragUpdatedEvent>.TypeId
	|-EventBase<IMGUIEvent>.TypeId
	|-EventBase<MouseCaptureOutEvent>.TypeId
	|-EventBase<MouseDownEvent>.TypeId
	|-EventBase<MouseEnterWindowEvent>.TypeId
	|-EventBase<MouseLeaveWindowEvent>.TypeId
	|-EventBase<MouseMoveEvent>.TypeId
	|-EventBase<MouseUpEvent>.TypeId
	|-EventBase<PointerCancelEvent>.TypeId
	|-EventBase<PointerCaptureEvent>.TypeId
	|-EventBase<PointerCaptureOutEvent>.TypeId
	|-EventBase<PointerDownEvent>.TypeId
	|-EventBase<PointerMoveEvent>.TypeId
	|-EventBase<PointerUpEvent>.TypeId
	|-EventBase<WheelEvent>.TypeId
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADFF0 Offset: 0x2AAE0F1 VA: 0x2AADFF0
	|-EventBase<object>.Init
	|-EventBase<IMGUIEvent>.Init
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE090 Offset: 0x2AAE191 VA: 0x2AAE090
	|-EventBase<object>.GetPooled
	|-EventBase<IMGUIEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(EventBase e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE270 Offset: 0x2AAE371 VA: 0x2AAE270
	|-EventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	private static void ReleasePooled(T evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE3E0 Offset: 0x2AAE4E1 VA: 0x2AAE3E0
	|-EventBase<object>.ReleasePooled
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE5D0 Offset: 0x2AAE6D1 VA: 0x2AAE5D0
	|-EventBase<object>.Acquire
	|-EventBase<BlurEvent>.Acquire
	|-EventBase<ContextClickEvent>.Acquire
	|-EventBase<DragEnterEvent>.Acquire
	|-EventBase<DragExitedEvent>.Acquire
	|-EventBase<DragLeaveEvent>.Acquire
	|-EventBase<DragPerformEvent>.Acquire
	|-EventBase<DragUpdatedEvent>.Acquire
	|-EventBase<ExecuteCommandEvent>.Acquire
	|-EventBase<FocusEvent>.Acquire
	|-EventBase<FocusInEvent>.Acquire
	|-EventBase<FocusOutEvent>.Acquire
	|-EventBase<IMGUIEvent>.Acquire
	|-EventBase<KeyDownEvent>.Acquire
	|-EventBase<KeyUpEvent>.Acquire
	|-EventBase<MouseCaptureEvent>.Acquire
	|-EventBase<MouseCaptureOutEvent>.Acquire
	|-EventBase<MouseDownEvent>.Acquire
	|-EventBase<MouseEnterEvent>.Acquire
	|-EventBase<MouseEnterWindowEvent>.Acquire
	|-EventBase<MouseLeaveEvent>.Acquire
	|-EventBase<MouseLeaveWindowEvent>.Acquire
	|-EventBase<MouseMoveEvent>.Acquire
	|-EventBase<MouseOutEvent>.Acquire
	|-EventBase<MouseOverEvent>.Acquire
	|-EventBase<MouseUpEvent>.Acquire
	|-EventBase<PointerCancelEvent>.Acquire
	|-EventBase<PointerCaptureEvent>.Acquire
	|-EventBase<PointerCaptureOutEvent>.Acquire
	|-EventBase<PointerDownEvent>.Acquire
	|-EventBase<PointerEnterEvent>.Acquire
	|-EventBase<PointerLeaveEvent>.Acquire
	|-EventBase<PointerMoveEvent>.Acquire
	|-EventBase<PointerOutEvent>.Acquire
	|-EventBase<PointerOverEvent>.Acquire
	|-EventBase<PointerUpEvent>.Acquire
	|-EventBase<ValidateCommandEvent>.Acquire
	|-EventBase<WheelEvent>.Acquire
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public sealed override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE5E0 Offset: 0x2AAE6E1 VA: 0x2AAE5E0
	|-EventBase<object>.Dispose
	|-EventBase<BlurEvent>.Dispose
	|-EventBase<ContextClickEvent>.Dispose
	|-EventBase<DragEnterEvent>.Dispose
	|-EventBase<DragExitedEvent>.Dispose
	|-EventBase<DragLeaveEvent>.Dispose
	|-EventBase<DragPerformEvent>.Dispose
	|-EventBase<DragUpdatedEvent>.Dispose
	|-EventBase<ExecuteCommandEvent>.Dispose
	|-EventBase<FocusEvent>.Dispose
	|-EventBase<FocusInEvent>.Dispose
	|-EventBase<FocusOutEvent>.Dispose
	|-EventBase<IMGUIEvent>.Dispose
	|-EventBase<KeyDownEvent>.Dispose
	|-EventBase<KeyUpEvent>.Dispose
	|-EventBase<MouseCaptureEvent>.Dispose
	|-EventBase<MouseCaptureOutEvent>.Dispose
	|-EventBase<MouseDownEvent>.Dispose
	|-EventBase<MouseEnterEvent>.Dispose
	|-EventBase<MouseEnterWindowEvent>.Dispose
	|-EventBase<MouseLeaveEvent>.Dispose
	|-EventBase<MouseLeaveWindowEvent>.Dispose
	|-EventBase<MouseMoveEvent>.Dispose
	|-EventBase<MouseOutEvent>.Dispose
	|-EventBase<MouseOverEvent>.Dispose
	|-EventBase<MouseUpEvent>.Dispose
	|-EventBase<PointerCancelEvent>.Dispose
	|-EventBase<PointerCaptureEvent>.Dispose
	|-EventBase<PointerCaptureOutEvent>.Dispose
	|-EventBase<PointerDownEvent>.Dispose
	|-EventBase<PointerEnterEvent>.Dispose
	|-EventBase<PointerLeaveEvent>.Dispose
	|-EventBase<PointerMoveEvent>.Dispose
	|-EventBase<PointerOutEvent>.Dispose
	|-EventBase<PointerOverEvent>.Dispose
	|-EventBase<PointerUpEvent>.Dispose
	|-EventBase<ValidateCommandEvent>.Dispose
	|-EventBase<WheelEvent>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override long get_eventTypeId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE6F0 Offset: 0x2AAE7F1 VA: 0x2AAE6F0
	|-EventBase<object>.get_eventTypeId
	|-EventBase<BlurEvent>.get_eventTypeId
	|-EventBase<ContextClickEvent>.get_eventTypeId
	|-EventBase<DragEnterEvent>.get_eventTypeId
	|-EventBase<DragExitedEvent>.get_eventTypeId
	|-EventBase<DragLeaveEvent>.get_eventTypeId
	|-EventBase<DragPerformEvent>.get_eventTypeId
	|-EventBase<DragUpdatedEvent>.get_eventTypeId
	|-EventBase<ExecuteCommandEvent>.get_eventTypeId
	|-EventBase<FocusEvent>.get_eventTypeId
	|-EventBase<FocusInEvent>.get_eventTypeId
	|-EventBase<FocusOutEvent>.get_eventTypeId
	|-EventBase<IMGUIEvent>.get_eventTypeId
	|-EventBase<KeyDownEvent>.get_eventTypeId
	|-EventBase<KeyUpEvent>.get_eventTypeId
	|-EventBase<MouseCaptureEvent>.get_eventTypeId
	|-EventBase<MouseCaptureOutEvent>.get_eventTypeId
	|-EventBase<MouseDownEvent>.get_eventTypeId
	|-EventBase<MouseEnterEvent>.get_eventTypeId
	|-EventBase<MouseEnterWindowEvent>.get_eventTypeId
	|-EventBase<MouseLeaveEvent>.get_eventTypeId
	|-EventBase<MouseLeaveWindowEvent>.get_eventTypeId
	|-EventBase<MouseMoveEvent>.get_eventTypeId
	|-EventBase<MouseOutEvent>.get_eventTypeId
	|-EventBase<MouseOverEvent>.get_eventTypeId
	|-EventBase<MouseUpEvent>.get_eventTypeId
	|-EventBase<PointerCancelEvent>.get_eventTypeId
	|-EventBase<PointerCaptureEvent>.get_eventTypeId
	|-EventBase<PointerCaptureOutEvent>.get_eventTypeId
	|-EventBase<PointerDownEvent>.get_eventTypeId
	|-EventBase<PointerEnterEvent>.get_eventTypeId
	|-EventBase<PointerLeaveEvent>.get_eventTypeId
	|-EventBase<PointerMoveEvent>.get_eventTypeId
	|-EventBase<PointerOutEvent>.get_eventTypeId
	|-EventBase<PointerOverEvent>.get_eventTypeId
	|-EventBase<PointerUpEvent>.get_eventTypeId
	|-EventBase<ValidateCommandEvent>.get_eventTypeId
	|-EventBase<WheelEvent>.get_eventTypeId
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE7A0 Offset: 0x2AAE8A1 VA: 0x2AAE7A0
	|-EventBase<object>..cctor
	*/
}

