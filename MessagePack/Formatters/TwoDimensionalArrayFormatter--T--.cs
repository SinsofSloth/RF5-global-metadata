public sealed class TwoDimensionalArrayFormatter<T> : IMessagePackFormatter<T[,]>, IMessagePackFormatter // TypeDefIndex: 5413
{
	// Fields
	private const int ArrayLength = 3;

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[,] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2869970 Offset: 0x2869A71 VA: 0x2869970
	|-TwoDimensionalArrayFormatter<object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[,] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2869C50 Offset: 0x2869D51 VA: 0x2869C50
	|-TwoDimensionalArrayFormatter<object>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x286A000 Offset: 0x286A101 VA: 0x286A000
	|-TwoDimensionalArrayFormatter<object>..ctor
	*/
}

