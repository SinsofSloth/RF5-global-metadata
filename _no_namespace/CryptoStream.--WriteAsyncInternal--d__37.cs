[CompilerGeneratedAttribute] // RVA: 0xAFE60 Offset: 0xAFF61 VA: 0xAFE60
private struct CryptoStream.<WriteAsyncInternal>d__37 : IAsyncStateMachine // TypeDefIndex: 926
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private int <bytesToWrite>5__1; // 0x40
	private int <currentInputIndex>5__2; // 0x44
	private int <numWholeBlocksInBytes>5__3; // 0x48
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x121D0 Offset: 0x122D1 VA: 0x121D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0xB9280 Offset: 0xB9381 VA: 0xB9280
	// RVA: 0x121E0 Offset: 0x122E1 VA: 0x121E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

