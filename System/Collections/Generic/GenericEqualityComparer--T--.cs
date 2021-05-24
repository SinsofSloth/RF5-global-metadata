[Serializable]
internal class GenericEqualityComparer<T> : EqualityComparer<T> // TypeDefIndex: 1442
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF350 Offset: 0x2EBF451 VA: 0x2EBF350
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.Equals
	|
	|-RVA: 0x2EBF650 Offset: 0x2EBF751 VA: 0x2EBF650
	|-GenericEqualityComparer<bool>.Equals
	|
	|-RVA: 0x2EBF8C0 Offset: 0x2EBF9C1 VA: 0x2EBF8C0
	|-GenericEqualityComparer<byte>.Equals
	|
	|-RVA: 0x2EBFB20 Offset: 0x2EBFC21 VA: 0x2EBFB20
	|-GenericEqualityComparer<char>.Equals
	|
	|-RVA: 0x2EBFD90 Offset: 0x2EBFE91 VA: 0x2EBFD90
	|-GenericEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x2EC0000 Offset: 0x2EC0101 VA: 0x2EC0000
	|-GenericEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x2EC02A0 Offset: 0x2EC03A1 VA: 0x2EC02A0
	|-GenericEqualityComparer<double>.Equals
	|
	|-RVA: 0x2EC0510 Offset: 0x2EC0611 VA: 0x2EC0510
	|-GenericEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x2EC07B0 Offset: 0x2EC08B1 VA: 0x2EC07B0
	|-GenericEqualityComparer<short>.Equals
	|
	|-RVA: 0x2EC0A20 Offset: 0x2EC0B21 VA: 0x2EC0A20
	|-GenericEqualityComparer<int>.Equals
	|
	|-RVA: 0x2EC0C90 Offset: 0x2EC0D91 VA: 0x2EC0C90
	|-GenericEqualityComparer<long>.Equals
	|
	|-RVA: 0x2EC0F00 Offset: 0x2EC1001 VA: 0x2EC0F00
	|-GenericEqualityComparer<object>.Equals
	|
	|-RVA: 0x2EC13B0 Offset: 0x2EC14B1 VA: 0x2EC13B0
	|-GenericEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x2EC1610 Offset: 0x2EC1711 VA: 0x2EC1610
	|-GenericEqualityComparer<float>.Equals
	|
	|-RVA: 0x2EC1880 Offset: 0x2EC1981 VA: 0x2EC1880
	|-GenericEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x2EC1AF0 Offset: 0x2EC1BF1 VA: 0x2EC1AF0
	|-GenericEqualityComparer<uint>.Equals
	|
	|-RVA: 0x2EC1D60 Offset: 0x2EC1E61 VA: 0x2EC1D60
	|-GenericEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x2EC1FD0 Offset: 0x2EC20D1 VA: 0x2EC1FD0
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>.Equals
	|
	|-RVA: 0x2EC24D0 Offset: 0x2EC25D1 VA: 0x2EC24D0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x2EC29D0 Offset: 0x2EC2AD1 VA: 0x2EC29D0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>.Equals
	|
	|-RVA: 0x2EC2EF0 Offset: 0x2EC2FF1 VA: 0x2EC2EF0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>.Equals
	|
	|-RVA: 0x2EC3410 Offset: 0x2EC3511 VA: 0x2EC3410
	|-GenericEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x2EC3930 Offset: 0x2EC3A31 VA: 0x2EC3930
	|-GenericEqualityComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x2EC3E50 Offset: 0x2EC3F51 VA: 0x2EC3E50
	|-GenericEqualityComparer<ValueTuple<float, float>>.Equals
	|
	|-RVA: 0x2EC4390 Offset: 0x2EC4491 VA: 0x2EC4390
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Equals
	|
	|-RVA: 0x2EC4910 Offset: 0x2EC4A11 VA: 0x2EC4910
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Equals
	|
	|-RVA: 0x2EC4FC0 Offset: 0x2EC50C1 VA: 0x2EC4FC0
	|-GenericEqualityComparer<BoneWeight>.Equals
	|
	|-RVA: 0x2EC5250 Offset: 0x2EC5351 VA: 0x2EC5250
	|-GenericEqualityComparer<Bounds>.Equals
	|
	|-RVA: 0x2EC54E0 Offset: 0x2EC55E1 VA: 0x2EC54E0
	|-GenericEqualityComparer<BoundsInt>.Equals
	|
	|-RVA: 0x2EC5770 Offset: 0x2EC5871 VA: 0x2EC5770
	|-GenericEqualityComparer<Color>.Equals
	|
	|-RVA: 0x2EC5A30 Offset: 0x2EC5B31 VA: 0x2EC5A30
	|-GenericEqualityComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x2EC5CF0 Offset: 0x2EC5DF1 VA: 0x2EC5CF0
	|-GenericEqualityComparer<Playable>.Equals
	|
	|-RVA: 0x2EC5FE0 Offset: 0x2EC60E1 VA: 0x2EC5FE0
	|-GenericEqualityComparer<Edge>.Equals
	|
	|-RVA: 0x2EC6250 Offset: 0x2EC6351 VA: 0x2EC6250
	|-GenericEqualityComparer<IntVec3>.Equals
	|
	|-RVA: 0x2EC6510 Offset: 0x2EC6611 VA: 0x2EC6510
	|-GenericEqualityComparer<Quaternion>.Equals
	|
	|-RVA: 0x2EC67D0 Offset: 0x2EC68D1 VA: 0x2EC67D0
	|-GenericEqualityComparer<Rect>.Equals
	|
	|-RVA: 0x2EC6A90 Offset: 0x2EC6B91 VA: 0x2EC6A90
	|-GenericEqualityComparer<RectInt>.Equals
	|
	|-RVA: 0x2EC6D80 Offset: 0x2EC6E81 VA: 0x2EC6D80
	|-GenericEqualityComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x2EC70A0 Offset: 0x2EC71A1 VA: 0x2EC70A0
	|-GenericEqualityComparer<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x2EC7340 Offset: 0x2EC7441 VA: 0x2EC7340
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.Equals
	|
	|-RVA: 0x2EC7900 Offset: 0x2EC7A01 VA: 0x2EC7900
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>.Equals
	|
	|-RVA: 0x2EC7EC0 Offset: 0x2EC7FC1 VA: 0x2EC7EC0
	|-GenericEqualityComparer<GlyphRect>.Equals
	|
	|-RVA: 0x2EC8160 Offset: 0x2EC8261 VA: 0x2EC8160
	|-GenericEqualityComparer<ColorBlock>.Equals
	|
	|-RVA: 0x2EC8450 Offset: 0x2EC8551 VA: 0x2EC8450
	|-GenericEqualityComparer<Navigation>.Equals
	|
	|-RVA: 0x2EC8780 Offset: 0x2EC8881 VA: 0x2EC8780
	|-GenericEqualityComparer<SpriteState>.Equals
	|
	|-RVA: 0x2EC8A90 Offset: 0x2EC8B91 VA: 0x2EC8A90
	|-GenericEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x2EC8D30 Offset: 0x2EC8E31 VA: 0x2EC8D30
	|-GenericEqualityComparer<Vector2Int>.Equals
	|
	|-RVA: 0x2EC8FA0 Offset: 0x2EC90A1 VA: 0x2EC8FA0
	|-GenericEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x2EC9260 Offset: 0x2EC9361 VA: 0x2EC9260
	|-GenericEqualityComparer<Vector3Int>.Equals
	|
	|-RVA: 0x2EC9510 Offset: 0x2EC9611 VA: 0x2EC9510
	|-GenericEqualityComparer<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF390 Offset: 0x2EBF491 VA: 0x2EBF390
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.GetHashCode
	|
	|-RVA: 0x2EBF690 Offset: 0x2EBF791 VA: 0x2EBF690
	|-GenericEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x2EBF8F0 Offset: 0x2EBF9F1 VA: 0x2EBF8F0
	|-GenericEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x2EBFB50 Offset: 0x2EBFC51 VA: 0x2EBFB50
	|-GenericEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x2EBFDC0 Offset: 0x2EBFEC1 VA: 0x2EBFDC0
	|-GenericEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x2EC0040 Offset: 0x2EC0141 VA: 0x2EC0040
	|-GenericEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x2EC02D0 Offset: 0x2EC03D1 VA: 0x2EC02D0
	|-GenericEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x2EC0550 Offset: 0x2EC0651 VA: 0x2EC0550
	|-GenericEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x2EC07E0 Offset: 0x2EC08E1 VA: 0x2EC07E0
	|-GenericEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x2EC0A50 Offset: 0x2EC0B51 VA: 0x2EC0A50
	|-GenericEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x2EC0CC0 Offset: 0x2EC0DC1 VA: 0x2EC0CC0
	|-GenericEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x2EC0FE0 Offset: 0x2EC10E1 VA: 0x2EC0FE0
	|-GenericEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x2EC13E0 Offset: 0x2EC14E1 VA: 0x2EC13E0
	|-GenericEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x2EC1640 Offset: 0x2EC1741 VA: 0x2EC1640
	|-GenericEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x2EC18B0 Offset: 0x2EC19B1 VA: 0x2EC18B0
	|-GenericEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x2EC1B20 Offset: 0x2EC1C21 VA: 0x2EC1B20
	|-GenericEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x2EC1D90 Offset: 0x2EC1E91 VA: 0x2EC1D90
	|-GenericEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x2EC20B0 Offset: 0x2EC21B1 VA: 0x2EC20B0
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2EC25B0 Offset: 0x2EC26B1 VA: 0x2EC25B0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x2EC2AC0 Offset: 0x2EC2BC1 VA: 0x2EC2AC0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>.GetHashCode
	|
	|-RVA: 0x2EC2FE0 Offset: 0x2EC30E1 VA: 0x2EC2FE0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2EC3500 Offset: 0x2EC3601 VA: 0x2EC3500
	|-GenericEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x2EC3A20 Offset: 0x2EC3B21 VA: 0x2EC3A20
	|-GenericEqualityComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x2EC3F40 Offset: 0x2EC4041 VA: 0x2EC3F40
	|-GenericEqualityComparer<ValueTuple<float, float>>.GetHashCode
	|
	|-RVA: 0x2EC4490 Offset: 0x2EC4591 VA: 0x2EC4490
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2EC4A70 Offset: 0x2EC4B71 VA: 0x2EC4A70
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.GetHashCode
	|
	|-RVA: 0x2EC5000 Offset: 0x2EC5101 VA: 0x2EC5000
	|-GenericEqualityComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x2EC5290 Offset: 0x2EC5391 VA: 0x2EC5290
	|-GenericEqualityComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x2EC5520 Offset: 0x2EC5621 VA: 0x2EC5520
	|-GenericEqualityComparer<BoundsInt>.GetHashCode
	|
	|-RVA: 0x2EC57B0 Offset: 0x2EC58B1 VA: 0x2EC57B0
	|-GenericEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x2EC5A80 Offset: 0x2EC5B81 VA: 0x2EC5A80
	|-GenericEqualityComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x2EC5D30 Offset: 0x2EC5E31 VA: 0x2EC5D30
	|-GenericEqualityComparer<Playable>.GetHashCode
	|
	|-RVA: 0x2EC6010 Offset: 0x2EC6111 VA: 0x2EC6010
	|-GenericEqualityComparer<Edge>.GetHashCode
	|
	|-RVA: 0x2EC6290 Offset: 0x2EC6391 VA: 0x2EC6290
	|-GenericEqualityComparer<IntVec3>.GetHashCode
	|
	|-RVA: 0x2EC6550 Offset: 0x2EC6651 VA: 0x2EC6550
	|-GenericEqualityComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x2EC6810 Offset: 0x2EC6911 VA: 0x2EC6810
	|-GenericEqualityComparer<Rect>.GetHashCode
	|
	|-RVA: 0x2EC6AD0 Offset: 0x2EC6BD1 VA: 0x2EC6AD0
	|-GenericEqualityComparer<RectInt>.GetHashCode
	|
	|-RVA: 0x2EC6DF0 Offset: 0x2EC6EF1 VA: 0x2EC6DF0
	|-GenericEqualityComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x2EC70E0 Offset: 0x2EC71E1 VA: 0x2EC70E0
	|-GenericEqualityComparer<VertexAttributeDescriptor>.GetHashCode
	|
	|-RVA: 0x2EC7460 Offset: 0x2EC7561 VA: 0x2EC7460
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.GetHashCode
	|
	|-RVA: 0x2EC7A20 Offset: 0x2EC7B21 VA: 0x2EC7A20
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>.GetHashCode
	|
	|-RVA: 0x2EC7F00 Offset: 0x2EC8001 VA: 0x2EC7F00
	|-GenericEqualityComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x2EC81C0 Offset: 0x2EC82C1 VA: 0x2EC81C0
	|-GenericEqualityComparer<ColorBlock>.GetHashCode
	|
	|-RVA: 0x2EC84A0 Offset: 0x2EC85A1 VA: 0x2EC84A0
	|-GenericEqualityComparer<Navigation>.GetHashCode
	|
	|-RVA: 0x2EC87C0 Offset: 0x2EC88C1 VA: 0x2EC87C0
	|-GenericEqualityComparer<SpriteState>.GetHashCode
	|
	|-RVA: 0x2EC8AD0 Offset: 0x2EC8BD1 VA: 0x2EC8AD0
	|-GenericEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x2EC8D60 Offset: 0x2EC8E61 VA: 0x2EC8D60
	|-GenericEqualityComparer<Vector2Int>.GetHashCode
	|
	|-RVA: 0x2EC8FE0 Offset: 0x2EC90E1 VA: 0x2EC8FE0
	|-GenericEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x2EC92A0 Offset: 0x2EC93A1 VA: 0x2EC92A0
	|-GenericEqualityComparer<Vector3Int>.GetHashCode
	|
	|-RVA: 0x2EC9550 Offset: 0x2EC9651 VA: 0x2EC9550
	|-GenericEqualityComparer<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF410 Offset: 0x2EBF511 VA: 0x2EBF410
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x2EBF6C0 Offset: 0x2EBF7C1 VA: 0x2EBF6C0
	|-GenericEqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x2EBF920 Offset: 0x2EBFA21 VA: 0x2EBF920
	|-GenericEqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x2EBFB80 Offset: 0x2EBFC81 VA: 0x2EBFB80
	|-GenericEqualityComparer<char>.IndexOf
	|
	|-RVA: 0x2EBFDF0 Offset: 0x2EBFEF1 VA: 0x2EBFDF0
	|-GenericEqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x2EC0070 Offset: 0x2EC0171 VA: 0x2EC0070
	|-GenericEqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x2EC0300 Offset: 0x2EC0401 VA: 0x2EC0300
	|-GenericEqualityComparer<double>.IndexOf
	|
	|-RVA: 0x2EC0580 Offset: 0x2EC0681 VA: 0x2EC0580
	|-GenericEqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x2EC0810 Offset: 0x2EC0911 VA: 0x2EC0810
	|-GenericEqualityComparer<short>.IndexOf
	|
	|-RVA: 0x2EC0A80 Offset: 0x2EC0B81 VA: 0x2EC0A80
	|-GenericEqualityComparer<int>.IndexOf
	|
	|-RVA: 0x2EC0CF0 Offset: 0x2EC0DF1 VA: 0x2EC0CF0
	|-GenericEqualityComparer<long>.IndexOf
	|
	|-RVA: 0x2EC1000 Offset: 0x2EC1101 VA: 0x2EC1000
	|-GenericEqualityComparer<object>.IndexOf
	|
	|-RVA: 0x2EC1410 Offset: 0x2EC1511 VA: 0x2EC1410
	|-GenericEqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x2EC1670 Offset: 0x2EC1771 VA: 0x2EC1670
	|-GenericEqualityComparer<float>.IndexOf
	|
	|-RVA: 0x2EC18E0 Offset: 0x2EC19E1 VA: 0x2EC18E0
	|-GenericEqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x2EC1B50 Offset: 0x2EC1C51 VA: 0x2EC1B50
	|-GenericEqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x2EC1DC0 Offset: 0x2EC1EC1 VA: 0x2EC1DC0
	|-GenericEqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x2EC2110 Offset: 0x2EC2211 VA: 0x2EC2110
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x2EC2610 Offset: 0x2EC2711 VA: 0x2EC2610
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x2EC2B30 Offset: 0x2EC2C31 VA: 0x2EC2B30
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x2EC3050 Offset: 0x2EC3151 VA: 0x2EC3050
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x2EC3570 Offset: 0x2EC3671 VA: 0x2EC3570
	|-GenericEqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x2EC3A90 Offset: 0x2EC3B91 VA: 0x2EC3A90
	|-GenericEqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x2EC3FB0 Offset: 0x2EC40B1 VA: 0x2EC3FB0
	|-GenericEqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x2EC4500 Offset: 0x2EC4601 VA: 0x2EC4500
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x2EC4B10 Offset: 0x2EC4C11 VA: 0x2EC4B10
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x2EC5010 Offset: 0x2EC5111 VA: 0x2EC5010
	|-GenericEqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x2EC52A0 Offset: 0x2EC53A1 VA: 0x2EC52A0
	|-GenericEqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x2EC5530 Offset: 0x2EC5631 VA: 0x2EC5530
	|-GenericEqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x2EC57E0 Offset: 0x2EC58E1 VA: 0x2EC57E0
	|-GenericEqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x2EC5A90 Offset: 0x2EC5B91 VA: 0x2EC5A90
	|-GenericEqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x2EC5DB0 Offset: 0x2EC5EB1 VA: 0x2EC5DB0
	|-GenericEqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x2EC6040 Offset: 0x2EC6141 VA: 0x2EC6040
	|-GenericEqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x2EC62C0 Offset: 0x2EC63C1 VA: 0x2EC62C0
	|-GenericEqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x2EC6580 Offset: 0x2EC6681 VA: 0x2EC6580
	|-GenericEqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x2EC6840 Offset: 0x2EC6941 VA: 0x2EC6840
	|-GenericEqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x2EC6B50 Offset: 0x2EC6C51 VA: 0x2EC6B50
	|-GenericEqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x2EC6E00 Offset: 0x2EC6F01 VA: 0x2EC6E00
	|-GenericEqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x2EC7110 Offset: 0x2EC7211 VA: 0x2EC7110
	|-GenericEqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x2EC74E0 Offset: 0x2EC75E1 VA: 0x2EC74E0
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EC7AA0 Offset: 0x2EC7BA1 VA: 0x2EC7AA0
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EC7F30 Offset: 0x2EC8031 VA: 0x2EC7F30
	|-GenericEqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EC81D0 Offset: 0x2EC82D1 VA: 0x2EC81D0
	|-GenericEqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EC8530 Offset: 0x2EC8631 VA: 0x2EC8530
	|-GenericEqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EC8850 Offset: 0x2EC8951 VA: 0x2EC8850
	|-GenericEqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EC8B00 Offset: 0x2EC8C01 VA: 0x2EC8B00
	|-GenericEqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EC8D90 Offset: 0x2EC8E91 VA: 0x2EC8D90
	|-GenericEqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EC9010 Offset: 0x2EC9111 VA: 0x2EC9010
	|-GenericEqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EC92D0 Offset: 0x2EC93D1 VA: 0x2EC92D0
	|-GenericEqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EC9580 Offset: 0x2EC9681 VA: 0x2EC9580
	|-GenericEqualityComparer<Vector4>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF4D0 Offset: 0x2EBF5D1 VA: 0x2EBF4D0
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x2EBF760 Offset: 0x2EBF861 VA: 0x2EBF760
	|-GenericEqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x2EBF9C0 Offset: 0x2EBFAC1 VA: 0x2EBF9C0
	|-GenericEqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x2EBFC30 Offset: 0x2EBFD31 VA: 0x2EBFC30
	|-GenericEqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x2EBFEA0 Offset: 0x2EBFFA1 VA: 0x2EBFEA0
	|-GenericEqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x2EC0130 Offset: 0x2EC0231 VA: 0x2EC0130
	|-GenericEqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x2EC03B0 Offset: 0x2EC04B1 VA: 0x2EC03B0
	|-GenericEqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x2EC0640 Offset: 0x2EC0741 VA: 0x2EC0640
	|-GenericEqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x2EC08C0 Offset: 0x2EC09C1 VA: 0x2EC08C0
	|-GenericEqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x2EC0B30 Offset: 0x2EC0C31 VA: 0x2EC0B30
	|-GenericEqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x2EC0DA0 Offset: 0x2EC0EA1 VA: 0x2EC0DA0
	|-GenericEqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x2EC1180 Offset: 0x2EC1281 VA: 0x2EC1180
	|-GenericEqualityComparer<object>.LastIndexOf
	|
	|-RVA: 0x2EC14B0 Offset: 0x2EC15B1 VA: 0x2EC14B0
	|-GenericEqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x2EC1720 Offset: 0x2EC1821 VA: 0x2EC1720
	|-GenericEqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x2EC1990 Offset: 0x2EC1A91 VA: 0x2EC1990
	|-GenericEqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x2EC1C00 Offset: 0x2EC1D01 VA: 0x2EC1C00
	|-GenericEqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x2EC1E70 Offset: 0x2EC1F71 VA: 0x2EC1E70
	|-GenericEqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x2EC2290 Offset: 0x2EC2391 VA: 0x2EC2290
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x2EC2790 Offset: 0x2EC2891 VA: 0x2EC2790
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x2EC2CB0 Offset: 0x2EC2DB1 VA: 0x2EC2CB0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x2EC31D0 Offset: 0x2EC32D1 VA: 0x2EC31D0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x2EC36F0 Offset: 0x2EC37F1 VA: 0x2EC36F0
	|-GenericEqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x2EC3C10 Offset: 0x2EC3D11 VA: 0x2EC3C10
	|-GenericEqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x2EC4140 Offset: 0x2EC4241 VA: 0x2EC4140
	|-GenericEqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x2EC46B0 Offset: 0x2EC47B1 VA: 0x2EC46B0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x2EC4D00 Offset: 0x2EC4E01 VA: 0x2EC4D00
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x2EC50D0 Offset: 0x2EC51D1 VA: 0x2EC50D0
	|-GenericEqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x2EC5360 Offset: 0x2EC5461 VA: 0x2EC5360
	|-GenericEqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x2EC55F0 Offset: 0x2EC56F1 VA: 0x2EC55F0
	|-GenericEqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x2EC58B0 Offset: 0x2EC59B1 VA: 0x2EC58B0
	|-GenericEqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x2EC5B60 Offset: 0x2EC5C61 VA: 0x2EC5B60
	|-GenericEqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x2EC5E70 Offset: 0x2EC5F71 VA: 0x2EC5E70
	|-GenericEqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x2EC60F0 Offset: 0x2EC61F1 VA: 0x2EC60F0
	|-GenericEqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x2EC6390 Offset: 0x2EC6491 VA: 0x2EC6390
	|-GenericEqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x2EC6650 Offset: 0x2EC6751 VA: 0x2EC6650
	|-GenericEqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x2EC6910 Offset: 0x2EC6A11 VA: 0x2EC6910
	|-GenericEqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x2EC6C10 Offset: 0x2EC6D11 VA: 0x2EC6C10
	|-GenericEqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x2EC6EF0 Offset: 0x2EC6FF1 VA: 0x2EC6EF0
	|-GenericEqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x2EC71D0 Offset: 0x2EC72D1 VA: 0x2EC71D0
	|-GenericEqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x2EC7690 Offset: 0x2EC7791 VA: 0x2EC7690
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EC7C50 Offset: 0x2EC7D51 VA: 0x2EC7C50
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EC7FF0 Offset: 0x2EC80F1 VA: 0x2EC7FF0
	|-GenericEqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EC82B0 Offset: 0x2EC83B1 VA: 0x2EC82B0
	|-GenericEqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EC8600 Offset: 0x2EC8701 VA: 0x2EC8600
	|-GenericEqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EC8910 Offset: 0x2EC8A11 VA: 0x2EC8910
	|-GenericEqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EC8BC0 Offset: 0x2EC8CC1 VA: 0x2EC8BC0
	|-GenericEqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EC8E40 Offset: 0x2EC8F41 VA: 0x2EC8E40
	|-GenericEqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EC90E0 Offset: 0x2EC91E1 VA: 0x2EC90E0
	|-GenericEqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EC9390 Offset: 0x2EC9491 VA: 0x2EC9390
	|-GenericEqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EC9650 Offset: 0x2EC9751 VA: 0x2EC9650
	|-GenericEqualityComparer<Vector4>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF590 Offset: 0x2EBF691 VA: 0x2EBF590
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.Equals
	|
	|-RVA: 0x2EBF800 Offset: 0x2EBF901 VA: 0x2EBF800
	|-GenericEqualityComparer<bool>.Equals
	|
	|-RVA: 0x2EBFA60 Offset: 0x2EBFB61 VA: 0x2EBFA60
	|-GenericEqualityComparer<byte>.Equals
	|
	|-RVA: 0x2EBFCD0 Offset: 0x2EBFDD1 VA: 0x2EBFCD0
	|-GenericEqualityComparer<char>.Equals
	|
	|-RVA: 0x2EBFF40 Offset: 0x2EC0041 VA: 0x2EBFF40
	|-GenericEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x2EC01E0 Offset: 0x2EC02E1 VA: 0x2EC01E0
	|-GenericEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x2EC0450 Offset: 0x2EC0551 VA: 0x2EC0450
	|-GenericEqualityComparer<double>.Equals
	|
	|-RVA: 0x2EC06F0 Offset: 0x2EC07F1 VA: 0x2EC06F0
	|-GenericEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x2EC0960 Offset: 0x2EC0A61 VA: 0x2EC0960
	|-GenericEqualityComparer<short>.Equals
	|
	|-RVA: 0x2EC0BD0 Offset: 0x2EC0CD1 VA: 0x2EC0BD0
	|-GenericEqualityComparer<int>.Equals
	|
	|-RVA: 0x2EC0E40 Offset: 0x2EC0F41 VA: 0x2EC0E40
	|-GenericEqualityComparer<long>.Equals
	|
	|-RVA: 0x2EC12F0 Offset: 0x2EC13F1 VA: 0x2EC12F0
	|-GenericEqualityComparer<object>.Equals
	|
	|-RVA: 0x2EC1550 Offset: 0x2EC1651 VA: 0x2EC1550
	|-GenericEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x2EC17C0 Offset: 0x2EC18C1 VA: 0x2EC17C0
	|-GenericEqualityComparer<float>.Equals
	|
	|-RVA: 0x2EC1A30 Offset: 0x2EC1B31 VA: 0x2EC1A30
	|-GenericEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x2EC1CA0 Offset: 0x2EC1DA1 VA: 0x2EC1CA0
	|-GenericEqualityComparer<uint>.Equals
	|
	|-RVA: 0x2EC1F10 Offset: 0x2EC2011 VA: 0x2EC1F10
	|-GenericEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x2EC2410 Offset: 0x2EC2511 VA: 0x2EC2410
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>.Equals
	|
	|-RVA: 0x2EC2910 Offset: 0x2EC2A11 VA: 0x2EC2910
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x2EC2E30 Offset: 0x2EC2F31 VA: 0x2EC2E30
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>.Equals
	|
	|-RVA: 0x2EC3350 Offset: 0x2EC3451 VA: 0x2EC3350
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>.Equals
	|
	|-RVA: 0x2EC3870 Offset: 0x2EC3971 VA: 0x2EC3870
	|-GenericEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x2EC3D90 Offset: 0x2EC3E91 VA: 0x2EC3D90
	|-GenericEqualityComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x2EC42D0 Offset: 0x2EC43D1 VA: 0x2EC42D0
	|-GenericEqualityComparer<ValueTuple<float, float>>.Equals
	|
	|-RVA: 0x2EC4850 Offset: 0x2EC4951 VA: 0x2EC4850
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Equals
	|
	|-RVA: 0x2EC4F00 Offset: 0x2EC5001 VA: 0x2EC4F00
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Equals
	|
	|-RVA: 0x2EC5190 Offset: 0x2EC5291 VA: 0x2EC5190
	|-GenericEqualityComparer<BoneWeight>.Equals
	|
	|-RVA: 0x2EC5420 Offset: 0x2EC5521 VA: 0x2EC5420
	|-GenericEqualityComparer<Bounds>.Equals
	|
	|-RVA: 0x2EC56B0 Offset: 0x2EC57B1 VA: 0x2EC56B0
	|-GenericEqualityComparer<BoundsInt>.Equals
	|
	|-RVA: 0x2EC5970 Offset: 0x2EC5A71 VA: 0x2EC5970
	|-GenericEqualityComparer<Color>.Equals
	|
	|-RVA: 0x2EC5C30 Offset: 0x2EC5D31 VA: 0x2EC5C30
	|-GenericEqualityComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x2EC5F20 Offset: 0x2EC6021 VA: 0x2EC5F20
	|-GenericEqualityComparer<Playable>.Equals
	|
	|-RVA: 0x2EC6190 Offset: 0x2EC6291 VA: 0x2EC6190
	|-GenericEqualityComparer<Edge>.Equals
	|
	|-RVA: 0x2EC6450 Offset: 0x2EC6551 VA: 0x2EC6450
	|-GenericEqualityComparer<IntVec3>.Equals
	|
	|-RVA: 0x2EC6710 Offset: 0x2EC6811 VA: 0x2EC6710
	|-GenericEqualityComparer<Quaternion>.Equals
	|
	|-RVA: 0x2EC69D0 Offset: 0x2EC6AD1 VA: 0x2EC69D0
	|-GenericEqualityComparer<Rect>.Equals
	|
	|-RVA: 0x2EC6CC0 Offset: 0x2EC6DC1 VA: 0x2EC6CC0
	|-GenericEqualityComparer<RectInt>.Equals
	|
	|-RVA: 0x2EC6FE0 Offset: 0x2EC70E1 VA: 0x2EC6FE0
	|-GenericEqualityComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x2EC7280 Offset: 0x2EC7381 VA: 0x2EC7280
	|-GenericEqualityComparer<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x2EC7840 Offset: 0x2EC7941 VA: 0x2EC7840
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.Equals
	|
	|-RVA: 0x2EC7E00 Offset: 0x2EC7F01 VA: 0x2EC7E00
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>.Equals
	|
	|-RVA: 0x2EC80A0 Offset: 0x2EC81A1 VA: 0x2EC80A0
	|-GenericEqualityComparer<GlyphRect>.Equals
	|
	|-RVA: 0x2EC8390 Offset: 0x2EC8491 VA: 0x2EC8390
	|-GenericEqualityComparer<ColorBlock>.Equals
	|
	|-RVA: 0x2EC86C0 Offset: 0x2EC87C1 VA: 0x2EC86C0
	|-GenericEqualityComparer<Navigation>.Equals
	|
	|-RVA: 0x2EC89D0 Offset: 0x2EC8AD1 VA: 0x2EC89D0
	|-GenericEqualityComparer<SpriteState>.Equals
	|
	|-RVA: 0x2EC8C70 Offset: 0x2EC8D71 VA: 0x2EC8C70
	|-GenericEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x2EC8EE0 Offset: 0x2EC8FE1 VA: 0x2EC8EE0
	|-GenericEqualityComparer<Vector2Int>.Equals
	|
	|-RVA: 0x2EC91A0 Offset: 0x2EC92A1 VA: 0x2EC91A0
	|-GenericEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x2EC9450 Offset: 0x2EC9551 VA: 0x2EC9450
	|-GenericEqualityComparer<Vector3Int>.Equals
	|
	|-RVA: 0x2EC9710 Offset: 0x2EC9811 VA: 0x2EC9710
	|-GenericEqualityComparer<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF5E0 Offset: 0x2EBF6E1 VA: 0x2EBF5E0
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.GetHashCode
	|
	|-RVA: 0x2EBF850 Offset: 0x2EBF951 VA: 0x2EBF850
	|-GenericEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x2EBFAB0 Offset: 0x2EBFBB1 VA: 0x2EBFAB0
	|-GenericEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x2EBFD20 Offset: 0x2EBFE21 VA: 0x2EBFD20
	|-GenericEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x2EBFF90 Offset: 0x2EC0091 VA: 0x2EBFF90
	|-GenericEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x2EC0230 Offset: 0x2EC0331 VA: 0x2EC0230
	|-GenericEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x2EC04A0 Offset: 0x2EC05A1 VA: 0x2EC04A0
	|-GenericEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x2EC0740 Offset: 0x2EC0841 VA: 0x2EC0740
	|-GenericEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x2EC09B0 Offset: 0x2EC0AB1 VA: 0x2EC09B0
	|-GenericEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x2EC0C20 Offset: 0x2EC0D21 VA: 0x2EC0C20
	|-GenericEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x2EC0E90 Offset: 0x2EC0F91 VA: 0x2EC0E90
	|-GenericEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x2EC1340 Offset: 0x2EC1441 VA: 0x2EC1340
	|-GenericEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x2EC15A0 Offset: 0x2EC16A1 VA: 0x2EC15A0
	|-GenericEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x2EC1810 Offset: 0x2EC1911 VA: 0x2EC1810
	|-GenericEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x2EC1A80 Offset: 0x2EC1B81 VA: 0x2EC1A80
	|-GenericEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x2EC1CF0 Offset: 0x2EC1DF1 VA: 0x2EC1CF0
	|-GenericEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x2EC1F60 Offset: 0x2EC2061 VA: 0x2EC1F60
	|-GenericEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x2EC2460 Offset: 0x2EC2561 VA: 0x2EC2460
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2EC2960 Offset: 0x2EC2A61 VA: 0x2EC2960
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x2EC2E80 Offset: 0x2EC2F81 VA: 0x2EC2E80
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>.GetHashCode
	|
	|-RVA: 0x2EC33A0 Offset: 0x2EC34A1 VA: 0x2EC33A0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2EC38C0 Offset: 0x2EC39C1 VA: 0x2EC38C0
	|-GenericEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x2EC3DE0 Offset: 0x2EC3EE1 VA: 0x2EC3DE0
	|-GenericEqualityComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x2EC4320 Offset: 0x2EC4421 VA: 0x2EC4320
	|-GenericEqualityComparer<ValueTuple<float, float>>.GetHashCode
	|
	|-RVA: 0x2EC48A0 Offset: 0x2EC49A1 VA: 0x2EC48A0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2EC4F50 Offset: 0x2EC5051 VA: 0x2EC4F50
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.GetHashCode
	|
	|-RVA: 0x2EC51E0 Offset: 0x2EC52E1 VA: 0x2EC51E0
	|-GenericEqualityComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x2EC5470 Offset: 0x2EC5571 VA: 0x2EC5470
	|-GenericEqualityComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x2EC5700 Offset: 0x2EC5801 VA: 0x2EC5700
	|-GenericEqualityComparer<BoundsInt>.GetHashCode
	|
	|-RVA: 0x2EC59C0 Offset: 0x2EC5AC1 VA: 0x2EC59C0
	|-GenericEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x2EC5C80 Offset: 0x2EC5D81 VA: 0x2EC5C80
	|-GenericEqualityComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x2EC5F70 Offset: 0x2EC6071 VA: 0x2EC5F70
	|-GenericEqualityComparer<Playable>.GetHashCode
	|
	|-RVA: 0x2EC61E0 Offset: 0x2EC62E1 VA: 0x2EC61E0
	|-GenericEqualityComparer<Edge>.GetHashCode
	|
	|-RVA: 0x2EC64A0 Offset: 0x2EC65A1 VA: 0x2EC64A0
	|-GenericEqualityComparer<IntVec3>.GetHashCode
	|
	|-RVA: 0x2EC6760 Offset: 0x2EC6861 VA: 0x2EC6760
	|-GenericEqualityComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x2EC6A20 Offset: 0x2EC6B21 VA: 0x2EC6A20
	|-GenericEqualityComparer<Rect>.GetHashCode
	|
	|-RVA: 0x2EC6D10 Offset: 0x2EC6E11 VA: 0x2EC6D10
	|-GenericEqualityComparer<RectInt>.GetHashCode
	|
	|-RVA: 0x2EC7030 Offset: 0x2EC7131 VA: 0x2EC7030
	|-GenericEqualityComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x2EC72D0 Offset: 0x2EC73D1 VA: 0x2EC72D0
	|-GenericEqualityComparer<VertexAttributeDescriptor>.GetHashCode
	|
	|-RVA: 0x2EC7890 Offset: 0x2EC7991 VA: 0x2EC7890
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.GetHashCode
	|
	|-RVA: 0x2EC7E50 Offset: 0x2EC7F51 VA: 0x2EC7E50
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>.GetHashCode
	|
	|-RVA: 0x2EC80F0 Offset: 0x2EC81F1 VA: 0x2EC80F0
	|-GenericEqualityComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x2EC83E0 Offset: 0x2EC84E1 VA: 0x2EC83E0
	|-GenericEqualityComparer<ColorBlock>.GetHashCode
	|
	|-RVA: 0x2EC8710 Offset: 0x2EC8811 VA: 0x2EC8710
	|-GenericEqualityComparer<Navigation>.GetHashCode
	|
	|-RVA: 0x2EC8A20 Offset: 0x2EC8B21 VA: 0x2EC8A20
	|-GenericEqualityComparer<SpriteState>.GetHashCode
	|
	|-RVA: 0x2EC8CC0 Offset: 0x2EC8DC1 VA: 0x2EC8CC0
	|-GenericEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x2EC8F30 Offset: 0x2EC9031 VA: 0x2EC8F30
	|-GenericEqualityComparer<Vector2Int>.GetHashCode
	|
	|-RVA: 0x2EC91F0 Offset: 0x2EC92F1 VA: 0x2EC91F0
	|-GenericEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x2EC94A0 Offset: 0x2EC95A1 VA: 0x2EC94A0
	|-GenericEqualityComparer<Vector3Int>.GetHashCode
	|
	|-RVA: 0x2EC9760 Offset: 0x2EC9861 VA: 0x2EC9760
	|-GenericEqualityComparer<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EBF620 Offset: 0x2EBF721 VA: 0x2EBF620
	|-GenericEqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x2EBF890 Offset: 0x2EBF991 VA: 0x2EBF890
	|-GenericEqualityComparer<bool>..ctor
	|
	|-RVA: 0x2EBFAF0 Offset: 0x2EBFBF1 VA: 0x2EBFAF0
	|-GenericEqualityComparer<byte>..ctor
	|
	|-RVA: 0x2EBFD60 Offset: 0x2EBFE61 VA: 0x2EBFD60
	|-GenericEqualityComparer<char>..ctor
	|
	|-RVA: 0x2EBFFD0 Offset: 0x2EC00D1 VA: 0x2EBFFD0
	|-GenericEqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x2EC0270 Offset: 0x2EC0371 VA: 0x2EC0270
	|-GenericEqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x2EC04E0 Offset: 0x2EC05E1 VA: 0x2EC04E0
	|-GenericEqualityComparer<double>..ctor
	|
	|-RVA: 0x2EC0780 Offset: 0x2EC0881 VA: 0x2EC0780
	|-GenericEqualityComparer<Guid>..ctor
	|
	|-RVA: 0x2EC09F0 Offset: 0x2EC0AF1 VA: 0x2EC09F0
	|-GenericEqualityComparer<short>..ctor
	|
	|-RVA: 0x2EC0C60 Offset: 0x2EC0D61 VA: 0x2EC0C60
	|-GenericEqualityComparer<int>..ctor
	|
	|-RVA: 0x2EC0ED0 Offset: 0x2EC0FD1 VA: 0x2EC0ED0
	|-GenericEqualityComparer<long>..ctor
	|
	|-RVA: 0x2EC1380 Offset: 0x2EC1481 VA: 0x2EC1380
	|-GenericEqualityComparer<object>..ctor
	|
	|-RVA: 0x2EC15E0 Offset: 0x2EC16E1 VA: 0x2EC15E0
	|-GenericEqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x2EC1850 Offset: 0x2EC1951 VA: 0x2EC1850
	|-GenericEqualityComparer<float>..ctor
	|
	|-RVA: 0x2EC1AC0 Offset: 0x2EC1BC1 VA: 0x2EC1AC0
	|-GenericEqualityComparer<ushort>..ctor
	|
	|-RVA: 0x2EC1D30 Offset: 0x2EC1E31 VA: 0x2EC1D30
	|-GenericEqualityComparer<uint>..ctor
	|
	|-RVA: 0x2EC1FA0 Offset: 0x2EC20A1 VA: 0x2EC1FA0
	|-GenericEqualityComparer<ulong>..ctor
	|
	|-RVA: 0x2EC24A0 Offset: 0x2EC25A1 VA: 0x2EC24A0
	|-GenericEqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2EC29A0 Offset: 0x2EC2AA1 VA: 0x2EC29A0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2EC2EC0 Offset: 0x2EC2FC1 VA: 0x2EC2EC0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2EC33E0 Offset: 0x2EC34E1 VA: 0x2EC33E0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x2EC3900 Offset: 0x2EC3A01 VA: 0x2EC3900
	|-GenericEqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2EC3E20 Offset: 0x2EC3F21 VA: 0x2EC3E20
	|-GenericEqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x2EC4360 Offset: 0x2EC4461 VA: 0x2EC4360
	|-GenericEqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2EC48E0 Offset: 0x2EC49E1 VA: 0x2EC48E0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x2EC4F90 Offset: 0x2EC5091 VA: 0x2EC4F90
	|-GenericEqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x2EC5220 Offset: 0x2EC5321 VA: 0x2EC5220
	|-GenericEqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x2EC54B0 Offset: 0x2EC55B1 VA: 0x2EC54B0
	|-GenericEqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x2EC5740 Offset: 0x2EC5841 VA: 0x2EC5740
	|-GenericEqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x2EC5A00 Offset: 0x2EC5B01 VA: 0x2EC5A00
	|-GenericEqualityComparer<Color>..ctor
	|
	|-RVA: 0x2EC5CC0 Offset: 0x2EC5DC1 VA: 0x2EC5CC0
	|-GenericEqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x2EC5FB0 Offset: 0x2EC60B1 VA: 0x2EC5FB0
	|-GenericEqualityComparer<Playable>..ctor
	|
	|-RVA: 0x2EC6220 Offset: 0x2EC6321 VA: 0x2EC6220
	|-GenericEqualityComparer<Edge>..ctor
	|
	|-RVA: 0x2EC64E0 Offset: 0x2EC65E1 VA: 0x2EC64E0
	|-GenericEqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x2EC67A0 Offset: 0x2EC68A1 VA: 0x2EC67A0
	|-GenericEqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x2EC6A60 Offset: 0x2EC6B61 VA: 0x2EC6A60
	|-GenericEqualityComparer<Rect>..ctor
	|
	|-RVA: 0x2EC6D50 Offset: 0x2EC6E51 VA: 0x2EC6D50
	|-GenericEqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x2EC7070 Offset: 0x2EC7171 VA: 0x2EC7070
	|-GenericEqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x2EC7310 Offset: 0x2EC7411 VA: 0x2EC7310
	|-GenericEqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x2EC78D0 Offset: 0x2EC79D1 VA: 0x2EC78D0
	|-GenericEqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EC7E90 Offset: 0x2EC7F91 VA: 0x2EC7E90
	|-GenericEqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EC8130 Offset: 0x2EC8231 VA: 0x2EC8130
	|-GenericEqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EC8420 Offset: 0x2EC8521 VA: 0x2EC8420
	|-GenericEqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EC8750 Offset: 0x2EC8851 VA: 0x2EC8750
	|-GenericEqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EC8A60 Offset: 0x2EC8B61 VA: 0x2EC8A60
	|-GenericEqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EC8D00 Offset: 0x2EC8E01 VA: 0x2EC8D00
	|-GenericEqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EC8F70 Offset: 0x2EC9071 VA: 0x2EC8F70
	|-GenericEqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EC9230 Offset: 0x2EC9331 VA: 0x2EC9230
	|-GenericEqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EC94E0 Offset: 0x2EC95E1 VA: 0x2EC94E0
	|-GenericEqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EC97A0 Offset: 0x2EC98A1 VA: 0x2EC97A0
	|-GenericEqualityComparer<Vector4>..ctor
	*/
}

