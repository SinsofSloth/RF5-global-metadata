[Serializable]
internal class ObjectComparer<T> : Comparer<T> // TypeDefIndex: 1438
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CF9F20 Offset: 0x2CFA021 VA: 0x2CF9F20
	|-ObjectComparer<AS_ToolController.ChargeInfo>.Compare
	|
	|-RVA: 0x2CFA100 Offset: 0x2CFA201 VA: 0x2CFA100
	|-ObjectComparer<BuildItemData>.Compare
	|
	|-RVA: 0x2CFA340 Offset: 0x2CFA441 VA: 0x2CFA340
	|-ObjectComparer<ButtonLinker.LinkObject>.Compare
	|
	|-RVA: 0x2CFA510 Offset: 0x2CFA611 VA: 0x2CFA510
	|-ObjectComparer<CharaCallTable.BustupTable>.Compare
	|
	|-RVA: 0x2CFA6E0 Offset: 0x2CFA7E1 VA: 0x2CFA6E0
	|-ObjectComparer<CharaCallTable.CharaFaceIconTable>.Compare
	|
	|-RVA: 0x2CFA8C0 Offset: 0x2CFA9C1 VA: 0x2CFA8C0
	|-ObjectComparer<CameraState.CustomBlendable>.Compare
	|
	|-RVA: 0x2CFAA90 Offset: 0x2CFAB91 VA: 0x2CFAA90
	|-ObjectComparer<CinemachineClearShot.Pair>.Compare
	|
	|-RVA: 0x2CFAC50 Offset: 0x2CFAD51 VA: 0x2CFAC50
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>.Compare
	|
	|-RVA: 0x2CFAE10 Offset: 0x2CFAF11 VA: 0x2CFAE10
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>.Compare
	|
	|-RVA: 0x2CFB000 Offset: 0x2CFB101 VA: 0x2CFB000
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>.Compare
	|
	|-RVA: 0x2CFB200 Offset: 0x2CFB301 VA: 0x2CFB200
	|-ObjectComparer<CropDataTable>.Compare
	|
	|-RVA: 0x2CFB3E0 Offset: 0x2CFB4E1 VA: 0x2CFB3E0
	|-ObjectComparer<DropItemParam>.Compare
	|
	|-RVA: 0x2CFB5A0 Offset: 0x2CFB6A1 VA: 0x2CFB5A0
	|-ObjectComparer<ErosionBrush.UndoStep>.Compare
	|
	|-RVA: 0x2CFB780 Offset: 0x2CFB881 VA: 0x2CFB780
	|-ObjectComparer<EventCheckId>.Compare
	|
	|-RVA: 0x2CFB960 Offset: 0x2CFBA61 VA: 0x2CFB960
	|-ObjectComparer<EventFlagProgressData>.Compare
	|
	|-RVA: 0x2CFBB30 Offset: 0x2CFBC31 VA: 0x2CFBB30
	|-ObjectComparer<FesNpcScoreData>.Compare
	|
	|-RVA: 0x2CFBD00 Offset: 0x2CFBE01 VA: 0x2CFBD00
	|-ObjectComparer<HitResult>.Compare
	|
	|-RVA: 0x2CFBEF0 Offset: 0x2CFBFF1 VA: 0x2CFBEF0
	|-ObjectComparer<MiningPointSaveData>.Compare
	|
	|-RVA: 0x2CFC0F0 Offset: 0x2CFC1F1 VA: 0x2CFC0F0
	|-ObjectComparer<MonsterHutSaveData>.Compare
	|
	|-RVA: 0x2CFC2E0 Offset: 0x2CFC3E1 VA: 0x2CFC2E0
	|-ObjectComparer<MoviePlayer.SUBTITLEDATA>.Compare
	|
	|-RVA: 0x2CFC4B0 Offset: 0x2CFC5B1 VA: 0x2CFC4B0
	|-ObjectComparer<NPCActionData>.Compare
	|
	|-RVA: 0x2CFC6B0 Offset: 0x2CFC7B1 VA: 0x2CFC6B0
	|-ObjectComparer<NpcPlaceSchedule>.Compare
	|
	|-RVA: 0x2CFC890 Offset: 0x2CFC991 VA: 0x2CFC890
	|-ObjectComparer<OrderLotterySaveParameter>.Compare
	|
	|-RVA: 0x2CFCA70 Offset: 0x2CFCB71 VA: 0x2CFCA70
	|-ObjectComparer<OrderSaveParameter>.Compare
	|
	|-RVA: 0x2CFCC50 Offset: 0x2CFCD51 VA: 0x2CFCC50
	|-ObjectComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.Compare
	|
	|-RVA: 0x2CFCE20 Offset: 0x2CFCF21 VA: 0x2CFCE20
	|-ObjectComparer<Parameter>.Compare
	|
	|-RVA: 0x2CFD000 Offset: 0x2CFD101 VA: 0x2CFD000
	|-ObjectComparer<ShopCatalogPage>.Compare
	|
	|-RVA: 0x2CFD1D0 Offset: 0x2CFD2D1 VA: 0x2CFD1D0
	|-ObjectComparer<ShopNpcTalk>.Compare
	|
	|-RVA: 0x2CFD3C0 Offset: 0x2CFD4C1 VA: 0x2CFD3C0
	|-ObjectComparer<SubtitleDataTable.Data>.Compare
	|
	|-RVA: 0x2CFD5A0 Offset: 0x2CFD6A1 VA: 0x2CFD5A0
	|-ObjectComparer<SubtitleDataTable.DataList>.Compare
	|
	|-RVA: 0x2CFD760 Offset: 0x2CFD861 VA: 0x2CFD760
	|-ObjectComparer<SubtitleHudDataTable.Data>.Compare
	|
	|-RVA: 0x2CFD940 Offset: 0x2CFDA41 VA: 0x2CFD940
	|-ObjectComparer<SRMonoBehaviourEx.FieldInfo>.Compare
	|
	|-RVA: 0x2CFDB20 Offset: 0x2CFDC21 VA: 0x2CFDB20
	|-ObjectComparer<Schedule>.Compare
	|
	|-RVA: 0x2CFDD00 Offset: 0x2CFDE01 VA: 0x2CFDD00
	|-ObjectComparer<CurveSample>.Compare
	|
	|-RVA: 0x2CFDF10 Offset: 0x2CFE011 VA: 0x2CFDF10
	|-ObjectComparer<bool>.Compare
	|
	|-RVA: 0x2CFE0D0 Offset: 0x2CFE1D1 VA: 0x2CFE0D0
	|-ObjectComparer<byte>.Compare
	|
	|-RVA: 0x2CFE290 Offset: 0x2CFE391 VA: 0x2CFE290
	|-ObjectComparer<char>.Compare
	|
	|-RVA: 0x2CFE450 Offset: 0x2CFE551 VA: 0x2CFE450
	|-ObjectComparer<KeyValuePair<DateTime, object>>.Compare
	|
	|-RVA: 0x2CFE620 Offset: 0x2CFE721 VA: 0x2CFE620
	|-ObjectComparer<KeyValuePair<int, object>>.Compare
	|
	|-RVA: 0x2CFE7F0 Offset: 0x2CFE8F1 VA: 0x2CFE7F0
	|-ObjectComparer<KeyValuePair<object, object>>.Compare
	|
	|-RVA: 0x2CFE9C0 Offset: 0x2CFEAC1 VA: 0x2CFE9C0
	|-ObjectComparer<DateTime>.Compare
	|
	|-RVA: 0x2CFEB80 Offset: 0x2CFEC81 VA: 0x2CFEB80
	|-ObjectComparer<double>.Compare
	|
	|-RVA: 0x2CFED50 Offset: 0x2CFEE51 VA: 0x2CFED50
	|-ObjectComparer<Guid>.Compare
	|
	|-RVA: 0x2821B00 Offset: 0x2821C01 VA: 0x2821B00
	|-ObjectComparer<short>.Compare
	|
	|-RVA: 0x2821CC0 Offset: 0x2821DC1 VA: 0x2821CC0
	|-ObjectComparer<int>.Compare
	|
	|-RVA: 0x2821E80 Offset: 0x2821F81 VA: 0x2821E80
	|-ObjectComparer<Int32Enum>.Compare
	|
	|-RVA: 0x2822040 Offset: 0x2822141 VA: 0x2822040
	|-ObjectComparer<long>.Compare
	|
	|-RVA: 0x2822200 Offset: 0x2822301 VA: 0x2822200
	|-ObjectComparer<InterpretedFrameInfo>.Compare
	|
	|-RVA: 0x28223D0 Offset: 0x28224D1 VA: 0x28223D0
	|-ObjectComparer<Nullable<Int32Enum>>.Compare
	|
	|-RVA: 0x2822590 Offset: 0x2822691 VA: 0x2822590
	|-ObjectComparer<Nullable<Bounds>>.Compare
	|
	|-RVA: 0x2822780 Offset: 0x2822881 VA: 0x2822780
	|-ObjectComparer<Nullable<BoundsInt>>.Compare
	|
	|-RVA: 0x2822970 Offset: 0x2822A71 VA: 0x2822970
	|-ObjectComparer<Nullable<Color32>>.Compare
	|
	|-RVA: 0x2822B30 Offset: 0x2822C31 VA: 0x2822B30
	|-ObjectComparer<Nullable<Color>>.Compare
	|
	|-RVA: 0x2822D10 Offset: 0x2822E11 VA: 0x2822D10
	|-ObjectComparer<Nullable<GradientAlphaKey>>.Compare
	|
	|-RVA: 0x2822EF0 Offset: 0x2822FF1 VA: 0x2822EF0
	|-ObjectComparer<Nullable<GradientColorKey>>.Compare
	|
	|-RVA: 0x28230D0 Offset: 0x28231D1 VA: 0x28230D0
	|-ObjectComparer<Nullable<Keyframe>>.Compare
	|
	|-RVA: 0x28232B0 Offset: 0x28233B1 VA: 0x28232B0
	|-ObjectComparer<Nullable<LayerMask>>.Compare
	|
	|-RVA: 0x2823470 Offset: 0x2823571 VA: 0x2823470
	|-ObjectComparer<Nullable<Matrix4x4>>.Compare
	|
	|-RVA: 0x2823690 Offset: 0x2823791 VA: 0x2823690
	|-ObjectComparer<Nullable<Quaternion>>.Compare
	|
	|-RVA: 0x2823870 Offset: 0x2823971 VA: 0x2823870
	|-ObjectComparer<Nullable<RangeInt>>.Compare
	|
	|-RVA: 0x2823A50 Offset: 0x2823B51 VA: 0x2823A50
	|-ObjectComparer<Nullable<Rect>>.Compare
	|
	|-RVA: 0x2823C30 Offset: 0x2823D31 VA: 0x2823C30
	|-ObjectComparer<Nullable<RectInt>>.Compare
	|
	|-RVA: 0x2823E10 Offset: 0x2823F11 VA: 0x2823E10
	|-ObjectComparer<Nullable<Vector2>>.Compare
	|
	|-RVA: 0x2823FF0 Offset: 0x28240F1 VA: 0x2823FF0
	|-ObjectComparer<Nullable<Vector2Int>>.Compare
	|
	|-RVA: 0x28241D0 Offset: 0x28242D1 VA: 0x28241D0
	|-ObjectComparer<Nullable<Vector3>>.Compare
	|
	|-RVA: 0x28243A0 Offset: 0x28244A1 VA: 0x28243A0
	|-ObjectComparer<Nullable<Vector3Int>>.Compare
	|
	|-RVA: 0x2824570 Offset: 0x2824671 VA: 0x2824570
	|-ObjectComparer<Nullable<Vector4>>.Compare
	|
	|-RVA: 0x2824750 Offset: 0x2824851 VA: 0x2824750
	|-ObjectComparer<object>.Compare
	|
	|-RVA: 0x28248A0 Offset: 0x28249A1 VA: 0x28248A0
	|-ObjectComparer<sbyte>.Compare
	|
	|-RVA: 0x2824A60 Offset: 0x2824B61 VA: 0x2824A60
	|-ObjectComparer<float>.Compare
	|
	|-RVA: 0x2824C20 Offset: 0x2824D21 VA: 0x2824C20
	|-ObjectComparer<ushort>.Compare
	|
	|-RVA: 0x2824DE0 Offset: 0x2824EE1 VA: 0x2824DE0
	|-ObjectComparer<uint>.Compare
	|
	|-RVA: 0x2824FA0 Offset: 0x28250A1 VA: 0x2824FA0
	|-ObjectComparer<ulong>.Compare
	|
	|-RVA: 0x2825160 Offset: 0x2825261 VA: 0x2825160
	|-ObjectComparer<ValueTuple<bool, Int32Enum>>.Compare
	|
	|-RVA: 0x2825320 Offset: 0x2825421 VA: 0x2825320
	|-ObjectComparer<ValueTuple<Int32Enum, int>>.Compare
	|
	|-RVA: 0x28254E0 Offset: 0x28255E1 VA: 0x28254E0
	|-ObjectComparer<ValueTuple<Int32Enum, object>>.Compare
	|
	|-RVA: 0x28256B0 Offset: 0x28257B1 VA: 0x28256B0
	|-ObjectComparer<ValueTuple<object, Int32Enum>>.Compare
	|
	|-RVA: 0x2825880 Offset: 0x2825981 VA: 0x2825880
	|-ObjectComparer<ValueTuple<object, object>>.Compare
	|
	|-RVA: 0x2825A50 Offset: 0x2825B51 VA: 0x2825A50
	|-ObjectComparer<ValueTuple<object, float>>.Compare
	|
	|-RVA: 0x2825C20 Offset: 0x2825D21 VA: 0x2825C20
	|-ObjectComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Compare
	|
	|-RVA: 0x2825E00 Offset: 0x2825F01 VA: 0x2825E00
	|-ObjectComparer<ValueTuple<object, object, Vector3>>.Compare
	|
	|-RVA: 0x2825FE0 Offset: 0x28260E1 VA: 0x2825FE0
	|-ObjectComparer<ValueTuple<object, object, Vector3, float>>.Compare
	|
	|-RVA: 0x28261C0 Offset: 0x28262C1 VA: 0x28261C0
	|-ObjectComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Compare
	|
	|-RVA: 0x28263C0 Offset: 0x28264C1 VA: 0x28263C0
	|-ObjectComparer<TexturePacker_JsonArray.Frame>.Compare
	|
	|-RVA: 0x28265C0 Offset: 0x28266C1 VA: 0x28265C0
	|-ObjectComparer<TutorialUnlockFlagData>.Compare
	|
	|-RVA: 0x28267A0 Offset: 0x28268A1 VA: 0x28267A0
	|-ObjectComparer<UIMainManagerAttachObject.AttachSet>.Compare
	|
	|-RVA: 0x2826970 Offset: 0x2826A71 VA: 0x2826970
	|-ObjectComparer<CapEdge>.Compare
	|
	|-RVA: 0x2826B70 Offset: 0x2826C71 VA: 0x2826B70
	|-ObjectComparer<MeshDataConnectivity.Face>.Compare
	|
	|-RVA: 0x2826D30 Offset: 0x2826E31 VA: 0x2826D30
	|-ObjectComparer<MeshFaceConnectivity.EdgeData.SideData>.Compare
	|
	|-RVA: 0x2826F10 Offset: 0x2827011 VA: 0x2826F10
	|-ObjectComparer<MeshFaceConnectivity.EdgeData>.Compare
	|
	|-RVA: 0x2827100 Offset: 0x2827201 VA: 0x2827100
	|-ObjectComparer<NavMeshBuildMarkup>.Compare
	|
	|-RVA: 0x28272D0 Offset: 0x28273D1 VA: 0x28272D0
	|-ObjectComparer<NavMeshBuildSource>.Compare
	|
	|-RVA: 0x2827500 Offset: 0x2827601 VA: 0x2827500
	|-ObjectComparer<ConstraintSource>.Compare
	|
	|-RVA: 0x28276D0 Offset: 0x28277D1 VA: 0x28276D0
	|-ObjectComparer<AnimatorClipInfo>.Compare
	|
	|-RVA: 0x2827890 Offset: 0x2827991 VA: 0x2827890
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.Compare
	|
	|-RVA: 0x2827A60 Offset: 0x2827B61 VA: 0x2827A60
	|-ObjectComparer<BoneWeight>.Compare
	|
	|-RVA: 0x2827C40 Offset: 0x2827D41 VA: 0x2827C40
	|-ObjectComparer<Bounds>.Compare
	|
	|-RVA: 0x2827E20 Offset: 0x2827F21 VA: 0x2827E20
	|-ObjectComparer<BoundsInt>.Compare
	|
	|-RVA: 0x2828000 Offset: 0x2828101 VA: 0x2828000
	|-ObjectComparer<Color32>.Compare
	|
	|-RVA: 0x28281C0 Offset: 0x28282C1 VA: 0x28281C0
	|-ObjectComparer<Color>.Compare
	|
	|-RVA: 0x28283C0 Offset: 0x28284C1 VA: 0x28283C0
	|-ObjectComparer<CombineInstance>.Compare
	|
	|-RVA: 0x28285F0 Offset: 0x28286F1 VA: 0x28285F0
	|-ObjectComparer<RaycastResult>.Compare
	|
	|-RVA: 0x2828800 Offset: 0x2828901 VA: 0x2828800
	|-ObjectComparer<GradientAlphaKey>.Compare
	|
	|-RVA: 0x28289E0 Offset: 0x2828AE1 VA: 0x28289E0
	|-ObjectComparer<GradientColorKey>.Compare
	|
	|-RVA: 0x2828BC0 Offset: 0x2828CC1 VA: 0x2828BC0
	|-ObjectComparer<Keyframe>.Compare
	|
	|-RVA: 0x2828DB0 Offset: 0x2828EB1 VA: 0x2828DB0
	|-ObjectComparer<LayerMask>.Compare
	|
	|-RVA: 0x2828F70 Offset: 0x2829071 VA: 0x2828F70
	|-ObjectComparer<Matrix4x4>.Compare
	|
	|-RVA: 0x2829170 Offset: 0x2829271 VA: 0x2829170
	|-ObjectComparer<ParticleSystem.Particle>.Compare
	|
	|-RVA: 0x2829350 Offset: 0x2829451 VA: 0x2829350
	|-ObjectComparer<Playable>.Compare
	|
	|-RVA: 0x2829520 Offset: 0x2829621 VA: 0x2829520
	|-ObjectComparer<PlayableBinding>.Compare
	|
	|-RVA: 0x2829700 Offset: 0x2829801 VA: 0x2829700
	|-ObjectComparer<PlayableGraph>.Compare
	|
	|-RVA: 0x28298D0 Offset: 0x28299D1 VA: 0x28298D0
	|-ObjectComparer<Edge>.Compare
	|
	|-RVA: 0x2829A90 Offset: 0x2829B91 VA: 0x2829A90
	|-ObjectComparer<Quaternion>.Compare
	|
	|-RVA: 0x2829C90 Offset: 0x2829D91 VA: 0x2829C90
	|-ObjectComparer<RangeInt>.Compare
	|
	|-RVA: 0x2829E50 Offset: 0x2829F51 VA: 0x2829E50
	|-ObjectComparer<RaycastHit2D>.Compare
	|
	|-RVA: 0x282A050 Offset: 0x282A151 VA: 0x282A050
	|-ObjectComparer<RaycastHit>.Compare
	|
	|-RVA: 0x282A250 Offset: 0x282A351 VA: 0x282A250
	|-ObjectComparer<Rect>.Compare
	|
	|-RVA: 0x282A450 Offset: 0x282A551 VA: 0x282A450
	|-ObjectComparer<RectInt>.Compare
	|
	|-RVA: 0x282A620 Offset: 0x282A721 VA: 0x282A620
	|-ObjectComparer<ReflectionProbeBlendInfo>.Compare
	|
	|-RVA: 0x282A7F0 Offset: 0x282A8F1 VA: 0x282A7F0
	|-ObjectComparer<SphericalHarmonicsL2>.Compare
	|
	|-RVA: 0x282AA30 Offset: 0x282AB31 VA: 0x282AA30
	|-ObjectComparer<VertexAttributeDescriptor>.Compare
	|
	|-RVA: 0x282AC00 Offset: 0x282AD01 VA: 0x282AC00
	|-ObjectComparer<AsyncOperationHandle>.Compare
	|
	|-RVA: 0x282ADE0 Offset: 0x282AEE1 VA: 0x282ADE0
	|-ObjectComparer<AsyncOperationHandle<SceneInstance>>.Compare
	|
	|-RVA: 0x282AFC0 Offset: 0x282B0C1 VA: 0x282AFC0
	|-ObjectComparer<DiagnosticEvent>.Compare
	|
	|-RVA: 0x282B1B0 Offset: 0x282B2B1 VA: 0x282B1B0
	|-ObjectComparer<DelayedActionManager.DelegateInfo>.Compare
	|
	|-RVA: 0x282B390 Offset: 0x282B491 VA: 0x282B390
	|-ObjectComparer<ObjectInitializationData>.Compare
	|
	|-RVA: 0x282B580 Offset: 0x282B681 VA: 0x282B580
	|-ObjectComparer<GlyphRect>.Compare
	|
	|-RVA: 0x282B750 Offset: 0x282B851 VA: 0x282B750
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>.Compare
	|
	|-RVA: 0x282B940 Offset: 0x282BA41 VA: 0x282B940
	|-ObjectComparer<IntervalTreeNode>.Compare
	|
	|-RVA: 0x282BB20 Offset: 0x282BC21 VA: 0x282BB20
	|-ObjectComparer<IntervalTree.Entry<object>>.Compare
	|
	|-RVA: 0x282BD00 Offset: 0x282BE01 VA: 0x282BD00
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>.Compare
	|
	|-RVA: 0x282BEE0 Offset: 0x282BFE1 VA: 0x282BEE0
	|-ObjectComparer<UICharInfo>.Compare
	|
	|-RVA: 0x282C0D0 Offset: 0x282C1D1 VA: 0x282C0D0
	|-ObjectComparer<FocusController.FocusedElement>.Compare
	|
	|-RVA: 0x282C2A0 Offset: 0x282C3A1 VA: 0x282C2A0
	|-ObjectComparer<UILineInfo>.Compare
	|
	|-RVA: 0x282C470 Offset: 0x282C571 VA: 0x282C470
	|-ObjectComparer<UIVertex>.Compare
	|
	|-RVA: 0x282C690 Offset: 0x282C791 VA: 0x282C690
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.Compare
	|
	|-RVA: 0x282C870 Offset: 0x282C971 VA: 0x282C870
	|-ObjectComparer<Vector2>.Compare
	|
	|-RVA: 0x282CA50 Offset: 0x282CB51 VA: 0x282CA50
	|-ObjectComparer<Vector2Int>.Compare
	|
	|-RVA: 0x282CC10 Offset: 0x282CD11 VA: 0x282CC10
	|-ObjectComparer<Vector3>.Compare
	|
	|-RVA: 0x282CE00 Offset: 0x282CF01 VA: 0x282CE00
	|-ObjectComparer<Vector3Int>.Compare
	|
	|-RVA: 0x282CFE0 Offset: 0x282D0E1 VA: 0x282CFE0
	|-ObjectComparer<Vector4>.Compare
	|
	|-RVA: 0x282D1E0 Offset: 0x282D2E1 VA: 0x282D1E0
	|-ObjectComparer<WarpPoints.WarpPoint>.Compare
	|
	|-RVA: 0x282D420 Offset: 0x282D521 VA: 0x282D420
	|-ObjectComparer<YieldItemParam>.Compare
	|
	|-RVA: 0x282D5E0 Offset: 0x282D6E1 VA: 0x282D5E0
	|-ObjectComparer<stCommand_t>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CFA040 Offset: 0x2CFA141 VA: 0x2CFA040
	|-ObjectComparer<AS_ToolController.ChargeInfo>.Equals
	|
	|-RVA: 0x2CFA280 Offset: 0x2CFA381 VA: 0x2CFA280
	|-ObjectComparer<BuildItemData>.Equals
	|
	|-RVA: 0x2CFA450 Offset: 0x2CFA551 VA: 0x2CFA450
	|-ObjectComparer<ButtonLinker.LinkObject>.Equals
	|
	|-RVA: 0x2CFA620 Offset: 0x2CFA721 VA: 0x2CFA620
	|-ObjectComparer<CharaCallTable.BustupTable>.Equals
	|
	|-RVA: 0x2CFA800 Offset: 0x2CFA901 VA: 0x2CFA800
	|-ObjectComparer<CharaCallTable.CharaFaceIconTable>.Equals
	|
	|-RVA: 0x2CFA9D0 Offset: 0x2CFAAD1 VA: 0x2CFA9D0
	|-ObjectComparer<CameraState.CustomBlendable>.Equals
	|
	|-RVA: 0x2CFAB90 Offset: 0x2CFAC91 VA: 0x2CFAB90
	|-ObjectComparer<CinemachineClearShot.Pair>.Equals
	|
	|-RVA: 0x2CFAD50 Offset: 0x2CFAE51 VA: 0x2CFAD50
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>.Equals
	|
	|-RVA: 0x2CFAF40 Offset: 0x2CFB041 VA: 0x2CFAF40
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>.Equals
	|
	|-RVA: 0x2CFB140 Offset: 0x2CFB241 VA: 0x2CFB140
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>.Equals
	|
	|-RVA: 0x2CFB320 Offset: 0x2CFB421 VA: 0x2CFB320
	|-ObjectComparer<CropDataTable>.Equals
	|
	|-RVA: 0x2CFB4E0 Offset: 0x2CFB5E1 VA: 0x2CFB4E0
	|-ObjectComparer<DropItemParam>.Equals
	|
	|-RVA: 0x2CFB6C0 Offset: 0x2CFB7C1 VA: 0x2CFB6C0
	|-ObjectComparer<ErosionBrush.UndoStep>.Equals
	|
	|-RVA: 0x2CFB8A0 Offset: 0x2CFB9A1 VA: 0x2CFB8A0
	|-ObjectComparer<EventCheckId>.Equals
	|
	|-RVA: 0x2CFBA70 Offset: 0x2CFBB71 VA: 0x2CFBA70
	|-ObjectComparer<EventFlagProgressData>.Equals
	|
	|-RVA: 0x2CFBC40 Offset: 0x2CFBD41 VA: 0x2CFBC40
	|-ObjectComparer<FesNpcScoreData>.Equals
	|
	|-RVA: 0x2CFBE30 Offset: 0x2CFBF31 VA: 0x2CFBE30
	|-ObjectComparer<HitResult>.Equals
	|
	|-RVA: 0x2CFC030 Offset: 0x2CFC131 VA: 0x2CFC030
	|-ObjectComparer<MiningPointSaveData>.Equals
	|
	|-RVA: 0x2CFC220 Offset: 0x2CFC321 VA: 0x2CFC220
	|-ObjectComparer<MonsterHutSaveData>.Equals
	|
	|-RVA: 0x2CFC3F0 Offset: 0x2CFC4F1 VA: 0x2CFC3F0
	|-ObjectComparer<MoviePlayer.SUBTITLEDATA>.Equals
	|
	|-RVA: 0x2CFC5F0 Offset: 0x2CFC6F1 VA: 0x2CFC5F0
	|-ObjectComparer<NPCActionData>.Equals
	|
	|-RVA: 0x2CFC7D0 Offset: 0x2CFC8D1 VA: 0x2CFC7D0
	|-ObjectComparer<NpcPlaceSchedule>.Equals
	|
	|-RVA: 0x2CFC9B0 Offset: 0x2CFCAB1 VA: 0x2CFC9B0
	|-ObjectComparer<OrderLotterySaveParameter>.Equals
	|
	|-RVA: 0x2CFCB90 Offset: 0x2CFCC91 VA: 0x2CFCB90
	|-ObjectComparer<OrderSaveParameter>.Equals
	|
	|-RVA: 0x2CFCD60 Offset: 0x2CFCE61 VA: 0x2CFCD60
	|-ObjectComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.Equals
	|
	|-RVA: 0x2CFCF40 Offset: 0x2CFD041 VA: 0x2CFCF40
	|-ObjectComparer<Parameter>.Equals
	|
	|-RVA: 0x2CFD110 Offset: 0x2CFD211 VA: 0x2CFD110
	|-ObjectComparer<ShopCatalogPage>.Equals
	|
	|-RVA: 0x2CFD300 Offset: 0x2CFD401 VA: 0x2CFD300
	|-ObjectComparer<ShopNpcTalk>.Equals
	|
	|-RVA: 0x2CFD4E0 Offset: 0x2CFD5E1 VA: 0x2CFD4E0
	|-ObjectComparer<SubtitleDataTable.Data>.Equals
	|
	|-RVA: 0x2CFD6A0 Offset: 0x2CFD7A1 VA: 0x2CFD6A0
	|-ObjectComparer<SubtitleDataTable.DataList>.Equals
	|
	|-RVA: 0x2CFD880 Offset: 0x2CFD981 VA: 0x2CFD880
	|-ObjectComparer<SubtitleHudDataTable.Data>.Equals
	|
	|-RVA: 0x2CFDA60 Offset: 0x2CFDB61 VA: 0x2CFDA60
	|-ObjectComparer<SRMonoBehaviourEx.FieldInfo>.Equals
	|
	|-RVA: 0x2CFDC40 Offset: 0x2CFDD41 VA: 0x2CFDC40
	|-ObjectComparer<Schedule>.Equals
	|
	|-RVA: 0x2CFDE50 Offset: 0x2CFDF51 VA: 0x2CFDE50
	|-ObjectComparer<CurveSample>.Equals
	|
	|-RVA: 0x2CFE010 Offset: 0x2CFE111 VA: 0x2CFE010
	|-ObjectComparer<bool>.Equals
	|
	|-RVA: 0x2CFE1D0 Offset: 0x2CFE2D1 VA: 0x2CFE1D0
	|-ObjectComparer<byte>.Equals
	|
	|-RVA: 0x2CFE390 Offset: 0x2CFE491 VA: 0x2CFE390
	|-ObjectComparer<char>.Equals
	|
	|-RVA: 0x2CFE560 Offset: 0x2CFE661 VA: 0x2CFE560
	|-ObjectComparer<KeyValuePair<DateTime, object>>.Equals
	|
	|-RVA: 0x2CFE730 Offset: 0x2CFE831 VA: 0x2CFE730
	|-ObjectComparer<KeyValuePair<int, object>>.Equals
	|
	|-RVA: 0x2CFE900 Offset: 0x2CFEA01 VA: 0x2CFE900
	|-ObjectComparer<KeyValuePair<object, object>>.Equals
	|
	|-RVA: 0x2CFEAC0 Offset: 0x2CFEBC1 VA: 0x2CFEAC0
	|-ObjectComparer<DateTime>.Equals
	|
	|-RVA: 0x2CFEC90 Offset: 0x2CFED91 VA: 0x2CFEC90
	|-ObjectComparer<double>.Equals
	|
	|-RVA: 0x2CFEE60 Offset: 0x2CFEF61 VA: 0x2CFEE60
	|-ObjectComparer<Guid>.Equals
	|
	|-RVA: 0x2821C00 Offset: 0x2821D01 VA: 0x2821C00
	|-ObjectComparer<short>.Equals
	|
	|-RVA: 0x2821DC0 Offset: 0x2821EC1 VA: 0x2821DC0
	|-ObjectComparer<int>.Equals
	|
	|-RVA: 0x2821F80 Offset: 0x2822081 VA: 0x2821F80
	|-ObjectComparer<Int32Enum>.Equals
	|
	|-RVA: 0x2822140 Offset: 0x2822241 VA: 0x2822140
	|-ObjectComparer<long>.Equals
	|
	|-RVA: 0x2822310 Offset: 0x2822411 VA: 0x2822310
	|-ObjectComparer<InterpretedFrameInfo>.Equals
	|
	|-RVA: 0x28224D0 Offset: 0x28225D1 VA: 0x28224D0
	|-ObjectComparer<Nullable<Int32Enum>>.Equals
	|
	|-RVA: 0x28226C0 Offset: 0x28227C1 VA: 0x28226C0
	|-ObjectComparer<Nullable<Bounds>>.Equals
	|
	|-RVA: 0x28228B0 Offset: 0x28229B1 VA: 0x28228B0
	|-ObjectComparer<Nullable<BoundsInt>>.Equals
	|
	|-RVA: 0x2822A70 Offset: 0x2822B71 VA: 0x2822A70
	|-ObjectComparer<Nullable<Color32>>.Equals
	|
	|-RVA: 0x2822C50 Offset: 0x2822D51 VA: 0x2822C50
	|-ObjectComparer<Nullable<Color>>.Equals
	|
	|-RVA: 0x2822E30 Offset: 0x2822F31 VA: 0x2822E30
	|-ObjectComparer<Nullable<GradientAlphaKey>>.Equals
	|
	|-RVA: 0x2823010 Offset: 0x2823111 VA: 0x2823010
	|-ObjectComparer<Nullable<GradientColorKey>>.Equals
	|
	|-RVA: 0x28231F0 Offset: 0x28232F1 VA: 0x28231F0
	|-ObjectComparer<Nullable<Keyframe>>.Equals
	|
	|-RVA: 0x28233B0 Offset: 0x28234B1 VA: 0x28233B0
	|-ObjectComparer<Nullable<LayerMask>>.Equals
	|
	|-RVA: 0x28235D0 Offset: 0x28236D1 VA: 0x28235D0
	|-ObjectComparer<Nullable<Matrix4x4>>.Equals
	|
	|-RVA: 0x28237B0 Offset: 0x28238B1 VA: 0x28237B0
	|-ObjectComparer<Nullable<Quaternion>>.Equals
	|
	|-RVA: 0x2823990 Offset: 0x2823A91 VA: 0x2823990
	|-ObjectComparer<Nullable<RangeInt>>.Equals
	|
	|-RVA: 0x2823B70 Offset: 0x2823C71 VA: 0x2823B70
	|-ObjectComparer<Nullable<Rect>>.Equals
	|
	|-RVA: 0x2823D50 Offset: 0x2823E51 VA: 0x2823D50
	|-ObjectComparer<Nullable<RectInt>>.Equals
	|
	|-RVA: 0x2823F30 Offset: 0x2824031 VA: 0x2823F30
	|-ObjectComparer<Nullable<Vector2>>.Equals
	|
	|-RVA: 0x2824110 Offset: 0x2824211 VA: 0x2824110
	|-ObjectComparer<Nullable<Vector2Int>>.Equals
	|
	|-RVA: 0x28242E0 Offset: 0x28243E1 VA: 0x28242E0
	|-ObjectComparer<Nullable<Vector3>>.Equals
	|
	|-RVA: 0x28244B0 Offset: 0x28245B1 VA: 0x28244B0
	|-ObjectComparer<Nullable<Vector3Int>>.Equals
	|
	|-RVA: 0x2824690 Offset: 0x2824791 VA: 0x2824690
	|-ObjectComparer<Nullable<Vector4>>.Equals
	|
	|-RVA: 0x28247E0 Offset: 0x28248E1 VA: 0x28247E0
	|-ObjectComparer<object>.Equals
	|
	|-RVA: 0x28249A0 Offset: 0x2824AA1 VA: 0x28249A0
	|-ObjectComparer<sbyte>.Equals
	|
	|-RVA: 0x2824B60 Offset: 0x2824C61 VA: 0x2824B60
	|-ObjectComparer<float>.Equals
	|
	|-RVA: 0x2824D20 Offset: 0x2824E21 VA: 0x2824D20
	|-ObjectComparer<ushort>.Equals
	|
	|-RVA: 0x2824EE0 Offset: 0x2824FE1 VA: 0x2824EE0
	|-ObjectComparer<uint>.Equals
	|
	|-RVA: 0x28250A0 Offset: 0x28251A1 VA: 0x28250A0
	|-ObjectComparer<ulong>.Equals
	|
	|-RVA: 0x2825260 Offset: 0x2825361 VA: 0x2825260
	|-ObjectComparer<ValueTuple<bool, Int32Enum>>.Equals
	|
	|-RVA: 0x2825420 Offset: 0x2825521 VA: 0x2825420
	|-ObjectComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x28255F0 Offset: 0x28256F1 VA: 0x28255F0
	|-ObjectComparer<ValueTuple<Int32Enum, object>>.Equals
	|
	|-RVA: 0x28257C0 Offset: 0x28258C1 VA: 0x28257C0
	|-ObjectComparer<ValueTuple<object, Int32Enum>>.Equals
	|
	|-RVA: 0x2825990 Offset: 0x2825A91 VA: 0x2825990
	|-ObjectComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x2825B60 Offset: 0x2825C61 VA: 0x2825B60
	|-ObjectComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x2825D40 Offset: 0x2825E41 VA: 0x2825D40
	|-ObjectComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Equals
	|
	|-RVA: 0x2825F20 Offset: 0x2826021 VA: 0x2825F20
	|-ObjectComparer<ValueTuple<object, object, Vector3>>.Equals
	|
	|-RVA: 0x2826100 Offset: 0x2826201 VA: 0x2826100
	|-ObjectComparer<ValueTuple<object, object, Vector3, float>>.Equals
	|
	|-RVA: 0x2826300 Offset: 0x2826401 VA: 0x2826300
	|-ObjectComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Equals
	|
	|-RVA: 0x2826500 Offset: 0x2826601 VA: 0x2826500
	|-ObjectComparer<TexturePacker_JsonArray.Frame>.Equals
	|
	|-RVA: 0x28266E0 Offset: 0x28267E1 VA: 0x28266E0
	|-ObjectComparer<TutorialUnlockFlagData>.Equals
	|
	|-RVA: 0x28268B0 Offset: 0x28269B1 VA: 0x28268B0
	|-ObjectComparer<UIMainManagerAttachObject.AttachSet>.Equals
	|
	|-RVA: 0x2826AB0 Offset: 0x2826BB1 VA: 0x2826AB0
	|-ObjectComparer<CapEdge>.Equals
	|
	|-RVA: 0x2826C70 Offset: 0x2826D71 VA: 0x2826C70
	|-ObjectComparer<MeshDataConnectivity.Face>.Equals
	|
	|-RVA: 0x2826E50 Offset: 0x2826F51 VA: 0x2826E50
	|-ObjectComparer<MeshFaceConnectivity.EdgeData.SideData>.Equals
	|
	|-RVA: 0x2827040 Offset: 0x2827141 VA: 0x2827040
	|-ObjectComparer<MeshFaceConnectivity.EdgeData>.Equals
	|
	|-RVA: 0x2827210 Offset: 0x2827311 VA: 0x2827210
	|-ObjectComparer<NavMeshBuildMarkup>.Equals
	|
	|-RVA: 0x2827440 Offset: 0x2827541 VA: 0x2827440
	|-ObjectComparer<NavMeshBuildSource>.Equals
	|
	|-RVA: 0x2827610 Offset: 0x2827711 VA: 0x2827610
	|-ObjectComparer<ConstraintSource>.Equals
	|
	|-RVA: 0x28277D0 Offset: 0x28278D1 VA: 0x28277D0
	|-ObjectComparer<AnimatorClipInfo>.Equals
	|
	|-RVA: 0x28279A0 Offset: 0x2827AA1 VA: 0x28279A0
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.Equals
	|
	|-RVA: 0x2827B80 Offset: 0x2827C81 VA: 0x2827B80
	|-ObjectComparer<BoneWeight>.Equals
	|
	|-RVA: 0x2827D60 Offset: 0x2827E61 VA: 0x2827D60
	|-ObjectComparer<Bounds>.Equals
	|
	|-RVA: 0x2827F40 Offset: 0x2828041 VA: 0x2827F40
	|-ObjectComparer<BoundsInt>.Equals
	|
	|-RVA: 0x2828100 Offset: 0x2828201 VA: 0x2828100
	|-ObjectComparer<Color32>.Equals
	|
	|-RVA: 0x2828300 Offset: 0x2828401 VA: 0x2828300
	|-ObjectComparer<Color>.Equals
	|
	|-RVA: 0x2828530 Offset: 0x2828631 VA: 0x2828530
	|-ObjectComparer<CombineInstance>.Equals
	|
	|-RVA: 0x2828740 Offset: 0x2828841 VA: 0x2828740
	|-ObjectComparer<RaycastResult>.Equals
	|
	|-RVA: 0x2828920 Offset: 0x2828A21 VA: 0x2828920
	|-ObjectComparer<GradientAlphaKey>.Equals
	|
	|-RVA: 0x2828B00 Offset: 0x2828C01 VA: 0x2828B00
	|-ObjectComparer<GradientColorKey>.Equals
	|
	|-RVA: 0x2828CF0 Offset: 0x2828DF1 VA: 0x2828CF0
	|-ObjectComparer<Keyframe>.Equals
	|
	|-RVA: 0x2828EB0 Offset: 0x2828FB1 VA: 0x2828EB0
	|-ObjectComparer<LayerMask>.Equals
	|
	|-RVA: 0x28290B0 Offset: 0x28291B1 VA: 0x28290B0
	|-ObjectComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x2829290 Offset: 0x2829391 VA: 0x2829290
	|-ObjectComparer<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x2829460 Offset: 0x2829561 VA: 0x2829460
	|-ObjectComparer<Playable>.Equals
	|
	|-RVA: 0x2829640 Offset: 0x2829741 VA: 0x2829640
	|-ObjectComparer<PlayableBinding>.Equals
	|
	|-RVA: 0x2829810 Offset: 0x2829911 VA: 0x2829810
	|-ObjectComparer<PlayableGraph>.Equals
	|
	|-RVA: 0x28299D0 Offset: 0x2829AD1 VA: 0x28299D0
	|-ObjectComparer<Edge>.Equals
	|
	|-RVA: 0x2829BD0 Offset: 0x2829CD1 VA: 0x2829BD0
	|-ObjectComparer<Quaternion>.Equals
	|
	|-RVA: 0x2829D90 Offset: 0x2829E91 VA: 0x2829D90
	|-ObjectComparer<RangeInt>.Equals
	|
	|-RVA: 0x2829F90 Offset: 0x282A091 VA: 0x2829F90
	|-ObjectComparer<RaycastHit2D>.Equals
	|
	|-RVA: 0x282A190 Offset: 0x282A291 VA: 0x282A190
	|-ObjectComparer<RaycastHit>.Equals
	|
	|-RVA: 0x282A390 Offset: 0x282A491 VA: 0x282A390
	|-ObjectComparer<Rect>.Equals
	|
	|-RVA: 0x282A560 Offset: 0x282A661 VA: 0x282A560
	|-ObjectComparer<RectInt>.Equals
	|
	|-RVA: 0x282A730 Offset: 0x282A831 VA: 0x282A730
	|-ObjectComparer<ReflectionProbeBlendInfo>.Equals
	|
	|-RVA: 0x282A970 Offset: 0x282AA71 VA: 0x282A970
	|-ObjectComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x282AB40 Offset: 0x282AC41 VA: 0x282AB40
	|-ObjectComparer<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x282AD20 Offset: 0x282AE21 VA: 0x282AD20
	|-ObjectComparer<AsyncOperationHandle>.Equals
	|
	|-RVA: 0x282AF00 Offset: 0x282B001 VA: 0x282AF00
	|-ObjectComparer<AsyncOperationHandle<SceneInstance>>.Equals
	|
	|-RVA: 0x282B0F0 Offset: 0x282B1F1 VA: 0x282B0F0
	|-ObjectComparer<DiagnosticEvent>.Equals
	|
	|-RVA: 0x282B2D0 Offset: 0x282B3D1 VA: 0x282B2D0
	|-ObjectComparer<DelayedActionManager.DelegateInfo>.Equals
	|
	|-RVA: 0x282B4C0 Offset: 0x282B5C1 VA: 0x282B4C0
	|-ObjectComparer<ObjectInitializationData>.Equals
	|
	|-RVA: 0x282B690 Offset: 0x282B791 VA: 0x282B690
	|-ObjectComparer<GlyphRect>.Equals
	|
	|-RVA: 0x282B880 Offset: 0x282B981 VA: 0x282B880
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>.Equals
	|
	|-RVA: 0x282BA60 Offset: 0x282BB61 VA: 0x282BA60
	|-ObjectComparer<IntervalTreeNode>.Equals
	|
	|-RVA: 0x282BC40 Offset: 0x282BD41 VA: 0x282BC40
	|-ObjectComparer<IntervalTree.Entry<object>>.Equals
	|
	|-RVA: 0x282BE20 Offset: 0x282BF21 VA: 0x282BE20
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>.Equals
	|
	|-RVA: 0x282C010 Offset: 0x282C111 VA: 0x282C010
	|-ObjectComparer<UICharInfo>.Equals
	|
	|-RVA: 0x282C1E0 Offset: 0x282C2E1 VA: 0x282C1E0
	|-ObjectComparer<FocusController.FocusedElement>.Equals
	|
	|-RVA: 0x282C3B0 Offset: 0x282C4B1 VA: 0x282C3B0
	|-ObjectComparer<UILineInfo>.Equals
	|
	|-RVA: 0x282C5D0 Offset: 0x282C6D1 VA: 0x282C5D0
	|-ObjectComparer<UIVertex>.Equals
	|
	|-RVA: 0x282C7B0 Offset: 0x282C8B1 VA: 0x282C7B0
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.Equals
	|
	|-RVA: 0x282C990 Offset: 0x282CA91 VA: 0x282C990
	|-ObjectComparer<Vector2>.Equals
	|
	|-RVA: 0x282CB50 Offset: 0x282CC51 VA: 0x282CB50
	|-ObjectComparer<Vector2Int>.Equals
	|
	|-RVA: 0x282CD40 Offset: 0x282CE41 VA: 0x282CD40
	|-ObjectComparer<Vector3>.Equals
	|
	|-RVA: 0x282CF20 Offset: 0x282D021 VA: 0x282CF20
	|-ObjectComparer<Vector3Int>.Equals
	|
	|-RVA: 0x282D120 Offset: 0x282D221 VA: 0x282D120
	|-ObjectComparer<Vector4>.Equals
	|
	|-RVA: 0x282D360 Offset: 0x282D461 VA: 0x282D360
	|-ObjectComparer<WarpPoints.WarpPoint>.Equals
	|
	|-RVA: 0x282D520 Offset: 0x282D621 VA: 0x282D520
	|-ObjectComparer<YieldItemParam>.Equals
	|
	|-RVA: 0x282D700 Offset: 0x282D801 VA: 0x282D700
	|-ObjectComparer<stCommand_t>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CFA090 Offset: 0x2CFA191 VA: 0x2CFA090
	|-ObjectComparer<AS_ToolController.ChargeInfo>.GetHashCode
	|
	|-RVA: 0x2CFA2D0 Offset: 0x2CFA3D1 VA: 0x2CFA2D0
	|-ObjectComparer<BuildItemData>.GetHashCode
	|
	|-RVA: 0x2CFA4A0 Offset: 0x2CFA5A1 VA: 0x2CFA4A0
	|-ObjectComparer<ButtonLinker.LinkObject>.GetHashCode
	|
	|-RVA: 0x2CFA670 Offset: 0x2CFA771 VA: 0x2CFA670
	|-ObjectComparer<CharaCallTable.BustupTable>.GetHashCode
	|
	|-RVA: 0x2CFA850 Offset: 0x2CFA951 VA: 0x2CFA850
	|-ObjectComparer<CharaCallTable.CharaFaceIconTable>.GetHashCode
	|
	|-RVA: 0x2CFAA20 Offset: 0x2CFAB21 VA: 0x2CFAA20
	|-ObjectComparer<CameraState.CustomBlendable>.GetHashCode
	|
	|-RVA: 0x2CFABE0 Offset: 0x2CFACE1 VA: 0x2CFABE0
	|-ObjectComparer<CinemachineClearShot.Pair>.GetHashCode
	|
	|-RVA: 0x2CFADA0 Offset: 0x2CFAEA1 VA: 0x2CFADA0
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>.GetHashCode
	|
	|-RVA: 0x2CFAF90 Offset: 0x2CFB091 VA: 0x2CFAF90
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>.GetHashCode
	|
	|-RVA: 0x2CFB190 Offset: 0x2CFB291 VA: 0x2CFB190
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>.GetHashCode
	|
	|-RVA: 0x2CFB370 Offset: 0x2CFB471 VA: 0x2CFB370
	|-ObjectComparer<CropDataTable>.GetHashCode
	|
	|-RVA: 0x2CFB530 Offset: 0x2CFB631 VA: 0x2CFB530
	|-ObjectComparer<DropItemParam>.GetHashCode
	|
	|-RVA: 0x2CFB710 Offset: 0x2CFB811 VA: 0x2CFB710
	|-ObjectComparer<ErosionBrush.UndoStep>.GetHashCode
	|
	|-RVA: 0x2CFB8F0 Offset: 0x2CFB9F1 VA: 0x2CFB8F0
	|-ObjectComparer<EventCheckId>.GetHashCode
	|
	|-RVA: 0x2CFBAC0 Offset: 0x2CFBBC1 VA: 0x2CFBAC0
	|-ObjectComparer<EventFlagProgressData>.GetHashCode
	|
	|-RVA: 0x2CFBC90 Offset: 0x2CFBD91 VA: 0x2CFBC90
	|-ObjectComparer<FesNpcScoreData>.GetHashCode
	|
	|-RVA: 0x2CFBE80 Offset: 0x2CFBF81 VA: 0x2CFBE80
	|-ObjectComparer<HitResult>.GetHashCode
	|
	|-RVA: 0x2CFC080 Offset: 0x2CFC181 VA: 0x2CFC080
	|-ObjectComparer<MiningPointSaveData>.GetHashCode
	|
	|-RVA: 0x2CFC270 Offset: 0x2CFC371 VA: 0x2CFC270
	|-ObjectComparer<MonsterHutSaveData>.GetHashCode
	|
	|-RVA: 0x2CFC440 Offset: 0x2CFC541 VA: 0x2CFC440
	|-ObjectComparer<MoviePlayer.SUBTITLEDATA>.GetHashCode
	|
	|-RVA: 0x2CFC640 Offset: 0x2CFC741 VA: 0x2CFC640
	|-ObjectComparer<NPCActionData>.GetHashCode
	|
	|-RVA: 0x2CFC820 Offset: 0x2CFC921 VA: 0x2CFC820
	|-ObjectComparer<NpcPlaceSchedule>.GetHashCode
	|
	|-RVA: 0x2CFCA00 Offset: 0x2CFCB01 VA: 0x2CFCA00
	|-ObjectComparer<OrderLotterySaveParameter>.GetHashCode
	|
	|-RVA: 0x2CFCBE0 Offset: 0x2CFCCE1 VA: 0x2CFCBE0
	|-ObjectComparer<OrderSaveParameter>.GetHashCode
	|
	|-RVA: 0x2CFCDB0 Offset: 0x2CFCEB1 VA: 0x2CFCDB0
	|-ObjectComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetHashCode
	|
	|-RVA: 0x2CFCF90 Offset: 0x2CFD091 VA: 0x2CFCF90
	|-ObjectComparer<Parameter>.GetHashCode
	|
	|-RVA: 0x2CFD160 Offset: 0x2CFD261 VA: 0x2CFD160
	|-ObjectComparer<ShopCatalogPage>.GetHashCode
	|
	|-RVA: 0x2CFD350 Offset: 0x2CFD451 VA: 0x2CFD350
	|-ObjectComparer<ShopNpcTalk>.GetHashCode
	|
	|-RVA: 0x2CFD530 Offset: 0x2CFD631 VA: 0x2CFD530
	|-ObjectComparer<SubtitleDataTable.Data>.GetHashCode
	|
	|-RVA: 0x2CFD6F0 Offset: 0x2CFD7F1 VA: 0x2CFD6F0
	|-ObjectComparer<SubtitleDataTable.DataList>.GetHashCode
	|
	|-RVA: 0x2CFD8D0 Offset: 0x2CFD9D1 VA: 0x2CFD8D0
	|-ObjectComparer<SubtitleHudDataTable.Data>.GetHashCode
	|
	|-RVA: 0x2CFDAB0 Offset: 0x2CFDBB1 VA: 0x2CFDAB0
	|-ObjectComparer<SRMonoBehaviourEx.FieldInfo>.GetHashCode
	|
	|-RVA: 0x2CFDC90 Offset: 0x2CFDD91 VA: 0x2CFDC90
	|-ObjectComparer<Schedule>.GetHashCode
	|
	|-RVA: 0x2CFDEA0 Offset: 0x2CFDFA1 VA: 0x2CFDEA0
	|-ObjectComparer<CurveSample>.GetHashCode
	|
	|-RVA: 0x2CFE060 Offset: 0x2CFE161 VA: 0x2CFE060
	|-ObjectComparer<bool>.GetHashCode
	|
	|-RVA: 0x2CFE220 Offset: 0x2CFE321 VA: 0x2CFE220
	|-ObjectComparer<byte>.GetHashCode
	|
	|-RVA: 0x2CFE3E0 Offset: 0x2CFE4E1 VA: 0x2CFE3E0
	|-ObjectComparer<char>.GetHashCode
	|
	|-RVA: 0x2CFE5B0 Offset: 0x2CFE6B1 VA: 0x2CFE5B0
	|-ObjectComparer<KeyValuePair<DateTime, object>>.GetHashCode
	|
	|-RVA: 0x2CFE780 Offset: 0x2CFE881 VA: 0x2CFE780
	|-ObjectComparer<KeyValuePair<int, object>>.GetHashCode
	|
	|-RVA: 0x2CFE950 Offset: 0x2CFEA51 VA: 0x2CFE950
	|-ObjectComparer<KeyValuePair<object, object>>.GetHashCode
	|
	|-RVA: 0x2CFEB10 Offset: 0x2CFEC11 VA: 0x2CFEB10
	|-ObjectComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x2CFECE0 Offset: 0x2CFEDE1 VA: 0x2CFECE0
	|-ObjectComparer<double>.GetHashCode
	|
	|-RVA: 0x2CFEEB0 Offset: 0x2CFEFB1 VA: 0x2CFEEB0
	|-ObjectComparer<Guid>.GetHashCode
	|
	|-RVA: 0x2821C50 Offset: 0x2821D51 VA: 0x2821C50
	|-ObjectComparer<short>.GetHashCode
	|
	|-RVA: 0x2821E10 Offset: 0x2821F11 VA: 0x2821E10
	|-ObjectComparer<int>.GetHashCode
	|
	|-RVA: 0x2821FD0 Offset: 0x28220D1 VA: 0x2821FD0
	|-ObjectComparer<Int32Enum>.GetHashCode
	|
	|-RVA: 0x2822190 Offset: 0x2822291 VA: 0x2822190
	|-ObjectComparer<long>.GetHashCode
	|
	|-RVA: 0x2822360 Offset: 0x2822461 VA: 0x2822360
	|-ObjectComparer<InterpretedFrameInfo>.GetHashCode
	|
	|-RVA: 0x2822520 Offset: 0x2822621 VA: 0x2822520
	|-ObjectComparer<Nullable<Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2822710 Offset: 0x2822811 VA: 0x2822710
	|-ObjectComparer<Nullable<Bounds>>.GetHashCode
	|
	|-RVA: 0x2822900 Offset: 0x2822A01 VA: 0x2822900
	|-ObjectComparer<Nullable<BoundsInt>>.GetHashCode
	|
	|-RVA: 0x2822AC0 Offset: 0x2822BC1 VA: 0x2822AC0
	|-ObjectComparer<Nullable<Color32>>.GetHashCode
	|
	|-RVA: 0x2822CA0 Offset: 0x2822DA1 VA: 0x2822CA0
	|-ObjectComparer<Nullable<Color>>.GetHashCode
	|
	|-RVA: 0x2822E80 Offset: 0x2822F81 VA: 0x2822E80
	|-ObjectComparer<Nullable<GradientAlphaKey>>.GetHashCode
	|
	|-RVA: 0x2823060 Offset: 0x2823161 VA: 0x2823060
	|-ObjectComparer<Nullable<GradientColorKey>>.GetHashCode
	|
	|-RVA: 0x2823240 Offset: 0x2823341 VA: 0x2823240
	|-ObjectComparer<Nullable<Keyframe>>.GetHashCode
	|
	|-RVA: 0x2823400 Offset: 0x2823501 VA: 0x2823400
	|-ObjectComparer<Nullable<LayerMask>>.GetHashCode
	|
	|-RVA: 0x2823620 Offset: 0x2823721 VA: 0x2823620
	|-ObjectComparer<Nullable<Matrix4x4>>.GetHashCode
	|
	|-RVA: 0x2823800 Offset: 0x2823901 VA: 0x2823800
	|-ObjectComparer<Nullable<Quaternion>>.GetHashCode
	|
	|-RVA: 0x28239E0 Offset: 0x2823AE1 VA: 0x28239E0
	|-ObjectComparer<Nullable<RangeInt>>.GetHashCode
	|
	|-RVA: 0x2823BC0 Offset: 0x2823CC1 VA: 0x2823BC0
	|-ObjectComparer<Nullable<Rect>>.GetHashCode
	|
	|-RVA: 0x2823DA0 Offset: 0x2823EA1 VA: 0x2823DA0
	|-ObjectComparer<Nullable<RectInt>>.GetHashCode
	|
	|-RVA: 0x2823F80 Offset: 0x2824081 VA: 0x2823F80
	|-ObjectComparer<Nullable<Vector2>>.GetHashCode
	|
	|-RVA: 0x2824160 Offset: 0x2824261 VA: 0x2824160
	|-ObjectComparer<Nullable<Vector2Int>>.GetHashCode
	|
	|-RVA: 0x2824330 Offset: 0x2824431 VA: 0x2824330
	|-ObjectComparer<Nullable<Vector3>>.GetHashCode
	|
	|-RVA: 0x2824500 Offset: 0x2824601 VA: 0x2824500
	|-ObjectComparer<Nullable<Vector3Int>>.GetHashCode
	|
	|-RVA: 0x28246E0 Offset: 0x28247E1 VA: 0x28246E0
	|-ObjectComparer<Nullable<Vector4>>.GetHashCode
	|
	|-RVA: 0x2824830 Offset: 0x2824931 VA: 0x2824830
	|-ObjectComparer<object>.GetHashCode
	|
	|-RVA: 0x28249F0 Offset: 0x2824AF1 VA: 0x28249F0
	|-ObjectComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x2824BB0 Offset: 0x2824CB1 VA: 0x2824BB0
	|-ObjectComparer<float>.GetHashCode
	|
	|-RVA: 0x2824D70 Offset: 0x2824E71 VA: 0x2824D70
	|-ObjectComparer<ushort>.GetHashCode
	|
	|-RVA: 0x2824F30 Offset: 0x2825031 VA: 0x2824F30
	|-ObjectComparer<uint>.GetHashCode
	|
	|-RVA: 0x28250F0 Offset: 0x28251F1 VA: 0x28250F0
	|-ObjectComparer<ulong>.GetHashCode
	|
	|-RVA: 0x28252B0 Offset: 0x28253B1 VA: 0x28252B0
	|-ObjectComparer<ValueTuple<bool, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2825470 Offset: 0x2825571 VA: 0x2825470
	|-ObjectComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x2825640 Offset: 0x2825741 VA: 0x2825640
	|-ObjectComparer<ValueTuple<Int32Enum, object>>.GetHashCode
	|
	|-RVA: 0x2825810 Offset: 0x2825911 VA: 0x2825810
	|-ObjectComparer<ValueTuple<object, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x28259E0 Offset: 0x2825AE1 VA: 0x28259E0
	|-ObjectComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x2825BB0 Offset: 0x2825CB1 VA: 0x2825BB0
	|-ObjectComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x2825D90 Offset: 0x2825E91 VA: 0x2825D90
	|-ObjectComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.GetHashCode
	|
	|-RVA: 0x2825F70 Offset: 0x2826071 VA: 0x2825F70
	|-ObjectComparer<ValueTuple<object, object, Vector3>>.GetHashCode
	|
	|-RVA: 0x2826150 Offset: 0x2826251 VA: 0x2826150
	|-ObjectComparer<ValueTuple<object, object, Vector3, float>>.GetHashCode
	|
	|-RVA: 0x2826350 Offset: 0x2826451 VA: 0x2826350
	|-ObjectComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>.GetHashCode
	|
	|-RVA: 0x2826550 Offset: 0x2826651 VA: 0x2826550
	|-ObjectComparer<TexturePacker_JsonArray.Frame>.GetHashCode
	|
	|-RVA: 0x2826730 Offset: 0x2826831 VA: 0x2826730
	|-ObjectComparer<TutorialUnlockFlagData>.GetHashCode
	|
	|-RVA: 0x2826900 Offset: 0x2826A01 VA: 0x2826900
	|-ObjectComparer<UIMainManagerAttachObject.AttachSet>.GetHashCode
	|
	|-RVA: 0x2826B00 Offset: 0x2826C01 VA: 0x2826B00
	|-ObjectComparer<CapEdge>.GetHashCode
	|
	|-RVA: 0x2826CC0 Offset: 0x2826DC1 VA: 0x2826CC0
	|-ObjectComparer<MeshDataConnectivity.Face>.GetHashCode
	|
	|-RVA: 0x2826EA0 Offset: 0x2826FA1 VA: 0x2826EA0
	|-ObjectComparer<MeshFaceConnectivity.EdgeData.SideData>.GetHashCode
	|
	|-RVA: 0x2827090 Offset: 0x2827191 VA: 0x2827090
	|-ObjectComparer<MeshFaceConnectivity.EdgeData>.GetHashCode
	|
	|-RVA: 0x2827260 Offset: 0x2827361 VA: 0x2827260
	|-ObjectComparer<NavMeshBuildMarkup>.GetHashCode
	|
	|-RVA: 0x2827490 Offset: 0x2827591 VA: 0x2827490
	|-ObjectComparer<NavMeshBuildSource>.GetHashCode
	|
	|-RVA: 0x2827660 Offset: 0x2827761 VA: 0x2827660
	|-ObjectComparer<ConstraintSource>.GetHashCode
	|
	|-RVA: 0x2827820 Offset: 0x2827921 VA: 0x2827820
	|-ObjectComparer<AnimatorClipInfo>.GetHashCode
	|
	|-RVA: 0x28279F0 Offset: 0x2827AF1 VA: 0x28279F0
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.GetHashCode
	|
	|-RVA: 0x2827BD0 Offset: 0x2827CD1 VA: 0x2827BD0
	|-ObjectComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x2827DB0 Offset: 0x2827EB1 VA: 0x2827DB0
	|-ObjectComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x2827F90 Offset: 0x2828091 VA: 0x2827F90
	|-ObjectComparer<BoundsInt>.GetHashCode
	|
	|-RVA: 0x2828150 Offset: 0x2828251 VA: 0x2828150
	|-ObjectComparer<Color32>.GetHashCode
	|
	|-RVA: 0x2828350 Offset: 0x2828451 VA: 0x2828350
	|-ObjectComparer<Color>.GetHashCode
	|
	|-RVA: 0x2828580 Offset: 0x2828681 VA: 0x2828580
	|-ObjectComparer<CombineInstance>.GetHashCode
	|
	|-RVA: 0x2828790 Offset: 0x2828891 VA: 0x2828790
	|-ObjectComparer<RaycastResult>.GetHashCode
	|
	|-RVA: 0x2828970 Offset: 0x2828A71 VA: 0x2828970
	|-ObjectComparer<GradientAlphaKey>.GetHashCode
	|
	|-RVA: 0x2828B50 Offset: 0x2828C51 VA: 0x2828B50
	|-ObjectComparer<GradientColorKey>.GetHashCode
	|
	|-RVA: 0x2828D40 Offset: 0x2828E41 VA: 0x2828D40
	|-ObjectComparer<Keyframe>.GetHashCode
	|
	|-RVA: 0x2828F00 Offset: 0x2829001 VA: 0x2828F00
	|-ObjectComparer<LayerMask>.GetHashCode
	|
	|-RVA: 0x2829100 Offset: 0x2829201 VA: 0x2829100
	|-ObjectComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x28292E0 Offset: 0x28293E1 VA: 0x28292E0
	|-ObjectComparer<ParticleSystem.Particle>.GetHashCode
	|
	|-RVA: 0x28294B0 Offset: 0x28295B1 VA: 0x28294B0
	|-ObjectComparer<Playable>.GetHashCode
	|
	|-RVA: 0x2829690 Offset: 0x2829791 VA: 0x2829690
	|-ObjectComparer<PlayableBinding>.GetHashCode
	|
	|-RVA: 0x2829860 Offset: 0x2829961 VA: 0x2829860
	|-ObjectComparer<PlayableGraph>.GetHashCode
	|
	|-RVA: 0x2829A20 Offset: 0x2829B21 VA: 0x2829A20
	|-ObjectComparer<Edge>.GetHashCode
	|
	|-RVA: 0x2829C20 Offset: 0x2829D21 VA: 0x2829C20
	|-ObjectComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x2829DE0 Offset: 0x2829EE1 VA: 0x2829DE0
	|-ObjectComparer<RangeInt>.GetHashCode
	|
	|-RVA: 0x2829FE0 Offset: 0x282A0E1 VA: 0x2829FE0
	|-ObjectComparer<RaycastHit2D>.GetHashCode
	|
	|-RVA: 0x282A1E0 Offset: 0x282A2E1 VA: 0x282A1E0
	|-ObjectComparer<RaycastHit>.GetHashCode
	|
	|-RVA: 0x282A3E0 Offset: 0x282A4E1 VA: 0x282A3E0
	|-ObjectComparer<Rect>.GetHashCode
	|
	|-RVA: 0x282A5B0 Offset: 0x282A6B1 VA: 0x282A5B0
	|-ObjectComparer<RectInt>.GetHashCode
	|
	|-RVA: 0x282A780 Offset: 0x282A881 VA: 0x282A780
	|-ObjectComparer<ReflectionProbeBlendInfo>.GetHashCode
	|
	|-RVA: 0x282A9C0 Offset: 0x282AAC1 VA: 0x282A9C0
	|-ObjectComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x282AB90 Offset: 0x282AC91 VA: 0x282AB90
	|-ObjectComparer<VertexAttributeDescriptor>.GetHashCode
	|
	|-RVA: 0x282AD70 Offset: 0x282AE71 VA: 0x282AD70
	|-ObjectComparer<AsyncOperationHandle>.GetHashCode
	|
	|-RVA: 0x282AF50 Offset: 0x282B051 VA: 0x282AF50
	|-ObjectComparer<AsyncOperationHandle<SceneInstance>>.GetHashCode
	|
	|-RVA: 0x282B140 Offset: 0x282B241 VA: 0x282B140
	|-ObjectComparer<DiagnosticEvent>.GetHashCode
	|
	|-RVA: 0x282B320 Offset: 0x282B421 VA: 0x282B320
	|-ObjectComparer<DelayedActionManager.DelegateInfo>.GetHashCode
	|
	|-RVA: 0x282B510 Offset: 0x282B611 VA: 0x282B510
	|-ObjectComparer<ObjectInitializationData>.GetHashCode
	|
	|-RVA: 0x282B6E0 Offset: 0x282B7E1 VA: 0x282B6E0
	|-ObjectComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x282B8D0 Offset: 0x282B9D1 VA: 0x282B8D0
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>.GetHashCode
	|
	|-RVA: 0x282BAB0 Offset: 0x282BBB1 VA: 0x282BAB0
	|-ObjectComparer<IntervalTreeNode>.GetHashCode
	|
	|-RVA: 0x282BC90 Offset: 0x282BD91 VA: 0x282BC90
	|-ObjectComparer<IntervalTree.Entry<object>>.GetHashCode
	|
	|-RVA: 0x282BE70 Offset: 0x282BF71 VA: 0x282BE70
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>.GetHashCode
	|
	|-RVA: 0x282C060 Offset: 0x282C161 VA: 0x282C060
	|-ObjectComparer<UICharInfo>.GetHashCode
	|
	|-RVA: 0x282C230 Offset: 0x282C331 VA: 0x282C230
	|-ObjectComparer<FocusController.FocusedElement>.GetHashCode
	|
	|-RVA: 0x282C400 Offset: 0x282C501 VA: 0x282C400
	|-ObjectComparer<UILineInfo>.GetHashCode
	|
	|-RVA: 0x282C620 Offset: 0x282C721 VA: 0x282C620
	|-ObjectComparer<UIVertex>.GetHashCode
	|
	|-RVA: 0x282C800 Offset: 0x282C901 VA: 0x282C800
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.GetHashCode
	|
	|-RVA: 0x282C9E0 Offset: 0x282CAE1 VA: 0x282C9E0
	|-ObjectComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x282CBA0 Offset: 0x282CCA1 VA: 0x282CBA0
	|-ObjectComparer<Vector2Int>.GetHashCode
	|
	|-RVA: 0x282CD90 Offset: 0x282CE91 VA: 0x282CD90
	|-ObjectComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x282CF70 Offset: 0x282D071 VA: 0x282CF70
	|-ObjectComparer<Vector3Int>.GetHashCode
	|
	|-RVA: 0x282D170 Offset: 0x282D271 VA: 0x282D170
	|-ObjectComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x282D3B0 Offset: 0x282D4B1 VA: 0x282D3B0
	|-ObjectComparer<WarpPoints.WarpPoint>.GetHashCode
	|
	|-RVA: 0x282D570 Offset: 0x282D671 VA: 0x282D570
	|-ObjectComparer<YieldItemParam>.GetHashCode
	|
	|-RVA: 0x282D750 Offset: 0x282D851 VA: 0x282D750
	|-ObjectComparer<stCommand_t>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CFA0D0 Offset: 0x2CFA1D1 VA: 0x2CFA0D0
	|-ObjectComparer<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x2CFA310 Offset: 0x2CFA411 VA: 0x2CFA310
	|-ObjectComparer<BuildItemData>..ctor
	|
	|-RVA: 0x2CFA4E0 Offset: 0x2CFA5E1 VA: 0x2CFA4E0
	|-ObjectComparer<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x2CFA6B0 Offset: 0x2CFA7B1 VA: 0x2CFA6B0
	|-ObjectComparer<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x2CFA890 Offset: 0x2CFA991 VA: 0x2CFA890
	|-ObjectComparer<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x2CFAA60 Offset: 0x2CFAB61 VA: 0x2CFAA60
	|-ObjectComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x2CFAC20 Offset: 0x2CFAD21 VA: 0x2CFAC20
	|-ObjectComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x2CFADE0 Offset: 0x2CFAEE1 VA: 0x2CFADE0
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x2CFAFD0 Offset: 0x2CFB0D1 VA: 0x2CFAFD0
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x2CFB1D0 Offset: 0x2CFB2D1 VA: 0x2CFB1D0
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x2CFB3B0 Offset: 0x2CFB4B1 VA: 0x2CFB3B0
	|-ObjectComparer<CropDataTable>..ctor
	|
	|-RVA: 0x2CFB570 Offset: 0x2CFB671 VA: 0x2CFB570
	|-ObjectComparer<DropItemParam>..ctor
	|
	|-RVA: 0x2CFB750 Offset: 0x2CFB851 VA: 0x2CFB750
	|-ObjectComparer<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x2CFB930 Offset: 0x2CFBA31 VA: 0x2CFB930
	|-ObjectComparer<EventCheckId>..ctor
	|
	|-RVA: 0x2CFBB00 Offset: 0x2CFBC01 VA: 0x2CFBB00
	|-ObjectComparer<EventFlagProgressData>..ctor
	|
	|-RVA: 0x2CFBCD0 Offset: 0x2CFBDD1 VA: 0x2CFBCD0
	|-ObjectComparer<FesNpcScoreData>..ctor
	|
	|-RVA: 0x2CFBEC0 Offset: 0x2CFBFC1 VA: 0x2CFBEC0
	|-ObjectComparer<HitResult>..ctor
	|
	|-RVA: 0x2CFC0C0 Offset: 0x2CFC1C1 VA: 0x2CFC0C0
	|-ObjectComparer<MiningPointSaveData>..ctor
	|
	|-RVA: 0x2CFC2B0 Offset: 0x2CFC3B1 VA: 0x2CFC2B0
	|-ObjectComparer<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x2CFC480 Offset: 0x2CFC581 VA: 0x2CFC480
	|-ObjectComparer<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x2CFC680 Offset: 0x2CFC781 VA: 0x2CFC680
	|-ObjectComparer<NPCActionData>..ctor
	|
	|-RVA: 0x2CFC860 Offset: 0x2CFC961 VA: 0x2CFC860
	|-ObjectComparer<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x2CFCA40 Offset: 0x2CFCB41 VA: 0x2CFCA40
	|-ObjectComparer<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x2CFCC20 Offset: 0x2CFCD21 VA: 0x2CFCC20
	|-ObjectComparer<OrderSaveParameter>..ctor
	|
	|-RVA: 0x2CFCDF0 Offset: 0x2CFCEF1 VA: 0x2CFCDF0
	|-ObjectComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x2CFCFD0 Offset: 0x2CFD0D1 VA: 0x2CFCFD0
	|-ObjectComparer<Parameter>..ctor
	|
	|-RVA: 0x2CFD1A0 Offset: 0x2CFD2A1 VA: 0x2CFD1A0
	|-ObjectComparer<ShopCatalogPage>..ctor
	|
	|-RVA: 0x2CFD390 Offset: 0x2CFD491 VA: 0x2CFD390
	|-ObjectComparer<ShopNpcTalk>..ctor
	|
	|-RVA: 0x2CFD570 Offset: 0x2CFD671 VA: 0x2CFD570
	|-ObjectComparer<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x2CFD730 Offset: 0x2CFD831 VA: 0x2CFD730
	|-ObjectComparer<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x2CFD910 Offset: 0x2CFDA11 VA: 0x2CFD910
	|-ObjectComparer<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x2CFDAF0 Offset: 0x2CFDBF1 VA: 0x2CFDAF0
	|-ObjectComparer<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x2CFDCD0 Offset: 0x2CFDDD1 VA: 0x2CFDCD0
	|-ObjectComparer<Schedule>..ctor
	|
	|-RVA: 0x2CFDEE0 Offset: 0x2CFDFE1 VA: 0x2CFDEE0
	|-ObjectComparer<CurveSample>..ctor
	|
	|-RVA: 0x2CFE0A0 Offset: 0x2CFE1A1 VA: 0x2CFE0A0
	|-ObjectComparer<bool>..ctor
	|
	|-RVA: 0x2CFE260 Offset: 0x2CFE361 VA: 0x2CFE260
	|-ObjectComparer<byte>..ctor
	|
	|-RVA: 0x2CFE420 Offset: 0x2CFE521 VA: 0x2CFE420
	|-ObjectComparer<char>..ctor
	|
	|-RVA: 0x2CFE5F0 Offset: 0x2CFE6F1 VA: 0x2CFE5F0
	|-ObjectComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x2CFE7C0 Offset: 0x2CFE8C1 VA: 0x2CFE7C0
	|-ObjectComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2CFE990 Offset: 0x2CFEA91 VA: 0x2CFE990
	|-ObjectComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2CFEB50 Offset: 0x2CFEC51 VA: 0x2CFEB50
	|-ObjectComparer<DateTime>..ctor
	|
	|-RVA: 0x2CFED20 Offset: 0x2CFEE21 VA: 0x2CFED20
	|-ObjectComparer<double>..ctor
	|
	|-RVA: 0x2CFEEF0 Offset: 0x2CFEFF1 VA: 0x2CFEEF0
	|-ObjectComparer<Guid>..ctor
	|
	|-RVA: 0x2821C90 Offset: 0x2821D91 VA: 0x2821C90
	|-ObjectComparer<short>..ctor
	|
	|-RVA: 0x2821E50 Offset: 0x2821F51 VA: 0x2821E50
	|-ObjectComparer<int>..ctor
	|
	|-RVA: 0x2822010 Offset: 0x2822111 VA: 0x2822010
	|-ObjectComparer<Int32Enum>..ctor
	|
	|-RVA: 0x28221D0 Offset: 0x28222D1 VA: 0x28221D0
	|-ObjectComparer<long>..ctor
	|
	|-RVA: 0x28223A0 Offset: 0x28224A1 VA: 0x28223A0
	|-ObjectComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2822560 Offset: 0x2822661 VA: 0x2822560
	|-ObjectComparer<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x2822750 Offset: 0x2822851 VA: 0x2822750
	|-ObjectComparer<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x2822940 Offset: 0x2822A41 VA: 0x2822940
	|-ObjectComparer<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2822B00 Offset: 0x2822C01 VA: 0x2822B00
	|-ObjectComparer<Nullable<Color32>>..ctor
	|
	|-RVA: 0x2822CE0 Offset: 0x2822DE1 VA: 0x2822CE0
	|-ObjectComparer<Nullable<Color>>..ctor
	|
	|-RVA: 0x2822EC0 Offset: 0x2822FC1 VA: 0x2822EC0
	|-ObjectComparer<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x28230A0 Offset: 0x28231A1 VA: 0x28230A0
	|-ObjectComparer<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2823280 Offset: 0x2823381 VA: 0x2823280
	|-ObjectComparer<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2823440 Offset: 0x2823541 VA: 0x2823440
	|-ObjectComparer<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2823660 Offset: 0x2823761 VA: 0x2823660
	|-ObjectComparer<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x2823840 Offset: 0x2823941 VA: 0x2823840
	|-ObjectComparer<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2823A20 Offset: 0x2823B21 VA: 0x2823A20
	|-ObjectComparer<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x2823C00 Offset: 0x2823D01 VA: 0x2823C00
	|-ObjectComparer<Nullable<Rect>>..ctor
	|
	|-RVA: 0x2823DE0 Offset: 0x2823EE1 VA: 0x2823DE0
	|-ObjectComparer<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2823FC0 Offset: 0x28240C1 VA: 0x2823FC0
	|-ObjectComparer<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x28241A0 Offset: 0x28242A1 VA: 0x28241A0
	|-ObjectComparer<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2824370 Offset: 0x2824471 VA: 0x2824370
	|-ObjectComparer<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2824540 Offset: 0x2824641 VA: 0x2824540
	|-ObjectComparer<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2824720 Offset: 0x2824821 VA: 0x2824720
	|-ObjectComparer<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2824870 Offset: 0x2824971 VA: 0x2824870
	|-ObjectComparer<object>..ctor
	|
	|-RVA: 0x2824A30 Offset: 0x2824B31 VA: 0x2824A30
	|-ObjectComparer<sbyte>..ctor
	|
	|-RVA: 0x2824BF0 Offset: 0x2824CF1 VA: 0x2824BF0
	|-ObjectComparer<float>..ctor
	|
	|-RVA: 0x2824DB0 Offset: 0x2824EB1 VA: 0x2824DB0
	|-ObjectComparer<ushort>..ctor
	|
	|-RVA: 0x2824F70 Offset: 0x2825071 VA: 0x2824F70
	|-ObjectComparer<uint>..ctor
	|
	|-RVA: 0x2825130 Offset: 0x2825231 VA: 0x2825130
	|-ObjectComparer<ulong>..ctor
	|
	|-RVA: 0x28252F0 Offset: 0x28253F1 VA: 0x28252F0
	|-ObjectComparer<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x28254B0 Offset: 0x28255B1 VA: 0x28254B0
	|-ObjectComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2825680 Offset: 0x2825781 VA: 0x2825680
	|-ObjectComparer<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2825850 Offset: 0x2825951 VA: 0x2825850
	|-ObjectComparer<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x2825A20 Offset: 0x2825B21 VA: 0x2825A20
	|-ObjectComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2825BF0 Offset: 0x2825CF1 VA: 0x2825BF0
	|-ObjectComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x2825DD0 Offset: 0x2825ED1 VA: 0x2825DD0
	|-ObjectComparer<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x2825FB0 Offset: 0x28260B1 VA: 0x2825FB0
	|-ObjectComparer<ValueTuple<object, object, Vector3>>..ctor
	|
	|-RVA: 0x2826190 Offset: 0x2826291 VA: 0x2826190
	|-ObjectComparer<ValueTuple<object, object, Vector3, float>>..ctor
	|
	|-RVA: 0x2826390 Offset: 0x2826491 VA: 0x2826390
	|-ObjectComparer<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x2826590 Offset: 0x2826691 VA: 0x2826590
	|-ObjectComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x2826770 Offset: 0x2826871 VA: 0x2826770
	|-ObjectComparer<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2826940 Offset: 0x2826A41 VA: 0x2826940
	|-ObjectComparer<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x2826B40 Offset: 0x2826C41 VA: 0x2826B40
	|-ObjectComparer<CapEdge>..ctor
	|
	|-RVA: 0x2826D00 Offset: 0x2826E01 VA: 0x2826D00
	|-ObjectComparer<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x2826EE0 Offset: 0x2826FE1 VA: 0x2826EE0
	|-ObjectComparer<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x28270D0 Offset: 0x28271D1 VA: 0x28270D0
	|-ObjectComparer<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x28272A0 Offset: 0x28273A1 VA: 0x28272A0
	|-ObjectComparer<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x28274D0 Offset: 0x28275D1 VA: 0x28274D0
	|-ObjectComparer<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x28276A0 Offset: 0x28277A1 VA: 0x28276A0
	|-ObjectComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x2827860 Offset: 0x2827961 VA: 0x2827860
	|-ObjectComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x2827A30 Offset: 0x2827B31 VA: 0x2827A30
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2827C10 Offset: 0x2827D11 VA: 0x2827C10
	|-ObjectComparer<BoneWeight>..ctor
	|
	|-RVA: 0x2827DF0 Offset: 0x2827EF1 VA: 0x2827DF0
	|-ObjectComparer<Bounds>..ctor
	|
	|-RVA: 0x2827FD0 Offset: 0x28280D1 VA: 0x2827FD0
	|-ObjectComparer<BoundsInt>..ctor
	|
	|-RVA: 0x2828190 Offset: 0x2828291 VA: 0x2828190
	|-ObjectComparer<Color32>..ctor
	|
	|-RVA: 0x2828390 Offset: 0x2828491 VA: 0x2828390
	|-ObjectComparer<Color>..ctor
	|
	|-RVA: 0x28285C0 Offset: 0x28286C1 VA: 0x28285C0
	|-ObjectComparer<CombineInstance>..ctor
	|
	|-RVA: 0x28287D0 Offset: 0x28288D1 VA: 0x28287D0
	|-ObjectComparer<RaycastResult>..ctor
	|
	|-RVA: 0x28289B0 Offset: 0x2828AB1 VA: 0x28289B0
	|-ObjectComparer<GradientAlphaKey>..ctor
	|
	|-RVA: 0x2828B90 Offset: 0x2828C91 VA: 0x2828B90
	|-ObjectComparer<GradientColorKey>..ctor
	|
	|-RVA: 0x2828D80 Offset: 0x2828E81 VA: 0x2828D80
	|-ObjectComparer<Keyframe>..ctor
	|
	|-RVA: 0x2828F40 Offset: 0x2829041 VA: 0x2828F40
	|-ObjectComparer<LayerMask>..ctor
	|
	|-RVA: 0x2829140 Offset: 0x2829241 VA: 0x2829140
	|-ObjectComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x2829320 Offset: 0x2829421 VA: 0x2829320
	|-ObjectComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x28294F0 Offset: 0x28295F1 VA: 0x28294F0
	|-ObjectComparer<Playable>..ctor
	|
	|-RVA: 0x28296D0 Offset: 0x28297D1 VA: 0x28296D0
	|-ObjectComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x28298A0 Offset: 0x28299A1 VA: 0x28298A0
	|-ObjectComparer<PlayableGraph>..ctor
	|
	|-RVA: 0x2829A60 Offset: 0x2829B61 VA: 0x2829A60
	|-ObjectComparer<Edge>..ctor
	|
	|-RVA: 0x2829C60 Offset: 0x2829D61 VA: 0x2829C60
	|-ObjectComparer<Quaternion>..ctor
	|
	|-RVA: 0x2829E20 Offset: 0x2829F21 VA: 0x2829E20
	|-ObjectComparer<RangeInt>..ctor
	|
	|-RVA: 0x282A020 Offset: 0x282A121 VA: 0x282A020
	|-ObjectComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x282A220 Offset: 0x282A321 VA: 0x282A220
	|-ObjectComparer<RaycastHit>..ctor
	|
	|-RVA: 0x282A420 Offset: 0x282A521 VA: 0x282A420
	|-ObjectComparer<Rect>..ctor
	|
	|-RVA: 0x282A5F0 Offset: 0x282A6F1 VA: 0x282A5F0
	|-ObjectComparer<RectInt>..ctor
	|
	|-RVA: 0x282A7C0 Offset: 0x282A8C1 VA: 0x282A7C0
	|-ObjectComparer<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x282AA00 Offset: 0x282AB01 VA: 0x282AA00
	|-ObjectComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x282ABD0 Offset: 0x282ACD1 VA: 0x282ABD0
	|-ObjectComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x282ADB0 Offset: 0x282AEB1 VA: 0x282ADB0
	|-ObjectComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x282AF90 Offset: 0x282B091 VA: 0x282AF90
	|-ObjectComparer<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x282B180 Offset: 0x282B281 VA: 0x282B180
	|-ObjectComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x282B360 Offset: 0x282B461 VA: 0x282B360
	|-ObjectComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x282B550 Offset: 0x282B651 VA: 0x282B550
	|-ObjectComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x282B720 Offset: 0x282B821 VA: 0x282B720
	|-ObjectComparer<GlyphRect>..ctor
	|
	|-RVA: 0x282B910 Offset: 0x282BA11 VA: 0x282B910
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x282BAF0 Offset: 0x282BBF1 VA: 0x282BAF0
	|-ObjectComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x282BCD0 Offset: 0x282BDD1 VA: 0x282BCD0
	|-ObjectComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x282BEB0 Offset: 0x282BFB1 VA: 0x282BEB0
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x282C0A0 Offset: 0x282C1A1 VA: 0x282C0A0
	|-ObjectComparer<UICharInfo>..ctor
	|
	|-RVA: 0x282C270 Offset: 0x282C371 VA: 0x282C270
	|-ObjectComparer<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x282C440 Offset: 0x282C541 VA: 0x282C440
	|-ObjectComparer<UILineInfo>..ctor
	|
	|-RVA: 0x282C660 Offset: 0x282C761 VA: 0x282C660
	|-ObjectComparer<UIVertex>..ctor
	|
	|-RVA: 0x282C840 Offset: 0x282C941 VA: 0x282C840
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x282CA20 Offset: 0x282CB21 VA: 0x282CA20
	|-ObjectComparer<Vector2>..ctor
	|
	|-RVA: 0x282CBE0 Offset: 0x282CCE1 VA: 0x282CBE0
	|-ObjectComparer<Vector2Int>..ctor
	|
	|-RVA: 0x282CDD0 Offset: 0x282CED1 VA: 0x282CDD0
	|-ObjectComparer<Vector3>..ctor
	|
	|-RVA: 0x282CFB0 Offset: 0x282D0B1 VA: 0x282CFB0
	|-ObjectComparer<Vector3Int>..ctor
	|
	|-RVA: 0x282D1B0 Offset: 0x282D2B1 VA: 0x282D1B0
	|-ObjectComparer<Vector4>..ctor
	|
	|-RVA: 0x282D3F0 Offset: 0x282D4F1 VA: 0x282D3F0
	|-ObjectComparer<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x282D5B0 Offset: 0x282D6B1 VA: 0x282D5B0
	|-ObjectComparer<YieldItemParam>..ctor
	|
	|-RVA: 0x282D790 Offset: 0x282D891 VA: 0x282D790
	|-ObjectComparer<stCommand_t>..ctor
	*/
}

