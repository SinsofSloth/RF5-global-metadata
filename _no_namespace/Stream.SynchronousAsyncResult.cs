internal sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 660
{
	// Fields
	private readonly object _stateObject; // 0x10
	private readonly bool _isWrite; // 0x18
	private ManualResetEvent _waitHandle; // 0x20
	private ExceptionDispatchInfo _exceptionInfo; // 0x28
	private bool _endXxxCalled; // 0x30
	private int _bytesRead; // 0x34

	// Properties
	public bool IsCompleted { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }

	// Methods

	// RVA: 0x18B1FD0 Offset: 0x18B20D1 VA: 0x18B1FD0
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x18B2140 Offset: 0x18B2241 VA: 0x18B2140
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x18B2020 Offset: 0x18B2121 VA: 0x18B2020
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x18B2FC0 Offset: 0x18B30C1 VA: 0x18B2FC0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x18B2FD0 Offset: 0x18B30D1 VA: 0x18B2FD0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x18B30E0 Offset: 0x18B31E1 VA: 0x18B30E0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x18B30F0 Offset: 0x18B31F1 VA: 0x18B30F0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x18B3100 Offset: 0x18B3201 VA: 0x18B3100
	internal void ThrowIfError() { }

	// RVA: 0x18B2090 Offset: 0x18B2191 VA: 0x18B2090
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B2180 Offset: 0x18B2281 VA: 0x18B2180
	internal static void EndWrite(IAsyncResult asyncResult) { }
}

