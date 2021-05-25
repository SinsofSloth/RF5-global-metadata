[DefaultMemberAttribute] // RVA: 0xB3370 Offset: 0xB3471 VA: 0xB3370
[DebuggerTypeProxyAttribute] // RVA: 0xB3370 Offset: 0xB3471 VA: 0xB3370
[DebuggerDisplayAttribute] // RVA: 0xB3370 Offset: 0xB3471 VA: 0xB3370
[Serializable]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1394
{
	// Fields
	private readonly IDictionary<TKey, TValue> m_dictionary; // 0x0
	private object m_syncRoot; // 0x0
	private ReadOnlyDictionary.KeyCollection<TKey, TValue> m_keys; // 0x0
	private ReadOnlyDictionary.ValueCollection<TKey, TValue> m_values; // 0x0

	// Properties
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FB70 Offset: 0x2E9FC71 VA: 0x2E9FB70
	|-ReadOnlyDictionary<int, CropDataTable>..ctor
	|
	|-RVA: 0x2EA1420 Offset: 0x2EA1521 VA: 0x2EA1420
	|-ReadOnlyDictionary<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2EA2B50 Offset: 0x2EA2C51 VA: 0x2EA2B50
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2EA41B0 Offset: 0x2EA42B1 VA: 0x2EA41B0
	|-ReadOnlyDictionary<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2EA5A00 Offset: 0x2EA5B01 VA: 0x2EA5A00
	|-ReadOnlyDictionary<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2C34D50 Offset: 0x2C34E51 VA: 0x2C34D50
	|-ReadOnlyDictionary<int, object>..ctor
	|
	|-RVA: 0x2C36360 Offset: 0x2C36461 VA: 0x2C36360
	|-ReadOnlyDictionary<object, object>..ctor
	|-ReadOnlyDictionary<Type, IMessagePackFormatter>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FC20 Offset: 0x2E9FD21 VA: 0x2E9FC20
	|-ReadOnlyDictionary<int, CropDataTable>.get_Keys
	|
	|-RVA: 0x2EA14D0 Offset: 0x2EA15D1 VA: 0x2EA14D0
	|-ReadOnlyDictionary<int, EffectDataTable>.get_Keys
	|
	|-RVA: 0x2EA2C00 Offset: 0x2EA2D01 VA: 0x2EA2C00
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.get_Keys
	|
	|-RVA: 0x2EA4260 Offset: 0x2EA4361 VA: 0x2EA4260
	|-ReadOnlyDictionary<int, MineTypeDataTable>.get_Keys
	|
	|-RVA: 0x2EA5AB0 Offset: 0x2EA5BB1 VA: 0x2EA5AB0
	|-ReadOnlyDictionary<int, MiningDataTable>.get_Keys
	|
	|-RVA: 0x2C34E00 Offset: 0x2C34F01 VA: 0x2C34E00
	|-ReadOnlyDictionary<int, object>.get_Keys
	|
	|-RVA: 0x2C36410 Offset: 0x2C36511 VA: 0x2C36410
	|-ReadOnlyDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FD50 Offset: 0x2E9FE51 VA: 0x2E9FD50
	|-ReadOnlyDictionary<int, CropDataTable>.ContainsKey
	|
	|-RVA: 0x2EA1600 Offset: 0x2EA1701 VA: 0x2EA1600
	|-ReadOnlyDictionary<int, EffectDataTable>.ContainsKey
	|
	|-RVA: 0x2EA2D30 Offset: 0x2EA2E31 VA: 0x2EA2D30
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.ContainsKey
	|
	|-RVA: 0x2EA4390 Offset: 0x2EA4491 VA: 0x2EA4390
	|-ReadOnlyDictionary<int, MineTypeDataTable>.ContainsKey
	|
	|-RVA: 0x2EA5BE0 Offset: 0x2EA5CE1 VA: 0x2EA5BE0
	|-ReadOnlyDictionary<int, MiningDataTable>.ContainsKey
	|
	|-RVA: 0x2C34F30 Offset: 0x2C35031 VA: 0x2C34F30
	|-ReadOnlyDictionary<int, object>.ContainsKey
	|
	|-RVA: 0x2C36540 Offset: 0x2C36641 VA: 0x2C36540
	|-ReadOnlyDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FE00 Offset: 0x2E9FF01 VA: 0x2E9FE00
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2EA16B0 Offset: 0x2EA17B1 VA: 0x2EA16B0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2EA2DE0 Offset: 0x2EA2EE1 VA: 0x2EA2DE0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2EA4440 Offset: 0x2EA4541 VA: 0x2EA4440
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2EA5C90 Offset: 0x2EA5D91 VA: 0x2EA5C90
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2C34FE0 Offset: 0x2C350E1 VA: 0x2C34FE0
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2C365F0 Offset: 0x2C366F1 VA: 0x2C365F0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FE30 Offset: 0x2E9FF31 VA: 0x2E9FE30
	|-ReadOnlyDictionary<int, CropDataTable>.TryGetValue
	|
	|-RVA: 0x2EA16E0 Offset: 0x2EA17E1 VA: 0x2EA16E0
	|-ReadOnlyDictionary<int, EffectDataTable>.TryGetValue
	|
	|-RVA: 0x2EA2E10 Offset: 0x2EA2F11 VA: 0x2EA2E10
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.TryGetValue
	|
	|-RVA: 0x2EA4470 Offset: 0x2EA4571 VA: 0x2EA4470
	|-ReadOnlyDictionary<int, MineTypeDataTable>.TryGetValue
	|
	|-RVA: 0x2EA5CC0 Offset: 0x2EA5DC1 VA: 0x2EA5CC0
	|-ReadOnlyDictionary<int, MiningDataTable>.TryGetValue
	|
	|-RVA: 0x2C35010 Offset: 0x2C35111 VA: 0x2C35010
	|-ReadOnlyDictionary<int, object>.TryGetValue
	|
	|-RVA: 0x2C36620 Offset: 0x2C36721 VA: 0x2C36620
	|-ReadOnlyDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FEF0 Offset: 0x2E9FFF1 VA: 0x2E9FEF0
	|-ReadOnlyDictionary<int, CropDataTable>.get_Item
	|
	|-RVA: 0x2EA17A0 Offset: 0x2EA18A1 VA: 0x2EA17A0
	|-ReadOnlyDictionary<int, EffectDataTable>.get_Item
	|
	|-RVA: 0x2EA2ED0 Offset: 0x2EA2FD1 VA: 0x2EA2ED0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.get_Item
	|
	|-RVA: 0x2EA4530 Offset: 0x2EA4631 VA: 0x2EA4530
	|-ReadOnlyDictionary<int, MineTypeDataTable>.get_Item
	|
	|-RVA: 0x2EA5D80 Offset: 0x2EA5E81 VA: 0x2EA5D80
	|-ReadOnlyDictionary<int, MiningDataTable>.get_Item
	|
	|-RVA: 0x2C350D0 Offset: 0x2C351D1 VA: 0x2C350D0
	|-ReadOnlyDictionary<int, object>.get_Item
	|
	|-RVA: 0x2C366E0 Offset: 0x2C367E1 VA: 0x2C366E0
	|-ReadOnlyDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FFD0 Offset: 0x2EA00D1 VA: 0x2E9FFD0
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2EA1870 Offset: 0x2EA1971 VA: 0x2EA1870
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2EA2F90 Offset: 0x2EA3091 VA: 0x2EA2F90
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2EA4610 Offset: 0x2EA4711 VA: 0x2EA4610
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2EA5E30 Offset: 0x2EA5F31 VA: 0x2EA5E30
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2C35180 Offset: 0x2C35281 VA: 0x2C35180
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2C36790 Offset: 0x2C36891 VA: 0x2C36790
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9FFE0 Offset: 0x2EA00E1 VA: 0x2E9FFE0
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x2EA1880 Offset: 0x2EA1981 VA: 0x2EA1880
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x2EA2FA0 Offset: 0x2EA30A1 VA: 0x2EA2FA0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x2EA4620 Offset: 0x2EA4721 VA: 0x2EA4620
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x2EA5E40 Offset: 0x2EA5F41 VA: 0x2EA5E40
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x2C35190 Offset: 0x2C35291 VA: 0x2C35190
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x2C367A0 Offset: 0x2C368A1 VA: 0x2C367A0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA00C0 Offset: 0x2EA01C1 VA: 0x2EA00C0
	|-ReadOnlyDictionary<int, CropDataTable>.get_Count
	|
	|-RVA: 0x2EA1950 Offset: 0x2EA1A51 VA: 0x2EA1950
	|-ReadOnlyDictionary<int, EffectDataTable>.get_Count
	|
	|-RVA: 0x2EA3060 Offset: 0x2EA3161 VA: 0x2EA3060
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.get_Count
	|
	|-RVA: 0x2EA4700 Offset: 0x2EA4801 VA: 0x2EA4700
	|-ReadOnlyDictionary<int, MineTypeDataTable>.get_Count
	|
	|-RVA: 0x2EA5EF0 Offset: 0x2EA5FF1 VA: 0x2EA5EF0
	|-ReadOnlyDictionary<int, MiningDataTable>.get_Count
	|
	|-RVA: 0x2C35240 Offset: 0x2C35341 VA: 0x2C35240
	|-ReadOnlyDictionary<int, object>.get_Count
	|
	|-RVA: 0x2C36850 Offset: 0x2C36951 VA: 0x2C36850
	|-ReadOnlyDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0160 Offset: 0x2EA0261 VA: 0x2EA0160
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2EA19F0 Offset: 0x2EA1AF1 VA: 0x2EA19F0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2EA3100 Offset: 0x2EA3201 VA: 0x2EA3100
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2EA47A0 Offset: 0x2EA48A1 VA: 0x2EA47A0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2EA5F90 Offset: 0x2EA6091 VA: 0x2EA5F90
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2C352E0 Offset: 0x2C353E1 VA: 0x2C352E0
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2C368F0 Offset: 0x2C369F1 VA: 0x2C368F0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0260 Offset: 0x2EA0361 VA: 0x2EA0260
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2EA1AE0 Offset: 0x2EA1BE1 VA: 0x2EA1AE0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2EA31B0 Offset: 0x2EA32B1 VA: 0x2EA31B0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2EA48D0 Offset: 0x2EA49D1 VA: 0x2EA48D0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2EA6080 Offset: 0x2EA6181 VA: 0x2EA6080
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2C353A0 Offset: 0x2C354A1 VA: 0x2C353A0
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2C369B0 Offset: 0x2C36AB1 VA: 0x2C369B0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0320 Offset: 0x2EA0421 VA: 0x2EA0320
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2EA1BA0 Offset: 0x2EA1CA1 VA: 0x2EA1BA0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2EA3270 Offset: 0x2EA3371 VA: 0x2EA3270
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2EA4990 Offset: 0x2EA4A91 VA: 0x2EA4990
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2EA6140 Offset: 0x2EA6241 VA: 0x2EA6140
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2C35460 Offset: 0x2C35561 VA: 0x2C35460
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2C36A70 Offset: 0x2C36B71 VA: 0x2C36A70
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0330 Offset: 0x2EA0431 VA: 0x2EA0330
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2EA1BB0 Offset: 0x2EA1CB1 VA: 0x2EA1BB0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2EA3280 Offset: 0x2EA3381 VA: 0x2EA3280
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2EA49A0 Offset: 0x2EA4AA1 VA: 0x2EA49A0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2EA6150 Offset: 0x2EA6251 VA: 0x2EA6150
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2C35470 Offset: 0x2C35571 VA: 0x2C35470
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2C36A80 Offset: 0x2C36B81 VA: 0x2C36A80
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0340 Offset: 0x2EA0441 VA: 0x2EA0340
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x2EA1BC0 Offset: 0x2EA1CC1 VA: 0x2EA1BC0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x2EA3290 Offset: 0x2EA3391 VA: 0x2EA3290
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x2EA49B0 Offset: 0x2EA4AB1 VA: 0x2EA49B0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x2EA6160 Offset: 0x2EA6261 VA: 0x2EA6160
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x2C35480 Offset: 0x2C35581 VA: 0x2C35480
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x2C36A90 Offset: 0x2C36B91 VA: 0x2C36A90
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0350 Offset: 0x2EA0451 VA: 0x2EA0350
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2EA1BD0 Offset: 0x2EA1CD1 VA: 0x2EA1BD0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2EA32A0 Offset: 0x2EA33A1 VA: 0x2EA32A0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2EA49C0 Offset: 0x2EA4AC1 VA: 0x2EA49C0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2EA6170 Offset: 0x2EA6271 VA: 0x2EA6170
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2C35490 Offset: 0x2C35591 VA: 0x2C35490
	|-ReadOnlyDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2C36AA0 Offset: 0x2C36BA1 VA: 0x2C36AA0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0370 Offset: 0x2EA0471 VA: 0x2EA0370
	|-ReadOnlyDictionary<int, CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2EA1BF0 Offset: 0x2EA1CF1 VA: 0x2EA1BF0
	|-ReadOnlyDictionary<int, EffectDataTable>.GetEnumerator
	|
	|-RVA: 0x2EA32C0 Offset: 0x2EA33C1 VA: 0x2EA32C0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.GetEnumerator
	|
	|-RVA: 0x2EA49E0 Offset: 0x2EA4AE1 VA: 0x2EA49E0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.GetEnumerator
	|
	|-RVA: 0x2EA6190 Offset: 0x2EA6291 VA: 0x2EA6190
	|-ReadOnlyDictionary<int, MiningDataTable>.GetEnumerator
	|
	|-RVA: 0x2C354B0 Offset: 0x2C355B1 VA: 0x2C354B0
	|-ReadOnlyDictionary<int, object>.GetEnumerator
	|
	|-RVA: 0x2C36AC0 Offset: 0x2C36BC1 VA: 0x2C36AC0
	|-ReadOnlyDictionary<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0410 Offset: 0x2EA0511 VA: 0x2EA0410
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EA1C90 Offset: 0x2EA1D91 VA: 0x2EA1C90
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EA3360 Offset: 0x2EA3461 VA: 0x2EA3360
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EA4A80 Offset: 0x2EA4B81 VA: 0x2EA4A80
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EA6230 Offset: 0x2EA6331 VA: 0x2EA6230
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C35550 Offset: 0x2C35651 VA: 0x2C35550
	|-ReadOnlyDictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C36B60 Offset: 0x2C36C61 VA: 0x2C36B60
	|-ReadOnlyDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA04C0 Offset: 0x2EA05C1 VA: 0x2EA04C0
	|-ReadOnlyDictionary<int, CropDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2EA1D40 Offset: 0x2EA1E41 VA: 0x2EA1D40
	|-ReadOnlyDictionary<int, EffectDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2EA3410 Offset: 0x2EA3511 VA: 0x2EA3410
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2EA4B30 Offset: 0x2EA4C31 VA: 0x2EA4B30
	|-ReadOnlyDictionary<int, MineTypeDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2EA62E0 Offset: 0x2EA63E1 VA: 0x2EA62E0
	|-ReadOnlyDictionary<int, MiningDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2C35600 Offset: 0x2C35701 VA: 0x2C35600
	|-ReadOnlyDictionary<int, object>.IsCompatibleKey
	|
	|-RVA: 0x2C36C10 Offset: 0x2C36D11 VA: 0x2C36C10
	|-ReadOnlyDictionary<object, object>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0550 Offset: 0x2EA0651 VA: 0x2EA0550
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2EA1DD0 Offset: 0x2EA1ED1 VA: 0x2EA1DD0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2EA34A0 Offset: 0x2EA35A1 VA: 0x2EA34A0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2EA4BC0 Offset: 0x2EA4CC1 VA: 0x2EA4BC0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2EA6370 Offset: 0x2EA6471 VA: 0x2EA6370
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2C35690 Offset: 0x2C35791 VA: 0x2C35690
	|-ReadOnlyDictionary<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2C36CA0 Offset: 0x2C36DA1 VA: 0x2C36CA0
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0560 Offset: 0x2EA0661 VA: 0x2EA0560
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2EA1DE0 Offset: 0x2EA1EE1 VA: 0x2EA1DE0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2EA34B0 Offset: 0x2EA35B1 VA: 0x2EA34B0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2EA4BD0 Offset: 0x2EA4CD1 VA: 0x2EA4BD0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2EA6380 Offset: 0x2EA6481 VA: 0x2EA6380
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2C356A0 Offset: 0x2C357A1 VA: 0x2C356A0
	|-ReadOnlyDictionary<int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2C36CB0 Offset: 0x2C36DB1 VA: 0x2C36CB0
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0640 Offset: 0x2EA0741 VA: 0x2EA0640
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2EA1EC0 Offset: 0x2EA1FC1 VA: 0x2EA1EC0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2EA3590 Offset: 0x2EA3691 VA: 0x2EA3590
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2EA4CB0 Offset: 0x2EA4DB1 VA: 0x2EA4CB0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2EA6460 Offset: 0x2EA6561 VA: 0x2EA6460
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2C35780 Offset: 0x2C35881 VA: 0x2C35780
	|-ReadOnlyDictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2C36D90 Offset: 0x2C36E91 VA: 0x2C36D90
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA0770 Offset: 0x2EA0871 VA: 0x2EA0770
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2EA1FF0 Offset: 0x2EA20F1 VA: 0x2EA1FF0
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2EA36C0 Offset: 0x2EA37C1 VA: 0x2EA36C0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2EA4DE0 Offset: 0x2EA4EE1 VA: 0x2EA4DE0
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2EA6590 Offset: 0x2EA6691 VA: 0x2EA6590
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2C358B0 Offset: 0x2C359B1 VA: 0x2C358B0
	|-ReadOnlyDictionary<int, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2C36EC0 Offset: 0x2C36FC1 VA: 0x2C36EC0
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA07A0 Offset: 0x2EA08A1 VA: 0x2EA07A0
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2EA2020 Offset: 0x2EA2121 VA: 0x2EA2020
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2EA36F0 Offset: 0x2EA37F1 VA: 0x2EA36F0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2EA4E10 Offset: 0x2EA4F11 VA: 0x2EA4E10
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2EA65C0 Offset: 0x2EA66C1 VA: 0x2EA65C0
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2C358E0 Offset: 0x2C359E1 VA: 0x2C358E0
	|-ReadOnlyDictionary<int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2C36EF0 Offset: 0x2C36FF1 VA: 0x2C36EF0
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA08B0 Offset: 0x2EA09B1 VA: 0x2EA08B0
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2EA2130 Offset: 0x2EA2231 VA: 0x2EA2130
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2EA37E0 Offset: 0x2EA38E1 VA: 0x2EA37E0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2EA4F30 Offset: 0x2EA5031 VA: 0x2EA4F30
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2EA66C0 Offset: 0x2EA67C1 VA: 0x2EA66C0
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2C359C0 Offset: 0x2C35AC1 VA: 0x2C359C0
	|-ReadOnlyDictionary<int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2C36FD0 Offset: 0x2C370D1 VA: 0x2C36FD0
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EA08C0 Offset: 0x2EA09C1 VA: 0x2EA08C0
	|-ReadOnlyDictionary<int, CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EA2140 Offset: 0x2EA2241 VA: 0x2EA2140
	|-ReadOnlyDictionary<int, EffectDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EA37F0 Offset: 0x2EA38F1 VA: 0x2EA37F0
	|-ReadOnlyDictionary<int, GimmickLayoutDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EA4F40 Offset: 0x2EA5041 VA: 0x2EA4F40
	|-ReadOnlyDictionary<int, MineTypeDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EA66D0 Offset: 0x2EA67D1 VA: 0x2EA66D0
	|-ReadOnlyDictionary<int, MiningDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C359D0 Offset: 0x2C35AD1 VA: 0x2C359D0
	|-ReadOnlyDictionary<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C36FE0 Offset: 0x2C370E1 VA: 0x2C36FE0
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.CopyTo
	*/
}

