[DebuggerTypeProxyAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DefaultMemberAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[ComVisibleAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DebuggerDisplayAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1357
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1860820 Offset: 0x1860921 VA: 0x1860820
	internal void .ctor(bool trash) { }

	// RVA: 0x18567E0 Offset: 0x18568E1 VA: 0x18567E0
	public void .ctor() { }

	// RVA: 0x1860AD0 Offset: 0x1860BD1 VA: 0x1860AD0
	public void .ctor(int capacity) { }

	// RVA: 0x1860830 Offset: 0x1860931 VA: 0x1860830
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xB9970 Offset: 0xB9A71 VA: 0xB9970
	// RVA: 0x1860AE0 Offset: 0x1860BE1 VA: 0x1860AE0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860BC0 Offset: 0x1860CC1 VA: 0x1860BC0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xB99B0 Offset: 0xB9AB1 VA: 0xB99B0
	// RVA: 0x1860BF0 Offset: 0x1860CF1 VA: 0x1860BF0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860C10 Offset: 0x1860D11 VA: 0x1860C10
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1860CC0 Offset: 0x1860DC1 VA: 0x1860CC0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1860D00 Offset: 0x1860E01 VA: 0x1860D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1860DA0 Offset: 0x1860EA1 VA: 0x1860DA0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1860E00 Offset: 0x1860F01 VA: 0x1860E00 Slot: 16
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0xB99F0 Offset: 0xB9AF1 VA: 0xB99F0
	// RVA: 0x1861330 Offset: 0x1861431 VA: 0x1861330 Slot: 17
	public virtual void Clear() { }

	// RVA: 0x1861480 Offset: 0x1861581 VA: 0x1861480 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x18615C0 Offset: 0x18616C1 VA: 0x18615C0 Slot: 19
	public virtual bool Contains(object key) { }

	// RVA: 0x18615D0 Offset: 0x18616D1 VA: 0x18615D0 Slot: 20
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1861770 Offset: 0x1861871 VA: 0x1861770
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1861860 Offset: 0x1861961 VA: 0x1861860
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1861A20 Offset: 0x1861B21 VA: 0x1861A20 Slot: 21
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1861BE0 Offset: 0x1861CE1 VA: 0x1861BE0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1861CE0 Offset: 0x1861DE1 VA: 0x1861CE0 Slot: 22
	public virtual object get_Item(object key) { }

	// RVA: 0x1861F30 Offset: 0x1862031 VA: 0x1861F30 Slot: 23
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1861F40 Offset: 0x1862041 VA: 0x1861F40
	private void expand() { }

	// RVA: 0x1862220 Offset: 0x1862321 VA: 0x1862220
	private void rehash() { }

	// RVA: 0x1861450 Offset: 0x1861551 VA: 0x1861450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A10 Offset: 0xB9B11 VA: 0xB9A10
	// RVA: 0x1862050 Offset: 0x1862151 VA: 0x1862050
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1862360 Offset: 0x1862461 VA: 0x1862360 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18623D0 Offset: 0x18624D1 VA: 0x18623D0 Slot: 24
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1862440 Offset: 0x1862541 VA: 0x1862440 Slot: 25
	protected virtual int GetHash(object key) { }

	// RVA: 0x1862530 Offset: 0x1862631 VA: 0x1862530 Slot: 26
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1862660 Offset: 0x1862761 VA: 0x1862660 Slot: 27
	public virtual ICollection get_Keys() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A30 Offset: 0xB9B31 VA: 0xB9A30
	// RVA: 0x1860E10 Offset: 0x1860F11 VA: 0x1860E10
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1862240 Offset: 0x1862341 VA: 0x1862240
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A50 Offset: 0xB9B51 VA: 0xB9A50
	// RVA: 0x1862710 Offset: 0x1862811 VA: 0x1862710 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x1862990 Offset: 0x1862A91 VA: 0x1862990 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x1862A20 Offset: 0x1862B21 VA: 0x1862A20 Slot: 30
	public virtual int get_Count() { }

	// RVA: 0x1862A30 Offset: 0x1862B31 VA: 0x1862A30
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1862AD0 Offset: 0x1862BD1 VA: 0x1862AD0 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863050 Offset: 0x1863151 VA: 0x1863050 Slot: 32
	public virtual void OnDeserialization(object sender) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DefaultMemberAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[ComVisibleAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DebuggerDisplayAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1357
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1860820 Offset: 0x1860921 VA: 0x1860820
	internal void .ctor(bool trash) { }

	// RVA: 0x18567E0 Offset: 0x18568E1 VA: 0x18567E0
	public void .ctor() { }

	// RVA: 0x1860AD0 Offset: 0x1860BD1 VA: 0x1860AD0
	public void .ctor(int capacity) { }

	// RVA: 0x1860830 Offset: 0x1860931 VA: 0x1860830
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xB9970 Offset: 0xB9A71 VA: 0xB9970
	// RVA: 0x1860AE0 Offset: 0x1860BE1 VA: 0x1860AE0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860BC0 Offset: 0x1860CC1 VA: 0x1860BC0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xB99B0 Offset: 0xB9AB1 VA: 0xB99B0
	// RVA: 0x1860BF0 Offset: 0x1860CF1 VA: 0x1860BF0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860C10 Offset: 0x1860D11 VA: 0x1860C10
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1860CC0 Offset: 0x1860DC1 VA: 0x1860CC0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1860D00 Offset: 0x1860E01 VA: 0x1860D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1860DA0 Offset: 0x1860EA1 VA: 0x1860DA0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1860E00 Offset: 0x1860F01 VA: 0x1860E00 Slot: 16
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0xB99F0 Offset: 0xB9AF1 VA: 0xB99F0
	// RVA: 0x1861330 Offset: 0x1861431 VA: 0x1861330 Slot: 17
	public virtual void Clear() { }

	// RVA: 0x1861480 Offset: 0x1861581 VA: 0x1861480 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x18615C0 Offset: 0x18616C1 VA: 0x18615C0 Slot: 19
	public virtual bool Contains(object key) { }

	// RVA: 0x18615D0 Offset: 0x18616D1 VA: 0x18615D0 Slot: 20
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1861770 Offset: 0x1861871 VA: 0x1861770
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1861860 Offset: 0x1861961 VA: 0x1861860
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1861A20 Offset: 0x1861B21 VA: 0x1861A20 Slot: 21
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1861BE0 Offset: 0x1861CE1 VA: 0x1861BE0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1861CE0 Offset: 0x1861DE1 VA: 0x1861CE0 Slot: 22
	public virtual object get_Item(object key) { }

	// RVA: 0x1861F30 Offset: 0x1862031 VA: 0x1861F30 Slot: 23
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1861F40 Offset: 0x1862041 VA: 0x1861F40
	private void expand() { }

	// RVA: 0x1862220 Offset: 0x1862321 VA: 0x1862220
	private void rehash() { }

	// RVA: 0x1861450 Offset: 0x1861551 VA: 0x1861450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A10 Offset: 0xB9B11 VA: 0xB9A10
	// RVA: 0x1862050 Offset: 0x1862151 VA: 0x1862050
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1862360 Offset: 0x1862461 VA: 0x1862360 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18623D0 Offset: 0x18624D1 VA: 0x18623D0 Slot: 24
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1862440 Offset: 0x1862541 VA: 0x1862440 Slot: 25
	protected virtual int GetHash(object key) { }

	// RVA: 0x1862530 Offset: 0x1862631 VA: 0x1862530 Slot: 26
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1862660 Offset: 0x1862761 VA: 0x1862660 Slot: 27
	public virtual ICollection get_Keys() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A30 Offset: 0xB9B31 VA: 0xB9A30
	// RVA: 0x1860E10 Offset: 0x1860F11 VA: 0x1860E10
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1862240 Offset: 0x1862341 VA: 0x1862240
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A50 Offset: 0xB9B51 VA: 0xB9A50
	// RVA: 0x1862710 Offset: 0x1862811 VA: 0x1862710 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x1862990 Offset: 0x1862A91 VA: 0x1862990 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x1862A20 Offset: 0x1862B21 VA: 0x1862A20 Slot: 30
	public virtual int get_Count() { }

	// RVA: 0x1862A30 Offset: 0x1862B31 VA: 0x1862A30
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1862AD0 Offset: 0x1862BD1 VA: 0x1862AD0 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863050 Offset: 0x1863151 VA: 0x1863050 Slot: 32
	public virtual void OnDeserialization(object sender) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DefaultMemberAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[ComVisibleAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DebuggerDisplayAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1357
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1860820 Offset: 0x1860921 VA: 0x1860820
	internal void .ctor(bool trash) { }

	// RVA: 0x18567E0 Offset: 0x18568E1 VA: 0x18567E0
	public void .ctor() { }

	// RVA: 0x1860AD0 Offset: 0x1860BD1 VA: 0x1860AD0
	public void .ctor(int capacity) { }

	// RVA: 0x1860830 Offset: 0x1860931 VA: 0x1860830
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xB9970 Offset: 0xB9A71 VA: 0xB9970
	// RVA: 0x1860AE0 Offset: 0x1860BE1 VA: 0x1860AE0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860BC0 Offset: 0x1860CC1 VA: 0x1860BC0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xB99B0 Offset: 0xB9AB1 VA: 0xB99B0
	// RVA: 0x1860BF0 Offset: 0x1860CF1 VA: 0x1860BF0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860C10 Offset: 0x1860D11 VA: 0x1860C10
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1860CC0 Offset: 0x1860DC1 VA: 0x1860CC0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1860D00 Offset: 0x1860E01 VA: 0x1860D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1860DA0 Offset: 0x1860EA1 VA: 0x1860DA0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1860E00 Offset: 0x1860F01 VA: 0x1860E00 Slot: 16
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0xB99F0 Offset: 0xB9AF1 VA: 0xB99F0
	// RVA: 0x1861330 Offset: 0x1861431 VA: 0x1861330 Slot: 17
	public virtual void Clear() { }

	// RVA: 0x1861480 Offset: 0x1861581 VA: 0x1861480 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x18615C0 Offset: 0x18616C1 VA: 0x18615C0 Slot: 19
	public virtual bool Contains(object key) { }

	// RVA: 0x18615D0 Offset: 0x18616D1 VA: 0x18615D0 Slot: 20
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1861770 Offset: 0x1861871 VA: 0x1861770
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1861860 Offset: 0x1861961 VA: 0x1861860
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1861A20 Offset: 0x1861B21 VA: 0x1861A20 Slot: 21
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1861BE0 Offset: 0x1861CE1 VA: 0x1861BE0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1861CE0 Offset: 0x1861DE1 VA: 0x1861CE0 Slot: 22
	public virtual object get_Item(object key) { }

	// RVA: 0x1861F30 Offset: 0x1862031 VA: 0x1861F30 Slot: 23
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1861F40 Offset: 0x1862041 VA: 0x1861F40
	private void expand() { }

	// RVA: 0x1862220 Offset: 0x1862321 VA: 0x1862220
	private void rehash() { }

	// RVA: 0x1861450 Offset: 0x1861551 VA: 0x1861450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A10 Offset: 0xB9B11 VA: 0xB9A10
	// RVA: 0x1862050 Offset: 0x1862151 VA: 0x1862050
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1862360 Offset: 0x1862461 VA: 0x1862360 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18623D0 Offset: 0x18624D1 VA: 0x18623D0 Slot: 24
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1862440 Offset: 0x1862541 VA: 0x1862440 Slot: 25
	protected virtual int GetHash(object key) { }

	// RVA: 0x1862530 Offset: 0x1862631 VA: 0x1862530 Slot: 26
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1862660 Offset: 0x1862761 VA: 0x1862660 Slot: 27
	public virtual ICollection get_Keys() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A30 Offset: 0xB9B31 VA: 0xB9A30
	// RVA: 0x1860E10 Offset: 0x1860F11 VA: 0x1860E10
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1862240 Offset: 0x1862341 VA: 0x1862240
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A50 Offset: 0xB9B51 VA: 0xB9A50
	// RVA: 0x1862710 Offset: 0x1862811 VA: 0x1862710 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x1862990 Offset: 0x1862A91 VA: 0x1862990 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x1862A20 Offset: 0x1862B21 VA: 0x1862A20 Slot: 30
	public virtual int get_Count() { }

	// RVA: 0x1862A30 Offset: 0x1862B31 VA: 0x1862A30
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1862AD0 Offset: 0x1862BD1 VA: 0x1862AD0 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863050 Offset: 0x1863151 VA: 0x1863050 Slot: 32
	public virtual void OnDeserialization(object sender) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DefaultMemberAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[ComVisibleAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DebuggerDisplayAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1357
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1860820 Offset: 0x1860921 VA: 0x1860820
	internal void .ctor(bool trash) { }

	// RVA: 0x18567E0 Offset: 0x18568E1 VA: 0x18567E0
	public void .ctor() { }

	// RVA: 0x1860AD0 Offset: 0x1860BD1 VA: 0x1860AD0
	public void .ctor(int capacity) { }

	// RVA: 0x1860830 Offset: 0x1860931 VA: 0x1860830
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xB9970 Offset: 0xB9A71 VA: 0xB9970
	// RVA: 0x1860AE0 Offset: 0x1860BE1 VA: 0x1860AE0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860BC0 Offset: 0x1860CC1 VA: 0x1860BC0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xB99B0 Offset: 0xB9AB1 VA: 0xB99B0
	// RVA: 0x1860BF0 Offset: 0x1860CF1 VA: 0x1860BF0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860C10 Offset: 0x1860D11 VA: 0x1860C10
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1860CC0 Offset: 0x1860DC1 VA: 0x1860CC0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1860D00 Offset: 0x1860E01 VA: 0x1860D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1860DA0 Offset: 0x1860EA1 VA: 0x1860DA0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1860E00 Offset: 0x1860F01 VA: 0x1860E00 Slot: 16
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0xB99F0 Offset: 0xB9AF1 VA: 0xB99F0
	// RVA: 0x1861330 Offset: 0x1861431 VA: 0x1861330 Slot: 17
	public virtual void Clear() { }

	// RVA: 0x1861480 Offset: 0x1861581 VA: 0x1861480 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x18615C0 Offset: 0x18616C1 VA: 0x18615C0 Slot: 19
	public virtual bool Contains(object key) { }

	// RVA: 0x18615D0 Offset: 0x18616D1 VA: 0x18615D0 Slot: 20
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1861770 Offset: 0x1861871 VA: 0x1861770
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1861860 Offset: 0x1861961 VA: 0x1861860
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1861A20 Offset: 0x1861B21 VA: 0x1861A20 Slot: 21
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1861BE0 Offset: 0x1861CE1 VA: 0x1861BE0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1861CE0 Offset: 0x1861DE1 VA: 0x1861CE0 Slot: 22
	public virtual object get_Item(object key) { }

	// RVA: 0x1861F30 Offset: 0x1862031 VA: 0x1861F30 Slot: 23
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1861F40 Offset: 0x1862041 VA: 0x1861F40
	private void expand() { }

	// RVA: 0x1862220 Offset: 0x1862321 VA: 0x1862220
	private void rehash() { }

	// RVA: 0x1861450 Offset: 0x1861551 VA: 0x1861450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A10 Offset: 0xB9B11 VA: 0xB9A10
	// RVA: 0x1862050 Offset: 0x1862151 VA: 0x1862050
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1862360 Offset: 0x1862461 VA: 0x1862360 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18623D0 Offset: 0x18624D1 VA: 0x18623D0 Slot: 24
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1862440 Offset: 0x1862541 VA: 0x1862440 Slot: 25
	protected virtual int GetHash(object key) { }

	// RVA: 0x1862530 Offset: 0x1862631 VA: 0x1862530 Slot: 26
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1862660 Offset: 0x1862761 VA: 0x1862660 Slot: 27
	public virtual ICollection get_Keys() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A30 Offset: 0xB9B31 VA: 0xB9A30
	// RVA: 0x1860E10 Offset: 0x1860F11 VA: 0x1860E10
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1862240 Offset: 0x1862341 VA: 0x1862240
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A50 Offset: 0xB9B51 VA: 0xB9A50
	// RVA: 0x1862710 Offset: 0x1862811 VA: 0x1862710 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x1862990 Offset: 0x1862A91 VA: 0x1862990 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x1862A20 Offset: 0x1862B21 VA: 0x1862A20 Slot: 30
	public virtual int get_Count() { }

	// RVA: 0x1862A30 Offset: 0x1862B31 VA: 0x1862A30
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1862AD0 Offset: 0x1862BD1 VA: 0x1862AD0 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863050 Offset: 0x1863151 VA: 0x1863050 Slot: 32
	public virtual void OnDeserialization(object sender) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DefaultMemberAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[ComVisibleAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DebuggerDisplayAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1357
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1860820 Offset: 0x1860921 VA: 0x1860820
	internal void .ctor(bool trash) { }

	// RVA: 0x18567E0 Offset: 0x18568E1 VA: 0x18567E0
	public void .ctor() { }

	// RVA: 0x1860AD0 Offset: 0x1860BD1 VA: 0x1860AD0
	public void .ctor(int capacity) { }

	// RVA: 0x1860830 Offset: 0x1860931 VA: 0x1860830
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xB9970 Offset: 0xB9A71 VA: 0xB9970
	// RVA: 0x1860AE0 Offset: 0x1860BE1 VA: 0x1860AE0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860BC0 Offset: 0x1860CC1 VA: 0x1860BC0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xB99B0 Offset: 0xB9AB1 VA: 0xB99B0
	// RVA: 0x1860BF0 Offset: 0x1860CF1 VA: 0x1860BF0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860C10 Offset: 0x1860D11 VA: 0x1860C10
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1860CC0 Offset: 0x1860DC1 VA: 0x1860CC0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1860D00 Offset: 0x1860E01 VA: 0x1860D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1860DA0 Offset: 0x1860EA1 VA: 0x1860DA0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1860E00 Offset: 0x1860F01 VA: 0x1860E00 Slot: 16
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0xB99F0 Offset: 0xB9AF1 VA: 0xB99F0
	// RVA: 0x1861330 Offset: 0x1861431 VA: 0x1861330 Slot: 17
	public virtual void Clear() { }

	// RVA: 0x1861480 Offset: 0x1861581 VA: 0x1861480 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x18615C0 Offset: 0x18616C1 VA: 0x18615C0 Slot: 19
	public virtual bool Contains(object key) { }

	// RVA: 0x18615D0 Offset: 0x18616D1 VA: 0x18615D0 Slot: 20
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1861770 Offset: 0x1861871 VA: 0x1861770
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1861860 Offset: 0x1861961 VA: 0x1861860
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1861A20 Offset: 0x1861B21 VA: 0x1861A20 Slot: 21
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1861BE0 Offset: 0x1861CE1 VA: 0x1861BE0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1861CE0 Offset: 0x1861DE1 VA: 0x1861CE0 Slot: 22
	public virtual object get_Item(object key) { }

	// RVA: 0x1861F30 Offset: 0x1862031 VA: 0x1861F30 Slot: 23
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1861F40 Offset: 0x1862041 VA: 0x1861F40
	private void expand() { }

	// RVA: 0x1862220 Offset: 0x1862321 VA: 0x1862220
	private void rehash() { }

	// RVA: 0x1861450 Offset: 0x1861551 VA: 0x1861450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A10 Offset: 0xB9B11 VA: 0xB9A10
	// RVA: 0x1862050 Offset: 0x1862151 VA: 0x1862050
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1862360 Offset: 0x1862461 VA: 0x1862360 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18623D0 Offset: 0x18624D1 VA: 0x18623D0 Slot: 24
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1862440 Offset: 0x1862541 VA: 0x1862440 Slot: 25
	protected virtual int GetHash(object key) { }

	// RVA: 0x1862530 Offset: 0x1862631 VA: 0x1862530 Slot: 26
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1862660 Offset: 0x1862761 VA: 0x1862660 Slot: 27
	public virtual ICollection get_Keys() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A30 Offset: 0xB9B31 VA: 0xB9A30
	// RVA: 0x1860E10 Offset: 0x1860F11 VA: 0x1860E10
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1862240 Offset: 0x1862341 VA: 0x1862240
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A50 Offset: 0xB9B51 VA: 0xB9A50
	// RVA: 0x1862710 Offset: 0x1862811 VA: 0x1862710 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x1862990 Offset: 0x1862A91 VA: 0x1862990 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x1862A20 Offset: 0x1862B21 VA: 0x1862A20 Slot: 30
	public virtual int get_Count() { }

	// RVA: 0x1862A30 Offset: 0x1862B31 VA: 0x1862A30
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1862AD0 Offset: 0x1862BD1 VA: 0x1862AD0 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863050 Offset: 0x1863151 VA: 0x1863050 Slot: 32
	public virtual void OnDeserialization(object sender) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DefaultMemberAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[ComVisibleAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[DebuggerDisplayAttribute] // RVA: 0xB2BD0 Offset: 0xB2CD1 VA: 0xB2BD0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1357
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1860820 Offset: 0x1860921 VA: 0x1860820
	internal void .ctor(bool trash) { }

	// RVA: 0x18567E0 Offset: 0x18568E1 VA: 0x18567E0
	public void .ctor() { }

	// RVA: 0x1860AD0 Offset: 0x1860BD1 VA: 0x1860AD0
	public void .ctor(int capacity) { }

	// RVA: 0x1860830 Offset: 0x1860931 VA: 0x1860830
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0xB9970 Offset: 0xB9A71 VA: 0xB9970
	// RVA: 0x1860AE0 Offset: 0x1860BE1 VA: 0x1860AE0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860BC0 Offset: 0x1860CC1 VA: 0x1860BC0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0xB99B0 Offset: 0xB9AB1 VA: 0xB99B0
	// RVA: 0x1860BF0 Offset: 0x1860CF1 VA: 0x1860BF0
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1860C10 Offset: 0x1860D11 VA: 0x1860C10
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1860CC0 Offset: 0x1860DC1 VA: 0x1860CC0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1860D00 Offset: 0x1860E01 VA: 0x1860D00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1860DA0 Offset: 0x1860EA1 VA: 0x1860DA0
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1860E00 Offset: 0x1860F01 VA: 0x1860E00 Slot: 16
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0xB99F0 Offset: 0xB9AF1 VA: 0xB99F0
	// RVA: 0x1861330 Offset: 0x1861431 VA: 0x1861330 Slot: 17
	public virtual void Clear() { }

	// RVA: 0x1861480 Offset: 0x1861581 VA: 0x1861480 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x18615C0 Offset: 0x18616C1 VA: 0x18615C0 Slot: 19
	public virtual bool Contains(object key) { }

	// RVA: 0x18615D0 Offset: 0x18616D1 VA: 0x18615D0 Slot: 20
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1861770 Offset: 0x1861871 VA: 0x1861770
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1861860 Offset: 0x1861961 VA: 0x1861860
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1861A20 Offset: 0x1861B21 VA: 0x1861A20 Slot: 21
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1861BE0 Offset: 0x1861CE1 VA: 0x1861BE0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1861CE0 Offset: 0x1861DE1 VA: 0x1861CE0 Slot: 22
	public virtual object get_Item(object key) { }

	// RVA: 0x1861F30 Offset: 0x1862031 VA: 0x1861F30 Slot: 23
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1861F40 Offset: 0x1862041 VA: 0x1861F40
	private void expand() { }

	// RVA: 0x1862220 Offset: 0x1862321 VA: 0x1862220
	private void rehash() { }

	// RVA: 0x1861450 Offset: 0x1861551 VA: 0x1861450
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A10 Offset: 0xB9B11 VA: 0xB9A10
	// RVA: 0x1862050 Offset: 0x1862151 VA: 0x1862050
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x1862360 Offset: 0x1862461 VA: 0x1862360 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18623D0 Offset: 0x18624D1 VA: 0x18623D0 Slot: 24
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1862440 Offset: 0x1862541 VA: 0x1862440 Slot: 25
	protected virtual int GetHash(object key) { }

	// RVA: 0x1862530 Offset: 0x1862631 VA: 0x1862530 Slot: 26
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1862660 Offset: 0x1862761 VA: 0x1862660 Slot: 27
	public virtual ICollection get_Keys() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A30 Offset: 0xB9B31 VA: 0xB9A30
	// RVA: 0x1860E10 Offset: 0x1860F11 VA: 0x1860E10
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1862240 Offset: 0x1862341 VA: 0x1862240
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A50 Offset: 0xB9B51 VA: 0xB9A50
	// RVA: 0x1862710 Offset: 0x1862811 VA: 0x1862710 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x1862990 Offset: 0x1862A91 VA: 0x1862990 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x1862A20 Offset: 0x1862B21 VA: 0x1862A20 Slot: 30
	public virtual int get_Count() { }

	// RVA: 0x1862A30 Offset: 0x1862B31 VA: 0x1862A30
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1862AD0 Offset: 0x1862BD1 VA: 0x1862AD0 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863050 Offset: 0x1863151 VA: 0x1863050 Slot: 32
	public virtual void OnDeserialization(object sender) { }
}

