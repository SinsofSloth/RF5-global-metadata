public sealed class StaticNullableFormatter<T> : IMessagePackFormatter<Nullable<T>>, IMessagePackFormatter // TypeDefIndex: 5419
{
	// Fields
	private readonly IMessagePackFormatter<T> underlyingFormatter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IMessagePackFormatter<T> underlyingFormatter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285EB80 Offset: 0x285EC81 VA: 0x285EB80
	|-StaticNullableFormatter<ArraySegment<byte>>..ctor
	|
	|-RVA: 0x285EE50 Offset: 0x285EF51 VA: 0x285EE50
	|-StaticNullableFormatter<ReadOnlySequence<byte>>..ctor
	|
	|-RVA: 0x285F170 Offset: 0x285F271 VA: 0x285F170
	|-StaticNullableFormatter<DateTime>..ctor
	|
	|-RVA: 0x285F430 Offset: 0x285F531 VA: 0x285F430
	|-StaticNullableFormatter<DateTimeOffset>..ctor
	|
	|-RVA: 0x285F700 Offset: 0x285F801 VA: 0x285F700
	|-StaticNullableFormatter<Decimal>..ctor
	|
	|-RVA: 0x285F9D0 Offset: 0x285FAD1 VA: 0x285F9D0
	|-StaticNullableFormatter<Guid>..ctor
	|
	|-RVA: 0x285FCA0 Offset: 0x285FDA1 VA: 0x285FCA0
	|-StaticNullableFormatter<Int32Enum>..ctor
	|-StaticNullableFormatter<GradientMode>..ctor
	|-StaticNullableFormatter<WrapMode>..ctor
	|
	|-RVA: 0x285FF40 Offset: 0x2860041 VA: 0x285FF40
	|-StaticNullableFormatter<Memory<byte>>..ctor
	|
	|-RVA: 0x2860210 Offset: 0x2860311 VA: 0x2860210
	|-StaticNullableFormatter<BigInteger>..ctor
	|
	|-RVA: 0x28604E0 Offset: 0x28605E1 VA: 0x28604E0
	|-StaticNullableFormatter<Complex>..ctor
	|
	|-RVA: 0x28607A0 Offset: 0x28608A1 VA: 0x28607A0
	|-StaticNullableFormatter<ReadOnlyMemory<byte>>..ctor
	|
	|-RVA: 0x2860A70 Offset: 0x2860B71 VA: 0x2860A70
	|-StaticNullableFormatter<TimeSpan>..ctor
	|
	|-RVA: 0x2860D30 Offset: 0x2860E31 VA: 0x2860D30
	|-StaticNullableFormatter<Bounds>..ctor
	|
	|-RVA: 0x2861040 Offset: 0x2861141 VA: 0x2861040
	|-StaticNullableFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x2861350 Offset: 0x2861451 VA: 0x2861350
	|-StaticNullableFormatter<Color32>..ctor
	|
	|-RVA: 0x28615F0 Offset: 0x28616F1 VA: 0x28615F0
	|-StaticNullableFormatter<Color>..ctor
	|
	|-RVA: 0x28618D0 Offset: 0x28619D1 VA: 0x28618D0
	|-StaticNullableFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x2861B90 Offset: 0x2861C91 VA: 0x2861B90
	|-StaticNullableFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x2861E90 Offset: 0x2861F91 VA: 0x2861E90
	|-StaticNullableFormatter<Keyframe>..ctor
	|
	|-RVA: 0x28621B0 Offset: 0x28622B1 VA: 0x28621B0
	|-StaticNullableFormatter<LayerMask>..ctor
	|
	|-RVA: 0x2862450 Offset: 0x2862551 VA: 0x2862450
	|-StaticNullableFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x28627D0 Offset: 0x28628D1 VA: 0x28627D0
	|-StaticNullableFormatter<Quaternion>..ctor
	|
	|-RVA: 0x2862AB0 Offset: 0x2862BB1 VA: 0x2862AB0
	|-StaticNullableFormatter<RangeInt>..ctor
	|
	|-RVA: 0x2862D70 Offset: 0x2862E71 VA: 0x2862D70
	|-StaticNullableFormatter<Rect>..ctor
	|
	|-RVA: 0x2863050 Offset: 0x2863151 VA: 0x2863050
	|-StaticNullableFormatter<RectInt>..ctor
	|
	|-RVA: 0x2863320 Offset: 0x2863421 VA: 0x2863320
	|-StaticNullableFormatter<Vector2>..ctor
	|
	|-RVA: 0x28635E0 Offset: 0x28636E1 VA: 0x28635E0
	|-StaticNullableFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x28638A0 Offset: 0x28639A1 VA: 0x28638A0
	|-StaticNullableFormatter<Vector3>..ctor
	|
	|-RVA: 0x2863B70 Offset: 0x2863C71 VA: 0x2863B70
	|-StaticNullableFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x2863E30 Offset: 0x2863F31 VA: 0x2863E30
	|-StaticNullableFormatter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<T> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285EBC0 Offset: 0x285ECC1 VA: 0x285EBC0
	|-StaticNullableFormatter<ArraySegment<byte>>.Serialize
	|
	|-RVA: 0x285EE90 Offset: 0x285EF91 VA: 0x285EE90
	|-StaticNullableFormatter<ReadOnlySequence<byte>>.Serialize
	|
	|-RVA: 0x285F1B0 Offset: 0x285F2B1 VA: 0x285F1B0
	|-StaticNullableFormatter<DateTime>.Serialize
	|
	|-RVA: 0x285F470 Offset: 0x285F571 VA: 0x285F470
	|-StaticNullableFormatter<DateTimeOffset>.Serialize
	|
	|-RVA: 0x285F740 Offset: 0x285F841 VA: 0x285F740
	|-StaticNullableFormatter<Decimal>.Serialize
	|
	|-RVA: 0x285FA10 Offset: 0x285FB11 VA: 0x285FA10
	|-StaticNullableFormatter<Guid>.Serialize
	|
	|-RVA: 0x285FCE0 Offset: 0x285FDE1 VA: 0x285FCE0
	|-StaticNullableFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x285FF80 Offset: 0x2860081 VA: 0x285FF80
	|-StaticNullableFormatter<Memory<byte>>.Serialize
	|
	|-RVA: 0x2860250 Offset: 0x2860351 VA: 0x2860250
	|-StaticNullableFormatter<BigInteger>.Serialize
	|
	|-RVA: 0x2860520 Offset: 0x2860621 VA: 0x2860520
	|-StaticNullableFormatter<Complex>.Serialize
	|
	|-RVA: 0x28607E0 Offset: 0x28608E1 VA: 0x28607E0
	|-StaticNullableFormatter<ReadOnlyMemory<byte>>.Serialize
	|
	|-RVA: 0x2860AB0 Offset: 0x2860BB1 VA: 0x2860AB0
	|-StaticNullableFormatter<TimeSpan>.Serialize
	|
	|-RVA: 0x2860D70 Offset: 0x2860E71 VA: 0x2860D70
	|-StaticNullableFormatter<Bounds>.Serialize
	|
	|-RVA: 0x2861080 Offset: 0x2861181 VA: 0x2861080
	|-StaticNullableFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x2861390 Offset: 0x2861491 VA: 0x2861390
	|-StaticNullableFormatter<Color32>.Serialize
	|
	|-RVA: 0x2861630 Offset: 0x2861731 VA: 0x2861630
	|-StaticNullableFormatter<Color>.Serialize
	|
	|-RVA: 0x2861910 Offset: 0x2861A11 VA: 0x2861910
	|-StaticNullableFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x2861BD0 Offset: 0x2861CD1 VA: 0x2861BD0
	|-StaticNullableFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x2861ED0 Offset: 0x2861FD1 VA: 0x2861ED0
	|-StaticNullableFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x28621F0 Offset: 0x28622F1 VA: 0x28621F0
	|-StaticNullableFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x2862490 Offset: 0x2862591 VA: 0x2862490
	|-StaticNullableFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x2862810 Offset: 0x2862911 VA: 0x2862810
	|-StaticNullableFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x2862AF0 Offset: 0x2862BF1 VA: 0x2862AF0
	|-StaticNullableFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x2862DB0 Offset: 0x2862EB1 VA: 0x2862DB0
	|-StaticNullableFormatter<Rect>.Serialize
	|
	|-RVA: 0x2863090 Offset: 0x2863191 VA: 0x2863090
	|-StaticNullableFormatter<RectInt>.Serialize
	|
	|-RVA: 0x2863360 Offset: 0x2863461 VA: 0x2863360
	|-StaticNullableFormatter<Vector2>.Serialize
	|
	|-RVA: 0x2863620 Offset: 0x2863721 VA: 0x2863620
	|-StaticNullableFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x28638E0 Offset: 0x28639E1 VA: 0x28638E0
	|-StaticNullableFormatter<Vector3>.Serialize
	|
	|-RVA: 0x2863BB0 Offset: 0x2863CB1 VA: 0x2863BB0
	|-StaticNullableFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x2863E70 Offset: 0x2863F71 VA: 0x2863E70
	|-StaticNullableFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Nullable<T> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285ECD0 Offset: 0x285EDD1 VA: 0x285ECD0
	|-StaticNullableFormatter<ArraySegment<byte>>.Deserialize
	|
	|-RVA: 0x285EFC0 Offset: 0x285F0C1 VA: 0x285EFC0
	|-StaticNullableFormatter<ReadOnlySequence<byte>>.Deserialize
	|
	|-RVA: 0x285F2D0 Offset: 0x285F3D1 VA: 0x285F2D0
	|-StaticNullableFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x285F580 Offset: 0x285F681 VA: 0x285F580
	|-StaticNullableFormatter<DateTimeOffset>.Deserialize
	|
	|-RVA: 0x285F850 Offset: 0x285F951 VA: 0x285F850
	|-StaticNullableFormatter<Decimal>.Deserialize
	|
	|-RVA: 0x285FB20 Offset: 0x285FC21 VA: 0x285FB20
	|-StaticNullableFormatter<Guid>.Deserialize
	|
	|-RVA: 0x285FDF0 Offset: 0x285FEF1 VA: 0x285FDF0
	|-StaticNullableFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x2860090 Offset: 0x2860191 VA: 0x2860090
	|-StaticNullableFormatter<Memory<byte>>.Deserialize
	|
	|-RVA: 0x2860360 Offset: 0x2860461 VA: 0x2860360
	|-StaticNullableFormatter<BigInteger>.Deserialize
	|
	|-RVA: 0x2860630 Offset: 0x2860731 VA: 0x2860630
	|-StaticNullableFormatter<Complex>.Deserialize
	|
	|-RVA: 0x28608F0 Offset: 0x28609F1 VA: 0x28608F0
	|-StaticNullableFormatter<ReadOnlyMemory<byte>>.Deserialize
	|
	|-RVA: 0x2860BD0 Offset: 0x2860CD1 VA: 0x2860BD0
	|-StaticNullableFormatter<TimeSpan>.Deserialize
	|
	|-RVA: 0x2860EA0 Offset: 0x2860FA1 VA: 0x2860EA0
	|-StaticNullableFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x28611B0 Offset: 0x28612B1 VA: 0x28611B0
	|-StaticNullableFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x28614A0 Offset: 0x28615A1 VA: 0x28614A0
	|-StaticNullableFormatter<Color32>.Deserialize
	|
	|-RVA: 0x2861760 Offset: 0x2861861 VA: 0x2861760
	|-StaticNullableFormatter<Color>.Deserialize
	|
	|-RVA: 0x2861A30 Offset: 0x2861B31 VA: 0x2861A30
	|-StaticNullableFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x2861D00 Offset: 0x2861E01 VA: 0x2861D00
	|-StaticNullableFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x2862010 Offset: 0x2862111 VA: 0x2862010
	|-StaticNullableFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x2862300 Offset: 0x2862401 VA: 0x2862300
	|-StaticNullableFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x28625E0 Offset: 0x28626E1 VA: 0x28625E0
	|-StaticNullableFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x2862940 Offset: 0x2862A41 VA: 0x2862940
	|-StaticNullableFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x2862C10 Offset: 0x2862D11 VA: 0x2862C10
	|-StaticNullableFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x2862EE0 Offset: 0x2862FE1 VA: 0x2862EE0
	|-StaticNullableFormatter<Rect>.Deserialize
	|
	|-RVA: 0x28631A0 Offset: 0x28632A1 VA: 0x28631A0
	|-StaticNullableFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x2863480 Offset: 0x2863581 VA: 0x2863480
	|-StaticNullableFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x2863740 Offset: 0x2863841 VA: 0x2863740
	|-StaticNullableFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x2863A10 Offset: 0x2863B11 VA: 0x2863A10
	|-StaticNullableFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x2863CD0 Offset: 0x2863DD1 VA: 0x2863CD0
	|-StaticNullableFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x2863FA0 Offset: 0x28640A1 VA: 0x2863FA0
	|-StaticNullableFormatter<Vector4>.Deserialize
	*/
}

