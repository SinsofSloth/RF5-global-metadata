public sealed class TupleFormatter<T1> : IMessagePackFormatter<Tuple<T1>>, IMessagePackFormatter // TypeDefIndex: 5501
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Tuple<T1> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28648D0 Offset: 0x28649D1 VA: 0x28648D0
	|-TupleFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Tuple<T1> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2864A50 Offset: 0x2864B51 VA: 0x2864A50
	|-TupleFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2864D10 Offset: 0x2864E11 VA: 0x2864D10
	|-TupleFormatter<object>..ctor
	*/
}

