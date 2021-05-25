internal static class ThrowHelper // TypeDefIndex: 109
{
	// Methods

	// RVA: 0x1590520 Offset: 0x1590621 VA: 0x1590520
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1590570 Offset: 0x1590671 VA: 0x1590570
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1590620 Offset: 0x1590721 VA: 0x1590620
	internal static void ThrowArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x1590670 Offset: 0x1590771 VA: 0x1590670
	private static Exception CreateArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x15906F0 Offset: 0x15907F1 VA: 0x15906F0
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x1590740 Offset: 0x1590841 VA: 0x1590740
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x15907A0 Offset: 0x15908A1 VA: 0x15907A0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x15907F0 Offset: 0x15908F1 VA: 0x15907F0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x15908A0 Offset: 0x15909A1 VA: 0x15908A0
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x15909D0 Offset: 0x1590AD1 VA: 0x15909D0
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x1590AD0 Offset: 0x1590BD1 VA: 0x1590AD0
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x15908C0 Offset: 0x15909C1 VA: 0x15908C0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x1590C50 Offset: 0x1590D51 VA: 0x1590C50
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x1590CD0 Offset: 0x1590DD1 VA: 0x1590CD0
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E00E0 Offset: 0x23E01E1 VA: 0x23E00E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AS_ToolController.ChargeInfo>
	|
	|-RVA: 0x23E0100 Offset: 0x23E0201 VA: 0x23E0100
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BuildItemData>
	|
	|-RVA: 0x23E0120 Offset: 0x23E0221 VA: 0x23E0120
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ButtonLinker.LinkObject>
	|
	|-RVA: 0x23E0140 Offset: 0x23E0241 VA: 0x23E0140
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CharaCallTable.BustupTable>
	|
	|-RVA: 0x23E0160 Offset: 0x23E0261 VA: 0x23E0160
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CharaCallTable.CharaFaceIconTable>
	|
	|-RVA: 0x23E0180 Offset: 0x23E0281 VA: 0x23E0180
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CameraState.CustomBlendable>
	|
	|-RVA: 0x23E01A0 Offset: 0x23E02A1 VA: 0x23E01A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CinemachineClearShot.Pair>
	|
	|-RVA: 0x23E01C0 Offset: 0x23E02C1 VA: 0x23E01C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x23E01E0 Offset: 0x23E02E1 VA: 0x23E01E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x23E0200 Offset: 0x23E0301 VA: 0x23E0200
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x23E0220 Offset: 0x23E0321 VA: 0x23E0220
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CropDataTable>
	|
	|-RVA: 0x23E0240 Offset: 0x23E0341 VA: 0x23E0240
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DropItemParam>
	|
	|-RVA: 0x23E0260 Offset: 0x23E0361 VA: 0x23E0260
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ErosionBrush.UndoStep>
	|
	|-RVA: 0x23E0280 Offset: 0x23E0381 VA: 0x23E0280
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EventCheckId>
	|
	|-RVA: 0x23E02A0 Offset: 0x23E03A1 VA: 0x23E02A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EventFlagProgressData>
	|
	|-RVA: 0x23E02C0 Offset: 0x23E03C1 VA: 0x23E02C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FesNpcScoreData>
	|
	|-RVA: 0x23E02E0 Offset: 0x23E03E1 VA: 0x23E02E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MiningPointSaveData>
	|
	|-RVA: 0x23E0300 Offset: 0x23E0401 VA: 0x23E0300
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MonsterHutSaveData>
	|
	|-RVA: 0x23E0320 Offset: 0x23E0421 VA: 0x23E0320
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MoviePlayer.SUBTITLEDATA>
	|
	|-RVA: 0x23E0340 Offset: 0x23E0441 VA: 0x23E0340
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NPCActionData>
	|
	|-RVA: 0x23E0360 Offset: 0x23E0461 VA: 0x23E0360
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NpcPlaceSchedule>
	|
	|-RVA: 0x23E0380 Offset: 0x23E0481 VA: 0x23E0380
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<OrderLotterySaveParameter>
	|
	|-RVA: 0x23E03A0 Offset: 0x23E04A1 VA: 0x23E03A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<OrderSaveParameter>
	|
	|-RVA: 0x23E03C0 Offset: 0x23E04C1 VA: 0x23E03C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x23E03E0 Offset: 0x23E04E1 VA: 0x23E03E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ShopCatalogPage>
	|
	|-RVA: 0x23E0400 Offset: 0x23E0501 VA: 0x23E0400
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ShopNpcTalk>
	|
	|-RVA: 0x23E0420 Offset: 0x23E0521 VA: 0x23E0420
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubtitleDataTable.Data>
	|
	|-RVA: 0x23E0440 Offset: 0x23E0541 VA: 0x23E0440
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubtitleDataTable.DataList>
	|
	|-RVA: 0x23E0460 Offset: 0x23E0561 VA: 0x23E0460
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubtitleHudDataTable.Data>
	|
	|-RVA: 0x23E0480 Offset: 0x23E0581 VA: 0x23E0480
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SRMonoBehaviourEx.FieldInfo>
	|
	|-RVA: 0x23E04A0 Offset: 0x23E05A1 VA: 0x23E04A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Schedule>
	|
	|-RVA: 0x23E04C0 Offset: 0x23E05C1 VA: 0x23E04C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CurveSample>
	|
	|-RVA: 0x23E04E0 Offset: 0x23E05E1 VA: 0x23E04E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<bool>
	|
	|-RVA: 0x23E0500 Offset: 0x23E0601 VA: 0x23E0500
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<byte>
	|
	|-RVA: 0x23E0520 Offset: 0x23E0621 VA: 0x23E0520
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<char>
	|
	|-RVA: 0x23E0540 Offset: 0x23E0641 VA: 0x23E0540
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x23E0560 Offset: 0x23E0661 VA: 0x23E0560
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, object>>
	|
	|-RVA: 0x23E0580 Offset: 0x23E0681 VA: 0x23E0580
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, object>>
	|
	|-RVA: 0x23E05A0 Offset: 0x23E06A1 VA: 0x23E05A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTime>
	|
	|-RVA: 0x23E05C0 Offset: 0x23E06C1 VA: 0x23E05C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<double>
	|
	|-RVA: 0x23E05E0 Offset: 0x23E06E1 VA: 0x23E05E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<short>
	|
	|-RVA: 0x23E0600 Offset: 0x23E0701 VA: 0x23E0600
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<int>
	|
	|-RVA: 0x23E0620 Offset: 0x23E0721 VA: 0x23E0620
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int32Enum>
	|
	|-RVA: 0x23E0640 Offset: 0x23E0741 VA: 0x23E0640
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<long>
	|
	|-RVA: 0x23E0660 Offset: 0x23E0761 VA: 0x23E0660
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InterpretedFrameInfo>
	|
	|-RVA: 0x23E0680 Offset: 0x23E0781 VA: 0x23E0680
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Int32Enum>>
	|
	|-RVA: 0x23E06E0 Offset: 0x23E07E1 VA: 0x23E06E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Bounds>>
	|
	|-RVA: 0x23E0750 Offset: 0x23E0851 VA: 0x23E0750
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<BoundsInt>>
	|
	|-RVA: 0x23E07C0 Offset: 0x23E08C1 VA: 0x23E07C0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Color32>>
	|
	|-RVA: 0x23E0820 Offset: 0x23E0921 VA: 0x23E0820
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Color>>
	|
	|-RVA: 0x23E0890 Offset: 0x23E0991 VA: 0x23E0890
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x23E0900 Offset: 0x23E0A01 VA: 0x23E0900
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<GradientColorKey>>
	|
	|-RVA: 0x23E0970 Offset: 0x23E0A71 VA: 0x23E0970
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Keyframe>>
	|
	|-RVA: 0x23E09E0 Offset: 0x23E0AE1 VA: 0x23E09E0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<LayerMask>>
	|
	|-RVA: 0x23E0A40 Offset: 0x23E0B41 VA: 0x23E0A40
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Matrix4x4>>
	|
	|-RVA: 0x23E0AB0 Offset: 0x23E0BB1 VA: 0x23E0AB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Quaternion>>
	|
	|-RVA: 0x23E0B20 Offset: 0x23E0C21 VA: 0x23E0B20
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<RangeInt>>
	|
	|-RVA: 0x23E0B90 Offset: 0x23E0C91 VA: 0x23E0B90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Rect>>
	|
	|-RVA: 0x23E0C00 Offset: 0x23E0D01 VA: 0x23E0C00
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<RectInt>>
	|
	|-RVA: 0x23E0C70 Offset: 0x23E0D71 VA: 0x23E0C70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Vector2>>
	|
	|-RVA: 0x23E0CE0 Offset: 0x23E0DE1 VA: 0x23E0CE0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Vector2Int>>
	|
	|-RVA: 0x23E0D50 Offset: 0x23E0E51 VA: 0x23E0D50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Vector3>>
	|
	|-RVA: 0x23E0DB0 Offset: 0x23E0EB1 VA: 0x23E0DB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Vector3Int>>
	|
	|-RVA: 0x23E0E10 Offset: 0x23E0F11 VA: 0x23E0E10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<Vector4>>
	|
	|-RVA: 0x23E0E80 Offset: 0x23E0F81 VA: 0x23E0E80
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<object>
	|
	|-RVA: 0x23E0E90 Offset: 0x23E0F91 VA: 0x23E0E90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<sbyte>
	|
	|-RVA: 0x23E0EB0 Offset: 0x23E0FB1 VA: 0x23E0EB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<float>
	|
	|-RVA: 0x23E0ED0 Offset: 0x23E0FD1 VA: 0x23E0ED0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ushort>
	|
	|-RVA: 0x23E0EF0 Offset: 0x23E0FF1 VA: 0x23E0EF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<uint>
	|
	|-RVA: 0x23E0F10 Offset: 0x23E1011 VA: 0x23E0F10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ulong>
	|
	|-RVA: 0x23E0F30 Offset: 0x23E1031 VA: 0x23E0F30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<bool, Int32Enum>>
	|
	|-RVA: 0x23E0F50 Offset: 0x23E1051 VA: 0x23E0F50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x23E0F70 Offset: 0x23E1071 VA: 0x23E0F70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0x23E0F90 Offset: 0x23E1091 VA: 0x23E0F90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, Int32Enum>>
	|
	|-RVA: 0x23E0FB0 Offset: 0x23E10B1 VA: 0x23E0FB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, object>>
	|
	|-RVA: 0x23E0FD0 Offset: 0x23E10D1 VA: 0x23E0FD0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, float>>
	|
	|-RVA: 0x23E0FF0 Offset: 0x23E10F1 VA: 0x23E0FF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>
	|
	|-RVA: 0x23E1010 Offset: 0x23E1111 VA: 0x23E1010
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<int, object, Vector3, Quaternion, object, object>>
	|
	|-RVA: 0x23E1030 Offset: 0x23E1131 VA: 0x23E1030
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x23E1050 Offset: 0x23E1151 VA: 0x23E1050
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TutorialUnlockFlagData>
	|
	|-RVA: 0x23E1070 Offset: 0x23E1171 VA: 0x23E1070
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIMainManagerAttachObject.AttachSet>
	|
	|-RVA: 0x23E1090 Offset: 0x23E1191 VA: 0x23E1090
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CapEdge>
	|
	|-RVA: 0x23E10B0 Offset: 0x23E11B1 VA: 0x23E10B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshDataConnectivity.Face>
	|
	|-RVA: 0x23E10D0 Offset: 0x23E11D1 VA: 0x23E10D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshFaceConnectivity.EdgeData.SideData>
	|
	|-RVA: 0x23E10F0 Offset: 0x23E11F1 VA: 0x23E10F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshFaceConnectivity.EdgeData>
	|
	|-RVA: 0x23E1110 Offset: 0x23E1211 VA: 0x23E1110
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildMarkup>
	|
	|-RVA: 0x23E1130 Offset: 0x23E1231 VA: 0x23E1130
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildSource>
	|
	|-RVA: 0x23E1150 Offset: 0x23E1251 VA: 0x23E1150
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ConstraintSource>
	|
	|-RVA: 0x23E1170 Offset: 0x23E1271 VA: 0x23E1170
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AnimatorClipInfo>
	|
	|-RVA: 0x23E1190 Offset: 0x23E1291 VA: 0x23E1190
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x23E11B0 Offset: 0x23E12B1 VA: 0x23E11B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoneWeight>
	|
	|-RVA: 0x23E11D0 Offset: 0x23E12D1 VA: 0x23E11D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Bounds>
	|
	|-RVA: 0x23E11F0 Offset: 0x23E12F1 VA: 0x23E11F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoundsInt>
	|
	|-RVA: 0x23E1210 Offset: 0x23E1311 VA: 0x23E1210
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color32>
	|
	|-RVA: 0x23E1230 Offset: 0x23E1331 VA: 0x23E1230
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color>
	|
	|-RVA: 0x23E1250 Offset: 0x23E1351 VA: 0x23E1250
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CombineInstance>
	|
	|-RVA: 0x23E1270 Offset: 0x23E1371 VA: 0x23E1270
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastResult>
	|
	|-RVA: 0x23E1290 Offset: 0x23E1391 VA: 0x23E1290
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GradientAlphaKey>
	|
	|-RVA: 0x23E12B0 Offset: 0x23E13B1 VA: 0x23E12B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GradientColorKey>
	|
	|-RVA: 0x23E12D0 Offset: 0x23E13D1 VA: 0x23E12D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Keyframe>
	|
	|-RVA: 0x23E12F0 Offset: 0x23E13F1 VA: 0x23E12F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<LayerMask>
	|
	|-RVA: 0x23E1310 Offset: 0x23E1411 VA: 0x23E1310
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Matrix4x4>
	|
	|-RVA: 0x23E1330 Offset: 0x23E1431 VA: 0x23E1330
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ParticleSystem.Particle>
	|
	|-RVA: 0x23E1350 Offset: 0x23E1451 VA: 0x23E1350
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Playable>
	|
	|-RVA: 0x23E1370 Offset: 0x23E1471 VA: 0x23E1370
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayableBinding>
	|
	|-RVA: 0x23E1390 Offset: 0x23E1491 VA: 0x23E1390
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayableGraph>
	|
	|-RVA: 0x23E13B0 Offset: 0x23E14B1 VA: 0x23E13B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Edge>
	|
	|-RVA: 0x23E13D0 Offset: 0x23E14D1 VA: 0x23E13D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Quaternion>
	|
	|-RVA: 0x23E13F0 Offset: 0x23E14F1 VA: 0x23E13F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangeInt>
	|
	|-RVA: 0x23E1410 Offset: 0x23E1511 VA: 0x23E1410
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit2D>
	|
	|-RVA: 0x23E1430 Offset: 0x23E1531 VA: 0x23E1430
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit>
	|
	|-RVA: 0x23E1450 Offset: 0x23E1551 VA: 0x23E1450
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Rect>
	|
	|-RVA: 0x23E1470 Offset: 0x23E1571 VA: 0x23E1470
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RectInt>
	|
	|-RVA: 0x23E1490 Offset: 0x23E1591 VA: 0x23E1490
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeBlendInfo>
	|
	|-RVA: 0x23E14B0 Offset: 0x23E15B1 VA: 0x23E14B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SphericalHarmonicsL2>
	|
	|-RVA: 0x23E14D0 Offset: 0x23E15D1 VA: 0x23E14D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<VertexAttributeDescriptor>
	|
	|-RVA: 0x23E14F0 Offset: 0x23E15F1 VA: 0x23E14F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AsyncOperationHandle>
	|
	|-RVA: 0x23E1510 Offset: 0x23E1611 VA: 0x23E1510
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AsyncOperationHandle<SceneInstance>>
	|
	|-RVA: 0x23E1530 Offset: 0x23E1631 VA: 0x23E1530
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DiagnosticEvent>
	|
	|-RVA: 0x23E1550 Offset: 0x23E1651 VA: 0x23E1550
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x23E1570 Offset: 0x23E1671 VA: 0x23E1570
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ObjectInitializationData>
	|
	|-RVA: 0x23E1590 Offset: 0x23E1691 VA: 0x23E1590
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GlyphRect>
	|
	|-RVA: 0x23E15B0 Offset: 0x23E16B1 VA: 0x23E15B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x23E15D0 Offset: 0x23E16D1 VA: 0x23E15D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IntervalTreeNode>
	|
	|-RVA: 0x23E15F0 Offset: 0x23E16F1 VA: 0x23E15F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IntervalTree.Entry<object>>
	|
	|-RVA: 0x23E1610 Offset: 0x23E1711 VA: 0x23E1610
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x23E1630 Offset: 0x23E1731 VA: 0x23E1630
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UICharInfo>
	|
	|-RVA: 0x23E1650 Offset: 0x23E1751 VA: 0x23E1650
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FocusController.FocusedElement>
	|
	|-RVA: 0x23E1670 Offset: 0x23E1771 VA: 0x23E1670
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UILineInfo>
	|
	|-RVA: 0x23E1690 Offset: 0x23E1791 VA: 0x23E1690
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIVertex>
	|
	|-RVA: 0x23E16B0 Offset: 0x23E17B1 VA: 0x23E16B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x23E16D0 Offset: 0x23E17D1 VA: 0x23E16D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2>
	|
	|-RVA: 0x23E16F0 Offset: 0x23E17F1 VA: 0x23E16F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2Int>
	|
	|-RVA: 0x23E1710 Offset: 0x23E1811 VA: 0x23E1710
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3>
	|
	|-RVA: 0x23E1730 Offset: 0x23E1831 VA: 0x23E1730
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3Int>
	|
	|-RVA: 0x23E1750 Offset: 0x23E1851 VA: 0x23E1750
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector4>
	|
	|-RVA: 0x23E1770 Offset: 0x23E1871 VA: 0x23E1770
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WarpPoints.WarpPoint>
	|
	|-RVA: 0x23E1790 Offset: 0x23E1891 VA: 0x23E1790
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<YieldItemParam>
	|
	|-RVA: 0x23E17B0 Offset: 0x23E18B1 VA: 0x23E17B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<stCommand_t>
	*/

	// RVA: 0x1590BD0 Offset: 0x1590CD1 VA: 0x1590BD0
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x1590B50 Offset: 0x1590C51 VA: 0x1590B50
	internal static string GetResourceName(ExceptionResource resource) { }
}

