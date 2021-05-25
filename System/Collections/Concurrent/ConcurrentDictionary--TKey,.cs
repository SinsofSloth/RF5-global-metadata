[DebuggerTypeProxyAttribute] // RVA: 0xB3540 Offset: 0xB3641 VA: 0xB3540
[DebuggerDisplayAttribute] // RVA: 0xB3540 Offset: 0xB3641 VA: 0xB3540
[DefaultMemberAttribute] // RVA: 0xB3540 Offset: 0xB3641 VA: 0xB3540
[Serializable]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1400
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public ICollection<TKey> Keys { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55880 Offset: 0x2B55981 VA: 0x2B55880
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B559B0 Offset: 0x2B55AB1 VA: 0x2B559B0
	|-ConcurrentDictionary<object, object>..ctor
	|-ConcurrentDictionary<MemberHolder, MemberInfo[]>..ctor
	|-ConcurrentDictionary<string, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55A90 Offset: 0x2B55B91 VA: 0x2B55A90
	|-ConcurrentDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55B70 Offset: 0x2B55C71 VA: 0x2B55B70
	|-ConcurrentDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55E30 Offset: 0x2B55F31 VA: 0x2B55E30
	|-ConcurrentDictionary<object, object>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55FC0 Offset: 0x2B560C1 VA: 0x2B55FC0
	|-ConcurrentDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B560B0 Offset: 0x2B561B1 VA: 0x2B560B0
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B56690 Offset: 0x2B56791 VA: 0x2B56690
	|-ConcurrentDictionary<object, object>.TryGetValue
	|-ConcurrentDictionary<string, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B56800 Offset: 0x2B56901 VA: 0x2B56800
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B569F0 Offset: 0x2B56AF1 VA: 0x2B569F0
	|-ConcurrentDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B56C80 Offset: 0x2B56D81 VA: 0x2B56C80
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B56F50 Offset: 0x2B57051 VA: 0x2B56F50
	|-ConcurrentDictionary<object, object>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57060 Offset: 0x2B57161 VA: 0x2B57060
	|-ConcurrentDictionary<object, object>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57160 Offset: 0x2B57261 VA: 0x2B57160
	|-ConcurrentDictionary<object, object>.CopyToObjects
	*/

	[IteratorStateMachineAttribute] // RVA: 0xB9AD0 Offset: 0xB9BD1 VA: 0xB9AD0
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57300 Offset: 0x2B57401 VA: 0x2B57300
	|-ConcurrentDictionary<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57390 Offset: 0x2B57491 VA: 0x2B57390
	|-ConcurrentDictionary<object, object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57BB0 Offset: 0x2B57CB1 VA: 0x2B57BB0
	|-ConcurrentDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57C80 Offset: 0x2B57D81 VA: 0x2B57C80
	|-ConcurrentDictionary<object, object>.set_Item
	|-ConcurrentDictionary<string, object>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNotFoundException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57E10 Offset: 0x2B57F11 VA: 0x2B57E10
	|-ConcurrentDictionary<object, object>.ThrowKeyNotFoundException
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57E70 Offset: 0x2B57F71 VA: 0x2B57E70
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57EE0 Offset: 0x2B57FE1 VA: 0x2B57EE0
	|-ConcurrentDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B57FC0 Offset: 0x2B580C1 VA: 0x2B57FC0
	|-ConcurrentDictionary<object, object>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58070 Offset: 0x2B58171 VA: 0x2B58070
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|-ConcurrentDictionary<MemberHolder, MemberInfo[]>.GetOrAdd
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B582C0 Offset: 0x2B583C1 VA: 0x2B582C0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58390 Offset: 0x2B58491 VA: 0x2B58390
	|-ConcurrentDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B583C0 Offset: 0x2B584C1 VA: 0x2B583C0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58480 Offset: 0x2B58581 VA: 0x2B58480
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58510 Offset: 0x2B58611 VA: 0x2B58510
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58520 Offset: 0x2B58621 VA: 0x2B58520
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58600 Offset: 0x2B58701 VA: 0x2B58600
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58630 Offset: 0x2B58731 VA: 0x2B58630
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58940 Offset: 0x2B58A41 VA: 0x2B58940
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58AB0 Offset: 0x2B58BB1 VA: 0x2B58AB0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58B20 Offset: 0x2B58C21 VA: 0x2B58B20
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58B50 Offset: 0x2B58C51 VA: 0x2B58B50
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58CB0 Offset: 0x2B58DB1 VA: 0x2B58CB0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B58F00 Offset: 0x2B59001 VA: 0x2B58F00
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59300 Offset: 0x2B59401 VA: 0x2B59300
	|-ConcurrentDictionary<object, object>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59B90 Offset: 0x2B59C91 VA: 0x2B59B90
	|-ConcurrentDictionary<object, object>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59BA0 Offset: 0x2B59CA1 VA: 0x2B59BA0
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59BC0 Offset: 0x2B59CC1 VA: 0x2B59BC0
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59BD0 Offset: 0x2B59CD1 VA: 0x2B59BD0
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59D20 Offset: 0x2B59E21 VA: 0x2B59D20
	|-ConcurrentDictionary<object, object>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59EA0 Offset: 0x2B59FA1 VA: 0x2B59EA0
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TKey> GetKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B59F20 Offset: 0x2B5A021 VA: 0x2B59F20
	|-ConcurrentDictionary<object, object>.GetKeys
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A290 Offset: 0x2B5A391 VA: 0x2B5A290
	|-ConcurrentDictionary<object, object>..cctor
	*/
}

