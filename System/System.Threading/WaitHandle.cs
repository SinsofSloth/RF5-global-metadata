[ComVisibleAttribute] // RVA: 0xAF580 Offset: 0xAF681 VA: 0xAF580
public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 824
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[ObsoleteAttribute] // RVA: 0xBA430 Offset: 0xBA531 VA: 0xBA430
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; }

	// Methods

	// RVA: 0x158F410 Offset: 0x158F511 VA: 0x158F410
	protected void .ctor() { }

	// RVA: 0x158F4A0 Offset: 0x158F5A1 VA: 0x158F4A0
	private void Init() { }

	// RVA: 0x158F530 Offset: 0x158F631 VA: 0x158F530 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0xB8DE0 Offset: 0xB8EE1 VA: 0xB8DE0
	// RVA: 0x1575F90 Offset: 0x1576091 VA: 0x1575F90
	public SafeWaitHandle get_SafeWaitHandle() { }

	// RVA: 0x158F640 Offset: 0x158F741 VA: 0x158F640
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x158F690 Offset: 0x158F791 VA: 0x158F690 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x158F840 Offset: 0x158F941 VA: 0x158F840 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x158F860 Offset: 0x158F961 VA: 0x158F860 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x158F7B0 Offset: 0x158F8B1 VA: 0x158F7B0
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x158F870 Offset: 0x158F971 VA: 0x158F870
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0xB8E00 Offset: 0xB8F01 VA: 0xB8E00
	// RVA: 0x158FB10 Offset: 0x158FC11 VA: 0x158FB10
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0xB8E20 Offset: 0xB8F21 VA: 0xB8E20
	// RVA: 0x1576060 Offset: 0x1576161 VA: 0x1576060
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x158FAB0 Offset: 0x158FBB1 VA: 0x158FAB0
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x15900D0 Offset: 0x15901D1 VA: 0x15900D0
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x1590150 Offset: 0x1590251 VA: 0x1590150 Slot: 11
	public virtual void Close() { }

	// RVA: 0x15901D0 Offset: 0x15902D1 VA: 0x15901D0 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x1590220 Offset: 0x1590321 VA: 0x1590220 Slot: 6
	public void Dispose() { }

	// RVA: 0x158FE30 Offset: 0x158FF31 VA: 0x158FE30
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x158F980 Offset: 0x158FA81 VA: 0x158F980
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x15902A0 Offset: 0x15903A1 VA: 0x15902A0
	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x15902B0 Offset: 0x15903B1 VA: 0x15902B0
	private static void .cctor() { }
}