internal static class ThrowHelper // TypeDefIndex: 4372
{
	// Methods

	// RVA: 0x1B6CAD0 Offset: 0x1B6CBD1 VA: 0x1B6CAD0
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1B6CB20 Offset: 0x1B6CC21 VA: 0x1B6CB20
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1B6CBD0 Offset: 0x1B6CCD1 VA: 0x1B6CBD0
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x1B6CC20 Offset: 0x1B6CD21 VA: 0x1B6CC20
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x1B6CC80 Offset: 0x1B6CD81 VA: 0x1B6CC80
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x1B6CCD0 Offset: 0x1B6CDD1 VA: 0x1B6CCD0
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x1B6CE10 Offset: 0x1B6CF11 VA: 0x1B6CE10
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x1B6CE60 Offset: 0x1B6CF61 VA: 0x1B6CE60
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x1B6CF50 Offset: 0x1B6D051 VA: 0x1B6CF50
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x1B6CFA0 Offset: 0x1B6D0A1 VA: 0x1B6CFA0
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x1B6D000 Offset: 0x1B6D101 VA: 0x1B6D000
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x1B6D050 Offset: 0x1B6D151 VA: 0x1B6D050
	private static Exception CreateArgumentOutOfRangeException() { }

	// RVA: 0x1B69A70 Offset: 0x1B69B71 VA: 0x1B69A70
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1B6D0B0 Offset: 0x1B6D1B1 VA: 0x1B6D0B0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1B66820 Offset: 0x1B66921 VA: 0x1B66820
	internal static void ThrowArgumentOutOfRangeException_PrecisionTooLarge() { }

