[CompilerGeneratedAttribute] // RVA: 0xBE150 Offset: 0xBE251 VA: 0xBE150
private sealed class Enumerable.<DefaultIfEmptyIterator>d__95<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2180
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private IEnumerator<TSource> <e>5__1; // 0x0
	private TSource defaultValue; // 0x0
	public TSource <>3__defaultValue; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xC0290 Offset: 0xC0391 VA: 0xC0290
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B233A0 Offset: 0x2B234A1 VA: 0x2B233A0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>..ctor
	|
	|-RVA: 0x2B23A40 Offset: 0x2B23B41 VA: 0x2B23A40
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC02A0 Offset: 0xC03A1 VA: 0xC02A0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B233E0 Offset: 0x2B234E1 VA: 0x2B233E0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B23A80 Offset: 0x2B23B81 VA: 0x2B23A80
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B23420 Offset: 0x2B23521 VA: 0x2B23420
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.MoveNext
	|
	|-RVA: 0x2B23AC0 Offset: 0x2B23BC1 VA: 0x2B23AC0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B237D0 Offset: 0x2B238D1 VA: 0x2B237D0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.<>m__Finally1
	|
	|-RVA: 0x2B23EA0 Offset: 0x2B23FA1 VA: 0x2B23EA0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC02B0 Offset: 0xC03B1 VA: 0xC02B0
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B23890 Offset: 0x2B23991 VA: 0x2B23890
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2B23F60 Offset: 0x2B24061 VA: 0x2B23F60
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC02C0 Offset: 0xC03C1 VA: 0xC02C0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B238A0 Offset: 0x2B239A1 VA: 0x2B238A0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B23F70 Offset: 0x2B24071 VA: 0x2B23F70
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC02D0 Offset: 0xC03D1 VA: 0xC02D0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B23900 Offset: 0x2B23A01 VA: 0x2B23900
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B23FD0 Offset: 0x2B240D1 VA: 0x2B23FD0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC02E0 Offset: 0xC03E1 VA: 0xC02E0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B23950 Offset: 0x2B23A51 VA: 0x2B23950
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2B23FE0 Offset: 0x2B240E1 VA: 0x2B23FE0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC02F0 Offset: 0xC03F1 VA: 0xC02F0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B23A10 Offset: 0x2B23B11 VA: 0x2B23A10
	|-Enumerable.<DefaultIfEmptyIterator>d__95<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B240A0 Offset: 0x2B241A1 VA: 0x2B240A0
	|-Enumerable.<DefaultIfEmptyIterator>d__95<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

