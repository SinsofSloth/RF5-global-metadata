public sealed class NonGenericDictionaryFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5378
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDFB80 Offset: 0x2CDFC81 VA: 0x2CDFB80
	|-NonGenericDictionaryFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0050 Offset: 0x2CE0151 VA: 0x2CE0050
	|-NonGenericDictionaryFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0450 Offset: 0x2CE0551 VA: 0x2CE0450
	|-NonGenericDictionaryFormatter<object>..ctor
	*/
}

