[DebuggerDisplayAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[ComVisibleAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[DebuggerTypeProxyAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
public struct SpinLock // TypeDefIndex: 765
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x3570 Offset: 0x3671 VA: 0x3570
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x35B0 Offset: 0x36B1 VA: 0x35B0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x3640 Offset: 0x3741 VA: 0x3640
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36E0 Offset: 0x37E1 VA: 0x36E0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36F0 Offset: 0x37F1 VA: 0x36F0
	private void DecrementWaiters() { }

	// RVA: 0x3770 Offset: 0x3871 VA: 0x3770
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0xB89B0 Offset: 0xB8AB1 VA: 0xB89B0
	// RVA: 0x3780 Offset: 0x3881 VA: 0x3780
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x37F0 Offset: 0x38F1 VA: 0x37F0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0xB89D0 Offset: 0xB8AD1 VA: 0xB89D0
	// RVA: 0x3800 Offset: 0x3901 VA: 0x3800
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB89F0 Offset: 0xB8AF1 VA: 0xB89F0
	// RVA: 0x3810 Offset: 0x3911 VA: 0x3810
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x157A3D0 Offset: 0x157A4D1 VA: 0x157A3D0
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[ComVisibleAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[DebuggerTypeProxyAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
public struct SpinLock // TypeDefIndex: 765
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x3570 Offset: 0x3671 VA: 0x3570
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x35B0 Offset: 0x36B1 VA: 0x35B0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x3640 Offset: 0x3741 VA: 0x3640
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36E0 Offset: 0x37E1 VA: 0x36E0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36F0 Offset: 0x37F1 VA: 0x36F0
	private void DecrementWaiters() { }

	// RVA: 0x3770 Offset: 0x3871 VA: 0x3770
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0xB89B0 Offset: 0xB8AB1 VA: 0xB89B0
	// RVA: 0x3780 Offset: 0x3881 VA: 0x3780
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x37F0 Offset: 0x38F1 VA: 0x37F0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0xB89D0 Offset: 0xB8AD1 VA: 0xB89D0
	// RVA: 0x3800 Offset: 0x3901 VA: 0x3800
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB89F0 Offset: 0xB8AF1 VA: 0xB89F0
	// RVA: 0x3810 Offset: 0x3911 VA: 0x3810
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x157A3D0 Offset: 0x157A4D1 VA: 0x157A3D0
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[ComVisibleAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[DebuggerTypeProxyAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
public struct SpinLock // TypeDefIndex: 765
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x3570 Offset: 0x3671 VA: 0x3570
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x35B0 Offset: 0x36B1 VA: 0x35B0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x3640 Offset: 0x3741 VA: 0x3640
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36E0 Offset: 0x37E1 VA: 0x36E0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36F0 Offset: 0x37F1 VA: 0x36F0
	private void DecrementWaiters() { }

	// RVA: 0x3770 Offset: 0x3871 VA: 0x3770
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0xB89B0 Offset: 0xB8AB1 VA: 0xB89B0
	// RVA: 0x3780 Offset: 0x3881 VA: 0x3780
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x37F0 Offset: 0x38F1 VA: 0x37F0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0xB89D0 Offset: 0xB8AD1 VA: 0xB89D0
	// RVA: 0x3800 Offset: 0x3901 VA: 0x3800
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB89F0 Offset: 0xB8AF1 VA: 0xB89F0
	// RVA: 0x3810 Offset: 0x3911 VA: 0x3810
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x157A3D0 Offset: 0x157A4D1 VA: 0x157A3D0
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[ComVisibleAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[DebuggerTypeProxyAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
public struct SpinLock // TypeDefIndex: 765
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x3570 Offset: 0x3671 VA: 0x3570
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x35B0 Offset: 0x36B1 VA: 0x35B0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x3640 Offset: 0x3741 VA: 0x3640
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36E0 Offset: 0x37E1 VA: 0x36E0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36F0 Offset: 0x37F1 VA: 0x36F0
	private void DecrementWaiters() { }

	// RVA: 0x3770 Offset: 0x3871 VA: 0x3770
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0xB89B0 Offset: 0xB8AB1 VA: 0xB89B0
	// RVA: 0x3780 Offset: 0x3881 VA: 0x3780
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x37F0 Offset: 0x38F1 VA: 0x37F0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0xB89D0 Offset: 0xB8AD1 VA: 0xB89D0
	// RVA: 0x3800 Offset: 0x3901 VA: 0x3800
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB89F0 Offset: 0xB8AF1 VA: 0xB89F0
	// RVA: 0x3810 Offset: 0x3911 VA: 0x3810
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x157A3D0 Offset: 0x157A4D1 VA: 0x157A3D0
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[ComVisibleAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[DebuggerTypeProxyAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
public struct SpinLock // TypeDefIndex: 765
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x3570 Offset: 0x3671 VA: 0x3570
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x35B0 Offset: 0x36B1 VA: 0x35B0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x3640 Offset: 0x3741 VA: 0x3640
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36E0 Offset: 0x37E1 VA: 0x36E0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36F0 Offset: 0x37F1 VA: 0x36F0
	private void DecrementWaiters() { }

	// RVA: 0x3770 Offset: 0x3871 VA: 0x3770
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0xB89B0 Offset: 0xB8AB1 VA: 0xB89B0
	// RVA: 0x3780 Offset: 0x3881 VA: 0x3780
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x37F0 Offset: 0x38F1 VA: 0x37F0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0xB89D0 Offset: 0xB8AD1 VA: 0xB89D0
	// RVA: 0x3800 Offset: 0x3901 VA: 0x3800
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB89F0 Offset: 0xB8AF1 VA: 0xB89F0
	// RVA: 0x3810 Offset: 0x3911 VA: 0x3810
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x157A3D0 Offset: 0x157A4D1 VA: 0x157A3D0
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[ComVisibleAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
[DebuggerTypeProxyAttribute] // RVA: 0xAF0E0 Offset: 0xAF1E1 VA: 0xAF0E0
public struct SpinLock // TypeDefIndex: 765
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x3570 Offset: 0x3671 VA: 0x3570
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x35B0 Offset: 0x36B1 VA: 0x35B0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x3640 Offset: 0x3741 VA: 0x3640
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36E0 Offset: 0x37E1 VA: 0x36E0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x36F0 Offset: 0x37F1 VA: 0x36F0
	private void DecrementWaiters() { }

	// RVA: 0x3770 Offset: 0x3871 VA: 0x3770
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0xB89B0 Offset: 0xB8AB1 VA: 0xB89B0
	// RVA: 0x3780 Offset: 0x3881 VA: 0x3780
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x37F0 Offset: 0x38F1 VA: 0x37F0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0xB89D0 Offset: 0xB8AD1 VA: 0xB89D0
	// RVA: 0x3800 Offset: 0x3901 VA: 0x3800
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB89F0 Offset: 0xB8AF1 VA: 0xB89F0
	// RVA: 0x3810 Offset: 0x3911 VA: 0x3810
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x157A3D0 Offset: 0x157A4D1 VA: 0x157A3D0
	private static void .cctor() { }
}

