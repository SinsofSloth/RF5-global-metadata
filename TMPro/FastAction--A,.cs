public class FastAction<A, B> // TypeDefIndex: 5745
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B5310 Offset: 0x28B5411 VA: 0x28B5310
	|-FastAction<bool, object>.Add
	|
	|-RVA: 0x28B55E0 Offset: 0x28B56E1 VA: 0x28B55E0
	|-FastAction<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B53C0 Offset: 0x28B54C1 VA: 0x28B53C0
	|-FastAction<bool, object>.Remove
	|
	|-RVA: 0x28B5690 Offset: 0x28B5791 VA: 0x28B5690
	|-FastAction<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B5460 Offset: 0x28B5561 VA: 0x28B5460
	|-FastAction<bool, object>.Call
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, Object>.Call
	|
	|-RVA: 0x28B5730 Offset: 0x28B5831 VA: 0x28B5730
	|-FastAction<object, object>.Call
	|-FastAction<object, Compute_DT_EventArgs>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28B5510 Offset: 0x28B5611 VA: 0x28B5510
	|-FastAction<bool, object>..ctor
	|-FastAction<bool, Material>..ctor
	|-FastAction<bool, Object>..ctor
	|
	|-RVA: 0x28B57E0 Offset: 0x28B58E1 VA: 0x28B57E0
	|-FastAction<object, object>..ctor
	|-FastAction<object, Compute_DT_EventArgs>..ctor
	*/
}

