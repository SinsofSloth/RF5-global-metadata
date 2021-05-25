[CompilerGeneratedAttribute] // RVA: 0xB3710 Offset: 0xB3811 VA: 0xB3710
private sealed class ConcurrentQueue.<Enumerate>d__27<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1409
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ConcurrentQueue.Segment<T> head; // 0x0
	public ConcurrentQueue.Segment<T> tail; // 0x0
	public int tailTail; // 0x0
	public int headHead; // 0x0
	public ConcurrentQueue<T> <>4__this; // 0x0
	private int <i>5__1; // 0x0
	private int <headTail>5__2; // 0x0
	private int <i>5__3; // 0x0
	private int <i>5__4; // 0x0
	private ConcurrentQueue.Segment<T> <s>5__5; // 0x0
	private int <i>5__6; // 0x0
	private int <sTail>5__7; // 0x0
	private int <i>5__8; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xB9C00 Offset: 0xB9D01 VA: 0xB9C00
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A340 Offset: 0x2B5A441 VA: 0x2B5A340
	|-ConcurrentQueue.<Enumerate>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9C10 Offset: 0xB9D11 VA: 0xB9C10
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A380 Offset: 0x2B5A481 VA: 0x2B5A380
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A390 Offset: 0x2B5A491 VA: 0x2B5A390
	|-ConcurrentQueue.<Enumerate>d__27<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9C20 Offset: 0xB9D21 VA: 0xB9C20
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A760 Offset: 0x2B5A861 VA: 0x2B5A760
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9C30 Offset: 0xB9D31 VA: 0xB9C30
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A770 Offset: 0x2B5A871 VA: 0x2B5A770
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9C40 Offset: 0xB9D41 VA: 0xB9C40
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A7D0 Offset: 0x2B5A8D1 VA: 0x2B5A7D0
	|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.get_Current
	*/
}

