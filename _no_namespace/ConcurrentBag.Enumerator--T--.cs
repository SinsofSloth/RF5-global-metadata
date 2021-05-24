[Serializable]
private sealed class ConcurrentBag.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2108
{
	// Fields
	private readonly T[] _array; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53870 Offset: 0x2B53971 VA: 0x2B53870
	|-ConcurrentBag.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B538B0 Offset: 0x2B539B1 VA: 0x2B538B0
	|-ConcurrentBag.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53930 Offset: 0x2B53A31 VA: 0x2B53930
	|-ConcurrentBag.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53940 Offset: 0x2B53A41 VA: 0x2B53940
	|-ConcurrentBag.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53A00 Offset: 0x2B53B01 VA: 0x2B53A00
	|-ConcurrentBag.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53A10 Offset: 0x2B53B11 VA: 0x2B53A10
	|-ConcurrentBag.Enumerator<object>.Dispose
	*/
}

