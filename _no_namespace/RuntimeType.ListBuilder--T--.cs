[DefaultMemberAttribute] // RVA: 0xAC650 Offset: 0xAC751 VA: 0xAC650
private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 303
{
	// Fields
	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	// Properties
	public T Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CBE0 Offset: 0x35CCE1 VA: 0x35CBE0
	|-RuntimeType.ListBuilder<object>..ctor
	|-RuntimeType.ListBuilder<ConstructorInfo>..ctor
	|-RuntimeType.ListBuilder<EventInfo>..ctor
	|-RuntimeType.ListBuilder<FieldInfo>..ctor
	|-RuntimeType.ListBuilder<MethodInfo>..ctor
	|-RuntimeType.ListBuilder<PropertyInfo>..ctor
	|-RuntimeType.ListBuilder<Type>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CC20 Offset: 0x35CD21 VA: 0x35CC20
	|-RuntimeType.ListBuilder<object>.get_Item
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Item
	|-RuntimeType.ListBuilder<MethodInfo>.get_Item
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CC60 Offset: 0x35CD61 VA: 0x35CC60
	|-RuntimeType.ListBuilder<object>.ToArray
	|-RuntimeType.ListBuilder<ConstructorInfo>.ToArray
	|-RuntimeType.ListBuilder<EventInfo>.ToArray
	|-RuntimeType.ListBuilder<FieldInfo>.ToArray
	|-RuntimeType.ListBuilder<MethodInfo>.ToArray
	|-RuntimeType.ListBuilder<PropertyInfo>.ToArray
	|-RuntimeType.ListBuilder<Type>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CC70 Offset: 0x35CD71 VA: 0x35CC70
	|-RuntimeType.ListBuilder<object>.CopyTo
	|-RuntimeType.ListBuilder<ConstructorInfo>.CopyTo
	|-RuntimeType.ListBuilder<EventInfo>.CopyTo
	|-RuntimeType.ListBuilder<FieldInfo>.CopyTo
	|-RuntimeType.ListBuilder<MethodInfo>.CopyTo
	|-RuntimeType.ListBuilder<PropertyInfo>.CopyTo
	|-RuntimeType.ListBuilder<Type>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CC80 Offset: 0x35CD81 VA: 0x35CC80
	|-RuntimeType.ListBuilder<object>.get_Count
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Count
	|-RuntimeType.ListBuilder<EventInfo>.get_Count
	|-RuntimeType.ListBuilder<FieldInfo>.get_Count
	|-RuntimeType.ListBuilder<MethodInfo>.get_Count
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Count
	|-RuntimeType.ListBuilder<Type>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CC90 Offset: 0x35CD91 VA: 0x35CC90
	|-RuntimeType.ListBuilder<object>.Add
	|-RuntimeType.ListBuilder<ConstructorInfo>.Add
	|-RuntimeType.ListBuilder<EventInfo>.Add
	|-RuntimeType.ListBuilder<FieldInfo>.Add
	|-RuntimeType.ListBuilder<MethodInfo>.Add
	|-RuntimeType.ListBuilder<PropertyInfo>.Add
	|-RuntimeType.ListBuilder<Type>.Add
	*/
}

