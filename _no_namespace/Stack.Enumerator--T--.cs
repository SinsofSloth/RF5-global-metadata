[Serializable]
public struct Stack.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2103
{
	// Fields
	private readonly Stack<T> _stack; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E370 Offset: 0x39E471 VA: 0x39E370
	|-Stack.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x39E4E0 Offset: 0x39E5E1 VA: 0x39E4E0
	|-Stack.Enumerator<int>..ctor
	|
	|-RVA: 0x39E630 Offset: 0x39E731 VA: 0x39E630
	|-Stack.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x39E780 Offset: 0x39E881 VA: 0x39E780
	|-Stack.Enumerator<object>..ctor
	|
	|-RVA: 0x39E930 Offset: 0x39EA31 VA: 0x39E930
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x39EAB0 Offset: 0x39EBB1 VA: 0x39EAB0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E3B0 Offset: 0x39E4B1 VA: 0x39E3B0
	|-Stack.Enumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x39E520 Offset: 0x39E621 VA: 0x39E520
	|-Stack.Enumerator<int>.Dispose
	|
	|-RVA: 0x39E670 Offset: 0x39E771 VA: 0x39E670
	|-Stack.Enumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x39E7C0 Offset: 0x39E8C1 VA: 0x39E7C0
	|-Stack.Enumerator<object>.Dispose
	|
	|-RVA: 0x39E980 Offset: 0x39EA81 VA: 0x39E980
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>.Dispose
	|
	|-RVA: 0x39EAF0 Offset: 0x39EBF1 VA: 0x39EAF0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E3C0 Offset: 0x39E4C1 VA: 0x39E3C0
	|-Stack.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x39E530 Offset: 0x39E631 VA: 0x39E530
	|-Stack.Enumerator<int>.MoveNext
	|
	|-RVA: 0x39E680 Offset: 0x39E781 VA: 0x39E680
	|-Stack.Enumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x39E7D0 Offset: 0x39E8D1 VA: 0x39E7D0
	|-Stack.Enumerator<object>.MoveNext
	|
	|-RVA: 0x39E990 Offset: 0x39EA91 VA: 0x39E990
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>.MoveNext
	|
	|-RVA: 0x39EB00 Offset: 0x39EC01 VA: 0x39EB00
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E3D0 Offset: 0x39E4D1 VA: 0x39E3D0
	|-Stack.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x39E540 Offset: 0x39E641 VA: 0x39E540
	|-Stack.Enumerator<int>.get_Current
	|
	|-RVA: 0x39E690 Offset: 0x39E791 VA: 0x39E690
	|-Stack.Enumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x39E7E0 Offset: 0x39E8E1 VA: 0x39E7E0
	|-Stack.Enumerator<object>.get_Current
	|
	|-RVA: 0x39E9A0 Offset: 0x39EAA1 VA: 0x39E9A0
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>.get_Current
	|
	|-RVA: 0x39EB10 Offset: 0x39EC11 VA: 0x39EB10
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E410 Offset: 0x39E511 VA: 0x39E410
	|-Stack.Enumerator<KeyValuePair<object, object>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x39E570 Offset: 0x39E671 VA: 0x39E570
	|-Stack.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x39E6C0 Offset: 0x39E7C1 VA: 0x39E6C0
	|-Stack.Enumerator<Int32Enum>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x39E810 Offset: 0x39E911 VA: 0x39E810
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x39E9E0 Offset: 0x39EAE1 VA: 0x39E9E0
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x39EB50 Offset: 0x39EC51 VA: 0x39EB50
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E420 Offset: 0x39E521 VA: 0x39E420
	|-Stack.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E580 Offset: 0x39E681 VA: 0x39E580
	|-Stack.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E6D0 Offset: 0x39E7D1 VA: 0x39E6D0
	|-Stack.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E820 Offset: 0x39E921 VA: 0x39E820
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E9F0 Offset: 0x39EAF1 VA: 0x39E9F0
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39EB60 Offset: 0x39EC61 VA: 0x39EB60
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E430 Offset: 0x39E531 VA: 0x39E430
	|-Stack.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39E590 Offset: 0x39E691 VA: 0x39E590
	|-Stack.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39E6E0 Offset: 0x39E7E1 VA: 0x39E6E0
	|-Stack.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39E880 Offset: 0x39E981 VA: 0x39E880
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39EA00 Offset: 0x39EB01 VA: 0x39EA00
	|-Stack.Enumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39EB70 Offset: 0x39EC71 VA: 0x39EB70
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	*/
}

