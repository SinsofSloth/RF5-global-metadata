[CompilerGeneratedAttribute] // RVA: 0xB35F0 Offset: 0xB36F1 VA: 0xB35F0
private sealed class ConcurrentDictionary.<GetEnumerator>d__32<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 1404
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public ConcurrentDictionary<TKey, TValue> <>4__this; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue>[] <buckets>5__1; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue> <current>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xB9B40 Offset: 0xB9C41 VA: 0xB9B40
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54FE0 Offset: 0x2B550E1 VA: 0x2B54FE0
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9B50 Offset: 0xB9C51 VA: 0xB9B50
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55020 Offset: 0x2B55121 VA: 0x2B55020
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55030 Offset: 0x2B55131 VA: 0x2B55030
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9B60 Offset: 0xB9C61 VA: 0xB9B60
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B551A0 Offset: 0x2B552A1 VA: 0x2B551A0
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9B70 Offset: 0xB9C71 VA: 0xB9B70
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B551B0 Offset: 0x2B552B1 VA: 0x2B551B0
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xB9B80 Offset: 0xB9C81 VA: 0xB9B80
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55210 Offset: 0x2B55311 VA: 0x2B55210
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.Collections.IEnumerator.get_Current
	*/
}

