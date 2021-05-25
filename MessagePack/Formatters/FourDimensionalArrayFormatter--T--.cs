public sealed class FourDimensionalArrayFormatter<T> : IMessagePackFormatter<T[,,,]>, IMessagePackFormatter // TypeDefIndex: 5415
{
	// Fields
	private const int ArrayLength = 5;

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[,,,] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE730 Offset: 0x27DE831 VA: 0x27DE730
	|-FourDimensionalArrayFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[,,,] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DEB00 Offset: 0x27DEC01 VA: 0x27DEB00
	|-FourDimensionalArrayFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DEF10 Offset: 0x27DF011 VA: 0x27DEF10
	|-FourDimensionalArrayFormatter<object>..ctor
	*/
}

