public class FastAction<A> // TypeDefIndex: 5744
{
	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B4D70 Offset: 0x28B4E71 VA: 0x28B4D70
	|-FastAction<bool>.Add
	|
	|-RVA: 0x28B5040 Offset: 0x28B5141 VA: 0x28B5040
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B4E20 Offset: 0x28B4F21 VA: 0x28B4E20
	|-FastAction<bool>.Remove
	|
	|-RVA: 0x28B50F0 Offset: 0x28B51F1 VA: 0x28B50F0
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B4EC0 Offset: 0x28B4FC1 VA: 0x28B4EC0
	|-FastAction<bool>.Call
	|
	|-RVA: 0x28B5190 Offset: 0x28B5291 VA: 0x28B5190
	|-FastAction<object>.Call
	|-FastAction<Object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B4F70 Offset: 0x28B5071 VA: 0x28B4F70
	|-FastAction<bool>..ctor
	|
	|-RVA: 0x28B5240 Offset: 0x28B5341 VA: 0x28B5240
	|-FastAction<object>..ctor
	|-FastAction<Object>..ctor
	*/
}

