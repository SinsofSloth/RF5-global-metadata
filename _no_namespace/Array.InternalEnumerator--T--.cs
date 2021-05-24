internal struct Array.InternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 122
{
	// Fields
	private readonly Array array; // 0x0
	private int idx; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Array array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BB0 Offset: 0x315CB1 VA: 0x315BB0
	|-Array.InternalEnumerator<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x315C90 Offset: 0x315D91 VA: 0x315C90
	|-Array.InternalEnumerator<ActionCommandDataTable>..ctor
	|
	|-RVA: 0x315D70 Offset: 0x315E71 VA: 0x315D70
	|-Array.InternalEnumerator<AdvScriptDefCountParam>..ctor
	|
	|-RVA: 0x315E50 Offset: 0x315F51 VA: 0x315E50
	|-Array.InternalEnumerator<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x315F30 Offset: 0x316031 VA: 0x315F30
	|-Array.InternalEnumerator<BitVector32Int>..ctor
	|
	|-RVA: 0x3160A0 Offset: 0x3161A1 VA: 0x3160A0
	|-Array.InternalEnumerator<BuildItemData>..ctor
	|
	|-RVA: 0x316180 Offset: 0x316281 VA: 0x316180
	|-Array.InternalEnumerator<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x316260 Offset: 0x316361 VA: 0x316260
	|-Array.InternalEnumerator<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x316340 Offset: 0x316441 VA: 0x316340
	|-Array.InternalEnumerator<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x316430 Offset: 0x316531 VA: 0x316430
	|-Array.InternalEnumerator<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x316510 Offset: 0x316611 VA: 0x316510
	|-Array.InternalEnumerator<CinemachineBlendListCamera.Instruction>..ctor
	|
	|-RVA: 0x3165F0 Offset: 0x3166F1 VA: 0x3165F0
	|-Array.InternalEnumerator<CinemachineBlenderSettings.CustomBlend>..ctor
	|
	|-RVA: 0x3166D0 Offset: 0x3167D1 VA: 0x3166D0
	|-Array.InternalEnumerator<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x316830 Offset: 0x316931 VA: 0x316830
	|-Array.InternalEnumerator<CinemachineFreeLook.Orbit>..ctor
	|
	|-RVA: 0x316910 Offset: 0x316A11 VA: 0x316910
	|-Array.InternalEnumerator<CinemachinePath.Waypoint>..ctor
	|
	|-RVA: 0x3169F0 Offset: 0x316AF1 VA: 0x3169F0
	|-Array.InternalEnumerator<CinemachineSmoothPath.Waypoint>..ctor
	|
	|-RVA: 0x316AD0 Offset: 0x316BD1 VA: 0x316AD0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x316C30 Offset: 0x316D31 VA: 0x316C30
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.Instruction>..ctor
	|
	|-RVA: 0x316D10 Offset: 0x316E11 VA: 0x316D10
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.ParentHash>..ctor
	|
	|-RVA: 0x316E70 Offset: 0x316F71 VA: 0x316E70
	|-Array.InternalEnumerator<CinemachineTargetGroup.Target>..ctor
	|
	|-RVA: 0x316F50 Offset: 0x317051 VA: 0x316F50
	|-Array.InternalEnumerator<NoiseSettings.TransformNoiseParams>..ctor
	|
	|-RVA: 0x317030 Offset: 0x317131 VA: 0x317030
	|-Array.InternalEnumerator<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x317110 Offset: 0x317211 VA: 0x317110
	|-Array.InternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x3171F0 Offset: 0x3172F1 VA: 0x3171F0
	|-Array.InternalEnumerator<HeadingTracker.Item>..ctor
	|
	|-RVA: 0x3172D0 Offset: 0x3173D1 VA: 0x3172D0
	|-Array.InternalEnumerator<CropDataTable>..ctor
	|
	|-RVA: 0x3173B0 Offset: 0x3174B1 VA: 0x3173B0
	|-Array.InternalEnumerator<ControlPoint>..ctor
	|
	|-RVA: 0x317490 Offset: 0x317591 VA: 0x317490
	|-Array.InternalEnumerator<DamageTextInfo>..ctor
	|
	|-RVA: 0x317570 Offset: 0x317671 VA: 0x317570
	|-Array.InternalEnumerator<UIEMDefine.CategoryDataSet>..ctor
	|
	|-RVA: 0x317650 Offset: 0x317751 VA: 0x317650
	|-Array.InternalEnumerator<DropItemParam>..ctor
	|
	|-RVA: 0x3177B0 Offset: 0x3178B1 VA: 0x3177B0
	|-Array.InternalEnumerator<DropTableElement>..ctor
	|
	|-RVA: 0x317890 Offset: 0x317991 VA: 0x317890
	|-Array.InternalEnumerator<EffectDataTable>..ctor
	|
	|-RVA: 0x317970 Offset: 0x317A71 VA: 0x317970
	|-Array.InternalEnumerator<EnemyPatrolPoints>..ctor
	|
	|-RVA: 0x317AD0 Offset: 0x317BD1 VA: 0x317AD0
	|-Array.InternalEnumerator<Coord>..ctor
	|
	|-RVA: 0x317C30 Offset: 0x317D31 VA: 0x317C30
	|-Array.InternalEnumerator<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x317D10 Offset: 0x317E11 VA: 0x317D10
	|-Array.InternalEnumerator<EventCheckId>..ctor
	|
	|-RVA: 0x317DF0 Offset: 0x317EF1 VA: 0x317DF0
	|-Array.InternalEnumerator<EventFlagProgressData>..ctor
	|
	|-RVA: 0x317ED0 Offset: 0x317FD1 VA: 0x317ED0
	|-Array.InternalEnumerator<EyeMouthAnimate.EMAnimSet>..ctor
	|
	|-RVA: 0x318030 Offset: 0x318131 VA: 0x318030
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_PARAM>..ctor
	|
	|-RVA: 0x318110 Offset: 0x318211 VA: 0x318110
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x3181F0 Offset: 0x3182F1 VA: 0x3181F0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x3182D0 Offset: 0x3183D1 VA: 0x3182D0
	|-Array.InternalEnumerator<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x3183C0 Offset: 0x3184C1 VA: 0x3183C0
	|-Array.InternalEnumerator<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x3184A0 Offset: 0x3185A1 VA: 0x3184A0
	|-Array.InternalEnumerator<FesNpcScoreData>..ctor
	|
	|-RVA: 0x318580 Offset: 0x318681 VA: 0x318580
	|-Array.InternalEnumerator<FieldHideItemSpawnDataTable>..ctor
	|
	|-RVA: 0x318660 Offset: 0x318761 VA: 0x318660
	|-Array.InternalEnumerator<FieldItemSpawnDataTable>..ctor
	|
	|-RVA: 0x318740 Offset: 0x318841 VA: 0x318740
	|-Array.InternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>..ctor
	|
	|-RVA: 0x318820 Offset: 0x318921 VA: 0x318820
	|-Array.InternalEnumerator<FieldSceneData.Data>..ctor
	|
	|-RVA: 0x318900 Offset: 0x318A01 VA: 0x318900
	|-Array.InternalEnumerator<FieldTreasureBoxItemData>..ctor
	|
	|-RVA: 0x318A70 Offset: 0x318B71 VA: 0x318A70
	|-Array.InternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>..ctor
	|
	|-RVA: 0x318B50 Offset: 0x318C51 VA: 0x318B50
	|-Array.InternalEnumerator<FieldWoodBoxSpawnDataTable>..ctor
	|
	|-RVA: 0x318C30 Offset: 0x318D31 VA: 0x318C30
	|-Array.InternalEnumerator<FocusObjectDataTable>..ctor
	|
	|-RVA: 0x318D10 Offset: 0x318E11 VA: 0x318D10
	|-Array.InternalEnumerator<FurnitureData>..ctor
	|
	|-RVA: 0x318DF0 Offset: 0x318EF1 VA: 0x318DF0
	|-Array.InternalEnumerator<GateDataTable>..ctor
	|
	|-RVA: 0x318ED0 Offset: 0x318FD1 VA: 0x318ED0
	|-Array.InternalEnumerator<GateStatusDataTable>..ctor
	|
	|-RVA: 0x318FB0 Offset: 0x3190B1 VA: 0x318FB0
	|-Array.InternalEnumerator<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x319120 Offset: 0x319221 VA: 0x319120
	|-Array.InternalEnumerator<HitResult>..ctor
	|
	|-RVA: 0x319200 Offset: 0x319301 VA: 0x319200
	|-Array.InternalEnumerator<ImagePaneDatas.ImagePaneData>..ctor
	|
	|-RVA: 0x3192E0 Offset: 0x3193E1 VA: 0x3192E0
	|-Array.InternalEnumerator<FurnitureManager.SendPos>..ctor
	|
	|-RVA: 0x3193C0 Offset: 0x3194C1 VA: 0x3193C0
	|-Array.InternalEnumerator<ItemLevelData>..ctor
	|
	|-RVA: 0x319520 Offset: 0x319621 VA: 0x319520
	|-Array.InternalEnumerator<MapDatas.MapData>..ctor
	|
	|-RVA: 0x319600 Offset: 0x319701 VA: 0x319600
	|-Array.InternalEnumerator<MapObjectDatas.MapObjectData>..ctor
	|
	|-RVA: 0x3196E0 Offset: 0x3197E1 VA: 0x3196E0
	|-Array.InternalEnumerator<ByteArrayStringHashTable.Entry>..ctor
	|
	|-RVA: 0x3197C0 Offset: 0x3198C1 VA: 0x3197C0
	|-Array.InternalEnumerator<MineTypeDataTable>..ctor
	|
	|-RVA: 0x3198A0 Offset: 0x3199A1 VA: 0x3198A0
	|-Array.InternalEnumerator<MiningDataTable>..ctor
	|
	|-RVA: 0x319980 Offset: 0x319A81 VA: 0x319980
	|-Array.InternalEnumerator<MiningPointSaveData>..ctor
	|
	|-RVA: 0x319A60 Offset: 0x319B61 VA: 0x319A60
	|-Array.InternalEnumerator<CodePointIndexer.TableRange>..ctor
	|
	|-RVA: 0x319B40 Offset: 0x319C41 VA: 0x319B40
	|-Array.InternalEnumerator<MonsterBehaviorDataTable>..ctor
	|
	|-RVA: 0x319C20 Offset: 0x319D21 VA: 0x319C20
	|-Array.InternalEnumerator<MonsterDataTable>..ctor
	|
	|-RVA: 0x319D00 Offset: 0x319E01 VA: 0x319D00
	|-Array.InternalEnumerator<MonsterDropItemDataTable>..ctor
	|
	|-RVA: 0x319DE0 Offset: 0x319EE1 VA: 0x319DE0
	|-Array.InternalEnumerator<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x319EC0 Offset: 0x319FC1 VA: 0x319EC0
	|-Array.InternalEnumerator<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x319FA0 Offset: 0x31A0A1 VA: 0x319FA0
	|-Array.InternalEnumerator<MonsterUIData.Data>..ctor
	|
	|-RVA: 0x31A080 Offset: 0x31A181 VA: 0x31A080
	|-Array.InternalEnumerator<MonsterYieldItemDataTable>..ctor
	|
	|-RVA: 0x31A160 Offset: 0x31A261 VA: 0x31A160
	|-Array.InternalEnumerator<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x31A240 Offset: 0x31A341 VA: 0x31A240
	|-Array.InternalEnumerator<NPCActionData>..ctor
	|
	|-RVA: 0x31A320 Offset: 0x31A421 VA: 0x31A320
	|-Array.InternalEnumerator<NPCCallingNameTextData.Data>..ctor
	|
	|-RVA: 0x31A400 Offset: 0x31A501 VA: 0x31A400
	|-Array.InternalEnumerator<NPCUIData.Data>..ctor
	|
	|-RVA: 0x31A4E0 Offset: 0x31A5E1 VA: 0x31A4E0
	|-Array.InternalEnumerator<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x31A5C0 Offset: 0x31A6C1 VA: 0x31A5C0
	|-Array.InternalEnumerator<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31A6B0 Offset: 0x31A7B1 VA: 0x31A6B0
	|-Array.InternalEnumerator<OrderSaveData>..ctor
	|
	|-RVA: 0x31A790 Offset: 0x31A891 VA: 0x31A790
	|-Array.InternalEnumerator<OrderSaveParameter>..ctor
	|
	|-RVA: 0x31A870 Offset: 0x31A971 VA: 0x31A870
	|-Array.InternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x31A950 Offset: 0x31AA51 VA: 0x31A950
	|-Array.InternalEnumerator<Parameter>..ctor
	|
	|-RVA: 0x31AA30 Offset: 0x31AB31 VA: 0x31AA30
	|-Array.InternalEnumerator<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x31AB10 Offset: 0x31AC11 VA: 0x31AB10
	|-Array.InternalEnumerator<PlayerCallingNameTextData.Data>..ctor
	|
	|-RVA: 0x31ABF0 Offset: 0x31ACF1 VA: 0x31ABF0
	|-Array.InternalEnumerator<ShopCatalogPage>..ctor
	|
	|-RVA: 0x31ACD0 Offset: 0x31ADD1 VA: 0x31ACD0
	|-Array.InternalEnumerator<ShopNpcTalk>..ctor
	|
	|-RVA: 0x31ADB0 Offset: 0x31AEB1 VA: 0x31ADB0
	|-Array.InternalEnumerator<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x31AEA0 Offset: 0x31AFA1 VA: 0x31AEA0
	|-Array.InternalEnumerator<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x321990 Offset: 0x321A91 VA: 0x321990
	|-Array.InternalEnumerator<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x321A80 Offset: 0x321B81 VA: 0x321A80
	|-Array.InternalEnumerator<AnimationWarping.Warp>..ctor
	|
	|-RVA: 0x321B60 Offset: 0x321C61 VA: 0x321B60
	|-Array.InternalEnumerator<GrounderQuadruped.Foot>..ctor
	|
	|-RVA: 0x321C40 Offset: 0x321D41 VA: 0x321C40
	|-Array.InternalEnumerator<IKSolverLimb.AxisDirection>..ctor
	|
	|-RVA: 0x321D20 Offset: 0x321E21 VA: 0x321D20
	|-Array.InternalEnumerator<ProfilerFrame>..ctor
	|
	|-RVA: 0x321E00 Offset: 0x321F01 VA: 0x321E00
	|-Array.InternalEnumerator<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x321EE0 Offset: 0x321FE1 VA: 0x321EE0
	|-Array.InternalEnumerator<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x321FC0 Offset: 0x3220C1 VA: 0x321FC0
	|-Array.InternalEnumerator<ResponsiveEnable.Entry>..ctor
	|
	|-RVA: 0x3220A0 Offset: 0x3221A1 VA: 0x3220A0
	|-Array.InternalEnumerator<ResponsiveResize.Element.SizeDefinition>..ctor
	|
	|-RVA: 0x322180 Offset: 0x322281 VA: 0x322180
	|-Array.InternalEnumerator<ResponsiveResize.Element>..ctor
	|
	|-RVA: 0x322260 Offset: 0x322361 VA: 0x322260
	|-Array.InternalEnumerator<Schedule>..ctor
	|
	|-RVA: 0x322340 Offset: 0x322441 VA: 0x322340
	|-Array.InternalEnumerator<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x322420 Offset: 0x322521 VA: 0x322420
	|-Array.InternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x322510 Offset: 0x322611 VA: 0x322510
	|-Array.InternalEnumerator<SpeedData>..ctor
	|
	|-RVA: 0x322670 Offset: 0x322771 VA: 0x322670
	|-Array.InternalEnumerator<CurveSample>..ctor
	|
	|-RVA: 0x322750 Offset: 0x322851 VA: 0x322750
	|-Array.InternalEnumerator<StatusPageSetParameter.ElementParameterText>..ctor
	|
	|-RVA: 0x3228B0 Offset: 0x3229B1 VA: 0x3228B0
	|-Array.InternalEnumerator<StringFormatData.FormatData>..ctor
	|
	|-RVA: 0x322990 Offset: 0x322A91 VA: 0x322990
	|-Array.InternalEnumerator<ArraySegment<ProfilerFrame>>..ctor
	|
	|-RVA: 0x322A70 Offset: 0x322B71 VA: 0x322A70
	|-Array.InternalEnumerator<ArraySegment<byte>>..ctor
	|
	|-RVA: 0x322B50 Offset: 0x322C51 VA: 0x322B50
	|-Array.InternalEnumerator<ArraySegment<object>>..ctor
	|
	|-RVA: 0x322C30 Offset: 0x322D31 VA: 0x322C30
	|-Array.InternalEnumerator<bool>..ctor
	|
	|-RVA: 0x322D10 Offset: 0x322E11 VA: 0x322D10
	|-Array.InternalEnumerator<byte>..ctor
	|
	|-RVA: 0x322E70 Offset: 0x322F71 VA: 0x322E70
	|-Array.InternalEnumerator<ByteEnum>..ctor
	|
	|-RVA: 0x322FD0 Offset: 0x3230D1 VA: 0x322FD0
	|-Array.InternalEnumerator<char>..ctor
	|
	|-RVA: 0x323130 Offset: 0x323231 VA: 0x323130
	|-Array.InternalEnumerator<ConcurrentQueue.Segment.Slot<object>>..ctor
	|
	|-RVA: 0x323210 Offset: 0x323311 VA: 0x323210
	|-Array.InternalEnumerator<DictionaryEntry>..ctor
	|
	|-RVA: 0x3232F0 Offset: 0x3233F1 VA: 0x3232F0
	|-Array.InternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>..ctor
	|
	|-RVA: 0x3233D0 Offset: 0x3234D1 VA: 0x3233D0
	|-Array.InternalEnumerator<Dictionary.Entry<BitVector32Int, object>>..ctor
	|
	|-RVA: 0x3234B0 Offset: 0x3235B1 VA: 0x3234B0
	|-Array.InternalEnumerator<Dictionary.Entry<EventCheckId, object>>..ctor
	|
	|-RVA: 0x323590 Offset: 0x323691 VA: 0x323590
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>..ctor
	|
	|-RVA: 0x323670 Offset: 0x323771 VA: 0x323670
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>..ctor
	|
	|-RVA: 0x323750 Offset: 0x323851 VA: 0x323750
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>..ctor
	|
	|-RVA: 0x323830 Offset: 0x323931 VA: 0x323830
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>..ctor
	|
	|-RVA: 0x323910 Offset: 0x323A11 VA: 0x323910
	|-Array.InternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>..ctor
	|
	|-RVA: 0x3239F0 Offset: 0x323AF1 VA: 0x3239F0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>..ctor
	|
	|-RVA: 0x323AD0 Offset: 0x323BD1 VA: 0x323AD0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveData, object>>..ctor
	|
	|-RVA: 0x323BB0 Offset: 0x323CB1 VA: 0x323BB0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>..ctor
	|
	|-RVA: 0x323C90 Offset: 0x323D91 VA: 0x323C90
	|-Array.InternalEnumerator<Dictionary.Entry<Parameter, object>>..ctor
	|
	|-RVA: 0x323D70 Offset: 0x323E71 VA: 0x323D70
	|-Array.InternalEnumerator<Dictionary.Entry<bool, object>>..ctor
	|
	|-RVA: 0x323E50 Offset: 0x323F51 VA: 0x323E50
	|-Array.InternalEnumerator<Dictionary.Entry<byte, object>>..ctor
	|
	|-RVA: 0x323F30 Offset: 0x324031 VA: 0x323F30
	|-Array.InternalEnumerator<Dictionary.Entry<char, object>>..ctor
	|
	|-RVA: 0x324010 Offset: 0x324111 VA: 0x324010
	|-Array.InternalEnumerator<Dictionary.Entry<DateTime, object>>..ctor
	|
	|-RVA: 0x3240F0 Offset: 0x3241F1 VA: 0x3240F0
	|-Array.InternalEnumerator<Dictionary.Entry<double, object>>..ctor
	|
	|-RVA: 0x3241D0 Offset: 0x3242D1 VA: 0x3241D0
	|-Array.InternalEnumerator<Dictionary.Entry<Guid, object>>..ctor
	|
	|-RVA: 0x3242B0 Offset: 0x3243B1 VA: 0x3242B0
	|-Array.InternalEnumerator<Dictionary.Entry<short, object>>..ctor
	|
	|-RVA: 0x324390 Offset: 0x324491 VA: 0x324390
	|-Array.InternalEnumerator<Dictionary.Entry<int, CropDataTable>>..ctor
	|
	|-RVA: 0x324470 Offset: 0x324571 VA: 0x324470
	|-Array.InternalEnumerator<Dictionary.Entry<int, EffectDataTable>>..ctor
	|
	|-RVA: 0x324550 Offset: 0x324651 VA: 0x324550
	|-Array.InternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>..ctor
	|
	|-RVA: 0x324630 Offset: 0x324731 VA: 0x324630
	|-Array.InternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>..ctor
	|
	|-RVA: 0x324710 Offset: 0x324811 VA: 0x324710
	|-Array.InternalEnumerator<Dictionary.Entry<int, MiningDataTable>>..ctor
	|
	|-RVA: 0x3247F0 Offset: 0x3248F1 VA: 0x3247F0
	|-Array.InternalEnumerator<Dictionary.Entry<int, bool>>..ctor
	|
	|-RVA: 0x3248D0 Offset: 0x3249D1 VA: 0x3248D0
	|-Array.InternalEnumerator<Dictionary.Entry<int, char>>..ctor
	|
	|-RVA: 0x3249B0 Offset: 0x324AB1 VA: 0x3249B0
	|-Array.InternalEnumerator<Dictionary.Entry<int, int>>..ctor
	|
	|-RVA: 0x324A90 Offset: 0x324B91 VA: 0x324A90
	|-Array.InternalEnumerator<Dictionary.Entry<int, Int32Enum>>..ctor
	|
	|-RVA: 0x324B70 Offset: 0x324C71 VA: 0x324B70
	|-Array.InternalEnumerator<Dictionary.Entry<int, long>>..ctor
	|
	|-RVA: 0x324C50 Offset: 0x324D51 VA: 0x324C50
	|-Array.InternalEnumerator<Dictionary.Entry<int, object>>..ctor
	|
	|-RVA: 0x324D30 Offset: 0x324E31 VA: 0x324D30
	|-Array.InternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>..ctor
	|
	|-RVA: 0x324E10 Offset: 0x324F11 VA: 0x324E10
	|-Array.InternalEnumerator<Dictionary.Entry<int, SceneInstance>>..ctor
	|
	|-RVA: 0x324EF0 Offset: 0x324FF1 VA: 0x324EF0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector2Int>>..ctor
	|
	|-RVA: 0x324FD0 Offset: 0x3250D1 VA: 0x324FD0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector3>>..ctor
	|
	|-RVA: 0x3250B0 Offset: 0x3251B1 VA: 0x3250B0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>..ctor
	|
	|-RVA: 0x325190 Offset: 0x325291 VA: 0x325190
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>..ctor
	|
	|-RVA: 0x325270 Offset: 0x325371 VA: 0x325270
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>..ctor
	|
	|-RVA: 0x325350 Offset: 0x325451 VA: 0x325350
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, bool>>..ctor
	|
	|-RVA: 0x325430 Offset: 0x325531 VA: 0x325430
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>..ctor
	|
	|-RVA: 0x325510 Offset: 0x325611 VA: 0x325510
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3255F0 Offset: 0x3256F1 VA: 0x3255F0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x3256D0 Offset: 0x3257D1 VA: 0x3256D0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, object>>..ctor
	|
	|-RVA: 0x3257B0 Offset: 0x3258B1 VA: 0x3257B0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, float>>..ctor
	|
	|-RVA: 0x325890 Offset: 0x325991 VA: 0x325890
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x325970 Offset: 0x325A71 VA: 0x325970
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>..ctor
	|
	|-RVA: 0x325A50 Offset: 0x325B51 VA: 0x325A50
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>..ctor
	|
	|-RVA: 0x325B30 Offset: 0x325C31 VA: 0x325B30
	|-Array.InternalEnumerator<Dictionary.Entry<long, object>>..ctor
	|
	|-RVA: 0x325C10 Offset: 0x325D11 VA: 0x325C10
	|-Array.InternalEnumerator<Dictionary.Entry<Memory<object>, object>>..ctor
	|
	|-RVA: 0x325CF0 Offset: 0x325DF1 VA: 0x325CF0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>..ctor
	|
	|-RVA: 0x325DD0 Offset: 0x325ED1 VA: 0x325DD0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>..ctor
	|
	|-RVA: 0x325EB0 Offset: 0x325FB1 VA: 0x325EB0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>..ctor
	|
	|-RVA: 0x325F90 Offset: 0x326091 VA: 0x325F90
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>..ctor
	|
	|-RVA: 0x326070 Offset: 0x326171 VA: 0x326070
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>..ctor
	|
	|-RVA: 0x326150 Offset: 0x326251 VA: 0x326150
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>..ctor
	|
	|-RVA: 0x326230 Offset: 0x326331 VA: 0x326230
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>..ctor
	|
	|-RVA: 0x326310 Offset: 0x326411 VA: 0x326310
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>..ctor
	|
	|-RVA: 0x3263F0 Offset: 0x3264F1 VA: 0x3263F0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>..ctor
	|
	|-RVA: 0x3264D0 Offset: 0x3265D1 VA: 0x3264D0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>..ctor
	|
	|-RVA: 0x3265B0 Offset: 0x3266B1 VA: 0x3265B0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>..ctor
	|
	|-RVA: 0x326690 Offset: 0x326791 VA: 0x326690
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>..ctor
	|
	|-RVA: 0x326770 Offset: 0x326871 VA: 0x326770
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>..ctor
	|
	|-RVA: 0x326850 Offset: 0x326951 VA: 0x326850
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>..ctor
	|
	|-RVA: 0x326930 Offset: 0x326A31 VA: 0x326930
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>..ctor
	|
	|-RVA: 0x326A10 Offset: 0x326B11 VA: 0x326A10
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>..ctor
	|
	|-RVA: 0x326AF0 Offset: 0x326BF1 VA: 0x326AF0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>..ctor
	|
	|-RVA: 0x326BD0 Offset: 0x326CD1 VA: 0x326BD0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>..ctor
	|
	|-RVA: 0x326CB0 Offset: 0x326DB1 VA: 0x326CB0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>..ctor
	|
	|-RVA: 0x326D90 Offset: 0x326E91 VA: 0x326D90
	|-Array.InternalEnumerator<Dictionary.Entry<object, BitVector32Int>>..ctor
	|
	|-RVA: 0x326E70 Offset: 0x326F71 VA: 0x326E70
	|-Array.InternalEnumerator<Dictionary.Entry<object, EventCheckId>>..ctor
	|
	|-RVA: 0x326F50 Offset: 0x327051 VA: 0x326F50
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>..ctor
	|
	|-RVA: 0x327030 Offset: 0x327131 VA: 0x327030
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>..ctor
	|
	|-RVA: 0x327110 Offset: 0x327211 VA: 0x327110
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>..ctor
	|
	|-RVA: 0x3271F0 Offset: 0x3272F1 VA: 0x3271F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>..ctor
	|
	|-RVA: 0x3272D0 Offset: 0x3273D1 VA: 0x3272D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>..ctor
	|
	|-RVA: 0x3273B0 Offset: 0x3274B1 VA: 0x3273B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>..ctor
	|
	|-RVA: 0x327490 Offset: 0x327591 VA: 0x327490
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveData>>..ctor
	|
	|-RVA: 0x327570 Offset: 0x327671 VA: 0x327570
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>..ctor
	|
	|-RVA: 0x327650 Offset: 0x327751 VA: 0x327650
	|-Array.InternalEnumerator<Dictionary.Entry<object, Parameter>>..ctor
	|
	|-RVA: 0x327730 Offset: 0x327831 VA: 0x327730
	|-Array.InternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>..ctor
	|
	|-RVA: 0x327810 Offset: 0x327911 VA: 0x327810
	|-Array.InternalEnumerator<Dictionary.Entry<object, bool>>..ctor
	|
	|-RVA: 0x3496F0 Offset: 0x3497F1 VA: 0x3496F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, byte>>..ctor
	|
	|-RVA: 0x3497D0 Offset: 0x3498D1 VA: 0x3497D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, char>>..ctor
	|
	|-RVA: 0x3498B0 Offset: 0x3499B1 VA: 0x3498B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, DateTime>>..ctor
	|
	|-RVA: 0x349990 Offset: 0x349A91 VA: 0x349990
	|-Array.InternalEnumerator<Dictionary.Entry<object, double>>..ctor
	|
	|-RVA: 0x349A70 Offset: 0x349B71 VA: 0x349A70
	|-Array.InternalEnumerator<Dictionary.Entry<object, short>>..ctor
	|
	|-RVA: 0x349B50 Offset: 0x349C51 VA: 0x349B50
	|-Array.InternalEnumerator<Dictionary.Entry<object, int>>..ctor
	|
	|-RVA: 0x349C30 Offset: 0x349D31 VA: 0x349C30
	|-Array.InternalEnumerator<Dictionary.Entry<object, Int32Enum>>..ctor
	|
	|-RVA: 0x349D10 Offset: 0x349E11 VA: 0x349D10
	|-Array.InternalEnumerator<Dictionary.Entry<object, long>>..ctor
	|
	|-RVA: 0x349DF0 Offset: 0x349EF1 VA: 0x349DF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Memory<object>>>..ctor
	|
	|-RVA: 0x349ED0 Offset: 0x349FD1 VA: 0x349ED0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>..ctor
	|
	|-RVA: 0x349FB0 Offset: 0x34A0B1 VA: 0x349FB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>..ctor
	|
	|-RVA: 0x34A090 Offset: 0x34A191 VA: 0x34A090
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>..ctor
	|
	|-RVA: 0x34A170 Offset: 0x34A271 VA: 0x34A170
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>..ctor
	|
	|-RVA: 0x34A250 Offset: 0x34A351 VA: 0x34A250
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>..ctor
	|
	|-RVA: 0x34A330 Offset: 0x34A431 VA: 0x34A330
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>..ctor
	|
	|-RVA: 0x34A410 Offset: 0x34A511 VA: 0x34A410
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>..ctor
	|
	|-RVA: 0x34A4F0 Offset: 0x34A5F1 VA: 0x34A4F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>..ctor
	|
	|-RVA: 0x34A5D0 Offset: 0x34A6D1 VA: 0x34A5D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>..ctor
	|
	|-RVA: 0x34A6B0 Offset: 0x34A7B1 VA: 0x34A6B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>..ctor
	|
	|-RVA: 0x34A790 Offset: 0x34A891 VA: 0x34A790
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>..ctor
	|
	|-RVA: 0x34A870 Offset: 0x34A971 VA: 0x34A870
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>..ctor
	|
	|-RVA: 0x34A950 Offset: 0x34AA51 VA: 0x34A950
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>..ctor
	|
	|-RVA: 0x34AA30 Offset: 0x34AB31 VA: 0x34AA30
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>..ctor
	|
	|-RVA: 0x34AB10 Offset: 0x34AC11 VA: 0x34AB10
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>..ctor
	|
	|-RVA: 0x34ABF0 Offset: 0x34ACF1 VA: 0x34ABF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>..ctor
	|
	|-RVA: 0x34ACD0 Offset: 0x34ADD1 VA: 0x34ACD0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>..ctor
	|
	|-RVA: 0x34ADB0 Offset: 0x34AEB1 VA: 0x34ADB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>..ctor
	|
	|-RVA: 0x34AE90 Offset: 0x34AF91 VA: 0x34AE90
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>..ctor
	|
	|-RVA: 0x34AF70 Offset: 0x34B071 VA: 0x34AF70
	|-Array.InternalEnumerator<Dictionary.Entry<object, object>>..ctor
	|
	|-RVA: 0x34B050 Offset: 0x34B151 VA: 0x34B050
	|-Array.InternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>..ctor
	|
	|-RVA: 0x34B130 Offset: 0x34B231 VA: 0x34B130
	|-Array.InternalEnumerator<Dictionary.Entry<object, ResourceLocator>>..ctor
	|
	|-RVA: 0x34B210 Offset: 0x34B311 VA: 0x34B210
	|-Array.InternalEnumerator<Dictionary.Entry<object, sbyte>>..ctor
	|
	|-RVA: 0x34B2F0 Offset: 0x34B3F1 VA: 0x34B2F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, float>>..ctor
	|
	|-RVA: 0x34B3D0 Offset: 0x34B4D1 VA: 0x34B3D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, ushort>>..ctor
	|
	|-RVA: 0x34B4B0 Offset: 0x34B5B1 VA: 0x34B4B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, uint>>..ctor
	|
	|-RVA: 0x34B590 Offset: 0x34B691 VA: 0x34B590
	|-Array.InternalEnumerator<Dictionary.Entry<object, ulong>>..ctor
	|
	|-RVA: 0x34B670 Offset: 0x34B771 VA: 0x34B670
	|-Array.InternalEnumerator<Dictionary.Entry<object, TransitionTables>>..ctor
	|
	|-RVA: 0x34B750 Offset: 0x34B851 VA: 0x34B750
	|-Array.InternalEnumerator<Dictionary.Entry<object, Bounds>>..ctor
	|
	|-RVA: 0x34B830 Offset: 0x34B931 VA: 0x34B830
	|-Array.InternalEnumerator<Dictionary.Entry<object, BoundsInt>>..ctor
	|
	|-RVA: 0x34B910 Offset: 0x34BA11 VA: 0x34B910
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color32>>..ctor
	|
	|-RVA: 0x34B9F0 Offset: 0x34BAF1 VA: 0x34B9F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color>>..ctor
	|
	|-RVA: 0x34BAD0 Offset: 0x34BBD1 VA: 0x34BAD0
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>..ctor
	|
	|-RVA: 0x34BBB0 Offset: 0x34BCB1 VA: 0x34BBB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientColorKey>>..ctor
	|
	|-RVA: 0x34BC90 Offset: 0x34BD91 VA: 0x34BC90
	|-Array.InternalEnumerator<Dictionary.Entry<object, Keyframe>>..ctor
	|
	|-RVA: 0x34BD70 Offset: 0x34BE71 VA: 0x34BD70
	|-Array.InternalEnumerator<Dictionary.Entry<object, LayerMask>>..ctor
	|
	|-RVA: 0x34BE50 Offset: 0x34BF51 VA: 0x34BE50
	|-Array.InternalEnumerator<Dictionary.Entry<object, Matrix4x4>>..ctor
	|
	|-RVA: 0x34BF30 Offset: 0x34C031 VA: 0x34BF30
	|-Array.InternalEnumerator<Dictionary.Entry<object, Playable>>..ctor
	|
	|-RVA: 0x34C010 Offset: 0x34C111 VA: 0x34C010
	|-Array.InternalEnumerator<Dictionary.Entry<object, Quaternion>>..ctor
	|
	|-RVA: 0x34C0F0 Offset: 0x34C1F1 VA: 0x34C0F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RangeInt>>..ctor
	|
	|-RVA: 0x34C1D0 Offset: 0x34C2D1 VA: 0x34C1D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Rect>>..ctor
	|
	|-RVA: 0x34C2B0 Offset: 0x34C3B1 VA: 0x34C2B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RectInt>>..ctor
	|
	|-RVA: 0x34C390 Offset: 0x34C491 VA: 0x34C390
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x34C470 Offset: 0x34C571 VA: 0x34C470
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>..ctor
	|
	|-RVA: 0x34C550 Offset: 0x34C651 VA: 0x34C550
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2>>..ctor
	|
	|-RVA: 0x34C630 Offset: 0x34C731 VA: 0x34C630
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2Int>>..ctor
	|
	|-RVA: 0x34C710 Offset: 0x34C811 VA: 0x34C710
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3>>..ctor
	|
	|-RVA: 0x34C7F0 Offset: 0x34C8F1 VA: 0x34C7F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3Int>>..ctor
	|
	|-RVA: 0x34C8D0 Offset: 0x34C9D1 VA: 0x34C8D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector4>>..ctor
	|
	|-RVA: 0x34C9B0 Offset: 0x34CAB1 VA: 0x34C9B0
	|-Array.InternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>..ctor
	|
	|-RVA: 0x34CA90 Offset: 0x34CB91 VA: 0x34CA90
	|-Array.InternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>..ctor
	|
	|-RVA: 0x34CB70 Offset: 0x34CC71 VA: 0x34CB70
	|-Array.InternalEnumerator<Dictionary.Entry<sbyte, object>>..ctor
	|
	|-RVA: 0x34CC50 Offset: 0x34CD51 VA: 0x34CC50
	|-Array.InternalEnumerator<Dictionary.Entry<float, CurveSample>>..ctor
	|
	|-RVA: 0x34CD30 Offset: 0x34CE31 VA: 0x34CD30
	|-Array.InternalEnumerator<Dictionary.Entry<float, object>>..ctor
	|
	|-RVA: 0x34CE10 Offset: 0x34CF11 VA: 0x34CE10
	|-Array.InternalEnumerator<Dictionary.Entry<ushort, object>>..ctor
	|
	|-RVA: 0x34CEF0 Offset: 0x34CFF1 VA: 0x34CEF0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, int>>..ctor
	|
	|-RVA: 0x34CFD0 Offset: 0x34D0D1 VA: 0x34CFD0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, Int32Enum>>..ctor
	|
	|-RVA: 0x34D0B0 Offset: 0x34D1B1 VA: 0x34D0B0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, object>>..ctor
	|
	|-RVA: 0x34D190 Offset: 0x34D291 VA: 0x34D190
	|-Array.InternalEnumerator<Dictionary.Entry<ulong, object>>..ctor
	|
	|-RVA: 0x34D270 Offset: 0x34D371 VA: 0x34D270
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>..ctor
	|
	|-RVA: 0x34D350 Offset: 0x34D451 VA: 0x34D350
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>..ctor
	|
	|-RVA: 0x34D430 Offset: 0x34D531 VA: 0x34D430
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>..ctor
	|
	|-RVA: 0x34D510 Offset: 0x34D611 VA: 0x34D510
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>..ctor
	|
	|-RVA: 0x34D5F0 Offset: 0x34D6F1 VA: 0x34D5F0
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>..ctor
	|
	|-RVA: 0x34D6D0 Offset: 0x34D7D1 VA: 0x34D6D0
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>..ctor
	|
	|-RVA: 0x34D7B0 Offset: 0x34D8B1 VA: 0x34D7B0
	|-Array.InternalEnumerator<Dictionary.Entry<Bounds, object>>..ctor
	|
	|-RVA: 0x34D890 Offset: 0x34D991 VA: 0x34D890
	|-Array.InternalEnumerator<Dictionary.Entry<BoundsInt, object>>..ctor
	|
	|-RVA: 0x34D970 Offset: 0x34DA71 VA: 0x34D970
	|-Array.InternalEnumerator<Dictionary.Entry<Color, object>>..ctor
	|
	|-RVA: 0x34DA50 Offset: 0x34DB51 VA: 0x34DA50
	|-Array.InternalEnumerator<Dictionary.Entry<Color32, object>>..ctor
	|
	|-RVA: 0x34DB30 Offset: 0x34DC31 VA: 0x34DB30
	|-Array.InternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>..ctor
	|
	|-RVA: 0x34DC10 Offset: 0x34DD11 VA: 0x34DC10
	|-Array.InternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>..ctor
	|
	|-RVA: 0x34DCF0 Offset: 0x34DDF1 VA: 0x34DCF0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientColorKey, object>>..ctor
	|
	|-RVA: 0x34DDD0 Offset: 0x34DED1 VA: 0x34DDD0
	|-Array.InternalEnumerator<Dictionary.Entry<Keyframe, object>>..ctor
	|
	|-RVA: 0x34DEB0 Offset: 0x34DFB1 VA: 0x34DEB0
	|-Array.InternalEnumerator<Dictionary.Entry<LayerMask, object>>..ctor
	|
	|-RVA: 0x34DF90 Offset: 0x34E091 VA: 0x34DF90
	|-Array.InternalEnumerator<Dictionary.Entry<Matrix4x4, object>>..ctor
	|
	|-RVA: 0x34E070 Offset: 0x34E171 VA: 0x34E070
	|-Array.InternalEnumerator<Dictionary.Entry<IntVec3, object>>..ctor
	|
	|-RVA: 0x34E150 Offset: 0x34E251 VA: 0x34E150
	|-Array.InternalEnumerator<Dictionary.Entry<Quaternion, object>>..ctor
	|
	|-RVA: 0x34E230 Offset: 0x34E331 VA: 0x34E230
	|-Array.InternalEnumerator<Dictionary.Entry<RangeInt, object>>..ctor
	|
	|-RVA: 0x34E310 Offset: 0x34E411 VA: 0x34E310
	|-Array.InternalEnumerator<Dictionary.Entry<Rect, object>>..ctor
	|
	|-RVA: 0x34E3F0 Offset: 0x34E4F1 VA: 0x34E3F0
	|-Array.InternalEnumerator<Dictionary.Entry<RectInt, object>>..ctor
	|
	|-RVA: 0x34E4D0 Offset: 0x34E5D1 VA: 0x34E4D0
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>..ctor
	|
	|-RVA: 0x34E5B0 Offset: 0x34E6B1 VA: 0x34E5B0
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>..ctor
	|
	|-RVA: 0x34E690 Offset: 0x34E791 VA: 0x34E690
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2, object>>..ctor
	|
	|-RVA: 0x34E770 Offset: 0x34E871 VA: 0x34E770
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2Int, object>>..ctor
	|
	|-RVA: 0x34E850 Offset: 0x34E951 VA: 0x34E850
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3, object>>..ctor
	|
	|-RVA: 0x34E930 Offset: 0x34EA31 VA: 0x34E930
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3Int, object>>..ctor
	|
	|-RVA: 0x34EA10 Offset: 0x34EB11 VA: 0x34EA10
	|-Array.InternalEnumerator<Dictionary.Entry<Vector4, object>>..ctor
	|
	|-RVA: 0x34EAF0 Offset: 0x34EBF1 VA: 0x34EAF0
	|-Array.InternalEnumerator<HashSet.Slot<int>>..ctor
	|
	|-RVA: 0x34EBE0 Offset: 0x34ECE1 VA: 0x34EBE0
	|-Array.InternalEnumerator<HashSet.Slot<Int32Enum>>..ctor
	|
	|-RVA: 0x34ECD0 Offset: 0x34EDD1 VA: 0x34ECD0
	|-Array.InternalEnumerator<HashSet.Slot<object>>..ctor
	|
	|-RVA: 0x34EDB0 Offset: 0x34EEB1 VA: 0x34EDB0
	|-Array.InternalEnumerator<HashSet.Slot<uint>>..ctor
	|
	|-RVA: 0x34EEA0 Offset: 0x34EFA1 VA: 0x34EEA0
	|-Array.InternalEnumerator<HashSet.Slot<Edge>>..ctor
	|
	|-RVA: 0x34EF80 Offset: 0x34F081 VA: 0x34EF80
	|-Array.InternalEnumerator<HashSet.Slot<AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x34F060 Offset: 0x34F161 VA: 0x34F060
	|-Array.InternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>..ctor
	|
	|-RVA: 0x34F140 Offset: 0x34F241 VA: 0x34F140
	|-Array.InternalEnumerator<KeyValuePair<BitVector32Int, object>>..ctor
	|
	|-RVA: 0x34F220 Offset: 0x34F321 VA: 0x34F220
	|-Array.InternalEnumerator<KeyValuePair<EventCheckId, object>>..ctor
	|
	|-RVA: 0x34F300 Offset: 0x34F401 VA: 0x34F300
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>..ctor
	|
	|-RVA: 0x338D80 Offset: 0x338E81 VA: 0x338D80
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>..ctor
	|
	|-RVA: 0x338E60 Offset: 0x338F61 VA: 0x338E60
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>..ctor
	|
	|-RVA: 0x338F40 Offset: 0x339041 VA: 0x338F40
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>..ctor
	|
	|-RVA: 0x339020 Offset: 0x339121 VA: 0x339020
	|-Array.InternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>..ctor
	|
	|-RVA: 0x339100 Offset: 0x339201 VA: 0x339100
	|-Array.InternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>..ctor
	|
	|-RVA: 0x3391E0 Offset: 0x3392E1 VA: 0x3391E0
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveData, object>>..ctor
	|
	|-RVA: 0x3392C0 Offset: 0x3393C1 VA: 0x3392C0
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveParameter, object>>..ctor
	|
	|-RVA: 0x3393A0 Offset: 0x3394A1 VA: 0x3393A0
	|-Array.InternalEnumerator<KeyValuePair<Parameter, object>>..ctor
	|
	|-RVA: 0x339480 Offset: 0x339581 VA: 0x339480
	|-Array.InternalEnumerator<KeyValuePair<bool, object>>..ctor
	|
	|-RVA: 0x339560 Offset: 0x339661 VA: 0x339560
	|-Array.InternalEnumerator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x339640 Offset: 0x339741 VA: 0x339640
	|-Array.InternalEnumerator<KeyValuePair<char, object>>..ctor
	|
	|-RVA: 0x339720 Offset: 0x339821 VA: 0x339720
	|-Array.InternalEnumerator<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x339800 Offset: 0x339901 VA: 0x339800
	|-Array.InternalEnumerator<KeyValuePair<double, object>>..ctor
	|
	|-RVA: 0x3398E0 Offset: 0x3399E1 VA: 0x3398E0
	|-Array.InternalEnumerator<KeyValuePair<Guid, object>>..ctor
	|
	|-RVA: 0x3399C0 Offset: 0x339AC1 VA: 0x3399C0
	|-Array.InternalEnumerator<KeyValuePair<short, object>>..ctor
	|
	|-RVA: 0x339AA0 Offset: 0x339BA1 VA: 0x339AA0
	|-Array.InternalEnumerator<KeyValuePair<int, CropDataTable>>..ctor
	|
	|-RVA: 0x339B80 Offset: 0x339C81 VA: 0x339B80
	|-Array.InternalEnumerator<KeyValuePair<int, EffectDataTable>>..ctor
	|
	|-RVA: 0x339C60 Offset: 0x339D61 VA: 0x339C60
	|-Array.InternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>..ctor
	|
	|-RVA: 0x339DC0 Offset: 0x339EC1 VA: 0x339DC0
	|-Array.InternalEnumerator<KeyValuePair<int, MineTypeDataTable>>..ctor
	|
	|-RVA: 0x339EA0 Offset: 0x339FA1 VA: 0x339EA0
	|-Array.InternalEnumerator<KeyValuePair<int, MiningDataTable>>..ctor
	|
	|-RVA: 0x339F80 Offset: 0x33A081 VA: 0x339F80
	|-Array.InternalEnumerator<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x33A0E0 Offset: 0x33A1E1 VA: 0x33A0E0
	|-Array.InternalEnumerator<KeyValuePair<int, char>>..ctor
	|
	|-RVA: 0x33A240 Offset: 0x33A341 VA: 0x33A240
	|-Array.InternalEnumerator<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x33A3A0 Offset: 0x33A4A1 VA: 0x33A3A0
	|-Array.InternalEnumerator<KeyValuePair<int, Int32Enum>>..ctor
	|
	|-RVA: 0x33A500 Offset: 0x33A601 VA: 0x33A500
	|-Array.InternalEnumerator<KeyValuePair<int, long>>..ctor
	|
	|-RVA: 0x33A5E0 Offset: 0x33A6E1 VA: 0x33A5E0
	|-Array.InternalEnumerator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x33A6C0 Offset: 0x33A7C1 VA: 0x33A6C0
	|-Array.InternalEnumerator<KeyValuePair<int, DiagnosticEvent>>..ctor
	|
	|-RVA: 0x33A7A0 Offset: 0x33A8A1 VA: 0x33A7A0
	|-Array.InternalEnumerator<KeyValuePair<int, SceneInstance>>..ctor
	|
	|-RVA: 0x33A880 Offset: 0x33A981 VA: 0x33A880
	|-Array.InternalEnumerator<KeyValuePair<int, Vector2Int>>..ctor
	|
	|-RVA: 0x33A970 Offset: 0x33AA71 VA: 0x33A970
	|-Array.InternalEnumerator<KeyValuePair<int, Vector3>>..ctor
	|
	|-RVA: 0x33AA50 Offset: 0x33AB51 VA: 0x33AA50
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>..ctor
	|
	|-RVA: 0x33AB30 Offset: 0x33AC31 VA: 0x33AB30
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>..ctor
	|
	|-RVA: 0x33AC10 Offset: 0x33AD11 VA: 0x33AC10
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>..ctor
	|
	|-RVA: 0x33ACF0 Offset: 0x33ADF1 VA: 0x33ACF0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, bool>>..ctor
	|
	|-RVA: 0x33AE50 Offset: 0x33AF51 VA: 0x33AE50
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>..ctor
	|
	|-RVA: 0x33AF40 Offset: 0x33B041 VA: 0x33AF40
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x33B0A0 Offset: 0x33B1A1 VA: 0x33B0A0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x33B200 Offset: 0x33B301 VA: 0x33B200
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x33B2E0 Offset: 0x33B3E1 VA: 0x33B2E0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, float>>..ctor
	|
	|-RVA: 0x33B440 Offset: 0x33B541 VA: 0x33B440
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x33B520 Offset: 0x33B621 VA: 0x33B520
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>..ctor
	|
	|-RVA: 0x33B610 Offset: 0x33B711 VA: 0x33B610
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>..ctor
	|
	|-RVA: 0x33B6F0 Offset: 0x33B7F1 VA: 0x33B6F0
	|-Array.InternalEnumerator<KeyValuePair<long, object>>..ctor
	|
	|-RVA: 0x33B7D0 Offset: 0x33B8D1 VA: 0x33B7D0
	|-Array.InternalEnumerator<KeyValuePair<Memory<object>, object>>..ctor
	|
	|-RVA: 0x33B8B0 Offset: 0x33B9B1 VA: 0x33B8B0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>..ctor
	|
	|-RVA: 0x33B990 Offset: 0x33BA91 VA: 0x33B990
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>..ctor
	|
	|-RVA: 0x33BA70 Offset: 0x33BB71 VA: 0x33BA70
	|-Array.InternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>..ctor
	|
	|-RVA: 0x33BB50 Offset: 0x33BC51 VA: 0x33BB50
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color32>, object>>..ctor
	|
	|-RVA: 0x33BC30 Offset: 0x33BD31 VA: 0x33BC30
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color>, object>>..ctor
	|
	|-RVA: 0x33BD10 Offset: 0x33BE11 VA: 0x33BD10
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>..ctor
	|
	|-RVA: 0x33BDF0 Offset: 0x33BEF1 VA: 0x33BDF0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>..ctor
	|
	|-RVA: 0x33BED0 Offset: 0x33BFD1 VA: 0x33BED0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>..ctor
	|
	|-RVA: 0x33BFB0 Offset: 0x33C0B1 VA: 0x33BFB0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>..ctor
	|
	|-RVA: 0x33C090 Offset: 0x33C191 VA: 0x33C090
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>..ctor
	|
	|-RVA: 0x33C170 Offset: 0x33C271 VA: 0x33C170
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>..ctor
	|
	|-RVA: 0x33C250 Offset: 0x33C351 VA: 0x33C250
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>..ctor
	|
	|-RVA: 0x33C330 Offset: 0x33C431 VA: 0x33C330
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Rect>, object>>..ctor
	|
	|-RVA: 0x33C410 Offset: 0x33C511 VA: 0x33C410
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>..ctor
	|
	|-RVA: 0x33C4F0 Offset: 0x33C5F1 VA: 0x33C4F0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>..ctor
	|
	|-RVA: 0x33C5D0 Offset: 0x33C6D1 VA: 0x33C5D0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>..ctor
	|
	|-RVA: 0x33C6B0 Offset: 0x33C7B1 VA: 0x33C6B0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>..ctor
	|
	|-RVA: 0x33C790 Offset: 0x33C891 VA: 0x33C790
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>..ctor
	|
	|-RVA: 0x33C870 Offset: 0x33C971 VA: 0x33C870
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>..ctor
	|
	|-RVA: 0x33C950 Offset: 0x33CA51 VA: 0x33C950
	|-Array.InternalEnumerator<KeyValuePair<object, BitVector32Int>>..ctor
	|
	|-RVA: 0x33CA30 Offset: 0x33CB31 VA: 0x33CA30
	|-Array.InternalEnumerator<KeyValuePair<object, EventCheckId>>..ctor
	|
	|-RVA: 0x33CB10 Offset: 0x33CC11 VA: 0x33CB10
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>..ctor
	|
	|-RVA: 0x33CBF0 Offset: 0x33CCF1 VA: 0x33CBF0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>..ctor
	|
	|-RVA: 0x33CCD0 Offset: 0x33CDD1 VA: 0x33CCD0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>..ctor
	|
	|-RVA: 0x33CDB0 Offset: 0x33CEB1 VA: 0x33CDB0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>..ctor
	|
	|-RVA: 0x33CE90 Offset: 0x33CF91 VA: 0x33CE90
	|-Array.InternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>..ctor
	|
	|-RVA: 0x33CF70 Offset: 0x33D071 VA: 0x33CF70
	|-Array.InternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>..ctor
	|
	|-RVA: 0x33D050 Offset: 0x33D151 VA: 0x33D050
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveData>>..ctor
	|
	|-RVA: 0x33D130 Offset: 0x33D231 VA: 0x33D130
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveParameter>>..ctor
	|
	|-RVA: 0x33D210 Offset: 0x33D311 VA: 0x33D210
	|-Array.InternalEnumerator<KeyValuePair<object, Parameter>>..ctor
	|
	|-RVA: 0x33D2F0 Offset: 0x33D3F1 VA: 0x33D2F0
	|-Array.InternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>..ctor
	|
	|-RVA: 0x33D3D0 Offset: 0x33D4D1 VA: 0x33D3D0
	|-Array.InternalEnumerator<KeyValuePair<object, bool>>..ctor
	|
	|-RVA: 0x33D4B0 Offset: 0x33D5B1 VA: 0x33D4B0
	|-Array.InternalEnumerator<KeyValuePair<object, byte>>..ctor
	|
	|-RVA: 0x33D590 Offset: 0x33D691 VA: 0x33D590
	|-Array.InternalEnumerator<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x33D670 Offset: 0x33D771 VA: 0x33D670
	|-Array.InternalEnumerator<KeyValuePair<object, DateTime>>..ctor
	|
	|-RVA: 0x33D750 Offset: 0x33D851 VA: 0x33D750
	|-Array.InternalEnumerator<KeyValuePair<object, double>>..ctor
	|
	|-RVA: 0x33D830 Offset: 0x33D931 VA: 0x33D830
	|-Array.InternalEnumerator<KeyValuePair<object, short>>..ctor
	|
	|-RVA: 0x33D910 Offset: 0x33DA11 VA: 0x33D910
	|-Array.InternalEnumerator<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x33D9F0 Offset: 0x33DAF1 VA: 0x33D9F0
	|-Array.InternalEnumerator<KeyValuePair<object, Int32Enum>>..ctor
	|
	|-RVA: 0x33DAD0 Offset: 0x33DBD1 VA: 0x33DAD0
	|-Array.InternalEnumerator<KeyValuePair<object, long>>..ctor
	|
	|-RVA: 0x33DBB0 Offset: 0x33DCB1 VA: 0x33DBB0
	|-Array.InternalEnumerator<KeyValuePair<object, Memory<object>>>..ctor
	|
	|-RVA: 0x33DC90 Offset: 0x33DD91 VA: 0x33DC90
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>..ctor
	|
	|-RVA: 0x33DD70 Offset: 0x33DE71 VA: 0x33DD70
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>..ctor
	|
	|-RVA: 0x33DE50 Offset: 0x33DF51 VA: 0x33DE50
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>..ctor
	|
	|-RVA: 0x33DF30 Offset: 0x33E031 VA: 0x33DF30
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color32>>>..ctor
	|
	|-RVA: 0x33E010 Offset: 0x33E111 VA: 0x33E010
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color>>>..ctor
	|
	|-RVA: 0x33E0F0 Offset: 0x33E1F1 VA: 0x33E0F0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>..ctor
	|
	|-RVA: 0x33E1D0 Offset: 0x33E2D1 VA: 0x33E1D0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>..ctor
	|
	|-RVA: 0x33E2B0 Offset: 0x33E3B1 VA: 0x33E2B0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>..ctor
	|
	|-RVA: 0x33E390 Offset: 0x33E491 VA: 0x33E390
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>..ctor
	|
	|-RVA: 0x33E470 Offset: 0x33E571 VA: 0x33E470
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>..ctor
	|
	|-RVA: 0x33E550 Offset: 0x33E651 VA: 0x33E550
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>..ctor
	|
	|-RVA: 0x33E630 Offset: 0x33E731 VA: 0x33E630
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>..ctor
	|
	|-RVA: 0x33E710 Offset: 0x33E811 VA: 0x33E710
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Rect>>>..ctor
	|
	|-RVA: 0x33E7F0 Offset: 0x33E8F1 VA: 0x33E7F0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>..ctor
	|
	|-RVA: 0x33E8D0 Offset: 0x33E9D1 VA: 0x33E8D0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>..ctor
	|
	|-RVA: 0x33E9B0 Offset: 0x33EAB1 VA: 0x33E9B0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>..ctor
	|
	|-RVA: 0x33EA90 Offset: 0x33EB91 VA: 0x33EA90
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>..ctor
	|
	|-RVA: 0x33EB70 Offset: 0x33EC71 VA: 0x33EB70
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>..ctor
	|
	|-RVA: 0x33EC50 Offset: 0x33ED51 VA: 0x33EC50
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>..ctor
	|
	|-RVA: 0x33ED30 Offset: 0x33EE31 VA: 0x33ED30
	|-Array.InternalEnumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3554A0 Offset: 0x3555A1 VA: 0x3554A0
	|-Array.InternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>..ctor
	|
	|-RVA: 0x355580 Offset: 0x355681 VA: 0x355580
	|-Array.InternalEnumerator<KeyValuePair<object, ResourceLocator>>..ctor
	|
	|-RVA: 0x355660 Offset: 0x355761 VA: 0x355660
	|-Array.InternalEnumerator<KeyValuePair<object, sbyte>>..ctor
	|
	|-RVA: 0x355740 Offset: 0x355841 VA: 0x355740
	|-Array.InternalEnumerator<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x355820 Offset: 0x355921 VA: 0x355820
	|-Array.InternalEnumerator<KeyValuePair<object, ushort>>..ctor
	|
	|-RVA: 0x355900 Offset: 0x355A01 VA: 0x355900
	|-Array.InternalEnumerator<KeyValuePair<object, uint>>..ctor
	|
	|-RVA: 0x3559E0 Offset: 0x355AE1 VA: 0x3559E0
	|-Array.InternalEnumerator<KeyValuePair<object, ulong>>..ctor
	|
	|-RVA: 0x355AC0 Offset: 0x355BC1 VA: 0x355AC0
	|-Array.InternalEnumerator<KeyValuePair<object, TransitionTables>>..ctor
	|
	|-RVA: 0x355BA0 Offset: 0x355CA1 VA: 0x355BA0
	|-Array.InternalEnumerator<KeyValuePair<object, Bounds>>..ctor
	|
	|-RVA: 0x355C80 Offset: 0x355D81 VA: 0x355C80
	|-Array.InternalEnumerator<KeyValuePair<object, BoundsInt>>..ctor
	|
	|-RVA: 0x355D60 Offset: 0x355E61 VA: 0x355D60
	|-Array.InternalEnumerator<KeyValuePair<object, Color32>>..ctor
	|
	|-RVA: 0x355E40 Offset: 0x355F41 VA: 0x355E40
	|-Array.InternalEnumerator<KeyValuePair<object, Color>>..ctor
	|
	|-RVA: 0x355F20 Offset: 0x356021 VA: 0x355F20
	|-Array.InternalEnumerator<KeyValuePair<object, GradientAlphaKey>>..ctor
	|
	|-RVA: 0x356000 Offset: 0x356101 VA: 0x356000
	|-Array.InternalEnumerator<KeyValuePair<object, GradientColorKey>>..ctor
	|
	|-RVA: 0x3560E0 Offset: 0x3561E1 VA: 0x3560E0
	|-Array.InternalEnumerator<KeyValuePair<object, Keyframe>>..ctor
	|
	|-RVA: 0x3561C0 Offset: 0x3562C1 VA: 0x3561C0
	|-Array.InternalEnumerator<KeyValuePair<object, LayerMask>>..ctor
	|
	|-RVA: 0x3562A0 Offset: 0x3563A1 VA: 0x3562A0
	|-Array.InternalEnumerator<KeyValuePair<object, Matrix4x4>>..ctor
	|
	|-RVA: 0x356380 Offset: 0x356481 VA: 0x356380
	|-Array.InternalEnumerator<KeyValuePair<object, Playable>>..ctor
	|
	|-RVA: 0x356460 Offset: 0x356561 VA: 0x356460
	|-Array.InternalEnumerator<KeyValuePair<object, Quaternion>>..ctor
	|
	|-RVA: 0x356540 Offset: 0x356641 VA: 0x356540
	|-Array.InternalEnumerator<KeyValuePair<object, RangeInt>>..ctor
	|
	|-RVA: 0x356620 Offset: 0x356721 VA: 0x356620
	|-Array.InternalEnumerator<KeyValuePair<object, Rect>>..ctor
	|
	|-RVA: 0x356700 Offset: 0x356801 VA: 0x356700
	|-Array.InternalEnumerator<KeyValuePair<object, RectInt>>..ctor
	|
	|-RVA: 0x3567E0 Offset: 0x3568E1 VA: 0x3567E0
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x3568C0 Offset: 0x3569C1 VA: 0x3568C0
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>..ctor
	|
	|-RVA: 0x3569A0 Offset: 0x356AA1 VA: 0x3569A0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2>>..ctor
	|
	|-RVA: 0x356A80 Offset: 0x356B81 VA: 0x356A80
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2Int>>..ctor
	|
	|-RVA: 0x356B60 Offset: 0x356C61 VA: 0x356B60
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3>>..ctor
	|
	|-RVA: 0x356C40 Offset: 0x356D41 VA: 0x356C40
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3Int>>..ctor
	|
	|-RVA: 0x356D20 Offset: 0x356E21 VA: 0x356D20
	|-Array.InternalEnumerator<KeyValuePair<object, Vector4>>..ctor
	|
	|-RVA: 0x356E00 Offset: 0x356F01 VA: 0x356E00
	|-Array.InternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>..ctor
	|
	|-RVA: 0x356EE0 Offset: 0x356FE1 VA: 0x356EE0
	|-Array.InternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>..ctor
	|
	|-RVA: 0x356FC0 Offset: 0x3570C1 VA: 0x356FC0
	|-Array.InternalEnumerator<KeyValuePair<sbyte, object>>..ctor
	|
	|-RVA: 0x3570A0 Offset: 0x3571A1 VA: 0x3570A0
	|-Array.InternalEnumerator<KeyValuePair<float, CurveSample>>..ctor
	|
	|-RVA: 0x357180 Offset: 0x357281 VA: 0x357180
	|-Array.InternalEnumerator<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x357260 Offset: 0x357361 VA: 0x357260
	|-Array.InternalEnumerator<KeyValuePair<ushort, object>>..ctor
	|
	|-RVA: 0x357340 Offset: 0x357441 VA: 0x357340
	|-Array.InternalEnumerator<KeyValuePair<uint, int>>..ctor
	|
	|-RVA: 0x3574A0 Offset: 0x3575A1 VA: 0x3574A0
	|-Array.InternalEnumerator<KeyValuePair<uint, Int32Enum>>..ctor
	|
	|-RVA: 0x357600 Offset: 0x357701 VA: 0x357600
	|-Array.InternalEnumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x3576E0 Offset: 0x3577E1 VA: 0x3576E0
	|-Array.InternalEnumerator<KeyValuePair<ulong, object>>..ctor
	|
	|-RVA: 0x3577C0 Offset: 0x3578C1 VA: 0x3577C0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>..ctor
	|
	|-RVA: 0x3578B0 Offset: 0x3579B1 VA: 0x3578B0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>..ctor
	|
	|-RVA: 0x357990 Offset: 0x357A91 VA: 0x357990
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>..ctor
	|
	|-RVA: 0x357A70 Offset: 0x357B71 VA: 0x357A70
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>..ctor
	|
	|-RVA: 0x357B50 Offset: 0x357C51 VA: 0x357B50
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>..ctor
	|
	|-RVA: 0x357C40 Offset: 0x357D41 VA: 0x357C40
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>..ctor
	|
	|-RVA: 0x357D20 Offset: 0x357E21 VA: 0x357D20
	|-Array.InternalEnumerator<KeyValuePair<Bounds, object>>..ctor
	|
	|-RVA: 0x357E00 Offset: 0x357F01 VA: 0x357E00
	|-Array.InternalEnumerator<KeyValuePair<BoundsInt, object>>..ctor
	|
	|-RVA: 0x357EE0 Offset: 0x357FE1 VA: 0x357EE0
	|-Array.InternalEnumerator<KeyValuePair<Color, object>>..ctor
	|
	|-RVA: 0x357FC0 Offset: 0x3580C1 VA: 0x357FC0
	|-Array.InternalEnumerator<KeyValuePair<Color32, object>>..ctor
	|
	|-RVA: 0x3580A0 Offset: 0x3581A1 VA: 0x3580A0
	|-Array.InternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>..ctor
	|
	|-RVA: 0x358180 Offset: 0x358281 VA: 0x358180
	|-Array.InternalEnumerator<KeyValuePair<GradientAlphaKey, object>>..ctor
	|
	|-RVA: 0x358260 Offset: 0x358361 VA: 0x358260
	|-Array.InternalEnumerator<KeyValuePair<GradientColorKey, object>>..ctor
	|
	|-RVA: 0x358340 Offset: 0x358441 VA: 0x358340
	|-Array.InternalEnumerator<KeyValuePair<Keyframe, object>>..ctor
	|
	|-RVA: 0x358420 Offset: 0x358521 VA: 0x358420
	|-Array.InternalEnumerator<KeyValuePair<LayerMask, object>>..ctor
	|
	|-RVA: 0x358500 Offset: 0x358601 VA: 0x358500
	|-Array.InternalEnumerator<KeyValuePair<Matrix4x4, object>>..ctor
	|
	|-RVA: 0x3585E0 Offset: 0x3586E1 VA: 0x3585E0
	|-Array.InternalEnumerator<KeyValuePair<IntVec3, object>>..ctor
	|
	|-RVA: 0x3586C0 Offset: 0x3587C1 VA: 0x3586C0
	|-Array.InternalEnumerator<KeyValuePair<Quaternion, object>>..ctor
	|
	|-RVA: 0x3587A0 Offset: 0x3588A1 VA: 0x3587A0
	|-Array.InternalEnumerator<KeyValuePair<RangeInt, object>>..ctor
	|
	|-RVA: 0x358880 Offset: 0x358981 VA: 0x358880
	|-Array.InternalEnumerator<KeyValuePair<Rect, object>>..ctor
	|
	|-RVA: 0x358960 Offset: 0x358A61 VA: 0x358960
	|-Array.InternalEnumerator<KeyValuePair<RectInt, object>>..ctor
	|
	|-RVA: 0x358A40 Offset: 0x358B41 VA: 0x358A40
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>..ctor
	|
	|-RVA: 0x358B30 Offset: 0x358C31 VA: 0x358B30
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>..ctor
	|
	|-RVA: 0x358C10 Offset: 0x358D11 VA: 0x358C10
	|-Array.InternalEnumerator<KeyValuePair<Vector2, object>>..ctor
	|
	|-RVA: 0x358CF0 Offset: 0x358DF1 VA: 0x358CF0
	|-Array.InternalEnumerator<KeyValuePair<Vector2Int, object>>..ctor
	|
	|-RVA: 0x358DD0 Offset: 0x358ED1 VA: 0x358DD0
	|-Array.InternalEnumerator<KeyValuePair<Vector3, object>>..ctor
	|
	|-RVA: 0x358EB0 Offset: 0x358FB1 VA: 0x358EB0
	|-Array.InternalEnumerator<KeyValuePair<Vector3Int, object>>..ctor
	|
	|-RVA: 0x358F90 Offset: 0x359091 VA: 0x358F90
	|-Array.InternalEnumerator<KeyValuePair<Vector4, object>>..ctor
	|
	|-RVA: 0x359070 Offset: 0x359171 VA: 0x359070
	|-Array.InternalEnumerator<Hashtable.bucket>..ctor
	|
	|-RVA: 0x359150 Offset: 0x359251 VA: 0x359150
	|-Array.InternalEnumerator<DateTime>..ctor
	|
	|-RVA: 0x3592B0 Offset: 0x3593B1 VA: 0x3592B0
	|-Array.InternalEnumerator<DateTimeOffset>..ctor
	|
	|-RVA: 0x359390 Offset: 0x359491 VA: 0x359390
	|-Array.InternalEnumerator<Decimal>..ctor
	|
	|-RVA: 0x359470 Offset: 0x359571 VA: 0x359470
	|-Array.InternalEnumerator<double>..ctor
	|
	|-RVA: 0x3595D0 Offset: 0x3596D1 VA: 0x3595D0
	|-Array.InternalEnumerator<InternalCodePageDataItem>..ctor
	|
	|-RVA: 0x3596B0 Offset: 0x3597B1 VA: 0x3596B0
	|-Array.InternalEnumerator<InternalEncodingDataItem>..ctor
	|
	|-RVA: 0x359790 Offset: 0x359891 VA: 0x359790
	|-Array.InternalEnumerator<Guid>..ctor
	|
	|-RVA: 0x359870 Offset: 0x359971 VA: 0x359870
	|-Array.InternalEnumerator<short>..ctor
	|
	|-RVA: 0x3599D0 Offset: 0x359AD1 VA: 0x3599D0
	|-Array.InternalEnumerator<int>..ctor
	|
	|-RVA: 0x359B30 Offset: 0x359C31 VA: 0x359B30
	|-Array.InternalEnumerator<Int32Enum>..ctor
	|
	|-RVA: 0x359C90 Offset: 0x359D91 VA: 0x359C90
	|-Array.InternalEnumerator<long>..ctor
	|
	|-RVA: 0x359DF0 Offset: 0x359EF1 VA: 0x359DF0
	|-Array.InternalEnumerator<IntPtr>..ctor
	|
	|-RVA: 0x359F50 Offset: 0x35A051 VA: 0x359F50
	|-Array.InternalEnumerator<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x35A030 Offset: 0x35A131 VA: 0x35A030
	|-Array.InternalEnumerator<LocalDefinition>..ctor
	|
	|-RVA: 0x35A110 Offset: 0x35A211 VA: 0x35A110
	|-Array.InternalEnumerator<RuntimeLabel>..ctor
	|
	|-RVA: 0x35A200 Offset: 0x35A301 VA: 0x35A200
	|-Array.InternalEnumerator<Set.Slot<int>>..ctor
	|
	|-RVA: 0x35A2F0 Offset: 0x35A3F1 VA: 0x35A2F0
	|-Array.InternalEnumerator<Set.Slot<object>>..ctor
	|
	|-RVA: 0x35A3D0 Offset: 0x35A4D1 VA: 0x35A3D0
	|-Array.InternalEnumerator<Memory<object>>..ctor
	|
	|-RVA: 0x35A4B0 Offset: 0x35A5B1 VA: 0x35A4B0
	|-Array.InternalEnumerator<CookieTokenizer.RecognizedAttribute>..ctor
	|
	|-RVA: 0x35A590 Offset: 0x35A691 VA: 0x35A590
	|-Array.InternalEnumerator<HeaderVariantInfo>..ctor
	|
	|-RVA: 0x35A670 Offset: 0x35A771 VA: 0x35A670
	|-Array.InternalEnumerator<Socket.WSABUF>..ctor
	|
	|-RVA: 0x35A750 Offset: 0x35A851 VA: 0x35A750
	|-Array.InternalEnumerator<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x35A830 Offset: 0x35A931 VA: 0x35A830
	|-Array.InternalEnumerator<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x35A990 Offset: 0x35AA91 VA: 0x35A990
	|-Array.InternalEnumerator<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x35AA70 Offset: 0x35AB71 VA: 0x35AA70
	|-Array.InternalEnumerator<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x35AB50 Offset: 0x35AC51 VA: 0x35AB50
	|-Array.InternalEnumerator<Nullable<Color32>>..ctor
	|
	|-RVA: 0x35ACB0 Offset: 0x35ADB1 VA: 0x35ACB0
	|-Array.InternalEnumerator<Nullable<Color>>..ctor
	|
	|-RVA: 0x35AD90 Offset: 0x35AE91 VA: 0x35AD90
	|-Array.InternalEnumerator<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x35AE80 Offset: 0x35AF81 VA: 0x35AE80
	|-Array.InternalEnumerator<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x35AF60 Offset: 0x35B061 VA: 0x35AF60
	|-Array.InternalEnumerator<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x35B040 Offset: 0x35B141 VA: 0x35B040
	|-Array.InternalEnumerator<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x35B1A0 Offset: 0x35B2A1 VA: 0x35B1A0
	|-Array.InternalEnumerator<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x35B280 Offset: 0x35B381 VA: 0x35B280
	|-Array.InternalEnumerator<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x35B360 Offset: 0x35B461 VA: 0x35B360
	|-Array.InternalEnumerator<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x35B450 Offset: 0x35B551 VA: 0x35B450
	|-Array.InternalEnumerator<Nullable<Rect>>..ctor
	|
	|-RVA: 0x35B530 Offset: 0x35B631 VA: 0x35B530
	|-Array.InternalEnumerator<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x35B610 Offset: 0x35B711 VA: 0x35B610
	|-Array.InternalEnumerator<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x35B700 Offset: 0x35B801 VA: 0x35B700
	|-Array.InternalEnumerator<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x35B7F0 Offset: 0x35B8F1 VA: 0x35B7F0
	|-Array.InternalEnumerator<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x3429D0 Offset: 0x342AD1 VA: 0x3429D0
	|-Array.InternalEnumerator<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x342AB0 Offset: 0x342BB1 VA: 0x342AB0
	|-Array.InternalEnumerator<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x342B90 Offset: 0x342C91 VA: 0x342B90
	|-Array.InternalEnumerator<object>..ctor
	|
	|-RVA: 0x342CA0 Offset: 0x342DA1 VA: 0x342CA0
	|-Array.InternalEnumerator<ParameterizedStrings.FormatParam>..ctor
	|
	|-RVA: 0x342D80 Offset: 0x342E81 VA: 0x342D80
	|-Array.InternalEnumerator<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x342E60 Offset: 0x342F61 VA: 0x342E60
	|-Array.InternalEnumerator<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x342F40 Offset: 0x343041 VA: 0x342F40
	|-Array.InternalEnumerator<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x343020 Offset: 0x343121 VA: 0x343020
	|-Array.InternalEnumerator<Label>..ctor
	|
	|-RVA: 0x343190 Offset: 0x343291 VA: 0x343190
	|-Array.InternalEnumerator<ParameterModifier>..ctor
	|
	|-RVA: 0x3432F0 Offset: 0x3433F1 VA: 0x3432F0
	|-Array.InternalEnumerator<ResourceLocator>..ctor
	|
	|-RVA: 0x3433D0 Offset: 0x3434D1 VA: 0x3433D0
	|-Array.InternalEnumerator<Ephemeron>..ctor
	|
	|-RVA: 0x3434B0 Offset: 0x3435B1 VA: 0x3434B0
	|-Array.InternalEnumerator<GCHandle>..ctor
	|
	|-RVA: 0x343620 Offset: 0x343721 VA: 0x343620
	|-Array.InternalEnumerator<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x343780 Offset: 0x343881 VA: 0x343780
	|-Array.InternalEnumerator<sbyte>..ctor
	|
	|-RVA: 0x3438E0 Offset: 0x3439E1 VA: 0x3438E0
	|-Array.InternalEnumerator<X509ChainStatus>..ctor
	|
	|-RVA: 0x3439C0 Offset: 0x343AC1 VA: 0x3439C0
	|-Array.InternalEnumerator<float>..ctor
	|
	|-RVA: 0x343B20 Offset: 0x343C21 VA: 0x343B20
	|-Array.InternalEnumerator<RegexCharClass.LowerCaseMapping>..ctor
	|
	|-RVA: 0x343C10 Offset: 0x343D11 VA: 0x343C10
	|-Array.InternalEnumerator<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x343CF0 Offset: 0x343DF1 VA: 0x343CF0
	|-Array.InternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>..ctor
	|
	|-RVA: 0x343E50 Offset: 0x343F51 VA: 0x343E50
	|-Array.InternalEnumerator<TimeSpan>..ctor
	|
	|-RVA: 0x343FB0 Offset: 0x3440B1 VA: 0x343FB0
	|-Array.InternalEnumerator<ushort>..ctor
	|
	|-RVA: 0x344110 Offset: 0x344211 VA: 0x344110
	|-Array.InternalEnumerator<UInt16Enum>..ctor
	|
	|-RVA: 0x344270 Offset: 0x344371 VA: 0x344270
	|-Array.InternalEnumerator<uint>..ctor
	|
	|-RVA: 0x3443D0 Offset: 0x3444D1 VA: 0x3443D0
	|-Array.InternalEnumerator<UInt32Enum>..ctor
	|
	|-RVA: 0x344530 Offset: 0x344631 VA: 0x344530
	|-Array.InternalEnumerator<ulong>..ctor
	|
	|-RVA: 0x344690 Offset: 0x344791 VA: 0x344690
	|-Array.InternalEnumerator<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x3447F0 Offset: 0x3448F1 VA: 0x3447F0
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x344950 Offset: 0x344A51 VA: 0x344950
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x344A30 Offset: 0x344B31 VA: 0x344A30
	|-Array.InternalEnumerator<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x344B10 Offset: 0x344C11 VA: 0x344B10
	|-Array.InternalEnumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x344BF0 Offset: 0x344CF1 VA: 0x344BF0
	|-Array.InternalEnumerator<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x344CD0 Offset: 0x344DD1 VA: 0x344CD0
	|-Array.InternalEnumerator<ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x344DB0 Offset: 0x344EB1 VA: 0x344DB0
	|-Array.InternalEnumerator<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x344E90 Offset: 0x344F91 VA: 0x344E90
	|-Array.InternalEnumerator<ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x344F70 Offset: 0x345071 VA: 0x344F70
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x345060 Offset: 0x345161 VA: 0x345060
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3>>..ctor
	|
	|-RVA: 0x345140 Offset: 0x345241 VA: 0x345140
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3, float>>..ctor
	|
	|-RVA: 0x345220 Offset: 0x345321 VA: 0x345220
	|-Array.InternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x345300 Offset: 0x345401 VA: 0x345300
	|-Array.InternalEnumerator<HighlightState>..ctor
	|
	|-RVA: 0x3453E0 Offset: 0x3454E1 VA: 0x3453E0
	|-Array.InternalEnumerator<MaterialReference>..ctor
	|
	|-RVA: 0x3454C0 Offset: 0x3455C1 VA: 0x3454C0
	|-Array.InternalEnumerator<RichTextTagAttribute>..ctor
	|
	|-RVA: 0x3455A0 Offset: 0x3456A1 VA: 0x3455A0
	|-Array.InternalEnumerator<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x345680 Offset: 0x345781 VA: 0x345680
	|-Array.InternalEnumerator<TMP_CharacterInfo>..ctor
	|
	|-RVA: 0x345760 Offset: 0x345861 VA: 0x345760
	|-Array.InternalEnumerator<TMP_FontWeightPair>..ctor
	|
	|-RVA: 0x345840 Offset: 0x345941 VA: 0x345840
	|-Array.InternalEnumerator<TMP_LineInfo>..ctor
	|
	|-RVA: 0x345920 Offset: 0x345A21 VA: 0x345920
	|-Array.InternalEnumerator<TMP_LinkInfo>..ctor
	|
	|-RVA: 0x345A00 Offset: 0x345B01 VA: 0x345A00
	|-Array.InternalEnumerator<TMP_MeshInfo>..ctor
	|
	|-RVA: 0x345AE0 Offset: 0x345BE1 VA: 0x345AE0
	|-Array.InternalEnumerator<TMP_PageInfo>..ctor
	|
	|-RVA: 0x345BC0 Offset: 0x345CC1 VA: 0x345BC0
	|-Array.InternalEnumerator<TMP_Text.UnicodeChar>..ctor
	|
	|-RVA: 0x345CB0 Offset: 0x345DB1 VA: 0x345CB0
	|-Array.InternalEnumerator<TMP_TextProcessingStack<int>>..ctor
	|
	|-RVA: 0x345D90 Offset: 0x345E91 VA: 0x345D90
	|-Array.InternalEnumerator<TMP_WordInfo>..ctor
	|
	|-RVA: 0x345E70 Offset: 0x345F71 VA: 0x345E70
	|-Array.InternalEnumerator<WordWrapState>..ctor
	|
	|-RVA: 0x345F50 Offset: 0x346051 VA: 0x345F50
	|-Array.InternalEnumerator<TextPaneDatas.TextPaneData>..ctor
	|
	|-RVA: 0x346030 Offset: 0x346131 VA: 0x346030
	|-Array.InternalEnumerator<TransitionTables>..ctor
	|
	|-RVA: 0x346110 Offset: 0x346211 VA: 0x346110
	|-Array.InternalEnumerator<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x346200 Offset: 0x346301 VA: 0x346200
	|-Array.InternalEnumerator<UICheckOnBackRune.LinkSet>..ctor
	|
	|-RVA: 0x3462E0 Offset: 0x3463E1 VA: 0x3462E0
	|-Array.InternalEnumerator<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x3463C0 Offset: 0x3464C1 VA: 0x3463C0
	|-Array.InternalEnumerator<CapEdge>..ctor
	|
	|-RVA: 0x3464A0 Offset: 0x3465A1 VA: 0x3464A0
	|-Array.InternalEnumerator<ClippedEdge>..ctor
	|
	|-RVA: 0x346580 Offset: 0x346681 VA: 0x346580
	|-Array.InternalEnumerator<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x3466E0 Offset: 0x3467E1 VA: 0x3466E0
	|-Array.InternalEnumerator<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x346840 Offset: 0x346941 VA: 0x346840
	|-Array.InternalEnumerator<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x3469A0 Offset: 0x346AA1 VA: 0x3469A0
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x346A80 Offset: 0x346B81 VA: 0x346A80
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x346B60 Offset: 0x346C61 VA: 0x346B60
	|-Array.InternalEnumerator<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x346C40 Offset: 0x346D41 VA: 0x346C40
	|-Array.InternalEnumerator<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x346D20 Offset: 0x346E21 VA: 0x346D20
	|-Array.InternalEnumerator<ContentCatalogData.Bucket>..ctor
	|
	|-RVA: 0x346E00 Offset: 0x346F01 VA: 0x346E00
	|-Array.InternalEnumerator<ConstraintSource>..ctor
	|
	|-RVA: 0x346EE0 Offset: 0x346FE1 VA: 0x346EE0
	|-Array.InternalEnumerator<PropertySceneHandle>..ctor
	|
	|-RVA: 0x347040 Offset: 0x347141 VA: 0x347040
	|-Array.InternalEnumerator<TransformStreamHandle>..ctor
	|
	|-RVA: 0x347130 Offset: 0x347231 VA: 0x347130
	|-Array.InternalEnumerator<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x347290 Offset: 0x347391 VA: 0x347290
	|-Array.InternalEnumerator<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x347370 Offset: 0x347471 VA: 0x347370
	|-Array.InternalEnumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x3474D0 Offset: 0x3475D1 VA: 0x3474D0
	|-Array.InternalEnumerator<BoneWeight>..ctor
	|
	|-RVA: 0x3475B0 Offset: 0x3476B1 VA: 0x3475B0
	|-Array.InternalEnumerator<BoundingSphere>..ctor
	|
	|-RVA: 0x347690 Offset: 0x347791 VA: 0x347690
	|-Array.InternalEnumerator<Bounds>..ctor
	|
	|-RVA: 0x347770 Offset: 0x347871 VA: 0x347770
	|-Array.InternalEnumerator<BoundsInt>..ctor
	|
	|-RVA: 0x347850 Offset: 0x347951 VA: 0x347850
	|-Array.InternalEnumerator<CharacterInfo>..ctor
	|
	|-RVA: 0x347930 Offset: 0x347A31 VA: 0x347930
	|-Array.InternalEnumerator<Color32>..ctor
	|
	|-RVA: 0x347AA0 Offset: 0x347BA1 VA: 0x347AA0
	|-Array.InternalEnumerator<Color>..ctor
	|
	|-RVA: 0x347B80 Offset: 0x347C81 VA: 0x347B80
	|-Array.InternalEnumerator<CombineInstance>..ctor
	|
	|-RVA: 0x347C60 Offset: 0x347D61 VA: 0x347C60
	|-Array.InternalEnumerator<ContactPoint2D>..ctor
	|
	|-RVA: 0x347D40 Offset: 0x347E41 VA: 0x347D40
	|-Array.InternalEnumerator<ContactPoint>..ctor
	|
	|-RVA: 0x347E20 Offset: 0x347F21 VA: 0x347E20
	|-Array.InternalEnumerator<RaycastResult>..ctor
	|
	|-RVA: 0x347F00 Offset: 0x348001 VA: 0x347F00
	|-Array.InternalEnumerator<LightDataGI>..ctor
	|
	|-RVA: 0x347FE0 Offset: 0x3480E1 VA: 0x347FE0
	|-Array.InternalEnumerator<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x348140 Offset: 0x348241 VA: 0x348140
	|-Array.InternalEnumerator<GradientAlphaKey>..ctor
	|
	|-RVA: 0x348220 Offset: 0x348321 VA: 0x348220
	|-Array.InternalEnumerator<GradientColorKey>..ctor
	|
	|-RVA: 0x348300 Offset: 0x348401 VA: 0x348300
	|-Array.InternalEnumerator<HumanBone>..ctor
	|
	|-RVA: 0x3483E0 Offset: 0x3484E1 VA: 0x3483E0
	|-Array.InternalEnumerator<Keyframe>..ctor
	|
	|-RVA: 0x3484C0 Offset: 0x3485C1 VA: 0x3484C0
	|-Array.InternalEnumerator<LOD>..ctor
	|
	|-RVA: 0x3485A0 Offset: 0x3486A1 VA: 0x3485A0
	|-Array.InternalEnumerator<LayerMask>..ctor
	|
	|-RVA: 0x348710 Offset: 0x348811 VA: 0x348710
	|-Array.InternalEnumerator<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3487F0 Offset: 0x3488F1 VA: 0x3487F0
	|-Array.InternalEnumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x3488D0 Offset: 0x3489D1 VA: 0x3488D0
	|-Array.InternalEnumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3489B0 Offset: 0x348AB1 VA: 0x3489B0
	|-Array.InternalEnumerator<PatchExtents>..ctor
	|
	|-RVA: 0x348A90 Offset: 0x348B91 VA: 0x348A90
	|-Array.InternalEnumerator<Plane>..ctor
	|
	|-RVA: 0x348B70 Offset: 0x348C71 VA: 0x348B70
	|-Array.InternalEnumerator<Playable>..ctor
	|
	|-RVA: 0x348C50 Offset: 0x348D51 VA: 0x348C50
	|-Array.InternalEnumerator<PlayableBinding>..ctor
	|
	|-RVA: 0x348D30 Offset: 0x348E31 VA: 0x348D30
	|-Array.InternalEnumerator<PlayableGraph>..ctor
	|
	|-RVA: 0x348E10 Offset: 0x348F11 VA: 0x348E10
	|-Array.InternalEnumerator<Edge>..ctor
	|
	|-RVA: 0x348F70 Offset: 0x349071 VA: 0x348F70
	|-Array.InternalEnumerator<IntVec3>..ctor
	|
	|-RVA: 0x349050 Offset: 0x349151 VA: 0x349050
	|-Array.InternalEnumerator<Quaternion>..ctor
	|
	|-RVA: 0x349130 Offset: 0x349231 VA: 0x349130
	|-Array.InternalEnumerator<RangeInt>..ctor
	|
	|-RVA: 0x349290 Offset: 0x349391 VA: 0x349290
	|-Array.InternalEnumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x349370 Offset: 0x349471 VA: 0x349370
	|-Array.InternalEnumerator<RaycastHit>..ctor
	|
	|-RVA: 0x349450 Offset: 0x349551 VA: 0x349450
	|-Array.InternalEnumerator<Rect>..ctor
	|
	|-RVA: 0x349530 Offset: 0x349631 VA: 0x349530
	|-Array.InternalEnumerator<RectInt>..ctor
	|
	|-RVA: 0x349610 Offset: 0x349711 VA: 0x349610
	|-Array.InternalEnumerator<RenderBuffer>..ctor
	|
	|-RVA: 0x327D00 Offset: 0x327E01 VA: 0x327D00
	|-Array.InternalEnumerator<BatchVisibility>..ctor
	|
	|-RVA: 0x327DF0 Offset: 0x327EF1 VA: 0x327DF0
	|-Array.InternalEnumerator<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x327ED0 Offset: 0x327FD1 VA: 0x327ED0
	|-Array.InternalEnumerator<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x327FB0 Offset: 0x3280B1 VA: 0x327FB0
	|-Array.InternalEnumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x328090 Offset: 0x328191 VA: 0x328090
	|-Array.InternalEnumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x328170 Offset: 0x328271 VA: 0x328170
	|-Array.InternalEnumerator<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x328250 Offset: 0x328351 VA: 0x328250
	|-Array.InternalEnumerator<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x328330 Offset: 0x328431 VA: 0x328330
	|-Array.InternalEnumerator<DiagnosticEvent>..ctor
	|
	|-RVA: 0x328410 Offset: 0x328511 VA: 0x328410
	|-Array.InternalEnumerator<SceneInstance>..ctor
	|
	|-RVA: 0x3284F0 Offset: 0x3285F1 VA: 0x3284F0
	|-Array.InternalEnumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3285D0 Offset: 0x3286D1 VA: 0x3285D0
	|-Array.InternalEnumerator<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3286B0 Offset: 0x3287B1 VA: 0x3286B0
	|-Array.InternalEnumerator<SerializedType>..ctor
	|
	|-RVA: 0x328790 Offset: 0x328891 VA: 0x328790
	|-Array.InternalEnumerator<SendMouseEvents.HitInfo>..ctor
	|
	|-RVA: 0x328870 Offset: 0x328971 VA: 0x328870
	|-Array.InternalEnumerator<SkeletonBone>..ctor
	|
	|-RVA: 0x328950 Offset: 0x328A51 VA: 0x328950
	|-Array.InternalEnumerator<GlyphRect>..ctor
	|
	|-RVA: 0x328A30 Offset: 0x328B31 VA: 0x328A30
	|-Array.InternalEnumerator<GlyphMarshallingStruct>..ctor
	|
	|-RVA: 0x328B10 Offset: 0x328C11 VA: 0x328B10
	|-Array.InternalEnumerator<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x328BF0 Offset: 0x328CF1 VA: 0x328BF0
	|-Array.InternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x328CD0 Offset: 0x328DD1 VA: 0x328CD0
	|-Array.InternalEnumerator<IntervalTreeNode>..ctor
	|
	|-RVA: 0x328DB0 Offset: 0x328EB1 VA: 0x328DB0
	|-Array.InternalEnumerator<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x328E90 Offset: 0x328F91 VA: 0x328E90
	|-Array.InternalEnumerator<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x328F70 Offset: 0x329071 VA: 0x328F70
	|-Array.InternalEnumerator<Touch>..ctor
	|
	|-RVA: 0x329050 Offset: 0x329151 VA: 0x329050
	|-Array.InternalEnumerator<TreeInstance>..ctor
	|
	|-RVA: 0x329130 Offset: 0x329231 VA: 0x329130
	|-Array.InternalEnumerator<ColorBlock>..ctor
	|
	|-RVA: 0x329210 Offset: 0x329311 VA: 0x329210
	|-Array.InternalEnumerator<Navigation>..ctor
	|
	|-RVA: 0x3292F0 Offset: 0x3293F1 VA: 0x3292F0
	|-Array.InternalEnumerator<SpriteState>..ctor
	|
	|-RVA: 0x3293D0 Offset: 0x3294D1 VA: 0x3293D0
	|-Array.InternalEnumerator<UICharInfo>..ctor
	|
	|-RVA: 0x3294B0 Offset: 0x3295B1 VA: 0x3294B0
	|-Array.InternalEnumerator<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x329590 Offset: 0x329691 VA: 0x329590
	|-Array.InternalEnumerator<EventDispatcher.EventRecord>..ctor
	|
	|-RVA: 0x329670 Offset: 0x329771 VA: 0x329670
	|-Array.InternalEnumerator<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x329750 Offset: 0x329851 VA: 0x329750
	|-Array.InternalEnumerator<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x3298B0 Offset: 0x3299B1 VA: 0x3298B0
	|-Array.InternalEnumerator<StyleValue>..ctor
	|
	|-RVA: 0x329990 Offset: 0x329A91 VA: 0x329990
	|-Array.InternalEnumerator<UILineInfo>..ctor
	|
	|-RVA: 0x329A70 Offset: 0x329B71 VA: 0x329A70
	|-Array.InternalEnumerator<UIVertex>..ctor
	|
	|-RVA: 0x329B50 Offset: 0x329C51 VA: 0x329B50
	|-Array.InternalEnumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x329C30 Offset: 0x329D31 VA: 0x329C30
	|-Array.InternalEnumerator<Vector2>..ctor
	|
	|-RVA: 0x329D10 Offset: 0x329E11 VA: 0x329D10
	|-Array.InternalEnumerator<Vector2Int>..ctor
	|
	|-RVA: 0x329E70 Offset: 0x329F71 VA: 0x329E70
	|-Array.InternalEnumerator<Vector3>..ctor
	|
	|-RVA: 0x329F50 Offset: 0x32A051 VA: 0x329F50
	|-Array.InternalEnumerator<Vector3Int>..ctor
	|
	|-RVA: 0x32A040 Offset: 0x32A141 VA: 0x32A040
	|-Array.InternalEnumerator<Vector4>..ctor
	|
	|-RVA: 0x32A120 Offset: 0x32A221 VA: 0x32A120
	|-Array.InternalEnumerator<jvalue>..ctor
	|
	|-RVA: 0x32A280 Offset: 0x32A381 VA: 0x32A280
	|-Array.InternalEnumerator<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x32A360 Offset: 0x32A461 VA: 0x32A360
	|-Array.InternalEnumerator<YieldItemParam>..ctor
	|
	|-RVA: 0x32A4C0 Offset: 0x32A5C1 VA: 0x32A4C0
	|-Array.InternalEnumerator<NetworkServiceAccountId>..ctor
	|
	|-RVA: 0x32A620 Offset: 0x32A721 VA: 0x32A620
	|-Array.InternalEnumerator<Uid>..ctor
	|
	|-RVA: 0x32A700 Offset: 0x32A801 VA: 0x32A700
	|-Array.InternalEnumerator<ConsumableServiceItemId>..ctor
	|
	|-RVA: 0x32A860 Offset: 0x32A961 VA: 0x32A860
	|-Array.InternalEnumerator<NsUid>..ctor
	|
	|-RVA: 0x32A9C0 Offset: 0x32AAC1 VA: 0x32A9C0
	|-Array.InternalEnumerator<Friend>..ctor
	|
	|-RVA: 0x32AAA0 Offset: 0x32ABA1 VA: 0x32AAA0
	|-Array.InternalEnumerator<Profile>..ctor
	|
	|-RVA: 0x32AB80 Offset: 0x32AC81 VA: 0x32AB80
	|-Array.InternalEnumerator<DirectoryEntry>..ctor
	|
	|-RVA: 0x32AC60 Offset: 0x32AD61 VA: 0x32AC60
	|-Array.InternalEnumerator<DebugPadState>..ctor
	|
	|-RVA: 0x32AD40 Offset: 0x32AE41 VA: 0x32AD40
	|-Array.InternalEnumerator<GesturePoint>..ctor
	|
	|-RVA: 0x32AEA0 Offset: 0x32AFA1 VA: 0x32AEA0
	|-Array.InternalEnumerator<GestureState>..ctor
	|
	|-RVA: 0x32AF80 Offset: 0x32B081 VA: 0x32AF80
	|-Array.InternalEnumerator<NpadFullKeyState>..ctor
	|
	|-RVA: 0x32B060 Offset: 0x32B161 VA: 0x32B060
	|-Array.InternalEnumerator<NpadHandheldState>..ctor
	|
	|-RVA: 0x32B140 Offset: 0x32B241 VA: 0x32B140
	|-Array.InternalEnumerator<NpadJoyDualState>..ctor
	|
	|-RVA: 0x32B220 Offset: 0x32B321 VA: 0x32B220
	|-Array.InternalEnumerator<NpadJoyLeftState>..ctor
	|
	|-RVA: 0x32B300 Offset: 0x32B401 VA: 0x32B300
	|-Array.InternalEnumerator<NpadJoyRightState>..ctor
	|
	|-RVA: 0x32B3E0 Offset: 0x32B4E1 VA: 0x32B3E0
	|-Array.InternalEnumerator<NpadStateArrayItem>..ctor
	|
	|-RVA: 0x32B4C0 Offset: 0x32B5C1 VA: 0x32B4C0
	|-Array.InternalEnumerator<SixAxisSensorHandle>..ctor
	|
	|-RVA: 0x32B630 Offset: 0x32B731 VA: 0x32B630
	|-Array.InternalEnumerator<SixAxisSensorState>..ctor
	|
	|-RVA: 0x32B710 Offset: 0x32B811 VA: 0x32B710
	|-Array.InternalEnumerator<TouchScreenState10>..ctor
	|
	|-RVA: 0x32B7F0 Offset: 0x32B8F1 VA: 0x32B7F0
	|-Array.InternalEnumerator<TouchScreenState11>..ctor
	|
	|-RVA: 0x32B8D0 Offset: 0x32B9D1 VA: 0x32B8D0
	|-Array.InternalEnumerator<TouchScreenState12>..ctor
	|
	|-RVA: 0x32B9B0 Offset: 0x32BAB1 VA: 0x32B9B0
	|-Array.InternalEnumerator<TouchScreenState13>..ctor
	|
	|-RVA: 0x32BA90 Offset: 0x32BB91 VA: 0x32BA90
	|-Array.InternalEnumerator<TouchScreenState14>..ctor
	|
	|-RVA: 0x32BB70 Offset: 0x32BC71 VA: 0x32BB70
	|-Array.InternalEnumerator<TouchScreenState15>..ctor
	|
	|-RVA: 0x32BC50 Offset: 0x32BD51 VA: 0x32BC50
	|-Array.InternalEnumerator<TouchScreenState16>..ctor
	|
	|-RVA: 0x32BD30 Offset: 0x32BE31 VA: 0x32BD30
	|-Array.InternalEnumerator<TouchScreenState1>..ctor
	|
	|-RVA: 0x32BE10 Offset: 0x32BF11 VA: 0x32BE10
	|-Array.InternalEnumerator<TouchScreenState2>..ctor
	|
	|-RVA: 0x32BEF0 Offset: 0x32BFF1 VA: 0x32BEF0
	|-Array.InternalEnumerator<TouchScreenState3>..ctor
	|
	|-RVA: 0x32BFD0 Offset: 0x32C0D1 VA: 0x32BFD0
	|-Array.InternalEnumerator<TouchScreenState4>..ctor
	|
	|-RVA: 0x32C0B0 Offset: 0x32C1B1 VA: 0x32C0B0
	|-Array.InternalEnumerator<TouchScreenState5>..ctor
	|
	|-RVA: 0x32C190 Offset: 0x32C291 VA: 0x32C190
	|-Array.InternalEnumerator<TouchScreenState6>..ctor
	|
	|-RVA: 0x32C270 Offset: 0x32C371 VA: 0x32C270
	|-Array.InternalEnumerator<TouchScreenState7>..ctor
	|
	|-RVA: 0x32C350 Offset: 0x32C451 VA: 0x32C350
	|-Array.InternalEnumerator<TouchScreenState8>..ctor
	|
	|-RVA: 0x32C430 Offset: 0x32C531 VA: 0x32C430
	|-Array.InternalEnumerator<TouchScreenState9>..ctor
	|
	|-RVA: 0x32C510 Offset: 0x32C611 VA: 0x32C510
	|-Array.InternalEnumerator<TouchState>..ctor
	|
	|-RVA: 0x32C5F0 Offset: 0x32C6F1 VA: 0x32C5F0
	|-Array.InternalEnumerator<VibrationDeviceHandle>..ctor
	|
	|-RVA: 0x32C760 Offset: 0x32C861 VA: 0x32C760
	|-Array.InternalEnumerator<VibrationDeviceInfo>..ctor
	|
	|-RVA: 0x32C8C0 Offset: 0x32C9C1 VA: 0x32C8C0
	|-Array.InternalEnumerator<VibrationValue>..ctor
	|
	|-RVA: 0x32C9A0 Offset: 0x32CAA1 VA: 0x32C9A0
	|-Array.InternalEnumerator<ClusteringData>..ctor
	|
	|-RVA: 0x32CA80 Offset: 0x32CB81 VA: 0x32CA80
	|-Array.InternalEnumerator<ClusteringProcessorState>..ctor
	|
	|-RVA: 0x32CB60 Offset: 0x32CC61 VA: 0x32CB60
	|-Array.InternalEnumerator<Finger>..ctor
	|
	|-RVA: 0x32CC40 Offset: 0x32CD41 VA: 0x32CC40
	|-Array.InternalEnumerator<Hand>..ctor
	|
	|-RVA: 0x32CD20 Offset: 0x32CE21 VA: 0x32CD20
	|-Array.InternalEnumerator<HandAnalysisImageState>..ctor
	|
	|-RVA: 0x32CE00 Offset: 0x32CF01 VA: 0x32CE00
	|-Array.InternalEnumerator<HandAnalysisSilhouetteState>..ctor
	|
	|-RVA: 0x32CEE0 Offset: 0x32CFE1 VA: 0x32CEE0
	|-Array.InternalEnumerator<MomentProcessorState>..ctor
	|
	|-RVA: 0x32CFC0 Offset: 0x32D0C1 VA: 0x32CFC0
	|-Array.InternalEnumerator<MomentStatistic>..ctor
	|
	|-RVA: 0x32D0A0 Offset: 0x32D1A1 VA: 0x32D0A0
	|-Array.InternalEnumerator<Protrusion>..ctor
	|
	|-RVA: 0x32D200 Offset: 0x32D301 VA: 0x32D200
	|-Array.InternalEnumerator<Shape>..ctor
	|
	|-RVA: 0x32D2E0 Offset: 0x32D3E1 VA: 0x32D2E0
	|-Array.InternalEnumerator<DictionaryInfo>..ctor
	|
	|-RVA: 0x32D440 Offset: 0x32D541 VA: 0x32D440
	|-Array.InternalEnumerator<UserWord>..ctor
	|
	|-RVA: 0x32D520 Offset: 0x32D621 VA: 0x32D520
	|-Array.InternalEnumerator<Color4u8>..ctor
	|
	|-RVA: 0x32D690 Offset: 0x32D791 VA: 0x32D690
	|-Array.InternalEnumerator<Float2>..ctor
	|
	|-RVA: 0x32D770 Offset: 0x32D871 VA: 0x32D770
	|-Array.InternalEnumerator<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BE0 Offset: 0x315CE1 VA: 0x315BE0
	|-Array.InternalEnumerator<AS_ToolController.ChargeInfo>.Dispose
	|
	|-RVA: 0x315CC0 Offset: 0x315DC1 VA: 0x315CC0
	|-Array.InternalEnumerator<ActionCommandDataTable>.Dispose
	|
	|-RVA: 0x315DA0 Offset: 0x315EA1 VA: 0x315DA0
	|-Array.InternalEnumerator<AdvScriptDefCountParam>.Dispose
	|
	|-RVA: 0x315E80 Offset: 0x315F81 VA: 0x315E80
	|-Array.InternalEnumerator<JSONDeserialization.TaskField>.Dispose
	|
	|-RVA: 0x315F60 Offset: 0x316061 VA: 0x315F60
	|-Array.InternalEnumerator<BitVector32Int>.Dispose
	|
	|-RVA: 0x3160D0 Offset: 0x3161D1 VA: 0x3160D0
	|-Array.InternalEnumerator<BuildItemData>.Dispose
	|
	|-RVA: 0x3161B0 Offset: 0x3162B1 VA: 0x3161B0
	|-Array.InternalEnumerator<ButtonLinker.LinkObject>.Dispose
	|
	|-RVA: 0x316290 Offset: 0x316391 VA: 0x316290
	|-Array.InternalEnumerator<CharaCallTable.BustupTable>.Dispose
	|
	|-RVA: 0x316370 Offset: 0x316471 VA: 0x316370
	|-Array.InternalEnumerator<CharaCallTable.CharaFaceIconTable>.Dispose
	|
	|-RVA: 0x316460 Offset: 0x316561 VA: 0x316460
	|-Array.InternalEnumerator<CameraState.CustomBlendable>.Dispose
	|
	|-RVA: 0x316540 Offset: 0x316641 VA: 0x316540
	|-Array.InternalEnumerator<CinemachineBlendListCamera.Instruction>.Dispose
	|
	|-RVA: 0x316620 Offset: 0x316721 VA: 0x316620
	|-Array.InternalEnumerator<CinemachineBlenderSettings.CustomBlend>.Dispose
	|
	|-RVA: 0x316700 Offset: 0x316801 VA: 0x316700
	|-Array.InternalEnumerator<CinemachineClearShot.Pair>.Dispose
	|
	|-RVA: 0x316860 Offset: 0x316961 VA: 0x316860
	|-Array.InternalEnumerator<CinemachineFreeLook.Orbit>.Dispose
	|
	|-RVA: 0x316940 Offset: 0x316A41 VA: 0x316940
	|-Array.InternalEnumerator<CinemachinePath.Waypoint>.Dispose
	|
	|-RVA: 0x316A20 Offset: 0x316B21 VA: 0x316A20
	|-Array.InternalEnumerator<CinemachineSmoothPath.Waypoint>.Dispose
	|
	|-RVA: 0x316B00 Offset: 0x316C01 VA: 0x316B00
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.HashPair>.Dispose
	|
	|-RVA: 0x316C60 Offset: 0x316D61 VA: 0x316C60
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.Instruction>.Dispose
	|
	|-RVA: 0x316D40 Offset: 0x316E41 VA: 0x316D40
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.Dispose
	|
	|-RVA: 0x316EA0 Offset: 0x316FA1 VA: 0x316EA0
	|-Array.InternalEnumerator<CinemachineTargetGroup.Target>.Dispose
	|
	|-RVA: 0x316F80 Offset: 0x317081 VA: 0x316F80
	|-Array.InternalEnumerator<NoiseSettings.TransformNoiseParams>.Dispose
	|
	|-RVA: 0x317060 Offset: 0x317161 VA: 0x317060
	|-Array.InternalEnumerator<TargetPositionCache.CacheCurve.Item>.Dispose
	|
	|-RVA: 0x317140 Offset: 0x317241 VA: 0x317140
	|-Array.InternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.Dispose
	|
	|-RVA: 0x317220 Offset: 0x317321 VA: 0x317220
	|-Array.InternalEnumerator<HeadingTracker.Item>.Dispose
	|
	|-RVA: 0x317300 Offset: 0x317401 VA: 0x317300
	|-Array.InternalEnumerator<CropDataTable>.Dispose
	|
	|-RVA: 0x3173E0 Offset: 0x3174E1 VA: 0x3173E0
	|-Array.InternalEnumerator<ControlPoint>.Dispose
	|
	|-RVA: 0x3174C0 Offset: 0x3175C1 VA: 0x3174C0
	|-Array.InternalEnumerator<DamageTextInfo>.Dispose
	|
	|-RVA: 0x3175A0 Offset: 0x3176A1 VA: 0x3175A0
	|-Array.InternalEnumerator<UIEMDefine.CategoryDataSet>.Dispose
	|
	|-RVA: 0x317680 Offset: 0x317781 VA: 0x317680
	|-Array.InternalEnumerator<DropItemParam>.Dispose
	|
	|-RVA: 0x3177E0 Offset: 0x3178E1 VA: 0x3177E0
	|-Array.InternalEnumerator<DropTableElement>.Dispose
	|
	|-RVA: 0x3178C0 Offset: 0x3179C1 VA: 0x3178C0
	|-Array.InternalEnumerator<EffectDataTable>.Dispose
	|
	|-RVA: 0x3179A0 Offset: 0x317AA1 VA: 0x3179A0
	|-Array.InternalEnumerator<EnemyPatrolPoints>.Dispose
	|
	|-RVA: 0x317B00 Offset: 0x317C01 VA: 0x317B00
	|-Array.InternalEnumerator<Coord>.Dispose
	|
	|-RVA: 0x317C60 Offset: 0x317D61 VA: 0x317C60
	|-Array.InternalEnumerator<ErosionBrush.UndoStep>.Dispose
	|
	|-RVA: 0x317D40 Offset: 0x317E41 VA: 0x317D40
	|-Array.InternalEnumerator<EventCheckId>.Dispose
	|
	|-RVA: 0x317E20 Offset: 0x317F21 VA: 0x317E20
	|-Array.InternalEnumerator<EventFlagProgressData>.Dispose
	|
	|-RVA: 0x317F00 Offset: 0x318001 VA: 0x317F00
	|-Array.InternalEnumerator<EyeMouthAnimate.EMAnimSet>.Dispose
	|
	|-RVA: 0x318060 Offset: 0x318161 VA: 0x318060
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_PARAM>.Dispose
	|
	|-RVA: 0x318140 Offset: 0x318241 VA: 0x318140
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE>.Dispose
	|
	|-RVA: 0x318220 Offset: 0x318321 VA: 0x318220
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.Dispose
	|
	|-RVA: 0x318300 Offset: 0x318401 VA: 0x318300
	|-Array.InternalEnumerator<FarmManager.RF4_MCROP_INFO>.Dispose
	|
	|-RVA: 0x3183F0 Offset: 0x3184F1 VA: 0x3183F0
	|-Array.InternalEnumerator<FarmManager.RF4_SOIL_INFO>.Dispose
	|
	|-RVA: 0x3184D0 Offset: 0x3185D1 VA: 0x3184D0
	|-Array.InternalEnumerator<FesNpcScoreData>.Dispose
	|
	|-RVA: 0x3185B0 Offset: 0x3186B1 VA: 0x3185B0
	|-Array.InternalEnumerator<FieldHideItemSpawnDataTable>.Dispose
	|
	|-RVA: 0x318690 Offset: 0x318791 VA: 0x318690
	|-Array.InternalEnumerator<FieldItemSpawnDataTable>.Dispose
	|
	|-RVA: 0x318770 Offset: 0x318871 VA: 0x318770
	|-Array.InternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.Dispose
	|
	|-RVA: 0x318850 Offset: 0x318951 VA: 0x318850
	|-Array.InternalEnumerator<FieldSceneData.Data>.Dispose
	|
	|-RVA: 0x318930 Offset: 0x318A31 VA: 0x318930
	|-Array.InternalEnumerator<FieldTreasureBoxItemData>.Dispose
	|
	|-RVA: 0x318AA0 Offset: 0x318BA1 VA: 0x318AA0
	|-Array.InternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.Dispose
	|
	|-RVA: 0x318B80 Offset: 0x318C81 VA: 0x318B80
	|-Array.InternalEnumerator<FieldWoodBoxSpawnDataTable>.Dispose
	|
	|-RVA: 0x318C60 Offset: 0x318D61 VA: 0x318C60
	|-Array.InternalEnumerator<FocusObjectDataTable>.Dispose
	|
	|-RVA: 0x318D40 Offset: 0x318E41 VA: 0x318D40
	|-Array.InternalEnumerator<FurnitureData>.Dispose
	|
	|-RVA: 0x318E20 Offset: 0x318F21 VA: 0x318E20
	|-Array.InternalEnumerator<GateDataTable>.Dispose
	|
	|-RVA: 0x318F00 Offset: 0x319001 VA: 0x318F00
	|-Array.InternalEnumerator<GateStatusDataTable>.Dispose
	|
	|-RVA: 0x318FE0 Offset: 0x3190E1 VA: 0x318FE0
	|-Array.InternalEnumerator<GimmickLayoutDataTable>.Dispose
	|
	|-RVA: 0x319150 Offset: 0x319251 VA: 0x319150
	|-Array.InternalEnumerator<HitResult>.Dispose
	|
	|-RVA: 0x319230 Offset: 0x319331 VA: 0x319230
	|-Array.InternalEnumerator<ImagePaneDatas.ImagePaneData>.Dispose
	|
	|-RVA: 0x319310 Offset: 0x319411 VA: 0x319310
	|-Array.InternalEnumerator<FurnitureManager.SendPos>.Dispose
	|
	|-RVA: 0x3193F0 Offset: 0x3194F1 VA: 0x3193F0
	|-Array.InternalEnumerator<ItemLevelData>.Dispose
	|
	|-RVA: 0x319550 Offset: 0x319651 VA: 0x319550
	|-Array.InternalEnumerator<MapDatas.MapData>.Dispose
	|
	|-RVA: 0x319630 Offset: 0x319731 VA: 0x319630
	|-Array.InternalEnumerator<MapObjectDatas.MapObjectData>.Dispose
	|
	|-RVA: 0x319710 Offset: 0x319811 VA: 0x319710
	|-Array.InternalEnumerator<ByteArrayStringHashTable.Entry>.Dispose
	|
	|-RVA: 0x3197F0 Offset: 0x3198F1 VA: 0x3197F0
	|-Array.InternalEnumerator<MineTypeDataTable>.Dispose
	|
	|-RVA: 0x3198D0 Offset: 0x3199D1 VA: 0x3198D0
	|-Array.InternalEnumerator<MiningDataTable>.Dispose
	|
	|-RVA: 0x3199B0 Offset: 0x319AB1 VA: 0x3199B0
	|-Array.InternalEnumerator<MiningPointSaveData>.Dispose
	|
	|-RVA: 0x319A90 Offset: 0x319B91 VA: 0x319A90
	|-Array.InternalEnumerator<CodePointIndexer.TableRange>.Dispose
	|
	|-RVA: 0x319B70 Offset: 0x319C71 VA: 0x319B70
	|-Array.InternalEnumerator<MonsterBehaviorDataTable>.Dispose
	|
	|-RVA: 0x319C50 Offset: 0x319D51 VA: 0x319C50
	|-Array.InternalEnumerator<MonsterDataTable>.Dispose
	|
	|-RVA: 0x319D30 Offset: 0x319E31 VA: 0x319D30
	|-Array.InternalEnumerator<MonsterDropItemDataTable>.Dispose
	|
	|-RVA: 0x319E10 Offset: 0x319F11 VA: 0x319E10
	|-Array.InternalEnumerator<MonsterFootStepEventDataTable>.Dispose
	|
	|-RVA: 0x319EF0 Offset: 0x319FF1 VA: 0x319EF0
	|-Array.InternalEnumerator<MonsterHutSaveData>.Dispose
	|
	|-RVA: 0x319FD0 Offset: 0x31A0D1 VA: 0x319FD0
	|-Array.InternalEnumerator<MonsterUIData.Data>.Dispose
	|
	|-RVA: 0x31A0B0 Offset: 0x31A1B1 VA: 0x31A0B0
	|-Array.InternalEnumerator<MonsterYieldItemDataTable>.Dispose
	|
	|-RVA: 0x31A190 Offset: 0x31A291 VA: 0x31A190
	|-Array.InternalEnumerator<MoviePlayer.SUBTITLEDATA>.Dispose
	|
	|-RVA: 0x31A270 Offset: 0x31A371 VA: 0x31A270
	|-Array.InternalEnumerator<NPCActionData>.Dispose
	|
	|-RVA: 0x31A350 Offset: 0x31A451 VA: 0x31A350
	|-Array.InternalEnumerator<NPCCallingNameTextData.Data>.Dispose
	|
	|-RVA: 0x31A430 Offset: 0x31A531 VA: 0x31A430
	|-Array.InternalEnumerator<NPCUIData.Data>.Dispose
	|
	|-RVA: 0x31A510 Offset: 0x31A611 VA: 0x31A510
	|-Array.InternalEnumerator<NpcPlaceSchedule>.Dispose
	|
	|-RVA: 0x31A5F0 Offset: 0x31A6F1 VA: 0x31A5F0
	|-Array.InternalEnumerator<OrderLotterySaveParameter>.Dispose
	|
	|-RVA: 0x31A6E0 Offset: 0x31A7E1 VA: 0x31A6E0
	|-Array.InternalEnumerator<OrderSaveData>.Dispose
	|
	|-RVA: 0x31A7C0 Offset: 0x31A8C1 VA: 0x31A7C0
	|-Array.InternalEnumerator<OrderSaveParameter>.Dispose
	|
	|-RVA: 0x31A8A0 Offset: 0x31A9A1 VA: 0x31A8A0
	|-Array.InternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.Dispose
	|
	|-RVA: 0x31A980 Offset: 0x31AA81 VA: 0x31A980
	|-Array.InternalEnumerator<Parameter>.Dispose
	|
	|-RVA: 0x31AA60 Offset: 0x31AB61 VA: 0x31AA60
	|-Array.InternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.Dispose
	|
	|-RVA: 0x31AB40 Offset: 0x31AC41 VA: 0x31AB40
	|-Array.InternalEnumerator<PlayerCallingNameTextData.Data>.Dispose
	|
	|-RVA: 0x31AC20 Offset: 0x31AD21 VA: 0x31AC20
	|-Array.InternalEnumerator<ShopCatalogPage>.Dispose
	|
	|-RVA: 0x31AD00 Offset: 0x31AE01 VA: 0x31AD00
	|-Array.InternalEnumerator<ShopNpcTalk>.Dispose
	|
	|-RVA: 0x31ADE0 Offset: 0x31AEE1 VA: 0x31ADE0
	|-Array.InternalEnumerator<SubtitleDataTable.Data>.Dispose
	|
	|-RVA: 0x31AED0 Offset: 0x31AFD1 VA: 0x31AED0
	|-Array.InternalEnumerator<SubtitleDataTable.DataList>.Dispose
	|
	|-RVA: 0x3219C0 Offset: 0x321AC1 VA: 0x3219C0
	|-Array.InternalEnumerator<SubtitleHudDataTable.Data>.Dispose
	|
	|-RVA: 0x321AB0 Offset: 0x321BB1 VA: 0x321AB0
	|-Array.InternalEnumerator<AnimationWarping.Warp>.Dispose
	|
	|-RVA: 0x321B90 Offset: 0x321C91 VA: 0x321B90
	|-Array.InternalEnumerator<GrounderQuadruped.Foot>.Dispose
	|
	|-RVA: 0x321C70 Offset: 0x321D71 VA: 0x321C70
	|-Array.InternalEnumerator<IKSolverLimb.AxisDirection>.Dispose
	|
	|-RVA: 0x321D50 Offset: 0x321E51 VA: 0x321D50
	|-Array.InternalEnumerator<ProfilerFrame>.Dispose
	|
	|-RVA: 0x321E30 Offset: 0x321F31 VA: 0x321E30
	|-Array.InternalEnumerator<NumberControl.ValueRange>.Dispose
	|
	|-RVA: 0x321F10 Offset: 0x322011 VA: 0x321F10
	|-Array.InternalEnumerator<SRMonoBehaviourEx.FieldInfo>.Dispose
	|
	|-RVA: 0x321FF0 Offset: 0x3220F1 VA: 0x321FF0
	|-Array.InternalEnumerator<ResponsiveEnable.Entry>.Dispose
	|
	|-RVA: 0x3220D0 Offset: 0x3221D1 VA: 0x3220D0
	|-Array.InternalEnumerator<ResponsiveResize.Element.SizeDefinition>.Dispose
	|
	|-RVA: 0x3221B0 Offset: 0x3222B1 VA: 0x3221B0
	|-Array.InternalEnumerator<ResponsiveResize.Element>.Dispose
	|
	|-RVA: 0x322290 Offset: 0x322391 VA: 0x322290
	|-Array.InternalEnumerator<Schedule>.Dispose
	|
	|-RVA: 0x322370 Offset: 0x322471 VA: 0x322370
	|-Array.InternalEnumerator<SimpleAnimationPlayable.QueuedState>.Dispose
	|
	|-RVA: 0x322450 Offset: 0x322551 VA: 0x322450
	|-Array.InternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.Dispose
	|
	|-RVA: 0x322540 Offset: 0x322641 VA: 0x322540
	|-Array.InternalEnumerator<SpeedData>.Dispose
	|
	|-RVA: 0x3226A0 Offset: 0x3227A1 VA: 0x3226A0
	|-Array.InternalEnumerator<CurveSample>.Dispose
	|
	|-RVA: 0x322780 Offset: 0x322881 VA: 0x322780
	|-Array.InternalEnumerator<StatusPageSetParameter.ElementParameterText>.Dispose
	|
	|-RVA: 0x3228E0 Offset: 0x3229E1 VA: 0x3228E0
	|-Array.InternalEnumerator<StringFormatData.FormatData>.Dispose
	|
	|-RVA: 0x3229C0 Offset: 0x322AC1 VA: 0x3229C0
	|-Array.InternalEnumerator<ArraySegment<ProfilerFrame>>.Dispose
	|
	|-RVA: 0x322AA0 Offset: 0x322BA1 VA: 0x322AA0
	|-Array.InternalEnumerator<ArraySegment<byte>>.Dispose
	|
	|-RVA: 0x322B80 Offset: 0x322C81 VA: 0x322B80
	|-Array.InternalEnumerator<ArraySegment<object>>.Dispose
	|
	|-RVA: 0x322C60 Offset: 0x322D61 VA: 0x322C60
	|-Array.InternalEnumerator<bool>.Dispose
	|
	|-RVA: 0x322D40 Offset: 0x322E41 VA: 0x322D40
	|-Array.InternalEnumerator<byte>.Dispose
	|
	|-RVA: 0x322EA0 Offset: 0x322FA1 VA: 0x322EA0
	|-Array.InternalEnumerator<ByteEnum>.Dispose
	|
	|-RVA: 0x323000 Offset: 0x323101 VA: 0x323000
	|-Array.InternalEnumerator<char>.Dispose
	|
	|-RVA: 0x323160 Offset: 0x323261 VA: 0x323160
	|-Array.InternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.Dispose
	|
	|-RVA: 0x323240 Offset: 0x323341 VA: 0x323240
	|-Array.InternalEnumerator<DictionaryEntry>.Dispose
	|
	|-RVA: 0x323320 Offset: 0x323421 VA: 0x323320
	|-Array.InternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.Dispose
	|
	|-RVA: 0x323400 Offset: 0x323501 VA: 0x323400
	|-Array.InternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.Dispose
	|
	|-RVA: 0x3234E0 Offset: 0x3235E1 VA: 0x3234E0
	|-Array.InternalEnumerator<Dictionary.Entry<EventCheckId, object>>.Dispose
	|
	|-RVA: 0x3235C0 Offset: 0x3236C1 VA: 0x3235C0
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.Dispose
	|
	|-RVA: 0x3236A0 Offset: 0x3237A1 VA: 0x3236A0
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.Dispose
	|
	|-RVA: 0x323780 Offset: 0x323881 VA: 0x323780
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.Dispose
	|
	|-RVA: 0x323860 Offset: 0x323961 VA: 0x323860
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.Dispose
	|
	|-RVA: 0x323940 Offset: 0x323A41 VA: 0x323940
	|-Array.InternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.Dispose
	|
	|-RVA: 0x323A20 Offset: 0x323B21 VA: 0x323A20
	|-Array.InternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.Dispose
	|
	|-RVA: 0x323B00 Offset: 0x323C01 VA: 0x323B00
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.Dispose
	|
	|-RVA: 0x323BE0 Offset: 0x323CE1 VA: 0x323BE0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.Dispose
	|
	|-RVA: 0x323CC0 Offset: 0x323DC1 VA: 0x323CC0
	|-Array.InternalEnumerator<Dictionary.Entry<Parameter, object>>.Dispose
	|
	|-RVA: 0x323DA0 Offset: 0x323EA1 VA: 0x323DA0
	|-Array.InternalEnumerator<Dictionary.Entry<bool, object>>.Dispose
	|
	|-RVA: 0x323E80 Offset: 0x323F81 VA: 0x323E80
	|-Array.InternalEnumerator<Dictionary.Entry<byte, object>>.Dispose
	|
	|-RVA: 0x323F60 Offset: 0x324061 VA: 0x323F60
	|-Array.InternalEnumerator<Dictionary.Entry<char, object>>.Dispose
	|
	|-RVA: 0x324040 Offset: 0x324141 VA: 0x324040
	|-Array.InternalEnumerator<Dictionary.Entry<DateTime, object>>.Dispose
	|
	|-RVA: 0x324120 Offset: 0x324221 VA: 0x324120
	|-Array.InternalEnumerator<Dictionary.Entry<double, object>>.Dispose
	|
	|-RVA: 0x324200 Offset: 0x324301 VA: 0x324200
	|-Array.InternalEnumerator<Dictionary.Entry<Guid, object>>.Dispose
	|
	|-RVA: 0x3242E0 Offset: 0x3243E1 VA: 0x3242E0
	|-Array.InternalEnumerator<Dictionary.Entry<short, object>>.Dispose
	|
	|-RVA: 0x3243C0 Offset: 0x3244C1 VA: 0x3243C0
	|-Array.InternalEnumerator<Dictionary.Entry<int, CropDataTable>>.Dispose
	|
	|-RVA: 0x3244A0 Offset: 0x3245A1 VA: 0x3244A0
	|-Array.InternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.Dispose
	|
	|-RVA: 0x324580 Offset: 0x324681 VA: 0x324580
	|-Array.InternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.Dispose
	|
	|-RVA: 0x324660 Offset: 0x324761 VA: 0x324660
	|-Array.InternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.Dispose
	|
	|-RVA: 0x324740 Offset: 0x324841 VA: 0x324740
	|-Array.InternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.Dispose
	|
	|-RVA: 0x324820 Offset: 0x324921 VA: 0x324820
	|-Array.InternalEnumerator<Dictionary.Entry<int, bool>>.Dispose
	|
	|-RVA: 0x324900 Offset: 0x324A01 VA: 0x324900
	|-Array.InternalEnumerator<Dictionary.Entry<int, char>>.Dispose
	|
	|-RVA: 0x3249E0 Offset: 0x324AE1 VA: 0x3249E0
	|-Array.InternalEnumerator<Dictionary.Entry<int, int>>.Dispose
	|
	|-RVA: 0x324AC0 Offset: 0x324BC1 VA: 0x324AC0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Int32Enum>>.Dispose
	|
	|-RVA: 0x324BA0 Offset: 0x324CA1 VA: 0x324BA0
	|-Array.InternalEnumerator<Dictionary.Entry<int, long>>.Dispose
	|
	|-RVA: 0x324C80 Offset: 0x324D81 VA: 0x324C80
	|-Array.InternalEnumerator<Dictionary.Entry<int, object>>.Dispose
	|
	|-RVA: 0x324D60 Offset: 0x324E61 VA: 0x324D60
	|-Array.InternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.Dispose
	|
	|-RVA: 0x324E40 Offset: 0x324F41 VA: 0x324E40
	|-Array.InternalEnumerator<Dictionary.Entry<int, SceneInstance>>.Dispose
	|
	|-RVA: 0x324F20 Offset: 0x325021 VA: 0x324F20
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector2Int>>.Dispose
	|
	|-RVA: 0x325000 Offset: 0x325101 VA: 0x325000
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector3>>.Dispose
	|
	|-RVA: 0x3250E0 Offset: 0x3251E1 VA: 0x3250E0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.Dispose
	|
	|-RVA: 0x3251C0 Offset: 0x3252C1 VA: 0x3251C0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.Dispose
	|
	|-RVA: 0x3252A0 Offset: 0x3253A1 VA: 0x3252A0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.Dispose
	|
	|-RVA: 0x325380 Offset: 0x325481 VA: 0x325380
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.Dispose
	|
	|-RVA: 0x325460 Offset: 0x325561 VA: 0x325460
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.Dispose
	|
	|-RVA: 0x325540 Offset: 0x325641 VA: 0x325540
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x325620 Offset: 0x325721 VA: 0x325620
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x325700 Offset: 0x325801 VA: 0x325700
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x3257E0 Offset: 0x3258E1 VA: 0x3257E0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, float>>.Dispose
	|
	|-RVA: 0x3258C0 Offset: 0x3259C1 VA: 0x3258C0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.Dispose
	|
	|-RVA: 0x3259A0 Offset: 0x325AA1 VA: 0x3259A0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.Dispose
	|
	|-RVA: 0x325A80 Offset: 0x325B81 VA: 0x325A80
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.Dispose
	|
	|-RVA: 0x325B60 Offset: 0x325C61 VA: 0x325B60
	|-Array.InternalEnumerator<Dictionary.Entry<long, object>>.Dispose
	|
	|-RVA: 0x325C40 Offset: 0x325D41 VA: 0x325C40
	|-Array.InternalEnumerator<Dictionary.Entry<Memory<object>, object>>.Dispose
	|
	|-RVA: 0x325D20 Offset: 0x325E21 VA: 0x325D20
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.Dispose
	|
	|-RVA: 0x325E00 Offset: 0x325F01 VA: 0x325E00
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.Dispose
	|
	|-RVA: 0x325EE0 Offset: 0x325FE1 VA: 0x325EE0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.Dispose
	|
	|-RVA: 0x325FC0 Offset: 0x3260C1 VA: 0x325FC0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.Dispose
	|
	|-RVA: 0x3260A0 Offset: 0x3261A1 VA: 0x3260A0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.Dispose
	|
	|-RVA: 0x326180 Offset: 0x326281 VA: 0x326180
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.Dispose
	|
	|-RVA: 0x326260 Offset: 0x326361 VA: 0x326260
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.Dispose
	|
	|-RVA: 0x326340 Offset: 0x326441 VA: 0x326340
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.Dispose
	|
	|-RVA: 0x326420 Offset: 0x326521 VA: 0x326420
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.Dispose
	|
	|-RVA: 0x326500 Offset: 0x326601 VA: 0x326500
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.Dispose
	|
	|-RVA: 0x3265E0 Offset: 0x3266E1 VA: 0x3265E0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.Dispose
	|
	|-RVA: 0x3266C0 Offset: 0x3267C1 VA: 0x3266C0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.Dispose
	|
	|-RVA: 0x3267A0 Offset: 0x3268A1 VA: 0x3267A0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.Dispose
	|
	|-RVA: 0x326880 Offset: 0x326981 VA: 0x326880
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.Dispose
	|
	|-RVA: 0x326960 Offset: 0x326A61 VA: 0x326960
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.Dispose
	|
	|-RVA: 0x326A40 Offset: 0x326B41 VA: 0x326A40
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.Dispose
	|
	|-RVA: 0x326B20 Offset: 0x326C21 VA: 0x326B20
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.Dispose
	|
	|-RVA: 0x326C00 Offset: 0x326D01 VA: 0x326C00
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.Dispose
	|
	|-RVA: 0x326CE0 Offset: 0x326DE1 VA: 0x326CE0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.Dispose
	|
	|-RVA: 0x326DC0 Offset: 0x326EC1 VA: 0x326DC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.Dispose
	|
	|-RVA: 0x326EA0 Offset: 0x326FA1 VA: 0x326EA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, EventCheckId>>.Dispose
	|
	|-RVA: 0x326F80 Offset: 0x327081 VA: 0x326F80
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.Dispose
	|
	|-RVA: 0x327060 Offset: 0x327161 VA: 0x327060
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.Dispose
	|
	|-RVA: 0x327140 Offset: 0x327241 VA: 0x327140
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.Dispose
	|
	|-RVA: 0x327220 Offset: 0x327321 VA: 0x327220
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.Dispose
	|
	|-RVA: 0x327300 Offset: 0x327401 VA: 0x327300
	|-Array.InternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.Dispose
	|
	|-RVA: 0x3273E0 Offset: 0x3274E1 VA: 0x3273E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.Dispose
	|
	|-RVA: 0x3274C0 Offset: 0x3275C1 VA: 0x3274C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.Dispose
	|
	|-RVA: 0x3275A0 Offset: 0x3276A1 VA: 0x3275A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.Dispose
	|
	|-RVA: 0x327680 Offset: 0x327781 VA: 0x327680
	|-Array.InternalEnumerator<Dictionary.Entry<object, Parameter>>.Dispose
	|
	|-RVA: 0x327760 Offset: 0x327861 VA: 0x327760
	|-Array.InternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.Dispose
	|
	|-RVA: 0x327840 Offset: 0x327941 VA: 0x327840
	|-Array.InternalEnumerator<Dictionary.Entry<object, bool>>.Dispose
	|
	|-RVA: 0x349720 Offset: 0x349821 VA: 0x349720
	|-Array.InternalEnumerator<Dictionary.Entry<object, byte>>.Dispose
	|
	|-RVA: 0x349800 Offset: 0x349901 VA: 0x349800
	|-Array.InternalEnumerator<Dictionary.Entry<object, char>>.Dispose
	|
	|-RVA: 0x3498E0 Offset: 0x3499E1 VA: 0x3498E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, DateTime>>.Dispose
	|
	|-RVA: 0x3499C0 Offset: 0x349AC1 VA: 0x3499C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, double>>.Dispose
	|
	|-RVA: 0x349AA0 Offset: 0x349BA1 VA: 0x349AA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, short>>.Dispose
	|
	|-RVA: 0x349B80 Offset: 0x349C81 VA: 0x349B80
	|-Array.InternalEnumerator<Dictionary.Entry<object, int>>.Dispose
	|
	|-RVA: 0x349C60 Offset: 0x349D61 VA: 0x349C60
	|-Array.InternalEnumerator<Dictionary.Entry<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x349D40 Offset: 0x349E41 VA: 0x349D40
	|-Array.InternalEnumerator<Dictionary.Entry<object, long>>.Dispose
	|
	|-RVA: 0x349E20 Offset: 0x349F21 VA: 0x349E20
	|-Array.InternalEnumerator<Dictionary.Entry<object, Memory<object>>>.Dispose
	|
	|-RVA: 0x349F00 Offset: 0x34A001 VA: 0x349F00
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.Dispose
	|
	|-RVA: 0x349FE0 Offset: 0x34A0E1 VA: 0x349FE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.Dispose
	|
	|-RVA: 0x34A0C0 Offset: 0x34A1C1 VA: 0x34A0C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.Dispose
	|
	|-RVA: 0x34A1A0 Offset: 0x34A2A1 VA: 0x34A1A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.Dispose
	|
	|-RVA: 0x34A280 Offset: 0x34A381 VA: 0x34A280
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.Dispose
	|
	|-RVA: 0x34A360 Offset: 0x34A461 VA: 0x34A360
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.Dispose
	|
	|-RVA: 0x34A440 Offset: 0x34A541 VA: 0x34A440
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.Dispose
	|
	|-RVA: 0x34A520 Offset: 0x34A621 VA: 0x34A520
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.Dispose
	|
	|-RVA: 0x34A600 Offset: 0x34A701 VA: 0x34A600
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.Dispose
	|
	|-RVA: 0x34A6E0 Offset: 0x34A7E1 VA: 0x34A6E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.Dispose
	|
	|-RVA: 0x34A7C0 Offset: 0x34A8C1 VA: 0x34A7C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.Dispose
	|
	|-RVA: 0x34A8A0 Offset: 0x34A9A1 VA: 0x34A8A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.Dispose
	|
	|-RVA: 0x34A980 Offset: 0x34AA81 VA: 0x34A980
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.Dispose
	|
	|-RVA: 0x34AA60 Offset: 0x34AB61 VA: 0x34AA60
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.Dispose
	|
	|-RVA: 0x34AB40 Offset: 0x34AC41 VA: 0x34AB40
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.Dispose
	|
	|-RVA: 0x34AC20 Offset: 0x34AD21 VA: 0x34AC20
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.Dispose
	|
	|-RVA: 0x34AD00 Offset: 0x34AE01 VA: 0x34AD00
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.Dispose
	|
	|-RVA: 0x34ADE0 Offset: 0x34AEE1 VA: 0x34ADE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.Dispose
	|
	|-RVA: 0x34AEC0 Offset: 0x34AFC1 VA: 0x34AEC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.Dispose
	|
	|-RVA: 0x34AFA0 Offset: 0x34B0A1 VA: 0x34AFA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, object>>.Dispose
	|
	|-RVA: 0x34B080 Offset: 0x34B181 VA: 0x34B080
	|-Array.InternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.Dispose
	|
	|-RVA: 0x34B160 Offset: 0x34B261 VA: 0x34B160
	|-Array.InternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.Dispose
	|
	|-RVA: 0x34B240 Offset: 0x34B341 VA: 0x34B240
	|-Array.InternalEnumerator<Dictionary.Entry<object, sbyte>>.Dispose
	|
	|-RVA: 0x34B320 Offset: 0x34B421 VA: 0x34B320
	|-Array.InternalEnumerator<Dictionary.Entry<object, float>>.Dispose
	|
	|-RVA: 0x34B400 Offset: 0x34B501 VA: 0x34B400
	|-Array.InternalEnumerator<Dictionary.Entry<object, ushort>>.Dispose
	|
	|-RVA: 0x34B4E0 Offset: 0x34B5E1 VA: 0x34B4E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, uint>>.Dispose
	|
	|-RVA: 0x34B5C0 Offset: 0x34B6C1 VA: 0x34B5C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, ulong>>.Dispose
	|
	|-RVA: 0x34B6A0 Offset: 0x34B7A1 VA: 0x34B6A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, TransitionTables>>.Dispose
	|
	|-RVA: 0x34B780 Offset: 0x34B881 VA: 0x34B780
	|-Array.InternalEnumerator<Dictionary.Entry<object, Bounds>>.Dispose
	|
	|-RVA: 0x34B860 Offset: 0x34B961 VA: 0x34B860
	|-Array.InternalEnumerator<Dictionary.Entry<object, BoundsInt>>.Dispose
	|
	|-RVA: 0x34B940 Offset: 0x34BA41 VA: 0x34B940
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color32>>.Dispose
	|
	|-RVA: 0x34BA20 Offset: 0x34BB21 VA: 0x34BA20
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color>>.Dispose
	|
	|-RVA: 0x34BB00 Offset: 0x34BC01 VA: 0x34BB00
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x34BBE0 Offset: 0x34BCE1 VA: 0x34BBE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.Dispose
	|
	|-RVA: 0x34BCC0 Offset: 0x34BDC1 VA: 0x34BCC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Keyframe>>.Dispose
	|
	|-RVA: 0x34BDA0 Offset: 0x34BEA1 VA: 0x34BDA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, LayerMask>>.Dispose
	|
	|-RVA: 0x34BE80 Offset: 0x34BF81 VA: 0x34BE80
	|-Array.InternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.Dispose
	|
	|-RVA: 0x34BF60 Offset: 0x34C061 VA: 0x34BF60
	|-Array.InternalEnumerator<Dictionary.Entry<object, Playable>>.Dispose
	|
	|-RVA: 0x34C040 Offset: 0x34C141 VA: 0x34C040
	|-Array.InternalEnumerator<Dictionary.Entry<object, Quaternion>>.Dispose
	|
	|-RVA: 0x34C120 Offset: 0x34C221 VA: 0x34C120
	|-Array.InternalEnumerator<Dictionary.Entry<object, RangeInt>>.Dispose
	|
	|-RVA: 0x34C200 Offset: 0x34C301 VA: 0x34C200
	|-Array.InternalEnumerator<Dictionary.Entry<object, Rect>>.Dispose
	|
	|-RVA: 0x34C2E0 Offset: 0x34C3E1 VA: 0x34C2E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RectInt>>.Dispose
	|
	|-RVA: 0x34C3C0 Offset: 0x34C4C1 VA: 0x34C3C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x34C4A0 Offset: 0x34C5A1 VA: 0x34C4A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.Dispose
	|
	|-RVA: 0x34C580 Offset: 0x34C681 VA: 0x34C580
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2>>.Dispose
	|
	|-RVA: 0x34C660 Offset: 0x34C761 VA: 0x34C660
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2Int>>.Dispose
	|
	|-RVA: 0x34C740 Offset: 0x34C841 VA: 0x34C740
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3>>.Dispose
	|
	|-RVA: 0x34C820 Offset: 0x34C921 VA: 0x34C820
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3Int>>.Dispose
	|
	|-RVA: 0x34C900 Offset: 0x34CA01 VA: 0x34C900
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector4>>.Dispose
	|
	|-RVA: 0x34C9E0 Offset: 0x34CAE1 VA: 0x34C9E0
	|-Array.InternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.Dispose
	|
	|-RVA: 0x34CAC0 Offset: 0x34CBC1 VA: 0x34CAC0
	|-Array.InternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.Dispose
	|
	|-RVA: 0x34CBA0 Offset: 0x34CCA1 VA: 0x34CBA0
	|-Array.InternalEnumerator<Dictionary.Entry<sbyte, object>>.Dispose
	|
	|-RVA: 0x34CC80 Offset: 0x34CD81 VA: 0x34CC80
	|-Array.InternalEnumerator<Dictionary.Entry<float, CurveSample>>.Dispose
	|
	|-RVA: 0x34CD60 Offset: 0x34CE61 VA: 0x34CD60
	|-Array.InternalEnumerator<Dictionary.Entry<float, object>>.Dispose
	|
	|-RVA: 0x34CE40 Offset: 0x34CF41 VA: 0x34CE40
	|-Array.InternalEnumerator<Dictionary.Entry<ushort, object>>.Dispose
	|
	|-RVA: 0x34CF20 Offset: 0x34D021 VA: 0x34CF20
	|-Array.InternalEnumerator<Dictionary.Entry<uint, int>>.Dispose
	|
	|-RVA: 0x34D000 Offset: 0x34D101 VA: 0x34D000
	|-Array.InternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.Dispose
	|
	|-RVA: 0x34D0E0 Offset: 0x34D1E1 VA: 0x34D0E0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, object>>.Dispose
	|
	|-RVA: 0x34D1C0 Offset: 0x34D2C1 VA: 0x34D1C0
	|-Array.InternalEnumerator<Dictionary.Entry<ulong, object>>.Dispose
	|
	|-RVA: 0x34D2A0 Offset: 0x34D3A1 VA: 0x34D2A0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.Dispose
	|
	|-RVA: 0x34D380 Offset: 0x34D481 VA: 0x34D380
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.Dispose
	|
	|-RVA: 0x34D460 Offset: 0x34D561 VA: 0x34D460
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.Dispose
	|
	|-RVA: 0x34D540 Offset: 0x34D641 VA: 0x34D540
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.Dispose
	|
	|-RVA: 0x34D620 Offset: 0x34D721 VA: 0x34D620
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.Dispose
	|
	|-RVA: 0x34D700 Offset: 0x34D801 VA: 0x34D700
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.Dispose
	|
	|-RVA: 0x34D7E0 Offset: 0x34D8E1 VA: 0x34D7E0
	|-Array.InternalEnumerator<Dictionary.Entry<Bounds, object>>.Dispose
	|
	|-RVA: 0x34D8C0 Offset: 0x34D9C1 VA: 0x34D8C0
	|-Array.InternalEnumerator<Dictionary.Entry<BoundsInt, object>>.Dispose
	|
	|-RVA: 0x34D9A0 Offset: 0x34DAA1 VA: 0x34D9A0
	|-Array.InternalEnumerator<Dictionary.Entry<Color, object>>.Dispose
	|
	|-RVA: 0x34DA80 Offset: 0x34DB81 VA: 0x34DA80
	|-Array.InternalEnumerator<Dictionary.Entry<Color32, object>>.Dispose
	|
	|-RVA: 0x34DB60 Offset: 0x34DC61 VA: 0x34DB60
	|-Array.InternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.Dispose
	|
	|-RVA: 0x34DC40 Offset: 0x34DD41 VA: 0x34DC40
	|-Array.InternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.Dispose
	|
	|-RVA: 0x34DD20 Offset: 0x34DE21 VA: 0x34DD20
	|-Array.InternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.Dispose
	|
	|-RVA: 0x34DE00 Offset: 0x34DF01 VA: 0x34DE00
	|-Array.InternalEnumerator<Dictionary.Entry<Keyframe, object>>.Dispose
	|
	|-RVA: 0x34DEE0 Offset: 0x34DFE1 VA: 0x34DEE0
	|-Array.InternalEnumerator<Dictionary.Entry<LayerMask, object>>.Dispose
	|
	|-RVA: 0x34DFC0 Offset: 0x34E0C1 VA: 0x34DFC0
	|-Array.InternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.Dispose
	|
	|-RVA: 0x34E0A0 Offset: 0x34E1A1 VA: 0x34E0A0
	|-Array.InternalEnumerator<Dictionary.Entry<IntVec3, object>>.Dispose
	|
	|-RVA: 0x34E180 Offset: 0x34E281 VA: 0x34E180
	|-Array.InternalEnumerator<Dictionary.Entry<Quaternion, object>>.Dispose
	|
	|-RVA: 0x34E260 Offset: 0x34E361 VA: 0x34E260
	|-Array.InternalEnumerator<Dictionary.Entry<RangeInt, object>>.Dispose
	|
	|-RVA: 0x34E340 Offset: 0x34E441 VA: 0x34E340
	|-Array.InternalEnumerator<Dictionary.Entry<Rect, object>>.Dispose
	|
	|-RVA: 0x34E420 Offset: 0x34E521 VA: 0x34E420
	|-Array.InternalEnumerator<Dictionary.Entry<RectInt, object>>.Dispose
	|
	|-RVA: 0x34E500 Offset: 0x34E601 VA: 0x34E500
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.Dispose
	|
	|-RVA: 0x34E5E0 Offset: 0x34E6E1 VA: 0x34E5E0
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.Dispose
	|
	|-RVA: 0x34E6C0 Offset: 0x34E7C1 VA: 0x34E6C0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2, object>>.Dispose
	|
	|-RVA: 0x34E7A0 Offset: 0x34E8A1 VA: 0x34E7A0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2Int, object>>.Dispose
	|
	|-RVA: 0x34E880 Offset: 0x34E981 VA: 0x34E880
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3, object>>.Dispose
	|
	|-RVA: 0x34E960 Offset: 0x34EA61 VA: 0x34E960
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3Int, object>>.Dispose
	|
	|-RVA: 0x34EA40 Offset: 0x34EB41 VA: 0x34EA40
	|-Array.InternalEnumerator<Dictionary.Entry<Vector4, object>>.Dispose
	|
	|-RVA: 0x34EB20 Offset: 0x34EC21 VA: 0x34EB20
	|-Array.InternalEnumerator<HashSet.Slot<int>>.Dispose
	|
	|-RVA: 0x34EC10 Offset: 0x34ED11 VA: 0x34EC10
	|-Array.InternalEnumerator<HashSet.Slot<Int32Enum>>.Dispose
	|
	|-RVA: 0x34ED00 Offset: 0x34EE01 VA: 0x34ED00
	|-Array.InternalEnumerator<HashSet.Slot<object>>.Dispose
	|
	|-RVA: 0x34EDE0 Offset: 0x34EEE1 VA: 0x34EDE0
	|-Array.InternalEnumerator<HashSet.Slot<uint>>.Dispose
	|
	|-RVA: 0x34EED0 Offset: 0x34EFD1 VA: 0x34EED0
	|-Array.InternalEnumerator<HashSet.Slot<Edge>>.Dispose
	|
	|-RVA: 0x34EFB0 Offset: 0x34F0B1 VA: 0x34EFB0
	|-Array.InternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x34F090 Offset: 0x34F191 VA: 0x34F090
	|-Array.InternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.Dispose
	|
	|-RVA: 0x34F170 Offset: 0x34F271 VA: 0x34F170
	|-Array.InternalEnumerator<KeyValuePair<BitVector32Int, object>>.Dispose
	|
	|-RVA: 0x34F250 Offset: 0x34F351 VA: 0x34F250
	|-Array.InternalEnumerator<KeyValuePair<EventCheckId, object>>.Dispose
	|
	|-RVA: 0x34F330 Offset: 0x34F431 VA: 0x34F330
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.Dispose
	|
	|-RVA: 0x338DB0 Offset: 0x338EB1 VA: 0x338DB0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.Dispose
	|
	|-RVA: 0x338E90 Offset: 0x338F91 VA: 0x338E90
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.Dispose
	|
	|-RVA: 0x338F70 Offset: 0x339071 VA: 0x338F70
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.Dispose
	|
	|-RVA: 0x339050 Offset: 0x339151 VA: 0x339050
	|-Array.InternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.Dispose
	|
	|-RVA: 0x339130 Offset: 0x339231 VA: 0x339130
	|-Array.InternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.Dispose
	|
	|-RVA: 0x339210 Offset: 0x339311 VA: 0x339210
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveData, object>>.Dispose
	|
	|-RVA: 0x3392F0 Offset: 0x3393F1 VA: 0x3392F0
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.Dispose
	|
	|-RVA: 0x3393D0 Offset: 0x3394D1 VA: 0x3393D0
	|-Array.InternalEnumerator<KeyValuePair<Parameter, object>>.Dispose
	|
	|-RVA: 0x3394B0 Offset: 0x3395B1 VA: 0x3394B0
	|-Array.InternalEnumerator<KeyValuePair<bool, object>>.Dispose
	|
	|-RVA: 0x339590 Offset: 0x339691 VA: 0x339590
	|-Array.InternalEnumerator<KeyValuePair<byte, object>>.Dispose
	|
	|-RVA: 0x339670 Offset: 0x339771 VA: 0x339670
	|-Array.InternalEnumerator<KeyValuePair<char, object>>.Dispose
	|
	|-RVA: 0x339750 Offset: 0x339851 VA: 0x339750
	|-Array.InternalEnumerator<KeyValuePair<DateTime, object>>.Dispose
	|
	|-RVA: 0x339830 Offset: 0x339931 VA: 0x339830
	|-Array.InternalEnumerator<KeyValuePair<double, object>>.Dispose
	|
	|-RVA: 0x339910 Offset: 0x339A11 VA: 0x339910
	|-Array.InternalEnumerator<KeyValuePair<Guid, object>>.Dispose
	|
	|-RVA: 0x3399F0 Offset: 0x339AF1 VA: 0x3399F0
	|-Array.InternalEnumerator<KeyValuePair<short, object>>.Dispose
	|
	|-RVA: 0x339AD0 Offset: 0x339BD1 VA: 0x339AD0
	|-Array.InternalEnumerator<KeyValuePair<int, CropDataTable>>.Dispose
	|
	|-RVA: 0x339BB0 Offset: 0x339CB1 VA: 0x339BB0
	|-Array.InternalEnumerator<KeyValuePair<int, EffectDataTable>>.Dispose
	|
	|-RVA: 0x339C90 Offset: 0x339D91 VA: 0x339C90
	|-Array.InternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.Dispose
	|
	|-RVA: 0x339DF0 Offset: 0x339EF1 VA: 0x339DF0
	|-Array.InternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.Dispose
	|
	|-RVA: 0x339ED0 Offset: 0x339FD1 VA: 0x339ED0
	|-Array.InternalEnumerator<KeyValuePair<int, MiningDataTable>>.Dispose
	|
	|-RVA: 0x339FB0 Offset: 0x33A0B1 VA: 0x339FB0
	|-Array.InternalEnumerator<KeyValuePair<int, bool>>.Dispose
	|
	|-RVA: 0x33A110 Offset: 0x33A211 VA: 0x33A110
	|-Array.InternalEnumerator<KeyValuePair<int, char>>.Dispose
	|
	|-RVA: 0x33A270 Offset: 0x33A371 VA: 0x33A270
	|-Array.InternalEnumerator<KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x33A3D0 Offset: 0x33A4D1 VA: 0x33A3D0
	|-Array.InternalEnumerator<KeyValuePair<int, Int32Enum>>.Dispose
	|
	|-RVA: 0x33A530 Offset: 0x33A631 VA: 0x33A530
	|-Array.InternalEnumerator<KeyValuePair<int, long>>.Dispose
	|
	|-RVA: 0x33A610 Offset: 0x33A711 VA: 0x33A610
	|-Array.InternalEnumerator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x33A6F0 Offset: 0x33A7F1 VA: 0x33A6F0
	|-Array.InternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.Dispose
	|
	|-RVA: 0x33A7D0 Offset: 0x33A8D1 VA: 0x33A7D0
	|-Array.InternalEnumerator<KeyValuePair<int, SceneInstance>>.Dispose
	|
	|-RVA: 0x33A8B0 Offset: 0x33A9B1 VA: 0x33A8B0
	|-Array.InternalEnumerator<KeyValuePair<int, Vector2Int>>.Dispose
	|
	|-RVA: 0x33A9A0 Offset: 0x33AAA1 VA: 0x33A9A0
	|-Array.InternalEnumerator<KeyValuePair<int, Vector3>>.Dispose
	|
	|-RVA: 0x33AA80 Offset: 0x33AB81 VA: 0x33AA80
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.Dispose
	|
	|-RVA: 0x33AB60 Offset: 0x33AC61 VA: 0x33AB60
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.Dispose
	|
	|-RVA: 0x33AC40 Offset: 0x33AD41 VA: 0x33AC40
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.Dispose
	|
	|-RVA: 0x33AD20 Offset: 0x33AE21 VA: 0x33AD20
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, bool>>.Dispose
	|
	|-RVA: 0x33AE80 Offset: 0x33AF81 VA: 0x33AE80
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.Dispose
	|
	|-RVA: 0x33AF70 Offset: 0x33B071 VA: 0x33AF70
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x33B0D0 Offset: 0x33B1D1 VA: 0x33B0D0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x33B230 Offset: 0x33B331 VA: 0x33B230
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x33B310 Offset: 0x33B411 VA: 0x33B310
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, float>>.Dispose
	|
	|-RVA: 0x33B470 Offset: 0x33B571 VA: 0x33B470
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.Dispose
	|
	|-RVA: 0x33B550 Offset: 0x33B651 VA: 0x33B550
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.Dispose
	|
	|-RVA: 0x33B640 Offset: 0x33B741 VA: 0x33B640
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.Dispose
	|
	|-RVA: 0x33B720 Offset: 0x33B821 VA: 0x33B720
	|-Array.InternalEnumerator<KeyValuePair<long, object>>.Dispose
	|
	|-RVA: 0x33B800 Offset: 0x33B901 VA: 0x33B800
	|-Array.InternalEnumerator<KeyValuePair<Memory<object>, object>>.Dispose
	|
	|-RVA: 0x33B8E0 Offset: 0x33B9E1 VA: 0x33B8E0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.Dispose
	|
	|-RVA: 0x33B9C0 Offset: 0x33BAC1 VA: 0x33B9C0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.Dispose
	|
	|-RVA: 0x33BAA0 Offset: 0x33BBA1 VA: 0x33BAA0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.Dispose
	|
	|-RVA: 0x33BB80 Offset: 0x33BC81 VA: 0x33BB80
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.Dispose
	|
	|-RVA: 0x33BC60 Offset: 0x33BD61 VA: 0x33BC60
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color>, object>>.Dispose
	|
	|-RVA: 0x33BD40 Offset: 0x33BE41 VA: 0x33BD40
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.Dispose
	|
	|-RVA: 0x33BE20 Offset: 0x33BF21 VA: 0x33BE20
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.Dispose
	|
	|-RVA: 0x33BF00 Offset: 0x33C001 VA: 0x33BF00
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.Dispose
	|
	|-RVA: 0x33BFE0 Offset: 0x33C0E1 VA: 0x33BFE0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.Dispose
	|
	|-RVA: 0x33C0C0 Offset: 0x33C1C1 VA: 0x33C0C0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.Dispose
	|
	|-RVA: 0x33C1A0 Offset: 0x33C2A1 VA: 0x33C1A0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.Dispose
	|
	|-RVA: 0x33C280 Offset: 0x33C381 VA: 0x33C280
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.Dispose
	|
	|-RVA: 0x33C360 Offset: 0x33C461 VA: 0x33C360
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.Dispose
	|
	|-RVA: 0x33C440 Offset: 0x33C541 VA: 0x33C440
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.Dispose
	|
	|-RVA: 0x33C520 Offset: 0x33C621 VA: 0x33C520
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.Dispose
	|
	|-RVA: 0x33C600 Offset: 0x33C701 VA: 0x33C600
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.Dispose
	|
	|-RVA: 0x33C6E0 Offset: 0x33C7E1 VA: 0x33C6E0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.Dispose
	|
	|-RVA: 0x33C7C0 Offset: 0x33C8C1 VA: 0x33C7C0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.Dispose
	|
	|-RVA: 0x33C8A0 Offset: 0x33C9A1 VA: 0x33C8A0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.Dispose
	|
	|-RVA: 0x33C980 Offset: 0x33CA81 VA: 0x33C980
	|-Array.InternalEnumerator<KeyValuePair<object, BitVector32Int>>.Dispose
	|
	|-RVA: 0x33CA60 Offset: 0x33CB61 VA: 0x33CA60
	|-Array.InternalEnumerator<KeyValuePair<object, EventCheckId>>.Dispose
	|
	|-RVA: 0x33CB40 Offset: 0x33CC41 VA: 0x33CB40
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.Dispose
	|
	|-RVA: 0x33CC20 Offset: 0x33CD21 VA: 0x33CC20
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.Dispose
	|
	|-RVA: 0x33CD00 Offset: 0x33CE01 VA: 0x33CD00
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.Dispose
	|
	|-RVA: 0x33CDE0 Offset: 0x33CEE1 VA: 0x33CDE0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.Dispose
	|
	|-RVA: 0x33CEC0 Offset: 0x33CFC1 VA: 0x33CEC0
	|-Array.InternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.Dispose
	|
	|-RVA: 0x33CFA0 Offset: 0x33D0A1 VA: 0x33CFA0
	|-Array.InternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.Dispose
	|
	|-RVA: 0x33D080 Offset: 0x33D181 VA: 0x33D080
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveData>>.Dispose
	|
	|-RVA: 0x33D160 Offset: 0x33D261 VA: 0x33D160
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.Dispose
	|
	|-RVA: 0x33D240 Offset: 0x33D341 VA: 0x33D240
	|-Array.InternalEnumerator<KeyValuePair<object, Parameter>>.Dispose
	|
	|-RVA: 0x33D320 Offset: 0x33D421 VA: 0x33D320
	|-Array.InternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.Dispose
	|
	|-RVA: 0x33D400 Offset: 0x33D501 VA: 0x33D400
	|-Array.InternalEnumerator<KeyValuePair<object, bool>>.Dispose
	|
	|-RVA: 0x33D4E0 Offset: 0x33D5E1 VA: 0x33D4E0
	|-Array.InternalEnumerator<KeyValuePair<object, byte>>.Dispose
	|
	|-RVA: 0x33D5C0 Offset: 0x33D6C1 VA: 0x33D5C0
	|-Array.InternalEnumerator<KeyValuePair<object, char>>.Dispose
	|
	|-RVA: 0x33D6A0 Offset: 0x33D7A1 VA: 0x33D6A0
	|-Array.InternalEnumerator<KeyValuePair<object, DateTime>>.Dispose
	|
	|-RVA: 0x33D780 Offset: 0x33D881 VA: 0x33D780
	|-Array.InternalEnumerator<KeyValuePair<object, double>>.Dispose
	|
	|-RVA: 0x33D860 Offset: 0x33D961 VA: 0x33D860
	|-Array.InternalEnumerator<KeyValuePair<object, short>>.Dispose
	|
	|-RVA: 0x33D940 Offset: 0x33DA41 VA: 0x33D940
	|-Array.InternalEnumerator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x33DA20 Offset: 0x33DB21 VA: 0x33DA20
	|-Array.InternalEnumerator<KeyValuePair<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x33DB00 Offset: 0x33DC01 VA: 0x33DB00
	|-Array.InternalEnumerator<KeyValuePair<object, long>>.Dispose
	|
	|-RVA: 0x33DBE0 Offset: 0x33DCE1 VA: 0x33DBE0
	|-Array.InternalEnumerator<KeyValuePair<object, Memory<object>>>.Dispose
	|
	|-RVA: 0x33DCC0 Offset: 0x33DDC1 VA: 0x33DCC0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.Dispose
	|
	|-RVA: 0x33DDA0 Offset: 0x33DEA1 VA: 0x33DDA0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.Dispose
	|
	|-RVA: 0x33DE80 Offset: 0x33DF81 VA: 0x33DE80
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.Dispose
	|
	|-RVA: 0x33DF60 Offset: 0x33E061 VA: 0x33DF60
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.Dispose
	|
	|-RVA: 0x33E040 Offset: 0x33E141 VA: 0x33E040
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color>>>.Dispose
	|
	|-RVA: 0x33E120 Offset: 0x33E221 VA: 0x33E120
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.Dispose
	|
	|-RVA: 0x33E200 Offset: 0x33E301 VA: 0x33E200
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.Dispose
	|
	|-RVA: 0x33E2E0 Offset: 0x33E3E1 VA: 0x33E2E0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.Dispose
	|
	|-RVA: 0x33E3C0 Offset: 0x33E4C1 VA: 0x33E3C0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.Dispose
	|
	|-RVA: 0x33E4A0 Offset: 0x33E5A1 VA: 0x33E4A0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.Dispose
	|
	|-RVA: 0x33E580 Offset: 0x33E681 VA: 0x33E580
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.Dispose
	|
	|-RVA: 0x33E660 Offset: 0x33E761 VA: 0x33E660
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.Dispose
	|
	|-RVA: 0x33E740 Offset: 0x33E841 VA: 0x33E740
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.Dispose
	|
	|-RVA: 0x33E820 Offset: 0x33E921 VA: 0x33E820
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.Dispose
	|
	|-RVA: 0x33E900 Offset: 0x33EA01 VA: 0x33E900
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.Dispose
	|
	|-RVA: 0x33E9E0 Offset: 0x33EAE1 VA: 0x33E9E0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.Dispose
	|
	|-RVA: 0x33EAC0 Offset: 0x33EBC1 VA: 0x33EAC0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.Dispose
	|
	|-RVA: 0x33EBA0 Offset: 0x33ECA1 VA: 0x33EBA0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.Dispose
	|
	|-RVA: 0x33EC80 Offset: 0x33ED81 VA: 0x33EC80
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.Dispose
	|
	|-RVA: 0x33ED60 Offset: 0x33EE61 VA: 0x33ED60
	|-Array.InternalEnumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x3554D0 Offset: 0x3555D1 VA: 0x3554D0
	|-Array.InternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.Dispose
	|
	|-RVA: 0x3555B0 Offset: 0x3556B1 VA: 0x3555B0
	|-Array.InternalEnumerator<KeyValuePair<object, ResourceLocator>>.Dispose
	|
	|-RVA: 0x355690 Offset: 0x355791 VA: 0x355690
	|-Array.InternalEnumerator<KeyValuePair<object, sbyte>>.Dispose
	|
	|-RVA: 0x355770 Offset: 0x355871 VA: 0x355770
	|-Array.InternalEnumerator<KeyValuePair<object, float>>.Dispose
	|
	|-RVA: 0x355850 Offset: 0x355951 VA: 0x355850
	|-Array.InternalEnumerator<KeyValuePair<object, ushort>>.Dispose
	|
	|-RVA: 0x355930 Offset: 0x355A31 VA: 0x355930
	|-Array.InternalEnumerator<KeyValuePair<object, uint>>.Dispose
	|
	|-RVA: 0x355A10 Offset: 0x355B11 VA: 0x355A10
	|-Array.InternalEnumerator<KeyValuePair<object, ulong>>.Dispose
	|
	|-RVA: 0x355AF0 Offset: 0x355BF1 VA: 0x355AF0
	|-Array.InternalEnumerator<KeyValuePair<object, TransitionTables>>.Dispose
	|
	|-RVA: 0x355BD0 Offset: 0x355CD1 VA: 0x355BD0
	|-Array.InternalEnumerator<KeyValuePair<object, Bounds>>.Dispose
	|
	|-RVA: 0x355CB0 Offset: 0x355DB1 VA: 0x355CB0
	|-Array.InternalEnumerator<KeyValuePair<object, BoundsInt>>.Dispose
	|
	|-RVA: 0x355D90 Offset: 0x355E91 VA: 0x355D90
	|-Array.InternalEnumerator<KeyValuePair<object, Color32>>.Dispose
	|
	|-RVA: 0x355E70 Offset: 0x355F71 VA: 0x355E70
	|-Array.InternalEnumerator<KeyValuePair<object, Color>>.Dispose
	|
	|-RVA: 0x355F50 Offset: 0x356051 VA: 0x355F50
	|-Array.InternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x356030 Offset: 0x356131 VA: 0x356030
	|-Array.InternalEnumerator<KeyValuePair<object, GradientColorKey>>.Dispose
	|
	|-RVA: 0x356110 Offset: 0x356211 VA: 0x356110
	|-Array.InternalEnumerator<KeyValuePair<object, Keyframe>>.Dispose
	|
	|-RVA: 0x3561F0 Offset: 0x3562F1 VA: 0x3561F0
	|-Array.InternalEnumerator<KeyValuePair<object, LayerMask>>.Dispose
	|
	|-RVA: 0x3562D0 Offset: 0x3563D1 VA: 0x3562D0
	|-Array.InternalEnumerator<KeyValuePair<object, Matrix4x4>>.Dispose
	|
	|-RVA: 0x3563B0 Offset: 0x3564B1 VA: 0x3563B0
	|-Array.InternalEnumerator<KeyValuePair<object, Playable>>.Dispose
	|
	|-RVA: 0x356490 Offset: 0x356591 VA: 0x356490
	|-Array.InternalEnumerator<KeyValuePair<object, Quaternion>>.Dispose
	|
	|-RVA: 0x356570 Offset: 0x356671 VA: 0x356570
	|-Array.InternalEnumerator<KeyValuePair<object, RangeInt>>.Dispose
	|
	|-RVA: 0x356650 Offset: 0x356751 VA: 0x356650
	|-Array.InternalEnumerator<KeyValuePair<object, Rect>>.Dispose
	|
	|-RVA: 0x356730 Offset: 0x356831 VA: 0x356730
	|-Array.InternalEnumerator<KeyValuePair<object, RectInt>>.Dispose
	|
	|-RVA: 0x356810 Offset: 0x356911 VA: 0x356810
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x3568F0 Offset: 0x3569F1 VA: 0x3568F0
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.Dispose
	|
	|-RVA: 0x3569D0 Offset: 0x356AD1 VA: 0x3569D0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2>>.Dispose
	|
	|-RVA: 0x356AB0 Offset: 0x356BB1 VA: 0x356AB0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2Int>>.Dispose
	|
	|-RVA: 0x356B90 Offset: 0x356C91 VA: 0x356B90
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3>>.Dispose
	|
	|-RVA: 0x356C70 Offset: 0x356D71 VA: 0x356C70
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3Int>>.Dispose
	|
	|-RVA: 0x356D50 Offset: 0x356E51 VA: 0x356D50
	|-Array.InternalEnumerator<KeyValuePair<object, Vector4>>.Dispose
	|
	|-RVA: 0x356E30 Offset: 0x356F31 VA: 0x356E30
	|-Array.InternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.Dispose
	|
	|-RVA: 0x356F10 Offset: 0x357011 VA: 0x356F10
	|-Array.InternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.Dispose
	|
	|-RVA: 0x356FF0 Offset: 0x3570F1 VA: 0x356FF0
	|-Array.InternalEnumerator<KeyValuePair<sbyte, object>>.Dispose
	|
	|-RVA: 0x3570D0 Offset: 0x3571D1 VA: 0x3570D0
	|-Array.InternalEnumerator<KeyValuePair<float, CurveSample>>.Dispose
	|
	|-RVA: 0x3571B0 Offset: 0x3572B1 VA: 0x3571B0
	|-Array.InternalEnumerator<KeyValuePair<float, object>>.Dispose
	|
	|-RVA: 0x357290 Offset: 0x357391 VA: 0x357290
	|-Array.InternalEnumerator<KeyValuePair<ushort, object>>.Dispose
	|
	|-RVA: 0x357370 Offset: 0x357471 VA: 0x357370
	|-Array.InternalEnumerator<KeyValuePair<uint, int>>.Dispose
	|
	|-RVA: 0x3574D0 Offset: 0x3575D1 VA: 0x3574D0
	|-Array.InternalEnumerator<KeyValuePair<uint, Int32Enum>>.Dispose
	|
	|-RVA: 0x357630 Offset: 0x357731 VA: 0x357630
	|-Array.InternalEnumerator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x357710 Offset: 0x357811 VA: 0x357710
	|-Array.InternalEnumerator<KeyValuePair<ulong, object>>.Dispose
	|
	|-RVA: 0x3577F0 Offset: 0x3578F1 VA: 0x3577F0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.Dispose
	|
	|-RVA: 0x3578E0 Offset: 0x3579E1 VA: 0x3578E0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.Dispose
	|
	|-RVA: 0x3579C0 Offset: 0x357AC1 VA: 0x3579C0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.Dispose
	|
	|-RVA: 0x357AA0 Offset: 0x357BA1 VA: 0x357AA0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.Dispose
	|
	|-RVA: 0x357B80 Offset: 0x357C81 VA: 0x357B80
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.Dispose
	|
	|-RVA: 0x357C70 Offset: 0x357D71 VA: 0x357C70
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.Dispose
	|
	|-RVA: 0x357D50 Offset: 0x357E51 VA: 0x357D50
	|-Array.InternalEnumerator<KeyValuePair<Bounds, object>>.Dispose
	|
	|-RVA: 0x357E30 Offset: 0x357F31 VA: 0x357E30
	|-Array.InternalEnumerator<KeyValuePair<BoundsInt, object>>.Dispose
	|
	|-RVA: 0x357F10 Offset: 0x358011 VA: 0x357F10
	|-Array.InternalEnumerator<KeyValuePair<Color, object>>.Dispose
	|
	|-RVA: 0x357FF0 Offset: 0x3580F1 VA: 0x357FF0
	|-Array.InternalEnumerator<KeyValuePair<Color32, object>>.Dispose
	|
	|-RVA: 0x3580D0 Offset: 0x3581D1 VA: 0x3580D0
	|-Array.InternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.Dispose
	|
	|-RVA: 0x3581B0 Offset: 0x3582B1 VA: 0x3581B0
	|-Array.InternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.Dispose
	|
	|-RVA: 0x358290 Offset: 0x358391 VA: 0x358290
	|-Array.InternalEnumerator<KeyValuePair<GradientColorKey, object>>.Dispose
	|
	|-RVA: 0x358370 Offset: 0x358471 VA: 0x358370
	|-Array.InternalEnumerator<KeyValuePair<Keyframe, object>>.Dispose
	|
	|-RVA: 0x358450 Offset: 0x358551 VA: 0x358450
	|-Array.InternalEnumerator<KeyValuePair<LayerMask, object>>.Dispose
	|
	|-RVA: 0x358530 Offset: 0x358631 VA: 0x358530
	|-Array.InternalEnumerator<KeyValuePair<Matrix4x4, object>>.Dispose
	|
	|-RVA: 0x358610 Offset: 0x358711 VA: 0x358610
	|-Array.InternalEnumerator<KeyValuePair<IntVec3, object>>.Dispose
	|
	|-RVA: 0x3586F0 Offset: 0x3587F1 VA: 0x3586F0
	|-Array.InternalEnumerator<KeyValuePair<Quaternion, object>>.Dispose
	|
	|-RVA: 0x3587D0 Offset: 0x3588D1 VA: 0x3587D0
	|-Array.InternalEnumerator<KeyValuePair<RangeInt, object>>.Dispose
	|
	|-RVA: 0x3588B0 Offset: 0x3589B1 VA: 0x3588B0
	|-Array.InternalEnumerator<KeyValuePair<Rect, object>>.Dispose
	|
	|-RVA: 0x358990 Offset: 0x358A91 VA: 0x358990
	|-Array.InternalEnumerator<KeyValuePair<RectInt, object>>.Dispose
	|
	|-RVA: 0x358A70 Offset: 0x358B71 VA: 0x358A70
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.Dispose
	|
	|-RVA: 0x358B60 Offset: 0x358C61 VA: 0x358B60
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.Dispose
	|
	|-RVA: 0x358C40 Offset: 0x358D41 VA: 0x358C40
	|-Array.InternalEnumerator<KeyValuePair<Vector2, object>>.Dispose
	|
	|-RVA: 0x358D20 Offset: 0x358E21 VA: 0x358D20
	|-Array.InternalEnumerator<KeyValuePair<Vector2Int, object>>.Dispose
	|
	|-RVA: 0x358E00 Offset: 0x358F01 VA: 0x358E00
	|-Array.InternalEnumerator<KeyValuePair<Vector3, object>>.Dispose
	|
	|-RVA: 0x358EE0 Offset: 0x358FE1 VA: 0x358EE0
	|-Array.InternalEnumerator<KeyValuePair<Vector3Int, object>>.Dispose
	|
	|-RVA: 0x358FC0 Offset: 0x3590C1 VA: 0x358FC0
	|-Array.InternalEnumerator<KeyValuePair<Vector4, object>>.Dispose
	|
	|-RVA: 0x3590A0 Offset: 0x3591A1 VA: 0x3590A0
	|-Array.InternalEnumerator<Hashtable.bucket>.Dispose
	|
	|-RVA: 0x359180 Offset: 0x359281 VA: 0x359180
	|-Array.InternalEnumerator<DateTime>.Dispose
	|
	|-RVA: 0x3592E0 Offset: 0x3593E1 VA: 0x3592E0
	|-Array.InternalEnumerator<DateTimeOffset>.Dispose
	|
	|-RVA: 0x3593C0 Offset: 0x3594C1 VA: 0x3593C0
	|-Array.InternalEnumerator<Decimal>.Dispose
	|
	|-RVA: 0x3594A0 Offset: 0x3595A1 VA: 0x3594A0
	|-Array.InternalEnumerator<double>.Dispose
	|
	|-RVA: 0x359600 Offset: 0x359701 VA: 0x359600
	|-Array.InternalEnumerator<InternalCodePageDataItem>.Dispose
	|
	|-RVA: 0x3596E0 Offset: 0x3597E1 VA: 0x3596E0
	|-Array.InternalEnumerator<InternalEncodingDataItem>.Dispose
	|
	|-RVA: 0x3597C0 Offset: 0x3598C1 VA: 0x3597C0
	|-Array.InternalEnumerator<Guid>.Dispose
	|
	|-RVA: 0x3598A0 Offset: 0x3599A1 VA: 0x3598A0
	|-Array.InternalEnumerator<short>.Dispose
	|
	|-RVA: 0x359A00 Offset: 0x359B01 VA: 0x359A00
	|-Array.InternalEnumerator<int>.Dispose
	|
	|-RVA: 0x359B60 Offset: 0x359C61 VA: 0x359B60
	|-Array.InternalEnumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x359CC0 Offset: 0x359DC1 VA: 0x359CC0
	|-Array.InternalEnumerator<long>.Dispose
	|
	|-RVA: 0x359E20 Offset: 0x359F21 VA: 0x359E20
	|-Array.InternalEnumerator<IntPtr>.Dispose
	|
	|-RVA: 0x359F80 Offset: 0x35A081 VA: 0x359F80
	|-Array.InternalEnumerator<InterpretedFrameInfo>.Dispose
	|
	|-RVA: 0x35A060 Offset: 0x35A161 VA: 0x35A060
	|-Array.InternalEnumerator<LocalDefinition>.Dispose
	|
	|-RVA: 0x35A140 Offset: 0x35A241 VA: 0x35A140
	|-Array.InternalEnumerator<RuntimeLabel>.Dispose
	|
	|-RVA: 0x35A230 Offset: 0x35A331 VA: 0x35A230
	|-Array.InternalEnumerator<Set.Slot<int>>.Dispose
	|
	|-RVA: 0x35A320 Offset: 0x35A421 VA: 0x35A320
	|-Array.InternalEnumerator<Set.Slot<object>>.Dispose
	|
	|-RVA: 0x35A400 Offset: 0x35A501 VA: 0x35A400
	|-Array.InternalEnumerator<Memory<object>>.Dispose
	|
	|-RVA: 0x35A4E0 Offset: 0x35A5E1 VA: 0x35A4E0
	|-Array.InternalEnumerator<CookieTokenizer.RecognizedAttribute>.Dispose
	|
	|-RVA: 0x35A5C0 Offset: 0x35A6C1 VA: 0x35A5C0
	|-Array.InternalEnumerator<HeaderVariantInfo>.Dispose
	|
	|-RVA: 0x35A6A0 Offset: 0x35A7A1 VA: 0x35A6A0
	|-Array.InternalEnumerator<Socket.WSABUF>.Dispose
	|
	|-RVA: 0x35A780 Offset: 0x35A881 VA: 0x35A780
	|-Array.InternalEnumerator<Nullable<ReadOnlySequence<byte>>>.Dispose
	|
	|-RVA: 0x35A860 Offset: 0x35A961 VA: 0x35A860
	|-Array.InternalEnumerator<Nullable<Int32Enum>>.Dispose
	|
	|-RVA: 0x35A9C0 Offset: 0x35AAC1 VA: 0x35A9C0
	|-Array.InternalEnumerator<Nullable<Bounds>>.Dispose
	|
	|-RVA: 0x35AAA0 Offset: 0x35ABA1 VA: 0x35AAA0
	|-Array.InternalEnumerator<Nullable<BoundsInt>>.Dispose
	|
	|-RVA: 0x35AB80 Offset: 0x35AC81 VA: 0x35AB80
	|-Array.InternalEnumerator<Nullable<Color32>>.Dispose
	|
	|-RVA: 0x35ACE0 Offset: 0x35ADE1 VA: 0x35ACE0
	|-Array.InternalEnumerator<Nullable<Color>>.Dispose
	|
	|-RVA: 0x35ADC0 Offset: 0x35AEC1 VA: 0x35ADC0
	|-Array.InternalEnumerator<Nullable<GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x35AEB0 Offset: 0x35AFB1 VA: 0x35AEB0
	|-Array.InternalEnumerator<Nullable<GradientColorKey>>.Dispose
	|
	|-RVA: 0x35AF90 Offset: 0x35B091 VA: 0x35AF90
	|-Array.InternalEnumerator<Nullable<Keyframe>>.Dispose
	|
	|-RVA: 0x35B070 Offset: 0x35B171 VA: 0x35B070
	|-Array.InternalEnumerator<Nullable<LayerMask>>.Dispose
	|
	|-RVA: 0x35B1D0 Offset: 0x35B2D1 VA: 0x35B1D0
	|-Array.InternalEnumerator<Nullable<Matrix4x4>>.Dispose
	|
	|-RVA: 0x35B2B0 Offset: 0x35B3B1 VA: 0x35B2B0
	|-Array.InternalEnumerator<Nullable<Quaternion>>.Dispose
	|
	|-RVA: 0x35B390 Offset: 0x35B491 VA: 0x35B390
	|-Array.InternalEnumerator<Nullable<RangeInt>>.Dispose
	|
	|-RVA: 0x35B480 Offset: 0x35B581 VA: 0x35B480
	|-Array.InternalEnumerator<Nullable<Rect>>.Dispose
	|
	|-RVA: 0x35B560 Offset: 0x35B661 VA: 0x35B560
	|-Array.InternalEnumerator<Nullable<RectInt>>.Dispose
	|
	|-RVA: 0x35B640 Offset: 0x35B741 VA: 0x35B640
	|-Array.InternalEnumerator<Nullable<Vector2>>.Dispose
	|
	|-RVA: 0x35B730 Offset: 0x35B831 VA: 0x35B730
	|-Array.InternalEnumerator<Nullable<Vector2Int>>.Dispose
	|
	|-RVA: 0x35B820 Offset: 0x35B921 VA: 0x35B820
	|-Array.InternalEnumerator<Nullable<Vector3>>.Dispose
	|
	|-RVA: 0x342A00 Offset: 0x342B01 VA: 0x342A00
	|-Array.InternalEnumerator<Nullable<Vector3Int>>.Dispose
	|
	|-RVA: 0x342AE0 Offset: 0x342BE1 VA: 0x342AE0
	|-Array.InternalEnumerator<Nullable<Vector4>>.Dispose
	|
	|-RVA: 0x342BC0 Offset: 0x342CC1 VA: 0x342BC0
	|-Array.InternalEnumerator<object>.Dispose
	|
	|-RVA: 0x342CD0 Offset: 0x342DD1 VA: 0x342CD0
	|-Array.InternalEnumerator<ParameterizedStrings.FormatParam>.Dispose
	|
	|-RVA: 0x342DB0 Offset: 0x342EB1 VA: 0x342DB0
	|-Array.InternalEnumerator<ReadOnlyMemory<object>>.Dispose
	|
	|-RVA: 0x342E90 Offset: 0x342F91 VA: 0x342E90
	|-Array.InternalEnumerator<CustomAttributeNamedArgument>.Dispose
	|
	|-RVA: 0x342F70 Offset: 0x343071 VA: 0x342F70
	|-Array.InternalEnumerator<CustomAttributeTypedArgument>.Dispose
	|
	|-RVA: 0x343050 Offset: 0x343151 VA: 0x343050
	|-Array.InternalEnumerator<Label>.Dispose
	|
	|-RVA: 0x3431C0 Offset: 0x3432C1 VA: 0x3431C0
	|-Array.InternalEnumerator<ParameterModifier>.Dispose
	|
	|-RVA: 0x343320 Offset: 0x343421 VA: 0x343320
	|-Array.InternalEnumerator<ResourceLocator>.Dispose
	|
	|-RVA: 0x343400 Offset: 0x343501 VA: 0x343400
	|-Array.InternalEnumerator<Ephemeron>.Dispose
	|
	|-RVA: 0x3434E0 Offset: 0x3435E1 VA: 0x3434E0
	|-Array.InternalEnumerator<GCHandle>.Dispose
	|
	|-RVA: 0x343650 Offset: 0x343751 VA: 0x343650
	|-Array.InternalEnumerator<RuntimeTypeHandle>.Dispose
	|
	|-RVA: 0x3437B0 Offset: 0x3438B1 VA: 0x3437B0
	|-Array.InternalEnumerator<sbyte>.Dispose
	|
	|-RVA: 0x343910 Offset: 0x343A11 VA: 0x343910
	|-Array.InternalEnumerator<X509ChainStatus>.Dispose
	|
	|-RVA: 0x3439F0 Offset: 0x343AF1 VA: 0x3439F0
	|-Array.InternalEnumerator<float>.Dispose
	|
	|-RVA: 0x343B50 Offset: 0x343C51 VA: 0x343B50
	|-Array.InternalEnumerator<RegexCharClass.LowerCaseMapping>.Dispose
	|
	|-RVA: 0x343C40 Offset: 0x343D41 VA: 0x343C40
	|-Array.InternalEnumerator<CancellationTokenRegistration>.Dispose
	|
	|-RVA: 0x343D20 Offset: 0x343E21 VA: 0x343D20
	|-Array.InternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.Dispose
	|
	|-RVA: 0x343E80 Offset: 0x343F81 VA: 0x343E80
	|-Array.InternalEnumerator<TimeSpan>.Dispose
	|
	|-RVA: 0x343FE0 Offset: 0x3440E1 VA: 0x343FE0
	|-Array.InternalEnumerator<ushort>.Dispose
	|
	|-RVA: 0x344140 Offset: 0x344241 VA: 0x344140
	|-Array.InternalEnumerator<UInt16Enum>.Dispose
	|
	|-RVA: 0x3442A0 Offset: 0x3443A1 VA: 0x3442A0
	|-Array.InternalEnumerator<uint>.Dispose
	|
	|-RVA: 0x344400 Offset: 0x344501 VA: 0x344400
	|-Array.InternalEnumerator<UInt32Enum>.Dispose
	|
	|-RVA: 0x344560 Offset: 0x344661 VA: 0x344560
	|-Array.InternalEnumerator<ulong>.Dispose
	|
	|-RVA: 0x3446C0 Offset: 0x3447C1 VA: 0x3446C0
	|-Array.InternalEnumerator<ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x344820 Offset: 0x344921 VA: 0x344820
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x344980 Offset: 0x344A81 VA: 0x344980
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x344A60 Offset: 0x344B61 VA: 0x344A60
	|-Array.InternalEnumerator<ValueTuple<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x344B40 Offset: 0x344C41 VA: 0x344B40
	|-Array.InternalEnumerator<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x344C20 Offset: 0x344D21 VA: 0x344C20
	|-Array.InternalEnumerator<ValueTuple<object, float>>.Dispose
	|
	|-RVA: 0x344D00 Offset: 0x344E01 VA: 0x344D00
	|-Array.InternalEnumerator<ValueTuple<float, object>>.Dispose
	|
	|-RVA: 0x344DE0 Offset: 0x344EE1 VA: 0x344DE0
	|-Array.InternalEnumerator<ValueTuple<float, float>>.Dispose
	|
	|-RVA: 0x344EC0 Offset: 0x344FC1 VA: 0x344EC0
	|-Array.InternalEnumerator<ValueTuple<Vector3, Quaternion>>.Dispose
	|
	|-RVA: 0x344FA0 Offset: 0x3450A1 VA: 0x344FA0
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x345090 Offset: 0x345191 VA: 0x345090
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3>>.Dispose
	|
	|-RVA: 0x345170 Offset: 0x345271 VA: 0x345170
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3, float>>.Dispose
	|
	|-RVA: 0x345250 Offset: 0x345351 VA: 0x345250
	|-Array.InternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Dispose
	|
	|-RVA: 0x345330 Offset: 0x345431 VA: 0x345330
	|-Array.InternalEnumerator<HighlightState>.Dispose
	|
	|-RVA: 0x345410 Offset: 0x345511 VA: 0x345410
	|-Array.InternalEnumerator<MaterialReference>.Dispose
	|
	|-RVA: 0x3454F0 Offset: 0x3455F1 VA: 0x3454F0
	|-Array.InternalEnumerator<RichTextTagAttribute>.Dispose
	|
	|-RVA: 0x3455D0 Offset: 0x3456D1 VA: 0x3455D0
	|-Array.InternalEnumerator<TexturePacker_JsonArray.Frame>.Dispose
	|
	|-RVA: 0x3456B0 Offset: 0x3457B1 VA: 0x3456B0
	|-Array.InternalEnumerator<TMP_CharacterInfo>.Dispose
	|
	|-RVA: 0x345790 Offset: 0x345891 VA: 0x345790
	|-Array.InternalEnumerator<TMP_FontWeightPair>.Dispose
	|
	|-RVA: 0x345870 Offset: 0x345971 VA: 0x345870
	|-Array.InternalEnumerator<TMP_LineInfo>.Dispose
	|
	|-RVA: 0x345950 Offset: 0x345A51 VA: 0x345950
	|-Array.InternalEnumerator<TMP_LinkInfo>.Dispose
	|
	|-RVA: 0x345A30 Offset: 0x345B31 VA: 0x345A30
	|-Array.InternalEnumerator<TMP_MeshInfo>.Dispose
	|
	|-RVA: 0x345B10 Offset: 0x345C11 VA: 0x345B10
	|-Array.InternalEnumerator<TMP_PageInfo>.Dispose
	|
	|-RVA: 0x345BF0 Offset: 0x345CF1 VA: 0x345BF0
	|-Array.InternalEnumerator<TMP_Text.UnicodeChar>.Dispose
	|
	|-RVA: 0x345CE0 Offset: 0x345DE1 VA: 0x345CE0
	|-Array.InternalEnumerator<TMP_TextProcessingStack<int>>.Dispose
	|
	|-RVA: 0x345DC0 Offset: 0x345EC1 VA: 0x345DC0
	|-Array.InternalEnumerator<TMP_WordInfo>.Dispose
	|
	|-RVA: 0x345EA0 Offset: 0x345FA1 VA: 0x345EA0
	|-Array.InternalEnumerator<WordWrapState>.Dispose
	|
	|-RVA: 0x345F80 Offset: 0x346081 VA: 0x345F80
	|-Array.InternalEnumerator<TextPaneDatas.TextPaneData>.Dispose
	|
	|-RVA: 0x346060 Offset: 0x346161 VA: 0x346060
	|-Array.InternalEnumerator<TransitionTables>.Dispose
	|
	|-RVA: 0x346140 Offset: 0x346241 VA: 0x346140
	|-Array.InternalEnumerator<TutorialUnlockFlagData>.Dispose
	|
	|-RVA: 0x346230 Offset: 0x346331 VA: 0x346230
	|-Array.InternalEnumerator<UICheckOnBackRune.LinkSet>.Dispose
	|
	|-RVA: 0x346310 Offset: 0x346411 VA: 0x346310
	|-Array.InternalEnumerator<UIMainManagerAttachObject.AttachSet>.Dispose
	|
	|-RVA: 0x3463F0 Offset: 0x3464F1 VA: 0x3463F0
	|-Array.InternalEnumerator<CapEdge>.Dispose
	|
	|-RVA: 0x3464D0 Offset: 0x3465D1 VA: 0x3464D0
	|-Array.InternalEnumerator<ClippedEdge>.Dispose
	|
	|-RVA: 0x3465B0 Offset: 0x3466B1 VA: 0x3465B0
	|-Array.InternalEnumerator<EdgeKeyByHash>.Dispose
	|
	|-RVA: 0x346710 Offset: 0x346811 VA: 0x346710
	|-Array.InternalEnumerator<EdgeKeyByIndex>.Dispose
	|
	|-RVA: 0x346870 Offset: 0x346971 VA: 0x346870
	|-Array.InternalEnumerator<MeshDataConnectivity.Face>.Dispose
	|
	|-RVA: 0x3469D0 Offset: 0x346AD1 VA: 0x3469D0
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.Dispose
	|
	|-RVA: 0x346AB0 Offset: 0x346BB1 VA: 0x346AB0
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData>.Dispose
	|
	|-RVA: 0x346B90 Offset: 0x346C91 VA: 0x346B90
	|-Array.InternalEnumerator<NavMeshBuildMarkup>.Dispose
	|
	|-RVA: 0x346C70 Offset: 0x346D71 VA: 0x346C70
	|-Array.InternalEnumerator<NavMeshBuildSource>.Dispose
	|
	|-RVA: 0x346D50 Offset: 0x346E51 VA: 0x346D50
	|-Array.InternalEnumerator<ContentCatalogData.Bucket>.Dispose
	|
	|-RVA: 0x346E30 Offset: 0x346F31 VA: 0x346E30
	|-Array.InternalEnumerator<ConstraintSource>.Dispose
	|
	|-RVA: 0x346F10 Offset: 0x347011 VA: 0x346F10
	|-Array.InternalEnumerator<PropertySceneHandle>.Dispose
	|
	|-RVA: 0x347070 Offset: 0x347171 VA: 0x347070
	|-Array.InternalEnumerator<TransformStreamHandle>.Dispose
	|
	|-RVA: 0x347160 Offset: 0x347261 VA: 0x347160
	|-Array.InternalEnumerator<AnimatorClipInfo>.Dispose
	|
	|-RVA: 0x3472C0 Offset: 0x3473C1 VA: 0x3472C0
	|-Array.InternalEnumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|
	|-RVA: 0x3473A0 Offset: 0x3474A1 VA: 0x3473A0
	|-Array.InternalEnumerator<BoneWeight1>.Dispose
	|
	|-RVA: 0x347500 Offset: 0x347601 VA: 0x347500
	|-Array.InternalEnumerator<BoneWeight>.Dispose
	|
	|-RVA: 0x3475E0 Offset: 0x3476E1 VA: 0x3475E0
	|-Array.InternalEnumerator<BoundingSphere>.Dispose
	|
	|-RVA: 0x3476C0 Offset: 0x3477C1 VA: 0x3476C0
	|-Array.InternalEnumerator<Bounds>.Dispose
	|
	|-RVA: 0x3477A0 Offset: 0x3478A1 VA: 0x3477A0
	|-Array.InternalEnumerator<BoundsInt>.Dispose
	|
	|-RVA: 0x347880 Offset: 0x347981 VA: 0x347880
	|-Array.InternalEnumerator<CharacterInfo>.Dispose
	|
	|-RVA: 0x347960 Offset: 0x347A61 VA: 0x347960
	|-Array.InternalEnumerator<Color32>.Dispose
	|
	|-RVA: 0x347AD0 Offset: 0x347BD1 VA: 0x347AD0
	|-Array.InternalEnumerator<Color>.Dispose
	|
	|-RVA: 0x347BB0 Offset: 0x347CB1 VA: 0x347BB0
	|-Array.InternalEnumerator<CombineInstance>.Dispose
	|
	|-RVA: 0x347C90 Offset: 0x347D91 VA: 0x347C90
	|-Array.InternalEnumerator<ContactPoint2D>.Dispose
	|
	|-RVA: 0x347D70 Offset: 0x347E71 VA: 0x347D70
	|-Array.InternalEnumerator<ContactPoint>.Dispose
	|
	|-RVA: 0x347E50 Offset: 0x347F51 VA: 0x347E50
	|-Array.InternalEnumerator<RaycastResult>.Dispose
	|
	|-RVA: 0x347F30 Offset: 0x348031 VA: 0x347F30
	|-Array.InternalEnumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x348010 Offset: 0x348111 VA: 0x348010
	|-Array.InternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.Dispose
	|
	|-RVA: 0x348170 Offset: 0x348271 VA: 0x348170
	|-Array.InternalEnumerator<GradientAlphaKey>.Dispose
	|
	|-RVA: 0x348250 Offset: 0x348351 VA: 0x348250
	|-Array.InternalEnumerator<GradientColorKey>.Dispose
	|
	|-RVA: 0x348330 Offset: 0x348431 VA: 0x348330
	|-Array.InternalEnumerator<HumanBone>.Dispose
	|
	|-RVA: 0x348410 Offset: 0x348511 VA: 0x348410
	|-Array.InternalEnumerator<Keyframe>.Dispose
	|
	|-RVA: 0x3484F0 Offset: 0x3485F1 VA: 0x3484F0
	|-Array.InternalEnumerator<LOD>.Dispose
	|
	|-RVA: 0x3485D0 Offset: 0x3486D1 VA: 0x3485D0
	|-Array.InternalEnumerator<LayerMask>.Dispose
	|
	|-RVA: 0x348740 Offset: 0x348841 VA: 0x348740
	|-Array.InternalEnumerator<PlayerLoopSystem>.Dispose
	|
	|-RVA: 0x348820 Offset: 0x348921 VA: 0x348820
	|-Array.InternalEnumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x348900 Offset: 0x348A01 VA: 0x348900
	|-Array.InternalEnumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x3489E0 Offset: 0x348AE1 VA: 0x3489E0
	|-Array.InternalEnumerator<PatchExtents>.Dispose
	|
	|-RVA: 0x348AC0 Offset: 0x348BC1 VA: 0x348AC0
	|-Array.InternalEnumerator<Plane>.Dispose
	|
	|-RVA: 0x348BA0 Offset: 0x348CA1 VA: 0x348BA0
	|-Array.InternalEnumerator<Playable>.Dispose
	|
	|-RVA: 0x348C80 Offset: 0x348D81 VA: 0x348C80
	|-Array.InternalEnumerator<PlayableBinding>.Dispose
	|
	|-RVA: 0x348D60 Offset: 0x348E61 VA: 0x348D60
	|-Array.InternalEnumerator<PlayableGraph>.Dispose
	|
	|-RVA: 0x348E40 Offset: 0x348F41 VA: 0x348E40
	|-Array.InternalEnumerator<Edge>.Dispose
	|
	|-RVA: 0x348FA0 Offset: 0x3490A1 VA: 0x348FA0
	|-Array.InternalEnumerator<IntVec3>.Dispose
	|
	|-RVA: 0x349080 Offset: 0x349181 VA: 0x349080
	|-Array.InternalEnumerator<Quaternion>.Dispose
	|
	|-RVA: 0x349160 Offset: 0x349261 VA: 0x349160
	|-Array.InternalEnumerator<RangeInt>.Dispose
	|
	|-RVA: 0x3492C0 Offset: 0x3493C1 VA: 0x3492C0
	|-Array.InternalEnumerator<RaycastHit2D>.Dispose
	|
	|-RVA: 0x3493A0 Offset: 0x3494A1 VA: 0x3493A0
	|-Array.InternalEnumerator<RaycastHit>.Dispose
	|
	|-RVA: 0x349480 Offset: 0x349581 VA: 0x349480
	|-Array.InternalEnumerator<Rect>.Dispose
	|
	|-RVA: 0x349560 Offset: 0x349661 VA: 0x349560
	|-Array.InternalEnumerator<RectInt>.Dispose
	|
	|-RVA: 0x349640 Offset: 0x349741 VA: 0x349640
	|-Array.InternalEnumerator<RenderBuffer>.Dispose
	|
	|-RVA: 0x327D30 Offset: 0x327E31 VA: 0x327D30
	|-Array.InternalEnumerator<BatchVisibility>.Dispose
	|
	|-RVA: 0x327E20 Offset: 0x327F21 VA: 0x327E20
	|-Array.InternalEnumerator<ReflectionProbeBlendInfo>.Dispose
	|
	|-RVA: 0x327F00 Offset: 0x328001 VA: 0x327F00
	|-Array.InternalEnumerator<SphericalHarmonicsL2>.Dispose
	|
	|-RVA: 0x327FE0 Offset: 0x3280E1 VA: 0x327FE0
	|-Array.InternalEnumerator<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x3280C0 Offset: 0x3281C1 VA: 0x3280C0
	|-Array.InternalEnumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x3281A0 Offset: 0x3282A1 VA: 0x3281A0
	|-Array.InternalEnumerator<AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x328280 Offset: 0x328381 VA: 0x328280
	|-Array.InternalEnumerator<AsyncOperationHandle<SceneInstance>>.Dispose
	|
	|-RVA: 0x328360 Offset: 0x328461 VA: 0x328360
	|-Array.InternalEnumerator<DiagnosticEvent>.Dispose
	|
	|-RVA: 0x328440 Offset: 0x328541 VA: 0x328440
	|-Array.InternalEnumerator<SceneInstance>.Dispose
	|
	|-RVA: 0x328520 Offset: 0x328621 VA: 0x328520
	|-Array.InternalEnumerator<DelayedActionManager.DelegateInfo>.Dispose
	|
	|-RVA: 0x328600 Offset: 0x328701 VA: 0x328600
	|-Array.InternalEnumerator<ObjectInitializationData>.Dispose
	|
	|-RVA: 0x3286E0 Offset: 0x3287E1 VA: 0x3286E0
	|-Array.InternalEnumerator<SerializedType>.Dispose
	|
	|-RVA: 0x3287C0 Offset: 0x3288C1 VA: 0x3287C0
	|-Array.InternalEnumerator<SendMouseEvents.HitInfo>.Dispose
	|
	|-RVA: 0x3288A0 Offset: 0x3289A1 VA: 0x3288A0
	|-Array.InternalEnumerator<SkeletonBone>.Dispose
	|
	|-RVA: 0x328980 Offset: 0x328A81 VA: 0x328980
	|-Array.InternalEnumerator<GlyphRect>.Dispose
	|
	|-RVA: 0x328A60 Offset: 0x328B61 VA: 0x328A60
	|-Array.InternalEnumerator<GlyphMarshallingStruct>.Dispose
	|
	|-RVA: 0x328B40 Offset: 0x328C41 VA: 0x328B40
	|-Array.InternalEnumerator<GlyphPairAdjustmentRecord>.Dispose
	|
	|-RVA: 0x328C20 Offset: 0x328D21 VA: 0x328C20
	|-Array.InternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.Dispose
	|
	|-RVA: 0x328D00 Offset: 0x328E01 VA: 0x328D00
	|-Array.InternalEnumerator<IntervalTreeNode>.Dispose
	|
	|-RVA: 0x328DE0 Offset: 0x328EE1 VA: 0x328DE0
	|-Array.InternalEnumerator<IntervalTree.Entry<object>>.Dispose
	|
	|-RVA: 0x328EC0 Offset: 0x328FC1 VA: 0x328EC0
	|-Array.InternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.Dispose
	|
	|-RVA: 0x328FA0 Offset: 0x3290A1 VA: 0x328FA0
	|-Array.InternalEnumerator<Touch>.Dispose
	|
	|-RVA: 0x329080 Offset: 0x329181 VA: 0x329080
	|-Array.InternalEnumerator<TreeInstance>.Dispose
	|
	|-RVA: 0x329160 Offset: 0x329261 VA: 0x329160
	|-Array.InternalEnumerator<ColorBlock>.Dispose
	|
	|-RVA: 0x329240 Offset: 0x329341 VA: 0x329240
	|-Array.InternalEnumerator<Navigation>.Dispose
	|
	|-RVA: 0x329320 Offset: 0x329421 VA: 0x329320
	|-Array.InternalEnumerator<SpriteState>.Dispose
	|
	|-RVA: 0x329400 Offset: 0x329501 VA: 0x329400
	|-Array.InternalEnumerator<UICharInfo>.Dispose
	|
	|-RVA: 0x3294E0 Offset: 0x3295E1 VA: 0x3294E0
	|-Array.InternalEnumerator<EventDispatcher.DispatchContext>.Dispose
	|
	|-RVA: 0x3295C0 Offset: 0x3296C1 VA: 0x3295C0
	|-Array.InternalEnumerator<EventDispatcher.EventRecord>.Dispose
	|
	|-RVA: 0x3296A0 Offset: 0x3297A1 VA: 0x3296A0
	|-Array.InternalEnumerator<FocusController.FocusedElement>.Dispose
	|
	|-RVA: 0x329780 Offset: 0x329881 VA: 0x329780
	|-Array.InternalEnumerator<StyleSheetCache.SheetHandleKey>.Dispose
	|
	|-RVA: 0x3298E0 Offset: 0x3299E1 VA: 0x3298E0
	|-Array.InternalEnumerator<StyleValue>.Dispose
	|
	|-RVA: 0x3299C0 Offset: 0x329AC1 VA: 0x3299C0
	|-Array.InternalEnumerator<UILineInfo>.Dispose
	|
	|-RVA: 0x329AA0 Offset: 0x329BA1 VA: 0x329AA0
	|-Array.InternalEnumerator<UIVertex>.Dispose
	|
	|-RVA: 0x329B80 Offset: 0x329C81 VA: 0x329B80
	|-Array.InternalEnumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|
	|-RVA: 0x329C60 Offset: 0x329D61 VA: 0x329C60
	|-Array.InternalEnumerator<Vector2>.Dispose
	|
	|-RVA: 0x329D40 Offset: 0x329E41 VA: 0x329D40
	|-Array.InternalEnumerator<Vector2Int>.Dispose
	|
	|-RVA: 0x329EA0 Offset: 0x329FA1 VA: 0x329EA0
	|-Array.InternalEnumerator<Vector3>.Dispose
	|
	|-RVA: 0x329F80 Offset: 0x32A081 VA: 0x329F80
	|-Array.InternalEnumerator<Vector3Int>.Dispose
	|
	|-RVA: 0x32A070 Offset: 0x32A171 VA: 0x32A070
	|-Array.InternalEnumerator<Vector4>.Dispose
	|
	|-RVA: 0x32A150 Offset: 0x32A251 VA: 0x32A150
	|-Array.InternalEnumerator<jvalue>.Dispose
	|
	|-RVA: 0x32A2B0 Offset: 0x32A3B1 VA: 0x32A2B0
	|-Array.InternalEnumerator<WarpPoints.WarpPoint>.Dispose
	|
	|-RVA: 0x32A390 Offset: 0x32A491 VA: 0x32A390
	|-Array.InternalEnumerator<YieldItemParam>.Dispose
	|
	|-RVA: 0x32A4F0 Offset: 0x32A5F1 VA: 0x32A4F0
	|-Array.InternalEnumerator<NetworkServiceAccountId>.Dispose
	|
	|-RVA: 0x32A650 Offset: 0x32A751 VA: 0x32A650
	|-Array.InternalEnumerator<Uid>.Dispose
	|
	|-RVA: 0x32A730 Offset: 0x32A831 VA: 0x32A730
	|-Array.InternalEnumerator<ConsumableServiceItemId>.Dispose
	|
	|-RVA: 0x32A890 Offset: 0x32A991 VA: 0x32A890
	|-Array.InternalEnumerator<NsUid>.Dispose
	|
	|-RVA: 0x32A9F0 Offset: 0x32AAF1 VA: 0x32A9F0
	|-Array.InternalEnumerator<Friend>.Dispose
	|
	|-RVA: 0x32AAD0 Offset: 0x32ABD1 VA: 0x32AAD0
	|-Array.InternalEnumerator<Profile>.Dispose
	|
	|-RVA: 0x32ABB0 Offset: 0x32ACB1 VA: 0x32ABB0
	|-Array.InternalEnumerator<DirectoryEntry>.Dispose
	|
	|-RVA: 0x32AC90 Offset: 0x32AD91 VA: 0x32AC90
	|-Array.InternalEnumerator<DebugPadState>.Dispose
	|
	|-RVA: 0x32AD70 Offset: 0x32AE71 VA: 0x32AD70
	|-Array.InternalEnumerator<GesturePoint>.Dispose
	|
	|-RVA: 0x32AED0 Offset: 0x32AFD1 VA: 0x32AED0
	|-Array.InternalEnumerator<GestureState>.Dispose
	|
	|-RVA: 0x32AFB0 Offset: 0x32B0B1 VA: 0x32AFB0
	|-Array.InternalEnumerator<NpadFullKeyState>.Dispose
	|
	|-RVA: 0x32B090 Offset: 0x32B191 VA: 0x32B090
	|-Array.InternalEnumerator<NpadHandheldState>.Dispose
	|
	|-RVA: 0x32B170 Offset: 0x32B271 VA: 0x32B170
	|-Array.InternalEnumerator<NpadJoyDualState>.Dispose
	|
	|-RVA: 0x32B250 Offset: 0x32B351 VA: 0x32B250
	|-Array.InternalEnumerator<NpadJoyLeftState>.Dispose
	|
	|-RVA: 0x32B330 Offset: 0x32B431 VA: 0x32B330
	|-Array.InternalEnumerator<NpadJoyRightState>.Dispose
	|
	|-RVA: 0x32B410 Offset: 0x32B511 VA: 0x32B410
	|-Array.InternalEnumerator<NpadStateArrayItem>.Dispose
	|
	|-RVA: 0x32B4F0 Offset: 0x32B5F1 VA: 0x32B4F0
	|-Array.InternalEnumerator<SixAxisSensorHandle>.Dispose
	|
	|-RVA: 0x32B660 Offset: 0x32B761 VA: 0x32B660
	|-Array.InternalEnumerator<SixAxisSensorState>.Dispose
	|
	|-RVA: 0x32B740 Offset: 0x32B841 VA: 0x32B740
	|-Array.InternalEnumerator<TouchScreenState10>.Dispose
	|
	|-RVA: 0x32B820 Offset: 0x32B921 VA: 0x32B820
	|-Array.InternalEnumerator<TouchScreenState11>.Dispose
	|
	|-RVA: 0x32B900 Offset: 0x32BA01 VA: 0x32B900
	|-Array.InternalEnumerator<TouchScreenState12>.Dispose
	|
	|-RVA: 0x32B9E0 Offset: 0x32BAE1 VA: 0x32B9E0
	|-Array.InternalEnumerator<TouchScreenState13>.Dispose
	|
	|-RVA: 0x32BAC0 Offset: 0x32BBC1 VA: 0x32BAC0
	|-Array.InternalEnumerator<TouchScreenState14>.Dispose
	|
	|-RVA: 0x32BBA0 Offset: 0x32BCA1 VA: 0x32BBA0
	|-Array.InternalEnumerator<TouchScreenState15>.Dispose
	|
	|-RVA: 0x32BC80 Offset: 0x32BD81 VA: 0x32BC80
	|-Array.InternalEnumerator<TouchScreenState16>.Dispose
	|
	|-RVA: 0x32BD60 Offset: 0x32BE61 VA: 0x32BD60
	|-Array.InternalEnumerator<TouchScreenState1>.Dispose
	|
	|-RVA: 0x32BE40 Offset: 0x32BF41 VA: 0x32BE40
	|-Array.InternalEnumerator<TouchScreenState2>.Dispose
	|
	|-RVA: 0x32BF20 Offset: 0x32C021 VA: 0x32BF20
	|-Array.InternalEnumerator<TouchScreenState3>.Dispose
	|
	|-RVA: 0x32C000 Offset: 0x32C101 VA: 0x32C000
	|-Array.InternalEnumerator<TouchScreenState4>.Dispose
	|
	|-RVA: 0x32C0E0 Offset: 0x32C1E1 VA: 0x32C0E0
	|-Array.InternalEnumerator<TouchScreenState5>.Dispose
	|
	|-RVA: 0x32C1C0 Offset: 0x32C2C1 VA: 0x32C1C0
	|-Array.InternalEnumerator<TouchScreenState6>.Dispose
	|
	|-RVA: 0x32C2A0 Offset: 0x32C3A1 VA: 0x32C2A0
	|-Array.InternalEnumerator<TouchScreenState7>.Dispose
	|
	|-RVA: 0x32C380 Offset: 0x32C481 VA: 0x32C380
	|-Array.InternalEnumerator<TouchScreenState8>.Dispose
	|
	|-RVA: 0x32C460 Offset: 0x32C561 VA: 0x32C460
	|-Array.InternalEnumerator<TouchScreenState9>.Dispose
	|
	|-RVA: 0x32C540 Offset: 0x32C641 VA: 0x32C540
	|-Array.InternalEnumerator<TouchState>.Dispose
	|
	|-RVA: 0x32C620 Offset: 0x32C721 VA: 0x32C620
	|-Array.InternalEnumerator<VibrationDeviceHandle>.Dispose
	|
	|-RVA: 0x32C790 Offset: 0x32C891 VA: 0x32C790
	|-Array.InternalEnumerator<VibrationDeviceInfo>.Dispose
	|
	|-RVA: 0x32C8F0 Offset: 0x32C9F1 VA: 0x32C8F0
	|-Array.InternalEnumerator<VibrationValue>.Dispose
	|
	|-RVA: 0x32C9D0 Offset: 0x32CAD1 VA: 0x32C9D0
	|-Array.InternalEnumerator<ClusteringData>.Dispose
	|
	|-RVA: 0x32CAB0 Offset: 0x32CBB1 VA: 0x32CAB0
	|-Array.InternalEnumerator<ClusteringProcessorState>.Dispose
	|
	|-RVA: 0x32CB90 Offset: 0x32CC91 VA: 0x32CB90
	|-Array.InternalEnumerator<Finger>.Dispose
	|
	|-RVA: 0x32CC70 Offset: 0x32CD71 VA: 0x32CC70
	|-Array.InternalEnumerator<Hand>.Dispose
	|
	|-RVA: 0x32CD50 Offset: 0x32CE51 VA: 0x32CD50
	|-Array.InternalEnumerator<HandAnalysisImageState>.Dispose
	|
	|-RVA: 0x32CE30 Offset: 0x32CF31 VA: 0x32CE30
	|-Array.InternalEnumerator<HandAnalysisSilhouetteState>.Dispose
	|
	|-RVA: 0x32CF10 Offset: 0x32D011 VA: 0x32CF10
	|-Array.InternalEnumerator<MomentProcessorState>.Dispose
	|
	|-RVA: 0x32CFF0 Offset: 0x32D0F1 VA: 0x32CFF0
	|-Array.InternalEnumerator<MomentStatistic>.Dispose
	|
	|-RVA: 0x32D0D0 Offset: 0x32D1D1 VA: 0x32D0D0
	|-Array.InternalEnumerator<Protrusion>.Dispose
	|
	|-RVA: 0x32D230 Offset: 0x32D331 VA: 0x32D230
	|-Array.InternalEnumerator<Shape>.Dispose
	|
	|-RVA: 0x32D310 Offset: 0x32D411 VA: 0x32D310
	|-Array.InternalEnumerator<DictionaryInfo>.Dispose
	|
	|-RVA: 0x32D470 Offset: 0x32D571 VA: 0x32D470
	|-Array.InternalEnumerator<UserWord>.Dispose
	|
	|-RVA: 0x32D550 Offset: 0x32D651 VA: 0x32D550
	|-Array.InternalEnumerator<Color4u8>.Dispose
	|
	|-RVA: 0x32D6C0 Offset: 0x32D7C1 VA: 0x32D6C0
	|-Array.InternalEnumerator<Float2>.Dispose
	|
	|-RVA: 0x32D7A0 Offset: 0x32D8A1 VA: 0x32D7A0
	|-Array.InternalEnumerator<stCommand_t>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BF0 Offset: 0x315CF1 VA: 0x315BF0
	|-Array.InternalEnumerator<AS_ToolController.ChargeInfo>.MoveNext
	|
	|-RVA: 0x315CD0 Offset: 0x315DD1 VA: 0x315CD0
	|-Array.InternalEnumerator<ActionCommandDataTable>.MoveNext
	|
	|-RVA: 0x315DB0 Offset: 0x315EB1 VA: 0x315DB0
	|-Array.InternalEnumerator<AdvScriptDefCountParam>.MoveNext
	|
	|-RVA: 0x315E90 Offset: 0x315F91 VA: 0x315E90
	|-Array.InternalEnumerator<JSONDeserialization.TaskField>.MoveNext
	|
	|-RVA: 0x315F70 Offset: 0x316071 VA: 0x315F70
	|-Array.InternalEnumerator<BitVector32Int>.MoveNext
	|
	|-RVA: 0x3160E0 Offset: 0x3161E1 VA: 0x3160E0
	|-Array.InternalEnumerator<BuildItemData>.MoveNext
	|
	|-RVA: 0x3161C0 Offset: 0x3162C1 VA: 0x3161C0
	|-Array.InternalEnumerator<ButtonLinker.LinkObject>.MoveNext
	|
	|-RVA: 0x3162A0 Offset: 0x3163A1 VA: 0x3162A0
	|-Array.InternalEnumerator<CharaCallTable.BustupTable>.MoveNext
	|
	|-RVA: 0x316380 Offset: 0x316481 VA: 0x316380
	|-Array.InternalEnumerator<CharaCallTable.CharaFaceIconTable>.MoveNext
	|
	|-RVA: 0x316470 Offset: 0x316571 VA: 0x316470
	|-Array.InternalEnumerator<CameraState.CustomBlendable>.MoveNext
	|
	|-RVA: 0x316550 Offset: 0x316651 VA: 0x316550
	|-Array.InternalEnumerator<CinemachineBlendListCamera.Instruction>.MoveNext
	|
	|-RVA: 0x316630 Offset: 0x316731 VA: 0x316630
	|-Array.InternalEnumerator<CinemachineBlenderSettings.CustomBlend>.MoveNext
	|
	|-RVA: 0x316710 Offset: 0x316811 VA: 0x316710
	|-Array.InternalEnumerator<CinemachineClearShot.Pair>.MoveNext
	|
	|-RVA: 0x316870 Offset: 0x316971 VA: 0x316870
	|-Array.InternalEnumerator<CinemachineFreeLook.Orbit>.MoveNext
	|
	|-RVA: 0x316950 Offset: 0x316A51 VA: 0x316950
	|-Array.InternalEnumerator<CinemachinePath.Waypoint>.MoveNext
	|
	|-RVA: 0x316A30 Offset: 0x316B31 VA: 0x316A30
	|-Array.InternalEnumerator<CinemachineSmoothPath.Waypoint>.MoveNext
	|
	|-RVA: 0x316B10 Offset: 0x316C11 VA: 0x316B10
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.HashPair>.MoveNext
	|
	|-RVA: 0x316C70 Offset: 0x316D71 VA: 0x316C70
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.Instruction>.MoveNext
	|
	|-RVA: 0x316D50 Offset: 0x316E51 VA: 0x316D50
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.MoveNext
	|
	|-RVA: 0x316EB0 Offset: 0x316FB1 VA: 0x316EB0
	|-Array.InternalEnumerator<CinemachineTargetGroup.Target>.MoveNext
	|
	|-RVA: 0x316F90 Offset: 0x317091 VA: 0x316F90
	|-Array.InternalEnumerator<NoiseSettings.TransformNoiseParams>.MoveNext
	|
	|-RVA: 0x317070 Offset: 0x317171 VA: 0x317070
	|-Array.InternalEnumerator<TargetPositionCache.CacheCurve.Item>.MoveNext
	|
	|-RVA: 0x317150 Offset: 0x317251 VA: 0x317150
	|-Array.InternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNext
	|
	|-RVA: 0x317230 Offset: 0x317331 VA: 0x317230
	|-Array.InternalEnumerator<HeadingTracker.Item>.MoveNext
	|
	|-RVA: 0x317310 Offset: 0x317411 VA: 0x317310
	|-Array.InternalEnumerator<CropDataTable>.MoveNext
	|
	|-RVA: 0x3173F0 Offset: 0x3174F1 VA: 0x3173F0
	|-Array.InternalEnumerator<ControlPoint>.MoveNext
	|
	|-RVA: 0x3174D0 Offset: 0x3175D1 VA: 0x3174D0
	|-Array.InternalEnumerator<DamageTextInfo>.MoveNext
	|
	|-RVA: 0x3175B0 Offset: 0x3176B1 VA: 0x3175B0
	|-Array.InternalEnumerator<UIEMDefine.CategoryDataSet>.MoveNext
	|
	|-RVA: 0x317690 Offset: 0x317791 VA: 0x317690
	|-Array.InternalEnumerator<DropItemParam>.MoveNext
	|
	|-RVA: 0x3177F0 Offset: 0x3178F1 VA: 0x3177F0
	|-Array.InternalEnumerator<DropTableElement>.MoveNext
	|
	|-RVA: 0x3178D0 Offset: 0x3179D1 VA: 0x3178D0
	|-Array.InternalEnumerator<EffectDataTable>.MoveNext
	|
	|-RVA: 0x3179B0 Offset: 0x317AB1 VA: 0x3179B0
	|-Array.InternalEnumerator<EnemyPatrolPoints>.MoveNext
	|
	|-RVA: 0x317B10 Offset: 0x317C11 VA: 0x317B10
	|-Array.InternalEnumerator<Coord>.MoveNext
	|
	|-RVA: 0x317C70 Offset: 0x317D71 VA: 0x317C70
	|-Array.InternalEnumerator<ErosionBrush.UndoStep>.MoveNext
	|
	|-RVA: 0x317D50 Offset: 0x317E51 VA: 0x317D50
	|-Array.InternalEnumerator<EventCheckId>.MoveNext
	|
	|-RVA: 0x317E30 Offset: 0x317F31 VA: 0x317E30
	|-Array.InternalEnumerator<EventFlagProgressData>.MoveNext
	|
	|-RVA: 0x317F10 Offset: 0x318011 VA: 0x317F10
	|-Array.InternalEnumerator<EyeMouthAnimate.EMAnimSet>.MoveNext
	|
	|-RVA: 0x318070 Offset: 0x318171 VA: 0x318070
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_PARAM>.MoveNext
	|
	|-RVA: 0x318150 Offset: 0x318251 VA: 0x318150
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE>.MoveNext
	|
	|-RVA: 0x318230 Offset: 0x318331 VA: 0x318230
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.MoveNext
	|
	|-RVA: 0x318310 Offset: 0x318411 VA: 0x318310
	|-Array.InternalEnumerator<FarmManager.RF4_MCROP_INFO>.MoveNext
	|
	|-RVA: 0x318400 Offset: 0x318501 VA: 0x318400
	|-Array.InternalEnumerator<FarmManager.RF4_SOIL_INFO>.MoveNext
	|
	|-RVA: 0x3184E0 Offset: 0x3185E1 VA: 0x3184E0
	|-Array.InternalEnumerator<FesNpcScoreData>.MoveNext
	|
	|-RVA: 0x3185C0 Offset: 0x3186C1 VA: 0x3185C0
	|-Array.InternalEnumerator<FieldHideItemSpawnDataTable>.MoveNext
	|
	|-RVA: 0x3186A0 Offset: 0x3187A1 VA: 0x3186A0
	|-Array.InternalEnumerator<FieldItemSpawnDataTable>.MoveNext
	|
	|-RVA: 0x318780 Offset: 0x318881 VA: 0x318780
	|-Array.InternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.MoveNext
	|
	|-RVA: 0x318860 Offset: 0x318961 VA: 0x318860
	|-Array.InternalEnumerator<FieldSceneData.Data>.MoveNext
	|
	|-RVA: 0x318940 Offset: 0x318A41 VA: 0x318940
	|-Array.InternalEnumerator<FieldTreasureBoxItemData>.MoveNext
	|
	|-RVA: 0x318AB0 Offset: 0x318BB1 VA: 0x318AB0
	|-Array.InternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.MoveNext
	|
	|-RVA: 0x318B90 Offset: 0x318C91 VA: 0x318B90
	|-Array.InternalEnumerator<FieldWoodBoxSpawnDataTable>.MoveNext
	|
	|-RVA: 0x318C70 Offset: 0x318D71 VA: 0x318C70
	|-Array.InternalEnumerator<FocusObjectDataTable>.MoveNext
	|
	|-RVA: 0x318D50 Offset: 0x318E51 VA: 0x318D50
	|-Array.InternalEnumerator<FurnitureData>.MoveNext
	|
	|-RVA: 0x318E30 Offset: 0x318F31 VA: 0x318E30
	|-Array.InternalEnumerator<GateDataTable>.MoveNext
	|
	|-RVA: 0x318F10 Offset: 0x319011 VA: 0x318F10
	|-Array.InternalEnumerator<GateStatusDataTable>.MoveNext
	|
	|-RVA: 0x318FF0 Offset: 0x3190F1 VA: 0x318FF0
	|-Array.InternalEnumerator<GimmickLayoutDataTable>.MoveNext
	|
	|-RVA: 0x319160 Offset: 0x319261 VA: 0x319160
	|-Array.InternalEnumerator<HitResult>.MoveNext
	|
	|-RVA: 0x319240 Offset: 0x319341 VA: 0x319240
	|-Array.InternalEnumerator<ImagePaneDatas.ImagePaneData>.MoveNext
	|
	|-RVA: 0x319320 Offset: 0x319421 VA: 0x319320
	|-Array.InternalEnumerator<FurnitureManager.SendPos>.MoveNext
	|
	|-RVA: 0x319400 Offset: 0x319501 VA: 0x319400
	|-Array.InternalEnumerator<ItemLevelData>.MoveNext
	|
	|-RVA: 0x319560 Offset: 0x319661 VA: 0x319560
	|-Array.InternalEnumerator<MapDatas.MapData>.MoveNext
	|
	|-RVA: 0x319640 Offset: 0x319741 VA: 0x319640
	|-Array.InternalEnumerator<MapObjectDatas.MapObjectData>.MoveNext
	|
	|-RVA: 0x319720 Offset: 0x319821 VA: 0x319720
	|-Array.InternalEnumerator<ByteArrayStringHashTable.Entry>.MoveNext
	|
	|-RVA: 0x319800 Offset: 0x319901 VA: 0x319800
	|-Array.InternalEnumerator<MineTypeDataTable>.MoveNext
	|
	|-RVA: 0x3198E0 Offset: 0x3199E1 VA: 0x3198E0
	|-Array.InternalEnumerator<MiningDataTable>.MoveNext
	|
	|-RVA: 0x3199C0 Offset: 0x319AC1 VA: 0x3199C0
	|-Array.InternalEnumerator<MiningPointSaveData>.MoveNext
	|
	|-RVA: 0x319AA0 Offset: 0x319BA1 VA: 0x319AA0
	|-Array.InternalEnumerator<CodePointIndexer.TableRange>.MoveNext
	|
	|-RVA: 0x319B80 Offset: 0x319C81 VA: 0x319B80
	|-Array.InternalEnumerator<MonsterBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x319C60 Offset: 0x319D61 VA: 0x319C60
	|-Array.InternalEnumerator<MonsterDataTable>.MoveNext
	|
	|-RVA: 0x319D40 Offset: 0x319E41 VA: 0x319D40
	|-Array.InternalEnumerator<MonsterDropItemDataTable>.MoveNext
	|
	|-RVA: 0x319E20 Offset: 0x319F21 VA: 0x319E20
	|-Array.InternalEnumerator<MonsterFootStepEventDataTable>.MoveNext
	|
	|-RVA: 0x319F00 Offset: 0x31A001 VA: 0x319F00
	|-Array.InternalEnumerator<MonsterHutSaveData>.MoveNext
	|
	|-RVA: 0x319FE0 Offset: 0x31A0E1 VA: 0x319FE0
	|-Array.InternalEnumerator<MonsterUIData.Data>.MoveNext
	|
	|-RVA: 0x31A0C0 Offset: 0x31A1C1 VA: 0x31A0C0
	|-Array.InternalEnumerator<MonsterYieldItemDataTable>.MoveNext
	|
	|-RVA: 0x31A1A0 Offset: 0x31A2A1 VA: 0x31A1A0
	|-Array.InternalEnumerator<MoviePlayer.SUBTITLEDATA>.MoveNext
	|
	|-RVA: 0x31A280 Offset: 0x31A381 VA: 0x31A280
	|-Array.InternalEnumerator<NPCActionData>.MoveNext
	|
	|-RVA: 0x31A360 Offset: 0x31A461 VA: 0x31A360
	|-Array.InternalEnumerator<NPCCallingNameTextData.Data>.MoveNext
	|
	|-RVA: 0x31A440 Offset: 0x31A541 VA: 0x31A440
	|-Array.InternalEnumerator<NPCUIData.Data>.MoveNext
	|
	|-RVA: 0x31A520 Offset: 0x31A621 VA: 0x31A520
	|-Array.InternalEnumerator<NpcPlaceSchedule>.MoveNext
	|
	|-RVA: 0x31A600 Offset: 0x31A701 VA: 0x31A600
	|-Array.InternalEnumerator<OrderLotterySaveParameter>.MoveNext
	|
	|-RVA: 0x31A6F0 Offset: 0x31A7F1 VA: 0x31A6F0
	|-Array.InternalEnumerator<OrderSaveData>.MoveNext
	|
	|-RVA: 0x31A7D0 Offset: 0x31A8D1 VA: 0x31A7D0
	|-Array.InternalEnumerator<OrderSaveParameter>.MoveNext
	|
	|-RVA: 0x31A8B0 Offset: 0x31A9B1 VA: 0x31A8B0
	|-Array.InternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNext
	|
	|-RVA: 0x31A990 Offset: 0x31AA91 VA: 0x31A990
	|-Array.InternalEnumerator<Parameter>.MoveNext
	|
	|-RVA: 0x31AA70 Offset: 0x31AB71 VA: 0x31AA70
	|-Array.InternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x31AB50 Offset: 0x31AC51 VA: 0x31AB50
	|-Array.InternalEnumerator<PlayerCallingNameTextData.Data>.MoveNext
	|
	|-RVA: 0x31AC30 Offset: 0x31AD31 VA: 0x31AC30
	|-Array.InternalEnumerator<ShopCatalogPage>.MoveNext
	|
	|-RVA: 0x31AD10 Offset: 0x31AE11 VA: 0x31AD10
	|-Array.InternalEnumerator<ShopNpcTalk>.MoveNext
	|
	|-RVA: 0x31ADF0 Offset: 0x31AEF1 VA: 0x31ADF0
	|-Array.InternalEnumerator<SubtitleDataTable.Data>.MoveNext
	|
	|-RVA: 0x31AEE0 Offset: 0x31AFE1 VA: 0x31AEE0
	|-Array.InternalEnumerator<SubtitleDataTable.DataList>.MoveNext
	|
	|-RVA: 0x3219D0 Offset: 0x321AD1 VA: 0x3219D0
	|-Array.InternalEnumerator<SubtitleHudDataTable.Data>.MoveNext
	|
	|-RVA: 0x321AC0 Offset: 0x321BC1 VA: 0x321AC0
	|-Array.InternalEnumerator<AnimationWarping.Warp>.MoveNext
	|
	|-RVA: 0x321BA0 Offset: 0x321CA1 VA: 0x321BA0
	|-Array.InternalEnumerator<GrounderQuadruped.Foot>.MoveNext
	|
	|-RVA: 0x321C80 Offset: 0x321D81 VA: 0x321C80
	|-Array.InternalEnumerator<IKSolverLimb.AxisDirection>.MoveNext
	|
	|-RVA: 0x321D60 Offset: 0x321E61 VA: 0x321D60
	|-Array.InternalEnumerator<ProfilerFrame>.MoveNext
	|
	|-RVA: 0x321E40 Offset: 0x321F41 VA: 0x321E40
	|-Array.InternalEnumerator<NumberControl.ValueRange>.MoveNext
	|
	|-RVA: 0x321F20 Offset: 0x322021 VA: 0x321F20
	|-Array.InternalEnumerator<SRMonoBehaviourEx.FieldInfo>.MoveNext
	|
	|-RVA: 0x322000 Offset: 0x322101 VA: 0x322000
	|-Array.InternalEnumerator<ResponsiveEnable.Entry>.MoveNext
	|
	|-RVA: 0x3220E0 Offset: 0x3221E1 VA: 0x3220E0
	|-Array.InternalEnumerator<ResponsiveResize.Element.SizeDefinition>.MoveNext
	|
	|-RVA: 0x3221C0 Offset: 0x3222C1 VA: 0x3221C0
	|-Array.InternalEnumerator<ResponsiveResize.Element>.MoveNext
	|
	|-RVA: 0x3222A0 Offset: 0x3223A1 VA: 0x3222A0
	|-Array.InternalEnumerator<Schedule>.MoveNext
	|
	|-RVA: 0x322380 Offset: 0x322481 VA: 0x322380
	|-Array.InternalEnumerator<SimpleAnimationPlayable.QueuedState>.MoveNext
	|
	|-RVA: 0x322460 Offset: 0x322561 VA: 0x322460
	|-Array.InternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.MoveNext
	|
	|-RVA: 0x322550 Offset: 0x322651 VA: 0x322550
	|-Array.InternalEnumerator<SpeedData>.MoveNext
	|
	|-RVA: 0x3226B0 Offset: 0x3227B1 VA: 0x3226B0
	|-Array.InternalEnumerator<CurveSample>.MoveNext
	|
	|-RVA: 0x322790 Offset: 0x322891 VA: 0x322790
	|-Array.InternalEnumerator<StatusPageSetParameter.ElementParameterText>.MoveNext
	|
	|-RVA: 0x3228F0 Offset: 0x3229F1 VA: 0x3228F0
	|-Array.InternalEnumerator<StringFormatData.FormatData>.MoveNext
	|
	|-RVA: 0x3229D0 Offset: 0x322AD1 VA: 0x3229D0
	|-Array.InternalEnumerator<ArraySegment<ProfilerFrame>>.MoveNext
	|
	|-RVA: 0x322AB0 Offset: 0x322BB1 VA: 0x322AB0
	|-Array.InternalEnumerator<ArraySegment<byte>>.MoveNext
	|
	|-RVA: 0x322B90 Offset: 0x322C91 VA: 0x322B90
	|-Array.InternalEnumerator<ArraySegment<object>>.MoveNext
	|
	|-RVA: 0x322C70 Offset: 0x322D71 VA: 0x322C70
	|-Array.InternalEnumerator<bool>.MoveNext
	|
	|-RVA: 0x322D50 Offset: 0x322E51 VA: 0x322D50
	|-Array.InternalEnumerator<byte>.MoveNext
	|
	|-RVA: 0x322EB0 Offset: 0x322FB1 VA: 0x322EB0
	|-Array.InternalEnumerator<ByteEnum>.MoveNext
	|
	|-RVA: 0x323010 Offset: 0x323111 VA: 0x323010
	|-Array.InternalEnumerator<char>.MoveNext
	|
	|-RVA: 0x323170 Offset: 0x323271 VA: 0x323170
	|-Array.InternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.MoveNext
	|
	|-RVA: 0x323250 Offset: 0x323351 VA: 0x323250
	|-Array.InternalEnumerator<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x323330 Offset: 0x323431 VA: 0x323330
	|-Array.InternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.MoveNext
	|
	|-RVA: 0x323410 Offset: 0x323511 VA: 0x323410
	|-Array.InternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.MoveNext
	|
	|-RVA: 0x3234F0 Offset: 0x3235F1 VA: 0x3234F0
	|-Array.InternalEnumerator<Dictionary.Entry<EventCheckId, object>>.MoveNext
	|
	|-RVA: 0x3235D0 Offset: 0x3236D1 VA: 0x3235D0
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.MoveNext
	|
	|-RVA: 0x3236B0 Offset: 0x3237B1 VA: 0x3236B0
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.MoveNext
	|
	|-RVA: 0x323790 Offset: 0x323891 VA: 0x323790
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.MoveNext
	|
	|-RVA: 0x323870 Offset: 0x323971 VA: 0x323870
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.MoveNext
	|
	|-RVA: 0x323950 Offset: 0x323A51 VA: 0x323950
	|-Array.InternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.MoveNext
	|
	|-RVA: 0x323A30 Offset: 0x323B31 VA: 0x323A30
	|-Array.InternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.MoveNext
	|
	|-RVA: 0x323B10 Offset: 0x323C11 VA: 0x323B10
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.MoveNext
	|
	|-RVA: 0x323BF0 Offset: 0x323CF1 VA: 0x323BF0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.MoveNext
	|
	|-RVA: 0x323CD0 Offset: 0x323DD1 VA: 0x323CD0
	|-Array.InternalEnumerator<Dictionary.Entry<Parameter, object>>.MoveNext
	|
	|-RVA: 0x323DB0 Offset: 0x323EB1 VA: 0x323DB0
	|-Array.InternalEnumerator<Dictionary.Entry<bool, object>>.MoveNext
	|
	|-RVA: 0x323E90 Offset: 0x323F91 VA: 0x323E90
	|-Array.InternalEnumerator<Dictionary.Entry<byte, object>>.MoveNext
	|
	|-RVA: 0x323F70 Offset: 0x324071 VA: 0x323F70
	|-Array.InternalEnumerator<Dictionary.Entry<char, object>>.MoveNext
	|
	|-RVA: 0x324050 Offset: 0x324151 VA: 0x324050
	|-Array.InternalEnumerator<Dictionary.Entry<DateTime, object>>.MoveNext
	|
	|-RVA: 0x324130 Offset: 0x324231 VA: 0x324130
	|-Array.InternalEnumerator<Dictionary.Entry<double, object>>.MoveNext
	|
	|-RVA: 0x324210 Offset: 0x324311 VA: 0x324210
	|-Array.InternalEnumerator<Dictionary.Entry<Guid, object>>.MoveNext
	|
	|-RVA: 0x3242F0 Offset: 0x3243F1 VA: 0x3242F0
	|-Array.InternalEnumerator<Dictionary.Entry<short, object>>.MoveNext
	|
	|-RVA: 0x3243D0 Offset: 0x3244D1 VA: 0x3243D0
	|-Array.InternalEnumerator<Dictionary.Entry<int, CropDataTable>>.MoveNext
	|
	|-RVA: 0x3244B0 Offset: 0x3245B1 VA: 0x3244B0
	|-Array.InternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.MoveNext
	|
	|-RVA: 0x324590 Offset: 0x324691 VA: 0x324590
	|-Array.InternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.MoveNext
	|
	|-RVA: 0x324670 Offset: 0x324771 VA: 0x324670
	|-Array.InternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.MoveNext
	|
	|-RVA: 0x324750 Offset: 0x324851 VA: 0x324750
	|-Array.InternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.MoveNext
	|
	|-RVA: 0x324830 Offset: 0x324931 VA: 0x324830
	|-Array.InternalEnumerator<Dictionary.Entry<int, bool>>.MoveNext
	|
	|-RVA: 0x324910 Offset: 0x324A11 VA: 0x324910
	|-Array.InternalEnumerator<Dictionary.Entry<int, char>>.MoveNext
	|
	|-RVA: 0x3249F0 Offset: 0x324AF1 VA: 0x3249F0
	|-Array.InternalEnumerator<Dictionary.Entry<int, int>>.MoveNext
	|
	|-RVA: 0x324AD0 Offset: 0x324BD1 VA: 0x324AD0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Int32Enum>>.MoveNext
	|
	|-RVA: 0x324BB0 Offset: 0x324CB1 VA: 0x324BB0
	|-Array.InternalEnumerator<Dictionary.Entry<int, long>>.MoveNext
	|
	|-RVA: 0x324C90 Offset: 0x324D91 VA: 0x324C90
	|-Array.InternalEnumerator<Dictionary.Entry<int, object>>.MoveNext
	|
	|-RVA: 0x324D70 Offset: 0x324E71 VA: 0x324D70
	|-Array.InternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.MoveNext
	|
	|-RVA: 0x324E50 Offset: 0x324F51 VA: 0x324E50
	|-Array.InternalEnumerator<Dictionary.Entry<int, SceneInstance>>.MoveNext
	|
	|-RVA: 0x324F30 Offset: 0x325031 VA: 0x324F30
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector2Int>>.MoveNext
	|
	|-RVA: 0x325010 Offset: 0x325111 VA: 0x325010
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector3>>.MoveNext
	|
	|-RVA: 0x3250F0 Offset: 0x3251F1 VA: 0x3250F0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.MoveNext
	|
	|-RVA: 0x3251D0 Offset: 0x3252D1 VA: 0x3251D0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.MoveNext
	|
	|-RVA: 0x3252B0 Offset: 0x3253B1 VA: 0x3252B0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.MoveNext
	|
	|-RVA: 0x325390 Offset: 0x325491 VA: 0x325390
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.MoveNext
	|
	|-RVA: 0x325470 Offset: 0x325571 VA: 0x325470
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.MoveNext
	|
	|-RVA: 0x325550 Offset: 0x325651 VA: 0x325550
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x325630 Offset: 0x325731 VA: 0x325630
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x325710 Offset: 0x325811 VA: 0x325710
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x3257F0 Offset: 0x3258F1 VA: 0x3257F0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, float>>.MoveNext
	|
	|-RVA: 0x3258D0 Offset: 0x3259D1 VA: 0x3258D0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.MoveNext
	|
	|-RVA: 0x3259B0 Offset: 0x325AB1 VA: 0x3259B0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.MoveNext
	|
	|-RVA: 0x325A90 Offset: 0x325B91 VA: 0x325A90
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.MoveNext
	|
	|-RVA: 0x325B70 Offset: 0x325C71 VA: 0x325B70
	|-Array.InternalEnumerator<Dictionary.Entry<long, object>>.MoveNext
	|
	|-RVA: 0x325C50 Offset: 0x325D51 VA: 0x325C50
	|-Array.InternalEnumerator<Dictionary.Entry<Memory<object>, object>>.MoveNext
	|
	|-RVA: 0x325D30 Offset: 0x325E31 VA: 0x325D30
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.MoveNext
	|
	|-RVA: 0x325E10 Offset: 0x325F11 VA: 0x325E10
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.MoveNext
	|
	|-RVA: 0x325EF0 Offset: 0x325FF1 VA: 0x325EF0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.MoveNext
	|
	|-RVA: 0x325FD0 Offset: 0x3260D1 VA: 0x325FD0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.MoveNext
	|
	|-RVA: 0x3260B0 Offset: 0x3261B1 VA: 0x3260B0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.MoveNext
	|
	|-RVA: 0x326190 Offset: 0x326291 VA: 0x326190
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.MoveNext
	|
	|-RVA: 0x326270 Offset: 0x326371 VA: 0x326270
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.MoveNext
	|
	|-RVA: 0x326350 Offset: 0x326451 VA: 0x326350
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.MoveNext
	|
	|-RVA: 0x326430 Offset: 0x326531 VA: 0x326430
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.MoveNext
	|
	|-RVA: 0x326510 Offset: 0x326611 VA: 0x326510
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.MoveNext
	|
	|-RVA: 0x3265F0 Offset: 0x3266F1 VA: 0x3265F0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.MoveNext
	|
	|-RVA: 0x3266D0 Offset: 0x3267D1 VA: 0x3266D0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.MoveNext
	|
	|-RVA: 0x3267B0 Offset: 0x3268B1 VA: 0x3267B0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.MoveNext
	|
	|-RVA: 0x326890 Offset: 0x326991 VA: 0x326890
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.MoveNext
	|
	|-RVA: 0x326970 Offset: 0x326A71 VA: 0x326970
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.MoveNext
	|
	|-RVA: 0x326A50 Offset: 0x326B51 VA: 0x326A50
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.MoveNext
	|
	|-RVA: 0x326B30 Offset: 0x326C31 VA: 0x326B30
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.MoveNext
	|
	|-RVA: 0x326C10 Offset: 0x326D11 VA: 0x326C10
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.MoveNext
	|
	|-RVA: 0x326CF0 Offset: 0x326DF1 VA: 0x326CF0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.MoveNext
	|
	|-RVA: 0x326DD0 Offset: 0x326ED1 VA: 0x326DD0
	|-Array.InternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.MoveNext
	|
	|-RVA: 0x326EB0 Offset: 0x326FB1 VA: 0x326EB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, EventCheckId>>.MoveNext
	|
	|-RVA: 0x326F90 Offset: 0x327091 VA: 0x326F90
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.MoveNext
	|
	|-RVA: 0x327070 Offset: 0x327171 VA: 0x327070
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.MoveNext
	|
	|-RVA: 0x327150 Offset: 0x327251 VA: 0x327150
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.MoveNext
	|
	|-RVA: 0x327230 Offset: 0x327331 VA: 0x327230
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.MoveNext
	|
	|-RVA: 0x327310 Offset: 0x327411 VA: 0x327310
	|-Array.InternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.MoveNext
	|
	|-RVA: 0x3273F0 Offset: 0x3274F1 VA: 0x3273F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.MoveNext
	|
	|-RVA: 0x3274D0 Offset: 0x3275D1 VA: 0x3274D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.MoveNext
	|
	|-RVA: 0x3275B0 Offset: 0x3276B1 VA: 0x3275B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.MoveNext
	|
	|-RVA: 0x327690 Offset: 0x327791 VA: 0x327690
	|-Array.InternalEnumerator<Dictionary.Entry<object, Parameter>>.MoveNext
	|
	|-RVA: 0x327770 Offset: 0x327871 VA: 0x327770
	|-Array.InternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.MoveNext
	|
	|-RVA: 0x327850 Offset: 0x327951 VA: 0x327850
	|-Array.InternalEnumerator<Dictionary.Entry<object, bool>>.MoveNext
	|
	|-RVA: 0x349730 Offset: 0x349831 VA: 0x349730
	|-Array.InternalEnumerator<Dictionary.Entry<object, byte>>.MoveNext
	|
	|-RVA: 0x349810 Offset: 0x349911 VA: 0x349810
	|-Array.InternalEnumerator<Dictionary.Entry<object, char>>.MoveNext
	|
	|-RVA: 0x3498F0 Offset: 0x3499F1 VA: 0x3498F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, DateTime>>.MoveNext
	|
	|-RVA: 0x3499D0 Offset: 0x349AD1 VA: 0x3499D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, double>>.MoveNext
	|
	|-RVA: 0x349AB0 Offset: 0x349BB1 VA: 0x349AB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, short>>.MoveNext
	|
	|-RVA: 0x349B90 Offset: 0x349C91 VA: 0x349B90
	|-Array.InternalEnumerator<Dictionary.Entry<object, int>>.MoveNext
	|
	|-RVA: 0x349C70 Offset: 0x349D71 VA: 0x349C70
	|-Array.InternalEnumerator<Dictionary.Entry<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x349D50 Offset: 0x349E51 VA: 0x349D50
	|-Array.InternalEnumerator<Dictionary.Entry<object, long>>.MoveNext
	|
	|-RVA: 0x349E30 Offset: 0x349F31 VA: 0x349E30
	|-Array.InternalEnumerator<Dictionary.Entry<object, Memory<object>>>.MoveNext
	|
	|-RVA: 0x349F10 Offset: 0x34A011 VA: 0x349F10
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.MoveNext
	|
	|-RVA: 0x349FF0 Offset: 0x34A0F1 VA: 0x349FF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.MoveNext
	|
	|-RVA: 0x34A0D0 Offset: 0x34A1D1 VA: 0x34A0D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.MoveNext
	|
	|-RVA: 0x34A1B0 Offset: 0x34A2B1 VA: 0x34A1B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.MoveNext
	|
	|-RVA: 0x34A290 Offset: 0x34A391 VA: 0x34A290
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.MoveNext
	|
	|-RVA: 0x34A370 Offset: 0x34A471 VA: 0x34A370
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.MoveNext
	|
	|-RVA: 0x34A450 Offset: 0x34A551 VA: 0x34A450
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.MoveNext
	|
	|-RVA: 0x34A530 Offset: 0x34A631 VA: 0x34A530
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.MoveNext
	|
	|-RVA: 0x34A610 Offset: 0x34A711 VA: 0x34A610
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.MoveNext
	|
	|-RVA: 0x34A6F0 Offset: 0x34A7F1 VA: 0x34A6F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.MoveNext
	|
	|-RVA: 0x34A7D0 Offset: 0x34A8D1 VA: 0x34A7D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.MoveNext
	|
	|-RVA: 0x34A8B0 Offset: 0x34A9B1 VA: 0x34A8B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.MoveNext
	|
	|-RVA: 0x34A990 Offset: 0x34AA91 VA: 0x34A990
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.MoveNext
	|
	|-RVA: 0x34AA70 Offset: 0x34AB71 VA: 0x34AA70
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.MoveNext
	|
	|-RVA: 0x34AB50 Offset: 0x34AC51 VA: 0x34AB50
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.MoveNext
	|
	|-RVA: 0x34AC30 Offset: 0x34AD31 VA: 0x34AC30
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.MoveNext
	|
	|-RVA: 0x34AD10 Offset: 0x34AE11 VA: 0x34AD10
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.MoveNext
	|
	|-RVA: 0x34ADF0 Offset: 0x34AEF1 VA: 0x34ADF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.MoveNext
	|
	|-RVA: 0x34AED0 Offset: 0x34AFD1 VA: 0x34AED0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.MoveNext
	|
	|-RVA: 0x34AFB0 Offset: 0x34B0B1 VA: 0x34AFB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, object>>.MoveNext
	|
	|-RVA: 0x34B090 Offset: 0x34B191 VA: 0x34B090
	|-Array.InternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.MoveNext
	|
	|-RVA: 0x34B170 Offset: 0x34B271 VA: 0x34B170
	|-Array.InternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.MoveNext
	|
	|-RVA: 0x34B250 Offset: 0x34B351 VA: 0x34B250
	|-Array.InternalEnumerator<Dictionary.Entry<object, sbyte>>.MoveNext
	|
	|-RVA: 0x34B330 Offset: 0x34B431 VA: 0x34B330
	|-Array.InternalEnumerator<Dictionary.Entry<object, float>>.MoveNext
	|
	|-RVA: 0x34B410 Offset: 0x34B511 VA: 0x34B410
	|-Array.InternalEnumerator<Dictionary.Entry<object, ushort>>.MoveNext
	|
	|-RVA: 0x34B4F0 Offset: 0x34B5F1 VA: 0x34B4F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, uint>>.MoveNext
	|
	|-RVA: 0x34B5D0 Offset: 0x34B6D1 VA: 0x34B5D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, ulong>>.MoveNext
	|
	|-RVA: 0x34B6B0 Offset: 0x34B7B1 VA: 0x34B6B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, TransitionTables>>.MoveNext
	|
	|-RVA: 0x34B790 Offset: 0x34B891 VA: 0x34B790
	|-Array.InternalEnumerator<Dictionary.Entry<object, Bounds>>.MoveNext
	|
	|-RVA: 0x34B870 Offset: 0x34B971 VA: 0x34B870
	|-Array.InternalEnumerator<Dictionary.Entry<object, BoundsInt>>.MoveNext
	|
	|-RVA: 0x34B950 Offset: 0x34BA51 VA: 0x34B950
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color32>>.MoveNext
	|
	|-RVA: 0x34BA30 Offset: 0x34BB31 VA: 0x34BA30
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color>>.MoveNext
	|
	|-RVA: 0x34BB10 Offset: 0x34BC11 VA: 0x34BB10
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x34BBF0 Offset: 0x34BCF1 VA: 0x34BBF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.MoveNext
	|
	|-RVA: 0x34BCD0 Offset: 0x34BDD1 VA: 0x34BCD0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Keyframe>>.MoveNext
	|
	|-RVA: 0x34BDB0 Offset: 0x34BEB1 VA: 0x34BDB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, LayerMask>>.MoveNext
	|
	|-RVA: 0x34BE90 Offset: 0x34BF91 VA: 0x34BE90
	|-Array.InternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.MoveNext
	|
	|-RVA: 0x34BF70 Offset: 0x34C071 VA: 0x34BF70
	|-Array.InternalEnumerator<Dictionary.Entry<object, Playable>>.MoveNext
	|
	|-RVA: 0x34C050 Offset: 0x34C151 VA: 0x34C050
	|-Array.InternalEnumerator<Dictionary.Entry<object, Quaternion>>.MoveNext
	|
	|-RVA: 0x34C130 Offset: 0x34C231 VA: 0x34C130
	|-Array.InternalEnumerator<Dictionary.Entry<object, RangeInt>>.MoveNext
	|
	|-RVA: 0x34C210 Offset: 0x34C311 VA: 0x34C210
	|-Array.InternalEnumerator<Dictionary.Entry<object, Rect>>.MoveNext
	|
	|-RVA: 0x34C2F0 Offset: 0x34C3F1 VA: 0x34C2F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RectInt>>.MoveNext
	|
	|-RVA: 0x34C3D0 Offset: 0x34C4D1 VA: 0x34C3D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x34C4B0 Offset: 0x34C5B1 VA: 0x34C4B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.MoveNext
	|
	|-RVA: 0x34C590 Offset: 0x34C691 VA: 0x34C590
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2>>.MoveNext
	|
	|-RVA: 0x34C670 Offset: 0x34C771 VA: 0x34C670
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2Int>>.MoveNext
	|
	|-RVA: 0x34C750 Offset: 0x34C851 VA: 0x34C750
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3>>.MoveNext
	|
	|-RVA: 0x34C830 Offset: 0x34C931 VA: 0x34C830
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3Int>>.MoveNext
	|
	|-RVA: 0x34C910 Offset: 0x34CA11 VA: 0x34C910
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector4>>.MoveNext
	|
	|-RVA: 0x34C9F0 Offset: 0x34CAF1 VA: 0x34C9F0
	|-Array.InternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.MoveNext
	|
	|-RVA: 0x34CAD0 Offset: 0x34CBD1 VA: 0x34CAD0
	|-Array.InternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.MoveNext
	|
	|-RVA: 0x34CBB0 Offset: 0x34CCB1 VA: 0x34CBB0
	|-Array.InternalEnumerator<Dictionary.Entry<sbyte, object>>.MoveNext
	|
	|-RVA: 0x34CC90 Offset: 0x34CD91 VA: 0x34CC90
	|-Array.InternalEnumerator<Dictionary.Entry<float, CurveSample>>.MoveNext
	|
	|-RVA: 0x34CD70 Offset: 0x34CE71 VA: 0x34CD70
	|-Array.InternalEnumerator<Dictionary.Entry<float, object>>.MoveNext
	|
	|-RVA: 0x34CE50 Offset: 0x34CF51 VA: 0x34CE50
	|-Array.InternalEnumerator<Dictionary.Entry<ushort, object>>.MoveNext
	|
	|-RVA: 0x34CF30 Offset: 0x34D031 VA: 0x34CF30
	|-Array.InternalEnumerator<Dictionary.Entry<uint, int>>.MoveNext
	|
	|-RVA: 0x34D010 Offset: 0x34D111 VA: 0x34D010
	|-Array.InternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.MoveNext
	|
	|-RVA: 0x34D0F0 Offset: 0x34D1F1 VA: 0x34D0F0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, object>>.MoveNext
	|
	|-RVA: 0x34D1D0 Offset: 0x34D2D1 VA: 0x34D1D0
	|-Array.InternalEnumerator<Dictionary.Entry<ulong, object>>.MoveNext
	|
	|-RVA: 0x34D2B0 Offset: 0x34D3B1 VA: 0x34D2B0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.MoveNext
	|
	|-RVA: 0x34D390 Offset: 0x34D491 VA: 0x34D390
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.MoveNext
	|
	|-RVA: 0x34D470 Offset: 0x34D571 VA: 0x34D470
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.MoveNext
	|
	|-RVA: 0x34D550 Offset: 0x34D651 VA: 0x34D550
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.MoveNext
	|
	|-RVA: 0x34D630 Offset: 0x34D731 VA: 0x34D630
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.MoveNext
	|
	|-RVA: 0x34D710 Offset: 0x34D811 VA: 0x34D710
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.MoveNext
	|
	|-RVA: 0x34D7F0 Offset: 0x34D8F1 VA: 0x34D7F0
	|-Array.InternalEnumerator<Dictionary.Entry<Bounds, object>>.MoveNext
	|
	|-RVA: 0x34D8D0 Offset: 0x34D9D1 VA: 0x34D8D0
	|-Array.InternalEnumerator<Dictionary.Entry<BoundsInt, object>>.MoveNext
	|
	|-RVA: 0x34D9B0 Offset: 0x34DAB1 VA: 0x34D9B0
	|-Array.InternalEnumerator<Dictionary.Entry<Color, object>>.MoveNext
	|
	|-RVA: 0x34DA90 Offset: 0x34DB91 VA: 0x34DA90
	|-Array.InternalEnumerator<Dictionary.Entry<Color32, object>>.MoveNext
	|
	|-RVA: 0x34DB70 Offset: 0x34DC71 VA: 0x34DB70
	|-Array.InternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.MoveNext
	|
	|-RVA: 0x34DC50 Offset: 0x34DD51 VA: 0x34DC50
	|-Array.InternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.MoveNext
	|
	|-RVA: 0x34DD30 Offset: 0x34DE31 VA: 0x34DD30
	|-Array.InternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.MoveNext
	|
	|-RVA: 0x34DE10 Offset: 0x34DF11 VA: 0x34DE10
	|-Array.InternalEnumerator<Dictionary.Entry<Keyframe, object>>.MoveNext
	|
	|-RVA: 0x34DEF0 Offset: 0x34DFF1 VA: 0x34DEF0
	|-Array.InternalEnumerator<Dictionary.Entry<LayerMask, object>>.MoveNext
	|
	|-RVA: 0x34DFD0 Offset: 0x34E0D1 VA: 0x34DFD0
	|-Array.InternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.MoveNext
	|
	|-RVA: 0x34E0B0 Offset: 0x34E1B1 VA: 0x34E0B0
	|-Array.InternalEnumerator<Dictionary.Entry<IntVec3, object>>.MoveNext
	|
	|-RVA: 0x34E190 Offset: 0x34E291 VA: 0x34E190
	|-Array.InternalEnumerator<Dictionary.Entry<Quaternion, object>>.MoveNext
	|
	|-RVA: 0x34E270 Offset: 0x34E371 VA: 0x34E270
	|-Array.InternalEnumerator<Dictionary.Entry<RangeInt, object>>.MoveNext
	|
	|-RVA: 0x34E350 Offset: 0x34E451 VA: 0x34E350
	|-Array.InternalEnumerator<Dictionary.Entry<Rect, object>>.MoveNext
	|
	|-RVA: 0x34E430 Offset: 0x34E531 VA: 0x34E430
	|-Array.InternalEnumerator<Dictionary.Entry<RectInt, object>>.MoveNext
	|
	|-RVA: 0x34E510 Offset: 0x34E611 VA: 0x34E510
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.MoveNext
	|
	|-RVA: 0x34E5F0 Offset: 0x34E6F1 VA: 0x34E5F0
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.MoveNext
	|
	|-RVA: 0x34E6D0 Offset: 0x34E7D1 VA: 0x34E6D0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2, object>>.MoveNext
	|
	|-RVA: 0x34E7B0 Offset: 0x34E8B1 VA: 0x34E7B0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2Int, object>>.MoveNext
	|
	|-RVA: 0x34E890 Offset: 0x34E991 VA: 0x34E890
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3, object>>.MoveNext
	|
	|-RVA: 0x34E970 Offset: 0x34EA71 VA: 0x34E970
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3Int, object>>.MoveNext
	|
	|-RVA: 0x34EA50 Offset: 0x34EB51 VA: 0x34EA50
	|-Array.InternalEnumerator<Dictionary.Entry<Vector4, object>>.MoveNext
	|
	|-RVA: 0x34EB30 Offset: 0x34EC31 VA: 0x34EB30
	|-Array.InternalEnumerator<HashSet.Slot<int>>.MoveNext
	|
	|-RVA: 0x34EC20 Offset: 0x34ED21 VA: 0x34EC20
	|-Array.InternalEnumerator<HashSet.Slot<Int32Enum>>.MoveNext
	|
	|-RVA: 0x34ED10 Offset: 0x34EE11 VA: 0x34ED10
	|-Array.InternalEnumerator<HashSet.Slot<object>>.MoveNext
	|
	|-RVA: 0x34EDF0 Offset: 0x34EEF1 VA: 0x34EDF0
	|-Array.InternalEnumerator<HashSet.Slot<uint>>.MoveNext
	|
	|-RVA: 0x34EEE0 Offset: 0x34EFE1 VA: 0x34EEE0
	|-Array.InternalEnumerator<HashSet.Slot<Edge>>.MoveNext
	|
	|-RVA: 0x34EFC0 Offset: 0x34F0C1 VA: 0x34EFC0
	|-Array.InternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x34F0A0 Offset: 0x34F1A1 VA: 0x34F0A0
	|-Array.InternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.MoveNext
	|
	|-RVA: 0x34F180 Offset: 0x34F281 VA: 0x34F180
	|-Array.InternalEnumerator<KeyValuePair<BitVector32Int, object>>.MoveNext
	|
	|-RVA: 0x34F260 Offset: 0x34F361 VA: 0x34F260
	|-Array.InternalEnumerator<KeyValuePair<EventCheckId, object>>.MoveNext
	|
	|-RVA: 0x34F340 Offset: 0x34F441 VA: 0x34F340
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.MoveNext
	|
	|-RVA: 0x338DC0 Offset: 0x338EC1 VA: 0x338DC0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.MoveNext
	|
	|-RVA: 0x338EA0 Offset: 0x338FA1 VA: 0x338EA0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.MoveNext
	|
	|-RVA: 0x338F80 Offset: 0x339081 VA: 0x338F80
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.MoveNext
	|
	|-RVA: 0x339060 Offset: 0x339161 VA: 0x339060
	|-Array.InternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.MoveNext
	|
	|-RVA: 0x339140 Offset: 0x339241 VA: 0x339140
	|-Array.InternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.MoveNext
	|
	|-RVA: 0x339220 Offset: 0x339321 VA: 0x339220
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveData, object>>.MoveNext
	|
	|-RVA: 0x339300 Offset: 0x339401 VA: 0x339300
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.MoveNext
	|
	|-RVA: 0x3393E0 Offset: 0x3394E1 VA: 0x3393E0
	|-Array.InternalEnumerator<KeyValuePair<Parameter, object>>.MoveNext
	|
	|-RVA: 0x3394C0 Offset: 0x3395C1 VA: 0x3394C0
	|-Array.InternalEnumerator<KeyValuePair<bool, object>>.MoveNext
	|
	|-RVA: 0x3395A0 Offset: 0x3396A1 VA: 0x3395A0
	|-Array.InternalEnumerator<KeyValuePair<byte, object>>.MoveNext
	|
	|-RVA: 0x339680 Offset: 0x339781 VA: 0x339680
	|-Array.InternalEnumerator<KeyValuePair<char, object>>.MoveNext
	|
	|-RVA: 0x339760 Offset: 0x339861 VA: 0x339760
	|-Array.InternalEnumerator<KeyValuePair<DateTime, object>>.MoveNext
	|
	|-RVA: 0x339840 Offset: 0x339941 VA: 0x339840
	|-Array.InternalEnumerator<KeyValuePair<double, object>>.MoveNext
	|
	|-RVA: 0x339920 Offset: 0x339A21 VA: 0x339920
	|-Array.InternalEnumerator<KeyValuePair<Guid, object>>.MoveNext
	|
	|-RVA: 0x339A00 Offset: 0x339B01 VA: 0x339A00
	|-Array.InternalEnumerator<KeyValuePair<short, object>>.MoveNext
	|
	|-RVA: 0x339AE0 Offset: 0x339BE1 VA: 0x339AE0
	|-Array.InternalEnumerator<KeyValuePair<int, CropDataTable>>.MoveNext
	|
	|-RVA: 0x339BC0 Offset: 0x339CC1 VA: 0x339BC0
	|-Array.InternalEnumerator<KeyValuePair<int, EffectDataTable>>.MoveNext
	|
	|-RVA: 0x339CA0 Offset: 0x339DA1 VA: 0x339CA0
	|-Array.InternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.MoveNext
	|
	|-RVA: 0x339E00 Offset: 0x339F01 VA: 0x339E00
	|-Array.InternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.MoveNext
	|
	|-RVA: 0x339EE0 Offset: 0x339FE1 VA: 0x339EE0
	|-Array.InternalEnumerator<KeyValuePair<int, MiningDataTable>>.MoveNext
	|
	|-RVA: 0x339FC0 Offset: 0x33A0C1 VA: 0x339FC0
	|-Array.InternalEnumerator<KeyValuePair<int, bool>>.MoveNext
	|
	|-RVA: 0x33A120 Offset: 0x33A221 VA: 0x33A120
	|-Array.InternalEnumerator<KeyValuePair<int, char>>.MoveNext
	|
	|-RVA: 0x33A280 Offset: 0x33A381 VA: 0x33A280
	|-Array.InternalEnumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x33A3E0 Offset: 0x33A4E1 VA: 0x33A3E0
	|-Array.InternalEnumerator<KeyValuePair<int, Int32Enum>>.MoveNext
	|
	|-RVA: 0x33A540 Offset: 0x33A641 VA: 0x33A540
	|-Array.InternalEnumerator<KeyValuePair<int, long>>.MoveNext
	|
	|-RVA: 0x33A620 Offset: 0x33A721 VA: 0x33A620
	|-Array.InternalEnumerator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x33A700 Offset: 0x33A801 VA: 0x33A700
	|-Array.InternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.MoveNext
	|
	|-RVA: 0x33A7E0 Offset: 0x33A8E1 VA: 0x33A7E0
	|-Array.InternalEnumerator<KeyValuePair<int, SceneInstance>>.MoveNext
	|
	|-RVA: 0x33A8C0 Offset: 0x33A9C1 VA: 0x33A8C0
	|-Array.InternalEnumerator<KeyValuePair<int, Vector2Int>>.MoveNext
	|
	|-RVA: 0x33A9B0 Offset: 0x33AAB1 VA: 0x33A9B0
	|-Array.InternalEnumerator<KeyValuePair<int, Vector3>>.MoveNext
	|
	|-RVA: 0x33AA90 Offset: 0x33AB91 VA: 0x33AA90
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.MoveNext
	|
	|-RVA: 0x33AB70 Offset: 0x33AC71 VA: 0x33AB70
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.MoveNext
	|
	|-RVA: 0x33AC50 Offset: 0x33AD51 VA: 0x33AC50
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.MoveNext
	|
	|-RVA: 0x33AD30 Offset: 0x33AE31 VA: 0x33AD30
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, bool>>.MoveNext
	|
	|-RVA: 0x33AE90 Offset: 0x33AF91 VA: 0x33AE90
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.MoveNext
	|
	|-RVA: 0x33AF80 Offset: 0x33B081 VA: 0x33AF80
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x33B0E0 Offset: 0x33B1E1 VA: 0x33B0E0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x33B240 Offset: 0x33B341 VA: 0x33B240
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x33B320 Offset: 0x33B421 VA: 0x33B320
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, float>>.MoveNext
	|
	|-RVA: 0x33B480 Offset: 0x33B581 VA: 0x33B480
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.MoveNext
	|
	|-RVA: 0x33B560 Offset: 0x33B661 VA: 0x33B560
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.MoveNext
	|
	|-RVA: 0x33B650 Offset: 0x33B751 VA: 0x33B650
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.MoveNext
	|
	|-RVA: 0x33B730 Offset: 0x33B831 VA: 0x33B730
	|-Array.InternalEnumerator<KeyValuePair<long, object>>.MoveNext
	|
	|-RVA: 0x33B810 Offset: 0x33B911 VA: 0x33B810
	|-Array.InternalEnumerator<KeyValuePair<Memory<object>, object>>.MoveNext
	|
	|-RVA: 0x33B8F0 Offset: 0x33B9F1 VA: 0x33B8F0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.MoveNext
	|
	|-RVA: 0x33B9D0 Offset: 0x33BAD1 VA: 0x33B9D0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.MoveNext
	|
	|-RVA: 0x33BAB0 Offset: 0x33BBB1 VA: 0x33BAB0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.MoveNext
	|
	|-RVA: 0x33BB90 Offset: 0x33BC91 VA: 0x33BB90
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.MoveNext
	|
	|-RVA: 0x33BC70 Offset: 0x33BD71 VA: 0x33BC70
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color>, object>>.MoveNext
	|
	|-RVA: 0x33BD50 Offset: 0x33BE51 VA: 0x33BD50
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.MoveNext
	|
	|-RVA: 0x33BE30 Offset: 0x33BF31 VA: 0x33BE30
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.MoveNext
	|
	|-RVA: 0x33BF10 Offset: 0x33C011 VA: 0x33BF10
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.MoveNext
	|
	|-RVA: 0x33BFF0 Offset: 0x33C0F1 VA: 0x33BFF0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.MoveNext
	|
	|-RVA: 0x33C0D0 Offset: 0x33C1D1 VA: 0x33C0D0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.MoveNext
	|
	|-RVA: 0x33C1B0 Offset: 0x33C2B1 VA: 0x33C1B0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.MoveNext
	|
	|-RVA: 0x33C290 Offset: 0x33C391 VA: 0x33C290
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.MoveNext
	|
	|-RVA: 0x33C370 Offset: 0x33C471 VA: 0x33C370
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.MoveNext
	|
	|-RVA: 0x33C450 Offset: 0x33C551 VA: 0x33C450
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.MoveNext
	|
	|-RVA: 0x33C530 Offset: 0x33C631 VA: 0x33C530
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.MoveNext
	|
	|-RVA: 0x33C610 Offset: 0x33C711 VA: 0x33C610
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.MoveNext
	|
	|-RVA: 0x33C6F0 Offset: 0x33C7F1 VA: 0x33C6F0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.MoveNext
	|
	|-RVA: 0x33C7D0 Offset: 0x33C8D1 VA: 0x33C7D0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.MoveNext
	|
	|-RVA: 0x33C8B0 Offset: 0x33C9B1 VA: 0x33C8B0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.MoveNext
	|
	|-RVA: 0x33C990 Offset: 0x33CA91 VA: 0x33C990
	|-Array.InternalEnumerator<KeyValuePair<object, BitVector32Int>>.MoveNext
	|
	|-RVA: 0x33CA70 Offset: 0x33CB71 VA: 0x33CA70
	|-Array.InternalEnumerator<KeyValuePair<object, EventCheckId>>.MoveNext
	|
	|-RVA: 0x33CB50 Offset: 0x33CC51 VA: 0x33CB50
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.MoveNext
	|
	|-RVA: 0x33CC30 Offset: 0x33CD31 VA: 0x33CC30
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.MoveNext
	|
	|-RVA: 0x33CD10 Offset: 0x33CE11 VA: 0x33CD10
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.MoveNext
	|
	|-RVA: 0x33CDF0 Offset: 0x33CEF1 VA: 0x33CDF0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.MoveNext
	|
	|-RVA: 0x33CED0 Offset: 0x33CFD1 VA: 0x33CED0
	|-Array.InternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.MoveNext
	|
	|-RVA: 0x33CFB0 Offset: 0x33D0B1 VA: 0x33CFB0
	|-Array.InternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.MoveNext
	|
	|-RVA: 0x33D090 Offset: 0x33D191 VA: 0x33D090
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveData>>.MoveNext
	|
	|-RVA: 0x33D170 Offset: 0x33D271 VA: 0x33D170
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.MoveNext
	|
	|-RVA: 0x33D250 Offset: 0x33D351 VA: 0x33D250
	|-Array.InternalEnumerator<KeyValuePair<object, Parameter>>.MoveNext
	|
	|-RVA: 0x33D330 Offset: 0x33D431 VA: 0x33D330
	|-Array.InternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.MoveNext
	|
	|-RVA: 0x33D410 Offset: 0x33D511 VA: 0x33D410
	|-Array.InternalEnumerator<KeyValuePair<object, bool>>.MoveNext
	|
	|-RVA: 0x33D4F0 Offset: 0x33D5F1 VA: 0x33D4F0
	|-Array.InternalEnumerator<KeyValuePair<object, byte>>.MoveNext
	|
	|-RVA: 0x33D5D0 Offset: 0x33D6D1 VA: 0x33D5D0
	|-Array.InternalEnumerator<KeyValuePair<object, char>>.MoveNext
	|
	|-RVA: 0x33D6B0 Offset: 0x33D7B1 VA: 0x33D6B0
	|-Array.InternalEnumerator<KeyValuePair<object, DateTime>>.MoveNext
	|
	|-RVA: 0x33D790 Offset: 0x33D891 VA: 0x33D790
	|-Array.InternalEnumerator<KeyValuePair<object, double>>.MoveNext
	|
	|-RVA: 0x33D870 Offset: 0x33D971 VA: 0x33D870
	|-Array.InternalEnumerator<KeyValuePair<object, short>>.MoveNext
	|
	|-RVA: 0x33D950 Offset: 0x33DA51 VA: 0x33D950
	|-Array.InternalEnumerator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x33DA30 Offset: 0x33DB31 VA: 0x33DA30
	|-Array.InternalEnumerator<KeyValuePair<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x33DB10 Offset: 0x33DC11 VA: 0x33DB10
	|-Array.InternalEnumerator<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x33DBF0 Offset: 0x33DCF1 VA: 0x33DBF0
	|-Array.InternalEnumerator<KeyValuePair<object, Memory<object>>>.MoveNext
	|
	|-RVA: 0x33DCD0 Offset: 0x33DDD1 VA: 0x33DCD0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.MoveNext
	|
	|-RVA: 0x33DDB0 Offset: 0x33DEB1 VA: 0x33DDB0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.MoveNext
	|
	|-RVA: 0x33DE90 Offset: 0x33DF91 VA: 0x33DE90
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.MoveNext
	|
	|-RVA: 0x33DF70 Offset: 0x33E071 VA: 0x33DF70
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.MoveNext
	|
	|-RVA: 0x33E050 Offset: 0x33E151 VA: 0x33E050
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color>>>.MoveNext
	|
	|-RVA: 0x33E130 Offset: 0x33E231 VA: 0x33E130
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.MoveNext
	|
	|-RVA: 0x33E210 Offset: 0x33E311 VA: 0x33E210
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.MoveNext
	|
	|-RVA: 0x33E2F0 Offset: 0x33E3F1 VA: 0x33E2F0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.MoveNext
	|
	|-RVA: 0x33E3D0 Offset: 0x33E4D1 VA: 0x33E3D0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.MoveNext
	|
	|-RVA: 0x33E4B0 Offset: 0x33E5B1 VA: 0x33E4B0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.MoveNext
	|
	|-RVA: 0x33E590 Offset: 0x33E691 VA: 0x33E590
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.MoveNext
	|
	|-RVA: 0x33E670 Offset: 0x33E771 VA: 0x33E670
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.MoveNext
	|
	|-RVA: 0x33E750 Offset: 0x33E851 VA: 0x33E750
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.MoveNext
	|
	|-RVA: 0x33E830 Offset: 0x33E931 VA: 0x33E830
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.MoveNext
	|
	|-RVA: 0x33E910 Offset: 0x33EA11 VA: 0x33E910
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.MoveNext
	|
	|-RVA: 0x33E9F0 Offset: 0x33EAF1 VA: 0x33E9F0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.MoveNext
	|
	|-RVA: 0x33EAD0 Offset: 0x33EBD1 VA: 0x33EAD0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.MoveNext
	|
	|-RVA: 0x33EBB0 Offset: 0x33ECB1 VA: 0x33EBB0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.MoveNext
	|
	|-RVA: 0x33EC90 Offset: 0x33ED91 VA: 0x33EC90
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.MoveNext
	|
	|-RVA: 0x33ED70 Offset: 0x33EE71 VA: 0x33ED70
	|-Array.InternalEnumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x3554E0 Offset: 0x3555E1 VA: 0x3554E0
	|-Array.InternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.MoveNext
	|
	|-RVA: 0x3555C0 Offset: 0x3556C1 VA: 0x3555C0
	|-Array.InternalEnumerator<KeyValuePair<object, ResourceLocator>>.MoveNext
	|
	|-RVA: 0x3556A0 Offset: 0x3557A1 VA: 0x3556A0
	|-Array.InternalEnumerator<KeyValuePair<object, sbyte>>.MoveNext
	|
	|-RVA: 0x355780 Offset: 0x355881 VA: 0x355780
	|-Array.InternalEnumerator<KeyValuePair<object, float>>.MoveNext
	|
	|-RVA: 0x355860 Offset: 0x355961 VA: 0x355860
	|-Array.InternalEnumerator<KeyValuePair<object, ushort>>.MoveNext
	|
	|-RVA: 0x355940 Offset: 0x355A41 VA: 0x355940
	|-Array.InternalEnumerator<KeyValuePair<object, uint>>.MoveNext
	|
	|-RVA: 0x355A20 Offset: 0x355B21 VA: 0x355A20
	|-Array.InternalEnumerator<KeyValuePair<object, ulong>>.MoveNext
	|
	|-RVA: 0x355B00 Offset: 0x355C01 VA: 0x355B00
	|-Array.InternalEnumerator<KeyValuePair<object, TransitionTables>>.MoveNext
	|
	|-RVA: 0x355BE0 Offset: 0x355CE1 VA: 0x355BE0
	|-Array.InternalEnumerator<KeyValuePair<object, Bounds>>.MoveNext
	|
	|-RVA: 0x355CC0 Offset: 0x355DC1 VA: 0x355CC0
	|-Array.InternalEnumerator<KeyValuePair<object, BoundsInt>>.MoveNext
	|
	|-RVA: 0x355DA0 Offset: 0x355EA1 VA: 0x355DA0
	|-Array.InternalEnumerator<KeyValuePair<object, Color32>>.MoveNext
	|
	|-RVA: 0x355E80 Offset: 0x355F81 VA: 0x355E80
	|-Array.InternalEnumerator<KeyValuePair<object, Color>>.MoveNext
	|
	|-RVA: 0x355F60 Offset: 0x356061 VA: 0x355F60
	|-Array.InternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x356040 Offset: 0x356141 VA: 0x356040
	|-Array.InternalEnumerator<KeyValuePair<object, GradientColorKey>>.MoveNext
	|
	|-RVA: 0x356120 Offset: 0x356221 VA: 0x356120
	|-Array.InternalEnumerator<KeyValuePair<object, Keyframe>>.MoveNext
	|
	|-RVA: 0x356200 Offset: 0x356301 VA: 0x356200
	|-Array.InternalEnumerator<KeyValuePair<object, LayerMask>>.MoveNext
	|
	|-RVA: 0x3562E0 Offset: 0x3563E1 VA: 0x3562E0
	|-Array.InternalEnumerator<KeyValuePair<object, Matrix4x4>>.MoveNext
	|
	|-RVA: 0x3563C0 Offset: 0x3564C1 VA: 0x3563C0
	|-Array.InternalEnumerator<KeyValuePair<object, Playable>>.MoveNext
	|
	|-RVA: 0x3564A0 Offset: 0x3565A1 VA: 0x3564A0
	|-Array.InternalEnumerator<KeyValuePair<object, Quaternion>>.MoveNext
	|
	|-RVA: 0x356580 Offset: 0x356681 VA: 0x356580
	|-Array.InternalEnumerator<KeyValuePair<object, RangeInt>>.MoveNext
	|
	|-RVA: 0x356660 Offset: 0x356761 VA: 0x356660
	|-Array.InternalEnumerator<KeyValuePair<object, Rect>>.MoveNext
	|
	|-RVA: 0x356740 Offset: 0x356841 VA: 0x356740
	|-Array.InternalEnumerator<KeyValuePair<object, RectInt>>.MoveNext
	|
	|-RVA: 0x356820 Offset: 0x356921 VA: 0x356820
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x356900 Offset: 0x356A01 VA: 0x356900
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.MoveNext
	|
	|-RVA: 0x3569E0 Offset: 0x356AE1 VA: 0x3569E0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2>>.MoveNext
	|
	|-RVA: 0x356AC0 Offset: 0x356BC1 VA: 0x356AC0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2Int>>.MoveNext
	|
	|-RVA: 0x356BA0 Offset: 0x356CA1 VA: 0x356BA0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3>>.MoveNext
	|
	|-RVA: 0x356C80 Offset: 0x356D81 VA: 0x356C80
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3Int>>.MoveNext
	|
	|-RVA: 0x356D60 Offset: 0x356E61 VA: 0x356D60
	|-Array.InternalEnumerator<KeyValuePair<object, Vector4>>.MoveNext
	|
	|-RVA: 0x356E40 Offset: 0x356F41 VA: 0x356E40
	|-Array.InternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.MoveNext
	|
	|-RVA: 0x356F20 Offset: 0x357021 VA: 0x356F20
	|-Array.InternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.MoveNext
	|
	|-RVA: 0x357000 Offset: 0x357101 VA: 0x357000
	|-Array.InternalEnumerator<KeyValuePair<sbyte, object>>.MoveNext
	|
	|-RVA: 0x3570E0 Offset: 0x3571E1 VA: 0x3570E0
	|-Array.InternalEnumerator<KeyValuePair<float, CurveSample>>.MoveNext
	|
	|-RVA: 0x3571C0 Offset: 0x3572C1 VA: 0x3571C0
	|-Array.InternalEnumerator<KeyValuePair<float, object>>.MoveNext
	|
	|-RVA: 0x3572A0 Offset: 0x3573A1 VA: 0x3572A0
	|-Array.InternalEnumerator<KeyValuePair<ushort, object>>.MoveNext
	|
	|-RVA: 0x357380 Offset: 0x357481 VA: 0x357380
	|-Array.InternalEnumerator<KeyValuePair<uint, int>>.MoveNext
	|
	|-RVA: 0x3574E0 Offset: 0x3575E1 VA: 0x3574E0
	|-Array.InternalEnumerator<KeyValuePair<uint, Int32Enum>>.MoveNext
	|
	|-RVA: 0x357640 Offset: 0x357741 VA: 0x357640
	|-Array.InternalEnumerator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x357720 Offset: 0x357821 VA: 0x357720
	|-Array.InternalEnumerator<KeyValuePair<ulong, object>>.MoveNext
	|
	|-RVA: 0x357800 Offset: 0x357901 VA: 0x357800
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.MoveNext
	|
	|-RVA: 0x3578F0 Offset: 0x3579F1 VA: 0x3578F0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.MoveNext
	|
	|-RVA: 0x3579D0 Offset: 0x357AD1 VA: 0x3579D0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.MoveNext
	|
	|-RVA: 0x357AB0 Offset: 0x357BB1 VA: 0x357AB0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.MoveNext
	|
	|-RVA: 0x357B90 Offset: 0x357C91 VA: 0x357B90
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.MoveNext
	|
	|-RVA: 0x357C80 Offset: 0x357D81 VA: 0x357C80
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.MoveNext
	|
	|-RVA: 0x357D60 Offset: 0x357E61 VA: 0x357D60
	|-Array.InternalEnumerator<KeyValuePair<Bounds, object>>.MoveNext
	|
	|-RVA: 0x357E40 Offset: 0x357F41 VA: 0x357E40
	|-Array.InternalEnumerator<KeyValuePair<BoundsInt, object>>.MoveNext
	|
	|-RVA: 0x357F20 Offset: 0x358021 VA: 0x357F20
	|-Array.InternalEnumerator<KeyValuePair<Color, object>>.MoveNext
	|
	|-RVA: 0x358000 Offset: 0x358101 VA: 0x358000
	|-Array.InternalEnumerator<KeyValuePair<Color32, object>>.MoveNext
	|
	|-RVA: 0x3580E0 Offset: 0x3581E1 VA: 0x3580E0
	|-Array.InternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.MoveNext
	|
	|-RVA: 0x3581C0 Offset: 0x3582C1 VA: 0x3581C0
	|-Array.InternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.MoveNext
	|
	|-RVA: 0x3582A0 Offset: 0x3583A1 VA: 0x3582A0
	|-Array.InternalEnumerator<KeyValuePair<GradientColorKey, object>>.MoveNext
	|
	|-RVA: 0x358380 Offset: 0x358481 VA: 0x358380
	|-Array.InternalEnumerator<KeyValuePair<Keyframe, object>>.MoveNext
	|
	|-RVA: 0x358460 Offset: 0x358561 VA: 0x358460
	|-Array.InternalEnumerator<KeyValuePair<LayerMask, object>>.MoveNext
	|
	|-RVA: 0x358540 Offset: 0x358641 VA: 0x358540
	|-Array.InternalEnumerator<KeyValuePair<Matrix4x4, object>>.MoveNext
	|
	|-RVA: 0x358620 Offset: 0x358721 VA: 0x358620
	|-Array.InternalEnumerator<KeyValuePair<IntVec3, object>>.MoveNext
	|
	|-RVA: 0x358700 Offset: 0x358801 VA: 0x358700
	|-Array.InternalEnumerator<KeyValuePair<Quaternion, object>>.MoveNext
	|
	|-RVA: 0x3587E0 Offset: 0x3588E1 VA: 0x3587E0
	|-Array.InternalEnumerator<KeyValuePair<RangeInt, object>>.MoveNext
	|
	|-RVA: 0x3588C0 Offset: 0x3589C1 VA: 0x3588C0
	|-Array.InternalEnumerator<KeyValuePair<Rect, object>>.MoveNext
	|
	|-RVA: 0x3589A0 Offset: 0x358AA1 VA: 0x3589A0
	|-Array.InternalEnumerator<KeyValuePair<RectInt, object>>.MoveNext
	|
	|-RVA: 0x358A80 Offset: 0x358B81 VA: 0x358A80
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.MoveNext
	|
	|-RVA: 0x358B70 Offset: 0x358C71 VA: 0x358B70
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.MoveNext
	|
	|-RVA: 0x358C50 Offset: 0x358D51 VA: 0x358C50
	|-Array.InternalEnumerator<KeyValuePair<Vector2, object>>.MoveNext
	|
	|-RVA: 0x358D30 Offset: 0x358E31 VA: 0x358D30
	|-Array.InternalEnumerator<KeyValuePair<Vector2Int, object>>.MoveNext
	|
	|-RVA: 0x358E10 Offset: 0x358F11 VA: 0x358E10
	|-Array.InternalEnumerator<KeyValuePair<Vector3, object>>.MoveNext
	|
	|-RVA: 0x358EF0 Offset: 0x358FF1 VA: 0x358EF0
	|-Array.InternalEnumerator<KeyValuePair<Vector3Int, object>>.MoveNext
	|
	|-RVA: 0x358FD0 Offset: 0x3590D1 VA: 0x358FD0
	|-Array.InternalEnumerator<KeyValuePair<Vector4, object>>.MoveNext
	|
	|-RVA: 0x3590B0 Offset: 0x3591B1 VA: 0x3590B0
	|-Array.InternalEnumerator<Hashtable.bucket>.MoveNext
	|
	|-RVA: 0x359190 Offset: 0x359291 VA: 0x359190
	|-Array.InternalEnumerator<DateTime>.MoveNext
	|
	|-RVA: 0x3592F0 Offset: 0x3593F1 VA: 0x3592F0
	|-Array.InternalEnumerator<DateTimeOffset>.MoveNext
	|
	|-RVA: 0x3593D0 Offset: 0x3594D1 VA: 0x3593D0
	|-Array.InternalEnumerator<Decimal>.MoveNext
	|
	|-RVA: 0x3594B0 Offset: 0x3595B1 VA: 0x3594B0
	|-Array.InternalEnumerator<double>.MoveNext
	|
	|-RVA: 0x359610 Offset: 0x359711 VA: 0x359610
	|-Array.InternalEnumerator<InternalCodePageDataItem>.MoveNext
	|
	|-RVA: 0x3596F0 Offset: 0x3597F1 VA: 0x3596F0
	|-Array.InternalEnumerator<InternalEncodingDataItem>.MoveNext
	|
	|-RVA: 0x3597D0 Offset: 0x3598D1 VA: 0x3597D0
	|-Array.InternalEnumerator<Guid>.MoveNext
	|
	|-RVA: 0x3598B0 Offset: 0x3599B1 VA: 0x3598B0
	|-Array.InternalEnumerator<short>.MoveNext
	|
	|-RVA: 0x359A10 Offset: 0x359B11 VA: 0x359A10
	|-Array.InternalEnumerator<int>.MoveNext
	|
	|-RVA: 0x359B70 Offset: 0x359C71 VA: 0x359B70
	|-Array.InternalEnumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x359CD0 Offset: 0x359DD1 VA: 0x359CD0
	|-Array.InternalEnumerator<long>.MoveNext
	|
	|-RVA: 0x359E30 Offset: 0x359F31 VA: 0x359E30
	|-Array.InternalEnumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x359F90 Offset: 0x35A091 VA: 0x359F90
	|-Array.InternalEnumerator<InterpretedFrameInfo>.MoveNext
	|
	|-RVA: 0x35A070 Offset: 0x35A171 VA: 0x35A070
	|-Array.InternalEnumerator<LocalDefinition>.MoveNext
	|
	|-RVA: 0x35A150 Offset: 0x35A251 VA: 0x35A150
	|-Array.InternalEnumerator<RuntimeLabel>.MoveNext
	|
	|-RVA: 0x35A240 Offset: 0x35A341 VA: 0x35A240
	|-Array.InternalEnumerator<Set.Slot<int>>.MoveNext
	|
	|-RVA: 0x35A330 Offset: 0x35A431 VA: 0x35A330
	|-Array.InternalEnumerator<Set.Slot<object>>.MoveNext
	|
	|-RVA: 0x35A410 Offset: 0x35A511 VA: 0x35A410
	|-Array.InternalEnumerator<Memory<object>>.MoveNext
	|
	|-RVA: 0x35A4F0 Offset: 0x35A5F1 VA: 0x35A4F0
	|-Array.InternalEnumerator<CookieTokenizer.RecognizedAttribute>.MoveNext
	|
	|-RVA: 0x35A5D0 Offset: 0x35A6D1 VA: 0x35A5D0
	|-Array.InternalEnumerator<HeaderVariantInfo>.MoveNext
	|
	|-RVA: 0x35A6B0 Offset: 0x35A7B1 VA: 0x35A6B0
	|-Array.InternalEnumerator<Socket.WSABUF>.MoveNext
	|
	|-RVA: 0x35A790 Offset: 0x35A891 VA: 0x35A790
	|-Array.InternalEnumerator<Nullable<ReadOnlySequence<byte>>>.MoveNext
	|
	|-RVA: 0x35A870 Offset: 0x35A971 VA: 0x35A870
	|-Array.InternalEnumerator<Nullable<Int32Enum>>.MoveNext
	|
	|-RVA: 0x35A9D0 Offset: 0x35AAD1 VA: 0x35A9D0
	|-Array.InternalEnumerator<Nullable<Bounds>>.MoveNext
	|
	|-RVA: 0x35AAB0 Offset: 0x35ABB1 VA: 0x35AAB0
	|-Array.InternalEnumerator<Nullable<BoundsInt>>.MoveNext
	|
	|-RVA: 0x35AB90 Offset: 0x35AC91 VA: 0x35AB90
	|-Array.InternalEnumerator<Nullable<Color32>>.MoveNext
	|
	|-RVA: 0x35ACF0 Offset: 0x35ADF1 VA: 0x35ACF0
	|-Array.InternalEnumerator<Nullable<Color>>.MoveNext
	|
	|-RVA: 0x35ADD0 Offset: 0x35AED1 VA: 0x35ADD0
	|-Array.InternalEnumerator<Nullable<GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x35AEC0 Offset: 0x35AFC1 VA: 0x35AEC0
	|-Array.InternalEnumerator<Nullable<GradientColorKey>>.MoveNext
	|
	|-RVA: 0x35AFA0 Offset: 0x35B0A1 VA: 0x35AFA0
	|-Array.InternalEnumerator<Nullable<Keyframe>>.MoveNext
	|
	|-RVA: 0x35B080 Offset: 0x35B181 VA: 0x35B080
	|-Array.InternalEnumerator<Nullable<LayerMask>>.MoveNext
	|
	|-RVA: 0x35B1E0 Offset: 0x35B2E1 VA: 0x35B1E0
	|-Array.InternalEnumerator<Nullable<Matrix4x4>>.MoveNext
	|
	|-RVA: 0x35B2C0 Offset: 0x35B3C1 VA: 0x35B2C0
	|-Array.InternalEnumerator<Nullable<Quaternion>>.MoveNext
	|
	|-RVA: 0x35B3A0 Offset: 0x35B4A1 VA: 0x35B3A0
	|-Array.InternalEnumerator<Nullable<RangeInt>>.MoveNext
	|
	|-RVA: 0x35B490 Offset: 0x35B591 VA: 0x35B490
	|-Array.InternalEnumerator<Nullable<Rect>>.MoveNext
	|
	|-RVA: 0x35B570 Offset: 0x35B671 VA: 0x35B570
	|-Array.InternalEnumerator<Nullable<RectInt>>.MoveNext
	|
	|-RVA: 0x35B650 Offset: 0x35B751 VA: 0x35B650
	|-Array.InternalEnumerator<Nullable<Vector2>>.MoveNext
	|
	|-RVA: 0x35B740 Offset: 0x35B841 VA: 0x35B740
	|-Array.InternalEnumerator<Nullable<Vector2Int>>.MoveNext
	|
	|-RVA: 0x35B830 Offset: 0x35B931 VA: 0x35B830
	|-Array.InternalEnumerator<Nullable<Vector3>>.MoveNext
	|
	|-RVA: 0x342A10 Offset: 0x342B11 VA: 0x342A10
	|-Array.InternalEnumerator<Nullable<Vector3Int>>.MoveNext
	|
	|-RVA: 0x342AF0 Offset: 0x342BF1 VA: 0x342AF0
	|-Array.InternalEnumerator<Nullable<Vector4>>.MoveNext
	|
	|-RVA: 0x342BD0 Offset: 0x342CD1 VA: 0x342BD0
	|-Array.InternalEnumerator<object>.MoveNext
	|
	|-RVA: 0x342CE0 Offset: 0x342DE1 VA: 0x342CE0
	|-Array.InternalEnumerator<ParameterizedStrings.FormatParam>.MoveNext
	|
	|-RVA: 0x342DC0 Offset: 0x342EC1 VA: 0x342DC0
	|-Array.InternalEnumerator<ReadOnlyMemory<object>>.MoveNext
	|
	|-RVA: 0x342EA0 Offset: 0x342FA1 VA: 0x342EA0
	|-Array.InternalEnumerator<CustomAttributeNamedArgument>.MoveNext
	|
	|-RVA: 0x342F80 Offset: 0x343081 VA: 0x342F80
	|-Array.InternalEnumerator<CustomAttributeTypedArgument>.MoveNext
	|
	|-RVA: 0x343060 Offset: 0x343161 VA: 0x343060
	|-Array.InternalEnumerator<Label>.MoveNext
	|
	|-RVA: 0x3431D0 Offset: 0x3432D1 VA: 0x3431D0
	|-Array.InternalEnumerator<ParameterModifier>.MoveNext
	|
	|-RVA: 0x343330 Offset: 0x343431 VA: 0x343330
	|-Array.InternalEnumerator<ResourceLocator>.MoveNext
	|
	|-RVA: 0x343410 Offset: 0x343511 VA: 0x343410
	|-Array.InternalEnumerator<Ephemeron>.MoveNext
	|
	|-RVA: 0x3434F0 Offset: 0x3435F1 VA: 0x3434F0
	|-Array.InternalEnumerator<GCHandle>.MoveNext
	|
	|-RVA: 0x343660 Offset: 0x343761 VA: 0x343660
	|-Array.InternalEnumerator<RuntimeTypeHandle>.MoveNext
	|
	|-RVA: 0x3437C0 Offset: 0x3438C1 VA: 0x3437C0
	|-Array.InternalEnumerator<sbyte>.MoveNext
	|
	|-RVA: 0x343920 Offset: 0x343A21 VA: 0x343920
	|-Array.InternalEnumerator<X509ChainStatus>.MoveNext
	|
	|-RVA: 0x343A00 Offset: 0x343B01 VA: 0x343A00
	|-Array.InternalEnumerator<float>.MoveNext
	|
	|-RVA: 0x343B60 Offset: 0x343C61 VA: 0x343B60
	|-Array.InternalEnumerator<RegexCharClass.LowerCaseMapping>.MoveNext
	|
	|-RVA: 0x343C50 Offset: 0x343D51 VA: 0x343C50
	|-Array.InternalEnumerator<CancellationTokenRegistration>.MoveNext
	|
	|-RVA: 0x343D30 Offset: 0x343E31 VA: 0x343D30
	|-Array.InternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.MoveNext
	|
	|-RVA: 0x343E90 Offset: 0x343F91 VA: 0x343E90
	|-Array.InternalEnumerator<TimeSpan>.MoveNext
	|
	|-RVA: 0x343FF0 Offset: 0x3440F1 VA: 0x343FF0
	|-Array.InternalEnumerator<ushort>.MoveNext
	|
	|-RVA: 0x344150 Offset: 0x344251 VA: 0x344150
	|-Array.InternalEnumerator<UInt16Enum>.MoveNext
	|
	|-RVA: 0x3442B0 Offset: 0x3443B1 VA: 0x3442B0
	|-Array.InternalEnumerator<uint>.MoveNext
	|
	|-RVA: 0x344410 Offset: 0x344511 VA: 0x344410
	|-Array.InternalEnumerator<UInt32Enum>.MoveNext
	|
	|-RVA: 0x344570 Offset: 0x344671 VA: 0x344570
	|-Array.InternalEnumerator<ulong>.MoveNext
	|
	|-RVA: 0x3446D0 Offset: 0x3447D1 VA: 0x3446D0
	|-Array.InternalEnumerator<ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x344830 Offset: 0x344931 VA: 0x344830
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x344990 Offset: 0x344A91 VA: 0x344990
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x344A70 Offset: 0x344B71 VA: 0x344A70
	|-Array.InternalEnumerator<ValueTuple<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x344B50 Offset: 0x344C51 VA: 0x344B50
	|-Array.InternalEnumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x344C30 Offset: 0x344D31 VA: 0x344C30
	|-Array.InternalEnumerator<ValueTuple<object, float>>.MoveNext
	|
	|-RVA: 0x344D10 Offset: 0x344E11 VA: 0x344D10
	|-Array.InternalEnumerator<ValueTuple<float, object>>.MoveNext
	|
	|-RVA: 0x344DF0 Offset: 0x344EF1 VA: 0x344DF0
	|-Array.InternalEnumerator<ValueTuple<float, float>>.MoveNext
	|
	|-RVA: 0x344ED0 Offset: 0x344FD1 VA: 0x344ED0
	|-Array.InternalEnumerator<ValueTuple<Vector3, Quaternion>>.MoveNext
	|
	|-RVA: 0x344FB0 Offset: 0x3450B1 VA: 0x344FB0
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x3450A0 Offset: 0x3451A1 VA: 0x3450A0
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3>>.MoveNext
	|
	|-RVA: 0x345180 Offset: 0x345281 VA: 0x345180
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3, float>>.MoveNext
	|
	|-RVA: 0x345260 Offset: 0x345361 VA: 0x345260
	|-Array.InternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.MoveNext
	|
	|-RVA: 0x345340 Offset: 0x345441 VA: 0x345340
	|-Array.InternalEnumerator<HighlightState>.MoveNext
	|
	|-RVA: 0x345420 Offset: 0x345521 VA: 0x345420
	|-Array.InternalEnumerator<MaterialReference>.MoveNext
	|
	|-RVA: 0x345500 Offset: 0x345601 VA: 0x345500
	|-Array.InternalEnumerator<RichTextTagAttribute>.MoveNext
	|
	|-RVA: 0x3455E0 Offset: 0x3456E1 VA: 0x3455E0
	|-Array.InternalEnumerator<TexturePacker_JsonArray.Frame>.MoveNext
	|
	|-RVA: 0x3456C0 Offset: 0x3457C1 VA: 0x3456C0
	|-Array.InternalEnumerator<TMP_CharacterInfo>.MoveNext
	|
	|-RVA: 0x3457A0 Offset: 0x3458A1 VA: 0x3457A0
	|-Array.InternalEnumerator<TMP_FontWeightPair>.MoveNext
	|
	|-RVA: 0x345880 Offset: 0x345981 VA: 0x345880
	|-Array.InternalEnumerator<TMP_LineInfo>.MoveNext
	|
	|-RVA: 0x345960 Offset: 0x345A61 VA: 0x345960
	|-Array.InternalEnumerator<TMP_LinkInfo>.MoveNext
	|
	|-RVA: 0x345A40 Offset: 0x345B41 VA: 0x345A40
	|-Array.InternalEnumerator<TMP_MeshInfo>.MoveNext
	|
	|-RVA: 0x345B20 Offset: 0x345C21 VA: 0x345B20
	|-Array.InternalEnumerator<TMP_PageInfo>.MoveNext
	|
	|-RVA: 0x345C00 Offset: 0x345D01 VA: 0x345C00
	|-Array.InternalEnumerator<TMP_Text.UnicodeChar>.MoveNext
	|
	|-RVA: 0x345CF0 Offset: 0x345DF1 VA: 0x345CF0
	|-Array.InternalEnumerator<TMP_TextProcessingStack<int>>.MoveNext
	|
	|-RVA: 0x345DD0 Offset: 0x345ED1 VA: 0x345DD0
	|-Array.InternalEnumerator<TMP_WordInfo>.MoveNext
	|
	|-RVA: 0x345EB0 Offset: 0x345FB1 VA: 0x345EB0
	|-Array.InternalEnumerator<WordWrapState>.MoveNext
	|
	|-RVA: 0x345F90 Offset: 0x346091 VA: 0x345F90
	|-Array.InternalEnumerator<TextPaneDatas.TextPaneData>.MoveNext
	|
	|-RVA: 0x346070 Offset: 0x346171 VA: 0x346070
	|-Array.InternalEnumerator<TransitionTables>.MoveNext
	|
	|-RVA: 0x346150 Offset: 0x346251 VA: 0x346150
	|-Array.InternalEnumerator<TutorialUnlockFlagData>.MoveNext
	|
	|-RVA: 0x346240 Offset: 0x346341 VA: 0x346240
	|-Array.InternalEnumerator<UICheckOnBackRune.LinkSet>.MoveNext
	|
	|-RVA: 0x346320 Offset: 0x346421 VA: 0x346320
	|-Array.InternalEnumerator<UIMainManagerAttachObject.AttachSet>.MoveNext
	|
	|-RVA: 0x346400 Offset: 0x346501 VA: 0x346400
	|-Array.InternalEnumerator<CapEdge>.MoveNext
	|
	|-RVA: 0x3464E0 Offset: 0x3465E1 VA: 0x3464E0
	|-Array.InternalEnumerator<ClippedEdge>.MoveNext
	|
	|-RVA: 0x3465C0 Offset: 0x3466C1 VA: 0x3465C0
	|-Array.InternalEnumerator<EdgeKeyByHash>.MoveNext
	|
	|-RVA: 0x346720 Offset: 0x346821 VA: 0x346720
	|-Array.InternalEnumerator<EdgeKeyByIndex>.MoveNext
	|
	|-RVA: 0x346880 Offset: 0x346981 VA: 0x346880
	|-Array.InternalEnumerator<MeshDataConnectivity.Face>.MoveNext
	|
	|-RVA: 0x3469E0 Offset: 0x346AE1 VA: 0x3469E0
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.MoveNext
	|
	|-RVA: 0x346AC0 Offset: 0x346BC1 VA: 0x346AC0
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData>.MoveNext
	|
	|-RVA: 0x346BA0 Offset: 0x346CA1 VA: 0x346BA0
	|-Array.InternalEnumerator<NavMeshBuildMarkup>.MoveNext
	|
	|-RVA: 0x346C80 Offset: 0x346D81 VA: 0x346C80
	|-Array.InternalEnumerator<NavMeshBuildSource>.MoveNext
	|
	|-RVA: 0x346D60 Offset: 0x346E61 VA: 0x346D60
	|-Array.InternalEnumerator<ContentCatalogData.Bucket>.MoveNext
	|
	|-RVA: 0x346E40 Offset: 0x346F41 VA: 0x346E40
	|-Array.InternalEnumerator<ConstraintSource>.MoveNext
	|
	|-RVA: 0x346F20 Offset: 0x347021 VA: 0x346F20
	|-Array.InternalEnumerator<PropertySceneHandle>.MoveNext
	|
	|-RVA: 0x347080 Offset: 0x347181 VA: 0x347080
	|-Array.InternalEnumerator<TransformStreamHandle>.MoveNext
	|
	|-RVA: 0x347170 Offset: 0x347271 VA: 0x347170
	|-Array.InternalEnumerator<AnimatorClipInfo>.MoveNext
	|
	|-RVA: 0x3472D0 Offset: 0x3473D1 VA: 0x3472D0
	|-Array.InternalEnumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x3473B0 Offset: 0x3474B1 VA: 0x3473B0
	|-Array.InternalEnumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x347510 Offset: 0x347611 VA: 0x347510
	|-Array.InternalEnumerator<BoneWeight>.MoveNext
	|
	|-RVA: 0x3475F0 Offset: 0x3476F1 VA: 0x3475F0
	|-Array.InternalEnumerator<BoundingSphere>.MoveNext
	|
	|-RVA: 0x3476D0 Offset: 0x3477D1 VA: 0x3476D0
	|-Array.InternalEnumerator<Bounds>.MoveNext
	|
	|-RVA: 0x3477B0 Offset: 0x3478B1 VA: 0x3477B0
	|-Array.InternalEnumerator<BoundsInt>.MoveNext
	|
	|-RVA: 0x347890 Offset: 0x347991 VA: 0x347890
	|-Array.InternalEnumerator<CharacterInfo>.MoveNext
	|
	|-RVA: 0x347970 Offset: 0x347A71 VA: 0x347970
	|-Array.InternalEnumerator<Color32>.MoveNext
	|
	|-RVA: 0x347AE0 Offset: 0x347BE1 VA: 0x347AE0
	|-Array.InternalEnumerator<Color>.MoveNext
	|
	|-RVA: 0x347BC0 Offset: 0x347CC1 VA: 0x347BC0
	|-Array.InternalEnumerator<CombineInstance>.MoveNext
	|
	|-RVA: 0x347CA0 Offset: 0x347DA1 VA: 0x347CA0
	|-Array.InternalEnumerator<ContactPoint2D>.MoveNext
	|
	|-RVA: 0x347D80 Offset: 0x347E81 VA: 0x347D80
	|-Array.InternalEnumerator<ContactPoint>.MoveNext
	|
	|-RVA: 0x347E60 Offset: 0x347F61 VA: 0x347E60
	|-Array.InternalEnumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x347F40 Offset: 0x348041 VA: 0x347F40
	|-Array.InternalEnumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x348020 Offset: 0x348121 VA: 0x348020
	|-Array.InternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.MoveNext
	|
	|-RVA: 0x348180 Offset: 0x348281 VA: 0x348180
	|-Array.InternalEnumerator<GradientAlphaKey>.MoveNext
	|
	|-RVA: 0x348260 Offset: 0x348361 VA: 0x348260
	|-Array.InternalEnumerator<GradientColorKey>.MoveNext
	|
	|-RVA: 0x348340 Offset: 0x348441 VA: 0x348340
	|-Array.InternalEnumerator<HumanBone>.MoveNext
	|
	|-RVA: 0x348420 Offset: 0x348521 VA: 0x348420
	|-Array.InternalEnumerator<Keyframe>.MoveNext
	|
	|-RVA: 0x348500 Offset: 0x348601 VA: 0x348500
	|-Array.InternalEnumerator<LOD>.MoveNext
	|
	|-RVA: 0x3485E0 Offset: 0x3486E1 VA: 0x3485E0
	|-Array.InternalEnumerator<LayerMask>.MoveNext
	|
	|-RVA: 0x348750 Offset: 0x348851 VA: 0x348750
	|-Array.InternalEnumerator<PlayerLoopSystem>.MoveNext
	|
	|-RVA: 0x348830 Offset: 0x348931 VA: 0x348830
	|-Array.InternalEnumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x348910 Offset: 0x348A11 VA: 0x348910
	|-Array.InternalEnumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x3489F0 Offset: 0x348AF1 VA: 0x3489F0
	|-Array.InternalEnumerator<PatchExtents>.MoveNext
	|
	|-RVA: 0x348AD0 Offset: 0x348BD1 VA: 0x348AD0
	|-Array.InternalEnumerator<Plane>.MoveNext
	|
	|-RVA: 0x348BB0 Offset: 0x348CB1 VA: 0x348BB0
	|-Array.InternalEnumerator<Playable>.MoveNext
	|
	|-RVA: 0x348C90 Offset: 0x348D91 VA: 0x348C90
	|-Array.InternalEnumerator<PlayableBinding>.MoveNext
	|
	|-RVA: 0x348D70 Offset: 0x348E71 VA: 0x348D70
	|-Array.InternalEnumerator<PlayableGraph>.MoveNext
	|
	|-RVA: 0x348E50 Offset: 0x348F51 VA: 0x348E50
	|-Array.InternalEnumerator<Edge>.MoveNext
	|
	|-RVA: 0x348FB0 Offset: 0x3490B1 VA: 0x348FB0
	|-Array.InternalEnumerator<IntVec3>.MoveNext
	|
	|-RVA: 0x349090 Offset: 0x349191 VA: 0x349090
	|-Array.InternalEnumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x349170 Offset: 0x349271 VA: 0x349170
	|-Array.InternalEnumerator<RangeInt>.MoveNext
	|
	|-RVA: 0x3492D0 Offset: 0x3493D1 VA: 0x3492D0
	|-Array.InternalEnumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x3493B0 Offset: 0x3494B1 VA: 0x3493B0
	|-Array.InternalEnumerator<RaycastHit>.MoveNext
	|
	|-RVA: 0x349490 Offset: 0x349591 VA: 0x349490
	|-Array.InternalEnumerator<Rect>.MoveNext
	|
	|-RVA: 0x349570 Offset: 0x349671 VA: 0x349570
	|-Array.InternalEnumerator<RectInt>.MoveNext
	|
	|-RVA: 0x349650 Offset: 0x349751 VA: 0x349650
	|-Array.InternalEnumerator<RenderBuffer>.MoveNext
	|
	|-RVA: 0x327D40 Offset: 0x327E41 VA: 0x327D40
	|-Array.InternalEnumerator<BatchVisibility>.MoveNext
	|
	|-RVA: 0x327E30 Offset: 0x327F31 VA: 0x327E30
	|-Array.InternalEnumerator<ReflectionProbeBlendInfo>.MoveNext
	|
	|-RVA: 0x327F10 Offset: 0x328011 VA: 0x327F10
	|-Array.InternalEnumerator<SphericalHarmonicsL2>.MoveNext
	|
	|-RVA: 0x327FF0 Offset: 0x3280F1 VA: 0x327FF0
	|-Array.InternalEnumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x3280D0 Offset: 0x3281D1 VA: 0x3280D0
	|-Array.InternalEnumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x3281B0 Offset: 0x3282B1 VA: 0x3281B0
	|-Array.InternalEnumerator<AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x328290 Offset: 0x328391 VA: 0x328290
	|-Array.InternalEnumerator<AsyncOperationHandle<SceneInstance>>.MoveNext
	|
	|-RVA: 0x328370 Offset: 0x328471 VA: 0x328370
	|-Array.InternalEnumerator<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x328450 Offset: 0x328551 VA: 0x328450
	|-Array.InternalEnumerator<SceneInstance>.MoveNext
	|
	|-RVA: 0x328530 Offset: 0x328631 VA: 0x328530
	|-Array.InternalEnumerator<DelayedActionManager.DelegateInfo>.MoveNext
	|
	|-RVA: 0x328610 Offset: 0x328711 VA: 0x328610
	|-Array.InternalEnumerator<ObjectInitializationData>.MoveNext
	|
	|-RVA: 0x3286F0 Offset: 0x3287F1 VA: 0x3286F0
	|-Array.InternalEnumerator<SerializedType>.MoveNext
	|
	|-RVA: 0x3287D0 Offset: 0x3288D1 VA: 0x3287D0
	|-Array.InternalEnumerator<SendMouseEvents.HitInfo>.MoveNext
	|
	|-RVA: 0x3288B0 Offset: 0x3289B1 VA: 0x3288B0
	|-Array.InternalEnumerator<SkeletonBone>.MoveNext
	|
	|-RVA: 0x328990 Offset: 0x328A91 VA: 0x328990
	|-Array.InternalEnumerator<GlyphRect>.MoveNext
	|
	|-RVA: 0x328A70 Offset: 0x328B71 VA: 0x328A70
	|-Array.InternalEnumerator<GlyphMarshallingStruct>.MoveNext
	|
	|-RVA: 0x328B50 Offset: 0x328C51 VA: 0x328B50
	|-Array.InternalEnumerator<GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x328C30 Offset: 0x328D31 VA: 0x328C30
	|-Array.InternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNext
	|
	|-RVA: 0x328D10 Offset: 0x328E11 VA: 0x328D10
	|-Array.InternalEnumerator<IntervalTreeNode>.MoveNext
	|
	|-RVA: 0x328DF0 Offset: 0x328EF1 VA: 0x328DF0
	|-Array.InternalEnumerator<IntervalTree.Entry<object>>.MoveNext
	|
	|-RVA: 0x328ED0 Offset: 0x328FD1 VA: 0x328ED0
	|-Array.InternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNext
	|
	|-RVA: 0x328FB0 Offset: 0x3290B1 VA: 0x328FB0
	|-Array.InternalEnumerator<Touch>.MoveNext
	|
	|-RVA: 0x329090 Offset: 0x329191 VA: 0x329090
	|-Array.InternalEnumerator<TreeInstance>.MoveNext
	|
	|-RVA: 0x329170 Offset: 0x329271 VA: 0x329170
	|-Array.InternalEnumerator<ColorBlock>.MoveNext
	|
	|-RVA: 0x329250 Offset: 0x329351 VA: 0x329250
	|-Array.InternalEnumerator<Navigation>.MoveNext
	|
	|-RVA: 0x329330 Offset: 0x329431 VA: 0x329330
	|-Array.InternalEnumerator<SpriteState>.MoveNext
	|
	|-RVA: 0x329410 Offset: 0x329511 VA: 0x329410
	|-Array.InternalEnumerator<UICharInfo>.MoveNext
	|
	|-RVA: 0x3294F0 Offset: 0x3295F1 VA: 0x3294F0
	|-Array.InternalEnumerator<EventDispatcher.DispatchContext>.MoveNext
	|
	|-RVA: 0x3295D0 Offset: 0x3296D1 VA: 0x3295D0
	|-Array.InternalEnumerator<EventDispatcher.EventRecord>.MoveNext
	|
	|-RVA: 0x3296B0 Offset: 0x3297B1 VA: 0x3296B0
	|-Array.InternalEnumerator<FocusController.FocusedElement>.MoveNext
	|
	|-RVA: 0x329790 Offset: 0x329891 VA: 0x329790
	|-Array.InternalEnumerator<StyleSheetCache.SheetHandleKey>.MoveNext
	|
	|-RVA: 0x3298F0 Offset: 0x3299F1 VA: 0x3298F0
	|-Array.InternalEnumerator<StyleValue>.MoveNext
	|
	|-RVA: 0x3299D0 Offset: 0x329AD1 VA: 0x3299D0
	|-Array.InternalEnumerator<UILineInfo>.MoveNext
	|
	|-RVA: 0x329AB0 Offset: 0x329BB1 VA: 0x329AB0
	|-Array.InternalEnumerator<UIVertex>.MoveNext
	|
	|-RVA: 0x329B90 Offset: 0x329C91 VA: 0x329B90
	|-Array.InternalEnumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x329C70 Offset: 0x329D71 VA: 0x329C70
	|-Array.InternalEnumerator<Vector2>.MoveNext
	|
	|-RVA: 0x329D50 Offset: 0x329E51 VA: 0x329D50
	|-Array.InternalEnumerator<Vector2Int>.MoveNext
	|
	|-RVA: 0x329EB0 Offset: 0x329FB1 VA: 0x329EB0
	|-Array.InternalEnumerator<Vector3>.MoveNext
	|
	|-RVA: 0x329F90 Offset: 0x32A091 VA: 0x329F90
	|-Array.InternalEnumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x32A080 Offset: 0x32A181 VA: 0x32A080
	|-Array.InternalEnumerator<Vector4>.MoveNext
	|
	|-RVA: 0x32A160 Offset: 0x32A261 VA: 0x32A160
	|-Array.InternalEnumerator<jvalue>.MoveNext
	|
	|-RVA: 0x32A2C0 Offset: 0x32A3C1 VA: 0x32A2C0
	|-Array.InternalEnumerator<WarpPoints.WarpPoint>.MoveNext
	|
	|-RVA: 0x32A3A0 Offset: 0x32A4A1 VA: 0x32A3A0
	|-Array.InternalEnumerator<YieldItemParam>.MoveNext
	|
	|-RVA: 0x32A500 Offset: 0x32A601 VA: 0x32A500
	|-Array.InternalEnumerator<NetworkServiceAccountId>.MoveNext
	|
	|-RVA: 0x32A660 Offset: 0x32A761 VA: 0x32A660
	|-Array.InternalEnumerator<Uid>.MoveNext
	|
	|-RVA: 0x32A740 Offset: 0x32A841 VA: 0x32A740
	|-Array.InternalEnumerator<ConsumableServiceItemId>.MoveNext
	|
	|-RVA: 0x32A8A0 Offset: 0x32A9A1 VA: 0x32A8A0
	|-Array.InternalEnumerator<NsUid>.MoveNext
	|
	|-RVA: 0x32AA00 Offset: 0x32AB01 VA: 0x32AA00
	|-Array.InternalEnumerator<Friend>.MoveNext
	|
	|-RVA: 0x32AAE0 Offset: 0x32ABE1 VA: 0x32AAE0
	|-Array.InternalEnumerator<Profile>.MoveNext
	|
	|-RVA: 0x32ABC0 Offset: 0x32ACC1 VA: 0x32ABC0
	|-Array.InternalEnumerator<DirectoryEntry>.MoveNext
	|
	|-RVA: 0x32ACA0 Offset: 0x32ADA1 VA: 0x32ACA0
	|-Array.InternalEnumerator<DebugPadState>.MoveNext
	|
	|-RVA: 0x32AD80 Offset: 0x32AE81 VA: 0x32AD80
	|-Array.InternalEnumerator<GesturePoint>.MoveNext
	|
	|-RVA: 0x32AEE0 Offset: 0x32AFE1 VA: 0x32AEE0
	|-Array.InternalEnumerator<GestureState>.MoveNext
	|
	|-RVA: 0x32AFC0 Offset: 0x32B0C1 VA: 0x32AFC0
	|-Array.InternalEnumerator<NpadFullKeyState>.MoveNext
	|
	|-RVA: 0x32B0A0 Offset: 0x32B1A1 VA: 0x32B0A0
	|-Array.InternalEnumerator<NpadHandheldState>.MoveNext
	|
	|-RVA: 0x32B180 Offset: 0x32B281 VA: 0x32B180
	|-Array.InternalEnumerator<NpadJoyDualState>.MoveNext
	|
	|-RVA: 0x32B260 Offset: 0x32B361 VA: 0x32B260
	|-Array.InternalEnumerator<NpadJoyLeftState>.MoveNext
	|
	|-RVA: 0x32B340 Offset: 0x32B441 VA: 0x32B340
	|-Array.InternalEnumerator<NpadJoyRightState>.MoveNext
	|
	|-RVA: 0x32B420 Offset: 0x32B521 VA: 0x32B420
	|-Array.InternalEnumerator<NpadStateArrayItem>.MoveNext
	|
	|-RVA: 0x32B500 Offset: 0x32B601 VA: 0x32B500
	|-Array.InternalEnumerator<SixAxisSensorHandle>.MoveNext
	|
	|-RVA: 0x32B670 Offset: 0x32B771 VA: 0x32B670
	|-Array.InternalEnumerator<SixAxisSensorState>.MoveNext
	|
	|-RVA: 0x32B750 Offset: 0x32B851 VA: 0x32B750
	|-Array.InternalEnumerator<TouchScreenState10>.MoveNext
	|
	|-RVA: 0x32B830 Offset: 0x32B931 VA: 0x32B830
	|-Array.InternalEnumerator<TouchScreenState11>.MoveNext
	|
	|-RVA: 0x32B910 Offset: 0x32BA11 VA: 0x32B910
	|-Array.InternalEnumerator<TouchScreenState12>.MoveNext
	|
	|-RVA: 0x32B9F0 Offset: 0x32BAF1 VA: 0x32B9F0
	|-Array.InternalEnumerator<TouchScreenState13>.MoveNext
	|
	|-RVA: 0x32BAD0 Offset: 0x32BBD1 VA: 0x32BAD0
	|-Array.InternalEnumerator<TouchScreenState14>.MoveNext
	|
	|-RVA: 0x32BBB0 Offset: 0x32BCB1 VA: 0x32BBB0
	|-Array.InternalEnumerator<TouchScreenState15>.MoveNext
	|
	|-RVA: 0x32BC90 Offset: 0x32BD91 VA: 0x32BC90
	|-Array.InternalEnumerator<TouchScreenState16>.MoveNext
	|
	|-RVA: 0x32BD70 Offset: 0x32BE71 VA: 0x32BD70
	|-Array.InternalEnumerator<TouchScreenState1>.MoveNext
	|
	|-RVA: 0x32BE50 Offset: 0x32BF51 VA: 0x32BE50
	|-Array.InternalEnumerator<TouchScreenState2>.MoveNext
	|
	|-RVA: 0x32BF30 Offset: 0x32C031 VA: 0x32BF30
	|-Array.InternalEnumerator<TouchScreenState3>.MoveNext
	|
	|-RVA: 0x32C010 Offset: 0x32C111 VA: 0x32C010
	|-Array.InternalEnumerator<TouchScreenState4>.MoveNext
	|
	|-RVA: 0x32C0F0 Offset: 0x32C1F1 VA: 0x32C0F0
	|-Array.InternalEnumerator<TouchScreenState5>.MoveNext
	|
	|-RVA: 0x32C1D0 Offset: 0x32C2D1 VA: 0x32C1D0
	|-Array.InternalEnumerator<TouchScreenState6>.MoveNext
	|
	|-RVA: 0x32C2B0 Offset: 0x32C3B1 VA: 0x32C2B0
	|-Array.InternalEnumerator<TouchScreenState7>.MoveNext
	|
	|-RVA: 0x32C390 Offset: 0x32C491 VA: 0x32C390
	|-Array.InternalEnumerator<TouchScreenState8>.MoveNext
	|
	|-RVA: 0x32C470 Offset: 0x32C571 VA: 0x32C470
	|-Array.InternalEnumerator<TouchScreenState9>.MoveNext
	|
	|-RVA: 0x32C550 Offset: 0x32C651 VA: 0x32C550
	|-Array.InternalEnumerator<TouchState>.MoveNext
	|
	|-RVA: 0x32C630 Offset: 0x32C731 VA: 0x32C630
	|-Array.InternalEnumerator<VibrationDeviceHandle>.MoveNext
	|
	|-RVA: 0x32C7A0 Offset: 0x32C8A1 VA: 0x32C7A0
	|-Array.InternalEnumerator<VibrationDeviceInfo>.MoveNext
	|
	|-RVA: 0x32C900 Offset: 0x32CA01 VA: 0x32C900
	|-Array.InternalEnumerator<VibrationValue>.MoveNext
	|
	|-RVA: 0x32C9E0 Offset: 0x32CAE1 VA: 0x32C9E0
	|-Array.InternalEnumerator<ClusteringData>.MoveNext
	|
	|-RVA: 0x32CAC0 Offset: 0x32CBC1 VA: 0x32CAC0
	|-Array.InternalEnumerator<ClusteringProcessorState>.MoveNext
	|
	|-RVA: 0x32CBA0 Offset: 0x32CCA1 VA: 0x32CBA0
	|-Array.InternalEnumerator<Finger>.MoveNext
	|
	|-RVA: 0x32CC80 Offset: 0x32CD81 VA: 0x32CC80
	|-Array.InternalEnumerator<Hand>.MoveNext
	|
	|-RVA: 0x32CD60 Offset: 0x32CE61 VA: 0x32CD60
	|-Array.InternalEnumerator<HandAnalysisImageState>.MoveNext
	|
	|-RVA: 0x32CE40 Offset: 0x32CF41 VA: 0x32CE40
	|-Array.InternalEnumerator<HandAnalysisSilhouetteState>.MoveNext
	|
	|-RVA: 0x32CF20 Offset: 0x32D021 VA: 0x32CF20
	|-Array.InternalEnumerator<MomentProcessorState>.MoveNext
	|
	|-RVA: 0x32D000 Offset: 0x32D101 VA: 0x32D000
	|-Array.InternalEnumerator<MomentStatistic>.MoveNext
	|
	|-RVA: 0x32D0E0 Offset: 0x32D1E1 VA: 0x32D0E0
	|-Array.InternalEnumerator<Protrusion>.MoveNext
	|
	|-RVA: 0x32D240 Offset: 0x32D341 VA: 0x32D240
	|-Array.InternalEnumerator<Shape>.MoveNext
	|
	|-RVA: 0x32D320 Offset: 0x32D421 VA: 0x32D320
	|-Array.InternalEnumerator<DictionaryInfo>.MoveNext
	|
	|-RVA: 0x32D480 Offset: 0x32D581 VA: 0x32D480
	|-Array.InternalEnumerator<UserWord>.MoveNext
	|
	|-RVA: 0x32D560 Offset: 0x32D661 VA: 0x32D560
	|-Array.InternalEnumerator<Color4u8>.MoveNext
	|
	|-RVA: 0x32D6D0 Offset: 0x32D7D1 VA: 0x32D6D0
	|-Array.InternalEnumerator<Float2>.MoveNext
	|
	|-RVA: 0x32D7B0 Offset: 0x32D8B1 VA: 0x32D7B0
	|-Array.InternalEnumerator<stCommand_t>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C60 Offset: 0x315D61 VA: 0x315C60
	|-Array.InternalEnumerator<AS_ToolController.ChargeInfo>.get_Current
	|
	|-RVA: 0x315D40 Offset: 0x315E41 VA: 0x315D40
	|-Array.InternalEnumerator<ActionCommandDataTable>.get_Current
	|
	|-RVA: 0x315E20 Offset: 0x315F21 VA: 0x315E20
	|-Array.InternalEnumerator<AdvScriptDefCountParam>.get_Current
	|
	|-RVA: 0x315F00 Offset: 0x316001 VA: 0x315F00
	|-Array.InternalEnumerator<JSONDeserialization.TaskField>.get_Current
	|
	|-RVA: 0x315FE0 Offset: 0x3160E1 VA: 0x315FE0
	|-Array.InternalEnumerator<BitVector32Int>.get_Current
	|
	|-RVA: 0x316150 Offset: 0x316251 VA: 0x316150
	|-Array.InternalEnumerator<BuildItemData>.get_Current
	|
	|-RVA: 0x316230 Offset: 0x316331 VA: 0x316230
	|-Array.InternalEnumerator<ButtonLinker.LinkObject>.get_Current
	|
	|-RVA: 0x316310 Offset: 0x316411 VA: 0x316310
	|-Array.InternalEnumerator<CharaCallTable.BustupTable>.get_Current
	|
	|-RVA: 0x3163F0 Offset: 0x3164F1 VA: 0x3163F0
	|-Array.InternalEnumerator<CharaCallTable.CharaFaceIconTable>.get_Current
	|
	|-RVA: 0x3164E0 Offset: 0x3165E1 VA: 0x3164E0
	|-Array.InternalEnumerator<CameraState.CustomBlendable>.get_Current
	|
	|-RVA: 0x3165C0 Offset: 0x3166C1 VA: 0x3165C0
	|-Array.InternalEnumerator<CinemachineBlendListCamera.Instruction>.get_Current
	|
	|-RVA: 0x3166A0 Offset: 0x3167A1 VA: 0x3166A0
	|-Array.InternalEnumerator<CinemachineBlenderSettings.CustomBlend>.get_Current
	|
	|-RVA: 0x316780 Offset: 0x316881 VA: 0x316780
	|-Array.InternalEnumerator<CinemachineClearShot.Pair>.get_Current
	|
	|-RVA: 0x3168E0 Offset: 0x3169E1 VA: 0x3168E0
	|-Array.InternalEnumerator<CinemachineFreeLook.Orbit>.get_Current
	|
	|-RVA: 0x3169C0 Offset: 0x316AC1 VA: 0x3169C0
	|-Array.InternalEnumerator<CinemachinePath.Waypoint>.get_Current
	|
	|-RVA: 0x316AA0 Offset: 0x316BA1 VA: 0x316AA0
	|-Array.InternalEnumerator<CinemachineSmoothPath.Waypoint>.get_Current
	|
	|-RVA: 0x316B80 Offset: 0x316C81 VA: 0x316B80
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.HashPair>.get_Current
	|
	|-RVA: 0x316CE0 Offset: 0x316DE1 VA: 0x316CE0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.Instruction>.get_Current
	|
	|-RVA: 0x316DC0 Offset: 0x316EC1 VA: 0x316DC0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.get_Current
	|
	|-RVA: 0x316F20 Offset: 0x317021 VA: 0x316F20
	|-Array.InternalEnumerator<CinemachineTargetGroup.Target>.get_Current
	|
	|-RVA: 0x317000 Offset: 0x317101 VA: 0x317000
	|-Array.InternalEnumerator<NoiseSettings.TransformNoiseParams>.get_Current
	|
	|-RVA: 0x3170E0 Offset: 0x3171E1 VA: 0x3170E0
	|-Array.InternalEnumerator<TargetPositionCache.CacheCurve.Item>.get_Current
	|
	|-RVA: 0x3171C0 Offset: 0x3172C1 VA: 0x3171C0
	|-Array.InternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.get_Current
	|
	|-RVA: 0x3172A0 Offset: 0x3173A1 VA: 0x3172A0
	|-Array.InternalEnumerator<HeadingTracker.Item>.get_Current
	|
	|-RVA: 0x317380 Offset: 0x317481 VA: 0x317380
	|-Array.InternalEnumerator<CropDataTable>.get_Current
	|
	|-RVA: 0x317460 Offset: 0x317561 VA: 0x317460
	|-Array.InternalEnumerator<ControlPoint>.get_Current
	|
	|-RVA: 0x317540 Offset: 0x317641 VA: 0x317540
	|-Array.InternalEnumerator<DamageTextInfo>.get_Current
	|
	|-RVA: 0x317620 Offset: 0x317721 VA: 0x317620
	|-Array.InternalEnumerator<UIEMDefine.CategoryDataSet>.get_Current
	|
	|-RVA: 0x317700 Offset: 0x317801 VA: 0x317700
	|-Array.InternalEnumerator<DropItemParam>.get_Current
	|
	|-RVA: 0x317860 Offset: 0x317961 VA: 0x317860
	|-Array.InternalEnumerator<DropTableElement>.get_Current
	|
	|-RVA: 0x317940 Offset: 0x317A41 VA: 0x317940
	|-Array.InternalEnumerator<EffectDataTable>.get_Current
	|
	|-RVA: 0x317A20 Offset: 0x317B21 VA: 0x317A20
	|-Array.InternalEnumerator<EnemyPatrolPoints>.get_Current
	|
	|-RVA: 0x317B80 Offset: 0x317C81 VA: 0x317B80
	|-Array.InternalEnumerator<Coord>.get_Current
	|
	|-RVA: 0x317CE0 Offset: 0x317DE1 VA: 0x317CE0
	|-Array.InternalEnumerator<ErosionBrush.UndoStep>.get_Current
	|
	|-RVA: 0x317DC0 Offset: 0x317EC1 VA: 0x317DC0
	|-Array.InternalEnumerator<EventCheckId>.get_Current
	|
	|-RVA: 0x317EA0 Offset: 0x317FA1 VA: 0x317EA0
	|-Array.InternalEnumerator<EventFlagProgressData>.get_Current
	|
	|-RVA: 0x317F80 Offset: 0x318081 VA: 0x317F80
	|-Array.InternalEnumerator<EyeMouthAnimate.EMAnimSet>.get_Current
	|
	|-RVA: 0x3180E0 Offset: 0x3181E1 VA: 0x3180E0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_PARAM>.get_Current
	|
	|-RVA: 0x3181C0 Offset: 0x3182C1 VA: 0x3181C0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE>.get_Current
	|
	|-RVA: 0x3182A0 Offset: 0x3183A1 VA: 0x3182A0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.get_Current
	|
	|-RVA: 0x318380 Offset: 0x318481 VA: 0x318380
	|-Array.InternalEnumerator<FarmManager.RF4_MCROP_INFO>.get_Current
	|
	|-RVA: 0x318470 Offset: 0x318571 VA: 0x318470
	|-Array.InternalEnumerator<FarmManager.RF4_SOIL_INFO>.get_Current
	|
	|-RVA: 0x318550 Offset: 0x318651 VA: 0x318550
	|-Array.InternalEnumerator<FesNpcScoreData>.get_Current
	|
	|-RVA: 0x318630 Offset: 0x318731 VA: 0x318630
	|-Array.InternalEnumerator<FieldHideItemSpawnDataTable>.get_Current
	|
	|-RVA: 0x318710 Offset: 0x318811 VA: 0x318710
	|-Array.InternalEnumerator<FieldItemSpawnDataTable>.get_Current
	|
	|-RVA: 0x3187F0 Offset: 0x3188F1 VA: 0x3187F0
	|-Array.InternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.get_Current
	|
	|-RVA: 0x3188D0 Offset: 0x3189D1 VA: 0x3188D0
	|-Array.InternalEnumerator<FieldSceneData.Data>.get_Current
	|
	|-RVA: 0x3189B0 Offset: 0x318AB1 VA: 0x3189B0
	|-Array.InternalEnumerator<FieldTreasureBoxItemData>.get_Current
	|
	|-RVA: 0x318B20 Offset: 0x318C21 VA: 0x318B20
	|-Array.InternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.get_Current
	|
	|-RVA: 0x318C00 Offset: 0x318D01 VA: 0x318C00
	|-Array.InternalEnumerator<FieldWoodBoxSpawnDataTable>.get_Current
	|
	|-RVA: 0x318CE0 Offset: 0x318DE1 VA: 0x318CE0
	|-Array.InternalEnumerator<FocusObjectDataTable>.get_Current
	|
	|-RVA: 0x318DC0 Offset: 0x318EC1 VA: 0x318DC0
	|-Array.InternalEnumerator<FurnitureData>.get_Current
	|
	|-RVA: 0x318EA0 Offset: 0x318FA1 VA: 0x318EA0
	|-Array.InternalEnumerator<GateDataTable>.get_Current
	|
	|-RVA: 0x318F80 Offset: 0x319081 VA: 0x318F80
	|-Array.InternalEnumerator<GateStatusDataTable>.get_Current
	|
	|-RVA: 0x319060 Offset: 0x319161 VA: 0x319060
	|-Array.InternalEnumerator<GimmickLayoutDataTable>.get_Current
	|
	|-RVA: 0x3191D0 Offset: 0x3192D1 VA: 0x3191D0
	|-Array.InternalEnumerator<HitResult>.get_Current
	|
	|-RVA: 0x3192B0 Offset: 0x3193B1 VA: 0x3192B0
	|-Array.InternalEnumerator<ImagePaneDatas.ImagePaneData>.get_Current
	|
	|-RVA: 0x319390 Offset: 0x319491 VA: 0x319390
	|-Array.InternalEnumerator<FurnitureManager.SendPos>.get_Current
	|
	|-RVA: 0x319470 Offset: 0x319571 VA: 0x319470
	|-Array.InternalEnumerator<ItemLevelData>.get_Current
	|
	|-RVA: 0x3195D0 Offset: 0x3196D1 VA: 0x3195D0
	|-Array.InternalEnumerator<MapDatas.MapData>.get_Current
	|
	|-RVA: 0x3196B0 Offset: 0x3197B1 VA: 0x3196B0
	|-Array.InternalEnumerator<MapObjectDatas.MapObjectData>.get_Current
	|
	|-RVA: 0x319790 Offset: 0x319891 VA: 0x319790
	|-Array.InternalEnumerator<ByteArrayStringHashTable.Entry>.get_Current
	|
	|-RVA: 0x319870 Offset: 0x319971 VA: 0x319870
	|-Array.InternalEnumerator<MineTypeDataTable>.get_Current
	|
	|-RVA: 0x319950 Offset: 0x319A51 VA: 0x319950
	|-Array.InternalEnumerator<MiningDataTable>.get_Current
	|
	|-RVA: 0x319A30 Offset: 0x319B31 VA: 0x319A30
	|-Array.InternalEnumerator<MiningPointSaveData>.get_Current
	|
	|-RVA: 0x319B10 Offset: 0x319C11 VA: 0x319B10
	|-Array.InternalEnumerator<CodePointIndexer.TableRange>.get_Current
	|
	|-RVA: 0x319BF0 Offset: 0x319CF1 VA: 0x319BF0
	|-Array.InternalEnumerator<MonsterBehaviorDataTable>.get_Current
	|
	|-RVA: 0x319CD0 Offset: 0x319DD1 VA: 0x319CD0
	|-Array.InternalEnumerator<MonsterDataTable>.get_Current
	|
	|-RVA: 0x319DB0 Offset: 0x319EB1 VA: 0x319DB0
	|-Array.InternalEnumerator<MonsterDropItemDataTable>.get_Current
	|
	|-RVA: 0x319E90 Offset: 0x319F91 VA: 0x319E90
	|-Array.InternalEnumerator<MonsterFootStepEventDataTable>.get_Current
	|
	|-RVA: 0x319F70 Offset: 0x31A071 VA: 0x319F70
	|-Array.InternalEnumerator<MonsterHutSaveData>.get_Current
	|
	|-RVA: 0x31A050 Offset: 0x31A151 VA: 0x31A050
	|-Array.InternalEnumerator<MonsterUIData.Data>.get_Current
	|
	|-RVA: 0x31A130 Offset: 0x31A231 VA: 0x31A130
	|-Array.InternalEnumerator<MonsterYieldItemDataTable>.get_Current
	|
	|-RVA: 0x31A210 Offset: 0x31A311 VA: 0x31A210
	|-Array.InternalEnumerator<MoviePlayer.SUBTITLEDATA>.get_Current
	|
	|-RVA: 0x31A2F0 Offset: 0x31A3F1 VA: 0x31A2F0
	|-Array.InternalEnumerator<NPCActionData>.get_Current
	|
	|-RVA: 0x31A3D0 Offset: 0x31A4D1 VA: 0x31A3D0
	|-Array.InternalEnumerator<NPCCallingNameTextData.Data>.get_Current
	|
	|-RVA: 0x31A4B0 Offset: 0x31A5B1 VA: 0x31A4B0
	|-Array.InternalEnumerator<NPCUIData.Data>.get_Current
	|
	|-RVA: 0x31A590 Offset: 0x31A691 VA: 0x31A590
	|-Array.InternalEnumerator<NpcPlaceSchedule>.get_Current
	|
	|-RVA: 0x31A670 Offset: 0x31A771 VA: 0x31A670
	|-Array.InternalEnumerator<OrderLotterySaveParameter>.get_Current
	|
	|-RVA: 0x31A760 Offset: 0x31A861 VA: 0x31A760
	|-Array.InternalEnumerator<OrderSaveData>.get_Current
	|
	|-RVA: 0x31A840 Offset: 0x31A941 VA: 0x31A840
	|-Array.InternalEnumerator<OrderSaveParameter>.get_Current
	|
	|-RVA: 0x31A920 Offset: 0x31AA21 VA: 0x31A920
	|-Array.InternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Current
	|
	|-RVA: 0x31AA00 Offset: 0x31AB01 VA: 0x31AA00
	|-Array.InternalEnumerator<Parameter>.get_Current
	|
	|-RVA: 0x31AAE0 Offset: 0x31ABE1 VA: 0x31AAE0
	|-Array.InternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.get_Current
	|
	|-RVA: 0x31ABC0 Offset: 0x31ACC1 VA: 0x31ABC0
	|-Array.InternalEnumerator<PlayerCallingNameTextData.Data>.get_Current
	|
	|-RVA: 0x31ACA0 Offset: 0x31ADA1 VA: 0x31ACA0
	|-Array.InternalEnumerator<ShopCatalogPage>.get_Current
	|
	|-RVA: 0x31AD80 Offset: 0x31AE81 VA: 0x31AD80
	|-Array.InternalEnumerator<ShopNpcTalk>.get_Current
	|
	|-RVA: 0x31AE60 Offset: 0x31AF61 VA: 0x31AE60
	|-Array.InternalEnumerator<SubtitleDataTable.Data>.get_Current
	|
	|-RVA: 0x31AF50 Offset: 0x31B051 VA: 0x31AF50
	|-Array.InternalEnumerator<SubtitleDataTable.DataList>.get_Current
	|
	|-RVA: 0x321A40 Offset: 0x321B41 VA: 0x321A40
	|-Array.InternalEnumerator<SubtitleHudDataTable.Data>.get_Current
	|
	|-RVA: 0x321B30 Offset: 0x321C31 VA: 0x321B30
	|-Array.InternalEnumerator<AnimationWarping.Warp>.get_Current
	|
	|-RVA: 0x321C10 Offset: 0x321D11 VA: 0x321C10
	|-Array.InternalEnumerator<GrounderQuadruped.Foot>.get_Current
	|
	|-RVA: 0x321CF0 Offset: 0x321DF1 VA: 0x321CF0
	|-Array.InternalEnumerator<IKSolverLimb.AxisDirection>.get_Current
	|
	|-RVA: 0x321DD0 Offset: 0x321ED1 VA: 0x321DD0
	|-Array.InternalEnumerator<ProfilerFrame>.get_Current
	|
	|-RVA: 0x321EB0 Offset: 0x321FB1 VA: 0x321EB0
	|-Array.InternalEnumerator<NumberControl.ValueRange>.get_Current
	|
	|-RVA: 0x321F90 Offset: 0x322091 VA: 0x321F90
	|-Array.InternalEnumerator<SRMonoBehaviourEx.FieldInfo>.get_Current
	|
	|-RVA: 0x322070 Offset: 0x322171 VA: 0x322070
	|-Array.InternalEnumerator<ResponsiveEnable.Entry>.get_Current
	|
	|-RVA: 0x322150 Offset: 0x322251 VA: 0x322150
	|-Array.InternalEnumerator<ResponsiveResize.Element.SizeDefinition>.get_Current
	|
	|-RVA: 0x322230 Offset: 0x322331 VA: 0x322230
	|-Array.InternalEnumerator<ResponsiveResize.Element>.get_Current
	|
	|-RVA: 0x322310 Offset: 0x322411 VA: 0x322310
	|-Array.InternalEnumerator<Schedule>.get_Current
	|
	|-RVA: 0x3223F0 Offset: 0x3224F1 VA: 0x3223F0
	|-Array.InternalEnumerator<SimpleAnimationPlayable.QueuedState>.get_Current
	|
	|-RVA: 0x3224D0 Offset: 0x3225D1 VA: 0x3224D0
	|-Array.InternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.get_Current
	|
	|-RVA: 0x3225C0 Offset: 0x3226C1 VA: 0x3225C0
	|-Array.InternalEnumerator<SpeedData>.get_Current
	|
	|-RVA: 0x322720 Offset: 0x322821 VA: 0x322720
	|-Array.InternalEnumerator<CurveSample>.get_Current
	|
	|-RVA: 0x322800 Offset: 0x322901 VA: 0x322800
	|-Array.InternalEnumerator<StatusPageSetParameter.ElementParameterText>.get_Current
	|
	|-RVA: 0x322960 Offset: 0x322A61 VA: 0x322960
	|-Array.InternalEnumerator<StringFormatData.FormatData>.get_Current
	|
	|-RVA: 0x322A40 Offset: 0x322B41 VA: 0x322A40
	|-Array.InternalEnumerator<ArraySegment<ProfilerFrame>>.get_Current
	|
	|-RVA: 0x322B20 Offset: 0x322C21 VA: 0x322B20
	|-Array.InternalEnumerator<ArraySegment<byte>>.get_Current
	|
	|-RVA: 0x322C00 Offset: 0x322D01 VA: 0x322C00
	|-Array.InternalEnumerator<ArraySegment<object>>.get_Current
	|
	|-RVA: 0x322CE0 Offset: 0x322DE1 VA: 0x322CE0
	|-Array.InternalEnumerator<bool>.get_Current
	|
	|-RVA: 0x322DC0 Offset: 0x322EC1 VA: 0x322DC0
	|-Array.InternalEnumerator<byte>.get_Current
	|
	|-RVA: 0x322F20 Offset: 0x323021 VA: 0x322F20
	|-Array.InternalEnumerator<ByteEnum>.get_Current
	|
	|-RVA: 0x323080 Offset: 0x323181 VA: 0x323080
	|-Array.InternalEnumerator<char>.get_Current
	|
	|-RVA: 0x3231E0 Offset: 0x3232E1 VA: 0x3231E0
	|-Array.InternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.get_Current
	|
	|-RVA: 0x3232C0 Offset: 0x3233C1 VA: 0x3232C0
	|-Array.InternalEnumerator<DictionaryEntry>.get_Current
	|
	|-RVA: 0x3233A0 Offset: 0x3234A1 VA: 0x3233A0
	|-Array.InternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.get_Current
	|
	|-RVA: 0x323480 Offset: 0x323581 VA: 0x323480
	|-Array.InternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.get_Current
	|
	|-RVA: 0x323560 Offset: 0x323661 VA: 0x323560
	|-Array.InternalEnumerator<Dictionary.Entry<EventCheckId, object>>.get_Current
	|
	|-RVA: 0x323640 Offset: 0x323741 VA: 0x323640
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.get_Current
	|
	|-RVA: 0x323720 Offset: 0x323821 VA: 0x323720
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.get_Current
	|
	|-RVA: 0x323800 Offset: 0x323901 VA: 0x323800
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.get_Current
	|
	|-RVA: 0x3238E0 Offset: 0x3239E1 VA: 0x3238E0
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.get_Current
	|
	|-RVA: 0x3239C0 Offset: 0x323AC1 VA: 0x3239C0
	|-Array.InternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.get_Current
	|
	|-RVA: 0x323AA0 Offset: 0x323BA1 VA: 0x323AA0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.get_Current
	|
	|-RVA: 0x323B80 Offset: 0x323C81 VA: 0x323B80
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.get_Current
	|
	|-RVA: 0x323C60 Offset: 0x323D61 VA: 0x323C60
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.get_Current
	|
	|-RVA: 0x323D40 Offset: 0x323E41 VA: 0x323D40
	|-Array.InternalEnumerator<Dictionary.Entry<Parameter, object>>.get_Current
	|
	|-RVA: 0x323E20 Offset: 0x323F21 VA: 0x323E20
	|-Array.InternalEnumerator<Dictionary.Entry<bool, object>>.get_Current
	|
	|-RVA: 0x323F00 Offset: 0x324001 VA: 0x323F00
	|-Array.InternalEnumerator<Dictionary.Entry<byte, object>>.get_Current
	|
	|-RVA: 0x323FE0 Offset: 0x3240E1 VA: 0x323FE0
	|-Array.InternalEnumerator<Dictionary.Entry<char, object>>.get_Current
	|
	|-RVA: 0x3240C0 Offset: 0x3241C1 VA: 0x3240C0
	|-Array.InternalEnumerator<Dictionary.Entry<DateTime, object>>.get_Current
	|
	|-RVA: 0x3241A0 Offset: 0x3242A1 VA: 0x3241A0
	|-Array.InternalEnumerator<Dictionary.Entry<double, object>>.get_Current
	|
	|-RVA: 0x324280 Offset: 0x324381 VA: 0x324280
	|-Array.InternalEnumerator<Dictionary.Entry<Guid, object>>.get_Current
	|
	|-RVA: 0x324360 Offset: 0x324461 VA: 0x324360
	|-Array.InternalEnumerator<Dictionary.Entry<short, object>>.get_Current
	|
	|-RVA: 0x324440 Offset: 0x324541 VA: 0x324440
	|-Array.InternalEnumerator<Dictionary.Entry<int, CropDataTable>>.get_Current
	|
	|-RVA: 0x324520 Offset: 0x324621 VA: 0x324520
	|-Array.InternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.get_Current
	|
	|-RVA: 0x324600 Offset: 0x324701 VA: 0x324600
	|-Array.InternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.get_Current
	|
	|-RVA: 0x3246E0 Offset: 0x3247E1 VA: 0x3246E0
	|-Array.InternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.get_Current
	|
	|-RVA: 0x3247C0 Offset: 0x3248C1 VA: 0x3247C0
	|-Array.InternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.get_Current
	|
	|-RVA: 0x3248A0 Offset: 0x3249A1 VA: 0x3248A0
	|-Array.InternalEnumerator<Dictionary.Entry<int, bool>>.get_Current
	|
	|-RVA: 0x324980 Offset: 0x324A81 VA: 0x324980
	|-Array.InternalEnumerator<Dictionary.Entry<int, char>>.get_Current
	|
	|-RVA: 0x324A60 Offset: 0x324B61 VA: 0x324A60
	|-Array.InternalEnumerator<Dictionary.Entry<int, int>>.get_Current
	|
	|-RVA: 0x324B40 Offset: 0x324C41 VA: 0x324B40
	|-Array.InternalEnumerator<Dictionary.Entry<int, Int32Enum>>.get_Current
	|
	|-RVA: 0x324C20 Offset: 0x324D21 VA: 0x324C20
	|-Array.InternalEnumerator<Dictionary.Entry<int, long>>.get_Current
	|
	|-RVA: 0x324D00 Offset: 0x324E01 VA: 0x324D00
	|-Array.InternalEnumerator<Dictionary.Entry<int, object>>.get_Current
	|
	|-RVA: 0x324DE0 Offset: 0x324EE1 VA: 0x324DE0
	|-Array.InternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.get_Current
	|
	|-RVA: 0x324EC0 Offset: 0x324FC1 VA: 0x324EC0
	|-Array.InternalEnumerator<Dictionary.Entry<int, SceneInstance>>.get_Current
	|
	|-RVA: 0x324FA0 Offset: 0x3250A1 VA: 0x324FA0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector2Int>>.get_Current
	|
	|-RVA: 0x325080 Offset: 0x325181 VA: 0x325080
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector3>>.get_Current
	|
	|-RVA: 0x325160 Offset: 0x325261 VA: 0x325160
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.get_Current
	|
	|-RVA: 0x325240 Offset: 0x325341 VA: 0x325240
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.get_Current
	|
	|-RVA: 0x325320 Offset: 0x325421 VA: 0x325320
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.get_Current
	|
	|-RVA: 0x325400 Offset: 0x325501 VA: 0x325400
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.get_Current
	|
	|-RVA: 0x3254E0 Offset: 0x3255E1 VA: 0x3254E0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.get_Current
	|
	|-RVA: 0x3255C0 Offset: 0x3256C1 VA: 0x3255C0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x3256A0 Offset: 0x3257A1 VA: 0x3256A0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x325780 Offset: 0x325881 VA: 0x325780
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x325860 Offset: 0x325961 VA: 0x325860
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, float>>.get_Current
	|
	|-RVA: 0x325940 Offset: 0x325A41 VA: 0x325940
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.get_Current
	|
	|-RVA: 0x325A20 Offset: 0x325B21 VA: 0x325A20
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.get_Current
	|
	|-RVA: 0x325B00 Offset: 0x325C01 VA: 0x325B00
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.get_Current
	|
	|-RVA: 0x325BE0 Offset: 0x325CE1 VA: 0x325BE0
	|-Array.InternalEnumerator<Dictionary.Entry<long, object>>.get_Current
	|
	|-RVA: 0x325CC0 Offset: 0x325DC1 VA: 0x325CC0
	|-Array.InternalEnumerator<Dictionary.Entry<Memory<object>, object>>.get_Current
	|
	|-RVA: 0x325DA0 Offset: 0x325EA1 VA: 0x325DA0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.get_Current
	|
	|-RVA: 0x325E80 Offset: 0x325F81 VA: 0x325E80
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.get_Current
	|
	|-RVA: 0x325F60 Offset: 0x326061 VA: 0x325F60
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.get_Current
	|
	|-RVA: 0x326040 Offset: 0x326141 VA: 0x326040
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.get_Current
	|
	|-RVA: 0x326120 Offset: 0x326221 VA: 0x326120
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.get_Current
	|
	|-RVA: 0x326200 Offset: 0x326301 VA: 0x326200
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.get_Current
	|
	|-RVA: 0x3262E0 Offset: 0x3263E1 VA: 0x3262E0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.get_Current
	|
	|-RVA: 0x3263C0 Offset: 0x3264C1 VA: 0x3263C0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.get_Current
	|
	|-RVA: 0x3264A0 Offset: 0x3265A1 VA: 0x3264A0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.get_Current
	|
	|-RVA: 0x326580 Offset: 0x326681 VA: 0x326580
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.get_Current
	|
	|-RVA: 0x326660 Offset: 0x326761 VA: 0x326660
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.get_Current
	|
	|-RVA: 0x326740 Offset: 0x326841 VA: 0x326740
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.get_Current
	|
	|-RVA: 0x326820 Offset: 0x326921 VA: 0x326820
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.get_Current
	|
	|-RVA: 0x326900 Offset: 0x326A01 VA: 0x326900
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.get_Current
	|
	|-RVA: 0x3269E0 Offset: 0x326AE1 VA: 0x3269E0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.get_Current
	|
	|-RVA: 0x326AC0 Offset: 0x326BC1 VA: 0x326AC0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.get_Current
	|
	|-RVA: 0x326BA0 Offset: 0x326CA1 VA: 0x326BA0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.get_Current
	|
	|-RVA: 0x326C80 Offset: 0x326D81 VA: 0x326C80
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.get_Current
	|
	|-RVA: 0x326D60 Offset: 0x326E61 VA: 0x326D60
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.get_Current
	|
	|-RVA: 0x326E40 Offset: 0x326F41 VA: 0x326E40
	|-Array.InternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.get_Current
	|
	|-RVA: 0x326F20 Offset: 0x327021 VA: 0x326F20
	|-Array.InternalEnumerator<Dictionary.Entry<object, EventCheckId>>.get_Current
	|
	|-RVA: 0x327000 Offset: 0x327101 VA: 0x327000
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.get_Current
	|
	|-RVA: 0x3270E0 Offset: 0x3271E1 VA: 0x3270E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.get_Current
	|
	|-RVA: 0x3271C0 Offset: 0x3272C1 VA: 0x3271C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.get_Current
	|
	|-RVA: 0x3272A0 Offset: 0x3273A1 VA: 0x3272A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.get_Current
	|
	|-RVA: 0x327380 Offset: 0x327481 VA: 0x327380
	|-Array.InternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.get_Current
	|
	|-RVA: 0x327460 Offset: 0x327561 VA: 0x327460
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.get_Current
	|
	|-RVA: 0x327540 Offset: 0x327641 VA: 0x327540
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.get_Current
	|
	|-RVA: 0x327620 Offset: 0x327721 VA: 0x327620
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.get_Current
	|
	|-RVA: 0x327700 Offset: 0x327801 VA: 0x327700
	|-Array.InternalEnumerator<Dictionary.Entry<object, Parameter>>.get_Current
	|
	|-RVA: 0x3277E0 Offset: 0x3278E1 VA: 0x3277E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.get_Current
	|
	|-RVA: 0x3278C0 Offset: 0x3279C1 VA: 0x3278C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, bool>>.get_Current
	|
	|-RVA: 0x3497A0 Offset: 0x3498A1 VA: 0x3497A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, byte>>.get_Current
	|
	|-RVA: 0x349880 Offset: 0x349981 VA: 0x349880
	|-Array.InternalEnumerator<Dictionary.Entry<object, char>>.get_Current
	|
	|-RVA: 0x349960 Offset: 0x349A61 VA: 0x349960
	|-Array.InternalEnumerator<Dictionary.Entry<object, DateTime>>.get_Current
	|
	|-RVA: 0x349A40 Offset: 0x349B41 VA: 0x349A40
	|-Array.InternalEnumerator<Dictionary.Entry<object, double>>.get_Current
	|
	|-RVA: 0x349B20 Offset: 0x349C21 VA: 0x349B20
	|-Array.InternalEnumerator<Dictionary.Entry<object, short>>.get_Current
	|
	|-RVA: 0x349C00 Offset: 0x349D01 VA: 0x349C00
	|-Array.InternalEnumerator<Dictionary.Entry<object, int>>.get_Current
	|
	|-RVA: 0x349CE0 Offset: 0x349DE1 VA: 0x349CE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x349DC0 Offset: 0x349EC1 VA: 0x349DC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, long>>.get_Current
	|
	|-RVA: 0x349EA0 Offset: 0x349FA1 VA: 0x349EA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Memory<object>>>.get_Current
	|
	|-RVA: 0x349F80 Offset: 0x34A081 VA: 0x349F80
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.get_Current
	|
	|-RVA: 0x34A060 Offset: 0x34A161 VA: 0x34A060
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.get_Current
	|
	|-RVA: 0x34A140 Offset: 0x34A241 VA: 0x34A140
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.get_Current
	|
	|-RVA: 0x34A220 Offset: 0x34A321 VA: 0x34A220
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.get_Current
	|
	|-RVA: 0x34A300 Offset: 0x34A401 VA: 0x34A300
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.get_Current
	|
	|-RVA: 0x34A3E0 Offset: 0x34A4E1 VA: 0x34A3E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.get_Current
	|
	|-RVA: 0x34A4C0 Offset: 0x34A5C1 VA: 0x34A4C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.get_Current
	|
	|-RVA: 0x34A5A0 Offset: 0x34A6A1 VA: 0x34A5A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.get_Current
	|
	|-RVA: 0x34A680 Offset: 0x34A781 VA: 0x34A680
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.get_Current
	|
	|-RVA: 0x34A760 Offset: 0x34A861 VA: 0x34A760
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.get_Current
	|
	|-RVA: 0x34A840 Offset: 0x34A941 VA: 0x34A840
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.get_Current
	|
	|-RVA: 0x34A920 Offset: 0x34AA21 VA: 0x34A920
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.get_Current
	|
	|-RVA: 0x34AA00 Offset: 0x34AB01 VA: 0x34AA00
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.get_Current
	|
	|-RVA: 0x34AAE0 Offset: 0x34ABE1 VA: 0x34AAE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.get_Current
	|
	|-RVA: 0x34ABC0 Offset: 0x34ACC1 VA: 0x34ABC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.get_Current
	|
	|-RVA: 0x34ACA0 Offset: 0x34ADA1 VA: 0x34ACA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.get_Current
	|
	|-RVA: 0x34AD80 Offset: 0x34AE81 VA: 0x34AD80
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.get_Current
	|
	|-RVA: 0x34AE60 Offset: 0x34AF61 VA: 0x34AE60
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.get_Current
	|
	|-RVA: 0x34AF40 Offset: 0x34B041 VA: 0x34AF40
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.get_Current
	|
	|-RVA: 0x34B020 Offset: 0x34B121 VA: 0x34B020
	|-Array.InternalEnumerator<Dictionary.Entry<object, object>>.get_Current
	|
	|-RVA: 0x34B100 Offset: 0x34B201 VA: 0x34B100
	|-Array.InternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.get_Current
	|
	|-RVA: 0x34B1E0 Offset: 0x34B2E1 VA: 0x34B1E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.get_Current
	|
	|-RVA: 0x34B2C0 Offset: 0x34B3C1 VA: 0x34B2C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, sbyte>>.get_Current
	|
	|-RVA: 0x34B3A0 Offset: 0x34B4A1 VA: 0x34B3A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, float>>.get_Current
	|
	|-RVA: 0x34B480 Offset: 0x34B581 VA: 0x34B480
	|-Array.InternalEnumerator<Dictionary.Entry<object, ushort>>.get_Current
	|
	|-RVA: 0x34B560 Offset: 0x34B661 VA: 0x34B560
	|-Array.InternalEnumerator<Dictionary.Entry<object, uint>>.get_Current
	|
	|-RVA: 0x34B640 Offset: 0x34B741 VA: 0x34B640
	|-Array.InternalEnumerator<Dictionary.Entry<object, ulong>>.get_Current
	|
	|-RVA: 0x34B720 Offset: 0x34B821 VA: 0x34B720
	|-Array.InternalEnumerator<Dictionary.Entry<object, TransitionTables>>.get_Current
	|
	|-RVA: 0x34B800 Offset: 0x34B901 VA: 0x34B800
	|-Array.InternalEnumerator<Dictionary.Entry<object, Bounds>>.get_Current
	|
	|-RVA: 0x34B8E0 Offset: 0x34B9E1 VA: 0x34B8E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, BoundsInt>>.get_Current
	|
	|-RVA: 0x34B9C0 Offset: 0x34BAC1 VA: 0x34B9C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color32>>.get_Current
	|
	|-RVA: 0x34BAA0 Offset: 0x34BBA1 VA: 0x34BAA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color>>.get_Current
	|
	|-RVA: 0x34BB80 Offset: 0x34BC81 VA: 0x34BB80
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x34BC60 Offset: 0x34BD61 VA: 0x34BC60
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.get_Current
	|
	|-RVA: 0x34BD40 Offset: 0x34BE41 VA: 0x34BD40
	|-Array.InternalEnumerator<Dictionary.Entry<object, Keyframe>>.get_Current
	|
	|-RVA: 0x34BE20 Offset: 0x34BF21 VA: 0x34BE20
	|-Array.InternalEnumerator<Dictionary.Entry<object, LayerMask>>.get_Current
	|
	|-RVA: 0x34BF00 Offset: 0x34C001 VA: 0x34BF00
	|-Array.InternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.get_Current
	|
	|-RVA: 0x34BFE0 Offset: 0x34C0E1 VA: 0x34BFE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Playable>>.get_Current
	|
	|-RVA: 0x34C0C0 Offset: 0x34C1C1 VA: 0x34C0C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Quaternion>>.get_Current
	|
	|-RVA: 0x34C1A0 Offset: 0x34C2A1 VA: 0x34C1A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RangeInt>>.get_Current
	|
	|-RVA: 0x34C280 Offset: 0x34C381 VA: 0x34C280
	|-Array.InternalEnumerator<Dictionary.Entry<object, Rect>>.get_Current
	|
	|-RVA: 0x34C360 Offset: 0x34C461 VA: 0x34C360
	|-Array.InternalEnumerator<Dictionary.Entry<object, RectInt>>.get_Current
	|
	|-RVA: 0x34C440 Offset: 0x34C541 VA: 0x34C440
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x34C520 Offset: 0x34C621 VA: 0x34C520
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.get_Current
	|
	|-RVA: 0x34C600 Offset: 0x34C701 VA: 0x34C600
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2>>.get_Current
	|
	|-RVA: 0x34C6E0 Offset: 0x34C7E1 VA: 0x34C6E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2Int>>.get_Current
	|
	|-RVA: 0x34C7C0 Offset: 0x34C8C1 VA: 0x34C7C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3>>.get_Current
	|
	|-RVA: 0x34C8A0 Offset: 0x34C9A1 VA: 0x34C8A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3Int>>.get_Current
	|
	|-RVA: 0x34C980 Offset: 0x34CA81 VA: 0x34C980
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector4>>.get_Current
	|
	|-RVA: 0x34CA60 Offset: 0x34CB61 VA: 0x34CA60
	|-Array.InternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.get_Current
	|
	|-RVA: 0x34CB40 Offset: 0x34CC41 VA: 0x34CB40
	|-Array.InternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.get_Current
	|
	|-RVA: 0x34CC20 Offset: 0x34CD21 VA: 0x34CC20
	|-Array.InternalEnumerator<Dictionary.Entry<sbyte, object>>.get_Current
	|
	|-RVA: 0x34CD00 Offset: 0x34CE01 VA: 0x34CD00
	|-Array.InternalEnumerator<Dictionary.Entry<float, CurveSample>>.get_Current
	|
	|-RVA: 0x34CDE0 Offset: 0x34CEE1 VA: 0x34CDE0
	|-Array.InternalEnumerator<Dictionary.Entry<float, object>>.get_Current
	|
	|-RVA: 0x34CEC0 Offset: 0x34CFC1 VA: 0x34CEC0
	|-Array.InternalEnumerator<Dictionary.Entry<ushort, object>>.get_Current
	|
	|-RVA: 0x34CFA0 Offset: 0x34D0A1 VA: 0x34CFA0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, int>>.get_Current
	|
	|-RVA: 0x34D080 Offset: 0x34D181 VA: 0x34D080
	|-Array.InternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.get_Current
	|
	|-RVA: 0x34D160 Offset: 0x34D261 VA: 0x34D160
	|-Array.InternalEnumerator<Dictionary.Entry<uint, object>>.get_Current
	|
	|-RVA: 0x34D240 Offset: 0x34D341 VA: 0x34D240
	|-Array.InternalEnumerator<Dictionary.Entry<ulong, object>>.get_Current
	|
	|-RVA: 0x34D320 Offset: 0x34D421 VA: 0x34D320
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.get_Current
	|
	|-RVA: 0x34D400 Offset: 0x34D501 VA: 0x34D400
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.get_Current
	|
	|-RVA: 0x34D4E0 Offset: 0x34D5E1 VA: 0x34D4E0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.get_Current
	|
	|-RVA: 0x34D5C0 Offset: 0x34D6C1 VA: 0x34D5C0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.get_Current
	|
	|-RVA: 0x34D6A0 Offset: 0x34D7A1 VA: 0x34D6A0
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.get_Current
	|
	|-RVA: 0x34D780 Offset: 0x34D881 VA: 0x34D780
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.get_Current
	|
	|-RVA: 0x34D860 Offset: 0x34D961 VA: 0x34D860
	|-Array.InternalEnumerator<Dictionary.Entry<Bounds, object>>.get_Current
	|
	|-RVA: 0x34D940 Offset: 0x34DA41 VA: 0x34D940
	|-Array.InternalEnumerator<Dictionary.Entry<BoundsInt, object>>.get_Current
	|
	|-RVA: 0x34DA20 Offset: 0x34DB21 VA: 0x34DA20
	|-Array.InternalEnumerator<Dictionary.Entry<Color, object>>.get_Current
	|
	|-RVA: 0x34DB00 Offset: 0x34DC01 VA: 0x34DB00
	|-Array.InternalEnumerator<Dictionary.Entry<Color32, object>>.get_Current
	|
	|-RVA: 0x34DBE0 Offset: 0x34DCE1 VA: 0x34DBE0
	|-Array.InternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.get_Current
	|
	|-RVA: 0x34DCC0 Offset: 0x34DDC1 VA: 0x34DCC0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.get_Current
	|
	|-RVA: 0x34DDA0 Offset: 0x34DEA1 VA: 0x34DDA0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.get_Current
	|
	|-RVA: 0x34DE80 Offset: 0x34DF81 VA: 0x34DE80
	|-Array.InternalEnumerator<Dictionary.Entry<Keyframe, object>>.get_Current
	|
	|-RVA: 0x34DF60 Offset: 0x34E061 VA: 0x34DF60
	|-Array.InternalEnumerator<Dictionary.Entry<LayerMask, object>>.get_Current
	|
	|-RVA: 0x34E040 Offset: 0x34E141 VA: 0x34E040
	|-Array.InternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.get_Current
	|
	|-RVA: 0x34E120 Offset: 0x34E221 VA: 0x34E120
	|-Array.InternalEnumerator<Dictionary.Entry<IntVec3, object>>.get_Current
	|
	|-RVA: 0x34E200 Offset: 0x34E301 VA: 0x34E200
	|-Array.InternalEnumerator<Dictionary.Entry<Quaternion, object>>.get_Current
	|
	|-RVA: 0x34E2E0 Offset: 0x34E3E1 VA: 0x34E2E0
	|-Array.InternalEnumerator<Dictionary.Entry<RangeInt, object>>.get_Current
	|
	|-RVA: 0x34E3C0 Offset: 0x34E4C1 VA: 0x34E3C0
	|-Array.InternalEnumerator<Dictionary.Entry<Rect, object>>.get_Current
	|
	|-RVA: 0x34E4A0 Offset: 0x34E5A1 VA: 0x34E4A0
	|-Array.InternalEnumerator<Dictionary.Entry<RectInt, object>>.get_Current
	|
	|-RVA: 0x34E580 Offset: 0x34E681 VA: 0x34E580
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.get_Current
	|
	|-RVA: 0x34E660 Offset: 0x34E761 VA: 0x34E660
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.get_Current
	|
	|-RVA: 0x34E740 Offset: 0x34E841 VA: 0x34E740
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2, object>>.get_Current
	|
	|-RVA: 0x34E820 Offset: 0x34E921 VA: 0x34E820
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2Int, object>>.get_Current
	|
	|-RVA: 0x34E900 Offset: 0x34EA01 VA: 0x34E900
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3, object>>.get_Current
	|
	|-RVA: 0x34E9E0 Offset: 0x34EAE1 VA: 0x34E9E0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3Int, object>>.get_Current
	|
	|-RVA: 0x34EAC0 Offset: 0x34EBC1 VA: 0x34EAC0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector4, object>>.get_Current
	|
	|-RVA: 0x34EBA0 Offset: 0x34ECA1 VA: 0x34EBA0
	|-Array.InternalEnumerator<HashSet.Slot<int>>.get_Current
	|
	|-RVA: 0x34EC90 Offset: 0x34ED91 VA: 0x34EC90
	|-Array.InternalEnumerator<HashSet.Slot<Int32Enum>>.get_Current
	|
	|-RVA: 0x34ED80 Offset: 0x34EE81 VA: 0x34ED80
	|-Array.InternalEnumerator<HashSet.Slot<object>>.get_Current
	|
	|-RVA: 0x34EE60 Offset: 0x34EF61 VA: 0x34EE60
	|-Array.InternalEnumerator<HashSet.Slot<uint>>.get_Current
	|
	|-RVA: 0x34EF50 Offset: 0x34F051 VA: 0x34EF50
	|-Array.InternalEnumerator<HashSet.Slot<Edge>>.get_Current
	|
	|-RVA: 0x34F030 Offset: 0x34F131 VA: 0x34F030
	|-Array.InternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x34F110 Offset: 0x34F211 VA: 0x34F110
	|-Array.InternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.get_Current
	|
	|-RVA: 0x34F1F0 Offset: 0x34F2F1 VA: 0x34F1F0
	|-Array.InternalEnumerator<KeyValuePair<BitVector32Int, object>>.get_Current
	|
	|-RVA: 0x34F2D0 Offset: 0x34F3D1 VA: 0x34F2D0
	|-Array.InternalEnumerator<KeyValuePair<EventCheckId, object>>.get_Current
	|
	|-RVA: 0x34F3B0 Offset: 0x34F4B1 VA: 0x34F3B0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.get_Current
	|
	|-RVA: 0x338E30 Offset: 0x338F31 VA: 0x338E30
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.get_Current
	|
	|-RVA: 0x338F10 Offset: 0x339011 VA: 0x338F10
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.get_Current
	|
	|-RVA: 0x338FF0 Offset: 0x3390F1 VA: 0x338FF0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.get_Current
	|
	|-RVA: 0x3390D0 Offset: 0x3391D1 VA: 0x3390D0
	|-Array.InternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.get_Current
	|
	|-RVA: 0x3391B0 Offset: 0x3392B1 VA: 0x3391B0
	|-Array.InternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.get_Current
	|
	|-RVA: 0x339290 Offset: 0x339391 VA: 0x339290
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveData, object>>.get_Current
	|
	|-RVA: 0x339370 Offset: 0x339471 VA: 0x339370
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.get_Current
	|
	|-RVA: 0x339450 Offset: 0x339551 VA: 0x339450
	|-Array.InternalEnumerator<KeyValuePair<Parameter, object>>.get_Current
	|
	|-RVA: 0x339530 Offset: 0x339631 VA: 0x339530
	|-Array.InternalEnumerator<KeyValuePair<bool, object>>.get_Current
	|
	|-RVA: 0x339610 Offset: 0x339711 VA: 0x339610
	|-Array.InternalEnumerator<KeyValuePair<byte, object>>.get_Current
	|
	|-RVA: 0x3396F0 Offset: 0x3397F1 VA: 0x3396F0
	|-Array.InternalEnumerator<KeyValuePair<char, object>>.get_Current
	|
	|-RVA: 0x3397D0 Offset: 0x3398D1 VA: 0x3397D0
	|-Array.InternalEnumerator<KeyValuePair<DateTime, object>>.get_Current
	|
	|-RVA: 0x3398B0 Offset: 0x3399B1 VA: 0x3398B0
	|-Array.InternalEnumerator<KeyValuePair<double, object>>.get_Current
	|
	|-RVA: 0x339990 Offset: 0x339A91 VA: 0x339990
	|-Array.InternalEnumerator<KeyValuePair<Guid, object>>.get_Current
	|
	|-RVA: 0x339A70 Offset: 0x339B71 VA: 0x339A70
	|-Array.InternalEnumerator<KeyValuePair<short, object>>.get_Current
	|
	|-RVA: 0x339B50 Offset: 0x339C51 VA: 0x339B50
	|-Array.InternalEnumerator<KeyValuePair<int, CropDataTable>>.get_Current
	|
	|-RVA: 0x339C30 Offset: 0x339D31 VA: 0x339C30
	|-Array.InternalEnumerator<KeyValuePair<int, EffectDataTable>>.get_Current
	|
	|-RVA: 0x339D10 Offset: 0x339E11 VA: 0x339D10
	|-Array.InternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.get_Current
	|
	|-RVA: 0x339E70 Offset: 0x339F71 VA: 0x339E70
	|-Array.InternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.get_Current
	|
	|-RVA: 0x339F50 Offset: 0x33A051 VA: 0x339F50
	|-Array.InternalEnumerator<KeyValuePair<int, MiningDataTable>>.get_Current
	|
	|-RVA: 0x33A030 Offset: 0x33A131 VA: 0x33A030
	|-Array.InternalEnumerator<KeyValuePair<int, bool>>.get_Current
	|
	|-RVA: 0x33A190 Offset: 0x33A291 VA: 0x33A190
	|-Array.InternalEnumerator<KeyValuePair<int, char>>.get_Current
	|
	|-RVA: 0x33A2F0 Offset: 0x33A3F1 VA: 0x33A2F0
	|-Array.InternalEnumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x33A450 Offset: 0x33A551 VA: 0x33A450
	|-Array.InternalEnumerator<KeyValuePair<int, Int32Enum>>.get_Current
	|
	|-RVA: 0x33A5B0 Offset: 0x33A6B1 VA: 0x33A5B0
	|-Array.InternalEnumerator<KeyValuePair<int, long>>.get_Current
	|
	|-RVA: 0x33A690 Offset: 0x33A791 VA: 0x33A690
	|-Array.InternalEnumerator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x33A770 Offset: 0x33A871 VA: 0x33A770
	|-Array.InternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.get_Current
	|
	|-RVA: 0x33A850 Offset: 0x33A951 VA: 0x33A850
	|-Array.InternalEnumerator<KeyValuePair<int, SceneInstance>>.get_Current
	|
	|-RVA: 0x33A930 Offset: 0x33AA31 VA: 0x33A930
	|-Array.InternalEnumerator<KeyValuePair<int, Vector2Int>>.get_Current
	|
	|-RVA: 0x33AA20 Offset: 0x33AB21 VA: 0x33AA20
	|-Array.InternalEnumerator<KeyValuePair<int, Vector3>>.get_Current
	|
	|-RVA: 0x33AB00 Offset: 0x33AC01 VA: 0x33AB00
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.get_Current
	|
	|-RVA: 0x33ABE0 Offset: 0x33ACE1 VA: 0x33ABE0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.get_Current
	|
	|-RVA: 0x33ACC0 Offset: 0x33ADC1 VA: 0x33ACC0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.get_Current
	|
	|-RVA: 0x33ADA0 Offset: 0x33AEA1 VA: 0x33ADA0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, bool>>.get_Current
	|
	|-RVA: 0x33AF00 Offset: 0x33B001 VA: 0x33AF00
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.get_Current
	|
	|-RVA: 0x33AFF0 Offset: 0x33B0F1 VA: 0x33AFF0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x33B150 Offset: 0x33B251 VA: 0x33B150
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x33B2B0 Offset: 0x33B3B1 VA: 0x33B2B0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x33B390 Offset: 0x33B491 VA: 0x33B390
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, float>>.get_Current
	|
	|-RVA: 0x33B4F0 Offset: 0x33B5F1 VA: 0x33B4F0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.get_Current
	|
	|-RVA: 0x33B5D0 Offset: 0x33B6D1 VA: 0x33B5D0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.get_Current
	|
	|-RVA: 0x33B6C0 Offset: 0x33B7C1 VA: 0x33B6C0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.get_Current
	|
	|-RVA: 0x33B7A0 Offset: 0x33B8A1 VA: 0x33B7A0
	|-Array.InternalEnumerator<KeyValuePair<long, object>>.get_Current
	|
	|-RVA: 0x33B880 Offset: 0x33B981 VA: 0x33B880
	|-Array.InternalEnumerator<KeyValuePair<Memory<object>, object>>.get_Current
	|
	|-RVA: 0x33B960 Offset: 0x33BA61 VA: 0x33B960
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.get_Current
	|
	|-RVA: 0x33BA40 Offset: 0x33BB41 VA: 0x33BA40
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.get_Current
	|
	|-RVA: 0x33BB20 Offset: 0x33BC21 VA: 0x33BB20
	|-Array.InternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.get_Current
	|
	|-RVA: 0x33BC00 Offset: 0x33BD01 VA: 0x33BC00
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.get_Current
	|
	|-RVA: 0x33BCE0 Offset: 0x33BDE1 VA: 0x33BCE0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color>, object>>.get_Current
	|
	|-RVA: 0x33BDC0 Offset: 0x33BEC1 VA: 0x33BDC0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.get_Current
	|
	|-RVA: 0x33BEA0 Offset: 0x33BFA1 VA: 0x33BEA0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.get_Current
	|
	|-RVA: 0x33BF80 Offset: 0x33C081 VA: 0x33BF80
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.get_Current
	|
	|-RVA: 0x33C060 Offset: 0x33C161 VA: 0x33C060
	|-Array.InternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.get_Current
	|
	|-RVA: 0x33C140 Offset: 0x33C241 VA: 0x33C140
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.get_Current
	|
	|-RVA: 0x33C220 Offset: 0x33C321 VA: 0x33C220
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.get_Current
	|
	|-RVA: 0x33C300 Offset: 0x33C401 VA: 0x33C300
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.get_Current
	|
	|-RVA: 0x33C3E0 Offset: 0x33C4E1 VA: 0x33C3E0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.get_Current
	|
	|-RVA: 0x33C4C0 Offset: 0x33C5C1 VA: 0x33C4C0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.get_Current
	|
	|-RVA: 0x33C5A0 Offset: 0x33C6A1 VA: 0x33C5A0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.get_Current
	|
	|-RVA: 0x33C680 Offset: 0x33C781 VA: 0x33C680
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.get_Current
	|
	|-RVA: 0x33C760 Offset: 0x33C861 VA: 0x33C760
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.get_Current
	|
	|-RVA: 0x33C840 Offset: 0x33C941 VA: 0x33C840
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.get_Current
	|
	|-RVA: 0x33C920 Offset: 0x33CA21 VA: 0x33C920
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.get_Current
	|
	|-RVA: 0x33CA00 Offset: 0x33CB01 VA: 0x33CA00
	|-Array.InternalEnumerator<KeyValuePair<object, BitVector32Int>>.get_Current
	|
	|-RVA: 0x33CAE0 Offset: 0x33CBE1 VA: 0x33CAE0
	|-Array.InternalEnumerator<KeyValuePair<object, EventCheckId>>.get_Current
	|
	|-RVA: 0x33CBC0 Offset: 0x33CCC1 VA: 0x33CBC0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.get_Current
	|
	|-RVA: 0x33CCA0 Offset: 0x33CDA1 VA: 0x33CCA0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.get_Current
	|
	|-RVA: 0x33CD80 Offset: 0x33CE81 VA: 0x33CD80
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.get_Current
	|
	|-RVA: 0x33CE60 Offset: 0x33CF61 VA: 0x33CE60
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.get_Current
	|
	|-RVA: 0x33CF40 Offset: 0x33D041 VA: 0x33CF40
	|-Array.InternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.get_Current
	|
	|-RVA: 0x33D020 Offset: 0x33D121 VA: 0x33D020
	|-Array.InternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.get_Current
	|
	|-RVA: 0x33D100 Offset: 0x33D201 VA: 0x33D100
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveData>>.get_Current
	|
	|-RVA: 0x33D1E0 Offset: 0x33D2E1 VA: 0x33D1E0
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.get_Current
	|
	|-RVA: 0x33D2C0 Offset: 0x33D3C1 VA: 0x33D2C0
	|-Array.InternalEnumerator<KeyValuePair<object, Parameter>>.get_Current
	|
	|-RVA: 0x33D3A0 Offset: 0x33D4A1 VA: 0x33D3A0
	|-Array.InternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.get_Current
	|
	|-RVA: 0x33D480 Offset: 0x33D581 VA: 0x33D480
	|-Array.InternalEnumerator<KeyValuePair<object, bool>>.get_Current
	|
	|-RVA: 0x33D560 Offset: 0x33D661 VA: 0x33D560
	|-Array.InternalEnumerator<KeyValuePair<object, byte>>.get_Current
	|
	|-RVA: 0x33D640 Offset: 0x33D741 VA: 0x33D640
	|-Array.InternalEnumerator<KeyValuePair<object, char>>.get_Current
	|
	|-RVA: 0x33D720 Offset: 0x33D821 VA: 0x33D720
	|-Array.InternalEnumerator<KeyValuePair<object, DateTime>>.get_Current
	|
	|-RVA: 0x33D800 Offset: 0x33D901 VA: 0x33D800
	|-Array.InternalEnumerator<KeyValuePair<object, double>>.get_Current
	|
	|-RVA: 0x33D8E0 Offset: 0x33D9E1 VA: 0x33D8E0
	|-Array.InternalEnumerator<KeyValuePair<object, short>>.get_Current
	|
	|-RVA: 0x33D9C0 Offset: 0x33DAC1 VA: 0x33D9C0
	|-Array.InternalEnumerator<KeyValuePair<object, int>>.get_Current
	|
	|-RVA: 0x33DAA0 Offset: 0x33DBA1 VA: 0x33DAA0
	|-Array.InternalEnumerator<KeyValuePair<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x33DB80 Offset: 0x33DC81 VA: 0x33DB80
	|-Array.InternalEnumerator<KeyValuePair<object, long>>.get_Current
	|
	|-RVA: 0x33DC60 Offset: 0x33DD61 VA: 0x33DC60
	|-Array.InternalEnumerator<KeyValuePair<object, Memory<object>>>.get_Current
	|
	|-RVA: 0x33DD40 Offset: 0x33DE41 VA: 0x33DD40
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.get_Current
	|
	|-RVA: 0x33DE20 Offset: 0x33DF21 VA: 0x33DE20
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.get_Current
	|
	|-RVA: 0x33DF00 Offset: 0x33E001 VA: 0x33DF00
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.get_Current
	|
	|-RVA: 0x33DFE0 Offset: 0x33E0E1 VA: 0x33DFE0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.get_Current
	|
	|-RVA: 0x33E0C0 Offset: 0x33E1C1 VA: 0x33E0C0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color>>>.get_Current
	|
	|-RVA: 0x33E1A0 Offset: 0x33E2A1 VA: 0x33E1A0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.get_Current
	|
	|-RVA: 0x33E280 Offset: 0x33E381 VA: 0x33E280
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.get_Current
	|
	|-RVA: 0x33E360 Offset: 0x33E461 VA: 0x33E360
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.get_Current
	|
	|-RVA: 0x33E440 Offset: 0x33E541 VA: 0x33E440
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.get_Current
	|
	|-RVA: 0x33E520 Offset: 0x33E621 VA: 0x33E520
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.get_Current
	|
	|-RVA: 0x33E600 Offset: 0x33E701 VA: 0x33E600
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.get_Current
	|
	|-RVA: 0x33E6E0 Offset: 0x33E7E1 VA: 0x33E6E0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.get_Current
	|
	|-RVA: 0x33E7C0 Offset: 0x33E8C1 VA: 0x33E7C0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.get_Current
	|
	|-RVA: 0x33E8A0 Offset: 0x33E9A1 VA: 0x33E8A0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.get_Current
	|
	|-RVA: 0x33E980 Offset: 0x33EA81 VA: 0x33E980
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.get_Current
	|
	|-RVA: 0x33EA60 Offset: 0x33EB61 VA: 0x33EA60
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.get_Current
	|
	|-RVA: 0x33EB40 Offset: 0x33EC41 VA: 0x33EB40
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.get_Current
	|
	|-RVA: 0x33EC20 Offset: 0x33ED21 VA: 0x33EC20
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.get_Current
	|
	|-RVA: 0x33ED00 Offset: 0x33EE01 VA: 0x33ED00
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.get_Current
	|
	|-RVA: 0x33EDE0 Offset: 0x33EEE1 VA: 0x33EDE0
	|-Array.InternalEnumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x355550 Offset: 0x355651 VA: 0x355550
	|-Array.InternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.get_Current
	|
	|-RVA: 0x355630 Offset: 0x355731 VA: 0x355630
	|-Array.InternalEnumerator<KeyValuePair<object, ResourceLocator>>.get_Current
	|
	|-RVA: 0x355710 Offset: 0x355811 VA: 0x355710
	|-Array.InternalEnumerator<KeyValuePair<object, sbyte>>.get_Current
	|
	|-RVA: 0x3557F0 Offset: 0x3558F1 VA: 0x3557F0
	|-Array.InternalEnumerator<KeyValuePair<object, float>>.get_Current
	|
	|-RVA: 0x3558D0 Offset: 0x3559D1 VA: 0x3558D0
	|-Array.InternalEnumerator<KeyValuePair<object, ushort>>.get_Current
	|
	|-RVA: 0x3559B0 Offset: 0x355AB1 VA: 0x3559B0
	|-Array.InternalEnumerator<KeyValuePair<object, uint>>.get_Current
	|
	|-RVA: 0x355A90 Offset: 0x355B91 VA: 0x355A90
	|-Array.InternalEnumerator<KeyValuePair<object, ulong>>.get_Current
	|
	|-RVA: 0x355B70 Offset: 0x355C71 VA: 0x355B70
	|-Array.InternalEnumerator<KeyValuePair<object, TransitionTables>>.get_Current
	|
	|-RVA: 0x355C50 Offset: 0x355D51 VA: 0x355C50
	|-Array.InternalEnumerator<KeyValuePair<object, Bounds>>.get_Current
	|
	|-RVA: 0x355D30 Offset: 0x355E31 VA: 0x355D30
	|-Array.InternalEnumerator<KeyValuePair<object, BoundsInt>>.get_Current
	|
	|-RVA: 0x355E10 Offset: 0x355F11 VA: 0x355E10
	|-Array.InternalEnumerator<KeyValuePair<object, Color32>>.get_Current
	|
	|-RVA: 0x355EF0 Offset: 0x355FF1 VA: 0x355EF0
	|-Array.InternalEnumerator<KeyValuePair<object, Color>>.get_Current
	|
	|-RVA: 0x355FD0 Offset: 0x3560D1 VA: 0x355FD0
	|-Array.InternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x3560B0 Offset: 0x3561B1 VA: 0x3560B0
	|-Array.InternalEnumerator<KeyValuePair<object, GradientColorKey>>.get_Current
	|
	|-RVA: 0x356190 Offset: 0x356291 VA: 0x356190
	|-Array.InternalEnumerator<KeyValuePair<object, Keyframe>>.get_Current
	|
	|-RVA: 0x356270 Offset: 0x356371 VA: 0x356270
	|-Array.InternalEnumerator<KeyValuePair<object, LayerMask>>.get_Current
	|
	|-RVA: 0x356350 Offset: 0x356451 VA: 0x356350
	|-Array.InternalEnumerator<KeyValuePair<object, Matrix4x4>>.get_Current
	|
	|-RVA: 0x356430 Offset: 0x356531 VA: 0x356430
	|-Array.InternalEnumerator<KeyValuePair<object, Playable>>.get_Current
	|
	|-RVA: 0x356510 Offset: 0x356611 VA: 0x356510
	|-Array.InternalEnumerator<KeyValuePair<object, Quaternion>>.get_Current
	|
	|-RVA: 0x3565F0 Offset: 0x3566F1 VA: 0x3565F0
	|-Array.InternalEnumerator<KeyValuePair<object, RangeInt>>.get_Current
	|
	|-RVA: 0x3566D0 Offset: 0x3567D1 VA: 0x3566D0
	|-Array.InternalEnumerator<KeyValuePair<object, Rect>>.get_Current
	|
	|-RVA: 0x3567B0 Offset: 0x3568B1 VA: 0x3567B0
	|-Array.InternalEnumerator<KeyValuePair<object, RectInt>>.get_Current
	|
	|-RVA: 0x356890 Offset: 0x356991 VA: 0x356890
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x356970 Offset: 0x356A71 VA: 0x356970
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.get_Current
	|
	|-RVA: 0x356A50 Offset: 0x356B51 VA: 0x356A50
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2>>.get_Current
	|
	|-RVA: 0x356B30 Offset: 0x356C31 VA: 0x356B30
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2Int>>.get_Current
	|
	|-RVA: 0x356C10 Offset: 0x356D11 VA: 0x356C10
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3>>.get_Current
	|
	|-RVA: 0x356CF0 Offset: 0x356DF1 VA: 0x356CF0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3Int>>.get_Current
	|
	|-RVA: 0x356DD0 Offset: 0x356ED1 VA: 0x356DD0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector4>>.get_Current
	|
	|-RVA: 0x356EB0 Offset: 0x356FB1 VA: 0x356EB0
	|-Array.InternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.get_Current
	|
	|-RVA: 0x356F90 Offset: 0x357091 VA: 0x356F90
	|-Array.InternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.get_Current
	|
	|-RVA: 0x357070 Offset: 0x357171 VA: 0x357070
	|-Array.InternalEnumerator<KeyValuePair<sbyte, object>>.get_Current
	|
	|-RVA: 0x357150 Offset: 0x357251 VA: 0x357150
	|-Array.InternalEnumerator<KeyValuePair<float, CurveSample>>.get_Current
	|
	|-RVA: 0x357230 Offset: 0x357331 VA: 0x357230
	|-Array.InternalEnumerator<KeyValuePair<float, object>>.get_Current
	|
	|-RVA: 0x357310 Offset: 0x357411 VA: 0x357310
	|-Array.InternalEnumerator<KeyValuePair<ushort, object>>.get_Current
	|
	|-RVA: 0x3573F0 Offset: 0x3574F1 VA: 0x3573F0
	|-Array.InternalEnumerator<KeyValuePair<uint, int>>.get_Current
	|
	|-RVA: 0x357550 Offset: 0x357651 VA: 0x357550
	|-Array.InternalEnumerator<KeyValuePair<uint, Int32Enum>>.get_Current
	|
	|-RVA: 0x3576B0 Offset: 0x3577B1 VA: 0x3576B0
	|-Array.InternalEnumerator<KeyValuePair<uint, object>>.get_Current
	|
	|-RVA: 0x357790 Offset: 0x357891 VA: 0x357790
	|-Array.InternalEnumerator<KeyValuePair<ulong, object>>.get_Current
	|
	|-RVA: 0x357870 Offset: 0x357971 VA: 0x357870
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.get_Current
	|
	|-RVA: 0x357960 Offset: 0x357A61 VA: 0x357960
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.get_Current
	|
	|-RVA: 0x357A40 Offset: 0x357B41 VA: 0x357A40
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.get_Current
	|
	|-RVA: 0x357B20 Offset: 0x357C21 VA: 0x357B20
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.get_Current
	|
	|-RVA: 0x357C00 Offset: 0x357D01 VA: 0x357C00
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.get_Current
	|
	|-RVA: 0x357CF0 Offset: 0x357DF1 VA: 0x357CF0
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.get_Current
	|
	|-RVA: 0x357DD0 Offset: 0x357ED1 VA: 0x357DD0
	|-Array.InternalEnumerator<KeyValuePair<Bounds, object>>.get_Current
	|
	|-RVA: 0x357EB0 Offset: 0x357FB1 VA: 0x357EB0
	|-Array.InternalEnumerator<KeyValuePair<BoundsInt, object>>.get_Current
	|
	|-RVA: 0x357F90 Offset: 0x358091 VA: 0x357F90
	|-Array.InternalEnumerator<KeyValuePair<Color, object>>.get_Current
	|
	|-RVA: 0x358070 Offset: 0x358171 VA: 0x358070
	|-Array.InternalEnumerator<KeyValuePair<Color32, object>>.get_Current
	|
	|-RVA: 0x358150 Offset: 0x358251 VA: 0x358150
	|-Array.InternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.get_Current
	|
	|-RVA: 0x358230 Offset: 0x358331 VA: 0x358230
	|-Array.InternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.get_Current
	|
	|-RVA: 0x358310 Offset: 0x358411 VA: 0x358310
	|-Array.InternalEnumerator<KeyValuePair<GradientColorKey, object>>.get_Current
	|
	|-RVA: 0x3583F0 Offset: 0x3584F1 VA: 0x3583F0
	|-Array.InternalEnumerator<KeyValuePair<Keyframe, object>>.get_Current
	|
	|-RVA: 0x3584D0 Offset: 0x3585D1 VA: 0x3584D0
	|-Array.InternalEnumerator<KeyValuePair<LayerMask, object>>.get_Current
	|
	|-RVA: 0x3585B0 Offset: 0x3586B1 VA: 0x3585B0
	|-Array.InternalEnumerator<KeyValuePair<Matrix4x4, object>>.get_Current
	|
	|-RVA: 0x358690 Offset: 0x358791 VA: 0x358690
	|-Array.InternalEnumerator<KeyValuePair<IntVec3, object>>.get_Current
	|
	|-RVA: 0x358770 Offset: 0x358871 VA: 0x358770
	|-Array.InternalEnumerator<KeyValuePair<Quaternion, object>>.get_Current
	|
	|-RVA: 0x358850 Offset: 0x358951 VA: 0x358850
	|-Array.InternalEnumerator<KeyValuePair<RangeInt, object>>.get_Current
	|
	|-RVA: 0x358930 Offset: 0x358A31 VA: 0x358930
	|-Array.InternalEnumerator<KeyValuePair<Rect, object>>.get_Current
	|
	|-RVA: 0x358A10 Offset: 0x358B11 VA: 0x358A10
	|-Array.InternalEnumerator<KeyValuePair<RectInt, object>>.get_Current
	|
	|-RVA: 0x358AF0 Offset: 0x358BF1 VA: 0x358AF0
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.get_Current
	|
	|-RVA: 0x358BE0 Offset: 0x358CE1 VA: 0x358BE0
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.get_Current
	|
	|-RVA: 0x358CC0 Offset: 0x358DC1 VA: 0x358CC0
	|-Array.InternalEnumerator<KeyValuePair<Vector2, object>>.get_Current
	|
	|-RVA: 0x358DA0 Offset: 0x358EA1 VA: 0x358DA0
	|-Array.InternalEnumerator<KeyValuePair<Vector2Int, object>>.get_Current
	|
	|-RVA: 0x358E80 Offset: 0x358F81 VA: 0x358E80
	|-Array.InternalEnumerator<KeyValuePair<Vector3, object>>.get_Current
	|
	|-RVA: 0x358F60 Offset: 0x359061 VA: 0x358F60
	|-Array.InternalEnumerator<KeyValuePair<Vector3Int, object>>.get_Current
	|
	|-RVA: 0x359040 Offset: 0x359141 VA: 0x359040
	|-Array.InternalEnumerator<KeyValuePair<Vector4, object>>.get_Current
	|
	|-RVA: 0x359120 Offset: 0x359221 VA: 0x359120
	|-Array.InternalEnumerator<Hashtable.bucket>.get_Current
	|
	|-RVA: 0x359200 Offset: 0x359301 VA: 0x359200
	|-Array.InternalEnumerator<DateTime>.get_Current
	|
	|-RVA: 0x359360 Offset: 0x359461 VA: 0x359360
	|-Array.InternalEnumerator<DateTimeOffset>.get_Current
	|
	|-RVA: 0x359440 Offset: 0x359541 VA: 0x359440
	|-Array.InternalEnumerator<Decimal>.get_Current
	|
	|-RVA: 0x359520 Offset: 0x359621 VA: 0x359520
	|-Array.InternalEnumerator<double>.get_Current
	|
	|-RVA: 0x359680 Offset: 0x359781 VA: 0x359680
	|-Array.InternalEnumerator<InternalCodePageDataItem>.get_Current
	|
	|-RVA: 0x359760 Offset: 0x359861 VA: 0x359760
	|-Array.InternalEnumerator<InternalEncodingDataItem>.get_Current
	|
	|-RVA: 0x359840 Offset: 0x359941 VA: 0x359840
	|-Array.InternalEnumerator<Guid>.get_Current
	|
	|-RVA: 0x359920 Offset: 0x359A21 VA: 0x359920
	|-Array.InternalEnumerator<short>.get_Current
	|
	|-RVA: 0x359A80 Offset: 0x359B81 VA: 0x359A80
	|-Array.InternalEnumerator<int>.get_Current
	|
	|-RVA: 0x359BE0 Offset: 0x359CE1 VA: 0x359BE0
	|-Array.InternalEnumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x359D40 Offset: 0x359E41 VA: 0x359D40
	|-Array.InternalEnumerator<long>.get_Current
	|
	|-RVA: 0x359EA0 Offset: 0x359FA1 VA: 0x359EA0
	|-Array.InternalEnumerator<IntPtr>.get_Current
	|
	|-RVA: 0x35A000 Offset: 0x35A101 VA: 0x35A000
	|-Array.InternalEnumerator<InterpretedFrameInfo>.get_Current
	|
	|-RVA: 0x35A0E0 Offset: 0x35A1E1 VA: 0x35A0E0
	|-Array.InternalEnumerator<LocalDefinition>.get_Current
	|
	|-RVA: 0x35A1C0 Offset: 0x35A2C1 VA: 0x35A1C0
	|-Array.InternalEnumerator<RuntimeLabel>.get_Current
	|
	|-RVA: 0x35A2B0 Offset: 0x35A3B1 VA: 0x35A2B0
	|-Array.InternalEnumerator<Set.Slot<int>>.get_Current
	|
	|-RVA: 0x35A3A0 Offset: 0x35A4A1 VA: 0x35A3A0
	|-Array.InternalEnumerator<Set.Slot<object>>.get_Current
	|
	|-RVA: 0x35A480 Offset: 0x35A581 VA: 0x35A480
	|-Array.InternalEnumerator<Memory<object>>.get_Current
	|
	|-RVA: 0x35A560 Offset: 0x35A661 VA: 0x35A560
	|-Array.InternalEnumerator<CookieTokenizer.RecognizedAttribute>.get_Current
	|
	|-RVA: 0x35A640 Offset: 0x35A741 VA: 0x35A640
	|-Array.InternalEnumerator<HeaderVariantInfo>.get_Current
	|
	|-RVA: 0x35A720 Offset: 0x35A821 VA: 0x35A720
	|-Array.InternalEnumerator<Socket.WSABUF>.get_Current
	|
	|-RVA: 0x35A800 Offset: 0x35A901 VA: 0x35A800
	|-Array.InternalEnumerator<Nullable<ReadOnlySequence<byte>>>.get_Current
	|
	|-RVA: 0x35A8E0 Offset: 0x35A9E1 VA: 0x35A8E0
	|-Array.InternalEnumerator<Nullable<Int32Enum>>.get_Current
	|
	|-RVA: 0x35AA40 Offset: 0x35AB41 VA: 0x35AA40
	|-Array.InternalEnumerator<Nullable<Bounds>>.get_Current
	|
	|-RVA: 0x35AB20 Offset: 0x35AC21 VA: 0x35AB20
	|-Array.InternalEnumerator<Nullable<BoundsInt>>.get_Current
	|
	|-RVA: 0x35AC00 Offset: 0x35AD01 VA: 0x35AC00
	|-Array.InternalEnumerator<Nullable<Color32>>.get_Current
	|
	|-RVA: 0x35AD60 Offset: 0x35AE61 VA: 0x35AD60
	|-Array.InternalEnumerator<Nullable<Color>>.get_Current
	|
	|-RVA: 0x35AE40 Offset: 0x35AF41 VA: 0x35AE40
	|-Array.InternalEnumerator<Nullable<GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x35AF30 Offset: 0x35B031 VA: 0x35AF30
	|-Array.InternalEnumerator<Nullable<GradientColorKey>>.get_Current
	|
	|-RVA: 0x35B010 Offset: 0x35B111 VA: 0x35B010
	|-Array.InternalEnumerator<Nullable<Keyframe>>.get_Current
	|
	|-RVA: 0x35B0F0 Offset: 0x35B1F1 VA: 0x35B0F0
	|-Array.InternalEnumerator<Nullable<LayerMask>>.get_Current
	|
	|-RVA: 0x35B250 Offset: 0x35B351 VA: 0x35B250
	|-Array.InternalEnumerator<Nullable<Matrix4x4>>.get_Current
	|
	|-RVA: 0x35B330 Offset: 0x35B431 VA: 0x35B330
	|-Array.InternalEnumerator<Nullable<Quaternion>>.get_Current
	|
	|-RVA: 0x35B410 Offset: 0x35B511 VA: 0x35B410
	|-Array.InternalEnumerator<Nullable<RangeInt>>.get_Current
	|
	|-RVA: 0x35B500 Offset: 0x35B601 VA: 0x35B500
	|-Array.InternalEnumerator<Nullable<Rect>>.get_Current
	|
	|-RVA: 0x35B5E0 Offset: 0x35B6E1 VA: 0x35B5E0
	|-Array.InternalEnumerator<Nullable<RectInt>>.get_Current
	|
	|-RVA: 0x35B6C0 Offset: 0x35B7C1 VA: 0x35B6C0
	|-Array.InternalEnumerator<Nullable<Vector2>>.get_Current
	|
	|-RVA: 0x35B7B0 Offset: 0x35B8B1 VA: 0x35B7B0
	|-Array.InternalEnumerator<Nullable<Vector2Int>>.get_Current
	|
	|-RVA: 0x35B8A0 Offset: 0x35B9A1 VA: 0x35B8A0
	|-Array.InternalEnumerator<Nullable<Vector3>>.get_Current
	|
	|-RVA: 0x342A80 Offset: 0x342B81 VA: 0x342A80
	|-Array.InternalEnumerator<Nullable<Vector3Int>>.get_Current
	|
	|-RVA: 0x342B60 Offset: 0x342C61 VA: 0x342B60
	|-Array.InternalEnumerator<Nullable<Vector4>>.get_Current
	|
	|-RVA: 0x342C40 Offset: 0x342D41 VA: 0x342C40
	|-Array.InternalEnumerator<object>.get_Current
	|
	|-RVA: 0x342D50 Offset: 0x342E51 VA: 0x342D50
	|-Array.InternalEnumerator<ParameterizedStrings.FormatParam>.get_Current
	|
	|-RVA: 0x342E30 Offset: 0x342F31 VA: 0x342E30
	|-Array.InternalEnumerator<ReadOnlyMemory<object>>.get_Current
	|
	|-RVA: 0x342F10 Offset: 0x343011 VA: 0x342F10
	|-Array.InternalEnumerator<CustomAttributeNamedArgument>.get_Current
	|
	|-RVA: 0x342FF0 Offset: 0x3430F1 VA: 0x342FF0
	|-Array.InternalEnumerator<CustomAttributeTypedArgument>.get_Current
	|
	|-RVA: 0x3430D0 Offset: 0x3431D1 VA: 0x3430D0
	|-Array.InternalEnumerator<Label>.get_Current
	|
	|-RVA: 0x343240 Offset: 0x343341 VA: 0x343240
	|-Array.InternalEnumerator<ParameterModifier>.get_Current
	|
	|-RVA: 0x3433A0 Offset: 0x3434A1 VA: 0x3433A0
	|-Array.InternalEnumerator<ResourceLocator>.get_Current
	|
	|-RVA: 0x343480 Offset: 0x343581 VA: 0x343480
	|-Array.InternalEnumerator<Ephemeron>.get_Current
	|
	|-RVA: 0x343560 Offset: 0x343661 VA: 0x343560
	|-Array.InternalEnumerator<GCHandle>.get_Current
	|
	|-RVA: 0x3436D0 Offset: 0x3437D1 VA: 0x3436D0
	|-Array.InternalEnumerator<RuntimeTypeHandle>.get_Current
	|
	|-RVA: 0x343830 Offset: 0x343931 VA: 0x343830
	|-Array.InternalEnumerator<sbyte>.get_Current
	|
	|-RVA: 0x343990 Offset: 0x343A91 VA: 0x343990
	|-Array.InternalEnumerator<X509ChainStatus>.get_Current
	|
	|-RVA: 0x343A70 Offset: 0x343B71 VA: 0x343A70
	|-Array.InternalEnumerator<float>.get_Current
	|
	|-RVA: 0x343BD0 Offset: 0x343CD1 VA: 0x343BD0
	|-Array.InternalEnumerator<RegexCharClass.LowerCaseMapping>.get_Current
	|
	|-RVA: 0x343CC0 Offset: 0x343DC1 VA: 0x343CC0
	|-Array.InternalEnumerator<CancellationTokenRegistration>.get_Current
	|
	|-RVA: 0x343DA0 Offset: 0x343EA1 VA: 0x343DA0
	|-Array.InternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.get_Current
	|
	|-RVA: 0x343F00 Offset: 0x344001 VA: 0x343F00
	|-Array.InternalEnumerator<TimeSpan>.get_Current
	|
	|-RVA: 0x344060 Offset: 0x344161 VA: 0x344060
	|-Array.InternalEnumerator<ushort>.get_Current
	|
	|-RVA: 0x3441C0 Offset: 0x3442C1 VA: 0x3441C0
	|-Array.InternalEnumerator<UInt16Enum>.get_Current
	|
	|-RVA: 0x344320 Offset: 0x344421 VA: 0x344320
	|-Array.InternalEnumerator<uint>.get_Current
	|
	|-RVA: 0x344480 Offset: 0x344581 VA: 0x344480
	|-Array.InternalEnumerator<UInt32Enum>.get_Current
	|
	|-RVA: 0x3445E0 Offset: 0x3446E1 VA: 0x3445E0
	|-Array.InternalEnumerator<ulong>.get_Current
	|
	|-RVA: 0x344740 Offset: 0x344841 VA: 0x344740
	|-Array.InternalEnumerator<ValueTuple<bool, Int32Enum>>.get_Current
	|
	|-RVA: 0x3448A0 Offset: 0x3449A1 VA: 0x3448A0
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x344A00 Offset: 0x344B01 VA: 0x344A00
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x344AE0 Offset: 0x344BE1 VA: 0x344AE0
	|-Array.InternalEnumerator<ValueTuple<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x344BC0 Offset: 0x344CC1 VA: 0x344BC0
	|-Array.InternalEnumerator<ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x344CA0 Offset: 0x344DA1 VA: 0x344CA0
	|-Array.InternalEnumerator<ValueTuple<object, float>>.get_Current
	|
	|-RVA: 0x344D80 Offset: 0x344E81 VA: 0x344D80
	|-Array.InternalEnumerator<ValueTuple<float, object>>.get_Current
	|
	|-RVA: 0x344E60 Offset: 0x344F61 VA: 0x344E60
	|-Array.InternalEnumerator<ValueTuple<float, float>>.get_Current
	|
	|-RVA: 0x344F40 Offset: 0x345041 VA: 0x344F40
	|-Array.InternalEnumerator<ValueTuple<Vector3, Quaternion>>.get_Current
	|
	|-RVA: 0x345020 Offset: 0x345121 VA: 0x345020
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x345110 Offset: 0x345211 VA: 0x345110
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3>>.get_Current
	|
	|-RVA: 0x3451F0 Offset: 0x3452F1 VA: 0x3451F0
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3, float>>.get_Current
	|
	|-RVA: 0x3452D0 Offset: 0x3453D1 VA: 0x3452D0
	|-Array.InternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Current
	|
	|-RVA: 0x3453B0 Offset: 0x3454B1 VA: 0x3453B0
	|-Array.InternalEnumerator<HighlightState>.get_Current
	|
	|-RVA: 0x345490 Offset: 0x345591 VA: 0x345490
	|-Array.InternalEnumerator<MaterialReference>.get_Current
	|
	|-RVA: 0x345570 Offset: 0x345671 VA: 0x345570
	|-Array.InternalEnumerator<RichTextTagAttribute>.get_Current
	|
	|-RVA: 0x345650 Offset: 0x345751 VA: 0x345650
	|-Array.InternalEnumerator<TexturePacker_JsonArray.Frame>.get_Current
	|
	|-RVA: 0x345730 Offset: 0x345831 VA: 0x345730
	|-Array.InternalEnumerator<TMP_CharacterInfo>.get_Current
	|
	|-RVA: 0x345810 Offset: 0x345911 VA: 0x345810
	|-Array.InternalEnumerator<TMP_FontWeightPair>.get_Current
	|
	|-RVA: 0x3458F0 Offset: 0x3459F1 VA: 0x3458F0
	|-Array.InternalEnumerator<TMP_LineInfo>.get_Current
	|
	|-RVA: 0x3459D0 Offset: 0x345AD1 VA: 0x3459D0
	|-Array.InternalEnumerator<TMP_LinkInfo>.get_Current
	|
	|-RVA: 0x345AB0 Offset: 0x345BB1 VA: 0x345AB0
	|-Array.InternalEnumerator<TMP_MeshInfo>.get_Current
	|
	|-RVA: 0x345B90 Offset: 0x345C91 VA: 0x345B90
	|-Array.InternalEnumerator<TMP_PageInfo>.get_Current
	|
	|-RVA: 0x345C70 Offset: 0x345D71 VA: 0x345C70
	|-Array.InternalEnumerator<TMP_Text.UnicodeChar>.get_Current
	|
	|-RVA: 0x345D60 Offset: 0x345E61 VA: 0x345D60
	|-Array.InternalEnumerator<TMP_TextProcessingStack<int>>.get_Current
	|
	|-RVA: 0x345E40 Offset: 0x345F41 VA: 0x345E40
	|-Array.InternalEnumerator<TMP_WordInfo>.get_Current
	|
	|-RVA: 0x345F20 Offset: 0x346021 VA: 0x345F20
	|-Array.InternalEnumerator<WordWrapState>.get_Current
	|
	|-RVA: 0x346000 Offset: 0x346101 VA: 0x346000
	|-Array.InternalEnumerator<TextPaneDatas.TextPaneData>.get_Current
	|
	|-RVA: 0x3460E0 Offset: 0x3461E1 VA: 0x3460E0
	|-Array.InternalEnumerator<TransitionTables>.get_Current
	|
	|-RVA: 0x3461C0 Offset: 0x3462C1 VA: 0x3461C0
	|-Array.InternalEnumerator<TutorialUnlockFlagData>.get_Current
	|
	|-RVA: 0x3462B0 Offset: 0x3463B1 VA: 0x3462B0
	|-Array.InternalEnumerator<UICheckOnBackRune.LinkSet>.get_Current
	|
	|-RVA: 0x346390 Offset: 0x346491 VA: 0x346390
	|-Array.InternalEnumerator<UIMainManagerAttachObject.AttachSet>.get_Current
	|
	|-RVA: 0x346470 Offset: 0x346571 VA: 0x346470
	|-Array.InternalEnumerator<CapEdge>.get_Current
	|
	|-RVA: 0x346550 Offset: 0x346651 VA: 0x346550
	|-Array.InternalEnumerator<ClippedEdge>.get_Current
	|
	|-RVA: 0x346630 Offset: 0x346731 VA: 0x346630
	|-Array.InternalEnumerator<EdgeKeyByHash>.get_Current
	|
	|-RVA: 0x346790 Offset: 0x346891 VA: 0x346790
	|-Array.InternalEnumerator<EdgeKeyByIndex>.get_Current
	|
	|-RVA: 0x3468F0 Offset: 0x3469F1 VA: 0x3468F0
	|-Array.InternalEnumerator<MeshDataConnectivity.Face>.get_Current
	|
	|-RVA: 0x346A50 Offset: 0x346B51 VA: 0x346A50
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.get_Current
	|
	|-RVA: 0x346B30 Offset: 0x346C31 VA: 0x346B30
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData>.get_Current
	|
	|-RVA: 0x346C10 Offset: 0x346D11 VA: 0x346C10
	|-Array.InternalEnumerator<NavMeshBuildMarkup>.get_Current
	|
	|-RVA: 0x346CF0 Offset: 0x346DF1 VA: 0x346CF0
	|-Array.InternalEnumerator<NavMeshBuildSource>.get_Current
	|
	|-RVA: 0x346DD0 Offset: 0x346ED1 VA: 0x346DD0
	|-Array.InternalEnumerator<ContentCatalogData.Bucket>.get_Current
	|
	|-RVA: 0x346EB0 Offset: 0x346FB1 VA: 0x346EB0
	|-Array.InternalEnumerator<ConstraintSource>.get_Current
	|
	|-RVA: 0x346F90 Offset: 0x347091 VA: 0x346F90
	|-Array.InternalEnumerator<PropertySceneHandle>.get_Current
	|
	|-RVA: 0x3470F0 Offset: 0x3471F1 VA: 0x3470F0
	|-Array.InternalEnumerator<TransformStreamHandle>.get_Current
	|
	|-RVA: 0x3471E0 Offset: 0x3472E1 VA: 0x3471E0
	|-Array.InternalEnumerator<AnimatorClipInfo>.get_Current
	|
	|-RVA: 0x347340 Offset: 0x347441 VA: 0x347340
	|-Array.InternalEnumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|
	|-RVA: 0x347420 Offset: 0x347521 VA: 0x347420
	|-Array.InternalEnumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x347580 Offset: 0x347681 VA: 0x347580
	|-Array.InternalEnumerator<BoneWeight>.get_Current
	|
	|-RVA: 0x347660 Offset: 0x347761 VA: 0x347660
	|-Array.InternalEnumerator<BoundingSphere>.get_Current
	|
	|-RVA: 0x347740 Offset: 0x347841 VA: 0x347740
	|-Array.InternalEnumerator<Bounds>.get_Current
	|
	|-RVA: 0x347820 Offset: 0x347921 VA: 0x347820
	|-Array.InternalEnumerator<BoundsInt>.get_Current
	|
	|-RVA: 0x347900 Offset: 0x347A01 VA: 0x347900
	|-Array.InternalEnumerator<CharacterInfo>.get_Current
	|
	|-RVA: 0x3479E0 Offset: 0x347AE1 VA: 0x3479E0
	|-Array.InternalEnumerator<Color32>.get_Current
	|
	|-RVA: 0x347B50 Offset: 0x347C51 VA: 0x347B50
	|-Array.InternalEnumerator<Color>.get_Current
	|
	|-RVA: 0x347C30 Offset: 0x347D31 VA: 0x347C30
	|-Array.InternalEnumerator<CombineInstance>.get_Current
	|
	|-RVA: 0x347D10 Offset: 0x347E11 VA: 0x347D10
	|-Array.InternalEnumerator<ContactPoint2D>.get_Current
	|
	|-RVA: 0x347DF0 Offset: 0x347EF1 VA: 0x347DF0
	|-Array.InternalEnumerator<ContactPoint>.get_Current
	|
	|-RVA: 0x347ED0 Offset: 0x347FD1 VA: 0x347ED0
	|-Array.InternalEnumerator<RaycastResult>.get_Current
	|
	|-RVA: 0x347FB0 Offset: 0x3480B1 VA: 0x347FB0
	|-Array.InternalEnumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x348090 Offset: 0x348191 VA: 0x348090
	|-Array.InternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.get_Current
	|
	|-RVA: 0x3481F0 Offset: 0x3482F1 VA: 0x3481F0
	|-Array.InternalEnumerator<GradientAlphaKey>.get_Current
	|
	|-RVA: 0x3482D0 Offset: 0x3483D1 VA: 0x3482D0
	|-Array.InternalEnumerator<GradientColorKey>.get_Current
	|
	|-RVA: 0x3483B0 Offset: 0x3484B1 VA: 0x3483B0
	|-Array.InternalEnumerator<HumanBone>.get_Current
	|
	|-RVA: 0x348490 Offset: 0x348591 VA: 0x348490
	|-Array.InternalEnumerator<Keyframe>.get_Current
	|
	|-RVA: 0x348570 Offset: 0x348671 VA: 0x348570
	|-Array.InternalEnumerator<LOD>.get_Current
	|
	|-RVA: 0x348650 Offset: 0x348751 VA: 0x348650
	|-Array.InternalEnumerator<LayerMask>.get_Current
	|
	|-RVA: 0x3487C0 Offset: 0x3488C1 VA: 0x3487C0
	|-Array.InternalEnumerator<PlayerLoopSystem>.get_Current
	|
	|-RVA: 0x3488A0 Offset: 0x3489A1 VA: 0x3488A0
	|-Array.InternalEnumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x348980 Offset: 0x348A81 VA: 0x348980
	|-Array.InternalEnumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x348A60 Offset: 0x348B61 VA: 0x348A60
	|-Array.InternalEnumerator<PatchExtents>.get_Current
	|
	|-RVA: 0x348B40 Offset: 0x348C41 VA: 0x348B40
	|-Array.InternalEnumerator<Plane>.get_Current
	|
	|-RVA: 0x348C20 Offset: 0x348D21 VA: 0x348C20
	|-Array.InternalEnumerator<Playable>.get_Current
	|
	|-RVA: 0x348D00 Offset: 0x348E01 VA: 0x348D00
	|-Array.InternalEnumerator<PlayableBinding>.get_Current
	|
	|-RVA: 0x348DE0 Offset: 0x348EE1 VA: 0x348DE0
	|-Array.InternalEnumerator<PlayableGraph>.get_Current
	|
	|-RVA: 0x348EC0 Offset: 0x348FC1 VA: 0x348EC0
	|-Array.InternalEnumerator<Edge>.get_Current
	|
	|-RVA: 0x349020 Offset: 0x349121 VA: 0x349020
	|-Array.InternalEnumerator<IntVec3>.get_Current
	|
	|-RVA: 0x349100 Offset: 0x349201 VA: 0x349100
	|-Array.InternalEnumerator<Quaternion>.get_Current
	|
	|-RVA: 0x3491E0 Offset: 0x3492E1 VA: 0x3491E0
	|-Array.InternalEnumerator<RangeInt>.get_Current
	|
	|-RVA: 0x349340 Offset: 0x349441 VA: 0x349340
	|-Array.InternalEnumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x349420 Offset: 0x349521 VA: 0x349420
	|-Array.InternalEnumerator<RaycastHit>.get_Current
	|
	|-RVA: 0x349500 Offset: 0x349601 VA: 0x349500
	|-Array.InternalEnumerator<Rect>.get_Current
	|
	|-RVA: 0x3495E0 Offset: 0x3496E1 VA: 0x3495E0
	|-Array.InternalEnumerator<RectInt>.get_Current
	|
	|-RVA: 0x3496C0 Offset: 0x3497C1 VA: 0x3496C0
	|-Array.InternalEnumerator<RenderBuffer>.get_Current
	|
	|-RVA: 0x327DB0 Offset: 0x327EB1 VA: 0x327DB0
	|-Array.InternalEnumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x327EA0 Offset: 0x327FA1 VA: 0x327EA0
	|-Array.InternalEnumerator<ReflectionProbeBlendInfo>.get_Current
	|
	|-RVA: 0x327F80 Offset: 0x328081 VA: 0x327F80
	|-Array.InternalEnumerator<SphericalHarmonicsL2>.get_Current
	|
	|-RVA: 0x328060 Offset: 0x328161 VA: 0x328060
	|-Array.InternalEnumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x328140 Offset: 0x328241 VA: 0x328140
	|-Array.InternalEnumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x328220 Offset: 0x328321 VA: 0x328220
	|-Array.InternalEnumerator<AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x328300 Offset: 0x328401 VA: 0x328300
	|-Array.InternalEnumerator<AsyncOperationHandle<SceneInstance>>.get_Current
	|
	|-RVA: 0x3283E0 Offset: 0x3284E1 VA: 0x3283E0
	|-Array.InternalEnumerator<DiagnosticEvent>.get_Current
	|
	|-RVA: 0x3284C0 Offset: 0x3285C1 VA: 0x3284C0
	|-Array.InternalEnumerator<SceneInstance>.get_Current
	|
	|-RVA: 0x3285A0 Offset: 0x3286A1 VA: 0x3285A0
	|-Array.InternalEnumerator<DelayedActionManager.DelegateInfo>.get_Current
	|
	|-RVA: 0x328680 Offset: 0x328781 VA: 0x328680
	|-Array.InternalEnumerator<ObjectInitializationData>.get_Current
	|
	|-RVA: 0x328760 Offset: 0x328861 VA: 0x328760
	|-Array.InternalEnumerator<SerializedType>.get_Current
	|
	|-RVA: 0x328840 Offset: 0x328941 VA: 0x328840
	|-Array.InternalEnumerator<SendMouseEvents.HitInfo>.get_Current
	|
	|-RVA: 0x328920 Offset: 0x328A21 VA: 0x328920
	|-Array.InternalEnumerator<SkeletonBone>.get_Current
	|
	|-RVA: 0x328A00 Offset: 0x328B01 VA: 0x328A00
	|-Array.InternalEnumerator<GlyphRect>.get_Current
	|
	|-RVA: 0x328AE0 Offset: 0x328BE1 VA: 0x328AE0
	|-Array.InternalEnumerator<GlyphMarshallingStruct>.get_Current
	|
	|-RVA: 0x328BC0 Offset: 0x328CC1 VA: 0x328BC0
	|-Array.InternalEnumerator<GlyphPairAdjustmentRecord>.get_Current
	|
	|-RVA: 0x328CA0 Offset: 0x328DA1 VA: 0x328CA0
	|-Array.InternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.get_Current
	|
	|-RVA: 0x328D80 Offset: 0x328E81 VA: 0x328D80
	|-Array.InternalEnumerator<IntervalTreeNode>.get_Current
	|
	|-RVA: 0x328E60 Offset: 0x328F61 VA: 0x328E60
	|-Array.InternalEnumerator<IntervalTree.Entry<object>>.get_Current
	|
	|-RVA: 0x328F40 Offset: 0x329041 VA: 0x328F40
	|-Array.InternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.get_Current
	|
	|-RVA: 0x329020 Offset: 0x329121 VA: 0x329020
	|-Array.InternalEnumerator<Touch>.get_Current
	|
	|-RVA: 0x329100 Offset: 0x329201 VA: 0x329100
	|-Array.InternalEnumerator<TreeInstance>.get_Current
	|
	|-RVA: 0x3291E0 Offset: 0x3292E1 VA: 0x3291E0
	|-Array.InternalEnumerator<ColorBlock>.get_Current
	|
	|-RVA: 0x3292C0 Offset: 0x3293C1 VA: 0x3292C0
	|-Array.InternalEnumerator<Navigation>.get_Current
	|
	|-RVA: 0x3293A0 Offset: 0x3294A1 VA: 0x3293A0
	|-Array.InternalEnumerator<SpriteState>.get_Current
	|
	|-RVA: 0x329480 Offset: 0x329581 VA: 0x329480
	|-Array.InternalEnumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x329560 Offset: 0x329661 VA: 0x329560
	|-Array.InternalEnumerator<EventDispatcher.DispatchContext>.get_Current
	|
	|-RVA: 0x329640 Offset: 0x329741 VA: 0x329640
	|-Array.InternalEnumerator<EventDispatcher.EventRecord>.get_Current
	|
	|-RVA: 0x329720 Offset: 0x329821 VA: 0x329720
	|-Array.InternalEnumerator<FocusController.FocusedElement>.get_Current
	|
	|-RVA: 0x329800 Offset: 0x329901 VA: 0x329800
	|-Array.InternalEnumerator<StyleSheetCache.SheetHandleKey>.get_Current
	|
	|-RVA: 0x329960 Offset: 0x329A61 VA: 0x329960
	|-Array.InternalEnumerator<StyleValue>.get_Current
	|
	|-RVA: 0x329A40 Offset: 0x329B41 VA: 0x329A40
	|-Array.InternalEnumerator<UILineInfo>.get_Current
	|
	|-RVA: 0x329B20 Offset: 0x329C21 VA: 0x329B20
	|-Array.InternalEnumerator<UIVertex>.get_Current
	|
	|-RVA: 0x329C00 Offset: 0x329D01 VA: 0x329C00
	|-Array.InternalEnumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x329CE0 Offset: 0x329DE1 VA: 0x329CE0
	|-Array.InternalEnumerator<Vector2>.get_Current
	|
	|-RVA: 0x329DC0 Offset: 0x329EC1 VA: 0x329DC0
	|-Array.InternalEnumerator<Vector2Int>.get_Current
	|
	|-RVA: 0x329F20 Offset: 0x32A021 VA: 0x329F20
	|-Array.InternalEnumerator<Vector3>.get_Current
	|
	|-RVA: 0x32A000 Offset: 0x32A101 VA: 0x32A000
	|-Array.InternalEnumerator<Vector3Int>.get_Current
	|
	|-RVA: 0x32A0F0 Offset: 0x32A1F1 VA: 0x32A0F0
	|-Array.InternalEnumerator<Vector4>.get_Current
	|
	|-RVA: 0x32A1D0 Offset: 0x32A2D1 VA: 0x32A1D0
	|-Array.InternalEnumerator<jvalue>.get_Current
	|
	|-RVA: 0x32A330 Offset: 0x32A431 VA: 0x32A330
	|-Array.InternalEnumerator<WarpPoints.WarpPoint>.get_Current
	|
	|-RVA: 0x32A410 Offset: 0x32A511 VA: 0x32A410
	|-Array.InternalEnumerator<YieldItemParam>.get_Current
	|
	|-RVA: 0x32A570 Offset: 0x32A671 VA: 0x32A570
	|-Array.InternalEnumerator<NetworkServiceAccountId>.get_Current
	|
	|-RVA: 0x32A6D0 Offset: 0x32A7D1 VA: 0x32A6D0
	|-Array.InternalEnumerator<Uid>.get_Current
	|
	|-RVA: 0x32A7B0 Offset: 0x32A8B1 VA: 0x32A7B0
	|-Array.InternalEnumerator<ConsumableServiceItemId>.get_Current
	|
	|-RVA: 0x32A910 Offset: 0x32AA11 VA: 0x32A910
	|-Array.InternalEnumerator<NsUid>.get_Current
	|
	|-RVA: 0x32AA70 Offset: 0x32AB71 VA: 0x32AA70
	|-Array.InternalEnumerator<Friend>.get_Current
	|
	|-RVA: 0x32AB50 Offset: 0x32AC51 VA: 0x32AB50
	|-Array.InternalEnumerator<Profile>.get_Current
	|
	|-RVA: 0x32AC30 Offset: 0x32AD31 VA: 0x32AC30
	|-Array.InternalEnumerator<DirectoryEntry>.get_Current
	|
	|-RVA: 0x32AD10 Offset: 0x32AE11 VA: 0x32AD10
	|-Array.InternalEnumerator<DebugPadState>.get_Current
	|
	|-RVA: 0x32ADF0 Offset: 0x32AEF1 VA: 0x32ADF0
	|-Array.InternalEnumerator<GesturePoint>.get_Current
	|
	|-RVA: 0x32AF50 Offset: 0x32B051 VA: 0x32AF50
	|-Array.InternalEnumerator<GestureState>.get_Current
	|
	|-RVA: 0x32B030 Offset: 0x32B131 VA: 0x32B030
	|-Array.InternalEnumerator<NpadFullKeyState>.get_Current
	|
	|-RVA: 0x32B110 Offset: 0x32B211 VA: 0x32B110
	|-Array.InternalEnumerator<NpadHandheldState>.get_Current
	|
	|-RVA: 0x32B1F0 Offset: 0x32B2F1 VA: 0x32B1F0
	|-Array.InternalEnumerator<NpadJoyDualState>.get_Current
	|
	|-RVA: 0x32B2D0 Offset: 0x32B3D1 VA: 0x32B2D0
	|-Array.InternalEnumerator<NpadJoyLeftState>.get_Current
	|
	|-RVA: 0x32B3B0 Offset: 0x32B4B1 VA: 0x32B3B0
	|-Array.InternalEnumerator<NpadJoyRightState>.get_Current
	|
	|-RVA: 0x32B490 Offset: 0x32B591 VA: 0x32B490
	|-Array.InternalEnumerator<NpadStateArrayItem>.get_Current
	|
	|-RVA: 0x32B570 Offset: 0x32B671 VA: 0x32B570
	|-Array.InternalEnumerator<SixAxisSensorHandle>.get_Current
	|
	|-RVA: 0x32B6E0 Offset: 0x32B7E1 VA: 0x32B6E0
	|-Array.InternalEnumerator<SixAxisSensorState>.get_Current
	|
	|-RVA: 0x32B7C0 Offset: 0x32B8C1 VA: 0x32B7C0
	|-Array.InternalEnumerator<TouchScreenState10>.get_Current
	|
	|-RVA: 0x32B8A0 Offset: 0x32B9A1 VA: 0x32B8A0
	|-Array.InternalEnumerator<TouchScreenState11>.get_Current
	|
	|-RVA: 0x32B980 Offset: 0x32BA81 VA: 0x32B980
	|-Array.InternalEnumerator<TouchScreenState12>.get_Current
	|
	|-RVA: 0x32BA60 Offset: 0x32BB61 VA: 0x32BA60
	|-Array.InternalEnumerator<TouchScreenState13>.get_Current
	|
	|-RVA: 0x32BB40 Offset: 0x32BC41 VA: 0x32BB40
	|-Array.InternalEnumerator<TouchScreenState14>.get_Current
	|
	|-RVA: 0x32BC20 Offset: 0x32BD21 VA: 0x32BC20
	|-Array.InternalEnumerator<TouchScreenState15>.get_Current
	|
	|-RVA: 0x32BD00 Offset: 0x32BE01 VA: 0x32BD00
	|-Array.InternalEnumerator<TouchScreenState16>.get_Current
	|
	|-RVA: 0x32BDE0 Offset: 0x32BEE1 VA: 0x32BDE0
	|-Array.InternalEnumerator<TouchScreenState1>.get_Current
	|
	|-RVA: 0x32BEC0 Offset: 0x32BFC1 VA: 0x32BEC0
	|-Array.InternalEnumerator<TouchScreenState2>.get_Current
	|
	|-RVA: 0x32BFA0 Offset: 0x32C0A1 VA: 0x32BFA0
	|-Array.InternalEnumerator<TouchScreenState3>.get_Current
	|
	|-RVA: 0x32C080 Offset: 0x32C181 VA: 0x32C080
	|-Array.InternalEnumerator<TouchScreenState4>.get_Current
	|
	|-RVA: 0x32C160 Offset: 0x32C261 VA: 0x32C160
	|-Array.InternalEnumerator<TouchScreenState5>.get_Current
	|
	|-RVA: 0x32C240 Offset: 0x32C341 VA: 0x32C240
	|-Array.InternalEnumerator<TouchScreenState6>.get_Current
	|
	|-RVA: 0x32C320 Offset: 0x32C421 VA: 0x32C320
	|-Array.InternalEnumerator<TouchScreenState7>.get_Current
	|
	|-RVA: 0x32C400 Offset: 0x32C501 VA: 0x32C400
	|-Array.InternalEnumerator<TouchScreenState8>.get_Current
	|
	|-RVA: 0x32C4E0 Offset: 0x32C5E1 VA: 0x32C4E0
	|-Array.InternalEnumerator<TouchScreenState9>.get_Current
	|
	|-RVA: 0x32C5C0 Offset: 0x32C6C1 VA: 0x32C5C0
	|-Array.InternalEnumerator<TouchState>.get_Current
	|
	|-RVA: 0x32C6A0 Offset: 0x32C7A1 VA: 0x32C6A0
	|-Array.InternalEnumerator<VibrationDeviceHandle>.get_Current
	|
	|-RVA: 0x32C810 Offset: 0x32C911 VA: 0x32C810
	|-Array.InternalEnumerator<VibrationDeviceInfo>.get_Current
	|
	|-RVA: 0x32C970 Offset: 0x32CA71 VA: 0x32C970
	|-Array.InternalEnumerator<VibrationValue>.get_Current
	|
	|-RVA: 0x32CA50 Offset: 0x32CB51 VA: 0x32CA50
	|-Array.InternalEnumerator<ClusteringData>.get_Current
	|
	|-RVA: 0x32CB30 Offset: 0x32CC31 VA: 0x32CB30
	|-Array.InternalEnumerator<ClusteringProcessorState>.get_Current
	|
	|-RVA: 0x32CC10 Offset: 0x32CD11 VA: 0x32CC10
	|-Array.InternalEnumerator<Finger>.get_Current
	|
	|-RVA: 0x32CCF0 Offset: 0x32CDF1 VA: 0x32CCF0
	|-Array.InternalEnumerator<Hand>.get_Current
	|
	|-RVA: 0x32CDD0 Offset: 0x32CED1 VA: 0x32CDD0
	|-Array.InternalEnumerator<HandAnalysisImageState>.get_Current
	|
	|-RVA: 0x32CEB0 Offset: 0x32CFB1 VA: 0x32CEB0
	|-Array.InternalEnumerator<HandAnalysisSilhouetteState>.get_Current
	|
	|-RVA: 0x32CF90 Offset: 0x32D091 VA: 0x32CF90
	|-Array.InternalEnumerator<MomentProcessorState>.get_Current
	|
	|-RVA: 0x32D070 Offset: 0x32D171 VA: 0x32D070
	|-Array.InternalEnumerator<MomentStatistic>.get_Current
	|
	|-RVA: 0x32D150 Offset: 0x32D251 VA: 0x32D150
	|-Array.InternalEnumerator<Protrusion>.get_Current
	|
	|-RVA: 0x32D2B0 Offset: 0x32D3B1 VA: 0x32D2B0
	|-Array.InternalEnumerator<Shape>.get_Current
	|
	|-RVA: 0x32D390 Offset: 0x32D491 VA: 0x32D390
	|-Array.InternalEnumerator<DictionaryInfo>.get_Current
	|
	|-RVA: 0x32D4F0 Offset: 0x32D5F1 VA: 0x32D4F0
	|-Array.InternalEnumerator<UserWord>.get_Current
	|
	|-RVA: 0x32D5D0 Offset: 0x32D6D1 VA: 0x32D5D0
	|-Array.InternalEnumerator<Color4u8>.get_Current
	|
	|-RVA: 0x32D740 Offset: 0x32D841 VA: 0x32D740
	|-Array.InternalEnumerator<Float2>.get_Current
	|
	|-RVA: 0x32D820 Offset: 0x32D921 VA: 0x32D820
	|-Array.InternalEnumerator<stCommand_t>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C70 Offset: 0x315D71 VA: 0x315C70
	|-Array.InternalEnumerator<AS_ToolController.ChargeInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x315D50 Offset: 0x315E51 VA: 0x315D50
	|-Array.InternalEnumerator<ActionCommandDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x315E30 Offset: 0x315F31 VA: 0x315E30
	|-Array.InternalEnumerator<AdvScriptDefCountParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x315F10 Offset: 0x316011 VA: 0x315F10
	|-Array.InternalEnumerator<JSONDeserialization.TaskField>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316000 Offset: 0x316101 VA: 0x316000
	|-Array.InternalEnumerator<BitVector32Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316160 Offset: 0x316261 VA: 0x316160
	|-Array.InternalEnumerator<BuildItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316240 Offset: 0x316341 VA: 0x316240
	|-Array.InternalEnumerator<ButtonLinker.LinkObject>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316320 Offset: 0x316421 VA: 0x316320
	|-Array.InternalEnumerator<CharaCallTable.BustupTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316410 Offset: 0x316511 VA: 0x316410
	|-Array.InternalEnumerator<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3164F0 Offset: 0x3165F1 VA: 0x3164F0
	|-Array.InternalEnumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3165D0 Offset: 0x3166D1 VA: 0x3165D0
	|-Array.InternalEnumerator<CinemachineBlendListCamera.Instruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3166B0 Offset: 0x3167B1 VA: 0x3166B0
	|-Array.InternalEnumerator<CinemachineBlenderSettings.CustomBlend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316790 Offset: 0x316891 VA: 0x316790
	|-Array.InternalEnumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3168F0 Offset: 0x3169F1 VA: 0x3168F0
	|-Array.InternalEnumerator<CinemachineFreeLook.Orbit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3169D0 Offset: 0x316AD1 VA: 0x3169D0
	|-Array.InternalEnumerator<CinemachinePath.Waypoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316AB0 Offset: 0x316BB1 VA: 0x316AB0
	|-Array.InternalEnumerator<CinemachineSmoothPath.Waypoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316B90 Offset: 0x316C91 VA: 0x316B90
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316CF0 Offset: 0x316DF1 VA: 0x316CF0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.Instruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316DD0 Offset: 0x316ED1 VA: 0x316DD0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x316F30 Offset: 0x317031 VA: 0x316F30
	|-Array.InternalEnumerator<CinemachineTargetGroup.Target>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317010 Offset: 0x317111 VA: 0x317010
	|-Array.InternalEnumerator<NoiseSettings.TransformNoiseParams>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3170F0 Offset: 0x3171F1 VA: 0x3170F0
	|-Array.InternalEnumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3171D0 Offset: 0x3172D1 VA: 0x3171D0
	|-Array.InternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3172B0 Offset: 0x3173B1 VA: 0x3172B0
	|-Array.InternalEnumerator<HeadingTracker.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317390 Offset: 0x317491 VA: 0x317390
	|-Array.InternalEnumerator<CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317470 Offset: 0x317571 VA: 0x317470
	|-Array.InternalEnumerator<ControlPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317550 Offset: 0x317651 VA: 0x317550
	|-Array.InternalEnumerator<DamageTextInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317630 Offset: 0x317731 VA: 0x317630
	|-Array.InternalEnumerator<UIEMDefine.CategoryDataSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317710 Offset: 0x317811 VA: 0x317710
	|-Array.InternalEnumerator<DropItemParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317870 Offset: 0x317971 VA: 0x317870
	|-Array.InternalEnumerator<DropTableElement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317950 Offset: 0x317A51 VA: 0x317950
	|-Array.InternalEnumerator<EffectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317A30 Offset: 0x317B31 VA: 0x317A30
	|-Array.InternalEnumerator<EnemyPatrolPoints>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317B90 Offset: 0x317C91 VA: 0x317B90
	|-Array.InternalEnumerator<Coord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317CF0 Offset: 0x317DF1 VA: 0x317CF0
	|-Array.InternalEnumerator<ErosionBrush.UndoStep>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317DD0 Offset: 0x317ED1 VA: 0x317DD0
	|-Array.InternalEnumerator<EventCheckId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317EB0 Offset: 0x317FB1 VA: 0x317EB0
	|-Array.InternalEnumerator<EventFlagProgressData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x317F90 Offset: 0x318091 VA: 0x317F90
	|-Array.InternalEnumerator<EyeMouthAnimate.EMAnimSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3180F0 Offset: 0x3181F1 VA: 0x3180F0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_PARAM>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3181D0 Offset: 0x3182D1 VA: 0x3181D0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3182B0 Offset: 0x3183B1 VA: 0x3182B0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3183A0 Offset: 0x3184A1 VA: 0x3183A0
	|-Array.InternalEnumerator<FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318480 Offset: 0x318581 VA: 0x318480
	|-Array.InternalEnumerator<FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318560 Offset: 0x318661 VA: 0x318560
	|-Array.InternalEnumerator<FesNpcScoreData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318640 Offset: 0x318741 VA: 0x318640
	|-Array.InternalEnumerator<FieldHideItemSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318720 Offset: 0x318821 VA: 0x318720
	|-Array.InternalEnumerator<FieldItemSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318800 Offset: 0x318901 VA: 0x318800
	|-Array.InternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3188E0 Offset: 0x3189E1 VA: 0x3188E0
	|-Array.InternalEnumerator<FieldSceneData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3189D0 Offset: 0x318AD1 VA: 0x3189D0
	|-Array.InternalEnumerator<FieldTreasureBoxItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318B30 Offset: 0x318C31 VA: 0x318B30
	|-Array.InternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318C10 Offset: 0x318D11 VA: 0x318C10
	|-Array.InternalEnumerator<FieldWoodBoxSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318CF0 Offset: 0x318DF1 VA: 0x318CF0
	|-Array.InternalEnumerator<FocusObjectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318DD0 Offset: 0x318ED1 VA: 0x318DD0
	|-Array.InternalEnumerator<FurnitureData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318EB0 Offset: 0x318FB1 VA: 0x318EB0
	|-Array.InternalEnumerator<GateDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x318F90 Offset: 0x319091 VA: 0x318F90
	|-Array.InternalEnumerator<GateStatusDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319080 Offset: 0x319181 VA: 0x319080
	|-Array.InternalEnumerator<GimmickLayoutDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3191E0 Offset: 0x3192E1 VA: 0x3191E0
	|-Array.InternalEnumerator<HitResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3192C0 Offset: 0x3193C1 VA: 0x3192C0
	|-Array.InternalEnumerator<ImagePaneDatas.ImagePaneData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3193A0 Offset: 0x3194A1 VA: 0x3193A0
	|-Array.InternalEnumerator<FurnitureManager.SendPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319480 Offset: 0x319581 VA: 0x319480
	|-Array.InternalEnumerator<ItemLevelData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3195E0 Offset: 0x3196E1 VA: 0x3195E0
	|-Array.InternalEnumerator<MapDatas.MapData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3196C0 Offset: 0x3197C1 VA: 0x3196C0
	|-Array.InternalEnumerator<MapObjectDatas.MapObjectData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3197A0 Offset: 0x3198A1 VA: 0x3197A0
	|-Array.InternalEnumerator<ByteArrayStringHashTable.Entry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319880 Offset: 0x319981 VA: 0x319880
	|-Array.InternalEnumerator<MineTypeDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319960 Offset: 0x319A61 VA: 0x319960
	|-Array.InternalEnumerator<MiningDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319A40 Offset: 0x319B41 VA: 0x319A40
	|-Array.InternalEnumerator<MiningPointSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319B20 Offset: 0x319C21 VA: 0x319B20
	|-Array.InternalEnumerator<CodePointIndexer.TableRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319C00 Offset: 0x319D01 VA: 0x319C00
	|-Array.InternalEnumerator<MonsterBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319CE0 Offset: 0x319DE1 VA: 0x319CE0
	|-Array.InternalEnumerator<MonsterDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319DC0 Offset: 0x319EC1 VA: 0x319DC0
	|-Array.InternalEnumerator<MonsterDropItemDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319EA0 Offset: 0x319FA1 VA: 0x319EA0
	|-Array.InternalEnumerator<MonsterFootStepEventDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x319F80 Offset: 0x31A081 VA: 0x319F80
	|-Array.InternalEnumerator<MonsterHutSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A060 Offset: 0x31A161 VA: 0x31A060
	|-Array.InternalEnumerator<MonsterUIData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A140 Offset: 0x31A241 VA: 0x31A140
	|-Array.InternalEnumerator<MonsterYieldItemDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A220 Offset: 0x31A321 VA: 0x31A220
	|-Array.InternalEnumerator<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A300 Offset: 0x31A401 VA: 0x31A300
	|-Array.InternalEnumerator<NPCActionData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A3E0 Offset: 0x31A4E1 VA: 0x31A3E0
	|-Array.InternalEnumerator<NPCCallingNameTextData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A4C0 Offset: 0x31A5C1 VA: 0x31A4C0
	|-Array.InternalEnumerator<NPCUIData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A5A0 Offset: 0x31A6A1 VA: 0x31A5A0
	|-Array.InternalEnumerator<NpcPlaceSchedule>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A690 Offset: 0x31A791 VA: 0x31A690
	|-Array.InternalEnumerator<OrderLotterySaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A770 Offset: 0x31A871 VA: 0x31A770
	|-Array.InternalEnumerator<OrderSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A850 Offset: 0x31A951 VA: 0x31A850
	|-Array.InternalEnumerator<OrderSaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31A930 Offset: 0x31AA31 VA: 0x31A930
	|-Array.InternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31AA10 Offset: 0x31AB11 VA: 0x31AA10
	|-Array.InternalEnumerator<Parameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31AAF0 Offset: 0x31ABF1 VA: 0x31AAF0
	|-Array.InternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31ABD0 Offset: 0x31ACD1 VA: 0x31ABD0
	|-Array.InternalEnumerator<PlayerCallingNameTextData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31ACB0 Offset: 0x31ADB1 VA: 0x31ACB0
	|-Array.InternalEnumerator<ShopCatalogPage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31AD90 Offset: 0x31AE91 VA: 0x31AD90
	|-Array.InternalEnumerator<ShopNpcTalk>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31AE80 Offset: 0x31AF81 VA: 0x31AE80
	|-Array.InternalEnumerator<SubtitleDataTable.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31AF60 Offset: 0x31B061 VA: 0x31AF60
	|-Array.InternalEnumerator<SubtitleDataTable.DataList>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321A60 Offset: 0x321B61 VA: 0x321A60
	|-Array.InternalEnumerator<SubtitleHudDataTable.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321B40 Offset: 0x321C41 VA: 0x321B40
	|-Array.InternalEnumerator<AnimationWarping.Warp>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321C20 Offset: 0x321D21 VA: 0x321C20
	|-Array.InternalEnumerator<GrounderQuadruped.Foot>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321D00 Offset: 0x321E01 VA: 0x321D00
	|-Array.InternalEnumerator<IKSolverLimb.AxisDirection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321DE0 Offset: 0x321EE1 VA: 0x321DE0
	|-Array.InternalEnumerator<ProfilerFrame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321EC0 Offset: 0x321FC1 VA: 0x321EC0
	|-Array.InternalEnumerator<NumberControl.ValueRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x321FA0 Offset: 0x3220A1 VA: 0x321FA0
	|-Array.InternalEnumerator<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322080 Offset: 0x322181 VA: 0x322080
	|-Array.InternalEnumerator<ResponsiveEnable.Entry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322160 Offset: 0x322261 VA: 0x322160
	|-Array.InternalEnumerator<ResponsiveResize.Element.SizeDefinition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322240 Offset: 0x322341 VA: 0x322240
	|-Array.InternalEnumerator<ResponsiveResize.Element>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322320 Offset: 0x322421 VA: 0x322320
	|-Array.InternalEnumerator<Schedule>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322400 Offset: 0x322501 VA: 0x322400
	|-Array.InternalEnumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3224F0 Offset: 0x3225F1 VA: 0x3224F0
	|-Array.InternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3225D0 Offset: 0x3226D1 VA: 0x3225D0
	|-Array.InternalEnumerator<SpeedData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322730 Offset: 0x322831 VA: 0x322730
	|-Array.InternalEnumerator<CurveSample>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322810 Offset: 0x322911 VA: 0x322810
	|-Array.InternalEnumerator<StatusPageSetParameter.ElementParameterText>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322970 Offset: 0x322A71 VA: 0x322970
	|-Array.InternalEnumerator<StringFormatData.FormatData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322A50 Offset: 0x322B51 VA: 0x322A50
	|-Array.InternalEnumerator<ArraySegment<ProfilerFrame>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322B30 Offset: 0x322C31 VA: 0x322B30
	|-Array.InternalEnumerator<ArraySegment<byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322C10 Offset: 0x322D11 VA: 0x322C10
	|-Array.InternalEnumerator<ArraySegment<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322CF0 Offset: 0x322DF1 VA: 0x322CF0
	|-Array.InternalEnumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322DD0 Offset: 0x322ED1 VA: 0x322DD0
	|-Array.InternalEnumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x322F30 Offset: 0x323031 VA: 0x322F30
	|-Array.InternalEnumerator<ByteEnum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323090 Offset: 0x323191 VA: 0x323090
	|-Array.InternalEnumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3231F0 Offset: 0x3232F1 VA: 0x3231F0
	|-Array.InternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3232D0 Offset: 0x3233D1 VA: 0x3232D0
	|-Array.InternalEnumerator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3233B0 Offset: 0x3234B1 VA: 0x3233B0
	|-Array.InternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323490 Offset: 0x323591 VA: 0x323490
	|-Array.InternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323570 Offset: 0x323671 VA: 0x323570
	|-Array.InternalEnumerator<Dictionary.Entry<EventCheckId, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323650 Offset: 0x323751 VA: 0x323650
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323730 Offset: 0x323831 VA: 0x323730
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323810 Offset: 0x323911 VA: 0x323810
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3238F0 Offset: 0x3239F1 VA: 0x3238F0
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3239D0 Offset: 0x323AD1 VA: 0x3239D0
	|-Array.InternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323AB0 Offset: 0x323BB1 VA: 0x323AB0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323B90 Offset: 0x323C91 VA: 0x323B90
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323C70 Offset: 0x323D71 VA: 0x323C70
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323D50 Offset: 0x323E51 VA: 0x323D50
	|-Array.InternalEnumerator<Dictionary.Entry<Parameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323E30 Offset: 0x323F31 VA: 0x323E30
	|-Array.InternalEnumerator<Dictionary.Entry<bool, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323F10 Offset: 0x324011 VA: 0x323F10
	|-Array.InternalEnumerator<Dictionary.Entry<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x323FF0 Offset: 0x3240F1 VA: 0x323FF0
	|-Array.InternalEnumerator<Dictionary.Entry<char, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3240D0 Offset: 0x3241D1 VA: 0x3240D0
	|-Array.InternalEnumerator<Dictionary.Entry<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3241B0 Offset: 0x3242B1 VA: 0x3241B0
	|-Array.InternalEnumerator<Dictionary.Entry<double, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324290 Offset: 0x324391 VA: 0x324290
	|-Array.InternalEnumerator<Dictionary.Entry<Guid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324370 Offset: 0x324471 VA: 0x324370
	|-Array.InternalEnumerator<Dictionary.Entry<short, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324450 Offset: 0x324551 VA: 0x324450
	|-Array.InternalEnumerator<Dictionary.Entry<int, CropDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324530 Offset: 0x324631 VA: 0x324530
	|-Array.InternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324610 Offset: 0x324711 VA: 0x324610
	|-Array.InternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3246F0 Offset: 0x3247F1 VA: 0x3246F0
	|-Array.InternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3247D0 Offset: 0x3248D1 VA: 0x3247D0
	|-Array.InternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3248B0 Offset: 0x3249B1 VA: 0x3248B0
	|-Array.InternalEnumerator<Dictionary.Entry<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324990 Offset: 0x324A91 VA: 0x324990
	|-Array.InternalEnumerator<Dictionary.Entry<int, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324A70 Offset: 0x324B71 VA: 0x324A70
	|-Array.InternalEnumerator<Dictionary.Entry<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324B50 Offset: 0x324C51 VA: 0x324B50
	|-Array.InternalEnumerator<Dictionary.Entry<int, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324C30 Offset: 0x324D31 VA: 0x324C30
	|-Array.InternalEnumerator<Dictionary.Entry<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324D10 Offset: 0x324E11 VA: 0x324D10
	|-Array.InternalEnumerator<Dictionary.Entry<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324DF0 Offset: 0x324EF1 VA: 0x324DF0
	|-Array.InternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324ED0 Offset: 0x324FD1 VA: 0x324ED0
	|-Array.InternalEnumerator<Dictionary.Entry<int, SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x324FB0 Offset: 0x3250B1 VA: 0x324FB0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325090 Offset: 0x325191 VA: 0x325090
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325170 Offset: 0x325271 VA: 0x325170
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325250 Offset: 0x325351 VA: 0x325250
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325330 Offset: 0x325431 VA: 0x325330
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325410 Offset: 0x325511 VA: 0x325410
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3254F0 Offset: 0x3255F1 VA: 0x3254F0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3255D0 Offset: 0x3256D1 VA: 0x3255D0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3256B0 Offset: 0x3257B1 VA: 0x3256B0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325790 Offset: 0x325891 VA: 0x325790
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325870 Offset: 0x325971 VA: 0x325870
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325950 Offset: 0x325A51 VA: 0x325950
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325A30 Offset: 0x325B31 VA: 0x325A30
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325B10 Offset: 0x325C11 VA: 0x325B10
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325BF0 Offset: 0x325CF1 VA: 0x325BF0
	|-Array.InternalEnumerator<Dictionary.Entry<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325CD0 Offset: 0x325DD1 VA: 0x325CD0
	|-Array.InternalEnumerator<Dictionary.Entry<Memory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325DB0 Offset: 0x325EB1 VA: 0x325DB0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325E90 Offset: 0x325F91 VA: 0x325E90
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x325F70 Offset: 0x326071 VA: 0x325F70
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326050 Offset: 0x326151 VA: 0x326050
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326130 Offset: 0x326231 VA: 0x326130
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326210 Offset: 0x326311 VA: 0x326210
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3262F0 Offset: 0x3263F1 VA: 0x3262F0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3263D0 Offset: 0x3264D1 VA: 0x3263D0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3264B0 Offset: 0x3265B1 VA: 0x3264B0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326590 Offset: 0x326691 VA: 0x326590
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326670 Offset: 0x326771 VA: 0x326670
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326750 Offset: 0x326851 VA: 0x326750
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326830 Offset: 0x326931 VA: 0x326830
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326910 Offset: 0x326A11 VA: 0x326910
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3269F0 Offset: 0x326AF1 VA: 0x3269F0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326AD0 Offset: 0x326BD1 VA: 0x326AD0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326BB0 Offset: 0x326CB1 VA: 0x326BB0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326C90 Offset: 0x326D91 VA: 0x326C90
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326D70 Offset: 0x326E71 VA: 0x326D70
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326E50 Offset: 0x326F51 VA: 0x326E50
	|-Array.InternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x326F30 Offset: 0x327031 VA: 0x326F30
	|-Array.InternalEnumerator<Dictionary.Entry<object, EventCheckId>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327010 Offset: 0x327111 VA: 0x327010
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3270F0 Offset: 0x3271F1 VA: 0x3270F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3271D0 Offset: 0x3272D1 VA: 0x3271D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3272B0 Offset: 0x3273B1 VA: 0x3272B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327390 Offset: 0x327491 VA: 0x327390
	|-Array.InternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327470 Offset: 0x327571 VA: 0x327470
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327550 Offset: 0x327651 VA: 0x327550
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327630 Offset: 0x327731 VA: 0x327630
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327710 Offset: 0x327811 VA: 0x327710
	|-Array.InternalEnumerator<Dictionary.Entry<object, Parameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3277F0 Offset: 0x3278F1 VA: 0x3277F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3278D0 Offset: 0x3279D1 VA: 0x3278D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3497B0 Offset: 0x3498B1 VA: 0x3497B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349890 Offset: 0x349991 VA: 0x349890
	|-Array.InternalEnumerator<Dictionary.Entry<object, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349970 Offset: 0x349A71 VA: 0x349970
	|-Array.InternalEnumerator<Dictionary.Entry<object, DateTime>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349A50 Offset: 0x349B51 VA: 0x349A50
	|-Array.InternalEnumerator<Dictionary.Entry<object, double>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349B30 Offset: 0x349C31 VA: 0x349B30
	|-Array.InternalEnumerator<Dictionary.Entry<object, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349C10 Offset: 0x349D11 VA: 0x349C10
	|-Array.InternalEnumerator<Dictionary.Entry<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349CF0 Offset: 0x349DF1 VA: 0x349CF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349DD0 Offset: 0x349ED1 VA: 0x349DD0
	|-Array.InternalEnumerator<Dictionary.Entry<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349EB0 Offset: 0x349FB1 VA: 0x349EB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Memory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349F90 Offset: 0x34A091 VA: 0x349F90
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A070 Offset: 0x34A171 VA: 0x34A070
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A150 Offset: 0x34A251 VA: 0x34A150
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A230 Offset: 0x34A331 VA: 0x34A230
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A310 Offset: 0x34A411 VA: 0x34A310
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A3F0 Offset: 0x34A4F1 VA: 0x34A3F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A4D0 Offset: 0x34A5D1 VA: 0x34A4D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A5B0 Offset: 0x34A6B1 VA: 0x34A5B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A690 Offset: 0x34A791 VA: 0x34A690
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A770 Offset: 0x34A871 VA: 0x34A770
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A850 Offset: 0x34A951 VA: 0x34A850
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A930 Offset: 0x34AA31 VA: 0x34A930
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AA10 Offset: 0x34AB11 VA: 0x34AA10
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AAF0 Offset: 0x34ABF1 VA: 0x34AAF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34ABD0 Offset: 0x34ACD1 VA: 0x34ABD0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34ACB0 Offset: 0x34ADB1 VA: 0x34ACB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AD90 Offset: 0x34AE91 VA: 0x34AD90
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AE70 Offset: 0x34AF71 VA: 0x34AE70
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34AF50 Offset: 0x34B051 VA: 0x34AF50
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B030 Offset: 0x34B131 VA: 0x34B030
	|-Array.InternalEnumerator<Dictionary.Entry<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B110 Offset: 0x34B211 VA: 0x34B110
	|-Array.InternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B1F0 Offset: 0x34B2F1 VA: 0x34B1F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B2D0 Offset: 0x34B3D1 VA: 0x34B2D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, sbyte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B3B0 Offset: 0x34B4B1 VA: 0x34B3B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B490 Offset: 0x34B591 VA: 0x34B490
	|-Array.InternalEnumerator<Dictionary.Entry<object, ushort>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B570 Offset: 0x34B671 VA: 0x34B570
	|-Array.InternalEnumerator<Dictionary.Entry<object, uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B650 Offset: 0x34B751 VA: 0x34B650
	|-Array.InternalEnumerator<Dictionary.Entry<object, ulong>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B730 Offset: 0x34B831 VA: 0x34B730
	|-Array.InternalEnumerator<Dictionary.Entry<object, TransitionTables>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B810 Offset: 0x34B911 VA: 0x34B810
	|-Array.InternalEnumerator<Dictionary.Entry<object, Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B8F0 Offset: 0x34B9F1 VA: 0x34B8F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34B9D0 Offset: 0x34BAD1 VA: 0x34B9D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BAB0 Offset: 0x34BBB1 VA: 0x34BAB0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BB90 Offset: 0x34BC91 VA: 0x34BB90
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BC70 Offset: 0x34BD71 VA: 0x34BC70
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BD50 Offset: 0x34BE51 VA: 0x34BD50
	|-Array.InternalEnumerator<Dictionary.Entry<object, Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BE30 Offset: 0x34BF31 VA: 0x34BE30
	|-Array.InternalEnumerator<Dictionary.Entry<object, LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BF10 Offset: 0x34C011 VA: 0x34BF10
	|-Array.InternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34BFF0 Offset: 0x34C0F1 VA: 0x34BFF0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Playable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C0D0 Offset: 0x34C1D1 VA: 0x34C0D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C1B0 Offset: 0x34C2B1 VA: 0x34C1B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C290 Offset: 0x34C391 VA: 0x34C290
	|-Array.InternalEnumerator<Dictionary.Entry<object, Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C370 Offset: 0x34C471 VA: 0x34C370
	|-Array.InternalEnumerator<Dictionary.Entry<object, RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C450 Offset: 0x34C551 VA: 0x34C450
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C530 Offset: 0x34C631 VA: 0x34C530
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C610 Offset: 0x34C711 VA: 0x34C610
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C6F0 Offset: 0x34C7F1 VA: 0x34C6F0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C7D0 Offset: 0x34C8D1 VA: 0x34C7D0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C8B0 Offset: 0x34C9B1 VA: 0x34C8B0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34C990 Offset: 0x34CA91 VA: 0x34C990
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CA70 Offset: 0x34CB71 VA: 0x34CA70
	|-Array.InternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CB50 Offset: 0x34CC51 VA: 0x34CB50
	|-Array.InternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CC30 Offset: 0x34CD31 VA: 0x34CC30
	|-Array.InternalEnumerator<Dictionary.Entry<sbyte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CD10 Offset: 0x34CE11 VA: 0x34CD10
	|-Array.InternalEnumerator<Dictionary.Entry<float, CurveSample>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CDF0 Offset: 0x34CEF1 VA: 0x34CDF0
	|-Array.InternalEnumerator<Dictionary.Entry<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CED0 Offset: 0x34CFD1 VA: 0x34CED0
	|-Array.InternalEnumerator<Dictionary.Entry<ushort, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34CFB0 Offset: 0x34D0B1 VA: 0x34CFB0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D090 Offset: 0x34D191 VA: 0x34D090
	|-Array.InternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D170 Offset: 0x34D271 VA: 0x34D170
	|-Array.InternalEnumerator<Dictionary.Entry<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D250 Offset: 0x34D351 VA: 0x34D250
	|-Array.InternalEnumerator<Dictionary.Entry<ulong, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D330 Offset: 0x34D431 VA: 0x34D330
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D410 Offset: 0x34D511 VA: 0x34D410
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D4F0 Offset: 0x34D5F1 VA: 0x34D4F0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D5D0 Offset: 0x34D6D1 VA: 0x34D5D0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D6B0 Offset: 0x34D7B1 VA: 0x34D6B0
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D790 Offset: 0x34D891 VA: 0x34D790
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D870 Offset: 0x34D971 VA: 0x34D870
	|-Array.InternalEnumerator<Dictionary.Entry<Bounds, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34D950 Offset: 0x34DA51 VA: 0x34D950
	|-Array.InternalEnumerator<Dictionary.Entry<BoundsInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DA30 Offset: 0x34DB31 VA: 0x34DA30
	|-Array.InternalEnumerator<Dictionary.Entry<Color, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DB10 Offset: 0x34DC11 VA: 0x34DB10
	|-Array.InternalEnumerator<Dictionary.Entry<Color32, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DBF0 Offset: 0x34DCF1 VA: 0x34DBF0
	|-Array.InternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DCD0 Offset: 0x34DDD1 VA: 0x34DCD0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DDB0 Offset: 0x34DEB1 VA: 0x34DDB0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DE90 Offset: 0x34DF91 VA: 0x34DE90
	|-Array.InternalEnumerator<Dictionary.Entry<Keyframe, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34DF70 Offset: 0x34E071 VA: 0x34DF70
	|-Array.InternalEnumerator<Dictionary.Entry<LayerMask, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E050 Offset: 0x34E151 VA: 0x34E050
	|-Array.InternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E130 Offset: 0x34E231 VA: 0x34E130
	|-Array.InternalEnumerator<Dictionary.Entry<IntVec3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E210 Offset: 0x34E311 VA: 0x34E210
	|-Array.InternalEnumerator<Dictionary.Entry<Quaternion, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E2F0 Offset: 0x34E3F1 VA: 0x34E2F0
	|-Array.InternalEnumerator<Dictionary.Entry<RangeInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E3D0 Offset: 0x34E4D1 VA: 0x34E3D0
	|-Array.InternalEnumerator<Dictionary.Entry<Rect, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E4B0 Offset: 0x34E5B1 VA: 0x34E4B0
	|-Array.InternalEnumerator<Dictionary.Entry<RectInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E590 Offset: 0x34E691 VA: 0x34E590
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E670 Offset: 0x34E771 VA: 0x34E670
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E750 Offset: 0x34E851 VA: 0x34E750
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E830 Offset: 0x34E931 VA: 0x34E830
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E910 Offset: 0x34EA11 VA: 0x34E910
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34E9F0 Offset: 0x34EAF1 VA: 0x34E9F0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34EAD0 Offset: 0x34EBD1 VA: 0x34EAD0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34EBC0 Offset: 0x34ECC1 VA: 0x34EBC0
	|-Array.InternalEnumerator<HashSet.Slot<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34ECB0 Offset: 0x34EDB1 VA: 0x34ECB0
	|-Array.InternalEnumerator<HashSet.Slot<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34ED90 Offset: 0x34EE91 VA: 0x34ED90
	|-Array.InternalEnumerator<HashSet.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34EE80 Offset: 0x34EF81 VA: 0x34EE80
	|-Array.InternalEnumerator<HashSet.Slot<uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34EF60 Offset: 0x34F061 VA: 0x34EF60
	|-Array.InternalEnumerator<HashSet.Slot<Edge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F040 Offset: 0x34F141 VA: 0x34F040
	|-Array.InternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F120 Offset: 0x34F221 VA: 0x34F120
	|-Array.InternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F200 Offset: 0x34F301 VA: 0x34F200
	|-Array.InternalEnumerator<KeyValuePair<BitVector32Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F2E0 Offset: 0x34F3E1 VA: 0x34F2E0
	|-Array.InternalEnumerator<KeyValuePair<EventCheckId, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F3C0 Offset: 0x34F4C1 VA: 0x34F3C0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338E40 Offset: 0x338F41 VA: 0x338E40
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x338F20 Offset: 0x339021 VA: 0x338F20
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339000 Offset: 0x339101 VA: 0x339000
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3390E0 Offset: 0x3391E1 VA: 0x3390E0
	|-Array.InternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3391C0 Offset: 0x3392C1 VA: 0x3391C0
	|-Array.InternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3392A0 Offset: 0x3393A1 VA: 0x3392A0
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339380 Offset: 0x339481 VA: 0x339380
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339460 Offset: 0x339561 VA: 0x339460
	|-Array.InternalEnumerator<KeyValuePair<Parameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339540 Offset: 0x339641 VA: 0x339540
	|-Array.InternalEnumerator<KeyValuePair<bool, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339620 Offset: 0x339721 VA: 0x339620
	|-Array.InternalEnumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339700 Offset: 0x339801 VA: 0x339700
	|-Array.InternalEnumerator<KeyValuePair<char, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3397E0 Offset: 0x3398E1 VA: 0x3397E0
	|-Array.InternalEnumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3398C0 Offset: 0x3399C1 VA: 0x3398C0
	|-Array.InternalEnumerator<KeyValuePair<double, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3399A0 Offset: 0x339AA1 VA: 0x3399A0
	|-Array.InternalEnumerator<KeyValuePair<Guid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339A80 Offset: 0x339B81 VA: 0x339A80
	|-Array.InternalEnumerator<KeyValuePair<short, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339B60 Offset: 0x339C61 VA: 0x339B60
	|-Array.InternalEnumerator<KeyValuePair<int, CropDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339C40 Offset: 0x339D41 VA: 0x339C40
	|-Array.InternalEnumerator<KeyValuePair<int, EffectDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339D20 Offset: 0x339E21 VA: 0x339D20
	|-Array.InternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339E80 Offset: 0x339F81 VA: 0x339E80
	|-Array.InternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x339F60 Offset: 0x33A061 VA: 0x339F60
	|-Array.InternalEnumerator<KeyValuePair<int, MiningDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A040 Offset: 0x33A141 VA: 0x33A040
	|-Array.InternalEnumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A1A0 Offset: 0x33A2A1 VA: 0x33A1A0
	|-Array.InternalEnumerator<KeyValuePair<int, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A300 Offset: 0x33A401 VA: 0x33A300
	|-Array.InternalEnumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A460 Offset: 0x33A561 VA: 0x33A460
	|-Array.InternalEnumerator<KeyValuePair<int, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A5C0 Offset: 0x33A6C1 VA: 0x33A5C0
	|-Array.InternalEnumerator<KeyValuePair<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A6A0 Offset: 0x33A7A1 VA: 0x33A6A0
	|-Array.InternalEnumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A780 Offset: 0x33A881 VA: 0x33A780
	|-Array.InternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A860 Offset: 0x33A961 VA: 0x33A860
	|-Array.InternalEnumerator<KeyValuePair<int, SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33A950 Offset: 0x33AA51 VA: 0x33A950
	|-Array.InternalEnumerator<KeyValuePair<int, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33AA30 Offset: 0x33AB31 VA: 0x33AA30
	|-Array.InternalEnumerator<KeyValuePair<int, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33AB10 Offset: 0x33AC11 VA: 0x33AB10
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33ABF0 Offset: 0x33ACF1 VA: 0x33ABF0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33ACD0 Offset: 0x33ADD1 VA: 0x33ACD0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33ADB0 Offset: 0x33AEB1 VA: 0x33ADB0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33AF20 Offset: 0x33B021 VA: 0x33AF20
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B000 Offset: 0x33B101 VA: 0x33B000
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B160 Offset: 0x33B261 VA: 0x33B160
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B2C0 Offset: 0x33B3C1 VA: 0x33B2C0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B3A0 Offset: 0x33B4A1 VA: 0x33B3A0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B500 Offset: 0x33B601 VA: 0x33B500
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B5F0 Offset: 0x33B6F1 VA: 0x33B5F0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B6D0 Offset: 0x33B7D1 VA: 0x33B6D0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B7B0 Offset: 0x33B8B1 VA: 0x33B7B0
	|-Array.InternalEnumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B890 Offset: 0x33B991 VA: 0x33B890
	|-Array.InternalEnumerator<KeyValuePair<Memory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33B970 Offset: 0x33BA71 VA: 0x33B970
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BA50 Offset: 0x33BB51 VA: 0x33BA50
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BB30 Offset: 0x33BC31 VA: 0x33BB30
	|-Array.InternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BC10 Offset: 0x33BD11 VA: 0x33BC10
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BCF0 Offset: 0x33BDF1 VA: 0x33BCF0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BDD0 Offset: 0x33BED1 VA: 0x33BDD0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BEB0 Offset: 0x33BFB1 VA: 0x33BEB0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33BF90 Offset: 0x33C091 VA: 0x33BF90
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C070 Offset: 0x33C171 VA: 0x33C070
	|-Array.InternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C150 Offset: 0x33C251 VA: 0x33C150
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C230 Offset: 0x33C331 VA: 0x33C230
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C310 Offset: 0x33C411 VA: 0x33C310
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C3F0 Offset: 0x33C4F1 VA: 0x33C3F0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C4D0 Offset: 0x33C5D1 VA: 0x33C4D0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C5B0 Offset: 0x33C6B1 VA: 0x33C5B0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C690 Offset: 0x33C791 VA: 0x33C690
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C770 Offset: 0x33C871 VA: 0x33C770
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C850 Offset: 0x33C951 VA: 0x33C850
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33C930 Offset: 0x33CA31 VA: 0x33C930
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CA10 Offset: 0x33CB11 VA: 0x33CA10
	|-Array.InternalEnumerator<KeyValuePair<object, BitVector32Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CAF0 Offset: 0x33CBF1 VA: 0x33CAF0
	|-Array.InternalEnumerator<KeyValuePair<object, EventCheckId>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CBD0 Offset: 0x33CCD1 VA: 0x33CBD0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CCB0 Offset: 0x33CDB1 VA: 0x33CCB0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CD90 Offset: 0x33CE91 VA: 0x33CD90
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CE70 Offset: 0x33CF71 VA: 0x33CE70
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33CF50 Offset: 0x33D051 VA: 0x33CF50
	|-Array.InternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D030 Offset: 0x33D131 VA: 0x33D030
	|-Array.InternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D110 Offset: 0x33D211 VA: 0x33D110
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D1F0 Offset: 0x33D2F1 VA: 0x33D1F0
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D2D0 Offset: 0x33D3D1 VA: 0x33D2D0
	|-Array.InternalEnumerator<KeyValuePair<object, Parameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D3B0 Offset: 0x33D4B1 VA: 0x33D3B0
	|-Array.InternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D490 Offset: 0x33D591 VA: 0x33D490
	|-Array.InternalEnumerator<KeyValuePair<object, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D570 Offset: 0x33D671 VA: 0x33D570
	|-Array.InternalEnumerator<KeyValuePair<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D650 Offset: 0x33D751 VA: 0x33D650
	|-Array.InternalEnumerator<KeyValuePair<object, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D730 Offset: 0x33D831 VA: 0x33D730
	|-Array.InternalEnumerator<KeyValuePair<object, DateTime>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D810 Offset: 0x33D911 VA: 0x33D810
	|-Array.InternalEnumerator<KeyValuePair<object, double>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D8F0 Offset: 0x33D9F1 VA: 0x33D8F0
	|-Array.InternalEnumerator<KeyValuePair<object, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33D9D0 Offset: 0x33DAD1 VA: 0x33D9D0
	|-Array.InternalEnumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DAB0 Offset: 0x33DBB1 VA: 0x33DAB0
	|-Array.InternalEnumerator<KeyValuePair<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DB90 Offset: 0x33DC91 VA: 0x33DB90
	|-Array.InternalEnumerator<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DC70 Offset: 0x33DD71 VA: 0x33DC70
	|-Array.InternalEnumerator<KeyValuePair<object, Memory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DD50 Offset: 0x33DE51 VA: 0x33DD50
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DE30 Offset: 0x33DF31 VA: 0x33DE30
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DF10 Offset: 0x33E011 VA: 0x33DF10
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33DFF0 Offset: 0x33E0F1 VA: 0x33DFF0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E0D0 Offset: 0x33E1D1 VA: 0x33E0D0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E1B0 Offset: 0x33E2B1 VA: 0x33E1B0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E290 Offset: 0x33E391 VA: 0x33E290
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E370 Offset: 0x33E471 VA: 0x33E370
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E450 Offset: 0x33E551 VA: 0x33E450
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E530 Offset: 0x33E631 VA: 0x33E530
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E610 Offset: 0x33E711 VA: 0x33E610
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E6F0 Offset: 0x33E7F1 VA: 0x33E6F0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E7D0 Offset: 0x33E8D1 VA: 0x33E7D0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E8B0 Offset: 0x33E9B1 VA: 0x33E8B0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33E990 Offset: 0x33EA91 VA: 0x33E990
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33EA70 Offset: 0x33EB71 VA: 0x33EA70
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33EB50 Offset: 0x33EC51 VA: 0x33EB50
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33EC30 Offset: 0x33ED31 VA: 0x33EC30
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33ED10 Offset: 0x33EE11 VA: 0x33ED10
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x33EDF0 Offset: 0x33EEF1 VA: 0x33EDF0
	|-Array.InternalEnumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355560 Offset: 0x355661 VA: 0x355560
	|-Array.InternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355640 Offset: 0x355741 VA: 0x355640
	|-Array.InternalEnumerator<KeyValuePair<object, ResourceLocator>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355720 Offset: 0x355821 VA: 0x355720
	|-Array.InternalEnumerator<KeyValuePair<object, sbyte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355800 Offset: 0x355901 VA: 0x355800
	|-Array.InternalEnumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3558E0 Offset: 0x3559E1 VA: 0x3558E0
	|-Array.InternalEnumerator<KeyValuePair<object, ushort>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3559C0 Offset: 0x355AC1 VA: 0x3559C0
	|-Array.InternalEnumerator<KeyValuePair<object, uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355AA0 Offset: 0x355BA1 VA: 0x355AA0
	|-Array.InternalEnumerator<KeyValuePair<object, ulong>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355B80 Offset: 0x355C81 VA: 0x355B80
	|-Array.InternalEnumerator<KeyValuePair<object, TransitionTables>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355C60 Offset: 0x355D61 VA: 0x355C60
	|-Array.InternalEnumerator<KeyValuePair<object, Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355D40 Offset: 0x355E41 VA: 0x355D40
	|-Array.InternalEnumerator<KeyValuePair<object, BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355E20 Offset: 0x355F21 VA: 0x355E20
	|-Array.InternalEnumerator<KeyValuePair<object, Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355F00 Offset: 0x356001 VA: 0x355F00
	|-Array.InternalEnumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x355FE0 Offset: 0x3560E1 VA: 0x355FE0
	|-Array.InternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3560C0 Offset: 0x3561C1 VA: 0x3560C0
	|-Array.InternalEnumerator<KeyValuePair<object, GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3561A0 Offset: 0x3562A1 VA: 0x3561A0
	|-Array.InternalEnumerator<KeyValuePair<object, Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356280 Offset: 0x356381 VA: 0x356280
	|-Array.InternalEnumerator<KeyValuePair<object, LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356360 Offset: 0x356461 VA: 0x356360
	|-Array.InternalEnumerator<KeyValuePair<object, Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356440 Offset: 0x356541 VA: 0x356440
	|-Array.InternalEnumerator<KeyValuePair<object, Playable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356520 Offset: 0x356621 VA: 0x356520
	|-Array.InternalEnumerator<KeyValuePair<object, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356600 Offset: 0x356701 VA: 0x356600
	|-Array.InternalEnumerator<KeyValuePair<object, RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3566E0 Offset: 0x3567E1 VA: 0x3566E0
	|-Array.InternalEnumerator<KeyValuePair<object, Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3567C0 Offset: 0x3568C1 VA: 0x3567C0
	|-Array.InternalEnumerator<KeyValuePair<object, RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3568A0 Offset: 0x3569A1 VA: 0x3568A0
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356980 Offset: 0x356A81 VA: 0x356980
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356A60 Offset: 0x356B61 VA: 0x356A60
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356B40 Offset: 0x356C41 VA: 0x356B40
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356C20 Offset: 0x356D21 VA: 0x356C20
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356D00 Offset: 0x356E01 VA: 0x356D00
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356DE0 Offset: 0x356EE1 VA: 0x356DE0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356EC0 Offset: 0x356FC1 VA: 0x356EC0
	|-Array.InternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x356FA0 Offset: 0x3570A1 VA: 0x356FA0
	|-Array.InternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357080 Offset: 0x357181 VA: 0x357080
	|-Array.InternalEnumerator<KeyValuePair<sbyte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357160 Offset: 0x357261 VA: 0x357160
	|-Array.InternalEnumerator<KeyValuePair<float, CurveSample>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357240 Offset: 0x357341 VA: 0x357240
	|-Array.InternalEnumerator<KeyValuePair<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357320 Offset: 0x357421 VA: 0x357320
	|-Array.InternalEnumerator<KeyValuePair<ushort, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357400 Offset: 0x357501 VA: 0x357400
	|-Array.InternalEnumerator<KeyValuePair<uint, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357560 Offset: 0x357661 VA: 0x357560
	|-Array.InternalEnumerator<KeyValuePair<uint, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3576C0 Offset: 0x3577C1 VA: 0x3576C0
	|-Array.InternalEnumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3577A0 Offset: 0x3578A1 VA: 0x3577A0
	|-Array.InternalEnumerator<KeyValuePair<ulong, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357890 Offset: 0x357991 VA: 0x357890
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357970 Offset: 0x357A71 VA: 0x357970
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357A50 Offset: 0x357B51 VA: 0x357A50
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357B30 Offset: 0x357C31 VA: 0x357B30
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357C20 Offset: 0x357D21 VA: 0x357C20
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357D00 Offset: 0x357E01 VA: 0x357D00
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357DE0 Offset: 0x357EE1 VA: 0x357DE0
	|-Array.InternalEnumerator<KeyValuePair<Bounds, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357EC0 Offset: 0x357FC1 VA: 0x357EC0
	|-Array.InternalEnumerator<KeyValuePair<BoundsInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x357FA0 Offset: 0x3580A1 VA: 0x357FA0
	|-Array.InternalEnumerator<KeyValuePair<Color, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358080 Offset: 0x358181 VA: 0x358080
	|-Array.InternalEnumerator<KeyValuePair<Color32, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358160 Offset: 0x358261 VA: 0x358160
	|-Array.InternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358240 Offset: 0x358341 VA: 0x358240
	|-Array.InternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358320 Offset: 0x358421 VA: 0x358320
	|-Array.InternalEnumerator<KeyValuePair<GradientColorKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358400 Offset: 0x358501 VA: 0x358400
	|-Array.InternalEnumerator<KeyValuePair<Keyframe, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3584E0 Offset: 0x3585E1 VA: 0x3584E0
	|-Array.InternalEnumerator<KeyValuePair<LayerMask, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3585C0 Offset: 0x3586C1 VA: 0x3585C0
	|-Array.InternalEnumerator<KeyValuePair<Matrix4x4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3586A0 Offset: 0x3587A1 VA: 0x3586A0
	|-Array.InternalEnumerator<KeyValuePair<IntVec3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358780 Offset: 0x358881 VA: 0x358780
	|-Array.InternalEnumerator<KeyValuePair<Quaternion, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358860 Offset: 0x358961 VA: 0x358860
	|-Array.InternalEnumerator<KeyValuePair<RangeInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358940 Offset: 0x358A41 VA: 0x358940
	|-Array.InternalEnumerator<KeyValuePair<Rect, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358A20 Offset: 0x358B21 VA: 0x358A20
	|-Array.InternalEnumerator<KeyValuePair<RectInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358B10 Offset: 0x358C11 VA: 0x358B10
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358BF0 Offset: 0x358CF1 VA: 0x358BF0
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358CD0 Offset: 0x358DD1 VA: 0x358CD0
	|-Array.InternalEnumerator<KeyValuePair<Vector2, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358DB0 Offset: 0x358EB1 VA: 0x358DB0
	|-Array.InternalEnumerator<KeyValuePair<Vector2Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358E90 Offset: 0x358F91 VA: 0x358E90
	|-Array.InternalEnumerator<KeyValuePair<Vector3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x358F70 Offset: 0x359071 VA: 0x358F70
	|-Array.InternalEnumerator<KeyValuePair<Vector3Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359050 Offset: 0x359151 VA: 0x359050
	|-Array.InternalEnumerator<KeyValuePair<Vector4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359130 Offset: 0x359231 VA: 0x359130
	|-Array.InternalEnumerator<Hashtable.bucket>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359210 Offset: 0x359311 VA: 0x359210
	|-Array.InternalEnumerator<DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359370 Offset: 0x359471 VA: 0x359370
	|-Array.InternalEnumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359450 Offset: 0x359551 VA: 0x359450
	|-Array.InternalEnumerator<Decimal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359530 Offset: 0x359631 VA: 0x359530
	|-Array.InternalEnumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359690 Offset: 0x359791 VA: 0x359690
	|-Array.InternalEnumerator<InternalCodePageDataItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359770 Offset: 0x359871 VA: 0x359770
	|-Array.InternalEnumerator<InternalEncodingDataItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359850 Offset: 0x359951 VA: 0x359850
	|-Array.InternalEnumerator<Guid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359930 Offset: 0x359A31 VA: 0x359930
	|-Array.InternalEnumerator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359A90 Offset: 0x359B91 VA: 0x359A90
	|-Array.InternalEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359BF0 Offset: 0x359CF1 VA: 0x359BF0
	|-Array.InternalEnumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359D50 Offset: 0x359E51 VA: 0x359D50
	|-Array.InternalEnumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x359EB0 Offset: 0x359FB1 VA: 0x359EB0
	|-Array.InternalEnumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A010 Offset: 0x35A111 VA: 0x35A010
	|-Array.InternalEnumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A0F0 Offset: 0x35A1F1 VA: 0x35A0F0
	|-Array.InternalEnumerator<LocalDefinition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A1E0 Offset: 0x35A2E1 VA: 0x35A1E0
	|-Array.InternalEnumerator<RuntimeLabel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A2D0 Offset: 0x35A3D1 VA: 0x35A2D0
	|-Array.InternalEnumerator<Set.Slot<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A3B0 Offset: 0x35A4B1 VA: 0x35A3B0
	|-Array.InternalEnumerator<Set.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A490 Offset: 0x35A591 VA: 0x35A490
	|-Array.InternalEnumerator<Memory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A570 Offset: 0x35A671 VA: 0x35A570
	|-Array.InternalEnumerator<CookieTokenizer.RecognizedAttribute>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A650 Offset: 0x35A751 VA: 0x35A650
	|-Array.InternalEnumerator<HeaderVariantInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A730 Offset: 0x35A831 VA: 0x35A730
	|-Array.InternalEnumerator<Socket.WSABUF>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A810 Offset: 0x35A911 VA: 0x35A810
	|-Array.InternalEnumerator<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35A8F0 Offset: 0x35A9F1 VA: 0x35A8F0
	|-Array.InternalEnumerator<Nullable<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35AA50 Offset: 0x35AB51 VA: 0x35AA50
	|-Array.InternalEnumerator<Nullable<Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35AB30 Offset: 0x35AC31 VA: 0x35AB30
	|-Array.InternalEnumerator<Nullable<BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35AC10 Offset: 0x35AD11 VA: 0x35AC10
	|-Array.InternalEnumerator<Nullable<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35AD70 Offset: 0x35AE71 VA: 0x35AD70
	|-Array.InternalEnumerator<Nullable<Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35AE60 Offset: 0x35AF61 VA: 0x35AE60
	|-Array.InternalEnumerator<Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35AF40 Offset: 0x35B041 VA: 0x35AF40
	|-Array.InternalEnumerator<Nullable<GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B020 Offset: 0x35B121 VA: 0x35B020
	|-Array.InternalEnumerator<Nullable<Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B100 Offset: 0x35B201 VA: 0x35B100
	|-Array.InternalEnumerator<Nullable<LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B260 Offset: 0x35B361 VA: 0x35B260
	|-Array.InternalEnumerator<Nullable<Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B340 Offset: 0x35B441 VA: 0x35B340
	|-Array.InternalEnumerator<Nullable<Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B430 Offset: 0x35B531 VA: 0x35B430
	|-Array.InternalEnumerator<Nullable<RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B510 Offset: 0x35B611 VA: 0x35B510
	|-Array.InternalEnumerator<Nullable<Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B5F0 Offset: 0x35B6F1 VA: 0x35B5F0
	|-Array.InternalEnumerator<Nullable<RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B6E0 Offset: 0x35B7E1 VA: 0x35B6E0
	|-Array.InternalEnumerator<Nullable<Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B7D0 Offset: 0x35B8D1 VA: 0x35B7D0
	|-Array.InternalEnumerator<Nullable<Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35B8B0 Offset: 0x35B9B1 VA: 0x35B8B0
	|-Array.InternalEnumerator<Nullable<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342A90 Offset: 0x342B91 VA: 0x342A90
	|-Array.InternalEnumerator<Nullable<Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342B70 Offset: 0x342C71 VA: 0x342B70
	|-Array.InternalEnumerator<Nullable<Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342C50 Offset: 0x342D51 VA: 0x342C50
	|-Array.InternalEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342D60 Offset: 0x342E61 VA: 0x342D60
	|-Array.InternalEnumerator<ParameterizedStrings.FormatParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342E40 Offset: 0x342F41 VA: 0x342E40
	|-Array.InternalEnumerator<ReadOnlyMemory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x342F20 Offset: 0x343021 VA: 0x342F20
	|-Array.InternalEnumerator<CustomAttributeNamedArgument>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343000 Offset: 0x343101 VA: 0x343000
	|-Array.InternalEnumerator<CustomAttributeTypedArgument>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3430F0 Offset: 0x3431F1 VA: 0x3430F0
	|-Array.InternalEnumerator<Label>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343250 Offset: 0x343351 VA: 0x343250
	|-Array.InternalEnumerator<ParameterModifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3433B0 Offset: 0x3434B1 VA: 0x3433B0
	|-Array.InternalEnumerator<ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343490 Offset: 0x343591 VA: 0x343490
	|-Array.InternalEnumerator<Ephemeron>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343580 Offset: 0x343681 VA: 0x343580
	|-Array.InternalEnumerator<GCHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3436E0 Offset: 0x3437E1 VA: 0x3436E0
	|-Array.InternalEnumerator<RuntimeTypeHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343840 Offset: 0x343941 VA: 0x343840
	|-Array.InternalEnumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3439A0 Offset: 0x343AA1 VA: 0x3439A0
	|-Array.InternalEnumerator<X509ChainStatus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343A80 Offset: 0x343B81 VA: 0x343A80
	|-Array.InternalEnumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343BF0 Offset: 0x343CF1 VA: 0x343BF0
	|-Array.InternalEnumerator<RegexCharClass.LowerCaseMapping>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343CD0 Offset: 0x343DD1 VA: 0x343CD0
	|-Array.InternalEnumerator<CancellationTokenRegistration>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343DB0 Offset: 0x343EB1 VA: 0x343DB0
	|-Array.InternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x343F10 Offset: 0x344011 VA: 0x343F10
	|-Array.InternalEnumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344070 Offset: 0x344171 VA: 0x344070
	|-Array.InternalEnumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3441D0 Offset: 0x3442D1 VA: 0x3441D0
	|-Array.InternalEnumerator<UInt16Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344330 Offset: 0x344431 VA: 0x344330
	|-Array.InternalEnumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344490 Offset: 0x344591 VA: 0x344490
	|-Array.InternalEnumerator<UInt32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3445F0 Offset: 0x3446F1 VA: 0x3445F0
	|-Array.InternalEnumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344750 Offset: 0x344851 VA: 0x344750
	|-Array.InternalEnumerator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3448B0 Offset: 0x3449B1 VA: 0x3448B0
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344A10 Offset: 0x344B11 VA: 0x344A10
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344AF0 Offset: 0x344BF1 VA: 0x344AF0
	|-Array.InternalEnumerator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344BD0 Offset: 0x344CD1 VA: 0x344BD0
	|-Array.InternalEnumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344CB0 Offset: 0x344DB1 VA: 0x344CB0
	|-Array.InternalEnumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344D90 Offset: 0x344E91 VA: 0x344D90
	|-Array.InternalEnumerator<ValueTuple<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344E70 Offset: 0x344F71 VA: 0x344E70
	|-Array.InternalEnumerator<ValueTuple<float, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x344F50 Offset: 0x345051 VA: 0x344F50
	|-Array.InternalEnumerator<ValueTuple<Vector3, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345040 Offset: 0x345141 VA: 0x345040
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345120 Offset: 0x345221 VA: 0x345120
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345200 Offset: 0x345301 VA: 0x345200
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3452E0 Offset: 0x3453E1 VA: 0x3452E0
	|-Array.InternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3453C0 Offset: 0x3454C1 VA: 0x3453C0
	|-Array.InternalEnumerator<HighlightState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3454A0 Offset: 0x3455A1 VA: 0x3454A0
	|-Array.InternalEnumerator<MaterialReference>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345580 Offset: 0x345681 VA: 0x345580
	|-Array.InternalEnumerator<RichTextTagAttribute>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345660 Offset: 0x345761 VA: 0x345660
	|-Array.InternalEnumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345740 Offset: 0x345841 VA: 0x345740
	|-Array.InternalEnumerator<TMP_CharacterInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345820 Offset: 0x345921 VA: 0x345820
	|-Array.InternalEnumerator<TMP_FontWeightPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345900 Offset: 0x345A01 VA: 0x345900
	|-Array.InternalEnumerator<TMP_LineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3459E0 Offset: 0x345AE1 VA: 0x3459E0
	|-Array.InternalEnumerator<TMP_LinkInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345AC0 Offset: 0x345BC1 VA: 0x345AC0
	|-Array.InternalEnumerator<TMP_MeshInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345BA0 Offset: 0x345CA1 VA: 0x345BA0
	|-Array.InternalEnumerator<TMP_PageInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345C90 Offset: 0x345D91 VA: 0x345C90
	|-Array.InternalEnumerator<TMP_Text.UnicodeChar>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345D70 Offset: 0x345E71 VA: 0x345D70
	|-Array.InternalEnumerator<TMP_TextProcessingStack<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345E50 Offset: 0x345F51 VA: 0x345E50
	|-Array.InternalEnumerator<TMP_WordInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x345F30 Offset: 0x346031 VA: 0x345F30
	|-Array.InternalEnumerator<WordWrapState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346010 Offset: 0x346111 VA: 0x346010
	|-Array.InternalEnumerator<TextPaneDatas.TextPaneData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3460F0 Offset: 0x3461F1 VA: 0x3460F0
	|-Array.InternalEnumerator<TransitionTables>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3461E0 Offset: 0x3462E1 VA: 0x3461E0
	|-Array.InternalEnumerator<TutorialUnlockFlagData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3462C0 Offset: 0x3463C1 VA: 0x3462C0
	|-Array.InternalEnumerator<UICheckOnBackRune.LinkSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3463A0 Offset: 0x3464A1 VA: 0x3463A0
	|-Array.InternalEnumerator<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346480 Offset: 0x346581 VA: 0x346480
	|-Array.InternalEnumerator<CapEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346560 Offset: 0x346661 VA: 0x346560
	|-Array.InternalEnumerator<ClippedEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346640 Offset: 0x346741 VA: 0x346640
	|-Array.InternalEnumerator<EdgeKeyByHash>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3467A0 Offset: 0x3468A1 VA: 0x3467A0
	|-Array.InternalEnumerator<EdgeKeyByIndex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346900 Offset: 0x346A01 VA: 0x346900
	|-Array.InternalEnumerator<MeshDataConnectivity.Face>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346A60 Offset: 0x346B61 VA: 0x346A60
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346B40 Offset: 0x346C41 VA: 0x346B40
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346C20 Offset: 0x346D21 VA: 0x346C20
	|-Array.InternalEnumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346D00 Offset: 0x346E01 VA: 0x346D00
	|-Array.InternalEnumerator<NavMeshBuildSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346DE0 Offset: 0x346EE1 VA: 0x346DE0
	|-Array.InternalEnumerator<ContentCatalogData.Bucket>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346EC0 Offset: 0x346FC1 VA: 0x346EC0
	|-Array.InternalEnumerator<ConstraintSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x346FA0 Offset: 0x3470A1 VA: 0x346FA0
	|-Array.InternalEnumerator<PropertySceneHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347110 Offset: 0x347211 VA: 0x347110
	|-Array.InternalEnumerator<TransformStreamHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3471F0 Offset: 0x3472F1 VA: 0x3471F0
	|-Array.InternalEnumerator<AnimatorClipInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347350 Offset: 0x347451 VA: 0x347350
	|-Array.InternalEnumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347430 Offset: 0x347531 VA: 0x347430
	|-Array.InternalEnumerator<BoneWeight1>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347590 Offset: 0x347691 VA: 0x347590
	|-Array.InternalEnumerator<BoneWeight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347670 Offset: 0x347771 VA: 0x347670
	|-Array.InternalEnumerator<BoundingSphere>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347750 Offset: 0x347851 VA: 0x347750
	|-Array.InternalEnumerator<Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347830 Offset: 0x347931 VA: 0x347830
	|-Array.InternalEnumerator<BoundsInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347910 Offset: 0x347A11 VA: 0x347910
	|-Array.InternalEnumerator<CharacterInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347A00 Offset: 0x347B01 VA: 0x347A00
	|-Array.InternalEnumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347B60 Offset: 0x347C61 VA: 0x347B60
	|-Array.InternalEnumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347C40 Offset: 0x347D41 VA: 0x347C40
	|-Array.InternalEnumerator<CombineInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347D20 Offset: 0x347E21 VA: 0x347D20
	|-Array.InternalEnumerator<ContactPoint2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347E00 Offset: 0x347F01 VA: 0x347E00
	|-Array.InternalEnumerator<ContactPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347EE0 Offset: 0x347FE1 VA: 0x347EE0
	|-Array.InternalEnumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x347FC0 Offset: 0x3480C1 VA: 0x347FC0
	|-Array.InternalEnumerator<LightDataGI>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3480A0 Offset: 0x3481A1 VA: 0x3480A0
	|-Array.InternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348200 Offset: 0x348301 VA: 0x348200
	|-Array.InternalEnumerator<GradientAlphaKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3482E0 Offset: 0x3483E1 VA: 0x3482E0
	|-Array.InternalEnumerator<GradientColorKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3483C0 Offset: 0x3484C1 VA: 0x3483C0
	|-Array.InternalEnumerator<HumanBone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3484A0 Offset: 0x3485A1 VA: 0x3484A0
	|-Array.InternalEnumerator<Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348580 Offset: 0x348681 VA: 0x348580
	|-Array.InternalEnumerator<LOD>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348670 Offset: 0x348771 VA: 0x348670
	|-Array.InternalEnumerator<LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3487D0 Offset: 0x3488D1 VA: 0x3487D0
	|-Array.InternalEnumerator<PlayerLoopSystem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3488B0 Offset: 0x3489B1 VA: 0x3488B0
	|-Array.InternalEnumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348990 Offset: 0x348A91 VA: 0x348990
	|-Array.InternalEnumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348A70 Offset: 0x348B71 VA: 0x348A70
	|-Array.InternalEnumerator<PatchExtents>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348B50 Offset: 0x348C51 VA: 0x348B50
	|-Array.InternalEnumerator<Plane>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348C30 Offset: 0x348D31 VA: 0x348C30
	|-Array.InternalEnumerator<Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348D10 Offset: 0x348E11 VA: 0x348D10
	|-Array.InternalEnumerator<PlayableBinding>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348DF0 Offset: 0x348EF1 VA: 0x348DF0
	|-Array.InternalEnumerator<PlayableGraph>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x348ED0 Offset: 0x348FD1 VA: 0x348ED0
	|-Array.InternalEnumerator<Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349030 Offset: 0x349131 VA: 0x349030
	|-Array.InternalEnumerator<IntVec3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349110 Offset: 0x349211 VA: 0x349110
	|-Array.InternalEnumerator<Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3491F0 Offset: 0x3492F1 VA: 0x3491F0
	|-Array.InternalEnumerator<RangeInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349350 Offset: 0x349451 VA: 0x349350
	|-Array.InternalEnumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349430 Offset: 0x349531 VA: 0x349430
	|-Array.InternalEnumerator<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x349510 Offset: 0x349611 VA: 0x349510
	|-Array.InternalEnumerator<Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3495F0 Offset: 0x3496F1 VA: 0x3495F0
	|-Array.InternalEnumerator<RectInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3496D0 Offset: 0x3497D1 VA: 0x3496D0
	|-Array.InternalEnumerator<RenderBuffer>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327DD0 Offset: 0x327ED1 VA: 0x327DD0
	|-Array.InternalEnumerator<BatchVisibility>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327EB0 Offset: 0x327FB1 VA: 0x327EB0
	|-Array.InternalEnumerator<ReflectionProbeBlendInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x327F90 Offset: 0x328091 VA: 0x327F90
	|-Array.InternalEnumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328070 Offset: 0x328171 VA: 0x328070
	|-Array.InternalEnumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328150 Offset: 0x328251 VA: 0x328150
	|-Array.InternalEnumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328230 Offset: 0x328331 VA: 0x328230
	|-Array.InternalEnumerator<AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328310 Offset: 0x328411 VA: 0x328310
	|-Array.InternalEnumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3283F0 Offset: 0x3284F1 VA: 0x3283F0
	|-Array.InternalEnumerator<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3284D0 Offset: 0x3285D1 VA: 0x3284D0
	|-Array.InternalEnumerator<SceneInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3285B0 Offset: 0x3286B1 VA: 0x3285B0
	|-Array.InternalEnumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328690 Offset: 0x328791 VA: 0x328690
	|-Array.InternalEnumerator<ObjectInitializationData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328770 Offset: 0x328871 VA: 0x328770
	|-Array.InternalEnumerator<SerializedType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328850 Offset: 0x328951 VA: 0x328850
	|-Array.InternalEnumerator<SendMouseEvents.HitInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328930 Offset: 0x328A31 VA: 0x328930
	|-Array.InternalEnumerator<SkeletonBone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328A10 Offset: 0x328B11 VA: 0x328A10
	|-Array.InternalEnumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328AF0 Offset: 0x328BF1 VA: 0x328AF0
	|-Array.InternalEnumerator<GlyphMarshallingStruct>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328BD0 Offset: 0x328CD1 VA: 0x328BD0
	|-Array.InternalEnumerator<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328CB0 Offset: 0x328DB1 VA: 0x328CB0
	|-Array.InternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328D90 Offset: 0x328E91 VA: 0x328D90
	|-Array.InternalEnumerator<IntervalTreeNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328E70 Offset: 0x328F71 VA: 0x328E70
	|-Array.InternalEnumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x328F50 Offset: 0x329051 VA: 0x328F50
	|-Array.InternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329030 Offset: 0x329131 VA: 0x329030
	|-Array.InternalEnumerator<Touch>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329110 Offset: 0x329211 VA: 0x329110
	|-Array.InternalEnumerator<TreeInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3291F0 Offset: 0x3292F1 VA: 0x3291F0
	|-Array.InternalEnumerator<ColorBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3292D0 Offset: 0x3293D1 VA: 0x3292D0
	|-Array.InternalEnumerator<Navigation>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3293B0 Offset: 0x3294B1 VA: 0x3293B0
	|-Array.InternalEnumerator<SpriteState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329490 Offset: 0x329591 VA: 0x329490
	|-Array.InternalEnumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329570 Offset: 0x329671 VA: 0x329570
	|-Array.InternalEnumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329650 Offset: 0x329751 VA: 0x329650
	|-Array.InternalEnumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329730 Offset: 0x329831 VA: 0x329730
	|-Array.InternalEnumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329810 Offset: 0x329911 VA: 0x329810
	|-Array.InternalEnumerator<StyleSheetCache.SheetHandleKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329970 Offset: 0x329A71 VA: 0x329970
	|-Array.InternalEnumerator<StyleValue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329A50 Offset: 0x329B51 VA: 0x329A50
	|-Array.InternalEnumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329B30 Offset: 0x329C31 VA: 0x329B30
	|-Array.InternalEnumerator<UIVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329C10 Offset: 0x329D11 VA: 0x329C10
	|-Array.InternalEnumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329CF0 Offset: 0x329DF1 VA: 0x329CF0
	|-Array.InternalEnumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329DD0 Offset: 0x329ED1 VA: 0x329DD0
	|-Array.InternalEnumerator<Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x329F30 Offset: 0x32A031 VA: 0x329F30
	|-Array.InternalEnumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A020 Offset: 0x32A121 VA: 0x32A020
	|-Array.InternalEnumerator<Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A100 Offset: 0x32A201 VA: 0x32A100
	|-Array.InternalEnumerator<Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A1E0 Offset: 0x32A2E1 VA: 0x32A1E0
	|-Array.InternalEnumerator<jvalue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A340 Offset: 0x32A441 VA: 0x32A340
	|-Array.InternalEnumerator<WarpPoints.WarpPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A420 Offset: 0x32A521 VA: 0x32A420
	|-Array.InternalEnumerator<YieldItemParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A580 Offset: 0x32A681 VA: 0x32A580
	|-Array.InternalEnumerator<NetworkServiceAccountId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A6E0 Offset: 0x32A7E1 VA: 0x32A6E0
	|-Array.InternalEnumerator<Uid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A7C0 Offset: 0x32A8C1 VA: 0x32A7C0
	|-Array.InternalEnumerator<ConsumableServiceItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32A920 Offset: 0x32AA21 VA: 0x32A920
	|-Array.InternalEnumerator<NsUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32AA80 Offset: 0x32AB81 VA: 0x32AA80
	|-Array.InternalEnumerator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32AB60 Offset: 0x32AC61 VA: 0x32AB60
	|-Array.InternalEnumerator<Profile>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32AC40 Offset: 0x32AD41 VA: 0x32AC40
	|-Array.InternalEnumerator<DirectoryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32AD20 Offset: 0x32AE21 VA: 0x32AD20
	|-Array.InternalEnumerator<DebugPadState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32AE00 Offset: 0x32AF01 VA: 0x32AE00
	|-Array.InternalEnumerator<GesturePoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32AF60 Offset: 0x32B061 VA: 0x32AF60
	|-Array.InternalEnumerator<GestureState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B040 Offset: 0x32B141 VA: 0x32B040
	|-Array.InternalEnumerator<NpadFullKeyState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B120 Offset: 0x32B221 VA: 0x32B120
	|-Array.InternalEnumerator<NpadHandheldState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B200 Offset: 0x32B301 VA: 0x32B200
	|-Array.InternalEnumerator<NpadJoyDualState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B2E0 Offset: 0x32B3E1 VA: 0x32B2E0
	|-Array.InternalEnumerator<NpadJoyLeftState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B3C0 Offset: 0x32B4C1 VA: 0x32B3C0
	|-Array.InternalEnumerator<NpadJoyRightState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B4A0 Offset: 0x32B5A1 VA: 0x32B4A0
	|-Array.InternalEnumerator<NpadStateArrayItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B590 Offset: 0x32B691 VA: 0x32B590
	|-Array.InternalEnumerator<SixAxisSensorHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B6F0 Offset: 0x32B7F1 VA: 0x32B6F0
	|-Array.InternalEnumerator<SixAxisSensorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B7D0 Offset: 0x32B8D1 VA: 0x32B7D0
	|-Array.InternalEnumerator<TouchScreenState10>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B8B0 Offset: 0x32B9B1 VA: 0x32B8B0
	|-Array.InternalEnumerator<TouchScreenState11>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32B990 Offset: 0x32BA91 VA: 0x32B990
	|-Array.InternalEnumerator<TouchScreenState12>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BA70 Offset: 0x32BB71 VA: 0x32BA70
	|-Array.InternalEnumerator<TouchScreenState13>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BB50 Offset: 0x32BC51 VA: 0x32BB50
	|-Array.InternalEnumerator<TouchScreenState14>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BC30 Offset: 0x32BD31 VA: 0x32BC30
	|-Array.InternalEnumerator<TouchScreenState15>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BD10 Offset: 0x32BE11 VA: 0x32BD10
	|-Array.InternalEnumerator<TouchScreenState16>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BDF0 Offset: 0x32BEF1 VA: 0x32BDF0
	|-Array.InternalEnumerator<TouchScreenState1>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BED0 Offset: 0x32BFD1 VA: 0x32BED0
	|-Array.InternalEnumerator<TouchScreenState2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32BFB0 Offset: 0x32C0B1 VA: 0x32BFB0
	|-Array.InternalEnumerator<TouchScreenState3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C090 Offset: 0x32C191 VA: 0x32C090
	|-Array.InternalEnumerator<TouchScreenState4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C170 Offset: 0x32C271 VA: 0x32C170
	|-Array.InternalEnumerator<TouchScreenState5>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C250 Offset: 0x32C351 VA: 0x32C250
	|-Array.InternalEnumerator<TouchScreenState6>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C330 Offset: 0x32C431 VA: 0x32C330
	|-Array.InternalEnumerator<TouchScreenState7>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C410 Offset: 0x32C511 VA: 0x32C410
	|-Array.InternalEnumerator<TouchScreenState8>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C4F0 Offset: 0x32C5F1 VA: 0x32C4F0
	|-Array.InternalEnumerator<TouchScreenState9>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C5D0 Offset: 0x32C6D1 VA: 0x32C5D0
	|-Array.InternalEnumerator<TouchState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C6C0 Offset: 0x32C7C1 VA: 0x32C6C0
	|-Array.InternalEnumerator<VibrationDeviceHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C820 Offset: 0x32C921 VA: 0x32C820
	|-Array.InternalEnumerator<VibrationDeviceInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32C980 Offset: 0x32CA81 VA: 0x32C980
	|-Array.InternalEnumerator<VibrationValue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CA60 Offset: 0x32CB61 VA: 0x32CA60
	|-Array.InternalEnumerator<ClusteringData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CB40 Offset: 0x32CC41 VA: 0x32CB40
	|-Array.InternalEnumerator<ClusteringProcessorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CC20 Offset: 0x32CD21 VA: 0x32CC20
	|-Array.InternalEnumerator<Finger>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CD00 Offset: 0x32CE01 VA: 0x32CD00
	|-Array.InternalEnumerator<Hand>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CDE0 Offset: 0x32CEE1 VA: 0x32CDE0
	|-Array.InternalEnumerator<HandAnalysisImageState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CEC0 Offset: 0x32CFC1 VA: 0x32CEC0
	|-Array.InternalEnumerator<HandAnalysisSilhouetteState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32CFA0 Offset: 0x32D0A1 VA: 0x32CFA0
	|-Array.InternalEnumerator<MomentProcessorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D080 Offset: 0x32D181 VA: 0x32D080
	|-Array.InternalEnumerator<MomentStatistic>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D160 Offset: 0x32D261 VA: 0x32D160
	|-Array.InternalEnumerator<Protrusion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D2C0 Offset: 0x32D3C1 VA: 0x32D2C0
	|-Array.InternalEnumerator<Shape>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D3A0 Offset: 0x32D4A1 VA: 0x32D3A0
	|-Array.InternalEnumerator<DictionaryInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D500 Offset: 0x32D601 VA: 0x32D500
	|-Array.InternalEnumerator<UserWord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D5F0 Offset: 0x32D6F1 VA: 0x32D5F0
	|-Array.InternalEnumerator<Color4u8>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D750 Offset: 0x32D851 VA: 0x32D750
	|-Array.InternalEnumerator<Float2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x32D830 Offset: 0x32D931 VA: 0x32D830
	|-Array.InternalEnumerator<stCommand_t>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C80 Offset: 0x315D81 VA: 0x315C80
	|-Array.InternalEnumerator<AS_ToolController.ChargeInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x315D60 Offset: 0x315E61 VA: 0x315D60
	|-Array.InternalEnumerator<ActionCommandDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x315E40 Offset: 0x315F41 VA: 0x315E40
	|-Array.InternalEnumerator<AdvScriptDefCountParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x315F20 Offset: 0x316021 VA: 0x315F20
	|-Array.InternalEnumerator<JSONDeserialization.TaskField>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316010 Offset: 0x316111 VA: 0x316010
	|-Array.InternalEnumerator<BitVector32Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316170 Offset: 0x316271 VA: 0x316170
	|-Array.InternalEnumerator<BuildItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316250 Offset: 0x316351 VA: 0x316250
	|-Array.InternalEnumerator<ButtonLinker.LinkObject>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316330 Offset: 0x316431 VA: 0x316330
	|-Array.InternalEnumerator<CharaCallTable.BustupTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316420 Offset: 0x316521 VA: 0x316420
	|-Array.InternalEnumerator<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316500 Offset: 0x316601 VA: 0x316500
	|-Array.InternalEnumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3165E0 Offset: 0x3166E1 VA: 0x3165E0
	|-Array.InternalEnumerator<CinemachineBlendListCamera.Instruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3166C0 Offset: 0x3167C1 VA: 0x3166C0
	|-Array.InternalEnumerator<CinemachineBlenderSettings.CustomBlend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3167A0 Offset: 0x3168A1 VA: 0x3167A0
	|-Array.InternalEnumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316900 Offset: 0x316A01 VA: 0x316900
	|-Array.InternalEnumerator<CinemachineFreeLook.Orbit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3169E0 Offset: 0x316AE1 VA: 0x3169E0
	|-Array.InternalEnumerator<CinemachinePath.Waypoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316AC0 Offset: 0x316BC1 VA: 0x316AC0
	|-Array.InternalEnumerator<CinemachineSmoothPath.Waypoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316BA0 Offset: 0x316CA1 VA: 0x316BA0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316D00 Offset: 0x316E01 VA: 0x316D00
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.Instruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316DE0 Offset: 0x316EE1 VA: 0x316DE0
	|-Array.InternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x316F40 Offset: 0x317041 VA: 0x316F40
	|-Array.InternalEnumerator<CinemachineTargetGroup.Target>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317020 Offset: 0x317121 VA: 0x317020
	|-Array.InternalEnumerator<NoiseSettings.TransformNoiseParams>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317100 Offset: 0x317201 VA: 0x317100
	|-Array.InternalEnumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3171E0 Offset: 0x3172E1 VA: 0x3171E0
	|-Array.InternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3172C0 Offset: 0x3173C1 VA: 0x3172C0
	|-Array.InternalEnumerator<HeadingTracker.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3173A0 Offset: 0x3174A1 VA: 0x3173A0
	|-Array.InternalEnumerator<CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317480 Offset: 0x317581 VA: 0x317480
	|-Array.InternalEnumerator<ControlPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317560 Offset: 0x317661 VA: 0x317560
	|-Array.InternalEnumerator<DamageTextInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317640 Offset: 0x317741 VA: 0x317640
	|-Array.InternalEnumerator<UIEMDefine.CategoryDataSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317720 Offset: 0x317821 VA: 0x317720
	|-Array.InternalEnumerator<DropItemParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317880 Offset: 0x317981 VA: 0x317880
	|-Array.InternalEnumerator<DropTableElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317960 Offset: 0x317A61 VA: 0x317960
	|-Array.InternalEnumerator<EffectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317A40 Offset: 0x317B41 VA: 0x317A40
	|-Array.InternalEnumerator<EnemyPatrolPoints>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317BA0 Offset: 0x317CA1 VA: 0x317BA0
	|-Array.InternalEnumerator<Coord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317D00 Offset: 0x317E01 VA: 0x317D00
	|-Array.InternalEnumerator<ErosionBrush.UndoStep>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317DE0 Offset: 0x317EE1 VA: 0x317DE0
	|-Array.InternalEnumerator<EventCheckId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317EC0 Offset: 0x317FC1 VA: 0x317EC0
	|-Array.InternalEnumerator<EventFlagProgressData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x317FA0 Offset: 0x3180A1 VA: 0x317FA0
	|-Array.InternalEnumerator<EyeMouthAnimate.EMAnimSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318100 Offset: 0x318201 VA: 0x318100
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_PARAM>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3181E0 Offset: 0x3182E1 VA: 0x3181E0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3182C0 Offset: 0x3183C1 VA: 0x3182C0
	|-Array.InternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3183B0 Offset: 0x3184B1 VA: 0x3183B0
	|-Array.InternalEnumerator<FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318490 Offset: 0x318591 VA: 0x318490
	|-Array.InternalEnumerator<FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318570 Offset: 0x318671 VA: 0x318570
	|-Array.InternalEnumerator<FesNpcScoreData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318650 Offset: 0x318751 VA: 0x318650
	|-Array.InternalEnumerator<FieldHideItemSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318730 Offset: 0x318831 VA: 0x318730
	|-Array.InternalEnumerator<FieldItemSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318810 Offset: 0x318911 VA: 0x318810
	|-Array.InternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3188F0 Offset: 0x3189F1 VA: 0x3188F0
	|-Array.InternalEnumerator<FieldSceneData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3189E0 Offset: 0x318AE1 VA: 0x3189E0
	|-Array.InternalEnumerator<FieldTreasureBoxItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318B40 Offset: 0x318C41 VA: 0x318B40
	|-Array.InternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318C20 Offset: 0x318D21 VA: 0x318C20
	|-Array.InternalEnumerator<FieldWoodBoxSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318D00 Offset: 0x318E01 VA: 0x318D00
	|-Array.InternalEnumerator<FocusObjectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318DE0 Offset: 0x318EE1 VA: 0x318DE0
	|-Array.InternalEnumerator<FurnitureData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318EC0 Offset: 0x318FC1 VA: 0x318EC0
	|-Array.InternalEnumerator<GateDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x318FA0 Offset: 0x3190A1 VA: 0x318FA0
	|-Array.InternalEnumerator<GateStatusDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319090 Offset: 0x319191 VA: 0x319090
	|-Array.InternalEnumerator<GimmickLayoutDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3191F0 Offset: 0x3192F1 VA: 0x3191F0
	|-Array.InternalEnumerator<HitResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3192D0 Offset: 0x3193D1 VA: 0x3192D0
	|-Array.InternalEnumerator<ImagePaneDatas.ImagePaneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3193B0 Offset: 0x3194B1 VA: 0x3193B0
	|-Array.InternalEnumerator<FurnitureManager.SendPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319490 Offset: 0x319591 VA: 0x319490
	|-Array.InternalEnumerator<ItemLevelData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3195F0 Offset: 0x3196F1 VA: 0x3195F0
	|-Array.InternalEnumerator<MapDatas.MapData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3196D0 Offset: 0x3197D1 VA: 0x3196D0
	|-Array.InternalEnumerator<MapObjectDatas.MapObjectData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3197B0 Offset: 0x3198B1 VA: 0x3197B0
	|-Array.InternalEnumerator<ByteArrayStringHashTable.Entry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319890 Offset: 0x319991 VA: 0x319890
	|-Array.InternalEnumerator<MineTypeDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319970 Offset: 0x319A71 VA: 0x319970
	|-Array.InternalEnumerator<MiningDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319A50 Offset: 0x319B51 VA: 0x319A50
	|-Array.InternalEnumerator<MiningPointSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319B30 Offset: 0x319C31 VA: 0x319B30
	|-Array.InternalEnumerator<CodePointIndexer.TableRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319C10 Offset: 0x319D11 VA: 0x319C10
	|-Array.InternalEnumerator<MonsterBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319CF0 Offset: 0x319DF1 VA: 0x319CF0
	|-Array.InternalEnumerator<MonsterDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319DD0 Offset: 0x319ED1 VA: 0x319DD0
	|-Array.InternalEnumerator<MonsterDropItemDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319EB0 Offset: 0x319FB1 VA: 0x319EB0
	|-Array.InternalEnumerator<MonsterFootStepEventDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x319F90 Offset: 0x31A091 VA: 0x319F90
	|-Array.InternalEnumerator<MonsterHutSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A070 Offset: 0x31A171 VA: 0x31A070
	|-Array.InternalEnumerator<MonsterUIData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A150 Offset: 0x31A251 VA: 0x31A150
	|-Array.InternalEnumerator<MonsterYieldItemDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A230 Offset: 0x31A331 VA: 0x31A230
	|-Array.InternalEnumerator<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A310 Offset: 0x31A411 VA: 0x31A310
	|-Array.InternalEnumerator<NPCActionData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A3F0 Offset: 0x31A4F1 VA: 0x31A3F0
	|-Array.InternalEnumerator<NPCCallingNameTextData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A4D0 Offset: 0x31A5D1 VA: 0x31A4D0
	|-Array.InternalEnumerator<NPCUIData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A5B0 Offset: 0x31A6B1 VA: 0x31A5B0
	|-Array.InternalEnumerator<NpcPlaceSchedule>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A6A0 Offset: 0x31A7A1 VA: 0x31A6A0
	|-Array.InternalEnumerator<OrderLotterySaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A780 Offset: 0x31A881 VA: 0x31A780
	|-Array.InternalEnumerator<OrderSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A860 Offset: 0x31A961 VA: 0x31A860
	|-Array.InternalEnumerator<OrderSaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31A940 Offset: 0x31AA41 VA: 0x31A940
	|-Array.InternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31AA20 Offset: 0x31AB21 VA: 0x31AA20
	|-Array.InternalEnumerator<Parameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31AB00 Offset: 0x31AC01 VA: 0x31AB00
	|-Array.InternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31ABE0 Offset: 0x31ACE1 VA: 0x31ABE0
	|-Array.InternalEnumerator<PlayerCallingNameTextData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31ACC0 Offset: 0x31ADC1 VA: 0x31ACC0
	|-Array.InternalEnumerator<ShopCatalogPage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31ADA0 Offset: 0x31AEA1 VA: 0x31ADA0
	|-Array.InternalEnumerator<ShopNpcTalk>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31AE90 Offset: 0x31AF91 VA: 0x31AE90
	|-Array.InternalEnumerator<SubtitleDataTable.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31AF70 Offset: 0x31B071 VA: 0x31AF70
	|-Array.InternalEnumerator<SubtitleDataTable.DataList>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321A70 Offset: 0x321B71 VA: 0x321A70
	|-Array.InternalEnumerator<SubtitleHudDataTable.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321B50 Offset: 0x321C51 VA: 0x321B50
	|-Array.InternalEnumerator<AnimationWarping.Warp>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321C30 Offset: 0x321D31 VA: 0x321C30
	|-Array.InternalEnumerator<GrounderQuadruped.Foot>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321D10 Offset: 0x321E11 VA: 0x321D10
	|-Array.InternalEnumerator<IKSolverLimb.AxisDirection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321DF0 Offset: 0x321EF1 VA: 0x321DF0
	|-Array.InternalEnumerator<ProfilerFrame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321ED0 Offset: 0x321FD1 VA: 0x321ED0
	|-Array.InternalEnumerator<NumberControl.ValueRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x321FB0 Offset: 0x3220B1 VA: 0x321FB0
	|-Array.InternalEnumerator<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322090 Offset: 0x322191 VA: 0x322090
	|-Array.InternalEnumerator<ResponsiveEnable.Entry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322170 Offset: 0x322271 VA: 0x322170
	|-Array.InternalEnumerator<ResponsiveResize.Element.SizeDefinition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322250 Offset: 0x322351 VA: 0x322250
	|-Array.InternalEnumerator<ResponsiveResize.Element>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322330 Offset: 0x322431 VA: 0x322330
	|-Array.InternalEnumerator<Schedule>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322410 Offset: 0x322511 VA: 0x322410
	|-Array.InternalEnumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322500 Offset: 0x322601 VA: 0x322500
	|-Array.InternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3225E0 Offset: 0x3226E1 VA: 0x3225E0
	|-Array.InternalEnumerator<SpeedData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322740 Offset: 0x322841 VA: 0x322740
	|-Array.InternalEnumerator<CurveSample>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322820 Offset: 0x322921 VA: 0x322820
	|-Array.InternalEnumerator<StatusPageSetParameter.ElementParameterText>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322980 Offset: 0x322A81 VA: 0x322980
	|-Array.InternalEnumerator<StringFormatData.FormatData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322A60 Offset: 0x322B61 VA: 0x322A60
	|-Array.InternalEnumerator<ArraySegment<ProfilerFrame>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322B40 Offset: 0x322C41 VA: 0x322B40
	|-Array.InternalEnumerator<ArraySegment<byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322C20 Offset: 0x322D21 VA: 0x322C20
	|-Array.InternalEnumerator<ArraySegment<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322D00 Offset: 0x322E01 VA: 0x322D00
	|-Array.InternalEnumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322DE0 Offset: 0x322EE1 VA: 0x322DE0
	|-Array.InternalEnumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x322F40 Offset: 0x323041 VA: 0x322F40
	|-Array.InternalEnumerator<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3230A0 Offset: 0x3231A1 VA: 0x3230A0
	|-Array.InternalEnumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323200 Offset: 0x323301 VA: 0x323200
	|-Array.InternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3232E0 Offset: 0x3233E1 VA: 0x3232E0
	|-Array.InternalEnumerator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3233C0 Offset: 0x3234C1 VA: 0x3233C0
	|-Array.InternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3234A0 Offset: 0x3235A1 VA: 0x3234A0
	|-Array.InternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323580 Offset: 0x323681 VA: 0x323580
	|-Array.InternalEnumerator<Dictionary.Entry<EventCheckId, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323660 Offset: 0x323761 VA: 0x323660
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323740 Offset: 0x323841 VA: 0x323740
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323820 Offset: 0x323921 VA: 0x323820
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323900 Offset: 0x323A01 VA: 0x323900
	|-Array.InternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3239E0 Offset: 0x323AE1 VA: 0x3239E0
	|-Array.InternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323AC0 Offset: 0x323BC1 VA: 0x323AC0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323BA0 Offset: 0x323CA1 VA: 0x323BA0
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323C80 Offset: 0x323D81 VA: 0x323C80
	|-Array.InternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323D60 Offset: 0x323E61 VA: 0x323D60
	|-Array.InternalEnumerator<Dictionary.Entry<Parameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323E40 Offset: 0x323F41 VA: 0x323E40
	|-Array.InternalEnumerator<Dictionary.Entry<bool, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x323F20 Offset: 0x324021 VA: 0x323F20
	|-Array.InternalEnumerator<Dictionary.Entry<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324000 Offset: 0x324101 VA: 0x324000
	|-Array.InternalEnumerator<Dictionary.Entry<char, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3240E0 Offset: 0x3241E1 VA: 0x3240E0
	|-Array.InternalEnumerator<Dictionary.Entry<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3241C0 Offset: 0x3242C1 VA: 0x3241C0
	|-Array.InternalEnumerator<Dictionary.Entry<double, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3242A0 Offset: 0x3243A1 VA: 0x3242A0
	|-Array.InternalEnumerator<Dictionary.Entry<Guid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324380 Offset: 0x324481 VA: 0x324380
	|-Array.InternalEnumerator<Dictionary.Entry<short, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324460 Offset: 0x324561 VA: 0x324460
	|-Array.InternalEnumerator<Dictionary.Entry<int, CropDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324540 Offset: 0x324641 VA: 0x324540
	|-Array.InternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324620 Offset: 0x324721 VA: 0x324620
	|-Array.InternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324700 Offset: 0x324801 VA: 0x324700
	|-Array.InternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3247E0 Offset: 0x3248E1 VA: 0x3247E0
	|-Array.InternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3248C0 Offset: 0x3249C1 VA: 0x3248C0
	|-Array.InternalEnumerator<Dictionary.Entry<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3249A0 Offset: 0x324AA1 VA: 0x3249A0
	|-Array.InternalEnumerator<Dictionary.Entry<int, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324A80 Offset: 0x324B81 VA: 0x324A80
	|-Array.InternalEnumerator<Dictionary.Entry<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324B60 Offset: 0x324C61 VA: 0x324B60
	|-Array.InternalEnumerator<Dictionary.Entry<int, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324C40 Offset: 0x324D41 VA: 0x324C40
	|-Array.InternalEnumerator<Dictionary.Entry<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324D20 Offset: 0x324E21 VA: 0x324D20
	|-Array.InternalEnumerator<Dictionary.Entry<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324E00 Offset: 0x324F01 VA: 0x324E00
	|-Array.InternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324EE0 Offset: 0x324FE1 VA: 0x324EE0
	|-Array.InternalEnumerator<Dictionary.Entry<int, SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x324FC0 Offset: 0x3250C1 VA: 0x324FC0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3250A0 Offset: 0x3251A1 VA: 0x3250A0
	|-Array.InternalEnumerator<Dictionary.Entry<int, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325180 Offset: 0x325281 VA: 0x325180
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325260 Offset: 0x325361 VA: 0x325260
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325340 Offset: 0x325441 VA: 0x325340
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325420 Offset: 0x325521 VA: 0x325420
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325500 Offset: 0x325601 VA: 0x325500
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3255E0 Offset: 0x3256E1 VA: 0x3255E0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3256C0 Offset: 0x3257C1 VA: 0x3256C0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3257A0 Offset: 0x3258A1 VA: 0x3257A0
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325880 Offset: 0x325981 VA: 0x325880
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325960 Offset: 0x325A61 VA: 0x325960
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325A40 Offset: 0x325B41 VA: 0x325A40
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325B20 Offset: 0x325C21 VA: 0x325B20
	|-Array.InternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325C00 Offset: 0x325D01 VA: 0x325C00
	|-Array.InternalEnumerator<Dictionary.Entry<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325CE0 Offset: 0x325DE1 VA: 0x325CE0
	|-Array.InternalEnumerator<Dictionary.Entry<Memory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325DC0 Offset: 0x325EC1 VA: 0x325DC0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325EA0 Offset: 0x325FA1 VA: 0x325EA0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x325F80 Offset: 0x326081 VA: 0x325F80
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326060 Offset: 0x326161 VA: 0x326060
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326140 Offset: 0x326241 VA: 0x326140
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326220 Offset: 0x326321 VA: 0x326220
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326300 Offset: 0x326401 VA: 0x326300
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3263E0 Offset: 0x3264E1 VA: 0x3263E0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3264C0 Offset: 0x3265C1 VA: 0x3264C0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3265A0 Offset: 0x3266A1 VA: 0x3265A0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326680 Offset: 0x326781 VA: 0x326680
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326760 Offset: 0x326861 VA: 0x326760
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326840 Offset: 0x326941 VA: 0x326840
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326920 Offset: 0x326A21 VA: 0x326920
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326A00 Offset: 0x326B01 VA: 0x326A00
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326AE0 Offset: 0x326BE1 VA: 0x326AE0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326BC0 Offset: 0x326CC1 VA: 0x326BC0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326CA0 Offset: 0x326DA1 VA: 0x326CA0
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326D80 Offset: 0x326E81 VA: 0x326D80
	|-Array.InternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326E60 Offset: 0x326F61 VA: 0x326E60
	|-Array.InternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x326F40 Offset: 0x327041 VA: 0x326F40
	|-Array.InternalEnumerator<Dictionary.Entry<object, EventCheckId>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327020 Offset: 0x327121 VA: 0x327020
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327100 Offset: 0x327201 VA: 0x327100
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3271E0 Offset: 0x3272E1 VA: 0x3271E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3272C0 Offset: 0x3273C1 VA: 0x3272C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3273A0 Offset: 0x3274A1 VA: 0x3273A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327480 Offset: 0x327581 VA: 0x327480
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327560 Offset: 0x327661 VA: 0x327560
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327640 Offset: 0x327741 VA: 0x327640
	|-Array.InternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327720 Offset: 0x327821 VA: 0x327720
	|-Array.InternalEnumerator<Dictionary.Entry<object, Parameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327800 Offset: 0x327901 VA: 0x327800
	|-Array.InternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3278E0 Offset: 0x3279E1 VA: 0x3278E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3497C0 Offset: 0x3498C1 VA: 0x3497C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3498A0 Offset: 0x3499A1 VA: 0x3498A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349980 Offset: 0x349A81 VA: 0x349980
	|-Array.InternalEnumerator<Dictionary.Entry<object, DateTime>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349A60 Offset: 0x349B61 VA: 0x349A60
	|-Array.InternalEnumerator<Dictionary.Entry<object, double>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349B40 Offset: 0x349C41 VA: 0x349B40
	|-Array.InternalEnumerator<Dictionary.Entry<object, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349C20 Offset: 0x349D21 VA: 0x349C20
	|-Array.InternalEnumerator<Dictionary.Entry<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349D00 Offset: 0x349E01 VA: 0x349D00
	|-Array.InternalEnumerator<Dictionary.Entry<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349DE0 Offset: 0x349EE1 VA: 0x349DE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349EC0 Offset: 0x349FC1 VA: 0x349EC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Memory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349FA0 Offset: 0x34A0A1 VA: 0x349FA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A080 Offset: 0x34A181 VA: 0x34A080
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A160 Offset: 0x34A261 VA: 0x34A160
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A240 Offset: 0x34A341 VA: 0x34A240
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A320 Offset: 0x34A421 VA: 0x34A320
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A400 Offset: 0x34A501 VA: 0x34A400
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A4E0 Offset: 0x34A5E1 VA: 0x34A4E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A5C0 Offset: 0x34A6C1 VA: 0x34A5C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A6A0 Offset: 0x34A7A1 VA: 0x34A6A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A780 Offset: 0x34A881 VA: 0x34A780
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A860 Offset: 0x34A961 VA: 0x34A860
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A940 Offset: 0x34AA41 VA: 0x34A940
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AA20 Offset: 0x34AB21 VA: 0x34AA20
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AB00 Offset: 0x34AC01 VA: 0x34AB00
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34ABE0 Offset: 0x34ACE1 VA: 0x34ABE0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34ACC0 Offset: 0x34ADC1 VA: 0x34ACC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34ADA0 Offset: 0x34AEA1 VA: 0x34ADA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AE80 Offset: 0x34AF81 VA: 0x34AE80
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34AF60 Offset: 0x34B061 VA: 0x34AF60
	|-Array.InternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B040 Offset: 0x34B141 VA: 0x34B040
	|-Array.InternalEnumerator<Dictionary.Entry<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B120 Offset: 0x34B221 VA: 0x34B120
	|-Array.InternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B200 Offset: 0x34B301 VA: 0x34B200
	|-Array.InternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B2E0 Offset: 0x34B3E1 VA: 0x34B2E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, sbyte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B3C0 Offset: 0x34B4C1 VA: 0x34B3C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B4A0 Offset: 0x34B5A1 VA: 0x34B4A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, ushort>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B580 Offset: 0x34B681 VA: 0x34B580
	|-Array.InternalEnumerator<Dictionary.Entry<object, uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B660 Offset: 0x34B761 VA: 0x34B660
	|-Array.InternalEnumerator<Dictionary.Entry<object, ulong>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B740 Offset: 0x34B841 VA: 0x34B740
	|-Array.InternalEnumerator<Dictionary.Entry<object, TransitionTables>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B820 Offset: 0x34B921 VA: 0x34B820
	|-Array.InternalEnumerator<Dictionary.Entry<object, Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B900 Offset: 0x34BA01 VA: 0x34B900
	|-Array.InternalEnumerator<Dictionary.Entry<object, BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34B9E0 Offset: 0x34BAE1 VA: 0x34B9E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34BAC0 Offset: 0x34BBC1 VA: 0x34BAC0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34BBA0 Offset: 0x34BCA1 VA: 0x34BBA0
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34BC80 Offset: 0x34BD81 VA: 0x34BC80
	|-Array.InternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34BD60 Offset: 0x34BE61 VA: 0x34BD60
	|-Array.InternalEnumerator<Dictionary.Entry<object, Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34BE40 Offset: 0x34BF41 VA: 0x34BE40
	|-Array.InternalEnumerator<Dictionary.Entry<object, LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34BF20 Offset: 0x34C021 VA: 0x34BF20
	|-Array.InternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C000 Offset: 0x34C101 VA: 0x34C000
	|-Array.InternalEnumerator<Dictionary.Entry<object, Playable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C0E0 Offset: 0x34C1E1 VA: 0x34C0E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C1C0 Offset: 0x34C2C1 VA: 0x34C1C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C2A0 Offset: 0x34C3A1 VA: 0x34C2A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C380 Offset: 0x34C481 VA: 0x34C380
	|-Array.InternalEnumerator<Dictionary.Entry<object, RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C460 Offset: 0x34C561 VA: 0x34C460
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C540 Offset: 0x34C641 VA: 0x34C540
	|-Array.InternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C620 Offset: 0x34C721 VA: 0x34C620
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C700 Offset: 0x34C801 VA: 0x34C700
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C7E0 Offset: 0x34C8E1 VA: 0x34C7E0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C8C0 Offset: 0x34C9C1 VA: 0x34C8C0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34C9A0 Offset: 0x34CAA1 VA: 0x34C9A0
	|-Array.InternalEnumerator<Dictionary.Entry<object, Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CA80 Offset: 0x34CB81 VA: 0x34CA80
	|-Array.InternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CB60 Offset: 0x34CC61 VA: 0x34CB60
	|-Array.InternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CC40 Offset: 0x34CD41 VA: 0x34CC40
	|-Array.InternalEnumerator<Dictionary.Entry<sbyte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CD20 Offset: 0x34CE21 VA: 0x34CD20
	|-Array.InternalEnumerator<Dictionary.Entry<float, CurveSample>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CE00 Offset: 0x34CF01 VA: 0x34CE00
	|-Array.InternalEnumerator<Dictionary.Entry<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CEE0 Offset: 0x34CFE1 VA: 0x34CEE0
	|-Array.InternalEnumerator<Dictionary.Entry<ushort, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34CFC0 Offset: 0x34D0C1 VA: 0x34CFC0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D0A0 Offset: 0x34D1A1 VA: 0x34D0A0
	|-Array.InternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D180 Offset: 0x34D281 VA: 0x34D180
	|-Array.InternalEnumerator<Dictionary.Entry<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D260 Offset: 0x34D361 VA: 0x34D260
	|-Array.InternalEnumerator<Dictionary.Entry<ulong, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D340 Offset: 0x34D441 VA: 0x34D340
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D420 Offset: 0x34D521 VA: 0x34D420
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D500 Offset: 0x34D601 VA: 0x34D500
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D5E0 Offset: 0x34D6E1 VA: 0x34D5E0
	|-Array.InternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D6C0 Offset: 0x34D7C1 VA: 0x34D6C0
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D7A0 Offset: 0x34D8A1 VA: 0x34D7A0
	|-Array.InternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D880 Offset: 0x34D981 VA: 0x34D880
	|-Array.InternalEnumerator<Dictionary.Entry<Bounds, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34D960 Offset: 0x34DA61 VA: 0x34D960
	|-Array.InternalEnumerator<Dictionary.Entry<BoundsInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DA40 Offset: 0x34DB41 VA: 0x34DA40
	|-Array.InternalEnumerator<Dictionary.Entry<Color, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DB20 Offset: 0x34DC21 VA: 0x34DB20
	|-Array.InternalEnumerator<Dictionary.Entry<Color32, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DC00 Offset: 0x34DD01 VA: 0x34DC00
	|-Array.InternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DCE0 Offset: 0x34DDE1 VA: 0x34DCE0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DDC0 Offset: 0x34DEC1 VA: 0x34DDC0
	|-Array.InternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DEA0 Offset: 0x34DFA1 VA: 0x34DEA0
	|-Array.InternalEnumerator<Dictionary.Entry<Keyframe, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34DF80 Offset: 0x34E081 VA: 0x34DF80
	|-Array.InternalEnumerator<Dictionary.Entry<LayerMask, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E060 Offset: 0x34E161 VA: 0x34E060
	|-Array.InternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E140 Offset: 0x34E241 VA: 0x34E140
	|-Array.InternalEnumerator<Dictionary.Entry<IntVec3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E220 Offset: 0x34E321 VA: 0x34E220
	|-Array.InternalEnumerator<Dictionary.Entry<Quaternion, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E300 Offset: 0x34E401 VA: 0x34E300
	|-Array.InternalEnumerator<Dictionary.Entry<RangeInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E3E0 Offset: 0x34E4E1 VA: 0x34E3E0
	|-Array.InternalEnumerator<Dictionary.Entry<Rect, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E4C0 Offset: 0x34E5C1 VA: 0x34E4C0
	|-Array.InternalEnumerator<Dictionary.Entry<RectInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E5A0 Offset: 0x34E6A1 VA: 0x34E5A0
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E680 Offset: 0x34E781 VA: 0x34E680
	|-Array.InternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E760 Offset: 0x34E861 VA: 0x34E760
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E840 Offset: 0x34E941 VA: 0x34E840
	|-Array.InternalEnumerator<Dictionary.Entry<Vector2Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34E920 Offset: 0x34EA21 VA: 0x34E920
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34EA00 Offset: 0x34EB01 VA: 0x34EA00
	|-Array.InternalEnumerator<Dictionary.Entry<Vector3Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34EAE0 Offset: 0x34EBE1 VA: 0x34EAE0
	|-Array.InternalEnumerator<Dictionary.Entry<Vector4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34EBD0 Offset: 0x34ECD1 VA: 0x34EBD0
	|-Array.InternalEnumerator<HashSet.Slot<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34ECC0 Offset: 0x34EDC1 VA: 0x34ECC0
	|-Array.InternalEnumerator<HashSet.Slot<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34EDA0 Offset: 0x34EEA1 VA: 0x34EDA0
	|-Array.InternalEnumerator<HashSet.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34EE90 Offset: 0x34EF91 VA: 0x34EE90
	|-Array.InternalEnumerator<HashSet.Slot<uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34EF70 Offset: 0x34F071 VA: 0x34EF70
	|-Array.InternalEnumerator<HashSet.Slot<Edge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F050 Offset: 0x34F151 VA: 0x34F050
	|-Array.InternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F130 Offset: 0x34F231 VA: 0x34F130
	|-Array.InternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F210 Offset: 0x34F311 VA: 0x34F210
	|-Array.InternalEnumerator<KeyValuePair<BitVector32Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F2F0 Offset: 0x34F3F1 VA: 0x34F2F0
	|-Array.InternalEnumerator<KeyValuePair<EventCheckId, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F3D0 Offset: 0x34F4D1 VA: 0x34F3D0
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338E50 Offset: 0x338F51 VA: 0x338E50
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x338F30 Offset: 0x339031 VA: 0x338F30
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339010 Offset: 0x339111 VA: 0x339010
	|-Array.InternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3390F0 Offset: 0x3391F1 VA: 0x3390F0
	|-Array.InternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3391D0 Offset: 0x3392D1 VA: 0x3391D0
	|-Array.InternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3392B0 Offset: 0x3393B1 VA: 0x3392B0
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339390 Offset: 0x339491 VA: 0x339390
	|-Array.InternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339470 Offset: 0x339571 VA: 0x339470
	|-Array.InternalEnumerator<KeyValuePair<Parameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339550 Offset: 0x339651 VA: 0x339550
	|-Array.InternalEnumerator<KeyValuePair<bool, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339630 Offset: 0x339731 VA: 0x339630
	|-Array.InternalEnumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339710 Offset: 0x339811 VA: 0x339710
	|-Array.InternalEnumerator<KeyValuePair<char, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3397F0 Offset: 0x3398F1 VA: 0x3397F0
	|-Array.InternalEnumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3398D0 Offset: 0x3399D1 VA: 0x3398D0
	|-Array.InternalEnumerator<KeyValuePair<double, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3399B0 Offset: 0x339AB1 VA: 0x3399B0
	|-Array.InternalEnumerator<KeyValuePair<Guid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339A90 Offset: 0x339B91 VA: 0x339A90
	|-Array.InternalEnumerator<KeyValuePair<short, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339B70 Offset: 0x339C71 VA: 0x339B70
	|-Array.InternalEnumerator<KeyValuePair<int, CropDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339C50 Offset: 0x339D51 VA: 0x339C50
	|-Array.InternalEnumerator<KeyValuePair<int, EffectDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339D30 Offset: 0x339E31 VA: 0x339D30
	|-Array.InternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339E90 Offset: 0x339F91 VA: 0x339E90
	|-Array.InternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x339F70 Offset: 0x33A071 VA: 0x339F70
	|-Array.InternalEnumerator<KeyValuePair<int, MiningDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A050 Offset: 0x33A151 VA: 0x33A050
	|-Array.InternalEnumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A1B0 Offset: 0x33A2B1 VA: 0x33A1B0
	|-Array.InternalEnumerator<KeyValuePair<int, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A310 Offset: 0x33A411 VA: 0x33A310
	|-Array.InternalEnumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A470 Offset: 0x33A571 VA: 0x33A470
	|-Array.InternalEnumerator<KeyValuePair<int, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A5D0 Offset: 0x33A6D1 VA: 0x33A5D0
	|-Array.InternalEnumerator<KeyValuePair<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A6B0 Offset: 0x33A7B1 VA: 0x33A6B0
	|-Array.InternalEnumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A790 Offset: 0x33A891 VA: 0x33A790
	|-Array.InternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A870 Offset: 0x33A971 VA: 0x33A870
	|-Array.InternalEnumerator<KeyValuePair<int, SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33A960 Offset: 0x33AA61 VA: 0x33A960
	|-Array.InternalEnumerator<KeyValuePair<int, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33AA40 Offset: 0x33AB41 VA: 0x33AA40
	|-Array.InternalEnumerator<KeyValuePair<int, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33AB20 Offset: 0x33AC21 VA: 0x33AB20
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33AC00 Offset: 0x33AD01 VA: 0x33AC00
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33ACE0 Offset: 0x33ADE1 VA: 0x33ACE0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33ADC0 Offset: 0x33AEC1 VA: 0x33ADC0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33AF30 Offset: 0x33B031 VA: 0x33AF30
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B010 Offset: 0x33B111 VA: 0x33B010
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B170 Offset: 0x33B271 VA: 0x33B170
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B2D0 Offset: 0x33B3D1 VA: 0x33B2D0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B3B0 Offset: 0x33B4B1 VA: 0x33B3B0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B510 Offset: 0x33B611 VA: 0x33B510
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B600 Offset: 0x33B701 VA: 0x33B600
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B6E0 Offset: 0x33B7E1 VA: 0x33B6E0
	|-Array.InternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B7C0 Offset: 0x33B8C1 VA: 0x33B7C0
	|-Array.InternalEnumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B8A0 Offset: 0x33B9A1 VA: 0x33B8A0
	|-Array.InternalEnumerator<KeyValuePair<Memory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33B980 Offset: 0x33BA81 VA: 0x33B980
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BA60 Offset: 0x33BB61 VA: 0x33BA60
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BB40 Offset: 0x33BC41 VA: 0x33BB40
	|-Array.InternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BC20 Offset: 0x33BD21 VA: 0x33BC20
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BD00 Offset: 0x33BE01 VA: 0x33BD00
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Color>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BDE0 Offset: 0x33BEE1 VA: 0x33BDE0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BEC0 Offset: 0x33BFC1 VA: 0x33BEC0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33BFA0 Offset: 0x33C0A1 VA: 0x33BFA0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C080 Offset: 0x33C181 VA: 0x33C080
	|-Array.InternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C160 Offset: 0x33C261 VA: 0x33C160
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C240 Offset: 0x33C341 VA: 0x33C240
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C320 Offset: 0x33C421 VA: 0x33C320
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C400 Offset: 0x33C501 VA: 0x33C400
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C4E0 Offset: 0x33C5E1 VA: 0x33C4E0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C5C0 Offset: 0x33C6C1 VA: 0x33C5C0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C6A0 Offset: 0x33C7A1 VA: 0x33C6A0
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C780 Offset: 0x33C881 VA: 0x33C780
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C860 Offset: 0x33C961 VA: 0x33C860
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33C940 Offset: 0x33CA41 VA: 0x33C940
	|-Array.InternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CA20 Offset: 0x33CB21 VA: 0x33CA20
	|-Array.InternalEnumerator<KeyValuePair<object, BitVector32Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CB00 Offset: 0x33CC01 VA: 0x33CB00
	|-Array.InternalEnumerator<KeyValuePair<object, EventCheckId>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CBE0 Offset: 0x33CCE1 VA: 0x33CBE0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CCC0 Offset: 0x33CDC1 VA: 0x33CCC0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CDA0 Offset: 0x33CEA1 VA: 0x33CDA0
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CE80 Offset: 0x33CF81 VA: 0x33CE80
	|-Array.InternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33CF60 Offset: 0x33D061 VA: 0x33CF60
	|-Array.InternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D040 Offset: 0x33D141 VA: 0x33D040
	|-Array.InternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D120 Offset: 0x33D221 VA: 0x33D120
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D200 Offset: 0x33D301 VA: 0x33D200
	|-Array.InternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D2E0 Offset: 0x33D3E1 VA: 0x33D2E0
	|-Array.InternalEnumerator<KeyValuePair<object, Parameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D3C0 Offset: 0x33D4C1 VA: 0x33D3C0
	|-Array.InternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D4A0 Offset: 0x33D5A1 VA: 0x33D4A0
	|-Array.InternalEnumerator<KeyValuePair<object, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D580 Offset: 0x33D681 VA: 0x33D580
	|-Array.InternalEnumerator<KeyValuePair<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D660 Offset: 0x33D761 VA: 0x33D660
	|-Array.InternalEnumerator<KeyValuePair<object, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D740 Offset: 0x33D841 VA: 0x33D740
	|-Array.InternalEnumerator<KeyValuePair<object, DateTime>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D820 Offset: 0x33D921 VA: 0x33D820
	|-Array.InternalEnumerator<KeyValuePair<object, double>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D900 Offset: 0x33DA01 VA: 0x33D900
	|-Array.InternalEnumerator<KeyValuePair<object, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33D9E0 Offset: 0x33DAE1 VA: 0x33D9E0
	|-Array.InternalEnumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33DAC0 Offset: 0x33DBC1 VA: 0x33DAC0
	|-Array.InternalEnumerator<KeyValuePair<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33DBA0 Offset: 0x33DCA1 VA: 0x33DBA0
	|-Array.InternalEnumerator<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33DC80 Offset: 0x33DD81 VA: 0x33DC80
	|-Array.InternalEnumerator<KeyValuePair<object, Memory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33DD60 Offset: 0x33DE61 VA: 0x33DD60
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33DE40 Offset: 0x33DF41 VA: 0x33DE40
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33DF20 Offset: 0x33E021 VA: 0x33DF20
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E000 Offset: 0x33E101 VA: 0x33E000
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E0E0 Offset: 0x33E1E1 VA: 0x33E0E0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Color>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E1C0 Offset: 0x33E2C1 VA: 0x33E1C0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E2A0 Offset: 0x33E3A1 VA: 0x33E2A0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E380 Offset: 0x33E481 VA: 0x33E380
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E460 Offset: 0x33E561 VA: 0x33E460
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E540 Offset: 0x33E641 VA: 0x33E540
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E620 Offset: 0x33E721 VA: 0x33E620
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E700 Offset: 0x33E801 VA: 0x33E700
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E7E0 Offset: 0x33E8E1 VA: 0x33E7E0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E8C0 Offset: 0x33E9C1 VA: 0x33E8C0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33E9A0 Offset: 0x33EAA1 VA: 0x33E9A0
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33EA80 Offset: 0x33EB81 VA: 0x33EA80
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33EB60 Offset: 0x33EC61 VA: 0x33EB60
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33EC40 Offset: 0x33ED41 VA: 0x33EC40
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33ED20 Offset: 0x33EE21 VA: 0x33ED20
	|-Array.InternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x33EE00 Offset: 0x33EF01 VA: 0x33EE00
	|-Array.InternalEnumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355570 Offset: 0x355671 VA: 0x355570
	|-Array.InternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355650 Offset: 0x355751 VA: 0x355650
	|-Array.InternalEnumerator<KeyValuePair<object, ResourceLocator>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355730 Offset: 0x355831 VA: 0x355730
	|-Array.InternalEnumerator<KeyValuePair<object, sbyte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355810 Offset: 0x355911 VA: 0x355810
	|-Array.InternalEnumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3558F0 Offset: 0x3559F1 VA: 0x3558F0
	|-Array.InternalEnumerator<KeyValuePair<object, ushort>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3559D0 Offset: 0x355AD1 VA: 0x3559D0
	|-Array.InternalEnumerator<KeyValuePair<object, uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355AB0 Offset: 0x355BB1 VA: 0x355AB0
	|-Array.InternalEnumerator<KeyValuePair<object, ulong>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355B90 Offset: 0x355C91 VA: 0x355B90
	|-Array.InternalEnumerator<KeyValuePair<object, TransitionTables>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355C70 Offset: 0x355D71 VA: 0x355C70
	|-Array.InternalEnumerator<KeyValuePair<object, Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355D50 Offset: 0x355E51 VA: 0x355D50
	|-Array.InternalEnumerator<KeyValuePair<object, BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355E30 Offset: 0x355F31 VA: 0x355E30
	|-Array.InternalEnumerator<KeyValuePair<object, Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355F10 Offset: 0x356011 VA: 0x355F10
	|-Array.InternalEnumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x355FF0 Offset: 0x3560F1 VA: 0x355FF0
	|-Array.InternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3560D0 Offset: 0x3561D1 VA: 0x3560D0
	|-Array.InternalEnumerator<KeyValuePair<object, GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3561B0 Offset: 0x3562B1 VA: 0x3561B0
	|-Array.InternalEnumerator<KeyValuePair<object, Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356290 Offset: 0x356391 VA: 0x356290
	|-Array.InternalEnumerator<KeyValuePair<object, LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356370 Offset: 0x356471 VA: 0x356370
	|-Array.InternalEnumerator<KeyValuePair<object, Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356450 Offset: 0x356551 VA: 0x356450
	|-Array.InternalEnumerator<KeyValuePair<object, Playable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356530 Offset: 0x356631 VA: 0x356530
	|-Array.InternalEnumerator<KeyValuePair<object, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356610 Offset: 0x356711 VA: 0x356610
	|-Array.InternalEnumerator<KeyValuePair<object, RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3566F0 Offset: 0x3567F1 VA: 0x3566F0
	|-Array.InternalEnumerator<KeyValuePair<object, Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3567D0 Offset: 0x3568D1 VA: 0x3567D0
	|-Array.InternalEnumerator<KeyValuePair<object, RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3568B0 Offset: 0x3569B1 VA: 0x3568B0
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356990 Offset: 0x356A91 VA: 0x356990
	|-Array.InternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356A70 Offset: 0x356B71 VA: 0x356A70
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356B50 Offset: 0x356C51 VA: 0x356B50
	|-Array.InternalEnumerator<KeyValuePair<object, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356C30 Offset: 0x356D31 VA: 0x356C30
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356D10 Offset: 0x356E11 VA: 0x356D10
	|-Array.InternalEnumerator<KeyValuePair<object, Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356DF0 Offset: 0x356EF1 VA: 0x356DF0
	|-Array.InternalEnumerator<KeyValuePair<object, Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356ED0 Offset: 0x356FD1 VA: 0x356ED0
	|-Array.InternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x356FB0 Offset: 0x3570B1 VA: 0x356FB0
	|-Array.InternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357090 Offset: 0x357191 VA: 0x357090
	|-Array.InternalEnumerator<KeyValuePair<sbyte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357170 Offset: 0x357271 VA: 0x357170
	|-Array.InternalEnumerator<KeyValuePair<float, CurveSample>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357250 Offset: 0x357351 VA: 0x357250
	|-Array.InternalEnumerator<KeyValuePair<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357330 Offset: 0x357431 VA: 0x357330
	|-Array.InternalEnumerator<KeyValuePair<ushort, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357410 Offset: 0x357511 VA: 0x357410
	|-Array.InternalEnumerator<KeyValuePair<uint, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357570 Offset: 0x357671 VA: 0x357570
	|-Array.InternalEnumerator<KeyValuePair<uint, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3576D0 Offset: 0x3577D1 VA: 0x3576D0
	|-Array.InternalEnumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3577B0 Offset: 0x3578B1 VA: 0x3577B0
	|-Array.InternalEnumerator<KeyValuePair<ulong, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3578A0 Offset: 0x3579A1 VA: 0x3578A0
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357980 Offset: 0x357A81 VA: 0x357980
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357A60 Offset: 0x357B61 VA: 0x357A60
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357B40 Offset: 0x357C41 VA: 0x357B40
	|-Array.InternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357C30 Offset: 0x357D31 VA: 0x357C30
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357D10 Offset: 0x357E11 VA: 0x357D10
	|-Array.InternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357DF0 Offset: 0x357EF1 VA: 0x357DF0
	|-Array.InternalEnumerator<KeyValuePair<Bounds, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357ED0 Offset: 0x357FD1 VA: 0x357ED0
	|-Array.InternalEnumerator<KeyValuePair<BoundsInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x357FB0 Offset: 0x3580B1 VA: 0x357FB0
	|-Array.InternalEnumerator<KeyValuePair<Color, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358090 Offset: 0x358191 VA: 0x358090
	|-Array.InternalEnumerator<KeyValuePair<Color32, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358170 Offset: 0x358271 VA: 0x358170
	|-Array.InternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358250 Offset: 0x358351 VA: 0x358250
	|-Array.InternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358330 Offset: 0x358431 VA: 0x358330
	|-Array.InternalEnumerator<KeyValuePair<GradientColorKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358410 Offset: 0x358511 VA: 0x358410
	|-Array.InternalEnumerator<KeyValuePair<Keyframe, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3584F0 Offset: 0x3585F1 VA: 0x3584F0
	|-Array.InternalEnumerator<KeyValuePair<LayerMask, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3585D0 Offset: 0x3586D1 VA: 0x3585D0
	|-Array.InternalEnumerator<KeyValuePair<Matrix4x4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3586B0 Offset: 0x3587B1 VA: 0x3586B0
	|-Array.InternalEnumerator<KeyValuePair<IntVec3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358790 Offset: 0x358891 VA: 0x358790
	|-Array.InternalEnumerator<KeyValuePair<Quaternion, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358870 Offset: 0x358971 VA: 0x358870
	|-Array.InternalEnumerator<KeyValuePair<RangeInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358950 Offset: 0x358A51 VA: 0x358950
	|-Array.InternalEnumerator<KeyValuePair<Rect, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358A30 Offset: 0x358B31 VA: 0x358A30
	|-Array.InternalEnumerator<KeyValuePair<RectInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358B20 Offset: 0x358C21 VA: 0x358B20
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358C00 Offset: 0x358D01 VA: 0x358C00
	|-Array.InternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358CE0 Offset: 0x358DE1 VA: 0x358CE0
	|-Array.InternalEnumerator<KeyValuePair<Vector2, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358DC0 Offset: 0x358EC1 VA: 0x358DC0
	|-Array.InternalEnumerator<KeyValuePair<Vector2Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358EA0 Offset: 0x358FA1 VA: 0x358EA0
	|-Array.InternalEnumerator<KeyValuePair<Vector3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x358F80 Offset: 0x359081 VA: 0x358F80
	|-Array.InternalEnumerator<KeyValuePair<Vector3Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359060 Offset: 0x359161 VA: 0x359060
	|-Array.InternalEnumerator<KeyValuePair<Vector4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359140 Offset: 0x359241 VA: 0x359140
	|-Array.InternalEnumerator<Hashtable.bucket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359220 Offset: 0x359321 VA: 0x359220
	|-Array.InternalEnumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359380 Offset: 0x359481 VA: 0x359380
	|-Array.InternalEnumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359460 Offset: 0x359561 VA: 0x359460
	|-Array.InternalEnumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359540 Offset: 0x359641 VA: 0x359540
	|-Array.InternalEnumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3596A0 Offset: 0x3597A1 VA: 0x3596A0
	|-Array.InternalEnumerator<InternalCodePageDataItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359780 Offset: 0x359881 VA: 0x359780
	|-Array.InternalEnumerator<InternalEncodingDataItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359860 Offset: 0x359961 VA: 0x359860
	|-Array.InternalEnumerator<Guid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359940 Offset: 0x359A41 VA: 0x359940
	|-Array.InternalEnumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359AA0 Offset: 0x359BA1 VA: 0x359AA0
	|-Array.InternalEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359C00 Offset: 0x359D01 VA: 0x359C00
	|-Array.InternalEnumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359D60 Offset: 0x359E61 VA: 0x359D60
	|-Array.InternalEnumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x359EC0 Offset: 0x359FC1 VA: 0x359EC0
	|-Array.InternalEnumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A020 Offset: 0x35A121 VA: 0x35A020
	|-Array.InternalEnumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A100 Offset: 0x35A201 VA: 0x35A100
	|-Array.InternalEnumerator<LocalDefinition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A1F0 Offset: 0x35A2F1 VA: 0x35A1F0
	|-Array.InternalEnumerator<RuntimeLabel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A2E0 Offset: 0x35A3E1 VA: 0x35A2E0
	|-Array.InternalEnumerator<Set.Slot<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A3C0 Offset: 0x35A4C1 VA: 0x35A3C0
	|-Array.InternalEnumerator<Set.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A4A0 Offset: 0x35A5A1 VA: 0x35A4A0
	|-Array.InternalEnumerator<Memory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A580 Offset: 0x35A681 VA: 0x35A580
	|-Array.InternalEnumerator<CookieTokenizer.RecognizedAttribute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A660 Offset: 0x35A761 VA: 0x35A660
	|-Array.InternalEnumerator<HeaderVariantInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A740 Offset: 0x35A841 VA: 0x35A740
	|-Array.InternalEnumerator<Socket.WSABUF>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A820 Offset: 0x35A921 VA: 0x35A820
	|-Array.InternalEnumerator<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35A900 Offset: 0x35AA01 VA: 0x35A900
	|-Array.InternalEnumerator<Nullable<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35AA60 Offset: 0x35AB61 VA: 0x35AA60
	|-Array.InternalEnumerator<Nullable<Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35AB40 Offset: 0x35AC41 VA: 0x35AB40
	|-Array.InternalEnumerator<Nullable<BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35AC20 Offset: 0x35AD21 VA: 0x35AC20
	|-Array.InternalEnumerator<Nullable<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35AD80 Offset: 0x35AE81 VA: 0x35AD80
	|-Array.InternalEnumerator<Nullable<Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35AE70 Offset: 0x35AF71 VA: 0x35AE70
	|-Array.InternalEnumerator<Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35AF50 Offset: 0x35B051 VA: 0x35AF50
	|-Array.InternalEnumerator<Nullable<GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B030 Offset: 0x35B131 VA: 0x35B030
	|-Array.InternalEnumerator<Nullable<Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B110 Offset: 0x35B211 VA: 0x35B110
	|-Array.InternalEnumerator<Nullable<LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B270 Offset: 0x35B371 VA: 0x35B270
	|-Array.InternalEnumerator<Nullable<Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B350 Offset: 0x35B451 VA: 0x35B350
	|-Array.InternalEnumerator<Nullable<Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B440 Offset: 0x35B541 VA: 0x35B440
	|-Array.InternalEnumerator<Nullable<RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B520 Offset: 0x35B621 VA: 0x35B520
	|-Array.InternalEnumerator<Nullable<Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B600 Offset: 0x35B701 VA: 0x35B600
	|-Array.InternalEnumerator<Nullable<RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B6F0 Offset: 0x35B7F1 VA: 0x35B6F0
	|-Array.InternalEnumerator<Nullable<Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B7E0 Offset: 0x35B8E1 VA: 0x35B7E0
	|-Array.InternalEnumerator<Nullable<Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35B8C0 Offset: 0x35B9C1 VA: 0x35B8C0
	|-Array.InternalEnumerator<Nullable<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342AA0 Offset: 0x342BA1 VA: 0x342AA0
	|-Array.InternalEnumerator<Nullable<Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342B80 Offset: 0x342C81 VA: 0x342B80
	|-Array.InternalEnumerator<Nullable<Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342C60 Offset: 0x342D61 VA: 0x342C60
	|-Array.InternalEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342D70 Offset: 0x342E71 VA: 0x342D70
	|-Array.InternalEnumerator<ParameterizedStrings.FormatParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342E50 Offset: 0x342F51 VA: 0x342E50
	|-Array.InternalEnumerator<ReadOnlyMemory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x342F30 Offset: 0x343031 VA: 0x342F30
	|-Array.InternalEnumerator<CustomAttributeNamedArgument>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343010 Offset: 0x343111 VA: 0x343010
	|-Array.InternalEnumerator<CustomAttributeTypedArgument>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343100 Offset: 0x343201 VA: 0x343100
	|-Array.InternalEnumerator<Label>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343260 Offset: 0x343361 VA: 0x343260
	|-Array.InternalEnumerator<ParameterModifier>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3433C0 Offset: 0x3434C1 VA: 0x3433C0
	|-Array.InternalEnumerator<ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3434A0 Offset: 0x3435A1 VA: 0x3434A0
	|-Array.InternalEnumerator<Ephemeron>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343590 Offset: 0x343691 VA: 0x343590
	|-Array.InternalEnumerator<GCHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3436F0 Offset: 0x3437F1 VA: 0x3436F0
	|-Array.InternalEnumerator<RuntimeTypeHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343850 Offset: 0x343951 VA: 0x343850
	|-Array.InternalEnumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3439B0 Offset: 0x343AB1 VA: 0x3439B0
	|-Array.InternalEnumerator<X509ChainStatus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343A90 Offset: 0x343B91 VA: 0x343A90
	|-Array.InternalEnumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343C00 Offset: 0x343D01 VA: 0x343C00
	|-Array.InternalEnumerator<RegexCharClass.LowerCaseMapping>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343CE0 Offset: 0x343DE1 VA: 0x343CE0
	|-Array.InternalEnumerator<CancellationTokenRegistration>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343DC0 Offset: 0x343EC1 VA: 0x343DC0
	|-Array.InternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x343F20 Offset: 0x344021 VA: 0x343F20
	|-Array.InternalEnumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344080 Offset: 0x344181 VA: 0x344080
	|-Array.InternalEnumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3441E0 Offset: 0x3442E1 VA: 0x3441E0
	|-Array.InternalEnumerator<UInt16Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344340 Offset: 0x344441 VA: 0x344340
	|-Array.InternalEnumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3444A0 Offset: 0x3445A1 VA: 0x3444A0
	|-Array.InternalEnumerator<UInt32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344600 Offset: 0x344701 VA: 0x344600
	|-Array.InternalEnumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344760 Offset: 0x344861 VA: 0x344760
	|-Array.InternalEnumerator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3448C0 Offset: 0x3449C1 VA: 0x3448C0
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344A20 Offset: 0x344B21 VA: 0x344A20
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344B00 Offset: 0x344C01 VA: 0x344B00
	|-Array.InternalEnumerator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344BE0 Offset: 0x344CE1 VA: 0x344BE0
	|-Array.InternalEnumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344CC0 Offset: 0x344DC1 VA: 0x344CC0
	|-Array.InternalEnumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344DA0 Offset: 0x344EA1 VA: 0x344DA0
	|-Array.InternalEnumerator<ValueTuple<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344E80 Offset: 0x344F81 VA: 0x344E80
	|-Array.InternalEnumerator<ValueTuple<float, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x344F60 Offset: 0x345061 VA: 0x344F60
	|-Array.InternalEnumerator<ValueTuple<Vector3, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345050 Offset: 0x345151 VA: 0x345050
	|-Array.InternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345130 Offset: 0x345231 VA: 0x345130
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345210 Offset: 0x345311 VA: 0x345210
	|-Array.InternalEnumerator<ValueTuple<object, object, Vector3, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3452F0 Offset: 0x3453F1 VA: 0x3452F0
	|-Array.InternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3453D0 Offset: 0x3454D1 VA: 0x3453D0
	|-Array.InternalEnumerator<HighlightState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3454B0 Offset: 0x3455B1 VA: 0x3454B0
	|-Array.InternalEnumerator<MaterialReference>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345590 Offset: 0x345691 VA: 0x345590
	|-Array.InternalEnumerator<RichTextTagAttribute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345670 Offset: 0x345771 VA: 0x345670
	|-Array.InternalEnumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345750 Offset: 0x345851 VA: 0x345750
	|-Array.InternalEnumerator<TMP_CharacterInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345830 Offset: 0x345931 VA: 0x345830
	|-Array.InternalEnumerator<TMP_FontWeightPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345910 Offset: 0x345A11 VA: 0x345910
	|-Array.InternalEnumerator<TMP_LineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3459F0 Offset: 0x345AF1 VA: 0x3459F0
	|-Array.InternalEnumerator<TMP_LinkInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345AD0 Offset: 0x345BD1 VA: 0x345AD0
	|-Array.InternalEnumerator<TMP_MeshInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345BB0 Offset: 0x345CB1 VA: 0x345BB0
	|-Array.InternalEnumerator<TMP_PageInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345CA0 Offset: 0x345DA1 VA: 0x345CA0
	|-Array.InternalEnumerator<TMP_Text.UnicodeChar>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345D80 Offset: 0x345E81 VA: 0x345D80
	|-Array.InternalEnumerator<TMP_TextProcessingStack<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345E60 Offset: 0x345F61 VA: 0x345E60
	|-Array.InternalEnumerator<TMP_WordInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x345F40 Offset: 0x346041 VA: 0x345F40
	|-Array.InternalEnumerator<WordWrapState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346020 Offset: 0x346121 VA: 0x346020
	|-Array.InternalEnumerator<TextPaneDatas.TextPaneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346100 Offset: 0x346201 VA: 0x346100
	|-Array.InternalEnumerator<TransitionTables>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3461F0 Offset: 0x3462F1 VA: 0x3461F0
	|-Array.InternalEnumerator<TutorialUnlockFlagData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3462D0 Offset: 0x3463D1 VA: 0x3462D0
	|-Array.InternalEnumerator<UICheckOnBackRune.LinkSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3463B0 Offset: 0x3464B1 VA: 0x3463B0
	|-Array.InternalEnumerator<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346490 Offset: 0x346591 VA: 0x346490
	|-Array.InternalEnumerator<CapEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346570 Offset: 0x346671 VA: 0x346570
	|-Array.InternalEnumerator<ClippedEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346650 Offset: 0x346751 VA: 0x346650
	|-Array.InternalEnumerator<EdgeKeyByHash>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3467B0 Offset: 0x3468B1 VA: 0x3467B0
	|-Array.InternalEnumerator<EdgeKeyByIndex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346910 Offset: 0x346A11 VA: 0x346910
	|-Array.InternalEnumerator<MeshDataConnectivity.Face>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346A70 Offset: 0x346B71 VA: 0x346A70
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346B50 Offset: 0x346C51 VA: 0x346B50
	|-Array.InternalEnumerator<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346C30 Offset: 0x346D31 VA: 0x346C30
	|-Array.InternalEnumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346D10 Offset: 0x346E11 VA: 0x346D10
	|-Array.InternalEnumerator<NavMeshBuildSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346DF0 Offset: 0x346EF1 VA: 0x346DF0
	|-Array.InternalEnumerator<ContentCatalogData.Bucket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346ED0 Offset: 0x346FD1 VA: 0x346ED0
	|-Array.InternalEnumerator<ConstraintSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x346FB0 Offset: 0x3470B1 VA: 0x346FB0
	|-Array.InternalEnumerator<PropertySceneHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347120 Offset: 0x347221 VA: 0x347120
	|-Array.InternalEnumerator<TransformStreamHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347200 Offset: 0x347301 VA: 0x347200
	|-Array.InternalEnumerator<AnimatorClipInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347360 Offset: 0x347461 VA: 0x347360
	|-Array.InternalEnumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347440 Offset: 0x347541 VA: 0x347440
	|-Array.InternalEnumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3475A0 Offset: 0x3476A1 VA: 0x3475A0
	|-Array.InternalEnumerator<BoneWeight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347680 Offset: 0x347781 VA: 0x347680
	|-Array.InternalEnumerator<BoundingSphere>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347760 Offset: 0x347861 VA: 0x347760
	|-Array.InternalEnumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347840 Offset: 0x347941 VA: 0x347840
	|-Array.InternalEnumerator<BoundsInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347920 Offset: 0x347A21 VA: 0x347920
	|-Array.InternalEnumerator<CharacterInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347A10 Offset: 0x347B11 VA: 0x347A10
	|-Array.InternalEnumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347B70 Offset: 0x347C71 VA: 0x347B70
	|-Array.InternalEnumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347C50 Offset: 0x347D51 VA: 0x347C50
	|-Array.InternalEnumerator<CombineInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347D30 Offset: 0x347E31 VA: 0x347D30
	|-Array.InternalEnumerator<ContactPoint2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347E10 Offset: 0x347F11 VA: 0x347E10
	|-Array.InternalEnumerator<ContactPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347EF0 Offset: 0x347FF1 VA: 0x347EF0
	|-Array.InternalEnumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x347FD0 Offset: 0x3480D1 VA: 0x347FD0
	|-Array.InternalEnumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3480B0 Offset: 0x3481B1 VA: 0x3480B0
	|-Array.InternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348210 Offset: 0x348311 VA: 0x348210
	|-Array.InternalEnumerator<GradientAlphaKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3482F0 Offset: 0x3483F1 VA: 0x3482F0
	|-Array.InternalEnumerator<GradientColorKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3483D0 Offset: 0x3484D1 VA: 0x3483D0
	|-Array.InternalEnumerator<HumanBone>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3484B0 Offset: 0x3485B1 VA: 0x3484B0
	|-Array.InternalEnumerator<Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348590 Offset: 0x348691 VA: 0x348590
	|-Array.InternalEnumerator<LOD>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348680 Offset: 0x348781 VA: 0x348680
	|-Array.InternalEnumerator<LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3487E0 Offset: 0x3488E1 VA: 0x3487E0
	|-Array.InternalEnumerator<PlayerLoopSystem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3488C0 Offset: 0x3489C1 VA: 0x3488C0
	|-Array.InternalEnumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3489A0 Offset: 0x348AA1 VA: 0x3489A0
	|-Array.InternalEnumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348A80 Offset: 0x348B81 VA: 0x348A80
	|-Array.InternalEnumerator<PatchExtents>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348B60 Offset: 0x348C61 VA: 0x348B60
	|-Array.InternalEnumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348C40 Offset: 0x348D41 VA: 0x348C40
	|-Array.InternalEnumerator<Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348D20 Offset: 0x348E21 VA: 0x348D20
	|-Array.InternalEnumerator<PlayableBinding>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348E00 Offset: 0x348F01 VA: 0x348E00
	|-Array.InternalEnumerator<PlayableGraph>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x348EE0 Offset: 0x348FE1 VA: 0x348EE0
	|-Array.InternalEnumerator<Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349040 Offset: 0x349141 VA: 0x349040
	|-Array.InternalEnumerator<IntVec3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349120 Offset: 0x349221 VA: 0x349120
	|-Array.InternalEnumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349200 Offset: 0x349301 VA: 0x349200
	|-Array.InternalEnumerator<RangeInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349360 Offset: 0x349461 VA: 0x349360
	|-Array.InternalEnumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349440 Offset: 0x349541 VA: 0x349440
	|-Array.InternalEnumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349520 Offset: 0x349621 VA: 0x349520
	|-Array.InternalEnumerator<Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x349600 Offset: 0x349701 VA: 0x349600
	|-Array.InternalEnumerator<RectInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3496E0 Offset: 0x3497E1 VA: 0x3496E0
	|-Array.InternalEnumerator<RenderBuffer>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327DE0 Offset: 0x327EE1 VA: 0x327DE0
	|-Array.InternalEnumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327EC0 Offset: 0x327FC1 VA: 0x327EC0
	|-Array.InternalEnumerator<ReflectionProbeBlendInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x327FA0 Offset: 0x3280A1 VA: 0x327FA0
	|-Array.InternalEnumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328080 Offset: 0x328181 VA: 0x328080
	|-Array.InternalEnumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328160 Offset: 0x328261 VA: 0x328160
	|-Array.InternalEnumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328240 Offset: 0x328341 VA: 0x328240
	|-Array.InternalEnumerator<AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328320 Offset: 0x328421 VA: 0x328320
	|-Array.InternalEnumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328400 Offset: 0x328501 VA: 0x328400
	|-Array.InternalEnumerator<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3284E0 Offset: 0x3285E1 VA: 0x3284E0
	|-Array.InternalEnumerator<SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3285C0 Offset: 0x3286C1 VA: 0x3285C0
	|-Array.InternalEnumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3286A0 Offset: 0x3287A1 VA: 0x3286A0
	|-Array.InternalEnumerator<ObjectInitializationData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328780 Offset: 0x328881 VA: 0x328780
	|-Array.InternalEnumerator<SerializedType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328860 Offset: 0x328961 VA: 0x328860
	|-Array.InternalEnumerator<SendMouseEvents.HitInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328940 Offset: 0x328A41 VA: 0x328940
	|-Array.InternalEnumerator<SkeletonBone>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328A20 Offset: 0x328B21 VA: 0x328A20
	|-Array.InternalEnumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328B00 Offset: 0x328C01 VA: 0x328B00
	|-Array.InternalEnumerator<GlyphMarshallingStruct>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328BE0 Offset: 0x328CE1 VA: 0x328BE0
	|-Array.InternalEnumerator<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328CC0 Offset: 0x328DC1 VA: 0x328CC0
	|-Array.InternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328DA0 Offset: 0x328EA1 VA: 0x328DA0
	|-Array.InternalEnumerator<IntervalTreeNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328E80 Offset: 0x328F81 VA: 0x328E80
	|-Array.InternalEnumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x328F60 Offset: 0x329061 VA: 0x328F60
	|-Array.InternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329040 Offset: 0x329141 VA: 0x329040
	|-Array.InternalEnumerator<Touch>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329120 Offset: 0x329221 VA: 0x329120
	|-Array.InternalEnumerator<TreeInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329200 Offset: 0x329301 VA: 0x329200
	|-Array.InternalEnumerator<ColorBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3292E0 Offset: 0x3293E1 VA: 0x3292E0
	|-Array.InternalEnumerator<Navigation>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3293C0 Offset: 0x3294C1 VA: 0x3293C0
	|-Array.InternalEnumerator<SpriteState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3294A0 Offset: 0x3295A1 VA: 0x3294A0
	|-Array.InternalEnumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329580 Offset: 0x329681 VA: 0x329580
	|-Array.InternalEnumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329660 Offset: 0x329761 VA: 0x329660
	|-Array.InternalEnumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329740 Offset: 0x329841 VA: 0x329740
	|-Array.InternalEnumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329820 Offset: 0x329921 VA: 0x329820
	|-Array.InternalEnumerator<StyleSheetCache.SheetHandleKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329980 Offset: 0x329A81 VA: 0x329980
	|-Array.InternalEnumerator<StyleValue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329A60 Offset: 0x329B61 VA: 0x329A60
	|-Array.InternalEnumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329B40 Offset: 0x329C41 VA: 0x329B40
	|-Array.InternalEnumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329C20 Offset: 0x329D21 VA: 0x329C20
	|-Array.InternalEnumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329D00 Offset: 0x329E01 VA: 0x329D00
	|-Array.InternalEnumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329DE0 Offset: 0x329EE1 VA: 0x329DE0
	|-Array.InternalEnumerator<Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x329F40 Offset: 0x32A041 VA: 0x329F40
	|-Array.InternalEnumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A030 Offset: 0x32A131 VA: 0x32A030
	|-Array.InternalEnumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A110 Offset: 0x32A211 VA: 0x32A110
	|-Array.InternalEnumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A1F0 Offset: 0x32A2F1 VA: 0x32A1F0
	|-Array.InternalEnumerator<jvalue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A350 Offset: 0x32A451 VA: 0x32A350
	|-Array.InternalEnumerator<WarpPoints.WarpPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A430 Offset: 0x32A531 VA: 0x32A430
	|-Array.InternalEnumerator<YieldItemParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A590 Offset: 0x32A691 VA: 0x32A590
	|-Array.InternalEnumerator<NetworkServiceAccountId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A6F0 Offset: 0x32A7F1 VA: 0x32A6F0
	|-Array.InternalEnumerator<Uid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A7D0 Offset: 0x32A8D1 VA: 0x32A7D0
	|-Array.InternalEnumerator<ConsumableServiceItemId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32A930 Offset: 0x32AA31 VA: 0x32A930
	|-Array.InternalEnumerator<NsUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32AA90 Offset: 0x32AB91 VA: 0x32AA90
	|-Array.InternalEnumerator<Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32AB70 Offset: 0x32AC71 VA: 0x32AB70
	|-Array.InternalEnumerator<Profile>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32AC50 Offset: 0x32AD51 VA: 0x32AC50
	|-Array.InternalEnumerator<DirectoryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32AD30 Offset: 0x32AE31 VA: 0x32AD30
	|-Array.InternalEnumerator<DebugPadState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32AE10 Offset: 0x32AF11 VA: 0x32AE10
	|-Array.InternalEnumerator<GesturePoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32AF70 Offset: 0x32B071 VA: 0x32AF70
	|-Array.InternalEnumerator<GestureState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B050 Offset: 0x32B151 VA: 0x32B050
	|-Array.InternalEnumerator<NpadFullKeyState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B130 Offset: 0x32B231 VA: 0x32B130
	|-Array.InternalEnumerator<NpadHandheldState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B210 Offset: 0x32B311 VA: 0x32B210
	|-Array.InternalEnumerator<NpadJoyDualState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B2F0 Offset: 0x32B3F1 VA: 0x32B2F0
	|-Array.InternalEnumerator<NpadJoyLeftState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B3D0 Offset: 0x32B4D1 VA: 0x32B3D0
	|-Array.InternalEnumerator<NpadJoyRightState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B4B0 Offset: 0x32B5B1 VA: 0x32B4B0
	|-Array.InternalEnumerator<NpadStateArrayItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B5A0 Offset: 0x32B6A1 VA: 0x32B5A0
	|-Array.InternalEnumerator<SixAxisSensorHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B700 Offset: 0x32B801 VA: 0x32B700
	|-Array.InternalEnumerator<SixAxisSensorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B7E0 Offset: 0x32B8E1 VA: 0x32B7E0
	|-Array.InternalEnumerator<TouchScreenState10>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B8C0 Offset: 0x32B9C1 VA: 0x32B8C0
	|-Array.InternalEnumerator<TouchScreenState11>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32B9A0 Offset: 0x32BAA1 VA: 0x32B9A0
	|-Array.InternalEnumerator<TouchScreenState12>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BA80 Offset: 0x32BB81 VA: 0x32BA80
	|-Array.InternalEnumerator<TouchScreenState13>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BB60 Offset: 0x32BC61 VA: 0x32BB60
	|-Array.InternalEnumerator<TouchScreenState14>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BC40 Offset: 0x32BD41 VA: 0x32BC40
	|-Array.InternalEnumerator<TouchScreenState15>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BD20 Offset: 0x32BE21 VA: 0x32BD20
	|-Array.InternalEnumerator<TouchScreenState16>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BE00 Offset: 0x32BF01 VA: 0x32BE00
	|-Array.InternalEnumerator<TouchScreenState1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BEE0 Offset: 0x32BFE1 VA: 0x32BEE0
	|-Array.InternalEnumerator<TouchScreenState2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32BFC0 Offset: 0x32C0C1 VA: 0x32BFC0
	|-Array.InternalEnumerator<TouchScreenState3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C0A0 Offset: 0x32C1A1 VA: 0x32C0A0
	|-Array.InternalEnumerator<TouchScreenState4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C180 Offset: 0x32C281 VA: 0x32C180
	|-Array.InternalEnumerator<TouchScreenState5>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C260 Offset: 0x32C361 VA: 0x32C260
	|-Array.InternalEnumerator<TouchScreenState6>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C340 Offset: 0x32C441 VA: 0x32C340
	|-Array.InternalEnumerator<TouchScreenState7>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C420 Offset: 0x32C521 VA: 0x32C420
	|-Array.InternalEnumerator<TouchScreenState8>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C500 Offset: 0x32C601 VA: 0x32C500
	|-Array.InternalEnumerator<TouchScreenState9>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C5E0 Offset: 0x32C6E1 VA: 0x32C5E0
	|-Array.InternalEnumerator<TouchState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C6D0 Offset: 0x32C7D1 VA: 0x32C6D0
	|-Array.InternalEnumerator<VibrationDeviceHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C830 Offset: 0x32C931 VA: 0x32C830
	|-Array.InternalEnumerator<VibrationDeviceInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32C990 Offset: 0x32CA91 VA: 0x32C990
	|-Array.InternalEnumerator<VibrationValue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CA70 Offset: 0x32CB71 VA: 0x32CA70
	|-Array.InternalEnumerator<ClusteringData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CB50 Offset: 0x32CC51 VA: 0x32CB50
	|-Array.InternalEnumerator<ClusteringProcessorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CC30 Offset: 0x32CD31 VA: 0x32CC30
	|-Array.InternalEnumerator<Finger>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CD10 Offset: 0x32CE11 VA: 0x32CD10
	|-Array.InternalEnumerator<Hand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CDF0 Offset: 0x32CEF1 VA: 0x32CDF0
	|-Array.InternalEnumerator<HandAnalysisImageState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CED0 Offset: 0x32CFD1 VA: 0x32CED0
	|-Array.InternalEnumerator<HandAnalysisSilhouetteState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32CFB0 Offset: 0x32D0B1 VA: 0x32CFB0
	|-Array.InternalEnumerator<MomentProcessorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D090 Offset: 0x32D191 VA: 0x32D090
	|-Array.InternalEnumerator<MomentStatistic>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D170 Offset: 0x32D271 VA: 0x32D170
	|-Array.InternalEnumerator<Protrusion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D2D0 Offset: 0x32D3D1 VA: 0x32D2D0
	|-Array.InternalEnumerator<Shape>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D3B0 Offset: 0x32D4B1 VA: 0x32D3B0
	|-Array.InternalEnumerator<DictionaryInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D510 Offset: 0x32D611 VA: 0x32D510
	|-Array.InternalEnumerator<UserWord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D600 Offset: 0x32D701 VA: 0x32D600
	|-Array.InternalEnumerator<Color4u8>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D760 Offset: 0x32D861 VA: 0x32D760
	|-Array.InternalEnumerator<Float2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x32D840 Offset: 0x32D941 VA: 0x32D840
	|-Array.InternalEnumerator<stCommand_t>.System.Collections.IEnumerator.get_Current
	*/
}

