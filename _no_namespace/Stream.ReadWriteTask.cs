private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 658
{
	// Fields
	internal readonly bool _isRead; // 0x54
	internal Stream _stream; // 0x58
	internal byte[] _buffer; // 0x60
	internal int _offset; // 0x68
	internal int _count; // 0x6C
	private AsyncCallback _callback; // 0x70
	private ExecutionContext _context; // 0x78
	private static ContextCallback s_invokeAsyncCallback; // 0x0

	// Methods

	// RVA: 0x18B2590 Offset: 0x18B2691 VA: 0x18B2590
	internal void ClearBeginState() { }

	// RVA: 0x18B1130 Offset: 0x18B1231 VA: 0x18B1130
	public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x18B2D60 Offset: 0x18B2E61 VA: 0x18B2D60
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x18B2DF0 Offset: 0x18B2EF1 VA: 0x18B2DF0 Slot: 20
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }
}

