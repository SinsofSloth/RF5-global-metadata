internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 645
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14220 Offset: 0x2B14321 VA: 0x2B14220
	|-Iterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14270 Offset: 0x2B14371 VA: 0x2B14270
	|-Iterator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14280 Offset: 0x2B14381 VA: 0x2B14280
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14310 Offset: 0x2B14411 VA: 0x2B14310
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14320 Offset: 0x2B14421 VA: 0x2B14320
	|-Iterator<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B14390 Offset: 0x2B14491 VA: 0x2B14390
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B143C0 Offset: 0x2B144C1 VA: 0x2B143C0
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B143F0 Offset: 0x2B144F1 VA: 0x2B143F0
	|-Iterator<object>.System.Collections.IEnumerator.Reset
	*/
}

