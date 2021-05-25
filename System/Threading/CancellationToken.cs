[ComVisibleAttribute] // RVA: 0xAEF80 Offset: 0xAF081 VA: 0xAEF80
[DebuggerDisplayAttribute] // RVA: 0xAEF80 Offset: 0xAF081 VA: 0xAEF80
public struct CancellationToken // TypeDefIndex: 751
{
	// Fields
	private CancellationTokenSource m_source; // 0x0
	private static readonly Action<object> s_ActionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x1A0A9B0 Offset: 0x1A0AAB1 VA: 0x1A0A9B0
	public static CancellationToken get_None() { }

	// RVA: 0x16F00 Offset: 0x17001 VA: 0x16F00
	public bool get_IsCancellationRequested() { }

	// RVA: 0x16F40 Offset: 0x17041 VA: 0x16F40
	public bool get_CanBeCanceled() { }

	// RVA: 0x16F80 Offset: 0x17081 VA: 0x16F80
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x16F90 Offset: 0x17091 VA: 0x16F90
	public void .ctor(bool canceled) { }

	// RVA: 0x1A0AC40 Offset: 0x1A0AD41 VA: 0x1A0AC40
	private static void ActionToActionObjShunt(object obj) { }

	// RVA: 0x16FA0 Offset: 0x170A1 VA: 0x16FA0
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x16FB0 Offset: 0x170B1 VA: 0x16FB0
	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x16FC0 Offset: 0x170C1 VA: 0x16FC0
	public bool Equals(CancellationToken other) { }

	// RVA: 0x16FD0 Offset: 0x170D1 VA: 0x16FD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x17060 Offset: 0x17161 VA: 0x17060 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A0B740 Offset: 0x1A0B841 VA: 0x1A0B740
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1A0B770 Offset: 0x1A0B871 VA: 0x1A0B770
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x17070 Offset: 0x17171 VA: 0x17070
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x170B0 Offset: 0x171B1 VA: 0x170B0
	internal void ThrowIfSourceDisposed() { }

	// RVA: 0x17130 Offset: 0x17231 VA: 0x17130
	private void ThrowOperationCanceledException() { }

	// RVA: 0x1A0B8F0 Offset: 0x1A0B9F1 VA: 0x1A0B8F0
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x1A0B970 Offset: 0x1A0BA71 VA: 0x1A0B970
	private static void .cctor() { }
}

