[ComVisibleAttribute] // RVA: 0xAEFD0 Offset: 0xAF0D1 VA: 0xAEFD0
public class CancellationTokenSource : IDisposable // TypeDefIndex: 753
{
	// Fields
	private static readonly CancellationTokenSource _staticSource_Set; // 0x0
	private static readonly CancellationTokenSource _staticSource_NotCancelable; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent m_kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists; // 0x18
	private int m_state; // 0x20
	private int m_threadIDExecutingCallbacks; // 0x24
	private bool m_disposed; // 0x28
	private CancellationTokenRegistration[] m_linkingRegistrations; // 0x30
	private static readonly Action<object> s_LinkedTokenCancelDelegate; // 0x18
	private CancellationCallbackInfo m_executingCallback; // 0x38
	private Timer m_timer; // 0x40
	private static readonly TimerCallback s_timerCallback; // 0x20

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal bool CanBeCanceled { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x1A0BEC0 Offset: 0x1A0BFC1 VA: 0x1A0BEC0
	private static void LinkedTokenCancelDelegate(object source) { }

	// RVA: 0x1A0AA00 Offset: 0x1A0AB01 VA: 0x1A0AA00
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1A0BBE0 Offset: 0x1A0BCE1 VA: 0x1A0BBE0
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x1A0C020 Offset: 0x1A0C121 VA: 0x1A0C020
	internal bool get_IsDisposed() { }

	// RVA: 0x1A0C030 Offset: 0x1A0C131 VA: 0x1A0C030
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x1A0BC10 Offset: 0x1A0BD11 VA: 0x1A0BC10
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x1A0C060 Offset: 0x1A0C161 VA: 0x1A0C060
	public CancellationToken get_Token() { }

	// RVA: 0x1A0AA70 Offset: 0x1A0AB71 VA: 0x1A0AA70
	internal bool get_CanBeCanceled() { }

	// RVA: 0x1A0C160 Offset: 0x1A0C261 VA: 0x1A0C160
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x1A0C190 Offset: 0x1A0C291 VA: 0x1A0C190
	public void .ctor() { }

	// RVA: 0x1A0C1D0 Offset: 0x1A0C2D1 VA: 0x1A0C1D0
	private void .ctor(bool set) { }

	// RVA: 0x1A0BFA0 Offset: 0x1A0C0A1 VA: 0x1A0BFA0
	public void Cancel() { }

	// RVA: 0x1A0C230 Offset: 0x1A0C331 VA: 0x1A0C230
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x1A0C480 Offset: 0x1A0C581 VA: 0x1A0C480
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x1A0C5F0 Offset: 0x1A0C6F1 VA: 0x1A0C5F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A0C670 Offset: 0x1A0C771 VA: 0x1A0C670 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1A0C0F0 Offset: 0x1A0C1F1 VA: 0x1A0C0F0
	internal void ThrowIfDisposed() { }

	// RVA: 0x1A0C790 Offset: 0x1A0C891 VA: 0x1A0C790
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1A0ABA0 Offset: 0x1A0ACA1 VA: 0x1A0ABA0
	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	// RVA: 0x1A0B0F0 Offset: 0x1A0B1F1 VA: 0x1A0B0F0
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x1A0C2B0 Offset: 0x1A0C3B1 VA: 0x1A0C2B0
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x1A0C8B0 Offset: 0x1A0C9B1 VA: 0x1A0C8B0
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x1A0CE80 Offset: 0x1A0CF81 VA: 0x1A0CE80
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x1A0CDA0 Offset: 0x1A0CEA1 VA: 0x1A0CDA0
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x1A0CF10 Offset: 0x1A0D011 VA: 0x1A0CF10
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1A0BC40 Offset: 0x1A0BD41 VA: 0x1A0BC40
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x1A0D160 Offset: 0x1A0D261 VA: 0x1A0D160
	private static void .cctor() { }
}

