public interface IMessagePackFormatter<T> : IMessagePackFormatter // TypeDefIndex: 5411
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Serialize(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMessagePackFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMessagePackFormatter<object>.Deserialize
	*/
}

