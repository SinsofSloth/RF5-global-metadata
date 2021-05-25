public sealed class MemoryFormatter<T> : IMessagePackFormatter<Memory<T>>, IMessagePackFormatter // TypeDefIndex: 5351
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Memory<T> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF8C0 Offset: 0x2CDF9C1 VA: 0x2CDF8C0
	|-MemoryFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Memory<T> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDFA20 Offset: 0x2CDFB21 VA: 0x2CDFA20
	|-MemoryFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDFB60 Offset: 0x2CDFC61 VA: 0x2CDFB60
	|-MemoryFormatter<object>..ctor
	*/
}

