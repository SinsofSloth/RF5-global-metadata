[DebuggerTypeProxyAttribute] // RVA: 0xBCA50 Offset: 0xBCB51 VA: 0xBCA50
[DebuggerDisplayAttribute] // RVA: 0xBCA50 Offset: 0xBCB51 VA: 0xBCA50
[Serializable]
public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 2102
{
	// Fields
	private T[] _array; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int DefaultCapacity = 4;

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE3290 Offset: 0x2EE3391 VA: 0x2EE3290
	|-Stack<Tween>..ctor
	|-Stack<ErosionBrush.TerrainUndoStep[]>..ctor
	|-Stack<Sequence<byte>>..ctor
	|-Stack<EnvironmentSoundController>..ctor
	|-Stack<HashSet<ParameterExpression>>..ctor
	|-Stack<ParameterExpression>..ctor
	|-Stack<object>..ctor
	|-Stack<string>..ctor
	|-Stack<string[]>..ctor
	|-Stack<GameObject[]>..ctor
	|-Stack<AsyncOperationHandle<SceneInstance>[]>..ctor
	|-Stack<EventCallbackList>..ctor
	|-Stack<IMGUIContainer>..ctor
	|-Stack<XWeaponTrail.Element>..ctor
	|
	|-RVA: 0x2EE29B0 Offset: 0x2EE2AB1 VA: 0x2EE29B0
	|-Stack<FieldSceneId>..ctor
	|-Stack<Int32Enum>..ctor
	|-Stack<LogLevel>..ctor
	|
	|-RVA: 0x2EE1780 Offset: 0x2EE1881 VA: 0x2EE1780
	|-Stack<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EE20D0 Offset: 0x2EE21D1 VA: 0x2EE20D0
	|-Stack<int>..ctor
	|
	|-RVA: 0x2EE3BA0 Offset: 0x2EE3CA1 VA: 0x2EE3BA0
	|-Stack<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EE45D0 Offset: 0x2EE46D1 VA: 0x2EE45D0
	|-Stack<EventDispatcher.DispatchContext>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE17D0 Offset: 0x2EE18D1 VA: 0x2EE17D0
	|-Stack<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EE32E0 Offset: 0x2EE33E1 VA: 0x2EE32E0
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>..ctor
	|-Stack<object>..ctor
	|
	|-RVA: 0x2EE2120 Offset: 0x2EE2221 VA: 0x2EE2120
	|-Stack<int>..ctor
	|
	|-RVA: 0x2EE2A00 Offset: 0x2EE2B01 VA: 0x2EE2A00
	|-Stack<Int32Enum>..ctor
	|
	|-RVA: 0x2EE3BF0 Offset: 0x2EE3CF1 VA: 0x2EE3BF0
	|-Stack<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EE4620 Offset: 0x2EE4721 VA: 0x2EE4620
	|-Stack<EventDispatcher.DispatchContext>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE18E0 Offset: 0x2EE19E1 VA: 0x2EE18E0
	|-Stack<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2EE2230 Offset: 0x2EE2331 VA: 0x2EE2230
	|-Stack<int>..ctor
	|
	|-RVA: 0x2EE2B10 Offset: 0x2EE2C11 VA: 0x2EE2B10
	|-Stack<Int32Enum>..ctor
	|
	|-RVA: 0x2EE33F0 Offset: 0x2EE34F1 VA: 0x2EE33F0
	|-Stack<object>..ctor
	|
	|-RVA: 0x2EE3D00 Offset: 0x2EE3E01 VA: 0x2EE3D00
	|-Stack<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EE4730 Offset: 0x2EE4831 VA: 0x2EE4730
	|-Stack<EventDispatcher.DispatchContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE34C0 Offset: 0x2EE35C1 VA: 0x2EE34C0
	|-Stack<ErosionBrush.TerrainUndoStep[]>.get_Count
	|-Stack<Sequence<byte>>.get_Count
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>.get_Count
	|-Stack<object>.get_Count
	|-Stack<string>.get_Count
	|-Stack<string[]>.get_Count
	|-Stack<AsyncOperationHandle<SceneInstance>[]>.get_Count
	|-Stack<EventCallbackList>.get_Count
	|-Stack<IMGUIContainer>.get_Count
	|-Stack<XWeaponTrail.Element>.get_Count
	|
	|-RVA: 0x2EE2BE0 Offset: 0x2EE2CE1 VA: 0x2EE2BE0
	|-Stack<FieldSceneId>.get_Count
	|-Stack<Int32Enum>.get_Count
	|
	|-RVA: 0x2EE19B0 Offset: 0x2EE1AB1 VA: 0x2EE19B0
	|-Stack<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x2EE2300 Offset: 0x2EE2401 VA: 0x2EE2300
	|-Stack<int>.get_Count
	|
	|-RVA: 0x2EE3DD0 Offset: 0x2EE3ED1 VA: 0x2EE3DD0
	|-Stack<AsyncOperationHandle<SceneInstance>>.get_Count
	|
	|-RVA: 0x2EE4800 Offset: 0x2EE4901 VA: 0x2EE4800
	|-Stack<EventDispatcher.DispatchContext>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE34D0 Offset: 0x2EE35D1 VA: 0x2EE34D0
	|-Stack<Tween>.Clear
	|-Stack<object>.Clear
	|-Stack<string>.Clear
	|-Stack<string[]>.Clear
	|-Stack<GameObject[]>.Clear
	|-Stack<AsyncOperationHandle<SceneInstance>[]>.Clear
	|
	|-RVA: 0x2EE2BF0 Offset: 0x2EE2CF1 VA: 0x2EE2BF0
	|-Stack<FieldSceneId>.Clear
	|-Stack<Int32Enum>.Clear
	|
	|-RVA: 0x2EE19C0 Offset: 0x2EE1AC1 VA: 0x2EE19C0
	|-Stack<KeyValuePair<object, object>>.Clear
	|
	|-RVA: 0x2EE2310 Offset: 0x2EE2411 VA: 0x2EE2310
	|-Stack<int>.Clear
	|
	|-RVA: 0x2EE3DE0 Offset: 0x2EE3EE1 VA: 0x2EE3DE0
	|-Stack<AsyncOperationHandle<SceneInstance>>.Clear
	|
	|-RVA: 0x2EE4810 Offset: 0x2EE4911 VA: 0x2EE4810
	|-Stack<EventDispatcher.DispatchContext>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE2C00 Offset: 0x2EE2D01 VA: 0x2EE2C00
	|-Stack<FieldSceneId>.Contains
	|-Stack<Int32Enum>.Contains
	|
	|-RVA: 0x2EE1A00 Offset: 0x2EE1B01 VA: 0x2EE1A00
	|-Stack<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x2EE2320 Offset: 0x2EE2421 VA: 0x2EE2320
	|-Stack<int>.Contains
	|
	|-RVA: 0x2EE3510 Offset: 0x2EE3611 VA: 0x2EE3510
	|-Stack<object>.Contains
	|
	|-RVA: 0x2EE3E20 Offset: 0x2EE3F21 VA: 0x2EE3E20
	|-Stack<AsyncOperationHandle<SceneInstance>>.Contains
	|
	|-RVA: 0x2EE4850 Offset: 0x2EE4951 VA: 0x2EE4850
	|-Stack<EventDispatcher.DispatchContext>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE1A50 Offset: 0x2EE1B51 VA: 0x2EE1A50
	|-Stack<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EE2370 Offset: 0x2EE2471 VA: 0x2EE2370
	|-Stack<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EE2C50 Offset: 0x2EE2D51 VA: 0x2EE2C50
	|-Stack<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EE3560 Offset: 0x2EE3661 VA: 0x2EE3560
	|-Stack<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EE3EA0 Offset: 0x2EE3FA1 VA: 0x2EE3EA0
	|-Stack<AsyncOperationHandle<SceneInstance>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EE48A0 Offset: 0x2EE49A1 VA: 0x2EE48A0
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Stack.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE1CF0 Offset: 0x2EE1DF1 VA: 0x2EE1CF0
	|-Stack<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x2EE2610 Offset: 0x2EE2711 VA: 0x2EE2610
	|-Stack<int>.GetEnumerator
	|
	|-RVA: 0x2EE2EF0 Offset: 0x2EE2FF1 VA: 0x2EE2EF0
	|-Stack<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2EE3800 Offset: 0x2EE3901 VA: 0x2EE3800
	|-Stack<object>.GetEnumerator
	|
	|-RVA: 0x2EE4140 Offset: 0x2EE4241 VA: 0x2EE4140
	|-Stack<AsyncOperationHandle<SceneInstance>>.GetEnumerator
	|
	|-RVA: 0x2EE4B40 Offset: 0x2EE4C41 VA: 0x2EE4B40
	|-Stack<EventDispatcher.DispatchContext>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE1D50 Offset: 0x2EE1E51 VA: 0x2EE1D50
	|-Stack<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EE2680 Offset: 0x2EE2781 VA: 0x2EE2680
	|-Stack<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EE2F60 Offset: 0x2EE3061 VA: 0x2EE2F60
	|-Stack<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EE3860 Offset: 0x2EE3961 VA: 0x2EE3860
	|-Stack<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EE41B0 Offset: 0x2EE42B1 VA: 0x2EE41B0
	|-Stack<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2EE4BA0 Offset: 0x2EE4CA1 VA: 0x2EE4BA0
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE1DE0 Offset: 0x2EE1EE1 VA: 0x2EE1DE0
	|-Stack<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EE2710 Offset: 0x2EE2811 VA: 0x2EE2710
	|-Stack<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EE2FF0 Offset: 0x2EE30F1 VA: 0x2EE2FF0
	|-Stack<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EE38F0 Offset: 0x2EE39F1 VA: 0x2EE38F0
	|-Stack<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EE4260 Offset: 0x2EE4361 VA: 0x2EE4260
	|-Stack<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EE4C30 Offset: 0x2EE4D31 VA: 0x2EE4C30
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE3980 Offset: 0x2EE3A81 VA: 0x2EE3980
	|-Stack<ErosionBrush.TerrainUndoStep[]>.Peek
	|-Stack<ParameterExpression>.Peek
	|-Stack<string>.Peek
	|-Stack<string[]>.Peek
	|-Stack<GameObject[]>.Peek
	|-Stack<AsyncOperationHandle<SceneInstance>[]>.Peek
	|-Stack<IMGUIContainer>.Peek
	|-Stack<XWeaponTrail.Element>.Peek
	|-Stack<object>.Peek
	|
	|-RVA: 0x2EE3080 Offset: 0x2EE3181 VA: 0x2EE3080
	|-Stack<FieldSceneId>.Peek
	|-Stack<Int32Enum>.Peek
	|
	|-RVA: 0x2EE27A0 Offset: 0x2EE28A1 VA: 0x2EE27A0
	|-Stack<int>.Peek
	|
	|-RVA: 0x2EE4310 Offset: 0x2EE4411 VA: 0x2EE4310
	|-Stack<AsyncOperationHandle<SceneInstance>>.Peek
	|
	|-RVA: 0x2EE1E70 Offset: 0x2EE1F71 VA: 0x2EE1E70
	|-Stack<KeyValuePair<object, object>>.Peek
	|
	|-RVA: 0x2EE4CC0 Offset: 0x2EE4DC1 VA: 0x2EE4CC0
	|-Stack<EventDispatcher.DispatchContext>.Peek
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE39F0 Offset: 0x2EE3AF1 VA: 0x2EE39F0
	|-Stack<Tween>.Pop
	|-Stack<ErosionBrush.TerrainUndoStep[]>.Pop
	|-Stack<Sequence<byte>>.Pop
	|-Stack<EnvironmentSoundController>.Pop
	|-Stack<HashSet<ParameterExpression>>.Pop
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>.Pop
	|-Stack<ParameterExpression>.Pop
	|-Stack<string>.Pop
	|-Stack<string[]>.Pop
	|-Stack<GameObject[]>.Pop
	|-Stack<AsyncOperationHandle<SceneInstance>[]>.Pop
	|-Stack<EventCallbackList>.Pop
	|-Stack<IMGUIContainer>.Pop
	|-Stack<XWeaponTrail.Element>.Pop
	|-Stack<object>.Pop
	|
	|-RVA: 0x2EE30F0 Offset: 0x2EE31F1 VA: 0x2EE30F0
	|-Stack<FieldSceneId>.Pop
	|-Stack<Int32Enum>.Pop
	|
	|-RVA: 0x2EE2810 Offset: 0x2EE2911 VA: 0x2EE2810
	|-Stack<int>.Pop
	|
	|-RVA: 0x2EE43A0 Offset: 0x2EE44A1 VA: 0x2EE43A0
	|-Stack<AsyncOperationHandle<SceneInstance>>.Pop
	|
	|-RVA: 0x2EE1EF0 Offset: 0x2EE1FF1 VA: 0x2EE1EF0
	|-Stack<KeyValuePair<object, object>>.Pop
	|
	|-RVA: 0x2EE4D40 Offset: 0x2EE4E41 VA: 0x2EE4D40
	|-Stack<EventDispatcher.DispatchContext>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE3A80 Offset: 0x2EE3B81 VA: 0x2EE3A80
	|-Stack<Tween>.Push
	|-Stack<ErosionBrush.TerrainUndoStep[]>.Push
	|-Stack<Sequence<byte>>.Push
	|-Stack<EnvironmentSoundController>.Push
	|-Stack<HashSet<ParameterExpression>>.Push
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>.Push
	|-Stack<ParameterExpression>.Push
	|-Stack<object>.Push
	|-Stack<string>.Push
	|-Stack<string[]>.Push
	|-Stack<GameObject[]>.Push
	|-Stack<AsyncOperationHandle<SceneInstance>[]>.Push
	|-Stack<EventCallbackList>.Push
	|-Stack<IMGUIContainer>.Push
	|-Stack<XWeaponTrail.Element>.Push
	|
	|-RVA: 0x2EE3170 Offset: 0x2EE3271 VA: 0x2EE3170
	|-Stack<FieldSceneId>.Push
	|-Stack<Int32Enum>.Push
	|
	|-RVA: 0x2EE1F90 Offset: 0x2EE2091 VA: 0x2EE1F90
	|-Stack<KeyValuePair<object, object>>.Push
	|
	|-RVA: 0x2EE2890 Offset: 0x2EE2991 VA: 0x2EE2890
	|-Stack<int>.Push
	|
	|-RVA: 0x2EE4470 Offset: 0x2EE4571 VA: 0x2EE4470
	|-Stack<AsyncOperationHandle<SceneInstance>>.Push
	|
	|-RVA: 0x2EE4DE0 Offset: 0x2EE4EE1 VA: 0x2EE4DE0
	|-Stack<EventDispatcher.DispatchContext>.Push
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE2060 Offset: 0x2EE2161 VA: 0x2EE2060
	|-Stack<KeyValuePair<object, object>>.ThrowForEmptyStack
	|
	|-RVA: 0x2EE2940 Offset: 0x2EE2A41 VA: 0x2EE2940
	|-Stack<int>.ThrowForEmptyStack
	|
	|-RVA: 0x2EE3220 Offset: 0x2EE3321 VA: 0x2EE3220
	|-Stack<Int32Enum>.ThrowForEmptyStack
	|
	|-RVA: 0x2EE3B30 Offset: 0x2EE3C31 VA: 0x2EE3B30
	|-Stack<object>.ThrowForEmptyStack
	|
	|-RVA: 0x2EE4560 Offset: 0x2EE4661 VA: 0x2EE4560
	|-Stack<AsyncOperationHandle<SceneInstance>>.ThrowForEmptyStack
	|
	|-RVA: 0x2EE4EB0 Offset: 0x2EE4FB1 VA: 0x2EE4EB0
	|-Stack<EventDispatcher.DispatchContext>.ThrowForEmptyStack
	*/
}

