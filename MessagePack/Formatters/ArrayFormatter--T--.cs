public sealed class ArrayFormatter<T> : IMessagePackFormatter<T[]>, IMessagePackFormatter // TypeDefIndex: 5346
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, T[] value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D26230 Offset: 0x2D26331 VA: 0x2D26230
	|-ArrayFormatter<Int32Enum>.Serialize
	|
	|-RVA: 0x2D26730 Offset: 0x2D26831 VA: 0x2D26730
	|-ArrayFormatter<Nullable<Int32Enum>>.Serialize
	|
	|-RVA: 0x2D26C30 Offset: 0x2D26D31 VA: 0x2D26C30
	|-ArrayFormatter<Nullable<Bounds>>.Serialize
	|
	|-RVA: 0x2D271F0 Offset: 0x2D272F1 VA: 0x2D271F0
	|-ArrayFormatter<Nullable<BoundsInt>>.Serialize
	|
	|-RVA: 0x2D277B0 Offset: 0x2D278B1 VA: 0x2D277B0
	|-ArrayFormatter<Nullable<Color32>>.Serialize
	|
	|-RVA: 0x2D27CB0 Offset: 0x2D27DB1 VA: 0x2D27CB0
	|-ArrayFormatter<Nullable<Color>>.Serialize
	|
	|-RVA: 0x2D28240 Offset: 0x2D28341 VA: 0x2D28240
	|-ArrayFormatter<Nullable<GradientAlphaKey>>.Serialize
	|
	|-RVA: 0x2D28760 Offset: 0x2D28861 VA: 0x2D28760
	|-ArrayFormatter<Nullable<GradientColorKey>>.Serialize
	|
	|-RVA: 0x2D28CF0 Offset: 0x2D28DF1 VA: 0x2D28CF0
	|-ArrayFormatter<Nullable<Keyframe>>.Serialize
	|
	|-RVA: 0x2D29280 Offset: 0x2D29381 VA: 0x2D29280
	|-ArrayFormatter<Nullable<LayerMask>>.Serialize
	|
	|-RVA: 0x2D29780 Offset: 0x2D29881 VA: 0x2D29780
	|-ArrayFormatter<Nullable<Matrix4x4>>.Serialize
	|
	|-RVA: 0x2D29DB0 Offset: 0x2D29EB1 VA: 0x2D29DB0
	|-ArrayFormatter<Nullable<Quaternion>>.Serialize
	|
	|-RVA: 0x2D2A340 Offset: 0x2D2A441 VA: 0x2D2A340
	|-ArrayFormatter<Nullable<RangeInt>>.Serialize
	|
	|-RVA: 0x2D2A860 Offset: 0x2D2A961 VA: 0x2D2A860
	|-ArrayFormatter<Nullable<Rect>>.Serialize
	|
	|-RVA: 0x2D2ADF0 Offset: 0x2D2AEF1 VA: 0x2D2ADF0
	|-ArrayFormatter<Nullable<RectInt>>.Serialize
	|
	|-RVA: 0x2D2B380 Offset: 0x2D2B481 VA: 0x2D2B380
	|-ArrayFormatter<Nullable<Vector2>>.Serialize
	|
	|-RVA: 0x2D2B8A0 Offset: 0x2D2B9A1 VA: 0x2D2B8A0
	|-ArrayFormatter<Nullable<Vector2Int>>.Serialize
	|
	|-RVA: 0x2D2BDC0 Offset: 0x2D2BEC1 VA: 0x2D2BDC0
	|-ArrayFormatter<Nullable<Vector3>>.Serialize
	|
	|-RVA: 0x2D2C2C0 Offset: 0x2D2C3C1 VA: 0x2D2C2C0
	|-ArrayFormatter<Nullable<Vector3Int>>.Serialize
	|
	|-RVA: 0x2D2C7C0 Offset: 0x2D2C8C1 VA: 0x2D2C7C0
	|-ArrayFormatter<Nullable<Vector4>>.Serialize
	|
	|-RVA: 0x2D2CD50 Offset: 0x2D2CE51 VA: 0x2D2CD50
	|-ArrayFormatter<object>.Serialize
	|
	|-RVA: 0x2D2D260 Offset: 0x2D2D361 VA: 0x2D2D260
	|-ArrayFormatter<Bounds>.Serialize
	|
	|-RVA: 0x2D2D7F0 Offset: 0x2D2D8F1 VA: 0x2D2D7F0
	|-ArrayFormatter<BoundsInt>.Serialize
	|
	|-RVA: 0x2D2DD80 Offset: 0x2D2DE81 VA: 0x2D2DD80
	|-ArrayFormatter<Color32>.Serialize
	|
	|-RVA: 0x2D2E280 Offset: 0x2D2E381 VA: 0x2D2E280
	|-ArrayFormatter<Color>.Serialize
	|
	|-RVA: 0x2D2E7A0 Offset: 0x2D2E8A1 VA: 0x2D2E7A0
	|-ArrayFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x2D2ECA0 Offset: 0x2D2EDA1 VA: 0x2D2ECA0
	|-ArrayFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x2D2F230 Offset: 0x2D2F331 VA: 0x2D2F230
	|-ArrayFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x2D2F7F0 Offset: 0x2D2F8F1 VA: 0x2D2F7F0
	|-ArrayFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x2D2FCF0 Offset: 0x2D2FDF1 VA: 0x2D2FCF0
	|-ArrayFormatter<Matrix4x4>.Serialize
	|
	|-RVA: 0x2D302D0 Offset: 0x2D303D1 VA: 0x2D302D0
	|-ArrayFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x2D307F0 Offset: 0x2D308F1 VA: 0x2D307F0
	|-ArrayFormatter<RangeInt>.Serialize
	|
	|-RVA: 0x2D30CF0 Offset: 0x2D30DF1 VA: 0x2D30CF0
	|-ArrayFormatter<Rect>.Serialize
	|
	|-RVA: 0x2D31210 Offset: 0x2D31311 VA: 0x2D31210
	|-ArrayFormatter<RectInt>.Serialize
	|
	|-RVA: 0x2D31710 Offset: 0x2D31811 VA: 0x2D31710
	|-ArrayFormatter<Vector2>.Serialize
	|
	|-RVA: 0x2D31C10 Offset: 0x2D31D11 VA: 0x2D31C10
	|-ArrayFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x2D32110 Offset: 0x2D32211 VA: 0x2D32110
	|-ArrayFormatter<Vector3>.Serialize
	|
	|-RVA: 0x2D32630 Offset: 0x2D32731 VA: 0x2D32630
	|-ArrayFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x2D32B50 Offset: 0x2D32C51 VA: 0x2D32B50
	|-ArrayFormatter<Vector4>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D26410 Offset: 0x2D26511 VA: 0x2D26410
	|-ArrayFormatter<Int32Enum>.Deserialize
	|
	|-RVA: 0x2D26910 Offset: 0x2D26A11 VA: 0x2D26910
	|-ArrayFormatter<Nullable<Int32Enum>>.Deserialize
	|
	|-RVA: 0x2D26E60 Offset: 0x2D26F61 VA: 0x2D26E60
	|-ArrayFormatter<Nullable<Bounds>>.Deserialize
	|
	|-RVA: 0x2D27420 Offset: 0x2D27521 VA: 0x2D27420
	|-ArrayFormatter<Nullable<BoundsInt>>.Deserialize
	|
	|-RVA: 0x2D27990 Offset: 0x2D27A91 VA: 0x2D27990
	|-ArrayFormatter<Nullable<Color32>>.Deserialize
	|
	|-RVA: 0x2D27EC0 Offset: 0x2D27FC1 VA: 0x2D27EC0
	|-ArrayFormatter<Nullable<Color>>.Deserialize
	|
	|-RVA: 0x2D28430 Offset: 0x2D28531 VA: 0x2D28430
	|-ArrayFormatter<Nullable<GradientAlphaKey>>.Deserialize
	|
	|-RVA: 0x2D28970 Offset: 0x2D28A71 VA: 0x2D28970
	|-ArrayFormatter<Nullable<GradientColorKey>>.Deserialize
	|
	|-RVA: 0x2D28F00 Offset: 0x2D29001 VA: 0x2D28F00
	|-ArrayFormatter<Nullable<Keyframe>>.Deserialize
	|
	|-RVA: 0x2D29460 Offset: 0x2D29561 VA: 0x2D29460
	|-ArrayFormatter<Nullable<LayerMask>>.Deserialize
	|
	|-RVA: 0x2D299F0 Offset: 0x2D29AF1 VA: 0x2D299F0
	|-ArrayFormatter<Nullable<Matrix4x4>>.Deserialize
	|
	|-RVA: 0x2D29FC0 Offset: 0x2D2A0C1 VA: 0x2D29FC0
	|-ArrayFormatter<Nullable<Quaternion>>.Deserialize
	|
	|-RVA: 0x2D2A530 Offset: 0x2D2A631 VA: 0x2D2A530
	|-ArrayFormatter<Nullable<RangeInt>>.Deserialize
	|
	|-RVA: 0x2D2AA70 Offset: 0x2D2AB71 VA: 0x2D2AA70
	|-ArrayFormatter<Nullable<Rect>>.Deserialize
	|
	|-RVA: 0x2D2B000 Offset: 0x2D2B101 VA: 0x2D2B000
	|-ArrayFormatter<Nullable<RectInt>>.Deserialize
	|
	|-RVA: 0x2D2B570 Offset: 0x2D2B671 VA: 0x2D2B570
	|-ArrayFormatter<Nullable<Vector2>>.Deserialize
	|
	|-RVA: 0x2D2BA90 Offset: 0x2D2BB91 VA: 0x2D2BA90
	|-ArrayFormatter<Nullable<Vector2Int>>.Deserialize
	|
	|-RVA: 0x2D2BFA0 Offset: 0x2D2C0A1 VA: 0x2D2BFA0
	|-ArrayFormatter<Nullable<Vector3>>.Deserialize
	|
	|-RVA: 0x2D2C4A0 Offset: 0x2D2C5A1 VA: 0x2D2C4A0
	|-ArrayFormatter<Nullable<Vector3Int>>.Deserialize
	|
	|-RVA: 0x2D2C9D0 Offset: 0x2D2CAD1 VA: 0x2D2C9D0
	|-ArrayFormatter<Nullable<Vector4>>.Deserialize
	|
	|-RVA: 0x2D2CF30 Offset: 0x2D2D031 VA: 0x2D2CF30
	|-ArrayFormatter<object>.Deserialize
	|
	|-RVA: 0x2D2D470 Offset: 0x2D2D571 VA: 0x2D2D470
	|-ArrayFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x2D2DA00 Offset: 0x2D2DB01 VA: 0x2D2DA00
	|-ArrayFormatter<BoundsInt>.Deserialize
	|
	|-RVA: 0x2D2DF60 Offset: 0x2D2E061 VA: 0x2D2DF60
	|-ArrayFormatter<Color32>.Deserialize
	|
	|-RVA: 0x2D2E470 Offset: 0x2D2E571 VA: 0x2D2E470
	|-ArrayFormatter<Color>.Deserialize
	|
	|-RVA: 0x2D2E980 Offset: 0x2D2EA81 VA: 0x2D2E980
	|-ArrayFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x2D2EEB0 Offset: 0x2D2EFB1 VA: 0x2D2EEB0
	|-ArrayFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x2D2F460 Offset: 0x2D2F561 VA: 0x2D2F460
	|-ArrayFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x2D2F9D0 Offset: 0x2D2FAD1 VA: 0x2D2F9D0
	|-ArrayFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x2D2FF30 Offset: 0x2D30031 VA: 0x2D2FF30
	|-ArrayFormatter<Matrix4x4>.Deserialize
	|
	|-RVA: 0x2D304C0 Offset: 0x2D305C1 VA: 0x2D304C0
	|-ArrayFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x2D309D0 Offset: 0x2D30AD1 VA: 0x2D309D0
	|-ArrayFormatter<RangeInt>.Deserialize
	|
	|-RVA: 0x2D30EE0 Offset: 0x2D30FE1 VA: 0x2D30EE0
	|-ArrayFormatter<Rect>.Deserialize
	|
	|-RVA: 0x2D313F0 Offset: 0x2D314F1 VA: 0x2D313F0
	|-ArrayFormatter<RectInt>.Deserialize
	|
	|-RVA: 0x2D318F0 Offset: 0x2D319F1 VA: 0x2D318F0
	|-ArrayFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x2D31DF0 Offset: 0x2D31EF1 VA: 0x2D31DF0
	|-ArrayFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x2D32300 Offset: 0x2D32401 VA: 0x2D32300
	|-ArrayFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x2D32820 Offset: 0x2D32921 VA: 0x2D32820
	|-ArrayFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x2D32D40 Offset: 0x2D32E41 VA: 0x2D32D40
	|-ArrayFormatter<Vector4>.Deserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D26710 Offset: 0x2D26811 VA: 0x2D26710
	|-ArrayFormatter<GameFlagData>..ctor
	|-ArrayFormatter<ItemID>..ctor
	|-ArrayFormatter<Int32Enum>..ctor
	|-ArrayFormatter<GradientMode>..ctor
	|-ArrayFormatter<WrapMode>..ctor
	|
	|-RVA: 0x2D2D240 Offset: 0x2D2D341 VA: 0x2D2D240
	|-ArrayFormatter<EventData>..ctor
	|-ArrayFormatter<EventScheduleData>..ctor
	|-ArrayFormatter<EventTimer>..ctor
	|-ArrayFormatter<FieldOnGroundItemInfo>..ctor
	|-ArrayFormatter<IntArray>..ctor
	|-ArrayFormatter<ItemData>..ctor
	|-ArrayFormatter<FriendMonsterIDAndHouseID>..ctor
	|-ArrayFormatter<object>..ctor
	|-ArrayFormatter<AnimationCurve>..ctor
	|-ArrayFormatter<Gradient>..ctor
	|-ArrayFormatter<RectOffset>..ctor
	|
	|-RVA: 0x2D26C10 Offset: 0x2D26D11 VA: 0x2D26C10
	|-ArrayFormatter<Nullable<Int32Enum>>..ctor
	|-ArrayFormatter<Nullable<GradientMode>>..ctor
	|-ArrayFormatter<Nullable<WrapMode>>..ctor
	|
	|-RVA: 0x2D271D0 Offset: 0x2D272D1 VA: 0x2D271D0
	|-ArrayFormatter<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x2D27790 Offset: 0x2D27891 VA: 0x2D27790
	|-ArrayFormatter<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2D27C90 Offset: 0x2D27D91 VA: 0x2D27C90
	|-ArrayFormatter<Nullable<Color32>>..ctor
	|
	|-RVA: 0x2D28220 Offset: 0x2D28321 VA: 0x2D28220
	|-ArrayFormatter<Nullable<Color>>..ctor
	|
	|-RVA: 0x2D28740 Offset: 0x2D28841 VA: 0x2D28740
	|-ArrayFormatter<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x2D28CD0 Offset: 0x2D28DD1 VA: 0x2D28CD0
	|-ArrayFormatter<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2D29260 Offset: 0x2D29361 VA: 0x2D29260
	|-ArrayFormatter<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2D29760 Offset: 0x2D29861 VA: 0x2D29760
	|-ArrayFormatter<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2D29D90 Offset: 0x2D29E91 VA: 0x2D29D90
	|-ArrayFormatter<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x2D2A320 Offset: 0x2D2A421 VA: 0x2D2A320
	|-ArrayFormatter<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2D2A840 Offset: 0x2D2A941 VA: 0x2D2A840
	|-ArrayFormatter<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2D2ADD0 Offset: 0x2D2AED1 VA: 0x2D2ADD0
	|-ArrayFormatter<Nullable<Rect>>..ctor
	|
	|-RVA: 0x2D2B360 Offset: 0x2D2B461 VA: 0x2D2B360
	|-ArrayFormatter<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2D2B880 Offset: 0x2D2B981 VA: 0x2D2B880
	|-ArrayFormatter<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2D2BDA0 Offset: 0x2D2BEA1 VA: 0x2D2BDA0
	|-ArrayFormatter<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2D2C2A0 Offset: 0x2D2C3A1 VA: 0x2D2C2A0
	|-ArrayFormatter<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2D2C7A0 Offset: 0x2D2C8A1 VA: 0x2D2C7A0
	|-ArrayFormatter<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2D2CD30 Offset: 0x2D2CE31 VA: 0x2D2CD30
	|-ArrayFormatter<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2D2D7D0 Offset: 0x2D2D8D1 VA: 0x2D2D7D0
	|-ArrayFormatter<Bounds>..ctor
	|
	|-RVA: 0x2D2DD60 Offset: 0x2D2DE61 VA: 0x2D2DD60
	|-ArrayFormatter<BoundsInt>..ctor
	|
	|-RVA: 0x2D2E260 Offset: 0x2D2E361 VA: 0x2D2E260
	|-ArrayFormatter<Color32>..ctor
	|
	|-RVA: 0x2D2E780 Offset: 0x2D2E881 VA: 0x2D2E780
	|-ArrayFormatter<Color>..ctor
	|
	|-RVA: 0x2D2EC80 Offset: 0x2D2ED81 VA: 0x2D2EC80
	|-ArrayFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x2D2F210 Offset: 0x2D2F311 VA: 0x2D2F210
	|-ArrayFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x2D2F7D0 Offset: 0x2D2F8D1 VA: 0x2D2F7D0
	|-ArrayFormatter<Keyframe>..ctor
	|
	|-RVA: 0x2D2FCD0 Offset: 0x2D2FDD1 VA: 0x2D2FCD0
	|-ArrayFormatter<LayerMask>..ctor
	|
	|-RVA: 0x2D302B0 Offset: 0x2D303B1 VA: 0x2D302B0
	|-ArrayFormatter<Matrix4x4>..ctor
	|
	|-RVA: 0x2D307D0 Offset: 0x2D308D1 VA: 0x2D307D0
	|-ArrayFormatter<Quaternion>..ctor
	|
	|-RVA: 0x2D30CD0 Offset: 0x2D30DD1 VA: 0x2D30CD0
	|-ArrayFormatter<RangeInt>..ctor
	|
	|-RVA: 0x2D311F0 Offset: 0x2D312F1 VA: 0x2D311F0
	|-ArrayFormatter<Rect>..ctor
	|
	|-RVA: 0x2D316F0 Offset: 0x2D317F1 VA: 0x2D316F0
	|-ArrayFormatter<RectInt>..ctor
	|
	|-RVA: 0x2D31BF0 Offset: 0x2D31CF1 VA: 0x2D31BF0
	|-ArrayFormatter<Vector2>..ctor
	|
	|-RVA: 0x2D320F0 Offset: 0x2D321F1 VA: 0x2D320F0
	|-ArrayFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x2D32610 Offset: 0x2D32711 VA: 0x2D32610
	|-ArrayFormatter<Vector3>..ctor
	|
	|-RVA: 0x2D32B30 Offset: 0x2D32C31 VA: 0x2D32B30
	|-ArrayFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x2D33050 Offset: 0x2D33151 VA: 0x2D33050
	|-ArrayFormatter<Vector4>..ctor
	*/
}

