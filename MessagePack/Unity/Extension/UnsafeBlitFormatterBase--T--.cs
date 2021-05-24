public abstract class UnsafeBlitFormatterBase<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter // TypeDefIndex: 5213
{
	// Properties
	protected abstract sbyte TypeCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract sbyte get_TypeCode() { }

	// RVA: -1 Offset: -1
	protected void CopyDeserializeUnsafe(ReadOnlySpan<byte> src, Span<T> dest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3030 Offset: 0x2AD3131 VA: 0x2AD3030
	|-UnsafeBlitFormatterBase<double>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3620 Offset: 0x2AD3721 VA: 0x2AD3620
	|-UnsafeBlitFormatterBase<int>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3C10 Offset: 0x2AD3D11 VA: 0x2AD3C10
	|-UnsafeBlitFormatterBase<float>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4200 Offset: 0x2AD4301 VA: 0x2AD4200
	|-UnsafeBlitFormatterBase<Bounds>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD47F0 Offset: 0x2AD48F1 VA: 0x2AD47F0
	|-UnsafeBlitFormatterBase<Color>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4DE0 Offset: 0x2AD4EE1 VA: 0x2AD4DE0
	|-UnsafeBlitFormatterBase<Quaternion>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD53D0 Offset: 0x2AD54D1 VA: 0x2AD53D0
	|-UnsafeBlitFormatterBase<Rect>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD59C0 Offset: 0x2AD5AC1 VA: 0x2AD59C0
	|-UnsafeBlitFormatterBase<Vector2>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD5FB0 Offset: 0x2AD60B1 VA: 0x2AD5FB0
	|-UnsafeBlitFormatterBase<Vector3>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD65A0 Offset: 0x2AD66A1 VA: 0x2AD65A0
	|-UnsafeBlitFormatterBase<Vector4>.CopyDeserializeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD30F0 Offset: 0x2AD31F1 VA: 0x2AD30F0
	|-UnsafeBlitFormatterBase<double>.Serialize
	|
	|-RVA: 0x2AD36E0 Offset: 0x2AD37E1 VA: 0x2AD36E0
	|-UnsafeBlitFormatterBase<int>.Serialize
	|
	|-RVA: 0x2AD3CD0 Offset: 0x2AD3DD1 VA: 0x2AD3CD0
	|-UnsafeBlitFormatterBase<float>.Serialize
	|
	|-RVA: 0x2AD42C0 Offset: 0x2AD43C1 VA: 0x2AD42C0
	|-UnsafeBlitFormatterBase<Bounds>.Serialize
	|
	|-RVA: 0x2AD48B0 Offset: 0x2AD49B1 VA: 0x2AD48B0
	|-UnsafeBlitFormatterBase<Color>.Serialize
	|
	|-RVA: 0x2AD4EA0 Offset: 0x2AD4FA1 VA: 0x2AD4EA0
	|-UnsafeBlitFormatterBase<Quaternion>.Serialize
	|
	|-RVA: 0x2AD5490 Offset: 0x2AD5591 VA: 0x2AD5490
	|-UnsafeBlitFormatterBase<Rect>.Serialize
	|
	|-RVA: 0x2AD5A80 Offset: 0x2AD5B81 VA: 0x2AD5A80
	|-UnsafeBlitFormatterBase<Vector2>.Serialize
	|
	|-RVA: 0x2AD6070 Offset: 0x2AD6171 VA: 0x2AD6070
	|-UnsafeBlitFormatterBase<Vector3>.Serialize
	|
	|-RVA: 0x2AD6660 Offset: 0x2AD6761 VA: 0x2AD6660
	|-UnsafeBlitFormatterBase<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD32D0 Offset: 0x2AD33D1 VA: 0x2AD32D0
	|-UnsafeBlitFormatterBase<double>.Deserialize
	|
	|-RVA: 0x2AD38C0 Offset: 0x2AD39C1 VA: 0x2AD38C0
	|-UnsafeBlitFormatterBase<int>.Deserialize
	|
	|-RVA: 0x2AD3EB0 Offset: 0x2AD3FB1 VA: 0x2AD3EB0
	|-UnsafeBlitFormatterBase<float>.Deserialize
	|
	|-RVA: 0x2AD44A0 Offset: 0x2AD45A1 VA: 0x2AD44A0
	|-UnsafeBlitFormatterBase<Bounds>.Deserialize
	|
	|-RVA: 0x2AD4A90 Offset: 0x2AD4B91 VA: 0x2AD4A90
	|-UnsafeBlitFormatterBase<Color>.Deserialize
	|
	|-RVA: 0x2AD5080 Offset: 0x2AD5181 VA: 0x2AD5080
	|-UnsafeBlitFormatterBase<Quaternion>.Deserialize
	|
	|-RVA: 0x2AD5670 Offset: 0x2AD5771 VA: 0x2AD5670
	|-UnsafeBlitFormatterBase<Rect>.Deserialize
	|
	|-RVA: 0x2AD5C60 Offset: 0x2AD5D61 VA: 0x2AD5C60
	|-UnsafeBlitFormatterBase<Vector2>.Deserialize
	|
	|-RVA: 0x2AD6250 Offset: 0x2AD6351 VA: 0x2AD6250
	|-UnsafeBlitFormatterBase<Vector3>.Deserialize
	|
	|-RVA: 0x2AD6840 Offset: 0x2AD6941 VA: 0x2AD6840
	|-UnsafeBlitFormatterBase<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3600 Offset: 0x2AD3701 VA: 0x2AD3600
	|-UnsafeBlitFormatterBase<double>..ctor
	|
	|-RVA: 0x2AD3BF0 Offset: 0x2AD3CF1 VA: 0x2AD3BF0
	|-UnsafeBlitFormatterBase<int>..ctor
	|
	|-RVA: 0x2AD41E0 Offset: 0x2AD42E1 VA: 0x2AD41E0
	|-UnsafeBlitFormatterBase<float>..ctor
	|
	|-RVA: 0x2AD47D0 Offset: 0x2AD48D1 VA: 0x2AD47D0
	|-UnsafeBlitFormatterBase<Bounds>..ctor
	|
	|-RVA: 0x2AD4DC0 Offset: 0x2AD4EC1 VA: 0x2AD4DC0
	|-UnsafeBlitFormatterBase<Color>..ctor
	|
	|-RVA: 0x2AD53B0 Offset: 0x2AD54B1 VA: 0x2AD53B0
	|-UnsafeBlitFormatterBase<Quaternion>..ctor
	|
	|-RVA: 0x2AD59A0 Offset: 0x2AD5AA1 VA: 0x2AD59A0
	|-UnsafeBlitFormatterBase<Rect>..ctor
	|
	|-RVA: 0x2AD5F90 Offset: 0x2AD6091 VA: 0x2AD5F90
	|-UnsafeBlitFormatterBase<Vector2>..ctor
	|
	|-RVA: 0x2AD6580 Offset: 0x2AD6681 VA: 0x2AD6580
	|-UnsafeBlitFormatterBase<Vector3>..ctor
	|
	|-RVA: 0x2AD6B70 Offset: 0x2AD6C71 VA: 0x2AD6B70
	|-UnsafeBlitFormatterBase<Vector4>..ctor
	*/
}

public abstract class UnsafeBlitFormatterBase<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter // TypeDefIndex: 5213
{
	// Properties
	protected abstract sbyte TypeCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract sbyte get_TypeCode() { }

	// RVA: -1 Offset: -1
	protected void CopyDeserializeUnsafe(ReadOnlySpan<byte> src, Span<T> dest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3030 Offset: 0x2AD3131 VA: 0x2AD3030
	|-UnsafeBlitFormatterBase<double>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3620 Offset: 0x2AD3721 VA: 0x2AD3620
	|-UnsafeBlitFormatterBase<int>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3C10 Offset: 0x2AD3D11 VA: 0x2AD3C10
	|-UnsafeBlitFormatterBase<float>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4200 Offset: 0x2AD4301 VA: 0x2AD4200
	|-UnsafeBlitFormatterBase<Bounds>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD47F0 Offset: 0x2AD48F1 VA: 0x2AD47F0
	|-UnsafeBlitFormatterBase<Color>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4DE0 Offset: 0x2AD4EE1 VA: 0x2AD4DE0
	|-UnsafeBlitFormatterBase<Quaternion>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD53D0 Offset: 0x2AD54D1 VA: 0x2AD53D0
	|-UnsafeBlitFormatterBase<Rect>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD59C0 Offset: 0x2AD5AC1 VA: 0x2AD59C0
	|-UnsafeBlitFormatterBase<Vector2>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD5FB0 Offset: 0x2AD60B1 VA: 0x2AD5FB0
	|-UnsafeBlitFormatterBase<Vector3>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD65A0 Offset: 0x2AD66A1 VA: 0x2AD65A0
	|-UnsafeBlitFormatterBase<Vector4>.CopyDeserializeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD30F0 Offset: 0x2AD31F1 VA: 0x2AD30F0
	|-UnsafeBlitFormatterBase<double>.Serialize
	|
	|-RVA: 0x2AD36E0 Offset: 0x2AD37E1 VA: 0x2AD36E0
	|-UnsafeBlitFormatterBase<int>.Serialize
	|
	|-RVA: 0x2AD3CD0 Offset: 0x2AD3DD1 VA: 0x2AD3CD0
	|-UnsafeBlitFormatterBase<float>.Serialize
	|
	|-RVA: 0x2AD42C0 Offset: 0x2AD43C1 VA: 0x2AD42C0
	|-UnsafeBlitFormatterBase<Bounds>.Serialize
	|
	|-RVA: 0x2AD48B0 Offset: 0x2AD49B1 VA: 0x2AD48B0
	|-UnsafeBlitFormatterBase<Color>.Serialize
	|
	|-RVA: 0x2AD4EA0 Offset: 0x2AD4FA1 VA: 0x2AD4EA0
	|-UnsafeBlitFormatterBase<Quaternion>.Serialize
	|
	|-RVA: 0x2AD5490 Offset: 0x2AD5591 VA: 0x2AD5490
	|-UnsafeBlitFormatterBase<Rect>.Serialize
	|
	|-RVA: 0x2AD5A80 Offset: 0x2AD5B81 VA: 0x2AD5A80
	|-UnsafeBlitFormatterBase<Vector2>.Serialize
	|
	|-RVA: 0x2AD6070 Offset: 0x2AD6171 VA: 0x2AD6070
	|-UnsafeBlitFormatterBase<Vector3>.Serialize
	|
	|-RVA: 0x2AD6660 Offset: 0x2AD6761 VA: 0x2AD6660
	|-UnsafeBlitFormatterBase<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD32D0 Offset: 0x2AD33D1 VA: 0x2AD32D0
	|-UnsafeBlitFormatterBase<double>.Deserialize
	|
	|-RVA: 0x2AD38C0 Offset: 0x2AD39C1 VA: 0x2AD38C0
	|-UnsafeBlitFormatterBase<int>.Deserialize
	|
	|-RVA: 0x2AD3EB0 Offset: 0x2AD3FB1 VA: 0x2AD3EB0
	|-UnsafeBlitFormatterBase<float>.Deserialize
	|
	|-RVA: 0x2AD44A0 Offset: 0x2AD45A1 VA: 0x2AD44A0
	|-UnsafeBlitFormatterBase<Bounds>.Deserialize
	|
	|-RVA: 0x2AD4A90 Offset: 0x2AD4B91 VA: 0x2AD4A90
	|-UnsafeBlitFormatterBase<Color>.Deserialize
	|
	|-RVA: 0x2AD5080 Offset: 0x2AD5181 VA: 0x2AD5080
	|-UnsafeBlitFormatterBase<Quaternion>.Deserialize
	|
	|-RVA: 0x2AD5670 Offset: 0x2AD5771 VA: 0x2AD5670
	|-UnsafeBlitFormatterBase<Rect>.Deserialize
	|
	|-RVA: 0x2AD5C60 Offset: 0x2AD5D61 VA: 0x2AD5C60
	|-UnsafeBlitFormatterBase<Vector2>.Deserialize
	|
	|-RVA: 0x2AD6250 Offset: 0x2AD6351 VA: 0x2AD6250
	|-UnsafeBlitFormatterBase<Vector3>.Deserialize
	|
	|-RVA: 0x2AD6840 Offset: 0x2AD6941 VA: 0x2AD6840
	|-UnsafeBlitFormatterBase<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3600 Offset: 0x2AD3701 VA: 0x2AD3600
	|-UnsafeBlitFormatterBase<double>..ctor
	|
	|-RVA: 0x2AD3BF0 Offset: 0x2AD3CF1 VA: 0x2AD3BF0
	|-UnsafeBlitFormatterBase<int>..ctor
	|
	|-RVA: 0x2AD41E0 Offset: 0x2AD42E1 VA: 0x2AD41E0
	|-UnsafeBlitFormatterBase<float>..ctor
	|
	|-RVA: 0x2AD47D0 Offset: 0x2AD48D1 VA: 0x2AD47D0
	|-UnsafeBlitFormatterBase<Bounds>..ctor
	|
	|-RVA: 0x2AD4DC0 Offset: 0x2AD4EC1 VA: 0x2AD4DC0
	|-UnsafeBlitFormatterBase<Color>..ctor
	|
	|-RVA: 0x2AD53B0 Offset: 0x2AD54B1 VA: 0x2AD53B0
	|-UnsafeBlitFormatterBase<Quaternion>..ctor
	|
	|-RVA: 0x2AD59A0 Offset: 0x2AD5AA1 VA: 0x2AD59A0
	|-UnsafeBlitFormatterBase<Rect>..ctor
	|
	|-RVA: 0x2AD5F90 Offset: 0x2AD6091 VA: 0x2AD5F90
	|-UnsafeBlitFormatterBase<Vector2>..ctor
	|
	|-RVA: 0x2AD6580 Offset: 0x2AD6681 VA: 0x2AD6580
	|-UnsafeBlitFormatterBase<Vector3>..ctor
	|
	|-RVA: 0x2AD6B70 Offset: 0x2AD6C71 VA: 0x2AD6B70
	|-UnsafeBlitFormatterBase<Vector4>..ctor
	*/
}

public abstract class UnsafeBlitFormatterBase<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter // TypeDefIndex: 5213
{
	// Properties
	protected abstract sbyte TypeCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract sbyte get_TypeCode() { }

	// RVA: -1 Offset: -1
	protected void CopyDeserializeUnsafe(ReadOnlySpan<byte> src, Span<T> dest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3030 Offset: 0x2AD3131 VA: 0x2AD3030
	|-UnsafeBlitFormatterBase<double>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3620 Offset: 0x2AD3721 VA: 0x2AD3620
	|-UnsafeBlitFormatterBase<int>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3C10 Offset: 0x2AD3D11 VA: 0x2AD3C10
	|-UnsafeBlitFormatterBase<float>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4200 Offset: 0x2AD4301 VA: 0x2AD4200
	|-UnsafeBlitFormatterBase<Bounds>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD47F0 Offset: 0x2AD48F1 VA: 0x2AD47F0
	|-UnsafeBlitFormatterBase<Color>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4DE0 Offset: 0x2AD4EE1 VA: 0x2AD4DE0
	|-UnsafeBlitFormatterBase<Quaternion>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD53D0 Offset: 0x2AD54D1 VA: 0x2AD53D0
	|-UnsafeBlitFormatterBase<Rect>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD59C0 Offset: 0x2AD5AC1 VA: 0x2AD59C0
	|-UnsafeBlitFormatterBase<Vector2>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD5FB0 Offset: 0x2AD60B1 VA: 0x2AD5FB0
	|-UnsafeBlitFormatterBase<Vector3>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD65A0 Offset: 0x2AD66A1 VA: 0x2AD65A0
	|-UnsafeBlitFormatterBase<Vector4>.CopyDeserializeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD30F0 Offset: 0x2AD31F1 VA: 0x2AD30F0
	|-UnsafeBlitFormatterBase<double>.Serialize
	|
	|-RVA: 0x2AD36E0 Offset: 0x2AD37E1 VA: 0x2AD36E0
	|-UnsafeBlitFormatterBase<int>.Serialize
	|
	|-RVA: 0x2AD3CD0 Offset: 0x2AD3DD1 VA: 0x2AD3CD0
	|-UnsafeBlitFormatterBase<float>.Serialize
	|
	|-RVA: 0x2AD42C0 Offset: 0x2AD43C1 VA: 0x2AD42C0
	|-UnsafeBlitFormatterBase<Bounds>.Serialize
	|
	|-RVA: 0x2AD48B0 Offset: 0x2AD49B1 VA: 0x2AD48B0
	|-UnsafeBlitFormatterBase<Color>.Serialize
	|
	|-RVA: 0x2AD4EA0 Offset: 0x2AD4FA1 VA: 0x2AD4EA0
	|-UnsafeBlitFormatterBase<Quaternion>.Serialize
	|
	|-RVA: 0x2AD5490 Offset: 0x2AD5591 VA: 0x2AD5490
	|-UnsafeBlitFormatterBase<Rect>.Serialize
	|
	|-RVA: 0x2AD5A80 Offset: 0x2AD5B81 VA: 0x2AD5A80
	|-UnsafeBlitFormatterBase<Vector2>.Serialize
	|
	|-RVA: 0x2AD6070 Offset: 0x2AD6171 VA: 0x2AD6070
	|-UnsafeBlitFormatterBase<Vector3>.Serialize
	|
	|-RVA: 0x2AD6660 Offset: 0x2AD6761 VA: 0x2AD6660
	|-UnsafeBlitFormatterBase<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD32D0 Offset: 0x2AD33D1 VA: 0x2AD32D0
	|-UnsafeBlitFormatterBase<double>.Deserialize
	|
	|-RVA: 0x2AD38C0 Offset: 0x2AD39C1 VA: 0x2AD38C0
	|-UnsafeBlitFormatterBase<int>.Deserialize
	|
	|-RVA: 0x2AD3EB0 Offset: 0x2AD3FB1 VA: 0x2AD3EB0
	|-UnsafeBlitFormatterBase<float>.Deserialize
	|
	|-RVA: 0x2AD44A0 Offset: 0x2AD45A1 VA: 0x2AD44A0
	|-UnsafeBlitFormatterBase<Bounds>.Deserialize
	|
	|-RVA: 0x2AD4A90 Offset: 0x2AD4B91 VA: 0x2AD4A90
	|-UnsafeBlitFormatterBase<Color>.Deserialize
	|
	|-RVA: 0x2AD5080 Offset: 0x2AD5181 VA: 0x2AD5080
	|-UnsafeBlitFormatterBase<Quaternion>.Deserialize
	|
	|-RVA: 0x2AD5670 Offset: 0x2AD5771 VA: 0x2AD5670
	|-UnsafeBlitFormatterBase<Rect>.Deserialize
	|
	|-RVA: 0x2AD5C60 Offset: 0x2AD5D61 VA: 0x2AD5C60
	|-UnsafeBlitFormatterBase<Vector2>.Deserialize
	|
	|-RVA: 0x2AD6250 Offset: 0x2AD6351 VA: 0x2AD6250
	|-UnsafeBlitFormatterBase<Vector3>.Deserialize
	|
	|-RVA: 0x2AD6840 Offset: 0x2AD6941 VA: 0x2AD6840
	|-UnsafeBlitFormatterBase<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3600 Offset: 0x2AD3701 VA: 0x2AD3600
	|-UnsafeBlitFormatterBase<double>..ctor
	|
	|-RVA: 0x2AD3BF0 Offset: 0x2AD3CF1 VA: 0x2AD3BF0
	|-UnsafeBlitFormatterBase<int>..ctor
	|
	|-RVA: 0x2AD41E0 Offset: 0x2AD42E1 VA: 0x2AD41E0
	|-UnsafeBlitFormatterBase<float>..ctor
	|
	|-RVA: 0x2AD47D0 Offset: 0x2AD48D1 VA: 0x2AD47D0
	|-UnsafeBlitFormatterBase<Bounds>..ctor
	|
	|-RVA: 0x2AD4DC0 Offset: 0x2AD4EC1 VA: 0x2AD4DC0
	|-UnsafeBlitFormatterBase<Color>..ctor
	|
	|-RVA: 0x2AD53B0 Offset: 0x2AD54B1 VA: 0x2AD53B0
	|-UnsafeBlitFormatterBase<Quaternion>..ctor
	|
	|-RVA: 0x2AD59A0 Offset: 0x2AD5AA1 VA: 0x2AD59A0
	|-UnsafeBlitFormatterBase<Rect>..ctor
	|
	|-RVA: 0x2AD5F90 Offset: 0x2AD6091 VA: 0x2AD5F90
	|-UnsafeBlitFormatterBase<Vector2>..ctor
	|
	|-RVA: 0x2AD6580 Offset: 0x2AD6681 VA: 0x2AD6580
	|-UnsafeBlitFormatterBase<Vector3>..ctor
	|
	|-RVA: 0x2AD6B70 Offset: 0x2AD6C71 VA: 0x2AD6B70
	|-UnsafeBlitFormatterBase<Vector4>..ctor
	*/
}

public abstract class UnsafeBlitFormatterBase<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter // TypeDefIndex: 5213
{
	// Properties
	protected abstract sbyte TypeCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract sbyte get_TypeCode() { }

	// RVA: -1 Offset: -1
	protected void CopyDeserializeUnsafe(ReadOnlySpan<byte> src, Span<T> dest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3030 Offset: 0x2AD3131 VA: 0x2AD3030
	|-UnsafeBlitFormatterBase<double>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3620 Offset: 0x2AD3721 VA: 0x2AD3620
	|-UnsafeBlitFormatterBase<int>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3C10 Offset: 0x2AD3D11 VA: 0x2AD3C10
	|-UnsafeBlitFormatterBase<float>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4200 Offset: 0x2AD4301 VA: 0x2AD4200
	|-UnsafeBlitFormatterBase<Bounds>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD47F0 Offset: 0x2AD48F1 VA: 0x2AD47F0
	|-UnsafeBlitFormatterBase<Color>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4DE0 Offset: 0x2AD4EE1 VA: 0x2AD4DE0
	|-UnsafeBlitFormatterBase<Quaternion>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD53D0 Offset: 0x2AD54D1 VA: 0x2AD53D0
	|-UnsafeBlitFormatterBase<Rect>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD59C0 Offset: 0x2AD5AC1 VA: 0x2AD59C0
	|-UnsafeBlitFormatterBase<Vector2>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD5FB0 Offset: 0x2AD60B1 VA: 0x2AD5FB0
	|-UnsafeBlitFormatterBase<Vector3>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD65A0 Offset: 0x2AD66A1 VA: 0x2AD65A0
	|-UnsafeBlitFormatterBase<Vector4>.CopyDeserializeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD30F0 Offset: 0x2AD31F1 VA: 0x2AD30F0
	|-UnsafeBlitFormatterBase<double>.Serialize
	|
	|-RVA: 0x2AD36E0 Offset: 0x2AD37E1 VA: 0x2AD36E0
	|-UnsafeBlitFormatterBase<int>.Serialize
	|
	|-RVA: 0x2AD3CD0 Offset: 0x2AD3DD1 VA: 0x2AD3CD0
	|-UnsafeBlitFormatterBase<float>.Serialize
	|
	|-RVA: 0x2AD42C0 Offset: 0x2AD43C1 VA: 0x2AD42C0
	|-UnsafeBlitFormatterBase<Bounds>.Serialize
	|
	|-RVA: 0x2AD48B0 Offset: 0x2AD49B1 VA: 0x2AD48B0
	|-UnsafeBlitFormatterBase<Color>.Serialize
	|
	|-RVA: 0x2AD4EA0 Offset: 0x2AD4FA1 VA: 0x2AD4EA0
	|-UnsafeBlitFormatterBase<Quaternion>.Serialize
	|
	|-RVA: 0x2AD5490 Offset: 0x2AD5591 VA: 0x2AD5490
	|-UnsafeBlitFormatterBase<Rect>.Serialize
	|
	|-RVA: 0x2AD5A80 Offset: 0x2AD5B81 VA: 0x2AD5A80
	|-UnsafeBlitFormatterBase<Vector2>.Serialize
	|
	|-RVA: 0x2AD6070 Offset: 0x2AD6171 VA: 0x2AD6070
	|-UnsafeBlitFormatterBase<Vector3>.Serialize
	|
	|-RVA: 0x2AD6660 Offset: 0x2AD6761 VA: 0x2AD6660
	|-UnsafeBlitFormatterBase<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD32D0 Offset: 0x2AD33D1 VA: 0x2AD32D0
	|-UnsafeBlitFormatterBase<double>.Deserialize
	|
	|-RVA: 0x2AD38C0 Offset: 0x2AD39C1 VA: 0x2AD38C0
	|-UnsafeBlitFormatterBase<int>.Deserialize
	|
	|-RVA: 0x2AD3EB0 Offset: 0x2AD3FB1 VA: 0x2AD3EB0
	|-UnsafeBlitFormatterBase<float>.Deserialize
	|
	|-RVA: 0x2AD44A0 Offset: 0x2AD45A1 VA: 0x2AD44A0
	|-UnsafeBlitFormatterBase<Bounds>.Deserialize
	|
	|-RVA: 0x2AD4A90 Offset: 0x2AD4B91 VA: 0x2AD4A90
	|-UnsafeBlitFormatterBase<Color>.Deserialize
	|
	|-RVA: 0x2AD5080 Offset: 0x2AD5181 VA: 0x2AD5080
	|-UnsafeBlitFormatterBase<Quaternion>.Deserialize
	|
	|-RVA: 0x2AD5670 Offset: 0x2AD5771 VA: 0x2AD5670
	|-UnsafeBlitFormatterBase<Rect>.Deserialize
	|
	|-RVA: 0x2AD5C60 Offset: 0x2AD5D61 VA: 0x2AD5C60
	|-UnsafeBlitFormatterBase<Vector2>.Deserialize
	|
	|-RVA: 0x2AD6250 Offset: 0x2AD6351 VA: 0x2AD6250
	|-UnsafeBlitFormatterBase<Vector3>.Deserialize
	|
	|-RVA: 0x2AD6840 Offset: 0x2AD6941 VA: 0x2AD6840
	|-UnsafeBlitFormatterBase<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3600 Offset: 0x2AD3701 VA: 0x2AD3600
	|-UnsafeBlitFormatterBase<double>..ctor
	|
	|-RVA: 0x2AD3BF0 Offset: 0x2AD3CF1 VA: 0x2AD3BF0
	|-UnsafeBlitFormatterBase<int>..ctor
	|
	|-RVA: 0x2AD41E0 Offset: 0x2AD42E1 VA: 0x2AD41E0
	|-UnsafeBlitFormatterBase<float>..ctor
	|
	|-RVA: 0x2AD47D0 Offset: 0x2AD48D1 VA: 0x2AD47D0
	|-UnsafeBlitFormatterBase<Bounds>..ctor
	|
	|-RVA: 0x2AD4DC0 Offset: 0x2AD4EC1 VA: 0x2AD4DC0
	|-UnsafeBlitFormatterBase<Color>..ctor
	|
	|-RVA: 0x2AD53B0 Offset: 0x2AD54B1 VA: 0x2AD53B0
	|-UnsafeBlitFormatterBase<Quaternion>..ctor
	|
	|-RVA: 0x2AD59A0 Offset: 0x2AD5AA1 VA: 0x2AD59A0
	|-UnsafeBlitFormatterBase<Rect>..ctor
	|
	|-RVA: 0x2AD5F90 Offset: 0x2AD6091 VA: 0x2AD5F90
	|-UnsafeBlitFormatterBase<Vector2>..ctor
	|
	|-RVA: 0x2AD6580 Offset: 0x2AD6681 VA: 0x2AD6580
	|-UnsafeBlitFormatterBase<Vector3>..ctor
	|
	|-RVA: 0x2AD6B70 Offset: 0x2AD6C71 VA: 0x2AD6B70
	|-UnsafeBlitFormatterBase<Vector4>..ctor
	*/
}

public abstract class UnsafeBlitFormatterBase<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter // TypeDefIndex: 5213
{
	// Properties
	protected abstract sbyte TypeCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract sbyte get_TypeCode() { }

	// RVA: -1 Offset: -1
	protected void CopyDeserializeUnsafe(ReadOnlySpan<byte> src, Span<T> dest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3030 Offset: 0x2AD3131 VA: 0x2AD3030
	|-UnsafeBlitFormatterBase<double>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3620 Offset: 0x2AD3721 VA: 0x2AD3620
	|-UnsafeBlitFormatterBase<int>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD3C10 Offset: 0x2AD3D11 VA: 0x2AD3C10
	|-UnsafeBlitFormatterBase<float>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4200 Offset: 0x2AD4301 VA: 0x2AD4200
	|-UnsafeBlitFormatterBase<Bounds>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD47F0 Offset: 0x2AD48F1 VA: 0x2AD47F0
	|-UnsafeBlitFormatterBase<Color>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD4DE0 Offset: 0x2AD4EE1 VA: 0x2AD4DE0
	|-UnsafeBlitFormatterBase<Quaternion>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD53D0 Offset: 0x2AD54D1 VA: 0x2AD53D0
	|-UnsafeBlitFormatterBase<Rect>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD59C0 Offset: 0x2AD5AC1 VA: 0x2AD59C0
	|-UnsafeBlitFormatterBase<Vector2>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD5FB0 Offset: 0x2AD60B1 VA: 0x2AD5FB0
	|-UnsafeBlitFormatterBase<Vector3>.CopyDeserializeUnsafe
	|
	|-RVA: 0x2AD65A0 Offset: 0x2AD66A1 VA: 0x2AD65A0
	|-UnsafeBlitFormatterBase<Vector4>.CopyDeserializeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD30F0 Offset: 0x2AD31F1 VA: 0x2AD30F0
	|-UnsafeBlitFormatterBase<double>.Serialize
	|
	|-RVA: 0x2AD36E0 Offset: 0x2AD37E1 VA: 0x2AD36E0
	|-UnsafeBlitFormatterBase<int>.Serialize
	|
	|-RVA: 0x2AD3CD0 Offset: 0x2AD3DD1 VA: 0x2AD3CD0
	|-UnsafeBlitFormatterBase<float>.Serialize
	|
	|-RVA: 0x2AD42C0 Offset: 0x2AD43C1 VA: 0x2AD42C0
	|-UnsafeBlitFormatterBase<Bounds>.Serialize
	|
	|-RVA: 0x2AD48B0 Offset: 0x2AD49B1 VA: 0x2AD48B0
	|-UnsafeBlitFormatterBase<Color>.Serialize
	|
	|-RVA: 0x2AD4EA0 Offset: 0x2AD4FA1 VA: 0x2AD4EA0
	|-UnsafeBlitFormatterBase<Quaternion>.Serialize
	|
	|-RVA: 0x2AD5490 Offset: 0x2AD5591 VA: 0x2AD5490
	|-UnsafeBlitFormatterBase<Rect>.Serialize
	|
	|-RVA: 0x2AD5A80 Offset: 0x2AD5B81 VA: 0x2AD5A80
	|-UnsafeBlitFormatterBase<Vector2>.Serialize
	|
	|-RVA: 0x2AD6070 Offset: 0x2AD6171 VA: 0x2AD6070
	|-UnsafeBlitFormatterBase<Vector3>.Serialize
	|
	|-RVA: 0x2AD6660 Offset: 0x2AD6761 VA: 0x2AD6660
	|-UnsafeBlitFormatterBase<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD32D0 Offset: 0x2AD33D1 VA: 0x2AD32D0
	|-UnsafeBlitFormatterBase<double>.Deserialize
	|
	|-RVA: 0x2AD38C0 Offset: 0x2AD39C1 VA: 0x2AD38C0
	|-UnsafeBlitFormatterBase<int>.Deserialize
	|
	|-RVA: 0x2AD3EB0 Offset: 0x2AD3FB1 VA: 0x2AD3EB0
	|-UnsafeBlitFormatterBase<float>.Deserialize
	|
	|-RVA: 0x2AD44A0 Offset: 0x2AD45A1 VA: 0x2AD44A0
	|-UnsafeBlitFormatterBase<Bounds>.Deserialize
	|
	|-RVA: 0x2AD4A90 Offset: 0x2AD4B91 VA: 0x2AD4A90
	|-UnsafeBlitFormatterBase<Color>.Deserialize
	|
	|-RVA: 0x2AD5080 Offset: 0x2AD5181 VA: 0x2AD5080
	|-UnsafeBlitFormatterBase<Quaternion>.Deserialize
	|
	|-RVA: 0x2AD5670 Offset: 0x2AD5771 VA: 0x2AD5670
	|-UnsafeBlitFormatterBase<Rect>.Deserialize
	|
	|-RVA: 0x2AD5C60 Offset: 0x2AD5D61 VA: 0x2AD5C60
	|-UnsafeBlitFormatterBase<Vector2>.Deserialize
	|
	|-RVA: 0x2AD6250 Offset: 0x2AD6351 VA: 0x2AD6250
	|-UnsafeBlitFormatterBase<Vector3>.Deserialize
	|
	|-RVA: 0x2AD6840 Offset: 0x2AD6941 VA: 0x2AD6840
	|-UnsafeBlitFormatterBase<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3600 Offset: 0x2AD3701 VA: 0x2AD3600
	|-UnsafeBlitFormatterBase<double>..ctor
	|
	|-RVA: 0x2AD3BF0 Offset: 0x2AD3CF1 VA: 0x2AD3BF0
	|-UnsafeBlitFormatterBase<int>..ctor
	|
	|-RVA: 0x2AD41E0 Offset: 0x2AD42E1 VA: 0x2AD41E0
	|-UnsafeBlitFormatterBase<float>..ctor
	|
	|-RVA: 0x2AD47D0 Offset: 0x2AD48D1 VA: 0x2AD47D0
	|-UnsafeBlitFormatterBase<Bounds>..ctor
	|
	|-RVA: 0x2AD4DC0 Offset: 0x2AD4EC1 VA: 0x2AD4DC0
	|-UnsafeBlitFormatterBase<Color>..ctor
	|
	|-RVA: 0x2AD53B0 Offset: 0x2AD54B1 VA: 0x2AD53B0
	|-UnsafeBlitFormatterBase<Quaternion>..ctor
	|
	|-RVA: 0x2AD59A0 Offset: 0x2AD5AA1 VA: 0x2AD59A0
	|-UnsafeBlitFormatterBase<Rect>..ctor
	|
	|-RVA: 0x2AD5F90 Offset: 0x2AD6091 VA: 0x2AD5F90
	|-UnsafeBlitFormatterBase<Vector2>..ctor
	|
	|-RVA: 0x2AD6580 Offset: 0x2AD6681 VA: 0x2AD6580
	|-UnsafeBlitFormatterBase<Vector3>..ctor
	|
	|-RVA: 0x2AD6B70 Offset: 0x2AD6C71 VA: 0x2AD6B70
	|-UnsafeBlitFormatterBase<Vector4>..ctor
	*/
}

