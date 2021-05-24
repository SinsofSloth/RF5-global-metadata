public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : IMessagePackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IMessagePackFormatter // TypeDefIndex: 5515
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ValueTuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286D170 Offset: 0x286D271 VA: 0x286D170
	|-ValueTupleFormatter<object, object, object, object, object, object, object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public ValueTuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286D6C0 Offset: 0x286D7C1 VA: 0x286D6C0
	|-ValueTupleFormatter<object, object, object, object, object, object, object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286DEA0 Offset: 0x286DFA1 VA: 0x286DEA0
	|-ValueTupleFormatter<object, object, object, object, object, object, object>..ctor
	*/
}

