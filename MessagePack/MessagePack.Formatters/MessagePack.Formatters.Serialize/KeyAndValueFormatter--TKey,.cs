public sealed class KeyAndValueFormatter<TKey, TValue> : IMessagePackFormatter<KeyAndValue<TKey, TValue>>, IMessagePackFormatter // TypeDefIndex: 10169
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, KeyAndValue<TKey, TValue> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E190 Offset: 0x285E291 VA: 0x285E190
	|-KeyAndValueFormatter<object, object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public KeyAndValue<TKey, TValue> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E3B0 Offset: 0x285E4B1 VA: 0x285E3B0
	|-KeyAndValueFormatter<object, object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E720 Offset: 0x285E821 VA: 0x285E720
	|-KeyAndValueFormatter<object, object>..ctor
	*/
}

