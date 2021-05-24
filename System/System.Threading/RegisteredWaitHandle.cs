[ComVisibleAttribute] // RVA: 0xAF600 Offset: 0xAF701 VA: 0xAF600
public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 830
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x1575860 Offset: 0x1575961 VA: 0x1575860
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1575960 Offset: 0x1575A61 VA: 0x1575960
	internal void Wait(object state) { }

	// RVA: 0x15761D0 Offset: 0x15762D1 VA: 0x15761D0
	private void DoCallBack(object timedOut) { }
}

