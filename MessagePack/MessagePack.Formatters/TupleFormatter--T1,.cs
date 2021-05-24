public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : IMessagePackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7>>, IMessagePackFormatter // TypeDefIndex: 5507
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Tuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2867B80 Offset: 0x2867C81 VA: 0x2867B80
	|-TupleFormatter<object, object, object, object, object, object, object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Tuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28681A0 Offset: 0x28682A1 VA: 0x28681A0
	|-TupleFormatter<object, object, object, object, object, object, object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2868990 Offset: 0x2868A91 VA: 0x2868990
	|-TupleFormatter<object, object, object, object, object, object, object>..ctor
	*/
}