	// RVA: 0x1B6D160 Offset: 0x1B6D261 VA: 0x1B6D160
	private static Exception CreateArgumentOutOfRangeException_PrecisionTooLarge() { }

	// RVA: 0x1B66870 Offset: 0x1B66971 VA: 0x1B66870
	internal static void ThrowArgumentOutOfRangeException_SymbolDoesNotFit() { }

	// RVA: 0x1B6D2D0 Offset: 0x1B6D3D1 VA: 0x1B6D2D0
	private static Exception CreateArgumentOutOfRangeException_SymbolDoesNotFit() { }

	// RVA: 0x1B6D3C0 Offset: 0x1B6D4C1 VA: 0x1B6D3C0
	internal static void ThrowInvalidOperationException() { }

	// RVA: 0x1B6D410 Offset: 0x1B6D511 VA: 0x1B6D410
	private static Exception CreateInvalidOperationException() { }

	// RVA: 0x1B6D470 Offset: 0x1B6D571 VA: 0x1B6D470
	internal static void ThrowInvalidOperationException_EndPositionNotReached() { }

	// RVA: 0x1B6D4C0 Offset: 0x1B6D5C1 VA: 0x1B6D4C0
	private static Exception CreateInvalidOperationException_EndPositionNotReached() { }

	// RVA: 0x1B6D5B0 Offset: 0x1B6D6B1 VA: 0x1B6D5B0
	internal static void ThrowArgumentOutOfRangeException_PositionOutOfRange() { }

