public sealed class KeyValuePairFormatter<TKey, TValue> : IMessagePackFormatter<KeyValuePair<TKey, TValue>>, IMessagePackFormatter // TypeDefIndex: 5430
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, KeyValuePair<TKey, TValue> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCCBF0 Offset: 0x2CCCCF1 VA: 0x2CCCBF0
	|-KeyValuePairFormatter<object, object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public KeyValuePair<TKey, TValue> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCCDE0 Offset: 0x2CCCEE1 VA: 0x2CCCDE0
	|-KeyValuePairFormatter<object, object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCD0F0 Offset: 0x2CCD1F1 VA: 0x2CCD0F0
	|-KeyValuePairFormatter<object, object>..ctor
	*/
}

