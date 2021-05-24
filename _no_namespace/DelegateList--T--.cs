internal class DelegateList<T> // TypeDefIndex: 4446
{
	// Fields
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc; // 0x0
	private Action<LinkedListNode<Action<T>>> m_releaseFunc; // 0x0
	private LinkedList<Action<T>> m_callbacks; // 0x0
	private bool m_invoking; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D230 Offset: 0x2C8D331 VA: 0x2C8D230
	|-DelegateList<object>..ctor
	|
	|-RVA: 0x2C8DA50 Offset: 0x2C8DB51 VA: 0x2C8DA50
	|-DelegateList<float>..ctor
	|
	|-RVA: 0x2C8E270 Offset: 0x2C8E371 VA: 0x2C8E270
	|-DelegateList<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2C8EAC0 Offset: 0x2C8EBC1 VA: 0x2C8EAC0
	|-DelegateList<AsyncOperationHandle<bool>>..ctor
	|
	|-RVA: 0x2C8F310 Offset: 0x2C8F411 VA: 0x2C8F310
	|-DelegateList<AsyncOperationHandle<long>>..ctor
	|
	|-RVA: 0x2C8FB60 Offset: 0x2C8FC61 VA: 0x2C8FB60
	|-DelegateList<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2C903B0 Offset: 0x2C904B1 VA: 0x2C903B0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2C90C00 Offset: 0x2C90D01 VA: 0x2C90C00
	|-DelegateList<DiagnosticEvent>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D310 Offset: 0x2C8D411 VA: 0x2C8D310
	|-DelegateList<object>.get_Count
	|
	|-RVA: 0x2C8DB30 Offset: 0x2C8DC31 VA: 0x2C8DB30
	|-DelegateList<float>.get_Count
	|
	|-RVA: 0x2C8E350 Offset: 0x2C8E451 VA: 0x2C8E350
	|-DelegateList<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x2C8EBA0 Offset: 0x2C8ECA1 VA: 0x2C8EBA0
	|-DelegateList<AsyncOperationHandle<bool>>.get_Count
	|
	|-RVA: 0x2C8F3F0 Offset: 0x2C8F4F1 VA: 0x2C8F3F0
	|-DelegateList<AsyncOperationHandle<long>>.get_Count
	|
	|-RVA: 0x2C8FC40 Offset: 0x2C8FD41 VA: 0x2C8FC40
	|-DelegateList<AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x2C90490 Offset: 0x2C90591 VA: 0x2C90490
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.get_Count
	|
	|-RVA: 0x2C90CE0 Offset: 0x2C90DE1 VA: 0x2C90CE0
	|-DelegateList<DiagnosticEvent>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D330 Offset: 0x2C8D431 VA: 0x2C8D330
	|-DelegateList<object>.Add
	|
	|-RVA: 0x2C8DB50 Offset: 0x2C8DC51 VA: 0x2C8DB50
	|-DelegateList<float>.Add
	|
	|-RVA: 0x2C8E370 Offset: 0x2C8E471 VA: 0x2C8E370
	|-DelegateList<AsyncOperationHandle>.Add
	|
	|-RVA: 0x2C8EBC0 Offset: 0x2C8ECC1 VA: 0x2C8EBC0
	|-DelegateList<AsyncOperationHandle<bool>>.Add
	|
	|-RVA: 0x2C8F410 Offset: 0x2C8F511 VA: 0x2C8F410
	|-DelegateList<AsyncOperationHandle<long>>.Add
	|
	|-RVA: 0x2C8FC60 Offset: 0x2C8FD61 VA: 0x2C8FC60
	|-DelegateList<AsyncOperationHandle<object>>.Add
	|
	|-RVA: 0x2C904B0 Offset: 0x2C905B1 VA: 0x2C904B0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Add
	|
	|-RVA: 0x2C90D00 Offset: 0x2C90E01 VA: 0x2C90D00
	|-DelegateList<DiagnosticEvent>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D3F0 Offset: 0x2C8D4F1 VA: 0x2C8D3F0
	|-DelegateList<object>.Remove
	|
	|-RVA: 0x2C8DC10 Offset: 0x2C8DD11 VA: 0x2C8DC10
	|-DelegateList<float>.Remove
	|
	|-RVA: 0x2C8E430 Offset: 0x2C8E531 VA: 0x2C8E430
	|-DelegateList<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x2C8EC80 Offset: 0x2C8ED81 VA: 0x2C8EC80
	|-DelegateList<AsyncOperationHandle<bool>>.Remove
	|
	|-RVA: 0x2C8F4D0 Offset: 0x2C8F5D1 VA: 0x2C8F4D0
	|-DelegateList<AsyncOperationHandle<long>>.Remove
	|
	|-RVA: 0x2C8FD20 Offset: 0x2C8FE21 VA: 0x2C8FD20
	|-DelegateList<AsyncOperationHandle<object>>.Remove
	|
	|-RVA: 0x2C90570 Offset: 0x2C90671 VA: 0x2C90570
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Remove
	|
	|-RVA: 0x2C90DC0 Offset: 0x2C90EC1 VA: 0x2C90DC0
	|-DelegateList<DiagnosticEvent>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T res) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D510 Offset: 0x2C8D611 VA: 0x2C8D510
	|-DelegateList<object>.Invoke
	|
	|-RVA: 0x2C8DD30 Offset: 0x2C8DE31 VA: 0x2C8DD30
	|-DelegateList<float>.Invoke
	|
	|-RVA: 0x2C8E550 Offset: 0x2C8E651 VA: 0x2C8E550
	|-DelegateList<AsyncOperationHandle>.Invoke
	|
	|-RVA: 0x2C8EDA0 Offset: 0x2C8EEA1 VA: 0x2C8EDA0
	|-DelegateList<AsyncOperationHandle<bool>>.Invoke
	|
	|-RVA: 0x2C8F5F0 Offset: 0x2C8F6F1 VA: 0x2C8F5F0
	|-DelegateList<AsyncOperationHandle<long>>.Invoke
	|
	|-RVA: 0x2C8FE40 Offset: 0x2C8FF41 VA: 0x2C8FE40
	|-DelegateList<AsyncOperationHandle<object>>.Invoke
	|
	|-RVA: 0x2C90690 Offset: 0x2C90791 VA: 0x2C90690
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x2C90EE0 Offset: 0x2C90FE1 VA: 0x2C90EE0
	|-DelegateList<DiagnosticEvent>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D780 Offset: 0x2C8D881 VA: 0x2C8D780
	|-DelegateList<object>.Clear
	|
	|-RVA: 0x2C8DFA0 Offset: 0x2C8E0A1 VA: 0x2C8DFA0
	|-DelegateList<float>.Clear
	|
	|-RVA: 0x2C8E7F0 Offset: 0x2C8E8F1 VA: 0x2C8E7F0
	|-DelegateList<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x2C8F040 Offset: 0x2C8F141 VA: 0x2C8F040
	|-DelegateList<AsyncOperationHandle<bool>>.Clear
	|
	|-RVA: 0x2C8F890 Offset: 0x2C8F991 VA: 0x2C8F890
	|-DelegateList<AsyncOperationHandle<long>>.Clear
	|
	|-RVA: 0x2C900E0 Offset: 0x2C901E1 VA: 0x2C900E0
	|-DelegateList<AsyncOperationHandle<object>>.Clear
	|
	|-RVA: 0x2C90930 Offset: 0x2C90A31 VA: 0x2C90930
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Clear
	|
	|-RVA: 0x2C91190 Offset: 0x2C91291 VA: 0x2C91190
	|-DelegateList<DiagnosticEvent>.Clear
	*/

	// RVA: -1 Offset: -1
	public static DelegateList<T> CreateWithGlobalCache() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8D840 Offset: 0x2C8D941 VA: 0x2C8D840
	|-DelegateList<object>.CreateWithGlobalCache
	|
	|-RVA: 0x2C8E060 Offset: 0x2C8E161 VA: 0x2C8E060
	|-DelegateList<float>.CreateWithGlobalCache
	|
	|-RVA: 0x2C8E8B0 Offset: 0x2C8E9B1 VA: 0x2C8E8B0
	|-DelegateList<AsyncOperationHandle>.CreateWithGlobalCache
	|
	|-RVA: 0x2C8F100 Offset: 0x2C8F201 VA: 0x2C8F100
	|-DelegateList<AsyncOperationHandle<bool>>.CreateWithGlobalCache
	|
	|-RVA: 0x2C8F950 Offset: 0x2C8FA51 VA: 0x2C8F950
	|-DelegateList<AsyncOperationHandle<long>>.CreateWithGlobalCache
	|
	|-RVA: 0x2C901A0 Offset: 0x2C902A1 VA: 0x2C901A0
	|-DelegateList<AsyncOperationHandle<object>>.CreateWithGlobalCache
	|
	|-RVA: 0x2C909F0 Offset: 0x2C90AF1 VA: 0x2C909F0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.CreateWithGlobalCache
	|
	|-RVA: 0x2C91250 Offset: 0x2C91351 VA: 0x2C91250
	|-DelegateList<DiagnosticEvent>.CreateWithGlobalCache
	*/
}

