[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2058
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x28E30E0 Offset: 0x28E31E1 VA: 0x28E30E0
	protected void .ctor() { }

	// RVA: 0x28E3150 Offset: 0x28E3251 VA: 0x28E3150
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x28E32F0 Offset: 0x28E33F1 VA: 0x28E32F0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x28E3400 Offset: 0x28E3501 VA: 0x28E3400
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x28E3410 Offset: 0x28E3511 VA: 0x28E3410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3450 Offset: 0x28E3551 VA: 0x28E3450 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x28E3A10 Offset: 0x28E3B11 VA: 0x28E3A10 Slot: 10
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x28E3220 Offset: 0x28E3321 VA: 0x28E3220
	private void Reset() { }

	// RVA: 0x28E3320 Offset: 0x28E3421 VA: 0x28E3320
	private void Reset(int capacity) { }

	// RVA: 0x28E42E0 Offset: 0x28E43E1 VA: 0x28E42E0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x28E43B0 Offset: 0x28E44B1 VA: 0x28E43B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x28E4150 Offset: 0x28E4251 VA: 0x28E4150
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x28E4410 Offset: 0x28E4511 VA: 0x28E4410
	protected void BaseRemove(string name) { }

	// RVA: 0x28E47E0 Offset: 0x28E48E1 VA: 0x28E47E0
	protected object BaseGet(string name) { }

	// RVA: 0x28E4800 Offset: 0x28E4901 VA: 0x28E4800
	protected void BaseSet(string name, object value) { }

	// RVA: 0x28E48E0 Offset: 0x28E49E1 VA: 0x28E48E0
	protected object BaseGet(int index) { }

	// RVA: 0x28E4730 Offset: 0x28E4831 VA: 0x28E4730
	protected string BaseGetKey(int index) { }

	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x28E4A90 Offset: 0x28E4B91 VA: 0x28E4A90 Slot: 12
	public virtual int get_Count() { }

	// RVA: 0x28E4AC0 Offset: 0x28E4BC1 VA: 0x28E4AC0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x28E4DF0 Offset: 0x28E4EF1 VA: 0x28E4DF0
	private static void .cctor() { }
}

