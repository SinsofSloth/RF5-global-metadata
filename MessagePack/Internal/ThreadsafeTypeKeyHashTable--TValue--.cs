internal class ThreadsafeTypeKeyHashTable<TValue> // TypeDefIndex: 5299
{
	// Fields
	private ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets; // 0x0
	private int size; // 0x0
	private readonly object writerLock; // 0x0
	private readonly float loadFactor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 4, float loadFactor = 0.75) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EEC0 Offset: 0x286EFC1 VA: 0x286EEC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>..ctor
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>..ctor
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>..ctor
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>..ctor
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>..ctor
	|-ThreadsafeTypeKeyHashTable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EFC0 Offset: 0x286F0C1 VA: 0x286EFC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryAdd
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryAdd
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0B0 Offset: 0x286F1B1 VA: 0x286F0B0
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(Type key, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0F0 Offset: 0x286F1F1 VA: 0x286F0F0
	|-ThreadsafeTypeKeyHashTable<object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1
	private bool AddToBuckets(ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets, Type newKey, ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F440 Offset: 0x286F541 VA: 0x286F440
	|-ThreadsafeTypeKeyHashTable<object>.AddToBuckets
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(Type key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F720 Offset: 0x286F821 VA: 0x286F720
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F820 Offset: 0x286F921 VA: 0x286F820
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>.GetOrAdd
	|-ThreadsafeTypeKeyHashTable<object>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8B0 Offset: 0x286F9B1 VA: 0x286F8B0
	|-ThreadsafeTypeKeyHashTable<object>.CalculateCapacity
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue> location, ThreadsafeTypeKeyHashTable.Entry<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8E0 Offset: 0x286F9E1 VA: 0x286F8E0
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue>[] location, ThreadsafeTypeKeyHashTable.Entry<TValue>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F910 Offset: 0x286FA11 VA: 0x286F910
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/
}

internal class ThreadsafeTypeKeyHashTable<TValue> // TypeDefIndex: 5299
{
	// Fields
	private ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets; // 0x0
	private int size; // 0x0
	private readonly object writerLock; // 0x0
	private readonly float loadFactor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 4, float loadFactor = 0.75) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EEC0 Offset: 0x286EFC1 VA: 0x286EEC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>..ctor
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>..ctor
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>..ctor
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>..ctor
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>..ctor
	|-ThreadsafeTypeKeyHashTable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EFC0 Offset: 0x286F0C1 VA: 0x286EFC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryAdd
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryAdd
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0B0 Offset: 0x286F1B1 VA: 0x286F0B0
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(Type key, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0F0 Offset: 0x286F1F1 VA: 0x286F0F0
	|-ThreadsafeTypeKeyHashTable<object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1
	private bool AddToBuckets(ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets, Type newKey, ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F440 Offset: 0x286F541 VA: 0x286F440
	|-ThreadsafeTypeKeyHashTable<object>.AddToBuckets
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(Type key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F720 Offset: 0x286F821 VA: 0x286F720
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F820 Offset: 0x286F921 VA: 0x286F820
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>.GetOrAdd
	|-ThreadsafeTypeKeyHashTable<object>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8B0 Offset: 0x286F9B1 VA: 0x286F8B0
	|-ThreadsafeTypeKeyHashTable<object>.CalculateCapacity
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue> location, ThreadsafeTypeKeyHashTable.Entry<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8E0 Offset: 0x286F9E1 VA: 0x286F8E0
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue>[] location, ThreadsafeTypeKeyHashTable.Entry<TValue>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F910 Offset: 0x286FA11 VA: 0x286F910
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/
}

internal class ThreadsafeTypeKeyHashTable<TValue> // TypeDefIndex: 5299
{
	// Fields
	private ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets; // 0x0
	private int size; // 0x0
	private readonly object writerLock; // 0x0
	private readonly float loadFactor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 4, float loadFactor = 0.75) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EEC0 Offset: 0x286EFC1 VA: 0x286EEC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>..ctor
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>..ctor
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>..ctor
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>..ctor
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>..ctor
	|-ThreadsafeTypeKeyHashTable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EFC0 Offset: 0x286F0C1 VA: 0x286EFC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryAdd
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryAdd
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0B0 Offset: 0x286F1B1 VA: 0x286F0B0
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(Type key, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0F0 Offset: 0x286F1F1 VA: 0x286F0F0
	|-ThreadsafeTypeKeyHashTable<object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1
	private bool AddToBuckets(ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets, Type newKey, ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F440 Offset: 0x286F541 VA: 0x286F440
	|-ThreadsafeTypeKeyHashTable<object>.AddToBuckets
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(Type key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F720 Offset: 0x286F821 VA: 0x286F720
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F820 Offset: 0x286F921 VA: 0x286F820
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>.GetOrAdd
	|-ThreadsafeTypeKeyHashTable<object>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8B0 Offset: 0x286F9B1 VA: 0x286F8B0
	|-ThreadsafeTypeKeyHashTable<object>.CalculateCapacity
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue> location, ThreadsafeTypeKeyHashTable.Entry<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8E0 Offset: 0x286F9E1 VA: 0x286F8E0
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue>[] location, ThreadsafeTypeKeyHashTable.Entry<TValue>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F910 Offset: 0x286FA11 VA: 0x286F910
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/
}

internal class ThreadsafeTypeKeyHashTable<TValue> // TypeDefIndex: 5299
{
	// Fields
	private ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets; // 0x0
	private int size; // 0x0
	private readonly object writerLock; // 0x0
	private readonly float loadFactor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 4, float loadFactor = 0.75) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EEC0 Offset: 0x286EFC1 VA: 0x286EEC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>..ctor
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>..ctor
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>..ctor
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>..ctor
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>..ctor
	|-ThreadsafeTypeKeyHashTable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EFC0 Offset: 0x286F0C1 VA: 0x286EFC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryAdd
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryAdd
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0B0 Offset: 0x286F1B1 VA: 0x286F0B0
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(Type key, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0F0 Offset: 0x286F1F1 VA: 0x286F0F0
	|-ThreadsafeTypeKeyHashTable<object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1
	private bool AddToBuckets(ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets, Type newKey, ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F440 Offset: 0x286F541 VA: 0x286F440
	|-ThreadsafeTypeKeyHashTable<object>.AddToBuckets
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(Type key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F720 Offset: 0x286F821 VA: 0x286F720
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F820 Offset: 0x286F921 VA: 0x286F820
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>.GetOrAdd
	|-ThreadsafeTypeKeyHashTable<object>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8B0 Offset: 0x286F9B1 VA: 0x286F8B0
	|-ThreadsafeTypeKeyHashTable<object>.CalculateCapacity
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue> location, ThreadsafeTypeKeyHashTable.Entry<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8E0 Offset: 0x286F9E1 VA: 0x286F8E0
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue>[] location, ThreadsafeTypeKeyHashTable.Entry<TValue>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F910 Offset: 0x286FA11 VA: 0x286F910
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/
}

internal class ThreadsafeTypeKeyHashTable<TValue> // TypeDefIndex: 5299
{
	// Fields
	private ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets; // 0x0
	private int size; // 0x0
	private readonly object writerLock; // 0x0
	private readonly float loadFactor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 4, float loadFactor = 0.75) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EEC0 Offset: 0x286EFC1 VA: 0x286EEC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>..ctor
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>..ctor
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>..ctor
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>..ctor
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>..ctor
	|-ThreadsafeTypeKeyHashTable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286EFC0 Offset: 0x286F0C1 VA: 0x286EFC0
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryAdd
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryAdd
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryAdd
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0B0 Offset: 0x286F1B1 VA: 0x286F0B0
	|-ThreadsafeTypeKeyHashTable<object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(Type key, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F0F0 Offset: 0x286F1F1 VA: 0x286F0F0
	|-ThreadsafeTypeKeyHashTable<object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1
	private bool AddToBuckets(ThreadsafeTypeKeyHashTable.Entry<TValue>[] buckets, Type newKey, ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, Func<Type, TValue> valueFactory, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F440 Offset: 0x286F541 VA: 0x286F440
	|-ThreadsafeTypeKeyHashTable<object>.AddToBuckets
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(Type key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F720 Offset: 0x286F821 VA: 0x286F720
	|-ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IMessagePackFormatter>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<IEqualityComparer>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<Func<IFormatterResolver, IMessagePackFormatter>>.TryGetValue
	|-ThreadsafeTypeKeyHashTable<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(Type key, Func<Type, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F820 Offset: 0x286F921 VA: 0x286F820
	|-ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods>.GetOrAdd
	|-ThreadsafeTypeKeyHashTable<object>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8B0 Offset: 0x286F9B1 VA: 0x286F8B0
	|-ThreadsafeTypeKeyHashTable<object>.CalculateCapacity
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue> location, ThreadsafeTypeKeyHashTable.Entry<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F8E0 Offset: 0x286F9E1 VA: 0x286F8E0
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/

	// RVA: -1 Offset: -1
	private static void VolatileWrite(ref ThreadsafeTypeKeyHashTable.Entry<TValue>[] location, ThreadsafeTypeKeyHashTable.Entry<TValue>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286F910 Offset: 0x286FA11 VA: 0x286F910
	|-ThreadsafeTypeKeyHashTable<object>.VolatileWrite
	*/
}

