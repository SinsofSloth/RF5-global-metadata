public sealed class NonGenericListFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5374
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0470 Offset: 0x2CE0571 VA: 0x2CE0470
	|-NonGenericListFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0970 Offset: 0x2CE0A71 VA: 0x2CE0970
	|-NonGenericListFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE0C70 Offset: 0x2CE0D71 VA: 0x2CE0C70
	|-NonGenericListFormatter<object>..ctor
	*/
}

