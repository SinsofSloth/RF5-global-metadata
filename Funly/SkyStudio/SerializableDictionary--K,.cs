[DefaultMemberAttribute] // RVA: 0x1493F0 Offset: 0x1494F1 VA: 0x1493F0
[Serializable]
public class SerializableDictionary<K, V> : ISerializationCallbackReceiver // TypeDefIndex: 9687
{
	// Fields
	public Dictionary<K, V> dict; // 0x0
	[SerializeField] // RVA: 0x17EAB0 Offset: 0x17EBB1 VA: 0x17EAB0
	public List<K> m_Keys; // 0x0
	[SerializeField] // RVA: 0x17EAC0 Offset: 0x17EBC1 VA: 0x17EAC0
	public List<V> m_Values; // 0x0

	// Properties
	public V Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22C60 Offset: 0x2D22D61 VA: 0x2D22C60
	|-SerializableDictionary<object, bool>.Clear
	|
	|-RVA: 0x2D23240 Offset: 0x2D23341 VA: 0x2D23240
	|-SerializableDictionary<object, object>.Clear
	|-SerializableDictionary<string, BoolKeyframeGroup>.Clear
	|-SerializableDictionary<string, ColorKeyframeGroup>.Clear
	|-SerializableDictionary<string, NumberKeyframeGroup>.Clear
	|-SerializableDictionary<string, SpherePointKeyframeGroup>.Clear
	|-SerializableDictionary<string, TextureKeyframeGroup>.Clear
	*/

	// RVA: -1 Offset: -1
	public V get_Item(K aKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22C90 Offset: 0x2D22D91 VA: 0x2D22C90
	|-SerializableDictionary<object, bool>.get_Item
	|-SerializableDictionary<string, bool>.get_Item
	|
	|-RVA: 0x2D23270 Offset: 0x2D23371 VA: 0x2D23270
	|-SerializableDictionary<object, object>.get_Item
	|-SerializableDictionary<string, BoolKeyframeGroup>.get_Item
	|-SerializableDictionary<string, ColorKeyframeGroup>.get_Item
	|-SerializableDictionary<string, NumberKeyframeGroup>.get_Item
	|-SerializableDictionary<string, SpherePointKeyframeGroup>.get_Item
	|-SerializableDictionary<string, TextureKeyframeGroup>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(K aKey, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22CC0 Offset: 0x2D22DC1 VA: 0x2D22CC0
	|-SerializableDictionary<object, bool>.set_Item
	|-SerializableDictionary<string, bool>.set_Item
	|
	|-RVA: 0x2D232A0 Offset: 0x2D233A1 VA: 0x2D232A0
	|-SerializableDictionary<object, object>.set_Item
	|-SerializableDictionary<string, BoolKeyframeGroup>.set_Item
	|-SerializableDictionary<string, ColorKeyframeGroup>.set_Item
	|-SerializableDictionary<string, NumberKeyframeGroup>.set_Item
	|-SerializableDictionary<string, SpherePointKeyframeGroup>.set_Item
	|-SerializableDictionary<string, TextureKeyframeGroup>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22CF0 Offset: 0x2D22DF1 VA: 0x2D22CF0
	|-SerializableDictionary<object, bool>.OnBeforeSerialize
	|-SerializableDictionary<string, bool>.OnBeforeSerialize
	|
	|-RVA: 0x2D232D0 Offset: 0x2D233D1 VA: 0x2D232D0
	|-SerializableDictionary<object, object>.OnBeforeSerialize
	|-SerializableDictionary<string, BoolKeyframeGroup>.OnBeforeSerialize
	|-SerializableDictionary<string, ColorKeyframeGroup>.OnBeforeSerialize
	|-SerializableDictionary<string, NumberKeyframeGroup>.OnBeforeSerialize
	|-SerializableDictionary<string, SpherePointKeyframeGroup>.OnBeforeSerialize
	|-SerializableDictionary<string, TextureKeyframeGroup>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22F80 Offset: 0x2D23081 VA: 0x2D22F80
	|-SerializableDictionary<object, bool>.OnAfterDeserialize
	|-SerializableDictionary<string, bool>.OnAfterDeserialize
	|
	|-RVA: 0x2D23560 Offset: 0x2D23661 VA: 0x2D23560
	|-SerializableDictionary<object, object>.OnAfterDeserialize
	|-SerializableDictionary<string, BoolKeyframeGroup>.OnAfterDeserialize
	|-SerializableDictionary<string, ColorKeyframeGroup>.OnAfterDeserialize
	|-SerializableDictionary<string, NumberKeyframeGroup>.OnAfterDeserialize
	|-SerializableDictionary<string, SpherePointKeyframeGroup>.OnAfterDeserialize
	|-SerializableDictionary<string, TextureKeyframeGroup>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23120 Offset: 0x2D23221 VA: 0x2D23120
	|-SerializableDictionary<object, bool>..ctor
	|-SerializableDictionary<string, bool>..ctor
	|
	|-RVA: 0x2D23700 Offset: 0x2D23801 VA: 0x2D23700
	|-SerializableDictionary<object, object>..ctor
	|-SerializableDictionary<string, BoolKeyframeGroup>..ctor
	|-SerializableDictionary<string, ColorKeyframeGroup>..ctor
	|-SerializableDictionary<string, NumberKeyframeGroup>..ctor
	|-SerializableDictionary<string, SpherePointKeyframeGroup>..ctor
	|-SerializableDictionary<string, TextureKeyframeGroup>..ctor
	*/
}

