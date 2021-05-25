[DefaultMemberAttribute] // RVA: 0x14A760 Offset: 0x14A861 VA: 0x14A760
public abstract class DictionaryForSaveData<TKey, TValue> : ISerializationCallbackReceiver // TypeDefIndex: 10656
{
	// Fields
	[KeyAttribute] // RVA: 0x181F90 Offset: 0x182091 VA: 0x181F90
	public List<TKey> KeyList; // 0x0
	[KeyAttribute] // RVA: 0x181FB0 Offset: 0x1820B1 VA: 0x181FB0
	public List<TValue> ValueList; // 0x0
	protected Dictionary<TKey, TValue> dic; // 0x0

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B92F0 Offset: 0x1B93F1 VA: 0x1B92F0
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABB8D0 Offset: 0x1ABB9D1 VA: 0x1ABB8D0
	|-DictionaryForSaveData<int, bool>.Init
	|
	|-RVA: 0x1ABC750 Offset: 0x1ABC851 VA: 0x1ABC750
	|-DictionaryForSaveData<int, int>.Init
	|
	|-RVA: 0x1ABD5C0 Offset: 0x1ABD6C1 VA: 0x1ABD5C0
	|-DictionaryForSaveData<Int32Enum, int>.Init
	|
	|-RVA: 0x1ABE430 Offset: 0x1ABE531 VA: 0x1ABE430
	|-DictionaryForSaveData<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABD740 Offset: 0x1ABD841 VA: 0x1ABD740
	|-DictionaryForSaveData<ItemID, int>.OnBeforeSerialize
	|-DictionaryForSaveData<Int32Enum, int>.OnBeforeSerialize
	|
	|-RVA: 0x1ABBA50 Offset: 0x1ABBB51 VA: 0x1ABBA50
	|-DictionaryForSaveData<int, bool>.OnBeforeSerialize
	|
	|-RVA: 0x1ABC8D0 Offset: 0x1ABC9D1 VA: 0x1ABC8D0
	|-DictionaryForSaveData<int, int>.OnBeforeSerialize
	|
	|-RVA: 0x1ABE5B0 Offset: 0x1ABE6B1 VA: 0x1ABE5B0
	|-DictionaryForSaveData<object, object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABDAA0 Offset: 0x1ABDBA1 VA: 0x1ABDAA0
	|-DictionaryForSaveData<ItemID, int>.OnAfterDeserialize
	|-DictionaryForSaveData<Int32Enum, int>.OnAfterDeserialize
	|
	|-RVA: 0x1ABBDB0 Offset: 0x1ABBEB1 VA: 0x1ABBDB0
	|-DictionaryForSaveData<int, bool>.OnAfterDeserialize
	|
	|-RVA: 0x1ABCC30 Offset: 0x1ABCD31 VA: 0x1ABCC30
	|-DictionaryForSaveData<int, int>.OnAfterDeserialize
	|
	|-RVA: 0x1ABE910 Offset: 0x1ABEA11 VA: 0x1ABE910
	|-DictionaryForSaveData<object, object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABBF00 Offset: 0x1ABC001 VA: 0x1ABBF00
	|-DictionaryForSaveData<int, bool>.get_Item
	|
	|-RVA: 0x1ABCD80 Offset: 0x1ABCE81 VA: 0x1ABCD80
	|-DictionaryForSaveData<int, int>.get_Item
	|
	|-RVA: 0x1ABDBF0 Offset: 0x1ABDCF1 VA: 0x1ABDBF0
	|-DictionaryForSaveData<Int32Enum, int>.get_Item
	|
	|-RVA: 0x1ABEA60 Offset: 0x1ABEB61 VA: 0x1ABEA60
	|-DictionaryForSaveData<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABBF30 Offset: 0x1ABC031 VA: 0x1ABBF30
	|-DictionaryForSaveData<int, bool>.set_Item
	|
	|-RVA: 0x1ABCDB0 Offset: 0x1ABCEB1 VA: 0x1ABCDB0
	|-DictionaryForSaveData<int, int>.set_Item
	|
	|-RVA: 0x1ABDC20 Offset: 0x1ABDD21 VA: 0x1ABDC20
	|-DictionaryForSaveData<Int32Enum, int>.set_Item
	|
	|-RVA: 0x1ABEA90 Offset: 0x1ABEB91 VA: 0x1ABEA90
	|-DictionaryForSaveData<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABBF60 Offset: 0x1ABC061 VA: 0x1ABBF60
	|-DictionaryForSaveData<int, bool>.Add
	|
	|-RVA: 0x1ABCDE0 Offset: 0x1ABCEE1 VA: 0x1ABCDE0
	|-DictionaryForSaveData<int, int>.Add
	|
	|-RVA: 0x1ABDC50 Offset: 0x1ABDD51 VA: 0x1ABDC50
	|-DictionaryForSaveData<Int32Enum, int>.Add
	|
	|-RVA: 0x1ABEAC0 Offset: 0x1ABEBC1 VA: 0x1ABEAC0
	|-DictionaryForSaveData<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool CheckValue(TKey[] keys) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABBF90 Offset: 0x1ABC091 VA: 0x1ABBF90
	|-DictionaryForSaveData<int, bool>.CheckValue
	|
	|-RVA: 0x1ABCE10 Offset: 0x1ABCF11 VA: 0x1ABCE10
	|-DictionaryForSaveData<int, int>.CheckValue
	|
	|-RVA: 0x1ABDC80 Offset: 0x1ABDD81 VA: 0x1ABDC80
	|-DictionaryForSaveData<Int32Enum, int>.CheckValue
	|
	|-RVA: 0x1ABEAF0 Offset: 0x1ABEBF1 VA: 0x1ABEAF0
	|-DictionaryForSaveData<object, object>.CheckValue
	*/

