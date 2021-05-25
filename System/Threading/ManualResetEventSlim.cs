[ComVisibleAttribute] // RVA: 0xAF030 Offset: 0xAF131 VA: 0xAF030
[DebuggerDisplayAttribute] // RVA: 0xAF030 Offset: 0xAF131 VA: 0xAF030
public class ManualResetEventSlim : IDisposable // TypeDefIndex: 761
{
	// Fields
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x1A0FA50 Offset: 0x1A0FB51 VA: 0x1A0FA50
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1A0FE00 Offset: 0x1A0FF01 VA: 0x1A0FE00
	public bool get_IsSet() { }

	// RVA: 0x1A0FE90 Offset: 0x1A0FF91 VA: 0x1A0FE90
	private void set_IsSet(bool value) { }

	// RVA: 0x1A0FF60 Offset: 0x1A10061 VA: 0x1A0FF60
	public int get_SpinCount() { }

	// RVA: 0x1A0FFF0 Offset: 0x1A100F1 VA: 0x1A0FFF0
	private void set_SpinCount(int value) { }

	// RVA: 0x1A10030 Offset: 0x1A10131 VA: 0x1A10030
	private int get_Waiters() { }

	// RVA: 0x1A100B0 Offset: 0x1A101B1 VA: 0x1A100B0
	private void set_Waiters(int value) { }

	// RVA: 0x1A10190 Offset: 0x1A10291 VA: 0x1A10190
	public void .ctor(bool initialState) { }

	// RVA: 0x1A10290 Offset: 0x1A10391 VA: 0x1A10290
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x1A10210 Offset: 0x1A10311 VA: 0x1A10210
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1A10430 Offset: 0x1A10531 VA: 0x1A10430
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1A0FBB0 Offset: 0x1A0FCB1 VA: 0x1A0FBB0
	private bool LazyInitializeEvent() { }

	// RVA: 0x1A10580 Offset: 0x1A10681 VA: 0x1A10580
	public void Set() { }

	// RVA: 0x1A10590 Offset: 0x1A10691 VA: 0x1A10590
	private void Set(bool duringCancellation) { }

	// RVA: 0x1A108F0 Offset: 0x1A109F1 VA: 0x1A108F0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1A113B0 Offset: 0x1A114B1 VA: 0x1A113B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A11430 Offset: 0x1A11531 VA: 0x1A11430 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1A0FB10 Offset: 0x1A0FC11 VA: 0x1A0FB10
	private void ThrowIfDisposed() { }

	// RVA: 0x1A11520 Offset: 0x1A11621 VA: 0x1A11520
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x1A0FEC0 Offset: 0x1A0FFC1 VA: 0x1A0FEC0
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x1A0FFE0 Offset: 0x1A100E1 VA: 0x1A0FFE0
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x1A0FE80 Offset: 0x1A0FF81 VA: 0x1A0FE80
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1A11630 Offset: 0x1A11731 VA: 0x1A11630
	private static void .cctor() { }
}

