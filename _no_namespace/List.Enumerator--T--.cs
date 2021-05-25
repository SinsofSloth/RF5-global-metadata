[Serializable]
public struct List.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1463
{
	// Fields
	private List<T> list; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private T current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F4D0 Offset: 0x34F5D1 VA: 0x34F4D0
	|-List.Enumerator<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x34F640 Offset: 0x34F741 VA: 0x34F640
	|-List.Enumerator<BuildItemData>..ctor
	|
	|-RVA: 0x34F820 Offset: 0x34F921 VA: 0x34F820
	|-List.Enumerator<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x34F960 Offset: 0x34FA61 VA: 0x34F960
	|-List.Enumerator<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x34FAA0 Offset: 0x34FBA1 VA: 0x34FAA0
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x34FC00 Offset: 0x34FD01 VA: 0x34FC00
	|-List.Enumerator<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x34FD40 Offset: 0x34FE41 VA: 0x34FD40
	|-List.Enumerator<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x34FE80 Offset: 0x34FF81 VA: 0x34FE80
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x34FFC0 Offset: 0x3500C1 VA: 0x34FFC0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x350140 Offset: 0x350241 VA: 0x350140
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x3502D0 Offset: 0x3503D1 VA: 0x3502D0
	|-List.Enumerator<CropDataTable>..ctor
	|
	|-RVA: 0x3504D0 Offset: 0x3505D1 VA: 0x3504D0
	|-List.Enumerator<DropItemParam>..ctor
	|
	|-RVA: 0x350610 Offset: 0x350711 VA: 0x350610
	|-List.Enumerator<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x350780 Offset: 0x350881 VA: 0x350780
	|-List.Enumerator<EventCheckId>..ctor
	|
	|-RVA: 0x3508F0 Offset: 0x3509F1 VA: 0x3508F0
	|-List.Enumerator<EventFlagProgressData>..ctor
	|
	|-RVA: 0x350A30 Offset: 0x350B31 VA: 0x350A30
	|-List.Enumerator<FesNpcScoreData>..ctor
	|
	|-RVA: 0x350B70 Offset: 0x350C71 VA: 0x350B70
	|-List.Enumerator<MiningPointSaveData>..ctor
	|
	|-RVA: 0x350D00 Offset: 0x350E01 VA: 0x350D00
	|-List.Enumerator<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x350E80 Offset: 0x350F81 VA: 0x350E80
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x350FC0 Offset: 0x3510C1 VA: 0x350FC0
	|-List.Enumerator<NPCActionData>..ctor
	|
	|-RVA: 0x351150 Offset: 0x351251 VA: 0x351150
	|-List.Enumerator<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x3512C0 Offset: 0x3513C1 VA: 0x3512C0
	|-List.Enumerator<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x351420 Offset: 0x351521 VA: 0x351420
	|-List.Enumerator<OrderSaveParameter>..ctor
	|
	|-RVA: 0x351590 Offset: 0x351691 VA: 0x351590
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3516D0 Offset: 0x3517D1 VA: 0x3516D0
	|-List.Enumerator<ShopCatalogPage>..ctor
	|
	|-RVA: 0x351810 Offset: 0x351911 VA: 0x351810
	|-List.Enumerator<ShopNpcTalk>..ctor
	|
	|-RVA: 0x351990 Offset: 0x351A91 VA: 0x351990
	|-List.Enumerator<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x351AF0 Offset: 0x351BF1 VA: 0x351AF0
	|-List.Enumerator<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x351C30 Offset: 0x351D31 VA: 0x351C30
	|-List.Enumerator<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x351D90 Offset: 0x351E91 VA: 0x351D90
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x351F00 Offset: 0x352001 VA: 0x351F00
	|-List.Enumerator<Schedule>..ctor
	|
	|-RVA: 0x352070 Offset: 0x352171 VA: 0x352070
	|-List.Enumerator<CurveSample>..ctor
	|
	|-RVA: 0x352200 Offset: 0x352301 VA: 0x352200
	|-List.Enumerator<bool>..ctor
	|
	|-RVA: 0x352340 Offset: 0x352441 VA: 0x352340
	|-List.Enumerator<byte>..ctor
	|
	|-RVA: 0x352480 Offset: 0x352581 VA: 0x352480
	|-List.Enumerator<char>..ctor
	|
	|-RVA: 0x3525C0 Offset: 0x3526C1 VA: 0x3525C0
	|-List.Enumerator<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x352700 Offset: 0x352801 VA: 0x352700
	|-List.Enumerator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x352840 Offset: 0x352941 VA: 0x352840
	|-List.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x352980 Offset: 0x352A81 VA: 0x352980
	|-List.Enumerator<DateTime>..ctor
	|
	|-RVA: 0x352AC0 Offset: 0x352BC1 VA: 0x352AC0
	|-List.Enumerator<double>..ctor
	|
	|-RVA: 0x352C00 Offset: 0x352D01 VA: 0x352C00
	|-List.Enumerator<short>..ctor
	|
	|-RVA: 0x352D40 Offset: 0x352E41 VA: 0x352D40
	|-List.Enumerator<int>..ctor
	|
	|-RVA: 0x352E80 Offset: 0x352F81 VA: 0x352E80
	|-List.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x352FC0 Offset: 0x3530C1 VA: 0x352FC0
	|-List.Enumerator<long>..ctor
	|
	|-RVA: 0x353100 Offset: 0x353201 VA: 0x353100
	|-List.Enumerator<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x353240 Offset: 0x353341 VA: 0x353240
	|-List.Enumerator<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x353380 Offset: 0x353481 VA: 0x353380
	|-List.Enumerator<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x353500 Offset: 0x353601 VA: 0x353500
	|-List.Enumerator<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x353680 Offset: 0x353781 VA: 0x353680
	|-List.Enumerator<Nullable<Color32>>..ctor
	|
	|-RVA: 0x3537C0 Offset: 0x3538C1 VA: 0x3537C0
	|-List.Enumerator<Nullable<Color>>..ctor
	|
	|-RVA: 0x353930 Offset: 0x353A31 VA: 0x353930
	|-List.Enumerator<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x353A90 Offset: 0x353B91 VA: 0x353A90
	|-List.Enumerator<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x353C00 Offset: 0x353D01 VA: 0x353C00
	|-List.Enumerator<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x353D70 Offset: 0x353E71 VA: 0x353D70
	|-List.Enumerator<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x353EB0 Offset: 0x353FB1 VA: 0x353EB0
	|-List.Enumerator<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x354050 Offset: 0x354151 VA: 0x354050
	|-List.Enumerator<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3541C0 Offset: 0x3542C1 VA: 0x3541C0
	|-List.Enumerator<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x354320 Offset: 0x354421 VA: 0x354320
	|-List.Enumerator<Nullable<Rect>>..ctor
	|
	|-RVA: 0x354490 Offset: 0x354591 VA: 0x354490
	|-List.Enumerator<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x354600 Offset: 0x354701 VA: 0x354600
	|-List.Enumerator<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x354760 Offset: 0x354861 VA: 0x354760
	|-List.Enumerator<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x3548C0 Offset: 0x3549C1 VA: 0x3548C0
	|-List.Enumerator<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x354A00 Offset: 0x354B01 VA: 0x354A00
	|-List.Enumerator<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x31B000 Offset: 0x31B101 VA: 0x31B000
	|-List.Enumerator<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x31B170 Offset: 0x31B271 VA: 0x31B170
	|-List.Enumerator<object>..ctor
	|
	|-RVA: 0x31B320 Offset: 0x31B421 VA: 0x31B320
	|-List.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x31B460 Offset: 0x31B561 VA: 0x31B460
	|-List.Enumerator<float>..ctor
	|
	|-RVA: 0x31B5A0 Offset: 0x31B6A1 VA: 0x31B5A0
	|-List.Enumerator<ushort>..ctor
	|
	|-RVA: 0x31B6E0 Offset: 0x31B7E1 VA: 0x31B6E0
	|-List.Enumerator<uint>..ctor
	|
	|-RVA: 0x31B820 Offset: 0x31B921 VA: 0x31B820
	|-List.Enumerator<ulong>..ctor
	|
	|-RVA: 0x31B960 Offset: 0x31BA61 VA: 0x31B960
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x31BAA0 Offset: 0x31BBA1 VA: 0x31BAA0
	|-List.Enumerator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x31BBE0 Offset: 0x31BCE1 VA: 0x31BBE0
	|-List.Enumerator<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x31BD20 Offset: 0x31BE21 VA: 0x31BD20
	|-List.Enumerator<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x31BE60 Offset: 0x31BF61 VA: 0x31BE60
	|-List.Enumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x31BFA0 Offset: 0x31C0A1 VA: 0x31BFA0
	|-List.Enumerator<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x31C0E0 Offset: 0x31C1E1 VA: 0x31C0E0
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x31C240 Offset: 0x31C341 VA: 0x31C240
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x31C3D0 Offset: 0x31C4D1 VA: 0x31C3D0
	|-List.Enumerator<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x31C560 Offset: 0x31C661 VA: 0x31C560
	|-List.Enumerator<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x31C6C0 Offset: 0x31C7C1 VA: 0x31C6C0
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x31C800 Offset: 0x31C901 VA: 0x31C800
	|-List.Enumerator<CapEdge>..ctor
	|
	|-RVA: 0x31C990 Offset: 0x31CA91 VA: 0x31C990
	|-List.Enumerator<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x31CAD0 Offset: 0x31CBD1 VA: 0x31CAD0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x31CC40 Offset: 0x31CD41 VA: 0x31CC40
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x31CDC0 Offset: 0x31CEC1 VA: 0x31CDC0
	|-List.Enumerator<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x31CF00 Offset: 0x31D001 VA: 0x31CF00
	|-List.Enumerator<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x31D0D0 Offset: 0x31D1D1 VA: 0x31D0D0
	|-List.Enumerator<ConstraintSource>..ctor
	|
	|-RVA: 0x31D210 Offset: 0x31D311 VA: 0x31D210
	|-List.Enumerator<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x31D350 Offset: 0x31D451 VA: 0x31D350
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x31D490 Offset: 0x31D591 VA: 0x31D490
	|-List.Enumerator<BoneWeight>..ctor
	|
	|-RVA: 0x31D600 Offset: 0x31D701 VA: 0x31D600
	|-List.Enumerator<Bounds>..ctor
	|
	|-RVA: 0x31D770 Offset: 0x31D871 VA: 0x31D770
	|-List.Enumerator<BoundsInt>..ctor
	|
	|-RVA: 0x31D8E0 Offset: 0x31D9E1 VA: 0x31D8E0
	|-List.Enumerator<Color32>..ctor
	|
	|-RVA: 0x31DA20 Offset: 0x31DB21 VA: 0x31DA20
	|-List.Enumerator<Color>..ctor
	|
	|-RVA: 0x31DB60 Offset: 0x31DC61 VA: 0x31DB60
	|-List.Enumerator<CombineInstance>..ctor
	|
	|-RVA: 0x31DD30 Offset: 0x31DE31 VA: 0x31DD30
	|-List.Enumerator<RaycastResult>..ctor
	|
	|-RVA: 0x31DEC0 Offset: 0x31DFC1 VA: 0x31DEC0
	|-List.Enumerator<GradientAlphaKey>..ctor
	|
	|-RVA: 0x31E000 Offset: 0x31E101 VA: 0x31E000
	|-List.Enumerator<GradientColorKey>..ctor
	|
	|-RVA: 0x31E170 Offset: 0x31E271 VA: 0x31E170
	|-List.Enumerator<Keyframe>..ctor
	|
	|-RVA: 0x31E2F0 Offset: 0x31E3F1 VA: 0x31E2F0
	|-List.Enumerator<LayerMask>..ctor
	|
	|-RVA: 0x31E430 Offset: 0x31E531 VA: 0x31E430
	|-List.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x31E5C0 Offset: 0x31E6C1 VA: 0x31E5C0
	|-List.Enumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x31E760 Offset: 0x31E861 VA: 0x31E760
	|-List.Enumerator<Playable>..ctor
	|
	|-RVA: 0x31E8A0 Offset: 0x31E9A1 VA: 0x31E8A0
	|-List.Enumerator<PlayableBinding>..ctor
	|
	|-RVA: 0x31EA10 Offset: 0x31EB11 VA: 0x31EA10
	|-List.Enumerator<PlayableGraph>..ctor
	|
	|-RVA: 0x31EB50 Offset: 0x31EC51 VA: 0x31EB50
	|-List.Enumerator<Edge>..ctor
	|
	|-RVA: 0x31EC90 Offset: 0x31ED91 VA: 0x31EC90
	|-List.Enumerator<Quaternion>..ctor
	|
	|-RVA: 0x31EDD0 Offset: 0x31EED1 VA: 0x31EDD0
	|-List.Enumerator<RangeInt>..ctor
	|
	|-RVA: 0x31EF10 Offset: 0x31F011 VA: 0x31EF10
	|-List.Enumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x31F0A0 Offset: 0x31F1A1 VA: 0x31F0A0
	|-List.Enumerator<RaycastHit>..ctor
	|
	|-RVA: 0x31F230 Offset: 0x31F331 VA: 0x31F230
	|-List.Enumerator<Rect>..ctor
	|
	|-RVA: 0x31F370 Offset: 0x31F471 VA: 0x31F370
	|-List.Enumerator<RectInt>..ctor
	|
	|-RVA: 0x31F4B0 Offset: 0x31F5B1 VA: 0x31F4B0
	|-List.Enumerator<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x31F5F0 Offset: 0x31F6F1 VA: 0x31F5F0
	|-List.Enumerator<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x31F7D0 Offset: 0x31F8D1 VA: 0x31F7D0
	|-List.Enumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x31F910 Offset: 0x31FA11 VA: 0x31F910
	|-List.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x31FA80 Offset: 0x31FB81 VA: 0x31FA80
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x31FBF0 Offset: 0x31FCF1 VA: 0x31FBF0
	|-List.Enumerator<DiagnosticEvent>..ctor
	|
	|-RVA: 0x31FD70 Offset: 0x31FE71 VA: 0x31FD70
	|-List.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x31FEE0 Offset: 0x31FFE1 VA: 0x31FEE0
	|-List.Enumerator<ObjectInitializationData>..ctor
	|
	|-RVA: 0x320060 Offset: 0x320161 VA: 0x320060
	|-List.Enumerator<GlyphRect>..ctor
	|
	|-RVA: 0x3201A0 Offset: 0x3202A1 VA: 0x3201A0
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x320320 Offset: 0x320421 VA: 0x320320
	|-List.Enumerator<IntervalTreeNode>..ctor
	|
	|-RVA: 0x320490 Offset: 0x320591 VA: 0x320490
	|-List.Enumerator<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x320600 Offset: 0x320701 VA: 0x320600
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x320770 Offset: 0x320871 VA: 0x320770
	|-List.Enumerator<UICharInfo>..ctor
	|
	|-RVA: 0x3208D0 Offset: 0x3209D1 VA: 0x3208D0
	|-List.Enumerator<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x320A10 Offset: 0x320B11 VA: 0x320A10
	|-List.Enumerator<UILineInfo>..ctor
	|
	|-RVA: 0x320B50 Offset: 0x320C51 VA: 0x320B50
	|-List.Enumerator<UIVertex>..ctor
	|
	|-RVA: 0x320D10 Offset: 0x320E11 VA: 0x320D10
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x320E80 Offset: 0x320F81 VA: 0x320E80
	|-List.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x320FC0 Offset: 0x3210C1 VA: 0x320FC0
	|-List.Enumerator<Vector2Int>..ctor
	|
	|-RVA: 0x321100 Offset: 0x321201 VA: 0x321100
	|-List.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x321260 Offset: 0x321361 VA: 0x321260
	|-List.Enumerator<Vector3Int>..ctor
	|
	|-RVA: 0x3213C0 Offset: 0x3214C1 VA: 0x3213C0
	|-List.Enumerator<Vector4>..ctor
	|
	|-RVA: 0x321500 Offset: 0x321601 VA: 0x321500
	|-List.Enumerator<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x3216E0 Offset: 0x3217E1 VA: 0x3216E0
	|-List.Enumerator<YieldItemParam>..ctor
	|
	|-RVA: 0x321820 Offset: 0x321921 VA: 0x321820
	|-List.Enumerator<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31B1C0 Offset: 0x31B2C1 VA: 0x31B1C0
	|-List.Enumerator<AIInput>.Dispose
	|-List.Enumerator<AS_MagicController>.Dispose
	|-List.Enumerator<ActionBehaviorCommandData>.Dispose
	|-List.Enumerator<ActionBehaviorCommandInformation>.Dispose
	|-List.Enumerator<Actor>.Dispose
	|-List.Enumerator<ActorController>.Dispose
	|-List.Enumerator<ActorData>.Dispose
	|-List.Enumerator<AdvShowOneImage.AdvSpriteLoader>.Dispose
	|-List.Enumerator<AdvShowOneImage>.Dispose
	|-List.Enumerator<AttackCollider>.Dispose
	|-List.Enumerator<AudmuraCrystal>.Dispose
	|-List.Enumerator<AutomaticLOD.LODLevelData>.Dispose
	|-List.Enumerator<AutomaticLOD>.Dispose
	|-List.Enumerator<BaffamoDodgeManager.BaffamoMonster>.Dispose
	|-List.Enumerator<BgmList>.Dispose
	|-List.Enumerator<BitBase>.Dispose
	|-List.Enumerator<BodyPartsCollision>.Dispose
	|-List.Enumerator<BulletBase>.Dispose
	|-List.Enumerator<BulletColliderBase>.Dispose
	|-List.Enumerator<BulletSubModule>.Dispose
	|-List.Enumerator<ButtonLinker>.Dispose
	|-List.Enumerator<CameraManager.CameraControllerPair>.Dispose
	|-List.Enumerator<CerberusController.DogParam>.Dispose
	|-List.Enumerator<Character>.Dispose
	|-List.Enumerator<CharacterBase>.Dispose
	|-List.Enumerator<CheerVoiceData>.Dispose
	|-List.Enumerator<ChildData>.Dispose
	|-List.Enumerator<CinemachineCollider.VcamExtraState>.Dispose
	|-List.Enumerator<ColliderStreamer>.Dispose
	|-List.Enumerator<CombinedMesh.MaterialMeshInfo>.Dispose
	|-List.Enumerator<CombinedMesh.ObjectInfo>.Dispose
	|-List.Enumerator<CursorEvent>.Dispose
	|-List.Enumerator<DLCPair>.Dispose
	|-List.Enumerator<DeadtreeController.ChestnutController>.Dispose
	|-List.Enumerator<EmotionController>.Dispose
	|-List.Enumerator<EnemyPatrolData.PatrolParameter.PatrollBehaviorTypeKeyAndValue>.Dispose
	|-List.Enumerator<EraseObject>.Dispose
	|-List.Enumerator<EventFlagManager.RequestDisableEventPointData>.Dispose
	|-List.Enumerator<EventPointData>.Dispose
	|-List.Enumerator<EventStartData>.Dispose
	|-List.Enumerator<EventUnlockFlagData>.Dispose
	|-List.Enumerator<CellController>.Dispose
	|-List.Enumerator<FarmCropData>.Dispose
	|-List.Enumerator<FesNpcScore>.Dispose
	|-List.Enumerator<ObjectLoader>.Dispose
	|-List.Enumerator<FishSwim>.Dispose
	|-List.Enumerator<FocusObjectName.BorderElement>.Dispose
	|-List.Enumerator<FracturedChunk.AdjacencyInfo>.Dispose
	|-List.Enumerator<FracturedChunk>.Dispose
	|-List.Enumerator<FriendMonsterManager.FarmInActorData>.Dispose
	|-List.Enumerator<FriendMonsterStatusData>.Dispose
	|-List.Enumerator<BoolKeyframeGroup>.Dispose
	|-List.Enumerator<ColorKeyframe>.Dispose
	|-List.Enumerator<ColorKeyframeGroup>.Dispose
	|-List.Enumerator<NumberKeyframe>.Dispose
	|-List.Enumerator<NumberKeyframeGroup>.Dispose
	|-List.Enumerator<ProfileGroupDefinition>.Dispose
	|-List.Enumerator<TextureKeyframeGroup>.Dispose
	|-List.Enumerator<GateSeasonInfomation>.Dispose
	|-List.Enumerator<GateTimeZoneMonsterInfomation>.Dispose
	|-List.Enumerator<GroupSoundData>.Dispose
	|-List.Enumerator<HUDDualWorkSelectInput.DualSelect>.Dispose
	|-List.Enumerator<HasibirokouSonicWind>.Dispose
	|-List.Enumerator<HateController.HateParameter>.Dispose
	|-List.Enumerator<HumanData>.Dispose
	|-List.Enumerator<HumanDataArray>.Dispose
	|-List.Enumerator<InosisiController.ThornsController>.Dispose
	|-List.Enumerator<ItemDataLinker>.Dispose
	|-List.Enumerator<ItemEquip>.Dispose
	|-List.Enumerator<FurnitureSaveData>.Dispose
	|-List.Enumerator<PlayerItemFurniture2>.Dispose
	|-List.Enumerator<ItemMoveToBasket>.Dispose
	|-List.Enumerator<ItemWeightData>.Dispose
	|-List.Enumerator<KrakenStickController>.Dispose
	|-List.Enumerator<LastBossBone>.Dispose
	|-List.Enumerator<AssetHandle>.Dispose
	|-List.Enumerator<AssetInfo>.Dispose
	|-List.Enumerator<MainEventFlagProgressData>.Dispose
	|-List.Enumerator<MiningPair>.Dispose
	|-List.Enumerator<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.Dispose
	|-List.Enumerator<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>.Dispose
	|-List.Enumerator<MonsterActionBehaviorData>.Dispose
	|-List.Enumerator<MonsterActionInformation>.Dispose
	|-List.Enumerator<MonsterAnimatorStateEvent.NormalizeTimeEvent>.Dispose
	|-List.Enumerator<MonsterControllerBase.DropItemDataParameter>.Dispose
	|-List.Enumerator<MonsterControllerBase>.Dispose
	|-List.Enumerator<MonsterModelData>.Dispose
	|-List.Enumerator<MonsterProjectileActionScriptsController>.Dispose
	|-List.Enumerator<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.Dispose
	|-List.Enumerator<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>.Dispose
	|-List.Enumerator<NpcController>.Dispose
	|-List.Enumerator<NpcData>.Dispose
	|-List.Enumerator<NpcLifeCycleDataRecord>.Dispose
	|-List.Enumerator<NpcPatrolPointData>.Dispose
	|-List.Enumerator<NpcSaveParameter>.Dispose
	|-List.Enumerator<NpcStatusData>.Dispose
	|-List.Enumerator<NpcTimeAction>.Dispose
	|-List.Enumerator<ObjectPooler.Pool>.Dispose
	|-List.Enumerator<OnGroundItem>.Dispose
	|-List.Enumerator<OrderData>.Dispose
	|-List.Enumerator<OrderHUDBlock>.Dispose
	|-List.Enumerator<OrderMasterData>.Dispose
	|-List.Enumerator<PartnerManager.NPCChangeBaseParameter>.Dispose
	|-List.Enumerator<PartnerMonsterBehaviorController>.Dispose
	|-List.Enumerator<PatrolPointMotionData>.Dispose
	|-List.Enumerator<PetNpcPetData>.Dispose
	|-List.Enumerator<PlayerCheerVoiceData>.Dispose
	|-List.Enumerator<Contour>.Dispose
	|-List.Enumerator<DTSweepConstraint>.Dispose
	|-List.Enumerator<DelaunayTriangle>.Dispose
	|-List.Enumerator<EdgeIntersectInfo>.Dispose
	|-List.Enumerator<Point2D>.Dispose
	|-List.Enumerator<Point2DList>.Dispose
	|-List.Enumerator<Polygon>.Dispose
	|-List.Enumerator<PolygonPoint>.Dispose
	|-List.Enumerator<TriangulationConstraint>.Dispose
	|-List.Enumerator<TriangulationPoint>.Dispose
	|-List.Enumerator<PreloadHandle>.Dispose
	|-List.Enumerator<PadBindData>.Dispose
	|-List.Enumerator<FishShipmentRecords>.Dispose
	|-List.Enumerator<ShipmentItemRecords>.Dispose
	|-List.Enumerator<RF5Streamer>.Dispose
	|-List.Enumerator<SubtitleHandler>.Dispose
	|-List.Enumerator<ButtonHintBlock>.Dispose
	|-List.Enumerator<SEController>.Dispose
	|-List.Enumerator<RandomData>.Dispose
	|-List.Enumerator<RecipeDataDispBlock>.Dispose
	|-List.Enumerator<RecipeDataTableArray.RecipeDataTable>.Dispose
	|-List.Enumerator<MP4FileProcessing.Chunk>.Dispose
	|-List.Enumerator<ReviatanIcePillar>.Dispose
	|-List.Enumerator<OptionDefinition>.Dispose
	|-List.Enumerator<OptionsTabController.CategoryInstance>.Dispose
	|-List.Enumerator<SRServiceManager.ServiceStub>.Dispose
	|-List.Enumerator<TimelineToActionScriptExpoter.ActionScriptData>.Dispose
	|-List.Enumerator<ScenarioTalkData>.Dispose
	|-List.Enumerator<SceneSplit>.Dispose
	|-List.Enumerator<SceneTransitionManager.GameObjectEnabled>.Dispose
	|-List.Enumerator<SearchCharacterController.SearchParameter>.Dispose
	|-List.Enumerator<SnowmanManager.Mocomoco>.Dispose
	|-List.Enumerator<CubicBezierCurve>.Dispose
	|-List.Enumerator<ExtrusionSegment.Vertex>.Dispose
	|-List.Enumerator<MeshVertex>.Dispose
	|-List.Enumerator<SplineNode>.Dispose
	|-List.Enumerator<TransformedMesh>.Dispose
	|-List.Enumerator<SubEventData>.Dispose
	|-List.Enumerator<SubEventMasterDataBase>.Dispose
	|-List.Enumerator<List<FarmCropData>>.Dispose
	|-List.Enumerator<List<PolygonPoint>>.Dispose
	|-List.Enumerator<BranchLabel>.Dispose
	|-List.Enumerator<ByRefUpdater>.Dispose
	|-List.Enumerator<LabelScopeInfo>.Dispose
	|-List.Enumerator<ModifierSpec>.Dispose
	|-List.Enumerator<IPAddress>.Dispose
	|-List.Enumerator<MonoChunkStream.Chunk>.Dispose
	|-List.Enumerator<WebConnection>.Dispose
	|-List.Enumerator<WebConnectionGroup>.Dispose
	|-List.Enumerator<object>.Dispose
	|-List.Enumerator<Assembly>.Dispose
	|-List.Enumerator<MethodInfo>.Dispose
	|-List.Enumerator<ExceptionDispatchInfo>.Dispose
	|-List.Enumerator<IContextProperty>.Dispose
	|-List.Enumerator<X509CertificateImpl>.Dispose
	|-List.Enumerator<string>.Dispose
	|-List.Enumerator<string[]>.Dispose
	|-List.Enumerator<IAsyncLocal>.Dispose
	|-List.Enumerator<Task>.Dispose
	|-List.Enumerator<Thread>.Dispose
	|-List.Enumerator<Type>.Dispose
	|-List.Enumerator<TypeIdentifier>.Dispose
	|-List.Enumerator<TimeManager.JustTimerData>.Dispose
	|-List.Enumerator<ToolInteractionInterface>.Dispose
	|-List.Enumerator<UIButtonLinkerInScrollBox>.Dispose
	|-List.Enumerator<UIFadeOnOffAnimate.ImageGroup>.Dispose
	|-List.Enumerator<UIItemSlot>.Dispose
	|-List.Enumerator<DynamicsSetup.ParseMessage>.Dispose
	|-List.Enumerator<SpringBone>.Dispose
	|-List.Enumerator<MeshData>.Dispose
	|-List.Enumerator<SupportPlane>.Dispose
	|-List.Enumerator<UltimateRope.RopeBone>.Dispose
	|-List.Enumerator<UltimateRope.RopeNode>.Dispose
	|-List.Enumerator<NavMeshLink>.Dispose
	|-List.Enumerator<NavMeshModifier>.Dispose
	|-List.Enumerator<NavMeshModifierVolume>.Dispose
	|-List.Enumerator<NavMeshObstacle>.Dispose
	|-List.Enumerator<AddressablesImpl.ResourceLocatorInfo>.Dispose
	|-List.Enumerator<Animator>.Dispose
	|-List.Enumerator<Collider>.Dispose
	|-List.Enumerator<PersistentCall>.Dispose
	|-List.Enumerator<IAnimationWindowPreview>.Dispose
	|-List.Enumerator<GUILayoutEntry>.Dispose
	|-List.Enumerator<GameObject>.Dispose
	|-List.Enumerator<GameObject[]>.Dispose
	|-List.Enumerator<ISubsystem>.Dispose
	|-List.Enumerator<ISubsystemDescriptor>.Dispose
	|-List.Enumerator<ISubsystemDescriptorImpl>.Dispose
	|-List.Enumerator<Material>.Dispose
	|-List.Enumerator<ParticleSystem>.Dispose
	|-List.Enumerator<RenderTexture>.Dispose
	|-List.Enumerator<IUpdateReceiver>.Dispose
	|-List.Enumerator<IResourceLocation>.Dispose
	|-List.Enumerator<ResourceManager.InstanceOperation>.Dispose
	|-List.Enumerator<ScriptableObject>.Dispose
	|-List.Enumerator<SkinnedMeshRenderer>.Dispose
	|-List.Enumerator<Terrain>.Dispose
	|-List.Enumerator<RuntimeElement>.Dispose
	|-List.Enumerator<TimelineClip>.Dispose
	|-List.Enumerator<Transform>.Dispose
	|-List.Enumerator<Image>.Dispose
	|-List.Enumerator<EventCallbackFunctorBase>.Dispose
	|-List.Enumerator<IEventDispatchingStrategy>.Dispose
	|-List.Enumerator<Panel>.Dispose
	|-List.Enumerator<VisualElement>.Dispose
	|-List.Enumerator<UpPointData>.Dispose
	|
	|-RVA: 0x34F530 Offset: 0x34F631 VA: 0x34F530
	|-List.Enumerator<AS_ToolController.ChargeInfo>.Dispose
	|
	|-RVA: 0x34F6B0 Offset: 0x34F7B1 VA: 0x34F6B0
	|-List.Enumerator<BuildItemData>.Dispose
	|
	|-RVA: 0x34F870 Offset: 0x34F971 VA: 0x34F870
	|-List.Enumerator<ButtonLinker.LinkObject>.Dispose
	|
	|-RVA: 0x34F9B0 Offset: 0x34FAB1 VA: 0x34F9B0
	|-List.Enumerator<CharaCallTable.BustupTable>.Dispose
	|
	|-RVA: 0x34FB00 Offset: 0x34FC01 VA: 0x34FB00
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>.Dispose
	|
	|-RVA: 0x34FC50 Offset: 0x34FD51 VA: 0x34FC50
	|-List.Enumerator<CameraState.CustomBlendable>.Dispose
	|
	|-RVA: 0x34FD90 Offset: 0x34FE91 VA: 0x34FD90
	|-List.Enumerator<CinemachineClearShot.Pair>.Dispose
	|
	|-RVA: 0x34FED0 Offset: 0x34FFD1 VA: 0x34FED0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.Dispose
	|
	|-RVA: 0x350020 Offset: 0x350121 VA: 0x350020
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.Dispose
	|
	|-RVA: 0x3501A0 Offset: 0x3502A1 VA: 0x3501A0
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.Dispose
	|
	|-RVA: 0x350360 Offset: 0x350461 VA: 0x350360
	|-List.Enumerator<CropDataTable>.Dispose
	|
	|-RVA: 0x352ED0 Offset: 0x352FD1 VA: 0x352ED0
	|-List.Enumerator<ActorID>.Dispose
	|-List.Enumerator<Alliance>.Dispose
	|-List.Enumerator<GameFlagData>.Dispose
	|-List.Enumerator<NPCID>.Dispose
	|-List.Enumerator<VariationNo>.Dispose
	|-List.Enumerator<ItemID>.Dispose
	|-List.Enumerator<Prefab>.Dispose
	|-List.Enumerator<Texture>.Dispose
	|-List.Enumerator<MonsterModelDataID>.Dispose
	|-List.Enumerator<SoundID>.Dispose
	|-List.Enumerator<Int32Enum>.Dispose
	|-List.Enumerator<UITextDic.DICID>.Dispose
	|
	|-RVA: 0x350520 Offset: 0x350621 VA: 0x350520
	|-List.Enumerator<DropItemParam>.Dispose
	|
	|-RVA: 0x350670 Offset: 0x350771 VA: 0x350670
	|-List.Enumerator<ErosionBrush.UndoStep>.Dispose
	|
	|-RVA: 0x3507E0 Offset: 0x3508E1 VA: 0x3507E0
	|-List.Enumerator<EventCheckId>.Dispose
	|
	|-RVA: 0x350940 Offset: 0x350A41 VA: 0x350940
	|-List.Enumerator<EventFlagProgressData>.Dispose
	|
	|-RVA: 0x350A80 Offset: 0x350B81 VA: 0x350A80
	|-List.Enumerator<FesNpcScoreData>.Dispose
	|
	|-RVA: 0x350BD0 Offset: 0x350CD1 VA: 0x350BD0
	|-List.Enumerator<MiningPointSaveData>.Dispose
	|
	|-RVA: 0x350D60 Offset: 0x350E61 VA: 0x350D60
	|-List.Enumerator<MonsterHutSaveData>.Dispose
	|
	|-RVA: 0x350ED0 Offset: 0x350FD1 VA: 0x350ED0
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>.Dispose
	|
	|-RVA: 0x351020 Offset: 0x351121 VA: 0x351020
	|-List.Enumerator<NPCActionData>.Dispose
	|
	|-RVA: 0x3511B0 Offset: 0x3512B1 VA: 0x3511B0
	|-List.Enumerator<NpcPlaceSchedule>.Dispose
	|
	|-RVA: 0x351320 Offset: 0x351421 VA: 0x351320
	|-List.Enumerator<OrderLotterySaveParameter>.Dispose
	|
	|-RVA: 0x351480 Offset: 0x351581 VA: 0x351480
	|-List.Enumerator<OrderSaveParameter>.Dispose
	|
	|-RVA: 0x3515E0 Offset: 0x3516E1 VA: 0x3515E0
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.Dispose
	|
	|-RVA: 0x351720 Offset: 0x351821 VA: 0x351720
	|-List.Enumerator<ShopCatalogPage>.Dispose
	|
	|-RVA: 0x351870 Offset: 0x351971 VA: 0x351870
	|-List.Enumerator<ShopNpcTalk>.Dispose
	|
	|-RVA: 0x3519F0 Offset: 0x351AF1 VA: 0x3519F0
	|-List.Enumerator<SubtitleDataTable.Data>.Dispose
	|
	|-RVA: 0x351B40 Offset: 0x351C41 VA: 0x351B40
	|-List.Enumerator<SubtitleDataTable.DataList>.Dispose
	|
	|-RVA: 0x351C90 Offset: 0x351D91 VA: 0x351C90
	|-List.Enumerator<SubtitleHudDataTable.Data>.Dispose
	|
	|-RVA: 0x351DF0 Offset: 0x351EF1 VA: 0x351DF0
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>.Dispose
	|
	|-RVA: 0x351F60 Offset: 0x352061 VA: 0x351F60
	|-List.Enumerator<Schedule>.Dispose
	|
	|-RVA: 0x3520D0 Offset: 0x3521D1 VA: 0x3520D0
	|-List.Enumerator<CurveSample>.Dispose
	|
	|-RVA: 0x352250 Offset: 0x352351 VA: 0x352250
	|-List.Enumerator<bool>.Dispose
	|
	|-RVA: 0x352390 Offset: 0x352491 VA: 0x352390
	|-List.Enumerator<byte>.Dispose
	|
	|-RVA: 0x3524D0 Offset: 0x3525D1 VA: 0x3524D0
	|-List.Enumerator<char>.Dispose
	|
	|-RVA: 0x352610 Offset: 0x352711 VA: 0x352610
	|-List.Enumerator<KeyValuePair<DateTime, object>>.Dispose
	|
	|-RVA: 0x352750 Offset: 0x352851 VA: 0x352750
	|-List.Enumerator<KeyValuePair<int, FishSwim>>.Dispose
	|-List.Enumerator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x352890 Offset: 0x352991 VA: 0x352890
	|-List.Enumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x3529D0 Offset: 0x352AD1 VA: 0x3529D0
	|-List.Enumerator<DateTime>.Dispose
	|
	|-RVA: 0x352B10 Offset: 0x352C11 VA: 0x352B10
	|-List.Enumerator<double>.Dispose
	|
	|-RVA: 0x352C50 Offset: 0x352D51 VA: 0x352C50
	|-List.Enumerator<short>.Dispose
	|
	|-RVA: 0x352D90 Offset: 0x352E91 VA: 0x352D90
	|-List.Enumerator<int>.Dispose
	|
	|-RVA: 0x353010 Offset: 0x353111 VA: 0x353010
	|-List.Enumerator<long>.Dispose
	|
	|-RVA: 0x353150 Offset: 0x353251 VA: 0x353150
	|-List.Enumerator<InterpretedFrameInfo>.Dispose
	|
	|-RVA: 0x353290 Offset: 0x353391 VA: 0x353290
	|-List.Enumerator<Nullable<Int32Enum>>.Dispose
	|
	|-RVA: 0x3533E0 Offset: 0x3534E1 VA: 0x3533E0
	|-List.Enumerator<Nullable<Bounds>>.Dispose
	|
	|-RVA: 0x353560 Offset: 0x353661 VA: 0x353560
	|-List.Enumerator<Nullable<BoundsInt>>.Dispose
	|
	|-RVA: 0x3536D0 Offset: 0x3537D1 VA: 0x3536D0
	|-List.Enumerator<Nullable<Color32>>.Dispose
	|
	|-RVA: 0x353820 Offset: 0x353921 VA: 0x353820
	|-List.Enumerator<Nullable<Color>>.Dispose
	|
	|-RVA: 0x353990 Offset: 0x353A91 VA: 0x353990
	|-List.Enumerator<Nullable<GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x353AF0 Offset: 0x353BF1 VA: 0x353AF0
	|-List.Enumerator<Nullable<GradientColorKey>>.Dispose
	|
	|-RVA: 0x353C60 Offset: 0x353D61 VA: 0x353C60
	|-List.Enumerator<Nullable<Keyframe>>.Dispose
	|
	|-RVA: 0x353DC0 Offset: 0x353EC1 VA: 0x353DC0
	|-List.Enumerator<Nullable<LayerMask>>.Dispose
	|
	|-RVA: 0x353F10 Offset: 0x354011 VA: 0x353F10
	|-List.Enumerator<Nullable<Matrix4x4>>.Dispose
	|
	|-RVA: 0x3540B0 Offset: 0x3541B1 VA: 0x3540B0
	|-List.Enumerator<Nullable<Quaternion>>.Dispose
	|
	|-RVA: 0x354220 Offset: 0x354321 VA: 0x354220
	|-List.Enumerator<Nullable<RangeInt>>.Dispose
	|
	|-RVA: 0x354380 Offset: 0x354481 VA: 0x354380
	|-List.Enumerator<Nullable<Rect>>.Dispose
	|
	|-RVA: 0x3544F0 Offset: 0x3545F1 VA: 0x3544F0
	|-List.Enumerator<Nullable<RectInt>>.Dispose
	|
	|-RVA: 0x354660 Offset: 0x354761 VA: 0x354660
	|-List.Enumerator<Nullable<Vector2>>.Dispose
	|
	|-RVA: 0x3547C0 Offset: 0x3548C1 VA: 0x3547C0
	|-List.Enumerator<Nullable<Vector2Int>>.Dispose
	|
	|-RVA: 0x354910 Offset: 0x354A11 VA: 0x354910
	|-List.Enumerator<Nullable<Vector3>>.Dispose
	|
	|-RVA: 0x354A50 Offset: 0x354B51 VA: 0x354A50
	|-List.Enumerator<Nullable<Vector3Int>>.Dispose
	|
	|-RVA: 0x31B060 Offset: 0x31B161 VA: 0x31B060
	|-List.Enumerator<Nullable<Vector4>>.Dispose
	|
	|-RVA: 0x31B370 Offset: 0x31B471 VA: 0x31B370
	|-List.Enumerator<sbyte>.Dispose
	|
	|-RVA: 0x31B4B0 Offset: 0x31B5B1 VA: 0x31B4B0
	|-List.Enumerator<float>.Dispose
	|
	|-RVA: 0x31B5F0 Offset: 0x31B6F1 VA: 0x31B5F0
	|-List.Enumerator<ushort>.Dispose
	|
	|-RVA: 0x31B730 Offset: 0x31B831 VA: 0x31B730
	|-List.Enumerator<uint>.Dispose
	|
	|-RVA: 0x31B870 Offset: 0x31B971 VA: 0x31B870
	|-List.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x31BFF0 Offset: 0x31C0F1 VA: 0x31BFF0
	|-List.Enumerator<ValueTuple<CharacterBase, float>>.Dispose
	|-List.Enumerator<ValueTuple<object, float>>.Dispose
	|
	|-RVA: 0x31BC30 Offset: 0x31BD31 VA: 0x31BC30
	|-List.Enumerator<ValueTuple<SoundID, EnvironmentSoundController>>.Dispose
	|-List.Enumerator<ValueTuple<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x31B9B0 Offset: 0x31BAB1 VA: 0x31B9B0
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x31BAF0 Offset: 0x31BBF1 VA: 0x31BAF0
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x31BD70 Offset: 0x31BE71 VA: 0x31BD70
	|-List.Enumerator<ValueTuple<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x31BEB0 Offset: 0x31BFB1 VA: 0x31BEB0
	|-List.Enumerator<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x31C140 Offset: 0x31C241 VA: 0x31C140
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x31C2A0 Offset: 0x31C3A1 VA: 0x31C2A0
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Dispose
	|-List.Enumerator<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>.Dispose
	|
	|-RVA: 0x31C430 Offset: 0x31C531 VA: 0x31C430
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.Dispose
	|
	|-RVA: 0x31C5C0 Offset: 0x31C6C1 VA: 0x31C5C0
	|-List.Enumerator<TutorialUnlockFlagData>.Dispose
	|
	|-RVA: 0x31C710 Offset: 0x31C811 VA: 0x31C710
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>.Dispose
	|
	|-RVA: 0x31C860 Offset: 0x31C961 VA: 0x31C860
	|-List.Enumerator<CapEdge>.Dispose
	|
	|-RVA: 0x31C9E0 Offset: 0x31CAE1 VA: 0x31C9E0
	|-List.Enumerator<MeshDataConnectivity.Face>.Dispose
	|
	|-RVA: 0x31CB30 Offset: 0x31CC31 VA: 0x31CB30
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>.Dispose
	|
	|-RVA: 0x31CCA0 Offset: 0x31CDA1 VA: 0x31CCA0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>.Dispose
	|
	|-RVA: 0x31CE10 Offset: 0x31CF11 VA: 0x31CE10
	|-List.Enumerator<NavMeshBuildMarkup>.Dispose
	|
	|-RVA: 0x31CF70 Offset: 0x31D071 VA: 0x31CF70
	|-List.Enumerator<NavMeshBuildSource>.Dispose
	|
	|-RVA: 0x31D120 Offset: 0x31D221 VA: 0x31D120
	|-List.Enumerator<ConstraintSource>.Dispose
	|
	|-RVA: 0x31D260 Offset: 0x31D361 VA: 0x31D260
	|-List.Enumerator<AnimatorClipInfo>.Dispose
	|
	|-RVA: 0x31D3A0 Offset: 0x31D4A1 VA: 0x31D3A0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|
	|-RVA: 0x31D4F0 Offset: 0x31D5F1 VA: 0x31D4F0
	|-List.Enumerator<BoneWeight>.Dispose
	|
	|-RVA: 0x31D660 Offset: 0x31D761 VA: 0x31D660
	|-List.Enumerator<Bounds>.Dispose
	|
	|-RVA: 0x31D7D0 Offset: 0x31D8D1 VA: 0x31D7D0
	|-List.Enumerator<BoundsInt>.Dispose
	|
	|-RVA: 0x31D930 Offset: 0x31DA31 VA: 0x31D930
	|-List.Enumerator<Color32>.Dispose
	|
	|-RVA: 0x31DA70 Offset: 0x31DB71 VA: 0x31DA70
	|-List.Enumerator<Color>.Dispose
	|
	|-RVA: 0x31DBD0 Offset: 0x31DCD1 VA: 0x31DBD0
	|-List.Enumerator<CombineInstance>.Dispose
	|
	|-RVA: 0x31DD90 Offset: 0x31DE91 VA: 0x31DD90
	|-List.Enumerator<RaycastResult>.Dispose
	|
	|-RVA: 0x31DF10 Offset: 0x31E011 VA: 0x31DF10
	|-List.Enumerator<GradientAlphaKey>.Dispose
	|
	|-RVA: 0x31E060 Offset: 0x31E161 VA: 0x31E060
	|-List.Enumerator<GradientColorKey>.Dispose
	|
	|-RVA: 0x31E1D0 Offset: 0x31E2D1 VA: 0x31E1D0
	|-List.Enumerator<Keyframe>.Dispose
	|
	|-RVA: 0x31E340 Offset: 0x31E441 VA: 0x31E340
	|-List.Enumerator<LayerMask>.Dispose
	|
	|-RVA: 0x31E490 Offset: 0x31E591 VA: 0x31E490
	|-List.Enumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x31E630 Offset: 0x31E731 VA: 0x31E630
	|-List.Enumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x31E7B0 Offset: 0x31E8B1 VA: 0x31E7B0
	|-List.Enumerator<Playable>.Dispose
	|
	|-RVA: 0x31E900 Offset: 0x31EA01 VA: 0x31E900
	|-List.Enumerator<PlayableBinding>.Dispose
	|
	|-RVA: 0x31EA60 Offset: 0x31EB61 VA: 0x31EA60
	|-List.Enumerator<PlayableGraph>.Dispose
	|
	|-RVA: 0x31EBA0 Offset: 0x31ECA1 VA: 0x31EBA0
	|-List.Enumerator<Edge>.Dispose
	|
	|-RVA: 0x31ECE0 Offset: 0x31EDE1 VA: 0x31ECE0
	|-List.Enumerator<Quaternion>.Dispose
	|
	|-RVA: 0x31EE20 Offset: 0x31EF21 VA: 0x31EE20
	|-List.Enumerator<RangeInt>.Dispose
	|
	|-RVA: 0x31EF70 Offset: 0x31F071 VA: 0x31EF70
	|-List.Enumerator<RaycastHit2D>.Dispose
	|
	|-RVA: 0x31F100 Offset: 0x31F201 VA: 0x31F100
	|-List.Enumerator<RaycastHit>.Dispose
	|
	|-RVA: 0x31F280 Offset: 0x31F381 VA: 0x31F280
	|-List.Enumerator<Rect>.Dispose
	|
	|-RVA: 0x31F3C0 Offset: 0x31F4C1 VA: 0x31F3C0
	|-List.Enumerator<RectInt>.Dispose
	|
	|-RVA: 0x31F500 Offset: 0x31F601 VA: 0x31F500
	|-List.Enumerator<ReflectionProbeBlendInfo>.Dispose
	|
	|-RVA: 0x31F660 Offset: 0x31F761 VA: 0x31F660
	|-List.Enumerator<SphericalHarmonicsL2>.Dispose
	|
	|-RVA: 0x31F820 Offset: 0x31F921 VA: 0x31F820
	|-List.Enumerator<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x31F970 Offset: 0x31FA71 VA: 0x31F970
	|-List.Enumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x31FAE0 Offset: 0x31FBE1 VA: 0x31FAE0
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>.Dispose
	|
	|-RVA: 0x31FC50 Offset: 0x31FD51 VA: 0x31FC50
	|-List.Enumerator<DiagnosticEvent>.Dispose
	|
	|-RVA: 0x31FDD0 Offset: 0x31FED1 VA: 0x31FDD0
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.Dispose
	|
	|-RVA: 0x31FF40 Offset: 0x320041 VA: 0x31FF40
	|-List.Enumerator<ObjectInitializationData>.Dispose
	|
	|-RVA: 0x3200B0 Offset: 0x3201B1 VA: 0x3200B0
	|-List.Enumerator<GlyphRect>.Dispose
	|
	|-RVA: 0x320200 Offset: 0x320301 VA: 0x320200
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.Dispose
	|
	|-RVA: 0x320380 Offset: 0x320481 VA: 0x320380
	|-List.Enumerator<IntervalTreeNode>.Dispose
	|
	|-RVA: 0x3204F0 Offset: 0x3205F1 VA: 0x3204F0
	|-List.Enumerator<IntervalTree.Entry<object>>.Dispose
	|
	|-RVA: 0x320660 Offset: 0x320761 VA: 0x320660
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.Dispose
	|
	|-RVA: 0x3207D0 Offset: 0x3208D1 VA: 0x3207D0
	|-List.Enumerator<UICharInfo>.Dispose
	|
	|-RVA: 0x320920 Offset: 0x320A21 VA: 0x320920
	|-List.Enumerator<FocusController.FocusedElement>.Dispose
	|
	|-RVA: 0x320A60 Offset: 0x320B61 VA: 0x320A60
	|-List.Enumerator<UILineInfo>.Dispose
	|
	|-RVA: 0x320BC0 Offset: 0x320CC1 VA: 0x320BC0
	|-List.Enumerator<UIVertex>.Dispose
	|
	|-RVA: 0x320D70 Offset: 0x320E71 VA: 0x320D70
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|
	|-RVA: 0x320ED0 Offset: 0x320FD1 VA: 0x320ED0
	|-List.Enumerator<Vector2>.Dispose
	|
	|-RVA: 0x321010 Offset: 0x321111 VA: 0x321010
	|-List.Enumerator<Vector2Int>.Dispose
	|
	|-RVA: 0x321160 Offset: 0x321261 VA: 0x321160
	|-List.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x3212C0 Offset: 0x3213C1 VA: 0x3212C0
	|-List.Enumerator<Vector3Int>.Dispose
	|
	|-RVA: 0x321410 Offset: 0x321511 VA: 0x321410
	|-List.Enumerator<Vector4>.Dispose
	|
	|-RVA: 0x321570 Offset: 0x321671 VA: 0x321570
	|-List.Enumerator<WarpPoints.WarpPoint>.Dispose
	|
	|-RVA: 0x321730 Offset: 0x321831 VA: 0x321730
	|-List.Enumerator<YieldItemParam>.Dispose
	|
	|-RVA: 0x321880 Offset: 0x321981 VA: 0x321880
	|-List.Enumerator<stCommand_t>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31B1D0 Offset: 0x31B2D1 VA: 0x31B1D0
	|-List.Enumerator<AIInput>.MoveNext
	|-List.Enumerator<AS_MagicController>.MoveNext
	|-List.Enumerator<ActionBehaviorCommandData>.MoveNext
	|-List.Enumerator<ActionBehaviorCommandInformation>.MoveNext
	|-List.Enumerator<Actor>.MoveNext
	|-List.Enumerator<ActorController>.MoveNext
	|-List.Enumerator<ActorData>.MoveNext
	|-List.Enumerator<AdvShowOneImage.AdvSpriteLoader>.MoveNext
	|-List.Enumerator<AdvShowOneImage>.MoveNext
	|-List.Enumerator<AttackCollider>.MoveNext
	|-List.Enumerator<AudmuraCrystal>.MoveNext
	|-List.Enumerator<AutomaticLOD.LODLevelData>.MoveNext
	|-List.Enumerator<AutomaticLOD>.MoveNext
	|-List.Enumerator<BaffamoDodgeManager.BaffamoMonster>.MoveNext
	|-List.Enumerator<BgmList>.MoveNext
	|-List.Enumerator<BitBase>.MoveNext
	|-List.Enumerator<BodyPartsCollision>.MoveNext
	|-List.Enumerator<BulletBase>.MoveNext
	|-List.Enumerator<BulletColliderBase>.MoveNext
	|-List.Enumerator<BulletSubModule>.MoveNext
	|-List.Enumerator<ButtonLinker>.MoveNext
	|-List.Enumerator<CameraManager.CameraControllerPair>.MoveNext
	|-List.Enumerator<CerberusController.DogParam>.MoveNext
	|-List.Enumerator<Character>.MoveNext
	|-List.Enumerator<CharacterBase>.MoveNext
	|-List.Enumerator<CheerVoiceData>.MoveNext
	|-List.Enumerator<ChildData>.MoveNext
	|-List.Enumerator<CinemachineCollider.VcamExtraState>.MoveNext
	|-List.Enumerator<ColliderStreamer>.MoveNext
	|-List.Enumerator<CombinedMesh.MaterialMeshInfo>.MoveNext
	|-List.Enumerator<CombinedMesh.ObjectInfo>.MoveNext
	|-List.Enumerator<CursorEvent>.MoveNext
	|-List.Enumerator<DLCPair>.MoveNext
	|-List.Enumerator<DeadtreeController.ChestnutController>.MoveNext
	|-List.Enumerator<EmotionController>.MoveNext
	|-List.Enumerator<EnemyPatrolData.PatrolParameter.PatrollBehaviorTypeKeyAndValue>.MoveNext
	|-List.Enumerator<EraseObject>.MoveNext
	|-List.Enumerator<EventFlagManager.RequestDisableEventPointData>.MoveNext
	|-List.Enumerator<EventPointData>.MoveNext
	|-List.Enumerator<EventStartData>.MoveNext
	|-List.Enumerator<EventUnlockFlagData>.MoveNext
	|-List.Enumerator<CellController>.MoveNext
	|-List.Enumerator<FarmCropData>.MoveNext
	|-List.Enumerator<FesNpcScore>.MoveNext
	|-List.Enumerator<ObjectLoader>.MoveNext
	|-List.Enumerator<FishSwim>.MoveNext
	|-List.Enumerator<FocusObjectName.BorderElement>.MoveNext
	|-List.Enumerator<FracturedChunk.AdjacencyInfo>.MoveNext
	|-List.Enumerator<FracturedChunk>.MoveNext
	|-List.Enumerator<FriendMonsterManager.FarmInActorData>.MoveNext
	|-List.Enumerator<FriendMonsterStatusData>.MoveNext
	|-List.Enumerator<BoolKeyframeGroup>.MoveNext
	|-List.Enumerator<ColorKeyframe>.MoveNext
	|-List.Enumerator<ColorKeyframeGroup>.MoveNext
	|-List.Enumerator<NumberKeyframe>.MoveNext
	|-List.Enumerator<NumberKeyframeGroup>.MoveNext
	|-List.Enumerator<ProfileGroupDefinition>.MoveNext
	|-List.Enumerator<TextureKeyframeGroup>.MoveNext
	|-List.Enumerator<GateSeasonInfomation>.MoveNext
	|-List.Enumerator<GateTimeZoneMonsterInfomation>.MoveNext
	|-List.Enumerator<GroupSoundData>.MoveNext
	|-List.Enumerator<HUDDualWorkSelectInput.DualSelect>.MoveNext
	|-List.Enumerator<HasibirokouSonicWind>.MoveNext
	|-List.Enumerator<HateController.HateParameter>.MoveNext
	|-List.Enumerator<HumanData>.MoveNext
	|-List.Enumerator<HumanDataArray>.MoveNext
	|-List.Enumerator<InosisiController.ThornsController>.MoveNext
	|-List.Enumerator<ItemDataLinker>.MoveNext
	|-List.Enumerator<ItemEquip>.MoveNext
	|-List.Enumerator<FurnitureSaveData>.MoveNext
	|-List.Enumerator<PlayerItemFurniture2>.MoveNext
	|-List.Enumerator<ItemMoveToBasket>.MoveNext
	|-List.Enumerator<ItemWeightData>.MoveNext
	|-List.Enumerator<KrakenStickController>.MoveNext
	|-List.Enumerator<LastBossBone>.MoveNext
	|-List.Enumerator<AssetHandle>.MoveNext
	|-List.Enumerator<AssetInfo>.MoveNext
	|-List.Enumerator<MainEventFlagProgressData>.MoveNext
	|-List.Enumerator<MiningPair>.MoveNext
	|-List.Enumerator<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.MoveNext
	|-List.Enumerator<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>.MoveNext
	|-List.Enumerator<MonsterActionBehaviorData>.MoveNext
	|-List.Enumerator<MonsterActionInformation>.MoveNext
	|-List.Enumerator<MonsterAnimatorStateEvent.NormalizeTimeEvent>.MoveNext
	|-List.Enumerator<MonsterControllerBase.DropItemDataParameter>.MoveNext
	|-List.Enumerator<MonsterControllerBase>.MoveNext
	|-List.Enumerator<MonsterModelData>.MoveNext
	|-List.Enumerator<MonsterProjectileActionScriptsController>.MoveNext
	|-List.Enumerator<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.MoveNext
	|-List.Enumerator<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>.MoveNext
	|-List.Enumerator<NpcController>.MoveNext
	|-List.Enumerator<NpcData>.MoveNext
	|-List.Enumerator<NpcLifeCycleDataRecord>.MoveNext
	|-List.Enumerator<NpcPatrolPointData>.MoveNext
	|-List.Enumerator<NpcSaveParameter>.MoveNext
	|-List.Enumerator<NpcStatusData>.MoveNext
	|-List.Enumerator<NpcTimeAction>.MoveNext
	|-List.Enumerator<ObjectPooler.Pool>.MoveNext
	|-List.Enumerator<OnGroundItem>.MoveNext
	|-List.Enumerator<OrderData>.MoveNext
	|-List.Enumerator<OrderHUDBlock>.MoveNext
	|-List.Enumerator<OrderMasterData>.MoveNext
	|-List.Enumerator<PartnerManager.NPCChangeBaseParameter>.MoveNext
	|-List.Enumerator<PartnerMonsterBehaviorController>.MoveNext
	|-List.Enumerator<PatrolPointMotionData>.MoveNext
	|-List.Enumerator<PetNpcPetData>.MoveNext
	|-List.Enumerator<PlayerCheerVoiceData>.MoveNext
	|-List.Enumerator<Contour>.MoveNext
	|-List.Enumerator<DTSweepConstraint>.MoveNext
	|-List.Enumerator<DelaunayTriangle>.MoveNext
	|-List.Enumerator<EdgeIntersectInfo>.MoveNext
	|-List.Enumerator<Point2D>.MoveNext
	|-List.Enumerator<Point2DList>.MoveNext
	|-List.Enumerator<Polygon>.MoveNext
	|-List.Enumerator<PolygonPoint>.MoveNext
	|-List.Enumerator<TriangulationConstraint>.MoveNext
	|-List.Enumerator<TriangulationPoint>.MoveNext
	|-List.Enumerator<PreloadHandle>.MoveNext
	|-List.Enumerator<PadBindData>.MoveNext
	|-List.Enumerator<FishShipmentRecords>.MoveNext
	|-List.Enumerator<ShipmentItemRecords>.MoveNext
	|-List.Enumerator<RF5Streamer>.MoveNext
	|-List.Enumerator<SubtitleHandler>.MoveNext
	|-List.Enumerator<ButtonHintBlock>.MoveNext
	|-List.Enumerator<SEController>.MoveNext
	|-List.Enumerator<RandomData>.MoveNext
	|-List.Enumerator<RecipeDataDispBlock>.MoveNext
	|-List.Enumerator<RecipeDataTableArray.RecipeDataTable>.MoveNext
	|-List.Enumerator<MP4FileProcessing.Chunk>.MoveNext
	|-List.Enumerator<ReviatanIcePillar>.MoveNext
	|-List.Enumerator<OptionDefinition>.MoveNext
	|-List.Enumerator<OptionsTabController.CategoryInstance>.MoveNext
	|-List.Enumerator<SRServiceManager.ServiceStub>.MoveNext
	|-List.Enumerator<TimelineToActionScriptExpoter.ActionScriptData>.MoveNext
	|-List.Enumerator<ScenarioTalkData>.MoveNext
	|-List.Enumerator<SceneSplit>.MoveNext
	|-List.Enumerator<SceneTransitionManager.GameObjectEnabled>.MoveNext
	|-List.Enumerator<SearchCharacterController.SearchParameter>.MoveNext
	|-List.Enumerator<SnowmanManager.Mocomoco>.MoveNext
	|-List.Enumerator<CubicBezierCurve>.MoveNext
	|-List.Enumerator<ExtrusionSegment.Vertex>.MoveNext
	|-List.Enumerator<MeshVertex>.MoveNext
	|-List.Enumerator<SplineNode>.MoveNext
	|-List.Enumerator<TransformedMesh>.MoveNext
	|-List.Enumerator<SubEventData>.MoveNext
	|-List.Enumerator<SubEventMasterDataBase>.MoveNext
	|-List.Enumerator<List<FarmCropData>>.MoveNext
	|-List.Enumerator<List<PolygonPoint>>.MoveNext
	|-List.Enumerator<BranchLabel>.MoveNext
	|-List.Enumerator<ByRefUpdater>.MoveNext
	|-List.Enumerator<LabelScopeInfo>.MoveNext
	|-List.Enumerator<ModifierSpec>.MoveNext
	|-List.Enumerator<IPAddress>.MoveNext
	|-List.Enumerator<MonoChunkStream.Chunk>.MoveNext
	|-List.Enumerator<WebConnection>.MoveNext
	|-List.Enumerator<WebConnectionGroup>.MoveNext
	|-List.Enumerator<object>.MoveNext
	|-List.Enumerator<Assembly>.MoveNext
	|-List.Enumerator<MethodInfo>.MoveNext
	|-List.Enumerator<ExceptionDispatchInfo>.MoveNext
	|-List.Enumerator<IContextProperty>.MoveNext
	|-List.Enumerator<X509CertificateImpl>.MoveNext
	|-List.Enumerator<string>.MoveNext
	|-List.Enumerator<string[]>.MoveNext
	|-List.Enumerator<IAsyncLocal>.MoveNext
	|-List.Enumerator<Task>.MoveNext
	|-List.Enumerator<Thread>.MoveNext
	|-List.Enumerator<Type>.MoveNext
	|-List.Enumerator<TypeIdentifier>.MoveNext
	|-List.Enumerator<TimeManager.JustTimerData>.MoveNext
	|-List.Enumerator<ToolInteractionInterface>.MoveNext
	|-List.Enumerator<UIButtonLinkerInScrollBox>.MoveNext
	|-List.Enumerator<UIFadeOnOffAnimate.ImageGroup>.MoveNext
	|-List.Enumerator<UIItemSlot>.MoveNext
	|-List.Enumerator<DynamicsSetup.ParseMessage>.MoveNext
	|-List.Enumerator<SpringBone>.MoveNext
	|-List.Enumerator<MeshData>.MoveNext
	|-List.Enumerator<SupportPlane>.MoveNext
	|-List.Enumerator<UltimateRope.RopeBone>.MoveNext
	|-List.Enumerator<UltimateRope.RopeNode>.MoveNext
	|-List.Enumerator<NavMeshLink>.MoveNext
	|-List.Enumerator<NavMeshModifier>.MoveNext
	|-List.Enumerator<NavMeshModifierVolume>.MoveNext
	|-List.Enumerator<NavMeshObstacle>.MoveNext
	|-List.Enumerator<AddressablesImpl.ResourceLocatorInfo>.MoveNext
	|-List.Enumerator<Animator>.MoveNext
	|-List.Enumerator<Collider>.MoveNext
	|-List.Enumerator<PersistentCall>.MoveNext
	|-List.Enumerator<IAnimationWindowPreview>.MoveNext
	|-List.Enumerator<GUILayoutEntry>.MoveNext
	|-List.Enumerator<GameObject>.MoveNext
	|-List.Enumerator<GameObject[]>.MoveNext
	|-List.Enumerator<ISubsystem>.MoveNext
	|-List.Enumerator<ISubsystemDescriptor>.MoveNext
	|-List.Enumerator<ISubsystemDescriptorImpl>.MoveNext
	|-List.Enumerator<Material>.MoveNext
	|-List.Enumerator<ParticleSystem>.MoveNext
	|-List.Enumerator<RenderTexture>.MoveNext
	|-List.Enumerator<IUpdateReceiver>.MoveNext
	|-List.Enumerator<IResourceLocation>.MoveNext
	|-List.Enumerator<ResourceManager.InstanceOperation>.MoveNext
	|-List.Enumerator<ScriptableObject>.MoveNext
	|-List.Enumerator<SkinnedMeshRenderer>.MoveNext
	|-List.Enumerator<Terrain>.MoveNext
	|-List.Enumerator<RuntimeElement>.MoveNext
	|-List.Enumerator<TimelineClip>.MoveNext
	|-List.Enumerator<Transform>.MoveNext
	|-List.Enumerator<Image>.MoveNext
	|-List.Enumerator<EventCallbackFunctorBase>.MoveNext
	|-List.Enumerator<IEventDispatchingStrategy>.MoveNext
	|-List.Enumerator<Panel>.MoveNext
	|-List.Enumerator<VisualElement>.MoveNext
	|-List.Enumerator<UpPointData>.MoveNext
	|
	|-RVA: 0x34F540 Offset: 0x34F641 VA: 0x34F540
	|-List.Enumerator<AS_ToolController.ChargeInfo>.MoveNext
	|
	|-RVA: 0x34F6C0 Offset: 0x34F7C1 VA: 0x34F6C0
	|-List.Enumerator<BuildItemData>.MoveNext
	|
	|-RVA: 0x34F880 Offset: 0x34F981 VA: 0x34F880
	|-List.Enumerator<ButtonLinker.LinkObject>.MoveNext
	|
	|-RVA: 0x34F9C0 Offset: 0x34FAC1 VA: 0x34F9C0
	|-List.Enumerator<CharaCallTable.BustupTable>.MoveNext
	|
	|-RVA: 0x34FB10 Offset: 0x34FC11 VA: 0x34FB10
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>.MoveNext
	|
	|-RVA: 0x34FC60 Offset: 0x34FD61 VA: 0x34FC60
	|-List.Enumerator<CameraState.CustomBlendable>.MoveNext
	|
	|-RVA: 0x34FDA0 Offset: 0x34FEA1 VA: 0x34FDA0
	|-List.Enumerator<CinemachineClearShot.Pair>.MoveNext
	|
	|-RVA: 0x34FEE0 Offset: 0x34FFE1 VA: 0x34FEE0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.MoveNext
	|
	|-RVA: 0x350030 Offset: 0x350131 VA: 0x350030
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.MoveNext
	|
	|-RVA: 0x3501B0 Offset: 0x3502B1 VA: 0x3501B0
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNext
	|
	|-RVA: 0x350370 Offset: 0x350471 VA: 0x350370
	|-List.Enumerator<CropDataTable>.MoveNext
	|
	|-RVA: 0x352EE0 Offset: 0x352FE1 VA: 0x352EE0
	|-List.Enumerator<ActorID>.MoveNext
	|-List.Enumerator<Alliance>.MoveNext
	|-List.Enumerator<GameFlagData>.MoveNext
	|-List.Enumerator<NPCID>.MoveNext
	|-List.Enumerator<VariationNo>.MoveNext
	|-List.Enumerator<ItemID>.MoveNext
	|-List.Enumerator<Prefab>.MoveNext
	|-List.Enumerator<Texture>.MoveNext
	|-List.Enumerator<MonsterModelDataID>.MoveNext
	|-List.Enumerator<SoundID>.MoveNext
	|-List.Enumerator<Int32Enum>.MoveNext
	|-List.Enumerator<UITextDic.DICID>.MoveNext
	|
	|-RVA: 0x350530 Offset: 0x350631 VA: 0x350530
	|-List.Enumerator<DropItemParam>.MoveNext
	|
	|-RVA: 0x350680 Offset: 0x350781 VA: 0x350680
	|-List.Enumerator<ErosionBrush.UndoStep>.MoveNext
	|
	|-RVA: 0x3507F0 Offset: 0x3508F1 VA: 0x3507F0
	|-List.Enumerator<EventCheckId>.MoveNext
	|
	|-RVA: 0x350950 Offset: 0x350A51 VA: 0x350950
	|-List.Enumerator<EventFlagProgressData>.MoveNext
	|
	|-RVA: 0x350A90 Offset: 0x350B91 VA: 0x350A90
	|-List.Enumerator<FesNpcScoreData>.MoveNext
	|
	|-RVA: 0x350BE0 Offset: 0x350CE1 VA: 0x350BE0
	|-List.Enumerator<MiningPointSaveData>.MoveNext
	|
	|-RVA: 0x350D70 Offset: 0x350E71 VA: 0x350D70
	|-List.Enumerator<MonsterHutSaveData>.MoveNext
	|
	|-RVA: 0x350EE0 Offset: 0x350FE1 VA: 0x350EE0
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>.MoveNext
	|
	|-RVA: 0x351030 Offset: 0x351131 VA: 0x351030
	|-List.Enumerator<NPCActionData>.MoveNext
	|
	|-RVA: 0x3511C0 Offset: 0x3512C1 VA: 0x3511C0
	|-List.Enumerator<NpcPlaceSchedule>.MoveNext
	|
	|-RVA: 0x351330 Offset: 0x351431 VA: 0x351330
	|-List.Enumerator<OrderLotterySaveParameter>.MoveNext
	|
	|-RVA: 0x351490 Offset: 0x351591 VA: 0x351490
	|-List.Enumerator<OrderSaveParameter>.MoveNext
	|
	|-RVA: 0x3515F0 Offset: 0x3516F1 VA: 0x3515F0
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNext
	|
	|-RVA: 0x351730 Offset: 0x351831 VA: 0x351730
	|-List.Enumerator<ShopCatalogPage>.MoveNext
	|
	|-RVA: 0x351880 Offset: 0x351981 VA: 0x351880
	|-List.Enumerator<ShopNpcTalk>.MoveNext
	|
	|-RVA: 0x351A00 Offset: 0x351B01 VA: 0x351A00
	|-List.Enumerator<SubtitleDataTable.Data>.MoveNext
	|
	|-RVA: 0x351B50 Offset: 0x351C51 VA: 0x351B50
	|-List.Enumerator<SubtitleDataTable.DataList>.MoveNext
	|
	|-RVA: 0x351CA0 Offset: 0x351DA1 VA: 0x351CA0
	|-List.Enumerator<SubtitleHudDataTable.Data>.MoveNext
	|
	|-RVA: 0x351E00 Offset: 0x351F01 VA: 0x351E00
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>.MoveNext
	|
	|-RVA: 0x351F70 Offset: 0x352071 VA: 0x351F70
	|-List.Enumerator<Schedule>.MoveNext
	|
	|-RVA: 0x3520E0 Offset: 0x3521E1 VA: 0x3520E0
	|-List.Enumerator<CurveSample>.MoveNext
	|
	|-RVA: 0x352260 Offset: 0x352361 VA: 0x352260
	|-List.Enumerator<bool>.MoveNext
	|
	|-RVA: 0x3523A0 Offset: 0x3524A1 VA: 0x3523A0
	|-List.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x3524E0 Offset: 0x3525E1 VA: 0x3524E0
	|-List.Enumerator<char>.MoveNext
	|
	|-RVA: 0x352620 Offset: 0x352721 VA: 0x352620
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNext
	|
	|-RVA: 0x352760 Offset: 0x352861 VA: 0x352760
	|-List.Enumerator<KeyValuePair<int, FishSwim>>.MoveNext
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x3528A0 Offset: 0x3529A1 VA: 0x3528A0
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x3529E0 Offset: 0x352AE1 VA: 0x3529E0
	|-List.Enumerator<DateTime>.MoveNext
	|
	|-RVA: 0x352B20 Offset: 0x352C21 VA: 0x352B20
	|-List.Enumerator<double>.MoveNext
	|
	|-RVA: 0x352C60 Offset: 0x352D61 VA: 0x352C60
	|-List.Enumerator<short>.MoveNext
	|
	|-RVA: 0x352DA0 Offset: 0x352EA1 VA: 0x352DA0
	|-List.Enumerator<int>.MoveNext
	|
	|-RVA: 0x353020 Offset: 0x353121 VA: 0x353020
	|-List.Enumerator<long>.MoveNext
	|
	|-RVA: 0x353160 Offset: 0x353261 VA: 0x353160
	|-List.Enumerator<InterpretedFrameInfo>.MoveNext
	|
	|-RVA: 0x3532A0 Offset: 0x3533A1 VA: 0x3532A0
	|-List.Enumerator<Nullable<Int32Enum>>.MoveNext
	|
	|-RVA: 0x3533F0 Offset: 0x3534F1 VA: 0x3533F0
	|-List.Enumerator<Nullable<Bounds>>.MoveNext
	|
	|-RVA: 0x353570 Offset: 0x353671 VA: 0x353570
	|-List.Enumerator<Nullable<BoundsInt>>.MoveNext
	|
	|-RVA: 0x3536E0 Offset: 0x3537E1 VA: 0x3536E0
	|-List.Enumerator<Nullable<Color32>>.MoveNext
	|
	|-RVA: 0x353830 Offset: 0x353931 VA: 0x353830
	|-List.Enumerator<Nullable<Color>>.MoveNext
	|
	|-RVA: 0x3539A0 Offset: 0x353AA1 VA: 0x3539A0
	|-List.Enumerator<Nullable<GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x353B00 Offset: 0x353C01 VA: 0x353B00
	|-List.Enumerator<Nullable<GradientColorKey>>.MoveNext
	|
	|-RVA: 0x353C70 Offset: 0x353D71 VA: 0x353C70
	|-List.Enumerator<Nullable<Keyframe>>.MoveNext
	|
	|-RVA: 0x353DD0 Offset: 0x353ED1 VA: 0x353DD0
	|-List.Enumerator<Nullable<LayerMask>>.MoveNext
	|
	|-RVA: 0x353F20 Offset: 0x354021 VA: 0x353F20
	|-List.Enumerator<Nullable<Matrix4x4>>.MoveNext
	|
	|-RVA: 0x3540C0 Offset: 0x3541C1 VA: 0x3540C0
	|-List.Enumerator<Nullable<Quaternion>>.MoveNext
	|
	|-RVA: 0x354230 Offset: 0x354331 VA: 0x354230
	|-List.Enumerator<Nullable<RangeInt>>.MoveNext
	|
	|-RVA: 0x354390 Offset: 0x354491 VA: 0x354390
	|-List.Enumerator<Nullable<Rect>>.MoveNext
	|
	|-RVA: 0x354500 Offset: 0x354601 VA: 0x354500
	|-List.Enumerator<Nullable<RectInt>>.MoveNext
	|
	|-RVA: 0x354670 Offset: 0x354771 VA: 0x354670
	|-List.Enumerator<Nullable<Vector2>>.MoveNext
	|
	|-RVA: 0x3547D0 Offset: 0x3548D1 VA: 0x3547D0
	|-List.Enumerator<Nullable<Vector2Int>>.MoveNext
	|
	|-RVA: 0x354920 Offset: 0x354A21 VA: 0x354920
	|-List.Enumerator<Nullable<Vector3>>.MoveNext
	|
	|-RVA: 0x354A60 Offset: 0x354B61 VA: 0x354A60
	|-List.Enumerator<Nullable<Vector3Int>>.MoveNext
	|
	|-RVA: 0x31B070 Offset: 0x31B171 VA: 0x31B070
	|-List.Enumerator<Nullable<Vector4>>.MoveNext
	|
	|-RVA: 0x31B380 Offset: 0x31B481 VA: 0x31B380
	|-List.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x31B4C0 Offset: 0x31B5C1 VA: 0x31B4C0
	|-List.Enumerator<float>.MoveNext
	|
	|-RVA: 0x31B600 Offset: 0x31B701 VA: 0x31B600
	|-List.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x31B740 Offset: 0x31B841 VA: 0x31B740
	|-List.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x31B880 Offset: 0x31B981 VA: 0x31B880
	|-List.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x31C000 Offset: 0x31C101 VA: 0x31C000
	|-List.Enumerator<ValueTuple<CharacterBase, float>>.MoveNext
	|-List.Enumerator<ValueTuple<object, float>>.MoveNext
	|
	|-RVA: 0x31BC40 Offset: 0x31BD41 VA: 0x31BC40
	|-List.Enumerator<ValueTuple<SoundID, EnvironmentSoundController>>.MoveNext
	|-List.Enumerator<ValueTuple<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x31B9C0 Offset: 0x31BAC1 VA: 0x31B9C0
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x31BB00 Offset: 0x31BC01 VA: 0x31BB00
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x31BD80 Offset: 0x31BE81 VA: 0x31BD80
	|-List.Enumerator<ValueTuple<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x31BEC0 Offset: 0x31BFC1 VA: 0x31BEC0
	|-List.Enumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x31C150 Offset: 0x31C251 VA: 0x31C150
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x31C2B0 Offset: 0x31C3B1 VA: 0x31C2B0
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.MoveNext
	|-List.Enumerator<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>.MoveNext
	|
	|-RVA: 0x31C440 Offset: 0x31C541 VA: 0x31C440
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.MoveNext
	|
	|-RVA: 0x31C5D0 Offset: 0x31C6D1 VA: 0x31C5D0
	|-List.Enumerator<TutorialUnlockFlagData>.MoveNext
	|
	|-RVA: 0x31C720 Offset: 0x31C821 VA: 0x31C720
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>.MoveNext
	|
	|-RVA: 0x31C870 Offset: 0x31C971 VA: 0x31C870
	|-List.Enumerator<CapEdge>.MoveNext
	|
	|-RVA: 0x31C9F0 Offset: 0x31CAF1 VA: 0x31C9F0
	|-List.Enumerator<MeshDataConnectivity.Face>.MoveNext
	|
	|-RVA: 0x31CB40 Offset: 0x31CC41 VA: 0x31CB40
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>.MoveNext
	|
	|-RVA: 0x31CCB0 Offset: 0x31CDB1 VA: 0x31CCB0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>.MoveNext
	|
	|-RVA: 0x31CE20 Offset: 0x31CF21 VA: 0x31CE20
	|-List.Enumerator<NavMeshBuildMarkup>.MoveNext
	|
	|-RVA: 0x31CF80 Offset: 0x31D081 VA: 0x31CF80
	|-List.Enumerator<NavMeshBuildSource>.MoveNext
	|
	|-RVA: 0x31D130 Offset: 0x31D231 VA: 0x31D130
	|-List.Enumerator<ConstraintSource>.MoveNext
	|
	|-RVA: 0x31D270 Offset: 0x31D371 VA: 0x31D270
	|-List.Enumerator<AnimatorClipInfo>.MoveNext
	|
	|-RVA: 0x31D3B0 Offset: 0x31D4B1 VA: 0x31D3B0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x31D500 Offset: 0x31D601 VA: 0x31D500
	|-List.Enumerator<BoneWeight>.MoveNext
	|
	|-RVA: 0x31D670 Offset: 0x31D771 VA: 0x31D670
	|-List.Enumerator<Bounds>.MoveNext
	|
	|-RVA: 0x31D7E0 Offset: 0x31D8E1 VA: 0x31D7E0
	|-List.Enumerator<BoundsInt>.MoveNext
	|
	|-RVA: 0x31D940 Offset: 0x31DA41 VA: 0x31D940
	|-List.Enumerator<Color32>.MoveNext
	|
	|-RVA: 0x31DA80 Offset: 0x31DB81 VA: 0x31DA80
	|-List.Enumerator<Color>.MoveNext
	|
	|-RVA: 0x31DBE0 Offset: 0x31DCE1 VA: 0x31DBE0
	|-List.Enumerator<CombineInstance>.MoveNext
	|
	|-RVA: 0x31DDA0 Offset: 0x31DEA1 VA: 0x31DDA0
	|-List.Enumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x31DF20 Offset: 0x31E021 VA: 0x31DF20
	|-List.Enumerator<GradientAlphaKey>.MoveNext
	|
	|-RVA: 0x31E070 Offset: 0x31E171 VA: 0x31E070
	|-List.Enumerator<GradientColorKey>.MoveNext
	|
	|-RVA: 0x31E1E0 Offset: 0x31E2E1 VA: 0x31E1E0
	|-List.Enumerator<Keyframe>.MoveNext
	|
	|-RVA: 0x31E350 Offset: 0x31E451 VA: 0x31E350
	|-List.Enumerator<LayerMask>.MoveNext
	|
	|-RVA: 0x31E4A0 Offset: 0x31E5A1 VA: 0x31E4A0
	|-List.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x31E640 Offset: 0x31E741 VA: 0x31E640
	|-List.Enumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x31E7C0 Offset: 0x31E8C1 VA: 0x31E7C0
	|-List.Enumerator<Playable>.MoveNext
	|
	|-RVA: 0x31E910 Offset: 0x31EA11 VA: 0x31E910
	|-List.Enumerator<PlayableBinding>.MoveNext
	|
	|-RVA: 0x31EA70 Offset: 0x31EB71 VA: 0x31EA70
	|-List.Enumerator<PlayableGraph>.MoveNext
	|
	|-RVA: 0x31EBB0 Offset: 0x31ECB1 VA: 0x31EBB0
	|-List.Enumerator<Edge>.MoveNext
	|
	|-RVA: 0x31ECF0 Offset: 0x31EDF1 VA: 0x31ECF0
	|-List.Enumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x31EE30 Offset: 0x31EF31 VA: 0x31EE30
	|-List.Enumerator<RangeInt>.MoveNext
	|
	|-RVA: 0x31EF80 Offset: 0x31F081 VA: 0x31EF80
	|-List.Enumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x31F110 Offset: 0x31F211 VA: 0x31F110
	|-List.Enumerator<RaycastHit>.MoveNext
	|
	|-RVA: 0x31F290 Offset: 0x31F391 VA: 0x31F290
	|-List.Enumerator<Rect>.MoveNext
	|
	|-RVA: 0x31F3D0 Offset: 0x31F4D1 VA: 0x31F3D0
	|-List.Enumerator<RectInt>.MoveNext
	|
	|-RVA: 0x31F510 Offset: 0x31F611 VA: 0x31F510
	|-List.Enumerator<ReflectionProbeBlendInfo>.MoveNext
	|
	|-RVA: 0x31F670 Offset: 0x31F771 VA: 0x31F670
	|-List.Enumerator<SphericalHarmonicsL2>.MoveNext
	|
	|-RVA: 0x31F830 Offset: 0x31F931 VA: 0x31F830
	|-List.Enumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x31F980 Offset: 0x31FA81 VA: 0x31F980
	|-List.Enumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x31FAF0 Offset: 0x31FBF1 VA: 0x31FAF0
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>.MoveNext
	|
	|-RVA: 0x31FC60 Offset: 0x31FD61 VA: 0x31FC60
	|-List.Enumerator<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x31FDE0 Offset: 0x31FEE1 VA: 0x31FDE0
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.MoveNext
	|
	|-RVA: 0x31FF50 Offset: 0x320051 VA: 0x31FF50
	|-List.Enumerator<ObjectInitializationData>.MoveNext
	|
	|-RVA: 0x3200C0 Offset: 0x3201C1 VA: 0x3200C0
	|-List.Enumerator<GlyphRect>.MoveNext
	|
	|-RVA: 0x320210 Offset: 0x320311 VA: 0x320210
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNext
	|
	|-RVA: 0x320390 Offset: 0x320491 VA: 0x320390
	|-List.Enumerator<IntervalTreeNode>.MoveNext
	|
	|-RVA: 0x320500 Offset: 0x320601 VA: 0x320500
	|-List.Enumerator<IntervalTree.Entry<object>>.MoveNext
	|
	|-RVA: 0x320670 Offset: 0x320771 VA: 0x320670
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNext
	|
	|-RVA: 0x3207E0 Offset: 0x3208E1 VA: 0x3207E0
	|-List.Enumerator<UICharInfo>.MoveNext
	|
	|-RVA: 0x320930 Offset: 0x320A31 VA: 0x320930
	|-List.Enumerator<FocusController.FocusedElement>.MoveNext
	|
	|-RVA: 0x320A70 Offset: 0x320B71 VA: 0x320A70
	|-List.Enumerator<UILineInfo>.MoveNext
	|
	|-RVA: 0x320BD0 Offset: 0x320CD1 VA: 0x320BD0
	|-List.Enumerator<UIVertex>.MoveNext
	|
	|-RVA: 0x320D80 Offset: 0x320E81 VA: 0x320D80
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x320EE0 Offset: 0x320FE1 VA: 0x320EE0
	|-List.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x321020 Offset: 0x321121 VA: 0x321020
	|-List.Enumerator<Vector2Int>.MoveNext
	|
	|-RVA: 0x321170 Offset: 0x321271 VA: 0x321170
	|-List.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x3212D0 Offset: 0x3213D1 VA: 0x3212D0
	|-List.Enumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x321420 Offset: 0x321521 VA: 0x321420
	|-List.Enumerator<Vector4>.MoveNext
	|
	|-RVA: 0x321580 Offset: 0x321681 VA: 0x321580
	|-List.Enumerator<WarpPoints.WarpPoint>.MoveNext
	|
	|-RVA: 0x321740 Offset: 0x321841 VA: 0x321740
	|-List.Enumerator<YieldItemParam>.MoveNext
	|
	|-RVA: 0x321890 Offset: 0x321991 VA: 0x321890
	|-List.Enumerator<stCommand_t>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F550 Offset: 0x34F651 VA: 0x34F550
	|-List.Enumerator<AS_ToolController.ChargeInfo>.MoveNextRare
	|
	|-RVA: 0x34F6D0 Offset: 0x34F7D1 VA: 0x34F6D0
	|-List.Enumerator<BuildItemData>.MoveNextRare
	|
	|-RVA: 0x34F890 Offset: 0x34F991 VA: 0x34F890
	|-List.Enumerator<ButtonLinker.LinkObject>.MoveNextRare
	|
	|-RVA: 0x34F9D0 Offset: 0x34FAD1 VA: 0x34F9D0
	|-List.Enumerator<CharaCallTable.BustupTable>.MoveNextRare
	|
	|-RVA: 0x34FB20 Offset: 0x34FC21 VA: 0x34FB20
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>.MoveNextRare
	|
	|-RVA: 0x34FC70 Offset: 0x34FD71 VA: 0x34FC70
	|-List.Enumerator<CameraState.CustomBlendable>.MoveNextRare
	|
	|-RVA: 0x34FDB0 Offset: 0x34FEB1 VA: 0x34FDB0
	|-List.Enumerator<CinemachineClearShot.Pair>.MoveNextRare
	|
	|-RVA: 0x34FEF0 Offset: 0x34FFF1 VA: 0x34FEF0
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.MoveNextRare
	|
	|-RVA: 0x350040 Offset: 0x350141 VA: 0x350040
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.MoveNextRare
	|
	|-RVA: 0x3501C0 Offset: 0x3502C1 VA: 0x3501C0
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNextRare
	|
	|-RVA: 0x350380 Offset: 0x350481 VA: 0x350380
	|-List.Enumerator<CropDataTable>.MoveNextRare
	|
	|-RVA: 0x350540 Offset: 0x350641 VA: 0x350540
	|-List.Enumerator<DropItemParam>.MoveNextRare
	|
	|-RVA: 0x350690 Offset: 0x350791 VA: 0x350690
	|-List.Enumerator<ErosionBrush.UndoStep>.MoveNextRare
	|
	|-RVA: 0x350800 Offset: 0x350901 VA: 0x350800
	|-List.Enumerator<EventCheckId>.MoveNextRare
	|
	|-RVA: 0x350960 Offset: 0x350A61 VA: 0x350960
	|-List.Enumerator<EventFlagProgressData>.MoveNextRare
	|
	|-RVA: 0x350AA0 Offset: 0x350BA1 VA: 0x350AA0
	|-List.Enumerator<FesNpcScoreData>.MoveNextRare
	|
	|-RVA: 0x350BF0 Offset: 0x350CF1 VA: 0x350BF0
	|-List.Enumerator<MiningPointSaveData>.MoveNextRare
	|
	|-RVA: 0x350D80 Offset: 0x350E81 VA: 0x350D80
	|-List.Enumerator<MonsterHutSaveData>.MoveNextRare
	|
	|-RVA: 0x350EF0 Offset: 0x350FF1 VA: 0x350EF0
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>.MoveNextRare
	|
	|-RVA: 0x351040 Offset: 0x351141 VA: 0x351040
	|-List.Enumerator<NPCActionData>.MoveNextRare
	|
	|-RVA: 0x3511D0 Offset: 0x3512D1 VA: 0x3511D0
	|-List.Enumerator<NpcPlaceSchedule>.MoveNextRare
	|
	|-RVA: 0x351340 Offset: 0x351441 VA: 0x351340
	|-List.Enumerator<OrderLotterySaveParameter>.MoveNextRare
	|
	|-RVA: 0x3514A0 Offset: 0x3515A1 VA: 0x3514A0
	|-List.Enumerator<OrderSaveParameter>.MoveNextRare
	|
	|-RVA: 0x351600 Offset: 0x351701 VA: 0x351600
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNextRare
	|
	|-RVA: 0x351740 Offset: 0x351841 VA: 0x351740
	|-List.Enumerator<ShopCatalogPage>.MoveNextRare
	|
	|-RVA: 0x351890 Offset: 0x351991 VA: 0x351890
	|-List.Enumerator<ShopNpcTalk>.MoveNextRare
	|
	|-RVA: 0x351A10 Offset: 0x351B11 VA: 0x351A10
	|-List.Enumerator<SubtitleDataTable.Data>.MoveNextRare
	|
	|-RVA: 0x351B60 Offset: 0x351C61 VA: 0x351B60
	|-List.Enumerator<SubtitleDataTable.DataList>.MoveNextRare
	|
	|-RVA: 0x351CB0 Offset: 0x351DB1 VA: 0x351CB0
	|-List.Enumerator<SubtitleHudDataTable.Data>.MoveNextRare
	|
	|-RVA: 0x351E10 Offset: 0x351F11 VA: 0x351E10
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>.MoveNextRare
	|
	|-RVA: 0x351F80 Offset: 0x352081 VA: 0x351F80
	|-List.Enumerator<Schedule>.MoveNextRare
	|
	|-RVA: 0x3520F0 Offset: 0x3521F1 VA: 0x3520F0
	|-List.Enumerator<CurveSample>.MoveNextRare
	|
	|-RVA: 0x352270 Offset: 0x352371 VA: 0x352270
	|-List.Enumerator<bool>.MoveNextRare
	|
	|-RVA: 0x3523B0 Offset: 0x3524B1 VA: 0x3523B0
	|-List.Enumerator<byte>.MoveNextRare
	|
	|-RVA: 0x3524F0 Offset: 0x3525F1 VA: 0x3524F0
	|-List.Enumerator<char>.MoveNextRare
	|
	|-RVA: 0x352630 Offset: 0x352731 VA: 0x352630
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNextRare
	|
	|-RVA: 0x352770 Offset: 0x352871 VA: 0x352770
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNextRare
	|
	|-RVA: 0x3528B0 Offset: 0x3529B1 VA: 0x3528B0
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNextRare
	|
	|-RVA: 0x3529F0 Offset: 0x352AF1 VA: 0x3529F0
	|-List.Enumerator<DateTime>.MoveNextRare
	|
	|-RVA: 0x352B30 Offset: 0x352C31 VA: 0x352B30
	|-List.Enumerator<double>.MoveNextRare
	|
	|-RVA: 0x352C70 Offset: 0x352D71 VA: 0x352C70
	|-List.Enumerator<short>.MoveNextRare
	|
	|-RVA: 0x352DB0 Offset: 0x352EB1 VA: 0x352DB0
	|-List.Enumerator<int>.MoveNextRare
	|
	|-RVA: 0x352EF0 Offset: 0x352FF1 VA: 0x352EF0
	|-List.Enumerator<Int32Enum>.MoveNextRare
	|
	|-RVA: 0x353030 Offset: 0x353131 VA: 0x353030
	|-List.Enumerator<long>.MoveNextRare
	|
	|-RVA: 0x353170 Offset: 0x353271 VA: 0x353170
	|-List.Enumerator<InterpretedFrameInfo>.MoveNextRare
	|
	|-RVA: 0x3532B0 Offset: 0x3533B1 VA: 0x3532B0
	|-List.Enumerator<Nullable<Int32Enum>>.MoveNextRare
	|
	|-RVA: 0x353400 Offset: 0x353501 VA: 0x353400
	|-List.Enumerator<Nullable<Bounds>>.MoveNextRare
	|
	|-RVA: 0x353580 Offset: 0x353681 VA: 0x353580
	|-List.Enumerator<Nullable<BoundsInt>>.MoveNextRare
	|
	|-RVA: 0x3536F0 Offset: 0x3537F1 VA: 0x3536F0
	|-List.Enumerator<Nullable<Color32>>.MoveNextRare
	|
	|-RVA: 0x353840 Offset: 0x353941 VA: 0x353840
	|-List.Enumerator<Nullable<Color>>.MoveNextRare
	|
	|-RVA: 0x3539B0 Offset: 0x353AB1 VA: 0x3539B0
	|-List.Enumerator<Nullable<GradientAlphaKey>>.MoveNextRare
	|
	|-RVA: 0x353B10 Offset: 0x353C11 VA: 0x353B10
	|-List.Enumerator<Nullable<GradientColorKey>>.MoveNextRare
	|
	|-RVA: 0x353C80 Offset: 0x353D81 VA: 0x353C80
	|-List.Enumerator<Nullable<Keyframe>>.MoveNextRare
	|
	|-RVA: 0x353DE0 Offset: 0x353EE1 VA: 0x353DE0
	|-List.Enumerator<Nullable<LayerMask>>.MoveNextRare
	|
	|-RVA: 0x353F30 Offset: 0x354031 VA: 0x353F30
	|-List.Enumerator<Nullable<Matrix4x4>>.MoveNextRare
	|
	|-RVA: 0x3540D0 Offset: 0x3541D1 VA: 0x3540D0
	|-List.Enumerator<Nullable<Quaternion>>.MoveNextRare
	|
	|-RVA: 0x354240 Offset: 0x354341 VA: 0x354240
	|-List.Enumerator<Nullable<RangeInt>>.MoveNextRare
	|
	|-RVA: 0x3543A0 Offset: 0x3544A1 VA: 0x3543A0
	|-List.Enumerator<Nullable<Rect>>.MoveNextRare
	|
	|-RVA: 0x354510 Offset: 0x354611 VA: 0x354510
	|-List.Enumerator<Nullable<RectInt>>.MoveNextRare
	|
	|-RVA: 0x354680 Offset: 0x354781 VA: 0x354680
	|-List.Enumerator<Nullable<Vector2>>.MoveNextRare
	|
	|-RVA: 0x3547E0 Offset: 0x3548E1 VA: 0x3547E0
	|-List.Enumerator<Nullable<Vector2Int>>.MoveNextRare
	|
	|-RVA: 0x354930 Offset: 0x354A31 VA: 0x354930
	|-List.Enumerator<Nullable<Vector3>>.MoveNextRare
	|
	|-RVA: 0x354A70 Offset: 0x354B71 VA: 0x354A70
	|-List.Enumerator<Nullable<Vector3Int>>.MoveNextRare
	|
	|-RVA: 0x31B080 Offset: 0x31B181 VA: 0x31B080
	|-List.Enumerator<Nullable<Vector4>>.MoveNextRare
	|
	|-RVA: 0x31B1E0 Offset: 0x31B2E1 VA: 0x31B1E0
	|-List.Enumerator<object>.MoveNextRare
	|
	|-RVA: 0x31B390 Offset: 0x31B491 VA: 0x31B390
	|-List.Enumerator<sbyte>.MoveNextRare
	|
	|-RVA: 0x31B4D0 Offset: 0x31B5D1 VA: 0x31B4D0
	|-List.Enumerator<float>.MoveNextRare
	|
	|-RVA: 0x31B610 Offset: 0x31B711 VA: 0x31B610
	|-List.Enumerator<ushort>.MoveNextRare
	|
	|-RVA: 0x31B750 Offset: 0x31B851 VA: 0x31B750
	|-List.Enumerator<uint>.MoveNextRare
	|
	|-RVA: 0x31B890 Offset: 0x31B991 VA: 0x31B890
	|-List.Enumerator<ulong>.MoveNextRare
	|
	|-RVA: 0x31B9D0 Offset: 0x31BAD1 VA: 0x31B9D0
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>.MoveNextRare
	|
	|-RVA: 0x31BB10 Offset: 0x31BC11 VA: 0x31BB10
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.MoveNextRare
	|
	|-RVA: 0x31BC50 Offset: 0x31BD51 VA: 0x31BC50
	|-List.Enumerator<ValueTuple<Int32Enum, object>>.MoveNextRare
	|
	|-RVA: 0x31BD90 Offset: 0x31BE91 VA: 0x31BD90
	|-List.Enumerator<ValueTuple<object, Int32Enum>>.MoveNextRare
	|
	|-RVA: 0x31BED0 Offset: 0x31BFD1 VA: 0x31BED0
	|-List.Enumerator<ValueTuple<object, object>>.MoveNextRare
	|
	|-RVA: 0x31C010 Offset: 0x31C111 VA: 0x31C010
	|-List.Enumerator<ValueTuple<object, float>>.MoveNextRare
	|
	|-RVA: 0x31C160 Offset: 0x31C261 VA: 0x31C160
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.MoveNextRare
	|
	|-RVA: 0x31C2C0 Offset: 0x31C3C1 VA: 0x31C2C0
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.MoveNextRare
	|
	|-RVA: 0x31C450 Offset: 0x31C551 VA: 0x31C450
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.MoveNextRare
	|
	|-RVA: 0x31C5E0 Offset: 0x31C6E1 VA: 0x31C5E0
	|-List.Enumerator<TutorialUnlockFlagData>.MoveNextRare
	|
	|-RVA: 0x31C730 Offset: 0x31C831 VA: 0x31C730
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>.MoveNextRare
	|
	|-RVA: 0x31C880 Offset: 0x31C981 VA: 0x31C880
	|-List.Enumerator<CapEdge>.MoveNextRare
	|
	|-RVA: 0x31CA00 Offset: 0x31CB01 VA: 0x31CA00
	|-List.Enumerator<MeshDataConnectivity.Face>.MoveNextRare
	|
	|-RVA: 0x31CB50 Offset: 0x31CC51 VA: 0x31CB50
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>.MoveNextRare
	|
	|-RVA: 0x31CCC0 Offset: 0x31CDC1 VA: 0x31CCC0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>.MoveNextRare
	|
	|-RVA: 0x31CE30 Offset: 0x31CF31 VA: 0x31CE30
	|-List.Enumerator<NavMeshBuildMarkup>.MoveNextRare
	|
	|-RVA: 0x31CF90 Offset: 0x31D091 VA: 0x31CF90
	|-List.Enumerator<NavMeshBuildSource>.MoveNextRare
	|
	|-RVA: 0x31D140 Offset: 0x31D241 VA: 0x31D140
	|-List.Enumerator<ConstraintSource>.MoveNextRare
	|
	|-RVA: 0x31D280 Offset: 0x31D381 VA: 0x31D280
	|-List.Enumerator<AnimatorClipInfo>.MoveNextRare
	|
	|-RVA: 0x31D3C0 Offset: 0x31D4C1 VA: 0x31D3C0
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNextRare
	|
	|-RVA: 0x31D510 Offset: 0x31D611 VA: 0x31D510
	|-List.Enumerator<BoneWeight>.MoveNextRare
	|
	|-RVA: 0x31D680 Offset: 0x31D781 VA: 0x31D680
	|-List.Enumerator<Bounds>.MoveNextRare
	|
	|-RVA: 0x31D7F0 Offset: 0x31D8F1 VA: 0x31D7F0
	|-List.Enumerator<BoundsInt>.MoveNextRare
	|
	|-RVA: 0x31D950 Offset: 0x31DA51 VA: 0x31D950
	|-List.Enumerator<Color32>.MoveNextRare
	|
	|-RVA: 0x31DA90 Offset: 0x31DB91 VA: 0x31DA90
	|-List.Enumerator<Color>.MoveNextRare
	|
	|-RVA: 0x31DBF0 Offset: 0x31DCF1 VA: 0x31DBF0
	|-List.Enumerator<CombineInstance>.MoveNextRare
	|
	|-RVA: 0x31DDB0 Offset: 0x31DEB1 VA: 0x31DDB0
	|-List.Enumerator<RaycastResult>.MoveNextRare
	|
	|-RVA: 0x31DF30 Offset: 0x31E031 VA: 0x31DF30
	|-List.Enumerator<GradientAlphaKey>.MoveNextRare
	|
	|-RVA: 0x31E080 Offset: 0x31E181 VA: 0x31E080
	|-List.Enumerator<GradientColorKey>.MoveNextRare
	|
	|-RVA: 0x31E1F0 Offset: 0x31E2F1 VA: 0x31E1F0
	|-List.Enumerator<Keyframe>.MoveNextRare
	|
	|-RVA: 0x31E360 Offset: 0x31E461 VA: 0x31E360
	|-List.Enumerator<LayerMask>.MoveNextRare
	|
	|-RVA: 0x31E4B0 Offset: 0x31E5B1 VA: 0x31E4B0
	|-List.Enumerator<Matrix4x4>.MoveNextRare
	|
	|-RVA: 0x31E650 Offset: 0x31E751 VA: 0x31E650
	|-List.Enumerator<ParticleSystem.Particle>.MoveNextRare
	|
	|-RVA: 0x31E7D0 Offset: 0x31E8D1 VA: 0x31E7D0
	|-List.Enumerator<Playable>.MoveNextRare
	|
	|-RVA: 0x31E920 Offset: 0x31EA21 VA: 0x31E920
	|-List.Enumerator<PlayableBinding>.MoveNextRare
	|
	|-RVA: 0x31EA80 Offset: 0x31EB81 VA: 0x31EA80
	|-List.Enumerator<PlayableGraph>.MoveNextRare
	|
	|-RVA: 0x31EBC0 Offset: 0x31ECC1 VA: 0x31EBC0
	|-List.Enumerator<Edge>.MoveNextRare
	|
	|-RVA: 0x31ED00 Offset: 0x31EE01 VA: 0x31ED00
	|-List.Enumerator<Quaternion>.MoveNextRare
	|
	|-RVA: 0x31EE40 Offset: 0x31EF41 VA: 0x31EE40
	|-List.Enumerator<RangeInt>.MoveNextRare
	|
	|-RVA: 0x31EF90 Offset: 0x31F091 VA: 0x31EF90
	|-List.Enumerator<RaycastHit2D>.MoveNextRare
	|
	|-RVA: 0x31F120 Offset: 0x31F221 VA: 0x31F120
	|-List.Enumerator<RaycastHit>.MoveNextRare
	|
	|-RVA: 0x31F2A0 Offset: 0x31F3A1 VA: 0x31F2A0
	|-List.Enumerator<Rect>.MoveNextRare
	|
	|-RVA: 0x31F3E0 Offset: 0x31F4E1 VA: 0x31F3E0
	|-List.Enumerator<RectInt>.MoveNextRare
	|
	|-RVA: 0x31F520 Offset: 0x31F621 VA: 0x31F520
	|-List.Enumerator<ReflectionProbeBlendInfo>.MoveNextRare
	|
	|-RVA: 0x31F680 Offset: 0x31F781 VA: 0x31F680
	|-List.Enumerator<SphericalHarmonicsL2>.MoveNextRare
	|
	|-RVA: 0x31F840 Offset: 0x31F941 VA: 0x31F840
	|-List.Enumerator<VertexAttributeDescriptor>.MoveNextRare
	|
	|-RVA: 0x31F990 Offset: 0x31FA91 VA: 0x31F990
	|-List.Enumerator<AsyncOperationHandle>.MoveNextRare
	|
	|-RVA: 0x31FB00 Offset: 0x31FC01 VA: 0x31FB00
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>.MoveNextRare
	|
	|-RVA: 0x31FC70 Offset: 0x31FD71 VA: 0x31FC70
	|-List.Enumerator<DiagnosticEvent>.MoveNextRare
	|
	|-RVA: 0x31FDF0 Offset: 0x31FEF1 VA: 0x31FDF0
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.MoveNextRare
	|
	|-RVA: 0x31FF60 Offset: 0x320061 VA: 0x31FF60
	|-List.Enumerator<ObjectInitializationData>.MoveNextRare
	|
	|-RVA: 0x3200D0 Offset: 0x3201D1 VA: 0x3200D0
	|-List.Enumerator<GlyphRect>.MoveNextRare
	|
	|-RVA: 0x320220 Offset: 0x320321 VA: 0x320220
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNextRare
	|
	|-RVA: 0x3203A0 Offset: 0x3204A1 VA: 0x3203A0
	|-List.Enumerator<IntervalTreeNode>.MoveNextRare
	|
	|-RVA: 0x320510 Offset: 0x320611 VA: 0x320510
	|-List.Enumerator<IntervalTree.Entry<object>>.MoveNextRare
	|
	|-RVA: 0x320680 Offset: 0x320781 VA: 0x320680
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNextRare
	|
	|-RVA: 0x3207F0 Offset: 0x3208F1 VA: 0x3207F0
	|-List.Enumerator<UICharInfo>.MoveNextRare
	|
	|-RVA: 0x320940 Offset: 0x320A41 VA: 0x320940
	|-List.Enumerator<FocusController.FocusedElement>.MoveNextRare
	|
	|-RVA: 0x320A80 Offset: 0x320B81 VA: 0x320A80
	|-List.Enumerator<UILineInfo>.MoveNextRare
	|
	|-RVA: 0x320BE0 Offset: 0x320CE1 VA: 0x320BE0
	|-List.Enumerator<UIVertex>.MoveNextRare
	|
	|-RVA: 0x320D90 Offset: 0x320E91 VA: 0x320D90
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNextRare
	|
	|-RVA: 0x320EF0 Offset: 0x320FF1 VA: 0x320EF0
	|-List.Enumerator<Vector2>.MoveNextRare
	|
	|-RVA: 0x321030 Offset: 0x321131 VA: 0x321030
	|-List.Enumerator<Vector2Int>.MoveNextRare
	|
	|-RVA: 0x321180 Offset: 0x321281 VA: 0x321180
	|-List.Enumerator<Vector3>.MoveNextRare
	|
	|-RVA: 0x3212E0 Offset: 0x3213E1 VA: 0x3212E0
	|-List.Enumerator<Vector3Int>.MoveNextRare
	|
	|-RVA: 0x321430 Offset: 0x321531 VA: 0x321430
	|-List.Enumerator<Vector4>.MoveNextRare
	|
	|-RVA: 0x321590 Offset: 0x321691 VA: 0x321590
	|-List.Enumerator<WarpPoints.WarpPoint>.MoveNextRare
	|
	|-RVA: 0x321750 Offset: 0x321851 VA: 0x321750
	|-List.Enumerator<YieldItemParam>.MoveNextRare
	|
	|-RVA: 0x3218A0 Offset: 0x3219A1 VA: 0x3218A0
	|-List.Enumerator<stCommand_t>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31B240 Offset: 0x31B341 VA: 0x31B240
	|-List.Enumerator<AIInput>.get_Current
	|-List.Enumerator<AS_MagicController>.get_Current
	|-List.Enumerator<ActionBehaviorCommandData>.get_Current
	|-List.Enumerator<ActionBehaviorCommandInformation>.get_Current
	|-List.Enumerator<Actor>.get_Current
	|-List.Enumerator<ActorController>.get_Current
	|-List.Enumerator<ActorData>.get_Current
	|-List.Enumerator<AdvShowOneImage.AdvSpriteLoader>.get_Current
	|-List.Enumerator<AdvShowOneImage>.get_Current
	|-List.Enumerator<AttackCollider>.get_Current
	|-List.Enumerator<AudmuraCrystal>.get_Current
	|-List.Enumerator<AutomaticLOD.LODLevelData>.get_Current
	|-List.Enumerator<AutomaticLOD>.get_Current
	|-List.Enumerator<BaffamoDodgeManager.BaffamoMonster>.get_Current
	|-List.Enumerator<BgmList>.get_Current
	|-List.Enumerator<BitBase>.get_Current
	|-List.Enumerator<BodyPartsCollision>.get_Current
	|-List.Enumerator<BulletBase>.get_Current
	|-List.Enumerator<BulletColliderBase>.get_Current
	|-List.Enumerator<BulletSubModule>.get_Current
	|-List.Enumerator<ButtonLinker>.get_Current
	|-List.Enumerator<CameraManager.CameraControllerPair>.get_Current
	|-List.Enumerator<CerberusController.DogParam>.get_Current
	|-List.Enumerator<Character>.get_Current
	|-List.Enumerator<CharacterBase>.get_Current
	|-List.Enumerator<CheerVoiceData>.get_Current
	|-List.Enumerator<ChildData>.get_Current
	|-List.Enumerator<CinemachineCollider.VcamExtraState>.get_Current
	|-List.Enumerator<ColliderStreamer>.get_Current
	|-List.Enumerator<CombinedMesh.MaterialMeshInfo>.get_Current
	|-List.Enumerator<CombinedMesh.ObjectInfo>.get_Current
	|-List.Enumerator<CursorEvent>.get_Current
	|-List.Enumerator<DLCPair>.get_Current
	|-List.Enumerator<DeadtreeController.ChestnutController>.get_Current
	|-List.Enumerator<EmotionController>.get_Current
	|-List.Enumerator<EnemyPatrolData.PatrolParameter.PatrollBehaviorTypeKeyAndValue>.get_Current
	|-List.Enumerator<EraseObject>.get_Current
	|-List.Enumerator<EventFlagManager.RequestDisableEventPointData>.get_Current
	|-List.Enumerator<EventPointData>.get_Current
	|-List.Enumerator<EventStartData>.get_Current
	|-List.Enumerator<EventUnlockFlagData>.get_Current
	|-List.Enumerator<CellController>.get_Current
	|-List.Enumerator<FarmCropData>.get_Current
	|-List.Enumerator<FesNpcScore>.get_Current
	|-List.Enumerator<ObjectLoader>.get_Current
	|-List.Enumerator<FishSwim>.get_Current
	|-List.Enumerator<FocusObjectName.BorderElement>.get_Current
	|-List.Enumerator<FracturedChunk.AdjacencyInfo>.get_Current
	|-List.Enumerator<FracturedChunk>.get_Current
	|-List.Enumerator<FriendMonsterManager.FarmInActorData>.get_Current
	|-List.Enumerator<FriendMonsterStatusData>.get_Current
	|-List.Enumerator<BoolKeyframeGroup>.get_Current
	|-List.Enumerator<ColorKeyframe>.get_Current
	|-List.Enumerator<ColorKeyframeGroup>.get_Current
	|-List.Enumerator<NumberKeyframe>.get_Current
	|-List.Enumerator<NumberKeyframeGroup>.get_Current
	|-List.Enumerator<ProfileGroupDefinition>.get_Current
	|-List.Enumerator<TextureKeyframeGroup>.get_Current
	|-List.Enumerator<GateSeasonInfomation>.get_Current
	|-List.Enumerator<GateTimeZoneMonsterInfomation>.get_Current
	|-List.Enumerator<GroupSoundData>.get_Current
	|-List.Enumerator<HUDDualWorkSelectInput.DualSelect>.get_Current
	|-List.Enumerator<HasibirokouSonicWind>.get_Current
	|-List.Enumerator<HateController.HateParameter>.get_Current
	|-List.Enumerator<HumanData>.get_Current
	|-List.Enumerator<HumanDataArray>.get_Current
	|-List.Enumerator<InosisiController.ThornsController>.get_Current
	|-List.Enumerator<ItemDataLinker>.get_Current
	|-List.Enumerator<ItemEquip>.get_Current
	|-List.Enumerator<FurnitureSaveData>.get_Current
	|-List.Enumerator<PlayerItemFurniture2>.get_Current
	|-List.Enumerator<ItemMoveToBasket>.get_Current
	|-List.Enumerator<ItemWeightData>.get_Current
	|-List.Enumerator<KrakenStickController>.get_Current
	|-List.Enumerator<LastBossBone>.get_Current
	|-List.Enumerator<AssetHandle>.get_Current
	|-List.Enumerator<AssetInfo>.get_Current
	|-List.Enumerator<MainEventFlagProgressData>.get_Current
	|-List.Enumerator<MiningPair>.get_Current
	|-List.Enumerator<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.get_Current
	|-List.Enumerator<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>.get_Current
	|-List.Enumerator<MonsterActionBehaviorData>.get_Current
	|-List.Enumerator<MonsterActionInformation>.get_Current
	|-List.Enumerator<MonsterAnimatorStateEvent.NormalizeTimeEvent>.get_Current
	|-List.Enumerator<MonsterControllerBase.DropItemDataParameter>.get_Current
	|-List.Enumerator<MonsterControllerBase>.get_Current
	|-List.Enumerator<MonsterModelData>.get_Current
	|-List.Enumerator<MonsterProjectileActionScriptsController>.get_Current
	|-List.Enumerator<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.get_Current
	|-List.Enumerator<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>.get_Current
	|-List.Enumerator<NpcController>.get_Current
	|-List.Enumerator<NpcData>.get_Current
	|-List.Enumerator<NpcLifeCycleDataRecord>.get_Current
	|-List.Enumerator<NpcPatrolPointData>.get_Current
	|-List.Enumerator<NpcSaveParameter>.get_Current
	|-List.Enumerator<NpcStatusData>.get_Current
	|-List.Enumerator<NpcTimeAction>.get_Current
	|-List.Enumerator<ObjectPooler.Pool>.get_Current
	|-List.Enumerator<OnGroundItem>.get_Current
	|-List.Enumerator<OrderData>.get_Current
	|-List.Enumerator<OrderHUDBlock>.get_Current
	|-List.Enumerator<OrderMasterData>.get_Current
	|-List.Enumerator<PartnerManager.NPCChangeBaseParameter>.get_Current
	|-List.Enumerator<PartnerMonsterBehaviorController>.get_Current
	|-List.Enumerator<PatrolPointMotionData>.get_Current
	|-List.Enumerator<PetNpcPetData>.get_Current
	|-List.Enumerator<PlayerCheerVoiceData>.get_Current
	|-List.Enumerator<Contour>.get_Current
	|-List.Enumerator<DTSweepConstraint>.get_Current
	|-List.Enumerator<DelaunayTriangle>.get_Current
	|-List.Enumerator<EdgeIntersectInfo>.get_Current
	|-List.Enumerator<Point2D>.get_Current
	|-List.Enumerator<Point2DList>.get_Current
	|-List.Enumerator<Polygon>.get_Current
	|-List.Enumerator<PolygonPoint>.get_Current
	|-List.Enumerator<TriangulationConstraint>.get_Current
	|-List.Enumerator<TriangulationPoint>.get_Current
	|-List.Enumerator<PreloadHandle>.get_Current
	|-List.Enumerator<PadBindData>.get_Current
	|-List.Enumerator<FishShipmentRecords>.get_Current
	|-List.Enumerator<ShipmentItemRecords>.get_Current
	|-List.Enumerator<RF5Streamer>.get_Current
	|-List.Enumerator<SubtitleHandler>.get_Current
	|-List.Enumerator<ButtonHintBlock>.get_Current
	|-List.Enumerator<SEController>.get_Current
	|-List.Enumerator<RandomData>.get_Current
	|-List.Enumerator<RecipeDataDispBlock>.get_Current
	|-List.Enumerator<RecipeDataTableArray.RecipeDataTable>.get_Current
	|-List.Enumerator<MP4FileProcessing.Chunk>.get_Current
	|-List.Enumerator<ReviatanIcePillar>.get_Current
	|-List.Enumerator<OptionDefinition>.get_Current
	|-List.Enumerator<OptionsTabController.CategoryInstance>.get_Current
	|-List.Enumerator<SRServiceManager.ServiceStub>.get_Current
	|-List.Enumerator<TimelineToActionScriptExpoter.ActionScriptData>.get_Current
	|-List.Enumerator<ScenarioTalkData>.get_Current
	|-List.Enumerator<SceneSplit>.get_Current
	|-List.Enumerator<SceneTransitionManager.GameObjectEnabled>.get_Current
	|-List.Enumerator<SearchCharacterController.SearchParameter>.get_Current
	|-List.Enumerator<SnowmanManager.Mocomoco>.get_Current
	|-List.Enumerator<CubicBezierCurve>.get_Current
	|-List.Enumerator<ExtrusionSegment.Vertex>.get_Current
	|-List.Enumerator<MeshVertex>.get_Current
	|-List.Enumerator<SplineNode>.get_Current
	|-List.Enumerator<TransformedMesh>.get_Current
	|-List.Enumerator<SubEventData>.get_Current
	|-List.Enumerator<SubEventMasterDataBase>.get_Current
	|-List.Enumerator<List<FarmCropData>>.get_Current
	|-List.Enumerator<List<PolygonPoint>>.get_Current
	|-List.Enumerator<BranchLabel>.get_Current
	|-List.Enumerator<ByRefUpdater>.get_Current
	|-List.Enumerator<LabelScopeInfo>.get_Current
	|-List.Enumerator<IPAddress>.get_Current
	|-List.Enumerator<MonoChunkStream.Chunk>.get_Current
	|-List.Enumerator<WebConnection>.get_Current
	|-List.Enumerator<WebConnectionGroup>.get_Current
	|-List.Enumerator<Assembly>.get_Current
	|-List.Enumerator<X509CertificateImpl>.get_Current
	|-List.Enumerator<string>.get_Current
	|-List.Enumerator<string[]>.get_Current
	|-List.Enumerator<Thread>.get_Current
	|-List.Enumerator<Type>.get_Current
	|-List.Enumerator<TimeManager.JustTimerData>.get_Current
	|-List.Enumerator<ToolInteractionInterface>.get_Current
	|-List.Enumerator<UIButtonLinkerInScrollBox>.get_Current
	|-List.Enumerator<UIFadeOnOffAnimate.ImageGroup>.get_Current
	|-List.Enumerator<UIItemSlot>.get_Current
	|-List.Enumerator<DynamicsSetup.ParseMessage>.get_Current
	|-List.Enumerator<SpringBone>.get_Current
	|-List.Enumerator<MeshData>.get_Current
	|-List.Enumerator<SupportPlane>.get_Current
	|-List.Enumerator<UltimateRope.RopeBone>.get_Current
	|-List.Enumerator<UltimateRope.RopeNode>.get_Current
	|-List.Enumerator<NavMeshLink>.get_Current
	|-List.Enumerator<NavMeshModifier>.get_Current
	|-List.Enumerator<NavMeshModifierVolume>.get_Current
	|-List.Enumerator<NavMeshObstacle>.get_Current
	|-List.Enumerator<AddressablesImpl.ResourceLocatorInfo>.get_Current
	|-List.Enumerator<Animator>.get_Current
	|-List.Enumerator<Collider>.get_Current
	|-List.Enumerator<PersistentCall>.get_Current
	|-List.Enumerator<IAnimationWindowPreview>.get_Current
	|-List.Enumerator<GUILayoutEntry>.get_Current
	|-List.Enumerator<GameObject>.get_Current
	|-List.Enumerator<GameObject[]>.get_Current
	|-List.Enumerator<ISubsystem>.get_Current
	|-List.Enumerator<ISubsystemDescriptor>.get_Current
	|-List.Enumerator<ISubsystemDescriptorImpl>.get_Current
	|-List.Enumerator<Material>.get_Current
	|-List.Enumerator<ParticleSystem>.get_Current
	|-List.Enumerator<RenderTexture>.get_Current
	|-List.Enumerator<IUpdateReceiver>.get_Current
	|-List.Enumerator<IResourceLocation>.get_Current
	|-List.Enumerator<ResourceManager.InstanceOperation>.get_Current
	|-List.Enumerator<ScriptableObject>.get_Current
	|-List.Enumerator<SkinnedMeshRenderer>.get_Current
	|-List.Enumerator<Terrain>.get_Current
	|-List.Enumerator<RuntimeElement>.get_Current
	|-List.Enumerator<TimelineClip>.get_Current
	|-List.Enumerator<Transform>.get_Current
	|-List.Enumerator<Image>.get_Current
	|-List.Enumerator<EventCallbackFunctorBase>.get_Current
	|-List.Enumerator<IEventDispatchingStrategy>.get_Current
	|-List.Enumerator<Panel>.get_Current
	|-List.Enumerator<VisualElement>.get_Current
	|-List.Enumerator<UpPointData>.get_Current
	|-List.Enumerator<ModifierSpec>.get_Current
	|-List.Enumerator<object>.get_Current
	|-List.Enumerator<MethodInfo>.get_Current
	|-List.Enumerator<ExceptionDispatchInfo>.get_Current
	|-List.Enumerator<IContextProperty>.get_Current
	|-List.Enumerator<IAsyncLocal>.get_Current
	|-List.Enumerator<Task>.get_Current
	|-List.Enumerator<TypeIdentifier>.get_Current
	|
	|-RVA: 0x350420 Offset: 0x350521 VA: 0x350420
	|-List.Enumerator<CropDataTable>.get_Current
	|
	|-RVA: 0x352F50 Offset: 0x353051 VA: 0x352F50
	|-List.Enumerator<ActorID>.get_Current
	|-List.Enumerator<Alliance>.get_Current
	|-List.Enumerator<GameFlagData>.get_Current
	|-List.Enumerator<NPCID>.get_Current
	|-List.Enumerator<VariationNo>.get_Current
	|-List.Enumerator<ItemID>.get_Current
	|-List.Enumerator<Prefab>.get_Current
	|-List.Enumerator<Texture>.get_Current
	|-List.Enumerator<MonsterModelDataID>.get_Current
	|-List.Enumerator<SoundID>.get_Current
	|-List.Enumerator<UITextDic.DICID>.get_Current
	|-List.Enumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x3505A0 Offset: 0x3506A1 VA: 0x3505A0
	|-List.Enumerator<DropItemParam>.get_Current
	|
	|-RVA: 0x350870 Offset: 0x350971 VA: 0x350870
	|-List.Enumerator<EventCheckId>.get_Current
	|
	|-RVA: 0x3509C0 Offset: 0x350AC1 VA: 0x3509C0
	|-List.Enumerator<EventFlagProgressData>.get_Current
	|
	|-RVA: 0x350B00 Offset: 0x350C01 VA: 0x350B00
	|-List.Enumerator<FesNpcScoreData>.get_Current
	|
	|-RVA: 0x350C60 Offset: 0x350D61 VA: 0x350C60
	|-List.Enumerator<MiningPointSaveData>.get_Current
	|
	|-RVA: 0x3510B0 Offset: 0x3511B1 VA: 0x3510B0
	|-List.Enumerator<NPCActionData>.get_Current
	|
	|-RVA: 0x351240 Offset: 0x351341 VA: 0x351240
	|-List.Enumerator<NpcPlaceSchedule>.get_Current
	|
	|-RVA: 0x3513B0 Offset: 0x3514B1 VA: 0x3513B0
	|-List.Enumerator<OrderLotterySaveParameter>.get_Current
	|
	|-RVA: 0x351510 Offset: 0x351611 VA: 0x351510
	|-List.Enumerator<OrderSaveParameter>.get_Current
	|
	|-RVA: 0x351660 Offset: 0x351761 VA: 0x351660
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Current
	|
	|-RVA: 0x351FF0 Offset: 0x3520F1 VA: 0x351FF0
	|-List.Enumerator<Schedule>.get_Current
	|
	|-RVA: 0x352160 Offset: 0x352261 VA: 0x352160
	|-List.Enumerator<CurveSample>.get_Current
	|
	|-RVA: 0x3527D0 Offset: 0x3528D1 VA: 0x3527D0
	|-List.Enumerator<KeyValuePair<int, FishSwim>>.get_Current
	|-List.Enumerator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x352E10 Offset: 0x352F11 VA: 0x352E10
	|-List.Enumerator<int>.get_Current
	|
	|-RVA: 0x31C070 Offset: 0x31C171 VA: 0x31C070
	|-List.Enumerator<ValueTuple<CharacterBase, float>>.get_Current
	|-List.Enumerator<ValueTuple<object, float>>.get_Current
	|
	|-RVA: 0x31BCB0 Offset: 0x31BDB1 VA: 0x31BCB0
	|-List.Enumerator<ValueTuple<SoundID, EnvironmentSoundController>>.get_Current
	|-List.Enumerator<ValueTuple<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x31C330 Offset: 0x31C431 VA: 0x31C330
	|-List.Enumerator<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>.get_Current
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Current
	|
	|-RVA: 0x31C650 Offset: 0x31C751 VA: 0x31C650
	|-List.Enumerator<TutorialUnlockFlagData>.get_Current
	|
	|-RVA: 0x31CA60 Offset: 0x31CB61 VA: 0x31CA60
	|-List.Enumerator<MeshDataConnectivity.Face>.get_Current
	|
	|-RVA: 0x31CBC0 Offset: 0x31CCC1 VA: 0x31CBC0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>.get_Current
	|
	|-RVA: 0x31D010 Offset: 0x31D111 VA: 0x31D010
	|-List.Enumerator<NavMeshBuildSource>.get_Current
	|
	|-RVA: 0x31FA00 Offset: 0x31FB01 VA: 0x31FA00
	|-List.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x31FB70 Offset: 0x31FC71 VA: 0x31FB70
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>.get_Current
	|
	|-RVA: 0x31FFD0 Offset: 0x3200D1 VA: 0x31FFD0
	|-List.Enumerator<ObjectInitializationData>.get_Current
	|
	|-RVA: 0x3211F0 Offset: 0x3212F1 VA: 0x3211F0
	|-List.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x34F5C0 Offset: 0x34F6C1 VA: 0x34F5C0
	|-List.Enumerator<AS_ToolController.ChargeInfo>.get_Current
	|
	|-RVA: 0x34F750 Offset: 0x34F851 VA: 0x34F750
	|-List.Enumerator<BuildItemData>.get_Current
	|
	|-RVA: 0x34F8F0 Offset: 0x34F9F1 VA: 0x34F8F0
	|-List.Enumerator<ButtonLinker.LinkObject>.get_Current
	|
	|-RVA: 0x34FA30 Offset: 0x34FB31 VA: 0x34FA30
	|-List.Enumerator<CharaCallTable.BustupTable>.get_Current
	|
	|-RVA: 0x34FB90 Offset: 0x34FC91 VA: 0x34FB90
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>.get_Current
	|
	|-RVA: 0x34FCD0 Offset: 0x34FDD1 VA: 0x34FCD0
	|-List.Enumerator<CameraState.CustomBlendable>.get_Current
	|
	|-RVA: 0x34FE10 Offset: 0x34FF11 VA: 0x34FE10
	|-List.Enumerator<CinemachineClearShot.Pair>.get_Current
	|
	|-RVA: 0x34FF50 Offset: 0x350051 VA: 0x34FF50
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.get_Current
	|
	|-RVA: 0x3500B0 Offset: 0x3501B1 VA: 0x3500B0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.get_Current
	|
	|-RVA: 0x350230 Offset: 0x350331 VA: 0x350230
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.get_Current
	|
	|-RVA: 0x350700 Offset: 0x350801 VA: 0x350700
	|-List.Enumerator<ErosionBrush.UndoStep>.get_Current
	|
	|-RVA: 0x350DF0 Offset: 0x350EF1 VA: 0x350DF0
	|-List.Enumerator<MonsterHutSaveData>.get_Current
	|
	|-RVA: 0x350F50 Offset: 0x351051 VA: 0x350F50
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>.get_Current
	|
	|-RVA: 0x3517A0 Offset: 0x3518A1 VA: 0x3517A0
	|-List.Enumerator<ShopCatalogPage>.get_Current
	|
	|-RVA: 0x351900 Offset: 0x351A01 VA: 0x351900
	|-List.Enumerator<ShopNpcTalk>.get_Current
	|
	|-RVA: 0x351A80 Offset: 0x351B81 VA: 0x351A80
	|-List.Enumerator<SubtitleDataTable.Data>.get_Current
	|
	|-RVA: 0x351BC0 Offset: 0x351CC1 VA: 0x351BC0
	|-List.Enumerator<SubtitleDataTable.DataList>.get_Current
	|
	|-RVA: 0x351D20 Offset: 0x351E21 VA: 0x351D20
	|-List.Enumerator<SubtitleHudDataTable.Data>.get_Current
	|
	|-RVA: 0x351E80 Offset: 0x351F81 VA: 0x351E80
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>.get_Current
	|
	|-RVA: 0x3522D0 Offset: 0x3523D1 VA: 0x3522D0
	|-List.Enumerator<bool>.get_Current
	|
	|-RVA: 0x352410 Offset: 0x352511 VA: 0x352410
	|-List.Enumerator<byte>.get_Current
	|
	|-RVA: 0x352550 Offset: 0x352651 VA: 0x352550
	|-List.Enumerator<char>.get_Current
	|
	|-RVA: 0x352690 Offset: 0x352791 VA: 0x352690
	|-List.Enumerator<KeyValuePair<DateTime, object>>.get_Current
	|
	|-RVA: 0x352910 Offset: 0x352A11 VA: 0x352910
	|-List.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x352A50 Offset: 0x352B51 VA: 0x352A50
	|-List.Enumerator<DateTime>.get_Current
	|
	|-RVA: 0x352B90 Offset: 0x352C91 VA: 0x352B90
	|-List.Enumerator<double>.get_Current
	|
	|-RVA: 0x352CD0 Offset: 0x352DD1 VA: 0x352CD0
	|-List.Enumerator<short>.get_Current
	|
	|-RVA: 0x353090 Offset: 0x353191 VA: 0x353090
	|-List.Enumerator<long>.get_Current
	|
	|-RVA: 0x3531D0 Offset: 0x3532D1 VA: 0x3531D0
	|-List.Enumerator<InterpretedFrameInfo>.get_Current
	|
	|-RVA: 0x353310 Offset: 0x353411 VA: 0x353310
	|-List.Enumerator<Nullable<Int32Enum>>.get_Current
	|
	|-RVA: 0x353470 Offset: 0x353571 VA: 0x353470
	|-List.Enumerator<Nullable<Bounds>>.get_Current
	|
	|-RVA: 0x3535F0 Offset: 0x3536F1 VA: 0x3535F0
	|-List.Enumerator<Nullable<BoundsInt>>.get_Current
	|
	|-RVA: 0x353750 Offset: 0x353851 VA: 0x353750
	|-List.Enumerator<Nullable<Color32>>.get_Current
	|
	|-RVA: 0x3538B0 Offset: 0x3539B1 VA: 0x3538B0
	|-List.Enumerator<Nullable<Color>>.get_Current
	|
	|-RVA: 0x353A20 Offset: 0x353B21 VA: 0x353A20
	|-List.Enumerator<Nullable<GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x353B80 Offset: 0x353C81 VA: 0x353B80
	|-List.Enumerator<Nullable<GradientColorKey>>.get_Current
	|
	|-RVA: 0x353CF0 Offset: 0x353DF1 VA: 0x353CF0
	|-List.Enumerator<Nullable<Keyframe>>.get_Current
	|
	|-RVA: 0x353E40 Offset: 0x353F41 VA: 0x353E40
	|-List.Enumerator<Nullable<LayerMask>>.get_Current
	|
	|-RVA: 0x353FA0 Offset: 0x3540A1 VA: 0x353FA0
	|-List.Enumerator<Nullable<Matrix4x4>>.get_Current
	|
	|-RVA: 0x354140 Offset: 0x354241 VA: 0x354140
	|-List.Enumerator<Nullable<Quaternion>>.get_Current
	|
	|-RVA: 0x3542B0 Offset: 0x3543B1 VA: 0x3542B0
	|-List.Enumerator<Nullable<RangeInt>>.get_Current
	|
	|-RVA: 0x354410 Offset: 0x354511 VA: 0x354410
	|-List.Enumerator<Nullable<Rect>>.get_Current
	|
	|-RVA: 0x354580 Offset: 0x354681 VA: 0x354580
	|-List.Enumerator<Nullable<RectInt>>.get_Current
	|
	|-RVA: 0x3546F0 Offset: 0x3547F1 VA: 0x3546F0
	|-List.Enumerator<Nullable<Vector2>>.get_Current
	|
	|-RVA: 0x354850 Offset: 0x354951 VA: 0x354850
	|-List.Enumerator<Nullable<Vector2Int>>.get_Current
	|
	|-RVA: 0x354990 Offset: 0x354A91 VA: 0x354990
	|-List.Enumerator<Nullable<Vector3>>.get_Current
	|
	|-RVA: 0x354AD0 Offset: 0x354BD1 VA: 0x354AD0
	|-List.Enumerator<Nullable<Vector3Int>>.get_Current
	|
	|-RVA: 0x31B0F0 Offset: 0x31B1F1 VA: 0x31B0F0
	|-List.Enumerator<Nullable<Vector4>>.get_Current
	|
	|-RVA: 0x31B3F0 Offset: 0x31B4F1 VA: 0x31B3F0
	|-List.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x31B530 Offset: 0x31B631 VA: 0x31B530
	|-List.Enumerator<float>.get_Current
	|
	|-RVA: 0x31B670 Offset: 0x31B771 VA: 0x31B670
	|-List.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x31B7B0 Offset: 0x31B8B1 VA: 0x31B7B0
	|-List.Enumerator<uint>.get_Current
	|
	|-RVA: 0x31B8F0 Offset: 0x31B9F1 VA: 0x31B8F0
	|-List.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x31BA30 Offset: 0x31BB31 VA: 0x31BA30
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>.get_Current
	|
	|-RVA: 0x31BB70 Offset: 0x31BC71 VA: 0x31BB70
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x31BDF0 Offset: 0x31BEF1 VA: 0x31BDF0
	|-List.Enumerator<ValueTuple<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x31BF30 Offset: 0x31C031 VA: 0x31BF30
	|-List.Enumerator<ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x31C1D0 Offset: 0x31C2D1 VA: 0x31C1D0
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x31C4C0 Offset: 0x31C5C1 VA: 0x31C4C0
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.get_Current
	|
	|-RVA: 0x31C790 Offset: 0x31C891 VA: 0x31C790
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>.get_Current
	|
	|-RVA: 0x31C8F0 Offset: 0x31C9F1 VA: 0x31C8F0
	|-List.Enumerator<CapEdge>.get_Current
	|
	|-RVA: 0x31CD30 Offset: 0x31CE31 VA: 0x31CD30
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>.get_Current
	|
	|-RVA: 0x31CE90 Offset: 0x31CF91 VA: 0x31CE90
	|-List.Enumerator<NavMeshBuildMarkup>.get_Current
	|
	|-RVA: 0x31D1A0 Offset: 0x31D2A1 VA: 0x31D1A0
	|-List.Enumerator<ConstraintSource>.get_Current
	|
	|-RVA: 0x31D2E0 Offset: 0x31D3E1 VA: 0x31D2E0
	|-List.Enumerator<AnimatorClipInfo>.get_Current
	|
	|-RVA: 0x31D420 Offset: 0x31D521 VA: 0x31D420
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|
	|-RVA: 0x31D580 Offset: 0x31D681 VA: 0x31D580
	|-List.Enumerator<BoneWeight>.get_Current
	|
	|-RVA: 0x31D6F0 Offset: 0x31D7F1 VA: 0x31D6F0
	|-List.Enumerator<Bounds>.get_Current
	|
	|-RVA: 0x31D860 Offset: 0x31D961 VA: 0x31D860
	|-List.Enumerator<BoundsInt>.get_Current
	|
	|-RVA: 0x31D9B0 Offset: 0x31DAB1 VA: 0x31D9B0
	|-List.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x31DAF0 Offset: 0x31DBF1 VA: 0x31DAF0
	|-List.Enumerator<Color>.get_Current
	|
	|-RVA: 0x31DC70 Offset: 0x31DD71 VA: 0x31DC70
	|-List.Enumerator<CombineInstance>.get_Current
	|
	|-RVA: 0x31DE20 Offset: 0x31DF21 VA: 0x31DE20
	|-List.Enumerator<RaycastResult>.get_Current
	|
	|-RVA: 0x31DF90 Offset: 0x31E091 VA: 0x31DF90
	|-List.Enumerator<GradientAlphaKey>.get_Current
	|
	|-RVA: 0x31E0F0 Offset: 0x31E1F1 VA: 0x31E0F0
	|-List.Enumerator<GradientColorKey>.get_Current
	|
	|-RVA: 0x31E260 Offset: 0x31E361 VA: 0x31E260
	|-List.Enumerator<Keyframe>.get_Current
	|
	|-RVA: 0x31E3C0 Offset: 0x31E4C1 VA: 0x31E3C0
	|-List.Enumerator<LayerMask>.get_Current
	|
	|-RVA: 0x31E520 Offset: 0x31E621 VA: 0x31E520
	|-List.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x31E6D0 Offset: 0x31E7D1 VA: 0x31E6D0
	|-List.Enumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x31E830 Offset: 0x31E931 VA: 0x31E830
	|-List.Enumerator<Playable>.get_Current
	|
	|-RVA: 0x31E990 Offset: 0x31EA91 VA: 0x31E990
	|-List.Enumerator<PlayableBinding>.get_Current
	|
	|-RVA: 0x31EAE0 Offset: 0x31EBE1 VA: 0x31EAE0
	|-List.Enumerator<PlayableGraph>.get_Current
	|
	|-RVA: 0x31EC20 Offset: 0x31ED21 VA: 0x31EC20
	|-List.Enumerator<Edge>.get_Current
	|
	|-RVA: 0x31ED60 Offset: 0x31EE61 VA: 0x31ED60
	|-List.Enumerator<Quaternion>.get_Current
	|
	|-RVA: 0x31EEA0 Offset: 0x31EFA1 VA: 0x31EEA0
	|-List.Enumerator<RangeInt>.get_Current
	|
	|-RVA: 0x31F000 Offset: 0x31F101 VA: 0x31F000
	|-List.Enumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x31F190 Offset: 0x31F291 VA: 0x31F190
	|-List.Enumerator<RaycastHit>.get_Current
	|
	|-RVA: 0x31F300 Offset: 0x31F401 VA: 0x31F300
	|-List.Enumerator<Rect>.get_Current
	|
	|-RVA: 0x31F440 Offset: 0x31F541 VA: 0x31F440
	|-List.Enumerator<RectInt>.get_Current
	|
	|-RVA: 0x31F580 Offset: 0x31F681 VA: 0x31F580
	|-List.Enumerator<ReflectionProbeBlendInfo>.get_Current
	|
	|-RVA: 0x31F700 Offset: 0x31F801 VA: 0x31F700
	|-List.Enumerator<SphericalHarmonicsL2>.get_Current
	|
	|-RVA: 0x31F8A0 Offset: 0x31F9A1 VA: 0x31F8A0
	|-List.Enumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x31FCE0 Offset: 0x31FDE1 VA: 0x31FCE0
	|-List.Enumerator<DiagnosticEvent>.get_Current
	|
	|-RVA: 0x31FE60 Offset: 0x31FF61 VA: 0x31FE60
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.get_Current
	|
	|-RVA: 0x320130 Offset: 0x320231 VA: 0x320130
	|-List.Enumerator<GlyphRect>.get_Current
	|
	|-RVA: 0x320290 Offset: 0x320391 VA: 0x320290
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.get_Current
	|
	|-RVA: 0x320410 Offset: 0x320511 VA: 0x320410
	|-List.Enumerator<IntervalTreeNode>.get_Current
	|
	|-RVA: 0x320580 Offset: 0x320681 VA: 0x320580
	|-List.Enumerator<IntervalTree.Entry<object>>.get_Current
	|
	|-RVA: 0x3206F0 Offset: 0x3207F1 VA: 0x3206F0
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.get_Current
	|
	|-RVA: 0x320860 Offset: 0x320961 VA: 0x320860
	|-List.Enumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x3209A0 Offset: 0x320AA1 VA: 0x3209A0
	|-List.Enumerator<FocusController.FocusedElement>.get_Current
	|
	|-RVA: 0x320AE0 Offset: 0x320BE1 VA: 0x320AE0
	|-List.Enumerator<UILineInfo>.get_Current
	|
	|-RVA: 0x320C60 Offset: 0x320D61 VA: 0x320C60
	|-List.Enumerator<UIVertex>.get_Current
	|
	|-RVA: 0x320E00 Offset: 0x320F01 VA: 0x320E00
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x320F50 Offset: 0x321051 VA: 0x320F50
	|-List.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x321090 Offset: 0x321191 VA: 0x321090
	|-List.Enumerator<Vector2Int>.get_Current
	|
	|-RVA: 0x321350 Offset: 0x321451 VA: 0x321350
	|-List.Enumerator<Vector3Int>.get_Current
	|
	|-RVA: 0x321490 Offset: 0x321591 VA: 0x321490
	|-List.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x321610 Offset: 0x321711 VA: 0x321610
	|-List.Enumerator<WarpPoints.WarpPoint>.get_Current
	|
	|-RVA: 0x3217B0 Offset: 0x3218B1 VA: 0x3217B0
	|-List.Enumerator<YieldItemParam>.get_Current
	|
	|-RVA: 0x321910 Offset: 0x321A11 VA: 0x321910
	|-List.Enumerator<stCommand_t>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F5E0 Offset: 0x34F6E1 VA: 0x34F5E0
	|-List.Enumerator<AS_ToolController.ChargeInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F7A0 Offset: 0x34F8A1 VA: 0x34F7A0
	|-List.Enumerator<BuildItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F900 Offset: 0x34FA01 VA: 0x34F900
	|-List.Enumerator<ButtonLinker.LinkObject>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34FA40 Offset: 0x34FB41 VA: 0x34FA40
	|-List.Enumerator<CharaCallTable.BustupTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34FBA0 Offset: 0x34FCA1 VA: 0x34FBA0
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34FCE0 Offset: 0x34FDE1 VA: 0x34FCE0
	|-List.Enumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34FE20 Offset: 0x34FF21 VA: 0x34FE20
	|-List.Enumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34FF60 Offset: 0x350061 VA: 0x34FF60
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3500D0 Offset: 0x3501D1 VA: 0x3500D0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350260 Offset: 0x350361 VA: 0x350260
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350430 Offset: 0x350531 VA: 0x350430
	|-List.Enumerator<CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3505B0 Offset: 0x3506B1 VA: 0x3505B0
	|-List.Enumerator<DropItemParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350720 Offset: 0x350821 VA: 0x350720
	|-List.Enumerator<ErosionBrush.UndoStep>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350890 Offset: 0x350991 VA: 0x350890
	|-List.Enumerator<EventCheckId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3509D0 Offset: 0x350AD1 VA: 0x3509D0
	|-List.Enumerator<EventFlagProgressData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350B10 Offset: 0x350C11 VA: 0x350B10
	|-List.Enumerator<FesNpcScoreData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350C90 Offset: 0x350D91 VA: 0x350C90
	|-List.Enumerator<MiningPointSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350E10 Offset: 0x350F11 VA: 0x350E10
	|-List.Enumerator<MonsterHutSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x350F60 Offset: 0x351061 VA: 0x350F60
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3510E0 Offset: 0x3511E1 VA: 0x3510E0
	|-List.Enumerator<NPCActionData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351260 Offset: 0x351361 VA: 0x351260
	|-List.Enumerator<NpcPlaceSchedule>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3513C0 Offset: 0x3514C1 VA: 0x3513C0
	|-List.Enumerator<OrderLotterySaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351530 Offset: 0x351631 VA: 0x351530
	|-List.Enumerator<OrderSaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351670 Offset: 0x351771 VA: 0x351670
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3517B0 Offset: 0x3518B1 VA: 0x3517B0
	|-List.Enumerator<ShopCatalogPage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351920 Offset: 0x351A21 VA: 0x351920
	|-List.Enumerator<ShopNpcTalk>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351A90 Offset: 0x351B91 VA: 0x351A90
	|-List.Enumerator<SubtitleDataTable.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351BD0 Offset: 0x351CD1 VA: 0x351BD0
	|-List.Enumerator<SubtitleDataTable.DataList>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351D30 Offset: 0x351E31 VA: 0x351D30
	|-List.Enumerator<SubtitleHudDataTable.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x351EA0 Offset: 0x351FA1 VA: 0x351EA0
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352010 Offset: 0x352111 VA: 0x352010
	|-List.Enumerator<Schedule>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352190 Offset: 0x352291 VA: 0x352190
	|-List.Enumerator<CurveSample>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3522E0 Offset: 0x3523E1 VA: 0x3522E0
	|-List.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352420 Offset: 0x352521 VA: 0x352420
	|-List.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352560 Offset: 0x352661 VA: 0x352560
	|-List.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3526A0 Offset: 0x3527A1 VA: 0x3526A0
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3527E0 Offset: 0x3528E1 VA: 0x3527E0
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352920 Offset: 0x352A21 VA: 0x352920
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352A60 Offset: 0x352B61 VA: 0x352A60
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352BA0 Offset: 0x352CA1 VA: 0x352BA0
	|-List.Enumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352CE0 Offset: 0x352DE1 VA: 0x352CE0
	|-List.Enumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352E20 Offset: 0x352F21 VA: 0x352E20
	|-List.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x352F60 Offset: 0x353061 VA: 0x352F60
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3530A0 Offset: 0x3531A1 VA: 0x3530A0
	|-List.Enumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3531E0 Offset: 0x3532E1 VA: 0x3531E0
	|-List.Enumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353320 Offset: 0x353421 VA: 0x353320
	|-List.Enumerator<Nullable<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353490 Offset: 0x353591 VA: 0x353490
	|-List.Enumerator<Nullable<Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353610 Offset: 0x353711 VA: 0x353610
	|-List.Enumerator<Nullable<BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353760 Offset: 0x353861 VA: 0x353760
	|-List.Enumerator<Nullable<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3538D0 Offset: 0x3539D1 VA: 0x3538D0
	|-List.Enumerator<Nullable<Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353A30 Offset: 0x353B31 VA: 0x353A30
	|-List.Enumerator<Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353BA0 Offset: 0x353CA1 VA: 0x353BA0
	|-List.Enumerator<Nullable<GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353D10 Offset: 0x353E11 VA: 0x353D10
	|-List.Enumerator<Nullable<Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353E50 Offset: 0x353F51 VA: 0x353E50
	|-List.Enumerator<Nullable<LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x353FE0 Offset: 0x3540E1 VA: 0x353FE0
	|-List.Enumerator<Nullable<Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x354160 Offset: 0x354261 VA: 0x354160
	|-List.Enumerator<Nullable<Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3542C0 Offset: 0x3543C1 VA: 0x3542C0
	|-List.Enumerator<Nullable<RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x354430 Offset: 0x354531 VA: 0x354430
	|-List.Enumerator<Nullable<Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3545A0 Offset: 0x3546A1 VA: 0x3545A0
	|-List.Enumerator<Nullable<RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x354700 Offset: 0x354801 VA: 0x354700
	|-List.Enumerator<Nullable<Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x354860 Offset: 0x354961 VA: 0x354860
	|-List.Enumerator<Nullable<Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3549A0 Offset: 0x354AA1 VA: 0x3549A0
	|-List.Enumerator<Nullable<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x354AE0 Offset: 0x354BE1 VA: 0x354AE0
	|-List.Enumerator<Nullable<Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B110 Offset: 0x31B211 VA: 0x31B110
	|-List.Enumerator<Nullable<Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B250 Offset: 0x31B351 VA: 0x31B250
	|-List.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B400 Offset: 0x31B501 VA: 0x31B400
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B540 Offset: 0x31B641 VA: 0x31B540
	|-List.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B680 Offset: 0x31B781 VA: 0x31B680
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B7C0 Offset: 0x31B8C1 VA: 0x31B7C0
	|-List.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31B900 Offset: 0x31BA01 VA: 0x31B900
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31BA40 Offset: 0x31BB41 VA: 0x31BA40
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31BB80 Offset: 0x31BC81 VA: 0x31BB80
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31BCC0 Offset: 0x31BDC1 VA: 0x31BCC0
	|-List.Enumerator<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31BE00 Offset: 0x31BF01 VA: 0x31BE00
	|-List.Enumerator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31BF40 Offset: 0x31C041 VA: 0x31BF40
	|-List.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C080 Offset: 0x31C181 VA: 0x31C080
	|-List.Enumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C1E0 Offset: 0x31C2E1 VA: 0x31C1E0
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C360 Offset: 0x31C461 VA: 0x31C360
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C4F0 Offset: 0x31C5F1 VA: 0x31C4F0
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C660 Offset: 0x31C761 VA: 0x31C660
	|-List.Enumerator<TutorialUnlockFlagData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C7A0 Offset: 0x31C8A1 VA: 0x31C7A0
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31C920 Offset: 0x31CA21 VA: 0x31C920
	|-List.Enumerator<CapEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31CA70 Offset: 0x31CB71 VA: 0x31CA70
	|-List.Enumerator<MeshDataConnectivity.Face>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31CBE0 Offset: 0x31CCE1 VA: 0x31CBE0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31CD50 Offset: 0x31CE51 VA: 0x31CD50
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31CEA0 Offset: 0x31CFA1 VA: 0x31CEA0
	|-List.Enumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D050 Offset: 0x31D151 VA: 0x31D050
	|-List.Enumerator<NavMeshBuildSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D1B0 Offset: 0x31D2B1 VA: 0x31D1B0
	|-List.Enumerator<ConstraintSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D2F0 Offset: 0x31D3F1 VA: 0x31D2F0
	|-List.Enumerator<AnimatorClipInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D430 Offset: 0x31D531 VA: 0x31D430
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D5A0 Offset: 0x31D6A1 VA: 0x31D5A0
	|-List.Enumerator<BoneWeight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D710 Offset: 0x31D811 VA: 0x31D710
	|-List.Enumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D880 Offset: 0x31D981 VA: 0x31D880
	|-List.Enumerator<BoundsInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31D9C0 Offset: 0x31DAC1 VA: 0x31D9C0
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31DB00 Offset: 0x31DC01 VA: 0x31DB00
	|-List.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31DCB0 Offset: 0x31DDB1 VA: 0x31DCB0
	|-List.Enumerator<CombineInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31DE50 Offset: 0x31DF51 VA: 0x31DE50
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31DFA0 Offset: 0x31E0A1 VA: 0x31DFA0
	|-List.Enumerator<GradientAlphaKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E110 Offset: 0x31E211 VA: 0x31E110
	|-List.Enumerator<GradientColorKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E280 Offset: 0x31E381 VA: 0x31E280
	|-List.Enumerator<Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E3D0 Offset: 0x31E4D1 VA: 0x31E3D0
	|-List.Enumerator<LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E550 Offset: 0x31E651 VA: 0x31E550
	|-List.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E6E0 Offset: 0x31E7E1 VA: 0x31E6E0
	|-List.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E840 Offset: 0x31E941 VA: 0x31E840
	|-List.Enumerator<Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31E9B0 Offset: 0x31EAB1 VA: 0x31E9B0
	|-List.Enumerator<PlayableBinding>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31EAF0 Offset: 0x31EBF1 VA: 0x31EAF0
	|-List.Enumerator<PlayableGraph>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31EC30 Offset: 0x31ED31 VA: 0x31EC30
	|-List.Enumerator<Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31ED70 Offset: 0x31EE71 VA: 0x31ED70
	|-List.Enumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31EEB0 Offset: 0x31EFB1 VA: 0x31EEB0
	|-List.Enumerator<RangeInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F030 Offset: 0x31F131 VA: 0x31F030
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F1C0 Offset: 0x31F2C1 VA: 0x31F1C0
	|-List.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F310 Offset: 0x31F411 VA: 0x31F310
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F450 Offset: 0x31F551 VA: 0x31F450
	|-List.Enumerator<RectInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F590 Offset: 0x31F691 VA: 0x31F590
	|-List.Enumerator<ReflectionProbeBlendInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F750 Offset: 0x31F851 VA: 0x31F750
	|-List.Enumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31F8B0 Offset: 0x31F9B1 VA: 0x31F8B0
	|-List.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31FA20 Offset: 0x31FB21 VA: 0x31FA20
	|-List.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31FB90 Offset: 0x31FC91 VA: 0x31FB90
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31FD00 Offset: 0x31FE01 VA: 0x31FD00
	|-List.Enumerator<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31FE80 Offset: 0x31FF81 VA: 0x31FE80
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31FFF0 Offset: 0x3200F1 VA: 0x31FFF0
	|-List.Enumerator<ObjectInitializationData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320140 Offset: 0x320241 VA: 0x320140
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3202B0 Offset: 0x3203B1 VA: 0x3202B0
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320430 Offset: 0x320531 VA: 0x320430
	|-List.Enumerator<IntervalTreeNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3205A0 Offset: 0x3206A1 VA: 0x3205A0
	|-List.Enumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320710 Offset: 0x320811 VA: 0x320710
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320870 Offset: 0x320971 VA: 0x320870
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3209B0 Offset: 0x320AB1 VA: 0x3209B0
	|-List.Enumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320AF0 Offset: 0x320BF1 VA: 0x320AF0
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320CA0 Offset: 0x320DA1 VA: 0x320CA0
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320E20 Offset: 0x320F21 VA: 0x320E20
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x320F60 Offset: 0x321061 VA: 0x320F60
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3210A0 Offset: 0x3211A1 VA: 0x3210A0
	|-List.Enumerator<Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321200 Offset: 0x321301 VA: 0x321200
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321360 Offset: 0x321461 VA: 0x321360
	|-List.Enumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3214A0 Offset: 0x3215A1 VA: 0x3214A0
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321660 Offset: 0x321761 VA: 0x321660
	|-List.Enumerator<WarpPoints.WarpPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3217C0 Offset: 0x3218C1 VA: 0x3217C0
	|-List.Enumerator<YieldItemParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321930 Offset: 0x321A31 VA: 0x321930
	|-List.Enumerator<stCommand_t>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F5F0 Offset: 0x34F6F1 VA: 0x34F5F0
	|-List.Enumerator<AS_ToolController.ChargeInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F7B0 Offset: 0x34F8B1 VA: 0x34F7B0
	|-List.Enumerator<BuildItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F910 Offset: 0x34FA11 VA: 0x34F910
	|-List.Enumerator<ButtonLinker.LinkObject>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34FA50 Offset: 0x34FB51 VA: 0x34FA50
	|-List.Enumerator<CharaCallTable.BustupTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34FBB0 Offset: 0x34FCB1 VA: 0x34FBB0
	|-List.Enumerator<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34FCF0 Offset: 0x34FDF1 VA: 0x34FCF0
	|-List.Enumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34FE30 Offset: 0x34FF31 VA: 0x34FE30
	|-List.Enumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34FF70 Offset: 0x350071 VA: 0x34FF70
	|-List.Enumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3500E0 Offset: 0x3501E1 VA: 0x3500E0
	|-List.Enumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350270 Offset: 0x350371 VA: 0x350270
	|-List.Enumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350440 Offset: 0x350541 VA: 0x350440
	|-List.Enumerator<CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3505C0 Offset: 0x3506C1 VA: 0x3505C0
	|-List.Enumerator<DropItemParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350730 Offset: 0x350831 VA: 0x350730
	|-List.Enumerator<ErosionBrush.UndoStep>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3508A0 Offset: 0x3509A1 VA: 0x3508A0
	|-List.Enumerator<EventCheckId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3509E0 Offset: 0x350AE1 VA: 0x3509E0
	|-List.Enumerator<EventFlagProgressData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350B20 Offset: 0x350C21 VA: 0x350B20
	|-List.Enumerator<FesNpcScoreData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350CA0 Offset: 0x350DA1 VA: 0x350CA0
	|-List.Enumerator<MiningPointSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350E20 Offset: 0x350F21 VA: 0x350E20
	|-List.Enumerator<MonsterHutSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x350F70 Offset: 0x351071 VA: 0x350F70
	|-List.Enumerator<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3510F0 Offset: 0x3511F1 VA: 0x3510F0
	|-List.Enumerator<NPCActionData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351270 Offset: 0x351371 VA: 0x351270
	|-List.Enumerator<NpcPlaceSchedule>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3513D0 Offset: 0x3514D1 VA: 0x3513D0
	|-List.Enumerator<OrderLotterySaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351540 Offset: 0x351641 VA: 0x351540
	|-List.Enumerator<OrderSaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351680 Offset: 0x351781 VA: 0x351680
	|-List.Enumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3517C0 Offset: 0x3518C1 VA: 0x3517C0
	|-List.Enumerator<ShopCatalogPage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351930 Offset: 0x351A31 VA: 0x351930
	|-List.Enumerator<ShopNpcTalk>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351AA0 Offset: 0x351BA1 VA: 0x351AA0
	|-List.Enumerator<SubtitleDataTable.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351BE0 Offset: 0x351CE1 VA: 0x351BE0
	|-List.Enumerator<SubtitleDataTable.DataList>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351D40 Offset: 0x351E41 VA: 0x351D40
	|-List.Enumerator<SubtitleHudDataTable.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x351EB0 Offset: 0x351FB1 VA: 0x351EB0
	|-List.Enumerator<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352020 Offset: 0x352121 VA: 0x352020
	|-List.Enumerator<Schedule>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3521A0 Offset: 0x3522A1 VA: 0x3521A0
	|-List.Enumerator<CurveSample>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3522F0 Offset: 0x3523F1 VA: 0x3522F0
	|-List.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352430 Offset: 0x352531 VA: 0x352430
	|-List.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352570 Offset: 0x352671 VA: 0x352570
	|-List.Enumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3526B0 Offset: 0x3527B1 VA: 0x3526B0
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3527F0 Offset: 0x3528F1 VA: 0x3527F0
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352930 Offset: 0x352A31 VA: 0x352930
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352A70 Offset: 0x352B71 VA: 0x352A70
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352BB0 Offset: 0x352CB1 VA: 0x352BB0
	|-List.Enumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352CF0 Offset: 0x352DF1 VA: 0x352CF0
	|-List.Enumerator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352E30 Offset: 0x352F31 VA: 0x352E30
	|-List.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x352F70 Offset: 0x353071 VA: 0x352F70
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3530B0 Offset: 0x3531B1 VA: 0x3530B0
	|-List.Enumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3531F0 Offset: 0x3532F1 VA: 0x3531F0
	|-List.Enumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353330 Offset: 0x353431 VA: 0x353330
	|-List.Enumerator<Nullable<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3534A0 Offset: 0x3535A1 VA: 0x3534A0
	|-List.Enumerator<Nullable<Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353620 Offset: 0x353721 VA: 0x353620
	|-List.Enumerator<Nullable<BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353770 Offset: 0x353871 VA: 0x353770
	|-List.Enumerator<Nullable<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3538E0 Offset: 0x3539E1 VA: 0x3538E0
	|-List.Enumerator<Nullable<Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353A40 Offset: 0x353B41 VA: 0x353A40
	|-List.Enumerator<Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353BB0 Offset: 0x353CB1 VA: 0x353BB0
	|-List.Enumerator<Nullable<GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353D20 Offset: 0x353E21 VA: 0x353D20
	|-List.Enumerator<Nullable<Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353E60 Offset: 0x353F61 VA: 0x353E60
	|-List.Enumerator<Nullable<LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x353FF0 Offset: 0x3540F1 VA: 0x353FF0
	|-List.Enumerator<Nullable<Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x354170 Offset: 0x354271 VA: 0x354170
	|-List.Enumerator<Nullable<Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3542D0 Offset: 0x3543D1 VA: 0x3542D0
	|-List.Enumerator<Nullable<RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x354440 Offset: 0x354541 VA: 0x354440
	|-List.Enumerator<Nullable<Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3545B0 Offset: 0x3546B1 VA: 0x3545B0
	|-List.Enumerator<Nullable<RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x354710 Offset: 0x354811 VA: 0x354710
	|-List.Enumerator<Nullable<Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x354870 Offset: 0x354971 VA: 0x354870
	|-List.Enumerator<Nullable<Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3549B0 Offset: 0x354AB1 VA: 0x3549B0
	|-List.Enumerator<Nullable<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x354AF0 Offset: 0x354BF1 VA: 0x354AF0
	|-List.Enumerator<Nullable<Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B120 Offset: 0x31B221 VA: 0x31B120
	|-List.Enumerator<Nullable<Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B2D0 Offset: 0x31B3D1 VA: 0x31B2D0
	|-List.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B410 Offset: 0x31B511 VA: 0x31B410
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B550 Offset: 0x31B651 VA: 0x31B550
	|-List.Enumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B690 Offset: 0x31B791 VA: 0x31B690
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B7D0 Offset: 0x31B8D1 VA: 0x31B7D0
	|-List.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31B910 Offset: 0x31BA11 VA: 0x31B910
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31BA50 Offset: 0x31BB51 VA: 0x31BA50
	|-List.Enumerator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31BB90 Offset: 0x31BC91 VA: 0x31BB90
	|-List.Enumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31BCD0 Offset: 0x31BDD1 VA: 0x31BCD0
	|-List.Enumerator<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31BE10 Offset: 0x31BF11 VA: 0x31BE10
	|-List.Enumerator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31BF50 Offset: 0x31C051 VA: 0x31BF50
	|-List.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C090 Offset: 0x31C191 VA: 0x31C090
	|-List.Enumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C1F0 Offset: 0x31C2F1 VA: 0x31C1F0
	|-List.Enumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C370 Offset: 0x31C471 VA: 0x31C370
	|-List.Enumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C500 Offset: 0x31C601 VA: 0x31C500
	|-List.Enumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C670 Offset: 0x31C771 VA: 0x31C670
	|-List.Enumerator<TutorialUnlockFlagData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C7B0 Offset: 0x31C8B1 VA: 0x31C7B0
	|-List.Enumerator<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31C930 Offset: 0x31CA31 VA: 0x31C930
	|-List.Enumerator<CapEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31CA80 Offset: 0x31CB81 VA: 0x31CA80
	|-List.Enumerator<MeshDataConnectivity.Face>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31CBF0 Offset: 0x31CCF1 VA: 0x31CBF0
	|-List.Enumerator<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31CD60 Offset: 0x31CE61 VA: 0x31CD60
	|-List.Enumerator<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31CEB0 Offset: 0x31CFB1 VA: 0x31CEB0
	|-List.Enumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D060 Offset: 0x31D161 VA: 0x31D060
	|-List.Enumerator<NavMeshBuildSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D1C0 Offset: 0x31D2C1 VA: 0x31D1C0
	|-List.Enumerator<ConstraintSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D300 Offset: 0x31D401 VA: 0x31D300
	|-List.Enumerator<AnimatorClipInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D440 Offset: 0x31D541 VA: 0x31D440
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D5B0 Offset: 0x31D6B1 VA: 0x31D5B0
	|-List.Enumerator<BoneWeight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D720 Offset: 0x31D821 VA: 0x31D720
	|-List.Enumerator<Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D890 Offset: 0x31D991 VA: 0x31D890
	|-List.Enumerator<BoundsInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31D9D0 Offset: 0x31DAD1 VA: 0x31D9D0
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31DB10 Offset: 0x31DC11 VA: 0x31DB10
	|-List.Enumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31DCC0 Offset: 0x31DDC1 VA: 0x31DCC0
	|-List.Enumerator<CombineInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31DE60 Offset: 0x31DF61 VA: 0x31DE60
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31DFB0 Offset: 0x31E0B1 VA: 0x31DFB0
	|-List.Enumerator<GradientAlphaKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E120 Offset: 0x31E221 VA: 0x31E120
	|-List.Enumerator<GradientColorKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E290 Offset: 0x31E391 VA: 0x31E290
	|-List.Enumerator<Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E3E0 Offset: 0x31E4E1 VA: 0x31E3E0
	|-List.Enumerator<LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E560 Offset: 0x31E661 VA: 0x31E560
	|-List.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E6F0 Offset: 0x31E7F1 VA: 0x31E6F0
	|-List.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E850 Offset: 0x31E951 VA: 0x31E850
	|-List.Enumerator<Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31E9C0 Offset: 0x31EAC1 VA: 0x31E9C0
	|-List.Enumerator<PlayableBinding>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31EB00 Offset: 0x31EC01 VA: 0x31EB00
	|-List.Enumerator<PlayableGraph>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31EC40 Offset: 0x31ED41 VA: 0x31EC40
	|-List.Enumerator<Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31ED80 Offset: 0x31EE81 VA: 0x31ED80
	|-List.Enumerator<Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31EEC0 Offset: 0x31EFC1 VA: 0x31EEC0
	|-List.Enumerator<RangeInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F040 Offset: 0x31F141 VA: 0x31F040
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F1D0 Offset: 0x31F2D1 VA: 0x31F1D0
	|-List.Enumerator<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F320 Offset: 0x31F421 VA: 0x31F320
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F460 Offset: 0x31F561 VA: 0x31F460
	|-List.Enumerator<RectInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F5A0 Offset: 0x31F6A1 VA: 0x31F5A0
	|-List.Enumerator<ReflectionProbeBlendInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F760 Offset: 0x31F861 VA: 0x31F760
	|-List.Enumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31F8C0 Offset: 0x31F9C1 VA: 0x31F8C0
	|-List.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31FA30 Offset: 0x31FB31 VA: 0x31FA30
	|-List.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31FBA0 Offset: 0x31FCA1 VA: 0x31FBA0
	|-List.Enumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31FD10 Offset: 0x31FE11 VA: 0x31FD10
	|-List.Enumerator<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31FE90 Offset: 0x31FF91 VA: 0x31FE90
	|-List.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320000 Offset: 0x320101 VA: 0x320000
	|-List.Enumerator<ObjectInitializationData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320150 Offset: 0x320251 VA: 0x320150
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3202C0 Offset: 0x3203C1 VA: 0x3202C0
	|-List.Enumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320440 Offset: 0x320541 VA: 0x320440
	|-List.Enumerator<IntervalTreeNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3205B0 Offset: 0x3206B1 VA: 0x3205B0
	|-List.Enumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320720 Offset: 0x320821 VA: 0x320720
	|-List.Enumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320880 Offset: 0x320981 VA: 0x320880
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3209C0 Offset: 0x320AC1 VA: 0x3209C0
	|-List.Enumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320B00 Offset: 0x320C01 VA: 0x320B00
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320CB0 Offset: 0x320DB1 VA: 0x320CB0
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320E30 Offset: 0x320F31 VA: 0x320E30
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x320F70 Offset: 0x321071 VA: 0x320F70
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3210B0 Offset: 0x3211B1 VA: 0x3210B0
	|-List.Enumerator<Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321210 Offset: 0x321311 VA: 0x321210
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321370 Offset: 0x321471 VA: 0x321370
	|-List.Enumerator<Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3214B0 Offset: 0x3215B1 VA: 0x3214B0
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321670 Offset: 0x321771 VA: 0x321670
	|-List.Enumerator<WarpPoints.WarpPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3217D0 Offset: 0x3218D1 VA: 0x3217D0
	|-List.Enumerator<YieldItemParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321940 Offset: 0x321A41 VA: 0x321940
	|-List.Enumerator<stCommand_t>.System.Collections.IEnumerator.Reset
	*/
}

