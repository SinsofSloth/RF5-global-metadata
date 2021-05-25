[CompilerGeneratedAttribute] // RVA: 0xBE130 Offset: 0xBE231 VA: 0xBE130
private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2178
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xC01B0 Offset: 0xC02B1 VA: 0xC01B0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B240D0 Offset: 0x2B241D1 VA: 0x2B240D0
	|-Enumerable.<DistinctIterator>d__68<int>..ctor
	|
	|-RVA: 0x2B24740 Offset: 0x2B24841 VA: 0x2B24740
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC01C0 Offset: 0xC02C1 VA: 0xC01C0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B24110 Offset: 0x2B24211 VA: 0x2B24110
	|-Enumerable.<DistinctIterator>d__68<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B24780 Offset: 0x2B24881 VA: 0x2B24780
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B24140 Offset: 0x2B24241 VA: 0x2B24140
	|-Enumerable.<DistinctIterator>d__68<int>.MoveNext
	|
	|-RVA: 0x2B247B0 Offset: 0x2B248B1 VA: 0x2B247B0
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B244D0 Offset: 0x2B245D1 VA: 0x2B244D0
	|-Enumerable.<DistinctIterator>d__68<int>.<>m__Finally1
	|
	|-RVA: 0x2B24B50 Offset: 0x2B24C51 VA: 0x2B24B50
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC01D0 Offset: 0xC02D1 VA: 0xC01D0
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B24590 Offset: 0x2B24691 VA: 0x2B24590
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2B24C10 Offset: 0x2B24D11 VA: 0x2B24C10
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC01E0 Offset: 0xC02E1 VA: 0xC01E0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B245A0 Offset: 0x2B246A1 VA: 0x2B245A0
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B24C20 Offset: 0x2B24D21 VA: 0x2B24C20
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC01F0 Offset: 0xC02F1 VA: 0xC01F0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B24600 Offset: 0x2B24701 VA: 0x2B24600
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B24C80 Offset: 0x2B24D81 VA: 0x2B24C80
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC0200 Offset: 0xC0301 VA: 0xC0200
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B24650 Offset: 0x2B24751 VA: 0x2B24650
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2B24C90 Offset: 0x2B24D91 VA: 0x2B24C90
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0xC0210 Offset: 0xC0311 VA: 0xC0210
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B24710 Offset: 0x2B24811 VA: 0x2B24710
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B24D50 Offset: 0x2B24E51 VA: 0x2B24D50
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

