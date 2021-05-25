[Serializable]
public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2078
{
	// Fields
	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3843B0 Offset: 0x3844B1 VA: 0x3843B0
	|-Queue.Enumerator<DamageTextInfo>..ctor
	|
	|-RVA: 0x384540 Offset: 0x384641 VA: 0x384540
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x384690 Offset: 0x384791 VA: 0x384690
	|-Queue.Enumerator<object>..ctor
	|
	|-RVA: 0x384840 Offset: 0x384941 VA: 0x384840
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384400 Offset: 0x384501 VA: 0x384400
	|-Queue.Enumerator<DamageTextInfo>.Dispose
	|
	|-RVA: 0x384580 Offset: 0x384681 VA: 0x384580
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x3846D0 Offset: 0x3847D1 VA: 0x3846D0
	|-Queue.Enumerator<object>.Dispose
	|
	|-RVA: 0x384880 Offset: 0x384981 VA: 0x384880
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384420 Offset: 0x384521 VA: 0x384420
	|-Queue.Enumerator<DamageTextInfo>.MoveNext
	|
	|-RVA: 0x384590 Offset: 0x384691 VA: 0x384590
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x3846E0 Offset: 0x3847E1 VA: 0x3846E0
	|-Queue.Enumerator<object>.MoveNext
	|
	|-RVA: 0x384890 Offset: 0x384991 VA: 0x384890
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384430 Offset: 0x384531 VA: 0x384430
	|-Queue.Enumerator<DamageTextInfo>.get_Current
	|
	|-RVA: 0x3845A0 Offset: 0x3846A1 VA: 0x3845A0
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x3846F0 Offset: 0x3847F1 VA: 0x3846F0
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x3848A0 Offset: 0x3849A1 VA: 0x3848A0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384470 Offset: 0x384571 VA: 0x384470
	|-Queue.Enumerator<DamageTextInfo>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x3845D0 Offset: 0x3846D1 VA: 0x3845D0
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x384720 Offset: 0x384821 VA: 0x384720
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x3848E0 Offset: 0x3849E1 VA: 0x3848E0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384480 Offset: 0x384581 VA: 0x384480
	|-Queue.Enumerator<DamageTextInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3845E0 Offset: 0x3846E1 VA: 0x3845E0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x384730 Offset: 0x384831 VA: 0x384730
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3848F0 Offset: 0x3849F1 VA: 0x3848F0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384490 Offset: 0x384591 VA: 0x384490
	|-Queue.Enumerator<DamageTextInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3845F0 Offset: 0x3846F1 VA: 0x3845F0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x384790 Offset: 0x384891 VA: 0x384790
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x384900 Offset: 0x384A01 VA: 0x384900
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	*/
}

