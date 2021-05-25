public sealed class ValueTupleFormatter<T1> : IMessagePackFormatter<ValueTuple<T1>>, IMessagePackFormatter // TypeDefIndex: 5509
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ValueTuple<T1> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286A2F0 Offset: 0x286A3F1 VA: 0x286A2F0
	|-ValueTupleFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public ValueTuple<T1> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286A430 Offset: 0x286A531 VA: 0x286A430
	|-ValueTupleFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286A680 Offset: 0x286A781 VA: 0x286A680
	|-ValueTupleFormatter<object>..ctor
	*/
}

