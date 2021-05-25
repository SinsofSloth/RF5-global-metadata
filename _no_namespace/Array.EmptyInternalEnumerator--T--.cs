internal class Array.EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 123
{
	// Fields
	public static readonly Array.EmptyInternalEnumerator<T> Value; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4B90 Offset: 0x28A4C91 VA: 0x28A4B90
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>.Dispose
	|
	|-RVA: 0x28A4DB0 Offset: 0x28A4EB1 VA: 0x28A4DB0
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>.Dispose
	|
	|-RVA: 0x28A4FF0 Offset: 0x28A50F1 VA: 0x28A4FF0
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>.Dispose
	|
	|-RVA: 0x28A5200 Offset: 0x28A5301 VA: 0x28A5200
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>.Dispose
	|
	|-RVA: 0x28A5410 Offset: 0x28A5511 VA: 0x28A5410
	|-Array.EmptyInternalEnumerator<BitVector32Int>.Dispose
	|
	|-RVA: 0x28A5620 Offset: 0x28A5721 VA: 0x28A5620
	|-Array.EmptyInternalEnumerator<BuildItemData>.Dispose
	|
	|-RVA: 0x28A5870 Offset: 0x28A5971 VA: 0x28A5870
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>.Dispose
	|
	|-RVA: 0x28A5A80 Offset: 0x28A5B81 VA: 0x28A5A80
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>.Dispose
	|
	|-RVA: 0x28A5C90 Offset: 0x28A5D91 VA: 0x28A5C90
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>.Dispose
	|
	|-RVA: 0x28A5EA0 Offset: 0x28A5FA1 VA: 0x28A5EA0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.Dispose
	|
	|-RVA: 0x28A60B0 Offset: 0x28A61B1 VA: 0x28A60B0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.Dispose
	|
	|-RVA: 0x28A62D0 Offset: 0x28A63D1 VA: 0x28A62D0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.Dispose
	|
	|-RVA: 0x28A64F0 Offset: 0x28A65F1 VA: 0x28A64F0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.Dispose
	|
	|-RVA: 0x28A6700 Offset: 0x28A6801 VA: 0x28A6700
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.Dispose
	|
	|-RVA: 0x28A6910 Offset: 0x28A6A11 VA: 0x28A6910
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.Dispose
	|
	|-RVA: 0x28A6B40 Offset: 0x28A6C41 VA: 0x28A6B40
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.Dispose
	|
	|-RVA: 0x28A6D50 Offset: 0x28A6E51 VA: 0x28A6D50
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.Dispose
	|
	|-RVA: 0x28A6F60 Offset: 0x28A7061 VA: 0x28A6F60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.Dispose
	|
	|-RVA: 0x28A7180 Offset: 0x28A7281 VA: 0x28A7180
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.Dispose
	|
	|-RVA: 0x28A7390 Offset: 0x28A7491 VA: 0x28A7390
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.Dispose
	|
	|-RVA: 0x28A75A0 Offset: 0x28A76A1 VA: 0x28A75A0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.Dispose
	|
	|-RVA: 0x28A77D0 Offset: 0x28A78D1 VA: 0x28A77D0
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.Dispose
	|
	|-RVA: 0x28A7A00 Offset: 0x28A7B01 VA: 0x28A7A00
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.Dispose
	|
	|-RVA: 0x28A7C30 Offset: 0x28A7D31 VA: 0x28A7C30
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.Dispose
	|
	|-RVA: 0x28A7E50 Offset: 0x28A7F51 VA: 0x28A7E50
	|-Array.EmptyInternalEnumerator<CropDataTable>.Dispose
	|
	|-RVA: 0x28A8070 Offset: 0x28A8171 VA: 0x28A8070
	|-Array.EmptyInternalEnumerator<ControlPoint>.Dispose
	|
	|-RVA: 0x28A8290 Offset: 0x28A8391 VA: 0x28A8290
	|-Array.EmptyInternalEnumerator<DamageTextInfo>.Dispose
	|
	|-RVA: 0x28A84B0 Offset: 0x28A85B1 VA: 0x28A84B0
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>.Dispose
	|
	|-RVA: 0x28A86D0 Offset: 0x28A87D1 VA: 0x28A86D0
	|-Array.EmptyInternalEnumerator<DropItemParam>.Dispose
	|
	|-RVA: 0x28A88E0 Offset: 0x28A89E1 VA: 0x28A88E0
	|-Array.EmptyInternalEnumerator<DropTableElement>.Dispose
	|
	|-RVA: 0x28A8B00 Offset: 0x28A8C01 VA: 0x28A8B00
	|-Array.EmptyInternalEnumerator<EffectDataTable>.Dispose
	|
	|-RVA: 0x28A8D20 Offset: 0x28A8E21 VA: 0x28A8D20
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>.Dispose
	|
	|-RVA: 0x28A8F30 Offset: 0x28A9031 VA: 0x28A8F30
	|-Array.EmptyInternalEnumerator<Coord>.Dispose
	|
	|-RVA: 0x28A9140 Offset: 0x28A9241 VA: 0x28A9140
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>.Dispose
	|
	|-RVA: 0x28A9360 Offset: 0x28A9461 VA: 0x28A9360
	|-Array.EmptyInternalEnumerator<EventCheckId>.Dispose
	|
	|-RVA: 0x28A9580 Offset: 0x28A9681 VA: 0x28A9580
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>.Dispose
	|
	|-RVA: 0x28A9790 Offset: 0x28A9891 VA: 0x28A9790
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>.Dispose
	|
	|-RVA: 0x28A99A0 Offset: 0x28A9AA1 VA: 0x28A99A0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>.Dispose
	|
	|-RVA: 0x28A9BE0 Offset: 0x28A9CE1 VA: 0x28A9BE0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>.Dispose
	|
	|-RVA: 0x28A9E10 Offset: 0x28A9F11 VA: 0x28A9E10
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.Dispose
	|
	|-RVA: 0x28AA030 Offset: 0x28AA131 VA: 0x28AA030
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>.Dispose
	|
	|-RVA: 0x28AA240 Offset: 0x28AA341 VA: 0x28AA240
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>.Dispose
	|
	|-RVA: 0x28AA450 Offset: 0x28AA551 VA: 0x28AA450
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>.Dispose
	|
	|-RVA: 0x28AA660 Offset: 0x28AA761 VA: 0x28AA660
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>.Dispose
	|
	|-RVA: 0x28AA870 Offset: 0x28AA971 VA: 0x28AA870
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>.Dispose
	|
	|-RVA: 0x28AAAA0 Offset: 0x28AABA1 VA: 0x28AAAA0
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.Dispose
	|
	|-RVA: 0x28AACC0 Offset: 0x28AADC1 VA: 0x28AACC0
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>.Dispose
	|
	|-RVA: 0x28AAF00 Offset: 0x28AB001 VA: 0x28AAF00
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>.Dispose
	|
	|-RVA: 0x28AB110 Offset: 0x28AB211 VA: 0x28AB110
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.Dispose
	|
	|-RVA: 0x28AB340 Offset: 0x28AB441 VA: 0x28AB340
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>.Dispose
	|
	|-RVA: 0x28AB560 Offset: 0x28AB661 VA: 0x28AB560
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>.Dispose
	|
	|-RVA: 0x28AB780 Offset: 0x28AB881 VA: 0x28AB780
	|-Array.EmptyInternalEnumerator<FurnitureData>.Dispose
	|
	|-RVA: 0x28AB9A0 Offset: 0x28ABAA1 VA: 0x28AB9A0
	|-Array.EmptyInternalEnumerator<GateDataTable>.Dispose
	|
	|-RVA: 0x28ABBB0 Offset: 0x28ABCB1 VA: 0x28ABBB0
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>.Dispose
	|
	|-RVA: 0x28ABDE0 Offset: 0x28ABEE1 VA: 0x28ABDE0
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>.Dispose
	|
	|-RVA: 0x28ABFF0 Offset: 0x28AC0F1 VA: 0x28ABFF0
	|-Array.EmptyInternalEnumerator<HitResult>.Dispose
	|
	|-RVA: 0x28AC220 Offset: 0x28AC321 VA: 0x28AC220
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>.Dispose
	|
	|-RVA: 0x28AC440 Offset: 0x28AC541 VA: 0x28AC440
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>.Dispose
	|
	|-RVA: 0x28AC660 Offset: 0x28AC761 VA: 0x28AC660
	|-Array.EmptyInternalEnumerator<ItemLevelData>.Dispose
	|
	|-RVA: 0x28AC870 Offset: 0x28AC971 VA: 0x28AC870
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>.Dispose
	|
	|-RVA: 0x28ACA90 Offset: 0x28ACB91 VA: 0x28ACA90
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>.Dispose
	|
	|-RVA: 0x28ACCC0 Offset: 0x28ACDC1 VA: 0x28ACCC0
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>.Dispose
	|
	|-RVA: 0x28ACED0 Offset: 0x28ACFD1 VA: 0x28ACED0
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>.Dispose
	|
	|-RVA: 0x28AD100 Offset: 0x28AD201 VA: 0x28AD100
	|-Array.EmptyInternalEnumerator<MiningDataTable>.Dispose
	|
	|-RVA: 0x28AD310 Offset: 0x28AD411 VA: 0x28AD310
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>.Dispose
	|
	|-RVA: 0x28AD540 Offset: 0x28AD641 VA: 0x28AD540
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.Dispose
	|
	|-RVA: 0x28AD760 Offset: 0x28AD861 VA: 0x28AD760
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>.Dispose
	|
	|-RVA: 0x28AD980 Offset: 0x28ADA81 VA: 0x28AD980
	|-Array.EmptyInternalEnumerator<MonsterDataTable>.Dispose
	|
	|-RVA: 0x28ADBA0 Offset: 0x28ADCA1 VA: 0x28ADBA0
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>.Dispose
	|
	|-RVA: 0x28ADDC0 Offset: 0x28ADEC1 VA: 0x28ADDC0
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>.Dispose
	|
	|-RVA: 0x28ADFF0 Offset: 0x28AE0F1 VA: 0x28ADFF0
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>.Dispose
	|
	|-RVA: 0x28AE220 Offset: 0x28AE321 VA: 0x28AE220
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>.Dispose
	|
	|-RVA: 0x28AE450 Offset: 0x28AE551 VA: 0x28AE450
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>.Dispose
	|
	|-RVA: 0x28AE660 Offset: 0x28AE761 VA: 0x28AE660
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>.Dispose
	|
	|-RVA: 0x28AE870 Offset: 0x28AE971 VA: 0x28AE870
	|-Array.EmptyInternalEnumerator<NPCActionData>.Dispose
	|
	|-RVA: 0x28AEAA0 Offset: 0x28AEBA1 VA: 0x28AEAA0
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>.Dispose
	|
	|-RVA: 0x28AECB0 Offset: 0x28AEDB1 VA: 0x28AECB0
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>.Dispose
	|
	|-RVA: 0x28AEEC0 Offset: 0x28AEFC1 VA: 0x28AEEC0
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>.Dispose
	|
	|-RVA: 0x28AF0E0 Offset: 0x28AF1E1 VA: 0x28AF0E0
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>.Dispose
	|
	|-RVA: 0x28AF2F0 Offset: 0x28AF3F1 VA: 0x28AF2F0
	|-Array.EmptyInternalEnumerator<OrderSaveData>.Dispose
	|
	|-RVA: 0x28AF520 Offset: 0x28AF621 VA: 0x28AF520
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>.Dispose
	|
	|-RVA: 0x28AF740 Offset: 0x28AF841 VA: 0x28AF740
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.Dispose
	|
	|-RVA: 0x28AF950 Offset: 0x28AFA51 VA: 0x28AF950
	|-Array.EmptyInternalEnumerator<Parameter>.Dispose
	|
	|-RVA: 0x28AFB70 Offset: 0x28AFC71 VA: 0x28AFB70
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.Dispose
	|
	|-RVA: 0x28AFD80 Offset: 0x28AFE81 VA: 0x28AFD80
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>.Dispose
	|
	|-RVA: 0x28AFFB0 Offset: 0x28B00B1 VA: 0x28AFFB0
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>.Dispose
	|
	|-RVA: 0x28B01C0 Offset: 0x28B02C1 VA: 0x28B01C0
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>.Dispose
	|
	|-RVA: 0x28B03F0 Offset: 0x28B04F1 VA: 0x28B03F0
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>.Dispose
	|
	|-RVA: 0x28B0600 Offset: 0x28B0701 VA: 0x28B0600
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>.Dispose
	|
	|-RVA: 0x28B0810 Offset: 0x28B0911 VA: 0x28B0810
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>.Dispose
	|
	|-RVA: 0x28B0A20 Offset: 0x28B0B21 VA: 0x28B0A20
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>.Dispose
	|
	|-RVA: 0x28B0C50 Offset: 0x28B0D51 VA: 0x28B0C50
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.Dispose
	|
	|-RVA: 0x28B0E80 Offset: 0x28B0F81 VA: 0x28B0E80
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.Dispose
	|
	|-RVA: 0x28B10B0 Offset: 0x28B11B1 VA: 0x28B10B0
	|-Array.EmptyInternalEnumerator<ProfilerFrame>.Dispose
	|
	|-RVA: 0x28B12C0 Offset: 0x28B13C1 VA: 0x28B12C0
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>.Dispose
	|
	|-RVA: 0x28B14D0 Offset: 0x28B15D1 VA: 0x28B14D0
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>.Dispose
	|
	|-RVA: 0x28B16F0 Offset: 0x28B17F1 VA: 0x28B16F0
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>.Dispose
	|
	|-RVA: 0x28B1910 Offset: 0x28B1A11 VA: 0x28B1910
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>.Dispose
	|
	|-RVA: 0x28B1B20 Offset: 0x28B1C21 VA: 0x28B1B20
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>.Dispose
	|
	|-RVA: 0x28B1D30 Offset: 0x28B1E31 VA: 0x28B1D30
	|-Array.EmptyInternalEnumerator<Schedule>.Dispose
	|
	|-RVA: 0x28B1F50 Offset: 0x28B2051 VA: 0x28B1F50
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.Dispose
	|
	|-RVA: 0x28B2160 Offset: 0x28B2261 VA: 0x28B2160
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.Dispose
	|
	|-RVA: 0x28B2370 Offset: 0x28B2471 VA: 0x28B2370
	|-Array.EmptyInternalEnumerator<SpeedData>.Dispose
	|
	|-RVA: 0x26F2550 Offset: 0x26F2651 VA: 0x26F2550
	|-Array.EmptyInternalEnumerator<CurveSample>.Dispose
	|
	|-RVA: 0x26F2790 Offset: 0x26F2891 VA: 0x26F2790
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>.Dispose
	|
	|-RVA: 0x26F29A0 Offset: 0x26F2AA1 VA: 0x26F29A0
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>.Dispose
	|
	|-RVA: 0x26F2BB0 Offset: 0x26F2CB1 VA: 0x26F2BB0
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>.Dispose
	|
	|-RVA: 0x26F2DC0 Offset: 0x26F2EC1 VA: 0x26F2DC0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.Dispose
	|
	|-RVA: 0x26F2FD0 Offset: 0x26F30D1 VA: 0x26F2FD0
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>.Dispose
	|
	|-RVA: 0x26F31E0 Offset: 0x26F32E1 VA: 0x26F31E0
	|-Array.EmptyInternalEnumerator<bool>.Dispose
	|
	|-RVA: 0x26F33F0 Offset: 0x26F34F1 VA: 0x26F33F0
	|-Array.EmptyInternalEnumerator<byte>.Dispose
	|
	|-RVA: 0x26F3600 Offset: 0x26F3701 VA: 0x26F3600
	|-Array.EmptyInternalEnumerator<ByteEnum>.Dispose
	|
	|-RVA: 0x26F3810 Offset: 0x26F3911 VA: 0x26F3810
	|-Array.EmptyInternalEnumerator<char>.Dispose
	|
	|-RVA: 0x26F3A20 Offset: 0x26F3B21 VA: 0x26F3A20
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.Dispose
	|
	|-RVA: 0x26F3C30 Offset: 0x26F3D31 VA: 0x26F3C30
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.Dispose
	|
	|-RVA: 0x26F3E40 Offset: 0x26F3F41 VA: 0x26F3E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.Dispose
	|
	|-RVA: 0x26F4060 Offset: 0x26F4161 VA: 0x26F4060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.Dispose
	|
	|-RVA: 0x26F4280 Offset: 0x26F4381 VA: 0x26F4280
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>.Dispose
	|
	|-RVA: 0x26F44B0 Offset: 0x26F45B1 VA: 0x26F44B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.Dispose
	|
	|-RVA: 0x26F46F0 Offset: 0x26F47F1 VA: 0x26F46F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.Dispose
	|
	|-RVA: 0x26F4920 Offset: 0x26F4A21 VA: 0x26F4920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.Dispose
	|
	|-RVA: 0x26F4B40 Offset: 0x26F4C41 VA: 0x26F4B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.Dispose
	|
	|-RVA: 0x26F4D60 Offset: 0x26F4E61 VA: 0x26F4D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.Dispose
	|
	|-RVA: 0x26F4F90 Offset: 0x26F5091 VA: 0x26F4F90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.Dispose
	|
	|-RVA: 0x26F51B0 Offset: 0x26F52B1 VA: 0x26F51B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.Dispose
	|
	|-RVA: 0x26F53E0 Offset: 0x26F54E1 VA: 0x26F53E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.Dispose
	|
	|-RVA: 0x26F5610 Offset: 0x26F5711 VA: 0x26F5610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>.Dispose
	|
	|-RVA: 0x26F5830 Offset: 0x26F5931 VA: 0x26F5830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>.Dispose
	|
	|-RVA: 0x26F5A50 Offset: 0x26F5B51 VA: 0x26F5A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.Dispose
	|
	|-RVA: 0x26F5C70 Offset: 0x26F5D71 VA: 0x26F5C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.Dispose
	|
	|-RVA: 0x26F5E90 Offset: 0x26F5F91 VA: 0x26F5E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>.Dispose
	|
	|-RVA: 0x26F60B0 Offset: 0x26F61B1 VA: 0x26F60B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>.Dispose
	|
	|-RVA: 0x26F62D0 Offset: 0x26F63D1 VA: 0x26F62D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.Dispose
	|
	|-RVA: 0x26F64F0 Offset: 0x26F65F1 VA: 0x26F64F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>.Dispose
	|
	|-RVA: 0x26F6710 Offset: 0x26F6811 VA: 0x26F6710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>.Dispose
	|
	|-RVA: 0x26F6930 Offset: 0x26F6A31 VA: 0x26F6930
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.Dispose
	|
	|-RVA: 0x26F6B50 Offset: 0x26F6C51 VA: 0x26F6B50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.Dispose
	|
	|-RVA: 0x26F6D60 Offset: 0x26F6E61 VA: 0x26F6D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.Dispose
	|
	|-RVA: 0x26F6FA0 Offset: 0x26F70A1 VA: 0x26F6FA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.Dispose
	|
	|-RVA: 0x26F71C0 Offset: 0x26F72C1 VA: 0x26F71C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.Dispose
	|
	|-RVA: 0x26F73D0 Offset: 0x26F74D1 VA: 0x26F73D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.Dispose
	|
	|-RVA: 0x26F75E0 Offset: 0x26F76E1 VA: 0x26F75E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.Dispose
	|
	|-RVA: 0x26F77F0 Offset: 0x26F78F1 VA: 0x26F77F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.Dispose
	|
	|-RVA: 0x26F7A00 Offset: 0x26F7B01 VA: 0x26F7A00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.Dispose
	|
	|-RVA: 0x26F7C20 Offset: 0x26F7D21 VA: 0x26F7C20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.Dispose
	|
	|-RVA: 0x26F7E40 Offset: 0x26F7F41 VA: 0x26F7E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.Dispose
	|
	|-RVA: 0x26F8070 Offset: 0x26F8171 VA: 0x26F8070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>.Dispose
	|
	|-RVA: 0x26F8290 Offset: 0x26F8391 VA: 0x26F8290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>.Dispose
	|
	|-RVA: 0x26F84B0 Offset: 0x26F85B1 VA: 0x26F84B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>.Dispose
	|
	|-RVA: 0x26F86D0 Offset: 0x26F87D1 VA: 0x26F86D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.Dispose
	|
	|-RVA: 0x26F88F0 Offset: 0x26F89F1 VA: 0x26F88F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.Dispose
	|
	|-RVA: 0x26F8B20 Offset: 0x26F8C21 VA: 0x26F8B20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.Dispose
	|
	|-RVA: 0x26F8D50 Offset: 0x26F8E51 VA: 0x26F8D50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.Dispose
	|
	|-RVA: 0x26F8F60 Offset: 0x26F9061 VA: 0x26F8F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.Dispose
	|
	|-RVA: 0x26F9180 Offset: 0x26F9281 VA: 0x26F9180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x26F9390 Offset: 0x26F9491 VA: 0x26F9390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x26F95A0 Offset: 0x26F96A1 VA: 0x26F95A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x26F97C0 Offset: 0x26F98C1 VA: 0x26F97C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>.Dispose
	|
	|-RVA: 0x26F99D0 Offset: 0x26F9AD1 VA: 0x26F99D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.Dispose
	|
	|-RVA: 0x26F9BF0 Offset: 0x26F9CF1 VA: 0x26F9BF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.Dispose
	|
	|-RVA: 0x26F9E10 Offset: 0x26F9F11 VA: 0x26F9E10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.Dispose
	|
	|-RVA: 0x26FA030 Offset: 0x26FA131 VA: 0x26FA030
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.Dispose
	|
	|-RVA: 0x26FA250 Offset: 0x26FA351 VA: 0x26FA250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>.Dispose
	|
	|-RVA: 0x26FA470 Offset: 0x26FA571 VA: 0x26FA470
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.Dispose
	|
	|-RVA: 0x26FA690 Offset: 0x26FA791 VA: 0x26FA690
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.Dispose
	|
	|-RVA: 0x26FA8C0 Offset: 0x26FA9C1 VA: 0x26FA8C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.Dispose
	|
	|-RVA: 0x26FAAF0 Offset: 0x26FABF1 VA: 0x26FAAF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.Dispose
	|
	|-RVA: 0x26FAD10 Offset: 0x26FAE11 VA: 0x26FAD10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.Dispose
	|
	|-RVA: 0x26FAF40 Offset: 0x26FB041 VA: 0x26FAF40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.Dispose
	|
	|-RVA: 0x26FB160 Offset: 0x26FB261 VA: 0x26FB160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.Dispose
	|
	|-RVA: 0x26FB390 Offset: 0x26FB491 VA: 0x26FB390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.Dispose
	|
	|-RVA: 0x26FB5C0 Offset: 0x26FB6C1 VA: 0x26FB5C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.Dispose
	|
	|-RVA: 0x26FB7E0 Offset: 0x26FB8E1 VA: 0x26FB7E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.Dispose
	|
	|-RVA: 0x26FBA20 Offset: 0x26FBB21 VA: 0x26FBA20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.Dispose
	|
	|-RVA: 0x26FBC50 Offset: 0x26FBD51 VA: 0x26FBC50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.Dispose
	|
	|-RVA: 0x26FBE70 Offset: 0x26FBF71 VA: 0x26FBE70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.Dispose
	|
	|-RVA: 0x26FC0A0 Offset: 0x26FC1A1 VA: 0x26FC0A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.Dispose
	|
	|-RVA: 0x26FC2D0 Offset: 0x26FC3D1 VA: 0x26FC2D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.Dispose
	|
	|-RVA: 0x26FC4F0 Offset: 0x26FC5F1 VA: 0x26FC4F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.Dispose
	|
	|-RVA: 0x26FC710 Offset: 0x26FC811 VA: 0x26FC710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.Dispose
	|
	|-RVA: 0x26FC930 Offset: 0x26FCA31 VA: 0x26FC930
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.Dispose
	|
	|-RVA: 0x26FCB50 Offset: 0x26FCC51 VA: 0x26FCB50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.Dispose
	|
	|-RVA: 0x26FCD80 Offset: 0x26FCE81 VA: 0x26FCD80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.Dispose
	|
	|-RVA: 0x26FCFA0 Offset: 0x26FD0A1 VA: 0x26FCFA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>.Dispose
	|
	|-RVA: 0x26FD1D0 Offset: 0x26FD2D1 VA: 0x26FD1D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.Dispose
	|
	|-RVA: 0x26FD410 Offset: 0x26FD511 VA: 0x26FD410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.Dispose
	|
	|-RVA: 0x26FD640 Offset: 0x26FD741 VA: 0x26FD640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.Dispose
	|
	|-RVA: 0x26FD860 Offset: 0x26FD961 VA: 0x26FD860
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.Dispose
	|
	|-RVA: 0x26FDA80 Offset: 0x26FDB81 VA: 0x26FDA80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.Dispose
	|
	|-RVA: 0x26FDCB0 Offset: 0x26FDDB1 VA: 0x26FDCB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.Dispose
	|
	|-RVA: 0x26FDED0 Offset: 0x26FDFD1 VA: 0x26FDED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.Dispose
	|
	|-RVA: 0x26FE100 Offset: 0x26FE201 VA: 0x26FE100
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.Dispose
	|
	|-RVA: 0x26FE330 Offset: 0x26FE431 VA: 0x26FE330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>.Dispose
	|
	|-RVA: 0x26FE550 Offset: 0x26FE651 VA: 0x26FE550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.Dispose
	|
	|-RVA: 0x26FE770 Offset: 0x26FE871 VA: 0x26FE770
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.Dispose
	|
	|-RVA: 0x26FE990 Offset: 0x26FEA91 VA: 0x26FE990
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.Dispose
	|
	|-RVA: 0x26FEBB0 Offset: 0x26FECB1 VA: 0x26FEBB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>.Dispose
	|
	|-RVA: 0x26FEDD0 Offset: 0x26FEED1 VA: 0x26FEDD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>.Dispose
	|
	|-RVA: 0x26FEFF0 Offset: 0x26FF0F1 VA: 0x26FEFF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>.Dispose
	|
	|-RVA: 0x26FF210 Offset: 0x26FF311 VA: 0x26FF210
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>.Dispose
	|
	|-RVA: 0x26FF430 Offset: 0x26FF531 VA: 0x26FF430
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.Dispose
	|
	|-RVA: 0x26FF650 Offset: 0x26FF751 VA: 0x26FF650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x26FF870 Offset: 0x26FF971 VA: 0x26FF870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>.Dispose
	|
	|-RVA: 0x26FFA90 Offset: 0x26FFB91 VA: 0x26FFA90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>.Dispose
	|
	|-RVA: 0x26FFCB0 Offset: 0x26FFDB1 VA: 0x26FFCB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.Dispose
	|
	|-RVA: 0x26FFED0 Offset: 0x26FFFD1 VA: 0x26FFED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.Dispose
	|
	|-RVA: 0x2700100 Offset: 0x2700201 VA: 0x2700100
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.Dispose
	|
	|-RVA: 0x2700330 Offset: 0x2700431 VA: 0x2700330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.Dispose
	|
	|-RVA: 0x2700550 Offset: 0x2700651 VA: 0x2700550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.Dispose
	|
	|-RVA: 0x2700780 Offset: 0x2700881 VA: 0x2700780
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.Dispose
	|
	|-RVA: 0x27009A0 Offset: 0x2700AA1 VA: 0x27009A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.Dispose
	|
	|-RVA: 0x2700BD0 Offset: 0x2700CD1 VA: 0x2700BD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.Dispose
	|
	|-RVA: 0x2700E00 Offset: 0x2700F01 VA: 0x2700E00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.Dispose
	|
	|-RVA: 0x2701020 Offset: 0x2701121 VA: 0x2701020
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.Dispose
	|
	|-RVA: 0x2701260 Offset: 0x2701361 VA: 0x2701260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.Dispose
	|
	|-RVA: 0x2701490 Offset: 0x2701591 VA: 0x2701490
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.Dispose
	|
	|-RVA: 0x27016B0 Offset: 0x27017B1 VA: 0x27016B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.Dispose
	|
	|-RVA: 0x27018E0 Offset: 0x27019E1 VA: 0x27018E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.Dispose
	|
	|-RVA: 0x2701B10 Offset: 0x2701C11 VA: 0x2701B10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.Dispose
	|
	|-RVA: 0x2701D30 Offset: 0x2701E31 VA: 0x2701D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.Dispose
	|
	|-RVA: 0x2701F50 Offset: 0x2702051 VA: 0x2701F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.Dispose
	|
	|-RVA: 0x2702170 Offset: 0x2702271 VA: 0x2702170
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.Dispose
	|
	|-RVA: 0x2702390 Offset: 0x2702491 VA: 0x2702390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.Dispose
	|
	|-RVA: 0x27025C0 Offset: 0x27026C1 VA: 0x27025C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.Dispose
	|
	|-RVA: 0x27027E0 Offset: 0x27028E1 VA: 0x27027E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.Dispose
	|
	|-RVA: 0x2702A00 Offset: 0x2702B01 VA: 0x2702A00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.Dispose
	|
	|-RVA: 0x2702C20 Offset: 0x2702D21 VA: 0x2702C20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>.Dispose
	|
	|-RVA: 0x2702E40 Offset: 0x2702F41 VA: 0x2702E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.Dispose
	|
	|-RVA: 0x2703060 Offset: 0x2703161 VA: 0x2703060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.Dispose
	|
	|-RVA: 0x2703280 Offset: 0x2703381 VA: 0x2703280
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>.Dispose
	|
	|-RVA: 0x27034A0 Offset: 0x27035A1 VA: 0x27034A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>.Dispose
	|
	|-RVA: 0x27036C0 Offset: 0x27037C1 VA: 0x27036C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>.Dispose
	|
	|-RVA: 0x27038F0 Offset: 0x27039F1 VA: 0x27038F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>.Dispose
	|
	|-RVA: 0x2703B20 Offset: 0x2703C21 VA: 0x2703B20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>.Dispose
	|
	|-RVA: 0x2703D50 Offset: 0x2703E51 VA: 0x2703D50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>.Dispose
	|
	|-RVA: 0x2703F70 Offset: 0x2704071 VA: 0x2703F70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>.Dispose
	|
	|-RVA: 0x2704190 Offset: 0x2704291 VA: 0x2704190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x27043B0 Offset: 0x27044B1 VA: 0x27043B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.Dispose
	|
	|-RVA: 0x27045E0 Offset: 0x27046E1 VA: 0x27045E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>.Dispose
	|
	|-RVA: 0x2704810 Offset: 0x2704911 VA: 0x2704810
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>.Dispose
	|
	|-RVA: 0x2704A30 Offset: 0x2704B31 VA: 0x2704A30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.Dispose
	|
	|-RVA: 0x2704C70 Offset: 0x2704D71 VA: 0x2704C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.Dispose
	|
	|-RVA: 0x2704E90 Offset: 0x2704F91 VA: 0x2704E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>.Dispose
	|
	|-RVA: 0x27050B0 Offset: 0x27051B1 VA: 0x27050B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>.Dispose
	|
	|-RVA: 0x27052D0 Offset: 0x27053D1 VA: 0x27052D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>.Dispose
	|
	|-RVA: 0x27054F0 Offset: 0x27055F1 VA: 0x27054F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>.Dispose
	|
	|-RVA: 0x2705710 Offset: 0x2705811 VA: 0x2705710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x2705940 Offset: 0x2705A41 VA: 0x2705940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.Dispose
	|
	|-RVA: 0x2705B70 Offset: 0x2705C71 VA: 0x2705B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>.Dispose
	|
	|-RVA: 0x2705D90 Offset: 0x2705E91 VA: 0x2705D90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>.Dispose
	|
	|-RVA: 0x2705FB0 Offset: 0x27060B1 VA: 0x2705FB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>.Dispose
	|
	|-RVA: 0x27061D0 Offset: 0x27062D1 VA: 0x27061D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>.Dispose
	|
	|-RVA: 0x27063F0 Offset: 0x27064F1 VA: 0x27063F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>.Dispose
	|
	|-RVA: 0x2706610 Offset: 0x2706711 VA: 0x2706610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.Dispose
	|
	|-RVA: 0x2706830 Offset: 0x2706931 VA: 0x2706830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.Dispose
	|
	|-RVA: 0x2706A50 Offset: 0x2706B51 VA: 0x2706A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.Dispose
	|
	|-RVA: 0x2706C70 Offset: 0x2706D71 VA: 0x2706C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>.Dispose
	|
	|-RVA: 0x2706EB0 Offset: 0x2706FB1 VA: 0x2706EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>.Dispose
	|
	|-RVA: 0x27070D0 Offset: 0x27071D1 VA: 0x27070D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>.Dispose
	|
	|-RVA: 0x27072F0 Offset: 0x27073F1 VA: 0x27072F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.Dispose
	|
	|-RVA: 0x2707500 Offset: 0x2707601 VA: 0x2707500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.Dispose
	|
	|-RVA: 0x2707710 Offset: 0x2707811 VA: 0x2707710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.Dispose
	|
	|-RVA: 0x2707930 Offset: 0x2707A31 VA: 0x2707930
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.Dispose
	|
	|-RVA: 0x2707B50 Offset: 0x2707C51 VA: 0x2707B50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.Dispose
	|
	|-RVA: 0x2707D70 Offset: 0x2707E71 VA: 0x2707D70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.Dispose
	|
	|-RVA: 0x2707FA0 Offset: 0x27080A1 VA: 0x2707FA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.Dispose
	|
	|-RVA: 0x27081D0 Offset: 0x27082D1 VA: 0x27081D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.Dispose
	|
	|-RVA: 0x2708400 Offset: 0x2708501 VA: 0x2708400
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.Dispose
	|
	|-RVA: 0x2708620 Offset: 0x2708721 VA: 0x2708620
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.Dispose
	|
	|-RVA: 0x2708840 Offset: 0x2708941 VA: 0x2708840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>.Dispose
	|
	|-RVA: 0x2708A70 Offset: 0x2708B71 VA: 0x2708A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>.Dispose
	|
	|-RVA: 0x2708CA0 Offset: 0x2708DA1 VA: 0x2708CA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>.Dispose
	|
	|-RVA: 0x2708EC0 Offset: 0x2708FC1 VA: 0x2708EC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>.Dispose
	|
	|-RVA: 0x27090E0 Offset: 0x27091E1 VA: 0x27090E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.Dispose
	|
	|-RVA: 0x2709300 Offset: 0x2709401 VA: 0x2709300
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.Dispose
	|
	|-RVA: 0x2709520 Offset: 0x2709621 VA: 0x2709520
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.Dispose
	|
	|-RVA: 0x2709750 Offset: 0x2709851 VA: 0x2709750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>.Dispose
	|
	|-RVA: 0x2709980 Offset: 0x2709A81 VA: 0x2709980
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>.Dispose
	|
	|-RVA: 0x2709BA0 Offset: 0x2709CA1 VA: 0x2709BA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.Dispose
	|
	|-RVA: 0x2709DE0 Offset: 0x2709EE1 VA: 0x2709DE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>.Dispose
	|
	|-RVA: 0x270A000 Offset: 0x270A101 VA: 0x270A000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>.Dispose
	|
	|-RVA: 0x270A220 Offset: 0x270A321 VA: 0x270A220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>.Dispose
	|
	|-RVA: 0x270A440 Offset: 0x270A541 VA: 0x270A440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>.Dispose
	|
	|-RVA: 0x270A660 Offset: 0x270A761 VA: 0x270A660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>.Dispose
	|
	|-RVA: 0x270A880 Offset: 0x270A981 VA: 0x270A880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.Dispose
	|
	|-RVA: 0x270AAA0 Offset: 0x270ABA1 VA: 0x270AAA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.Dispose
	|
	|-RVA: 0x270ACC0 Offset: 0x270ADC1 VA: 0x270ACC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>.Dispose
	|
	|-RVA: 0x270AEE0 Offset: 0x270AFE1 VA: 0x270AEE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>.Dispose
	|
	|-RVA: 0x270B100 Offset: 0x270B201 VA: 0x270B100
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>.Dispose
	|
	|-RVA: 0x270B320 Offset: 0x270B421 VA: 0x270B320
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>.Dispose
	|
	|-RVA: 0x270B540 Offset: 0x270B641 VA: 0x270B540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>.Dispose
	|
	|-RVA: 0x270B760 Offset: 0x270B861 VA: 0x270B760
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.Dispose
	|
	|-RVA: 0x28C6740 Offset: 0x28C6841 VA: 0x28C6740
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.Dispose
	|
	|-RVA: 0x28C6950 Offset: 0x28C6A51 VA: 0x28C6950
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.Dispose
	|
	|-RVA: 0x28C6B60 Offset: 0x28C6C61 VA: 0x28C6B60
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.Dispose
	|
	|-RVA: 0x28C6D70 Offset: 0x28C6E71 VA: 0x28C6D70
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>.Dispose
	|
	|-RVA: 0x28C6F80 Offset: 0x28C7081 VA: 0x28C6F80
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x28C71A0 Offset: 0x28C72A1 VA: 0x28C71A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.Dispose
	|
	|-RVA: 0x28C73C0 Offset: 0x28C74C1 VA: 0x28C73C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>.Dispose
	|
	|-RVA: 0x28C75D0 Offset: 0x28C76D1 VA: 0x28C75D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>.Dispose
	|
	|-RVA: 0x28C77F0 Offset: 0x28C78F1 VA: 0x28C77F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.Dispose
	|
	|-RVA: 0x28C7A20 Offset: 0x28C7B21 VA: 0x28C7A20
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.Dispose
	|
	|-RVA: 0x28C7C40 Offset: 0x28C7D41 VA: 0x28C7C40
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.Dispose
	|
	|-RVA: 0x28C7E60 Offset: 0x28C7F61 VA: 0x28C7E60
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.Dispose
	|
	|-RVA: 0x28C8080 Offset: 0x28C8181 VA: 0x28C8080
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.Dispose
	|
	|-RVA: 0x28C82B0 Offset: 0x28C83B1 VA: 0x28C82B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.Dispose
	|
	|-RVA: 0x28C84D0 Offset: 0x28C85D1 VA: 0x28C84D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>.Dispose
	|
	|-RVA: 0x28C8700 Offset: 0x28C8801 VA: 0x28C8700
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.Dispose
	|
	|-RVA: 0x28C8930 Offset: 0x28C8A31 VA: 0x28C8930
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>.Dispose
	|
	|-RVA: 0x28C8B50 Offset: 0x28C8C51 VA: 0x28C8B50
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>.Dispose
	|
	|-RVA: 0x28C8D60 Offset: 0x28C8E61 VA: 0x28C8D60
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.Dispose
	|
	|-RVA: 0x28C8F70 Offset: 0x28C9071 VA: 0x28C8F70
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.Dispose
	|
	|-RVA: 0x28C9180 Offset: 0x28C9281 VA: 0x28C9180
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.Dispose
	|
	|-RVA: 0x28C9390 Offset: 0x28C9491 VA: 0x28C9390
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>.Dispose
	|
	|-RVA: 0x28C95A0 Offset: 0x28C96A1 VA: 0x28C95A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.Dispose
	|
	|-RVA: 0x28C97C0 Offset: 0x28C98C1 VA: 0x28C97C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>.Dispose
	|
	|-RVA: 0x28C99D0 Offset: 0x28C9AD1 VA: 0x28C99D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>.Dispose
	|
	|-RVA: 0x28C9BF0 Offset: 0x28C9CF1 VA: 0x28C9BF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>.Dispose
	|
	|-RVA: 0x28C9E10 Offset: 0x28C9F11 VA: 0x28C9E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.Dispose
	|
	|-RVA: 0x28CA020 Offset: 0x28CA121 VA: 0x28CA020
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.Dispose
	|
	|-RVA: 0x28CA260 Offset: 0x28CA361 VA: 0x28CA260
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>.Dispose
	|
	|-RVA: 0x28CA480 Offset: 0x28CA581 VA: 0x28CA480
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.Dispose
	|
	|-RVA: 0x28CA690 Offset: 0x28CA791 VA: 0x28CA690
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.Dispose
	|
	|-RVA: 0x28CA8A0 Offset: 0x28CA9A1 VA: 0x28CA8A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x28CAAB0 Offset: 0x28CABB1 VA: 0x28CAAB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.Dispose
	|
	|-RVA: 0x28CACC0 Offset: 0x28CADC1 VA: 0x28CACC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.Dispose
	|
	|-RVA: 0x28CAED0 Offset: 0x28CAFD1 VA: 0x28CAED0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x28CB0E0 Offset: 0x28CB1E1 VA: 0x28CB0E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.Dispose
	|
	|-RVA: 0x28CB310 Offset: 0x28CB411 VA: 0x28CB310
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>.Dispose
	|
	|-RVA: 0x28CB530 Offset: 0x28CB631 VA: 0x28CB530
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>.Dispose
	|
	|-RVA: 0x28CB740 Offset: 0x28CB841 VA: 0x28CB740
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>.Dispose
	|
	|-RVA: 0x28CB950 Offset: 0x28CBA51 VA: 0x28CB950
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.Dispose
	|
	|-RVA: 0x28CBB70 Offset: 0x28CBC71 VA: 0x28CBB70
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.Dispose
	|
	|-RVA: 0x28CBDA0 Offset: 0x28CBEA1 VA: 0x28CBDA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.Dispose
	|
	|-RVA: 0x28CBFC0 Offset: 0x28CC0C1 VA: 0x28CBFC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.Dispose
	|
	|-RVA: 0x28CC1D0 Offset: 0x28CC2D1 VA: 0x28CC1D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.Dispose
	|
	|-RVA: 0x28CC3E0 Offset: 0x28CC4E1 VA: 0x28CC3E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x28CC5F0 Offset: 0x28CC6F1 VA: 0x28CC5F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x28CC800 Offset: 0x28CC901 VA: 0x28CC800
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x28CCA10 Offset: 0x28CCB11 VA: 0x28CCA10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>.Dispose
	|
	|-RVA: 0x28CCC20 Offset: 0x28CCD21 VA: 0x28CCC20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.Dispose
	|
	|-RVA: 0x28CCE40 Offset: 0x28CCF41 VA: 0x28CCE40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.Dispose
	|
	|-RVA: 0x28CD050 Offset: 0x28CD151 VA: 0x28CD050
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.Dispose
	|
	|-RVA: 0x28CD260 Offset: 0x28CD361 VA: 0x28CD260
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.Dispose
	|
	|-RVA: 0x28CD470 Offset: 0x28CD571 VA: 0x28CD470
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>.Dispose
	|
	|-RVA: 0x28CD690 Offset: 0x28CD791 VA: 0x28CD690
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.Dispose
	|
	|-RVA: 0x28CD8A0 Offset: 0x28CD9A1 VA: 0x28CD8A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.Dispose
	|
	|-RVA: 0x28CDAD0 Offset: 0x28CDBD1 VA: 0x28CDAD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.Dispose
	|
	|-RVA: 0x28CDD00 Offset: 0x28CDE01 VA: 0x28CDD00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.Dispose
	|
	|-RVA: 0x28CDF10 Offset: 0x28CE011 VA: 0x28CDF10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>.Dispose
	|
	|-RVA: 0x28CE130 Offset: 0x28CE231 VA: 0x28CE130
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.Dispose
	|
	|-RVA: 0x28CE350 Offset: 0x28CE451 VA: 0x28CE350
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.Dispose
	|
	|-RVA: 0x28CE570 Offset: 0x28CE671 VA: 0x28CE570
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.Dispose
	|
	|-RVA: 0x28CE7A0 Offset: 0x28CE8A1 VA: 0x28CE7A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.Dispose
	|
	|-RVA: 0x28CE9B0 Offset: 0x28CEAB1 VA: 0x28CE9B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.Dispose
	|
	|-RVA: 0x28CEBF0 Offset: 0x28CECF1 VA: 0x28CEBF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.Dispose
	|
	|-RVA: 0x28CEE10 Offset: 0x28CEF11 VA: 0x28CEE10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.Dispose
	|
	|-RVA: 0x28CF030 Offset: 0x28CF131 VA: 0x28CF030
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.Dispose
	|
	|-RVA: 0x28CF250 Offset: 0x28CF351 VA: 0x28CF250
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.Dispose
	|
	|-RVA: 0x28CF470 Offset: 0x28CF571 VA: 0x28CF470
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.Dispose
	|
	|-RVA: 0x28CF690 Offset: 0x28CF791 VA: 0x28CF690
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.Dispose
	|
	|-RVA: 0x28CF8B0 Offset: 0x28CF9B1 VA: 0x28CF8B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.Dispose
	|
	|-RVA: 0x28CFAD0 Offset: 0x28CFBD1 VA: 0x28CFAD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.Dispose
	|
	|-RVA: 0x28CFCF0 Offset: 0x28CFDF1 VA: 0x28CFCF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.Dispose
	|
	|-RVA: 0x28CFF10 Offset: 0x28D0011 VA: 0x28CFF10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>.Dispose
	|
	|-RVA: 0x28D0120 Offset: 0x28D0221 VA: 0x28D0120
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>.Dispose
	|
	|-RVA: 0x28D0340 Offset: 0x28D0441 VA: 0x28D0340
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.Dispose
	|
	|-RVA: 0x28D0570 Offset: 0x28D0671 VA: 0x28D0570
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.Dispose
	|
	|-RVA: 0x28D0790 Offset: 0x28D0891 VA: 0x28D0790
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.Dispose
	|
	|-RVA: 0x28D09B0 Offset: 0x28D0AB1 VA: 0x28D09B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.Dispose
	|
	|-RVA: 0x28D0BD0 Offset: 0x28D0CD1 VA: 0x28D0BD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.Dispose
	|
	|-RVA: 0x28D0E00 Offset: 0x28D0F01 VA: 0x28D0E00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.Dispose
	|
	|-RVA: 0x28D1020 Offset: 0x28D1121 VA: 0x28D1020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>.Dispose
	|
	|-RVA: 0x28D1250 Offset: 0x28D1351 VA: 0x28D1250
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.Dispose
	|
	|-RVA: 0x28D1480 Offset: 0x28D1581 VA: 0x28D1480
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>.Dispose
	|
	|-RVA: 0x28D16A0 Offset: 0x28D17A1 VA: 0x28D16A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.Dispose
	|
	|-RVA: 0x28D18C0 Offset: 0x28D19C1 VA: 0x28D18C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.Dispose
	|
	|-RVA: 0x28D1AD0 Offset: 0x28D1BD1 VA: 0x28D1AD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.Dispose
	|
	|-RVA: 0x28D1CE0 Offset: 0x28D1DE1 VA: 0x28D1CE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>.Dispose
	|
	|-RVA: 0x28D1EF0 Offset: 0x28D1FF1 VA: 0x28D1EF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>.Dispose
	|
	|-RVA: 0x28D2100 Offset: 0x28D2201 VA: 0x28D2100
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>.Dispose
	|
	|-RVA: 0x28D2310 Offset: 0x28D2411 VA: 0x28D2310
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>.Dispose
	|
	|-RVA: 0x28D2520 Offset: 0x28D2621 VA: 0x28D2520
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x28D2730 Offset: 0x28D2831 VA: 0x28D2730
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x28D2940 Offset: 0x28D2A41 VA: 0x28D2940
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>.Dispose
	|
	|-RVA: 0x28D2B50 Offset: 0x28D2C51 VA: 0x28D2B50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>.Dispose
	|
	|-RVA: 0x28D2D70 Offset: 0x28D2E71 VA: 0x28D2D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.Dispose
	|
	|-RVA: 0x28D2F80 Offset: 0x28D3081 VA: 0x28D2F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.Dispose
	|
	|-RVA: 0x28D31B0 Offset: 0x28D32B1 VA: 0x28D31B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.Dispose
	|
	|-RVA: 0x28D33E0 Offset: 0x28D34E1 VA: 0x28D33E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.Dispose
	|
	|-RVA: 0x28D35F0 Offset: 0x28D36F1 VA: 0x28D35F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>.Dispose
	|
	|-RVA: 0x28D3810 Offset: 0x28D3911 VA: 0x28D3810
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.Dispose
	|
	|-RVA: 0x28D3A30 Offset: 0x28D3B31 VA: 0x28D3A30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.Dispose
	|
	|-RVA: 0x28D3C50 Offset: 0x28D3D51 VA: 0x28D3C50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.Dispose
	|
	|-RVA: 0x28D3E80 Offset: 0x28D3F81 VA: 0x28D3E80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.Dispose
	|
	|-RVA: 0x28D4090 Offset: 0x28D4191 VA: 0x28D4090
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.Dispose
	|
	|-RVA: 0x28D42D0 Offset: 0x28D43D1 VA: 0x28D42D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.Dispose
	|
	|-RVA: 0x28D44F0 Offset: 0x28D45F1 VA: 0x28D44F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.Dispose
	|
	|-RVA: 0x28D4710 Offset: 0x28D4811 VA: 0x28D4710
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.Dispose
	|
	|-RVA: 0x28D4930 Offset: 0x28D4A31 VA: 0x28D4930
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.Dispose
	|
	|-RVA: 0x28D4B50 Offset: 0x28D4C51 VA: 0x28D4B50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.Dispose
	|
	|-RVA: 0x28D4D70 Offset: 0x28D4E71 VA: 0x28D4D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.Dispose
	|
	|-RVA: 0x28D4F90 Offset: 0x28D5091 VA: 0x28D4F90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.Dispose
	|
	|-RVA: 0x28D51B0 Offset: 0x28D52B1 VA: 0x28D51B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.Dispose
	|
	|-RVA: 0x28D53D0 Offset: 0x28D54D1 VA: 0x28D53D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.Dispose
	|
	|-RVA: 0x28D55F0 Offset: 0x28D56F1 VA: 0x28D55F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x28D5800 Offset: 0x28D5901 VA: 0x28D5800
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.Dispose
	|
	|-RVA: 0x28D5A20 Offset: 0x28D5B21 VA: 0x28D5A20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.Dispose
	|
	|-RVA: 0x28D5C40 Offset: 0x28D5D41 VA: 0x28D5C40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>.Dispose
	|
	|-RVA: 0x28D5E50 Offset: 0x28D5F51 VA: 0x28D5E50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.Dispose
	|
	|-RVA: 0x28D6060 Offset: 0x28D6161 VA: 0x28D6060
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.Dispose
	|
	|-RVA: 0x28D6270 Offset: 0x28D6371 VA: 0x28D6270
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>.Dispose
	|
	|-RVA: 0x28D6480 Offset: 0x28D6581 VA: 0x28D6480
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>.Dispose
	|
	|-RVA: 0x28D6690 Offset: 0x28D6791 VA: 0x28D6690
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>.Dispose
	|
	|-RVA: 0x28D68C0 Offset: 0x28D69C1 VA: 0x28D68C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>.Dispose
	|
	|-RVA: 0x28D6AE0 Offset: 0x28D6BE1 VA: 0x28D6AE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>.Dispose
	|
	|-RVA: 0x28D6D00 Offset: 0x28D6E01 VA: 0x28D6D00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>.Dispose
	|
	|-RVA: 0x28D6F10 Offset: 0x28D7011 VA: 0x28D6F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>.Dispose
	|
	|-RVA: 0x28D7130 Offset: 0x28D7231 VA: 0x28D7130
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x28D7340 Offset: 0x28D7441 VA: 0x28D7340
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>.Dispose
	|
	|-RVA: 0x28D7560 Offset: 0x28D7661 VA: 0x28D7560
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>.Dispose
	|
	|-RVA: 0x28D7790 Offset: 0x28D7891 VA: 0x28D7790
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>.Dispose
	|
	|-RVA: 0x28D79A0 Offset: 0x28D7AA1 VA: 0x28D79A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>.Dispose
	|
	|-RVA: 0x28D7BE0 Offset: 0x28D7CE1 VA: 0x28D7BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.Dispose
	|
	|-RVA: 0x28D7E00 Offset: 0x28D7F01 VA: 0x28D7E00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>.Dispose
	|
	|-RVA: 0x28D8020 Offset: 0x28D8121 VA: 0x28D8020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>.Dispose
	|
	|-RVA: 0x28D8230 Offset: 0x28D8331 VA: 0x28D8230
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>.Dispose
	|
	|-RVA: 0x28D8450 Offset: 0x28D8551 VA: 0x28D8450
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>.Dispose
	|
	|-RVA: 0x28D8670 Offset: 0x28D8771 VA: 0x28D8670
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x28D8890 Offset: 0x28D8991 VA: 0x28D8890
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.Dispose
	|
	|-RVA: 0x28D8AB0 Offset: 0x28D8BB1 VA: 0x28D8AB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>.Dispose
	|
	|-RVA: 0x28D8CC0 Offset: 0x28D8DC1 VA: 0x28D8CC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>.Dispose
	|
	|-RVA: 0x28D8ED0 Offset: 0x28D8FD1 VA: 0x28D8ED0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>.Dispose
	|
	|-RVA: 0x28D90F0 Offset: 0x28D91F1 VA: 0x28D90F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>.Dispose
	|
	|-RVA: 0x28D9310 Offset: 0x28D9411 VA: 0x28D9310
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>.Dispose
	|
	|-RVA: 0x28D9530 Offset: 0x28D9631 VA: 0x28D9530
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.Dispose
	|
	|-RVA: 0x28D9750 Offset: 0x28D9851 VA: 0x28D9750
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.Dispose
	|
	|-RVA: 0x28D9960 Offset: 0x28D9A61 VA: 0x28D9960
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.Dispose
	|
	|-RVA: 0x28D9B70 Offset: 0x28D9C71 VA: 0x28D9B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>.Dispose
	|
	|-RVA: 0x28D9DB0 Offset: 0x28D9EB1 VA: 0x28D9DB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>.Dispose
	|
	|-RVA: 0x28D9FC0 Offset: 0x28DA0C1 VA: 0x28D9FC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>.Dispose
	|
	|-RVA: 0x28DA1D0 Offset: 0x28DA2D1 VA: 0x28DA1D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.Dispose
	|
	|-RVA: 0x28DA3E0 Offset: 0x28DA4E1 VA: 0x28DA3E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>.Dispose
	|
	|-RVA: 0x28DA5F0 Offset: 0x28DA6F1 VA: 0x28DA5F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x28DA800 Offset: 0x28DA901 VA: 0x28DA800
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.Dispose
	|
	|-RVA: 0x28DAA10 Offset: 0x28DAB11 VA: 0x28DAA10
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.Dispose
	|
	|-RVA: 0x28DAC20 Offset: 0x28DAD21 VA: 0x28DAC20
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.Dispose
	|
	|-RVA: 0x28DAE50 Offset: 0x28DAF51 VA: 0x28DAE50
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.Dispose
	|
	|-RVA: 0x28DB080 Offset: 0x28DB181 VA: 0x28DB080
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.Dispose
	|
	|-RVA: 0x28DB2B0 Offset: 0x28DB3B1 VA: 0x28DB2B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.Dispose
	|
	|-RVA: 0x28DB4C0 Offset: 0x28DB5C1 VA: 0x28DB4C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.Dispose
	|
	|-RVA: 0x28DB6D0 Offset: 0x28DB7D1 VA: 0x28DB6D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>.Dispose
	|
	|-RVA: 0x28DB8F0 Offset: 0x28DB9F1 VA: 0x28DB8F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>.Dispose
	|
	|-RVA: 0x28DBB10 Offset: 0x28DBC11 VA: 0x28DBB10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>.Dispose
	|
	|-RVA: 0x28DBD30 Offset: 0x28DBE31 VA: 0x28DBD30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>.Dispose
	|
	|-RVA: 0x28DBF40 Offset: 0x28DC041 VA: 0x28DBF40
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.Dispose
	|
	|-RVA: 0x28DC150 Offset: 0x28DC251 VA: 0x28DC150
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.Dispose
	|
	|-RVA: 0x28DC360 Offset: 0x28DC461 VA: 0x28DC360
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>.Dispose
	|
	|-RVA: 0x28DC580 Offset: 0x28DC681 VA: 0x28DC580
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>.Dispose
	|
	|-RVA: 0x28DC7B0 Offset: 0x28DC8B1 VA: 0x28DC7B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>.Dispose
	|
	|-RVA: 0x28DC9C0 Offset: 0x28DCAC1 VA: 0x28DC9C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>.Dispose
	|
	|-RVA: 0x28DCC00 Offset: 0x28DCD01 VA: 0x28DCC00
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>.Dispose
	|
	|-RVA: 0x28DCE20 Offset: 0x28DCF21 VA: 0x28DCE20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>.Dispose
	|
	|-RVA: 0x28DD040 Offset: 0x28DD141 VA: 0x28DD040
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>.Dispose
	|
	|-RVA: 0x28DD250 Offset: 0x28DD351 VA: 0x28DD250
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>.Dispose
	|
	|-RVA: 0x28DD470 Offset: 0x28DD571 VA: 0x28DD470
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>.Dispose
	|
	|-RVA: 0x28DD690 Offset: 0x28DD791 VA: 0x28DD690
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.Dispose
	|
	|-RVA: 0x28DD8A0 Offset: 0x28DD9A1 VA: 0x28DD8A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.Dispose
	|
	|-RVA: 0x28DDAB0 Offset: 0x28DDBB1 VA: 0x28DDAB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>.Dispose
	|
	|-RVA: 0x28DDCC0 Offset: 0x28DDDC1 VA: 0x28DDCC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>.Dispose
	|
	|-RVA: 0x28DDED0 Offset: 0x28DDFD1 VA: 0x28DDED0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>.Dispose
	|
	|-RVA: 0x28DE0F0 Offset: 0x28DE1F1 VA: 0x28DE0F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>.Dispose
	|
	|-RVA: 0x28DE310 Offset: 0x28DE411 VA: 0x28DE310
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>.Dispose
	|
	|-RVA: 0x28DE530 Offset: 0x28DE631 VA: 0x28DE530
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.Dispose
	|
	|-RVA: 0x28DE750 Offset: 0x28DE851 VA: 0x28DE750
	|-Array.EmptyInternalEnumerator<DateTime>.Dispose
	|
	|-RVA: 0x28DE960 Offset: 0x28DEA61 VA: 0x28DE960
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.Dispose
	|
	|-RVA: 0x28DEB70 Offset: 0x28DEC71 VA: 0x28DEB70
	|-Array.EmptyInternalEnumerator<Decimal>.Dispose
	|
	|-RVA: 0x28DED80 Offset: 0x28DEE81 VA: 0x28DED80
	|-Array.EmptyInternalEnumerator<double>.Dispose
	|
	|-RVA: 0x28DEF90 Offset: 0x28DF091 VA: 0x28DEF90
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.Dispose
	|
	|-RVA: 0x28DF1A0 Offset: 0x28DF2A1 VA: 0x28DF1A0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.Dispose
	|
	|-RVA: 0x273E7E0 Offset: 0x273E8E1 VA: 0x273E7E0
	|-Array.EmptyInternalEnumerator<Guid>.Dispose
	|
	|-RVA: 0x273E9F0 Offset: 0x273EAF1 VA: 0x273E9F0
	|-Array.EmptyInternalEnumerator<short>.Dispose
	|
	|-RVA: 0x273EC00 Offset: 0x273ED01 VA: 0x273EC00
	|-Array.EmptyInternalEnumerator<int>.Dispose
	|
	|-RVA: 0x273EE10 Offset: 0x273EF11 VA: 0x273EE10
	|-Array.EmptyInternalEnumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x273F020 Offset: 0x273F121 VA: 0x273F020
	|-Array.EmptyInternalEnumerator<long>.Dispose
	|
	|-RVA: 0x273F230 Offset: 0x273F331 VA: 0x273F230
	|-Array.EmptyInternalEnumerator<IntPtr>.Dispose
	|
	|-RVA: 0x273F440 Offset: 0x273F541 VA: 0x273F440
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.Dispose
	|
	|-RVA: 0x273F650 Offset: 0x273F751 VA: 0x273F650
	|-Array.EmptyInternalEnumerator<LocalDefinition>.Dispose
	|
	|-RVA: 0x273F860 Offset: 0x273F961 VA: 0x273F860
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.Dispose
	|
	|-RVA: 0x273FA70 Offset: 0x273FB71 VA: 0x273FA70
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>.Dispose
	|
	|-RVA: 0x273FC80 Offset: 0x273FD81 VA: 0x273FC80
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.Dispose
	|
	|-RVA: 0x273FEA0 Offset: 0x273FFA1 VA: 0x273FEA0
	|-Array.EmptyInternalEnumerator<Memory<object>>.Dispose
	|
	|-RVA: 0x27400B0 Offset: 0x27401B1 VA: 0x27400B0
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.Dispose
	|
	|-RVA: 0x27402C0 Offset: 0x27403C1 VA: 0x27402C0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.Dispose
	|
	|-RVA: 0x27404D0 Offset: 0x27405D1 VA: 0x27404D0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.Dispose
	|
	|-RVA: 0x27406E0 Offset: 0x27407E1 VA: 0x27406E0
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>.Dispose
	|
	|-RVA: 0x2740910 Offset: 0x2740A11 VA: 0x2740910
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>.Dispose
	|
	|-RVA: 0x2740B20 Offset: 0x2740C21 VA: 0x2740B20
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>.Dispose
	|
	|-RVA: 0x2740D50 Offset: 0x2740E51 VA: 0x2740D50
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>.Dispose
	|
	|-RVA: 0x2740F80 Offset: 0x2741081 VA: 0x2740F80
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>.Dispose
	|
	|-RVA: 0x2741190 Offset: 0x2741291 VA: 0x2741190
	|-Array.EmptyInternalEnumerator<Nullable<Color>>.Dispose
	|
	|-RVA: 0x27413B0 Offset: 0x27414B1 VA: 0x27413B0
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>.Dispose
	|
	|-RVA: 0x27415C0 Offset: 0x27416C1 VA: 0x27415C0
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>.Dispose
	|
	|-RVA: 0x27417E0 Offset: 0x27418E1 VA: 0x27417E0
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>.Dispose
	|
	|-RVA: 0x2741A00 Offset: 0x2741B01 VA: 0x2741A00
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>.Dispose
	|
	|-RVA: 0x2741C10 Offset: 0x2741D11 VA: 0x2741C10
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>.Dispose
	|
	|-RVA: 0x2741E50 Offset: 0x2741F51 VA: 0x2741E50
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>.Dispose
	|
	|-RVA: 0x2742070 Offset: 0x2742171 VA: 0x2742070
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>.Dispose
	|
	|-RVA: 0x2742280 Offset: 0x2742381 VA: 0x2742280
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>.Dispose
	|
	|-RVA: 0x27424A0 Offset: 0x27425A1 VA: 0x27424A0
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>.Dispose
	|
	|-RVA: 0x27426C0 Offset: 0x27427C1 VA: 0x27426C0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>.Dispose
	|
	|-RVA: 0x27428D0 Offset: 0x27429D1 VA: 0x27428D0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>.Dispose
	|
	|-RVA: 0x2742AE0 Offset: 0x2742BE1 VA: 0x2742AE0
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>.Dispose
	|
	|-RVA: 0x2742CF0 Offset: 0x2742DF1 VA: 0x2742CF0
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>.Dispose
	|
	|-RVA: 0x2742F00 Offset: 0x2743001 VA: 0x2742F00
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>.Dispose
	|
	|-RVA: 0x2743120 Offset: 0x2743221 VA: 0x2743120
	|-Array.EmptyInternalEnumerator<object>.Dispose
	|
	|-RVA: 0x27432F0 Offset: 0x27433F1 VA: 0x27432F0
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.Dispose
	|
	|-RVA: 0x2743500 Offset: 0x2743601 VA: 0x2743500
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>.Dispose
	|
	|-RVA: 0x2743710 Offset: 0x2743811 VA: 0x2743710
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.Dispose
	|
	|-RVA: 0x2743930 Offset: 0x2743A31 VA: 0x2743930
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.Dispose
	|
	|-RVA: 0x2743B40 Offset: 0x2743C41 VA: 0x2743B40
	|-Array.EmptyInternalEnumerator<Label>.Dispose
	|
	|-RVA: 0x2743D50 Offset: 0x2743E51 VA: 0x2743D50
	|-Array.EmptyInternalEnumerator<ParameterModifier>.Dispose
	|
	|-RVA: 0x2743F60 Offset: 0x2744061 VA: 0x2743F60
	|-Array.EmptyInternalEnumerator<ResourceLocator>.Dispose
	|
	|-RVA: 0x2744170 Offset: 0x2744271 VA: 0x2744170
	|-Array.EmptyInternalEnumerator<Ephemeron>.Dispose
	|
	|-RVA: 0x2744380 Offset: 0x2744481 VA: 0x2744380
	|-Array.EmptyInternalEnumerator<GCHandle>.Dispose
	|
	|-RVA: 0x2744590 Offset: 0x2744691 VA: 0x2744590
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>.Dispose
	|
	|-RVA: 0x27447A0 Offset: 0x27448A1 VA: 0x27447A0
	|-Array.EmptyInternalEnumerator<sbyte>.Dispose
	|
	|-RVA: 0x27449B0 Offset: 0x2744AB1 VA: 0x27449B0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.Dispose
	|
	|-RVA: 0x2744BC0 Offset: 0x2744CC1 VA: 0x2744BC0
	|-Array.EmptyInternalEnumerator<float>.Dispose
	|
	|-RVA: 0x2744DD0 Offset: 0x2744ED1 VA: 0x2744DD0
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.Dispose
	|
	|-RVA: 0x2744FE0 Offset: 0x27450E1 VA: 0x2744FE0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.Dispose
	|
	|-RVA: 0x2745200 Offset: 0x2745301 VA: 0x2745200
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.Dispose
	|
	|-RVA: 0x2745410 Offset: 0x2745511 VA: 0x2745410
	|-Array.EmptyInternalEnumerator<TimeSpan>.Dispose
	|
	|-RVA: 0x2745620 Offset: 0x2745721 VA: 0x2745620
	|-Array.EmptyInternalEnumerator<ushort>.Dispose
	|
	|-RVA: 0x2745830 Offset: 0x2745931 VA: 0x2745830
	|-Array.EmptyInternalEnumerator<UInt16Enum>.Dispose
	|
	|-RVA: 0x2745A40 Offset: 0x2745B41 VA: 0x2745A40
	|-Array.EmptyInternalEnumerator<uint>.Dispose
	|
	|-RVA: 0x2745C50 Offset: 0x2745D51 VA: 0x2745C50
	|-Array.EmptyInternalEnumerator<UInt32Enum>.Dispose
	|
	|-RVA: 0x2745E60 Offset: 0x2745F61 VA: 0x2745E60
	|-Array.EmptyInternalEnumerator<ulong>.Dispose
	|
	|-RVA: 0x2746070 Offset: 0x2746171 VA: 0x2746070
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>.Dispose
	|
	|-RVA: 0x2746280 Offset: 0x2746381 VA: 0x2746280
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2746490 Offset: 0x2746591 VA: 0x2746490
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x27466A0 Offset: 0x27467A1 VA: 0x27466A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x27468B0 Offset: 0x27469B1 VA: 0x27468B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x2746AC0 Offset: 0x2746BC1 VA: 0x2746AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.Dispose
	|
	|-RVA: 0x2746CD0 Offset: 0x2746DD1 VA: 0x2746CD0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>.Dispose
	|
	|-RVA: 0x2746EE0 Offset: 0x2746FE1 VA: 0x2746EE0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>.Dispose
	|
	|-RVA: 0x27470F0 Offset: 0x27471F1 VA: 0x27470F0
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>.Dispose
	|
	|-RVA: 0x2747320 Offset: 0x2747421 VA: 0x2747320
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x2747530 Offset: 0x2747631 VA: 0x2747530
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>.Dispose
	|
	|-RVA: 0x2747750 Offset: 0x2747851 VA: 0x2747750
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>.Dispose
	|
	|-RVA: 0x2747970 Offset: 0x2747A71 VA: 0x2747970
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Dispose
	|
	|-RVA: 0x2747BA0 Offset: 0x2747CA1 VA: 0x2747BA0
	|-Array.EmptyInternalEnumerator<HighlightState>.Dispose
	|
	|-RVA: 0x2747DC0 Offset: 0x2747EC1 VA: 0x2747DC0
	|-Array.EmptyInternalEnumerator<MaterialReference>.Dispose
	|
	|-RVA: 0x2747FF0 Offset: 0x27480F1 VA: 0x2747FF0
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.Dispose
	|
	|-RVA: 0x2748210 Offset: 0x2748311 VA: 0x2748210
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.Dispose
	|
	|-RVA: 0x2748440 Offset: 0x2748541 VA: 0x2748440
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.Dispose
	|
	|-RVA: 0x2748660 Offset: 0x2748761 VA: 0x2748660
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.Dispose
	|
	|-RVA: 0x2748870 Offset: 0x2748971 VA: 0x2748870
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.Dispose
	|
	|-RVA: 0x2748AC0 Offset: 0x2748BC1 VA: 0x2748AC0
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.Dispose
	|
	|-RVA: 0x2748CF0 Offset: 0x2748DF1 VA: 0x2748CF0
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.Dispose
	|
	|-RVA: 0x2748F30 Offset: 0x2749031 VA: 0x2748F30
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.Dispose
	|
	|-RVA: 0x2749150 Offset: 0x2749251 VA: 0x2749150
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.Dispose
	|
	|-RVA: 0x2749360 Offset: 0x2749461 VA: 0x2749360
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.Dispose
	|
	|-RVA: 0x2749580 Offset: 0x2749681 VA: 0x2749580
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.Dispose
	|
	|-RVA: 0x27497A0 Offset: 0x27498A1 VA: 0x27497A0
	|-Array.EmptyInternalEnumerator<WordWrapState>.Dispose
	|
	|-RVA: 0x27499C0 Offset: 0x2749AC1 VA: 0x27499C0
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>.Dispose
	|
	|-RVA: 0x2749BF0 Offset: 0x2749CF1 VA: 0x2749BF0
	|-Array.EmptyInternalEnumerator<TransitionTables>.Dispose
	|
	|-RVA: 0x2749E10 Offset: 0x2749F11 VA: 0x2749E10
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>.Dispose
	|
	|-RVA: 0x274A020 Offset: 0x274A121 VA: 0x274A020
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>.Dispose
	|
	|-RVA: 0x274A230 Offset: 0x274A331 VA: 0x274A230
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>.Dispose
	|
	|-RVA: 0x274A440 Offset: 0x274A541 VA: 0x274A440
	|-Array.EmptyInternalEnumerator<CapEdge>.Dispose
	|
	|-RVA: 0x274A670 Offset: 0x274A771 VA: 0x274A670
	|-Array.EmptyInternalEnumerator<ClippedEdge>.Dispose
	|
	|-RVA: 0x274A890 Offset: 0x274A991 VA: 0x274A890
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>.Dispose
	|
	|-RVA: 0x274AAA0 Offset: 0x274ABA1 VA: 0x274AAA0
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>.Dispose
	|
	|-RVA: 0x274ACB0 Offset: 0x274ADB1 VA: 0x274ACB0
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>.Dispose
	|
	|-RVA: 0x274AEC0 Offset: 0x274AFC1 VA: 0x274AEC0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.Dispose
	|
	|-RVA: 0x274B0E0 Offset: 0x274B1E1 VA: 0x274B0E0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>.Dispose
	|
	|-RVA: 0x274B310 Offset: 0x274B411 VA: 0x274B310
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>.Dispose
	|
	|-RVA: 0x274B520 Offset: 0x274B621 VA: 0x274B520
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>.Dispose
	|
	|-RVA: 0x274B770 Offset: 0x274B871 VA: 0x274B770
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.Dispose
	|
	|-RVA: 0x274B980 Offset: 0x274BA81 VA: 0x274B980
	|-Array.EmptyInternalEnumerator<ConstraintSource>.Dispose
	|
	|-RVA: 0x274BB90 Offset: 0x274BC91 VA: 0x274BB90
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>.Dispose
	|
	|-RVA: 0x274BDA0 Offset: 0x274BEA1 VA: 0x274BDA0
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>.Dispose
	|
	|-RVA: 0x274BFB0 Offset: 0x274C0B1 VA: 0x274BFB0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.Dispose
	|
	|-RVA: 0x274C1C0 Offset: 0x274C2C1 VA: 0x274C1C0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|
	|-RVA: 0x274C3D0 Offset: 0x274C4D1 VA: 0x274C3D0
	|-Array.EmptyInternalEnumerator<BoneWeight1>.Dispose
	|
	|-RVA: 0x274C5E0 Offset: 0x274C6E1 VA: 0x274C5E0
	|-Array.EmptyInternalEnumerator<BoneWeight>.Dispose
	|
	|-RVA: 0x274C800 Offset: 0x274C901 VA: 0x274C800
	|-Array.EmptyInternalEnumerator<BoundingSphere>.Dispose
	|
	|-RVA: 0x274CA10 Offset: 0x274CB11 VA: 0x274CA10
	|-Array.EmptyInternalEnumerator<Bounds>.Dispose
	|
	|-RVA: 0x274CC30 Offset: 0x274CD31 VA: 0x274CC30
	|-Array.EmptyInternalEnumerator<BoundsInt>.Dispose
	|
	|-RVA: 0x274CE50 Offset: 0x274CF51 VA: 0x274CE50
	|-Array.EmptyInternalEnumerator<CharacterInfo>.Dispose
	|
	|-RVA: 0x274D080 Offset: 0x274D181 VA: 0x274D080
	|-Array.EmptyInternalEnumerator<Color32>.Dispose
	|
	|-RVA: 0x274D290 Offset: 0x274D391 VA: 0x274D290
	|-Array.EmptyInternalEnumerator<Color>.Dispose
	|
	|-RVA: 0x274D4A0 Offset: 0x274D5A1 VA: 0x274D4A0
	|-Array.EmptyInternalEnumerator<CombineInstance>.Dispose
	|
	|-RVA: 0x274D6F0 Offset: 0x274D7F1 VA: 0x274D6F0
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.Dispose
	|
	|-RVA: 0x274D920 Offset: 0x274DA21 VA: 0x274D920
	|-Array.EmptyInternalEnumerator<ContactPoint>.Dispose
	|
	|-RVA: 0x274DB50 Offset: 0x274DC51 VA: 0x274DB50
	|-Array.EmptyInternalEnumerator<RaycastResult>.Dispose
	|
	|-RVA: 0x274DD90 Offset: 0x274DE91 VA: 0x274DD90
	|-Array.EmptyInternalEnumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x274DFD0 Offset: 0x274E0D1 VA: 0x274DFD0
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.Dispose
	|
	|-RVA: 0x274E1E0 Offset: 0x274E2E1 VA: 0x274E1E0
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>.Dispose
	|
	|-RVA: 0x274E3F0 Offset: 0x274E4F1 VA: 0x274E3F0
	|-Array.EmptyInternalEnumerator<GradientColorKey>.Dispose
	|
	|-RVA: 0x274E610 Offset: 0x274E711 VA: 0x274E610
	|-Array.EmptyInternalEnumerator<HumanBone>.Dispose
	|
	|-RVA: 0x274E840 Offset: 0x274E941 VA: 0x274E840
	|-Array.EmptyInternalEnumerator<Keyframe>.Dispose
	|
	|-RVA: 0x274EA70 Offset: 0x274EB71 VA: 0x274EA70
	|-Array.EmptyInternalEnumerator<LOD>.Dispose
	|
	|-RVA: 0x274EC80 Offset: 0x274ED81 VA: 0x274EC80
	|-Array.EmptyInternalEnumerator<LayerMask>.Dispose
	|
	|-RVA: 0x274EE90 Offset: 0x274EF91 VA: 0x274EE90
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.Dispose
	|
	|-RVA: 0x274F0C0 Offset: 0x274F1C1 VA: 0x274F0C0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x274F2F0 Offset: 0x274F3F1 VA: 0x274F2F0
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x274F510 Offset: 0x274F611 VA: 0x274F510
	|-Array.EmptyInternalEnumerator<PatchExtents>.Dispose
	|
	|-RVA: 0x274F720 Offset: 0x274F821 VA: 0x274F720
	|-Array.EmptyInternalEnumerator<Plane>.Dispose
	|
	|-RVA: 0x274F930 Offset: 0x274FA31 VA: 0x274F930
	|-Array.EmptyInternalEnumerator<Playable>.Dispose
	|
	|-RVA: 0x274FB40 Offset: 0x274FC41 VA: 0x274FB40
	|-Array.EmptyInternalEnumerator<PlayableBinding>.Dispose
	|
	|-RVA: 0x274FD60 Offset: 0x274FE61 VA: 0x274FD60
	|-Array.EmptyInternalEnumerator<PlayableGraph>.Dispose
	|
	|-RVA: 0x274FF70 Offset: 0x2750071 VA: 0x274FF70
	|-Array.EmptyInternalEnumerator<Edge>.Dispose
	|
	|-RVA: 0x2750180 Offset: 0x2750281 VA: 0x2750180
	|-Array.EmptyInternalEnumerator<IntVec3>.Dispose
	|
	|-RVA: 0x2750390 Offset: 0x2750491 VA: 0x2750390
	|-Array.EmptyInternalEnumerator<Quaternion>.Dispose
	|
	|-RVA: 0x27505A0 Offset: 0x27506A1 VA: 0x27505A0
	|-Array.EmptyInternalEnumerator<RangeInt>.Dispose
	|
	|-RVA: 0x27507B0 Offset: 0x27508B1 VA: 0x27507B0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.Dispose
	|
	|-RVA: 0x27509E0 Offset: 0x2750AE1 VA: 0x27509E0
	|-Array.EmptyInternalEnumerator<RaycastHit>.Dispose
	|
	|-RVA: 0x2750C10 Offset: 0x2750D11 VA: 0x2750C10
	|-Array.EmptyInternalEnumerator<Rect>.Dispose
	|
	|-RVA: 0x2750E20 Offset: 0x2750F21 VA: 0x2750E20
	|-Array.EmptyInternalEnumerator<RectInt>.Dispose
	|
	|-RVA: 0x2751030 Offset: 0x2751131 VA: 0x2751030
	|-Array.EmptyInternalEnumerator<RenderBuffer>.Dispose
	|
	|-RVA: 0x2751240 Offset: 0x2751341 VA: 0x2751240
	|-Array.EmptyInternalEnumerator<BatchVisibility>.Dispose
	|
	|-RVA: 0x2751450 Offset: 0x2751551 VA: 0x2751450
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>.Dispose
	|
	|-RVA: 0x2751660 Offset: 0x2751761 VA: 0x2751660
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.Dispose
	|
	|-RVA: 0x27518B0 Offset: 0x27519B1 VA: 0x27518B0
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x2751AC0 Offset: 0x2751BC1 VA: 0x2751AC0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2751CE0 Offset: 0x2751DE1 VA: 0x2751CE0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x2751F00 Offset: 0x2752001 VA: 0x2751F00
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>.Dispose
	|
	|-RVA: 0x2752120 Offset: 0x2752221 VA: 0x2752120
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.Dispose
	|
	|-RVA: 0x2752350 Offset: 0x2752451 VA: 0x2752350
	|-Array.EmptyInternalEnumerator<SceneInstance>.Dispose
	|
	|-RVA: 0x2752560 Offset: 0x2752661 VA: 0x2752560
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.Dispose
	|
	|-RVA: 0x2752780 Offset: 0x2752881 VA: 0x2752780
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.Dispose
	|
	|-RVA: 0x27529B0 Offset: 0x2752AB1 VA: 0x27529B0
	|-Array.EmptyInternalEnumerator<SerializedType>.Dispose
	|
	|-RVA: 0x2752BD0 Offset: 0x2752CD1 VA: 0x2752BD0
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.Dispose
	|
	|-RVA: 0x2752DE0 Offset: 0x2752EE1 VA: 0x2752DE0
	|-Array.EmptyInternalEnumerator<SkeletonBone>.Dispose
	|
	|-RVA: 0x2753010 Offset: 0x2753111 VA: 0x2753010
	|-Array.EmptyInternalEnumerator<GlyphRect>.Dispose
	|
	|-RVA: 0x2753220 Offset: 0x2753321 VA: 0x2753220
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.Dispose
	|
	|-RVA: 0x2753450 Offset: 0x2753551 VA: 0x2753450
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.Dispose
	|
	|-RVA: 0x2753680 Offset: 0x2753781 VA: 0x2753680
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.Dispose
	|
	|-RVA: 0x27538B0 Offset: 0x27539B1 VA: 0x27538B0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.Dispose
	|
	|-RVA: 0x2753AD0 Offset: 0x2753BD1 VA: 0x2753AD0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.Dispose
	|
	|-RVA: 0x2753CF0 Offset: 0x2753DF1 VA: 0x2753CF0
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.Dispose
	|
	|-RVA: 0x2753F10 Offset: 0x2754011 VA: 0x2753F10
	|-Array.EmptyInternalEnumerator<Touch>.Dispose
	|
	|-RVA: 0x2754150 Offset: 0x2754251 VA: 0x2754150
	|-Array.EmptyInternalEnumerator<TreeInstance>.Dispose
	|
	|-RVA: 0x2754380 Offset: 0x2754481 VA: 0x2754380
	|-Array.EmptyInternalEnumerator<ColorBlock>.Dispose
	|
	|-RVA: 0x27545C0 Offset: 0x27546C1 VA: 0x27545C0
	|-Array.EmptyInternalEnumerator<Navigation>.Dispose
	|
	|-RVA: 0x27547F0 Offset: 0x27548F1 VA: 0x27547F0
	|-Array.EmptyInternalEnumerator<SpriteState>.Dispose
	|
	|-RVA: 0x2754A10 Offset: 0x2754B11 VA: 0x2754A10
	|-Array.EmptyInternalEnumerator<UICharInfo>.Dispose
	|
	|-RVA: 0x2754C20 Offset: 0x2754D21 VA: 0x2754C20
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>.Dispose
	|
	|-RVA: 0x2754E30 Offset: 0x2754F31 VA: 0x2754E30
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>.Dispose
	|
	|-RVA: 0x2755040 Offset: 0x2755141 VA: 0x2755040
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>.Dispose
	|
	|-RVA: 0x2755250 Offset: 0x2755351 VA: 0x2755250
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>.Dispose
	|
	|-RVA: 0x2755460 Offset: 0x2755561 VA: 0x2755460
	|-Array.EmptyInternalEnumerator<StyleValue>.Dispose
	|
	|-RVA: 0x2755680 Offset: 0x2755781 VA: 0x2755680
	|-Array.EmptyInternalEnumerator<UILineInfo>.Dispose
	|
	|-RVA: 0x2755890 Offset: 0x2755991 VA: 0x2755890
	|-Array.EmptyInternalEnumerator<UIVertex>.Dispose
	|
	|-RVA: 0x2755AD0 Offset: 0x2755BD1 VA: 0x2755AD0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|
	|-RVA: 0x2755CF0 Offset: 0x2755DF1 VA: 0x2755CF0
	|-Array.EmptyInternalEnumerator<Vector2>.Dispose
	|
	|-RVA: 0x2755F00 Offset: 0x2756001 VA: 0x2755F00
	|-Array.EmptyInternalEnumerator<Vector2Int>.Dispose
	|
	|-RVA: 0x2756110 Offset: 0x2756211 VA: 0x2756110
	|-Array.EmptyInternalEnumerator<Vector3>.Dispose
	|
	|-RVA: 0x2756320 Offset: 0x2756421 VA: 0x2756320
	|-Array.EmptyInternalEnumerator<Vector3Int>.Dispose
	|
	|-RVA: 0x2756530 Offset: 0x2756631 VA: 0x2756530
	|-Array.EmptyInternalEnumerator<Vector4>.Dispose
	|
	|-RVA: 0x2756740 Offset: 0x2756841 VA: 0x2756740
	|-Array.EmptyInternalEnumerator<jvalue>.Dispose
	|
	|-RVA: 0x2756950 Offset: 0x2756A51 VA: 0x2756950
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>.Dispose
	|
	|-RVA: 0x2756BA0 Offset: 0x2756CA1 VA: 0x2756BA0
	|-Array.EmptyInternalEnumerator<YieldItemParam>.Dispose
	|
	|-RVA: 0x2756DB0 Offset: 0x2756EB1 VA: 0x2756DB0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.Dispose
	|
	|-RVA: 0x2756FC0 Offset: 0x27570C1 VA: 0x2756FC0
	|-Array.EmptyInternalEnumerator<Uid>.Dispose
	|
	|-RVA: 0x27571D0 Offset: 0x27572D1 VA: 0x27571D0
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>.Dispose
	|
	|-RVA: 0x27573E0 Offset: 0x27574E1 VA: 0x27573E0
	|-Array.EmptyInternalEnumerator<NsUid>.Dispose
	|
	|-RVA: 0x27575F0 Offset: 0x27576F1 VA: 0x27575F0
	|-Array.EmptyInternalEnumerator<Friend>.Dispose
	|
	|-RVA: 0x2757810 Offset: 0x2757911 VA: 0x2757810
	|-Array.EmptyInternalEnumerator<Profile>.Dispose
	|
	|-RVA: 0x2757A30 Offset: 0x2757B31 VA: 0x2757A30
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.Dispose
	|
	|-RVA: 0x2757C50 Offset: 0x2757D51 VA: 0x2757C50
	|-Array.EmptyInternalEnumerator<DebugPadState>.Dispose
	|
	|-RVA: 0x2757E70 Offset: 0x2757F71 VA: 0x2757E70
	|-Array.EmptyInternalEnumerator<GesturePoint>.Dispose
	|
	|-RVA: 0x2758080 Offset: 0x2758181 VA: 0x2758080
	|-Array.EmptyInternalEnumerator<GestureState>.Dispose
	|
	|-RVA: 0x27582C0 Offset: 0x27583C1 VA: 0x27582C0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.Dispose
	|
	|-RVA: 0x27584F0 Offset: 0x27585F1 VA: 0x27584F0
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.Dispose
	|
	|-RVA: 0x2758720 Offset: 0x2758821 VA: 0x2758720
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.Dispose
	|
	|-RVA: 0x2758950 Offset: 0x2758A51 VA: 0x2758950
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.Dispose
	|
	|-RVA: 0x2758B80 Offset: 0x2758C81 VA: 0x2758B80
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.Dispose
	|
	|-RVA: 0x2758DB0 Offset: 0x2758EB1 VA: 0x2758DB0
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.Dispose
	|
	|-RVA: 0x2469FD0 Offset: 0x246A0D1 VA: 0x2469FD0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.Dispose
	|
	|-RVA: 0x246A1E0 Offset: 0x246A2E1 VA: 0x246A1E0
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.Dispose
	|
	|-RVA: 0x246A420 Offset: 0x246A521 VA: 0x246A420
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.Dispose
	|
	|-RVA: 0x246A640 Offset: 0x246A741 VA: 0x246A640
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.Dispose
	|
	|-RVA: 0x246A860 Offset: 0x246A961 VA: 0x246A860
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.Dispose
	|
	|-RVA: 0x246AA80 Offset: 0x246AB81 VA: 0x246AA80
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.Dispose
	|
	|-RVA: 0x246ACA0 Offset: 0x246ADA1 VA: 0x246ACA0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.Dispose
	|
	|-RVA: 0x246AEC0 Offset: 0x246AFC1 VA: 0x246AEC0
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.Dispose
	|
	|-RVA: 0x246B0E0 Offset: 0x246B1E1 VA: 0x246B0E0
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.Dispose
	|
	|-RVA: 0x246B300 Offset: 0x246B401 VA: 0x246B300
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.Dispose
	|
	|-RVA: 0x246B530 Offset: 0x246B631 VA: 0x246B530
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.Dispose
	|
	|-RVA: 0x246B770 Offset: 0x246B871 VA: 0x246B770
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.Dispose
	|
	|-RVA: 0x246B990 Offset: 0x246BA91 VA: 0x246B990
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.Dispose
	|
	|-RVA: 0x246BBB0 Offset: 0x246BCB1 VA: 0x246BBB0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.Dispose
	|
	|-RVA: 0x246BDD0 Offset: 0x246BED1 VA: 0x246BDD0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.Dispose
	|
	|-RVA: 0x246BFF0 Offset: 0x246C0F1 VA: 0x246BFF0
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.Dispose
	|
	|-RVA: 0x246C210 Offset: 0x246C311 VA: 0x246C210
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.Dispose
	|
	|-RVA: 0x246C430 Offset: 0x246C531 VA: 0x246C430
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.Dispose
	|
	|-RVA: 0x246C650 Offset: 0x246C751 VA: 0x246C650
	|-Array.EmptyInternalEnumerator<TouchState>.Dispose
	|
	|-RVA: 0x246C880 Offset: 0x246C981 VA: 0x246C880
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.Dispose
	|
	|-RVA: 0x246CA90 Offset: 0x246CB91 VA: 0x246CA90
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.Dispose
	|
	|-RVA: 0x246CCA0 Offset: 0x246CDA1 VA: 0x246CCA0
	|-Array.EmptyInternalEnumerator<VibrationValue>.Dispose
	|
	|-RVA: 0x246CEB0 Offset: 0x246CFB1 VA: 0x246CEB0
	|-Array.EmptyInternalEnumerator<ClusteringData>.Dispose
	|
	|-RVA: 0x246D0D0 Offset: 0x246D1D1 VA: 0x246D0D0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.Dispose
	|
	|-RVA: 0x246D2F0 Offset: 0x246D3F1 VA: 0x246D2F0
	|-Array.EmptyInternalEnumerator<Finger>.Dispose
	|
	|-RVA: 0x246D520 Offset: 0x246D621 VA: 0x246D520
	|-Array.EmptyInternalEnumerator<Hand>.Dispose
	|
	|-RVA: 0x246D740 Offset: 0x246D841 VA: 0x246D740
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.Dispose
	|
	|-RVA: 0x246D950 Offset: 0x246DA51 VA: 0x246D950
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.Dispose
	|
	|-RVA: 0x246DB70 Offset: 0x246DC71 VA: 0x246DB70
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.Dispose
	|
	|-RVA: 0x246DD90 Offset: 0x246DE91 VA: 0x246DD90
	|-Array.EmptyInternalEnumerator<MomentStatistic>.Dispose
	|
	|-RVA: 0x246DFA0 Offset: 0x246E0A1 VA: 0x246DFA0
	|-Array.EmptyInternalEnumerator<Protrusion>.Dispose
	|
	|-RVA: 0x246E1B0 Offset: 0x246E2B1 VA: 0x246E1B0
	|-Array.EmptyInternalEnumerator<Shape>.Dispose
	|
	|-RVA: 0x246E3D0 Offset: 0x246E4D1 VA: 0x246E3D0
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.Dispose
	|
	|-RVA: 0x246E5E0 Offset: 0x246E6E1 VA: 0x246E5E0
	|-Array.EmptyInternalEnumerator<UserWord>.Dispose
	|
	|-RVA: 0x246E7F0 Offset: 0x246E8F1 VA: 0x246E7F0
	|-Array.EmptyInternalEnumerator<Color4u8>.Dispose
	|
	|-RVA: 0x246EA00 Offset: 0x246EB01 VA: 0x246EA00
	|-Array.EmptyInternalEnumerator<Float2>.Dispose
	|
	|-RVA: 0x246EC10 Offset: 0x246ED11 VA: 0x246EC10
	|-Array.EmptyInternalEnumerator<stCommand_t>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4BA0 Offset: 0x28A4CA1 VA: 0x28A4BA0
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>.MoveNext
	|
	|-RVA: 0x28A4DC0 Offset: 0x28A4EC1 VA: 0x28A4DC0
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>.MoveNext
	|
	|-RVA: 0x28A5000 Offset: 0x28A5101 VA: 0x28A5000
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>.MoveNext
	|
	|-RVA: 0x28A5210 Offset: 0x28A5311 VA: 0x28A5210
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>.MoveNext
	|
	|-RVA: 0x28A5420 Offset: 0x28A5521 VA: 0x28A5420
	|-Array.EmptyInternalEnumerator<BitVector32Int>.MoveNext
	|
	|-RVA: 0x28A5630 Offset: 0x28A5731 VA: 0x28A5630
	|-Array.EmptyInternalEnumerator<BuildItemData>.MoveNext
	|
	|-RVA: 0x28A5880 Offset: 0x28A5981 VA: 0x28A5880
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>.MoveNext
	|
	|-RVA: 0x28A5A90 Offset: 0x28A5B91 VA: 0x28A5A90
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>.MoveNext
	|
	|-RVA: 0x28A5CA0 Offset: 0x28A5DA1 VA: 0x28A5CA0
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>.MoveNext
	|
	|-RVA: 0x28A5EB0 Offset: 0x28A5FB1 VA: 0x28A5EB0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.MoveNext
	|
	|-RVA: 0x28A60C0 Offset: 0x28A61C1 VA: 0x28A60C0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.MoveNext
	|
	|-RVA: 0x28A62E0 Offset: 0x28A63E1 VA: 0x28A62E0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.MoveNext
	|
	|-RVA: 0x28A6500 Offset: 0x28A6601 VA: 0x28A6500
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.MoveNext
	|
	|-RVA: 0x28A6710 Offset: 0x28A6811 VA: 0x28A6710
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.MoveNext
	|
	|-RVA: 0x28A6920 Offset: 0x28A6A21 VA: 0x28A6920
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.MoveNext
	|
	|-RVA: 0x28A6B50 Offset: 0x28A6C51 VA: 0x28A6B50
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.MoveNext
	|
	|-RVA: 0x28A6D60 Offset: 0x28A6E61 VA: 0x28A6D60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.MoveNext
	|
	|-RVA: 0x28A6F70 Offset: 0x28A7071 VA: 0x28A6F70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.MoveNext
	|
	|-RVA: 0x28A7190 Offset: 0x28A7291 VA: 0x28A7190
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.MoveNext
	|
	|-RVA: 0x28A73A0 Offset: 0x28A74A1 VA: 0x28A73A0
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.MoveNext
	|
	|-RVA: 0x28A75B0 Offset: 0x28A76B1 VA: 0x28A75B0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.MoveNext
	|
	|-RVA: 0x28A77E0 Offset: 0x28A78E1 VA: 0x28A77E0
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.MoveNext
	|
	|-RVA: 0x28A7A10 Offset: 0x28A7B11 VA: 0x28A7A10
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNext
	|
	|-RVA: 0x28A7C40 Offset: 0x28A7D41 VA: 0x28A7C40
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.MoveNext
	|
	|-RVA: 0x28A7E60 Offset: 0x28A7F61 VA: 0x28A7E60
	|-Array.EmptyInternalEnumerator<CropDataTable>.MoveNext
	|
	|-RVA: 0x28A8080 Offset: 0x28A8181 VA: 0x28A8080
	|-Array.EmptyInternalEnumerator<ControlPoint>.MoveNext
	|
	|-RVA: 0x28A82A0 Offset: 0x28A83A1 VA: 0x28A82A0
	|-Array.EmptyInternalEnumerator<DamageTextInfo>.MoveNext
	|
	|-RVA: 0x28A84C0 Offset: 0x28A85C1 VA: 0x28A84C0
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>.MoveNext
	|
	|-RVA: 0x28A86E0 Offset: 0x28A87E1 VA: 0x28A86E0
	|-Array.EmptyInternalEnumerator<DropItemParam>.MoveNext
	|
	|-RVA: 0x28A88F0 Offset: 0x28A89F1 VA: 0x28A88F0
	|-Array.EmptyInternalEnumerator<DropTableElement>.MoveNext
	|
	|-RVA: 0x28A8B10 Offset: 0x28A8C11 VA: 0x28A8B10
	|-Array.EmptyInternalEnumerator<EffectDataTable>.MoveNext
	|
	|-RVA: 0x28A8D30 Offset: 0x28A8E31 VA: 0x28A8D30
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>.MoveNext
	|
	|-RVA: 0x28A8F40 Offset: 0x28A9041 VA: 0x28A8F40
	|-Array.EmptyInternalEnumerator<Coord>.MoveNext
	|
	|-RVA: 0x28A9150 Offset: 0x28A9251 VA: 0x28A9150
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>.MoveNext
	|
	|-RVA: 0x28A9370 Offset: 0x28A9471 VA: 0x28A9370
	|-Array.EmptyInternalEnumerator<EventCheckId>.MoveNext
	|
	|-RVA: 0x28A9590 Offset: 0x28A9691 VA: 0x28A9590
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>.MoveNext
	|
	|-RVA: 0x28A97A0 Offset: 0x28A98A1 VA: 0x28A97A0
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>.MoveNext
	|
	|-RVA: 0x28A99B0 Offset: 0x28A9AB1 VA: 0x28A99B0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>.MoveNext
	|
	|-RVA: 0x28A9BF0 Offset: 0x28A9CF1 VA: 0x28A9BF0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>.MoveNext
	|
	|-RVA: 0x28A9E20 Offset: 0x28A9F21 VA: 0x28A9E20
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.MoveNext
	|
	|-RVA: 0x28AA040 Offset: 0x28AA141 VA: 0x28AA040
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>.MoveNext
	|
	|-RVA: 0x28AA250 Offset: 0x28AA351 VA: 0x28AA250
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>.MoveNext
	|
	|-RVA: 0x28AA460 Offset: 0x28AA561 VA: 0x28AA460
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>.MoveNext
	|
	|-RVA: 0x28AA670 Offset: 0x28AA771 VA: 0x28AA670
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>.MoveNext
	|
	|-RVA: 0x28AA880 Offset: 0x28AA981 VA: 0x28AA880
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>.MoveNext
	|
	|-RVA: 0x28AAAB0 Offset: 0x28AABB1 VA: 0x28AAAB0
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.MoveNext
	|
	|-RVA: 0x28AACD0 Offset: 0x28AADD1 VA: 0x28AACD0
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>.MoveNext
	|
	|-RVA: 0x28AAF10 Offset: 0x28AB011 VA: 0x28AAF10
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>.MoveNext
	|
	|-RVA: 0x28AB120 Offset: 0x28AB221 VA: 0x28AB120
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.MoveNext
	|
	|-RVA: 0x28AB350 Offset: 0x28AB451 VA: 0x28AB350
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>.MoveNext
	|
	|-RVA: 0x28AB570 Offset: 0x28AB671 VA: 0x28AB570
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>.MoveNext
	|
	|-RVA: 0x28AB790 Offset: 0x28AB891 VA: 0x28AB790
	|-Array.EmptyInternalEnumerator<FurnitureData>.MoveNext
	|
	|-RVA: 0x28AB9B0 Offset: 0x28ABAB1 VA: 0x28AB9B0
	|-Array.EmptyInternalEnumerator<GateDataTable>.MoveNext
	|
	|-RVA: 0x28ABBC0 Offset: 0x28ABCC1 VA: 0x28ABBC0
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>.MoveNext
	|
	|-RVA: 0x28ABDF0 Offset: 0x28ABEF1 VA: 0x28ABDF0
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>.MoveNext
	|
	|-RVA: 0x28AC000 Offset: 0x28AC101 VA: 0x28AC000
	|-Array.EmptyInternalEnumerator<HitResult>.MoveNext
	|
	|-RVA: 0x28AC230 Offset: 0x28AC331 VA: 0x28AC230
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>.MoveNext
	|
	|-RVA: 0x28AC450 Offset: 0x28AC551 VA: 0x28AC450
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>.MoveNext
	|
	|-RVA: 0x28AC670 Offset: 0x28AC771 VA: 0x28AC670
	|-Array.EmptyInternalEnumerator<ItemLevelData>.MoveNext
	|
	|-RVA: 0x28AC880 Offset: 0x28AC981 VA: 0x28AC880
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>.MoveNext
	|
	|-RVA: 0x28ACAA0 Offset: 0x28ACBA1 VA: 0x28ACAA0
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>.MoveNext
	|
	|-RVA: 0x28ACCD0 Offset: 0x28ACDD1 VA: 0x28ACCD0
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>.MoveNext
	|
	|-RVA: 0x28ACEE0 Offset: 0x28ACFE1 VA: 0x28ACEE0
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>.MoveNext
	|
	|-RVA: 0x28AD110 Offset: 0x28AD211 VA: 0x28AD110
	|-Array.EmptyInternalEnumerator<MiningDataTable>.MoveNext
	|
	|-RVA: 0x28AD320 Offset: 0x28AD421 VA: 0x28AD320
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>.MoveNext
	|
	|-RVA: 0x28AD550 Offset: 0x28AD651 VA: 0x28AD550
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.MoveNext
	|
	|-RVA: 0x28AD770 Offset: 0x28AD871 VA: 0x28AD770
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x28AD990 Offset: 0x28ADA91 VA: 0x28AD990
	|-Array.EmptyInternalEnumerator<MonsterDataTable>.MoveNext
	|
	|-RVA: 0x28ADBB0 Offset: 0x28ADCB1 VA: 0x28ADBB0
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>.MoveNext
	|
	|-RVA: 0x28ADDD0 Offset: 0x28ADED1 VA: 0x28ADDD0
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>.MoveNext
	|
	|-RVA: 0x28AE000 Offset: 0x28AE101 VA: 0x28AE000
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>.MoveNext
	|
	|-RVA: 0x28AE230 Offset: 0x28AE331 VA: 0x28AE230
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>.MoveNext
	|
	|-RVA: 0x28AE460 Offset: 0x28AE561 VA: 0x28AE460
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>.MoveNext
	|
	|-RVA: 0x28AE670 Offset: 0x28AE771 VA: 0x28AE670
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>.MoveNext
	|
	|-RVA: 0x28AE880 Offset: 0x28AE981 VA: 0x28AE880
	|-Array.EmptyInternalEnumerator<NPCActionData>.MoveNext
	|
	|-RVA: 0x28AEAB0 Offset: 0x28AEBB1 VA: 0x28AEAB0
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>.MoveNext
	|
	|-RVA: 0x28AECC0 Offset: 0x28AEDC1 VA: 0x28AECC0
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>.MoveNext
	|
	|-RVA: 0x28AEED0 Offset: 0x28AEFD1 VA: 0x28AEED0
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>.MoveNext
	|
	|-RVA: 0x28AF0F0 Offset: 0x28AF1F1 VA: 0x28AF0F0
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>.MoveNext
	|
	|-RVA: 0x28AF300 Offset: 0x28AF401 VA: 0x28AF300
	|-Array.EmptyInternalEnumerator<OrderSaveData>.MoveNext
	|
	|-RVA: 0x28AF530 Offset: 0x28AF631 VA: 0x28AF530
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>.MoveNext
	|
	|-RVA: 0x28AF750 Offset: 0x28AF851 VA: 0x28AF750
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNext
	|
	|-RVA: 0x28AF960 Offset: 0x28AFA61 VA: 0x28AF960
	|-Array.EmptyInternalEnumerator<Parameter>.MoveNext
	|
	|-RVA: 0x28AFB80 Offset: 0x28AFC81 VA: 0x28AFB80
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.MoveNext
	|
	|-RVA: 0x28AFD90 Offset: 0x28AFE91 VA: 0x28AFD90
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>.MoveNext
	|
	|-RVA: 0x28AFFC0 Offset: 0x28B00C1 VA: 0x28AFFC0
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>.MoveNext
	|
	|-RVA: 0x28B01D0 Offset: 0x28B02D1 VA: 0x28B01D0
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>.MoveNext
	|
	|-RVA: 0x28B0400 Offset: 0x28B0501 VA: 0x28B0400
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>.MoveNext
	|
	|-RVA: 0x28B0610 Offset: 0x28B0711 VA: 0x28B0610
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>.MoveNext
	|
	|-RVA: 0x28B0820 Offset: 0x28B0921 VA: 0x28B0820
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>.MoveNext
	|
	|-RVA: 0x28B0A30 Offset: 0x28B0B31 VA: 0x28B0A30
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>.MoveNext
	|
	|-RVA: 0x28B0C60 Offset: 0x28B0D61 VA: 0x28B0C60
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.MoveNext
	|
	|-RVA: 0x28B0E90 Offset: 0x28B0F91 VA: 0x28B0E90
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.MoveNext
	|
	|-RVA: 0x28B10C0 Offset: 0x28B11C1 VA: 0x28B10C0
	|-Array.EmptyInternalEnumerator<ProfilerFrame>.MoveNext
	|
	|-RVA: 0x28B12D0 Offset: 0x28B13D1 VA: 0x28B12D0
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>.MoveNext
	|
	|-RVA: 0x28B14E0 Offset: 0x28B15E1 VA: 0x28B14E0
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>.MoveNext
	|
	|-RVA: 0x28B1700 Offset: 0x28B1801 VA: 0x28B1700
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>.MoveNext
	|
	|-RVA: 0x28B1920 Offset: 0x28B1A21 VA: 0x28B1920
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>.MoveNext
	|
	|-RVA: 0x28B1B30 Offset: 0x28B1C31 VA: 0x28B1B30
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>.MoveNext
	|
	|-RVA: 0x28B1D40 Offset: 0x28B1E41 VA: 0x28B1D40
	|-Array.EmptyInternalEnumerator<Schedule>.MoveNext
	|
	|-RVA: 0x28B1F60 Offset: 0x28B2061 VA: 0x28B1F60
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.MoveNext
	|
	|-RVA: 0x28B2170 Offset: 0x28B2271 VA: 0x28B2170
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.MoveNext
	|
	|-RVA: 0x28B2380 Offset: 0x28B2481 VA: 0x28B2380
	|-Array.EmptyInternalEnumerator<SpeedData>.MoveNext
	|
	|-RVA: 0x26F2560 Offset: 0x26F2661 VA: 0x26F2560
	|-Array.EmptyInternalEnumerator<CurveSample>.MoveNext
	|
	|-RVA: 0x26F27A0 Offset: 0x26F28A1 VA: 0x26F27A0
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>.MoveNext
	|
	|-RVA: 0x26F29B0 Offset: 0x26F2AB1 VA: 0x26F29B0
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>.MoveNext
	|
	|-RVA: 0x26F2BC0 Offset: 0x26F2CC1 VA: 0x26F2BC0
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>.MoveNext
	|
	|-RVA: 0x26F2DD0 Offset: 0x26F2ED1 VA: 0x26F2DD0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.MoveNext
	|
	|-RVA: 0x26F2FE0 Offset: 0x26F30E1 VA: 0x26F2FE0
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>.MoveNext
	|
	|-RVA: 0x26F31F0 Offset: 0x26F32F1 VA: 0x26F31F0
	|-Array.EmptyInternalEnumerator<bool>.MoveNext
	|
	|-RVA: 0x26F3400 Offset: 0x26F3501 VA: 0x26F3400
	|-Array.EmptyInternalEnumerator<byte>.MoveNext
	|
	|-RVA: 0x26F3610 Offset: 0x26F3711 VA: 0x26F3610
	|-Array.EmptyInternalEnumerator<ByteEnum>.MoveNext
	|
	|-RVA: 0x26F3820 Offset: 0x26F3921 VA: 0x26F3820
	|-Array.EmptyInternalEnumerator<char>.MoveNext
	|
	|-RVA: 0x26F3A30 Offset: 0x26F3B31 VA: 0x26F3A30
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.MoveNext
	|
	|-RVA: 0x26F3C40 Offset: 0x26F3D41 VA: 0x26F3C40
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x26F3E50 Offset: 0x26F3F51 VA: 0x26F3E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.MoveNext
	|
	|-RVA: 0x26F4070 Offset: 0x26F4171 VA: 0x26F4070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.MoveNext
	|
	|-RVA: 0x26F4290 Offset: 0x26F4391 VA: 0x26F4290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>.MoveNext
	|
	|-RVA: 0x26F44C0 Offset: 0x26F45C1 VA: 0x26F44C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.MoveNext
	|
	|-RVA: 0x26F4700 Offset: 0x26F4801 VA: 0x26F4700
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.MoveNext
	|
	|-RVA: 0x26F4930 Offset: 0x26F4A31 VA: 0x26F4930
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.MoveNext
	|
	|-RVA: 0x26F4B50 Offset: 0x26F4C51 VA: 0x26F4B50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.MoveNext
	|
	|-RVA: 0x26F4D70 Offset: 0x26F4E71 VA: 0x26F4D70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.MoveNext
	|
	|-RVA: 0x26F4FA0 Offset: 0x26F50A1 VA: 0x26F4FA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.MoveNext
	|
	|-RVA: 0x26F51C0 Offset: 0x26F52C1 VA: 0x26F51C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.MoveNext
	|
	|-RVA: 0x26F53F0 Offset: 0x26F54F1 VA: 0x26F53F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.MoveNext
	|
	|-RVA: 0x26F5620 Offset: 0x26F5721 VA: 0x26F5620
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>.MoveNext
	|
	|-RVA: 0x26F5840 Offset: 0x26F5941 VA: 0x26F5840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>.MoveNext
	|
	|-RVA: 0x26F5A60 Offset: 0x26F5B61 VA: 0x26F5A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.MoveNext
	|
	|-RVA: 0x26F5C80 Offset: 0x26F5D81 VA: 0x26F5C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.MoveNext
	|
	|-RVA: 0x26F5EA0 Offset: 0x26F5FA1 VA: 0x26F5EA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>.MoveNext
	|
	|-RVA: 0x26F60C0 Offset: 0x26F61C1 VA: 0x26F60C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>.MoveNext
	|
	|-RVA: 0x26F62E0 Offset: 0x26F63E1 VA: 0x26F62E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.MoveNext
	|
	|-RVA: 0x26F6500 Offset: 0x26F6601 VA: 0x26F6500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>.MoveNext
	|
	|-RVA: 0x26F6720 Offset: 0x26F6821 VA: 0x26F6720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>.MoveNext
	|
	|-RVA: 0x26F6940 Offset: 0x26F6A41 VA: 0x26F6940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.MoveNext
	|
	|-RVA: 0x26F6B60 Offset: 0x26F6C61 VA: 0x26F6B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.MoveNext
	|
	|-RVA: 0x26F6D70 Offset: 0x26F6E71 VA: 0x26F6D70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.MoveNext
	|
	|-RVA: 0x26F6FB0 Offset: 0x26F70B1 VA: 0x26F6FB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.MoveNext
	|
	|-RVA: 0x26F71D0 Offset: 0x26F72D1 VA: 0x26F71D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.MoveNext
	|
	|-RVA: 0x26F73E0 Offset: 0x26F74E1 VA: 0x26F73E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.MoveNext
	|
	|-RVA: 0x26F75F0 Offset: 0x26F76F1 VA: 0x26F75F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.MoveNext
	|
	|-RVA: 0x26F7800 Offset: 0x26F7901 VA: 0x26F7800
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.MoveNext
	|
	|-RVA: 0x26F7A10 Offset: 0x26F7B11 VA: 0x26F7A10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.MoveNext
	|
	|-RVA: 0x26F7C30 Offset: 0x26F7D31 VA: 0x26F7C30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.MoveNext
	|
	|-RVA: 0x26F7E50 Offset: 0x26F7F51 VA: 0x26F7E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.MoveNext
	|
	|-RVA: 0x26F8080 Offset: 0x26F8181 VA: 0x26F8080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>.MoveNext
	|
	|-RVA: 0x26F82A0 Offset: 0x26F83A1 VA: 0x26F82A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>.MoveNext
	|
	|-RVA: 0x26F84C0 Offset: 0x26F85C1 VA: 0x26F84C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>.MoveNext
	|
	|-RVA: 0x26F86E0 Offset: 0x26F87E1 VA: 0x26F86E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.MoveNext
	|
	|-RVA: 0x26F8900 Offset: 0x26F8A01 VA: 0x26F8900
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.MoveNext
	|
	|-RVA: 0x26F8B30 Offset: 0x26F8C31 VA: 0x26F8B30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.MoveNext
	|
	|-RVA: 0x26F8D60 Offset: 0x26F8E61 VA: 0x26F8D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.MoveNext
	|
	|-RVA: 0x26F8F70 Offset: 0x26F9071 VA: 0x26F8F70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.MoveNext
	|
	|-RVA: 0x26F9190 Offset: 0x26F9291 VA: 0x26F9190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x26F93A0 Offset: 0x26F94A1 VA: 0x26F93A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x26F95B0 Offset: 0x26F96B1 VA: 0x26F95B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x26F97D0 Offset: 0x26F98D1 VA: 0x26F97D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>.MoveNext
	|
	|-RVA: 0x26F99E0 Offset: 0x26F9AE1 VA: 0x26F99E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.MoveNext
	|
	|-RVA: 0x26F9C00 Offset: 0x26F9D01 VA: 0x26F9C00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.MoveNext
	|
	|-RVA: 0x26F9E20 Offset: 0x26F9F21 VA: 0x26F9E20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.MoveNext
	|
	|-RVA: 0x26FA040 Offset: 0x26FA141 VA: 0x26FA040
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.MoveNext
	|
	|-RVA: 0x26FA260 Offset: 0x26FA361 VA: 0x26FA260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>.MoveNext
	|
	|-RVA: 0x26FA480 Offset: 0x26FA581 VA: 0x26FA480
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.MoveNext
	|
	|-RVA: 0x26FA6A0 Offset: 0x26FA7A1 VA: 0x26FA6A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.MoveNext
	|
	|-RVA: 0x26FA8D0 Offset: 0x26FA9D1 VA: 0x26FA8D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.MoveNext
	|
	|-RVA: 0x26FAB00 Offset: 0x26FAC01 VA: 0x26FAB00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.MoveNext
	|
	|-RVA: 0x26FAD20 Offset: 0x26FAE21 VA: 0x26FAD20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.MoveNext
	|
	|-RVA: 0x26FAF50 Offset: 0x26FB051 VA: 0x26FAF50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.MoveNext
	|
	|-RVA: 0x26FB170 Offset: 0x26FB271 VA: 0x26FB170
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.MoveNext
	|
	|-RVA: 0x26FB3A0 Offset: 0x26FB4A1 VA: 0x26FB3A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.MoveNext
	|
	|-RVA: 0x26FB5D0 Offset: 0x26FB6D1 VA: 0x26FB5D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.MoveNext
	|
	|-RVA: 0x26FB7F0 Offset: 0x26FB8F1 VA: 0x26FB7F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.MoveNext
	|
	|-RVA: 0x26FBA30 Offset: 0x26FBB31 VA: 0x26FBA30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.MoveNext
	|
	|-RVA: 0x26FBC60 Offset: 0x26FBD61 VA: 0x26FBC60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.MoveNext
	|
	|-RVA: 0x26FBE80 Offset: 0x26FBF81 VA: 0x26FBE80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.MoveNext
	|
	|-RVA: 0x26FC0B0 Offset: 0x26FC1B1 VA: 0x26FC0B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.MoveNext
	|
	|-RVA: 0x26FC2E0 Offset: 0x26FC3E1 VA: 0x26FC2E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.MoveNext
	|
	|-RVA: 0x26FC500 Offset: 0x26FC601 VA: 0x26FC500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.MoveNext
	|
	|-RVA: 0x26FC720 Offset: 0x26FC821 VA: 0x26FC720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.MoveNext
	|
	|-RVA: 0x26FC940 Offset: 0x26FCA41 VA: 0x26FC940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.MoveNext
	|
	|-RVA: 0x26FCB60 Offset: 0x26FCC61 VA: 0x26FCB60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.MoveNext
	|
	|-RVA: 0x26FCD90 Offset: 0x26FCE91 VA: 0x26FCD90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.MoveNext
	|
	|-RVA: 0x26FCFB0 Offset: 0x26FD0B1 VA: 0x26FCFB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>.MoveNext
	|
	|-RVA: 0x26FD1E0 Offset: 0x26FD2E1 VA: 0x26FD1E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.MoveNext
	|
	|-RVA: 0x26FD420 Offset: 0x26FD521 VA: 0x26FD420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.MoveNext
	|
	|-RVA: 0x26FD650 Offset: 0x26FD751 VA: 0x26FD650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.MoveNext
	|
	|-RVA: 0x26FD870 Offset: 0x26FD971 VA: 0x26FD870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.MoveNext
	|
	|-RVA: 0x26FDA90 Offset: 0x26FDB91 VA: 0x26FDA90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.MoveNext
	|
	|-RVA: 0x26FDCC0 Offset: 0x26FDDC1 VA: 0x26FDCC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.MoveNext
	|
	|-RVA: 0x26FDEE0 Offset: 0x26FDFE1 VA: 0x26FDEE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.MoveNext
	|
	|-RVA: 0x26FE110 Offset: 0x26FE211 VA: 0x26FE110
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.MoveNext
	|
	|-RVA: 0x26FE340 Offset: 0x26FE441 VA: 0x26FE340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>.MoveNext
	|
	|-RVA: 0x26FE560 Offset: 0x26FE661 VA: 0x26FE560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.MoveNext
	|
	|-RVA: 0x26FE780 Offset: 0x26FE881 VA: 0x26FE780
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.MoveNext
	|
	|-RVA: 0x26FE9A0 Offset: 0x26FEAA1 VA: 0x26FE9A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.MoveNext
	|
	|-RVA: 0x26FEBC0 Offset: 0x26FECC1 VA: 0x26FEBC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>.MoveNext
	|
	|-RVA: 0x26FEDE0 Offset: 0x26FEEE1 VA: 0x26FEDE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>.MoveNext
	|
	|-RVA: 0x26FF000 Offset: 0x26FF101 VA: 0x26FF000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>.MoveNext
	|
	|-RVA: 0x26FF220 Offset: 0x26FF321 VA: 0x26FF220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>.MoveNext
	|
	|-RVA: 0x26FF440 Offset: 0x26FF541 VA: 0x26FF440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.MoveNext
	|
	|-RVA: 0x26FF660 Offset: 0x26FF761 VA: 0x26FF660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x26FF880 Offset: 0x26FF981 VA: 0x26FF880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>.MoveNext
	|
	|-RVA: 0x26FFAA0 Offset: 0x26FFBA1 VA: 0x26FFAA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>.MoveNext
	|
	|-RVA: 0x26FFCC0 Offset: 0x26FFDC1 VA: 0x26FFCC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.MoveNext
	|
	|-RVA: 0x26FFEE0 Offset: 0x26FFFE1 VA: 0x26FFEE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.MoveNext
	|
	|-RVA: 0x2700110 Offset: 0x2700211 VA: 0x2700110
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.MoveNext
	|
	|-RVA: 0x2700340 Offset: 0x2700441 VA: 0x2700340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.MoveNext
	|
	|-RVA: 0x2700560 Offset: 0x2700661 VA: 0x2700560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.MoveNext
	|
	|-RVA: 0x2700790 Offset: 0x2700891 VA: 0x2700790
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.MoveNext
	|
	|-RVA: 0x27009B0 Offset: 0x2700AB1 VA: 0x27009B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.MoveNext
	|
	|-RVA: 0x2700BE0 Offset: 0x2700CE1 VA: 0x2700BE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.MoveNext
	|
	|-RVA: 0x2700E10 Offset: 0x2700F11 VA: 0x2700E10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.MoveNext
	|
	|-RVA: 0x2701030 Offset: 0x2701131 VA: 0x2701030
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.MoveNext
	|
	|-RVA: 0x2701270 Offset: 0x2701371 VA: 0x2701270
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.MoveNext
	|
	|-RVA: 0x27014A0 Offset: 0x27015A1 VA: 0x27014A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.MoveNext
	|
	|-RVA: 0x27016C0 Offset: 0x27017C1 VA: 0x27016C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.MoveNext
	|
	|-RVA: 0x27018F0 Offset: 0x27019F1 VA: 0x27018F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.MoveNext
	|
	|-RVA: 0x2701B20 Offset: 0x2701C21 VA: 0x2701B20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.MoveNext
	|
	|-RVA: 0x2701D40 Offset: 0x2701E41 VA: 0x2701D40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.MoveNext
	|
	|-RVA: 0x2701F60 Offset: 0x2702061 VA: 0x2701F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.MoveNext
	|
	|-RVA: 0x2702180 Offset: 0x2702281 VA: 0x2702180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.MoveNext
	|
	|-RVA: 0x27023A0 Offset: 0x27024A1 VA: 0x27023A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.MoveNext
	|
	|-RVA: 0x27025D0 Offset: 0x27026D1 VA: 0x27025D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.MoveNext
	|
	|-RVA: 0x27027F0 Offset: 0x27028F1 VA: 0x27027F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.MoveNext
	|
	|-RVA: 0x2702A10 Offset: 0x2702B11 VA: 0x2702A10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.MoveNext
	|
	|-RVA: 0x2702C30 Offset: 0x2702D31 VA: 0x2702C30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>.MoveNext
	|
	|-RVA: 0x2702E50 Offset: 0x2702F51 VA: 0x2702E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.MoveNext
	|
	|-RVA: 0x2703070 Offset: 0x2703171 VA: 0x2703070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.MoveNext
	|
	|-RVA: 0x2703290 Offset: 0x2703391 VA: 0x2703290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>.MoveNext
	|
	|-RVA: 0x27034B0 Offset: 0x27035B1 VA: 0x27034B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>.MoveNext
	|
	|-RVA: 0x27036D0 Offset: 0x27037D1 VA: 0x27036D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>.MoveNext
	|
	|-RVA: 0x2703900 Offset: 0x2703A01 VA: 0x2703900
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>.MoveNext
	|
	|-RVA: 0x2703B30 Offset: 0x2703C31 VA: 0x2703B30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>.MoveNext
	|
	|-RVA: 0x2703D60 Offset: 0x2703E61 VA: 0x2703D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>.MoveNext
	|
	|-RVA: 0x2703F80 Offset: 0x2704081 VA: 0x2703F80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>.MoveNext
	|
	|-RVA: 0x27041A0 Offset: 0x27042A1 VA: 0x27041A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x27043C0 Offset: 0x27044C1 VA: 0x27043C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.MoveNext
	|
	|-RVA: 0x27045F0 Offset: 0x27046F1 VA: 0x27045F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>.MoveNext
	|
	|-RVA: 0x2704820 Offset: 0x2704921 VA: 0x2704820
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>.MoveNext
	|
	|-RVA: 0x2704A40 Offset: 0x2704B41 VA: 0x2704A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.MoveNext
	|
	|-RVA: 0x2704C80 Offset: 0x2704D81 VA: 0x2704C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.MoveNext
	|
	|-RVA: 0x2704EA0 Offset: 0x2704FA1 VA: 0x2704EA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>.MoveNext
	|
	|-RVA: 0x27050C0 Offset: 0x27051C1 VA: 0x27050C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>.MoveNext
	|
	|-RVA: 0x27052E0 Offset: 0x27053E1 VA: 0x27052E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>.MoveNext
	|
	|-RVA: 0x2705500 Offset: 0x2705601 VA: 0x2705500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>.MoveNext
	|
	|-RVA: 0x2705720 Offset: 0x2705821 VA: 0x2705720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x2705950 Offset: 0x2705A51 VA: 0x2705950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.MoveNext
	|
	|-RVA: 0x2705B80 Offset: 0x2705C81 VA: 0x2705B80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>.MoveNext
	|
	|-RVA: 0x2705DA0 Offset: 0x2705EA1 VA: 0x2705DA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>.MoveNext
	|
	|-RVA: 0x2705FC0 Offset: 0x27060C1 VA: 0x2705FC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>.MoveNext
	|
	|-RVA: 0x27061E0 Offset: 0x27062E1 VA: 0x27061E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>.MoveNext
	|
	|-RVA: 0x2706400 Offset: 0x2706501 VA: 0x2706400
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>.MoveNext
	|
	|-RVA: 0x2706620 Offset: 0x2706721 VA: 0x2706620
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.MoveNext
	|
	|-RVA: 0x2706840 Offset: 0x2706941 VA: 0x2706840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.MoveNext
	|
	|-RVA: 0x2706A60 Offset: 0x2706B61 VA: 0x2706A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.MoveNext
	|
	|-RVA: 0x2706C80 Offset: 0x2706D81 VA: 0x2706C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>.MoveNext
	|
	|-RVA: 0x2706EC0 Offset: 0x2706FC1 VA: 0x2706EC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>.MoveNext
	|
	|-RVA: 0x27070E0 Offset: 0x27071E1 VA: 0x27070E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>.MoveNext
	|
	|-RVA: 0x2707300 Offset: 0x2707401 VA: 0x2707300
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.MoveNext
	|
	|-RVA: 0x2707510 Offset: 0x2707611 VA: 0x2707510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2707720 Offset: 0x2707821 VA: 0x2707720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.MoveNext
	|
	|-RVA: 0x2707940 Offset: 0x2707A41 VA: 0x2707940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.MoveNext
	|
	|-RVA: 0x2707B60 Offset: 0x2707C61 VA: 0x2707B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.MoveNext
	|
	|-RVA: 0x2707D80 Offset: 0x2707E81 VA: 0x2707D80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.MoveNext
	|
	|-RVA: 0x2707FB0 Offset: 0x27080B1 VA: 0x2707FB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.MoveNext
	|
	|-RVA: 0x27081E0 Offset: 0x27082E1 VA: 0x27081E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.MoveNext
	|
	|-RVA: 0x2708410 Offset: 0x2708511 VA: 0x2708410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.MoveNext
	|
	|-RVA: 0x2708630 Offset: 0x2708731 VA: 0x2708630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.MoveNext
	|
	|-RVA: 0x2708850 Offset: 0x2708951 VA: 0x2708850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>.MoveNext
	|
	|-RVA: 0x2708A80 Offset: 0x2708B81 VA: 0x2708A80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>.MoveNext
	|
	|-RVA: 0x2708CB0 Offset: 0x2708DB1 VA: 0x2708CB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>.MoveNext
	|
	|-RVA: 0x2708ED0 Offset: 0x2708FD1 VA: 0x2708ED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>.MoveNext
	|
	|-RVA: 0x27090F0 Offset: 0x27091F1 VA: 0x27090F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.MoveNext
	|
	|-RVA: 0x2709310 Offset: 0x2709411 VA: 0x2709310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.MoveNext
	|
	|-RVA: 0x2709530 Offset: 0x2709631 VA: 0x2709530
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.MoveNext
	|
	|-RVA: 0x2709760 Offset: 0x2709861 VA: 0x2709760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>.MoveNext
	|
	|-RVA: 0x2709990 Offset: 0x2709A91 VA: 0x2709990
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>.MoveNext
	|
	|-RVA: 0x2709BB0 Offset: 0x2709CB1 VA: 0x2709BB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.MoveNext
	|
	|-RVA: 0x2709DF0 Offset: 0x2709EF1 VA: 0x2709DF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>.MoveNext
	|
	|-RVA: 0x270A010 Offset: 0x270A111 VA: 0x270A010
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>.MoveNext
	|
	|-RVA: 0x270A230 Offset: 0x270A331 VA: 0x270A230
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>.MoveNext
	|
	|-RVA: 0x270A450 Offset: 0x270A551 VA: 0x270A450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>.MoveNext
	|
	|-RVA: 0x270A670 Offset: 0x270A771 VA: 0x270A670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>.MoveNext
	|
	|-RVA: 0x270A890 Offset: 0x270A991 VA: 0x270A890
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.MoveNext
	|
	|-RVA: 0x270AAB0 Offset: 0x270ABB1 VA: 0x270AAB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.MoveNext
	|
	|-RVA: 0x270ACD0 Offset: 0x270ADD1 VA: 0x270ACD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>.MoveNext
	|
	|-RVA: 0x270AEF0 Offset: 0x270AFF1 VA: 0x270AEF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>.MoveNext
	|
	|-RVA: 0x270B110 Offset: 0x270B211 VA: 0x270B110
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>.MoveNext
	|
	|-RVA: 0x270B330 Offset: 0x270B431 VA: 0x270B330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>.MoveNext
	|
	|-RVA: 0x270B550 Offset: 0x270B651 VA: 0x270B550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>.MoveNext
	|
	|-RVA: 0x270B770 Offset: 0x270B871 VA: 0x270B770
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.MoveNext
	|
	|-RVA: 0x28C6750 Offset: 0x28C6851 VA: 0x28C6750
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.MoveNext
	|
	|-RVA: 0x28C6960 Offset: 0x28C6A61 VA: 0x28C6960
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.MoveNext
	|
	|-RVA: 0x28C6B70 Offset: 0x28C6C71 VA: 0x28C6B70
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.MoveNext
	|
	|-RVA: 0x28C6D80 Offset: 0x28C6E81 VA: 0x28C6D80
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>.MoveNext
	|
	|-RVA: 0x28C6F90 Offset: 0x28C7091 VA: 0x28C6F90
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x28C71B0 Offset: 0x28C72B1 VA: 0x28C71B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.MoveNext
	|
	|-RVA: 0x28C73D0 Offset: 0x28C74D1 VA: 0x28C73D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>.MoveNext
	|
	|-RVA: 0x28C75E0 Offset: 0x28C76E1 VA: 0x28C75E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>.MoveNext
	|
	|-RVA: 0x28C7800 Offset: 0x28C7901 VA: 0x28C7800
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.MoveNext
	|
	|-RVA: 0x28C7A30 Offset: 0x28C7B31 VA: 0x28C7A30
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.MoveNext
	|
	|-RVA: 0x28C7C50 Offset: 0x28C7D51 VA: 0x28C7C50
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.MoveNext
	|
	|-RVA: 0x28C7E70 Offset: 0x28C7F71 VA: 0x28C7E70
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.MoveNext
	|
	|-RVA: 0x28C8090 Offset: 0x28C8191 VA: 0x28C8090
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.MoveNext
	|
	|-RVA: 0x28C82C0 Offset: 0x28C83C1 VA: 0x28C82C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.MoveNext
	|
	|-RVA: 0x28C84E0 Offset: 0x28C85E1 VA: 0x28C84E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>.MoveNext
	|
	|-RVA: 0x28C8710 Offset: 0x28C8811 VA: 0x28C8710
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.MoveNext
	|
	|-RVA: 0x28C8940 Offset: 0x28C8A41 VA: 0x28C8940
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>.MoveNext
	|
	|-RVA: 0x28C8B60 Offset: 0x28C8C61 VA: 0x28C8B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>.MoveNext
	|
	|-RVA: 0x28C8D70 Offset: 0x28C8E71 VA: 0x28C8D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.MoveNext
	|
	|-RVA: 0x28C8F80 Offset: 0x28C9081 VA: 0x28C8F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.MoveNext
	|
	|-RVA: 0x28C9190 Offset: 0x28C9291 VA: 0x28C9190
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.MoveNext
	|
	|-RVA: 0x28C93A0 Offset: 0x28C94A1 VA: 0x28C93A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>.MoveNext
	|
	|-RVA: 0x28C95B0 Offset: 0x28C96B1 VA: 0x28C95B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.MoveNext
	|
	|-RVA: 0x28C97D0 Offset: 0x28C98D1 VA: 0x28C97D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>.MoveNext
	|
	|-RVA: 0x28C99E0 Offset: 0x28C9AE1 VA: 0x28C99E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>.MoveNext
	|
	|-RVA: 0x28C9C00 Offset: 0x28C9D01 VA: 0x28C9C00
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>.MoveNext
	|
	|-RVA: 0x28C9E20 Offset: 0x28C9F21 VA: 0x28C9E20
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.MoveNext
	|
	|-RVA: 0x28CA030 Offset: 0x28CA131 VA: 0x28CA030
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.MoveNext
	|
	|-RVA: 0x28CA270 Offset: 0x28CA371 VA: 0x28CA270
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>.MoveNext
	|
	|-RVA: 0x28CA490 Offset: 0x28CA591 VA: 0x28CA490
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.MoveNext
	|
	|-RVA: 0x28CA6A0 Offset: 0x28CA7A1 VA: 0x28CA6A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.MoveNext
	|
	|-RVA: 0x28CA8B0 Offset: 0x28CA9B1 VA: 0x28CA8B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x28CAAC0 Offset: 0x28CABC1 VA: 0x28CAAC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.MoveNext
	|
	|-RVA: 0x28CACD0 Offset: 0x28CADD1 VA: 0x28CACD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.MoveNext
	|
	|-RVA: 0x28CAEE0 Offset: 0x28CAFE1 VA: 0x28CAEE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x28CB0F0 Offset: 0x28CB1F1 VA: 0x28CB0F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.MoveNext
	|
	|-RVA: 0x28CB320 Offset: 0x28CB421 VA: 0x28CB320
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>.MoveNext
	|
	|-RVA: 0x28CB540 Offset: 0x28CB641 VA: 0x28CB540
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>.MoveNext
	|
	|-RVA: 0x28CB750 Offset: 0x28CB851 VA: 0x28CB750
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>.MoveNext
	|
	|-RVA: 0x28CB960 Offset: 0x28CBA61 VA: 0x28CB960
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.MoveNext
	|
	|-RVA: 0x28CBB80 Offset: 0x28CBC81 VA: 0x28CBB80
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.MoveNext
	|
	|-RVA: 0x28CBDB0 Offset: 0x28CBEB1 VA: 0x28CBDB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.MoveNext
	|
	|-RVA: 0x28CBFD0 Offset: 0x28CC0D1 VA: 0x28CBFD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.MoveNext
	|
	|-RVA: 0x28CC1E0 Offset: 0x28CC2E1 VA: 0x28CC1E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.MoveNext
	|
	|-RVA: 0x28CC3F0 Offset: 0x28CC4F1 VA: 0x28CC3F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x28CC600 Offset: 0x28CC701 VA: 0x28CC600
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x28CC810 Offset: 0x28CC911 VA: 0x28CC810
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x28CCA20 Offset: 0x28CCB21 VA: 0x28CCA20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>.MoveNext
	|
	|-RVA: 0x28CCC30 Offset: 0x28CCD31 VA: 0x28CCC30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.MoveNext
	|
	|-RVA: 0x28CCE50 Offset: 0x28CCF51 VA: 0x28CCE50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.MoveNext
	|
	|-RVA: 0x28CD060 Offset: 0x28CD161 VA: 0x28CD060
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.MoveNext
	|
	|-RVA: 0x28CD270 Offset: 0x28CD371 VA: 0x28CD270
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.MoveNext
	|
	|-RVA: 0x28CD480 Offset: 0x28CD581 VA: 0x28CD480
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>.MoveNext
	|
	|-RVA: 0x28CD6A0 Offset: 0x28CD7A1 VA: 0x28CD6A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.MoveNext
	|
	|-RVA: 0x28CD8B0 Offset: 0x28CD9B1 VA: 0x28CD8B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.MoveNext
	|
	|-RVA: 0x28CDAE0 Offset: 0x28CDBE1 VA: 0x28CDAE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.MoveNext
	|
	|-RVA: 0x28CDD10 Offset: 0x28CDE11 VA: 0x28CDD10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.MoveNext
	|
	|-RVA: 0x28CDF20 Offset: 0x28CE021 VA: 0x28CDF20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>.MoveNext
	|
	|-RVA: 0x28CE140 Offset: 0x28CE241 VA: 0x28CE140
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.MoveNext
	|
	|-RVA: 0x28CE360 Offset: 0x28CE461 VA: 0x28CE360
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.MoveNext
	|
	|-RVA: 0x28CE580 Offset: 0x28CE681 VA: 0x28CE580
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.MoveNext
	|
	|-RVA: 0x28CE7B0 Offset: 0x28CE8B1 VA: 0x28CE7B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.MoveNext
	|
	|-RVA: 0x28CE9C0 Offset: 0x28CEAC1 VA: 0x28CE9C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.MoveNext
	|
	|-RVA: 0x28CEC00 Offset: 0x28CED01 VA: 0x28CEC00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.MoveNext
	|
	|-RVA: 0x28CEE20 Offset: 0x28CEF21 VA: 0x28CEE20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.MoveNext
	|
	|-RVA: 0x28CF040 Offset: 0x28CF141 VA: 0x28CF040
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.MoveNext
	|
	|-RVA: 0x28CF260 Offset: 0x28CF361 VA: 0x28CF260
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.MoveNext
	|
	|-RVA: 0x28CF480 Offset: 0x28CF581 VA: 0x28CF480
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.MoveNext
	|
	|-RVA: 0x28CF6A0 Offset: 0x28CF7A1 VA: 0x28CF6A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.MoveNext
	|
	|-RVA: 0x28CF8C0 Offset: 0x28CF9C1 VA: 0x28CF8C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.MoveNext
	|
	|-RVA: 0x28CFAE0 Offset: 0x28CFBE1 VA: 0x28CFAE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.MoveNext
	|
	|-RVA: 0x28CFD00 Offset: 0x28CFE01 VA: 0x28CFD00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.MoveNext
	|
	|-RVA: 0x28CFF20 Offset: 0x28D0021 VA: 0x28CFF20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>.MoveNext
	|
	|-RVA: 0x28D0130 Offset: 0x28D0231 VA: 0x28D0130
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>.MoveNext
	|
	|-RVA: 0x28D0350 Offset: 0x28D0451 VA: 0x28D0350
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.MoveNext
	|
	|-RVA: 0x28D0580 Offset: 0x28D0681 VA: 0x28D0580
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.MoveNext
	|
	|-RVA: 0x28D07A0 Offset: 0x28D08A1 VA: 0x28D07A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.MoveNext
	|
	|-RVA: 0x28D09C0 Offset: 0x28D0AC1 VA: 0x28D09C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.MoveNext
	|
	|-RVA: 0x28D0BE0 Offset: 0x28D0CE1 VA: 0x28D0BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.MoveNext
	|
	|-RVA: 0x28D0E10 Offset: 0x28D0F11 VA: 0x28D0E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.MoveNext
	|
	|-RVA: 0x28D1030 Offset: 0x28D1131 VA: 0x28D1030
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>.MoveNext
	|
	|-RVA: 0x28D1260 Offset: 0x28D1361 VA: 0x28D1260
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.MoveNext
	|
	|-RVA: 0x28D1490 Offset: 0x28D1591 VA: 0x28D1490
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>.MoveNext
	|
	|-RVA: 0x28D16B0 Offset: 0x28D17B1 VA: 0x28D16B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.MoveNext
	|
	|-RVA: 0x28D18D0 Offset: 0x28D19D1 VA: 0x28D18D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.MoveNext
	|
	|-RVA: 0x28D1AE0 Offset: 0x28D1BE1 VA: 0x28D1AE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.MoveNext
	|
	|-RVA: 0x28D1CF0 Offset: 0x28D1DF1 VA: 0x28D1CF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>.MoveNext
	|
	|-RVA: 0x28D1F00 Offset: 0x28D2001 VA: 0x28D1F00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>.MoveNext
	|
	|-RVA: 0x28D2110 Offset: 0x28D2211 VA: 0x28D2110
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>.MoveNext
	|
	|-RVA: 0x28D2320 Offset: 0x28D2421 VA: 0x28D2320
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>.MoveNext
	|
	|-RVA: 0x28D2530 Offset: 0x28D2631 VA: 0x28D2530
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x28D2740 Offset: 0x28D2841 VA: 0x28D2740
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x28D2950 Offset: 0x28D2A51 VA: 0x28D2950
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>.MoveNext
	|
	|-RVA: 0x28D2B60 Offset: 0x28D2C61 VA: 0x28D2B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>.MoveNext
	|
	|-RVA: 0x28D2D80 Offset: 0x28D2E81 VA: 0x28D2D80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.MoveNext
	|
	|-RVA: 0x28D2F90 Offset: 0x28D3091 VA: 0x28D2F90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.MoveNext
	|
	|-RVA: 0x28D31C0 Offset: 0x28D32C1 VA: 0x28D31C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.MoveNext
	|
	|-RVA: 0x28D33F0 Offset: 0x28D34F1 VA: 0x28D33F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.MoveNext
	|
	|-RVA: 0x28D3600 Offset: 0x28D3701 VA: 0x28D3600
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>.MoveNext
	|
	|-RVA: 0x28D3820 Offset: 0x28D3921 VA: 0x28D3820
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.MoveNext
	|
	|-RVA: 0x28D3A40 Offset: 0x28D3B41 VA: 0x28D3A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.MoveNext
	|
	|-RVA: 0x28D3C60 Offset: 0x28D3D61 VA: 0x28D3C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.MoveNext
	|
	|-RVA: 0x28D3E90 Offset: 0x28D3F91 VA: 0x28D3E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.MoveNext
	|
	|-RVA: 0x28D40A0 Offset: 0x28D41A1 VA: 0x28D40A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.MoveNext
	|
	|-RVA: 0x28D42E0 Offset: 0x28D43E1 VA: 0x28D42E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.MoveNext
	|
	|-RVA: 0x28D4500 Offset: 0x28D4601 VA: 0x28D4500
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.MoveNext
	|
	|-RVA: 0x28D4720 Offset: 0x28D4821 VA: 0x28D4720
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.MoveNext
	|
	|-RVA: 0x28D4940 Offset: 0x28D4A41 VA: 0x28D4940
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.MoveNext
	|
	|-RVA: 0x28D4B60 Offset: 0x28D4C61 VA: 0x28D4B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.MoveNext
	|
	|-RVA: 0x28D4D80 Offset: 0x28D4E81 VA: 0x28D4D80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.MoveNext
	|
	|-RVA: 0x28D4FA0 Offset: 0x28D50A1 VA: 0x28D4FA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.MoveNext
	|
	|-RVA: 0x28D51C0 Offset: 0x28D52C1 VA: 0x28D51C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.MoveNext
	|
	|-RVA: 0x28D53E0 Offset: 0x28D54E1 VA: 0x28D53E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.MoveNext
	|
	|-RVA: 0x28D5600 Offset: 0x28D5701 VA: 0x28D5600
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x28D5810 Offset: 0x28D5911 VA: 0x28D5810
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.MoveNext
	|
	|-RVA: 0x28D5A30 Offset: 0x28D5B31 VA: 0x28D5A30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.MoveNext
	|
	|-RVA: 0x28D5C50 Offset: 0x28D5D51 VA: 0x28D5C50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>.MoveNext
	|
	|-RVA: 0x28D5E60 Offset: 0x28D5F61 VA: 0x28D5E60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.MoveNext
	|
	|-RVA: 0x28D6070 Offset: 0x28D6171 VA: 0x28D6070
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.MoveNext
	|
	|-RVA: 0x28D6280 Offset: 0x28D6381 VA: 0x28D6280
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>.MoveNext
	|
	|-RVA: 0x28D6490 Offset: 0x28D6591 VA: 0x28D6490
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>.MoveNext
	|
	|-RVA: 0x28D66A0 Offset: 0x28D67A1 VA: 0x28D66A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>.MoveNext
	|
	|-RVA: 0x28D68D0 Offset: 0x28D69D1 VA: 0x28D68D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>.MoveNext
	|
	|-RVA: 0x28D6AF0 Offset: 0x28D6BF1 VA: 0x28D6AF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>.MoveNext
	|
	|-RVA: 0x28D6D10 Offset: 0x28D6E11 VA: 0x28D6D10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>.MoveNext
	|
	|-RVA: 0x28D6F20 Offset: 0x28D7021 VA: 0x28D6F20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>.MoveNext
	|
	|-RVA: 0x28D7140 Offset: 0x28D7241 VA: 0x28D7140
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x28D7350 Offset: 0x28D7451 VA: 0x28D7350
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>.MoveNext
	|
	|-RVA: 0x28D7570 Offset: 0x28D7671 VA: 0x28D7570
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>.MoveNext
	|
	|-RVA: 0x28D77A0 Offset: 0x28D78A1 VA: 0x28D77A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>.MoveNext
	|
	|-RVA: 0x28D79B0 Offset: 0x28D7AB1 VA: 0x28D79B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>.MoveNext
	|
	|-RVA: 0x28D7BF0 Offset: 0x28D7CF1 VA: 0x28D7BF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.MoveNext
	|
	|-RVA: 0x28D7E10 Offset: 0x28D7F11 VA: 0x28D7E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>.MoveNext
	|
	|-RVA: 0x28D8030 Offset: 0x28D8131 VA: 0x28D8030
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>.MoveNext
	|
	|-RVA: 0x28D8240 Offset: 0x28D8341 VA: 0x28D8240
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>.MoveNext
	|
	|-RVA: 0x28D8460 Offset: 0x28D8561 VA: 0x28D8460
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>.MoveNext
	|
	|-RVA: 0x28D8680 Offset: 0x28D8781 VA: 0x28D8680
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x28D88A0 Offset: 0x28D89A1 VA: 0x28D88A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.MoveNext
	|
	|-RVA: 0x28D8AC0 Offset: 0x28D8BC1 VA: 0x28D8AC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>.MoveNext
	|
	|-RVA: 0x28D8CD0 Offset: 0x28D8DD1 VA: 0x28D8CD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>.MoveNext
	|
	|-RVA: 0x28D8EE0 Offset: 0x28D8FE1 VA: 0x28D8EE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>.MoveNext
	|
	|-RVA: 0x28D9100 Offset: 0x28D9201 VA: 0x28D9100
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>.MoveNext
	|
	|-RVA: 0x28D9320 Offset: 0x28D9421 VA: 0x28D9320
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>.MoveNext
	|
	|-RVA: 0x28D9540 Offset: 0x28D9641 VA: 0x28D9540
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.MoveNext
	|
	|-RVA: 0x28D9760 Offset: 0x28D9861 VA: 0x28D9760
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.MoveNext
	|
	|-RVA: 0x28D9970 Offset: 0x28D9A71 VA: 0x28D9970
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.MoveNext
	|
	|-RVA: 0x28D9B80 Offset: 0x28D9C81 VA: 0x28D9B80
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>.MoveNext
	|
	|-RVA: 0x28D9DC0 Offset: 0x28D9EC1 VA: 0x28D9DC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>.MoveNext
	|
	|-RVA: 0x28D9FD0 Offset: 0x28DA0D1 VA: 0x28D9FD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>.MoveNext
	|
	|-RVA: 0x28DA1E0 Offset: 0x28DA2E1 VA: 0x28DA1E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.MoveNext
	|
	|-RVA: 0x28DA3F0 Offset: 0x28DA4F1 VA: 0x28DA3F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>.MoveNext
	|
	|-RVA: 0x28DA600 Offset: 0x28DA701 VA: 0x28DA600
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x28DA810 Offset: 0x28DA911 VA: 0x28DA810
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.MoveNext
	|
	|-RVA: 0x28DAA20 Offset: 0x28DAB21 VA: 0x28DAA20
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.MoveNext
	|
	|-RVA: 0x28DAC30 Offset: 0x28DAD31 VA: 0x28DAC30
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.MoveNext
	|
	|-RVA: 0x28DAE60 Offset: 0x28DAF61 VA: 0x28DAE60
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.MoveNext
	|
	|-RVA: 0x28DB090 Offset: 0x28DB191 VA: 0x28DB090
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.MoveNext
	|
	|-RVA: 0x28DB2C0 Offset: 0x28DB3C1 VA: 0x28DB2C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.MoveNext
	|
	|-RVA: 0x28DB4D0 Offset: 0x28DB5D1 VA: 0x28DB4D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.MoveNext
	|
	|-RVA: 0x28DB6E0 Offset: 0x28DB7E1 VA: 0x28DB6E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>.MoveNext
	|
	|-RVA: 0x28DB900 Offset: 0x28DBA01 VA: 0x28DB900
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>.MoveNext
	|
	|-RVA: 0x28DBB20 Offset: 0x28DBC21 VA: 0x28DBB20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>.MoveNext
	|
	|-RVA: 0x28DBD40 Offset: 0x28DBE41 VA: 0x28DBD40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>.MoveNext
	|
	|-RVA: 0x28DBF50 Offset: 0x28DC051 VA: 0x28DBF50
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.MoveNext
	|
	|-RVA: 0x28DC160 Offset: 0x28DC261 VA: 0x28DC160
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.MoveNext
	|
	|-RVA: 0x28DC370 Offset: 0x28DC471 VA: 0x28DC370
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>.MoveNext
	|
	|-RVA: 0x28DC590 Offset: 0x28DC691 VA: 0x28DC590
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>.MoveNext
	|
	|-RVA: 0x28DC7C0 Offset: 0x28DC8C1 VA: 0x28DC7C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>.MoveNext
	|
	|-RVA: 0x28DC9D0 Offset: 0x28DCAD1 VA: 0x28DC9D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>.MoveNext
	|
	|-RVA: 0x28DCC10 Offset: 0x28DCD11 VA: 0x28DCC10
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>.MoveNext
	|
	|-RVA: 0x28DCE30 Offset: 0x28DCF31 VA: 0x28DCE30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>.MoveNext
	|
	|-RVA: 0x28DD050 Offset: 0x28DD151 VA: 0x28DD050
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>.MoveNext
	|
	|-RVA: 0x28DD260 Offset: 0x28DD361 VA: 0x28DD260
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>.MoveNext
	|
	|-RVA: 0x28DD480 Offset: 0x28DD581 VA: 0x28DD480
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>.MoveNext
	|
	|-RVA: 0x28DD6A0 Offset: 0x28DD7A1 VA: 0x28DD6A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.MoveNext
	|
	|-RVA: 0x28DD8B0 Offset: 0x28DD9B1 VA: 0x28DD8B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.MoveNext
	|
	|-RVA: 0x28DDAC0 Offset: 0x28DDBC1 VA: 0x28DDAC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>.MoveNext
	|
	|-RVA: 0x28DDCD0 Offset: 0x28DDDD1 VA: 0x28DDCD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>.MoveNext
	|
	|-RVA: 0x28DDEE0 Offset: 0x28DDFE1 VA: 0x28DDEE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>.MoveNext
	|
	|-RVA: 0x28DE100 Offset: 0x28DE201 VA: 0x28DE100
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>.MoveNext
	|
	|-RVA: 0x28DE320 Offset: 0x28DE421 VA: 0x28DE320
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>.MoveNext
	|
	|-RVA: 0x28DE540 Offset: 0x28DE641 VA: 0x28DE540
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.MoveNext
	|
	|-RVA: 0x28DE760 Offset: 0x28DE861 VA: 0x28DE760
	|-Array.EmptyInternalEnumerator<DateTime>.MoveNext
	|
	|-RVA: 0x28DE970 Offset: 0x28DEA71 VA: 0x28DE970
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.MoveNext
	|
	|-RVA: 0x28DEB80 Offset: 0x28DEC81 VA: 0x28DEB80
	|-Array.EmptyInternalEnumerator<Decimal>.MoveNext
	|
	|-RVA: 0x28DED90 Offset: 0x28DEE91 VA: 0x28DED90
	|-Array.EmptyInternalEnumerator<double>.MoveNext
	|
	|-RVA: 0x28DEFA0 Offset: 0x28DF0A1 VA: 0x28DEFA0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.MoveNext
	|
	|-RVA: 0x28DF1B0 Offset: 0x28DF2B1 VA: 0x28DF1B0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.MoveNext
	|
	|-RVA: 0x273E7F0 Offset: 0x273E8F1 VA: 0x273E7F0
	|-Array.EmptyInternalEnumerator<Guid>.MoveNext
	|
	|-RVA: 0x273EA00 Offset: 0x273EB01 VA: 0x273EA00
	|-Array.EmptyInternalEnumerator<short>.MoveNext
	|
	|-RVA: 0x273EC10 Offset: 0x273ED11 VA: 0x273EC10
	|-Array.EmptyInternalEnumerator<int>.MoveNext
	|
	|-RVA: 0x273EE20 Offset: 0x273EF21 VA: 0x273EE20
	|-Array.EmptyInternalEnumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x273F030 Offset: 0x273F131 VA: 0x273F030
	|-Array.EmptyInternalEnumerator<long>.MoveNext
	|
	|-RVA: 0x273F240 Offset: 0x273F341 VA: 0x273F240
	|-Array.EmptyInternalEnumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x273F450 Offset: 0x273F551 VA: 0x273F450
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.MoveNext
	|
	|-RVA: 0x273F660 Offset: 0x273F761 VA: 0x273F660
	|-Array.EmptyInternalEnumerator<LocalDefinition>.MoveNext
	|
	|-RVA: 0x273F870 Offset: 0x273F971 VA: 0x273F870
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.MoveNext
	|
	|-RVA: 0x273FA80 Offset: 0x273FB81 VA: 0x273FA80
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>.MoveNext
	|
	|-RVA: 0x273FC90 Offset: 0x273FD91 VA: 0x273FC90
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.MoveNext
	|
	|-RVA: 0x273FEB0 Offset: 0x273FFB1 VA: 0x273FEB0
	|-Array.EmptyInternalEnumerator<Memory<object>>.MoveNext
	|
	|-RVA: 0x27400C0 Offset: 0x27401C1 VA: 0x27400C0
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.MoveNext
	|
	|-RVA: 0x27402D0 Offset: 0x27403D1 VA: 0x27402D0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.MoveNext
	|
	|-RVA: 0x27404E0 Offset: 0x27405E1 VA: 0x27404E0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.MoveNext
	|
	|-RVA: 0x27406F0 Offset: 0x27407F1 VA: 0x27406F0
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>.MoveNext
	|
	|-RVA: 0x2740920 Offset: 0x2740A21 VA: 0x2740920
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>.MoveNext
	|
	|-RVA: 0x2740B30 Offset: 0x2740C31 VA: 0x2740B30
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>.MoveNext
	|
	|-RVA: 0x2740D60 Offset: 0x2740E61 VA: 0x2740D60
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>.MoveNext
	|
	|-RVA: 0x2740F90 Offset: 0x2741091 VA: 0x2740F90
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>.MoveNext
	|
	|-RVA: 0x27411A0 Offset: 0x27412A1 VA: 0x27411A0
	|-Array.EmptyInternalEnumerator<Nullable<Color>>.MoveNext
	|
	|-RVA: 0x27413C0 Offset: 0x27414C1 VA: 0x27413C0
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>.MoveNext
	|
	|-RVA: 0x27415D0 Offset: 0x27416D1 VA: 0x27415D0
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>.MoveNext
	|
	|-RVA: 0x27417F0 Offset: 0x27418F1 VA: 0x27417F0
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>.MoveNext
	|
	|-RVA: 0x2741A10 Offset: 0x2741B11 VA: 0x2741A10
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>.MoveNext
	|
	|-RVA: 0x2741C20 Offset: 0x2741D21 VA: 0x2741C20
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>.MoveNext
	|
	|-RVA: 0x2741E60 Offset: 0x2741F61 VA: 0x2741E60
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>.MoveNext
	|
	|-RVA: 0x2742080 Offset: 0x2742181 VA: 0x2742080
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>.MoveNext
	|
	|-RVA: 0x2742290 Offset: 0x2742391 VA: 0x2742290
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>.MoveNext
	|
	|-RVA: 0x27424B0 Offset: 0x27425B1 VA: 0x27424B0
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>.MoveNext
	|
	|-RVA: 0x27426D0 Offset: 0x27427D1 VA: 0x27426D0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>.MoveNext
	|
	|-RVA: 0x27428E0 Offset: 0x27429E1 VA: 0x27428E0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>.MoveNext
	|
	|-RVA: 0x2742AF0 Offset: 0x2742BF1 VA: 0x2742AF0
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>.MoveNext
	|
	|-RVA: 0x2742D00 Offset: 0x2742E01 VA: 0x2742D00
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>.MoveNext
	|
	|-RVA: 0x2742F10 Offset: 0x2743011 VA: 0x2742F10
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>.MoveNext
	|
	|-RVA: 0x2743130 Offset: 0x2743231 VA: 0x2743130
	|-Array.EmptyInternalEnumerator<object>.MoveNext
	|
	|-RVA: 0x2743300 Offset: 0x2743401 VA: 0x2743300
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.MoveNext
	|
	|-RVA: 0x2743510 Offset: 0x2743611 VA: 0x2743510
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>.MoveNext
	|
	|-RVA: 0x2743720 Offset: 0x2743821 VA: 0x2743720
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.MoveNext
	|
	|-RVA: 0x2743940 Offset: 0x2743A41 VA: 0x2743940
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.MoveNext
	|
	|-RVA: 0x2743B50 Offset: 0x2743C51 VA: 0x2743B50
	|-Array.EmptyInternalEnumerator<Label>.MoveNext
	|
	|-RVA: 0x2743D60 Offset: 0x2743E61 VA: 0x2743D60
	|-Array.EmptyInternalEnumerator<ParameterModifier>.MoveNext
	|
	|-RVA: 0x2743F70 Offset: 0x2744071 VA: 0x2743F70
	|-Array.EmptyInternalEnumerator<ResourceLocator>.MoveNext
	|
	|-RVA: 0x2744180 Offset: 0x2744281 VA: 0x2744180
	|-Array.EmptyInternalEnumerator<Ephemeron>.MoveNext
	|
	|-RVA: 0x2744390 Offset: 0x2744491 VA: 0x2744390
	|-Array.EmptyInternalEnumerator<GCHandle>.MoveNext
	|
	|-RVA: 0x27445A0 Offset: 0x27446A1 VA: 0x27445A0
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>.MoveNext
	|
	|-RVA: 0x27447B0 Offset: 0x27448B1 VA: 0x27447B0
	|-Array.EmptyInternalEnumerator<sbyte>.MoveNext
	|
	|-RVA: 0x27449C0 Offset: 0x2744AC1 VA: 0x27449C0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.MoveNext
	|
	|-RVA: 0x2744BD0 Offset: 0x2744CD1 VA: 0x2744BD0
	|-Array.EmptyInternalEnumerator<float>.MoveNext
	|
	|-RVA: 0x2744DE0 Offset: 0x2744EE1 VA: 0x2744DE0
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.MoveNext
	|
	|-RVA: 0x2744FF0 Offset: 0x27450F1 VA: 0x2744FF0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.MoveNext
	|
	|-RVA: 0x2745210 Offset: 0x2745311 VA: 0x2745210
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.MoveNext
	|
	|-RVA: 0x2745420 Offset: 0x2745521 VA: 0x2745420
	|-Array.EmptyInternalEnumerator<TimeSpan>.MoveNext
	|
	|-RVA: 0x2745630 Offset: 0x2745731 VA: 0x2745630
	|-Array.EmptyInternalEnumerator<ushort>.MoveNext
	|
	|-RVA: 0x2745840 Offset: 0x2745941 VA: 0x2745840
	|-Array.EmptyInternalEnumerator<UInt16Enum>.MoveNext
	|
	|-RVA: 0x2745A50 Offset: 0x2745B51 VA: 0x2745A50
	|-Array.EmptyInternalEnumerator<uint>.MoveNext
	|
	|-RVA: 0x2745C60 Offset: 0x2745D61 VA: 0x2745C60
	|-Array.EmptyInternalEnumerator<UInt32Enum>.MoveNext
	|
	|-RVA: 0x2745E70 Offset: 0x2745F71 VA: 0x2745E70
	|-Array.EmptyInternalEnumerator<ulong>.MoveNext
	|
	|-RVA: 0x2746080 Offset: 0x2746181 VA: 0x2746080
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2746290 Offset: 0x2746391 VA: 0x2746290
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x27464A0 Offset: 0x27465A1 VA: 0x27464A0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x27466B0 Offset: 0x27467B1 VA: 0x27466B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x27468C0 Offset: 0x27469C1 VA: 0x27468C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x2746AD0 Offset: 0x2746BD1 VA: 0x2746AD0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.MoveNext
	|
	|-RVA: 0x2746CE0 Offset: 0x2746DE1 VA: 0x2746CE0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>.MoveNext
	|
	|-RVA: 0x2746EF0 Offset: 0x2746FF1 VA: 0x2746EF0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>.MoveNext
	|
	|-RVA: 0x2747100 Offset: 0x2747201 VA: 0x2747100
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>.MoveNext
	|
	|-RVA: 0x2747330 Offset: 0x2747431 VA: 0x2747330
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2747540 Offset: 0x2747641 VA: 0x2747540
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>.MoveNext
	|
	|-RVA: 0x2747760 Offset: 0x2747861 VA: 0x2747760
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>.MoveNext
	|
	|-RVA: 0x2747980 Offset: 0x2747A81 VA: 0x2747980
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.MoveNext
	|
	|-RVA: 0x2747BB0 Offset: 0x2747CB1 VA: 0x2747BB0
	|-Array.EmptyInternalEnumerator<HighlightState>.MoveNext
	|
	|-RVA: 0x2747DD0 Offset: 0x2747ED1 VA: 0x2747DD0
	|-Array.EmptyInternalEnumerator<MaterialReference>.MoveNext
	|
	|-RVA: 0x2748000 Offset: 0x2748101 VA: 0x2748000
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.MoveNext
	|
	|-RVA: 0x2748220 Offset: 0x2748321 VA: 0x2748220
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.MoveNext
	|
	|-RVA: 0x2748450 Offset: 0x2748551 VA: 0x2748450
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.MoveNext
	|
	|-RVA: 0x2748670 Offset: 0x2748771 VA: 0x2748670
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.MoveNext
	|
	|-RVA: 0x2748880 Offset: 0x2748981 VA: 0x2748880
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.MoveNext
	|
	|-RVA: 0x2748AD0 Offset: 0x2748BD1 VA: 0x2748AD0
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.MoveNext
	|
	|-RVA: 0x2748D00 Offset: 0x2748E01 VA: 0x2748D00
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.MoveNext
	|
	|-RVA: 0x2748F40 Offset: 0x2749041 VA: 0x2748F40
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.MoveNext
	|
	|-RVA: 0x2749160 Offset: 0x2749261 VA: 0x2749160
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.MoveNext
	|
	|-RVA: 0x2749370 Offset: 0x2749471 VA: 0x2749370
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.MoveNext
	|
	|-RVA: 0x2749590 Offset: 0x2749691 VA: 0x2749590
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.MoveNext
	|
	|-RVA: 0x27497B0 Offset: 0x27498B1 VA: 0x27497B0
	|-Array.EmptyInternalEnumerator<WordWrapState>.MoveNext
	|
	|-RVA: 0x27499D0 Offset: 0x2749AD1 VA: 0x27499D0
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>.MoveNext
	|
	|-RVA: 0x2749C00 Offset: 0x2749D01 VA: 0x2749C00
	|-Array.EmptyInternalEnumerator<TransitionTables>.MoveNext
	|
	|-RVA: 0x2749E20 Offset: 0x2749F21 VA: 0x2749E20
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>.MoveNext
	|
	|-RVA: 0x274A030 Offset: 0x274A131 VA: 0x274A030
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>.MoveNext
	|
	|-RVA: 0x274A240 Offset: 0x274A341 VA: 0x274A240
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>.MoveNext
	|
	|-RVA: 0x274A450 Offset: 0x274A551 VA: 0x274A450
	|-Array.EmptyInternalEnumerator<CapEdge>.MoveNext
	|
	|-RVA: 0x274A680 Offset: 0x274A781 VA: 0x274A680
	|-Array.EmptyInternalEnumerator<ClippedEdge>.MoveNext
	|
	|-RVA: 0x274A8A0 Offset: 0x274A9A1 VA: 0x274A8A0
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>.MoveNext
	|
	|-RVA: 0x274AAB0 Offset: 0x274ABB1 VA: 0x274AAB0
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>.MoveNext
	|
	|-RVA: 0x274ACC0 Offset: 0x274ADC1 VA: 0x274ACC0
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>.MoveNext
	|
	|-RVA: 0x274AED0 Offset: 0x274AFD1 VA: 0x274AED0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.MoveNext
	|
	|-RVA: 0x274B0F0 Offset: 0x274B1F1 VA: 0x274B0F0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>.MoveNext
	|
	|-RVA: 0x274B320 Offset: 0x274B421 VA: 0x274B320
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>.MoveNext
	|
	|-RVA: 0x274B530 Offset: 0x274B631 VA: 0x274B530
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>.MoveNext
	|
	|-RVA: 0x274B780 Offset: 0x274B881 VA: 0x274B780
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.MoveNext
	|
	|-RVA: 0x274B990 Offset: 0x274BA91 VA: 0x274B990
	|-Array.EmptyInternalEnumerator<ConstraintSource>.MoveNext
	|
	|-RVA: 0x274BBA0 Offset: 0x274BCA1 VA: 0x274BBA0
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>.MoveNext
	|
	|-RVA: 0x274BDB0 Offset: 0x274BEB1 VA: 0x274BDB0
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>.MoveNext
	|
	|-RVA: 0x274BFC0 Offset: 0x274C0C1 VA: 0x274BFC0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.MoveNext
	|
	|-RVA: 0x274C1D0 Offset: 0x274C2D1 VA: 0x274C1D0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x274C3E0 Offset: 0x274C4E1 VA: 0x274C3E0
	|-Array.EmptyInternalEnumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x274C5F0 Offset: 0x274C6F1 VA: 0x274C5F0
	|-Array.EmptyInternalEnumerator<BoneWeight>.MoveNext
	|
	|-RVA: 0x274C810 Offset: 0x274C911 VA: 0x274C810
	|-Array.EmptyInternalEnumerator<BoundingSphere>.MoveNext
	|
	|-RVA: 0x274CA20 Offset: 0x274CB21 VA: 0x274CA20
	|-Array.EmptyInternalEnumerator<Bounds>.MoveNext
	|
	|-RVA: 0x274CC40 Offset: 0x274CD41 VA: 0x274CC40
	|-Array.EmptyInternalEnumerator<BoundsInt>.MoveNext
	|
	|-RVA: 0x274CE60 Offset: 0x274CF61 VA: 0x274CE60
	|-Array.EmptyInternalEnumerator<CharacterInfo>.MoveNext
	|
	|-RVA: 0x274D090 Offset: 0x274D191 VA: 0x274D090
	|-Array.EmptyInternalEnumerator<Color32>.MoveNext
	|
	|-RVA: 0x274D2A0 Offset: 0x274D3A1 VA: 0x274D2A0
	|-Array.EmptyInternalEnumerator<Color>.MoveNext
	|
	|-RVA: 0x274D4B0 Offset: 0x274D5B1 VA: 0x274D4B0
	|-Array.EmptyInternalEnumerator<CombineInstance>.MoveNext
	|
	|-RVA: 0x274D700 Offset: 0x274D801 VA: 0x274D700
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.MoveNext
	|
	|-RVA: 0x274D930 Offset: 0x274DA31 VA: 0x274D930
	|-Array.EmptyInternalEnumerator<ContactPoint>.MoveNext
	|
	|-RVA: 0x274DB60 Offset: 0x274DC61 VA: 0x274DB60
	|-Array.EmptyInternalEnumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x274DDA0 Offset: 0x274DEA1 VA: 0x274DDA0
	|-Array.EmptyInternalEnumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x274DFE0 Offset: 0x274E0E1 VA: 0x274DFE0
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.MoveNext
	|
	|-RVA: 0x274E1F0 Offset: 0x274E2F1 VA: 0x274E1F0
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>.MoveNext
	|
	|-RVA: 0x274E400 Offset: 0x274E501 VA: 0x274E400
	|-Array.EmptyInternalEnumerator<GradientColorKey>.MoveNext
	|
	|-RVA: 0x274E620 Offset: 0x274E721 VA: 0x274E620
	|-Array.EmptyInternalEnumerator<HumanBone>.MoveNext
	|
	|-RVA: 0x274E850 Offset: 0x274E951 VA: 0x274E850
	|-Array.EmptyInternalEnumerator<Keyframe>.MoveNext
	|
	|-RVA: 0x274EA80 Offset: 0x274EB81 VA: 0x274EA80
	|-Array.EmptyInternalEnumerator<LOD>.MoveNext
	|
	|-RVA: 0x274EC90 Offset: 0x274ED91 VA: 0x274EC90
	|-Array.EmptyInternalEnumerator<LayerMask>.MoveNext
	|
	|-RVA: 0x274EEA0 Offset: 0x274EFA1 VA: 0x274EEA0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.MoveNext
	|
	|-RVA: 0x274F0D0 Offset: 0x274F1D1 VA: 0x274F0D0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x274F300 Offset: 0x274F401 VA: 0x274F300
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x274F520 Offset: 0x274F621 VA: 0x274F520
	|-Array.EmptyInternalEnumerator<PatchExtents>.MoveNext
	|
	|-RVA: 0x274F730 Offset: 0x274F831 VA: 0x274F730
	|-Array.EmptyInternalEnumerator<Plane>.MoveNext
	|
	|-RVA: 0x274F940 Offset: 0x274FA41 VA: 0x274F940
	|-Array.EmptyInternalEnumerator<Playable>.MoveNext
	|
	|-RVA: 0x274FB50 Offset: 0x274FC51 VA: 0x274FB50
	|-Array.EmptyInternalEnumerator<PlayableBinding>.MoveNext
	|
	|-RVA: 0x274FD70 Offset: 0x274FE71 VA: 0x274FD70
	|-Array.EmptyInternalEnumerator<PlayableGraph>.MoveNext
	|
	|-RVA: 0x274FF80 Offset: 0x2750081 VA: 0x274FF80
	|-Array.EmptyInternalEnumerator<Edge>.MoveNext
	|
	|-RVA: 0x2750190 Offset: 0x2750291 VA: 0x2750190
	|-Array.EmptyInternalEnumerator<IntVec3>.MoveNext
	|
	|-RVA: 0x27503A0 Offset: 0x27504A1 VA: 0x27503A0
	|-Array.EmptyInternalEnumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x27505B0 Offset: 0x27506B1 VA: 0x27505B0
	|-Array.EmptyInternalEnumerator<RangeInt>.MoveNext
	|
	|-RVA: 0x27507C0 Offset: 0x27508C1 VA: 0x27507C0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x27509F0 Offset: 0x2750AF1 VA: 0x27509F0
	|-Array.EmptyInternalEnumerator<RaycastHit>.MoveNext
	|
	|-RVA: 0x2750C20 Offset: 0x2750D21 VA: 0x2750C20
	|-Array.EmptyInternalEnumerator<Rect>.MoveNext
	|
	|-RVA: 0x2750E30 Offset: 0x2750F31 VA: 0x2750E30
	|-Array.EmptyInternalEnumerator<RectInt>.MoveNext
	|
	|-RVA: 0x2751040 Offset: 0x2751141 VA: 0x2751040
	|-Array.EmptyInternalEnumerator<RenderBuffer>.MoveNext
	|
	|-RVA: 0x2751250 Offset: 0x2751351 VA: 0x2751250
	|-Array.EmptyInternalEnumerator<BatchVisibility>.MoveNext
	|
	|-RVA: 0x2751460 Offset: 0x2751561 VA: 0x2751460
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>.MoveNext
	|
	|-RVA: 0x2751670 Offset: 0x2751771 VA: 0x2751670
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.MoveNext
	|
	|-RVA: 0x27518C0 Offset: 0x27519C1 VA: 0x27518C0
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x2751AD0 Offset: 0x2751BD1 VA: 0x2751AD0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2751CF0 Offset: 0x2751DF1 VA: 0x2751CF0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x2751F10 Offset: 0x2752011 VA: 0x2751F10
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>.MoveNext
	|
	|-RVA: 0x2752130 Offset: 0x2752231 VA: 0x2752130
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x2752360 Offset: 0x2752461 VA: 0x2752360
	|-Array.EmptyInternalEnumerator<SceneInstance>.MoveNext
	|
	|-RVA: 0x2752570 Offset: 0x2752671 VA: 0x2752570
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.MoveNext
	|
	|-RVA: 0x2752790 Offset: 0x2752891 VA: 0x2752790
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.MoveNext
	|
	|-RVA: 0x27529C0 Offset: 0x2752AC1 VA: 0x27529C0
	|-Array.EmptyInternalEnumerator<SerializedType>.MoveNext
	|
	|-RVA: 0x2752BE0 Offset: 0x2752CE1 VA: 0x2752BE0
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.MoveNext
	|
	|-RVA: 0x2752DF0 Offset: 0x2752EF1 VA: 0x2752DF0
	|-Array.EmptyInternalEnumerator<SkeletonBone>.MoveNext
	|
	|-RVA: 0x2753020 Offset: 0x2753121 VA: 0x2753020
	|-Array.EmptyInternalEnumerator<GlyphRect>.MoveNext
	|
	|-RVA: 0x2753230 Offset: 0x2753331 VA: 0x2753230
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.MoveNext
	|
	|-RVA: 0x2753460 Offset: 0x2753561 VA: 0x2753460
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x2753690 Offset: 0x2753791 VA: 0x2753690
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNext
	|
	|-RVA: 0x27538C0 Offset: 0x27539C1 VA: 0x27538C0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.MoveNext
	|
	|-RVA: 0x2753AE0 Offset: 0x2753BE1 VA: 0x2753AE0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.MoveNext
	|
	|-RVA: 0x2753D00 Offset: 0x2753E01 VA: 0x2753D00
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNext
	|
	|-RVA: 0x2753F20 Offset: 0x2754021 VA: 0x2753F20
	|-Array.EmptyInternalEnumerator<Touch>.MoveNext
	|
	|-RVA: 0x2754160 Offset: 0x2754261 VA: 0x2754160
	|-Array.EmptyInternalEnumerator<TreeInstance>.MoveNext
	|
	|-RVA: 0x2754390 Offset: 0x2754491 VA: 0x2754390
	|-Array.EmptyInternalEnumerator<ColorBlock>.MoveNext
	|
	|-RVA: 0x27545D0 Offset: 0x27546D1 VA: 0x27545D0
	|-Array.EmptyInternalEnumerator<Navigation>.MoveNext
	|
	|-RVA: 0x2754800 Offset: 0x2754901 VA: 0x2754800
	|-Array.EmptyInternalEnumerator<SpriteState>.MoveNext
	|
	|-RVA: 0x2754A20 Offset: 0x2754B21 VA: 0x2754A20
	|-Array.EmptyInternalEnumerator<UICharInfo>.MoveNext
	|
	|-RVA: 0x2754C30 Offset: 0x2754D31 VA: 0x2754C30
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>.MoveNext
	|
	|-RVA: 0x2754E40 Offset: 0x2754F41 VA: 0x2754E40
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>.MoveNext
	|
	|-RVA: 0x2755050 Offset: 0x2755151 VA: 0x2755050
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>.MoveNext
	|
	|-RVA: 0x2755260 Offset: 0x2755361 VA: 0x2755260
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>.MoveNext
	|
	|-RVA: 0x2755470 Offset: 0x2755571 VA: 0x2755470
	|-Array.EmptyInternalEnumerator<StyleValue>.MoveNext
	|
	|-RVA: 0x2755690 Offset: 0x2755791 VA: 0x2755690
	|-Array.EmptyInternalEnumerator<UILineInfo>.MoveNext
	|
	|-RVA: 0x27558A0 Offset: 0x27559A1 VA: 0x27558A0
	|-Array.EmptyInternalEnumerator<UIVertex>.MoveNext
	|
	|-RVA: 0x2755AE0 Offset: 0x2755BE1 VA: 0x2755AE0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x2755D00 Offset: 0x2755E01 VA: 0x2755D00
	|-Array.EmptyInternalEnumerator<Vector2>.MoveNext
	|
	|-RVA: 0x2755F10 Offset: 0x2756011 VA: 0x2755F10
	|-Array.EmptyInternalEnumerator<Vector2Int>.MoveNext
	|
	|-RVA: 0x2756120 Offset: 0x2756221 VA: 0x2756120
	|-Array.EmptyInternalEnumerator<Vector3>.MoveNext
	|
	|-RVA: 0x2756330 Offset: 0x2756431 VA: 0x2756330
	|-Array.EmptyInternalEnumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x2756540 Offset: 0x2756641 VA: 0x2756540
	|-Array.EmptyInternalEnumerator<Vector4>.MoveNext
	|
	|-RVA: 0x2756750 Offset: 0x2756851 VA: 0x2756750
	|-Array.EmptyInternalEnumerator<jvalue>.MoveNext
	|
	|-RVA: 0x2756960 Offset: 0x2756A61 VA: 0x2756960
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>.MoveNext
	|
	|-RVA: 0x2756BB0 Offset: 0x2756CB1 VA: 0x2756BB0
	|-Array.EmptyInternalEnumerator<YieldItemParam>.MoveNext
	|
	|-RVA: 0x2756DC0 Offset: 0x2756EC1 VA: 0x2756DC0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.MoveNext
	|
	|-RVA: 0x2756FD0 Offset: 0x27570D1 VA: 0x2756FD0
	|-Array.EmptyInternalEnumerator<Uid>.MoveNext
	|
	|-RVA: 0x27571E0 Offset: 0x27572E1 VA: 0x27571E0
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>.MoveNext
	|
	|-RVA: 0x27573F0 Offset: 0x27574F1 VA: 0x27573F0
	|-Array.EmptyInternalEnumerator<NsUid>.MoveNext
	|
	|-RVA: 0x2757600 Offset: 0x2757701 VA: 0x2757600
	|-Array.EmptyInternalEnumerator<Friend>.MoveNext
	|
	|-RVA: 0x2757820 Offset: 0x2757921 VA: 0x2757820
	|-Array.EmptyInternalEnumerator<Profile>.MoveNext
	|
	|-RVA: 0x2757A40 Offset: 0x2757B41 VA: 0x2757A40
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.MoveNext
	|
	|-RVA: 0x2757C60 Offset: 0x2757D61 VA: 0x2757C60
	|-Array.EmptyInternalEnumerator<DebugPadState>.MoveNext
	|
	|-RVA: 0x2757E80 Offset: 0x2757F81 VA: 0x2757E80
	|-Array.EmptyInternalEnumerator<GesturePoint>.MoveNext
	|
	|-RVA: 0x2758090 Offset: 0x2758191 VA: 0x2758090
	|-Array.EmptyInternalEnumerator<GestureState>.MoveNext
	|
	|-RVA: 0x27582D0 Offset: 0x27583D1 VA: 0x27582D0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.MoveNext
	|
	|-RVA: 0x2758500 Offset: 0x2758601 VA: 0x2758500
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.MoveNext
	|
	|-RVA: 0x2758730 Offset: 0x2758831 VA: 0x2758730
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.MoveNext
	|
	|-RVA: 0x2758960 Offset: 0x2758A61 VA: 0x2758960
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.MoveNext
	|
	|-RVA: 0x2758B90 Offset: 0x2758C91 VA: 0x2758B90
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.MoveNext
	|
	|-RVA: 0x2758DC0 Offset: 0x2758EC1 VA: 0x2758DC0
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.MoveNext
	|
	|-RVA: 0x2469FE0 Offset: 0x246A0E1 VA: 0x2469FE0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.MoveNext
	|
	|-RVA: 0x246A1F0 Offset: 0x246A2F1 VA: 0x246A1F0
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.MoveNext
	|
	|-RVA: 0x246A430 Offset: 0x246A531 VA: 0x246A430
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.MoveNext
	|
	|-RVA: 0x246A650 Offset: 0x246A751 VA: 0x246A650
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.MoveNext
	|
	|-RVA: 0x246A870 Offset: 0x246A971 VA: 0x246A870
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.MoveNext
	|
	|-RVA: 0x246AA90 Offset: 0x246AB91 VA: 0x246AA90
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.MoveNext
	|
	|-RVA: 0x246ACB0 Offset: 0x246ADB1 VA: 0x246ACB0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.MoveNext
	|
	|-RVA: 0x246AED0 Offset: 0x246AFD1 VA: 0x246AED0
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.MoveNext
	|
	|-RVA: 0x246B0F0 Offset: 0x246B1F1 VA: 0x246B0F0
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.MoveNext
	|
	|-RVA: 0x246B310 Offset: 0x246B411 VA: 0x246B310
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.MoveNext
	|
	|-RVA: 0x246B540 Offset: 0x246B641 VA: 0x246B540
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.MoveNext
	|
	|-RVA: 0x246B780 Offset: 0x246B881 VA: 0x246B780
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.MoveNext
	|
	|-RVA: 0x246B9A0 Offset: 0x246BAA1 VA: 0x246B9A0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.MoveNext
	|
	|-RVA: 0x246BBC0 Offset: 0x246BCC1 VA: 0x246BBC0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.MoveNext
	|
	|-RVA: 0x246BDE0 Offset: 0x246BEE1 VA: 0x246BDE0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.MoveNext
	|
	|-RVA: 0x246C000 Offset: 0x246C101 VA: 0x246C000
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.MoveNext
	|
	|-RVA: 0x246C220 Offset: 0x246C321 VA: 0x246C220
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.MoveNext
	|
	|-RVA: 0x246C440 Offset: 0x246C541 VA: 0x246C440
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.MoveNext
	|
	|-RVA: 0x246C660 Offset: 0x246C761 VA: 0x246C660
	|-Array.EmptyInternalEnumerator<TouchState>.MoveNext
	|
	|-RVA: 0x246C890 Offset: 0x246C991 VA: 0x246C890
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.MoveNext
	|
	|-RVA: 0x246CAA0 Offset: 0x246CBA1 VA: 0x246CAA0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.MoveNext
	|
	|-RVA: 0x246CCB0 Offset: 0x246CDB1 VA: 0x246CCB0
	|-Array.EmptyInternalEnumerator<VibrationValue>.MoveNext
	|
	|-RVA: 0x246CEC0 Offset: 0x246CFC1 VA: 0x246CEC0
	|-Array.EmptyInternalEnumerator<ClusteringData>.MoveNext
	|
	|-RVA: 0x246D0E0 Offset: 0x246D1E1 VA: 0x246D0E0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.MoveNext
	|
	|-RVA: 0x246D300 Offset: 0x246D401 VA: 0x246D300
	|-Array.EmptyInternalEnumerator<Finger>.MoveNext
	|
	|-RVA: 0x246D530 Offset: 0x246D631 VA: 0x246D530
	|-Array.EmptyInternalEnumerator<Hand>.MoveNext
	|
	|-RVA: 0x246D750 Offset: 0x246D851 VA: 0x246D750
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.MoveNext
	|
	|-RVA: 0x246D960 Offset: 0x246DA61 VA: 0x246D960
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.MoveNext
	|
	|-RVA: 0x246DB80 Offset: 0x246DC81 VA: 0x246DB80
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.MoveNext
	|
	|-RVA: 0x246DDA0 Offset: 0x246DEA1 VA: 0x246DDA0
	|-Array.EmptyInternalEnumerator<MomentStatistic>.MoveNext
	|
	|-RVA: 0x246DFB0 Offset: 0x246E0B1 VA: 0x246DFB0
	|-Array.EmptyInternalEnumerator<Protrusion>.MoveNext
	|
	|-RVA: 0x246E1C0 Offset: 0x246E2C1 VA: 0x246E1C0
	|-Array.EmptyInternalEnumerator<Shape>.MoveNext
	|
	|-RVA: 0x246E3E0 Offset: 0x246E4E1 VA: 0x246E3E0
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.MoveNext
	|
	|-RVA: 0x246E5F0 Offset: 0x246E6F1 VA: 0x246E5F0
	|-Array.EmptyInternalEnumerator<UserWord>.MoveNext
	|
	|-RVA: 0x246E800 Offset: 0x246E901 VA: 0x246E800
	|-Array.EmptyInternalEnumerator<Color4u8>.MoveNext
	|
	|-RVA: 0x246EA10 Offset: 0x246EB11 VA: 0x246EA10
	|-Array.EmptyInternalEnumerator<Float2>.MoveNext
	|
	|-RVA: 0x246EC20 Offset: 0x246ED21 VA: 0x246EC20
	|-Array.EmptyInternalEnumerator<stCommand_t>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4BB0 Offset: 0x28A4CB1 VA: 0x28A4BB0
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>.get_Current
	|
	|-RVA: 0x28A4DD0 Offset: 0x28A4ED1 VA: 0x28A4DD0
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>.get_Current
	|
	|-RVA: 0x28A5010 Offset: 0x28A5111 VA: 0x28A5010
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>.get_Current
	|
	|-RVA: 0x28A5220 Offset: 0x28A5321 VA: 0x28A5220
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>.get_Current
	|
	|-RVA: 0x28A5430 Offset: 0x28A5531 VA: 0x28A5430
	|-Array.EmptyInternalEnumerator<BitVector32Int>.get_Current
	|
	|-RVA: 0x28A5640 Offset: 0x28A5741 VA: 0x28A5640
	|-Array.EmptyInternalEnumerator<BuildItemData>.get_Current
	|
	|-RVA: 0x28A5890 Offset: 0x28A5991 VA: 0x28A5890
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>.get_Current
	|
	|-RVA: 0x28A5AA0 Offset: 0x28A5BA1 VA: 0x28A5AA0
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>.get_Current
	|
	|-RVA: 0x28A5CB0 Offset: 0x28A5DB1 VA: 0x28A5CB0
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>.get_Current
	|
	|-RVA: 0x28A5EC0 Offset: 0x28A5FC1 VA: 0x28A5EC0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.get_Current
	|
	|-RVA: 0x28A60D0 Offset: 0x28A61D1 VA: 0x28A60D0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.get_Current
	|
	|-RVA: 0x28A62F0 Offset: 0x28A63F1 VA: 0x28A62F0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.get_Current
	|
	|-RVA: 0x28A6510 Offset: 0x28A6611 VA: 0x28A6510
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.get_Current
	|
	|-RVA: 0x28A6720 Offset: 0x28A6821 VA: 0x28A6720
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.get_Current
	|
	|-RVA: 0x28A6930 Offset: 0x28A6A31 VA: 0x28A6930
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.get_Current
	|
	|-RVA: 0x28A6B60 Offset: 0x28A6C61 VA: 0x28A6B60
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.get_Current
	|
	|-RVA: 0x28A6D70 Offset: 0x28A6E71 VA: 0x28A6D70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.get_Current
	|
	|-RVA: 0x28A6F80 Offset: 0x28A7081 VA: 0x28A6F80
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.get_Current
	|
	|-RVA: 0x28A71A0 Offset: 0x28A72A1 VA: 0x28A71A0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.get_Current
	|
	|-RVA: 0x28A73B0 Offset: 0x28A74B1 VA: 0x28A73B0
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.get_Current
	|
	|-RVA: 0x28A75C0 Offset: 0x28A76C1 VA: 0x28A75C0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.get_Current
	|
	|-RVA: 0x28A77F0 Offset: 0x28A78F1 VA: 0x28A77F0
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.get_Current
	|
	|-RVA: 0x28A7A20 Offset: 0x28A7B21 VA: 0x28A7A20
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.get_Current
	|
	|-RVA: 0x28A7C50 Offset: 0x28A7D51 VA: 0x28A7C50
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.get_Current
	|
	|-RVA: 0x28A7E70 Offset: 0x28A7F71 VA: 0x28A7E70
	|-Array.EmptyInternalEnumerator<CropDataTable>.get_Current
	|
	|-RVA: 0x28A8090 Offset: 0x28A8191 VA: 0x28A8090
	|-Array.EmptyInternalEnumerator<ControlPoint>.get_Current
	|
	|-RVA: 0x28A82B0 Offset: 0x28A83B1 VA: 0x28A82B0
	|-Array.EmptyInternalEnumerator<DamageTextInfo>.get_Current
	|
	|-RVA: 0x28A84D0 Offset: 0x28A85D1 VA: 0x28A84D0
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>.get_Current
	|
	|-RVA: 0x28A86F0 Offset: 0x28A87F1 VA: 0x28A86F0
	|-Array.EmptyInternalEnumerator<DropItemParam>.get_Current
	|
	|-RVA: 0x28A8900 Offset: 0x28A8A01 VA: 0x28A8900
	|-Array.EmptyInternalEnumerator<DropTableElement>.get_Current
	|
	|-RVA: 0x28A8B20 Offset: 0x28A8C21 VA: 0x28A8B20
	|-Array.EmptyInternalEnumerator<EffectDataTable>.get_Current
	|
	|-RVA: 0x28A8D40 Offset: 0x28A8E41 VA: 0x28A8D40
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>.get_Current
	|
	|-RVA: 0x28A8F50 Offset: 0x28A9051 VA: 0x28A8F50
	|-Array.EmptyInternalEnumerator<Coord>.get_Current
	|
	|-RVA: 0x28A9160 Offset: 0x28A9261 VA: 0x28A9160
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>.get_Current
	|
	|-RVA: 0x28A9380 Offset: 0x28A9481 VA: 0x28A9380
	|-Array.EmptyInternalEnumerator<EventCheckId>.get_Current
	|
	|-RVA: 0x28A95A0 Offset: 0x28A96A1 VA: 0x28A95A0
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>.get_Current
	|
	|-RVA: 0x28A97B0 Offset: 0x28A98B1 VA: 0x28A97B0
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>.get_Current
	|
	|-RVA: 0x28A99C0 Offset: 0x28A9AC1 VA: 0x28A99C0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>.get_Current
	|
	|-RVA: 0x28A9C00 Offset: 0x28A9D01 VA: 0x28A9C00
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>.get_Current
	|
	|-RVA: 0x28A9E30 Offset: 0x28A9F31 VA: 0x28A9E30
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.get_Current
	|
	|-RVA: 0x28AA050 Offset: 0x28AA151 VA: 0x28AA050
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>.get_Current
	|
	|-RVA: 0x28AA260 Offset: 0x28AA361 VA: 0x28AA260
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>.get_Current
	|
	|-RVA: 0x28AA470 Offset: 0x28AA571 VA: 0x28AA470
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>.get_Current
	|
	|-RVA: 0x28AA680 Offset: 0x28AA781 VA: 0x28AA680
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>.get_Current
	|
	|-RVA: 0x28AA890 Offset: 0x28AA991 VA: 0x28AA890
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>.get_Current
	|
	|-RVA: 0x28AAAC0 Offset: 0x28AABC1 VA: 0x28AAAC0
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.get_Current
	|
	|-RVA: 0x28AACE0 Offset: 0x28AADE1 VA: 0x28AACE0
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>.get_Current
	|
	|-RVA: 0x28AAF20 Offset: 0x28AB021 VA: 0x28AAF20
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>.get_Current
	|
	|-RVA: 0x28AB130 Offset: 0x28AB231 VA: 0x28AB130
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.get_Current
	|
	|-RVA: 0x28AB360 Offset: 0x28AB461 VA: 0x28AB360
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>.get_Current
	|
	|-RVA: 0x28AB580 Offset: 0x28AB681 VA: 0x28AB580
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>.get_Current
	|
	|-RVA: 0x28AB7A0 Offset: 0x28AB8A1 VA: 0x28AB7A0
	|-Array.EmptyInternalEnumerator<FurnitureData>.get_Current
	|
	|-RVA: 0x28AB9C0 Offset: 0x28ABAC1 VA: 0x28AB9C0
	|-Array.EmptyInternalEnumerator<GateDataTable>.get_Current
	|
	|-RVA: 0x28ABBD0 Offset: 0x28ABCD1 VA: 0x28ABBD0
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>.get_Current
	|
	|-RVA: 0x28ABE00 Offset: 0x28ABF01 VA: 0x28ABE00
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>.get_Current
	|
	|-RVA: 0x28AC010 Offset: 0x28AC111 VA: 0x28AC010
	|-Array.EmptyInternalEnumerator<HitResult>.get_Current
	|
	|-RVA: 0x28AC240 Offset: 0x28AC341 VA: 0x28AC240
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>.get_Current
	|
	|-RVA: 0x28AC460 Offset: 0x28AC561 VA: 0x28AC460
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>.get_Current
	|
	|-RVA: 0x28AC680 Offset: 0x28AC781 VA: 0x28AC680
	|-Array.EmptyInternalEnumerator<ItemLevelData>.get_Current
	|
	|-RVA: 0x28AC890 Offset: 0x28AC991 VA: 0x28AC890
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>.get_Current
	|
	|-RVA: 0x28ACAB0 Offset: 0x28ACBB1 VA: 0x28ACAB0
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>.get_Current
	|
	|-RVA: 0x28ACCE0 Offset: 0x28ACDE1 VA: 0x28ACCE0
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>.get_Current
	|
	|-RVA: 0x28ACEF0 Offset: 0x28ACFF1 VA: 0x28ACEF0
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>.get_Current
	|
	|-RVA: 0x28AD120 Offset: 0x28AD221 VA: 0x28AD120
	|-Array.EmptyInternalEnumerator<MiningDataTable>.get_Current
	|
	|-RVA: 0x28AD330 Offset: 0x28AD431 VA: 0x28AD330
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>.get_Current
	|
	|-RVA: 0x28AD560 Offset: 0x28AD661 VA: 0x28AD560
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.get_Current
	|
	|-RVA: 0x28AD780 Offset: 0x28AD881 VA: 0x28AD780
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>.get_Current
	|
	|-RVA: 0x28AD9A0 Offset: 0x28ADAA1 VA: 0x28AD9A0
	|-Array.EmptyInternalEnumerator<MonsterDataTable>.get_Current
	|
	|-RVA: 0x28ADBC0 Offset: 0x28ADCC1 VA: 0x28ADBC0
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>.get_Current
	|
	|-RVA: 0x28ADDE0 Offset: 0x28ADEE1 VA: 0x28ADDE0
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>.get_Current
	|
	|-RVA: 0x28AE010 Offset: 0x28AE111 VA: 0x28AE010
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>.get_Current
	|
	|-RVA: 0x28AE240 Offset: 0x28AE341 VA: 0x28AE240
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>.get_Current
	|
	|-RVA: 0x28AE470 Offset: 0x28AE571 VA: 0x28AE470
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>.get_Current
	|
	|-RVA: 0x28AE680 Offset: 0x28AE781 VA: 0x28AE680
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>.get_Current
	|
	|-RVA: 0x28AE890 Offset: 0x28AE991 VA: 0x28AE890
	|-Array.EmptyInternalEnumerator<NPCActionData>.get_Current
	|
	|-RVA: 0x28AEAC0 Offset: 0x28AEBC1 VA: 0x28AEAC0
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>.get_Current
	|
	|-RVA: 0x28AECD0 Offset: 0x28AEDD1 VA: 0x28AECD0
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>.get_Current
	|
	|-RVA: 0x28AEEE0 Offset: 0x28AEFE1 VA: 0x28AEEE0
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>.get_Current
	|
	|-RVA: 0x28AF100 Offset: 0x28AF201 VA: 0x28AF100
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>.get_Current
	|
	|-RVA: 0x28AF310 Offset: 0x28AF411 VA: 0x28AF310
	|-Array.EmptyInternalEnumerator<OrderSaveData>.get_Current
	|
	|-RVA: 0x28AF540 Offset: 0x28AF641 VA: 0x28AF540
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>.get_Current
	|
	|-RVA: 0x28AF760 Offset: 0x28AF861 VA: 0x28AF760
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Current
	|
	|-RVA: 0x28AF970 Offset: 0x28AFA71 VA: 0x28AF970
	|-Array.EmptyInternalEnumerator<Parameter>.get_Current
	|
	|-RVA: 0x28AFB90 Offset: 0x28AFC91 VA: 0x28AFB90
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.get_Current
	|
	|-RVA: 0x28AFDA0 Offset: 0x28AFEA1 VA: 0x28AFDA0
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>.get_Current
	|
	|-RVA: 0x28AFFD0 Offset: 0x28B00D1 VA: 0x28AFFD0
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>.get_Current
	|
	|-RVA: 0x28B01E0 Offset: 0x28B02E1 VA: 0x28B01E0
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>.get_Current
	|
	|-RVA: 0x28B0410 Offset: 0x28B0511 VA: 0x28B0410
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>.get_Current
	|
	|-RVA: 0x28B0620 Offset: 0x28B0721 VA: 0x28B0620
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>.get_Current
	|
	|-RVA: 0x28B0830 Offset: 0x28B0931 VA: 0x28B0830
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>.get_Current
	|
	|-RVA: 0x28B0A40 Offset: 0x28B0B41 VA: 0x28B0A40
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>.get_Current
	|
	|-RVA: 0x28B0C70 Offset: 0x28B0D71 VA: 0x28B0C70
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.get_Current
	|
	|-RVA: 0x28B0EA0 Offset: 0x28B0FA1 VA: 0x28B0EA0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.get_Current
	|
	|-RVA: 0x28B10D0 Offset: 0x28B11D1 VA: 0x28B10D0
	|-Array.EmptyInternalEnumerator<ProfilerFrame>.get_Current
	|
	|-RVA: 0x28B12E0 Offset: 0x28B13E1 VA: 0x28B12E0
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>.get_Current
	|
	|-RVA: 0x28B14F0 Offset: 0x28B15F1 VA: 0x28B14F0
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>.get_Current
	|
	|-RVA: 0x28B1710 Offset: 0x28B1811 VA: 0x28B1710
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>.get_Current
	|
	|-RVA: 0x28B1930 Offset: 0x28B1A31 VA: 0x28B1930
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>.get_Current
	|
	|-RVA: 0x28B1B40 Offset: 0x28B1C41 VA: 0x28B1B40
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>.get_Current
	|
	|-RVA: 0x28B1D50 Offset: 0x28B1E51 VA: 0x28B1D50
	|-Array.EmptyInternalEnumerator<Schedule>.get_Current
	|
	|-RVA: 0x28B1F70 Offset: 0x28B2071 VA: 0x28B1F70
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.get_Current
	|
	|-RVA: 0x28B2180 Offset: 0x28B2281 VA: 0x28B2180
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.get_Current
	|
	|-RVA: 0x28B2390 Offset: 0x28B2491 VA: 0x28B2390
	|-Array.EmptyInternalEnumerator<SpeedData>.get_Current
	|
	|-RVA: 0x26F2570 Offset: 0x26F2671 VA: 0x26F2570
	|-Array.EmptyInternalEnumerator<CurveSample>.get_Current
	|
	|-RVA: 0x26F27B0 Offset: 0x26F28B1 VA: 0x26F27B0
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>.get_Current
	|
	|-RVA: 0x26F29C0 Offset: 0x26F2AC1 VA: 0x26F29C0
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>.get_Current
	|
	|-RVA: 0x26F2BD0 Offset: 0x26F2CD1 VA: 0x26F2BD0
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>.get_Current
	|
	|-RVA: 0x26F2DE0 Offset: 0x26F2EE1 VA: 0x26F2DE0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.get_Current
	|
	|-RVA: 0x26F2FF0 Offset: 0x26F30F1 VA: 0x26F2FF0
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>.get_Current
	|
	|-RVA: 0x26F3200 Offset: 0x26F3301 VA: 0x26F3200
	|-Array.EmptyInternalEnumerator<bool>.get_Current
	|
	|-RVA: 0x26F3410 Offset: 0x26F3511 VA: 0x26F3410
	|-Array.EmptyInternalEnumerator<byte>.get_Current
	|
	|-RVA: 0x26F3620 Offset: 0x26F3721 VA: 0x26F3620
	|-Array.EmptyInternalEnumerator<ByteEnum>.get_Current
	|
	|-RVA: 0x26F3830 Offset: 0x26F3931 VA: 0x26F3830
	|-Array.EmptyInternalEnumerator<char>.get_Current
	|
	|-RVA: 0x26F3A40 Offset: 0x26F3B41 VA: 0x26F3A40
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.get_Current
	|
	|-RVA: 0x26F3C50 Offset: 0x26F3D51 VA: 0x26F3C50
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.get_Current
	|
	|-RVA: 0x26F3E60 Offset: 0x26F3F61 VA: 0x26F3E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.get_Current
	|
	|-RVA: 0x26F4080 Offset: 0x26F4181 VA: 0x26F4080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.get_Current
	|
	|-RVA: 0x26F42A0 Offset: 0x26F43A1 VA: 0x26F42A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>.get_Current
	|
	|-RVA: 0x26F44D0 Offset: 0x26F45D1 VA: 0x26F44D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.get_Current
	|
	|-RVA: 0x26F4710 Offset: 0x26F4811 VA: 0x26F4710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.get_Current
	|
	|-RVA: 0x26F4940 Offset: 0x26F4A41 VA: 0x26F4940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.get_Current
	|
	|-RVA: 0x26F4B60 Offset: 0x26F4C61 VA: 0x26F4B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.get_Current
	|
	|-RVA: 0x26F4D80 Offset: 0x26F4E81 VA: 0x26F4D80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.get_Current
	|
	|-RVA: 0x26F4FB0 Offset: 0x26F50B1 VA: 0x26F4FB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.get_Current
	|
	|-RVA: 0x26F51D0 Offset: 0x26F52D1 VA: 0x26F51D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.get_Current
	|
	|-RVA: 0x26F5400 Offset: 0x26F5501 VA: 0x26F5400
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.get_Current
	|
	|-RVA: 0x26F5630 Offset: 0x26F5731 VA: 0x26F5630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>.get_Current
	|
	|-RVA: 0x26F5850 Offset: 0x26F5951 VA: 0x26F5850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>.get_Current
	|
	|-RVA: 0x26F5A70 Offset: 0x26F5B71 VA: 0x26F5A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.get_Current
	|
	|-RVA: 0x26F5C90 Offset: 0x26F5D91 VA: 0x26F5C90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.get_Current
	|
	|-RVA: 0x26F5EB0 Offset: 0x26F5FB1 VA: 0x26F5EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>.get_Current
	|
	|-RVA: 0x26F60D0 Offset: 0x26F61D1 VA: 0x26F60D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>.get_Current
	|
	|-RVA: 0x26F62F0 Offset: 0x26F63F1 VA: 0x26F62F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.get_Current
	|
	|-RVA: 0x26F6510 Offset: 0x26F6611 VA: 0x26F6510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>.get_Current
	|
	|-RVA: 0x26F6730 Offset: 0x26F6831 VA: 0x26F6730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>.get_Current
	|
	|-RVA: 0x26F6950 Offset: 0x26F6A51 VA: 0x26F6950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.get_Current
	|
	|-RVA: 0x26F6B70 Offset: 0x26F6C71 VA: 0x26F6B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.get_Current
	|
	|-RVA: 0x26F6D80 Offset: 0x26F6E81 VA: 0x26F6D80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.get_Current
	|
	|-RVA: 0x26F6FC0 Offset: 0x26F70C1 VA: 0x26F6FC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.get_Current
	|
	|-RVA: 0x26F71E0 Offset: 0x26F72E1 VA: 0x26F71E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.get_Current
	|
	|-RVA: 0x26F73F0 Offset: 0x26F74F1 VA: 0x26F73F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.get_Current
	|
	|-RVA: 0x26F7600 Offset: 0x26F7701 VA: 0x26F7600
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.get_Current
	|
	|-RVA: 0x26F7810 Offset: 0x26F7911 VA: 0x26F7810
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.get_Current
	|
	|-RVA: 0x26F7A20 Offset: 0x26F7B21 VA: 0x26F7A20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.get_Current
	|
	|-RVA: 0x26F7C40 Offset: 0x26F7D41 VA: 0x26F7C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.get_Current
	|
	|-RVA: 0x26F7E60 Offset: 0x26F7F61 VA: 0x26F7E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.get_Current
	|
	|-RVA: 0x26F8090 Offset: 0x26F8191 VA: 0x26F8090
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>.get_Current
	|
	|-RVA: 0x26F82B0 Offset: 0x26F83B1 VA: 0x26F82B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>.get_Current
	|
	|-RVA: 0x26F84D0 Offset: 0x26F85D1 VA: 0x26F84D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>.get_Current
	|
	|-RVA: 0x26F86F0 Offset: 0x26F87F1 VA: 0x26F86F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.get_Current
	|
	|-RVA: 0x26F8910 Offset: 0x26F8A11 VA: 0x26F8910
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.get_Current
	|
	|-RVA: 0x26F8B40 Offset: 0x26F8C41 VA: 0x26F8B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.get_Current
	|
	|-RVA: 0x26F8D70 Offset: 0x26F8E71 VA: 0x26F8D70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.get_Current
	|
	|-RVA: 0x26F8F80 Offset: 0x26F9081 VA: 0x26F8F80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.get_Current
	|
	|-RVA: 0x26F91A0 Offset: 0x26F92A1 VA: 0x26F91A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x26F93B0 Offset: 0x26F94B1 VA: 0x26F93B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x26F95C0 Offset: 0x26F96C1 VA: 0x26F95C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x26F97E0 Offset: 0x26F98E1 VA: 0x26F97E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>.get_Current
	|
	|-RVA: 0x26F99F0 Offset: 0x26F9AF1 VA: 0x26F99F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.get_Current
	|
	|-RVA: 0x26F9C10 Offset: 0x26F9D11 VA: 0x26F9C10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.get_Current
	|
	|-RVA: 0x26F9E30 Offset: 0x26F9F31 VA: 0x26F9E30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.get_Current
	|
	|-RVA: 0x26FA050 Offset: 0x26FA151 VA: 0x26FA050
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.get_Current
	|
	|-RVA: 0x26FA270 Offset: 0x26FA371 VA: 0x26FA270
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>.get_Current
	|
	|-RVA: 0x26FA490 Offset: 0x26FA591 VA: 0x26FA490
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.get_Current
	|
	|-RVA: 0x26FA6B0 Offset: 0x26FA7B1 VA: 0x26FA6B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.get_Current
	|
	|-RVA: 0x26FA8E0 Offset: 0x26FA9E1 VA: 0x26FA8E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.get_Current
	|
	|-RVA: 0x26FAB10 Offset: 0x26FAC11 VA: 0x26FAB10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.get_Current
	|
	|-RVA: 0x26FAD30 Offset: 0x26FAE31 VA: 0x26FAD30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.get_Current
	|
	|-RVA: 0x26FAF60 Offset: 0x26FB061 VA: 0x26FAF60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.get_Current
	|
	|-RVA: 0x26FB180 Offset: 0x26FB281 VA: 0x26FB180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.get_Current
	|
	|-RVA: 0x26FB3B0 Offset: 0x26FB4B1 VA: 0x26FB3B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.get_Current
	|
	|-RVA: 0x26FB5E0 Offset: 0x26FB6E1 VA: 0x26FB5E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.get_Current
	|
	|-RVA: 0x26FB800 Offset: 0x26FB901 VA: 0x26FB800
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.get_Current
	|
	|-RVA: 0x26FBA40 Offset: 0x26FBB41 VA: 0x26FBA40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.get_Current
	|
	|-RVA: 0x26FBC70 Offset: 0x26FBD71 VA: 0x26FBC70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.get_Current
	|
	|-RVA: 0x26FBE90 Offset: 0x26FBF91 VA: 0x26FBE90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.get_Current
	|
	|-RVA: 0x26FC0C0 Offset: 0x26FC1C1 VA: 0x26FC0C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.get_Current
	|
	|-RVA: 0x26FC2F0 Offset: 0x26FC3F1 VA: 0x26FC2F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.get_Current
	|
	|-RVA: 0x26FC510 Offset: 0x26FC611 VA: 0x26FC510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.get_Current
	|
	|-RVA: 0x26FC730 Offset: 0x26FC831 VA: 0x26FC730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.get_Current
	|
	|-RVA: 0x26FC950 Offset: 0x26FCA51 VA: 0x26FC950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.get_Current
	|
	|-RVA: 0x26FCB70 Offset: 0x26FCC71 VA: 0x26FCB70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.get_Current
	|
	|-RVA: 0x26FCDA0 Offset: 0x26FCEA1 VA: 0x26FCDA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.get_Current
	|
	|-RVA: 0x26FCFC0 Offset: 0x26FD0C1 VA: 0x26FCFC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>.get_Current
	|
	|-RVA: 0x26FD1F0 Offset: 0x26FD2F1 VA: 0x26FD1F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.get_Current
	|
	|-RVA: 0x26FD430 Offset: 0x26FD531 VA: 0x26FD430
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.get_Current
	|
	|-RVA: 0x26FD660 Offset: 0x26FD761 VA: 0x26FD660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.get_Current
	|
	|-RVA: 0x26FD880 Offset: 0x26FD981 VA: 0x26FD880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.get_Current
	|
	|-RVA: 0x26FDAA0 Offset: 0x26FDBA1 VA: 0x26FDAA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.get_Current
	|
	|-RVA: 0x26FDCD0 Offset: 0x26FDDD1 VA: 0x26FDCD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.get_Current
	|
	|-RVA: 0x26FDEF0 Offset: 0x26FDFF1 VA: 0x26FDEF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.get_Current
	|
	|-RVA: 0x26FE120 Offset: 0x26FE221 VA: 0x26FE120
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.get_Current
	|
	|-RVA: 0x26FE350 Offset: 0x26FE451 VA: 0x26FE350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>.get_Current
	|
	|-RVA: 0x26FE570 Offset: 0x26FE671 VA: 0x26FE570
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.get_Current
	|
	|-RVA: 0x26FE790 Offset: 0x26FE891 VA: 0x26FE790
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.get_Current
	|
	|-RVA: 0x26FE9B0 Offset: 0x26FEAB1 VA: 0x26FE9B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.get_Current
	|
	|-RVA: 0x26FEBD0 Offset: 0x26FECD1 VA: 0x26FEBD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>.get_Current
	|
	|-RVA: 0x26FEDF0 Offset: 0x26FEEF1 VA: 0x26FEDF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>.get_Current
	|
	|-RVA: 0x26FF010 Offset: 0x26FF111 VA: 0x26FF010
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>.get_Current
	|
	|-RVA: 0x26FF230 Offset: 0x26FF331 VA: 0x26FF230
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>.get_Current
	|
	|-RVA: 0x26FF450 Offset: 0x26FF551 VA: 0x26FF450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.get_Current
	|
	|-RVA: 0x26FF670 Offset: 0x26FF771 VA: 0x26FF670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x26FF890 Offset: 0x26FF991 VA: 0x26FF890
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>.get_Current
	|
	|-RVA: 0x26FFAB0 Offset: 0x26FFBB1 VA: 0x26FFAB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>.get_Current
	|
	|-RVA: 0x26FFCD0 Offset: 0x26FFDD1 VA: 0x26FFCD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.get_Current
	|
	|-RVA: 0x26FFEF0 Offset: 0x26FFFF1 VA: 0x26FFEF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.get_Current
	|
	|-RVA: 0x2700120 Offset: 0x2700221 VA: 0x2700120
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.get_Current
	|
	|-RVA: 0x2700350 Offset: 0x2700451 VA: 0x2700350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.get_Current
	|
	|-RVA: 0x2700570 Offset: 0x2700671 VA: 0x2700570
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.get_Current
	|
	|-RVA: 0x27007A0 Offset: 0x27008A1 VA: 0x27007A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.get_Current
	|
	|-RVA: 0x27009C0 Offset: 0x2700AC1 VA: 0x27009C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.get_Current
	|
	|-RVA: 0x2700BF0 Offset: 0x2700CF1 VA: 0x2700BF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.get_Current
	|
	|-RVA: 0x2700E20 Offset: 0x2700F21 VA: 0x2700E20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.get_Current
	|
	|-RVA: 0x2701040 Offset: 0x2701141 VA: 0x2701040
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.get_Current
	|
	|-RVA: 0x2701280 Offset: 0x2701381 VA: 0x2701280
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.get_Current
	|
	|-RVA: 0x27014B0 Offset: 0x27015B1 VA: 0x27014B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.get_Current
	|
	|-RVA: 0x27016D0 Offset: 0x27017D1 VA: 0x27016D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.get_Current
	|
	|-RVA: 0x2701900 Offset: 0x2701A01 VA: 0x2701900
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.get_Current
	|
	|-RVA: 0x2701B30 Offset: 0x2701C31 VA: 0x2701B30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.get_Current
	|
	|-RVA: 0x2701D50 Offset: 0x2701E51 VA: 0x2701D50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.get_Current
	|
	|-RVA: 0x2701F70 Offset: 0x2702071 VA: 0x2701F70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.get_Current
	|
	|-RVA: 0x2702190 Offset: 0x2702291 VA: 0x2702190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.get_Current
	|
	|-RVA: 0x27023B0 Offset: 0x27024B1 VA: 0x27023B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.get_Current
	|
	|-RVA: 0x27025E0 Offset: 0x27026E1 VA: 0x27025E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.get_Current
	|
	|-RVA: 0x2702800 Offset: 0x2702901 VA: 0x2702800
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.get_Current
	|
	|-RVA: 0x2702A20 Offset: 0x2702B21 VA: 0x2702A20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.get_Current
	|
	|-RVA: 0x2702C40 Offset: 0x2702D41 VA: 0x2702C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>.get_Current
	|
	|-RVA: 0x2702E60 Offset: 0x2702F61 VA: 0x2702E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.get_Current
	|
	|-RVA: 0x2703080 Offset: 0x2703181 VA: 0x2703080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.get_Current
	|
	|-RVA: 0x27032A0 Offset: 0x27033A1 VA: 0x27032A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>.get_Current
	|
	|-RVA: 0x27034C0 Offset: 0x27035C1 VA: 0x27034C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>.get_Current
	|
	|-RVA: 0x27036E0 Offset: 0x27037E1 VA: 0x27036E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>.get_Current
	|
	|-RVA: 0x2703910 Offset: 0x2703A11 VA: 0x2703910
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>.get_Current
	|
	|-RVA: 0x2703B40 Offset: 0x2703C41 VA: 0x2703B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>.get_Current
	|
	|-RVA: 0x2703D70 Offset: 0x2703E71 VA: 0x2703D70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>.get_Current
	|
	|-RVA: 0x2703F90 Offset: 0x2704091 VA: 0x2703F90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>.get_Current
	|
	|-RVA: 0x27041B0 Offset: 0x27042B1 VA: 0x27041B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x27043D0 Offset: 0x27044D1 VA: 0x27043D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.get_Current
	|
	|-RVA: 0x2704600 Offset: 0x2704701 VA: 0x2704600
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>.get_Current
	|
	|-RVA: 0x2704830 Offset: 0x2704931 VA: 0x2704830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>.get_Current
	|
	|-RVA: 0x2704A50 Offset: 0x2704B51 VA: 0x2704A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.get_Current
	|
	|-RVA: 0x2704C90 Offset: 0x2704D91 VA: 0x2704C90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.get_Current
	|
	|-RVA: 0x2704EB0 Offset: 0x2704FB1 VA: 0x2704EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>.get_Current
	|
	|-RVA: 0x27050D0 Offset: 0x27051D1 VA: 0x27050D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>.get_Current
	|
	|-RVA: 0x27052F0 Offset: 0x27053F1 VA: 0x27052F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>.get_Current
	|
	|-RVA: 0x2705510 Offset: 0x2705611 VA: 0x2705510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>.get_Current
	|
	|-RVA: 0x2705730 Offset: 0x2705831 VA: 0x2705730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x2705960 Offset: 0x2705A61 VA: 0x2705960
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.get_Current
	|
	|-RVA: 0x2705B90 Offset: 0x2705C91 VA: 0x2705B90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>.get_Current
	|
	|-RVA: 0x2705DB0 Offset: 0x2705EB1 VA: 0x2705DB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>.get_Current
	|
	|-RVA: 0x2705FD0 Offset: 0x27060D1 VA: 0x2705FD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>.get_Current
	|
	|-RVA: 0x27061F0 Offset: 0x27062F1 VA: 0x27061F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>.get_Current
	|
	|-RVA: 0x2706410 Offset: 0x2706511 VA: 0x2706410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>.get_Current
	|
	|-RVA: 0x2706630 Offset: 0x2706731 VA: 0x2706630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.get_Current
	|
	|-RVA: 0x2706850 Offset: 0x2706951 VA: 0x2706850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.get_Current
	|
	|-RVA: 0x2706A70 Offset: 0x2706B71 VA: 0x2706A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.get_Current
	|
	|-RVA: 0x2706C90 Offset: 0x2706D91 VA: 0x2706C90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>.get_Current
	|
	|-RVA: 0x2706ED0 Offset: 0x2706FD1 VA: 0x2706ED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>.get_Current
	|
	|-RVA: 0x27070F0 Offset: 0x27071F1 VA: 0x27070F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>.get_Current
	|
	|-RVA: 0x2707310 Offset: 0x2707411 VA: 0x2707310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.get_Current
	|
	|-RVA: 0x2707520 Offset: 0x2707621 VA: 0x2707520
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.get_Current
	|
	|-RVA: 0x2707730 Offset: 0x2707831 VA: 0x2707730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.get_Current
	|
	|-RVA: 0x2707950 Offset: 0x2707A51 VA: 0x2707950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.get_Current
	|
	|-RVA: 0x2707B70 Offset: 0x2707C71 VA: 0x2707B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.get_Current
	|
	|-RVA: 0x2707D90 Offset: 0x2707E91 VA: 0x2707D90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.get_Current
	|
	|-RVA: 0x2707FC0 Offset: 0x27080C1 VA: 0x2707FC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.get_Current
	|
	|-RVA: 0x27081F0 Offset: 0x27082F1 VA: 0x27081F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.get_Current
	|
	|-RVA: 0x2708420 Offset: 0x2708521 VA: 0x2708420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.get_Current
	|
	|-RVA: 0x2708640 Offset: 0x2708741 VA: 0x2708640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.get_Current
	|
	|-RVA: 0x2708860 Offset: 0x2708961 VA: 0x2708860
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>.get_Current
	|
	|-RVA: 0x2708A90 Offset: 0x2708B91 VA: 0x2708A90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>.get_Current
	|
	|-RVA: 0x2708CC0 Offset: 0x2708DC1 VA: 0x2708CC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>.get_Current
	|
	|-RVA: 0x2708EE0 Offset: 0x2708FE1 VA: 0x2708EE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>.get_Current
	|
	|-RVA: 0x2709100 Offset: 0x2709201 VA: 0x2709100
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.get_Current
	|
	|-RVA: 0x2709320 Offset: 0x2709421 VA: 0x2709320
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.get_Current
	|
	|-RVA: 0x2709540 Offset: 0x2709641 VA: 0x2709540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.get_Current
	|
	|-RVA: 0x2709770 Offset: 0x2709871 VA: 0x2709770
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>.get_Current
	|
	|-RVA: 0x27099A0 Offset: 0x2709AA1 VA: 0x27099A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>.get_Current
	|
	|-RVA: 0x2709BC0 Offset: 0x2709CC1 VA: 0x2709BC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.get_Current
	|
	|-RVA: 0x2709E00 Offset: 0x2709F01 VA: 0x2709E00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>.get_Current
	|
	|-RVA: 0x270A020 Offset: 0x270A121 VA: 0x270A020
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>.get_Current
	|
	|-RVA: 0x270A240 Offset: 0x270A341 VA: 0x270A240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>.get_Current
	|
	|-RVA: 0x270A460 Offset: 0x270A561 VA: 0x270A460
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>.get_Current
	|
	|-RVA: 0x270A680 Offset: 0x270A781 VA: 0x270A680
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>.get_Current
	|
	|-RVA: 0x270A8A0 Offset: 0x270A9A1 VA: 0x270A8A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.get_Current
	|
	|-RVA: 0x270AAC0 Offset: 0x270ABC1 VA: 0x270AAC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.get_Current
	|
	|-RVA: 0x270ACE0 Offset: 0x270ADE1 VA: 0x270ACE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>.get_Current
	|
	|-RVA: 0x270AF00 Offset: 0x270B001 VA: 0x270AF00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>.get_Current
	|
	|-RVA: 0x270B120 Offset: 0x270B221 VA: 0x270B120
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>.get_Current
	|
	|-RVA: 0x270B340 Offset: 0x270B441 VA: 0x270B340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>.get_Current
	|
	|-RVA: 0x270B560 Offset: 0x270B661 VA: 0x270B560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>.get_Current
	|
	|-RVA: 0x270B780 Offset: 0x270B881 VA: 0x270B780
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.get_Current
	|
	|-RVA: 0x28C6760 Offset: 0x28C6861 VA: 0x28C6760
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.get_Current
	|
	|-RVA: 0x28C6970 Offset: 0x28C6A71 VA: 0x28C6970
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.get_Current
	|
	|-RVA: 0x28C6B80 Offset: 0x28C6C81 VA: 0x28C6B80
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.get_Current
	|
	|-RVA: 0x28C6D90 Offset: 0x28C6E91 VA: 0x28C6D90
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>.get_Current
	|
	|-RVA: 0x28C6FA0 Offset: 0x28C70A1 VA: 0x28C6FA0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x28C71C0 Offset: 0x28C72C1 VA: 0x28C71C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.get_Current
	|
	|-RVA: 0x28C73E0 Offset: 0x28C74E1 VA: 0x28C73E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>.get_Current
	|
	|-RVA: 0x28C75F0 Offset: 0x28C76F1 VA: 0x28C75F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>.get_Current
	|
	|-RVA: 0x28C7810 Offset: 0x28C7911 VA: 0x28C7810
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.get_Current
	|
	|-RVA: 0x28C7A40 Offset: 0x28C7B41 VA: 0x28C7A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.get_Current
	|
	|-RVA: 0x28C7C60 Offset: 0x28C7D61 VA: 0x28C7C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.get_Current
	|
	|-RVA: 0x28C7E80 Offset: 0x28C7F81 VA: 0x28C7E80
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.get_Current
	|
	|-RVA: 0x28C80A0 Offset: 0x28C81A1 VA: 0x28C80A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.get_Current
	|
	|-RVA: 0x28C82D0 Offset: 0x28C83D1 VA: 0x28C82D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.get_Current
	|
	|-RVA: 0x28C84F0 Offset: 0x28C85F1 VA: 0x28C84F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>.get_Current
	|
	|-RVA: 0x28C8720 Offset: 0x28C8821 VA: 0x28C8720
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.get_Current
	|
	|-RVA: 0x28C8950 Offset: 0x28C8A51 VA: 0x28C8950
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>.get_Current
	|
	|-RVA: 0x28C8B70 Offset: 0x28C8C71 VA: 0x28C8B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>.get_Current
	|
	|-RVA: 0x28C8D80 Offset: 0x28C8E81 VA: 0x28C8D80
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.get_Current
	|
	|-RVA: 0x28C8F90 Offset: 0x28C9091 VA: 0x28C8F90
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.get_Current
	|
	|-RVA: 0x28C91A0 Offset: 0x28C92A1 VA: 0x28C91A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.get_Current
	|
	|-RVA: 0x28C93B0 Offset: 0x28C94B1 VA: 0x28C93B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>.get_Current
	|
	|-RVA: 0x28C95C0 Offset: 0x28C96C1 VA: 0x28C95C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.get_Current
	|
	|-RVA: 0x28C97E0 Offset: 0x28C98E1 VA: 0x28C97E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>.get_Current
	|
	|-RVA: 0x28C99F0 Offset: 0x28C9AF1 VA: 0x28C99F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>.get_Current
	|
	|-RVA: 0x28C9C10 Offset: 0x28C9D11 VA: 0x28C9C10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>.get_Current
	|
	|-RVA: 0x28C9E30 Offset: 0x28C9F31 VA: 0x28C9E30
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.get_Current
	|
	|-RVA: 0x28CA040 Offset: 0x28CA141 VA: 0x28CA040
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.get_Current
	|
	|-RVA: 0x28CA280 Offset: 0x28CA381 VA: 0x28CA280
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>.get_Current
	|
	|-RVA: 0x28CA4A0 Offset: 0x28CA5A1 VA: 0x28CA4A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.get_Current
	|
	|-RVA: 0x28CA6B0 Offset: 0x28CA7B1 VA: 0x28CA6B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.get_Current
	|
	|-RVA: 0x28CA8C0 Offset: 0x28CA9C1 VA: 0x28CA8C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x28CAAD0 Offset: 0x28CABD1 VA: 0x28CAAD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.get_Current
	|
	|-RVA: 0x28CACE0 Offset: 0x28CADE1 VA: 0x28CACE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.get_Current
	|
	|-RVA: 0x28CAEF0 Offset: 0x28CAFF1 VA: 0x28CAEF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x28CB100 Offset: 0x28CB201 VA: 0x28CB100
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.get_Current
	|
	|-RVA: 0x28CB330 Offset: 0x28CB431 VA: 0x28CB330
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>.get_Current
	|
	|-RVA: 0x28CB550 Offset: 0x28CB651 VA: 0x28CB550
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>.get_Current
	|
	|-RVA: 0x28CB760 Offset: 0x28CB861 VA: 0x28CB760
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>.get_Current
	|
	|-RVA: 0x28CB970 Offset: 0x28CBA71 VA: 0x28CB970
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.get_Current
	|
	|-RVA: 0x28CBB90 Offset: 0x28CBC91 VA: 0x28CBB90
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.get_Current
	|
	|-RVA: 0x28CBDC0 Offset: 0x28CBEC1 VA: 0x28CBDC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.get_Current
	|
	|-RVA: 0x28CBFE0 Offset: 0x28CC0E1 VA: 0x28CBFE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.get_Current
	|
	|-RVA: 0x28CC1F0 Offset: 0x28CC2F1 VA: 0x28CC1F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.get_Current
	|
	|-RVA: 0x28CC400 Offset: 0x28CC501 VA: 0x28CC400
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x28CC610 Offset: 0x28CC711 VA: 0x28CC610
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x28CC820 Offset: 0x28CC921 VA: 0x28CC820
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x28CCA30 Offset: 0x28CCB31 VA: 0x28CCA30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>.get_Current
	|
	|-RVA: 0x28CCC40 Offset: 0x28CCD41 VA: 0x28CCC40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.get_Current
	|
	|-RVA: 0x28CCE60 Offset: 0x28CCF61 VA: 0x28CCE60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.get_Current
	|
	|-RVA: 0x28CD070 Offset: 0x28CD171 VA: 0x28CD070
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.get_Current
	|
	|-RVA: 0x28CD280 Offset: 0x28CD381 VA: 0x28CD280
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.get_Current
	|
	|-RVA: 0x28CD490 Offset: 0x28CD591 VA: 0x28CD490
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>.get_Current
	|
	|-RVA: 0x28CD6B0 Offset: 0x28CD7B1 VA: 0x28CD6B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.get_Current
	|
	|-RVA: 0x28CD8C0 Offset: 0x28CD9C1 VA: 0x28CD8C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.get_Current
	|
	|-RVA: 0x28CDAF0 Offset: 0x28CDBF1 VA: 0x28CDAF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.get_Current
	|
	|-RVA: 0x28CDD20 Offset: 0x28CDE21 VA: 0x28CDD20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.get_Current
	|
	|-RVA: 0x28CDF30 Offset: 0x28CE031 VA: 0x28CDF30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>.get_Current
	|
	|-RVA: 0x28CE150 Offset: 0x28CE251 VA: 0x28CE150
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.get_Current
	|
	|-RVA: 0x28CE370 Offset: 0x28CE471 VA: 0x28CE370
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.get_Current
	|
	|-RVA: 0x28CE590 Offset: 0x28CE691 VA: 0x28CE590
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.get_Current
	|
	|-RVA: 0x28CE7C0 Offset: 0x28CE8C1 VA: 0x28CE7C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.get_Current
	|
	|-RVA: 0x28CE9D0 Offset: 0x28CEAD1 VA: 0x28CE9D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.get_Current
	|
	|-RVA: 0x28CEC10 Offset: 0x28CED11 VA: 0x28CEC10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.get_Current
	|
	|-RVA: 0x28CEE30 Offset: 0x28CEF31 VA: 0x28CEE30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.get_Current
	|
	|-RVA: 0x28CF050 Offset: 0x28CF151 VA: 0x28CF050
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.get_Current
	|
	|-RVA: 0x28CF270 Offset: 0x28CF371 VA: 0x28CF270
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.get_Current
	|
	|-RVA: 0x28CF490 Offset: 0x28CF591 VA: 0x28CF490
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.get_Current
	|
	|-RVA: 0x28CF6B0 Offset: 0x28CF7B1 VA: 0x28CF6B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.get_Current
	|
	|-RVA: 0x28CF8D0 Offset: 0x28CF9D1 VA: 0x28CF8D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.get_Current
	|
	|-RVA: 0x28CFAF0 Offset: 0x28CFBF1 VA: 0x28CFAF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.get_Current
	|
	|-RVA: 0x28CFD10 Offset: 0x28CFE11 VA: 0x28CFD10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.get_Current
	|
	|-RVA: 0x28CFF30 Offset: 0x28D0031 VA: 0x28CFF30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>.get_Current
	|
	|-RVA: 0x28D0140 Offset: 0x28D0241 VA: 0x28D0140
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>.get_Current
	|
	|-RVA: 0x28D0360 Offset: 0x28D0461 VA: 0x28D0360
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.get_Current
	|
	|-RVA: 0x28D0590 Offset: 0x28D0691 VA: 0x28D0590
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.get_Current
	|
	|-RVA: 0x28D07B0 Offset: 0x28D08B1 VA: 0x28D07B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.get_Current
	|
	|-RVA: 0x28D09D0 Offset: 0x28D0AD1 VA: 0x28D09D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.get_Current
	|
	|-RVA: 0x28D0BF0 Offset: 0x28D0CF1 VA: 0x28D0BF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.get_Current
	|
	|-RVA: 0x28D0E20 Offset: 0x28D0F21 VA: 0x28D0E20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.get_Current
	|
	|-RVA: 0x28D1040 Offset: 0x28D1141 VA: 0x28D1040
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>.get_Current
	|
	|-RVA: 0x28D1270 Offset: 0x28D1371 VA: 0x28D1270
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.get_Current
	|
	|-RVA: 0x28D14A0 Offset: 0x28D15A1 VA: 0x28D14A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>.get_Current
	|
	|-RVA: 0x28D16C0 Offset: 0x28D17C1 VA: 0x28D16C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.get_Current
	|
	|-RVA: 0x28D18E0 Offset: 0x28D19E1 VA: 0x28D18E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.get_Current
	|
	|-RVA: 0x28D1AF0 Offset: 0x28D1BF1 VA: 0x28D1AF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.get_Current
	|
	|-RVA: 0x28D1D00 Offset: 0x28D1E01 VA: 0x28D1D00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>.get_Current
	|
	|-RVA: 0x28D1F10 Offset: 0x28D2011 VA: 0x28D1F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>.get_Current
	|
	|-RVA: 0x28D2120 Offset: 0x28D2221 VA: 0x28D2120
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>.get_Current
	|
	|-RVA: 0x28D2330 Offset: 0x28D2431 VA: 0x28D2330
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>.get_Current
	|
	|-RVA: 0x28D2540 Offset: 0x28D2641 VA: 0x28D2540
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.get_Current
	|
	|-RVA: 0x28D2750 Offset: 0x28D2851 VA: 0x28D2750
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x28D2960 Offset: 0x28D2A61 VA: 0x28D2960
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>.get_Current
	|
	|-RVA: 0x28D2B70 Offset: 0x28D2C71 VA: 0x28D2B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>.get_Current
	|
	|-RVA: 0x28D2D90 Offset: 0x28D2E91 VA: 0x28D2D90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.get_Current
	|
	|-RVA: 0x28D2FA0 Offset: 0x28D30A1 VA: 0x28D2FA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.get_Current
	|
	|-RVA: 0x28D31D0 Offset: 0x28D32D1 VA: 0x28D31D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.get_Current
	|
	|-RVA: 0x28D3400 Offset: 0x28D3501 VA: 0x28D3400
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.get_Current
	|
	|-RVA: 0x28D3610 Offset: 0x28D3711 VA: 0x28D3610
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>.get_Current
	|
	|-RVA: 0x28D3830 Offset: 0x28D3931 VA: 0x28D3830
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.get_Current
	|
	|-RVA: 0x28D3A50 Offset: 0x28D3B51 VA: 0x28D3A50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.get_Current
	|
	|-RVA: 0x28D3C70 Offset: 0x28D3D71 VA: 0x28D3C70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.get_Current
	|
	|-RVA: 0x28D3EA0 Offset: 0x28D3FA1 VA: 0x28D3EA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.get_Current
	|
	|-RVA: 0x28D40B0 Offset: 0x28D41B1 VA: 0x28D40B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.get_Current
	|
	|-RVA: 0x28D42F0 Offset: 0x28D43F1 VA: 0x28D42F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.get_Current
	|
	|-RVA: 0x28D4510 Offset: 0x28D4611 VA: 0x28D4510
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.get_Current
	|
	|-RVA: 0x28D4730 Offset: 0x28D4831 VA: 0x28D4730
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.get_Current
	|
	|-RVA: 0x28D4950 Offset: 0x28D4A51 VA: 0x28D4950
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.get_Current
	|
	|-RVA: 0x28D4B70 Offset: 0x28D4C71 VA: 0x28D4B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.get_Current
	|
	|-RVA: 0x28D4D90 Offset: 0x28D4E91 VA: 0x28D4D90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.get_Current
	|
	|-RVA: 0x28D4FB0 Offset: 0x28D50B1 VA: 0x28D4FB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.get_Current
	|
	|-RVA: 0x28D51D0 Offset: 0x28D52D1 VA: 0x28D51D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.get_Current
	|
	|-RVA: 0x28D53F0 Offset: 0x28D54F1 VA: 0x28D53F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.get_Current
	|
	|-RVA: 0x28D5610 Offset: 0x28D5711 VA: 0x28D5610
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x28D5820 Offset: 0x28D5921 VA: 0x28D5820
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.get_Current
	|
	|-RVA: 0x28D5A40 Offset: 0x28D5B41 VA: 0x28D5A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.get_Current
	|
	|-RVA: 0x28D5C60 Offset: 0x28D5D61 VA: 0x28D5C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>.get_Current
	|
	|-RVA: 0x28D5E70 Offset: 0x28D5F71 VA: 0x28D5E70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.get_Current
	|
	|-RVA: 0x28D6080 Offset: 0x28D6181 VA: 0x28D6080
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.get_Current
	|
	|-RVA: 0x28D6290 Offset: 0x28D6391 VA: 0x28D6290
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>.get_Current
	|
	|-RVA: 0x28D64A0 Offset: 0x28D65A1 VA: 0x28D64A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>.get_Current
	|
	|-RVA: 0x28D66B0 Offset: 0x28D67B1 VA: 0x28D66B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>.get_Current
	|
	|-RVA: 0x28D68E0 Offset: 0x28D69E1 VA: 0x28D68E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>.get_Current
	|
	|-RVA: 0x28D6B00 Offset: 0x28D6C01 VA: 0x28D6B00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>.get_Current
	|
	|-RVA: 0x28D6D20 Offset: 0x28D6E21 VA: 0x28D6D20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>.get_Current
	|
	|-RVA: 0x28D6F30 Offset: 0x28D7031 VA: 0x28D6F30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>.get_Current
	|
	|-RVA: 0x28D7150 Offset: 0x28D7251 VA: 0x28D7150
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x28D7360 Offset: 0x28D7461 VA: 0x28D7360
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>.get_Current
	|
	|-RVA: 0x28D7580 Offset: 0x28D7681 VA: 0x28D7580
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>.get_Current
	|
	|-RVA: 0x28D77B0 Offset: 0x28D78B1 VA: 0x28D77B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>.get_Current
	|
	|-RVA: 0x28D79C0 Offset: 0x28D7AC1 VA: 0x28D79C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>.get_Current
	|
	|-RVA: 0x28D7C00 Offset: 0x28D7D01 VA: 0x28D7C00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.get_Current
	|
	|-RVA: 0x28D7E20 Offset: 0x28D7F21 VA: 0x28D7E20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>.get_Current
	|
	|-RVA: 0x28D8040 Offset: 0x28D8141 VA: 0x28D8040
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>.get_Current
	|
	|-RVA: 0x28D8250 Offset: 0x28D8351 VA: 0x28D8250
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>.get_Current
	|
	|-RVA: 0x28D8470 Offset: 0x28D8571 VA: 0x28D8470
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>.get_Current
	|
	|-RVA: 0x28D8690 Offset: 0x28D8791 VA: 0x28D8690
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x28D88B0 Offset: 0x28D89B1 VA: 0x28D88B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.get_Current
	|
	|-RVA: 0x28D8AD0 Offset: 0x28D8BD1 VA: 0x28D8AD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>.get_Current
	|
	|-RVA: 0x28D8CE0 Offset: 0x28D8DE1 VA: 0x28D8CE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>.get_Current
	|
	|-RVA: 0x28D8EF0 Offset: 0x28D8FF1 VA: 0x28D8EF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>.get_Current
	|
	|-RVA: 0x28D9110 Offset: 0x28D9211 VA: 0x28D9110
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>.get_Current
	|
	|-RVA: 0x28D9330 Offset: 0x28D9431 VA: 0x28D9330
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>.get_Current
	|
	|-RVA: 0x28D9550 Offset: 0x28D9651 VA: 0x28D9550
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.get_Current
	|
	|-RVA: 0x28D9770 Offset: 0x28D9871 VA: 0x28D9770
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.get_Current
	|
	|-RVA: 0x28D9980 Offset: 0x28D9A81 VA: 0x28D9980
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.get_Current
	|
	|-RVA: 0x28D9B90 Offset: 0x28D9C91 VA: 0x28D9B90
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>.get_Current
	|
	|-RVA: 0x28D9DD0 Offset: 0x28D9ED1 VA: 0x28D9DD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>.get_Current
	|
	|-RVA: 0x28D9FE0 Offset: 0x28DA0E1 VA: 0x28D9FE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>.get_Current
	|
	|-RVA: 0x28DA1F0 Offset: 0x28DA2F1 VA: 0x28DA1F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.get_Current
	|
	|-RVA: 0x28DA400 Offset: 0x28DA501 VA: 0x28DA400
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>.get_Current
	|
	|-RVA: 0x28DA610 Offset: 0x28DA711 VA: 0x28DA610
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.get_Current
	|
	|-RVA: 0x28DA820 Offset: 0x28DA921 VA: 0x28DA820
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.get_Current
	|
	|-RVA: 0x28DAA30 Offset: 0x28DAB31 VA: 0x28DAA30
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.get_Current
	|
	|-RVA: 0x28DAC40 Offset: 0x28DAD41 VA: 0x28DAC40
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.get_Current
	|
	|-RVA: 0x28DAE70 Offset: 0x28DAF71 VA: 0x28DAE70
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.get_Current
	|
	|-RVA: 0x28DB0A0 Offset: 0x28DB1A1 VA: 0x28DB0A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.get_Current
	|
	|-RVA: 0x28DB2D0 Offset: 0x28DB3D1 VA: 0x28DB2D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.get_Current
	|
	|-RVA: 0x28DB4E0 Offset: 0x28DB5E1 VA: 0x28DB4E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.get_Current
	|
	|-RVA: 0x28DB6F0 Offset: 0x28DB7F1 VA: 0x28DB6F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>.get_Current
	|
	|-RVA: 0x28DB910 Offset: 0x28DBA11 VA: 0x28DB910
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>.get_Current
	|
	|-RVA: 0x28DBB30 Offset: 0x28DBC31 VA: 0x28DBB30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>.get_Current
	|
	|-RVA: 0x28DBD50 Offset: 0x28DBE51 VA: 0x28DBD50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>.get_Current
	|
	|-RVA: 0x28DBF60 Offset: 0x28DC061 VA: 0x28DBF60
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.get_Current
	|
	|-RVA: 0x28DC170 Offset: 0x28DC271 VA: 0x28DC170
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.get_Current
	|
	|-RVA: 0x28DC380 Offset: 0x28DC481 VA: 0x28DC380
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>.get_Current
	|
	|-RVA: 0x28DC5A0 Offset: 0x28DC6A1 VA: 0x28DC5A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>.get_Current
	|
	|-RVA: 0x28DC7D0 Offset: 0x28DC8D1 VA: 0x28DC7D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>.get_Current
	|
	|-RVA: 0x28DC9E0 Offset: 0x28DCAE1 VA: 0x28DC9E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>.get_Current
	|
	|-RVA: 0x28DCC20 Offset: 0x28DCD21 VA: 0x28DCC20
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>.get_Current
	|
	|-RVA: 0x28DCE40 Offset: 0x28DCF41 VA: 0x28DCE40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>.get_Current
	|
	|-RVA: 0x28DD060 Offset: 0x28DD161 VA: 0x28DD060
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>.get_Current
	|
	|-RVA: 0x28DD270 Offset: 0x28DD371 VA: 0x28DD270
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>.get_Current
	|
	|-RVA: 0x28DD490 Offset: 0x28DD591 VA: 0x28DD490
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>.get_Current
	|
	|-RVA: 0x28DD6B0 Offset: 0x28DD7B1 VA: 0x28DD6B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.get_Current
	|
	|-RVA: 0x28DD8C0 Offset: 0x28DD9C1 VA: 0x28DD8C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.get_Current
	|
	|-RVA: 0x28DDAD0 Offset: 0x28DDBD1 VA: 0x28DDAD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>.get_Current
	|
	|-RVA: 0x28DDCE0 Offset: 0x28DDDE1 VA: 0x28DDCE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>.get_Current
	|
	|-RVA: 0x28DDEF0 Offset: 0x28DDFF1 VA: 0x28DDEF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>.get_Current
	|
	|-RVA: 0x28DE110 Offset: 0x28DE211 VA: 0x28DE110
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>.get_Current
	|
	|-RVA: 0x28DE330 Offset: 0x28DE431 VA: 0x28DE330
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>.get_Current
	|
	|-RVA: 0x28DE550 Offset: 0x28DE651 VA: 0x28DE550
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.get_Current
	|
	|-RVA: 0x28DE770 Offset: 0x28DE871 VA: 0x28DE770
	|-Array.EmptyInternalEnumerator<DateTime>.get_Current
	|
	|-RVA: 0x28DE980 Offset: 0x28DEA81 VA: 0x28DE980
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.get_Current
	|
	|-RVA: 0x28DEB90 Offset: 0x28DEC91 VA: 0x28DEB90
	|-Array.EmptyInternalEnumerator<Decimal>.get_Current
	|
	|-RVA: 0x28DEDA0 Offset: 0x28DEEA1 VA: 0x28DEDA0
	|-Array.EmptyInternalEnumerator<double>.get_Current
	|
	|-RVA: 0x28DEFB0 Offset: 0x28DF0B1 VA: 0x28DEFB0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.get_Current
	|
	|-RVA: 0x28DF1C0 Offset: 0x28DF2C1 VA: 0x28DF1C0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.get_Current
	|
	|-RVA: 0x273E800 Offset: 0x273E901 VA: 0x273E800
	|-Array.EmptyInternalEnumerator<Guid>.get_Current
	|
	|-RVA: 0x273EA10 Offset: 0x273EB11 VA: 0x273EA10
	|-Array.EmptyInternalEnumerator<short>.get_Current
	|
	|-RVA: 0x273EC20 Offset: 0x273ED21 VA: 0x273EC20
	|-Array.EmptyInternalEnumerator<int>.get_Current
	|
	|-RVA: 0x273EE30 Offset: 0x273EF31 VA: 0x273EE30
	|-Array.EmptyInternalEnumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x273F040 Offset: 0x273F141 VA: 0x273F040
	|-Array.EmptyInternalEnumerator<long>.get_Current
	|
	|-RVA: 0x273F250 Offset: 0x273F351 VA: 0x273F250
	|-Array.EmptyInternalEnumerator<IntPtr>.get_Current
	|
	|-RVA: 0x273F460 Offset: 0x273F561 VA: 0x273F460
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.get_Current
	|
	|-RVA: 0x273F670 Offset: 0x273F771 VA: 0x273F670
	|-Array.EmptyInternalEnumerator<LocalDefinition>.get_Current
	|
	|-RVA: 0x273F880 Offset: 0x273F981 VA: 0x273F880
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.get_Current
	|
	|-RVA: 0x273FA90 Offset: 0x273FB91 VA: 0x273FA90
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>.get_Current
	|
	|-RVA: 0x273FCA0 Offset: 0x273FDA1 VA: 0x273FCA0
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.get_Current
	|
	|-RVA: 0x273FEC0 Offset: 0x273FFC1 VA: 0x273FEC0
	|-Array.EmptyInternalEnumerator<Memory<object>>.get_Current
	|
	|-RVA: 0x27400D0 Offset: 0x27401D1 VA: 0x27400D0
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.get_Current
	|
	|-RVA: 0x27402E0 Offset: 0x27403E1 VA: 0x27402E0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.get_Current
	|
	|-RVA: 0x27404F0 Offset: 0x27405F1 VA: 0x27404F0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.get_Current
	|
	|-RVA: 0x2740700 Offset: 0x2740801 VA: 0x2740700
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>.get_Current
	|
	|-RVA: 0x2740930 Offset: 0x2740A31 VA: 0x2740930
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>.get_Current
	|
	|-RVA: 0x2740B40 Offset: 0x2740C41 VA: 0x2740B40
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>.get_Current
	|
	|-RVA: 0x2740D70 Offset: 0x2740E71 VA: 0x2740D70
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>.get_Current
	|
	|-RVA: 0x2740FA0 Offset: 0x27410A1 VA: 0x2740FA0
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>.get_Current
	|
	|-RVA: 0x27411B0 Offset: 0x27412B1 VA: 0x27411B0
	|-Array.EmptyInternalEnumerator<Nullable<Color>>.get_Current
	|
	|-RVA: 0x27413D0 Offset: 0x27414D1 VA: 0x27413D0
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>.get_Current
	|
	|-RVA: 0x27415E0 Offset: 0x27416E1 VA: 0x27415E0
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>.get_Current
	|
	|-RVA: 0x2741800 Offset: 0x2741901 VA: 0x2741800
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>.get_Current
	|
	|-RVA: 0x2741A20 Offset: 0x2741B21 VA: 0x2741A20
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>.get_Current
	|
	|-RVA: 0x2741C30 Offset: 0x2741D31 VA: 0x2741C30
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>.get_Current
	|
	|-RVA: 0x2741E70 Offset: 0x2741F71 VA: 0x2741E70
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>.get_Current
	|
	|-RVA: 0x2742090 Offset: 0x2742191 VA: 0x2742090
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>.get_Current
	|
	|-RVA: 0x27422A0 Offset: 0x27423A1 VA: 0x27422A0
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>.get_Current
	|
	|-RVA: 0x27424C0 Offset: 0x27425C1 VA: 0x27424C0
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>.get_Current
	|
	|-RVA: 0x27426E0 Offset: 0x27427E1 VA: 0x27426E0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>.get_Current
	|
	|-RVA: 0x27428F0 Offset: 0x27429F1 VA: 0x27428F0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>.get_Current
	|
	|-RVA: 0x2742B00 Offset: 0x2742C01 VA: 0x2742B00
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>.get_Current
	|
	|-RVA: 0x2742D10 Offset: 0x2742E11 VA: 0x2742D10
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>.get_Current
	|
	|-RVA: 0x2742F20 Offset: 0x2743021 VA: 0x2742F20
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>.get_Current
	|
	|-RVA: 0x2743140 Offset: 0x2743241 VA: 0x2743140
	|-Array.EmptyInternalEnumerator<object>.get_Current
	|
	|-RVA: 0x2743310 Offset: 0x2743411 VA: 0x2743310
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.get_Current
	|
	|-RVA: 0x2743520 Offset: 0x2743621 VA: 0x2743520
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>.get_Current
	|
	|-RVA: 0x2743730 Offset: 0x2743831 VA: 0x2743730
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.get_Current
	|
	|-RVA: 0x2743950 Offset: 0x2743A51 VA: 0x2743950
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.get_Current
	|
	|-RVA: 0x2743B60 Offset: 0x2743C61 VA: 0x2743B60
	|-Array.EmptyInternalEnumerator<Label>.get_Current
	|
	|-RVA: 0x2743D70 Offset: 0x2743E71 VA: 0x2743D70
	|-Array.EmptyInternalEnumerator<ParameterModifier>.get_Current
	|
	|-RVA: 0x2743F80 Offset: 0x2744081 VA: 0x2743F80
	|-Array.EmptyInternalEnumerator<ResourceLocator>.get_Current
	|
	|-RVA: 0x2744190 Offset: 0x2744291 VA: 0x2744190
	|-Array.EmptyInternalEnumerator<Ephemeron>.get_Current
	|
	|-RVA: 0x27443A0 Offset: 0x27444A1 VA: 0x27443A0
	|-Array.EmptyInternalEnumerator<GCHandle>.get_Current
	|
	|-RVA: 0x27445B0 Offset: 0x27446B1 VA: 0x27445B0
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>.get_Current
	|
	|-RVA: 0x27447C0 Offset: 0x27448C1 VA: 0x27447C0
	|-Array.EmptyInternalEnumerator<sbyte>.get_Current
	|
	|-RVA: 0x27449D0 Offset: 0x2744AD1 VA: 0x27449D0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.get_Current
	|
	|-RVA: 0x2744BE0 Offset: 0x2744CE1 VA: 0x2744BE0
	|-Array.EmptyInternalEnumerator<float>.get_Current
	|
	|-RVA: 0x2744DF0 Offset: 0x2744EF1 VA: 0x2744DF0
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.get_Current
	|
	|-RVA: 0x2745000 Offset: 0x2745101 VA: 0x2745000
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.get_Current
	|
	|-RVA: 0x2745220 Offset: 0x2745321 VA: 0x2745220
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.get_Current
	|
	|-RVA: 0x2745430 Offset: 0x2745531 VA: 0x2745430
	|-Array.EmptyInternalEnumerator<TimeSpan>.get_Current
	|
	|-RVA: 0x2745640 Offset: 0x2745741 VA: 0x2745640
	|-Array.EmptyInternalEnumerator<ushort>.get_Current
	|
	|-RVA: 0x2745850 Offset: 0x2745951 VA: 0x2745850
	|-Array.EmptyInternalEnumerator<UInt16Enum>.get_Current
	|
	|-RVA: 0x2745A60 Offset: 0x2745B61 VA: 0x2745A60
	|-Array.EmptyInternalEnumerator<uint>.get_Current
	|
	|-RVA: 0x2745C70 Offset: 0x2745D71 VA: 0x2745C70
	|-Array.EmptyInternalEnumerator<UInt32Enum>.get_Current
	|
	|-RVA: 0x2745E80 Offset: 0x2745F81 VA: 0x2745E80
	|-Array.EmptyInternalEnumerator<ulong>.get_Current
	|
	|-RVA: 0x2746090 Offset: 0x2746191 VA: 0x2746090
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>.get_Current
	|
	|-RVA: 0x27462A0 Offset: 0x27463A1 VA: 0x27462A0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x27464B0 Offset: 0x27465B1 VA: 0x27464B0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x27466C0 Offset: 0x27467C1 VA: 0x27466C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x27468D0 Offset: 0x27469D1 VA: 0x27468D0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x2746AE0 Offset: 0x2746BE1 VA: 0x2746AE0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.get_Current
	|
	|-RVA: 0x2746CF0 Offset: 0x2746DF1 VA: 0x2746CF0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>.get_Current
	|
	|-RVA: 0x2746F00 Offset: 0x2747001 VA: 0x2746F00
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>.get_Current
	|
	|-RVA: 0x2747110 Offset: 0x2747211 VA: 0x2747110
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>.get_Current
	|
	|-RVA: 0x2747340 Offset: 0x2747441 VA: 0x2747340
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x2747550 Offset: 0x2747651 VA: 0x2747550
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>.get_Current
	|
	|-RVA: 0x2747770 Offset: 0x2747871 VA: 0x2747770
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>.get_Current
	|
	|-RVA: 0x2747990 Offset: 0x2747A91 VA: 0x2747990
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Current
	|
	|-RVA: 0x2747BC0 Offset: 0x2747CC1 VA: 0x2747BC0
	|-Array.EmptyInternalEnumerator<HighlightState>.get_Current
	|
	|-RVA: 0x2747DE0 Offset: 0x2747EE1 VA: 0x2747DE0
	|-Array.EmptyInternalEnumerator<MaterialReference>.get_Current
	|
	|-RVA: 0x2748010 Offset: 0x2748111 VA: 0x2748010
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.get_Current
	|
	|-RVA: 0x2748230 Offset: 0x2748331 VA: 0x2748230
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.get_Current
	|
	|-RVA: 0x2748460 Offset: 0x2748561 VA: 0x2748460
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.get_Current
	|
	|-RVA: 0x2748680 Offset: 0x2748781 VA: 0x2748680
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.get_Current
	|
	|-RVA: 0x2748890 Offset: 0x2748991 VA: 0x2748890
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.get_Current
	|
	|-RVA: 0x2748AE0 Offset: 0x2748BE1 VA: 0x2748AE0
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.get_Current
	|
	|-RVA: 0x2748D10 Offset: 0x2748E11 VA: 0x2748D10
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.get_Current
	|
	|-RVA: 0x2748F50 Offset: 0x2749051 VA: 0x2748F50
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.get_Current
	|
	|-RVA: 0x2749170 Offset: 0x2749271 VA: 0x2749170
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.get_Current
	|
	|-RVA: 0x2749380 Offset: 0x2749481 VA: 0x2749380
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.get_Current
	|
	|-RVA: 0x27495A0 Offset: 0x27496A1 VA: 0x27495A0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.get_Current
	|
	|-RVA: 0x27497C0 Offset: 0x27498C1 VA: 0x27497C0
	|-Array.EmptyInternalEnumerator<WordWrapState>.get_Current
	|
	|-RVA: 0x27499E0 Offset: 0x2749AE1 VA: 0x27499E0
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>.get_Current
	|
	|-RVA: 0x2749C10 Offset: 0x2749D11 VA: 0x2749C10
	|-Array.EmptyInternalEnumerator<TransitionTables>.get_Current
	|
	|-RVA: 0x2749E30 Offset: 0x2749F31 VA: 0x2749E30
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>.get_Current
	|
	|-RVA: 0x274A040 Offset: 0x274A141 VA: 0x274A040
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>.get_Current
	|
	|-RVA: 0x274A250 Offset: 0x274A351 VA: 0x274A250
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>.get_Current
	|
	|-RVA: 0x274A460 Offset: 0x274A561 VA: 0x274A460
	|-Array.EmptyInternalEnumerator<CapEdge>.get_Current
	|
	|-RVA: 0x274A690 Offset: 0x274A791 VA: 0x274A690
	|-Array.EmptyInternalEnumerator<ClippedEdge>.get_Current
	|
	|-RVA: 0x274A8B0 Offset: 0x274A9B1 VA: 0x274A8B0
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>.get_Current
	|
	|-RVA: 0x274AAC0 Offset: 0x274ABC1 VA: 0x274AAC0
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>.get_Current
	|
	|-RVA: 0x274ACD0 Offset: 0x274ADD1 VA: 0x274ACD0
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>.get_Current
	|
	|-RVA: 0x274AEE0 Offset: 0x274AFE1 VA: 0x274AEE0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.get_Current
	|
	|-RVA: 0x274B100 Offset: 0x274B201 VA: 0x274B100
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>.get_Current
	|
	|-RVA: 0x274B330 Offset: 0x274B431 VA: 0x274B330
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>.get_Current
	|
	|-RVA: 0x274B540 Offset: 0x274B641 VA: 0x274B540
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>.get_Current
	|
	|-RVA: 0x274B790 Offset: 0x274B891 VA: 0x274B790
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.get_Current
	|
	|-RVA: 0x274B9A0 Offset: 0x274BAA1 VA: 0x274B9A0
	|-Array.EmptyInternalEnumerator<ConstraintSource>.get_Current
	|
	|-RVA: 0x274BBB0 Offset: 0x274BCB1 VA: 0x274BBB0
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>.get_Current
	|
	|-RVA: 0x274BDC0 Offset: 0x274BEC1 VA: 0x274BDC0
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>.get_Current
	|
	|-RVA: 0x274BFD0 Offset: 0x274C0D1 VA: 0x274BFD0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.get_Current
	|
	|-RVA: 0x274C1E0 Offset: 0x274C2E1 VA: 0x274C1E0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|
	|-RVA: 0x274C3F0 Offset: 0x274C4F1 VA: 0x274C3F0
	|-Array.EmptyInternalEnumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x274C600 Offset: 0x274C701 VA: 0x274C600
	|-Array.EmptyInternalEnumerator<BoneWeight>.get_Current
	|
	|-RVA: 0x274C820 Offset: 0x274C921 VA: 0x274C820
	|-Array.EmptyInternalEnumerator<BoundingSphere>.get_Current
	|
	|-RVA: 0x274CA30 Offset: 0x274CB31 VA: 0x274CA30
	|-Array.EmptyInternalEnumerator<Bounds>.get_Current
	|
	|-RVA: 0x274CC50 Offset: 0x274CD51 VA: 0x274CC50
	|-Array.EmptyInternalEnumerator<BoundsInt>.get_Current
	|
	|-RVA: 0x274CE70 Offset: 0x274CF71 VA: 0x274CE70
	|-Array.EmptyInternalEnumerator<CharacterInfo>.get_Current
	|
	|-RVA: 0x274D0A0 Offset: 0x274D1A1 VA: 0x274D0A0
	|-Array.EmptyInternalEnumerator<Color32>.get_Current
	|
	|-RVA: 0x274D2B0 Offset: 0x274D3B1 VA: 0x274D2B0
	|-Array.EmptyInternalEnumerator<Color>.get_Current
	|
	|-RVA: 0x274D4C0 Offset: 0x274D5C1 VA: 0x274D4C0
	|-Array.EmptyInternalEnumerator<CombineInstance>.get_Current
	|
	|-RVA: 0x274D710 Offset: 0x274D811 VA: 0x274D710
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.get_Current
	|
	|-RVA: 0x274D940 Offset: 0x274DA41 VA: 0x274D940
	|-Array.EmptyInternalEnumerator<ContactPoint>.get_Current
	|
	|-RVA: 0x274DB70 Offset: 0x274DC71 VA: 0x274DB70
	|-Array.EmptyInternalEnumerator<RaycastResult>.get_Current
	|
	|-RVA: 0x274DDB0 Offset: 0x274DEB1 VA: 0x274DDB0
	|-Array.EmptyInternalEnumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x274DFF0 Offset: 0x274E0F1 VA: 0x274DFF0
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.get_Current
	|
	|-RVA: 0x274E200 Offset: 0x274E301 VA: 0x274E200
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>.get_Current
	|
	|-RVA: 0x274E410 Offset: 0x274E511 VA: 0x274E410
	|-Array.EmptyInternalEnumerator<GradientColorKey>.get_Current
	|
	|-RVA: 0x274E630 Offset: 0x274E731 VA: 0x274E630
	|-Array.EmptyInternalEnumerator<HumanBone>.get_Current
	|
	|-RVA: 0x274E860 Offset: 0x274E961 VA: 0x274E860
	|-Array.EmptyInternalEnumerator<Keyframe>.get_Current
	|
	|-RVA: 0x274EA90 Offset: 0x274EB91 VA: 0x274EA90
	|-Array.EmptyInternalEnumerator<LOD>.get_Current
	|
	|-RVA: 0x274ECA0 Offset: 0x274EDA1 VA: 0x274ECA0
	|-Array.EmptyInternalEnumerator<LayerMask>.get_Current
	|
	|-RVA: 0x274EEB0 Offset: 0x274EFB1 VA: 0x274EEB0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.get_Current
	|
	|-RVA: 0x274F0E0 Offset: 0x274F1E1 VA: 0x274F0E0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x274F310 Offset: 0x274F411 VA: 0x274F310
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x274F530 Offset: 0x274F631 VA: 0x274F530
	|-Array.EmptyInternalEnumerator<PatchExtents>.get_Current
	|
	|-RVA: 0x274F740 Offset: 0x274F841 VA: 0x274F740
	|-Array.EmptyInternalEnumerator<Plane>.get_Current
	|
	|-RVA: 0x274F950 Offset: 0x274FA51 VA: 0x274F950
	|-Array.EmptyInternalEnumerator<Playable>.get_Current
	|
	|-RVA: 0x274FB60 Offset: 0x274FC61 VA: 0x274FB60
	|-Array.EmptyInternalEnumerator<PlayableBinding>.get_Current
	|
	|-RVA: 0x274FD80 Offset: 0x274FE81 VA: 0x274FD80
	|-Array.EmptyInternalEnumerator<PlayableGraph>.get_Current
	|
	|-RVA: 0x274FF90 Offset: 0x2750091 VA: 0x274FF90
	|-Array.EmptyInternalEnumerator<Edge>.get_Current
	|
	|-RVA: 0x27501A0 Offset: 0x27502A1 VA: 0x27501A0
	|-Array.EmptyInternalEnumerator<IntVec3>.get_Current
	|
	|-RVA: 0x27503B0 Offset: 0x27504B1 VA: 0x27503B0
	|-Array.EmptyInternalEnumerator<Quaternion>.get_Current
	|
	|-RVA: 0x27505C0 Offset: 0x27506C1 VA: 0x27505C0
	|-Array.EmptyInternalEnumerator<RangeInt>.get_Current
	|
	|-RVA: 0x27507D0 Offset: 0x27508D1 VA: 0x27507D0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x2750A00 Offset: 0x2750B01 VA: 0x2750A00
	|-Array.EmptyInternalEnumerator<RaycastHit>.get_Current
	|
	|-RVA: 0x2750C30 Offset: 0x2750D31 VA: 0x2750C30
	|-Array.EmptyInternalEnumerator<Rect>.get_Current
	|
	|-RVA: 0x2750E40 Offset: 0x2750F41 VA: 0x2750E40
	|-Array.EmptyInternalEnumerator<RectInt>.get_Current
	|
	|-RVA: 0x2751050 Offset: 0x2751151 VA: 0x2751050
	|-Array.EmptyInternalEnumerator<RenderBuffer>.get_Current
	|
	|-RVA: 0x2751260 Offset: 0x2751361 VA: 0x2751260
	|-Array.EmptyInternalEnumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x2751470 Offset: 0x2751571 VA: 0x2751470
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>.get_Current
	|
	|-RVA: 0x2751680 Offset: 0x2751781 VA: 0x2751680
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.get_Current
	|
	|-RVA: 0x27518D0 Offset: 0x27519D1 VA: 0x27518D0
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x2751AE0 Offset: 0x2751BE1 VA: 0x2751AE0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2751D00 Offset: 0x2751E01 VA: 0x2751D00
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x2751F20 Offset: 0x2752021 VA: 0x2751F20
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>.get_Current
	|
	|-RVA: 0x2752140 Offset: 0x2752241 VA: 0x2752140
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.get_Current
	|
	|-RVA: 0x2752370 Offset: 0x2752471 VA: 0x2752370
	|-Array.EmptyInternalEnumerator<SceneInstance>.get_Current
	|
	|-RVA: 0x2752580 Offset: 0x2752681 VA: 0x2752580
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.get_Current
	|
	|-RVA: 0x27527A0 Offset: 0x27528A1 VA: 0x27527A0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.get_Current
	|
	|-RVA: 0x27529D0 Offset: 0x2752AD1 VA: 0x27529D0
	|-Array.EmptyInternalEnumerator<SerializedType>.get_Current
	|
	|-RVA: 0x2752BF0 Offset: 0x2752CF1 VA: 0x2752BF0
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.get_Current
	|
	|-RVA: 0x2752E00 Offset: 0x2752F01 VA: 0x2752E00
	|-Array.EmptyInternalEnumerator<SkeletonBone>.get_Current
	|
	|-RVA: 0x2753030 Offset: 0x2753131 VA: 0x2753030
	|-Array.EmptyInternalEnumerator<GlyphRect>.get_Current
	|
	|-RVA: 0x2753240 Offset: 0x2753341 VA: 0x2753240
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.get_Current
	|
	|-RVA: 0x2753470 Offset: 0x2753571 VA: 0x2753470
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.get_Current
	|
	|-RVA: 0x27536A0 Offset: 0x27537A1 VA: 0x27536A0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.get_Current
	|
	|-RVA: 0x27538D0 Offset: 0x27539D1 VA: 0x27538D0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.get_Current
	|
	|-RVA: 0x2753AF0 Offset: 0x2753BF1 VA: 0x2753AF0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.get_Current
	|
	|-RVA: 0x2753D10 Offset: 0x2753E11 VA: 0x2753D10
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.get_Current
	|
	|-RVA: 0x2753F30 Offset: 0x2754031 VA: 0x2753F30
	|-Array.EmptyInternalEnumerator<Touch>.get_Current
	|
	|-RVA: 0x2754170 Offset: 0x2754271 VA: 0x2754170
	|-Array.EmptyInternalEnumerator<TreeInstance>.get_Current
	|
	|-RVA: 0x27543A0 Offset: 0x27544A1 VA: 0x27543A0
	|-Array.EmptyInternalEnumerator<ColorBlock>.get_Current
	|
	|-RVA: 0x27545E0 Offset: 0x27546E1 VA: 0x27545E0
	|-Array.EmptyInternalEnumerator<Navigation>.get_Current
	|
	|-RVA: 0x2754810 Offset: 0x2754911 VA: 0x2754810
	|-Array.EmptyInternalEnumerator<SpriteState>.get_Current
	|
	|-RVA: 0x2754A30 Offset: 0x2754B31 VA: 0x2754A30
	|-Array.EmptyInternalEnumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x2754C40 Offset: 0x2754D41 VA: 0x2754C40
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>.get_Current
	|
	|-RVA: 0x2754E50 Offset: 0x2754F51 VA: 0x2754E50
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>.get_Current
	|
	|-RVA: 0x2755060 Offset: 0x2755161 VA: 0x2755060
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>.get_Current
	|
	|-RVA: 0x2755270 Offset: 0x2755371 VA: 0x2755270
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>.get_Current
	|
	|-RVA: 0x2755480 Offset: 0x2755581 VA: 0x2755480
	|-Array.EmptyInternalEnumerator<StyleValue>.get_Current
	|
	|-RVA: 0x27556A0 Offset: 0x27557A1 VA: 0x27556A0
	|-Array.EmptyInternalEnumerator<UILineInfo>.get_Current
	|
	|-RVA: 0x27558B0 Offset: 0x27559B1 VA: 0x27558B0
	|-Array.EmptyInternalEnumerator<UIVertex>.get_Current
	|
	|-RVA: 0x2755AF0 Offset: 0x2755BF1 VA: 0x2755AF0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x2755D10 Offset: 0x2755E11 VA: 0x2755D10
	|-Array.EmptyInternalEnumerator<Vector2>.get_Current
	|
	|-RVA: 0x2755F20 Offset: 0x2756021 VA: 0x2755F20
	|-Array.EmptyInternalEnumerator<Vector2Int>.get_Current
	|
	|-RVA: 0x2756130 Offset: 0x2756231 VA: 0x2756130
	|-Array.EmptyInternalEnumerator<Vector3>.get_Current
	|
	|-RVA: 0x2756340 Offset: 0x2756441 VA: 0x2756340
	|-Array.EmptyInternalEnumerator<Vector3Int>.get_Current
	|
	|-RVA: 0x2756550 Offset: 0x2756651 VA: 0x2756550
	|-Array.EmptyInternalEnumerator<Vector4>.get_Current
	|
	|-RVA: 0x2756760 Offset: 0x2756861 VA: 0x2756760
	|-Array.EmptyInternalEnumerator<jvalue>.get_Current
	|
	|-RVA: 0x2756970 Offset: 0x2756A71 VA: 0x2756970
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>.get_Current
	|
	|-RVA: 0x2756BC0 Offset: 0x2756CC1 VA: 0x2756BC0
	|-Array.EmptyInternalEnumerator<YieldItemParam>.get_Current
	|
	|-RVA: 0x2756DD0 Offset: 0x2756ED1 VA: 0x2756DD0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.get_Current
	|
	|-RVA: 0x2756FE0 Offset: 0x27570E1 VA: 0x2756FE0
	|-Array.EmptyInternalEnumerator<Uid>.get_Current
	|
	|-RVA: 0x27571F0 Offset: 0x27572F1 VA: 0x27571F0
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>.get_Current
	|
	|-RVA: 0x2757400 Offset: 0x2757501 VA: 0x2757400
	|-Array.EmptyInternalEnumerator<NsUid>.get_Current
	|
	|-RVA: 0x2757610 Offset: 0x2757711 VA: 0x2757610
	|-Array.EmptyInternalEnumerator<Friend>.get_Current
	|
	|-RVA: 0x2757830 Offset: 0x2757931 VA: 0x2757830
	|-Array.EmptyInternalEnumerator<Profile>.get_Current
	|
	|-RVA: 0x2757A50 Offset: 0x2757B51 VA: 0x2757A50
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.get_Current
	|
	|-RVA: 0x2757C70 Offset: 0x2757D71 VA: 0x2757C70
	|-Array.EmptyInternalEnumerator<DebugPadState>.get_Current
	|
	|-RVA: 0x2757E90 Offset: 0x2757F91 VA: 0x2757E90
	|-Array.EmptyInternalEnumerator<GesturePoint>.get_Current
	|
	|-RVA: 0x27580A0 Offset: 0x27581A1 VA: 0x27580A0
	|-Array.EmptyInternalEnumerator<GestureState>.get_Current
	|
	|-RVA: 0x27582E0 Offset: 0x27583E1 VA: 0x27582E0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.get_Current
	|
	|-RVA: 0x2758510 Offset: 0x2758611 VA: 0x2758510
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.get_Current
	|
	|-RVA: 0x2758740 Offset: 0x2758841 VA: 0x2758740
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.get_Current
	|
	|-RVA: 0x2758970 Offset: 0x2758A71 VA: 0x2758970
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.get_Current
	|
	|-RVA: 0x2758BA0 Offset: 0x2758CA1 VA: 0x2758BA0
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.get_Current
	|
	|-RVA: 0x2758DD0 Offset: 0x2758ED1 VA: 0x2758DD0
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.get_Current
	|
	|-RVA: 0x2469FF0 Offset: 0x246A0F1 VA: 0x2469FF0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.get_Current
	|
	|-RVA: 0x246A200 Offset: 0x246A301 VA: 0x246A200
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.get_Current
	|
	|-RVA: 0x246A440 Offset: 0x246A541 VA: 0x246A440
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.get_Current
	|
	|-RVA: 0x246A660 Offset: 0x246A761 VA: 0x246A660
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.get_Current
	|
	|-RVA: 0x246A880 Offset: 0x246A981 VA: 0x246A880
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.get_Current
	|
	|-RVA: 0x246AAA0 Offset: 0x246ABA1 VA: 0x246AAA0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.get_Current
	|
	|-RVA: 0x246ACC0 Offset: 0x246ADC1 VA: 0x246ACC0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.get_Current
	|
	|-RVA: 0x246AEE0 Offset: 0x246AFE1 VA: 0x246AEE0
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.get_Current
	|
	|-RVA: 0x246B100 Offset: 0x246B201 VA: 0x246B100
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.get_Current
	|
	|-RVA: 0x246B320 Offset: 0x246B421 VA: 0x246B320
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.get_Current
	|
	|-RVA: 0x246B550 Offset: 0x246B651 VA: 0x246B550
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.get_Current
	|
	|-RVA: 0x246B790 Offset: 0x246B891 VA: 0x246B790
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.get_Current
	|
	|-RVA: 0x246B9B0 Offset: 0x246BAB1 VA: 0x246B9B0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.get_Current
	|
	|-RVA: 0x246BBD0 Offset: 0x246BCD1 VA: 0x246BBD0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.get_Current
	|
	|-RVA: 0x246BDF0 Offset: 0x246BEF1 VA: 0x246BDF0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.get_Current
	|
	|-RVA: 0x246C010 Offset: 0x246C111 VA: 0x246C010
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.get_Current
	|
	|-RVA: 0x246C230 Offset: 0x246C331 VA: 0x246C230
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.get_Current
	|
	|-RVA: 0x246C450 Offset: 0x246C551 VA: 0x246C450
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.get_Current
	|
	|-RVA: 0x246C670 Offset: 0x246C771 VA: 0x246C670
	|-Array.EmptyInternalEnumerator<TouchState>.get_Current
	|
	|-RVA: 0x246C8A0 Offset: 0x246C9A1 VA: 0x246C8A0
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.get_Current
	|
	|-RVA: 0x246CAB0 Offset: 0x246CBB1 VA: 0x246CAB0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.get_Current
	|
	|-RVA: 0x246CCC0 Offset: 0x246CDC1 VA: 0x246CCC0
	|-Array.EmptyInternalEnumerator<VibrationValue>.get_Current
	|
	|-RVA: 0x246CED0 Offset: 0x246CFD1 VA: 0x246CED0
	|-Array.EmptyInternalEnumerator<ClusteringData>.get_Current
	|
	|-RVA: 0x246D0F0 Offset: 0x246D1F1 VA: 0x246D0F0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.get_Current
	|
	|-RVA: 0x246D310 Offset: 0x246D411 VA: 0x246D310
	|-Array.EmptyInternalEnumerator<Finger>.get_Current
	|
	|-RVA: 0x246D540 Offset: 0x246D641 VA: 0x246D540
	|-Array.EmptyInternalEnumerator<Hand>.get_Current
	|
	|-RVA: 0x246D760 Offset: 0x246D861 VA: 0x246D760
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.get_Current
	|
	|-RVA: 0x246D970 Offset: 0x246DA71 VA: 0x246D970
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.get_Current
	|
	|-RVA: 0x246DB90 Offset: 0x246DC91 VA: 0x246DB90
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.get_Current
	|
	|-RVA: 0x246DDB0 Offset: 0x246DEB1 VA: 0x246DDB0
	|-Array.EmptyInternalEnumerator<MomentStatistic>.get_Current
	|
	|-RVA: 0x246DFC0 Offset: 0x246E0C1 VA: 0x246DFC0
	|-Array.EmptyInternalEnumerator<Protrusion>.get_Current
	|
	|-RVA: 0x246E1D0 Offset: 0x246E2D1 VA: 0x246E1D0
	|-Array.EmptyInternalEnumerator<Shape>.get_Current
	|
	|-RVA: 0x246E3F0 Offset: 0x246E4F1 VA: 0x246E3F0
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.get_Current
	|
	|-RVA: 0x246E600 Offset: 0x246E701 VA: 0x246E600
	|-Array.EmptyInternalEnumerator<UserWord>.get_Current
	|
	|-RVA: 0x246E810 Offset: 0x246E911 VA: 0x246E810
	|-Array.EmptyInternalEnumerator<Color4u8>.get_Current
	|
	|-RVA: 0x246EA20 Offset: 0x246EB21 VA: 0x246EA20
	|-Array.EmptyInternalEnumerator<Float2>.get_Current
	|
	|-RVA: 0x246EC30 Offset: 0x246ED31 VA: 0x246EC30
	|-Array.EmptyInternalEnumerator<stCommand_t>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4C20 Offset: 0x28A4D21 VA: 0x28A4C20
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A4E40 Offset: 0x28A4F41 VA: 0x28A4E40
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A5080 Offset: 0x28A5181 VA: 0x28A5080
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A5290 Offset: 0x28A5391 VA: 0x28A5290
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A54A0 Offset: 0x28A55A1 VA: 0x28A54A0
	|-Array.EmptyInternalEnumerator<BitVector32Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A56B0 Offset: 0x28A57B1 VA: 0x28A56B0
	|-Array.EmptyInternalEnumerator<BuildItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A5900 Offset: 0x28A5A01 VA: 0x28A5900
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A5B10 Offset: 0x28A5C11 VA: 0x28A5B10
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A5D20 Offset: 0x28A5E21 VA: 0x28A5D20
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A5F30 Offset: 0x28A6031 VA: 0x28A5F30
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6140 Offset: 0x28A6241 VA: 0x28A6140
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6360 Offset: 0x28A6461 VA: 0x28A6360
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6580 Offset: 0x28A6681 VA: 0x28A6580
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6790 Offset: 0x28A6891 VA: 0x28A6790
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A69A0 Offset: 0x28A6AA1 VA: 0x28A69A0
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6BD0 Offset: 0x28A6CD1 VA: 0x28A6BD0
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6DE0 Offset: 0x28A6EE1 VA: 0x28A6DE0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A6FF0 Offset: 0x28A70F1 VA: 0x28A6FF0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7210 Offset: 0x28A7311 VA: 0x28A7210
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7420 Offset: 0x28A7521 VA: 0x28A7420
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7630 Offset: 0x28A7731 VA: 0x28A7630
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7860 Offset: 0x28A7961 VA: 0x28A7860
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7A90 Offset: 0x28A7B91 VA: 0x28A7A90
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7CC0 Offset: 0x28A7DC1 VA: 0x28A7CC0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A7EE0 Offset: 0x28A7FE1 VA: 0x28A7EE0
	|-Array.EmptyInternalEnumerator<CropDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8100 Offset: 0x28A8201 VA: 0x28A8100
	|-Array.EmptyInternalEnumerator<ControlPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8320 Offset: 0x28A8421 VA: 0x28A8320
	|-Array.EmptyInternalEnumerator<DamageTextInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8540 Offset: 0x28A8641 VA: 0x28A8540
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8760 Offset: 0x28A8861 VA: 0x28A8760
	|-Array.EmptyInternalEnumerator<DropItemParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8970 Offset: 0x28A8A71 VA: 0x28A8970
	|-Array.EmptyInternalEnumerator<DropTableElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8B90 Offset: 0x28A8C91 VA: 0x28A8B90
	|-Array.EmptyInternalEnumerator<EffectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8DB0 Offset: 0x28A8EB1 VA: 0x28A8DB0
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A8FC0 Offset: 0x28A90C1 VA: 0x28A8FC0
	|-Array.EmptyInternalEnumerator<Coord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A91D0 Offset: 0x28A92D1 VA: 0x28A91D0
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A93F0 Offset: 0x28A94F1 VA: 0x28A93F0
	|-Array.EmptyInternalEnumerator<EventCheckId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A9610 Offset: 0x28A9711 VA: 0x28A9610
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A9820 Offset: 0x28A9921 VA: 0x28A9820
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A9A30 Offset: 0x28A9B31 VA: 0x28A9A30
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A9C70 Offset: 0x28A9D71 VA: 0x28A9C70
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28A9EA0 Offset: 0x28A9FA1 VA: 0x28A9EA0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AA0C0 Offset: 0x28AA1C1 VA: 0x28AA0C0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AA2D0 Offset: 0x28AA3D1 VA: 0x28AA2D0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AA4E0 Offset: 0x28AA5E1 VA: 0x28AA4E0
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AA6F0 Offset: 0x28AA7F1 VA: 0x28AA6F0
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AA900 Offset: 0x28AAA01 VA: 0x28AA900
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AAB30 Offset: 0x28AAC31 VA: 0x28AAB30
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AAD50 Offset: 0x28AAE51 VA: 0x28AAD50
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AAF90 Offset: 0x28AB091 VA: 0x28AAF90
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AB1A0 Offset: 0x28AB2A1 VA: 0x28AB1A0
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AB3D0 Offset: 0x28AB4D1 VA: 0x28AB3D0
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AB5F0 Offset: 0x28AB6F1 VA: 0x28AB5F0
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AB810 Offset: 0x28AB911 VA: 0x28AB810
	|-Array.EmptyInternalEnumerator<FurnitureData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ABA30 Offset: 0x28ABB31 VA: 0x28ABA30
	|-Array.EmptyInternalEnumerator<GateDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ABC40 Offset: 0x28ABD41 VA: 0x28ABC40
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ABE70 Offset: 0x28ABF71 VA: 0x28ABE70
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AC080 Offset: 0x28AC181 VA: 0x28AC080
	|-Array.EmptyInternalEnumerator<HitResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AC2B0 Offset: 0x28AC3B1 VA: 0x28AC2B0
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AC4D0 Offset: 0x28AC5D1 VA: 0x28AC4D0
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AC6F0 Offset: 0x28AC7F1 VA: 0x28AC6F0
	|-Array.EmptyInternalEnumerator<ItemLevelData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AC900 Offset: 0x28ACA01 VA: 0x28AC900
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ACB20 Offset: 0x28ACC21 VA: 0x28ACB20
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ACD50 Offset: 0x28ACE51 VA: 0x28ACD50
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ACF60 Offset: 0x28AD061 VA: 0x28ACF60
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AD190 Offset: 0x28AD291 VA: 0x28AD190
	|-Array.EmptyInternalEnumerator<MiningDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AD3A0 Offset: 0x28AD4A1 VA: 0x28AD3A0
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AD5D0 Offset: 0x28AD6D1 VA: 0x28AD5D0
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AD7F0 Offset: 0x28AD8F1 VA: 0x28AD7F0
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ADA10 Offset: 0x28ADB11 VA: 0x28ADA10
	|-Array.EmptyInternalEnumerator<MonsterDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ADC30 Offset: 0x28ADD31 VA: 0x28ADC30
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28ADE50 Offset: 0x28ADF51 VA: 0x28ADE50
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AE080 Offset: 0x28AE181 VA: 0x28AE080
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AE2B0 Offset: 0x28AE3B1 VA: 0x28AE2B0
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AE4E0 Offset: 0x28AE5E1 VA: 0x28AE4E0
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AE6F0 Offset: 0x28AE7F1 VA: 0x28AE6F0
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AE900 Offset: 0x28AEA01 VA: 0x28AE900
	|-Array.EmptyInternalEnumerator<NPCActionData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AEB30 Offset: 0x28AEC31 VA: 0x28AEB30
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AED40 Offset: 0x28AEE41 VA: 0x28AED40
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AEF50 Offset: 0x28AF051 VA: 0x28AEF50
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AF170 Offset: 0x28AF271 VA: 0x28AF170
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AF380 Offset: 0x28AF481 VA: 0x28AF380
	|-Array.EmptyInternalEnumerator<OrderSaveData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AF5B0 Offset: 0x28AF6B1 VA: 0x28AF5B0
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AF7D0 Offset: 0x28AF8D1 VA: 0x28AF7D0
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AF9E0 Offset: 0x28AFAE1 VA: 0x28AF9E0
	|-Array.EmptyInternalEnumerator<Parameter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AFC00 Offset: 0x28AFD01 VA: 0x28AFC00
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28AFE10 Offset: 0x28AFF11 VA: 0x28AFE10
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0040 Offset: 0x28B0141 VA: 0x28B0040
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0250 Offset: 0x28B0351 VA: 0x28B0250
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0480 Offset: 0x28B0581 VA: 0x28B0480
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0690 Offset: 0x28B0791 VA: 0x28B0690
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B08A0 Offset: 0x28B09A1 VA: 0x28B08A0
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0AB0 Offset: 0x28B0BB1 VA: 0x28B0AB0
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0CE0 Offset: 0x28B0DE1 VA: 0x28B0CE0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B0F10 Offset: 0x28B1011 VA: 0x28B0F10
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1140 Offset: 0x28B1241 VA: 0x28B1140
	|-Array.EmptyInternalEnumerator<ProfilerFrame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1350 Offset: 0x28B1451 VA: 0x28B1350
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1560 Offset: 0x28B1661 VA: 0x28B1560
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1780 Offset: 0x28B1881 VA: 0x28B1780
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B19A0 Offset: 0x28B1AA1 VA: 0x28B19A0
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1BB0 Offset: 0x28B1CB1 VA: 0x28B1BB0
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1DC0 Offset: 0x28B1EC1 VA: 0x28B1DC0
	|-Array.EmptyInternalEnumerator<Schedule>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B1FE0 Offset: 0x28B20E1 VA: 0x28B1FE0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B21F0 Offset: 0x28B22F1 VA: 0x28B21F0
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28B2400 Offset: 0x28B2501 VA: 0x28B2400
	|-Array.EmptyInternalEnumerator<SpeedData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F25E0 Offset: 0x26F26E1 VA: 0x26F25E0
	|-Array.EmptyInternalEnumerator<CurveSample>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F2820 Offset: 0x26F2921 VA: 0x26F2820
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F2A30 Offset: 0x26F2B31 VA: 0x26F2A30
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F2C40 Offset: 0x26F2D41 VA: 0x26F2C40
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F2E50 Offset: 0x26F2F51 VA: 0x26F2E50
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3060 Offset: 0x26F3161 VA: 0x26F3060
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3270 Offset: 0x26F3371 VA: 0x26F3270
	|-Array.EmptyInternalEnumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3480 Offset: 0x26F3581 VA: 0x26F3480
	|-Array.EmptyInternalEnumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3690 Offset: 0x26F3791 VA: 0x26F3690
	|-Array.EmptyInternalEnumerator<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F38A0 Offset: 0x26F39A1 VA: 0x26F38A0
	|-Array.EmptyInternalEnumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3AB0 Offset: 0x26F3BB1 VA: 0x26F3AB0
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3CC0 Offset: 0x26F3DC1 VA: 0x26F3CC0
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F3ED0 Offset: 0x26F3FD1 VA: 0x26F3ED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F40F0 Offset: 0x26F41F1 VA: 0x26F40F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F4310 Offset: 0x26F4411 VA: 0x26F4310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F4540 Offset: 0x26F4641 VA: 0x26F4540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F4780 Offset: 0x26F4881 VA: 0x26F4780
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F49B0 Offset: 0x26F4AB1 VA: 0x26F49B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F4BD0 Offset: 0x26F4CD1 VA: 0x26F4BD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F4DF0 Offset: 0x26F4EF1 VA: 0x26F4DF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F5020 Offset: 0x26F5121 VA: 0x26F5020
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F5240 Offset: 0x26F5341 VA: 0x26F5240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F5470 Offset: 0x26F5571 VA: 0x26F5470
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F56A0 Offset: 0x26F57A1 VA: 0x26F56A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F58C0 Offset: 0x26F59C1 VA: 0x26F58C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F5AE0 Offset: 0x26F5BE1 VA: 0x26F5AE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F5D00 Offset: 0x26F5E01 VA: 0x26F5D00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F5F20 Offset: 0x26F6021 VA: 0x26F5F20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F6140 Offset: 0x26F6241 VA: 0x26F6140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F6360 Offset: 0x26F6461 VA: 0x26F6360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F6580 Offset: 0x26F6681 VA: 0x26F6580
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F67A0 Offset: 0x26F68A1 VA: 0x26F67A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F69C0 Offset: 0x26F6AC1 VA: 0x26F69C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F6BE0 Offset: 0x26F6CE1 VA: 0x26F6BE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F6DF0 Offset: 0x26F6EF1 VA: 0x26F6DF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7030 Offset: 0x26F7131 VA: 0x26F7030
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7250 Offset: 0x26F7351 VA: 0x26F7250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7460 Offset: 0x26F7561 VA: 0x26F7460
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7670 Offset: 0x26F7771 VA: 0x26F7670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7880 Offset: 0x26F7981 VA: 0x26F7880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7A90 Offset: 0x26F7B91 VA: 0x26F7A90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7CB0 Offset: 0x26F7DB1 VA: 0x26F7CB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F7ED0 Offset: 0x26F7FD1 VA: 0x26F7ED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8100 Offset: 0x26F8201 VA: 0x26F8100
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8320 Offset: 0x26F8421 VA: 0x26F8320
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8540 Offset: 0x26F8641 VA: 0x26F8540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8760 Offset: 0x26F8861 VA: 0x26F8760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8980 Offset: 0x26F8A81 VA: 0x26F8980
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8BB0 Offset: 0x26F8CB1 VA: 0x26F8BB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8DE0 Offset: 0x26F8EE1 VA: 0x26F8DE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F8FF0 Offset: 0x26F90F1 VA: 0x26F8FF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9210 Offset: 0x26F9311 VA: 0x26F9210
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9420 Offset: 0x26F9521 VA: 0x26F9420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9630 Offset: 0x26F9731 VA: 0x26F9630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9850 Offset: 0x26F9951 VA: 0x26F9850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9A60 Offset: 0x26F9B61 VA: 0x26F9A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9C80 Offset: 0x26F9D81 VA: 0x26F9C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26F9EA0 Offset: 0x26F9FA1 VA: 0x26F9EA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FA0C0 Offset: 0x26FA1C1 VA: 0x26FA0C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FA2E0 Offset: 0x26FA3E1 VA: 0x26FA2E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FA500 Offset: 0x26FA601 VA: 0x26FA500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FA720 Offset: 0x26FA821 VA: 0x26FA720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FA950 Offset: 0x26FAA51 VA: 0x26FA950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FAB80 Offset: 0x26FAC81 VA: 0x26FAB80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FADA0 Offset: 0x26FAEA1 VA: 0x26FADA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FAFD0 Offset: 0x26FB0D1 VA: 0x26FAFD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FB1F0 Offset: 0x26FB2F1 VA: 0x26FB1F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FB420 Offset: 0x26FB521 VA: 0x26FB420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FB650 Offset: 0x26FB751 VA: 0x26FB650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FB870 Offset: 0x26FB971 VA: 0x26FB870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FBAB0 Offset: 0x26FBBB1 VA: 0x26FBAB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FBCE0 Offset: 0x26FBDE1 VA: 0x26FBCE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FBF00 Offset: 0x26FC001 VA: 0x26FBF00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FC130 Offset: 0x26FC231 VA: 0x26FC130
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FC360 Offset: 0x26FC461 VA: 0x26FC360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FC580 Offset: 0x26FC681 VA: 0x26FC580
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FC7A0 Offset: 0x26FC8A1 VA: 0x26FC7A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FC9C0 Offset: 0x26FCAC1 VA: 0x26FC9C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FCBE0 Offset: 0x26FCCE1 VA: 0x26FCBE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FCE10 Offset: 0x26FCF11 VA: 0x26FCE10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FD030 Offset: 0x26FD131 VA: 0x26FD030
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FD260 Offset: 0x26FD361 VA: 0x26FD260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FD4A0 Offset: 0x26FD5A1 VA: 0x26FD4A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FD6D0 Offset: 0x26FD7D1 VA: 0x26FD6D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FD8F0 Offset: 0x26FD9F1 VA: 0x26FD8F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FDB10 Offset: 0x26FDC11 VA: 0x26FDB10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FDD40 Offset: 0x26FDE41 VA: 0x26FDD40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FDF60 Offset: 0x26FE061 VA: 0x26FDF60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FE190 Offset: 0x26FE291 VA: 0x26FE190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FE3C0 Offset: 0x26FE4C1 VA: 0x26FE3C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FE5E0 Offset: 0x26FE6E1 VA: 0x26FE5E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FE800 Offset: 0x26FE901 VA: 0x26FE800
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FEA20 Offset: 0x26FEB21 VA: 0x26FEA20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FEC40 Offset: 0x26FED41 VA: 0x26FEC40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FEE60 Offset: 0x26FEF61 VA: 0x26FEE60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FF080 Offset: 0x26FF181 VA: 0x26FF080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FF2A0 Offset: 0x26FF3A1 VA: 0x26FF2A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FF4C0 Offset: 0x26FF5C1 VA: 0x26FF4C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FF6E0 Offset: 0x26FF7E1 VA: 0x26FF6E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FF900 Offset: 0x26FFA01 VA: 0x26FF900
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FFB20 Offset: 0x26FFC21 VA: 0x26FFB20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FFD40 Offset: 0x26FFE41 VA: 0x26FFD40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26FFF60 Offset: 0x2700061 VA: 0x26FFF60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2700190 Offset: 0x2700291 VA: 0x2700190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27003C0 Offset: 0x27004C1 VA: 0x27003C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27005E0 Offset: 0x27006E1 VA: 0x27005E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2700810 Offset: 0x2700911 VA: 0x2700810
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2700A30 Offset: 0x2700B31 VA: 0x2700A30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2700C60 Offset: 0x2700D61 VA: 0x2700C60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2700E90 Offset: 0x2700F91 VA: 0x2700E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27010B0 Offset: 0x27011B1 VA: 0x27010B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27012F0 Offset: 0x27013F1 VA: 0x27012F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2701520 Offset: 0x2701621 VA: 0x2701520
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2701740 Offset: 0x2701841 VA: 0x2701740
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2701970 Offset: 0x2701A71 VA: 0x2701970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2701BA0 Offset: 0x2701CA1 VA: 0x2701BA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2701DC0 Offset: 0x2701EC1 VA: 0x2701DC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2701FE0 Offset: 0x27020E1 VA: 0x2701FE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702200 Offset: 0x2702301 VA: 0x2702200
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702420 Offset: 0x2702521 VA: 0x2702420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702650 Offset: 0x2702751 VA: 0x2702650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702870 Offset: 0x2702971 VA: 0x2702870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702A90 Offset: 0x2702B91 VA: 0x2702A90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702CB0 Offset: 0x2702DB1 VA: 0x2702CB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2702ED0 Offset: 0x2702FD1 VA: 0x2702ED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27030F0 Offset: 0x27031F1 VA: 0x27030F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2703310 Offset: 0x2703411 VA: 0x2703310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2703530 Offset: 0x2703631 VA: 0x2703530
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2703750 Offset: 0x2703851 VA: 0x2703750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2703980 Offset: 0x2703A81 VA: 0x2703980
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2703BB0 Offset: 0x2703CB1 VA: 0x2703BB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2703DE0 Offset: 0x2703EE1 VA: 0x2703DE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704000 Offset: 0x2704101 VA: 0x2704000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704220 Offset: 0x2704321 VA: 0x2704220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704440 Offset: 0x2704541 VA: 0x2704440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704670 Offset: 0x2704771 VA: 0x2704670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27048A0 Offset: 0x27049A1 VA: 0x27048A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704AC0 Offset: 0x2704BC1 VA: 0x2704AC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704D00 Offset: 0x2704E01 VA: 0x2704D00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2704F20 Offset: 0x2705021 VA: 0x2704F20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2705140 Offset: 0x2705241 VA: 0x2705140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2705360 Offset: 0x2705461 VA: 0x2705360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2705580 Offset: 0x2705681 VA: 0x2705580
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27057A0 Offset: 0x27058A1 VA: 0x27057A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27059D0 Offset: 0x2705AD1 VA: 0x27059D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2705C00 Offset: 0x2705D01 VA: 0x2705C00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2705E20 Offset: 0x2705F21 VA: 0x2705E20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2706040 Offset: 0x2706141 VA: 0x2706040
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2706260 Offset: 0x2706361 VA: 0x2706260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2706480 Offset: 0x2706581 VA: 0x2706480
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27066A0 Offset: 0x27067A1 VA: 0x27066A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27068C0 Offset: 0x27069C1 VA: 0x27068C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2706AE0 Offset: 0x2706BE1 VA: 0x2706AE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2706D00 Offset: 0x2706E01 VA: 0x2706D00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2706F40 Offset: 0x2707041 VA: 0x2706F40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2707160 Offset: 0x2707261 VA: 0x2707160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2707380 Offset: 0x2707481 VA: 0x2707380
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2707590 Offset: 0x2707691 VA: 0x2707590
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27077A0 Offset: 0x27078A1 VA: 0x27077A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27079C0 Offset: 0x2707AC1 VA: 0x27079C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2707BE0 Offset: 0x2707CE1 VA: 0x2707BE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2707E00 Offset: 0x2707F01 VA: 0x2707E00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2708030 Offset: 0x2708131 VA: 0x2708030
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2708260 Offset: 0x2708361 VA: 0x2708260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2708490 Offset: 0x2708591 VA: 0x2708490
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27086B0 Offset: 0x27087B1 VA: 0x27086B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27088D0 Offset: 0x27089D1 VA: 0x27088D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2708B00 Offset: 0x2708C01 VA: 0x2708B00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2708D30 Offset: 0x2708E31 VA: 0x2708D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2708F50 Offset: 0x2709051 VA: 0x2708F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2709170 Offset: 0x2709271 VA: 0x2709170
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2709390 Offset: 0x2709491 VA: 0x2709390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27095B0 Offset: 0x27096B1 VA: 0x27095B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27097E0 Offset: 0x27098E1 VA: 0x27097E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2709A10 Offset: 0x2709B11 VA: 0x2709A10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2709C30 Offset: 0x2709D31 VA: 0x2709C30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2709E70 Offset: 0x2709F71 VA: 0x2709E70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270A090 Offset: 0x270A191 VA: 0x270A090
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270A2B0 Offset: 0x270A3B1 VA: 0x270A2B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270A4D0 Offset: 0x270A5D1 VA: 0x270A4D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270A6F0 Offset: 0x270A7F1 VA: 0x270A6F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270A910 Offset: 0x270AA11 VA: 0x270A910
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270AB30 Offset: 0x270AC31 VA: 0x270AB30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270AD50 Offset: 0x270AE51 VA: 0x270AD50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270AF70 Offset: 0x270B071 VA: 0x270AF70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270B190 Offset: 0x270B291 VA: 0x270B190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270B3B0 Offset: 0x270B4B1 VA: 0x270B3B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270B5D0 Offset: 0x270B6D1 VA: 0x270B5D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x270B7F0 Offset: 0x270B8F1 VA: 0x270B7F0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C67D0 Offset: 0x28C68D1 VA: 0x28C67D0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C69E0 Offset: 0x28C6AE1 VA: 0x28C69E0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C6BF0 Offset: 0x28C6CF1 VA: 0x28C6BF0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C6E00 Offset: 0x28C6F01 VA: 0x28C6E00
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7010 Offset: 0x28C7111 VA: 0x28C7010
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7230 Offset: 0x28C7331 VA: 0x28C7230
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7450 Offset: 0x28C7551 VA: 0x28C7450
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7660 Offset: 0x28C7761 VA: 0x28C7660
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7880 Offset: 0x28C7981 VA: 0x28C7880
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7AB0 Offset: 0x28C7BB1 VA: 0x28C7AB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7CD0 Offset: 0x28C7DD1 VA: 0x28C7CD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C7EF0 Offset: 0x28C7FF1 VA: 0x28C7EF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C8110 Offset: 0x28C8211 VA: 0x28C8110
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C8340 Offset: 0x28C8441 VA: 0x28C8340
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C8560 Offset: 0x28C8661 VA: 0x28C8560
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C8790 Offset: 0x28C8891 VA: 0x28C8790
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C89C0 Offset: 0x28C8AC1 VA: 0x28C89C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C8BE0 Offset: 0x28C8CE1 VA: 0x28C8BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C8DF0 Offset: 0x28C8EF1 VA: 0x28C8DF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9000 Offset: 0x28C9101 VA: 0x28C9000
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9210 Offset: 0x28C9311 VA: 0x28C9210
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9420 Offset: 0x28C9521 VA: 0x28C9420
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9630 Offset: 0x28C9731 VA: 0x28C9630
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9850 Offset: 0x28C9951 VA: 0x28C9850
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9A60 Offset: 0x28C9B61 VA: 0x28C9A60
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9C80 Offset: 0x28C9D81 VA: 0x28C9C80
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28C9EA0 Offset: 0x28C9FA1 VA: 0x28C9EA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CA0B0 Offset: 0x28CA1B1 VA: 0x28CA0B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CA2F0 Offset: 0x28CA3F1 VA: 0x28CA2F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CA510 Offset: 0x28CA611 VA: 0x28CA510
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CA720 Offset: 0x28CA821 VA: 0x28CA720
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CA930 Offset: 0x28CAA31 VA: 0x28CA930
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CAB40 Offset: 0x28CAC41 VA: 0x28CAB40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CAD50 Offset: 0x28CAE51 VA: 0x28CAD50
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CAF60 Offset: 0x28CB061 VA: 0x28CAF60
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CB170 Offset: 0x28CB271 VA: 0x28CB170
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CB3A0 Offset: 0x28CB4A1 VA: 0x28CB3A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CB5C0 Offset: 0x28CB6C1 VA: 0x28CB5C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CB7D0 Offset: 0x28CB8D1 VA: 0x28CB7D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CB9E0 Offset: 0x28CBAE1 VA: 0x28CB9E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CBC00 Offset: 0x28CBD01 VA: 0x28CBC00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CBE30 Offset: 0x28CBF31 VA: 0x28CBE30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CC050 Offset: 0x28CC151 VA: 0x28CC050
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CC260 Offset: 0x28CC361 VA: 0x28CC260
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CC470 Offset: 0x28CC571 VA: 0x28CC470
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CC680 Offset: 0x28CC781 VA: 0x28CC680
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CC890 Offset: 0x28CC991 VA: 0x28CC890
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CCAA0 Offset: 0x28CCBA1 VA: 0x28CCAA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CCCB0 Offset: 0x28CCDB1 VA: 0x28CCCB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CCED0 Offset: 0x28CCFD1 VA: 0x28CCED0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CD0E0 Offset: 0x28CD1E1 VA: 0x28CD0E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CD2F0 Offset: 0x28CD3F1 VA: 0x28CD2F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CD500 Offset: 0x28CD601 VA: 0x28CD500
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CD720 Offset: 0x28CD821 VA: 0x28CD720
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CD930 Offset: 0x28CDA31 VA: 0x28CD930
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CDB60 Offset: 0x28CDC61 VA: 0x28CDB60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CDD90 Offset: 0x28CDE91 VA: 0x28CDD90
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CDFA0 Offset: 0x28CE0A1 VA: 0x28CDFA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CE1C0 Offset: 0x28CE2C1 VA: 0x28CE1C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CE3E0 Offset: 0x28CE4E1 VA: 0x28CE3E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CE600 Offset: 0x28CE701 VA: 0x28CE600
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CE830 Offset: 0x28CE931 VA: 0x28CE830
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CEA40 Offset: 0x28CEB41 VA: 0x28CEA40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CEC80 Offset: 0x28CED81 VA: 0x28CEC80
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CEEA0 Offset: 0x28CEFA1 VA: 0x28CEEA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CF0C0 Offset: 0x28CF1C1 VA: 0x28CF0C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CF2E0 Offset: 0x28CF3E1 VA: 0x28CF2E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CF500 Offset: 0x28CF601 VA: 0x28CF500
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CF720 Offset: 0x28CF821 VA: 0x28CF720
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CF940 Offset: 0x28CFA41 VA: 0x28CF940
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CFB60 Offset: 0x28CFC61 VA: 0x28CFB60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CFD80 Offset: 0x28CFE81 VA: 0x28CFD80
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28CFFA0 Offset: 0x28D00A1 VA: 0x28CFFA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D01B0 Offset: 0x28D02B1 VA: 0x28D01B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D03D0 Offset: 0x28D04D1 VA: 0x28D03D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D0600 Offset: 0x28D0701 VA: 0x28D0600
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D0820 Offset: 0x28D0921 VA: 0x28D0820
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D0A40 Offset: 0x28D0B41 VA: 0x28D0A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D0C60 Offset: 0x28D0D61 VA: 0x28D0C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D0E90 Offset: 0x28D0F91 VA: 0x28D0E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D10B0 Offset: 0x28D11B1 VA: 0x28D10B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D12E0 Offset: 0x28D13E1 VA: 0x28D12E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D1510 Offset: 0x28D1611 VA: 0x28D1510
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D1730 Offset: 0x28D1831 VA: 0x28D1730
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D1950 Offset: 0x28D1A51 VA: 0x28D1950
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D1B60 Offset: 0x28D1C61 VA: 0x28D1B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D1D70 Offset: 0x28D1E71 VA: 0x28D1D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D1F80 Offset: 0x28D2081 VA: 0x28D1F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D2190 Offset: 0x28D2291 VA: 0x28D2190
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D23A0 Offset: 0x28D24A1 VA: 0x28D23A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D25B0 Offset: 0x28D26B1 VA: 0x28D25B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D27C0 Offset: 0x28D28C1 VA: 0x28D27C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D29D0 Offset: 0x28D2AD1 VA: 0x28D29D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D2BE0 Offset: 0x28D2CE1 VA: 0x28D2BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D2E00 Offset: 0x28D2F01 VA: 0x28D2E00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3010 Offset: 0x28D3111 VA: 0x28D3010
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3240 Offset: 0x28D3341 VA: 0x28D3240
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3470 Offset: 0x28D3571 VA: 0x28D3470
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3680 Offset: 0x28D3781 VA: 0x28D3680
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D38A0 Offset: 0x28D39A1 VA: 0x28D38A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3AC0 Offset: 0x28D3BC1 VA: 0x28D3AC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3CE0 Offset: 0x28D3DE1 VA: 0x28D3CE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D3F10 Offset: 0x28D4011 VA: 0x28D3F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D4120 Offset: 0x28D4221 VA: 0x28D4120
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D4360 Offset: 0x28D4461 VA: 0x28D4360
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D4580 Offset: 0x28D4681 VA: 0x28D4580
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D47A0 Offset: 0x28D48A1 VA: 0x28D47A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D49C0 Offset: 0x28D4AC1 VA: 0x28D49C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D4BE0 Offset: 0x28D4CE1 VA: 0x28D4BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D4E00 Offset: 0x28D4F01 VA: 0x28D4E00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5020 Offset: 0x28D5121 VA: 0x28D5020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5240 Offset: 0x28D5341 VA: 0x28D5240
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5460 Offset: 0x28D5561 VA: 0x28D5460
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5680 Offset: 0x28D5781 VA: 0x28D5680
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5890 Offset: 0x28D5991 VA: 0x28D5890
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5AB0 Offset: 0x28D5BB1 VA: 0x28D5AB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5CD0 Offset: 0x28D5DD1 VA: 0x28D5CD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D5EE0 Offset: 0x28D5FE1 VA: 0x28D5EE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D60F0 Offset: 0x28D61F1 VA: 0x28D60F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6300 Offset: 0x28D6401 VA: 0x28D6300
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6510 Offset: 0x28D6611 VA: 0x28D6510
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6720 Offset: 0x28D6821 VA: 0x28D6720
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6950 Offset: 0x28D6A51 VA: 0x28D6950
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6B70 Offset: 0x28D6C71 VA: 0x28D6B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6D90 Offset: 0x28D6E91 VA: 0x28D6D90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D6FA0 Offset: 0x28D70A1 VA: 0x28D6FA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D71C0 Offset: 0x28D72C1 VA: 0x28D71C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D73D0 Offset: 0x28D74D1 VA: 0x28D73D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D75F0 Offset: 0x28D76F1 VA: 0x28D75F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D7820 Offset: 0x28D7921 VA: 0x28D7820
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D7A30 Offset: 0x28D7B31 VA: 0x28D7A30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D7C70 Offset: 0x28D7D71 VA: 0x28D7C70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D7E90 Offset: 0x28D7F91 VA: 0x28D7E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D80B0 Offset: 0x28D81B1 VA: 0x28D80B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D82C0 Offset: 0x28D83C1 VA: 0x28D82C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D84E0 Offset: 0x28D85E1 VA: 0x28D84E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D8700 Offset: 0x28D8801 VA: 0x28D8700
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D8920 Offset: 0x28D8A21 VA: 0x28D8920
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D8B40 Offset: 0x28D8C41 VA: 0x28D8B40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D8D50 Offset: 0x28D8E51 VA: 0x28D8D50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D8F60 Offset: 0x28D9061 VA: 0x28D8F60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D9180 Offset: 0x28D9281 VA: 0x28D9180
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D93A0 Offset: 0x28D94A1 VA: 0x28D93A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D95C0 Offset: 0x28D96C1 VA: 0x28D95C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D97E0 Offset: 0x28D98E1 VA: 0x28D97E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D99F0 Offset: 0x28D9AF1 VA: 0x28D99F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D9C00 Offset: 0x28D9D01 VA: 0x28D9C00
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28D9E40 Offset: 0x28D9F41 VA: 0x28D9E40
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DA050 Offset: 0x28DA151 VA: 0x28DA050
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DA260 Offset: 0x28DA361 VA: 0x28DA260
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DA470 Offset: 0x28DA571 VA: 0x28DA470
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DA680 Offset: 0x28DA781 VA: 0x28DA680
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DA890 Offset: 0x28DA991 VA: 0x28DA890
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DAAA0 Offset: 0x28DABA1 VA: 0x28DAAA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DACB0 Offset: 0x28DADB1 VA: 0x28DACB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DAEE0 Offset: 0x28DAFE1 VA: 0x28DAEE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DB110 Offset: 0x28DB211 VA: 0x28DB110
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DB340 Offset: 0x28DB441 VA: 0x28DB340
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DB550 Offset: 0x28DB651 VA: 0x28DB550
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DB760 Offset: 0x28DB861 VA: 0x28DB760
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DB980 Offset: 0x28DBA81 VA: 0x28DB980
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DBBA0 Offset: 0x28DBCA1 VA: 0x28DBBA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DBDC0 Offset: 0x28DBEC1 VA: 0x28DBDC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DBFD0 Offset: 0x28DC0D1 VA: 0x28DBFD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DC1E0 Offset: 0x28DC2E1 VA: 0x28DC1E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DC3F0 Offset: 0x28DC4F1 VA: 0x28DC3F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DC610 Offset: 0x28DC711 VA: 0x28DC610
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DC840 Offset: 0x28DC941 VA: 0x28DC840
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DCA50 Offset: 0x28DCB51 VA: 0x28DCA50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DCC90 Offset: 0x28DCD91 VA: 0x28DCC90
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DCEB0 Offset: 0x28DCFB1 VA: 0x28DCEB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DD0D0 Offset: 0x28DD1D1 VA: 0x28DD0D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DD2E0 Offset: 0x28DD3E1 VA: 0x28DD2E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DD500 Offset: 0x28DD601 VA: 0x28DD500
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DD720 Offset: 0x28DD821 VA: 0x28DD720
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DD930 Offset: 0x28DDA31 VA: 0x28DD930
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DDB40 Offset: 0x28DDC41 VA: 0x28DDB40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DDD50 Offset: 0x28DDE51 VA: 0x28DDD50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DDF60 Offset: 0x28DE061 VA: 0x28DDF60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DE180 Offset: 0x28DE281 VA: 0x28DE180
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DE3A0 Offset: 0x28DE4A1 VA: 0x28DE3A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DE5C0 Offset: 0x28DE6C1 VA: 0x28DE5C0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DE7E0 Offset: 0x28DE8E1 VA: 0x28DE7E0
	|-Array.EmptyInternalEnumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DE9F0 Offset: 0x28DEAF1 VA: 0x28DE9F0
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DEC00 Offset: 0x28DED01 VA: 0x28DEC00
	|-Array.EmptyInternalEnumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DEE10 Offset: 0x28DEF11 VA: 0x28DEE10
	|-Array.EmptyInternalEnumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DF020 Offset: 0x28DF121 VA: 0x28DF020
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28DF230 Offset: 0x28DF331 VA: 0x28DF230
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273E870 Offset: 0x273E971 VA: 0x273E870
	|-Array.EmptyInternalEnumerator<Guid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273EA80 Offset: 0x273EB81 VA: 0x273EA80
	|-Array.EmptyInternalEnumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273EC90 Offset: 0x273ED91 VA: 0x273EC90
	|-Array.EmptyInternalEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273EEA0 Offset: 0x273EFA1 VA: 0x273EEA0
	|-Array.EmptyInternalEnumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273F0B0 Offset: 0x273F1B1 VA: 0x273F0B0
	|-Array.EmptyInternalEnumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273F2C0 Offset: 0x273F3C1 VA: 0x273F2C0
	|-Array.EmptyInternalEnumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273F4D0 Offset: 0x273F5D1 VA: 0x273F4D0
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273F6E0 Offset: 0x273F7E1 VA: 0x273F6E0
	|-Array.EmptyInternalEnumerator<LocalDefinition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273F8F0 Offset: 0x273F9F1 VA: 0x273F8F0
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273FB00 Offset: 0x273FC01 VA: 0x273FB00
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273FD10 Offset: 0x273FE11 VA: 0x273FD10
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x273FF30 Offset: 0x2740031 VA: 0x273FF30
	|-Array.EmptyInternalEnumerator<Memory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2740140 Offset: 0x2740241 VA: 0x2740140
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2740350 Offset: 0x2740451 VA: 0x2740350
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2740560 Offset: 0x2740661 VA: 0x2740560
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2740770 Offset: 0x2740871 VA: 0x2740770
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27409A0 Offset: 0x2740AA1 VA: 0x27409A0
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2740BB0 Offset: 0x2740CB1 VA: 0x2740BB0
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2740DE0 Offset: 0x2740EE1 VA: 0x2740DE0
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741010 Offset: 0x2741111 VA: 0x2741010
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741220 Offset: 0x2741321 VA: 0x2741220
	|-Array.EmptyInternalEnumerator<Nullable<Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741440 Offset: 0x2741541 VA: 0x2741440
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741650 Offset: 0x2741751 VA: 0x2741650
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741870 Offset: 0x2741971 VA: 0x2741870
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741A90 Offset: 0x2741B91 VA: 0x2741A90
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741CA0 Offset: 0x2741DA1 VA: 0x2741CA0
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2741EE0 Offset: 0x2741FE1 VA: 0x2741EE0
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742100 Offset: 0x2742201 VA: 0x2742100
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742310 Offset: 0x2742411 VA: 0x2742310
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742530 Offset: 0x2742631 VA: 0x2742530
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742750 Offset: 0x2742851 VA: 0x2742750
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742960 Offset: 0x2742A61 VA: 0x2742960
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742B70 Offset: 0x2742C71 VA: 0x2742B70
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742D80 Offset: 0x2742E81 VA: 0x2742D80
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2742F90 Offset: 0x2743091 VA: 0x2742F90
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27431B0 Offset: 0x27432B1 VA: 0x27431B0
	|-Array.EmptyInternalEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2743380 Offset: 0x2743481 VA: 0x2743380
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2743590 Offset: 0x2743691 VA: 0x2743590
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27437A0 Offset: 0x27438A1 VA: 0x27437A0
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27439C0 Offset: 0x2743AC1 VA: 0x27439C0
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2743BD0 Offset: 0x2743CD1 VA: 0x2743BD0
	|-Array.EmptyInternalEnumerator<Label>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2743DE0 Offset: 0x2743EE1 VA: 0x2743DE0
	|-Array.EmptyInternalEnumerator<ParameterModifier>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2743FF0 Offset: 0x27440F1 VA: 0x2743FF0
	|-Array.EmptyInternalEnumerator<ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744200 Offset: 0x2744301 VA: 0x2744200
	|-Array.EmptyInternalEnumerator<Ephemeron>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744410 Offset: 0x2744511 VA: 0x2744410
	|-Array.EmptyInternalEnumerator<GCHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744620 Offset: 0x2744721 VA: 0x2744620
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744830 Offset: 0x2744931 VA: 0x2744830
	|-Array.EmptyInternalEnumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744A40 Offset: 0x2744B41 VA: 0x2744A40
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744C50 Offset: 0x2744D51 VA: 0x2744C50
	|-Array.EmptyInternalEnumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2744E60 Offset: 0x2744F61 VA: 0x2744E60
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2745070 Offset: 0x2745171 VA: 0x2745070
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2745290 Offset: 0x2745391 VA: 0x2745290
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27454A0 Offset: 0x27455A1 VA: 0x27454A0
	|-Array.EmptyInternalEnumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27456B0 Offset: 0x27457B1 VA: 0x27456B0
	|-Array.EmptyInternalEnumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27458C0 Offset: 0x27459C1 VA: 0x27458C0
	|-Array.EmptyInternalEnumerator<UInt16Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2745AD0 Offset: 0x2745BD1 VA: 0x2745AD0
	|-Array.EmptyInternalEnumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2745CE0 Offset: 0x2745DE1 VA: 0x2745CE0
	|-Array.EmptyInternalEnumerator<UInt32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2745EF0 Offset: 0x2745FF1 VA: 0x2745EF0
	|-Array.EmptyInternalEnumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746100 Offset: 0x2746201 VA: 0x2746100
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746310 Offset: 0x2746411 VA: 0x2746310
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746520 Offset: 0x2746621 VA: 0x2746520
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746730 Offset: 0x2746831 VA: 0x2746730
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746940 Offset: 0x2746A41 VA: 0x2746940
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746B50 Offset: 0x2746C51 VA: 0x2746B50
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746D60 Offset: 0x2746E61 VA: 0x2746D60
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2746F70 Offset: 0x2747071 VA: 0x2746F70
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2747180 Offset: 0x2747281 VA: 0x2747180
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27473B0 Offset: 0x27474B1 VA: 0x27473B0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27475C0 Offset: 0x27476C1 VA: 0x27475C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27477E0 Offset: 0x27478E1 VA: 0x27477E0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2747A00 Offset: 0x2747B01 VA: 0x2747A00
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2747C30 Offset: 0x2747D31 VA: 0x2747C30
	|-Array.EmptyInternalEnumerator<HighlightState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2747E50 Offset: 0x2747F51 VA: 0x2747E50
	|-Array.EmptyInternalEnumerator<MaterialReference>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2748080 Offset: 0x2748181 VA: 0x2748080
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27482A0 Offset: 0x27483A1 VA: 0x27482A0
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27484D0 Offset: 0x27485D1 VA: 0x27484D0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27486F0 Offset: 0x27487F1 VA: 0x27486F0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2748900 Offset: 0x2748A01 VA: 0x2748900
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2748B50 Offset: 0x2748C51 VA: 0x2748B50
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2748D80 Offset: 0x2748E81 VA: 0x2748D80
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2748FC0 Offset: 0x27490C1 VA: 0x2748FC0
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27491E0 Offset: 0x27492E1 VA: 0x27491E0
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27493F0 Offset: 0x27494F1 VA: 0x27493F0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2749610 Offset: 0x2749711 VA: 0x2749610
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2749830 Offset: 0x2749931 VA: 0x2749830
	|-Array.EmptyInternalEnumerator<WordWrapState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2749A50 Offset: 0x2749B51 VA: 0x2749A50
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2749C80 Offset: 0x2749D81 VA: 0x2749C80
	|-Array.EmptyInternalEnumerator<TransitionTables>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2749EA0 Offset: 0x2749FA1 VA: 0x2749EA0
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274A0B0 Offset: 0x274A1B1 VA: 0x274A0B0
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274A2C0 Offset: 0x274A3C1 VA: 0x274A2C0
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274A4D0 Offset: 0x274A5D1 VA: 0x274A4D0
	|-Array.EmptyInternalEnumerator<CapEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274A700 Offset: 0x274A801 VA: 0x274A700
	|-Array.EmptyInternalEnumerator<ClippedEdge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274A920 Offset: 0x274AA21 VA: 0x274A920
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274AB30 Offset: 0x274AC31 VA: 0x274AB30
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274AD40 Offset: 0x274AE41 VA: 0x274AD40
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274AF50 Offset: 0x274B051 VA: 0x274AF50
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274B170 Offset: 0x274B271 VA: 0x274B170
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274B3A0 Offset: 0x274B4A1 VA: 0x274B3A0
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274B5B0 Offset: 0x274B6B1 VA: 0x274B5B0
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274B800 Offset: 0x274B901 VA: 0x274B800
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274BA10 Offset: 0x274BB11 VA: 0x274BA10
	|-Array.EmptyInternalEnumerator<ConstraintSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274BC20 Offset: 0x274BD21 VA: 0x274BC20
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274BE30 Offset: 0x274BF31 VA: 0x274BE30
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274C040 Offset: 0x274C141 VA: 0x274C040
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274C250 Offset: 0x274C351 VA: 0x274C250
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274C460 Offset: 0x274C561 VA: 0x274C460
	|-Array.EmptyInternalEnumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274C670 Offset: 0x274C771 VA: 0x274C670
	|-Array.EmptyInternalEnumerator<BoneWeight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274C890 Offset: 0x274C991 VA: 0x274C890
	|-Array.EmptyInternalEnumerator<BoundingSphere>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274CAA0 Offset: 0x274CBA1 VA: 0x274CAA0
	|-Array.EmptyInternalEnumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274CCC0 Offset: 0x274CDC1 VA: 0x274CCC0
	|-Array.EmptyInternalEnumerator<BoundsInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274CEE0 Offset: 0x274CFE1 VA: 0x274CEE0
	|-Array.EmptyInternalEnumerator<CharacterInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274D110 Offset: 0x274D211 VA: 0x274D110
	|-Array.EmptyInternalEnumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274D320 Offset: 0x274D421 VA: 0x274D320
	|-Array.EmptyInternalEnumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274D530 Offset: 0x274D631 VA: 0x274D530
	|-Array.EmptyInternalEnumerator<CombineInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274D780 Offset: 0x274D881 VA: 0x274D780
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274D9B0 Offset: 0x274DAB1 VA: 0x274D9B0
	|-Array.EmptyInternalEnumerator<ContactPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274DBE0 Offset: 0x274DCE1 VA: 0x274DBE0
	|-Array.EmptyInternalEnumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274DE20 Offset: 0x274DF21 VA: 0x274DE20
	|-Array.EmptyInternalEnumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274E060 Offset: 0x274E161 VA: 0x274E060
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274E270 Offset: 0x274E371 VA: 0x274E270
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274E480 Offset: 0x274E581 VA: 0x274E480
	|-Array.EmptyInternalEnumerator<GradientColorKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274E6A0 Offset: 0x274E7A1 VA: 0x274E6A0
	|-Array.EmptyInternalEnumerator<HumanBone>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274E8D0 Offset: 0x274E9D1 VA: 0x274E8D0
	|-Array.EmptyInternalEnumerator<Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274EB00 Offset: 0x274EC01 VA: 0x274EB00
	|-Array.EmptyInternalEnumerator<LOD>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274ED10 Offset: 0x274EE11 VA: 0x274ED10
	|-Array.EmptyInternalEnumerator<LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274EF20 Offset: 0x274F021 VA: 0x274EF20
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274F150 Offset: 0x274F251 VA: 0x274F150
	|-Array.EmptyInternalEnumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274F380 Offset: 0x274F481 VA: 0x274F380
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274F5A0 Offset: 0x274F6A1 VA: 0x274F5A0
	|-Array.EmptyInternalEnumerator<PatchExtents>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274F7B0 Offset: 0x274F8B1 VA: 0x274F7B0
	|-Array.EmptyInternalEnumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274F9C0 Offset: 0x274FAC1 VA: 0x274F9C0
	|-Array.EmptyInternalEnumerator<Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274FBD0 Offset: 0x274FCD1 VA: 0x274FBD0
	|-Array.EmptyInternalEnumerator<PlayableBinding>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x274FDF0 Offset: 0x274FEF1 VA: 0x274FDF0
	|-Array.EmptyInternalEnumerator<PlayableGraph>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750000 Offset: 0x2750101 VA: 0x2750000
	|-Array.EmptyInternalEnumerator<Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750210 Offset: 0x2750311 VA: 0x2750210
	|-Array.EmptyInternalEnumerator<IntVec3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750420 Offset: 0x2750521 VA: 0x2750420
	|-Array.EmptyInternalEnumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750630 Offset: 0x2750731 VA: 0x2750630
	|-Array.EmptyInternalEnumerator<RangeInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750840 Offset: 0x2750941 VA: 0x2750840
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750A70 Offset: 0x2750B71 VA: 0x2750A70
	|-Array.EmptyInternalEnumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750CA0 Offset: 0x2750DA1 VA: 0x2750CA0
	|-Array.EmptyInternalEnumerator<Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2750EB0 Offset: 0x2750FB1 VA: 0x2750EB0
	|-Array.EmptyInternalEnumerator<RectInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27510C0 Offset: 0x27511C1 VA: 0x27510C0
	|-Array.EmptyInternalEnumerator<RenderBuffer>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27512D0 Offset: 0x27513D1 VA: 0x27512D0
	|-Array.EmptyInternalEnumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27514E0 Offset: 0x27515E1 VA: 0x27514E0
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27516F0 Offset: 0x27517F1 VA: 0x27516F0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2751940 Offset: 0x2751A41 VA: 0x2751940
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2751B50 Offset: 0x2751C51 VA: 0x2751B50
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2751D70 Offset: 0x2751E71 VA: 0x2751D70
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2751F90 Offset: 0x2752091 VA: 0x2751F90
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27521B0 Offset: 0x27522B1 VA: 0x27521B0
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27523E0 Offset: 0x27524E1 VA: 0x27523E0
	|-Array.EmptyInternalEnumerator<SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27525F0 Offset: 0x27526F1 VA: 0x27525F0
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2752810 Offset: 0x2752911 VA: 0x2752810
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2752A40 Offset: 0x2752B41 VA: 0x2752A40
	|-Array.EmptyInternalEnumerator<SerializedType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2752C60 Offset: 0x2752D61 VA: 0x2752C60
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2752E70 Offset: 0x2752F71 VA: 0x2752E70
	|-Array.EmptyInternalEnumerator<SkeletonBone>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27530A0 Offset: 0x27531A1 VA: 0x27530A0
	|-Array.EmptyInternalEnumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27532B0 Offset: 0x27533B1 VA: 0x27532B0
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27534E0 Offset: 0x27535E1 VA: 0x27534E0
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2753710 Offset: 0x2753811 VA: 0x2753710
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2753940 Offset: 0x2753A41 VA: 0x2753940
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2753B60 Offset: 0x2753C61 VA: 0x2753B60
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2753D80 Offset: 0x2753E81 VA: 0x2753D80
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2753FA0 Offset: 0x27540A1 VA: 0x2753FA0
	|-Array.EmptyInternalEnumerator<Touch>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27541E0 Offset: 0x27542E1 VA: 0x27541E0
	|-Array.EmptyInternalEnumerator<TreeInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2754410 Offset: 0x2754511 VA: 0x2754410
	|-Array.EmptyInternalEnumerator<ColorBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2754650 Offset: 0x2754751 VA: 0x2754650
	|-Array.EmptyInternalEnumerator<Navigation>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2754880 Offset: 0x2754981 VA: 0x2754880
	|-Array.EmptyInternalEnumerator<SpriteState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2754AA0 Offset: 0x2754BA1 VA: 0x2754AA0
	|-Array.EmptyInternalEnumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2754CB0 Offset: 0x2754DB1 VA: 0x2754CB0
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2754EC0 Offset: 0x2754FC1 VA: 0x2754EC0
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27550D0 Offset: 0x27551D1 VA: 0x27550D0
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27552E0 Offset: 0x27553E1 VA: 0x27552E0
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27554F0 Offset: 0x27555F1 VA: 0x27554F0
	|-Array.EmptyInternalEnumerator<StyleValue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2755710 Offset: 0x2755811 VA: 0x2755710
	|-Array.EmptyInternalEnumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2755920 Offset: 0x2755A21 VA: 0x2755920
	|-Array.EmptyInternalEnumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2755B60 Offset: 0x2755C61 VA: 0x2755B60
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2755D80 Offset: 0x2755E81 VA: 0x2755D80
	|-Array.EmptyInternalEnumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2755F90 Offset: 0x2756091 VA: 0x2755F90
	|-Array.EmptyInternalEnumerator<Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27561A0 Offset: 0x27562A1 VA: 0x27561A0
	|-Array.EmptyInternalEnumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27563B0 Offset: 0x27564B1 VA: 0x27563B0
	|-Array.EmptyInternalEnumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27565C0 Offset: 0x27566C1 VA: 0x27565C0
	|-Array.EmptyInternalEnumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27567D0 Offset: 0x27568D1 VA: 0x27567D0
	|-Array.EmptyInternalEnumerator<jvalue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27569E0 Offset: 0x2756AE1 VA: 0x27569E0
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2756C30 Offset: 0x2756D31 VA: 0x2756C30
	|-Array.EmptyInternalEnumerator<YieldItemParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2756E40 Offset: 0x2756F41 VA: 0x2756E40
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757050 Offset: 0x2757151 VA: 0x2757050
	|-Array.EmptyInternalEnumerator<Uid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757260 Offset: 0x2757361 VA: 0x2757260
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757470 Offset: 0x2757571 VA: 0x2757470
	|-Array.EmptyInternalEnumerator<NsUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757680 Offset: 0x2757781 VA: 0x2757680
	|-Array.EmptyInternalEnumerator<Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27578A0 Offset: 0x27579A1 VA: 0x27578A0
	|-Array.EmptyInternalEnumerator<Profile>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757AC0 Offset: 0x2757BC1 VA: 0x2757AC0
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757CE0 Offset: 0x2757DE1 VA: 0x2757CE0
	|-Array.EmptyInternalEnumerator<DebugPadState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2757F00 Offset: 0x2758001 VA: 0x2757F00
	|-Array.EmptyInternalEnumerator<GesturePoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2758110 Offset: 0x2758211 VA: 0x2758110
	|-Array.EmptyInternalEnumerator<GestureState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2758350 Offset: 0x2758451 VA: 0x2758350
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2758580 Offset: 0x2758681 VA: 0x2758580
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27587B0 Offset: 0x27588B1 VA: 0x27587B0
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x27589E0 Offset: 0x2758AE1 VA: 0x27589E0
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2758C10 Offset: 0x2758D11 VA: 0x2758C10
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2758E40 Offset: 0x2758F41 VA: 0x2758E40
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246A060 Offset: 0x246A161 VA: 0x246A060
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246A270 Offset: 0x246A371 VA: 0x246A270
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246A4B0 Offset: 0x246A5B1 VA: 0x246A4B0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246A6D0 Offset: 0x246A7D1 VA: 0x246A6D0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246A8F0 Offset: 0x246A9F1 VA: 0x246A8F0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246AB10 Offset: 0x246AC11 VA: 0x246AB10
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246AD30 Offset: 0x246AE31 VA: 0x246AD30
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246AF50 Offset: 0x246B051 VA: 0x246AF50
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246B170 Offset: 0x246B271 VA: 0x246B170
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246B390 Offset: 0x246B491 VA: 0x246B390
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246B5C0 Offset: 0x246B6C1 VA: 0x246B5C0
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246B800 Offset: 0x246B901 VA: 0x246B800
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246BA20 Offset: 0x246BB21 VA: 0x246BA20
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246BC40 Offset: 0x246BD41 VA: 0x246BC40
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246BE60 Offset: 0x246BF61 VA: 0x246BE60
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246C080 Offset: 0x246C181 VA: 0x246C080
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246C2A0 Offset: 0x246C3A1 VA: 0x246C2A0
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246C4C0 Offset: 0x246C5C1 VA: 0x246C4C0
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246C6E0 Offset: 0x246C7E1 VA: 0x246C6E0
	|-Array.EmptyInternalEnumerator<TouchState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246C910 Offset: 0x246CA11 VA: 0x246C910
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246CB20 Offset: 0x246CC21 VA: 0x246CB20
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246CD30 Offset: 0x246CE31 VA: 0x246CD30
	|-Array.EmptyInternalEnumerator<VibrationValue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246CF40 Offset: 0x246D041 VA: 0x246CF40
	|-Array.EmptyInternalEnumerator<ClusteringData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246D160 Offset: 0x246D261 VA: 0x246D160
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246D380 Offset: 0x246D481 VA: 0x246D380
	|-Array.EmptyInternalEnumerator<Finger>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246D5B0 Offset: 0x246D6B1 VA: 0x246D5B0
	|-Array.EmptyInternalEnumerator<Hand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246D7D0 Offset: 0x246D8D1 VA: 0x246D7D0
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246D9E0 Offset: 0x246DAE1 VA: 0x246D9E0
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246DC00 Offset: 0x246DD01 VA: 0x246DC00
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246DE20 Offset: 0x246DF21 VA: 0x246DE20
	|-Array.EmptyInternalEnumerator<MomentStatistic>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246E030 Offset: 0x246E131 VA: 0x246E030
	|-Array.EmptyInternalEnumerator<Protrusion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246E240 Offset: 0x246E341 VA: 0x246E240
	|-Array.EmptyInternalEnumerator<Shape>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246E460 Offset: 0x246E561 VA: 0x246E460
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246E670 Offset: 0x246E771 VA: 0x246E670
	|-Array.EmptyInternalEnumerator<UserWord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246E880 Offset: 0x246E981 VA: 0x246E880
	|-Array.EmptyInternalEnumerator<Color4u8>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246EA90 Offset: 0x246EB91 VA: 0x246EA90
	|-Array.EmptyInternalEnumerator<Float2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x246ECA0 Offset: 0x246EDA1 VA: 0x246ECA0
	|-Array.EmptyInternalEnumerator<stCommand_t>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4CA0 Offset: 0x28A4DA1 VA: 0x28A4CA0
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A4EE0 Offset: 0x28A4FE1 VA: 0x28A4EE0
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A50F0 Offset: 0x28A51F1 VA: 0x28A50F0
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5300 Offset: 0x28A5401 VA: 0x28A5300
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5510 Offset: 0x28A5611 VA: 0x28A5510
	|-Array.EmptyInternalEnumerator<BitVector32Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5760 Offset: 0x28A5861 VA: 0x28A5760
	|-Array.EmptyInternalEnumerator<BuildItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5970 Offset: 0x28A5A71 VA: 0x28A5970
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5B80 Offset: 0x28A5C81 VA: 0x28A5B80
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5D90 Offset: 0x28A5E91 VA: 0x28A5D90
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A5FA0 Offset: 0x28A60A1 VA: 0x28A5FA0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A61C0 Offset: 0x28A62C1 VA: 0x28A61C0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A63E0 Offset: 0x28A64E1 VA: 0x28A63E0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A65F0 Offset: 0x28A66F1 VA: 0x28A65F0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A6800 Offset: 0x28A6901 VA: 0x28A6800
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A6A30 Offset: 0x28A6B31 VA: 0x28A6A30
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A6C40 Offset: 0x28A6D41 VA: 0x28A6C40
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A6E50 Offset: 0x28A6F51 VA: 0x28A6E50
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A7070 Offset: 0x28A7171 VA: 0x28A7070
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A7280 Offset: 0x28A7381 VA: 0x28A7280
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A7490 Offset: 0x28A7591 VA: 0x28A7490
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A76C0 Offset: 0x28A77C1 VA: 0x28A76C0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A78F0 Offset: 0x28A79F1 VA: 0x28A78F0
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A7B20 Offset: 0x28A7C21 VA: 0x28A7B20
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A7D40 Offset: 0x28A7E41 VA: 0x28A7D40
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A7F60 Offset: 0x28A8061 VA: 0x28A7F60
	|-Array.EmptyInternalEnumerator<CropDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A8180 Offset: 0x28A8281 VA: 0x28A8180
	|-Array.EmptyInternalEnumerator<ControlPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A83A0 Offset: 0x28A84A1 VA: 0x28A83A0
	|-Array.EmptyInternalEnumerator<DamageTextInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A85C0 Offset: 0x28A86C1 VA: 0x28A85C0
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A87D0 Offset: 0x28A88D1 VA: 0x28A87D0
	|-Array.EmptyInternalEnumerator<DropItemParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A89F0 Offset: 0x28A8AF1 VA: 0x28A89F0
	|-Array.EmptyInternalEnumerator<DropTableElement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A8C10 Offset: 0x28A8D11 VA: 0x28A8C10
	|-Array.EmptyInternalEnumerator<EffectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A8E20 Offset: 0x28A8F21 VA: 0x28A8E20
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9030 Offset: 0x28A9131 VA: 0x28A9030
	|-Array.EmptyInternalEnumerator<Coord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9250 Offset: 0x28A9351 VA: 0x28A9250
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9470 Offset: 0x28A9571 VA: 0x28A9470
	|-Array.EmptyInternalEnumerator<EventCheckId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9680 Offset: 0x28A9781 VA: 0x28A9680
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9890 Offset: 0x28A9991 VA: 0x28A9890
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9AD0 Offset: 0x28A9BD1 VA: 0x28A9AD0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9D00 Offset: 0x28A9E01 VA: 0x28A9D00
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28A9F20 Offset: 0x28AA021 VA: 0x28A9F20
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AA130 Offset: 0x28AA231 VA: 0x28AA130
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AA340 Offset: 0x28AA441 VA: 0x28AA340
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AA550 Offset: 0x28AA651 VA: 0x28AA550
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AA760 Offset: 0x28AA861 VA: 0x28AA760
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AA990 Offset: 0x28AAA91 VA: 0x28AA990
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AABB0 Offset: 0x28AACB1 VA: 0x28AABB0
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AADF0 Offset: 0x28AAEF1 VA: 0x28AADF0
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AB000 Offset: 0x28AB101 VA: 0x28AB000
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AB230 Offset: 0x28AB331 VA: 0x28AB230
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AB450 Offset: 0x28AB551 VA: 0x28AB450
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AB670 Offset: 0x28AB771 VA: 0x28AB670
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AB890 Offset: 0x28AB991 VA: 0x28AB890
	|-Array.EmptyInternalEnumerator<FurnitureData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ABAA0 Offset: 0x28ABBA1 VA: 0x28ABAA0
	|-Array.EmptyInternalEnumerator<GateDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ABCD0 Offset: 0x28ABDD1 VA: 0x28ABCD0
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ABEE0 Offset: 0x28ABFE1 VA: 0x28ABEE0
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AC110 Offset: 0x28AC211 VA: 0x28AC110
	|-Array.EmptyInternalEnumerator<HitResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AC330 Offset: 0x28AC431 VA: 0x28AC330
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AC550 Offset: 0x28AC651 VA: 0x28AC550
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AC760 Offset: 0x28AC861 VA: 0x28AC760
	|-Array.EmptyInternalEnumerator<ItemLevelData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AC980 Offset: 0x28ACA81 VA: 0x28AC980
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ACBB0 Offset: 0x28ACCB1 VA: 0x28ACBB0
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ACDC0 Offset: 0x28ACEC1 VA: 0x28ACDC0
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ACFF0 Offset: 0x28AD0F1 VA: 0x28ACFF0
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AD200 Offset: 0x28AD301 VA: 0x28AD200
	|-Array.EmptyInternalEnumerator<MiningDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AD430 Offset: 0x28AD531 VA: 0x28AD430
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AD650 Offset: 0x28AD751 VA: 0x28AD650
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AD870 Offset: 0x28AD971 VA: 0x28AD870
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ADA90 Offset: 0x28ADB91 VA: 0x28ADA90
	|-Array.EmptyInternalEnumerator<MonsterDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ADCB0 Offset: 0x28ADDB1 VA: 0x28ADCB0
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28ADEE0 Offset: 0x28ADFE1 VA: 0x28ADEE0
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AE110 Offset: 0x28AE211 VA: 0x28AE110
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AE340 Offset: 0x28AE441 VA: 0x28AE340
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AE550 Offset: 0x28AE651 VA: 0x28AE550
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AE760 Offset: 0x28AE861 VA: 0x28AE760
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AE990 Offset: 0x28AEA91 VA: 0x28AE990
	|-Array.EmptyInternalEnumerator<NPCActionData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AEBA0 Offset: 0x28AECA1 VA: 0x28AEBA0
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AEDB0 Offset: 0x28AEEB1 VA: 0x28AEDB0
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AEFD0 Offset: 0x28AF0D1 VA: 0x28AEFD0
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AF1E0 Offset: 0x28AF2E1 VA: 0x28AF1E0
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AF410 Offset: 0x28AF511 VA: 0x28AF410
	|-Array.EmptyInternalEnumerator<OrderSaveData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AF630 Offset: 0x28AF731 VA: 0x28AF630
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AF840 Offset: 0x28AF941 VA: 0x28AF840
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AFA60 Offset: 0x28AFB61 VA: 0x28AFA60
	|-Array.EmptyInternalEnumerator<Parameter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AFC70 Offset: 0x28AFD71 VA: 0x28AFC70
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28AFEA0 Offset: 0x28AFFA1 VA: 0x28AFEA0
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B00B0 Offset: 0x28B01B1 VA: 0x28B00B0
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B02E0 Offset: 0x28B03E1 VA: 0x28B02E0
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B04F0 Offset: 0x28B05F1 VA: 0x28B04F0
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B0700 Offset: 0x28B0801 VA: 0x28B0700
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B0910 Offset: 0x28B0A11 VA: 0x28B0910
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B0B40 Offset: 0x28B0C41 VA: 0x28B0B40
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B0D70 Offset: 0x28B0E71 VA: 0x28B0D70
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B0FA0 Offset: 0x28B10A1 VA: 0x28B0FA0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B11B0 Offset: 0x28B12B1 VA: 0x28B11B0
	|-Array.EmptyInternalEnumerator<ProfilerFrame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B13C0 Offset: 0x28B14C1 VA: 0x28B13C0
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B15E0 Offset: 0x28B16E1 VA: 0x28B15E0
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B1800 Offset: 0x28B1901 VA: 0x28B1800
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B1A10 Offset: 0x28B1B11 VA: 0x28B1A10
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B1C20 Offset: 0x28B1D21 VA: 0x28B1C20
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B1E40 Offset: 0x28B1F41 VA: 0x28B1E40
	|-Array.EmptyInternalEnumerator<Schedule>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B2050 Offset: 0x28B2151 VA: 0x28B2050
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B2260 Offset: 0x28B2361 VA: 0x28B2260
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28B2470 Offset: 0x28B2571 VA: 0x28B2470
	|-Array.EmptyInternalEnumerator<SpeedData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F2680 Offset: 0x26F2781 VA: 0x26F2680
	|-Array.EmptyInternalEnumerator<CurveSample>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F2890 Offset: 0x26F2991 VA: 0x26F2890
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F2AA0 Offset: 0x26F2BA1 VA: 0x26F2AA0
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F2CB0 Offset: 0x26F2DB1 VA: 0x26F2CB0
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F2EC0 Offset: 0x26F2FC1 VA: 0x26F2EC0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F30D0 Offset: 0x26F31D1 VA: 0x26F30D0
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F32E0 Offset: 0x26F33E1 VA: 0x26F32E0
	|-Array.EmptyInternalEnumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F34F0 Offset: 0x26F35F1 VA: 0x26F34F0
	|-Array.EmptyInternalEnumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F3700 Offset: 0x26F3801 VA: 0x26F3700
	|-Array.EmptyInternalEnumerator<ByteEnum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F3910 Offset: 0x26F3A11 VA: 0x26F3910
	|-Array.EmptyInternalEnumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F3B20 Offset: 0x26F3C21 VA: 0x26F3B20
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F3D30 Offset: 0x26F3E31 VA: 0x26F3D30
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F3F50 Offset: 0x26F4051 VA: 0x26F3F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F4170 Offset: 0x26F4271 VA: 0x26F4170
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F43A0 Offset: 0x26F44A1 VA: 0x26F43A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F45E0 Offset: 0x26F46E1 VA: 0x26F45E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F4810 Offset: 0x26F4911 VA: 0x26F4810
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F4A30 Offset: 0x26F4B31 VA: 0x26F4A30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F4C50 Offset: 0x26F4D51 VA: 0x26F4C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F4E80 Offset: 0x26F4F81 VA: 0x26F4E80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F50A0 Offset: 0x26F51A1 VA: 0x26F50A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F52D0 Offset: 0x26F53D1 VA: 0x26F52D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F5500 Offset: 0x26F5601 VA: 0x26F5500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F5720 Offset: 0x26F5821 VA: 0x26F5720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F5940 Offset: 0x26F5A41 VA: 0x26F5940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F5B60 Offset: 0x26F5C61 VA: 0x26F5B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F5D80 Offset: 0x26F5E81 VA: 0x26F5D80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F5FA0 Offset: 0x26F60A1 VA: 0x26F5FA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F61C0 Offset: 0x26F62C1 VA: 0x26F61C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F63E0 Offset: 0x26F64E1 VA: 0x26F63E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F6600 Offset: 0x26F6701 VA: 0x26F6600
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F6820 Offset: 0x26F6921 VA: 0x26F6820
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F6A40 Offset: 0x26F6B41 VA: 0x26F6A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F6C50 Offset: 0x26F6D51 VA: 0x26F6C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F6E90 Offset: 0x26F6F91 VA: 0x26F6E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F70B0 Offset: 0x26F71B1 VA: 0x26F70B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F72C0 Offset: 0x26F73C1 VA: 0x26F72C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F74D0 Offset: 0x26F75D1 VA: 0x26F74D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F76E0 Offset: 0x26F77E1 VA: 0x26F76E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F78F0 Offset: 0x26F79F1 VA: 0x26F78F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F7B10 Offset: 0x26F7C11 VA: 0x26F7B10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F7D30 Offset: 0x26F7E31 VA: 0x26F7D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F7F60 Offset: 0x26F8061 VA: 0x26F7F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F8180 Offset: 0x26F8281 VA: 0x26F8180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F83A0 Offset: 0x26F84A1 VA: 0x26F83A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F85C0 Offset: 0x26F86C1 VA: 0x26F85C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F87E0 Offset: 0x26F88E1 VA: 0x26F87E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F8A10 Offset: 0x26F8B11 VA: 0x26F8A10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F8C40 Offset: 0x26F8D41 VA: 0x26F8C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F8E50 Offset: 0x26F8F51 VA: 0x26F8E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F9070 Offset: 0x26F9171 VA: 0x26F9070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F9280 Offset: 0x26F9381 VA: 0x26F9280
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F9490 Offset: 0x26F9591 VA: 0x26F9490
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F96B0 Offset: 0x26F97B1 VA: 0x26F96B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F98C0 Offset: 0x26F99C1 VA: 0x26F98C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F9AE0 Offset: 0x26F9BE1 VA: 0x26F9AE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F9D00 Offset: 0x26F9E01 VA: 0x26F9D00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26F9F20 Offset: 0x26FA021 VA: 0x26F9F20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FA140 Offset: 0x26FA241 VA: 0x26FA140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FA360 Offset: 0x26FA461 VA: 0x26FA360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FA580 Offset: 0x26FA681 VA: 0x26FA580
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FA7B0 Offset: 0x26FA8B1 VA: 0x26FA7B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FA9E0 Offset: 0x26FAAE1 VA: 0x26FA9E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FAC00 Offset: 0x26FAD01 VA: 0x26FAC00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FAE30 Offset: 0x26FAF31 VA: 0x26FAE30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FB050 Offset: 0x26FB151 VA: 0x26FB050
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FB280 Offset: 0x26FB381 VA: 0x26FB280
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FB4B0 Offset: 0x26FB5B1 VA: 0x26FB4B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FB6D0 Offset: 0x26FB7D1 VA: 0x26FB6D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FB910 Offset: 0x26FBA11 VA: 0x26FB910
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FBB40 Offset: 0x26FBC41 VA: 0x26FBB40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FBD60 Offset: 0x26FBE61 VA: 0x26FBD60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FBF90 Offset: 0x26FC091 VA: 0x26FBF90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FC1C0 Offset: 0x26FC2C1 VA: 0x26FC1C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FC3E0 Offset: 0x26FC4E1 VA: 0x26FC3E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FC600 Offset: 0x26FC701 VA: 0x26FC600
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FC820 Offset: 0x26FC921 VA: 0x26FC820
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FCA40 Offset: 0x26FCB41 VA: 0x26FCA40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FCC70 Offset: 0x26FCD71 VA: 0x26FCC70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FCE90 Offset: 0x26FCF91 VA: 0x26FCE90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FD0C0 Offset: 0x26FD1C1 VA: 0x26FD0C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FD300 Offset: 0x26FD401 VA: 0x26FD300
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FD530 Offset: 0x26FD631 VA: 0x26FD530
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FD750 Offset: 0x26FD851 VA: 0x26FD750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FD970 Offset: 0x26FDA71 VA: 0x26FD970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FDBA0 Offset: 0x26FDCA1 VA: 0x26FDBA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FDDC0 Offset: 0x26FDEC1 VA: 0x26FDDC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FDFF0 Offset: 0x26FE0F1 VA: 0x26FDFF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FE220 Offset: 0x26FE321 VA: 0x26FE220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FE440 Offset: 0x26FE541 VA: 0x26FE440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FE660 Offset: 0x26FE761 VA: 0x26FE660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FE880 Offset: 0x26FE981 VA: 0x26FE880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FEAA0 Offset: 0x26FEBA1 VA: 0x26FEAA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FECC0 Offset: 0x26FEDC1 VA: 0x26FECC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FEEE0 Offset: 0x26FEFE1 VA: 0x26FEEE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FF100 Offset: 0x26FF201 VA: 0x26FF100
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FF320 Offset: 0x26FF421 VA: 0x26FF320
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FF540 Offset: 0x26FF641 VA: 0x26FF540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FF760 Offset: 0x26FF861 VA: 0x26FF760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FF980 Offset: 0x26FFA81 VA: 0x26FF980
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FFBA0 Offset: 0x26FFCA1 VA: 0x26FFBA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FFDC0 Offset: 0x26FFEC1 VA: 0x26FFDC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26FFFF0 Offset: 0x27000F1 VA: 0x26FFFF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700220 Offset: 0x2700321 VA: 0x2700220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700440 Offset: 0x2700541 VA: 0x2700440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700670 Offset: 0x2700771 VA: 0x2700670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700890 Offset: 0x2700991 VA: 0x2700890
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700AC0 Offset: 0x2700BC1 VA: 0x2700AC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700CF0 Offset: 0x2700DF1 VA: 0x2700CF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2700F10 Offset: 0x2701011 VA: 0x2700F10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2701150 Offset: 0x2701251 VA: 0x2701150
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2701380 Offset: 0x2701481 VA: 0x2701380
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27015A0 Offset: 0x27016A1 VA: 0x27015A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27017D0 Offset: 0x27018D1 VA: 0x27017D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2701A00 Offset: 0x2701B01 VA: 0x2701A00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2701C20 Offset: 0x2701D21 VA: 0x2701C20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2701E40 Offset: 0x2701F41 VA: 0x2701E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2702060 Offset: 0x2702161 VA: 0x2702060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2702280 Offset: 0x2702381 VA: 0x2702280
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27024B0 Offset: 0x27025B1 VA: 0x27024B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27026D0 Offset: 0x27027D1 VA: 0x27026D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27028F0 Offset: 0x27029F1 VA: 0x27028F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2702B10 Offset: 0x2702C11 VA: 0x2702B10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2702D30 Offset: 0x2702E31 VA: 0x2702D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2702F50 Offset: 0x2703051 VA: 0x2702F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2703170 Offset: 0x2703271 VA: 0x2703170
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2703390 Offset: 0x2703491 VA: 0x2703390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27035B0 Offset: 0x27036B1 VA: 0x27035B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27037E0 Offset: 0x27038E1 VA: 0x27037E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2703A10 Offset: 0x2703B11 VA: 0x2703A10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2703C40 Offset: 0x2703D41 VA: 0x2703C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2703E60 Offset: 0x2703F61 VA: 0x2703E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2704080 Offset: 0x2704181 VA: 0x2704080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27042A0 Offset: 0x27043A1 VA: 0x27042A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27044D0 Offset: 0x27045D1 VA: 0x27044D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2704700 Offset: 0x2704801 VA: 0x2704700
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2704920 Offset: 0x2704A21 VA: 0x2704920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2704B60 Offset: 0x2704C61 VA: 0x2704B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2704D80 Offset: 0x2704E81 VA: 0x2704D80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2704FA0 Offset: 0x27050A1 VA: 0x2704FA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27051C0 Offset: 0x27052C1 VA: 0x27051C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27053E0 Offset: 0x27054E1 VA: 0x27053E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2705600 Offset: 0x2705701 VA: 0x2705600
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2705830 Offset: 0x2705931 VA: 0x2705830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2705A60 Offset: 0x2705B61 VA: 0x2705A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2705C80 Offset: 0x2705D81 VA: 0x2705C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2705EA0 Offset: 0x2705FA1 VA: 0x2705EA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27060C0 Offset: 0x27061C1 VA: 0x27060C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27062E0 Offset: 0x27063E1 VA: 0x27062E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2706500 Offset: 0x2706601 VA: 0x2706500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2706720 Offset: 0x2706821 VA: 0x2706720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2706940 Offset: 0x2706A41 VA: 0x2706940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2706B60 Offset: 0x2706C61 VA: 0x2706B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2706DA0 Offset: 0x2706EA1 VA: 0x2706DA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2706FC0 Offset: 0x27070C1 VA: 0x2706FC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27071E0 Offset: 0x27072E1 VA: 0x27071E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27073F0 Offset: 0x27074F1 VA: 0x27073F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2707600 Offset: 0x2707701 VA: 0x2707600
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2707820 Offset: 0x2707921 VA: 0x2707820
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2707A40 Offset: 0x2707B41 VA: 0x2707A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2707C60 Offset: 0x2707D61 VA: 0x2707C60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2707E90 Offset: 0x2707F91 VA: 0x2707E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27080C0 Offset: 0x27081C1 VA: 0x27080C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27082F0 Offset: 0x27083F1 VA: 0x27082F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2708510 Offset: 0x2708611 VA: 0x2708510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2708730 Offset: 0x2708831 VA: 0x2708730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2708960 Offset: 0x2708A61 VA: 0x2708960
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2708B90 Offset: 0x2708C91 VA: 0x2708B90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2708DB0 Offset: 0x2708EB1 VA: 0x2708DB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2708FD0 Offset: 0x27090D1 VA: 0x2708FD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27091F0 Offset: 0x27092F1 VA: 0x27091F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2709410 Offset: 0x2709511 VA: 0x2709410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2709640 Offset: 0x2709741 VA: 0x2709640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2709870 Offset: 0x2709971 VA: 0x2709870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2709A90 Offset: 0x2709B91 VA: 0x2709A90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2709CD0 Offset: 0x2709DD1 VA: 0x2709CD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2709EF0 Offset: 0x2709FF1 VA: 0x2709EF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270A110 Offset: 0x270A211 VA: 0x270A110
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270A330 Offset: 0x270A431 VA: 0x270A330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270A550 Offset: 0x270A651 VA: 0x270A550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270A770 Offset: 0x270A871 VA: 0x270A770
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270A990 Offset: 0x270AA91 VA: 0x270A990
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270ABB0 Offset: 0x270ACB1 VA: 0x270ABB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270ADD0 Offset: 0x270AED1 VA: 0x270ADD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270AFF0 Offset: 0x270B0F1 VA: 0x270AFF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270B210 Offset: 0x270B311 VA: 0x270B210
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270B430 Offset: 0x270B531 VA: 0x270B430
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270B650 Offset: 0x270B751 VA: 0x270B650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x270B860 Offset: 0x270B961 VA: 0x270B860
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C6840 Offset: 0x28C6941 VA: 0x28C6840
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C6A50 Offset: 0x28C6B51 VA: 0x28C6A50
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C6C60 Offset: 0x28C6D61 VA: 0x28C6C60
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C6E70 Offset: 0x28C6F71 VA: 0x28C6E70
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C7090 Offset: 0x28C7191 VA: 0x28C7090
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C72B0 Offset: 0x28C73B1 VA: 0x28C72B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C74C0 Offset: 0x28C75C1 VA: 0x28C74C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C76E0 Offset: 0x28C77E1 VA: 0x28C76E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C7910 Offset: 0x28C7A11 VA: 0x28C7910
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C7B30 Offset: 0x28C7C31 VA: 0x28C7B30
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C7D50 Offset: 0x28C7E51 VA: 0x28C7D50
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C7F70 Offset: 0x28C8071 VA: 0x28C7F70
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C81A0 Offset: 0x28C82A1 VA: 0x28C81A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C83C0 Offset: 0x28C84C1 VA: 0x28C83C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C85F0 Offset: 0x28C86F1 VA: 0x28C85F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C8820 Offset: 0x28C8921 VA: 0x28C8820
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C8A40 Offset: 0x28C8B41 VA: 0x28C8A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C8C50 Offset: 0x28C8D51 VA: 0x28C8C50
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C8E60 Offset: 0x28C8F61 VA: 0x28C8E60
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C9070 Offset: 0x28C9171 VA: 0x28C9070
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C9280 Offset: 0x28C9381 VA: 0x28C9280
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C9490 Offset: 0x28C9591 VA: 0x28C9490
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C96B0 Offset: 0x28C97B1 VA: 0x28C96B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C98C0 Offset: 0x28C99C1 VA: 0x28C98C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C9AE0 Offset: 0x28C9BE1 VA: 0x28C9AE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C9D00 Offset: 0x28C9E01 VA: 0x28C9D00
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28C9F10 Offset: 0x28CA011 VA: 0x28C9F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CA150 Offset: 0x28CA251 VA: 0x28CA150
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CA370 Offset: 0x28CA471 VA: 0x28CA370
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CA580 Offset: 0x28CA681 VA: 0x28CA580
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CA790 Offset: 0x28CA891 VA: 0x28CA790
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CA9A0 Offset: 0x28CAAA1 VA: 0x28CA9A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CABB0 Offset: 0x28CACB1 VA: 0x28CABB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CADC0 Offset: 0x28CAEC1 VA: 0x28CADC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CAFD0 Offset: 0x28CB0D1 VA: 0x28CAFD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CB200 Offset: 0x28CB301 VA: 0x28CB200
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CB420 Offset: 0x28CB521 VA: 0x28CB420
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CB630 Offset: 0x28CB731 VA: 0x28CB630
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CB840 Offset: 0x28CB941 VA: 0x28CB840
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CBA60 Offset: 0x28CBB61 VA: 0x28CBA60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CBC90 Offset: 0x28CBD91 VA: 0x28CBC90
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CBEB0 Offset: 0x28CBFB1 VA: 0x28CBEB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CC0C0 Offset: 0x28CC1C1 VA: 0x28CC0C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CC2D0 Offset: 0x28CC3D1 VA: 0x28CC2D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CC4E0 Offset: 0x28CC5E1 VA: 0x28CC4E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CC6F0 Offset: 0x28CC7F1 VA: 0x28CC6F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CC900 Offset: 0x28CCA01 VA: 0x28CC900
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CCB10 Offset: 0x28CCC11 VA: 0x28CCB10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CCD30 Offset: 0x28CCE31 VA: 0x28CCD30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CCF40 Offset: 0x28CD041 VA: 0x28CCF40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CD150 Offset: 0x28CD251 VA: 0x28CD150
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CD360 Offset: 0x28CD461 VA: 0x28CD360
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CD580 Offset: 0x28CD681 VA: 0x28CD580
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CD790 Offset: 0x28CD891 VA: 0x28CD790
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CD9C0 Offset: 0x28CDAC1 VA: 0x28CD9C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CDBF0 Offset: 0x28CDCF1 VA: 0x28CDBF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CDE00 Offset: 0x28CDF01 VA: 0x28CDE00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CE020 Offset: 0x28CE121 VA: 0x28CE020
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CE240 Offset: 0x28CE341 VA: 0x28CE240
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CE460 Offset: 0x28CE561 VA: 0x28CE460
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CE690 Offset: 0x28CE791 VA: 0x28CE690
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CE8A0 Offset: 0x28CE9A1 VA: 0x28CE8A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CEAE0 Offset: 0x28CEBE1 VA: 0x28CEAE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CED00 Offset: 0x28CEE01 VA: 0x28CED00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CEF20 Offset: 0x28CF021 VA: 0x28CEF20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CF140 Offset: 0x28CF241 VA: 0x28CF140
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CF360 Offset: 0x28CF461 VA: 0x28CF360
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CF580 Offset: 0x28CF681 VA: 0x28CF580
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CF7A0 Offset: 0x28CF8A1 VA: 0x28CF7A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CF9C0 Offset: 0x28CFAC1 VA: 0x28CF9C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CFBE0 Offset: 0x28CFCE1 VA: 0x28CFBE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28CFE00 Offset: 0x28CFF01 VA: 0x28CFE00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0010 Offset: 0x28D0111 VA: 0x28D0010
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0230 Offset: 0x28D0331 VA: 0x28D0230
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0460 Offset: 0x28D0561 VA: 0x28D0460
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0680 Offset: 0x28D0781 VA: 0x28D0680
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D08A0 Offset: 0x28D09A1 VA: 0x28D08A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0AC0 Offset: 0x28D0BC1 VA: 0x28D0AC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0CF0 Offset: 0x28D0DF1 VA: 0x28D0CF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D0F10 Offset: 0x28D1011 VA: 0x28D0F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D1140 Offset: 0x28D1241 VA: 0x28D1140
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D1370 Offset: 0x28D1471 VA: 0x28D1370
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D1590 Offset: 0x28D1691 VA: 0x28D1590
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D17B0 Offset: 0x28D18B1 VA: 0x28D17B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D19C0 Offset: 0x28D1AC1 VA: 0x28D19C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D1BD0 Offset: 0x28D1CD1 VA: 0x28D1BD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D1DE0 Offset: 0x28D1EE1 VA: 0x28D1DE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D1FF0 Offset: 0x28D20F1 VA: 0x28D1FF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2200 Offset: 0x28D2301 VA: 0x28D2200
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2410 Offset: 0x28D2511 VA: 0x28D2410
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2620 Offset: 0x28D2721 VA: 0x28D2620
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2830 Offset: 0x28D2931 VA: 0x28D2830
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2A40 Offset: 0x28D2B41 VA: 0x28D2A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2C60 Offset: 0x28D2D61 VA: 0x28D2C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D2E70 Offset: 0x28D2F71 VA: 0x28D2E70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D30A0 Offset: 0x28D31A1 VA: 0x28D30A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D32D0 Offset: 0x28D33D1 VA: 0x28D32D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D34E0 Offset: 0x28D35E1 VA: 0x28D34E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D3700 Offset: 0x28D3801 VA: 0x28D3700
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D3920 Offset: 0x28D3A21 VA: 0x28D3920
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D3B40 Offset: 0x28D3C41 VA: 0x28D3B40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D3D70 Offset: 0x28D3E71 VA: 0x28D3D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D3F80 Offset: 0x28D4081 VA: 0x28D3F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D41C0 Offset: 0x28D42C1 VA: 0x28D41C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D43E0 Offset: 0x28D44E1 VA: 0x28D43E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D4600 Offset: 0x28D4701 VA: 0x28D4600
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D4820 Offset: 0x28D4921 VA: 0x28D4820
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D4A40 Offset: 0x28D4B41 VA: 0x28D4A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D4C60 Offset: 0x28D4D61 VA: 0x28D4C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D4E80 Offset: 0x28D4F81 VA: 0x28D4E80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D50A0 Offset: 0x28D51A1 VA: 0x28D50A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D52C0 Offset: 0x28D53C1 VA: 0x28D52C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D54E0 Offset: 0x28D55E1 VA: 0x28D54E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D56F0 Offset: 0x28D57F1 VA: 0x28D56F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D5910 Offset: 0x28D5A11 VA: 0x28D5910
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D5B30 Offset: 0x28D5C31 VA: 0x28D5B30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D5D40 Offset: 0x28D5E41 VA: 0x28D5D40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D5F50 Offset: 0x28D6051 VA: 0x28D5F50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D6160 Offset: 0x28D6261 VA: 0x28D6160
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D6370 Offset: 0x28D6471 VA: 0x28D6370
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D6580 Offset: 0x28D6681 VA: 0x28D6580
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D67B0 Offset: 0x28D68B1 VA: 0x28D67B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D69D0 Offset: 0x28D6AD1 VA: 0x28D69D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D6BF0 Offset: 0x28D6CF1 VA: 0x28D6BF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D6E00 Offset: 0x28D6F01 VA: 0x28D6E00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7020 Offset: 0x28D7121 VA: 0x28D7020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7230 Offset: 0x28D7331 VA: 0x28D7230
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7450 Offset: 0x28D7551 VA: 0x28D7450
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7680 Offset: 0x28D7781 VA: 0x28D7680
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7890 Offset: 0x28D7991 VA: 0x28D7890
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7AD0 Offset: 0x28D7BD1 VA: 0x28D7AD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7CF0 Offset: 0x28D7DF1 VA: 0x28D7CF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D7F10 Offset: 0x28D8011 VA: 0x28D7F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8120 Offset: 0x28D8221 VA: 0x28D8120
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8340 Offset: 0x28D8441 VA: 0x28D8340
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8560 Offset: 0x28D8661 VA: 0x28D8560
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8780 Offset: 0x28D8881 VA: 0x28D8780
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D89A0 Offset: 0x28D8AA1 VA: 0x28D89A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8BB0 Offset: 0x28D8CB1 VA: 0x28D8BB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8DC0 Offset: 0x28D8EC1 VA: 0x28D8DC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D8FE0 Offset: 0x28D90E1 VA: 0x28D8FE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9200 Offset: 0x28D9301 VA: 0x28D9200
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9420 Offset: 0x28D9521 VA: 0x28D9420
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9640 Offset: 0x28D9741 VA: 0x28D9640
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9850 Offset: 0x28D9951 VA: 0x28D9850
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9A60 Offset: 0x28D9B61 VA: 0x28D9A60
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9CA0 Offset: 0x28D9DA1 VA: 0x28D9CA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28D9EB0 Offset: 0x28D9FB1 VA: 0x28D9EB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DA0C0 Offset: 0x28DA1C1 VA: 0x28DA0C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DA2D0 Offset: 0x28DA3D1 VA: 0x28DA2D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DA4E0 Offset: 0x28DA5E1 VA: 0x28DA4E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DA6F0 Offset: 0x28DA7F1 VA: 0x28DA6F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DA900 Offset: 0x28DAA01 VA: 0x28DA900
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DAB10 Offset: 0x28DAC11 VA: 0x28DAB10
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DAD40 Offset: 0x28DAE41 VA: 0x28DAD40
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DAF70 Offset: 0x28DB071 VA: 0x28DAF70
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DB1A0 Offset: 0x28DB2A1 VA: 0x28DB1A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DB3B0 Offset: 0x28DB4B1 VA: 0x28DB3B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DB5C0 Offset: 0x28DB6C1 VA: 0x28DB5C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DB7E0 Offset: 0x28DB8E1 VA: 0x28DB7E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DBA00 Offset: 0x28DBB01 VA: 0x28DBA00
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DBC20 Offset: 0x28DBD21 VA: 0x28DBC20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DBE30 Offset: 0x28DBF31 VA: 0x28DBE30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DC040 Offset: 0x28DC141 VA: 0x28DC040
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DC250 Offset: 0x28DC351 VA: 0x28DC250
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DC470 Offset: 0x28DC571 VA: 0x28DC470
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DC6A0 Offset: 0x28DC7A1 VA: 0x28DC6A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DC8B0 Offset: 0x28DC9B1 VA: 0x28DC8B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DCAF0 Offset: 0x28DCBF1 VA: 0x28DCAF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DCD10 Offset: 0x28DCE11 VA: 0x28DCD10
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DCF30 Offset: 0x28DD031 VA: 0x28DCF30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DD140 Offset: 0x28DD241 VA: 0x28DD140
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DD360 Offset: 0x28DD461 VA: 0x28DD360
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DD580 Offset: 0x28DD681 VA: 0x28DD580
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DD790 Offset: 0x28DD891 VA: 0x28DD790
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DD9A0 Offset: 0x28DDAA1 VA: 0x28DD9A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DDBB0 Offset: 0x28DDCB1 VA: 0x28DDBB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DDDC0 Offset: 0x28DDEC1 VA: 0x28DDDC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DDFE0 Offset: 0x28DE0E1 VA: 0x28DDFE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DE200 Offset: 0x28DE301 VA: 0x28DE200
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DE420 Offset: 0x28DE521 VA: 0x28DE420
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DE640 Offset: 0x28DE741 VA: 0x28DE640
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DE850 Offset: 0x28DE951 VA: 0x28DE850
	|-Array.EmptyInternalEnumerator<DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DEA60 Offset: 0x28DEB61 VA: 0x28DEA60
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DEC70 Offset: 0x28DED71 VA: 0x28DEC70
	|-Array.EmptyInternalEnumerator<Decimal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DEE80 Offset: 0x28DEF81 VA: 0x28DEE80
	|-Array.EmptyInternalEnumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DF090 Offset: 0x28DF191 VA: 0x28DF090
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28DF2A0 Offset: 0x28DF3A1 VA: 0x28DF2A0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273E8E0 Offset: 0x273E9E1 VA: 0x273E8E0
	|-Array.EmptyInternalEnumerator<Guid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273EAF0 Offset: 0x273EBF1 VA: 0x273EAF0
	|-Array.EmptyInternalEnumerator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273ED00 Offset: 0x273EE01 VA: 0x273ED00
	|-Array.EmptyInternalEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273EF10 Offset: 0x273F011 VA: 0x273EF10
	|-Array.EmptyInternalEnumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273F120 Offset: 0x273F221 VA: 0x273F120
	|-Array.EmptyInternalEnumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273F330 Offset: 0x273F431 VA: 0x273F330
	|-Array.EmptyInternalEnumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273F540 Offset: 0x273F641 VA: 0x273F540
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273F750 Offset: 0x273F851 VA: 0x273F750
	|-Array.EmptyInternalEnumerator<LocalDefinition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273F960 Offset: 0x273FA61 VA: 0x273F960
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273FB70 Offset: 0x273FC71 VA: 0x273FB70
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273FD90 Offset: 0x273FE91 VA: 0x273FD90
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x273FFA0 Offset: 0x27400A1 VA: 0x273FFA0
	|-Array.EmptyInternalEnumerator<Memory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27401B0 Offset: 0x27402B1 VA: 0x27401B0
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27403C0 Offset: 0x27404C1 VA: 0x27403C0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27405D0 Offset: 0x27406D1 VA: 0x27405D0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2740800 Offset: 0x2740901 VA: 0x2740800
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2740A10 Offset: 0x2740B11 VA: 0x2740A10
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2740C40 Offset: 0x2740D41 VA: 0x2740C40
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2740E70 Offset: 0x2740F71 VA: 0x2740E70
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2741080 Offset: 0x2741181 VA: 0x2741080
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27412A0 Offset: 0x27413A1 VA: 0x27412A0
	|-Array.EmptyInternalEnumerator<Nullable<Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27414B0 Offset: 0x27415B1 VA: 0x27414B0
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27416D0 Offset: 0x27417D1 VA: 0x27416D0
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27418F0 Offset: 0x27419F1 VA: 0x27418F0
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2741B00 Offset: 0x2741C01 VA: 0x2741B00
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2741D40 Offset: 0x2741E41 VA: 0x2741D40
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2741F60 Offset: 0x2742061 VA: 0x2741F60
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2742170 Offset: 0x2742271 VA: 0x2742170
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2742390 Offset: 0x2742491 VA: 0x2742390
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27425B0 Offset: 0x27426B1 VA: 0x27425B0
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27427C0 Offset: 0x27428C1 VA: 0x27427C0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27429D0 Offset: 0x2742AD1 VA: 0x27429D0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2742BE0 Offset: 0x2742CE1 VA: 0x2742BE0
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2742DF0 Offset: 0x2742EF1 VA: 0x2742DF0
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2743010 Offset: 0x2743111 VA: 0x2743010
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27431E0 Offset: 0x27432E1 VA: 0x27431E0
	|-Array.EmptyInternalEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27433F0 Offset: 0x27434F1 VA: 0x27433F0
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2743600 Offset: 0x2743701 VA: 0x2743600
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2743820 Offset: 0x2743921 VA: 0x2743820
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2743A30 Offset: 0x2743B31 VA: 0x2743A30
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2743C40 Offset: 0x2743D41 VA: 0x2743C40
	|-Array.EmptyInternalEnumerator<Label>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2743E50 Offset: 0x2743F51 VA: 0x2743E50
	|-Array.EmptyInternalEnumerator<ParameterModifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744060 Offset: 0x2744161 VA: 0x2744060
	|-Array.EmptyInternalEnumerator<ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744270 Offset: 0x2744371 VA: 0x2744270
	|-Array.EmptyInternalEnumerator<Ephemeron>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744480 Offset: 0x2744581 VA: 0x2744480
	|-Array.EmptyInternalEnumerator<GCHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744690 Offset: 0x2744791 VA: 0x2744690
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27448A0 Offset: 0x27449A1 VA: 0x27448A0
	|-Array.EmptyInternalEnumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744AB0 Offset: 0x2744BB1 VA: 0x2744AB0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744CC0 Offset: 0x2744DC1 VA: 0x2744CC0
	|-Array.EmptyInternalEnumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2744ED0 Offset: 0x2744FD1 VA: 0x2744ED0
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27450F0 Offset: 0x27451F1 VA: 0x27450F0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745300 Offset: 0x2745401 VA: 0x2745300
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745510 Offset: 0x2745611 VA: 0x2745510
	|-Array.EmptyInternalEnumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745720 Offset: 0x2745821 VA: 0x2745720
	|-Array.EmptyInternalEnumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745930 Offset: 0x2745A31 VA: 0x2745930
	|-Array.EmptyInternalEnumerator<UInt16Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745B40 Offset: 0x2745C41 VA: 0x2745B40
	|-Array.EmptyInternalEnumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745D50 Offset: 0x2745E51 VA: 0x2745D50
	|-Array.EmptyInternalEnumerator<UInt32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2745F60 Offset: 0x2746061 VA: 0x2745F60
	|-Array.EmptyInternalEnumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2746170 Offset: 0x2746271 VA: 0x2746170
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2746380 Offset: 0x2746481 VA: 0x2746380
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2746590 Offset: 0x2746691 VA: 0x2746590
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27467A0 Offset: 0x27468A1 VA: 0x27467A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27469B0 Offset: 0x2746AB1 VA: 0x27469B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2746BC0 Offset: 0x2746CC1 VA: 0x2746BC0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2746DD0 Offset: 0x2746ED1 VA: 0x2746DD0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2746FE0 Offset: 0x27470E1 VA: 0x2746FE0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747210 Offset: 0x2747311 VA: 0x2747210
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747420 Offset: 0x2747521 VA: 0x2747420
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747640 Offset: 0x2747741 VA: 0x2747640
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747860 Offset: 0x2747961 VA: 0x2747860
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747A90 Offset: 0x2747B91 VA: 0x2747A90
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747CB0 Offset: 0x2747DB1 VA: 0x2747CB0
	|-Array.EmptyInternalEnumerator<HighlightState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2747EE0 Offset: 0x2747FE1 VA: 0x2747EE0
	|-Array.EmptyInternalEnumerator<MaterialReference>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2748100 Offset: 0x2748201 VA: 0x2748100
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2748330 Offset: 0x2748431 VA: 0x2748330
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2748550 Offset: 0x2748651 VA: 0x2748550
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2748760 Offset: 0x2748861 VA: 0x2748760
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27489B0 Offset: 0x2748AB1 VA: 0x27489B0
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2748BE0 Offset: 0x2748CE1 VA: 0x2748BE0
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2748E20 Offset: 0x2748F21 VA: 0x2748E20
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749040 Offset: 0x2749141 VA: 0x2749040
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749250 Offset: 0x2749351 VA: 0x2749250
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749470 Offset: 0x2749571 VA: 0x2749470
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749690 Offset: 0x2749791 VA: 0x2749690
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27498B0 Offset: 0x27499B1 VA: 0x27498B0
	|-Array.EmptyInternalEnumerator<WordWrapState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749AE0 Offset: 0x2749BE1 VA: 0x2749AE0
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749D00 Offset: 0x2749E01 VA: 0x2749D00
	|-Array.EmptyInternalEnumerator<TransitionTables>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2749F10 Offset: 0x274A011 VA: 0x2749F10
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274A120 Offset: 0x274A221 VA: 0x274A120
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274A330 Offset: 0x274A431 VA: 0x274A330
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274A560 Offset: 0x274A661 VA: 0x274A560
	|-Array.EmptyInternalEnumerator<CapEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274A780 Offset: 0x274A881 VA: 0x274A780
	|-Array.EmptyInternalEnumerator<ClippedEdge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274A990 Offset: 0x274AA91 VA: 0x274A990
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274ABA0 Offset: 0x274ACA1 VA: 0x274ABA0
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274ADB0 Offset: 0x274AEB1 VA: 0x274ADB0
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274AFD0 Offset: 0x274B0D1 VA: 0x274AFD0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274B200 Offset: 0x274B301 VA: 0x274B200
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274B410 Offset: 0x274B511 VA: 0x274B410
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274B660 Offset: 0x274B761 VA: 0x274B660
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274B870 Offset: 0x274B971 VA: 0x274B870
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274BA80 Offset: 0x274BB81 VA: 0x274BA80
	|-Array.EmptyInternalEnumerator<ConstraintSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274BC90 Offset: 0x274BD91 VA: 0x274BC90
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274BEA0 Offset: 0x274BFA1 VA: 0x274BEA0
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274C0B0 Offset: 0x274C1B1 VA: 0x274C0B0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274C2C0 Offset: 0x274C3C1 VA: 0x274C2C0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274C4D0 Offset: 0x274C5D1 VA: 0x274C4D0
	|-Array.EmptyInternalEnumerator<BoneWeight1>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274C6F0 Offset: 0x274C7F1 VA: 0x274C6F0
	|-Array.EmptyInternalEnumerator<BoneWeight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274C900 Offset: 0x274CA01 VA: 0x274C900
	|-Array.EmptyInternalEnumerator<BoundingSphere>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274CB20 Offset: 0x274CC21 VA: 0x274CB20
	|-Array.EmptyInternalEnumerator<Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274CD40 Offset: 0x274CE41 VA: 0x274CD40
	|-Array.EmptyInternalEnumerator<BoundsInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274CF70 Offset: 0x274D071 VA: 0x274CF70
	|-Array.EmptyInternalEnumerator<CharacterInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274D180 Offset: 0x274D281 VA: 0x274D180
	|-Array.EmptyInternalEnumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274D390 Offset: 0x274D491 VA: 0x274D390
	|-Array.EmptyInternalEnumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274D5E0 Offset: 0x274D6E1 VA: 0x274D5E0
	|-Array.EmptyInternalEnumerator<CombineInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274D810 Offset: 0x274D911 VA: 0x274D810
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274DA40 Offset: 0x274DB41 VA: 0x274DA40
	|-Array.EmptyInternalEnumerator<ContactPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274DC80 Offset: 0x274DD81 VA: 0x274DC80
	|-Array.EmptyInternalEnumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274DEC0 Offset: 0x274DFC1 VA: 0x274DEC0
	|-Array.EmptyInternalEnumerator<LightDataGI>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274E0D0 Offset: 0x274E1D1 VA: 0x274E0D0
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274E2E0 Offset: 0x274E3E1 VA: 0x274E2E0
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274E500 Offset: 0x274E601 VA: 0x274E500
	|-Array.EmptyInternalEnumerator<GradientColorKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274E730 Offset: 0x274E831 VA: 0x274E730
	|-Array.EmptyInternalEnumerator<HumanBone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274E960 Offset: 0x274EA61 VA: 0x274E960
	|-Array.EmptyInternalEnumerator<Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274EB70 Offset: 0x274EC71 VA: 0x274EB70
	|-Array.EmptyInternalEnumerator<LOD>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274ED80 Offset: 0x274EE81 VA: 0x274ED80
	|-Array.EmptyInternalEnumerator<LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274EFB0 Offset: 0x274F0B1 VA: 0x274EFB0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274F1E0 Offset: 0x274F2E1 VA: 0x274F1E0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274F400 Offset: 0x274F501 VA: 0x274F400
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274F610 Offset: 0x274F711 VA: 0x274F610
	|-Array.EmptyInternalEnumerator<PatchExtents>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274F820 Offset: 0x274F921 VA: 0x274F820
	|-Array.EmptyInternalEnumerator<Plane>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274FA30 Offset: 0x274FB31 VA: 0x274FA30
	|-Array.EmptyInternalEnumerator<Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274FC50 Offset: 0x274FD51 VA: 0x274FC50
	|-Array.EmptyInternalEnumerator<PlayableBinding>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x274FE60 Offset: 0x274FF61 VA: 0x274FE60
	|-Array.EmptyInternalEnumerator<PlayableGraph>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2750070 Offset: 0x2750171 VA: 0x2750070
	|-Array.EmptyInternalEnumerator<Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2750280 Offset: 0x2750381 VA: 0x2750280
	|-Array.EmptyInternalEnumerator<IntVec3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2750490 Offset: 0x2750591 VA: 0x2750490
	|-Array.EmptyInternalEnumerator<Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27506A0 Offset: 0x27507A1 VA: 0x27506A0
	|-Array.EmptyInternalEnumerator<RangeInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27508D0 Offset: 0x27509D1 VA: 0x27508D0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2750B00 Offset: 0x2750C01 VA: 0x2750B00
	|-Array.EmptyInternalEnumerator<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2750D10 Offset: 0x2750E11 VA: 0x2750D10
	|-Array.EmptyInternalEnumerator<Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2750F20 Offset: 0x2751021 VA: 0x2750F20
	|-Array.EmptyInternalEnumerator<RectInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2751130 Offset: 0x2751231 VA: 0x2751130
	|-Array.EmptyInternalEnumerator<RenderBuffer>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2751340 Offset: 0x2751441 VA: 0x2751340
	|-Array.EmptyInternalEnumerator<BatchVisibility>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2751550 Offset: 0x2751651 VA: 0x2751550
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27517A0 Offset: 0x27518A1 VA: 0x27517A0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27519B0 Offset: 0x2751AB1 VA: 0x27519B0
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2751BD0 Offset: 0x2751CD1 VA: 0x2751BD0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2751DF0 Offset: 0x2751EF1 VA: 0x2751DF0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752010 Offset: 0x2752111 VA: 0x2752010
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752240 Offset: 0x2752341 VA: 0x2752240
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752450 Offset: 0x2752551 VA: 0x2752450
	|-Array.EmptyInternalEnumerator<SceneInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752670 Offset: 0x2752771 VA: 0x2752670
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27528A0 Offset: 0x27529A1 VA: 0x27528A0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752AC0 Offset: 0x2752BC1 VA: 0x2752AC0
	|-Array.EmptyInternalEnumerator<SerializedType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752CD0 Offset: 0x2752DD1 VA: 0x2752CD0
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2752F00 Offset: 0x2753001 VA: 0x2752F00
	|-Array.EmptyInternalEnumerator<SkeletonBone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2753110 Offset: 0x2753211 VA: 0x2753110
	|-Array.EmptyInternalEnumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2753340 Offset: 0x2753441 VA: 0x2753340
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2753570 Offset: 0x2753671 VA: 0x2753570
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27537A0 Offset: 0x27538A1 VA: 0x27537A0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27539C0 Offset: 0x2753AC1 VA: 0x27539C0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2753BE0 Offset: 0x2753CE1 VA: 0x2753BE0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2753E00 Offset: 0x2753F01 VA: 0x2753E00
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2754040 Offset: 0x2754141 VA: 0x2754040
	|-Array.EmptyInternalEnumerator<Touch>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2754270 Offset: 0x2754371 VA: 0x2754270
	|-Array.EmptyInternalEnumerator<TreeInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27544B0 Offset: 0x27545B1 VA: 0x27544B0
	|-Array.EmptyInternalEnumerator<ColorBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27546E0 Offset: 0x27547E1 VA: 0x27546E0
	|-Array.EmptyInternalEnumerator<Navigation>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2754900 Offset: 0x2754A01 VA: 0x2754900
	|-Array.EmptyInternalEnumerator<SpriteState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2754B10 Offset: 0x2754C11 VA: 0x2754B10
	|-Array.EmptyInternalEnumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2754D20 Offset: 0x2754E21 VA: 0x2754D20
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2754F30 Offset: 0x2755031 VA: 0x2754F30
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2755140 Offset: 0x2755241 VA: 0x2755140
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2755350 Offset: 0x2755451 VA: 0x2755350
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2755570 Offset: 0x2755671 VA: 0x2755570
	|-Array.EmptyInternalEnumerator<StyleValue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2755780 Offset: 0x2755881 VA: 0x2755780
	|-Array.EmptyInternalEnumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27559C0 Offset: 0x2755AC1 VA: 0x27559C0
	|-Array.EmptyInternalEnumerator<UIVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2755BE0 Offset: 0x2755CE1 VA: 0x2755BE0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2755DF0 Offset: 0x2755EF1 VA: 0x2755DF0
	|-Array.EmptyInternalEnumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756000 Offset: 0x2756101 VA: 0x2756000
	|-Array.EmptyInternalEnumerator<Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756210 Offset: 0x2756311 VA: 0x2756210
	|-Array.EmptyInternalEnumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756420 Offset: 0x2756521 VA: 0x2756420
	|-Array.EmptyInternalEnumerator<Vector3Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756630 Offset: 0x2756731 VA: 0x2756630
	|-Array.EmptyInternalEnumerator<Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756840 Offset: 0x2756941 VA: 0x2756840
	|-Array.EmptyInternalEnumerator<jvalue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756A90 Offset: 0x2756B91 VA: 0x2756A90
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756CA0 Offset: 0x2756DA1 VA: 0x2756CA0
	|-Array.EmptyInternalEnumerator<YieldItemParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2756EB0 Offset: 0x2756FB1 VA: 0x2756EB0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27570C0 Offset: 0x27571C1 VA: 0x27570C0
	|-Array.EmptyInternalEnumerator<Uid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27572D0 Offset: 0x27573D1 VA: 0x27572D0
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27574E0 Offset: 0x27575E1 VA: 0x27574E0
	|-Array.EmptyInternalEnumerator<NsUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2757700 Offset: 0x2757801 VA: 0x2757700
	|-Array.EmptyInternalEnumerator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2757920 Offset: 0x2757A21 VA: 0x2757920
	|-Array.EmptyInternalEnumerator<Profile>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2757B40 Offset: 0x2757C41 VA: 0x2757B40
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2757D60 Offset: 0x2757E61 VA: 0x2757D60
	|-Array.EmptyInternalEnumerator<DebugPadState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2757F70 Offset: 0x2758071 VA: 0x2757F70
	|-Array.EmptyInternalEnumerator<GesturePoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27581B0 Offset: 0x27582B1 VA: 0x27581B0
	|-Array.EmptyInternalEnumerator<GestureState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x27583E0 Offset: 0x27584E1 VA: 0x27583E0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2758610 Offset: 0x2758711 VA: 0x2758610
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2758840 Offset: 0x2758941 VA: 0x2758840
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2758A70 Offset: 0x2758B71 VA: 0x2758A70
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2758CA0 Offset: 0x2758DA1 VA: 0x2758CA0
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2758ED0 Offset: 0x2758FD1 VA: 0x2758ED0
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246A0D0 Offset: 0x246A1D1 VA: 0x246A0D0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246A310 Offset: 0x246A411 VA: 0x246A310
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246A530 Offset: 0x246A631 VA: 0x246A530
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246A750 Offset: 0x246A851 VA: 0x246A750
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246A970 Offset: 0x246AA71 VA: 0x246A970
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246AB90 Offset: 0x246AC91 VA: 0x246AB90
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246ADB0 Offset: 0x246AEB1 VA: 0x246ADB0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246AFD0 Offset: 0x246B0D1 VA: 0x246AFD0
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246B1F0 Offset: 0x246B2F1 VA: 0x246B1F0
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246B420 Offset: 0x246B521 VA: 0x246B420
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246B660 Offset: 0x246B761 VA: 0x246B660
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246B880 Offset: 0x246B981 VA: 0x246B880
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246BAA0 Offset: 0x246BBA1 VA: 0x246BAA0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246BCC0 Offset: 0x246BDC1 VA: 0x246BCC0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246BEE0 Offset: 0x246BFE1 VA: 0x246BEE0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246C100 Offset: 0x246C201 VA: 0x246C100
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246C320 Offset: 0x246C421 VA: 0x246C320
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246C540 Offset: 0x246C641 VA: 0x246C540
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246C770 Offset: 0x246C871 VA: 0x246C770
	|-Array.EmptyInternalEnumerator<TouchState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246C980 Offset: 0x246CA81 VA: 0x246C980
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246CB90 Offset: 0x246CC91 VA: 0x246CB90
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246CDA0 Offset: 0x246CEA1 VA: 0x246CDA0
	|-Array.EmptyInternalEnumerator<VibrationValue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246CFC0 Offset: 0x246D0C1 VA: 0x246CFC0
	|-Array.EmptyInternalEnumerator<ClusteringData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246D1E0 Offset: 0x246D2E1 VA: 0x246D1E0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246D410 Offset: 0x246D511 VA: 0x246D410
	|-Array.EmptyInternalEnumerator<Finger>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246D630 Offset: 0x246D731 VA: 0x246D630
	|-Array.EmptyInternalEnumerator<Hand>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246D840 Offset: 0x246D941 VA: 0x246D840
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246DA60 Offset: 0x246DB61 VA: 0x246DA60
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246DC80 Offset: 0x246DD81 VA: 0x246DC80
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246DE90 Offset: 0x246DF91 VA: 0x246DE90
	|-Array.EmptyInternalEnumerator<MomentStatistic>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246E0A0 Offset: 0x246E1A1 VA: 0x246E0A0
	|-Array.EmptyInternalEnumerator<Protrusion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246E2C0 Offset: 0x246E3C1 VA: 0x246E2C0
	|-Array.EmptyInternalEnumerator<Shape>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246E4D0 Offset: 0x246E5D1 VA: 0x246E4D0
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246E6E0 Offset: 0x246E7E1 VA: 0x246E6E0
	|-Array.EmptyInternalEnumerator<UserWord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246E8F0 Offset: 0x246E9F1 VA: 0x246E8F0
	|-Array.EmptyInternalEnumerator<Color4u8>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246EB00 Offset: 0x246EC01 VA: 0x246EB00
	|-Array.EmptyInternalEnumerator<Float2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x246ED20 Offset: 0x246EE21 VA: 0x246ED20
	|-Array.EmptyInternalEnumerator<stCommand_t>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4CB0 Offset: 0x28A4DB1 VA: 0x28A4CB0
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x28A4EF0 Offset: 0x28A4FF1 VA: 0x28A4EF0
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>..ctor
	|
	|-RVA: 0x28A5100 Offset: 0x28A5201 VA: 0x28A5100
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>..ctor
	|
	|-RVA: 0x28A5310 Offset: 0x28A5411 VA: 0x28A5310
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>..ctor
	|
	|-RVA: 0x28A5520 Offset: 0x28A5621 VA: 0x28A5520
	|-Array.EmptyInternalEnumerator<BitVector32Int>..ctor
	|
	|-RVA: 0x28A5770 Offset: 0x28A5871 VA: 0x28A5770
	|-Array.EmptyInternalEnumerator<BuildItemData>..ctor
	|
	|-RVA: 0x28A5980 Offset: 0x28A5A81 VA: 0x28A5980
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x28A5B90 Offset: 0x28A5C91 VA: 0x28A5B90
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x28A5DA0 Offset: 0x28A5EA1 VA: 0x28A5DA0
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x28A5FB0 Offset: 0x28A60B1 VA: 0x28A5FB0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x28A61D0 Offset: 0x28A62D1 VA: 0x28A61D0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>..ctor
	|
	|-RVA: 0x28A63F0 Offset: 0x28A64F1 VA: 0x28A63F0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>..ctor
	|
	|-RVA: 0x28A6600 Offset: 0x28A6701 VA: 0x28A6600
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x28A6810 Offset: 0x28A6911 VA: 0x28A6810
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>..ctor
	|
	|-RVA: 0x28A6A40 Offset: 0x28A6B41 VA: 0x28A6A40
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>..ctor
	|
	|-RVA: 0x28A6C50 Offset: 0x28A6D51 VA: 0x28A6C50
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>..ctor
	|
	|-RVA: 0x28A6E60 Offset: 0x28A6F61 VA: 0x28A6E60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x28A7080 Offset: 0x28A7181 VA: 0x28A7080
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>..ctor
	|
	|-RVA: 0x28A7290 Offset: 0x28A7391 VA: 0x28A7290
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>..ctor
	|
	|-RVA: 0x28A74A0 Offset: 0x28A75A1 VA: 0x28A74A0
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>..ctor
	|
	|-RVA: 0x28A76D0 Offset: 0x28A77D1 VA: 0x28A76D0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>..ctor
	|
	|-RVA: 0x28A7900 Offset: 0x28A7A01 VA: 0x28A7900
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x28A7B30 Offset: 0x28A7C31 VA: 0x28A7B30
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x28A7D50 Offset: 0x28A7E51 VA: 0x28A7D50
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>..ctor
	|
	|-RVA: 0x28A7F70 Offset: 0x28A8071 VA: 0x28A7F70
	|-Array.EmptyInternalEnumerator<CropDataTable>..ctor
	|
	|-RVA: 0x28A8190 Offset: 0x28A8291 VA: 0x28A8190
	|-Array.EmptyInternalEnumerator<ControlPoint>..ctor
	|
	|-RVA: 0x28A83B0 Offset: 0x28A84B1 VA: 0x28A83B0
	|-Array.EmptyInternalEnumerator<DamageTextInfo>..ctor
	|
	|-RVA: 0x28A85D0 Offset: 0x28A86D1 VA: 0x28A85D0
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>..ctor
	|
	|-RVA: 0x28A87E0 Offset: 0x28A88E1 VA: 0x28A87E0
	|-Array.EmptyInternalEnumerator<DropItemParam>..ctor
	|
	|-RVA: 0x28A8A00 Offset: 0x28A8B01 VA: 0x28A8A00
	|-Array.EmptyInternalEnumerator<DropTableElement>..ctor
	|
	|-RVA: 0x28A8C20 Offset: 0x28A8D21 VA: 0x28A8C20
	|-Array.EmptyInternalEnumerator<EffectDataTable>..ctor
	|
	|-RVA: 0x28A8E30 Offset: 0x28A8F31 VA: 0x28A8E30
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>..ctor
	|
	|-RVA: 0x28A9040 Offset: 0x28A9141 VA: 0x28A9040
	|-Array.EmptyInternalEnumerator<Coord>..ctor
	|
	|-RVA: 0x28A9260 Offset: 0x28A9361 VA: 0x28A9260
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x28A9480 Offset: 0x28A9581 VA: 0x28A9480
	|-Array.EmptyInternalEnumerator<EventCheckId>..ctor
	|
	|-RVA: 0x28A9690 Offset: 0x28A9791 VA: 0x28A9690
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>..ctor
	|
	|-RVA: 0x28A98A0 Offset: 0x28A99A1 VA: 0x28A98A0
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>..ctor
	|
	|-RVA: 0x28A9AE0 Offset: 0x28A9BE1 VA: 0x28A9AE0
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>..ctor
	|
	|-RVA: 0x28A9D10 Offset: 0x28A9E11 VA: 0x28A9D10
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x28A9F30 Offset: 0x28AA031 VA: 0x28A9F30
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x28AA140 Offset: 0x28AA241 VA: 0x28AA140
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x28AA350 Offset: 0x28AA451 VA: 0x28AA350
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x28AA560 Offset: 0x28AA661 VA: 0x28AA560
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>..ctor
	|
	|-RVA: 0x28AA770 Offset: 0x28AA871 VA: 0x28AA770
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>..ctor
	|
	|-RVA: 0x28AA9A0 Offset: 0x28AAAA1 VA: 0x28AA9A0
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>..ctor
	|
	|-RVA: 0x28AABC0 Offset: 0x28AACC1 VA: 0x28AABC0
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>..ctor
	|
	|-RVA: 0x28AAE00 Offset: 0x28AAF01 VA: 0x28AAE00
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>..ctor
	|
	|-RVA: 0x28AB010 Offset: 0x28AB111 VA: 0x28AB010
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>..ctor
	|
	|-RVA: 0x28AB240 Offset: 0x28AB341 VA: 0x28AB240
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>..ctor
	|
	|-RVA: 0x28AB460 Offset: 0x28AB561 VA: 0x28AB460
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>..ctor
	|
	|-RVA: 0x28AB680 Offset: 0x28AB781 VA: 0x28AB680
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>..ctor
	|
	|-RVA: 0x28AB8A0 Offset: 0x28AB9A1 VA: 0x28AB8A0
	|-Array.EmptyInternalEnumerator<FurnitureData>..ctor
	|
	|-RVA: 0x28ABAB0 Offset: 0x28ABBB1 VA: 0x28ABAB0
	|-Array.EmptyInternalEnumerator<GateDataTable>..ctor
	|
	|-RVA: 0x28ABCE0 Offset: 0x28ABDE1 VA: 0x28ABCE0
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>..ctor
	|
	|-RVA: 0x28ABEF0 Offset: 0x28ABFF1 VA: 0x28ABEF0
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x28AC120 Offset: 0x28AC221 VA: 0x28AC120
	|-Array.EmptyInternalEnumerator<HitResult>..ctor
	|
	|-RVA: 0x28AC340 Offset: 0x28AC441 VA: 0x28AC340
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>..ctor
	|
	|-RVA: 0x28AC560 Offset: 0x28AC661 VA: 0x28AC560
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>..ctor
	|
	|-RVA: 0x28AC770 Offset: 0x28AC871 VA: 0x28AC770
	|-Array.EmptyInternalEnumerator<ItemLevelData>..ctor
	|
	|-RVA: 0x28AC990 Offset: 0x28ACA91 VA: 0x28AC990
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>..ctor
	|
	|-RVA: 0x28ACBC0 Offset: 0x28ACCC1 VA: 0x28ACBC0
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>..ctor
	|
	|-RVA: 0x28ACDD0 Offset: 0x28ACED1 VA: 0x28ACDD0
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>..ctor
	|
	|-RVA: 0x28AD000 Offset: 0x28AD101 VA: 0x28AD000
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>..ctor
	|
	|-RVA: 0x28AD210 Offset: 0x28AD311 VA: 0x28AD210
	|-Array.EmptyInternalEnumerator<MiningDataTable>..ctor
	|
	|-RVA: 0x28AD440 Offset: 0x28AD541 VA: 0x28AD440
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>..ctor
	|
	|-RVA: 0x28AD660 Offset: 0x28AD761 VA: 0x28AD660
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>..ctor
	|
	|-RVA: 0x28AD880 Offset: 0x28AD981 VA: 0x28AD880
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>..ctor
	|
	|-RVA: 0x28ADAA0 Offset: 0x28ADBA1 VA: 0x28ADAA0
	|-Array.EmptyInternalEnumerator<MonsterDataTable>..ctor
	|
	|-RVA: 0x28ADCC0 Offset: 0x28ADDC1 VA: 0x28ADCC0
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>..ctor
	|
	|-RVA: 0x28ADEF0 Offset: 0x28ADFF1 VA: 0x28ADEF0
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x28AE120 Offset: 0x28AE221 VA: 0x28AE120
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x28AE350 Offset: 0x28AE451 VA: 0x28AE350
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>..ctor
	|
	|-RVA: 0x28AE560 Offset: 0x28AE661 VA: 0x28AE560
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>..ctor
	|
	|-RVA: 0x28AE770 Offset: 0x28AE871 VA: 0x28AE770
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x28AE9A0 Offset: 0x28AEAA1 VA: 0x28AE9A0
	|-Array.EmptyInternalEnumerator<NPCActionData>..ctor
	|
	|-RVA: 0x28AEBB0 Offset: 0x28AECB1 VA: 0x28AEBB0
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>..ctor
	|
	|-RVA: 0x28AEDC0 Offset: 0x28AEEC1 VA: 0x28AEDC0
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>..ctor
	|
	|-RVA: 0x28AEFE0 Offset: 0x28AF0E1 VA: 0x28AEFE0
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x28AF1F0 Offset: 0x28AF2F1 VA: 0x28AF1F0
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x28AF420 Offset: 0x28AF521 VA: 0x28AF420
	|-Array.EmptyInternalEnumerator<OrderSaveData>..ctor
	|
	|-RVA: 0x28AF640 Offset: 0x28AF741 VA: 0x28AF640
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>..ctor
	|
	|-RVA: 0x28AF850 Offset: 0x28AF951 VA: 0x28AF850
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x28AFA70 Offset: 0x28AFB71 VA: 0x28AFA70
	|-Array.EmptyInternalEnumerator<Parameter>..ctor
	|
	|-RVA: 0x28AFC80 Offset: 0x28AFD81 VA: 0x28AFC80
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x28AFEB0 Offset: 0x28AFFB1 VA: 0x28AFEB0
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>..ctor
	|
	|-RVA: 0x28B00C0 Offset: 0x28B01C1 VA: 0x28B00C0
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>..ctor
	|
	|-RVA: 0x28B02F0 Offset: 0x28B03F1 VA: 0x28B02F0
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>..ctor
	|
	|-RVA: 0x28B0500 Offset: 0x28B0601 VA: 0x28B0500
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x28B0710 Offset: 0x28B0811 VA: 0x28B0710
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x28B0920 Offset: 0x28B0A21 VA: 0x28B0920
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x28B0B50 Offset: 0x28B0C51 VA: 0x28B0B50
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>..ctor
	|
	|-RVA: 0x28B0D80 Offset: 0x28B0E81 VA: 0x28B0D80
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>..ctor
	|
	|-RVA: 0x28B0FB0 Offset: 0x28B10B1 VA: 0x28B0FB0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>..ctor
	|
	|-RVA: 0x28B11C0 Offset: 0x28B12C1 VA: 0x28B11C0
	|-Array.EmptyInternalEnumerator<ProfilerFrame>..ctor
	|
	|-RVA: 0x28B13D0 Offset: 0x28B14D1 VA: 0x28B13D0
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x28B15F0 Offset: 0x28B16F1 VA: 0x28B15F0
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x28B1810 Offset: 0x28B1911 VA: 0x28B1810
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>..ctor
	|
	|-RVA: 0x28B1A20 Offset: 0x28B1B21 VA: 0x28B1A20
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>..ctor
	|
	|-RVA: 0x28B1C30 Offset: 0x28B1D31 VA: 0x28B1C30
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>..ctor
	|
	|-RVA: 0x28B1E50 Offset: 0x28B1F51 VA: 0x28B1E50
	|-Array.EmptyInternalEnumerator<Schedule>..ctor
	|
	|-RVA: 0x28B2060 Offset: 0x28B2161 VA: 0x28B2060
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x28B2270 Offset: 0x28B2371 VA: 0x28B2270
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x28B2480 Offset: 0x28B2581 VA: 0x28B2480
	|-Array.EmptyInternalEnumerator<SpeedData>..ctor
	|
	|-RVA: 0x26F2690 Offset: 0x26F2791 VA: 0x26F2690
	|-Array.EmptyInternalEnumerator<CurveSample>..ctor
	|
	|-RVA: 0x26F28A0 Offset: 0x26F29A1 VA: 0x26F28A0
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>..ctor
	|
	|-RVA: 0x26F2AB0 Offset: 0x26F2BB1 VA: 0x26F2AB0
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>..ctor
	|
	|-RVA: 0x26F2CC0 Offset: 0x26F2DC1 VA: 0x26F2CC0
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>..ctor
	|
	|-RVA: 0x26F2ED0 Offset: 0x26F2FD1 VA: 0x26F2ED0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>..ctor
	|
	|-RVA: 0x26F30E0 Offset: 0x26F31E1 VA: 0x26F30E0
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>..ctor
	|
	|-RVA: 0x26F32F0 Offset: 0x26F33F1 VA: 0x26F32F0
	|-Array.EmptyInternalEnumerator<bool>..ctor
	|
	|-RVA: 0x26F3500 Offset: 0x26F3601 VA: 0x26F3500
	|-Array.EmptyInternalEnumerator<byte>..ctor
	|
	|-RVA: 0x26F3710 Offset: 0x26F3811 VA: 0x26F3710
	|-Array.EmptyInternalEnumerator<ByteEnum>..ctor
	|
	|-RVA: 0x26F3920 Offset: 0x26F3A21 VA: 0x26F3920
	|-Array.EmptyInternalEnumerator<char>..ctor
	|
	|-RVA: 0x26F3B30 Offset: 0x26F3C31 VA: 0x26F3B30
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>..ctor
	|
	|-RVA: 0x26F3D40 Offset: 0x26F3E41 VA: 0x26F3D40
	|-Array.EmptyInternalEnumerator<DictionaryEntry>..ctor
	|
	|-RVA: 0x26F3F60 Offset: 0x26F4061 VA: 0x26F3F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>..ctor
	|
	|-RVA: 0x26F4180 Offset: 0x26F4281 VA: 0x26F4180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>..ctor
	|
	|-RVA: 0x26F43B0 Offset: 0x26F44B1 VA: 0x26F43B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>..ctor
	|
	|-RVA: 0x26F45F0 Offset: 0x26F46F1 VA: 0x26F45F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>..ctor
	|
	|-RVA: 0x26F4820 Offset: 0x26F4921 VA: 0x26F4820
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>..ctor
	|
	|-RVA: 0x26F4A40 Offset: 0x26F4B41 VA: 0x26F4A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>..ctor
	|
	|-RVA: 0x26F4C60 Offset: 0x26F4D61 VA: 0x26F4C60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>..ctor
	|
	|-RVA: 0x26F4E90 Offset: 0x26F4F91 VA: 0x26F4E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>..ctor
	|
	|-RVA: 0x26F50B0 Offset: 0x26F51B1 VA: 0x26F50B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>..ctor
	|
	|-RVA: 0x26F52E0 Offset: 0x26F53E1 VA: 0x26F52E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>..ctor
	|
	|-RVA: 0x26F5510 Offset: 0x26F5611 VA: 0x26F5510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>..ctor
	|
	|-RVA: 0x26F5730 Offset: 0x26F5831 VA: 0x26F5730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>..ctor
	|
	|-RVA: 0x26F5950 Offset: 0x26F5A51 VA: 0x26F5950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>..ctor
	|
	|-RVA: 0x26F5B70 Offset: 0x26F5C71 VA: 0x26F5B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>..ctor
	|
	|-RVA: 0x26F5D90 Offset: 0x26F5E91 VA: 0x26F5D90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>..ctor
	|
	|-RVA: 0x26F5FB0 Offset: 0x26F60B1 VA: 0x26F5FB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>..ctor
	|
	|-RVA: 0x26F61D0 Offset: 0x26F62D1 VA: 0x26F61D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>..ctor
	|
	|-RVA: 0x26F63F0 Offset: 0x26F64F1 VA: 0x26F63F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>..ctor
	|
	|-RVA: 0x26F6610 Offset: 0x26F6711 VA: 0x26F6610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>..ctor
	|
	|-RVA: 0x26F6830 Offset: 0x26F6931 VA: 0x26F6830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>..ctor
	|
	|-RVA: 0x26F6A50 Offset: 0x26F6B51 VA: 0x26F6A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>..ctor
	|
	|-RVA: 0x26F6C60 Offset: 0x26F6D61 VA: 0x26F6C60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>..ctor
	|
	|-RVA: 0x26F6EA0 Offset: 0x26F6FA1 VA: 0x26F6EA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>..ctor
	|
	|-RVA: 0x26F70C0 Offset: 0x26F71C1 VA: 0x26F70C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>..ctor
	|
	|-RVA: 0x26F72D0 Offset: 0x26F73D1 VA: 0x26F72D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>..ctor
	|
	|-RVA: 0x26F74E0 Offset: 0x26F75E1 VA: 0x26F74E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>..ctor
	|
	|-RVA: 0x26F76F0 Offset: 0x26F77F1 VA: 0x26F76F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>..ctor
	|
	|-RVA: 0x26F7900 Offset: 0x26F7A01 VA: 0x26F7900
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>..ctor
	|
	|-RVA: 0x26F7B20 Offset: 0x26F7C21 VA: 0x26F7B20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>..ctor
	|
	|-RVA: 0x26F7D40 Offset: 0x26F7E41 VA: 0x26F7D40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>..ctor
	|
	|-RVA: 0x26F7F70 Offset: 0x26F8071 VA: 0x26F7F70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>..ctor
	|
	|-RVA: 0x26F8190 Offset: 0x26F8291 VA: 0x26F8190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>..ctor
	|
	|-RVA: 0x26F83B0 Offset: 0x26F84B1 VA: 0x26F83B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>..ctor
	|
	|-RVA: 0x26F85D0 Offset: 0x26F86D1 VA: 0x26F85D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>..ctor
	|
	|-RVA: 0x26F87F0 Offset: 0x26F88F1 VA: 0x26F87F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>..ctor
	|
	|-RVA: 0x26F8A20 Offset: 0x26F8B21 VA: 0x26F8A20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>..ctor
	|
	|-RVA: 0x26F8C50 Offset: 0x26F8D51 VA: 0x26F8C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>..ctor
	|
	|-RVA: 0x26F8E60 Offset: 0x26F8F61 VA: 0x26F8E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>..ctor
	|
	|-RVA: 0x26F9080 Offset: 0x26F9181 VA: 0x26F9080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>..ctor
	|
	|-RVA: 0x26F9290 Offset: 0x26F9391 VA: 0x26F9290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>..ctor
	|
	|-RVA: 0x26F94A0 Offset: 0x26F95A1 VA: 0x26F94A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x26F96C0 Offset: 0x26F97C1 VA: 0x26F96C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>..ctor
	|
	|-RVA: 0x26F98D0 Offset: 0x26F99D1 VA: 0x26F98D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>..ctor
	|
	|-RVA: 0x26F9AF0 Offset: 0x26F9BF1 VA: 0x26F9AF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x26F9D10 Offset: 0x26F9E11 VA: 0x26F9D10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>..ctor
	|
	|-RVA: 0x26F9F30 Offset: 0x26FA031 VA: 0x26F9F30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>..ctor
	|
	|-RVA: 0x26FA150 Offset: 0x26FA251 VA: 0x26FA150
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>..ctor
	|
	|-RVA: 0x26FA370 Offset: 0x26FA471 VA: 0x26FA370
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>..ctor
	|
	|-RVA: 0x26FA590 Offset: 0x26FA691 VA: 0x26FA590
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>..ctor
	|
	|-RVA: 0x26FA7C0 Offset: 0x26FA8C1 VA: 0x26FA7C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>..ctor
	|
	|-RVA: 0x26FA9F0 Offset: 0x26FAAF1 VA: 0x26FA9F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>..ctor
	|
	|-RVA: 0x26FAC10 Offset: 0x26FAD11 VA: 0x26FAC10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>..ctor
	|
	|-RVA: 0x26FAE40 Offset: 0x26FAF41 VA: 0x26FAE40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>..ctor
	|
	|-RVA: 0x26FB060 Offset: 0x26FB161 VA: 0x26FB060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>..ctor
	|
	|-RVA: 0x26FB290 Offset: 0x26FB391 VA: 0x26FB290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>..ctor
	|
	|-RVA: 0x26FB4C0 Offset: 0x26FB5C1 VA: 0x26FB4C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>..ctor
	|
	|-RVA: 0x26FB6E0 Offset: 0x26FB7E1 VA: 0x26FB6E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>..ctor
	|
	|-RVA: 0x26FB920 Offset: 0x26FBA21 VA: 0x26FB920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>..ctor
	|
	|-RVA: 0x26FBB50 Offset: 0x26FBC51 VA: 0x26FBB50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>..ctor
	|
	|-RVA: 0x26FBD70 Offset: 0x26FBE71 VA: 0x26FBD70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>..ctor
	|
	|-RVA: 0x26FBFA0 Offset: 0x26FC0A1 VA: 0x26FBFA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>..ctor
	|
	|-RVA: 0x26FC1D0 Offset: 0x26FC2D1 VA: 0x26FC1D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>..ctor
	|
	|-RVA: 0x26FC3F0 Offset: 0x26FC4F1 VA: 0x26FC3F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>..ctor
	|
	|-RVA: 0x26FC610 Offset: 0x26FC711 VA: 0x26FC610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>..ctor
	|
	|-RVA: 0x26FC830 Offset: 0x26FC931 VA: 0x26FC830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>..ctor
	|
	|-RVA: 0x26FCA50 Offset: 0x26FCB51 VA: 0x26FCA50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>..ctor
	|
	|-RVA: 0x26FCC80 Offset: 0x26FCD81 VA: 0x26FCC80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>..ctor
	|
	|-RVA: 0x26FCEA0 Offset: 0x26FCFA1 VA: 0x26FCEA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>..ctor
	|
	|-RVA: 0x26FD0D0 Offset: 0x26FD1D1 VA: 0x26FD0D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>..ctor
	|
	|-RVA: 0x26FD310 Offset: 0x26FD411 VA: 0x26FD310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>..ctor
	|
	|-RVA: 0x26FD540 Offset: 0x26FD641 VA: 0x26FD540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>..ctor
	|
	|-RVA: 0x26FD760 Offset: 0x26FD861 VA: 0x26FD760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>..ctor
	|
	|-RVA: 0x26FD980 Offset: 0x26FDA81 VA: 0x26FD980
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>..ctor
	|
	|-RVA: 0x26FDBB0 Offset: 0x26FDCB1 VA: 0x26FDBB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>..ctor
	|
	|-RVA: 0x26FDDD0 Offset: 0x26FDED1 VA: 0x26FDDD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>..ctor
	|
	|-RVA: 0x26FE000 Offset: 0x26FE101 VA: 0x26FE000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>..ctor
	|
	|-RVA: 0x26FE230 Offset: 0x26FE331 VA: 0x26FE230
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>..ctor
	|
	|-RVA: 0x26FE450 Offset: 0x26FE551 VA: 0x26FE450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>..ctor
	|
	|-RVA: 0x26FE670 Offset: 0x26FE771 VA: 0x26FE670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>..ctor
	|
	|-RVA: 0x26FE890 Offset: 0x26FE991 VA: 0x26FE890
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>..ctor
	|
	|-RVA: 0x26FEAB0 Offset: 0x26FEBB1 VA: 0x26FEAB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>..ctor
	|
	|-RVA: 0x26FECD0 Offset: 0x26FEDD1 VA: 0x26FECD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>..ctor
	|
	|-RVA: 0x26FEEF0 Offset: 0x26FEFF1 VA: 0x26FEEF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>..ctor
	|
	|-RVA: 0x26FF110 Offset: 0x26FF211 VA: 0x26FF110
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>..ctor
	|
	|-RVA: 0x26FF330 Offset: 0x26FF431 VA: 0x26FF330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>..ctor
	|
	|-RVA: 0x26FF550 Offset: 0x26FF651 VA: 0x26FF550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>..ctor
	|
	|-RVA: 0x26FF770 Offset: 0x26FF871 VA: 0x26FF770
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>..ctor
	|
	|-RVA: 0x26FF990 Offset: 0x26FFA91 VA: 0x26FF990
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>..ctor
	|
	|-RVA: 0x26FFBB0 Offset: 0x26FFCB1 VA: 0x26FFBB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>..ctor
	|
	|-RVA: 0x26FFDD0 Offset: 0x26FFED1 VA: 0x26FFDD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>..ctor
	|
	|-RVA: 0x2700000 Offset: 0x2700101 VA: 0x2700000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>..ctor
	|
	|-RVA: 0x2700230 Offset: 0x2700331 VA: 0x2700230
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>..ctor
	|
	|-RVA: 0x2700450 Offset: 0x2700551 VA: 0x2700450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>..ctor
	|
	|-RVA: 0x2700680 Offset: 0x2700781 VA: 0x2700680
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>..ctor
	|
	|-RVA: 0x27008A0 Offset: 0x27009A1 VA: 0x27008A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>..ctor
	|
	|-RVA: 0x2700AD0 Offset: 0x2700BD1 VA: 0x2700AD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>..ctor
	|
	|-RVA: 0x2700D00 Offset: 0x2700E01 VA: 0x2700D00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>..ctor
	|
	|-RVA: 0x2700F20 Offset: 0x2701021 VA: 0x2700F20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>..ctor
	|
	|-RVA: 0x2701160 Offset: 0x2701261 VA: 0x2701160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>..ctor
	|
	|-RVA: 0x2701390 Offset: 0x2701491 VA: 0x2701390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>..ctor
	|
	|-RVA: 0x27015B0 Offset: 0x27016B1 VA: 0x27015B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>..ctor
	|
	|-RVA: 0x27017E0 Offset: 0x27018E1 VA: 0x27017E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>..ctor
	|
	|-RVA: 0x2701A10 Offset: 0x2701B11 VA: 0x2701A10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>..ctor
	|
	|-RVA: 0x2701C30 Offset: 0x2701D31 VA: 0x2701C30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>..ctor
	|
	|-RVA: 0x2701E50 Offset: 0x2701F51 VA: 0x2701E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>..ctor
	|
	|-RVA: 0x2702070 Offset: 0x2702171 VA: 0x2702070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>..ctor
	|
	|-RVA: 0x2702290 Offset: 0x2702391 VA: 0x2702290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>..ctor
	|
	|-RVA: 0x27024C0 Offset: 0x27025C1 VA: 0x27024C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>..ctor
	|
	|-RVA: 0x27026E0 Offset: 0x27027E1 VA: 0x27026E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>..ctor
	|
	|-RVA: 0x2702900 Offset: 0x2702A01 VA: 0x2702900
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>..ctor
	|
	|-RVA: 0x2702B20 Offset: 0x2702C21 VA: 0x2702B20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>..ctor
	|
	|-RVA: 0x2702D40 Offset: 0x2702E41 VA: 0x2702D40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>..ctor
	|
	|-RVA: 0x2702F60 Offset: 0x2703061 VA: 0x2702F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>..ctor
	|
	|-RVA: 0x2703180 Offset: 0x2703281 VA: 0x2703180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>..ctor
	|
	|-RVA: 0x27033A0 Offset: 0x27034A1 VA: 0x27033A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>..ctor
	|
	|-RVA: 0x27035C0 Offset: 0x27036C1 VA: 0x27035C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>..ctor
	|
	|-RVA: 0x27037F0 Offset: 0x27038F1 VA: 0x27037F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>..ctor
	|
	|-RVA: 0x2703A20 Offset: 0x2703B21 VA: 0x2703A20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>..ctor
	|
	|-RVA: 0x2703C50 Offset: 0x2703D51 VA: 0x2703C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>..ctor
	|
	|-RVA: 0x2703E70 Offset: 0x2703F71 VA: 0x2703E70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>..ctor
	|
	|-RVA: 0x2704090 Offset: 0x2704191 VA: 0x2704090
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>..ctor
	|
	|-RVA: 0x27042B0 Offset: 0x27043B1 VA: 0x27042B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>..ctor
	|
	|-RVA: 0x27044E0 Offset: 0x27045E1 VA: 0x27044E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>..ctor
	|
	|-RVA: 0x2704710 Offset: 0x2704811 VA: 0x2704710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>..ctor
	|
	|-RVA: 0x2704930 Offset: 0x2704A31 VA: 0x2704930
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>..ctor
	|
	|-RVA: 0x2704B70 Offset: 0x2704C71 VA: 0x2704B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>..ctor
	|
	|-RVA: 0x2704D90 Offset: 0x2704E91 VA: 0x2704D90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>..ctor
	|
	|-RVA: 0x2704FB0 Offset: 0x27050B1 VA: 0x2704FB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>..ctor
	|
	|-RVA: 0x27051D0 Offset: 0x27052D1 VA: 0x27051D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>..ctor
	|
	|-RVA: 0x27053F0 Offset: 0x27054F1 VA: 0x27053F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>..ctor
	|
	|-RVA: 0x2705610 Offset: 0x2705711 VA: 0x2705610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>..ctor
	|
	|-RVA: 0x2705840 Offset: 0x2705941 VA: 0x2705840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x2705A70 Offset: 0x2705B71 VA: 0x2705A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>..ctor
	|
	|-RVA: 0x2705C90 Offset: 0x2705D91 VA: 0x2705C90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>..ctor
	|
	|-RVA: 0x2705EB0 Offset: 0x2705FB1 VA: 0x2705EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>..ctor
	|
	|-RVA: 0x27060D0 Offset: 0x27061D1 VA: 0x27060D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>..ctor
	|
	|-RVA: 0x27062F0 Offset: 0x27063F1 VA: 0x27062F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>..ctor
	|
	|-RVA: 0x2706510 Offset: 0x2706611 VA: 0x2706510
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>..ctor
	|
	|-RVA: 0x2706730 Offset: 0x2706831 VA: 0x2706730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>..ctor
	|
	|-RVA: 0x2706950 Offset: 0x2706A51 VA: 0x2706950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>..ctor
	|
	|-RVA: 0x2706B70 Offset: 0x2706C71 VA: 0x2706B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>..ctor
	|
	|-RVA: 0x2706DB0 Offset: 0x2706EB1 VA: 0x2706DB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>..ctor
	|
	|-RVA: 0x2706FD0 Offset: 0x27070D1 VA: 0x2706FD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>..ctor
	|
	|-RVA: 0x27071F0 Offset: 0x27072F1 VA: 0x27071F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>..ctor
	|
	|-RVA: 0x2707400 Offset: 0x2707501 VA: 0x2707400
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>..ctor
	|
	|-RVA: 0x2707610 Offset: 0x2707711 VA: 0x2707610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>..ctor
	|
	|-RVA: 0x2707830 Offset: 0x2707931 VA: 0x2707830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>..ctor
	|
	|-RVA: 0x2707A50 Offset: 0x2707B51 VA: 0x2707A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>..ctor
	|
	|-RVA: 0x2707C70 Offset: 0x2707D71 VA: 0x2707C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>..ctor
	|
	|-RVA: 0x2707EA0 Offset: 0x2707FA1 VA: 0x2707EA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>..ctor
	|
	|-RVA: 0x27080D0 Offset: 0x27081D1 VA: 0x27080D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>..ctor
	|
	|-RVA: 0x2708300 Offset: 0x2708401 VA: 0x2708300
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>..ctor
	|
	|-RVA: 0x2708520 Offset: 0x2708621 VA: 0x2708520
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>..ctor
	|
	|-RVA: 0x2708740 Offset: 0x2708841 VA: 0x2708740
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>..ctor
	|
	|-RVA: 0x2708970 Offset: 0x2708A71 VA: 0x2708970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>..ctor
	|
	|-RVA: 0x2708BA0 Offset: 0x2708CA1 VA: 0x2708BA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>..ctor
	|
	|-RVA: 0x2708DC0 Offset: 0x2708EC1 VA: 0x2708DC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>..ctor
	|
	|-RVA: 0x2708FE0 Offset: 0x27090E1 VA: 0x2708FE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>..ctor
	|
	|-RVA: 0x2709200 Offset: 0x2709301 VA: 0x2709200
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>..ctor
	|
	|-RVA: 0x2709420 Offset: 0x2709521 VA: 0x2709420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>..ctor
	|
	|-RVA: 0x2709650 Offset: 0x2709751 VA: 0x2709650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>..ctor
	|
	|-RVA: 0x2709880 Offset: 0x2709981 VA: 0x2709880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>..ctor
	|
	|-RVA: 0x2709AA0 Offset: 0x2709BA1 VA: 0x2709AA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>..ctor
	|
	|-RVA: 0x2709CE0 Offset: 0x2709DE1 VA: 0x2709CE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>..ctor
	|
	|-RVA: 0x2709F00 Offset: 0x270A001 VA: 0x2709F00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>..ctor
	|
	|-RVA: 0x270A120 Offset: 0x270A221 VA: 0x270A120
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>..ctor
	|
	|-RVA: 0x270A340 Offset: 0x270A441 VA: 0x270A340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>..ctor
	|
	|-RVA: 0x270A560 Offset: 0x270A661 VA: 0x270A560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>..ctor
	|
	|-RVA: 0x270A780 Offset: 0x270A881 VA: 0x270A780
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>..ctor
	|
	|-RVA: 0x270A9A0 Offset: 0x270AAA1 VA: 0x270A9A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>..ctor
	|
	|-RVA: 0x270ABC0 Offset: 0x270ACC1 VA: 0x270ABC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>..ctor
	|
	|-RVA: 0x270ADE0 Offset: 0x270AEE1 VA: 0x270ADE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>..ctor
	|
	|-RVA: 0x270B000 Offset: 0x270B101 VA: 0x270B000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>..ctor
	|
	|-RVA: 0x270B220 Offset: 0x270B321 VA: 0x270B220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>..ctor
	|
	|-RVA: 0x270B440 Offset: 0x270B541 VA: 0x270B440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>..ctor
	|
	|-RVA: 0x270B660 Offset: 0x270B761 VA: 0x270B660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>..ctor
	|
	|-RVA: 0x270B870 Offset: 0x270B971 VA: 0x270B870
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>..ctor
	|
	|-RVA: 0x28C6850 Offset: 0x28C6951 VA: 0x28C6850
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>..ctor
	|
	|-RVA: 0x28C6A60 Offset: 0x28C6B61 VA: 0x28C6A60
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>..ctor
	|
	|-RVA: 0x28C6C70 Offset: 0x28C6D71 VA: 0x28C6C70
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>..ctor
	|
	|-RVA: 0x28C6E80 Offset: 0x28C6F81 VA: 0x28C6E80
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>..ctor
	|
	|-RVA: 0x28C70A0 Offset: 0x28C71A1 VA: 0x28C70A0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x28C72C0 Offset: 0x28C73C1 VA: 0x28C72C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>..ctor
	|
	|-RVA: 0x28C74D0 Offset: 0x28C75D1 VA: 0x28C74D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>..ctor
	|
	|-RVA: 0x28C76F0 Offset: 0x28C77F1 VA: 0x28C76F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>..ctor
	|
	|-RVA: 0x28C7920 Offset: 0x28C7A21 VA: 0x28C7920
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>..ctor
	|
	|-RVA: 0x28C7B40 Offset: 0x28C7C41 VA: 0x28C7B40
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>..ctor
	|
	|-RVA: 0x28C7D60 Offset: 0x28C7E61 VA: 0x28C7D60
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>..ctor
	|
	|-RVA: 0x28C7F80 Offset: 0x28C8081 VA: 0x28C7F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>..ctor
	|
	|-RVA: 0x28C81B0 Offset: 0x28C82B1 VA: 0x28C81B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>..ctor
	|
	|-RVA: 0x28C83D0 Offset: 0x28C84D1 VA: 0x28C83D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>..ctor
	|
	|-RVA: 0x28C8600 Offset: 0x28C8701 VA: 0x28C8600
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>..ctor
	|
	|-RVA: 0x28C8830 Offset: 0x28C8931 VA: 0x28C8830
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>..ctor
	|
	|-RVA: 0x28C8A50 Offset: 0x28C8B51 VA: 0x28C8A50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>..ctor
	|
	|-RVA: 0x28C8C60 Offset: 0x28C8D61 VA: 0x28C8C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>..ctor
	|
	|-RVA: 0x28C8E70 Offset: 0x28C8F71 VA: 0x28C8E70
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x28C9080 Offset: 0x28C9181 VA: 0x28C9080
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>..ctor
	|
	|-RVA: 0x28C9290 Offset: 0x28C9391 VA: 0x28C9290
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x28C94A0 Offset: 0x28C95A1 VA: 0x28C94A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>..ctor
	|
	|-RVA: 0x28C96C0 Offset: 0x28C97C1 VA: 0x28C96C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>..ctor
	|
	|-RVA: 0x28C98D0 Offset: 0x28C99D1 VA: 0x28C98D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>..ctor
	|
	|-RVA: 0x28C9AF0 Offset: 0x28C9BF1 VA: 0x28C9AF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>..ctor
	|
	|-RVA: 0x28C9D10 Offset: 0x28C9E11 VA: 0x28C9D10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>..ctor
	|
	|-RVA: 0x28C9F20 Offset: 0x28CA021 VA: 0x28C9F20
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>..ctor
	|
	|-RVA: 0x28CA160 Offset: 0x28CA261 VA: 0x28CA160
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>..ctor
	|
	|-RVA: 0x28CA380 Offset: 0x28CA481 VA: 0x28CA380
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>..ctor
	|
	|-RVA: 0x28CA590 Offset: 0x28CA691 VA: 0x28CA590
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x28CA7A0 Offset: 0x28CA8A1 VA: 0x28CA7A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>..ctor
	|
	|-RVA: 0x28CA9B0 Offset: 0x28CAAB1 VA: 0x28CA9B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x28CABC0 Offset: 0x28CACC1 VA: 0x28CABC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>..ctor
	|
	|-RVA: 0x28CADD0 Offset: 0x28CAED1 VA: 0x28CADD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>..ctor
	|
	|-RVA: 0x28CAFE0 Offset: 0x28CB0E1 VA: 0x28CAFE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x28CB210 Offset: 0x28CB311 VA: 0x28CB210
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>..ctor
	|
	|-RVA: 0x28CB430 Offset: 0x28CB531 VA: 0x28CB430
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>..ctor
	|
	|-RVA: 0x28CB640 Offset: 0x28CB741 VA: 0x28CB640
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>..ctor
	|
	|-RVA: 0x28CB850 Offset: 0x28CB951 VA: 0x28CB850
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>..ctor
	|
	|-RVA: 0x28CBA70 Offset: 0x28CBB71 VA: 0x28CBA70
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>..ctor
	|
	|-RVA: 0x28CBCA0 Offset: 0x28CBDA1 VA: 0x28CBCA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>..ctor
	|
	|-RVA: 0x28CBEC0 Offset: 0x28CBFC1 VA: 0x28CBEC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>..ctor
	|
	|-RVA: 0x28CC0D0 Offset: 0x28CC1D1 VA: 0x28CC0D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>..ctor
	|
	|-RVA: 0x28CC2E0 Offset: 0x28CC3E1 VA: 0x28CC2E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>..ctor
	|
	|-RVA: 0x28CC4F0 Offset: 0x28CC5F1 VA: 0x28CC4F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x28CC700 Offset: 0x28CC801 VA: 0x28CC700
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x28CC910 Offset: 0x28CCA11 VA: 0x28CC910
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x28CCB20 Offset: 0x28CCC21 VA: 0x28CCB20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>..ctor
	|
	|-RVA: 0x28CCD40 Offset: 0x28CCE41 VA: 0x28CCD40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x28CCF50 Offset: 0x28CD051 VA: 0x28CCF50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>..ctor
	|
	|-RVA: 0x28CD160 Offset: 0x28CD261 VA: 0x28CD160
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>..ctor
	|
	|-RVA: 0x28CD370 Offset: 0x28CD471 VA: 0x28CD370
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>..ctor
	|
	|-RVA: 0x28CD590 Offset: 0x28CD691 VA: 0x28CD590
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>..ctor
	|
	|-RVA: 0x28CD7A0 Offset: 0x28CD8A1 VA: 0x28CD7A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>..ctor
	|
	|-RVA: 0x28CD9D0 Offset: 0x28CDAD1 VA: 0x28CD9D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>..ctor
	|
	|-RVA: 0x28CDC00 Offset: 0x28CDD01 VA: 0x28CDC00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>..ctor
	|
	|-RVA: 0x28CDE10 Offset: 0x28CDF11 VA: 0x28CDE10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>..ctor
	|
	|-RVA: 0x28CE030 Offset: 0x28CE131 VA: 0x28CE030
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>..ctor
	|
	|-RVA: 0x28CE250 Offset: 0x28CE351 VA: 0x28CE250
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>..ctor
	|
	|-RVA: 0x28CE470 Offset: 0x28CE571 VA: 0x28CE470
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>..ctor
	|
	|-RVA: 0x28CE6A0 Offset: 0x28CE7A1 VA: 0x28CE6A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>..ctor
	|
	|-RVA: 0x28CE8B0 Offset: 0x28CE9B1 VA: 0x28CE8B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>..ctor
	|
	|-RVA: 0x28CEAF0 Offset: 0x28CEBF1 VA: 0x28CEAF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>..ctor
	|
	|-RVA: 0x28CED10 Offset: 0x28CEE11 VA: 0x28CED10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>..ctor
	|
	|-RVA: 0x28CEF30 Offset: 0x28CF031 VA: 0x28CEF30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>..ctor
	|
	|-RVA: 0x28CF150 Offset: 0x28CF251 VA: 0x28CF150
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>..ctor
	|
	|-RVA: 0x28CF370 Offset: 0x28CF471 VA: 0x28CF370
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>..ctor
	|
	|-RVA: 0x28CF590 Offset: 0x28CF691 VA: 0x28CF590
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>..ctor
	|
	|-RVA: 0x28CF7B0 Offset: 0x28CF8B1 VA: 0x28CF7B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>..ctor
	|
	|-RVA: 0x28CF9D0 Offset: 0x28CFAD1 VA: 0x28CF9D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>..ctor
	|
	|-RVA: 0x28CFBF0 Offset: 0x28CFCF1 VA: 0x28CFBF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>..ctor
	|
	|-RVA: 0x28CFE10 Offset: 0x28CFF11 VA: 0x28CFE10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>..ctor
	|
	|-RVA: 0x28D0020 Offset: 0x28D0121 VA: 0x28D0020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>..ctor
	|
	|-RVA: 0x28D0240 Offset: 0x28D0341 VA: 0x28D0240
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>..ctor
	|
	|-RVA: 0x28D0470 Offset: 0x28D0571 VA: 0x28D0470
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>..ctor
	|
	|-RVA: 0x28D0690 Offset: 0x28D0791 VA: 0x28D0690
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>..ctor
	|
	|-RVA: 0x28D08B0 Offset: 0x28D09B1 VA: 0x28D08B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>..ctor
	|
	|-RVA: 0x28D0AD0 Offset: 0x28D0BD1 VA: 0x28D0AD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>..ctor
	|
	|-RVA: 0x28D0D00 Offset: 0x28D0E01 VA: 0x28D0D00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>..ctor
	|
	|-RVA: 0x28D0F20 Offset: 0x28D1021 VA: 0x28D0F20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>..ctor
	|
	|-RVA: 0x28D1150 Offset: 0x28D1251 VA: 0x28D1150
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>..ctor
	|
	|-RVA: 0x28D1380 Offset: 0x28D1481 VA: 0x28D1380
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>..ctor
	|
	|-RVA: 0x28D15A0 Offset: 0x28D16A1 VA: 0x28D15A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>..ctor
	|
	|-RVA: 0x28D17C0 Offset: 0x28D18C1 VA: 0x28D17C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>..ctor
	|
	|-RVA: 0x28D19D0 Offset: 0x28D1AD1 VA: 0x28D19D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>..ctor
	|
	|-RVA: 0x28D1BE0 Offset: 0x28D1CE1 VA: 0x28D1BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>..ctor
	|
	|-RVA: 0x28D1DF0 Offset: 0x28D1EF1 VA: 0x28D1DF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x28D2000 Offset: 0x28D2101 VA: 0x28D2000
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>..ctor
	|
	|-RVA: 0x28D2210 Offset: 0x28D2311 VA: 0x28D2210
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>..ctor
	|
	|-RVA: 0x28D2420 Offset: 0x28D2521 VA: 0x28D2420
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>..ctor
	|
	|-RVA: 0x28D2630 Offset: 0x28D2731 VA: 0x28D2630
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x28D2840 Offset: 0x28D2941 VA: 0x28D2840
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>..ctor
	|
	|-RVA: 0x28D2A50 Offset: 0x28D2B51 VA: 0x28D2A50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>..ctor
	|
	|-RVA: 0x28D2C70 Offset: 0x28D2D71 VA: 0x28D2C70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>..ctor
	|
	|-RVA: 0x28D2E80 Offset: 0x28D2F81 VA: 0x28D2E80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>..ctor
	|
	|-RVA: 0x28D30B0 Offset: 0x28D31B1 VA: 0x28D30B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>..ctor
	|
	|-RVA: 0x28D32E0 Offset: 0x28D33E1 VA: 0x28D32E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>..ctor
	|
	|-RVA: 0x28D34F0 Offset: 0x28D35F1 VA: 0x28D34F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>..ctor
	|
	|-RVA: 0x28D3710 Offset: 0x28D3811 VA: 0x28D3710
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>..ctor
	|
	|-RVA: 0x28D3930 Offset: 0x28D3A31 VA: 0x28D3930
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>..ctor
	|
	|-RVA: 0x28D3B50 Offset: 0x28D3C51 VA: 0x28D3B50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>..ctor
	|
	|-RVA: 0x28D3D80 Offset: 0x28D3E81 VA: 0x28D3D80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>..ctor
	|
	|-RVA: 0x28D3F90 Offset: 0x28D4091 VA: 0x28D3F90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>..ctor
	|
	|-RVA: 0x28D41D0 Offset: 0x28D42D1 VA: 0x28D41D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>..ctor
	|
	|-RVA: 0x28D43F0 Offset: 0x28D44F1 VA: 0x28D43F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>..ctor
	|
	|-RVA: 0x28D4610 Offset: 0x28D4711 VA: 0x28D4610
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>..ctor
	|
	|-RVA: 0x28D4830 Offset: 0x28D4931 VA: 0x28D4830
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>..ctor
	|
	|-RVA: 0x28D4A50 Offset: 0x28D4B51 VA: 0x28D4A50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>..ctor
	|
	|-RVA: 0x28D4C70 Offset: 0x28D4D71 VA: 0x28D4C70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>..ctor
	|
	|-RVA: 0x28D4E90 Offset: 0x28D4F91 VA: 0x28D4E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>..ctor
	|
	|-RVA: 0x28D50B0 Offset: 0x28D51B1 VA: 0x28D50B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>..ctor
	|
	|-RVA: 0x28D52D0 Offset: 0x28D53D1 VA: 0x28D52D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>..ctor
	|
	|-RVA: 0x28D54F0 Offset: 0x28D55F1 VA: 0x28D54F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>..ctor
	|
	|-RVA: 0x28D5700 Offset: 0x28D5801 VA: 0x28D5700
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x28D5920 Offset: 0x28D5A21 VA: 0x28D5920
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>..ctor
	|
	|-RVA: 0x28D5B40 Offset: 0x28D5C41 VA: 0x28D5B40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>..ctor
	|
	|-RVA: 0x28D5D50 Offset: 0x28D5E51 VA: 0x28D5D50
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>..ctor
	|
	|-RVA: 0x28D5F60 Offset: 0x28D6061 VA: 0x28D5F60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x28D6170 Offset: 0x28D6271 VA: 0x28D6170
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>..ctor
	|
	|-RVA: 0x28D6380 Offset: 0x28D6481 VA: 0x28D6380
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>..ctor
	|
	|-RVA: 0x28D6590 Offset: 0x28D6691 VA: 0x28D6590
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>..ctor
	|
	|-RVA: 0x28D67C0 Offset: 0x28D68C1 VA: 0x28D67C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>..ctor
	|
	|-RVA: 0x28D69E0 Offset: 0x28D6AE1 VA: 0x28D69E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>..ctor
	|
	|-RVA: 0x28D6C00 Offset: 0x28D6D01 VA: 0x28D6C00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>..ctor
	|
	|-RVA: 0x28D6E10 Offset: 0x28D6F11 VA: 0x28D6E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>..ctor
	|
	|-RVA: 0x28D7030 Offset: 0x28D7131 VA: 0x28D7030
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>..ctor
	|
	|-RVA: 0x28D7240 Offset: 0x28D7341 VA: 0x28D7240
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>..ctor
	|
	|-RVA: 0x28D7460 Offset: 0x28D7561 VA: 0x28D7460
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>..ctor
	|
	|-RVA: 0x28D7690 Offset: 0x28D7791 VA: 0x28D7690
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>..ctor
	|
	|-RVA: 0x28D78A0 Offset: 0x28D79A1 VA: 0x28D78A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>..ctor
	|
	|-RVA: 0x28D7AE0 Offset: 0x28D7BE1 VA: 0x28D7AE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>..ctor
	|
	|-RVA: 0x28D7D00 Offset: 0x28D7E01 VA: 0x28D7D00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>..ctor
	|
	|-RVA: 0x28D7F20 Offset: 0x28D8021 VA: 0x28D7F20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>..ctor
	|
	|-RVA: 0x28D8130 Offset: 0x28D8231 VA: 0x28D8130
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>..ctor
	|
	|-RVA: 0x28D8350 Offset: 0x28D8451 VA: 0x28D8350
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>..ctor
	|
	|-RVA: 0x28D8570 Offset: 0x28D8671 VA: 0x28D8570
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>..ctor
	|
	|-RVA: 0x28D8790 Offset: 0x28D8891 VA: 0x28D8790
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x28D89B0 Offset: 0x28D8AB1 VA: 0x28D89B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>..ctor
	|
	|-RVA: 0x28D8BC0 Offset: 0x28D8CC1 VA: 0x28D8BC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>..ctor
	|
	|-RVA: 0x28D8DD0 Offset: 0x28D8ED1 VA: 0x28D8DD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>..ctor
	|
	|-RVA: 0x28D8FF0 Offset: 0x28D90F1 VA: 0x28D8FF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>..ctor
	|
	|-RVA: 0x28D9210 Offset: 0x28D9311 VA: 0x28D9210
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>..ctor
	|
	|-RVA: 0x28D9430 Offset: 0x28D9531 VA: 0x28D9430
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>..ctor
	|
	|-RVA: 0x28D9650 Offset: 0x28D9751 VA: 0x28D9650
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>..ctor
	|
	|-RVA: 0x28D9860 Offset: 0x28D9961 VA: 0x28D9860
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>..ctor
	|
	|-RVA: 0x28D9A70 Offset: 0x28D9B71 VA: 0x28D9A70
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>..ctor
	|
	|-RVA: 0x28D9CB0 Offset: 0x28D9DB1 VA: 0x28D9CB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>..ctor
	|
	|-RVA: 0x28D9EC0 Offset: 0x28D9FC1 VA: 0x28D9EC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x28DA0D0 Offset: 0x28DA1D1 VA: 0x28DA0D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>..ctor
	|
	|-RVA: 0x28DA2E0 Offset: 0x28DA3E1 VA: 0x28DA2E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>..ctor
	|
	|-RVA: 0x28DA4F0 Offset: 0x28DA5F1 VA: 0x28DA4F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>..ctor
	|
	|-RVA: 0x28DA700 Offset: 0x28DA801 VA: 0x28DA700
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x28DA910 Offset: 0x28DAA11 VA: 0x28DA910
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>..ctor
	|
	|-RVA: 0x28DAB20 Offset: 0x28DAC21 VA: 0x28DAB20
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>..ctor
	|
	|-RVA: 0x28DAD50 Offset: 0x28DAE51 VA: 0x28DAD50
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>..ctor
	|
	|-RVA: 0x28DAF80 Offset: 0x28DB081 VA: 0x28DAF80
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>..ctor
	|
	|-RVA: 0x28DB1B0 Offset: 0x28DB2B1 VA: 0x28DB1B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>..ctor
	|
	|-RVA: 0x28DB3C0 Offset: 0x28DB4C1 VA: 0x28DB3C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>..ctor
	|
	|-RVA: 0x28DB5D0 Offset: 0x28DB6D1 VA: 0x28DB5D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>..ctor
	|
	|-RVA: 0x28DB7F0 Offset: 0x28DB8F1 VA: 0x28DB7F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>..ctor
	|
	|-RVA: 0x28DBA10 Offset: 0x28DBB11 VA: 0x28DBA10
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>..ctor
	|
	|-RVA: 0x28DBC30 Offset: 0x28DBD31 VA: 0x28DBC30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>..ctor
	|
	|-RVA: 0x28DBE40 Offset: 0x28DBF41 VA: 0x28DBE40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>..ctor
	|
	|-RVA: 0x28DC050 Offset: 0x28DC151 VA: 0x28DC050
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>..ctor
	|
	|-RVA: 0x28DC260 Offset: 0x28DC361 VA: 0x28DC260
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>..ctor
	|
	|-RVA: 0x28DC480 Offset: 0x28DC581 VA: 0x28DC480
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>..ctor
	|
	|-RVA: 0x28DC6B0 Offset: 0x28DC7B1 VA: 0x28DC6B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>..ctor
	|
	|-RVA: 0x28DC8C0 Offset: 0x28DC9C1 VA: 0x28DC8C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>..ctor
	|
	|-RVA: 0x28DCB00 Offset: 0x28DCC01 VA: 0x28DCB00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>..ctor
	|
	|-RVA: 0x28DCD20 Offset: 0x28DCE21 VA: 0x28DCD20
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>..ctor
	|
	|-RVA: 0x28DCF40 Offset: 0x28DD041 VA: 0x28DCF40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>..ctor
	|
	|-RVA: 0x28DD150 Offset: 0x28DD251 VA: 0x28DD150
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>..ctor
	|
	|-RVA: 0x28DD370 Offset: 0x28DD471 VA: 0x28DD370
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>..ctor
	|
	|-RVA: 0x28DD590 Offset: 0x28DD691 VA: 0x28DD590
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>..ctor
	|
	|-RVA: 0x28DD7A0 Offset: 0x28DD8A1 VA: 0x28DD7A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>..ctor
	|
	|-RVA: 0x28DD9B0 Offset: 0x28DDAB1 VA: 0x28DD9B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>..ctor
	|
	|-RVA: 0x28DDBC0 Offset: 0x28DDCC1 VA: 0x28DDBC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>..ctor
	|
	|-RVA: 0x28DDDD0 Offset: 0x28DDED1 VA: 0x28DDDD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>..ctor
	|
	|-RVA: 0x28DDFF0 Offset: 0x28DE0F1 VA: 0x28DDFF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>..ctor
	|
	|-RVA: 0x28DE210 Offset: 0x28DE311 VA: 0x28DE210
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>..ctor
	|
	|-RVA: 0x28DE430 Offset: 0x28DE531 VA: 0x28DE430
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>..ctor
	|
	|-RVA: 0x28DE650 Offset: 0x28DE751 VA: 0x28DE650
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>..ctor
	|
	|-RVA: 0x28DE860 Offset: 0x28DE961 VA: 0x28DE860
	|-Array.EmptyInternalEnumerator<DateTime>..ctor
	|
	|-RVA: 0x28DEA70 Offset: 0x28DEB71 VA: 0x28DEA70
	|-Array.EmptyInternalEnumerator<DateTimeOffset>..ctor
	|
	|-RVA: 0x28DEC80 Offset: 0x28DED81 VA: 0x28DEC80
	|-Array.EmptyInternalEnumerator<Decimal>..ctor
	|
	|-RVA: 0x28DEE90 Offset: 0x28DEF91 VA: 0x28DEE90
	|-Array.EmptyInternalEnumerator<double>..ctor
	|
	|-RVA: 0x28DF0A0 Offset: 0x28DF1A1 VA: 0x28DF0A0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>..ctor
	|
	|-RVA: 0x28DF2B0 Offset: 0x28DF3B1 VA: 0x28DF2B0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>..ctor
	|
	|-RVA: 0x273E8F0 Offset: 0x273E9F1 VA: 0x273E8F0
	|-Array.EmptyInternalEnumerator<Guid>..ctor
	|
	|-RVA: 0x273EB00 Offset: 0x273EC01 VA: 0x273EB00
	|-Array.EmptyInternalEnumerator<short>..ctor
	|
	|-RVA: 0x273ED10 Offset: 0x273EE11 VA: 0x273ED10
	|-Array.EmptyInternalEnumerator<int>..ctor
	|
	|-RVA: 0x273EF20 Offset: 0x273F021 VA: 0x273EF20
	|-Array.EmptyInternalEnumerator<Int32Enum>..ctor
	|
	|-RVA: 0x273F130 Offset: 0x273F231 VA: 0x273F130
	|-Array.EmptyInternalEnumerator<long>..ctor
	|
	|-RVA: 0x273F340 Offset: 0x273F441 VA: 0x273F340
	|-Array.EmptyInternalEnumerator<IntPtr>..ctor
	|
	|-RVA: 0x273F550 Offset: 0x273F651 VA: 0x273F550
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x273F760 Offset: 0x273F861 VA: 0x273F760
	|-Array.EmptyInternalEnumerator<LocalDefinition>..ctor
	|
	|-RVA: 0x273F970 Offset: 0x273FA71 VA: 0x273F970
	|-Array.EmptyInternalEnumerator<RuntimeLabel>..ctor
	|
	|-RVA: 0x273FB80 Offset: 0x273FC81 VA: 0x273FB80
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>..ctor
	|
	|-RVA: 0x273FDA0 Offset: 0x273FEA1 VA: 0x273FDA0
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>..ctor
	|
	|-RVA: 0x273FFB0 Offset: 0x27400B1 VA: 0x273FFB0
	|-Array.EmptyInternalEnumerator<Memory<object>>..ctor
	|
	|-RVA: 0x27401C0 Offset: 0x27402C1 VA: 0x27401C0
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>..ctor
	|
	|-RVA: 0x27403D0 Offset: 0x27404D1 VA: 0x27403D0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>..ctor
	|
	|-RVA: 0x27405E0 Offset: 0x27406E1 VA: 0x27405E0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>..ctor
	|
	|-RVA: 0x2740810 Offset: 0x2740911 VA: 0x2740810
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2740A20 Offset: 0x2740B21 VA: 0x2740A20
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x2740C50 Offset: 0x2740D51 VA: 0x2740C50
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x2740E80 Offset: 0x2740F81 VA: 0x2740E80
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x2741090 Offset: 0x2741191 VA: 0x2741090
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>..ctor
	|
	|-RVA: 0x27412B0 Offset: 0x27413B1 VA: 0x27412B0
	|-Array.EmptyInternalEnumerator<Nullable<Color>>..ctor
	|
	|-RVA: 0x27414C0 Offset: 0x27415C1 VA: 0x27414C0
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x27416E0 Offset: 0x27417E1 VA: 0x27416E0
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x2741900 Offset: 0x2741A01 VA: 0x2741900
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x2741B10 Offset: 0x2741C11 VA: 0x2741B10
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x2741D50 Offset: 0x2741E51 VA: 0x2741D50
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x2741F70 Offset: 0x2742071 VA: 0x2741F70
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x2742180 Offset: 0x2742281 VA: 0x2742180
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x27423A0 Offset: 0x27424A1 VA: 0x27423A0
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>..ctor
	|
	|-RVA: 0x27425C0 Offset: 0x27426C1 VA: 0x27425C0
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x27427D0 Offset: 0x27428D1 VA: 0x27427D0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x27429E0 Offset: 0x2742AE1 VA: 0x27429E0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2742BF0 Offset: 0x2742CF1 VA: 0x2742BF0
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2742E00 Offset: 0x2742F01 VA: 0x2742E00
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2743020 Offset: 0x2743121 VA: 0x2743020
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x27431F0 Offset: 0x27432F1 VA: 0x27431F0
	|-Array.EmptyInternalEnumerator<object>..ctor
	|
	|-RVA: 0x2743400 Offset: 0x2743501 VA: 0x2743400
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>..ctor
	|
	|-RVA: 0x2743610 Offset: 0x2743711 VA: 0x2743610
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2743830 Offset: 0x2743931 VA: 0x2743830
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x2743A40 Offset: 0x2743B41 VA: 0x2743A40
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x2743C50 Offset: 0x2743D51 VA: 0x2743C50
	|-Array.EmptyInternalEnumerator<Label>..ctor
	|
	|-RVA: 0x2743E60 Offset: 0x2743F61 VA: 0x2743E60
	|-Array.EmptyInternalEnumerator<ParameterModifier>..ctor
	|
	|-RVA: 0x2744070 Offset: 0x2744171 VA: 0x2744070
	|-Array.EmptyInternalEnumerator<ResourceLocator>..ctor
	|
	|-RVA: 0x2744280 Offset: 0x2744381 VA: 0x2744280
	|-Array.EmptyInternalEnumerator<Ephemeron>..ctor
	|
	|-RVA: 0x2744490 Offset: 0x2744591 VA: 0x2744490
	|-Array.EmptyInternalEnumerator<GCHandle>..ctor
	|
	|-RVA: 0x27446A0 Offset: 0x27447A1 VA: 0x27446A0
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>..ctor
	|
	|-RVA: 0x27448B0 Offset: 0x27449B1 VA: 0x27448B0
	|-Array.EmptyInternalEnumerator<sbyte>..ctor
	|
	|-RVA: 0x2744AC0 Offset: 0x2744BC1 VA: 0x2744AC0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>..ctor
	|
	|-RVA: 0x2744CD0 Offset: 0x2744DD1 VA: 0x2744CD0
	|-Array.EmptyInternalEnumerator<float>..ctor
	|
	|-RVA: 0x2744EE0 Offset: 0x2744FE1 VA: 0x2744EE0
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>..ctor
	|
	|-RVA: 0x2745100 Offset: 0x2745201 VA: 0x2745100
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x2745310 Offset: 0x2745411 VA: 0x2745310
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>..ctor
	|
	|-RVA: 0x2745520 Offset: 0x2745621 VA: 0x2745520
	|-Array.EmptyInternalEnumerator<TimeSpan>..ctor
	|
	|-RVA: 0x2745730 Offset: 0x2745831 VA: 0x2745730
	|-Array.EmptyInternalEnumerator<ushort>..ctor
	|
	|-RVA: 0x2745940 Offset: 0x2745A41 VA: 0x2745940
	|-Array.EmptyInternalEnumerator<UInt16Enum>..ctor
	|
	|-RVA: 0x2745B50 Offset: 0x2745C51 VA: 0x2745B50
	|-Array.EmptyInternalEnumerator<uint>..ctor
	|
	|-RVA: 0x2745D60 Offset: 0x2745E61 VA: 0x2745D60
	|-Array.EmptyInternalEnumerator<UInt32Enum>..ctor
	|
	|-RVA: 0x2745F70 Offset: 0x2746071 VA: 0x2745F70
	|-Array.EmptyInternalEnumerator<ulong>..ctor
	|
	|-RVA: 0x2746180 Offset: 0x2746281 VA: 0x2746180
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x2746390 Offset: 0x2746491 VA: 0x2746390
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x27465A0 Offset: 0x27466A1 VA: 0x27465A0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x27467B0 Offset: 0x27468B1 VA: 0x27467B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x27469C0 Offset: 0x2746AC1 VA: 0x27469C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2746BD0 Offset: 0x2746CD1 VA: 0x2746BD0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x2746DE0 Offset: 0x2746EE1 VA: 0x2746DE0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x2746FF0 Offset: 0x27470F1 VA: 0x2746FF0
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2747220 Offset: 0x2747321 VA: 0x2747220
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x2747430 Offset: 0x2747531 VA: 0x2747430
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x2747650 Offset: 0x2747751 VA: 0x2747650
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>..ctor
	|
	|-RVA: 0x2747870 Offset: 0x2747971 VA: 0x2747870
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>..ctor
	|
	|-RVA: 0x2747AA0 Offset: 0x2747BA1 VA: 0x2747AA0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x2747CC0 Offset: 0x2747DC1 VA: 0x2747CC0
	|-Array.EmptyInternalEnumerator<HighlightState>..ctor
	|
	|-RVA: 0x2747EF0 Offset: 0x2747FF1 VA: 0x2747EF0
	|-Array.EmptyInternalEnumerator<MaterialReference>..ctor
	|
	|-RVA: 0x2748110 Offset: 0x2748211 VA: 0x2748110
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>..ctor
	|
	|-RVA: 0x2748340 Offset: 0x2748441 VA: 0x2748340
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x2748560 Offset: 0x2748661 VA: 0x2748560
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>..ctor
	|
	|-RVA: 0x2748770 Offset: 0x2748871 VA: 0x2748770
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>..ctor
	|
	|-RVA: 0x27489C0 Offset: 0x2748AC1 VA: 0x27489C0
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>..ctor
	|
	|-RVA: 0x2748BF0 Offset: 0x2748CF1 VA: 0x2748BF0
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>..ctor
	|
	|-RVA: 0x2748E30 Offset: 0x2748F31 VA: 0x2748E30
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>..ctor
	|
	|-RVA: 0x2749050 Offset: 0x2749151 VA: 0x2749050
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>..ctor
	|
	|-RVA: 0x2749260 Offset: 0x2749361 VA: 0x2749260
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>..ctor
	|
	|-RVA: 0x2749480 Offset: 0x2749581 VA: 0x2749480
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>..ctor
	|
	|-RVA: 0x27496A0 Offset: 0x27497A1 VA: 0x27496A0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>..ctor
	|
	|-RVA: 0x27498C0 Offset: 0x27499C1 VA: 0x27498C0
	|-Array.EmptyInternalEnumerator<WordWrapState>..ctor
	|
	|-RVA: 0x2749AF0 Offset: 0x2749BF1 VA: 0x2749AF0
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>..ctor
	|
	|-RVA: 0x2749D10 Offset: 0x2749E11 VA: 0x2749D10
	|-Array.EmptyInternalEnumerator<TransitionTables>..ctor
	|
	|-RVA: 0x2749F20 Offset: 0x274A021 VA: 0x2749F20
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x274A130 Offset: 0x274A231 VA: 0x274A130
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>..ctor
	|
	|-RVA: 0x274A340 Offset: 0x274A441 VA: 0x274A340
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x274A570 Offset: 0x274A671 VA: 0x274A570
	|-Array.EmptyInternalEnumerator<CapEdge>..ctor
	|
	|-RVA: 0x274A790 Offset: 0x274A891 VA: 0x274A790
	|-Array.EmptyInternalEnumerator<ClippedEdge>..ctor
	|
	|-RVA: 0x274A9A0 Offset: 0x274AAA1 VA: 0x274A9A0
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>..ctor
	|
	|-RVA: 0x274ABB0 Offset: 0x274ACB1 VA: 0x274ABB0
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>..ctor
	|
	|-RVA: 0x274ADC0 Offset: 0x274AEC1 VA: 0x274ADC0
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x274AFE0 Offset: 0x274B0E1 VA: 0x274AFE0
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x274B210 Offset: 0x274B311 VA: 0x274B210
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x274B420 Offset: 0x274B521 VA: 0x274B420
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x274B670 Offset: 0x274B771 VA: 0x274B670
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x274B880 Offset: 0x274B981 VA: 0x274B880
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>..ctor
	|
	|-RVA: 0x274BA90 Offset: 0x274BB91 VA: 0x274BA90
	|-Array.EmptyInternalEnumerator<ConstraintSource>..ctor
	|
	|-RVA: 0x274BCA0 Offset: 0x274BDA1 VA: 0x274BCA0
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>..ctor
	|
	|-RVA: 0x274BEB0 Offset: 0x274BFB1 VA: 0x274BEB0
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>..ctor
	|
	|-RVA: 0x274C0C0 Offset: 0x274C1C1 VA: 0x274C0C0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x274C2D0 Offset: 0x274C3D1 VA: 0x274C2D0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x274C4E0 Offset: 0x274C5E1 VA: 0x274C4E0
	|-Array.EmptyInternalEnumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x274C700 Offset: 0x274C801 VA: 0x274C700
	|-Array.EmptyInternalEnumerator<BoneWeight>..ctor
	|
	|-RVA: 0x274C910 Offset: 0x274CA11 VA: 0x274C910
	|-Array.EmptyInternalEnumerator<BoundingSphere>..ctor
	|
	|-RVA: 0x274CB30 Offset: 0x274CC31 VA: 0x274CB30
	|-Array.EmptyInternalEnumerator<Bounds>..ctor
	|
	|-RVA: 0x274CD50 Offset: 0x274CE51 VA: 0x274CD50
	|-Array.EmptyInternalEnumerator<BoundsInt>..ctor
	|
	|-RVA: 0x274CF80 Offset: 0x274D081 VA: 0x274CF80
	|-Array.EmptyInternalEnumerator<CharacterInfo>..ctor
	|
	|-RVA: 0x274D190 Offset: 0x274D291 VA: 0x274D190
	|-Array.EmptyInternalEnumerator<Color32>..ctor
	|
	|-RVA: 0x274D3A0 Offset: 0x274D4A1 VA: 0x274D3A0
	|-Array.EmptyInternalEnumerator<Color>..ctor
	|
	|-RVA: 0x274D5F0 Offset: 0x274D6F1 VA: 0x274D5F0
	|-Array.EmptyInternalEnumerator<CombineInstance>..ctor
	|
	|-RVA: 0x274D820 Offset: 0x274D921 VA: 0x274D820
	|-Array.EmptyInternalEnumerator<ContactPoint2D>..ctor
	|
	|-RVA: 0x274DA50 Offset: 0x274DB51 VA: 0x274DA50
	|-Array.EmptyInternalEnumerator<ContactPoint>..ctor
	|
	|-RVA: 0x274DC90 Offset: 0x274DD91 VA: 0x274DC90
	|-Array.EmptyInternalEnumerator<RaycastResult>..ctor
	|
	|-RVA: 0x274DED0 Offset: 0x274DFD1 VA: 0x274DED0
	|-Array.EmptyInternalEnumerator<LightDataGI>..ctor
	|
	|-RVA: 0x274E0E0 Offset: 0x274E1E1 VA: 0x274E0E0
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>..ctor
	|
	|-RVA: 0x274E2F0 Offset: 0x274E3F1 VA: 0x274E2F0
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>..ctor
	|
	|-RVA: 0x274E510 Offset: 0x274E611 VA: 0x274E510
	|-Array.EmptyInternalEnumerator<GradientColorKey>..ctor
	|
	|-RVA: 0x274E740 Offset: 0x274E841 VA: 0x274E740
	|-Array.EmptyInternalEnumerator<HumanBone>..ctor
	|
	|-RVA: 0x274E970 Offset: 0x274EA71 VA: 0x274E970
	|-Array.EmptyInternalEnumerator<Keyframe>..ctor
	|
	|-RVA: 0x274EB80 Offset: 0x274EC81 VA: 0x274EB80
	|-Array.EmptyInternalEnumerator<LOD>..ctor
	|
	|-RVA: 0x274ED90 Offset: 0x274EE91 VA: 0x274ED90
	|-Array.EmptyInternalEnumerator<LayerMask>..ctor
	|
	|-RVA: 0x274EFC0 Offset: 0x274F0C1 VA: 0x274EFC0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x274F1F0 Offset: 0x274F2F1 VA: 0x274F1F0
	|-Array.EmptyInternalEnumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x274F410 Offset: 0x274F511 VA: 0x274F410
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x274F620 Offset: 0x274F721 VA: 0x274F620
	|-Array.EmptyInternalEnumerator<PatchExtents>..ctor
	|
	|-RVA: 0x274F830 Offset: 0x274F931 VA: 0x274F830
	|-Array.EmptyInternalEnumerator<Plane>..ctor
	|
	|-RVA: 0x274FA40 Offset: 0x274FB41 VA: 0x274FA40
	|-Array.EmptyInternalEnumerator<Playable>..ctor
	|
	|-RVA: 0x274FC60 Offset: 0x274FD61 VA: 0x274FC60
	|-Array.EmptyInternalEnumerator<PlayableBinding>..ctor
	|
	|-RVA: 0x274FE70 Offset: 0x274FF71 VA: 0x274FE70
	|-Array.EmptyInternalEnumerator<PlayableGraph>..ctor
	|
	|-RVA: 0x2750080 Offset: 0x2750181 VA: 0x2750080
	|-Array.EmptyInternalEnumerator<Edge>..ctor
	|
	|-RVA: 0x2750290 Offset: 0x2750391 VA: 0x2750290
	|-Array.EmptyInternalEnumerator<IntVec3>..ctor
	|
	|-RVA: 0x27504A0 Offset: 0x27505A1 VA: 0x27504A0
	|-Array.EmptyInternalEnumerator<Quaternion>..ctor
	|
	|-RVA: 0x27506B0 Offset: 0x27507B1 VA: 0x27506B0
	|-Array.EmptyInternalEnumerator<RangeInt>..ctor
	|
	|-RVA: 0x27508E0 Offset: 0x27509E1 VA: 0x27508E0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x2750B10 Offset: 0x2750C11 VA: 0x2750B10
	|-Array.EmptyInternalEnumerator<RaycastHit>..ctor
	|
	|-RVA: 0x2750D20 Offset: 0x2750E21 VA: 0x2750D20
	|-Array.EmptyInternalEnumerator<Rect>..ctor
	|
	|-RVA: 0x2750F30 Offset: 0x2751031 VA: 0x2750F30
	|-Array.EmptyInternalEnumerator<RectInt>..ctor
	|
	|-RVA: 0x2751140 Offset: 0x2751241 VA: 0x2751140
	|-Array.EmptyInternalEnumerator<RenderBuffer>..ctor
	|
	|-RVA: 0x2751350 Offset: 0x2751451 VA: 0x2751350
	|-Array.EmptyInternalEnumerator<BatchVisibility>..ctor
	|
	|-RVA: 0x2751560 Offset: 0x2751661 VA: 0x2751560
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x27517B0 Offset: 0x27518B1 VA: 0x27517B0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x27519C0 Offset: 0x2751AC1 VA: 0x27519C0
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x2751BE0 Offset: 0x2751CE1 VA: 0x2751BE0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2751E00 Offset: 0x2751F01 VA: 0x2751E00
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2752020 Offset: 0x2752121 VA: 0x2752020
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2752250 Offset: 0x2752351 VA: 0x2752250
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2752460 Offset: 0x2752561 VA: 0x2752460
	|-Array.EmptyInternalEnumerator<SceneInstance>..ctor
	|
	|-RVA: 0x2752680 Offset: 0x2752781 VA: 0x2752680
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x27528B0 Offset: 0x27529B1 VA: 0x27528B0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>..ctor
	|
	|-RVA: 0x2752AD0 Offset: 0x2752BD1 VA: 0x2752AD0
	|-Array.EmptyInternalEnumerator<SerializedType>..ctor
	|
	|-RVA: 0x2752CE0 Offset: 0x2752DE1 VA: 0x2752CE0
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>..ctor
	|
	|-RVA: 0x2752F10 Offset: 0x2753011 VA: 0x2752F10
	|-Array.EmptyInternalEnumerator<SkeletonBone>..ctor
	|
	|-RVA: 0x2753120 Offset: 0x2753221 VA: 0x2753120
	|-Array.EmptyInternalEnumerator<GlyphRect>..ctor
	|
	|-RVA: 0x2753350 Offset: 0x2753451 VA: 0x2753350
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>..ctor
	|
	|-RVA: 0x2753580 Offset: 0x2753681 VA: 0x2753580
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x27537B0 Offset: 0x27538B1 VA: 0x27537B0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x27539D0 Offset: 0x2753AD1 VA: 0x27539D0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>..ctor
	|
	|-RVA: 0x2753BF0 Offset: 0x2753CF1 VA: 0x2753BF0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x2753E10 Offset: 0x2753F11 VA: 0x2753E10
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x2754050 Offset: 0x2754151 VA: 0x2754050
	|-Array.EmptyInternalEnumerator<Touch>..ctor
	|
	|-RVA: 0x2754280 Offset: 0x2754381 VA: 0x2754280
	|-Array.EmptyInternalEnumerator<TreeInstance>..ctor
	|
	|-RVA: 0x27544C0 Offset: 0x27545C1 VA: 0x27544C0
	|-Array.EmptyInternalEnumerator<ColorBlock>..ctor
	|
	|-RVA: 0x27546F0 Offset: 0x27547F1 VA: 0x27546F0
	|-Array.EmptyInternalEnumerator<Navigation>..ctor
	|
	|-RVA: 0x2754910 Offset: 0x2754A11 VA: 0x2754910
	|-Array.EmptyInternalEnumerator<SpriteState>..ctor
	|
	|-RVA: 0x2754B20 Offset: 0x2754C21 VA: 0x2754B20
	|-Array.EmptyInternalEnumerator<UICharInfo>..ctor
	|
	|-RVA: 0x2754D30 Offset: 0x2754E31 VA: 0x2754D30
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>..ctor
	|
	|-RVA: 0x2754F40 Offset: 0x2755041 VA: 0x2754F40
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>..ctor
	|
	|-RVA: 0x2755150 Offset: 0x2755251 VA: 0x2755150
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x2755360 Offset: 0x2755461 VA: 0x2755360
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>..ctor
	|
	|-RVA: 0x2755580 Offset: 0x2755681 VA: 0x2755580
	|-Array.EmptyInternalEnumerator<StyleValue>..ctor
	|
	|-RVA: 0x2755790 Offset: 0x2755891 VA: 0x2755790
	|-Array.EmptyInternalEnumerator<UILineInfo>..ctor
	|
	|-RVA: 0x27559D0 Offset: 0x2755AD1 VA: 0x27559D0
	|-Array.EmptyInternalEnumerator<UIVertex>..ctor
	|
	|-RVA: 0x2755BF0 Offset: 0x2755CF1 VA: 0x2755BF0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2755E00 Offset: 0x2755F01 VA: 0x2755E00
	|-Array.EmptyInternalEnumerator<Vector2>..ctor
	|
	|-RVA: 0x2756010 Offset: 0x2756111 VA: 0x2756010
	|-Array.EmptyInternalEnumerator<Vector2Int>..ctor
	|
	|-RVA: 0x2756220 Offset: 0x2756321 VA: 0x2756220
	|-Array.EmptyInternalEnumerator<Vector3>..ctor
	|
	|-RVA: 0x2756430 Offset: 0x2756531 VA: 0x2756430
	|-Array.EmptyInternalEnumerator<Vector3Int>..ctor
	|
	|-RVA: 0x2756640 Offset: 0x2756741 VA: 0x2756640
	|-Array.EmptyInternalEnumerator<Vector4>..ctor
	|
	|-RVA: 0x2756850 Offset: 0x2756951 VA: 0x2756850
	|-Array.EmptyInternalEnumerator<jvalue>..ctor
	|
	|-RVA: 0x2756AA0 Offset: 0x2756BA1 VA: 0x2756AA0
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2756CB0 Offset: 0x2756DB1 VA: 0x2756CB0
	|-Array.EmptyInternalEnumerator<YieldItemParam>..ctor
	|
	|-RVA: 0x2756EC0 Offset: 0x2756FC1 VA: 0x2756EC0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>..ctor
	|
	|-RVA: 0x27570D0 Offset: 0x27571D1 VA: 0x27570D0
	|-Array.EmptyInternalEnumerator<Uid>..ctor
	|
	|-RVA: 0x27572E0 Offset: 0x27573E1 VA: 0x27572E0
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>..ctor
	|
	|-RVA: 0x27574F0 Offset: 0x27575F1 VA: 0x27574F0
	|-Array.EmptyInternalEnumerator<NsUid>..ctor
	|
	|-RVA: 0x2757710 Offset: 0x2757811 VA: 0x2757710
	|-Array.EmptyInternalEnumerator<Friend>..ctor
	|
	|-RVA: 0x2757930 Offset: 0x2757A31 VA: 0x2757930
	|-Array.EmptyInternalEnumerator<Profile>..ctor
	|
	|-RVA: 0x2757B50 Offset: 0x2757C51 VA: 0x2757B50
	|-Array.EmptyInternalEnumerator<DirectoryEntry>..ctor
	|
	|-RVA: 0x2757D70 Offset: 0x2757E71 VA: 0x2757D70
	|-Array.EmptyInternalEnumerator<DebugPadState>..ctor
	|
	|-RVA: 0x2757F80 Offset: 0x2758081 VA: 0x2757F80
	|-Array.EmptyInternalEnumerator<GesturePoint>..ctor
	|
	|-RVA: 0x27581C0 Offset: 0x27582C1 VA: 0x27581C0
	|-Array.EmptyInternalEnumerator<GestureState>..ctor
	|
	|-RVA: 0x27583F0 Offset: 0x27584F1 VA: 0x27583F0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>..ctor
	|
	|-RVA: 0x2758620 Offset: 0x2758721 VA: 0x2758620
	|-Array.EmptyInternalEnumerator<NpadHandheldState>..ctor
	|
	|-RVA: 0x2758850 Offset: 0x2758951 VA: 0x2758850
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>..ctor
	|
	|-RVA: 0x2758A80 Offset: 0x2758B81 VA: 0x2758A80
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>..ctor
	|
	|-RVA: 0x2758CB0 Offset: 0x2758DB1 VA: 0x2758CB0
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>..ctor
	|
	|-RVA: 0x2758EE0 Offset: 0x2758FE1 VA: 0x2758EE0
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>..ctor
	|
	|-RVA: 0x246A0E0 Offset: 0x246A1E1 VA: 0x246A0E0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>..ctor
	|
	|-RVA: 0x246A320 Offset: 0x246A421 VA: 0x246A320
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>..ctor
	|
	|-RVA: 0x246A540 Offset: 0x246A641 VA: 0x246A540
	|-Array.EmptyInternalEnumerator<TouchScreenState10>..ctor
	|
	|-RVA: 0x246A760 Offset: 0x246A861 VA: 0x246A760
	|-Array.EmptyInternalEnumerator<TouchScreenState11>..ctor
	|
	|-RVA: 0x246A980 Offset: 0x246AA81 VA: 0x246A980
	|-Array.EmptyInternalEnumerator<TouchScreenState12>..ctor
	|
	|-RVA: 0x246ABA0 Offset: 0x246ACA1 VA: 0x246ABA0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>..ctor
	|
	|-RVA: 0x246ADC0 Offset: 0x246AEC1 VA: 0x246ADC0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>..ctor
	|
	|-RVA: 0x246AFE0 Offset: 0x246B0E1 VA: 0x246AFE0
	|-Array.EmptyInternalEnumerator<TouchScreenState15>..ctor
	|
	|-RVA: 0x246B200 Offset: 0x246B301 VA: 0x246B200
	|-Array.EmptyInternalEnumerator<TouchScreenState16>..ctor
	|
	|-RVA: 0x246B430 Offset: 0x246B531 VA: 0x246B430
	|-Array.EmptyInternalEnumerator<TouchScreenState1>..ctor
	|
	|-RVA: 0x246B670 Offset: 0x246B771 VA: 0x246B670
	|-Array.EmptyInternalEnumerator<TouchScreenState2>..ctor
	|
	|-RVA: 0x246B890 Offset: 0x246B991 VA: 0x246B890
	|-Array.EmptyInternalEnumerator<TouchScreenState3>..ctor
	|
	|-RVA: 0x246BAB0 Offset: 0x246BBB1 VA: 0x246BAB0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>..ctor
	|
	|-RVA: 0x246BCD0 Offset: 0x246BDD1 VA: 0x246BCD0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>..ctor
	|
	|-RVA: 0x246BEF0 Offset: 0x246BFF1 VA: 0x246BEF0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>..ctor
	|
	|-RVA: 0x246C110 Offset: 0x246C211 VA: 0x246C110
	|-Array.EmptyInternalEnumerator<TouchScreenState7>..ctor
	|
	|-RVA: 0x246C330 Offset: 0x246C431 VA: 0x246C330
	|-Array.EmptyInternalEnumerator<TouchScreenState8>..ctor
	|
	|-RVA: 0x246C550 Offset: 0x246C651 VA: 0x246C550
	|-Array.EmptyInternalEnumerator<TouchScreenState9>..ctor
	|
	|-RVA: 0x246C780 Offset: 0x246C881 VA: 0x246C780
	|-Array.EmptyInternalEnumerator<TouchState>..ctor
	|
	|-RVA: 0x246C990 Offset: 0x246CA91 VA: 0x246C990
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>..ctor
	|
	|-RVA: 0x246CBA0 Offset: 0x246CCA1 VA: 0x246CBA0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>..ctor
	|
	|-RVA: 0x246CDB0 Offset: 0x246CEB1 VA: 0x246CDB0
	|-Array.EmptyInternalEnumerator<VibrationValue>..ctor
	|
	|-RVA: 0x246CFD0 Offset: 0x246D0D1 VA: 0x246CFD0
	|-Array.EmptyInternalEnumerator<ClusteringData>..ctor
	|
	|-RVA: 0x246D1F0 Offset: 0x246D2F1 VA: 0x246D1F0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>..ctor
	|
	|-RVA: 0x246D420 Offset: 0x246D521 VA: 0x246D420
	|-Array.EmptyInternalEnumerator<Finger>..ctor
	|
	|-RVA: 0x246D640 Offset: 0x246D741 VA: 0x246D640
	|-Array.EmptyInternalEnumerator<Hand>..ctor
	|
	|-RVA: 0x246D850 Offset: 0x246D951 VA: 0x246D850
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>..ctor
	|
	|-RVA: 0x246DA70 Offset: 0x246DB71 VA: 0x246DA70
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>..ctor
	|
	|-RVA: 0x246DC90 Offset: 0x246DD91 VA: 0x246DC90
	|-Array.EmptyInternalEnumerator<MomentProcessorState>..ctor
	|
	|-RVA: 0x246DEA0 Offset: 0x246DFA1 VA: 0x246DEA0
	|-Array.EmptyInternalEnumerator<MomentStatistic>..ctor
	|
	|-RVA: 0x246E0B0 Offset: 0x246E1B1 VA: 0x246E0B0
	|-Array.EmptyInternalEnumerator<Protrusion>..ctor
	|
	|-RVA: 0x246E2D0 Offset: 0x246E3D1 VA: 0x246E2D0
	|-Array.EmptyInternalEnumerator<Shape>..ctor
	|
	|-RVA: 0x246E4E0 Offset: 0x246E5E1 VA: 0x246E4E0
	|-Array.EmptyInternalEnumerator<DictionaryInfo>..ctor
	|
	|-RVA: 0x246E6F0 Offset: 0x246E7F1 VA: 0x246E6F0
	|-Array.EmptyInternalEnumerator<UserWord>..ctor
	|
	|-RVA: 0x246E900 Offset: 0x246EA01 VA: 0x246E900
	|-Array.EmptyInternalEnumerator<Color4u8>..ctor
	|
	|-RVA: 0x246EB10 Offset: 0x246EC11 VA: 0x246EB10
	|-Array.EmptyInternalEnumerator<Float2>..ctor
	|
	|-RVA: 0x246ED30 Offset: 0x246EE31 VA: 0x246ED30
	|-Array.EmptyInternalEnumerator<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28A4CD0 Offset: 0x28A4DD1 VA: 0x28A4CD0
	|-Array.EmptyInternalEnumerator<AS_ToolController.ChargeInfo>..cctor
	|
	|-RVA: 0x28A4F10 Offset: 0x28A5011 VA: 0x28A4F10
	|-Array.EmptyInternalEnumerator<ActionCommandDataTable>..cctor
	|
	|-RVA: 0x28A5120 Offset: 0x28A5221 VA: 0x28A5120
	|-Array.EmptyInternalEnumerator<AdvScriptDefCountParam>..cctor
	|
	|-RVA: 0x28A5330 Offset: 0x28A5431 VA: 0x28A5330
	|-Array.EmptyInternalEnumerator<JSONDeserialization.TaskField>..cctor
	|
	|-RVA: 0x28A5540 Offset: 0x28A5641 VA: 0x28A5540
	|-Array.EmptyInternalEnumerator<BitVector32Int>..cctor
	|
	|-RVA: 0x28A5790 Offset: 0x28A5891 VA: 0x28A5790
	|-Array.EmptyInternalEnumerator<BuildItemData>..cctor
	|
	|-RVA: 0x28A59A0 Offset: 0x28A5AA1 VA: 0x28A59A0
	|-Array.EmptyInternalEnumerator<ButtonLinker.LinkObject>..cctor
	|
	|-RVA: 0x28A5BB0 Offset: 0x28A5CB1 VA: 0x28A5BB0
	|-Array.EmptyInternalEnumerator<CharaCallTable.BustupTable>..cctor
	|
	|-RVA: 0x28A5DC0 Offset: 0x28A5EC1 VA: 0x28A5DC0
	|-Array.EmptyInternalEnumerator<CharaCallTable.CharaFaceIconTable>..cctor
	|
	|-RVA: 0x28A5FD0 Offset: 0x28A60D1 VA: 0x28A5FD0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>..cctor
	|
	|-RVA: 0x28A61F0 Offset: 0x28A62F1 VA: 0x28A61F0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>..cctor
	|
	|-RVA: 0x28A6410 Offset: 0x28A6511 VA: 0x28A6410
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>..cctor
	|
	|-RVA: 0x28A6620 Offset: 0x28A6721 VA: 0x28A6620
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>..cctor
	|
	|-RVA: 0x28A6830 Offset: 0x28A6931 VA: 0x28A6830
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>..cctor
	|
	|-RVA: 0x28A6A60 Offset: 0x28A6B61 VA: 0x28A6A60
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>..cctor
	|
	|-RVA: 0x28A6C70 Offset: 0x28A6D71 VA: 0x28A6C70
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>..cctor
	|
	|-RVA: 0x28A6E80 Offset: 0x28A6F81 VA: 0x28A6E80
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>..cctor
	|
	|-RVA: 0x28A70A0 Offset: 0x28A71A1 VA: 0x28A70A0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>..cctor
	|
	|-RVA: 0x28A72B0 Offset: 0x28A73B1 VA: 0x28A72B0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>..cctor
	|
	|-RVA: 0x28A74C0 Offset: 0x28A75C1 VA: 0x28A74C0
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>..cctor
	|
	|-RVA: 0x28A76F0 Offset: 0x28A77F1 VA: 0x28A76F0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>..cctor
	|
	|-RVA: 0x28A7920 Offset: 0x28A7A21 VA: 0x28A7920
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>..cctor
	|
	|-RVA: 0x28A7B50 Offset: 0x28A7C51 VA: 0x28A7B50
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>..cctor
	|
	|-RVA: 0x28A7D70 Offset: 0x28A7E71 VA: 0x28A7D70
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>..cctor
	|
	|-RVA: 0x28A7F90 Offset: 0x28A8091 VA: 0x28A7F90
	|-Array.EmptyInternalEnumerator<CropDataTable>..cctor
	|
	|-RVA: 0x28A81B0 Offset: 0x28A82B1 VA: 0x28A81B0
	|-Array.EmptyInternalEnumerator<ControlPoint>..cctor
	|
	|-RVA: 0x28A83D0 Offset: 0x28A84D1 VA: 0x28A83D0
	|-Array.EmptyInternalEnumerator<DamageTextInfo>..cctor
	|
	|-RVA: 0x28A85F0 Offset: 0x28A86F1 VA: 0x28A85F0
	|-Array.EmptyInternalEnumerator<UIEMDefine.CategoryDataSet>..cctor
	|
	|-RVA: 0x28A8800 Offset: 0x28A8901 VA: 0x28A8800
	|-Array.EmptyInternalEnumerator<DropItemParam>..cctor
	|
	|-RVA: 0x28A8A20 Offset: 0x28A8B21 VA: 0x28A8A20
	|-Array.EmptyInternalEnumerator<DropTableElement>..cctor
	|
	|-RVA: 0x28A8C40 Offset: 0x28A8D41 VA: 0x28A8C40
	|-Array.EmptyInternalEnumerator<EffectDataTable>..cctor
	|
	|-RVA: 0x28A8E50 Offset: 0x28A8F51 VA: 0x28A8E50
	|-Array.EmptyInternalEnumerator<EnemyPatrolPoints>..cctor
	|
	|-RVA: 0x28A9060 Offset: 0x28A9161 VA: 0x28A9060
	|-Array.EmptyInternalEnumerator<Coord>..cctor
	|
	|-RVA: 0x28A9280 Offset: 0x28A9381 VA: 0x28A9280
	|-Array.EmptyInternalEnumerator<ErosionBrush.UndoStep>..cctor
	|
	|-RVA: 0x28A94A0 Offset: 0x28A95A1 VA: 0x28A94A0
	|-Array.EmptyInternalEnumerator<EventCheckId>..cctor
	|
	|-RVA: 0x28A96B0 Offset: 0x28A97B1 VA: 0x28A96B0
	|-Array.EmptyInternalEnumerator<EventFlagProgressData>..cctor
	|
	|-RVA: 0x28A98C0 Offset: 0x28A99C1 VA: 0x28A98C0
	|-Array.EmptyInternalEnumerator<EyeMouthAnimate.EMAnimSet>..cctor
	|
	|-RVA: 0x28A9B00 Offset: 0x28A9C01 VA: 0x28A9B00
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_PARAM>..cctor
	|
	|-RVA: 0x28A9D30 Offset: 0x28A9E31 VA: 0x28A9D30
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE>..cctor
	|
	|-RVA: 0x28A9F50 Offset: 0x28AA051 VA: 0x28A9F50
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_CROP_STATE_INFO>..cctor
	|
	|-RVA: 0x28AA160 Offset: 0x28AA261 VA: 0x28AA160
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_MCROP_INFO>..cctor
	|
	|-RVA: 0x28AA370 Offset: 0x28AA471 VA: 0x28AA370
	|-Array.EmptyInternalEnumerator<FarmManager.RF4_SOIL_INFO>..cctor
	|
	|-RVA: 0x28AA580 Offset: 0x28AA681 VA: 0x28AA580
	|-Array.EmptyInternalEnumerator<FesNpcScoreData>..cctor
	|
	|-RVA: 0x28AA790 Offset: 0x28AA891 VA: 0x28AA790
	|-Array.EmptyInternalEnumerator<FieldHideItemSpawnDataTable>..cctor
	|
	|-RVA: 0x28AA9C0 Offset: 0x28AAAC1 VA: 0x28AA9C0
	|-Array.EmptyInternalEnumerator<FieldItemSpawnDataTable>..cctor
	|
	|-RVA: 0x28AABE0 Offset: 0x28AACE1 VA: 0x28AABE0
	|-Array.EmptyInternalEnumerator<FieldRandomTreasureBoxSpawnDataTable>..cctor
	|
	|-RVA: 0x28AAE20 Offset: 0x28AAF21 VA: 0x28AAE20
	|-Array.EmptyInternalEnumerator<FieldSceneData.Data>..cctor
	|
	|-RVA: 0x28AB030 Offset: 0x28AB131 VA: 0x28AB030
	|-Array.EmptyInternalEnumerator<FieldTreasureBoxItemData>..cctor
	|
	|-RVA: 0x28AB260 Offset: 0x28AB361 VA: 0x28AB260
	|-Array.EmptyInternalEnumerator<FieldUniqueTreasureBoxSpawnDataTable>..cctor
	|
	|-RVA: 0x28AB480 Offset: 0x28AB581 VA: 0x28AB480
	|-Array.EmptyInternalEnumerator<FieldWoodBoxSpawnDataTable>..cctor
	|
	|-RVA: 0x28AB6A0 Offset: 0x28AB7A1 VA: 0x28AB6A0
	|-Array.EmptyInternalEnumerator<FocusObjectDataTable>..cctor
	|
	|-RVA: 0x28AB8C0 Offset: 0x28AB9C1 VA: 0x28AB8C0
	|-Array.EmptyInternalEnumerator<FurnitureData>..cctor
	|
	|-RVA: 0x28ABAD0 Offset: 0x28ABBD1 VA: 0x28ABAD0
	|-Array.EmptyInternalEnumerator<GateDataTable>..cctor
	|
	|-RVA: 0x28ABD00 Offset: 0x28ABE01 VA: 0x28ABD00
	|-Array.EmptyInternalEnumerator<GateStatusDataTable>..cctor
	|
	|-RVA: 0x28ABF10 Offset: 0x28AC011 VA: 0x28ABF10
	|-Array.EmptyInternalEnumerator<GimmickLayoutDataTable>..cctor
	|
	|-RVA: 0x28AC140 Offset: 0x28AC241 VA: 0x28AC140
	|-Array.EmptyInternalEnumerator<HitResult>..cctor
	|
	|-RVA: 0x28AC360 Offset: 0x28AC461 VA: 0x28AC360
	|-Array.EmptyInternalEnumerator<ImagePaneDatas.ImagePaneData>..cctor
	|
	|-RVA: 0x28AC580 Offset: 0x28AC681 VA: 0x28AC580
	|-Array.EmptyInternalEnumerator<FurnitureManager.SendPos>..cctor
	|
	|-RVA: 0x28AC790 Offset: 0x28AC891 VA: 0x28AC790
	|-Array.EmptyInternalEnumerator<ItemLevelData>..cctor
	|
	|-RVA: 0x28AC9B0 Offset: 0x28ACAB1 VA: 0x28AC9B0
	|-Array.EmptyInternalEnumerator<MapDatas.MapData>..cctor
	|
	|-RVA: 0x28ACBE0 Offset: 0x28ACCE1 VA: 0x28ACBE0
	|-Array.EmptyInternalEnumerator<MapObjectDatas.MapObjectData>..cctor
	|
	|-RVA: 0x28ACDF0 Offset: 0x28ACEF1 VA: 0x28ACDF0
	|-Array.EmptyInternalEnumerator<ByteArrayStringHashTable.Entry>..cctor
	|
	|-RVA: 0x28AD020 Offset: 0x28AD121 VA: 0x28AD020
	|-Array.EmptyInternalEnumerator<MineTypeDataTable>..cctor
	|
	|-RVA: 0x28AD230 Offset: 0x28AD331 VA: 0x28AD230
	|-Array.EmptyInternalEnumerator<MiningDataTable>..cctor
	|
	|-RVA: 0x28AD460 Offset: 0x28AD561 VA: 0x28AD460
	|-Array.EmptyInternalEnumerator<MiningPointSaveData>..cctor
	|
	|-RVA: 0x28AD680 Offset: 0x28AD781 VA: 0x28AD680
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>..cctor
	|
	|-RVA: 0x28AD8A0 Offset: 0x28AD9A1 VA: 0x28AD8A0
	|-Array.EmptyInternalEnumerator<MonsterBehaviorDataTable>..cctor
	|
	|-RVA: 0x28ADAC0 Offset: 0x28ADBC1 VA: 0x28ADAC0
	|-Array.EmptyInternalEnumerator<MonsterDataTable>..cctor
	|
	|-RVA: 0x28ADCE0 Offset: 0x28ADDE1 VA: 0x28ADCE0
	|-Array.EmptyInternalEnumerator<MonsterDropItemDataTable>..cctor
	|
	|-RVA: 0x28ADF10 Offset: 0x28AE011 VA: 0x28ADF10
	|-Array.EmptyInternalEnumerator<MonsterFootStepEventDataTable>..cctor
	|
	|-RVA: 0x28AE140 Offset: 0x28AE241 VA: 0x28AE140
	|-Array.EmptyInternalEnumerator<MonsterHutSaveData>..cctor
	|
	|-RVA: 0x28AE370 Offset: 0x28AE471 VA: 0x28AE370
	|-Array.EmptyInternalEnumerator<MonsterUIData.Data>..cctor
	|
	|-RVA: 0x28AE580 Offset: 0x28AE681 VA: 0x28AE580
	|-Array.EmptyInternalEnumerator<MonsterYieldItemDataTable>..cctor
	|
	|-RVA: 0x28AE790 Offset: 0x28AE891 VA: 0x28AE790
	|-Array.EmptyInternalEnumerator<MoviePlayer.SUBTITLEDATA>..cctor
	|
	|-RVA: 0x28AE9C0 Offset: 0x28AEAC1 VA: 0x28AE9C0
	|-Array.EmptyInternalEnumerator<NPCActionData>..cctor
	|
	|-RVA: 0x28AEBD0 Offset: 0x28AECD1 VA: 0x28AEBD0
	|-Array.EmptyInternalEnumerator<NPCCallingNameTextData.Data>..cctor
	|
	|-RVA: 0x28AEDE0 Offset: 0x28AEEE1 VA: 0x28AEDE0
	|-Array.EmptyInternalEnumerator<NPCUIData.Data>..cctor
	|
	|-RVA: 0x28AF000 Offset: 0x28AF101 VA: 0x28AF000
	|-Array.EmptyInternalEnumerator<NpcPlaceSchedule>..cctor
	|
	|-RVA: 0x28AF210 Offset: 0x28AF311 VA: 0x28AF210
	|-Array.EmptyInternalEnumerator<OrderLotterySaveParameter>..cctor
	|
	|-RVA: 0x28AF440 Offset: 0x28AF541 VA: 0x28AF440
	|-Array.EmptyInternalEnumerator<OrderSaveData>..cctor
	|
	|-RVA: 0x28AF660 Offset: 0x28AF761 VA: 0x28AF660
	|-Array.EmptyInternalEnumerator<OrderSaveParameter>..cctor
	|
	|-RVA: 0x28AF870 Offset: 0x28AF971 VA: 0x28AF870
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..cctor
	|
	|-RVA: 0x28AFA90 Offset: 0x28AFB91 VA: 0x28AFA90
	|-Array.EmptyInternalEnumerator<Parameter>..cctor
	|
	|-RVA: 0x28AFCA0 Offset: 0x28AFDA1 VA: 0x28AFCA0
	|-Array.EmptyInternalEnumerator<PartnerNPCWeaponBehaviorDataTable>..cctor
	|
	|-RVA: 0x28AFED0 Offset: 0x28AFFD1 VA: 0x28AFED0
	|-Array.EmptyInternalEnumerator<PlayerCallingNameTextData.Data>..cctor
	|
	|-RVA: 0x28B00E0 Offset: 0x28B01E1 VA: 0x28B00E0
	|-Array.EmptyInternalEnumerator<ShopCatalogPage>..cctor
	|
	|-RVA: 0x28B0310 Offset: 0x28B0411 VA: 0x28B0310
	|-Array.EmptyInternalEnumerator<ShopNpcTalk>..cctor
	|
	|-RVA: 0x28B0520 Offset: 0x28B0621 VA: 0x28B0520
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.Data>..cctor
	|
	|-RVA: 0x28B0730 Offset: 0x28B0831 VA: 0x28B0730
	|-Array.EmptyInternalEnumerator<SubtitleDataTable.DataList>..cctor
	|
	|-RVA: 0x28B0940 Offset: 0x28B0A41 VA: 0x28B0940
	|-Array.EmptyInternalEnumerator<SubtitleHudDataTable.Data>..cctor
	|
	|-RVA: 0x28B0B70 Offset: 0x28B0C71 VA: 0x28B0B70
	|-Array.EmptyInternalEnumerator<AnimationWarping.Warp>..cctor
	|
	|-RVA: 0x28B0DA0 Offset: 0x28B0EA1 VA: 0x28B0DA0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>..cctor
	|
	|-RVA: 0x28B0FD0 Offset: 0x28B10D1 VA: 0x28B0FD0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>..cctor
	|
	|-RVA: 0x28B11E0 Offset: 0x28B12E1 VA: 0x28B11E0
	|-Array.EmptyInternalEnumerator<ProfilerFrame>..cctor
	|
	|-RVA: 0x28B13F0 Offset: 0x28B14F1 VA: 0x28B13F0
	|-Array.EmptyInternalEnumerator<NumberControl.ValueRange>..cctor
	|
	|-RVA: 0x28B1610 Offset: 0x28B1711 VA: 0x28B1610
	|-Array.EmptyInternalEnumerator<SRMonoBehaviourEx.FieldInfo>..cctor
	|
	|-RVA: 0x28B1830 Offset: 0x28B1931 VA: 0x28B1830
	|-Array.EmptyInternalEnumerator<ResponsiveEnable.Entry>..cctor
	|
	|-RVA: 0x28B1A40 Offset: 0x28B1B41 VA: 0x28B1A40
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element.SizeDefinition>..cctor
	|
	|-RVA: 0x28B1C50 Offset: 0x28B1D51 VA: 0x28B1C50
	|-Array.EmptyInternalEnumerator<ResponsiveResize.Element>..cctor
	|
	|-RVA: 0x28B1E70 Offset: 0x28B1F71 VA: 0x28B1E70
	|-Array.EmptyInternalEnumerator<Schedule>..cctor
	|
	|-RVA: 0x28B2080 Offset: 0x28B2181 VA: 0x28B2080
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>..cctor
	|
	|-RVA: 0x28B2290 Offset: 0x28B2391 VA: 0x28B2290
	|-Array.EmptyInternalEnumerator<SkillLevelUpEffectController.LevelUpInfo>..cctor
	|
	|-RVA: 0x28B24A0 Offset: 0x28B25A1 VA: 0x28B24A0
	|-Array.EmptyInternalEnumerator<SpeedData>..cctor
	|
	|-RVA: 0x26F26B0 Offset: 0x26F27B1 VA: 0x26F26B0
	|-Array.EmptyInternalEnumerator<CurveSample>..cctor
	|
	|-RVA: 0x26F28C0 Offset: 0x26F29C1 VA: 0x26F28C0
	|-Array.EmptyInternalEnumerator<StatusPageSetParameter.ElementParameterText>..cctor
	|
	|-RVA: 0x26F2AD0 Offset: 0x26F2BD1 VA: 0x26F2AD0
	|-Array.EmptyInternalEnumerator<StringFormatData.FormatData>..cctor
	|
	|-RVA: 0x26F2CE0 Offset: 0x26F2DE1 VA: 0x26F2CE0
	|-Array.EmptyInternalEnumerator<ArraySegment<ProfilerFrame>>..cctor
	|
	|-RVA: 0x26F2EF0 Offset: 0x26F2FF1 VA: 0x26F2EF0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>..cctor
	|
	|-RVA: 0x26F3100 Offset: 0x26F3201 VA: 0x26F3100
	|-Array.EmptyInternalEnumerator<ArraySegment<object>>..cctor
	|
	|-RVA: 0x26F3310 Offset: 0x26F3411 VA: 0x26F3310
	|-Array.EmptyInternalEnumerator<bool>..cctor
	|
	|-RVA: 0x26F3520 Offset: 0x26F3621 VA: 0x26F3520
	|-Array.EmptyInternalEnumerator<byte>..cctor
	|
	|-RVA: 0x26F3730 Offset: 0x26F3831 VA: 0x26F3730
	|-Array.EmptyInternalEnumerator<ByteEnum>..cctor
	|
	|-RVA: 0x26F3940 Offset: 0x26F3A41 VA: 0x26F3940
	|-Array.EmptyInternalEnumerator<char>..cctor
	|
	|-RVA: 0x26F3B50 Offset: 0x26F3C51 VA: 0x26F3B50
	|-Array.EmptyInternalEnumerator<ConcurrentQueue.Segment.Slot<object>>..cctor
	|
	|-RVA: 0x26F3D60 Offset: 0x26F3E61 VA: 0x26F3D60
	|-Array.EmptyInternalEnumerator<DictionaryEntry>..cctor
	|
	|-RVA: 0x26F3F80 Offset: 0x26F4081 VA: 0x26F3F80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<JSONDeserialization.TaskField, object>>..cctor
	|
	|-RVA: 0x26F41A0 Offset: 0x26F42A1 VA: 0x26F41A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BitVector32Int, object>>..cctor
	|
	|-RVA: 0x26F43D0 Offset: 0x26F44D1 VA: 0x26F43D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EventCheckId, object>>..cctor
	|
	|-RVA: 0x26F4610 Offset: 0x26F4711 VA: 0x26F4610
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE, object>>..cctor
	|
	|-RVA: 0x26F4840 Offset: 0x26F4941 VA: 0x26F4840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_CROP_STATE_INFO, object>>..cctor
	|
	|-RVA: 0x26F4A60 Offset: 0x26F4B61 VA: 0x26F4A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_MCROP_INFO, object>>..cctor
	|
	|-RVA: 0x26F4C80 Offset: 0x26F4D81 VA: 0x26F4C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<FarmManager.RF4_SOIL_INFO, object>>..cctor
	|
	|-RVA: 0x26F4EB0 Offset: 0x26F4FB1 VA: 0x26F4EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MonsterHutSaveData, object>>..cctor
	|
	|-RVA: 0x26F50D0 Offset: 0x26F51D1 VA: 0x26F50D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderLotterySaveParameter, object>>..cctor
	|
	|-RVA: 0x26F5300 Offset: 0x26F5401 VA: 0x26F5300
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveData, object>>..cctor
	|
	|-RVA: 0x26F5530 Offset: 0x26F5631 VA: 0x26F5530
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<OrderSaveParameter, object>>..cctor
	|
	|-RVA: 0x26F5750 Offset: 0x26F5851 VA: 0x26F5750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Parameter, object>>..cctor
	|
	|-RVA: 0x26F5970 Offset: 0x26F5A71 VA: 0x26F5970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<bool, object>>..cctor
	|
	|-RVA: 0x26F5B90 Offset: 0x26F5C91 VA: 0x26F5B90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>..cctor
	|
	|-RVA: 0x26F5DB0 Offset: 0x26F5EB1 VA: 0x26F5DB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>..cctor
	|
	|-RVA: 0x26F5FD0 Offset: 0x26F60D1 VA: 0x26F5FD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<DateTime, object>>..cctor
	|
	|-RVA: 0x26F61F0 Offset: 0x26F62F1 VA: 0x26F61F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<double, object>>..cctor
	|
	|-RVA: 0x26F6410 Offset: 0x26F6511 VA: 0x26F6410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>..cctor
	|
	|-RVA: 0x26F6630 Offset: 0x26F6731 VA: 0x26F6630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<short, object>>..cctor
	|
	|-RVA: 0x26F6850 Offset: 0x26F6951 VA: 0x26F6850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, CropDataTable>>..cctor
	|
	|-RVA: 0x26F6A70 Offset: 0x26F6B71 VA: 0x26F6A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, EffectDataTable>>..cctor
	|
	|-RVA: 0x26F6C80 Offset: 0x26F6D81 VA: 0x26F6C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, GimmickLayoutDataTable>>..cctor
	|
	|-RVA: 0x26F6EC0 Offset: 0x26F6FC1 VA: 0x26F6EC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MineTypeDataTable>>..cctor
	|
	|-RVA: 0x26F70E0 Offset: 0x26F71E1 VA: 0x26F70E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MiningDataTable>>..cctor
	|
	|-RVA: 0x26F72F0 Offset: 0x26F73F1 VA: 0x26F72F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>..cctor
	|
	|-RVA: 0x26F7500 Offset: 0x26F7601 VA: 0x26F7500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>..cctor
	|
	|-RVA: 0x26F7710 Offset: 0x26F7811 VA: 0x26F7710
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>..cctor
	|
	|-RVA: 0x26F7920 Offset: 0x26F7A21 VA: 0x26F7920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>..cctor
	|
	|-RVA: 0x26F7B40 Offset: 0x26F7C41 VA: 0x26F7B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>..cctor
	|
	|-RVA: 0x26F7D60 Offset: 0x26F7E61 VA: 0x26F7D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>..cctor
	|
	|-RVA: 0x26F7F90 Offset: 0x26F8091 VA: 0x26F7F90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>..cctor
	|
	|-RVA: 0x26F81B0 Offset: 0x26F82B1 VA: 0x26F81B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, SceneInstance>>..cctor
	|
	|-RVA: 0x26F83D0 Offset: 0x26F84D1 VA: 0x26F83D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector2Int>>..cctor
	|
	|-RVA: 0x26F85F0 Offset: 0x26F86F1 VA: 0x26F85F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Vector3>>..cctor
	|
	|-RVA: 0x26F8810 Offset: 0x26F8911 VA: 0x26F8810
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterDataTable>>..cctor
	|
	|-RVA: 0x26F8A40 Offset: 0x26F8B41 VA: 0x26F8A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, MonsterFootStepEventDataTable>>..cctor
	|
	|-RVA: 0x26F8C70 Offset: 0x26F8D71 VA: 0x26F8C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>..cctor
	|
	|-RVA: 0x26F8E80 Offset: 0x26F8F81 VA: 0x26F8E80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>..cctor
	|
	|-RVA: 0x26F90A0 Offset: 0x26F91A1 VA: 0x26F90A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, KeyValuePair<Int32Enum, int>>>..cctor
	|
	|-RVA: 0x26F92B0 Offset: 0x26F93B1 VA: 0x26F92B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>..cctor
	|
	|-RVA: 0x26F94C0 Offset: 0x26F95C1 VA: 0x26F94C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>..cctor
	|
	|-RVA: 0x26F96E0 Offset: 0x26F97E1 VA: 0x26F96E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>..cctor
	|
	|-RVA: 0x26F98F0 Offset: 0x26F99F1 VA: 0x26F98F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, float>>..cctor
	|
	|-RVA: 0x26F9B10 Offset: 0x26F9C11 VA: 0x26F9B10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<object, object>>>..cctor
	|
	|-RVA: 0x26F9D30 Offset: 0x26F9E31 VA: 0x26F9D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, ValueTuple<float, float>>>..cctor
	|
	|-RVA: 0x26F9F50 Offset: 0x26FA051 VA: 0x26F9F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, TutorialUnlockFlagData>>..cctor
	|
	|-RVA: 0x26FA170 Offset: 0x26FA271 VA: 0x26FA170
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>..cctor
	|
	|-RVA: 0x26FA390 Offset: 0x26FA491 VA: 0x26FA390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Memory<object>, object>>..cctor
	|
	|-RVA: 0x26FA5B0 Offset: 0x26FA6B1 VA: 0x26FA5B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Int32Enum>, object>>..cctor
	|
	|-RVA: 0x26FA7E0 Offset: 0x26FA8E1 VA: 0x26FA7E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Bounds>, object>>..cctor
	|
	|-RVA: 0x26FAA10 Offset: 0x26FAB11 VA: 0x26FAA10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<BoundsInt>, object>>..cctor
	|
	|-RVA: 0x26FAC30 Offset: 0x26FAD31 VA: 0x26FAC30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color32>, object>>..cctor
	|
	|-RVA: 0x26FAE60 Offset: 0x26FAF61 VA: 0x26FAE60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Color>, object>>..cctor
	|
	|-RVA: 0x26FB080 Offset: 0x26FB181 VA: 0x26FB080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientAlphaKey>, object>>..cctor
	|
	|-RVA: 0x26FB2B0 Offset: 0x26FB3B1 VA: 0x26FB2B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<GradientColorKey>, object>>..cctor
	|
	|-RVA: 0x26FB4E0 Offset: 0x26FB5E1 VA: 0x26FB4E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Keyframe>, object>>..cctor
	|
	|-RVA: 0x26FB700 Offset: 0x26FB801 VA: 0x26FB700
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<LayerMask>, object>>..cctor
	|
	|-RVA: 0x26FB940 Offset: 0x26FBA41 VA: 0x26FB940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Matrix4x4>, object>>..cctor
	|
	|-RVA: 0x26FBB70 Offset: 0x26FBC71 VA: 0x26FBB70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Quaternion>, object>>..cctor
	|
	|-RVA: 0x26FBD90 Offset: 0x26FBE91 VA: 0x26FBD90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RangeInt>, object>>..cctor
	|
	|-RVA: 0x26FBFC0 Offset: 0x26FC0C1 VA: 0x26FBFC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Rect>, object>>..cctor
	|
	|-RVA: 0x26FC1F0 Offset: 0x26FC2F1 VA: 0x26FC1F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<RectInt>, object>>..cctor
	|
	|-RVA: 0x26FC410 Offset: 0x26FC511 VA: 0x26FC410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2>, object>>..cctor
	|
	|-RVA: 0x26FC630 Offset: 0x26FC731 VA: 0x26FC630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector2Int>, object>>..cctor
	|
	|-RVA: 0x26FC850 Offset: 0x26FC951 VA: 0x26FC850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3>, object>>..cctor
	|
	|-RVA: 0x26FCA70 Offset: 0x26FCB71 VA: 0x26FCA70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector3Int>, object>>..cctor
	|
	|-RVA: 0x26FCCA0 Offset: 0x26FCDA1 VA: 0x26FCCA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Nullable<Vector4>, object>>..cctor
	|
	|-RVA: 0x26FCEC0 Offset: 0x26FCFC1 VA: 0x26FCEC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BitVector32Int>>..cctor
	|
	|-RVA: 0x26FD0F0 Offset: 0x26FD1F1 VA: 0x26FD0F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, EventCheckId>>..cctor
	|
	|-RVA: 0x26FD330 Offset: 0x26FD431 VA: 0x26FD330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE>>..cctor
	|
	|-RVA: 0x26FD560 Offset: 0x26FD661 VA: 0x26FD560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_CROP_STATE_INFO>>..cctor
	|
	|-RVA: 0x26FD780 Offset: 0x26FD881 VA: 0x26FD780
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_MCROP_INFO>>..cctor
	|
	|-RVA: 0x26FD9A0 Offset: 0x26FDAA1 VA: 0x26FD9A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, FarmManager.RF4_SOIL_INFO>>..cctor
	|
	|-RVA: 0x26FDBD0 Offset: 0x26FDCD1 VA: 0x26FDBD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, MonsterHutSaveData>>..cctor
	|
	|-RVA: 0x26FDDF0 Offset: 0x26FDEF1 VA: 0x26FDDF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderLotterySaveParameter>>..cctor
	|
	|-RVA: 0x26FE020 Offset: 0x26FE121 VA: 0x26FE020
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveData>>..cctor
	|
	|-RVA: 0x26FE250 Offset: 0x26FE351 VA: 0x26FE250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, OrderSaveParameter>>..cctor
	|
	|-RVA: 0x26FE470 Offset: 0x26FE571 VA: 0x26FE470
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Parameter>>..cctor
	|
	|-RVA: 0x26FE690 Offset: 0x26FE791 VA: 0x26FE690
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, NumberControl.ValueRange>>..cctor
	|
	|-RVA: 0x26FE8B0 Offset: 0x26FE9B1 VA: 0x26FE8B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>..cctor
	|
	|-RVA: 0x26FEAD0 Offset: 0x26FEBD1 VA: 0x26FEAD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>..cctor
	|
	|-RVA: 0x26FECF0 Offset: 0x26FEDF1 VA: 0x26FECF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, char>>..cctor
	|
	|-RVA: 0x26FEF10 Offset: 0x26FF011 VA: 0x26FEF10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, DateTime>>..cctor
	|
	|-RVA: 0x26FF130 Offset: 0x26FF231 VA: 0x26FF130
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, double>>..cctor
	|
	|-RVA: 0x26FF350 Offset: 0x26FF451 VA: 0x26FF350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, short>>..cctor
	|
	|-RVA: 0x26FF570 Offset: 0x26FF671 VA: 0x26FF570
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>..cctor
	|
	|-RVA: 0x26FF790 Offset: 0x26FF891 VA: 0x26FF790
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>..cctor
	|
	|-RVA: 0x26FF9B0 Offset: 0x26FFAB1 VA: 0x26FF9B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, long>>..cctor
	|
	|-RVA: 0x26FFBD0 Offset: 0x26FFCD1 VA: 0x26FFBD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Memory<object>>>..cctor
	|
	|-RVA: 0x26FFDF0 Offset: 0x26FFEF1 VA: 0x26FFDF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Int32Enum>>>..cctor
	|
	|-RVA: 0x2700020 Offset: 0x2700121 VA: 0x2700020
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Bounds>>>..cctor
	|
	|-RVA: 0x2700250 Offset: 0x2700351 VA: 0x2700250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<BoundsInt>>>..cctor
	|
	|-RVA: 0x2700470 Offset: 0x2700571 VA: 0x2700470
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color32>>>..cctor
	|
	|-RVA: 0x27006A0 Offset: 0x27007A1 VA: 0x27006A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Color>>>..cctor
	|
	|-RVA: 0x27008C0 Offset: 0x27009C1 VA: 0x27008C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientAlphaKey>>>..cctor
	|
	|-RVA: 0x2700AF0 Offset: 0x2700BF1 VA: 0x2700AF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<GradientColorKey>>>..cctor
	|
	|-RVA: 0x2700D20 Offset: 0x2700E21 VA: 0x2700D20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Keyframe>>>..cctor
	|
	|-RVA: 0x2700F40 Offset: 0x2701041 VA: 0x2700F40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<LayerMask>>>..cctor
	|
	|-RVA: 0x2701180 Offset: 0x2701281 VA: 0x2701180
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Matrix4x4>>>..cctor
	|
	|-RVA: 0x27013B0 Offset: 0x27014B1 VA: 0x27013B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Quaternion>>>..cctor
	|
	|-RVA: 0x27015D0 Offset: 0x27016D1 VA: 0x27015D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RangeInt>>>..cctor
	|
	|-RVA: 0x2701800 Offset: 0x2701901 VA: 0x2701800
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Rect>>>..cctor
	|
	|-RVA: 0x2701A30 Offset: 0x2701B31 VA: 0x2701A30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<RectInt>>>..cctor
	|
	|-RVA: 0x2701C50 Offset: 0x2701D51 VA: 0x2701C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2>>>..cctor
	|
	|-RVA: 0x2701E70 Offset: 0x2701F71 VA: 0x2701E70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector2Int>>>..cctor
	|
	|-RVA: 0x2702090 Offset: 0x2702191 VA: 0x2702090
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3>>>..cctor
	|
	|-RVA: 0x27022B0 Offset: 0x27023B1 VA: 0x27022B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector3Int>>>..cctor
	|
	|-RVA: 0x27024E0 Offset: 0x27025E1 VA: 0x27024E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Nullable<Vector4>>>..cctor
	|
	|-RVA: 0x2702700 Offset: 0x2702801 VA: 0x2702700
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>..cctor
	|
	|-RVA: 0x2702920 Offset: 0x2702A21 VA: 0x2702920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ReadOnlyMemory<object>>>..cctor
	|
	|-RVA: 0x2702B40 Offset: 0x2702C41 VA: 0x2702B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>..cctor
	|
	|-RVA: 0x2702D60 Offset: 0x2702E61 VA: 0x2702D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, sbyte>>..cctor
	|
	|-RVA: 0x2702F80 Offset: 0x2703081 VA: 0x2702F80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>..cctor
	|
	|-RVA: 0x27031A0 Offset: 0x27032A1 VA: 0x27031A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>..cctor
	|
	|-RVA: 0x27033C0 Offset: 0x27034C1 VA: 0x27033C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, uint>>..cctor
	|
	|-RVA: 0x27035E0 Offset: 0x27036E1 VA: 0x27035E0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ulong>>..cctor
	|
	|-RVA: 0x2703810 Offset: 0x2703911 VA: 0x2703810
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, TransitionTables>>..cctor
	|
	|-RVA: 0x2703A40 Offset: 0x2703B41 VA: 0x2703A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Bounds>>..cctor
	|
	|-RVA: 0x2703C70 Offset: 0x2703D71 VA: 0x2703C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, BoundsInt>>..cctor
	|
	|-RVA: 0x2703E90 Offset: 0x2703F91 VA: 0x2703E90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color32>>..cctor
	|
	|-RVA: 0x27040B0 Offset: 0x27041B1 VA: 0x27040B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Color>>..cctor
	|
	|-RVA: 0x27042D0 Offset: 0x27043D1 VA: 0x27042D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientAlphaKey>>..cctor
	|
	|-RVA: 0x2704500 Offset: 0x2704601 VA: 0x2704500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GradientColorKey>>..cctor
	|
	|-RVA: 0x2704730 Offset: 0x2704831 VA: 0x2704730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Keyframe>>..cctor
	|
	|-RVA: 0x2704950 Offset: 0x2704A51 VA: 0x2704950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, LayerMask>>..cctor
	|
	|-RVA: 0x2704B90 Offset: 0x2704C91 VA: 0x2704B90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Matrix4x4>>..cctor
	|
	|-RVA: 0x2704DB0 Offset: 0x2704EB1 VA: 0x2704DB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>..cctor
	|
	|-RVA: 0x2704FD0 Offset: 0x27050D1 VA: 0x2704FD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Quaternion>>..cctor
	|
	|-RVA: 0x27051F0 Offset: 0x27052F1 VA: 0x27051F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RangeInt>>..cctor
	|
	|-RVA: 0x2705410 Offset: 0x2705511 VA: 0x2705410
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Rect>>..cctor
	|
	|-RVA: 0x2705630 Offset: 0x2705731 VA: 0x2705630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, RectInt>>..cctor
	|
	|-RVA: 0x2705860 Offset: 0x2705961 VA: 0x2705860
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>..cctor
	|
	|-RVA: 0x2705A90 Offset: 0x2705B91 VA: 0x2705A90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>..cctor
	|
	|-RVA: 0x2705CB0 Offset: 0x2705DB1 VA: 0x2705CB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2>>..cctor
	|
	|-RVA: 0x2705ED0 Offset: 0x2705FD1 VA: 0x2705ED0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector2Int>>..cctor
	|
	|-RVA: 0x27060F0 Offset: 0x27061F1 VA: 0x27060F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3>>..cctor
	|
	|-RVA: 0x2706310 Offset: 0x2706411 VA: 0x2706310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector3Int>>..cctor
	|
	|-RVA: 0x2706530 Offset: 0x2706631 VA: 0x2706530
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Vector4>>..cctor
	|
	|-RVA: 0x2706750 Offset: 0x2706851 VA: 0x2706750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ReadOnlyMemory<object>, object>>..cctor
	|
	|-RVA: 0x2706970 Offset: 0x2706A71 VA: 0x2706970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RuntimeTypeHandle, KeyValuePair<int, int>>>..cctor
	|
	|-RVA: 0x2706B90 Offset: 0x2706C91 VA: 0x2706B90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>..cctor
	|
	|-RVA: 0x2706DD0 Offset: 0x2706ED1 VA: 0x2706DD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, CurveSample>>..cctor
	|
	|-RVA: 0x2706FF0 Offset: 0x27070F1 VA: 0x2706FF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<float, object>>..cctor
	|
	|-RVA: 0x2707210 Offset: 0x2707311 VA: 0x2707210
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, object>>..cctor
	|
	|-RVA: 0x2707420 Offset: 0x2707521 VA: 0x2707420
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>..cctor
	|
	|-RVA: 0x2707630 Offset: 0x2707731 VA: 0x2707630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, Int32Enum>>..cctor
	|
	|-RVA: 0x2707850 Offset: 0x2707951 VA: 0x2707850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>..cctor
	|
	|-RVA: 0x2707A70 Offset: 0x2707B71 VA: 0x2707A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>..cctor
	|
	|-RVA: 0x2707C90 Offset: 0x2707D91 VA: 0x2707C90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, int>>..cctor
	|
	|-RVA: 0x2707EC0 Offset: 0x2707FC1 VA: 0x2707EC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, CapEdge>>..cctor
	|
	|-RVA: 0x27080F0 Offset: 0x27081F1 VA: 0x27080F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>..cctor
	|
	|-RVA: 0x2708320 Offset: 0x2708421 VA: 0x2708320
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<EdgeKeyByIndex, ClippedEdge>>..cctor
	|
	|-RVA: 0x2708540 Offset: 0x2708641 VA: 0x2708540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, bool>>..cctor
	|
	|-RVA: 0x2708760 Offset: 0x2708861 VA: 0x2708760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MeshDataConnectivity.Face, object>>..cctor
	|
	|-RVA: 0x2708990 Offset: 0x2708A91 VA: 0x2708990
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Bounds, object>>..cctor
	|
	|-RVA: 0x2708BC0 Offset: 0x2708CC1 VA: 0x2708BC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<BoundsInt, object>>..cctor
	|
	|-RVA: 0x2708DE0 Offset: 0x2708EE1 VA: 0x2708DE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color, object>>..cctor
	|
	|-RVA: 0x2709000 Offset: 0x2709101 VA: 0x2709000
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Color32, object>>..cctor
	|
	|-RVA: 0x2709220 Offset: 0x2709321 VA: 0x2709220
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>..cctor
	|
	|-RVA: 0x2709440 Offset: 0x2709541 VA: 0x2709440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientAlphaKey, object>>..cctor
	|
	|-RVA: 0x2709670 Offset: 0x2709771 VA: 0x2709670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<GradientColorKey, object>>..cctor
	|
	|-RVA: 0x27098A0 Offset: 0x27099A1 VA: 0x27098A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Keyframe, object>>..cctor
	|
	|-RVA: 0x2709AC0 Offset: 0x2709BC1 VA: 0x2709AC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<LayerMask, object>>..cctor
	|
	|-RVA: 0x2709D00 Offset: 0x2709E01 VA: 0x2709D00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Matrix4x4, object>>..cctor
	|
	|-RVA: 0x2709F20 Offset: 0x270A021 VA: 0x2709F20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<IntVec3, object>>..cctor
	|
	|-RVA: 0x270A140 Offset: 0x270A241 VA: 0x270A140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Quaternion, object>>..cctor
	|
	|-RVA: 0x270A360 Offset: 0x270A461 VA: 0x270A360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RangeInt, object>>..cctor
	|
	|-RVA: 0x270A580 Offset: 0x270A681 VA: 0x270A580
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Rect, object>>..cctor
	|
	|-RVA: 0x270A7A0 Offset: 0x270A8A1 VA: 0x270A7A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<RectInt, object>>..cctor
	|
	|-RVA: 0x270A9C0 Offset: 0x270AAC1 VA: 0x270A9C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, int>>..cctor
	|
	|-RVA: 0x270ABE0 Offset: 0x270ACE1 VA: 0x270ABE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>..cctor
	|
	|-RVA: 0x270AE00 Offset: 0x270AF01 VA: 0x270AE00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2, object>>..cctor
	|
	|-RVA: 0x270B020 Offset: 0x270B121 VA: 0x270B020
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector2Int, object>>..cctor
	|
	|-RVA: 0x270B240 Offset: 0x270B341 VA: 0x270B240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, object>>..cctor
	|
	|-RVA: 0x270B460 Offset: 0x270B561 VA: 0x270B460
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3Int, object>>..cctor
	|
	|-RVA: 0x270B680 Offset: 0x270B781 VA: 0x270B680
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector4, object>>..cctor
	|
	|-RVA: 0x270B890 Offset: 0x270B991 VA: 0x270B890
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>..cctor
	|
	|-RVA: 0x28C6870 Offset: 0x28C6971 VA: 0x28C6870
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>..cctor
	|
	|-RVA: 0x28C6A80 Offset: 0x28C6B81 VA: 0x28C6A80
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>..cctor
	|
	|-RVA: 0x28C6C90 Offset: 0x28C6D91 VA: 0x28C6C90
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>..cctor
	|
	|-RVA: 0x28C6EA0 Offset: 0x28C6FA1 VA: 0x28C6EA0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Edge>>..cctor
	|
	|-RVA: 0x28C70C0 Offset: 0x28C71C1 VA: 0x28C70C0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>..cctor
	|
	|-RVA: 0x28C72E0 Offset: 0x28C73E1 VA: 0x28C72E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<JSONDeserialization.TaskField, object>>..cctor
	|
	|-RVA: 0x28C74F0 Offset: 0x28C75F1 VA: 0x28C74F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<BitVector32Int, object>>..cctor
	|
	|-RVA: 0x28C7710 Offset: 0x28C7811 VA: 0x28C7710
	|-Array.EmptyInternalEnumerator<KeyValuePair<EventCheckId, object>>..cctor
	|
	|-RVA: 0x28C7940 Offset: 0x28C7A41 VA: 0x28C7940
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE, object>>..cctor
	|
	|-RVA: 0x28C7B60 Offset: 0x28C7C61 VA: 0x28C7B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_CROP_STATE_INFO, object>>..cctor
	|
	|-RVA: 0x28C7D80 Offset: 0x28C7E81 VA: 0x28C7D80
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_MCROP_INFO, object>>..cctor
	|
	|-RVA: 0x28C7FA0 Offset: 0x28C80A1 VA: 0x28C7FA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<FarmManager.RF4_SOIL_INFO, object>>..cctor
	|
	|-RVA: 0x28C81D0 Offset: 0x28C82D1 VA: 0x28C81D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MonsterHutSaveData, object>>..cctor
	|
	|-RVA: 0x28C83F0 Offset: 0x28C84F1 VA: 0x28C83F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderLotterySaveParameter, object>>..cctor
	|
	|-RVA: 0x28C8620 Offset: 0x28C8721 VA: 0x28C8620
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveData, object>>..cctor
	|
	|-RVA: 0x28C8850 Offset: 0x28C8951 VA: 0x28C8850
	|-Array.EmptyInternalEnumerator<KeyValuePair<OrderSaveParameter, object>>..cctor
	|
	|-RVA: 0x28C8A70 Offset: 0x28C8B71 VA: 0x28C8A70
	|-Array.EmptyInternalEnumerator<KeyValuePair<Parameter, object>>..cctor
	|
	|-RVA: 0x28C8C80 Offset: 0x28C8D81 VA: 0x28C8C80
	|-Array.EmptyInternalEnumerator<KeyValuePair<bool, object>>..cctor
	|
	|-RVA: 0x28C8E90 Offset: 0x28C8F91 VA: 0x28C8E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>..cctor
	|
	|-RVA: 0x28C90A0 Offset: 0x28C91A1 VA: 0x28C90A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>..cctor
	|
	|-RVA: 0x28C92B0 Offset: 0x28C93B1 VA: 0x28C92B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>..cctor
	|
	|-RVA: 0x28C94C0 Offset: 0x28C95C1 VA: 0x28C94C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<double, object>>..cctor
	|
	|-RVA: 0x28C96E0 Offset: 0x28C97E1 VA: 0x28C96E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>..cctor
	|
	|-RVA: 0x28C98F0 Offset: 0x28C99F1 VA: 0x28C98F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<short, object>>..cctor
	|
	|-RVA: 0x28C9B10 Offset: 0x28C9C11 VA: 0x28C9B10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, CropDataTable>>..cctor
	|
	|-RVA: 0x28C9D30 Offset: 0x28C9E31 VA: 0x28C9D30
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, EffectDataTable>>..cctor
	|
	|-RVA: 0x28C9F40 Offset: 0x28CA041 VA: 0x28C9F40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, GimmickLayoutDataTable>>..cctor
	|
	|-RVA: 0x28CA180 Offset: 0x28CA281 VA: 0x28CA180
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MineTypeDataTable>>..cctor
	|
	|-RVA: 0x28CA3A0 Offset: 0x28CA4A1 VA: 0x28CA3A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MiningDataTable>>..cctor
	|
	|-RVA: 0x28CA5B0 Offset: 0x28CA6B1 VA: 0x28CA5B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>..cctor
	|
	|-RVA: 0x28CA7C0 Offset: 0x28CA8C1 VA: 0x28CA7C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>..cctor
	|
	|-RVA: 0x28CA9D0 Offset: 0x28CAAD1 VA: 0x28CA9D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>..cctor
	|
	|-RVA: 0x28CABE0 Offset: 0x28CACE1 VA: 0x28CABE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>..cctor
	|
	|-RVA: 0x28CADF0 Offset: 0x28CAEF1 VA: 0x28CADF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>..cctor
	|
	|-RVA: 0x28CB000 Offset: 0x28CB101 VA: 0x28CB000
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>..cctor
	|
	|-RVA: 0x28CB230 Offset: 0x28CB331 VA: 0x28CB230
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>..cctor
	|
	|-RVA: 0x28CB450 Offset: 0x28CB551 VA: 0x28CB450
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, SceneInstance>>..cctor
	|
	|-RVA: 0x28CB660 Offset: 0x28CB761 VA: 0x28CB660
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector2Int>>..cctor
	|
	|-RVA: 0x28CB870 Offset: 0x28CB971 VA: 0x28CB870
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Vector3>>..cctor
	|
	|-RVA: 0x28CBA90 Offset: 0x28CBB91 VA: 0x28CBA90
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterDataTable>>..cctor
	|
	|-RVA: 0x28CBCC0 Offset: 0x28CBDC1 VA: 0x28CBCC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, MonsterFootStepEventDataTable>>..cctor
	|
	|-RVA: 0x28CBEE0 Offset: 0x28CBFE1 VA: 0x28CBEE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, PartnerNPCWeaponBehaviorDataTable>>..cctor
	|
	|-RVA: 0x28CC0F0 Offset: 0x28CC1F1 VA: 0x28CC0F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>..cctor
	|
	|-RVA: 0x28CC300 Offset: 0x28CC401 VA: 0x28CC300
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, KeyValuePair<Int32Enum, int>>>..cctor
	|
	|-RVA: 0x28CC510 Offset: 0x28CC611 VA: 0x28CC510
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>..cctor
	|
	|-RVA: 0x28CC720 Offset: 0x28CC821 VA: 0x28CC720
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>..cctor
	|
	|-RVA: 0x28CC930 Offset: 0x28CCA31 VA: 0x28CC930
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>..cctor
	|
	|-RVA: 0x28CCB40 Offset: 0x28CCC41 VA: 0x28CCB40
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, float>>..cctor
	|
	|-RVA: 0x28CCD60 Offset: 0x28CCE61 VA: 0x28CCD60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<object, object>>>..cctor
	|
	|-RVA: 0x28CCF70 Offset: 0x28CD071 VA: 0x28CCF70
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, ValueTuple<float, float>>>..cctor
	|
	|-RVA: 0x28CD180 Offset: 0x28CD281 VA: 0x28CD180
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, TutorialUnlockFlagData>>..cctor
	|
	|-RVA: 0x28CD390 Offset: 0x28CD491 VA: 0x28CD390
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>..cctor
	|
	|-RVA: 0x28CD5B0 Offset: 0x28CD6B1 VA: 0x28CD5B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Memory<object>, object>>..cctor
	|
	|-RVA: 0x28CD7C0 Offset: 0x28CD8C1 VA: 0x28CD7C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Int32Enum>, object>>..cctor
	|
	|-RVA: 0x28CD9F0 Offset: 0x28CDAF1 VA: 0x28CD9F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Bounds>, object>>..cctor
	|
	|-RVA: 0x28CDC20 Offset: 0x28CDD21 VA: 0x28CDC20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<BoundsInt>, object>>..cctor
	|
	|-RVA: 0x28CDE30 Offset: 0x28CDF31 VA: 0x28CDE30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color32>, object>>..cctor
	|
	|-RVA: 0x28CE050 Offset: 0x28CE151 VA: 0x28CE050
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Color>, object>>..cctor
	|
	|-RVA: 0x28CE270 Offset: 0x28CE371 VA: 0x28CE270
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientAlphaKey>, object>>..cctor
	|
	|-RVA: 0x28CE490 Offset: 0x28CE591 VA: 0x28CE490
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<GradientColorKey>, object>>..cctor
	|
	|-RVA: 0x28CE6C0 Offset: 0x28CE7C1 VA: 0x28CE6C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Keyframe>, object>>..cctor
	|
	|-RVA: 0x28CE8D0 Offset: 0x28CE9D1 VA: 0x28CE8D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<LayerMask>, object>>..cctor
	|
	|-RVA: 0x28CEB10 Offset: 0x28CEC11 VA: 0x28CEB10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Matrix4x4>, object>>..cctor
	|
	|-RVA: 0x28CED30 Offset: 0x28CEE31 VA: 0x28CED30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Quaternion>, object>>..cctor
	|
	|-RVA: 0x28CEF50 Offset: 0x28CF051 VA: 0x28CEF50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RangeInt>, object>>..cctor
	|
	|-RVA: 0x28CF170 Offset: 0x28CF271 VA: 0x28CF170
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Rect>, object>>..cctor
	|
	|-RVA: 0x28CF390 Offset: 0x28CF491 VA: 0x28CF390
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<RectInt>, object>>..cctor
	|
	|-RVA: 0x28CF5B0 Offset: 0x28CF6B1 VA: 0x28CF5B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2>, object>>..cctor
	|
	|-RVA: 0x28CF7D0 Offset: 0x28CF8D1 VA: 0x28CF7D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector2Int>, object>>..cctor
	|
	|-RVA: 0x28CF9F0 Offset: 0x28CFAF1 VA: 0x28CF9F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3>, object>>..cctor
	|
	|-RVA: 0x28CFC10 Offset: 0x28CFD11 VA: 0x28CFC10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector3Int>, object>>..cctor
	|
	|-RVA: 0x28CFE30 Offset: 0x28CFF31 VA: 0x28CFE30
	|-Array.EmptyInternalEnumerator<KeyValuePair<Nullable<Vector4>, object>>..cctor
	|
	|-RVA: 0x28D0040 Offset: 0x28D0141 VA: 0x28D0040
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BitVector32Int>>..cctor
	|
	|-RVA: 0x28D0260 Offset: 0x28D0361 VA: 0x28D0260
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, EventCheckId>>..cctor
	|
	|-RVA: 0x28D0490 Offset: 0x28D0591 VA: 0x28D0490
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE>>..cctor
	|
	|-RVA: 0x28D06B0 Offset: 0x28D07B1 VA: 0x28D06B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_CROP_STATE_INFO>>..cctor
	|
	|-RVA: 0x28D08D0 Offset: 0x28D09D1 VA: 0x28D08D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_MCROP_INFO>>..cctor
	|
	|-RVA: 0x28D0AF0 Offset: 0x28D0BF1 VA: 0x28D0AF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, FarmManager.RF4_SOIL_INFO>>..cctor
	|
	|-RVA: 0x28D0D20 Offset: 0x28D0E21 VA: 0x28D0D20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, MonsterHutSaveData>>..cctor
	|
	|-RVA: 0x28D0F40 Offset: 0x28D1041 VA: 0x28D0F40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderLotterySaveParameter>>..cctor
	|
	|-RVA: 0x28D1170 Offset: 0x28D1271 VA: 0x28D1170
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveData>>..cctor
	|
	|-RVA: 0x28D13A0 Offset: 0x28D14A1 VA: 0x28D13A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, OrderSaveParameter>>..cctor
	|
	|-RVA: 0x28D15C0 Offset: 0x28D16C1 VA: 0x28D15C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Parameter>>..cctor
	|
	|-RVA: 0x28D17E0 Offset: 0x28D18E1 VA: 0x28D17E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, NumberControl.ValueRange>>..cctor
	|
	|-RVA: 0x28D19F0 Offset: 0x28D1AF1 VA: 0x28D19F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>..cctor
	|
	|-RVA: 0x28D1C00 Offset: 0x28D1D01 VA: 0x28D1C00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>..cctor
	|
	|-RVA: 0x28D1E10 Offset: 0x28D1F11 VA: 0x28D1E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, char>>..cctor
	|
	|-RVA: 0x28D2020 Offset: 0x28D2121 VA: 0x28D2020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, DateTime>>..cctor
	|
	|-RVA: 0x28D2230 Offset: 0x28D2331 VA: 0x28D2230
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, double>>..cctor
	|
	|-RVA: 0x28D2440 Offset: 0x28D2541 VA: 0x28D2440
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, short>>..cctor
	|
	|-RVA: 0x28D2650 Offset: 0x28D2751 VA: 0x28D2650
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>..cctor
	|
	|-RVA: 0x28D2860 Offset: 0x28D2961 VA: 0x28D2860
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>..cctor
	|
	|-RVA: 0x28D2A70 Offset: 0x28D2B71 VA: 0x28D2A70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, long>>..cctor
	|
	|-RVA: 0x28D2C90 Offset: 0x28D2D91 VA: 0x28D2C90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Memory<object>>>..cctor
	|
	|-RVA: 0x28D2EA0 Offset: 0x28D2FA1 VA: 0x28D2EA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Int32Enum>>>..cctor
	|
	|-RVA: 0x28D30D0 Offset: 0x28D31D1 VA: 0x28D30D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Bounds>>>..cctor
	|
	|-RVA: 0x28D3300 Offset: 0x28D3401 VA: 0x28D3300
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<BoundsInt>>>..cctor
	|
	|-RVA: 0x28D3510 Offset: 0x28D3611 VA: 0x28D3510
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color32>>>..cctor
	|
	|-RVA: 0x28D3730 Offset: 0x28D3831 VA: 0x28D3730
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Color>>>..cctor
	|
	|-RVA: 0x28D3950 Offset: 0x28D3A51 VA: 0x28D3950
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientAlphaKey>>>..cctor
	|
	|-RVA: 0x28D3B70 Offset: 0x28D3C71 VA: 0x28D3B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<GradientColorKey>>>..cctor
	|
	|-RVA: 0x28D3DA0 Offset: 0x28D3EA1 VA: 0x28D3DA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Keyframe>>>..cctor
	|
	|-RVA: 0x28D3FB0 Offset: 0x28D40B1 VA: 0x28D3FB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<LayerMask>>>..cctor
	|
	|-RVA: 0x28D41F0 Offset: 0x28D42F1 VA: 0x28D41F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Matrix4x4>>>..cctor
	|
	|-RVA: 0x28D4410 Offset: 0x28D4511 VA: 0x28D4410
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Quaternion>>>..cctor
	|
	|-RVA: 0x28D4630 Offset: 0x28D4731 VA: 0x28D4630
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RangeInt>>>..cctor
	|
	|-RVA: 0x28D4850 Offset: 0x28D4951 VA: 0x28D4850
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Rect>>>..cctor
	|
	|-RVA: 0x28D4A70 Offset: 0x28D4B71 VA: 0x28D4A70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<RectInt>>>..cctor
	|
	|-RVA: 0x28D4C90 Offset: 0x28D4D91 VA: 0x28D4C90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2>>>..cctor
	|
	|-RVA: 0x28D4EB0 Offset: 0x28D4FB1 VA: 0x28D4EB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector2Int>>>..cctor
	|
	|-RVA: 0x28D50D0 Offset: 0x28D51D1 VA: 0x28D50D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3>>>..cctor
	|
	|-RVA: 0x28D52F0 Offset: 0x28D53F1 VA: 0x28D52F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector3Int>>>..cctor
	|
	|-RVA: 0x28D5510 Offset: 0x28D5611 VA: 0x28D5510
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Nullable<Vector4>>>..cctor
	|
	|-RVA: 0x28D5720 Offset: 0x28D5821 VA: 0x28D5720
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x28D5940 Offset: 0x28D5A41 VA: 0x28D5940
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ReadOnlyMemory<object>>>..cctor
	|
	|-RVA: 0x28D5B60 Offset: 0x28D5C61 VA: 0x28D5B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>..cctor
	|
	|-RVA: 0x28D5D70 Offset: 0x28D5E71 VA: 0x28D5D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, sbyte>>..cctor
	|
	|-RVA: 0x28D5F80 Offset: 0x28D6081 VA: 0x28D5F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>..cctor
	|
	|-RVA: 0x28D6190 Offset: 0x28D6291 VA: 0x28D6190
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>..cctor
	|
	|-RVA: 0x28D63A0 Offset: 0x28D64A1 VA: 0x28D63A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, uint>>..cctor
	|
	|-RVA: 0x28D65B0 Offset: 0x28D66B1 VA: 0x28D65B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ulong>>..cctor
	|
	|-RVA: 0x28D67E0 Offset: 0x28D68E1 VA: 0x28D67E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, TransitionTables>>..cctor
	|
	|-RVA: 0x28D6A00 Offset: 0x28D6B01 VA: 0x28D6A00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Bounds>>..cctor
	|
	|-RVA: 0x28D6C20 Offset: 0x28D6D21 VA: 0x28D6C20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, BoundsInt>>..cctor
	|
	|-RVA: 0x28D6E30 Offset: 0x28D6F31 VA: 0x28D6E30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color32>>..cctor
	|
	|-RVA: 0x28D7050 Offset: 0x28D7151 VA: 0x28D7050
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Color>>..cctor
	|
	|-RVA: 0x28D7260 Offset: 0x28D7361 VA: 0x28D7260
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientAlphaKey>>..cctor
	|
	|-RVA: 0x28D7480 Offset: 0x28D7581 VA: 0x28D7480
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GradientColorKey>>..cctor
	|
	|-RVA: 0x28D76B0 Offset: 0x28D77B1 VA: 0x28D76B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Keyframe>>..cctor
	|
	|-RVA: 0x28D78C0 Offset: 0x28D79C1 VA: 0x28D78C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, LayerMask>>..cctor
	|
	|-RVA: 0x28D7B00 Offset: 0x28D7C01 VA: 0x28D7B00
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Matrix4x4>>..cctor
	|
	|-RVA: 0x28D7D20 Offset: 0x28D7E21 VA: 0x28D7D20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>..cctor
	|
	|-RVA: 0x28D7F40 Offset: 0x28D8041 VA: 0x28D7F40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Quaternion>>..cctor
	|
	|-RVA: 0x28D8150 Offset: 0x28D8251 VA: 0x28D8150
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RangeInt>>..cctor
	|
	|-RVA: 0x28D8370 Offset: 0x28D8471 VA: 0x28D8370
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Rect>>..cctor
	|
	|-RVA: 0x28D8590 Offset: 0x28D8691 VA: 0x28D8590
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, RectInt>>..cctor
	|
	|-RVA: 0x28D87B0 Offset: 0x28D88B1 VA: 0x28D87B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>..cctor
	|
	|-RVA: 0x28D89D0 Offset: 0x28D8AD1 VA: 0x28D89D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>..cctor
	|
	|-RVA: 0x28D8BE0 Offset: 0x28D8CE1 VA: 0x28D8BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2>>..cctor
	|
	|-RVA: 0x28D8DF0 Offset: 0x28D8EF1 VA: 0x28D8DF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector2Int>>..cctor
	|
	|-RVA: 0x28D9010 Offset: 0x28D9111 VA: 0x28D9010
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3>>..cctor
	|
	|-RVA: 0x28D9230 Offset: 0x28D9331 VA: 0x28D9230
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector3Int>>..cctor
	|
	|-RVA: 0x28D9450 Offset: 0x28D9551 VA: 0x28D9450
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Vector4>>..cctor
	|
	|-RVA: 0x28D9670 Offset: 0x28D9771 VA: 0x28D9670
	|-Array.EmptyInternalEnumerator<KeyValuePair<ReadOnlyMemory<object>, object>>..cctor
	|
	|-RVA: 0x28D9880 Offset: 0x28D9981 VA: 0x28D9880
	|-Array.EmptyInternalEnumerator<KeyValuePair<RuntimeTypeHandle, KeyValuePair<int, int>>>..cctor
	|
	|-RVA: 0x28D9A90 Offset: 0x28D9B91 VA: 0x28D9A90
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>..cctor
	|
	|-RVA: 0x28D9CD0 Offset: 0x28D9DD1 VA: 0x28D9CD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, CurveSample>>..cctor
	|
	|-RVA: 0x28D9EE0 Offset: 0x28D9FE1 VA: 0x28D9EE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<float, object>>..cctor
	|
	|-RVA: 0x28DA0F0 Offset: 0x28DA1F1 VA: 0x28DA0F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, object>>..cctor
	|
	|-RVA: 0x28DA300 Offset: 0x28DA401 VA: 0x28DA300
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>..cctor
	|
	|-RVA: 0x28DA510 Offset: 0x28DA611 VA: 0x28DA510
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, Int32Enum>>..cctor
	|
	|-RVA: 0x28DA720 Offset: 0x28DA821 VA: 0x28DA720
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>..cctor
	|
	|-RVA: 0x28DA930 Offset: 0x28DAA31 VA: 0x28DA930
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>..cctor
	|
	|-RVA: 0x28DAB40 Offset: 0x28DAC41 VA: 0x28DAB40
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, int>>..cctor
	|
	|-RVA: 0x28DAD70 Offset: 0x28DAE71 VA: 0x28DAD70
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, CapEdge>>..cctor
	|
	|-RVA: 0x28DAFA0 Offset: 0x28DB0A1 VA: 0x28DAFA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>>..cctor
	|
	|-RVA: 0x28DB1D0 Offset: 0x28DB2D1 VA: 0x28DB1D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<EdgeKeyByIndex, ClippedEdge>>..cctor
	|
	|-RVA: 0x28DB3E0 Offset: 0x28DB4E1 VA: 0x28DB3E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, bool>>..cctor
	|
	|-RVA: 0x28DB5F0 Offset: 0x28DB6F1 VA: 0x28DB5F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MeshDataConnectivity.Face, object>>..cctor
	|
	|-RVA: 0x28DB810 Offset: 0x28DB911 VA: 0x28DB810
	|-Array.EmptyInternalEnumerator<KeyValuePair<Bounds, object>>..cctor
	|
	|-RVA: 0x28DBA30 Offset: 0x28DBB31 VA: 0x28DBA30
	|-Array.EmptyInternalEnumerator<KeyValuePair<BoundsInt, object>>..cctor
	|
	|-RVA: 0x28DBC50 Offset: 0x28DBD51 VA: 0x28DBC50
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color, object>>..cctor
	|
	|-RVA: 0x28DBE60 Offset: 0x28DBF61 VA: 0x28DBE60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Color32, object>>..cctor
	|
	|-RVA: 0x28DC070 Offset: 0x28DC171 VA: 0x28DC070
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>..cctor
	|
	|-RVA: 0x28DC280 Offset: 0x28DC381 VA: 0x28DC280
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientAlphaKey, object>>..cctor
	|
	|-RVA: 0x28DC4A0 Offset: 0x28DC5A1 VA: 0x28DC4A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<GradientColorKey, object>>..cctor
	|
	|-RVA: 0x28DC6D0 Offset: 0x28DC7D1 VA: 0x28DC6D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Keyframe, object>>..cctor
	|
	|-RVA: 0x28DC8E0 Offset: 0x28DC9E1 VA: 0x28DC8E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<LayerMask, object>>..cctor
	|
	|-RVA: 0x28DCB20 Offset: 0x28DCC21 VA: 0x28DCB20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Matrix4x4, object>>..cctor
	|
	|-RVA: 0x28DCD40 Offset: 0x28DCE41 VA: 0x28DCD40
	|-Array.EmptyInternalEnumerator<KeyValuePair<IntVec3, object>>..cctor
	|
	|-RVA: 0x28DCF60 Offset: 0x28DD061 VA: 0x28DCF60
	|-Array.EmptyInternalEnumerator<KeyValuePair<Quaternion, object>>..cctor
	|
	|-RVA: 0x28DD170 Offset: 0x28DD271 VA: 0x28DD170
	|-Array.EmptyInternalEnumerator<KeyValuePair<RangeInt, object>>..cctor
	|
	|-RVA: 0x28DD390 Offset: 0x28DD491 VA: 0x28DD390
	|-Array.EmptyInternalEnumerator<KeyValuePair<Rect, object>>..cctor
	|
	|-RVA: 0x28DD5B0 Offset: 0x28DD6B1 VA: 0x28DD5B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<RectInt, object>>..cctor
	|
	|-RVA: 0x28DD7C0 Offset: 0x28DD8C1 VA: 0x28DD7C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, int>>..cctor
	|
	|-RVA: 0x28DD9D0 Offset: 0x28DDAD1 VA: 0x28DD9D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>..cctor
	|
	|-RVA: 0x28DDBE0 Offset: 0x28DDCE1 VA: 0x28DDBE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2, object>>..cctor
	|
	|-RVA: 0x28DDDF0 Offset: 0x28DDEF1 VA: 0x28DDDF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector2Int, object>>..cctor
	|
	|-RVA: 0x28DE010 Offset: 0x28DE111 VA: 0x28DE010
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, object>>..cctor
	|
	|-RVA: 0x28DE230 Offset: 0x28DE331 VA: 0x28DE230
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3Int, object>>..cctor
	|
	|-RVA: 0x28DE450 Offset: 0x28DE551 VA: 0x28DE450
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector4, object>>..cctor
	|
	|-RVA: 0x28DE670 Offset: 0x28DE771 VA: 0x28DE670
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>..cctor
	|
	|-RVA: 0x28DE880 Offset: 0x28DE981 VA: 0x28DE880
	|-Array.EmptyInternalEnumerator<DateTime>..cctor
	|
	|-RVA: 0x28DEA90 Offset: 0x28DEB91 VA: 0x28DEA90
	|-Array.EmptyInternalEnumerator<DateTimeOffset>..cctor
	|
	|-RVA: 0x28DECA0 Offset: 0x28DEDA1 VA: 0x28DECA0
	|-Array.EmptyInternalEnumerator<Decimal>..cctor
	|
	|-RVA: 0x28DEEB0 Offset: 0x28DEFB1 VA: 0x28DEEB0
	|-Array.EmptyInternalEnumerator<double>..cctor
	|
	|-RVA: 0x28DF0C0 Offset: 0x28DF1C1 VA: 0x28DF0C0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>..cctor
	|
	|-RVA: 0x28DF2D0 Offset: 0x28DF3D1 VA: 0x28DF2D0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>..cctor
	|
	|-RVA: 0x273E910 Offset: 0x273EA11 VA: 0x273E910
	|-Array.EmptyInternalEnumerator<Guid>..cctor
	|
	|-RVA: 0x273EB20 Offset: 0x273EC21 VA: 0x273EB20
	|-Array.EmptyInternalEnumerator<short>..cctor
	|
	|-RVA: 0x273ED30 Offset: 0x273EE31 VA: 0x273ED30
	|-Array.EmptyInternalEnumerator<int>..cctor
	|
	|-RVA: 0x273EF40 Offset: 0x273F041 VA: 0x273EF40
	|-Array.EmptyInternalEnumerator<Int32Enum>..cctor
	|
	|-RVA: 0x273F150 Offset: 0x273F251 VA: 0x273F150
	|-Array.EmptyInternalEnumerator<long>..cctor
	|
	|-RVA: 0x273F360 Offset: 0x273F461 VA: 0x273F360
	|-Array.EmptyInternalEnumerator<IntPtr>..cctor
	|
	|-RVA: 0x273F570 Offset: 0x273F671 VA: 0x273F570
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>..cctor
	|
	|-RVA: 0x273F780 Offset: 0x273F881 VA: 0x273F780
	|-Array.EmptyInternalEnumerator<LocalDefinition>..cctor
	|
	|-RVA: 0x273F990 Offset: 0x273FA91 VA: 0x273F990
	|-Array.EmptyInternalEnumerator<RuntimeLabel>..cctor
	|
	|-RVA: 0x273FBA0 Offset: 0x273FCA1 VA: 0x273FBA0
	|-Array.EmptyInternalEnumerator<Set.Slot<int>>..cctor
	|
	|-RVA: 0x273FDC0 Offset: 0x273FEC1 VA: 0x273FDC0
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>..cctor
	|
	|-RVA: 0x273FFD0 Offset: 0x27400D1 VA: 0x273FFD0
	|-Array.EmptyInternalEnumerator<Memory<object>>..cctor
	|
	|-RVA: 0x27401E0 Offset: 0x27402E1 VA: 0x27401E0
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>..cctor
	|
	|-RVA: 0x27403F0 Offset: 0x27404F1 VA: 0x27403F0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>..cctor
	|
	|-RVA: 0x2740600 Offset: 0x2740701 VA: 0x2740600
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>..cctor
	|
	|-RVA: 0x2740830 Offset: 0x2740931 VA: 0x2740830
	|-Array.EmptyInternalEnumerator<Nullable<ReadOnlySequence<byte>>>..cctor
	|
	|-RVA: 0x2740A40 Offset: 0x2740B41 VA: 0x2740A40
	|-Array.EmptyInternalEnumerator<Nullable<Int32Enum>>..cctor
	|
	|-RVA: 0x2740C70 Offset: 0x2740D71 VA: 0x2740C70
	|-Array.EmptyInternalEnumerator<Nullable<Bounds>>..cctor
	|
	|-RVA: 0x2740EA0 Offset: 0x2740FA1 VA: 0x2740EA0
	|-Array.EmptyInternalEnumerator<Nullable<BoundsInt>>..cctor
	|
	|-RVA: 0x27410B0 Offset: 0x27411B1 VA: 0x27410B0
	|-Array.EmptyInternalEnumerator<Nullable<Color32>>..cctor
	|
	|-RVA: 0x27412D0 Offset: 0x27413D1 VA: 0x27412D0
	|-Array.EmptyInternalEnumerator<Nullable<Color>>..cctor
	|
	|-RVA: 0x27414E0 Offset: 0x27415E1 VA: 0x27414E0
	|-Array.EmptyInternalEnumerator<Nullable<GradientAlphaKey>>..cctor
	|
	|-RVA: 0x2741700 Offset: 0x2741801 VA: 0x2741700
	|-Array.EmptyInternalEnumerator<Nullable<GradientColorKey>>..cctor
	|
	|-RVA: 0x2741920 Offset: 0x2741A21 VA: 0x2741920
	|-Array.EmptyInternalEnumerator<Nullable<Keyframe>>..cctor
	|
	|-RVA: 0x2741B30 Offset: 0x2741C31 VA: 0x2741B30
	|-Array.EmptyInternalEnumerator<Nullable<LayerMask>>..cctor
	|
	|-RVA: 0x2741D70 Offset: 0x2741E71 VA: 0x2741D70
	|-Array.EmptyInternalEnumerator<Nullable<Matrix4x4>>..cctor
	|
	|-RVA: 0x2741F90 Offset: 0x2742091 VA: 0x2741F90
	|-Array.EmptyInternalEnumerator<Nullable<Quaternion>>..cctor
	|
	|-RVA: 0x27421A0 Offset: 0x27422A1 VA: 0x27421A0
	|-Array.EmptyInternalEnumerator<Nullable<RangeInt>>..cctor
	|
	|-RVA: 0x27423C0 Offset: 0x27424C1 VA: 0x27423C0
	|-Array.EmptyInternalEnumerator<Nullable<Rect>>..cctor
	|
	|-RVA: 0x27425E0 Offset: 0x27426E1 VA: 0x27425E0
	|-Array.EmptyInternalEnumerator<Nullable<RectInt>>..cctor
	|
	|-RVA: 0x27427F0 Offset: 0x27428F1 VA: 0x27427F0
	|-Array.EmptyInternalEnumerator<Nullable<Vector2>>..cctor
	|
	|-RVA: 0x2742A00 Offset: 0x2742B01 VA: 0x2742A00
	|-Array.EmptyInternalEnumerator<Nullable<Vector2Int>>..cctor
	|
	|-RVA: 0x2742C10 Offset: 0x2742D11 VA: 0x2742C10
	|-Array.EmptyInternalEnumerator<Nullable<Vector3>>..cctor
	|
	|-RVA: 0x2742E20 Offset: 0x2742F21 VA: 0x2742E20
	|-Array.EmptyInternalEnumerator<Nullable<Vector3Int>>..cctor
	|
	|-RVA: 0x2743040 Offset: 0x2743141 VA: 0x2743040
	|-Array.EmptyInternalEnumerator<Nullable<Vector4>>..cctor
	|
	|-RVA: 0x2743210 Offset: 0x2743311 VA: 0x2743210
	|-Array.EmptyInternalEnumerator<object>..cctor
	|
	|-RVA: 0x2743420 Offset: 0x2743521 VA: 0x2743420
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>..cctor
	|
	|-RVA: 0x2743630 Offset: 0x2743731 VA: 0x2743630
	|-Array.EmptyInternalEnumerator<ReadOnlyMemory<object>>..cctor
	|
	|-RVA: 0x2743850 Offset: 0x2743951 VA: 0x2743850
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>..cctor
	|
	|-RVA: 0x2743A60 Offset: 0x2743B61 VA: 0x2743A60
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>..cctor
	|
	|-RVA: 0x2743C70 Offset: 0x2743D71 VA: 0x2743C70
	|-Array.EmptyInternalEnumerator<Label>..cctor
	|
	|-RVA: 0x2743E80 Offset: 0x2743F81 VA: 0x2743E80
	|-Array.EmptyInternalEnumerator<ParameterModifier>..cctor
	|
	|-RVA: 0x2744090 Offset: 0x2744191 VA: 0x2744090
	|-Array.EmptyInternalEnumerator<ResourceLocator>..cctor
	|
	|-RVA: 0x27442A0 Offset: 0x27443A1 VA: 0x27442A0
	|-Array.EmptyInternalEnumerator<Ephemeron>..cctor
	|
	|-RVA: 0x27444B0 Offset: 0x27445B1 VA: 0x27444B0
	|-Array.EmptyInternalEnumerator<GCHandle>..cctor
	|
	|-RVA: 0x27446C0 Offset: 0x27447C1 VA: 0x27446C0
	|-Array.EmptyInternalEnumerator<RuntimeTypeHandle>..cctor
	|
	|-RVA: 0x27448D0 Offset: 0x27449D1 VA: 0x27448D0
	|-Array.EmptyInternalEnumerator<sbyte>..cctor
	|
	|-RVA: 0x2744AE0 Offset: 0x2744BE1 VA: 0x2744AE0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>..cctor
	|
	|-RVA: 0x2744CF0 Offset: 0x2744DF1 VA: 0x2744CF0
	|-Array.EmptyInternalEnumerator<float>..cctor
	|
	|-RVA: 0x2744F00 Offset: 0x2745001 VA: 0x2744F00
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>..cctor
	|
	|-RVA: 0x2745120 Offset: 0x2745221 VA: 0x2745120
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>..cctor
	|
	|-RVA: 0x2745330 Offset: 0x2745431 VA: 0x2745330
	|-Array.EmptyInternalEnumerator<ThreadLocal.LinkedSlotVolatile<object>>..cctor
	|
	|-RVA: 0x2745540 Offset: 0x2745641 VA: 0x2745540
	|-Array.EmptyInternalEnumerator<TimeSpan>..cctor
	|
	|-RVA: 0x2745750 Offset: 0x2745851 VA: 0x2745750
	|-Array.EmptyInternalEnumerator<ushort>..cctor
	|
	|-RVA: 0x2745960 Offset: 0x2745A61 VA: 0x2745960
	|-Array.EmptyInternalEnumerator<UInt16Enum>..cctor
	|
	|-RVA: 0x2745B70 Offset: 0x2745C71 VA: 0x2745B70
	|-Array.EmptyInternalEnumerator<uint>..cctor
	|
	|-RVA: 0x2745D80 Offset: 0x2745E81 VA: 0x2745D80
	|-Array.EmptyInternalEnumerator<UInt32Enum>..cctor
	|
	|-RVA: 0x2745F90 Offset: 0x2746091 VA: 0x2745F90
	|-Array.EmptyInternalEnumerator<ulong>..cctor
	|
	|-RVA: 0x27461A0 Offset: 0x27462A1 VA: 0x27461A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Int32Enum>>..cctor
	|
	|-RVA: 0x27463B0 Offset: 0x27464B1 VA: 0x27463B0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>..cctor
	|
	|-RVA: 0x27465C0 Offset: 0x27466C1 VA: 0x27465C0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, object>>..cctor
	|
	|-RVA: 0x27467D0 Offset: 0x27468D1 VA: 0x27467D0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum>>..cctor
	|
	|-RVA: 0x27469E0 Offset: 0x2746AE1 VA: 0x27469E0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>..cctor
	|
	|-RVA: 0x2746BF0 Offset: 0x2746CF1 VA: 0x2746BF0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>..cctor
	|
	|-RVA: 0x2746E00 Offset: 0x2746F01 VA: 0x2746E00
	|-Array.EmptyInternalEnumerator<ValueTuple<float, object>>..cctor
	|
	|-RVA: 0x2747010 Offset: 0x2747111 VA: 0x2747010
	|-Array.EmptyInternalEnumerator<ValueTuple<float, float>>..cctor
	|
	|-RVA: 0x2747240 Offset: 0x2747341 VA: 0x2747240
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, Quaternion>>..cctor
	|
	|-RVA: 0x2747450 Offset: 0x2747551 VA: 0x2747450
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..cctor
	|
	|-RVA: 0x2747670 Offset: 0x2747771 VA: 0x2747670
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3>>..cctor
	|
	|-RVA: 0x2747890 Offset: 0x2747991 VA: 0x2747890
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, Vector3, float>>..cctor
	|
	|-RVA: 0x2747AC0 Offset: 0x2747BC1 VA: 0x2747AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object, Vector3, Quaternion, object, object>>..cctor
	|
	|-RVA: 0x2747CE0 Offset: 0x2747DE1 VA: 0x2747CE0
	|-Array.EmptyInternalEnumerator<HighlightState>..cctor
	|
	|-RVA: 0x2747F10 Offset: 0x2748011 VA: 0x2747F10
	|-Array.EmptyInternalEnumerator<MaterialReference>..cctor
	|
	|-RVA: 0x2748130 Offset: 0x2748231 VA: 0x2748130
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>..cctor
	|
	|-RVA: 0x2748360 Offset: 0x2748461 VA: 0x2748360
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>..cctor
	|
	|-RVA: 0x2748580 Offset: 0x2748681 VA: 0x2748580
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>..cctor
	|
	|-RVA: 0x2748790 Offset: 0x2748891 VA: 0x2748790
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>..cctor
	|
	|-RVA: 0x27489E0 Offset: 0x2748AE1 VA: 0x27489E0
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>..cctor
	|
	|-RVA: 0x2748C10 Offset: 0x2748D11 VA: 0x2748C10
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>..cctor
	|
	|-RVA: 0x2748E50 Offset: 0x2748F51 VA: 0x2748E50
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>..cctor
	|
	|-RVA: 0x2749070 Offset: 0x2749171 VA: 0x2749070
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>..cctor
	|
	|-RVA: 0x2749280 Offset: 0x2749381 VA: 0x2749280
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>..cctor
	|
	|-RVA: 0x27494A0 Offset: 0x27495A1 VA: 0x27494A0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>..cctor
	|
	|-RVA: 0x27496C0 Offset: 0x27497C1 VA: 0x27496C0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>..cctor
	|
	|-RVA: 0x27498E0 Offset: 0x27499E1 VA: 0x27498E0
	|-Array.EmptyInternalEnumerator<WordWrapState>..cctor
	|
	|-RVA: 0x2749B10 Offset: 0x2749C11 VA: 0x2749B10
	|-Array.EmptyInternalEnumerator<TextPaneDatas.TextPaneData>..cctor
	|
	|-RVA: 0x2749D30 Offset: 0x2749E31 VA: 0x2749D30
	|-Array.EmptyInternalEnumerator<TransitionTables>..cctor
	|
	|-RVA: 0x2749F40 Offset: 0x274A041 VA: 0x2749F40
	|-Array.EmptyInternalEnumerator<TutorialUnlockFlagData>..cctor
	|
	|-RVA: 0x274A150 Offset: 0x274A251 VA: 0x274A150
	|-Array.EmptyInternalEnumerator<UICheckOnBackRune.LinkSet>..cctor
	|
	|-RVA: 0x274A360 Offset: 0x274A461 VA: 0x274A360
	|-Array.EmptyInternalEnumerator<UIMainManagerAttachObject.AttachSet>..cctor
	|
	|-RVA: 0x274A590 Offset: 0x274A691 VA: 0x274A590
	|-Array.EmptyInternalEnumerator<CapEdge>..cctor
	|
	|-RVA: 0x274A7B0 Offset: 0x274A8B1 VA: 0x274A7B0
	|-Array.EmptyInternalEnumerator<ClippedEdge>..cctor
	|
	|-RVA: 0x274A9C0 Offset: 0x274AAC1 VA: 0x274A9C0
	|-Array.EmptyInternalEnumerator<EdgeKeyByHash>..cctor
	|
	|-RVA: 0x274ABD0 Offset: 0x274ACD1 VA: 0x274ABD0
	|-Array.EmptyInternalEnumerator<EdgeKeyByIndex>..cctor
	|
	|-RVA: 0x274ADE0 Offset: 0x274AEE1 VA: 0x274ADE0
	|-Array.EmptyInternalEnumerator<MeshDataConnectivity.Face>..cctor
	|
	|-RVA: 0x274B000 Offset: 0x274B101 VA: 0x274B000
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData.SideData>..cctor
	|
	|-RVA: 0x274B230 Offset: 0x274B331 VA: 0x274B230
	|-Array.EmptyInternalEnumerator<MeshFaceConnectivity.EdgeData>..cctor
	|
	|-RVA: 0x274B440 Offset: 0x274B541 VA: 0x274B440
	|-Array.EmptyInternalEnumerator<NavMeshBuildMarkup>..cctor
	|
	|-RVA: 0x274B690 Offset: 0x274B791 VA: 0x274B690
	|-Array.EmptyInternalEnumerator<NavMeshBuildSource>..cctor
	|
	|-RVA: 0x274B8A0 Offset: 0x274B9A1 VA: 0x274B8A0
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>..cctor
	|
	|-RVA: 0x274BAB0 Offset: 0x274BBB1 VA: 0x274BAB0
	|-Array.EmptyInternalEnumerator<ConstraintSource>..cctor
	|
	|-RVA: 0x274BCC0 Offset: 0x274BDC1 VA: 0x274BCC0
	|-Array.EmptyInternalEnumerator<PropertySceneHandle>..cctor
	|
	|-RVA: 0x274BED0 Offset: 0x274BFD1 VA: 0x274BED0
	|-Array.EmptyInternalEnumerator<TransformStreamHandle>..cctor
	|
	|-RVA: 0x274C0E0 Offset: 0x274C1E1 VA: 0x274C0E0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>..cctor
	|
	|-RVA: 0x274C2F0 Offset: 0x274C3F1 VA: 0x274C2F0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>..cctor
	|
	|-RVA: 0x274C500 Offset: 0x274C601 VA: 0x274C500
	|-Array.EmptyInternalEnumerator<BoneWeight1>..cctor
	|
	|-RVA: 0x274C720 Offset: 0x274C821 VA: 0x274C720
	|-Array.EmptyInternalEnumerator<BoneWeight>..cctor
	|
	|-RVA: 0x274C930 Offset: 0x274CA31 VA: 0x274C930
	|-Array.EmptyInternalEnumerator<BoundingSphere>..cctor
	|
	|-RVA: 0x274CB50 Offset: 0x274CC51 VA: 0x274CB50
	|-Array.EmptyInternalEnumerator<Bounds>..cctor
	|
	|-RVA: 0x274CD70 Offset: 0x274CE71 VA: 0x274CD70
	|-Array.EmptyInternalEnumerator<BoundsInt>..cctor
	|
	|-RVA: 0x274CFA0 Offset: 0x274D0A1 VA: 0x274CFA0
	|-Array.EmptyInternalEnumerator<CharacterInfo>..cctor
	|
	|-RVA: 0x274D1B0 Offset: 0x274D2B1 VA: 0x274D1B0
	|-Array.EmptyInternalEnumerator<Color32>..cctor
	|
	|-RVA: 0x274D3C0 Offset: 0x274D4C1 VA: 0x274D3C0
	|-Array.EmptyInternalEnumerator<Color>..cctor
	|
	|-RVA: 0x274D610 Offset: 0x274D711 VA: 0x274D610
	|-Array.EmptyInternalEnumerator<CombineInstance>..cctor
	|
	|-RVA: 0x274D840 Offset: 0x274D941 VA: 0x274D840
	|-Array.EmptyInternalEnumerator<ContactPoint2D>..cctor
	|
	|-RVA: 0x274DA70 Offset: 0x274DB71 VA: 0x274DA70
	|-Array.EmptyInternalEnumerator<ContactPoint>..cctor
	|
	|-RVA: 0x274DCB0 Offset: 0x274DDB1 VA: 0x274DCB0
	|-Array.EmptyInternalEnumerator<RaycastResult>..cctor
	|
	|-RVA: 0x274DEF0 Offset: 0x274DFF1 VA: 0x274DEF0
	|-Array.EmptyInternalEnumerator<LightDataGI>..cctor
	|
	|-RVA: 0x274E100 Offset: 0x274E201 VA: 0x274E100
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>..cctor
	|
	|-RVA: 0x274E310 Offset: 0x274E411 VA: 0x274E310
	|-Array.EmptyInternalEnumerator<GradientAlphaKey>..cctor
	|
	|-RVA: 0x274E530 Offset: 0x274E631 VA: 0x274E530
	|-Array.EmptyInternalEnumerator<GradientColorKey>..cctor
	|
	|-RVA: 0x274E760 Offset: 0x274E861 VA: 0x274E760
	|-Array.EmptyInternalEnumerator<HumanBone>..cctor
	|
	|-RVA: 0x274E990 Offset: 0x274EA91 VA: 0x274E990
	|-Array.EmptyInternalEnumerator<Keyframe>..cctor
	|
	|-RVA: 0x274EBA0 Offset: 0x274ECA1 VA: 0x274EBA0
	|-Array.EmptyInternalEnumerator<LOD>..cctor
	|
	|-RVA: 0x274EDB0 Offset: 0x274EEB1 VA: 0x274EDB0
	|-Array.EmptyInternalEnumerator<LayerMask>..cctor
	|
	|-RVA: 0x274EFE0 Offset: 0x274F0E1 VA: 0x274EFE0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>..cctor
	|
	|-RVA: 0x274F210 Offset: 0x274F311 VA: 0x274F210
	|-Array.EmptyInternalEnumerator<Matrix4x4>..cctor
	|
	|-RVA: 0x274F430 Offset: 0x274F531 VA: 0x274F430
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>..cctor
	|
	|-RVA: 0x274F640 Offset: 0x274F741 VA: 0x274F640
	|-Array.EmptyInternalEnumerator<PatchExtents>..cctor
	|
	|-RVA: 0x274F850 Offset: 0x274F951 VA: 0x274F850
	|-Array.EmptyInternalEnumerator<Plane>..cctor
	|
	|-RVA: 0x274FA60 Offset: 0x274FB61 VA: 0x274FA60
	|-Array.EmptyInternalEnumerator<Playable>..cctor
	|
	|-RVA: 0x274FC80 Offset: 0x274FD81 VA: 0x274FC80
	|-Array.EmptyInternalEnumerator<PlayableBinding>..cctor
	|
	|-RVA: 0x274FE90 Offset: 0x274FF91 VA: 0x274FE90
	|-Array.EmptyInternalEnumerator<PlayableGraph>..cctor
	|
	|-RVA: 0x27500A0 Offset: 0x27501A1 VA: 0x27500A0
	|-Array.EmptyInternalEnumerator<Edge>..cctor
	|
	|-RVA: 0x27502B0 Offset: 0x27503B1 VA: 0x27502B0
	|-Array.EmptyInternalEnumerator<IntVec3>..cctor
	|
	|-RVA: 0x27504C0 Offset: 0x27505C1 VA: 0x27504C0
	|-Array.EmptyInternalEnumerator<Quaternion>..cctor
	|
	|-RVA: 0x27506D0 Offset: 0x27507D1 VA: 0x27506D0
	|-Array.EmptyInternalEnumerator<RangeInt>..cctor
	|
	|-RVA: 0x2750900 Offset: 0x2750A01 VA: 0x2750900
	|-Array.EmptyInternalEnumerator<RaycastHit2D>..cctor
	|
	|-RVA: 0x2750B30 Offset: 0x2750C31 VA: 0x2750B30
	|-Array.EmptyInternalEnumerator<RaycastHit>..cctor
	|
	|-RVA: 0x2750D40 Offset: 0x2750E41 VA: 0x2750D40
	|-Array.EmptyInternalEnumerator<Rect>..cctor
	|
	|-RVA: 0x2750F50 Offset: 0x2751051 VA: 0x2750F50
	|-Array.EmptyInternalEnumerator<RectInt>..cctor
	|
	|-RVA: 0x2751160 Offset: 0x2751261 VA: 0x2751160
	|-Array.EmptyInternalEnumerator<RenderBuffer>..cctor
	|
	|-RVA: 0x2751370 Offset: 0x2751471 VA: 0x2751370
	|-Array.EmptyInternalEnumerator<BatchVisibility>..cctor
	|
	|-RVA: 0x2751580 Offset: 0x2751681 VA: 0x2751580
	|-Array.EmptyInternalEnumerator<ReflectionProbeBlendInfo>..cctor
	|
	|-RVA: 0x27517D0 Offset: 0x27518D1 VA: 0x27517D0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>..cctor
	|
	|-RVA: 0x27519E0 Offset: 0x2751AE1 VA: 0x27519E0
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>..cctor
	|
	|-RVA: 0x2751C00 Offset: 0x2751D01 VA: 0x2751C00
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>..cctor
	|
	|-RVA: 0x2751E20 Offset: 0x2751F21 VA: 0x2751E20
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>..cctor
	|
	|-RVA: 0x2752040 Offset: 0x2752141 VA: 0x2752040
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<SceneInstance>>..cctor
	|
	|-RVA: 0x2752270 Offset: 0x2752371 VA: 0x2752270
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>..cctor
	|
	|-RVA: 0x2752480 Offset: 0x2752581 VA: 0x2752480
	|-Array.EmptyInternalEnumerator<SceneInstance>..cctor
	|
	|-RVA: 0x27526A0 Offset: 0x27527A1 VA: 0x27526A0
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>..cctor
	|
	|-RVA: 0x27528D0 Offset: 0x27529D1 VA: 0x27528D0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>..cctor
	|
	|-RVA: 0x2752AF0 Offset: 0x2752BF1 VA: 0x2752AF0
	|-Array.EmptyInternalEnumerator<SerializedType>..cctor
	|
	|-RVA: 0x2752D00 Offset: 0x2752E01 VA: 0x2752D00
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>..cctor
	|
	|-RVA: 0x2752F30 Offset: 0x2753031 VA: 0x2752F30
	|-Array.EmptyInternalEnumerator<SkeletonBone>..cctor
	|
	|-RVA: 0x2753140 Offset: 0x2753241 VA: 0x2753140
	|-Array.EmptyInternalEnumerator<GlyphRect>..cctor
	|
	|-RVA: 0x2753370 Offset: 0x2753471 VA: 0x2753370
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>..cctor
	|
	|-RVA: 0x27535A0 Offset: 0x27536A1 VA: 0x27535A0
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>..cctor
	|
	|-RVA: 0x27537D0 Offset: 0x27538D1 VA: 0x27537D0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>..cctor
	|
	|-RVA: 0x27539F0 Offset: 0x2753AF1 VA: 0x27539F0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>..cctor
	|
	|-RVA: 0x2753C10 Offset: 0x2753D11 VA: 0x2753C10
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>..cctor
	|
	|-RVA: 0x2753E30 Offset: 0x2753F31 VA: 0x2753E30
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>..cctor
	|
	|-RVA: 0x2754070 Offset: 0x2754171 VA: 0x2754070
	|-Array.EmptyInternalEnumerator<Touch>..cctor
	|
	|-RVA: 0x27542A0 Offset: 0x27543A1 VA: 0x27542A0
	|-Array.EmptyInternalEnumerator<TreeInstance>..cctor
	|
	|-RVA: 0x27544E0 Offset: 0x27545E1 VA: 0x27544E0
	|-Array.EmptyInternalEnumerator<ColorBlock>..cctor
	|
	|-RVA: 0x2754710 Offset: 0x2754811 VA: 0x2754710
	|-Array.EmptyInternalEnumerator<Navigation>..cctor
	|
	|-RVA: 0x2754930 Offset: 0x2754A31 VA: 0x2754930
	|-Array.EmptyInternalEnumerator<SpriteState>..cctor
	|
	|-RVA: 0x2754B40 Offset: 0x2754C41 VA: 0x2754B40
	|-Array.EmptyInternalEnumerator<UICharInfo>..cctor
	|
	|-RVA: 0x2754D50 Offset: 0x2754E51 VA: 0x2754D50
	|-Array.EmptyInternalEnumerator<EventDispatcher.DispatchContext>..cctor
	|
	|-RVA: 0x2754F60 Offset: 0x2755061 VA: 0x2754F60
	|-Array.EmptyInternalEnumerator<EventDispatcher.EventRecord>..cctor
	|
	|-RVA: 0x2755170 Offset: 0x2755271 VA: 0x2755170
	|-Array.EmptyInternalEnumerator<FocusController.FocusedElement>..cctor
	|
	|-RVA: 0x2755380 Offset: 0x2755481 VA: 0x2755380
	|-Array.EmptyInternalEnumerator<StyleSheetCache.SheetHandleKey>..cctor
	|
	|-RVA: 0x27555A0 Offset: 0x27556A1 VA: 0x27555A0
	|-Array.EmptyInternalEnumerator<StyleValue>..cctor
	|
	|-RVA: 0x27557B0 Offset: 0x27558B1 VA: 0x27557B0
	|-Array.EmptyInternalEnumerator<UILineInfo>..cctor
	|
	|-RVA: 0x27559F0 Offset: 0x2755AF1 VA: 0x27559F0
	|-Array.EmptyInternalEnumerator<UIVertex>..cctor
	|
	|-RVA: 0x2755C10 Offset: 0x2755D11 VA: 0x2755C10
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>..cctor
	|
	|-RVA: 0x2755E20 Offset: 0x2755F21 VA: 0x2755E20
	|-Array.EmptyInternalEnumerator<Vector2>..cctor
	|
	|-RVA: 0x2756030 Offset: 0x2756131 VA: 0x2756030
	|-Array.EmptyInternalEnumerator<Vector2Int>..cctor
	|
	|-RVA: 0x2756240 Offset: 0x2756341 VA: 0x2756240
	|-Array.EmptyInternalEnumerator<Vector3>..cctor
	|
	|-RVA: 0x2756450 Offset: 0x2756551 VA: 0x2756450
	|-Array.EmptyInternalEnumerator<Vector3Int>..cctor
	|
	|-RVA: 0x2756660 Offset: 0x2756761 VA: 0x2756660
	|-Array.EmptyInternalEnumerator<Vector4>..cctor
	|
	|-RVA: 0x2756870 Offset: 0x2756971 VA: 0x2756870
	|-Array.EmptyInternalEnumerator<jvalue>..cctor
	|
	|-RVA: 0x2756AC0 Offset: 0x2756BC1 VA: 0x2756AC0
	|-Array.EmptyInternalEnumerator<WarpPoints.WarpPoint>..cctor
	|
	|-RVA: 0x2756CD0 Offset: 0x2756DD1 VA: 0x2756CD0
	|-Array.EmptyInternalEnumerator<YieldItemParam>..cctor
	|
	|-RVA: 0x2756EE0 Offset: 0x2756FE1 VA: 0x2756EE0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>..cctor
	|
	|-RVA: 0x27570F0 Offset: 0x27571F1 VA: 0x27570F0
	|-Array.EmptyInternalEnumerator<Uid>..cctor
	|
	|-RVA: 0x2757300 Offset: 0x2757401 VA: 0x2757300
	|-Array.EmptyInternalEnumerator<ConsumableServiceItemId>..cctor
	|
	|-RVA: 0x2757510 Offset: 0x2757611 VA: 0x2757510
	|-Array.EmptyInternalEnumerator<NsUid>..cctor
	|
	|-RVA: 0x2757730 Offset: 0x2757831 VA: 0x2757730
	|-Array.EmptyInternalEnumerator<Friend>..cctor
	|
	|-RVA: 0x2757950 Offset: 0x2757A51 VA: 0x2757950
	|-Array.EmptyInternalEnumerator<Profile>..cctor
	|
	|-RVA: 0x2757B70 Offset: 0x2757C71 VA: 0x2757B70
	|-Array.EmptyInternalEnumerator<DirectoryEntry>..cctor
	|
	|-RVA: 0x2757D90 Offset: 0x2757E91 VA: 0x2757D90
	|-Array.EmptyInternalEnumerator<DebugPadState>..cctor
	|
	|-RVA: 0x2757FA0 Offset: 0x27580A1 VA: 0x2757FA0
	|-Array.EmptyInternalEnumerator<GesturePoint>..cctor
	|
	|-RVA: 0x27581E0 Offset: 0x27582E1 VA: 0x27581E0
	|-Array.EmptyInternalEnumerator<GestureState>..cctor
	|
	|-RVA: 0x2758410 Offset: 0x2758511 VA: 0x2758410
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>..cctor
	|
	|-RVA: 0x2758640 Offset: 0x2758741 VA: 0x2758640
	|-Array.EmptyInternalEnumerator<NpadHandheldState>..cctor
	|
	|-RVA: 0x2758870 Offset: 0x2758971 VA: 0x2758870
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>..cctor
	|
	|-RVA: 0x2758AA0 Offset: 0x2758BA1 VA: 0x2758AA0
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>..cctor
	|
	|-RVA: 0x2758CD0 Offset: 0x2758DD1 VA: 0x2758CD0
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>..cctor
	|
	|-RVA: 0x2758F00 Offset: 0x2759001 VA: 0x2758F00
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>..cctor
	|
	|-RVA: 0x246A100 Offset: 0x246A201 VA: 0x246A100
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>..cctor
	|
	|-RVA: 0x246A340 Offset: 0x246A441 VA: 0x246A340
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>..cctor
	|
	|-RVA: 0x246A560 Offset: 0x246A661 VA: 0x246A560
	|-Array.EmptyInternalEnumerator<TouchScreenState10>..cctor
	|
	|-RVA: 0x246A780 Offset: 0x246A881 VA: 0x246A780
	|-Array.EmptyInternalEnumerator<TouchScreenState11>..cctor
	|
	|-RVA: 0x246A9A0 Offset: 0x246AAA1 VA: 0x246A9A0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>..cctor
	|
	|-RVA: 0x246ABC0 Offset: 0x246ACC1 VA: 0x246ABC0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>..cctor
	|
	|-RVA: 0x246ADE0 Offset: 0x246AEE1 VA: 0x246ADE0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>..cctor
	|
	|-RVA: 0x246B000 Offset: 0x246B101 VA: 0x246B000
	|-Array.EmptyInternalEnumerator<TouchScreenState15>..cctor
	|
	|-RVA: 0x246B220 Offset: 0x246B321 VA: 0x246B220
	|-Array.EmptyInternalEnumerator<TouchScreenState16>..cctor
	|
	|-RVA: 0x246B450 Offset: 0x246B551 VA: 0x246B450
	|-Array.EmptyInternalEnumerator<TouchScreenState1>..cctor
	|
	|-RVA: 0x246B690 Offset: 0x246B791 VA: 0x246B690
	|-Array.EmptyInternalEnumerator<TouchScreenState2>..cctor
	|
	|-RVA: 0x246B8B0 Offset: 0x246B9B1 VA: 0x246B8B0
	|-Array.EmptyInternalEnumerator<TouchScreenState3>..cctor
	|
	|-RVA: 0x246BAD0 Offset: 0x246BBD1 VA: 0x246BAD0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>..cctor
	|
	|-RVA: 0x246BCF0 Offset: 0x246BDF1 VA: 0x246BCF0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>..cctor
	|
	|-RVA: 0x246BF10 Offset: 0x246C011 VA: 0x246BF10
	|-Array.EmptyInternalEnumerator<TouchScreenState6>..cctor
	|
	|-RVA: 0x246C130 Offset: 0x246C231 VA: 0x246C130
	|-Array.EmptyInternalEnumerator<TouchScreenState7>..cctor
	|
	|-RVA: 0x246C350 Offset: 0x246C451 VA: 0x246C350
	|-Array.EmptyInternalEnumerator<TouchScreenState8>..cctor
	|
	|-RVA: 0x246C570 Offset: 0x246C671 VA: 0x246C570
	|-Array.EmptyInternalEnumerator<TouchScreenState9>..cctor
	|
	|-RVA: 0x246C7A0 Offset: 0x246C8A1 VA: 0x246C7A0
	|-Array.EmptyInternalEnumerator<TouchState>..cctor
	|
	|-RVA: 0x246C9B0 Offset: 0x246CAB1 VA: 0x246C9B0
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>..cctor
	|
	|-RVA: 0x246CBC0 Offset: 0x246CCC1 VA: 0x246CBC0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>..cctor
	|
	|-RVA: 0x246CDD0 Offset: 0x246CED1 VA: 0x246CDD0
	|-Array.EmptyInternalEnumerator<VibrationValue>..cctor
	|
	|-RVA: 0x246CFF0 Offset: 0x246D0F1 VA: 0x246CFF0
	|-Array.EmptyInternalEnumerator<ClusteringData>..cctor
	|
	|-RVA: 0x246D210 Offset: 0x246D311 VA: 0x246D210
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>..cctor
	|
	|-RVA: 0x246D440 Offset: 0x246D541 VA: 0x246D440
	|-Array.EmptyInternalEnumerator<Finger>..cctor
	|
	|-RVA: 0x246D660 Offset: 0x246D761 VA: 0x246D660
	|-Array.EmptyInternalEnumerator<Hand>..cctor
	|
	|-RVA: 0x246D870 Offset: 0x246D971 VA: 0x246D870
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>..cctor
	|
	|-RVA: 0x246DA90 Offset: 0x246DB91 VA: 0x246DA90
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>..cctor
	|
	|-RVA: 0x246DCB0 Offset: 0x246DDB1 VA: 0x246DCB0
	|-Array.EmptyInternalEnumerator<MomentProcessorState>..cctor
	|
	|-RVA: 0x246DEC0 Offset: 0x246DFC1 VA: 0x246DEC0
	|-Array.EmptyInternalEnumerator<MomentStatistic>..cctor
	|
	|-RVA: 0x246E0D0 Offset: 0x246E1D1 VA: 0x246E0D0
	|-Array.EmptyInternalEnumerator<Protrusion>..cctor
	|
	|-RVA: 0x246E2F0 Offset: 0x246E3F1 VA: 0x246E2F0
	|-Array.EmptyInternalEnumerator<Shape>..cctor
	|
	|-RVA: 0x246E500 Offset: 0x246E601 VA: 0x246E500
	|-Array.EmptyInternalEnumerator<DictionaryInfo>..cctor
	|
	|-RVA: 0x246E710 Offset: 0x246E811 VA: 0x246E710
	|-Array.EmptyInternalEnumerator<UserWord>..cctor
	|
	|-RVA: 0x246E920 Offset: 0x246EA21 VA: 0x246E920
	|-Array.EmptyInternalEnumerator<Color4u8>..cctor
	|
	|-RVA: 0x246EB30 Offset: 0x246EC31 VA: 0x246EB30
	|-Array.EmptyInternalEnumerator<Float2>..cctor
	|
	|-RVA: 0x246ED50 Offset: 0x246EE51 VA: 0x246ED50
	|-Array.EmptyInternalEnumerator<stCommand_t>..cctor
	*/
}

