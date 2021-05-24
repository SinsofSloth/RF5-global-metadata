public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

public sealed class ExpandoObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 2724
{
	// Fields
	private static readonly MethodInfo ExpandoTryGetValue; // 0x0
	private static readonly MethodInfo ExpandoTrySetValue; // 0x8
	private static readonly MethodInfo ExpandoTryDeleteValue; // 0x10
	private static readonly MethodInfo ExpandoPromoteClass; // 0x18
	private static readonly MethodInfo ExpandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x169C980 Offset: 0x169CA81 VA: 0x169C980
	public void .ctor() { }

	// RVA: 0x169CA30 Offset: 0x169CB31 VA: 0x169CA30
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x169CCA0 Offset: 0x169CDA1 VA: 0x169CCA0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x169D430 Offset: 0x169D531 VA: 0x169D430
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x169C830 Offset: 0x169C931 VA: 0x169C830
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x169D8A0 Offset: 0x169D9A1 VA: 0x169D8A0
	internal ExpandoClass get_Class() { }

	// RVA: 0x169D2C0 Offset: 0x169D3C1 VA: 0x169D2C0
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x169DAA0 Offset: 0x169DBA1 VA: 0x169DAA0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x169DC10 Offset: 0x169DD11 VA: 0x169DC10
	private void TryAddMember(string key, object value) { }

	// RVA: 0x169DD80 Offset: 0x169DE81 VA: 0x169DD80
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x169DDA0 Offset: 0x169DEA1 VA: 0x169DDA0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x169DE50 Offset: 0x169DF51 VA: 0x169DE50 Slot: 5
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x169DFB0 Offset: 0x169E0B1 VA: 0x169DFB0 Slot: 4
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x169E0C0 Offset: 0x169E1C1 VA: 0x169E0C0 Slot: 7
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x169E0D0 Offset: 0x169E1D1 VA: 0x169E0D0 Slot: 6
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x169E250 Offset: 0x169E351 VA: 0x169E250 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x169E270 Offset: 0x169E371 VA: 0x169E270 Slot: 9
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x169E280 Offset: 0x169E381 VA: 0x169E280 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x169E290 Offset: 0x169E391 VA: 0x169E290 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x169E2F0 Offset: 0x169E3F1 VA: 0x169E2F0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x169E520 Offset: 0x169E621 VA: 0x169E520 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x169E5C0 Offset: 0x169E6C1 VA: 0x169E5C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x169E9B0 Offset: 0x169EAB1 VA: 0x169E9B0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x169EA20 Offset: 0x169EB21 VA: 0x169EA20 Slot: 16
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x169EB70 Offset: 0x169EC71 VA: 0x169EB70 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0xC1110 Offset: 0xC1211 VA: 0xC1110
	// RVA: 0x169EAD0 Offset: 0x169EBD1 VA: 0x169EAD0
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x169EC50 Offset: 0x169ED51 VA: 0x169EC50 Slot: 18
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ECE0 Offset: 0x169EDE1 VA: 0x169ECE0 Slot: 19
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x169ED70 Offset: 0x169EE71 VA: 0x169ED70
	private static void .cctor() { }
}

