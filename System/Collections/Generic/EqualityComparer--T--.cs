[TypeDependencyAttribute] // RVA: 0xB3A20 Offset: 0xB3B21 VA: 0xB3A20
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1441
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A50 Offset: 0x32D4B51 VA: 0x32D4A50
	|-EqualityComparer<Font>.get_Default
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x2E3E1C0 Offset: 0x2E3E2C1 VA: 0x2E3E1C0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.get_Default
	|
	|-RVA: 0x2E3EE10 Offset: 0x2E3EF11 VA: 0x2E3EE10
	|-EqualityComparer<JSONDeserialization.TaskField>.get_Default
	|
	|-RVA: 0x2E3F980 Offset: 0x2E3FA81 VA: 0x2E3F980
	|-EqualityComparer<BitVector32Int>.get_Default
	|
	|-RVA: 0x2E404C0 Offset: 0x2E405C1 VA: 0x2E404C0
	|-EqualityComparer<BuildItemData>.get_Default
	|
	|-RVA: 0x2E413B0 Offset: 0x2E414B1 VA: 0x2E413B0
	|-EqualityComparer<ButtonLinker.LinkObject>.get_Default
	|
	|-RVA: 0x2E41F20 Offset: 0x2E42021 VA: 0x2E41F20
	|-EqualityComparer<CharaCallTable.BustupTable>.get_Default
	|
	|-RVA: 0x2E42A90 Offset: 0x2E42B91 VA: 0x2E42A90
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.get_Default
	|
	|-RVA: 0x2E43620 Offset: 0x2E43721 VA: 0x2E43620
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x2E44190 Offset: 0x2E44291 VA: 0x2E44190
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x2E44CD0 Offset: 0x2E44DD1 VA: 0x2E44CD0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x2E45810 Offset: 0x2E45911 VA: 0x2E45810
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x2E464D0 Offset: 0x2E465D1 VA: 0x2E464D0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x2E471C0 Offset: 0x2E472C1 VA: 0x2E471C0
	|-EqualityComparer<CropDataTable>.get_Default
	|
	|-RVA: 0x2E47E20 Offset: 0x2E47F21 VA: 0x2E47E20
	|-EqualityComparer<DropItemParam>.get_Default
	|
	|-RVA: 0x2E48960 Offset: 0x2E48A61 VA: 0x2E48960
	|-EqualityComparer<EffectDataTable>.get_Default
	|
	|-RVA: 0x2E495B0 Offset: 0x2E496B1 VA: 0x2E495B0
	|-EqualityComparer<ErosionBrush.UndoStep>.get_Default
	|
	|-RVA: 0x2E4A200 Offset: 0x2E4A301 VA: 0x2E4A200
	|-EqualityComparer<EventCheckId>.get_Default
	|
	|-RVA: 0x2E4AE50 Offset: 0x2E4AF51 VA: 0x2E4AE50
	|-EqualityComparer<EventFlagProgressData>.get_Default
	|
	|-RVA: 0x2E4B9C0 Offset: 0x2E4BAC1 VA: 0x2E4B9C0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.get_Default
	|
	|-RVA: 0x2E4C720 Offset: 0x2E4C821 VA: 0x2E4C720
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.get_Default
	|
	|-RVA: 0x2E4D370 Offset: 0x2E4D471 VA: 0x2E4D370
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.get_Default
	|
	|-RVA: 0x2E4DF00 Offset: 0x2E4E001 VA: 0x2E4DF00
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.get_Default
	|
	|-RVA: 0x2E4EA70 Offset: 0x2E4EB71 VA: 0x2E4EA70
	|-EqualityComparer<FesNpcScoreData>.get_Default
	|
	|-RVA: 0x2E4F5E0 Offset: 0x2E4F6E1 VA: 0x2E4F5E0
	|-EqualityComparer<GimmickLayoutDataTable>.get_Default
	|
	|-RVA: 0x2E50120 Offset: 0x2E50221 VA: 0x2E50120
	|-EqualityComparer<MineTypeDataTable>.get_Default
	|
	|-RVA: 0x2E50E50 Offset: 0x2E50F51 VA: 0x2E50E50
	|-EqualityComparer<MiningDataTable>.get_Default
	|
	|-RVA: 0x2E519C0 Offset: 0x2E51AC1 VA: 0x2E519C0
	|-EqualityComparer<MiningPointSaveData>.get_Default
	|
	|-RVA: 0x2E526B0 Offset: 0x2E527B1 VA: 0x2E526B0
	|-EqualityComparer<MonsterDataTable>.get_Default
	|
	|-RVA: 0x2E53330 Offset: 0x2E53431 VA: 0x2E53330
	|-EqualityComparer<MonsterFootStepEventDataTable>.get_Default
	|
	|-RVA: 0x2E53FF0 Offset: 0x2E540F1 VA: 0x2E53FF0
	|-EqualityComparer<MonsterHutSaveData>.get_Default
	|
	|-RVA: 0x2E54CC0 Offset: 0x2E54DC1 VA: 0x2E54CC0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.get_Default
	|
	|-RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
	|-EqualityComparer<NPCActionData>.get_Default
	|
	|-RVA: 0x2E56560 Offset: 0x2E56661 VA: 0x2E56560
	|-EqualityComparer<NpcPlaceSchedule>.get_Default
	|
	|-RVA: 0x2E571B0 Offset: 0x2E572B1 VA: 0x2E571B0
	|-EqualityComparer<OrderLotterySaveParameter>.get_Default
	|
	|-RVA: 0x31FE270 Offset: 0x31FE371 VA: 0x31FE270
	|-EqualityComparer<OrderSaveData>.get_Default
	|
	|-RVA: 0x31FEF40 Offset: 0x31FF041 VA: 0x31FEF40
	|-EqualityComparer<OrderSaveParameter>.get_Default
	|
	|-RVA: 0x31FFB90 Offset: 0x31FFC91 VA: 0x31FFB90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3200700 Offset: 0x3200801 VA: 0x3200700
	|-EqualityComparer<Parameter>.get_Default
	|
	|-RVA: 0x3201380 Offset: 0x3201481 VA: 0x3201380
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.get_Default
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-EqualityComparer<ShopCatalogPage>.get_Default
	|
	|-RVA: 0x3202A60 Offset: 0x3202B61 VA: 0x3202A60
	|-EqualityComparer<ShopNpcTalk>.get_Default
	|
	|-RVA: 0x3203720 Offset: 0x3203821 VA: 0x3203720
	|-EqualityComparer<SubtitleDataTable.Data>.get_Default
	|
	|-RVA: 0x32042B0 Offset: 0x32043B1 VA: 0x32042B0
	|-EqualityComparer<SubtitleDataTable.DataList>.get_Default
	|
	|-RVA: 0x3204DF0 Offset: 0x3204EF1 VA: 0x3204DF0
	|-EqualityComparer<SubtitleHudDataTable.Data>.get_Default
	|
	|-RVA: 0x3205980 Offset: 0x3205A81 VA: 0x3205980
	|-EqualityComparer<ProfilerFrame>.get_Default
	|
	|-RVA: 0x3206550 Offset: 0x3206651 VA: 0x3206550
	|-EqualityComparer<NumberControl.ValueRange>.get_Default
	|
	|-RVA: 0x32070C0 Offset: 0x32071C1 VA: 0x32070C0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.get_Default
	|
	|-RVA: 0x3207D10 Offset: 0x3207E11 VA: 0x3207D10
	|-EqualityComparer<Schedule>.get_Default
	|
	|-RVA: 0x3208960 Offset: 0x3208A61 VA: 0x3208960
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x32094D0 Offset: 0x32095D1 VA: 0x32094D0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.get_Default
	|
	|-RVA: 0x320A060 Offset: 0x320A161 VA: 0x320A060
	|-EqualityComparer<CurveSample>.get_Default
	|
	|-RVA: 0x320AE00 Offset: 0x320AF01 VA: 0x320AE00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x320B950 Offset: 0x320BA51 VA: 0x320B950
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x320C490 Offset: 0x320C591 VA: 0x320C490
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x320CFD0 Offset: 0x320D0D1 VA: 0x320CFD0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x320DB40 Offset: 0x320DC41 VA: 0x320DB40
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x320E680 Offset: 0x320E781 VA: 0x320E680
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x320FD30 Offset: 0x320FE31 VA: 0x320FD30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x32113E0 Offset: 0x32114E1 VA: 0x32113E0
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3211F50 Offset: 0x3212051 VA: 0x3211F50
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3212AA0 Offset: 0x3212BA1 VA: 0x3212AA0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3213610 Offset: 0x3213711 VA: 0x3213610
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3214150 Offset: 0x3214251 VA: 0x3214150
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3214C90 Offset: 0x3214D91 VA: 0x3214C90
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x32157D0 Offset: 0x32158D1 VA: 0x32157D0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3216310 Offset: 0x3216411 VA: 0x3216310
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3216E80 Offset: 0x3216F81 VA: 0x3216E80
	|-EqualityComparer<Memory<object>>.get_Default
	|
	|-RVA: 0x32179F0 Offset: 0x3217AF1 VA: 0x32179F0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.get_Default
	|
	|-RVA: 0x32186E0 Offset: 0x32187E1 VA: 0x32186E0
	|-EqualityComparer<Nullable<Int32Enum>>.get_Default
	|
	|-RVA: 0x3219230 Offset: 0x3219331 VA: 0x3219230
	|-EqualityComparer<Nullable<Bounds>>.get_Default
	|
	|-RVA: 0x3219F20 Offset: 0x321A021 VA: 0x3219F20
	|-EqualityComparer<Nullable<BoundsInt>>.get_Default
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-EqualityComparer<Nullable<Color32>>.get_Default
	|
	|-RVA: 0x32C9420 Offset: 0x32C9521 VA: 0x32C9420
	|-EqualityComparer<Nullable<Color>>.get_Default
	|
	|-RVA: 0x32CA0A0 Offset: 0x32CA1A1 VA: 0x32CA0A0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.get_Default
	|
	|-RVA: 0x32CAC40 Offset: 0x32CAD41 VA: 0x32CAC40
	|-EqualityComparer<Nullable<GradientColorKey>>.get_Default
	|
	|-RVA: 0x32CB8C0 Offset: 0x32CB9C1 VA: 0x32CB8C0
	|-EqualityComparer<Nullable<Keyframe>>.get_Default
	|
	|-RVA: 0x32CC540 Offset: 0x32CC641 VA: 0x32CC540
	|-EqualityComparer<Nullable<LayerMask>>.get_Default
	|
	|-RVA: 0x32CD090 Offset: 0x32CD191 VA: 0x32CD090
	|-EqualityComparer<Nullable<Matrix4x4>>.get_Default
	|
	|-RVA: 0x32CDE90 Offset: 0x32CDF91 VA: 0x32CDE90
	|-EqualityComparer<Nullable<Quaternion>>.get_Default
	|
	|-RVA: 0x32CEB10 Offset: 0x32CEC11 VA: 0x32CEB10
	|-EqualityComparer<Nullable<RangeInt>>.get_Default
	|
	|-RVA: 0x32CF6B0 Offset: 0x32CF7B1 VA: 0x32CF6B0
	|-EqualityComparer<Nullable<Rect>>.get_Default
	|
	|-RVA: 0x32D0330 Offset: 0x32D0431 VA: 0x32D0330
	|-EqualityComparer<Nullable<RectInt>>.get_Default
	|
	|-RVA: 0x32D0FB0 Offset: 0x32D10B1 VA: 0x32D0FB0
	|-EqualityComparer<Nullable<Vector2>>.get_Default
	|
	|-RVA: 0x32D1B50 Offset: 0x32D1C51 VA: 0x32D1B50
	|-EqualityComparer<Nullable<Vector2Int>>.get_Default
	|
	|-RVA: 0x32D26F0 Offset: 0x32D27F1 VA: 0x32D26F0
	|-EqualityComparer<Nullable<Vector3>>.get_Default
	|
	|-RVA: 0x32D3260 Offset: 0x32D3361 VA: 0x32D3260
	|-EqualityComparer<Nullable<Vector3Int>>.get_Default
	|
	|-RVA: 0x32D3DD0 Offset: 0x32D3ED1 VA: 0x32D3DD0
	|-EqualityComparer<Nullable<Vector4>>.get_Default
	|
	|-RVA: 0x32D5570 Offset: 0x32D5671 VA: 0x32D5570
	|-EqualityComparer<ReadOnlyMemory<object>>.get_Default
	|
	|-RVA: 0x32D60E0 Offset: 0x32D61E1 VA: 0x32D60E0
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x32D6C20 Offset: 0x32D6D21 VA: 0x32D6C20
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x32D7790 Offset: 0x32D7891 VA: 0x32D7790
	|-EqualityComparer<RuntimeTypeHandle>.get_Default
	|
	|-RVA: 0x32D82D0 Offset: 0x32D83D1 VA: 0x32D82D0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x32D8E10 Offset: 0x32D8F11 VA: 0x32D8E10
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x32D9960 Offset: 0x32D9A61 VA: 0x32D9960
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x32DA4A0 Offset: 0x32DA5A1 VA: 0x32DA4A0
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x32DAFE0 Offset: 0x32DB0E1 VA: 0x32DAFE0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DC660 Offset: 0x32DC761 VA: 0x32DC660
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x32DD1A0 Offset: 0x32DD2A1 VA: 0x32DD1A0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x32DDD10 Offset: 0x32DDE11 VA: 0x32DDD10
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DE880 Offset: 0x32DE981 VA: 0x32DE880
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x32DF3F0 Offset: 0x32DF4F1 VA: 0x32DF3F0
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x32DFF60 Offset: 0x32E0061 VA: 0x32DFF60
	|-EqualityComparer<ValueTuple<float, float>>.get_Default
	|
	|-RVA: 0x32E0AD0 Offset: 0x32E0BD1 VA: 0x32E0AD0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Default
	|
	|-RVA: 0x32E1660 Offset: 0x32E1761 VA: 0x32E1660
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Default
	|
	|-RVA: 0x32E2390 Offset: 0x32E2491 VA: 0x32E2390
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x32E30C0 Offset: 0x32E31C1 VA: 0x32E30C0
	|-EqualityComparer<TransitionTables>.get_Default
	|
	|-RVA: 0x32E3D10 Offset: 0x32E3E11 VA: 0x32E3D10
	|-EqualityComparer<TutorialUnlockFlagData>.get_Default
	|
	|-RVA: 0x32E48A0 Offset: 0x32E49A1 VA: 0x32E48A0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.get_Default
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-EqualityComparer<CapEdge>.get_Default
	|
	|-RVA: 0x30F14B0 Offset: 0x30F15B1 VA: 0x30F14B0
	|-EqualityComparer<ClippedEdge>.get_Default
	|
	|-RVA: 0x30F2100 Offset: 0x30F2201 VA: 0x30F2100
	|-EqualityComparer<EdgeKeyByHash>.get_Default
	|
	|-RVA: 0x30F2C40 Offset: 0x30F2D41 VA: 0x30F2C40
	|-EqualityComparer<EdgeKeyByIndex>.get_Default
	|
	|-RVA: 0x30F3780 Offset: 0x30F3881 VA: 0x30F3780
	|-EqualityComparer<MeshDataConnectivity.Face>.get_Default
	|
	|-RVA: 0x30F42C0 Offset: 0x30F43C1 VA: 0x30F42C0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.get_Default
	|
	|-RVA: 0x30F4F10 Offset: 0x30F5011 VA: 0x30F4F10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.get_Default
	|
	|-RVA: 0x30F5BD0 Offset: 0x30F5CD1 VA: 0x30F5BD0
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x30F6740 Offset: 0x30F6841 VA: 0x30F6740
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x30F75C0 Offset: 0x30F76C1 VA: 0x30F75C0
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x30F8130 Offset: 0x30F8231 VA: 0x30F8130
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x30F8C70 Offset: 0x30F8D71 VA: 0x30F8C70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x30F97E0 Offset: 0x30F98E1 VA: 0x30F97E0
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x30FA430 Offset: 0x30FA531 VA: 0x30FA430
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x30FB080 Offset: 0x30FB181 VA: 0x30FB080
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x30FBCD0 Offset: 0x30FBDD1 VA: 0x30FBCD0
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x30FC810 Offset: 0x30FC911 VA: 0x30FC810
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x30FD3E0 Offset: 0x30FD4E1 VA: 0x30FD3E0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x30FE260 Offset: 0x30FE361 VA: 0x30FE260
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x30FF000 Offset: 0x30FF101 VA: 0x30FF000
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	|
	|-RVA: 0x30FFB40 Offset: 0x30FFC41 VA: 0x30FFB40
	|-EqualityComparer<GradientAlphaKey>.get_Default
	|
	|-RVA: 0x31006B0 Offset: 0x31007B1 VA: 0x31006B0
	|-EqualityComparer<GradientColorKey>.get_Default
	|
	|-RVA: 0x3101300 Offset: 0x3101401 VA: 0x3101300
	|-EqualityComparer<Keyframe>.get_Default
	|
	|-RVA: 0x3101FC0 Offset: 0x31020C1 VA: 0x3101FC0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3102B00 Offset: 0x3102C01 VA: 0x3102B00
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x31044B0 Offset: 0x31045B1 VA: 0x31044B0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3105020 Offset: 0x3105121 VA: 0x3105020
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3105C70 Offset: 0x3105D71 VA: 0x3105C70
	|-EqualityComparer<PlayableGraph>.get_Default
	|
	|-RVA: 0x31067E0 Offset: 0x31068E1 VA: 0x31067E0
	|-EqualityComparer<Edge>.get_Default
	|
	|-RVA: 0x3107320 Offset: 0x3107421 VA: 0x3107320
	|-EqualityComparer<IntVec3>.get_Default
	|
	|-RVA: 0x3107EF0 Offset: 0x3107FF1 VA: 0x3107EF0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3108AC0 Offset: 0x3108BC1 VA: 0x3108AC0
	|-EqualityComparer<RangeInt>.get_Default
	|
	|-RVA: 0x3109600 Offset: 0x3109701 VA: 0x3109600
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x310A2F0 Offset: 0x310A3F1 VA: 0x310A2F0
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x310B020 Offset: 0x310B121 VA: 0x310B020
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x310BBF0 Offset: 0x310BCF1 VA: 0x310BBF0
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x310C760 Offset: 0x310C861 VA: 0x310C760
	|-EqualityComparer<ReflectionProbeBlendInfo>.get_Default
	|
	|-RVA: 0x310D2D0 Offset: 0x310D3D1 VA: 0x310D2D0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x310E1D0 Offset: 0x310E2D1 VA: 0x310E1D0
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x310ED40 Offset: 0x310EE41 VA: 0x310ED40
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x2EA70A0 Offset: 0x2EA71A1 VA: 0x2EA70A0
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x2EA7CF0 Offset: 0x2EA7DF1 VA: 0x2EA7CF0
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.get_Default
	|
	|-RVA: 0x2EA8940 Offset: 0x2EA8A41 VA: 0x2EA8940
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x2EA9600 Offset: 0x2EA9701 VA: 0x2EA9600
	|-EqualityComparer<SceneInstance>.get_Default
	|
	|-RVA: 0x2EAA170 Offset: 0x2EAA271 VA: 0x2EAA170
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x2EAADC0 Offset: 0x2EAAEC1 VA: 0x2EAADC0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x2EABA80 Offset: 0x2EABB81 VA: 0x2EABA80
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x2EAC5F0 Offset: 0x2EAC6F1 VA: 0x2EAC5F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x2EAD2C0 Offset: 0x2EAD3C1 VA: 0x2EAD2C0
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x2EADF10 Offset: 0x2EAE011 VA: 0x2EADF10
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x2EAEB60 Offset: 0x2EAEC61 VA: 0x2EAEB60
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x2EAF7B0 Offset: 0x2EAF8B1 VA: 0x2EAF7B0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x2EB05C0 Offset: 0x2EB06C1 VA: 0x2EB05C0
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x2EB1290 Offset: 0x2EB1391 VA: 0x2EB1290
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x2EB1EE0 Offset: 0x2EB1FE1 VA: 0x2EB1EE0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x2EB3620 Offset: 0x2EB3721 VA: 0x2EB3620
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x2EB4190 Offset: 0x2EB4291 VA: 0x2EB4190
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x2EB4CD0 Offset: 0x2EB4DD1 VA: 0x2EB4CD0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x2EB5840 Offset: 0x2EB5941 VA: 0x2EB5840
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x2EB6650 Offset: 0x2EB6751 VA: 0x2EB6650
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2EB72A0 Offset: 0x2EB73A1 VA: 0x2EB72A0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x2EB8950 Offset: 0x2EB8A51 VA: 0x2EB8950
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x2EBA0B0 Offset: 0x2EBA1B1 VA: 0x2EBA0B0
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-EqualityComparer<WarpPoints.WarpPoint>.get_Default
	|
	|-RVA: 0x2EBBB70 Offset: 0x2EBBC71 VA: 0x2EBBB70
	|-EqualityComparer<YieldItemParam>.get_Default
	|
	|-RVA: 0x2EBC6B0 Offset: 0x2EBC7B1 VA: 0x2EBC6B0
	|-EqualityComparer<stCommand_t>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E2D0 Offset: 0x2E3E3D1 VA: 0x2E3E2D0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.CreateComparer
	|
	|-RVA: 0x2E3EF20 Offset: 0x2E3F021 VA: 0x2E3EF20
	|-EqualityComparer<JSONDeserialization.TaskField>.CreateComparer
	|
	|-RVA: 0x2E3FA90 Offset: 0x2E3FB91 VA: 0x2E3FA90
	|-EqualityComparer<BitVector32Int>.CreateComparer
	|
	|-RVA: 0x2E405D0 Offset: 0x2E406D1 VA: 0x2E405D0
	|-EqualityComparer<BuildItemData>.CreateComparer
	|
	|-RVA: 0x2E414C0 Offset: 0x2E415C1 VA: 0x2E414C0
	|-EqualityComparer<ButtonLinker.LinkObject>.CreateComparer
	|
	|-RVA: 0x2E42030 Offset: 0x2E42131 VA: 0x2E42030
	|-EqualityComparer<CharaCallTable.BustupTable>.CreateComparer
	|
	|-RVA: 0x2E42BA0 Offset: 0x2E42CA1 VA: 0x2E42BA0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.CreateComparer
	|
	|-RVA: 0x2E43730 Offset: 0x2E43831 VA: 0x2E43730
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x2E465E0 Offset: 0x2E466E1 VA: 0x2E465E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x2E472D0 Offset: 0x2E473D1 VA: 0x2E472D0
	|-EqualityComparer<CropDataTable>.CreateComparer
	|
	|-RVA: 0x2E47F30 Offset: 0x2E48031 VA: 0x2E47F30
	|-EqualityComparer<DropItemParam>.CreateComparer
	|
	|-RVA: 0x2E48A70 Offset: 0x2E48B71 VA: 0x2E48A70
	|-EqualityComparer<EffectDataTable>.CreateComparer
	|
	|-RVA: 0x2E496C0 Offset: 0x2E497C1 VA: 0x2E496C0
	|-EqualityComparer<ErosionBrush.UndoStep>.CreateComparer
	|
	|-RVA: 0x2E4A310 Offset: 0x2E4A411 VA: 0x2E4A310
	|-EqualityComparer<EventCheckId>.CreateComparer
	|
	|-RVA: 0x2E4AF60 Offset: 0x2E4B061 VA: 0x2E4AF60
	|-EqualityComparer<EventFlagProgressData>.CreateComparer
	|
	|-RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.CreateComparer
	|
	|-RVA: 0x2E4C830 Offset: 0x2E4C931 VA: 0x2E4C830
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.CreateComparer
	|
	|-RVA: 0x2E4D480 Offset: 0x2E4D581 VA: 0x2E4D480
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.CreateComparer
	|
	|-RVA: 0x2E4E010 Offset: 0x2E4E111 VA: 0x2E4E010
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.CreateComparer
	|
	|-RVA: 0x2E4EB80 Offset: 0x2E4EC81 VA: 0x2E4EB80
	|-EqualityComparer<FesNpcScoreData>.CreateComparer
	|
	|-RVA: 0x2E4F6F0 Offset: 0x2E4F7F1 VA: 0x2E4F6F0
	|-EqualityComparer<GimmickLayoutDataTable>.CreateComparer
	|
	|-RVA: 0x2E50230 Offset: 0x2E50331 VA: 0x2E50230
	|-EqualityComparer<MineTypeDataTable>.CreateComparer
	|
	|-RVA: 0x2E50F60 Offset: 0x2E51061 VA: 0x2E50F60
	|-EqualityComparer<MiningDataTable>.CreateComparer
	|
	|-RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0
	|-EqualityComparer<MiningPointSaveData>.CreateComparer
	|
	|-RVA: 0x2E527C0 Offset: 0x2E528C1 VA: 0x2E527C0
	|-EqualityComparer<MonsterDataTable>.CreateComparer
	|
	|-RVA: 0x2E53440 Offset: 0x2E53541 VA: 0x2E53440
	|-EqualityComparer<MonsterFootStepEventDataTable>.CreateComparer
	|
	|-RVA: 0x2E54100 Offset: 0x2E54201 VA: 0x2E54100
	|-EqualityComparer<MonsterHutSaveData>.CreateComparer
	|
	|-RVA: 0x2E54DD0 Offset: 0x2E54ED1 VA: 0x2E54DD0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.CreateComparer
	|
	|-RVA: 0x2E55940 Offset: 0x2E55A41 VA: 0x2E55940
	|-EqualityComparer<NPCActionData>.CreateComparer
	|
	|-RVA: 0x2E56670 Offset: 0x2E56771 VA: 0x2E56670
	|-EqualityComparer<NpcPlaceSchedule>.CreateComparer
	|
	|-RVA: 0x2E572C0 Offset: 0x2E573C1 VA: 0x2E572C0
	|-EqualityComparer<OrderLotterySaveParameter>.CreateComparer
	|
	|-RVA: 0x31FE380 Offset: 0x31FE481 VA: 0x31FE380
	|-EqualityComparer<OrderSaveData>.CreateComparer
	|
	|-RVA: 0x31FF050 Offset: 0x31FF151 VA: 0x31FF050
	|-EqualityComparer<OrderSaveParameter>.CreateComparer
	|
	|-RVA: 0x31FFCA0 Offset: 0x31FFDA1 VA: 0x31FFCA0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3200810 Offset: 0x3200911 VA: 0x3200810
	|-EqualityComparer<Parameter>.CreateComparer
	|
	|-RVA: 0x3201490 Offset: 0x3201591 VA: 0x3201490
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.CreateComparer
	|
	|-RVA: 0x3202000 Offset: 0x3202101 VA: 0x3202000
	|-EqualityComparer<ShopCatalogPage>.CreateComparer
	|
	|-RVA: 0x3202B70 Offset: 0x3202C71 VA: 0x3202B70
	|-EqualityComparer<ShopNpcTalk>.CreateComparer
	|
	|-RVA: 0x3203830 Offset: 0x3203931 VA: 0x3203830
	|-EqualityComparer<SubtitleDataTable.Data>.CreateComparer
	|
	|-RVA: 0x32043C0 Offset: 0x32044C1 VA: 0x32043C0
	|-EqualityComparer<SubtitleDataTable.DataList>.CreateComparer
	|
	|-RVA: 0x3204F00 Offset: 0x3205001 VA: 0x3204F00
	|-EqualityComparer<SubtitleHudDataTable.Data>.CreateComparer
	|
	|-RVA: 0x3205A90 Offset: 0x3205B91 VA: 0x3205A90
	|-EqualityComparer<ProfilerFrame>.CreateComparer
	|
	|-RVA: 0x3206660 Offset: 0x3206761 VA: 0x3206660
	|-EqualityComparer<NumberControl.ValueRange>.CreateComparer
	|
	|-RVA: 0x32071D0 Offset: 0x32072D1 VA: 0x32071D0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.CreateComparer
	|
	|-RVA: 0x3207E20 Offset: 0x3207F21 VA: 0x3207E20
	|-EqualityComparer<Schedule>.CreateComparer
	|
	|-RVA: 0x3208A70 Offset: 0x3208B71 VA: 0x3208A70
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x32095E0 Offset: 0x32096E1 VA: 0x32095E0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.CreateComparer
	|
	|-RVA: 0x320A170 Offset: 0x320A271 VA: 0x320A170
	|-EqualityComparer<CurveSample>.CreateComparer
	|
	|-RVA: 0x320AF10 Offset: 0x320B011 VA: 0x320AF10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x320BA60 Offset: 0x320BB61 VA: 0x320BA60
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x320C5A0 Offset: 0x320C6A1 VA: 0x320C5A0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x320D0E0 Offset: 0x320D1E1 VA: 0x320D0E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x320DC50 Offset: 0x320DD51 VA: 0x320DC50
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x320E790 Offset: 0x320E891 VA: 0x320E790
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x320F300 Offset: 0x320F401 VA: 0x320F300
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x320FE40 Offset: 0x320FF41 VA: 0x320FE40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x32109B0 Offset: 0x3210AB1 VA: 0x32109B0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x32114F0 Offset: 0x32115F1 VA: 0x32114F0
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3212060 Offset: 0x3212161 VA: 0x3212060
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3212BB0 Offset: 0x3212CB1 VA: 0x3212BB0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3213720 Offset: 0x3213821 VA: 0x3213720
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3214260 Offset: 0x3214361 VA: 0x3214260
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3214DA0 Offset: 0x3214EA1 VA: 0x3214DA0
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x32158E0 Offset: 0x32159E1 VA: 0x32158E0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3216420 Offset: 0x3216521 VA: 0x3216420
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3216F90 Offset: 0x3217091 VA: 0x3216F90
	|-EqualityComparer<Memory<object>>.CreateComparer
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.CreateComparer
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-EqualityComparer<Nullable<Int32Enum>>.CreateComparer
	|
	|-RVA: 0x3219340 Offset: 0x3219441 VA: 0x3219340
	|-EqualityComparer<Nullable<Bounds>>.CreateComparer
	|
	|-RVA: 0x321A030 Offset: 0x321A131 VA: 0x321A030
	|-EqualityComparer<Nullable<BoundsInt>>.CreateComparer
	|
	|-RVA: 0x321AD20 Offset: 0x321AE21 VA: 0x321AD20
	|-EqualityComparer<Nullable<Color32>>.CreateComparer
	|
	|-RVA: 0x32C9530 Offset: 0x32C9631 VA: 0x32C9530
	|-EqualityComparer<Nullable<Color>>.CreateComparer
	|
	|-RVA: 0x32CA1B0 Offset: 0x32CA2B1 VA: 0x32CA1B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.CreateComparer
	|
	|-RVA: 0x32CAD50 Offset: 0x32CAE51 VA: 0x32CAD50
	|-EqualityComparer<Nullable<GradientColorKey>>.CreateComparer
	|
	|-RVA: 0x32CB9D0 Offset: 0x32CBAD1 VA: 0x32CB9D0
	|-EqualityComparer<Nullable<Keyframe>>.CreateComparer
	|
	|-RVA: 0x32CC650 Offset: 0x32CC751 VA: 0x32CC650
	|-EqualityComparer<Nullable<LayerMask>>.CreateComparer
	|
	|-RVA: 0x32CD1A0 Offset: 0x32CD2A1 VA: 0x32CD1A0
	|-EqualityComparer<Nullable<Matrix4x4>>.CreateComparer
	|
	|-RVA: 0x32CDFA0 Offset: 0x32CE0A1 VA: 0x32CDFA0
	|-EqualityComparer<Nullable<Quaternion>>.CreateComparer
	|
	|-RVA: 0x32CEC20 Offset: 0x32CED21 VA: 0x32CEC20
	|-EqualityComparer<Nullable<RangeInt>>.CreateComparer
	|
	|-RVA: 0x32CF7C0 Offset: 0x32CF8C1 VA: 0x32CF7C0
	|-EqualityComparer<Nullable<Rect>>.CreateComparer
	|
	|-RVA: 0x32D0440 Offset: 0x32D0541 VA: 0x32D0440
	|-EqualityComparer<Nullable<RectInt>>.CreateComparer
	|
	|-RVA: 0x32D10C0 Offset: 0x32D11C1 VA: 0x32D10C0
	|-EqualityComparer<Nullable<Vector2>>.CreateComparer
	|
	|-RVA: 0x32D1C60 Offset: 0x32D1D61 VA: 0x32D1C60
	|-EqualityComparer<Nullable<Vector2Int>>.CreateComparer
	|
	|-RVA: 0x32D2800 Offset: 0x32D2901 VA: 0x32D2800
	|-EqualityComparer<Nullable<Vector3>>.CreateComparer
	|
	|-RVA: 0x32D3370 Offset: 0x32D3471 VA: 0x32D3370
	|-EqualityComparer<Nullable<Vector3Int>>.CreateComparer
	|
	|-RVA: 0x32D3EE0 Offset: 0x32D3FE1 VA: 0x32D3EE0
	|-EqualityComparer<Nullable<Vector4>>.CreateComparer
	|
	|-RVA: 0x32D4B60 Offset: 0x32D4C61 VA: 0x32D4B60
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x32D5680 Offset: 0x32D5781 VA: 0x32D5680
	|-EqualityComparer<ReadOnlyMemory<object>>.CreateComparer
	|
	|-RVA: 0x32D61F0 Offset: 0x32D62F1 VA: 0x32D61F0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x32D6D30 Offset: 0x32D6E31 VA: 0x32D6D30
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x32D78A0 Offset: 0x32D79A1 VA: 0x32D78A0
	|-EqualityComparer<RuntimeTypeHandle>.CreateComparer
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x32D8F20 Offset: 0x32D9021 VA: 0x32D8F20
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x32D9A70 Offset: 0x32D9B71 VA: 0x32D9A70
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x32DB0F0 Offset: 0x32DB1F1 VA: 0x32DB0F0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x32DBC30 Offset: 0x32DBD31 VA: 0x32DBC30
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DC770 Offset: 0x32DC871 VA: 0x32DC770
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x32DD2B0 Offset: 0x32DD3B1 VA: 0x32DD2B0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x32DDE20 Offset: 0x32DDF21 VA: 0x32DDE20
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DE990 Offset: 0x32DEA91 VA: 0x32DE990
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x32E0070 Offset: 0x32E0171 VA: 0x32E0070
	|-EqualityComparer<ValueTuple<float, float>>.CreateComparer
	|
	|-RVA: 0x32E0BE0 Offset: 0x32E0CE1 VA: 0x32E0BE0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CreateComparer
	|
	|-RVA: 0x32E24A0 Offset: 0x32E25A1 VA: 0x32E24A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x32E31D0 Offset: 0x32E32D1 VA: 0x32E31D0
	|-EqualityComparer<TransitionTables>.CreateComparer
	|
	|-RVA: 0x32E3E20 Offset: 0x32E3F21 VA: 0x32E3E20
	|-EqualityComparer<TutorialUnlockFlagData>.CreateComparer
	|
	|-RVA: 0x32E49B0 Offset: 0x32E4AB1 VA: 0x32E49B0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.CreateComparer
	|
	|-RVA: 0x32E5520 Offset: 0x32E5621 VA: 0x32E5520
	|-EqualityComparer<CapEdge>.CreateComparer
	|
	|-RVA: 0x30F15C0 Offset: 0x30F16C1 VA: 0x30F15C0
	|-EqualityComparer<ClippedEdge>.CreateComparer
	|
	|-RVA: 0x30F2210 Offset: 0x30F2311 VA: 0x30F2210
	|-EqualityComparer<EdgeKeyByHash>.CreateComparer
	|
	|-RVA: 0x30F2D50 Offset: 0x30F2E51 VA: 0x30F2D50
	|-EqualityComparer<EdgeKeyByIndex>.CreateComparer
	|
	|-RVA: 0x30F3890 Offset: 0x30F3991 VA: 0x30F3890
	|-EqualityComparer<MeshDataConnectivity.Face>.CreateComparer
	|
	|-RVA: 0x30F43D0 Offset: 0x30F44D1 VA: 0x30F43D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.CreateComparer
	|
	|-RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.CreateComparer
	|
	|-RVA: 0x30F5CE0 Offset: 0x30F5DE1 VA: 0x30F5CE0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x30F76D0 Offset: 0x30F77D1 VA: 0x30F76D0
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x30F8240 Offset: 0x30F8341 VA: 0x30F8240
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x30F8D80 Offset: 0x30F8E81 VA: 0x30F8D80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x30FA540 Offset: 0x30FA641 VA: 0x30FA540
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x30FB190 Offset: 0x30FB291 VA: 0x30FB190
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x30FBDE0 Offset: 0x30FBEE1 VA: 0x30FBDE0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x30FC920 Offset: 0x30FCA21 VA: 0x30FC920
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x30FD4F0 Offset: 0x30FD5F1 VA: 0x30FD4F0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x30FE370 Offset: 0x30FE471 VA: 0x30FE370
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	|
	|-RVA: 0x30FFC50 Offset: 0x30FFD51 VA: 0x30FFC50
	|-EqualityComparer<GradientAlphaKey>.CreateComparer
	|
	|-RVA: 0x31007C0 Offset: 0x31008C1 VA: 0x31007C0
	|-EqualityComparer<GradientColorKey>.CreateComparer
	|
	|-RVA: 0x3101410 Offset: 0x3101511 VA: 0x3101410
	|-EqualityComparer<Keyframe>.CreateComparer
	|
	|-RVA: 0x31020D0 Offset: 0x31021D1 VA: 0x31020D0
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3102C10 Offset: 0x3102D11 VA: 0x3102C10
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3103940 Offset: 0x3103A41 VA: 0x3103940
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x31045C0 Offset: 0x31046C1 VA: 0x31045C0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3105130 Offset: 0x3105231 VA: 0x3105130
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3105D80 Offset: 0x3105E81 VA: 0x3105D80
	|-EqualityComparer<PlayableGraph>.CreateComparer
	|
	|-RVA: 0x31068F0 Offset: 0x31069F1 VA: 0x31068F0
	|-EqualityComparer<Edge>.CreateComparer
	|
	|-RVA: 0x3107430 Offset: 0x3107531 VA: 0x3107430
	|-EqualityComparer<IntVec3>.CreateComparer
	|
	|-RVA: 0x3108000 Offset: 0x3108101 VA: 0x3108000
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3108BD0 Offset: 0x3108CD1 VA: 0x3108BD0
	|-EqualityComparer<RangeInt>.CreateComparer
	|
	|-RVA: 0x3109710 Offset: 0x3109811 VA: 0x3109710
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x310A400 Offset: 0x310A501 VA: 0x310A400
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x310B130 Offset: 0x310B231 VA: 0x310B130
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x310BD00 Offset: 0x310BE01 VA: 0x310BD00
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x310C870 Offset: 0x310C971 VA: 0x310C870
	|-EqualityComparer<ReflectionProbeBlendInfo>.CreateComparer
	|
	|-RVA: 0x310D3E0 Offset: 0x310D4E1 VA: 0x310D3E0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x310E2E0 Offset: 0x310E3E1 VA: 0x310E2E0
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x310EE50 Offset: 0x310EF51 VA: 0x310EE50
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x2EA71B0 Offset: 0x2EA72B1 VA: 0x2EA71B0
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x2EA7E00 Offset: 0x2EA7F01 VA: 0x2EA7E00
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.CreateComparer
	|
	|-RVA: 0x2EA8A50 Offset: 0x2EA8B51 VA: 0x2EA8A50
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x2EA9710 Offset: 0x2EA9811 VA: 0x2EA9710
	|-EqualityComparer<SceneInstance>.CreateComparer
	|
	|-RVA: 0x2EAA280 Offset: 0x2EAA381 VA: 0x2EAA280
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x2EAAED0 Offset: 0x2EAAFD1 VA: 0x2EAAED0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x2EABB90 Offset: 0x2EABC91 VA: 0x2EABB90
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x2EAC700 Offset: 0x2EAC801 VA: 0x2EAC700
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x2EAD3D0 Offset: 0x2EAD4D1 VA: 0x2EAD3D0
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x2EAE020 Offset: 0x2EAE121 VA: 0x2EAE020
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x2EAEC70 Offset: 0x2EAED71 VA: 0x2EAEC70
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x2EAF8C0 Offset: 0x2EAF9C1 VA: 0x2EAF8C0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x2EB06D0 Offset: 0x2EB07D1 VA: 0x2EB06D0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x2EB13A0 Offset: 0x2EB14A1 VA: 0x2EB13A0
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x2EB2BC0 Offset: 0x2EB2CC1 VA: 0x2EB2BC0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x2EB3730 Offset: 0x2EB3831 VA: 0x2EB3730
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x2EB42A0 Offset: 0x2EB43A1 VA: 0x2EB42A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x2EB4DE0 Offset: 0x2EB4EE1 VA: 0x2EB4DE0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x2EB5950 Offset: 0x2EB5A51 VA: 0x2EB5950
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x2EB6760 Offset: 0x2EB6861 VA: 0x2EB6760
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2EB73B0 Offset: 0x2EB74B1 VA: 0x2EB73B0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2EB7F20 Offset: 0x2EB8021 VA: 0x2EB7F20
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x2EB8A60 Offset: 0x2EB8B61 VA: 0x2EB8A60
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2EB9630 Offset: 0x2EB9731 VA: 0x2EB9630
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x2EBA1C0 Offset: 0x2EBA2C1 VA: 0x2EBA1C0
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x2EBAD90 Offset: 0x2EBAE91 VA: 0x2EBAD90
	|-EqualityComparer<WarpPoints.WarpPoint>.CreateComparer
	|
	|-RVA: 0x2EBBC80 Offset: 0x2EBBD81 VA: 0x2EBBC80
	|-EqualityComparer<YieldItemParam>.CreateComparer
	|
	|-RVA: 0x2EBC7C0 Offset: 0x2EBC8C1 VA: 0x2EBC7C0
	|-EqualityComparer<stCommand_t>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E910 Offset: 0x2E3EA11 VA: 0x2E3E910
	|-EqualityComparer<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2E3F560 Offset: 0x2E3F661 VA: 0x2E3F560
	|-EqualityComparer<JSONDeserialization.TaskField>.IndexOf
	|
	|-RVA: 0x2E400D0 Offset: 0x2E401D1 VA: 0x2E400D0
	|-EqualityComparer<BitVector32Int>.IndexOf
	|
	|-RVA: 0x2E40C10 Offset: 0x2E40D11 VA: 0x2E40C10
	|-EqualityComparer<BuildItemData>.IndexOf
	|
	|-RVA: 0x2E41B00 Offset: 0x2E41C01 VA: 0x2E41B00
	|-EqualityComparer<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2E42670 Offset: 0x2E42771 VA: 0x2E42670
	|-EqualityComparer<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2E431E0 Offset: 0x2E432E1 VA: 0x2E431E0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2E43D70 Offset: 0x2E43E71 VA: 0x2E43D70
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2E448E0 Offset: 0x2E449E1 VA: 0x2E448E0
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2E45420 Offset: 0x2E45521 VA: 0x2E45420
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2E45F60 Offset: 0x2E46061 VA: 0x2E45F60
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2E46C20 Offset: 0x2E46D21 VA: 0x2E46C20
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2E47910 Offset: 0x2E47A11 VA: 0x2E47910
	|-EqualityComparer<CropDataTable>.IndexOf
	|
	|-RVA: 0x2E48570 Offset: 0x2E48671 VA: 0x2E48570
	|-EqualityComparer<DropItemParam>.IndexOf
	|
	|-RVA: 0x2E490B0 Offset: 0x2E491B1 VA: 0x2E490B0
	|-EqualityComparer<EffectDataTable>.IndexOf
	|
	|-RVA: 0x2E49D00 Offset: 0x2E49E01 VA: 0x2E49D00
	|-EqualityComparer<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2E4A950 Offset: 0x2E4AA51 VA: 0x2E4A950
	|-EqualityComparer<EventCheckId>.IndexOf
	|
	|-RVA: 0x2E4B5A0 Offset: 0x2E4B6A1 VA: 0x2E4B5A0
	|-EqualityComparer<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2E4C110 Offset: 0x2E4C211 VA: 0x2E4C110
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.IndexOf
	|
	|-RVA: 0x2E4CE70 Offset: 0x2E4CF71 VA: 0x2E4CE70
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.IndexOf
	|
	|-RVA: 0x2E4DAC0 Offset: 0x2E4DBC1 VA: 0x2E4DAC0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.IndexOf
	|
	|-RVA: 0x2E4E650 Offset: 0x2E4E751 VA: 0x2E4E650
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.IndexOf
	|
	|-RVA: 0x2E4F1C0 Offset: 0x2E4F2C1 VA: 0x2E4F1C0
	|-EqualityComparer<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2E4FD30 Offset: 0x2E4FE31 VA: 0x2E4FD30
	|-EqualityComparer<GimmickLayoutDataTable>.IndexOf
	|
	|-RVA: 0x2E50870 Offset: 0x2E50971 VA: 0x2E50870
	|-EqualityComparer<MineTypeDataTable>.IndexOf
	|
	|-RVA: 0x2E515A0 Offset: 0x2E516A1 VA: 0x2E515A0
	|-EqualityComparer<MiningDataTable>.IndexOf
	|
	|-RVA: 0x2E52110 Offset: 0x2E52211 VA: 0x2E52110
	|-EqualityComparer<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2E52E00 Offset: 0x2E52F01 VA: 0x2E52E00
	|-EqualityComparer<MonsterDataTable>.IndexOf
	|
	|-RVA: 0x2E53A80 Offset: 0x2E53B81 VA: 0x2E53A80
	|-EqualityComparer<MonsterFootStepEventDataTable>.IndexOf
	|
	|-RVA: 0x2E54740 Offset: 0x2E54841 VA: 0x2E54740
	|-EqualityComparer<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2E55410 Offset: 0x2E55511 VA: 0x2E55410
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x2E55F80 Offset: 0x2E56081 VA: 0x2E55F80
	|-EqualityComparer<NPCActionData>.IndexOf
	|
	|-RVA: 0x2E56CB0 Offset: 0x2E56DB1 VA: 0x2E56CB0
	|-EqualityComparer<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	|-EqualityComparer<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31FE9C0 Offset: 0x31FEAC1 VA: 0x31FE9C0
	|-EqualityComparer<OrderSaveData>.IndexOf
	|
	|-RVA: 0x31FF690 Offset: 0x31FF791 VA: 0x31FF690
	|-EqualityComparer<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32002E0 Offset: 0x32003E1 VA: 0x32002E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3200E50 Offset: 0x3200F51 VA: 0x3200E50
	|-EqualityComparer<Parameter>.IndexOf
	|
	|-RVA: 0x3201AD0 Offset: 0x3201BD1 VA: 0x3201AD0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.IndexOf
	|
	|-RVA: 0x3202640 Offset: 0x3202741 VA: 0x3202640
	|-EqualityComparer<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32031B0 Offset: 0x32032B1 VA: 0x32031B0
	|-EqualityComparer<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x3203E70 Offset: 0x3203F71 VA: 0x3203E70
	|-EqualityComparer<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3204A00 Offset: 0x3204B01 VA: 0x3204A00
	|-EqualityComparer<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3205540 Offset: 0x3205641 VA: 0x3205540
	|-EqualityComparer<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32060D0 Offset: 0x32061D1 VA: 0x32060D0
	|-EqualityComparer<ProfilerFrame>.IndexOf
	|
	|-RVA: 0x3206CA0 Offset: 0x3206DA1 VA: 0x3206CA0
	|-EqualityComparer<NumberControl.ValueRange>.IndexOf
	|
	|-RVA: 0x3207810 Offset: 0x3207911 VA: 0x3207810
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x3208460 Offset: 0x3208561 VA: 0x3208460
	|-EqualityComparer<Schedule>.IndexOf
	|
	|-RVA: 0x32090B0 Offset: 0x32091B1 VA: 0x32090B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3209C20 Offset: 0x3209D21 VA: 0x3209C20
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x320A7B0 Offset: 0x320A8B1 VA: 0x320A7B0
	|-EqualityComparer<CurveSample>.IndexOf
	|
	|-RVA: 0x320B550 Offset: 0x320B651 VA: 0x320B550
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x320C0A0 Offset: 0x320C1A1 VA: 0x320C0A0
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x320D720 Offset: 0x320D821 VA: 0x320D720
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x320E290 Offset: 0x320E391 VA: 0x320E290
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x320EDD0 Offset: 0x320EED1 VA: 0x320EDD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x320F940 Offset: 0x320FA41 VA: 0x320F940
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3210480 Offset: 0x3210581 VA: 0x3210480
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3210FF0 Offset: 0x32110F1 VA: 0x3210FF0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3211B30 Offset: 0x3211C31 VA: 0x3211B30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x32126A0 Offset: 0x32127A1 VA: 0x32126A0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x32131F0 Offset: 0x32132F1 VA: 0x32131F0
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3213D60 Offset: 0x3213E61 VA: 0x3213D60
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x32148A0 Offset: 0x32149A1 VA: 0x32148A0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x32153E0 Offset: 0x32154E1 VA: 0x32153E0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3216A60 Offset: 0x3216B61 VA: 0x3216A60
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x32175D0 Offset: 0x32176D1 VA: 0x32175D0
	|-EqualityComparer<Memory<object>>.IndexOf
	|
	|-RVA: 0x3218140 Offset: 0x3218241 VA: 0x3218140
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.IndexOf
	|
	|-RVA: 0x3218E30 Offset: 0x3218F31 VA: 0x3218E30
	|-EqualityComparer<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3219980 Offset: 0x3219A81 VA: 0x3219980
	|-EqualityComparer<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x321A670 Offset: 0x321A771 VA: 0x321A670
	|-EqualityComparer<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x321B360 Offset: 0x321B461 VA: 0x321B360
	|-EqualityComparer<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x32C9B70 Offset: 0x32C9C71 VA: 0x32C9B70
	|-EqualityComparer<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x32CA7F0 Offset: 0x32CA8F1 VA: 0x32CA7F0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-EqualityComparer<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x32CC010 Offset: 0x32CC111 VA: 0x32CC010
	|-EqualityComparer<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x32CCC90 Offset: 0x32CCD91 VA: 0x32CCC90
	|-EqualityComparer<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x32CD7E0 Offset: 0x32CD8E1 VA: 0x32CD7E0
	|-EqualityComparer<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32CE5E0 Offset: 0x32CE6E1 VA: 0x32CE5E0
	|-EqualityComparer<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32CF260 Offset: 0x32CF361 VA: 0x32CF260
	|-EqualityComparer<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32CFE00 Offset: 0x32CFF01 VA: 0x32CFE00
	|-EqualityComparer<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x32D0A80 Offset: 0x32D0B81 VA: 0x32D0A80
	|-EqualityComparer<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x32D1700 Offset: 0x32D1801 VA: 0x32D1700
	|-EqualityComparer<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32D22A0 Offset: 0x32D23A1 VA: 0x32D22A0
	|-EqualityComparer<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32D2E40 Offset: 0x32D2F41 VA: 0x32D2E40
	|-EqualityComparer<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x32D39B0 Offset: 0x32D3AB1 VA: 0x32D39B0
	|-EqualityComparer<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-EqualityComparer<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x32D51A0 Offset: 0x32D52A1 VA: 0x32D51A0
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-EqualityComparer<ReadOnlyMemory<object>>.IndexOf
	|
	|-RVA: 0x32D6830 Offset: 0x32D6931 VA: 0x32D6830
	|-EqualityComparer<Label>.IndexOf
	|
	|-RVA: 0x32D7370 Offset: 0x32D7471 VA: 0x32D7370
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x32D7EE0 Offset: 0x32D7FE1 VA: 0x32D7EE0
	|-EqualityComparer<RuntimeTypeHandle>.IndexOf
	|
	|-RVA: 0x32D8A20 Offset: 0x32D8B21 VA: 0x32D8A20
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x32D9560 Offset: 0x32D9661 VA: 0x32D9560
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x32DA0B0 Offset: 0x32DA1B1 VA: 0x32DA0B0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x32DABF0 Offset: 0x32DACF1 VA: 0x32DABF0
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x32DB730 Offset: 0x32DB831 VA: 0x32DB730
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x32DC270 Offset: 0x32DC371 VA: 0x32DC270
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DCDB0 Offset: 0x32DCEB1 VA: 0x32DCDB0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32DE460 Offset: 0x32DE561 VA: 0x32DE460
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DEFD0 Offset: 0x32DF0D1 VA: 0x32DEFD0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32DFB40 Offset: 0x32DFC41 VA: 0x32DFB40
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32E06B0 Offset: 0x32E07B1 VA: 0x32E06B0
	|-EqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x32E1220 Offset: 0x32E1321 VA: 0x32E1220
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32E1DB0 Offset: 0x32E1EB1 VA: 0x32E1DB0
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32E3810 Offset: 0x32E3911 VA: 0x32E3810
	|-EqualityComparer<TransitionTables>.IndexOf
	|
	|-RVA: 0x32E4460 Offset: 0x32E4561 VA: 0x32E4460
	|-EqualityComparer<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32E4FF0 Offset: 0x32E50F1 VA: 0x32E4FF0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32E5B60 Offset: 0x32E5C61 VA: 0x32E5B60
	|-EqualityComparer<CapEdge>.IndexOf
	|
	|-RVA: 0x30F1C00 Offset: 0x30F1D01 VA: 0x30F1C00
	|-EqualityComparer<ClippedEdge>.IndexOf
	|
	|-RVA: 0x30F2850 Offset: 0x30F2951 VA: 0x30F2850
	|-EqualityComparer<EdgeKeyByHash>.IndexOf
	|
	|-RVA: 0x30F3390 Offset: 0x30F3491 VA: 0x30F3390
	|-EqualityComparer<EdgeKeyByIndex>.IndexOf
	|
	|-RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	|-EqualityComparer<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x30F4A10 Offset: 0x30F4B11 VA: 0x30F4A10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x30F5660 Offset: 0x30F5761 VA: 0x30F5660
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x30F6320 Offset: 0x30F6421 VA: 0x30F6320
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x30F6E90 Offset: 0x30F6F91 VA: 0x30F6E90
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x30F7D10 Offset: 0x30F7E11 VA: 0x30F7D10
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x30F8880 Offset: 0x30F8981 VA: 0x30F8880
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x30F93C0 Offset: 0x30F94C1 VA: 0x30F93C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x30F9F30 Offset: 0x30FA031 VA: 0x30F9F30
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x30FAB80 Offset: 0x30FAC81 VA: 0x30FAB80
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x30FB7D0 Offset: 0x30FB8D1 VA: 0x30FB7D0
	|-EqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x30FC420 Offset: 0x30FC521 VA: 0x30FC420
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x30FCF60 Offset: 0x30FD061 VA: 0x30FCF60
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x30FDB30 Offset: 0x30FDC31 VA: 0x30FDB30
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x30FE9B0 Offset: 0x30FEAB1 VA: 0x30FE9B0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x30FF750 Offset: 0x30FF851 VA: 0x30FF750
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	|
	|-RVA: 0x3100290 Offset: 0x3100391 VA: 0x3100290
	|-EqualityComparer<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x3100E00 Offset: 0x3100F01 VA: 0x3100E00
	|-EqualityComparer<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3101A50 Offset: 0x3101B51 VA: 0x3101A50
	|-EqualityComparer<Keyframe>.IndexOf
	|
	|-RVA: 0x3102710 Offset: 0x3102811 VA: 0x3102710
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3103250 Offset: 0x3103351 VA: 0x3103250
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3103F80 Offset: 0x3104081 VA: 0x3103F80
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3104C00 Offset: 0x3104D01 VA: 0x3104C00
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3105770 Offset: 0x3105871 VA: 0x3105770
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	|-EqualityComparer<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3106F30 Offset: 0x3107031 VA: 0x3106F30
	|-EqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x3107A70 Offset: 0x3107B71 VA: 0x3107A70
	|-EqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x3108640 Offset: 0x3108741 VA: 0x3108640
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3109210 Offset: 0x3109311 VA: 0x3109210
	|-EqualityComparer<RangeInt>.IndexOf
	|
	|-RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x310AA40 Offset: 0x310AB41 VA: 0x310AA40
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x310B770 Offset: 0x310B871 VA: 0x310B770
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x310C340 Offset: 0x310C441 VA: 0x310C340
	|-EqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x310CEB0 Offset: 0x310CFB1 VA: 0x310CEB0
	|-EqualityComparer<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x310DA20 Offset: 0x310DB21 VA: 0x310DA20
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x310E920 Offset: 0x310EA21 VA: 0x310E920
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x310F490 Offset: 0x310F591 VA: 0x310F490
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x2EA77F0 Offset: 0x2EA78F1 VA: 0x2EA77F0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EA8440 Offset: 0x2EA8541 VA: 0x2EA8440
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EA9090 Offset: 0x2EA9191 VA: 0x2EA9090
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2EA9D50 Offset: 0x2EA9E51 VA: 0x2EA9D50
	|-EqualityComparer<SceneInstance>.IndexOf
	|
	|-RVA: 0x2EAA8C0 Offset: 0x2EAA9C1 VA: 0x2EAA8C0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2EAB510 Offset: 0x2EAB611 VA: 0x2EAB510
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2EAC1D0 Offset: 0x2EAC2D1 VA: 0x2EAC1D0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EACD40 Offset: 0x2EACE41 VA: 0x2EACD40
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2EADA10 Offset: 0x2EADB11 VA: 0x2EADA10
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2EAE660 Offset: 0x2EAE761 VA: 0x2EAE660
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2EAF2B0 Offset: 0x2EAF3B1 VA: 0x2EAF2B0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2EAFF00 Offset: 0x2EB0001 VA: 0x2EAFF00
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EB0D10 Offset: 0x2EB0E11 VA: 0x2EB0D10
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EB2630 Offset: 0x2EB2731 VA: 0x2EB2630
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x2EB3200 Offset: 0x2EB3301 VA: 0x2EB3200
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|
	|-RVA: 0x2EB3D70 Offset: 0x2EB3E71 VA: 0x2EB3D70
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2EB48E0 Offset: 0x2EB49E1 VA: 0x2EB48E0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|
	|-RVA: 0x2EB5420 Offset: 0x2EB5521 VA: 0x2EB5420
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x2EB5F90 Offset: 0x2EB6091 VA: 0x2EB5F90
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x2EB6DA0 Offset: 0x2EB6EA1 VA: 0x2EB6DA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2EB79F0 Offset: 0x2EB7AF1 VA: 0x2EB79F0
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EB8560 Offset: 0x2EB8661 VA: 0x2EB8560
	|-EqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EB90A0 Offset: 0x2EB91A1 VA: 0x2EB90A0
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EB9C70 Offset: 0x2EB9D71 VA: 0x2EB9C70
	|-EqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EBA800 Offset: 0x2EBA901 VA: 0x2EBA800
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2EBB3D0 Offset: 0x2EBB4D1 VA: 0x2EBB3D0
	|-EqualityComparer<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2EBC2C0 Offset: 0x2EBC3C1 VA: 0x2EBC2C0
	|-EqualityComparer<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2EBCE00 Offset: 0x2EBCF01 VA: 0x2EBCE00
	|-EqualityComparer<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EA30 Offset: 0x2E3EB31 VA: 0x2E3EA30
	|-EqualityComparer<AS_ToolController.ChargeInfo>.LastIndexOf
	|
	|-RVA: 0x2E3F630 Offset: 0x2E3F731 VA: 0x2E3F630
	|-EqualityComparer<JSONDeserialization.TaskField>.LastIndexOf
	|
	|-RVA: 0x2E40190 Offset: 0x2E40291 VA: 0x2E40190
	|-EqualityComparer<BitVector32Int>.LastIndexOf
	|
	|-RVA: 0x2E40DF0 Offset: 0x2E40EF1 VA: 0x2E40DF0
	|-EqualityComparer<BuildItemData>.LastIndexOf
	|
	|-RVA: 0x2E41BD0 Offset: 0x2E41CD1 VA: 0x2E41BD0
	|-EqualityComparer<ButtonLinker.LinkObject>.LastIndexOf
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-EqualityComparer<CharaCallTable.BustupTable>.LastIndexOf
	|
	|-RVA: 0x2E432C0 Offset: 0x2E433C1 VA: 0x2E432C0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.LastIndexOf
	|
	|-RVA: 0x2E43E40 Offset: 0x2E43F41 VA: 0x2E43E40
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x2E449A0 Offset: 0x2E44AA1 VA: 0x2E449A0
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x2E454E0 Offset: 0x2E455E1 VA: 0x2E454E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x2E460A0 Offset: 0x2E461A1 VA: 0x2E460A0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x2E46D70 Offset: 0x2E46E71 VA: 0x2E46D70
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x2E47A30 Offset: 0x2E47B31 VA: 0x2E47A30
	|-EqualityComparer<CropDataTable>.LastIndexOf
	|
	|-RVA: 0x2E48630 Offset: 0x2E48731 VA: 0x2E48630
	|-EqualityComparer<DropItemParam>.LastIndexOf
	|
	|-RVA: 0x2E491D0 Offset: 0x2E492D1 VA: 0x2E491D0
	|-EqualityComparer<EffectDataTable>.LastIndexOf
	|
	|-RVA: 0x2E49E20 Offset: 0x2E49F21 VA: 0x2E49E20
	|-EqualityComparer<ErosionBrush.UndoStep>.LastIndexOf
	|
	|-RVA: 0x2E4AA70 Offset: 0x2E4AB71 VA: 0x2E4AA70
	|-EqualityComparer<EventCheckId>.LastIndexOf
	|
	|-RVA: 0x2E4B670 Offset: 0x2E4B771 VA: 0x2E4B670
	|-EqualityComparer<EventFlagProgressData>.LastIndexOf
	|
	|-RVA: 0x2E4C280 Offset: 0x2E4C381 VA: 0x2E4C280
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.LastIndexOf
	|
	|-RVA: 0x2E4CF90 Offset: 0x2E4D091 VA: 0x2E4CF90
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4DBA0 Offset: 0x2E4DCA1 VA: 0x2E4DBA0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4E720 Offset: 0x2E4E821 VA: 0x2E4E720
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4F290 Offset: 0x2E4F391 VA: 0x2E4F290
	|-EqualityComparer<FesNpcScoreData>.LastIndexOf
	|
	|-RVA: 0x2E4FDF0 Offset: 0x2E4FEF1 VA: 0x2E4FDF0
	|-EqualityComparer<GimmickLayoutDataTable>.LastIndexOf
	|
	|-RVA: 0x2E509D0 Offset: 0x2E50AD1 VA: 0x2E509D0
	|-EqualityComparer<MineTypeDataTable>.LastIndexOf
	|
	|-RVA: 0x2E51670 Offset: 0x2E51771 VA: 0x2E51670
	|-EqualityComparer<MiningDataTable>.LastIndexOf
	|
	|-RVA: 0x2E52260 Offset: 0x2E52361 VA: 0x2E52260
	|-EqualityComparer<MiningPointSaveData>.LastIndexOf
	|
	|-RVA: 0x2E52F20 Offset: 0x2E53021 VA: 0x2E52F20
	|-EqualityComparer<MonsterDataTable>.LastIndexOf
	|
	|-RVA: 0x2E53BC0 Offset: 0x2E53CC1 VA: 0x2E53BC0
	|-EqualityComparer<MonsterFootStepEventDataTable>.LastIndexOf
	|
	|-RVA: 0x2E54880 Offset: 0x2E54981 VA: 0x2E54880
	|-EqualityComparer<MonsterHutSaveData>.LastIndexOf
	|
	|-RVA: 0x2E554E0 Offset: 0x2E555E1 VA: 0x2E554E0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.LastIndexOf
	|
	|-RVA: 0x2E560E0 Offset: 0x2E561E1 VA: 0x2E560E0
	|-EqualityComparer<NPCActionData>.LastIndexOf
	|
	|-RVA: 0x2E56DD0 Offset: 0x2E56ED1 VA: 0x2E56DD0
	|-EqualityComparer<NpcPlaceSchedule>.LastIndexOf
	|
	|-RVA: 0x2E579E0 Offset: 0x2E57AE1 VA: 0x2E579E0
	|-EqualityComparer<OrderLotterySaveParameter>.LastIndexOf
	|
	|-RVA: 0x31FEB00 Offset: 0x31FEC01 VA: 0x31FEB00
	|-EqualityComparer<OrderSaveData>.LastIndexOf
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-EqualityComparer<OrderSaveParameter>.LastIndexOf
	|
	|-RVA: 0x32003B0 Offset: 0x32004B1 VA: 0x32003B0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3200F70 Offset: 0x3201071 VA: 0x3200F70
	|-EqualityComparer<Parameter>.LastIndexOf
	|
	|-RVA: 0x3201BA0 Offset: 0x3201CA1 VA: 0x3201BA0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.LastIndexOf
	|
	|-RVA: 0x3202710 Offset: 0x3202811 VA: 0x3202710
	|-EqualityComparer<ShopCatalogPage>.LastIndexOf
	|
	|-RVA: 0x32032F0 Offset: 0x32033F1 VA: 0x32032F0
	|-EqualityComparer<ShopNpcTalk>.LastIndexOf
	|
	|-RVA: 0x3203F50 Offset: 0x3204051 VA: 0x3203F50
	|-EqualityComparer<SubtitleDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x3204AC0 Offset: 0x3204BC1 VA: 0x3204AC0
	|-EqualityComparer<SubtitleDataTable.DataList>.LastIndexOf
	|
	|-RVA: 0x3205620 Offset: 0x3205721 VA: 0x3205620
	|-EqualityComparer<SubtitleHudDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x32061C0 Offset: 0x32062C1 VA: 0x32061C0
	|-EqualityComparer<ProfilerFrame>.LastIndexOf
	|
	|-RVA: 0x3206D70 Offset: 0x3206E71 VA: 0x3206D70
	|-EqualityComparer<NumberControl.ValueRange>.LastIndexOf
	|
	|-RVA: 0x3207930 Offset: 0x3207A31 VA: 0x3207930
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.LastIndexOf
	|
	|-RVA: 0x3208580 Offset: 0x3208681 VA: 0x3208580
	|-EqualityComparer<Schedule>.LastIndexOf
	|
	|-RVA: 0x3209180 Offset: 0x3209281 VA: 0x3209180
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3209D00 Offset: 0x3209E01 VA: 0x3209D00
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x320A930 Offset: 0x320AA31 VA: 0x320A930
	|-EqualityComparer<CurveSample>.LastIndexOf
	|
	|-RVA: 0x320B610 Offset: 0x320B711 VA: 0x320B610
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x320C160 Offset: 0x320C261 VA: 0x320C160
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x320CCA0 Offset: 0x320CDA1 VA: 0x320CCA0
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x320D7F0 Offset: 0x320D8F1 VA: 0x320D7F0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x320E350 Offset: 0x320E451 VA: 0x320E350
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x320FA00 Offset: 0x320FB01 VA: 0x320FA00
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3210550 Offset: 0x3210651 VA: 0x3210550
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x32110B0 Offset: 0x32111B1 VA: 0x32110B0
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3211C00 Offset: 0x3211D01 VA: 0x3211C00
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3212760 Offset: 0x3212861 VA: 0x3212760
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x32132C0 Offset: 0x32133C1 VA: 0x32132C0
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3213E20 Offset: 0x3213F21 VA: 0x3213E20
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3214960 Offset: 0x3214A61 VA: 0x3214960
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3215FE0 Offset: 0x32160E1 VA: 0x3215FE0
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3216B30 Offset: 0x3216C31 VA: 0x3216B30
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x32176A0 Offset: 0x32177A1 VA: 0x32176A0
	|-EqualityComparer<Memory<object>>.LastIndexOf
	|
	|-RVA: 0x3218280 Offset: 0x3218381 VA: 0x3218280
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.LastIndexOf
	|
	|-RVA: 0x3218EF0 Offset: 0x3218FF1 VA: 0x3218EF0
	|-EqualityComparer<Nullable<Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x3219AC0 Offset: 0x3219BC1 VA: 0x3219AC0
	|-EqualityComparer<Nullable<Bounds>>.LastIndexOf
	|
	|-RVA: 0x321A7B0 Offset: 0x321A8B1 VA: 0x321A7B0
	|-EqualityComparer<Nullable<BoundsInt>>.LastIndexOf
	|
	|-RVA: 0x321B420 Offset: 0x321B521 VA: 0x321B420
	|-EqualityComparer<Nullable<Color32>>.LastIndexOf
	|
	|-RVA: 0x32C9C90 Offset: 0x32C9D91 VA: 0x32C9C90
	|-EqualityComparer<Nullable<Color>>.LastIndexOf
	|
	|-RVA: 0x32CA8D0 Offset: 0x32CA9D1 VA: 0x32CA8D0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.LastIndexOf
	|
	|-RVA: 0x32CB4B0 Offset: 0x32CB5B1 VA: 0x32CB4B0
	|-EqualityComparer<Nullable<GradientColorKey>>.LastIndexOf
	|
	|-RVA: 0x32CC130 Offset: 0x32CC231 VA: 0x32CC130
	|-EqualityComparer<Nullable<Keyframe>>.LastIndexOf
	|
	|-RVA: 0x32CCD50 Offset: 0x32CCE51 VA: 0x32CCD50
	|-EqualityComparer<Nullable<LayerMask>>.LastIndexOf
	|
	|-RVA: 0x32CD970 Offset: 0x32CDA71 VA: 0x32CD970
	|-EqualityComparer<Nullable<Matrix4x4>>.LastIndexOf
	|
	|-RVA: 0x32CE700 Offset: 0x32CE801 VA: 0x32CE700
	|-EqualityComparer<Nullable<Quaternion>>.LastIndexOf
	|
	|-RVA: 0x32CF340 Offset: 0x32CF441 VA: 0x32CF340
	|-EqualityComparer<Nullable<RangeInt>>.LastIndexOf
	|
	|-RVA: 0x32CFF20 Offset: 0x32D0021 VA: 0x32CFF20
	|-EqualityComparer<Nullable<Rect>>.LastIndexOf
	|
	|-RVA: 0x32D0BA0 Offset: 0x32D0CA1 VA: 0x32D0BA0
	|-EqualityComparer<Nullable<RectInt>>.LastIndexOf
	|
	|-RVA: 0x32D17E0 Offset: 0x32D18E1 VA: 0x32D17E0
	|-EqualityComparer<Nullable<Vector2>>.LastIndexOf
	|
	|-RVA: 0x32D2380 Offset: 0x32D2481 VA: 0x32D2380
	|-EqualityComparer<Nullable<Vector2Int>>.LastIndexOf
	|
	|-RVA: 0x32D2F10 Offset: 0x32D3011 VA: 0x32D2F10
	|-EqualityComparer<Nullable<Vector3>>.LastIndexOf
	|
	|-RVA: 0x32D3A80 Offset: 0x32D3B81 VA: 0x32D3A80
	|-EqualityComparer<Nullable<Vector3Int>>.LastIndexOf
	|
	|-RVA: 0x32D4640 Offset: 0x32D4741 VA: 0x32D4640
	|-EqualityComparer<Nullable<Vector4>>.LastIndexOf
	|
	|-RVA: 0x32D5260 Offset: 0x32D5361 VA: 0x32D5260
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x32D5D90 Offset: 0x32D5E91 VA: 0x32D5D90
	|-EqualityComparer<ReadOnlyMemory<object>>.LastIndexOf
	|
	|-RVA: 0x32D68F0 Offset: 0x32D69F1 VA: 0x32D68F0
	|-EqualityComparer<Label>.LastIndexOf
	|
	|-RVA: 0x32D7440 Offset: 0x32D7541 VA: 0x32D7440
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x32D7FA0 Offset: 0x32D80A1 VA: 0x32D7FA0
	|-EqualityComparer<RuntimeTypeHandle>.LastIndexOf
	|
	|-RVA: 0x32D8AE0 Offset: 0x32D8BE1 VA: 0x32D8AE0
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x32D9620 Offset: 0x32D9721 VA: 0x32D9620
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x32DACB0 Offset: 0x32DADB1 VA: 0x32DACB0
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x32DC330 Offset: 0x32DC431 VA: 0x32DC330
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DCE70 Offset: 0x32DCF71 VA: 0x32DCE70
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x32DD9C0 Offset: 0x32DDAC1 VA: 0x32DD9C0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x32DE530 Offset: 0x32DE631 VA: 0x32DE530
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DF0A0 Offset: 0x32DF1A1 VA: 0x32DF0A0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x32DFC10 Offset: 0x32DFD11 VA: 0x32DFC10
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x32E0780 Offset: 0x32E0881 VA: 0x32E0780
	|-EqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x32E1300 Offset: 0x32E1401 VA: 0x32E1300
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32E1F10 Offset: 0x32E2011 VA: 0x32E1F10
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x32E2C40 Offset: 0x32E2D41 VA: 0x32E2C40
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-EqualityComparer<TransitionTables>.LastIndexOf
	|
	|-RVA: 0x32E4540 Offset: 0x32E4641 VA: 0x32E4540
	|-EqualityComparer<TutorialUnlockFlagData>.LastIndexOf
	|
	|-RVA: 0x32E50C0 Offset: 0x32E51C1 VA: 0x32E50C0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.LastIndexOf
	|
	|-RVA: 0x32E5CB0 Offset: 0x32E5DB1 VA: 0x32E5CB0
	|-EqualityComparer<CapEdge>.LastIndexOf
	|
	|-RVA: 0x30F1D20 Offset: 0x30F1E21 VA: 0x30F1D20
	|-EqualityComparer<ClippedEdge>.LastIndexOf
	|
	|-RVA: 0x30F2910 Offset: 0x30F2A11 VA: 0x30F2910
	|-EqualityComparer<EdgeKeyByHash>.LastIndexOf
	|
	|-RVA: 0x30F3450 Offset: 0x30F3551 VA: 0x30F3450
	|-EqualityComparer<EdgeKeyByIndex>.LastIndexOf
	|
	|-RVA: 0x30F3F90 Offset: 0x30F4091 VA: 0x30F3F90
	|-EqualityComparer<MeshDataConnectivity.Face>.LastIndexOf
	|
	|-RVA: 0x30F4B30 Offset: 0x30F4C31 VA: 0x30F4B30
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.LastIndexOf
	|
	|-RVA: 0x30F57A0 Offset: 0x30F58A1 VA: 0x30F57A0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.LastIndexOf
	|
	|-RVA: 0x30F63F0 Offset: 0x30F64F1 VA: 0x30F63F0
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|
	|-RVA: 0x30F7050 Offset: 0x30F7151 VA: 0x30F7050
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|
	|-RVA: 0x30F7DE0 Offset: 0x30F7EE1 VA: 0x30F7DE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x30F8940 Offset: 0x30F8A41 VA: 0x30F8940
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x30F9490 Offset: 0x30F9591 VA: 0x30F9490
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x30FA050 Offset: 0x30FA151 VA: 0x30FA050
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x30FACA0 Offset: 0x30FADA1 VA: 0x30FACA0
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x30FB8F0 Offset: 0x30FB9F1 VA: 0x30FB8F0
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x30FC4E0 Offset: 0x30FC5E1 VA: 0x30FC4E0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x30FD050 Offset: 0x30FD151 VA: 0x30FD050
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x30FDCF0 Offset: 0x30FDDF1 VA: 0x30FDCF0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x30FEB30 Offset: 0x30FEC31 VA: 0x30FEB30
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x30FF810 Offset: 0x30FF911 VA: 0x30FF810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	|
	|-RVA: 0x3100360 Offset: 0x3100461 VA: 0x3100360
	|-EqualityComparer<GradientAlphaKey>.LastIndexOf
	|
	|-RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	|-EqualityComparer<GradientColorKey>.LastIndexOf
	|
	|-RVA: 0x3101B90 Offset: 0x3101C91 VA: 0x3101B90
	|-EqualityComparer<Keyframe>.LastIndexOf
	|
	|-RVA: 0x31027D0 Offset: 0x31028D1 VA: 0x31027D0
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x31033B0 Offset: 0x31034B1 VA: 0x31033B0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x31040A0 Offset: 0x31041A1 VA: 0x31040A0
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3104CD0 Offset: 0x3104DD1 VA: 0x3104CD0
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3105890 Offset: 0x3105991 VA: 0x3105890
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3106490 Offset: 0x3106591 VA: 0x3106490
	|-EqualityComparer<PlayableGraph>.LastIndexOf
	|
	|-RVA: 0x3106FF0 Offset: 0x31070F1 VA: 0x3106FF0
	|-EqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x3107B60 Offset: 0x3107C61 VA: 0x3107B60
	|-EqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x3108730 Offset: 0x3108831 VA: 0x3108730
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x31092D0 Offset: 0x31093D1 VA: 0x31092D0
	|-EqualityComparer<RangeInt>.LastIndexOf
	|
	|-RVA: 0x3109EA0 Offset: 0x3109FA1 VA: 0x3109EA0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x310ABA0 Offset: 0x310ACA1 VA: 0x310ABA0
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x310B860 Offset: 0x310B961 VA: 0x310B860
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x310C410 Offset: 0x310C511 VA: 0x310C410
	|-EqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x310CF80 Offset: 0x310D081 VA: 0x310CF80
	|-EqualityComparer<ReflectionProbeBlendInfo>.LastIndexOf
	|
	|-RVA: 0x310DC00 Offset: 0x310DD01 VA: 0x310DC00
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x310E9F0 Offset: 0x310EAF1 VA: 0x310E9F0
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x310F5B0 Offset: 0x310F6B1 VA: 0x310F5B0
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x2EA7910 Offset: 0x2EA7A11 VA: 0x2EA7910
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EA8560 Offset: 0x2EA8661 VA: 0x2EA8560
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EA91D0 Offset: 0x2EA92D1 VA: 0x2EA91D0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x2EA9E20 Offset: 0x2EA9F21 VA: 0x2EA9E20
	|-EqualityComparer<SceneInstance>.LastIndexOf
	|
	|-RVA: 0x2EAA9E0 Offset: 0x2EAAAE1 VA: 0x2EAA9E0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x2EAB650 Offset: 0x2EAB751 VA: 0x2EAB650
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x2EAC2A0 Offset: 0x2EAC3A1 VA: 0x2EAC2A0
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EACE80 Offset: 0x2EACF81 VA: 0x2EACE80
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x2EADB30 Offset: 0x2EADC31 VA: 0x2EADB30
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x2EAE780 Offset: 0x2EAE881 VA: 0x2EAE780
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2EAF3D0 Offset: 0x2EAF4D1 VA: 0x2EAF3D0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EB0E50 Offset: 0x2EB0F51 VA: 0x2EB0E50
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EB1B00 Offset: 0x2EB1C01 VA: 0x2EB1B00
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EB2720 Offset: 0x2EB2821 VA: 0x2EB2720
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x2EB32D0 Offset: 0x2EB33D1 VA: 0x2EB32D0
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|
	|-RVA: 0x2EB49A0 Offset: 0x2EB4AA1 VA: 0x2EB49A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|
	|-RVA: 0x2EB54F0 Offset: 0x2EB55F1 VA: 0x2EB54F0
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x2EB6130 Offset: 0x2EB6231 VA: 0x2EB6130
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x2EB6EC0 Offset: 0x2EB6FC1 VA: 0x2EB6EC0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x2EB7AC0 Offset: 0x2EB7BC1 VA: 0x2EB7AC0
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EB8620 Offset: 0x2EB8721 VA: 0x2EB8620
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EB9190 Offset: 0x2EB9291 VA: 0x2EB9190
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EB9D50 Offset: 0x2EB9E51 VA: 0x2EB9D50
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EBA8F0 Offset: 0x2EBA9F1 VA: 0x2EBA8F0
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2EBB5B0 Offset: 0x2EBB6B1 VA: 0x2EBB5B0
	|-EqualityComparer<WarpPoints.WarpPoint>.LastIndexOf
	|
	|-RVA: 0x2EBC380 Offset: 0x2EBC481 VA: 0x2EBC380
	|-EqualityComparer<YieldItemParam>.LastIndexOf
	|
	|-RVA: 0x2EBCF20 Offset: 0x2EBD021 VA: 0x2EBCF20
	|-EqualityComparer<stCommand_t>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EB40 Offset: 0x2E3EC41 VA: 0x2E3EB40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E3F700 Offset: 0x2E3F801 VA: 0x2E3F700
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40250 Offset: 0x2E40351 VA: 0x2E40250
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40FC0 Offset: 0x2E410C1 VA: 0x2E40FC0
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E41CA0 Offset: 0x2E41DA1 VA: 0x2E41CA0
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E42810 Offset: 0x2E42911 VA: 0x2E42810
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E43F10 Offset: 0x2E44011 VA: 0x2E43F10
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E44A60 Offset: 0x2E44B61 VA: 0x2E44A60
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E455A0 Offset: 0x2E456A1 VA: 0x2E455A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E461D0 Offset: 0x2E462D1 VA: 0x2E461D0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E46EB0 Offset: 0x2E46FB1 VA: 0x2E46EB0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E47B50 Offset: 0x2E47C51 VA: 0x2E47B50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E486F0 Offset: 0x2E487F1 VA: 0x2E486F0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E492E0 Offset: 0x2E493E1 VA: 0x2E492E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E49F30 Offset: 0x2E4A031 VA: 0x2E49F30
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4AB80 Offset: 0x2E4AC81 VA: 0x2E4AB80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4B740 Offset: 0x2E4B841 VA: 0x2E4B740
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4C3E0 Offset: 0x2E4C4E1 VA: 0x2E4C3E0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4D0A0 Offset: 0x2E4D1A1 VA: 0x2E4D0A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4DC80 Offset: 0x2E4DD81 VA: 0x2E4DC80
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4E7F0 Offset: 0x2E4E8F1 VA: 0x2E4E7F0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4FEB0 Offset: 0x2E4FFB1 VA: 0x2E4FEB0
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E50B20 Offset: 0x2E50C21 VA: 0x2E50B20
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E51740 Offset: 0x2E51841 VA: 0x2E51740
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E523A0 Offset: 0x2E524A1 VA: 0x2E523A0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53040 Offset: 0x2E53141 VA: 0x2E53040
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53CF0 Offset: 0x2E53DF1 VA: 0x2E53CF0
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E549B0 Offset: 0x2E54AB1 VA: 0x2E549B0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E555B0 Offset: 0x2E556B1 VA: 0x2E555B0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56230 Offset: 0x2E56331 VA: 0x2E56230
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56EE0 Offset: 0x2E56FE1 VA: 0x2E56EE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E57AC0 Offset: 0x2E57BC1 VA: 0x2E57AC0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FEC30 Offset: 0x31FED31 VA: 0x31FEC30
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FF8C0 Offset: 0x31FF9C1 VA: 0x31FF8C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3200480 Offset: 0x3200581 VA: 0x3200480
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201090 Offset: 0x3201191 VA: 0x3201090
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201C70 Offset: 0x3201D71 VA: 0x3201C70
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32027E0 Offset: 0x32028E1 VA: 0x32027E0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3203420 Offset: 0x3203521 VA: 0x3203420
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204030 Offset: 0x3204131 VA: 0x3204030
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204B80 Offset: 0x3204C81 VA: 0x3204B80
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3205700 Offset: 0x3205801 VA: 0x3205700
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32062B0 Offset: 0x32063B1 VA: 0x32062B0
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3207A40 Offset: 0x3207B41 VA: 0x3207A40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3208690 Offset: 0x3208791 VA: 0x3208690
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209DE0 Offset: 0x3209EE1 VA: 0x3209DE0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320AAA0 Offset: 0x320ABA1 VA: 0x320AAA0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320B6D0 Offset: 0x320B7D1 VA: 0x320B6D0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320C220 Offset: 0x320C321 VA: 0x320C220
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320CD60 Offset: 0x320CE61 VA: 0x320CD60
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320E410 Offset: 0x320E511 VA: 0x320E410
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320EF70 Offset: 0x320F071 VA: 0x320EF70
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320FAC0 Offset: 0x320FBC1 VA: 0x320FAC0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3210620 Offset: 0x3210721 VA: 0x3210620
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211170 Offset: 0x3211271 VA: 0x3211170
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211CD0 Offset: 0x3211DD1 VA: 0x3211CD0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3212820 Offset: 0x3212921 VA: 0x3212820
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213390 Offset: 0x3213491 VA: 0x3213390
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213EE0 Offset: 0x3213FE1 VA: 0x3213EE0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3214A20 Offset: 0x3214B21 VA: 0x3214A20
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3215560 Offset: 0x3215661 VA: 0x3215560
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32160A0 Offset: 0x32161A1 VA: 0x32160A0
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3216C00 Offset: 0x3216D01 VA: 0x3216C00
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3217770 Offset: 0x3217871 VA: 0x3217770
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32183B0 Offset: 0x32184B1 VA: 0x32183B0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3218FB0 Offset: 0x32190B1 VA: 0x3218FB0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3219BF0 Offset: 0x3219CF1 VA: 0x3219BF0
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321A8E0 Offset: 0x321A9E1 VA: 0x321A8E0
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321B4E0 Offset: 0x321B5E1 VA: 0x321B4E0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32C9DA0 Offset: 0x32C9EA1 VA: 0x32C9DA0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CA9B0 Offset: 0x32CAAB1 VA: 0x32CA9B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CB5C0 Offset: 0x32CB6C1 VA: 0x32CB5C0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CCE10 Offset: 0x32CCF11 VA: 0x32CCE10
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CDAF0 Offset: 0x32CDBF1 VA: 0x32CDAF0
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CE810 Offset: 0x32CE911 VA: 0x32CE810
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CF420 Offset: 0x32CF521 VA: 0x32CF420
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0030 Offset: 0x32D0131 VA: 0x32D0030
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0CB0 Offset: 0x32D0DB1 VA: 0x32D0CB0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D18C0 Offset: 0x32D19C1 VA: 0x32D18C0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2460 Offset: 0x32D2561 VA: 0x32D2460
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2FE0 Offset: 0x32D30E1 VA: 0x32D2FE0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D3B50 Offset: 0x32D3C51 VA: 0x32D3B50
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D4750 Offset: 0x32D4851 VA: 0x32D4750
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5320 Offset: 0x32D5421 VA: 0x32D5320
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5E60 Offset: 0x32D5F61 VA: 0x32D5E60
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D69B0 Offset: 0x32D6AB1 VA: 0x32D69B0
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D7510 Offset: 0x32D7611 VA: 0x32D7510
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8060 Offset: 0x32D8161 VA: 0x32D8060
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8BA0 Offset: 0x32D8CA1 VA: 0x32D8BA0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D96E0 Offset: 0x32D97E1 VA: 0x32D96E0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DA230 Offset: 0x32DA331 VA: 0x32DA230
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DAD70 Offset: 0x32DAE71 VA: 0x32DAD70
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DB8B0 Offset: 0x32DB9B1 VA: 0x32DB8B0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DC3F0 Offset: 0x32DC4F1 VA: 0x32DC3F0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DCF30 Offset: 0x32DD031 VA: 0x32DCF30
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DDA90 Offset: 0x32DDB91 VA: 0x32DDA90
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DF170 Offset: 0x32DF271 VA: 0x32DF170
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DFCE0 Offset: 0x32DFDE1 VA: 0x32DFCE0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E0850 Offset: 0x32E0951 VA: 0x32E0850
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E13E0 Offset: 0x32E14E1 VA: 0x32E13E0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2060 Offset: 0x32E2161 VA: 0x32E2060
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2D90 Offset: 0x32E2E91 VA: 0x32E2D90
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E3A40 Offset: 0x32E3B41 VA: 0x32E3A40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E4620 Offset: 0x32E4721 VA: 0x32E4620
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5190 Offset: 0x32E5291 VA: 0x32E5190
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5DF0 Offset: 0x32E5EF1 VA: 0x32E5DF0
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F1E30 Offset: 0x30F1F31 VA: 0x30F1E30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F29D0 Offset: 0x30F2AD1 VA: 0x30F29D0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F3510 Offset: 0x30F3611 VA: 0x30F3510
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4050 Offset: 0x30F4151 VA: 0x30F4050
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4C40 Offset: 0x30F4D41 VA: 0x30F4C40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F58D0 Offset: 0x30F59D1 VA: 0x30F58D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F64C0 Offset: 0x30F65C1 VA: 0x30F64C0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7200 Offset: 0x30F7301 VA: 0x30F7200
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7EB0 Offset: 0x30F7FB1 VA: 0x30F7EB0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F8A00 Offset: 0x30F8B01 VA: 0x30F8A00
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F9560 Offset: 0x30F9661 VA: 0x30F9560
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FADB0 Offset: 0x30FAEB1 VA: 0x30FADB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FBA00 Offset: 0x30FBB01 VA: 0x30FBA00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FC5A0 Offset: 0x30FC6A1 VA: 0x30FC5A0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FD140 Offset: 0x30FD241 VA: 0x30FD140
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FDEA0 Offset: 0x30FDFA1 VA: 0x30FDEA0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FECA0 Offset: 0x30FEDA1 VA: 0x30FECA0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FF8D0 Offset: 0x30FF9D1 VA: 0x30FF8D0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101030 Offset: 0x3101131 VA: 0x3101030
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101CC0 Offset: 0x3101DC1 VA: 0x3101CC0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3102890 Offset: 0x3102991 VA: 0x3102890
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3103500 Offset: 0x3103601 VA: 0x3103500
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31041C0 Offset: 0x31042C1 VA: 0x31041C0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3104DA0 Offset: 0x3104EA1 VA: 0x3104DA0
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31059A0 Offset: 0x3105AA1 VA: 0x31059A0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3106560 Offset: 0x3106661 VA: 0x3106560
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31070B0 Offset: 0x31071B1 VA: 0x31070B0
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3107C50 Offset: 0x3107D51 VA: 0x3107C50
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3108820 Offset: 0x3108921 VA: 0x3108820
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109390 Offset: 0x3109491 VA: 0x3109390
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109FE0 Offset: 0x310A0E1 VA: 0x3109FE0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310ACF0 Offset: 0x310ADF1 VA: 0x310ACF0
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310B950 Offset: 0x310BA51 VA: 0x310B950
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310C4E0 Offset: 0x310C5E1 VA: 0x310C4E0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310D050 Offset: 0x310D151 VA: 0x310D050
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310DDD0 Offset: 0x310DED1 VA: 0x310DDD0
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310EAC0 Offset: 0x310EBC1 VA: 0x310EAC0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310F6C0 Offset: 0x310F7C1 VA: 0x310F6C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA7A20 Offset: 0x2EA7B21 VA: 0x2EA7A20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA8670 Offset: 0x2EA8771 VA: 0x2EA8670
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9300 Offset: 0x2EA9401 VA: 0x2EA9300
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9EF0 Offset: 0x2EA9FF1 VA: 0x2EA9EF0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAAAF0 Offset: 0x2EAABF1 VA: 0x2EAAAF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAB780 Offset: 0x2EAB881 VA: 0x2EAB780
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAC370 Offset: 0x2EAC471 VA: 0x2EAC370
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EACFB0 Offset: 0x2EAD0B1 VA: 0x2EACFB0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EADC40 Offset: 0x2EADD41 VA: 0x2EADC40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAE890 Offset: 0x2EAE991 VA: 0x2EAE890
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0230 Offset: 0x2EB0331 VA: 0x2EB0230
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0F80 Offset: 0x2EB1081 VA: 0x2EB0F80
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB1C10 Offset: 0x2EB1D11 VA: 0x2EB1C10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB2810 Offset: 0x2EB2911 VA: 0x2EB2810
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB33A0 Offset: 0x2EB34A1 VA: 0x2EB33A0
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB3F10 Offset: 0x2EB4011 VA: 0x2EB3F10
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB4A60 Offset: 0x2EB4B61 VA: 0x2EB4A60
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB55C0 Offset: 0x2EB56C1 VA: 0x2EB55C0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB62C0 Offset: 0x2EB63C1 VA: 0x2EB62C0
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB6FD0 Offset: 0x2EB70D1 VA: 0x2EB6FD0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB7B90 Offset: 0x2EB7C91 VA: 0x2EB7B90
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9280 Offset: 0x2EB9381 VA: 0x2EB9280
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9E30 Offset: 0x2EB9F31 VA: 0x2EB9E30
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBA9E0 Offset: 0x2EBAAE1 VA: 0x2EBA9E0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBB780 Offset: 0x2EBB881 VA: 0x2EBB780
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBC440 Offset: 0x2EBC541 VA: 0x2EBC440
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBD030 Offset: 0x2EBD131 VA: 0x2EBD030
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EC40 Offset: 0x2E3ED41 VA: 0x2E3EC40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E3F7E0 Offset: 0x2E3F8E1 VA: 0x2E3F7E0
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E40330 Offset: 0x2E40431 VA: 0x2E40330
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41120 Offset: 0x2E41221 VA: 0x2E41120
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E428F0 Offset: 0x2E429F1 VA: 0x2E428F0
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43480 Offset: 0x2E43581 VA: 0x2E43480
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43FF0 Offset: 0x2E440F1 VA: 0x2E43FF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E462E0 Offset: 0x2E463E1 VA: 0x2E462E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E46FC0 Offset: 0x2E470C1 VA: 0x2E46FC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E47C50 Offset: 0x2E47D51 VA: 0x2E47C50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E487D0 Offset: 0x2E488D1 VA: 0x2E487D0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E493E0 Offset: 0x2E494E1 VA: 0x2E493E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4A030 Offset: 0x2E4A131 VA: 0x2E4A030
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4AC80 Offset: 0x2E4AD81 VA: 0x2E4AC80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4B820 Offset: 0x2E4B921 VA: 0x2E4B820
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4C500 Offset: 0x2E4C601 VA: 0x2E4C500
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4D1A0 Offset: 0x2E4D2A1 VA: 0x2E4D1A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4DD60 Offset: 0x2E4DE61 VA: 0x2E4DD60
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4E8D0 Offset: 0x2E4E9D1 VA: 0x2E4E8D0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4F440 Offset: 0x2E4F541 VA: 0x2E4F440
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4FF90 Offset: 0x2E50091 VA: 0x2E4FF90
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E50C40 Offset: 0x2E50D41 VA: 0x2E50C40
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E524B0 Offset: 0x2E525B1 VA: 0x2E524B0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53150 Offset: 0x2E53251 VA: 0x2E53150
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53E00 Offset: 0x2E53F01 VA: 0x2E53E00
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E54AC0 Offset: 0x2E54BC1 VA: 0x2E54AC0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E55690 Offset: 0x2E55791 VA: 0x2E55690
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56350 Offset: 0x2E56451 VA: 0x2E56350
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56FE0 Offset: 0x2E570E1 VA: 0x2E56FE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E57BA0 Offset: 0x2E57CA1 VA: 0x2E57BA0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3200560 Offset: 0x3200661 VA: 0x3200560
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32011A0 Offset: 0x32012A1 VA: 0x32011A0
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3201D50 Offset: 0x3201E51 VA: 0x3201D50
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32028C0 Offset: 0x32029C1 VA: 0x32028C0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3203530 Offset: 0x3203631 VA: 0x3203530
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204110 Offset: 0x3204211 VA: 0x3204110
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204C60 Offset: 0x3204D61 VA: 0x3204C60
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32057E0 Offset: 0x32058E1 VA: 0x32057E0
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206390 Offset: 0x3206491 VA: 0x3206390
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206F20 Offset: 0x3207021 VA: 0x3206F20
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3207B40 Offset: 0x3207C41 VA: 0x3207B40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3208790 Offset: 0x3208891 VA: 0x3208790
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209330 Offset: 0x3209431 VA: 0x3209330
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320ABD0 Offset: 0x320ACD1 VA: 0x320ABD0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320B7B0 Offset: 0x320B8B1 VA: 0x320B7B0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320CE40 Offset: 0x320CF41 VA: 0x320CE40
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320D9A0 Offset: 0x320DAA1 VA: 0x320D9A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320E4F0 Offset: 0x320E5F1 VA: 0x320E4F0
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320F050 Offset: 0x320F151 VA: 0x320F050
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320FBA0 Offset: 0x320FCA1 VA: 0x320FBA0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3210700 Offset: 0x3210801 VA: 0x3210700
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211250 Offset: 0x3211351 VA: 0x3211250
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211DB0 Offset: 0x3211EB1 VA: 0x3211DB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3212900 Offset: 0x3212A01 VA: 0x3212900
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213470 Offset: 0x3213571 VA: 0x3213470
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213FC0 Offset: 0x32140C1 VA: 0x3213FC0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3214B00 Offset: 0x3214C01 VA: 0x3214B00
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3215640 Offset: 0x3215741 VA: 0x3215640
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216180 Offset: 0x3216281 VA: 0x3216180
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216CE0 Offset: 0x3216DE1 VA: 0x3216CE0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3217850 Offset: 0x3217951 VA: 0x3217850
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32184E0 Offset: 0x32185E1 VA: 0x32184E0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32190A0 Offset: 0x32191A1 VA: 0x32190A0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3219D20 Offset: 0x3219E21 VA: 0x3219D20
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321AA10 Offset: 0x321AB11 VA: 0x321AA10
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321B5D0 Offset: 0x321B6D1 VA: 0x321B5D0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32C9EC0 Offset: 0x32C9FC1 VA: 0x32C9EC0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CB6E0 Offset: 0x32CB7E1 VA: 0x32CB6E0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CC360 Offset: 0x32CC461 VA: 0x32CC360
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CDC40 Offset: 0x32CDD41 VA: 0x32CDC40
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CE930 Offset: 0x32CEA31 VA: 0x32CE930
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CF510 Offset: 0x32CF611 VA: 0x32CF510
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0150 Offset: 0x32D0251 VA: 0x32D0150
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0DD0 Offset: 0x32D0ED1 VA: 0x32D0DD0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D19B0 Offset: 0x32D1AB1 VA: 0x32D19B0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D2550 Offset: 0x32D2651 VA: 0x32D2550
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D30D0 Offset: 0x32D31D1 VA: 0x32D30D0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D3C40 Offset: 0x32D3D41 VA: 0x32D3C40
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D4870 Offset: 0x32D4971 VA: 0x32D4870
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D53F0 Offset: 0x32D54F1 VA: 0x32D53F0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D5F40 Offset: 0x32D6041 VA: 0x32D5F40
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D6A90 Offset: 0x32D6B91 VA: 0x32D6A90
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D75F0 Offset: 0x32D76F1 VA: 0x32D75F0
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8C80 Offset: 0x32D8D81 VA: 0x32D8C80
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DA310 Offset: 0x32DA411 VA: 0x32DA310
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DAE50 Offset: 0x32DAF51 VA: 0x32DAE50
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DB990 Offset: 0x32DBA91 VA: 0x32DB990
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DC4D0 Offset: 0x32DC5D1 VA: 0x32DC4D0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DD010 Offset: 0x32DD111 VA: 0x32DD010
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DDB70 Offset: 0x32DDC71 VA: 0x32DDB70
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DF250 Offset: 0x32DF351 VA: 0x32DF250
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DFDC0 Offset: 0x32DFEC1 VA: 0x32DFDC0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E0930 Offset: 0x32E0A31 VA: 0x32E0930
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E14C0 Offset: 0x32E15C1 VA: 0x32E14C0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2180 Offset: 0x32E2281 VA: 0x32E2180
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2EB0 Offset: 0x32E2FB1 VA: 0x32E2EB0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E3B40 Offset: 0x32E3C41 VA: 0x32E3B40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E4700 Offset: 0x32E4801 VA: 0x32E4700
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5270 Offset: 0x32E5371 VA: 0x32E5270
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5F00 Offset: 0x32E6001 VA: 0x32E5F00
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F1F30 Offset: 0x30F2031 VA: 0x30F1F30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F2AB0 Offset: 0x30F2BB1 VA: 0x30F2AB0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F35F0 Offset: 0x30F36F1 VA: 0x30F35F0
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4130 Offset: 0x30F4231 VA: 0x30F4130
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4D40 Offset: 0x30F4E41 VA: 0x30F4D40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F59E0 Offset: 0x30F5AE1 VA: 0x30F59E0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7350 Offset: 0x30F7451 VA: 0x30F7350
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7F90 Offset: 0x30F8091 VA: 0x30F7F90
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F8AE0 Offset: 0x30F8BE1 VA: 0x30F8AE0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F9640 Offset: 0x30F9741 VA: 0x30F9640
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FA260 Offset: 0x30FA361 VA: 0x30FA260
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FAEB0 Offset: 0x30FAFB1 VA: 0x30FAEB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FBB00 Offset: 0x30FBC01 VA: 0x30FBB00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FC680 Offset: 0x30FC781 VA: 0x30FC680
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FD220 Offset: 0x30FD321 VA: 0x30FD220
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FDFF0 Offset: 0x30FE0F1 VA: 0x30FDFF0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FEDD0 Offset: 0x30FEED1 VA: 0x30FEDD0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FF9B0 Offset: 0x30FFAB1 VA: 0x30FF9B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3100510 Offset: 0x3100611 VA: 0x3100510
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101130 Offset: 0x3101231 VA: 0x3101130
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101DD0 Offset: 0x3101ED1 VA: 0x3101DD0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3102970 Offset: 0x3102A71 VA: 0x3102970
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3103620 Offset: 0x3103721 VA: 0x3103620
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31042D0 Offset: 0x31043D1 VA: 0x31042D0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3104E80 Offset: 0x3104F81 VA: 0x3104E80
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3105AA0 Offset: 0x3105BA1 VA: 0x3105AA0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3106640 Offset: 0x3106741 VA: 0x3106640
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107190 Offset: 0x3107291 VA: 0x3107190
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107D30 Offset: 0x3107E31 VA: 0x3107D30
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3108900 Offset: 0x3108A01 VA: 0x3108900
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3109470 Offset: 0x3109571 VA: 0x3109470
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310A0F0 Offset: 0x310A1F1 VA: 0x310A0F0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310AE10 Offset: 0x310AF11 VA: 0x310AE10
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310BA30 Offset: 0x310BB31 VA: 0x310BA30
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310C5C0 Offset: 0x310C6C1 VA: 0x310C5C0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310D130 Offset: 0x310D231 VA: 0x310D130
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310DF40 Offset: 0x310E041 VA: 0x310DF40
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310EBA0 Offset: 0x310ECA1 VA: 0x310EBA0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310F7C0 Offset: 0x310F8C1 VA: 0x310F7C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA7B20 Offset: 0x2EA7C21 VA: 0x2EA7B20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA8770 Offset: 0x2EA8871 VA: 0x2EA8770
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9410 Offset: 0x2EA9511 VA: 0x2EA9410
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9FD0 Offset: 0x2EAA0D1 VA: 0x2EA9FD0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAABF0 Offset: 0x2EAACF1 VA: 0x2EAABF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAB890 Offset: 0x2EAB991 VA: 0x2EAB890
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAC450 Offset: 0x2EAC551 VA: 0x2EAC450
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAD0C0 Offset: 0x2EAD1C1 VA: 0x2EAD0C0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAE990 Offset: 0x2EAEA91 VA: 0x2EAE990
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAF5E0 Offset: 0x2EAF6E1 VA: 0x2EAF5E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB0370 Offset: 0x2EB0471 VA: 0x2EB0370
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1090 Offset: 0x2EB1191 VA: 0x2EB1090
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1D10 Offset: 0x2EB1E11 VA: 0x2EB1D10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3480 Offset: 0x2EB3581 VA: 0x2EB3480
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3FF0 Offset: 0x2EB40F1 VA: 0x2EB3FF0
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB4B40 Offset: 0x2EB4C41 VA: 0x2EB4B40
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB56A0 Offset: 0x2EB57A1 VA: 0x2EB56A0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB6400 Offset: 0x2EB6501 VA: 0x2EB6400
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB70D0 Offset: 0x2EB71D1 VA: 0x2EB70D0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB7C70 Offset: 0x2EB7D71 VA: 0x2EB7C70
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB87C0 Offset: 0x2EB88C1 VA: 0x2EB87C0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9360 Offset: 0x2EB9461 VA: 0x2EB9360
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9F10 Offset: 0x2EBA011 VA: 0x2EB9F10
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBAAC0 Offset: 0x2EBABC1 VA: 0x2EBAAC0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBB8E0 Offset: 0x2EBB9E1 VA: 0x2EBB8E0
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBC520 Offset: 0x2EBC621 VA: 0x2EBC520
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EDF0 Offset: 0x2E3EEF1 VA: 0x2E3EDF0
	|-EqualityComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2E3F960 Offset: 0x2E3FA61 VA: 0x2E3F960
	|-EqualityComparer<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x2E404A0 Offset: 0x2E405A1 VA: 0x2E404A0
	|-EqualityComparer<BitVector32Int>..ctor
	|
	|-RVA: 0x2E41390 Offset: 0x2E41491 VA: 0x2E41390
	|-EqualityComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-EqualityComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2E42A70 Offset: 0x2E42B71 VA: 0x2E42A70
	|-EqualityComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2E43600 Offset: 0x2E43701 VA: 0x2E43600
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2E44170 Offset: 0x2E44271 VA: 0x2E44170
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E44CB0 Offset: 0x2E44DB1 VA: 0x2E44CB0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E457F0 Offset: 0x2E458F1 VA: 0x2E457F0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2E471A0 Offset: 0x2E472A1 VA: 0x2E471A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2E47E00 Offset: 0x2E47F01 VA: 0x2E47E00
	|-EqualityComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2E48940 Offset: 0x2E48A41 VA: 0x2E48940
	|-EqualityComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2E49590 Offset: 0x2E49691 VA: 0x2E49590
	|-EqualityComparer<EffectDataTable>..ctor
	|
	|-RVA: 0x2E4A1E0 Offset: 0x2E4A2E1 VA: 0x2E4A1E0
	|-EqualityComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2E4AE30 Offset: 0x2E4AF31 VA: 0x2E4AE30
	|-EqualityComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2E4B9A0 Offset: 0x2E4BAA1 VA: 0x2E4B9A0
	|-EqualityComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2E4C700 Offset: 0x2E4C801 VA: 0x2E4C700
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E4D350 Offset: 0x2E4D451 VA: 0x2E4D350
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E4DEE0 Offset: 0x2E4DFE1 VA: 0x2E4DEE0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E4EA50 Offset: 0x2E4EB51 VA: 0x2E4EA50
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E4F5C0 Offset: 0x2E4F6C1 VA: 0x2E4F5C0
	|-EqualityComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2E50100 Offset: 0x2E50201 VA: 0x2E50100
	|-EqualityComparer<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E50E30 Offset: 0x2E50F31 VA: 0x2E50E30
	|-EqualityComparer<MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E519A0 Offset: 0x2E51AA1 VA: 0x2E519A0
	|-EqualityComparer<MiningDataTable>..ctor
	|
	|-RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	|-EqualityComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2E53310 Offset: 0x2E53411 VA: 0x2E53310
	|-EqualityComparer<MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53FD0 Offset: 0x2E540D1 VA: 0x2E53FD0
	|-EqualityComparer<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54CA0 Offset: 0x2E54DA1 VA: 0x2E54CA0
	|-EqualityComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E55810 Offset: 0x2E55911 VA: 0x2E55810
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	|-EqualityComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2E57190 Offset: 0x2E57291 VA: 0x2E57190
	|-EqualityComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2E57D20 Offset: 0x2E57E21 VA: 0x2E57D20
	|-EqualityComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31FEF20 Offset: 0x31FF021 VA: 0x31FEF20
	|-EqualityComparer<OrderSaveData>..ctor
	|
	|-RVA: 0x31FFB70 Offset: 0x31FFC71 VA: 0x31FFB70
	|-EqualityComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32006E0 Offset: 0x32007E1 VA: 0x32006E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3201360 Offset: 0x3201461 VA: 0x3201360
	|-EqualityComparer<Parameter>..ctor
	|
	|-RVA: 0x3201ED0 Offset: 0x3201FD1 VA: 0x3201ED0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x3202A40 Offset: 0x3202B41 VA: 0x3202A40
	|-EqualityComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x3203700 Offset: 0x3203801 VA: 0x3203700
	|-EqualityComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3204290 Offset: 0x3204391 VA: 0x3204290
	|-EqualityComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3204DD0 Offset: 0x3204ED1 VA: 0x3204DD0
	|-EqualityComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3205960 Offset: 0x3205A61 VA: 0x3205960
	|-EqualityComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3206530 Offset: 0x3206631 VA: 0x3206530
	|-EqualityComparer<ProfilerFrame>..ctor
	|
	|-RVA: 0x32070A0 Offset: 0x32071A1 VA: 0x32070A0
	|-EqualityComparer<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x3207CF0 Offset: 0x3207DF1 VA: 0x3207CF0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x3208940 Offset: 0x3208A41 VA: 0x3208940
	|-EqualityComparer<Schedule>..ctor
	|
	|-RVA: 0x32094B0 Offset: 0x32095B1 VA: 0x32094B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x320A040 Offset: 0x320A141 VA: 0x320A040
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-EqualityComparer<CurveSample>..ctor
	|
	|-RVA: 0x320B930 Offset: 0x320BA31 VA: 0x320B930
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x320C470 Offset: 0x320C571 VA: 0x320C470
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x320CFB0 Offset: 0x320D0B1 VA: 0x320CFB0
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x320DB20 Offset: 0x320DC21 VA: 0x320DB20
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x320E660 Offset: 0x320E761 VA: 0x320E660
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x320F1D0 Offset: 0x320F2D1 VA: 0x320F1D0
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x320FD10 Offset: 0x320FE11 VA: 0x320FD10
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3210880 Offset: 0x3210981 VA: 0x3210880
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32113C0 Offset: 0x32114C1 VA: 0x32113C0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3211F30 Offset: 0x3212031 VA: 0x3211F30
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3212A80 Offset: 0x3212B81 VA: 0x3212A80
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x32135F0 Offset: 0x32136F1 VA: 0x32135F0
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3214130 Offset: 0x3214231 VA: 0x3214130
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3214C70 Offset: 0x3214D71 VA: 0x3214C70
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x32157B0 Offset: 0x32158B1 VA: 0x32157B0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x32162F0 Offset: 0x32163F1 VA: 0x32162F0
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3216E60 Offset: 0x3216F61 VA: 0x3216E60
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x32179D0 Offset: 0x3217AD1 VA: 0x32179D0
	|-EqualityComparer<Memory<object>>..ctor
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3219210 Offset: 0x3219311 VA: 0x3219210
	|-EqualityComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3219F00 Offset: 0x321A001 VA: 0x3219F00
	|-EqualityComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x321ABF0 Offset: 0x321ACF1 VA: 0x321ABF0
	|-EqualityComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x321B740 Offset: 0x321B841 VA: 0x321B740
	|-EqualityComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x32CA080 Offset: 0x32CA181 VA: 0x32CA080
	|-EqualityComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x32CAC20 Offset: 0x32CAD21 VA: 0x32CAC20
	|-EqualityComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x32CB8A0 Offset: 0x32CB9A1 VA: 0x32CB8A0
	|-EqualityComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x32CC520 Offset: 0x32CC621 VA: 0x32CC520
	|-EqualityComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x32CD070 Offset: 0x32CD171 VA: 0x32CD070
	|-EqualityComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x32CDE70 Offset: 0x32CDF71 VA: 0x32CDE70
	|-EqualityComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x32CEAF0 Offset: 0x32CEBF1 VA: 0x32CEAF0
	|-EqualityComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x32CF690 Offset: 0x32CF791 VA: 0x32CF690
	|-EqualityComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x32D0310 Offset: 0x32D0411 VA: 0x32D0310
	|-EqualityComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32D0F90 Offset: 0x32D1091 VA: 0x32D0F90
	|-EqualityComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x32D1B30 Offset: 0x32D1C31 VA: 0x32D1B30
	|-EqualityComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x32D26D0 Offset: 0x32D27D1 VA: 0x32D26D0
	|-EqualityComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x32D3240 Offset: 0x32D3341 VA: 0x32D3240
	|-EqualityComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32D3DB0 Offset: 0x32D3EB1 VA: 0x32D3DB0
	|-EqualityComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x32D4A30 Offset: 0x32D4B31 VA: 0x32D4A30
	|-EqualityComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32D5550 Offset: 0x32D5651 VA: 0x32D5550
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x32D60C0 Offset: 0x32D61C1 VA: 0x32D60C0
	|-EqualityComparer<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x32D6C00 Offset: 0x32D6D01 VA: 0x32D6C00
	|-EqualityComparer<Label>..ctor
	|
	|-RVA: 0x32D7770 Offset: 0x32D7871 VA: 0x32D7770
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x32D82B0 Offset: 0x32D83B1 VA: 0x32D82B0
	|-EqualityComparer<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x32D8DF0 Offset: 0x32D8EF1 VA: 0x32D8DF0
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x32D9940 Offset: 0x32D9A41 VA: 0x32D9940
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x32DA480 Offset: 0x32DA581 VA: 0x32DA480
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x32DAFC0 Offset: 0x32DB0C1 VA: 0x32DAFC0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x32DBB00 Offset: 0x32DBC01 VA: 0x32DBB00
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x32DC640 Offset: 0x32DC741 VA: 0x32DC640
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32DD180 Offset: 0x32DD281 VA: 0x32DD180
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32DDCF0 Offset: 0x32DDDF1 VA: 0x32DDCF0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32DE860 Offset: 0x32DE961 VA: 0x32DE860
	|-EqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32DF3D0 Offset: 0x32DF4D1 VA: 0x32DF3D0
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32E0AB0 Offset: 0x32E0BB1 VA: 0x32E0AB0
	|-EqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x32E1640 Offset: 0x32E1741 VA: 0x32E1640
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32E2370 Offset: 0x32E2471 VA: 0x32E2370
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32E30A0 Offset: 0x32E31A1 VA: 0x32E30A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32E3CF0 Offset: 0x32E3DF1 VA: 0x32E3CF0
	|-EqualityComparer<TransitionTables>..ctor
	|
	|-RVA: 0x32E4880 Offset: 0x32E4981 VA: 0x32E4880
	|-EqualityComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32E60E0 Offset: 0x32E61E1 VA: 0x32E60E0
	|-EqualityComparer<CapEdge>..ctor
	|
	|-RVA: 0x30F20E0 Offset: 0x30F21E1 VA: 0x30F20E0
	|-EqualityComparer<ClippedEdge>..ctor
	|
	|-RVA: 0x30F2C20 Offset: 0x30F2D21 VA: 0x30F2C20
	|-EqualityComparer<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x30F3760 Offset: 0x30F3861 VA: 0x30F3760
	|-EqualityComparer<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x30F42A0 Offset: 0x30F43A1 VA: 0x30F42A0
	|-EqualityComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x30F4EF0 Offset: 0x30F4FF1 VA: 0x30F4EF0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x30F6720 Offset: 0x30F6821 VA: 0x30F6720
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x30F75A0 Offset: 0x30F76A1 VA: 0x30F75A0
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x30F8110 Offset: 0x30F8211 VA: 0x30F8110
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x30F8C50 Offset: 0x30F8D51 VA: 0x30F8C50
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x30F97C0 Offset: 0x30F98C1 VA: 0x30F97C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x30FA410 Offset: 0x30FA511 VA: 0x30FA410
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x30FB060 Offset: 0x30FB161 VA: 0x30FB060
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x30FBCB0 Offset: 0x30FBDB1 VA: 0x30FBCB0
	|-EqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x30FC7F0 Offset: 0x30FC8F1 VA: 0x30FC7F0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x30FD3C0 Offset: 0x30FD4C1 VA: 0x30FD3C0
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x30FE240 Offset: 0x30FE341 VA: 0x30FE240
	|-EqualityComparer<CombineInstance>..ctor
	|
	|-RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x30FFB20 Offset: 0x30FFC21 VA: 0x30FFB20
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x3100690 Offset: 0x3100791 VA: 0x3100690
	|-EqualityComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31012E0 Offset: 0x31013E1 VA: 0x31012E0
	|-EqualityComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x3101FA0 Offset: 0x31020A1 VA: 0x3101FA0
	|-EqualityComparer<Keyframe>..ctor
	|
	|-RVA: 0x3102AE0 Offset: 0x3102BE1 VA: 0x3102AE0
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3103810 Offset: 0x3103911 VA: 0x3103810
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3104490 Offset: 0x3104591 VA: 0x3104490
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3105000 Offset: 0x3105101 VA: 0x3105000
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3105C50 Offset: 0x3105D51 VA: 0x3105C50
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x31067C0 Offset: 0x31068C1 VA: 0x31067C0
	|-EqualityComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x3107300 Offset: 0x3107401 VA: 0x3107300
	|-EqualityComparer<Edge>..ctor
	|
	|-RVA: 0x3107ED0 Offset: 0x3107FD1 VA: 0x3107ED0
	|-EqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x3108AA0 Offset: 0x3108BA1 VA: 0x3108AA0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x31095E0 Offset: 0x31096E1 VA: 0x31095E0
	|-EqualityComparer<RangeInt>..ctor
	|
	|-RVA: 0x310A2D0 Offset: 0x310A3D1 VA: 0x310A2D0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x310B000 Offset: 0x310B101 VA: 0x310B000
	|-EqualityComparer<RaycastHit>..ctor
	|
	|-RVA: 0x310BBD0 Offset: 0x310BCD1 VA: 0x310BBD0
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x310C740 Offset: 0x310C841 VA: 0x310C740
	|-EqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x310D2B0 Offset: 0x310D3B1 VA: 0x310D2B0
	|-EqualityComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x310ED20 Offset: 0x310EE21 VA: 0x310ED20
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x310F970 Offset: 0x310FA71 VA: 0x310F970
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EA7CD0 Offset: 0x2EA7DD1 VA: 0x2EA7CD0
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EA8920 Offset: 0x2EA8A21 VA: 0x2EA8920
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EA95E0 Offset: 0x2EA96E1 VA: 0x2EA95E0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EAA150 Offset: 0x2EAA251 VA: 0x2EAA150
	|-EqualityComparer<SceneInstance>..ctor
	|
	|-RVA: 0x2EAADA0 Offset: 0x2EAAEA1 VA: 0x2EAADA0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2EABA60 Offset: 0x2EABB61 VA: 0x2EABA60
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EAC5D0 Offset: 0x2EAC6D1 VA: 0x2EAC5D0
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EAD2A0 Offset: 0x2EAD3A1 VA: 0x2EAD2A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2EADEF0 Offset: 0x2EADFF1 VA: 0x2EADEF0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EB1270 Offset: 0x2EB1371 VA: 0x2EB1270
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EB1EC0 Offset: 0x2EB1FC1 VA: 0x2EB1EC0
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EB2A90 Offset: 0x2EB2B91 VA: 0x2EB2A90
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x2EB3600 Offset: 0x2EB3701 VA: 0x2EB3600
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2EB4170 Offset: 0x2EB4271 VA: 0x2EB4170
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2EB4CB0 Offset: 0x2EB4DB1 VA: 0x2EB4CB0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2EB5820 Offset: 0x2EB5921 VA: 0x2EB5820
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x2EB6630 Offset: 0x2EB6731 VA: 0x2EB6630
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2EB7DF0 Offset: 0x2EB7EF1 VA: 0x2EB7DF0
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EB8930 Offset: 0x2EB8A31 VA: 0x2EB8930
	|-EqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EB9500 Offset: 0x2EB9601 VA: 0x2EB9500
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EBA090 Offset: 0x2EBA191 VA: 0x2EBA090
	|-EqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EBAC60 Offset: 0x2EBAD61 VA: 0x2EBAC60
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2EBBB50 Offset: 0x2EBBC51 VA: 0x2EBBB50
	|-EqualityComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-EqualityComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x2EBD2E0 Offset: 0x2EBD3E1 VA: 0x2EBD2E0
	|-EqualityComparer<stCommand_t>..ctor
	*/
}

[TypeDependencyAttribute] // RVA: 0xB3A20 Offset: 0xB3B21 VA: 0xB3A20
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1441
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A50 Offset: 0x32D4B51 VA: 0x32D4A50
	|-EqualityComparer<Font>.get_Default
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x2E3E1C0 Offset: 0x2E3E2C1 VA: 0x2E3E1C0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.get_Default
	|
	|-RVA: 0x2E3EE10 Offset: 0x2E3EF11 VA: 0x2E3EE10
	|-EqualityComparer<JSONDeserialization.TaskField>.get_Default
	|
	|-RVA: 0x2E3F980 Offset: 0x2E3FA81 VA: 0x2E3F980
	|-EqualityComparer<BitVector32Int>.get_Default
	|
	|-RVA: 0x2E404C0 Offset: 0x2E405C1 VA: 0x2E404C0
	|-EqualityComparer<BuildItemData>.get_Default
	|
	|-RVA: 0x2E413B0 Offset: 0x2E414B1 VA: 0x2E413B0
	|-EqualityComparer<ButtonLinker.LinkObject>.get_Default
	|
	|-RVA: 0x2E41F20 Offset: 0x2E42021 VA: 0x2E41F20
	|-EqualityComparer<CharaCallTable.BustupTable>.get_Default
	|
	|-RVA: 0x2E42A90 Offset: 0x2E42B91 VA: 0x2E42A90
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.get_Default
	|
	|-RVA: 0x2E43620 Offset: 0x2E43721 VA: 0x2E43620
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x2E44190 Offset: 0x2E44291 VA: 0x2E44190
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x2E44CD0 Offset: 0x2E44DD1 VA: 0x2E44CD0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x2E45810 Offset: 0x2E45911 VA: 0x2E45810
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x2E464D0 Offset: 0x2E465D1 VA: 0x2E464D0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x2E471C0 Offset: 0x2E472C1 VA: 0x2E471C0
	|-EqualityComparer<CropDataTable>.get_Default
	|
	|-RVA: 0x2E47E20 Offset: 0x2E47F21 VA: 0x2E47E20
	|-EqualityComparer<DropItemParam>.get_Default
	|
	|-RVA: 0x2E48960 Offset: 0x2E48A61 VA: 0x2E48960
	|-EqualityComparer<EffectDataTable>.get_Default
	|
	|-RVA: 0x2E495B0 Offset: 0x2E496B1 VA: 0x2E495B0
	|-EqualityComparer<ErosionBrush.UndoStep>.get_Default
	|
	|-RVA: 0x2E4A200 Offset: 0x2E4A301 VA: 0x2E4A200
	|-EqualityComparer<EventCheckId>.get_Default
	|
	|-RVA: 0x2E4AE50 Offset: 0x2E4AF51 VA: 0x2E4AE50
	|-EqualityComparer<EventFlagProgressData>.get_Default
	|
	|-RVA: 0x2E4B9C0 Offset: 0x2E4BAC1 VA: 0x2E4B9C0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.get_Default
	|
	|-RVA: 0x2E4C720 Offset: 0x2E4C821 VA: 0x2E4C720
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.get_Default
	|
	|-RVA: 0x2E4D370 Offset: 0x2E4D471 VA: 0x2E4D370
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.get_Default
	|
	|-RVA: 0x2E4DF00 Offset: 0x2E4E001 VA: 0x2E4DF00
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.get_Default
	|
	|-RVA: 0x2E4EA70 Offset: 0x2E4EB71 VA: 0x2E4EA70
	|-EqualityComparer<FesNpcScoreData>.get_Default
	|
	|-RVA: 0x2E4F5E0 Offset: 0x2E4F6E1 VA: 0x2E4F5E0
	|-EqualityComparer<GimmickLayoutDataTable>.get_Default
	|
	|-RVA: 0x2E50120 Offset: 0x2E50221 VA: 0x2E50120
	|-EqualityComparer<MineTypeDataTable>.get_Default
	|
	|-RVA: 0x2E50E50 Offset: 0x2E50F51 VA: 0x2E50E50
	|-EqualityComparer<MiningDataTable>.get_Default
	|
	|-RVA: 0x2E519C0 Offset: 0x2E51AC1 VA: 0x2E519C0
	|-EqualityComparer<MiningPointSaveData>.get_Default
	|
	|-RVA: 0x2E526B0 Offset: 0x2E527B1 VA: 0x2E526B0
	|-EqualityComparer<MonsterDataTable>.get_Default
	|
	|-RVA: 0x2E53330 Offset: 0x2E53431 VA: 0x2E53330
	|-EqualityComparer<MonsterFootStepEventDataTable>.get_Default
	|
	|-RVA: 0x2E53FF0 Offset: 0x2E540F1 VA: 0x2E53FF0
	|-EqualityComparer<MonsterHutSaveData>.get_Default
	|
	|-RVA: 0x2E54CC0 Offset: 0x2E54DC1 VA: 0x2E54CC0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.get_Default
	|
	|-RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
	|-EqualityComparer<NPCActionData>.get_Default
	|
	|-RVA: 0x2E56560 Offset: 0x2E56661 VA: 0x2E56560
	|-EqualityComparer<NpcPlaceSchedule>.get_Default
	|
	|-RVA: 0x2E571B0 Offset: 0x2E572B1 VA: 0x2E571B0
	|-EqualityComparer<OrderLotterySaveParameter>.get_Default
	|
	|-RVA: 0x31FE270 Offset: 0x31FE371 VA: 0x31FE270
	|-EqualityComparer<OrderSaveData>.get_Default
	|
	|-RVA: 0x31FEF40 Offset: 0x31FF041 VA: 0x31FEF40
	|-EqualityComparer<OrderSaveParameter>.get_Default
	|
	|-RVA: 0x31FFB90 Offset: 0x31FFC91 VA: 0x31FFB90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3200700 Offset: 0x3200801 VA: 0x3200700
	|-EqualityComparer<Parameter>.get_Default
	|
	|-RVA: 0x3201380 Offset: 0x3201481 VA: 0x3201380
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.get_Default
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-EqualityComparer<ShopCatalogPage>.get_Default
	|
	|-RVA: 0x3202A60 Offset: 0x3202B61 VA: 0x3202A60
	|-EqualityComparer<ShopNpcTalk>.get_Default
	|
	|-RVA: 0x3203720 Offset: 0x3203821 VA: 0x3203720
	|-EqualityComparer<SubtitleDataTable.Data>.get_Default
	|
	|-RVA: 0x32042B0 Offset: 0x32043B1 VA: 0x32042B0
	|-EqualityComparer<SubtitleDataTable.DataList>.get_Default
	|
	|-RVA: 0x3204DF0 Offset: 0x3204EF1 VA: 0x3204DF0
	|-EqualityComparer<SubtitleHudDataTable.Data>.get_Default
	|
	|-RVA: 0x3205980 Offset: 0x3205A81 VA: 0x3205980
	|-EqualityComparer<ProfilerFrame>.get_Default
	|
	|-RVA: 0x3206550 Offset: 0x3206651 VA: 0x3206550
	|-EqualityComparer<NumberControl.ValueRange>.get_Default
	|
	|-RVA: 0x32070C0 Offset: 0x32071C1 VA: 0x32070C0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.get_Default
	|
	|-RVA: 0x3207D10 Offset: 0x3207E11 VA: 0x3207D10
	|-EqualityComparer<Schedule>.get_Default
	|
	|-RVA: 0x3208960 Offset: 0x3208A61 VA: 0x3208960
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x32094D0 Offset: 0x32095D1 VA: 0x32094D0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.get_Default
	|
	|-RVA: 0x320A060 Offset: 0x320A161 VA: 0x320A060
	|-EqualityComparer<CurveSample>.get_Default
	|
	|-RVA: 0x320AE00 Offset: 0x320AF01 VA: 0x320AE00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x320B950 Offset: 0x320BA51 VA: 0x320B950
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x320C490 Offset: 0x320C591 VA: 0x320C490
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x320CFD0 Offset: 0x320D0D1 VA: 0x320CFD0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x320DB40 Offset: 0x320DC41 VA: 0x320DB40
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x320E680 Offset: 0x320E781 VA: 0x320E680
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x320FD30 Offset: 0x320FE31 VA: 0x320FD30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x32113E0 Offset: 0x32114E1 VA: 0x32113E0
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3211F50 Offset: 0x3212051 VA: 0x3211F50
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3212AA0 Offset: 0x3212BA1 VA: 0x3212AA0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3213610 Offset: 0x3213711 VA: 0x3213610
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3214150 Offset: 0x3214251 VA: 0x3214150
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3214C90 Offset: 0x3214D91 VA: 0x3214C90
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x32157D0 Offset: 0x32158D1 VA: 0x32157D0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3216310 Offset: 0x3216411 VA: 0x3216310
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3216E80 Offset: 0x3216F81 VA: 0x3216E80
	|-EqualityComparer<Memory<object>>.get_Default
	|
	|-RVA: 0x32179F0 Offset: 0x3217AF1 VA: 0x32179F0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.get_Default
	|
	|-RVA: 0x32186E0 Offset: 0x32187E1 VA: 0x32186E0
	|-EqualityComparer<Nullable<Int32Enum>>.get_Default
	|
	|-RVA: 0x3219230 Offset: 0x3219331 VA: 0x3219230
	|-EqualityComparer<Nullable<Bounds>>.get_Default
	|
	|-RVA: 0x3219F20 Offset: 0x321A021 VA: 0x3219F20
	|-EqualityComparer<Nullable<BoundsInt>>.get_Default
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-EqualityComparer<Nullable<Color32>>.get_Default
	|
	|-RVA: 0x32C9420 Offset: 0x32C9521 VA: 0x32C9420
	|-EqualityComparer<Nullable<Color>>.get_Default
	|
	|-RVA: 0x32CA0A0 Offset: 0x32CA1A1 VA: 0x32CA0A0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.get_Default
	|
	|-RVA: 0x32CAC40 Offset: 0x32CAD41 VA: 0x32CAC40
	|-EqualityComparer<Nullable<GradientColorKey>>.get_Default
	|
	|-RVA: 0x32CB8C0 Offset: 0x32CB9C1 VA: 0x32CB8C0
	|-EqualityComparer<Nullable<Keyframe>>.get_Default
	|
	|-RVA: 0x32CC540 Offset: 0x32CC641 VA: 0x32CC540
	|-EqualityComparer<Nullable<LayerMask>>.get_Default
	|
	|-RVA: 0x32CD090 Offset: 0x32CD191 VA: 0x32CD090
	|-EqualityComparer<Nullable<Matrix4x4>>.get_Default
	|
	|-RVA: 0x32CDE90 Offset: 0x32CDF91 VA: 0x32CDE90
	|-EqualityComparer<Nullable<Quaternion>>.get_Default
	|
	|-RVA: 0x32CEB10 Offset: 0x32CEC11 VA: 0x32CEB10
	|-EqualityComparer<Nullable<RangeInt>>.get_Default
	|
	|-RVA: 0x32CF6B0 Offset: 0x32CF7B1 VA: 0x32CF6B0
	|-EqualityComparer<Nullable<Rect>>.get_Default
	|
	|-RVA: 0x32D0330 Offset: 0x32D0431 VA: 0x32D0330
	|-EqualityComparer<Nullable<RectInt>>.get_Default
	|
	|-RVA: 0x32D0FB0 Offset: 0x32D10B1 VA: 0x32D0FB0
	|-EqualityComparer<Nullable<Vector2>>.get_Default
	|
	|-RVA: 0x32D1B50 Offset: 0x32D1C51 VA: 0x32D1B50
	|-EqualityComparer<Nullable<Vector2Int>>.get_Default
	|
	|-RVA: 0x32D26F0 Offset: 0x32D27F1 VA: 0x32D26F0
	|-EqualityComparer<Nullable<Vector3>>.get_Default
	|
	|-RVA: 0x32D3260 Offset: 0x32D3361 VA: 0x32D3260
	|-EqualityComparer<Nullable<Vector3Int>>.get_Default
	|
	|-RVA: 0x32D3DD0 Offset: 0x32D3ED1 VA: 0x32D3DD0
	|-EqualityComparer<Nullable<Vector4>>.get_Default
	|
	|-RVA: 0x32D5570 Offset: 0x32D5671 VA: 0x32D5570
	|-EqualityComparer<ReadOnlyMemory<object>>.get_Default
	|
	|-RVA: 0x32D60E0 Offset: 0x32D61E1 VA: 0x32D60E0
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x32D6C20 Offset: 0x32D6D21 VA: 0x32D6C20
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x32D7790 Offset: 0x32D7891 VA: 0x32D7790
	|-EqualityComparer<RuntimeTypeHandle>.get_Default
	|
	|-RVA: 0x32D82D0 Offset: 0x32D83D1 VA: 0x32D82D0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x32D8E10 Offset: 0x32D8F11 VA: 0x32D8E10
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x32D9960 Offset: 0x32D9A61 VA: 0x32D9960
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x32DA4A0 Offset: 0x32DA5A1 VA: 0x32DA4A0
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x32DAFE0 Offset: 0x32DB0E1 VA: 0x32DAFE0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DC660 Offset: 0x32DC761 VA: 0x32DC660
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x32DD1A0 Offset: 0x32DD2A1 VA: 0x32DD1A0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x32DDD10 Offset: 0x32DDE11 VA: 0x32DDD10
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DE880 Offset: 0x32DE981 VA: 0x32DE880
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x32DF3F0 Offset: 0x32DF4F1 VA: 0x32DF3F0
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x32DFF60 Offset: 0x32E0061 VA: 0x32DFF60
	|-EqualityComparer<ValueTuple<float, float>>.get_Default
	|
	|-RVA: 0x32E0AD0 Offset: 0x32E0BD1 VA: 0x32E0AD0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Default
	|
	|-RVA: 0x32E1660 Offset: 0x32E1761 VA: 0x32E1660
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Default
	|
	|-RVA: 0x32E2390 Offset: 0x32E2491 VA: 0x32E2390
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x32E30C0 Offset: 0x32E31C1 VA: 0x32E30C0
	|-EqualityComparer<TransitionTables>.get_Default
	|
	|-RVA: 0x32E3D10 Offset: 0x32E3E11 VA: 0x32E3D10
	|-EqualityComparer<TutorialUnlockFlagData>.get_Default
	|
	|-RVA: 0x32E48A0 Offset: 0x32E49A1 VA: 0x32E48A0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.get_Default
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-EqualityComparer<CapEdge>.get_Default
	|
	|-RVA: 0x30F14B0 Offset: 0x30F15B1 VA: 0x30F14B0
	|-EqualityComparer<ClippedEdge>.get_Default
	|
	|-RVA: 0x30F2100 Offset: 0x30F2201 VA: 0x30F2100
	|-EqualityComparer<EdgeKeyByHash>.get_Default
	|
	|-RVA: 0x30F2C40 Offset: 0x30F2D41 VA: 0x30F2C40
	|-EqualityComparer<EdgeKeyByIndex>.get_Default
	|
	|-RVA: 0x30F3780 Offset: 0x30F3881 VA: 0x30F3780
	|-EqualityComparer<MeshDataConnectivity.Face>.get_Default
	|
	|-RVA: 0x30F42C0 Offset: 0x30F43C1 VA: 0x30F42C0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.get_Default
	|
	|-RVA: 0x30F4F10 Offset: 0x30F5011 VA: 0x30F4F10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.get_Default
	|
	|-RVA: 0x30F5BD0 Offset: 0x30F5CD1 VA: 0x30F5BD0
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x30F6740 Offset: 0x30F6841 VA: 0x30F6740
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x30F75C0 Offset: 0x30F76C1 VA: 0x30F75C0
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x30F8130 Offset: 0x30F8231 VA: 0x30F8130
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x30F8C70 Offset: 0x30F8D71 VA: 0x30F8C70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x30F97E0 Offset: 0x30F98E1 VA: 0x30F97E0
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x30FA430 Offset: 0x30FA531 VA: 0x30FA430
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x30FB080 Offset: 0x30FB181 VA: 0x30FB080
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x30FBCD0 Offset: 0x30FBDD1 VA: 0x30FBCD0
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x30FC810 Offset: 0x30FC911 VA: 0x30FC810
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x30FD3E0 Offset: 0x30FD4E1 VA: 0x30FD3E0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x30FE260 Offset: 0x30FE361 VA: 0x30FE260
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x30FF000 Offset: 0x30FF101 VA: 0x30FF000
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	|
	|-RVA: 0x30FFB40 Offset: 0x30FFC41 VA: 0x30FFB40
	|-EqualityComparer<GradientAlphaKey>.get_Default
	|
	|-RVA: 0x31006B0 Offset: 0x31007B1 VA: 0x31006B0
	|-EqualityComparer<GradientColorKey>.get_Default
	|
	|-RVA: 0x3101300 Offset: 0x3101401 VA: 0x3101300
	|-EqualityComparer<Keyframe>.get_Default
	|
	|-RVA: 0x3101FC0 Offset: 0x31020C1 VA: 0x3101FC0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3102B00 Offset: 0x3102C01 VA: 0x3102B00
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x31044B0 Offset: 0x31045B1 VA: 0x31044B0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3105020 Offset: 0x3105121 VA: 0x3105020
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3105C70 Offset: 0x3105D71 VA: 0x3105C70
	|-EqualityComparer<PlayableGraph>.get_Default
	|
	|-RVA: 0x31067E0 Offset: 0x31068E1 VA: 0x31067E0
	|-EqualityComparer<Edge>.get_Default
	|
	|-RVA: 0x3107320 Offset: 0x3107421 VA: 0x3107320
	|-EqualityComparer<IntVec3>.get_Default
	|
	|-RVA: 0x3107EF0 Offset: 0x3107FF1 VA: 0x3107EF0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3108AC0 Offset: 0x3108BC1 VA: 0x3108AC0
	|-EqualityComparer<RangeInt>.get_Default
	|
	|-RVA: 0x3109600 Offset: 0x3109701 VA: 0x3109600
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x310A2F0 Offset: 0x310A3F1 VA: 0x310A2F0
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x310B020 Offset: 0x310B121 VA: 0x310B020
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x310BBF0 Offset: 0x310BCF1 VA: 0x310BBF0
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x310C760 Offset: 0x310C861 VA: 0x310C760
	|-EqualityComparer<ReflectionProbeBlendInfo>.get_Default
	|
	|-RVA: 0x310D2D0 Offset: 0x310D3D1 VA: 0x310D2D0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x310E1D0 Offset: 0x310E2D1 VA: 0x310E1D0
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x310ED40 Offset: 0x310EE41 VA: 0x310ED40
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x2EA70A0 Offset: 0x2EA71A1 VA: 0x2EA70A0
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x2EA7CF0 Offset: 0x2EA7DF1 VA: 0x2EA7CF0
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.get_Default
	|
	|-RVA: 0x2EA8940 Offset: 0x2EA8A41 VA: 0x2EA8940
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x2EA9600 Offset: 0x2EA9701 VA: 0x2EA9600
	|-EqualityComparer<SceneInstance>.get_Default
	|
	|-RVA: 0x2EAA170 Offset: 0x2EAA271 VA: 0x2EAA170
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x2EAADC0 Offset: 0x2EAAEC1 VA: 0x2EAADC0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x2EABA80 Offset: 0x2EABB81 VA: 0x2EABA80
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x2EAC5F0 Offset: 0x2EAC6F1 VA: 0x2EAC5F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x2EAD2C0 Offset: 0x2EAD3C1 VA: 0x2EAD2C0
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x2EADF10 Offset: 0x2EAE011 VA: 0x2EADF10
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x2EAEB60 Offset: 0x2EAEC61 VA: 0x2EAEB60
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x2EAF7B0 Offset: 0x2EAF8B1 VA: 0x2EAF7B0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x2EB05C0 Offset: 0x2EB06C1 VA: 0x2EB05C0
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x2EB1290 Offset: 0x2EB1391 VA: 0x2EB1290
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x2EB1EE0 Offset: 0x2EB1FE1 VA: 0x2EB1EE0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x2EB3620 Offset: 0x2EB3721 VA: 0x2EB3620
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x2EB4190 Offset: 0x2EB4291 VA: 0x2EB4190
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x2EB4CD0 Offset: 0x2EB4DD1 VA: 0x2EB4CD0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x2EB5840 Offset: 0x2EB5941 VA: 0x2EB5840
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x2EB6650 Offset: 0x2EB6751 VA: 0x2EB6650
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2EB72A0 Offset: 0x2EB73A1 VA: 0x2EB72A0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x2EB8950 Offset: 0x2EB8A51 VA: 0x2EB8950
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x2EBA0B0 Offset: 0x2EBA1B1 VA: 0x2EBA0B0
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-EqualityComparer<WarpPoints.WarpPoint>.get_Default
	|
	|-RVA: 0x2EBBB70 Offset: 0x2EBBC71 VA: 0x2EBBB70
	|-EqualityComparer<YieldItemParam>.get_Default
	|
	|-RVA: 0x2EBC6B0 Offset: 0x2EBC7B1 VA: 0x2EBC6B0
	|-EqualityComparer<stCommand_t>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E2D0 Offset: 0x2E3E3D1 VA: 0x2E3E2D0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.CreateComparer
	|
	|-RVA: 0x2E3EF20 Offset: 0x2E3F021 VA: 0x2E3EF20
	|-EqualityComparer<JSONDeserialization.TaskField>.CreateComparer
	|
	|-RVA: 0x2E3FA90 Offset: 0x2E3FB91 VA: 0x2E3FA90
	|-EqualityComparer<BitVector32Int>.CreateComparer
	|
	|-RVA: 0x2E405D0 Offset: 0x2E406D1 VA: 0x2E405D0
	|-EqualityComparer<BuildItemData>.CreateComparer
	|
	|-RVA: 0x2E414C0 Offset: 0x2E415C1 VA: 0x2E414C0
	|-EqualityComparer<ButtonLinker.LinkObject>.CreateComparer
	|
	|-RVA: 0x2E42030 Offset: 0x2E42131 VA: 0x2E42030
	|-EqualityComparer<CharaCallTable.BustupTable>.CreateComparer
	|
	|-RVA: 0x2E42BA0 Offset: 0x2E42CA1 VA: 0x2E42BA0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.CreateComparer
	|
	|-RVA: 0x2E43730 Offset: 0x2E43831 VA: 0x2E43730
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x2E465E0 Offset: 0x2E466E1 VA: 0x2E465E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x2E472D0 Offset: 0x2E473D1 VA: 0x2E472D0
	|-EqualityComparer<CropDataTable>.CreateComparer
	|
	|-RVA: 0x2E47F30 Offset: 0x2E48031 VA: 0x2E47F30
	|-EqualityComparer<DropItemParam>.CreateComparer
	|
	|-RVA: 0x2E48A70 Offset: 0x2E48B71 VA: 0x2E48A70
	|-EqualityComparer<EffectDataTable>.CreateComparer
	|
	|-RVA: 0x2E496C0 Offset: 0x2E497C1 VA: 0x2E496C0
	|-EqualityComparer<ErosionBrush.UndoStep>.CreateComparer
	|
	|-RVA: 0x2E4A310 Offset: 0x2E4A411 VA: 0x2E4A310
	|-EqualityComparer<EventCheckId>.CreateComparer
	|
	|-RVA: 0x2E4AF60 Offset: 0x2E4B061 VA: 0x2E4AF60
	|-EqualityComparer<EventFlagProgressData>.CreateComparer
	|
	|-RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.CreateComparer
	|
	|-RVA: 0x2E4C830 Offset: 0x2E4C931 VA: 0x2E4C830
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.CreateComparer
	|
	|-RVA: 0x2E4D480 Offset: 0x2E4D581 VA: 0x2E4D480
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.CreateComparer
	|
	|-RVA: 0x2E4E010 Offset: 0x2E4E111 VA: 0x2E4E010
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.CreateComparer
	|
	|-RVA: 0x2E4EB80 Offset: 0x2E4EC81 VA: 0x2E4EB80
	|-EqualityComparer<FesNpcScoreData>.CreateComparer
	|
	|-RVA: 0x2E4F6F0 Offset: 0x2E4F7F1 VA: 0x2E4F6F0
	|-EqualityComparer<GimmickLayoutDataTable>.CreateComparer
	|
	|-RVA: 0x2E50230 Offset: 0x2E50331 VA: 0x2E50230
	|-EqualityComparer<MineTypeDataTable>.CreateComparer
	|
	|-RVA: 0x2E50F60 Offset: 0x2E51061 VA: 0x2E50F60
	|-EqualityComparer<MiningDataTable>.CreateComparer
	|
	|-RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0
	|-EqualityComparer<MiningPointSaveData>.CreateComparer
	|
	|-RVA: 0x2E527C0 Offset: 0x2E528C1 VA: 0x2E527C0
	|-EqualityComparer<MonsterDataTable>.CreateComparer
	|
	|-RVA: 0x2E53440 Offset: 0x2E53541 VA: 0x2E53440
	|-EqualityComparer<MonsterFootStepEventDataTable>.CreateComparer
	|
	|-RVA: 0x2E54100 Offset: 0x2E54201 VA: 0x2E54100
	|-EqualityComparer<MonsterHutSaveData>.CreateComparer
	|
	|-RVA: 0x2E54DD0 Offset: 0x2E54ED1 VA: 0x2E54DD0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.CreateComparer
	|
	|-RVA: 0x2E55940 Offset: 0x2E55A41 VA: 0x2E55940
	|-EqualityComparer<NPCActionData>.CreateComparer
	|
	|-RVA: 0x2E56670 Offset: 0x2E56771 VA: 0x2E56670
	|-EqualityComparer<NpcPlaceSchedule>.CreateComparer
	|
	|-RVA: 0x2E572C0 Offset: 0x2E573C1 VA: 0x2E572C0
	|-EqualityComparer<OrderLotterySaveParameter>.CreateComparer
	|
	|-RVA: 0x31FE380 Offset: 0x31FE481 VA: 0x31FE380
	|-EqualityComparer<OrderSaveData>.CreateComparer
	|
	|-RVA: 0x31FF050 Offset: 0x31FF151 VA: 0x31FF050
	|-EqualityComparer<OrderSaveParameter>.CreateComparer
	|
	|-RVA: 0x31FFCA0 Offset: 0x31FFDA1 VA: 0x31FFCA0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3200810 Offset: 0x3200911 VA: 0x3200810
	|-EqualityComparer<Parameter>.CreateComparer
	|
	|-RVA: 0x3201490 Offset: 0x3201591 VA: 0x3201490
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.CreateComparer
	|
	|-RVA: 0x3202000 Offset: 0x3202101 VA: 0x3202000
	|-EqualityComparer<ShopCatalogPage>.CreateComparer
	|
	|-RVA: 0x3202B70 Offset: 0x3202C71 VA: 0x3202B70
	|-EqualityComparer<ShopNpcTalk>.CreateComparer
	|
	|-RVA: 0x3203830 Offset: 0x3203931 VA: 0x3203830
	|-EqualityComparer<SubtitleDataTable.Data>.CreateComparer
	|
	|-RVA: 0x32043C0 Offset: 0x32044C1 VA: 0x32043C0
	|-EqualityComparer<SubtitleDataTable.DataList>.CreateComparer
	|
	|-RVA: 0x3204F00 Offset: 0x3205001 VA: 0x3204F00
	|-EqualityComparer<SubtitleHudDataTable.Data>.CreateComparer
	|
	|-RVA: 0x3205A90 Offset: 0x3205B91 VA: 0x3205A90
	|-EqualityComparer<ProfilerFrame>.CreateComparer
	|
	|-RVA: 0x3206660 Offset: 0x3206761 VA: 0x3206660
	|-EqualityComparer<NumberControl.ValueRange>.CreateComparer
	|
	|-RVA: 0x32071D0 Offset: 0x32072D1 VA: 0x32071D0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.CreateComparer
	|
	|-RVA: 0x3207E20 Offset: 0x3207F21 VA: 0x3207E20
	|-EqualityComparer<Schedule>.CreateComparer
	|
	|-RVA: 0x3208A70 Offset: 0x3208B71 VA: 0x3208A70
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x32095E0 Offset: 0x32096E1 VA: 0x32095E0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.CreateComparer
	|
	|-RVA: 0x320A170 Offset: 0x320A271 VA: 0x320A170
	|-EqualityComparer<CurveSample>.CreateComparer
	|
	|-RVA: 0x320AF10 Offset: 0x320B011 VA: 0x320AF10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x320BA60 Offset: 0x320BB61 VA: 0x320BA60
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x320C5A0 Offset: 0x320C6A1 VA: 0x320C5A0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x320D0E0 Offset: 0x320D1E1 VA: 0x320D0E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x320DC50 Offset: 0x320DD51 VA: 0x320DC50
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x320E790 Offset: 0x320E891 VA: 0x320E790
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x320F300 Offset: 0x320F401 VA: 0x320F300
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x320FE40 Offset: 0x320FF41 VA: 0x320FE40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x32109B0 Offset: 0x3210AB1 VA: 0x32109B0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x32114F0 Offset: 0x32115F1 VA: 0x32114F0
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3212060 Offset: 0x3212161 VA: 0x3212060
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3212BB0 Offset: 0x3212CB1 VA: 0x3212BB0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3213720 Offset: 0x3213821 VA: 0x3213720
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3214260 Offset: 0x3214361 VA: 0x3214260
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3214DA0 Offset: 0x3214EA1 VA: 0x3214DA0
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x32158E0 Offset: 0x32159E1 VA: 0x32158E0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3216420 Offset: 0x3216521 VA: 0x3216420
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3216F90 Offset: 0x3217091 VA: 0x3216F90
	|-EqualityComparer<Memory<object>>.CreateComparer
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.CreateComparer
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-EqualityComparer<Nullable<Int32Enum>>.CreateComparer
	|
	|-RVA: 0x3219340 Offset: 0x3219441 VA: 0x3219340
	|-EqualityComparer<Nullable<Bounds>>.CreateComparer
	|
	|-RVA: 0x321A030 Offset: 0x321A131 VA: 0x321A030
	|-EqualityComparer<Nullable<BoundsInt>>.CreateComparer
	|
	|-RVA: 0x321AD20 Offset: 0x321AE21 VA: 0x321AD20
	|-EqualityComparer<Nullable<Color32>>.CreateComparer
	|
	|-RVA: 0x32C9530 Offset: 0x32C9631 VA: 0x32C9530
	|-EqualityComparer<Nullable<Color>>.CreateComparer
	|
	|-RVA: 0x32CA1B0 Offset: 0x32CA2B1 VA: 0x32CA1B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.CreateComparer
	|
	|-RVA: 0x32CAD50 Offset: 0x32CAE51 VA: 0x32CAD50
	|-EqualityComparer<Nullable<GradientColorKey>>.CreateComparer
	|
	|-RVA: 0x32CB9D0 Offset: 0x32CBAD1 VA: 0x32CB9D0
	|-EqualityComparer<Nullable<Keyframe>>.CreateComparer
	|
	|-RVA: 0x32CC650 Offset: 0x32CC751 VA: 0x32CC650
	|-EqualityComparer<Nullable<LayerMask>>.CreateComparer
	|
	|-RVA: 0x32CD1A0 Offset: 0x32CD2A1 VA: 0x32CD1A0
	|-EqualityComparer<Nullable<Matrix4x4>>.CreateComparer
	|
	|-RVA: 0x32CDFA0 Offset: 0x32CE0A1 VA: 0x32CDFA0
	|-EqualityComparer<Nullable<Quaternion>>.CreateComparer
	|
	|-RVA: 0x32CEC20 Offset: 0x32CED21 VA: 0x32CEC20
	|-EqualityComparer<Nullable<RangeInt>>.CreateComparer
	|
	|-RVA: 0x32CF7C0 Offset: 0x32CF8C1 VA: 0x32CF7C0
	|-EqualityComparer<Nullable<Rect>>.CreateComparer
	|
	|-RVA: 0x32D0440 Offset: 0x32D0541 VA: 0x32D0440
	|-EqualityComparer<Nullable<RectInt>>.CreateComparer
	|
	|-RVA: 0x32D10C0 Offset: 0x32D11C1 VA: 0x32D10C0
	|-EqualityComparer<Nullable<Vector2>>.CreateComparer
	|
	|-RVA: 0x32D1C60 Offset: 0x32D1D61 VA: 0x32D1C60
	|-EqualityComparer<Nullable<Vector2Int>>.CreateComparer
	|
	|-RVA: 0x32D2800 Offset: 0x32D2901 VA: 0x32D2800
	|-EqualityComparer<Nullable<Vector3>>.CreateComparer
	|
	|-RVA: 0x32D3370 Offset: 0x32D3471 VA: 0x32D3370
	|-EqualityComparer<Nullable<Vector3Int>>.CreateComparer
	|
	|-RVA: 0x32D3EE0 Offset: 0x32D3FE1 VA: 0x32D3EE0
	|-EqualityComparer<Nullable<Vector4>>.CreateComparer
	|
	|-RVA: 0x32D4B60 Offset: 0x32D4C61 VA: 0x32D4B60
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x32D5680 Offset: 0x32D5781 VA: 0x32D5680
	|-EqualityComparer<ReadOnlyMemory<object>>.CreateComparer
	|
	|-RVA: 0x32D61F0 Offset: 0x32D62F1 VA: 0x32D61F0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x32D6D30 Offset: 0x32D6E31 VA: 0x32D6D30
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x32D78A0 Offset: 0x32D79A1 VA: 0x32D78A0
	|-EqualityComparer<RuntimeTypeHandle>.CreateComparer
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x32D8F20 Offset: 0x32D9021 VA: 0x32D8F20
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x32D9A70 Offset: 0x32D9B71 VA: 0x32D9A70
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x32DB0F0 Offset: 0x32DB1F1 VA: 0x32DB0F0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x32DBC30 Offset: 0x32DBD31 VA: 0x32DBC30
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DC770 Offset: 0x32DC871 VA: 0x32DC770
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x32DD2B0 Offset: 0x32DD3B1 VA: 0x32DD2B0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x32DDE20 Offset: 0x32DDF21 VA: 0x32DDE20
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DE990 Offset: 0x32DEA91 VA: 0x32DE990
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x32E0070 Offset: 0x32E0171 VA: 0x32E0070
	|-EqualityComparer<ValueTuple<float, float>>.CreateComparer
	|
	|-RVA: 0x32E0BE0 Offset: 0x32E0CE1 VA: 0x32E0BE0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CreateComparer
	|
	|-RVA: 0x32E24A0 Offset: 0x32E25A1 VA: 0x32E24A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x32E31D0 Offset: 0x32E32D1 VA: 0x32E31D0
	|-EqualityComparer<TransitionTables>.CreateComparer
	|
	|-RVA: 0x32E3E20 Offset: 0x32E3F21 VA: 0x32E3E20
	|-EqualityComparer<TutorialUnlockFlagData>.CreateComparer
	|
	|-RVA: 0x32E49B0 Offset: 0x32E4AB1 VA: 0x32E49B0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.CreateComparer
	|
	|-RVA: 0x32E5520 Offset: 0x32E5621 VA: 0x32E5520
	|-EqualityComparer<CapEdge>.CreateComparer
	|
	|-RVA: 0x30F15C0 Offset: 0x30F16C1 VA: 0x30F15C0
	|-EqualityComparer<ClippedEdge>.CreateComparer
	|
	|-RVA: 0x30F2210 Offset: 0x30F2311 VA: 0x30F2210
	|-EqualityComparer<EdgeKeyByHash>.CreateComparer
	|
	|-RVA: 0x30F2D50 Offset: 0x30F2E51 VA: 0x30F2D50
	|-EqualityComparer<EdgeKeyByIndex>.CreateComparer
	|
	|-RVA: 0x30F3890 Offset: 0x30F3991 VA: 0x30F3890
	|-EqualityComparer<MeshDataConnectivity.Face>.CreateComparer
	|
	|-RVA: 0x30F43D0 Offset: 0x30F44D1 VA: 0x30F43D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.CreateComparer
	|
	|-RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.CreateComparer
	|
	|-RVA: 0x30F5CE0 Offset: 0x30F5DE1 VA: 0x30F5CE0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x30F76D0 Offset: 0x30F77D1 VA: 0x30F76D0
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x30F8240 Offset: 0x30F8341 VA: 0x30F8240
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x30F8D80 Offset: 0x30F8E81 VA: 0x30F8D80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x30FA540 Offset: 0x30FA641 VA: 0x30FA540
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x30FB190 Offset: 0x30FB291 VA: 0x30FB190
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x30FBDE0 Offset: 0x30FBEE1 VA: 0x30FBDE0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x30FC920 Offset: 0x30FCA21 VA: 0x30FC920
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x30FD4F0 Offset: 0x30FD5F1 VA: 0x30FD4F0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x30FE370 Offset: 0x30FE471 VA: 0x30FE370
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	|
	|-RVA: 0x30FFC50 Offset: 0x30FFD51 VA: 0x30FFC50
	|-EqualityComparer<GradientAlphaKey>.CreateComparer
	|
	|-RVA: 0x31007C0 Offset: 0x31008C1 VA: 0x31007C0
	|-EqualityComparer<GradientColorKey>.CreateComparer
	|
	|-RVA: 0x3101410 Offset: 0x3101511 VA: 0x3101410
	|-EqualityComparer<Keyframe>.CreateComparer
	|
	|-RVA: 0x31020D0 Offset: 0x31021D1 VA: 0x31020D0
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3102C10 Offset: 0x3102D11 VA: 0x3102C10
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3103940 Offset: 0x3103A41 VA: 0x3103940
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x31045C0 Offset: 0x31046C1 VA: 0x31045C0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3105130 Offset: 0x3105231 VA: 0x3105130
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3105D80 Offset: 0x3105E81 VA: 0x3105D80
	|-EqualityComparer<PlayableGraph>.CreateComparer
	|
	|-RVA: 0x31068F0 Offset: 0x31069F1 VA: 0x31068F0
	|-EqualityComparer<Edge>.CreateComparer
	|
	|-RVA: 0x3107430 Offset: 0x3107531 VA: 0x3107430
	|-EqualityComparer<IntVec3>.CreateComparer
	|
	|-RVA: 0x3108000 Offset: 0x3108101 VA: 0x3108000
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3108BD0 Offset: 0x3108CD1 VA: 0x3108BD0
	|-EqualityComparer<RangeInt>.CreateComparer
	|
	|-RVA: 0x3109710 Offset: 0x3109811 VA: 0x3109710
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x310A400 Offset: 0x310A501 VA: 0x310A400
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x310B130 Offset: 0x310B231 VA: 0x310B130
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x310BD00 Offset: 0x310BE01 VA: 0x310BD00
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x310C870 Offset: 0x310C971 VA: 0x310C870
	|-EqualityComparer<ReflectionProbeBlendInfo>.CreateComparer
	|
	|-RVA: 0x310D3E0 Offset: 0x310D4E1 VA: 0x310D3E0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x310E2E0 Offset: 0x310E3E1 VA: 0x310E2E0
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x310EE50 Offset: 0x310EF51 VA: 0x310EE50
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x2EA71B0 Offset: 0x2EA72B1 VA: 0x2EA71B0
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x2EA7E00 Offset: 0x2EA7F01 VA: 0x2EA7E00
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.CreateComparer
	|
	|-RVA: 0x2EA8A50 Offset: 0x2EA8B51 VA: 0x2EA8A50
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x2EA9710 Offset: 0x2EA9811 VA: 0x2EA9710
	|-EqualityComparer<SceneInstance>.CreateComparer
	|
	|-RVA: 0x2EAA280 Offset: 0x2EAA381 VA: 0x2EAA280
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x2EAAED0 Offset: 0x2EAAFD1 VA: 0x2EAAED0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x2EABB90 Offset: 0x2EABC91 VA: 0x2EABB90
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x2EAC700 Offset: 0x2EAC801 VA: 0x2EAC700
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x2EAD3D0 Offset: 0x2EAD4D1 VA: 0x2EAD3D0
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x2EAE020 Offset: 0x2EAE121 VA: 0x2EAE020
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x2EAEC70 Offset: 0x2EAED71 VA: 0x2EAEC70
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x2EAF8C0 Offset: 0x2EAF9C1 VA: 0x2EAF8C0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x2EB06D0 Offset: 0x2EB07D1 VA: 0x2EB06D0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x2EB13A0 Offset: 0x2EB14A1 VA: 0x2EB13A0
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x2EB2BC0 Offset: 0x2EB2CC1 VA: 0x2EB2BC0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x2EB3730 Offset: 0x2EB3831 VA: 0x2EB3730
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x2EB42A0 Offset: 0x2EB43A1 VA: 0x2EB42A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x2EB4DE0 Offset: 0x2EB4EE1 VA: 0x2EB4DE0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x2EB5950 Offset: 0x2EB5A51 VA: 0x2EB5950
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x2EB6760 Offset: 0x2EB6861 VA: 0x2EB6760
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2EB73B0 Offset: 0x2EB74B1 VA: 0x2EB73B0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2EB7F20 Offset: 0x2EB8021 VA: 0x2EB7F20
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x2EB8A60 Offset: 0x2EB8B61 VA: 0x2EB8A60
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2EB9630 Offset: 0x2EB9731 VA: 0x2EB9630
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x2EBA1C0 Offset: 0x2EBA2C1 VA: 0x2EBA1C0
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x2EBAD90 Offset: 0x2EBAE91 VA: 0x2EBAD90
	|-EqualityComparer<WarpPoints.WarpPoint>.CreateComparer
	|
	|-RVA: 0x2EBBC80 Offset: 0x2EBBD81 VA: 0x2EBBC80
	|-EqualityComparer<YieldItemParam>.CreateComparer
	|
	|-RVA: 0x2EBC7C0 Offset: 0x2EBC8C1 VA: 0x2EBC7C0
	|-EqualityComparer<stCommand_t>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E910 Offset: 0x2E3EA11 VA: 0x2E3E910
	|-EqualityComparer<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2E3F560 Offset: 0x2E3F661 VA: 0x2E3F560
	|-EqualityComparer<JSONDeserialization.TaskField>.IndexOf
	|
	|-RVA: 0x2E400D0 Offset: 0x2E401D1 VA: 0x2E400D0
	|-EqualityComparer<BitVector32Int>.IndexOf
	|
	|-RVA: 0x2E40C10 Offset: 0x2E40D11 VA: 0x2E40C10
	|-EqualityComparer<BuildItemData>.IndexOf
	|
	|-RVA: 0x2E41B00 Offset: 0x2E41C01 VA: 0x2E41B00
	|-EqualityComparer<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2E42670 Offset: 0x2E42771 VA: 0x2E42670
	|-EqualityComparer<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2E431E0 Offset: 0x2E432E1 VA: 0x2E431E0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2E43D70 Offset: 0x2E43E71 VA: 0x2E43D70
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2E448E0 Offset: 0x2E449E1 VA: 0x2E448E0
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2E45420 Offset: 0x2E45521 VA: 0x2E45420
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2E45F60 Offset: 0x2E46061 VA: 0x2E45F60
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2E46C20 Offset: 0x2E46D21 VA: 0x2E46C20
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2E47910 Offset: 0x2E47A11 VA: 0x2E47910
	|-EqualityComparer<CropDataTable>.IndexOf
	|
	|-RVA: 0x2E48570 Offset: 0x2E48671 VA: 0x2E48570
	|-EqualityComparer<DropItemParam>.IndexOf
	|
	|-RVA: 0x2E490B0 Offset: 0x2E491B1 VA: 0x2E490B0
	|-EqualityComparer<EffectDataTable>.IndexOf
	|
	|-RVA: 0x2E49D00 Offset: 0x2E49E01 VA: 0x2E49D00
	|-EqualityComparer<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2E4A950 Offset: 0x2E4AA51 VA: 0x2E4A950
	|-EqualityComparer<EventCheckId>.IndexOf
	|
	|-RVA: 0x2E4B5A0 Offset: 0x2E4B6A1 VA: 0x2E4B5A0
	|-EqualityComparer<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2E4C110 Offset: 0x2E4C211 VA: 0x2E4C110
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.IndexOf
	|
	|-RVA: 0x2E4CE70 Offset: 0x2E4CF71 VA: 0x2E4CE70
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.IndexOf
	|
	|-RVA: 0x2E4DAC0 Offset: 0x2E4DBC1 VA: 0x2E4DAC0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.IndexOf
	|
	|-RVA: 0x2E4E650 Offset: 0x2E4E751 VA: 0x2E4E650
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.IndexOf
	|
	|-RVA: 0x2E4F1C0 Offset: 0x2E4F2C1 VA: 0x2E4F1C0
	|-EqualityComparer<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2E4FD30 Offset: 0x2E4FE31 VA: 0x2E4FD30
	|-EqualityComparer<GimmickLayoutDataTable>.IndexOf
	|
	|-RVA: 0x2E50870 Offset: 0x2E50971 VA: 0x2E50870
	|-EqualityComparer<MineTypeDataTable>.IndexOf
	|
	|-RVA: 0x2E515A0 Offset: 0x2E516A1 VA: 0x2E515A0
	|-EqualityComparer<MiningDataTable>.IndexOf
	|
	|-RVA: 0x2E52110 Offset: 0x2E52211 VA: 0x2E52110
	|-EqualityComparer<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2E52E00 Offset: 0x2E52F01 VA: 0x2E52E00
	|-EqualityComparer<MonsterDataTable>.IndexOf
	|
	|-RVA: 0x2E53A80 Offset: 0x2E53B81 VA: 0x2E53A80
	|-EqualityComparer<MonsterFootStepEventDataTable>.IndexOf
	|
	|-RVA: 0x2E54740 Offset: 0x2E54841 VA: 0x2E54740
	|-EqualityComparer<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2E55410 Offset: 0x2E55511 VA: 0x2E55410
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x2E55F80 Offset: 0x2E56081 VA: 0x2E55F80
	|-EqualityComparer<NPCActionData>.IndexOf
	|
	|-RVA: 0x2E56CB0 Offset: 0x2E56DB1 VA: 0x2E56CB0
	|-EqualityComparer<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	|-EqualityComparer<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31FE9C0 Offset: 0x31FEAC1 VA: 0x31FE9C0
	|-EqualityComparer<OrderSaveData>.IndexOf
	|
	|-RVA: 0x31FF690 Offset: 0x31FF791 VA: 0x31FF690
	|-EqualityComparer<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32002E0 Offset: 0x32003E1 VA: 0x32002E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3200E50 Offset: 0x3200F51 VA: 0x3200E50
	|-EqualityComparer<Parameter>.IndexOf
	|
	|-RVA: 0x3201AD0 Offset: 0x3201BD1 VA: 0x3201AD0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.IndexOf
	|
	|-RVA: 0x3202640 Offset: 0x3202741 VA: 0x3202640
	|-EqualityComparer<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32031B0 Offset: 0x32032B1 VA: 0x32031B0
	|-EqualityComparer<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x3203E70 Offset: 0x3203F71 VA: 0x3203E70
	|-EqualityComparer<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3204A00 Offset: 0x3204B01 VA: 0x3204A00
	|-EqualityComparer<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3205540 Offset: 0x3205641 VA: 0x3205540
	|-EqualityComparer<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32060D0 Offset: 0x32061D1 VA: 0x32060D0
	|-EqualityComparer<ProfilerFrame>.IndexOf
	|
	|-RVA: 0x3206CA0 Offset: 0x3206DA1 VA: 0x3206CA0
	|-EqualityComparer<NumberControl.ValueRange>.IndexOf
	|
	|-RVA: 0x3207810 Offset: 0x3207911 VA: 0x3207810
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x3208460 Offset: 0x3208561 VA: 0x3208460
	|-EqualityComparer<Schedule>.IndexOf
	|
	|-RVA: 0x32090B0 Offset: 0x32091B1 VA: 0x32090B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3209C20 Offset: 0x3209D21 VA: 0x3209C20
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x320A7B0 Offset: 0x320A8B1 VA: 0x320A7B0
	|-EqualityComparer<CurveSample>.IndexOf
	|
	|-RVA: 0x320B550 Offset: 0x320B651 VA: 0x320B550
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x320C0A0 Offset: 0x320C1A1 VA: 0x320C0A0
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x320D720 Offset: 0x320D821 VA: 0x320D720
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x320E290 Offset: 0x320E391 VA: 0x320E290
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x320EDD0 Offset: 0x320EED1 VA: 0x320EDD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x320F940 Offset: 0x320FA41 VA: 0x320F940
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3210480 Offset: 0x3210581 VA: 0x3210480
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3210FF0 Offset: 0x32110F1 VA: 0x3210FF0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3211B30 Offset: 0x3211C31 VA: 0x3211B30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x32126A0 Offset: 0x32127A1 VA: 0x32126A0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x32131F0 Offset: 0x32132F1 VA: 0x32131F0
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3213D60 Offset: 0x3213E61 VA: 0x3213D60
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x32148A0 Offset: 0x32149A1 VA: 0x32148A0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x32153E0 Offset: 0x32154E1 VA: 0x32153E0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3216A60 Offset: 0x3216B61 VA: 0x3216A60
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x32175D0 Offset: 0x32176D1 VA: 0x32175D0
	|-EqualityComparer<Memory<object>>.IndexOf
	|
	|-RVA: 0x3218140 Offset: 0x3218241 VA: 0x3218140
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.IndexOf
	|
	|-RVA: 0x3218E30 Offset: 0x3218F31 VA: 0x3218E30
	|-EqualityComparer<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3219980 Offset: 0x3219A81 VA: 0x3219980
	|-EqualityComparer<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x321A670 Offset: 0x321A771 VA: 0x321A670
	|-EqualityComparer<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x321B360 Offset: 0x321B461 VA: 0x321B360
	|-EqualityComparer<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x32C9B70 Offset: 0x32C9C71 VA: 0x32C9B70
	|-EqualityComparer<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x32CA7F0 Offset: 0x32CA8F1 VA: 0x32CA7F0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-EqualityComparer<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x32CC010 Offset: 0x32CC111 VA: 0x32CC010
	|-EqualityComparer<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x32CCC90 Offset: 0x32CCD91 VA: 0x32CCC90
	|-EqualityComparer<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x32CD7E0 Offset: 0x32CD8E1 VA: 0x32CD7E0
	|-EqualityComparer<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32CE5E0 Offset: 0x32CE6E1 VA: 0x32CE5E0
	|-EqualityComparer<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32CF260 Offset: 0x32CF361 VA: 0x32CF260
	|-EqualityComparer<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32CFE00 Offset: 0x32CFF01 VA: 0x32CFE00
	|-EqualityComparer<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x32D0A80 Offset: 0x32D0B81 VA: 0x32D0A80
	|-EqualityComparer<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x32D1700 Offset: 0x32D1801 VA: 0x32D1700
	|-EqualityComparer<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32D22A0 Offset: 0x32D23A1 VA: 0x32D22A0
	|-EqualityComparer<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32D2E40 Offset: 0x32D2F41 VA: 0x32D2E40
	|-EqualityComparer<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x32D39B0 Offset: 0x32D3AB1 VA: 0x32D39B0
	|-EqualityComparer<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-EqualityComparer<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x32D51A0 Offset: 0x32D52A1 VA: 0x32D51A0
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-EqualityComparer<ReadOnlyMemory<object>>.IndexOf
	|
	|-RVA: 0x32D6830 Offset: 0x32D6931 VA: 0x32D6830
	|-EqualityComparer<Label>.IndexOf
	|
	|-RVA: 0x32D7370 Offset: 0x32D7471 VA: 0x32D7370
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x32D7EE0 Offset: 0x32D7FE1 VA: 0x32D7EE0
	|-EqualityComparer<RuntimeTypeHandle>.IndexOf
	|
	|-RVA: 0x32D8A20 Offset: 0x32D8B21 VA: 0x32D8A20
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x32D9560 Offset: 0x32D9661 VA: 0x32D9560
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x32DA0B0 Offset: 0x32DA1B1 VA: 0x32DA0B0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x32DABF0 Offset: 0x32DACF1 VA: 0x32DABF0
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x32DB730 Offset: 0x32DB831 VA: 0x32DB730
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x32DC270 Offset: 0x32DC371 VA: 0x32DC270
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DCDB0 Offset: 0x32DCEB1 VA: 0x32DCDB0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32DE460 Offset: 0x32DE561 VA: 0x32DE460
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DEFD0 Offset: 0x32DF0D1 VA: 0x32DEFD0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32DFB40 Offset: 0x32DFC41 VA: 0x32DFB40
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32E06B0 Offset: 0x32E07B1 VA: 0x32E06B0
	|-EqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x32E1220 Offset: 0x32E1321 VA: 0x32E1220
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32E1DB0 Offset: 0x32E1EB1 VA: 0x32E1DB0
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32E3810 Offset: 0x32E3911 VA: 0x32E3810
	|-EqualityComparer<TransitionTables>.IndexOf
	|
	|-RVA: 0x32E4460 Offset: 0x32E4561 VA: 0x32E4460
	|-EqualityComparer<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32E4FF0 Offset: 0x32E50F1 VA: 0x32E4FF0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32E5B60 Offset: 0x32E5C61 VA: 0x32E5B60
	|-EqualityComparer<CapEdge>.IndexOf
	|
	|-RVA: 0x30F1C00 Offset: 0x30F1D01 VA: 0x30F1C00
	|-EqualityComparer<ClippedEdge>.IndexOf
	|
	|-RVA: 0x30F2850 Offset: 0x30F2951 VA: 0x30F2850
	|-EqualityComparer<EdgeKeyByHash>.IndexOf
	|
	|-RVA: 0x30F3390 Offset: 0x30F3491 VA: 0x30F3390
	|-EqualityComparer<EdgeKeyByIndex>.IndexOf
	|
	|-RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	|-EqualityComparer<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x30F4A10 Offset: 0x30F4B11 VA: 0x30F4A10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x30F5660 Offset: 0x30F5761 VA: 0x30F5660
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x30F6320 Offset: 0x30F6421 VA: 0x30F6320
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x30F6E90 Offset: 0x30F6F91 VA: 0x30F6E90
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x30F7D10 Offset: 0x30F7E11 VA: 0x30F7D10
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x30F8880 Offset: 0x30F8981 VA: 0x30F8880
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x30F93C0 Offset: 0x30F94C1 VA: 0x30F93C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x30F9F30 Offset: 0x30FA031 VA: 0x30F9F30
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x30FAB80 Offset: 0x30FAC81 VA: 0x30FAB80
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x30FB7D0 Offset: 0x30FB8D1 VA: 0x30FB7D0
	|-EqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x30FC420 Offset: 0x30FC521 VA: 0x30FC420
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x30FCF60 Offset: 0x30FD061 VA: 0x30FCF60
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x30FDB30 Offset: 0x30FDC31 VA: 0x30FDB30
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x30FE9B0 Offset: 0x30FEAB1 VA: 0x30FE9B0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x30FF750 Offset: 0x30FF851 VA: 0x30FF750
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	|
	|-RVA: 0x3100290 Offset: 0x3100391 VA: 0x3100290
	|-EqualityComparer<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x3100E00 Offset: 0x3100F01 VA: 0x3100E00
	|-EqualityComparer<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3101A50 Offset: 0x3101B51 VA: 0x3101A50
	|-EqualityComparer<Keyframe>.IndexOf
	|
	|-RVA: 0x3102710 Offset: 0x3102811 VA: 0x3102710
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3103250 Offset: 0x3103351 VA: 0x3103250
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3103F80 Offset: 0x3104081 VA: 0x3103F80
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3104C00 Offset: 0x3104D01 VA: 0x3104C00
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3105770 Offset: 0x3105871 VA: 0x3105770
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	|-EqualityComparer<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3106F30 Offset: 0x3107031 VA: 0x3106F30
	|-EqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x3107A70 Offset: 0x3107B71 VA: 0x3107A70
	|-EqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x3108640 Offset: 0x3108741 VA: 0x3108640
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3109210 Offset: 0x3109311 VA: 0x3109210
	|-EqualityComparer<RangeInt>.IndexOf
	|
	|-RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x310AA40 Offset: 0x310AB41 VA: 0x310AA40
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x310B770 Offset: 0x310B871 VA: 0x310B770
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x310C340 Offset: 0x310C441 VA: 0x310C340
	|-EqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x310CEB0 Offset: 0x310CFB1 VA: 0x310CEB0
	|-EqualityComparer<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x310DA20 Offset: 0x310DB21 VA: 0x310DA20
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x310E920 Offset: 0x310EA21 VA: 0x310E920
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x310F490 Offset: 0x310F591 VA: 0x310F490
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x2EA77F0 Offset: 0x2EA78F1 VA: 0x2EA77F0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EA8440 Offset: 0x2EA8541 VA: 0x2EA8440
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EA9090 Offset: 0x2EA9191 VA: 0x2EA9090
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2EA9D50 Offset: 0x2EA9E51 VA: 0x2EA9D50
	|-EqualityComparer<SceneInstance>.IndexOf
	|
	|-RVA: 0x2EAA8C0 Offset: 0x2EAA9C1 VA: 0x2EAA8C0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2EAB510 Offset: 0x2EAB611 VA: 0x2EAB510
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2EAC1D0 Offset: 0x2EAC2D1 VA: 0x2EAC1D0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EACD40 Offset: 0x2EACE41 VA: 0x2EACD40
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2EADA10 Offset: 0x2EADB11 VA: 0x2EADA10
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2EAE660 Offset: 0x2EAE761 VA: 0x2EAE660
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2EAF2B0 Offset: 0x2EAF3B1 VA: 0x2EAF2B0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2EAFF00 Offset: 0x2EB0001 VA: 0x2EAFF00
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EB0D10 Offset: 0x2EB0E11 VA: 0x2EB0D10
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EB2630 Offset: 0x2EB2731 VA: 0x2EB2630
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x2EB3200 Offset: 0x2EB3301 VA: 0x2EB3200
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|
	|-RVA: 0x2EB3D70 Offset: 0x2EB3E71 VA: 0x2EB3D70
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2EB48E0 Offset: 0x2EB49E1 VA: 0x2EB48E0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|
	|-RVA: 0x2EB5420 Offset: 0x2EB5521 VA: 0x2EB5420
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x2EB5F90 Offset: 0x2EB6091 VA: 0x2EB5F90
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x2EB6DA0 Offset: 0x2EB6EA1 VA: 0x2EB6DA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2EB79F0 Offset: 0x2EB7AF1 VA: 0x2EB79F0
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EB8560 Offset: 0x2EB8661 VA: 0x2EB8560
	|-EqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EB90A0 Offset: 0x2EB91A1 VA: 0x2EB90A0
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EB9C70 Offset: 0x2EB9D71 VA: 0x2EB9C70
	|-EqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EBA800 Offset: 0x2EBA901 VA: 0x2EBA800
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2EBB3D0 Offset: 0x2EBB4D1 VA: 0x2EBB3D0
	|-EqualityComparer<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2EBC2C0 Offset: 0x2EBC3C1 VA: 0x2EBC2C0
	|-EqualityComparer<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2EBCE00 Offset: 0x2EBCF01 VA: 0x2EBCE00
	|-EqualityComparer<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EA30 Offset: 0x2E3EB31 VA: 0x2E3EA30
	|-EqualityComparer<AS_ToolController.ChargeInfo>.LastIndexOf
	|
	|-RVA: 0x2E3F630 Offset: 0x2E3F731 VA: 0x2E3F630
	|-EqualityComparer<JSONDeserialization.TaskField>.LastIndexOf
	|
	|-RVA: 0x2E40190 Offset: 0x2E40291 VA: 0x2E40190
	|-EqualityComparer<BitVector32Int>.LastIndexOf
	|
	|-RVA: 0x2E40DF0 Offset: 0x2E40EF1 VA: 0x2E40DF0
	|-EqualityComparer<BuildItemData>.LastIndexOf
	|
	|-RVA: 0x2E41BD0 Offset: 0x2E41CD1 VA: 0x2E41BD0
	|-EqualityComparer<ButtonLinker.LinkObject>.LastIndexOf
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-EqualityComparer<CharaCallTable.BustupTable>.LastIndexOf
	|
	|-RVA: 0x2E432C0 Offset: 0x2E433C1 VA: 0x2E432C0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.LastIndexOf
	|
	|-RVA: 0x2E43E40 Offset: 0x2E43F41 VA: 0x2E43E40
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x2E449A0 Offset: 0x2E44AA1 VA: 0x2E449A0
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x2E454E0 Offset: 0x2E455E1 VA: 0x2E454E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x2E460A0 Offset: 0x2E461A1 VA: 0x2E460A0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x2E46D70 Offset: 0x2E46E71 VA: 0x2E46D70
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x2E47A30 Offset: 0x2E47B31 VA: 0x2E47A30
	|-EqualityComparer<CropDataTable>.LastIndexOf
	|
	|-RVA: 0x2E48630 Offset: 0x2E48731 VA: 0x2E48630
	|-EqualityComparer<DropItemParam>.LastIndexOf
	|
	|-RVA: 0x2E491D0 Offset: 0x2E492D1 VA: 0x2E491D0
	|-EqualityComparer<EffectDataTable>.LastIndexOf
	|
	|-RVA: 0x2E49E20 Offset: 0x2E49F21 VA: 0x2E49E20
	|-EqualityComparer<ErosionBrush.UndoStep>.LastIndexOf
	|
	|-RVA: 0x2E4AA70 Offset: 0x2E4AB71 VA: 0x2E4AA70
	|-EqualityComparer<EventCheckId>.LastIndexOf
	|
	|-RVA: 0x2E4B670 Offset: 0x2E4B771 VA: 0x2E4B670
	|-EqualityComparer<EventFlagProgressData>.LastIndexOf
	|
	|-RVA: 0x2E4C280 Offset: 0x2E4C381 VA: 0x2E4C280
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.LastIndexOf
	|
	|-RVA: 0x2E4CF90 Offset: 0x2E4D091 VA: 0x2E4CF90
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4DBA0 Offset: 0x2E4DCA1 VA: 0x2E4DBA0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4E720 Offset: 0x2E4E821 VA: 0x2E4E720
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4F290 Offset: 0x2E4F391 VA: 0x2E4F290
	|-EqualityComparer<FesNpcScoreData>.LastIndexOf
	|
	|-RVA: 0x2E4FDF0 Offset: 0x2E4FEF1 VA: 0x2E4FDF0
	|-EqualityComparer<GimmickLayoutDataTable>.LastIndexOf
	|
	|-RVA: 0x2E509D0 Offset: 0x2E50AD1 VA: 0x2E509D0
	|-EqualityComparer<MineTypeDataTable>.LastIndexOf
	|
	|-RVA: 0x2E51670 Offset: 0x2E51771 VA: 0x2E51670
	|-EqualityComparer<MiningDataTable>.LastIndexOf
	|
	|-RVA: 0x2E52260 Offset: 0x2E52361 VA: 0x2E52260
	|-EqualityComparer<MiningPointSaveData>.LastIndexOf
	|
	|-RVA: 0x2E52F20 Offset: 0x2E53021 VA: 0x2E52F20
	|-EqualityComparer<MonsterDataTable>.LastIndexOf
	|
	|-RVA: 0x2E53BC0 Offset: 0x2E53CC1 VA: 0x2E53BC0
	|-EqualityComparer<MonsterFootStepEventDataTable>.LastIndexOf
	|
	|-RVA: 0x2E54880 Offset: 0x2E54981 VA: 0x2E54880
	|-EqualityComparer<MonsterHutSaveData>.LastIndexOf
	|
	|-RVA: 0x2E554E0 Offset: 0x2E555E1 VA: 0x2E554E0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.LastIndexOf
	|
	|-RVA: 0x2E560E0 Offset: 0x2E561E1 VA: 0x2E560E0
	|-EqualityComparer<NPCActionData>.LastIndexOf
	|
	|-RVA: 0x2E56DD0 Offset: 0x2E56ED1 VA: 0x2E56DD0
	|-EqualityComparer<NpcPlaceSchedule>.LastIndexOf
	|
	|-RVA: 0x2E579E0 Offset: 0x2E57AE1 VA: 0x2E579E0
	|-EqualityComparer<OrderLotterySaveParameter>.LastIndexOf
	|
	|-RVA: 0x31FEB00 Offset: 0x31FEC01 VA: 0x31FEB00
	|-EqualityComparer<OrderSaveData>.LastIndexOf
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-EqualityComparer<OrderSaveParameter>.LastIndexOf
	|
	|-RVA: 0x32003B0 Offset: 0x32004B1 VA: 0x32003B0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3200F70 Offset: 0x3201071 VA: 0x3200F70
	|-EqualityComparer<Parameter>.LastIndexOf
	|
	|-RVA: 0x3201BA0 Offset: 0x3201CA1 VA: 0x3201BA0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.LastIndexOf
	|
	|-RVA: 0x3202710 Offset: 0x3202811 VA: 0x3202710
	|-EqualityComparer<ShopCatalogPage>.LastIndexOf
	|
	|-RVA: 0x32032F0 Offset: 0x32033F1 VA: 0x32032F0
	|-EqualityComparer<ShopNpcTalk>.LastIndexOf
	|
	|-RVA: 0x3203F50 Offset: 0x3204051 VA: 0x3203F50
	|-EqualityComparer<SubtitleDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x3204AC0 Offset: 0x3204BC1 VA: 0x3204AC0
	|-EqualityComparer<SubtitleDataTable.DataList>.LastIndexOf
	|
	|-RVA: 0x3205620 Offset: 0x3205721 VA: 0x3205620
	|-EqualityComparer<SubtitleHudDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x32061C0 Offset: 0x32062C1 VA: 0x32061C0
	|-EqualityComparer<ProfilerFrame>.LastIndexOf
	|
	|-RVA: 0x3206D70 Offset: 0x3206E71 VA: 0x3206D70
	|-EqualityComparer<NumberControl.ValueRange>.LastIndexOf
	|
	|-RVA: 0x3207930 Offset: 0x3207A31 VA: 0x3207930
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.LastIndexOf
	|
	|-RVA: 0x3208580 Offset: 0x3208681 VA: 0x3208580
	|-EqualityComparer<Schedule>.LastIndexOf
	|
	|-RVA: 0x3209180 Offset: 0x3209281 VA: 0x3209180
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3209D00 Offset: 0x3209E01 VA: 0x3209D00
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x320A930 Offset: 0x320AA31 VA: 0x320A930
	|-EqualityComparer<CurveSample>.LastIndexOf
	|
	|-RVA: 0x320B610 Offset: 0x320B711 VA: 0x320B610
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x320C160 Offset: 0x320C261 VA: 0x320C160
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x320CCA0 Offset: 0x320CDA1 VA: 0x320CCA0
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x320D7F0 Offset: 0x320D8F1 VA: 0x320D7F0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x320E350 Offset: 0x320E451 VA: 0x320E350
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x320FA00 Offset: 0x320FB01 VA: 0x320FA00
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3210550 Offset: 0x3210651 VA: 0x3210550
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x32110B0 Offset: 0x32111B1 VA: 0x32110B0
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3211C00 Offset: 0x3211D01 VA: 0x3211C00
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3212760 Offset: 0x3212861 VA: 0x3212760
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x32132C0 Offset: 0x32133C1 VA: 0x32132C0
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3213E20 Offset: 0x3213F21 VA: 0x3213E20
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3214960 Offset: 0x3214A61 VA: 0x3214960
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3215FE0 Offset: 0x32160E1 VA: 0x3215FE0
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3216B30 Offset: 0x3216C31 VA: 0x3216B30
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x32176A0 Offset: 0x32177A1 VA: 0x32176A0
	|-EqualityComparer<Memory<object>>.LastIndexOf
	|
	|-RVA: 0x3218280 Offset: 0x3218381 VA: 0x3218280
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.LastIndexOf
	|
	|-RVA: 0x3218EF0 Offset: 0x3218FF1 VA: 0x3218EF0
	|-EqualityComparer<Nullable<Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x3219AC0 Offset: 0x3219BC1 VA: 0x3219AC0
	|-EqualityComparer<Nullable<Bounds>>.LastIndexOf
	|
	|-RVA: 0x321A7B0 Offset: 0x321A8B1 VA: 0x321A7B0
	|-EqualityComparer<Nullable<BoundsInt>>.LastIndexOf
	|
	|-RVA: 0x321B420 Offset: 0x321B521 VA: 0x321B420
	|-EqualityComparer<Nullable<Color32>>.LastIndexOf
	|
	|-RVA: 0x32C9C90 Offset: 0x32C9D91 VA: 0x32C9C90
	|-EqualityComparer<Nullable<Color>>.LastIndexOf
	|
	|-RVA: 0x32CA8D0 Offset: 0x32CA9D1 VA: 0x32CA8D0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.LastIndexOf
	|
	|-RVA: 0x32CB4B0 Offset: 0x32CB5B1 VA: 0x32CB4B0
	|-EqualityComparer<Nullable<GradientColorKey>>.LastIndexOf
	|
	|-RVA: 0x32CC130 Offset: 0x32CC231 VA: 0x32CC130
	|-EqualityComparer<Nullable<Keyframe>>.LastIndexOf
	|
	|-RVA: 0x32CCD50 Offset: 0x32CCE51 VA: 0x32CCD50
	|-EqualityComparer<Nullable<LayerMask>>.LastIndexOf
	|
	|-RVA: 0x32CD970 Offset: 0x32CDA71 VA: 0x32CD970
	|-EqualityComparer<Nullable<Matrix4x4>>.LastIndexOf
	|
	|-RVA: 0x32CE700 Offset: 0x32CE801 VA: 0x32CE700
	|-EqualityComparer<Nullable<Quaternion>>.LastIndexOf
	|
	|-RVA: 0x32CF340 Offset: 0x32CF441 VA: 0x32CF340
	|-EqualityComparer<Nullable<RangeInt>>.LastIndexOf
	|
	|-RVA: 0x32CFF20 Offset: 0x32D0021 VA: 0x32CFF20
	|-EqualityComparer<Nullable<Rect>>.LastIndexOf
	|
	|-RVA: 0x32D0BA0 Offset: 0x32D0CA1 VA: 0x32D0BA0
	|-EqualityComparer<Nullable<RectInt>>.LastIndexOf
	|
	|-RVA: 0x32D17E0 Offset: 0x32D18E1 VA: 0x32D17E0
	|-EqualityComparer<Nullable<Vector2>>.LastIndexOf
	|
	|-RVA: 0x32D2380 Offset: 0x32D2481 VA: 0x32D2380
	|-EqualityComparer<Nullable<Vector2Int>>.LastIndexOf
	|
	|-RVA: 0x32D2F10 Offset: 0x32D3011 VA: 0x32D2F10
	|-EqualityComparer<Nullable<Vector3>>.LastIndexOf
	|
	|-RVA: 0x32D3A80 Offset: 0x32D3B81 VA: 0x32D3A80
	|-EqualityComparer<Nullable<Vector3Int>>.LastIndexOf
	|
	|-RVA: 0x32D4640 Offset: 0x32D4741 VA: 0x32D4640
	|-EqualityComparer<Nullable<Vector4>>.LastIndexOf
	|
	|-RVA: 0x32D5260 Offset: 0x32D5361 VA: 0x32D5260
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x32D5D90 Offset: 0x32D5E91 VA: 0x32D5D90
	|-EqualityComparer<ReadOnlyMemory<object>>.LastIndexOf
	|
	|-RVA: 0x32D68F0 Offset: 0x32D69F1 VA: 0x32D68F0
	|-EqualityComparer<Label>.LastIndexOf
	|
	|-RVA: 0x32D7440 Offset: 0x32D7541 VA: 0x32D7440
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x32D7FA0 Offset: 0x32D80A1 VA: 0x32D7FA0
	|-EqualityComparer<RuntimeTypeHandle>.LastIndexOf
	|
	|-RVA: 0x32D8AE0 Offset: 0x32D8BE1 VA: 0x32D8AE0
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x32D9620 Offset: 0x32D9721 VA: 0x32D9620
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x32DACB0 Offset: 0x32DADB1 VA: 0x32DACB0
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x32DC330 Offset: 0x32DC431 VA: 0x32DC330
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DCE70 Offset: 0x32DCF71 VA: 0x32DCE70
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x32DD9C0 Offset: 0x32DDAC1 VA: 0x32DD9C0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x32DE530 Offset: 0x32DE631 VA: 0x32DE530
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DF0A0 Offset: 0x32DF1A1 VA: 0x32DF0A0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x32DFC10 Offset: 0x32DFD11 VA: 0x32DFC10
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x32E0780 Offset: 0x32E0881 VA: 0x32E0780
	|-EqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x32E1300 Offset: 0x32E1401 VA: 0x32E1300
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32E1F10 Offset: 0x32E2011 VA: 0x32E1F10
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x32E2C40 Offset: 0x32E2D41 VA: 0x32E2C40
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-EqualityComparer<TransitionTables>.LastIndexOf
	|
	|-RVA: 0x32E4540 Offset: 0x32E4641 VA: 0x32E4540
	|-EqualityComparer<TutorialUnlockFlagData>.LastIndexOf
	|
	|-RVA: 0x32E50C0 Offset: 0x32E51C1 VA: 0x32E50C0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.LastIndexOf
	|
	|-RVA: 0x32E5CB0 Offset: 0x32E5DB1 VA: 0x32E5CB0
	|-EqualityComparer<CapEdge>.LastIndexOf
	|
	|-RVA: 0x30F1D20 Offset: 0x30F1E21 VA: 0x30F1D20
	|-EqualityComparer<ClippedEdge>.LastIndexOf
	|
	|-RVA: 0x30F2910 Offset: 0x30F2A11 VA: 0x30F2910
	|-EqualityComparer<EdgeKeyByHash>.LastIndexOf
	|
	|-RVA: 0x30F3450 Offset: 0x30F3551 VA: 0x30F3450
	|-EqualityComparer<EdgeKeyByIndex>.LastIndexOf
	|
	|-RVA: 0x30F3F90 Offset: 0x30F4091 VA: 0x30F3F90
	|-EqualityComparer<MeshDataConnectivity.Face>.LastIndexOf
	|
	|-RVA: 0x30F4B30 Offset: 0x30F4C31 VA: 0x30F4B30
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.LastIndexOf
	|
	|-RVA: 0x30F57A0 Offset: 0x30F58A1 VA: 0x30F57A0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.LastIndexOf
	|
	|-RVA: 0x30F63F0 Offset: 0x30F64F1 VA: 0x30F63F0
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|
	|-RVA: 0x30F7050 Offset: 0x30F7151 VA: 0x30F7050
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|
	|-RVA: 0x30F7DE0 Offset: 0x30F7EE1 VA: 0x30F7DE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x30F8940 Offset: 0x30F8A41 VA: 0x30F8940
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x30F9490 Offset: 0x30F9591 VA: 0x30F9490
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x30FA050 Offset: 0x30FA151 VA: 0x30FA050
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x30FACA0 Offset: 0x30FADA1 VA: 0x30FACA0
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x30FB8F0 Offset: 0x30FB9F1 VA: 0x30FB8F0
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x30FC4E0 Offset: 0x30FC5E1 VA: 0x30FC4E0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x30FD050 Offset: 0x30FD151 VA: 0x30FD050
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x30FDCF0 Offset: 0x30FDDF1 VA: 0x30FDCF0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x30FEB30 Offset: 0x30FEC31 VA: 0x30FEB30
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x30FF810 Offset: 0x30FF911 VA: 0x30FF810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	|
	|-RVA: 0x3100360 Offset: 0x3100461 VA: 0x3100360
	|-EqualityComparer<GradientAlphaKey>.LastIndexOf
	|
	|-RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	|-EqualityComparer<GradientColorKey>.LastIndexOf
	|
	|-RVA: 0x3101B90 Offset: 0x3101C91 VA: 0x3101B90
	|-EqualityComparer<Keyframe>.LastIndexOf
	|
	|-RVA: 0x31027D0 Offset: 0x31028D1 VA: 0x31027D0
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x31033B0 Offset: 0x31034B1 VA: 0x31033B0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x31040A0 Offset: 0x31041A1 VA: 0x31040A0
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3104CD0 Offset: 0x3104DD1 VA: 0x3104CD0
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3105890 Offset: 0x3105991 VA: 0x3105890
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3106490 Offset: 0x3106591 VA: 0x3106490
	|-EqualityComparer<PlayableGraph>.LastIndexOf
	|
	|-RVA: 0x3106FF0 Offset: 0x31070F1 VA: 0x3106FF0
	|-EqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x3107B60 Offset: 0x3107C61 VA: 0x3107B60
	|-EqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x3108730 Offset: 0x3108831 VA: 0x3108730
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x31092D0 Offset: 0x31093D1 VA: 0x31092D0
	|-EqualityComparer<RangeInt>.LastIndexOf
	|
	|-RVA: 0x3109EA0 Offset: 0x3109FA1 VA: 0x3109EA0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x310ABA0 Offset: 0x310ACA1 VA: 0x310ABA0
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x310B860 Offset: 0x310B961 VA: 0x310B860
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x310C410 Offset: 0x310C511 VA: 0x310C410
	|-EqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x310CF80 Offset: 0x310D081 VA: 0x310CF80
	|-EqualityComparer<ReflectionProbeBlendInfo>.LastIndexOf
	|
	|-RVA: 0x310DC00 Offset: 0x310DD01 VA: 0x310DC00
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x310E9F0 Offset: 0x310EAF1 VA: 0x310E9F0
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x310F5B0 Offset: 0x310F6B1 VA: 0x310F5B0
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x2EA7910 Offset: 0x2EA7A11 VA: 0x2EA7910
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EA8560 Offset: 0x2EA8661 VA: 0x2EA8560
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EA91D0 Offset: 0x2EA92D1 VA: 0x2EA91D0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x2EA9E20 Offset: 0x2EA9F21 VA: 0x2EA9E20
	|-EqualityComparer<SceneInstance>.LastIndexOf
	|
	|-RVA: 0x2EAA9E0 Offset: 0x2EAAAE1 VA: 0x2EAA9E0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x2EAB650 Offset: 0x2EAB751 VA: 0x2EAB650
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x2EAC2A0 Offset: 0x2EAC3A1 VA: 0x2EAC2A0
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EACE80 Offset: 0x2EACF81 VA: 0x2EACE80
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x2EADB30 Offset: 0x2EADC31 VA: 0x2EADB30
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x2EAE780 Offset: 0x2EAE881 VA: 0x2EAE780
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2EAF3D0 Offset: 0x2EAF4D1 VA: 0x2EAF3D0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EB0E50 Offset: 0x2EB0F51 VA: 0x2EB0E50
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EB1B00 Offset: 0x2EB1C01 VA: 0x2EB1B00
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EB2720 Offset: 0x2EB2821 VA: 0x2EB2720
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x2EB32D0 Offset: 0x2EB33D1 VA: 0x2EB32D0
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|
	|-RVA: 0x2EB49A0 Offset: 0x2EB4AA1 VA: 0x2EB49A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|
	|-RVA: 0x2EB54F0 Offset: 0x2EB55F1 VA: 0x2EB54F0
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x2EB6130 Offset: 0x2EB6231 VA: 0x2EB6130
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x2EB6EC0 Offset: 0x2EB6FC1 VA: 0x2EB6EC0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x2EB7AC0 Offset: 0x2EB7BC1 VA: 0x2EB7AC0
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EB8620 Offset: 0x2EB8721 VA: 0x2EB8620
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EB9190 Offset: 0x2EB9291 VA: 0x2EB9190
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EB9D50 Offset: 0x2EB9E51 VA: 0x2EB9D50
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EBA8F0 Offset: 0x2EBA9F1 VA: 0x2EBA8F0
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2EBB5B0 Offset: 0x2EBB6B1 VA: 0x2EBB5B0
	|-EqualityComparer<WarpPoints.WarpPoint>.LastIndexOf
	|
	|-RVA: 0x2EBC380 Offset: 0x2EBC481 VA: 0x2EBC380
	|-EqualityComparer<YieldItemParam>.LastIndexOf
	|
	|-RVA: 0x2EBCF20 Offset: 0x2EBD021 VA: 0x2EBCF20
	|-EqualityComparer<stCommand_t>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EB40 Offset: 0x2E3EC41 VA: 0x2E3EB40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E3F700 Offset: 0x2E3F801 VA: 0x2E3F700
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40250 Offset: 0x2E40351 VA: 0x2E40250
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40FC0 Offset: 0x2E410C1 VA: 0x2E40FC0
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E41CA0 Offset: 0x2E41DA1 VA: 0x2E41CA0
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E42810 Offset: 0x2E42911 VA: 0x2E42810
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E43F10 Offset: 0x2E44011 VA: 0x2E43F10
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E44A60 Offset: 0x2E44B61 VA: 0x2E44A60
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E455A0 Offset: 0x2E456A1 VA: 0x2E455A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E461D0 Offset: 0x2E462D1 VA: 0x2E461D0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E46EB0 Offset: 0x2E46FB1 VA: 0x2E46EB0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E47B50 Offset: 0x2E47C51 VA: 0x2E47B50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E486F0 Offset: 0x2E487F1 VA: 0x2E486F0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E492E0 Offset: 0x2E493E1 VA: 0x2E492E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E49F30 Offset: 0x2E4A031 VA: 0x2E49F30
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4AB80 Offset: 0x2E4AC81 VA: 0x2E4AB80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4B740 Offset: 0x2E4B841 VA: 0x2E4B740
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4C3E0 Offset: 0x2E4C4E1 VA: 0x2E4C3E0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4D0A0 Offset: 0x2E4D1A1 VA: 0x2E4D0A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4DC80 Offset: 0x2E4DD81 VA: 0x2E4DC80
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4E7F0 Offset: 0x2E4E8F1 VA: 0x2E4E7F0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4FEB0 Offset: 0x2E4FFB1 VA: 0x2E4FEB0
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E50B20 Offset: 0x2E50C21 VA: 0x2E50B20
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E51740 Offset: 0x2E51841 VA: 0x2E51740
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E523A0 Offset: 0x2E524A1 VA: 0x2E523A0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53040 Offset: 0x2E53141 VA: 0x2E53040
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53CF0 Offset: 0x2E53DF1 VA: 0x2E53CF0
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E549B0 Offset: 0x2E54AB1 VA: 0x2E549B0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E555B0 Offset: 0x2E556B1 VA: 0x2E555B0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56230 Offset: 0x2E56331 VA: 0x2E56230
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56EE0 Offset: 0x2E56FE1 VA: 0x2E56EE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E57AC0 Offset: 0x2E57BC1 VA: 0x2E57AC0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FEC30 Offset: 0x31FED31 VA: 0x31FEC30
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FF8C0 Offset: 0x31FF9C1 VA: 0x31FF8C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3200480 Offset: 0x3200581 VA: 0x3200480
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201090 Offset: 0x3201191 VA: 0x3201090
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201C70 Offset: 0x3201D71 VA: 0x3201C70
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32027E0 Offset: 0x32028E1 VA: 0x32027E0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3203420 Offset: 0x3203521 VA: 0x3203420
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204030 Offset: 0x3204131 VA: 0x3204030
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204B80 Offset: 0x3204C81 VA: 0x3204B80
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3205700 Offset: 0x3205801 VA: 0x3205700
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32062B0 Offset: 0x32063B1 VA: 0x32062B0
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3207A40 Offset: 0x3207B41 VA: 0x3207A40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3208690 Offset: 0x3208791 VA: 0x3208690
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209DE0 Offset: 0x3209EE1 VA: 0x3209DE0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320AAA0 Offset: 0x320ABA1 VA: 0x320AAA0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320B6D0 Offset: 0x320B7D1 VA: 0x320B6D0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320C220 Offset: 0x320C321 VA: 0x320C220
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320CD60 Offset: 0x320CE61 VA: 0x320CD60
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320E410 Offset: 0x320E511 VA: 0x320E410
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320EF70 Offset: 0x320F071 VA: 0x320EF70
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320FAC0 Offset: 0x320FBC1 VA: 0x320FAC0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3210620 Offset: 0x3210721 VA: 0x3210620
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211170 Offset: 0x3211271 VA: 0x3211170
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211CD0 Offset: 0x3211DD1 VA: 0x3211CD0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3212820 Offset: 0x3212921 VA: 0x3212820
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213390 Offset: 0x3213491 VA: 0x3213390
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213EE0 Offset: 0x3213FE1 VA: 0x3213EE0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3214A20 Offset: 0x3214B21 VA: 0x3214A20
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3215560 Offset: 0x3215661 VA: 0x3215560
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32160A0 Offset: 0x32161A1 VA: 0x32160A0
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3216C00 Offset: 0x3216D01 VA: 0x3216C00
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3217770 Offset: 0x3217871 VA: 0x3217770
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32183B0 Offset: 0x32184B1 VA: 0x32183B0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3218FB0 Offset: 0x32190B1 VA: 0x3218FB0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3219BF0 Offset: 0x3219CF1 VA: 0x3219BF0
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321A8E0 Offset: 0x321A9E1 VA: 0x321A8E0
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321B4E0 Offset: 0x321B5E1 VA: 0x321B4E0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32C9DA0 Offset: 0x32C9EA1 VA: 0x32C9DA0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CA9B0 Offset: 0x32CAAB1 VA: 0x32CA9B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CB5C0 Offset: 0x32CB6C1 VA: 0x32CB5C0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CCE10 Offset: 0x32CCF11 VA: 0x32CCE10
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CDAF0 Offset: 0x32CDBF1 VA: 0x32CDAF0
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CE810 Offset: 0x32CE911 VA: 0x32CE810
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CF420 Offset: 0x32CF521 VA: 0x32CF420
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0030 Offset: 0x32D0131 VA: 0x32D0030
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0CB0 Offset: 0x32D0DB1 VA: 0x32D0CB0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D18C0 Offset: 0x32D19C1 VA: 0x32D18C0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2460 Offset: 0x32D2561 VA: 0x32D2460
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2FE0 Offset: 0x32D30E1 VA: 0x32D2FE0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D3B50 Offset: 0x32D3C51 VA: 0x32D3B50
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D4750 Offset: 0x32D4851 VA: 0x32D4750
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5320 Offset: 0x32D5421 VA: 0x32D5320
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5E60 Offset: 0x32D5F61 VA: 0x32D5E60
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D69B0 Offset: 0x32D6AB1 VA: 0x32D69B0
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D7510 Offset: 0x32D7611 VA: 0x32D7510
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8060 Offset: 0x32D8161 VA: 0x32D8060
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8BA0 Offset: 0x32D8CA1 VA: 0x32D8BA0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D96E0 Offset: 0x32D97E1 VA: 0x32D96E0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DA230 Offset: 0x32DA331 VA: 0x32DA230
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DAD70 Offset: 0x32DAE71 VA: 0x32DAD70
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DB8B0 Offset: 0x32DB9B1 VA: 0x32DB8B0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DC3F0 Offset: 0x32DC4F1 VA: 0x32DC3F0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DCF30 Offset: 0x32DD031 VA: 0x32DCF30
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DDA90 Offset: 0x32DDB91 VA: 0x32DDA90
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DF170 Offset: 0x32DF271 VA: 0x32DF170
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DFCE0 Offset: 0x32DFDE1 VA: 0x32DFCE0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E0850 Offset: 0x32E0951 VA: 0x32E0850
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E13E0 Offset: 0x32E14E1 VA: 0x32E13E0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2060 Offset: 0x32E2161 VA: 0x32E2060
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2D90 Offset: 0x32E2E91 VA: 0x32E2D90
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E3A40 Offset: 0x32E3B41 VA: 0x32E3A40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E4620 Offset: 0x32E4721 VA: 0x32E4620
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5190 Offset: 0x32E5291 VA: 0x32E5190
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5DF0 Offset: 0x32E5EF1 VA: 0x32E5DF0
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F1E30 Offset: 0x30F1F31 VA: 0x30F1E30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F29D0 Offset: 0x30F2AD1 VA: 0x30F29D0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F3510 Offset: 0x30F3611 VA: 0x30F3510
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4050 Offset: 0x30F4151 VA: 0x30F4050
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4C40 Offset: 0x30F4D41 VA: 0x30F4C40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F58D0 Offset: 0x30F59D1 VA: 0x30F58D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F64C0 Offset: 0x30F65C1 VA: 0x30F64C0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7200 Offset: 0x30F7301 VA: 0x30F7200
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7EB0 Offset: 0x30F7FB1 VA: 0x30F7EB0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F8A00 Offset: 0x30F8B01 VA: 0x30F8A00
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F9560 Offset: 0x30F9661 VA: 0x30F9560
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FADB0 Offset: 0x30FAEB1 VA: 0x30FADB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FBA00 Offset: 0x30FBB01 VA: 0x30FBA00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FC5A0 Offset: 0x30FC6A1 VA: 0x30FC5A0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FD140 Offset: 0x30FD241 VA: 0x30FD140
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FDEA0 Offset: 0x30FDFA1 VA: 0x30FDEA0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FECA0 Offset: 0x30FEDA1 VA: 0x30FECA0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FF8D0 Offset: 0x30FF9D1 VA: 0x30FF8D0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101030 Offset: 0x3101131 VA: 0x3101030
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101CC0 Offset: 0x3101DC1 VA: 0x3101CC0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3102890 Offset: 0x3102991 VA: 0x3102890
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3103500 Offset: 0x3103601 VA: 0x3103500
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31041C0 Offset: 0x31042C1 VA: 0x31041C0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3104DA0 Offset: 0x3104EA1 VA: 0x3104DA0
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31059A0 Offset: 0x3105AA1 VA: 0x31059A0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3106560 Offset: 0x3106661 VA: 0x3106560
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31070B0 Offset: 0x31071B1 VA: 0x31070B0
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3107C50 Offset: 0x3107D51 VA: 0x3107C50
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3108820 Offset: 0x3108921 VA: 0x3108820
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109390 Offset: 0x3109491 VA: 0x3109390
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109FE0 Offset: 0x310A0E1 VA: 0x3109FE0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310ACF0 Offset: 0x310ADF1 VA: 0x310ACF0
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310B950 Offset: 0x310BA51 VA: 0x310B950
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310C4E0 Offset: 0x310C5E1 VA: 0x310C4E0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310D050 Offset: 0x310D151 VA: 0x310D050
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310DDD0 Offset: 0x310DED1 VA: 0x310DDD0
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310EAC0 Offset: 0x310EBC1 VA: 0x310EAC0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310F6C0 Offset: 0x310F7C1 VA: 0x310F6C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA7A20 Offset: 0x2EA7B21 VA: 0x2EA7A20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA8670 Offset: 0x2EA8771 VA: 0x2EA8670
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9300 Offset: 0x2EA9401 VA: 0x2EA9300
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9EF0 Offset: 0x2EA9FF1 VA: 0x2EA9EF0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAAAF0 Offset: 0x2EAABF1 VA: 0x2EAAAF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAB780 Offset: 0x2EAB881 VA: 0x2EAB780
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAC370 Offset: 0x2EAC471 VA: 0x2EAC370
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EACFB0 Offset: 0x2EAD0B1 VA: 0x2EACFB0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EADC40 Offset: 0x2EADD41 VA: 0x2EADC40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAE890 Offset: 0x2EAE991 VA: 0x2EAE890
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0230 Offset: 0x2EB0331 VA: 0x2EB0230
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0F80 Offset: 0x2EB1081 VA: 0x2EB0F80
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB1C10 Offset: 0x2EB1D11 VA: 0x2EB1C10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB2810 Offset: 0x2EB2911 VA: 0x2EB2810
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB33A0 Offset: 0x2EB34A1 VA: 0x2EB33A0
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB3F10 Offset: 0x2EB4011 VA: 0x2EB3F10
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB4A60 Offset: 0x2EB4B61 VA: 0x2EB4A60
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB55C0 Offset: 0x2EB56C1 VA: 0x2EB55C0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB62C0 Offset: 0x2EB63C1 VA: 0x2EB62C0
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB6FD0 Offset: 0x2EB70D1 VA: 0x2EB6FD0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB7B90 Offset: 0x2EB7C91 VA: 0x2EB7B90
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9280 Offset: 0x2EB9381 VA: 0x2EB9280
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9E30 Offset: 0x2EB9F31 VA: 0x2EB9E30
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBA9E0 Offset: 0x2EBAAE1 VA: 0x2EBA9E0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBB780 Offset: 0x2EBB881 VA: 0x2EBB780
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBC440 Offset: 0x2EBC541 VA: 0x2EBC440
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBD030 Offset: 0x2EBD131 VA: 0x2EBD030
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EC40 Offset: 0x2E3ED41 VA: 0x2E3EC40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E3F7E0 Offset: 0x2E3F8E1 VA: 0x2E3F7E0
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E40330 Offset: 0x2E40431 VA: 0x2E40330
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41120 Offset: 0x2E41221 VA: 0x2E41120
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E428F0 Offset: 0x2E429F1 VA: 0x2E428F0
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43480 Offset: 0x2E43581 VA: 0x2E43480
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43FF0 Offset: 0x2E440F1 VA: 0x2E43FF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E462E0 Offset: 0x2E463E1 VA: 0x2E462E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E46FC0 Offset: 0x2E470C1 VA: 0x2E46FC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E47C50 Offset: 0x2E47D51 VA: 0x2E47C50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E487D0 Offset: 0x2E488D1 VA: 0x2E487D0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E493E0 Offset: 0x2E494E1 VA: 0x2E493E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4A030 Offset: 0x2E4A131 VA: 0x2E4A030
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4AC80 Offset: 0x2E4AD81 VA: 0x2E4AC80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4B820 Offset: 0x2E4B921 VA: 0x2E4B820
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4C500 Offset: 0x2E4C601 VA: 0x2E4C500
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4D1A0 Offset: 0x2E4D2A1 VA: 0x2E4D1A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4DD60 Offset: 0x2E4DE61 VA: 0x2E4DD60
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4E8D0 Offset: 0x2E4E9D1 VA: 0x2E4E8D0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4F440 Offset: 0x2E4F541 VA: 0x2E4F440
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4FF90 Offset: 0x2E50091 VA: 0x2E4FF90
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E50C40 Offset: 0x2E50D41 VA: 0x2E50C40
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E524B0 Offset: 0x2E525B1 VA: 0x2E524B0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53150 Offset: 0x2E53251 VA: 0x2E53150
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53E00 Offset: 0x2E53F01 VA: 0x2E53E00
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E54AC0 Offset: 0x2E54BC1 VA: 0x2E54AC0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E55690 Offset: 0x2E55791 VA: 0x2E55690
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56350 Offset: 0x2E56451 VA: 0x2E56350
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56FE0 Offset: 0x2E570E1 VA: 0x2E56FE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E57BA0 Offset: 0x2E57CA1 VA: 0x2E57BA0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3200560 Offset: 0x3200661 VA: 0x3200560
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32011A0 Offset: 0x32012A1 VA: 0x32011A0
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3201D50 Offset: 0x3201E51 VA: 0x3201D50
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32028C0 Offset: 0x32029C1 VA: 0x32028C0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3203530 Offset: 0x3203631 VA: 0x3203530
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204110 Offset: 0x3204211 VA: 0x3204110
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204C60 Offset: 0x3204D61 VA: 0x3204C60
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32057E0 Offset: 0x32058E1 VA: 0x32057E0
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206390 Offset: 0x3206491 VA: 0x3206390
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206F20 Offset: 0x3207021 VA: 0x3206F20
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3207B40 Offset: 0x3207C41 VA: 0x3207B40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3208790 Offset: 0x3208891 VA: 0x3208790
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209330 Offset: 0x3209431 VA: 0x3209330
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320ABD0 Offset: 0x320ACD1 VA: 0x320ABD0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320B7B0 Offset: 0x320B8B1 VA: 0x320B7B0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320CE40 Offset: 0x320CF41 VA: 0x320CE40
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320D9A0 Offset: 0x320DAA1 VA: 0x320D9A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320E4F0 Offset: 0x320E5F1 VA: 0x320E4F0
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320F050 Offset: 0x320F151 VA: 0x320F050
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320FBA0 Offset: 0x320FCA1 VA: 0x320FBA0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3210700 Offset: 0x3210801 VA: 0x3210700
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211250 Offset: 0x3211351 VA: 0x3211250
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211DB0 Offset: 0x3211EB1 VA: 0x3211DB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3212900 Offset: 0x3212A01 VA: 0x3212900
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213470 Offset: 0x3213571 VA: 0x3213470
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213FC0 Offset: 0x32140C1 VA: 0x3213FC0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3214B00 Offset: 0x3214C01 VA: 0x3214B00
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3215640 Offset: 0x3215741 VA: 0x3215640
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216180 Offset: 0x3216281 VA: 0x3216180
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216CE0 Offset: 0x3216DE1 VA: 0x3216CE0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3217850 Offset: 0x3217951 VA: 0x3217850
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32184E0 Offset: 0x32185E1 VA: 0x32184E0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32190A0 Offset: 0x32191A1 VA: 0x32190A0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3219D20 Offset: 0x3219E21 VA: 0x3219D20
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321AA10 Offset: 0x321AB11 VA: 0x321AA10
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321B5D0 Offset: 0x321B6D1 VA: 0x321B5D0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32C9EC0 Offset: 0x32C9FC1 VA: 0x32C9EC0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CB6E0 Offset: 0x32CB7E1 VA: 0x32CB6E0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CC360 Offset: 0x32CC461 VA: 0x32CC360
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CDC40 Offset: 0x32CDD41 VA: 0x32CDC40
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CE930 Offset: 0x32CEA31 VA: 0x32CE930
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CF510 Offset: 0x32CF611 VA: 0x32CF510
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0150 Offset: 0x32D0251 VA: 0x32D0150
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0DD0 Offset: 0x32D0ED1 VA: 0x32D0DD0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D19B0 Offset: 0x32D1AB1 VA: 0x32D19B0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D2550 Offset: 0x32D2651 VA: 0x32D2550
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D30D0 Offset: 0x32D31D1 VA: 0x32D30D0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D3C40 Offset: 0x32D3D41 VA: 0x32D3C40
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D4870 Offset: 0x32D4971 VA: 0x32D4870
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D53F0 Offset: 0x32D54F1 VA: 0x32D53F0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D5F40 Offset: 0x32D6041 VA: 0x32D5F40
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D6A90 Offset: 0x32D6B91 VA: 0x32D6A90
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D75F0 Offset: 0x32D76F1 VA: 0x32D75F0
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8C80 Offset: 0x32D8D81 VA: 0x32D8C80
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DA310 Offset: 0x32DA411 VA: 0x32DA310
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DAE50 Offset: 0x32DAF51 VA: 0x32DAE50
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DB990 Offset: 0x32DBA91 VA: 0x32DB990
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DC4D0 Offset: 0x32DC5D1 VA: 0x32DC4D0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DD010 Offset: 0x32DD111 VA: 0x32DD010
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DDB70 Offset: 0x32DDC71 VA: 0x32DDB70
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DF250 Offset: 0x32DF351 VA: 0x32DF250
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DFDC0 Offset: 0x32DFEC1 VA: 0x32DFDC0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E0930 Offset: 0x32E0A31 VA: 0x32E0930
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E14C0 Offset: 0x32E15C1 VA: 0x32E14C0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2180 Offset: 0x32E2281 VA: 0x32E2180
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2EB0 Offset: 0x32E2FB1 VA: 0x32E2EB0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E3B40 Offset: 0x32E3C41 VA: 0x32E3B40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E4700 Offset: 0x32E4801 VA: 0x32E4700
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5270 Offset: 0x32E5371 VA: 0x32E5270
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5F00 Offset: 0x32E6001 VA: 0x32E5F00
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F1F30 Offset: 0x30F2031 VA: 0x30F1F30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F2AB0 Offset: 0x30F2BB1 VA: 0x30F2AB0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F35F0 Offset: 0x30F36F1 VA: 0x30F35F0
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4130 Offset: 0x30F4231 VA: 0x30F4130
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4D40 Offset: 0x30F4E41 VA: 0x30F4D40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F59E0 Offset: 0x30F5AE1 VA: 0x30F59E0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7350 Offset: 0x30F7451 VA: 0x30F7350
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7F90 Offset: 0x30F8091 VA: 0x30F7F90
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F8AE0 Offset: 0x30F8BE1 VA: 0x30F8AE0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F9640 Offset: 0x30F9741 VA: 0x30F9640
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FA260 Offset: 0x30FA361 VA: 0x30FA260
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FAEB0 Offset: 0x30FAFB1 VA: 0x30FAEB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FBB00 Offset: 0x30FBC01 VA: 0x30FBB00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FC680 Offset: 0x30FC781 VA: 0x30FC680
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FD220 Offset: 0x30FD321 VA: 0x30FD220
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FDFF0 Offset: 0x30FE0F1 VA: 0x30FDFF0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FEDD0 Offset: 0x30FEED1 VA: 0x30FEDD0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FF9B0 Offset: 0x30FFAB1 VA: 0x30FF9B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3100510 Offset: 0x3100611 VA: 0x3100510
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101130 Offset: 0x3101231 VA: 0x3101130
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101DD0 Offset: 0x3101ED1 VA: 0x3101DD0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3102970 Offset: 0x3102A71 VA: 0x3102970
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3103620 Offset: 0x3103721 VA: 0x3103620
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31042D0 Offset: 0x31043D1 VA: 0x31042D0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3104E80 Offset: 0x3104F81 VA: 0x3104E80
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3105AA0 Offset: 0x3105BA1 VA: 0x3105AA0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3106640 Offset: 0x3106741 VA: 0x3106640
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107190 Offset: 0x3107291 VA: 0x3107190
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107D30 Offset: 0x3107E31 VA: 0x3107D30
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3108900 Offset: 0x3108A01 VA: 0x3108900
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3109470 Offset: 0x3109571 VA: 0x3109470
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310A0F0 Offset: 0x310A1F1 VA: 0x310A0F0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310AE10 Offset: 0x310AF11 VA: 0x310AE10
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310BA30 Offset: 0x310BB31 VA: 0x310BA30
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310C5C0 Offset: 0x310C6C1 VA: 0x310C5C0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310D130 Offset: 0x310D231 VA: 0x310D130
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310DF40 Offset: 0x310E041 VA: 0x310DF40
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310EBA0 Offset: 0x310ECA1 VA: 0x310EBA0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310F7C0 Offset: 0x310F8C1 VA: 0x310F7C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA7B20 Offset: 0x2EA7C21 VA: 0x2EA7B20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA8770 Offset: 0x2EA8871 VA: 0x2EA8770
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9410 Offset: 0x2EA9511 VA: 0x2EA9410
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9FD0 Offset: 0x2EAA0D1 VA: 0x2EA9FD0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAABF0 Offset: 0x2EAACF1 VA: 0x2EAABF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAB890 Offset: 0x2EAB991 VA: 0x2EAB890
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAC450 Offset: 0x2EAC551 VA: 0x2EAC450
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAD0C0 Offset: 0x2EAD1C1 VA: 0x2EAD0C0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAE990 Offset: 0x2EAEA91 VA: 0x2EAE990
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAF5E0 Offset: 0x2EAF6E1 VA: 0x2EAF5E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB0370 Offset: 0x2EB0471 VA: 0x2EB0370
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1090 Offset: 0x2EB1191 VA: 0x2EB1090
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1D10 Offset: 0x2EB1E11 VA: 0x2EB1D10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3480 Offset: 0x2EB3581 VA: 0x2EB3480
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3FF0 Offset: 0x2EB40F1 VA: 0x2EB3FF0
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB4B40 Offset: 0x2EB4C41 VA: 0x2EB4B40
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB56A0 Offset: 0x2EB57A1 VA: 0x2EB56A0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB6400 Offset: 0x2EB6501 VA: 0x2EB6400
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB70D0 Offset: 0x2EB71D1 VA: 0x2EB70D0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB7C70 Offset: 0x2EB7D71 VA: 0x2EB7C70
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB87C0 Offset: 0x2EB88C1 VA: 0x2EB87C0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9360 Offset: 0x2EB9461 VA: 0x2EB9360
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9F10 Offset: 0x2EBA011 VA: 0x2EB9F10
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBAAC0 Offset: 0x2EBABC1 VA: 0x2EBAAC0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBB8E0 Offset: 0x2EBB9E1 VA: 0x2EBB8E0
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBC520 Offset: 0x2EBC621 VA: 0x2EBC520
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EDF0 Offset: 0x2E3EEF1 VA: 0x2E3EDF0
	|-EqualityComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2E3F960 Offset: 0x2E3FA61 VA: 0x2E3F960
	|-EqualityComparer<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x2E404A0 Offset: 0x2E405A1 VA: 0x2E404A0
	|-EqualityComparer<BitVector32Int>..ctor
	|
	|-RVA: 0x2E41390 Offset: 0x2E41491 VA: 0x2E41390
	|-EqualityComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-EqualityComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2E42A70 Offset: 0x2E42B71 VA: 0x2E42A70
	|-EqualityComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2E43600 Offset: 0x2E43701 VA: 0x2E43600
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2E44170 Offset: 0x2E44271 VA: 0x2E44170
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E44CB0 Offset: 0x2E44DB1 VA: 0x2E44CB0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E457F0 Offset: 0x2E458F1 VA: 0x2E457F0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2E471A0 Offset: 0x2E472A1 VA: 0x2E471A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2E47E00 Offset: 0x2E47F01 VA: 0x2E47E00
	|-EqualityComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2E48940 Offset: 0x2E48A41 VA: 0x2E48940
	|-EqualityComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2E49590 Offset: 0x2E49691 VA: 0x2E49590
	|-EqualityComparer<EffectDataTable>..ctor
	|
	|-RVA: 0x2E4A1E0 Offset: 0x2E4A2E1 VA: 0x2E4A1E0
	|-EqualityComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2E4AE30 Offset: 0x2E4AF31 VA: 0x2E4AE30
	|-EqualityComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2E4B9A0 Offset: 0x2E4BAA1 VA: 0x2E4B9A0
	|-EqualityComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2E4C700 Offset: 0x2E4C801 VA: 0x2E4C700
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E4D350 Offset: 0x2E4D451 VA: 0x2E4D350
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E4DEE0 Offset: 0x2E4DFE1 VA: 0x2E4DEE0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E4EA50 Offset: 0x2E4EB51 VA: 0x2E4EA50
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E4F5C0 Offset: 0x2E4F6C1 VA: 0x2E4F5C0
	|-EqualityComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2E50100 Offset: 0x2E50201 VA: 0x2E50100
	|-EqualityComparer<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E50E30 Offset: 0x2E50F31 VA: 0x2E50E30
	|-EqualityComparer<MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E519A0 Offset: 0x2E51AA1 VA: 0x2E519A0
	|-EqualityComparer<MiningDataTable>..ctor
	|
	|-RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	|-EqualityComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2E53310 Offset: 0x2E53411 VA: 0x2E53310
	|-EqualityComparer<MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53FD0 Offset: 0x2E540D1 VA: 0x2E53FD0
	|-EqualityComparer<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54CA0 Offset: 0x2E54DA1 VA: 0x2E54CA0
	|-EqualityComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E55810 Offset: 0x2E55911 VA: 0x2E55810
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	|-EqualityComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2E57190 Offset: 0x2E57291 VA: 0x2E57190
	|-EqualityComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2E57D20 Offset: 0x2E57E21 VA: 0x2E57D20
	|-EqualityComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31FEF20 Offset: 0x31FF021 VA: 0x31FEF20
	|-EqualityComparer<OrderSaveData>..ctor
	|
	|-RVA: 0x31FFB70 Offset: 0x31FFC71 VA: 0x31FFB70
	|-EqualityComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32006E0 Offset: 0x32007E1 VA: 0x32006E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3201360 Offset: 0x3201461 VA: 0x3201360
	|-EqualityComparer<Parameter>..ctor
	|
	|-RVA: 0x3201ED0 Offset: 0x3201FD1 VA: 0x3201ED0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x3202A40 Offset: 0x3202B41 VA: 0x3202A40
	|-EqualityComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x3203700 Offset: 0x3203801 VA: 0x3203700
	|-EqualityComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3204290 Offset: 0x3204391 VA: 0x3204290
	|-EqualityComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3204DD0 Offset: 0x3204ED1 VA: 0x3204DD0
	|-EqualityComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3205960 Offset: 0x3205A61 VA: 0x3205960
	|-EqualityComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3206530 Offset: 0x3206631 VA: 0x3206530
	|-EqualityComparer<ProfilerFrame>..ctor
	|
	|-RVA: 0x32070A0 Offset: 0x32071A1 VA: 0x32070A0
	|-EqualityComparer<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x3207CF0 Offset: 0x3207DF1 VA: 0x3207CF0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x3208940 Offset: 0x3208A41 VA: 0x3208940
	|-EqualityComparer<Schedule>..ctor
	|
	|-RVA: 0x32094B0 Offset: 0x32095B1 VA: 0x32094B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x320A040 Offset: 0x320A141 VA: 0x320A040
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-EqualityComparer<CurveSample>..ctor
	|
	|-RVA: 0x320B930 Offset: 0x320BA31 VA: 0x320B930
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x320C470 Offset: 0x320C571 VA: 0x320C470
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x320CFB0 Offset: 0x320D0B1 VA: 0x320CFB0
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x320DB20 Offset: 0x320DC21 VA: 0x320DB20
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x320E660 Offset: 0x320E761 VA: 0x320E660
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x320F1D0 Offset: 0x320F2D1 VA: 0x320F1D0
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x320FD10 Offset: 0x320FE11 VA: 0x320FD10
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3210880 Offset: 0x3210981 VA: 0x3210880
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32113C0 Offset: 0x32114C1 VA: 0x32113C0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3211F30 Offset: 0x3212031 VA: 0x3211F30
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3212A80 Offset: 0x3212B81 VA: 0x3212A80
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x32135F0 Offset: 0x32136F1 VA: 0x32135F0
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3214130 Offset: 0x3214231 VA: 0x3214130
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3214C70 Offset: 0x3214D71 VA: 0x3214C70
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x32157B0 Offset: 0x32158B1 VA: 0x32157B0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x32162F0 Offset: 0x32163F1 VA: 0x32162F0
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3216E60 Offset: 0x3216F61 VA: 0x3216E60
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x32179D0 Offset: 0x3217AD1 VA: 0x32179D0
	|-EqualityComparer<Memory<object>>..ctor
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3219210 Offset: 0x3219311 VA: 0x3219210
	|-EqualityComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3219F00 Offset: 0x321A001 VA: 0x3219F00
	|-EqualityComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x321ABF0 Offset: 0x321ACF1 VA: 0x321ABF0
	|-EqualityComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x321B740 Offset: 0x321B841 VA: 0x321B740
	|-EqualityComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x32CA080 Offset: 0x32CA181 VA: 0x32CA080
	|-EqualityComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x32CAC20 Offset: 0x32CAD21 VA: 0x32CAC20
	|-EqualityComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x32CB8A0 Offset: 0x32CB9A1 VA: 0x32CB8A0
	|-EqualityComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x32CC520 Offset: 0x32CC621 VA: 0x32CC520
	|-EqualityComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x32CD070 Offset: 0x32CD171 VA: 0x32CD070
	|-EqualityComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x32CDE70 Offset: 0x32CDF71 VA: 0x32CDE70
	|-EqualityComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x32CEAF0 Offset: 0x32CEBF1 VA: 0x32CEAF0
	|-EqualityComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x32CF690 Offset: 0x32CF791 VA: 0x32CF690
	|-EqualityComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x32D0310 Offset: 0x32D0411 VA: 0x32D0310
	|-EqualityComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32D0F90 Offset: 0x32D1091 VA: 0x32D0F90
	|-EqualityComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x32D1B30 Offset: 0x32D1C31 VA: 0x32D1B30
	|-EqualityComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x32D26D0 Offset: 0x32D27D1 VA: 0x32D26D0
	|-EqualityComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x32D3240 Offset: 0x32D3341 VA: 0x32D3240
	|-EqualityComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32D3DB0 Offset: 0x32D3EB1 VA: 0x32D3DB0
	|-EqualityComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x32D4A30 Offset: 0x32D4B31 VA: 0x32D4A30
	|-EqualityComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32D5550 Offset: 0x32D5651 VA: 0x32D5550
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x32D60C0 Offset: 0x32D61C1 VA: 0x32D60C0
	|-EqualityComparer<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x32D6C00 Offset: 0x32D6D01 VA: 0x32D6C00
	|-EqualityComparer<Label>..ctor
	|
	|-RVA: 0x32D7770 Offset: 0x32D7871 VA: 0x32D7770
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x32D82B0 Offset: 0x32D83B1 VA: 0x32D82B0
	|-EqualityComparer<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x32D8DF0 Offset: 0x32D8EF1 VA: 0x32D8DF0
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x32D9940 Offset: 0x32D9A41 VA: 0x32D9940
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x32DA480 Offset: 0x32DA581 VA: 0x32DA480
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x32DAFC0 Offset: 0x32DB0C1 VA: 0x32DAFC0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x32DBB00 Offset: 0x32DBC01 VA: 0x32DBB00
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x32DC640 Offset: 0x32DC741 VA: 0x32DC640
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32DD180 Offset: 0x32DD281 VA: 0x32DD180
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32DDCF0 Offset: 0x32DDDF1 VA: 0x32DDCF0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32DE860 Offset: 0x32DE961 VA: 0x32DE860
	|-EqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32DF3D0 Offset: 0x32DF4D1 VA: 0x32DF3D0
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32E0AB0 Offset: 0x32E0BB1 VA: 0x32E0AB0
	|-EqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x32E1640 Offset: 0x32E1741 VA: 0x32E1640
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32E2370 Offset: 0x32E2471 VA: 0x32E2370
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32E30A0 Offset: 0x32E31A1 VA: 0x32E30A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32E3CF0 Offset: 0x32E3DF1 VA: 0x32E3CF0
	|-EqualityComparer<TransitionTables>..ctor
	|
	|-RVA: 0x32E4880 Offset: 0x32E4981 VA: 0x32E4880
	|-EqualityComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32E60E0 Offset: 0x32E61E1 VA: 0x32E60E0
	|-EqualityComparer<CapEdge>..ctor
	|
	|-RVA: 0x30F20E0 Offset: 0x30F21E1 VA: 0x30F20E0
	|-EqualityComparer<ClippedEdge>..ctor
	|
	|-RVA: 0x30F2C20 Offset: 0x30F2D21 VA: 0x30F2C20
	|-EqualityComparer<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x30F3760 Offset: 0x30F3861 VA: 0x30F3760
	|-EqualityComparer<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x30F42A0 Offset: 0x30F43A1 VA: 0x30F42A0
	|-EqualityComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x30F4EF0 Offset: 0x30F4FF1 VA: 0x30F4EF0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x30F6720 Offset: 0x30F6821 VA: 0x30F6720
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x30F75A0 Offset: 0x30F76A1 VA: 0x30F75A0
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x30F8110 Offset: 0x30F8211 VA: 0x30F8110
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x30F8C50 Offset: 0x30F8D51 VA: 0x30F8C50
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x30F97C0 Offset: 0x30F98C1 VA: 0x30F97C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x30FA410 Offset: 0x30FA511 VA: 0x30FA410
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x30FB060 Offset: 0x30FB161 VA: 0x30FB060
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x30FBCB0 Offset: 0x30FBDB1 VA: 0x30FBCB0
	|-EqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x30FC7F0 Offset: 0x30FC8F1 VA: 0x30FC7F0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x30FD3C0 Offset: 0x30FD4C1 VA: 0x30FD3C0
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x30FE240 Offset: 0x30FE341 VA: 0x30FE240
	|-EqualityComparer<CombineInstance>..ctor
	|
	|-RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x30FFB20 Offset: 0x30FFC21 VA: 0x30FFB20
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x3100690 Offset: 0x3100791 VA: 0x3100690
	|-EqualityComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31012E0 Offset: 0x31013E1 VA: 0x31012E0
	|-EqualityComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x3101FA0 Offset: 0x31020A1 VA: 0x3101FA0
	|-EqualityComparer<Keyframe>..ctor
	|
	|-RVA: 0x3102AE0 Offset: 0x3102BE1 VA: 0x3102AE0
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3103810 Offset: 0x3103911 VA: 0x3103810
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3104490 Offset: 0x3104591 VA: 0x3104490
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3105000 Offset: 0x3105101 VA: 0x3105000
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3105C50 Offset: 0x3105D51 VA: 0x3105C50
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x31067C0 Offset: 0x31068C1 VA: 0x31067C0
	|-EqualityComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x3107300 Offset: 0x3107401 VA: 0x3107300
	|-EqualityComparer<Edge>..ctor
	|
	|-RVA: 0x3107ED0 Offset: 0x3107FD1 VA: 0x3107ED0
	|-EqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x3108AA0 Offset: 0x3108BA1 VA: 0x3108AA0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x31095E0 Offset: 0x31096E1 VA: 0x31095E0
	|-EqualityComparer<RangeInt>..ctor
	|
	|-RVA: 0x310A2D0 Offset: 0x310A3D1 VA: 0x310A2D0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x310B000 Offset: 0x310B101 VA: 0x310B000
	|-EqualityComparer<RaycastHit>..ctor
	|
	|-RVA: 0x310BBD0 Offset: 0x310BCD1 VA: 0x310BBD0
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x310C740 Offset: 0x310C841 VA: 0x310C740
	|-EqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x310D2B0 Offset: 0x310D3B1 VA: 0x310D2B0
	|-EqualityComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x310ED20 Offset: 0x310EE21 VA: 0x310ED20
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x310F970 Offset: 0x310FA71 VA: 0x310F970
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EA7CD0 Offset: 0x2EA7DD1 VA: 0x2EA7CD0
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EA8920 Offset: 0x2EA8A21 VA: 0x2EA8920
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EA95E0 Offset: 0x2EA96E1 VA: 0x2EA95E0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EAA150 Offset: 0x2EAA251 VA: 0x2EAA150
	|-EqualityComparer<SceneInstance>..ctor
	|
	|-RVA: 0x2EAADA0 Offset: 0x2EAAEA1 VA: 0x2EAADA0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2EABA60 Offset: 0x2EABB61 VA: 0x2EABA60
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EAC5D0 Offset: 0x2EAC6D1 VA: 0x2EAC5D0
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EAD2A0 Offset: 0x2EAD3A1 VA: 0x2EAD2A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2EADEF0 Offset: 0x2EADFF1 VA: 0x2EADEF0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EB1270 Offset: 0x2EB1371 VA: 0x2EB1270
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EB1EC0 Offset: 0x2EB1FC1 VA: 0x2EB1EC0
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EB2A90 Offset: 0x2EB2B91 VA: 0x2EB2A90
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x2EB3600 Offset: 0x2EB3701 VA: 0x2EB3600
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2EB4170 Offset: 0x2EB4271 VA: 0x2EB4170
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2EB4CB0 Offset: 0x2EB4DB1 VA: 0x2EB4CB0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2EB5820 Offset: 0x2EB5921 VA: 0x2EB5820
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x2EB6630 Offset: 0x2EB6731 VA: 0x2EB6630
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2EB7DF0 Offset: 0x2EB7EF1 VA: 0x2EB7DF0
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EB8930 Offset: 0x2EB8A31 VA: 0x2EB8930
	|-EqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EB9500 Offset: 0x2EB9601 VA: 0x2EB9500
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EBA090 Offset: 0x2EBA191 VA: 0x2EBA090
	|-EqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EBAC60 Offset: 0x2EBAD61 VA: 0x2EBAC60
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2EBBB50 Offset: 0x2EBBC51 VA: 0x2EBBB50
	|-EqualityComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-EqualityComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x2EBD2E0 Offset: 0x2EBD3E1 VA: 0x2EBD2E0
	|-EqualityComparer<stCommand_t>..ctor
	*/
}

[TypeDependencyAttribute] // RVA: 0xB3A20 Offset: 0xB3B21 VA: 0xB3A20
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1441
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A50 Offset: 0x32D4B51 VA: 0x32D4A50
	|-EqualityComparer<Font>.get_Default
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x2E3E1C0 Offset: 0x2E3E2C1 VA: 0x2E3E1C0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.get_Default
	|
	|-RVA: 0x2E3EE10 Offset: 0x2E3EF11 VA: 0x2E3EE10
	|-EqualityComparer<JSONDeserialization.TaskField>.get_Default
	|
	|-RVA: 0x2E3F980 Offset: 0x2E3FA81 VA: 0x2E3F980
	|-EqualityComparer<BitVector32Int>.get_Default
	|
	|-RVA: 0x2E404C0 Offset: 0x2E405C1 VA: 0x2E404C0
	|-EqualityComparer<BuildItemData>.get_Default
	|
	|-RVA: 0x2E413B0 Offset: 0x2E414B1 VA: 0x2E413B0
	|-EqualityComparer<ButtonLinker.LinkObject>.get_Default
	|
	|-RVA: 0x2E41F20 Offset: 0x2E42021 VA: 0x2E41F20
	|-EqualityComparer<CharaCallTable.BustupTable>.get_Default
	|
	|-RVA: 0x2E42A90 Offset: 0x2E42B91 VA: 0x2E42A90
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.get_Default
	|
	|-RVA: 0x2E43620 Offset: 0x2E43721 VA: 0x2E43620
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x2E44190 Offset: 0x2E44291 VA: 0x2E44190
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x2E44CD0 Offset: 0x2E44DD1 VA: 0x2E44CD0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x2E45810 Offset: 0x2E45911 VA: 0x2E45810
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x2E464D0 Offset: 0x2E465D1 VA: 0x2E464D0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x2E471C0 Offset: 0x2E472C1 VA: 0x2E471C0
	|-EqualityComparer<CropDataTable>.get_Default
	|
	|-RVA: 0x2E47E20 Offset: 0x2E47F21 VA: 0x2E47E20
	|-EqualityComparer<DropItemParam>.get_Default
	|
	|-RVA: 0x2E48960 Offset: 0x2E48A61 VA: 0x2E48960
	|-EqualityComparer<EffectDataTable>.get_Default
	|
	|-RVA: 0x2E495B0 Offset: 0x2E496B1 VA: 0x2E495B0
	|-EqualityComparer<ErosionBrush.UndoStep>.get_Default
	|
	|-RVA: 0x2E4A200 Offset: 0x2E4A301 VA: 0x2E4A200
	|-EqualityComparer<EventCheckId>.get_Default
	|
	|-RVA: 0x2E4AE50 Offset: 0x2E4AF51 VA: 0x2E4AE50
	|-EqualityComparer<EventFlagProgressData>.get_Default
	|
	|-RVA: 0x2E4B9C0 Offset: 0x2E4BAC1 VA: 0x2E4B9C0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.get_Default
	|
	|-RVA: 0x2E4C720 Offset: 0x2E4C821 VA: 0x2E4C720
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.get_Default
	|
	|-RVA: 0x2E4D370 Offset: 0x2E4D471 VA: 0x2E4D370
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.get_Default
	|
	|-RVA: 0x2E4DF00 Offset: 0x2E4E001 VA: 0x2E4DF00
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.get_Default
	|
	|-RVA: 0x2E4EA70 Offset: 0x2E4EB71 VA: 0x2E4EA70
	|-EqualityComparer<FesNpcScoreData>.get_Default
	|
	|-RVA: 0x2E4F5E0 Offset: 0x2E4F6E1 VA: 0x2E4F5E0
	|-EqualityComparer<GimmickLayoutDataTable>.get_Default
	|
	|-RVA: 0x2E50120 Offset: 0x2E50221 VA: 0x2E50120
	|-EqualityComparer<MineTypeDataTable>.get_Default
	|
	|-RVA: 0x2E50E50 Offset: 0x2E50F51 VA: 0x2E50E50
	|-EqualityComparer<MiningDataTable>.get_Default
	|
	|-RVA: 0x2E519C0 Offset: 0x2E51AC1 VA: 0x2E519C0
	|-EqualityComparer<MiningPointSaveData>.get_Default
	|
	|-RVA: 0x2E526B0 Offset: 0x2E527B1 VA: 0x2E526B0
	|-EqualityComparer<MonsterDataTable>.get_Default
	|
	|-RVA: 0x2E53330 Offset: 0x2E53431 VA: 0x2E53330
	|-EqualityComparer<MonsterFootStepEventDataTable>.get_Default
	|
	|-RVA: 0x2E53FF0 Offset: 0x2E540F1 VA: 0x2E53FF0
	|-EqualityComparer<MonsterHutSaveData>.get_Default
	|
	|-RVA: 0x2E54CC0 Offset: 0x2E54DC1 VA: 0x2E54CC0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.get_Default
	|
	|-RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
	|-EqualityComparer<NPCActionData>.get_Default
	|
	|-RVA: 0x2E56560 Offset: 0x2E56661 VA: 0x2E56560
	|-EqualityComparer<NpcPlaceSchedule>.get_Default
	|
	|-RVA: 0x2E571B0 Offset: 0x2E572B1 VA: 0x2E571B0
	|-EqualityComparer<OrderLotterySaveParameter>.get_Default
	|
	|-RVA: 0x31FE270 Offset: 0x31FE371 VA: 0x31FE270
	|-EqualityComparer<OrderSaveData>.get_Default
	|
	|-RVA: 0x31FEF40 Offset: 0x31FF041 VA: 0x31FEF40
	|-EqualityComparer<OrderSaveParameter>.get_Default
	|
	|-RVA: 0x31FFB90 Offset: 0x31FFC91 VA: 0x31FFB90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3200700 Offset: 0x3200801 VA: 0x3200700
	|-EqualityComparer<Parameter>.get_Default
	|
	|-RVA: 0x3201380 Offset: 0x3201481 VA: 0x3201380
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.get_Default
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-EqualityComparer<ShopCatalogPage>.get_Default
	|
	|-RVA: 0x3202A60 Offset: 0x3202B61 VA: 0x3202A60
	|-EqualityComparer<ShopNpcTalk>.get_Default
	|
	|-RVA: 0x3203720 Offset: 0x3203821 VA: 0x3203720
	|-EqualityComparer<SubtitleDataTable.Data>.get_Default
	|
	|-RVA: 0x32042B0 Offset: 0x32043B1 VA: 0x32042B0
	|-EqualityComparer<SubtitleDataTable.DataList>.get_Default
	|
	|-RVA: 0x3204DF0 Offset: 0x3204EF1 VA: 0x3204DF0
	|-EqualityComparer<SubtitleHudDataTable.Data>.get_Default
	|
	|-RVA: 0x3205980 Offset: 0x3205A81 VA: 0x3205980
	|-EqualityComparer<ProfilerFrame>.get_Default
	|
	|-RVA: 0x3206550 Offset: 0x3206651 VA: 0x3206550
	|-EqualityComparer<NumberControl.ValueRange>.get_Default
	|
	|-RVA: 0x32070C0 Offset: 0x32071C1 VA: 0x32070C0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.get_Default
	|
	|-RVA: 0x3207D10 Offset: 0x3207E11 VA: 0x3207D10
	|-EqualityComparer<Schedule>.get_Default
	|
	|-RVA: 0x3208960 Offset: 0x3208A61 VA: 0x3208960
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x32094D0 Offset: 0x32095D1 VA: 0x32094D0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.get_Default
	|
	|-RVA: 0x320A060 Offset: 0x320A161 VA: 0x320A060
	|-EqualityComparer<CurveSample>.get_Default
	|
	|-RVA: 0x320AE00 Offset: 0x320AF01 VA: 0x320AE00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x320B950 Offset: 0x320BA51 VA: 0x320B950
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x320C490 Offset: 0x320C591 VA: 0x320C490
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x320CFD0 Offset: 0x320D0D1 VA: 0x320CFD0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x320DB40 Offset: 0x320DC41 VA: 0x320DB40
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x320E680 Offset: 0x320E781 VA: 0x320E680
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x320FD30 Offset: 0x320FE31 VA: 0x320FD30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x32113E0 Offset: 0x32114E1 VA: 0x32113E0
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3211F50 Offset: 0x3212051 VA: 0x3211F50
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3212AA0 Offset: 0x3212BA1 VA: 0x3212AA0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3213610 Offset: 0x3213711 VA: 0x3213610
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3214150 Offset: 0x3214251 VA: 0x3214150
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3214C90 Offset: 0x3214D91 VA: 0x3214C90
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x32157D0 Offset: 0x32158D1 VA: 0x32157D0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3216310 Offset: 0x3216411 VA: 0x3216310
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3216E80 Offset: 0x3216F81 VA: 0x3216E80
	|-EqualityComparer<Memory<object>>.get_Default
	|
	|-RVA: 0x32179F0 Offset: 0x3217AF1 VA: 0x32179F0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.get_Default
	|
	|-RVA: 0x32186E0 Offset: 0x32187E1 VA: 0x32186E0
	|-EqualityComparer<Nullable<Int32Enum>>.get_Default
	|
	|-RVA: 0x3219230 Offset: 0x3219331 VA: 0x3219230
	|-EqualityComparer<Nullable<Bounds>>.get_Default
	|
	|-RVA: 0x3219F20 Offset: 0x321A021 VA: 0x3219F20
	|-EqualityComparer<Nullable<BoundsInt>>.get_Default
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-EqualityComparer<Nullable<Color32>>.get_Default
	|
	|-RVA: 0x32C9420 Offset: 0x32C9521 VA: 0x32C9420
	|-EqualityComparer<Nullable<Color>>.get_Default
	|
	|-RVA: 0x32CA0A0 Offset: 0x32CA1A1 VA: 0x32CA0A0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.get_Default
	|
	|-RVA: 0x32CAC40 Offset: 0x32CAD41 VA: 0x32CAC40
	|-EqualityComparer<Nullable<GradientColorKey>>.get_Default
	|
	|-RVA: 0x32CB8C0 Offset: 0x32CB9C1 VA: 0x32CB8C0
	|-EqualityComparer<Nullable<Keyframe>>.get_Default
	|
	|-RVA: 0x32CC540 Offset: 0x32CC641 VA: 0x32CC540
	|-EqualityComparer<Nullable<LayerMask>>.get_Default
	|
	|-RVA: 0x32CD090 Offset: 0x32CD191 VA: 0x32CD090
	|-EqualityComparer<Nullable<Matrix4x4>>.get_Default
	|
	|-RVA: 0x32CDE90 Offset: 0x32CDF91 VA: 0x32CDE90
	|-EqualityComparer<Nullable<Quaternion>>.get_Default
	|
	|-RVA: 0x32CEB10 Offset: 0x32CEC11 VA: 0x32CEB10
	|-EqualityComparer<Nullable<RangeInt>>.get_Default
	|
	|-RVA: 0x32CF6B0 Offset: 0x32CF7B1 VA: 0x32CF6B0
	|-EqualityComparer<Nullable<Rect>>.get_Default
	|
	|-RVA: 0x32D0330 Offset: 0x32D0431 VA: 0x32D0330
	|-EqualityComparer<Nullable<RectInt>>.get_Default
	|
	|-RVA: 0x32D0FB0 Offset: 0x32D10B1 VA: 0x32D0FB0
	|-EqualityComparer<Nullable<Vector2>>.get_Default
	|
	|-RVA: 0x32D1B50 Offset: 0x32D1C51 VA: 0x32D1B50
	|-EqualityComparer<Nullable<Vector2Int>>.get_Default
	|
	|-RVA: 0x32D26F0 Offset: 0x32D27F1 VA: 0x32D26F0
	|-EqualityComparer<Nullable<Vector3>>.get_Default
	|
	|-RVA: 0x32D3260 Offset: 0x32D3361 VA: 0x32D3260
	|-EqualityComparer<Nullable<Vector3Int>>.get_Default
	|
	|-RVA: 0x32D3DD0 Offset: 0x32D3ED1 VA: 0x32D3DD0
	|-EqualityComparer<Nullable<Vector4>>.get_Default
	|
	|-RVA: 0x32D5570 Offset: 0x32D5671 VA: 0x32D5570
	|-EqualityComparer<ReadOnlyMemory<object>>.get_Default
	|
	|-RVA: 0x32D60E0 Offset: 0x32D61E1 VA: 0x32D60E0
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x32D6C20 Offset: 0x32D6D21 VA: 0x32D6C20
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x32D7790 Offset: 0x32D7891 VA: 0x32D7790
	|-EqualityComparer<RuntimeTypeHandle>.get_Default
	|
	|-RVA: 0x32D82D0 Offset: 0x32D83D1 VA: 0x32D82D0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x32D8E10 Offset: 0x32D8F11 VA: 0x32D8E10
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x32D9960 Offset: 0x32D9A61 VA: 0x32D9960
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x32DA4A0 Offset: 0x32DA5A1 VA: 0x32DA4A0
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x32DAFE0 Offset: 0x32DB0E1 VA: 0x32DAFE0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DC660 Offset: 0x32DC761 VA: 0x32DC660
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x32DD1A0 Offset: 0x32DD2A1 VA: 0x32DD1A0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x32DDD10 Offset: 0x32DDE11 VA: 0x32DDD10
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DE880 Offset: 0x32DE981 VA: 0x32DE880
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x32DF3F0 Offset: 0x32DF4F1 VA: 0x32DF3F0
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x32DFF60 Offset: 0x32E0061 VA: 0x32DFF60
	|-EqualityComparer<ValueTuple<float, float>>.get_Default
	|
	|-RVA: 0x32E0AD0 Offset: 0x32E0BD1 VA: 0x32E0AD0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Default
	|
	|-RVA: 0x32E1660 Offset: 0x32E1761 VA: 0x32E1660
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Default
	|
	|-RVA: 0x32E2390 Offset: 0x32E2491 VA: 0x32E2390
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x32E30C0 Offset: 0x32E31C1 VA: 0x32E30C0
	|-EqualityComparer<TransitionTables>.get_Default
	|
	|-RVA: 0x32E3D10 Offset: 0x32E3E11 VA: 0x32E3D10
	|-EqualityComparer<TutorialUnlockFlagData>.get_Default
	|
	|-RVA: 0x32E48A0 Offset: 0x32E49A1 VA: 0x32E48A0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.get_Default
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-EqualityComparer<CapEdge>.get_Default
	|
	|-RVA: 0x30F14B0 Offset: 0x30F15B1 VA: 0x30F14B0
	|-EqualityComparer<ClippedEdge>.get_Default
	|
	|-RVA: 0x30F2100 Offset: 0x30F2201 VA: 0x30F2100
	|-EqualityComparer<EdgeKeyByHash>.get_Default
	|
	|-RVA: 0x30F2C40 Offset: 0x30F2D41 VA: 0x30F2C40
	|-EqualityComparer<EdgeKeyByIndex>.get_Default
	|
	|-RVA: 0x30F3780 Offset: 0x30F3881 VA: 0x30F3780
	|-EqualityComparer<MeshDataConnectivity.Face>.get_Default
	|
	|-RVA: 0x30F42C0 Offset: 0x30F43C1 VA: 0x30F42C0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.get_Default
	|
	|-RVA: 0x30F4F10 Offset: 0x30F5011 VA: 0x30F4F10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.get_Default
	|
	|-RVA: 0x30F5BD0 Offset: 0x30F5CD1 VA: 0x30F5BD0
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x30F6740 Offset: 0x30F6841 VA: 0x30F6740
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x30F75C0 Offset: 0x30F76C1 VA: 0x30F75C0
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x30F8130 Offset: 0x30F8231 VA: 0x30F8130
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x30F8C70 Offset: 0x30F8D71 VA: 0x30F8C70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x30F97E0 Offset: 0x30F98E1 VA: 0x30F97E0
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x30FA430 Offset: 0x30FA531 VA: 0x30FA430
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x30FB080 Offset: 0x30FB181 VA: 0x30FB080
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x30FBCD0 Offset: 0x30FBDD1 VA: 0x30FBCD0
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x30FC810 Offset: 0x30FC911 VA: 0x30FC810
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x30FD3E0 Offset: 0x30FD4E1 VA: 0x30FD3E0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x30FE260 Offset: 0x30FE361 VA: 0x30FE260
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x30FF000 Offset: 0x30FF101 VA: 0x30FF000
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	|
	|-RVA: 0x30FFB40 Offset: 0x30FFC41 VA: 0x30FFB40
	|-EqualityComparer<GradientAlphaKey>.get_Default
	|
	|-RVA: 0x31006B0 Offset: 0x31007B1 VA: 0x31006B0
	|-EqualityComparer<GradientColorKey>.get_Default
	|
	|-RVA: 0x3101300 Offset: 0x3101401 VA: 0x3101300
	|-EqualityComparer<Keyframe>.get_Default
	|
	|-RVA: 0x3101FC0 Offset: 0x31020C1 VA: 0x3101FC0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3102B00 Offset: 0x3102C01 VA: 0x3102B00
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x31044B0 Offset: 0x31045B1 VA: 0x31044B0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3105020 Offset: 0x3105121 VA: 0x3105020
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3105C70 Offset: 0x3105D71 VA: 0x3105C70
	|-EqualityComparer<PlayableGraph>.get_Default
	|
	|-RVA: 0x31067E0 Offset: 0x31068E1 VA: 0x31067E0
	|-EqualityComparer<Edge>.get_Default
	|
	|-RVA: 0x3107320 Offset: 0x3107421 VA: 0x3107320
	|-EqualityComparer<IntVec3>.get_Default
	|
	|-RVA: 0x3107EF0 Offset: 0x3107FF1 VA: 0x3107EF0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3108AC0 Offset: 0x3108BC1 VA: 0x3108AC0
	|-EqualityComparer<RangeInt>.get_Default
	|
	|-RVA: 0x3109600 Offset: 0x3109701 VA: 0x3109600
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x310A2F0 Offset: 0x310A3F1 VA: 0x310A2F0
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x310B020 Offset: 0x310B121 VA: 0x310B020
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x310BBF0 Offset: 0x310BCF1 VA: 0x310BBF0
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x310C760 Offset: 0x310C861 VA: 0x310C760
	|-EqualityComparer<ReflectionProbeBlendInfo>.get_Default
	|
	|-RVA: 0x310D2D0 Offset: 0x310D3D1 VA: 0x310D2D0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x310E1D0 Offset: 0x310E2D1 VA: 0x310E1D0
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x310ED40 Offset: 0x310EE41 VA: 0x310ED40
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x2EA70A0 Offset: 0x2EA71A1 VA: 0x2EA70A0
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x2EA7CF0 Offset: 0x2EA7DF1 VA: 0x2EA7CF0
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.get_Default
	|
	|-RVA: 0x2EA8940 Offset: 0x2EA8A41 VA: 0x2EA8940
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x2EA9600 Offset: 0x2EA9701 VA: 0x2EA9600
	|-EqualityComparer<SceneInstance>.get_Default
	|
	|-RVA: 0x2EAA170 Offset: 0x2EAA271 VA: 0x2EAA170
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x2EAADC0 Offset: 0x2EAAEC1 VA: 0x2EAADC0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x2EABA80 Offset: 0x2EABB81 VA: 0x2EABA80
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x2EAC5F0 Offset: 0x2EAC6F1 VA: 0x2EAC5F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x2EAD2C0 Offset: 0x2EAD3C1 VA: 0x2EAD2C0
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x2EADF10 Offset: 0x2EAE011 VA: 0x2EADF10
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x2EAEB60 Offset: 0x2EAEC61 VA: 0x2EAEB60
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x2EAF7B0 Offset: 0x2EAF8B1 VA: 0x2EAF7B0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x2EB05C0 Offset: 0x2EB06C1 VA: 0x2EB05C0
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x2EB1290 Offset: 0x2EB1391 VA: 0x2EB1290
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x2EB1EE0 Offset: 0x2EB1FE1 VA: 0x2EB1EE0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x2EB3620 Offset: 0x2EB3721 VA: 0x2EB3620
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x2EB4190 Offset: 0x2EB4291 VA: 0x2EB4190
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x2EB4CD0 Offset: 0x2EB4DD1 VA: 0x2EB4CD0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x2EB5840 Offset: 0x2EB5941 VA: 0x2EB5840
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x2EB6650 Offset: 0x2EB6751 VA: 0x2EB6650
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2EB72A0 Offset: 0x2EB73A1 VA: 0x2EB72A0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x2EB8950 Offset: 0x2EB8A51 VA: 0x2EB8950
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x2EBA0B0 Offset: 0x2EBA1B1 VA: 0x2EBA0B0
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-EqualityComparer<WarpPoints.WarpPoint>.get_Default
	|
	|-RVA: 0x2EBBB70 Offset: 0x2EBBC71 VA: 0x2EBBB70
	|-EqualityComparer<YieldItemParam>.get_Default
	|
	|-RVA: 0x2EBC6B0 Offset: 0x2EBC7B1 VA: 0x2EBC6B0
	|-EqualityComparer<stCommand_t>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E2D0 Offset: 0x2E3E3D1 VA: 0x2E3E2D0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.CreateComparer
	|
	|-RVA: 0x2E3EF20 Offset: 0x2E3F021 VA: 0x2E3EF20
	|-EqualityComparer<JSONDeserialization.TaskField>.CreateComparer
	|
	|-RVA: 0x2E3FA90 Offset: 0x2E3FB91 VA: 0x2E3FA90
	|-EqualityComparer<BitVector32Int>.CreateComparer
	|
	|-RVA: 0x2E405D0 Offset: 0x2E406D1 VA: 0x2E405D0
	|-EqualityComparer<BuildItemData>.CreateComparer
	|
	|-RVA: 0x2E414C0 Offset: 0x2E415C1 VA: 0x2E414C0
	|-EqualityComparer<ButtonLinker.LinkObject>.CreateComparer
	|
	|-RVA: 0x2E42030 Offset: 0x2E42131 VA: 0x2E42030
	|-EqualityComparer<CharaCallTable.BustupTable>.CreateComparer
	|
	|-RVA: 0x2E42BA0 Offset: 0x2E42CA1 VA: 0x2E42BA0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.CreateComparer
	|
	|-RVA: 0x2E43730 Offset: 0x2E43831 VA: 0x2E43730
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x2E465E0 Offset: 0x2E466E1 VA: 0x2E465E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x2E472D0 Offset: 0x2E473D1 VA: 0x2E472D0
	|-EqualityComparer<CropDataTable>.CreateComparer
	|
	|-RVA: 0x2E47F30 Offset: 0x2E48031 VA: 0x2E47F30
	|-EqualityComparer<DropItemParam>.CreateComparer
	|
	|-RVA: 0x2E48A70 Offset: 0x2E48B71 VA: 0x2E48A70
	|-EqualityComparer<EffectDataTable>.CreateComparer
	|
	|-RVA: 0x2E496C0 Offset: 0x2E497C1 VA: 0x2E496C0
	|-EqualityComparer<ErosionBrush.UndoStep>.CreateComparer
	|
	|-RVA: 0x2E4A310 Offset: 0x2E4A411 VA: 0x2E4A310
	|-EqualityComparer<EventCheckId>.CreateComparer
	|
	|-RVA: 0x2E4AF60 Offset: 0x2E4B061 VA: 0x2E4AF60
	|-EqualityComparer<EventFlagProgressData>.CreateComparer
	|
	|-RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.CreateComparer
	|
	|-RVA: 0x2E4C830 Offset: 0x2E4C931 VA: 0x2E4C830
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.CreateComparer
	|
	|-RVA: 0x2E4D480 Offset: 0x2E4D581 VA: 0x2E4D480
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.CreateComparer
	|
	|-RVA: 0x2E4E010 Offset: 0x2E4E111 VA: 0x2E4E010
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.CreateComparer
	|
	|-RVA: 0x2E4EB80 Offset: 0x2E4EC81 VA: 0x2E4EB80
	|-EqualityComparer<FesNpcScoreData>.CreateComparer
	|
	|-RVA: 0x2E4F6F0 Offset: 0x2E4F7F1 VA: 0x2E4F6F0
	|-EqualityComparer<GimmickLayoutDataTable>.CreateComparer
	|
	|-RVA: 0x2E50230 Offset: 0x2E50331 VA: 0x2E50230
	|-EqualityComparer<MineTypeDataTable>.CreateComparer
	|
	|-RVA: 0x2E50F60 Offset: 0x2E51061 VA: 0x2E50F60
	|-EqualityComparer<MiningDataTable>.CreateComparer
	|
	|-RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0
	|-EqualityComparer<MiningPointSaveData>.CreateComparer
	|
	|-RVA: 0x2E527C0 Offset: 0x2E528C1 VA: 0x2E527C0
	|-EqualityComparer<MonsterDataTable>.CreateComparer
	|
	|-RVA: 0x2E53440 Offset: 0x2E53541 VA: 0x2E53440
	|-EqualityComparer<MonsterFootStepEventDataTable>.CreateComparer
	|
	|-RVA: 0x2E54100 Offset: 0x2E54201 VA: 0x2E54100
	|-EqualityComparer<MonsterHutSaveData>.CreateComparer
	|
	|-RVA: 0x2E54DD0 Offset: 0x2E54ED1 VA: 0x2E54DD0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.CreateComparer
	|
	|-RVA: 0x2E55940 Offset: 0x2E55A41 VA: 0x2E55940
	|-EqualityComparer<NPCActionData>.CreateComparer
	|
	|-RVA: 0x2E56670 Offset: 0x2E56771 VA: 0x2E56670
	|-EqualityComparer<NpcPlaceSchedule>.CreateComparer
	|
	|-RVA: 0x2E572C0 Offset: 0x2E573C1 VA: 0x2E572C0
	|-EqualityComparer<OrderLotterySaveParameter>.CreateComparer
	|
	|-RVA: 0x31FE380 Offset: 0x31FE481 VA: 0x31FE380
	|-EqualityComparer<OrderSaveData>.CreateComparer
	|
	|-RVA: 0x31FF050 Offset: 0x31FF151 VA: 0x31FF050
	|-EqualityComparer<OrderSaveParameter>.CreateComparer
	|
	|-RVA: 0x31FFCA0 Offset: 0x31FFDA1 VA: 0x31FFCA0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3200810 Offset: 0x3200911 VA: 0x3200810
	|-EqualityComparer<Parameter>.CreateComparer
	|
	|-RVA: 0x3201490 Offset: 0x3201591 VA: 0x3201490
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.CreateComparer
	|
	|-RVA: 0x3202000 Offset: 0x3202101 VA: 0x3202000
	|-EqualityComparer<ShopCatalogPage>.CreateComparer
	|
	|-RVA: 0x3202B70 Offset: 0x3202C71 VA: 0x3202B70
	|-EqualityComparer<ShopNpcTalk>.CreateComparer
	|
	|-RVA: 0x3203830 Offset: 0x3203931 VA: 0x3203830
	|-EqualityComparer<SubtitleDataTable.Data>.CreateComparer
	|
	|-RVA: 0x32043C0 Offset: 0x32044C1 VA: 0x32043C0
	|-EqualityComparer<SubtitleDataTable.DataList>.CreateComparer
	|
	|-RVA: 0x3204F00 Offset: 0x3205001 VA: 0x3204F00
	|-EqualityComparer<SubtitleHudDataTable.Data>.CreateComparer
	|
	|-RVA: 0x3205A90 Offset: 0x3205B91 VA: 0x3205A90
	|-EqualityComparer<ProfilerFrame>.CreateComparer
	|
	|-RVA: 0x3206660 Offset: 0x3206761 VA: 0x3206660
	|-EqualityComparer<NumberControl.ValueRange>.CreateComparer
	|
	|-RVA: 0x32071D0 Offset: 0x32072D1 VA: 0x32071D0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.CreateComparer
	|
	|-RVA: 0x3207E20 Offset: 0x3207F21 VA: 0x3207E20
	|-EqualityComparer<Schedule>.CreateComparer
	|
	|-RVA: 0x3208A70 Offset: 0x3208B71 VA: 0x3208A70
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x32095E0 Offset: 0x32096E1 VA: 0x32095E0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.CreateComparer
	|
	|-RVA: 0x320A170 Offset: 0x320A271 VA: 0x320A170
	|-EqualityComparer<CurveSample>.CreateComparer
	|
	|-RVA: 0x320AF10 Offset: 0x320B011 VA: 0x320AF10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x320BA60 Offset: 0x320BB61 VA: 0x320BA60
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x320C5A0 Offset: 0x320C6A1 VA: 0x320C5A0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x320D0E0 Offset: 0x320D1E1 VA: 0x320D0E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x320DC50 Offset: 0x320DD51 VA: 0x320DC50
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x320E790 Offset: 0x320E891 VA: 0x320E790
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x320F300 Offset: 0x320F401 VA: 0x320F300
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x320FE40 Offset: 0x320FF41 VA: 0x320FE40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x32109B0 Offset: 0x3210AB1 VA: 0x32109B0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x32114F0 Offset: 0x32115F1 VA: 0x32114F0
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3212060 Offset: 0x3212161 VA: 0x3212060
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3212BB0 Offset: 0x3212CB1 VA: 0x3212BB0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3213720 Offset: 0x3213821 VA: 0x3213720
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3214260 Offset: 0x3214361 VA: 0x3214260
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3214DA0 Offset: 0x3214EA1 VA: 0x3214DA0
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x32158E0 Offset: 0x32159E1 VA: 0x32158E0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3216420 Offset: 0x3216521 VA: 0x3216420
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3216F90 Offset: 0x3217091 VA: 0x3216F90
	|-EqualityComparer<Memory<object>>.CreateComparer
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.CreateComparer
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-EqualityComparer<Nullable<Int32Enum>>.CreateComparer
	|
	|-RVA: 0x3219340 Offset: 0x3219441 VA: 0x3219340
	|-EqualityComparer<Nullable<Bounds>>.CreateComparer
	|
	|-RVA: 0x321A030 Offset: 0x321A131 VA: 0x321A030
	|-EqualityComparer<Nullable<BoundsInt>>.CreateComparer
	|
	|-RVA: 0x321AD20 Offset: 0x321AE21 VA: 0x321AD20
	|-EqualityComparer<Nullable<Color32>>.CreateComparer
	|
	|-RVA: 0x32C9530 Offset: 0x32C9631 VA: 0x32C9530
	|-EqualityComparer<Nullable<Color>>.CreateComparer
	|
	|-RVA: 0x32CA1B0 Offset: 0x32CA2B1 VA: 0x32CA1B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.CreateComparer
	|
	|-RVA: 0x32CAD50 Offset: 0x32CAE51 VA: 0x32CAD50
	|-EqualityComparer<Nullable<GradientColorKey>>.CreateComparer
	|
	|-RVA: 0x32CB9D0 Offset: 0x32CBAD1 VA: 0x32CB9D0
	|-EqualityComparer<Nullable<Keyframe>>.CreateComparer
	|
	|-RVA: 0x32CC650 Offset: 0x32CC751 VA: 0x32CC650
	|-EqualityComparer<Nullable<LayerMask>>.CreateComparer
	|
	|-RVA: 0x32CD1A0 Offset: 0x32CD2A1 VA: 0x32CD1A0
	|-EqualityComparer<Nullable<Matrix4x4>>.CreateComparer
	|
	|-RVA: 0x32CDFA0 Offset: 0x32CE0A1 VA: 0x32CDFA0
	|-EqualityComparer<Nullable<Quaternion>>.CreateComparer
	|
	|-RVA: 0x32CEC20 Offset: 0x32CED21 VA: 0x32CEC20
	|-EqualityComparer<Nullable<RangeInt>>.CreateComparer
	|
	|-RVA: 0x32CF7C0 Offset: 0x32CF8C1 VA: 0x32CF7C0
	|-EqualityComparer<Nullable<Rect>>.CreateComparer
	|
	|-RVA: 0x32D0440 Offset: 0x32D0541 VA: 0x32D0440
	|-EqualityComparer<Nullable<RectInt>>.CreateComparer
	|
	|-RVA: 0x32D10C0 Offset: 0x32D11C1 VA: 0x32D10C0
	|-EqualityComparer<Nullable<Vector2>>.CreateComparer
	|
	|-RVA: 0x32D1C60 Offset: 0x32D1D61 VA: 0x32D1C60
	|-EqualityComparer<Nullable<Vector2Int>>.CreateComparer
	|
	|-RVA: 0x32D2800 Offset: 0x32D2901 VA: 0x32D2800
	|-EqualityComparer<Nullable<Vector3>>.CreateComparer
	|
	|-RVA: 0x32D3370 Offset: 0x32D3471 VA: 0x32D3370
	|-EqualityComparer<Nullable<Vector3Int>>.CreateComparer
	|
	|-RVA: 0x32D3EE0 Offset: 0x32D3FE1 VA: 0x32D3EE0
	|-EqualityComparer<Nullable<Vector4>>.CreateComparer
	|
	|-RVA: 0x32D4B60 Offset: 0x32D4C61 VA: 0x32D4B60
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x32D5680 Offset: 0x32D5781 VA: 0x32D5680
	|-EqualityComparer<ReadOnlyMemory<object>>.CreateComparer
	|
	|-RVA: 0x32D61F0 Offset: 0x32D62F1 VA: 0x32D61F0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x32D6D30 Offset: 0x32D6E31 VA: 0x32D6D30
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x32D78A0 Offset: 0x32D79A1 VA: 0x32D78A0
	|-EqualityComparer<RuntimeTypeHandle>.CreateComparer
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x32D8F20 Offset: 0x32D9021 VA: 0x32D8F20
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x32D9A70 Offset: 0x32D9B71 VA: 0x32D9A70
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x32DB0F0 Offset: 0x32DB1F1 VA: 0x32DB0F0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x32DBC30 Offset: 0x32DBD31 VA: 0x32DBC30
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DC770 Offset: 0x32DC871 VA: 0x32DC770
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x32DD2B0 Offset: 0x32DD3B1 VA: 0x32DD2B0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x32DDE20 Offset: 0x32DDF21 VA: 0x32DDE20
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DE990 Offset: 0x32DEA91 VA: 0x32DE990
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x32E0070 Offset: 0x32E0171 VA: 0x32E0070
	|-EqualityComparer<ValueTuple<float, float>>.CreateComparer
	|
	|-RVA: 0x32E0BE0 Offset: 0x32E0CE1 VA: 0x32E0BE0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CreateComparer
	|
	|-RVA: 0x32E24A0 Offset: 0x32E25A1 VA: 0x32E24A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x32E31D0 Offset: 0x32E32D1 VA: 0x32E31D0
	|-EqualityComparer<TransitionTables>.CreateComparer
	|
	|-RVA: 0x32E3E20 Offset: 0x32E3F21 VA: 0x32E3E20
	|-EqualityComparer<TutorialUnlockFlagData>.CreateComparer
	|
	|-RVA: 0x32E49B0 Offset: 0x32E4AB1 VA: 0x32E49B0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.CreateComparer
	|
	|-RVA: 0x32E5520 Offset: 0x32E5621 VA: 0x32E5520
	|-EqualityComparer<CapEdge>.CreateComparer
	|
	|-RVA: 0x30F15C0 Offset: 0x30F16C1 VA: 0x30F15C0
	|-EqualityComparer<ClippedEdge>.CreateComparer
	|
	|-RVA: 0x30F2210 Offset: 0x30F2311 VA: 0x30F2210
	|-EqualityComparer<EdgeKeyByHash>.CreateComparer
	|
	|-RVA: 0x30F2D50 Offset: 0x30F2E51 VA: 0x30F2D50
	|-EqualityComparer<EdgeKeyByIndex>.CreateComparer
	|
	|-RVA: 0x30F3890 Offset: 0x30F3991 VA: 0x30F3890
	|-EqualityComparer<MeshDataConnectivity.Face>.CreateComparer
	|
	|-RVA: 0x30F43D0 Offset: 0x30F44D1 VA: 0x30F43D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.CreateComparer
	|
	|-RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.CreateComparer
	|
	|-RVA: 0x30F5CE0 Offset: 0x30F5DE1 VA: 0x30F5CE0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x30F76D0 Offset: 0x30F77D1 VA: 0x30F76D0
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x30F8240 Offset: 0x30F8341 VA: 0x30F8240
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x30F8D80 Offset: 0x30F8E81 VA: 0x30F8D80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x30FA540 Offset: 0x30FA641 VA: 0x30FA540
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x30FB190 Offset: 0x30FB291 VA: 0x30FB190
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x30FBDE0 Offset: 0x30FBEE1 VA: 0x30FBDE0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x30FC920 Offset: 0x30FCA21 VA: 0x30FC920
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x30FD4F0 Offset: 0x30FD5F1 VA: 0x30FD4F0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x30FE370 Offset: 0x30FE471 VA: 0x30FE370
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	|
	|-RVA: 0x30FFC50 Offset: 0x30FFD51 VA: 0x30FFC50
	|-EqualityComparer<GradientAlphaKey>.CreateComparer
	|
	|-RVA: 0x31007C0 Offset: 0x31008C1 VA: 0x31007C0
	|-EqualityComparer<GradientColorKey>.CreateComparer
	|
	|-RVA: 0x3101410 Offset: 0x3101511 VA: 0x3101410
	|-EqualityComparer<Keyframe>.CreateComparer
	|
	|-RVA: 0x31020D0 Offset: 0x31021D1 VA: 0x31020D0
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3102C10 Offset: 0x3102D11 VA: 0x3102C10
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3103940 Offset: 0x3103A41 VA: 0x3103940
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x31045C0 Offset: 0x31046C1 VA: 0x31045C0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3105130 Offset: 0x3105231 VA: 0x3105130
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3105D80 Offset: 0x3105E81 VA: 0x3105D80
	|-EqualityComparer<PlayableGraph>.CreateComparer
	|
	|-RVA: 0x31068F0 Offset: 0x31069F1 VA: 0x31068F0
	|-EqualityComparer<Edge>.CreateComparer
	|
	|-RVA: 0x3107430 Offset: 0x3107531 VA: 0x3107430
	|-EqualityComparer<IntVec3>.CreateComparer
	|
	|-RVA: 0x3108000 Offset: 0x3108101 VA: 0x3108000
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3108BD0 Offset: 0x3108CD1 VA: 0x3108BD0
	|-EqualityComparer<RangeInt>.CreateComparer
	|
	|-RVA: 0x3109710 Offset: 0x3109811 VA: 0x3109710
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x310A400 Offset: 0x310A501 VA: 0x310A400
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x310B130 Offset: 0x310B231 VA: 0x310B130
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x310BD00 Offset: 0x310BE01 VA: 0x310BD00
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x310C870 Offset: 0x310C971 VA: 0x310C870
	|-EqualityComparer<ReflectionProbeBlendInfo>.CreateComparer
	|
	|-RVA: 0x310D3E0 Offset: 0x310D4E1 VA: 0x310D3E0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x310E2E0 Offset: 0x310E3E1 VA: 0x310E2E0
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x310EE50 Offset: 0x310EF51 VA: 0x310EE50
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x2EA71B0 Offset: 0x2EA72B1 VA: 0x2EA71B0
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x2EA7E00 Offset: 0x2EA7F01 VA: 0x2EA7E00
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.CreateComparer
	|
	|-RVA: 0x2EA8A50 Offset: 0x2EA8B51 VA: 0x2EA8A50
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x2EA9710 Offset: 0x2EA9811 VA: 0x2EA9710
	|-EqualityComparer<SceneInstance>.CreateComparer
	|
	|-RVA: 0x2EAA280 Offset: 0x2EAA381 VA: 0x2EAA280
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x2EAAED0 Offset: 0x2EAAFD1 VA: 0x2EAAED0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x2EABB90 Offset: 0x2EABC91 VA: 0x2EABB90
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x2EAC700 Offset: 0x2EAC801 VA: 0x2EAC700
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x2EAD3D0 Offset: 0x2EAD4D1 VA: 0x2EAD3D0
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x2EAE020 Offset: 0x2EAE121 VA: 0x2EAE020
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x2EAEC70 Offset: 0x2EAED71 VA: 0x2EAEC70
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x2EAF8C0 Offset: 0x2EAF9C1 VA: 0x2EAF8C0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x2EB06D0 Offset: 0x2EB07D1 VA: 0x2EB06D0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x2EB13A0 Offset: 0x2EB14A1 VA: 0x2EB13A0
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x2EB2BC0 Offset: 0x2EB2CC1 VA: 0x2EB2BC0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x2EB3730 Offset: 0x2EB3831 VA: 0x2EB3730
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x2EB42A0 Offset: 0x2EB43A1 VA: 0x2EB42A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x2EB4DE0 Offset: 0x2EB4EE1 VA: 0x2EB4DE0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x2EB5950 Offset: 0x2EB5A51 VA: 0x2EB5950
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x2EB6760 Offset: 0x2EB6861 VA: 0x2EB6760
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2EB73B0 Offset: 0x2EB74B1 VA: 0x2EB73B0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2EB7F20 Offset: 0x2EB8021 VA: 0x2EB7F20
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x2EB8A60 Offset: 0x2EB8B61 VA: 0x2EB8A60
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2EB9630 Offset: 0x2EB9731 VA: 0x2EB9630
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x2EBA1C0 Offset: 0x2EBA2C1 VA: 0x2EBA1C0
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x2EBAD90 Offset: 0x2EBAE91 VA: 0x2EBAD90
	|-EqualityComparer<WarpPoints.WarpPoint>.CreateComparer
	|
	|-RVA: 0x2EBBC80 Offset: 0x2EBBD81 VA: 0x2EBBC80
	|-EqualityComparer<YieldItemParam>.CreateComparer
	|
	|-RVA: 0x2EBC7C0 Offset: 0x2EBC8C1 VA: 0x2EBC7C0
	|-EqualityComparer<stCommand_t>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E910 Offset: 0x2E3EA11 VA: 0x2E3E910
	|-EqualityComparer<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2E3F560 Offset: 0x2E3F661 VA: 0x2E3F560
	|-EqualityComparer<JSONDeserialization.TaskField>.IndexOf
	|
	|-RVA: 0x2E400D0 Offset: 0x2E401D1 VA: 0x2E400D0
	|-EqualityComparer<BitVector32Int>.IndexOf
	|
	|-RVA: 0x2E40C10 Offset: 0x2E40D11 VA: 0x2E40C10
	|-EqualityComparer<BuildItemData>.IndexOf
	|
	|-RVA: 0x2E41B00 Offset: 0x2E41C01 VA: 0x2E41B00
	|-EqualityComparer<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2E42670 Offset: 0x2E42771 VA: 0x2E42670
	|-EqualityComparer<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2E431E0 Offset: 0x2E432E1 VA: 0x2E431E0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2E43D70 Offset: 0x2E43E71 VA: 0x2E43D70
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2E448E0 Offset: 0x2E449E1 VA: 0x2E448E0
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2E45420 Offset: 0x2E45521 VA: 0x2E45420
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2E45F60 Offset: 0x2E46061 VA: 0x2E45F60
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2E46C20 Offset: 0x2E46D21 VA: 0x2E46C20
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2E47910 Offset: 0x2E47A11 VA: 0x2E47910
	|-EqualityComparer<CropDataTable>.IndexOf
	|
	|-RVA: 0x2E48570 Offset: 0x2E48671 VA: 0x2E48570
	|-EqualityComparer<DropItemParam>.IndexOf
	|
	|-RVA: 0x2E490B0 Offset: 0x2E491B1 VA: 0x2E490B0
	|-EqualityComparer<EffectDataTable>.IndexOf
	|
	|-RVA: 0x2E49D00 Offset: 0x2E49E01 VA: 0x2E49D00
	|-EqualityComparer<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2E4A950 Offset: 0x2E4AA51 VA: 0x2E4A950
	|-EqualityComparer<EventCheckId>.IndexOf
	|
	|-RVA: 0x2E4B5A0 Offset: 0x2E4B6A1 VA: 0x2E4B5A0
	|-EqualityComparer<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2E4C110 Offset: 0x2E4C211 VA: 0x2E4C110
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.IndexOf
	|
	|-RVA: 0x2E4CE70 Offset: 0x2E4CF71 VA: 0x2E4CE70
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.IndexOf
	|
	|-RVA: 0x2E4DAC0 Offset: 0x2E4DBC1 VA: 0x2E4DAC0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.IndexOf
	|
	|-RVA: 0x2E4E650 Offset: 0x2E4E751 VA: 0x2E4E650
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.IndexOf
	|
	|-RVA: 0x2E4F1C0 Offset: 0x2E4F2C1 VA: 0x2E4F1C0
	|-EqualityComparer<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2E4FD30 Offset: 0x2E4FE31 VA: 0x2E4FD30
	|-EqualityComparer<GimmickLayoutDataTable>.IndexOf
	|
	|-RVA: 0x2E50870 Offset: 0x2E50971 VA: 0x2E50870
	|-EqualityComparer<MineTypeDataTable>.IndexOf
	|
	|-RVA: 0x2E515A0 Offset: 0x2E516A1 VA: 0x2E515A0
	|-EqualityComparer<MiningDataTable>.IndexOf
	|
	|-RVA: 0x2E52110 Offset: 0x2E52211 VA: 0x2E52110
	|-EqualityComparer<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2E52E00 Offset: 0x2E52F01 VA: 0x2E52E00
	|-EqualityComparer<MonsterDataTable>.IndexOf
	|
	|-RVA: 0x2E53A80 Offset: 0x2E53B81 VA: 0x2E53A80
	|-EqualityComparer<MonsterFootStepEventDataTable>.IndexOf
	|
	|-RVA: 0x2E54740 Offset: 0x2E54841 VA: 0x2E54740
	|-EqualityComparer<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2E55410 Offset: 0x2E55511 VA: 0x2E55410
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x2E55F80 Offset: 0x2E56081 VA: 0x2E55F80
	|-EqualityComparer<NPCActionData>.IndexOf
	|
	|-RVA: 0x2E56CB0 Offset: 0x2E56DB1 VA: 0x2E56CB0
	|-EqualityComparer<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	|-EqualityComparer<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31FE9C0 Offset: 0x31FEAC1 VA: 0x31FE9C0
	|-EqualityComparer<OrderSaveData>.IndexOf
	|
	|-RVA: 0x31FF690 Offset: 0x31FF791 VA: 0x31FF690
	|-EqualityComparer<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32002E0 Offset: 0x32003E1 VA: 0x32002E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3200E50 Offset: 0x3200F51 VA: 0x3200E50
	|-EqualityComparer<Parameter>.IndexOf
	|
	|-RVA: 0x3201AD0 Offset: 0x3201BD1 VA: 0x3201AD0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.IndexOf
	|
	|-RVA: 0x3202640 Offset: 0x3202741 VA: 0x3202640
	|-EqualityComparer<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32031B0 Offset: 0x32032B1 VA: 0x32031B0
	|-EqualityComparer<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x3203E70 Offset: 0x3203F71 VA: 0x3203E70
	|-EqualityComparer<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3204A00 Offset: 0x3204B01 VA: 0x3204A00
	|-EqualityComparer<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3205540 Offset: 0x3205641 VA: 0x3205540
	|-EqualityComparer<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32060D0 Offset: 0x32061D1 VA: 0x32060D0
	|-EqualityComparer<ProfilerFrame>.IndexOf
	|
	|-RVA: 0x3206CA0 Offset: 0x3206DA1 VA: 0x3206CA0
	|-EqualityComparer<NumberControl.ValueRange>.IndexOf
	|
	|-RVA: 0x3207810 Offset: 0x3207911 VA: 0x3207810
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x3208460 Offset: 0x3208561 VA: 0x3208460
	|-EqualityComparer<Schedule>.IndexOf
	|
	|-RVA: 0x32090B0 Offset: 0x32091B1 VA: 0x32090B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3209C20 Offset: 0x3209D21 VA: 0x3209C20
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x320A7B0 Offset: 0x320A8B1 VA: 0x320A7B0
	|-EqualityComparer<CurveSample>.IndexOf
	|
	|-RVA: 0x320B550 Offset: 0x320B651 VA: 0x320B550
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x320C0A0 Offset: 0x320C1A1 VA: 0x320C0A0
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x320D720 Offset: 0x320D821 VA: 0x320D720
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x320E290 Offset: 0x320E391 VA: 0x320E290
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x320EDD0 Offset: 0x320EED1 VA: 0x320EDD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x320F940 Offset: 0x320FA41 VA: 0x320F940
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3210480 Offset: 0x3210581 VA: 0x3210480
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3210FF0 Offset: 0x32110F1 VA: 0x3210FF0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3211B30 Offset: 0x3211C31 VA: 0x3211B30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x32126A0 Offset: 0x32127A1 VA: 0x32126A0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x32131F0 Offset: 0x32132F1 VA: 0x32131F0
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3213D60 Offset: 0x3213E61 VA: 0x3213D60
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x32148A0 Offset: 0x32149A1 VA: 0x32148A0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x32153E0 Offset: 0x32154E1 VA: 0x32153E0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3216A60 Offset: 0x3216B61 VA: 0x3216A60
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x32175D0 Offset: 0x32176D1 VA: 0x32175D0
	|-EqualityComparer<Memory<object>>.IndexOf
	|
	|-RVA: 0x3218140 Offset: 0x3218241 VA: 0x3218140
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.IndexOf
	|
	|-RVA: 0x3218E30 Offset: 0x3218F31 VA: 0x3218E30
	|-EqualityComparer<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3219980 Offset: 0x3219A81 VA: 0x3219980
	|-EqualityComparer<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x321A670 Offset: 0x321A771 VA: 0x321A670
	|-EqualityComparer<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x321B360 Offset: 0x321B461 VA: 0x321B360
	|-EqualityComparer<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x32C9B70 Offset: 0x32C9C71 VA: 0x32C9B70
	|-EqualityComparer<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x32CA7F0 Offset: 0x32CA8F1 VA: 0x32CA7F0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-EqualityComparer<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x32CC010 Offset: 0x32CC111 VA: 0x32CC010
	|-EqualityComparer<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x32CCC90 Offset: 0x32CCD91 VA: 0x32CCC90
	|-EqualityComparer<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x32CD7E0 Offset: 0x32CD8E1 VA: 0x32CD7E0
	|-EqualityComparer<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32CE5E0 Offset: 0x32CE6E1 VA: 0x32CE5E0
	|-EqualityComparer<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32CF260 Offset: 0x32CF361 VA: 0x32CF260
	|-EqualityComparer<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32CFE00 Offset: 0x32CFF01 VA: 0x32CFE00
	|-EqualityComparer<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x32D0A80 Offset: 0x32D0B81 VA: 0x32D0A80
	|-EqualityComparer<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x32D1700 Offset: 0x32D1801 VA: 0x32D1700
	|-EqualityComparer<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32D22A0 Offset: 0x32D23A1 VA: 0x32D22A0
	|-EqualityComparer<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32D2E40 Offset: 0x32D2F41 VA: 0x32D2E40
	|-EqualityComparer<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x32D39B0 Offset: 0x32D3AB1 VA: 0x32D39B0
	|-EqualityComparer<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-EqualityComparer<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x32D51A0 Offset: 0x32D52A1 VA: 0x32D51A0
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-EqualityComparer<ReadOnlyMemory<object>>.IndexOf
	|
	|-RVA: 0x32D6830 Offset: 0x32D6931 VA: 0x32D6830
	|-EqualityComparer<Label>.IndexOf
	|
	|-RVA: 0x32D7370 Offset: 0x32D7471 VA: 0x32D7370
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x32D7EE0 Offset: 0x32D7FE1 VA: 0x32D7EE0
	|-EqualityComparer<RuntimeTypeHandle>.IndexOf
	|
	|-RVA: 0x32D8A20 Offset: 0x32D8B21 VA: 0x32D8A20
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x32D9560 Offset: 0x32D9661 VA: 0x32D9560
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x32DA0B0 Offset: 0x32DA1B1 VA: 0x32DA0B0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x32DABF0 Offset: 0x32DACF1 VA: 0x32DABF0
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x32DB730 Offset: 0x32DB831 VA: 0x32DB730
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x32DC270 Offset: 0x32DC371 VA: 0x32DC270
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DCDB0 Offset: 0x32DCEB1 VA: 0x32DCDB0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32DE460 Offset: 0x32DE561 VA: 0x32DE460
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DEFD0 Offset: 0x32DF0D1 VA: 0x32DEFD0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32DFB40 Offset: 0x32DFC41 VA: 0x32DFB40
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32E06B0 Offset: 0x32E07B1 VA: 0x32E06B0
	|-EqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x32E1220 Offset: 0x32E1321 VA: 0x32E1220
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32E1DB0 Offset: 0x32E1EB1 VA: 0x32E1DB0
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32E3810 Offset: 0x32E3911 VA: 0x32E3810
	|-EqualityComparer<TransitionTables>.IndexOf
	|
	|-RVA: 0x32E4460 Offset: 0x32E4561 VA: 0x32E4460
	|-EqualityComparer<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32E4FF0 Offset: 0x32E50F1 VA: 0x32E4FF0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32E5B60 Offset: 0x32E5C61 VA: 0x32E5B60
	|-EqualityComparer<CapEdge>.IndexOf
	|
	|-RVA: 0x30F1C00 Offset: 0x30F1D01 VA: 0x30F1C00
	|-EqualityComparer<ClippedEdge>.IndexOf
	|
	|-RVA: 0x30F2850 Offset: 0x30F2951 VA: 0x30F2850
	|-EqualityComparer<EdgeKeyByHash>.IndexOf
	|
	|-RVA: 0x30F3390 Offset: 0x30F3491 VA: 0x30F3390
	|-EqualityComparer<EdgeKeyByIndex>.IndexOf
	|
	|-RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	|-EqualityComparer<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x30F4A10 Offset: 0x30F4B11 VA: 0x30F4A10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x30F5660 Offset: 0x30F5761 VA: 0x30F5660
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x30F6320 Offset: 0x30F6421 VA: 0x30F6320
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x30F6E90 Offset: 0x30F6F91 VA: 0x30F6E90
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x30F7D10 Offset: 0x30F7E11 VA: 0x30F7D10
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x30F8880 Offset: 0x30F8981 VA: 0x30F8880
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x30F93C0 Offset: 0x30F94C1 VA: 0x30F93C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x30F9F30 Offset: 0x30FA031 VA: 0x30F9F30
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x30FAB80 Offset: 0x30FAC81 VA: 0x30FAB80
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x30FB7D0 Offset: 0x30FB8D1 VA: 0x30FB7D0
	|-EqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x30FC420 Offset: 0x30FC521 VA: 0x30FC420
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x30FCF60 Offset: 0x30FD061 VA: 0x30FCF60
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x30FDB30 Offset: 0x30FDC31 VA: 0x30FDB30
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x30FE9B0 Offset: 0x30FEAB1 VA: 0x30FE9B0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x30FF750 Offset: 0x30FF851 VA: 0x30FF750
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	|
	|-RVA: 0x3100290 Offset: 0x3100391 VA: 0x3100290
	|-EqualityComparer<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x3100E00 Offset: 0x3100F01 VA: 0x3100E00
	|-EqualityComparer<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3101A50 Offset: 0x3101B51 VA: 0x3101A50
	|-EqualityComparer<Keyframe>.IndexOf
	|
	|-RVA: 0x3102710 Offset: 0x3102811 VA: 0x3102710
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3103250 Offset: 0x3103351 VA: 0x3103250
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3103F80 Offset: 0x3104081 VA: 0x3103F80
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3104C00 Offset: 0x3104D01 VA: 0x3104C00
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3105770 Offset: 0x3105871 VA: 0x3105770
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	|-EqualityComparer<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3106F30 Offset: 0x3107031 VA: 0x3106F30
	|-EqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x3107A70 Offset: 0x3107B71 VA: 0x3107A70
	|-EqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x3108640 Offset: 0x3108741 VA: 0x3108640
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3109210 Offset: 0x3109311 VA: 0x3109210
	|-EqualityComparer<RangeInt>.IndexOf
	|
	|-RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x310AA40 Offset: 0x310AB41 VA: 0x310AA40
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x310B770 Offset: 0x310B871 VA: 0x310B770
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x310C340 Offset: 0x310C441 VA: 0x310C340
	|-EqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x310CEB0 Offset: 0x310CFB1 VA: 0x310CEB0
	|-EqualityComparer<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x310DA20 Offset: 0x310DB21 VA: 0x310DA20
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x310E920 Offset: 0x310EA21 VA: 0x310E920
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x310F490 Offset: 0x310F591 VA: 0x310F490
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x2EA77F0 Offset: 0x2EA78F1 VA: 0x2EA77F0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EA8440 Offset: 0x2EA8541 VA: 0x2EA8440
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EA9090 Offset: 0x2EA9191 VA: 0x2EA9090
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2EA9D50 Offset: 0x2EA9E51 VA: 0x2EA9D50
	|-EqualityComparer<SceneInstance>.IndexOf
	|
	|-RVA: 0x2EAA8C0 Offset: 0x2EAA9C1 VA: 0x2EAA8C0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2EAB510 Offset: 0x2EAB611 VA: 0x2EAB510
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2EAC1D0 Offset: 0x2EAC2D1 VA: 0x2EAC1D0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EACD40 Offset: 0x2EACE41 VA: 0x2EACD40
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2EADA10 Offset: 0x2EADB11 VA: 0x2EADA10
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2EAE660 Offset: 0x2EAE761 VA: 0x2EAE660
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2EAF2B0 Offset: 0x2EAF3B1 VA: 0x2EAF2B0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2EAFF00 Offset: 0x2EB0001 VA: 0x2EAFF00
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EB0D10 Offset: 0x2EB0E11 VA: 0x2EB0D10
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EB2630 Offset: 0x2EB2731 VA: 0x2EB2630
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x2EB3200 Offset: 0x2EB3301 VA: 0x2EB3200
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|
	|-RVA: 0x2EB3D70 Offset: 0x2EB3E71 VA: 0x2EB3D70
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2EB48E0 Offset: 0x2EB49E1 VA: 0x2EB48E0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|
	|-RVA: 0x2EB5420 Offset: 0x2EB5521 VA: 0x2EB5420
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x2EB5F90 Offset: 0x2EB6091 VA: 0x2EB5F90
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x2EB6DA0 Offset: 0x2EB6EA1 VA: 0x2EB6DA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2EB79F0 Offset: 0x2EB7AF1 VA: 0x2EB79F0
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EB8560 Offset: 0x2EB8661 VA: 0x2EB8560
	|-EqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EB90A0 Offset: 0x2EB91A1 VA: 0x2EB90A0
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EB9C70 Offset: 0x2EB9D71 VA: 0x2EB9C70
	|-EqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EBA800 Offset: 0x2EBA901 VA: 0x2EBA800
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2EBB3D0 Offset: 0x2EBB4D1 VA: 0x2EBB3D0
	|-EqualityComparer<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2EBC2C0 Offset: 0x2EBC3C1 VA: 0x2EBC2C0
	|-EqualityComparer<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2EBCE00 Offset: 0x2EBCF01 VA: 0x2EBCE00
	|-EqualityComparer<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EA30 Offset: 0x2E3EB31 VA: 0x2E3EA30
	|-EqualityComparer<AS_ToolController.ChargeInfo>.LastIndexOf
	|
	|-RVA: 0x2E3F630 Offset: 0x2E3F731 VA: 0x2E3F630
	|-EqualityComparer<JSONDeserialization.TaskField>.LastIndexOf
	|
	|-RVA: 0x2E40190 Offset: 0x2E40291 VA: 0x2E40190
	|-EqualityComparer<BitVector32Int>.LastIndexOf
	|
	|-RVA: 0x2E40DF0 Offset: 0x2E40EF1 VA: 0x2E40DF0
	|-EqualityComparer<BuildItemData>.LastIndexOf
	|
	|-RVA: 0x2E41BD0 Offset: 0x2E41CD1 VA: 0x2E41BD0
	|-EqualityComparer<ButtonLinker.LinkObject>.LastIndexOf
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-EqualityComparer<CharaCallTable.BustupTable>.LastIndexOf
	|
	|-RVA: 0x2E432C0 Offset: 0x2E433C1 VA: 0x2E432C0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.LastIndexOf
	|
	|-RVA: 0x2E43E40 Offset: 0x2E43F41 VA: 0x2E43E40
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x2E449A0 Offset: 0x2E44AA1 VA: 0x2E449A0
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x2E454E0 Offset: 0x2E455E1 VA: 0x2E454E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x2E460A0 Offset: 0x2E461A1 VA: 0x2E460A0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x2E46D70 Offset: 0x2E46E71 VA: 0x2E46D70
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x2E47A30 Offset: 0x2E47B31 VA: 0x2E47A30
	|-EqualityComparer<CropDataTable>.LastIndexOf
	|
	|-RVA: 0x2E48630 Offset: 0x2E48731 VA: 0x2E48630
	|-EqualityComparer<DropItemParam>.LastIndexOf
	|
	|-RVA: 0x2E491D0 Offset: 0x2E492D1 VA: 0x2E491D0
	|-EqualityComparer<EffectDataTable>.LastIndexOf
	|
	|-RVA: 0x2E49E20 Offset: 0x2E49F21 VA: 0x2E49E20
	|-EqualityComparer<ErosionBrush.UndoStep>.LastIndexOf
	|
	|-RVA: 0x2E4AA70 Offset: 0x2E4AB71 VA: 0x2E4AA70
	|-EqualityComparer<EventCheckId>.LastIndexOf
	|
	|-RVA: 0x2E4B670 Offset: 0x2E4B771 VA: 0x2E4B670
	|-EqualityComparer<EventFlagProgressData>.LastIndexOf
	|
	|-RVA: 0x2E4C280 Offset: 0x2E4C381 VA: 0x2E4C280
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.LastIndexOf
	|
	|-RVA: 0x2E4CF90 Offset: 0x2E4D091 VA: 0x2E4CF90
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4DBA0 Offset: 0x2E4DCA1 VA: 0x2E4DBA0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4E720 Offset: 0x2E4E821 VA: 0x2E4E720
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4F290 Offset: 0x2E4F391 VA: 0x2E4F290
	|-EqualityComparer<FesNpcScoreData>.LastIndexOf
	|
	|-RVA: 0x2E4FDF0 Offset: 0x2E4FEF1 VA: 0x2E4FDF0
	|-EqualityComparer<GimmickLayoutDataTable>.LastIndexOf
	|
	|-RVA: 0x2E509D0 Offset: 0x2E50AD1 VA: 0x2E509D0
	|-EqualityComparer<MineTypeDataTable>.LastIndexOf
	|
	|-RVA: 0x2E51670 Offset: 0x2E51771 VA: 0x2E51670
	|-EqualityComparer<MiningDataTable>.LastIndexOf
	|
	|-RVA: 0x2E52260 Offset: 0x2E52361 VA: 0x2E52260
	|-EqualityComparer<MiningPointSaveData>.LastIndexOf
	|
	|-RVA: 0x2E52F20 Offset: 0x2E53021 VA: 0x2E52F20
	|-EqualityComparer<MonsterDataTable>.LastIndexOf
	|
	|-RVA: 0x2E53BC0 Offset: 0x2E53CC1 VA: 0x2E53BC0
	|-EqualityComparer<MonsterFootStepEventDataTable>.LastIndexOf
	|
	|-RVA: 0x2E54880 Offset: 0x2E54981 VA: 0x2E54880
	|-EqualityComparer<MonsterHutSaveData>.LastIndexOf
	|
	|-RVA: 0x2E554E0 Offset: 0x2E555E1 VA: 0x2E554E0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.LastIndexOf
	|
	|-RVA: 0x2E560E0 Offset: 0x2E561E1 VA: 0x2E560E0
	|-EqualityComparer<NPCActionData>.LastIndexOf
	|
	|-RVA: 0x2E56DD0 Offset: 0x2E56ED1 VA: 0x2E56DD0
	|-EqualityComparer<NpcPlaceSchedule>.LastIndexOf
	|
	|-RVA: 0x2E579E0 Offset: 0x2E57AE1 VA: 0x2E579E0
	|-EqualityComparer<OrderLotterySaveParameter>.LastIndexOf
	|
	|-RVA: 0x31FEB00 Offset: 0x31FEC01 VA: 0x31FEB00
	|-EqualityComparer<OrderSaveData>.LastIndexOf
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-EqualityComparer<OrderSaveParameter>.LastIndexOf
	|
	|-RVA: 0x32003B0 Offset: 0x32004B1 VA: 0x32003B0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3200F70 Offset: 0x3201071 VA: 0x3200F70
	|-EqualityComparer<Parameter>.LastIndexOf
	|
	|-RVA: 0x3201BA0 Offset: 0x3201CA1 VA: 0x3201BA0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.LastIndexOf
	|
	|-RVA: 0x3202710 Offset: 0x3202811 VA: 0x3202710
	|-EqualityComparer<ShopCatalogPage>.LastIndexOf
	|
	|-RVA: 0x32032F0 Offset: 0x32033F1 VA: 0x32032F0
	|-EqualityComparer<ShopNpcTalk>.LastIndexOf
	|
	|-RVA: 0x3203F50 Offset: 0x3204051 VA: 0x3203F50
	|-EqualityComparer<SubtitleDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x3204AC0 Offset: 0x3204BC1 VA: 0x3204AC0
	|-EqualityComparer<SubtitleDataTable.DataList>.LastIndexOf
	|
	|-RVA: 0x3205620 Offset: 0x3205721 VA: 0x3205620
	|-EqualityComparer<SubtitleHudDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x32061C0 Offset: 0x32062C1 VA: 0x32061C0
	|-EqualityComparer<ProfilerFrame>.LastIndexOf
	|
	|-RVA: 0x3206D70 Offset: 0x3206E71 VA: 0x3206D70
	|-EqualityComparer<NumberControl.ValueRange>.LastIndexOf
	|
	|-RVA: 0x3207930 Offset: 0x3207A31 VA: 0x3207930
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.LastIndexOf
	|
	|-RVA: 0x3208580 Offset: 0x3208681 VA: 0x3208580
	|-EqualityComparer<Schedule>.LastIndexOf
	|
	|-RVA: 0x3209180 Offset: 0x3209281 VA: 0x3209180
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3209D00 Offset: 0x3209E01 VA: 0x3209D00
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x320A930 Offset: 0x320AA31 VA: 0x320A930
	|-EqualityComparer<CurveSample>.LastIndexOf
	|
	|-RVA: 0x320B610 Offset: 0x320B711 VA: 0x320B610
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x320C160 Offset: 0x320C261 VA: 0x320C160
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x320CCA0 Offset: 0x320CDA1 VA: 0x320CCA0
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x320D7F0 Offset: 0x320D8F1 VA: 0x320D7F0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x320E350 Offset: 0x320E451 VA: 0x320E350
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x320FA00 Offset: 0x320FB01 VA: 0x320FA00
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3210550 Offset: 0x3210651 VA: 0x3210550
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x32110B0 Offset: 0x32111B1 VA: 0x32110B0
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3211C00 Offset: 0x3211D01 VA: 0x3211C00
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3212760 Offset: 0x3212861 VA: 0x3212760
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x32132C0 Offset: 0x32133C1 VA: 0x32132C0
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3213E20 Offset: 0x3213F21 VA: 0x3213E20
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3214960 Offset: 0x3214A61 VA: 0x3214960
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3215FE0 Offset: 0x32160E1 VA: 0x3215FE0
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3216B30 Offset: 0x3216C31 VA: 0x3216B30
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x32176A0 Offset: 0x32177A1 VA: 0x32176A0
	|-EqualityComparer<Memory<object>>.LastIndexOf
	|
	|-RVA: 0x3218280 Offset: 0x3218381 VA: 0x3218280
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.LastIndexOf
	|
	|-RVA: 0x3218EF0 Offset: 0x3218FF1 VA: 0x3218EF0
	|-EqualityComparer<Nullable<Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x3219AC0 Offset: 0x3219BC1 VA: 0x3219AC0
	|-EqualityComparer<Nullable<Bounds>>.LastIndexOf
	|
	|-RVA: 0x321A7B0 Offset: 0x321A8B1 VA: 0x321A7B0
	|-EqualityComparer<Nullable<BoundsInt>>.LastIndexOf
	|
	|-RVA: 0x321B420 Offset: 0x321B521 VA: 0x321B420
	|-EqualityComparer<Nullable<Color32>>.LastIndexOf
	|
	|-RVA: 0x32C9C90 Offset: 0x32C9D91 VA: 0x32C9C90
	|-EqualityComparer<Nullable<Color>>.LastIndexOf
	|
	|-RVA: 0x32CA8D0 Offset: 0x32CA9D1 VA: 0x32CA8D0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.LastIndexOf
	|
	|-RVA: 0x32CB4B0 Offset: 0x32CB5B1 VA: 0x32CB4B0
	|-EqualityComparer<Nullable<GradientColorKey>>.LastIndexOf
	|
	|-RVA: 0x32CC130 Offset: 0x32CC231 VA: 0x32CC130
	|-EqualityComparer<Nullable<Keyframe>>.LastIndexOf
	|
	|-RVA: 0x32CCD50 Offset: 0x32CCE51 VA: 0x32CCD50
	|-EqualityComparer<Nullable<LayerMask>>.LastIndexOf
	|
	|-RVA: 0x32CD970 Offset: 0x32CDA71 VA: 0x32CD970
	|-EqualityComparer<Nullable<Matrix4x4>>.LastIndexOf
	|
	|-RVA: 0x32CE700 Offset: 0x32CE801 VA: 0x32CE700
	|-EqualityComparer<Nullable<Quaternion>>.LastIndexOf
	|
	|-RVA: 0x32CF340 Offset: 0x32CF441 VA: 0x32CF340
	|-EqualityComparer<Nullable<RangeInt>>.LastIndexOf
	|
	|-RVA: 0x32CFF20 Offset: 0x32D0021 VA: 0x32CFF20
	|-EqualityComparer<Nullable<Rect>>.LastIndexOf
	|
	|-RVA: 0x32D0BA0 Offset: 0x32D0CA1 VA: 0x32D0BA0
	|-EqualityComparer<Nullable<RectInt>>.LastIndexOf
	|
	|-RVA: 0x32D17E0 Offset: 0x32D18E1 VA: 0x32D17E0
	|-EqualityComparer<Nullable<Vector2>>.LastIndexOf
	|
	|-RVA: 0x32D2380 Offset: 0x32D2481 VA: 0x32D2380
	|-EqualityComparer<Nullable<Vector2Int>>.LastIndexOf
	|
	|-RVA: 0x32D2F10 Offset: 0x32D3011 VA: 0x32D2F10
	|-EqualityComparer<Nullable<Vector3>>.LastIndexOf
	|
	|-RVA: 0x32D3A80 Offset: 0x32D3B81 VA: 0x32D3A80
	|-EqualityComparer<Nullable<Vector3Int>>.LastIndexOf
	|
	|-RVA: 0x32D4640 Offset: 0x32D4741 VA: 0x32D4640
	|-EqualityComparer<Nullable<Vector4>>.LastIndexOf
	|
	|-RVA: 0x32D5260 Offset: 0x32D5361 VA: 0x32D5260
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x32D5D90 Offset: 0x32D5E91 VA: 0x32D5D90
	|-EqualityComparer<ReadOnlyMemory<object>>.LastIndexOf
	|
	|-RVA: 0x32D68F0 Offset: 0x32D69F1 VA: 0x32D68F0
	|-EqualityComparer<Label>.LastIndexOf
	|
	|-RVA: 0x32D7440 Offset: 0x32D7541 VA: 0x32D7440
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x32D7FA0 Offset: 0x32D80A1 VA: 0x32D7FA0
	|-EqualityComparer<RuntimeTypeHandle>.LastIndexOf
	|
	|-RVA: 0x32D8AE0 Offset: 0x32D8BE1 VA: 0x32D8AE0
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x32D9620 Offset: 0x32D9721 VA: 0x32D9620
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x32DACB0 Offset: 0x32DADB1 VA: 0x32DACB0
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x32DC330 Offset: 0x32DC431 VA: 0x32DC330
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DCE70 Offset: 0x32DCF71 VA: 0x32DCE70
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x32DD9C0 Offset: 0x32DDAC1 VA: 0x32DD9C0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x32DE530 Offset: 0x32DE631 VA: 0x32DE530
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DF0A0 Offset: 0x32DF1A1 VA: 0x32DF0A0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x32DFC10 Offset: 0x32DFD11 VA: 0x32DFC10
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x32E0780 Offset: 0x32E0881 VA: 0x32E0780
	|-EqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x32E1300 Offset: 0x32E1401 VA: 0x32E1300
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32E1F10 Offset: 0x32E2011 VA: 0x32E1F10
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x32E2C40 Offset: 0x32E2D41 VA: 0x32E2C40
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-EqualityComparer<TransitionTables>.LastIndexOf
	|
	|-RVA: 0x32E4540 Offset: 0x32E4641 VA: 0x32E4540
	|-EqualityComparer<TutorialUnlockFlagData>.LastIndexOf
	|
	|-RVA: 0x32E50C0 Offset: 0x32E51C1 VA: 0x32E50C0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.LastIndexOf
	|
	|-RVA: 0x32E5CB0 Offset: 0x32E5DB1 VA: 0x32E5CB0
	|-EqualityComparer<CapEdge>.LastIndexOf
	|
	|-RVA: 0x30F1D20 Offset: 0x30F1E21 VA: 0x30F1D20
	|-EqualityComparer<ClippedEdge>.LastIndexOf
	|
	|-RVA: 0x30F2910 Offset: 0x30F2A11 VA: 0x30F2910
	|-EqualityComparer<EdgeKeyByHash>.LastIndexOf
	|
	|-RVA: 0x30F3450 Offset: 0x30F3551 VA: 0x30F3450
	|-EqualityComparer<EdgeKeyByIndex>.LastIndexOf
	|
	|-RVA: 0x30F3F90 Offset: 0x30F4091 VA: 0x30F3F90
	|-EqualityComparer<MeshDataConnectivity.Face>.LastIndexOf
	|
	|-RVA: 0x30F4B30 Offset: 0x30F4C31 VA: 0x30F4B30
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.LastIndexOf
	|
	|-RVA: 0x30F57A0 Offset: 0x30F58A1 VA: 0x30F57A0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.LastIndexOf
	|
	|-RVA: 0x30F63F0 Offset: 0x30F64F1 VA: 0x30F63F0
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|
	|-RVA: 0x30F7050 Offset: 0x30F7151 VA: 0x30F7050
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|
	|-RVA: 0x30F7DE0 Offset: 0x30F7EE1 VA: 0x30F7DE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x30F8940 Offset: 0x30F8A41 VA: 0x30F8940
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x30F9490 Offset: 0x30F9591 VA: 0x30F9490
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x30FA050 Offset: 0x30FA151 VA: 0x30FA050
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x30FACA0 Offset: 0x30FADA1 VA: 0x30FACA0
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x30FB8F0 Offset: 0x30FB9F1 VA: 0x30FB8F0
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x30FC4E0 Offset: 0x30FC5E1 VA: 0x30FC4E0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x30FD050 Offset: 0x30FD151 VA: 0x30FD050
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x30FDCF0 Offset: 0x30FDDF1 VA: 0x30FDCF0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x30FEB30 Offset: 0x30FEC31 VA: 0x30FEB30
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x30FF810 Offset: 0x30FF911 VA: 0x30FF810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	|
	|-RVA: 0x3100360 Offset: 0x3100461 VA: 0x3100360
	|-EqualityComparer<GradientAlphaKey>.LastIndexOf
	|
	|-RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	|-EqualityComparer<GradientColorKey>.LastIndexOf
	|
	|-RVA: 0x3101B90 Offset: 0x3101C91 VA: 0x3101B90
	|-EqualityComparer<Keyframe>.LastIndexOf
	|
	|-RVA: 0x31027D0 Offset: 0x31028D1 VA: 0x31027D0
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x31033B0 Offset: 0x31034B1 VA: 0x31033B0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x31040A0 Offset: 0x31041A1 VA: 0x31040A0
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3104CD0 Offset: 0x3104DD1 VA: 0x3104CD0
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3105890 Offset: 0x3105991 VA: 0x3105890
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3106490 Offset: 0x3106591 VA: 0x3106490
	|-EqualityComparer<PlayableGraph>.LastIndexOf
	|
	|-RVA: 0x3106FF0 Offset: 0x31070F1 VA: 0x3106FF0
	|-EqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x3107B60 Offset: 0x3107C61 VA: 0x3107B60
	|-EqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x3108730 Offset: 0x3108831 VA: 0x3108730
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x31092D0 Offset: 0x31093D1 VA: 0x31092D0
	|-EqualityComparer<RangeInt>.LastIndexOf
	|
	|-RVA: 0x3109EA0 Offset: 0x3109FA1 VA: 0x3109EA0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x310ABA0 Offset: 0x310ACA1 VA: 0x310ABA0
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x310B860 Offset: 0x310B961 VA: 0x310B860
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x310C410 Offset: 0x310C511 VA: 0x310C410
	|-EqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x310CF80 Offset: 0x310D081 VA: 0x310CF80
	|-EqualityComparer<ReflectionProbeBlendInfo>.LastIndexOf
	|
	|-RVA: 0x310DC00 Offset: 0x310DD01 VA: 0x310DC00
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x310E9F0 Offset: 0x310EAF1 VA: 0x310E9F0
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x310F5B0 Offset: 0x310F6B1 VA: 0x310F5B0
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x2EA7910 Offset: 0x2EA7A11 VA: 0x2EA7910
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EA8560 Offset: 0x2EA8661 VA: 0x2EA8560
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EA91D0 Offset: 0x2EA92D1 VA: 0x2EA91D0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x2EA9E20 Offset: 0x2EA9F21 VA: 0x2EA9E20
	|-EqualityComparer<SceneInstance>.LastIndexOf
	|
	|-RVA: 0x2EAA9E0 Offset: 0x2EAAAE1 VA: 0x2EAA9E0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x2EAB650 Offset: 0x2EAB751 VA: 0x2EAB650
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x2EAC2A0 Offset: 0x2EAC3A1 VA: 0x2EAC2A0
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EACE80 Offset: 0x2EACF81 VA: 0x2EACE80
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x2EADB30 Offset: 0x2EADC31 VA: 0x2EADB30
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x2EAE780 Offset: 0x2EAE881 VA: 0x2EAE780
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2EAF3D0 Offset: 0x2EAF4D1 VA: 0x2EAF3D0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EB0E50 Offset: 0x2EB0F51 VA: 0x2EB0E50
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EB1B00 Offset: 0x2EB1C01 VA: 0x2EB1B00
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EB2720 Offset: 0x2EB2821 VA: 0x2EB2720
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x2EB32D0 Offset: 0x2EB33D1 VA: 0x2EB32D0
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|
	|-RVA: 0x2EB49A0 Offset: 0x2EB4AA1 VA: 0x2EB49A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|
	|-RVA: 0x2EB54F0 Offset: 0x2EB55F1 VA: 0x2EB54F0
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x2EB6130 Offset: 0x2EB6231 VA: 0x2EB6130
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x2EB6EC0 Offset: 0x2EB6FC1 VA: 0x2EB6EC0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x2EB7AC0 Offset: 0x2EB7BC1 VA: 0x2EB7AC0
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EB8620 Offset: 0x2EB8721 VA: 0x2EB8620
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EB9190 Offset: 0x2EB9291 VA: 0x2EB9190
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EB9D50 Offset: 0x2EB9E51 VA: 0x2EB9D50
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EBA8F0 Offset: 0x2EBA9F1 VA: 0x2EBA8F0
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2EBB5B0 Offset: 0x2EBB6B1 VA: 0x2EBB5B0
	|-EqualityComparer<WarpPoints.WarpPoint>.LastIndexOf
	|
	|-RVA: 0x2EBC380 Offset: 0x2EBC481 VA: 0x2EBC380
	|-EqualityComparer<YieldItemParam>.LastIndexOf
	|
	|-RVA: 0x2EBCF20 Offset: 0x2EBD021 VA: 0x2EBCF20
	|-EqualityComparer<stCommand_t>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EB40 Offset: 0x2E3EC41 VA: 0x2E3EB40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E3F700 Offset: 0x2E3F801 VA: 0x2E3F700
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40250 Offset: 0x2E40351 VA: 0x2E40250
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40FC0 Offset: 0x2E410C1 VA: 0x2E40FC0
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E41CA0 Offset: 0x2E41DA1 VA: 0x2E41CA0
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E42810 Offset: 0x2E42911 VA: 0x2E42810
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E43F10 Offset: 0x2E44011 VA: 0x2E43F10
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E44A60 Offset: 0x2E44B61 VA: 0x2E44A60
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E455A0 Offset: 0x2E456A1 VA: 0x2E455A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E461D0 Offset: 0x2E462D1 VA: 0x2E461D0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E46EB0 Offset: 0x2E46FB1 VA: 0x2E46EB0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E47B50 Offset: 0x2E47C51 VA: 0x2E47B50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E486F0 Offset: 0x2E487F1 VA: 0x2E486F0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E492E0 Offset: 0x2E493E1 VA: 0x2E492E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E49F30 Offset: 0x2E4A031 VA: 0x2E49F30
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4AB80 Offset: 0x2E4AC81 VA: 0x2E4AB80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4B740 Offset: 0x2E4B841 VA: 0x2E4B740
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4C3E0 Offset: 0x2E4C4E1 VA: 0x2E4C3E0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4D0A0 Offset: 0x2E4D1A1 VA: 0x2E4D0A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4DC80 Offset: 0x2E4DD81 VA: 0x2E4DC80
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4E7F0 Offset: 0x2E4E8F1 VA: 0x2E4E7F0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4FEB0 Offset: 0x2E4FFB1 VA: 0x2E4FEB0
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E50B20 Offset: 0x2E50C21 VA: 0x2E50B20
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E51740 Offset: 0x2E51841 VA: 0x2E51740
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E523A0 Offset: 0x2E524A1 VA: 0x2E523A0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53040 Offset: 0x2E53141 VA: 0x2E53040
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53CF0 Offset: 0x2E53DF1 VA: 0x2E53CF0
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E549B0 Offset: 0x2E54AB1 VA: 0x2E549B0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E555B0 Offset: 0x2E556B1 VA: 0x2E555B0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56230 Offset: 0x2E56331 VA: 0x2E56230
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56EE0 Offset: 0x2E56FE1 VA: 0x2E56EE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E57AC0 Offset: 0x2E57BC1 VA: 0x2E57AC0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FEC30 Offset: 0x31FED31 VA: 0x31FEC30
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FF8C0 Offset: 0x31FF9C1 VA: 0x31FF8C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3200480 Offset: 0x3200581 VA: 0x3200480
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201090 Offset: 0x3201191 VA: 0x3201090
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201C70 Offset: 0x3201D71 VA: 0x3201C70
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32027E0 Offset: 0x32028E1 VA: 0x32027E0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3203420 Offset: 0x3203521 VA: 0x3203420
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204030 Offset: 0x3204131 VA: 0x3204030
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204B80 Offset: 0x3204C81 VA: 0x3204B80
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3205700 Offset: 0x3205801 VA: 0x3205700
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32062B0 Offset: 0x32063B1 VA: 0x32062B0
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3207A40 Offset: 0x3207B41 VA: 0x3207A40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3208690 Offset: 0x3208791 VA: 0x3208690
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209DE0 Offset: 0x3209EE1 VA: 0x3209DE0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320AAA0 Offset: 0x320ABA1 VA: 0x320AAA0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320B6D0 Offset: 0x320B7D1 VA: 0x320B6D0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320C220 Offset: 0x320C321 VA: 0x320C220
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320CD60 Offset: 0x320CE61 VA: 0x320CD60
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320E410 Offset: 0x320E511 VA: 0x320E410
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320EF70 Offset: 0x320F071 VA: 0x320EF70
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320FAC0 Offset: 0x320FBC1 VA: 0x320FAC0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3210620 Offset: 0x3210721 VA: 0x3210620
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211170 Offset: 0x3211271 VA: 0x3211170
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211CD0 Offset: 0x3211DD1 VA: 0x3211CD0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3212820 Offset: 0x3212921 VA: 0x3212820
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213390 Offset: 0x3213491 VA: 0x3213390
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213EE0 Offset: 0x3213FE1 VA: 0x3213EE0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3214A20 Offset: 0x3214B21 VA: 0x3214A20
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3215560 Offset: 0x3215661 VA: 0x3215560
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32160A0 Offset: 0x32161A1 VA: 0x32160A0
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3216C00 Offset: 0x3216D01 VA: 0x3216C00
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3217770 Offset: 0x3217871 VA: 0x3217770
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32183B0 Offset: 0x32184B1 VA: 0x32183B0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3218FB0 Offset: 0x32190B1 VA: 0x3218FB0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3219BF0 Offset: 0x3219CF1 VA: 0x3219BF0
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321A8E0 Offset: 0x321A9E1 VA: 0x321A8E0
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321B4E0 Offset: 0x321B5E1 VA: 0x321B4E0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32C9DA0 Offset: 0x32C9EA1 VA: 0x32C9DA0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CA9B0 Offset: 0x32CAAB1 VA: 0x32CA9B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CB5C0 Offset: 0x32CB6C1 VA: 0x32CB5C0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CCE10 Offset: 0x32CCF11 VA: 0x32CCE10
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CDAF0 Offset: 0x32CDBF1 VA: 0x32CDAF0
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CE810 Offset: 0x32CE911 VA: 0x32CE810
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CF420 Offset: 0x32CF521 VA: 0x32CF420
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0030 Offset: 0x32D0131 VA: 0x32D0030
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0CB0 Offset: 0x32D0DB1 VA: 0x32D0CB0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D18C0 Offset: 0x32D19C1 VA: 0x32D18C0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2460 Offset: 0x32D2561 VA: 0x32D2460
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2FE0 Offset: 0x32D30E1 VA: 0x32D2FE0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D3B50 Offset: 0x32D3C51 VA: 0x32D3B50
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D4750 Offset: 0x32D4851 VA: 0x32D4750
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5320 Offset: 0x32D5421 VA: 0x32D5320
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5E60 Offset: 0x32D5F61 VA: 0x32D5E60
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D69B0 Offset: 0x32D6AB1 VA: 0x32D69B0
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D7510 Offset: 0x32D7611 VA: 0x32D7510
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8060 Offset: 0x32D8161 VA: 0x32D8060
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8BA0 Offset: 0x32D8CA1 VA: 0x32D8BA0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D96E0 Offset: 0x32D97E1 VA: 0x32D96E0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DA230 Offset: 0x32DA331 VA: 0x32DA230
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DAD70 Offset: 0x32DAE71 VA: 0x32DAD70
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DB8B0 Offset: 0x32DB9B1 VA: 0x32DB8B0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DC3F0 Offset: 0x32DC4F1 VA: 0x32DC3F0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DCF30 Offset: 0x32DD031 VA: 0x32DCF30
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DDA90 Offset: 0x32DDB91 VA: 0x32DDA90
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DF170 Offset: 0x32DF271 VA: 0x32DF170
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DFCE0 Offset: 0x32DFDE1 VA: 0x32DFCE0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E0850 Offset: 0x32E0951 VA: 0x32E0850
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E13E0 Offset: 0x32E14E1 VA: 0x32E13E0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2060 Offset: 0x32E2161 VA: 0x32E2060
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2D90 Offset: 0x32E2E91 VA: 0x32E2D90
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E3A40 Offset: 0x32E3B41 VA: 0x32E3A40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E4620 Offset: 0x32E4721 VA: 0x32E4620
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5190 Offset: 0x32E5291 VA: 0x32E5190
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5DF0 Offset: 0x32E5EF1 VA: 0x32E5DF0
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F1E30 Offset: 0x30F1F31 VA: 0x30F1E30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F29D0 Offset: 0x30F2AD1 VA: 0x30F29D0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F3510 Offset: 0x30F3611 VA: 0x30F3510
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4050 Offset: 0x30F4151 VA: 0x30F4050
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4C40 Offset: 0x30F4D41 VA: 0x30F4C40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F58D0 Offset: 0x30F59D1 VA: 0x30F58D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F64C0 Offset: 0x30F65C1 VA: 0x30F64C0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7200 Offset: 0x30F7301 VA: 0x30F7200
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7EB0 Offset: 0x30F7FB1 VA: 0x30F7EB0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F8A00 Offset: 0x30F8B01 VA: 0x30F8A00
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F9560 Offset: 0x30F9661 VA: 0x30F9560
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FADB0 Offset: 0x30FAEB1 VA: 0x30FADB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FBA00 Offset: 0x30FBB01 VA: 0x30FBA00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FC5A0 Offset: 0x30FC6A1 VA: 0x30FC5A0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FD140 Offset: 0x30FD241 VA: 0x30FD140
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FDEA0 Offset: 0x30FDFA1 VA: 0x30FDEA0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FECA0 Offset: 0x30FEDA1 VA: 0x30FECA0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FF8D0 Offset: 0x30FF9D1 VA: 0x30FF8D0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101030 Offset: 0x3101131 VA: 0x3101030
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101CC0 Offset: 0x3101DC1 VA: 0x3101CC0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3102890 Offset: 0x3102991 VA: 0x3102890
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3103500 Offset: 0x3103601 VA: 0x3103500
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31041C0 Offset: 0x31042C1 VA: 0x31041C0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3104DA0 Offset: 0x3104EA1 VA: 0x3104DA0
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31059A0 Offset: 0x3105AA1 VA: 0x31059A0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3106560 Offset: 0x3106661 VA: 0x3106560
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31070B0 Offset: 0x31071B1 VA: 0x31070B0
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3107C50 Offset: 0x3107D51 VA: 0x3107C50
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3108820 Offset: 0x3108921 VA: 0x3108820
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109390 Offset: 0x3109491 VA: 0x3109390
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109FE0 Offset: 0x310A0E1 VA: 0x3109FE0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310ACF0 Offset: 0x310ADF1 VA: 0x310ACF0
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310B950 Offset: 0x310BA51 VA: 0x310B950
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310C4E0 Offset: 0x310C5E1 VA: 0x310C4E0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310D050 Offset: 0x310D151 VA: 0x310D050
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310DDD0 Offset: 0x310DED1 VA: 0x310DDD0
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310EAC0 Offset: 0x310EBC1 VA: 0x310EAC0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310F6C0 Offset: 0x310F7C1 VA: 0x310F6C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA7A20 Offset: 0x2EA7B21 VA: 0x2EA7A20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA8670 Offset: 0x2EA8771 VA: 0x2EA8670
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9300 Offset: 0x2EA9401 VA: 0x2EA9300
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9EF0 Offset: 0x2EA9FF1 VA: 0x2EA9EF0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAAAF0 Offset: 0x2EAABF1 VA: 0x2EAAAF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAB780 Offset: 0x2EAB881 VA: 0x2EAB780
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAC370 Offset: 0x2EAC471 VA: 0x2EAC370
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EACFB0 Offset: 0x2EAD0B1 VA: 0x2EACFB0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EADC40 Offset: 0x2EADD41 VA: 0x2EADC40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAE890 Offset: 0x2EAE991 VA: 0x2EAE890
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0230 Offset: 0x2EB0331 VA: 0x2EB0230
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0F80 Offset: 0x2EB1081 VA: 0x2EB0F80
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB1C10 Offset: 0x2EB1D11 VA: 0x2EB1C10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB2810 Offset: 0x2EB2911 VA: 0x2EB2810
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB33A0 Offset: 0x2EB34A1 VA: 0x2EB33A0
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB3F10 Offset: 0x2EB4011 VA: 0x2EB3F10
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB4A60 Offset: 0x2EB4B61 VA: 0x2EB4A60
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB55C0 Offset: 0x2EB56C1 VA: 0x2EB55C0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB62C0 Offset: 0x2EB63C1 VA: 0x2EB62C0
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB6FD0 Offset: 0x2EB70D1 VA: 0x2EB6FD0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB7B90 Offset: 0x2EB7C91 VA: 0x2EB7B90
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9280 Offset: 0x2EB9381 VA: 0x2EB9280
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9E30 Offset: 0x2EB9F31 VA: 0x2EB9E30
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBA9E0 Offset: 0x2EBAAE1 VA: 0x2EBA9E0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBB780 Offset: 0x2EBB881 VA: 0x2EBB780
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBC440 Offset: 0x2EBC541 VA: 0x2EBC440
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBD030 Offset: 0x2EBD131 VA: 0x2EBD030
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EC40 Offset: 0x2E3ED41 VA: 0x2E3EC40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E3F7E0 Offset: 0x2E3F8E1 VA: 0x2E3F7E0
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E40330 Offset: 0x2E40431 VA: 0x2E40330
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41120 Offset: 0x2E41221 VA: 0x2E41120
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E428F0 Offset: 0x2E429F1 VA: 0x2E428F0
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43480 Offset: 0x2E43581 VA: 0x2E43480
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43FF0 Offset: 0x2E440F1 VA: 0x2E43FF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E462E0 Offset: 0x2E463E1 VA: 0x2E462E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E46FC0 Offset: 0x2E470C1 VA: 0x2E46FC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E47C50 Offset: 0x2E47D51 VA: 0x2E47C50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E487D0 Offset: 0x2E488D1 VA: 0x2E487D0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E493E0 Offset: 0x2E494E1 VA: 0x2E493E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4A030 Offset: 0x2E4A131 VA: 0x2E4A030
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4AC80 Offset: 0x2E4AD81 VA: 0x2E4AC80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4B820 Offset: 0x2E4B921 VA: 0x2E4B820
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4C500 Offset: 0x2E4C601 VA: 0x2E4C500
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4D1A0 Offset: 0x2E4D2A1 VA: 0x2E4D1A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4DD60 Offset: 0x2E4DE61 VA: 0x2E4DD60
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4E8D0 Offset: 0x2E4E9D1 VA: 0x2E4E8D0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4F440 Offset: 0x2E4F541 VA: 0x2E4F440
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4FF90 Offset: 0x2E50091 VA: 0x2E4FF90
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E50C40 Offset: 0x2E50D41 VA: 0x2E50C40
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E524B0 Offset: 0x2E525B1 VA: 0x2E524B0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53150 Offset: 0x2E53251 VA: 0x2E53150
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53E00 Offset: 0x2E53F01 VA: 0x2E53E00
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E54AC0 Offset: 0x2E54BC1 VA: 0x2E54AC0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E55690 Offset: 0x2E55791 VA: 0x2E55690
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56350 Offset: 0x2E56451 VA: 0x2E56350
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56FE0 Offset: 0x2E570E1 VA: 0x2E56FE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E57BA0 Offset: 0x2E57CA1 VA: 0x2E57BA0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3200560 Offset: 0x3200661 VA: 0x3200560
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32011A0 Offset: 0x32012A1 VA: 0x32011A0
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3201D50 Offset: 0x3201E51 VA: 0x3201D50
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32028C0 Offset: 0x32029C1 VA: 0x32028C0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3203530 Offset: 0x3203631 VA: 0x3203530
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204110 Offset: 0x3204211 VA: 0x3204110
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204C60 Offset: 0x3204D61 VA: 0x3204C60
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32057E0 Offset: 0x32058E1 VA: 0x32057E0
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206390 Offset: 0x3206491 VA: 0x3206390
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206F20 Offset: 0x3207021 VA: 0x3206F20
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3207B40 Offset: 0x3207C41 VA: 0x3207B40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3208790 Offset: 0x3208891 VA: 0x3208790
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209330 Offset: 0x3209431 VA: 0x3209330
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320ABD0 Offset: 0x320ACD1 VA: 0x320ABD0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320B7B0 Offset: 0x320B8B1 VA: 0x320B7B0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320CE40 Offset: 0x320CF41 VA: 0x320CE40
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320D9A0 Offset: 0x320DAA1 VA: 0x320D9A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320E4F0 Offset: 0x320E5F1 VA: 0x320E4F0
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320F050 Offset: 0x320F151 VA: 0x320F050
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320FBA0 Offset: 0x320FCA1 VA: 0x320FBA0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3210700 Offset: 0x3210801 VA: 0x3210700
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211250 Offset: 0x3211351 VA: 0x3211250
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211DB0 Offset: 0x3211EB1 VA: 0x3211DB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3212900 Offset: 0x3212A01 VA: 0x3212900
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213470 Offset: 0x3213571 VA: 0x3213470
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213FC0 Offset: 0x32140C1 VA: 0x3213FC0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3214B00 Offset: 0x3214C01 VA: 0x3214B00
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3215640 Offset: 0x3215741 VA: 0x3215640
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216180 Offset: 0x3216281 VA: 0x3216180
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216CE0 Offset: 0x3216DE1 VA: 0x3216CE0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3217850 Offset: 0x3217951 VA: 0x3217850
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32184E0 Offset: 0x32185E1 VA: 0x32184E0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32190A0 Offset: 0x32191A1 VA: 0x32190A0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3219D20 Offset: 0x3219E21 VA: 0x3219D20
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321AA10 Offset: 0x321AB11 VA: 0x321AA10
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321B5D0 Offset: 0x321B6D1 VA: 0x321B5D0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32C9EC0 Offset: 0x32C9FC1 VA: 0x32C9EC0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CB6E0 Offset: 0x32CB7E1 VA: 0x32CB6E0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CC360 Offset: 0x32CC461 VA: 0x32CC360
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CDC40 Offset: 0x32CDD41 VA: 0x32CDC40
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CE930 Offset: 0x32CEA31 VA: 0x32CE930
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CF510 Offset: 0x32CF611 VA: 0x32CF510
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0150 Offset: 0x32D0251 VA: 0x32D0150
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0DD0 Offset: 0x32D0ED1 VA: 0x32D0DD0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D19B0 Offset: 0x32D1AB1 VA: 0x32D19B0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D2550 Offset: 0x32D2651 VA: 0x32D2550
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D30D0 Offset: 0x32D31D1 VA: 0x32D30D0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D3C40 Offset: 0x32D3D41 VA: 0x32D3C40
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D4870 Offset: 0x32D4971 VA: 0x32D4870
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D53F0 Offset: 0x32D54F1 VA: 0x32D53F0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D5F40 Offset: 0x32D6041 VA: 0x32D5F40
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D6A90 Offset: 0x32D6B91 VA: 0x32D6A90
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D75F0 Offset: 0x32D76F1 VA: 0x32D75F0
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8C80 Offset: 0x32D8D81 VA: 0x32D8C80
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DA310 Offset: 0x32DA411 VA: 0x32DA310
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DAE50 Offset: 0x32DAF51 VA: 0x32DAE50
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DB990 Offset: 0x32DBA91 VA: 0x32DB990
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DC4D0 Offset: 0x32DC5D1 VA: 0x32DC4D0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DD010 Offset: 0x32DD111 VA: 0x32DD010
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DDB70 Offset: 0x32DDC71 VA: 0x32DDB70
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DF250 Offset: 0x32DF351 VA: 0x32DF250
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DFDC0 Offset: 0x32DFEC1 VA: 0x32DFDC0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E0930 Offset: 0x32E0A31 VA: 0x32E0930
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E14C0 Offset: 0x32E15C1 VA: 0x32E14C0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2180 Offset: 0x32E2281 VA: 0x32E2180
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2EB0 Offset: 0x32E2FB1 VA: 0x32E2EB0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E3B40 Offset: 0x32E3C41 VA: 0x32E3B40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E4700 Offset: 0x32E4801 VA: 0x32E4700
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5270 Offset: 0x32E5371 VA: 0x32E5270
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5F00 Offset: 0x32E6001 VA: 0x32E5F00
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F1F30 Offset: 0x30F2031 VA: 0x30F1F30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F2AB0 Offset: 0x30F2BB1 VA: 0x30F2AB0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F35F0 Offset: 0x30F36F1 VA: 0x30F35F0
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4130 Offset: 0x30F4231 VA: 0x30F4130
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4D40 Offset: 0x30F4E41 VA: 0x30F4D40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F59E0 Offset: 0x30F5AE1 VA: 0x30F59E0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7350 Offset: 0x30F7451 VA: 0x30F7350
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7F90 Offset: 0x30F8091 VA: 0x30F7F90
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F8AE0 Offset: 0x30F8BE1 VA: 0x30F8AE0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F9640 Offset: 0x30F9741 VA: 0x30F9640
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FA260 Offset: 0x30FA361 VA: 0x30FA260
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FAEB0 Offset: 0x30FAFB1 VA: 0x30FAEB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FBB00 Offset: 0x30FBC01 VA: 0x30FBB00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FC680 Offset: 0x30FC781 VA: 0x30FC680
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FD220 Offset: 0x30FD321 VA: 0x30FD220
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FDFF0 Offset: 0x30FE0F1 VA: 0x30FDFF0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FEDD0 Offset: 0x30FEED1 VA: 0x30FEDD0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FF9B0 Offset: 0x30FFAB1 VA: 0x30FF9B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3100510 Offset: 0x3100611 VA: 0x3100510
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101130 Offset: 0x3101231 VA: 0x3101130
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101DD0 Offset: 0x3101ED1 VA: 0x3101DD0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3102970 Offset: 0x3102A71 VA: 0x3102970
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3103620 Offset: 0x3103721 VA: 0x3103620
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31042D0 Offset: 0x31043D1 VA: 0x31042D0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3104E80 Offset: 0x3104F81 VA: 0x3104E80
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3105AA0 Offset: 0x3105BA1 VA: 0x3105AA0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3106640 Offset: 0x3106741 VA: 0x3106640
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107190 Offset: 0x3107291 VA: 0x3107190
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107D30 Offset: 0x3107E31 VA: 0x3107D30
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3108900 Offset: 0x3108A01 VA: 0x3108900
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3109470 Offset: 0x3109571 VA: 0x3109470
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310A0F0 Offset: 0x310A1F1 VA: 0x310A0F0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310AE10 Offset: 0x310AF11 VA: 0x310AE10
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310BA30 Offset: 0x310BB31 VA: 0x310BA30
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310C5C0 Offset: 0x310C6C1 VA: 0x310C5C0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310D130 Offset: 0x310D231 VA: 0x310D130
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310DF40 Offset: 0x310E041 VA: 0x310DF40
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310EBA0 Offset: 0x310ECA1 VA: 0x310EBA0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310F7C0 Offset: 0x310F8C1 VA: 0x310F7C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA7B20 Offset: 0x2EA7C21 VA: 0x2EA7B20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA8770 Offset: 0x2EA8871 VA: 0x2EA8770
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9410 Offset: 0x2EA9511 VA: 0x2EA9410
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9FD0 Offset: 0x2EAA0D1 VA: 0x2EA9FD0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAABF0 Offset: 0x2EAACF1 VA: 0x2EAABF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAB890 Offset: 0x2EAB991 VA: 0x2EAB890
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAC450 Offset: 0x2EAC551 VA: 0x2EAC450
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAD0C0 Offset: 0x2EAD1C1 VA: 0x2EAD0C0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAE990 Offset: 0x2EAEA91 VA: 0x2EAE990
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAF5E0 Offset: 0x2EAF6E1 VA: 0x2EAF5E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB0370 Offset: 0x2EB0471 VA: 0x2EB0370
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1090 Offset: 0x2EB1191 VA: 0x2EB1090
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1D10 Offset: 0x2EB1E11 VA: 0x2EB1D10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3480 Offset: 0x2EB3581 VA: 0x2EB3480
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3FF0 Offset: 0x2EB40F1 VA: 0x2EB3FF0
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB4B40 Offset: 0x2EB4C41 VA: 0x2EB4B40
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB56A0 Offset: 0x2EB57A1 VA: 0x2EB56A0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB6400 Offset: 0x2EB6501 VA: 0x2EB6400
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB70D0 Offset: 0x2EB71D1 VA: 0x2EB70D0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB7C70 Offset: 0x2EB7D71 VA: 0x2EB7C70
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB87C0 Offset: 0x2EB88C1 VA: 0x2EB87C0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9360 Offset: 0x2EB9461 VA: 0x2EB9360
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9F10 Offset: 0x2EBA011 VA: 0x2EB9F10
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBAAC0 Offset: 0x2EBABC1 VA: 0x2EBAAC0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBB8E0 Offset: 0x2EBB9E1 VA: 0x2EBB8E0
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBC520 Offset: 0x2EBC621 VA: 0x2EBC520
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EDF0 Offset: 0x2E3EEF1 VA: 0x2E3EDF0
	|-EqualityComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2E3F960 Offset: 0x2E3FA61 VA: 0x2E3F960
	|-EqualityComparer<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x2E404A0 Offset: 0x2E405A1 VA: 0x2E404A0
	|-EqualityComparer<BitVector32Int>..ctor
	|
	|-RVA: 0x2E41390 Offset: 0x2E41491 VA: 0x2E41390
	|-EqualityComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-EqualityComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2E42A70 Offset: 0x2E42B71 VA: 0x2E42A70
	|-EqualityComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2E43600 Offset: 0x2E43701 VA: 0x2E43600
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2E44170 Offset: 0x2E44271 VA: 0x2E44170
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E44CB0 Offset: 0x2E44DB1 VA: 0x2E44CB0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E457F0 Offset: 0x2E458F1 VA: 0x2E457F0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2E471A0 Offset: 0x2E472A1 VA: 0x2E471A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2E47E00 Offset: 0x2E47F01 VA: 0x2E47E00
	|-EqualityComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2E48940 Offset: 0x2E48A41 VA: 0x2E48940
	|-EqualityComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2E49590 Offset: 0x2E49691 VA: 0x2E49590
	|-EqualityComparer<EffectDataTable>..ctor
	|
	|-RVA: 0x2E4A1E0 Offset: 0x2E4A2E1 VA: 0x2E4A1E0
	|-EqualityComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2E4AE30 Offset: 0x2E4AF31 VA: 0x2E4AE30
	|-EqualityComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2E4B9A0 Offset: 0x2E4BAA1 VA: 0x2E4B9A0
	|-EqualityComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2E4C700 Offset: 0x2E4C801 VA: 0x2E4C700
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E4D350 Offset: 0x2E4D451 VA: 0x2E4D350
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E4DEE0 Offset: 0x2E4DFE1 VA: 0x2E4DEE0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E4EA50 Offset: 0x2E4EB51 VA: 0x2E4EA50
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E4F5C0 Offset: 0x2E4F6C1 VA: 0x2E4F5C0
	|-EqualityComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2E50100 Offset: 0x2E50201 VA: 0x2E50100
	|-EqualityComparer<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E50E30 Offset: 0x2E50F31 VA: 0x2E50E30
	|-EqualityComparer<MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E519A0 Offset: 0x2E51AA1 VA: 0x2E519A0
	|-EqualityComparer<MiningDataTable>..ctor
	|
	|-RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	|-EqualityComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2E53310 Offset: 0x2E53411 VA: 0x2E53310
	|-EqualityComparer<MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53FD0 Offset: 0x2E540D1 VA: 0x2E53FD0
	|-EqualityComparer<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54CA0 Offset: 0x2E54DA1 VA: 0x2E54CA0
	|-EqualityComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E55810 Offset: 0x2E55911 VA: 0x2E55810
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	|-EqualityComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2E57190 Offset: 0x2E57291 VA: 0x2E57190
	|-EqualityComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2E57D20 Offset: 0x2E57E21 VA: 0x2E57D20
	|-EqualityComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31FEF20 Offset: 0x31FF021 VA: 0x31FEF20
	|-EqualityComparer<OrderSaveData>..ctor
	|
	|-RVA: 0x31FFB70 Offset: 0x31FFC71 VA: 0x31FFB70
	|-EqualityComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32006E0 Offset: 0x32007E1 VA: 0x32006E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3201360 Offset: 0x3201461 VA: 0x3201360
	|-EqualityComparer<Parameter>..ctor
	|
	|-RVA: 0x3201ED0 Offset: 0x3201FD1 VA: 0x3201ED0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x3202A40 Offset: 0x3202B41 VA: 0x3202A40
	|-EqualityComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x3203700 Offset: 0x3203801 VA: 0x3203700
	|-EqualityComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3204290 Offset: 0x3204391 VA: 0x3204290
	|-EqualityComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3204DD0 Offset: 0x3204ED1 VA: 0x3204DD0
	|-EqualityComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3205960 Offset: 0x3205A61 VA: 0x3205960
	|-EqualityComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3206530 Offset: 0x3206631 VA: 0x3206530
	|-EqualityComparer<ProfilerFrame>..ctor
	|
	|-RVA: 0x32070A0 Offset: 0x32071A1 VA: 0x32070A0
	|-EqualityComparer<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x3207CF0 Offset: 0x3207DF1 VA: 0x3207CF0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x3208940 Offset: 0x3208A41 VA: 0x3208940
	|-EqualityComparer<Schedule>..ctor
	|
	|-RVA: 0x32094B0 Offset: 0x32095B1 VA: 0x32094B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x320A040 Offset: 0x320A141 VA: 0x320A040
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-EqualityComparer<CurveSample>..ctor
	|
	|-RVA: 0x320B930 Offset: 0x320BA31 VA: 0x320B930
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x320C470 Offset: 0x320C571 VA: 0x320C470
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x320CFB0 Offset: 0x320D0B1 VA: 0x320CFB0
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x320DB20 Offset: 0x320DC21 VA: 0x320DB20
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x320E660 Offset: 0x320E761 VA: 0x320E660
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x320F1D0 Offset: 0x320F2D1 VA: 0x320F1D0
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x320FD10 Offset: 0x320FE11 VA: 0x320FD10
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3210880 Offset: 0x3210981 VA: 0x3210880
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32113C0 Offset: 0x32114C1 VA: 0x32113C0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3211F30 Offset: 0x3212031 VA: 0x3211F30
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3212A80 Offset: 0x3212B81 VA: 0x3212A80
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x32135F0 Offset: 0x32136F1 VA: 0x32135F0
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3214130 Offset: 0x3214231 VA: 0x3214130
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3214C70 Offset: 0x3214D71 VA: 0x3214C70
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x32157B0 Offset: 0x32158B1 VA: 0x32157B0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x32162F0 Offset: 0x32163F1 VA: 0x32162F0
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3216E60 Offset: 0x3216F61 VA: 0x3216E60
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x32179D0 Offset: 0x3217AD1 VA: 0x32179D0
	|-EqualityComparer<Memory<object>>..ctor
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3219210 Offset: 0x3219311 VA: 0x3219210
	|-EqualityComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3219F00 Offset: 0x321A001 VA: 0x3219F00
	|-EqualityComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x321ABF0 Offset: 0x321ACF1 VA: 0x321ABF0
	|-EqualityComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x321B740 Offset: 0x321B841 VA: 0x321B740
	|-EqualityComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x32CA080 Offset: 0x32CA181 VA: 0x32CA080
	|-EqualityComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x32CAC20 Offset: 0x32CAD21 VA: 0x32CAC20
	|-EqualityComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x32CB8A0 Offset: 0x32CB9A1 VA: 0x32CB8A0
	|-EqualityComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x32CC520 Offset: 0x32CC621 VA: 0x32CC520
	|-EqualityComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x32CD070 Offset: 0x32CD171 VA: 0x32CD070
	|-EqualityComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x32CDE70 Offset: 0x32CDF71 VA: 0x32CDE70
	|-EqualityComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x32CEAF0 Offset: 0x32CEBF1 VA: 0x32CEAF0
	|-EqualityComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x32CF690 Offset: 0x32CF791 VA: 0x32CF690
	|-EqualityComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x32D0310 Offset: 0x32D0411 VA: 0x32D0310
	|-EqualityComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32D0F90 Offset: 0x32D1091 VA: 0x32D0F90
	|-EqualityComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x32D1B30 Offset: 0x32D1C31 VA: 0x32D1B30
	|-EqualityComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x32D26D0 Offset: 0x32D27D1 VA: 0x32D26D0
	|-EqualityComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x32D3240 Offset: 0x32D3341 VA: 0x32D3240
	|-EqualityComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32D3DB0 Offset: 0x32D3EB1 VA: 0x32D3DB0
	|-EqualityComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x32D4A30 Offset: 0x32D4B31 VA: 0x32D4A30
	|-EqualityComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32D5550 Offset: 0x32D5651 VA: 0x32D5550
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x32D60C0 Offset: 0x32D61C1 VA: 0x32D60C0
	|-EqualityComparer<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x32D6C00 Offset: 0x32D6D01 VA: 0x32D6C00
	|-EqualityComparer<Label>..ctor
	|
	|-RVA: 0x32D7770 Offset: 0x32D7871 VA: 0x32D7770
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x32D82B0 Offset: 0x32D83B1 VA: 0x32D82B0
	|-EqualityComparer<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x32D8DF0 Offset: 0x32D8EF1 VA: 0x32D8DF0
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x32D9940 Offset: 0x32D9A41 VA: 0x32D9940
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x32DA480 Offset: 0x32DA581 VA: 0x32DA480
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x32DAFC0 Offset: 0x32DB0C1 VA: 0x32DAFC0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x32DBB00 Offset: 0x32DBC01 VA: 0x32DBB00
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x32DC640 Offset: 0x32DC741 VA: 0x32DC640
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32DD180 Offset: 0x32DD281 VA: 0x32DD180
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32DDCF0 Offset: 0x32DDDF1 VA: 0x32DDCF0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32DE860 Offset: 0x32DE961 VA: 0x32DE860
	|-EqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32DF3D0 Offset: 0x32DF4D1 VA: 0x32DF3D0
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32E0AB0 Offset: 0x32E0BB1 VA: 0x32E0AB0
	|-EqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x32E1640 Offset: 0x32E1741 VA: 0x32E1640
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32E2370 Offset: 0x32E2471 VA: 0x32E2370
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32E30A0 Offset: 0x32E31A1 VA: 0x32E30A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32E3CF0 Offset: 0x32E3DF1 VA: 0x32E3CF0
	|-EqualityComparer<TransitionTables>..ctor
	|
	|-RVA: 0x32E4880 Offset: 0x32E4981 VA: 0x32E4880
	|-EqualityComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32E60E0 Offset: 0x32E61E1 VA: 0x32E60E0
	|-EqualityComparer<CapEdge>..ctor
	|
	|-RVA: 0x30F20E0 Offset: 0x30F21E1 VA: 0x30F20E0
	|-EqualityComparer<ClippedEdge>..ctor
	|
	|-RVA: 0x30F2C20 Offset: 0x30F2D21 VA: 0x30F2C20
	|-EqualityComparer<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x30F3760 Offset: 0x30F3861 VA: 0x30F3760
	|-EqualityComparer<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x30F42A0 Offset: 0x30F43A1 VA: 0x30F42A0
	|-EqualityComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x30F4EF0 Offset: 0x30F4FF1 VA: 0x30F4EF0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x30F6720 Offset: 0x30F6821 VA: 0x30F6720
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x30F75A0 Offset: 0x30F76A1 VA: 0x30F75A0
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x30F8110 Offset: 0x30F8211 VA: 0x30F8110
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x30F8C50 Offset: 0x30F8D51 VA: 0x30F8C50
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x30F97C0 Offset: 0x30F98C1 VA: 0x30F97C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x30FA410 Offset: 0x30FA511 VA: 0x30FA410
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x30FB060 Offset: 0x30FB161 VA: 0x30FB060
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x30FBCB0 Offset: 0x30FBDB1 VA: 0x30FBCB0
	|-EqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x30FC7F0 Offset: 0x30FC8F1 VA: 0x30FC7F0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x30FD3C0 Offset: 0x30FD4C1 VA: 0x30FD3C0
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x30FE240 Offset: 0x30FE341 VA: 0x30FE240
	|-EqualityComparer<CombineInstance>..ctor
	|
	|-RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x30FFB20 Offset: 0x30FFC21 VA: 0x30FFB20
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x3100690 Offset: 0x3100791 VA: 0x3100690
	|-EqualityComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31012E0 Offset: 0x31013E1 VA: 0x31012E0
	|-EqualityComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x3101FA0 Offset: 0x31020A1 VA: 0x3101FA0
	|-EqualityComparer<Keyframe>..ctor
	|
	|-RVA: 0x3102AE0 Offset: 0x3102BE1 VA: 0x3102AE0
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3103810 Offset: 0x3103911 VA: 0x3103810
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3104490 Offset: 0x3104591 VA: 0x3104490
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3105000 Offset: 0x3105101 VA: 0x3105000
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3105C50 Offset: 0x3105D51 VA: 0x3105C50
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x31067C0 Offset: 0x31068C1 VA: 0x31067C0
	|-EqualityComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x3107300 Offset: 0x3107401 VA: 0x3107300
	|-EqualityComparer<Edge>..ctor
	|
	|-RVA: 0x3107ED0 Offset: 0x3107FD1 VA: 0x3107ED0
	|-EqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x3108AA0 Offset: 0x3108BA1 VA: 0x3108AA0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x31095E0 Offset: 0x31096E1 VA: 0x31095E0
	|-EqualityComparer<RangeInt>..ctor
	|
	|-RVA: 0x310A2D0 Offset: 0x310A3D1 VA: 0x310A2D0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x310B000 Offset: 0x310B101 VA: 0x310B000
	|-EqualityComparer<RaycastHit>..ctor
	|
	|-RVA: 0x310BBD0 Offset: 0x310BCD1 VA: 0x310BBD0
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x310C740 Offset: 0x310C841 VA: 0x310C740
	|-EqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x310D2B0 Offset: 0x310D3B1 VA: 0x310D2B0
	|-EqualityComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x310ED20 Offset: 0x310EE21 VA: 0x310ED20
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x310F970 Offset: 0x310FA71 VA: 0x310F970
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EA7CD0 Offset: 0x2EA7DD1 VA: 0x2EA7CD0
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EA8920 Offset: 0x2EA8A21 VA: 0x2EA8920
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EA95E0 Offset: 0x2EA96E1 VA: 0x2EA95E0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EAA150 Offset: 0x2EAA251 VA: 0x2EAA150
	|-EqualityComparer<SceneInstance>..ctor
	|
	|-RVA: 0x2EAADA0 Offset: 0x2EAAEA1 VA: 0x2EAADA0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2EABA60 Offset: 0x2EABB61 VA: 0x2EABA60
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EAC5D0 Offset: 0x2EAC6D1 VA: 0x2EAC5D0
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EAD2A0 Offset: 0x2EAD3A1 VA: 0x2EAD2A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2EADEF0 Offset: 0x2EADFF1 VA: 0x2EADEF0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EB1270 Offset: 0x2EB1371 VA: 0x2EB1270
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EB1EC0 Offset: 0x2EB1FC1 VA: 0x2EB1EC0
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EB2A90 Offset: 0x2EB2B91 VA: 0x2EB2A90
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x2EB3600 Offset: 0x2EB3701 VA: 0x2EB3600
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2EB4170 Offset: 0x2EB4271 VA: 0x2EB4170
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2EB4CB0 Offset: 0x2EB4DB1 VA: 0x2EB4CB0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2EB5820 Offset: 0x2EB5921 VA: 0x2EB5820
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x2EB6630 Offset: 0x2EB6731 VA: 0x2EB6630
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2EB7DF0 Offset: 0x2EB7EF1 VA: 0x2EB7DF0
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EB8930 Offset: 0x2EB8A31 VA: 0x2EB8930
	|-EqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EB9500 Offset: 0x2EB9601 VA: 0x2EB9500
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EBA090 Offset: 0x2EBA191 VA: 0x2EBA090
	|-EqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EBAC60 Offset: 0x2EBAD61 VA: 0x2EBAC60
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2EBBB50 Offset: 0x2EBBC51 VA: 0x2EBBB50
	|-EqualityComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-EqualityComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x2EBD2E0 Offset: 0x2EBD3E1 VA: 0x2EBD2E0
	|-EqualityComparer<stCommand_t>..ctor
	*/
}

[TypeDependencyAttribute] // RVA: 0xB3A20 Offset: 0xB3B21 VA: 0xB3A20
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1441
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A50 Offset: 0x32D4B51 VA: 0x32D4A50
	|-EqualityComparer<Font>.get_Default
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x2E3E1C0 Offset: 0x2E3E2C1 VA: 0x2E3E1C0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.get_Default
	|
	|-RVA: 0x2E3EE10 Offset: 0x2E3EF11 VA: 0x2E3EE10
	|-EqualityComparer<JSONDeserialization.TaskField>.get_Default
	|
	|-RVA: 0x2E3F980 Offset: 0x2E3FA81 VA: 0x2E3F980
	|-EqualityComparer<BitVector32Int>.get_Default
	|
	|-RVA: 0x2E404C0 Offset: 0x2E405C1 VA: 0x2E404C0
	|-EqualityComparer<BuildItemData>.get_Default
	|
	|-RVA: 0x2E413B0 Offset: 0x2E414B1 VA: 0x2E413B0
	|-EqualityComparer<ButtonLinker.LinkObject>.get_Default
	|
	|-RVA: 0x2E41F20 Offset: 0x2E42021 VA: 0x2E41F20
	|-EqualityComparer<CharaCallTable.BustupTable>.get_Default
	|
	|-RVA: 0x2E42A90 Offset: 0x2E42B91 VA: 0x2E42A90
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.get_Default
	|
	|-RVA: 0x2E43620 Offset: 0x2E43721 VA: 0x2E43620
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x2E44190 Offset: 0x2E44291 VA: 0x2E44190
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x2E44CD0 Offset: 0x2E44DD1 VA: 0x2E44CD0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x2E45810 Offset: 0x2E45911 VA: 0x2E45810
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x2E464D0 Offset: 0x2E465D1 VA: 0x2E464D0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x2E471C0 Offset: 0x2E472C1 VA: 0x2E471C0
	|-EqualityComparer<CropDataTable>.get_Default
	|
	|-RVA: 0x2E47E20 Offset: 0x2E47F21 VA: 0x2E47E20
	|-EqualityComparer<DropItemParam>.get_Default
	|
	|-RVA: 0x2E48960 Offset: 0x2E48A61 VA: 0x2E48960
	|-EqualityComparer<EffectDataTable>.get_Default
	|
	|-RVA: 0x2E495B0 Offset: 0x2E496B1 VA: 0x2E495B0
	|-EqualityComparer<ErosionBrush.UndoStep>.get_Default
	|
	|-RVA: 0x2E4A200 Offset: 0x2E4A301 VA: 0x2E4A200
	|-EqualityComparer<EventCheckId>.get_Default
	|
	|-RVA: 0x2E4AE50 Offset: 0x2E4AF51 VA: 0x2E4AE50
	|-EqualityComparer<EventFlagProgressData>.get_Default
	|
	|-RVA: 0x2E4B9C0 Offset: 0x2E4BAC1 VA: 0x2E4B9C0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.get_Default
	|
	|-RVA: 0x2E4C720 Offset: 0x2E4C821 VA: 0x2E4C720
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.get_Default
	|
	|-RVA: 0x2E4D370 Offset: 0x2E4D471 VA: 0x2E4D370
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.get_Default
	|
	|-RVA: 0x2E4DF00 Offset: 0x2E4E001 VA: 0x2E4DF00
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.get_Default
	|
	|-RVA: 0x2E4EA70 Offset: 0x2E4EB71 VA: 0x2E4EA70
	|-EqualityComparer<FesNpcScoreData>.get_Default
	|
	|-RVA: 0x2E4F5E0 Offset: 0x2E4F6E1 VA: 0x2E4F5E0
	|-EqualityComparer<GimmickLayoutDataTable>.get_Default
	|
	|-RVA: 0x2E50120 Offset: 0x2E50221 VA: 0x2E50120
	|-EqualityComparer<MineTypeDataTable>.get_Default
	|
	|-RVA: 0x2E50E50 Offset: 0x2E50F51 VA: 0x2E50E50
	|-EqualityComparer<MiningDataTable>.get_Default
	|
	|-RVA: 0x2E519C0 Offset: 0x2E51AC1 VA: 0x2E519C0
	|-EqualityComparer<MiningPointSaveData>.get_Default
	|
	|-RVA: 0x2E526B0 Offset: 0x2E527B1 VA: 0x2E526B0
	|-EqualityComparer<MonsterDataTable>.get_Default
	|
	|-RVA: 0x2E53330 Offset: 0x2E53431 VA: 0x2E53330
	|-EqualityComparer<MonsterFootStepEventDataTable>.get_Default
	|
	|-RVA: 0x2E53FF0 Offset: 0x2E540F1 VA: 0x2E53FF0
	|-EqualityComparer<MonsterHutSaveData>.get_Default
	|
	|-RVA: 0x2E54CC0 Offset: 0x2E54DC1 VA: 0x2E54CC0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.get_Default
	|
	|-RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
	|-EqualityComparer<NPCActionData>.get_Default
	|
	|-RVA: 0x2E56560 Offset: 0x2E56661 VA: 0x2E56560
	|-EqualityComparer<NpcPlaceSchedule>.get_Default
	|
	|-RVA: 0x2E571B0 Offset: 0x2E572B1 VA: 0x2E571B0
	|-EqualityComparer<OrderLotterySaveParameter>.get_Default
	|
	|-RVA: 0x31FE270 Offset: 0x31FE371 VA: 0x31FE270
	|-EqualityComparer<OrderSaveData>.get_Default
	|
	|-RVA: 0x31FEF40 Offset: 0x31FF041 VA: 0x31FEF40
	|-EqualityComparer<OrderSaveParameter>.get_Default
	|
	|-RVA: 0x31FFB90 Offset: 0x31FFC91 VA: 0x31FFB90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3200700 Offset: 0x3200801 VA: 0x3200700
	|-EqualityComparer<Parameter>.get_Default
	|
	|-RVA: 0x3201380 Offset: 0x3201481 VA: 0x3201380
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.get_Default
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-EqualityComparer<ShopCatalogPage>.get_Default
	|
	|-RVA: 0x3202A60 Offset: 0x3202B61 VA: 0x3202A60
	|-EqualityComparer<ShopNpcTalk>.get_Default
	|
	|-RVA: 0x3203720 Offset: 0x3203821 VA: 0x3203720
	|-EqualityComparer<SubtitleDataTable.Data>.get_Default
	|
	|-RVA: 0x32042B0 Offset: 0x32043B1 VA: 0x32042B0
	|-EqualityComparer<SubtitleDataTable.DataList>.get_Default
	|
	|-RVA: 0x3204DF0 Offset: 0x3204EF1 VA: 0x3204DF0
	|-EqualityComparer<SubtitleHudDataTable.Data>.get_Default
	|
	|-RVA: 0x3205980 Offset: 0x3205A81 VA: 0x3205980
	|-EqualityComparer<ProfilerFrame>.get_Default
	|
	|-RVA: 0x3206550 Offset: 0x3206651 VA: 0x3206550
	|-EqualityComparer<NumberControl.ValueRange>.get_Default
	|
	|-RVA: 0x32070C0 Offset: 0x32071C1 VA: 0x32070C0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.get_Default
	|
	|-RVA: 0x3207D10 Offset: 0x3207E11 VA: 0x3207D10
	|-EqualityComparer<Schedule>.get_Default
	|
	|-RVA: 0x3208960 Offset: 0x3208A61 VA: 0x3208960
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x32094D0 Offset: 0x32095D1 VA: 0x32094D0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.get_Default
	|
	|-RVA: 0x320A060 Offset: 0x320A161 VA: 0x320A060
	|-EqualityComparer<CurveSample>.get_Default
	|
	|-RVA: 0x320AE00 Offset: 0x320AF01 VA: 0x320AE00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x320B950 Offset: 0x320BA51 VA: 0x320B950
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x320C490 Offset: 0x320C591 VA: 0x320C490
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x320CFD0 Offset: 0x320D0D1 VA: 0x320CFD0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x320DB40 Offset: 0x320DC41 VA: 0x320DB40
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x320E680 Offset: 0x320E781 VA: 0x320E680
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x320FD30 Offset: 0x320FE31 VA: 0x320FD30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x32113E0 Offset: 0x32114E1 VA: 0x32113E0
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3211F50 Offset: 0x3212051 VA: 0x3211F50
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3212AA0 Offset: 0x3212BA1 VA: 0x3212AA0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3213610 Offset: 0x3213711 VA: 0x3213610
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3214150 Offset: 0x3214251 VA: 0x3214150
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3214C90 Offset: 0x3214D91 VA: 0x3214C90
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x32157D0 Offset: 0x32158D1 VA: 0x32157D0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3216310 Offset: 0x3216411 VA: 0x3216310
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3216E80 Offset: 0x3216F81 VA: 0x3216E80
	|-EqualityComparer<Memory<object>>.get_Default
	|
	|-RVA: 0x32179F0 Offset: 0x3217AF1 VA: 0x32179F0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.get_Default
	|
	|-RVA: 0x32186E0 Offset: 0x32187E1 VA: 0x32186E0
	|-EqualityComparer<Nullable<Int32Enum>>.get_Default
	|
	|-RVA: 0x3219230 Offset: 0x3219331 VA: 0x3219230
	|-EqualityComparer<Nullable<Bounds>>.get_Default
	|
	|-RVA: 0x3219F20 Offset: 0x321A021 VA: 0x3219F20
	|-EqualityComparer<Nullable<BoundsInt>>.get_Default
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-EqualityComparer<Nullable<Color32>>.get_Default
	|
	|-RVA: 0x32C9420 Offset: 0x32C9521 VA: 0x32C9420
	|-EqualityComparer<Nullable<Color>>.get_Default
	|
	|-RVA: 0x32CA0A0 Offset: 0x32CA1A1 VA: 0x32CA0A0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.get_Default
	|
	|-RVA: 0x32CAC40 Offset: 0x32CAD41 VA: 0x32CAC40
	|-EqualityComparer<Nullable<GradientColorKey>>.get_Default
	|
	|-RVA: 0x32CB8C0 Offset: 0x32CB9C1 VA: 0x32CB8C0
	|-EqualityComparer<Nullable<Keyframe>>.get_Default
	|
	|-RVA: 0x32CC540 Offset: 0x32CC641 VA: 0x32CC540
	|-EqualityComparer<Nullable<LayerMask>>.get_Default
	|
	|-RVA: 0x32CD090 Offset: 0x32CD191 VA: 0x32CD090
	|-EqualityComparer<Nullable<Matrix4x4>>.get_Default
	|
	|-RVA: 0x32CDE90 Offset: 0x32CDF91 VA: 0x32CDE90
	|-EqualityComparer<Nullable<Quaternion>>.get_Default
	|
	|-RVA: 0x32CEB10 Offset: 0x32CEC11 VA: 0x32CEB10
	|-EqualityComparer<Nullable<RangeInt>>.get_Default
	|
	|-RVA: 0x32CF6B0 Offset: 0x32CF7B1 VA: 0x32CF6B0
	|-EqualityComparer<Nullable<Rect>>.get_Default
	|
	|-RVA: 0x32D0330 Offset: 0x32D0431 VA: 0x32D0330
	|-EqualityComparer<Nullable<RectInt>>.get_Default
	|
	|-RVA: 0x32D0FB0 Offset: 0x32D10B1 VA: 0x32D0FB0
	|-EqualityComparer<Nullable<Vector2>>.get_Default
	|
	|-RVA: 0x32D1B50 Offset: 0x32D1C51 VA: 0x32D1B50
	|-EqualityComparer<Nullable<Vector2Int>>.get_Default
	|
	|-RVA: 0x32D26F0 Offset: 0x32D27F1 VA: 0x32D26F0
	|-EqualityComparer<Nullable<Vector3>>.get_Default
	|
	|-RVA: 0x32D3260 Offset: 0x32D3361 VA: 0x32D3260
	|-EqualityComparer<Nullable<Vector3Int>>.get_Default
	|
	|-RVA: 0x32D3DD0 Offset: 0x32D3ED1 VA: 0x32D3DD0
	|-EqualityComparer<Nullable<Vector4>>.get_Default
	|
	|-RVA: 0x32D5570 Offset: 0x32D5671 VA: 0x32D5570
	|-EqualityComparer<ReadOnlyMemory<object>>.get_Default
	|
	|-RVA: 0x32D60E0 Offset: 0x32D61E1 VA: 0x32D60E0
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x32D6C20 Offset: 0x32D6D21 VA: 0x32D6C20
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x32D7790 Offset: 0x32D7891 VA: 0x32D7790
	|-EqualityComparer<RuntimeTypeHandle>.get_Default
	|
	|-RVA: 0x32D82D0 Offset: 0x32D83D1 VA: 0x32D82D0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x32D8E10 Offset: 0x32D8F11 VA: 0x32D8E10
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x32D9960 Offset: 0x32D9A61 VA: 0x32D9960
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x32DA4A0 Offset: 0x32DA5A1 VA: 0x32DA4A0
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x32DAFE0 Offset: 0x32DB0E1 VA: 0x32DAFE0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DC660 Offset: 0x32DC761 VA: 0x32DC660
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x32DD1A0 Offset: 0x32DD2A1 VA: 0x32DD1A0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x32DDD10 Offset: 0x32DDE11 VA: 0x32DDD10
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DE880 Offset: 0x32DE981 VA: 0x32DE880
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x32DF3F0 Offset: 0x32DF4F1 VA: 0x32DF3F0
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x32DFF60 Offset: 0x32E0061 VA: 0x32DFF60
	|-EqualityComparer<ValueTuple<float, float>>.get_Default
	|
	|-RVA: 0x32E0AD0 Offset: 0x32E0BD1 VA: 0x32E0AD0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Default
	|
	|-RVA: 0x32E1660 Offset: 0x32E1761 VA: 0x32E1660
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Default
	|
	|-RVA: 0x32E2390 Offset: 0x32E2491 VA: 0x32E2390
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x32E30C0 Offset: 0x32E31C1 VA: 0x32E30C0
	|-EqualityComparer<TransitionTables>.get_Default
	|
	|-RVA: 0x32E3D10 Offset: 0x32E3E11 VA: 0x32E3D10
	|-EqualityComparer<TutorialUnlockFlagData>.get_Default
	|
	|-RVA: 0x32E48A0 Offset: 0x32E49A1 VA: 0x32E48A0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.get_Default
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-EqualityComparer<CapEdge>.get_Default
	|
	|-RVA: 0x30F14B0 Offset: 0x30F15B1 VA: 0x30F14B0
	|-EqualityComparer<ClippedEdge>.get_Default
	|
	|-RVA: 0x30F2100 Offset: 0x30F2201 VA: 0x30F2100
	|-EqualityComparer<EdgeKeyByHash>.get_Default
	|
	|-RVA: 0x30F2C40 Offset: 0x30F2D41 VA: 0x30F2C40
	|-EqualityComparer<EdgeKeyByIndex>.get_Default
	|
	|-RVA: 0x30F3780 Offset: 0x30F3881 VA: 0x30F3780
	|-EqualityComparer<MeshDataConnectivity.Face>.get_Default
	|
	|-RVA: 0x30F42C0 Offset: 0x30F43C1 VA: 0x30F42C0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.get_Default
	|
	|-RVA: 0x30F4F10 Offset: 0x30F5011 VA: 0x30F4F10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.get_Default
	|
	|-RVA: 0x30F5BD0 Offset: 0x30F5CD1 VA: 0x30F5BD0
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x30F6740 Offset: 0x30F6841 VA: 0x30F6740
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x30F75C0 Offset: 0x30F76C1 VA: 0x30F75C0
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x30F8130 Offset: 0x30F8231 VA: 0x30F8130
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x30F8C70 Offset: 0x30F8D71 VA: 0x30F8C70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x30F97E0 Offset: 0x30F98E1 VA: 0x30F97E0
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x30FA430 Offset: 0x30FA531 VA: 0x30FA430
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x30FB080 Offset: 0x30FB181 VA: 0x30FB080
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x30FBCD0 Offset: 0x30FBDD1 VA: 0x30FBCD0
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x30FC810 Offset: 0x30FC911 VA: 0x30FC810
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x30FD3E0 Offset: 0x30FD4E1 VA: 0x30FD3E0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x30FE260 Offset: 0x30FE361 VA: 0x30FE260
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x30FF000 Offset: 0x30FF101 VA: 0x30FF000
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	|
	|-RVA: 0x30FFB40 Offset: 0x30FFC41 VA: 0x30FFB40
	|-EqualityComparer<GradientAlphaKey>.get_Default
	|
	|-RVA: 0x31006B0 Offset: 0x31007B1 VA: 0x31006B0
	|-EqualityComparer<GradientColorKey>.get_Default
	|
	|-RVA: 0x3101300 Offset: 0x3101401 VA: 0x3101300
	|-EqualityComparer<Keyframe>.get_Default
	|
	|-RVA: 0x3101FC0 Offset: 0x31020C1 VA: 0x3101FC0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3102B00 Offset: 0x3102C01 VA: 0x3102B00
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x31044B0 Offset: 0x31045B1 VA: 0x31044B0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3105020 Offset: 0x3105121 VA: 0x3105020
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3105C70 Offset: 0x3105D71 VA: 0x3105C70
	|-EqualityComparer<PlayableGraph>.get_Default
	|
	|-RVA: 0x31067E0 Offset: 0x31068E1 VA: 0x31067E0
	|-EqualityComparer<Edge>.get_Default
	|
	|-RVA: 0x3107320 Offset: 0x3107421 VA: 0x3107320
	|-EqualityComparer<IntVec3>.get_Default
	|
	|-RVA: 0x3107EF0 Offset: 0x3107FF1 VA: 0x3107EF0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3108AC0 Offset: 0x3108BC1 VA: 0x3108AC0
	|-EqualityComparer<RangeInt>.get_Default
	|
	|-RVA: 0x3109600 Offset: 0x3109701 VA: 0x3109600
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x310A2F0 Offset: 0x310A3F1 VA: 0x310A2F0
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x310B020 Offset: 0x310B121 VA: 0x310B020
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x310BBF0 Offset: 0x310BCF1 VA: 0x310BBF0
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x310C760 Offset: 0x310C861 VA: 0x310C760
	|-EqualityComparer<ReflectionProbeBlendInfo>.get_Default
	|
	|-RVA: 0x310D2D0 Offset: 0x310D3D1 VA: 0x310D2D0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x310E1D0 Offset: 0x310E2D1 VA: 0x310E1D0
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x310ED40 Offset: 0x310EE41 VA: 0x310ED40
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x2EA70A0 Offset: 0x2EA71A1 VA: 0x2EA70A0
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x2EA7CF0 Offset: 0x2EA7DF1 VA: 0x2EA7CF0
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.get_Default
	|
	|-RVA: 0x2EA8940 Offset: 0x2EA8A41 VA: 0x2EA8940
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x2EA9600 Offset: 0x2EA9701 VA: 0x2EA9600
	|-EqualityComparer<SceneInstance>.get_Default
	|
	|-RVA: 0x2EAA170 Offset: 0x2EAA271 VA: 0x2EAA170
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x2EAADC0 Offset: 0x2EAAEC1 VA: 0x2EAADC0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x2EABA80 Offset: 0x2EABB81 VA: 0x2EABA80
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x2EAC5F0 Offset: 0x2EAC6F1 VA: 0x2EAC5F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x2EAD2C0 Offset: 0x2EAD3C1 VA: 0x2EAD2C0
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x2EADF10 Offset: 0x2EAE011 VA: 0x2EADF10
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x2EAEB60 Offset: 0x2EAEC61 VA: 0x2EAEB60
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x2EAF7B0 Offset: 0x2EAF8B1 VA: 0x2EAF7B0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x2EB05C0 Offset: 0x2EB06C1 VA: 0x2EB05C0
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x2EB1290 Offset: 0x2EB1391 VA: 0x2EB1290
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x2EB1EE0 Offset: 0x2EB1FE1 VA: 0x2EB1EE0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x2EB3620 Offset: 0x2EB3721 VA: 0x2EB3620
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x2EB4190 Offset: 0x2EB4291 VA: 0x2EB4190
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x2EB4CD0 Offset: 0x2EB4DD1 VA: 0x2EB4CD0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x2EB5840 Offset: 0x2EB5941 VA: 0x2EB5840
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x2EB6650 Offset: 0x2EB6751 VA: 0x2EB6650
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2EB72A0 Offset: 0x2EB73A1 VA: 0x2EB72A0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x2EB8950 Offset: 0x2EB8A51 VA: 0x2EB8950
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x2EBA0B0 Offset: 0x2EBA1B1 VA: 0x2EBA0B0
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-EqualityComparer<WarpPoints.WarpPoint>.get_Default
	|
	|-RVA: 0x2EBBB70 Offset: 0x2EBBC71 VA: 0x2EBBB70
	|-EqualityComparer<YieldItemParam>.get_Default
	|
	|-RVA: 0x2EBC6B0 Offset: 0x2EBC7B1 VA: 0x2EBC6B0
	|-EqualityComparer<stCommand_t>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E2D0 Offset: 0x2E3E3D1 VA: 0x2E3E2D0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.CreateComparer
	|
	|-RVA: 0x2E3EF20 Offset: 0x2E3F021 VA: 0x2E3EF20
	|-EqualityComparer<JSONDeserialization.TaskField>.CreateComparer
	|
	|-RVA: 0x2E3FA90 Offset: 0x2E3FB91 VA: 0x2E3FA90
	|-EqualityComparer<BitVector32Int>.CreateComparer
	|
	|-RVA: 0x2E405D0 Offset: 0x2E406D1 VA: 0x2E405D0
	|-EqualityComparer<BuildItemData>.CreateComparer
	|
	|-RVA: 0x2E414C0 Offset: 0x2E415C1 VA: 0x2E414C0
	|-EqualityComparer<ButtonLinker.LinkObject>.CreateComparer
	|
	|-RVA: 0x2E42030 Offset: 0x2E42131 VA: 0x2E42030
	|-EqualityComparer<CharaCallTable.BustupTable>.CreateComparer
	|
	|-RVA: 0x2E42BA0 Offset: 0x2E42CA1 VA: 0x2E42BA0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.CreateComparer
	|
	|-RVA: 0x2E43730 Offset: 0x2E43831 VA: 0x2E43730
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x2E465E0 Offset: 0x2E466E1 VA: 0x2E465E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x2E472D0 Offset: 0x2E473D1 VA: 0x2E472D0
	|-EqualityComparer<CropDataTable>.CreateComparer
	|
	|-RVA: 0x2E47F30 Offset: 0x2E48031 VA: 0x2E47F30
	|-EqualityComparer<DropItemParam>.CreateComparer
	|
	|-RVA: 0x2E48A70 Offset: 0x2E48B71 VA: 0x2E48A70
	|-EqualityComparer<EffectDataTable>.CreateComparer
	|
	|-RVA: 0x2E496C0 Offset: 0x2E497C1 VA: 0x2E496C0
	|-EqualityComparer<ErosionBrush.UndoStep>.CreateComparer
	|
	|-RVA: 0x2E4A310 Offset: 0x2E4A411 VA: 0x2E4A310
	|-EqualityComparer<EventCheckId>.CreateComparer
	|
	|-RVA: 0x2E4AF60 Offset: 0x2E4B061 VA: 0x2E4AF60
	|-EqualityComparer<EventFlagProgressData>.CreateComparer
	|
	|-RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.CreateComparer
	|
	|-RVA: 0x2E4C830 Offset: 0x2E4C931 VA: 0x2E4C830
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.CreateComparer
	|
	|-RVA: 0x2E4D480 Offset: 0x2E4D581 VA: 0x2E4D480
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.CreateComparer
	|
	|-RVA: 0x2E4E010 Offset: 0x2E4E111 VA: 0x2E4E010
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.CreateComparer
	|
	|-RVA: 0x2E4EB80 Offset: 0x2E4EC81 VA: 0x2E4EB80
	|-EqualityComparer<FesNpcScoreData>.CreateComparer
	|
	|-RVA: 0x2E4F6F0 Offset: 0x2E4F7F1 VA: 0x2E4F6F0
	|-EqualityComparer<GimmickLayoutDataTable>.CreateComparer
	|
	|-RVA: 0x2E50230 Offset: 0x2E50331 VA: 0x2E50230
	|-EqualityComparer<MineTypeDataTable>.CreateComparer
	|
	|-RVA: 0x2E50F60 Offset: 0x2E51061 VA: 0x2E50F60
	|-EqualityComparer<MiningDataTable>.CreateComparer
	|
	|-RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0
	|-EqualityComparer<MiningPointSaveData>.CreateComparer
	|
	|-RVA: 0x2E527C0 Offset: 0x2E528C1 VA: 0x2E527C0
	|-EqualityComparer<MonsterDataTable>.CreateComparer
	|
	|-RVA: 0x2E53440 Offset: 0x2E53541 VA: 0x2E53440
	|-EqualityComparer<MonsterFootStepEventDataTable>.CreateComparer
	|
	|-RVA: 0x2E54100 Offset: 0x2E54201 VA: 0x2E54100
	|-EqualityComparer<MonsterHutSaveData>.CreateComparer
	|
	|-RVA: 0x2E54DD0 Offset: 0x2E54ED1 VA: 0x2E54DD0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.CreateComparer
	|
	|-RVA: 0x2E55940 Offset: 0x2E55A41 VA: 0x2E55940
	|-EqualityComparer<NPCActionData>.CreateComparer
	|
	|-RVA: 0x2E56670 Offset: 0x2E56771 VA: 0x2E56670
	|-EqualityComparer<NpcPlaceSchedule>.CreateComparer
	|
	|-RVA: 0x2E572C0 Offset: 0x2E573C1 VA: 0x2E572C0
	|-EqualityComparer<OrderLotterySaveParameter>.CreateComparer
	|
	|-RVA: 0x31FE380 Offset: 0x31FE481 VA: 0x31FE380
	|-EqualityComparer<OrderSaveData>.CreateComparer
	|
	|-RVA: 0x31FF050 Offset: 0x31FF151 VA: 0x31FF050
	|-EqualityComparer<OrderSaveParameter>.CreateComparer
	|
	|-RVA: 0x31FFCA0 Offset: 0x31FFDA1 VA: 0x31FFCA0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3200810 Offset: 0x3200911 VA: 0x3200810
	|-EqualityComparer<Parameter>.CreateComparer
	|
	|-RVA: 0x3201490 Offset: 0x3201591 VA: 0x3201490
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.CreateComparer
	|
	|-RVA: 0x3202000 Offset: 0x3202101 VA: 0x3202000
	|-EqualityComparer<ShopCatalogPage>.CreateComparer
	|
	|-RVA: 0x3202B70 Offset: 0x3202C71 VA: 0x3202B70
	|-EqualityComparer<ShopNpcTalk>.CreateComparer
	|
	|-RVA: 0x3203830 Offset: 0x3203931 VA: 0x3203830
	|-EqualityComparer<SubtitleDataTable.Data>.CreateComparer
	|
	|-RVA: 0x32043C0 Offset: 0x32044C1 VA: 0x32043C0
	|-EqualityComparer<SubtitleDataTable.DataList>.CreateComparer
	|
	|-RVA: 0x3204F00 Offset: 0x3205001 VA: 0x3204F00
	|-EqualityComparer<SubtitleHudDataTable.Data>.CreateComparer
	|
	|-RVA: 0x3205A90 Offset: 0x3205B91 VA: 0x3205A90
	|-EqualityComparer<ProfilerFrame>.CreateComparer
	|
	|-RVA: 0x3206660 Offset: 0x3206761 VA: 0x3206660
	|-EqualityComparer<NumberControl.ValueRange>.CreateComparer
	|
	|-RVA: 0x32071D0 Offset: 0x32072D1 VA: 0x32071D0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.CreateComparer
	|
	|-RVA: 0x3207E20 Offset: 0x3207F21 VA: 0x3207E20
	|-EqualityComparer<Schedule>.CreateComparer
	|
	|-RVA: 0x3208A70 Offset: 0x3208B71 VA: 0x3208A70
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x32095E0 Offset: 0x32096E1 VA: 0x32095E0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.CreateComparer
	|
	|-RVA: 0x320A170 Offset: 0x320A271 VA: 0x320A170
	|-EqualityComparer<CurveSample>.CreateComparer
	|
	|-RVA: 0x320AF10 Offset: 0x320B011 VA: 0x320AF10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x320BA60 Offset: 0x320BB61 VA: 0x320BA60
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x320C5A0 Offset: 0x320C6A1 VA: 0x320C5A0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x320D0E0 Offset: 0x320D1E1 VA: 0x320D0E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x320DC50 Offset: 0x320DD51 VA: 0x320DC50
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x320E790 Offset: 0x320E891 VA: 0x320E790
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x320F300 Offset: 0x320F401 VA: 0x320F300
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x320FE40 Offset: 0x320FF41 VA: 0x320FE40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x32109B0 Offset: 0x3210AB1 VA: 0x32109B0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x32114F0 Offset: 0x32115F1 VA: 0x32114F0
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3212060 Offset: 0x3212161 VA: 0x3212060
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3212BB0 Offset: 0x3212CB1 VA: 0x3212BB0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3213720 Offset: 0x3213821 VA: 0x3213720
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3214260 Offset: 0x3214361 VA: 0x3214260
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3214DA0 Offset: 0x3214EA1 VA: 0x3214DA0
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x32158E0 Offset: 0x32159E1 VA: 0x32158E0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3216420 Offset: 0x3216521 VA: 0x3216420
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3216F90 Offset: 0x3217091 VA: 0x3216F90
	|-EqualityComparer<Memory<object>>.CreateComparer
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.CreateComparer
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-EqualityComparer<Nullable<Int32Enum>>.CreateComparer
	|
	|-RVA: 0x3219340 Offset: 0x3219441 VA: 0x3219340
	|-EqualityComparer<Nullable<Bounds>>.CreateComparer
	|
	|-RVA: 0x321A030 Offset: 0x321A131 VA: 0x321A030
	|-EqualityComparer<Nullable<BoundsInt>>.CreateComparer
	|
	|-RVA: 0x321AD20 Offset: 0x321AE21 VA: 0x321AD20
	|-EqualityComparer<Nullable<Color32>>.CreateComparer
	|
	|-RVA: 0x32C9530 Offset: 0x32C9631 VA: 0x32C9530
	|-EqualityComparer<Nullable<Color>>.CreateComparer
	|
	|-RVA: 0x32CA1B0 Offset: 0x32CA2B1 VA: 0x32CA1B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.CreateComparer
	|
	|-RVA: 0x32CAD50 Offset: 0x32CAE51 VA: 0x32CAD50
	|-EqualityComparer<Nullable<GradientColorKey>>.CreateComparer
	|
	|-RVA: 0x32CB9D0 Offset: 0x32CBAD1 VA: 0x32CB9D0
	|-EqualityComparer<Nullable<Keyframe>>.CreateComparer
	|
	|-RVA: 0x32CC650 Offset: 0x32CC751 VA: 0x32CC650
	|-EqualityComparer<Nullable<LayerMask>>.CreateComparer
	|
	|-RVA: 0x32CD1A0 Offset: 0x32CD2A1 VA: 0x32CD1A0
	|-EqualityComparer<Nullable<Matrix4x4>>.CreateComparer
	|
	|-RVA: 0x32CDFA0 Offset: 0x32CE0A1 VA: 0x32CDFA0
	|-EqualityComparer<Nullable<Quaternion>>.CreateComparer
	|
	|-RVA: 0x32CEC20 Offset: 0x32CED21 VA: 0x32CEC20
	|-EqualityComparer<Nullable<RangeInt>>.CreateComparer
	|
	|-RVA: 0x32CF7C0 Offset: 0x32CF8C1 VA: 0x32CF7C0
	|-EqualityComparer<Nullable<Rect>>.CreateComparer
	|
	|-RVA: 0x32D0440 Offset: 0x32D0541 VA: 0x32D0440
	|-EqualityComparer<Nullable<RectInt>>.CreateComparer
	|
	|-RVA: 0x32D10C0 Offset: 0x32D11C1 VA: 0x32D10C0
	|-EqualityComparer<Nullable<Vector2>>.CreateComparer
	|
	|-RVA: 0x32D1C60 Offset: 0x32D1D61 VA: 0x32D1C60
	|-EqualityComparer<Nullable<Vector2Int>>.CreateComparer
	|
	|-RVA: 0x32D2800 Offset: 0x32D2901 VA: 0x32D2800
	|-EqualityComparer<Nullable<Vector3>>.CreateComparer
	|
	|-RVA: 0x32D3370 Offset: 0x32D3471 VA: 0x32D3370
	|-EqualityComparer<Nullable<Vector3Int>>.CreateComparer
	|
	|-RVA: 0x32D3EE0 Offset: 0x32D3FE1 VA: 0x32D3EE0
	|-EqualityComparer<Nullable<Vector4>>.CreateComparer
	|
	|-RVA: 0x32D4B60 Offset: 0x32D4C61 VA: 0x32D4B60
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x32D5680 Offset: 0x32D5781 VA: 0x32D5680
	|-EqualityComparer<ReadOnlyMemory<object>>.CreateComparer
	|
	|-RVA: 0x32D61F0 Offset: 0x32D62F1 VA: 0x32D61F0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x32D6D30 Offset: 0x32D6E31 VA: 0x32D6D30
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x32D78A0 Offset: 0x32D79A1 VA: 0x32D78A0
	|-EqualityComparer<RuntimeTypeHandle>.CreateComparer
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x32D8F20 Offset: 0x32D9021 VA: 0x32D8F20
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x32D9A70 Offset: 0x32D9B71 VA: 0x32D9A70
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x32DB0F0 Offset: 0x32DB1F1 VA: 0x32DB0F0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x32DBC30 Offset: 0x32DBD31 VA: 0x32DBC30
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DC770 Offset: 0x32DC871 VA: 0x32DC770
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x32DD2B0 Offset: 0x32DD3B1 VA: 0x32DD2B0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x32DDE20 Offset: 0x32DDF21 VA: 0x32DDE20
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DE990 Offset: 0x32DEA91 VA: 0x32DE990
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x32E0070 Offset: 0x32E0171 VA: 0x32E0070
	|-EqualityComparer<ValueTuple<float, float>>.CreateComparer
	|
	|-RVA: 0x32E0BE0 Offset: 0x32E0CE1 VA: 0x32E0BE0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CreateComparer
	|
	|-RVA: 0x32E24A0 Offset: 0x32E25A1 VA: 0x32E24A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x32E31D0 Offset: 0x32E32D1 VA: 0x32E31D0
	|-EqualityComparer<TransitionTables>.CreateComparer
	|
	|-RVA: 0x32E3E20 Offset: 0x32E3F21 VA: 0x32E3E20
	|-EqualityComparer<TutorialUnlockFlagData>.CreateComparer
	|
	|-RVA: 0x32E49B0 Offset: 0x32E4AB1 VA: 0x32E49B0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.CreateComparer
	|
	|-RVA: 0x32E5520 Offset: 0x32E5621 VA: 0x32E5520
	|-EqualityComparer<CapEdge>.CreateComparer
	|
	|-RVA: 0x30F15C0 Offset: 0x30F16C1 VA: 0x30F15C0
	|-EqualityComparer<ClippedEdge>.CreateComparer
	|
	|-RVA: 0x30F2210 Offset: 0x30F2311 VA: 0x30F2210
	|-EqualityComparer<EdgeKeyByHash>.CreateComparer
	|
	|-RVA: 0x30F2D50 Offset: 0x30F2E51 VA: 0x30F2D50
	|-EqualityComparer<EdgeKeyByIndex>.CreateComparer
	|
	|-RVA: 0x30F3890 Offset: 0x30F3991 VA: 0x30F3890
	|-EqualityComparer<MeshDataConnectivity.Face>.CreateComparer
	|
	|-RVA: 0x30F43D0 Offset: 0x30F44D1 VA: 0x30F43D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.CreateComparer
	|
	|-RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.CreateComparer
	|
	|-RVA: 0x30F5CE0 Offset: 0x30F5DE1 VA: 0x30F5CE0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x30F76D0 Offset: 0x30F77D1 VA: 0x30F76D0
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x30F8240 Offset: 0x30F8341 VA: 0x30F8240
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x30F8D80 Offset: 0x30F8E81 VA: 0x30F8D80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x30FA540 Offset: 0x30FA641 VA: 0x30FA540
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x30FB190 Offset: 0x30FB291 VA: 0x30FB190
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x30FBDE0 Offset: 0x30FBEE1 VA: 0x30FBDE0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x30FC920 Offset: 0x30FCA21 VA: 0x30FC920
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x30FD4F0 Offset: 0x30FD5F1 VA: 0x30FD4F0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x30FE370 Offset: 0x30FE471 VA: 0x30FE370
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	|
	|-RVA: 0x30FFC50 Offset: 0x30FFD51 VA: 0x30FFC50
	|-EqualityComparer<GradientAlphaKey>.CreateComparer
	|
	|-RVA: 0x31007C0 Offset: 0x31008C1 VA: 0x31007C0
	|-EqualityComparer<GradientColorKey>.CreateComparer
	|
	|-RVA: 0x3101410 Offset: 0x3101511 VA: 0x3101410
	|-EqualityComparer<Keyframe>.CreateComparer
	|
	|-RVA: 0x31020D0 Offset: 0x31021D1 VA: 0x31020D0
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3102C10 Offset: 0x3102D11 VA: 0x3102C10
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3103940 Offset: 0x3103A41 VA: 0x3103940
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x31045C0 Offset: 0x31046C1 VA: 0x31045C0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3105130 Offset: 0x3105231 VA: 0x3105130
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3105D80 Offset: 0x3105E81 VA: 0x3105D80
	|-EqualityComparer<PlayableGraph>.CreateComparer
	|
	|-RVA: 0x31068F0 Offset: 0x31069F1 VA: 0x31068F0
	|-EqualityComparer<Edge>.CreateComparer
	|
	|-RVA: 0x3107430 Offset: 0x3107531 VA: 0x3107430
	|-EqualityComparer<IntVec3>.CreateComparer
	|
	|-RVA: 0x3108000 Offset: 0x3108101 VA: 0x3108000
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3108BD0 Offset: 0x3108CD1 VA: 0x3108BD0
	|-EqualityComparer<RangeInt>.CreateComparer
	|
	|-RVA: 0x3109710 Offset: 0x3109811 VA: 0x3109710
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x310A400 Offset: 0x310A501 VA: 0x310A400
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x310B130 Offset: 0x310B231 VA: 0x310B130
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x310BD00 Offset: 0x310BE01 VA: 0x310BD00
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x310C870 Offset: 0x310C971 VA: 0x310C870
	|-EqualityComparer<ReflectionProbeBlendInfo>.CreateComparer
	|
	|-RVA: 0x310D3E0 Offset: 0x310D4E1 VA: 0x310D3E0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x310E2E0 Offset: 0x310E3E1 VA: 0x310E2E0
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x310EE50 Offset: 0x310EF51 VA: 0x310EE50
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x2EA71B0 Offset: 0x2EA72B1 VA: 0x2EA71B0
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x2EA7E00 Offset: 0x2EA7F01 VA: 0x2EA7E00
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.CreateComparer
	|
	|-RVA: 0x2EA8A50 Offset: 0x2EA8B51 VA: 0x2EA8A50
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x2EA9710 Offset: 0x2EA9811 VA: 0x2EA9710
	|-EqualityComparer<SceneInstance>.CreateComparer
	|
	|-RVA: 0x2EAA280 Offset: 0x2EAA381 VA: 0x2EAA280
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x2EAAED0 Offset: 0x2EAAFD1 VA: 0x2EAAED0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x2EABB90 Offset: 0x2EABC91 VA: 0x2EABB90
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x2EAC700 Offset: 0x2EAC801 VA: 0x2EAC700
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x2EAD3D0 Offset: 0x2EAD4D1 VA: 0x2EAD3D0
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x2EAE020 Offset: 0x2EAE121 VA: 0x2EAE020
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x2EAEC70 Offset: 0x2EAED71 VA: 0x2EAEC70
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x2EAF8C0 Offset: 0x2EAF9C1 VA: 0x2EAF8C0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x2EB06D0 Offset: 0x2EB07D1 VA: 0x2EB06D0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x2EB13A0 Offset: 0x2EB14A1 VA: 0x2EB13A0
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x2EB2BC0 Offset: 0x2EB2CC1 VA: 0x2EB2BC0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x2EB3730 Offset: 0x2EB3831 VA: 0x2EB3730
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x2EB42A0 Offset: 0x2EB43A1 VA: 0x2EB42A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x2EB4DE0 Offset: 0x2EB4EE1 VA: 0x2EB4DE0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x2EB5950 Offset: 0x2EB5A51 VA: 0x2EB5950
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x2EB6760 Offset: 0x2EB6861 VA: 0x2EB6760
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2EB73B0 Offset: 0x2EB74B1 VA: 0x2EB73B0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2EB7F20 Offset: 0x2EB8021 VA: 0x2EB7F20
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x2EB8A60 Offset: 0x2EB8B61 VA: 0x2EB8A60
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2EB9630 Offset: 0x2EB9731 VA: 0x2EB9630
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x2EBA1C0 Offset: 0x2EBA2C1 VA: 0x2EBA1C0
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x2EBAD90 Offset: 0x2EBAE91 VA: 0x2EBAD90
	|-EqualityComparer<WarpPoints.WarpPoint>.CreateComparer
	|
	|-RVA: 0x2EBBC80 Offset: 0x2EBBD81 VA: 0x2EBBC80
	|-EqualityComparer<YieldItemParam>.CreateComparer
	|
	|-RVA: 0x2EBC7C0 Offset: 0x2EBC8C1 VA: 0x2EBC7C0
	|-EqualityComparer<stCommand_t>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E910 Offset: 0x2E3EA11 VA: 0x2E3E910
	|-EqualityComparer<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2E3F560 Offset: 0x2E3F661 VA: 0x2E3F560
	|-EqualityComparer<JSONDeserialization.TaskField>.IndexOf
	|
	|-RVA: 0x2E400D0 Offset: 0x2E401D1 VA: 0x2E400D0
	|-EqualityComparer<BitVector32Int>.IndexOf
	|
	|-RVA: 0x2E40C10 Offset: 0x2E40D11 VA: 0x2E40C10
	|-EqualityComparer<BuildItemData>.IndexOf
	|
	|-RVA: 0x2E41B00 Offset: 0x2E41C01 VA: 0x2E41B00
	|-EqualityComparer<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2E42670 Offset: 0x2E42771 VA: 0x2E42670
	|-EqualityComparer<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2E431E0 Offset: 0x2E432E1 VA: 0x2E431E0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2E43D70 Offset: 0x2E43E71 VA: 0x2E43D70
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2E448E0 Offset: 0x2E449E1 VA: 0x2E448E0
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2E45420 Offset: 0x2E45521 VA: 0x2E45420
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2E45F60 Offset: 0x2E46061 VA: 0x2E45F60
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2E46C20 Offset: 0x2E46D21 VA: 0x2E46C20
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2E47910 Offset: 0x2E47A11 VA: 0x2E47910
	|-EqualityComparer<CropDataTable>.IndexOf
	|
	|-RVA: 0x2E48570 Offset: 0x2E48671 VA: 0x2E48570
	|-EqualityComparer<DropItemParam>.IndexOf
	|
	|-RVA: 0x2E490B0 Offset: 0x2E491B1 VA: 0x2E490B0
	|-EqualityComparer<EffectDataTable>.IndexOf
	|
	|-RVA: 0x2E49D00 Offset: 0x2E49E01 VA: 0x2E49D00
	|-EqualityComparer<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2E4A950 Offset: 0x2E4AA51 VA: 0x2E4A950
	|-EqualityComparer<EventCheckId>.IndexOf
	|
	|-RVA: 0x2E4B5A0 Offset: 0x2E4B6A1 VA: 0x2E4B5A0
	|-EqualityComparer<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2E4C110 Offset: 0x2E4C211 VA: 0x2E4C110
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.IndexOf
	|
	|-RVA: 0x2E4CE70 Offset: 0x2E4CF71 VA: 0x2E4CE70
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.IndexOf
	|
	|-RVA: 0x2E4DAC0 Offset: 0x2E4DBC1 VA: 0x2E4DAC0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.IndexOf
	|
	|-RVA: 0x2E4E650 Offset: 0x2E4E751 VA: 0x2E4E650
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.IndexOf
	|
	|-RVA: 0x2E4F1C0 Offset: 0x2E4F2C1 VA: 0x2E4F1C0
	|-EqualityComparer<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2E4FD30 Offset: 0x2E4FE31 VA: 0x2E4FD30
	|-EqualityComparer<GimmickLayoutDataTable>.IndexOf
	|
	|-RVA: 0x2E50870 Offset: 0x2E50971 VA: 0x2E50870
	|-EqualityComparer<MineTypeDataTable>.IndexOf
	|
	|-RVA: 0x2E515A0 Offset: 0x2E516A1 VA: 0x2E515A0
	|-EqualityComparer<MiningDataTable>.IndexOf
	|
	|-RVA: 0x2E52110 Offset: 0x2E52211 VA: 0x2E52110
	|-EqualityComparer<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2E52E00 Offset: 0x2E52F01 VA: 0x2E52E00
	|-EqualityComparer<MonsterDataTable>.IndexOf
	|
	|-RVA: 0x2E53A80 Offset: 0x2E53B81 VA: 0x2E53A80
	|-EqualityComparer<MonsterFootStepEventDataTable>.IndexOf
	|
	|-RVA: 0x2E54740 Offset: 0x2E54841 VA: 0x2E54740
	|-EqualityComparer<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2E55410 Offset: 0x2E55511 VA: 0x2E55410
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x2E55F80 Offset: 0x2E56081 VA: 0x2E55F80
	|-EqualityComparer<NPCActionData>.IndexOf
	|
	|-RVA: 0x2E56CB0 Offset: 0x2E56DB1 VA: 0x2E56CB0
	|-EqualityComparer<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	|-EqualityComparer<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31FE9C0 Offset: 0x31FEAC1 VA: 0x31FE9C0
	|-EqualityComparer<OrderSaveData>.IndexOf
	|
	|-RVA: 0x31FF690 Offset: 0x31FF791 VA: 0x31FF690
	|-EqualityComparer<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32002E0 Offset: 0x32003E1 VA: 0x32002E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3200E50 Offset: 0x3200F51 VA: 0x3200E50
	|-EqualityComparer<Parameter>.IndexOf
	|
	|-RVA: 0x3201AD0 Offset: 0x3201BD1 VA: 0x3201AD0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.IndexOf
	|
	|-RVA: 0x3202640 Offset: 0x3202741 VA: 0x3202640
	|-EqualityComparer<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32031B0 Offset: 0x32032B1 VA: 0x32031B0
	|-EqualityComparer<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x3203E70 Offset: 0x3203F71 VA: 0x3203E70
	|-EqualityComparer<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3204A00 Offset: 0x3204B01 VA: 0x3204A00
	|-EqualityComparer<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3205540 Offset: 0x3205641 VA: 0x3205540
	|-EqualityComparer<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32060D0 Offset: 0x32061D1 VA: 0x32060D0
	|-EqualityComparer<ProfilerFrame>.IndexOf
	|
	|-RVA: 0x3206CA0 Offset: 0x3206DA1 VA: 0x3206CA0
	|-EqualityComparer<NumberControl.ValueRange>.IndexOf
	|
	|-RVA: 0x3207810 Offset: 0x3207911 VA: 0x3207810
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x3208460 Offset: 0x3208561 VA: 0x3208460
	|-EqualityComparer<Schedule>.IndexOf
	|
	|-RVA: 0x32090B0 Offset: 0x32091B1 VA: 0x32090B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3209C20 Offset: 0x3209D21 VA: 0x3209C20
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x320A7B0 Offset: 0x320A8B1 VA: 0x320A7B0
	|-EqualityComparer<CurveSample>.IndexOf
	|
	|-RVA: 0x320B550 Offset: 0x320B651 VA: 0x320B550
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x320C0A0 Offset: 0x320C1A1 VA: 0x320C0A0
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x320D720 Offset: 0x320D821 VA: 0x320D720
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x320E290 Offset: 0x320E391 VA: 0x320E290
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x320EDD0 Offset: 0x320EED1 VA: 0x320EDD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x320F940 Offset: 0x320FA41 VA: 0x320F940
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3210480 Offset: 0x3210581 VA: 0x3210480
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3210FF0 Offset: 0x32110F1 VA: 0x3210FF0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3211B30 Offset: 0x3211C31 VA: 0x3211B30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x32126A0 Offset: 0x32127A1 VA: 0x32126A0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x32131F0 Offset: 0x32132F1 VA: 0x32131F0
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3213D60 Offset: 0x3213E61 VA: 0x3213D60
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x32148A0 Offset: 0x32149A1 VA: 0x32148A0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x32153E0 Offset: 0x32154E1 VA: 0x32153E0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3216A60 Offset: 0x3216B61 VA: 0x3216A60
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x32175D0 Offset: 0x32176D1 VA: 0x32175D0
	|-EqualityComparer<Memory<object>>.IndexOf
	|
	|-RVA: 0x3218140 Offset: 0x3218241 VA: 0x3218140
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.IndexOf
	|
	|-RVA: 0x3218E30 Offset: 0x3218F31 VA: 0x3218E30
	|-EqualityComparer<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3219980 Offset: 0x3219A81 VA: 0x3219980
	|-EqualityComparer<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x321A670 Offset: 0x321A771 VA: 0x321A670
	|-EqualityComparer<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x321B360 Offset: 0x321B461 VA: 0x321B360
	|-EqualityComparer<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x32C9B70 Offset: 0x32C9C71 VA: 0x32C9B70
	|-EqualityComparer<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x32CA7F0 Offset: 0x32CA8F1 VA: 0x32CA7F0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-EqualityComparer<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x32CC010 Offset: 0x32CC111 VA: 0x32CC010
	|-EqualityComparer<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x32CCC90 Offset: 0x32CCD91 VA: 0x32CCC90
	|-EqualityComparer<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x32CD7E0 Offset: 0x32CD8E1 VA: 0x32CD7E0
	|-EqualityComparer<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32CE5E0 Offset: 0x32CE6E1 VA: 0x32CE5E0
	|-EqualityComparer<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32CF260 Offset: 0x32CF361 VA: 0x32CF260
	|-EqualityComparer<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32CFE00 Offset: 0x32CFF01 VA: 0x32CFE00
	|-EqualityComparer<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x32D0A80 Offset: 0x32D0B81 VA: 0x32D0A80
	|-EqualityComparer<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x32D1700 Offset: 0x32D1801 VA: 0x32D1700
	|-EqualityComparer<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32D22A0 Offset: 0x32D23A1 VA: 0x32D22A0
	|-EqualityComparer<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32D2E40 Offset: 0x32D2F41 VA: 0x32D2E40
	|-EqualityComparer<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x32D39B0 Offset: 0x32D3AB1 VA: 0x32D39B0
	|-EqualityComparer<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-EqualityComparer<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x32D51A0 Offset: 0x32D52A1 VA: 0x32D51A0
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-EqualityComparer<ReadOnlyMemory<object>>.IndexOf
	|
	|-RVA: 0x32D6830 Offset: 0x32D6931 VA: 0x32D6830
	|-EqualityComparer<Label>.IndexOf
	|
	|-RVA: 0x32D7370 Offset: 0x32D7471 VA: 0x32D7370
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x32D7EE0 Offset: 0x32D7FE1 VA: 0x32D7EE0
	|-EqualityComparer<RuntimeTypeHandle>.IndexOf
	|
	|-RVA: 0x32D8A20 Offset: 0x32D8B21 VA: 0x32D8A20
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x32D9560 Offset: 0x32D9661 VA: 0x32D9560
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x32DA0B0 Offset: 0x32DA1B1 VA: 0x32DA0B0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x32DABF0 Offset: 0x32DACF1 VA: 0x32DABF0
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x32DB730 Offset: 0x32DB831 VA: 0x32DB730
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x32DC270 Offset: 0x32DC371 VA: 0x32DC270
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DCDB0 Offset: 0x32DCEB1 VA: 0x32DCDB0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32DE460 Offset: 0x32DE561 VA: 0x32DE460
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DEFD0 Offset: 0x32DF0D1 VA: 0x32DEFD0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32DFB40 Offset: 0x32DFC41 VA: 0x32DFB40
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32E06B0 Offset: 0x32E07B1 VA: 0x32E06B0
	|-EqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x32E1220 Offset: 0x32E1321 VA: 0x32E1220
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32E1DB0 Offset: 0x32E1EB1 VA: 0x32E1DB0
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32E3810 Offset: 0x32E3911 VA: 0x32E3810
	|-EqualityComparer<TransitionTables>.IndexOf
	|
	|-RVA: 0x32E4460 Offset: 0x32E4561 VA: 0x32E4460
	|-EqualityComparer<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32E4FF0 Offset: 0x32E50F1 VA: 0x32E4FF0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32E5B60 Offset: 0x32E5C61 VA: 0x32E5B60
	|-EqualityComparer<CapEdge>.IndexOf
	|
	|-RVA: 0x30F1C00 Offset: 0x30F1D01 VA: 0x30F1C00
	|-EqualityComparer<ClippedEdge>.IndexOf
	|
	|-RVA: 0x30F2850 Offset: 0x30F2951 VA: 0x30F2850
	|-EqualityComparer<EdgeKeyByHash>.IndexOf
	|
	|-RVA: 0x30F3390 Offset: 0x30F3491 VA: 0x30F3390
	|-EqualityComparer<EdgeKeyByIndex>.IndexOf
	|
	|-RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	|-EqualityComparer<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x30F4A10 Offset: 0x30F4B11 VA: 0x30F4A10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x30F5660 Offset: 0x30F5761 VA: 0x30F5660
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x30F6320 Offset: 0x30F6421 VA: 0x30F6320
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x30F6E90 Offset: 0x30F6F91 VA: 0x30F6E90
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x30F7D10 Offset: 0x30F7E11 VA: 0x30F7D10
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x30F8880 Offset: 0x30F8981 VA: 0x30F8880
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x30F93C0 Offset: 0x30F94C1 VA: 0x30F93C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x30F9F30 Offset: 0x30FA031 VA: 0x30F9F30
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x30FAB80 Offset: 0x30FAC81 VA: 0x30FAB80
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x30FB7D0 Offset: 0x30FB8D1 VA: 0x30FB7D0
	|-EqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x30FC420 Offset: 0x30FC521 VA: 0x30FC420
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x30FCF60 Offset: 0x30FD061 VA: 0x30FCF60
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x30FDB30 Offset: 0x30FDC31 VA: 0x30FDB30
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x30FE9B0 Offset: 0x30FEAB1 VA: 0x30FE9B0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x30FF750 Offset: 0x30FF851 VA: 0x30FF750
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	|
	|-RVA: 0x3100290 Offset: 0x3100391 VA: 0x3100290
	|-EqualityComparer<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x3100E00 Offset: 0x3100F01 VA: 0x3100E00
	|-EqualityComparer<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3101A50 Offset: 0x3101B51 VA: 0x3101A50
	|-EqualityComparer<Keyframe>.IndexOf
	|
	|-RVA: 0x3102710 Offset: 0x3102811 VA: 0x3102710
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3103250 Offset: 0x3103351 VA: 0x3103250
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3103F80 Offset: 0x3104081 VA: 0x3103F80
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3104C00 Offset: 0x3104D01 VA: 0x3104C00
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3105770 Offset: 0x3105871 VA: 0x3105770
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	|-EqualityComparer<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3106F30 Offset: 0x3107031 VA: 0x3106F30
	|-EqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x3107A70 Offset: 0x3107B71 VA: 0x3107A70
	|-EqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x3108640 Offset: 0x3108741 VA: 0x3108640
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3109210 Offset: 0x3109311 VA: 0x3109210
	|-EqualityComparer<RangeInt>.IndexOf
	|
	|-RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x310AA40 Offset: 0x310AB41 VA: 0x310AA40
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x310B770 Offset: 0x310B871 VA: 0x310B770
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x310C340 Offset: 0x310C441 VA: 0x310C340
	|-EqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x310CEB0 Offset: 0x310CFB1 VA: 0x310CEB0
	|-EqualityComparer<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x310DA20 Offset: 0x310DB21 VA: 0x310DA20
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x310E920 Offset: 0x310EA21 VA: 0x310E920
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x310F490 Offset: 0x310F591 VA: 0x310F490
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x2EA77F0 Offset: 0x2EA78F1 VA: 0x2EA77F0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EA8440 Offset: 0x2EA8541 VA: 0x2EA8440
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EA9090 Offset: 0x2EA9191 VA: 0x2EA9090
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2EA9D50 Offset: 0x2EA9E51 VA: 0x2EA9D50
	|-EqualityComparer<SceneInstance>.IndexOf
	|
	|-RVA: 0x2EAA8C0 Offset: 0x2EAA9C1 VA: 0x2EAA8C0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2EAB510 Offset: 0x2EAB611 VA: 0x2EAB510
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2EAC1D0 Offset: 0x2EAC2D1 VA: 0x2EAC1D0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EACD40 Offset: 0x2EACE41 VA: 0x2EACD40
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2EADA10 Offset: 0x2EADB11 VA: 0x2EADA10
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2EAE660 Offset: 0x2EAE761 VA: 0x2EAE660
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2EAF2B0 Offset: 0x2EAF3B1 VA: 0x2EAF2B0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2EAFF00 Offset: 0x2EB0001 VA: 0x2EAFF00
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EB0D10 Offset: 0x2EB0E11 VA: 0x2EB0D10
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EB2630 Offset: 0x2EB2731 VA: 0x2EB2630
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x2EB3200 Offset: 0x2EB3301 VA: 0x2EB3200
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|
	|-RVA: 0x2EB3D70 Offset: 0x2EB3E71 VA: 0x2EB3D70
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2EB48E0 Offset: 0x2EB49E1 VA: 0x2EB48E0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|
	|-RVA: 0x2EB5420 Offset: 0x2EB5521 VA: 0x2EB5420
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x2EB5F90 Offset: 0x2EB6091 VA: 0x2EB5F90
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x2EB6DA0 Offset: 0x2EB6EA1 VA: 0x2EB6DA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2EB79F0 Offset: 0x2EB7AF1 VA: 0x2EB79F0
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EB8560 Offset: 0x2EB8661 VA: 0x2EB8560
	|-EqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EB90A0 Offset: 0x2EB91A1 VA: 0x2EB90A0
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EB9C70 Offset: 0x2EB9D71 VA: 0x2EB9C70
	|-EqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EBA800 Offset: 0x2EBA901 VA: 0x2EBA800
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2EBB3D0 Offset: 0x2EBB4D1 VA: 0x2EBB3D0
	|-EqualityComparer<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2EBC2C0 Offset: 0x2EBC3C1 VA: 0x2EBC2C0
	|-EqualityComparer<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2EBCE00 Offset: 0x2EBCF01 VA: 0x2EBCE00
	|-EqualityComparer<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EA30 Offset: 0x2E3EB31 VA: 0x2E3EA30
	|-EqualityComparer<AS_ToolController.ChargeInfo>.LastIndexOf
	|
	|-RVA: 0x2E3F630 Offset: 0x2E3F731 VA: 0x2E3F630
	|-EqualityComparer<JSONDeserialization.TaskField>.LastIndexOf
	|
	|-RVA: 0x2E40190 Offset: 0x2E40291 VA: 0x2E40190
	|-EqualityComparer<BitVector32Int>.LastIndexOf
	|
	|-RVA: 0x2E40DF0 Offset: 0x2E40EF1 VA: 0x2E40DF0
	|-EqualityComparer<BuildItemData>.LastIndexOf
	|
	|-RVA: 0x2E41BD0 Offset: 0x2E41CD1 VA: 0x2E41BD0
	|-EqualityComparer<ButtonLinker.LinkObject>.LastIndexOf
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-EqualityComparer<CharaCallTable.BustupTable>.LastIndexOf
	|
	|-RVA: 0x2E432C0 Offset: 0x2E433C1 VA: 0x2E432C0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.LastIndexOf
	|
	|-RVA: 0x2E43E40 Offset: 0x2E43F41 VA: 0x2E43E40
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x2E449A0 Offset: 0x2E44AA1 VA: 0x2E449A0
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x2E454E0 Offset: 0x2E455E1 VA: 0x2E454E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x2E460A0 Offset: 0x2E461A1 VA: 0x2E460A0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x2E46D70 Offset: 0x2E46E71 VA: 0x2E46D70
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x2E47A30 Offset: 0x2E47B31 VA: 0x2E47A30
	|-EqualityComparer<CropDataTable>.LastIndexOf
	|
	|-RVA: 0x2E48630 Offset: 0x2E48731 VA: 0x2E48630
	|-EqualityComparer<DropItemParam>.LastIndexOf
	|
	|-RVA: 0x2E491D0 Offset: 0x2E492D1 VA: 0x2E491D0
	|-EqualityComparer<EffectDataTable>.LastIndexOf
	|
	|-RVA: 0x2E49E20 Offset: 0x2E49F21 VA: 0x2E49E20
	|-EqualityComparer<ErosionBrush.UndoStep>.LastIndexOf
	|
	|-RVA: 0x2E4AA70 Offset: 0x2E4AB71 VA: 0x2E4AA70
	|-EqualityComparer<EventCheckId>.LastIndexOf
	|
	|-RVA: 0x2E4B670 Offset: 0x2E4B771 VA: 0x2E4B670
	|-EqualityComparer<EventFlagProgressData>.LastIndexOf
	|
	|-RVA: 0x2E4C280 Offset: 0x2E4C381 VA: 0x2E4C280
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.LastIndexOf
	|
	|-RVA: 0x2E4CF90 Offset: 0x2E4D091 VA: 0x2E4CF90
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4DBA0 Offset: 0x2E4DCA1 VA: 0x2E4DBA0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4E720 Offset: 0x2E4E821 VA: 0x2E4E720
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4F290 Offset: 0x2E4F391 VA: 0x2E4F290
	|-EqualityComparer<FesNpcScoreData>.LastIndexOf
	|
	|-RVA: 0x2E4FDF0 Offset: 0x2E4FEF1 VA: 0x2E4FDF0
	|-EqualityComparer<GimmickLayoutDataTable>.LastIndexOf
	|
	|-RVA: 0x2E509D0 Offset: 0x2E50AD1 VA: 0x2E509D0
	|-EqualityComparer<MineTypeDataTable>.LastIndexOf
	|
	|-RVA: 0x2E51670 Offset: 0x2E51771 VA: 0x2E51670
	|-EqualityComparer<MiningDataTable>.LastIndexOf
	|
	|-RVA: 0x2E52260 Offset: 0x2E52361 VA: 0x2E52260
	|-EqualityComparer<MiningPointSaveData>.LastIndexOf
	|
	|-RVA: 0x2E52F20 Offset: 0x2E53021 VA: 0x2E52F20
	|-EqualityComparer<MonsterDataTable>.LastIndexOf
	|
	|-RVA: 0x2E53BC0 Offset: 0x2E53CC1 VA: 0x2E53BC0
	|-EqualityComparer<MonsterFootStepEventDataTable>.LastIndexOf
	|
	|-RVA: 0x2E54880 Offset: 0x2E54981 VA: 0x2E54880
	|-EqualityComparer<MonsterHutSaveData>.LastIndexOf
	|
	|-RVA: 0x2E554E0 Offset: 0x2E555E1 VA: 0x2E554E0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.LastIndexOf
	|
	|-RVA: 0x2E560E0 Offset: 0x2E561E1 VA: 0x2E560E0
	|-EqualityComparer<NPCActionData>.LastIndexOf
	|
	|-RVA: 0x2E56DD0 Offset: 0x2E56ED1 VA: 0x2E56DD0
	|-EqualityComparer<NpcPlaceSchedule>.LastIndexOf
	|
	|-RVA: 0x2E579E0 Offset: 0x2E57AE1 VA: 0x2E579E0
	|-EqualityComparer<OrderLotterySaveParameter>.LastIndexOf
	|
	|-RVA: 0x31FEB00 Offset: 0x31FEC01 VA: 0x31FEB00
	|-EqualityComparer<OrderSaveData>.LastIndexOf
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-EqualityComparer<OrderSaveParameter>.LastIndexOf
	|
	|-RVA: 0x32003B0 Offset: 0x32004B1 VA: 0x32003B0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3200F70 Offset: 0x3201071 VA: 0x3200F70
	|-EqualityComparer<Parameter>.LastIndexOf
	|
	|-RVA: 0x3201BA0 Offset: 0x3201CA1 VA: 0x3201BA0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.LastIndexOf
	|
	|-RVA: 0x3202710 Offset: 0x3202811 VA: 0x3202710
	|-EqualityComparer<ShopCatalogPage>.LastIndexOf
	|
	|-RVA: 0x32032F0 Offset: 0x32033F1 VA: 0x32032F0
	|-EqualityComparer<ShopNpcTalk>.LastIndexOf
	|
	|-RVA: 0x3203F50 Offset: 0x3204051 VA: 0x3203F50
	|-EqualityComparer<SubtitleDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x3204AC0 Offset: 0x3204BC1 VA: 0x3204AC0
	|-EqualityComparer<SubtitleDataTable.DataList>.LastIndexOf
	|
	|-RVA: 0x3205620 Offset: 0x3205721 VA: 0x3205620
	|-EqualityComparer<SubtitleHudDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x32061C0 Offset: 0x32062C1 VA: 0x32061C0
	|-EqualityComparer<ProfilerFrame>.LastIndexOf
	|
	|-RVA: 0x3206D70 Offset: 0x3206E71 VA: 0x3206D70
	|-EqualityComparer<NumberControl.ValueRange>.LastIndexOf
	|
	|-RVA: 0x3207930 Offset: 0x3207A31 VA: 0x3207930
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.LastIndexOf
	|
	|-RVA: 0x3208580 Offset: 0x3208681 VA: 0x3208580
	|-EqualityComparer<Schedule>.LastIndexOf
	|
	|-RVA: 0x3209180 Offset: 0x3209281 VA: 0x3209180
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3209D00 Offset: 0x3209E01 VA: 0x3209D00
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x320A930 Offset: 0x320AA31 VA: 0x320A930
	|-EqualityComparer<CurveSample>.LastIndexOf
	|
	|-RVA: 0x320B610 Offset: 0x320B711 VA: 0x320B610
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x320C160 Offset: 0x320C261 VA: 0x320C160
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x320CCA0 Offset: 0x320CDA1 VA: 0x320CCA0
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x320D7F0 Offset: 0x320D8F1 VA: 0x320D7F0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x320E350 Offset: 0x320E451 VA: 0x320E350
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x320FA00 Offset: 0x320FB01 VA: 0x320FA00
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3210550 Offset: 0x3210651 VA: 0x3210550
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x32110B0 Offset: 0x32111B1 VA: 0x32110B0
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3211C00 Offset: 0x3211D01 VA: 0x3211C00
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3212760 Offset: 0x3212861 VA: 0x3212760
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x32132C0 Offset: 0x32133C1 VA: 0x32132C0
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3213E20 Offset: 0x3213F21 VA: 0x3213E20
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3214960 Offset: 0x3214A61 VA: 0x3214960
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3215FE0 Offset: 0x32160E1 VA: 0x3215FE0
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3216B30 Offset: 0x3216C31 VA: 0x3216B30
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x32176A0 Offset: 0x32177A1 VA: 0x32176A0
	|-EqualityComparer<Memory<object>>.LastIndexOf
	|
	|-RVA: 0x3218280 Offset: 0x3218381 VA: 0x3218280
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.LastIndexOf
	|
	|-RVA: 0x3218EF0 Offset: 0x3218FF1 VA: 0x3218EF0
	|-EqualityComparer<Nullable<Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x3219AC0 Offset: 0x3219BC1 VA: 0x3219AC0
	|-EqualityComparer<Nullable<Bounds>>.LastIndexOf
	|
	|-RVA: 0x321A7B0 Offset: 0x321A8B1 VA: 0x321A7B0
	|-EqualityComparer<Nullable<BoundsInt>>.LastIndexOf
	|
	|-RVA: 0x321B420 Offset: 0x321B521 VA: 0x321B420
	|-EqualityComparer<Nullable<Color32>>.LastIndexOf
	|
	|-RVA: 0x32C9C90 Offset: 0x32C9D91 VA: 0x32C9C90
	|-EqualityComparer<Nullable<Color>>.LastIndexOf
	|
	|-RVA: 0x32CA8D0 Offset: 0x32CA9D1 VA: 0x32CA8D0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.LastIndexOf
	|
	|-RVA: 0x32CB4B0 Offset: 0x32CB5B1 VA: 0x32CB4B0
	|-EqualityComparer<Nullable<GradientColorKey>>.LastIndexOf
	|
	|-RVA: 0x32CC130 Offset: 0x32CC231 VA: 0x32CC130
	|-EqualityComparer<Nullable<Keyframe>>.LastIndexOf
	|
	|-RVA: 0x32CCD50 Offset: 0x32CCE51 VA: 0x32CCD50
	|-EqualityComparer<Nullable<LayerMask>>.LastIndexOf
	|
	|-RVA: 0x32CD970 Offset: 0x32CDA71 VA: 0x32CD970
	|-EqualityComparer<Nullable<Matrix4x4>>.LastIndexOf
	|
	|-RVA: 0x32CE700 Offset: 0x32CE801 VA: 0x32CE700
	|-EqualityComparer<Nullable<Quaternion>>.LastIndexOf
	|
	|-RVA: 0x32CF340 Offset: 0x32CF441 VA: 0x32CF340
	|-EqualityComparer<Nullable<RangeInt>>.LastIndexOf
	|
	|-RVA: 0x32CFF20 Offset: 0x32D0021 VA: 0x32CFF20
	|-EqualityComparer<Nullable<Rect>>.LastIndexOf
	|
	|-RVA: 0x32D0BA0 Offset: 0x32D0CA1 VA: 0x32D0BA0
	|-EqualityComparer<Nullable<RectInt>>.LastIndexOf
	|
	|-RVA: 0x32D17E0 Offset: 0x32D18E1 VA: 0x32D17E0
	|-EqualityComparer<Nullable<Vector2>>.LastIndexOf
	|
	|-RVA: 0x32D2380 Offset: 0x32D2481 VA: 0x32D2380
	|-EqualityComparer<Nullable<Vector2Int>>.LastIndexOf
	|
	|-RVA: 0x32D2F10 Offset: 0x32D3011 VA: 0x32D2F10
	|-EqualityComparer<Nullable<Vector3>>.LastIndexOf
	|
	|-RVA: 0x32D3A80 Offset: 0x32D3B81 VA: 0x32D3A80
	|-EqualityComparer<Nullable<Vector3Int>>.LastIndexOf
	|
	|-RVA: 0x32D4640 Offset: 0x32D4741 VA: 0x32D4640
	|-EqualityComparer<Nullable<Vector4>>.LastIndexOf
	|
	|-RVA: 0x32D5260 Offset: 0x32D5361 VA: 0x32D5260
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x32D5D90 Offset: 0x32D5E91 VA: 0x32D5D90
	|-EqualityComparer<ReadOnlyMemory<object>>.LastIndexOf
	|
	|-RVA: 0x32D68F0 Offset: 0x32D69F1 VA: 0x32D68F0
	|-EqualityComparer<Label>.LastIndexOf
	|
	|-RVA: 0x32D7440 Offset: 0x32D7541 VA: 0x32D7440
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x32D7FA0 Offset: 0x32D80A1 VA: 0x32D7FA0
	|-EqualityComparer<RuntimeTypeHandle>.LastIndexOf
	|
	|-RVA: 0x32D8AE0 Offset: 0x32D8BE1 VA: 0x32D8AE0
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x32D9620 Offset: 0x32D9721 VA: 0x32D9620
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x32DACB0 Offset: 0x32DADB1 VA: 0x32DACB0
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x32DC330 Offset: 0x32DC431 VA: 0x32DC330
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DCE70 Offset: 0x32DCF71 VA: 0x32DCE70
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x32DD9C0 Offset: 0x32DDAC1 VA: 0x32DD9C0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x32DE530 Offset: 0x32DE631 VA: 0x32DE530
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DF0A0 Offset: 0x32DF1A1 VA: 0x32DF0A0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x32DFC10 Offset: 0x32DFD11 VA: 0x32DFC10
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x32E0780 Offset: 0x32E0881 VA: 0x32E0780
	|-EqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x32E1300 Offset: 0x32E1401 VA: 0x32E1300
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32E1F10 Offset: 0x32E2011 VA: 0x32E1F10
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x32E2C40 Offset: 0x32E2D41 VA: 0x32E2C40
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-EqualityComparer<TransitionTables>.LastIndexOf
	|
	|-RVA: 0x32E4540 Offset: 0x32E4641 VA: 0x32E4540
	|-EqualityComparer<TutorialUnlockFlagData>.LastIndexOf
	|
	|-RVA: 0x32E50C0 Offset: 0x32E51C1 VA: 0x32E50C0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.LastIndexOf
	|
	|-RVA: 0x32E5CB0 Offset: 0x32E5DB1 VA: 0x32E5CB0
	|-EqualityComparer<CapEdge>.LastIndexOf
	|
	|-RVA: 0x30F1D20 Offset: 0x30F1E21 VA: 0x30F1D20
	|-EqualityComparer<ClippedEdge>.LastIndexOf
	|
	|-RVA: 0x30F2910 Offset: 0x30F2A11 VA: 0x30F2910
	|-EqualityComparer<EdgeKeyByHash>.LastIndexOf
	|
	|-RVA: 0x30F3450 Offset: 0x30F3551 VA: 0x30F3450
	|-EqualityComparer<EdgeKeyByIndex>.LastIndexOf
	|
	|-RVA: 0x30F3F90 Offset: 0x30F4091 VA: 0x30F3F90
	|-EqualityComparer<MeshDataConnectivity.Face>.LastIndexOf
	|
	|-RVA: 0x30F4B30 Offset: 0x30F4C31 VA: 0x30F4B30
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.LastIndexOf
	|
	|-RVA: 0x30F57A0 Offset: 0x30F58A1 VA: 0x30F57A0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.LastIndexOf
	|
	|-RVA: 0x30F63F0 Offset: 0x30F64F1 VA: 0x30F63F0
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|
	|-RVA: 0x30F7050 Offset: 0x30F7151 VA: 0x30F7050
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|
	|-RVA: 0x30F7DE0 Offset: 0x30F7EE1 VA: 0x30F7DE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x30F8940 Offset: 0x30F8A41 VA: 0x30F8940
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x30F9490 Offset: 0x30F9591 VA: 0x30F9490
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x30FA050 Offset: 0x30FA151 VA: 0x30FA050
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x30FACA0 Offset: 0x30FADA1 VA: 0x30FACA0
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x30FB8F0 Offset: 0x30FB9F1 VA: 0x30FB8F0
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x30FC4E0 Offset: 0x30FC5E1 VA: 0x30FC4E0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x30FD050 Offset: 0x30FD151 VA: 0x30FD050
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x30FDCF0 Offset: 0x30FDDF1 VA: 0x30FDCF0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x30FEB30 Offset: 0x30FEC31 VA: 0x30FEB30
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x30FF810 Offset: 0x30FF911 VA: 0x30FF810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	|
	|-RVA: 0x3100360 Offset: 0x3100461 VA: 0x3100360
	|-EqualityComparer<GradientAlphaKey>.LastIndexOf
	|
	|-RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	|-EqualityComparer<GradientColorKey>.LastIndexOf
	|
	|-RVA: 0x3101B90 Offset: 0x3101C91 VA: 0x3101B90
	|-EqualityComparer<Keyframe>.LastIndexOf
	|
	|-RVA: 0x31027D0 Offset: 0x31028D1 VA: 0x31027D0
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x31033B0 Offset: 0x31034B1 VA: 0x31033B0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x31040A0 Offset: 0x31041A1 VA: 0x31040A0
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3104CD0 Offset: 0x3104DD1 VA: 0x3104CD0
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3105890 Offset: 0x3105991 VA: 0x3105890
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3106490 Offset: 0x3106591 VA: 0x3106490
	|-EqualityComparer<PlayableGraph>.LastIndexOf
	|
	|-RVA: 0x3106FF0 Offset: 0x31070F1 VA: 0x3106FF0
	|-EqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x3107B60 Offset: 0x3107C61 VA: 0x3107B60
	|-EqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x3108730 Offset: 0x3108831 VA: 0x3108730
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x31092D0 Offset: 0x31093D1 VA: 0x31092D0
	|-EqualityComparer<RangeInt>.LastIndexOf
	|
	|-RVA: 0x3109EA0 Offset: 0x3109FA1 VA: 0x3109EA0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x310ABA0 Offset: 0x310ACA1 VA: 0x310ABA0
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x310B860 Offset: 0x310B961 VA: 0x310B860
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x310C410 Offset: 0x310C511 VA: 0x310C410
	|-EqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x310CF80 Offset: 0x310D081 VA: 0x310CF80
	|-EqualityComparer<ReflectionProbeBlendInfo>.LastIndexOf
	|
	|-RVA: 0x310DC00 Offset: 0x310DD01 VA: 0x310DC00
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x310E9F0 Offset: 0x310EAF1 VA: 0x310E9F0
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x310F5B0 Offset: 0x310F6B1 VA: 0x310F5B0
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x2EA7910 Offset: 0x2EA7A11 VA: 0x2EA7910
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EA8560 Offset: 0x2EA8661 VA: 0x2EA8560
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EA91D0 Offset: 0x2EA92D1 VA: 0x2EA91D0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x2EA9E20 Offset: 0x2EA9F21 VA: 0x2EA9E20
	|-EqualityComparer<SceneInstance>.LastIndexOf
	|
	|-RVA: 0x2EAA9E0 Offset: 0x2EAAAE1 VA: 0x2EAA9E0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x2EAB650 Offset: 0x2EAB751 VA: 0x2EAB650
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x2EAC2A0 Offset: 0x2EAC3A1 VA: 0x2EAC2A0
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EACE80 Offset: 0x2EACF81 VA: 0x2EACE80
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x2EADB30 Offset: 0x2EADC31 VA: 0x2EADB30
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x2EAE780 Offset: 0x2EAE881 VA: 0x2EAE780
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2EAF3D0 Offset: 0x2EAF4D1 VA: 0x2EAF3D0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EB0E50 Offset: 0x2EB0F51 VA: 0x2EB0E50
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EB1B00 Offset: 0x2EB1C01 VA: 0x2EB1B00
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EB2720 Offset: 0x2EB2821 VA: 0x2EB2720
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x2EB32D0 Offset: 0x2EB33D1 VA: 0x2EB32D0
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|
	|-RVA: 0x2EB49A0 Offset: 0x2EB4AA1 VA: 0x2EB49A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|
	|-RVA: 0x2EB54F0 Offset: 0x2EB55F1 VA: 0x2EB54F0
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x2EB6130 Offset: 0x2EB6231 VA: 0x2EB6130
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x2EB6EC0 Offset: 0x2EB6FC1 VA: 0x2EB6EC0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x2EB7AC0 Offset: 0x2EB7BC1 VA: 0x2EB7AC0
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EB8620 Offset: 0x2EB8721 VA: 0x2EB8620
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EB9190 Offset: 0x2EB9291 VA: 0x2EB9190
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EB9D50 Offset: 0x2EB9E51 VA: 0x2EB9D50
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EBA8F0 Offset: 0x2EBA9F1 VA: 0x2EBA8F0
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2EBB5B0 Offset: 0x2EBB6B1 VA: 0x2EBB5B0
	|-EqualityComparer<WarpPoints.WarpPoint>.LastIndexOf
	|
	|-RVA: 0x2EBC380 Offset: 0x2EBC481 VA: 0x2EBC380
	|-EqualityComparer<YieldItemParam>.LastIndexOf
	|
	|-RVA: 0x2EBCF20 Offset: 0x2EBD021 VA: 0x2EBCF20
	|-EqualityComparer<stCommand_t>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EB40 Offset: 0x2E3EC41 VA: 0x2E3EB40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E3F700 Offset: 0x2E3F801 VA: 0x2E3F700
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40250 Offset: 0x2E40351 VA: 0x2E40250
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40FC0 Offset: 0x2E410C1 VA: 0x2E40FC0
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E41CA0 Offset: 0x2E41DA1 VA: 0x2E41CA0
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E42810 Offset: 0x2E42911 VA: 0x2E42810
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E43F10 Offset: 0x2E44011 VA: 0x2E43F10
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E44A60 Offset: 0x2E44B61 VA: 0x2E44A60
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E455A0 Offset: 0x2E456A1 VA: 0x2E455A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E461D0 Offset: 0x2E462D1 VA: 0x2E461D0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E46EB0 Offset: 0x2E46FB1 VA: 0x2E46EB0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E47B50 Offset: 0x2E47C51 VA: 0x2E47B50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E486F0 Offset: 0x2E487F1 VA: 0x2E486F0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E492E0 Offset: 0x2E493E1 VA: 0x2E492E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E49F30 Offset: 0x2E4A031 VA: 0x2E49F30
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4AB80 Offset: 0x2E4AC81 VA: 0x2E4AB80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4B740 Offset: 0x2E4B841 VA: 0x2E4B740
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4C3E0 Offset: 0x2E4C4E1 VA: 0x2E4C3E0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4D0A0 Offset: 0x2E4D1A1 VA: 0x2E4D0A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4DC80 Offset: 0x2E4DD81 VA: 0x2E4DC80
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4E7F0 Offset: 0x2E4E8F1 VA: 0x2E4E7F0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4FEB0 Offset: 0x2E4FFB1 VA: 0x2E4FEB0
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E50B20 Offset: 0x2E50C21 VA: 0x2E50B20
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E51740 Offset: 0x2E51841 VA: 0x2E51740
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E523A0 Offset: 0x2E524A1 VA: 0x2E523A0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53040 Offset: 0x2E53141 VA: 0x2E53040
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53CF0 Offset: 0x2E53DF1 VA: 0x2E53CF0
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E549B0 Offset: 0x2E54AB1 VA: 0x2E549B0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E555B0 Offset: 0x2E556B1 VA: 0x2E555B0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56230 Offset: 0x2E56331 VA: 0x2E56230
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56EE0 Offset: 0x2E56FE1 VA: 0x2E56EE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E57AC0 Offset: 0x2E57BC1 VA: 0x2E57AC0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FEC30 Offset: 0x31FED31 VA: 0x31FEC30
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FF8C0 Offset: 0x31FF9C1 VA: 0x31FF8C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3200480 Offset: 0x3200581 VA: 0x3200480
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201090 Offset: 0x3201191 VA: 0x3201090
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201C70 Offset: 0x3201D71 VA: 0x3201C70
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32027E0 Offset: 0x32028E1 VA: 0x32027E0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3203420 Offset: 0x3203521 VA: 0x3203420
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204030 Offset: 0x3204131 VA: 0x3204030
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204B80 Offset: 0x3204C81 VA: 0x3204B80
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3205700 Offset: 0x3205801 VA: 0x3205700
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32062B0 Offset: 0x32063B1 VA: 0x32062B0
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3207A40 Offset: 0x3207B41 VA: 0x3207A40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3208690 Offset: 0x3208791 VA: 0x3208690
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209DE0 Offset: 0x3209EE1 VA: 0x3209DE0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320AAA0 Offset: 0x320ABA1 VA: 0x320AAA0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320B6D0 Offset: 0x320B7D1 VA: 0x320B6D0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320C220 Offset: 0x320C321 VA: 0x320C220
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320CD60 Offset: 0x320CE61 VA: 0x320CD60
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320E410 Offset: 0x320E511 VA: 0x320E410
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320EF70 Offset: 0x320F071 VA: 0x320EF70
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320FAC0 Offset: 0x320FBC1 VA: 0x320FAC0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3210620 Offset: 0x3210721 VA: 0x3210620
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211170 Offset: 0x3211271 VA: 0x3211170
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211CD0 Offset: 0x3211DD1 VA: 0x3211CD0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3212820 Offset: 0x3212921 VA: 0x3212820
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213390 Offset: 0x3213491 VA: 0x3213390
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213EE0 Offset: 0x3213FE1 VA: 0x3213EE0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3214A20 Offset: 0x3214B21 VA: 0x3214A20
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3215560 Offset: 0x3215661 VA: 0x3215560
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32160A0 Offset: 0x32161A1 VA: 0x32160A0
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3216C00 Offset: 0x3216D01 VA: 0x3216C00
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3217770 Offset: 0x3217871 VA: 0x3217770
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32183B0 Offset: 0x32184B1 VA: 0x32183B0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3218FB0 Offset: 0x32190B1 VA: 0x3218FB0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3219BF0 Offset: 0x3219CF1 VA: 0x3219BF0
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321A8E0 Offset: 0x321A9E1 VA: 0x321A8E0
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321B4E0 Offset: 0x321B5E1 VA: 0x321B4E0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32C9DA0 Offset: 0x32C9EA1 VA: 0x32C9DA0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CA9B0 Offset: 0x32CAAB1 VA: 0x32CA9B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CB5C0 Offset: 0x32CB6C1 VA: 0x32CB5C0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CCE10 Offset: 0x32CCF11 VA: 0x32CCE10
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CDAF0 Offset: 0x32CDBF1 VA: 0x32CDAF0
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CE810 Offset: 0x32CE911 VA: 0x32CE810
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CF420 Offset: 0x32CF521 VA: 0x32CF420
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0030 Offset: 0x32D0131 VA: 0x32D0030
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0CB0 Offset: 0x32D0DB1 VA: 0x32D0CB0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D18C0 Offset: 0x32D19C1 VA: 0x32D18C0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2460 Offset: 0x32D2561 VA: 0x32D2460
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2FE0 Offset: 0x32D30E1 VA: 0x32D2FE0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D3B50 Offset: 0x32D3C51 VA: 0x32D3B50
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D4750 Offset: 0x32D4851 VA: 0x32D4750
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5320 Offset: 0x32D5421 VA: 0x32D5320
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5E60 Offset: 0x32D5F61 VA: 0x32D5E60
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D69B0 Offset: 0x32D6AB1 VA: 0x32D69B0
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D7510 Offset: 0x32D7611 VA: 0x32D7510
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8060 Offset: 0x32D8161 VA: 0x32D8060
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8BA0 Offset: 0x32D8CA1 VA: 0x32D8BA0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D96E0 Offset: 0x32D97E1 VA: 0x32D96E0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DA230 Offset: 0x32DA331 VA: 0x32DA230
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DAD70 Offset: 0x32DAE71 VA: 0x32DAD70
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DB8B0 Offset: 0x32DB9B1 VA: 0x32DB8B0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DC3F0 Offset: 0x32DC4F1 VA: 0x32DC3F0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DCF30 Offset: 0x32DD031 VA: 0x32DCF30
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DDA90 Offset: 0x32DDB91 VA: 0x32DDA90
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DF170 Offset: 0x32DF271 VA: 0x32DF170
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DFCE0 Offset: 0x32DFDE1 VA: 0x32DFCE0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E0850 Offset: 0x32E0951 VA: 0x32E0850
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E13E0 Offset: 0x32E14E1 VA: 0x32E13E0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2060 Offset: 0x32E2161 VA: 0x32E2060
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2D90 Offset: 0x32E2E91 VA: 0x32E2D90
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E3A40 Offset: 0x32E3B41 VA: 0x32E3A40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E4620 Offset: 0x32E4721 VA: 0x32E4620
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5190 Offset: 0x32E5291 VA: 0x32E5190
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5DF0 Offset: 0x32E5EF1 VA: 0x32E5DF0
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F1E30 Offset: 0x30F1F31 VA: 0x30F1E30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F29D0 Offset: 0x30F2AD1 VA: 0x30F29D0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F3510 Offset: 0x30F3611 VA: 0x30F3510
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4050 Offset: 0x30F4151 VA: 0x30F4050
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4C40 Offset: 0x30F4D41 VA: 0x30F4C40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F58D0 Offset: 0x30F59D1 VA: 0x30F58D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F64C0 Offset: 0x30F65C1 VA: 0x30F64C0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7200 Offset: 0x30F7301 VA: 0x30F7200
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7EB0 Offset: 0x30F7FB1 VA: 0x30F7EB0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F8A00 Offset: 0x30F8B01 VA: 0x30F8A00
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F9560 Offset: 0x30F9661 VA: 0x30F9560
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FADB0 Offset: 0x30FAEB1 VA: 0x30FADB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FBA00 Offset: 0x30FBB01 VA: 0x30FBA00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FC5A0 Offset: 0x30FC6A1 VA: 0x30FC5A0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FD140 Offset: 0x30FD241 VA: 0x30FD140
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FDEA0 Offset: 0x30FDFA1 VA: 0x30FDEA0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FECA0 Offset: 0x30FEDA1 VA: 0x30FECA0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FF8D0 Offset: 0x30FF9D1 VA: 0x30FF8D0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101030 Offset: 0x3101131 VA: 0x3101030
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101CC0 Offset: 0x3101DC1 VA: 0x3101CC0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3102890 Offset: 0x3102991 VA: 0x3102890
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3103500 Offset: 0x3103601 VA: 0x3103500
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31041C0 Offset: 0x31042C1 VA: 0x31041C0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3104DA0 Offset: 0x3104EA1 VA: 0x3104DA0
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31059A0 Offset: 0x3105AA1 VA: 0x31059A0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3106560 Offset: 0x3106661 VA: 0x3106560
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31070B0 Offset: 0x31071B1 VA: 0x31070B0
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3107C50 Offset: 0x3107D51 VA: 0x3107C50
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3108820 Offset: 0x3108921 VA: 0x3108820
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109390 Offset: 0x3109491 VA: 0x3109390
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109FE0 Offset: 0x310A0E1 VA: 0x3109FE0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310ACF0 Offset: 0x310ADF1 VA: 0x310ACF0
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310B950 Offset: 0x310BA51 VA: 0x310B950
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310C4E0 Offset: 0x310C5E1 VA: 0x310C4E0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310D050 Offset: 0x310D151 VA: 0x310D050
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310DDD0 Offset: 0x310DED1 VA: 0x310DDD0
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310EAC0 Offset: 0x310EBC1 VA: 0x310EAC0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310F6C0 Offset: 0x310F7C1 VA: 0x310F6C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA7A20 Offset: 0x2EA7B21 VA: 0x2EA7A20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA8670 Offset: 0x2EA8771 VA: 0x2EA8670
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9300 Offset: 0x2EA9401 VA: 0x2EA9300
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9EF0 Offset: 0x2EA9FF1 VA: 0x2EA9EF0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAAAF0 Offset: 0x2EAABF1 VA: 0x2EAAAF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAB780 Offset: 0x2EAB881 VA: 0x2EAB780
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAC370 Offset: 0x2EAC471 VA: 0x2EAC370
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EACFB0 Offset: 0x2EAD0B1 VA: 0x2EACFB0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EADC40 Offset: 0x2EADD41 VA: 0x2EADC40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAE890 Offset: 0x2EAE991 VA: 0x2EAE890
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0230 Offset: 0x2EB0331 VA: 0x2EB0230
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0F80 Offset: 0x2EB1081 VA: 0x2EB0F80
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB1C10 Offset: 0x2EB1D11 VA: 0x2EB1C10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB2810 Offset: 0x2EB2911 VA: 0x2EB2810
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB33A0 Offset: 0x2EB34A1 VA: 0x2EB33A0
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB3F10 Offset: 0x2EB4011 VA: 0x2EB3F10
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB4A60 Offset: 0x2EB4B61 VA: 0x2EB4A60
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB55C0 Offset: 0x2EB56C1 VA: 0x2EB55C0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB62C0 Offset: 0x2EB63C1 VA: 0x2EB62C0
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB6FD0 Offset: 0x2EB70D1 VA: 0x2EB6FD0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB7B90 Offset: 0x2EB7C91 VA: 0x2EB7B90
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9280 Offset: 0x2EB9381 VA: 0x2EB9280
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9E30 Offset: 0x2EB9F31 VA: 0x2EB9E30
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBA9E0 Offset: 0x2EBAAE1 VA: 0x2EBA9E0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBB780 Offset: 0x2EBB881 VA: 0x2EBB780
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBC440 Offset: 0x2EBC541 VA: 0x2EBC440
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBD030 Offset: 0x2EBD131 VA: 0x2EBD030
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EC40 Offset: 0x2E3ED41 VA: 0x2E3EC40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E3F7E0 Offset: 0x2E3F8E1 VA: 0x2E3F7E0
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E40330 Offset: 0x2E40431 VA: 0x2E40330
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41120 Offset: 0x2E41221 VA: 0x2E41120
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E428F0 Offset: 0x2E429F1 VA: 0x2E428F0
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43480 Offset: 0x2E43581 VA: 0x2E43480
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43FF0 Offset: 0x2E440F1 VA: 0x2E43FF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E462E0 Offset: 0x2E463E1 VA: 0x2E462E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E46FC0 Offset: 0x2E470C1 VA: 0x2E46FC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E47C50 Offset: 0x2E47D51 VA: 0x2E47C50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E487D0 Offset: 0x2E488D1 VA: 0x2E487D0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E493E0 Offset: 0x2E494E1 VA: 0x2E493E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4A030 Offset: 0x2E4A131 VA: 0x2E4A030
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4AC80 Offset: 0x2E4AD81 VA: 0x2E4AC80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4B820 Offset: 0x2E4B921 VA: 0x2E4B820
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4C500 Offset: 0x2E4C601 VA: 0x2E4C500
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4D1A0 Offset: 0x2E4D2A1 VA: 0x2E4D1A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4DD60 Offset: 0x2E4DE61 VA: 0x2E4DD60
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4E8D0 Offset: 0x2E4E9D1 VA: 0x2E4E8D0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4F440 Offset: 0x2E4F541 VA: 0x2E4F440
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4FF90 Offset: 0x2E50091 VA: 0x2E4FF90
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E50C40 Offset: 0x2E50D41 VA: 0x2E50C40
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E524B0 Offset: 0x2E525B1 VA: 0x2E524B0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53150 Offset: 0x2E53251 VA: 0x2E53150
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53E00 Offset: 0x2E53F01 VA: 0x2E53E00
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E54AC0 Offset: 0x2E54BC1 VA: 0x2E54AC0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E55690 Offset: 0x2E55791 VA: 0x2E55690
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56350 Offset: 0x2E56451 VA: 0x2E56350
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56FE0 Offset: 0x2E570E1 VA: 0x2E56FE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E57BA0 Offset: 0x2E57CA1 VA: 0x2E57BA0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3200560 Offset: 0x3200661 VA: 0x3200560
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32011A0 Offset: 0x32012A1 VA: 0x32011A0
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3201D50 Offset: 0x3201E51 VA: 0x3201D50
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32028C0 Offset: 0x32029C1 VA: 0x32028C0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3203530 Offset: 0x3203631 VA: 0x3203530
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204110 Offset: 0x3204211 VA: 0x3204110
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204C60 Offset: 0x3204D61 VA: 0x3204C60
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32057E0 Offset: 0x32058E1 VA: 0x32057E0
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206390 Offset: 0x3206491 VA: 0x3206390
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206F20 Offset: 0x3207021 VA: 0x3206F20
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3207B40 Offset: 0x3207C41 VA: 0x3207B40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3208790 Offset: 0x3208891 VA: 0x3208790
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209330 Offset: 0x3209431 VA: 0x3209330
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320ABD0 Offset: 0x320ACD1 VA: 0x320ABD0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320B7B0 Offset: 0x320B8B1 VA: 0x320B7B0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320CE40 Offset: 0x320CF41 VA: 0x320CE40
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320D9A0 Offset: 0x320DAA1 VA: 0x320D9A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320E4F0 Offset: 0x320E5F1 VA: 0x320E4F0
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320F050 Offset: 0x320F151 VA: 0x320F050
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320FBA0 Offset: 0x320FCA1 VA: 0x320FBA0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3210700 Offset: 0x3210801 VA: 0x3210700
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211250 Offset: 0x3211351 VA: 0x3211250
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211DB0 Offset: 0x3211EB1 VA: 0x3211DB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3212900 Offset: 0x3212A01 VA: 0x3212900
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213470 Offset: 0x3213571 VA: 0x3213470
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213FC0 Offset: 0x32140C1 VA: 0x3213FC0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3214B00 Offset: 0x3214C01 VA: 0x3214B00
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3215640 Offset: 0x3215741 VA: 0x3215640
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216180 Offset: 0x3216281 VA: 0x3216180
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216CE0 Offset: 0x3216DE1 VA: 0x3216CE0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3217850 Offset: 0x3217951 VA: 0x3217850
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32184E0 Offset: 0x32185E1 VA: 0x32184E0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32190A0 Offset: 0x32191A1 VA: 0x32190A0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3219D20 Offset: 0x3219E21 VA: 0x3219D20
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321AA10 Offset: 0x321AB11 VA: 0x321AA10
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321B5D0 Offset: 0x321B6D1 VA: 0x321B5D0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32C9EC0 Offset: 0x32C9FC1 VA: 0x32C9EC0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CB6E0 Offset: 0x32CB7E1 VA: 0x32CB6E0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CC360 Offset: 0x32CC461 VA: 0x32CC360
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CDC40 Offset: 0x32CDD41 VA: 0x32CDC40
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CE930 Offset: 0x32CEA31 VA: 0x32CE930
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CF510 Offset: 0x32CF611 VA: 0x32CF510
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0150 Offset: 0x32D0251 VA: 0x32D0150
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0DD0 Offset: 0x32D0ED1 VA: 0x32D0DD0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D19B0 Offset: 0x32D1AB1 VA: 0x32D19B0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D2550 Offset: 0x32D2651 VA: 0x32D2550
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D30D0 Offset: 0x32D31D1 VA: 0x32D30D0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D3C40 Offset: 0x32D3D41 VA: 0x32D3C40
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D4870 Offset: 0x32D4971 VA: 0x32D4870
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D53F0 Offset: 0x32D54F1 VA: 0x32D53F0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D5F40 Offset: 0x32D6041 VA: 0x32D5F40
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D6A90 Offset: 0x32D6B91 VA: 0x32D6A90
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D75F0 Offset: 0x32D76F1 VA: 0x32D75F0
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8C80 Offset: 0x32D8D81 VA: 0x32D8C80
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DA310 Offset: 0x32DA411 VA: 0x32DA310
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DAE50 Offset: 0x32DAF51 VA: 0x32DAE50
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DB990 Offset: 0x32DBA91 VA: 0x32DB990
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DC4D0 Offset: 0x32DC5D1 VA: 0x32DC4D0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DD010 Offset: 0x32DD111 VA: 0x32DD010
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DDB70 Offset: 0x32DDC71 VA: 0x32DDB70
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DF250 Offset: 0x32DF351 VA: 0x32DF250
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DFDC0 Offset: 0x32DFEC1 VA: 0x32DFDC0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E0930 Offset: 0x32E0A31 VA: 0x32E0930
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E14C0 Offset: 0x32E15C1 VA: 0x32E14C0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2180 Offset: 0x32E2281 VA: 0x32E2180
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2EB0 Offset: 0x32E2FB1 VA: 0x32E2EB0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E3B40 Offset: 0x32E3C41 VA: 0x32E3B40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E4700 Offset: 0x32E4801 VA: 0x32E4700
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5270 Offset: 0x32E5371 VA: 0x32E5270
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5F00 Offset: 0x32E6001 VA: 0x32E5F00
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F1F30 Offset: 0x30F2031 VA: 0x30F1F30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F2AB0 Offset: 0x30F2BB1 VA: 0x30F2AB0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F35F0 Offset: 0x30F36F1 VA: 0x30F35F0
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4130 Offset: 0x30F4231 VA: 0x30F4130
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4D40 Offset: 0x30F4E41 VA: 0x30F4D40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F59E0 Offset: 0x30F5AE1 VA: 0x30F59E0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7350 Offset: 0x30F7451 VA: 0x30F7350
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7F90 Offset: 0x30F8091 VA: 0x30F7F90
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F8AE0 Offset: 0x30F8BE1 VA: 0x30F8AE0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F9640 Offset: 0x30F9741 VA: 0x30F9640
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FA260 Offset: 0x30FA361 VA: 0x30FA260
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FAEB0 Offset: 0x30FAFB1 VA: 0x30FAEB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FBB00 Offset: 0x30FBC01 VA: 0x30FBB00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FC680 Offset: 0x30FC781 VA: 0x30FC680
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FD220 Offset: 0x30FD321 VA: 0x30FD220
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FDFF0 Offset: 0x30FE0F1 VA: 0x30FDFF0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FEDD0 Offset: 0x30FEED1 VA: 0x30FEDD0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FF9B0 Offset: 0x30FFAB1 VA: 0x30FF9B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3100510 Offset: 0x3100611 VA: 0x3100510
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101130 Offset: 0x3101231 VA: 0x3101130
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101DD0 Offset: 0x3101ED1 VA: 0x3101DD0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3102970 Offset: 0x3102A71 VA: 0x3102970
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3103620 Offset: 0x3103721 VA: 0x3103620
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31042D0 Offset: 0x31043D1 VA: 0x31042D0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3104E80 Offset: 0x3104F81 VA: 0x3104E80
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3105AA0 Offset: 0x3105BA1 VA: 0x3105AA0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3106640 Offset: 0x3106741 VA: 0x3106640
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107190 Offset: 0x3107291 VA: 0x3107190
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107D30 Offset: 0x3107E31 VA: 0x3107D30
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3108900 Offset: 0x3108A01 VA: 0x3108900
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3109470 Offset: 0x3109571 VA: 0x3109470
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310A0F0 Offset: 0x310A1F1 VA: 0x310A0F0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310AE10 Offset: 0x310AF11 VA: 0x310AE10
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310BA30 Offset: 0x310BB31 VA: 0x310BA30
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310C5C0 Offset: 0x310C6C1 VA: 0x310C5C0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310D130 Offset: 0x310D231 VA: 0x310D130
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310DF40 Offset: 0x310E041 VA: 0x310DF40
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310EBA0 Offset: 0x310ECA1 VA: 0x310EBA0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310F7C0 Offset: 0x310F8C1 VA: 0x310F7C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA7B20 Offset: 0x2EA7C21 VA: 0x2EA7B20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA8770 Offset: 0x2EA8871 VA: 0x2EA8770
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9410 Offset: 0x2EA9511 VA: 0x2EA9410
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9FD0 Offset: 0x2EAA0D1 VA: 0x2EA9FD0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAABF0 Offset: 0x2EAACF1 VA: 0x2EAABF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAB890 Offset: 0x2EAB991 VA: 0x2EAB890
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAC450 Offset: 0x2EAC551 VA: 0x2EAC450
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAD0C0 Offset: 0x2EAD1C1 VA: 0x2EAD0C0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAE990 Offset: 0x2EAEA91 VA: 0x2EAE990
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAF5E0 Offset: 0x2EAF6E1 VA: 0x2EAF5E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB0370 Offset: 0x2EB0471 VA: 0x2EB0370
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1090 Offset: 0x2EB1191 VA: 0x2EB1090
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1D10 Offset: 0x2EB1E11 VA: 0x2EB1D10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3480 Offset: 0x2EB3581 VA: 0x2EB3480
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3FF0 Offset: 0x2EB40F1 VA: 0x2EB3FF0
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB4B40 Offset: 0x2EB4C41 VA: 0x2EB4B40
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB56A0 Offset: 0x2EB57A1 VA: 0x2EB56A0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB6400 Offset: 0x2EB6501 VA: 0x2EB6400
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB70D0 Offset: 0x2EB71D1 VA: 0x2EB70D0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB7C70 Offset: 0x2EB7D71 VA: 0x2EB7C70
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB87C0 Offset: 0x2EB88C1 VA: 0x2EB87C0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9360 Offset: 0x2EB9461 VA: 0x2EB9360
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9F10 Offset: 0x2EBA011 VA: 0x2EB9F10
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBAAC0 Offset: 0x2EBABC1 VA: 0x2EBAAC0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBB8E0 Offset: 0x2EBB9E1 VA: 0x2EBB8E0
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBC520 Offset: 0x2EBC621 VA: 0x2EBC520
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EDF0 Offset: 0x2E3EEF1 VA: 0x2E3EDF0
	|-EqualityComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2E3F960 Offset: 0x2E3FA61 VA: 0x2E3F960
	|-EqualityComparer<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x2E404A0 Offset: 0x2E405A1 VA: 0x2E404A0
	|-EqualityComparer<BitVector32Int>..ctor
	|
	|-RVA: 0x2E41390 Offset: 0x2E41491 VA: 0x2E41390
	|-EqualityComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-EqualityComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2E42A70 Offset: 0x2E42B71 VA: 0x2E42A70
	|-EqualityComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2E43600 Offset: 0x2E43701 VA: 0x2E43600
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2E44170 Offset: 0x2E44271 VA: 0x2E44170
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E44CB0 Offset: 0x2E44DB1 VA: 0x2E44CB0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E457F0 Offset: 0x2E458F1 VA: 0x2E457F0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2E471A0 Offset: 0x2E472A1 VA: 0x2E471A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2E47E00 Offset: 0x2E47F01 VA: 0x2E47E00
	|-EqualityComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2E48940 Offset: 0x2E48A41 VA: 0x2E48940
	|-EqualityComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2E49590 Offset: 0x2E49691 VA: 0x2E49590
	|-EqualityComparer<EffectDataTable>..ctor
	|
	|-RVA: 0x2E4A1E0 Offset: 0x2E4A2E1 VA: 0x2E4A1E0
	|-EqualityComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2E4AE30 Offset: 0x2E4AF31 VA: 0x2E4AE30
	|-EqualityComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2E4B9A0 Offset: 0x2E4BAA1 VA: 0x2E4B9A0
	|-EqualityComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2E4C700 Offset: 0x2E4C801 VA: 0x2E4C700
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E4D350 Offset: 0x2E4D451 VA: 0x2E4D350
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E4DEE0 Offset: 0x2E4DFE1 VA: 0x2E4DEE0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E4EA50 Offset: 0x2E4EB51 VA: 0x2E4EA50
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E4F5C0 Offset: 0x2E4F6C1 VA: 0x2E4F5C0
	|-EqualityComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2E50100 Offset: 0x2E50201 VA: 0x2E50100
	|-EqualityComparer<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E50E30 Offset: 0x2E50F31 VA: 0x2E50E30
	|-EqualityComparer<MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E519A0 Offset: 0x2E51AA1 VA: 0x2E519A0
	|-EqualityComparer<MiningDataTable>..ctor
	|
	|-RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	|-EqualityComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2E53310 Offset: 0x2E53411 VA: 0x2E53310
	|-EqualityComparer<MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53FD0 Offset: 0x2E540D1 VA: 0x2E53FD0
	|-EqualityComparer<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54CA0 Offset: 0x2E54DA1 VA: 0x2E54CA0
	|-EqualityComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E55810 Offset: 0x2E55911 VA: 0x2E55810
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	|-EqualityComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2E57190 Offset: 0x2E57291 VA: 0x2E57190
	|-EqualityComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2E57D20 Offset: 0x2E57E21 VA: 0x2E57D20
	|-EqualityComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31FEF20 Offset: 0x31FF021 VA: 0x31FEF20
	|-EqualityComparer<OrderSaveData>..ctor
	|
	|-RVA: 0x31FFB70 Offset: 0x31FFC71 VA: 0x31FFB70
	|-EqualityComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32006E0 Offset: 0x32007E1 VA: 0x32006E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3201360 Offset: 0x3201461 VA: 0x3201360
	|-EqualityComparer<Parameter>..ctor
	|
	|-RVA: 0x3201ED0 Offset: 0x3201FD1 VA: 0x3201ED0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x3202A40 Offset: 0x3202B41 VA: 0x3202A40
	|-EqualityComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x3203700 Offset: 0x3203801 VA: 0x3203700
	|-EqualityComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3204290 Offset: 0x3204391 VA: 0x3204290
	|-EqualityComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3204DD0 Offset: 0x3204ED1 VA: 0x3204DD0
	|-EqualityComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3205960 Offset: 0x3205A61 VA: 0x3205960
	|-EqualityComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3206530 Offset: 0x3206631 VA: 0x3206530
	|-EqualityComparer<ProfilerFrame>..ctor
	|
	|-RVA: 0x32070A0 Offset: 0x32071A1 VA: 0x32070A0
	|-EqualityComparer<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x3207CF0 Offset: 0x3207DF1 VA: 0x3207CF0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x3208940 Offset: 0x3208A41 VA: 0x3208940
	|-EqualityComparer<Schedule>..ctor
	|
	|-RVA: 0x32094B0 Offset: 0x32095B1 VA: 0x32094B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x320A040 Offset: 0x320A141 VA: 0x320A040
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-EqualityComparer<CurveSample>..ctor
	|
	|-RVA: 0x320B930 Offset: 0x320BA31 VA: 0x320B930
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x320C470 Offset: 0x320C571 VA: 0x320C470
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x320CFB0 Offset: 0x320D0B1 VA: 0x320CFB0
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x320DB20 Offset: 0x320DC21 VA: 0x320DB20
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x320E660 Offset: 0x320E761 VA: 0x320E660
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x320F1D0 Offset: 0x320F2D1 VA: 0x320F1D0
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x320FD10 Offset: 0x320FE11 VA: 0x320FD10
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3210880 Offset: 0x3210981 VA: 0x3210880
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32113C0 Offset: 0x32114C1 VA: 0x32113C0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3211F30 Offset: 0x3212031 VA: 0x3211F30
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3212A80 Offset: 0x3212B81 VA: 0x3212A80
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x32135F0 Offset: 0x32136F1 VA: 0x32135F0
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3214130 Offset: 0x3214231 VA: 0x3214130
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3214C70 Offset: 0x3214D71 VA: 0x3214C70
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x32157B0 Offset: 0x32158B1 VA: 0x32157B0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x32162F0 Offset: 0x32163F1 VA: 0x32162F0
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3216E60 Offset: 0x3216F61 VA: 0x3216E60
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x32179D0 Offset: 0x3217AD1 VA: 0x32179D0
	|-EqualityComparer<Memory<object>>..ctor
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3219210 Offset: 0x3219311 VA: 0x3219210
	|-EqualityComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3219F00 Offset: 0x321A001 VA: 0x3219F00
	|-EqualityComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x321ABF0 Offset: 0x321ACF1 VA: 0x321ABF0
	|-EqualityComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x321B740 Offset: 0x321B841 VA: 0x321B740
	|-EqualityComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x32CA080 Offset: 0x32CA181 VA: 0x32CA080
	|-EqualityComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x32CAC20 Offset: 0x32CAD21 VA: 0x32CAC20
	|-EqualityComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x32CB8A0 Offset: 0x32CB9A1 VA: 0x32CB8A0
	|-EqualityComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x32CC520 Offset: 0x32CC621 VA: 0x32CC520
	|-EqualityComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x32CD070 Offset: 0x32CD171 VA: 0x32CD070
	|-EqualityComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x32CDE70 Offset: 0x32CDF71 VA: 0x32CDE70
	|-EqualityComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x32CEAF0 Offset: 0x32CEBF1 VA: 0x32CEAF0
	|-EqualityComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x32CF690 Offset: 0x32CF791 VA: 0x32CF690
	|-EqualityComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x32D0310 Offset: 0x32D0411 VA: 0x32D0310
	|-EqualityComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32D0F90 Offset: 0x32D1091 VA: 0x32D0F90
	|-EqualityComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x32D1B30 Offset: 0x32D1C31 VA: 0x32D1B30
	|-EqualityComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x32D26D0 Offset: 0x32D27D1 VA: 0x32D26D0
	|-EqualityComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x32D3240 Offset: 0x32D3341 VA: 0x32D3240
	|-EqualityComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32D3DB0 Offset: 0x32D3EB1 VA: 0x32D3DB0
	|-EqualityComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x32D4A30 Offset: 0x32D4B31 VA: 0x32D4A30
	|-EqualityComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32D5550 Offset: 0x32D5651 VA: 0x32D5550
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x32D60C0 Offset: 0x32D61C1 VA: 0x32D60C0
	|-EqualityComparer<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x32D6C00 Offset: 0x32D6D01 VA: 0x32D6C00
	|-EqualityComparer<Label>..ctor
	|
	|-RVA: 0x32D7770 Offset: 0x32D7871 VA: 0x32D7770
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x32D82B0 Offset: 0x32D83B1 VA: 0x32D82B0
	|-EqualityComparer<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x32D8DF0 Offset: 0x32D8EF1 VA: 0x32D8DF0
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x32D9940 Offset: 0x32D9A41 VA: 0x32D9940
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x32DA480 Offset: 0x32DA581 VA: 0x32DA480
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x32DAFC0 Offset: 0x32DB0C1 VA: 0x32DAFC0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x32DBB00 Offset: 0x32DBC01 VA: 0x32DBB00
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x32DC640 Offset: 0x32DC741 VA: 0x32DC640
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32DD180 Offset: 0x32DD281 VA: 0x32DD180
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32DDCF0 Offset: 0x32DDDF1 VA: 0x32DDCF0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32DE860 Offset: 0x32DE961 VA: 0x32DE860
	|-EqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32DF3D0 Offset: 0x32DF4D1 VA: 0x32DF3D0
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32E0AB0 Offset: 0x32E0BB1 VA: 0x32E0AB0
	|-EqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x32E1640 Offset: 0x32E1741 VA: 0x32E1640
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32E2370 Offset: 0x32E2471 VA: 0x32E2370
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32E30A0 Offset: 0x32E31A1 VA: 0x32E30A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32E3CF0 Offset: 0x32E3DF1 VA: 0x32E3CF0
	|-EqualityComparer<TransitionTables>..ctor
	|
	|-RVA: 0x32E4880 Offset: 0x32E4981 VA: 0x32E4880
	|-EqualityComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32E60E0 Offset: 0x32E61E1 VA: 0x32E60E0
	|-EqualityComparer<CapEdge>..ctor
	|
	|-RVA: 0x30F20E0 Offset: 0x30F21E1 VA: 0x30F20E0
	|-EqualityComparer<ClippedEdge>..ctor
	|
	|-RVA: 0x30F2C20 Offset: 0x30F2D21 VA: 0x30F2C20
	|-EqualityComparer<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x30F3760 Offset: 0x30F3861 VA: 0x30F3760
	|-EqualityComparer<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x30F42A0 Offset: 0x30F43A1 VA: 0x30F42A0
	|-EqualityComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x30F4EF0 Offset: 0x30F4FF1 VA: 0x30F4EF0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x30F6720 Offset: 0x30F6821 VA: 0x30F6720
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x30F75A0 Offset: 0x30F76A1 VA: 0x30F75A0
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x30F8110 Offset: 0x30F8211 VA: 0x30F8110
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x30F8C50 Offset: 0x30F8D51 VA: 0x30F8C50
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x30F97C0 Offset: 0x30F98C1 VA: 0x30F97C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x30FA410 Offset: 0x30FA511 VA: 0x30FA410
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x30FB060 Offset: 0x30FB161 VA: 0x30FB060
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x30FBCB0 Offset: 0x30FBDB1 VA: 0x30FBCB0
	|-EqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x30FC7F0 Offset: 0x30FC8F1 VA: 0x30FC7F0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x30FD3C0 Offset: 0x30FD4C1 VA: 0x30FD3C0
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x30FE240 Offset: 0x30FE341 VA: 0x30FE240
	|-EqualityComparer<CombineInstance>..ctor
	|
	|-RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x30FFB20 Offset: 0x30FFC21 VA: 0x30FFB20
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x3100690 Offset: 0x3100791 VA: 0x3100690
	|-EqualityComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31012E0 Offset: 0x31013E1 VA: 0x31012E0
	|-EqualityComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x3101FA0 Offset: 0x31020A1 VA: 0x3101FA0
	|-EqualityComparer<Keyframe>..ctor
	|
	|-RVA: 0x3102AE0 Offset: 0x3102BE1 VA: 0x3102AE0
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3103810 Offset: 0x3103911 VA: 0x3103810
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3104490 Offset: 0x3104591 VA: 0x3104490
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3105000 Offset: 0x3105101 VA: 0x3105000
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3105C50 Offset: 0x3105D51 VA: 0x3105C50
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x31067C0 Offset: 0x31068C1 VA: 0x31067C0
	|-EqualityComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x3107300 Offset: 0x3107401 VA: 0x3107300
	|-EqualityComparer<Edge>..ctor
	|
	|-RVA: 0x3107ED0 Offset: 0x3107FD1 VA: 0x3107ED0
	|-EqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x3108AA0 Offset: 0x3108BA1 VA: 0x3108AA0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x31095E0 Offset: 0x31096E1 VA: 0x31095E0
	|-EqualityComparer<RangeInt>..ctor
	|
	|-RVA: 0x310A2D0 Offset: 0x310A3D1 VA: 0x310A2D0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x310B000 Offset: 0x310B101 VA: 0x310B000
	|-EqualityComparer<RaycastHit>..ctor
	|
	|-RVA: 0x310BBD0 Offset: 0x310BCD1 VA: 0x310BBD0
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x310C740 Offset: 0x310C841 VA: 0x310C740
	|-EqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x310D2B0 Offset: 0x310D3B1 VA: 0x310D2B0
	|-EqualityComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x310ED20 Offset: 0x310EE21 VA: 0x310ED20
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x310F970 Offset: 0x310FA71 VA: 0x310F970
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EA7CD0 Offset: 0x2EA7DD1 VA: 0x2EA7CD0
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EA8920 Offset: 0x2EA8A21 VA: 0x2EA8920
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EA95E0 Offset: 0x2EA96E1 VA: 0x2EA95E0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EAA150 Offset: 0x2EAA251 VA: 0x2EAA150
	|-EqualityComparer<SceneInstance>..ctor
	|
	|-RVA: 0x2EAADA0 Offset: 0x2EAAEA1 VA: 0x2EAADA0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2EABA60 Offset: 0x2EABB61 VA: 0x2EABA60
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EAC5D0 Offset: 0x2EAC6D1 VA: 0x2EAC5D0
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EAD2A0 Offset: 0x2EAD3A1 VA: 0x2EAD2A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2EADEF0 Offset: 0x2EADFF1 VA: 0x2EADEF0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EB1270 Offset: 0x2EB1371 VA: 0x2EB1270
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EB1EC0 Offset: 0x2EB1FC1 VA: 0x2EB1EC0
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EB2A90 Offset: 0x2EB2B91 VA: 0x2EB2A90
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x2EB3600 Offset: 0x2EB3701 VA: 0x2EB3600
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2EB4170 Offset: 0x2EB4271 VA: 0x2EB4170
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2EB4CB0 Offset: 0x2EB4DB1 VA: 0x2EB4CB0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2EB5820 Offset: 0x2EB5921 VA: 0x2EB5820
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x2EB6630 Offset: 0x2EB6731 VA: 0x2EB6630
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2EB7DF0 Offset: 0x2EB7EF1 VA: 0x2EB7DF0
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EB8930 Offset: 0x2EB8A31 VA: 0x2EB8930
	|-EqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EB9500 Offset: 0x2EB9601 VA: 0x2EB9500
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EBA090 Offset: 0x2EBA191 VA: 0x2EBA090
	|-EqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EBAC60 Offset: 0x2EBAD61 VA: 0x2EBAC60
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2EBBB50 Offset: 0x2EBBC51 VA: 0x2EBBB50
	|-EqualityComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-EqualityComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x2EBD2E0 Offset: 0x2EBD3E1 VA: 0x2EBD2E0
	|-EqualityComparer<stCommand_t>..ctor
	*/
}

[TypeDependencyAttribute] // RVA: 0xB3A20 Offset: 0xB3B21 VA: 0xB3A20
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1441
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A50 Offset: 0x32D4B51 VA: 0x32D4A50
	|-EqualityComparer<Font>.get_Default
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x2E3E1C0 Offset: 0x2E3E2C1 VA: 0x2E3E1C0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.get_Default
	|
	|-RVA: 0x2E3EE10 Offset: 0x2E3EF11 VA: 0x2E3EE10
	|-EqualityComparer<JSONDeserialization.TaskField>.get_Default
	|
	|-RVA: 0x2E3F980 Offset: 0x2E3FA81 VA: 0x2E3F980
	|-EqualityComparer<BitVector32Int>.get_Default
	|
	|-RVA: 0x2E404C0 Offset: 0x2E405C1 VA: 0x2E404C0
	|-EqualityComparer<BuildItemData>.get_Default
	|
	|-RVA: 0x2E413B0 Offset: 0x2E414B1 VA: 0x2E413B0
	|-EqualityComparer<ButtonLinker.LinkObject>.get_Default
	|
	|-RVA: 0x2E41F20 Offset: 0x2E42021 VA: 0x2E41F20
	|-EqualityComparer<CharaCallTable.BustupTable>.get_Default
	|
	|-RVA: 0x2E42A90 Offset: 0x2E42B91 VA: 0x2E42A90
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.get_Default
	|
	|-RVA: 0x2E43620 Offset: 0x2E43721 VA: 0x2E43620
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x2E44190 Offset: 0x2E44291 VA: 0x2E44190
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x2E44CD0 Offset: 0x2E44DD1 VA: 0x2E44CD0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x2E45810 Offset: 0x2E45911 VA: 0x2E45810
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x2E464D0 Offset: 0x2E465D1 VA: 0x2E464D0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x2E471C0 Offset: 0x2E472C1 VA: 0x2E471C0
	|-EqualityComparer<CropDataTable>.get_Default
	|
	|-RVA: 0x2E47E20 Offset: 0x2E47F21 VA: 0x2E47E20
	|-EqualityComparer<DropItemParam>.get_Default
	|
	|-RVA: 0x2E48960 Offset: 0x2E48A61 VA: 0x2E48960
	|-EqualityComparer<EffectDataTable>.get_Default
	|
	|-RVA: 0x2E495B0 Offset: 0x2E496B1 VA: 0x2E495B0
	|-EqualityComparer<ErosionBrush.UndoStep>.get_Default
	|
	|-RVA: 0x2E4A200 Offset: 0x2E4A301 VA: 0x2E4A200
	|-EqualityComparer<EventCheckId>.get_Default
	|
	|-RVA: 0x2E4AE50 Offset: 0x2E4AF51 VA: 0x2E4AE50
	|-EqualityComparer<EventFlagProgressData>.get_Default
	|
	|-RVA: 0x2E4B9C0 Offset: 0x2E4BAC1 VA: 0x2E4B9C0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.get_Default
	|
	|-RVA: 0x2E4C720 Offset: 0x2E4C821 VA: 0x2E4C720
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.get_Default
	|
	|-RVA: 0x2E4D370 Offset: 0x2E4D471 VA: 0x2E4D370
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.get_Default
	|
	|-RVA: 0x2E4DF00 Offset: 0x2E4E001 VA: 0x2E4DF00
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.get_Default
	|
	|-RVA: 0x2E4EA70 Offset: 0x2E4EB71 VA: 0x2E4EA70
	|-EqualityComparer<FesNpcScoreData>.get_Default
	|
	|-RVA: 0x2E4F5E0 Offset: 0x2E4F6E1 VA: 0x2E4F5E0
	|-EqualityComparer<GimmickLayoutDataTable>.get_Default
	|
	|-RVA: 0x2E50120 Offset: 0x2E50221 VA: 0x2E50120
	|-EqualityComparer<MineTypeDataTable>.get_Default
	|
	|-RVA: 0x2E50E50 Offset: 0x2E50F51 VA: 0x2E50E50
	|-EqualityComparer<MiningDataTable>.get_Default
	|
	|-RVA: 0x2E519C0 Offset: 0x2E51AC1 VA: 0x2E519C0
	|-EqualityComparer<MiningPointSaveData>.get_Default
	|
	|-RVA: 0x2E526B0 Offset: 0x2E527B1 VA: 0x2E526B0
	|-EqualityComparer<MonsterDataTable>.get_Default
	|
	|-RVA: 0x2E53330 Offset: 0x2E53431 VA: 0x2E53330
	|-EqualityComparer<MonsterFootStepEventDataTable>.get_Default
	|
	|-RVA: 0x2E53FF0 Offset: 0x2E540F1 VA: 0x2E53FF0
	|-EqualityComparer<MonsterHutSaveData>.get_Default
	|
	|-RVA: 0x2E54CC0 Offset: 0x2E54DC1 VA: 0x2E54CC0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.get_Default
	|
	|-RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
	|-EqualityComparer<NPCActionData>.get_Default
	|
	|-RVA: 0x2E56560 Offset: 0x2E56661 VA: 0x2E56560
	|-EqualityComparer<NpcPlaceSchedule>.get_Default
	|
	|-RVA: 0x2E571B0 Offset: 0x2E572B1 VA: 0x2E571B0
	|-EqualityComparer<OrderLotterySaveParameter>.get_Default
	|
	|-RVA: 0x31FE270 Offset: 0x31FE371 VA: 0x31FE270
	|-EqualityComparer<OrderSaveData>.get_Default
	|
	|-RVA: 0x31FEF40 Offset: 0x31FF041 VA: 0x31FEF40
	|-EqualityComparer<OrderSaveParameter>.get_Default
	|
	|-RVA: 0x31FFB90 Offset: 0x31FFC91 VA: 0x31FFB90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3200700 Offset: 0x3200801 VA: 0x3200700
	|-EqualityComparer<Parameter>.get_Default
	|
	|-RVA: 0x3201380 Offset: 0x3201481 VA: 0x3201380
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.get_Default
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-EqualityComparer<ShopCatalogPage>.get_Default
	|
	|-RVA: 0x3202A60 Offset: 0x3202B61 VA: 0x3202A60
	|-EqualityComparer<ShopNpcTalk>.get_Default
	|
	|-RVA: 0x3203720 Offset: 0x3203821 VA: 0x3203720
	|-EqualityComparer<SubtitleDataTable.Data>.get_Default
	|
	|-RVA: 0x32042B0 Offset: 0x32043B1 VA: 0x32042B0
	|-EqualityComparer<SubtitleDataTable.DataList>.get_Default
	|
	|-RVA: 0x3204DF0 Offset: 0x3204EF1 VA: 0x3204DF0
	|-EqualityComparer<SubtitleHudDataTable.Data>.get_Default
	|
	|-RVA: 0x3205980 Offset: 0x3205A81 VA: 0x3205980
	|-EqualityComparer<ProfilerFrame>.get_Default
	|
	|-RVA: 0x3206550 Offset: 0x3206651 VA: 0x3206550
	|-EqualityComparer<NumberControl.ValueRange>.get_Default
	|
	|-RVA: 0x32070C0 Offset: 0x32071C1 VA: 0x32070C0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.get_Default
	|
	|-RVA: 0x3207D10 Offset: 0x3207E11 VA: 0x3207D10
	|-EqualityComparer<Schedule>.get_Default
	|
	|-RVA: 0x3208960 Offset: 0x3208A61 VA: 0x3208960
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x32094D0 Offset: 0x32095D1 VA: 0x32094D0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.get_Default
	|
	|-RVA: 0x320A060 Offset: 0x320A161 VA: 0x320A060
	|-EqualityComparer<CurveSample>.get_Default
	|
	|-RVA: 0x320AE00 Offset: 0x320AF01 VA: 0x320AE00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x320B950 Offset: 0x320BA51 VA: 0x320B950
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x320C490 Offset: 0x320C591 VA: 0x320C490
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x320CFD0 Offset: 0x320D0D1 VA: 0x320CFD0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x320DB40 Offset: 0x320DC41 VA: 0x320DB40
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x320E680 Offset: 0x320E781 VA: 0x320E680
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x320FD30 Offset: 0x320FE31 VA: 0x320FD30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x32113E0 Offset: 0x32114E1 VA: 0x32113E0
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3211F50 Offset: 0x3212051 VA: 0x3211F50
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3212AA0 Offset: 0x3212BA1 VA: 0x3212AA0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3213610 Offset: 0x3213711 VA: 0x3213610
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3214150 Offset: 0x3214251 VA: 0x3214150
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3214C90 Offset: 0x3214D91 VA: 0x3214C90
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x32157D0 Offset: 0x32158D1 VA: 0x32157D0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3216310 Offset: 0x3216411 VA: 0x3216310
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3216E80 Offset: 0x3216F81 VA: 0x3216E80
	|-EqualityComparer<Memory<object>>.get_Default
	|
	|-RVA: 0x32179F0 Offset: 0x3217AF1 VA: 0x32179F0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.get_Default
	|
	|-RVA: 0x32186E0 Offset: 0x32187E1 VA: 0x32186E0
	|-EqualityComparer<Nullable<Int32Enum>>.get_Default
	|
	|-RVA: 0x3219230 Offset: 0x3219331 VA: 0x3219230
	|-EqualityComparer<Nullable<Bounds>>.get_Default
	|
	|-RVA: 0x3219F20 Offset: 0x321A021 VA: 0x3219F20
	|-EqualityComparer<Nullable<BoundsInt>>.get_Default
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-EqualityComparer<Nullable<Color32>>.get_Default
	|
	|-RVA: 0x32C9420 Offset: 0x32C9521 VA: 0x32C9420
	|-EqualityComparer<Nullable<Color>>.get_Default
	|
	|-RVA: 0x32CA0A0 Offset: 0x32CA1A1 VA: 0x32CA0A0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.get_Default
	|
	|-RVA: 0x32CAC40 Offset: 0x32CAD41 VA: 0x32CAC40
	|-EqualityComparer<Nullable<GradientColorKey>>.get_Default
	|
	|-RVA: 0x32CB8C0 Offset: 0x32CB9C1 VA: 0x32CB8C0
	|-EqualityComparer<Nullable<Keyframe>>.get_Default
	|
	|-RVA: 0x32CC540 Offset: 0x32CC641 VA: 0x32CC540
	|-EqualityComparer<Nullable<LayerMask>>.get_Default
	|
	|-RVA: 0x32CD090 Offset: 0x32CD191 VA: 0x32CD090
	|-EqualityComparer<Nullable<Matrix4x4>>.get_Default
	|
	|-RVA: 0x32CDE90 Offset: 0x32CDF91 VA: 0x32CDE90
	|-EqualityComparer<Nullable<Quaternion>>.get_Default
	|
	|-RVA: 0x32CEB10 Offset: 0x32CEC11 VA: 0x32CEB10
	|-EqualityComparer<Nullable<RangeInt>>.get_Default
	|
	|-RVA: 0x32CF6B0 Offset: 0x32CF7B1 VA: 0x32CF6B0
	|-EqualityComparer<Nullable<Rect>>.get_Default
	|
	|-RVA: 0x32D0330 Offset: 0x32D0431 VA: 0x32D0330
	|-EqualityComparer<Nullable<RectInt>>.get_Default
	|
	|-RVA: 0x32D0FB0 Offset: 0x32D10B1 VA: 0x32D0FB0
	|-EqualityComparer<Nullable<Vector2>>.get_Default
	|
	|-RVA: 0x32D1B50 Offset: 0x32D1C51 VA: 0x32D1B50
	|-EqualityComparer<Nullable<Vector2Int>>.get_Default
	|
	|-RVA: 0x32D26F0 Offset: 0x32D27F1 VA: 0x32D26F0
	|-EqualityComparer<Nullable<Vector3>>.get_Default
	|
	|-RVA: 0x32D3260 Offset: 0x32D3361 VA: 0x32D3260
	|-EqualityComparer<Nullable<Vector3Int>>.get_Default
	|
	|-RVA: 0x32D3DD0 Offset: 0x32D3ED1 VA: 0x32D3DD0
	|-EqualityComparer<Nullable<Vector4>>.get_Default
	|
	|-RVA: 0x32D5570 Offset: 0x32D5671 VA: 0x32D5570
	|-EqualityComparer<ReadOnlyMemory<object>>.get_Default
	|
	|-RVA: 0x32D60E0 Offset: 0x32D61E1 VA: 0x32D60E0
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x32D6C20 Offset: 0x32D6D21 VA: 0x32D6C20
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x32D7790 Offset: 0x32D7891 VA: 0x32D7790
	|-EqualityComparer<RuntimeTypeHandle>.get_Default
	|
	|-RVA: 0x32D82D0 Offset: 0x32D83D1 VA: 0x32D82D0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x32D8E10 Offset: 0x32D8F11 VA: 0x32D8E10
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x32D9960 Offset: 0x32D9A61 VA: 0x32D9960
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x32DA4A0 Offset: 0x32DA5A1 VA: 0x32DA4A0
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x32DAFE0 Offset: 0x32DB0E1 VA: 0x32DAFE0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DC660 Offset: 0x32DC761 VA: 0x32DC660
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x32DD1A0 Offset: 0x32DD2A1 VA: 0x32DD1A0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x32DDD10 Offset: 0x32DDE11 VA: 0x32DDD10
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DE880 Offset: 0x32DE981 VA: 0x32DE880
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x32DF3F0 Offset: 0x32DF4F1 VA: 0x32DF3F0
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x32DFF60 Offset: 0x32E0061 VA: 0x32DFF60
	|-EqualityComparer<ValueTuple<float, float>>.get_Default
	|
	|-RVA: 0x32E0AD0 Offset: 0x32E0BD1 VA: 0x32E0AD0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Default
	|
	|-RVA: 0x32E1660 Offset: 0x32E1761 VA: 0x32E1660
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Default
	|
	|-RVA: 0x32E2390 Offset: 0x32E2491 VA: 0x32E2390
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x32E30C0 Offset: 0x32E31C1 VA: 0x32E30C0
	|-EqualityComparer<TransitionTables>.get_Default
	|
	|-RVA: 0x32E3D10 Offset: 0x32E3E11 VA: 0x32E3D10
	|-EqualityComparer<TutorialUnlockFlagData>.get_Default
	|
	|-RVA: 0x32E48A0 Offset: 0x32E49A1 VA: 0x32E48A0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.get_Default
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-EqualityComparer<CapEdge>.get_Default
	|
	|-RVA: 0x30F14B0 Offset: 0x30F15B1 VA: 0x30F14B0
	|-EqualityComparer<ClippedEdge>.get_Default
	|
	|-RVA: 0x30F2100 Offset: 0x30F2201 VA: 0x30F2100
	|-EqualityComparer<EdgeKeyByHash>.get_Default
	|
	|-RVA: 0x30F2C40 Offset: 0x30F2D41 VA: 0x30F2C40
	|-EqualityComparer<EdgeKeyByIndex>.get_Default
	|
	|-RVA: 0x30F3780 Offset: 0x30F3881 VA: 0x30F3780
	|-EqualityComparer<MeshDataConnectivity.Face>.get_Default
	|
	|-RVA: 0x30F42C0 Offset: 0x30F43C1 VA: 0x30F42C0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.get_Default
	|
	|-RVA: 0x30F4F10 Offset: 0x30F5011 VA: 0x30F4F10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.get_Default
	|
	|-RVA: 0x30F5BD0 Offset: 0x30F5CD1 VA: 0x30F5BD0
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x30F6740 Offset: 0x30F6841 VA: 0x30F6740
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x30F75C0 Offset: 0x30F76C1 VA: 0x30F75C0
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x30F8130 Offset: 0x30F8231 VA: 0x30F8130
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x30F8C70 Offset: 0x30F8D71 VA: 0x30F8C70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x30F97E0 Offset: 0x30F98E1 VA: 0x30F97E0
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x30FA430 Offset: 0x30FA531 VA: 0x30FA430
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x30FB080 Offset: 0x30FB181 VA: 0x30FB080
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x30FBCD0 Offset: 0x30FBDD1 VA: 0x30FBCD0
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x30FC810 Offset: 0x30FC911 VA: 0x30FC810
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x30FD3E0 Offset: 0x30FD4E1 VA: 0x30FD3E0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x30FE260 Offset: 0x30FE361 VA: 0x30FE260
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x30FF000 Offset: 0x30FF101 VA: 0x30FF000
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	|
	|-RVA: 0x30FFB40 Offset: 0x30FFC41 VA: 0x30FFB40
	|-EqualityComparer<GradientAlphaKey>.get_Default
	|
	|-RVA: 0x31006B0 Offset: 0x31007B1 VA: 0x31006B0
	|-EqualityComparer<GradientColorKey>.get_Default
	|
	|-RVA: 0x3101300 Offset: 0x3101401 VA: 0x3101300
	|-EqualityComparer<Keyframe>.get_Default
	|
	|-RVA: 0x3101FC0 Offset: 0x31020C1 VA: 0x3101FC0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3102B00 Offset: 0x3102C01 VA: 0x3102B00
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x31044B0 Offset: 0x31045B1 VA: 0x31044B0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3105020 Offset: 0x3105121 VA: 0x3105020
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3105C70 Offset: 0x3105D71 VA: 0x3105C70
	|-EqualityComparer<PlayableGraph>.get_Default
	|
	|-RVA: 0x31067E0 Offset: 0x31068E1 VA: 0x31067E0
	|-EqualityComparer<Edge>.get_Default
	|
	|-RVA: 0x3107320 Offset: 0x3107421 VA: 0x3107320
	|-EqualityComparer<IntVec3>.get_Default
	|
	|-RVA: 0x3107EF0 Offset: 0x3107FF1 VA: 0x3107EF0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3108AC0 Offset: 0x3108BC1 VA: 0x3108AC0
	|-EqualityComparer<RangeInt>.get_Default
	|
	|-RVA: 0x3109600 Offset: 0x3109701 VA: 0x3109600
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x310A2F0 Offset: 0x310A3F1 VA: 0x310A2F0
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x310B020 Offset: 0x310B121 VA: 0x310B020
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x310BBF0 Offset: 0x310BCF1 VA: 0x310BBF0
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x310C760 Offset: 0x310C861 VA: 0x310C760
	|-EqualityComparer<ReflectionProbeBlendInfo>.get_Default
	|
	|-RVA: 0x310D2D0 Offset: 0x310D3D1 VA: 0x310D2D0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x310E1D0 Offset: 0x310E2D1 VA: 0x310E1D0
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x310ED40 Offset: 0x310EE41 VA: 0x310ED40
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x2EA70A0 Offset: 0x2EA71A1 VA: 0x2EA70A0
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x2EA7CF0 Offset: 0x2EA7DF1 VA: 0x2EA7CF0
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.get_Default
	|
	|-RVA: 0x2EA8940 Offset: 0x2EA8A41 VA: 0x2EA8940
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x2EA9600 Offset: 0x2EA9701 VA: 0x2EA9600
	|-EqualityComparer<SceneInstance>.get_Default
	|
	|-RVA: 0x2EAA170 Offset: 0x2EAA271 VA: 0x2EAA170
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x2EAADC0 Offset: 0x2EAAEC1 VA: 0x2EAADC0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x2EABA80 Offset: 0x2EABB81 VA: 0x2EABA80
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x2EAC5F0 Offset: 0x2EAC6F1 VA: 0x2EAC5F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x2EAD2C0 Offset: 0x2EAD3C1 VA: 0x2EAD2C0
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x2EADF10 Offset: 0x2EAE011 VA: 0x2EADF10
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x2EAEB60 Offset: 0x2EAEC61 VA: 0x2EAEB60
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x2EAF7B0 Offset: 0x2EAF8B1 VA: 0x2EAF7B0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x2EB05C0 Offset: 0x2EB06C1 VA: 0x2EB05C0
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x2EB1290 Offset: 0x2EB1391 VA: 0x2EB1290
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x2EB1EE0 Offset: 0x2EB1FE1 VA: 0x2EB1EE0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x2EB3620 Offset: 0x2EB3721 VA: 0x2EB3620
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x2EB4190 Offset: 0x2EB4291 VA: 0x2EB4190
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x2EB4CD0 Offset: 0x2EB4DD1 VA: 0x2EB4CD0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x2EB5840 Offset: 0x2EB5941 VA: 0x2EB5840
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x2EB6650 Offset: 0x2EB6751 VA: 0x2EB6650
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2EB72A0 Offset: 0x2EB73A1 VA: 0x2EB72A0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x2EB8950 Offset: 0x2EB8A51 VA: 0x2EB8950
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x2EBA0B0 Offset: 0x2EBA1B1 VA: 0x2EBA0B0
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-EqualityComparer<WarpPoints.WarpPoint>.get_Default
	|
	|-RVA: 0x2EBBB70 Offset: 0x2EBBC71 VA: 0x2EBBB70
	|-EqualityComparer<YieldItemParam>.get_Default
	|
	|-RVA: 0x2EBC6B0 Offset: 0x2EBC7B1 VA: 0x2EBC6B0
	|-EqualityComparer<stCommand_t>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E2D0 Offset: 0x2E3E3D1 VA: 0x2E3E2D0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.CreateComparer
	|
	|-RVA: 0x2E3EF20 Offset: 0x2E3F021 VA: 0x2E3EF20
	|-EqualityComparer<JSONDeserialization.TaskField>.CreateComparer
	|
	|-RVA: 0x2E3FA90 Offset: 0x2E3FB91 VA: 0x2E3FA90
	|-EqualityComparer<BitVector32Int>.CreateComparer
	|
	|-RVA: 0x2E405D0 Offset: 0x2E406D1 VA: 0x2E405D0
	|-EqualityComparer<BuildItemData>.CreateComparer
	|
	|-RVA: 0x2E414C0 Offset: 0x2E415C1 VA: 0x2E414C0
	|-EqualityComparer<ButtonLinker.LinkObject>.CreateComparer
	|
	|-RVA: 0x2E42030 Offset: 0x2E42131 VA: 0x2E42030
	|-EqualityComparer<CharaCallTable.BustupTable>.CreateComparer
	|
	|-RVA: 0x2E42BA0 Offset: 0x2E42CA1 VA: 0x2E42BA0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.CreateComparer
	|
	|-RVA: 0x2E43730 Offset: 0x2E43831 VA: 0x2E43730
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x2E465E0 Offset: 0x2E466E1 VA: 0x2E465E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x2E472D0 Offset: 0x2E473D1 VA: 0x2E472D0
	|-EqualityComparer<CropDataTable>.CreateComparer
	|
	|-RVA: 0x2E47F30 Offset: 0x2E48031 VA: 0x2E47F30
	|-EqualityComparer<DropItemParam>.CreateComparer
	|
	|-RVA: 0x2E48A70 Offset: 0x2E48B71 VA: 0x2E48A70
	|-EqualityComparer<EffectDataTable>.CreateComparer
	|
	|-RVA: 0x2E496C0 Offset: 0x2E497C1 VA: 0x2E496C0
	|-EqualityComparer<ErosionBrush.UndoStep>.CreateComparer
	|
	|-RVA: 0x2E4A310 Offset: 0x2E4A411 VA: 0x2E4A310
	|-EqualityComparer<EventCheckId>.CreateComparer
	|
	|-RVA: 0x2E4AF60 Offset: 0x2E4B061 VA: 0x2E4AF60
	|-EqualityComparer<EventFlagProgressData>.CreateComparer
	|
	|-RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.CreateComparer
	|
	|-RVA: 0x2E4C830 Offset: 0x2E4C931 VA: 0x2E4C830
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.CreateComparer
	|
	|-RVA: 0x2E4D480 Offset: 0x2E4D581 VA: 0x2E4D480
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.CreateComparer
	|
	|-RVA: 0x2E4E010 Offset: 0x2E4E111 VA: 0x2E4E010
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.CreateComparer
	|
	|-RVA: 0x2E4EB80 Offset: 0x2E4EC81 VA: 0x2E4EB80
	|-EqualityComparer<FesNpcScoreData>.CreateComparer
	|
	|-RVA: 0x2E4F6F0 Offset: 0x2E4F7F1 VA: 0x2E4F6F0
	|-EqualityComparer<GimmickLayoutDataTable>.CreateComparer
	|
	|-RVA: 0x2E50230 Offset: 0x2E50331 VA: 0x2E50230
	|-EqualityComparer<MineTypeDataTable>.CreateComparer
	|
	|-RVA: 0x2E50F60 Offset: 0x2E51061 VA: 0x2E50F60
	|-EqualityComparer<MiningDataTable>.CreateComparer
	|
	|-RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0
	|-EqualityComparer<MiningPointSaveData>.CreateComparer
	|
	|-RVA: 0x2E527C0 Offset: 0x2E528C1 VA: 0x2E527C0
	|-EqualityComparer<MonsterDataTable>.CreateComparer
	|
	|-RVA: 0x2E53440 Offset: 0x2E53541 VA: 0x2E53440
	|-EqualityComparer<MonsterFootStepEventDataTable>.CreateComparer
	|
	|-RVA: 0x2E54100 Offset: 0x2E54201 VA: 0x2E54100
	|-EqualityComparer<MonsterHutSaveData>.CreateComparer
	|
	|-RVA: 0x2E54DD0 Offset: 0x2E54ED1 VA: 0x2E54DD0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.CreateComparer
	|
	|-RVA: 0x2E55940 Offset: 0x2E55A41 VA: 0x2E55940
	|-EqualityComparer<NPCActionData>.CreateComparer
	|
	|-RVA: 0x2E56670 Offset: 0x2E56771 VA: 0x2E56670
	|-EqualityComparer<NpcPlaceSchedule>.CreateComparer
	|
	|-RVA: 0x2E572C0 Offset: 0x2E573C1 VA: 0x2E572C0
	|-EqualityComparer<OrderLotterySaveParameter>.CreateComparer
	|
	|-RVA: 0x31FE380 Offset: 0x31FE481 VA: 0x31FE380
	|-EqualityComparer<OrderSaveData>.CreateComparer
	|
	|-RVA: 0x31FF050 Offset: 0x31FF151 VA: 0x31FF050
	|-EqualityComparer<OrderSaveParameter>.CreateComparer
	|
	|-RVA: 0x31FFCA0 Offset: 0x31FFDA1 VA: 0x31FFCA0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3200810 Offset: 0x3200911 VA: 0x3200810
	|-EqualityComparer<Parameter>.CreateComparer
	|
	|-RVA: 0x3201490 Offset: 0x3201591 VA: 0x3201490
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.CreateComparer
	|
	|-RVA: 0x3202000 Offset: 0x3202101 VA: 0x3202000
	|-EqualityComparer<ShopCatalogPage>.CreateComparer
	|
	|-RVA: 0x3202B70 Offset: 0x3202C71 VA: 0x3202B70
	|-EqualityComparer<ShopNpcTalk>.CreateComparer
	|
	|-RVA: 0x3203830 Offset: 0x3203931 VA: 0x3203830
	|-EqualityComparer<SubtitleDataTable.Data>.CreateComparer
	|
	|-RVA: 0x32043C0 Offset: 0x32044C1 VA: 0x32043C0
	|-EqualityComparer<SubtitleDataTable.DataList>.CreateComparer
	|
	|-RVA: 0x3204F00 Offset: 0x3205001 VA: 0x3204F00
	|-EqualityComparer<SubtitleHudDataTable.Data>.CreateComparer
	|
	|-RVA: 0x3205A90 Offset: 0x3205B91 VA: 0x3205A90
	|-EqualityComparer<ProfilerFrame>.CreateComparer
	|
	|-RVA: 0x3206660 Offset: 0x3206761 VA: 0x3206660
	|-EqualityComparer<NumberControl.ValueRange>.CreateComparer
	|
	|-RVA: 0x32071D0 Offset: 0x32072D1 VA: 0x32071D0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.CreateComparer
	|
	|-RVA: 0x3207E20 Offset: 0x3207F21 VA: 0x3207E20
	|-EqualityComparer<Schedule>.CreateComparer
	|
	|-RVA: 0x3208A70 Offset: 0x3208B71 VA: 0x3208A70
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x32095E0 Offset: 0x32096E1 VA: 0x32095E0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.CreateComparer
	|
	|-RVA: 0x320A170 Offset: 0x320A271 VA: 0x320A170
	|-EqualityComparer<CurveSample>.CreateComparer
	|
	|-RVA: 0x320AF10 Offset: 0x320B011 VA: 0x320AF10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x320BA60 Offset: 0x320BB61 VA: 0x320BA60
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x320C5A0 Offset: 0x320C6A1 VA: 0x320C5A0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x320D0E0 Offset: 0x320D1E1 VA: 0x320D0E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x320DC50 Offset: 0x320DD51 VA: 0x320DC50
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x320E790 Offset: 0x320E891 VA: 0x320E790
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x320F300 Offset: 0x320F401 VA: 0x320F300
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x320FE40 Offset: 0x320FF41 VA: 0x320FE40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x32109B0 Offset: 0x3210AB1 VA: 0x32109B0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x32114F0 Offset: 0x32115F1 VA: 0x32114F0
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3212060 Offset: 0x3212161 VA: 0x3212060
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3212BB0 Offset: 0x3212CB1 VA: 0x3212BB0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3213720 Offset: 0x3213821 VA: 0x3213720
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3214260 Offset: 0x3214361 VA: 0x3214260
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3214DA0 Offset: 0x3214EA1 VA: 0x3214DA0
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x32158E0 Offset: 0x32159E1 VA: 0x32158E0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3216420 Offset: 0x3216521 VA: 0x3216420
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3216F90 Offset: 0x3217091 VA: 0x3216F90
	|-EqualityComparer<Memory<object>>.CreateComparer
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.CreateComparer
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-EqualityComparer<Nullable<Int32Enum>>.CreateComparer
	|
	|-RVA: 0x3219340 Offset: 0x3219441 VA: 0x3219340
	|-EqualityComparer<Nullable<Bounds>>.CreateComparer
	|
	|-RVA: 0x321A030 Offset: 0x321A131 VA: 0x321A030
	|-EqualityComparer<Nullable<BoundsInt>>.CreateComparer
	|
	|-RVA: 0x321AD20 Offset: 0x321AE21 VA: 0x321AD20
	|-EqualityComparer<Nullable<Color32>>.CreateComparer
	|
	|-RVA: 0x32C9530 Offset: 0x32C9631 VA: 0x32C9530
	|-EqualityComparer<Nullable<Color>>.CreateComparer
	|
	|-RVA: 0x32CA1B0 Offset: 0x32CA2B1 VA: 0x32CA1B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.CreateComparer
	|
	|-RVA: 0x32CAD50 Offset: 0x32CAE51 VA: 0x32CAD50
	|-EqualityComparer<Nullable<GradientColorKey>>.CreateComparer
	|
	|-RVA: 0x32CB9D0 Offset: 0x32CBAD1 VA: 0x32CB9D0
	|-EqualityComparer<Nullable<Keyframe>>.CreateComparer
	|
	|-RVA: 0x32CC650 Offset: 0x32CC751 VA: 0x32CC650
	|-EqualityComparer<Nullable<LayerMask>>.CreateComparer
	|
	|-RVA: 0x32CD1A0 Offset: 0x32CD2A1 VA: 0x32CD1A0
	|-EqualityComparer<Nullable<Matrix4x4>>.CreateComparer
	|
	|-RVA: 0x32CDFA0 Offset: 0x32CE0A1 VA: 0x32CDFA0
	|-EqualityComparer<Nullable<Quaternion>>.CreateComparer
	|
	|-RVA: 0x32CEC20 Offset: 0x32CED21 VA: 0x32CEC20
	|-EqualityComparer<Nullable<RangeInt>>.CreateComparer
	|
	|-RVA: 0x32CF7C0 Offset: 0x32CF8C1 VA: 0x32CF7C0
	|-EqualityComparer<Nullable<Rect>>.CreateComparer
	|
	|-RVA: 0x32D0440 Offset: 0x32D0541 VA: 0x32D0440
	|-EqualityComparer<Nullable<RectInt>>.CreateComparer
	|
	|-RVA: 0x32D10C0 Offset: 0x32D11C1 VA: 0x32D10C0
	|-EqualityComparer<Nullable<Vector2>>.CreateComparer
	|
	|-RVA: 0x32D1C60 Offset: 0x32D1D61 VA: 0x32D1C60
	|-EqualityComparer<Nullable<Vector2Int>>.CreateComparer
	|
	|-RVA: 0x32D2800 Offset: 0x32D2901 VA: 0x32D2800
	|-EqualityComparer<Nullable<Vector3>>.CreateComparer
	|
	|-RVA: 0x32D3370 Offset: 0x32D3471 VA: 0x32D3370
	|-EqualityComparer<Nullable<Vector3Int>>.CreateComparer
	|
	|-RVA: 0x32D3EE0 Offset: 0x32D3FE1 VA: 0x32D3EE0
	|-EqualityComparer<Nullable<Vector4>>.CreateComparer
	|
	|-RVA: 0x32D4B60 Offset: 0x32D4C61 VA: 0x32D4B60
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x32D5680 Offset: 0x32D5781 VA: 0x32D5680
	|-EqualityComparer<ReadOnlyMemory<object>>.CreateComparer
	|
	|-RVA: 0x32D61F0 Offset: 0x32D62F1 VA: 0x32D61F0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x32D6D30 Offset: 0x32D6E31 VA: 0x32D6D30
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x32D78A0 Offset: 0x32D79A1 VA: 0x32D78A0
	|-EqualityComparer<RuntimeTypeHandle>.CreateComparer
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x32D8F20 Offset: 0x32D9021 VA: 0x32D8F20
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x32D9A70 Offset: 0x32D9B71 VA: 0x32D9A70
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x32DB0F0 Offset: 0x32DB1F1 VA: 0x32DB0F0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x32DBC30 Offset: 0x32DBD31 VA: 0x32DBC30
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DC770 Offset: 0x32DC871 VA: 0x32DC770
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x32DD2B0 Offset: 0x32DD3B1 VA: 0x32DD2B0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x32DDE20 Offset: 0x32DDF21 VA: 0x32DDE20
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DE990 Offset: 0x32DEA91 VA: 0x32DE990
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x32E0070 Offset: 0x32E0171 VA: 0x32E0070
	|-EqualityComparer<ValueTuple<float, float>>.CreateComparer
	|
	|-RVA: 0x32E0BE0 Offset: 0x32E0CE1 VA: 0x32E0BE0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CreateComparer
	|
	|-RVA: 0x32E24A0 Offset: 0x32E25A1 VA: 0x32E24A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x32E31D0 Offset: 0x32E32D1 VA: 0x32E31D0
	|-EqualityComparer<TransitionTables>.CreateComparer
	|
	|-RVA: 0x32E3E20 Offset: 0x32E3F21 VA: 0x32E3E20
	|-EqualityComparer<TutorialUnlockFlagData>.CreateComparer
	|
	|-RVA: 0x32E49B0 Offset: 0x32E4AB1 VA: 0x32E49B0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.CreateComparer
	|
	|-RVA: 0x32E5520 Offset: 0x32E5621 VA: 0x32E5520
	|-EqualityComparer<CapEdge>.CreateComparer
	|
	|-RVA: 0x30F15C0 Offset: 0x30F16C1 VA: 0x30F15C0
	|-EqualityComparer<ClippedEdge>.CreateComparer
	|
	|-RVA: 0x30F2210 Offset: 0x30F2311 VA: 0x30F2210
	|-EqualityComparer<EdgeKeyByHash>.CreateComparer
	|
	|-RVA: 0x30F2D50 Offset: 0x30F2E51 VA: 0x30F2D50
	|-EqualityComparer<EdgeKeyByIndex>.CreateComparer
	|
	|-RVA: 0x30F3890 Offset: 0x30F3991 VA: 0x30F3890
	|-EqualityComparer<MeshDataConnectivity.Face>.CreateComparer
	|
	|-RVA: 0x30F43D0 Offset: 0x30F44D1 VA: 0x30F43D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.CreateComparer
	|
	|-RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.CreateComparer
	|
	|-RVA: 0x30F5CE0 Offset: 0x30F5DE1 VA: 0x30F5CE0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x30F76D0 Offset: 0x30F77D1 VA: 0x30F76D0
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x30F8240 Offset: 0x30F8341 VA: 0x30F8240
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x30F8D80 Offset: 0x30F8E81 VA: 0x30F8D80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x30FA540 Offset: 0x30FA641 VA: 0x30FA540
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x30FB190 Offset: 0x30FB291 VA: 0x30FB190
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x30FBDE0 Offset: 0x30FBEE1 VA: 0x30FBDE0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x30FC920 Offset: 0x30FCA21 VA: 0x30FC920
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x30FD4F0 Offset: 0x30FD5F1 VA: 0x30FD4F0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x30FE370 Offset: 0x30FE471 VA: 0x30FE370
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	|
	|-RVA: 0x30FFC50 Offset: 0x30FFD51 VA: 0x30FFC50
	|-EqualityComparer<GradientAlphaKey>.CreateComparer
	|
	|-RVA: 0x31007C0 Offset: 0x31008C1 VA: 0x31007C0
	|-EqualityComparer<GradientColorKey>.CreateComparer
	|
	|-RVA: 0x3101410 Offset: 0x3101511 VA: 0x3101410
	|-EqualityComparer<Keyframe>.CreateComparer
	|
	|-RVA: 0x31020D0 Offset: 0x31021D1 VA: 0x31020D0
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3102C10 Offset: 0x3102D11 VA: 0x3102C10
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3103940 Offset: 0x3103A41 VA: 0x3103940
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x31045C0 Offset: 0x31046C1 VA: 0x31045C0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3105130 Offset: 0x3105231 VA: 0x3105130
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3105D80 Offset: 0x3105E81 VA: 0x3105D80
	|-EqualityComparer<PlayableGraph>.CreateComparer
	|
	|-RVA: 0x31068F0 Offset: 0x31069F1 VA: 0x31068F0
	|-EqualityComparer<Edge>.CreateComparer
	|
	|-RVA: 0x3107430 Offset: 0x3107531 VA: 0x3107430
	|-EqualityComparer<IntVec3>.CreateComparer
	|
	|-RVA: 0x3108000 Offset: 0x3108101 VA: 0x3108000
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3108BD0 Offset: 0x3108CD1 VA: 0x3108BD0
	|-EqualityComparer<RangeInt>.CreateComparer
	|
	|-RVA: 0x3109710 Offset: 0x3109811 VA: 0x3109710
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x310A400 Offset: 0x310A501 VA: 0x310A400
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x310B130 Offset: 0x310B231 VA: 0x310B130
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x310BD00 Offset: 0x310BE01 VA: 0x310BD00
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x310C870 Offset: 0x310C971 VA: 0x310C870
	|-EqualityComparer<ReflectionProbeBlendInfo>.CreateComparer
	|
	|-RVA: 0x310D3E0 Offset: 0x310D4E1 VA: 0x310D3E0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x310E2E0 Offset: 0x310E3E1 VA: 0x310E2E0
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x310EE50 Offset: 0x310EF51 VA: 0x310EE50
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x2EA71B0 Offset: 0x2EA72B1 VA: 0x2EA71B0
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x2EA7E00 Offset: 0x2EA7F01 VA: 0x2EA7E00
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.CreateComparer
	|
	|-RVA: 0x2EA8A50 Offset: 0x2EA8B51 VA: 0x2EA8A50
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x2EA9710 Offset: 0x2EA9811 VA: 0x2EA9710
	|-EqualityComparer<SceneInstance>.CreateComparer
	|
	|-RVA: 0x2EAA280 Offset: 0x2EAA381 VA: 0x2EAA280
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x2EAAED0 Offset: 0x2EAAFD1 VA: 0x2EAAED0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x2EABB90 Offset: 0x2EABC91 VA: 0x2EABB90
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x2EAC700 Offset: 0x2EAC801 VA: 0x2EAC700
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x2EAD3D0 Offset: 0x2EAD4D1 VA: 0x2EAD3D0
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x2EAE020 Offset: 0x2EAE121 VA: 0x2EAE020
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x2EAEC70 Offset: 0x2EAED71 VA: 0x2EAEC70
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x2EAF8C0 Offset: 0x2EAF9C1 VA: 0x2EAF8C0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x2EB06D0 Offset: 0x2EB07D1 VA: 0x2EB06D0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x2EB13A0 Offset: 0x2EB14A1 VA: 0x2EB13A0
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x2EB2BC0 Offset: 0x2EB2CC1 VA: 0x2EB2BC0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x2EB3730 Offset: 0x2EB3831 VA: 0x2EB3730
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x2EB42A0 Offset: 0x2EB43A1 VA: 0x2EB42A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x2EB4DE0 Offset: 0x2EB4EE1 VA: 0x2EB4DE0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x2EB5950 Offset: 0x2EB5A51 VA: 0x2EB5950
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x2EB6760 Offset: 0x2EB6861 VA: 0x2EB6760
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2EB73B0 Offset: 0x2EB74B1 VA: 0x2EB73B0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2EB7F20 Offset: 0x2EB8021 VA: 0x2EB7F20
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x2EB8A60 Offset: 0x2EB8B61 VA: 0x2EB8A60
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2EB9630 Offset: 0x2EB9731 VA: 0x2EB9630
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x2EBA1C0 Offset: 0x2EBA2C1 VA: 0x2EBA1C0
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x2EBAD90 Offset: 0x2EBAE91 VA: 0x2EBAD90
	|-EqualityComparer<WarpPoints.WarpPoint>.CreateComparer
	|
	|-RVA: 0x2EBBC80 Offset: 0x2EBBD81 VA: 0x2EBBC80
	|-EqualityComparer<YieldItemParam>.CreateComparer
	|
	|-RVA: 0x2EBC7C0 Offset: 0x2EBC8C1 VA: 0x2EBC7C0
	|-EqualityComparer<stCommand_t>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E910 Offset: 0x2E3EA11 VA: 0x2E3E910
	|-EqualityComparer<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2E3F560 Offset: 0x2E3F661 VA: 0x2E3F560
	|-EqualityComparer<JSONDeserialization.TaskField>.IndexOf
	|
	|-RVA: 0x2E400D0 Offset: 0x2E401D1 VA: 0x2E400D0
	|-EqualityComparer<BitVector32Int>.IndexOf
	|
	|-RVA: 0x2E40C10 Offset: 0x2E40D11 VA: 0x2E40C10
	|-EqualityComparer<BuildItemData>.IndexOf
	|
	|-RVA: 0x2E41B00 Offset: 0x2E41C01 VA: 0x2E41B00
	|-EqualityComparer<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2E42670 Offset: 0x2E42771 VA: 0x2E42670
	|-EqualityComparer<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2E431E0 Offset: 0x2E432E1 VA: 0x2E431E0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2E43D70 Offset: 0x2E43E71 VA: 0x2E43D70
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2E448E0 Offset: 0x2E449E1 VA: 0x2E448E0
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2E45420 Offset: 0x2E45521 VA: 0x2E45420
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2E45F60 Offset: 0x2E46061 VA: 0x2E45F60
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2E46C20 Offset: 0x2E46D21 VA: 0x2E46C20
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2E47910 Offset: 0x2E47A11 VA: 0x2E47910
	|-EqualityComparer<CropDataTable>.IndexOf
	|
	|-RVA: 0x2E48570 Offset: 0x2E48671 VA: 0x2E48570
	|-EqualityComparer<DropItemParam>.IndexOf
	|
	|-RVA: 0x2E490B0 Offset: 0x2E491B1 VA: 0x2E490B0
	|-EqualityComparer<EffectDataTable>.IndexOf
	|
	|-RVA: 0x2E49D00 Offset: 0x2E49E01 VA: 0x2E49D00
	|-EqualityComparer<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2E4A950 Offset: 0x2E4AA51 VA: 0x2E4A950
	|-EqualityComparer<EventCheckId>.IndexOf
	|
	|-RVA: 0x2E4B5A0 Offset: 0x2E4B6A1 VA: 0x2E4B5A0
	|-EqualityComparer<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2E4C110 Offset: 0x2E4C211 VA: 0x2E4C110
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.IndexOf
	|
	|-RVA: 0x2E4CE70 Offset: 0x2E4CF71 VA: 0x2E4CE70
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.IndexOf
	|
	|-RVA: 0x2E4DAC0 Offset: 0x2E4DBC1 VA: 0x2E4DAC0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.IndexOf
	|
	|-RVA: 0x2E4E650 Offset: 0x2E4E751 VA: 0x2E4E650
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.IndexOf
	|
	|-RVA: 0x2E4F1C0 Offset: 0x2E4F2C1 VA: 0x2E4F1C0
	|-EqualityComparer<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2E4FD30 Offset: 0x2E4FE31 VA: 0x2E4FD30
	|-EqualityComparer<GimmickLayoutDataTable>.IndexOf
	|
	|-RVA: 0x2E50870 Offset: 0x2E50971 VA: 0x2E50870
	|-EqualityComparer<MineTypeDataTable>.IndexOf
	|
	|-RVA: 0x2E515A0 Offset: 0x2E516A1 VA: 0x2E515A0
	|-EqualityComparer<MiningDataTable>.IndexOf
	|
	|-RVA: 0x2E52110 Offset: 0x2E52211 VA: 0x2E52110
	|-EqualityComparer<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2E52E00 Offset: 0x2E52F01 VA: 0x2E52E00
	|-EqualityComparer<MonsterDataTable>.IndexOf
	|
	|-RVA: 0x2E53A80 Offset: 0x2E53B81 VA: 0x2E53A80
	|-EqualityComparer<MonsterFootStepEventDataTable>.IndexOf
	|
	|-RVA: 0x2E54740 Offset: 0x2E54841 VA: 0x2E54740
	|-EqualityComparer<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2E55410 Offset: 0x2E55511 VA: 0x2E55410
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x2E55F80 Offset: 0x2E56081 VA: 0x2E55F80
	|-EqualityComparer<NPCActionData>.IndexOf
	|
	|-RVA: 0x2E56CB0 Offset: 0x2E56DB1 VA: 0x2E56CB0
	|-EqualityComparer<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	|-EqualityComparer<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31FE9C0 Offset: 0x31FEAC1 VA: 0x31FE9C0
	|-EqualityComparer<OrderSaveData>.IndexOf
	|
	|-RVA: 0x31FF690 Offset: 0x31FF791 VA: 0x31FF690
	|-EqualityComparer<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32002E0 Offset: 0x32003E1 VA: 0x32002E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3200E50 Offset: 0x3200F51 VA: 0x3200E50
	|-EqualityComparer<Parameter>.IndexOf
	|
	|-RVA: 0x3201AD0 Offset: 0x3201BD1 VA: 0x3201AD0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.IndexOf
	|
	|-RVA: 0x3202640 Offset: 0x3202741 VA: 0x3202640
	|-EqualityComparer<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32031B0 Offset: 0x32032B1 VA: 0x32031B0
	|-EqualityComparer<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x3203E70 Offset: 0x3203F71 VA: 0x3203E70
	|-EqualityComparer<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3204A00 Offset: 0x3204B01 VA: 0x3204A00
	|-EqualityComparer<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3205540 Offset: 0x3205641 VA: 0x3205540
	|-EqualityComparer<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32060D0 Offset: 0x32061D1 VA: 0x32060D0
	|-EqualityComparer<ProfilerFrame>.IndexOf
	|
	|-RVA: 0x3206CA0 Offset: 0x3206DA1 VA: 0x3206CA0
	|-EqualityComparer<NumberControl.ValueRange>.IndexOf
	|
	|-RVA: 0x3207810 Offset: 0x3207911 VA: 0x3207810
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x3208460 Offset: 0x3208561 VA: 0x3208460
	|-EqualityComparer<Schedule>.IndexOf
	|
	|-RVA: 0x32090B0 Offset: 0x32091B1 VA: 0x32090B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3209C20 Offset: 0x3209D21 VA: 0x3209C20
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x320A7B0 Offset: 0x320A8B1 VA: 0x320A7B0
	|-EqualityComparer<CurveSample>.IndexOf
	|
	|-RVA: 0x320B550 Offset: 0x320B651 VA: 0x320B550
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x320C0A0 Offset: 0x320C1A1 VA: 0x320C0A0
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x320D720 Offset: 0x320D821 VA: 0x320D720
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x320E290 Offset: 0x320E391 VA: 0x320E290
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x320EDD0 Offset: 0x320EED1 VA: 0x320EDD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x320F940 Offset: 0x320FA41 VA: 0x320F940
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3210480 Offset: 0x3210581 VA: 0x3210480
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3210FF0 Offset: 0x32110F1 VA: 0x3210FF0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3211B30 Offset: 0x3211C31 VA: 0x3211B30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x32126A0 Offset: 0x32127A1 VA: 0x32126A0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x32131F0 Offset: 0x32132F1 VA: 0x32131F0
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3213D60 Offset: 0x3213E61 VA: 0x3213D60
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x32148A0 Offset: 0x32149A1 VA: 0x32148A0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x32153E0 Offset: 0x32154E1 VA: 0x32153E0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3216A60 Offset: 0x3216B61 VA: 0x3216A60
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x32175D0 Offset: 0x32176D1 VA: 0x32175D0
	|-EqualityComparer<Memory<object>>.IndexOf
	|
	|-RVA: 0x3218140 Offset: 0x3218241 VA: 0x3218140
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.IndexOf
	|
	|-RVA: 0x3218E30 Offset: 0x3218F31 VA: 0x3218E30
	|-EqualityComparer<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3219980 Offset: 0x3219A81 VA: 0x3219980
	|-EqualityComparer<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x321A670 Offset: 0x321A771 VA: 0x321A670
	|-EqualityComparer<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x321B360 Offset: 0x321B461 VA: 0x321B360
	|-EqualityComparer<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x32C9B70 Offset: 0x32C9C71 VA: 0x32C9B70
	|-EqualityComparer<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x32CA7F0 Offset: 0x32CA8F1 VA: 0x32CA7F0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-EqualityComparer<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x32CC010 Offset: 0x32CC111 VA: 0x32CC010
	|-EqualityComparer<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x32CCC90 Offset: 0x32CCD91 VA: 0x32CCC90
	|-EqualityComparer<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x32CD7E0 Offset: 0x32CD8E1 VA: 0x32CD7E0
	|-EqualityComparer<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32CE5E0 Offset: 0x32CE6E1 VA: 0x32CE5E0
	|-EqualityComparer<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32CF260 Offset: 0x32CF361 VA: 0x32CF260
	|-EqualityComparer<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32CFE00 Offset: 0x32CFF01 VA: 0x32CFE00
	|-EqualityComparer<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x32D0A80 Offset: 0x32D0B81 VA: 0x32D0A80
	|-EqualityComparer<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x32D1700 Offset: 0x32D1801 VA: 0x32D1700
	|-EqualityComparer<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32D22A0 Offset: 0x32D23A1 VA: 0x32D22A0
	|-EqualityComparer<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32D2E40 Offset: 0x32D2F41 VA: 0x32D2E40
	|-EqualityComparer<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x32D39B0 Offset: 0x32D3AB1 VA: 0x32D39B0
	|-EqualityComparer<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-EqualityComparer<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x32D51A0 Offset: 0x32D52A1 VA: 0x32D51A0
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-EqualityComparer<ReadOnlyMemory<object>>.IndexOf
	|
	|-RVA: 0x32D6830 Offset: 0x32D6931 VA: 0x32D6830
	|-EqualityComparer<Label>.IndexOf
	|
	|-RVA: 0x32D7370 Offset: 0x32D7471 VA: 0x32D7370
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x32D7EE0 Offset: 0x32D7FE1 VA: 0x32D7EE0
	|-EqualityComparer<RuntimeTypeHandle>.IndexOf
	|
	|-RVA: 0x32D8A20 Offset: 0x32D8B21 VA: 0x32D8A20
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x32D9560 Offset: 0x32D9661 VA: 0x32D9560
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x32DA0B0 Offset: 0x32DA1B1 VA: 0x32DA0B0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x32DABF0 Offset: 0x32DACF1 VA: 0x32DABF0
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x32DB730 Offset: 0x32DB831 VA: 0x32DB730
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x32DC270 Offset: 0x32DC371 VA: 0x32DC270
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DCDB0 Offset: 0x32DCEB1 VA: 0x32DCDB0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32DE460 Offset: 0x32DE561 VA: 0x32DE460
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DEFD0 Offset: 0x32DF0D1 VA: 0x32DEFD0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32DFB40 Offset: 0x32DFC41 VA: 0x32DFB40
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32E06B0 Offset: 0x32E07B1 VA: 0x32E06B0
	|-EqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x32E1220 Offset: 0x32E1321 VA: 0x32E1220
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32E1DB0 Offset: 0x32E1EB1 VA: 0x32E1DB0
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32E3810 Offset: 0x32E3911 VA: 0x32E3810
	|-EqualityComparer<TransitionTables>.IndexOf
	|
	|-RVA: 0x32E4460 Offset: 0x32E4561 VA: 0x32E4460
	|-EqualityComparer<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32E4FF0 Offset: 0x32E50F1 VA: 0x32E4FF0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32E5B60 Offset: 0x32E5C61 VA: 0x32E5B60
	|-EqualityComparer<CapEdge>.IndexOf
	|
	|-RVA: 0x30F1C00 Offset: 0x30F1D01 VA: 0x30F1C00
	|-EqualityComparer<ClippedEdge>.IndexOf
	|
	|-RVA: 0x30F2850 Offset: 0x30F2951 VA: 0x30F2850
	|-EqualityComparer<EdgeKeyByHash>.IndexOf
	|
	|-RVA: 0x30F3390 Offset: 0x30F3491 VA: 0x30F3390
	|-EqualityComparer<EdgeKeyByIndex>.IndexOf
	|
	|-RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	|-EqualityComparer<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x30F4A10 Offset: 0x30F4B11 VA: 0x30F4A10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x30F5660 Offset: 0x30F5761 VA: 0x30F5660
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x30F6320 Offset: 0x30F6421 VA: 0x30F6320
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x30F6E90 Offset: 0x30F6F91 VA: 0x30F6E90
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x30F7D10 Offset: 0x30F7E11 VA: 0x30F7D10
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x30F8880 Offset: 0x30F8981 VA: 0x30F8880
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x30F93C0 Offset: 0x30F94C1 VA: 0x30F93C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x30F9F30 Offset: 0x30FA031 VA: 0x30F9F30
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x30FAB80 Offset: 0x30FAC81 VA: 0x30FAB80
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x30FB7D0 Offset: 0x30FB8D1 VA: 0x30FB7D0
	|-EqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x30FC420 Offset: 0x30FC521 VA: 0x30FC420
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x30FCF60 Offset: 0x30FD061 VA: 0x30FCF60
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x30FDB30 Offset: 0x30FDC31 VA: 0x30FDB30
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x30FE9B0 Offset: 0x30FEAB1 VA: 0x30FE9B0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x30FF750 Offset: 0x30FF851 VA: 0x30FF750
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	|
	|-RVA: 0x3100290 Offset: 0x3100391 VA: 0x3100290
	|-EqualityComparer<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x3100E00 Offset: 0x3100F01 VA: 0x3100E00
	|-EqualityComparer<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3101A50 Offset: 0x3101B51 VA: 0x3101A50
	|-EqualityComparer<Keyframe>.IndexOf
	|
	|-RVA: 0x3102710 Offset: 0x3102811 VA: 0x3102710
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3103250 Offset: 0x3103351 VA: 0x3103250
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3103F80 Offset: 0x3104081 VA: 0x3103F80
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3104C00 Offset: 0x3104D01 VA: 0x3104C00
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3105770 Offset: 0x3105871 VA: 0x3105770
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	|-EqualityComparer<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3106F30 Offset: 0x3107031 VA: 0x3106F30
	|-EqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x3107A70 Offset: 0x3107B71 VA: 0x3107A70
	|-EqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x3108640 Offset: 0x3108741 VA: 0x3108640
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3109210 Offset: 0x3109311 VA: 0x3109210
	|-EqualityComparer<RangeInt>.IndexOf
	|
	|-RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x310AA40 Offset: 0x310AB41 VA: 0x310AA40
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x310B770 Offset: 0x310B871 VA: 0x310B770
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x310C340 Offset: 0x310C441 VA: 0x310C340
	|-EqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x310CEB0 Offset: 0x310CFB1 VA: 0x310CEB0
	|-EqualityComparer<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x310DA20 Offset: 0x310DB21 VA: 0x310DA20
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x310E920 Offset: 0x310EA21 VA: 0x310E920
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x310F490 Offset: 0x310F591 VA: 0x310F490
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x2EA77F0 Offset: 0x2EA78F1 VA: 0x2EA77F0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EA8440 Offset: 0x2EA8541 VA: 0x2EA8440
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EA9090 Offset: 0x2EA9191 VA: 0x2EA9090
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2EA9D50 Offset: 0x2EA9E51 VA: 0x2EA9D50
	|-EqualityComparer<SceneInstance>.IndexOf
	|
	|-RVA: 0x2EAA8C0 Offset: 0x2EAA9C1 VA: 0x2EAA8C0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2EAB510 Offset: 0x2EAB611 VA: 0x2EAB510
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2EAC1D0 Offset: 0x2EAC2D1 VA: 0x2EAC1D0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EACD40 Offset: 0x2EACE41 VA: 0x2EACD40
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2EADA10 Offset: 0x2EADB11 VA: 0x2EADA10
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2EAE660 Offset: 0x2EAE761 VA: 0x2EAE660
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2EAF2B0 Offset: 0x2EAF3B1 VA: 0x2EAF2B0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2EAFF00 Offset: 0x2EB0001 VA: 0x2EAFF00
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EB0D10 Offset: 0x2EB0E11 VA: 0x2EB0D10
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EB2630 Offset: 0x2EB2731 VA: 0x2EB2630
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x2EB3200 Offset: 0x2EB3301 VA: 0x2EB3200
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|
	|-RVA: 0x2EB3D70 Offset: 0x2EB3E71 VA: 0x2EB3D70
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2EB48E0 Offset: 0x2EB49E1 VA: 0x2EB48E0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|
	|-RVA: 0x2EB5420 Offset: 0x2EB5521 VA: 0x2EB5420
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x2EB5F90 Offset: 0x2EB6091 VA: 0x2EB5F90
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x2EB6DA0 Offset: 0x2EB6EA1 VA: 0x2EB6DA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2EB79F0 Offset: 0x2EB7AF1 VA: 0x2EB79F0
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EB8560 Offset: 0x2EB8661 VA: 0x2EB8560
	|-EqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EB90A0 Offset: 0x2EB91A1 VA: 0x2EB90A0
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EB9C70 Offset: 0x2EB9D71 VA: 0x2EB9C70
	|-EqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EBA800 Offset: 0x2EBA901 VA: 0x2EBA800
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2EBB3D0 Offset: 0x2EBB4D1 VA: 0x2EBB3D0
	|-EqualityComparer<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2EBC2C0 Offset: 0x2EBC3C1 VA: 0x2EBC2C0
	|-EqualityComparer<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2EBCE00 Offset: 0x2EBCF01 VA: 0x2EBCE00
	|-EqualityComparer<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EA30 Offset: 0x2E3EB31 VA: 0x2E3EA30
	|-EqualityComparer<AS_ToolController.ChargeInfo>.LastIndexOf
	|
	|-RVA: 0x2E3F630 Offset: 0x2E3F731 VA: 0x2E3F630
	|-EqualityComparer<JSONDeserialization.TaskField>.LastIndexOf
	|
	|-RVA: 0x2E40190 Offset: 0x2E40291 VA: 0x2E40190
	|-EqualityComparer<BitVector32Int>.LastIndexOf
	|
	|-RVA: 0x2E40DF0 Offset: 0x2E40EF1 VA: 0x2E40DF0
	|-EqualityComparer<BuildItemData>.LastIndexOf
	|
	|-RVA: 0x2E41BD0 Offset: 0x2E41CD1 VA: 0x2E41BD0
	|-EqualityComparer<ButtonLinker.LinkObject>.LastIndexOf
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-EqualityComparer<CharaCallTable.BustupTable>.LastIndexOf
	|
	|-RVA: 0x2E432C0 Offset: 0x2E433C1 VA: 0x2E432C0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.LastIndexOf
	|
	|-RVA: 0x2E43E40 Offset: 0x2E43F41 VA: 0x2E43E40
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x2E449A0 Offset: 0x2E44AA1 VA: 0x2E449A0
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x2E454E0 Offset: 0x2E455E1 VA: 0x2E454E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x2E460A0 Offset: 0x2E461A1 VA: 0x2E460A0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x2E46D70 Offset: 0x2E46E71 VA: 0x2E46D70
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x2E47A30 Offset: 0x2E47B31 VA: 0x2E47A30
	|-EqualityComparer<CropDataTable>.LastIndexOf
	|
	|-RVA: 0x2E48630 Offset: 0x2E48731 VA: 0x2E48630
	|-EqualityComparer<DropItemParam>.LastIndexOf
	|
	|-RVA: 0x2E491D0 Offset: 0x2E492D1 VA: 0x2E491D0
	|-EqualityComparer<EffectDataTable>.LastIndexOf
	|
	|-RVA: 0x2E49E20 Offset: 0x2E49F21 VA: 0x2E49E20
	|-EqualityComparer<ErosionBrush.UndoStep>.LastIndexOf
	|
	|-RVA: 0x2E4AA70 Offset: 0x2E4AB71 VA: 0x2E4AA70
	|-EqualityComparer<EventCheckId>.LastIndexOf
	|
	|-RVA: 0x2E4B670 Offset: 0x2E4B771 VA: 0x2E4B670
	|-EqualityComparer<EventFlagProgressData>.LastIndexOf
	|
	|-RVA: 0x2E4C280 Offset: 0x2E4C381 VA: 0x2E4C280
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.LastIndexOf
	|
	|-RVA: 0x2E4CF90 Offset: 0x2E4D091 VA: 0x2E4CF90
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4DBA0 Offset: 0x2E4DCA1 VA: 0x2E4DBA0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4E720 Offset: 0x2E4E821 VA: 0x2E4E720
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4F290 Offset: 0x2E4F391 VA: 0x2E4F290
	|-EqualityComparer<FesNpcScoreData>.LastIndexOf
	|
	|-RVA: 0x2E4FDF0 Offset: 0x2E4FEF1 VA: 0x2E4FDF0
	|-EqualityComparer<GimmickLayoutDataTable>.LastIndexOf
	|
	|-RVA: 0x2E509D0 Offset: 0x2E50AD1 VA: 0x2E509D0
	|-EqualityComparer<MineTypeDataTable>.LastIndexOf
	|
	|-RVA: 0x2E51670 Offset: 0x2E51771 VA: 0x2E51670
	|-EqualityComparer<MiningDataTable>.LastIndexOf
	|
	|-RVA: 0x2E52260 Offset: 0x2E52361 VA: 0x2E52260
	|-EqualityComparer<MiningPointSaveData>.LastIndexOf
	|
	|-RVA: 0x2E52F20 Offset: 0x2E53021 VA: 0x2E52F20
	|-EqualityComparer<MonsterDataTable>.LastIndexOf
	|
	|-RVA: 0x2E53BC0 Offset: 0x2E53CC1 VA: 0x2E53BC0
	|-EqualityComparer<MonsterFootStepEventDataTable>.LastIndexOf
	|
	|-RVA: 0x2E54880 Offset: 0x2E54981 VA: 0x2E54880
	|-EqualityComparer<MonsterHutSaveData>.LastIndexOf
	|
	|-RVA: 0x2E554E0 Offset: 0x2E555E1 VA: 0x2E554E0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.LastIndexOf
	|
	|-RVA: 0x2E560E0 Offset: 0x2E561E1 VA: 0x2E560E0
	|-EqualityComparer<NPCActionData>.LastIndexOf
	|
	|-RVA: 0x2E56DD0 Offset: 0x2E56ED1 VA: 0x2E56DD0
	|-EqualityComparer<NpcPlaceSchedule>.LastIndexOf
	|
	|-RVA: 0x2E579E0 Offset: 0x2E57AE1 VA: 0x2E579E0
	|-EqualityComparer<OrderLotterySaveParameter>.LastIndexOf
	|
	|-RVA: 0x31FEB00 Offset: 0x31FEC01 VA: 0x31FEB00
	|-EqualityComparer<OrderSaveData>.LastIndexOf
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-EqualityComparer<OrderSaveParameter>.LastIndexOf
	|
	|-RVA: 0x32003B0 Offset: 0x32004B1 VA: 0x32003B0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3200F70 Offset: 0x3201071 VA: 0x3200F70
	|-EqualityComparer<Parameter>.LastIndexOf
	|
	|-RVA: 0x3201BA0 Offset: 0x3201CA1 VA: 0x3201BA0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.LastIndexOf
	|
	|-RVA: 0x3202710 Offset: 0x3202811 VA: 0x3202710
	|-EqualityComparer<ShopCatalogPage>.LastIndexOf
	|
	|-RVA: 0x32032F0 Offset: 0x32033F1 VA: 0x32032F0
	|-EqualityComparer<ShopNpcTalk>.LastIndexOf
	|
	|-RVA: 0x3203F50 Offset: 0x3204051 VA: 0x3203F50
	|-EqualityComparer<SubtitleDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x3204AC0 Offset: 0x3204BC1 VA: 0x3204AC0
	|-EqualityComparer<SubtitleDataTable.DataList>.LastIndexOf
	|
	|-RVA: 0x3205620 Offset: 0x3205721 VA: 0x3205620
	|-EqualityComparer<SubtitleHudDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x32061C0 Offset: 0x32062C1 VA: 0x32061C0
	|-EqualityComparer<ProfilerFrame>.LastIndexOf
	|
	|-RVA: 0x3206D70 Offset: 0x3206E71 VA: 0x3206D70
	|-EqualityComparer<NumberControl.ValueRange>.LastIndexOf
	|
	|-RVA: 0x3207930 Offset: 0x3207A31 VA: 0x3207930
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.LastIndexOf
	|
	|-RVA: 0x3208580 Offset: 0x3208681 VA: 0x3208580
	|-EqualityComparer<Schedule>.LastIndexOf
	|
	|-RVA: 0x3209180 Offset: 0x3209281 VA: 0x3209180
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3209D00 Offset: 0x3209E01 VA: 0x3209D00
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x320A930 Offset: 0x320AA31 VA: 0x320A930
	|-EqualityComparer<CurveSample>.LastIndexOf
	|
	|-RVA: 0x320B610 Offset: 0x320B711 VA: 0x320B610
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x320C160 Offset: 0x320C261 VA: 0x320C160
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x320CCA0 Offset: 0x320CDA1 VA: 0x320CCA0
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x320D7F0 Offset: 0x320D8F1 VA: 0x320D7F0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x320E350 Offset: 0x320E451 VA: 0x320E350
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x320FA00 Offset: 0x320FB01 VA: 0x320FA00
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3210550 Offset: 0x3210651 VA: 0x3210550
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x32110B0 Offset: 0x32111B1 VA: 0x32110B0
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3211C00 Offset: 0x3211D01 VA: 0x3211C00
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3212760 Offset: 0x3212861 VA: 0x3212760
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x32132C0 Offset: 0x32133C1 VA: 0x32132C0
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3213E20 Offset: 0x3213F21 VA: 0x3213E20
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3214960 Offset: 0x3214A61 VA: 0x3214960
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3215FE0 Offset: 0x32160E1 VA: 0x3215FE0
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3216B30 Offset: 0x3216C31 VA: 0x3216B30
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x32176A0 Offset: 0x32177A1 VA: 0x32176A0
	|-EqualityComparer<Memory<object>>.LastIndexOf
	|
	|-RVA: 0x3218280 Offset: 0x3218381 VA: 0x3218280
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.LastIndexOf
	|
	|-RVA: 0x3218EF0 Offset: 0x3218FF1 VA: 0x3218EF0
	|-EqualityComparer<Nullable<Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x3219AC0 Offset: 0x3219BC1 VA: 0x3219AC0
	|-EqualityComparer<Nullable<Bounds>>.LastIndexOf
	|
	|-RVA: 0x321A7B0 Offset: 0x321A8B1 VA: 0x321A7B0
	|-EqualityComparer<Nullable<BoundsInt>>.LastIndexOf
	|
	|-RVA: 0x321B420 Offset: 0x321B521 VA: 0x321B420
	|-EqualityComparer<Nullable<Color32>>.LastIndexOf
	|
	|-RVA: 0x32C9C90 Offset: 0x32C9D91 VA: 0x32C9C90
	|-EqualityComparer<Nullable<Color>>.LastIndexOf
	|
	|-RVA: 0x32CA8D0 Offset: 0x32CA9D1 VA: 0x32CA8D0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.LastIndexOf
	|
	|-RVA: 0x32CB4B0 Offset: 0x32CB5B1 VA: 0x32CB4B0
	|-EqualityComparer<Nullable<GradientColorKey>>.LastIndexOf
	|
	|-RVA: 0x32CC130 Offset: 0x32CC231 VA: 0x32CC130
	|-EqualityComparer<Nullable<Keyframe>>.LastIndexOf
	|
	|-RVA: 0x32CCD50 Offset: 0x32CCE51 VA: 0x32CCD50
	|-EqualityComparer<Nullable<LayerMask>>.LastIndexOf
	|
	|-RVA: 0x32CD970 Offset: 0x32CDA71 VA: 0x32CD970
	|-EqualityComparer<Nullable<Matrix4x4>>.LastIndexOf
	|
	|-RVA: 0x32CE700 Offset: 0x32CE801 VA: 0x32CE700
	|-EqualityComparer<Nullable<Quaternion>>.LastIndexOf
	|
	|-RVA: 0x32CF340 Offset: 0x32CF441 VA: 0x32CF340
	|-EqualityComparer<Nullable<RangeInt>>.LastIndexOf
	|
	|-RVA: 0x32CFF20 Offset: 0x32D0021 VA: 0x32CFF20
	|-EqualityComparer<Nullable<Rect>>.LastIndexOf
	|
	|-RVA: 0x32D0BA0 Offset: 0x32D0CA1 VA: 0x32D0BA0
	|-EqualityComparer<Nullable<RectInt>>.LastIndexOf
	|
	|-RVA: 0x32D17E0 Offset: 0x32D18E1 VA: 0x32D17E0
	|-EqualityComparer<Nullable<Vector2>>.LastIndexOf
	|
	|-RVA: 0x32D2380 Offset: 0x32D2481 VA: 0x32D2380
	|-EqualityComparer<Nullable<Vector2Int>>.LastIndexOf
	|
	|-RVA: 0x32D2F10 Offset: 0x32D3011 VA: 0x32D2F10
	|-EqualityComparer<Nullable<Vector3>>.LastIndexOf
	|
	|-RVA: 0x32D3A80 Offset: 0x32D3B81 VA: 0x32D3A80
	|-EqualityComparer<Nullable<Vector3Int>>.LastIndexOf
	|
	|-RVA: 0x32D4640 Offset: 0x32D4741 VA: 0x32D4640
	|-EqualityComparer<Nullable<Vector4>>.LastIndexOf
	|
	|-RVA: 0x32D5260 Offset: 0x32D5361 VA: 0x32D5260
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x32D5D90 Offset: 0x32D5E91 VA: 0x32D5D90
	|-EqualityComparer<ReadOnlyMemory<object>>.LastIndexOf
	|
	|-RVA: 0x32D68F0 Offset: 0x32D69F1 VA: 0x32D68F0
	|-EqualityComparer<Label>.LastIndexOf
	|
	|-RVA: 0x32D7440 Offset: 0x32D7541 VA: 0x32D7440
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x32D7FA0 Offset: 0x32D80A1 VA: 0x32D7FA0
	|-EqualityComparer<RuntimeTypeHandle>.LastIndexOf
	|
	|-RVA: 0x32D8AE0 Offset: 0x32D8BE1 VA: 0x32D8AE0
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x32D9620 Offset: 0x32D9721 VA: 0x32D9620
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x32DACB0 Offset: 0x32DADB1 VA: 0x32DACB0
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x32DC330 Offset: 0x32DC431 VA: 0x32DC330
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DCE70 Offset: 0x32DCF71 VA: 0x32DCE70
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x32DD9C0 Offset: 0x32DDAC1 VA: 0x32DD9C0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x32DE530 Offset: 0x32DE631 VA: 0x32DE530
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DF0A0 Offset: 0x32DF1A1 VA: 0x32DF0A0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x32DFC10 Offset: 0x32DFD11 VA: 0x32DFC10
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x32E0780 Offset: 0x32E0881 VA: 0x32E0780
	|-EqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x32E1300 Offset: 0x32E1401 VA: 0x32E1300
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32E1F10 Offset: 0x32E2011 VA: 0x32E1F10
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x32E2C40 Offset: 0x32E2D41 VA: 0x32E2C40
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-EqualityComparer<TransitionTables>.LastIndexOf
	|
	|-RVA: 0x32E4540 Offset: 0x32E4641 VA: 0x32E4540
	|-EqualityComparer<TutorialUnlockFlagData>.LastIndexOf
	|
	|-RVA: 0x32E50C0 Offset: 0x32E51C1 VA: 0x32E50C0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.LastIndexOf
	|
	|-RVA: 0x32E5CB0 Offset: 0x32E5DB1 VA: 0x32E5CB0
	|-EqualityComparer<CapEdge>.LastIndexOf
	|
	|-RVA: 0x30F1D20 Offset: 0x30F1E21 VA: 0x30F1D20
	|-EqualityComparer<ClippedEdge>.LastIndexOf
	|
	|-RVA: 0x30F2910 Offset: 0x30F2A11 VA: 0x30F2910
	|-EqualityComparer<EdgeKeyByHash>.LastIndexOf
	|
	|-RVA: 0x30F3450 Offset: 0x30F3551 VA: 0x30F3450
	|-EqualityComparer<EdgeKeyByIndex>.LastIndexOf
	|
	|-RVA: 0x30F3F90 Offset: 0x30F4091 VA: 0x30F3F90
	|-EqualityComparer<MeshDataConnectivity.Face>.LastIndexOf
	|
	|-RVA: 0x30F4B30 Offset: 0x30F4C31 VA: 0x30F4B30
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.LastIndexOf
	|
	|-RVA: 0x30F57A0 Offset: 0x30F58A1 VA: 0x30F57A0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.LastIndexOf
	|
	|-RVA: 0x30F63F0 Offset: 0x30F64F1 VA: 0x30F63F0
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|
	|-RVA: 0x30F7050 Offset: 0x30F7151 VA: 0x30F7050
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|
	|-RVA: 0x30F7DE0 Offset: 0x30F7EE1 VA: 0x30F7DE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x30F8940 Offset: 0x30F8A41 VA: 0x30F8940
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x30F9490 Offset: 0x30F9591 VA: 0x30F9490
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x30FA050 Offset: 0x30FA151 VA: 0x30FA050
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x30FACA0 Offset: 0x30FADA1 VA: 0x30FACA0
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x30FB8F0 Offset: 0x30FB9F1 VA: 0x30FB8F0
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x30FC4E0 Offset: 0x30FC5E1 VA: 0x30FC4E0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x30FD050 Offset: 0x30FD151 VA: 0x30FD050
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x30FDCF0 Offset: 0x30FDDF1 VA: 0x30FDCF0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x30FEB30 Offset: 0x30FEC31 VA: 0x30FEB30
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x30FF810 Offset: 0x30FF911 VA: 0x30FF810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	|
	|-RVA: 0x3100360 Offset: 0x3100461 VA: 0x3100360
	|-EqualityComparer<GradientAlphaKey>.LastIndexOf
	|
	|-RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	|-EqualityComparer<GradientColorKey>.LastIndexOf
	|
	|-RVA: 0x3101B90 Offset: 0x3101C91 VA: 0x3101B90
	|-EqualityComparer<Keyframe>.LastIndexOf
	|
	|-RVA: 0x31027D0 Offset: 0x31028D1 VA: 0x31027D0
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x31033B0 Offset: 0x31034B1 VA: 0x31033B0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x31040A0 Offset: 0x31041A1 VA: 0x31040A0
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3104CD0 Offset: 0x3104DD1 VA: 0x3104CD0
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3105890 Offset: 0x3105991 VA: 0x3105890
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3106490 Offset: 0x3106591 VA: 0x3106490
	|-EqualityComparer<PlayableGraph>.LastIndexOf
	|
	|-RVA: 0x3106FF0 Offset: 0x31070F1 VA: 0x3106FF0
	|-EqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x3107B60 Offset: 0x3107C61 VA: 0x3107B60
	|-EqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x3108730 Offset: 0x3108831 VA: 0x3108730
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x31092D0 Offset: 0x31093D1 VA: 0x31092D0
	|-EqualityComparer<RangeInt>.LastIndexOf
	|
	|-RVA: 0x3109EA0 Offset: 0x3109FA1 VA: 0x3109EA0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x310ABA0 Offset: 0x310ACA1 VA: 0x310ABA0
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x310B860 Offset: 0x310B961 VA: 0x310B860
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x310C410 Offset: 0x310C511 VA: 0x310C410
	|-EqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x310CF80 Offset: 0x310D081 VA: 0x310CF80
	|-EqualityComparer<ReflectionProbeBlendInfo>.LastIndexOf
	|
	|-RVA: 0x310DC00 Offset: 0x310DD01 VA: 0x310DC00
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x310E9F0 Offset: 0x310EAF1 VA: 0x310E9F0
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x310F5B0 Offset: 0x310F6B1 VA: 0x310F5B0
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x2EA7910 Offset: 0x2EA7A11 VA: 0x2EA7910
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EA8560 Offset: 0x2EA8661 VA: 0x2EA8560
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EA91D0 Offset: 0x2EA92D1 VA: 0x2EA91D0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x2EA9E20 Offset: 0x2EA9F21 VA: 0x2EA9E20
	|-EqualityComparer<SceneInstance>.LastIndexOf
	|
	|-RVA: 0x2EAA9E0 Offset: 0x2EAAAE1 VA: 0x2EAA9E0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x2EAB650 Offset: 0x2EAB751 VA: 0x2EAB650
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x2EAC2A0 Offset: 0x2EAC3A1 VA: 0x2EAC2A0
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EACE80 Offset: 0x2EACF81 VA: 0x2EACE80
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x2EADB30 Offset: 0x2EADC31 VA: 0x2EADB30
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x2EAE780 Offset: 0x2EAE881 VA: 0x2EAE780
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2EAF3D0 Offset: 0x2EAF4D1 VA: 0x2EAF3D0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EB0E50 Offset: 0x2EB0F51 VA: 0x2EB0E50
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EB1B00 Offset: 0x2EB1C01 VA: 0x2EB1B00
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EB2720 Offset: 0x2EB2821 VA: 0x2EB2720
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x2EB32D0 Offset: 0x2EB33D1 VA: 0x2EB32D0
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|
	|-RVA: 0x2EB49A0 Offset: 0x2EB4AA1 VA: 0x2EB49A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|
	|-RVA: 0x2EB54F0 Offset: 0x2EB55F1 VA: 0x2EB54F0
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x2EB6130 Offset: 0x2EB6231 VA: 0x2EB6130
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x2EB6EC0 Offset: 0x2EB6FC1 VA: 0x2EB6EC0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x2EB7AC0 Offset: 0x2EB7BC1 VA: 0x2EB7AC0
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EB8620 Offset: 0x2EB8721 VA: 0x2EB8620
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EB9190 Offset: 0x2EB9291 VA: 0x2EB9190
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EB9D50 Offset: 0x2EB9E51 VA: 0x2EB9D50
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EBA8F0 Offset: 0x2EBA9F1 VA: 0x2EBA8F0
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2EBB5B0 Offset: 0x2EBB6B1 VA: 0x2EBB5B0
	|-EqualityComparer<WarpPoints.WarpPoint>.LastIndexOf
	|
	|-RVA: 0x2EBC380 Offset: 0x2EBC481 VA: 0x2EBC380
	|-EqualityComparer<YieldItemParam>.LastIndexOf
	|
	|-RVA: 0x2EBCF20 Offset: 0x2EBD021 VA: 0x2EBCF20
	|-EqualityComparer<stCommand_t>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EB40 Offset: 0x2E3EC41 VA: 0x2E3EB40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E3F700 Offset: 0x2E3F801 VA: 0x2E3F700
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40250 Offset: 0x2E40351 VA: 0x2E40250
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40FC0 Offset: 0x2E410C1 VA: 0x2E40FC0
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E41CA0 Offset: 0x2E41DA1 VA: 0x2E41CA0
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E42810 Offset: 0x2E42911 VA: 0x2E42810
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E43F10 Offset: 0x2E44011 VA: 0x2E43F10
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E44A60 Offset: 0x2E44B61 VA: 0x2E44A60
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E455A0 Offset: 0x2E456A1 VA: 0x2E455A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E461D0 Offset: 0x2E462D1 VA: 0x2E461D0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E46EB0 Offset: 0x2E46FB1 VA: 0x2E46EB0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E47B50 Offset: 0x2E47C51 VA: 0x2E47B50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E486F0 Offset: 0x2E487F1 VA: 0x2E486F0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E492E0 Offset: 0x2E493E1 VA: 0x2E492E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E49F30 Offset: 0x2E4A031 VA: 0x2E49F30
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4AB80 Offset: 0x2E4AC81 VA: 0x2E4AB80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4B740 Offset: 0x2E4B841 VA: 0x2E4B740
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4C3E0 Offset: 0x2E4C4E1 VA: 0x2E4C3E0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4D0A0 Offset: 0x2E4D1A1 VA: 0x2E4D0A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4DC80 Offset: 0x2E4DD81 VA: 0x2E4DC80
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4E7F0 Offset: 0x2E4E8F1 VA: 0x2E4E7F0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4FEB0 Offset: 0x2E4FFB1 VA: 0x2E4FEB0
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E50B20 Offset: 0x2E50C21 VA: 0x2E50B20
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E51740 Offset: 0x2E51841 VA: 0x2E51740
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E523A0 Offset: 0x2E524A1 VA: 0x2E523A0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53040 Offset: 0x2E53141 VA: 0x2E53040
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53CF0 Offset: 0x2E53DF1 VA: 0x2E53CF0
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E549B0 Offset: 0x2E54AB1 VA: 0x2E549B0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E555B0 Offset: 0x2E556B1 VA: 0x2E555B0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56230 Offset: 0x2E56331 VA: 0x2E56230
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56EE0 Offset: 0x2E56FE1 VA: 0x2E56EE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E57AC0 Offset: 0x2E57BC1 VA: 0x2E57AC0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FEC30 Offset: 0x31FED31 VA: 0x31FEC30
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FF8C0 Offset: 0x31FF9C1 VA: 0x31FF8C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3200480 Offset: 0x3200581 VA: 0x3200480
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201090 Offset: 0x3201191 VA: 0x3201090
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201C70 Offset: 0x3201D71 VA: 0x3201C70
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32027E0 Offset: 0x32028E1 VA: 0x32027E0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3203420 Offset: 0x3203521 VA: 0x3203420
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204030 Offset: 0x3204131 VA: 0x3204030
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204B80 Offset: 0x3204C81 VA: 0x3204B80
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3205700 Offset: 0x3205801 VA: 0x3205700
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32062B0 Offset: 0x32063B1 VA: 0x32062B0
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3207A40 Offset: 0x3207B41 VA: 0x3207A40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3208690 Offset: 0x3208791 VA: 0x3208690
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209DE0 Offset: 0x3209EE1 VA: 0x3209DE0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320AAA0 Offset: 0x320ABA1 VA: 0x320AAA0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320B6D0 Offset: 0x320B7D1 VA: 0x320B6D0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320C220 Offset: 0x320C321 VA: 0x320C220
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320CD60 Offset: 0x320CE61 VA: 0x320CD60
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320E410 Offset: 0x320E511 VA: 0x320E410
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320EF70 Offset: 0x320F071 VA: 0x320EF70
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320FAC0 Offset: 0x320FBC1 VA: 0x320FAC0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3210620 Offset: 0x3210721 VA: 0x3210620
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211170 Offset: 0x3211271 VA: 0x3211170
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211CD0 Offset: 0x3211DD1 VA: 0x3211CD0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3212820 Offset: 0x3212921 VA: 0x3212820
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213390 Offset: 0x3213491 VA: 0x3213390
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213EE0 Offset: 0x3213FE1 VA: 0x3213EE0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3214A20 Offset: 0x3214B21 VA: 0x3214A20
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3215560 Offset: 0x3215661 VA: 0x3215560
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32160A0 Offset: 0x32161A1 VA: 0x32160A0
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3216C00 Offset: 0x3216D01 VA: 0x3216C00
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3217770 Offset: 0x3217871 VA: 0x3217770
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32183B0 Offset: 0x32184B1 VA: 0x32183B0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3218FB0 Offset: 0x32190B1 VA: 0x3218FB0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3219BF0 Offset: 0x3219CF1 VA: 0x3219BF0
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321A8E0 Offset: 0x321A9E1 VA: 0x321A8E0
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321B4E0 Offset: 0x321B5E1 VA: 0x321B4E0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32C9DA0 Offset: 0x32C9EA1 VA: 0x32C9DA0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CA9B0 Offset: 0x32CAAB1 VA: 0x32CA9B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CB5C0 Offset: 0x32CB6C1 VA: 0x32CB5C0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CCE10 Offset: 0x32CCF11 VA: 0x32CCE10
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CDAF0 Offset: 0x32CDBF1 VA: 0x32CDAF0
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CE810 Offset: 0x32CE911 VA: 0x32CE810
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CF420 Offset: 0x32CF521 VA: 0x32CF420
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0030 Offset: 0x32D0131 VA: 0x32D0030
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0CB0 Offset: 0x32D0DB1 VA: 0x32D0CB0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D18C0 Offset: 0x32D19C1 VA: 0x32D18C0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2460 Offset: 0x32D2561 VA: 0x32D2460
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2FE0 Offset: 0x32D30E1 VA: 0x32D2FE0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D3B50 Offset: 0x32D3C51 VA: 0x32D3B50
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D4750 Offset: 0x32D4851 VA: 0x32D4750
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5320 Offset: 0x32D5421 VA: 0x32D5320
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5E60 Offset: 0x32D5F61 VA: 0x32D5E60
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D69B0 Offset: 0x32D6AB1 VA: 0x32D69B0
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D7510 Offset: 0x32D7611 VA: 0x32D7510
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8060 Offset: 0x32D8161 VA: 0x32D8060
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8BA0 Offset: 0x32D8CA1 VA: 0x32D8BA0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D96E0 Offset: 0x32D97E1 VA: 0x32D96E0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DA230 Offset: 0x32DA331 VA: 0x32DA230
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DAD70 Offset: 0x32DAE71 VA: 0x32DAD70
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DB8B0 Offset: 0x32DB9B1 VA: 0x32DB8B0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DC3F0 Offset: 0x32DC4F1 VA: 0x32DC3F0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DCF30 Offset: 0x32DD031 VA: 0x32DCF30
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DDA90 Offset: 0x32DDB91 VA: 0x32DDA90
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DF170 Offset: 0x32DF271 VA: 0x32DF170
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DFCE0 Offset: 0x32DFDE1 VA: 0x32DFCE0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E0850 Offset: 0x32E0951 VA: 0x32E0850
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E13E0 Offset: 0x32E14E1 VA: 0x32E13E0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2060 Offset: 0x32E2161 VA: 0x32E2060
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2D90 Offset: 0x32E2E91 VA: 0x32E2D90
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E3A40 Offset: 0x32E3B41 VA: 0x32E3A40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E4620 Offset: 0x32E4721 VA: 0x32E4620
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5190 Offset: 0x32E5291 VA: 0x32E5190
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5DF0 Offset: 0x32E5EF1 VA: 0x32E5DF0
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F1E30 Offset: 0x30F1F31 VA: 0x30F1E30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F29D0 Offset: 0x30F2AD1 VA: 0x30F29D0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F3510 Offset: 0x30F3611 VA: 0x30F3510
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4050 Offset: 0x30F4151 VA: 0x30F4050
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4C40 Offset: 0x30F4D41 VA: 0x30F4C40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F58D0 Offset: 0x30F59D1 VA: 0x30F58D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F64C0 Offset: 0x30F65C1 VA: 0x30F64C0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7200 Offset: 0x30F7301 VA: 0x30F7200
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7EB0 Offset: 0x30F7FB1 VA: 0x30F7EB0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F8A00 Offset: 0x30F8B01 VA: 0x30F8A00
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F9560 Offset: 0x30F9661 VA: 0x30F9560
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FADB0 Offset: 0x30FAEB1 VA: 0x30FADB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FBA00 Offset: 0x30FBB01 VA: 0x30FBA00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FC5A0 Offset: 0x30FC6A1 VA: 0x30FC5A0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FD140 Offset: 0x30FD241 VA: 0x30FD140
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FDEA0 Offset: 0x30FDFA1 VA: 0x30FDEA0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FECA0 Offset: 0x30FEDA1 VA: 0x30FECA0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FF8D0 Offset: 0x30FF9D1 VA: 0x30FF8D0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101030 Offset: 0x3101131 VA: 0x3101030
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101CC0 Offset: 0x3101DC1 VA: 0x3101CC0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3102890 Offset: 0x3102991 VA: 0x3102890
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3103500 Offset: 0x3103601 VA: 0x3103500
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31041C0 Offset: 0x31042C1 VA: 0x31041C0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3104DA0 Offset: 0x3104EA1 VA: 0x3104DA0
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31059A0 Offset: 0x3105AA1 VA: 0x31059A0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3106560 Offset: 0x3106661 VA: 0x3106560
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31070B0 Offset: 0x31071B1 VA: 0x31070B0
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3107C50 Offset: 0x3107D51 VA: 0x3107C50
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3108820 Offset: 0x3108921 VA: 0x3108820
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109390 Offset: 0x3109491 VA: 0x3109390
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109FE0 Offset: 0x310A0E1 VA: 0x3109FE0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310ACF0 Offset: 0x310ADF1 VA: 0x310ACF0
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310B950 Offset: 0x310BA51 VA: 0x310B950
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310C4E0 Offset: 0x310C5E1 VA: 0x310C4E0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310D050 Offset: 0x310D151 VA: 0x310D050
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310DDD0 Offset: 0x310DED1 VA: 0x310DDD0
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310EAC0 Offset: 0x310EBC1 VA: 0x310EAC0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310F6C0 Offset: 0x310F7C1 VA: 0x310F6C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA7A20 Offset: 0x2EA7B21 VA: 0x2EA7A20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA8670 Offset: 0x2EA8771 VA: 0x2EA8670
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9300 Offset: 0x2EA9401 VA: 0x2EA9300
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9EF0 Offset: 0x2EA9FF1 VA: 0x2EA9EF0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAAAF0 Offset: 0x2EAABF1 VA: 0x2EAAAF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAB780 Offset: 0x2EAB881 VA: 0x2EAB780
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAC370 Offset: 0x2EAC471 VA: 0x2EAC370
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EACFB0 Offset: 0x2EAD0B1 VA: 0x2EACFB0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EADC40 Offset: 0x2EADD41 VA: 0x2EADC40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAE890 Offset: 0x2EAE991 VA: 0x2EAE890
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0230 Offset: 0x2EB0331 VA: 0x2EB0230
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0F80 Offset: 0x2EB1081 VA: 0x2EB0F80
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB1C10 Offset: 0x2EB1D11 VA: 0x2EB1C10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB2810 Offset: 0x2EB2911 VA: 0x2EB2810
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB33A0 Offset: 0x2EB34A1 VA: 0x2EB33A0
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB3F10 Offset: 0x2EB4011 VA: 0x2EB3F10
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB4A60 Offset: 0x2EB4B61 VA: 0x2EB4A60
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB55C0 Offset: 0x2EB56C1 VA: 0x2EB55C0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB62C0 Offset: 0x2EB63C1 VA: 0x2EB62C0
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB6FD0 Offset: 0x2EB70D1 VA: 0x2EB6FD0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB7B90 Offset: 0x2EB7C91 VA: 0x2EB7B90
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9280 Offset: 0x2EB9381 VA: 0x2EB9280
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9E30 Offset: 0x2EB9F31 VA: 0x2EB9E30
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBA9E0 Offset: 0x2EBAAE1 VA: 0x2EBA9E0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBB780 Offset: 0x2EBB881 VA: 0x2EBB780
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBC440 Offset: 0x2EBC541 VA: 0x2EBC440
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBD030 Offset: 0x2EBD131 VA: 0x2EBD030
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EC40 Offset: 0x2E3ED41 VA: 0x2E3EC40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E3F7E0 Offset: 0x2E3F8E1 VA: 0x2E3F7E0
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E40330 Offset: 0x2E40431 VA: 0x2E40330
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41120 Offset: 0x2E41221 VA: 0x2E41120
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E428F0 Offset: 0x2E429F1 VA: 0x2E428F0
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43480 Offset: 0x2E43581 VA: 0x2E43480
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43FF0 Offset: 0x2E440F1 VA: 0x2E43FF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E462E0 Offset: 0x2E463E1 VA: 0x2E462E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E46FC0 Offset: 0x2E470C1 VA: 0x2E46FC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E47C50 Offset: 0x2E47D51 VA: 0x2E47C50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E487D0 Offset: 0x2E488D1 VA: 0x2E487D0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E493E0 Offset: 0x2E494E1 VA: 0x2E493E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4A030 Offset: 0x2E4A131 VA: 0x2E4A030
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4AC80 Offset: 0x2E4AD81 VA: 0x2E4AC80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4B820 Offset: 0x2E4B921 VA: 0x2E4B820
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4C500 Offset: 0x2E4C601 VA: 0x2E4C500
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4D1A0 Offset: 0x2E4D2A1 VA: 0x2E4D1A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4DD60 Offset: 0x2E4DE61 VA: 0x2E4DD60
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4E8D0 Offset: 0x2E4E9D1 VA: 0x2E4E8D0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4F440 Offset: 0x2E4F541 VA: 0x2E4F440
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4FF90 Offset: 0x2E50091 VA: 0x2E4FF90
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E50C40 Offset: 0x2E50D41 VA: 0x2E50C40
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E524B0 Offset: 0x2E525B1 VA: 0x2E524B0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53150 Offset: 0x2E53251 VA: 0x2E53150
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53E00 Offset: 0x2E53F01 VA: 0x2E53E00
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E54AC0 Offset: 0x2E54BC1 VA: 0x2E54AC0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E55690 Offset: 0x2E55791 VA: 0x2E55690
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56350 Offset: 0x2E56451 VA: 0x2E56350
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56FE0 Offset: 0x2E570E1 VA: 0x2E56FE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E57BA0 Offset: 0x2E57CA1 VA: 0x2E57BA0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3200560 Offset: 0x3200661 VA: 0x3200560
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32011A0 Offset: 0x32012A1 VA: 0x32011A0
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3201D50 Offset: 0x3201E51 VA: 0x3201D50
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32028C0 Offset: 0x32029C1 VA: 0x32028C0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3203530 Offset: 0x3203631 VA: 0x3203530
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204110 Offset: 0x3204211 VA: 0x3204110
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204C60 Offset: 0x3204D61 VA: 0x3204C60
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32057E0 Offset: 0x32058E1 VA: 0x32057E0
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206390 Offset: 0x3206491 VA: 0x3206390
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206F20 Offset: 0x3207021 VA: 0x3206F20
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3207B40 Offset: 0x3207C41 VA: 0x3207B40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3208790 Offset: 0x3208891 VA: 0x3208790
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209330 Offset: 0x3209431 VA: 0x3209330
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320ABD0 Offset: 0x320ACD1 VA: 0x320ABD0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320B7B0 Offset: 0x320B8B1 VA: 0x320B7B0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320CE40 Offset: 0x320CF41 VA: 0x320CE40
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320D9A0 Offset: 0x320DAA1 VA: 0x320D9A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320E4F0 Offset: 0x320E5F1 VA: 0x320E4F0
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320F050 Offset: 0x320F151 VA: 0x320F050
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320FBA0 Offset: 0x320FCA1 VA: 0x320FBA0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3210700 Offset: 0x3210801 VA: 0x3210700
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211250 Offset: 0x3211351 VA: 0x3211250
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211DB0 Offset: 0x3211EB1 VA: 0x3211DB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3212900 Offset: 0x3212A01 VA: 0x3212900
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213470 Offset: 0x3213571 VA: 0x3213470
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213FC0 Offset: 0x32140C1 VA: 0x3213FC0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3214B00 Offset: 0x3214C01 VA: 0x3214B00
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3215640 Offset: 0x3215741 VA: 0x3215640
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216180 Offset: 0x3216281 VA: 0x3216180
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216CE0 Offset: 0x3216DE1 VA: 0x3216CE0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3217850 Offset: 0x3217951 VA: 0x3217850
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32184E0 Offset: 0x32185E1 VA: 0x32184E0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32190A0 Offset: 0x32191A1 VA: 0x32190A0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3219D20 Offset: 0x3219E21 VA: 0x3219D20
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321AA10 Offset: 0x321AB11 VA: 0x321AA10
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321B5D0 Offset: 0x321B6D1 VA: 0x321B5D0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32C9EC0 Offset: 0x32C9FC1 VA: 0x32C9EC0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CB6E0 Offset: 0x32CB7E1 VA: 0x32CB6E0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CC360 Offset: 0x32CC461 VA: 0x32CC360
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CDC40 Offset: 0x32CDD41 VA: 0x32CDC40
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CE930 Offset: 0x32CEA31 VA: 0x32CE930
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CF510 Offset: 0x32CF611 VA: 0x32CF510
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0150 Offset: 0x32D0251 VA: 0x32D0150
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0DD0 Offset: 0x32D0ED1 VA: 0x32D0DD0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D19B0 Offset: 0x32D1AB1 VA: 0x32D19B0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D2550 Offset: 0x32D2651 VA: 0x32D2550
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D30D0 Offset: 0x32D31D1 VA: 0x32D30D0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D3C40 Offset: 0x32D3D41 VA: 0x32D3C40
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D4870 Offset: 0x32D4971 VA: 0x32D4870
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D53F0 Offset: 0x32D54F1 VA: 0x32D53F0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D5F40 Offset: 0x32D6041 VA: 0x32D5F40
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D6A90 Offset: 0x32D6B91 VA: 0x32D6A90
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D75F0 Offset: 0x32D76F1 VA: 0x32D75F0
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8C80 Offset: 0x32D8D81 VA: 0x32D8C80
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DA310 Offset: 0x32DA411 VA: 0x32DA310
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DAE50 Offset: 0x32DAF51 VA: 0x32DAE50
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DB990 Offset: 0x32DBA91 VA: 0x32DB990
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DC4D0 Offset: 0x32DC5D1 VA: 0x32DC4D0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DD010 Offset: 0x32DD111 VA: 0x32DD010
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DDB70 Offset: 0x32DDC71 VA: 0x32DDB70
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DF250 Offset: 0x32DF351 VA: 0x32DF250
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DFDC0 Offset: 0x32DFEC1 VA: 0x32DFDC0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E0930 Offset: 0x32E0A31 VA: 0x32E0930
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E14C0 Offset: 0x32E15C1 VA: 0x32E14C0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2180 Offset: 0x32E2281 VA: 0x32E2180
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2EB0 Offset: 0x32E2FB1 VA: 0x32E2EB0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E3B40 Offset: 0x32E3C41 VA: 0x32E3B40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E4700 Offset: 0x32E4801 VA: 0x32E4700
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5270 Offset: 0x32E5371 VA: 0x32E5270
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5F00 Offset: 0x32E6001 VA: 0x32E5F00
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F1F30 Offset: 0x30F2031 VA: 0x30F1F30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F2AB0 Offset: 0x30F2BB1 VA: 0x30F2AB0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F35F0 Offset: 0x30F36F1 VA: 0x30F35F0
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4130 Offset: 0x30F4231 VA: 0x30F4130
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4D40 Offset: 0x30F4E41 VA: 0x30F4D40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F59E0 Offset: 0x30F5AE1 VA: 0x30F59E0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7350 Offset: 0x30F7451 VA: 0x30F7350
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7F90 Offset: 0x30F8091 VA: 0x30F7F90
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F8AE0 Offset: 0x30F8BE1 VA: 0x30F8AE0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F9640 Offset: 0x30F9741 VA: 0x30F9640
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FA260 Offset: 0x30FA361 VA: 0x30FA260
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FAEB0 Offset: 0x30FAFB1 VA: 0x30FAEB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FBB00 Offset: 0x30FBC01 VA: 0x30FBB00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FC680 Offset: 0x30FC781 VA: 0x30FC680
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FD220 Offset: 0x30FD321 VA: 0x30FD220
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FDFF0 Offset: 0x30FE0F1 VA: 0x30FDFF0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FEDD0 Offset: 0x30FEED1 VA: 0x30FEDD0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FF9B0 Offset: 0x30FFAB1 VA: 0x30FF9B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3100510 Offset: 0x3100611 VA: 0x3100510
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101130 Offset: 0x3101231 VA: 0x3101130
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101DD0 Offset: 0x3101ED1 VA: 0x3101DD0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3102970 Offset: 0x3102A71 VA: 0x3102970
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3103620 Offset: 0x3103721 VA: 0x3103620
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31042D0 Offset: 0x31043D1 VA: 0x31042D0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3104E80 Offset: 0x3104F81 VA: 0x3104E80
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3105AA0 Offset: 0x3105BA1 VA: 0x3105AA0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3106640 Offset: 0x3106741 VA: 0x3106640
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107190 Offset: 0x3107291 VA: 0x3107190
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107D30 Offset: 0x3107E31 VA: 0x3107D30
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3108900 Offset: 0x3108A01 VA: 0x3108900
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3109470 Offset: 0x3109571 VA: 0x3109470
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310A0F0 Offset: 0x310A1F1 VA: 0x310A0F0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310AE10 Offset: 0x310AF11 VA: 0x310AE10
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310BA30 Offset: 0x310BB31 VA: 0x310BA30
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310C5C0 Offset: 0x310C6C1 VA: 0x310C5C0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310D130 Offset: 0x310D231 VA: 0x310D130
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310DF40 Offset: 0x310E041 VA: 0x310DF40
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310EBA0 Offset: 0x310ECA1 VA: 0x310EBA0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310F7C0 Offset: 0x310F8C1 VA: 0x310F7C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA7B20 Offset: 0x2EA7C21 VA: 0x2EA7B20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA8770 Offset: 0x2EA8871 VA: 0x2EA8770
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9410 Offset: 0x2EA9511 VA: 0x2EA9410
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9FD0 Offset: 0x2EAA0D1 VA: 0x2EA9FD0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAABF0 Offset: 0x2EAACF1 VA: 0x2EAABF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAB890 Offset: 0x2EAB991 VA: 0x2EAB890
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAC450 Offset: 0x2EAC551 VA: 0x2EAC450
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAD0C0 Offset: 0x2EAD1C1 VA: 0x2EAD0C0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAE990 Offset: 0x2EAEA91 VA: 0x2EAE990
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAF5E0 Offset: 0x2EAF6E1 VA: 0x2EAF5E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB0370 Offset: 0x2EB0471 VA: 0x2EB0370
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1090 Offset: 0x2EB1191 VA: 0x2EB1090
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1D10 Offset: 0x2EB1E11 VA: 0x2EB1D10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3480 Offset: 0x2EB3581 VA: 0x2EB3480
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3FF0 Offset: 0x2EB40F1 VA: 0x2EB3FF0
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB4B40 Offset: 0x2EB4C41 VA: 0x2EB4B40
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB56A0 Offset: 0x2EB57A1 VA: 0x2EB56A0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB6400 Offset: 0x2EB6501 VA: 0x2EB6400
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB70D0 Offset: 0x2EB71D1 VA: 0x2EB70D0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB7C70 Offset: 0x2EB7D71 VA: 0x2EB7C70
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB87C0 Offset: 0x2EB88C1 VA: 0x2EB87C0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9360 Offset: 0x2EB9461 VA: 0x2EB9360
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9F10 Offset: 0x2EBA011 VA: 0x2EB9F10
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBAAC0 Offset: 0x2EBABC1 VA: 0x2EBAAC0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBB8E0 Offset: 0x2EBB9E1 VA: 0x2EBB8E0
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBC520 Offset: 0x2EBC621 VA: 0x2EBC520
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EDF0 Offset: 0x2E3EEF1 VA: 0x2E3EDF0
	|-EqualityComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2E3F960 Offset: 0x2E3FA61 VA: 0x2E3F960
	|-EqualityComparer<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x2E404A0 Offset: 0x2E405A1 VA: 0x2E404A0
	|-EqualityComparer<BitVector32Int>..ctor
	|
	|-RVA: 0x2E41390 Offset: 0x2E41491 VA: 0x2E41390
	|-EqualityComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-EqualityComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2E42A70 Offset: 0x2E42B71 VA: 0x2E42A70
	|-EqualityComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2E43600 Offset: 0x2E43701 VA: 0x2E43600
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2E44170 Offset: 0x2E44271 VA: 0x2E44170
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E44CB0 Offset: 0x2E44DB1 VA: 0x2E44CB0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E457F0 Offset: 0x2E458F1 VA: 0x2E457F0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2E471A0 Offset: 0x2E472A1 VA: 0x2E471A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2E47E00 Offset: 0x2E47F01 VA: 0x2E47E00
	|-EqualityComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2E48940 Offset: 0x2E48A41 VA: 0x2E48940
	|-EqualityComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2E49590 Offset: 0x2E49691 VA: 0x2E49590
	|-EqualityComparer<EffectDataTable>..ctor
	|
	|-RVA: 0x2E4A1E0 Offset: 0x2E4A2E1 VA: 0x2E4A1E0
	|-EqualityComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2E4AE30 Offset: 0x2E4AF31 VA: 0x2E4AE30
	|-EqualityComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2E4B9A0 Offset: 0x2E4BAA1 VA: 0x2E4B9A0
	|-EqualityComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2E4C700 Offset: 0x2E4C801 VA: 0x2E4C700
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E4D350 Offset: 0x2E4D451 VA: 0x2E4D350
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E4DEE0 Offset: 0x2E4DFE1 VA: 0x2E4DEE0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E4EA50 Offset: 0x2E4EB51 VA: 0x2E4EA50
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E4F5C0 Offset: 0x2E4F6C1 VA: 0x2E4F5C0
	|-EqualityComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2E50100 Offset: 0x2E50201 VA: 0x2E50100
	|-EqualityComparer<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E50E30 Offset: 0x2E50F31 VA: 0x2E50E30
	|-EqualityComparer<MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E519A0 Offset: 0x2E51AA1 VA: 0x2E519A0
	|-EqualityComparer<MiningDataTable>..ctor
	|
	|-RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	|-EqualityComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2E53310 Offset: 0x2E53411 VA: 0x2E53310
	|-EqualityComparer<MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53FD0 Offset: 0x2E540D1 VA: 0x2E53FD0
	|-EqualityComparer<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54CA0 Offset: 0x2E54DA1 VA: 0x2E54CA0
	|-EqualityComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E55810 Offset: 0x2E55911 VA: 0x2E55810
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	|-EqualityComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2E57190 Offset: 0x2E57291 VA: 0x2E57190
	|-EqualityComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2E57D20 Offset: 0x2E57E21 VA: 0x2E57D20
	|-EqualityComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31FEF20 Offset: 0x31FF021 VA: 0x31FEF20
	|-EqualityComparer<OrderSaveData>..ctor
	|
	|-RVA: 0x31FFB70 Offset: 0x31FFC71 VA: 0x31FFB70
	|-EqualityComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32006E0 Offset: 0x32007E1 VA: 0x32006E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3201360 Offset: 0x3201461 VA: 0x3201360
	|-EqualityComparer<Parameter>..ctor
	|
	|-RVA: 0x3201ED0 Offset: 0x3201FD1 VA: 0x3201ED0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x3202A40 Offset: 0x3202B41 VA: 0x3202A40
	|-EqualityComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x3203700 Offset: 0x3203801 VA: 0x3203700
	|-EqualityComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3204290 Offset: 0x3204391 VA: 0x3204290
	|-EqualityComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3204DD0 Offset: 0x3204ED1 VA: 0x3204DD0
	|-EqualityComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3205960 Offset: 0x3205A61 VA: 0x3205960
	|-EqualityComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3206530 Offset: 0x3206631 VA: 0x3206530
	|-EqualityComparer<ProfilerFrame>..ctor
	|
	|-RVA: 0x32070A0 Offset: 0x32071A1 VA: 0x32070A0
	|-EqualityComparer<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x3207CF0 Offset: 0x3207DF1 VA: 0x3207CF0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x3208940 Offset: 0x3208A41 VA: 0x3208940
	|-EqualityComparer<Schedule>..ctor
	|
	|-RVA: 0x32094B0 Offset: 0x32095B1 VA: 0x32094B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x320A040 Offset: 0x320A141 VA: 0x320A040
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-EqualityComparer<CurveSample>..ctor
	|
	|-RVA: 0x320B930 Offset: 0x320BA31 VA: 0x320B930
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x320C470 Offset: 0x320C571 VA: 0x320C470
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x320CFB0 Offset: 0x320D0B1 VA: 0x320CFB0
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x320DB20 Offset: 0x320DC21 VA: 0x320DB20
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x320E660 Offset: 0x320E761 VA: 0x320E660
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x320F1D0 Offset: 0x320F2D1 VA: 0x320F1D0
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x320FD10 Offset: 0x320FE11 VA: 0x320FD10
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3210880 Offset: 0x3210981 VA: 0x3210880
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32113C0 Offset: 0x32114C1 VA: 0x32113C0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3211F30 Offset: 0x3212031 VA: 0x3211F30
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3212A80 Offset: 0x3212B81 VA: 0x3212A80
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x32135F0 Offset: 0x32136F1 VA: 0x32135F0
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3214130 Offset: 0x3214231 VA: 0x3214130
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3214C70 Offset: 0x3214D71 VA: 0x3214C70
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x32157B0 Offset: 0x32158B1 VA: 0x32157B0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x32162F0 Offset: 0x32163F1 VA: 0x32162F0
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3216E60 Offset: 0x3216F61 VA: 0x3216E60
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x32179D0 Offset: 0x3217AD1 VA: 0x32179D0
	|-EqualityComparer<Memory<object>>..ctor
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3219210 Offset: 0x3219311 VA: 0x3219210
	|-EqualityComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3219F00 Offset: 0x321A001 VA: 0x3219F00
	|-EqualityComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x321ABF0 Offset: 0x321ACF1 VA: 0x321ABF0
	|-EqualityComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x321B740 Offset: 0x321B841 VA: 0x321B740
	|-EqualityComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x32CA080 Offset: 0x32CA181 VA: 0x32CA080
	|-EqualityComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x32CAC20 Offset: 0x32CAD21 VA: 0x32CAC20
	|-EqualityComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x32CB8A0 Offset: 0x32CB9A1 VA: 0x32CB8A0
	|-EqualityComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x32CC520 Offset: 0x32CC621 VA: 0x32CC520
	|-EqualityComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x32CD070 Offset: 0x32CD171 VA: 0x32CD070
	|-EqualityComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x32CDE70 Offset: 0x32CDF71 VA: 0x32CDE70
	|-EqualityComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x32CEAF0 Offset: 0x32CEBF1 VA: 0x32CEAF0
	|-EqualityComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x32CF690 Offset: 0x32CF791 VA: 0x32CF690
	|-EqualityComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x32D0310 Offset: 0x32D0411 VA: 0x32D0310
	|-EqualityComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32D0F90 Offset: 0x32D1091 VA: 0x32D0F90
	|-EqualityComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x32D1B30 Offset: 0x32D1C31 VA: 0x32D1B30
	|-EqualityComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x32D26D0 Offset: 0x32D27D1 VA: 0x32D26D0
	|-EqualityComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x32D3240 Offset: 0x32D3341 VA: 0x32D3240
	|-EqualityComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32D3DB0 Offset: 0x32D3EB1 VA: 0x32D3DB0
	|-EqualityComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x32D4A30 Offset: 0x32D4B31 VA: 0x32D4A30
	|-EqualityComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32D5550 Offset: 0x32D5651 VA: 0x32D5550
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x32D60C0 Offset: 0x32D61C1 VA: 0x32D60C0
	|-EqualityComparer<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x32D6C00 Offset: 0x32D6D01 VA: 0x32D6C00
	|-EqualityComparer<Label>..ctor
	|
	|-RVA: 0x32D7770 Offset: 0x32D7871 VA: 0x32D7770
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x32D82B0 Offset: 0x32D83B1 VA: 0x32D82B0
	|-EqualityComparer<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x32D8DF0 Offset: 0x32D8EF1 VA: 0x32D8DF0
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x32D9940 Offset: 0x32D9A41 VA: 0x32D9940
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x32DA480 Offset: 0x32DA581 VA: 0x32DA480
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x32DAFC0 Offset: 0x32DB0C1 VA: 0x32DAFC0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x32DBB00 Offset: 0x32DBC01 VA: 0x32DBB00
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x32DC640 Offset: 0x32DC741 VA: 0x32DC640
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32DD180 Offset: 0x32DD281 VA: 0x32DD180
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32DDCF0 Offset: 0x32DDDF1 VA: 0x32DDCF0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32DE860 Offset: 0x32DE961 VA: 0x32DE860
	|-EqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32DF3D0 Offset: 0x32DF4D1 VA: 0x32DF3D0
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32E0AB0 Offset: 0x32E0BB1 VA: 0x32E0AB0
	|-EqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x32E1640 Offset: 0x32E1741 VA: 0x32E1640
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32E2370 Offset: 0x32E2471 VA: 0x32E2370
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32E30A0 Offset: 0x32E31A1 VA: 0x32E30A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32E3CF0 Offset: 0x32E3DF1 VA: 0x32E3CF0
	|-EqualityComparer<TransitionTables>..ctor
	|
	|-RVA: 0x32E4880 Offset: 0x32E4981 VA: 0x32E4880
	|-EqualityComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32E60E0 Offset: 0x32E61E1 VA: 0x32E60E0
	|-EqualityComparer<CapEdge>..ctor
	|
	|-RVA: 0x30F20E0 Offset: 0x30F21E1 VA: 0x30F20E0
	|-EqualityComparer<ClippedEdge>..ctor
	|
	|-RVA: 0x30F2C20 Offset: 0x30F2D21 VA: 0x30F2C20
	|-EqualityComparer<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x30F3760 Offset: 0x30F3861 VA: 0x30F3760
	|-EqualityComparer<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x30F42A0 Offset: 0x30F43A1 VA: 0x30F42A0
	|-EqualityComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x30F4EF0 Offset: 0x30F4FF1 VA: 0x30F4EF0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x30F6720 Offset: 0x30F6821 VA: 0x30F6720
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x30F75A0 Offset: 0x30F76A1 VA: 0x30F75A0
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x30F8110 Offset: 0x30F8211 VA: 0x30F8110
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x30F8C50 Offset: 0x30F8D51 VA: 0x30F8C50
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x30F97C0 Offset: 0x30F98C1 VA: 0x30F97C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x30FA410 Offset: 0x30FA511 VA: 0x30FA410
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x30FB060 Offset: 0x30FB161 VA: 0x30FB060
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x30FBCB0 Offset: 0x30FBDB1 VA: 0x30FBCB0
	|-EqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x30FC7F0 Offset: 0x30FC8F1 VA: 0x30FC7F0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x30FD3C0 Offset: 0x30FD4C1 VA: 0x30FD3C0
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x30FE240 Offset: 0x30FE341 VA: 0x30FE240
	|-EqualityComparer<CombineInstance>..ctor
	|
	|-RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x30FFB20 Offset: 0x30FFC21 VA: 0x30FFB20
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x3100690 Offset: 0x3100791 VA: 0x3100690
	|-EqualityComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31012E0 Offset: 0x31013E1 VA: 0x31012E0
	|-EqualityComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x3101FA0 Offset: 0x31020A1 VA: 0x3101FA0
	|-EqualityComparer<Keyframe>..ctor
	|
	|-RVA: 0x3102AE0 Offset: 0x3102BE1 VA: 0x3102AE0
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3103810 Offset: 0x3103911 VA: 0x3103810
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3104490 Offset: 0x3104591 VA: 0x3104490
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3105000 Offset: 0x3105101 VA: 0x3105000
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3105C50 Offset: 0x3105D51 VA: 0x3105C50
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x31067C0 Offset: 0x31068C1 VA: 0x31067C0
	|-EqualityComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x3107300 Offset: 0x3107401 VA: 0x3107300
	|-EqualityComparer<Edge>..ctor
	|
	|-RVA: 0x3107ED0 Offset: 0x3107FD1 VA: 0x3107ED0
	|-EqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x3108AA0 Offset: 0x3108BA1 VA: 0x3108AA0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x31095E0 Offset: 0x31096E1 VA: 0x31095E0
	|-EqualityComparer<RangeInt>..ctor
	|
	|-RVA: 0x310A2D0 Offset: 0x310A3D1 VA: 0x310A2D0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x310B000 Offset: 0x310B101 VA: 0x310B000
	|-EqualityComparer<RaycastHit>..ctor
	|
	|-RVA: 0x310BBD0 Offset: 0x310BCD1 VA: 0x310BBD0
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x310C740 Offset: 0x310C841 VA: 0x310C740
	|-EqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x310D2B0 Offset: 0x310D3B1 VA: 0x310D2B0
	|-EqualityComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x310ED20 Offset: 0x310EE21 VA: 0x310ED20
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x310F970 Offset: 0x310FA71 VA: 0x310F970
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EA7CD0 Offset: 0x2EA7DD1 VA: 0x2EA7CD0
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EA8920 Offset: 0x2EA8A21 VA: 0x2EA8920
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EA95E0 Offset: 0x2EA96E1 VA: 0x2EA95E0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EAA150 Offset: 0x2EAA251 VA: 0x2EAA150
	|-EqualityComparer<SceneInstance>..ctor
	|
	|-RVA: 0x2EAADA0 Offset: 0x2EAAEA1 VA: 0x2EAADA0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2EABA60 Offset: 0x2EABB61 VA: 0x2EABA60
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EAC5D0 Offset: 0x2EAC6D1 VA: 0x2EAC5D0
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EAD2A0 Offset: 0x2EAD3A1 VA: 0x2EAD2A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2EADEF0 Offset: 0x2EADFF1 VA: 0x2EADEF0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EB1270 Offset: 0x2EB1371 VA: 0x2EB1270
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EB1EC0 Offset: 0x2EB1FC1 VA: 0x2EB1EC0
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EB2A90 Offset: 0x2EB2B91 VA: 0x2EB2A90
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x2EB3600 Offset: 0x2EB3701 VA: 0x2EB3600
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2EB4170 Offset: 0x2EB4271 VA: 0x2EB4170
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2EB4CB0 Offset: 0x2EB4DB1 VA: 0x2EB4CB0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2EB5820 Offset: 0x2EB5921 VA: 0x2EB5820
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x2EB6630 Offset: 0x2EB6731 VA: 0x2EB6630
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2EB7DF0 Offset: 0x2EB7EF1 VA: 0x2EB7DF0
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EB8930 Offset: 0x2EB8A31 VA: 0x2EB8930
	|-EqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EB9500 Offset: 0x2EB9601 VA: 0x2EB9500
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EBA090 Offset: 0x2EBA191 VA: 0x2EBA090
	|-EqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EBAC60 Offset: 0x2EBAD61 VA: 0x2EBAC60
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2EBBB50 Offset: 0x2EBBC51 VA: 0x2EBBB50
	|-EqualityComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-EqualityComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x2EBD2E0 Offset: 0x2EBD3E1 VA: 0x2EBD2E0
	|-EqualityComparer<stCommand_t>..ctor
	*/
}

[TypeDependencyAttribute] // RVA: 0xB3A20 Offset: 0xB3B21 VA: 0xB3A20
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1441
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A50 Offset: 0x32D4B51 VA: 0x32D4A50
	|-EqualityComparer<Font>.get_Default
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x2E3E1C0 Offset: 0x2E3E2C1 VA: 0x2E3E1C0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.get_Default
	|
	|-RVA: 0x2E3EE10 Offset: 0x2E3EF11 VA: 0x2E3EE10
	|-EqualityComparer<JSONDeserialization.TaskField>.get_Default
	|
	|-RVA: 0x2E3F980 Offset: 0x2E3FA81 VA: 0x2E3F980
	|-EqualityComparer<BitVector32Int>.get_Default
	|
	|-RVA: 0x2E404C0 Offset: 0x2E405C1 VA: 0x2E404C0
	|-EqualityComparer<BuildItemData>.get_Default
	|
	|-RVA: 0x2E413B0 Offset: 0x2E414B1 VA: 0x2E413B0
	|-EqualityComparer<ButtonLinker.LinkObject>.get_Default
	|
	|-RVA: 0x2E41F20 Offset: 0x2E42021 VA: 0x2E41F20
	|-EqualityComparer<CharaCallTable.BustupTable>.get_Default
	|
	|-RVA: 0x2E42A90 Offset: 0x2E42B91 VA: 0x2E42A90
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.get_Default
	|
	|-RVA: 0x2E43620 Offset: 0x2E43721 VA: 0x2E43620
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x2E44190 Offset: 0x2E44291 VA: 0x2E44190
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x2E44CD0 Offset: 0x2E44DD1 VA: 0x2E44CD0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x2E45810 Offset: 0x2E45911 VA: 0x2E45810
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x2E464D0 Offset: 0x2E465D1 VA: 0x2E464D0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x2E471C0 Offset: 0x2E472C1 VA: 0x2E471C0
	|-EqualityComparer<CropDataTable>.get_Default
	|
	|-RVA: 0x2E47E20 Offset: 0x2E47F21 VA: 0x2E47E20
	|-EqualityComparer<DropItemParam>.get_Default
	|
	|-RVA: 0x2E48960 Offset: 0x2E48A61 VA: 0x2E48960
	|-EqualityComparer<EffectDataTable>.get_Default
	|
	|-RVA: 0x2E495B0 Offset: 0x2E496B1 VA: 0x2E495B0
	|-EqualityComparer<ErosionBrush.UndoStep>.get_Default
	|
	|-RVA: 0x2E4A200 Offset: 0x2E4A301 VA: 0x2E4A200
	|-EqualityComparer<EventCheckId>.get_Default
	|
	|-RVA: 0x2E4AE50 Offset: 0x2E4AF51 VA: 0x2E4AE50
	|-EqualityComparer<EventFlagProgressData>.get_Default
	|
	|-RVA: 0x2E4B9C0 Offset: 0x2E4BAC1 VA: 0x2E4B9C0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.get_Default
	|
	|-RVA: 0x2E4C720 Offset: 0x2E4C821 VA: 0x2E4C720
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.get_Default
	|
	|-RVA: 0x2E4D370 Offset: 0x2E4D471 VA: 0x2E4D370
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.get_Default
	|
	|-RVA: 0x2E4DF00 Offset: 0x2E4E001 VA: 0x2E4DF00
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.get_Default
	|
	|-RVA: 0x2E4EA70 Offset: 0x2E4EB71 VA: 0x2E4EA70
	|-EqualityComparer<FesNpcScoreData>.get_Default
	|
	|-RVA: 0x2E4F5E0 Offset: 0x2E4F6E1 VA: 0x2E4F5E0
	|-EqualityComparer<GimmickLayoutDataTable>.get_Default
	|
	|-RVA: 0x2E50120 Offset: 0x2E50221 VA: 0x2E50120
	|-EqualityComparer<MineTypeDataTable>.get_Default
	|
	|-RVA: 0x2E50E50 Offset: 0x2E50F51 VA: 0x2E50E50
	|-EqualityComparer<MiningDataTable>.get_Default
	|
	|-RVA: 0x2E519C0 Offset: 0x2E51AC1 VA: 0x2E519C0
	|-EqualityComparer<MiningPointSaveData>.get_Default
	|
	|-RVA: 0x2E526B0 Offset: 0x2E527B1 VA: 0x2E526B0
	|-EqualityComparer<MonsterDataTable>.get_Default
	|
	|-RVA: 0x2E53330 Offset: 0x2E53431 VA: 0x2E53330
	|-EqualityComparer<MonsterFootStepEventDataTable>.get_Default
	|
	|-RVA: 0x2E53FF0 Offset: 0x2E540F1 VA: 0x2E53FF0
	|-EqualityComparer<MonsterHutSaveData>.get_Default
	|
	|-RVA: 0x2E54CC0 Offset: 0x2E54DC1 VA: 0x2E54CC0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.get_Default
	|
	|-RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
	|-EqualityComparer<NPCActionData>.get_Default
	|
	|-RVA: 0x2E56560 Offset: 0x2E56661 VA: 0x2E56560
	|-EqualityComparer<NpcPlaceSchedule>.get_Default
	|
	|-RVA: 0x2E571B0 Offset: 0x2E572B1 VA: 0x2E571B0
	|-EqualityComparer<OrderLotterySaveParameter>.get_Default
	|
	|-RVA: 0x31FE270 Offset: 0x31FE371 VA: 0x31FE270
	|-EqualityComparer<OrderSaveData>.get_Default
	|
	|-RVA: 0x31FEF40 Offset: 0x31FF041 VA: 0x31FEF40
	|-EqualityComparer<OrderSaveParameter>.get_Default
	|
	|-RVA: 0x31FFB90 Offset: 0x31FFC91 VA: 0x31FFB90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3200700 Offset: 0x3200801 VA: 0x3200700
	|-EqualityComparer<Parameter>.get_Default
	|
	|-RVA: 0x3201380 Offset: 0x3201481 VA: 0x3201380
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.get_Default
	|
	|-RVA: 0x3201EF0 Offset: 0x3201FF1 VA: 0x3201EF0
	|-EqualityComparer<ShopCatalogPage>.get_Default
	|
	|-RVA: 0x3202A60 Offset: 0x3202B61 VA: 0x3202A60
	|-EqualityComparer<ShopNpcTalk>.get_Default
	|
	|-RVA: 0x3203720 Offset: 0x3203821 VA: 0x3203720
	|-EqualityComparer<SubtitleDataTable.Data>.get_Default
	|
	|-RVA: 0x32042B0 Offset: 0x32043B1 VA: 0x32042B0
	|-EqualityComparer<SubtitleDataTable.DataList>.get_Default
	|
	|-RVA: 0x3204DF0 Offset: 0x3204EF1 VA: 0x3204DF0
	|-EqualityComparer<SubtitleHudDataTable.Data>.get_Default
	|
	|-RVA: 0x3205980 Offset: 0x3205A81 VA: 0x3205980
	|-EqualityComparer<ProfilerFrame>.get_Default
	|
	|-RVA: 0x3206550 Offset: 0x3206651 VA: 0x3206550
	|-EqualityComparer<NumberControl.ValueRange>.get_Default
	|
	|-RVA: 0x32070C0 Offset: 0x32071C1 VA: 0x32070C0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.get_Default
	|
	|-RVA: 0x3207D10 Offset: 0x3207E11 VA: 0x3207D10
	|-EqualityComparer<Schedule>.get_Default
	|
	|-RVA: 0x3208960 Offset: 0x3208A61 VA: 0x3208960
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x32094D0 Offset: 0x32095D1 VA: 0x32094D0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.get_Default
	|
	|-RVA: 0x320A060 Offset: 0x320A161 VA: 0x320A060
	|-EqualityComparer<CurveSample>.get_Default
	|
	|-RVA: 0x320AE00 Offset: 0x320AF01 VA: 0x320AE00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x320B950 Offset: 0x320BA51 VA: 0x320B950
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x320C490 Offset: 0x320C591 VA: 0x320C490
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x320CFD0 Offset: 0x320D0D1 VA: 0x320CFD0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x320DB40 Offset: 0x320DC41 VA: 0x320DB40
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x320E680 Offset: 0x320E781 VA: 0x320E680
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x320F1F0 Offset: 0x320F2F1 VA: 0x320F1F0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x320FD30 Offset: 0x320FE31 VA: 0x320FD30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x32108A0 Offset: 0x32109A1 VA: 0x32108A0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x32113E0 Offset: 0x32114E1 VA: 0x32113E0
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3211F50 Offset: 0x3212051 VA: 0x3211F50
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3212AA0 Offset: 0x3212BA1 VA: 0x3212AA0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3213610 Offset: 0x3213711 VA: 0x3213610
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3214150 Offset: 0x3214251 VA: 0x3214150
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3214C90 Offset: 0x3214D91 VA: 0x3214C90
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x32157D0 Offset: 0x32158D1 VA: 0x32157D0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3216310 Offset: 0x3216411 VA: 0x3216310
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3216E80 Offset: 0x3216F81 VA: 0x3216E80
	|-EqualityComparer<Memory<object>>.get_Default
	|
	|-RVA: 0x32179F0 Offset: 0x3217AF1 VA: 0x32179F0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.get_Default
	|
	|-RVA: 0x32186E0 Offset: 0x32187E1 VA: 0x32186E0
	|-EqualityComparer<Nullable<Int32Enum>>.get_Default
	|
	|-RVA: 0x3219230 Offset: 0x3219331 VA: 0x3219230
	|-EqualityComparer<Nullable<Bounds>>.get_Default
	|
	|-RVA: 0x3219F20 Offset: 0x321A021 VA: 0x3219F20
	|-EqualityComparer<Nullable<BoundsInt>>.get_Default
	|
	|-RVA: 0x321AC10 Offset: 0x321AD11 VA: 0x321AC10
	|-EqualityComparer<Nullable<Color32>>.get_Default
	|
	|-RVA: 0x32C9420 Offset: 0x32C9521 VA: 0x32C9420
	|-EqualityComparer<Nullable<Color>>.get_Default
	|
	|-RVA: 0x32CA0A0 Offset: 0x32CA1A1 VA: 0x32CA0A0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.get_Default
	|
	|-RVA: 0x32CAC40 Offset: 0x32CAD41 VA: 0x32CAC40
	|-EqualityComparer<Nullable<GradientColorKey>>.get_Default
	|
	|-RVA: 0x32CB8C0 Offset: 0x32CB9C1 VA: 0x32CB8C0
	|-EqualityComparer<Nullable<Keyframe>>.get_Default
	|
	|-RVA: 0x32CC540 Offset: 0x32CC641 VA: 0x32CC540
	|-EqualityComparer<Nullable<LayerMask>>.get_Default
	|
	|-RVA: 0x32CD090 Offset: 0x32CD191 VA: 0x32CD090
	|-EqualityComparer<Nullable<Matrix4x4>>.get_Default
	|
	|-RVA: 0x32CDE90 Offset: 0x32CDF91 VA: 0x32CDE90
	|-EqualityComparer<Nullable<Quaternion>>.get_Default
	|
	|-RVA: 0x32CEB10 Offset: 0x32CEC11 VA: 0x32CEB10
	|-EqualityComparer<Nullable<RangeInt>>.get_Default
	|
	|-RVA: 0x32CF6B0 Offset: 0x32CF7B1 VA: 0x32CF6B0
	|-EqualityComparer<Nullable<Rect>>.get_Default
	|
	|-RVA: 0x32D0330 Offset: 0x32D0431 VA: 0x32D0330
	|-EqualityComparer<Nullable<RectInt>>.get_Default
	|
	|-RVA: 0x32D0FB0 Offset: 0x32D10B1 VA: 0x32D0FB0
	|-EqualityComparer<Nullable<Vector2>>.get_Default
	|
	|-RVA: 0x32D1B50 Offset: 0x32D1C51 VA: 0x32D1B50
	|-EqualityComparer<Nullable<Vector2Int>>.get_Default
	|
	|-RVA: 0x32D26F0 Offset: 0x32D27F1 VA: 0x32D26F0
	|-EqualityComparer<Nullable<Vector3>>.get_Default
	|
	|-RVA: 0x32D3260 Offset: 0x32D3361 VA: 0x32D3260
	|-EqualityComparer<Nullable<Vector3Int>>.get_Default
	|
	|-RVA: 0x32D3DD0 Offset: 0x32D3ED1 VA: 0x32D3DD0
	|-EqualityComparer<Nullable<Vector4>>.get_Default
	|
	|-RVA: 0x32D5570 Offset: 0x32D5671 VA: 0x32D5570
	|-EqualityComparer<ReadOnlyMemory<object>>.get_Default
	|
	|-RVA: 0x32D60E0 Offset: 0x32D61E1 VA: 0x32D60E0
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x32D6C20 Offset: 0x32D6D21 VA: 0x32D6C20
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x32D7790 Offset: 0x32D7891 VA: 0x32D7790
	|-EqualityComparer<RuntimeTypeHandle>.get_Default
	|
	|-RVA: 0x32D82D0 Offset: 0x32D83D1 VA: 0x32D82D0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x32D8E10 Offset: 0x32D8F11 VA: 0x32D8E10
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x32D9960 Offset: 0x32D9A61 VA: 0x32D9960
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x32DA4A0 Offset: 0x32DA5A1 VA: 0x32DA4A0
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x32DAFE0 Offset: 0x32DB0E1 VA: 0x32DAFE0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DC660 Offset: 0x32DC761 VA: 0x32DC660
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x32DD1A0 Offset: 0x32DD2A1 VA: 0x32DD1A0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x32DDD10 Offset: 0x32DDE11 VA: 0x32DDD10
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.get_Default
	|
	|-RVA: 0x32DE880 Offset: 0x32DE981 VA: 0x32DE880
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x32DF3F0 Offset: 0x32DF4F1 VA: 0x32DF3F0
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x32DFF60 Offset: 0x32E0061 VA: 0x32DFF60
	|-EqualityComparer<ValueTuple<float, float>>.get_Default
	|
	|-RVA: 0x32E0AD0 Offset: 0x32E0BD1 VA: 0x32E0AD0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Default
	|
	|-RVA: 0x32E1660 Offset: 0x32E1761 VA: 0x32E1660
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Default
	|
	|-RVA: 0x32E2390 Offset: 0x32E2491 VA: 0x32E2390
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x32E30C0 Offset: 0x32E31C1 VA: 0x32E30C0
	|-EqualityComparer<TransitionTables>.get_Default
	|
	|-RVA: 0x32E3D10 Offset: 0x32E3E11 VA: 0x32E3D10
	|-EqualityComparer<TutorialUnlockFlagData>.get_Default
	|
	|-RVA: 0x32E48A0 Offset: 0x32E49A1 VA: 0x32E48A0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.get_Default
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-EqualityComparer<CapEdge>.get_Default
	|
	|-RVA: 0x30F14B0 Offset: 0x30F15B1 VA: 0x30F14B0
	|-EqualityComparer<ClippedEdge>.get_Default
	|
	|-RVA: 0x30F2100 Offset: 0x30F2201 VA: 0x30F2100
	|-EqualityComparer<EdgeKeyByHash>.get_Default
	|
	|-RVA: 0x30F2C40 Offset: 0x30F2D41 VA: 0x30F2C40
	|-EqualityComparer<EdgeKeyByIndex>.get_Default
	|
	|-RVA: 0x30F3780 Offset: 0x30F3881 VA: 0x30F3780
	|-EqualityComparer<MeshDataConnectivity.Face>.get_Default
	|
	|-RVA: 0x30F42C0 Offset: 0x30F43C1 VA: 0x30F42C0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.get_Default
	|
	|-RVA: 0x30F4F10 Offset: 0x30F5011 VA: 0x30F4F10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.get_Default
	|
	|-RVA: 0x30F5BD0 Offset: 0x30F5CD1 VA: 0x30F5BD0
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x30F6740 Offset: 0x30F6841 VA: 0x30F6740
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x30F75C0 Offset: 0x30F76C1 VA: 0x30F75C0
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x30F8130 Offset: 0x30F8231 VA: 0x30F8130
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x30F8C70 Offset: 0x30F8D71 VA: 0x30F8C70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x30F97E0 Offset: 0x30F98E1 VA: 0x30F97E0
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x30FA430 Offset: 0x30FA531 VA: 0x30FA430
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x30FB080 Offset: 0x30FB181 VA: 0x30FB080
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x30FBCD0 Offset: 0x30FBDD1 VA: 0x30FBCD0
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x30FC810 Offset: 0x30FC911 VA: 0x30FC810
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x30FD3E0 Offset: 0x30FD4E1 VA: 0x30FD3E0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x30FE260 Offset: 0x30FE361 VA: 0x30FE260
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x30FF000 Offset: 0x30FF101 VA: 0x30FF000
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	|
	|-RVA: 0x30FFB40 Offset: 0x30FFC41 VA: 0x30FFB40
	|-EqualityComparer<GradientAlphaKey>.get_Default
	|
	|-RVA: 0x31006B0 Offset: 0x31007B1 VA: 0x31006B0
	|-EqualityComparer<GradientColorKey>.get_Default
	|
	|-RVA: 0x3101300 Offset: 0x3101401 VA: 0x3101300
	|-EqualityComparer<Keyframe>.get_Default
	|
	|-RVA: 0x3101FC0 Offset: 0x31020C1 VA: 0x3101FC0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3102B00 Offset: 0x3102C01 VA: 0x3102B00
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x31044B0 Offset: 0x31045B1 VA: 0x31044B0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3105020 Offset: 0x3105121 VA: 0x3105020
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3105C70 Offset: 0x3105D71 VA: 0x3105C70
	|-EqualityComparer<PlayableGraph>.get_Default
	|
	|-RVA: 0x31067E0 Offset: 0x31068E1 VA: 0x31067E0
	|-EqualityComparer<Edge>.get_Default
	|
	|-RVA: 0x3107320 Offset: 0x3107421 VA: 0x3107320
	|-EqualityComparer<IntVec3>.get_Default
	|
	|-RVA: 0x3107EF0 Offset: 0x3107FF1 VA: 0x3107EF0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3108AC0 Offset: 0x3108BC1 VA: 0x3108AC0
	|-EqualityComparer<RangeInt>.get_Default
	|
	|-RVA: 0x3109600 Offset: 0x3109701 VA: 0x3109600
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x310A2F0 Offset: 0x310A3F1 VA: 0x310A2F0
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x310B020 Offset: 0x310B121 VA: 0x310B020
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x310BBF0 Offset: 0x310BCF1 VA: 0x310BBF0
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x310C760 Offset: 0x310C861 VA: 0x310C760
	|-EqualityComparer<ReflectionProbeBlendInfo>.get_Default
	|
	|-RVA: 0x310D2D0 Offset: 0x310D3D1 VA: 0x310D2D0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x310E1D0 Offset: 0x310E2D1 VA: 0x310E1D0
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x310ED40 Offset: 0x310EE41 VA: 0x310ED40
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x2EA70A0 Offset: 0x2EA71A1 VA: 0x2EA70A0
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x2EA7CF0 Offset: 0x2EA7DF1 VA: 0x2EA7CF0
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.get_Default
	|
	|-RVA: 0x2EA8940 Offset: 0x2EA8A41 VA: 0x2EA8940
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x2EA9600 Offset: 0x2EA9701 VA: 0x2EA9600
	|-EqualityComparer<SceneInstance>.get_Default
	|
	|-RVA: 0x2EAA170 Offset: 0x2EAA271 VA: 0x2EAA170
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x2EAADC0 Offset: 0x2EAAEC1 VA: 0x2EAADC0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x2EABA80 Offset: 0x2EABB81 VA: 0x2EABA80
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x2EAC5F0 Offset: 0x2EAC6F1 VA: 0x2EAC5F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x2EAD2C0 Offset: 0x2EAD3C1 VA: 0x2EAD2C0
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x2EADF10 Offset: 0x2EAE011 VA: 0x2EADF10
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x2EAEB60 Offset: 0x2EAEC61 VA: 0x2EAEB60
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x2EAF7B0 Offset: 0x2EAF8B1 VA: 0x2EAF7B0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x2EB05C0 Offset: 0x2EB06C1 VA: 0x2EB05C0
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x2EB1290 Offset: 0x2EB1391 VA: 0x2EB1290
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x2EB1EE0 Offset: 0x2EB1FE1 VA: 0x2EB1EE0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x2EB2AB0 Offset: 0x2EB2BB1 VA: 0x2EB2AB0
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x2EB3620 Offset: 0x2EB3721 VA: 0x2EB3620
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x2EB4190 Offset: 0x2EB4291 VA: 0x2EB4190
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x2EB4CD0 Offset: 0x2EB4DD1 VA: 0x2EB4CD0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x2EB5840 Offset: 0x2EB5941 VA: 0x2EB5840
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x2EB6650 Offset: 0x2EB6751 VA: 0x2EB6650
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2EB72A0 Offset: 0x2EB73A1 VA: 0x2EB72A0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x2EB7E10 Offset: 0x2EB7F11 VA: 0x2EB7E10
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x2EB8950 Offset: 0x2EB8A51 VA: 0x2EB8950
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x2EBA0B0 Offset: 0x2EBA1B1 VA: 0x2EBA0B0
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-EqualityComparer<WarpPoints.WarpPoint>.get_Default
	|
	|-RVA: 0x2EBBB70 Offset: 0x2EBBC71 VA: 0x2EBBB70
	|-EqualityComparer<YieldItemParam>.get_Default
	|
	|-RVA: 0x2EBC6B0 Offset: 0x2EBC7B1 VA: 0x2EBC6B0
	|-EqualityComparer<stCommand_t>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E2D0 Offset: 0x2E3E3D1 VA: 0x2E3E2D0
	|-EqualityComparer<AS_ToolController.ChargeInfo>.CreateComparer
	|
	|-RVA: 0x2E3EF20 Offset: 0x2E3F021 VA: 0x2E3EF20
	|-EqualityComparer<JSONDeserialization.TaskField>.CreateComparer
	|
	|-RVA: 0x2E3FA90 Offset: 0x2E3FB91 VA: 0x2E3FA90
	|-EqualityComparer<BitVector32Int>.CreateComparer
	|
	|-RVA: 0x2E405D0 Offset: 0x2E406D1 VA: 0x2E405D0
	|-EqualityComparer<BuildItemData>.CreateComparer
	|
	|-RVA: 0x2E414C0 Offset: 0x2E415C1 VA: 0x2E414C0
	|-EqualityComparer<ButtonLinker.LinkObject>.CreateComparer
	|
	|-RVA: 0x2E42030 Offset: 0x2E42131 VA: 0x2E42030
	|-EqualityComparer<CharaCallTable.BustupTable>.CreateComparer
	|
	|-RVA: 0x2E42BA0 Offset: 0x2E42CA1 VA: 0x2E42BA0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.CreateComparer
	|
	|-RVA: 0x2E43730 Offset: 0x2E43831 VA: 0x2E43730
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x2E465E0 Offset: 0x2E466E1 VA: 0x2E465E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x2E472D0 Offset: 0x2E473D1 VA: 0x2E472D0
	|-EqualityComparer<CropDataTable>.CreateComparer
	|
	|-RVA: 0x2E47F30 Offset: 0x2E48031 VA: 0x2E47F30
	|-EqualityComparer<DropItemParam>.CreateComparer
	|
	|-RVA: 0x2E48A70 Offset: 0x2E48B71 VA: 0x2E48A70
	|-EqualityComparer<EffectDataTable>.CreateComparer
	|
	|-RVA: 0x2E496C0 Offset: 0x2E497C1 VA: 0x2E496C0
	|-EqualityComparer<ErosionBrush.UndoStep>.CreateComparer
	|
	|-RVA: 0x2E4A310 Offset: 0x2E4A411 VA: 0x2E4A310
	|-EqualityComparer<EventCheckId>.CreateComparer
	|
	|-RVA: 0x2E4AF60 Offset: 0x2E4B061 VA: 0x2E4AF60
	|-EqualityComparer<EventFlagProgressData>.CreateComparer
	|
	|-RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.CreateComparer
	|
	|-RVA: 0x2E4C830 Offset: 0x2E4C931 VA: 0x2E4C830
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.CreateComparer
	|
	|-RVA: 0x2E4D480 Offset: 0x2E4D581 VA: 0x2E4D480
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.CreateComparer
	|
	|-RVA: 0x2E4E010 Offset: 0x2E4E111 VA: 0x2E4E010
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.CreateComparer
	|
	|-RVA: 0x2E4EB80 Offset: 0x2E4EC81 VA: 0x2E4EB80
	|-EqualityComparer<FesNpcScoreData>.CreateComparer
	|
	|-RVA: 0x2E4F6F0 Offset: 0x2E4F7F1 VA: 0x2E4F6F0
	|-EqualityComparer<GimmickLayoutDataTable>.CreateComparer
	|
	|-RVA: 0x2E50230 Offset: 0x2E50331 VA: 0x2E50230
	|-EqualityComparer<MineTypeDataTable>.CreateComparer
	|
	|-RVA: 0x2E50F60 Offset: 0x2E51061 VA: 0x2E50F60
	|-EqualityComparer<MiningDataTable>.CreateComparer
	|
	|-RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0
	|-EqualityComparer<MiningPointSaveData>.CreateComparer
	|
	|-RVA: 0x2E527C0 Offset: 0x2E528C1 VA: 0x2E527C0
	|-EqualityComparer<MonsterDataTable>.CreateComparer
	|
	|-RVA: 0x2E53440 Offset: 0x2E53541 VA: 0x2E53440
	|-EqualityComparer<MonsterFootStepEventDataTable>.CreateComparer
	|
	|-RVA: 0x2E54100 Offset: 0x2E54201 VA: 0x2E54100
	|-EqualityComparer<MonsterHutSaveData>.CreateComparer
	|
	|-RVA: 0x2E54DD0 Offset: 0x2E54ED1 VA: 0x2E54DD0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.CreateComparer
	|
	|-RVA: 0x2E55940 Offset: 0x2E55A41 VA: 0x2E55940
	|-EqualityComparer<NPCActionData>.CreateComparer
	|
	|-RVA: 0x2E56670 Offset: 0x2E56771 VA: 0x2E56670
	|-EqualityComparer<NpcPlaceSchedule>.CreateComparer
	|
	|-RVA: 0x2E572C0 Offset: 0x2E573C1 VA: 0x2E572C0
	|-EqualityComparer<OrderLotterySaveParameter>.CreateComparer
	|
	|-RVA: 0x31FE380 Offset: 0x31FE481 VA: 0x31FE380
	|-EqualityComparer<OrderSaveData>.CreateComparer
	|
	|-RVA: 0x31FF050 Offset: 0x31FF151 VA: 0x31FF050
	|-EqualityComparer<OrderSaveParameter>.CreateComparer
	|
	|-RVA: 0x31FFCA0 Offset: 0x31FFDA1 VA: 0x31FFCA0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3200810 Offset: 0x3200911 VA: 0x3200810
	|-EqualityComparer<Parameter>.CreateComparer
	|
	|-RVA: 0x3201490 Offset: 0x3201591 VA: 0x3201490
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.CreateComparer
	|
	|-RVA: 0x3202000 Offset: 0x3202101 VA: 0x3202000
	|-EqualityComparer<ShopCatalogPage>.CreateComparer
	|
	|-RVA: 0x3202B70 Offset: 0x3202C71 VA: 0x3202B70
	|-EqualityComparer<ShopNpcTalk>.CreateComparer
	|
	|-RVA: 0x3203830 Offset: 0x3203931 VA: 0x3203830
	|-EqualityComparer<SubtitleDataTable.Data>.CreateComparer
	|
	|-RVA: 0x32043C0 Offset: 0x32044C1 VA: 0x32043C0
	|-EqualityComparer<SubtitleDataTable.DataList>.CreateComparer
	|
	|-RVA: 0x3204F00 Offset: 0x3205001 VA: 0x3204F00
	|-EqualityComparer<SubtitleHudDataTable.Data>.CreateComparer
	|
	|-RVA: 0x3205A90 Offset: 0x3205B91 VA: 0x3205A90
	|-EqualityComparer<ProfilerFrame>.CreateComparer
	|
	|-RVA: 0x3206660 Offset: 0x3206761 VA: 0x3206660
	|-EqualityComparer<NumberControl.ValueRange>.CreateComparer
	|
	|-RVA: 0x32071D0 Offset: 0x32072D1 VA: 0x32071D0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.CreateComparer
	|
	|-RVA: 0x3207E20 Offset: 0x3207F21 VA: 0x3207E20
	|-EqualityComparer<Schedule>.CreateComparer
	|
	|-RVA: 0x3208A70 Offset: 0x3208B71 VA: 0x3208A70
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x32095E0 Offset: 0x32096E1 VA: 0x32095E0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.CreateComparer
	|
	|-RVA: 0x320A170 Offset: 0x320A271 VA: 0x320A170
	|-EqualityComparer<CurveSample>.CreateComparer
	|
	|-RVA: 0x320AF10 Offset: 0x320B011 VA: 0x320AF10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x320BA60 Offset: 0x320BB61 VA: 0x320BA60
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x320C5A0 Offset: 0x320C6A1 VA: 0x320C5A0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x320D0E0 Offset: 0x320D1E1 VA: 0x320D0E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x320DC50 Offset: 0x320DD51 VA: 0x320DC50
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x320E790 Offset: 0x320E891 VA: 0x320E790
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x320F300 Offset: 0x320F401 VA: 0x320F300
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x320FE40 Offset: 0x320FF41 VA: 0x320FE40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x32109B0 Offset: 0x3210AB1 VA: 0x32109B0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x32114F0 Offset: 0x32115F1 VA: 0x32114F0
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3212060 Offset: 0x3212161 VA: 0x3212060
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3212BB0 Offset: 0x3212CB1 VA: 0x3212BB0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3213720 Offset: 0x3213821 VA: 0x3213720
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3214260 Offset: 0x3214361 VA: 0x3214260
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3214DA0 Offset: 0x3214EA1 VA: 0x3214DA0
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x32158E0 Offset: 0x32159E1 VA: 0x32158E0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3216420 Offset: 0x3216521 VA: 0x3216420
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3216F90 Offset: 0x3217091 VA: 0x3216F90
	|-EqualityComparer<Memory<object>>.CreateComparer
	|
	|-RVA: 0x3217B00 Offset: 0x3217C01 VA: 0x3217B00
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.CreateComparer
	|
	|-RVA: 0x32187F0 Offset: 0x32188F1 VA: 0x32187F0
	|-EqualityComparer<Nullable<Int32Enum>>.CreateComparer
	|
	|-RVA: 0x3219340 Offset: 0x3219441 VA: 0x3219340
	|-EqualityComparer<Nullable<Bounds>>.CreateComparer
	|
	|-RVA: 0x321A030 Offset: 0x321A131 VA: 0x321A030
	|-EqualityComparer<Nullable<BoundsInt>>.CreateComparer
	|
	|-RVA: 0x321AD20 Offset: 0x321AE21 VA: 0x321AD20
	|-EqualityComparer<Nullable<Color32>>.CreateComparer
	|
	|-RVA: 0x32C9530 Offset: 0x32C9631 VA: 0x32C9530
	|-EqualityComparer<Nullable<Color>>.CreateComparer
	|
	|-RVA: 0x32CA1B0 Offset: 0x32CA2B1 VA: 0x32CA1B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.CreateComparer
	|
	|-RVA: 0x32CAD50 Offset: 0x32CAE51 VA: 0x32CAD50
	|-EqualityComparer<Nullable<GradientColorKey>>.CreateComparer
	|
	|-RVA: 0x32CB9D0 Offset: 0x32CBAD1 VA: 0x32CB9D0
	|-EqualityComparer<Nullable<Keyframe>>.CreateComparer
	|
	|-RVA: 0x32CC650 Offset: 0x32CC751 VA: 0x32CC650
	|-EqualityComparer<Nullable<LayerMask>>.CreateComparer
	|
	|-RVA: 0x32CD1A0 Offset: 0x32CD2A1 VA: 0x32CD1A0
	|-EqualityComparer<Nullable<Matrix4x4>>.CreateComparer
	|
	|-RVA: 0x32CDFA0 Offset: 0x32CE0A1 VA: 0x32CDFA0
	|-EqualityComparer<Nullable<Quaternion>>.CreateComparer
	|
	|-RVA: 0x32CEC20 Offset: 0x32CED21 VA: 0x32CEC20
	|-EqualityComparer<Nullable<RangeInt>>.CreateComparer
	|
	|-RVA: 0x32CF7C0 Offset: 0x32CF8C1 VA: 0x32CF7C0
	|-EqualityComparer<Nullable<Rect>>.CreateComparer
	|
	|-RVA: 0x32D0440 Offset: 0x32D0541 VA: 0x32D0440
	|-EqualityComparer<Nullable<RectInt>>.CreateComparer
	|
	|-RVA: 0x32D10C0 Offset: 0x32D11C1 VA: 0x32D10C0
	|-EqualityComparer<Nullable<Vector2>>.CreateComparer
	|
	|-RVA: 0x32D1C60 Offset: 0x32D1D61 VA: 0x32D1C60
	|-EqualityComparer<Nullable<Vector2Int>>.CreateComparer
	|
	|-RVA: 0x32D2800 Offset: 0x32D2901 VA: 0x32D2800
	|-EqualityComparer<Nullable<Vector3>>.CreateComparer
	|
	|-RVA: 0x32D3370 Offset: 0x32D3471 VA: 0x32D3370
	|-EqualityComparer<Nullable<Vector3Int>>.CreateComparer
	|
	|-RVA: 0x32D3EE0 Offset: 0x32D3FE1 VA: 0x32D3EE0
	|-EqualityComparer<Nullable<Vector4>>.CreateComparer
	|
	|-RVA: 0x32D4B60 Offset: 0x32D4C61 VA: 0x32D4B60
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x32D5680 Offset: 0x32D5781 VA: 0x32D5680
	|-EqualityComparer<ReadOnlyMemory<object>>.CreateComparer
	|
	|-RVA: 0x32D61F0 Offset: 0x32D62F1 VA: 0x32D61F0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x32D6D30 Offset: 0x32D6E31 VA: 0x32D6D30
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x32D78A0 Offset: 0x32D79A1 VA: 0x32D78A0
	|-EqualityComparer<RuntimeTypeHandle>.CreateComparer
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x32D8F20 Offset: 0x32D9021 VA: 0x32D8F20
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x32D9A70 Offset: 0x32D9B71 VA: 0x32D9A70
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x32DB0F0 Offset: 0x32DB1F1 VA: 0x32DB0F0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x32DBC30 Offset: 0x32DBD31 VA: 0x32DBC30
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DC770 Offset: 0x32DC871 VA: 0x32DC770
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x32DD2B0 Offset: 0x32DD3B1 VA: 0x32DD2B0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x32DDE20 Offset: 0x32DDF21 VA: 0x32DDE20
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32DE990 Offset: 0x32DEA91 VA: 0x32DE990
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x32DF500 Offset: 0x32DF601 VA: 0x32DF500
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x32E0070 Offset: 0x32E0171 VA: 0x32E0070
	|-EqualityComparer<ValueTuple<float, float>>.CreateComparer
	|
	|-RVA: 0x32E0BE0 Offset: 0x32E0CE1 VA: 0x32E0BE0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CreateComparer
	|
	|-RVA: 0x32E1770 Offset: 0x32E1871 VA: 0x32E1770
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CreateComparer
	|
	|-RVA: 0x32E24A0 Offset: 0x32E25A1 VA: 0x32E24A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x32E31D0 Offset: 0x32E32D1 VA: 0x32E31D0
	|-EqualityComparer<TransitionTables>.CreateComparer
	|
	|-RVA: 0x32E3E20 Offset: 0x32E3F21 VA: 0x32E3E20
	|-EqualityComparer<TutorialUnlockFlagData>.CreateComparer
	|
	|-RVA: 0x32E49B0 Offset: 0x32E4AB1 VA: 0x32E49B0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.CreateComparer
	|
	|-RVA: 0x32E5520 Offset: 0x32E5621 VA: 0x32E5520
	|-EqualityComparer<CapEdge>.CreateComparer
	|
	|-RVA: 0x30F15C0 Offset: 0x30F16C1 VA: 0x30F15C0
	|-EqualityComparer<ClippedEdge>.CreateComparer
	|
	|-RVA: 0x30F2210 Offset: 0x30F2311 VA: 0x30F2210
	|-EqualityComparer<EdgeKeyByHash>.CreateComparer
	|
	|-RVA: 0x30F2D50 Offset: 0x30F2E51 VA: 0x30F2D50
	|-EqualityComparer<EdgeKeyByIndex>.CreateComparer
	|
	|-RVA: 0x30F3890 Offset: 0x30F3991 VA: 0x30F3890
	|-EqualityComparer<MeshDataConnectivity.Face>.CreateComparer
	|
	|-RVA: 0x30F43D0 Offset: 0x30F44D1 VA: 0x30F43D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.CreateComparer
	|
	|-RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.CreateComparer
	|
	|-RVA: 0x30F5CE0 Offset: 0x30F5DE1 VA: 0x30F5CE0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x30F6850 Offset: 0x30F6951 VA: 0x30F6850
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x30F76D0 Offset: 0x30F77D1 VA: 0x30F76D0
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x30F8240 Offset: 0x30F8341 VA: 0x30F8240
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x30F8D80 Offset: 0x30F8E81 VA: 0x30F8D80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x30FA540 Offset: 0x30FA641 VA: 0x30FA540
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x30FB190 Offset: 0x30FB291 VA: 0x30FB190
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x30FBDE0 Offset: 0x30FBEE1 VA: 0x30FBDE0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x30FC920 Offset: 0x30FCA21 VA: 0x30FC920
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x30FD4F0 Offset: 0x30FD5F1 VA: 0x30FD4F0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x30FE370 Offset: 0x30FE471 VA: 0x30FE370
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	|
	|-RVA: 0x30FFC50 Offset: 0x30FFD51 VA: 0x30FFC50
	|-EqualityComparer<GradientAlphaKey>.CreateComparer
	|
	|-RVA: 0x31007C0 Offset: 0x31008C1 VA: 0x31007C0
	|-EqualityComparer<GradientColorKey>.CreateComparer
	|
	|-RVA: 0x3101410 Offset: 0x3101511 VA: 0x3101410
	|-EqualityComparer<Keyframe>.CreateComparer
	|
	|-RVA: 0x31020D0 Offset: 0x31021D1 VA: 0x31020D0
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3102C10 Offset: 0x3102D11 VA: 0x3102C10
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3103940 Offset: 0x3103A41 VA: 0x3103940
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x31045C0 Offset: 0x31046C1 VA: 0x31045C0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3105130 Offset: 0x3105231 VA: 0x3105130
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3105D80 Offset: 0x3105E81 VA: 0x3105D80
	|-EqualityComparer<PlayableGraph>.CreateComparer
	|
	|-RVA: 0x31068F0 Offset: 0x31069F1 VA: 0x31068F0
	|-EqualityComparer<Edge>.CreateComparer
	|
	|-RVA: 0x3107430 Offset: 0x3107531 VA: 0x3107430
	|-EqualityComparer<IntVec3>.CreateComparer
	|
	|-RVA: 0x3108000 Offset: 0x3108101 VA: 0x3108000
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3108BD0 Offset: 0x3108CD1 VA: 0x3108BD0
	|-EqualityComparer<RangeInt>.CreateComparer
	|
	|-RVA: 0x3109710 Offset: 0x3109811 VA: 0x3109710
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x310A400 Offset: 0x310A501 VA: 0x310A400
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x310B130 Offset: 0x310B231 VA: 0x310B130
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x310BD00 Offset: 0x310BE01 VA: 0x310BD00
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x310C870 Offset: 0x310C971 VA: 0x310C870
	|-EqualityComparer<ReflectionProbeBlendInfo>.CreateComparer
	|
	|-RVA: 0x310D3E0 Offset: 0x310D4E1 VA: 0x310D3E0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x310E2E0 Offset: 0x310E3E1 VA: 0x310E2E0
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x310EE50 Offset: 0x310EF51 VA: 0x310EE50
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x2EA71B0 Offset: 0x2EA72B1 VA: 0x2EA71B0
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x2EA7E00 Offset: 0x2EA7F01 VA: 0x2EA7E00
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.CreateComparer
	|
	|-RVA: 0x2EA8A50 Offset: 0x2EA8B51 VA: 0x2EA8A50
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x2EA9710 Offset: 0x2EA9811 VA: 0x2EA9710
	|-EqualityComparer<SceneInstance>.CreateComparer
	|
	|-RVA: 0x2EAA280 Offset: 0x2EAA381 VA: 0x2EAA280
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x2EAAED0 Offset: 0x2EAAFD1 VA: 0x2EAAED0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x2EABB90 Offset: 0x2EABC91 VA: 0x2EABB90
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x2EAC700 Offset: 0x2EAC801 VA: 0x2EAC700
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x2EAD3D0 Offset: 0x2EAD4D1 VA: 0x2EAD3D0
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x2EAE020 Offset: 0x2EAE121 VA: 0x2EAE020
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x2EAEC70 Offset: 0x2EAED71 VA: 0x2EAEC70
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x2EAF8C0 Offset: 0x2EAF9C1 VA: 0x2EAF8C0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x2EB06D0 Offset: 0x2EB07D1 VA: 0x2EB06D0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x2EB13A0 Offset: 0x2EB14A1 VA: 0x2EB13A0
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x2EB1FF0 Offset: 0x2EB20F1 VA: 0x2EB1FF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x2EB2BC0 Offset: 0x2EB2CC1 VA: 0x2EB2BC0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x2EB3730 Offset: 0x2EB3831 VA: 0x2EB3730
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x2EB42A0 Offset: 0x2EB43A1 VA: 0x2EB42A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x2EB4DE0 Offset: 0x2EB4EE1 VA: 0x2EB4DE0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x2EB5950 Offset: 0x2EB5A51 VA: 0x2EB5950
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x2EB6760 Offset: 0x2EB6861 VA: 0x2EB6760
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2EB73B0 Offset: 0x2EB74B1 VA: 0x2EB73B0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2EB7F20 Offset: 0x2EB8021 VA: 0x2EB7F20
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x2EB8A60 Offset: 0x2EB8B61 VA: 0x2EB8A60
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2EB9630 Offset: 0x2EB9731 VA: 0x2EB9630
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x2EBA1C0 Offset: 0x2EBA2C1 VA: 0x2EBA1C0
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x2EBAD90 Offset: 0x2EBAE91 VA: 0x2EBAD90
	|-EqualityComparer<WarpPoints.WarpPoint>.CreateComparer
	|
	|-RVA: 0x2EBBC80 Offset: 0x2EBBD81 VA: 0x2EBBC80
	|-EqualityComparer<YieldItemParam>.CreateComparer
	|
	|-RVA: 0x2EBC7C0 Offset: 0x2EBC8C1 VA: 0x2EBC7C0
	|-EqualityComparer<stCommand_t>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3E910 Offset: 0x2E3EA11 VA: 0x2E3E910
	|-EqualityComparer<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2E3F560 Offset: 0x2E3F661 VA: 0x2E3F560
	|-EqualityComparer<JSONDeserialization.TaskField>.IndexOf
	|
	|-RVA: 0x2E400D0 Offset: 0x2E401D1 VA: 0x2E400D0
	|-EqualityComparer<BitVector32Int>.IndexOf
	|
	|-RVA: 0x2E40C10 Offset: 0x2E40D11 VA: 0x2E40C10
	|-EqualityComparer<BuildItemData>.IndexOf
	|
	|-RVA: 0x2E41B00 Offset: 0x2E41C01 VA: 0x2E41B00
	|-EqualityComparer<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2E42670 Offset: 0x2E42771 VA: 0x2E42670
	|-EqualityComparer<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2E431E0 Offset: 0x2E432E1 VA: 0x2E431E0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2E43D70 Offset: 0x2E43E71 VA: 0x2E43D70
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2E448E0 Offset: 0x2E449E1 VA: 0x2E448E0
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2E45420 Offset: 0x2E45521 VA: 0x2E45420
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2E45F60 Offset: 0x2E46061 VA: 0x2E45F60
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2E46C20 Offset: 0x2E46D21 VA: 0x2E46C20
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2E47910 Offset: 0x2E47A11 VA: 0x2E47910
	|-EqualityComparer<CropDataTable>.IndexOf
	|
	|-RVA: 0x2E48570 Offset: 0x2E48671 VA: 0x2E48570
	|-EqualityComparer<DropItemParam>.IndexOf
	|
	|-RVA: 0x2E490B0 Offset: 0x2E491B1 VA: 0x2E490B0
	|-EqualityComparer<EffectDataTable>.IndexOf
	|
	|-RVA: 0x2E49D00 Offset: 0x2E49E01 VA: 0x2E49D00
	|-EqualityComparer<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2E4A950 Offset: 0x2E4AA51 VA: 0x2E4A950
	|-EqualityComparer<EventCheckId>.IndexOf
	|
	|-RVA: 0x2E4B5A0 Offset: 0x2E4B6A1 VA: 0x2E4B5A0
	|-EqualityComparer<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2E4C110 Offset: 0x2E4C211 VA: 0x2E4C110
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.IndexOf
	|
	|-RVA: 0x2E4CE70 Offset: 0x2E4CF71 VA: 0x2E4CE70
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.IndexOf
	|
	|-RVA: 0x2E4DAC0 Offset: 0x2E4DBC1 VA: 0x2E4DAC0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.IndexOf
	|
	|-RVA: 0x2E4E650 Offset: 0x2E4E751 VA: 0x2E4E650
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.IndexOf
	|
	|-RVA: 0x2E4F1C0 Offset: 0x2E4F2C1 VA: 0x2E4F1C0
	|-EqualityComparer<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2E4FD30 Offset: 0x2E4FE31 VA: 0x2E4FD30
	|-EqualityComparer<GimmickLayoutDataTable>.IndexOf
	|
	|-RVA: 0x2E50870 Offset: 0x2E50971 VA: 0x2E50870
	|-EqualityComparer<MineTypeDataTable>.IndexOf
	|
	|-RVA: 0x2E515A0 Offset: 0x2E516A1 VA: 0x2E515A0
	|-EqualityComparer<MiningDataTable>.IndexOf
	|
	|-RVA: 0x2E52110 Offset: 0x2E52211 VA: 0x2E52110
	|-EqualityComparer<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2E52E00 Offset: 0x2E52F01 VA: 0x2E52E00
	|-EqualityComparer<MonsterDataTable>.IndexOf
	|
	|-RVA: 0x2E53A80 Offset: 0x2E53B81 VA: 0x2E53A80
	|-EqualityComparer<MonsterFootStepEventDataTable>.IndexOf
	|
	|-RVA: 0x2E54740 Offset: 0x2E54841 VA: 0x2E54740
	|-EqualityComparer<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2E55410 Offset: 0x2E55511 VA: 0x2E55410
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x2E55F80 Offset: 0x2E56081 VA: 0x2E55F80
	|-EqualityComparer<NPCActionData>.IndexOf
	|
	|-RVA: 0x2E56CB0 Offset: 0x2E56DB1 VA: 0x2E56CB0
	|-EqualityComparer<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	|-EqualityComparer<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31FE9C0 Offset: 0x31FEAC1 VA: 0x31FE9C0
	|-EqualityComparer<OrderSaveData>.IndexOf
	|
	|-RVA: 0x31FF690 Offset: 0x31FF791 VA: 0x31FF690
	|-EqualityComparer<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32002E0 Offset: 0x32003E1 VA: 0x32002E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3200E50 Offset: 0x3200F51 VA: 0x3200E50
	|-EqualityComparer<Parameter>.IndexOf
	|
	|-RVA: 0x3201AD0 Offset: 0x3201BD1 VA: 0x3201AD0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.IndexOf
	|
	|-RVA: 0x3202640 Offset: 0x3202741 VA: 0x3202640
	|-EqualityComparer<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32031B0 Offset: 0x32032B1 VA: 0x32031B0
	|-EqualityComparer<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x3203E70 Offset: 0x3203F71 VA: 0x3203E70
	|-EqualityComparer<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3204A00 Offset: 0x3204B01 VA: 0x3204A00
	|-EqualityComparer<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3205540 Offset: 0x3205641 VA: 0x3205540
	|-EqualityComparer<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32060D0 Offset: 0x32061D1 VA: 0x32060D0
	|-EqualityComparer<ProfilerFrame>.IndexOf
	|
	|-RVA: 0x3206CA0 Offset: 0x3206DA1 VA: 0x3206CA0
	|-EqualityComparer<NumberControl.ValueRange>.IndexOf
	|
	|-RVA: 0x3207810 Offset: 0x3207911 VA: 0x3207810
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x3208460 Offset: 0x3208561 VA: 0x3208460
	|-EqualityComparer<Schedule>.IndexOf
	|
	|-RVA: 0x32090B0 Offset: 0x32091B1 VA: 0x32090B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3209C20 Offset: 0x3209D21 VA: 0x3209C20
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.IndexOf
	|
	|-RVA: 0x320A7B0 Offset: 0x320A8B1 VA: 0x320A7B0
	|-EqualityComparer<CurveSample>.IndexOf
	|
	|-RVA: 0x320B550 Offset: 0x320B651 VA: 0x320B550
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x320C0A0 Offset: 0x320C1A1 VA: 0x320C0A0
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x320CBE0 Offset: 0x320CCE1 VA: 0x320CBE0
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x320D720 Offset: 0x320D821 VA: 0x320D720
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x320E290 Offset: 0x320E391 VA: 0x320E290
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x320EDD0 Offset: 0x320EED1 VA: 0x320EDD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x320F940 Offset: 0x320FA41 VA: 0x320F940
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3210480 Offset: 0x3210581 VA: 0x3210480
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3210FF0 Offset: 0x32110F1 VA: 0x3210FF0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3211B30 Offset: 0x3211C31 VA: 0x3211B30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x32126A0 Offset: 0x32127A1 VA: 0x32126A0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x32131F0 Offset: 0x32132F1 VA: 0x32131F0
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3213D60 Offset: 0x3213E61 VA: 0x3213D60
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x32148A0 Offset: 0x32149A1 VA: 0x32148A0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x32153E0 Offset: 0x32154E1 VA: 0x32153E0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3215F20 Offset: 0x3216021 VA: 0x3215F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3216A60 Offset: 0x3216B61 VA: 0x3216A60
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x32175D0 Offset: 0x32176D1 VA: 0x32175D0
	|-EqualityComparer<Memory<object>>.IndexOf
	|
	|-RVA: 0x3218140 Offset: 0x3218241 VA: 0x3218140
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.IndexOf
	|
	|-RVA: 0x3218E30 Offset: 0x3218F31 VA: 0x3218E30
	|-EqualityComparer<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3219980 Offset: 0x3219A81 VA: 0x3219980
	|-EqualityComparer<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x321A670 Offset: 0x321A771 VA: 0x321A670
	|-EqualityComparer<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x321B360 Offset: 0x321B461 VA: 0x321B360
	|-EqualityComparer<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x32C9B70 Offset: 0x32C9C71 VA: 0x32C9B70
	|-EqualityComparer<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x32CA7F0 Offset: 0x32CA8F1 VA: 0x32CA7F0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x32CB390 Offset: 0x32CB491 VA: 0x32CB390
	|-EqualityComparer<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x32CC010 Offset: 0x32CC111 VA: 0x32CC010
	|-EqualityComparer<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x32CCC90 Offset: 0x32CCD91 VA: 0x32CCC90
	|-EqualityComparer<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x32CD7E0 Offset: 0x32CD8E1 VA: 0x32CD7E0
	|-EqualityComparer<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32CE5E0 Offset: 0x32CE6E1 VA: 0x32CE5E0
	|-EqualityComparer<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32CF260 Offset: 0x32CF361 VA: 0x32CF260
	|-EqualityComparer<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32CFE00 Offset: 0x32CFF01 VA: 0x32CFE00
	|-EqualityComparer<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x32D0A80 Offset: 0x32D0B81 VA: 0x32D0A80
	|-EqualityComparer<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x32D1700 Offset: 0x32D1801 VA: 0x32D1700
	|-EqualityComparer<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32D22A0 Offset: 0x32D23A1 VA: 0x32D22A0
	|-EqualityComparer<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32D2E40 Offset: 0x32D2F41 VA: 0x32D2E40
	|-EqualityComparer<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x32D39B0 Offset: 0x32D3AB1 VA: 0x32D39B0
	|-EqualityComparer<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-EqualityComparer<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x32D51A0 Offset: 0x32D52A1 VA: 0x32D51A0
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-EqualityComparer<ReadOnlyMemory<object>>.IndexOf
	|
	|-RVA: 0x32D6830 Offset: 0x32D6931 VA: 0x32D6830
	|-EqualityComparer<Label>.IndexOf
	|
	|-RVA: 0x32D7370 Offset: 0x32D7471 VA: 0x32D7370
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x32D7EE0 Offset: 0x32D7FE1 VA: 0x32D7EE0
	|-EqualityComparer<RuntimeTypeHandle>.IndexOf
	|
	|-RVA: 0x32D8A20 Offset: 0x32D8B21 VA: 0x32D8A20
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x32D9560 Offset: 0x32D9661 VA: 0x32D9560
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x32DA0B0 Offset: 0x32DA1B1 VA: 0x32DA0B0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x32DABF0 Offset: 0x32DACF1 VA: 0x32DABF0
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x32DB730 Offset: 0x32DB831 VA: 0x32DB730
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x32DC270 Offset: 0x32DC371 VA: 0x32DC270
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DCDB0 Offset: 0x32DCEB1 VA: 0x32DCDB0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32DD8F0 Offset: 0x32DD9F1 VA: 0x32DD8F0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32DE460 Offset: 0x32DE561 VA: 0x32DE460
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32DEFD0 Offset: 0x32DF0D1 VA: 0x32DEFD0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32DFB40 Offset: 0x32DFC41 VA: 0x32DFB40
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32E06B0 Offset: 0x32E07B1 VA: 0x32E06B0
	|-EqualityComparer<ValueTuple<float, float>>.IndexOf
	|
	|-RVA: 0x32E1220 Offset: 0x32E1321 VA: 0x32E1220
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32E1DB0 Offset: 0x32E1EB1 VA: 0x32E1DB0
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32E2AE0 Offset: 0x32E2BE1 VA: 0x32E2AE0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32E3810 Offset: 0x32E3911 VA: 0x32E3810
	|-EqualityComparer<TransitionTables>.IndexOf
	|
	|-RVA: 0x32E4460 Offset: 0x32E4561 VA: 0x32E4460
	|-EqualityComparer<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32E4FF0 Offset: 0x32E50F1 VA: 0x32E4FF0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32E5B60 Offset: 0x32E5C61 VA: 0x32E5B60
	|-EqualityComparer<CapEdge>.IndexOf
	|
	|-RVA: 0x30F1C00 Offset: 0x30F1D01 VA: 0x30F1C00
	|-EqualityComparer<ClippedEdge>.IndexOf
	|
	|-RVA: 0x30F2850 Offset: 0x30F2951 VA: 0x30F2850
	|-EqualityComparer<EdgeKeyByHash>.IndexOf
	|
	|-RVA: 0x30F3390 Offset: 0x30F3491 VA: 0x30F3390
	|-EqualityComparer<EdgeKeyByIndex>.IndexOf
	|
	|-RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	|-EqualityComparer<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x30F4A10 Offset: 0x30F4B11 VA: 0x30F4A10
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x30F5660 Offset: 0x30F5761 VA: 0x30F5660
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x30F6320 Offset: 0x30F6421 VA: 0x30F6320
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x30F6E90 Offset: 0x30F6F91 VA: 0x30F6E90
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x30F7D10 Offset: 0x30F7E11 VA: 0x30F7D10
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x30F8880 Offset: 0x30F8981 VA: 0x30F8880
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x30F93C0 Offset: 0x30F94C1 VA: 0x30F93C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x30F9F30 Offset: 0x30FA031 VA: 0x30F9F30
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x30FAB80 Offset: 0x30FAC81 VA: 0x30FAB80
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x30FB7D0 Offset: 0x30FB8D1 VA: 0x30FB7D0
	|-EqualityComparer<BoundsInt>.IndexOf
	|
	|-RVA: 0x30FC420 Offset: 0x30FC521 VA: 0x30FC420
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x30FCF60 Offset: 0x30FD061 VA: 0x30FCF60
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x30FDB30 Offset: 0x30FDC31 VA: 0x30FDB30
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x30FE9B0 Offset: 0x30FEAB1 VA: 0x30FE9B0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x30FF750 Offset: 0x30FF851 VA: 0x30FF750
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	|
	|-RVA: 0x3100290 Offset: 0x3100391 VA: 0x3100290
	|-EqualityComparer<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x3100E00 Offset: 0x3100F01 VA: 0x3100E00
	|-EqualityComparer<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3101A50 Offset: 0x3101B51 VA: 0x3101A50
	|-EqualityComparer<Keyframe>.IndexOf
	|
	|-RVA: 0x3102710 Offset: 0x3102811 VA: 0x3102710
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3103250 Offset: 0x3103351 VA: 0x3103250
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3103F80 Offset: 0x3104081 VA: 0x3103F80
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3104C00 Offset: 0x3104D01 VA: 0x3104C00
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3105770 Offset: 0x3105871 VA: 0x3105770
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x31063C0 Offset: 0x31064C1 VA: 0x31063C0
	|-EqualityComparer<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3106F30 Offset: 0x3107031 VA: 0x3106F30
	|-EqualityComparer<Edge>.IndexOf
	|
	|-RVA: 0x3107A70 Offset: 0x3107B71 VA: 0x3107A70
	|-EqualityComparer<IntVec3>.IndexOf
	|
	|-RVA: 0x3108640 Offset: 0x3108741 VA: 0x3108640
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3109210 Offset: 0x3109311 VA: 0x3109210
	|-EqualityComparer<RangeInt>.IndexOf
	|
	|-RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x310AA40 Offset: 0x310AB41 VA: 0x310AA40
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x310B770 Offset: 0x310B871 VA: 0x310B770
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x310C340 Offset: 0x310C441 VA: 0x310C340
	|-EqualityComparer<RectInt>.IndexOf
	|
	|-RVA: 0x310CEB0 Offset: 0x310CFB1 VA: 0x310CEB0
	|-EqualityComparer<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x310DA20 Offset: 0x310DB21 VA: 0x310DA20
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x310E920 Offset: 0x310EA21 VA: 0x310E920
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x310F490 Offset: 0x310F591 VA: 0x310F490
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x2EA77F0 Offset: 0x2EA78F1 VA: 0x2EA77F0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x2EA8440 Offset: 0x2EA8541 VA: 0x2EA8440
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x2EA9090 Offset: 0x2EA9191 VA: 0x2EA9090
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2EA9D50 Offset: 0x2EA9E51 VA: 0x2EA9D50
	|-EqualityComparer<SceneInstance>.IndexOf
	|
	|-RVA: 0x2EAA8C0 Offset: 0x2EAA9C1 VA: 0x2EAA8C0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2EAB510 Offset: 0x2EAB611 VA: 0x2EAB510
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2EAC1D0 Offset: 0x2EAC2D1 VA: 0x2EAC1D0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x2EACD40 Offset: 0x2EACE41 VA: 0x2EACD40
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2EADA10 Offset: 0x2EADB11 VA: 0x2EADA10
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2EAE660 Offset: 0x2EAE761 VA: 0x2EAE660
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2EAF2B0 Offset: 0x2EAF3B1 VA: 0x2EAF2B0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2EAFF00 Offset: 0x2EB0001 VA: 0x2EAFF00
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x2EB0D10 Offset: 0x2EB0E11 VA: 0x2EB0D10
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x2EB2630 Offset: 0x2EB2731 VA: 0x2EB2630
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x2EB3200 Offset: 0x2EB3301 VA: 0x2EB3200
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|
	|-RVA: 0x2EB3D70 Offset: 0x2EB3E71 VA: 0x2EB3D70
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2EB48E0 Offset: 0x2EB49E1 VA: 0x2EB48E0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|
	|-RVA: 0x2EB5420 Offset: 0x2EB5521 VA: 0x2EB5420
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x2EB5F90 Offset: 0x2EB6091 VA: 0x2EB5F90
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x2EB6DA0 Offset: 0x2EB6EA1 VA: 0x2EB6DA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2EB79F0 Offset: 0x2EB7AF1 VA: 0x2EB79F0
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2EB8560 Offset: 0x2EB8661 VA: 0x2EB8560
	|-EqualityComparer<Vector2Int>.IndexOf
	|
	|-RVA: 0x2EB90A0 Offset: 0x2EB91A1 VA: 0x2EB90A0
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2EB9C70 Offset: 0x2EB9D71 VA: 0x2EB9C70
	|-EqualityComparer<Vector3Int>.IndexOf
	|
	|-RVA: 0x2EBA800 Offset: 0x2EBA901 VA: 0x2EBA800
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2EBB3D0 Offset: 0x2EBB4D1 VA: 0x2EBB3D0
	|-EqualityComparer<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2EBC2C0 Offset: 0x2EBC3C1 VA: 0x2EBC2C0
	|-EqualityComparer<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2EBCE00 Offset: 0x2EBCF01 VA: 0x2EBCE00
	|-EqualityComparer<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EA30 Offset: 0x2E3EB31 VA: 0x2E3EA30
	|-EqualityComparer<AS_ToolController.ChargeInfo>.LastIndexOf
	|
	|-RVA: 0x2E3F630 Offset: 0x2E3F731 VA: 0x2E3F630
	|-EqualityComparer<JSONDeserialization.TaskField>.LastIndexOf
	|
	|-RVA: 0x2E40190 Offset: 0x2E40291 VA: 0x2E40190
	|-EqualityComparer<BitVector32Int>.LastIndexOf
	|
	|-RVA: 0x2E40DF0 Offset: 0x2E40EF1 VA: 0x2E40DF0
	|-EqualityComparer<BuildItemData>.LastIndexOf
	|
	|-RVA: 0x2E41BD0 Offset: 0x2E41CD1 VA: 0x2E41BD0
	|-EqualityComparer<ButtonLinker.LinkObject>.LastIndexOf
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-EqualityComparer<CharaCallTable.BustupTable>.LastIndexOf
	|
	|-RVA: 0x2E432C0 Offset: 0x2E433C1 VA: 0x2E432C0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.LastIndexOf
	|
	|-RVA: 0x2E43E40 Offset: 0x2E43F41 VA: 0x2E43E40
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x2E449A0 Offset: 0x2E44AA1 VA: 0x2E449A0
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x2E454E0 Offset: 0x2E455E1 VA: 0x2E454E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x2E460A0 Offset: 0x2E461A1 VA: 0x2E460A0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x2E46D70 Offset: 0x2E46E71 VA: 0x2E46D70
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x2E47A30 Offset: 0x2E47B31 VA: 0x2E47A30
	|-EqualityComparer<CropDataTable>.LastIndexOf
	|
	|-RVA: 0x2E48630 Offset: 0x2E48731 VA: 0x2E48630
	|-EqualityComparer<DropItemParam>.LastIndexOf
	|
	|-RVA: 0x2E491D0 Offset: 0x2E492D1 VA: 0x2E491D0
	|-EqualityComparer<EffectDataTable>.LastIndexOf
	|
	|-RVA: 0x2E49E20 Offset: 0x2E49F21 VA: 0x2E49E20
	|-EqualityComparer<ErosionBrush.UndoStep>.LastIndexOf
	|
	|-RVA: 0x2E4AA70 Offset: 0x2E4AB71 VA: 0x2E4AA70
	|-EqualityComparer<EventCheckId>.LastIndexOf
	|
	|-RVA: 0x2E4B670 Offset: 0x2E4B771 VA: 0x2E4B670
	|-EqualityComparer<EventFlagProgressData>.LastIndexOf
	|
	|-RVA: 0x2E4C280 Offset: 0x2E4C381 VA: 0x2E4C280
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.LastIndexOf
	|
	|-RVA: 0x2E4CF90 Offset: 0x2E4D091 VA: 0x2E4CF90
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4DBA0 Offset: 0x2E4DCA1 VA: 0x2E4DBA0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4E720 Offset: 0x2E4E821 VA: 0x2E4E720
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.LastIndexOf
	|
	|-RVA: 0x2E4F290 Offset: 0x2E4F391 VA: 0x2E4F290
	|-EqualityComparer<FesNpcScoreData>.LastIndexOf
	|
	|-RVA: 0x2E4FDF0 Offset: 0x2E4FEF1 VA: 0x2E4FDF0
	|-EqualityComparer<GimmickLayoutDataTable>.LastIndexOf
	|
	|-RVA: 0x2E509D0 Offset: 0x2E50AD1 VA: 0x2E509D0
	|-EqualityComparer<MineTypeDataTable>.LastIndexOf
	|
	|-RVA: 0x2E51670 Offset: 0x2E51771 VA: 0x2E51670
	|-EqualityComparer<MiningDataTable>.LastIndexOf
	|
	|-RVA: 0x2E52260 Offset: 0x2E52361 VA: 0x2E52260
	|-EqualityComparer<MiningPointSaveData>.LastIndexOf
	|
	|-RVA: 0x2E52F20 Offset: 0x2E53021 VA: 0x2E52F20
	|-EqualityComparer<MonsterDataTable>.LastIndexOf
	|
	|-RVA: 0x2E53BC0 Offset: 0x2E53CC1 VA: 0x2E53BC0
	|-EqualityComparer<MonsterFootStepEventDataTable>.LastIndexOf
	|
	|-RVA: 0x2E54880 Offset: 0x2E54981 VA: 0x2E54880
	|-EqualityComparer<MonsterHutSaveData>.LastIndexOf
	|
	|-RVA: 0x2E554E0 Offset: 0x2E555E1 VA: 0x2E554E0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.LastIndexOf
	|
	|-RVA: 0x2E560E0 Offset: 0x2E561E1 VA: 0x2E560E0
	|-EqualityComparer<NPCActionData>.LastIndexOf
	|
	|-RVA: 0x2E56DD0 Offset: 0x2E56ED1 VA: 0x2E56DD0
	|-EqualityComparer<NpcPlaceSchedule>.LastIndexOf
	|
	|-RVA: 0x2E579E0 Offset: 0x2E57AE1 VA: 0x2E579E0
	|-EqualityComparer<OrderLotterySaveParameter>.LastIndexOf
	|
	|-RVA: 0x31FEB00 Offset: 0x31FEC01 VA: 0x31FEB00
	|-EqualityComparer<OrderSaveData>.LastIndexOf
	|
	|-RVA: 0x31FF7B0 Offset: 0x31FF8B1 VA: 0x31FF7B0
	|-EqualityComparer<OrderSaveParameter>.LastIndexOf
	|
	|-RVA: 0x32003B0 Offset: 0x32004B1 VA: 0x32003B0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3200F70 Offset: 0x3201071 VA: 0x3200F70
	|-EqualityComparer<Parameter>.LastIndexOf
	|
	|-RVA: 0x3201BA0 Offset: 0x3201CA1 VA: 0x3201BA0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.LastIndexOf
	|
	|-RVA: 0x3202710 Offset: 0x3202811 VA: 0x3202710
	|-EqualityComparer<ShopCatalogPage>.LastIndexOf
	|
	|-RVA: 0x32032F0 Offset: 0x32033F1 VA: 0x32032F0
	|-EqualityComparer<ShopNpcTalk>.LastIndexOf
	|
	|-RVA: 0x3203F50 Offset: 0x3204051 VA: 0x3203F50
	|-EqualityComparer<SubtitleDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x3204AC0 Offset: 0x3204BC1 VA: 0x3204AC0
	|-EqualityComparer<SubtitleDataTable.DataList>.LastIndexOf
	|
	|-RVA: 0x3205620 Offset: 0x3205721 VA: 0x3205620
	|-EqualityComparer<SubtitleHudDataTable.Data>.LastIndexOf
	|
	|-RVA: 0x32061C0 Offset: 0x32062C1 VA: 0x32061C0
	|-EqualityComparer<ProfilerFrame>.LastIndexOf
	|
	|-RVA: 0x3206D70 Offset: 0x3206E71 VA: 0x3206D70
	|-EqualityComparer<NumberControl.ValueRange>.LastIndexOf
	|
	|-RVA: 0x3207930 Offset: 0x3207A31 VA: 0x3207930
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.LastIndexOf
	|
	|-RVA: 0x3208580 Offset: 0x3208681 VA: 0x3208580
	|-EqualityComparer<Schedule>.LastIndexOf
	|
	|-RVA: 0x3209180 Offset: 0x3209281 VA: 0x3209180
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3209D00 Offset: 0x3209E01 VA: 0x3209D00
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.LastIndexOf
	|
	|-RVA: 0x320A930 Offset: 0x320AA31 VA: 0x320A930
	|-EqualityComparer<CurveSample>.LastIndexOf
	|
	|-RVA: 0x320B610 Offset: 0x320B711 VA: 0x320B610
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x320C160 Offset: 0x320C261 VA: 0x320C160
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x320CCA0 Offset: 0x320CDA1 VA: 0x320CCA0
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x320D7F0 Offset: 0x320D8F1 VA: 0x320D7F0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x320E350 Offset: 0x320E451 VA: 0x320E350
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x320EEA0 Offset: 0x320EFA1 VA: 0x320EEA0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x320FA00 Offset: 0x320FB01 VA: 0x320FA00
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3210550 Offset: 0x3210651 VA: 0x3210550
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x32110B0 Offset: 0x32111B1 VA: 0x32110B0
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3211C00 Offset: 0x3211D01 VA: 0x3211C00
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3212760 Offset: 0x3212861 VA: 0x3212760
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x32132C0 Offset: 0x32133C1 VA: 0x32132C0
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3213E20 Offset: 0x3213F21 VA: 0x3213E20
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3214960 Offset: 0x3214A61 VA: 0x3214960
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x32154A0 Offset: 0x32155A1 VA: 0x32154A0
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3215FE0 Offset: 0x32160E1 VA: 0x3215FE0
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3216B30 Offset: 0x3216C31 VA: 0x3216B30
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x32176A0 Offset: 0x32177A1 VA: 0x32176A0
	|-EqualityComparer<Memory<object>>.LastIndexOf
	|
	|-RVA: 0x3218280 Offset: 0x3218381 VA: 0x3218280
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.LastIndexOf
	|
	|-RVA: 0x3218EF0 Offset: 0x3218FF1 VA: 0x3218EF0
	|-EqualityComparer<Nullable<Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x3219AC0 Offset: 0x3219BC1 VA: 0x3219AC0
	|-EqualityComparer<Nullable<Bounds>>.LastIndexOf
	|
	|-RVA: 0x321A7B0 Offset: 0x321A8B1 VA: 0x321A7B0
	|-EqualityComparer<Nullable<BoundsInt>>.LastIndexOf
	|
	|-RVA: 0x321B420 Offset: 0x321B521 VA: 0x321B420
	|-EqualityComparer<Nullable<Color32>>.LastIndexOf
	|
	|-RVA: 0x32C9C90 Offset: 0x32C9D91 VA: 0x32C9C90
	|-EqualityComparer<Nullable<Color>>.LastIndexOf
	|
	|-RVA: 0x32CA8D0 Offset: 0x32CA9D1 VA: 0x32CA8D0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.LastIndexOf
	|
	|-RVA: 0x32CB4B0 Offset: 0x32CB5B1 VA: 0x32CB4B0
	|-EqualityComparer<Nullable<GradientColorKey>>.LastIndexOf
	|
	|-RVA: 0x32CC130 Offset: 0x32CC231 VA: 0x32CC130
	|-EqualityComparer<Nullable<Keyframe>>.LastIndexOf
	|
	|-RVA: 0x32CCD50 Offset: 0x32CCE51 VA: 0x32CCD50
	|-EqualityComparer<Nullable<LayerMask>>.LastIndexOf
	|
	|-RVA: 0x32CD970 Offset: 0x32CDA71 VA: 0x32CD970
	|-EqualityComparer<Nullable<Matrix4x4>>.LastIndexOf
	|
	|-RVA: 0x32CE700 Offset: 0x32CE801 VA: 0x32CE700
	|-EqualityComparer<Nullable<Quaternion>>.LastIndexOf
	|
	|-RVA: 0x32CF340 Offset: 0x32CF441 VA: 0x32CF340
	|-EqualityComparer<Nullable<RangeInt>>.LastIndexOf
	|
	|-RVA: 0x32CFF20 Offset: 0x32D0021 VA: 0x32CFF20
	|-EqualityComparer<Nullable<Rect>>.LastIndexOf
	|
	|-RVA: 0x32D0BA0 Offset: 0x32D0CA1 VA: 0x32D0BA0
	|-EqualityComparer<Nullable<RectInt>>.LastIndexOf
	|
	|-RVA: 0x32D17E0 Offset: 0x32D18E1 VA: 0x32D17E0
	|-EqualityComparer<Nullable<Vector2>>.LastIndexOf
	|
	|-RVA: 0x32D2380 Offset: 0x32D2481 VA: 0x32D2380
	|-EqualityComparer<Nullable<Vector2Int>>.LastIndexOf
	|
	|-RVA: 0x32D2F10 Offset: 0x32D3011 VA: 0x32D2F10
	|-EqualityComparer<Nullable<Vector3>>.LastIndexOf
	|
	|-RVA: 0x32D3A80 Offset: 0x32D3B81 VA: 0x32D3A80
	|-EqualityComparer<Nullable<Vector3Int>>.LastIndexOf
	|
	|-RVA: 0x32D4640 Offset: 0x32D4741 VA: 0x32D4640
	|-EqualityComparer<Nullable<Vector4>>.LastIndexOf
	|
	|-RVA: 0x32D5260 Offset: 0x32D5361 VA: 0x32D5260
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x32D5D90 Offset: 0x32D5E91 VA: 0x32D5D90
	|-EqualityComparer<ReadOnlyMemory<object>>.LastIndexOf
	|
	|-RVA: 0x32D68F0 Offset: 0x32D69F1 VA: 0x32D68F0
	|-EqualityComparer<Label>.LastIndexOf
	|
	|-RVA: 0x32D7440 Offset: 0x32D7541 VA: 0x32D7440
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x32D7FA0 Offset: 0x32D80A1 VA: 0x32D7FA0
	|-EqualityComparer<RuntimeTypeHandle>.LastIndexOf
	|
	|-RVA: 0x32D8AE0 Offset: 0x32D8BE1 VA: 0x32D8AE0
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x32D9620 Offset: 0x32D9721 VA: 0x32D9620
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x32DACB0 Offset: 0x32DADB1 VA: 0x32DACB0
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x32DC330 Offset: 0x32DC431 VA: 0x32DC330
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DCE70 Offset: 0x32DCF71 VA: 0x32DCE70
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x32DD9C0 Offset: 0x32DDAC1 VA: 0x32DD9C0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x32DE530 Offset: 0x32DE631 VA: 0x32DE530
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32DF0A0 Offset: 0x32DF1A1 VA: 0x32DF0A0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x32DFC10 Offset: 0x32DFD11 VA: 0x32DFC10
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x32E0780 Offset: 0x32E0881 VA: 0x32E0780
	|-EqualityComparer<ValueTuple<float, float>>.LastIndexOf
	|
	|-RVA: 0x32E1300 Offset: 0x32E1401 VA: 0x32E1300
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.LastIndexOf
	|
	|-RVA: 0x32E1F10 Offset: 0x32E2011 VA: 0x32E1F10
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.LastIndexOf
	|
	|-RVA: 0x32E2C40 Offset: 0x32E2D41 VA: 0x32E2C40
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-EqualityComparer<TransitionTables>.LastIndexOf
	|
	|-RVA: 0x32E4540 Offset: 0x32E4641 VA: 0x32E4540
	|-EqualityComparer<TutorialUnlockFlagData>.LastIndexOf
	|
	|-RVA: 0x32E50C0 Offset: 0x32E51C1 VA: 0x32E50C0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.LastIndexOf
	|
	|-RVA: 0x32E5CB0 Offset: 0x32E5DB1 VA: 0x32E5CB0
	|-EqualityComparer<CapEdge>.LastIndexOf
	|
	|-RVA: 0x30F1D20 Offset: 0x30F1E21 VA: 0x30F1D20
	|-EqualityComparer<ClippedEdge>.LastIndexOf
	|
	|-RVA: 0x30F2910 Offset: 0x30F2A11 VA: 0x30F2910
	|-EqualityComparer<EdgeKeyByHash>.LastIndexOf
	|
	|-RVA: 0x30F3450 Offset: 0x30F3551 VA: 0x30F3450
	|-EqualityComparer<EdgeKeyByIndex>.LastIndexOf
	|
	|-RVA: 0x30F3F90 Offset: 0x30F4091 VA: 0x30F3F90
	|-EqualityComparer<MeshDataConnectivity.Face>.LastIndexOf
	|
	|-RVA: 0x30F4B30 Offset: 0x30F4C31 VA: 0x30F4B30
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.LastIndexOf
	|
	|-RVA: 0x30F57A0 Offset: 0x30F58A1 VA: 0x30F57A0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.LastIndexOf
	|
	|-RVA: 0x30F63F0 Offset: 0x30F64F1 VA: 0x30F63F0
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|
	|-RVA: 0x30F7050 Offset: 0x30F7151 VA: 0x30F7050
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|
	|-RVA: 0x30F7DE0 Offset: 0x30F7EE1 VA: 0x30F7DE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x30F8940 Offset: 0x30F8A41 VA: 0x30F8940
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x30F9490 Offset: 0x30F9591 VA: 0x30F9490
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x30FA050 Offset: 0x30FA151 VA: 0x30FA050
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x30FACA0 Offset: 0x30FADA1 VA: 0x30FACA0
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x30FB8F0 Offset: 0x30FB9F1 VA: 0x30FB8F0
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|
	|-RVA: 0x30FC4E0 Offset: 0x30FC5E1 VA: 0x30FC4E0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x30FD050 Offset: 0x30FD151 VA: 0x30FD050
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x30FDCF0 Offset: 0x30FDDF1 VA: 0x30FDCF0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x30FEB30 Offset: 0x30FEC31 VA: 0x30FEB30
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x30FF810 Offset: 0x30FF911 VA: 0x30FF810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	|
	|-RVA: 0x3100360 Offset: 0x3100461 VA: 0x3100360
	|-EqualityComparer<GradientAlphaKey>.LastIndexOf
	|
	|-RVA: 0x3100F20 Offset: 0x3101021 VA: 0x3100F20
	|-EqualityComparer<GradientColorKey>.LastIndexOf
	|
	|-RVA: 0x3101B90 Offset: 0x3101C91 VA: 0x3101B90
	|-EqualityComparer<Keyframe>.LastIndexOf
	|
	|-RVA: 0x31027D0 Offset: 0x31028D1 VA: 0x31027D0
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x31033B0 Offset: 0x31034B1 VA: 0x31033B0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x31040A0 Offset: 0x31041A1 VA: 0x31040A0
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3104CD0 Offset: 0x3104DD1 VA: 0x3104CD0
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3105890 Offset: 0x3105991 VA: 0x3105890
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3106490 Offset: 0x3106591 VA: 0x3106490
	|-EqualityComparer<PlayableGraph>.LastIndexOf
	|
	|-RVA: 0x3106FF0 Offset: 0x31070F1 VA: 0x3106FF0
	|-EqualityComparer<Edge>.LastIndexOf
	|
	|-RVA: 0x3107B60 Offset: 0x3107C61 VA: 0x3107B60
	|-EqualityComparer<IntVec3>.LastIndexOf
	|
	|-RVA: 0x3108730 Offset: 0x3108831 VA: 0x3108730
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x31092D0 Offset: 0x31093D1 VA: 0x31092D0
	|-EqualityComparer<RangeInt>.LastIndexOf
	|
	|-RVA: 0x3109EA0 Offset: 0x3109FA1 VA: 0x3109EA0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x310ABA0 Offset: 0x310ACA1 VA: 0x310ABA0
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x310B860 Offset: 0x310B961 VA: 0x310B860
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x310C410 Offset: 0x310C511 VA: 0x310C410
	|-EqualityComparer<RectInt>.LastIndexOf
	|
	|-RVA: 0x310CF80 Offset: 0x310D081 VA: 0x310CF80
	|-EqualityComparer<ReflectionProbeBlendInfo>.LastIndexOf
	|
	|-RVA: 0x310DC00 Offset: 0x310DD01 VA: 0x310DC00
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x310E9F0 Offset: 0x310EAF1 VA: 0x310E9F0
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x310F5B0 Offset: 0x310F6B1 VA: 0x310F5B0
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x2EA7910 Offset: 0x2EA7A11 VA: 0x2EA7910
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x2EA8560 Offset: 0x2EA8661 VA: 0x2EA8560
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.LastIndexOf
	|
	|-RVA: 0x2EA91D0 Offset: 0x2EA92D1 VA: 0x2EA91D0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x2EA9E20 Offset: 0x2EA9F21 VA: 0x2EA9E20
	|-EqualityComparer<SceneInstance>.LastIndexOf
	|
	|-RVA: 0x2EAA9E0 Offset: 0x2EAAAE1 VA: 0x2EAA9E0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x2EAB650 Offset: 0x2EAB751 VA: 0x2EAB650
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x2EAC2A0 Offset: 0x2EAC3A1 VA: 0x2EAC2A0
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x2EACE80 Offset: 0x2EACF81 VA: 0x2EACE80
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x2EADB30 Offset: 0x2EADC31 VA: 0x2EADB30
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x2EAE780 Offset: 0x2EAE881 VA: 0x2EAE780
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x2EAF3D0 Offset: 0x2EAF4D1 VA: 0x2EAF3D0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x2EB0E50 Offset: 0x2EB0F51 VA: 0x2EB0E50
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x2EB1B00 Offset: 0x2EB1C01 VA: 0x2EB1B00
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x2EB2720 Offset: 0x2EB2821 VA: 0x2EB2720
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x2EB32D0 Offset: 0x2EB33D1 VA: 0x2EB32D0
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|
	|-RVA: 0x2EB3E40 Offset: 0x2EB3F41 VA: 0x2EB3E40
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|
	|-RVA: 0x2EB49A0 Offset: 0x2EB4AA1 VA: 0x2EB49A0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|
	|-RVA: 0x2EB54F0 Offset: 0x2EB55F1 VA: 0x2EB54F0
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x2EB6130 Offset: 0x2EB6231 VA: 0x2EB6130
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x2EB6EC0 Offset: 0x2EB6FC1 VA: 0x2EB6EC0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x2EB7AC0 Offset: 0x2EB7BC1 VA: 0x2EB7AC0
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2EB8620 Offset: 0x2EB8721 VA: 0x2EB8620
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|
	|-RVA: 0x2EB9190 Offset: 0x2EB9291 VA: 0x2EB9190
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2EB9D50 Offset: 0x2EB9E51 VA: 0x2EB9D50
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|
	|-RVA: 0x2EBA8F0 Offset: 0x2EBA9F1 VA: 0x2EBA8F0
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2EBB5B0 Offset: 0x2EBB6B1 VA: 0x2EBB5B0
	|-EqualityComparer<WarpPoints.WarpPoint>.LastIndexOf
	|
	|-RVA: 0x2EBC380 Offset: 0x2EBC481 VA: 0x2EBC380
	|-EqualityComparer<YieldItemParam>.LastIndexOf
	|
	|-RVA: 0x2EBCF20 Offset: 0x2EBD021 VA: 0x2EBCF20
	|-EqualityComparer<stCommand_t>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EB40 Offset: 0x2E3EC41 VA: 0x2E3EB40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E3F700 Offset: 0x2E3F801 VA: 0x2E3F700
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40250 Offset: 0x2E40351 VA: 0x2E40250
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E40FC0 Offset: 0x2E410C1 VA: 0x2E40FC0
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E41CA0 Offset: 0x2E41DA1 VA: 0x2E41CA0
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E42810 Offset: 0x2E42911 VA: 0x2E42810
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E43F10 Offset: 0x2E44011 VA: 0x2E43F10
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E44A60 Offset: 0x2E44B61 VA: 0x2E44A60
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E455A0 Offset: 0x2E456A1 VA: 0x2E455A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E461D0 Offset: 0x2E462D1 VA: 0x2E461D0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E46EB0 Offset: 0x2E46FB1 VA: 0x2E46EB0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E47B50 Offset: 0x2E47C51 VA: 0x2E47B50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E486F0 Offset: 0x2E487F1 VA: 0x2E486F0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E492E0 Offset: 0x2E493E1 VA: 0x2E492E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E49F30 Offset: 0x2E4A031 VA: 0x2E49F30
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4AB80 Offset: 0x2E4AC81 VA: 0x2E4AB80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4B740 Offset: 0x2E4B841 VA: 0x2E4B740
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4C3E0 Offset: 0x2E4C4E1 VA: 0x2E4C3E0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4D0A0 Offset: 0x2E4D1A1 VA: 0x2E4D0A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4DC80 Offset: 0x2E4DD81 VA: 0x2E4DC80
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4E7F0 Offset: 0x2E4E8F1 VA: 0x2E4E7F0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E4FEB0 Offset: 0x2E4FFB1 VA: 0x2E4FEB0
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E50B20 Offset: 0x2E50C21 VA: 0x2E50B20
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E51740 Offset: 0x2E51841 VA: 0x2E51740
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E523A0 Offset: 0x2E524A1 VA: 0x2E523A0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53040 Offset: 0x2E53141 VA: 0x2E53040
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E53CF0 Offset: 0x2E53DF1 VA: 0x2E53CF0
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E549B0 Offset: 0x2E54AB1 VA: 0x2E549B0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E555B0 Offset: 0x2E556B1 VA: 0x2E555B0
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56230 Offset: 0x2E56331 VA: 0x2E56230
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E56EE0 Offset: 0x2E56FE1 VA: 0x2E56EE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2E57AC0 Offset: 0x2E57BC1 VA: 0x2E57AC0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FEC30 Offset: 0x31FED31 VA: 0x31FEC30
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31FF8C0 Offset: 0x31FF9C1 VA: 0x31FF8C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3200480 Offset: 0x3200581 VA: 0x3200480
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201090 Offset: 0x3201191 VA: 0x3201090
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3201C70 Offset: 0x3201D71 VA: 0x3201C70
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32027E0 Offset: 0x32028E1 VA: 0x32027E0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3203420 Offset: 0x3203521 VA: 0x3203420
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204030 Offset: 0x3204131 VA: 0x3204030
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3204B80 Offset: 0x3204C81 VA: 0x3204B80
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3205700 Offset: 0x3205801 VA: 0x3205700
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32062B0 Offset: 0x32063B1 VA: 0x32062B0
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3206E40 Offset: 0x3206F41 VA: 0x3206E40
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3207A40 Offset: 0x3207B41 VA: 0x3207A40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3208690 Offset: 0x3208791 VA: 0x3208690
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209250 Offset: 0x3209351 VA: 0x3209250
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3209DE0 Offset: 0x3209EE1 VA: 0x3209DE0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320AAA0 Offset: 0x320ABA1 VA: 0x320AAA0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320B6D0 Offset: 0x320B7D1 VA: 0x320B6D0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320C220 Offset: 0x320C321 VA: 0x320C220
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320CD60 Offset: 0x320CE61 VA: 0x320CD60
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320D8C0 Offset: 0x320D9C1 VA: 0x320D8C0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320E410 Offset: 0x320E511 VA: 0x320E410
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320EF70 Offset: 0x320F071 VA: 0x320EF70
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x320FAC0 Offset: 0x320FBC1 VA: 0x320FAC0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3210620 Offset: 0x3210721 VA: 0x3210620
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211170 Offset: 0x3211271 VA: 0x3211170
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3211CD0 Offset: 0x3211DD1 VA: 0x3211CD0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3212820 Offset: 0x3212921 VA: 0x3212820
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213390 Offset: 0x3213491 VA: 0x3213390
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3213EE0 Offset: 0x3213FE1 VA: 0x3213EE0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3214A20 Offset: 0x3214B21 VA: 0x3214A20
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3215560 Offset: 0x3215661 VA: 0x3215560
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32160A0 Offset: 0x32161A1 VA: 0x32160A0
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3216C00 Offset: 0x3216D01 VA: 0x3216C00
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3217770 Offset: 0x3217871 VA: 0x3217770
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32183B0 Offset: 0x32184B1 VA: 0x32183B0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3218FB0 Offset: 0x32190B1 VA: 0x3218FB0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3219BF0 Offset: 0x3219CF1 VA: 0x3219BF0
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321A8E0 Offset: 0x321A9E1 VA: 0x321A8E0
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x321B4E0 Offset: 0x321B5E1 VA: 0x321B4E0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32C9DA0 Offset: 0x32C9EA1 VA: 0x32C9DA0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CA9B0 Offset: 0x32CAAB1 VA: 0x32CA9B0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CB5C0 Offset: 0x32CB6C1 VA: 0x32CB5C0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CC240 Offset: 0x32CC341 VA: 0x32CC240
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CCE10 Offset: 0x32CCF11 VA: 0x32CCE10
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CDAF0 Offset: 0x32CDBF1 VA: 0x32CDAF0
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CE810 Offset: 0x32CE911 VA: 0x32CE810
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32CF420 Offset: 0x32CF521 VA: 0x32CF420
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0030 Offset: 0x32D0131 VA: 0x32D0030
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D0CB0 Offset: 0x32D0DB1 VA: 0x32D0CB0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D18C0 Offset: 0x32D19C1 VA: 0x32D18C0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2460 Offset: 0x32D2561 VA: 0x32D2460
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D2FE0 Offset: 0x32D30E1 VA: 0x32D2FE0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D3B50 Offset: 0x32D3C51 VA: 0x32D3B50
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D4750 Offset: 0x32D4851 VA: 0x32D4750
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5320 Offset: 0x32D5421 VA: 0x32D5320
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D5E60 Offset: 0x32D5F61 VA: 0x32D5E60
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D69B0 Offset: 0x32D6AB1 VA: 0x32D69B0
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D7510 Offset: 0x32D7611 VA: 0x32D7510
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8060 Offset: 0x32D8161 VA: 0x32D8060
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D8BA0 Offset: 0x32D8CA1 VA: 0x32D8BA0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32D96E0 Offset: 0x32D97E1 VA: 0x32D96E0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DA230 Offset: 0x32DA331 VA: 0x32DA230
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DAD70 Offset: 0x32DAE71 VA: 0x32DAD70
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DB8B0 Offset: 0x32DB9B1 VA: 0x32DB8B0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DC3F0 Offset: 0x32DC4F1 VA: 0x32DC3F0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DCF30 Offset: 0x32DD031 VA: 0x32DCF30
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DDA90 Offset: 0x32DDB91 VA: 0x32DDA90
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DE600 Offset: 0x32DE701 VA: 0x32DE600
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DF170 Offset: 0x32DF271 VA: 0x32DF170
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32DFCE0 Offset: 0x32DFDE1 VA: 0x32DFCE0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E0850 Offset: 0x32E0951 VA: 0x32E0850
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E13E0 Offset: 0x32E14E1 VA: 0x32E13E0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2060 Offset: 0x32E2161 VA: 0x32E2060
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E2D90 Offset: 0x32E2E91 VA: 0x32E2D90
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E3A40 Offset: 0x32E3B41 VA: 0x32E3A40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E4620 Offset: 0x32E4721 VA: 0x32E4620
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5190 Offset: 0x32E5291 VA: 0x32E5190
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x32E5DF0 Offset: 0x32E5EF1 VA: 0x32E5DF0
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F1E30 Offset: 0x30F1F31 VA: 0x30F1E30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F29D0 Offset: 0x30F2AD1 VA: 0x30F29D0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F3510 Offset: 0x30F3611 VA: 0x30F3510
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4050 Offset: 0x30F4151 VA: 0x30F4050
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F4C40 Offset: 0x30F4D41 VA: 0x30F4C40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F58D0 Offset: 0x30F59D1 VA: 0x30F58D0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F64C0 Offset: 0x30F65C1 VA: 0x30F64C0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7200 Offset: 0x30F7301 VA: 0x30F7200
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F7EB0 Offset: 0x30F7FB1 VA: 0x30F7EB0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F8A00 Offset: 0x30F8B01 VA: 0x30F8A00
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30F9560 Offset: 0x30F9661 VA: 0x30F9560
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FADB0 Offset: 0x30FAEB1 VA: 0x30FADB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FBA00 Offset: 0x30FBB01 VA: 0x30FBA00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FC5A0 Offset: 0x30FC6A1 VA: 0x30FC5A0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FD140 Offset: 0x30FD241 VA: 0x30FD140
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FDEA0 Offset: 0x30FDFA1 VA: 0x30FDEA0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FECA0 Offset: 0x30FEDA1 VA: 0x30FECA0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x30FF8D0 Offset: 0x30FF9D1 VA: 0x30FF8D0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3100430 Offset: 0x3100531 VA: 0x3100430
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101030 Offset: 0x3101131 VA: 0x3101030
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3101CC0 Offset: 0x3101DC1 VA: 0x3101CC0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3102890 Offset: 0x3102991 VA: 0x3102890
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3103500 Offset: 0x3103601 VA: 0x3103500
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31041C0 Offset: 0x31042C1 VA: 0x31041C0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3104DA0 Offset: 0x3104EA1 VA: 0x3104DA0
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31059A0 Offset: 0x3105AA1 VA: 0x31059A0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3106560 Offset: 0x3106661 VA: 0x3106560
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x31070B0 Offset: 0x31071B1 VA: 0x31070B0
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3107C50 Offset: 0x3107D51 VA: 0x3107C50
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3108820 Offset: 0x3108921 VA: 0x3108820
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109390 Offset: 0x3109491 VA: 0x3109390
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3109FE0 Offset: 0x310A0E1 VA: 0x3109FE0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310ACF0 Offset: 0x310ADF1 VA: 0x310ACF0
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310B950 Offset: 0x310BA51 VA: 0x310B950
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310C4E0 Offset: 0x310C5E1 VA: 0x310C4E0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310D050 Offset: 0x310D151 VA: 0x310D050
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310DDD0 Offset: 0x310DED1 VA: 0x310DDD0
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310EAC0 Offset: 0x310EBC1 VA: 0x310EAC0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x310F6C0 Offset: 0x310F7C1 VA: 0x310F6C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA7A20 Offset: 0x2EA7B21 VA: 0x2EA7A20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA8670 Offset: 0x2EA8771 VA: 0x2EA8670
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9300 Offset: 0x2EA9401 VA: 0x2EA9300
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EA9EF0 Offset: 0x2EA9FF1 VA: 0x2EA9EF0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAAAF0 Offset: 0x2EAABF1 VA: 0x2EAAAF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAB780 Offset: 0x2EAB881 VA: 0x2EAB780
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAC370 Offset: 0x2EAC471 VA: 0x2EAC370
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EACFB0 Offset: 0x2EAD0B1 VA: 0x2EACFB0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EADC40 Offset: 0x2EADD41 VA: 0x2EADC40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAE890 Offset: 0x2EAE991 VA: 0x2EAE890
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EAF4E0 Offset: 0x2EAF5E1 VA: 0x2EAF4E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0230 Offset: 0x2EB0331 VA: 0x2EB0230
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB0F80 Offset: 0x2EB1081 VA: 0x2EB0F80
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB1C10 Offset: 0x2EB1D11 VA: 0x2EB1C10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB2810 Offset: 0x2EB2911 VA: 0x2EB2810
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB33A0 Offset: 0x2EB34A1 VA: 0x2EB33A0
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB3F10 Offset: 0x2EB4011 VA: 0x2EB3F10
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB4A60 Offset: 0x2EB4B61 VA: 0x2EB4A60
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB55C0 Offset: 0x2EB56C1 VA: 0x2EB55C0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB62C0 Offset: 0x2EB63C1 VA: 0x2EB62C0
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB6FD0 Offset: 0x2EB70D1 VA: 0x2EB6FD0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB7B90 Offset: 0x2EB7C91 VA: 0x2EB7B90
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9280 Offset: 0x2EB9381 VA: 0x2EB9280
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EB9E30 Offset: 0x2EB9F31 VA: 0x2EB9E30
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBA9E0 Offset: 0x2EBAAE1 VA: 0x2EBA9E0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBB780 Offset: 0x2EBB881 VA: 0x2EBB780
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBC440 Offset: 0x2EBC541 VA: 0x2EBC440
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x2EBD030 Offset: 0x2EBD131 VA: 0x2EBD030
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EC40 Offset: 0x2E3ED41 VA: 0x2E3EC40
	|-EqualityComparer<AS_ToolController.ChargeInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E3F7E0 Offset: 0x2E3F8E1 VA: 0x2E3F7E0
	|-EqualityComparer<JSONDeserialization.TaskField>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E40330 Offset: 0x2E40431 VA: 0x2E40330
	|-EqualityComparer<BitVector32Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41120 Offset: 0x2E41221 VA: 0x2E41120
	|-EqualityComparer<BuildItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-EqualityComparer<ButtonLinker.LinkObject>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E428F0 Offset: 0x2E429F1 VA: 0x2E428F0
	|-EqualityComparer<CharaCallTable.BustupTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43480 Offset: 0x2E43581 VA: 0x2E43480
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E43FF0 Offset: 0x2E440F1 VA: 0x2E43FF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E462E0 Offset: 0x2E463E1 VA: 0x2E462E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E46FC0 Offset: 0x2E470C1 VA: 0x2E46FC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E47C50 Offset: 0x2E47D51 VA: 0x2E47C50
	|-EqualityComparer<CropDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E487D0 Offset: 0x2E488D1 VA: 0x2E487D0
	|-EqualityComparer<DropItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E493E0 Offset: 0x2E494E1 VA: 0x2E493E0
	|-EqualityComparer<EffectDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4A030 Offset: 0x2E4A131 VA: 0x2E4A030
	|-EqualityComparer<ErosionBrush.UndoStep>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4AC80 Offset: 0x2E4AD81 VA: 0x2E4AC80
	|-EqualityComparer<EventCheckId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4B820 Offset: 0x2E4B921 VA: 0x2E4B820
	|-EqualityComparer<EventFlagProgressData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4C500 Offset: 0x2E4C601 VA: 0x2E4C500
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4D1A0 Offset: 0x2E4D2A1 VA: 0x2E4D1A0
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4DD60 Offset: 0x2E4DE61 VA: 0x2E4DD60
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4E8D0 Offset: 0x2E4E9D1 VA: 0x2E4E8D0
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4F440 Offset: 0x2E4F541 VA: 0x2E4F440
	|-EqualityComparer<FesNpcScoreData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E4FF90 Offset: 0x2E50091 VA: 0x2E4FF90
	|-EqualityComparer<GimmickLayoutDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E50C40 Offset: 0x2E50D41 VA: 0x2E50C40
	|-EqualityComparer<MineTypeDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820
	|-EqualityComparer<MiningDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E524B0 Offset: 0x2E525B1 VA: 0x2E524B0
	|-EqualityComparer<MiningPointSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53150 Offset: 0x2E53251 VA: 0x2E53150
	|-EqualityComparer<MonsterDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E53E00 Offset: 0x2E53F01 VA: 0x2E53E00
	|-EqualityComparer<MonsterFootStepEventDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E54AC0 Offset: 0x2E54BC1 VA: 0x2E54AC0
	|-EqualityComparer<MonsterHutSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E55690 Offset: 0x2E55791 VA: 0x2E55690
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56350 Offset: 0x2E56451 VA: 0x2E56350
	|-EqualityComparer<NPCActionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E56FE0 Offset: 0x2E570E1 VA: 0x2E56FE0
	|-EqualityComparer<NpcPlaceSchedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2E57BA0 Offset: 0x2E57CA1 VA: 0x2E57BA0
	|-EqualityComparer<OrderLotterySaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FED40 Offset: 0x31FEE41 VA: 0x31FED40
	|-EqualityComparer<OrderSaveData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31FF9C0 Offset: 0x31FFAC1 VA: 0x31FF9C0
	|-EqualityComparer<OrderSaveParameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3200560 Offset: 0x3200661 VA: 0x3200560
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32011A0 Offset: 0x32012A1 VA: 0x32011A0
	|-EqualityComparer<Parameter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3201D50 Offset: 0x3201E51 VA: 0x3201D50
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32028C0 Offset: 0x32029C1 VA: 0x32028C0
	|-EqualityComparer<ShopCatalogPage>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3203530 Offset: 0x3203631 VA: 0x3203530
	|-EqualityComparer<ShopNpcTalk>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204110 Offset: 0x3204211 VA: 0x3204110
	|-EqualityComparer<SubtitleDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3204C60 Offset: 0x3204D61 VA: 0x3204C60
	|-EqualityComparer<SubtitleDataTable.DataList>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32057E0 Offset: 0x32058E1 VA: 0x32057E0
	|-EqualityComparer<SubtitleHudDataTable.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206390 Offset: 0x3206491 VA: 0x3206390
	|-EqualityComparer<ProfilerFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3206F20 Offset: 0x3207021 VA: 0x3206F20
	|-EqualityComparer<NumberControl.ValueRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3207B40 Offset: 0x3207C41 VA: 0x3207B40
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3208790 Offset: 0x3208891 VA: 0x3208790
	|-EqualityComparer<Schedule>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209330 Offset: 0x3209431 VA: 0x3209330
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3209EC0 Offset: 0x3209FC1 VA: 0x3209EC0
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320ABD0 Offset: 0x320ACD1 VA: 0x320ABD0
	|-EqualityComparer<CurveSample>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320B7B0 Offset: 0x320B8B1 VA: 0x320B7B0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320C300 Offset: 0x320C401 VA: 0x320C300
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320CE40 Offset: 0x320CF41 VA: 0x320CE40
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320D9A0 Offset: 0x320DAA1 VA: 0x320D9A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320E4F0 Offset: 0x320E5F1 VA: 0x320E4F0
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320F050 Offset: 0x320F151 VA: 0x320F050
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x320FBA0 Offset: 0x320FCA1 VA: 0x320FBA0
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3210700 Offset: 0x3210801 VA: 0x3210700
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211250 Offset: 0x3211351 VA: 0x3211250
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3211DB0 Offset: 0x3211EB1 VA: 0x3211DB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3212900 Offset: 0x3212A01 VA: 0x3212900
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213470 Offset: 0x3213571 VA: 0x3213470
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3213FC0 Offset: 0x32140C1 VA: 0x3213FC0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3214B00 Offset: 0x3214C01 VA: 0x3214B00
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3215640 Offset: 0x3215741 VA: 0x3215640
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216180 Offset: 0x3216281 VA: 0x3216180
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3216CE0 Offset: 0x3216DE1 VA: 0x3216CE0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3217850 Offset: 0x3217951 VA: 0x3217850
	|-EqualityComparer<Memory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32184E0 Offset: 0x32185E1 VA: 0x32184E0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32190A0 Offset: 0x32191A1 VA: 0x32190A0
	|-EqualityComparer<Nullable<Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3219D20 Offset: 0x3219E21 VA: 0x3219D20
	|-EqualityComparer<Nullable<Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321AA10 Offset: 0x321AB11 VA: 0x321AA10
	|-EqualityComparer<Nullable<BoundsInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x321B5D0 Offset: 0x321B6D1 VA: 0x321B5D0
	|-EqualityComparer<Nullable<Color32>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32C9EC0 Offset: 0x32C9FC1 VA: 0x32C9EC0
	|-EqualityComparer<Nullable<Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CAAA0 Offset: 0x32CABA1 VA: 0x32CAAA0
	|-EqualityComparer<Nullable<GradientAlphaKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CB6E0 Offset: 0x32CB7E1 VA: 0x32CB6E0
	|-EqualityComparer<Nullable<GradientColorKey>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CC360 Offset: 0x32CC461 VA: 0x32CC360
	|-EqualityComparer<Nullable<Keyframe>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CCF00 Offset: 0x32CD001 VA: 0x32CCF00
	|-EqualityComparer<Nullable<LayerMask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CDC40 Offset: 0x32CDD41 VA: 0x32CDC40
	|-EqualityComparer<Nullable<Matrix4x4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CE930 Offset: 0x32CEA31 VA: 0x32CE930
	|-EqualityComparer<Nullable<Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32CF510 Offset: 0x32CF611 VA: 0x32CF510
	|-EqualityComparer<Nullable<RangeInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0150 Offset: 0x32D0251 VA: 0x32D0150
	|-EqualityComparer<Nullable<Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D0DD0 Offset: 0x32D0ED1 VA: 0x32D0DD0
	|-EqualityComparer<Nullable<RectInt>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D19B0 Offset: 0x32D1AB1 VA: 0x32D19B0
	|-EqualityComparer<Nullable<Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D2550 Offset: 0x32D2651 VA: 0x32D2550
	|-EqualityComparer<Nullable<Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D30D0 Offset: 0x32D31D1 VA: 0x32D30D0
	|-EqualityComparer<Nullable<Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D3C40 Offset: 0x32D3D41 VA: 0x32D3C40
	|-EqualityComparer<Nullable<Vector3Int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D4870 Offset: 0x32D4971 VA: 0x32D4870
	|-EqualityComparer<Nullable<Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D53F0 Offset: 0x32D54F1 VA: 0x32D53F0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D5F40 Offset: 0x32D6041 VA: 0x32D5F40
	|-EqualityComparer<ReadOnlyMemory<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D6A90 Offset: 0x32D6B91 VA: 0x32D6A90
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D75F0 Offset: 0x32D76F1 VA: 0x32D75F0
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-EqualityComparer<RuntimeTypeHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D8C80 Offset: 0x32D8D81 VA: 0x32D8C80
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DA310 Offset: 0x32DA411 VA: 0x32DA310
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DAE50 Offset: 0x32DAF51 VA: 0x32DAE50
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DB990 Offset: 0x32DBA91 VA: 0x32DB990
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DC4D0 Offset: 0x32DC5D1 VA: 0x32DC4D0
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DD010 Offset: 0x32DD111 VA: 0x32DD010
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DDB70 Offset: 0x32DDC71 VA: 0x32DDB70
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DE6E0 Offset: 0x32DE7E1 VA: 0x32DE6E0
	|-EqualityComparer<ValueTuple<object, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DF250 Offset: 0x32DF351 VA: 0x32DF250
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32DFDC0 Offset: 0x32DFEC1 VA: 0x32DFDC0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E0930 Offset: 0x32E0A31 VA: 0x32E0930
	|-EqualityComparer<ValueTuple<float, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E14C0 Offset: 0x32E15C1 VA: 0x32E14C0
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2180 Offset: 0x32E2281 VA: 0x32E2180
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E2EB0 Offset: 0x32E2FB1 VA: 0x32E2EB0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E3B40 Offset: 0x32E3C41 VA: 0x32E3B40
	|-EqualityComparer<TransitionTables>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E4700 Offset: 0x32E4801 VA: 0x32E4700
	|-EqualityComparer<TutorialUnlockFlagData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5270 Offset: 0x32E5371 VA: 0x32E5270
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x32E5F00 Offset: 0x32E6001 VA: 0x32E5F00
	|-EqualityComparer<CapEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F1F30 Offset: 0x30F2031 VA: 0x30F1F30
	|-EqualityComparer<ClippedEdge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F2AB0 Offset: 0x30F2BB1 VA: 0x30F2AB0
	|-EqualityComparer<EdgeKeyByHash>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F35F0 Offset: 0x30F36F1 VA: 0x30F35F0
	|-EqualityComparer<EdgeKeyByIndex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4130 Offset: 0x30F4231 VA: 0x30F4130
	|-EqualityComparer<MeshDataConnectivity.Face>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F4D40 Offset: 0x30F4E41 VA: 0x30F4D40
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F59E0 Offset: 0x30F5AE1 VA: 0x30F59E0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F65A0 Offset: 0x30F66A1 VA: 0x30F65A0
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7350 Offset: 0x30F7451 VA: 0x30F7350
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F7F90 Offset: 0x30F8091 VA: 0x30F7F90
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F8AE0 Offset: 0x30F8BE1 VA: 0x30F8AE0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30F9640 Offset: 0x30F9741 VA: 0x30F9640
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FA260 Offset: 0x30FA361 VA: 0x30FA260
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FAEB0 Offset: 0x30FAFB1 VA: 0x30FAEB0
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FBB00 Offset: 0x30FBC01 VA: 0x30FBB00
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FC680 Offset: 0x30FC781 VA: 0x30FC680
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FD220 Offset: 0x30FD321 VA: 0x30FD220
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FDFF0 Offset: 0x30FE0F1 VA: 0x30FDFF0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FEDD0 Offset: 0x30FEED1 VA: 0x30FEDD0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x30FF9B0 Offset: 0x30FFAB1 VA: 0x30FF9B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3100510 Offset: 0x3100611 VA: 0x3100510
	|-EqualityComparer<GradientAlphaKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101130 Offset: 0x3101231 VA: 0x3101130
	|-EqualityComparer<GradientColorKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3101DD0 Offset: 0x3101ED1 VA: 0x3101DD0
	|-EqualityComparer<Keyframe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3102970 Offset: 0x3102A71 VA: 0x3102970
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3103620 Offset: 0x3103721 VA: 0x3103620
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x31042D0 Offset: 0x31043D1 VA: 0x31042D0
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3104E80 Offset: 0x3104F81 VA: 0x3104E80
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3105AA0 Offset: 0x3105BA1 VA: 0x3105AA0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3106640 Offset: 0x3106741 VA: 0x3106640
	|-EqualityComparer<PlayableGraph>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107190 Offset: 0x3107291 VA: 0x3107190
	|-EqualityComparer<Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3107D30 Offset: 0x3107E31 VA: 0x3107D30
	|-EqualityComparer<IntVec3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3108900 Offset: 0x3108A01 VA: 0x3108900
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3109470 Offset: 0x3109571 VA: 0x3109470
	|-EqualityComparer<RangeInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310A0F0 Offset: 0x310A1F1 VA: 0x310A0F0
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310AE10 Offset: 0x310AF11 VA: 0x310AE10
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310BA30 Offset: 0x310BB31 VA: 0x310BA30
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310C5C0 Offset: 0x310C6C1 VA: 0x310C5C0
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310D130 Offset: 0x310D231 VA: 0x310D130
	|-EqualityComparer<ReflectionProbeBlendInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310DF40 Offset: 0x310E041 VA: 0x310DF40
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310EBA0 Offset: 0x310ECA1 VA: 0x310EBA0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x310F7C0 Offset: 0x310F8C1 VA: 0x310F7C0
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA7B20 Offset: 0x2EA7C21 VA: 0x2EA7B20
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA8770 Offset: 0x2EA8871 VA: 0x2EA8770
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9410 Offset: 0x2EA9511 VA: 0x2EA9410
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EA9FD0 Offset: 0x2EAA0D1 VA: 0x2EA9FD0
	|-EqualityComparer<SceneInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAABF0 Offset: 0x2EAACF1 VA: 0x2EAABF0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAB890 Offset: 0x2EAB991 VA: 0x2EAB890
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAC450 Offset: 0x2EAC551 VA: 0x2EAC450
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAD0C0 Offset: 0x2EAD1C1 VA: 0x2EAD0C0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAE990 Offset: 0x2EAEA91 VA: 0x2EAE990
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EAF5E0 Offset: 0x2EAF6E1 VA: 0x2EAF5E0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB0370 Offset: 0x2EB0471 VA: 0x2EB0370
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1090 Offset: 0x2EB1191 VA: 0x2EB1090
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB1D10 Offset: 0x2EB1E11 VA: 0x2EB1D10
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3480 Offset: 0x2EB3581 VA: 0x2EB3480
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB3FF0 Offset: 0x2EB40F1 VA: 0x2EB3FF0
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB4B40 Offset: 0x2EB4C41 VA: 0x2EB4B40
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB56A0 Offset: 0x2EB57A1 VA: 0x2EB56A0
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB6400 Offset: 0x2EB6501 VA: 0x2EB6400
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB70D0 Offset: 0x2EB71D1 VA: 0x2EB70D0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB7C70 Offset: 0x2EB7D71 VA: 0x2EB7C70
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB87C0 Offset: 0x2EB88C1 VA: 0x2EB87C0
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9360 Offset: 0x2EB9461 VA: 0x2EB9360
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EB9F10 Offset: 0x2EBA011 VA: 0x2EB9F10
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBAAC0 Offset: 0x2EBABC1 VA: 0x2EBAAC0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBB8E0 Offset: 0x2EBB9E1 VA: 0x2EBB8E0
	|-EqualityComparer<WarpPoints.WarpPoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBC520 Offset: 0x2EBC621 VA: 0x2EBC520
	|-EqualityComparer<YieldItemParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x2EBD130 Offset: 0x2EBD231 VA: 0x2EBD130
	|-EqualityComparer<stCommand_t>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3EDF0 Offset: 0x2E3EEF1 VA: 0x2E3EDF0
	|-EqualityComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2E3F960 Offset: 0x2E3FA61 VA: 0x2E3F960
	|-EqualityComparer<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x2E404A0 Offset: 0x2E405A1 VA: 0x2E404A0
	|-EqualityComparer<BitVector32Int>..ctor
	|
	|-RVA: 0x2E41390 Offset: 0x2E41491 VA: 0x2E41390
	|-EqualityComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-EqualityComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2E42A70 Offset: 0x2E42B71 VA: 0x2E42A70
	|-EqualityComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2E43600 Offset: 0x2E43701 VA: 0x2E43600
	|-EqualityComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2E44170 Offset: 0x2E44271 VA: 0x2E44170
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2E44CB0 Offset: 0x2E44DB1 VA: 0x2E44CB0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2E457F0 Offset: 0x2E458F1 VA: 0x2E457F0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2E471A0 Offset: 0x2E472A1 VA: 0x2E471A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2E47E00 Offset: 0x2E47F01 VA: 0x2E47E00
	|-EqualityComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2E48940 Offset: 0x2E48A41 VA: 0x2E48940
	|-EqualityComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2E49590 Offset: 0x2E49691 VA: 0x2E49590
	|-EqualityComparer<EffectDataTable>..ctor
	|
	|-RVA: 0x2E4A1E0 Offset: 0x2E4A2E1 VA: 0x2E4A1E0
	|-EqualityComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2E4AE30 Offset: 0x2E4AF31 VA: 0x2E4AE30
	|-EqualityComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2E4B9A0 Offset: 0x2E4BAA1 VA: 0x2E4B9A0
	|-EqualityComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2E4C700 Offset: 0x2E4C801 VA: 0x2E4C700
	|-EqualityComparer<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2E4D350 Offset: 0x2E4D451 VA: 0x2E4D350
	|-EqualityComparer<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2E4DEE0 Offset: 0x2E4DFE1 VA: 0x2E4DEE0
	|-EqualityComparer<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2E4EA50 Offset: 0x2E4EB51 VA: 0x2E4EA50
	|-EqualityComparer<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x2E4F5C0 Offset: 0x2E4F6C1 VA: 0x2E4F5C0
	|-EqualityComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2E50100 Offset: 0x2E50201 VA: 0x2E50100
	|-EqualityComparer<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2E50E30 Offset: 0x2E50F31 VA: 0x2E50E30
	|-EqualityComparer<MineTypeDataTable>..ctor
	|
	|-RVA: 0x2E519A0 Offset: 0x2E51AA1 VA: 0x2E519A0
	|-EqualityComparer<MiningDataTable>..ctor
	|
	|-RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	|-EqualityComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2E53310 Offset: 0x2E53411 VA: 0x2E53310
	|-EqualityComparer<MonsterDataTable>..ctor
	|
	|-RVA: 0x2E53FD0 Offset: 0x2E540D1 VA: 0x2E53FD0
	|-EqualityComparer<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E54CA0 Offset: 0x2E54DA1 VA: 0x2E54CA0
	|-EqualityComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2E55810 Offset: 0x2E55911 VA: 0x2E55810
	|-EqualityComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	|-EqualityComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2E57190 Offset: 0x2E57291 VA: 0x2E57190
	|-EqualityComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2E57D20 Offset: 0x2E57E21 VA: 0x2E57D20
	|-EqualityComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31FEF20 Offset: 0x31FF021 VA: 0x31FEF20
	|-EqualityComparer<OrderSaveData>..ctor
	|
	|-RVA: 0x31FFB70 Offset: 0x31FFC71 VA: 0x31FFB70
	|-EqualityComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32006E0 Offset: 0x32007E1 VA: 0x32006E0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3201360 Offset: 0x3201461 VA: 0x3201360
	|-EqualityComparer<Parameter>..ctor
	|
	|-RVA: 0x3201ED0 Offset: 0x3201FD1 VA: 0x3201ED0
	|-EqualityComparer<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x3202A40 Offset: 0x3202B41 VA: 0x3202A40
	|-EqualityComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x3203700 Offset: 0x3203801 VA: 0x3203700
	|-EqualityComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3204290 Offset: 0x3204391 VA: 0x3204290
	|-EqualityComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3204DD0 Offset: 0x3204ED1 VA: 0x3204DD0
	|-EqualityComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3205960 Offset: 0x3205A61 VA: 0x3205960
	|-EqualityComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3206530 Offset: 0x3206631 VA: 0x3206530
	|-EqualityComparer<ProfilerFrame>..ctor
	|
	|-RVA: 0x32070A0 Offset: 0x32071A1 VA: 0x32070A0
	|-EqualityComparer<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x3207CF0 Offset: 0x3207DF1 VA: 0x3207CF0
	|-EqualityComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x3208940 Offset: 0x3208A41 VA: 0x3208940
	|-EqualityComparer<Schedule>..ctor
	|
	|-RVA: 0x32094B0 Offset: 0x32095B1 VA: 0x32094B0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x320A040 Offset: 0x320A141 VA: 0x320A040
	|-EqualityComparer<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x320ADE0 Offset: 0x320AEE1 VA: 0x320ADE0
	|-EqualityComparer<CurveSample>..ctor
	|
	|-RVA: 0x320B930 Offset: 0x320BA31 VA: 0x320B930
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x320C470 Offset: 0x320C571 VA: 0x320C470
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x320CFB0 Offset: 0x320D0B1 VA: 0x320CFB0
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x320DB20 Offset: 0x320DC21 VA: 0x320DB20
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x320E660 Offset: 0x320E761 VA: 0x320E660
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x320F1D0 Offset: 0x320F2D1 VA: 0x320F1D0
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x320FD10 Offset: 0x320FE11 VA: 0x320FD10
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3210880 Offset: 0x3210981 VA: 0x3210880
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32113C0 Offset: 0x32114C1 VA: 0x32113C0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3211F30 Offset: 0x3212031 VA: 0x3211F30
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3212A80 Offset: 0x3212B81 VA: 0x3212A80
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x32135F0 Offset: 0x32136F1 VA: 0x32135F0
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3214130 Offset: 0x3214231 VA: 0x3214130
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3214C70 Offset: 0x3214D71 VA: 0x3214C70
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x32157B0 Offset: 0x32158B1 VA: 0x32157B0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x32162F0 Offset: 0x32163F1 VA: 0x32162F0
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3216E60 Offset: 0x3216F61 VA: 0x3216E60
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x32179D0 Offset: 0x3217AD1 VA: 0x32179D0
	|-EqualityComparer<Memory<object>>..ctor
	|
	|-RVA: 0x32186C0 Offset: 0x32187C1 VA: 0x32186C0
	|-EqualityComparer<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3219210 Offset: 0x3219311 VA: 0x3219210
	|-EqualityComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3219F00 Offset: 0x321A001 VA: 0x3219F00
	|-EqualityComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x321ABF0 Offset: 0x321ACF1 VA: 0x321ABF0
	|-EqualityComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x321B740 Offset: 0x321B841 VA: 0x321B740
	|-EqualityComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x32CA080 Offset: 0x32CA181 VA: 0x32CA080
	|-EqualityComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x32CAC20 Offset: 0x32CAD21 VA: 0x32CAC20
	|-EqualityComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x32CB8A0 Offset: 0x32CB9A1 VA: 0x32CB8A0
	|-EqualityComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x32CC520 Offset: 0x32CC621 VA: 0x32CC520
	|-EqualityComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x32CD070 Offset: 0x32CD171 VA: 0x32CD070
	|-EqualityComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x32CDE70 Offset: 0x32CDF71 VA: 0x32CDE70
	|-EqualityComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x32CEAF0 Offset: 0x32CEBF1 VA: 0x32CEAF0
	|-EqualityComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x32CF690 Offset: 0x32CF791 VA: 0x32CF690
	|-EqualityComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x32D0310 Offset: 0x32D0411 VA: 0x32D0310
	|-EqualityComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32D0F90 Offset: 0x32D1091 VA: 0x32D0F90
	|-EqualityComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x32D1B30 Offset: 0x32D1C31 VA: 0x32D1B30
	|-EqualityComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x32D26D0 Offset: 0x32D27D1 VA: 0x32D26D0
	|-EqualityComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x32D3240 Offset: 0x32D3341 VA: 0x32D3240
	|-EqualityComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32D3DB0 Offset: 0x32D3EB1 VA: 0x32D3DB0
	|-EqualityComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x32D4A30 Offset: 0x32D4B31 VA: 0x32D4A30
	|-EqualityComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32D5550 Offset: 0x32D5651 VA: 0x32D5550
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x32D60C0 Offset: 0x32D61C1 VA: 0x32D60C0
	|-EqualityComparer<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x32D6C00 Offset: 0x32D6D01 VA: 0x32D6C00
	|-EqualityComparer<Label>..ctor
	|
	|-RVA: 0x32D7770 Offset: 0x32D7871 VA: 0x32D7770
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x32D82B0 Offset: 0x32D83B1 VA: 0x32D82B0
	|-EqualityComparer<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x32D8DF0 Offset: 0x32D8EF1 VA: 0x32D8DF0
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x32D9940 Offset: 0x32D9A41 VA: 0x32D9940
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x32DA480 Offset: 0x32DA581 VA: 0x32DA480
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x32DAFC0 Offset: 0x32DB0C1 VA: 0x32DAFC0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x32DBB00 Offset: 0x32DBC01 VA: 0x32DBB00
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x32DC640 Offset: 0x32DC741 VA: 0x32DC640
	|-EqualityComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32DD180 Offset: 0x32DD281 VA: 0x32DD180
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32DDCF0 Offset: 0x32DDDF1 VA: 0x32DDCF0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32DE860 Offset: 0x32DE961 VA: 0x32DE860
	|-EqualityComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32DF3D0 Offset: 0x32DF4D1 VA: 0x32DF3D0
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32DFF40 Offset: 0x32E0041 VA: 0x32DFF40
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32E0AB0 Offset: 0x32E0BB1 VA: 0x32E0AB0
	|-EqualityComparer<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x32E1640 Offset: 0x32E1741 VA: 0x32E1640
	|-EqualityComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32E2370 Offset: 0x32E2471 VA: 0x32E2370
	|-EqualityComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32E30A0 Offset: 0x32E31A1 VA: 0x32E30A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32E3CF0 Offset: 0x32E3DF1 VA: 0x32E3CF0
	|-EqualityComparer<TransitionTables>..ctor
	|
	|-RVA: 0x32E4880 Offset: 0x32E4981 VA: 0x32E4880
	|-EqualityComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-EqualityComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32E60E0 Offset: 0x32E61E1 VA: 0x32E60E0
	|-EqualityComparer<CapEdge>..ctor
	|
	|-RVA: 0x30F20E0 Offset: 0x30F21E1 VA: 0x30F20E0
	|-EqualityComparer<ClippedEdge>..ctor
	|
	|-RVA: 0x30F2C20 Offset: 0x30F2D21 VA: 0x30F2C20
	|-EqualityComparer<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x30F3760 Offset: 0x30F3861 VA: 0x30F3760
	|-EqualityComparer<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x30F42A0 Offset: 0x30F43A1 VA: 0x30F42A0
	|-EqualityComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x30F4EF0 Offset: 0x30F4FF1 VA: 0x30F4EF0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x30F5BB0 Offset: 0x30F5CB1 VA: 0x30F5BB0
	|-EqualityComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x30F6720 Offset: 0x30F6821 VA: 0x30F6720
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x30F75A0 Offset: 0x30F76A1 VA: 0x30F75A0
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x30F8110 Offset: 0x30F8211 VA: 0x30F8110
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x30F8C50 Offset: 0x30F8D51 VA: 0x30F8C50
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x30F97C0 Offset: 0x30F98C1 VA: 0x30F97C0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x30FA410 Offset: 0x30FA511 VA: 0x30FA410
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x30FB060 Offset: 0x30FB161 VA: 0x30FB060
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x30FBCB0 Offset: 0x30FBDB1 VA: 0x30FBCB0
	|-EqualityComparer<BoundsInt>..ctor
	|
	|-RVA: 0x30FC7F0 Offset: 0x30FC8F1 VA: 0x30FC7F0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x30FD3C0 Offset: 0x30FD4C1 VA: 0x30FD3C0
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x30FE240 Offset: 0x30FE341 VA: 0x30FE240
	|-EqualityComparer<CombineInstance>..ctor
	|
	|-RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x30FFB20 Offset: 0x30FFC21 VA: 0x30FFB20
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x3100690 Offset: 0x3100791 VA: 0x3100690
	|-EqualityComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31012E0 Offset: 0x31013E1 VA: 0x31012E0
	|-EqualityComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x3101FA0 Offset: 0x31020A1 VA: 0x3101FA0
	|-EqualityComparer<Keyframe>..ctor
	|
	|-RVA: 0x3102AE0 Offset: 0x3102BE1 VA: 0x3102AE0
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3103810 Offset: 0x3103911 VA: 0x3103810
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3104490 Offset: 0x3104591 VA: 0x3104490
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3105000 Offset: 0x3105101 VA: 0x3105000
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3105C50 Offset: 0x3105D51 VA: 0x3105C50
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x31067C0 Offset: 0x31068C1 VA: 0x31067C0
	|-EqualityComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x3107300 Offset: 0x3107401 VA: 0x3107300
	|-EqualityComparer<Edge>..ctor
	|
	|-RVA: 0x3107ED0 Offset: 0x3107FD1 VA: 0x3107ED0
	|-EqualityComparer<IntVec3>..ctor
	|
	|-RVA: 0x3108AA0 Offset: 0x3108BA1 VA: 0x3108AA0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x31095E0 Offset: 0x31096E1 VA: 0x31095E0
	|-EqualityComparer<RangeInt>..ctor
	|
	|-RVA: 0x310A2D0 Offset: 0x310A3D1 VA: 0x310A2D0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x310B000 Offset: 0x310B101 VA: 0x310B000
	|-EqualityComparer<RaycastHit>..ctor
	|
	|-RVA: 0x310BBD0 Offset: 0x310BCD1 VA: 0x310BBD0
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x310C740 Offset: 0x310C841 VA: 0x310C740
	|-EqualityComparer<RectInt>..ctor
	|
	|-RVA: 0x310D2B0 Offset: 0x310D3B1 VA: 0x310D2B0
	|-EqualityComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x310ED20 Offset: 0x310EE21 VA: 0x310ED20
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x310F970 Offset: 0x310FA71 VA: 0x310F970
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EA7CD0 Offset: 0x2EA7DD1 VA: 0x2EA7CD0
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2EA8920 Offset: 0x2EA8A21 VA: 0x2EA8920
	|-EqualityComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2EA95E0 Offset: 0x2EA96E1 VA: 0x2EA95E0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2EAA150 Offset: 0x2EAA251 VA: 0x2EAA150
	|-EqualityComparer<SceneInstance>..ctor
	|
	|-RVA: 0x2EAADA0 Offset: 0x2EAAEA1 VA: 0x2EAADA0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2EABA60 Offset: 0x2EABB61 VA: 0x2EABA60
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2EAC5D0 Offset: 0x2EAC6D1 VA: 0x2EAC5D0
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x2EAD2A0 Offset: 0x2EAD3A1 VA: 0x2EAD2A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2EADEF0 Offset: 0x2EADFF1 VA: 0x2EADEF0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2EAEB40 Offset: 0x2EAEC41 VA: 0x2EAEB40
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2EAF790 Offset: 0x2EAF891 VA: 0x2EAF790
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2EB05A0 Offset: 0x2EB06A1 VA: 0x2EB05A0
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x2EB1270 Offset: 0x2EB1371 VA: 0x2EB1270
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x2EB1EC0 Offset: 0x2EB1FC1 VA: 0x2EB1EC0
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x2EB2A90 Offset: 0x2EB2B91 VA: 0x2EB2A90
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x2EB3600 Offset: 0x2EB3701 VA: 0x2EB3600
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2EB4170 Offset: 0x2EB4271 VA: 0x2EB4170
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2EB4CB0 Offset: 0x2EB4DB1 VA: 0x2EB4CB0
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2EB5820 Offset: 0x2EB5921 VA: 0x2EB5820
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x2EB6630 Offset: 0x2EB6731 VA: 0x2EB6630
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2EB7DF0 Offset: 0x2EB7EF1 VA: 0x2EB7DF0
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2EB8930 Offset: 0x2EB8A31 VA: 0x2EB8930
	|-EqualityComparer<Vector2Int>..ctor
	|
	|-RVA: 0x2EB9500 Offset: 0x2EB9601 VA: 0x2EB9500
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2EBA090 Offset: 0x2EBA191 VA: 0x2EBA090
	|-EqualityComparer<Vector3Int>..ctor
	|
	|-RVA: 0x2EBAC60 Offset: 0x2EBAD61 VA: 0x2EBAC60
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2EBBB50 Offset: 0x2EBBC51 VA: 0x2EBBB50
	|-EqualityComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2EBC690 Offset: 0x2EBC791 VA: 0x2EBC690
	|-EqualityComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x2EBD2E0 Offset: 0x2EBD3E1 VA: 0x2EBD2E0
	|-EqualityComparer<stCommand_t>..ctor
	*/
}

