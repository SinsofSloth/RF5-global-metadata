[Serializable]
private struct ReadOnlyDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1395
{
	// Fields
	private readonly IDictionary<TKey, TValue> m_dictionary; // 0x0
	private IEnumerator<KeyValuePair<TKey, TValue>> m_enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CC60 Offset: 0x39CD61 VA: 0x39CC60
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>..ctor
	|
	|-RVA: 0x39CEA0 Offset: 0x39CFA1 VA: 0x39CEA0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>..ctor
	|
	|-RVA: 0x39D0E0 Offset: 0x39D1E1 VA: 0x39D0E0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x39D320 Offset: 0x39D421 VA: 0x39D320
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x39D560 Offset: 0x39D661 VA: 0x39D560
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>..ctor
	|
	|-RVA: 0x39D7A0 Offset: 0x39D8A1 VA: 0x39D7A0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>..ctor
	|
	|-RVA: 0x39D9E0 Offset: 0x39DAE1 VA: 0x39D9E0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CC70 Offset: 0x39CD71 VA: 0x39CC70
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>.get_Entry
	|
	|-RVA: 0x39CEB0 Offset: 0x39CFB1 VA: 0x39CEB0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>.get_Entry
	|
	|-RVA: 0x39D0F0 Offset: 0x39D1F1 VA: 0x39D0F0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>.get_Entry
	|
	|-RVA: 0x39D330 Offset: 0x39D431 VA: 0x39D330
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>.get_Entry
	|
	|-RVA: 0x39D570 Offset: 0x39D671 VA: 0x39D570
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>.get_Entry
	|
	|-RVA: 0x39D7B0 Offset: 0x39D8B1 VA: 0x39D7B0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>.get_Entry
	|
	|-RVA: 0x39D9F0 Offset: 0x39DAF1 VA: 0x39D9F0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CC80 Offset: 0x39CD81 VA: 0x39CC80
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>.get_Key
	|
	|-RVA: 0x39CEC0 Offset: 0x39CFC1 VA: 0x39CEC0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>.get_Key
	|
	|-RVA: 0x39D100 Offset: 0x39D201 VA: 0x39D100
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>.get_Key
	|
	|-RVA: 0x39D340 Offset: 0x39D441 VA: 0x39D340
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>.get_Key
	|
	|-RVA: 0x39D580 Offset: 0x39D681 VA: 0x39D580
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>.get_Key
	|
	|-RVA: 0x39D7C0 Offset: 0x39D8C1 VA: 0x39D7C0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>.get_Key
	|
	|-RVA: 0x39DA00 Offset: 0x39DB01 VA: 0x39DA00
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CC90 Offset: 0x39CD91 VA: 0x39CC90
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>.get_Value
	|
	|-RVA: 0x39CED0 Offset: 0x39CFD1 VA: 0x39CED0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>.get_Value
	|
	|-RVA: 0x39D110 Offset: 0x39D211 VA: 0x39D110
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>.get_Value
	|
	|-RVA: 0x39D350 Offset: 0x39D451 VA: 0x39D350
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>.get_Value
	|
	|-RVA: 0x39D590 Offset: 0x39D691 VA: 0x39D590
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>.get_Value
	|
	|-RVA: 0x39D7D0 Offset: 0x39D8D1 VA: 0x39D7D0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>.get_Value
	|
	|-RVA: 0x39DA10 Offset: 0x39DB11 VA: 0x39DA10
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CCA0 Offset: 0x39CDA1 VA: 0x39CCA0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>.get_Current
	|
	|-RVA: 0x39CEE0 Offset: 0x39CFE1 VA: 0x39CEE0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>.get_Current
	|
	|-RVA: 0x39D120 Offset: 0x39D221 VA: 0x39D120
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>.get_Current
	|
	|-RVA: 0x39D360 Offset: 0x39D461 VA: 0x39D360
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>.get_Current
	|
	|-RVA: 0x39D5A0 Offset: 0x39D6A1 VA: 0x39D5A0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>.get_Current
	|
	|-RVA: 0x39D7E0 Offset: 0x39D8E1 VA: 0x39D7E0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>.get_Current
	|
	|-RVA: 0x39DA20 Offset: 0x39DB21 VA: 0x39DA20
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CD30 Offset: 0x39CE31 VA: 0x39CD30
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>.MoveNext
	|
	|-RVA: 0x39CF70 Offset: 0x39D071 VA: 0x39CF70
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>.MoveNext
	|
	|-RVA: 0x39D1B0 Offset: 0x39D2B1 VA: 0x39D1B0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>.MoveNext
	|
	|-RVA: 0x39D3F0 Offset: 0x39D4F1 VA: 0x39D3F0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>.MoveNext
	|
	|-RVA: 0x39D630 Offset: 0x39D731 VA: 0x39D630
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>.MoveNext
	|
	|-RVA: 0x39D870 Offset: 0x39D971 VA: 0x39D870
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>.MoveNext
	|
	|-RVA: 0x39DAB0 Offset: 0x39DBB1 VA: 0x39DAB0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CDE0 Offset: 0x39CEE1 VA: 0x39CDE0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, CropDataTable>.Reset
	|
	|-RVA: 0x39D020 Offset: 0x39D121 VA: 0x39D020
	|-ReadOnlyDictionary.DictionaryEnumerator<int, EffectDataTable>.Reset
	|
	|-RVA: 0x39D260 Offset: 0x39D361 VA: 0x39D260
	|-ReadOnlyDictionary.DictionaryEnumerator<int, GimmickLayoutDataTable>.Reset
	|
	|-RVA: 0x39D4A0 Offset: 0x39D5A1 VA: 0x39D4A0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MineTypeDataTable>.Reset
	|
	|-RVA: 0x39D6E0 Offset: 0x39D7E1 VA: 0x39D6E0
	|-ReadOnlyDictionary.DictionaryEnumerator<int, MiningDataTable>.Reset
	|
	|-RVA: 0x39D920 Offset: 0x39DA21 VA: 0x39D920
	|-ReadOnlyDictionary.DictionaryEnumerator<int, object>.Reset
	|
	|-RVA: 0x39DB60 Offset: 0x39DC61 VA: 0x39DB60
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.Reset
	*/
}