	// RVA: -1 Offset: -1
	public TValue[] GetValues(TKey[] keys) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABC040 Offset: 0x1ABC141 VA: 0x1ABC040
	|-DictionaryForSaveData<int, bool>.GetValues
	|
	|-RVA: 0x1ABCEC0 Offset: 0x1ABCFC1 VA: 0x1ABCEC0
	|-DictionaryForSaveData<int, int>.GetValues
	|
	|-RVA: 0x1ABDD30 Offset: 0x1ABDE31 VA: 0x1ABDD30
	|-DictionaryForSaveData<Int32Enum, int>.GetValues
	|
	|-RVA: 0x1ABEBA0 Offset: 0x1ABECA1 VA: 0x1ABEBA0
	|-DictionaryForSaveData<object, object>.GetValues
	*/

	// RVA: -1 Offset: -1
	public void SetValues(TKey[] keys, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABC1E0 Offset: 0x1ABC2E1 VA: 0x1ABC1E0
	|-DictionaryForSaveData<int, bool>.SetValues
	|
	|-RVA: 0x1ABD050 Offset: 0x1ABD151 VA: 0x1ABD050
	|-DictionaryForSaveData<int, int>.SetValues
	|
	|-RVA: 0x1ABDEC0 Offset: 0x1ABDFC1 VA: 0x1ABDEC0
	|-DictionaryForSaveData<Int32Enum, int>.SetValues
	|
	|-RVA: 0x1ABED40 Offset: 0x1ABEE41 VA: 0x1ABED40
	|-DictionaryForSaveData<object, object>.SetValues
	*/

	// RVA: -1 Offset: -1
	private bool CheckValue(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABC290 Offset: 0x1ABC391 VA: 0x1ABC290
	|-DictionaryForSaveData<int, bool>.CheckValue
	|
	|-RVA: 0x1ABD100 Offset: 0x1ABD201 VA: 0x1ABD100
	|-DictionaryForSaveData<int, int>.CheckValue
	|
	|-RVA: 0x1ABDF70 Offset: 0x1ABE071 VA: 0x1ABDF70
	|-DictionaryForSaveData<Int32Enum, int>.CheckValue
	|
	|-RVA: 0x1ABEDF0 Offset: 0x1ABEEF1 VA: 0x1ABEDF0
	|-DictionaryForSaveData<object, object>.CheckValue
	*/

	// RVA: -1 Offset: -1
	public void SetValue(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABC2C0 Offset: 0x1ABC3C1 VA: 0x1ABC2C0
	|-DictionaryForSaveData<int, bool>.SetValue
	|
	|-RVA: 0x1ABD130 Offset: 0x1ABD231 VA: 0x1ABD130
	|-DictionaryForSaveData<int, int>.SetValue
	|
	|-RVA: 0x1ABDFA0 Offset: 0x1ABE0A1 VA: 0x1ABDFA0
	|-DictionaryForSaveData<Int32Enum, int>.SetValue
	|
	|-RVA: 0x1ABEE20 Offset: 0x1ABEF21 VA: 0x1ABEE20
	|-DictionaryForSaveData<object, object>.SetValue
	*/

	// RVA: -1 Offset: -1
	public void Debug_Log() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABC340 Offset: 0x1ABC441 VA: 0x1ABC340
	|-DictionaryForSaveData<int, bool>.Debug_Log
	|
	|-RVA: 0x1ABD1B0 Offset: 0x1ABD2B1 VA: 0x1ABD1B0
	|-DictionaryForSaveData<int, int>.Debug_Log
	|
	|-RVA: 0x1ABE020 Offset: 0x1ABE121 VA: 0x1ABE020
	|-DictionaryForSaveData<Int32Enum, int>.Debug_Log
	|
	|-RVA: 0x1ABEEA0 Offset: 0x1ABEFA1 VA: 0x1ABEEA0
	|-DictionaryForSaveData<object, object>.Debug_Log
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1ABE410 Offset: 0x1ABE511 VA: 0x1ABE410
	|-DictionaryForSaveData<ItemID, int>..ctor
	|-DictionaryForSaveData<Int32Enum, int>..ctor
	|
	|-RVA: 0x1ABC730 Offset: 0x1ABC831 VA: 0x1ABC730
	|-DictionaryForSaveData<int, bool>..ctor
	|
	|-RVA: 0x1ABD5A0 Offset: 0x1ABD6A1 VA: 0x1ABD5A0
	|-DictionaryForSaveData<int, int>..ctor
	|
	|-RVA: 0x1ABF1E0 Offset: 0x1ABF2E1 VA: 0x1ABF1E0
	|-DictionaryForSaveData<object, object>..ctor
	*/
}

