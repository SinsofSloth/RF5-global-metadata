public static class Vector // TypeDefIndex: 3760
{
	// Properties
	[JitIntrinsicAttribute] // RVA: 0x108A50 Offset: 0x108B51 VA: 0x108A50
	public static bool IsHardwareAccelerated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561370 Offset: 0x2561471 VA: 0x2561370
	|-Vector.Equals<byte>
	|
	|-RVA: 0x2561430 Offset: 0x2561531 VA: 0x2561430
	|-Vector.Equals<ushort>
	*/

	// RVA: 0x1BDFF60 Offset: 0x1BE0061 VA: 0x1BDFF60
	public static bool get_IsHardwareAccelerated() { }

	// RVA: -1 Offset: -1
	public static Vector<byte> AsVectorByte<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561190 Offset: 0x2561291 VA: 0x2561190
	|-Vector.AsVectorByte<uint>
	*/

	[CLSCompliantAttribute] // RVA: 0x108A00 Offset: 0x108B01 VA: 0x108A00
	// RVA: -1 Offset: -1
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561230 Offset: 0x2561331 VA: 0x2561230
	|-Vector.AsVectorUInt64<byte>
	|
	|-RVA: 0x25612D0 Offset: 0x25613D1 VA: 0x25612D0
	|-Vector.AsVectorUInt64<ushort>
	*/
}