	// RVA: 0x1B6D600 Offset: 0x1B6D701 VA: 0x1B6D600
	private static Exception CreateArgumentOutOfRangeException_PositionOutOfRange() { }

	// RVA: 0x1B6D670 Offset: 0x1B6D771 VA: 0x1B6D670
	internal static void ThrowArgumentOutOfRangeException_OffsetOutOfRange() { }

	// RVA: 0x1B6D6C0 Offset: 0x1B6D7C1 VA: 0x1B6D6C0
	private static Exception CreateArgumentOutOfRangeException_OffsetOutOfRange() { }

	// RVA: 0x1B6D730 Offset: 0x1B6D831 VA: 0x1B6D730
	internal static void ThrowObjectDisposedException_ArrayMemoryPoolBuffer() { }

	// RVA: 0x1B6D780 Offset: 0x1B6D881 VA: 0x1B6D780
	private static Exception CreateObjectDisposedException_ArrayMemoryPoolBuffer() { }

	// RVA: 0x1B6D7F0 Offset: 0x1B6D8F1 VA: 0x1B6D7F0
	internal static void ThrowFormatException_BadFormatSpecifier() { }

	// RVA: 0x1B6D840 Offset: 0x1B6D941 VA: 0x1B6D840
	private static Exception CreateFormatException_BadFormatSpecifier() { }

