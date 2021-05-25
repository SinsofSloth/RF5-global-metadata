[DebuggerDisplayAttribute] // RVA: 0xB32B0 Offset: 0xB33B1 VA: 0xB32B0
[DebuggerTypeProxyAttribute] // RVA: 0xB32B0 Offset: 0xB33B1 VA: 0xB32B0
[DefaultMemberAttribute] // RVA: 0xB32B0 Offset: 0xB33B1 VA: 0xB32B0
[ComVisibleAttribute] // RVA: 0xB32B0 Offset: 0xB33B1 VA: 0xB32B0
[Serializable]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1393
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	protected IList<T> Items { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8AA0 Offset: 0x2EE8BA1 VA: 0x2EE8AA0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2EE9C10 Offset: 0x2EE9D11 VA: 0x2EE9C10
	|-ReadOnlyCollection<BuildItemData>..ctor
	|
	|-RVA: 0x2EEB010 Offset: 0x2EEB111 VA: 0x2EEB010
	|-ReadOnlyCollection<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2EEC0B0 Offset: 0x2EEC1B1 VA: 0x2EEC0B0
	|-ReadOnlyCollection<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2EED150 Offset: 0x2EED251 VA: 0x2EED150
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2EEE220 Offset: 0x2EEE321 VA: 0x2EEE220
	|-ReadOnlyCollection<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2EEF2C0 Offset: 0x2EEF3C1 VA: 0x2EEF2C0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2EF0350 Offset: 0x2EF0451 VA: 0x2EF0350
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2EF13E0 Offset: 0x2EF14E1 VA: 0x2EF13E0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2EF25C0 Offset: 0x2EF26C1 VA: 0x2EF25C0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2EF37C0 Offset: 0x2EF38C1 VA: 0x2EF37C0
	|-ReadOnlyCollection<CropDataTable>..ctor
	|
	|-RVA: 0x2EF49A0 Offset: 0x2EF4AA1 VA: 0x2EF49A0
	|-ReadOnlyCollection<DropItemParam>..ctor
	|
	|-RVA: 0x2EF5A30 Offset: 0x2EF5B31 VA: 0x2EF5A30
	|-ReadOnlyCollection<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2EF6BA0 Offset: 0x2EF6CA1 VA: 0x2EF6BA0
	|-ReadOnlyCollection<EventCheckId>..ctor
	|
	|-RVA: 0x2EF7D10 Offset: 0x2EF7E11 VA: 0x2EF7D10
	|-ReadOnlyCollection<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2EF8DB0 Offset: 0x2EF8EB1 VA: 0x2EF8DB0
	|-ReadOnlyCollection<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2EF9E50 Offset: 0x2EF9F51 VA: 0x2EF9E50
	|-ReadOnlyCollection<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2EFB050 Offset: 0x2EFB151 VA: 0x2EFB050
	|-ReadOnlyCollection<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2EFC230 Offset: 0x2EFC331 VA: 0x2EFC230
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x32E6100 Offset: 0x32E6201 VA: 0x32E6100
	|-ReadOnlyCollection<NPCActionData>..ctor
	|
	|-RVA: 0x32E7340 Offset: 0x32E7441 VA: 0x32E7340
	|-ReadOnlyCollection<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x32E84B0 Offset: 0x32E85B1 VA: 0x32E84B0
	|-ReadOnlyCollection<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x32E9580 Offset: 0x32E9681 VA: 0x32E9580
	|-ReadOnlyCollection<OrderSaveParameter>..ctor
	|
	|-RVA: 0x32EA6F0 Offset: 0x32EA7F1 VA: 0x32EA6F0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x32EB790 Offset: 0x32EB891 VA: 0x32EB790
	|-ReadOnlyCollection<ShopCatalogPage>..ctor
	|
	|-RVA: 0x32EC830 Offset: 0x32EC931 VA: 0x32EC830
	|-ReadOnlyCollection<ShopNpcTalk>..ctor
	|
	|-RVA: 0x32EDA10 Offset: 0x32EDB11 VA: 0x32EDA10
	|-ReadOnlyCollection<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x32EEAE0 Offset: 0x32EEBE1 VA: 0x32EEAE0
	|-ReadOnlyCollection<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x32EFB70 Offset: 0x32EFC71 VA: 0x32EFB70
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x328F870 Offset: 0x328F971 VA: 0x328F870
	|-ReadOnlyCollection<OptionDefinition>..ctor
	|-ReadOnlyCollection<Exception>..ctor
	|-ReadOnlyCollection<Expression>..ctor
	|-ReadOnlyCollection<object>..ctor
	|-ReadOnlyCollection<ExceptionDispatchInfo>..ctor
	|-ReadOnlyCollection<TimeZoneInfo>..ctor
	|-ReadOnlyCollection<Face>..ctor
	|-ReadOnlyCollection<SharedVertex>..ctor
	|
	|-RVA: 0x32F0C40 Offset: 0x32F0D41 VA: 0x32F0C40
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x32F1DB0 Offset: 0x32F1EB1 VA: 0x32F1DB0
	|-ReadOnlyCollection<Schedule>..ctor
	|
	|-RVA: 0x32F2F20 Offset: 0x32F3021 VA: 0x32F2F20
	|-ReadOnlyCollection<CurveSample>..ctor
	|
	|-RVA: 0x32F41E0 Offset: 0x32F42E1 VA: 0x32F41E0
	|-ReadOnlyCollection<bool>..ctor
	|
	|-RVA: 0x32F5280 Offset: 0x32F5381 VA: 0x32F5280
	|-ReadOnlyCollection<byte>..ctor
	|
	|-RVA: 0x32F6310 Offset: 0x32F6411 VA: 0x32F6310
	|-ReadOnlyCollection<char>..ctor
	|
	|-RVA: 0x32F73A0 Offset: 0x32F74A1 VA: 0x32F73A0
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x32F8440 Offset: 0x32F8541 VA: 0x32F8440
	|-ReadOnlyCollection<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x32F94E0 Offset: 0x32F95E1 VA: 0x32F94E0
	|-ReadOnlyCollection<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x32FA580 Offset: 0x32FA681 VA: 0x32FA580
	|-ReadOnlyCollection<DateTime>..ctor
	|
	|-RVA: 0x32FB610 Offset: 0x32FB711 VA: 0x32FB610
	|-ReadOnlyCollection<double>..ctor
	|
	|-RVA: 0x32FC6A0 Offset: 0x32FC7A1 VA: 0x32FC6A0
	|-ReadOnlyCollection<short>..ctor
	|
	|-RVA: 0x32FD730 Offset: 0x32FD831 VA: 0x32FD730
	|-ReadOnlyCollection<int>..ctor
	|
	|-RVA: 0x32FE7C0 Offset: 0x32FE8C1 VA: 0x32FE7C0
	|-ReadOnlyCollection<Int32Enum>..ctor
	|
	|-RVA: 0x32FF850 Offset: 0x32FF951 VA: 0x32FF850
	|-ReadOnlyCollection<long>..ctor
	|
	|-RVA: 0x33008E0 Offset: 0x33009E1 VA: 0x33008E0
	|-ReadOnlyCollection<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3301980 Offset: 0x3301A81 VA: 0x3301980
	|-ReadOnlyCollection<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3302A10 Offset: 0x3302B11 VA: 0x3302A10
	|-ReadOnlyCollection<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x3303C10 Offset: 0x3303D11 VA: 0x3303C10
	|-ReadOnlyCollection<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x3304E10 Offset: 0x3304F11 VA: 0x3304E10
	|-ReadOnlyCollection<Nullable<Color32>>..ctor
	|
	|-RVA: 0x3305EA0 Offset: 0x3305FA1 VA: 0x3305EA0
	|-ReadOnlyCollection<Nullable<Color>>..ctor
	|
	|-RVA: 0x3307050 Offset: 0x3307151 VA: 0x3307050
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3308130 Offset: 0x3308231 VA: 0x3308130
	|-ReadOnlyCollection<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x33092E0 Offset: 0x33093E1 VA: 0x33092E0
	|-ReadOnlyCollection<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x3283A40 Offset: 0x3283B41 VA: 0x3283A40
	|-ReadOnlyCollection<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x3284AD0 Offset: 0x3284BD1 VA: 0x3284AD0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3285DD0 Offset: 0x3285ED1 VA: 0x3285DD0
	|-ReadOnlyCollection<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3286F80 Offset: 0x3287081 VA: 0x3286F80
	|-ReadOnlyCollection<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3288060 Offset: 0x3288161 VA: 0x3288060
	|-ReadOnlyCollection<Nullable<Rect>>..ctor
	|
	|-RVA: 0x3289210 Offset: 0x3289311 VA: 0x3289210
	|-ReadOnlyCollection<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x328A3C0 Offset: 0x328A4C1 VA: 0x328A3C0
	|-ReadOnlyCollection<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x328B4A0 Offset: 0x328B5A1 VA: 0x328B4A0
	|-ReadOnlyCollection<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x328C580 Offset: 0x328C681 VA: 0x328C580
	|-ReadOnlyCollection<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x328D620 Offset: 0x328D721 VA: 0x328D620
	|-ReadOnlyCollection<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x328E6C0 Offset: 0x328E7C1 VA: 0x328E6C0
	|-ReadOnlyCollection<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x32907D0 Offset: 0x32908D1 VA: 0x32907D0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x3291940 Offset: 0x3291A41 VA: 0x3291940
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x32929E0 Offset: 0x3292AE1 VA: 0x32929E0
	|-ReadOnlyCollection<sbyte>..ctor
	|
	|-RVA: 0x3293A70 Offset: 0x3293B71 VA: 0x3293A70
	|-ReadOnlyCollection<float>..ctor
	|
	|-RVA: 0x3294B00 Offset: 0x3294C01 VA: 0x3294B00
	|-ReadOnlyCollection<ushort>..ctor
	|
	|-RVA: 0x3295B90 Offset: 0x3295C91 VA: 0x3295B90
	|-ReadOnlyCollection<uint>..ctor
	|
	|-RVA: 0x3296C20 Offset: 0x3296D21 VA: 0x3296C20
	|-ReadOnlyCollection<ulong>..ctor
	|
	|-RVA: 0x3297CB0 Offset: 0x3297DB1 VA: 0x3297CB0
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x3298D40 Offset: 0x3298E41 VA: 0x3298D40
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3299DD0 Offset: 0x3299ED1 VA: 0x3299DD0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x329AE70 Offset: 0x329AF71 VA: 0x329AE70
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x329BF10 Offset: 0x329C011 VA: 0x329BF10
	|-ReadOnlyCollection<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x329CFB0 Offset: 0x329D0B1 VA: 0x329CFB0
	|-ReadOnlyCollection<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x329E050 Offset: 0x329E151 VA: 0x329E050
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x329F120 Offset: 0x329F221 VA: 0x329F120
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x32A0360 Offset: 0x32A0461 VA: 0x32A0360
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x32A15A0 Offset: 0x32A16A1 VA: 0x32A15A0
	|-ReadOnlyCollection<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x32A2670 Offset: 0x32A2771 VA: 0x32A2670
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x32A3710 Offset: 0x32A3811 VA: 0x32A3710
	|-ReadOnlyCollection<CapEdge>..ctor
	|
	|-RVA: 0x32A4910 Offset: 0x32A4A11 VA: 0x32A4910
	|-ReadOnlyCollection<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x32A59A0 Offset: 0x32A5AA1 VA: 0x32A59A0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x32A6B10 Offset: 0x32A6C11 VA: 0x32A6B10
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x3177B60 Offset: 0x3177C61 VA: 0x3177B60
	|-ReadOnlyCollection<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x3178C00 Offset: 0x3178D01 VA: 0x3178C00
	|-ReadOnlyCollection<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x3179FC0 Offset: 0x317A0C1 VA: 0x3179FC0
	|-ReadOnlyCollection<ConstraintSource>..ctor
	|
	|-RVA: 0x317B060 Offset: 0x317B161 VA: 0x317B060
	|-ReadOnlyCollection<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x317C0F0 Offset: 0x317C1F1 VA: 0x317C0F0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x317D190 Offset: 0x317D291 VA: 0x317D190
	|-ReadOnlyCollection<BoneWeight>..ctor
	|
	|-RVA: 0x317E300 Offset: 0x317E401 VA: 0x317E300
	|-ReadOnlyCollection<Bounds>..ctor
	|
	|-RVA: 0x317F470 Offset: 0x317F571 VA: 0x317F470
	|-ReadOnlyCollection<BoundsInt>..ctor
	|
	|-RVA: 0x31805E0 Offset: 0x31806E1 VA: 0x31805E0
	|-ReadOnlyCollection<Color32>..ctor
	|
	|-RVA: 0x31816B0 Offset: 0x31817B1 VA: 0x31816B0
	|-ReadOnlyCollection<Color>..ctor
	|
	|-RVA: 0x3182780 Offset: 0x3182881 VA: 0x3182780
	|-ReadOnlyCollection<CombineInstance>..ctor
	|
	|-RVA: 0x3183B40 Offset: 0x3183C41 VA: 0x3183B40
	|-ReadOnlyCollection<RaycastResult>..ctor
	|
	|-RVA: 0x3184E00 Offset: 0x3184F01 VA: 0x3184E00
	|-ReadOnlyCollection<GradientAlphaKey>..ctor
	|
	|-RVA: 0x3185EB0 Offset: 0x3185FB1 VA: 0x3185EB0
	|-ReadOnlyCollection<GradientColorKey>..ctor
	|
	|-RVA: 0x3187020 Offset: 0x3187121 VA: 0x3187020
	|-ReadOnlyCollection<Keyframe>..ctor
	|
	|-RVA: 0x3188200 Offset: 0x3188301 VA: 0x3188200
	|-ReadOnlyCollection<LayerMask>..ctor
	|
	|-RVA: 0x31892D0 Offset: 0x31893D1 VA: 0x31892D0
	|-ReadOnlyCollection<Matrix4x4>..ctor
	|
	|-RVA: 0x318A510 Offset: 0x318A611 VA: 0x318A510
	|-ReadOnlyCollection<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x318B6C0 Offset: 0x318B7C1 VA: 0x318B6C0
	|-ReadOnlyCollection<Playable>..ctor
	|
	|-RVA: 0x318C760 Offset: 0x318C861 VA: 0x318C760
	|-ReadOnlyCollection<PlayableBinding>..ctor
	|
	|-RVA: 0x318D8D0 Offset: 0x318D9D1 VA: 0x318D8D0
	|-ReadOnlyCollection<PlayableGraph>..ctor
	|
	|-RVA: 0x318E970 Offset: 0x318EA71 VA: 0x318E970
	|-ReadOnlyCollection<Edge>..ctor
	|
	|-RVA: 0x318FA00 Offset: 0x318FB01 VA: 0x318FA00
	|-ReadOnlyCollection<Quaternion>..ctor
	|
	|-RVA: 0x3190AD0 Offset: 0x3190BD1 VA: 0x3190AD0
	|-ReadOnlyCollection<RangeInt>..ctor
	|
	|-RVA: 0x3191B60 Offset: 0x3191C61 VA: 0x3191B60
	|-ReadOnlyCollection<RaycastHit2D>..ctor
	|
	|-RVA: 0x3192D60 Offset: 0x3192E61 VA: 0x3192D60
	|-ReadOnlyCollection<RaycastHit>..ctor
	|
	|-RVA: 0x3193FA0 Offset: 0x31940A1 VA: 0x3193FA0
	|-ReadOnlyCollection<Rect>..ctor
	|
	|-RVA: 0x3195070 Offset: 0x3195171 VA: 0x3195070
	|-ReadOnlyCollection<RectInt>..ctor
	|
	|-RVA: 0x3196110 Offset: 0x3196211 VA: 0x3196110
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x31971B0 Offset: 0x31972B1 VA: 0x31971B0
	|-ReadOnlyCollection<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x31985B0 Offset: 0x31986B1 VA: 0x31985B0
	|-ReadOnlyCollection<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3199650 Offset: 0x3199751 VA: 0x3199650
	|-ReadOnlyCollection<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x319A7C0 Offset: 0x319A8C1 VA: 0x319A7C0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x319B930 Offset: 0x319BA31 VA: 0x319B930
	|-ReadOnlyCollection<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2E82A50 Offset: 0x2E82B51 VA: 0x2E82A50
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2E83BC0 Offset: 0x2E83CC1 VA: 0x2E83BC0
	|-ReadOnlyCollection<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2E84DA0 Offset: 0x2E84EA1 VA: 0x2E84DA0
	|-ReadOnlyCollection<GlyphRect>..ctor
	|
	|-RVA: 0x2E85E40 Offset: 0x2E85F41 VA: 0x2E85E40
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x2E87020 Offset: 0x2E87121 VA: 0x2E87020
	|-ReadOnlyCollection<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2E88190 Offset: 0x2E88291 VA: 0x2E88190
	|-ReadOnlyCollection<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2E89300 Offset: 0x2E89401 VA: 0x2E89300
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2E8A470 Offset: 0x2E8A571 VA: 0x2E8A470
	|-ReadOnlyCollection<UICharInfo>..ctor
	|
	|-RVA: 0x2E8B540 Offset: 0x2E8B641 VA: 0x2E8B540
	|-ReadOnlyCollection<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2E8C5E0 Offset: 0x2E8C6E1 VA: 0x2E8C5E0
	|-ReadOnlyCollection<UILineInfo>..ctor
	|
	|-RVA: 0x2E8D680 Offset: 0x2E8D781 VA: 0x2E8D680
	|-ReadOnlyCollection<UIVertex>..ctor
	|
	|-RVA: 0x2E8E9A0 Offset: 0x2E8EAA1 VA: 0x2E8E9A0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2E8FB10 Offset: 0x2E8FC11 VA: 0x2E8FB10
	|-ReadOnlyCollection<Vector2>..ctor
	|
	|-RVA: 0x2E90BC0 Offset: 0x2E90CC1 VA: 0x2E90BC0
	|-ReadOnlyCollection<Vector2Int>..ctor
	|
	|-RVA: 0x2E91C50 Offset: 0x2E91D51 VA: 0x2E91C50
	|-ReadOnlyCollection<Vector3>..ctor
	|
	|-RVA: 0x2E92D20 Offset: 0x2E92E21 VA: 0x2E92D20
	|-ReadOnlyCollection<Vector3Int>..ctor
	|
	|-RVA: 0x2E93DF0 Offset: 0x2E93EF1 VA: 0x2E93DF0
	|-ReadOnlyCollection<Vector4>..ctor
	|
	|-RVA: 0x2E94EC0 Offset: 0x2E94FC1 VA: 0x2E94EC0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2E962C0 Offset: 0x2E963C1 VA: 0x2E962C0
	|-ReadOnlyCollection<YieldItemParam>..ctor
	|
	|-RVA: 0x2E97350 Offset: 0x2E97451 VA: 0x2E97350
	|-ReadOnlyCollection<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8AF0 Offset: 0x2EE8BF1 VA: 0x2EE8AF0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.get_Count
	|
	|-RVA: 0x2EE9C60 Offset: 0x2EE9D61 VA: 0x2EE9C60
	|-ReadOnlyCollection<BuildItemData>.get_Count
	|
	|-RVA: 0x2EEB060 Offset: 0x2EEB161 VA: 0x2EEB060
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.get_Count
	|
	|-RVA: 0x2EEC100 Offset: 0x2EEC201 VA: 0x2EEC100
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.get_Count
	|
	|-RVA: 0x2EED1A0 Offset: 0x2EED2A1 VA: 0x2EED1A0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.get_Count
	|
	|-RVA: 0x2EEE270 Offset: 0x2EEE371 VA: 0x2EEE270
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Count
	|
	|-RVA: 0x2EEF310 Offset: 0x2EEF411 VA: 0x2EEF310
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Count
	|
	|-RVA: 0x2EF03A0 Offset: 0x2EF04A1 VA: 0x2EF03A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Count
	|
	|-RVA: 0x2EF1430 Offset: 0x2EF1531 VA: 0x2EF1430
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Count
	|
	|-RVA: 0x2EF2610 Offset: 0x2EF2711 VA: 0x2EF2610
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Count
	|
	|-RVA: 0x2EF3810 Offset: 0x2EF3911 VA: 0x2EF3810
	|-ReadOnlyCollection<CropDataTable>.get_Count
	|
	|-RVA: 0x2EF49F0 Offset: 0x2EF4AF1 VA: 0x2EF49F0
	|-ReadOnlyCollection<DropItemParam>.get_Count
	|
	|-RVA: 0x2EF5A80 Offset: 0x2EF5B81 VA: 0x2EF5A80
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.get_Count
	|
	|-RVA: 0x2EF6BF0 Offset: 0x2EF6CF1 VA: 0x2EF6BF0
	|-ReadOnlyCollection<EventCheckId>.get_Count
	|
	|-RVA: 0x2EF7D60 Offset: 0x2EF7E61 VA: 0x2EF7D60
	|-ReadOnlyCollection<EventFlagProgressData>.get_Count
	|
	|-RVA: 0x2EF8E00 Offset: 0x2EF8F01 VA: 0x2EF8E00
	|-ReadOnlyCollection<FesNpcScoreData>.get_Count
	|
	|-RVA: 0x2EF9EA0 Offset: 0x2EF9FA1 VA: 0x2EF9EA0
	|-ReadOnlyCollection<MiningPointSaveData>.get_Count
	|
	|-RVA: 0x2EFB0A0 Offset: 0x2EFB1A1 VA: 0x2EFB0A0
	|-ReadOnlyCollection<MonsterHutSaveData>.get_Count
	|
	|-RVA: 0x2EFC280 Offset: 0x2EFC381 VA: 0x2EFC280
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.get_Count
	|
	|-RVA: 0x32E6150 Offset: 0x32E6251 VA: 0x32E6150
	|-ReadOnlyCollection<NPCActionData>.get_Count
	|
	|-RVA: 0x32E7390 Offset: 0x32E7491 VA: 0x32E7390
	|-ReadOnlyCollection<NpcPlaceSchedule>.get_Count
	|
	|-RVA: 0x32E8500 Offset: 0x32E8601 VA: 0x32E8500
	|-ReadOnlyCollection<OrderLotterySaveParameter>.get_Count
	|
	|-RVA: 0x32E95D0 Offset: 0x32E96D1 VA: 0x32E95D0
	|-ReadOnlyCollection<OrderSaveParameter>.get_Count
	|
	|-RVA: 0x32EA740 Offset: 0x32EA841 VA: 0x32EA740
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Count
	|
	|-RVA: 0x32EB7E0 Offset: 0x32EB8E1 VA: 0x32EB7E0
	|-ReadOnlyCollection<ShopCatalogPage>.get_Count
	|
	|-RVA: 0x32EC880 Offset: 0x32EC981 VA: 0x32EC880
	|-ReadOnlyCollection<ShopNpcTalk>.get_Count
	|
	|-RVA: 0x32EDA60 Offset: 0x32EDB61 VA: 0x32EDA60
	|-ReadOnlyCollection<SubtitleDataTable.Data>.get_Count
	|
	|-RVA: 0x32EEB30 Offset: 0x32EEC31 VA: 0x32EEB30
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.get_Count
	|
	|-RVA: 0x32EFBC0 Offset: 0x32EFCC1 VA: 0x32EFBC0
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.get_Count
	|
	|-RVA: 0x32F0C90 Offset: 0x32F0D91 VA: 0x32F0C90
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.get_Count
	|
	|-RVA: 0x32F1E00 Offset: 0x32F1F01 VA: 0x32F1E00
	|-ReadOnlyCollection<Schedule>.get_Count
	|
	|-RVA: 0x328F8C0 Offset: 0x328F9C1 VA: 0x328F8C0
	|-ReadOnlyCollection<CubicBezierCurve>.get_Count
	|-ReadOnlyCollection<Exception>.get_Count
	|-ReadOnlyCollection<CatchBlock>.get_Count
	|-ReadOnlyCollection<ElementInit>.get_Count
	|-ReadOnlyCollection<Expression>.get_Count
	|-ReadOnlyCollection<ParameterExpression>.get_Count
	|-ReadOnlyCollection<SwitchCase>.get_Count
	|-ReadOnlyCollection<object>.get_Count
	|-ReadOnlyCollection<MemberInfo>.get_Count
	|-ReadOnlyCollection<ExceptionDispatchInfo>.get_Count
	|
	|-RVA: 0x32F2F70 Offset: 0x32F3071 VA: 0x32F2F70
	|-ReadOnlyCollection<CurveSample>.get_Count
	|
	|-RVA: 0x32F4230 Offset: 0x32F4331 VA: 0x32F4230
	|-ReadOnlyCollection<bool>.get_Count
	|
	|-RVA: 0x32F52D0 Offset: 0x32F53D1 VA: 0x32F52D0
	|-ReadOnlyCollection<byte>.get_Count
	|
	|-RVA: 0x32F6360 Offset: 0x32F6461 VA: 0x32F6360
	|-ReadOnlyCollection<char>.get_Count
	|
	|-RVA: 0x32F73F0 Offset: 0x32F74F1 VA: 0x32F73F0
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.get_Count
	|
	|-RVA: 0x32F8490 Offset: 0x32F8591 VA: 0x32F8490
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Count
	|
	|-RVA: 0x32F9530 Offset: 0x32F9631 VA: 0x32F9530
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x32FA5D0 Offset: 0x32FA6D1 VA: 0x32FA5D0
	|-ReadOnlyCollection<DateTime>.get_Count
	|
	|-RVA: 0x32FB660 Offset: 0x32FB761 VA: 0x32FB660
	|-ReadOnlyCollection<double>.get_Count
	|
	|-RVA: 0x32FC6F0 Offset: 0x32FC7F1 VA: 0x32FC6F0
	|-ReadOnlyCollection<short>.get_Count
	|
	|-RVA: 0x32FD780 Offset: 0x32FD881 VA: 0x32FD780
	|-ReadOnlyCollection<int>.get_Count
	|
	|-RVA: 0x32FE810 Offset: 0x32FE911 VA: 0x32FE810
	|-ReadOnlyCollection<Int32Enum>.get_Count
	|
	|-RVA: 0x32FF8A0 Offset: 0x32FF9A1 VA: 0x32FF8A0
	|-ReadOnlyCollection<long>.get_Count
	|
	|-RVA: 0x3300930 Offset: 0x3300A31 VA: 0x3300930
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Count
	|
	|-RVA: 0x33019D0 Offset: 0x3301AD1 VA: 0x33019D0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.get_Count
	|
	|-RVA: 0x3302A60 Offset: 0x3302B61 VA: 0x3302A60
	|-ReadOnlyCollection<Nullable<Bounds>>.get_Count
	|
	|-RVA: 0x3303C60 Offset: 0x3303D61 VA: 0x3303C60
	|-ReadOnlyCollection<Nullable<BoundsInt>>.get_Count
	|
	|-RVA: 0x3304E60 Offset: 0x3304F61 VA: 0x3304E60
	|-ReadOnlyCollection<Nullable<Color32>>.get_Count
	|
	|-RVA: 0x3305EF0 Offset: 0x3305FF1 VA: 0x3305EF0
	|-ReadOnlyCollection<Nullable<Color>>.get_Count
	|
	|-RVA: 0x33070A0 Offset: 0x33071A1 VA: 0x33070A0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.get_Count
	|
	|-RVA: 0x3308180 Offset: 0x3308281 VA: 0x3308180
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.get_Count
	|
	|-RVA: 0x3309330 Offset: 0x3309431 VA: 0x3309330
	|-ReadOnlyCollection<Nullable<Keyframe>>.get_Count
	|
	|-RVA: 0x3283A90 Offset: 0x3283B91 VA: 0x3283A90
	|-ReadOnlyCollection<Nullable<LayerMask>>.get_Count
	|
	|-RVA: 0x3284B20 Offset: 0x3284C21 VA: 0x3284B20
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.get_Count
	|
	|-RVA: 0x3285E20 Offset: 0x3285F21 VA: 0x3285E20
	|-ReadOnlyCollection<Nullable<Quaternion>>.get_Count
	|
	|-RVA: 0x3286FD0 Offset: 0x32870D1 VA: 0x3286FD0
	|-ReadOnlyCollection<Nullable<RangeInt>>.get_Count
	|
	|-RVA: 0x32880B0 Offset: 0x32881B1 VA: 0x32880B0
	|-ReadOnlyCollection<Nullable<Rect>>.get_Count
	|
	|-RVA: 0x3289260 Offset: 0x3289361 VA: 0x3289260
	|-ReadOnlyCollection<Nullable<RectInt>>.get_Count
	|
	|-RVA: 0x328A410 Offset: 0x328A511 VA: 0x328A410
	|-ReadOnlyCollection<Nullable<Vector2>>.get_Count
	|
	|-RVA: 0x328B4F0 Offset: 0x328B5F1 VA: 0x328B4F0
	|-ReadOnlyCollection<Nullable<Vector2Int>>.get_Count
	|
	|-RVA: 0x328C5D0 Offset: 0x328C6D1 VA: 0x328C5D0
	|-ReadOnlyCollection<Nullable<Vector3>>.get_Count
	|
	|-RVA: 0x328D670 Offset: 0x328D771 VA: 0x328D670
	|-ReadOnlyCollection<Nullable<Vector3Int>>.get_Count
	|
	|-RVA: 0x328E710 Offset: 0x328E811 VA: 0x328E710
	|-ReadOnlyCollection<Nullable<Vector4>>.get_Count
	|
	|-RVA: 0x3290820 Offset: 0x3290921 VA: 0x3290820
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|
	|-RVA: 0x3291990 Offset: 0x3291A91 VA: 0x3291990
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|
	|-RVA: 0x3292A30 Offset: 0x3292B31 VA: 0x3292A30
	|-ReadOnlyCollection<sbyte>.get_Count
	|
	|-RVA: 0x3293AC0 Offset: 0x3293BC1 VA: 0x3293AC0
	|-ReadOnlyCollection<float>.get_Count
	|
	|-RVA: 0x3294B50 Offset: 0x3294C51 VA: 0x3294B50
	|-ReadOnlyCollection<ushort>.get_Count
	|
	|-RVA: 0x3295BE0 Offset: 0x3295CE1 VA: 0x3295BE0
	|-ReadOnlyCollection<uint>.get_Count
	|
	|-RVA: 0x3296C70 Offset: 0x3296D71 VA: 0x3296C70
	|-ReadOnlyCollection<ulong>.get_Count
	|
	|-RVA: 0x3297D00 Offset: 0x3297E01 VA: 0x3297D00
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.get_Count
	|
	|-RVA: 0x3298D90 Offset: 0x3298E91 VA: 0x3298D90
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x3299E20 Offset: 0x3299F21 VA: 0x3299E20
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.get_Count
	|
	|-RVA: 0x329AEC0 Offset: 0x329AFC1 VA: 0x329AEC0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.get_Count
	|
	|-RVA: 0x329BF60 Offset: 0x329C061 VA: 0x329BF60
	|-ReadOnlyCollection<ValueTuple<object, object>>.get_Count
	|
	|-RVA: 0x329D000 Offset: 0x329D101 VA: 0x329D000
	|-ReadOnlyCollection<ValueTuple<object, float>>.get_Count
	|
	|-RVA: 0x329E0A0 Offset: 0x329E1A1 VA: 0x329E0A0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Count
	|
	|-RVA: 0x329F170 Offset: 0x329F271 VA: 0x329F170
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Count
	|
	|-RVA: 0x32A03B0 Offset: 0x32A04B1 VA: 0x32A03B0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Count
	|
	|-RVA: 0x32A15F0 Offset: 0x32A16F1 VA: 0x32A15F0
	|-ReadOnlyCollection<TutorialUnlockFlagData>.get_Count
	|
	|-RVA: 0x32A26C0 Offset: 0x32A27C1 VA: 0x32A26C0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.get_Count
	|
	|-RVA: 0x32A3760 Offset: 0x32A3861 VA: 0x32A3760
	|-ReadOnlyCollection<CapEdge>.get_Count
	|
	|-RVA: 0x32A4960 Offset: 0x32A4A61 VA: 0x32A4960
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.get_Count
	|
	|-RVA: 0x32A59F0 Offset: 0x32A5AF1 VA: 0x32A59F0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.get_Count
	|
	|-RVA: 0x32A6B60 Offset: 0x32A6C61 VA: 0x32A6B60
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.get_Count
	|
	|-RVA: 0x3177BB0 Offset: 0x3177CB1 VA: 0x3177BB0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.get_Count
	|
	|-RVA: 0x3178C50 Offset: 0x3178D51 VA: 0x3178C50
	|-ReadOnlyCollection<NavMeshBuildSource>.get_Count
	|
	|-RVA: 0x317A010 Offset: 0x317A111 VA: 0x317A010
	|-ReadOnlyCollection<ConstraintSource>.get_Count
	|
	|-RVA: 0x317B0B0 Offset: 0x317B1B1 VA: 0x317B0B0
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Count
	|
	|-RVA: 0x317C140 Offset: 0x317C241 VA: 0x317C140
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Count
	|
	|-RVA: 0x317D1E0 Offset: 0x317D2E1 VA: 0x317D1E0
	|-ReadOnlyCollection<BoneWeight>.get_Count
	|
	|-RVA: 0x317E350 Offset: 0x317E451 VA: 0x317E350
	|-ReadOnlyCollection<Bounds>.get_Count
	|
	|-RVA: 0x317F4C0 Offset: 0x317F5C1 VA: 0x317F4C0
	|-ReadOnlyCollection<BoundsInt>.get_Count
	|
	|-RVA: 0x3180630 Offset: 0x3180731 VA: 0x3180630
	|-ReadOnlyCollection<Color32>.get_Count
	|
	|-RVA: 0x3181700 Offset: 0x3181801 VA: 0x3181700
	|-ReadOnlyCollection<Color>.get_Count
	|
	|-RVA: 0x31827D0 Offset: 0x31828D1 VA: 0x31827D0
	|-ReadOnlyCollection<CombineInstance>.get_Count
	|
	|-RVA: 0x3183B90 Offset: 0x3183C91 VA: 0x3183B90
	|-ReadOnlyCollection<RaycastResult>.get_Count
	|
	|-RVA: 0x3184E50 Offset: 0x3184F51 VA: 0x3184E50
	|-ReadOnlyCollection<GradientAlphaKey>.get_Count
	|
	|-RVA: 0x3185F00 Offset: 0x3186001 VA: 0x3185F00
	|-ReadOnlyCollection<GradientColorKey>.get_Count
	|
	|-RVA: 0x3187070 Offset: 0x3187171 VA: 0x3187070
	|-ReadOnlyCollection<Keyframe>.get_Count
	|
	|-RVA: 0x3188250 Offset: 0x3188351 VA: 0x3188250
	|-ReadOnlyCollection<LayerMask>.get_Count
	|
	|-RVA: 0x3189320 Offset: 0x3189421 VA: 0x3189320
	|-ReadOnlyCollection<Matrix4x4>.get_Count
	|
	|-RVA: 0x318A560 Offset: 0x318A661 VA: 0x318A560
	|-ReadOnlyCollection<ParticleSystem.Particle>.get_Count
	|
	|-RVA: 0x318B710 Offset: 0x318B811 VA: 0x318B710
	|-ReadOnlyCollection<Playable>.get_Count
	|
	|-RVA: 0x318C7B0 Offset: 0x318C8B1 VA: 0x318C7B0
	|-ReadOnlyCollection<PlayableBinding>.get_Count
	|
	|-RVA: 0x318D920 Offset: 0x318DA21 VA: 0x318D920
	|-ReadOnlyCollection<PlayableGraph>.get_Count
	|
	|-RVA: 0x318E9C0 Offset: 0x318EAC1 VA: 0x318E9C0
	|-ReadOnlyCollection<Edge>.get_Count
	|
	|-RVA: 0x318FA50 Offset: 0x318FB51 VA: 0x318FA50
	|-ReadOnlyCollection<Quaternion>.get_Count
	|
	|-RVA: 0x3190B20 Offset: 0x3190C21 VA: 0x3190B20
	|-ReadOnlyCollection<RangeInt>.get_Count
	|
	|-RVA: 0x3191BB0 Offset: 0x3191CB1 VA: 0x3191BB0
	|-ReadOnlyCollection<RaycastHit2D>.get_Count
	|
	|-RVA: 0x3192DB0 Offset: 0x3192EB1 VA: 0x3192DB0
	|-ReadOnlyCollection<RaycastHit>.get_Count
	|
	|-RVA: 0x3193FF0 Offset: 0x31940F1 VA: 0x3193FF0
	|-ReadOnlyCollection<Rect>.get_Count
	|
	|-RVA: 0x31950C0 Offset: 0x31951C1 VA: 0x31950C0
	|-ReadOnlyCollection<RectInt>.get_Count
	|
	|-RVA: 0x3196160 Offset: 0x3196261 VA: 0x3196160
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.get_Count
	|
	|-RVA: 0x3197200 Offset: 0x3197301 VA: 0x3197200
	|-ReadOnlyCollection<SphericalHarmonicsL2>.get_Count
	|
	|-RVA: 0x3198600 Offset: 0x3198701 VA: 0x3198600
	|-ReadOnlyCollection<VertexAttributeDescriptor>.get_Count
	|
	|-RVA: 0x31996A0 Offset: 0x31997A1 VA: 0x31996A0
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x319A810 Offset: 0x319A911 VA: 0x319A810
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.get_Count
	|
	|-RVA: 0x319B980 Offset: 0x319BA81 VA: 0x319B980
	|-ReadOnlyCollection<DiagnosticEvent>.get_Count
	|
	|-RVA: 0x2E82AA0 Offset: 0x2E82BA1 VA: 0x2E82AA0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Count
	|
	|-RVA: 0x2E83C10 Offset: 0x2E83D11 VA: 0x2E83C10
	|-ReadOnlyCollection<ObjectInitializationData>.get_Count
	|
	|-RVA: 0x2E84DF0 Offset: 0x2E84EF1 VA: 0x2E84DF0
	|-ReadOnlyCollection<GlyphRect>.get_Count
	|
	|-RVA: 0x2E85E90 Offset: 0x2E85F91 VA: 0x2E85E90
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Count
	|
	|-RVA: 0x2E87070 Offset: 0x2E87171 VA: 0x2E87070
	|-ReadOnlyCollection<IntervalTreeNode>.get_Count
	|
	|-RVA: 0x2E881E0 Offset: 0x2E882E1 VA: 0x2E881E0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Count
	|
	|-RVA: 0x2E89350 Offset: 0x2E89451 VA: 0x2E89350
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Count
	|
	|-RVA: 0x2E8A4C0 Offset: 0x2E8A5C1 VA: 0x2E8A4C0
	|-ReadOnlyCollection<UICharInfo>.get_Count
	|
	|-RVA: 0x2E8B590 Offset: 0x2E8B691 VA: 0x2E8B590
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Count
	|
	|-RVA: 0x2E8C630 Offset: 0x2E8C731 VA: 0x2E8C630
	|-ReadOnlyCollection<UILineInfo>.get_Count
	|
	|-RVA: 0x2E8D6D0 Offset: 0x2E8D7D1 VA: 0x2E8D6D0
	|-ReadOnlyCollection<UIVertex>.get_Count
	|
	|-RVA: 0x2E8E9F0 Offset: 0x2E8EAF1 VA: 0x2E8E9F0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Count
	|
	|-RVA: 0x2E8FB60 Offset: 0x2E8FC61 VA: 0x2E8FB60
	|-ReadOnlyCollection<Vector2>.get_Count
	|
	|-RVA: 0x2E90C10 Offset: 0x2E90D11 VA: 0x2E90C10
	|-ReadOnlyCollection<Vector2Int>.get_Count
	|
	|-RVA: 0x2E91CA0 Offset: 0x2E91DA1 VA: 0x2E91CA0
	|-ReadOnlyCollection<Vector3>.get_Count
	|
	|-RVA: 0x2E92D70 Offset: 0x2E92E71 VA: 0x2E92D70
	|-ReadOnlyCollection<Vector3Int>.get_Count
	|
	|-RVA: 0x2E93E40 Offset: 0x2E93F41 VA: 0x2E93E40
	|-ReadOnlyCollection<Vector4>.get_Count
	|
	|-RVA: 0x2E94F10 Offset: 0x2E95011 VA: 0x2E94F10
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.get_Count
	|
	|-RVA: 0x2E96310 Offset: 0x2E96411 VA: 0x2E96310
	|-ReadOnlyCollection<YieldItemParam>.get_Count
	|
	|-RVA: 0x2E973A0 Offset: 0x2E974A1 VA: 0x2E973A0
	|-ReadOnlyCollection<stCommand_t>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328F960 Offset: 0x328FA61 VA: 0x328F960
	|-ReadOnlyCollection<CubicBezierCurve>.get_Item
	|-ReadOnlyCollection<ElementInit>.get_Item
	|-ReadOnlyCollection<Expression>.get_Item
	|-ReadOnlyCollection<ParameterExpression>.get_Item
	|-ReadOnlyCollection<SwitchCase>.get_Item
	|-ReadOnlyCollection<MemberInfo>.get_Item
	|-ReadOnlyCollection<Exception>.get_Item
	|-ReadOnlyCollection<object>.get_Item
	|-ReadOnlyCollection<ExceptionDispatchInfo>.get_Item
	|
	|-RVA: 0x2EE8B90 Offset: 0x2EE8C91 VA: 0x2EE8B90
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.get_Item
	|
	|-RVA: 0x2EE9D00 Offset: 0x2EE9E01 VA: 0x2EE9D00
	|-ReadOnlyCollection<BuildItemData>.get_Item
	|
	|-RVA: 0x2EEB100 Offset: 0x2EEB201 VA: 0x2EEB100
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.get_Item
	|
	|-RVA: 0x2EEC1A0 Offset: 0x2EEC2A1 VA: 0x2EEC1A0
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.get_Item
	|
	|-RVA: 0x2EED240 Offset: 0x2EED341 VA: 0x2EED240
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.get_Item
	|
	|-RVA: 0x2EEE310 Offset: 0x2EEE411 VA: 0x2EEE310
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Item
	|
	|-RVA: 0x2EEF3B0 Offset: 0x2EEF4B1 VA: 0x2EEF3B0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Item
	|
	|-RVA: 0x2EF0440 Offset: 0x2EF0541 VA: 0x2EF0440
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Item
	|
	|-RVA: 0x2EF14D0 Offset: 0x2EF15D1 VA: 0x2EF14D0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Item
	|
	|-RVA: 0x2EF26B0 Offset: 0x2EF27B1 VA: 0x2EF26B0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Item
	|
	|-RVA: 0x2EF38B0 Offset: 0x2EF39B1 VA: 0x2EF38B0
	|-ReadOnlyCollection<CropDataTable>.get_Item
	|
	|-RVA: 0x2EF4A90 Offset: 0x2EF4B91 VA: 0x2EF4A90
	|-ReadOnlyCollection<DropItemParam>.get_Item
	|
	|-RVA: 0x2EF5B20 Offset: 0x2EF5C21 VA: 0x2EF5B20
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.get_Item
	|
	|-RVA: 0x2EF6C90 Offset: 0x2EF6D91 VA: 0x2EF6C90
	|-ReadOnlyCollection<EventCheckId>.get_Item
	|
	|-RVA: 0x2EF7E00 Offset: 0x2EF7F01 VA: 0x2EF7E00
	|-ReadOnlyCollection<EventFlagProgressData>.get_Item
	|
	|-RVA: 0x2EF8EA0 Offset: 0x2EF8FA1 VA: 0x2EF8EA0
	|-ReadOnlyCollection<FesNpcScoreData>.get_Item
	|
	|-RVA: 0x2EF9F40 Offset: 0x2EFA041 VA: 0x2EF9F40
	|-ReadOnlyCollection<MiningPointSaveData>.get_Item
	|
	|-RVA: 0x2EFB140 Offset: 0x2EFB241 VA: 0x2EFB140
	|-ReadOnlyCollection<MonsterHutSaveData>.get_Item
	|
	|-RVA: 0x2EFC320 Offset: 0x2EFC421 VA: 0x2EFC320
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.get_Item
	|
	|-RVA: 0x32E61F0 Offset: 0x32E62F1 VA: 0x32E61F0
	|-ReadOnlyCollection<NPCActionData>.get_Item
	|
	|-RVA: 0x32E7430 Offset: 0x32E7531 VA: 0x32E7430
	|-ReadOnlyCollection<NpcPlaceSchedule>.get_Item
	|
	|-RVA: 0x32E85A0 Offset: 0x32E86A1 VA: 0x32E85A0
	|-ReadOnlyCollection<OrderLotterySaveParameter>.get_Item
	|
	|-RVA: 0x32E9670 Offset: 0x32E9771 VA: 0x32E9670
	|-ReadOnlyCollection<OrderSaveParameter>.get_Item
	|
	|-RVA: 0x32EA7E0 Offset: 0x32EA8E1 VA: 0x32EA7E0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Item
	|
	|-RVA: 0x32EB880 Offset: 0x32EB981 VA: 0x32EB880
	|-ReadOnlyCollection<ShopCatalogPage>.get_Item
	|
	|-RVA: 0x32EC920 Offset: 0x32ECA21 VA: 0x32EC920
	|-ReadOnlyCollection<ShopNpcTalk>.get_Item
	|
	|-RVA: 0x32EDB00 Offset: 0x32EDC01 VA: 0x32EDB00
	|-ReadOnlyCollection<SubtitleDataTable.Data>.get_Item
	|
	|-RVA: 0x32EEBD0 Offset: 0x32EECD1 VA: 0x32EEBD0
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.get_Item
	|
	|-RVA: 0x32EFC60 Offset: 0x32EFD61 VA: 0x32EFC60
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.get_Item
	|
	|-RVA: 0x32F0D30 Offset: 0x32F0E31 VA: 0x32F0D30
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.get_Item
	|
	|-RVA: 0x32F1EA0 Offset: 0x32F1FA1 VA: 0x32F1EA0
	|-ReadOnlyCollection<Schedule>.get_Item
	|
	|-RVA: 0x32F3010 Offset: 0x32F3111 VA: 0x32F3010
	|-ReadOnlyCollection<CurveSample>.get_Item
	|
	|-RVA: 0x32F42D0 Offset: 0x32F43D1 VA: 0x32F42D0
	|-ReadOnlyCollection<bool>.get_Item
	|
	|-RVA: 0x32F5370 Offset: 0x32F5471 VA: 0x32F5370
	|-ReadOnlyCollection<byte>.get_Item
	|
	|-RVA: 0x32F6400 Offset: 0x32F6501 VA: 0x32F6400
	|-ReadOnlyCollection<char>.get_Item
	|
	|-RVA: 0x32F7490 Offset: 0x32F7591 VA: 0x32F7490
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.get_Item
	|
	|-RVA: 0x32F8530 Offset: 0x32F8631 VA: 0x32F8530
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Item
	|
	|-RVA: 0x32F95D0 Offset: 0x32F96D1 VA: 0x32F95D0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x32FA670 Offset: 0x32FA771 VA: 0x32FA670
	|-ReadOnlyCollection<DateTime>.get_Item
	|
	|-RVA: 0x32FB700 Offset: 0x32FB801 VA: 0x32FB700
	|-ReadOnlyCollection<double>.get_Item
	|
	|-RVA: 0x32FC790 Offset: 0x32FC891 VA: 0x32FC790
	|-ReadOnlyCollection<short>.get_Item
	|
	|-RVA: 0x32FD820 Offset: 0x32FD921 VA: 0x32FD820
	|-ReadOnlyCollection<int>.get_Item
	|
	|-RVA: 0x32FE8B0 Offset: 0x32FE9B1 VA: 0x32FE8B0
	|-ReadOnlyCollection<Int32Enum>.get_Item
	|
	|-RVA: 0x32FF940 Offset: 0x32FFA41 VA: 0x32FF940
	|-ReadOnlyCollection<long>.get_Item
	|
	|-RVA: 0x33009D0 Offset: 0x3300AD1 VA: 0x33009D0
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Item
	|
	|-RVA: 0x3301A70 Offset: 0x3301B71 VA: 0x3301A70
	|-ReadOnlyCollection<Nullable<Int32Enum>>.get_Item
	|
	|-RVA: 0x3302B00 Offset: 0x3302C01 VA: 0x3302B00
	|-ReadOnlyCollection<Nullable<Bounds>>.get_Item
	|
	|-RVA: 0x3303D00 Offset: 0x3303E01 VA: 0x3303D00
	|-ReadOnlyCollection<Nullable<BoundsInt>>.get_Item
	|
	|-RVA: 0x3304F00 Offset: 0x3305001 VA: 0x3304F00
	|-ReadOnlyCollection<Nullable<Color32>>.get_Item
	|
	|-RVA: 0x3305F90 Offset: 0x3306091 VA: 0x3305F90
	|-ReadOnlyCollection<Nullable<Color>>.get_Item
	|
	|-RVA: 0x3307140 Offset: 0x3307241 VA: 0x3307140
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.get_Item
	|
	|-RVA: 0x3308220 Offset: 0x3308321 VA: 0x3308220
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.get_Item
	|
	|-RVA: 0x33093D0 Offset: 0x33094D1 VA: 0x33093D0
	|-ReadOnlyCollection<Nullable<Keyframe>>.get_Item
	|
	|-RVA: 0x3283B30 Offset: 0x3283C31 VA: 0x3283B30
	|-ReadOnlyCollection<Nullable<LayerMask>>.get_Item
	|
	|-RVA: 0x3284BC0 Offset: 0x3284CC1 VA: 0x3284BC0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.get_Item
	|
	|-RVA: 0x3285EC0 Offset: 0x3285FC1 VA: 0x3285EC0
	|-ReadOnlyCollection<Nullable<Quaternion>>.get_Item
	|
	|-RVA: 0x3287070 Offset: 0x3287171 VA: 0x3287070
	|-ReadOnlyCollection<Nullable<RangeInt>>.get_Item
	|
	|-RVA: 0x3288150 Offset: 0x3288251 VA: 0x3288150
	|-ReadOnlyCollection<Nullable<Rect>>.get_Item
	|
	|-RVA: 0x3289300 Offset: 0x3289401 VA: 0x3289300
	|-ReadOnlyCollection<Nullable<RectInt>>.get_Item
	|
	|-RVA: 0x328A4B0 Offset: 0x328A5B1 VA: 0x328A4B0
	|-ReadOnlyCollection<Nullable<Vector2>>.get_Item
	|
	|-RVA: 0x328B590 Offset: 0x328B691 VA: 0x328B590
	|-ReadOnlyCollection<Nullable<Vector2Int>>.get_Item
	|
	|-RVA: 0x328C670 Offset: 0x328C771 VA: 0x328C670
	|-ReadOnlyCollection<Nullable<Vector3>>.get_Item
	|
	|-RVA: 0x328D710 Offset: 0x328D811 VA: 0x328D710
	|-ReadOnlyCollection<Nullable<Vector3Int>>.get_Item
	|
	|-RVA: 0x328E7B0 Offset: 0x328E8B1 VA: 0x328E7B0
	|-ReadOnlyCollection<Nullable<Vector4>>.get_Item
	|
	|-RVA: 0x32908C0 Offset: 0x32909C1 VA: 0x32908C0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|
	|-RVA: 0x3291A30 Offset: 0x3291B31 VA: 0x3291A30
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|
	|-RVA: 0x3292AD0 Offset: 0x3292BD1 VA: 0x3292AD0
	|-ReadOnlyCollection<sbyte>.get_Item
	|
	|-RVA: 0x3293B60 Offset: 0x3293C61 VA: 0x3293B60
	|-ReadOnlyCollection<float>.get_Item
	|
	|-RVA: 0x3294BF0 Offset: 0x3294CF1 VA: 0x3294BF0
	|-ReadOnlyCollection<ushort>.get_Item
	|
	|-RVA: 0x3295C80 Offset: 0x3295D81 VA: 0x3295C80
	|-ReadOnlyCollection<uint>.get_Item
	|
	|-RVA: 0x3296D10 Offset: 0x3296E11 VA: 0x3296D10
	|-ReadOnlyCollection<ulong>.get_Item
	|
	|-RVA: 0x3297DA0 Offset: 0x3297EA1 VA: 0x3297DA0
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.get_Item
	|
	|-RVA: 0x3298E30 Offset: 0x3298F31 VA: 0x3298E30
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.get_Item
	|
	|-RVA: 0x3299EC0 Offset: 0x3299FC1 VA: 0x3299EC0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.get_Item
	|
	|-RVA: 0x329AF60 Offset: 0x329B061 VA: 0x329AF60
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.get_Item
	|
	|-RVA: 0x329C000 Offset: 0x329C101 VA: 0x329C000
	|-ReadOnlyCollection<ValueTuple<object, object>>.get_Item
	|
	|-RVA: 0x329D0A0 Offset: 0x329D1A1 VA: 0x329D0A0
	|-ReadOnlyCollection<ValueTuple<object, float>>.get_Item
	|
	|-RVA: 0x329E140 Offset: 0x329E241 VA: 0x329E140
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Item
	|
	|-RVA: 0x329F210 Offset: 0x329F311 VA: 0x329F210
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Item
	|
	|-RVA: 0x32A0450 Offset: 0x32A0551 VA: 0x32A0450
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Item
	|
	|-RVA: 0x32A1690 Offset: 0x32A1791 VA: 0x32A1690
	|-ReadOnlyCollection<TutorialUnlockFlagData>.get_Item
	|
	|-RVA: 0x32A2760 Offset: 0x32A2861 VA: 0x32A2760
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.get_Item
	|
	|-RVA: 0x32A3800 Offset: 0x32A3901 VA: 0x32A3800
	|-ReadOnlyCollection<CapEdge>.get_Item
	|
	|-RVA: 0x32A4A00 Offset: 0x32A4B01 VA: 0x32A4A00
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.get_Item
	|
	|-RVA: 0x32A5A90 Offset: 0x32A5B91 VA: 0x32A5A90
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.get_Item
	|
	|-RVA: 0x32A6C00 Offset: 0x32A6D01 VA: 0x32A6C00
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.get_Item
	|
	|-RVA: 0x3177C50 Offset: 0x3177D51 VA: 0x3177C50
	|-ReadOnlyCollection<NavMeshBuildMarkup>.get_Item
	|
	|-RVA: 0x3178CF0 Offset: 0x3178DF1 VA: 0x3178CF0
	|-ReadOnlyCollection<NavMeshBuildSource>.get_Item
	|
	|-RVA: 0x317A0B0 Offset: 0x317A1B1 VA: 0x317A0B0
	|-ReadOnlyCollection<ConstraintSource>.get_Item
	|
	|-RVA: 0x317B150 Offset: 0x317B251 VA: 0x317B150
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Item
	|
	|-RVA: 0x317C1E0 Offset: 0x317C2E1 VA: 0x317C1E0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Item
	|
	|-RVA: 0x317D280 Offset: 0x317D381 VA: 0x317D280
	|-ReadOnlyCollection<BoneWeight>.get_Item
	|
	|-RVA: 0x317E3F0 Offset: 0x317E4F1 VA: 0x317E3F0
	|-ReadOnlyCollection<Bounds>.get_Item
	|
	|-RVA: 0x317F560 Offset: 0x317F661 VA: 0x317F560
	|-ReadOnlyCollection<BoundsInt>.get_Item
	|
	|-RVA: 0x31806D0 Offset: 0x31807D1 VA: 0x31806D0
	|-ReadOnlyCollection<Color32>.get_Item
	|
	|-RVA: 0x31817A0 Offset: 0x31818A1 VA: 0x31817A0
	|-ReadOnlyCollection<Color>.get_Item
	|
	|-RVA: 0x3182870 Offset: 0x3182971 VA: 0x3182870
	|-ReadOnlyCollection<CombineInstance>.get_Item
	|
	|-RVA: 0x3183C30 Offset: 0x3183D31 VA: 0x3183C30
	|-ReadOnlyCollection<RaycastResult>.get_Item
	|
	|-RVA: 0x3184EF0 Offset: 0x3184FF1 VA: 0x3184EF0
	|-ReadOnlyCollection<GradientAlphaKey>.get_Item
	|
	|-RVA: 0x3185FA0 Offset: 0x31860A1 VA: 0x3185FA0
	|-ReadOnlyCollection<GradientColorKey>.get_Item
	|
	|-RVA: 0x3187110 Offset: 0x3187211 VA: 0x3187110
	|-ReadOnlyCollection<Keyframe>.get_Item
	|
	|-RVA: 0x31882F0 Offset: 0x31883F1 VA: 0x31882F0
	|-ReadOnlyCollection<LayerMask>.get_Item
	|
	|-RVA: 0x31893C0 Offset: 0x31894C1 VA: 0x31893C0
	|-ReadOnlyCollection<Matrix4x4>.get_Item
	|
	|-RVA: 0x318A600 Offset: 0x318A701 VA: 0x318A600
	|-ReadOnlyCollection<ParticleSystem.Particle>.get_Item
	|
	|-RVA: 0x318B7B0 Offset: 0x318B8B1 VA: 0x318B7B0
	|-ReadOnlyCollection<Playable>.get_Item
	|
	|-RVA: 0x318C850 Offset: 0x318C951 VA: 0x318C850
	|-ReadOnlyCollection<PlayableBinding>.get_Item
	|
	|-RVA: 0x318D9C0 Offset: 0x318DAC1 VA: 0x318D9C0
	|-ReadOnlyCollection<PlayableGraph>.get_Item
	|
	|-RVA: 0x318EA60 Offset: 0x318EB61 VA: 0x318EA60
	|-ReadOnlyCollection<Edge>.get_Item
	|
	|-RVA: 0x318FAF0 Offset: 0x318FBF1 VA: 0x318FAF0
	|-ReadOnlyCollection<Quaternion>.get_Item
	|
	|-RVA: 0x3190BC0 Offset: 0x3190CC1 VA: 0x3190BC0
	|-ReadOnlyCollection<RangeInt>.get_Item
	|
	|-RVA: 0x3191C50 Offset: 0x3191D51 VA: 0x3191C50
	|-ReadOnlyCollection<RaycastHit2D>.get_Item
	|
	|-RVA: 0x3192E50 Offset: 0x3192F51 VA: 0x3192E50
	|-ReadOnlyCollection<RaycastHit>.get_Item
	|
	|-RVA: 0x3194090 Offset: 0x3194191 VA: 0x3194090
	|-ReadOnlyCollection<Rect>.get_Item
	|
	|-RVA: 0x3195160 Offset: 0x3195261 VA: 0x3195160
	|-ReadOnlyCollection<RectInt>.get_Item
	|
	|-RVA: 0x3196200 Offset: 0x3196301 VA: 0x3196200
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.get_Item
	|
	|-RVA: 0x31972A0 Offset: 0x31973A1 VA: 0x31972A0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.get_Item
	|
	|-RVA: 0x31986A0 Offset: 0x31987A1 VA: 0x31986A0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0x3199740 Offset: 0x3199841 VA: 0x3199740
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x319A8B0 Offset: 0x319A9B1 VA: 0x319A8B0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.get_Item
	|
	|-RVA: 0x319BA20 Offset: 0x319BB21 VA: 0x319BA20
	|-ReadOnlyCollection<DiagnosticEvent>.get_Item
	|
	|-RVA: 0x2E82B40 Offset: 0x2E82C41 VA: 0x2E82B40
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Item
	|
	|-RVA: 0x2E83CB0 Offset: 0x2E83DB1 VA: 0x2E83CB0
	|-ReadOnlyCollection<ObjectInitializationData>.get_Item
	|
	|-RVA: 0x2E84E90 Offset: 0x2E84F91 VA: 0x2E84E90
	|-ReadOnlyCollection<GlyphRect>.get_Item
	|
	|-RVA: 0x2E85F30 Offset: 0x2E86031 VA: 0x2E85F30
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Item
	|
	|-RVA: 0x2E87110 Offset: 0x2E87211 VA: 0x2E87110
	|-ReadOnlyCollection<IntervalTreeNode>.get_Item
	|
	|-RVA: 0x2E88280 Offset: 0x2E88381 VA: 0x2E88280
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Item
	|
	|-RVA: 0x2E893F0 Offset: 0x2E894F1 VA: 0x2E893F0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Item
	|
	|-RVA: 0x2E8A560 Offset: 0x2E8A661 VA: 0x2E8A560
	|-ReadOnlyCollection<UICharInfo>.get_Item
	|
	|-RVA: 0x2E8B630 Offset: 0x2E8B731 VA: 0x2E8B630
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Item
	|
	|-RVA: 0x2E8C6D0 Offset: 0x2E8C7D1 VA: 0x2E8C6D0
	|-ReadOnlyCollection<UILineInfo>.get_Item
	|
	|-RVA: 0x2E8D770 Offset: 0x2E8D871 VA: 0x2E8D770
	|-ReadOnlyCollection<UIVertex>.get_Item
	|
	|-RVA: 0x2E8EA90 Offset: 0x2E8EB91 VA: 0x2E8EA90
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Item
	|
	|-RVA: 0x2E8FC00 Offset: 0x2E8FD01 VA: 0x2E8FC00
	|-ReadOnlyCollection<Vector2>.get_Item
	|
	|-RVA: 0x2E90CB0 Offset: 0x2E90DB1 VA: 0x2E90CB0
	|-ReadOnlyCollection<Vector2Int>.get_Item
	|
	|-RVA: 0x2E91D40 Offset: 0x2E91E41 VA: 0x2E91D40
	|-ReadOnlyCollection<Vector3>.get_Item
	|
	|-RVA: 0x2E92E10 Offset: 0x2E92F11 VA: 0x2E92E10
	|-ReadOnlyCollection<Vector3Int>.get_Item
	|
	|-RVA: 0x2E93EE0 Offset: 0x2E93FE1 VA: 0x2E93EE0
	|-ReadOnlyCollection<Vector4>.get_Item
	|
	|-RVA: 0x2E94FB0 Offset: 0x2E950B1 VA: 0x2E94FB0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.get_Item
	|
	|-RVA: 0x2E963B0 Offset: 0x2E964B1 VA: 0x2E963B0
	|-ReadOnlyCollection<YieldItemParam>.get_Item
	|
	|-RVA: 0x2E97440 Offset: 0x2E97541 VA: 0x2E97440
	|-ReadOnlyCollection<stCommand_t>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8C60 Offset: 0x2EE8D61 VA: 0x2EE8C60
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.Contains
	|
	|-RVA: 0x2EE9E00 Offset: 0x2EE9F01 VA: 0x2EE9E00
	|-ReadOnlyCollection<BuildItemData>.Contains
	|
	|-RVA: 0x2EEB1B0 Offset: 0x2EEB2B1 VA: 0x2EEB1B0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.Contains
	|
	|-RVA: 0x2EEC250 Offset: 0x2EEC351 VA: 0x2EEC250
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.Contains
	|
	|-RVA: 0x2EED300 Offset: 0x2EED401 VA: 0x2EED300
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.Contains
	|
	|-RVA: 0x2EEE3C0 Offset: 0x2EEE4C1 VA: 0x2EEE3C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.Contains
	|
	|-RVA: 0x2EEF460 Offset: 0x2EEF561 VA: 0x2EEF460
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.Contains
	|
	|-RVA: 0x2EF04F0 Offset: 0x2EF05F1 VA: 0x2EF04F0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.Contains
	|
	|-RVA: 0x2EF15B0 Offset: 0x2EF16B1 VA: 0x2EF15B0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.Contains
	|
	|-RVA: 0x2EF2790 Offset: 0x2EF2891 VA: 0x2EF2790
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.Contains
	|
	|-RVA: 0x2EF3990 Offset: 0x2EF3A91 VA: 0x2EF3990
	|-ReadOnlyCollection<CropDataTable>.Contains
	|
	|-RVA: 0x2EF4B40 Offset: 0x2EF4C41 VA: 0x2EF4B40
	|-ReadOnlyCollection<DropItemParam>.Contains
	|
	|-RVA: 0x2EF5BF0 Offset: 0x2EF5CF1 VA: 0x2EF5BF0
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.Contains
	|
	|-RVA: 0x2EF6D60 Offset: 0x2EF6E61 VA: 0x2EF6D60
	|-ReadOnlyCollection<EventCheckId>.Contains
	|
	|-RVA: 0x2EF7EB0 Offset: 0x2EF7FB1 VA: 0x2EF7EB0
	|-ReadOnlyCollection<EventFlagProgressData>.Contains
	|
	|-RVA: 0x2EF8F50 Offset: 0x2EF9051 VA: 0x2EF8F50
	|-ReadOnlyCollection<FesNpcScoreData>.Contains
	|
	|-RVA: 0x2EFA020 Offset: 0x2EFA121 VA: 0x2EFA020
	|-ReadOnlyCollection<MiningPointSaveData>.Contains
	|
	|-RVA: 0x2EFB220 Offset: 0x2EFB321 VA: 0x2EFB220
	|-ReadOnlyCollection<MonsterHutSaveData>.Contains
	|
	|-RVA: 0x2EFC3D0 Offset: 0x2EFC4D1 VA: 0x2EFC3D0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.Contains
	|
	|-RVA: 0x32E62D0 Offset: 0x32E63D1 VA: 0x32E62D0
	|-ReadOnlyCollection<NPCActionData>.Contains
	|
	|-RVA: 0x32E7500 Offset: 0x32E7601 VA: 0x32E7500
	|-ReadOnlyCollection<NpcPlaceSchedule>.Contains
	|
	|-RVA: 0x32E8660 Offset: 0x32E8761 VA: 0x32E8660
	|-ReadOnlyCollection<OrderLotterySaveParameter>.Contains
	|
	|-RVA: 0x32E9740 Offset: 0x32E9841 VA: 0x32E9740
	|-ReadOnlyCollection<OrderSaveParameter>.Contains
	|
	|-RVA: 0x32EA890 Offset: 0x32EA991 VA: 0x32EA890
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.Contains
	|
	|-RVA: 0x32EB930 Offset: 0x32EBA31 VA: 0x32EB930
	|-ReadOnlyCollection<ShopCatalogPage>.Contains
	|
	|-RVA: 0x32ECA00 Offset: 0x32ECB01 VA: 0x32ECA00
	|-ReadOnlyCollection<ShopNpcTalk>.Contains
	|
	|-RVA: 0x32EDBC0 Offset: 0x32EDCC1 VA: 0x32EDBC0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.Contains
	|
	|-RVA: 0x32EEC80 Offset: 0x32EED81 VA: 0x32EEC80
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.Contains
	|
	|-RVA: 0x32EFD20 Offset: 0x32EFE21 VA: 0x32EFD20
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.Contains
	|
	|-RVA: 0x32F0E00 Offset: 0x32F0F01 VA: 0x32F0E00
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.Contains
	|
	|-RVA: 0x32F1F70 Offset: 0x32F2071 VA: 0x32F1F70
	|-ReadOnlyCollection<Schedule>.Contains
	|
	|-RVA: 0x32F3100 Offset: 0x32F3201 VA: 0x32F3100
	|-ReadOnlyCollection<CurveSample>.Contains
	|
	|-RVA: 0x32F4380 Offset: 0x32F4481 VA: 0x32F4380
	|-ReadOnlyCollection<bool>.Contains
	|
	|-RVA: 0x32F5420 Offset: 0x32F5521 VA: 0x32F5420
	|-ReadOnlyCollection<byte>.Contains
	|
	|-RVA: 0x32F64B0 Offset: 0x32F65B1 VA: 0x32F64B0
	|-ReadOnlyCollection<char>.Contains
	|
	|-RVA: 0x32F7540 Offset: 0x32F7641 VA: 0x32F7540
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.Contains
	|
	|-RVA: 0x32F85E0 Offset: 0x32F86E1 VA: 0x32F85E0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.Contains
	|
	|-RVA: 0x32F9680 Offset: 0x32F9781 VA: 0x32F9680
	|-ReadOnlyCollection<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x32FA720 Offset: 0x32FA821 VA: 0x32FA720
	|-ReadOnlyCollection<DateTime>.Contains
	|
	|-RVA: 0x32FB7B0 Offset: 0x32FB8B1 VA: 0x32FB7B0
	|-ReadOnlyCollection<double>.Contains
	|
	|-RVA: 0x32FC840 Offset: 0x32FC941 VA: 0x32FC840
	|-ReadOnlyCollection<short>.Contains
	|
	|-RVA: 0x32FD8D0 Offset: 0x32FD9D1 VA: 0x32FD8D0
	|-ReadOnlyCollection<int>.Contains
	|
	|-RVA: 0x32FE960 Offset: 0x32FEA61 VA: 0x32FE960
	|-ReadOnlyCollection<Int32Enum>.Contains
	|
	|-RVA: 0x32FF9F0 Offset: 0x32FFAF1 VA: 0x32FF9F0
	|-ReadOnlyCollection<long>.Contains
	|
	|-RVA: 0x3300A80 Offset: 0x3300B81 VA: 0x3300A80
	|-ReadOnlyCollection<InterpretedFrameInfo>.Contains
	|
	|-RVA: 0x3301B20 Offset: 0x3301C21 VA: 0x3301B20
	|-ReadOnlyCollection<Nullable<Int32Enum>>.Contains
	|
	|-RVA: 0x3302BE0 Offset: 0x3302CE1 VA: 0x3302BE0
	|-ReadOnlyCollection<Nullable<Bounds>>.Contains
	|
	|-RVA: 0x3303DE0 Offset: 0x3303EE1 VA: 0x3303DE0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.Contains
	|
	|-RVA: 0x3304FB0 Offset: 0x33050B1 VA: 0x3304FB0
	|-ReadOnlyCollection<Nullable<Color32>>.Contains
	|
	|-RVA: 0x3306060 Offset: 0x3306161 VA: 0x3306060
	|-ReadOnlyCollection<Nullable<Color>>.Contains
	|
	|-RVA: 0x3307200 Offset: 0x3307301 VA: 0x3307200
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.Contains
	|
	|-RVA: 0x33082F0 Offset: 0x33083F1 VA: 0x33082F0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.Contains
	|
	|-RVA: 0x33094A0 Offset: 0x33095A1 VA: 0x33094A0
	|-ReadOnlyCollection<Nullable<Keyframe>>.Contains
	|
	|-RVA: 0x3283BE0 Offset: 0x3283CE1 VA: 0x3283BE0
	|-ReadOnlyCollection<Nullable<LayerMask>>.Contains
	|
	|-RVA: 0x3284CB0 Offset: 0x3284DB1 VA: 0x3284CB0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.Contains
	|
	|-RVA: 0x3285F90 Offset: 0x3286091 VA: 0x3285F90
	|-ReadOnlyCollection<Nullable<Quaternion>>.Contains
	|
	|-RVA: 0x3287130 Offset: 0x3287231 VA: 0x3287130
	|-ReadOnlyCollection<Nullable<RangeInt>>.Contains
	|
	|-RVA: 0x3288220 Offset: 0x3288321 VA: 0x3288220
	|-ReadOnlyCollection<Nullable<Rect>>.Contains
	|
	|-RVA: 0x32893D0 Offset: 0x32894D1 VA: 0x32893D0
	|-ReadOnlyCollection<Nullable<RectInt>>.Contains
	|
	|-RVA: 0x328A570 Offset: 0x328A671 VA: 0x328A570
	|-ReadOnlyCollection<Nullable<Vector2>>.Contains
	|
	|-RVA: 0x328B650 Offset: 0x328B751 VA: 0x328B650
	|-ReadOnlyCollection<Nullable<Vector2Int>>.Contains
	|
	|-RVA: 0x328C720 Offset: 0x328C821 VA: 0x328C720
	|-ReadOnlyCollection<Nullable<Vector3>>.Contains
	|
	|-RVA: 0x328D7C0 Offset: 0x328D8C1 VA: 0x328D7C0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.Contains
	|
	|-RVA: 0x328E880 Offset: 0x328E981 VA: 0x328E880
	|-ReadOnlyCollection<Nullable<Vector4>>.Contains
	|
	|-RVA: 0x328FA10 Offset: 0x328FB11 VA: 0x328FA10
	|-ReadOnlyCollection<object>.Contains
	|
	|-RVA: 0x3290990 Offset: 0x3290A91 VA: 0x3290990
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|
	|-RVA: 0x3291AE0 Offset: 0x3291BE1 VA: 0x3291AE0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|
	|-RVA: 0x3292B80 Offset: 0x3292C81 VA: 0x3292B80
	|-ReadOnlyCollection<sbyte>.Contains
	|
	|-RVA: 0x3293C10 Offset: 0x3293D11 VA: 0x3293C10
	|-ReadOnlyCollection<float>.Contains
	|
	|-RVA: 0x3294CA0 Offset: 0x3294DA1 VA: 0x3294CA0
	|-ReadOnlyCollection<ushort>.Contains
	|
	|-RVA: 0x3295D30 Offset: 0x3295E31 VA: 0x3295D30
	|-ReadOnlyCollection<uint>.Contains
	|
	|-RVA: 0x3296DC0 Offset: 0x3296EC1 VA: 0x3296DC0
	|-ReadOnlyCollection<ulong>.Contains
	|
	|-RVA: 0x3297E50 Offset: 0x3297F51 VA: 0x3297E50
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.Contains
	|
	|-RVA: 0x3298EE0 Offset: 0x3298FE1 VA: 0x3298EE0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.Contains
	|
	|-RVA: 0x3299F70 Offset: 0x329A071 VA: 0x3299F70
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.Contains
	|
	|-RVA: 0x329B010 Offset: 0x329B111 VA: 0x329B010
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.Contains
	|
	|-RVA: 0x329C0B0 Offset: 0x329C1B1 VA: 0x329C0B0
	|-ReadOnlyCollection<ValueTuple<object, object>>.Contains
	|
	|-RVA: 0x329D150 Offset: 0x329D251 VA: 0x329D150
	|-ReadOnlyCollection<ValueTuple<object, float>>.Contains
	|
	|-RVA: 0x329E200 Offset: 0x329E301 VA: 0x329E200
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Contains
	|
	|-RVA: 0x329F2F0 Offset: 0x329F3F1 VA: 0x329F2F0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Contains
	|
	|-RVA: 0x32A0530 Offset: 0x32A0631 VA: 0x32A0530
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.Contains
	|
	|-RVA: 0x32A1750 Offset: 0x32A1851 VA: 0x32A1750
	|-ReadOnlyCollection<TutorialUnlockFlagData>.Contains
	|
	|-RVA: 0x32A2810 Offset: 0x32A2911 VA: 0x32A2810
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.Contains
	|
	|-RVA: 0x32A38E0 Offset: 0x32A39E1 VA: 0x32A38E0
	|-ReadOnlyCollection<CapEdge>.Contains
	|
	|-RVA: 0x32A4AB0 Offset: 0x32A4BB1 VA: 0x32A4AB0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.Contains
	|
	|-RVA: 0x32A5B60 Offset: 0x32A5C61 VA: 0x32A5B60
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.Contains
	|
	|-RVA: 0x32A6CE0 Offset: 0x32A6DE1 VA: 0x32A6CE0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.Contains
	|
	|-RVA: 0x3177D00 Offset: 0x3177E01 VA: 0x3177D00
	|-ReadOnlyCollection<NavMeshBuildMarkup>.Contains
	|
	|-RVA: 0x3178DF0 Offset: 0x3178EF1 VA: 0x3178DF0
	|-ReadOnlyCollection<NavMeshBuildSource>.Contains
	|
	|-RVA: 0x317A160 Offset: 0x317A261 VA: 0x317A160
	|-ReadOnlyCollection<ConstraintSource>.Contains
	|
	|-RVA: 0x317B200 Offset: 0x317B301 VA: 0x317B200
	|-ReadOnlyCollection<AnimatorClipInfo>.Contains
	|
	|-RVA: 0x317C290 Offset: 0x317C391 VA: 0x317C290
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.Contains
	|
	|-RVA: 0x317D350 Offset: 0x317D451 VA: 0x317D350
	|-ReadOnlyCollection<BoneWeight>.Contains
	|
	|-RVA: 0x317E4C0 Offset: 0x317E5C1 VA: 0x317E4C0
	|-ReadOnlyCollection<Bounds>.Contains
	|
	|-RVA: 0x317F630 Offset: 0x317F731 VA: 0x317F630
	|-ReadOnlyCollection<BoundsInt>.Contains
	|
	|-RVA: 0x3180790 Offset: 0x3180891 VA: 0x3180790
	|-ReadOnlyCollection<Color32>.Contains
	|
	|-RVA: 0x3181850 Offset: 0x3181951 VA: 0x3181850
	|-ReadOnlyCollection<Color>.Contains
	|
	|-RVA: 0x3182970 Offset: 0x3182A71 VA: 0x3182970
	|-ReadOnlyCollection<CombineInstance>.Contains
	|
	|-RVA: 0x3183D20 Offset: 0x3183E21 VA: 0x3183D20
	|-ReadOnlyCollection<RaycastResult>.Contains
	|
	|-RVA: 0x3184FA0 Offset: 0x31850A1 VA: 0x3184FA0
	|-ReadOnlyCollection<GradientAlphaKey>.Contains
	|
	|-RVA: 0x3186070 Offset: 0x3186171 VA: 0x3186070
	|-ReadOnlyCollection<GradientColorKey>.Contains
	|
	|-RVA: 0x31871F0 Offset: 0x31872F1 VA: 0x31871F0
	|-ReadOnlyCollection<Keyframe>.Contains
	|
	|-RVA: 0x31883B0 Offset: 0x31884B1 VA: 0x31883B0
	|-ReadOnlyCollection<LayerMask>.Contains
	|
	|-RVA: 0x31894A0 Offset: 0x31895A1 VA: 0x31894A0
	|-ReadOnlyCollection<Matrix4x4>.Contains
	|
	|-RVA: 0x318A6D0 Offset: 0x318A7D1 VA: 0x318A6D0
	|-ReadOnlyCollection<ParticleSystem.Particle>.Contains
	|
	|-RVA: 0x318B860 Offset: 0x318B961 VA: 0x318B860
	|-ReadOnlyCollection<Playable>.Contains
	|
	|-RVA: 0x318C920 Offset: 0x318CA21 VA: 0x318C920
	|-ReadOnlyCollection<PlayableBinding>.Contains
	|
	|-RVA: 0x318DA70 Offset: 0x318DB71 VA: 0x318DA70
	|-ReadOnlyCollection<PlayableGraph>.Contains
	|
	|-RVA: 0x318EB10 Offset: 0x318EC11 VA: 0x318EB10
	|-ReadOnlyCollection<Edge>.Contains
	|
	|-RVA: 0x318FBA0 Offset: 0x318FCA1 VA: 0x318FBA0
	|-ReadOnlyCollection<Quaternion>.Contains
	|
	|-RVA: 0x3190C70 Offset: 0x3190D71 VA: 0x3190C70
	|-ReadOnlyCollection<RangeInt>.Contains
	|
	|-RVA: 0x3191D30 Offset: 0x3191E31 VA: 0x3191D30
	|-ReadOnlyCollection<RaycastHit2D>.Contains
	|
	|-RVA: 0x3192F30 Offset: 0x3193031 VA: 0x3192F30
	|-ReadOnlyCollection<RaycastHit>.Contains
	|
	|-RVA: 0x3194140 Offset: 0x3194241 VA: 0x3194140
	|-ReadOnlyCollection<Rect>.Contains
	|
	|-RVA: 0x3195210 Offset: 0x3195311 VA: 0x3195210
	|-ReadOnlyCollection<RectInt>.Contains
	|
	|-RVA: 0x31962B0 Offset: 0x31963B1 VA: 0x31962B0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.Contains
	|
	|-RVA: 0x31973A0 Offset: 0x31974A1 VA: 0x31973A0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.Contains
	|
	|-RVA: 0x3198750 Offset: 0x3198851 VA: 0x3198750
	|-ReadOnlyCollection<VertexAttributeDescriptor>.Contains
	|
	|-RVA: 0x3199810 Offset: 0x3199911 VA: 0x3199810
	|-ReadOnlyCollection<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x319A980 Offset: 0x319AA81 VA: 0x319A980
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.Contains
	|
	|-RVA: 0x319BB00 Offset: 0x319BC01 VA: 0x319BB00
	|-ReadOnlyCollection<DiagnosticEvent>.Contains
	|
	|-RVA: 0x2E82C10 Offset: 0x2E82D11 VA: 0x2E82C10
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.Contains
	|
	|-RVA: 0x2E83D90 Offset: 0x2E83E91 VA: 0x2E83D90
	|-ReadOnlyCollection<ObjectInitializationData>.Contains
	|
	|-RVA: 0x2E84F40 Offset: 0x2E85041 VA: 0x2E84F40
	|-ReadOnlyCollection<GlyphRect>.Contains
	|
	|-RVA: 0x2E86010 Offset: 0x2E86111 VA: 0x2E86010
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.Contains
	|
	|-RVA: 0x2E871E0 Offset: 0x2E872E1 VA: 0x2E871E0
	|-ReadOnlyCollection<IntervalTreeNode>.Contains
	|
	|-RVA: 0x2E88350 Offset: 0x2E88451 VA: 0x2E88350
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.Contains
	|
	|-RVA: 0x2E894C0 Offset: 0x2E895C1 VA: 0x2E894C0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.Contains
	|
	|-RVA: 0x2E8A610 Offset: 0x2E8A711 VA: 0x2E8A610
	|-ReadOnlyCollection<UICharInfo>.Contains
	|
	|-RVA: 0x2E8B6E0 Offset: 0x2E8B7E1 VA: 0x2E8B6E0
	|-ReadOnlyCollection<FocusController.FocusedElement>.Contains
	|
	|-RVA: 0x2E8C780 Offset: 0x2E8C881 VA: 0x2E8C780
	|-ReadOnlyCollection<UILineInfo>.Contains
	|
	|-RVA: 0x2E8D860 Offset: 0x2E8D961 VA: 0x2E8D860
	|-ReadOnlyCollection<UIVertex>.Contains
	|
	|-RVA: 0x2E8EB60 Offset: 0x2E8EC61 VA: 0x2E8EB60
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.Contains
	|
	|-RVA: 0x2E8FCB0 Offset: 0x2E8FDB1 VA: 0x2E8FCB0
	|-ReadOnlyCollection<Vector2>.Contains
	|
	|-RVA: 0x2E90D60 Offset: 0x2E90E61 VA: 0x2E90D60
	|-ReadOnlyCollection<Vector2Int>.Contains
	|
	|-RVA: 0x2E91DF0 Offset: 0x2E91EF1 VA: 0x2E91DF0
	|-ReadOnlyCollection<Vector3>.Contains
	|
	|-RVA: 0x2E92ED0 Offset: 0x2E92FD1 VA: 0x2E92ED0
	|-ReadOnlyCollection<Vector3Int>.Contains
	|
	|-RVA: 0x2E93F90 Offset: 0x2E94091 VA: 0x2E93F90
	|-ReadOnlyCollection<Vector4>.Contains
	|
	|-RVA: 0x2E950B0 Offset: 0x2E951B1 VA: 0x2E950B0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.Contains
	|
	|-RVA: 0x2E96460 Offset: 0x2E96561 VA: 0x2E96460
	|-ReadOnlyCollection<YieldItemParam>.Contains
	|
	|-RVA: 0x2E97510 Offset: 0x2E97611 VA: 0x2E97510
	|-ReadOnlyCollection<stCommand_t>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8D50 Offset: 0x2EE8E51 VA: 0x2EE8D50
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.CopyTo
	|
	|-RVA: 0x2EE9F80 Offset: 0x2EEA081 VA: 0x2EE9F80
	|-ReadOnlyCollection<BuildItemData>.CopyTo
	|
	|-RVA: 0x2EEB270 Offset: 0x2EEB371 VA: 0x2EEB270
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.CopyTo
	|
	|-RVA: 0x2EEC310 Offset: 0x2EEC411 VA: 0x2EEC310
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.CopyTo
	|
	|-RVA: 0x2EED3C0 Offset: 0x2EED4C1 VA: 0x2EED3C0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.CopyTo
	|
	|-RVA: 0x2EEE480 Offset: 0x2EEE581 VA: 0x2EEE480
	|-ReadOnlyCollection<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x2EEF510 Offset: 0x2EEF611 VA: 0x2EEF510
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x2EF05A0 Offset: 0x2EF06A1 VA: 0x2EF05A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x2EF16B0 Offset: 0x2EF17B1 VA: 0x2EF16B0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x2EF28A0 Offset: 0x2EF29A1 VA: 0x2EF28A0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	|
	|-RVA: 0x2EF3A90 Offset: 0x2EF3B91 VA: 0x2EF3A90
	|-ReadOnlyCollection<CropDataTable>.CopyTo
	|
	|-RVA: 0x2EF4BF0 Offset: 0x2EF4CF1 VA: 0x2EF4BF0
	|-ReadOnlyCollection<DropItemParam>.CopyTo
	|
	|-RVA: 0x2EF5CE0 Offset: 0x2EF5DE1 VA: 0x2EF5CE0
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.CopyTo
	|
	|-RVA: 0x2EF6E50 Offset: 0x2EF6F51 VA: 0x2EF6E50
	|-ReadOnlyCollection<EventCheckId>.CopyTo
	|
	|-RVA: 0x2EF7F70 Offset: 0x2EF8071 VA: 0x2EF7F70
	|-ReadOnlyCollection<EventFlagProgressData>.CopyTo
	|
	|-RVA: 0x2EF9010 Offset: 0x2EF9111 VA: 0x2EF9010
	|-ReadOnlyCollection<FesNpcScoreData>.CopyTo
	|
	|-RVA: 0x2EFA130 Offset: 0x2EFA231 VA: 0x2EFA130
	|-ReadOnlyCollection<MiningPointSaveData>.CopyTo
	|
	|-RVA: 0x2EFB320 Offset: 0x2EFB421 VA: 0x2EFB320
	|-ReadOnlyCollection<MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x2EFC490 Offset: 0x2EFC591 VA: 0x2EFC490
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.CopyTo
	|
	|-RVA: 0x32E63F0 Offset: 0x32E64F1 VA: 0x32E63F0
	|-ReadOnlyCollection<NPCActionData>.CopyTo
	|
	|-RVA: 0x32E75F0 Offset: 0x32E76F1 VA: 0x32E75F0
	|-ReadOnlyCollection<NpcPlaceSchedule>.CopyTo
	|
	|-RVA: 0x32E8720 Offset: 0x32E8821 VA: 0x32E8720
	|-ReadOnlyCollection<OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x32E9830 Offset: 0x32E9931 VA: 0x32E9830
	|-ReadOnlyCollection<OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x32EA950 Offset: 0x32EAA51 VA: 0x32EA950
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x32EB9F0 Offset: 0x32EBAF1 VA: 0x32EB9F0
	|-ReadOnlyCollection<ShopCatalogPage>.CopyTo
	|
	|-RVA: 0x32ECB00 Offset: 0x32ECC01 VA: 0x32ECB00
	|-ReadOnlyCollection<ShopNpcTalk>.CopyTo
	|
	|-RVA: 0x32EDC80 Offset: 0x32EDD81 VA: 0x32EDC80
	|-ReadOnlyCollection<SubtitleDataTable.Data>.CopyTo
	|
	|-RVA: 0x32EED30 Offset: 0x32EEE31 VA: 0x32EED30
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.CopyTo
	|
	|-RVA: 0x32EFDE0 Offset: 0x32EFEE1 VA: 0x32EFDE0
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.CopyTo
	|
	|-RVA: 0x32F0EF0 Offset: 0x32F0FF1 VA: 0x32F0EF0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.CopyTo
	|
	|-RVA: 0x32F2060 Offset: 0x32F2161 VA: 0x32F2060
	|-ReadOnlyCollection<Schedule>.CopyTo
	|
	|-RVA: 0x32F3230 Offset: 0x32F3331 VA: 0x32F3230
	|-ReadOnlyCollection<CurveSample>.CopyTo
	|
	|-RVA: 0x32F4430 Offset: 0x32F4531 VA: 0x32F4430
	|-ReadOnlyCollection<bool>.CopyTo
	|
	|-RVA: 0x32F54D0 Offset: 0x32F55D1 VA: 0x32F54D0
	|-ReadOnlyCollection<byte>.CopyTo
	|
	|-RVA: 0x32F6560 Offset: 0x32F6661 VA: 0x32F6560
	|-ReadOnlyCollection<char>.CopyTo
	|
	|-RVA: 0x32F7600 Offset: 0x32F7701 VA: 0x32F7600
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x32F86A0 Offset: 0x32F87A1 VA: 0x32F86A0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x32F9740 Offset: 0x32F9841 VA: 0x32F9740
	|-ReadOnlyCollection<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x32FA7D0 Offset: 0x32FA8D1 VA: 0x32FA7D0
	|-ReadOnlyCollection<DateTime>.CopyTo
	|
	|-RVA: 0x32FB860 Offset: 0x32FB961 VA: 0x32FB860
	|-ReadOnlyCollection<double>.CopyTo
	|
	|-RVA: 0x328FAC0 Offset: 0x328FBC1 VA: 0x328FAC0
	|-ReadOnlyCollection<Exception>.CopyTo
	|-ReadOnlyCollection<object>.CopyTo
	|
	|-RVA: 0x32FC8F0 Offset: 0x32FC9F1 VA: 0x32FC8F0
	|-ReadOnlyCollection<short>.CopyTo
	|
	|-RVA: 0x32FD980 Offset: 0x32FDA81 VA: 0x32FD980
	|-ReadOnlyCollection<int>.CopyTo
	|
	|-RVA: 0x32FEA10 Offset: 0x32FEB11 VA: 0x32FEA10
	|-ReadOnlyCollection<Int32Enum>.CopyTo
	|
	|-RVA: 0x32FFAA0 Offset: 0x32FFBA1 VA: 0x32FFAA0
	|-ReadOnlyCollection<long>.CopyTo
	|
	|-RVA: 0x3300B40 Offset: 0x3300C41 VA: 0x3300B40
	|-ReadOnlyCollection<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3301BD0 Offset: 0x3301CD1 VA: 0x3301BD0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x3302CE0 Offset: 0x3302DE1 VA: 0x3302CE0
	|-ReadOnlyCollection<Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x3303EE0 Offset: 0x3303FE1 VA: 0x3303EE0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x3305060 Offset: 0x3305161 VA: 0x3305060
	|-ReadOnlyCollection<Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x3306150 Offset: 0x3306251 VA: 0x3306150
	|-ReadOnlyCollection<Nullable<Color>>.CopyTo
	|
	|-RVA: 0x33072C0 Offset: 0x33073C1 VA: 0x33072C0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x33083E0 Offset: 0x33084E1 VA: 0x33083E0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x3309590 Offset: 0x3309691 VA: 0x3309590
	|-ReadOnlyCollection<Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x3283C90 Offset: 0x3283D91 VA: 0x3283C90
	|-ReadOnlyCollection<Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x3284DF0 Offset: 0x3284EF1 VA: 0x3284DF0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x3286080 Offset: 0x3286181 VA: 0x3286080
	|-ReadOnlyCollection<Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x32871F0 Offset: 0x32872F1 VA: 0x32871F0
	|-ReadOnlyCollection<Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x3288310 Offset: 0x3288411 VA: 0x3288310
	|-ReadOnlyCollection<Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x32894C0 Offset: 0x32895C1 VA: 0x32894C0
	|-ReadOnlyCollection<Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x328A630 Offset: 0x328A731 VA: 0x328A630
	|-ReadOnlyCollection<Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x328B710 Offset: 0x328B811 VA: 0x328B710
	|-ReadOnlyCollection<Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x328C7E0 Offset: 0x328C8E1 VA: 0x328C7E0
	|-ReadOnlyCollection<Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x328D880 Offset: 0x328D981 VA: 0x328D880
	|-ReadOnlyCollection<Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x328E970 Offset: 0x328EA71 VA: 0x328E970
	|-ReadOnlyCollection<Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x3290A80 Offset: 0x3290B81 VA: 0x3290A80
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|
	|-RVA: 0x3291BA0 Offset: 0x3291CA1 VA: 0x3291BA0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|
	|-RVA: 0x3292C30 Offset: 0x3292D31 VA: 0x3292C30
	|-ReadOnlyCollection<sbyte>.CopyTo
	|
	|-RVA: 0x3293CC0 Offset: 0x3293DC1 VA: 0x3293CC0
	|-ReadOnlyCollection<float>.CopyTo
	|
	|-RVA: 0x3294D50 Offset: 0x3294E51 VA: 0x3294D50
	|-ReadOnlyCollection<ushort>.CopyTo
	|
	|-RVA: 0x3295DE0 Offset: 0x3295EE1 VA: 0x3295DE0
	|-ReadOnlyCollection<uint>.CopyTo
	|
	|-RVA: 0x3296E70 Offset: 0x3296F71 VA: 0x3296E70
	|-ReadOnlyCollection<ulong>.CopyTo
	|
	|-RVA: 0x3297F00 Offset: 0x3298001 VA: 0x3297F00
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.CopyTo
	|
	|-RVA: 0x3298F90 Offset: 0x3299091 VA: 0x3298F90
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x329A030 Offset: 0x329A131 VA: 0x329A030
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x329B0D0 Offset: 0x329B1D1 VA: 0x329B0D0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.CopyTo
	|
	|-RVA: 0x329C170 Offset: 0x329C271 VA: 0x329C170
	|-ReadOnlyCollection<ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x329D210 Offset: 0x329D311 VA: 0x329D210
	|-ReadOnlyCollection<ValueTuple<object, float>>.CopyTo
	|
	|-RVA: 0x329E2C0 Offset: 0x329E3C1 VA: 0x329E2C0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CopyTo
	|
	|-RVA: 0x329F410 Offset: 0x329F511 VA: 0x329F410
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CopyTo
	|
	|-RVA: 0x32A0650 Offset: 0x32A0751 VA: 0x32A0650
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x32A1810 Offset: 0x32A1911 VA: 0x32A1810
	|-ReadOnlyCollection<TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x32A28D0 Offset: 0x32A29D1 VA: 0x32A28D0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.CopyTo
	|
	|-RVA: 0x32A39F0 Offset: 0x32A3AF1 VA: 0x32A39F0
	|-ReadOnlyCollection<CapEdge>.CopyTo
	|
	|-RVA: 0x32A4B60 Offset: 0x32A4C61 VA: 0x32A4B60
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.CopyTo
	|
	|-RVA: 0x32A5C50 Offset: 0x32A5D51 VA: 0x32A5C50
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.CopyTo
	|
	|-RVA: 0x32A6DE0 Offset: 0x32A6EE1 VA: 0x32A6DE0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x3177DC0 Offset: 0x3177EC1 VA: 0x3177DC0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.CopyTo
	|
	|-RVA: 0x3178F60 Offset: 0x3179061 VA: 0x3178F60
	|-ReadOnlyCollection<NavMeshBuildSource>.CopyTo
	|
	|-RVA: 0x317A220 Offset: 0x317A321 VA: 0x317A220
	|-ReadOnlyCollection<ConstraintSource>.CopyTo
	|
	|-RVA: 0x317B2B0 Offset: 0x317B3B1 VA: 0x317B2B0
	|-ReadOnlyCollection<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x317C350 Offset: 0x317C451 VA: 0x317C350
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x317D440 Offset: 0x317D541 VA: 0x317D440
	|-ReadOnlyCollection<BoneWeight>.CopyTo
	|
	|-RVA: 0x317E5B0 Offset: 0x317E6B1 VA: 0x317E5B0
	|-ReadOnlyCollection<Bounds>.CopyTo
	|
	|-RVA: 0x317F720 Offset: 0x317F821 VA: 0x317F720
	|-ReadOnlyCollection<BoundsInt>.CopyTo
	|
	|-RVA: 0x3180850 Offset: 0x3180951 VA: 0x3180850
	|-ReadOnlyCollection<Color32>.CopyTo
	|
	|-RVA: 0x3181920 Offset: 0x3181A21 VA: 0x3181920
	|-ReadOnlyCollection<Color>.CopyTo
	|
	|-RVA: 0x3182AE0 Offset: 0x3182BE1 VA: 0x3182AE0
	|-ReadOnlyCollection<CombineInstance>.CopyTo
	|
	|-RVA: 0x3183E50 Offset: 0x3183F51 VA: 0x3183E50
	|-ReadOnlyCollection<RaycastResult>.CopyTo
	|
	|-RVA: 0x3185060 Offset: 0x3185161 VA: 0x3185060
	|-ReadOnlyCollection<GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x3186160 Offset: 0x3186261 VA: 0x3186160
	|-ReadOnlyCollection<GradientColorKey>.CopyTo
	|
	|-RVA: 0x31872F0 Offset: 0x31873F1 VA: 0x31872F0
	|-ReadOnlyCollection<Keyframe>.CopyTo
	|
	|-RVA: 0x3188470 Offset: 0x3188571 VA: 0x3188470
	|-ReadOnlyCollection<LayerMask>.CopyTo
	|
	|-RVA: 0x31895C0 Offset: 0x31896C1 VA: 0x31895C0
	|-ReadOnlyCollection<Matrix4x4>.CopyTo
	|
	|-RVA: 0x318A7D0 Offset: 0x318A8D1 VA: 0x318A7D0
	|-ReadOnlyCollection<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x318B920 Offset: 0x318BA21 VA: 0x318B920
	|-ReadOnlyCollection<Playable>.CopyTo
	|
	|-RVA: 0x318CA10 Offset: 0x318CB11 VA: 0x318CA10
	|-ReadOnlyCollection<PlayableBinding>.CopyTo
	|
	|-RVA: 0x318DB30 Offset: 0x318DC31 VA: 0x318DB30
	|-ReadOnlyCollection<PlayableGraph>.CopyTo
	|
	|-RVA: 0x318EBC0 Offset: 0x318ECC1 VA: 0x318EBC0
	|-ReadOnlyCollection<Edge>.CopyTo
	|
	|-RVA: 0x318FC70 Offset: 0x318FD71 VA: 0x318FC70
	|-ReadOnlyCollection<Quaternion>.CopyTo
	|
	|-RVA: 0x3190D20 Offset: 0x3190E21 VA: 0x3190D20
	|-ReadOnlyCollection<RangeInt>.CopyTo
	|
	|-RVA: 0x3191E40 Offset: 0x3191F41 VA: 0x3191E40
	|-ReadOnlyCollection<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x3193050 Offset: 0x3193151 VA: 0x3193050
	|-ReadOnlyCollection<RaycastHit>.CopyTo
	|
	|-RVA: 0x3194210 Offset: 0x3194311 VA: 0x3194210
	|-ReadOnlyCollection<Rect>.CopyTo
	|
	|-RVA: 0x31952D0 Offset: 0x31953D1 VA: 0x31952D0
	|-ReadOnlyCollection<RectInt>.CopyTo
	|
	|-RVA: 0x3196370 Offset: 0x3196471 VA: 0x3196370
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.CopyTo
	|
	|-RVA: 0x3197520 Offset: 0x3197621 VA: 0x3197520
	|-ReadOnlyCollection<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x3198810 Offset: 0x3198911 VA: 0x3198810
	|-ReadOnlyCollection<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x3199900 Offset: 0x3199A01 VA: 0x3199900
	|-ReadOnlyCollection<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x319AA70 Offset: 0x319AB71 VA: 0x319AA70
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.CopyTo
	|
	|-RVA: 0x319BC00 Offset: 0x319BD01 VA: 0x319BC00
	|-ReadOnlyCollection<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x2E82D00 Offset: 0x2E82E01 VA: 0x2E82D00
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x2E83E90 Offset: 0x2E83F91 VA: 0x2E83E90
	|-ReadOnlyCollection<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x2E85000 Offset: 0x2E85101 VA: 0x2E85000
	|-ReadOnlyCollection<GlyphRect>.CopyTo
	|
	|-RVA: 0x2E86110 Offset: 0x2E86211 VA: 0x2E86110
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x2E872D0 Offset: 0x2E873D1 VA: 0x2E872D0
	|-ReadOnlyCollection<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x2E88440 Offset: 0x2E88541 VA: 0x2E88440
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x2E895B0 Offset: 0x2E896B1 VA: 0x2E895B0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x2E8A6E0 Offset: 0x2E8A7E1 VA: 0x2E8A6E0
	|-ReadOnlyCollection<UICharInfo>.CopyTo
	|
	|-RVA: 0x2E8B7A0 Offset: 0x2E8B8A1 VA: 0x2E8B7A0
	|-ReadOnlyCollection<FocusController.FocusedElement>.CopyTo
	|
	|-RVA: 0x2E8C840 Offset: 0x2E8C941 VA: 0x2E8C840
	|-ReadOnlyCollection<UILineInfo>.CopyTo
	|
	|-RVA: 0x2E8D9B0 Offset: 0x2E8DAB1 VA: 0x2E8D9B0
	|-ReadOnlyCollection<UIVertex>.CopyTo
	|
	|-RVA: 0x2E8EC50 Offset: 0x2E8ED51 VA: 0x2E8EC50
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x2E8FD70 Offset: 0x2E8FE71 VA: 0x2E8FD70
	|-ReadOnlyCollection<Vector2>.CopyTo
	|
	|-RVA: 0x2E90E10 Offset: 0x2E90F11 VA: 0x2E90E10
	|-ReadOnlyCollection<Vector2Int>.CopyTo
	|
	|-RVA: 0x2E91EC0 Offset: 0x2E91FC1 VA: 0x2E91EC0
	|-ReadOnlyCollection<Vector3>.CopyTo
	|
	|-RVA: 0x2E92F90 Offset: 0x2E93091 VA: 0x2E92F90
	|-ReadOnlyCollection<Vector3Int>.CopyTo
	|
	|-RVA: 0x2E94060 Offset: 0x2E94161 VA: 0x2E94060
	|-ReadOnlyCollection<Vector4>.CopyTo
	|
	|-RVA: 0x2E95230 Offset: 0x2E95331 VA: 0x2E95230
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.CopyTo
	|
	|-RVA: 0x2E96510 Offset: 0x2E96611 VA: 0x2E96510
	|-ReadOnlyCollection<YieldItemParam>.CopyTo
	|
	|-RVA: 0x2E97600 Offset: 0x2E97701 VA: 0x2E97600
	|-ReadOnlyCollection<stCommand_t>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328FB80 Offset: 0x328FC81 VA: 0x328FB80
	|-ReadOnlyCollection<CubicBezierCurve>.GetEnumerator
	|-ReadOnlyCollection<CatchBlock>.GetEnumerator
	|-ReadOnlyCollection<Expression>.GetEnumerator
	|-ReadOnlyCollection<MemberBinding>.GetEnumerator
	|-ReadOnlyCollection<ParameterExpression>.GetEnumerator
	|-ReadOnlyCollection<SwitchCase>.GetEnumerator
	|-ReadOnlyCollection<Exception>.GetEnumerator
	|-ReadOnlyCollection<object>.GetEnumerator
	|-ReadOnlyCollection<TimeZoneInfo>.GetEnumerator
	|
	|-RVA: 0x32FDA40 Offset: 0x32FDB41 VA: 0x32FDA40
	|-ReadOnlyCollection<int>.GetEnumerator
	|
	|-RVA: 0x2EE8E10 Offset: 0x2EE8F11 VA: 0x2EE8E10
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.GetEnumerator
	|
	|-RVA: 0x2EEA040 Offset: 0x2EEA141 VA: 0x2EEA040
	|-ReadOnlyCollection<BuildItemData>.GetEnumerator
	|
	|-RVA: 0x2EEB330 Offset: 0x2EEB431 VA: 0x2EEB330
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.GetEnumerator
	|
	|-RVA: 0x2EEC3D0 Offset: 0x2EEC4D1 VA: 0x2EEC3D0
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.GetEnumerator
	|
	|-RVA: 0x2EED480 Offset: 0x2EED581 VA: 0x2EED480
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.GetEnumerator
	|
	|-RVA: 0x2EEE540 Offset: 0x2EEE641 VA: 0x2EEE540
	|-ReadOnlyCollection<CameraState.CustomBlendable>.GetEnumerator
	|
	|-RVA: 0x2EEF5D0 Offset: 0x2EEF6D1 VA: 0x2EEF5D0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.GetEnumerator
	|
	|-RVA: 0x2EF0660 Offset: 0x2EF0761 VA: 0x2EF0660
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.GetEnumerator
	|
	|-RVA: 0x2EF1770 Offset: 0x2EF1871 VA: 0x2EF1770
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.GetEnumerator
	|
	|-RVA: 0x2EF2960 Offset: 0x2EF2A61 VA: 0x2EF2960
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.GetEnumerator
	|
	|-RVA: 0x2EF3B50 Offset: 0x2EF3C51 VA: 0x2EF3B50
	|-ReadOnlyCollection<CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2EF4CB0 Offset: 0x2EF4DB1 VA: 0x2EF4CB0
	|-ReadOnlyCollection<DropItemParam>.GetEnumerator
	|
	|-RVA: 0x2EF5DA0 Offset: 0x2EF5EA1 VA: 0x2EF5DA0
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.GetEnumerator
	|
	|-RVA: 0x2EF6F10 Offset: 0x2EF7011 VA: 0x2EF6F10
	|-ReadOnlyCollection<EventCheckId>.GetEnumerator
	|
	|-RVA: 0x2EF8030 Offset: 0x2EF8131 VA: 0x2EF8030
	|-ReadOnlyCollection<EventFlagProgressData>.GetEnumerator
	|
	|-RVA: 0x2EF90D0 Offset: 0x2EF91D1 VA: 0x2EF90D0
	|-ReadOnlyCollection<FesNpcScoreData>.GetEnumerator
	|
	|-RVA: 0x2EFA1F0 Offset: 0x2EFA2F1 VA: 0x2EFA1F0
	|-ReadOnlyCollection<MiningPointSaveData>.GetEnumerator
	|
	|-RVA: 0x2EFB3E0 Offset: 0x2EFB4E1 VA: 0x2EFB3E0
	|-ReadOnlyCollection<MonsterHutSaveData>.GetEnumerator
	|
	|-RVA: 0x2EFC550 Offset: 0x2EFC651 VA: 0x2EFC550
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.GetEnumerator
	|
	|-RVA: 0x32E64B0 Offset: 0x32E65B1 VA: 0x32E64B0
	|-ReadOnlyCollection<NPCActionData>.GetEnumerator
	|
	|-RVA: 0x32E76B0 Offset: 0x32E77B1 VA: 0x32E76B0
	|-ReadOnlyCollection<NpcPlaceSchedule>.GetEnumerator
	|
	|-RVA: 0x32E87E0 Offset: 0x32E88E1 VA: 0x32E87E0
	|-ReadOnlyCollection<OrderLotterySaveParameter>.GetEnumerator
	|
	|-RVA: 0x32E98F0 Offset: 0x32E99F1 VA: 0x32E98F0
	|-ReadOnlyCollection<OrderSaveParameter>.GetEnumerator
	|
	|-RVA: 0x32EAA10 Offset: 0x32EAB11 VA: 0x32EAA10
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetEnumerator
	|
	|-RVA: 0x32EBAB0 Offset: 0x32EBBB1 VA: 0x32EBAB0
	|-ReadOnlyCollection<ShopCatalogPage>.GetEnumerator
	|
	|-RVA: 0x32ECBC0 Offset: 0x32ECCC1 VA: 0x32ECBC0
	|-ReadOnlyCollection<ShopNpcTalk>.GetEnumerator
	|
	|-RVA: 0x32EDD40 Offset: 0x32EDE41 VA: 0x32EDD40
	|-ReadOnlyCollection<SubtitleDataTable.Data>.GetEnumerator
	|
	|-RVA: 0x32EEDF0 Offset: 0x32EEEF1 VA: 0x32EEDF0
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.GetEnumerator
	|
	|-RVA: 0x32EFEA0 Offset: 0x32EFFA1 VA: 0x32EFEA0
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.GetEnumerator
	|
	|-RVA: 0x32F0FB0 Offset: 0x32F10B1 VA: 0x32F0FB0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.GetEnumerator
	|
	|-RVA: 0x32F2120 Offset: 0x32F2221 VA: 0x32F2120
	|-ReadOnlyCollection<Schedule>.GetEnumerator
	|
	|-RVA: 0x32F32F0 Offset: 0x32F33F1 VA: 0x32F32F0
	|-ReadOnlyCollection<CurveSample>.GetEnumerator
	|
	|-RVA: 0x32F44F0 Offset: 0x32F45F1 VA: 0x32F44F0
	|-ReadOnlyCollection<bool>.GetEnumerator
	|
	|-RVA: 0x32F5590 Offset: 0x32F5691 VA: 0x32F5590
	|-ReadOnlyCollection<byte>.GetEnumerator
	|
	|-RVA: 0x32F6620 Offset: 0x32F6721 VA: 0x32F6620
	|-ReadOnlyCollection<char>.GetEnumerator
	|
	|-RVA: 0x32F76C0 Offset: 0x32F77C1 VA: 0x32F76C0
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.GetEnumerator
	|
	|-RVA: 0x32F8760 Offset: 0x32F8861 VA: 0x32F8760
	|-ReadOnlyCollection<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x32F9800 Offset: 0x32F9901 VA: 0x32F9800
	|-ReadOnlyCollection<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x32FA890 Offset: 0x32FA991 VA: 0x32FA890
	|-ReadOnlyCollection<DateTime>.GetEnumerator
	|
	|-RVA: 0x32FB920 Offset: 0x32FBA21 VA: 0x32FB920
	|-ReadOnlyCollection<double>.GetEnumerator
	|
	|-RVA: 0x32FC9B0 Offset: 0x32FCAB1 VA: 0x32FC9B0
	|-ReadOnlyCollection<short>.GetEnumerator
	|
	|-RVA: 0x32FEAD0 Offset: 0x32FEBD1 VA: 0x32FEAD0
	|-ReadOnlyCollection<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x32FFB60 Offset: 0x32FFC61 VA: 0x32FFB60
	|-ReadOnlyCollection<long>.GetEnumerator
	|
	|-RVA: 0x3300C00 Offset: 0x3300D01 VA: 0x3300C00
	|-ReadOnlyCollection<InterpretedFrameInfo>.GetEnumerator
	|
	|-RVA: 0x3301C90 Offset: 0x3301D91 VA: 0x3301C90
	|-ReadOnlyCollection<Nullable<Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x3302DA0 Offset: 0x3302EA1 VA: 0x3302DA0
	|-ReadOnlyCollection<Nullable<Bounds>>.GetEnumerator
	|
	|-RVA: 0x3303FA0 Offset: 0x33040A1 VA: 0x3303FA0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.GetEnumerator
	|
	|-RVA: 0x3305120 Offset: 0x3305221 VA: 0x3305120
	|-ReadOnlyCollection<Nullable<Color32>>.GetEnumerator
	|
	|-RVA: 0x3306210 Offset: 0x3306311 VA: 0x3306210
	|-ReadOnlyCollection<Nullable<Color>>.GetEnumerator
	|
	|-RVA: 0x3307380 Offset: 0x3307481 VA: 0x3307380
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.GetEnumerator
	|
	|-RVA: 0x33084A0 Offset: 0x33085A1 VA: 0x33084A0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.GetEnumerator
	|
	|-RVA: 0x3309650 Offset: 0x3309751 VA: 0x3309650
	|-ReadOnlyCollection<Nullable<Keyframe>>.GetEnumerator
	|
	|-RVA: 0x3283D50 Offset: 0x3283E51 VA: 0x3283D50
	|-ReadOnlyCollection<Nullable<LayerMask>>.GetEnumerator
	|
	|-RVA: 0x3284EB0 Offset: 0x3284FB1 VA: 0x3284EB0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.GetEnumerator
	|
	|-RVA: 0x3286140 Offset: 0x3286241 VA: 0x3286140
	|-ReadOnlyCollection<Nullable<Quaternion>>.GetEnumerator
	|
	|-RVA: 0x32872B0 Offset: 0x32873B1 VA: 0x32872B0
	|-ReadOnlyCollection<Nullable<RangeInt>>.GetEnumerator
	|
	|-RVA: 0x32883D0 Offset: 0x32884D1 VA: 0x32883D0
	|-ReadOnlyCollection<Nullable<Rect>>.GetEnumerator
	|
	|-RVA: 0x3289580 Offset: 0x3289681 VA: 0x3289580
	|-ReadOnlyCollection<Nullable<RectInt>>.GetEnumerator
	|
	|-RVA: 0x328A6F0 Offset: 0x328A7F1 VA: 0x328A6F0
	|-ReadOnlyCollection<Nullable<Vector2>>.GetEnumerator
	|
	|-RVA: 0x328B7D0 Offset: 0x328B8D1 VA: 0x328B7D0
	|-ReadOnlyCollection<Nullable<Vector2Int>>.GetEnumerator
	|
	|-RVA: 0x328C8A0 Offset: 0x328C9A1 VA: 0x328C8A0
	|-ReadOnlyCollection<Nullable<Vector3>>.GetEnumerator
	|
	|-RVA: 0x328D940 Offset: 0x328DA41 VA: 0x328D940
	|-ReadOnlyCollection<Nullable<Vector3Int>>.GetEnumerator
	|
	|-RVA: 0x328EA30 Offset: 0x328EB31 VA: 0x328EA30
	|-ReadOnlyCollection<Nullable<Vector4>>.GetEnumerator
	|
	|-RVA: 0x3290B40 Offset: 0x3290C41 VA: 0x3290B40
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|
	|-RVA: 0x3291C60 Offset: 0x3291D61 VA: 0x3291C60
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|
	|-RVA: 0x3292CF0 Offset: 0x3292DF1 VA: 0x3292CF0
	|-ReadOnlyCollection<sbyte>.GetEnumerator
	|
	|-RVA: 0x3293D80 Offset: 0x3293E81 VA: 0x3293D80
	|-ReadOnlyCollection<float>.GetEnumerator
	|
	|-RVA: 0x3294E10 Offset: 0x3294F11 VA: 0x3294E10
	|-ReadOnlyCollection<ushort>.GetEnumerator
	|
	|-RVA: 0x3295EA0 Offset: 0x3295FA1 VA: 0x3295EA0
	|-ReadOnlyCollection<uint>.GetEnumerator
	|
	|-RVA: 0x3296F30 Offset: 0x3297031 VA: 0x3296F30
	|-ReadOnlyCollection<ulong>.GetEnumerator
	|
	|-RVA: 0x3297FC0 Offset: 0x32980C1 VA: 0x3297FC0
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x3299050 Offset: 0x3299151 VA: 0x3299050
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x329A0F0 Offset: 0x329A1F1 VA: 0x329A0F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.GetEnumerator
	|
	|-RVA: 0x329B190 Offset: 0x329B291 VA: 0x329B190
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x329C230 Offset: 0x329C331 VA: 0x329C230
	|-ReadOnlyCollection<ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x329D2D0 Offset: 0x329D3D1 VA: 0x329D2D0
	|-ReadOnlyCollection<ValueTuple<object, float>>.GetEnumerator
	|
	|-RVA: 0x329E380 Offset: 0x329E481 VA: 0x329E380
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x329F4D0 Offset: 0x329F5D1 VA: 0x329F4D0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.GetEnumerator
	|
	|-RVA: 0x32A0710 Offset: 0x32A0811 VA: 0x32A0710
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.GetEnumerator
	|
	|-RVA: 0x32A18D0 Offset: 0x32A19D1 VA: 0x32A18D0
	|-ReadOnlyCollection<TutorialUnlockFlagData>.GetEnumerator
	|
	|-RVA: 0x32A2990 Offset: 0x32A2A91 VA: 0x32A2990
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.GetEnumerator
	|
	|-RVA: 0x32A3AB0 Offset: 0x32A3BB1 VA: 0x32A3AB0
	|-ReadOnlyCollection<CapEdge>.GetEnumerator
	|
	|-RVA: 0x32A4C20 Offset: 0x32A4D21 VA: 0x32A4C20
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.GetEnumerator
	|
	|-RVA: 0x32A5D10 Offset: 0x32A5E11 VA: 0x32A5D10
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.GetEnumerator
	|
	|-RVA: 0x32A6EA0 Offset: 0x32A6FA1 VA: 0x32A6EA0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.GetEnumerator
	|
	|-RVA: 0x3177E80 Offset: 0x3177F81 VA: 0x3177E80
	|-ReadOnlyCollection<NavMeshBuildMarkup>.GetEnumerator
	|
	|-RVA: 0x3179020 Offset: 0x3179121 VA: 0x3179020
	|-ReadOnlyCollection<NavMeshBuildSource>.GetEnumerator
	|
	|-RVA: 0x317A2E0 Offset: 0x317A3E1 VA: 0x317A2E0
	|-ReadOnlyCollection<ConstraintSource>.GetEnumerator
	|
	|-RVA: 0x317B370 Offset: 0x317B471 VA: 0x317B370
	|-ReadOnlyCollection<AnimatorClipInfo>.GetEnumerator
	|
	|-RVA: 0x317C410 Offset: 0x317C511 VA: 0x317C410
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|
	|-RVA: 0x317D500 Offset: 0x317D601 VA: 0x317D500
	|-ReadOnlyCollection<BoneWeight>.GetEnumerator
	|
	|-RVA: 0x317E670 Offset: 0x317E771 VA: 0x317E670
	|-ReadOnlyCollection<Bounds>.GetEnumerator
	|
	|-RVA: 0x317F7E0 Offset: 0x317F8E1 VA: 0x317F7E0
	|-ReadOnlyCollection<BoundsInt>.GetEnumerator
	|
	|-RVA: 0x3180910 Offset: 0x3180A11 VA: 0x3180910
	|-ReadOnlyCollection<Color32>.GetEnumerator
	|
	|-RVA: 0x31819E0 Offset: 0x3181AE1 VA: 0x31819E0
	|-ReadOnlyCollection<Color>.GetEnumerator
	|
	|-RVA: 0x3182BA0 Offset: 0x3182CA1 VA: 0x3182BA0
	|-ReadOnlyCollection<CombineInstance>.GetEnumerator
	|
	|-RVA: 0x3183F10 Offset: 0x3184011 VA: 0x3183F10
	|-ReadOnlyCollection<RaycastResult>.GetEnumerator
	|
	|-RVA: 0x3185120 Offset: 0x3185221 VA: 0x3185120
	|-ReadOnlyCollection<GradientAlphaKey>.GetEnumerator
	|
	|-RVA: 0x3186220 Offset: 0x3186321 VA: 0x3186220
	|-ReadOnlyCollection<GradientColorKey>.GetEnumerator
	|
	|-RVA: 0x31873B0 Offset: 0x31874B1 VA: 0x31873B0
	|-ReadOnlyCollection<Keyframe>.GetEnumerator
	|
	|-RVA: 0x3188530 Offset: 0x3188631 VA: 0x3188530
	|-ReadOnlyCollection<LayerMask>.GetEnumerator
	|
	|-RVA: 0x3189680 Offset: 0x3189781 VA: 0x3189680
	|-ReadOnlyCollection<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x318A890 Offset: 0x318A991 VA: 0x318A890
	|-ReadOnlyCollection<ParticleSystem.Particle>.GetEnumerator
	|
	|-RVA: 0x318B9E0 Offset: 0x318BAE1 VA: 0x318B9E0
	|-ReadOnlyCollection<Playable>.GetEnumerator
	|
	|-RVA: 0x318CAD0 Offset: 0x318CBD1 VA: 0x318CAD0
	|-ReadOnlyCollection<PlayableBinding>.GetEnumerator
	|
	|-RVA: 0x318DBF0 Offset: 0x318DCF1 VA: 0x318DBF0
	|-ReadOnlyCollection<PlayableGraph>.GetEnumerator
	|
	|-RVA: 0x318EC80 Offset: 0x318ED81 VA: 0x318EC80
	|-ReadOnlyCollection<Edge>.GetEnumerator
	|
	|-RVA: 0x318FD30 Offset: 0x318FE31 VA: 0x318FD30
	|-ReadOnlyCollection<Quaternion>.GetEnumerator
	|
	|-RVA: 0x3190DE0 Offset: 0x3190EE1 VA: 0x3190DE0
	|-ReadOnlyCollection<RangeInt>.GetEnumerator
	|
	|-RVA: 0x3191F00 Offset: 0x3192001 VA: 0x3191F00
	|-ReadOnlyCollection<RaycastHit2D>.GetEnumerator
	|
	|-RVA: 0x3193110 Offset: 0x3193211 VA: 0x3193110
	|-ReadOnlyCollection<RaycastHit>.GetEnumerator
	|
	|-RVA: 0x31942D0 Offset: 0x31943D1 VA: 0x31942D0
	|-ReadOnlyCollection<Rect>.GetEnumerator
	|
	|-RVA: 0x3195390 Offset: 0x3195491 VA: 0x3195390
	|-ReadOnlyCollection<RectInt>.GetEnumerator
	|
	|-RVA: 0x3196430 Offset: 0x3196531 VA: 0x3196430
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.GetEnumerator
	|
	|-RVA: 0x31975E0 Offset: 0x31976E1 VA: 0x31975E0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.GetEnumerator
	|
	|-RVA: 0x31988D0 Offset: 0x31989D1 VA: 0x31988D0
	|-ReadOnlyCollection<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0x31999C0 Offset: 0x3199AC1 VA: 0x31999C0
	|-ReadOnlyCollection<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x319AB30 Offset: 0x319AC31 VA: 0x319AB30
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.GetEnumerator
	|
	|-RVA: 0x319BCC0 Offset: 0x319BDC1 VA: 0x319BCC0
	|-ReadOnlyCollection<DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x2E82DC0 Offset: 0x2E82EC1 VA: 0x2E82DC0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.GetEnumerator
	|
	|-RVA: 0x2E83F50 Offset: 0x2E84051 VA: 0x2E83F50
	|-ReadOnlyCollection<ObjectInitializationData>.GetEnumerator
	|
	|-RVA: 0x2E850C0 Offset: 0x2E851C1 VA: 0x2E850C0
	|-ReadOnlyCollection<GlyphRect>.GetEnumerator
	|
	|-RVA: 0x2E861D0 Offset: 0x2E862D1 VA: 0x2E861D0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.GetEnumerator
	|
	|-RVA: 0x2E87390 Offset: 0x2E87491 VA: 0x2E87390
	|-ReadOnlyCollection<IntervalTreeNode>.GetEnumerator
	|
	|-RVA: 0x2E88500 Offset: 0x2E88601 VA: 0x2E88500
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.GetEnumerator
	|
	|-RVA: 0x2E89670 Offset: 0x2E89771 VA: 0x2E89670
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.GetEnumerator
	|
	|-RVA: 0x2E8A7A0 Offset: 0x2E8A8A1 VA: 0x2E8A7A0
	|-ReadOnlyCollection<UICharInfo>.GetEnumerator
	|
	|-RVA: 0x2E8B860 Offset: 0x2E8B961 VA: 0x2E8B860
	|-ReadOnlyCollection<FocusController.FocusedElement>.GetEnumerator
	|
	|-RVA: 0x2E8C900 Offset: 0x2E8CA01 VA: 0x2E8C900
	|-ReadOnlyCollection<UILineInfo>.GetEnumerator
	|
	|-RVA: 0x2E8DA70 Offset: 0x2E8DB71 VA: 0x2E8DA70
	|-ReadOnlyCollection<UIVertex>.GetEnumerator
	|
	|-RVA: 0x2E8ED10 Offset: 0x2E8EE11 VA: 0x2E8ED10
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|
	|-RVA: 0x2E8FE30 Offset: 0x2E8FF31 VA: 0x2E8FE30
	|-ReadOnlyCollection<Vector2>.GetEnumerator
	|
	|-RVA: 0x2E90ED0 Offset: 0x2E90FD1 VA: 0x2E90ED0
	|-ReadOnlyCollection<Vector2Int>.GetEnumerator
	|
	|-RVA: 0x2E91F80 Offset: 0x2E92081 VA: 0x2E91F80
	|-ReadOnlyCollection<Vector3>.GetEnumerator
	|
	|-RVA: 0x2E93050 Offset: 0x2E93151 VA: 0x2E93050
	|-ReadOnlyCollection<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x2E94120 Offset: 0x2E94221 VA: 0x2E94120
	|-ReadOnlyCollection<Vector4>.GetEnumerator
	|
	|-RVA: 0x2E952F0 Offset: 0x2E953F1 VA: 0x2E952F0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.GetEnumerator
	|
	|-RVA: 0x2E965D0 Offset: 0x2E966D1 VA: 0x2E965D0
	|-ReadOnlyCollection<YieldItemParam>.GetEnumerator
	|
	|-RVA: 0x2E976C0 Offset: 0x2E977C1 VA: 0x2E976C0
	|-ReadOnlyCollection<stCommand_t>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8EB0 Offset: 0x2EE8FB1 VA: 0x2EE8EB0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x2EEA0E0 Offset: 0x2EEA1E1 VA: 0x2EEA0E0
	|-ReadOnlyCollection<BuildItemData>.IndexOf
	|
	|-RVA: 0x2EEB3D0 Offset: 0x2EEB4D1 VA: 0x2EEB3D0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x2EEC470 Offset: 0x2EEC571 VA: 0x2EEC470
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x2EED520 Offset: 0x2EED621 VA: 0x2EED520
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x2EEE5E0 Offset: 0x2EEE6E1 VA: 0x2EEE5E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x2EEF670 Offset: 0x2EEF771 VA: 0x2EEF670
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x2EF0700 Offset: 0x2EF0801 VA: 0x2EF0700
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x2EF1810 Offset: 0x2EF1911 VA: 0x2EF1810
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x2EF2A00 Offset: 0x2EF2B01 VA: 0x2EF2A00
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x2EF3BF0 Offset: 0x2EF3CF1 VA: 0x2EF3BF0
	|-ReadOnlyCollection<CropDataTable>.IndexOf
	|
	|-RVA: 0x2EF4D50 Offset: 0x2EF4E51 VA: 0x2EF4D50
	|-ReadOnlyCollection<DropItemParam>.IndexOf
	|
	|-RVA: 0x2EF5E40 Offset: 0x2EF5F41 VA: 0x2EF5E40
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x2EF6FB0 Offset: 0x2EF70B1 VA: 0x2EF6FB0
	|-ReadOnlyCollection<EventCheckId>.IndexOf
	|
	|-RVA: 0x2EF80D0 Offset: 0x2EF81D1 VA: 0x2EF80D0
	|-ReadOnlyCollection<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x2EF9170 Offset: 0x2EF9271 VA: 0x2EF9170
	|-ReadOnlyCollection<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x2EFA290 Offset: 0x2EFA391 VA: 0x2EFA290
	|-ReadOnlyCollection<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x2EFB480 Offset: 0x2EFB581 VA: 0x2EFB480
	|-ReadOnlyCollection<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x2EFC5F0 Offset: 0x2EFC6F1 VA: 0x2EFC5F0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x32E6550 Offset: 0x32E6651 VA: 0x32E6550
	|-ReadOnlyCollection<NPCActionData>.IndexOf
	|
	|-RVA: 0x32E7750 Offset: 0x32E7851 VA: 0x32E7750
	|-ReadOnlyCollection<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x32E8880 Offset: 0x32E8981 VA: 0x32E8880
	|-ReadOnlyCollection<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x32E9990 Offset: 0x32E9A91 VA: 0x32E9990
	|-ReadOnlyCollection<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x32EAAB0 Offset: 0x32EABB1 VA: 0x32EAAB0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x32EBB50 Offset: 0x32EBC51 VA: 0x32EBB50
	|-ReadOnlyCollection<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x32ECC60 Offset: 0x32ECD61 VA: 0x32ECC60
	|-ReadOnlyCollection<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x32EDDE0 Offset: 0x32EDEE1 VA: 0x32EDDE0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x32EEE90 Offset: 0x32EEF91 VA: 0x32EEE90
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x32EFF40 Offset: 0x32F0041 VA: 0x32EFF40
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x32F1050 Offset: 0x32F1151 VA: 0x32F1050
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x32F21C0 Offset: 0x32F22C1 VA: 0x32F21C0
	|-ReadOnlyCollection<Schedule>.IndexOf
	|
	|-RVA: 0x32F3390 Offset: 0x32F3491 VA: 0x32F3390
	|-ReadOnlyCollection<CurveSample>.IndexOf
	|
	|-RVA: 0x32F4590 Offset: 0x32F4691 VA: 0x32F4590
	|-ReadOnlyCollection<bool>.IndexOf
	|
	|-RVA: 0x32F5630 Offset: 0x32F5731 VA: 0x32F5630
	|-ReadOnlyCollection<byte>.IndexOf
	|
	|-RVA: 0x32F66C0 Offset: 0x32F67C1 VA: 0x32F66C0
	|-ReadOnlyCollection<char>.IndexOf
	|
	|-RVA: 0x32F7760 Offset: 0x32F7861 VA: 0x32F7760
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x32F8800 Offset: 0x32F8901 VA: 0x32F8800
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x32F98A0 Offset: 0x32F99A1 VA: 0x32F98A0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x32FA930 Offset: 0x32FAA31 VA: 0x32FA930
	|-ReadOnlyCollection<DateTime>.IndexOf
	|
	|-RVA: 0x32FB9C0 Offset: 0x32FBAC1 VA: 0x32FB9C0
	|-ReadOnlyCollection<double>.IndexOf
	|
	|-RVA: 0x32FCA50 Offset: 0x32FCB51 VA: 0x32FCA50
	|-ReadOnlyCollection<short>.IndexOf
	|
	|-RVA: 0x32FDAE0 Offset: 0x32FDBE1 VA: 0x32FDAE0
	|-ReadOnlyCollection<int>.IndexOf
	|
	|-RVA: 0x32FEB70 Offset: 0x32FEC71 VA: 0x32FEB70
	|-ReadOnlyCollection<Int32Enum>.IndexOf
	|
	|-RVA: 0x32FFC00 Offset: 0x32FFD01 VA: 0x32FFC00
	|-ReadOnlyCollection<long>.IndexOf
	|
	|-RVA: 0x3300CA0 Offset: 0x3300DA1 VA: 0x3300CA0
	|-ReadOnlyCollection<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x3301D30 Offset: 0x3301E31 VA: 0x3301D30
	|-ReadOnlyCollection<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x3302E40 Offset: 0x3302F41 VA: 0x3302E40
	|-ReadOnlyCollection<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x3304040 Offset: 0x3304141 VA: 0x3304040
	|-ReadOnlyCollection<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x33051C0 Offset: 0x33052C1 VA: 0x33051C0
	|-ReadOnlyCollection<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x33062B0 Offset: 0x33063B1 VA: 0x33062B0
	|-ReadOnlyCollection<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x3307420 Offset: 0x3307521 VA: 0x3307420
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x3308540 Offset: 0x3308641 VA: 0x3308540
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x33096F0 Offset: 0x33097F1 VA: 0x33096F0
	|-ReadOnlyCollection<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x3283DF0 Offset: 0x3283EF1 VA: 0x3283DF0
	|-ReadOnlyCollection<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x3284F50 Offset: 0x3285051 VA: 0x3284F50
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x32861E0 Offset: 0x32862E1 VA: 0x32861E0
	|-ReadOnlyCollection<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x3287350 Offset: 0x3287451 VA: 0x3287350
	|-ReadOnlyCollection<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x3288470 Offset: 0x3288571 VA: 0x3288470
	|-ReadOnlyCollection<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x3289620 Offset: 0x3289721 VA: 0x3289620
	|-ReadOnlyCollection<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x328A790 Offset: 0x328A891 VA: 0x328A790
	|-ReadOnlyCollection<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x328B870 Offset: 0x328B971 VA: 0x328B870
	|-ReadOnlyCollection<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x328C940 Offset: 0x328CA41 VA: 0x328C940
	|-ReadOnlyCollection<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x328D9E0 Offset: 0x328DAE1 VA: 0x328D9E0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x328EAD0 Offset: 0x328EBD1 VA: 0x328EAD0
	|-ReadOnlyCollection<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x328FC20 Offset: 0x328FD21 VA: 0x328FC20
	|-ReadOnlyCollection<object>.IndexOf
	|
	|-RVA: 0x3290BE0 Offset: 0x3290CE1 VA: 0x3290BE0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|
	|-RVA: 0x3291D00 Offset: 0x3291E01 VA: 0x3291D00
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|
	|-RVA: 0x3292D90 Offset: 0x3292E91 VA: 0x3292D90
	|-ReadOnlyCollection<sbyte>.IndexOf
	|
	|-RVA: 0x3293E20 Offset: 0x3293F21 VA: 0x3293E20
	|-ReadOnlyCollection<float>.IndexOf
	|
	|-RVA: 0x3294EB0 Offset: 0x3294FB1 VA: 0x3294EB0
	|-ReadOnlyCollection<ushort>.IndexOf
	|
	|-RVA: 0x3295F40 Offset: 0x3296041 VA: 0x3295F40
	|-ReadOnlyCollection<uint>.IndexOf
	|
	|-RVA: 0x3296FD0 Offset: 0x32970D1 VA: 0x3296FD0
	|-ReadOnlyCollection<ulong>.IndexOf
	|
	|-RVA: 0x3298060 Offset: 0x3298161 VA: 0x3298060
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32990F0 Offset: 0x32991F1 VA: 0x32990F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x329A190 Offset: 0x329A291 VA: 0x329A190
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x329B230 Offset: 0x329B331 VA: 0x329B230
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x329C2D0 Offset: 0x329C3D1 VA: 0x329C2D0
	|-ReadOnlyCollection<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x329D370 Offset: 0x329D471 VA: 0x329D370
	|-ReadOnlyCollection<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x329E420 Offset: 0x329E521 VA: 0x329E420
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x329F570 Offset: 0x329F671 VA: 0x329F570
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x32A07B0 Offset: 0x32A08B1 VA: 0x32A07B0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x32A1970 Offset: 0x32A1A71 VA: 0x32A1970
	|-ReadOnlyCollection<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x32A2A30 Offset: 0x32A2B31 VA: 0x32A2A30
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x32A3B50 Offset: 0x32A3C51 VA: 0x32A3B50
	|-ReadOnlyCollection<CapEdge>.IndexOf
	|
	|-RVA: 0x32A4CC0 Offset: 0x32A4DC1 VA: 0x32A4CC0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x32A5DB0 Offset: 0x32A5EB1 VA: 0x32A5DB0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x32A6F40 Offset: 0x32A7041 VA: 0x32A6F40
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x3177F20 Offset: 0x3178021 VA: 0x3177F20
	|-ReadOnlyCollection<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x31790C0 Offset: 0x31791C1 VA: 0x31790C0
	|-ReadOnlyCollection<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x317A380 Offset: 0x317A481 VA: 0x317A380
	|-ReadOnlyCollection<ConstraintSource>.IndexOf
	|
	|-RVA: 0x317B410 Offset: 0x317B511 VA: 0x317B410
	|-ReadOnlyCollection<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x317C4B0 Offset: 0x317C5B1 VA: 0x317C4B0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x317D5A0 Offset: 0x317D6A1 VA: 0x317D5A0
	|-ReadOnlyCollection<BoneWeight>.IndexOf
	|
	|-RVA: 0x317E710 Offset: 0x317E811 VA: 0x317E710
	|-ReadOnlyCollection<Bounds>.IndexOf
	|
	|-RVA: 0x317F880 Offset: 0x317F981 VA: 0x317F880
	|-ReadOnlyCollection<BoundsInt>.IndexOf
	|
	|-RVA: 0x31809B0 Offset: 0x3180AB1 VA: 0x31809B0
	|-ReadOnlyCollection<Color32>.IndexOf
	|
	|-RVA: 0x3181A80 Offset: 0x3181B81 VA: 0x3181A80
	|-ReadOnlyCollection<Color>.IndexOf
	|
	|-RVA: 0x3182C40 Offset: 0x3182D41 VA: 0x3182C40
	|-ReadOnlyCollection<CombineInstance>.IndexOf
	|
	|-RVA: 0x3183FB0 Offset: 0x31840B1 VA: 0x3183FB0
	|-ReadOnlyCollection<RaycastResult>.IndexOf
	|
	|-RVA: 0x31851C0 Offset: 0x31852C1 VA: 0x31851C0
	|-ReadOnlyCollection<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x31862C0 Offset: 0x31863C1 VA: 0x31862C0
	|-ReadOnlyCollection<GradientColorKey>.IndexOf
	|
	|-RVA: 0x3187450 Offset: 0x3187551 VA: 0x3187450
	|-ReadOnlyCollection<Keyframe>.IndexOf
	|
	|-RVA: 0x31885D0 Offset: 0x31886D1 VA: 0x31885D0
	|-ReadOnlyCollection<LayerMask>.IndexOf
	|
	|-RVA: 0x3189720 Offset: 0x3189821 VA: 0x3189720
	|-ReadOnlyCollection<Matrix4x4>.IndexOf
	|
	|-RVA: 0x318A930 Offset: 0x318AA31 VA: 0x318A930
	|-ReadOnlyCollection<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x318BA80 Offset: 0x318BB81 VA: 0x318BA80
	|-ReadOnlyCollection<Playable>.IndexOf
	|
	|-RVA: 0x318CB70 Offset: 0x318CC71 VA: 0x318CB70
	|-ReadOnlyCollection<PlayableBinding>.IndexOf
	|
	|-RVA: 0x318DC90 Offset: 0x318DD91 VA: 0x318DC90
	|-ReadOnlyCollection<PlayableGraph>.IndexOf
	|
	|-RVA: 0x318ED20 Offset: 0x318EE21 VA: 0x318ED20
	|-ReadOnlyCollection<Edge>.IndexOf
	|
	|-RVA: 0x318FDD0 Offset: 0x318FED1 VA: 0x318FDD0
	|-ReadOnlyCollection<Quaternion>.IndexOf
	|
	|-RVA: 0x3190E80 Offset: 0x3190F81 VA: 0x3190E80
	|-ReadOnlyCollection<RangeInt>.IndexOf
	|
	|-RVA: 0x3191FA0 Offset: 0x31920A1 VA: 0x3191FA0
	|-ReadOnlyCollection<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x31931B0 Offset: 0x31932B1 VA: 0x31931B0
	|-ReadOnlyCollection<RaycastHit>.IndexOf
	|
	|-RVA: 0x3194370 Offset: 0x3194471 VA: 0x3194370
	|-ReadOnlyCollection<Rect>.IndexOf
	|
	|-RVA: 0x3195430 Offset: 0x3195531 VA: 0x3195430
	|-ReadOnlyCollection<RectInt>.IndexOf
	|
	|-RVA: 0x31964D0 Offset: 0x31965D1 VA: 0x31964D0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x3197680 Offset: 0x3197781 VA: 0x3197680
	|-ReadOnlyCollection<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x3198970 Offset: 0x3198A71 VA: 0x3198970
	|-ReadOnlyCollection<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x3199A60 Offset: 0x3199B61 VA: 0x3199A60
	|-ReadOnlyCollection<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x319ABD0 Offset: 0x319ACD1 VA: 0x319ABD0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x319BD60 Offset: 0x319BE61 VA: 0x319BD60
	|-ReadOnlyCollection<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x2E82E60 Offset: 0x2E82F61 VA: 0x2E82E60
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x2E83FF0 Offset: 0x2E840F1 VA: 0x2E83FF0
	|-ReadOnlyCollection<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x2E85160 Offset: 0x2E85261 VA: 0x2E85160
	|-ReadOnlyCollection<GlyphRect>.IndexOf
	|
	|-RVA: 0x2E86270 Offset: 0x2E86371 VA: 0x2E86270
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x2E87430 Offset: 0x2E87531 VA: 0x2E87430
	|-ReadOnlyCollection<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x2E885A0 Offset: 0x2E886A1 VA: 0x2E885A0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x2E89710 Offset: 0x2E89811 VA: 0x2E89710
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x2E8A840 Offset: 0x2E8A941 VA: 0x2E8A840
	|-ReadOnlyCollection<UICharInfo>.IndexOf
	|
	|-RVA: 0x2E8B900 Offset: 0x2E8BA01 VA: 0x2E8B900
	|-ReadOnlyCollection<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x2E8C9A0 Offset: 0x2E8CAA1 VA: 0x2E8C9A0
	|-ReadOnlyCollection<UILineInfo>.IndexOf
	|
	|-RVA: 0x2E8DB10 Offset: 0x2E8DC11 VA: 0x2E8DB10
	|-ReadOnlyCollection<UIVertex>.IndexOf
	|
	|-RVA: 0x2E8EDB0 Offset: 0x2E8EEB1 VA: 0x2E8EDB0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2E8FED0 Offset: 0x2E8FFD1 VA: 0x2E8FED0
	|-ReadOnlyCollection<Vector2>.IndexOf
	|
	|-RVA: 0x2E90F70 Offset: 0x2E91071 VA: 0x2E90F70
	|-ReadOnlyCollection<Vector2Int>.IndexOf
	|
	|-RVA: 0x2E92020 Offset: 0x2E92121 VA: 0x2E92020
	|-ReadOnlyCollection<Vector3>.IndexOf
	|
	|-RVA: 0x2E930F0 Offset: 0x2E931F1 VA: 0x2E930F0
	|-ReadOnlyCollection<Vector3Int>.IndexOf
	|
	|-RVA: 0x2E941C0 Offset: 0x2E942C1 VA: 0x2E941C0
	|-ReadOnlyCollection<Vector4>.IndexOf
	|
	|-RVA: 0x2E95390 Offset: 0x2E95491 VA: 0x2E95390
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2E96670 Offset: 0x2E96771 VA: 0x2E96670
	|-ReadOnlyCollection<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2E97760 Offset: 0x2E97861 VA: 0x2E97760
	|-ReadOnlyCollection<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8FA0 Offset: 0x2EE90A1 VA: 0x2EE8FA0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.get_Items
	|
	|-RVA: 0x2EEA260 Offset: 0x2EEA361 VA: 0x2EEA260
	|-ReadOnlyCollection<BuildItemData>.get_Items
	|
	|-RVA: 0x2EEB490 Offset: 0x2EEB591 VA: 0x2EEB490
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.get_Items
	|
	|-RVA: 0x2EEC530 Offset: 0x2EEC631 VA: 0x2EEC530
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.get_Items
	|
	|-RVA: 0x2EED5E0 Offset: 0x2EED6E1 VA: 0x2EED5E0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.get_Items
	|
	|-RVA: 0x2EEE6A0 Offset: 0x2EEE7A1 VA: 0x2EEE6A0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Items
	|
	|-RVA: 0x2EEF720 Offset: 0x2EEF821 VA: 0x2EEF720
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Items
	|
	|-RVA: 0x2EF07B0 Offset: 0x2EF08B1 VA: 0x2EF07B0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Items
	|
	|-RVA: 0x2EF1910 Offset: 0x2EF1A11 VA: 0x2EF1910
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Items
	|
	|-RVA: 0x2EF2B10 Offset: 0x2EF2C11 VA: 0x2EF2B10
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Items
	|
	|-RVA: 0x2EF3CE0 Offset: 0x2EF3DE1 VA: 0x2EF3CE0
	|-ReadOnlyCollection<CropDataTable>.get_Items
	|
	|-RVA: 0x2EF4E00 Offset: 0x2EF4F01 VA: 0x2EF4E00
	|-ReadOnlyCollection<DropItemParam>.get_Items
	|
	|-RVA: 0x2EF5F30 Offset: 0x2EF6031 VA: 0x2EF5F30
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.get_Items
	|
	|-RVA: 0x2EF70A0 Offset: 0x2EF71A1 VA: 0x2EF70A0
	|-ReadOnlyCollection<EventCheckId>.get_Items
	|
	|-RVA: 0x2EF8190 Offset: 0x2EF8291 VA: 0x2EF8190
	|-ReadOnlyCollection<EventFlagProgressData>.get_Items
	|
	|-RVA: 0x2EF9230 Offset: 0x2EF9331 VA: 0x2EF9230
	|-ReadOnlyCollection<FesNpcScoreData>.get_Items
	|
	|-RVA: 0x2EFA3A0 Offset: 0x2EFA4A1 VA: 0x2EFA3A0
	|-ReadOnlyCollection<MiningPointSaveData>.get_Items
	|
	|-RVA: 0x2EFB580 Offset: 0x2EFB681 VA: 0x2EFB580
	|-ReadOnlyCollection<MonsterHutSaveData>.get_Items
	|
	|-RVA: 0x2EFC6B0 Offset: 0x2EFC7B1 VA: 0x2EFC6B0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.get_Items
	|
	|-RVA: 0x32E6670 Offset: 0x32E6771 VA: 0x32E6670
	|-ReadOnlyCollection<NPCActionData>.get_Items
	|
	|-RVA: 0x32E7840 Offset: 0x32E7941 VA: 0x32E7840
	|-ReadOnlyCollection<NpcPlaceSchedule>.get_Items
	|
	|-RVA: 0x32E8940 Offset: 0x32E8A41 VA: 0x32E8940
	|-ReadOnlyCollection<OrderLotterySaveParameter>.get_Items
	|
	|-RVA: 0x32E9A80 Offset: 0x32E9B81 VA: 0x32E9A80
	|-ReadOnlyCollection<OrderSaveParameter>.get_Items
	|
	|-RVA: 0x32EAB70 Offset: 0x32EAC71 VA: 0x32EAB70
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Items
	|
	|-RVA: 0x32EBC10 Offset: 0x32EBD11 VA: 0x32EBC10
	|-ReadOnlyCollection<ShopCatalogPage>.get_Items
	|
	|-RVA: 0x32ECD60 Offset: 0x32ECE61 VA: 0x32ECD60
	|-ReadOnlyCollection<ShopNpcTalk>.get_Items
	|
	|-RVA: 0x32EDEA0 Offset: 0x32EDFA1 VA: 0x32EDEA0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.get_Items
	|
	|-RVA: 0x32EEF40 Offset: 0x32EF041 VA: 0x32EEF40
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.get_Items
	|
	|-RVA: 0x32F0000 Offset: 0x32F0101 VA: 0x32F0000
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.get_Items
	|
	|-RVA: 0x32F1140 Offset: 0x32F1241 VA: 0x32F1140
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.get_Items
	|
	|-RVA: 0x32F22B0 Offset: 0x32F23B1 VA: 0x32F22B0
	|-ReadOnlyCollection<Schedule>.get_Items
	|
	|-RVA: 0x32F34C0 Offset: 0x32F35C1 VA: 0x32F34C0
	|-ReadOnlyCollection<CurveSample>.get_Items
	|
	|-RVA: 0x32F4640 Offset: 0x32F4741 VA: 0x32F4640
	|-ReadOnlyCollection<bool>.get_Items
	|
	|-RVA: 0x32F56E0 Offset: 0x32F57E1 VA: 0x32F56E0
	|-ReadOnlyCollection<byte>.get_Items
	|
	|-RVA: 0x32F6770 Offset: 0x32F6871 VA: 0x32F6770
	|-ReadOnlyCollection<char>.get_Items
	|
	|-RVA: 0x32F7820 Offset: 0x32F7921 VA: 0x32F7820
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.get_Items
	|
	|-RVA: 0x32F88C0 Offset: 0x32F89C1 VA: 0x32F88C0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Items
	|
	|-RVA: 0x32F9960 Offset: 0x32F9A61 VA: 0x32F9960
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Items
	|
	|-RVA: 0x32FA9E0 Offset: 0x32FAAE1 VA: 0x32FA9E0
	|-ReadOnlyCollection<DateTime>.get_Items
	|
	|-RVA: 0x32FBA70 Offset: 0x32FBB71 VA: 0x32FBA70
	|-ReadOnlyCollection<double>.get_Items
	|
	|-RVA: 0x32FCB00 Offset: 0x32FCC01 VA: 0x32FCB00
	|-ReadOnlyCollection<short>.get_Items
	|
	|-RVA: 0x32FDB90 Offset: 0x32FDC91 VA: 0x32FDB90
	|-ReadOnlyCollection<int>.get_Items
	|
	|-RVA: 0x32FEC20 Offset: 0x32FED21 VA: 0x32FEC20
	|-ReadOnlyCollection<Int32Enum>.get_Items
	|
	|-RVA: 0x32FFCB0 Offset: 0x32FFDB1 VA: 0x32FFCB0
	|-ReadOnlyCollection<long>.get_Items
	|
	|-RVA: 0x3300D60 Offset: 0x3300E61 VA: 0x3300D60
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Items
	|
	|-RVA: 0x3301DE0 Offset: 0x3301EE1 VA: 0x3301DE0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.get_Items
	|
	|-RVA: 0x3302F40 Offset: 0x3303041 VA: 0x3302F40
	|-ReadOnlyCollection<Nullable<Bounds>>.get_Items
	|
	|-RVA: 0x3304140 Offset: 0x3304241 VA: 0x3304140
	|-ReadOnlyCollection<Nullable<BoundsInt>>.get_Items
	|
	|-RVA: 0x3305270 Offset: 0x3305371 VA: 0x3305270
	|-ReadOnlyCollection<Nullable<Color32>>.get_Items
	|
	|-RVA: 0x33063A0 Offset: 0x33064A1 VA: 0x33063A0
	|-ReadOnlyCollection<Nullable<Color>>.get_Items
	|
	|-RVA: 0x33074E0 Offset: 0x33075E1 VA: 0x33074E0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.get_Items
	|
	|-RVA: 0x3308630 Offset: 0x3308731 VA: 0x3308630
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.get_Items
	|
	|-RVA: 0x33097E0 Offset: 0x33098E1 VA: 0x33097E0
	|-ReadOnlyCollection<Nullable<Keyframe>>.get_Items
	|
	|-RVA: 0x3283EA0 Offset: 0x3283FA1 VA: 0x3283EA0
	|-ReadOnlyCollection<Nullable<LayerMask>>.get_Items
	|
	|-RVA: 0x3285090 Offset: 0x3285191 VA: 0x3285090
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.get_Items
	|
	|-RVA: 0x32862D0 Offset: 0x32863D1 VA: 0x32862D0
	|-ReadOnlyCollection<Nullable<Quaternion>>.get_Items
	|
	|-RVA: 0x3287410 Offset: 0x3287511 VA: 0x3287410
	|-ReadOnlyCollection<Nullable<RangeInt>>.get_Items
	|
	|-RVA: 0x3288560 Offset: 0x3288661 VA: 0x3288560
	|-ReadOnlyCollection<Nullable<Rect>>.get_Items
	|
	|-RVA: 0x3289710 Offset: 0x3289811 VA: 0x3289710
	|-ReadOnlyCollection<Nullable<RectInt>>.get_Items
	|
	|-RVA: 0x328A850 Offset: 0x328A951 VA: 0x328A850
	|-ReadOnlyCollection<Nullable<Vector2>>.get_Items
	|
	|-RVA: 0x328B930 Offset: 0x328BA31 VA: 0x328B930
	|-ReadOnlyCollection<Nullable<Vector2Int>>.get_Items
	|
	|-RVA: 0x328CA00 Offset: 0x328CB01 VA: 0x328CA00
	|-ReadOnlyCollection<Nullable<Vector3>>.get_Items
	|
	|-RVA: 0x328DAA0 Offset: 0x328DBA1 VA: 0x328DAA0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.get_Items
	|
	|-RVA: 0x328EBC0 Offset: 0x328ECC1 VA: 0x328EBC0
	|-ReadOnlyCollection<Nullable<Vector4>>.get_Items
	|
	|-RVA: 0x328FCD0 Offset: 0x328FDD1 VA: 0x328FCD0
	|-ReadOnlyCollection<object>.get_Items
	|
	|-RVA: 0x3290CD0 Offset: 0x3290DD1 VA: 0x3290CD0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Items
	|
	|-RVA: 0x3291DC0 Offset: 0x3291EC1 VA: 0x3291DC0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Items
	|
	|-RVA: 0x3292E40 Offset: 0x3292F41 VA: 0x3292E40
	|-ReadOnlyCollection<sbyte>.get_Items
	|
	|-RVA: 0x3293ED0 Offset: 0x3293FD1 VA: 0x3293ED0
	|-ReadOnlyCollection<float>.get_Items
	|
	|-RVA: 0x3294F60 Offset: 0x3295061 VA: 0x3294F60
	|-ReadOnlyCollection<ushort>.get_Items
	|
	|-RVA: 0x3295FF0 Offset: 0x32960F1 VA: 0x3295FF0
	|-ReadOnlyCollection<uint>.get_Items
	|
	|-RVA: 0x3297080 Offset: 0x3297181 VA: 0x3297080
	|-ReadOnlyCollection<ulong>.get_Items
	|
	|-RVA: 0x3298110 Offset: 0x3298211 VA: 0x3298110
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.get_Items
	|
	|-RVA: 0x32991A0 Offset: 0x32992A1 VA: 0x32991A0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.get_Items
	|
	|-RVA: 0x329A250 Offset: 0x329A351 VA: 0x329A250
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.get_Items
	|
	|-RVA: 0x329B2F0 Offset: 0x329B3F1 VA: 0x329B2F0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.get_Items
	|
	|-RVA: 0x329C390 Offset: 0x329C491 VA: 0x329C390
	|-ReadOnlyCollection<ValueTuple<object, object>>.get_Items
	|
	|-RVA: 0x329D430 Offset: 0x329D531 VA: 0x329D430
	|-ReadOnlyCollection<ValueTuple<object, float>>.get_Items
	|
	|-RVA: 0x329E4E0 Offset: 0x329E5E1 VA: 0x329E4E0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Items
	|
	|-RVA: 0x329F690 Offset: 0x329F791 VA: 0x329F690
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Items
	|
	|-RVA: 0x32A08D0 Offset: 0x32A09D1 VA: 0x32A08D0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Items
	|
	|-RVA: 0x32A1A30 Offset: 0x32A1B31 VA: 0x32A1A30
	|-ReadOnlyCollection<TutorialUnlockFlagData>.get_Items
	|
	|-RVA: 0x32A2AF0 Offset: 0x32A2BF1 VA: 0x32A2AF0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.get_Items
	|
	|-RVA: 0x32A3C60 Offset: 0x32A3D61 VA: 0x32A3C60
	|-ReadOnlyCollection<CapEdge>.get_Items
	|
	|-RVA: 0x32A4D70 Offset: 0x32A4E71 VA: 0x32A4D70
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.get_Items
	|
	|-RVA: 0x32A5EA0 Offset: 0x32A5FA1 VA: 0x32A5EA0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.get_Items
	|
	|-RVA: 0x32A7040 Offset: 0x32A7141 VA: 0x32A7040
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.get_Items
	|
	|-RVA: 0x3177FE0 Offset: 0x31780E1 VA: 0x3177FE0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.get_Items
	|
	|-RVA: 0x3179230 Offset: 0x3179331 VA: 0x3179230
	|-ReadOnlyCollection<NavMeshBuildSource>.get_Items
	|
	|-RVA: 0x317A440 Offset: 0x317A541 VA: 0x317A440
	|-ReadOnlyCollection<ConstraintSource>.get_Items
	|
	|-RVA: 0x317B4C0 Offset: 0x317B5C1 VA: 0x317B4C0
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Items
	|
	|-RVA: 0x317C570 Offset: 0x317C671 VA: 0x317C570
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Items
	|
	|-RVA: 0x317D690 Offset: 0x317D791 VA: 0x317D690
	|-ReadOnlyCollection<BoneWeight>.get_Items
	|
	|-RVA: 0x317E800 Offset: 0x317E901 VA: 0x317E800
	|-ReadOnlyCollection<Bounds>.get_Items
	|
	|-RVA: 0x317F970 Offset: 0x317FA71 VA: 0x317F970
	|-ReadOnlyCollection<BoundsInt>.get_Items
	|
	|-RVA: 0x3180A70 Offset: 0x3180B71 VA: 0x3180A70
	|-ReadOnlyCollection<Color32>.get_Items
	|
	|-RVA: 0x3181B50 Offset: 0x3181C51 VA: 0x3181B50
	|-ReadOnlyCollection<Color>.get_Items
	|
	|-RVA: 0x3182DB0 Offset: 0x3182EB1 VA: 0x3182DB0
	|-ReadOnlyCollection<CombineInstance>.get_Items
	|
	|-RVA: 0x31840E0 Offset: 0x31841E1 VA: 0x31840E0
	|-ReadOnlyCollection<RaycastResult>.get_Items
	|
	|-RVA: 0x3185280 Offset: 0x3185381 VA: 0x3185280
	|-ReadOnlyCollection<GradientAlphaKey>.get_Items
	|
	|-RVA: 0x31863B0 Offset: 0x31864B1 VA: 0x31863B0
	|-ReadOnlyCollection<GradientColorKey>.get_Items
	|
	|-RVA: 0x3187550 Offset: 0x3187651 VA: 0x3187550
	|-ReadOnlyCollection<Keyframe>.get_Items
	|
	|-RVA: 0x3188690 Offset: 0x3188791 VA: 0x3188690
	|-ReadOnlyCollection<LayerMask>.get_Items
	|
	|-RVA: 0x3189840 Offset: 0x3189941 VA: 0x3189840
	|-ReadOnlyCollection<Matrix4x4>.get_Items
	|
	|-RVA: 0x318AA20 Offset: 0x318AB21 VA: 0x318AA20
	|-ReadOnlyCollection<ParticleSystem.Particle>.get_Items
	|
	|-RVA: 0x318BB40 Offset: 0x318BC41 VA: 0x318BB40
	|-ReadOnlyCollection<Playable>.get_Items
	|
	|-RVA: 0x318CC60 Offset: 0x318CD61 VA: 0x318CC60
	|-ReadOnlyCollection<PlayableBinding>.get_Items
	|
	|-RVA: 0x318DD50 Offset: 0x318DE51 VA: 0x318DD50
	|-ReadOnlyCollection<PlayableGraph>.get_Items
	|
	|-RVA: 0x318EDD0 Offset: 0x318EED1 VA: 0x318EDD0
	|-ReadOnlyCollection<Edge>.get_Items
	|
	|-RVA: 0x318FEA0 Offset: 0x318FFA1 VA: 0x318FEA0
	|-ReadOnlyCollection<Quaternion>.get_Items
	|
	|-RVA: 0x3190F30 Offset: 0x3191031 VA: 0x3190F30
	|-ReadOnlyCollection<RangeInt>.get_Items
	|
	|-RVA: 0x31920B0 Offset: 0x31921B1 VA: 0x31920B0
	|-ReadOnlyCollection<RaycastHit2D>.get_Items
	|
	|-RVA: 0x31932D0 Offset: 0x31933D1 VA: 0x31932D0
	|-ReadOnlyCollection<RaycastHit>.get_Items
	|
	|-RVA: 0x3194440 Offset: 0x3194541 VA: 0x3194440
	|-ReadOnlyCollection<Rect>.get_Items
	|
	|-RVA: 0x31954F0 Offset: 0x31955F1 VA: 0x31954F0
	|-ReadOnlyCollection<RectInt>.get_Items
	|
	|-RVA: 0x3196590 Offset: 0x3196691 VA: 0x3196590
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.get_Items
	|
	|-RVA: 0x3197800 Offset: 0x3197901 VA: 0x3197800
	|-ReadOnlyCollection<SphericalHarmonicsL2>.get_Items
	|
	|-RVA: 0x3198A30 Offset: 0x3198B31 VA: 0x3198A30
	|-ReadOnlyCollection<VertexAttributeDescriptor>.get_Items
	|
	|-RVA: 0x3199B50 Offset: 0x3199C51 VA: 0x3199B50
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Items
	|
	|-RVA: 0x319ACC0 Offset: 0x319ADC1 VA: 0x319ACC0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.get_Items
	|
	|-RVA: 0x319BE60 Offset: 0x319BF61 VA: 0x319BE60
	|-ReadOnlyCollection<DiagnosticEvent>.get_Items
	|
	|-RVA: 0x2E82F50 Offset: 0x2E83051 VA: 0x2E82F50
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Items
	|
	|-RVA: 0x2E840F0 Offset: 0x2E841F1 VA: 0x2E840F0
	|-ReadOnlyCollection<ObjectInitializationData>.get_Items
	|
	|-RVA: 0x2E85220 Offset: 0x2E85321 VA: 0x2E85220
	|-ReadOnlyCollection<GlyphRect>.get_Items
	|
	|-RVA: 0x2E86370 Offset: 0x2E86471 VA: 0x2E86370
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Items
	|
	|-RVA: 0x2E87520 Offset: 0x2E87621 VA: 0x2E87520
	|-ReadOnlyCollection<IntervalTreeNode>.get_Items
	|
	|-RVA: 0x2E88690 Offset: 0x2E88791 VA: 0x2E88690
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Items
	|
	|-RVA: 0x2E89800 Offset: 0x2E89901 VA: 0x2E89800
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Items
	|
	|-RVA: 0x2E8A910 Offset: 0x2E8AA11 VA: 0x2E8A910
	|-ReadOnlyCollection<UICharInfo>.get_Items
	|
	|-RVA: 0x2E8B9C0 Offset: 0x2E8BAC1 VA: 0x2E8B9C0
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Items
	|
	|-RVA: 0x2E8CA60 Offset: 0x2E8CB61 VA: 0x2E8CA60
	|-ReadOnlyCollection<UILineInfo>.get_Items
	|
	|-RVA: 0x2E8DC60 Offset: 0x2E8DD61 VA: 0x2E8DC60
	|-ReadOnlyCollection<UIVertex>.get_Items
	|
	|-RVA: 0x2E8EEA0 Offset: 0x2E8EFA1 VA: 0x2E8EEA0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Items
	|
	|-RVA: 0x2E8FF90 Offset: 0x2E90091 VA: 0x2E8FF90
	|-ReadOnlyCollection<Vector2>.get_Items
	|
	|-RVA: 0x2E91020 Offset: 0x2E91121 VA: 0x2E91020
	|-ReadOnlyCollection<Vector2Int>.get_Items
	|
	|-RVA: 0x2E920F0 Offset: 0x2E921F1 VA: 0x2E920F0
	|-ReadOnlyCollection<Vector3>.get_Items
	|
	|-RVA: 0x2E931B0 Offset: 0x2E932B1 VA: 0x2E931B0
	|-ReadOnlyCollection<Vector3Int>.get_Items
	|
	|-RVA: 0x2E94290 Offset: 0x2E94391 VA: 0x2E94290
	|-ReadOnlyCollection<Vector4>.get_Items
	|
	|-RVA: 0x2E95510 Offset: 0x2E95611 VA: 0x2E95510
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.get_Items
	|
	|-RVA: 0x2E96720 Offset: 0x2E96821 VA: 0x2E96720
	|-ReadOnlyCollection<YieldItemParam>.get_Items
	|
	|-RVA: 0x2E97850 Offset: 0x2E97951 VA: 0x2E97850
	|-ReadOnlyCollection<stCommand_t>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8FB0 Offset: 0x2EE90B1 VA: 0x2EE8FB0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EEA270 Offset: 0x2EEA371 VA: 0x2EEA270
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EEB4A0 Offset: 0x2EEB5A1 VA: 0x2EEB4A0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EEC540 Offset: 0x2EEC641 VA: 0x2EEC540
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EED5F0 Offset: 0x2EED6F1 VA: 0x2EED5F0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EEE6B0 Offset: 0x2EEE7B1 VA: 0x2EEE6B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EEF730 Offset: 0x2EEF831 VA: 0x2EEF730
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF07C0 Offset: 0x2EF08C1 VA: 0x2EF07C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF1920 Offset: 0x2EF1A21 VA: 0x2EF1920
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF2B20 Offset: 0x2EF2C21 VA: 0x2EF2B20
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF3CF0 Offset: 0x2EF3DF1 VA: 0x2EF3CF0
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF4E10 Offset: 0x2EF4F11 VA: 0x2EF4E10
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF5F40 Offset: 0x2EF6041 VA: 0x2EF5F40
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF70B0 Offset: 0x2EF71B1 VA: 0x2EF70B0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF81A0 Offset: 0x2EF82A1 VA: 0x2EF81A0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EF9240 Offset: 0x2EF9341 VA: 0x2EF9240
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EFA3B0 Offset: 0x2EFA4B1 VA: 0x2EFA3B0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EFB590 Offset: 0x2EFB691 VA: 0x2EFB590
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2EFC6C0 Offset: 0x2EFC7C1 VA: 0x2EFC6C0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32E6680 Offset: 0x32E6781 VA: 0x32E6680
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32E7850 Offset: 0x32E7951 VA: 0x32E7850
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32E8950 Offset: 0x32E8A51 VA: 0x32E8950
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32E9A90 Offset: 0x32E9B91 VA: 0x32E9A90
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32EAB80 Offset: 0x32EAC81 VA: 0x32EAB80
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32EBC20 Offset: 0x32EBD21 VA: 0x32EBC20
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32ECD70 Offset: 0x32ECE71 VA: 0x32ECD70
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32EDEB0 Offset: 0x32EDFB1 VA: 0x32EDEB0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32EEF50 Offset: 0x32EF051 VA: 0x32EEF50
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F0010 Offset: 0x32F0111 VA: 0x32F0010
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F1150 Offset: 0x32F1251 VA: 0x32F1150
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F22C0 Offset: 0x32F23C1 VA: 0x32F22C0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F34D0 Offset: 0x32F35D1 VA: 0x32F34D0
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F4650 Offset: 0x32F4751 VA: 0x32F4650
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F56F0 Offset: 0x32F57F1 VA: 0x32F56F0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F6780 Offset: 0x32F6881 VA: 0x32F6780
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F7830 Offset: 0x32F7931 VA: 0x32F7830
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F88D0 Offset: 0x32F89D1 VA: 0x32F88D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32F9970 Offset: 0x32F9A71 VA: 0x32F9970
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32FA9F0 Offset: 0x32FAAF1 VA: 0x32FA9F0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32FBA80 Offset: 0x32FBB81 VA: 0x32FBA80
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32FCB10 Offset: 0x32FCC11 VA: 0x32FCB10
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32FDBA0 Offset: 0x32FDCA1 VA: 0x32FDBA0
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32FEC30 Offset: 0x32FED31 VA: 0x32FEC30
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32FFCC0 Offset: 0x32FFDC1 VA: 0x32FFCC0
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3300D70 Offset: 0x3300E71 VA: 0x3300D70
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3301DF0 Offset: 0x3301EF1 VA: 0x3301DF0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3302F50 Offset: 0x3303051 VA: 0x3302F50
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3304150 Offset: 0x3304251 VA: 0x3304150
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3305280 Offset: 0x3305381 VA: 0x3305280
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33063B0 Offset: 0x33064B1 VA: 0x33063B0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33074F0 Offset: 0x33075F1 VA: 0x33074F0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3308640 Offset: 0x3308741 VA: 0x3308640
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33097F0 Offset: 0x33098F1 VA: 0x33097F0
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3283EB0 Offset: 0x3283FB1 VA: 0x3283EB0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32850A0 Offset: 0x32851A1 VA: 0x32850A0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32862E0 Offset: 0x32863E1 VA: 0x32862E0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3287420 Offset: 0x3287521 VA: 0x3287420
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3288570 Offset: 0x3288671 VA: 0x3288570
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3289720 Offset: 0x3289821 VA: 0x3289720
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x328A860 Offset: 0x328A961 VA: 0x328A860
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x328B940 Offset: 0x328BA41 VA: 0x328B940
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x328CA10 Offset: 0x328CB11 VA: 0x328CA10
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x328DAB0 Offset: 0x328DBB1 VA: 0x328DAB0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x328EBD0 Offset: 0x328ECD1 VA: 0x328EBD0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x328FCE0 Offset: 0x328FDE1 VA: 0x328FCE0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3290CE0 Offset: 0x3290DE1 VA: 0x3290CE0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3291DD0 Offset: 0x3291ED1 VA: 0x3291DD0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3292E50 Offset: 0x3292F51 VA: 0x3292E50
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3293EE0 Offset: 0x3293FE1 VA: 0x3293EE0
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3294F70 Offset: 0x3295071 VA: 0x3294F70
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3296000 Offset: 0x3296101 VA: 0x3296000
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3297090 Offset: 0x3297191 VA: 0x3297090
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3298120 Offset: 0x3298221 VA: 0x3298120
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32991B0 Offset: 0x32992B1 VA: 0x32991B0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x329A260 Offset: 0x329A361 VA: 0x329A260
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x329B300 Offset: 0x329B401 VA: 0x329B300
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x329C3A0 Offset: 0x329C4A1 VA: 0x329C3A0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x329D440 Offset: 0x329D541 VA: 0x329D440
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x329E4F0 Offset: 0x329E5F1 VA: 0x329E4F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x329F6A0 Offset: 0x329F7A1 VA: 0x329F6A0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A08E0 Offset: 0x32A09E1 VA: 0x32A08E0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A1A40 Offset: 0x32A1B41 VA: 0x32A1A40
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A2B00 Offset: 0x32A2C01 VA: 0x32A2B00
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A3C70 Offset: 0x32A3D71 VA: 0x32A3C70
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A4D80 Offset: 0x32A4E81 VA: 0x32A4D80
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A5EB0 Offset: 0x32A5FB1 VA: 0x32A5EB0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A7050 Offset: 0x32A7151 VA: 0x32A7050
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3177FF0 Offset: 0x31780F1 VA: 0x3177FF0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3179240 Offset: 0x3179341 VA: 0x3179240
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x317A450 Offset: 0x317A551 VA: 0x317A450
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x317B4D0 Offset: 0x317B5D1 VA: 0x317B4D0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x317C580 Offset: 0x317C681 VA: 0x317C580
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x317D6A0 Offset: 0x317D7A1 VA: 0x317D6A0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x317E810 Offset: 0x317E911 VA: 0x317E810
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x317F980 Offset: 0x317FA81 VA: 0x317F980
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3180A80 Offset: 0x3180B81 VA: 0x3180A80
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3181B60 Offset: 0x3181C61 VA: 0x3181B60
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3182DC0 Offset: 0x3182EC1 VA: 0x3182DC0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31840F0 Offset: 0x31841F1 VA: 0x31840F0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3185290 Offset: 0x3185391 VA: 0x3185290
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31863C0 Offset: 0x31864C1 VA: 0x31863C0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3187560 Offset: 0x3187661 VA: 0x3187560
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31886A0 Offset: 0x31887A1 VA: 0x31886A0
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3189850 Offset: 0x3189951 VA: 0x3189850
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x318AA30 Offset: 0x318AB31 VA: 0x318AA30
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x318BB50 Offset: 0x318BC51 VA: 0x318BB50
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x318CC70 Offset: 0x318CD71 VA: 0x318CC70
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x318DD60 Offset: 0x318DE61 VA: 0x318DD60
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x318EDE0 Offset: 0x318EEE1 VA: 0x318EDE0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x318FEB0 Offset: 0x318FFB1 VA: 0x318FEB0
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3190F40 Offset: 0x3191041 VA: 0x3190F40
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31920C0 Offset: 0x31921C1 VA: 0x31920C0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31932E0 Offset: 0x31933E1 VA: 0x31932E0
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3194450 Offset: 0x3194551 VA: 0x3194450
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3195500 Offset: 0x3195601 VA: 0x3195500
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31965A0 Offset: 0x31966A1 VA: 0x31965A0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3197810 Offset: 0x3197911 VA: 0x3197810
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3198A40 Offset: 0x3198B41 VA: 0x3198A40
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3199B60 Offset: 0x3199C61 VA: 0x3199B60
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x319ACD0 Offset: 0x319ADD1 VA: 0x319ACD0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x319BE70 Offset: 0x319BF71 VA: 0x319BE70
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E82F60 Offset: 0x2E83061 VA: 0x2E82F60
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E84100 Offset: 0x2E84201 VA: 0x2E84100
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E85230 Offset: 0x2E85331 VA: 0x2E85230
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E86380 Offset: 0x2E86481 VA: 0x2E86380
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E87530 Offset: 0x2E87631 VA: 0x2E87530
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E886A0 Offset: 0x2E887A1 VA: 0x2E886A0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E89810 Offset: 0x2E89911 VA: 0x2E89810
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E8A920 Offset: 0x2E8AA21 VA: 0x2E8A920
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E8B9D0 Offset: 0x2E8BAD1 VA: 0x2E8B9D0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E8CA70 Offset: 0x2E8CB71 VA: 0x2E8CA70
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E8DC70 Offset: 0x2E8DD71 VA: 0x2E8DC70
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E8EEB0 Offset: 0x2E8EFB1 VA: 0x2E8EEB0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E8FFA0 Offset: 0x2E900A1 VA: 0x2E8FFA0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E91030 Offset: 0x2E91131 VA: 0x2E91030
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E92100 Offset: 0x2E92201 VA: 0x2E92100
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E931C0 Offset: 0x2E932C1 VA: 0x2E931C0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E942A0 Offset: 0x2E943A1 VA: 0x2E942A0
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E95520 Offset: 0x2E95621 VA: 0x2E95520
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E96730 Offset: 0x2E96831 VA: 0x2E96730
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2E97860 Offset: 0x2E97961 VA: 0x2E97860
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE8FC0 Offset: 0x2EE90C1 VA: 0x2EE8FC0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EEA280 Offset: 0x2EEA381 VA: 0x2EEA280
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EEB4B0 Offset: 0x2EEB5B1 VA: 0x2EEB4B0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EEC550 Offset: 0x2EEC651 VA: 0x2EEC550
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EED600 Offset: 0x2EED701 VA: 0x2EED600
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EEE6C0 Offset: 0x2EEE7C1 VA: 0x2EEE6C0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EEF740 Offset: 0x2EEF841 VA: 0x2EEF740
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF07D0 Offset: 0x2EF08D1 VA: 0x2EF07D0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF1930 Offset: 0x2EF1A31 VA: 0x2EF1930
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF2B30 Offset: 0x2EF2C31 VA: 0x2EF2B30
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF3D00 Offset: 0x2EF3E01 VA: 0x2EF3D00
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF4E20 Offset: 0x2EF4F21 VA: 0x2EF4E20
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF5F50 Offset: 0x2EF6051 VA: 0x2EF5F50
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF70C0 Offset: 0x2EF71C1 VA: 0x2EF70C0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF81B0 Offset: 0x2EF82B1 VA: 0x2EF81B0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EF9250 Offset: 0x2EF9351 VA: 0x2EF9250
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EFA3C0 Offset: 0x2EFA4C1 VA: 0x2EFA3C0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EFB5A0 Offset: 0x2EFB6A1 VA: 0x2EFB5A0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2EFC6D0 Offset: 0x2EFC7D1 VA: 0x2EFC6D0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32E6690 Offset: 0x32E6791 VA: 0x32E6690
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32E7860 Offset: 0x32E7961 VA: 0x32E7860
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32E8960 Offset: 0x32E8A61 VA: 0x32E8960
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32E9AA0 Offset: 0x32E9BA1 VA: 0x32E9AA0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32EAB90 Offset: 0x32EAC91 VA: 0x32EAB90
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32EBC30 Offset: 0x32EBD31 VA: 0x32EBC30
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32ECD80 Offset: 0x32ECE81 VA: 0x32ECD80
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32EDEC0 Offset: 0x32EDFC1 VA: 0x32EDEC0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32EEF60 Offset: 0x32EF061 VA: 0x32EEF60
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F0020 Offset: 0x32F0121 VA: 0x32F0020
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F1160 Offset: 0x32F1261 VA: 0x32F1160
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F22D0 Offset: 0x32F23D1 VA: 0x32F22D0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F34E0 Offset: 0x32F35E1 VA: 0x32F34E0
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F4660 Offset: 0x32F4761 VA: 0x32F4660
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F5700 Offset: 0x32F5801 VA: 0x32F5700
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F6790 Offset: 0x32F6891 VA: 0x32F6790
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F7840 Offset: 0x32F7941 VA: 0x32F7840
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F88E0 Offset: 0x32F89E1 VA: 0x32F88E0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32F9980 Offset: 0x32F9A81 VA: 0x32F9980
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32FAA00 Offset: 0x32FAB01 VA: 0x32FAA00
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32FBA90 Offset: 0x32FBB91 VA: 0x32FBA90
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32FCB20 Offset: 0x32FCC21 VA: 0x32FCB20
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32FDBB0 Offset: 0x32FDCB1 VA: 0x32FDBB0
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32FEC40 Offset: 0x32FED41 VA: 0x32FEC40
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32FFCD0 Offset: 0x32FFDD1 VA: 0x32FFCD0
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3300D80 Offset: 0x3300E81 VA: 0x3300D80
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3301E00 Offset: 0x3301F01 VA: 0x3301E00
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3302F60 Offset: 0x3303061 VA: 0x3302F60
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3304160 Offset: 0x3304261 VA: 0x3304160
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3305290 Offset: 0x3305391 VA: 0x3305290
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x33063C0 Offset: 0x33064C1 VA: 0x33063C0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3307500 Offset: 0x3307601 VA: 0x3307500
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3308650 Offset: 0x3308751 VA: 0x3308650
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3309800 Offset: 0x3309901 VA: 0x3309800
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3283EC0 Offset: 0x3283FC1 VA: 0x3283EC0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32850B0 Offset: 0x32851B1 VA: 0x32850B0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32862F0 Offset: 0x32863F1 VA: 0x32862F0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3287430 Offset: 0x3287531 VA: 0x3287430
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3288580 Offset: 0x3288681 VA: 0x3288580
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3289730 Offset: 0x3289831 VA: 0x3289730
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x328A870 Offset: 0x328A971 VA: 0x328A870
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x328B950 Offset: 0x328BA51 VA: 0x328B950
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x328CA20 Offset: 0x328CB21 VA: 0x328CA20
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x328DAC0 Offset: 0x328DBC1 VA: 0x328DAC0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x328EBE0 Offset: 0x328ECE1 VA: 0x328EBE0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x328FCF0 Offset: 0x328FDF1 VA: 0x328FCF0
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3290CF0 Offset: 0x3290DF1 VA: 0x3290CF0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3291DE0 Offset: 0x3291EE1 VA: 0x3291DE0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3292E60 Offset: 0x3292F61 VA: 0x3292E60
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3293EF0 Offset: 0x3293FF1 VA: 0x3293EF0
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3294F80 Offset: 0x3295081 VA: 0x3294F80
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3296010 Offset: 0x3296111 VA: 0x3296010
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32970A0 Offset: 0x32971A1 VA: 0x32970A0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3298130 Offset: 0x3298231 VA: 0x3298130
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32991C0 Offset: 0x32992C1 VA: 0x32991C0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x329A270 Offset: 0x329A371 VA: 0x329A270
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x329B310 Offset: 0x329B411 VA: 0x329B310
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x329C3B0 Offset: 0x329C4B1 VA: 0x329C3B0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x329D450 Offset: 0x329D551 VA: 0x329D450
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x329E500 Offset: 0x329E601 VA: 0x329E500
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x329F6B0 Offset: 0x329F7B1 VA: 0x329F6B0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A08F0 Offset: 0x32A09F1 VA: 0x32A08F0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A1A50 Offset: 0x32A1B51 VA: 0x32A1A50
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A2B10 Offset: 0x32A2C11 VA: 0x32A2B10
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A3C80 Offset: 0x32A3D81 VA: 0x32A3C80
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A4D90 Offset: 0x32A4E91 VA: 0x32A4D90
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A5EC0 Offset: 0x32A5FC1 VA: 0x32A5EC0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x32A7060 Offset: 0x32A7161 VA: 0x32A7060
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3178000 Offset: 0x3178101 VA: 0x3178000
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3179250 Offset: 0x3179351 VA: 0x3179250
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x317A460 Offset: 0x317A561 VA: 0x317A460
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x317B4E0 Offset: 0x317B5E1 VA: 0x317B4E0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x317C590 Offset: 0x317C691 VA: 0x317C590
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x317D6B0 Offset: 0x317D7B1 VA: 0x317D6B0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x317E820 Offset: 0x317E921 VA: 0x317E820
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x317F990 Offset: 0x317FA91 VA: 0x317F990
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3180A90 Offset: 0x3180B91 VA: 0x3180A90
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3181B70 Offset: 0x3181C71 VA: 0x3181B70
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3182DD0 Offset: 0x3182ED1 VA: 0x3182DD0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3184100 Offset: 0x3184201 VA: 0x3184100
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x31852A0 Offset: 0x31853A1 VA: 0x31852A0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x31863D0 Offset: 0x31864D1 VA: 0x31863D0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3187570 Offset: 0x3187671 VA: 0x3187570
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x31886B0 Offset: 0x31887B1 VA: 0x31886B0
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3189860 Offset: 0x3189961 VA: 0x3189860
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x318AA40 Offset: 0x318AB41 VA: 0x318AA40
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x318BB60 Offset: 0x318BC61 VA: 0x318BB60
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x318CC80 Offset: 0x318CD81 VA: 0x318CC80
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x318DD70 Offset: 0x318DE71 VA: 0x318DD70
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x318EDF0 Offset: 0x318EEF1 VA: 0x318EDF0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x318FEC0 Offset: 0x318FFC1 VA: 0x318FEC0
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3190F50 Offset: 0x3191051 VA: 0x3190F50
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x31920D0 Offset: 0x31921D1 VA: 0x31920D0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x31932F0 Offset: 0x31933F1 VA: 0x31932F0
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3194460 Offset: 0x3194561 VA: 0x3194460
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3195510 Offset: 0x3195611 VA: 0x3195510
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x31965B0 Offset: 0x31966B1 VA: 0x31965B0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3197820 Offset: 0x3197921 VA: 0x3197820
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3198A50 Offset: 0x3198B51 VA: 0x3198A50
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3199B70 Offset: 0x3199C71 VA: 0x3199B70
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x319ACE0 Offset: 0x319ADE1 VA: 0x319ACE0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x319BE80 Offset: 0x319BF81 VA: 0x319BE80
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E82F70 Offset: 0x2E83071 VA: 0x2E82F70
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E84110 Offset: 0x2E84211 VA: 0x2E84110
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E85240 Offset: 0x2E85341 VA: 0x2E85240
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E86390 Offset: 0x2E86491 VA: 0x2E86390
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E87540 Offset: 0x2E87641 VA: 0x2E87540
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E886B0 Offset: 0x2E887B1 VA: 0x2E886B0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E89820 Offset: 0x2E89921 VA: 0x2E89820
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E8A930 Offset: 0x2E8AA31 VA: 0x2E8A930
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E8B9E0 Offset: 0x2E8BAE1 VA: 0x2E8B9E0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E8CA80 Offset: 0x2E8CB81 VA: 0x2E8CA80
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E8DC80 Offset: 0x2E8DD81 VA: 0x2E8DC80
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E8EEC0 Offset: 0x2E8EFC1 VA: 0x2E8EEC0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E8FFB0 Offset: 0x2E900B1 VA: 0x2E8FFB0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E91040 Offset: 0x2E91141 VA: 0x2E91040
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E92110 Offset: 0x2E92211 VA: 0x2E92110
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E931D0 Offset: 0x2E932D1 VA: 0x2E931D0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E942B0 Offset: 0x2E943B1 VA: 0x2E942B0
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E95530 Offset: 0x2E95631 VA: 0x2E95530
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E96740 Offset: 0x2E96841 VA: 0x2E96740
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2E97870 Offset: 0x2E97971 VA: 0x2E97870
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9090 Offset: 0x2EE9191 VA: 0x2EE9090
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EEA380 Offset: 0x2EEA481 VA: 0x2EEA380
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EEB560 Offset: 0x2EEB661 VA: 0x2EEB560
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EEC600 Offset: 0x2EEC701 VA: 0x2EEC600
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EED6C0 Offset: 0x2EED7C1 VA: 0x2EED6C0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EEE770 Offset: 0x2EEE871 VA: 0x2EEE770
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EEF7F0 Offset: 0x2EEF8F1 VA: 0x2EEF7F0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF0880 Offset: 0x2EF0981 VA: 0x2EF0880
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF1A10 Offset: 0x2EF1B11 VA: 0x2EF1A10
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF2C10 Offset: 0x2EF2D11 VA: 0x2EF2C10
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF3DE0 Offset: 0x2EF3EE1 VA: 0x2EF3DE0
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF4ED0 Offset: 0x2EF4FD1 VA: 0x2EF4ED0
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF6020 Offset: 0x2EF6121 VA: 0x2EF6020
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF7190 Offset: 0x2EF7291 VA: 0x2EF7190
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF8260 Offset: 0x2EF8361 VA: 0x2EF8260
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EF9300 Offset: 0x2EF9401 VA: 0x2EF9300
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EFA4A0 Offset: 0x2EFA5A1 VA: 0x2EFA4A0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EFB680 Offset: 0x2EFB781 VA: 0x2EFB680
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2EFC780 Offset: 0x2EFC881 VA: 0x2EFC780
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32E6770 Offset: 0x32E6871 VA: 0x32E6770
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32E7930 Offset: 0x32E7A31 VA: 0x32E7930
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32E8A20 Offset: 0x32E8B21 VA: 0x32E8A20
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32E9B70 Offset: 0x32E9C71 VA: 0x32E9B70
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32EAC40 Offset: 0x32EAD41 VA: 0x32EAC40
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32EBCE0 Offset: 0x32EBDE1 VA: 0x32EBCE0
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32ECE60 Offset: 0x32ECF61 VA: 0x32ECE60
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32EDF80 Offset: 0x32EE081 VA: 0x32EDF80
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32EF010 Offset: 0x32EF111 VA: 0x32EF010
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F00E0 Offset: 0x32F01E1 VA: 0x32F00E0
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F1230 Offset: 0x32F1331 VA: 0x32F1230
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F23A0 Offset: 0x32F24A1 VA: 0x32F23A0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F35D0 Offset: 0x32F36D1 VA: 0x32F35D0
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F4710 Offset: 0x32F4811 VA: 0x32F4710
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F57B0 Offset: 0x32F58B1 VA: 0x32F57B0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F6840 Offset: 0x32F6941 VA: 0x32F6840
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F78F0 Offset: 0x32F79F1 VA: 0x32F78F0
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F8990 Offset: 0x32F8A91 VA: 0x32F8990
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32F9A30 Offset: 0x32F9B31 VA: 0x32F9A30
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32FAAB0 Offset: 0x32FABB1 VA: 0x32FAAB0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32FBB40 Offset: 0x32FBC41 VA: 0x32FBB40
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32FCBD0 Offset: 0x32FCCD1 VA: 0x32FCBD0
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32FDC60 Offset: 0x32FDD61 VA: 0x32FDC60
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32FECF0 Offset: 0x32FEDF1 VA: 0x32FECF0
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32FFD80 Offset: 0x32FFE81 VA: 0x32FFD80
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3300E30 Offset: 0x3300F31 VA: 0x3300E30
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3301EB0 Offset: 0x3301FB1 VA: 0x3301EB0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3303040 Offset: 0x3303141 VA: 0x3303040
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3304240 Offset: 0x3304341 VA: 0x3304240
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3305340 Offset: 0x3305441 VA: 0x3305340
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3306490 Offset: 0x3306591 VA: 0x3306490
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x33075C0 Offset: 0x33076C1 VA: 0x33075C0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3308720 Offset: 0x3308821 VA: 0x3308720
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x33098D0 Offset: 0x33099D1 VA: 0x33098D0
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3283F70 Offset: 0x3284071 VA: 0x3283F70
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32851A0 Offset: 0x32852A1 VA: 0x32851A0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32863C0 Offset: 0x32864C1 VA: 0x32863C0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32874F0 Offset: 0x32875F1 VA: 0x32874F0
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3288650 Offset: 0x3288751 VA: 0x3288650
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3289800 Offset: 0x3289901 VA: 0x3289800
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x328A930 Offset: 0x328AA31 VA: 0x328A930
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x328BA10 Offset: 0x328BB11 VA: 0x328BA10
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x328CAD0 Offset: 0x328CBD1 VA: 0x328CAD0
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x328DB70 Offset: 0x328DC71 VA: 0x328DB70
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x328ECB0 Offset: 0x328EDB1 VA: 0x328ECB0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x328FDA0 Offset: 0x328FEA1 VA: 0x328FDA0
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3290DC0 Offset: 0x3290EC1 VA: 0x3290DC0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3291E90 Offset: 0x3291F91 VA: 0x3291E90
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3292F10 Offset: 0x3293011 VA: 0x3292F10
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3293FA0 Offset: 0x32940A1 VA: 0x3293FA0
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3295030 Offset: 0x3295131 VA: 0x3295030
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32960C0 Offset: 0x32961C1 VA: 0x32960C0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3297150 Offset: 0x3297251 VA: 0x3297150
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32981E0 Offset: 0x32982E1 VA: 0x32981E0
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3299270 Offset: 0x3299371 VA: 0x3299270
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x329A320 Offset: 0x329A421 VA: 0x329A320
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x329B3C0 Offset: 0x329B4C1 VA: 0x329B3C0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x329C460 Offset: 0x329C561 VA: 0x329C460
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x329D500 Offset: 0x329D601 VA: 0x329D500
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x329E5C0 Offset: 0x329E6C1 VA: 0x329E5C0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x329F790 Offset: 0x329F891 VA: 0x329F790
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A09D0 Offset: 0x32A0AD1 VA: 0x32A09D0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A1B10 Offset: 0x32A1C11 VA: 0x32A1B10
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A2BC0 Offset: 0x32A2CC1 VA: 0x32A2BC0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A3D60 Offset: 0x32A3E61 VA: 0x32A3D60
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A4E40 Offset: 0x32A4F41 VA: 0x32A4E40
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A5F90 Offset: 0x32A6091 VA: 0x32A5F90
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x32A7140 Offset: 0x32A7241 VA: 0x32A7140
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x31780B0 Offset: 0x31781B1 VA: 0x31780B0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3179350 Offset: 0x3179451 VA: 0x3179350
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x317A510 Offset: 0x317A611 VA: 0x317A510
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x317B590 Offset: 0x317B691 VA: 0x317B590
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x317C640 Offset: 0x317C741 VA: 0x317C640
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x317D780 Offset: 0x317D881 VA: 0x317D780
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x317E8F0 Offset: 0x317E9F1 VA: 0x317E8F0
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x317FA60 Offset: 0x317FB61 VA: 0x317FA60
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3180B50 Offset: 0x3180C51 VA: 0x3180B50
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3181C20 Offset: 0x3181D21 VA: 0x3181C20
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3182ED0 Offset: 0x3182FD1 VA: 0x3182ED0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x31841F0 Offset: 0x31842F1 VA: 0x31841F0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3185350 Offset: 0x3185451 VA: 0x3185350
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x31864A0 Offset: 0x31865A1 VA: 0x31864A0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3187650 Offset: 0x3187751 VA: 0x3187650
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3188770 Offset: 0x3188871 VA: 0x3188770
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3189940 Offset: 0x3189A41 VA: 0x3189940
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x318AB10 Offset: 0x318AC11 VA: 0x318AB10
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x318BC10 Offset: 0x318BD11 VA: 0x318BC10
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x318CD50 Offset: 0x318CE51 VA: 0x318CD50
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x318DE20 Offset: 0x318DF21 VA: 0x318DE20
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x318EEA0 Offset: 0x318EFA1 VA: 0x318EEA0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x318FF70 Offset: 0x3190071 VA: 0x318FF70
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3191000 Offset: 0x3191101 VA: 0x3191000
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x31921B0 Offset: 0x31922B1 VA: 0x31921B0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x31933D0 Offset: 0x31934D1 VA: 0x31933D0
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3194510 Offset: 0x3194611 VA: 0x3194510
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x31955C0 Offset: 0x31956C1 VA: 0x31955C0
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3196660 Offset: 0x3196761 VA: 0x3196660
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3197920 Offset: 0x3197A21 VA: 0x3197920
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3198B00 Offset: 0x3198C01 VA: 0x3198B00
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3199C40 Offset: 0x3199D41 VA: 0x3199C40
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x319ADB0 Offset: 0x319AEB1 VA: 0x319ADB0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x319BF60 Offset: 0x319C061 VA: 0x319BF60
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E83040 Offset: 0x2E83141 VA: 0x2E83040
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E841F0 Offset: 0x2E842F1 VA: 0x2E841F0
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E852F0 Offset: 0x2E853F1 VA: 0x2E852F0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E86470 Offset: 0x2E86571 VA: 0x2E86470
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E87610 Offset: 0x2E87711 VA: 0x2E87610
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E88780 Offset: 0x2E88881 VA: 0x2E88780
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E898F0 Offset: 0x2E899F1 VA: 0x2E898F0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E8A9E0 Offset: 0x2E8AAE1 VA: 0x2E8A9E0
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E8BA90 Offset: 0x2E8BB91 VA: 0x2E8BA90
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E8CB30 Offset: 0x2E8CC31 VA: 0x2E8CB30
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E8DD70 Offset: 0x2E8DE71 VA: 0x2E8DD70
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E8EF90 Offset: 0x2E8F091 VA: 0x2E8EF90
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E90060 Offset: 0x2E90161 VA: 0x2E90060
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E910F0 Offset: 0x2E911F1 VA: 0x2E910F0
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E921C0 Offset: 0x2E922C1 VA: 0x2E921C0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E93290 Offset: 0x2E93391 VA: 0x2E93290
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E94360 Offset: 0x2E94461 VA: 0x2E94360
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E95630 Offset: 0x2E95731 VA: 0x2E95630
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E967F0 Offset: 0x2E968F1 VA: 0x2E967F0
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2E97940 Offset: 0x2E97A41 VA: 0x2E97940
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE90A0 Offset: 0x2EE91A1 VA: 0x2EE90A0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EEA390 Offset: 0x2EEA491 VA: 0x2EEA390
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EEB570 Offset: 0x2EEB671 VA: 0x2EEB570
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EEC610 Offset: 0x2EEC711 VA: 0x2EEC610
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EED6D0 Offset: 0x2EED7D1 VA: 0x2EED6D0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EEE780 Offset: 0x2EEE881 VA: 0x2EEE780
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EEF800 Offset: 0x2EEF901 VA: 0x2EEF800
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF0890 Offset: 0x2EF0991 VA: 0x2EF0890
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF1A20 Offset: 0x2EF1B21 VA: 0x2EF1A20
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF2C20 Offset: 0x2EF2D21 VA: 0x2EF2C20
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF3DF0 Offset: 0x2EF3EF1 VA: 0x2EF3DF0
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF4EE0 Offset: 0x2EF4FE1 VA: 0x2EF4EE0
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF6030 Offset: 0x2EF6131 VA: 0x2EF6030
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF71A0 Offset: 0x2EF72A1 VA: 0x2EF71A0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF8270 Offset: 0x2EF8371 VA: 0x2EF8270
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EF9310 Offset: 0x2EF9411 VA: 0x2EF9310
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EFA4B0 Offset: 0x2EFA5B1 VA: 0x2EFA4B0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EFB690 Offset: 0x2EFB791 VA: 0x2EFB690
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2EFC790 Offset: 0x2EFC891 VA: 0x2EFC790
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32E6780 Offset: 0x32E6881 VA: 0x32E6780
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32E7940 Offset: 0x32E7A41 VA: 0x32E7940
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32E8A30 Offset: 0x32E8B31 VA: 0x32E8A30
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32E9B80 Offset: 0x32E9C81 VA: 0x32E9B80
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32EAC50 Offset: 0x32EAD51 VA: 0x32EAC50
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32EBCF0 Offset: 0x32EBDF1 VA: 0x32EBCF0
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32ECE70 Offset: 0x32ECF71 VA: 0x32ECE70
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32EDF90 Offset: 0x32EE091 VA: 0x32EDF90
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32EF020 Offset: 0x32EF121 VA: 0x32EF020
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F00F0 Offset: 0x32F01F1 VA: 0x32F00F0
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F1240 Offset: 0x32F1341 VA: 0x32F1240
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F23B0 Offset: 0x32F24B1 VA: 0x32F23B0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F35E0 Offset: 0x32F36E1 VA: 0x32F35E0
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F4720 Offset: 0x32F4821 VA: 0x32F4720
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F57C0 Offset: 0x32F58C1 VA: 0x32F57C0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F6850 Offset: 0x32F6951 VA: 0x32F6850
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F7900 Offset: 0x32F7A01 VA: 0x32F7900
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F89A0 Offset: 0x32F8AA1 VA: 0x32F89A0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32F9A40 Offset: 0x32F9B41 VA: 0x32F9A40
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32FAAC0 Offset: 0x32FABC1 VA: 0x32FAAC0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32FBB50 Offset: 0x32FBC51 VA: 0x32FBB50
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32FCBE0 Offset: 0x32FCCE1 VA: 0x32FCBE0
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32FDC70 Offset: 0x32FDD71 VA: 0x32FDC70
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32FED00 Offset: 0x32FEE01 VA: 0x32FED00
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32FFD90 Offset: 0x32FFE91 VA: 0x32FFD90
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3300E40 Offset: 0x3300F41 VA: 0x3300E40
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3301EC0 Offset: 0x3301FC1 VA: 0x3301EC0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3303050 Offset: 0x3303151 VA: 0x3303050
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3304250 Offset: 0x3304351 VA: 0x3304250
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3305350 Offset: 0x3305451 VA: 0x3305350
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x33064A0 Offset: 0x33065A1 VA: 0x33064A0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x33075D0 Offset: 0x33076D1 VA: 0x33075D0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3308730 Offset: 0x3308831 VA: 0x3308730
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x33098E0 Offset: 0x33099E1 VA: 0x33098E0
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3283F80 Offset: 0x3284081 VA: 0x3283F80
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32851B0 Offset: 0x32852B1 VA: 0x32851B0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32863D0 Offset: 0x32864D1 VA: 0x32863D0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3287500 Offset: 0x3287601 VA: 0x3287500
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3288660 Offset: 0x3288761 VA: 0x3288660
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3289810 Offset: 0x3289911 VA: 0x3289810
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x328A940 Offset: 0x328AA41 VA: 0x328A940
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x328BA20 Offset: 0x328BB21 VA: 0x328BA20
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x328CAE0 Offset: 0x328CBE1 VA: 0x328CAE0
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x328DB80 Offset: 0x328DC81 VA: 0x328DB80
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x328ECC0 Offset: 0x328EDC1 VA: 0x328ECC0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x328FDB0 Offset: 0x328FEB1 VA: 0x328FDB0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3290DD0 Offset: 0x3290ED1 VA: 0x3290DD0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3291EA0 Offset: 0x3291FA1 VA: 0x3291EA0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3292F20 Offset: 0x3293021 VA: 0x3292F20
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3293FB0 Offset: 0x32940B1 VA: 0x3293FB0
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3295040 Offset: 0x3295141 VA: 0x3295040
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32960D0 Offset: 0x32961D1 VA: 0x32960D0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3297160 Offset: 0x3297261 VA: 0x3297160
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32981F0 Offset: 0x32982F1 VA: 0x32981F0
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3299280 Offset: 0x3299381 VA: 0x3299280
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x329A330 Offset: 0x329A431 VA: 0x329A330
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x329B3D0 Offset: 0x329B4D1 VA: 0x329B3D0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x329C470 Offset: 0x329C571 VA: 0x329C470
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x329D510 Offset: 0x329D611 VA: 0x329D510
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x329E5D0 Offset: 0x329E6D1 VA: 0x329E5D0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x329F7A0 Offset: 0x329F8A1 VA: 0x329F7A0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A09E0 Offset: 0x32A0AE1 VA: 0x32A09E0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A1B20 Offset: 0x32A1C21 VA: 0x32A1B20
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A2BD0 Offset: 0x32A2CD1 VA: 0x32A2BD0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A3D70 Offset: 0x32A3E71 VA: 0x32A3D70
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A4E50 Offset: 0x32A4F51 VA: 0x32A4E50
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A5FA0 Offset: 0x32A60A1 VA: 0x32A5FA0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x32A7150 Offset: 0x32A7251 VA: 0x32A7150
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x31780C0 Offset: 0x31781C1 VA: 0x31780C0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3179360 Offset: 0x3179461 VA: 0x3179360
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x317A520 Offset: 0x317A621 VA: 0x317A520
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x317B5A0 Offset: 0x317B6A1 VA: 0x317B5A0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x317C650 Offset: 0x317C751 VA: 0x317C650
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x317D790 Offset: 0x317D891 VA: 0x317D790
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x317E900 Offset: 0x317EA01 VA: 0x317E900
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x317FA70 Offset: 0x317FB71 VA: 0x317FA70
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3180B60 Offset: 0x3180C61 VA: 0x3180B60
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3181C30 Offset: 0x3181D31 VA: 0x3181C30
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3182EE0 Offset: 0x3182FE1 VA: 0x3182EE0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3184200 Offset: 0x3184301 VA: 0x3184200
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3185360 Offset: 0x3185461 VA: 0x3185360
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x31864B0 Offset: 0x31865B1 VA: 0x31864B0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3187660 Offset: 0x3187761 VA: 0x3187660
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3188780 Offset: 0x3188881 VA: 0x3188780
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3189950 Offset: 0x3189A51 VA: 0x3189950
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x318AB20 Offset: 0x318AC21 VA: 0x318AB20
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x318BC20 Offset: 0x318BD21 VA: 0x318BC20
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x318CD60 Offset: 0x318CE61 VA: 0x318CD60
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x318DE30 Offset: 0x318DF31 VA: 0x318DE30
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x318EEB0 Offset: 0x318EFB1 VA: 0x318EEB0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x318FF80 Offset: 0x3190081 VA: 0x318FF80
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3191010 Offset: 0x3191111 VA: 0x3191010
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x31921C0 Offset: 0x31922C1 VA: 0x31921C0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x31933E0 Offset: 0x31934E1 VA: 0x31933E0
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3194520 Offset: 0x3194621 VA: 0x3194520
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x31955D0 Offset: 0x31956D1 VA: 0x31955D0
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3196670 Offset: 0x3196771 VA: 0x3196670
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3197930 Offset: 0x3197A31 VA: 0x3197930
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3198B10 Offset: 0x3198C11 VA: 0x3198B10
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3199C50 Offset: 0x3199D51 VA: 0x3199C50
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x319ADC0 Offset: 0x319AEC1 VA: 0x319ADC0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x319BF70 Offset: 0x319C071 VA: 0x319BF70
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E83050 Offset: 0x2E83151 VA: 0x2E83050
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E84200 Offset: 0x2E84301 VA: 0x2E84200
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E85300 Offset: 0x2E85401 VA: 0x2E85300
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E86480 Offset: 0x2E86581 VA: 0x2E86480
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E87620 Offset: 0x2E87721 VA: 0x2E87620
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E88790 Offset: 0x2E88891 VA: 0x2E88790
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E89900 Offset: 0x2E89A01 VA: 0x2E89900
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E8A9F0 Offset: 0x2E8AAF1 VA: 0x2E8A9F0
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E8BAA0 Offset: 0x2E8BBA1 VA: 0x2E8BAA0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E8CB40 Offset: 0x2E8CC41 VA: 0x2E8CB40
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E8DD80 Offset: 0x2E8DE81 VA: 0x2E8DD80
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E8EFA0 Offset: 0x2E8F0A1 VA: 0x2E8EFA0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E90070 Offset: 0x2E90171 VA: 0x2E90070
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E91100 Offset: 0x2E91201 VA: 0x2E91100
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E921D0 Offset: 0x2E922D1 VA: 0x2E921D0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E932A0 Offset: 0x2E933A1 VA: 0x2E932A0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E94370 Offset: 0x2E94471 VA: 0x2E94370
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E95640 Offset: 0x2E95741 VA: 0x2E95640
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E96800 Offset: 0x2E96901 VA: 0x2E96800
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2E97950 Offset: 0x2E97A51 VA: 0x2E97950
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE90B0 Offset: 0x2EE91B1 VA: 0x2EE90B0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EEA3A0 Offset: 0x2EEA4A1 VA: 0x2EEA3A0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EEB580 Offset: 0x2EEB681 VA: 0x2EEB580
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EEC620 Offset: 0x2EEC721 VA: 0x2EEC620
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EED6E0 Offset: 0x2EED7E1 VA: 0x2EED6E0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EEE790 Offset: 0x2EEE891 VA: 0x2EEE790
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EEF810 Offset: 0x2EEF911 VA: 0x2EEF810
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF08A0 Offset: 0x2EF09A1 VA: 0x2EF08A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF1A30 Offset: 0x2EF1B31 VA: 0x2EF1A30
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF2C30 Offset: 0x2EF2D31 VA: 0x2EF2C30
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF3E00 Offset: 0x2EF3F01 VA: 0x2EF3E00
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF4EF0 Offset: 0x2EF4FF1 VA: 0x2EF4EF0
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF6040 Offset: 0x2EF6141 VA: 0x2EF6040
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF71B0 Offset: 0x2EF72B1 VA: 0x2EF71B0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF8280 Offset: 0x2EF8381 VA: 0x2EF8280
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EF9320 Offset: 0x2EF9421 VA: 0x2EF9320
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EFA4C0 Offset: 0x2EFA5C1 VA: 0x2EFA4C0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EFB6A0 Offset: 0x2EFB7A1 VA: 0x2EFB6A0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2EFC7A0 Offset: 0x2EFC8A1 VA: 0x2EFC7A0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32E6790 Offset: 0x32E6891 VA: 0x32E6790
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32E7950 Offset: 0x32E7A51 VA: 0x32E7950
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32E8A40 Offset: 0x32E8B41 VA: 0x32E8A40
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32E9B90 Offset: 0x32E9C91 VA: 0x32E9B90
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32EAC60 Offset: 0x32EAD61 VA: 0x32EAC60
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32EBD00 Offset: 0x32EBE01 VA: 0x32EBD00
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32ECE80 Offset: 0x32ECF81 VA: 0x32ECE80
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32EDFA0 Offset: 0x32EE0A1 VA: 0x32EDFA0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32EF030 Offset: 0x32EF131 VA: 0x32EF030
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F0100 Offset: 0x32F0201 VA: 0x32F0100
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F1250 Offset: 0x32F1351 VA: 0x32F1250
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F23C0 Offset: 0x32F24C1 VA: 0x32F23C0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F35F0 Offset: 0x32F36F1 VA: 0x32F35F0
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F4730 Offset: 0x32F4831 VA: 0x32F4730
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F57D0 Offset: 0x32F58D1 VA: 0x32F57D0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F6860 Offset: 0x32F6961 VA: 0x32F6860
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F7910 Offset: 0x32F7A11 VA: 0x32F7910
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F89B0 Offset: 0x32F8AB1 VA: 0x32F89B0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32F9A50 Offset: 0x32F9B51 VA: 0x32F9A50
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32FAAD0 Offset: 0x32FABD1 VA: 0x32FAAD0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32FBB60 Offset: 0x32FBC61 VA: 0x32FBB60
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32FCBF0 Offset: 0x32FCCF1 VA: 0x32FCBF0
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32FDC80 Offset: 0x32FDD81 VA: 0x32FDC80
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32FED10 Offset: 0x32FEE11 VA: 0x32FED10
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32FFDA0 Offset: 0x32FFEA1 VA: 0x32FFDA0
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3300E50 Offset: 0x3300F51 VA: 0x3300E50
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3301ED0 Offset: 0x3301FD1 VA: 0x3301ED0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3303060 Offset: 0x3303161 VA: 0x3303060
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3304260 Offset: 0x3304361 VA: 0x3304260
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3305360 Offset: 0x3305461 VA: 0x3305360
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x33064B0 Offset: 0x33065B1 VA: 0x33064B0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x33075E0 Offset: 0x33076E1 VA: 0x33075E0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3308740 Offset: 0x3308841 VA: 0x3308740
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x33098F0 Offset: 0x33099F1 VA: 0x33098F0
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3283F90 Offset: 0x3284091 VA: 0x3283F90
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32851C0 Offset: 0x32852C1 VA: 0x32851C0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32863E0 Offset: 0x32864E1 VA: 0x32863E0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3287510 Offset: 0x3287611 VA: 0x3287510
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3288670 Offset: 0x3288771 VA: 0x3288670
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3289820 Offset: 0x3289921 VA: 0x3289820
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x328A950 Offset: 0x328AA51 VA: 0x328A950
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x328BA30 Offset: 0x328BB31 VA: 0x328BA30
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x328CAF0 Offset: 0x328CBF1 VA: 0x328CAF0
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x328DB90 Offset: 0x328DC91 VA: 0x328DB90
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x328ECD0 Offset: 0x328EDD1 VA: 0x328ECD0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x328FDC0 Offset: 0x328FEC1 VA: 0x328FDC0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3290DE0 Offset: 0x3290EE1 VA: 0x3290DE0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3291EB0 Offset: 0x3291FB1 VA: 0x3291EB0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3292F30 Offset: 0x3293031 VA: 0x3292F30
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3293FC0 Offset: 0x32940C1 VA: 0x3293FC0
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3295050 Offset: 0x3295151 VA: 0x3295050
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32960E0 Offset: 0x32961E1 VA: 0x32960E0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3297170 Offset: 0x3297271 VA: 0x3297170
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3298200 Offset: 0x3298301 VA: 0x3298200
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3299290 Offset: 0x3299391 VA: 0x3299290
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x329A340 Offset: 0x329A441 VA: 0x329A340
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x329B3E0 Offset: 0x329B4E1 VA: 0x329B3E0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x329C480 Offset: 0x329C581 VA: 0x329C480
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x329D520 Offset: 0x329D621 VA: 0x329D520
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x329E5E0 Offset: 0x329E6E1 VA: 0x329E5E0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x329F7B0 Offset: 0x329F8B1 VA: 0x329F7B0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A09F0 Offset: 0x32A0AF1 VA: 0x32A09F0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A1B30 Offset: 0x32A1C31 VA: 0x32A1B30
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A2BE0 Offset: 0x32A2CE1 VA: 0x32A2BE0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A3D80 Offset: 0x32A3E81 VA: 0x32A3D80
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A4E60 Offset: 0x32A4F61 VA: 0x32A4E60
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A5FB0 Offset: 0x32A60B1 VA: 0x32A5FB0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x32A7160 Offset: 0x32A7261 VA: 0x32A7160
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x31780D0 Offset: 0x31781D1 VA: 0x31780D0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3179370 Offset: 0x3179471 VA: 0x3179370
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x317A530 Offset: 0x317A631 VA: 0x317A530
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x317B5B0 Offset: 0x317B6B1 VA: 0x317B5B0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x317C660 Offset: 0x317C761 VA: 0x317C660
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x317D7A0 Offset: 0x317D8A1 VA: 0x317D7A0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x317E910 Offset: 0x317EA11 VA: 0x317E910
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x317FA80 Offset: 0x317FB81 VA: 0x317FA80
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3180B70 Offset: 0x3180C71 VA: 0x3180B70
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3181C40 Offset: 0x3181D41 VA: 0x3181C40
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3182EF0 Offset: 0x3182FF1 VA: 0x3182EF0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3184210 Offset: 0x3184311 VA: 0x3184210
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3185370 Offset: 0x3185471 VA: 0x3185370
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x31864C0 Offset: 0x31865C1 VA: 0x31864C0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3187670 Offset: 0x3187771 VA: 0x3187670
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3188790 Offset: 0x3188891 VA: 0x3188790
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3189960 Offset: 0x3189A61 VA: 0x3189960
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x318AB30 Offset: 0x318AC31 VA: 0x318AB30
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x318BC30 Offset: 0x318BD31 VA: 0x318BC30
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x318CD70 Offset: 0x318CE71 VA: 0x318CD70
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x318DE40 Offset: 0x318DF41 VA: 0x318DE40
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x318EEC0 Offset: 0x318EFC1 VA: 0x318EEC0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x318FF90 Offset: 0x3190091 VA: 0x318FF90
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3191020 Offset: 0x3191121 VA: 0x3191020
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x31921D0 Offset: 0x31922D1 VA: 0x31921D0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x31933F0 Offset: 0x31934F1 VA: 0x31933F0
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3194530 Offset: 0x3194631 VA: 0x3194530
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x31955E0 Offset: 0x31956E1 VA: 0x31955E0
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3196680 Offset: 0x3196781 VA: 0x3196680
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3197940 Offset: 0x3197A41 VA: 0x3197940
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3198B20 Offset: 0x3198C21 VA: 0x3198B20
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3199C60 Offset: 0x3199D61 VA: 0x3199C60
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x319ADD0 Offset: 0x319AED1 VA: 0x319ADD0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x319BF80 Offset: 0x319C081 VA: 0x319BF80
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E83060 Offset: 0x2E83161 VA: 0x2E83060
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E84210 Offset: 0x2E84311 VA: 0x2E84210
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E85310 Offset: 0x2E85411 VA: 0x2E85310
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E86490 Offset: 0x2E86591 VA: 0x2E86490
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E87630 Offset: 0x2E87731 VA: 0x2E87630
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E887A0 Offset: 0x2E888A1 VA: 0x2E887A0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E89910 Offset: 0x2E89A11 VA: 0x2E89910
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E8AA00 Offset: 0x2E8AB01 VA: 0x2E8AA00
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E8BAB0 Offset: 0x2E8BBB1 VA: 0x2E8BAB0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E8CB50 Offset: 0x2E8CC51 VA: 0x2E8CB50
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E8DD90 Offset: 0x2E8DE91 VA: 0x2E8DD90
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E8EFB0 Offset: 0x2E8F0B1 VA: 0x2E8EFB0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E90080 Offset: 0x2E90181 VA: 0x2E90080
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E91110 Offset: 0x2E91211 VA: 0x2E91110
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E921E0 Offset: 0x2E922E1 VA: 0x2E921E0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E932B0 Offset: 0x2E933B1 VA: 0x2E932B0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E94380 Offset: 0x2E94481 VA: 0x2E94380
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E95650 Offset: 0x2E95751 VA: 0x2E95650
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E96810 Offset: 0x2E96911 VA: 0x2E96810
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2E97960 Offset: 0x2E97A61 VA: 0x2E97960
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE90C0 Offset: 0x2EE91C1 VA: 0x2EE90C0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EEA3B0 Offset: 0x2EEA4B1 VA: 0x2EEA3B0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EEB590 Offset: 0x2EEB691 VA: 0x2EEB590
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EEC630 Offset: 0x2EEC731 VA: 0x2EEC630
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EED6F0 Offset: 0x2EED7F1 VA: 0x2EED6F0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EEE7A0 Offset: 0x2EEE8A1 VA: 0x2EEE7A0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EEF820 Offset: 0x2EEF921 VA: 0x2EEF820
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF08B0 Offset: 0x2EF09B1 VA: 0x2EF08B0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF1A40 Offset: 0x2EF1B41 VA: 0x2EF1A40
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF2C40 Offset: 0x2EF2D41 VA: 0x2EF2C40
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF3E10 Offset: 0x2EF3F11 VA: 0x2EF3E10
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF4F00 Offset: 0x2EF5001 VA: 0x2EF4F00
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF6050 Offset: 0x2EF6151 VA: 0x2EF6050
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF71C0 Offset: 0x2EF72C1 VA: 0x2EF71C0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF8290 Offset: 0x2EF8391 VA: 0x2EF8290
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EF9330 Offset: 0x2EF9431 VA: 0x2EF9330
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EFA4D0 Offset: 0x2EFA5D1 VA: 0x2EFA4D0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EFB6B0 Offset: 0x2EFB7B1 VA: 0x2EFB6B0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2EFC7B0 Offset: 0x2EFC8B1 VA: 0x2EFC7B0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32E67A0 Offset: 0x32E68A1 VA: 0x32E67A0
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32E7960 Offset: 0x32E7A61 VA: 0x32E7960
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32E8A50 Offset: 0x32E8B51 VA: 0x32E8A50
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32E9BA0 Offset: 0x32E9CA1 VA: 0x32E9BA0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32EAC70 Offset: 0x32EAD71 VA: 0x32EAC70
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32EBD10 Offset: 0x32EBE11 VA: 0x32EBD10
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32ECE90 Offset: 0x32ECF91 VA: 0x32ECE90
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32EDFB0 Offset: 0x32EE0B1 VA: 0x32EDFB0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32EF040 Offset: 0x32EF141 VA: 0x32EF040
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F0110 Offset: 0x32F0211 VA: 0x32F0110
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F1260 Offset: 0x32F1361 VA: 0x32F1260
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F23D0 Offset: 0x32F24D1 VA: 0x32F23D0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F3600 Offset: 0x32F3701 VA: 0x32F3600
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F4740 Offset: 0x32F4841 VA: 0x32F4740
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F57E0 Offset: 0x32F58E1 VA: 0x32F57E0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F6870 Offset: 0x32F6971 VA: 0x32F6870
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F7920 Offset: 0x32F7A21 VA: 0x32F7920
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F89C0 Offset: 0x32F8AC1 VA: 0x32F89C0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32F9A60 Offset: 0x32F9B61 VA: 0x32F9A60
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32FAAE0 Offset: 0x32FABE1 VA: 0x32FAAE0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32FBB70 Offset: 0x32FBC71 VA: 0x32FBB70
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32FCC00 Offset: 0x32FCD01 VA: 0x32FCC00
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32FDC90 Offset: 0x32FDD91 VA: 0x32FDC90
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32FED20 Offset: 0x32FEE21 VA: 0x32FED20
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32FFDB0 Offset: 0x32FFEB1 VA: 0x32FFDB0
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3300E60 Offset: 0x3300F61 VA: 0x3300E60
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3301EE0 Offset: 0x3301FE1 VA: 0x3301EE0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3303070 Offset: 0x3303171 VA: 0x3303070
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3304270 Offset: 0x3304371 VA: 0x3304270
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3305370 Offset: 0x3305471 VA: 0x3305370
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x33064C0 Offset: 0x33065C1 VA: 0x33064C0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x33075F0 Offset: 0x33076F1 VA: 0x33075F0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3308750 Offset: 0x3308851 VA: 0x3308750
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3309900 Offset: 0x3309A01 VA: 0x3309900
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3283FA0 Offset: 0x32840A1 VA: 0x3283FA0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32851D0 Offset: 0x32852D1 VA: 0x32851D0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32863F0 Offset: 0x32864F1 VA: 0x32863F0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3287520 Offset: 0x3287621 VA: 0x3287520
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3288680 Offset: 0x3288781 VA: 0x3288680
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3289830 Offset: 0x3289931 VA: 0x3289830
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x328A960 Offset: 0x328AA61 VA: 0x328A960
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x328BA40 Offset: 0x328BB41 VA: 0x328BA40
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x328CB00 Offset: 0x328CC01 VA: 0x328CB00
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x328DBA0 Offset: 0x328DCA1 VA: 0x328DBA0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x328ECE0 Offset: 0x328EDE1 VA: 0x328ECE0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x328FDD0 Offset: 0x328FED1 VA: 0x328FDD0
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3290DF0 Offset: 0x3290EF1 VA: 0x3290DF0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3291EC0 Offset: 0x3291FC1 VA: 0x3291EC0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3292F40 Offset: 0x3293041 VA: 0x3292F40
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3293FD0 Offset: 0x32940D1 VA: 0x3293FD0
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3295060 Offset: 0x3295161 VA: 0x3295060
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32960F0 Offset: 0x32961F1 VA: 0x32960F0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3297180 Offset: 0x3297281 VA: 0x3297180
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3298210 Offset: 0x3298311 VA: 0x3298210
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32992A0 Offset: 0x32993A1 VA: 0x32992A0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x329A350 Offset: 0x329A451 VA: 0x329A350
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x329B3F0 Offset: 0x329B4F1 VA: 0x329B3F0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x329C490 Offset: 0x329C591 VA: 0x329C490
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x329D530 Offset: 0x329D631 VA: 0x329D530
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x329E5F0 Offset: 0x329E6F1 VA: 0x329E5F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x329F7C0 Offset: 0x329F8C1 VA: 0x329F7C0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A0A00 Offset: 0x32A0B01 VA: 0x32A0A00
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A1B40 Offset: 0x32A1C41 VA: 0x32A1B40
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A2BF0 Offset: 0x32A2CF1 VA: 0x32A2BF0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A3D90 Offset: 0x32A3E91 VA: 0x32A3D90
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A4E70 Offset: 0x32A4F71 VA: 0x32A4E70
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A5FC0 Offset: 0x32A60C1 VA: 0x32A5FC0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x32A7170 Offset: 0x32A7271 VA: 0x32A7170
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x31780E0 Offset: 0x31781E1 VA: 0x31780E0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3179380 Offset: 0x3179481 VA: 0x3179380
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x317A540 Offset: 0x317A641 VA: 0x317A540
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x317B5C0 Offset: 0x317B6C1 VA: 0x317B5C0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x317C670 Offset: 0x317C771 VA: 0x317C670
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x317D7B0 Offset: 0x317D8B1 VA: 0x317D7B0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x317E920 Offset: 0x317EA21 VA: 0x317E920
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x317FA90 Offset: 0x317FB91 VA: 0x317FA90
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3180B80 Offset: 0x3180C81 VA: 0x3180B80
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3181C50 Offset: 0x3181D51 VA: 0x3181C50
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3182F00 Offset: 0x3183001 VA: 0x3182F00
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3184220 Offset: 0x3184321 VA: 0x3184220
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3185380 Offset: 0x3185481 VA: 0x3185380
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x31864D0 Offset: 0x31865D1 VA: 0x31864D0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3187680 Offset: 0x3187781 VA: 0x3187680
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x31887A0 Offset: 0x31888A1 VA: 0x31887A0
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3189970 Offset: 0x3189A71 VA: 0x3189970
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x318AB40 Offset: 0x318AC41 VA: 0x318AB40
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x318BC40 Offset: 0x318BD41 VA: 0x318BC40
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x318CD80 Offset: 0x318CE81 VA: 0x318CD80
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x318DE50 Offset: 0x318DF51 VA: 0x318DE50
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x318EED0 Offset: 0x318EFD1 VA: 0x318EED0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x318FFA0 Offset: 0x31900A1 VA: 0x318FFA0
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3191030 Offset: 0x3191131 VA: 0x3191030
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x31921E0 Offset: 0x31922E1 VA: 0x31921E0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3193400 Offset: 0x3193501 VA: 0x3193400
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3194540 Offset: 0x3194641 VA: 0x3194540
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x31955F0 Offset: 0x31956F1 VA: 0x31955F0
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3196690 Offset: 0x3196791 VA: 0x3196690
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3197950 Offset: 0x3197A51 VA: 0x3197950
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3198B30 Offset: 0x3198C31 VA: 0x3198B30
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3199C70 Offset: 0x3199D71 VA: 0x3199C70
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x319ADE0 Offset: 0x319AEE1 VA: 0x319ADE0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x319BF90 Offset: 0x319C091 VA: 0x319BF90
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E83070 Offset: 0x2E83171 VA: 0x2E83070
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E84220 Offset: 0x2E84321 VA: 0x2E84220
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E85320 Offset: 0x2E85421 VA: 0x2E85320
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E864A0 Offset: 0x2E865A1 VA: 0x2E864A0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E87640 Offset: 0x2E87741 VA: 0x2E87640
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E887B0 Offset: 0x2E888B1 VA: 0x2E887B0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E89920 Offset: 0x2E89A21 VA: 0x2E89920
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E8AA10 Offset: 0x2E8AB11 VA: 0x2E8AA10
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E8BAC0 Offset: 0x2E8BBC1 VA: 0x2E8BAC0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E8CB60 Offset: 0x2E8CC61 VA: 0x2E8CB60
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E8DDA0 Offset: 0x2E8DEA1 VA: 0x2E8DDA0
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E8EFC0 Offset: 0x2E8F0C1 VA: 0x2E8EFC0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E90090 Offset: 0x2E90191 VA: 0x2E90090
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E91120 Offset: 0x2E91221 VA: 0x2E91120
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E921F0 Offset: 0x2E922F1 VA: 0x2E921F0
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E932C0 Offset: 0x2E933C1 VA: 0x2E932C0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E94390 Offset: 0x2E94491 VA: 0x2E94390
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E95660 Offset: 0x2E95761 VA: 0x2E95660
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E96820 Offset: 0x2E96921 VA: 0x2E96820
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2E97970 Offset: 0x2E97A71 VA: 0x2E97970
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE90D0 Offset: 0x2EE91D1 VA: 0x2EE90D0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EEA3C0 Offset: 0x2EEA4C1 VA: 0x2EEA3C0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EEB5A0 Offset: 0x2EEB6A1 VA: 0x2EEB5A0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EEC640 Offset: 0x2EEC741 VA: 0x2EEC640
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EED700 Offset: 0x2EED801 VA: 0x2EED700
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EEE7B0 Offset: 0x2EEE8B1 VA: 0x2EEE7B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EEF830 Offset: 0x2EEF931 VA: 0x2EEF830
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF08C0 Offset: 0x2EF09C1 VA: 0x2EF08C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF1A50 Offset: 0x2EF1B51 VA: 0x2EF1A50
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF2C50 Offset: 0x2EF2D51 VA: 0x2EF2C50
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF3E20 Offset: 0x2EF3F21 VA: 0x2EF3E20
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF4F10 Offset: 0x2EF5011 VA: 0x2EF4F10
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF6060 Offset: 0x2EF6161 VA: 0x2EF6060
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF71D0 Offset: 0x2EF72D1 VA: 0x2EF71D0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF82A0 Offset: 0x2EF83A1 VA: 0x2EF82A0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EF9340 Offset: 0x2EF9441 VA: 0x2EF9340
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EFA4E0 Offset: 0x2EFA5E1 VA: 0x2EFA4E0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EFB6C0 Offset: 0x2EFB7C1 VA: 0x2EFB6C0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2EFC7C0 Offset: 0x2EFC8C1 VA: 0x2EFC7C0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32E67B0 Offset: 0x32E68B1 VA: 0x32E67B0
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32E7970 Offset: 0x32E7A71 VA: 0x32E7970
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32E8A60 Offset: 0x32E8B61 VA: 0x32E8A60
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32E9BB0 Offset: 0x32E9CB1 VA: 0x32E9BB0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32EAC80 Offset: 0x32EAD81 VA: 0x32EAC80
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32EBD20 Offset: 0x32EBE21 VA: 0x32EBD20
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32ECEA0 Offset: 0x32ECFA1 VA: 0x32ECEA0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32EDFC0 Offset: 0x32EE0C1 VA: 0x32EDFC0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32EF050 Offset: 0x32EF151 VA: 0x32EF050
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F0120 Offset: 0x32F0221 VA: 0x32F0120
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F1270 Offset: 0x32F1371 VA: 0x32F1270
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F23E0 Offset: 0x32F24E1 VA: 0x32F23E0
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F3610 Offset: 0x32F3711 VA: 0x32F3610
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F4750 Offset: 0x32F4851 VA: 0x32F4750
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F57F0 Offset: 0x32F58F1 VA: 0x32F57F0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F6880 Offset: 0x32F6981 VA: 0x32F6880
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F7930 Offset: 0x32F7A31 VA: 0x32F7930
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F89D0 Offset: 0x32F8AD1 VA: 0x32F89D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32F9A70 Offset: 0x32F9B71 VA: 0x32F9A70
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32FAAF0 Offset: 0x32FABF1 VA: 0x32FAAF0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32FBB80 Offset: 0x32FBC81 VA: 0x32FBB80
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32FCC10 Offset: 0x32FCD11 VA: 0x32FCC10
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32FDCA0 Offset: 0x32FDDA1 VA: 0x32FDCA0
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32FED30 Offset: 0x32FEE31 VA: 0x32FED30
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32FFDC0 Offset: 0x32FFEC1 VA: 0x32FFDC0
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3300E70 Offset: 0x3300F71 VA: 0x3300E70
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3301EF0 Offset: 0x3301FF1 VA: 0x3301EF0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3303080 Offset: 0x3303181 VA: 0x3303080
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3304280 Offset: 0x3304381 VA: 0x3304280
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3305380 Offset: 0x3305481 VA: 0x3305380
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x33064D0 Offset: 0x33065D1 VA: 0x33064D0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3307600 Offset: 0x3307701 VA: 0x3307600
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3308760 Offset: 0x3308861 VA: 0x3308760
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3309910 Offset: 0x3309A11 VA: 0x3309910
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3283FB0 Offset: 0x32840B1 VA: 0x3283FB0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32851E0 Offset: 0x32852E1 VA: 0x32851E0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3286400 Offset: 0x3286501 VA: 0x3286400
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3287530 Offset: 0x3287631 VA: 0x3287530
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3288690 Offset: 0x3288791 VA: 0x3288690
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3289840 Offset: 0x3289941 VA: 0x3289840
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x328A970 Offset: 0x328AA71 VA: 0x328A970
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x328BA50 Offset: 0x328BB51 VA: 0x328BA50
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x328CB10 Offset: 0x328CC11 VA: 0x328CB10
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x328DBB0 Offset: 0x328DCB1 VA: 0x328DBB0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x328ECF0 Offset: 0x328EDF1 VA: 0x328ECF0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x328FDE0 Offset: 0x328FEE1 VA: 0x328FDE0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3290E00 Offset: 0x3290F01 VA: 0x3290E00
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3291ED0 Offset: 0x3291FD1 VA: 0x3291ED0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3292F50 Offset: 0x3293051 VA: 0x3292F50
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3293FE0 Offset: 0x32940E1 VA: 0x3293FE0
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3295070 Offset: 0x3295171 VA: 0x3295070
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3296100 Offset: 0x3296201 VA: 0x3296100
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3297190 Offset: 0x3297291 VA: 0x3297190
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3298220 Offset: 0x3298321 VA: 0x3298220
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32992B0 Offset: 0x32993B1 VA: 0x32992B0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x329A360 Offset: 0x329A461 VA: 0x329A360
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x329B400 Offset: 0x329B501 VA: 0x329B400
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x329C4A0 Offset: 0x329C5A1 VA: 0x329C4A0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x329D540 Offset: 0x329D641 VA: 0x329D540
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x329E600 Offset: 0x329E701 VA: 0x329E600
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x329F7D0 Offset: 0x329F8D1 VA: 0x329F7D0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A0A10 Offset: 0x32A0B11 VA: 0x32A0A10
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A1B50 Offset: 0x32A1C51 VA: 0x32A1B50
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A2C00 Offset: 0x32A2D01 VA: 0x32A2C00
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A3DA0 Offset: 0x32A3EA1 VA: 0x32A3DA0
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A4E80 Offset: 0x32A4F81 VA: 0x32A4E80
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A5FD0 Offset: 0x32A60D1 VA: 0x32A5FD0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x32A7180 Offset: 0x32A7281 VA: 0x32A7180
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x31780F0 Offset: 0x31781F1 VA: 0x31780F0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3179390 Offset: 0x3179491 VA: 0x3179390
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x317A550 Offset: 0x317A651 VA: 0x317A550
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x317B5D0 Offset: 0x317B6D1 VA: 0x317B5D0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x317C680 Offset: 0x317C781 VA: 0x317C680
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x317D7C0 Offset: 0x317D8C1 VA: 0x317D7C0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x317E930 Offset: 0x317EA31 VA: 0x317E930
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x317FAA0 Offset: 0x317FBA1 VA: 0x317FAA0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3180B90 Offset: 0x3180C91 VA: 0x3180B90
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3181C60 Offset: 0x3181D61 VA: 0x3181C60
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3182F10 Offset: 0x3183011 VA: 0x3182F10
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3184230 Offset: 0x3184331 VA: 0x3184230
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3185390 Offset: 0x3185491 VA: 0x3185390
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x31864E0 Offset: 0x31865E1 VA: 0x31864E0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3187690 Offset: 0x3187791 VA: 0x3187690
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x31887B0 Offset: 0x31888B1 VA: 0x31887B0
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3189980 Offset: 0x3189A81 VA: 0x3189980
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x318AB50 Offset: 0x318AC51 VA: 0x318AB50
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x318BC50 Offset: 0x318BD51 VA: 0x318BC50
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x318CD90 Offset: 0x318CE91 VA: 0x318CD90
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x318DE60 Offset: 0x318DF61 VA: 0x318DE60
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x318EEE0 Offset: 0x318EFE1 VA: 0x318EEE0
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x318FFB0 Offset: 0x31900B1 VA: 0x318FFB0
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3191040 Offset: 0x3191141 VA: 0x3191040
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x31921F0 Offset: 0x31922F1 VA: 0x31921F0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3193410 Offset: 0x3193511 VA: 0x3193410
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3194550 Offset: 0x3194651 VA: 0x3194550
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3195600 Offset: 0x3195701 VA: 0x3195600
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x31966A0 Offset: 0x31967A1 VA: 0x31966A0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3197960 Offset: 0x3197A61 VA: 0x3197960
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3198B40 Offset: 0x3198C41 VA: 0x3198B40
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3199C80 Offset: 0x3199D81 VA: 0x3199C80
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x319ADF0 Offset: 0x319AEF1 VA: 0x319ADF0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x319BFA0 Offset: 0x319C0A1 VA: 0x319BFA0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E83080 Offset: 0x2E83181 VA: 0x2E83080
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E84230 Offset: 0x2E84331 VA: 0x2E84230
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E85330 Offset: 0x2E85431 VA: 0x2E85330
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E864B0 Offset: 0x2E865B1 VA: 0x2E864B0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E87650 Offset: 0x2E87751 VA: 0x2E87650
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E887C0 Offset: 0x2E888C1 VA: 0x2E887C0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E89930 Offset: 0x2E89A31 VA: 0x2E89930
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E8AA20 Offset: 0x2E8AB21 VA: 0x2E8AA20
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E8BAD0 Offset: 0x2E8BBD1 VA: 0x2E8BAD0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E8CB70 Offset: 0x2E8CC71 VA: 0x2E8CB70
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E8DDB0 Offset: 0x2E8DEB1 VA: 0x2E8DDB0
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E8EFD0 Offset: 0x2E8F0D1 VA: 0x2E8EFD0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E900A0 Offset: 0x2E901A1 VA: 0x2E900A0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E91130 Offset: 0x2E91231 VA: 0x2E91130
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E92200 Offset: 0x2E92301 VA: 0x2E92200
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E932D0 Offset: 0x2E933D1 VA: 0x2E932D0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E943A0 Offset: 0x2E944A1 VA: 0x2E943A0
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E95670 Offset: 0x2E95771 VA: 0x2E95670
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E96830 Offset: 0x2E96931 VA: 0x2E96830
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2E97980 Offset: 0x2E97A81 VA: 0x2E97980
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE90F0 Offset: 0x2EE91F1 VA: 0x2EE90F0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EEA3E0 Offset: 0x2EEA4E1 VA: 0x2EEA3E0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EEB5C0 Offset: 0x2EEB6C1 VA: 0x2EEB5C0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EEC660 Offset: 0x2EEC761 VA: 0x2EEC660
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EED720 Offset: 0x2EED821 VA: 0x2EED720
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EEE7D0 Offset: 0x2EEE8D1 VA: 0x2EEE7D0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EEF850 Offset: 0x2EEF951 VA: 0x2EEF850
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF08E0 Offset: 0x2EF09E1 VA: 0x2EF08E0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF1A70 Offset: 0x2EF1B71 VA: 0x2EF1A70
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF2C70 Offset: 0x2EF2D71 VA: 0x2EF2C70
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF3E40 Offset: 0x2EF3F41 VA: 0x2EF3E40
	|-ReadOnlyCollection<CropDataTable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF4F30 Offset: 0x2EF5031 VA: 0x2EF4F30
	|-ReadOnlyCollection<DropItemParam>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF6080 Offset: 0x2EF6181 VA: 0x2EF6080
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF71F0 Offset: 0x2EF72F1 VA: 0x2EF71F0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF82C0 Offset: 0x2EF83C1 VA: 0x2EF82C0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EF9360 Offset: 0x2EF9461 VA: 0x2EF9360
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EFA500 Offset: 0x2EFA601 VA: 0x2EFA500
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EFB6E0 Offset: 0x2EFB7E1 VA: 0x2EFB6E0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2EFC7E0 Offset: 0x2EFC8E1 VA: 0x2EFC7E0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32E67D0 Offset: 0x32E68D1 VA: 0x32E67D0
	|-ReadOnlyCollection<NPCActionData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32E7990 Offset: 0x32E7A91 VA: 0x32E7990
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32E8A80 Offset: 0x32E8B81 VA: 0x32E8A80
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32E9BD0 Offset: 0x32E9CD1 VA: 0x32E9BD0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32EACA0 Offset: 0x32EADA1 VA: 0x32EACA0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32EBD40 Offset: 0x32EBE41 VA: 0x32EBD40
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32ECEC0 Offset: 0x32ECFC1 VA: 0x32ECEC0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32EDFE0 Offset: 0x32EE0E1 VA: 0x32EDFE0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32EF070 Offset: 0x32EF171 VA: 0x32EF070
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F0140 Offset: 0x32F0241 VA: 0x32F0140
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F1290 Offset: 0x32F1391 VA: 0x32F1290
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F2400 Offset: 0x32F2501 VA: 0x32F2400
	|-ReadOnlyCollection<Schedule>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F3630 Offset: 0x32F3731 VA: 0x32F3630
	|-ReadOnlyCollection<CurveSample>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F4770 Offset: 0x32F4871 VA: 0x32F4770
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F5810 Offset: 0x32F5911 VA: 0x32F5810
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F68A0 Offset: 0x32F69A1 VA: 0x32F68A0
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F7950 Offset: 0x32F7A51 VA: 0x32F7950
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F89F0 Offset: 0x32F8AF1 VA: 0x32F89F0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32F9A90 Offset: 0x32F9B91 VA: 0x32F9A90
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32FAB10 Offset: 0x32FAC11 VA: 0x32FAB10
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32FBBA0 Offset: 0x32FBCA1 VA: 0x32FBBA0
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32FCC30 Offset: 0x32FCD31 VA: 0x32FCC30
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32FDCC0 Offset: 0x32FDDC1 VA: 0x32FDCC0
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32FED50 Offset: 0x32FEE51 VA: 0x32FED50
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32FFDE0 Offset: 0x32FFEE1 VA: 0x32FFDE0
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3300E90 Offset: 0x3300F91 VA: 0x3300E90
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3301F10 Offset: 0x3302011 VA: 0x3301F10
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x33030A0 Offset: 0x33031A1 VA: 0x33030A0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x33042A0 Offset: 0x33043A1 VA: 0x33042A0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x33053A0 Offset: 0x33054A1 VA: 0x33053A0
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x33064F0 Offset: 0x33065F1 VA: 0x33064F0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3307620 Offset: 0x3307721 VA: 0x3307620
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3308780 Offset: 0x3308881 VA: 0x3308780
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3309930 Offset: 0x3309A31 VA: 0x3309930
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3283FD0 Offset: 0x32840D1 VA: 0x3283FD0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3285200 Offset: 0x3285301 VA: 0x3285200
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3286420 Offset: 0x3286521 VA: 0x3286420
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3287550 Offset: 0x3287651 VA: 0x3287550
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32886B0 Offset: 0x32887B1 VA: 0x32886B0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3289860 Offset: 0x3289961 VA: 0x3289860
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x328A990 Offset: 0x328AA91 VA: 0x328A990
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x328BA70 Offset: 0x328BB71 VA: 0x328BA70
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x328CB30 Offset: 0x328CC31 VA: 0x328CB30
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x328DBD0 Offset: 0x328DCD1 VA: 0x328DBD0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x328ED10 Offset: 0x328EE11 VA: 0x328ED10
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x328FE00 Offset: 0x328FF01 VA: 0x328FE00
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3290E20 Offset: 0x3290F21 VA: 0x3290E20
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3291EF0 Offset: 0x3291FF1 VA: 0x3291EF0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3292F70 Offset: 0x3293071 VA: 0x3292F70
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3294000 Offset: 0x3294101 VA: 0x3294000
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3295090 Offset: 0x3295191 VA: 0x3295090
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3296120 Offset: 0x3296221 VA: 0x3296120
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32971B0 Offset: 0x32972B1 VA: 0x32971B0
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3298240 Offset: 0x3298341 VA: 0x3298240
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32992D0 Offset: 0x32993D1 VA: 0x32992D0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x329A380 Offset: 0x329A481 VA: 0x329A380
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x329B420 Offset: 0x329B521 VA: 0x329B420
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x329C4C0 Offset: 0x329C5C1 VA: 0x329C4C0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x329D560 Offset: 0x329D661 VA: 0x329D560
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x329E620 Offset: 0x329E721 VA: 0x329E620
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x329F7F0 Offset: 0x329F8F1 VA: 0x329F7F0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A0A30 Offset: 0x32A0B31 VA: 0x32A0A30
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A1B70 Offset: 0x32A1C71 VA: 0x32A1B70
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A2C20 Offset: 0x32A2D21 VA: 0x32A2C20
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A3DC0 Offset: 0x32A3EC1 VA: 0x32A3DC0
	|-ReadOnlyCollection<CapEdge>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A4EA0 Offset: 0x32A4FA1 VA: 0x32A4EA0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A5FF0 Offset: 0x32A60F1 VA: 0x32A5FF0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x32A71A0 Offset: 0x32A72A1 VA: 0x32A71A0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3178110 Offset: 0x3178211 VA: 0x3178110
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x31793B0 Offset: 0x31794B1 VA: 0x31793B0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x317A570 Offset: 0x317A671 VA: 0x317A570
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x317B5F0 Offset: 0x317B6F1 VA: 0x317B5F0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x317C6A0 Offset: 0x317C7A1 VA: 0x317C6A0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x317D7E0 Offset: 0x317D8E1 VA: 0x317D7E0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x317E950 Offset: 0x317EA51 VA: 0x317E950
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x317FAC0 Offset: 0x317FBC1 VA: 0x317FAC0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3180BB0 Offset: 0x3180CB1 VA: 0x3180BB0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3181C80 Offset: 0x3181D81 VA: 0x3181C80
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3182F30 Offset: 0x3183031 VA: 0x3182F30
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3184250 Offset: 0x3184351 VA: 0x3184250
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x31853B0 Offset: 0x31854B1 VA: 0x31853B0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3186500 Offset: 0x3186601 VA: 0x3186500
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x31876B0 Offset: 0x31877B1 VA: 0x31876B0
	|-ReadOnlyCollection<Keyframe>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x31887D0 Offset: 0x31888D1 VA: 0x31887D0
	|-ReadOnlyCollection<LayerMask>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x31899A0 Offset: 0x3189AA1 VA: 0x31899A0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x318AB70 Offset: 0x318AC71 VA: 0x318AB70
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x318BC70 Offset: 0x318BD71 VA: 0x318BC70
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x318CDB0 Offset: 0x318CEB1 VA: 0x318CDB0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x318DE80 Offset: 0x318DF81 VA: 0x318DE80
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x318EF00 Offset: 0x318F001 VA: 0x318EF00
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x318FFD0 Offset: 0x31900D1 VA: 0x318FFD0
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3191060 Offset: 0x3191161 VA: 0x3191060
	|-ReadOnlyCollection<RangeInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3192210 Offset: 0x3192311 VA: 0x3192210
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3193430 Offset: 0x3193531 VA: 0x3193430
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3194570 Offset: 0x3194671 VA: 0x3194570
	|-ReadOnlyCollection<Rect>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3195620 Offset: 0x3195721 VA: 0x3195620
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x31966C0 Offset: 0x31967C1 VA: 0x31966C0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3197980 Offset: 0x3197A81 VA: 0x3197980
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3198B60 Offset: 0x3198C61 VA: 0x3198B60
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3199CA0 Offset: 0x3199DA1 VA: 0x3199CA0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x319AE10 Offset: 0x319AF11 VA: 0x319AE10
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x319BFC0 Offset: 0x319C0C1 VA: 0x319BFC0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E830A0 Offset: 0x2E831A1 VA: 0x2E830A0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E84250 Offset: 0x2E84351 VA: 0x2E84250
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E85350 Offset: 0x2E85451 VA: 0x2E85350
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E864D0 Offset: 0x2E865D1 VA: 0x2E864D0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E87670 Offset: 0x2E87771 VA: 0x2E87670
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E887E0 Offset: 0x2E888E1 VA: 0x2E887E0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E89950 Offset: 0x2E89A51 VA: 0x2E89950
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E8AA40 Offset: 0x2E8AB41 VA: 0x2E8AA40
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E8BAF0 Offset: 0x2E8BBF1 VA: 0x2E8BAF0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E8CB90 Offset: 0x2E8CC91 VA: 0x2E8CB90
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E8DDD0 Offset: 0x2E8DED1 VA: 0x2E8DDD0
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E8EFF0 Offset: 0x2E8F0F1 VA: 0x2E8EFF0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E900C0 Offset: 0x2E901C1 VA: 0x2E900C0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E91150 Offset: 0x2E91251 VA: 0x2E91150
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E92220 Offset: 0x2E92321 VA: 0x2E92220
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E932F0 Offset: 0x2E933F1 VA: 0x2E932F0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E943C0 Offset: 0x2E944C1 VA: 0x2E943C0
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E95690 Offset: 0x2E95791 VA: 0x2E95690
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E96850 Offset: 0x2E96951 VA: 0x2E96850
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2E979A0 Offset: 0x2E97AA1 VA: 0x2E979A0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9100 Offset: 0x2EE9201 VA: 0x2EE9100
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EEA3F0 Offset: 0x2EEA4F1 VA: 0x2EEA3F0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EEB5D0 Offset: 0x2EEB6D1 VA: 0x2EEB5D0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EEC670 Offset: 0x2EEC771 VA: 0x2EEC670
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EED730 Offset: 0x2EED831 VA: 0x2EED730
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EEE7E0 Offset: 0x2EEE8E1 VA: 0x2EEE7E0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EEF860 Offset: 0x2EEF961 VA: 0x2EEF860
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF08F0 Offset: 0x2EF09F1 VA: 0x2EF08F0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF1A80 Offset: 0x2EF1B81 VA: 0x2EF1A80
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF2C80 Offset: 0x2EF2D81 VA: 0x2EF2C80
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF3E50 Offset: 0x2EF3F51 VA: 0x2EF3E50
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF4F40 Offset: 0x2EF5041 VA: 0x2EF4F40
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF6090 Offset: 0x2EF6191 VA: 0x2EF6090
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF7200 Offset: 0x2EF7301 VA: 0x2EF7200
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF82D0 Offset: 0x2EF83D1 VA: 0x2EF82D0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EF9370 Offset: 0x2EF9471 VA: 0x2EF9370
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EFA510 Offset: 0x2EFA611 VA: 0x2EFA510
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EFB6F0 Offset: 0x2EFB7F1 VA: 0x2EFB6F0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2EFC7F0 Offset: 0x2EFC8F1 VA: 0x2EFC7F0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32E67E0 Offset: 0x32E68E1 VA: 0x32E67E0
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32E79A0 Offset: 0x32E7AA1 VA: 0x32E79A0
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32E8A90 Offset: 0x32E8B91 VA: 0x32E8A90
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32E9BE0 Offset: 0x32E9CE1 VA: 0x32E9BE0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32EACB0 Offset: 0x32EADB1 VA: 0x32EACB0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32EBD50 Offset: 0x32EBE51 VA: 0x32EBD50
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32ECED0 Offset: 0x32ECFD1 VA: 0x32ECED0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32EDFF0 Offset: 0x32EE0F1 VA: 0x32EDFF0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32EF080 Offset: 0x32EF181 VA: 0x32EF080
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F0150 Offset: 0x32F0251 VA: 0x32F0150
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F12A0 Offset: 0x32F13A1 VA: 0x32F12A0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F2410 Offset: 0x32F2511 VA: 0x32F2410
	|-ReadOnlyCollection<Schedule>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F3640 Offset: 0x32F3741 VA: 0x32F3640
	|-ReadOnlyCollection<CurveSample>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F4780 Offset: 0x32F4881 VA: 0x32F4780
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F5820 Offset: 0x32F5921 VA: 0x32F5820
	|-ReadOnlyCollection<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F68B0 Offset: 0x32F69B1 VA: 0x32F68B0
	|-ReadOnlyCollection<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F7960 Offset: 0x32F7A61 VA: 0x32F7960
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F8A00 Offset: 0x32F8B01 VA: 0x32F8A00
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32F9AA0 Offset: 0x32F9BA1 VA: 0x32F9AA0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32FAB20 Offset: 0x32FAC21 VA: 0x32FAB20
	|-ReadOnlyCollection<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32FBBB0 Offset: 0x32FBCB1 VA: 0x32FBBB0
	|-ReadOnlyCollection<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32FCC40 Offset: 0x32FCD41 VA: 0x32FCC40
	|-ReadOnlyCollection<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32FDCD0 Offset: 0x32FDDD1 VA: 0x32FDCD0
	|-ReadOnlyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32FED60 Offset: 0x32FEE61 VA: 0x32FED60
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32FFDF0 Offset: 0x32FFEF1 VA: 0x32FFDF0
	|-ReadOnlyCollection<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3300EA0 Offset: 0x3300FA1 VA: 0x3300EA0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3301F20 Offset: 0x3302021 VA: 0x3301F20
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33030B0 Offset: 0x33031B1 VA: 0x33030B0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33042B0 Offset: 0x33043B1 VA: 0x33042B0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33053B0 Offset: 0x33054B1 VA: 0x33053B0
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3306500 Offset: 0x3306601 VA: 0x3306500
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3307630 Offset: 0x3307731 VA: 0x3307630
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3308790 Offset: 0x3308891 VA: 0x3308790
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3309940 Offset: 0x3309A41 VA: 0x3309940
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3283FE0 Offset: 0x32840E1 VA: 0x3283FE0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3285210 Offset: 0x3285311 VA: 0x3285210
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3286430 Offset: 0x3286531 VA: 0x3286430
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3287560 Offset: 0x3287661 VA: 0x3287560
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32886C0 Offset: 0x32887C1 VA: 0x32886C0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3289870 Offset: 0x3289971 VA: 0x3289870
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x328A9A0 Offset: 0x328AAA1 VA: 0x328A9A0
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x328BA80 Offset: 0x328BB81 VA: 0x328BA80
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x328CB40 Offset: 0x328CC41 VA: 0x328CB40
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x328DBE0 Offset: 0x328DCE1 VA: 0x328DBE0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x328ED20 Offset: 0x328EE21 VA: 0x328ED20
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x328FE10 Offset: 0x328FF11 VA: 0x328FE10
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3290E30 Offset: 0x3290F31 VA: 0x3290E30
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3291F00 Offset: 0x3292001 VA: 0x3291F00
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3292F80 Offset: 0x3293081 VA: 0x3292F80
	|-ReadOnlyCollection<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3294010 Offset: 0x3294111 VA: 0x3294010
	|-ReadOnlyCollection<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32950A0 Offset: 0x32951A1 VA: 0x32950A0
	|-ReadOnlyCollection<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3296130 Offset: 0x3296231 VA: 0x3296130
	|-ReadOnlyCollection<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32971C0 Offset: 0x32972C1 VA: 0x32971C0
	|-ReadOnlyCollection<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3298250 Offset: 0x3298351 VA: 0x3298250
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32992E0 Offset: 0x32993E1 VA: 0x32992E0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x329A390 Offset: 0x329A491 VA: 0x329A390
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x329B430 Offset: 0x329B531 VA: 0x329B430
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x329C4D0 Offset: 0x329C5D1 VA: 0x329C4D0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x329D570 Offset: 0x329D671 VA: 0x329D570
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x329E630 Offset: 0x329E731 VA: 0x329E630
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x329F800 Offset: 0x329F901 VA: 0x329F800
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A0A40 Offset: 0x32A0B41 VA: 0x32A0A40
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A1B80 Offset: 0x32A1C81 VA: 0x32A1B80
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A2C30 Offset: 0x32A2D31 VA: 0x32A2C30
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A3DD0 Offset: 0x32A3ED1 VA: 0x32A3DD0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A4EB0 Offset: 0x32A4FB1 VA: 0x32A4EB0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A6000 Offset: 0x32A6101 VA: 0x32A6000
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A71B0 Offset: 0x32A72B1 VA: 0x32A71B0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3178120 Offset: 0x3178221 VA: 0x3178120
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31793C0 Offset: 0x31794C1 VA: 0x31793C0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x317A580 Offset: 0x317A681 VA: 0x317A580
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x317B600 Offset: 0x317B701 VA: 0x317B600
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x317C6B0 Offset: 0x317C7B1 VA: 0x317C6B0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x317D7F0 Offset: 0x317D8F1 VA: 0x317D7F0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x317E960 Offset: 0x317EA61 VA: 0x317E960
	|-ReadOnlyCollection<Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x317FAD0 Offset: 0x317FBD1 VA: 0x317FAD0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3180BC0 Offset: 0x3180CC1 VA: 0x3180BC0
	|-ReadOnlyCollection<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3181C90 Offset: 0x3181D91 VA: 0x3181C90
	|-ReadOnlyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3182F40 Offset: 0x3183041 VA: 0x3182F40
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3184260 Offset: 0x3184361 VA: 0x3184260
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31853C0 Offset: 0x31854C1 VA: 0x31853C0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3186510 Offset: 0x3186611 VA: 0x3186510
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31876C0 Offset: 0x31877C1 VA: 0x31876C0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31887E0 Offset: 0x31888E1 VA: 0x31887E0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31899B0 Offset: 0x3189AB1 VA: 0x31899B0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318AB80 Offset: 0x318AC81 VA: 0x318AB80
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318BC80 Offset: 0x318BD81 VA: 0x318BC80
	|-ReadOnlyCollection<Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318CDC0 Offset: 0x318CEC1 VA: 0x318CDC0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318DE90 Offset: 0x318DF91 VA: 0x318DE90
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318EF10 Offset: 0x318F011 VA: 0x318EF10
	|-ReadOnlyCollection<Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318FFE0 Offset: 0x31900E1 VA: 0x318FFE0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3191070 Offset: 0x3191171 VA: 0x3191070
	|-ReadOnlyCollection<RangeInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3192220 Offset: 0x3192321 VA: 0x3192220
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3193440 Offset: 0x3193541 VA: 0x3193440
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3194580 Offset: 0x3194681 VA: 0x3194580
	|-ReadOnlyCollection<Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3195630 Offset: 0x3195731 VA: 0x3195630
	|-ReadOnlyCollection<RectInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31966D0 Offset: 0x31967D1 VA: 0x31966D0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3197990 Offset: 0x3197A91 VA: 0x3197990
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3198B70 Offset: 0x3198C71 VA: 0x3198B70
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3199CB0 Offset: 0x3199DB1 VA: 0x3199CB0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319AE20 Offset: 0x319AF21 VA: 0x319AE20
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319BFD0 Offset: 0x319C0D1 VA: 0x319BFD0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E830B0 Offset: 0x2E831B1 VA: 0x2E830B0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E84260 Offset: 0x2E84361 VA: 0x2E84260
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E85360 Offset: 0x2E85461 VA: 0x2E85360
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E864E0 Offset: 0x2E865E1 VA: 0x2E864E0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E87680 Offset: 0x2E87781 VA: 0x2E87680
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E887F0 Offset: 0x2E888F1 VA: 0x2E887F0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E89960 Offset: 0x2E89A61 VA: 0x2E89960
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E8AA50 Offset: 0x2E8AB51 VA: 0x2E8AA50
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E8BB00 Offset: 0x2E8BC01 VA: 0x2E8BB00
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E8CBA0 Offset: 0x2E8CCA1 VA: 0x2E8CBA0
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E8DDE0 Offset: 0x2E8DEE1 VA: 0x2E8DDE0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E8F000 Offset: 0x2E8F101 VA: 0x2E8F000
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E900D0 Offset: 0x2E901D1 VA: 0x2E900D0
	|-ReadOnlyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E91160 Offset: 0x2E91261 VA: 0x2E91160
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E92230 Offset: 0x2E92331 VA: 0x2E92230
	|-ReadOnlyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E93300 Offset: 0x2E93401 VA: 0x2E93300
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E943D0 Offset: 0x2E944D1 VA: 0x2E943D0
	|-ReadOnlyCollection<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E956A0 Offset: 0x2E957A1 VA: 0x2E956A0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E96860 Offset: 0x2E96961 VA: 0x2E96860
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E979B0 Offset: 0x2E97AB1 VA: 0x2E979B0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE91B0 Offset: 0x2EE92B1 VA: 0x2EE91B0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EEA4A0 Offset: 0x2EEA5A1 VA: 0x2EEA4A0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EEB680 Offset: 0x2EEB781 VA: 0x2EEB680
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EEC720 Offset: 0x2EEC821 VA: 0x2EEC720
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EED7E0 Offset: 0x2EED8E1 VA: 0x2EED7E0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EEE890 Offset: 0x2EEE991 VA: 0x2EEE890
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EEF910 Offset: 0x2EEFA11 VA: 0x2EEF910
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF09A0 Offset: 0x2EF0AA1 VA: 0x2EF09A0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF1B30 Offset: 0x2EF1C31 VA: 0x2EF1B30
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF2D30 Offset: 0x2EF2E31 VA: 0x2EF2D30
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF3F00 Offset: 0x2EF4001 VA: 0x2EF3F00
	|-ReadOnlyCollection<CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF4FF0 Offset: 0x2EF50F1 VA: 0x2EF4FF0
	|-ReadOnlyCollection<DropItemParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF6140 Offset: 0x2EF6241 VA: 0x2EF6140
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF72B0 Offset: 0x2EF73B1 VA: 0x2EF72B0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF8380 Offset: 0x2EF8481 VA: 0x2EF8380
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EF9420 Offset: 0x2EF9521 VA: 0x2EF9420
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EFA5C0 Offset: 0x2EFA6C1 VA: 0x2EFA5C0
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EFB7A0 Offset: 0x2EFB8A1 VA: 0x2EFB7A0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EFC8A0 Offset: 0x2EFC9A1 VA: 0x2EFC8A0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32E6890 Offset: 0x32E6991 VA: 0x32E6890
	|-ReadOnlyCollection<NPCActionData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32E7A50 Offset: 0x32E7B51 VA: 0x32E7A50
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32E8B40 Offset: 0x32E8C41 VA: 0x32E8B40
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32E9C90 Offset: 0x32E9D91 VA: 0x32E9C90
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32EAD60 Offset: 0x32EAE61 VA: 0x32EAD60
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32EBE00 Offset: 0x32EBF01 VA: 0x32EBE00
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32ECF80 Offset: 0x32ED081 VA: 0x32ECF80
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32EE0A0 Offset: 0x32EE1A1 VA: 0x32EE0A0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32EF130 Offset: 0x32EF231 VA: 0x32EF130
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F0200 Offset: 0x32F0301 VA: 0x32F0200
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F1350 Offset: 0x32F1451 VA: 0x32F1350
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F24C0 Offset: 0x32F25C1 VA: 0x32F24C0
	|-ReadOnlyCollection<Schedule>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F36F0 Offset: 0x32F37F1 VA: 0x32F36F0
	|-ReadOnlyCollection<CurveSample>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F4830 Offset: 0x32F4931 VA: 0x32F4830
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F58D0 Offset: 0x32F59D1 VA: 0x32F58D0
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F6960 Offset: 0x32F6A61 VA: 0x32F6960
	|-ReadOnlyCollection<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F7A10 Offset: 0x32F7B11 VA: 0x32F7A10
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F8AB0 Offset: 0x32F8BB1 VA: 0x32F8AB0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32F9B50 Offset: 0x32F9C51 VA: 0x32F9B50
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32FABD0 Offset: 0x32FACD1 VA: 0x32FABD0
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32FBC60 Offset: 0x32FBD61 VA: 0x32FBC60
	|-ReadOnlyCollection<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32FCCF0 Offset: 0x32FCDF1 VA: 0x32FCCF0
	|-ReadOnlyCollection<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32FDD80 Offset: 0x32FDE81 VA: 0x32FDD80
	|-ReadOnlyCollection<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32FEE10 Offset: 0x32FEF11 VA: 0x32FEE10
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32FFEA0 Offset: 0x32FFFA1 VA: 0x32FFEA0
	|-ReadOnlyCollection<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3300F50 Offset: 0x3301051 VA: 0x3300F50
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3301FD0 Offset: 0x33020D1 VA: 0x3301FD0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3303160 Offset: 0x3303261 VA: 0x3303160
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3304360 Offset: 0x3304461 VA: 0x3304360
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3305460 Offset: 0x3305561 VA: 0x3305460
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33065B0 Offset: 0x33066B1 VA: 0x33065B0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33076E0 Offset: 0x33077E1 VA: 0x33076E0
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3308840 Offset: 0x3308941 VA: 0x3308840
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33099F0 Offset: 0x3309AF1 VA: 0x33099F0
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3284090 Offset: 0x3284191 VA: 0x3284090
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32852C0 Offset: 0x32853C1 VA: 0x32852C0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32864E0 Offset: 0x32865E1 VA: 0x32864E0
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3287610 Offset: 0x3287711 VA: 0x3287610
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3288770 Offset: 0x3288871 VA: 0x3288770
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3289920 Offset: 0x3289A21 VA: 0x3289920
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x328AA50 Offset: 0x328AB51 VA: 0x328AA50
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x328BB30 Offset: 0x328BC31 VA: 0x328BB30
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x328CBF0 Offset: 0x328CCF1 VA: 0x328CBF0
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x328DC90 Offset: 0x328DD91 VA: 0x328DC90
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x328EDD0 Offset: 0x328EED1 VA: 0x328EDD0
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x328FEC0 Offset: 0x328FFC1 VA: 0x328FEC0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3290EE0 Offset: 0x3290FE1 VA: 0x3290EE0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3291FB0 Offset: 0x32920B1 VA: 0x3291FB0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3293030 Offset: 0x3293131 VA: 0x3293030
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32940C0 Offset: 0x32941C1 VA: 0x32940C0
	|-ReadOnlyCollection<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3295150 Offset: 0x3295251 VA: 0x3295150
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32961E0 Offset: 0x32962E1 VA: 0x32961E0
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3297270 Offset: 0x3297371 VA: 0x3297270
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3298300 Offset: 0x3298401 VA: 0x3298300
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3299390 Offset: 0x3299491 VA: 0x3299390
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x329A440 Offset: 0x329A541 VA: 0x329A440
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x329B4E0 Offset: 0x329B5E1 VA: 0x329B4E0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x329C580 Offset: 0x329C681 VA: 0x329C580
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x329D620 Offset: 0x329D721 VA: 0x329D620
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x329E6E0 Offset: 0x329E7E1 VA: 0x329E6E0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x329F8B0 Offset: 0x329F9B1 VA: 0x329F8B0
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A0AF0 Offset: 0x32A0BF1 VA: 0x32A0AF0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A1C30 Offset: 0x32A1D31 VA: 0x32A1C30
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A2CE0 Offset: 0x32A2DE1 VA: 0x32A2CE0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A3E80 Offset: 0x32A3F81 VA: 0x32A3E80
	|-ReadOnlyCollection<CapEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A4F60 Offset: 0x32A5061 VA: 0x32A4F60
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A60B0 Offset: 0x32A61B1 VA: 0x32A60B0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A7260 Offset: 0x32A7361 VA: 0x32A7260
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31781D0 Offset: 0x31782D1 VA: 0x31781D0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3179470 Offset: 0x3179571 VA: 0x3179470
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x317A630 Offset: 0x317A731 VA: 0x317A630
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x317B6B0 Offset: 0x317B7B1 VA: 0x317B6B0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x317C760 Offset: 0x317C861 VA: 0x317C760
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x317D8A0 Offset: 0x317D9A1 VA: 0x317D8A0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x317EA10 Offset: 0x317EB11 VA: 0x317EA10
	|-ReadOnlyCollection<Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x317FB80 Offset: 0x317FC81 VA: 0x317FB80
	|-ReadOnlyCollection<BoundsInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3180C70 Offset: 0x3180D71 VA: 0x3180C70
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3181D40 Offset: 0x3181E41 VA: 0x3181D40
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3182FF0 Offset: 0x31830F1 VA: 0x3182FF0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3184310 Offset: 0x3184411 VA: 0x3184310
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3185470 Offset: 0x3185571 VA: 0x3185470
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31865C0 Offset: 0x31866C1 VA: 0x31865C0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3187770 Offset: 0x3187871 VA: 0x3187770
	|-ReadOnlyCollection<Keyframe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3188890 Offset: 0x3188991 VA: 0x3188890
	|-ReadOnlyCollection<LayerMask>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3189A60 Offset: 0x3189B61 VA: 0x3189A60
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x318AC30 Offset: 0x318AD31 VA: 0x318AC30
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x318BD30 Offset: 0x318BE31 VA: 0x318BD30
	|-ReadOnlyCollection<Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x318CE70 Offset: 0x318CF71 VA: 0x318CE70
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x318DF40 Offset: 0x318E041 VA: 0x318DF40
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x318EFC0 Offset: 0x318F0C1 VA: 0x318EFC0
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3190090 Offset: 0x3190191 VA: 0x3190090
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3191120 Offset: 0x3191221 VA: 0x3191120
	|-ReadOnlyCollection<RangeInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31922D0 Offset: 0x31923D1 VA: 0x31922D0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31934F0 Offset: 0x31935F1 VA: 0x31934F0
	|-ReadOnlyCollection<RaycastHit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3194630 Offset: 0x3194731 VA: 0x3194630
	|-ReadOnlyCollection<Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31956E0 Offset: 0x31957E1 VA: 0x31956E0
	|-ReadOnlyCollection<RectInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3196780 Offset: 0x3196881 VA: 0x3196780
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3197A40 Offset: 0x3197B41 VA: 0x3197A40
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3198C20 Offset: 0x3198D21 VA: 0x3198C20
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3199D60 Offset: 0x3199E61 VA: 0x3199D60
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x319AED0 Offset: 0x319AFD1 VA: 0x319AED0
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x319C080 Offset: 0x319C181 VA: 0x319C080
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E83160 Offset: 0x2E83261 VA: 0x2E83160
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E84310 Offset: 0x2E84411 VA: 0x2E84310
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E85410 Offset: 0x2E85511 VA: 0x2E85410
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E86590 Offset: 0x2E86691 VA: 0x2E86590
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E87730 Offset: 0x2E87831 VA: 0x2E87730
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E888A0 Offset: 0x2E889A1 VA: 0x2E888A0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E89A10 Offset: 0x2E89B11 VA: 0x2E89A10
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E8AB00 Offset: 0x2E8AC01 VA: 0x2E8AB00
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E8BBB0 Offset: 0x2E8BCB1 VA: 0x2E8BBB0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E8CC50 Offset: 0x2E8CD51 VA: 0x2E8CC50
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E8DE90 Offset: 0x2E8DF91 VA: 0x2E8DE90
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E8F0B0 Offset: 0x2E8F1B1 VA: 0x2E8F0B0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E90180 Offset: 0x2E90281 VA: 0x2E90180
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E91210 Offset: 0x2E91311 VA: 0x2E91210
	|-ReadOnlyCollection<Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E922E0 Offset: 0x2E923E1 VA: 0x2E922E0
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E933B0 Offset: 0x2E934B1 VA: 0x2E933B0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E94480 Offset: 0x2E94581 VA: 0x2E94480
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E95750 Offset: 0x2E95851 VA: 0x2E95750
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E96910 Offset: 0x2E96A11 VA: 0x2E96910
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E97A60 Offset: 0x2E97B61 VA: 0x2E97A60
	|-ReadOnlyCollection<stCommand_t>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE97E0 Offset: 0x2EE98E1 VA: 0x2EE97E0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EEAB40 Offset: 0x2EEAC41 VA: 0x2EEAB40
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EEBC90 Offset: 0x2EEBD91 VA: 0x2EEBC90
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EECD30 Offset: 0x2EECE31 VA: 0x2EECD30
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EEDE00 Offset: 0x2EEDF01 VA: 0x2EEDE00
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EEEEA0 Offset: 0x2EEEFA1 VA: 0x2EEEEA0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EEFF20 Offset: 0x2EF0021 VA: 0x2EEFF20
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF0FB0 Offset: 0x2EF10B1 VA: 0x2EF0FB0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF2170 Offset: 0x2EF2271 VA: 0x2EF2170
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF3370 Offset: 0x2EF3471 VA: 0x2EF3370
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF4540 Offset: 0x2EF4641 VA: 0x2EF4540
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF5600 Offset: 0x2EF5701 VA: 0x2EF5600
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF6770 Offset: 0x2EF6871 VA: 0x2EF6770
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF78E0 Offset: 0x2EF79E1 VA: 0x2EF78E0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF8990 Offset: 0x2EF8A91 VA: 0x2EF8990
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EF9A30 Offset: 0x2EF9B31 VA: 0x2EF9A30
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EFAC00 Offset: 0x2EFAD01 VA: 0x2EFAC00
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EFBDE0 Offset: 0x2EFBEE1 VA: 0x2EFBDE0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2EFCEB0 Offset: 0x2EFCFB1 VA: 0x2EFCEB0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32E6EE0 Offset: 0x32E6FE1 VA: 0x32E6EE0
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32E8080 Offset: 0x32E8181 VA: 0x32E8080
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32E9160 Offset: 0x32E9261 VA: 0x32E9160
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32EA2C0 Offset: 0x32EA3C1 VA: 0x32EA2C0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32EB370 Offset: 0x32EB471 VA: 0x32EB370
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32EC410 Offset: 0x32EC511 VA: 0x32EC410
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32ED5C0 Offset: 0x32ED6C1 VA: 0x32ED5C0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32EE6C0 Offset: 0x32EE7C1 VA: 0x32EE6C0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32EF740 Offset: 0x32EF841 VA: 0x32EF740
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F0820 Offset: 0x32F0921 VA: 0x32F0820
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F1980 Offset: 0x32F1A81 VA: 0x32F1980
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F2AF0 Offset: 0x32F2BF1 VA: 0x32F2AF0
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F3D50 Offset: 0x32F3E51 VA: 0x32F3D50
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F4E50 Offset: 0x32F4F51 VA: 0x32F4E50
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F5EE0 Offset: 0x32F5FE1 VA: 0x32F5EE0
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F6F70 Offset: 0x32F7071 VA: 0x32F6F70
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F8020 Offset: 0x32F8121 VA: 0x32F8020
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32F90C0 Offset: 0x32F91C1 VA: 0x32F90C0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32FA160 Offset: 0x32FA261 VA: 0x32FA160
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32FB1E0 Offset: 0x32FB2E1 VA: 0x32FB1E0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32FC270 Offset: 0x32FC371 VA: 0x32FC270
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32FD300 Offset: 0x32FD401 VA: 0x32FD300
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32FE390 Offset: 0x32FE491 VA: 0x32FE390
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32FF420 Offset: 0x32FF521 VA: 0x32FF420
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33004B0 Offset: 0x33005B1 VA: 0x33004B0
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3301560 Offset: 0x3301661 VA: 0x3301560
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33025E0 Offset: 0x33026E1 VA: 0x33025E0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33037A0 Offset: 0x33038A1 VA: 0x33037A0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33049A0 Offset: 0x3304AA1 VA: 0x33049A0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3305A70 Offset: 0x3305B71 VA: 0x3305A70
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3306BE0 Offset: 0x3306CE1 VA: 0x3306BE0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3307D00 Offset: 0x3307E01 VA: 0x3307D00
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3308E70 Offset: 0x3308F71 VA: 0x3308E70
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x330A020 Offset: 0x330A121 VA: 0x330A020
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32846A0 Offset: 0x32847A1 VA: 0x32846A0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3285920 Offset: 0x3285A21 VA: 0x3285920
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3286B10 Offset: 0x3286C11 VA: 0x3286B10
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3287C30 Offset: 0x3287D31 VA: 0x3287C30
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3288DA0 Offset: 0x3288EA1 VA: 0x3288DA0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3289F50 Offset: 0x328A051 VA: 0x3289F50
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x328B070 Offset: 0x328B171 VA: 0x328B070
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x328C150 Offset: 0x328C251 VA: 0x328C150
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x328D200 Offset: 0x328D301 VA: 0x328D200
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x328E2A0 Offset: 0x328E3A1 VA: 0x328E2A0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x328F400 Offset: 0x328F501 VA: 0x328F400
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3290450 Offset: 0x3290551 VA: 0x3290450
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3291510 Offset: 0x3291611 VA: 0x3291510
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32925C0 Offset: 0x32926C1 VA: 0x32925C0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3293640 Offset: 0x3293741 VA: 0x3293640
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32946D0 Offset: 0x32947D1 VA: 0x32946D0
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3295760 Offset: 0x3295861 VA: 0x3295760
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32967F0 Offset: 0x32968F1 VA: 0x32967F0
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3297880 Offset: 0x3297981 VA: 0x3297880
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3298910 Offset: 0x3298A11 VA: 0x3298910
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32999A0 Offset: 0x3299AA1 VA: 0x32999A0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x329AA50 Offset: 0x329AB51 VA: 0x329AA50
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x329BAF0 Offset: 0x329BBF1 VA: 0x329BAF0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x329CB90 Offset: 0x329CC91 VA: 0x329CB90
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x329DC30 Offset: 0x329DD31 VA: 0x329DC30
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x329ED00 Offset: 0x329EE01 VA: 0x329ED00
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x329FF00 Offset: 0x32A0001 VA: 0x329FF00
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A1140 Offset: 0x32A1241 VA: 0x32A1140
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A2250 Offset: 0x32A2351 VA: 0x32A2250
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A32F0 Offset: 0x32A33F1 VA: 0x32A32F0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A44C0 Offset: 0x32A45C1 VA: 0x32A44C0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A5570 Offset: 0x32A5671 VA: 0x32A5570
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A66E0 Offset: 0x32A67E1 VA: 0x32A66E0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A78A0 Offset: 0x32A79A1 VA: 0x32A78A0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31787E0 Offset: 0x31788E1 VA: 0x31787E0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3179B00 Offset: 0x3179C01 VA: 0x3179B00
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x317AC40 Offset: 0x317AD41 VA: 0x317AC40
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x317BCC0 Offset: 0x317BDC1 VA: 0x317BCC0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x317CD70 Offset: 0x317CE71 VA: 0x317CD70
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x317DED0 Offset: 0x317DFD1 VA: 0x317DED0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x317F040 Offset: 0x317F141 VA: 0x317F040
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31801B0 Offset: 0x31802B1 VA: 0x31801B0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3181280 Offset: 0x3181381 VA: 0x3181280
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3182360 Offset: 0x3182461 VA: 0x3182360
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3183680 Offset: 0x3183781 VA: 0x3183680
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3184970 Offset: 0x3184A71 VA: 0x3184970
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3185A80 Offset: 0x3185B81 VA: 0x3185A80
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3186BF0 Offset: 0x3186CF1 VA: 0x3186BF0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3187DB0 Offset: 0x3187EB1 VA: 0x3187DB0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3188EA0 Offset: 0x3188FA1 VA: 0x3188EA0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x318A0B0 Offset: 0x318A1B1 VA: 0x318A0B0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x318B270 Offset: 0x318B371 VA: 0x318B270
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x318C340 Offset: 0x318C441 VA: 0x318C340
	|-ReadOnlyCollection<Playable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x318D4A0 Offset: 0x318D5A1 VA: 0x318D4A0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x318E550 Offset: 0x318E651 VA: 0x318E550
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x318F5D0 Offset: 0x318F6D1 VA: 0x318F5D0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31906B0 Offset: 0x31907B1 VA: 0x31906B0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3191730 Offset: 0x3191831 VA: 0x3191730
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3192910 Offset: 0x3192A11 VA: 0x3192910
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3193B40 Offset: 0x3193C41 VA: 0x3193B40
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3194C50 Offset: 0x3194D51 VA: 0x3194C50
	|-ReadOnlyCollection<Rect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3195CF0 Offset: 0x3195DF1 VA: 0x3195CF0
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3196D90 Offset: 0x3196E91 VA: 0x3196D90
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31980E0 Offset: 0x31981E1 VA: 0x31980E0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3199230 Offset: 0x3199331 VA: 0x3199230
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x319A390 Offset: 0x319A491 VA: 0x319A390
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x319B500 Offset: 0x319B601 VA: 0x319B500
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x319C6C0 Offset: 0x319C7C1 VA: 0x319C6C0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E83790 Offset: 0x2E83891 VA: 0x2E83790
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E84950 Offset: 0x2E84A51 VA: 0x2E84950
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E85A20 Offset: 0x2E85B21 VA: 0x2E85A20
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E86BD0 Offset: 0x2E86CD1 VA: 0x2E86BD0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E87D60 Offset: 0x2E87E61 VA: 0x2E87D60
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E88ED0 Offset: 0x2E88FD1 VA: 0x2E88ED0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E8A040 Offset: 0x2E8A141 VA: 0x2E8A040
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E8B120 Offset: 0x2E8B221 VA: 0x2E8B120
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E8C1C0 Offset: 0x2E8C2C1 VA: 0x2E8C1C0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E8D260 Offset: 0x2E8D361 VA: 0x2E8D260
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E8E500 Offset: 0x2E8E601 VA: 0x2E8E500
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E8F6E0 Offset: 0x2E8F7E1 VA: 0x2E8F6E0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E90790 Offset: 0x2E90891 VA: 0x2E90790
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E91820 Offset: 0x2E91921 VA: 0x2E91820
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E92900 Offset: 0x2E92A01 VA: 0x2E92900
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E939D0 Offset: 0x2E93AD1 VA: 0x2E939D0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E94AA0 Offset: 0x2E94BA1 VA: 0x2E94AA0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E95DF0 Offset: 0x2E95EF1 VA: 0x2E95DF0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E96F20 Offset: 0x2E97021 VA: 0x2E96F20
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2E98090 Offset: 0x2E98191 VA: 0x2E98090
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE97F0 Offset: 0x2EE98F1 VA: 0x2EE97F0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EEAB50 Offset: 0x2EEAC51 VA: 0x2EEAB50
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EEBCA0 Offset: 0x2EEBDA1 VA: 0x2EEBCA0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EECD40 Offset: 0x2EECE41 VA: 0x2EECD40
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EEDE10 Offset: 0x2EEDF11 VA: 0x2EEDE10
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EEEEB0 Offset: 0x2EEEFB1 VA: 0x2EEEEB0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EEFF30 Offset: 0x2EF0031 VA: 0x2EEFF30
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF0FC0 Offset: 0x2EF10C1 VA: 0x2EF0FC0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF2180 Offset: 0x2EF2281 VA: 0x2EF2180
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF3380 Offset: 0x2EF3481 VA: 0x2EF3380
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF4550 Offset: 0x2EF4651 VA: 0x2EF4550
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF5610 Offset: 0x2EF5711 VA: 0x2EF5610
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF6780 Offset: 0x2EF6881 VA: 0x2EF6780
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF78F0 Offset: 0x2EF79F1 VA: 0x2EF78F0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF89A0 Offset: 0x2EF8AA1 VA: 0x2EF89A0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EF9A40 Offset: 0x2EF9B41 VA: 0x2EF9A40
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EFAC10 Offset: 0x2EFAD11 VA: 0x2EFAC10
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EFBDF0 Offset: 0x2EFBEF1 VA: 0x2EFBDF0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2EFCEC0 Offset: 0x2EFCFC1 VA: 0x2EFCEC0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32E6EF0 Offset: 0x32E6FF1 VA: 0x32E6EF0
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32E8090 Offset: 0x32E8191 VA: 0x32E8090
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32E9170 Offset: 0x32E9271 VA: 0x32E9170
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32EA2D0 Offset: 0x32EA3D1 VA: 0x32EA2D0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32EB380 Offset: 0x32EB481 VA: 0x32EB380
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32EC420 Offset: 0x32EC521 VA: 0x32EC420
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32ED5D0 Offset: 0x32ED6D1 VA: 0x32ED5D0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32EE6D0 Offset: 0x32EE7D1 VA: 0x32EE6D0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32EF750 Offset: 0x32EF851 VA: 0x32EF750
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F0830 Offset: 0x32F0931 VA: 0x32F0830
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F1990 Offset: 0x32F1A91 VA: 0x32F1990
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F2B00 Offset: 0x32F2C01 VA: 0x32F2B00
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F3D60 Offset: 0x32F3E61 VA: 0x32F3D60
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F4E60 Offset: 0x32F4F61 VA: 0x32F4E60
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F5EF0 Offset: 0x32F5FF1 VA: 0x32F5EF0
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F6F80 Offset: 0x32F7081 VA: 0x32F6F80
	|-ReadOnlyCollection<char>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F8030 Offset: 0x32F8131 VA: 0x32F8030
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32F90D0 Offset: 0x32F91D1 VA: 0x32F90D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32FA170 Offset: 0x32FA271 VA: 0x32FA170
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32FB1F0 Offset: 0x32FB2F1 VA: 0x32FB1F0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32FC280 Offset: 0x32FC381 VA: 0x32FC280
	|-ReadOnlyCollection<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32FD310 Offset: 0x32FD411 VA: 0x32FD310
	|-ReadOnlyCollection<short>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32FE3A0 Offset: 0x32FE4A1 VA: 0x32FE3A0
	|-ReadOnlyCollection<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32FF430 Offset: 0x32FF531 VA: 0x32FF430
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33004C0 Offset: 0x33005C1 VA: 0x33004C0
	|-ReadOnlyCollection<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3301570 Offset: 0x3301671 VA: 0x3301570
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33025F0 Offset: 0x33026F1 VA: 0x33025F0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33037B0 Offset: 0x33038B1 VA: 0x33037B0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33049B0 Offset: 0x3304AB1 VA: 0x33049B0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3305A80 Offset: 0x3305B81 VA: 0x3305A80
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3306BF0 Offset: 0x3306CF1 VA: 0x3306BF0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3307D10 Offset: 0x3307E11 VA: 0x3307D10
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3308E80 Offset: 0x3308F81 VA: 0x3308E80
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x330A030 Offset: 0x330A131 VA: 0x330A030
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32846B0 Offset: 0x32847B1 VA: 0x32846B0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3285930 Offset: 0x3285A31 VA: 0x3285930
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3286B20 Offset: 0x3286C21 VA: 0x3286B20
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3287C40 Offset: 0x3287D41 VA: 0x3287C40
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3288DB0 Offset: 0x3288EB1 VA: 0x3288DB0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3289F60 Offset: 0x328A061 VA: 0x3289F60
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x328B080 Offset: 0x328B181 VA: 0x328B080
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x328C160 Offset: 0x328C261 VA: 0x328C160
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x328D210 Offset: 0x328D311 VA: 0x328D210
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x328E2B0 Offset: 0x328E3B1 VA: 0x328E2B0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x328F410 Offset: 0x328F511 VA: 0x328F410
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3290460 Offset: 0x3290561 VA: 0x3290460
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3291520 Offset: 0x3291621 VA: 0x3291520
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32925D0 Offset: 0x32926D1 VA: 0x32925D0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3293650 Offset: 0x3293751 VA: 0x3293650
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32946E0 Offset: 0x32947E1 VA: 0x32946E0
	|-ReadOnlyCollection<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3295770 Offset: 0x3295871 VA: 0x3295770
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3296800 Offset: 0x3296901 VA: 0x3296800
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3297890 Offset: 0x3297991 VA: 0x3297890
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3298920 Offset: 0x3298A21 VA: 0x3298920
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32999B0 Offset: 0x3299AB1 VA: 0x32999B0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x329AA60 Offset: 0x329AB61 VA: 0x329AA60
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x329BB00 Offset: 0x329BC01 VA: 0x329BB00
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x329CBA0 Offset: 0x329CCA1 VA: 0x329CBA0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x329DC40 Offset: 0x329DD41 VA: 0x329DC40
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x329ED10 Offset: 0x329EE11 VA: 0x329ED10
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x329FF10 Offset: 0x32A0011 VA: 0x329FF10
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A1150 Offset: 0x32A1251 VA: 0x32A1150
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A2260 Offset: 0x32A2361 VA: 0x32A2260
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A3300 Offset: 0x32A3401 VA: 0x32A3300
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A44D0 Offset: 0x32A45D1 VA: 0x32A44D0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A5580 Offset: 0x32A5681 VA: 0x32A5580
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A66F0 Offset: 0x32A67F1 VA: 0x32A66F0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A78B0 Offset: 0x32A79B1 VA: 0x32A78B0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31787F0 Offset: 0x31788F1 VA: 0x31787F0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3179B10 Offset: 0x3179C11 VA: 0x3179B10
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.get_Item
	|
	|-RVA: 0x317AC50 Offset: 0x317AD51 VA: 0x317AC50
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.get_Item
	|
	|-RVA: 0x317BCD0 Offset: 0x317BDD1 VA: 0x317BCD0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x317CD80 Offset: 0x317CE81 VA: 0x317CD80
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|
	|-RVA: 0x317DEE0 Offset: 0x317DFE1 VA: 0x317DEE0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.get_Item
	|
	|-RVA: 0x317F050 Offset: 0x317F151 VA: 0x317F050
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31801C0 Offset: 0x31802C1 VA: 0x31801C0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3181290 Offset: 0x3181391 VA: 0x3181290
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3182370 Offset: 0x3182471 VA: 0x3182370
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3183690 Offset: 0x3183791 VA: 0x3183690
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3184980 Offset: 0x3184A81 VA: 0x3184980
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3185A90 Offset: 0x3185B91 VA: 0x3185A90
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3186C00 Offset: 0x3186D01 VA: 0x3186C00
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3187DC0 Offset: 0x3187EC1 VA: 0x3187DC0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3188EB0 Offset: 0x3188FB1 VA: 0x3188EB0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.get_Item
	|
	|-RVA: 0x318A0C0 Offset: 0x318A1C1 VA: 0x318A0C0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x318B280 Offset: 0x318B381 VA: 0x318B280
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x318C350 Offset: 0x318C451 VA: 0x318C350
	|-ReadOnlyCollection<Playable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x318D4B0 Offset: 0x318D5B1 VA: 0x318D4B0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_Item
	|
	|-RVA: 0x318E560 Offset: 0x318E661 VA: 0x318E560
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.get_Item
	|
	|-RVA: 0x318F5E0 Offset: 0x318F6E1 VA: 0x318F5E0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31906C0 Offset: 0x31907C1 VA: 0x31906C0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3191740 Offset: 0x3191841 VA: 0x3191740
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3192920 Offset: 0x3192A21 VA: 0x3192920
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3193B50 Offset: 0x3193C51 VA: 0x3193B50
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3194C60 Offset: 0x3194D61 VA: 0x3194C60
	|-ReadOnlyCollection<Rect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3195D00 Offset: 0x3195E01 VA: 0x3195D00
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3196DA0 Offset: 0x3196EA1 VA: 0x3196DA0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31980F0 Offset: 0x31981F1 VA: 0x31980F0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3199240 Offset: 0x3199341 VA: 0x3199240
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.get_Item
	|
	|-RVA: 0x319A3A0 Offset: 0x319A4A1 VA: 0x319A3A0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x319B510 Offset: 0x319B611 VA: 0x319B510
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x319C6D0 Offset: 0x319C7D1 VA: 0x319C6D0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E837A0 Offset: 0x2E838A1 VA: 0x2E837A0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E84960 Offset: 0x2E84A61 VA: 0x2E84960
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E85A30 Offset: 0x2E85B31 VA: 0x2E85A30
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E86BE0 Offset: 0x2E86CE1 VA: 0x2E86BE0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E87D70 Offset: 0x2E87E71 VA: 0x2E87D70
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E88EE0 Offset: 0x2E88FE1 VA: 0x2E88EE0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E8A050 Offset: 0x2E8A151 VA: 0x2E8A050
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E8B130 Offset: 0x2E8B231 VA: 0x2E8B130
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E8C1D0 Offset: 0x2E8C2D1 VA: 0x2E8C1D0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E8D270 Offset: 0x2E8D371 VA: 0x2E8D270
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E8E510 Offset: 0x2E8E611 VA: 0x2E8E510
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E8F6F0 Offset: 0x2E8F7F1 VA: 0x2E8F6F0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E907A0 Offset: 0x2E908A1 VA: 0x2E907A0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E91830 Offset: 0x2E91931 VA: 0x2E91830
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E92910 Offset: 0x2E92A11 VA: 0x2E92910
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E939E0 Offset: 0x2E93AE1 VA: 0x2E939E0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E94AB0 Offset: 0x2E94BB1 VA: 0x2E94AB0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E95E00 Offset: 0x2E95F01 VA: 0x2E95E00
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E96F30 Offset: 0x2E97031 VA: 0x2E96F30
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2E980A0 Offset: 0x2E981A1 VA: 0x2E980A0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE98F0 Offset: 0x2EE99F1 VA: 0x2EE98F0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EEAC80 Offset: 0x2EEAD81 VA: 0x2EEAC80
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EEBD90 Offset: 0x2EEBE91 VA: 0x2EEBD90
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EECE30 Offset: 0x2EECF31 VA: 0x2EECE30
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EEDF00 Offset: 0x2EEE001 VA: 0x2EEDF00
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EEEFA0 Offset: 0x2EEF0A1 VA: 0x2EEEFA0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF0020 Offset: 0x2EF0121 VA: 0x2EF0020
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF10B0 Offset: 0x2EF11B1 VA: 0x2EF10B0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF2280 Offset: 0x2EF2381 VA: 0x2EF2280
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF3480 Offset: 0x2EF3581 VA: 0x2EF3480
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF4650 Offset: 0x2EF4751 VA: 0x2EF4650
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF5700 Offset: 0x2EF5801 VA: 0x2EF5700
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF6880 Offset: 0x2EF6981 VA: 0x2EF6880
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF79F0 Offset: 0x2EF7AF1 VA: 0x2EF79F0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF8A90 Offset: 0x2EF8B91 VA: 0x2EF8A90
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EF9B30 Offset: 0x2EF9C31 VA: 0x2EF9B30
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EFAD10 Offset: 0x2EFAE11 VA: 0x2EFAD10
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EFBEF0 Offset: 0x2EFBFF1 VA: 0x2EFBEF0
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2EFCFB0 Offset: 0x2EFD0B1 VA: 0x2EFCFB0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32E7000 Offset: 0x32E7101 VA: 0x32E7000
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32E8190 Offset: 0x32E8291 VA: 0x32E8190
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32E9260 Offset: 0x32E9361 VA: 0x32E9260
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32EA3D0 Offset: 0x32EA4D1 VA: 0x32EA3D0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32EB470 Offset: 0x32EB571 VA: 0x32EB470
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32EC510 Offset: 0x32EC611 VA: 0x32EC510
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32ED6D0 Offset: 0x32ED7D1 VA: 0x32ED6D0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32EE7C0 Offset: 0x32EE8C1 VA: 0x32EE7C0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32EF840 Offset: 0x32EF941 VA: 0x32EF840
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F0920 Offset: 0x32F0A21 VA: 0x32F0920
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F1A90 Offset: 0x32F1B91 VA: 0x32F1A90
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F2C00 Offset: 0x32F2D01 VA: 0x32F2C00
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F3E70 Offset: 0x32F3F71 VA: 0x32F3E70
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F4F50 Offset: 0x32F5051 VA: 0x32F4F50
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F5FE0 Offset: 0x32F60E1 VA: 0x32F5FE0
	|-ReadOnlyCollection<byte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F7070 Offset: 0x32F7171 VA: 0x32F7070
	|-ReadOnlyCollection<char>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F8120 Offset: 0x32F8221 VA: 0x32F8120
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32F91C0 Offset: 0x32F92C1 VA: 0x32F91C0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32FA260 Offset: 0x32FA361 VA: 0x32FA260
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32FB2E0 Offset: 0x32FB3E1 VA: 0x32FB2E0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32FC370 Offset: 0x32FC471 VA: 0x32FC370
	|-ReadOnlyCollection<double>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32FD400 Offset: 0x32FD501 VA: 0x32FD400
	|-ReadOnlyCollection<short>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32FE490 Offset: 0x32FE591 VA: 0x32FE490
	|-ReadOnlyCollection<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32FF520 Offset: 0x32FF621 VA: 0x32FF520
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33005B0 Offset: 0x33006B1 VA: 0x33005B0
	|-ReadOnlyCollection<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3301660 Offset: 0x3301761 VA: 0x3301660
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33026E0 Offset: 0x33027E1 VA: 0x33026E0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33038B0 Offset: 0x33039B1 VA: 0x33038B0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3304AB0 Offset: 0x3304BB1 VA: 0x3304AB0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3305B70 Offset: 0x3305C71 VA: 0x3305B70
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3306CF0 Offset: 0x3306DF1 VA: 0x3306CF0
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3307E00 Offset: 0x3307F01 VA: 0x3307E00
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3308F80 Offset: 0x3309081 VA: 0x3308F80
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x330A130 Offset: 0x330A231 VA: 0x330A130
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32847A0 Offset: 0x32848A1 VA: 0x32847A0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3285A40 Offset: 0x3285B41 VA: 0x3285A40
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3286C20 Offset: 0x3286D21 VA: 0x3286C20
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3287D30 Offset: 0x3287E31 VA: 0x3287D30
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3288EB0 Offset: 0x3288FB1 VA: 0x3288EB0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x328A060 Offset: 0x328A161 VA: 0x328A060
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x328B170 Offset: 0x328B271 VA: 0x328B170
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x328C250 Offset: 0x328C351 VA: 0x328C250
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x328D300 Offset: 0x328D401 VA: 0x328D300
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x328E3A0 Offset: 0x328E4A1 VA: 0x328E3A0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x328F510 Offset: 0x328F611 VA: 0x328F510
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3290510 Offset: 0x3290611 VA: 0x3290510
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3291620 Offset: 0x3291721 VA: 0x3291620
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32926C0 Offset: 0x32927C1 VA: 0x32926C0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3293740 Offset: 0x3293841 VA: 0x3293740
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32947D0 Offset: 0x32948D1 VA: 0x32947D0
	|-ReadOnlyCollection<float>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3295860 Offset: 0x3295961 VA: 0x3295860
	|-ReadOnlyCollection<ushort>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32968F0 Offset: 0x32969F1 VA: 0x32968F0
	|-ReadOnlyCollection<uint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3297980 Offset: 0x3297A81 VA: 0x3297980
	|-ReadOnlyCollection<ulong>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3298A10 Offset: 0x3298B11 VA: 0x3298A10
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3299AA0 Offset: 0x3299BA1 VA: 0x3299AA0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x329AB50 Offset: 0x329AC51 VA: 0x329AB50
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x329BBF0 Offset: 0x329BCF1 VA: 0x329BBF0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x329CC90 Offset: 0x329CD91 VA: 0x329CC90
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x329DD30 Offset: 0x329DE31 VA: 0x329DD30
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x329EE00 Offset: 0x329EF01 VA: 0x329EE00
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A0020 Offset: 0x32A0121 VA: 0x32A0020
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A1260 Offset: 0x32A1361 VA: 0x32A1260
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A2350 Offset: 0x32A2451 VA: 0x32A2350
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A33F0 Offset: 0x32A34F1 VA: 0x32A33F0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A45D0 Offset: 0x32A46D1 VA: 0x32A45D0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A5670 Offset: 0x32A5771 VA: 0x32A5670
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A67F0 Offset: 0x32A68F1 VA: 0x32A67F0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A79B0 Offset: 0x32A7AB1 VA: 0x32A79B0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31788E0 Offset: 0x31789E1 VA: 0x31788E0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3179C30 Offset: 0x3179D31 VA: 0x3179C30
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.set_Item
	|
	|-RVA: 0x317AD40 Offset: 0x317AE41 VA: 0x317AD40
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.set_Item
	|
	|-RVA: 0x317BDC0 Offset: 0x317BEC1 VA: 0x317BDC0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x317CE70 Offset: 0x317CF71 VA: 0x317CE70
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|
	|-RVA: 0x317DFE0 Offset: 0x317E0E1 VA: 0x317DFE0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.set_Item
	|
	|-RVA: 0x317F150 Offset: 0x317F251 VA: 0x317F150
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31802C0 Offset: 0x31803C1 VA: 0x31802C0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3181380 Offset: 0x3181481 VA: 0x3181380
	|-ReadOnlyCollection<Color32>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3182460 Offset: 0x3182561 VA: 0x3182460
	|-ReadOnlyCollection<Color>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31837B0 Offset: 0x31838B1 VA: 0x31837B0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3184A90 Offset: 0x3184B91 VA: 0x3184A90
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3185B80 Offset: 0x3185C81 VA: 0x3185B80
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3186D00 Offset: 0x3186E01 VA: 0x3186D00
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3187EC0 Offset: 0x3187FC1 VA: 0x3187EC0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3188FA0 Offset: 0x31890A1 VA: 0x3188FA0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.set_Item
	|
	|-RVA: 0x318A1D0 Offset: 0x318A2D1 VA: 0x318A1D0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x318B380 Offset: 0x318B481 VA: 0x318B380
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x318C440 Offset: 0x318C541 VA: 0x318C440
	|-ReadOnlyCollection<Playable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x318D5B0 Offset: 0x318D6B1 VA: 0x318D5B0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.set_Item
	|
	|-RVA: 0x318E650 Offset: 0x318E751 VA: 0x318E650
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.set_Item
	|
	|-RVA: 0x318F6D0 Offset: 0x318F7D1 VA: 0x318F6D0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31907B0 Offset: 0x31908B1 VA: 0x31907B0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3191830 Offset: 0x3191931 VA: 0x3191830
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3192A20 Offset: 0x3192B21 VA: 0x3192A20
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3193C60 Offset: 0x3193D61 VA: 0x3193C60
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3194D50 Offset: 0x3194E51 VA: 0x3194D50
	|-ReadOnlyCollection<Rect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3195DF0 Offset: 0x3195EF1 VA: 0x3195DF0
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3196E90 Offset: 0x3196F91 VA: 0x3196E90
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3198220 Offset: 0x3198321 VA: 0x3198220
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3199330 Offset: 0x3199431 VA: 0x3199330
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.set_Item
	|
	|-RVA: 0x319A4A0 Offset: 0x319A5A1 VA: 0x319A4A0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x319B610 Offset: 0x319B711 VA: 0x319B610
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x319C7D0 Offset: 0x319C8D1 VA: 0x319C7D0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E838A0 Offset: 0x2E839A1 VA: 0x2E838A0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E84A60 Offset: 0x2E84B61 VA: 0x2E84A60
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E85B20 Offset: 0x2E85C21 VA: 0x2E85B20
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E86CE0 Offset: 0x2E86DE1 VA: 0x2E86CE0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E87E70 Offset: 0x2E87F71 VA: 0x2E87E70
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E88FE0 Offset: 0x2E890E1 VA: 0x2E88FE0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E8A150 Offset: 0x2E8A251 VA: 0x2E8A150
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E8B220 Offset: 0x2E8B321 VA: 0x2E8B220
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E8C2C0 Offset: 0x2E8C3C1 VA: 0x2E8C2C0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E8D360 Offset: 0x2E8D461 VA: 0x2E8D360
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E8E630 Offset: 0x2E8E731 VA: 0x2E8E630
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E8F7F0 Offset: 0x2E8F8F1 VA: 0x2E8F7F0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E90890 Offset: 0x2E90991 VA: 0x2E90890
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E91920 Offset: 0x2E91A21 VA: 0x2E91920
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E92A00 Offset: 0x2E92B01 VA: 0x2E92A00
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E93AD0 Offset: 0x2E93BD1 VA: 0x2E93AD0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E94BA0 Offset: 0x2E94CA1 VA: 0x2E94BA0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E95F30 Offset: 0x2E96031 VA: 0x2E95F30
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E97020 Offset: 0x2E97121 VA: 0x2E97020
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2E981A0 Offset: 0x2E982A1 VA: 0x2E981A0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9900 Offset: 0x2EE9A01 VA: 0x2EE9900
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2EEAC90 Offset: 0x2EEAD91 VA: 0x2EEAC90
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.Add
	|
	|-RVA: 0x2EEBDA0 Offset: 0x2EEBEA1 VA: 0x2EEBDA0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.Add
	|
	|-RVA: 0x2EECE40 Offset: 0x2EECF41 VA: 0x2EECE40
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.Add
	|
	|-RVA: 0x2EEDF10 Offset: 0x2EEE011 VA: 0x2EEDF10
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Add
	|
	|-RVA: 0x2EEEFB0 Offset: 0x2EEF0B1 VA: 0x2EEEFB0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF0030 Offset: 0x2EF0131 VA: 0x2EF0030
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF10C0 Offset: 0x2EF11C1 VA: 0x2EF10C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF2290 Offset: 0x2EF2391 VA: 0x2EF2290
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF3490 Offset: 0x2EF3591 VA: 0x2EF3490
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF4660 Offset: 0x2EF4761 VA: 0x2EF4660
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF5710 Offset: 0x2EF5811 VA: 0x2EF5710
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF6890 Offset: 0x2EF6991 VA: 0x2EF6890
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF7A00 Offset: 0x2EF7B01 VA: 0x2EF7A00
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF8AA0 Offset: 0x2EF8BA1 VA: 0x2EF8AA0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.Add
	|
	|-RVA: 0x2EF9B40 Offset: 0x2EF9C41 VA: 0x2EF9B40
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.Add
	|
	|-RVA: 0x2EFAD20 Offset: 0x2EFAE21 VA: 0x2EFAD20
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.Add
	|
	|-RVA: 0x2EFBF00 Offset: 0x2EFC001 VA: 0x2EFBF00
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.Add
	|
	|-RVA: 0x2EFCFC0 Offset: 0x2EFD0C1 VA: 0x2EFCFC0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Add
	|
	|-RVA: 0x32E7010 Offset: 0x32E7111 VA: 0x32E7010
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.Add
	|
	|-RVA: 0x32E81A0 Offset: 0x32E82A1 VA: 0x32E81A0
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.Add
	|
	|-RVA: 0x32E9270 Offset: 0x32E9371 VA: 0x32E9270
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.Add
	|
	|-RVA: 0x32EA3E0 Offset: 0x32EA4E1 VA: 0x32EA3E0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.Add
	|
	|-RVA: 0x32EB480 Offset: 0x32EB581 VA: 0x32EB480
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Add
	|
	|-RVA: 0x32EC520 Offset: 0x32EC621 VA: 0x32EC520
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.Add
	|
	|-RVA: 0x32ED6E0 Offset: 0x32ED7E1 VA: 0x32ED6E0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.Add
	|
	|-RVA: 0x32EE7D0 Offset: 0x32EE8D1 VA: 0x32EE7D0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.Add
	|
	|-RVA: 0x32EF850 Offset: 0x32EF951 VA: 0x32EF850
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.Add
	|
	|-RVA: 0x32F0930 Offset: 0x32F0A31 VA: 0x32F0930
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.Add
	|
	|-RVA: 0x32F1AA0 Offset: 0x32F1BA1 VA: 0x32F1AA0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x32F2C10 Offset: 0x32F2D11 VA: 0x32F2C10
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.Add
	|
	|-RVA: 0x32F3E80 Offset: 0x32F3F81 VA: 0x32F3E80
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.Add
	|
	|-RVA: 0x32F4F60 Offset: 0x32F5061 VA: 0x32F4F60
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x32F5FF0 Offset: 0x32F60F1 VA: 0x32F5FF0
	|-ReadOnlyCollection<byte>.System.Collections.IList.Add
	|
	|-RVA: 0x32F7080 Offset: 0x32F7181 VA: 0x32F7080
	|-ReadOnlyCollection<char>.System.Collections.IList.Add
	|
	|-RVA: 0x32F8130 Offset: 0x32F8231 VA: 0x32F8130
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x32F91D0 Offset: 0x32F92D1 VA: 0x32F91D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x32FA270 Offset: 0x32FA371 VA: 0x32FA270
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x32FB2F0 Offset: 0x32FB3F1 VA: 0x32FB2F0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Add
	|
	|-RVA: 0x32FC380 Offset: 0x32FC481 VA: 0x32FC380
	|-ReadOnlyCollection<double>.System.Collections.IList.Add
	|
	|-RVA: 0x32FD410 Offset: 0x32FD511 VA: 0x32FD410
	|-ReadOnlyCollection<short>.System.Collections.IList.Add
	|
	|-RVA: 0x32FE4A0 Offset: 0x32FE5A1 VA: 0x32FE4A0
	|-ReadOnlyCollection<int>.System.Collections.IList.Add
	|
	|-RVA: 0x32FF530 Offset: 0x32FF631 VA: 0x32FF530
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x33005C0 Offset: 0x33006C1 VA: 0x33005C0
	|-ReadOnlyCollection<long>.System.Collections.IList.Add
	|
	|-RVA: 0x3301670 Offset: 0x3301771 VA: 0x3301670
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x33026F0 Offset: 0x33027F1 VA: 0x33026F0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x33038C0 Offset: 0x33039C1 VA: 0x33038C0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.Add
	|
	|-RVA: 0x3304AC0 Offset: 0x3304BC1 VA: 0x3304AC0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.Add
	|
	|-RVA: 0x3305B80 Offset: 0x3305C81 VA: 0x3305B80
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.Add
	|
	|-RVA: 0x3306D00 Offset: 0x3306E01 VA: 0x3306D00
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.Add
	|
	|-RVA: 0x3307E10 Offset: 0x3307F11 VA: 0x3307E10
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.Add
	|
	|-RVA: 0x3308F90 Offset: 0x3309091 VA: 0x3308F90
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.Add
	|
	|-RVA: 0x330A140 Offset: 0x330A241 VA: 0x330A140
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.Add
	|
	|-RVA: 0x32847B0 Offset: 0x32848B1 VA: 0x32847B0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.Add
	|
	|-RVA: 0x3285A50 Offset: 0x3285B51 VA: 0x3285A50
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.Add
	|
	|-RVA: 0x3286C30 Offset: 0x3286D31 VA: 0x3286C30
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.Add
	|
	|-RVA: 0x3287D40 Offset: 0x3287E41 VA: 0x3287D40
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.Add
	|
	|-RVA: 0x3288EC0 Offset: 0x3288FC1 VA: 0x3288EC0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.Add
	|
	|-RVA: 0x328A070 Offset: 0x328A171 VA: 0x328A070
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.Add
	|
	|-RVA: 0x328B180 Offset: 0x328B281 VA: 0x328B180
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.Add
	|
	|-RVA: 0x328C260 Offset: 0x328C361 VA: 0x328C260
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.Add
	|
	|-RVA: 0x328D310 Offset: 0x328D411 VA: 0x328D310
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.Add
	|
	|-RVA: 0x328E3B0 Offset: 0x328E4B1 VA: 0x328E3B0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.Add
	|
	|-RVA: 0x328F520 Offset: 0x328F621 VA: 0x328F520
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.Add
	|
	|-RVA: 0x3290520 Offset: 0x3290621 VA: 0x3290520
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x3291630 Offset: 0x3291731 VA: 0x3291630
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x32926D0 Offset: 0x32927D1 VA: 0x32926D0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x3293750 Offset: 0x3293851 VA: 0x3293750
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Add
	|
	|-RVA: 0x32947E0 Offset: 0x32948E1 VA: 0x32947E0
	|-ReadOnlyCollection<float>.System.Collections.IList.Add
	|
	|-RVA: 0x3295870 Offset: 0x3295971 VA: 0x3295870
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Add
	|
	|-RVA: 0x3296900 Offset: 0x3296A01 VA: 0x3296900
	|-ReadOnlyCollection<uint>.System.Collections.IList.Add
	|
	|-RVA: 0x3297990 Offset: 0x3297A91 VA: 0x3297990
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Add
	|
	|-RVA: 0x3298A20 Offset: 0x3298B21 VA: 0x3298A20
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x3299AB0 Offset: 0x3299BB1 VA: 0x3299AB0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x329AB60 Offset: 0x329AC61 VA: 0x329AB60
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x329BC00 Offset: 0x329BD01 VA: 0x329BC00
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x329CCA0 Offset: 0x329CDA1 VA: 0x329CCA0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x329DD40 Offset: 0x329DE41 VA: 0x329DD40
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x329EE10 Offset: 0x329EF11 VA: 0x329EE10
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x32A0030 Offset: 0x32A0131 VA: 0x32A0030
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x32A1270 Offset: 0x32A1371 VA: 0x32A1270
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Add
	|
	|-RVA: 0x32A2360 Offset: 0x32A2461 VA: 0x32A2360
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.Add
	|
	|-RVA: 0x32A3400 Offset: 0x32A3501 VA: 0x32A3400
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Add
	|
	|-RVA: 0x32A45E0 Offset: 0x32A46E1 VA: 0x32A45E0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.Add
	|
	|-RVA: 0x32A5680 Offset: 0x32A5781 VA: 0x32A5680
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.Add
	|
	|-RVA: 0x32A6800 Offset: 0x32A6901 VA: 0x32A6800
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Add
	|
	|-RVA: 0x32A79C0 Offset: 0x32A7AC1 VA: 0x32A79C0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Add
	|
	|-RVA: 0x31788F0 Offset: 0x31789F1 VA: 0x31788F0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Add
	|
	|-RVA: 0x3179C40 Offset: 0x3179D41 VA: 0x3179C40
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Add
	|
	|-RVA: 0x317AD50 Offset: 0x317AE51 VA: 0x317AD50
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Add
	|
	|-RVA: 0x317BDD0 Offset: 0x317BED1 VA: 0x317BDD0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x317CE80 Offset: 0x317CF81 VA: 0x317CE80
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|
	|-RVA: 0x317DFF0 Offset: 0x317E0F1 VA: 0x317DFF0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Add
	|
	|-RVA: 0x317F160 Offset: 0x317F261 VA: 0x317F160
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Add
	|
	|-RVA: 0x31802D0 Offset: 0x31803D1 VA: 0x31802D0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3181390 Offset: 0x3181491 VA: 0x3181390
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Add
	|
	|-RVA: 0x3182470 Offset: 0x3182571 VA: 0x3182470
	|-ReadOnlyCollection<Color>.System.Collections.IList.Add
	|
	|-RVA: 0x31837C0 Offset: 0x31838C1 VA: 0x31837C0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Add
	|
	|-RVA: 0x3184AA0 Offset: 0x3184BA1 VA: 0x3184AA0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Add
	|
	|-RVA: 0x3185B90 Offset: 0x3185C91 VA: 0x3185B90
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.Add
	|
	|-RVA: 0x3186D10 Offset: 0x3186E11 VA: 0x3186D10
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.Add
	|
	|-RVA: 0x3187ED0 Offset: 0x3187FD1 VA: 0x3187ED0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.Add
	|
	|-RVA: 0x3188FB0 Offset: 0x31890B1 VA: 0x3188FB0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.Add
	|
	|-RVA: 0x318A1E0 Offset: 0x318A2E1 VA: 0x318A1E0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Add
	|
	|-RVA: 0x318B390 Offset: 0x318B491 VA: 0x318B390
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Add
	|
	|-RVA: 0x318C450 Offset: 0x318C551 VA: 0x318C450
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Add
	|
	|-RVA: 0x318D5C0 Offset: 0x318D6C1 VA: 0x318D5C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Add
	|
	|-RVA: 0x318E660 Offset: 0x318E761 VA: 0x318E660
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.Add
	|
	|-RVA: 0x318F6E0 Offset: 0x318F7E1 VA: 0x318F6E0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Add
	|
	|-RVA: 0x31907C0 Offset: 0x31908C1 VA: 0x31907C0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Add
	|
	|-RVA: 0x3191840 Offset: 0x3191941 VA: 0x3191840
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3192A30 Offset: 0x3192B31 VA: 0x3192A30
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Add
	|
	|-RVA: 0x3193C70 Offset: 0x3193D71 VA: 0x3193C70
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Add
	|
	|-RVA: 0x3194D60 Offset: 0x3194E61 VA: 0x3194D60
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Add
	|
	|-RVA: 0x3195E00 Offset: 0x3195F01 VA: 0x3195E00
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3196EA0 Offset: 0x3196FA1 VA: 0x3196EA0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x3198230 Offset: 0x3198331 VA: 0x3198230
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Add
	|
	|-RVA: 0x3199340 Offset: 0x3199441 VA: 0x3199340
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Add
	|
	|-RVA: 0x319A4B0 Offset: 0x319A5B1 VA: 0x319A4B0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x319B620 Offset: 0x319B721 VA: 0x319B620
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Add
	|
	|-RVA: 0x319C7E0 Offset: 0x319C8E1 VA: 0x319C7E0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Add
	|
	|-RVA: 0x2E838B0 Offset: 0x2E839B1 VA: 0x2E838B0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2E84A70 Offset: 0x2E84B71 VA: 0x2E84A70
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Add
	|
	|-RVA: 0x2E85B30 Offset: 0x2E85C31 VA: 0x2E85B30
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Add
	|
	|-RVA: 0x2E86CF0 Offset: 0x2E86DF1 VA: 0x2E86CF0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2E87E80 Offset: 0x2E87F81 VA: 0x2E87E80
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Add
	|
	|-RVA: 0x2E88FF0 Offset: 0x2E890F1 VA: 0x2E88FF0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2E8A160 Offset: 0x2E8A261 VA: 0x2E8A160
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x2E8B230 Offset: 0x2E8B331 VA: 0x2E8B230
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2E8C2D0 Offset: 0x2E8C3D1 VA: 0x2E8C2D0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Add
	|
	|-RVA: 0x2E8D370 Offset: 0x2E8D471 VA: 0x2E8D370
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2E8E640 Offset: 0x2E8E741 VA: 0x2E8E640
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Add
	|
	|-RVA: 0x2E8F800 Offset: 0x2E8F901 VA: 0x2E8F800
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x2E908A0 Offset: 0x2E909A1 VA: 0x2E908A0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Add
	|
	|-RVA: 0x2E91930 Offset: 0x2E91A31 VA: 0x2E91930
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Add
	|
	|-RVA: 0x2E92A10 Offset: 0x2E92B11 VA: 0x2E92A10
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Add
	|
	|-RVA: 0x2E93AE0 Offset: 0x2E93BE1 VA: 0x2E93AE0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.Add
	|
	|-RVA: 0x2E94BB0 Offset: 0x2E94CB1 VA: 0x2E94BB0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Add
	|
	|-RVA: 0x2E95F40 Offset: 0x2E96041 VA: 0x2E95F40
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.Add
	|
	|-RVA: 0x2E97030 Offset: 0x2E97131 VA: 0x2E97030
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.Add
	|
	|-RVA: 0x2E981B0 Offset: 0x2E982B1 VA: 0x2E981B0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9920 Offset: 0x2EE9A21 VA: 0x2EE9920
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EEACB0 Offset: 0x2EEADB1 VA: 0x2EEACB0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EEBDC0 Offset: 0x2EEBEC1 VA: 0x2EEBDC0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EECE60 Offset: 0x2EECF61 VA: 0x2EECE60
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EEDF30 Offset: 0x2EEE031 VA: 0x2EEDF30
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EEEFD0 Offset: 0x2EEF0D1 VA: 0x2EEEFD0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF0050 Offset: 0x2EF0151 VA: 0x2EF0050
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF10E0 Offset: 0x2EF11E1 VA: 0x2EF10E0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF22B0 Offset: 0x2EF23B1 VA: 0x2EF22B0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF34B0 Offset: 0x2EF35B1 VA: 0x2EF34B0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF4680 Offset: 0x2EF4781 VA: 0x2EF4680
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF5730 Offset: 0x2EF5831 VA: 0x2EF5730
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF68B0 Offset: 0x2EF69B1 VA: 0x2EF68B0
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF7A20 Offset: 0x2EF7B21 VA: 0x2EF7A20
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF8AC0 Offset: 0x2EF8BC1 VA: 0x2EF8AC0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EF9B60 Offset: 0x2EF9C61 VA: 0x2EF9B60
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EFAD40 Offset: 0x2EFAE41 VA: 0x2EFAD40
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EFBF20 Offset: 0x2EFC021 VA: 0x2EFBF20
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2EFCFE0 Offset: 0x2EFD0E1 VA: 0x2EFCFE0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Clear
	|
	|-RVA: 0x32E7030 Offset: 0x32E7131 VA: 0x32E7030
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.Clear
	|
	|-RVA: 0x32E81C0 Offset: 0x32E82C1 VA: 0x32E81C0
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.Clear
	|
	|-RVA: 0x32E9290 Offset: 0x32E9391 VA: 0x32E9290
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.Clear
	|
	|-RVA: 0x32EA400 Offset: 0x32EA501 VA: 0x32EA400
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.Clear
	|
	|-RVA: 0x32EB4A0 Offset: 0x32EB5A1 VA: 0x32EB4A0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Clear
	|
	|-RVA: 0x32EC540 Offset: 0x32EC641 VA: 0x32EC540
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.Clear
	|
	|-RVA: 0x32ED700 Offset: 0x32ED801 VA: 0x32ED700
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.Clear
	|
	|-RVA: 0x32EE7F0 Offset: 0x32EE8F1 VA: 0x32EE7F0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.Clear
	|
	|-RVA: 0x32EF870 Offset: 0x32EF971 VA: 0x32EF870
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F0950 Offset: 0x32F0A51 VA: 0x32F0950
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F1AC0 Offset: 0x32F1BC1 VA: 0x32F1AC0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F2C30 Offset: 0x32F2D31 VA: 0x32F2C30
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F3EA0 Offset: 0x32F3FA1 VA: 0x32F3EA0
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F4F80 Offset: 0x32F5081 VA: 0x32F4F80
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F6010 Offset: 0x32F6111 VA: 0x32F6010
	|-ReadOnlyCollection<byte>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F70A0 Offset: 0x32F71A1 VA: 0x32F70A0
	|-ReadOnlyCollection<char>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F8150 Offset: 0x32F8251 VA: 0x32F8150
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x32F91F0 Offset: 0x32F92F1 VA: 0x32F91F0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x32FA290 Offset: 0x32FA391 VA: 0x32FA290
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x32FB310 Offset: 0x32FB411 VA: 0x32FB310
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Clear
	|
	|-RVA: 0x32FC3A0 Offset: 0x32FC4A1 VA: 0x32FC3A0
	|-ReadOnlyCollection<double>.System.Collections.IList.Clear
	|
	|-RVA: 0x32FD430 Offset: 0x32FD531 VA: 0x32FD430
	|-ReadOnlyCollection<short>.System.Collections.IList.Clear
	|
	|-RVA: 0x32FE4C0 Offset: 0x32FE5C1 VA: 0x32FE4C0
	|-ReadOnlyCollection<int>.System.Collections.IList.Clear
	|
	|-RVA: 0x32FF550 Offset: 0x32FF651 VA: 0x32FF550
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Clear
	|
	|-RVA: 0x33005E0 Offset: 0x33006E1 VA: 0x33005E0
	|-ReadOnlyCollection<long>.System.Collections.IList.Clear
	|
	|-RVA: 0x3301690 Offset: 0x3301791 VA: 0x3301690
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3302710 Offset: 0x3302811 VA: 0x3302710
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.Clear
	|
	|-RVA: 0x33038E0 Offset: 0x33039E1 VA: 0x33038E0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3304AE0 Offset: 0x3304BE1 VA: 0x3304AE0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3305BA0 Offset: 0x3305CA1 VA: 0x3305BA0
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3306D20 Offset: 0x3306E21 VA: 0x3306D20
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3307E30 Offset: 0x3307F31 VA: 0x3307E30
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3308FB0 Offset: 0x33090B1 VA: 0x3308FB0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.Clear
	|
	|-RVA: 0x330A160 Offset: 0x330A261 VA: 0x330A160
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.Clear
	|
	|-RVA: 0x32847D0 Offset: 0x32848D1 VA: 0x32847D0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3285A70 Offset: 0x3285B71 VA: 0x3285A70
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3286C50 Offset: 0x3286D51 VA: 0x3286C50
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3287D60 Offset: 0x3287E61 VA: 0x3287D60
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3288EE0 Offset: 0x3288FE1 VA: 0x3288EE0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.Clear
	|
	|-RVA: 0x328A090 Offset: 0x328A191 VA: 0x328A090
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.Clear
	|
	|-RVA: 0x328B1A0 Offset: 0x328B2A1 VA: 0x328B1A0
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.Clear
	|
	|-RVA: 0x328C280 Offset: 0x328C381 VA: 0x328C280
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x328D330 Offset: 0x328D431 VA: 0x328D330
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.Clear
	|
	|-RVA: 0x328E3D0 Offset: 0x328E4D1 VA: 0x328E3D0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x328F540 Offset: 0x328F641 VA: 0x328F540
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3290540 Offset: 0x3290641 VA: 0x3290540
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|
	|-RVA: 0x3291650 Offset: 0x3291751 VA: 0x3291650
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x32926F0 Offset: 0x32927F1 VA: 0x32926F0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x3293770 Offset: 0x3293871 VA: 0x3293770
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Clear
	|
	|-RVA: 0x3294800 Offset: 0x3294901 VA: 0x3294800
	|-ReadOnlyCollection<float>.System.Collections.IList.Clear
	|
	|-RVA: 0x3295890 Offset: 0x3295991 VA: 0x3295890
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Clear
	|
	|-RVA: 0x3296920 Offset: 0x3296A21 VA: 0x3296920
	|-ReadOnlyCollection<uint>.System.Collections.IList.Clear
	|
	|-RVA: 0x32979B0 Offset: 0x3297AB1 VA: 0x32979B0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Clear
	|
	|-RVA: 0x3298A40 Offset: 0x3298B41 VA: 0x3298A40
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Clear
	|
	|-RVA: 0x3299AD0 Offset: 0x3299BD1 VA: 0x3299AD0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x329AB80 Offset: 0x329AC81 VA: 0x329AB80
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x329BC20 Offset: 0x329BD21 VA: 0x329BC20
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.Clear
	|
	|-RVA: 0x329CCC0 Offset: 0x329CDC1 VA: 0x329CCC0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x329DD60 Offset: 0x329DE61 VA: 0x329DD60
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.Clear
	|
	|-RVA: 0x329EE30 Offset: 0x329EF31 VA: 0x329EE30
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A0050 Offset: 0x32A0151 VA: 0x32A0050
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A1290 Offset: 0x32A1391 VA: 0x32A1290
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A2380 Offset: 0x32A2481 VA: 0x32A2380
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A3420 Offset: 0x32A3521 VA: 0x32A3420
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A4600 Offset: 0x32A4701 VA: 0x32A4600
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A56A0 Offset: 0x32A57A1 VA: 0x32A56A0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A6820 Offset: 0x32A6921 VA: 0x32A6820
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Clear
	|
	|-RVA: 0x32A79E0 Offset: 0x32A7AE1 VA: 0x32A79E0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Clear
	|
	|-RVA: 0x3178910 Offset: 0x3178A11 VA: 0x3178910
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Clear
	|
	|-RVA: 0x3179C60 Offset: 0x3179D61 VA: 0x3179C60
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Clear
	|
	|-RVA: 0x317AD70 Offset: 0x317AE71 VA: 0x317AD70
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Clear
	|
	|-RVA: 0x317BDF0 Offset: 0x317BEF1 VA: 0x317BDF0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x317CEA0 Offset: 0x317CFA1 VA: 0x317CEA0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Clear
	|
	|-RVA: 0x317E010 Offset: 0x317E111 VA: 0x317E010
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Clear
	|
	|-RVA: 0x317F180 Offset: 0x317F281 VA: 0x317F180
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Clear
	|
	|-RVA: 0x31802F0 Offset: 0x31803F1 VA: 0x31802F0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x31813B0 Offset: 0x31814B1 VA: 0x31813B0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Clear
	|
	|-RVA: 0x3182490 Offset: 0x3182591 VA: 0x3182490
	|-ReadOnlyCollection<Color>.System.Collections.IList.Clear
	|
	|-RVA: 0x31837E0 Offset: 0x31838E1 VA: 0x31837E0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Clear
	|
	|-RVA: 0x3184AC0 Offset: 0x3184BC1 VA: 0x3184AC0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Clear
	|
	|-RVA: 0x3185BB0 Offset: 0x3185CB1 VA: 0x3185BB0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.Clear
	|
	|-RVA: 0x3186D30 Offset: 0x3186E31 VA: 0x3186D30
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.Clear
	|
	|-RVA: 0x3187EF0 Offset: 0x3187FF1 VA: 0x3187EF0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.Clear
	|
	|-RVA: 0x3188FD0 Offset: 0x31890D1 VA: 0x3188FD0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.Clear
	|
	|-RVA: 0x318A200 Offset: 0x318A301 VA: 0x318A200
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Clear
	|
	|-RVA: 0x318B3B0 Offset: 0x318B4B1 VA: 0x318B3B0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Clear
	|
	|-RVA: 0x318C470 Offset: 0x318C571 VA: 0x318C470
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Clear
	|
	|-RVA: 0x318D5E0 Offset: 0x318D6E1 VA: 0x318D5E0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Clear
	|
	|-RVA: 0x318E680 Offset: 0x318E781 VA: 0x318E680
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.Clear
	|
	|-RVA: 0x318F700 Offset: 0x318F801 VA: 0x318F700
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Clear
	|
	|-RVA: 0x31907E0 Offset: 0x31908E1 VA: 0x31907E0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Clear
	|
	|-RVA: 0x3191860 Offset: 0x3191961 VA: 0x3191860
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x3192A50 Offset: 0x3192B51 VA: 0x3192A50
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Clear
	|
	|-RVA: 0x3193C90 Offset: 0x3193D91 VA: 0x3193C90
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Clear
	|
	|-RVA: 0x3194D80 Offset: 0x3194E81 VA: 0x3194D80
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Clear
	|
	|-RVA: 0x3195E20 Offset: 0x3195F21 VA: 0x3195E20
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Clear
	|
	|-RVA: 0x3196EC0 Offset: 0x3196FC1 VA: 0x3196EC0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x3198250 Offset: 0x3198351 VA: 0x3198250
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Clear
	|
	|-RVA: 0x3199360 Offset: 0x3199461 VA: 0x3199360
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Clear
	|
	|-RVA: 0x319A4D0 Offset: 0x319A5D1 VA: 0x319A4D0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Clear
	|
	|-RVA: 0x319B640 Offset: 0x319B741 VA: 0x319B640
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Clear
	|
	|-RVA: 0x319C800 Offset: 0x319C901 VA: 0x319C800
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E838D0 Offset: 0x2E839D1 VA: 0x2E838D0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E84A90 Offset: 0x2E84B91 VA: 0x2E84A90
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E85B50 Offset: 0x2E85C51 VA: 0x2E85B50
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E86D10 Offset: 0x2E86E11 VA: 0x2E86D10
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E87EA0 Offset: 0x2E87FA1 VA: 0x2E87EA0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E89010 Offset: 0x2E89111 VA: 0x2E89010
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E8A180 Offset: 0x2E8A281 VA: 0x2E8A180
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E8B250 Offset: 0x2E8B351 VA: 0x2E8B250
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E8C2F0 Offset: 0x2E8C3F1 VA: 0x2E8C2F0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E8D390 Offset: 0x2E8D491 VA: 0x2E8D390
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E8E660 Offset: 0x2E8E761 VA: 0x2E8E660
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E8F820 Offset: 0x2E8F921 VA: 0x2E8F820
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E908C0 Offset: 0x2E909C1 VA: 0x2E908C0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E91950 Offset: 0x2E91A51 VA: 0x2E91950
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E92A30 Offset: 0x2E92B31 VA: 0x2E92A30
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E93B00 Offset: 0x2E93C01 VA: 0x2E93B00
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E94BD0 Offset: 0x2E94CD1 VA: 0x2E94BD0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E95F60 Offset: 0x2E96061 VA: 0x2E95F60
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E97050 Offset: 0x2E97151 VA: 0x2E97050
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.Clear
	|
	|-RVA: 0x2E981D0 Offset: 0x2E982D1 VA: 0x2E981D0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9930 Offset: 0x2EE9A31 VA: 0x2EE9930
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.IsCompatibleObject
	|
	|-RVA: 0x2EEACC0 Offset: 0x2EEADC1 VA: 0x2EEACC0
	|-ReadOnlyCollection<BuildItemData>.IsCompatibleObject
	|
	|-RVA: 0x2EEBDD0 Offset: 0x2EEBED1 VA: 0x2EEBDD0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.IsCompatibleObject
	|
	|-RVA: 0x2EECE70 Offset: 0x2EECF71 VA: 0x2EECE70
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.IsCompatibleObject
	|
	|-RVA: 0x2EEDF40 Offset: 0x2EEE041 VA: 0x2EEDF40
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.IsCompatibleObject
	|
	|-RVA: 0x2EEEFE0 Offset: 0x2EEF0E1 VA: 0x2EEEFE0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.IsCompatibleObject
	|
	|-RVA: 0x2EF0060 Offset: 0x2EF0161 VA: 0x2EF0060
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.IsCompatibleObject
	|
	|-RVA: 0x2EF10F0 Offset: 0x2EF11F1 VA: 0x2EF10F0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.IsCompatibleObject
	|
	|-RVA: 0x2EF22C0 Offset: 0x2EF23C1 VA: 0x2EF22C0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.IsCompatibleObject
	|
	|-RVA: 0x2EF34C0 Offset: 0x2EF35C1 VA: 0x2EF34C0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.IsCompatibleObject
	|
	|-RVA: 0x2EF4690 Offset: 0x2EF4791 VA: 0x2EF4690
	|-ReadOnlyCollection<CropDataTable>.IsCompatibleObject
	|
	|-RVA: 0x2EF5740 Offset: 0x2EF5841 VA: 0x2EF5740
	|-ReadOnlyCollection<DropItemParam>.IsCompatibleObject
	|
	|-RVA: 0x2EF68C0 Offset: 0x2EF69C1 VA: 0x2EF68C0
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.IsCompatibleObject
	|
	|-RVA: 0x2EF7A30 Offset: 0x2EF7B31 VA: 0x2EF7A30
	|-ReadOnlyCollection<EventCheckId>.IsCompatibleObject
	|
	|-RVA: 0x2EF8AD0 Offset: 0x2EF8BD1 VA: 0x2EF8AD0
	|-ReadOnlyCollection<EventFlagProgressData>.IsCompatibleObject
	|
	|-RVA: 0x2EF9B70 Offset: 0x2EF9C71 VA: 0x2EF9B70
	|-ReadOnlyCollection<FesNpcScoreData>.IsCompatibleObject
	|
	|-RVA: 0x2EFAD50 Offset: 0x2EFAE51 VA: 0x2EFAD50
	|-ReadOnlyCollection<MiningPointSaveData>.IsCompatibleObject
	|
	|-RVA: 0x2EFBF30 Offset: 0x2EFC031 VA: 0x2EFBF30
	|-ReadOnlyCollection<MonsterHutSaveData>.IsCompatibleObject
	|
	|-RVA: 0x2EFCFF0 Offset: 0x2EFD0F1 VA: 0x2EFCFF0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.IsCompatibleObject
	|
	|-RVA: 0x32E7040 Offset: 0x32E7141 VA: 0x32E7040
	|-ReadOnlyCollection<NPCActionData>.IsCompatibleObject
	|
	|-RVA: 0x32E81D0 Offset: 0x32E82D1 VA: 0x32E81D0
	|-ReadOnlyCollection<NpcPlaceSchedule>.IsCompatibleObject
	|
	|-RVA: 0x32E92A0 Offset: 0x32E93A1 VA: 0x32E92A0
	|-ReadOnlyCollection<OrderLotterySaveParameter>.IsCompatibleObject
	|
	|-RVA: 0x32EA410 Offset: 0x32EA511 VA: 0x32EA410
	|-ReadOnlyCollection<OrderSaveParameter>.IsCompatibleObject
	|
	|-RVA: 0x32EB4B0 Offset: 0x32EB5B1 VA: 0x32EB4B0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.IsCompatibleObject
	|
	|-RVA: 0x32EC550 Offset: 0x32EC651 VA: 0x32EC550
	|-ReadOnlyCollection<ShopCatalogPage>.IsCompatibleObject
	|
	|-RVA: 0x32ED710 Offset: 0x32ED811 VA: 0x32ED710
	|-ReadOnlyCollection<ShopNpcTalk>.IsCompatibleObject
	|
	|-RVA: 0x32EE800 Offset: 0x32EE901 VA: 0x32EE800
	|-ReadOnlyCollection<SubtitleDataTable.Data>.IsCompatibleObject
	|
	|-RVA: 0x32EF880 Offset: 0x32EF981 VA: 0x32EF880
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.IsCompatibleObject
	|
	|-RVA: 0x32F0960 Offset: 0x32F0A61 VA: 0x32F0960
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.IsCompatibleObject
	|
	|-RVA: 0x32F1AD0 Offset: 0x32F1BD1 VA: 0x32F1AD0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.IsCompatibleObject
	|
	|-RVA: 0x32F2C40 Offset: 0x32F2D41 VA: 0x32F2C40
	|-ReadOnlyCollection<Schedule>.IsCompatibleObject
	|
	|-RVA: 0x32F3EB0 Offset: 0x32F3FB1 VA: 0x32F3EB0
	|-ReadOnlyCollection<CurveSample>.IsCompatibleObject
	|
	|-RVA: 0x32F4F90 Offset: 0x32F5091 VA: 0x32F4F90
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|
	|-RVA: 0x32F6020 Offset: 0x32F6121 VA: 0x32F6020
	|-ReadOnlyCollection<byte>.IsCompatibleObject
	|
	|-RVA: 0x32F70B0 Offset: 0x32F71B1 VA: 0x32F70B0
	|-ReadOnlyCollection<char>.IsCompatibleObject
	|
	|-RVA: 0x32F8160 Offset: 0x32F8261 VA: 0x32F8160
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.IsCompatibleObject
	|
	|-RVA: 0x32F9200 Offset: 0x32F9301 VA: 0x32F9200
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x32FA2A0 Offset: 0x32FA3A1 VA: 0x32FA2A0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x32FB320 Offset: 0x32FB421 VA: 0x32FB320
	|-ReadOnlyCollection<DateTime>.IsCompatibleObject
	|
	|-RVA: 0x32FC3B0 Offset: 0x32FC4B1 VA: 0x32FC3B0
	|-ReadOnlyCollection<double>.IsCompatibleObject
	|
	|-RVA: 0x32FD440 Offset: 0x32FD541 VA: 0x32FD440
	|-ReadOnlyCollection<short>.IsCompatibleObject
	|
	|-RVA: 0x32FE4D0 Offset: 0x32FE5D1 VA: 0x32FE4D0
	|-ReadOnlyCollection<int>.IsCompatibleObject
	|
	|-RVA: 0x32FF560 Offset: 0x32FF661 VA: 0x32FF560
	|-ReadOnlyCollection<Int32Enum>.IsCompatibleObject
	|
	|-RVA: 0x33005F0 Offset: 0x33006F1 VA: 0x33005F0
	|-ReadOnlyCollection<long>.IsCompatibleObject
	|
	|-RVA: 0x33016A0 Offset: 0x33017A1 VA: 0x33016A0
	|-ReadOnlyCollection<InterpretedFrameInfo>.IsCompatibleObject
	|
	|-RVA: 0x3302720 Offset: 0x3302821 VA: 0x3302720
	|-ReadOnlyCollection<Nullable<Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x33038F0 Offset: 0x33039F1 VA: 0x33038F0
	|-ReadOnlyCollection<Nullable<Bounds>>.IsCompatibleObject
	|
	|-RVA: 0x3304AF0 Offset: 0x3304BF1 VA: 0x3304AF0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.IsCompatibleObject
	|
	|-RVA: 0x3305BB0 Offset: 0x3305CB1 VA: 0x3305BB0
	|-ReadOnlyCollection<Nullable<Color32>>.IsCompatibleObject
	|
	|-RVA: 0x3306D30 Offset: 0x3306E31 VA: 0x3306D30
	|-ReadOnlyCollection<Nullable<Color>>.IsCompatibleObject
	|
	|-RVA: 0x3307E40 Offset: 0x3307F41 VA: 0x3307E40
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.IsCompatibleObject
	|
	|-RVA: 0x3308FC0 Offset: 0x33090C1 VA: 0x3308FC0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.IsCompatibleObject
	|
	|-RVA: 0x330A170 Offset: 0x330A271 VA: 0x330A170
	|-ReadOnlyCollection<Nullable<Keyframe>>.IsCompatibleObject
	|
	|-RVA: 0x32847E0 Offset: 0x32848E1 VA: 0x32847E0
	|-ReadOnlyCollection<Nullable<LayerMask>>.IsCompatibleObject
	|
	|-RVA: 0x3285A80 Offset: 0x3285B81 VA: 0x3285A80
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.IsCompatibleObject
	|
	|-RVA: 0x3286C60 Offset: 0x3286D61 VA: 0x3286C60
	|-ReadOnlyCollection<Nullable<Quaternion>>.IsCompatibleObject
	|
	|-RVA: 0x3287D70 Offset: 0x3287E71 VA: 0x3287D70
	|-ReadOnlyCollection<Nullable<RangeInt>>.IsCompatibleObject
	|
	|-RVA: 0x3288EF0 Offset: 0x3288FF1 VA: 0x3288EF0
	|-ReadOnlyCollection<Nullable<Rect>>.IsCompatibleObject
	|
	|-RVA: 0x328A0A0 Offset: 0x328A1A1 VA: 0x328A0A0
	|-ReadOnlyCollection<Nullable<RectInt>>.IsCompatibleObject
	|
	|-RVA: 0x328B1B0 Offset: 0x328B2B1 VA: 0x328B1B0
	|-ReadOnlyCollection<Nullable<Vector2>>.IsCompatibleObject
	|
	|-RVA: 0x328C290 Offset: 0x328C391 VA: 0x328C290
	|-ReadOnlyCollection<Nullable<Vector2Int>>.IsCompatibleObject
	|
	|-RVA: 0x328D340 Offset: 0x328D441 VA: 0x328D340
	|-ReadOnlyCollection<Nullable<Vector3>>.IsCompatibleObject
	|
	|-RVA: 0x328E3E0 Offset: 0x328E4E1 VA: 0x328E3E0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.IsCompatibleObject
	|
	|-RVA: 0x328F550 Offset: 0x328F651 VA: 0x328F550
	|-ReadOnlyCollection<Nullable<Vector4>>.IsCompatibleObject
	|
	|-RVA: 0x3290550 Offset: 0x3290651 VA: 0x3290550
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0x3291660 Offset: 0x3291761 VA: 0x3291660
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|
	|-RVA: 0x3292700 Offset: 0x3292801 VA: 0x3292700
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|
	|-RVA: 0x3293780 Offset: 0x3293881 VA: 0x3293780
	|-ReadOnlyCollection<sbyte>.IsCompatibleObject
	|
	|-RVA: 0x3294810 Offset: 0x3294911 VA: 0x3294810
	|-ReadOnlyCollection<float>.IsCompatibleObject
	|
	|-RVA: 0x32958A0 Offset: 0x32959A1 VA: 0x32958A0
	|-ReadOnlyCollection<ushort>.IsCompatibleObject
	|
	|-RVA: 0x3296930 Offset: 0x3296A31 VA: 0x3296930
	|-ReadOnlyCollection<uint>.IsCompatibleObject
	|
	|-RVA: 0x32979C0 Offset: 0x3297AC1 VA: 0x32979C0
	|-ReadOnlyCollection<ulong>.IsCompatibleObject
	|
	|-RVA: 0x3298A50 Offset: 0x3298B51 VA: 0x3298A50
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x3299AE0 Offset: 0x3299BE1 VA: 0x3299AE0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x329AB90 Offset: 0x329AC91 VA: 0x329AB90
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.IsCompatibleObject
	|
	|-RVA: 0x329BC30 Offset: 0x329BD31 VA: 0x329BC30
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x329CCD0 Offset: 0x329CDD1 VA: 0x329CCD0
	|-ReadOnlyCollection<ValueTuple<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x329DD70 Offset: 0x329DE71 VA: 0x329DD70
	|-ReadOnlyCollection<ValueTuple<object, float>>.IsCompatibleObject
	|
	|-RVA: 0x329EE40 Offset: 0x329EF41 VA: 0x329EE40
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x32A0060 Offset: 0x32A0161 VA: 0x32A0060
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IsCompatibleObject
	|
	|-RVA: 0x32A12A0 Offset: 0x32A13A1 VA: 0x32A12A0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IsCompatibleObject
	|
	|-RVA: 0x32A2390 Offset: 0x32A2491 VA: 0x32A2390
	|-ReadOnlyCollection<TutorialUnlockFlagData>.IsCompatibleObject
	|
	|-RVA: 0x32A3430 Offset: 0x32A3531 VA: 0x32A3430
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.IsCompatibleObject
	|
	|-RVA: 0x32A4610 Offset: 0x32A4711 VA: 0x32A4610
	|-ReadOnlyCollection<CapEdge>.IsCompatibleObject
	|
	|-RVA: 0x32A56B0 Offset: 0x32A57B1 VA: 0x32A56B0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.IsCompatibleObject
	|
	|-RVA: 0x32A6830 Offset: 0x32A6931 VA: 0x32A6830
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.IsCompatibleObject
	|
	|-RVA: 0x32A79F0 Offset: 0x32A7AF1 VA: 0x32A79F0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.IsCompatibleObject
	|
	|-RVA: 0x3178920 Offset: 0x3178A21 VA: 0x3178920
	|-ReadOnlyCollection<NavMeshBuildMarkup>.IsCompatibleObject
	|
	|-RVA: 0x3179C70 Offset: 0x3179D71 VA: 0x3179C70
	|-ReadOnlyCollection<NavMeshBuildSource>.IsCompatibleObject
	|
	|-RVA: 0x317AD80 Offset: 0x317AE81 VA: 0x317AD80
	|-ReadOnlyCollection<ConstraintSource>.IsCompatibleObject
	|
	|-RVA: 0x317BE00 Offset: 0x317BF01 VA: 0x317BE00
	|-ReadOnlyCollection<AnimatorClipInfo>.IsCompatibleObject
	|
	|-RVA: 0x317CEB0 Offset: 0x317CFB1 VA: 0x317CEB0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|
	|-RVA: 0x317E020 Offset: 0x317E121 VA: 0x317E020
	|-ReadOnlyCollection<BoneWeight>.IsCompatibleObject
	|
	|-RVA: 0x317F190 Offset: 0x317F291 VA: 0x317F190
	|-ReadOnlyCollection<Bounds>.IsCompatibleObject
	|
	|-RVA: 0x3180300 Offset: 0x3180401 VA: 0x3180300
	|-ReadOnlyCollection<BoundsInt>.IsCompatibleObject
	|
	|-RVA: 0x31813C0 Offset: 0x31814C1 VA: 0x31813C0
	|-ReadOnlyCollection<Color32>.IsCompatibleObject
	|
	|-RVA: 0x31824A0 Offset: 0x31825A1 VA: 0x31824A0
	|-ReadOnlyCollection<Color>.IsCompatibleObject
	|
	|-RVA: 0x31837F0 Offset: 0x31838F1 VA: 0x31837F0
	|-ReadOnlyCollection<CombineInstance>.IsCompatibleObject
	|
	|-RVA: 0x3184AD0 Offset: 0x3184BD1 VA: 0x3184AD0
	|-ReadOnlyCollection<RaycastResult>.IsCompatibleObject
	|
	|-RVA: 0x3185BC0 Offset: 0x3185CC1 VA: 0x3185BC0
	|-ReadOnlyCollection<GradientAlphaKey>.IsCompatibleObject
	|
	|-RVA: 0x3186D40 Offset: 0x3186E41 VA: 0x3186D40
	|-ReadOnlyCollection<GradientColorKey>.IsCompatibleObject
	|
	|-RVA: 0x3187F00 Offset: 0x3188001 VA: 0x3187F00
	|-ReadOnlyCollection<Keyframe>.IsCompatibleObject
	|
	|-RVA: 0x3188FE0 Offset: 0x31890E1 VA: 0x3188FE0
	|-ReadOnlyCollection<LayerMask>.IsCompatibleObject
	|
	|-RVA: 0x318A210 Offset: 0x318A311 VA: 0x318A210
	|-ReadOnlyCollection<Matrix4x4>.IsCompatibleObject
	|
	|-RVA: 0x318B3C0 Offset: 0x318B4C1 VA: 0x318B3C0
	|-ReadOnlyCollection<ParticleSystem.Particle>.IsCompatibleObject
	|
	|-RVA: 0x318C480 Offset: 0x318C581 VA: 0x318C480
	|-ReadOnlyCollection<Playable>.IsCompatibleObject
	|
	|-RVA: 0x318D5F0 Offset: 0x318D6F1 VA: 0x318D5F0
	|-ReadOnlyCollection<PlayableBinding>.IsCompatibleObject
	|
	|-RVA: 0x318E690 Offset: 0x318E791 VA: 0x318E690
	|-ReadOnlyCollection<PlayableGraph>.IsCompatibleObject
	|
	|-RVA: 0x318F710 Offset: 0x318F811 VA: 0x318F710
	|-ReadOnlyCollection<Edge>.IsCompatibleObject
	|
	|-RVA: 0x31907F0 Offset: 0x31908F1 VA: 0x31907F0
	|-ReadOnlyCollection<Quaternion>.IsCompatibleObject
	|
	|-RVA: 0x3191870 Offset: 0x3191971 VA: 0x3191870
	|-ReadOnlyCollection<RangeInt>.IsCompatibleObject
	|
	|-RVA: 0x3192A60 Offset: 0x3192B61 VA: 0x3192A60
	|-ReadOnlyCollection<RaycastHit2D>.IsCompatibleObject
	|
	|-RVA: 0x3193CA0 Offset: 0x3193DA1 VA: 0x3193CA0
	|-ReadOnlyCollection<RaycastHit>.IsCompatibleObject
	|
	|-RVA: 0x3194D90 Offset: 0x3194E91 VA: 0x3194D90
	|-ReadOnlyCollection<Rect>.IsCompatibleObject
	|
	|-RVA: 0x3195E30 Offset: 0x3195F31 VA: 0x3195E30
	|-ReadOnlyCollection<RectInt>.IsCompatibleObject
	|
	|-RVA: 0x3196ED0 Offset: 0x3196FD1 VA: 0x3196ED0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.IsCompatibleObject
	|
	|-RVA: 0x3198260 Offset: 0x3198361 VA: 0x3198260
	|-ReadOnlyCollection<SphericalHarmonicsL2>.IsCompatibleObject
	|
	|-RVA: 0x3199370 Offset: 0x3199471 VA: 0x3199370
	|-ReadOnlyCollection<VertexAttributeDescriptor>.IsCompatibleObject
	|
	|-RVA: 0x319A4E0 Offset: 0x319A5E1 VA: 0x319A4E0
	|-ReadOnlyCollection<AsyncOperationHandle>.IsCompatibleObject
	|
	|-RVA: 0x319B650 Offset: 0x319B751 VA: 0x319B650
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.IsCompatibleObject
	|
	|-RVA: 0x319C810 Offset: 0x319C911 VA: 0x319C810
	|-ReadOnlyCollection<DiagnosticEvent>.IsCompatibleObject
	|
	|-RVA: 0x2E838E0 Offset: 0x2E839E1 VA: 0x2E838E0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.IsCompatibleObject
	|
	|-RVA: 0x2E84AA0 Offset: 0x2E84BA1 VA: 0x2E84AA0
	|-ReadOnlyCollection<ObjectInitializationData>.IsCompatibleObject
	|
	|-RVA: 0x2E85B60 Offset: 0x2E85C61 VA: 0x2E85B60
	|-ReadOnlyCollection<GlyphRect>.IsCompatibleObject
	|
	|-RVA: 0x2E86D20 Offset: 0x2E86E21 VA: 0x2E86D20
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.IsCompatibleObject
	|
	|-RVA: 0x2E87EB0 Offset: 0x2E87FB1 VA: 0x2E87EB0
	|-ReadOnlyCollection<IntervalTreeNode>.IsCompatibleObject
	|
	|-RVA: 0x2E89020 Offset: 0x2E89121 VA: 0x2E89020
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.IsCompatibleObject
	|
	|-RVA: 0x2E8A190 Offset: 0x2E8A291 VA: 0x2E8A190
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.IsCompatibleObject
	|
	|-RVA: 0x2E8B260 Offset: 0x2E8B361 VA: 0x2E8B260
	|-ReadOnlyCollection<UICharInfo>.IsCompatibleObject
	|
	|-RVA: 0x2E8C300 Offset: 0x2E8C401 VA: 0x2E8C300
	|-ReadOnlyCollection<FocusController.FocusedElement>.IsCompatibleObject
	|
	|-RVA: 0x2E8D3A0 Offset: 0x2E8D4A1 VA: 0x2E8D3A0
	|-ReadOnlyCollection<UILineInfo>.IsCompatibleObject
	|
	|-RVA: 0x2E8E670 Offset: 0x2E8E771 VA: 0x2E8E670
	|-ReadOnlyCollection<UIVertex>.IsCompatibleObject
	|
	|-RVA: 0x2E8F830 Offset: 0x2E8F931 VA: 0x2E8F830
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|
	|-RVA: 0x2E908D0 Offset: 0x2E909D1 VA: 0x2E908D0
	|-ReadOnlyCollection<Vector2>.IsCompatibleObject
	|
	|-RVA: 0x2E91960 Offset: 0x2E91A61 VA: 0x2E91960
	|-ReadOnlyCollection<Vector2Int>.IsCompatibleObject
	|
	|-RVA: 0x2E92A40 Offset: 0x2E92B41 VA: 0x2E92A40
	|-ReadOnlyCollection<Vector3>.IsCompatibleObject
	|
	|-RVA: 0x2E93B10 Offset: 0x2E93C11 VA: 0x2E93B10
	|-ReadOnlyCollection<Vector3Int>.IsCompatibleObject
	|
	|-RVA: 0x2E94BE0 Offset: 0x2E94CE1 VA: 0x2E94BE0
	|-ReadOnlyCollection<Vector4>.IsCompatibleObject
	|
	|-RVA: 0x2E95F70 Offset: 0x2E96071 VA: 0x2E95F70
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.IsCompatibleObject
	|
	|-RVA: 0x2E97060 Offset: 0x2E97161 VA: 0x2E97060
	|-ReadOnlyCollection<YieldItemParam>.IsCompatibleObject
	|
	|-RVA: 0x2E981E0 Offset: 0x2E982E1 VA: 0x2E981E0
	|-ReadOnlyCollection<stCommand_t>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9A20 Offset: 0x2EE9B21 VA: 0x2EE9A20
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EEADC0 Offset: 0x2EEAEC1 VA: 0x2EEADC0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EEBEC0 Offset: 0x2EEBFC1 VA: 0x2EEBEC0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EECF60 Offset: 0x2EED061 VA: 0x2EECF60
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EEE030 Offset: 0x2EEE131 VA: 0x2EEE030
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EEF0D0 Offset: 0x2EEF1D1 VA: 0x2EEF0D0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF0160 Offset: 0x2EF0261 VA: 0x2EF0160
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF11F0 Offset: 0x2EF12F1 VA: 0x2EF11F0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF23B0 Offset: 0x2EF24B1 VA: 0x2EF23B0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF35B0 Offset: 0x2EF36B1 VA: 0x2EF35B0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF47B0 Offset: 0x2EF48B1 VA: 0x2EF47B0
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF5840 Offset: 0x2EF5941 VA: 0x2EF5840
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF69B0 Offset: 0x2EF6AB1 VA: 0x2EF69B0
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF7B20 Offset: 0x2EF7C21 VA: 0x2EF7B20
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF8BC0 Offset: 0x2EF8CC1 VA: 0x2EF8BC0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EF9C60 Offset: 0x2EF9D61 VA: 0x2EF9C60
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EFAE40 Offset: 0x2EFAF41 VA: 0x2EFAE40
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EFC020 Offset: 0x2EFC121 VA: 0x2EFC020
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2EFD0E0 Offset: 0x2EFD1E1 VA: 0x2EFD0E0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Contains
	|
	|-RVA: 0x32E7130 Offset: 0x32E7231 VA: 0x32E7130
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.Contains
	|
	|-RVA: 0x32E82C0 Offset: 0x32E83C1 VA: 0x32E82C0
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.Contains
	|
	|-RVA: 0x32E9390 Offset: 0x32E9491 VA: 0x32E9390
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.Contains
	|
	|-RVA: 0x32EA500 Offset: 0x32EA601 VA: 0x32EA500
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.Contains
	|
	|-RVA: 0x32EB5A0 Offset: 0x32EB6A1 VA: 0x32EB5A0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Contains
	|
	|-RVA: 0x32EC640 Offset: 0x32EC741 VA: 0x32EC640
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.Contains
	|
	|-RVA: 0x32ED800 Offset: 0x32ED901 VA: 0x32ED800
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.Contains
	|
	|-RVA: 0x32EE8F0 Offset: 0x32EE9F1 VA: 0x32EE8F0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.Contains
	|
	|-RVA: 0x32EF980 Offset: 0x32EFA81 VA: 0x32EF980
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F0A50 Offset: 0x32F0B51 VA: 0x32F0A50
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F1BC0 Offset: 0x32F1CC1 VA: 0x32F1BC0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F2D30 Offset: 0x32F2E31 VA: 0x32F2D30
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F3FB0 Offset: 0x32F40B1 VA: 0x32F3FB0
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F5090 Offset: 0x32F5191 VA: 0x32F5090
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F6120 Offset: 0x32F6221 VA: 0x32F6120
	|-ReadOnlyCollection<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F71B0 Offset: 0x32F72B1 VA: 0x32F71B0
	|-ReadOnlyCollection<char>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F8250 Offset: 0x32F8351 VA: 0x32F8250
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32F92F0 Offset: 0x32F93F1 VA: 0x32F92F0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32FA390 Offset: 0x32FA491 VA: 0x32FA390
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32FB420 Offset: 0x32FB521 VA: 0x32FB420
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Contains
	|
	|-RVA: 0x32FC4B0 Offset: 0x32FC5B1 VA: 0x32FC4B0
	|-ReadOnlyCollection<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x32FD540 Offset: 0x32FD641 VA: 0x32FD540
	|-ReadOnlyCollection<short>.System.Collections.IList.Contains
	|
	|-RVA: 0x32FE5D0 Offset: 0x32FE6D1 VA: 0x32FE5D0
	|-ReadOnlyCollection<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x32FF660 Offset: 0x32FF761 VA: 0x32FF660
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x33006F0 Offset: 0x33007F1 VA: 0x33006F0
	|-ReadOnlyCollection<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x3301790 Offset: 0x3301891 VA: 0x3301790
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3302820 Offset: 0x3302921 VA: 0x3302820
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x33039E0 Offset: 0x3303AE1 VA: 0x33039E0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3304BE0 Offset: 0x3304CE1 VA: 0x3304BE0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3305CB0 Offset: 0x3305DB1 VA: 0x3305CB0
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3306E20 Offset: 0x3306F21 VA: 0x3306E20
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3307F30 Offset: 0x3308031 VA: 0x3307F30
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.Contains
	|
	|-RVA: 0x33090B0 Offset: 0x33091B1 VA: 0x33090B0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.Contains
	|
	|-RVA: 0x330A260 Offset: 0x330A361 VA: 0x330A260
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32848E0 Offset: 0x32849E1 VA: 0x32848E0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3285B80 Offset: 0x3285C81 VA: 0x3285B80
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3286D50 Offset: 0x3286E51 VA: 0x3286D50
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3287E60 Offset: 0x3287F61 VA: 0x3287E60
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3288FE0 Offset: 0x32890E1 VA: 0x3288FE0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.Contains
	|
	|-RVA: 0x328A190 Offset: 0x328A291 VA: 0x328A190
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.Contains
	|
	|-RVA: 0x328B2A0 Offset: 0x328B3A1 VA: 0x328B2A0
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.Contains
	|
	|-RVA: 0x328C380 Offset: 0x328C481 VA: 0x328C380
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x328D430 Offset: 0x328D531 VA: 0x328D430
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.Contains
	|
	|-RVA: 0x328E4D0 Offset: 0x328E5D1 VA: 0x328E4D0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x328F640 Offset: 0x328F741 VA: 0x328F640
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32905E0 Offset: 0x32906E1 VA: 0x32905E0
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x3291750 Offset: 0x3291851 VA: 0x3291750
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x32927F0 Offset: 0x32928F1 VA: 0x32927F0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x3293880 Offset: 0x3293981 VA: 0x3293880
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x3294910 Offset: 0x3294A11 VA: 0x3294910
	|-ReadOnlyCollection<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x32959A0 Offset: 0x3295AA1 VA: 0x32959A0
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x3296A30 Offset: 0x3296B31 VA: 0x3296A30
	|-ReadOnlyCollection<uint>.System.Collections.IList.Contains
	|
	|-RVA: 0x3297AC0 Offset: 0x3297BC1 VA: 0x3297AC0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x3298B50 Offset: 0x3298C51 VA: 0x3298B50
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3299BE0 Offset: 0x3299CE1 VA: 0x3299BE0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x329AC80 Offset: 0x329AD81 VA: 0x329AC80
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x329BD20 Offset: 0x329BE21 VA: 0x329BD20
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x329CDC0 Offset: 0x329CEC1 VA: 0x329CDC0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x329DE60 Offset: 0x329DF61 VA: 0x329DE60
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x329EF30 Offset: 0x329F031 VA: 0x329EF30
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A0150 Offset: 0x32A0251 VA: 0x32A0150
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A1390 Offset: 0x32A1491 VA: 0x32A1390
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A2480 Offset: 0x32A2581 VA: 0x32A2480
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A3520 Offset: 0x32A3621 VA: 0x32A3520
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A4700 Offset: 0x32A4801 VA: 0x32A4700
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A57B0 Offset: 0x32A58B1 VA: 0x32A57B0
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A6920 Offset: 0x32A6A21 VA: 0x32A6920
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A7AE0 Offset: 0x32A7BE1 VA: 0x32A7AE0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3178A10 Offset: 0x3178B11 VA: 0x3178A10
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Contains
	|
	|-RVA: 0x3179D70 Offset: 0x3179E71 VA: 0x3179D70
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Contains
	|
	|-RVA: 0x317AE70 Offset: 0x317AF71 VA: 0x317AE70
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Contains
	|
	|-RVA: 0x317BF00 Offset: 0x317C001 VA: 0x317BF00
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x317CFA0 Offset: 0x317D0A1 VA: 0x317CFA0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|
	|-RVA: 0x317E110 Offset: 0x317E211 VA: 0x317E110
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Contains
	|
	|-RVA: 0x317F280 Offset: 0x317F381 VA: 0x317F280
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Contains
	|
	|-RVA: 0x31803F0 Offset: 0x31804F1 VA: 0x31803F0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x31814C0 Offset: 0x31815C1 VA: 0x31814C0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Contains
	|
	|-RVA: 0x3182590 Offset: 0x3182691 VA: 0x3182590
	|-ReadOnlyCollection<Color>.System.Collections.IList.Contains
	|
	|-RVA: 0x31838F0 Offset: 0x31839F1 VA: 0x31838F0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Contains
	|
	|-RVA: 0x3184BD0 Offset: 0x3184CD1 VA: 0x3184BD0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Contains
	|
	|-RVA: 0x3185CC0 Offset: 0x3185DC1 VA: 0x3185CC0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.Contains
	|
	|-RVA: 0x3186E30 Offset: 0x3186F31 VA: 0x3186E30
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.Contains
	|
	|-RVA: 0x3187FF0 Offset: 0x31880F1 VA: 0x3187FF0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.Contains
	|
	|-RVA: 0x31890E0 Offset: 0x31891E1 VA: 0x31890E0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.Contains
	|
	|-RVA: 0x318A300 Offset: 0x318A401 VA: 0x318A300
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Contains
	|
	|-RVA: 0x318B4D0 Offset: 0x318B5D1 VA: 0x318B4D0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Contains
	|
	|-RVA: 0x318C570 Offset: 0x318C671 VA: 0x318C570
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Contains
	|
	|-RVA: 0x318D6E0 Offset: 0x318D7E1 VA: 0x318D6E0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Contains
	|
	|-RVA: 0x318E780 Offset: 0x318E881 VA: 0x318E780
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.Contains
	|
	|-RVA: 0x318F810 Offset: 0x318F911 VA: 0x318F810
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Contains
	|
	|-RVA: 0x31908E0 Offset: 0x31909E1 VA: 0x31908E0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Contains
	|
	|-RVA: 0x3191970 Offset: 0x3191A71 VA: 0x3191970
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3192B50 Offset: 0x3192C51 VA: 0x3192B50
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Contains
	|
	|-RVA: 0x3193D90 Offset: 0x3193E91 VA: 0x3193D90
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Contains
	|
	|-RVA: 0x3194E80 Offset: 0x3194F81 VA: 0x3194E80
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Contains
	|
	|-RVA: 0x3195F20 Offset: 0x3196021 VA: 0x3195F20
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3196FC0 Offset: 0x31970C1 VA: 0x3196FC0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3198360 Offset: 0x3198461 VA: 0x3198360
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Contains
	|
	|-RVA: 0x3199460 Offset: 0x3199561 VA: 0x3199460
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Contains
	|
	|-RVA: 0x319A5D0 Offset: 0x319A6D1 VA: 0x319A5D0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x319B740 Offset: 0x319B841 VA: 0x319B740
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Contains
	|
	|-RVA: 0x319C900 Offset: 0x319CA01 VA: 0x319C900
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E839D0 Offset: 0x2E83AD1 VA: 0x2E839D0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E84B90 Offset: 0x2E84C91 VA: 0x2E84B90
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E85C50 Offset: 0x2E85D51 VA: 0x2E85C50
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E86E10 Offset: 0x2E86F11 VA: 0x2E86E10
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E87FA0 Offset: 0x2E880A1 VA: 0x2E87FA0
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E89110 Offset: 0x2E89211 VA: 0x2E89110
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E8A280 Offset: 0x2E8A381 VA: 0x2E8A280
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E8B350 Offset: 0x2E8B451 VA: 0x2E8B350
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E8C3F0 Offset: 0x2E8C4F1 VA: 0x2E8C3F0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E8D490 Offset: 0x2E8D591 VA: 0x2E8D490
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E8E770 Offset: 0x2E8E871 VA: 0x2E8E770
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E8F920 Offset: 0x2E8FA21 VA: 0x2E8F920
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E909D0 Offset: 0x2E90AD1 VA: 0x2E909D0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E91A60 Offset: 0x2E91B61 VA: 0x2E91A60
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E92B30 Offset: 0x2E92C31 VA: 0x2E92B30
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E93C00 Offset: 0x2E93D01 VA: 0x2E93C00
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E94CD0 Offset: 0x2E94DD1 VA: 0x2E94CD0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E96070 Offset: 0x2E96171 VA: 0x2E96070
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E97160 Offset: 0x2E97261 VA: 0x2E97160
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x2E982D0 Offset: 0x2E983D1 VA: 0x2E982D0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9B00 Offset: 0x2EE9C01 VA: 0x2EE9B00
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EEAED0 Offset: 0x2EEAFD1 VA: 0x2EEAED0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EEBFA0 Offset: 0x2EEC0A1 VA: 0x2EEBFA0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EED040 Offset: 0x2EED141 VA: 0x2EED040
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EEE110 Offset: 0x2EEE211 VA: 0x2EEE110
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EEF1B0 Offset: 0x2EEF2B1 VA: 0x2EEF1B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF0240 Offset: 0x2EF0341 VA: 0x2EF0240
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF12D0 Offset: 0x2EF13D1 VA: 0x2EF12D0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF24A0 Offset: 0x2EF25A1 VA: 0x2EF24A0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF36A0 Offset: 0x2EF37A1 VA: 0x2EF36A0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF4890 Offset: 0x2EF4991 VA: 0x2EF4890
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF5920 Offset: 0x2EF5A21 VA: 0x2EF5920
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF6A90 Offset: 0x2EF6B91 VA: 0x2EF6A90
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF7C00 Offset: 0x2EF7D01 VA: 0x2EF7C00
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF8CA0 Offset: 0x2EF8DA1 VA: 0x2EF8CA0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EF9D40 Offset: 0x2EF9E41 VA: 0x2EF9D40
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EFAF30 Offset: 0x2EFB031 VA: 0x2EFAF30
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EFC110 Offset: 0x2EFC211 VA: 0x2EFC110
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2EFD1C0 Offset: 0x2EFD2C1 VA: 0x2EFD1C0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32E7220 Offset: 0x32E7321 VA: 0x32E7220
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32E83A0 Offset: 0x32E84A1 VA: 0x32E83A0
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32E9470 Offset: 0x32E9571 VA: 0x32E9470
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32EA5E0 Offset: 0x32EA6E1 VA: 0x32EA5E0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32EB680 Offset: 0x32EB781 VA: 0x32EB680
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32EC720 Offset: 0x32EC821 VA: 0x32EC720
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32ED8F0 Offset: 0x32ED9F1 VA: 0x32ED8F0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32EE9D0 Offset: 0x32EEAD1 VA: 0x32EE9D0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32EFA60 Offset: 0x32EFB61 VA: 0x32EFA60
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F0B30 Offset: 0x32F0C31 VA: 0x32F0B30
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F1CA0 Offset: 0x32F1DA1 VA: 0x32F1CA0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F2E10 Offset: 0x32F2F11 VA: 0x32F2E10
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F40B0 Offset: 0x32F41B1 VA: 0x32F40B0
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F5170 Offset: 0x32F5271 VA: 0x32F5170
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F6200 Offset: 0x32F6301 VA: 0x32F6200
	|-ReadOnlyCollection<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F7290 Offset: 0x32F7391 VA: 0x32F7290
	|-ReadOnlyCollection<char>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F8330 Offset: 0x32F8431 VA: 0x32F8330
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32F93D0 Offset: 0x32F94D1 VA: 0x32F93D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32FA470 Offset: 0x32FA571 VA: 0x32FA470
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32FB500 Offset: 0x32FB601 VA: 0x32FB500
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32FC590 Offset: 0x32FC691 VA: 0x32FC590
	|-ReadOnlyCollection<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32FD620 Offset: 0x32FD721 VA: 0x32FD620
	|-ReadOnlyCollection<short>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32FE6B0 Offset: 0x32FE7B1 VA: 0x32FE6B0
	|-ReadOnlyCollection<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32FF740 Offset: 0x32FF841 VA: 0x32FF740
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33007D0 Offset: 0x33008D1 VA: 0x33007D0
	|-ReadOnlyCollection<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3301870 Offset: 0x3301971 VA: 0x3301870
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3302900 Offset: 0x3302A01 VA: 0x3302900
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3303AE0 Offset: 0x3303BE1 VA: 0x3303AE0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3304CE0 Offset: 0x3304DE1 VA: 0x3304CE0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3305D90 Offset: 0x3305E91 VA: 0x3305D90
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3306F20 Offset: 0x3307021 VA: 0x3306F20
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3308020 Offset: 0x3308121 VA: 0x3308020
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33091B0 Offset: 0x33092B1 VA: 0x33091B0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x330A360 Offset: 0x330A461 VA: 0x330A360
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32849C0 Offset: 0x3284AC1 VA: 0x32849C0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3285C90 Offset: 0x3285D91 VA: 0x3285C90
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3286E50 Offset: 0x3286F51 VA: 0x3286E50
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3287F50 Offset: 0x3288051 VA: 0x3287F50
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32890E0 Offset: 0x32891E1 VA: 0x32890E0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x328A290 Offset: 0x328A391 VA: 0x328A290
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x328B390 Offset: 0x328B491 VA: 0x328B390
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x328C470 Offset: 0x328C571 VA: 0x328C470
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x328D510 Offset: 0x328D611 VA: 0x328D510
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x328E5B0 Offset: 0x328E6B1 VA: 0x328E5B0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x328F740 Offset: 0x328F841 VA: 0x328F740
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32906C0 Offset: 0x32907C1 VA: 0x32906C0
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3291830 Offset: 0x3291931 VA: 0x3291830
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32928D0 Offset: 0x32929D1 VA: 0x32928D0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3293960 Offset: 0x3293A61 VA: 0x3293960
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32949F0 Offset: 0x3294AF1 VA: 0x32949F0
	|-ReadOnlyCollection<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3295A80 Offset: 0x3295B81 VA: 0x3295A80
	|-ReadOnlyCollection<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3296B10 Offset: 0x3296C11 VA: 0x3296B10
	|-ReadOnlyCollection<uint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3297BA0 Offset: 0x3297CA1 VA: 0x3297BA0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3298C30 Offset: 0x3298D31 VA: 0x3298C30
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3299CC0 Offset: 0x3299DC1 VA: 0x3299CC0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x329AD60 Offset: 0x329AE61 VA: 0x329AD60
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x329BE00 Offset: 0x329BF01 VA: 0x329BE00
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x329CEA0 Offset: 0x329CFA1 VA: 0x329CEA0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x329DF40 Offset: 0x329E041 VA: 0x329DF40
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x329F010 Offset: 0x329F111 VA: 0x329F010
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A0240 Offset: 0x32A0341 VA: 0x32A0240
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A1480 Offset: 0x32A1581 VA: 0x32A1480
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A2560 Offset: 0x32A2661 VA: 0x32A2560
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A3600 Offset: 0x32A3701 VA: 0x32A3600
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A47F0 Offset: 0x32A48F1 VA: 0x32A47F0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A5890 Offset: 0x32A5991 VA: 0x32A5890
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A6A00 Offset: 0x32A6B01 VA: 0x32A6A00
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A7BD0 Offset: 0x32A7CD1 VA: 0x32A7BD0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3178AF0 Offset: 0x3178BF1 VA: 0x3178AF0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3179E80 Offset: 0x3179F81 VA: 0x3179E80
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x317AF50 Offset: 0x317B051 VA: 0x317AF50
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x317BFE0 Offset: 0x317C0E1 VA: 0x317BFE0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x317D080 Offset: 0x317D181 VA: 0x317D080
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x317E1F0 Offset: 0x317E2F1 VA: 0x317E1F0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x317F360 Offset: 0x317F461 VA: 0x317F360
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31804D0 Offset: 0x31805D1 VA: 0x31804D0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31815A0 Offset: 0x31816A1 VA: 0x31815A0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3182670 Offset: 0x3182771 VA: 0x3182670
	|-ReadOnlyCollection<Color>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3183A00 Offset: 0x3183B01 VA: 0x3183A00
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3184CD0 Offset: 0x3184DD1 VA: 0x3184CD0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3185DA0 Offset: 0x3185EA1 VA: 0x3185DA0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3186F10 Offset: 0x3187011 VA: 0x3186F10
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31880E0 Offset: 0x31881E1 VA: 0x31880E0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31891C0 Offset: 0x31892C1 VA: 0x31891C0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x318A3F0 Offset: 0x318A4F1 VA: 0x318A3F0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x318B5B0 Offset: 0x318B6B1 VA: 0x318B5B0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x318C650 Offset: 0x318C751 VA: 0x318C650
	|-ReadOnlyCollection<Playable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x318D7C0 Offset: 0x318D8C1 VA: 0x318D7C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x318E860 Offset: 0x318E961 VA: 0x318E860
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x318F8F0 Offset: 0x318F9F1 VA: 0x318F8F0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31909C0 Offset: 0x3190AC1 VA: 0x31909C0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3191A50 Offset: 0x3191B51 VA: 0x3191A50
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3192C40 Offset: 0x3192D41 VA: 0x3192C40
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3193E80 Offset: 0x3193F81 VA: 0x3193E80
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3194F60 Offset: 0x3195061 VA: 0x3194F60
	|-ReadOnlyCollection<Rect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3196000 Offset: 0x3196101 VA: 0x3196000
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31970A0 Offset: 0x31971A1 VA: 0x31970A0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3198470 Offset: 0x3198571 VA: 0x3198470
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3199540 Offset: 0x3199641 VA: 0x3199540
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x319A6B0 Offset: 0x319A7B1 VA: 0x319A6B0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x319B820 Offset: 0x319B921 VA: 0x319B820
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x319C9F0 Offset: 0x319CAF1 VA: 0x319C9F0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E83AB0 Offset: 0x2E83BB1 VA: 0x2E83AB0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E84C80 Offset: 0x2E84D81 VA: 0x2E84C80
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E85D30 Offset: 0x2E85E31 VA: 0x2E85D30
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E86F00 Offset: 0x2E87001 VA: 0x2E86F00
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E88080 Offset: 0x2E88181 VA: 0x2E88080
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E891F0 Offset: 0x2E892F1 VA: 0x2E891F0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E8A360 Offset: 0x2E8A461 VA: 0x2E8A360
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E8B430 Offset: 0x2E8B531 VA: 0x2E8B430
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E8C4D0 Offset: 0x2E8C5D1 VA: 0x2E8C4D0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E8D570 Offset: 0x2E8D671 VA: 0x2E8D570
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E8E870 Offset: 0x2E8E971 VA: 0x2E8E870
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E8FA00 Offset: 0x2E8FB01 VA: 0x2E8FA00
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E90AB0 Offset: 0x2E90BB1 VA: 0x2E90AB0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E91B40 Offset: 0x2E91C41 VA: 0x2E91B40
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E92C10 Offset: 0x2E92D11 VA: 0x2E92C10
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E93CE0 Offset: 0x2E93DE1 VA: 0x2E93CE0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E94DB0 Offset: 0x2E94EB1 VA: 0x2E94DB0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E96180 Offset: 0x2E96281 VA: 0x2E96180
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E97240 Offset: 0x2E97341 VA: 0x2E97240
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2E983B0 Offset: 0x2E984B1 VA: 0x2E983B0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9BE0 Offset: 0x2EE9CE1 VA: 0x2EE9BE0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EEAFE0 Offset: 0x2EEB0E1 VA: 0x2EEAFE0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EEC080 Offset: 0x2EEC181 VA: 0x2EEC080
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EED120 Offset: 0x2EED221 VA: 0x2EED120
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EEE1F0 Offset: 0x2EEE2F1 VA: 0x2EEE1F0
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EEF290 Offset: 0x2EEF391 VA: 0x2EEF290
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF0320 Offset: 0x2EF0421 VA: 0x2EF0320
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF13B0 Offset: 0x2EF14B1 VA: 0x2EF13B0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF2590 Offset: 0x2EF2691 VA: 0x2EF2590
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF3790 Offset: 0x2EF3891 VA: 0x2EF3790
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF4970 Offset: 0x2EF4A71 VA: 0x2EF4970
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF5A00 Offset: 0x2EF5B01 VA: 0x2EF5A00
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF6B70 Offset: 0x2EF6C71 VA: 0x2EF6B70
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF7CE0 Offset: 0x2EF7DE1 VA: 0x2EF7CE0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF8D80 Offset: 0x2EF8E81 VA: 0x2EF8D80
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EF9E20 Offset: 0x2EF9F21 VA: 0x2EF9E20
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EFB020 Offset: 0x2EFB121 VA: 0x2EFB020
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EFC200 Offset: 0x2EFC301 VA: 0x2EFC200
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2EFD2A0 Offset: 0x2EFD3A1 VA: 0x2EFD2A0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Insert
	|
	|-RVA: 0x32E7310 Offset: 0x32E7411 VA: 0x32E7310
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.Insert
	|
	|-RVA: 0x32E8480 Offset: 0x32E8581 VA: 0x32E8480
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.Insert
	|
	|-RVA: 0x32E9550 Offset: 0x32E9651 VA: 0x32E9550
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.Insert
	|
	|-RVA: 0x32EA6C0 Offset: 0x32EA7C1 VA: 0x32EA6C0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.Insert
	|
	|-RVA: 0x32EB760 Offset: 0x32EB861 VA: 0x32EB760
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Insert
	|
	|-RVA: 0x32EC800 Offset: 0x32EC901 VA: 0x32EC800
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.Insert
	|
	|-RVA: 0x32ED9E0 Offset: 0x32EDAE1 VA: 0x32ED9E0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.Insert
	|
	|-RVA: 0x32EEAB0 Offset: 0x32EEBB1 VA: 0x32EEAB0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.Insert
	|
	|-RVA: 0x32EFB40 Offset: 0x32EFC41 VA: 0x32EFB40
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F0C10 Offset: 0x32F0D11 VA: 0x32F0C10
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F1D80 Offset: 0x32F1E81 VA: 0x32F1D80
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F2EF0 Offset: 0x32F2FF1 VA: 0x32F2EF0
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F41B0 Offset: 0x32F42B1 VA: 0x32F41B0
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F5250 Offset: 0x32F5351 VA: 0x32F5250
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F62E0 Offset: 0x32F63E1 VA: 0x32F62E0
	|-ReadOnlyCollection<byte>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F7370 Offset: 0x32F7471 VA: 0x32F7370
	|-ReadOnlyCollection<char>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F8410 Offset: 0x32F8511 VA: 0x32F8410
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32F94B0 Offset: 0x32F95B1 VA: 0x32F94B0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32FA550 Offset: 0x32FA651 VA: 0x32FA550
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32FB5E0 Offset: 0x32FB6E1 VA: 0x32FB5E0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Insert
	|
	|-RVA: 0x32FC670 Offset: 0x32FC771 VA: 0x32FC670
	|-ReadOnlyCollection<double>.System.Collections.IList.Insert
	|
	|-RVA: 0x32FD700 Offset: 0x32FD801 VA: 0x32FD700
	|-ReadOnlyCollection<short>.System.Collections.IList.Insert
	|
	|-RVA: 0x32FE790 Offset: 0x32FE891 VA: 0x32FE790
	|-ReadOnlyCollection<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x32FF820 Offset: 0x32FF921 VA: 0x32FF820
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x33008B0 Offset: 0x33009B1 VA: 0x33008B0
	|-ReadOnlyCollection<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x3301950 Offset: 0x3301A51 VA: 0x3301950
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x33029E0 Offset: 0x3302AE1 VA: 0x33029E0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3303BE0 Offset: 0x3303CE1 VA: 0x3303BE0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3304DE0 Offset: 0x3304EE1 VA: 0x3304DE0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3305E70 Offset: 0x3305F71 VA: 0x3305E70
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3307020 Offset: 0x3307121 VA: 0x3307020
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3308100 Offset: 0x3308201 VA: 0x3308100
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.Insert
	|
	|-RVA: 0x33092B0 Offset: 0x33093B1 VA: 0x33092B0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.Insert
	|
	|-RVA: 0x330A460 Offset: 0x330A561 VA: 0x330A460
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3284AA0 Offset: 0x3284BA1 VA: 0x3284AA0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3285DA0 Offset: 0x3285EA1 VA: 0x3285DA0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3286F50 Offset: 0x3287051 VA: 0x3286F50
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3288030 Offset: 0x3288131 VA: 0x3288030
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32891E0 Offset: 0x32892E1 VA: 0x32891E0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.Insert
	|
	|-RVA: 0x328A390 Offset: 0x328A491 VA: 0x328A390
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.Insert
	|
	|-RVA: 0x328B470 Offset: 0x328B571 VA: 0x328B470
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.Insert
	|
	|-RVA: 0x328C550 Offset: 0x328C651 VA: 0x328C550
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x328D5F0 Offset: 0x328D6F1 VA: 0x328D5F0
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.Insert
	|
	|-RVA: 0x328E690 Offset: 0x328E791 VA: 0x328E690
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x328F840 Offset: 0x328F941 VA: 0x328F840
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32907A0 Offset: 0x32908A1 VA: 0x32907A0
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x3291910 Offset: 0x3291A11 VA: 0x3291910
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x32929B0 Offset: 0x3292AB1 VA: 0x32929B0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x3293A40 Offset: 0x3293B41 VA: 0x3293A40
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Insert
	|
	|-RVA: 0x3294AD0 Offset: 0x3294BD1 VA: 0x3294AD0
	|-ReadOnlyCollection<float>.System.Collections.IList.Insert
	|
	|-RVA: 0x3295B60 Offset: 0x3295C61 VA: 0x3295B60
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Insert
	|
	|-RVA: 0x3296BF0 Offset: 0x3296CF1 VA: 0x3296BF0
	|-ReadOnlyCollection<uint>.System.Collections.IList.Insert
	|
	|-RVA: 0x3297C80 Offset: 0x3297D81 VA: 0x3297C80
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Insert
	|
	|-RVA: 0x3298D10 Offset: 0x3298E11 VA: 0x3298D10
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3299DA0 Offset: 0x3299EA1 VA: 0x3299DA0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x329AE40 Offset: 0x329AF41 VA: 0x329AE40
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x329BEE0 Offset: 0x329BFE1 VA: 0x329BEE0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x329CF80 Offset: 0x329D081 VA: 0x329CF80
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x329E020 Offset: 0x329E121 VA: 0x329E020
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x329F0F0 Offset: 0x329F1F1 VA: 0x329F0F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A0330 Offset: 0x32A0431 VA: 0x32A0330
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A1570 Offset: 0x32A1671 VA: 0x32A1570
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A2640 Offset: 0x32A2741 VA: 0x32A2640
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A36E0 Offset: 0x32A37E1 VA: 0x32A36E0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A48E0 Offset: 0x32A49E1 VA: 0x32A48E0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A5970 Offset: 0x32A5A71 VA: 0x32A5970
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A6AE0 Offset: 0x32A6BE1 VA: 0x32A6AE0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A7CC0 Offset: 0x32A7DC1 VA: 0x32A7CC0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3178BD0 Offset: 0x3178CD1 VA: 0x3178BD0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Insert
	|
	|-RVA: 0x3179F90 Offset: 0x317A091 VA: 0x3179F90
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Insert
	|
	|-RVA: 0x317B030 Offset: 0x317B131 VA: 0x317B030
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Insert
	|
	|-RVA: 0x317C0C0 Offset: 0x317C1C1 VA: 0x317C0C0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x317D160 Offset: 0x317D261 VA: 0x317D160
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|
	|-RVA: 0x317E2D0 Offset: 0x317E3D1 VA: 0x317E2D0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Insert
	|
	|-RVA: 0x317F440 Offset: 0x317F541 VA: 0x317F440
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Insert
	|
	|-RVA: 0x31805B0 Offset: 0x31806B1 VA: 0x31805B0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3181680 Offset: 0x3181781 VA: 0x3181680
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Insert
	|
	|-RVA: 0x3182750 Offset: 0x3182851 VA: 0x3182750
	|-ReadOnlyCollection<Color>.System.Collections.IList.Insert
	|
	|-RVA: 0x3183B10 Offset: 0x3183C11 VA: 0x3183B10
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Insert
	|
	|-RVA: 0x3184DD0 Offset: 0x3184ED1 VA: 0x3184DD0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Insert
	|
	|-RVA: 0x3185E80 Offset: 0x3185F81 VA: 0x3185E80
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.Insert
	|
	|-RVA: 0x3186FF0 Offset: 0x31870F1 VA: 0x3186FF0
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.Insert
	|
	|-RVA: 0x31881D0 Offset: 0x31882D1 VA: 0x31881D0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.Insert
	|
	|-RVA: 0x31892A0 Offset: 0x31893A1 VA: 0x31892A0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.Insert
	|
	|-RVA: 0x318A4E0 Offset: 0x318A5E1 VA: 0x318A4E0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Insert
	|
	|-RVA: 0x318B690 Offset: 0x318B791 VA: 0x318B690
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Insert
	|
	|-RVA: 0x318C730 Offset: 0x318C831 VA: 0x318C730
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Insert
	|
	|-RVA: 0x318D8A0 Offset: 0x318D9A1 VA: 0x318D8A0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Insert
	|
	|-RVA: 0x318E940 Offset: 0x318EA41 VA: 0x318E940
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.Insert
	|
	|-RVA: 0x318F9D0 Offset: 0x318FAD1 VA: 0x318F9D0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Insert
	|
	|-RVA: 0x3190AA0 Offset: 0x3190BA1 VA: 0x3190AA0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Insert
	|
	|-RVA: 0x3191B30 Offset: 0x3191C31 VA: 0x3191B30
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3192D30 Offset: 0x3192E31 VA: 0x3192D30
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Insert
	|
	|-RVA: 0x3193F70 Offset: 0x3194071 VA: 0x3193F70
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Insert
	|
	|-RVA: 0x3195040 Offset: 0x3195141 VA: 0x3195040
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Insert
	|
	|-RVA: 0x31960E0 Offset: 0x31961E1 VA: 0x31960E0
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x3197180 Offset: 0x3197281 VA: 0x3197180
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3198580 Offset: 0x3198681 VA: 0x3198580
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Insert
	|
	|-RVA: 0x3199620 Offset: 0x3199721 VA: 0x3199620
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Insert
	|
	|-RVA: 0x319A790 Offset: 0x319A891 VA: 0x319A790
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x319B900 Offset: 0x319BA01 VA: 0x319B900
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Insert
	|
	|-RVA: 0x319CAE0 Offset: 0x319CBE1 VA: 0x319CAE0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E83B90 Offset: 0x2E83C91 VA: 0x2E83B90
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E84D70 Offset: 0x2E84E71 VA: 0x2E84D70
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E85E10 Offset: 0x2E85F11 VA: 0x2E85E10
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E86FF0 Offset: 0x2E870F1 VA: 0x2E86FF0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E88160 Offset: 0x2E88261 VA: 0x2E88160
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E892D0 Offset: 0x2E893D1 VA: 0x2E892D0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E8A440 Offset: 0x2E8A541 VA: 0x2E8A440
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E8B510 Offset: 0x2E8B611 VA: 0x2E8B510
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E8C5B0 Offset: 0x2E8C6B1 VA: 0x2E8C5B0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E8D650 Offset: 0x2E8D751 VA: 0x2E8D650
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E8E970 Offset: 0x2E8EA71 VA: 0x2E8E970
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E8FAE0 Offset: 0x2E8FBE1 VA: 0x2E8FAE0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E90B90 Offset: 0x2E90C91 VA: 0x2E90B90
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E91C20 Offset: 0x2E91D21 VA: 0x2E91C20
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E92CF0 Offset: 0x2E92DF1 VA: 0x2E92CF0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E93DC0 Offset: 0x2E93EC1 VA: 0x2E93DC0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E94E90 Offset: 0x2E94F91 VA: 0x2E94E90
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E96290 Offset: 0x2E96391 VA: 0x2E96290
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E97320 Offset: 0x2E97421 VA: 0x2E97320
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x2E98490 Offset: 0x2E98591 VA: 0x2E98490
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9BF0 Offset: 0x2EE9CF1 VA: 0x2EE9BF0
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EEAFF0 Offset: 0x2EEB0F1 VA: 0x2EEAFF0
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EEC090 Offset: 0x2EEC191 VA: 0x2EEC090
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EED130 Offset: 0x2EED231 VA: 0x2EED130
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EEE200 Offset: 0x2EEE301 VA: 0x2EEE200
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EEF2A0 Offset: 0x2EEF3A1 VA: 0x2EEF2A0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF0330 Offset: 0x2EF0431 VA: 0x2EF0330
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF13C0 Offset: 0x2EF14C1 VA: 0x2EF13C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF25A0 Offset: 0x2EF26A1 VA: 0x2EF25A0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF37A0 Offset: 0x2EF38A1 VA: 0x2EF37A0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF4980 Offset: 0x2EF4A81 VA: 0x2EF4980
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF5A10 Offset: 0x2EF5B11 VA: 0x2EF5A10
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF6B80 Offset: 0x2EF6C81 VA: 0x2EF6B80
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF7CF0 Offset: 0x2EF7DF1 VA: 0x2EF7CF0
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF8D90 Offset: 0x2EF8E91 VA: 0x2EF8D90
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EF9E30 Offset: 0x2EF9F31 VA: 0x2EF9E30
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EFB030 Offset: 0x2EFB131 VA: 0x2EFB030
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EFC210 Offset: 0x2EFC311 VA: 0x2EFC210
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2EFD2B0 Offset: 0x2EFD3B1 VA: 0x2EFD2B0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Remove
	|
	|-RVA: 0x32E7320 Offset: 0x32E7421 VA: 0x32E7320
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.Remove
	|
	|-RVA: 0x32E8490 Offset: 0x32E8591 VA: 0x32E8490
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.Remove
	|
	|-RVA: 0x32E9560 Offset: 0x32E9661 VA: 0x32E9560
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.Remove
	|
	|-RVA: 0x32EA6D0 Offset: 0x32EA7D1 VA: 0x32EA6D0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.Remove
	|
	|-RVA: 0x32EB770 Offset: 0x32EB871 VA: 0x32EB770
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Remove
	|
	|-RVA: 0x32EC810 Offset: 0x32EC911 VA: 0x32EC810
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.Remove
	|
	|-RVA: 0x32ED9F0 Offset: 0x32EDAF1 VA: 0x32ED9F0
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.Remove
	|
	|-RVA: 0x32EEAC0 Offset: 0x32EEBC1 VA: 0x32EEAC0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.Remove
	|
	|-RVA: 0x32EFB50 Offset: 0x32EFC51 VA: 0x32EFB50
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F0C20 Offset: 0x32F0D21 VA: 0x32F0C20
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F1D90 Offset: 0x32F1E91 VA: 0x32F1D90
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F2F00 Offset: 0x32F3001 VA: 0x32F2F00
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F41C0 Offset: 0x32F42C1 VA: 0x32F41C0
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F5260 Offset: 0x32F5361 VA: 0x32F5260
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F62F0 Offset: 0x32F63F1 VA: 0x32F62F0
	|-ReadOnlyCollection<byte>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F7380 Offset: 0x32F7481 VA: 0x32F7380
	|-ReadOnlyCollection<char>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F8420 Offset: 0x32F8521 VA: 0x32F8420
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32F94C0 Offset: 0x32F95C1 VA: 0x32F94C0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32FA560 Offset: 0x32FA661 VA: 0x32FA560
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32FB5F0 Offset: 0x32FB6F1 VA: 0x32FB5F0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Remove
	|
	|-RVA: 0x32FC680 Offset: 0x32FC781 VA: 0x32FC680
	|-ReadOnlyCollection<double>.System.Collections.IList.Remove
	|
	|-RVA: 0x32FD710 Offset: 0x32FD811 VA: 0x32FD710
	|-ReadOnlyCollection<short>.System.Collections.IList.Remove
	|
	|-RVA: 0x32FE7A0 Offset: 0x32FE8A1 VA: 0x32FE7A0
	|-ReadOnlyCollection<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x32FF830 Offset: 0x32FF931 VA: 0x32FF830
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x33008C0 Offset: 0x33009C1 VA: 0x33008C0
	|-ReadOnlyCollection<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x3301960 Offset: 0x3301A61 VA: 0x3301960
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x33029F0 Offset: 0x3302AF1 VA: 0x33029F0
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3303BF0 Offset: 0x3303CF1 VA: 0x3303BF0
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3304DF0 Offset: 0x3304EF1 VA: 0x3304DF0
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3305E80 Offset: 0x3305F81 VA: 0x3305E80
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3307030 Offset: 0x3307131 VA: 0x3307030
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3308110 Offset: 0x3308211 VA: 0x3308110
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.Remove
	|
	|-RVA: 0x33092C0 Offset: 0x33093C1 VA: 0x33092C0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.Remove
	|
	|-RVA: 0x330A470 Offset: 0x330A571 VA: 0x330A470
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3284AB0 Offset: 0x3284BB1 VA: 0x3284AB0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3285DB0 Offset: 0x3285EB1 VA: 0x3285DB0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3286F60 Offset: 0x3287061 VA: 0x3286F60
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3288040 Offset: 0x3288141 VA: 0x3288040
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32891F0 Offset: 0x32892F1 VA: 0x32891F0
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.Remove
	|
	|-RVA: 0x328A3A0 Offset: 0x328A4A1 VA: 0x328A3A0
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.Remove
	|
	|-RVA: 0x328B480 Offset: 0x328B581 VA: 0x328B480
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.Remove
	|
	|-RVA: 0x328C560 Offset: 0x328C661 VA: 0x328C560
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x328D600 Offset: 0x328D701 VA: 0x328D600
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.Remove
	|
	|-RVA: 0x328E6A0 Offset: 0x328E7A1 VA: 0x328E6A0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x328F850 Offset: 0x328F951 VA: 0x328F850
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32907B0 Offset: 0x32908B1 VA: 0x32907B0
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x3291920 Offset: 0x3291A21 VA: 0x3291920
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x32929C0 Offset: 0x3292AC1 VA: 0x32929C0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x3293A50 Offset: 0x3293B51 VA: 0x3293A50
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Remove
	|
	|-RVA: 0x3294AE0 Offset: 0x3294BE1 VA: 0x3294AE0
	|-ReadOnlyCollection<float>.System.Collections.IList.Remove
	|
	|-RVA: 0x3295B70 Offset: 0x3295C71 VA: 0x3295B70
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Remove
	|
	|-RVA: 0x3296C00 Offset: 0x3296D01 VA: 0x3296C00
	|-ReadOnlyCollection<uint>.System.Collections.IList.Remove
	|
	|-RVA: 0x3297C90 Offset: 0x3297D91 VA: 0x3297C90
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Remove
	|
	|-RVA: 0x3298D20 Offset: 0x3298E21 VA: 0x3298D20
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3299DB0 Offset: 0x3299EB1 VA: 0x3299DB0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x329AE50 Offset: 0x329AF51 VA: 0x329AE50
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x329BEF0 Offset: 0x329BFF1 VA: 0x329BEF0
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x329CF90 Offset: 0x329D091 VA: 0x329CF90
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x329E030 Offset: 0x329E131 VA: 0x329E030
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x329F100 Offset: 0x329F201 VA: 0x329F100
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A0340 Offset: 0x32A0441 VA: 0x32A0340
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A1580 Offset: 0x32A1681 VA: 0x32A1580
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A2650 Offset: 0x32A2751 VA: 0x32A2650
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A36F0 Offset: 0x32A37F1 VA: 0x32A36F0
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A48F0 Offset: 0x32A49F1 VA: 0x32A48F0
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A5980 Offset: 0x32A5A81 VA: 0x32A5980
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A6AF0 Offset: 0x32A6BF1 VA: 0x32A6AF0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Remove
	|
	|-RVA: 0x32A7CD0 Offset: 0x32A7DD1 VA: 0x32A7CD0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3178BE0 Offset: 0x3178CE1 VA: 0x3178BE0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Remove
	|
	|-RVA: 0x3179FA0 Offset: 0x317A0A1 VA: 0x3179FA0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Remove
	|
	|-RVA: 0x317B040 Offset: 0x317B141 VA: 0x317B040
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.Remove
	|
	|-RVA: 0x317C0D0 Offset: 0x317C1D1 VA: 0x317C0D0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x317D170 Offset: 0x317D271 VA: 0x317D170
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|
	|-RVA: 0x317E2E0 Offset: 0x317E3E1 VA: 0x317E2E0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.Remove
	|
	|-RVA: 0x317F450 Offset: 0x317F551 VA: 0x317F450
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Remove
	|
	|-RVA: 0x31805C0 Offset: 0x31806C1 VA: 0x31805C0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3181690 Offset: 0x3181791 VA: 0x3181690
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Remove
	|
	|-RVA: 0x3182760 Offset: 0x3182861 VA: 0x3182760
	|-ReadOnlyCollection<Color>.System.Collections.IList.Remove
	|
	|-RVA: 0x3183B20 Offset: 0x3183C21 VA: 0x3183B20
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Remove
	|
	|-RVA: 0x3184DE0 Offset: 0x3184EE1 VA: 0x3184DE0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Remove
	|
	|-RVA: 0x3185E90 Offset: 0x3185F91 VA: 0x3185E90
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.Remove
	|
	|-RVA: 0x3187000 Offset: 0x3187101 VA: 0x3187000
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.Remove
	|
	|-RVA: 0x31881E0 Offset: 0x31882E1 VA: 0x31881E0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.Remove
	|
	|-RVA: 0x31892B0 Offset: 0x31893B1 VA: 0x31892B0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.Remove
	|
	|-RVA: 0x318A4F0 Offset: 0x318A5F1 VA: 0x318A4F0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Remove
	|
	|-RVA: 0x318B6A0 Offset: 0x318B7A1 VA: 0x318B6A0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.Remove
	|
	|-RVA: 0x318C740 Offset: 0x318C841 VA: 0x318C740
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Remove
	|
	|-RVA: 0x318D8B0 Offset: 0x318D9B1 VA: 0x318D8B0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Remove
	|
	|-RVA: 0x318E950 Offset: 0x318EA51 VA: 0x318E950
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.Remove
	|
	|-RVA: 0x318F9E0 Offset: 0x318FAE1 VA: 0x318F9E0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Remove
	|
	|-RVA: 0x3190AB0 Offset: 0x3190BB1 VA: 0x3190AB0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Remove
	|
	|-RVA: 0x3191B40 Offset: 0x3191C41 VA: 0x3191B40
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3192D40 Offset: 0x3192E41 VA: 0x3192D40
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Remove
	|
	|-RVA: 0x3193F80 Offset: 0x3194081 VA: 0x3193F80
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Remove
	|
	|-RVA: 0x3195050 Offset: 0x3195151 VA: 0x3195050
	|-ReadOnlyCollection<Rect>.System.Collections.IList.Remove
	|
	|-RVA: 0x31960F0 Offset: 0x31961F1 VA: 0x31960F0
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x3197190 Offset: 0x3197291 VA: 0x3197190
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x3198590 Offset: 0x3198691 VA: 0x3198590
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.Remove
	|
	|-RVA: 0x3199630 Offset: 0x3199731 VA: 0x3199630
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.Remove
	|
	|-RVA: 0x319A7A0 Offset: 0x319A8A1 VA: 0x319A7A0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x319B910 Offset: 0x319BA11 VA: 0x319B910
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Remove
	|
	|-RVA: 0x319CAF0 Offset: 0x319CBF1 VA: 0x319CAF0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E83BA0 Offset: 0x2E83CA1 VA: 0x2E83BA0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E84D80 Offset: 0x2E84E81 VA: 0x2E84D80
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E85E20 Offset: 0x2E85F21 VA: 0x2E85E20
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E87000 Offset: 0x2E87101 VA: 0x2E87000
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E88170 Offset: 0x2E88271 VA: 0x2E88170
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E892E0 Offset: 0x2E893E1 VA: 0x2E892E0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E8A450 Offset: 0x2E8A551 VA: 0x2E8A450
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E8B520 Offset: 0x2E8B621 VA: 0x2E8B520
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E8C5C0 Offset: 0x2E8C6C1 VA: 0x2E8C5C0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E8D660 Offset: 0x2E8D761 VA: 0x2E8D660
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E8E980 Offset: 0x2E8EA81 VA: 0x2E8E980
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E8FAF0 Offset: 0x2E8FBF1 VA: 0x2E8FAF0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E90BA0 Offset: 0x2E90CA1 VA: 0x2E90BA0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E91C30 Offset: 0x2E91D31 VA: 0x2E91C30
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E92D00 Offset: 0x2E92E01 VA: 0x2E92D00
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E93DD0 Offset: 0x2E93ED1 VA: 0x2E93DD0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E94EA0 Offset: 0x2E94FA1 VA: 0x2E94EA0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E962A0 Offset: 0x2E963A1 VA: 0x2E962A0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E97330 Offset: 0x2E97431 VA: 0x2E97330
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x2E984A0 Offset: 0x2E985A1 VA: 0x2E984A0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EE9C00 Offset: 0x2EE9D01 VA: 0x2EE9C00
	|-ReadOnlyCollection<AS_ToolController.ChargeInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EEB000 Offset: 0x2EEB101 VA: 0x2EEB000
	|-ReadOnlyCollection<BuildItemData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EEC0A0 Offset: 0x2EEC1A1 VA: 0x2EEC0A0
	|-ReadOnlyCollection<ButtonLinker.LinkObject>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EED140 Offset: 0x2EED241 VA: 0x2EED140
	|-ReadOnlyCollection<CharaCallTable.BustupTable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EEE210 Offset: 0x2EEE311 VA: 0x2EEE210
	|-ReadOnlyCollection<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EEF2B0 Offset: 0x2EEF3B1 VA: 0x2EEF2B0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF0340 Offset: 0x2EF0441 VA: 0x2EF0340
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF13D0 Offset: 0x2EF14D1 VA: 0x2EF13D0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF25B0 Offset: 0x2EF26B1 VA: 0x2EF25B0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF37B0 Offset: 0x2EF38B1 VA: 0x2EF37B0
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF4990 Offset: 0x2EF4A91 VA: 0x2EF4990
	|-ReadOnlyCollection<CropDataTable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF5A20 Offset: 0x2EF5B21 VA: 0x2EF5A20
	|-ReadOnlyCollection<DropItemParam>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF6B90 Offset: 0x2EF6C91 VA: 0x2EF6B90
	|-ReadOnlyCollection<ErosionBrush.UndoStep>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF7D00 Offset: 0x2EF7E01 VA: 0x2EF7D00
	|-ReadOnlyCollection<EventCheckId>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF8DA0 Offset: 0x2EF8EA1 VA: 0x2EF8DA0
	|-ReadOnlyCollection<EventFlagProgressData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EF9E40 Offset: 0x2EF9F41 VA: 0x2EF9E40
	|-ReadOnlyCollection<FesNpcScoreData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EFB040 Offset: 0x2EFB141 VA: 0x2EFB040
	|-ReadOnlyCollection<MiningPointSaveData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EFC220 Offset: 0x2EFC321 VA: 0x2EFC220
	|-ReadOnlyCollection<MonsterHutSaveData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2EFD2C0 Offset: 0x2EFD3C1 VA: 0x2EFD2C0
	|-ReadOnlyCollection<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32E7330 Offset: 0x32E7431 VA: 0x32E7330
	|-ReadOnlyCollection<NPCActionData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32E84A0 Offset: 0x32E85A1 VA: 0x32E84A0
	|-ReadOnlyCollection<NpcPlaceSchedule>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32E9570 Offset: 0x32E9671 VA: 0x32E9570
	|-ReadOnlyCollection<OrderLotterySaveParameter>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32EA6E0 Offset: 0x32EA7E1 VA: 0x32EA6E0
	|-ReadOnlyCollection<OrderSaveParameter>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32EB780 Offset: 0x32EB881 VA: 0x32EB780
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32EC820 Offset: 0x32EC921 VA: 0x32EC820
	|-ReadOnlyCollection<ShopCatalogPage>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32EDA00 Offset: 0x32EDB01 VA: 0x32EDA00
	|-ReadOnlyCollection<ShopNpcTalk>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32EEAD0 Offset: 0x32EEBD1 VA: 0x32EEAD0
	|-ReadOnlyCollection<SubtitleDataTable.Data>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32EFB60 Offset: 0x32EFC61 VA: 0x32EFB60
	|-ReadOnlyCollection<SubtitleDataTable.DataList>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F0C30 Offset: 0x32F0D31 VA: 0x32F0C30
	|-ReadOnlyCollection<SubtitleHudDataTable.Data>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F1DA0 Offset: 0x32F1EA1 VA: 0x32F1DA0
	|-ReadOnlyCollection<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F2F10 Offset: 0x32F3011 VA: 0x32F2F10
	|-ReadOnlyCollection<Schedule>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F41D0 Offset: 0x32F42D1 VA: 0x32F41D0
	|-ReadOnlyCollection<CurveSample>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F5270 Offset: 0x32F5371 VA: 0x32F5270
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F6300 Offset: 0x32F6401 VA: 0x32F6300
	|-ReadOnlyCollection<byte>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F7390 Offset: 0x32F7491 VA: 0x32F7390
	|-ReadOnlyCollection<char>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F8430 Offset: 0x32F8531 VA: 0x32F8430
	|-ReadOnlyCollection<KeyValuePair<DateTime, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32F94D0 Offset: 0x32F95D1 VA: 0x32F94D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32FA570 Offset: 0x32FA671 VA: 0x32FA570
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32FB600 Offset: 0x32FB701 VA: 0x32FB600
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32FC690 Offset: 0x32FC791 VA: 0x32FC690
	|-ReadOnlyCollection<double>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32FD720 Offset: 0x32FD821 VA: 0x32FD720
	|-ReadOnlyCollection<short>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32FE7B0 Offset: 0x32FE8B1 VA: 0x32FE7B0
	|-ReadOnlyCollection<int>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32FF840 Offset: 0x32FF941 VA: 0x32FF840
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x33008D0 Offset: 0x33009D1 VA: 0x33008D0
	|-ReadOnlyCollection<long>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3301970 Offset: 0x3301A71 VA: 0x3301970
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3302A00 Offset: 0x3302B01 VA: 0x3302A00
	|-ReadOnlyCollection<Nullable<Int32Enum>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3303C00 Offset: 0x3303D01 VA: 0x3303C00
	|-ReadOnlyCollection<Nullable<Bounds>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3304E00 Offset: 0x3304F01 VA: 0x3304E00
	|-ReadOnlyCollection<Nullable<BoundsInt>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3305E90 Offset: 0x3305F91 VA: 0x3305E90
	|-ReadOnlyCollection<Nullable<Color32>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3307040 Offset: 0x3307141 VA: 0x3307040
	|-ReadOnlyCollection<Nullable<Color>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3308120 Offset: 0x3308221 VA: 0x3308120
	|-ReadOnlyCollection<Nullable<GradientAlphaKey>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x33092D0 Offset: 0x33093D1 VA: 0x33092D0
	|-ReadOnlyCollection<Nullable<GradientColorKey>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x330A480 Offset: 0x330A581 VA: 0x330A480
	|-ReadOnlyCollection<Nullable<Keyframe>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3284AC0 Offset: 0x3284BC1 VA: 0x3284AC0
	|-ReadOnlyCollection<Nullable<LayerMask>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3285DC0 Offset: 0x3285EC1 VA: 0x3285DC0
	|-ReadOnlyCollection<Nullable<Matrix4x4>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3286F70 Offset: 0x3287071 VA: 0x3286F70
	|-ReadOnlyCollection<Nullable<Quaternion>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3288050 Offset: 0x3288151 VA: 0x3288050
	|-ReadOnlyCollection<Nullable<RangeInt>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3289200 Offset: 0x3289301 VA: 0x3289200
	|-ReadOnlyCollection<Nullable<Rect>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x328A3B0 Offset: 0x328A4B1 VA: 0x328A3B0
	|-ReadOnlyCollection<Nullable<RectInt>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x328B490 Offset: 0x328B591 VA: 0x328B490
	|-ReadOnlyCollection<Nullable<Vector2>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x328C570 Offset: 0x328C671 VA: 0x328C570
	|-ReadOnlyCollection<Nullable<Vector2Int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x328D610 Offset: 0x328D711 VA: 0x328D610
	|-ReadOnlyCollection<Nullable<Vector3>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x328E6B0 Offset: 0x328E7B1 VA: 0x328E6B0
	|-ReadOnlyCollection<Nullable<Vector3Int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x328F860 Offset: 0x328F961 VA: 0x328F860
	|-ReadOnlyCollection<Nullable<Vector4>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32907C0 Offset: 0x32908C1 VA: 0x32907C0
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3291930 Offset: 0x3291A31 VA: 0x3291930
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32929D0 Offset: 0x3292AD1 VA: 0x32929D0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3293A60 Offset: 0x3293B61 VA: 0x3293A60
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3294AF0 Offset: 0x3294BF1 VA: 0x3294AF0
	|-ReadOnlyCollection<float>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3295B80 Offset: 0x3295C81 VA: 0x3295B80
	|-ReadOnlyCollection<ushort>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3296C10 Offset: 0x3296D11 VA: 0x3296C10
	|-ReadOnlyCollection<uint>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3297CA0 Offset: 0x3297DA1 VA: 0x3297CA0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3298D30 Offset: 0x3298E31 VA: 0x3298D30
	|-ReadOnlyCollection<ValueTuple<bool, Int32Enum>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3299DC0 Offset: 0x3299EC1 VA: 0x3299DC0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x329AE60 Offset: 0x329AF61 VA: 0x329AE60
	|-ReadOnlyCollection<ValueTuple<Int32Enum, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x329BF00 Offset: 0x329C001 VA: 0x329BF00
	|-ReadOnlyCollection<ValueTuple<object, Int32Enum>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x329CFA0 Offset: 0x329D0A1 VA: 0x329CFA0
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x329E040 Offset: 0x329E141 VA: 0x329E040
	|-ReadOnlyCollection<ValueTuple<object, float>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x329F110 Offset: 0x329F211 VA: 0x329F110
	|-ReadOnlyCollection<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A0350 Offset: 0x32A0451 VA: 0x32A0350
	|-ReadOnlyCollection<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A1590 Offset: 0x32A1691 VA: 0x32A1590
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A2660 Offset: 0x32A2761 VA: 0x32A2660
	|-ReadOnlyCollection<TutorialUnlockFlagData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A3700 Offset: 0x32A3801 VA: 0x32A3700
	|-ReadOnlyCollection<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A4900 Offset: 0x32A4A01 VA: 0x32A4900
	|-ReadOnlyCollection<CapEdge>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A5990 Offset: 0x32A5A91 VA: 0x32A5990
	|-ReadOnlyCollection<MeshDataConnectivity.Face>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A6B00 Offset: 0x32A6C01 VA: 0x32A6B00
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x32A7CE0 Offset: 0x32A7DE1 VA: 0x32A7CE0
	|-ReadOnlyCollection<MeshFaceConnectivity.EdgeData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3178BF0 Offset: 0x3178CF1 VA: 0x3178BF0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3179FB0 Offset: 0x317A0B1 VA: 0x3179FB0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x317B050 Offset: 0x317B151 VA: 0x317B050
	|-ReadOnlyCollection<ConstraintSource>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x317C0E0 Offset: 0x317C1E1 VA: 0x317C0E0
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x317D180 Offset: 0x317D281 VA: 0x317D180
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x317E2F0 Offset: 0x317E3F1 VA: 0x317E2F0
	|-ReadOnlyCollection<BoneWeight>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x317F460 Offset: 0x317F561 VA: 0x317F460
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x31805D0 Offset: 0x31806D1 VA: 0x31805D0
	|-ReadOnlyCollection<BoundsInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x31816A0 Offset: 0x31817A1 VA: 0x31816A0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3182770 Offset: 0x3182871 VA: 0x3182770
	|-ReadOnlyCollection<Color>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3183B30 Offset: 0x3183C31 VA: 0x3183B30
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3184DF0 Offset: 0x3184EF1 VA: 0x3184DF0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3185EA0 Offset: 0x3185FA1 VA: 0x3185EA0
	|-ReadOnlyCollection<GradientAlphaKey>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3187010 Offset: 0x3187111 VA: 0x3187010
	|-ReadOnlyCollection<GradientColorKey>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x31881F0 Offset: 0x31882F1 VA: 0x31881F0
	|-ReadOnlyCollection<Keyframe>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x31892C0 Offset: 0x31893C1 VA: 0x31892C0
	|-ReadOnlyCollection<LayerMask>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x318A500 Offset: 0x318A601 VA: 0x318A500
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x318B6B0 Offset: 0x318B7B1 VA: 0x318B6B0
	|-ReadOnlyCollection<ParticleSystem.Particle>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x318C750 Offset: 0x318C851 VA: 0x318C750
	|-ReadOnlyCollection<Playable>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x318D8C0 Offset: 0x318D9C1 VA: 0x318D8C0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x318E960 Offset: 0x318EA61 VA: 0x318E960
	|-ReadOnlyCollection<PlayableGraph>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x318F9F0 Offset: 0x318FAF1 VA: 0x318F9F0
	|-ReadOnlyCollection<Edge>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3190AC0 Offset: 0x3190BC1 VA: 0x3190AC0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3191B50 Offset: 0x3191C51 VA: 0x3191B50
	|-ReadOnlyCollection<RangeInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3192D50 Offset: 0x3192E51 VA: 0x3192D50
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3193F90 Offset: 0x3194091 VA: 0x3193F90
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3195060 Offset: 0x3195161 VA: 0x3195060
	|-ReadOnlyCollection<Rect>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3196100 Offset: 0x3196201 VA: 0x3196100
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x31971A0 Offset: 0x31972A1 VA: 0x31971A0
	|-ReadOnlyCollection<ReflectionProbeBlendInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x31985A0 Offset: 0x31986A1 VA: 0x31985A0
	|-ReadOnlyCollection<SphericalHarmonicsL2>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x3199640 Offset: 0x3199741 VA: 0x3199640
	|-ReadOnlyCollection<VertexAttributeDescriptor>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x319A7B0 Offset: 0x319A8B1 VA: 0x319A7B0
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x319B920 Offset: 0x319BA21 VA: 0x319B920
	|-ReadOnlyCollection<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x319CB00 Offset: 0x319CC01 VA: 0x319CB00
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E83BB0 Offset: 0x2E83CB1 VA: 0x2E83BB0
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E84D90 Offset: 0x2E84E91 VA: 0x2E84D90
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E85E30 Offset: 0x2E85F31 VA: 0x2E85E30
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E87010 Offset: 0x2E87111 VA: 0x2E87010
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E88180 Offset: 0x2E88281 VA: 0x2E88180
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E892F0 Offset: 0x2E893F1 VA: 0x2E892F0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E8A460 Offset: 0x2E8A561 VA: 0x2E8A460
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E8B530 Offset: 0x2E8B631 VA: 0x2E8B530
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E8C5D0 Offset: 0x2E8C6D1 VA: 0x2E8C5D0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E8D670 Offset: 0x2E8D771 VA: 0x2E8D670
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E8E990 Offset: 0x2E8EA91 VA: 0x2E8E990
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E8FB00 Offset: 0x2E8FC01 VA: 0x2E8FB00
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E90BB0 Offset: 0x2E90CB1 VA: 0x2E90BB0
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E91C40 Offset: 0x2E91D41 VA: 0x2E91C40
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E92D10 Offset: 0x2E92E11 VA: 0x2E92D10
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E93DE0 Offset: 0x2E93EE1 VA: 0x2E93DE0
	|-ReadOnlyCollection<Vector3Int>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E94EB0 Offset: 0x2E94FB1 VA: 0x2E94EB0
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E962B0 Offset: 0x2E963B1 VA: 0x2E962B0
	|-ReadOnlyCollection<WarpPoints.WarpPoint>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E97340 Offset: 0x2E97441 VA: 0x2E97340
	|-ReadOnlyCollection<YieldItemParam>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2E984B0 Offset: 0x2E985B1 VA: 0x2E984B0
	|-ReadOnlyCollection<stCommand_t>.System.Collections.IList.RemoveAt
	*/
}

