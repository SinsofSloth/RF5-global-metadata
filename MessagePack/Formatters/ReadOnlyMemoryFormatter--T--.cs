public sealed class ReadOnlyMemoryFormatter<T> : IMessagePackFormatter<ReadOnlyMemory<T>>, IMessagePackFormatter // TypeDefIndex: 5352
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ReadOnlyMemory<T> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285D8C0 Offset: 0x285D9C1 VA: 0x285D8C0
	|-ReadOnlyMemoryFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public ReadOnlyMemory<T> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285DAC0 Offset: 0x285DBC1 VA: 0x285DAC0
	|-ReadOnlyMemoryFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285DC00 Offset: 0x285DD01 VA: 0x285DC00
	|-ReadOnlyMemoryFormatter<object>..ctor
	*/
}

