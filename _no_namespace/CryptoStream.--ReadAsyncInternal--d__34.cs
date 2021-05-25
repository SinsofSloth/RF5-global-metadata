[CompilerGeneratedAttribute] // RVA: 0xAFE50 Offset: 0xAFF51 VA: 0xAFE50
private struct CryptoStream.<ReadAsyncInternal>d__34 : IAsyncStateMachine // TypeDefIndex: 925
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private byte[] <tempInputBuffer>5__1; // 0x40
	private int <currentOutputIndex>5__2; // 0x48
	private int <bytesToDeliver>5__3; // 0x4C
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60
	private int <>7__wrap1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3; // 0x78

	// Methods

	// RVA: 0x12160 Offset: 0x12261 VA: 0x12160 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0xB9270 Offset: 0xB9371 VA: 0xB9270
	// RVA: 0x12170 Offset: 0x12271 VA: 0x12170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

