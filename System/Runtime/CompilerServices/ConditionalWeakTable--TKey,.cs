public sealed class ConditionalWeakTable<TKey, TValue> // TypeDefIndex: 1288
{
	// Fields
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EAFF0 Offset: 0x26EB0F1 VA: 0x26EAFF0
	|-ConditionalWeakTable<HttpWebRequest, NtlmSession>..ctor
	|-ConditionalWeakTable<object, object>..ctor
	|-ConditionalWeakTable<object, SerializationInfo>..ctor
	|-ConditionalWeakTable<object, OSSpecificSynchronizationContext>..ctor
	|-ConditionalWeakTable<TaskScheduler, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EB0C0 Offset: 0x26EB1C1 VA: 0x26EB0C0
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EB0E0 Offset: 0x26EB1E1 VA: 0x26EB0E0
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EB330 Offset: 0x26EB431 VA: 0x26EB330
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EB3B0 Offset: 0x26EB4B1 VA: 0x26EB3B0
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EB710 Offset: 0x26EB811 VA: 0x26EB710
	|-ConditionalWeakTable<object, object>.Add
	|-ConditionalWeakTable<object, SerializationInfo>.Add
	|-ConditionalWeakTable<TaskScheduler, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EBAC0 Offset: 0x26EBBC1 VA: 0x26EBAC0
	|-ConditionalWeakTable<object, object>.Remove
	|-ConditionalWeakTable<object, SerializationInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EBDA0 Offset: 0x26EBEA1 VA: 0x26EBDA0
	|-ConditionalWeakTable<Expression, Expression.ExtensionInfo>.TryGetValue
	|-ConditionalWeakTable<object, object>.TryGetValue
	|-ConditionalWeakTable<object, SerializationInfo>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EC070 Offset: 0x26EC171 VA: 0x26EC070
	|-ConditionalWeakTable<HttpWebRequest, NtlmSession>.GetValue
	|-ConditionalWeakTable<object, object>.GetValue
	|-ConditionalWeakTable<object, OSSpecificSynchronizationContext>.GetValue
	*/
}

