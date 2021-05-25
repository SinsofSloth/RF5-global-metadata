public abstract class PointerCaptureEventBase<T> : EventBase<T> // TypeDefIndex: 4144
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x11E920 Offset: 0x11EA21 VA: 0x11E920
	[CompilerGeneratedAttribute] // RVA: 0x11E920 Offset: 0x11EA21 VA: 0x11E920
	private IEventHandler <relatedTarget>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11E960 Offset: 0x11EA61 VA: 0x11E960
	[DebuggerBrowsableAttribute] // RVA: 0x11E960 Offset: 0x11EA61 VA: 0x11E960
	private int <pointerId>k__BackingField; // 0x0

	// Properties
	private IEventHandler relatedTarget { set; }
	private int pointerId { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11FA40 Offset: 0x11FB41 VA: 0x11FA40
	// RVA: -1 Offset: -1
	private void set_relatedTarget(IEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1D00 Offset: 0x2AB1E01 VA: 0x2AB1D00
	|-PointerCaptureEventBase<object>.set_relatedTarget
	*/

	[CompilerGeneratedAttribute] // RVA: 0x11FA50 Offset: 0x11FB51 VA: 0x11FA50
	// RVA: -1 Offset: -1
	private void set_pointerId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1D10 Offset: 0x2AB1E11 VA: 0x2AB1D10
	|-PointerCaptureEventBase<object>.set_pointerId
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1D20 Offset: 0x2AB1E21 VA: 0x2AB1D20
	|-PointerCaptureEventBase<object>.Init
	|-PointerCaptureEventBase<PointerCaptureEvent>.Init
	|-PointerCaptureEventBase<PointerCaptureOutEvent>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1D70 Offset: 0x2AB1E71 VA: 0x2AB1D70
	|-PointerCaptureEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB1E30 Offset: 0x2AB1F31 VA: 0x2AB1E30
	|-PointerCaptureEventBase<object>.GetPooled
	|-PointerCaptureEventBase<MouseCaptureEvent>.GetPooled
	|-PointerCaptureEventBase<MouseCaptureOutEvent>.GetPooled
	|-PointerCaptureEventBase<PointerCaptureEvent>.GetPooled
	|-PointerCaptureEventBase<PointerCaptureOutEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB2060 Offset: 0x2AB2161 VA: 0x2AB2060
	|-PointerCaptureEventBase<object>..ctor
	|-PointerCaptureEventBase<PointerCaptureEvent>..ctor
	|-PointerCaptureEventBase<PointerCaptureOutEvent>..ctor
	*/
}

