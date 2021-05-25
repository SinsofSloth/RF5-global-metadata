internal sealed class InterpretedFrame // TypeDefIndex: 2485
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xBF720 Offset: 0xBF821 VA: 0xBF720
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x17BC6D0 Offset: 0x17BC7D1 VA: 0x17BC6D0
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x17BC7F0 Offset: 0x17BC8F1 VA: 0x17BC7F0
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x17BC880 Offset: 0x17BC981 VA: 0x17BC880
	public string get_Name() { }

	// RVA: 0x17BC8A0 Offset: 0x17BC9A1 VA: 0x17BC8A0
	public void Push(object value) { }

	// RVA: 0x17BC930 Offset: 0x17BCA31 VA: 0x17BC930
	public void Push(bool value) { }

	// RVA: 0x17BCA40 Offset: 0x17BCB41 VA: 0x17BCA40
	public void Push(int value) { }

	// RVA: 0x17BCAD0 Offset: 0x17BCBD1 VA: 0x17BCAD0
	public void Push(byte value) { }

	// RVA: 0x17BCBB0 Offset: 0x17BCCB1 VA: 0x17BCBB0
	public void Push(sbyte value) { }

	// RVA: 0x17BCC90 Offset: 0x17BCD91 VA: 0x17BCC90
	public void Push(short value) { }

	// RVA: 0x17BCD70 Offset: 0x17BCE71 VA: 0x17BCD70
	public void Push(ushort value) { }

	// RVA: 0x17BCE50 Offset: 0x17BCF51 VA: 0x17BCE50
	public object Pop() { }

	// RVA: 0x17BCEA0 Offset: 0x17BCFA1 VA: 0x17BCEA0
	internal void SetStackDepth(int depth) { }

	// RVA: 0x17BCED0 Offset: 0x17BCFD1 VA: 0x17BCED0
	public object Peek() { }

	// RVA: 0x17BCF20 Offset: 0x17BD021 VA: 0x17BCF20
	public void Dup() { }

	// RVA: 0x17BCFC0 Offset: 0x17BD0C1 VA: 0x17BCFC0
	public InterpretedFrame get_Parent() { }

	[IteratorStateMachineAttribute] // RVA: 0xC0D30 Offset: 0xC0E31 VA: 0xC0D30
	// RVA: 0x17BCFD0 Offset: 0x17BD0D1 VA: 0x17BCFD0
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x17BD0A0 Offset: 0x17BD1A1 VA: 0x17BD0A0
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x17BD340 Offset: 0x17BD441 VA: 0x17BD340
	internal InterpretedFrame Enter() { }

	// RVA: 0x17BD3D0 Offset: 0x17BD4D1 VA: 0x17BD3D0
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x17BD430 Offset: 0x17BD531 VA: 0x17BD430
	internal bool IsJumpHappened() { }

	// RVA: 0x17BD440 Offset: 0x17BD541 VA: 0x17BD440
	public void RemoveContinuation() { }

	// RVA: 0x17BD450 Offset: 0x17BD551 VA: 0x17BD450
	public void PushContinuation(int continuation) { }

	// RVA: 0x17BD4A0 Offset: 0x17BD5A1 VA: 0x17BD4A0
	public int YieldToCurrentContinuation() { }

	// RVA: 0x17BD520 Offset: 0x17BD621 VA: 0x17BD520
	public int YieldToPendingContinuation() { }

	// RVA: 0x17BD700 Offset: 0x17BD801 VA: 0x17BD700
	internal void PushPendingContinuation() { }

	// RVA: 0x17BD7A0 Offset: 0x17BD8A1 VA: 0x17BD7A0
	internal void PopPendingContinuation() { }

	// RVA: 0x17BD890 Offset: 0x17BD991 VA: 0x17BD890
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}

