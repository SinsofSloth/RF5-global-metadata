public sealed class ThreeDimensionalArrayFormatter<T> : IMessagePackFormatter<T[,,]>, IMessagePackFormatter // TypeDefIndex: 5414
{
	// Fields
	private const int ArrayLength = 4;

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[,,] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2864110 Offset: 0x2864211 VA: 0x2864110
	|-ThreeDimensionalArrayFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[,,] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2864490 Offset: 0x2864591 VA: 0x2864490
	|-ThreeDimensionalArrayFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28648B0 Offset: 0x28649B1 VA: 0x28648B0
	|-ThreeDimensionalArrayFormatter<object>..ctor
	*/
}