	// RVA: 0x1B681F0 Offset: 0x1B682F1 VA: 0x1B681F0
	public static bool TryFormatThrowFormatException(out int bytesWritten) { }

	// RVA: -1 Offset: -1
	public static bool TryParseThrowFormatException<T>(out T value, out int bytesConsumed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D0460 Offset: 0x22D0561 VA: 0x22D0460
	|-ThrowHelper.TryParseThrowFormatException<Decimal>
	|
	|-RVA: 0x22D0490 Offset: 0x22D0591 VA: 0x22D0490
	|-ThrowHelper.TryParseThrowFormatException<object>
	*/

	// RVA: -1 Offset: -1
	public static void ThrowArgumentValidationException<T>(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E17D0 Offset: 0x23E18D1 VA: 0x23E17D0
	|-ThrowHelper.ThrowArgumentValidationException<byte>
	|
	|-RVA: 0x23E1850 Offset: 0x23E1951 VA: 0x23E1850
	|-ThrowHelper.ThrowArgumentValidationException<char>
	|
	|-RVA: 0x23E18D0 Offset: 0x23E19D1 VA: 0x23E18D0
	|-ThrowHelper.ThrowArgumentValidationException<object>
	*/

	// RVA: -1 Offset: -1
	private static Exception CreateArgumentValidationException<T>(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ABFA0 Offset: 0x21AC0A1 VA: 0x21ABFA0
	|-ThrowHelper.CreateArgumentValidationException<byte>
	|
	|-RVA: 0x21AC090 Offset: 0x21AC191 VA: 0x21AC090
	|-ThrowHelper.CreateArgumentValidationException<char>
	|
	|-RVA: 0x21AC180 Offset: 0x21AC281 VA: 0x21AC180
	|-ThrowHelper.CreateArgumentValidationException<object>
	*/

	// RVA: 0x1B6D930 Offset: 0x1B6DA31 VA: 0x1B6D930
	public static void ThrowStartOrEndArgumentValidationException(long start) { }

	// RVA: 0x1B6D980 Offset: 0x1B6DA81 VA: 0x1B6D980
	private static Exception CreateStartOrEndArgumentValidationException(long start) { }
}

internal static class ThrowHelper // TypeDefIndex: 4427
{
	// Methods

	// RVA: 0x1BDA1D0 Offset: 0x1BDA2D1 VA: 0x1BDA1D0
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1BDA0D0 Offset: 0x1BDA1D1 VA: 0x1BDA0D0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1BDA6F0 Offset: 0x1BDA7F1 VA: 0x1BDA6F0
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1BDA760 Offset: 0x1BDA861 VA: 0x1BDA760
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1BDA7D0 Offset: 0x1BDA8D1 VA: 0x1BDA7D0
	private static string GetArgumentName(ExceptionArgument argument) { }
}

