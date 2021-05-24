public sealed class ListFormatter<T> : IMessagePackFormatter<List<T>>, IMessagePackFormatter // TypeDefIndex: 5355
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, List<T> value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCD710 Offset: 0x2CCD811 VA: 0x2CCD710
	|-ListFormatter<EventCheckId>.Serialize
	|
	|-RVA: 0x2CCDC80 Offset: 0x2CCDD81 VA: 0x2CCDC80
	|-ListFormatter<OrderLotterySaveParameter>.Serialize
	|
	|-RVA: 0x2CCE1B0 Offset: 0x2CCE2B1 VA: 0x2CCE1B0
	|-ListFormatter<OrderSaveParameter>.Serialize
	|
	|-RVA: 0x2CCE720 Offset: 0x2CCE821 VA: 0x2CCE720
	|-ListFormatter<bool>.Serialize
	|
	|-RVA: 0x2CCEC30 Offset: 0x2CCED31 VA: 0x2CCEC30
	|-ListFormatter<byte>.Serialize
	|
	|-RVA: 0x2CCF140 Offset: 0x2CCF241 VA: 0x2CCF140
	|-ListFormatter<char>.Serialize
	|
	|-RVA: 0x2CCF650 Offset: 0x2CCF751 VA: 0x2CCF650
	|-ListFormatter<DateTime>.Serialize
	|
	|-RVA: 0x2CCFB60 Offset: 0x2CCFC61 VA: 0x2CCFB60
	|-ListFormatter<double>.Serialize
	|
	|-RVA: 0x2CD0070 Offset: 0x2CD0171 VA: 0x2CD0070
	|-ListFormatter<short>.Serialize
	|
	|-RVA: 0x2CD0580 Offset: 0x2CD0681 VA: 0x2CD0580
	|-ListFormatter<int>.Serialize
	|
	|-RVA: 0x2CD0A90 Offset: 0x2CD0B91 VA: 0x2CD0A90
	|-ListFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x2CD0FA0 Offset: 0x2CD10A1 VA: 0x2CD0FA0
	|-ListFormatter<long>.Serialize
	|
	|-RVA: 0x2CD14B0 Offset: 0x2CD15B1 VA: 0x2CD14B0
	|-ListFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x2CD19C0 Offset: 0x2CD1AC1 VA: 0x2CD19C0
	|-ListFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x2CD1F50 Offset: 0x2CD2051 VA: 0x2CD1F50
	|-ListFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x2CD24E0 Offset: 0x2CD25E1 VA: 0x2CD24E0
	|-ListFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x2CD29F0 Offset: 0x2CD2AF1 VA: 0x2CD29F0
	|-ListFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x2CD2F60 Offset: 0x2CD3061 VA: 0x2CD2F60
	|-ListFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2CD3490 Offset: 0x2CD3591 VA: 0x2CD3490
	|-ListFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2CD3A00 Offset: 0x2CD3B01 VA: 0x2CD3A00
	|-ListFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2CD3F70 Offset: 0x2CD4071 VA: 0x2CD3F70
	|-ListFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2CD4480 Offset: 0x2CD4581 VA: 0x2CD4480
	|-ListFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x2CD4A50 Offset: 0x2CD4B51 VA: 0x2CD4A50
	|-ListFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2CD4FC0 Offset: 0x2CD50C1 VA: 0x2CD4FC0
	|-ListFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2CD54F0 Offset: 0x2CD55F1 VA: 0x2CD54F0
	|-ListFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x2CD5A60 Offset: 0x2CD5B61 VA: 0x2CD5A60
	|-ListFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x2CD5FD0 Offset: 0x2CD60D1 VA: 0x2CD5FD0
	|-ListFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x2CD6500 Offset: 0x2CD6601 VA: 0x2CD6500
	|-ListFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x2CD6A30 Offset: 0x2CD6B31 VA: 0x2CD6A30
	|-ListFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x2CD6F60 Offset: 0x2CD7061 VA: 0x2CD6F60
	|-ListFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x2CD7490 Offset: 0x2CD7591 VA: 0x2CD7490
	|-ListFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x2CD7A00 Offset: 0x2CD7B01 VA: 0x2CD7A00
	|-ListFormatter<object>.Serialize
	|
	|-RVA: 0x2CD7F10 Offset: 0x2CD8011 VA: 0x2CD7F10
	|-ListFormatter<sbyte>.Serialize
	|
	|-RVA: 0x2CD8420 Offset: 0x2CD8521 VA: 0x2CD8420
	|-ListFormatter<float>.Serialize
	|
	|-RVA: 0x2CD8930 Offset: 0x2CD8A31 VA: 0x2CD8930
	|-ListFormatter<ushort>.Serialize
	|
	|-RVA: 0x2CD8E40 Offset: 0x2CD8F41 VA: 0x2CD8E40
	|-ListFormatter<uint>.Serialize
	|
	|-RVA: 0x2CD9350 Offset: 0x2CD9451 VA: 0x2CD9350
	|-ListFormatter<ulong>.Serialize
	|
	|-RVA: 0x2CD9860 Offset: 0x2CD9961 VA: 0x2CD9860
	|-ListFormatter<Bounds>.Serialize
	|
	|-RVA: 0x2CD9DD0 Offset: 0x2CD9ED1 VA: 0x2CD9DD0
	|-ListFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x2CDA340 Offset: 0x2CDA441 VA: 0x2CDA340
	|-ListFormatter<Color32>.Serialize
	|
	|-RVA: 0x2CDA850 Offset: 0x2CDA951 VA: 0x2CDA850
	|-ListFormatter<Color>.Serialize
	|
	|-RVA: 0x2CDAD80 Offset: 0x2CDAE81 VA: 0x2CDAD80
	|-ListFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x2CDB2A0 Offset: 0x2CDB3A1 VA: 0x2CDB2A0
	|-ListFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x2CDB810 Offset: 0x2CDB911 VA: 0x2CDB810
	|-ListFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x2CDBDA0 Offset: 0x2CDBEA1 VA: 0x2CDBDA0
	|-ListFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x2CDC2B0 Offset: 0x2CDC3B1 VA: 0x2CDC2B0
	|-ListFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x2CDC860 Offset: 0x2CDC961 VA: 0x2CDC860
	|-ListFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x2CDCD90 Offset: 0x2CDCE91 VA: 0x2CDCD90
	|-ListFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x2CDD2A0 Offset: 0x2CDD3A1 VA: 0x2CDD2A0
	|-ListFormatter<Rect>.Serialize
	|
	|-RVA: 0x2CDD7D0 Offset: 0x2CDD8D1 VA: 0x2CDD7D0
	|-ListFormatter<RectInt>.Serialize
	|
	|-RVA: 0x2CDDD00 Offset: 0x2CDDE01 VA: 0x2CDDD00
	|-ListFormatter<Vector2>.Serialize
	|
	|-RVA: 0x2CDE220 Offset: 0x2CDE321 VA: 0x2CDE220
	|-ListFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x2CDE730 Offset: 0x2CDE831 VA: 0x2CDE730
	|-ListFormatter<Vector3>.Serialize
	|
	|-RVA: 0x2CDEC50 Offset: 0x2CDED51 VA: 0x2CDEC50
	|-ListFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x2CDF180 Offset: 0x2CDF281 VA: 0x2CDF180
	|-ListFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public List<T> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCD940 Offset: 0x2CCDA41 VA: 0x2CCD940
	|-ListFormatter<EventCheckId>.Deserialize
	|
	|-RVA: 0x2CCDEA0 Offset: 0x2CCDFA1 VA: 0x2CCDEA0
	|-ListFormatter<OrderLotterySaveParameter>.Deserialize
	|
	|-RVA: 0x2CCE3E0 Offset: 0x2CCE4E1 VA: 0x2CCE3E0
	|-ListFormatter<OrderSaveParameter>.Deserialize
	|
	|-RVA: 0x2CCE930 Offset: 0x2CCEA31 VA: 0x2CCE930
	|-ListFormatter<bool>.Deserialize
	|
	|-RVA: 0x2CCEE40 Offset: 0x2CCEF41 VA: 0x2CCEE40
	|-ListFormatter<byte>.Deserialize
	|
	|-RVA: 0x2CCF350 Offset: 0x2CCF451 VA: 0x2CCF350
	|-ListFormatter<char>.Deserialize
	|
	|-RVA: 0x2CCF860 Offset: 0x2CCF961 VA: 0x2CCF860
	|-ListFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x2CCFD70 Offset: 0x2CCFE71 VA: 0x2CCFD70
	|-ListFormatter<double>.Deserialize
	|
	|-RVA: 0x2CD0280 Offset: 0x2CD0381 VA: 0x2CD0280
	|-ListFormatter<short>.Deserialize
	|
	|-RVA: 0x2CD0790 Offset: 0x2CD0891 VA: 0x2CD0790
	|-ListFormatter<int>.Deserialize
	|
	|-RVA: 0x2CD0CA0 Offset: 0x2CD0DA1 VA: 0x2CD0CA0
	|-ListFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x2CD11B0 Offset: 0x2CD12B1 VA: 0x2CD11B0
	|-ListFormatter<long>.Deserialize
	|
	|-RVA: 0x2CD16C0 Offset: 0x2CD17C1 VA: 0x2CD16C0
	|-ListFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x2CD1C00 Offset: 0x2CD1D01 VA: 0x2CD1C00
	|-ListFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x2CD2190 Offset: 0x2CD2291 VA: 0x2CD2190
	|-ListFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x2CD26F0 Offset: 0x2CD27F1 VA: 0x2CD26F0
	|-ListFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x2CD2C20 Offset: 0x2CD2D21 VA: 0x2CD2C20
	|-ListFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x2CD3180 Offset: 0x2CD3281 VA: 0x2CD3180
	|-ListFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x2CD36C0 Offset: 0x2CD37C1 VA: 0x2CD36C0
	|-ListFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2CD3C30 Offset: 0x2CD3D31 VA: 0x2CD3C30
	|-ListFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2CD4180 Offset: 0x2CD4281 VA: 0x2CD4180
	|-ListFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2CD46F0 Offset: 0x2CD47F1 VA: 0x2CD46F0
	|-ListFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2CD4C80 Offset: 0x2CD4D81 VA: 0x2CD4C80
	|-ListFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x2CD51E0 Offset: 0x2CD52E1 VA: 0x2CD51E0
	|-ListFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2CD5720 Offset: 0x2CD5821 VA: 0x2CD5720
	|-ListFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x2CD5C90 Offset: 0x2CD5D91 VA: 0x2CD5C90
	|-ListFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x2CD61F0 Offset: 0x2CD62F1 VA: 0x2CD61F0
	|-ListFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x2CD6720 Offset: 0x2CD6821 VA: 0x2CD6720
	|-ListFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x2CD6C50 Offset: 0x2CD6D51 VA: 0x2CD6C50
	|-ListFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x2CD7180 Offset: 0x2CD7281 VA: 0x2CD7180
	|-ListFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x2CD76C0 Offset: 0x2CD77C1 VA: 0x2CD76C0
	|-ListFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x2CD7C10 Offset: 0x2CD7D11 VA: 0x2CD7C10
	|-ListFormatter<object>.Deserialize
	|
	|-RVA: 0x2CD8120 Offset: 0x2CD8221 VA: 0x2CD8120
	|-ListFormatter<sbyte>.Deserialize
	|
	|-RVA: 0x2CD8630 Offset: 0x2CD8731 VA: 0x2CD8630
	|-ListFormatter<float>.Deserialize
	|
	|-RVA: 0x2CD8B40 Offset: 0x2CD8C41 VA: 0x2CD8B40
	|-ListFormatter<ushort>.Deserialize
	|
	|-RVA: 0x2CD9050 Offset: 0x2CD9151 VA: 0x2CD9050
	|-ListFormatter<uint>.Deserialize
	|
	|-RVA: 0x2CD9560 Offset: 0x2CD9661 VA: 0x2CD9560
	|-ListFormatter<ulong>.Deserialize
	|
	|-RVA: 0x2CD9A90 Offset: 0x2CD9B91 VA: 0x2CD9A90
	|-ListFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x2CDA000 Offset: 0x2CDA101 VA: 0x2CDA000
	|-ListFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x2CDA550 Offset: 0x2CDA651 VA: 0x2CDA550
	|-ListFormatter<Color32>.Deserialize
	|
	|-RVA: 0x2CDAA80 Offset: 0x2CDAB81 VA: 0x2CDAA80
	|-ListFormatter<Color>.Deserialize
	|
	|-RVA: 0x2CDAFA0 Offset: 0x2CDB0A1 VA: 0x2CDAFA0
	|-ListFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x2CDB4D0 Offset: 0x2CDB5D1 VA: 0x2CDB4D0
	|-ListFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x2CDBA50 Offset: 0x2CDBB51 VA: 0x2CDBA50
	|-ListFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x2CDBFB0 Offset: 0x2CDC0B1 VA: 0x2CDBFB0
	|-ListFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x2CDC510 Offset: 0x2CDC611 VA: 0x2CDC510
	|-ListFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x2CDCA90 Offset: 0x2CDCB91 VA: 0x2CDCA90
	|-ListFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x2CDCFA0 Offset: 0x2CDD0A1 VA: 0x2CDCFA0
	|-ListFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x2CDD4D0 Offset: 0x2CDD5D1 VA: 0x2CDD4D0
	|-ListFormatter<Rect>.Deserialize
	|
	|-RVA: 0x2CDD9F0 Offset: 0x2CDDAF1 VA: 0x2CDD9F0
	|-ListFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x2CDDF20 Offset: 0x2CDE021 VA: 0x2CDDF20
	|-ListFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x2CDE430 Offset: 0x2CDE531 VA: 0x2CDE430
	|-ListFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x2CDE950 Offset: 0x2CDEA51 VA: 0x2CDE950
	|-ListFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x2CDEE70 Offset: 0x2CDEF71 VA: 0x2CDEE70
	|-ListFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x2CDF3B0 Offset: 0x2CDF4B1 VA: 0x2CDF3B0
	|-ListFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCDC60 Offset: 0x2CCDD61 VA: 0x2CCDC60
	|-ListFormatter<EventCheckId>..ctor
	|
	|-RVA: 0x2CD7EF0 Offset: 0x2CD7FF1 VA: 0x2CD7EF0
	|-ListFormatter<EventUnlockFlagData>..ctor
	|-ListFormatter<SubEventStep>..ctor
	|-ListFormatter<object>..ctor
	|-ListFormatter<string>..ctor
	|-ListFormatter<AnimationCurve>..ctor
	|-ListFormatter<Gradient>..ctor
	|-ListFormatter<RectOffset>..ctor
	|
	|-RVA: 0x2CD0F80 Offset: 0x2CD1081 VA: 0x2CD0F80
	|-ListFormatter<LovePointManager.FavoriteType>..ctor
	|-ListFormatter<Int32Enum>..ctor
	|-ListFormatter<GradientMode>..ctor
	|-ListFormatter<WrapMode>..ctor
	|
	|-RVA: 0x2CCE190 Offset: 0x2CCE291 VA: 0x2CCE190
	|-ListFormatter<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2CCE700 Offset: 0x2CCE801 VA: 0x2CCE700
	|-ListFormatter<OrderSaveParameter>..ctor
	|
	|-RVA: 0x2CCEC10 Offset: 0x2CCED11 VA: 0x2CCEC10
	|-ListFormatter<bool>..ctor
	|
	|-RVA: 0x2CCF120 Offset: 0x2CCF221 VA: 0x2CCF120
	|-ListFormatter<byte>..ctor
	|
	|-RVA: 0x2CCF630 Offset: 0x2CCF731 VA: 0x2CCF630
	|-ListFormatter<char>..ctor
	|
	|-RVA: 0x2CCFB40 Offset: 0x2CCFC41 VA: 0x2CCFB40
	|-ListFormatter<DateTime>..ctor
	|
	|-RVA: 0x2CD0050 Offset: 0x2CD0151 VA: 0x2CD0050
	|-ListFormatter<double>..ctor
	|
	|-RVA: 0x2CD0560 Offset: 0x2CD0661 VA: 0x2CD0560
	|-ListFormatter<short>..ctor
	|
	|-RVA: 0x2CD0A70 Offset: 0x2CD0B71 VA: 0x2CD0A70
	|-ListFormatter<int>..ctor
	|
	|-RVA: 0x2CD1490 Offset: 0x2CD1591 VA: 0x2CD1490
	|-ListFormatter<long>..ctor
	|
	|-RVA: 0x2CD19A0 Offset: 0x2CD1AA1 VA: 0x2CD19A0
	|-ListFormatter<Nullable<Int32Enum>>..ctor
	|-ListFormatter<Nullable<GradientMode>>..ctor
	|-ListFormatter<Nullable<WrapMode>>..ctor
	|
	|-RVA: 0x2CD1F30 Offset: 0x2CD2031 VA: 0x2CD1F30
	|-ListFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x2CD24C0 Offset: 0x2CD25C1 VA: 0x2CD24C0
	|-ListFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2CD29D0 Offset: 0x2CD2AD1 VA: 0x2CD29D0
	|-ListFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x2CD2F40 Offset: 0x2CD3041 VA: 0x2CD2F40
	|-ListFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x2CD3470 Offset: 0x2CD3571 VA: 0x2CD3470
	|-ListFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2CD39E0 Offset: 0x2CD3AE1 VA: 0x2CD39E0
	|-ListFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2CD3F50 Offset: 0x2CD4051 VA: 0x2CD3F50
	|-ListFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2CD4460 Offset: 0x2CD4561 VA: 0x2CD4460
	|-ListFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2CD4A30 Offset: 0x2CD4B31 VA: 0x2CD4A30
	|-ListFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x2CD4FA0 Offset: 0x2CD50A1 VA: 0x2CD4FA0
	|-ListFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2CD54D0 Offset: 0x2CD55D1 VA: 0x2CD54D0
	|-ListFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2CD5A40 Offset: 0x2CD5B41 VA: 0x2CD5A40
	|-ListFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x2CD5FB0 Offset: 0x2CD60B1 VA: 0x2CD5FB0
	|-ListFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2CD64E0 Offset: 0x2CD65E1 VA: 0x2CD64E0
	|-ListFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2CD6A10 Offset: 0x2CD6B11 VA: 0x2CD6A10
	|-ListFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2CD6F40 Offset: 0x2CD7041 VA: 0x2CD6F40
	|-ListFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2CD7470 Offset: 0x2CD7571 VA: 0x2CD7470
	|-ListFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2CD79E0 Offset: 0x2CD7AE1 VA: 0x2CD79E0
	|-ListFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2CD8400 Offset: 0x2CD8501 VA: 0x2CD8400
	|-ListFormatter<sbyte>..ctor
	|
	|-RVA: 0x2CD8910 Offset: 0x2CD8A11 VA: 0x2CD8910
	|-ListFormatter<float>..ctor
	|
	|-RVA: 0x2CD8E20 Offset: 0x2CD8F21 VA: 0x2CD8E20
	|-ListFormatter<ushort>..ctor
	|
	|-RVA: 0x2CD9330 Offset: 0x2CD9431 VA: 0x2CD9330
	|-ListFormatter<uint>..ctor
	|
	|-RVA: 0x2CD9840 Offset: 0x2CD9941 VA: 0x2CD9840
	|-ListFormatter<ulong>..ctor
	|
	|-RVA: 0x2CD9DB0 Offset: 0x2CD9EB1 VA: 0x2CD9DB0
	|-ListFormatter<Bounds>..ctor
	|
	|-RVA: 0x2CDA320 Offset: 0x2CDA421 VA: 0x2CDA320
	|-ListFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x2CDA830 Offset: 0x2CDA931 VA: 0x2CDA830
	|-ListFormatter<Color32>..ctor
	|
	|-RVA: 0x2CDAD60 Offset: 0x2CDAE61 VA: 0x2CDAD60
	|-ListFormatter<Color>..ctor
	|
	|-RVA: 0x2CDB280 Offset: 0x2CDB381 VA: 0x2CDB280
	|-ListFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x2CDB7F0 Offset: 0x2CDB8F1 VA: 0x2CDB7F0
	|-ListFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x2CDBD80 Offset: 0x2CDBE81 VA: 0x2CDBD80
	|-ListFormatter<Keyframe>..ctor
	|
	|-RVA: 0x2CDC290 Offset: 0x2CDC391 VA: 0x2CDC290
	|-ListFormatter<LayerMask>..ctor
	|
	|-RVA: 0x2CDC840 Offset: 0x2CDC941 VA: 0x2CDC840
	|-ListFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x2CDCD70 Offset: 0x2CDCE71 VA: 0x2CDCD70
	|-ListFormatter<Quaternion>..ctor
	|
	|-RVA: 0x2CDD280 Offset: 0x2CDD381 VA: 0x2CDD280
	|-ListFormatter<RangeInt>..ctor
	|
	|-RVA: 0x2CDD7B0 Offset: 0x2CDD8B1 VA: 0x2CDD7B0
	|-ListFormatter<Rect>..ctor
	|
	|-RVA: 0x2CDDCE0 Offset: 0x2CDDDE1 VA: 0x2CDDCE0
	|-ListFormatter<RectInt>..ctor
	|
	|-RVA: 0x2CDE200 Offset: 0x2CDE301 VA: 0x2CDE200
	|-ListFormatter<Vector2>..ctor
	|
	|-RVA: 0x2CDE710 Offset: 0x2CDE811 VA: 0x2CDE710
	|-ListFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x2CDEC30 Offset: 0x2CDED31 VA: 0x2CDEC30
	|-ListFormatter<Vector3>..ctor
	|
	|-RVA: 0x2CDF160 Offset: 0x2CDF261 VA: 0x2CDF160
	|-ListFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x2CDF690 Offset: 0x2CDF791 VA: 0x2CDF690
	|-ListFormatter<Vector4>..ctor
	*/
}

