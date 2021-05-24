[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

[ComVisibleAttribute] // RVA: 0xB1150 Offset: 0xB1251 VA: 0xB1150
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1196
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x174C8D0 Offset: 0x174C9D1 VA: 0x174C8D0
	internal void .ctor() { }

	// RVA: 0x174C8E0 Offset: 0x174C9E1 VA: 0x174C8E0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x174C9F0 Offset: 0x174CAF1 VA: 0x174C9F0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x174CA90 Offset: 0x174CB91 VA: 0x174CA90 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x174CAA0 Offset: 0x174CBA1 VA: 0x174CAA0 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x174CBC0 Offset: 0x174CCC1 VA: 0x174CBC0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x174CBD0 Offset: 0x174CCD1 VA: 0x174CBD0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x174CBE0 Offset: 0x174CCE1 VA: 0x174CBE0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x174CBF0 Offset: 0x174CCF1 VA: 0x174CBF0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x174CC00 Offset: 0x174CD01 VA: 0x174CC00 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x174CC10 Offset: 0x174CD11 VA: 0x174CC10 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x174CC20 Offset: 0x174CD21 VA: 0x174CC20 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174CC80 Offset: 0x174CD81 VA: 0x174CC80 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x174CC90 Offset: 0x174CD91 VA: 0x174CC90 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x174CCA0 Offset: 0x174CDA1 VA: 0x174CCA0
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x174CCB0 Offset: 0x174CDB1 VA: 0x174CCB0
	internal IMessage EndInvoke() { }

	// RVA: 0x174CDC0 Offset: 0x174CEC1 VA: 0x174CDC0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174CF20 Offset: 0x174D021 VA: 0x174CF20
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x174CF30 Offset: 0x174D031 VA: 0x174CF30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x174CF40 Offset: 0x174D041 VA: 0x174CF40 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x174CF60 Offset: 0x174D061 VA: 0x174CF60 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x174CF50 Offset: 0x174D051 VA: 0x174CF50
	internal object Invoke() { }

	// RVA: 0x174CF70 Offset: 0x174D071 VA: 0x174CF70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94C0 Offset: 0xB95C1 VA: 0xB94C0
	// RVA: 0x174CFF0 Offset: 0x174D0F1 VA: 0x174CFF0
	private void <.ctor>b__17_0(object <p0>) { }
}

