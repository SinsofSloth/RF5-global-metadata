public sealed class IgnoreFormatter<T> : IMessagePackFormatter<T>, IMessagePackFormatter // TypeDefIndex: 5412
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBA00 Offset: 0x2CCBB01 VA: 0x2CCBA00
	|-IgnoreFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBA10 Offset: 0x2CCBB11 VA: 0x2CCBA10
	|-IgnoreFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCBA30 Offset: 0x2CCBB31 VA: 0x2CCBA30
	|-IgnoreFormatter<object>..ctor
	*/
}

