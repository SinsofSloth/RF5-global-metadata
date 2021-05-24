[DebuggerTypeProxyAttribute] // RVA: 0xB3420 Offset: 0xB3521 VA: 0xB3420
[DebuggerDisplayAttribute] // RVA: 0xB3420 Offset: 0xB3521 VA: 0xB3420
[Serializable]
public sealed class ReadOnlyDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 1396
{
	// Fields
	private readonly ICollection<TKey> m_collection; // 0x0
	private object m_syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TKey> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9BF40 Offset: 0x2E9C041 VA: 0x2E9BF40
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>..ctor
	|
	|-RVA: 0x2E9C3A0 Offset: 0x2E9C4A1 VA: 0x2E9C3A0
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2E9C800 Offset: 0x2E9C901 VA: 0x2E9C800
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E9CC60 Offset: 0x2E9CD61 VA: 0x2E9CC60
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E9D0C0 Offset: 0x2E9D1C1 VA: 0x2E9D0C0
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2E9D520 Offset: 0x2E9D621 VA: 0x2E9D520
	|-ReadOnlyDictionary.KeyCollection<int, object>..ctor
	|
	|-RVA: 0x2E9D980 Offset: 0x2E9DA81 VA: 0x2E9D980
	|-ReadOnlyDictionary.KeyCollection<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9BF90 Offset: 0x2E9C091 VA: 0x2E9BF90
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2E9C3F0 Offset: 0x2E9C4F1 VA: 0x2E9C3F0
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2E9C850 Offset: 0x2E9C951 VA: 0x2E9C850
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2E9CCB0 Offset: 0x2E9CDB1 VA: 0x2E9CCB0
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2E9D110 Offset: 0x2E9D211 VA: 0x2E9D110
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2E9D570 Offset: 0x2E9D671 VA: 0x2E9D570
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2E9D9D0 Offset: 0x2E9DAD1 VA: 0x2E9D9D0
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9BFA0 Offset: 0x2E9C0A1 VA: 0x2E9BFA0
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2E9C400 Offset: 0x2E9C501 VA: 0x2E9C400
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2E9C860 Offset: 0x2E9C961 VA: 0x2E9C860
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2E9CCC0 Offset: 0x2E9CDC1 VA: 0x2E9CCC0
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2E9D120 Offset: 0x2E9D221 VA: 0x2E9D120
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2E9D580 Offset: 0x2E9D681 VA: 0x2E9D580
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2E9D9E0 Offset: 0x2E9DAE1 VA: 0x2E9D9E0
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9BFB0 Offset: 0x2E9C0B1 VA: 0x2E9BFB0
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2E9C410 Offset: 0x2E9C511 VA: 0x2E9C410
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2E9C870 Offset: 0x2E9C971 VA: 0x2E9C870
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2E9CCD0 Offset: 0x2E9CDD1 VA: 0x2E9CCD0
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2E9D130 Offset: 0x2E9D231 VA: 0x2E9D130
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2E9D590 Offset: 0x2E9D691 VA: 0x2E9D590
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2E9D9F0 Offset: 0x2E9DAF1 VA: 0x2E9D9F0
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C060 Offset: 0x2E9C161 VA: 0x2E9C060
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.CopyTo
	|
	|-RVA: 0x2E9C4C0 Offset: 0x2E9C5C1 VA: 0x2E9C4C0
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.CopyTo
	|
	|-RVA: 0x2E9C920 Offset: 0x2E9CA21 VA: 0x2E9C920
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.CopyTo
	|
	|-RVA: 0x2E9CD80 Offset: 0x2E9CE81 VA: 0x2E9CD80
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.CopyTo
	|
	|-RVA: 0x2E9D1E0 Offset: 0x2E9D2E1 VA: 0x2E9D1E0
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.CopyTo
	|
	|-RVA: 0x2E9D640 Offset: 0x2E9D741 VA: 0x2E9D640
	|-ReadOnlyDictionary.KeyCollection<int, object>.CopyTo
	|
	|-RVA: 0x2E9DAA0 Offset: 0x2E9DBA1 VA: 0x2E9DAA0
	|-ReadOnlyDictionary.KeyCollection<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C120 Offset: 0x2E9C221 VA: 0x2E9C120
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.get_Count
	|
	|-RVA: 0x2E9C580 Offset: 0x2E9C681 VA: 0x2E9C580
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.get_Count
	|
	|-RVA: 0x2E9C9E0 Offset: 0x2E9CAE1 VA: 0x2E9C9E0
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.get_Count
	|
	|-RVA: 0x2E9CE40 Offset: 0x2E9CF41 VA: 0x2E9CE40
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.get_Count
	|
	|-RVA: 0x2E9D2A0 Offset: 0x2E9D3A1 VA: 0x2E9D2A0
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.get_Count
	|
	|-RVA: 0x2E9D700 Offset: 0x2E9D801 VA: 0x2E9D700
	|-ReadOnlyDictionary.KeyCollection<int, object>.get_Count
	|
	|-RVA: 0x2E9DB60 Offset: 0x2E9DC61 VA: 0x2E9DB60
	|-ReadOnlyDictionary.KeyCollection<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C1C0 Offset: 0x2E9C2C1 VA: 0x2E9C1C0
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2E9C620 Offset: 0x2E9C721 VA: 0x2E9C620
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2E9CA80 Offset: 0x2E9CB81 VA: 0x2E9CA80
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2E9CEE0 Offset: 0x2E9CFE1 VA: 0x2E9CEE0
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2E9D340 Offset: 0x2E9D441 VA: 0x2E9D340
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2E9D7A0 Offset: 0x2E9D8A1 VA: 0x2E9D7A0
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2E9DC00 Offset: 0x2E9DD01 VA: 0x2E9DC00
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C1D0 Offset: 0x2E9C2D1 VA: 0x2E9C1D0
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2E9C630 Offset: 0x2E9C731 VA: 0x2E9C630
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2E9CA90 Offset: 0x2E9CB91 VA: 0x2E9CA90
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2E9CEF0 Offset: 0x2E9CFF1 VA: 0x2E9CEF0
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2E9D350 Offset: 0x2E9D451 VA: 0x2E9D350
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2E9D7B0 Offset: 0x2E9D8B1 VA: 0x2E9D7B0
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2E9DC10 Offset: 0x2E9DD11 VA: 0x2E9DC10
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C1F0 Offset: 0x2E9C2F1 VA: 0x2E9C1F0
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9C650 Offset: 0x2E9C751 VA: 0x2E9C650
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9CAB0 Offset: 0x2E9CBB1 VA: 0x2E9CAB0
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9CF10 Offset: 0x2E9D011 VA: 0x2E9CF10
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9D370 Offset: 0x2E9D471 VA: 0x2E9D370
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.GetEnumerator
	|
	|-RVA: 0x2E9D7D0 Offset: 0x2E9D8D1 VA: 0x2E9D7D0
	|-ReadOnlyDictionary.KeyCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x2E9DC30 Offset: 0x2E9DD31 VA: 0x2E9DC30
	|-ReadOnlyDictionary.KeyCollection<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C290 Offset: 0x2E9C391 VA: 0x2E9C290
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9C6F0 Offset: 0x2E9C7F1 VA: 0x2E9C6F0
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9CB50 Offset: 0x2E9CC51 VA: 0x2E9CB50
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9CFB0 Offset: 0x2E9D0B1 VA: 0x2E9CFB0
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9D410 Offset: 0x2E9D511 VA: 0x2E9D410
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9D870 Offset: 0x2E9D971 VA: 0x2E9D870
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E9DCD0 Offset: 0x2E9DDD1 VA: 0x2E9DCD0
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C340 Offset: 0x2E9C441 VA: 0x2E9C340
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9C7A0 Offset: 0x2E9C8A1 VA: 0x2E9C7A0
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9CC00 Offset: 0x2E9CD01 VA: 0x2E9CC00
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9D060 Offset: 0x2E9D161 VA: 0x2E9D060
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9D4C0 Offset: 0x2E9D5C1 VA: 0x2E9D4C0
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9D920 Offset: 0x2E9DA21 VA: 0x2E9D920
	|-ReadOnlyDictionary.KeyCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E9DD80 Offset: 0x2E9DE81 VA: 0x2E9DD80
	|-ReadOnlyDictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E9C360 Offset: 0x2E9C461 VA: 0x2E9C360
	|-ReadOnlyDictionary.KeyCollection<int, CropDataTable>..ctor
	|
	|-RVA: 0x2E9C7C0 Offset: 0x2E9C8C1 VA: 0x2E9C7C0
	|-ReadOnlyDictionary.KeyCollection<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2E9CC20 Offset: 0x2E9CD21 VA: 0x2E9CC20
	|-ReadOnlyDictionary.KeyCollection<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E9D080 Offset: 0x2E9D181 VA: 0x2E9D080
	|-ReadOnlyDictionary.KeyCollection<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E9D4E0 Offset: 0x2E9D5E1 VA: 0x2E9D4E0
	|-ReadOnlyDictionary.KeyCollection<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2E9D940 Offset: 0x2E9DA41 VA: 0x2E9D940
	|-ReadOnlyDictionary.KeyCollection<int, object>..ctor
	|
	|-RVA: 0x2E9DDA0 Offset: 0x2E9DEA1 VA: 0x2E9DDA0
	|-ReadOnlyDictionary.KeyCollection<object, object>..ctor
	*/
}

