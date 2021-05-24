[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[NativeHeaderAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
[RequiredByNativeCodeAttribute] // RVA: 0xC65E0 Offset: 0xC66E1 VA: 0xC65E0
public class AsyncOperation : YieldInstruction // TypeDefIndex: 2990
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }
	public float progress { get; }
	public int priority { set; }
	public bool allowSceneActivation { set; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	[NativeMethodAttribute] // RVA: 0xD5B40 Offset: 0xD5C41 VA: 0xD5B40
	// RVA: 0x2AF77C0 Offset: 0x2AF78C1 VA: 0x2AF77C0
	private static void InternalDestroy(IntPtr ptr) { }

	[NativeMethodAttribute] // RVA: 0xD5BA0 Offset: 0xD5CA1 VA: 0xD5BA0
	// RVA: 0x2AF7810 Offset: 0x2AF7911 VA: 0x2AF7810
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0xD5BE0 Offset: 0xD5CE1 VA: 0xD5BE0
	// RVA: 0x2AF7860 Offset: 0x2AF7961 VA: 0x2AF7860
	public float get_progress() { }

	[NativeMethodAttribute] // RVA: 0xD5C20 Offset: 0xD5D21 VA: 0xD5C20
	// RVA: 0x2AF78B0 Offset: 0x2AF79B1 VA: 0x2AF78B0
	public void set_priority(int value) { }

	[NativeMethodAttribute] // RVA: 0xD5C60 Offset: 0xD5D61 VA: 0xD5C60
	// RVA: 0x2AF7900 Offset: 0x2AF7A01 VA: 0x2AF7900
	public void set_allowSceneActivation(bool value) { }

	// RVA: 0x2AF7950 Offset: 0x2AF7A51 VA: 0x2AF7950 Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD5CA0 Offset: 0xD5DA1 VA: 0xD5CA0
	// RVA: 0x2AF79F0 Offset: 0x2AF7AF1 VA: 0x2AF79F0
	internal void InvokeCompletionEvent() { }

	// RVA: 0x2AF7A70 Offset: 0x2AF7B71 VA: 0x2AF7A70
	public void add_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7B70 Offset: 0x2AF7C71 VA: 0x2AF7B70
	public void remove_completed(Action<AsyncOperation> value) { }

	// RVA: 0x2AF7C00 Offset: 0x2AF7D01 VA: 0x2AF7C00
	public void .ctor() { }
}

