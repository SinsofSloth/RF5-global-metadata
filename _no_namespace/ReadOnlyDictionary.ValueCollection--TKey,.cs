[DebuggerDisplayAttribute] // RVA: 0xB34B0 Offset: 0xB35B1 VA: 0xB34B0
[DebuggerTypeProxyAttribute] // RVA: 0xB34B0 Offset: 0xB35B1 VA: 0xB34B0
[Serializable]
public sealed class ReadOnlyDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 1397
{
	// Fields
	private readonly ICollection<TValue> m_collection; // 0x0
	private object m_syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9DDE0 Offset: 0x2E9DEE1 VA: 0x2E9DDE0
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E9E240 Offset: 0x2E9E341 VA: 0x2E9E240
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E9E690 Offset: 0x2E9E791 VA: 0x2E9E690
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E9EAB0 Offset: 0x2E9EBB1 VA: 0x2E9EAB0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E9EF30 Offset: 0x2E9F031 VA: 0x2E9EF30
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E9F350 Offset: 0x2E9F451 VA: 0x2E9F350
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E9F760 Offset: 0x2E9F861 VA: 0x2E9F760
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9DDF0 Offset: 0x2E9DEF1 VA: 0x2E9DDF0
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E9E250 Offset: 0x2E9E351 VA: 0x2E9E250
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E9E6A0 Offset: 0x2E9E7A1 VA: 0x2E9E6A0
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E9EAC0 Offset: 0x2E9EBC1 VA: 0x2E9EAC0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E9EF40 Offset: 0x2E9F041 VA: 0x2E9EF40
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E9F360 Offset: 0x2E9F461 VA: 0x2E9F360
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E9F770 Offset: 0x2E9F871 VA: 0x2E9F770
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9DE00 Offset: 0x2E9DF01 VA: 0x2E9DE00
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E9E260 Offset: 0x2E9E361 VA: 0x2E9E260
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E9E6B0 Offset: 0x2E9E7B1 VA: 0x2E9E6B0
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E9EAD0 Offset: 0x2E9EBD1 VA: 0x2E9EAD0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E9EF50 Offset: 0x2E9F051 VA: 0x2E9EF50
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E9F370 Offset: 0x2E9F471 VA: 0x2E9F370
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E9F780 Offset: 0x2E9F881 VA: 0x2E9F780
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9DF00 Offset: 0x2E9E001 VA: 0x2E9DF00
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.CopyTo
	|
	|-RVA: 0x2E9E350 Offset: 0x2E9E451 VA: 0x2E9E350
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.CopyTo
	|
	|-RVA: 0x2E9E770 Offset: 0x2E9E871 VA: 0x2E9E770
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.CopyTo
	|
	|-RVA: 0x2E9EBF0 Offset: 0x2E9ECF1 VA: 0x2E9EBF0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.CopyTo
	|
	|-RVA: 0x2E9F010 Offset: 0x2E9F111 VA: 0x2E9F010
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.CopyTo
	|
	|-RVA: 0x2E9F420 Offset: 0x2E9F521 VA: 0x2E9F420
	|-ReadOnlyDictionary.ValueCollection<int, object>.CopyTo
	|
	|-RVA: 0x2E9F830 Offset: 0x2E9F931 VA: 0x2E9F830
	|-ReadOnlyDictionary.ValueCollection<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9DFC0 Offset: 0x2E9E0C1 VA: 0x2E9DFC0
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.get_Count
	|
	|-RVA: 0x2E9E410 Offset: 0x2E9E511 VA: 0x2E9E410
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.get_Count
	|
	|-RVA: 0x2E9E830 Offset: 0x2E9E931 VA: 0x2E9E830
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.get_Count
	|
	|-RVA: 0x2E9ECB0 Offset: 0x2E9EDB1 VA: 0x2E9ECB0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.get_Count
	|
	|-RVA: 0x2E9F0D0 Offset: 0x2E9F1D1 VA: 0x2E9F0D0
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.get_Count
	|
	|-RVA: 0x2E9F4E0 Offset: 0x2E9F5E1 VA: 0x2E9F4E0
	|-ReadOnlyDictionary.ValueCollection<int, object>.get_Count
	|
	|-RVA: 0x2E9F8F0 Offset: 0x2E9F9F1 VA: 0x2E9F8F0
	|-ReadOnlyDictionary.ValueCollection<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9E060 Offset: 0x2E9E161 VA: 0x2E9E060
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E9E4B0 Offset: 0x2E9E5B1 VA: 0x2E9E4B0
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E9E8D0 Offset: 0x2E9E9D1 VA: 0x2E9E8D0
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E9ED50 Offset: 0x2E9EE51 VA: 0x2E9ED50
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E9F170 Offset: 0x2E9F271 VA: 0x2E9F170
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E9F580 Offset: 0x2E9F681 VA: 0x2E9F580
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E9F990 Offset: 0x2E9FA91 VA: 0x2E9F990
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9E070 Offset: 0x2E9E171 VA: 0x2E9E070
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E9E4C0 Offset: 0x2E9E5C1 VA: 0x2E9E4C0
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E9E8E0 Offset: 0x2E9E9E1 VA: 0x2E9E8E0
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E9ED60 Offset: 0x2E9EE61 VA: 0x2E9ED60
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E9F180 Offset: 0x2E9F281 VA: 0x2E9F180
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E9F590 Offset: 0x2E9F691 VA: 0x2E9F590
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E9F9A0 Offset: 0x2E9FAA1 VA: 0x2E9F9A0
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9E090 Offset: 0x2E9E191 VA: 0x2E9E090
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9E4E0 Offset: 0x2E9E5E1 VA: 0x2E9E4E0
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9E900 Offset: 0x2E9EA01 VA: 0x2E9E900
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9ED80 Offset: 0x2E9EE81 VA: 0x2E9ED80
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9F1A0 Offset: 0x2E9F2A1 VA: 0x2E9F1A0
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9F5B0 Offset: 0x2E9F6B1 VA: 0x2E9F5B0
	|-ReadOnlyDictionary.ValueCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x2E9F9C0 Offset: 0x2E9FAC1 VA: 0x2E9F9C0
	|-ReadOnlyDictionary.ValueCollection<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9E130 Offset: 0x2E9E231 VA: 0x2E9E130
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9E580 Offset: 0x2E9E681 VA: 0x2E9E580
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9E9A0 Offset: 0x2E9EAA1 VA: 0x2E9E9A0
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9EE20 Offset: 0x2E9EF21 VA: 0x2E9EE20
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9F240 Offset: 0x2E9F341 VA: 0x2E9F240
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9F650 Offset: 0x2E9F751 VA: 0x2E9F650
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9FA60 Offset: 0x2E9FB61 VA: 0x2E9FA60
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9E1E0 Offset: 0x2E9E2E1 VA: 0x2E9E1E0
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9E630 Offset: 0x2E9E731 VA: 0x2E9E630
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9EA50 Offset: 0x2E9EB51 VA: 0x2E9EA50
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9EED0 Offset: 0x2E9EFD1 VA: 0x2E9EED0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9F2F0 Offset: 0x2E9F3F1 VA: 0x2E9F2F0
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9F700 Offset: 0x2E9F801 VA: 0x2E9F700
	|-ReadOnlyDictionary.ValueCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9FB10 Offset: 0x2E9FC11 VA: 0x2E9FB10
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9E200 Offset: 0x2E9E301 VA: 0x2E9E200
	|-ReadOnlyDictionary.ValueCollection<int, CropDataTable>..ctor
	|
	|-RVA: 0x2E9E650 Offset: 0x2E9E751 VA: 0x2E9E650
	|-ReadOnlyDictionary.ValueCollection<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2E9EA70 Offset: 0x2E9EB71 VA: 0x2E9EA70
	|-ReadOnlyDictionary.ValueCollection<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E9EEF0 Offset: 0x2E9EFF1 VA: 0x2E9EEF0
	|-ReadOnlyDictionary.ValueCollection<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E9F310 Offset: 0x2E9F411 VA: 0x2E9F310
	|-ReadOnlyDictionary.ValueCollection<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2E9F720 Offset: 0x2E9F821 VA: 0x2E9F720
	|-ReadOnlyDictionary.ValueCollection<int, object>..ctor
	|
	|-RVA: 0x2E9FB30 Offset: 0x2E9FC31 VA: 0x2E9FB30
	|-ReadOnlyDictionary.ValueCollection<object, object>..ctor
	*/
}

