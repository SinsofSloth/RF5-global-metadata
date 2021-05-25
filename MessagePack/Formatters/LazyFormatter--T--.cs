public sealed class LazyFormatter<T> : IMessagePackFormatter<Lazy<T>>, IMessagePackFormatter // TypeDefIndex: 5435
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Lazy<T> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCD140 Offset: 0x2CCD241 VA: 0x2CCD140
	|-LazyFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Lazy<T> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCD2B0 Offset: 0x2CCD3B1 VA: 0x2CCD2B0
	|-LazyFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCD5C0 Offset: 0x2CCD6C1 VA: 0x2CCD5C0
	|-LazyFormatter<object>..ctor
	*/
}

