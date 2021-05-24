[DebuggerTypeProxyAttribute] // RVA: 0xB3C80 Offset: 0xB3D81 VA: 0xB3C80
[DefaultMemberAttribute] // RVA: 0xB3C80 Offset: 0xB3D81 VA: 0xB3C80
[DebuggerDisplayAttribute] // RVA: 0xB3C80 Offset: 0xB3D81 VA: 0xB3C80
[Serializable]
public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1462
{
	// Fields
	private const int _defaultCapacity = 4;
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private static readonly T[] _emptyArray; // 0x0

	// Properties
	public int Capacity { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	public T Item { get; set; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327AB90 Offset: 0x327AC91 VA: 0x327AB90
	|-List<AIInput>..ctor
	|-List<AS_MagicController>..ctor
	|-List<ActionBehaviorCommandBase>..ctor
	|-List<ActionBehaviorCommandInformation>..ctor
	|-List<ActionCommandBase>..ctor
	|-List<Actor>..ctor
	|-List<ActorController>..ctor
	|-List<AdvShowOneImage.AdvSpriteLoader>..ctor
	|-List<AdvShowOneImage>..ctor
	|-List<AracneFlatWeb>..ctor
	|-List<AttackCollider>..ctor
	|-List<AudmuraCrystal>..ctor
	|-List<AutomaticLOD.LODLevelData>..ctor
	|-List<AutomaticLOD>..ctor
	|-List<BasiliskController.WearFireController>..ctor
	|-List<BehaviorManager.BehaviorThreadLoader>..ctor
	|-List<BehaviorManager.BehaviorTree.ConditionalReevaluate>..ctor
	|-List<BehaviorManager.BehaviorTree>..ctor
	|-List<SharedVariable>..ctor
	|-List<TaskCoroutine>..ctor
	|-List<Task>..ctor
	|-List<VariableSynchronizer.SynchronizedVariable>..ctor
	|-List<BehaviorTreeManager.EnemyBehaviorParameter>..ctor
	|-List<BgmList>..ctor
	|-List<BitBase>..ctor
	|-List<BodyPartsCollision>..ctor
	|-List<BossBehaviorParams>..ctor
	|-List<BulletBase>..ctor
	|-List<BulletColliderBase>..ctor
	|-List<BulletSubModule>..ctor
	|-List<ButtonLinker>..ctor
	|-List<CameraManager.CameraControllerPair>..ctor
	|-List<CerberusController.DogParam>..ctor
	|-List<Character>..ctor
	|-List<CharacterBase>..ctor
	|-List<CheerVoiceData>..ctor
	|-List<ChildData>..ctor
	|-List<ChoiceImage>..ctor
	|-List<CinemachineBrain.BrainFrame>..ctor
	|-List<CinemachineBrain>..ctor
	|-List<CinemachineComponentBase>..ctor
	|-List<CinemachineExtension>..ctor
	|-List<CinemachineImpulseManager.ImpulseEvent>..ctor
	|-List<CinemachineStoryboard.CanvasInfo>..ctor
	|-List<CinemachineVirtualCameraBase>..ctor
	|-List<CombinedMesh.MaterialMeshInfo>..ctor
	|-List<CombinedMesh.ObjectInfo>..ctor
	|-List<VariableBase>..ctor
	|-List<CursorEvent>..ctor
	|-List<ABSSequentiable>..ctor
	|-List<Tween>..ctor
	|-List<TweenCallback>..ctor
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>..ctor
	|-List<DamageText>..ctor
	|-List<DateSlotControl>..ctor
	|-List<DeadtreeController.ChestnutController>..ctor
	|-List<DynamicBone.Particle>..ctor
	|-List<DynamicBoneH.Particle>..ctor
	|-List<EnvironmentSoundArea>..ctor
	|-List<EnvironmentSoundDataTable>..ctor
	|-List<EraseObject>..ctor
	|-List<EventFlagManager.RequestDisableEventPointData>..ctor
	|-List<EventStartData>..ctor
	|-List<EventUnlockFlagData>..ctor
	|-List<CellController>..ctor
	|-List<FarmCropData>..ctor
	|-List<FarmSupportMonsterController>..ctor
	|-List<FarmSupportMonsterData>..ctor
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>..ctor
	|-List<FesNpcScore>..ctor
	|-List<ObjectLoader>..ctor
	|-List<FishRecord>..ctor
	|-List<FishSwim>..ctor
	|-List<FishingPoint>..ctor
	|-List<FracturedChunk.AdjacencyInfo>..ctor
	|-List<FracturedChunk>..ctor
	|-List<FriendJudgmentManager.FriendJudgmentMonster>..ctor
	|-List<FriendMonsterManager.FarmInActorData>..ctor
	|-List<FriendMonsterStatusData>..ctor
	|-List<LightningRenderer>..ctor
	|-List<LightningSpawnArea>..ctor
	|-List<ProfileGroupDefinition>..ctor
	|-List<RainSplashRenderer>..ctor
	|-List<WeatherEnclosure>..ctor
	|-List<GateSeasonInfomation>..ctor
	|-List<GateTimeZoneMonsterInfomation>..ctor
	|-List<HUDDualWorkSelectInput.DualSelect>..ctor
	|-List<HUDMinimapControl.RectImage>..ctor
	|-List<HasibirokouSonicWind>..ctor
	|-List<HateController.HateParameter>..ctor
	|-List<HoldItemController.ItemModel>..ctor
	|-List<HumanController>..ctor
	|-List<InosisiController.ThornsController>..ctor
	|-List<ItemData>..ctor
	|-List<ItemDataLinker>..ctor
	|-List<ItemEquip>..ctor
	|-List<FurnitureSaveData>..ctor
	|-List<PlayerItemFurniture2>..ctor
	|-List<ItemIconMng.ImageLoaderObj>..ctor
	|-List<ItemIconMng.SpriteWork>..ctor
	|-List<ItemMoveToBasket>..ctor
	|-List<ItemStorage>..ctor
	|-List<ItemTool>..ctor
	|-List<ItemWeightData>..ctor
	|-List<KrakenStickController>..ctor
	|-List<KyubiController.FireballParameter>..ctor
	|-List<LastBossBone>..ctor
	|-List<LifeCycleAdvData>..ctor
	|-List<AssetHandle>..ctor
	|-List<AssetInfo>..ctor
	|-List<MeshSimplify>..ctor
	|-List<ObjectSerializationInfo.EmittableMemberAndConstructorParameter>..ctor
	|-List<MiningPoint>..ctor
	|-List<Contraction>..ctor
	|-List<Level2Map>..ctor
	|-List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>..ctor
	|-List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>..ctor
	|-List<MonsterActionInformation>..ctor
	|-List<MonsterAnimatorStateEvent.NormalizeTimeEvent>..ctor
	|-List<MonsterBehaviorController.BehaviorActionParam>..ctor
	|-List<MonsterControllerBase.DropItemDataParameter>..ctor
	|-List<MonsterControllerBase>..ctor
	|-List<MonsterHutController.OrderFarmInParameter>..ctor
	|-List<MonsterProjectileActionScriptsController>..ctor
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>..ctor
	|-List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>..ctor
	|-List<NpcController>..ctor
	|-List<NpcLifeCycleDataRecord>..ctor
	|-List<NpcPatrolPoint>..ctor
	|-List<NpcPatrolPointData>..ctor
	|-List<NpcSaveParameter>..ctor
	|-List<NpcTimeAction>..ctor
	|-List<ObjectPooler.Pool>..ctor
	|-List<OnGroundItem>..ctor
	|-List<OrderData>..ctor
	|-List<OrderHUDBlock>..ctor
	|-List<OrderMasterData>..ctor
	|-List<OrderPopControl.StockDoOrder>..ctor
	|-List<PartnerManager.DestinationAngle>..ctor
	|-List<PartnerManager.NPCChangeBaseParameter>..ctor
	|-List<PartnerManager.PartnerSearchRange>..ctor
	|-List<PartnerMonsterBehaviorController>..ctor
	|-List<PartyBase>..ctor
	|-List<PartyMonster>..ctor
	|-List<PlayerSkillBase>..ctor
	|-List<Contour>..ctor
	|-List<DTSweepConstraint>..ctor
	|-List<DelaunayTriangle>..ctor
	|-List<EdgeIntersectInfo>..ctor
	|-List<Point2D>..ctor
	|-List<Point2DList>..ctor
	|-List<Polygon>..ctor
	|-List<PolygonPoint>..ctor
	|-List<SplitComplexPolygonNode>..ctor
	|-List<TriangulationConstraint>..ctor
	|-List<TriangulationPoint>..ctor
	|-List<PreloadHandle>..ctor
	|-List<QuestIconData>..ctor
	|-List<FishShipmentRecords>..ctor
	|-List<SeedLevelRecords>..ctor
	|-List<ShipmentItemRecords>..ctor
	|-List<SeedShopItemDataTable.SeedShopItemData>..ctor
	|-List<ShopItem>..ctor
	|-List<RF5Streamer>..ctor
	|-List<SubtitleHandler>..ctor
	|-List<ButtonHintBlock>..ctor
	|-List<UIEMCustomizeSet>..ctor
	|-List<WantedData>..ctor
	|-List<SEController>..ctor
	|-List<RandomData>..ctor
	|-List<RecipeDataDispBlock>..ctor
	|-List<RecipeDataTableArray.RecipeDataTable>..ctor
	|-List<RecipeGroupBase>..ctor
	|-List<MP4FileProcessing.Chunk>..ctor
	|-List<ReviatanIcePillar>..ctor
	|-List<InteractionTarget>..ctor
	|-List<InteractionTrigger>..ctor
	|-List<InfoEntry>..ctor
	|-List<OptionDefinition>..ctor
	|-List<Settings.KeyboardShortcut>..ctor
	|-List<OptionsControlBase>..ctor
	|-List<OptionsTabController.CategoryInstance>..ctor
	|-List<SRServiceManager.ServiceStub>..ctor
	|-List<Style>..ctor
	|-List<TimelineToActionScriptExpoter.ActionScriptData>..ctor
	|-List<RF5ThumbnailData>..ctor
	|-List<SceneCollection>..ctor
	|-List<SceneSplit>..ctor
	|-List<SceneTransitionManager.GameObjectEnabled>..ctor
	|-List<SceneTransitionManager.SceneGameObjectEnabled>..ctor
	|-List<SearchCharacterController.SearchParameter>..ctor
	|-List<SimpleAnimation.EditorState>..ctor
	|-List<SimpleAnimationPlayable.StateInfo>..ctor
	|-List<CubicBezierCurve>..ctor
	|-List<ExtrusionSegment.Vertex>..ctor
	|-List<SplineNode>..ctor
	|-List<TrackSegment>..ctor
	|-List<TransformedMesh>..ctor
	|-List<Streamer>..ctor
	|-List<SubEventData>..ctor
	|-List<SubEventMasterDataBase>..ctor
	|-List<Action>..ctor
	|-List<AggregateException>..ctor
	|-List<byte[]>..ctor
	|-List<Dictionary<int, Vector3>>..ctor
	|-List<IList<string>>..ctor
	|-List<List<ActionBehaviorCommandInformation>>..ctor
	|-List<List<CinemachineVirtualCameraBase>>..ctor
	|-List<List<ErosionBrush.UndoStep>>..ctor
	|-List<List<FarmCropData>>..ctor
	|-List<List<Point2D>>..ctor
	|-List<List<PolygonPoint>>..ctor
	|-List<List<int>>..ctor
	|-List<List<object>>..ctor
	|-List<List<Renderer>>..ctor
	|-List<List<Vector2>>..ctor
	|-List<List<Vector3>>..ctor
	|-List<Stack<int>>..ctor
	|-List<StackFrame>..ctor
	|-List<Exception>..ctor
	|-List<Func<FocusInterface>>..ctor
	|-List<Directory.SearchData>..ctor
	|-List<int[]>..ctor
	|-List<Expression>..ctor
	|-List<BranchLabel>..ctor
	|-List<ByRefUpdater>..ctor
	|-List<DebugInfo>..ctor
	|-List<ExceptionHandler>..ctor
	|-List<Instruction>..ctor
	|-List<LabelScopeInfo>..ctor
	|-List<LocalVariables.VariableScope>..ctor
	|-List<LocalDataStore>..ctor
	|-List<ModifierSpec>..ctor
	|-List<IPAddress>..ctor
	|-List<WebConnection>..ctor
	|-List<WebConnectionGroup>..ctor
	|-List<object>..ctor
	|-List<Assembly>..ctor
	|-List<FieldInfo>..ctor
	|-List<MethodInfo>..ctor
	|-List<IContextProperty>..ctor
	|-List<SerializationFieldInfo>..ctor
	|-List<X509CertificateImpl>..ctor
	|-List<string>..ctor
	|-List<string[]>..ctor
	|-List<StringBuilder>..ctor
	|-List<Task>..ctor
	|-List<Thread>..ctor
	|-List<TimeZoneInfo.AdjustmentRule>..ctor
	|-List<TimeZoneInfo>..ctor
	|-List<Type>..ctor
	|-List<TypeIdentifier>..ctor
	|-List<TypeSpec>..ctor
	|-List<WeakReference>..ctor
	|-List<SystemTextDisp>..ctor
	|-List<KerningPair>..ctor
	|-List<TMP_Character>..ctor
	|-List<TMP_Dropdown.DropdownItem>..ctor
	|-List<TMP_Dropdown.OptionData>..ctor
	|-List<TMP_FontAsset>..ctor
	|-List<TMP_GlyphPairAdjustmentRecord>..ctor
	|-List<TMP_MaterialManager.FallbackMaterial>..ctor
	|-List<TMP_MaterialManager.MaskingMaterial>..ctor
	|-List<TMP_SpriteCharacter>..ctor
	|-List<TMP_SpriteGlyph>..ctor
	|-List<TMP_Text>..ctor
	|-List<TimeManager.JustTimerData>..ctor
	|-List<TimelineMsg>..ctor
	|-List<ToolInteractionInterface>..ctor
	|-List<UIFadeOnOffAnimate.ImageGroup>..ctor
	|-List<UIItemBoxWindowOpenButton>..ctor
	|-List<UIItemSlot>..ctor
	|-List<UIOnOffAnimate>..ctor
	|-List<UIOrderBoardMenu.OrderList>..ctor
	|-List<DynamicsSetup.ParseMessage>..ctor
	|-List<SpringBone>..ctor
	|-List<SpringBoneSerialization.PivotSerializer>..ctor
	|-List<SpringBoneSerialization.SpringBoneSerializer>..ctor
	|-List<SpringColliderSerialization.IColliderSerializer>..ctor
	|-List<SpringColliderSerialization.TransformSerializer>..ctor
	|-List<TextRecordParsing.Record>..ctor
	|-List<MeshData>..ctor
	|-List<MeshFaceConnectivity.TriangleData>..ctor
	|-List<SupportPlane>..ctor
	|-List<VertexData>..ctor
	|-List<MeshUniqueVertices.RepeatedVertex>..ctor
	|-List<MeshUniqueVertices.SerializableBoneWeight>..ctor
	|-List<Simplifier.Triangle>..ctor
	|-List<Simplifier.Vertex>..ctor
	|-List<UltimateRope.RopeBone>..ctor
	|-List<UltimateRope.RopeNode>..ctor
	|-List<NavMeshLink>..ctor
	|-List<NavMeshModifier>..ctor
	|-List<NavMeshModifierVolume>..ctor
	|-List<NavMeshObstacle>..ctor
	|-List<NavMeshSurface>..ctor
	|-List<AddressablesImpl.ResourceLocatorInfo>..ctor
	|-List<ResourceLocationData>..ctor
	|-List<CanvasGroup>..ctor
	|-List<Collider>..ctor
	|-List<BaseInputModule>..ctor
	|-List<BaseRaycaster>..ctor
	|-List<EventSystem>..ctor
	|-List<EventTrigger.Entry>..ctor
	|-List<PointerInputModule.ButtonState>..ctor
	|-List<BaseInvokableCall>..ctor
	|-List<PersistentCall>..ctor
	|-List<UnityEvent>..ctor
	|-List<IAnimationWindowPreview>..ctor
	|-List<GUILayoutEntry>..ctor
	|-List<GameObject>..ctor
	|-List<ISubsystem>..ctor
	|-List<ISubsystemDescriptor>..ctor
	|-List<ISubsystemDescriptorImpl>..ctor
	|-List<Light>..ctor
	|-List<Material>..ctor
	|-List<PlayerEditorConnectionEvents.MessageTypeSubscribers>..ctor
	|-List<UnityWebRequestAsyncOperation>..ctor
	|-List<Object>..ctor
	|-List<ParticleSystem>..ctor
	|-List<RectTransform>..ctor
	|-List<RenderTexture>..ctor
	|-List<Renderer>..ctor
	|-List<AsyncOperationHandle<SceneInstance>[]>..ctor
	|-List<IAsyncOperation>..ctor
	|-List<IUpdateReceiver>..ctor
	|-List<IResourceLocation>..ctor
	|-List<ResourceManager.InstanceOperation>..ctor
	|-List<Rigidbody2D>..ctor
	|-List<ScriptableObject>..ctor
	|-List<SkinnedMeshRenderer>..ctor
	|-List<Sprite>..ctor
	|-List<Terrain>..ctor
	|-List<Glyph>..ctor
	|-List<Texture2D>..ctor
	|-List<AnimationTrack>..ctor
	|-List<ITimelineEvaluateCallback>..ctor
	|-List<RuntimeElement>..ctor
	|-List<SignalAsset>..ctor
	|-List<TimelineClip>..ctor
	|-List<TrackAsset>..ctor
	|-List<Transform>..ctor
	|-List<Dropdown.DropdownItem>..ctor
	|-List<Dropdown.OptionData>..ctor
	|-List<Graphic>..ctor
	|-List<ICanvasElement>..ctor
	|-List<Image>..ctor
	|-List<RectMask2D>..ctor
	|-List<StencilMaterial.MatEntry>..ctor
	|-List<Toggle>..ctor
	|-List<EventCallbackFunctorBase>..ctor
	|-List<IEventDispatchingStrategy>..ctor
	|-List<IEventHandler>..ctor
	|-List<Panel>..ctor
	|-List<VisualElement>..ctor
	|-List<UpPointData>..ctor
	|-List<VoiceComment.CharaSprite>..ctor
	|-List<SplineControlPoint>..ctor
	|-List<XWeaponTrail.Element>..ctor
	|
	|-RVA: 0x248C090 Offset: 0x248C191 VA: 0x248C090
	|-List<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x336CB40 Offset: 0x336CC41 VA: 0x336CB40
	|-List<BeanID>..ctor
	|-List<TaskStatus>..ctor
	|-List<CalendarDataTable.FestivalId>..ctor
	|-List<CraftCategoryId>..ctor
	|-List<ActorID>..ctor
	|-List<Alliance>..ctor
	|-List<BadStatus>..ctor
	|-List<BulletID>..ctor
	|-List<ClothShopID>..ctor
	|-List<DLCID>..ctor
	|-List<EffectID>..ctor
	|-List<EmotionType>..ctor
	|-List<FarmFieldWorkArea>..ctor
	|-List<GameFlagData>..ctor
	|-List<HotSpringID>..ctor
	|-List<MakingID>..ctor
	|-List<NPCID>..ctor
	|-List<PoliceBatchId>..ctor
	|-List<RecipePanShopID>..ctor
	|-List<StorageType>..ctor
	|-List<VaccinationID>..ctor
	|-List<VariationNo>..ctor
	|-List<ItemID>..ctor
	|-List<Prefab>..ctor
	|-List<Texture>..ctor
	|-List<LovePointManager.FavoriteType>..ctor
	|-List<MonsterActionBehaviorType>..ctor
	|-List<MonsterDataID>..ctor
	|-List<MonsterModelDataID>..ctor
	|-List<NpcSearchCollider.VoiceType>..ctor
	|-List<PartnerNPCActionBehaviorType>..ctor
	|-List<RecipeId>..ctor
	|-List<SoundID>..ctor
	|-List<Int32Enum>..ctor
	|-List<RegexOptions>..ctor
	|-List<UINamingWindow.NamingId>..ctor
	|
	|-RVA: 0x248F430 Offset: 0x248F531 VA: 0x248F430
	|-List<BuildItemData>..ctor
	|
	|-RVA: 0x3155730 Offset: 0x3155831 VA: 0x3155730
	|-List<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x3158780 Offset: 0x3158881 VA: 0x3158780
	|-List<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x315B790 Offset: 0x315B891 VA: 0x315B790
	|-List<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x315E850 Offset: 0x315E951 VA: 0x315E850
	|-List<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3161890 Offset: 0x3161991 VA: 0x3161890
	|-List<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3164840 Offset: 0x3164941 VA: 0x3164840
	|-List<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x31677F0 Offset: 0x31678F1 VA: 0x31677F0
	|-List<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x316ACD0 Offset: 0x316ADD1 VA: 0x316ACD0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x316E230 Offset: 0x316E331 VA: 0x316E230
	|-List<CropDataTable>..ctor
	|
	|-RVA: 0x3171800 Offset: 0x3171901 VA: 0x3171800
	|-List<DropItemParam>..ctor
	|
	|-RVA: 0x31747B0 Offset: 0x31748B1 VA: 0x31747B0
	|-List<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x31DB440 Offset: 0x31DB541 VA: 0x31DB440
	|-List<EventCheckId>..ctor
	|
	|-RVA: 0x31DE7E0 Offset: 0x31DE8E1 VA: 0x31DE7E0
	|-List<EventFlagProgressData>..ctor
	|
	|-RVA: 0x31E1830 Offset: 0x31E1931 VA: 0x31E1830
	|-List<FesNpcScoreData>..ctor
	|
	|-RVA: 0x31E4880 Offset: 0x31E4981 VA: 0x31E4880
	|-List<MiningPointSaveData>..ctor
	|
	|-RVA: 0x31E7DE0 Offset: 0x31E7EE1 VA: 0x31E7DE0
	|-List<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x31EB300 Offset: 0x31EB401 VA: 0x31EB300
	|-List<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x31EE350 Offset: 0x31EE451 VA: 0x31EE350
	|-List<NPCActionData>..ctor
	|
	|-RVA: 0x31F1A10 Offset: 0x31F1B11 VA: 0x31F1A10
	|-List<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x31F4DB0 Offset: 0x31F4EB1 VA: 0x31F4DB0
	|-List<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31F7E70 Offset: 0x31F7F71 VA: 0x31F7E70
	|-List<OrderSaveParameter>..ctor
	|
	|-RVA: 0x31FB220 Offset: 0x31FB321 VA: 0x31FB220
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x330A490 Offset: 0x330A591 VA: 0x330A490
	|-List<ShopCatalogPage>..ctor
	|
	|-RVA: 0x330D4D0 Offset: 0x330D5D1 VA: 0x330D4D0
	|-List<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3310A90 Offset: 0x3310B91 VA: 0x3310A90
	|-List<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3313B50 Offset: 0x3313C51 VA: 0x3313B50
	|-List<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3316B20 Offset: 0x3316C21 VA: 0x3316B20
	|-List<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3319BE0 Offset: 0x3319CE1 VA: 0x3319BE0
	|-List<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x331CF90 Offset: 0x331D091 VA: 0x331CF90
	|-List<Schedule>..ctor
	|
	|-RVA: 0x33202E0 Offset: 0x33203E1 VA: 0x33202E0
	|-List<CurveSample>..ctor
	|
	|-RVA: 0x3323B90 Offset: 0x3323C91 VA: 0x3323B90
	|-List<bool>..ctor
	|
	|-RVA: 0x3326B80 Offset: 0x3326C81 VA: 0x3326B80
	|-List<byte>..ctor
	|
	|-RVA: 0x3329B50 Offset: 0x3329C51 VA: 0x3329B50
	|-List<char>..ctor
	|
	|-RVA: 0x3357BA0 Offset: 0x3357CA1 VA: 0x3357BA0
	|-List<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x335ABF0 Offset: 0x335ACF1 VA: 0x335ABF0
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x335DC40 Offset: 0x335DD41 VA: 0x335DC40
	|-List<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3360C80 Offset: 0x3360D81 VA: 0x3360C80
	|-List<DateTime>..ctor
	|
	|-RVA: 0x3363C30 Offset: 0x3363D31 VA: 0x3363C30
	|-List<double>..ctor
	|
	|-RVA: 0x3366BE0 Offset: 0x3366CE1 VA: 0x3366BE0
	|-List<short>..ctor
	|
	|-RVA: 0x3369B90 Offset: 0x3369C91 VA: 0x3369B90
	|-List<int>..ctor
	|
	|-RVA: 0x336FAF0 Offset: 0x336FBF1 VA: 0x336FAF0
	|-List<long>..ctor
	|
	|-RVA: 0x3372AA0 Offset: 0x3372BA1 VA: 0x3372AA0
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3375AE0 Offset: 0x3375BE1 VA: 0x3375AE0
	|-List<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3404770 Offset: 0x3404871 VA: 0x3404770
	|-List<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x3407D30 Offset: 0x3407E31 VA: 0x3407D30
	|-List<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x340B2F0 Offset: 0x340B3F1 VA: 0x340B2F0
	|-List<Nullable<Color32>>..ctor
	|
	|-RVA: 0x340E2F0 Offset: 0x340E3F1 VA: 0x340E2F0
	|-List<Nullable<Color>>..ctor
	|
	|-RVA: 0x3411750 Offset: 0x3411851 VA: 0x3411750
	|-List<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3414870 Offset: 0x3414971 VA: 0x3414870
	|-List<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3417CC0 Offset: 0x3417DC1 VA: 0x3417CC0
	|-List<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x341B120 Offset: 0x341B221 VA: 0x341B120
	|-List<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x341E120 Offset: 0x341E221 VA: 0x341E120
	|-List<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3421B60 Offset: 0x3421C61 VA: 0x3421B60
	|-List<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3261A30 Offset: 0x3261B31 VA: 0x3261A30
	|-List<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3264B50 Offset: 0x3264C51 VA: 0x3264B50
	|-List<Nullable<Rect>>..ctor
	|
	|-RVA: 0x3267FB0 Offset: 0x32680B1 VA: 0x3267FB0
	|-List<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x326B410 Offset: 0x326B511 VA: 0x326B410
	|-List<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x326E530 Offset: 0x326E631 VA: 0x326E530
	|-List<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x3271650 Offset: 0x3271751 VA: 0x3271650
	|-List<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32746C0 Offset: 0x32747C1 VA: 0x32746C0
	|-List<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x3277730 Offset: 0x3277831 VA: 0x3277730
	|-List<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x327DAC0 Offset: 0x327DBC1 VA: 0x327DAC0
	|-List<sbyte>..ctor
	|
	|-RVA: 0x3280A90 Offset: 0x3280B91 VA: 0x3280A90
	|-List<float>..ctor
	|
	|-RVA: 0x32A7CF0 Offset: 0x32A7DF1 VA: 0x32A7CF0
	|-List<ushort>..ctor
	|
	|-RVA: 0x32AACA0 Offset: 0x32AADA1 VA: 0x32AACA0
	|-List<uint>..ctor
	|
	|-RVA: 0x32ADC50 Offset: 0x32ADD51 VA: 0x32ADC50
	|-List<ulong>..ctor
	|
	|-RVA: 0x32BFC30 Offset: 0x32BFD31 VA: 0x32BFC30
	|-List<ValueTuple<CharacterBase, float>>..ctor
	|-List<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32BCBF0 Offset: 0x32BCCF1 VA: 0x32BCBF0
	|-List<ValueTuple<FocusInterface, Collider>>..ctor
	|-List<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32B6B60 Offset: 0x32B6C61 VA: 0x32B6B60
	|-List<ValueTuple<SoundID, EnvironmentSoundController>>..ctor
	|-List<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32B0C00 Offset: 0x32B0D01 VA: 0x32B0C00
	|-List<ValueTuple<bool, ItemID>>..ctor
	|-List<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32B3BB0 Offset: 0x32B3CB1 VA: 0x32B3BB0
	|-List<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32B9BB0 Offset: 0x32B9CB1 VA: 0x32B9BB0
	|-List<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32C2C70 Offset: 0x32C2D71 VA: 0x32C2C70
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32C5D30 Offset: 0x32C5E31 VA: 0x32C5D30
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x310F990 Offset: 0x310FA91 VA: 0x310F990
	|-List<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3113080 Offset: 0x3113181 VA: 0x3113080
	|-List<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x3116140 Offset: 0x3116241 VA: 0x3116140
	|-List<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x3119190 Offset: 0x3119291 VA: 0x3119190
	|-List<CapEdge>..ctor
	|
	|-RVA: 0x311C6F0 Offset: 0x311C7F1 VA: 0x311C6F0
	|-List<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x311F6A0 Offset: 0x311F7A1 VA: 0x311F6A0
	|-List<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x31229F0 Offset: 0x3122AF1 VA: 0x31229F0
	|-List<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x3125FB0 Offset: 0x31260B1 VA: 0x3125FB0
	|-List<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x3128FC0 Offset: 0x31290C1 VA: 0x3128FC0
	|-List<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x312CB90 Offset: 0x312CC91 VA: 0x312CB90
	|-List<ConstraintSource>..ctor
	|
	|-RVA: 0x312FBD0 Offset: 0x312FCD1 VA: 0x312FBD0
	|-List<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x321B760 Offset: 0x321B861 VA: 0x321B760
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x321E7B0 Offset: 0x321E8B1 VA: 0x321E7B0
	|-List<BoneWeight>..ctor
	|
	|-RVA: 0x3221B10 Offset: 0x3221C11 VA: 0x3221B10
	|-List<Bounds>..ctor
	|
	|-RVA: 0x3224E60 Offset: 0x3224F61 VA: 0x3224E60
	|-List<BoundsInt>..ctor
	|
	|-RVA: 0x32281B0 Offset: 0x32282B1 VA: 0x32281B0
	|-List<Color32>..ctor
	|
	|-RVA: 0x322B180 Offset: 0x322B281 VA: 0x322B180
	|-List<Color>..ctor
	|
	|-RVA: 0x322E200 Offset: 0x322E301 VA: 0x322E200
	|-List<CombineInstance>..ctor
	|
	|-RVA: 0x3231DF0 Offset: 0x3231EF1 VA: 0x3231DF0
	|-List<RaycastResult>..ctor
	|
	|-RVA: 0x32356D0 Offset: 0x32357D1 VA: 0x32356D0
	|-List<GradientAlphaKey>..ctor
	|
	|-RVA: 0x32386F0 Offset: 0x32387F1 VA: 0x32386F0
	|-List<GradientColorKey>..ctor
	|
	|-RVA: 0x323BA50 Offset: 0x323BB51 VA: 0x323BA50
	|-List<Keyframe>..ctor
	|
	|-RVA: 0x323EF30 Offset: 0x323F031 VA: 0x323EF30
	|-List<LayerMask>..ctor
	|
	|-RVA: 0x3241F00 Offset: 0x3242001 VA: 0x3241F00
	|-List<Matrix4x4>..ctor
	|
	|-RVA: 0x32455B0 Offset: 0x32456B1 VA: 0x32455B0
	|-List<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3248A70 Offset: 0x3248B71 VA: 0x3248A70
	|-List<Playable>..ctor
	|
	|-RVA: 0x324BA80 Offset: 0x324BB81 VA: 0x324BA80
	|-List<PlayableBinding>..ctor
	|
	|-RVA: 0x324EE30 Offset: 0x324EF31 VA: 0x324EE30
	|-List<PlayableGraph>..ctor
	|
	|-RVA: 0x3251E40 Offset: 0x3251F41 VA: 0x3251E40
	|-List<Edge>..ctor
	|
	|-RVA: 0x3254DF0 Offset: 0x3254EF1 VA: 0x3254DF0
	|-List<Quaternion>..ctor
	|
	|-RVA: 0x3257E70 Offset: 0x3257F71 VA: 0x3257E70
	|-List<RangeInt>..ctor
	|
	|-RVA: 0x325AE20 Offset: 0x325AF21 VA: 0x325AE20
	|-List<RaycastHit2D>..ctor
	|
	|-RVA: 0x325E380 Offset: 0x325E481 VA: 0x325E380
	|-List<RaycastHit>..ctor
	|
	|-RVA: 0x33C0230 Offset: 0x33C0331 VA: 0x33C0230
	|-List<Rect>..ctor
	|
	|-RVA: 0x33C32B0 Offset: 0x33C33B1 VA: 0x33C32B0
	|-List<RectInt>..ctor
	|
	|-RVA: 0x33C62C0 Offset: 0x33C63C1 VA: 0x33C62C0
	|-List<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x33C9300 Offset: 0x33C9401 VA: 0x33C9300
	|-List<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x33CD060 Offset: 0x33CD161 VA: 0x33CD060
	|-List<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x33D0070 Offset: 0x33D0171 VA: 0x33D0070
	|-List<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x33D3410 Offset: 0x33D3511 VA: 0x33D3410
	|-List<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x33D67B0 Offset: 0x33D68B1 VA: 0x33D67B0
	|-List<DiagnosticEvent>..ctor
	|
	|-RVA: 0x33D9D70 Offset: 0x33D9E71 VA: 0x33D9D70
	|-List<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x33DD120 Offset: 0x33DD221 VA: 0x33DD120
	|-List<ObjectInitializationData>..ctor
	|
	|-RVA: 0x31B8630 Offset: 0x31B8731 VA: 0x31B8630
	|-List<GlyphRect>..ctor
	|
	|-RVA: 0x31BB640 Offset: 0x31BB741 VA: 0x31BB640
	|-List<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x31BEB20 Offset: 0x31BEC21 VA: 0x31BEB20
	|-List<IntervalTreeNode>..ctor
	|
	|-RVA: 0x31C1E70 Offset: 0x31C1F71 VA: 0x31C1E70
	|-List<IntervalTree.Entry<object>>..ctor
	|-List<IntervalTree.Entry<RuntimeElement>>..ctor
	|
	|-RVA: 0x31C5210 Offset: 0x31C5311 VA: 0x31C5210
	|-List<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x31C85B0 Offset: 0x31C86B1 VA: 0x31C85B0
	|-List<UICharInfo>..ctor
	|
	|-RVA: 0x31CB630 Offset: 0x31CB731 VA: 0x31CB630
	|-List<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x31CE670 Offset: 0x31CE771 VA: 0x31CE670
	|-List<UILineInfo>..ctor
	|
	|-RVA: 0x31D1680 Offset: 0x31D1781 VA: 0x31D1680
	|-List<UIVertex>..ctor
	|
	|-RVA: 0x31D5080 Offset: 0x31D5181 VA: 0x31D5080
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x31D8420 Offset: 0x31D8521 VA: 0x31D8420
	|-List<Vector2>..ctor
	|
	|-RVA: 0x2CE1050 Offset: 0x2CE1151 VA: 0x2CE1050
	|-List<Vector2Int>..ctor
	|
	|-RVA: 0x2CE4000 Offset: 0x2CE4101 VA: 0x2CE4000
	|-List<Vector3>..ctor
	|
	|-RVA: 0x2CE7080 Offset: 0x2CE7181 VA: 0x2CE7080
	|-List<Vector3Int>..ctor
	|
	|-RVA: 0x2CEA140 Offset: 0x2CEA241 VA: 0x2CEA140
	|-List<Vector4>..ctor
	|
	|-RVA: 0x2CED1C0 Offset: 0x2CED2C1 VA: 0x2CED1C0
	|-List<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2CF0ED0 Offset: 0x2CF0FD1 VA: 0x2CF0ED0
	|-List<YieldItemParam>..ctor
	|
	|-RVA: 0x2CF3E80 Offset: 0x2CF3F81 VA: 0x2CF3E80
	|-List<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248C160 Offset: 0x248C261 VA: 0x248C160
	|-List<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x327AC60 Offset: 0x327AD61 VA: 0x327AC60
	|-List<BaffamoDodgeManager.BaffamoMonster>..ctor
	|-List<CharacterBase>..ctor
	|-List<Tween>..ctor
	|-List<FestivalSnowball>..ctor
	|-List<MobBrain>..ctor
	|-List<DelaunayTriangle>..ctor
	|-List<TriangulationPoint>..ctor
	|-List<InfoEntry>..ctor
	|-List<SnowmanManager.Mocomoco>..ctor
	|-List<MeshVertex>..ctor
	|-List<ParameterExpression>..ctor
	|-List<MonoChunkStream.Chunk>..ctor
	|-List<object>..ctor
	|-List<Assembly>..ctor
	|-List<MethodBase>..ctor
	|-List<MethodInfo>..ctor
	|-List<Module>..ctor
	|-List<ExceptionDispatchInfo>..ctor
	|-List<string>..ctor
	|-List<RegexCharClass.SingleRange>..ctor
	|-List<RegexNode>..ctor
	|-List<Timer>..ctor
	|-List<Type>..ctor
	|-List<TMP_FontAsset>..ctor
	|-List<TMP_GlyphPairAdjustmentRecord>..ctor
	|-List<TMP_Style>..ctor
	|-List<UIStrengtheningSlot>..ctor
	|-List<DynamicsSetup.ParseMessage>..ctor
	|-List<SpringBoneSerialization.PivotSerializer>..ctor
	|-List<SpringBoneSerialization.SpringBoneSerializer>..ctor
	|-List<SpringColliderSerialization.IColliderSerializer>..ctor
	|-List<SpringColliderSerialization.TransformSerializer>..ctor
	|-List<TextRecordParsing.Record>..ctor
	|-List<Simplifier.Vertex>..ctor
	|-List<AddressablesImpl.ResourceLocatorInfo>..ctor
	|-List<IResourceLocator>..ctor
	|-List<Camera>..ctor
	|-List<GameObject>..ctor
	|-List<ParticleSystem>..ctor
	|-List<PlayableDirector>..ctor
	|-List<IResourceLocation>..ctor
	|-List<ScriptableObject>..ctor
	|-List<IMarker>..ctor
	|-List<RuntimeElement>..ctor
	|-List<TimelineClip>..ctor
	|-List<TrackAsset>..ctor
	|-List<Transform>..ctor
	|-List<VisualElement>..ctor
	|
	|-RVA: 0x248F500 Offset: 0x248F601 VA: 0x248F500
	|-List<BuildItemData>..ctor
	|
	|-RVA: 0x3155800 Offset: 0x3155901 VA: 0x3155800
	|-List<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x3158850 Offset: 0x3158951 VA: 0x3158850
	|-List<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x315B860 Offset: 0x315B961 VA: 0x315B860
	|-List<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x315E920 Offset: 0x315EA21 VA: 0x315E920
	|-List<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3161960 Offset: 0x3161A61 VA: 0x3161960
	|-List<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3164910 Offset: 0x3164A11 VA: 0x3164910
	|-List<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x31678C0 Offset: 0x31679C1 VA: 0x31678C0
	|-List<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x316ADA0 Offset: 0x316AEA1 VA: 0x316ADA0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x316E300 Offset: 0x316E401 VA: 0x316E300
	|-List<CropDataTable>..ctor
	|
	|-RVA: 0x336CC10 Offset: 0x336CD11 VA: 0x336CC10
	|-List<ActorID>..ctor
	|-List<ItemID>..ctor
	|-List<Int32Enum>..ctor
	|-List<ParticleSystemVertexStream>..ctor
	|
	|-RVA: 0x31718D0 Offset: 0x31719D1 VA: 0x31718D0
	|-List<DropItemParam>..ctor
	|
	|-RVA: 0x3174880 Offset: 0x3174981 VA: 0x3174880
	|-List<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x31DB510 Offset: 0x31DB611 VA: 0x31DB510
	|-List<EventCheckId>..ctor
	|
	|-RVA: 0x31DE8B0 Offset: 0x31DE9B1 VA: 0x31DE8B0
	|-List<EventFlagProgressData>..ctor
	|
	|-RVA: 0x31E1900 Offset: 0x31E1A01 VA: 0x31E1900
	|-List<FesNpcScoreData>..ctor
	|
	|-RVA: 0x31E4950 Offset: 0x31E4A51 VA: 0x31E4950
	|-List<MiningPointSaveData>..ctor
	|
	|-RVA: 0x31E7EB0 Offset: 0x31E7FB1 VA: 0x31E7EB0
	|-List<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x31EB3D0 Offset: 0x31EB4D1 VA: 0x31EB3D0
	|-List<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x31EE420 Offset: 0x31EE521 VA: 0x31EE420
	|-List<NPCActionData>..ctor
	|
	|-RVA: 0x31F1AE0 Offset: 0x31F1BE1 VA: 0x31F1AE0
	|-List<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x31F4E80 Offset: 0x31F4F81 VA: 0x31F4E80
	|-List<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31F7F40 Offset: 0x31F8041 VA: 0x31F7F40
	|-List<OrderSaveParameter>..ctor
	|
	|-RVA: 0x31FB2F0 Offset: 0x31FB3F1 VA: 0x31FB2F0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x330A560 Offset: 0x330A661 VA: 0x330A560
	|-List<ShopCatalogPage>..ctor
	|
	|-RVA: 0x330D5A0 Offset: 0x330D6A1 VA: 0x330D5A0
	|-List<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3310B60 Offset: 0x3310C61 VA: 0x3310B60
	|-List<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3313C20 Offset: 0x3313D21 VA: 0x3313C20
	|-List<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3316BF0 Offset: 0x3316CF1 VA: 0x3316BF0
	|-List<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3319CB0 Offset: 0x3319DB1 VA: 0x3319CB0
	|-List<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x331D060 Offset: 0x331D161 VA: 0x331D060
	|-List<Schedule>..ctor
	|
	|-RVA: 0x33203B0 Offset: 0x33204B1 VA: 0x33203B0
	|-List<CurveSample>..ctor
	|
	|-RVA: 0x3323C60 Offset: 0x3323D61 VA: 0x3323C60
	|-List<bool>..ctor
	|
	|-RVA: 0x3326C50 Offset: 0x3326D51 VA: 0x3326C50
	|-List<byte>..ctor
	|
	|-RVA: 0x3329C20 Offset: 0x3329D21 VA: 0x3329C20
	|-List<char>..ctor
	|
	|-RVA: 0x3357C70 Offset: 0x3357D71 VA: 0x3357C70
	|-List<KeyValuePair<DateTime, object>>..ctor
	|-List<KeyValuePair<DateTime, TimeType>>..ctor
	|
	|-RVA: 0x335ACC0 Offset: 0x335ADC1 VA: 0x335ACC0
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x335DD10 Offset: 0x335DE11 VA: 0x335DD10
	|-List<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3360D50 Offset: 0x3360E51 VA: 0x3360D50
	|-List<DateTime>..ctor
	|
	|-RVA: 0x3363D00 Offset: 0x3363E01 VA: 0x3363D00
	|-List<double>..ctor
	|
	|-RVA: 0x3366CB0 Offset: 0x3366DB1 VA: 0x3366CB0
	|-List<short>..ctor
	|
	|-RVA: 0x3369C60 Offset: 0x3369D61 VA: 0x3369C60
	|-List<int>..ctor
	|
	|-RVA: 0x336FBC0 Offset: 0x336FCC1 VA: 0x336FBC0
	|-List<long>..ctor
	|
	|-RVA: 0x3372B70 Offset: 0x3372C71 VA: 0x3372B70
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3375BB0 Offset: 0x3375CB1 VA: 0x3375BB0
	|-List<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3404840 Offset: 0x3404941 VA: 0x3404840
	|-List<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x3407E00 Offset: 0x3407F01 VA: 0x3407E00
	|-List<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x340B3C0 Offset: 0x340B4C1 VA: 0x340B3C0
	|-List<Nullable<Color32>>..ctor
	|
	|-RVA: 0x340E3C0 Offset: 0x340E4C1 VA: 0x340E3C0
	|-List<Nullable<Color>>..ctor
	|
	|-RVA: 0x3411820 Offset: 0x3411921 VA: 0x3411820
	|-List<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3414940 Offset: 0x3414A41 VA: 0x3414940
	|-List<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3417D90 Offset: 0x3417E91 VA: 0x3417D90
	|-List<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x341B1F0 Offset: 0x341B2F1 VA: 0x341B1F0
	|-List<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x341E1F0 Offset: 0x341E2F1 VA: 0x341E1F0
	|-List<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3421C30 Offset: 0x3421D31 VA: 0x3421C30
	|-List<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3261B00 Offset: 0x3261C01 VA: 0x3261B00
	|-List<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3264C20 Offset: 0x3264D21 VA: 0x3264C20
	|-List<Nullable<Rect>>..ctor
	|
	|-RVA: 0x3268080 Offset: 0x3268181 VA: 0x3268080
	|-List<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x326B4E0 Offset: 0x326B5E1 VA: 0x326B4E0
	|-List<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x326E600 Offset: 0x326E701 VA: 0x326E600
	|-List<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x3271720 Offset: 0x3271821 VA: 0x3271720
	|-List<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x3274790 Offset: 0x3274891 VA: 0x3274790
	|-List<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x3277800 Offset: 0x3277901 VA: 0x3277800
	|-List<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x327DB90 Offset: 0x327DC91 VA: 0x327DB90
	|-List<sbyte>..ctor
	|
	|-RVA: 0x3280B60 Offset: 0x3280C61 VA: 0x3280B60
	|-List<float>..ctor
	|
	|-RVA: 0x32A7DC0 Offset: 0x32A7EC1 VA: 0x32A7DC0
	|-List<ushort>..ctor
	|
	|-RVA: 0x32AAD70 Offset: 0x32AAE71 VA: 0x32AAD70
	|-List<uint>..ctor
	|
	|-RVA: 0x32ADD20 Offset: 0x32ADE21 VA: 0x32ADD20
	|-List<ulong>..ctor
	|
	|-RVA: 0x32B0CD0 Offset: 0x32B0DD1 VA: 0x32B0CD0
	|-List<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32B3C80 Offset: 0x32B3D81 VA: 0x32B3C80
	|-List<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32B6C30 Offset: 0x32B6D31 VA: 0x32B6C30
	|-List<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32B9C80 Offset: 0x32B9D81 VA: 0x32B9C80
	|-List<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32BCCC0 Offset: 0x32BCDC1 VA: 0x32BCCC0
	|-List<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32BFD00 Offset: 0x32BFE01 VA: 0x32BFD00
	|-List<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32C2D40 Offset: 0x32C2E41 VA: 0x32C2D40
	|-List<ValueTuple<CharID, VariationNo, HairType>>..ctor
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32C5E00 Offset: 0x32C5F01 VA: 0x32C5E00
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|-List<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>..ctor
	|
	|-RVA: 0x310FA60 Offset: 0x310FB61 VA: 0x310FA60
	|-List<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3113150 Offset: 0x3113251 VA: 0x3113150
	|-List<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x3116210 Offset: 0x3116311 VA: 0x3116210
	|-List<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x3119260 Offset: 0x3119361 VA: 0x3119260
	|-List<CapEdge>..ctor
	|
	|-RVA: 0x311C7C0 Offset: 0x311C8C1 VA: 0x311C7C0
	|-List<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x311F770 Offset: 0x311F871 VA: 0x311F770
	|-List<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x3122AC0 Offset: 0x3122BC1 VA: 0x3122AC0
	|-List<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x3126080 Offset: 0x3126181 VA: 0x3126080
	|-List<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x3129090 Offset: 0x3129191 VA: 0x3129090
	|-List<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x312CC60 Offset: 0x312CD61 VA: 0x312CC60
	|-List<ConstraintSource>..ctor
	|
	|-RVA: 0x312FCA0 Offset: 0x312FDA1 VA: 0x312FCA0
	|-List<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x321B830 Offset: 0x321B931 VA: 0x321B830
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x321E880 Offset: 0x321E981 VA: 0x321E880
	|-List<BoneWeight>..ctor
	|
	|-RVA: 0x3221BE0 Offset: 0x3221CE1 VA: 0x3221BE0
	|-List<Bounds>..ctor
	|
	|-RVA: 0x3224F30 Offset: 0x3225031 VA: 0x3224F30
	|-List<BoundsInt>..ctor
	|
	|-RVA: 0x3228280 Offset: 0x3228381 VA: 0x3228280
	|-List<Color32>..ctor
	|
	|-RVA: 0x322B250 Offset: 0x322B351 VA: 0x322B250
	|-List<Color>..ctor
	|
	|-RVA: 0x322E2D0 Offset: 0x322E3D1 VA: 0x322E2D0
	|-List<CombineInstance>..ctor
	|
	|-RVA: 0x3231EC0 Offset: 0x3231FC1 VA: 0x3231EC0
	|-List<RaycastResult>..ctor
	|
	|-RVA: 0x32357A0 Offset: 0x32358A1 VA: 0x32357A0
	|-List<GradientAlphaKey>..ctor
	|
	|-RVA: 0x32387C0 Offset: 0x32388C1 VA: 0x32387C0
	|-List<GradientColorKey>..ctor
	|
	|-RVA: 0x323BB20 Offset: 0x323BC21 VA: 0x323BB20
	|-List<Keyframe>..ctor
	|
	|-RVA: 0x323F000 Offset: 0x323F101 VA: 0x323F000
	|-List<LayerMask>..ctor
	|
	|-RVA: 0x3241FD0 Offset: 0x32420D1 VA: 0x3241FD0
	|-List<Matrix4x4>..ctor
	|
	|-RVA: 0x3245680 Offset: 0x3245781 VA: 0x3245680
	|-List<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3248B40 Offset: 0x3248C41 VA: 0x3248B40
	|-List<Playable>..ctor
	|
	|-RVA: 0x324BB50 Offset: 0x324BC51 VA: 0x324BB50
	|-List<PlayableBinding>..ctor
	|
	|-RVA: 0x324EF00 Offset: 0x324F001 VA: 0x324EF00
	|-List<PlayableGraph>..ctor
	|
	|-RVA: 0x3251F10 Offset: 0x3252011 VA: 0x3251F10
	|-List<Edge>..ctor
	|
	|-RVA: 0x3254EC0 Offset: 0x3254FC1 VA: 0x3254EC0
	|-List<Quaternion>..ctor
	|
	|-RVA: 0x3257F40 Offset: 0x3258041 VA: 0x3257F40
	|-List<RangeInt>..ctor
	|
	|-RVA: 0x325AEF0 Offset: 0x325AFF1 VA: 0x325AEF0
	|-List<RaycastHit2D>..ctor
	|
	|-RVA: 0x325E450 Offset: 0x325E551 VA: 0x325E450
	|-List<RaycastHit>..ctor
	|
	|-RVA: 0x33C0300 Offset: 0x33C0401 VA: 0x33C0300
	|-List<Rect>..ctor
	|
	|-RVA: 0x33C3380 Offset: 0x33C3481 VA: 0x33C3380
	|-List<RectInt>..ctor
	|
	|-RVA: 0x33C6390 Offset: 0x33C6491 VA: 0x33C6390
	|-List<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x33C93D0 Offset: 0x33C94D1 VA: 0x33C93D0
	|-List<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x33CD130 Offset: 0x33CD231 VA: 0x33CD130
	|-List<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x33D0140 Offset: 0x33D0241 VA: 0x33D0140
	|-List<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x33D34E0 Offset: 0x33D35E1 VA: 0x33D34E0
	|-List<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x33D6880 Offset: 0x33D6981 VA: 0x33D6880
	|-List<DiagnosticEvent>..ctor
	|
	|-RVA: 0x33D9E40 Offset: 0x33D9F41 VA: 0x33D9E40
	|-List<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x33DD1F0 Offset: 0x33DD2F1 VA: 0x33DD1F0
	|-List<ObjectInitializationData>..ctor
	|
	|-RVA: 0x31B8700 Offset: 0x31B8801 VA: 0x31B8700
	|-List<GlyphRect>..ctor
	|
	|-RVA: 0x31BB710 Offset: 0x31BB811 VA: 0x31BB710
	|-List<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x31BEBF0 Offset: 0x31BECF1 VA: 0x31BEBF0
	|-List<IntervalTreeNode>..ctor
	|
	|-RVA: 0x31C1F40 Offset: 0x31C2041 VA: 0x31C1F40
	|-List<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x31C52E0 Offset: 0x31C53E1 VA: 0x31C52E0
	|-List<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x31C8680 Offset: 0x31C8781 VA: 0x31C8680
	|-List<UICharInfo>..ctor
	|
	|-RVA: 0x31CB700 Offset: 0x31CB801 VA: 0x31CB700
	|-List<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x31CE740 Offset: 0x31CE841 VA: 0x31CE740
	|-List<UILineInfo>..ctor
	|
	|-RVA: 0x31D1750 Offset: 0x31D1851 VA: 0x31D1750
	|-List<UIVertex>..ctor
	|
	|-RVA: 0x31D5150 Offset: 0x31D5251 VA: 0x31D5150
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x31D84F0 Offset: 0x31D85F1 VA: 0x31D84F0
	|-List<Vector2>..ctor
	|
	|-RVA: 0x2CE1120 Offset: 0x2CE1221 VA: 0x2CE1120
	|-List<Vector2Int>..ctor
	|
	|-RVA: 0x2CE40D0 Offset: 0x2CE41D1 VA: 0x2CE40D0
	|-List<Vector3>..ctor
	|
	|-RVA: 0x2CE7150 Offset: 0x2CE7251 VA: 0x2CE7150
	|-List<Vector3Int>..ctor
	|
	|-RVA: 0x2CEA210 Offset: 0x2CEA311 VA: 0x2CEA210
	|-List<Vector4>..ctor
	|
	|-RVA: 0x2CED290 Offset: 0x2CED391 VA: 0x2CED290
	|-List<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2CF0FA0 Offset: 0x2CF10A1 VA: 0x2CF0FA0
	|-List<YieldItemParam>..ctor
	|
	|-RVA: 0x2CF3F50 Offset: 0x2CF4051 VA: 0x2CF3F50
	|-List<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248C290 Offset: 0x248C391 VA: 0x248C290
	|-List<AS_ToolController.ChargeInfo>..ctor
	|
	|-RVA: 0x327AD90 Offset: 0x327AE91 VA: 0x327AD90
	|-List<AracneFlatWeb>..ctor
	|-List<BeanSowingActionTerm>..ctor
	|-List<FracturedChunk.AdjacencyInfo>..ctor
	|-List<GluttonFoodData>..ctor
	|-List<GluttonItemTerm>..ctor
	|-List<ItemData>..ctor
	|-List<ItemEquip>..ctor
	|-List<MovieRoomData>..ctor
	|-List<OrderData>..ctor
	|-List<PartyBase>..ctor
	|-List<Point2D>..ctor
	|-List<FishShipmentRecords>..ctor
	|-List<Settings.KeyboardShortcut>..ctor
	|-List<SnowballObjectSpawnTerm>..ctor
	|-List<StampData>..ctor
	|-List<Exception>..ctor
	|-List<WebConnectionGroup>..ctor
	|-List<object>..ctor
	|-List<ExceptionDispatchInfo>..ctor
	|-List<string>..ctor
	|-List<UIButtonLinkerInScrollBox>..ctor
	|-List<MeshData>..ctor
	|-List<NavMeshModifier>..ctor
	|-List<NavMeshModifierVolume>..ctor
	|-List<IResourceLocation>..ctor
	|-List<TimelineClip>..ctor
	|-List<TrackAsset>..ctor
	|-List<Selectable>..ctor
	|-List<EventCallbackFunctorBase>..ctor
	|-List<VoiceCommentData>..ctor
	|
	|-RVA: 0x248F630 Offset: 0x248F731 VA: 0x248F630
	|-List<BuildItemData>..ctor
	|
	|-RVA: 0x3155930 Offset: 0x3155A31 VA: 0x3155930
	|-List<ButtonLinker.LinkObject>..ctor
	|
	|-RVA: 0x3158980 Offset: 0x3158A81 VA: 0x3158980
	|-List<CharaCallTable.BustupTable>..ctor
	|
	|-RVA: 0x315B990 Offset: 0x315BA91 VA: 0x315B990
	|-List<CharaCallTable.CharaFaceIconTable>..ctor
	|
	|-RVA: 0x315EA50 Offset: 0x315EB51 VA: 0x315EA50
	|-List<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3161A90 Offset: 0x3161B91 VA: 0x3161A90
	|-List<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3164A40 Offset: 0x3164B41 VA: 0x3164A40
	|-List<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x31679F0 Offset: 0x3167AF1 VA: 0x31679F0
	|-List<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x316AED0 Offset: 0x316AFD1 VA: 0x316AED0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x316E430 Offset: 0x316E531 VA: 0x316E430
	|-List<CropDataTable>..ctor
	|
	|-RVA: 0x3171A00 Offset: 0x3171B01 VA: 0x3171A00
	|-List<DropItemParam>..ctor
	|
	|-RVA: 0x31749B0 Offset: 0x3174AB1 VA: 0x31749B0
	|-List<ErosionBrush.UndoStep>..ctor
	|
	|-RVA: 0x31DB640 Offset: 0x31DB741 VA: 0x31DB640
	|-List<EventCheckId>..ctor
	|
	|-RVA: 0x31DE9E0 Offset: 0x31DEAE1 VA: 0x31DE9E0
	|-List<EventFlagProgressData>..ctor
	|
	|-RVA: 0x31E1A30 Offset: 0x31E1B31 VA: 0x31E1A30
	|-List<FesNpcScoreData>..ctor
	|
	|-RVA: 0x31E4A80 Offset: 0x31E4B81 VA: 0x31E4A80
	|-List<MiningPointSaveData>..ctor
	|
	|-RVA: 0x336CD40 Offset: 0x336CE41 VA: 0x336CD40
	|-List<MonsterActionBehaviorType>..ctor
	|-List<RecipeId>..ctor
	|-List<Int32Enum>..ctor
	|
	|-RVA: 0x31E7FE0 Offset: 0x31E80E1 VA: 0x31E7FE0
	|-List<MonsterHutSaveData>..ctor
	|
	|-RVA: 0x31EB500 Offset: 0x31EB601 VA: 0x31EB500
	|-List<MoviePlayer.SUBTITLEDATA>..ctor
	|
	|-RVA: 0x31EE550 Offset: 0x31EE651 VA: 0x31EE550
	|-List<NPCActionData>..ctor
	|
	|-RVA: 0x31F1C10 Offset: 0x31F1D11 VA: 0x31F1C10
	|-List<NpcPlaceSchedule>..ctor
	|
	|-RVA: 0x31F4FB0 Offset: 0x31F50B1 VA: 0x31F4FB0
	|-List<OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x31F8070 Offset: 0x31F8171 VA: 0x31F8070
	|-List<OrderSaveParameter>..ctor
	|
	|-RVA: 0x31FB420 Offset: 0x31FB521 VA: 0x31FB420
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x330A690 Offset: 0x330A791 VA: 0x330A690
	|-List<ShopCatalogPage>..ctor
	|
	|-RVA: 0x330D6D0 Offset: 0x330D7D1 VA: 0x330D6D0
	|-List<ShopNpcTalk>..ctor
	|
	|-RVA: 0x3310C90 Offset: 0x3310D91 VA: 0x3310C90
	|-List<SubtitleDataTable.Data>..ctor
	|
	|-RVA: 0x3313D50 Offset: 0x3313E51 VA: 0x3313D50
	|-List<SubtitleDataTable.DataList>..ctor
	|
	|-RVA: 0x3316D20 Offset: 0x3316E21 VA: 0x3316D20
	|-List<SubtitleHudDataTable.Data>..ctor
	|
	|-RVA: 0x3319DE0 Offset: 0x3319EE1 VA: 0x3319DE0
	|-List<SRMonoBehaviourEx.FieldInfo>..ctor
	|
	|-RVA: 0x331D190 Offset: 0x331D291 VA: 0x331D190
	|-List<Schedule>..ctor
	|
	|-RVA: 0x33204E0 Offset: 0x33205E1 VA: 0x33204E0
	|-List<CurveSample>..ctor
	|
	|-RVA: 0x3323D90 Offset: 0x3323E91 VA: 0x3323D90
	|-List<bool>..ctor
	|
	|-RVA: 0x3326D80 Offset: 0x3326E81 VA: 0x3326D80
	|-List<byte>..ctor
	|
	|-RVA: 0x3329D50 Offset: 0x3329E51 VA: 0x3329D50
	|-List<char>..ctor
	|
	|-RVA: 0x3357DA0 Offset: 0x3357EA1 VA: 0x3357DA0
	|-List<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x335ADF0 Offset: 0x335AEF1 VA: 0x335ADF0
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x335DE40 Offset: 0x335DF41 VA: 0x335DE40
	|-List<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3360E80 Offset: 0x3360F81 VA: 0x3360E80
	|-List<DateTime>..ctor
	|
	|-RVA: 0x3363E30 Offset: 0x3363F31 VA: 0x3363E30
	|-List<double>..ctor
	|
	|-RVA: 0x3366DE0 Offset: 0x3366EE1 VA: 0x3366DE0
	|-List<short>..ctor
	|
	|-RVA: 0x3369D90 Offset: 0x3369E91 VA: 0x3369D90
	|-List<int>..ctor
	|
	|-RVA: 0x336FCF0 Offset: 0x336FDF1 VA: 0x336FCF0
	|-List<long>..ctor
	|
	|-RVA: 0x3372CA0 Offset: 0x3372DA1 VA: 0x3372CA0
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3375CE0 Offset: 0x3375DE1 VA: 0x3375CE0
	|-List<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x3404970 Offset: 0x3404A71 VA: 0x3404970
	|-List<Nullable<Bounds>>..ctor
	|
	|-RVA: 0x3407F30 Offset: 0x3408031 VA: 0x3407F30
	|-List<Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x340B4F0 Offset: 0x340B5F1 VA: 0x340B4F0
	|-List<Nullable<Color32>>..ctor
	|
	|-RVA: 0x340E4F0 Offset: 0x340E5F1 VA: 0x340E4F0
	|-List<Nullable<Color>>..ctor
	|
	|-RVA: 0x3411950 Offset: 0x3411A51 VA: 0x3411950
	|-List<Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3414A70 Offset: 0x3414B71 VA: 0x3414A70
	|-List<Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3417EC0 Offset: 0x3417FC1 VA: 0x3417EC0
	|-List<Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x341B320 Offset: 0x341B421 VA: 0x341B320
	|-List<Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x341E320 Offset: 0x341E421 VA: 0x341E320
	|-List<Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3421D60 Offset: 0x3421E61 VA: 0x3421D60
	|-List<Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3261C30 Offset: 0x3261D31 VA: 0x3261C30
	|-List<Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3264D50 Offset: 0x3264E51 VA: 0x3264D50
	|-List<Nullable<Rect>>..ctor
	|
	|-RVA: 0x32681B0 Offset: 0x32682B1 VA: 0x32681B0
	|-List<Nullable<RectInt>>..ctor
	|
	|-RVA: 0x326B610 Offset: 0x326B711 VA: 0x326B610
	|-List<Nullable<Vector2>>..ctor
	|
	|-RVA: 0x326E730 Offset: 0x326E831 VA: 0x326E730
	|-List<Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x3271850 Offset: 0x3271951 VA: 0x3271850
	|-List<Nullable<Vector3>>..ctor
	|
	|-RVA: 0x32748C0 Offset: 0x32749C1 VA: 0x32748C0
	|-List<Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x3277930 Offset: 0x3277A31 VA: 0x3277930
	|-List<Nullable<Vector4>>..ctor
	|
	|-RVA: 0x327DCC0 Offset: 0x327DDC1 VA: 0x327DCC0
	|-List<sbyte>..ctor
	|
	|-RVA: 0x3280C90 Offset: 0x3280D91 VA: 0x3280C90
	|-List<float>..ctor
	|
	|-RVA: 0x32A7EF0 Offset: 0x32A7FF1 VA: 0x32A7EF0
	|-List<ushort>..ctor
	|
	|-RVA: 0x32AAEA0 Offset: 0x32AAFA1 VA: 0x32AAEA0
	|-List<uint>..ctor
	|
	|-RVA: 0x32ADE50 Offset: 0x32ADF51 VA: 0x32ADE50
	|-List<ulong>..ctor
	|
	|-RVA: 0x32B0E00 Offset: 0x32B0F01 VA: 0x32B0E00
	|-List<ValueTuple<bool, Int32Enum>>..ctor
	|
	|-RVA: 0x32B3DB0 Offset: 0x32B3EB1 VA: 0x32B3DB0
	|-List<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x32B6D60 Offset: 0x32B6E61 VA: 0x32B6D60
	|-List<ValueTuple<Int32Enum, object>>..ctor
	|
	|-RVA: 0x32B9DB0 Offset: 0x32B9EB1 VA: 0x32B9DB0
	|-List<ValueTuple<object, Int32Enum>>..ctor
	|
	|-RVA: 0x32BCDF0 Offset: 0x32BCEF1 VA: 0x32BCDF0
	|-List<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x32BFE30 Offset: 0x32BFF31 VA: 0x32BFE30
	|-List<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x32C2E70 Offset: 0x32C2F71 VA: 0x32C2E70
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x32C5F30 Offset: 0x32C6031 VA: 0x32C5F30
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>..ctor
	|
	|-RVA: 0x310FB90 Offset: 0x310FC91 VA: 0x310FB90
	|-List<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3113280 Offset: 0x3113381 VA: 0x3113280
	|-List<TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x3116340 Offset: 0x3116441 VA: 0x3116340
	|-List<UIMainManagerAttachObject.AttachSet>..ctor
	|
	|-RVA: 0x3119390 Offset: 0x3119491 VA: 0x3119390
	|-List<CapEdge>..ctor
	|
	|-RVA: 0x311C8F0 Offset: 0x311C9F1 VA: 0x311C8F0
	|-List<MeshDataConnectivity.Face>..ctor
	|
	|-RVA: 0x311F8A0 Offset: 0x311F9A1 VA: 0x311F8A0
	|-List<MeshFaceConnectivity.EdgeData.SideData>..ctor
	|
	|-RVA: 0x3122BF0 Offset: 0x3122CF1 VA: 0x3122BF0
	|-List<MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x31261B0 Offset: 0x31262B1 VA: 0x31261B0
	|-List<NavMeshBuildMarkup>..ctor
	|
	|-RVA: 0x31291C0 Offset: 0x31292C1 VA: 0x31291C0
	|-List<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x312CD90 Offset: 0x312CE91 VA: 0x312CD90
	|-List<ConstraintSource>..ctor
	|
	|-RVA: 0x312FDD0 Offset: 0x312FED1 VA: 0x312FDD0
	|-List<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x321B960 Offset: 0x321BA61 VA: 0x321B960
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x321E9B0 Offset: 0x321EAB1 VA: 0x321E9B0
	|-List<BoneWeight>..ctor
	|
	|-RVA: 0x3221D10 Offset: 0x3221E11 VA: 0x3221D10
	|-List<Bounds>..ctor
	|
	|-RVA: 0x3225060 Offset: 0x3225161 VA: 0x3225060
	|-List<BoundsInt>..ctor
	|
	|-RVA: 0x32283B0 Offset: 0x32284B1 VA: 0x32283B0
	|-List<Color32>..ctor
	|
	|-RVA: 0x322B380 Offset: 0x322B481 VA: 0x322B380
	|-List<Color>..ctor
	|
	|-RVA: 0x322E400 Offset: 0x322E501 VA: 0x322E400
	|-List<CombineInstance>..ctor
	|
	|-RVA: 0x3231FF0 Offset: 0x32320F1 VA: 0x3231FF0
	|-List<RaycastResult>..ctor
	|
	|-RVA: 0x32358D0 Offset: 0x32359D1 VA: 0x32358D0
	|-List<GradientAlphaKey>..ctor
	|
	|-RVA: 0x32388F0 Offset: 0x32389F1 VA: 0x32388F0
	|-List<GradientColorKey>..ctor
	|
	|-RVA: 0x323BC50 Offset: 0x323BD51 VA: 0x323BC50
	|-List<Keyframe>..ctor
	|
	|-RVA: 0x323F130 Offset: 0x323F231 VA: 0x323F130
	|-List<LayerMask>..ctor
	|
	|-RVA: 0x3242100 Offset: 0x3242201 VA: 0x3242100
	|-List<Matrix4x4>..ctor
	|
	|-RVA: 0x32457B0 Offset: 0x32458B1 VA: 0x32457B0
	|-List<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3248C70 Offset: 0x3248D71 VA: 0x3248C70
	|-List<Playable>..ctor
	|
	|-RVA: 0x324BC80 Offset: 0x324BD81 VA: 0x324BC80
	|-List<PlayableBinding>..ctor
	|
	|-RVA: 0x324F030 Offset: 0x324F131 VA: 0x324F030
	|-List<PlayableGraph>..ctor
	|
	|-RVA: 0x3252040 Offset: 0x3252141 VA: 0x3252040
	|-List<Edge>..ctor
	|
	|-RVA: 0x3254FF0 Offset: 0x32550F1 VA: 0x3254FF0
	|-List<Quaternion>..ctor
	|
	|-RVA: 0x3258070 Offset: 0x3258171 VA: 0x3258070
	|-List<RangeInt>..ctor
	|
	|-RVA: 0x325B020 Offset: 0x325B121 VA: 0x325B020
	|-List<RaycastHit2D>..ctor
	|
	|-RVA: 0x325E580 Offset: 0x325E681 VA: 0x325E580
	|-List<RaycastHit>..ctor
	|
	|-RVA: 0x33C0430 Offset: 0x33C0531 VA: 0x33C0430
	|-List<Rect>..ctor
	|
	|-RVA: 0x33C34B0 Offset: 0x33C35B1 VA: 0x33C34B0
	|-List<RectInt>..ctor
	|
	|-RVA: 0x33C64C0 Offset: 0x33C65C1 VA: 0x33C64C0
	|-List<ReflectionProbeBlendInfo>..ctor
	|
	|-RVA: 0x33C9500 Offset: 0x33C9601 VA: 0x33C9500
	|-List<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x33CD260 Offset: 0x33CD361 VA: 0x33CD260
	|-List<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x33D0270 Offset: 0x33D0371 VA: 0x33D0270
	|-List<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x33D3610 Offset: 0x33D3711 VA: 0x33D3610
	|-List<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x33D69B0 Offset: 0x33D6AB1 VA: 0x33D69B0
	|-List<DiagnosticEvent>..ctor
	|
	|-RVA: 0x33D9F70 Offset: 0x33DA071 VA: 0x33D9F70
	|-List<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x33DD320 Offset: 0x33DD421 VA: 0x33DD320
	|-List<ObjectInitializationData>..ctor
	|
	|-RVA: 0x31B8830 Offset: 0x31B8931 VA: 0x31B8830
	|-List<GlyphRect>..ctor
	|
	|-RVA: 0x31BB840 Offset: 0x31BB941 VA: 0x31BB840
	|-List<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x31BED20 Offset: 0x31BEE21 VA: 0x31BED20
	|-List<IntervalTreeNode>..ctor
	|
	|-RVA: 0x31C2070 Offset: 0x31C2171 VA: 0x31C2070
	|-List<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x31C5410 Offset: 0x31C5511 VA: 0x31C5410
	|-List<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x31C87B0 Offset: 0x31C88B1 VA: 0x31C87B0
	|-List<UICharInfo>..ctor
	|
	|-RVA: 0x31CB830 Offset: 0x31CB931 VA: 0x31CB830
	|-List<FocusController.FocusedElement>..ctor
	|
	|-RVA: 0x31CE870 Offset: 0x31CE971 VA: 0x31CE870
	|-List<UILineInfo>..ctor
	|
	|-RVA: 0x31D1880 Offset: 0x31D1981 VA: 0x31D1880
	|-List<UIVertex>..ctor
	|
	|-RVA: 0x31D5280 Offset: 0x31D5381 VA: 0x31D5280
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x31D8620 Offset: 0x31D8721 VA: 0x31D8620
	|-List<Vector2>..ctor
	|
	|-RVA: 0x2CE1250 Offset: 0x2CE1351 VA: 0x2CE1250
	|-List<Vector2Int>..ctor
	|
	|-RVA: 0x2CE4200 Offset: 0x2CE4301 VA: 0x2CE4200
	|-List<Vector3>..ctor
	|
	|-RVA: 0x2CE7280 Offset: 0x2CE7381 VA: 0x2CE7280
	|-List<Vector3Int>..ctor
	|
	|-RVA: 0x2CEA340 Offset: 0x2CEA441 VA: 0x2CEA340
	|-List<Vector4>..ctor
	|
	|-RVA: 0x2CED3C0 Offset: 0x2CED4C1 VA: 0x2CED3C0
	|-List<WarpPoints.WarpPoint>..ctor
	|
	|-RVA: 0x2CF10D0 Offset: 0x2CF11D1 VA: 0x2CF10D0
	|-List<YieldItemParam>..ctor
	|
	|-RVA: 0x2CF4080 Offset: 0x2CF4181 VA: 0x2CF4080
	|-List<stCommand_t>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248C850 Offset: 0x248C951 VA: 0x248C850
	|-List<AS_ToolController.ChargeInfo>.get_Capacity
	|
	|-RVA: 0x248FC20 Offset: 0x248FD21 VA: 0x248FC20
	|-List<BuildItemData>.get_Capacity
	|
	|-RVA: 0x3155ED0 Offset: 0x3155FD1 VA: 0x3155ED0
	|-List<ButtonLinker.LinkObject>.get_Capacity
	|
	|-RVA: 0x3158F20 Offset: 0x3159021 VA: 0x3158F20
	|-List<CharaCallTable.BustupTable>.get_Capacity
	|
	|-RVA: 0x315BF30 Offset: 0x315C031 VA: 0x315BF30
	|-List<CharaCallTable.CharaFaceIconTable>.get_Capacity
	|
	|-RVA: 0x315EFF0 Offset: 0x315F0F1 VA: 0x315EFF0
	|-List<CameraState.CustomBlendable>.get_Capacity
	|
	|-RVA: 0x3162030 Offset: 0x3162131 VA: 0x3162030
	|-List<CinemachineClearShot.Pair>.get_Capacity
	|
	|-RVA: 0x3164FE0 Offset: 0x31650E1 VA: 0x3164FE0
	|-List<CinemachineStateDrivenCamera.HashPair>.get_Capacity
	|
	|-RVA: 0x3167FB0 Offset: 0x31680B1 VA: 0x3167FB0
	|-List<TargetPositionCache.CacheCurve.Item>.get_Capacity
	|
	|-RVA: 0x316B490 Offset: 0x316B591 VA: 0x316B490
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.get_Capacity
	|
	|-RVA: 0x316EA00 Offset: 0x316EB01 VA: 0x316EA00
	|-List<CropDataTable>.get_Capacity
	|
	|-RVA: 0x327B330 Offset: 0x327B431 VA: 0x327B330
	|-List<Tween>.get_Capacity
	|-List<object>.get_Capacity
	|-List<Timer>.get_Capacity
	|-List<GameObject>.get_Capacity
	|-List<VisualElement>.get_Capacity
	|
	|-RVA: 0x3171FA0 Offset: 0x31720A1 VA: 0x3171FA0
	|-List<DropItemParam>.get_Capacity
	|
	|-RVA: 0x3174F70 Offset: 0x3175071 VA: 0x3174F70
	|-List<ErosionBrush.UndoStep>.get_Capacity
	|
	|-RVA: 0x31DBC00 Offset: 0x31DBD01 VA: 0x31DBC00
	|-List<EventCheckId>.get_Capacity
	|
	|-RVA: 0x31DEF80 Offset: 0x31DF081 VA: 0x31DEF80
	|-List<EventFlagProgressData>.get_Capacity
	|
	|-RVA: 0x31E1FD0 Offset: 0x31E20D1 VA: 0x31E1FD0
	|-List<FesNpcScoreData>.get_Capacity
	|
	|-RVA: 0x31E5040 Offset: 0x31E5141 VA: 0x31E5040
	|-List<MiningPointSaveData>.get_Capacity
	|
	|-RVA: 0x31E85A0 Offset: 0x31E86A1 VA: 0x31E85A0
	|-List<MonsterHutSaveData>.get_Capacity
	|
	|-RVA: 0x31EBAA0 Offset: 0x31EBBA1 VA: 0x31EBAA0
	|-List<MoviePlayer.SUBTITLEDATA>.get_Capacity
	|
	|-RVA: 0x31EEB20 Offset: 0x31EEC21 VA: 0x31EEB20
	|-List<NPCActionData>.get_Capacity
	|
	|-RVA: 0x31F21D0 Offset: 0x31F22D1 VA: 0x31F21D0
	|-List<NpcPlaceSchedule>.get_Capacity
	|
	|-RVA: 0x31F5550 Offset: 0x31F5651 VA: 0x31F5550
	|-List<OrderLotterySaveParameter>.get_Capacity
	|
	|-RVA: 0x31F8630 Offset: 0x31F8731 VA: 0x31F8630
	|-List<OrderSaveParameter>.get_Capacity
	|
	|-RVA: 0x31FB9C0 Offset: 0x31FBAC1 VA: 0x31FB9C0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Capacity
	|
	|-RVA: 0x330AC30 Offset: 0x330AD31 VA: 0x330AC30
	|-List<ShopCatalogPage>.get_Capacity
	|
	|-RVA: 0x330DC90 Offset: 0x330DD91 VA: 0x330DC90
	|-List<ShopNpcTalk>.get_Capacity
	|
	|-RVA: 0x3311230 Offset: 0x3311331 VA: 0x3311230
	|-List<SubtitleDataTable.Data>.get_Capacity
	|
	|-RVA: 0x33142F0 Offset: 0x33143F1 VA: 0x33142F0
	|-List<SubtitleDataTable.DataList>.get_Capacity
	|
	|-RVA: 0x33172C0 Offset: 0x33173C1 VA: 0x33172C0
	|-List<SubtitleHudDataTable.Data>.get_Capacity
	|
	|-RVA: 0x331A3A0 Offset: 0x331A4A1 VA: 0x331A3A0
	|-List<SRMonoBehaviourEx.FieldInfo>.get_Capacity
	|
	|-RVA: 0x331D750 Offset: 0x331D851 VA: 0x331D750
	|-List<Schedule>.get_Capacity
	|
	|-RVA: 0x3320AB0 Offset: 0x3320BB1 VA: 0x3320AB0
	|-List<CurveSample>.get_Capacity
	|
	|-RVA: 0x3324330 Offset: 0x3324431 VA: 0x3324330
	|-List<bool>.get_Capacity
	|
	|-RVA: 0x3327320 Offset: 0x3327421 VA: 0x3327320
	|-List<byte>.get_Capacity
	|
	|-RVA: 0x332A2F0 Offset: 0x332A3F1 VA: 0x332A2F0
	|-List<char>.get_Capacity
	|
	|-RVA: 0x3358340 Offset: 0x3358441 VA: 0x3358340
	|-List<KeyValuePair<DateTime, object>>.get_Capacity
	|
	|-RVA: 0x335B390 Offset: 0x335B491 VA: 0x335B390
	|-List<KeyValuePair<int, object>>.get_Capacity
	|
	|-RVA: 0x335E3E0 Offset: 0x335E4E1 VA: 0x335E3E0
	|-List<KeyValuePair<object, object>>.get_Capacity
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.get_Capacity
	|
	|-RVA: 0x3361420 Offset: 0x3361521 VA: 0x3361420
	|-List<DateTime>.get_Capacity
	|
	|-RVA: 0x33643C0 Offset: 0x33644C1 VA: 0x33643C0
	|-List<double>.get_Capacity
	|
	|-RVA: 0x3367380 Offset: 0x3367481 VA: 0x3367380
	|-List<short>.get_Capacity
	|
	|-RVA: 0x336A330 Offset: 0x336A431 VA: 0x336A330
	|-List<int>.get_Capacity
	|
	|-RVA: 0x336D2E0 Offset: 0x336D3E1 VA: 0x336D2E0
	|-List<Int32Enum>.get_Capacity
	|
	|-RVA: 0x3370290 Offset: 0x3370391 VA: 0x3370290
	|-List<long>.get_Capacity
	|
	|-RVA: 0x3373240 Offset: 0x3373341 VA: 0x3373240
	|-List<InterpretedFrameInfo>.get_Capacity
	|
	|-RVA: 0x3376280 Offset: 0x3376381 VA: 0x3376280
	|-List<Nullable<Int32Enum>>.get_Capacity
	|
	|-RVA: 0x3404F30 Offset: 0x3405031 VA: 0x3404F30
	|-List<Nullable<Bounds>>.get_Capacity
	|
	|-RVA: 0x34084F0 Offset: 0x34085F1 VA: 0x34084F0
	|-List<Nullable<BoundsInt>>.get_Capacity
	|
	|-RVA: 0x340BA90 Offset: 0x340BB91 VA: 0x340BA90
	|-List<Nullable<Color32>>.get_Capacity
	|
	|-RVA: 0x340EAB0 Offset: 0x340EBB1 VA: 0x340EAB0
	|-List<Nullable<Color>>.get_Capacity
	|
	|-RVA: 0x3411EF0 Offset: 0x3411FF1 VA: 0x3411EF0
	|-List<Nullable<GradientAlphaKey>>.get_Capacity
	|
	|-RVA: 0x3415030 Offset: 0x3415131 VA: 0x3415030
	|-List<Nullable<GradientColorKey>>.get_Capacity
	|
	|-RVA: 0x3418480 Offset: 0x3418581 VA: 0x3418480
	|-List<Nullable<Keyframe>>.get_Capacity
	|
	|-RVA: 0x341B8C0 Offset: 0x341B9C1 VA: 0x341B8C0
	|-List<Nullable<LayerMask>>.get_Capacity
	|
	|-RVA: 0x341E8F0 Offset: 0x341E9F1 VA: 0x341E8F0
	|-List<Nullable<Matrix4x4>>.get_Capacity
	|
	|-RVA: 0x3422320 Offset: 0x3422421 VA: 0x3422320
	|-List<Nullable<Quaternion>>.get_Capacity
	|
	|-RVA: 0x32621D0 Offset: 0x32622D1 VA: 0x32621D0
	|-List<Nullable<RangeInt>>.get_Capacity
	|
	|-RVA: 0x3265310 Offset: 0x3265411 VA: 0x3265310
	|-List<Nullable<Rect>>.get_Capacity
	|
	|-RVA: 0x3268770 Offset: 0x3268871 VA: 0x3268770
	|-List<Nullable<RectInt>>.get_Capacity
	|
	|-RVA: 0x326BBB0 Offset: 0x326BCB1 VA: 0x326BBB0
	|-List<Nullable<Vector2>>.get_Capacity
	|
	|-RVA: 0x326ECD0 Offset: 0x326EDD1 VA: 0x326ECD0
	|-List<Nullable<Vector2Int>>.get_Capacity
	|
	|-RVA: 0x3271DF0 Offset: 0x3271EF1 VA: 0x3271DF0
	|-List<Nullable<Vector3>>.get_Capacity
	|
	|-RVA: 0x3274E60 Offset: 0x3274F61 VA: 0x3274E60
	|-List<Nullable<Vector3Int>>.get_Capacity
	|
	|-RVA: 0x3277EF0 Offset: 0x3277FF1 VA: 0x3277EF0
	|-List<Nullable<Vector4>>.get_Capacity
	|
	|-RVA: 0x327E260 Offset: 0x327E361 VA: 0x327E260
	|-List<sbyte>.get_Capacity
	|
	|-RVA: 0x3281220 Offset: 0x3281321 VA: 0x3281220
	|-List<float>.get_Capacity
	|
	|-RVA: 0x32A8490 Offset: 0x32A8591 VA: 0x32A8490
	|-List<ushort>.get_Capacity
	|
	|-RVA: 0x32AB440 Offset: 0x32AB541 VA: 0x32AB440
	|-List<uint>.get_Capacity
	|
	|-RVA: 0x32AE3F0 Offset: 0x32AE4F1 VA: 0x32AE3F0
	|-List<ulong>.get_Capacity
	|
	|-RVA: 0x32B13A0 Offset: 0x32B14A1 VA: 0x32B13A0
	|-List<ValueTuple<bool, Int32Enum>>.get_Capacity
	|
	|-RVA: 0x32B4350 Offset: 0x32B4451 VA: 0x32B4350
	|-List<ValueTuple<Int32Enum, int>>.get_Capacity
	|
	|-RVA: 0x32B7300 Offset: 0x32B7401 VA: 0x32B7300
	|-List<ValueTuple<Int32Enum, object>>.get_Capacity
	|
	|-RVA: 0x32BA350 Offset: 0x32BA451 VA: 0x32BA350
	|-List<ValueTuple<object, Int32Enum>>.get_Capacity
	|
	|-RVA: 0x32BD390 Offset: 0x32BD491 VA: 0x32BD390
	|-List<ValueTuple<object, object>>.get_Capacity
	|
	|-RVA: 0x32C03D0 Offset: 0x32C04D1 VA: 0x32C03D0
	|-List<ValueTuple<object, float>>.get_Capacity
	|
	|-RVA: 0x32C3410 Offset: 0x32C3511 VA: 0x32C3410
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Capacity
	|
	|-RVA: 0x32C6500 Offset: 0x32C6601 VA: 0x32C6500
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Capacity
	|
	|-RVA: 0x3110160 Offset: 0x3110261 VA: 0x3110160
	|-List<TexturePacker_JsonArray.Frame>.get_Capacity
	|
	|-RVA: 0x3113820 Offset: 0x3113921 VA: 0x3113820
	|-List<TutorialUnlockFlagData>.get_Capacity
	|
	|-RVA: 0x31168E0 Offset: 0x31169E1 VA: 0x31168E0
	|-List<UIMainManagerAttachObject.AttachSet>.get_Capacity
	|
	|-RVA: 0x3119950 Offset: 0x3119A51 VA: 0x3119950
	|-List<CapEdge>.get_Capacity
	|
	|-RVA: 0x311CE90 Offset: 0x311CF91 VA: 0x311CE90
	|-List<MeshDataConnectivity.Face>.get_Capacity
	|
	|-RVA: 0x311FE60 Offset: 0x311FF61 VA: 0x311FE60
	|-List<MeshFaceConnectivity.EdgeData.SideData>.get_Capacity
	|
	|-RVA: 0x31231B0 Offset: 0x31232B1 VA: 0x31231B0
	|-List<MeshFaceConnectivity.EdgeData>.get_Capacity
	|
	|-RVA: 0x3126750 Offset: 0x3126851 VA: 0x3126750
	|-List<NavMeshBuildMarkup>.get_Capacity
	|
	|-RVA: 0x31297A0 Offset: 0x31298A1 VA: 0x31297A0
	|-List<NavMeshBuildSource>.get_Capacity
	|
	|-RVA: 0x312D330 Offset: 0x312D431 VA: 0x312D330
	|-List<ConstraintSource>.get_Capacity
	|
	|-RVA: 0x3130370 Offset: 0x3130471 VA: 0x3130370
	|-List<AnimatorClipInfo>.get_Capacity
	|
	|-RVA: 0x321BF00 Offset: 0x321C001 VA: 0x321BF00
	|-List<BeforeRenderHelper.OrderBlock>.get_Capacity
	|
	|-RVA: 0x321EF70 Offset: 0x321F071 VA: 0x321EF70
	|-List<BoneWeight>.get_Capacity
	|
	|-RVA: 0x32222D0 Offset: 0x32223D1 VA: 0x32222D0
	|-List<Bounds>.get_Capacity
	|
	|-RVA: 0x3225620 Offset: 0x3225721 VA: 0x3225620
	|-List<BoundsInt>.get_Capacity
	|
	|-RVA: 0x3228950 Offset: 0x3228A51 VA: 0x3228950
	|-List<Color32>.get_Capacity
	|
	|-RVA: 0x322B910 Offset: 0x322BA11 VA: 0x322B910
	|-List<Color>.get_Capacity
	|
	|-RVA: 0x322E9E0 Offset: 0x322EAE1 VA: 0x322E9E0
	|-List<CombineInstance>.get_Capacity
	|
	|-RVA: 0x32325C0 Offset: 0x32326C1 VA: 0x32325C0
	|-List<RaycastResult>.get_Capacity
	|
	|-RVA: 0x3235E60 Offset: 0x3235F61 VA: 0x3235E60
	|-List<GradientAlphaKey>.get_Capacity
	|
	|-RVA: 0x3238EB0 Offset: 0x3238FB1 VA: 0x3238EB0
	|-List<GradientColorKey>.get_Capacity
	|
	|-RVA: 0x323C210 Offset: 0x323C311 VA: 0x323C210
	|-List<Keyframe>.get_Capacity
	|
	|-RVA: 0x323F6D0 Offset: 0x323F7D1 VA: 0x323F6D0
	|-List<LayerMask>.get_Capacity
	|
	|-RVA: 0x32426D0 Offset: 0x32427D1 VA: 0x32426D0
	|-List<Matrix4x4>.get_Capacity
	|
	|-RVA: 0x3245D80 Offset: 0x3245E81 VA: 0x3245D80
	|-List<ParticleSystem.Particle>.get_Capacity
	|
	|-RVA: 0x3249210 Offset: 0x3249311 VA: 0x3249210
	|-List<Playable>.get_Capacity
	|
	|-RVA: 0x324C240 Offset: 0x324C341 VA: 0x324C240
	|-List<PlayableBinding>.get_Capacity
	|
	|-RVA: 0x324F5D0 Offset: 0x324F6D1 VA: 0x324F5D0
	|-List<PlayableGraph>.get_Capacity
	|
	|-RVA: 0x32525E0 Offset: 0x32526E1 VA: 0x32525E0
	|-List<Edge>.get_Capacity
	|
	|-RVA: 0x3255580 Offset: 0x3255681 VA: 0x3255580
	|-List<Quaternion>.get_Capacity
	|
	|-RVA: 0x3258610 Offset: 0x3258711 VA: 0x3258610
	|-List<RangeInt>.get_Capacity
	|
	|-RVA: 0x325B5E0 Offset: 0x325B6E1 VA: 0x325B5E0
	|-List<RaycastHit2D>.get_Capacity
	|
	|-RVA: 0x325EB50 Offset: 0x325EC51 VA: 0x325EB50
	|-List<RaycastHit>.get_Capacity
	|
	|-RVA: 0x33C09C0 Offset: 0x33C0AC1 VA: 0x33C09C0
	|-List<Rect>.get_Capacity
	|
	|-RVA: 0x33C3A50 Offset: 0x33C3B51 VA: 0x33C3A50
	|-List<RectInt>.get_Capacity
	|
	|-RVA: 0x33C6A60 Offset: 0x33C6B61 VA: 0x33C6A60
	|-List<ReflectionProbeBlendInfo>.get_Capacity
	|
	|-RVA: 0x33C9AF0 Offset: 0x33C9BF1 VA: 0x33C9AF0
	|-List<SphericalHarmonicsL2>.get_Capacity
	|
	|-RVA: 0x33CD800 Offset: 0x33CD901 VA: 0x33CD800
	|-List<VertexAttributeDescriptor>.get_Capacity
	|
	|-RVA: 0x33D0830 Offset: 0x33D0931 VA: 0x33D0830
	|-List<AsyncOperationHandle>.get_Capacity
	|
	|-RVA: 0x33D3BD0 Offset: 0x33D3CD1 VA: 0x33D3BD0
	|-List<AsyncOperationHandle<SceneInstance>>.get_Capacity
	|
	|-RVA: 0x33D6F70 Offset: 0x33D7071 VA: 0x33D6F70
	|-List<DiagnosticEvent>.get_Capacity
	|
	|-RVA: 0x33DA530 Offset: 0x33DA631 VA: 0x33DA530
	|-List<DelayedActionManager.DelegateInfo>.get_Capacity
	|
	|-RVA: 0x33DD8E0 Offset: 0x33DD9E1 VA: 0x33DD8E0
	|-List<ObjectInitializationData>.get_Capacity
	|
	|-RVA: 0x31B8DD0 Offset: 0x31B8ED1 VA: 0x31B8DD0
	|-List<GlyphRect>.get_Capacity
	|
	|-RVA: 0x31BBE00 Offset: 0x31BBF01 VA: 0x31BBE00
	|-List<AnimationOutputWeightProcessor.WeightInfo>.get_Capacity
	|
	|-RVA: 0x31BF2E0 Offset: 0x31BF3E1 VA: 0x31BF2E0
	|-List<IntervalTreeNode>.get_Capacity
	|
	|-RVA: 0x31C2630 Offset: 0x31C2731 VA: 0x31C2630
	|-List<IntervalTree.Entry<object>>.get_Capacity
	|
	|-RVA: 0x31C59D0 Offset: 0x31C5AD1 VA: 0x31C59D0
	|-List<TimeNotificationBehaviour.NotificationEntry>.get_Capacity
	|
	|-RVA: 0x31C8D40 Offset: 0x31C8E41 VA: 0x31C8D40
	|-List<UICharInfo>.get_Capacity
	|
	|-RVA: 0x31CBDD0 Offset: 0x31CBED1 VA: 0x31CBDD0
	|-List<FocusController.FocusedElement>.get_Capacity
	|
	|-RVA: 0x31CEE10 Offset: 0x31CEF11 VA: 0x31CEE10
	|-List<UILineInfo>.get_Capacity
	|
	|-RVA: 0x31D1E60 Offset: 0x31D1F61 VA: 0x31D1E60
	|-List<UIVertex>.get_Capacity
	|
	|-RVA: 0x31D5840 Offset: 0x31D5941 VA: 0x31D5840
	|-List<UnitySynchronizationContext.WorkRequest>.get_Capacity
	|
	|-RVA: 0x31D8BB0 Offset: 0x31D8CB1 VA: 0x31D8BB0
	|-List<Vector2>.get_Capacity
	|
	|-RVA: 0x2CE17F0 Offset: 0x2CE18F1 VA: 0x2CE17F0
	|-List<Vector2Int>.get_Capacity
	|
	|-RVA: 0x2CE4790 Offset: 0x2CE4891 VA: 0x2CE4790
	|-List<Vector3>.get_Capacity
	|
	|-RVA: 0x2CE7820 Offset: 0x2CE7921 VA: 0x2CE7820
	|-List<Vector3Int>.get_Capacity
	|
	|-RVA: 0x2CEA8D0 Offset: 0x2CEA9D1 VA: 0x2CEA8D0
	|-List<Vector4>.get_Capacity
	|
	|-RVA: 0x2CED9B0 Offset: 0x2CEDAB1 VA: 0x2CED9B0
	|-List<WarpPoints.WarpPoint>.get_Capacity
	|
	|-RVA: 0x2CF1670 Offset: 0x2CF1771 VA: 0x2CF1670
	|-List<YieldItemParam>.get_Capacity
	|
	|-RVA: 0x2CF4640 Offset: 0x2CF4741 VA: 0x2CF4640
	|-List<stCommand_t>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248C870 Offset: 0x248C971 VA: 0x248C870
	|-List<AS_ToolController.ChargeInfo>.set_Capacity
	|
	|-RVA: 0x248FC40 Offset: 0x248FD41 VA: 0x248FC40
	|-List<BuildItemData>.set_Capacity
	|
	|-RVA: 0x3155EF0 Offset: 0x3155FF1 VA: 0x3155EF0
	|-List<ButtonLinker.LinkObject>.set_Capacity
	|
	|-RVA: 0x3158F40 Offset: 0x3159041 VA: 0x3158F40
	|-List<CharaCallTable.BustupTable>.set_Capacity
	|
	|-RVA: 0x315BF50 Offset: 0x315C051 VA: 0x315BF50
	|-List<CharaCallTable.CharaFaceIconTable>.set_Capacity
	|
	|-RVA: 0x315F010 Offset: 0x315F111 VA: 0x315F010
	|-List<CameraState.CustomBlendable>.set_Capacity
	|
	|-RVA: 0x3162050 Offset: 0x3162151 VA: 0x3162050
	|-List<CinemachineClearShot.Pair>.set_Capacity
	|
	|-RVA: 0x3165000 Offset: 0x3165101 VA: 0x3165000
	|-List<CinemachineStateDrivenCamera.HashPair>.set_Capacity
	|
	|-RVA: 0x3167FD0 Offset: 0x31680D1 VA: 0x3167FD0
	|-List<TargetPositionCache.CacheCurve.Item>.set_Capacity
	|
	|-RVA: 0x316B4B0 Offset: 0x316B5B1 VA: 0x316B4B0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.set_Capacity
	|
	|-RVA: 0x316EA20 Offset: 0x316EB21 VA: 0x316EA20
	|-List<CropDataTable>.set_Capacity
	|
	|-RVA: 0x327B350 Offset: 0x327B451 VA: 0x327B350
	|-List<Tween>.set_Capacity
	|-List<Point2D>.set_Capacity
	|-List<object>.set_Capacity
	|-List<Timer>.set_Capacity
	|-List<VertexData>.set_Capacity
	|-List<GameObject>.set_Capacity
	|-List<VisualElement>.set_Capacity
	|
	|-RVA: 0x3171FC0 Offset: 0x31720C1 VA: 0x3171FC0
	|-List<DropItemParam>.set_Capacity
	|
	|-RVA: 0x3174F90 Offset: 0x3175091 VA: 0x3174F90
	|-List<ErosionBrush.UndoStep>.set_Capacity
	|
	|-RVA: 0x31DBC20 Offset: 0x31DBD21 VA: 0x31DBC20
	|-List<EventCheckId>.set_Capacity
	|
	|-RVA: 0x31DEFA0 Offset: 0x31DF0A1 VA: 0x31DEFA0
	|-List<EventFlagProgressData>.set_Capacity
	|
	|-RVA: 0x31E1FF0 Offset: 0x31E20F1 VA: 0x31E1FF0
	|-List<FesNpcScoreData>.set_Capacity
	|
	|-RVA: 0x31E5060 Offset: 0x31E5161 VA: 0x31E5060
	|-List<MiningPointSaveData>.set_Capacity
	|
	|-RVA: 0x31E85C0 Offset: 0x31E86C1 VA: 0x31E85C0
	|-List<MonsterHutSaveData>.set_Capacity
	|
	|-RVA: 0x31EBAC0 Offset: 0x31EBBC1 VA: 0x31EBAC0
	|-List<MoviePlayer.SUBTITLEDATA>.set_Capacity
	|
	|-RVA: 0x31EEB40 Offset: 0x31EEC41 VA: 0x31EEB40
	|-List<NPCActionData>.set_Capacity
	|
	|-RVA: 0x31F21F0 Offset: 0x31F22F1 VA: 0x31F21F0
	|-List<NpcPlaceSchedule>.set_Capacity
	|
	|-RVA: 0x31F5570 Offset: 0x31F5671 VA: 0x31F5570
	|-List<OrderLotterySaveParameter>.set_Capacity
	|
	|-RVA: 0x31F8650 Offset: 0x31F8751 VA: 0x31F8650
	|-List<OrderSaveParameter>.set_Capacity
	|
	|-RVA: 0x31FB9E0 Offset: 0x31FBAE1 VA: 0x31FB9E0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.set_Capacity
	|
	|-RVA: 0x330AC50 Offset: 0x330AD51 VA: 0x330AC50
	|-List<ShopCatalogPage>.set_Capacity
	|
	|-RVA: 0x330DCB0 Offset: 0x330DDB1 VA: 0x330DCB0
	|-List<ShopNpcTalk>.set_Capacity
	|
	|-RVA: 0x3311250 Offset: 0x3311351 VA: 0x3311250
	|-List<SubtitleDataTable.Data>.set_Capacity
	|
	|-RVA: 0x3314310 Offset: 0x3314411 VA: 0x3314310
	|-List<SubtitleDataTable.DataList>.set_Capacity
	|
	|-RVA: 0x33172E0 Offset: 0x33173E1 VA: 0x33172E0
	|-List<SubtitleHudDataTable.Data>.set_Capacity
	|
	|-RVA: 0x331A3C0 Offset: 0x331A4C1 VA: 0x331A3C0
	|-List<SRMonoBehaviourEx.FieldInfo>.set_Capacity
	|
	|-RVA: 0x331D770 Offset: 0x331D871 VA: 0x331D770
	|-List<Schedule>.set_Capacity
	|
	|-RVA: 0x3320AD0 Offset: 0x3320BD1 VA: 0x3320AD0
	|-List<CurveSample>.set_Capacity
	|
	|-RVA: 0x3324350 Offset: 0x3324451 VA: 0x3324350
	|-List<bool>.set_Capacity
	|
	|-RVA: 0x3327340 Offset: 0x3327441 VA: 0x3327340
	|-List<byte>.set_Capacity
	|
	|-RVA: 0x332A310 Offset: 0x332A411 VA: 0x332A310
	|-List<char>.set_Capacity
	|
	|-RVA: 0x3358360 Offset: 0x3358461 VA: 0x3358360
	|-List<KeyValuePair<DateTime, object>>.set_Capacity
	|
	|-RVA: 0x335B3B0 Offset: 0x335B4B1 VA: 0x335B3B0
	|-List<KeyValuePair<int, object>>.set_Capacity
	|
	|-RVA: 0x335E400 Offset: 0x335E501 VA: 0x335E400
	|-List<KeyValuePair<object, object>>.set_Capacity
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.set_Capacity
	|
	|-RVA: 0x3361440 Offset: 0x3361541 VA: 0x3361440
	|-List<DateTime>.set_Capacity
	|
	|-RVA: 0x33643E0 Offset: 0x33644E1 VA: 0x33643E0
	|-List<double>.set_Capacity
	|
	|-RVA: 0x33673A0 Offset: 0x33674A1 VA: 0x33673A0
	|-List<short>.set_Capacity
	|
	|-RVA: 0x336A350 Offset: 0x336A451 VA: 0x336A350
	|-List<int>.set_Capacity
	|
	|-RVA: 0x336D300 Offset: 0x336D401 VA: 0x336D300
	|-List<Int32Enum>.set_Capacity
	|
	|-RVA: 0x33702B0 Offset: 0x33703B1 VA: 0x33702B0
	|-List<long>.set_Capacity
	|
	|-RVA: 0x3373260 Offset: 0x3373361 VA: 0x3373260
	|-List<InterpretedFrameInfo>.set_Capacity
	|
	|-RVA: 0x33762A0 Offset: 0x33763A1 VA: 0x33762A0
	|-List<Nullable<Int32Enum>>.set_Capacity
	|
	|-RVA: 0x3404F50 Offset: 0x3405051 VA: 0x3404F50
	|-List<Nullable<Bounds>>.set_Capacity
	|
	|-RVA: 0x3408510 Offset: 0x3408611 VA: 0x3408510
	|-List<Nullable<BoundsInt>>.set_Capacity
	|
	|-RVA: 0x340BAB0 Offset: 0x340BBB1 VA: 0x340BAB0
	|-List<Nullable<Color32>>.set_Capacity
	|
	|-RVA: 0x340EAD0 Offset: 0x340EBD1 VA: 0x340EAD0
	|-List<Nullable<Color>>.set_Capacity
	|
	|-RVA: 0x3411F10 Offset: 0x3412011 VA: 0x3411F10
	|-List<Nullable<GradientAlphaKey>>.set_Capacity
	|
	|-RVA: 0x3415050 Offset: 0x3415151 VA: 0x3415050
	|-List<Nullable<GradientColorKey>>.set_Capacity
	|
	|-RVA: 0x34184A0 Offset: 0x34185A1 VA: 0x34184A0
	|-List<Nullable<Keyframe>>.set_Capacity
	|
	|-RVA: 0x341B8E0 Offset: 0x341B9E1 VA: 0x341B8E0
	|-List<Nullable<LayerMask>>.set_Capacity
	|
	|-RVA: 0x341E910 Offset: 0x341EA11 VA: 0x341E910
	|-List<Nullable<Matrix4x4>>.set_Capacity
	|
	|-RVA: 0x3422340 Offset: 0x3422441 VA: 0x3422340
	|-List<Nullable<Quaternion>>.set_Capacity
	|
	|-RVA: 0x32621F0 Offset: 0x32622F1 VA: 0x32621F0
	|-List<Nullable<RangeInt>>.set_Capacity
	|
	|-RVA: 0x3265330 Offset: 0x3265431 VA: 0x3265330
	|-List<Nullable<Rect>>.set_Capacity
	|
	|-RVA: 0x3268790 Offset: 0x3268891 VA: 0x3268790
	|-List<Nullable<RectInt>>.set_Capacity
	|
	|-RVA: 0x326BBD0 Offset: 0x326BCD1 VA: 0x326BBD0
	|-List<Nullable<Vector2>>.set_Capacity
	|
	|-RVA: 0x326ECF0 Offset: 0x326EDF1 VA: 0x326ECF0
	|-List<Nullable<Vector2Int>>.set_Capacity
	|
	|-RVA: 0x3271E10 Offset: 0x3271F11 VA: 0x3271E10
	|-List<Nullable<Vector3>>.set_Capacity
	|
	|-RVA: 0x3274E80 Offset: 0x3274F81 VA: 0x3274E80
	|-List<Nullable<Vector3Int>>.set_Capacity
	|
	|-RVA: 0x3277F10 Offset: 0x3278011 VA: 0x3277F10
	|-List<Nullable<Vector4>>.set_Capacity
	|
	|-RVA: 0x327E280 Offset: 0x327E381 VA: 0x327E280
	|-List<sbyte>.set_Capacity
	|
	|-RVA: 0x3281240 Offset: 0x3281341 VA: 0x3281240
	|-List<float>.set_Capacity
	|
	|-RVA: 0x32A84B0 Offset: 0x32A85B1 VA: 0x32A84B0
	|-List<ushort>.set_Capacity
	|
	|-RVA: 0x32AB460 Offset: 0x32AB561 VA: 0x32AB460
	|-List<uint>.set_Capacity
	|
	|-RVA: 0x32AE410 Offset: 0x32AE511 VA: 0x32AE410
	|-List<ulong>.set_Capacity
	|
	|-RVA: 0x32B13C0 Offset: 0x32B14C1 VA: 0x32B13C0
	|-List<ValueTuple<bool, Int32Enum>>.set_Capacity
	|
	|-RVA: 0x32B4370 Offset: 0x32B4471 VA: 0x32B4370
	|-List<ValueTuple<Int32Enum, int>>.set_Capacity
	|
	|-RVA: 0x32B7320 Offset: 0x32B7421 VA: 0x32B7320
	|-List<ValueTuple<Int32Enum, object>>.set_Capacity
	|
	|-RVA: 0x32BA370 Offset: 0x32BA471 VA: 0x32BA370
	|-List<ValueTuple<object, Int32Enum>>.set_Capacity
	|
	|-RVA: 0x32BD3B0 Offset: 0x32BD4B1 VA: 0x32BD3B0
	|-List<ValueTuple<object, object>>.set_Capacity
	|
	|-RVA: 0x32C03F0 Offset: 0x32C04F1 VA: 0x32C03F0
	|-List<ValueTuple<object, float>>.set_Capacity
	|
	|-RVA: 0x32C3430 Offset: 0x32C3531 VA: 0x32C3430
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.set_Capacity
	|
	|-RVA: 0x32C6520 Offset: 0x32C6621 VA: 0x32C6520
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.set_Capacity
	|
	|-RVA: 0x3110180 Offset: 0x3110281 VA: 0x3110180
	|-List<TexturePacker_JsonArray.Frame>.set_Capacity
	|
	|-RVA: 0x3113840 Offset: 0x3113941 VA: 0x3113840
	|-List<TutorialUnlockFlagData>.set_Capacity
	|
	|-RVA: 0x3116900 Offset: 0x3116A01 VA: 0x3116900
	|-List<UIMainManagerAttachObject.AttachSet>.set_Capacity
	|
	|-RVA: 0x3119970 Offset: 0x3119A71 VA: 0x3119970
	|-List<CapEdge>.set_Capacity
	|
	|-RVA: 0x311CEB0 Offset: 0x311CFB1 VA: 0x311CEB0
	|-List<MeshDataConnectivity.Face>.set_Capacity
	|
	|-RVA: 0x311FE80 Offset: 0x311FF81 VA: 0x311FE80
	|-List<MeshFaceConnectivity.EdgeData.SideData>.set_Capacity
	|
	|-RVA: 0x31231D0 Offset: 0x31232D1 VA: 0x31231D0
	|-List<MeshFaceConnectivity.EdgeData>.set_Capacity
	|
	|-RVA: 0x3126770 Offset: 0x3126871 VA: 0x3126770
	|-List<NavMeshBuildMarkup>.set_Capacity
	|
	|-RVA: 0x31297C0 Offset: 0x31298C1 VA: 0x31297C0
	|-List<NavMeshBuildSource>.set_Capacity
	|
	|-RVA: 0x312D350 Offset: 0x312D451 VA: 0x312D350
	|-List<ConstraintSource>.set_Capacity
	|
	|-RVA: 0x3130390 Offset: 0x3130491 VA: 0x3130390
	|-List<AnimatorClipInfo>.set_Capacity
	|
	|-RVA: 0x321BF20 Offset: 0x321C021 VA: 0x321BF20
	|-List<BeforeRenderHelper.OrderBlock>.set_Capacity
	|
	|-RVA: 0x321EF90 Offset: 0x321F091 VA: 0x321EF90
	|-List<BoneWeight>.set_Capacity
	|
	|-RVA: 0x32222F0 Offset: 0x32223F1 VA: 0x32222F0
	|-List<Bounds>.set_Capacity
	|
	|-RVA: 0x3225640 Offset: 0x3225741 VA: 0x3225640
	|-List<BoundsInt>.set_Capacity
	|
	|-RVA: 0x3228970 Offset: 0x3228A71 VA: 0x3228970
	|-List<Color32>.set_Capacity
	|
	|-RVA: 0x322B930 Offset: 0x322BA31 VA: 0x322B930
	|-List<Color>.set_Capacity
	|
	|-RVA: 0x322EA00 Offset: 0x322EB01 VA: 0x322EA00
	|-List<CombineInstance>.set_Capacity
	|
	|-RVA: 0x32325E0 Offset: 0x32326E1 VA: 0x32325E0
	|-List<RaycastResult>.set_Capacity
	|
	|-RVA: 0x3235E80 Offset: 0x3235F81 VA: 0x3235E80
	|-List<GradientAlphaKey>.set_Capacity
	|
	|-RVA: 0x3238ED0 Offset: 0x3238FD1 VA: 0x3238ED0
	|-List<GradientColorKey>.set_Capacity
	|
	|-RVA: 0x323C230 Offset: 0x323C331 VA: 0x323C230
	|-List<Keyframe>.set_Capacity
	|
	|-RVA: 0x323F6F0 Offset: 0x323F7F1 VA: 0x323F6F0
	|-List<LayerMask>.set_Capacity
	|
	|-RVA: 0x32426F0 Offset: 0x32427F1 VA: 0x32426F0
	|-List<Matrix4x4>.set_Capacity
	|
	|-RVA: 0x3245DA0 Offset: 0x3245EA1 VA: 0x3245DA0
	|-List<ParticleSystem.Particle>.set_Capacity
	|
	|-RVA: 0x3249230 Offset: 0x3249331 VA: 0x3249230
	|-List<Playable>.set_Capacity
	|
	|-RVA: 0x324C260 Offset: 0x324C361 VA: 0x324C260
	|-List<PlayableBinding>.set_Capacity
	|
	|-RVA: 0x324F5F0 Offset: 0x324F6F1 VA: 0x324F5F0
	|-List<PlayableGraph>.set_Capacity
	|
	|-RVA: 0x3252600 Offset: 0x3252701 VA: 0x3252600
	|-List<Edge>.set_Capacity
	|
	|-RVA: 0x32555A0 Offset: 0x32556A1 VA: 0x32555A0
	|-List<Quaternion>.set_Capacity
	|
	|-RVA: 0x3258630 Offset: 0x3258731 VA: 0x3258630
	|-List<RangeInt>.set_Capacity
	|
	|-RVA: 0x325B600 Offset: 0x325B701 VA: 0x325B600
	|-List<RaycastHit2D>.set_Capacity
	|
	|-RVA: 0x325EB70 Offset: 0x325EC71 VA: 0x325EB70
	|-List<RaycastHit>.set_Capacity
	|
	|-RVA: 0x33C09E0 Offset: 0x33C0AE1 VA: 0x33C09E0
	|-List<Rect>.set_Capacity
	|
	|-RVA: 0x33C3A70 Offset: 0x33C3B71 VA: 0x33C3A70
	|-List<RectInt>.set_Capacity
	|
	|-RVA: 0x33C6A80 Offset: 0x33C6B81 VA: 0x33C6A80
	|-List<ReflectionProbeBlendInfo>.set_Capacity
	|
	|-RVA: 0x33C9B10 Offset: 0x33C9C11 VA: 0x33C9B10
	|-List<SphericalHarmonicsL2>.set_Capacity
	|
	|-RVA: 0x33CD820 Offset: 0x33CD921 VA: 0x33CD820
	|-List<VertexAttributeDescriptor>.set_Capacity
	|
	|-RVA: 0x33D0850 Offset: 0x33D0951 VA: 0x33D0850
	|-List<AsyncOperationHandle>.set_Capacity
	|
	|-RVA: 0x33D3BF0 Offset: 0x33D3CF1 VA: 0x33D3BF0
	|-List<AsyncOperationHandle<SceneInstance>>.set_Capacity
	|
	|-RVA: 0x33D6F90 Offset: 0x33D7091 VA: 0x33D6F90
	|-List<DiagnosticEvent>.set_Capacity
	|
	|-RVA: 0x33DA550 Offset: 0x33DA651 VA: 0x33DA550
	|-List<DelayedActionManager.DelegateInfo>.set_Capacity
	|
	|-RVA: 0x33DD900 Offset: 0x33DDA01 VA: 0x33DD900
	|-List<ObjectInitializationData>.set_Capacity
	|
	|-RVA: 0x31B8DF0 Offset: 0x31B8EF1 VA: 0x31B8DF0
	|-List<GlyphRect>.set_Capacity
	|
	|-RVA: 0x31BBE20 Offset: 0x31BBF21 VA: 0x31BBE20
	|-List<AnimationOutputWeightProcessor.WeightInfo>.set_Capacity
	|
	|-RVA: 0x31BF300 Offset: 0x31BF401 VA: 0x31BF300
	|-List<IntervalTreeNode>.set_Capacity
	|
	|-RVA: 0x31C2650 Offset: 0x31C2751 VA: 0x31C2650
	|-List<IntervalTree.Entry<object>>.set_Capacity
	|
	|-RVA: 0x31C59F0 Offset: 0x31C5AF1 VA: 0x31C59F0
	|-List<TimeNotificationBehaviour.NotificationEntry>.set_Capacity
	|
	|-RVA: 0x31C8D60 Offset: 0x31C8E61 VA: 0x31C8D60
	|-List<UICharInfo>.set_Capacity
	|
	|-RVA: 0x31CBDF0 Offset: 0x31CBEF1 VA: 0x31CBDF0
	|-List<FocusController.FocusedElement>.set_Capacity
	|
	|-RVA: 0x31CEE30 Offset: 0x31CEF31 VA: 0x31CEE30
	|-List<UILineInfo>.set_Capacity
	|
	|-RVA: 0x31D1E80 Offset: 0x31D1F81 VA: 0x31D1E80
	|-List<UIVertex>.set_Capacity
	|
	|-RVA: 0x31D5860 Offset: 0x31D5961 VA: 0x31D5860
	|-List<UnitySynchronizationContext.WorkRequest>.set_Capacity
	|
	|-RVA: 0x31D8BD0 Offset: 0x31D8CD1 VA: 0x31D8BD0
	|-List<Vector2>.set_Capacity
	|
	|-RVA: 0x2CE1810 Offset: 0x2CE1911 VA: 0x2CE1810
	|-List<Vector2Int>.set_Capacity
	|
	|-RVA: 0x2CE47B0 Offset: 0x2CE48B1 VA: 0x2CE47B0
	|-List<Vector3>.set_Capacity
	|
	|-RVA: 0x2CE7840 Offset: 0x2CE7941 VA: 0x2CE7840
	|-List<Vector3Int>.set_Capacity
	|
	|-RVA: 0x2CEA8F0 Offset: 0x2CEA9F1 VA: 0x2CEA8F0
	|-List<Vector4>.set_Capacity
	|
	|-RVA: 0x2CED9D0 Offset: 0x2CEDAD1 VA: 0x2CED9D0
	|-List<WarpPoints.WarpPoint>.set_Capacity
	|
	|-RVA: 0x2CF1690 Offset: 0x2CF1791 VA: 0x2CF1690
	|-List<YieldItemParam>.set_Capacity
	|
	|-RVA: 0x2CF4660 Offset: 0x2CF4761 VA: 0x2CF4660
	|-List<stCommand_t>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327B4D0 Offset: 0x327B5D1 VA: 0x327B4D0
	|-List<AIInput>.get_Count
	|-List<AS_MagicController>.get_Count
	|-List<ActionBehaviorCommandData.Argument>.get_Count
	|-List<Actor>.get_Count
	|-List<AdvShowOneImage>.get_Count
	|-List<AracneFlatWeb>.get_Count
	|-List<AudmuraCrystal>.get_Count
	|-List<AutomaticLOD.LODLevelData>.get_Count
	|-List<AutomaticLOD>.get_Count
	|-List<BaffamoDodgeManager.BaffamoMonster>.get_Count
	|-List<BaffamoFestivalData>.get_Count
	|-List<BasiliskController.WearFireController>.get_Count
	|-List<BeanData>.get_Count
	|-List<BeanSowingActionTerm>.get_Count
	|-List<BehaviorManager.BehaviorThreadLoader>.get_Count
	|-List<BehaviorManager.BehaviorTree.ConditionalReevaluate>.get_Count
	|-List<BehaviorManager.BehaviorTree>.get_Count
	|-List<SharedVariable>.get_Count
	|-List<TaskCoroutine>.get_Count
	|-List<Task>.get_Count
	|-List<VariableSynchronizer.SynchronizedVariable>.get_Count
	|-List<BehaviorTreeManager.EnemyBehaviorParameter>.get_Count
	|-List<BitBase>.get_Count
	|-List<BodyPartsCollision>.get_Count
	|-List<BossBehaviorParams>.get_Count
	|-List<BustupDataList.DataTable>.get_Count
	|-List<ButtonLinker>.get_Count
	|-List<CameraManager.CameraControllerPair>.get_Count
	|-List<CerberusController.DogParam>.get_Count
	|-List<Character>.get_Count
	|-List<CharacterEnableMoveNormalizeTime.EnableSettingNormalizeTime>.get_Count
	|-List<CharacterEnableRotateNormalizeTime.EnableSettingNormalizeTime>.get_Count
	|-List<CheerVoiceData>.get_Count
	|-List<ChildData>.get_Count
	|-List<ChoiceImage>.get_Count
	|-List<CinemachineBrain.BrainFrame>.get_Count
	|-List<CinemachineBrain>.get_Count
	|-List<CinemachineExtension>.get_Count
	|-List<CinemachineImpulseManager.ImpulseEvent>.get_Count
	|-List<CinemachineStoryboard.CanvasInfo>.get_Count
	|-List<CinemachineVirtualCameraBase>.get_Count
	|-List<CombinedMesh.MaterialMeshInfo>.get_Count
	|-List<CombinedMesh.ObjectInfo>.get_Count
	|-List<CursorEvent>.get_Count
	|-List<ABSSequentiable>.get_Count
	|-List<Tween>.get_Count
	|-List<TweenCallback>.get_Count
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>.get_Count
	|-List<DateSlotControl>.get_Count
	|-List<DeadtreeController.ChestnutController>.get_Count
	|-List<DynamicBone.Particle>.get_Count
	|-List<DynamicBoneColliderBase>.get_Count
	|-List<DynamicBoneH.Particle>.get_Count
	|-List<EnvironmentSoundArea>.get_Count
	|-List<EventScheduleData>.get_Count
	|-List<EventStartData>.get_Count
	|-List<EventUnlockFlagData>.get_Count
	|-List<CellController>.get_Count
	|-List<FarmCropData>.get_Count
	|-List<FarmSupportMonsterController>.get_Count
	|-List<FarmSupportMonsterData>.get_Count
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>.get_Count
	|-List<FesNpcScore>.get_Count
	|-List<FestivalSnowball>.get_Count
	|-List<ObjectLoader>.get_Count
	|-List<FishRecord>.get_Count
	|-List<FishSwim>.get_Count
	|-List<FishingPoint>.get_Count
	|-List<FracturedChunk.AdjacencyInfo>.get_Count
	|-List<FracturedChunk>.get_Count
	|-List<FriendJudgmentManager.FriendJudgmentMonster>.get_Count
	|-List<FriendMonsterManager.FarmInActorData>.get_Count
	|-List<FriendMonsterStatusData>.get_Count
	|-List<BoolKeyframe>.get_Count
	|-List<ColorKeyframe>.get_Count
	|-List<LightningArtItem>.get_Count
	|-List<LightningRenderer>.get_Count
	|-List<LightningSpawnArea>.get_Count
	|-List<NumberKeyframe>.get_Count
	|-List<RainSplashArtItem>.get_Count
	|-List<RainSplashRenderer>.get_Count
	|-List<SpherePointKeyframe>.get_Count
	|-List<TextureKeyframe>.get_Count
	|-List<WeatherEnclosure>.get_Count
	|-List<GateSeasonInfomation>.get_Count
	|-List<GateTimeZoneMonsterInfomation>.get_Count
	|-List<GluttonFoodData>.get_Count
	|-List<GluttonItemTerm>.get_Count
	|-List<HUDDualWorkSelectInput.DualSelect>.get_Count
	|-List<HUDMinimapControl.RectImage>.get_Count
	|-List<HateController.HateParameter>.get_Count
	|-List<HintData>.get_Count
	|-List<HoldItemController.ItemModel>.get_Count
	|-List<InosisiController.ThornsController>.get_Count
	|-List<ItemData>.get_Count
	|-List<ItemDataLinker>.get_Count
	|-List<ItemEquip>.get_Count
	|-List<FurnitureSaveData>.get_Count
	|-List<ItemStorage>.get_Count
	|-List<ItemWeightData>.get_Count
	|-List<KyubiController.FireballParameter>.get_Count
	|-List<LifeCycleAdvData>.get_Count
	|-List<AssetHandle>.get_Count
	|-List<MeshSimplify>.get_Count
	|-List<MobBrain>.get_Count
	|-List<MobDeployCharData>.get_Count
	|-List<MocomocoData>.get_Count
	|-List<ModelScaleData>.get_Count
	|-List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.get_Count
	|-List<MonsterActionBehaviorData>.get_Count
	|-List<MonsterActionBehaviorDataTable.MonsterActionBehaviorCodeData>.get_Count
	|-List<MonsterActionInformation>.get_Count
	|-List<MonsterBehaviorController.BehaviorActionParam>.get_Count
	|-List<MonsterControllerBase.DropItemDataParameter>.get_Count
	|-List<MonsterControllerBase>.get_Count
	|-List<MonsterHutArea>.get_Count
	|-List<MonsterHutController.OrderFarmInParameter>.get_Count
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.get_Count
	|-List<NPCActionBehaviorDataTable.NPCActionBehaviorCodeData>.get_Count
	|-List<NpcController>.get_Count
	|-List<NpcData>.get_Count
	|-List<NpcPatrolPoint>.get_Count
	|-List<NpcSaveParameter>.get_Count
	|-List<OnGroundItem>.get_Count
	|-List<OrderData>.get_Count
	|-List<OrderHUDBlock>.get_Count
	|-List<OrderMasterData>.get_Count
	|-List<OrderPopControl.StockDoOrder>.get_Count
	|-List<PartnerManager.NPCChangeBaseParameter>.get_Count
	|-List<PartnerManager.PartnerSearchRange>.get_Count
	|-List<PartnerMonsterBehaviorController>.get_Count
	|-List<PartyBase>.get_Count
	|-List<PartyMonster>.get_Count
	|-List<PesronalMotionPlayData>.get_Count
	|-List<PlayerSkillBase>.get_Count
	|-List<Contour>.get_Count
	|-List<DTSweepConstraint>.get_Count
	|-List<EdgeIntersectInfo>.get_Count
	|-List<Point2D>.get_Count
	|-List<Point2DList>.get_Count
	|-List<PolygonPoint>.get_Count
	|-List<SplitComplexPolygonNode>.get_Count
	|-List<TriangulationConstraint>.get_Count
	|-List<TriangulationPoint>.get_Count
	|-List<PreloadHandle>.get_Count
	|-List<QuestIconData>.get_Count
	|-List<FishShipmentRecords>.get_Count
	|-List<SeedLevelRecords>.get_Count
	|-List<ShipmentItemRecords>.get_Count
	|-List<SeedShopItemDataTable.SeedShopItemData>.get_Count
	|-List<ShopItem>.get_Count
	|-List<SubtitleHandler>.get_Count
	|-List<ButtonHintBlock>.get_Count
	|-List<UIEMCustomizeSet>.get_Count
	|-List<WantedData>.get_Count
	|-List<RandomData>.get_Count
	|-List<RecipeDataDispBlock>.get_Count
	|-List<RecipeDataTableArray.RecipeDataTable>.get_Count
	|-List<RecipeGroupBase>.get_Count
	|-List<ReviatanIcePillar>.get_Count
	|-List<InteractionTrigger>.get_Count
	|-List<OptionDefinition>.get_Count
	|-List<Settings.KeyboardShortcut>.get_Count
	|-List<OptionsControlBase>.get_Count
	|-List<RF5ThumbnailData>.get_Count
	|-List<SceneSplit>.get_Count
	|-List<SceneTransitionManager.SceneGameObjectEnabled>.get_Count
	|-List<ScriptNames>.get_Count
	|-List<SearchCharacterController.SearchParameter>.get_Count
	|-List<SimpleAnimationPlayable.StateInfo>.get_Count
	|-List<SnowballData>.get_Count
	|-List<SnowballObjectSpawnData>.get_Count
	|-List<SnowballObjectSpawnTerm>.get_Count
	|-List<SnowmanManager.Mocomoco>.get_Count
	|-List<CubicBezierCurve>.get_Count
	|-List<ExtrusionSegment.Vertex>.get_Count
	|-List<MeshVertex>.get_Count
	|-List<SplineNode>.get_Count
	|-List<TrackSegment>.get_Count
	|-List<SubEventData>.get_Count
	|-List<SubEventMasterDataBase>.get_Count
	|-List<AggregateException>.get_Count
	|-List<byte[]>.get_Count
	|-List<List<CinemachineVirtualCameraBase>>.get_Count
	|-List<List<PolygonPoint>>.get_Count
	|-List<List<int>>.get_Count
	|-List<List<object>>.get_Count
	|-List<List<Renderer>>.get_Count
	|-List<List<Vector2>>.get_Count
	|-List<List<Vector3>>.get_Count
	|-List<Stack<int>>.get_Count
	|-List<Func<FocusInterface>>.get_Count
	|-List<Directory.SearchData>.get_Count
	|-List<int[]>.get_Count
	|-List<Instruction>.get_Count
	|-List<LabelScopeInfo>.get_Count
	|-List<LocalDataStore>.get_Count
	|-List<IPAddress>.get_Count
	|-List<object>.get_Count
	|-List<Assembly>.get_Count
	|-List<MethodBase>.get_Count
	|-List<MethodInfo>.get_Count
	|-List<ExceptionDispatchInfo>.get_Count
	|-List<IContextProperty>.get_Count
	|-List<SerializationFieldInfo>.get_Count
	|-List<X509CertificateImpl>.get_Count
	|-List<string>.get_Count
	|-List<string[]>.get_Count
	|-List<RegexCharClass.SingleRange>.get_Count
	|-List<RegexNode>.get_Count
	|-List<StringBuilder>.get_Count
	|-List<Thread>.get_Count
	|-List<Timer>.get_Count
	|-List<TimeZoneInfo.AdjustmentRule>.get_Count
	|-List<TimeZoneInfo>.get_Count
	|-List<TypeSpec>.get_Count
	|-List<WeakReference>.get_Count
	|-List<SystemTextDisp>.get_Count
	|-List<KerningPair>.get_Count
	|-List<TMP_Character>.get_Count
	|-List<TMP_Dropdown.DropdownItem>.get_Count
	|-List<TMP_Dropdown.OptionData>.get_Count
	|-List<TMP_FontAsset>.get_Count
	|-List<TMP_Glyph>.get_Count
	|-List<TMP_GlyphPairAdjustmentRecord>.get_Count
	|-List<TMP_MaterialManager.FallbackMaterial>.get_Count
	|-List<TMP_MaterialManager.MaskingMaterial>.get_Count
	|-List<TMP_Sprite>.get_Count
	|-List<TMP_SpriteAsset>.get_Count
	|-List<TMP_SpriteCharacter>.get_Count
	|-List<TMP_SpriteGlyph>.get_Count
	|-List<TMP_Style>.get_Count
	|-List<TMP_Text>.get_Count
	|-List<TimeManager.JustTimerData>.get_Count
	|-List<ToolInteractionInterface>.get_Count
	|-List<UIButtonLinkerInScrollBox>.get_Count
	|-List<UIItemBoxWindowOpenButton>.get_Count
	|-List<UIItemSlot>.get_Count
	|-List<UIOnOffAnimate>.get_Count
	|-List<UIOrderBoardMenu.OrderList>.get_Count
	|-List<DynamicsSetup.ParseMessage>.get_Count
	|-List<SpringBone>.get_Count
	|-List<SpringColliderSerialization.IColliderSerializer>.get_Count
	|-List<SpringColliderSerialization.TransformSerializer>.get_Count
	|-List<TextRecordParsing.Record>.get_Count
	|-List<MeshData>.get_Count
	|-List<MeshFaceConnectivity.TriangleData>.get_Count
	|-List<VertexData>.get_Count
	|-List<MeshUniqueVertices.SerializableBoneWeight>.get_Count
	|-List<Simplifier.Triangle>.get_Count
	|-List<Simplifier.Vertex>.get_Count
	|-List<UltimateRope.RopeNode>.get_Count
	|-List<NavMeshLink>.get_Count
	|-List<NavMeshSurface>.get_Count
	|-List<AddressablesImpl.ResourceLocatorInfo>.get_Count
	|-List<Animator>.get_Count
	|-List<Camera>.get_Count
	|-List<Canvas>.get_Count
	|-List<CanvasGroup>.get_Count
	|-List<Collider>.get_Count
	|-List<Component>.get_Count
	|-List<BaseInputModule>.get_Count
	|-List<BaseRaycaster>.get_Count
	|-List<EventSystem>.get_Count
	|-List<EventTrigger.Entry>.get_Count
	|-List<IEventSystemHandler>.get_Count
	|-List<PointerInputModule.ButtonState>.get_Count
	|-List<BaseInvokableCall>.get_Count
	|-List<UnityEvent>.get_Count
	|-List<GUILayoutEntry>.get_Count
	|-List<GameObject>.get_Count
	|-List<ISubsystem>.get_Count
	|-List<Light>.get_Count
	|-List<Material>.get_Count
	|-List<UnityWebRequestAsyncOperation>.get_Count
	|-List<Object>.get_Count
	|-List<ParticleSystem>.get_Count
	|-List<RectTransform>.get_Count
	|-List<RenderTexture>.get_Count
	|-List<IAsyncOperation>.get_Count
	|-List<IResourceLocation>.get_Count
	|-List<ScriptableObject>.get_Count
	|-List<SkinnedMeshRenderer>.get_Count
	|-List<Sprite>.get_Count
	|-List<Terrain>.get_Count
	|-List<Glyph>.get_Count
	|-List<AnimationTrack>.get_Count
	|-List<IMarker>.get_Count
	|-List<ITimelineEvaluateCallback>.get_Count
	|-List<RuntimeElement>.get_Count
	|-List<SignalAsset>.get_Count
	|-List<TimelineClip>.get_Count
	|-List<TrackAsset>.get_Count
	|-List<Transform>.get_Count
	|-List<Dropdown.DropdownItem>.get_Count
	|-List<Dropdown.OptionData>.get_Count
	|-List<Graphic>.get_Count
	|-List<ICanvasElement>.get_Count
	|-List<IMaterialModifier>.get_Count
	|-List<Image>.get_Count
	|-List<Mask>.get_Count
	|-List<RectMask2D>.get_Count
	|-List<StencilMaterial.MatEntry>.get_Count
	|-List<Toggle>.get_Count
	|-List<EventCallbackFunctorBase>.get_Count
	|-List<VisualElement>.get_Count
	|-List<SplineControlPoint>.get_Count
	|-List<XWeaponTrail.Element>.get_Count
	|
	|-RVA: 0x248C9F0 Offset: 0x248CAF1 VA: 0x248C9F0
	|-List<AS_ToolController.ChargeInfo>.get_Count
	|
	|-RVA: 0x248FDC0 Offset: 0x248FEC1 VA: 0x248FDC0
	|-List<BuildItemData>.get_Count
	|
	|-RVA: 0x3156070 Offset: 0x3156171 VA: 0x3156070
	|-List<ButtonLinker.LinkObject>.get_Count
	|
	|-RVA: 0x31590C0 Offset: 0x31591C1 VA: 0x31590C0
	|-List<CharaCallTable.BustupTable>.get_Count
	|
	|-RVA: 0x315C0D0 Offset: 0x315C1D1 VA: 0x315C0D0
	|-List<CharaCallTable.CharaFaceIconTable>.get_Count
	|
	|-RVA: 0x315F190 Offset: 0x315F291 VA: 0x315F190
	|-List<CameraState.CustomBlendable>.get_Count
	|
	|-RVA: 0x31621D0 Offset: 0x31622D1 VA: 0x31621D0
	|-List<CinemachineClearShot.Pair>.get_Count
	|
	|-RVA: 0x3165180 Offset: 0x3165281 VA: 0x3165180
	|-List<CinemachineStateDrivenCamera.HashPair>.get_Count
	|
	|-RVA: 0x3168150 Offset: 0x3168251 VA: 0x3168150
	|-List<TargetPositionCache.CacheCurve.Item>.get_Count
	|
	|-RVA: 0x316B630 Offset: 0x316B731 VA: 0x316B630
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.get_Count
	|
	|-RVA: 0x336D480 Offset: 0x336D581 VA: 0x336D480
	|-List<CraftCategoryId>.get_Count
	|-List<ActorID>.get_Count
	|-List<Alliance>.get_Count
	|-List<BadStatus>.get_Count
	|-List<BulletID>.get_Count
	|-List<CharID>.get_Count
	|-List<EffectID>.get_Count
	|-List<EmotionType>.get_Count
	|-List<FarmFieldWorkArea>.get_Count
	|-List<GameFlagData>.get_Count
	|-List<HairType>.get_Count
	|-List<NPCID>.get_Count
	|-List<PoliceBatchId>.get_Count
	|-List<StorageType>.get_Count
	|-List<ItemID>.get_Count
	|-List<MonsterActionBehaviorType>.get_Count
	|-List<NpcSearchCollider.VoiceType>.get_Count
	|-List<PartnerNPCActionBehaviorType>.get_Count
	|-List<RecipeId>.get_Count
	|-List<SoundID>.get_Count
	|-List<Int32Enum>.get_Count
	|-List<RegexOptions>.get_Count
	|-List<UINamingWindow.NamingId>.get_Count
	|
	|-RVA: 0x316EBA0 Offset: 0x316ECA1 VA: 0x316EBA0
	|-List<CropDataTable>.get_Count
	|
	|-RVA: 0x3172140 Offset: 0x3172241 VA: 0x3172140
	|-List<DropItemParam>.get_Count
	|
	|-RVA: 0x3175110 Offset: 0x3175211 VA: 0x3175110
	|-List<ErosionBrush.UndoStep>.get_Count
	|
	|-RVA: 0x31DBDA0 Offset: 0x31DBEA1 VA: 0x31DBDA0
	|-List<EventCheckId>.get_Count
	|
	|-RVA: 0x31DF120 Offset: 0x31DF221 VA: 0x31DF120
	|-List<EventFlagProgressData>.get_Count
	|
	|-RVA: 0x31E2170 Offset: 0x31E2271 VA: 0x31E2170
	|-List<FesNpcScoreData>.get_Count
	|
	|-RVA: 0x31E51E0 Offset: 0x31E52E1 VA: 0x31E51E0
	|-List<MiningPointSaveData>.get_Count
	|
	|-RVA: 0x31E8740 Offset: 0x31E8841 VA: 0x31E8740
	|-List<MonsterHutSaveData>.get_Count
	|
	|-RVA: 0x31EBC40 Offset: 0x31EBD41 VA: 0x31EBC40
	|-List<MoviePlayer.SUBTITLEDATA>.get_Count
	|
	|-RVA: 0x31EECC0 Offset: 0x31EEDC1 VA: 0x31EECC0
	|-List<NPCActionData>.get_Count
	|
	|-RVA: 0x31F2370 Offset: 0x31F2471 VA: 0x31F2370
	|-List<NpcPlaceSchedule>.get_Count
	|
	|-RVA: 0x31F56F0 Offset: 0x31F57F1 VA: 0x31F56F0
	|-List<OrderLotterySaveParameter>.get_Count
	|
	|-RVA: 0x31F87D0 Offset: 0x31F88D1 VA: 0x31F87D0
	|-List<OrderSaveParameter>.get_Count
	|
	|-RVA: 0x31FBB60 Offset: 0x31FBC61 VA: 0x31FBB60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Count
	|
	|-RVA: 0x330ADD0 Offset: 0x330AED1 VA: 0x330ADD0
	|-List<ShopCatalogPage>.get_Count
	|
	|-RVA: 0x330DE30 Offset: 0x330DF31 VA: 0x330DE30
	|-List<ShopNpcTalk>.get_Count
	|
	|-RVA: 0x33113D0 Offset: 0x33114D1 VA: 0x33113D0
	|-List<SubtitleDataTable.Data>.get_Count
	|
	|-RVA: 0x3314490 Offset: 0x3314591 VA: 0x3314490
	|-List<SubtitleDataTable.DataList>.get_Count
	|
	|-RVA: 0x3317460 Offset: 0x3317561 VA: 0x3317460
	|-List<SubtitleHudDataTable.Data>.get_Count
	|
	|-RVA: 0x331A540 Offset: 0x331A641 VA: 0x331A540
	|-List<SRMonoBehaviourEx.FieldInfo>.get_Count
	|
	|-RVA: 0x331D8F0 Offset: 0x331D9F1 VA: 0x331D8F0
	|-List<Schedule>.get_Count
	|
	|-RVA: 0x3320C50 Offset: 0x3320D51 VA: 0x3320C50
	|-List<CurveSample>.get_Count
	|
	|-RVA: 0x33244D0 Offset: 0x33245D1 VA: 0x33244D0
	|-List<bool>.get_Count
	|
	|-RVA: 0x33274C0 Offset: 0x33275C1 VA: 0x33274C0
	|-List<byte>.get_Count
	|
	|-RVA: 0x332A490 Offset: 0x332A591 VA: 0x332A490
	|-List<char>.get_Count
	|
	|-RVA: 0x33584E0 Offset: 0x33585E1 VA: 0x33584E0
	|-List<KeyValuePair<DateTime, object>>.get_Count
	|-List<KeyValuePair<DateTime, TimeType>>.get_Count
	|
	|-RVA: 0x335B530 Offset: 0x335B631 VA: 0x335B530
	|-List<KeyValuePair<int, object>>.get_Count
	|
	|-RVA: 0x335E580 Offset: 0x335E681 VA: 0x335E580
	|-List<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x33615C0 Offset: 0x33616C1 VA: 0x33615C0
	|-List<DateTime>.get_Count
	|
	|-RVA: 0x3364560 Offset: 0x3364661 VA: 0x3364560
	|-List<double>.get_Count
	|
	|-RVA: 0x3367520 Offset: 0x3367621 VA: 0x3367520
	|-List<short>.get_Count
	|
	|-RVA: 0x336A4D0 Offset: 0x336A5D1 VA: 0x336A4D0
	|-List<int>.get_Count
	|
	|-RVA: 0x3370430 Offset: 0x3370531 VA: 0x3370430
	|-List<long>.get_Count
	|
	|-RVA: 0x33733E0 Offset: 0x33734E1 VA: 0x33733E0
	|-List<InterpretedFrameInfo>.get_Count
	|
	|-RVA: 0x3376420 Offset: 0x3376521 VA: 0x3376420
	|-List<Nullable<Int32Enum>>.get_Count
	|
	|-RVA: 0x34050D0 Offset: 0x34051D1 VA: 0x34050D0
	|-List<Nullable<Bounds>>.get_Count
	|
	|-RVA: 0x3408690 Offset: 0x3408791 VA: 0x3408690
	|-List<Nullable<BoundsInt>>.get_Count
	|
	|-RVA: 0x340BC30 Offset: 0x340BD31 VA: 0x340BC30
	|-List<Nullable<Color32>>.get_Count
	|
	|-RVA: 0x340EC50 Offset: 0x340ED51 VA: 0x340EC50
	|-List<Nullable<Color>>.get_Count
	|
	|-RVA: 0x3412090 Offset: 0x3412191 VA: 0x3412090
	|-List<Nullable<GradientAlphaKey>>.get_Count
	|
	|-RVA: 0x34151D0 Offset: 0x34152D1 VA: 0x34151D0
	|-List<Nullable<GradientColorKey>>.get_Count
	|
	|-RVA: 0x3418620 Offset: 0x3418721 VA: 0x3418620
	|-List<Nullable<Keyframe>>.get_Count
	|
	|-RVA: 0x341BA60 Offset: 0x341BB61 VA: 0x341BA60
	|-List<Nullable<LayerMask>>.get_Count
	|
	|-RVA: 0x341EA90 Offset: 0x341EB91 VA: 0x341EA90
	|-List<Nullable<Matrix4x4>>.get_Count
	|
	|-RVA: 0x34224C0 Offset: 0x34225C1 VA: 0x34224C0
	|-List<Nullable<Quaternion>>.get_Count
	|
	|-RVA: 0x3262370 Offset: 0x3262471 VA: 0x3262370
	|-List<Nullable<RangeInt>>.get_Count
	|
	|-RVA: 0x32654B0 Offset: 0x32655B1 VA: 0x32654B0
	|-List<Nullable<Rect>>.get_Count
	|
	|-RVA: 0x3268910 Offset: 0x3268A11 VA: 0x3268910
	|-List<Nullable<RectInt>>.get_Count
	|
	|-RVA: 0x326BD50 Offset: 0x326BE51 VA: 0x326BD50
	|-List<Nullable<Vector2>>.get_Count
	|
	|-RVA: 0x326EE70 Offset: 0x326EF71 VA: 0x326EE70
	|-List<Nullable<Vector2Int>>.get_Count
	|
	|-RVA: 0x3271F90 Offset: 0x3272091 VA: 0x3271F90
	|-List<Nullable<Vector3>>.get_Count
	|
	|-RVA: 0x3275000 Offset: 0x3275101 VA: 0x3275000
	|-List<Nullable<Vector3Int>>.get_Count
	|
	|-RVA: 0x3278090 Offset: 0x3278191 VA: 0x3278090
	|-List<Nullable<Vector4>>.get_Count
	|
	|-RVA: 0x327E400 Offset: 0x327E501 VA: 0x327E400
	|-List<sbyte>.get_Count
	|
	|-RVA: 0x32813C0 Offset: 0x32814C1 VA: 0x32813C0
	|-List<float>.get_Count
	|
	|-RVA: 0x32A8630 Offset: 0x32A8731 VA: 0x32A8630
	|-List<ushort>.get_Count
	|
	|-RVA: 0x32AB5E0 Offset: 0x32AB6E1 VA: 0x32AB5E0
	|-List<uint>.get_Count
	|
	|-RVA: 0x32AE590 Offset: 0x32AE691 VA: 0x32AE590
	|-List<ulong>.get_Count
	|
	|-RVA: 0x32B1540 Offset: 0x32B1641 VA: 0x32B1540
	|-List<ValueTuple<bool, Int32Enum>>.get_Count
	|
	|-RVA: 0x32B44F0 Offset: 0x32B45F1 VA: 0x32B44F0
	|-List<ValueTuple<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x32B74A0 Offset: 0x32B75A1 VA: 0x32B74A0
	|-List<ValueTuple<Int32Enum, object>>.get_Count
	|
	|-RVA: 0x32BA4F0 Offset: 0x32BA5F1 VA: 0x32BA4F0
	|-List<ValueTuple<object, Int32Enum>>.get_Count
	|
	|-RVA: 0x32BD530 Offset: 0x32BD631 VA: 0x32BD530
	|-List<ValueTuple<object, object>>.get_Count
	|
	|-RVA: 0x32C0570 Offset: 0x32C0671 VA: 0x32C0570
	|-List<ValueTuple<object, float>>.get_Count
	|
	|-RVA: 0x32C35B0 Offset: 0x32C36B1 VA: 0x32C35B0
	|-List<ValueTuple<CharID, VariationNo, HairType>>.get_Count
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Count
	|
	|-RVA: 0x32C66A0 Offset: 0x32C67A1 VA: 0x32C66A0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Count
	|
	|-RVA: 0x3110300 Offset: 0x3110401 VA: 0x3110300
	|-List<TexturePacker_JsonArray.Frame>.get_Count
	|
	|-RVA: 0x31139C0 Offset: 0x3113AC1 VA: 0x31139C0
	|-List<TutorialUnlockFlagData>.get_Count
	|
	|-RVA: 0x3116A80 Offset: 0x3116B81 VA: 0x3116A80
	|-List<UIMainManagerAttachObject.AttachSet>.get_Count
	|
	|-RVA: 0x3119AF0 Offset: 0x3119BF1 VA: 0x3119AF0
	|-List<CapEdge>.get_Count
	|
	|-RVA: 0x311D030 Offset: 0x311D131 VA: 0x311D030
	|-List<MeshDataConnectivity.Face>.get_Count
	|
	|-RVA: 0x3120000 Offset: 0x3120101 VA: 0x3120000
	|-List<MeshFaceConnectivity.EdgeData.SideData>.get_Count
	|
	|-RVA: 0x3123350 Offset: 0x3123451 VA: 0x3123350
	|-List<MeshFaceConnectivity.EdgeData>.get_Count
	|
	|-RVA: 0x31268F0 Offset: 0x31269F1 VA: 0x31268F0
	|-List<NavMeshBuildMarkup>.get_Count
	|
	|-RVA: 0x3129940 Offset: 0x3129A41 VA: 0x3129940
	|-List<NavMeshBuildSource>.get_Count
	|
	|-RVA: 0x312D4D0 Offset: 0x312D5D1 VA: 0x312D4D0
	|-List<ConstraintSource>.get_Count
	|
	|-RVA: 0x3130510 Offset: 0x3130611 VA: 0x3130510
	|-List<AnimatorClipInfo>.get_Count
	|
	|-RVA: 0x321C0A0 Offset: 0x321C1A1 VA: 0x321C0A0
	|-List<BeforeRenderHelper.OrderBlock>.get_Count
	|
	|-RVA: 0x321F110 Offset: 0x321F211 VA: 0x321F110
	|-List<BoneWeight>.get_Count
	|
	|-RVA: 0x3222470 Offset: 0x3222571 VA: 0x3222470
	|-List<Bounds>.get_Count
	|
	|-RVA: 0x32257C0 Offset: 0x32258C1 VA: 0x32257C0
	|-List<BoundsInt>.get_Count
	|
	|-RVA: 0x3228AF0 Offset: 0x3228BF1 VA: 0x3228AF0
	|-List<Color32>.get_Count
	|
	|-RVA: 0x322BAB0 Offset: 0x322BBB1 VA: 0x322BAB0
	|-List<Color>.get_Count
	|
	|-RVA: 0x322EB80 Offset: 0x322EC81 VA: 0x322EB80
	|-List<CombineInstance>.get_Count
	|
	|-RVA: 0x3232760 Offset: 0x3232861 VA: 0x3232760
	|-List<RaycastResult>.get_Count
	|
	|-RVA: 0x3236000 Offset: 0x3236101 VA: 0x3236000
	|-List<GradientAlphaKey>.get_Count
	|
	|-RVA: 0x3239050 Offset: 0x3239151 VA: 0x3239050
	|-List<GradientColorKey>.get_Count
	|
	|-RVA: 0x323C3B0 Offset: 0x323C4B1 VA: 0x323C3B0
	|-List<Keyframe>.get_Count
	|
	|-RVA: 0x323F870 Offset: 0x323F971 VA: 0x323F870
	|-List<LayerMask>.get_Count
	|
	|-RVA: 0x3242870 Offset: 0x3242971 VA: 0x3242870
	|-List<Matrix4x4>.get_Count
	|
	|-RVA: 0x3245F20 Offset: 0x3246021 VA: 0x3245F20
	|-List<ParticleSystem.Particle>.get_Count
	|
	|-RVA: 0x32493B0 Offset: 0x32494B1 VA: 0x32493B0
	|-List<Playable>.get_Count
	|
	|-RVA: 0x324C3E0 Offset: 0x324C4E1 VA: 0x324C3E0
	|-List<PlayableBinding>.get_Count
	|
	|-RVA: 0x324F770 Offset: 0x324F871 VA: 0x324F770
	|-List<PlayableGraph>.get_Count
	|
	|-RVA: 0x3252780 Offset: 0x3252881 VA: 0x3252780
	|-List<Edge>.get_Count
	|
	|-RVA: 0x3255720 Offset: 0x3255821 VA: 0x3255720
	|-List<Quaternion>.get_Count
	|
	|-RVA: 0x32587B0 Offset: 0x32588B1 VA: 0x32587B0
	|-List<RangeInt>.get_Count
	|
	|-RVA: 0x325B780 Offset: 0x325B881 VA: 0x325B780
	|-List<RaycastHit2D>.get_Count
	|
	|-RVA: 0x325ECF0 Offset: 0x325EDF1 VA: 0x325ECF0
	|-List<RaycastHit>.get_Count
	|
	|-RVA: 0x33C0B60 Offset: 0x33C0C61 VA: 0x33C0B60
	|-List<Rect>.get_Count
	|
	|-RVA: 0x33C3BF0 Offset: 0x33C3CF1 VA: 0x33C3BF0
	|-List<RectInt>.get_Count
	|
	|-RVA: 0x33C6C00 Offset: 0x33C6D01 VA: 0x33C6C00
	|-List<ReflectionProbeBlendInfo>.get_Count
	|
	|-RVA: 0x33C9C90 Offset: 0x33C9D91 VA: 0x33C9C90
	|-List<SphericalHarmonicsL2>.get_Count
	|
	|-RVA: 0x33CD9A0 Offset: 0x33CDAA1 VA: 0x33CD9A0
	|-List<VertexAttributeDescriptor>.get_Count
	|
	|-RVA: 0x33D09D0 Offset: 0x33D0AD1 VA: 0x33D09D0
	|-List<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x33D3D70 Offset: 0x33D3E71 VA: 0x33D3D70
	|-List<AsyncOperationHandle<SceneInstance>>.get_Count
	|
	|-RVA: 0x33D7110 Offset: 0x33D7211 VA: 0x33D7110
	|-List<DiagnosticEvent>.get_Count
	|
	|-RVA: 0x33DA6D0 Offset: 0x33DA7D1 VA: 0x33DA6D0
	|-List<DelayedActionManager.DelegateInfo>.get_Count
	|
	|-RVA: 0x33DDA80 Offset: 0x33DDB81 VA: 0x33DDA80
	|-List<ObjectInitializationData>.get_Count
	|
	|-RVA: 0x31B8F70 Offset: 0x31B9071 VA: 0x31B8F70
	|-List<GlyphRect>.get_Count
	|
	|-RVA: 0x31BBFA0 Offset: 0x31BC0A1 VA: 0x31BBFA0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.get_Count
	|
	|-RVA: 0x31BF480 Offset: 0x31BF581 VA: 0x31BF480
	|-List<IntervalTreeNode>.get_Count
	|
	|-RVA: 0x31C27D0 Offset: 0x31C28D1 VA: 0x31C27D0
	|-List<IntervalTree.Entry<object>>.get_Count
	|
	|-RVA: 0x31C5B70 Offset: 0x31C5C71 VA: 0x31C5B70
	|-List<TimeNotificationBehaviour.NotificationEntry>.get_Count
	|
	|-RVA: 0x31C8EE0 Offset: 0x31C8FE1 VA: 0x31C8EE0
	|-List<UICharInfo>.get_Count
	|
	|-RVA: 0x31CBF70 Offset: 0x31CC071 VA: 0x31CBF70
	|-List<FocusController.FocusedElement>.get_Count
	|
	|-RVA: 0x31CEFB0 Offset: 0x31CF0B1 VA: 0x31CEFB0
	|-List<UILineInfo>.get_Count
	|
	|-RVA: 0x31D2000 Offset: 0x31D2101 VA: 0x31D2000
	|-List<UIVertex>.get_Count
	|
	|-RVA: 0x31D59E0 Offset: 0x31D5AE1 VA: 0x31D59E0
	|-List<UnitySynchronizationContext.WorkRequest>.get_Count
	|
	|-RVA: 0x31D8D50 Offset: 0x31D8E51 VA: 0x31D8D50
	|-List<Vector2>.get_Count
	|
	|-RVA: 0x2CE1990 Offset: 0x2CE1A91 VA: 0x2CE1990
	|-List<Vector2Int>.get_Count
	|
	|-RVA: 0x2CE4930 Offset: 0x2CE4A31 VA: 0x2CE4930
	|-List<Vector3>.get_Count
	|
	|-RVA: 0x2CE79C0 Offset: 0x2CE7AC1 VA: 0x2CE79C0
	|-List<Vector3Int>.get_Count
	|
	|-RVA: 0x2CEAA70 Offset: 0x2CEAB71 VA: 0x2CEAA70
	|-List<Vector4>.get_Count
	|
	|-RVA: 0x2CEDB50 Offset: 0x2CEDC51 VA: 0x2CEDB50
	|-List<WarpPoints.WarpPoint>.get_Count
	|
	|-RVA: 0x2CF1810 Offset: 0x2CF1911 VA: 0x2CF1810
	|-List<YieldItemParam>.get_Count
	|
	|-RVA: 0x2CF47E0 Offset: 0x2CF48E1 VA: 0x2CF47E0
	|-List<stCommand_t>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CA00 Offset: 0x248CB01 VA: 0x248CA00
	|-List<AS_ToolController.ChargeInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x248FDD0 Offset: 0x248FED1 VA: 0x248FDD0
	|-List<BuildItemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3156080 Offset: 0x3156181 VA: 0x3156080
	|-List<ButtonLinker.LinkObject>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31590D0 Offset: 0x31591D1 VA: 0x31590D0
	|-List<CharaCallTable.BustupTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x315C0E0 Offset: 0x315C1E1 VA: 0x315C0E0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x315F1A0 Offset: 0x315F2A1 VA: 0x315F1A0
	|-List<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31621E0 Offset: 0x31622E1 VA: 0x31621E0
	|-List<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3165190 Offset: 0x3165291 VA: 0x3165190
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3168160 Offset: 0x3168261 VA: 0x3168160
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x316B640 Offset: 0x316B741 VA: 0x316B640
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x316EBB0 Offset: 0x316ECB1 VA: 0x316EBB0
	|-List<CropDataTable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3172150 Offset: 0x3172251 VA: 0x3172150
	|-List<DropItemParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3175120 Offset: 0x3175221 VA: 0x3175120
	|-List<ErosionBrush.UndoStep>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31DBDB0 Offset: 0x31DBEB1 VA: 0x31DBDB0
	|-List<EventCheckId>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31DF130 Offset: 0x31DF231 VA: 0x31DF130
	|-List<EventFlagProgressData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31E2180 Offset: 0x31E2281 VA: 0x31E2180
	|-List<FesNpcScoreData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31E51F0 Offset: 0x31E52F1 VA: 0x31E51F0
	|-List<MiningPointSaveData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31E8750 Offset: 0x31E8851 VA: 0x31E8750
	|-List<MonsterHutSaveData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31EBC50 Offset: 0x31EBD51 VA: 0x31EBC50
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31EECD0 Offset: 0x31EEDD1 VA: 0x31EECD0
	|-List<NPCActionData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31F2380 Offset: 0x31F2481 VA: 0x31F2380
	|-List<NpcPlaceSchedule>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31F5700 Offset: 0x31F5801 VA: 0x31F5700
	|-List<OrderLotterySaveParameter>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31F87E0 Offset: 0x31F88E1 VA: 0x31F87E0
	|-List<OrderSaveParameter>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31FBB70 Offset: 0x31FBC71 VA: 0x31FBB70
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x330ADE0 Offset: 0x330AEE1 VA: 0x330ADE0
	|-List<ShopCatalogPage>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x330DE40 Offset: 0x330DF41 VA: 0x330DE40
	|-List<ShopNpcTalk>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33113E0 Offset: 0x33114E1 VA: 0x33113E0
	|-List<SubtitleDataTable.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33144A0 Offset: 0x33145A1 VA: 0x33144A0
	|-List<SubtitleDataTable.DataList>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3317470 Offset: 0x3317571 VA: 0x3317470
	|-List<SubtitleHudDataTable.Data>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x331A550 Offset: 0x331A651 VA: 0x331A550
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x331D900 Offset: 0x331DA01 VA: 0x331D900
	|-List<Schedule>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3320C60 Offset: 0x3320D61 VA: 0x3320C60
	|-List<CurveSample>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33244E0 Offset: 0x33245E1 VA: 0x33244E0
	|-List<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33274D0 Offset: 0x33275D1 VA: 0x33274D0
	|-List<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x332A4A0 Offset: 0x332A5A1 VA: 0x332A4A0
	|-List<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33584F0 Offset: 0x33585F1 VA: 0x33584F0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x335B540 Offset: 0x335B641 VA: 0x335B540
	|-List<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x335E590 Offset: 0x335E691 VA: 0x335E590
	|-List<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33615D0 Offset: 0x33616D1 VA: 0x33615D0
	|-List<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3364570 Offset: 0x3364671 VA: 0x3364570
	|-List<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3367530 Offset: 0x3367631 VA: 0x3367530
	|-List<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x336A4E0 Offset: 0x336A5E1 VA: 0x336A4E0
	|-List<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x336D490 Offset: 0x336D591 VA: 0x336D490
	|-List<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3370440 Offset: 0x3370541 VA: 0x3370440
	|-List<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33733F0 Offset: 0x33734F1 VA: 0x33733F0
	|-List<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3376430 Offset: 0x3376531 VA: 0x3376430
	|-List<Nullable<Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x34050E0 Offset: 0x34051E1 VA: 0x34050E0
	|-List<Nullable<Bounds>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x34086A0 Offset: 0x34087A1 VA: 0x34086A0
	|-List<Nullable<BoundsInt>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x340BC40 Offset: 0x340BD41 VA: 0x340BC40
	|-List<Nullable<Color32>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x340EC60 Offset: 0x340ED61 VA: 0x340EC60
	|-List<Nullable<Color>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x34120A0 Offset: 0x34121A1 VA: 0x34120A0
	|-List<Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x34151E0 Offset: 0x34152E1 VA: 0x34151E0
	|-List<Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3418630 Offset: 0x3418731 VA: 0x3418630
	|-List<Nullable<Keyframe>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x341BA70 Offset: 0x341BB71 VA: 0x341BA70
	|-List<Nullable<LayerMask>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x341EAA0 Offset: 0x341EBA1 VA: 0x341EAA0
	|-List<Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x34224D0 Offset: 0x34225D1 VA: 0x34224D0
	|-List<Nullable<Quaternion>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3262380 Offset: 0x3262481 VA: 0x3262380
	|-List<Nullable<RangeInt>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32654C0 Offset: 0x32655C1 VA: 0x32654C0
	|-List<Nullable<Rect>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3268920 Offset: 0x3268A21 VA: 0x3268920
	|-List<Nullable<RectInt>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x326BD60 Offset: 0x326BE61 VA: 0x326BD60
	|-List<Nullable<Vector2>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x326EE80 Offset: 0x326EF81 VA: 0x326EE80
	|-List<Nullable<Vector2Int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3271FA0 Offset: 0x32720A1 VA: 0x3271FA0
	|-List<Nullable<Vector3>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3275010 Offset: 0x3275111 VA: 0x3275010
	|-List<Nullable<Vector3Int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32780A0 Offset: 0x32781A1 VA: 0x32780A0
	|-List<Nullable<Vector4>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x327B4E0 Offset: 0x327B5E1 VA: 0x327B4E0
	|-List<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x327E410 Offset: 0x327E511 VA: 0x327E410
	|-List<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32813D0 Offset: 0x32814D1 VA: 0x32813D0
	|-List<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32A8640 Offset: 0x32A8741 VA: 0x32A8640
	|-List<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32AB5F0 Offset: 0x32AB6F1 VA: 0x32AB5F0
	|-List<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32AE5A0 Offset: 0x32AE6A1 VA: 0x32AE5A0
	|-List<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32B1550 Offset: 0x32B1651 VA: 0x32B1550
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32B4500 Offset: 0x32B4601 VA: 0x32B4500
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32B74B0 Offset: 0x32B75B1 VA: 0x32B74B0
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32BA500 Offset: 0x32BA601 VA: 0x32BA500
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32BD540 Offset: 0x32BD641 VA: 0x32BD540
	|-List<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32C0580 Offset: 0x32C0681 VA: 0x32C0580
	|-List<ValueTuple<object, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32C35C0 Offset: 0x32C36C1 VA: 0x32C35C0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32C66B0 Offset: 0x32C67B1 VA: 0x32C66B0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3110310 Offset: 0x3110411 VA: 0x3110310
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31139D0 Offset: 0x3113AD1 VA: 0x31139D0
	|-List<TutorialUnlockFlagData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3116A90 Offset: 0x3116B91 VA: 0x3116A90
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3119B00 Offset: 0x3119C01 VA: 0x3119B00
	|-List<CapEdge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x311D040 Offset: 0x311D141 VA: 0x311D040
	|-List<MeshDataConnectivity.Face>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3120010 Offset: 0x3120111 VA: 0x3120010
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3123360 Offset: 0x3123461 VA: 0x3123360
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3126900 Offset: 0x3126A01 VA: 0x3126900
	|-List<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3129950 Offset: 0x3129A51 VA: 0x3129950
	|-List<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x312D4E0 Offset: 0x312D5E1 VA: 0x312D4E0
	|-List<ConstraintSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3130520 Offset: 0x3130621 VA: 0x3130520
	|-List<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x321C0B0 Offset: 0x321C1B1 VA: 0x321C0B0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x321F120 Offset: 0x321F221 VA: 0x321F120
	|-List<BoneWeight>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3222480 Offset: 0x3222581 VA: 0x3222480
	|-List<Bounds>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32257D0 Offset: 0x32258D1 VA: 0x32257D0
	|-List<BoundsInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3228B00 Offset: 0x3228C01 VA: 0x3228B00
	|-List<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x322BAC0 Offset: 0x322BBC1 VA: 0x322BAC0
	|-List<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x322EB90 Offset: 0x322EC91 VA: 0x322EB90
	|-List<CombineInstance>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3232770 Offset: 0x3232871 VA: 0x3232770
	|-List<RaycastResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3236010 Offset: 0x3236111 VA: 0x3236010
	|-List<GradientAlphaKey>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3239060 Offset: 0x3239161 VA: 0x3239060
	|-List<GradientColorKey>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x323C3C0 Offset: 0x323C4C1 VA: 0x323C3C0
	|-List<Keyframe>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x323F880 Offset: 0x323F981 VA: 0x323F880
	|-List<LayerMask>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3242880 Offset: 0x3242981 VA: 0x3242880
	|-List<Matrix4x4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3245F30 Offset: 0x3246031 VA: 0x3245F30
	|-List<ParticleSystem.Particle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32493C0 Offset: 0x32494C1 VA: 0x32493C0
	|-List<Playable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x324C3F0 Offset: 0x324C4F1 VA: 0x324C3F0
	|-List<PlayableBinding>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x324F780 Offset: 0x324F881 VA: 0x324F780
	|-List<PlayableGraph>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3252790 Offset: 0x3252891 VA: 0x3252790
	|-List<Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3255730 Offset: 0x3255831 VA: 0x3255730
	|-List<Quaternion>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x32587C0 Offset: 0x32588C1 VA: 0x32587C0
	|-List<RangeInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x325B790 Offset: 0x325B891 VA: 0x325B790
	|-List<RaycastHit2D>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x325ED00 Offset: 0x325EE01 VA: 0x325ED00
	|-List<RaycastHit>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33C0B70 Offset: 0x33C0C71 VA: 0x33C0B70
	|-List<Rect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33C3C00 Offset: 0x33C3D01 VA: 0x33C3C00
	|-List<RectInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33C6C10 Offset: 0x33C6D11 VA: 0x33C6C10
	|-List<ReflectionProbeBlendInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33C9CA0 Offset: 0x33C9DA1 VA: 0x33C9CA0
	|-List<SphericalHarmonicsL2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33CD9B0 Offset: 0x33CDAB1 VA: 0x33CD9B0
	|-List<VertexAttributeDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33D09E0 Offset: 0x33D0AE1 VA: 0x33D09E0
	|-List<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33D3D80 Offset: 0x33D3E81 VA: 0x33D3D80
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33D7120 Offset: 0x33D7221 VA: 0x33D7120
	|-List<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33DA6E0 Offset: 0x33DA7E1 VA: 0x33DA6E0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x33DDA90 Offset: 0x33DDB91 VA: 0x33DDA90
	|-List<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31B8F80 Offset: 0x31B9081 VA: 0x31B8F80
	|-List<GlyphRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31BBFB0 Offset: 0x31BC0B1 VA: 0x31BBFB0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31BF490 Offset: 0x31BF591 VA: 0x31BF490
	|-List<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31C27E0 Offset: 0x31C28E1 VA: 0x31C27E0
	|-List<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31C5B80 Offset: 0x31C5C81 VA: 0x31C5B80
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31C8EF0 Offset: 0x31C8FF1 VA: 0x31C8EF0
	|-List<UICharInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31CBF80 Offset: 0x31CC081 VA: 0x31CBF80
	|-List<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31CEFC0 Offset: 0x31CF0C1 VA: 0x31CEFC0
	|-List<UILineInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31D2010 Offset: 0x31D2111 VA: 0x31D2010
	|-List<UIVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31D59F0 Offset: 0x31D5AF1 VA: 0x31D59F0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x31D8D60 Offset: 0x31D8E61 VA: 0x31D8D60
	|-List<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CE19A0 Offset: 0x2CE1AA1 VA: 0x2CE19A0
	|-List<Vector2Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CE4940 Offset: 0x2CE4A41 VA: 0x2CE4940
	|-List<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CE79D0 Offset: 0x2CE7AD1 VA: 0x2CE79D0
	|-List<Vector3Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CEAA80 Offset: 0x2CEAB81 VA: 0x2CEAA80
	|-List<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CEDB60 Offset: 0x2CEDC61 VA: 0x2CEDB60
	|-List<WarpPoints.WarpPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CF1820 Offset: 0x2CF1921 VA: 0x2CF1820
	|-List<YieldItemParam>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2CF47F0 Offset: 0x2CF48F1 VA: 0x2CF47F0
	|-List<stCommand_t>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CA10 Offset: 0x248CB11 VA: 0x248CA10
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x248FDE0 Offset: 0x248FEE1 VA: 0x248FDE0
	|-List<BuildItemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3156090 Offset: 0x3156191 VA: 0x3156090
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31590E0 Offset: 0x31591E1 VA: 0x31590E0
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x315C0F0 Offset: 0x315C1F1 VA: 0x315C0F0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x315F1B0 Offset: 0x315F2B1 VA: 0x315F1B0
	|-List<CameraState.CustomBlendable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31621F0 Offset: 0x31622F1 VA: 0x31621F0
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31651A0 Offset: 0x31652A1 VA: 0x31651A0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3168170 Offset: 0x3168271 VA: 0x3168170
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x316B650 Offset: 0x316B751 VA: 0x316B650
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x316EBC0 Offset: 0x316ECC1 VA: 0x316EBC0
	|-List<CropDataTable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3172160 Offset: 0x3172261 VA: 0x3172160
	|-List<DropItemParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3175130 Offset: 0x3175231 VA: 0x3175130
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31DBDC0 Offset: 0x31DBEC1 VA: 0x31DBDC0
	|-List<EventCheckId>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31DF140 Offset: 0x31DF241 VA: 0x31DF140
	|-List<EventFlagProgressData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31E2190 Offset: 0x31E2291 VA: 0x31E2190
	|-List<FesNpcScoreData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31E5200 Offset: 0x31E5301 VA: 0x31E5200
	|-List<MiningPointSaveData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31E8760 Offset: 0x31E8861 VA: 0x31E8760
	|-List<MonsterHutSaveData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31EBC60 Offset: 0x31EBD61 VA: 0x31EBC60
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31EECE0 Offset: 0x31EEDE1 VA: 0x31EECE0
	|-List<NPCActionData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31F2390 Offset: 0x31F2491 VA: 0x31F2390
	|-List<NpcPlaceSchedule>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31F5710 Offset: 0x31F5811 VA: 0x31F5710
	|-List<OrderLotterySaveParameter>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31F87F0 Offset: 0x31F88F1 VA: 0x31F87F0
	|-List<OrderSaveParameter>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31FBB80 Offset: 0x31FBC81 VA: 0x31FBB80
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x330ADF0 Offset: 0x330AEF1 VA: 0x330ADF0
	|-List<ShopCatalogPage>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x330DE50 Offset: 0x330DF51 VA: 0x330DE50
	|-List<ShopNpcTalk>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33113F0 Offset: 0x33114F1 VA: 0x33113F0
	|-List<SubtitleDataTable.Data>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33144B0 Offset: 0x33145B1 VA: 0x33144B0
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3317480 Offset: 0x3317581 VA: 0x3317480
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x331A560 Offset: 0x331A661 VA: 0x331A560
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x331D910 Offset: 0x331DA11 VA: 0x331D910
	|-List<Schedule>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3320C70 Offset: 0x3320D71 VA: 0x3320C70
	|-List<CurveSample>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33244F0 Offset: 0x33245F1 VA: 0x33244F0
	|-List<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33274E0 Offset: 0x33275E1 VA: 0x33274E0
	|-List<byte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x332A4B0 Offset: 0x332A5B1 VA: 0x332A4B0
	|-List<char>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3358500 Offset: 0x3358601 VA: 0x3358500
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x335B550 Offset: 0x335B651 VA: 0x335B550
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x335E5A0 Offset: 0x335E6A1 VA: 0x335E5A0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33615E0 Offset: 0x33616E1 VA: 0x33615E0
	|-List<DateTime>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3364580 Offset: 0x3364681 VA: 0x3364580
	|-List<double>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3367540 Offset: 0x3367641 VA: 0x3367540
	|-List<short>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x336A4F0 Offset: 0x336A5F1 VA: 0x336A4F0
	|-List<int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x336D4A0 Offset: 0x336D5A1 VA: 0x336D4A0
	|-List<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3370450 Offset: 0x3370551 VA: 0x3370450
	|-List<long>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3373400 Offset: 0x3373501 VA: 0x3373400
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3376440 Offset: 0x3376541 VA: 0x3376440
	|-List<Nullable<Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34050F0 Offset: 0x34051F1 VA: 0x34050F0
	|-List<Nullable<Bounds>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34086B0 Offset: 0x34087B1 VA: 0x34086B0
	|-List<Nullable<BoundsInt>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x340BC50 Offset: 0x340BD51 VA: 0x340BC50
	|-List<Nullable<Color32>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x340EC70 Offset: 0x340ED71 VA: 0x340EC70
	|-List<Nullable<Color>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34120B0 Offset: 0x34121B1 VA: 0x34120B0
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34151F0 Offset: 0x34152F1 VA: 0x34151F0
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3418640 Offset: 0x3418741 VA: 0x3418640
	|-List<Nullable<Keyframe>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x341BA80 Offset: 0x341BB81 VA: 0x341BA80
	|-List<Nullable<LayerMask>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x341EAB0 Offset: 0x341EBB1 VA: 0x341EAB0
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x34224E0 Offset: 0x34225E1 VA: 0x34224E0
	|-List<Nullable<Quaternion>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3262390 Offset: 0x3262491 VA: 0x3262390
	|-List<Nullable<RangeInt>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32654D0 Offset: 0x32655D1 VA: 0x32654D0
	|-List<Nullable<Rect>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3268930 Offset: 0x3268A31 VA: 0x3268930
	|-List<Nullable<RectInt>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x326BD70 Offset: 0x326BE71 VA: 0x326BD70
	|-List<Nullable<Vector2>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x326EE90 Offset: 0x326EF91 VA: 0x326EE90
	|-List<Nullable<Vector2Int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3271FB0 Offset: 0x32720B1 VA: 0x3271FB0
	|-List<Nullable<Vector3>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3275020 Offset: 0x3275121 VA: 0x3275020
	|-List<Nullable<Vector3Int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32780B0 Offset: 0x32781B1 VA: 0x32780B0
	|-List<Nullable<Vector4>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x327B4F0 Offset: 0x327B5F1 VA: 0x327B4F0
	|-List<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x327E420 Offset: 0x327E521 VA: 0x327E420
	|-List<sbyte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32813E0 Offset: 0x32814E1 VA: 0x32813E0
	|-List<float>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32A8650 Offset: 0x32A8751 VA: 0x32A8650
	|-List<ushort>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32AB600 Offset: 0x32AB701 VA: 0x32AB600
	|-List<uint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32AE5B0 Offset: 0x32AE6B1 VA: 0x32AE5B0
	|-List<ulong>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32B1560 Offset: 0x32B1661 VA: 0x32B1560
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32B4510 Offset: 0x32B4611 VA: 0x32B4510
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32B74C0 Offset: 0x32B75C1 VA: 0x32B74C0
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32BA510 Offset: 0x32BA611 VA: 0x32BA510
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32BD550 Offset: 0x32BD651 VA: 0x32BD550
	|-List<ValueTuple<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32C0590 Offset: 0x32C0691 VA: 0x32C0590
	|-List<ValueTuple<object, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32C35D0 Offset: 0x32C36D1 VA: 0x32C35D0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32C66C0 Offset: 0x32C67C1 VA: 0x32C66C0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3110320 Offset: 0x3110421 VA: 0x3110320
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31139E0 Offset: 0x3113AE1 VA: 0x31139E0
	|-List<TutorialUnlockFlagData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3116AA0 Offset: 0x3116BA1 VA: 0x3116AA0
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3119B10 Offset: 0x3119C11 VA: 0x3119B10
	|-List<CapEdge>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x311D050 Offset: 0x311D151 VA: 0x311D050
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3120020 Offset: 0x3120121 VA: 0x3120020
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3123370 Offset: 0x3123471 VA: 0x3123370
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3126910 Offset: 0x3126A11 VA: 0x3126910
	|-List<NavMeshBuildMarkup>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3129960 Offset: 0x3129A61 VA: 0x3129960
	|-List<NavMeshBuildSource>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x312D4F0 Offset: 0x312D5F1 VA: 0x312D4F0
	|-List<ConstraintSource>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3130530 Offset: 0x3130631 VA: 0x3130530
	|-List<AnimatorClipInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x321C0C0 Offset: 0x321C1C1 VA: 0x321C0C0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x321F130 Offset: 0x321F231 VA: 0x321F130
	|-List<BoneWeight>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3222490 Offset: 0x3222591 VA: 0x3222490
	|-List<Bounds>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32257E0 Offset: 0x32258E1 VA: 0x32257E0
	|-List<BoundsInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3228B10 Offset: 0x3228C11 VA: 0x3228B10
	|-List<Color32>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x322BAD0 Offset: 0x322BBD1 VA: 0x322BAD0
	|-List<Color>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x322EBA0 Offset: 0x322ECA1 VA: 0x322EBA0
	|-List<CombineInstance>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3232780 Offset: 0x3232881 VA: 0x3232780
	|-List<RaycastResult>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3236020 Offset: 0x3236121 VA: 0x3236020
	|-List<GradientAlphaKey>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3239070 Offset: 0x3239171 VA: 0x3239070
	|-List<GradientColorKey>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x323C3D0 Offset: 0x323C4D1 VA: 0x323C3D0
	|-List<Keyframe>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x323F890 Offset: 0x323F991 VA: 0x323F890
	|-List<LayerMask>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3242890 Offset: 0x3242991 VA: 0x3242890
	|-List<Matrix4x4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3245F40 Offset: 0x3246041 VA: 0x3245F40
	|-List<ParticleSystem.Particle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32493D0 Offset: 0x32494D1 VA: 0x32493D0
	|-List<Playable>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x324C400 Offset: 0x324C501 VA: 0x324C400
	|-List<PlayableBinding>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x324F790 Offset: 0x324F891 VA: 0x324F790
	|-List<PlayableGraph>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32527A0 Offset: 0x32528A1 VA: 0x32527A0
	|-List<Edge>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x3255740 Offset: 0x3255841 VA: 0x3255740
	|-List<Quaternion>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x32587D0 Offset: 0x32588D1 VA: 0x32587D0
	|-List<RangeInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x325B7A0 Offset: 0x325B8A1 VA: 0x325B7A0
	|-List<RaycastHit2D>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x325ED10 Offset: 0x325EE11 VA: 0x325ED10
	|-List<RaycastHit>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33C0B80 Offset: 0x33C0C81 VA: 0x33C0B80
	|-List<Rect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33C3C10 Offset: 0x33C3D11 VA: 0x33C3C10
	|-List<RectInt>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33C6C20 Offset: 0x33C6D21 VA: 0x33C6C20
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33C9CB0 Offset: 0x33C9DB1 VA: 0x33C9CB0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33CD9C0 Offset: 0x33CDAC1 VA: 0x33CD9C0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33D09F0 Offset: 0x33D0AF1 VA: 0x33D09F0
	|-List<AsyncOperationHandle>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33D3D90 Offset: 0x33D3E91 VA: 0x33D3D90
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33D7130 Offset: 0x33D7231 VA: 0x33D7130
	|-List<DiagnosticEvent>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33DA6F0 Offset: 0x33DA7F1 VA: 0x33DA6F0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x33DDAA0 Offset: 0x33DDBA1 VA: 0x33DDAA0
	|-List<ObjectInitializationData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31B8F90 Offset: 0x31B9091 VA: 0x31B8F90
	|-List<GlyphRect>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31BBFC0 Offset: 0x31BC0C1 VA: 0x31BBFC0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31BF4A0 Offset: 0x31BF5A1 VA: 0x31BF4A0
	|-List<IntervalTreeNode>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31C27F0 Offset: 0x31C28F1 VA: 0x31C27F0
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31C5B90 Offset: 0x31C5C91 VA: 0x31C5B90
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31C8F00 Offset: 0x31C9001 VA: 0x31C8F00
	|-List<UICharInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31CBF90 Offset: 0x31CC091 VA: 0x31CBF90
	|-List<FocusController.FocusedElement>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31CEFD0 Offset: 0x31CF0D1 VA: 0x31CEFD0
	|-List<UILineInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31D2020 Offset: 0x31D2121 VA: 0x31D2020
	|-List<UIVertex>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31D5A00 Offset: 0x31D5B01 VA: 0x31D5A00
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x31D8D70 Offset: 0x31D8E71 VA: 0x31D8D70
	|-List<Vector2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CE19B0 Offset: 0x2CE1AB1 VA: 0x2CE19B0
	|-List<Vector2Int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CE4950 Offset: 0x2CE4A51 VA: 0x2CE4950
	|-List<Vector3>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CE79E0 Offset: 0x2CE7AE1 VA: 0x2CE79E0
	|-List<Vector3Int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CEAA90 Offset: 0x2CEAB91 VA: 0x2CEAA90
	|-List<Vector4>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CEDB70 Offset: 0x2CEDC71 VA: 0x2CEDB70
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CF1830 Offset: 0x2CF1931 VA: 0x2CF1830
	|-List<YieldItemParam>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2CF4800 Offset: 0x2CF4901 VA: 0x2CF4800
	|-List<stCommand_t>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327B500 Offset: 0x327B601 VA: 0x327B500
	|-List<AIInput>.get_Item
	|-List<ActionBehaviorCommandBase>.get_Item
	|-List<ActionBehaviorCommandData.Argument>.get_Item
	|-List<Actor>.get_Item
	|-List<AdvOneImageDataTable.DataTable>.get_Item
	|-List<AracneFlatWeb>.get_Item
	|-List<AttackCollider>.get_Item
	|-List<AudmuraCrystal>.get_Item
	|-List<AutomaticLOD.LODLevelData>.get_Item
	|-List<AutomaticLOD>.get_Item
	|-List<BaffamoFestivalData>.get_Item
	|-List<BasiliskController.WearFireController>.get_Item
	|-List<BeanData>.get_Item
	|-List<BeanSowingActionData>.get_Item
	|-List<BeanSowingActionTerm>.get_Item
	|-List<BehaviorManager.BehaviorThreadLoader>.get_Item
	|-List<BehaviorManager.BehaviorTree.ConditionalReevaluate>.get_Item
	|-List<BehaviorManager.BehaviorTree>.get_Item
	|-List<SharedVariable>.get_Item
	|-List<TaskCoroutine>.get_Item
	|-List<Task>.get_Item
	|-List<VariableSynchronizer.SynchronizedVariable>.get_Item
	|-List<BehaviorTreeManager.EnemyBehaviorParameter>.get_Item
	|-List<BgmList>.get_Item
	|-List<BirthTalkData>.get_Item
	|-List<BodyPartsCollision>.get_Item
	|-List<BossBehaviorParams>.get_Item
	|-List<BustupDataList.DataTable>.get_Item
	|-List<ButtonLinker>.get_Item
	|-List<CameraManager.CameraControllerPair>.get_Item
	|-List<CerberusController.DogParam>.get_Item
	|-List<CharaVoiceGroupDataArray>.get_Item
	|-List<Character>.get_Item
	|-List<CharacterCallingData>.get_Item
	|-List<CharacterEnableMoveNormalizeTime.EnableSettingNormalizeTime>.get_Item
	|-List<CharacterEnableRotateNormalizeTime.EnableSettingNormalizeTime>.get_Item
	|-List<CheerVoiceData>.get_Item
	|-List<ChildData>.get_Item
	|-List<ChoiceImage>.get_Item
	|-List<CinemachineBrain.BrainFrame>.get_Item
	|-List<CinemachineBrain>.get_Item
	|-List<CinemachineExtension>.get_Item
	|-List<CinemachineImpulseManager.ImpulseEvent>.get_Item
	|-List<CinemachineStoryboard.CanvasInfo>.get_Item
	|-List<CinemachineVirtualCameraBase>.get_Item
	|-List<CombinedMesh.ObjectInfo>.get_Item
	|-List<VariableBase>.get_Item
	|-List<CursorEvent>.get_Item
	|-List<ABSSequentiable>.get_Item
	|-List<Tween>.get_Item
	|-List<TweenCallback>.get_Item
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>.get_Item
	|-List<DamageText>.get_Item
	|-List<DateSlotControl>.get_Item
	|-List<DynamicBone.Particle>.get_Item
	|-List<DynamicBoneColliderBase>.get_Item
	|-List<DynamicBoneH.Particle>.get_Item
	|-List<EventScheduleData>.get_Item
	|-List<EventStartData>.get_Item
	|-List<EventUnlockFlagData>.get_Item
	|-List<CellController>.get_Item
	|-List<FarmCropData>.get_Item
	|-List<FarmSupportMonsterController>.get_Item
	|-List<FarmSupportMonsterData>.get_Item
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>.get_Item
	|-List<FesNpcScore>.get_Item
	|-List<FestivalSnowball>.get_Item
	|-List<ObjectLoader>.get_Item
	|-List<FishRecord>.get_Item
	|-List<FishSwim>.get_Item
	|-List<FishingPoint>.get_Item
	|-List<FracturedChunk.AdjacencyInfo>.get_Item
	|-List<FracturedChunk>.get_Item
	|-List<FriendJudgmentManager.FriendJudgmentMonster>.get_Item
	|-List<FriendMonsterStatusData>.get_Item
	|-List<BoolKeyframe>.get_Item
	|-List<ColorKeyframe>.get_Item
	|-List<LightningArtItem>.get_Item
	|-List<LightningRenderer>.get_Item
	|-List<LightningSpawnArea>.get_Item
	|-List<RainSplashArtItem>.get_Item
	|-List<RainSplashRenderer>.get_Item
	|-List<SpherePointKeyframe>.get_Item
	|-List<WeatherEnclosure>.get_Item
	|-List<GluttonFoodData>.get_Item
	|-List<GluttonItemTerm>.get_Item
	|-List<HUDDualWorkSelectInput.DualSelect>.get_Item
	|-List<HUDMinimapControl.RectImage>.get_Item
	|-List<HateController.HateParameter>.get_Item
	|-List<HintData>.get_Item
	|-List<HoldItemController.ItemModel>.get_Item
	|-List<InosisiController.ThornsController>.get_Item
	|-List<ItemData>.get_Item
	|-List<ItemDataLinker>.get_Item
	|-List<ItemEquip>.get_Item
	|-List<FurnitureSaveData>.get_Item
	|-List<ItemStorage>.get_Item
	|-List<KrakenStickController>.get_Item
	|-List<KyubiController.FireballParameter>.get_Item
	|-List<LifeCycleAdvData>.get_Item
	|-List<AssetHandle>.get_Item
	|-List<MobBrain>.get_Item
	|-List<MobDeployCharData>.get_Item
	|-List<MocomocoData>.get_Item
	|-List<ModelScaleData>.get_Item
	|-List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.get_Item
	|-List<MonsterActionBehaviorData>.get_Item
	|-List<MonsterActionBehaviorDataTable.MonsterActionBehaviorCodeData>.get_Item
	|-List<MonsterBehaviorController.BehaviorActionParam>.get_Item
	|-List<MonsterControllerBase>.get_Item
	|-List<MonsterHutArea>.get_Item
	|-List<MonsterHutController.OrderFarmInParameter>.get_Item
	|-List<MovieRoomData>.get_Item
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.get_Item
	|-List<NPCActionBehaviorDataTable.NPCActionBehaviorCodeData>.get_Item
	|-List<NpcController>.get_Item
	|-List<NpcData>.get_Item
	|-List<NpcPatrolPoint>.get_Item
	|-List<NpcSaveParameter>.get_Item
	|-List<NpcTimeAction>.get_Item
	|-List<OnGroundItem>.get_Item
	|-List<OrderData>.get_Item
	|-List<OrderHUDBlock>.get_Item
	|-List<OrderMasterData>.get_Item
	|-List<OrderPopControl.StockDoOrder>.get_Item
	|-List<PartnerManager.DestinationAngle>.get_Item
	|-List<PartnerManager.NPCChangeBaseParameter>.get_Item
	|-List<PartnerManager.PartnerSearchRange>.get_Item
	|-List<PartnerMonsterBehaviorController>.get_Item
	|-List<PartyBase>.get_Item
	|-List<PartyMonster>.get_Item
	|-List<PesronalMotionPlayData>.get_Item
	|-List<PlayerSkillBase>.get_Item
	|-List<Contour>.get_Item
	|-List<EdgeIntersectInfo>.get_Item
	|-List<Point2D>.get_Item
	|-List<Point2DList>.get_Item
	|-List<Polygon>.get_Item
	|-List<PolygonPoint>.get_Item
	|-List<SplitComplexPolygonNode>.get_Item
	|-List<TriangulationPoint>.get_Item
	|-List<PreloadHandle>.get_Item
	|-List<QuestIconData>.get_Item
	|-List<FishShipmentRecords>.get_Item
	|-List<SeedLevelRecords>.get_Item
	|-List<ShipmentItemRecords>.get_Item
	|-List<SeedShopItemDataTable.SeedShopItemData>.get_Item
	|-List<ShopItem>.get_Item
	|-List<SubtitleHandler>.get_Item
	|-List<UIEMCustomizeSet>.get_Item
	|-List<WantedData>.get_Item
	|-List<RecipeDataDispBlock>.get_Item
	|-List<RecipeDataTableArray.RecipeDataTable>.get_Item
	|-List<RecipeGroupBase>.get_Item
	|-List<ReviatanIcePillar>.get_Item
	|-List<InteractionTrigger>.get_Item
	|-List<Settings.KeyboardShortcut>.get_Item
	|-List<OptionsControlBase>.get_Item
	|-List<Style>.get_Item
	|-List<RF5ThumbnailData>.get_Item
	|-List<SceneSplit>.get_Item
	|-List<SceneTransitionManager.SceneGameObjectEnabled>.get_Item
	|-List<ScriptNames>.get_Item
	|-List<SearchCharacterController.SearchParameter>.get_Item
	|-List<SeriousEventScriptsData>.get_Item
	|-List<SimpleAnimationPlayable.StateInfo>.get_Item
	|-List<SnowballData>.get_Item
	|-List<SnowballObjectSpawnData>.get_Item
	|-List<SnowballObjectSpawnTerm>.get_Item
	|-List<CubicBezierCurve>.get_Item
	|-List<SplineNode>.get_Item
	|-List<TrackSegment>.get_Item
	|-List<StampData>.get_Item
	|-List<SubEventMasterDataBase>.get_Item
	|-List<Action>.get_Item
	|-List<byte[]>.get_Item
	|-List<Dictionary<int, Vector3>>.get_Item
	|-List<List<ActionBehaviorCommandInformation>>.get_Item
	|-List<List<CinemachineVirtualCameraBase>>.get_Item
	|-List<List<FarmCropData>>.get_Item
	|-List<List<Point2D>>.get_Item
	|-List<List<PolygonPoint>>.get_Item
	|-List<List<int>>.get_Item
	|-List<List<object>>.get_Item
	|-List<List<Renderer>>.get_Item
	|-List<List<Vector2>>.get_Item
	|-List<List<Vector3>>.get_Item
	|-List<Stack<int>>.get_Item
	|-List<Func<FocusInterface>>.get_Item
	|-List<int[]>.get_Item
	|-List<Instruction>.get_Item
	|-List<LocalVariables.VariableScope>.get_Item
	|-List<Assembly>.get_Item
	|-List<X509CertificateImpl>.get_Item
	|-List<RegexCharClass.SingleRange>.get_Item
	|-List<RegexNode>.get_Item
	|-List<StringBuilder>.get_Item
	|-List<Thread>.get_Item
	|-List<WeakReference>.get_Item
	|-List<SystemTextDisp>.get_Item
	|-List<KerningPair>.get_Item
	|-List<TMP_Character>.get_Item
	|-List<TMP_Dropdown.DropdownItem>.get_Item
	|-List<TMP_Dropdown.OptionData>.get_Item
	|-List<TMP_FontAsset>.get_Item
	|-List<TMP_Glyph>.get_Item
	|-List<TMP_GlyphPairAdjustmentRecord>.get_Item
	|-List<TMP_MaterialManager.FallbackMaterial>.get_Item
	|-List<TMP_MaterialManager.MaskingMaterial>.get_Item
	|-List<TMP_Sprite>.get_Item
	|-List<TMP_SpriteAsset>.get_Item
	|-List<TMP_SpriteCharacter>.get_Item
	|-List<TMP_SpriteGlyph>.get_Item
	|-List<TMP_Style>.get_Item
	|-List<TMP_Text>.get_Item
	|-List<UIButtonLinkerInScrollBox>.get_Item
	|-List<UIItemBoxWindowOpenButton>.get_Item
	|-List<UIItemSlot>.get_Item
	|-List<UIOrderBoardMenu.OrderList>.get_Item
	|-List<UIStrengtheningSlot>.get_Item
	|-List<MeshData>.get_Item
	|-List<MeshFaceConnectivity.TriangleData>.get_Item
	|-List<VertexData>.get_Item
	|-List<MeshUniqueVertices.SerializableBoneWeight>.get_Item
	|-List<Simplifier.Triangle>.get_Item
	|-List<Simplifier.Vertex>.get_Item
	|-List<UltimateRope.RopeNode>.get_Item
	|-List<NavMeshSurface>.get_Item
	|-List<AddressablesImpl.ResourceLocatorInfo>.get_Item
	|-List<Animator>.get_Item
	|-List<Camera>.get_Item
	|-List<Canvas>.get_Item
	|-List<CanvasGroup>.get_Item
	|-List<Collider>.get_Item
	|-List<Component>.get_Item
	|-List<BaseInputModule>.get_Item
	|-List<BaseRaycaster>.get_Item
	|-List<EventSystem>.get_Item
	|-List<EventTrigger.Entry>.get_Item
	|-List<IEventSystemHandler>.get_Item
	|-List<PointerInputModule.ButtonState>.get_Item
	|-List<BaseInvokableCall>.get_Item
	|-List<UnityEvent>.get_Item
	|-List<GUILayoutEntry>.get_Item
	|-List<GameObject>.get_Item
	|-List<ISubsystem>.get_Item
	|-List<Light>.get_Item
	|-List<Material>.get_Item
	|-List<Object>.get_Item
	|-List<ParticleSystem>.get_Item
	|-List<RectTransform>.get_Item
	|-List<IAsyncOperation>.get_Item
	|-List<ScriptableObject>.get_Item
	|-List<SkinnedMeshRenderer>.get_Item
	|-List<Sprite>.get_Item
	|-List<Terrain>.get_Item
	|-List<Glyph>.get_Item
	|-List<Texture2D>.get_Item
	|-List<AnimationTrack>.get_Item
	|-List<IMarker>.get_Item
	|-List<ITimelineEvaluateCallback>.get_Item
	|-List<RuntimeElement>.get_Item
	|-List<SignalAsset>.get_Item
	|-List<TimelineClip>.get_Item
	|-List<TrackAsset>.get_Item
	|-List<Transform>.get_Item
	|-List<Dropdown.DropdownItem>.get_Item
	|-List<Dropdown.OptionData>.get_Item
	|-List<Graphic>.get_Item
	|-List<ICanvasElement>.get_Item
	|-List<IMaterialModifier>.get_Item
	|-List<Image>.get_Item
	|-List<Mask>.get_Item
	|-List<RectMask2D>.get_Item
	|-List<StencilMaterial.MatEntry>.get_Item
	|-List<Toggle>.get_Item
	|-List<EventCallbackFunctorBase>.get_Item
	|-List<VisualElement>.get_Item
	|-List<VoiceComment.CharaSprite>.get_Item
	|-List<VoiceCommentData>.get_Item
	|-List<WantedField.Points>.get_Item
	|-List<SplineControlPoint>.get_Item
	|-List<XWeaponTrail.Element>.get_Item
	|-List<AggregateException>.get_Item
	|-List<Directory.SearchData>.get_Item
	|-List<LocalDataStore>.get_Item
	|-List<object>.get_Item
	|-List<ExceptionDispatchInfo>.get_Item
	|-List<IContextProperty>.get_Item
	|-List<string>.get_Item
	|-List<Timer>.get_Item
	|-List<Type>.get_Item
	|-List<TypeSpec>.get_Item
	|
	|-RVA: 0x248CA20 Offset: 0x248CB21 VA: 0x248CA20
	|-List<AS_ToolController.ChargeInfo>.get_Item
	|
	|-RVA: 0x336D4B0 Offset: 0x336D5B1 VA: 0x336D4B0
	|-List<BeanID>.get_Item
	|-List<TaskStatus>.get_Item
	|-List<CraftCategoryId>.get_Item
	|-List<ActorID>.get_Item
	|-List<Alliance>.get_Item
	|-List<BadStatus>.get_Item
	|-List<BulletID>.get_Item
	|-List<CharID>.get_Item
	|-List<ClothShopID>.get_Item
	|-List<EffectID>.get_Item
	|-List<FarmFieldWorkArea>.get_Item
	|-List<GameFlagData>.get_Item
	|-List<HairType>.get_Item
	|-List<HotSpringID>.get_Item
	|-List<NPCID>.get_Item
	|-List<PoliceBatchId>.get_Item
	|-List<RecipePanShopID>.get_Item
	|-List<StorageType>.get_Item
	|-List<VaccinationID>.get_Item
	|-List<VariationNo>.get_Item
	|-List<ItemID>.get_Item
	|-List<MonsterActionBehaviorType>.get_Item
	|-List<MonsterDataID>.get_Item
	|-List<NpcSearchCollider.VoiceType>.get_Item
	|-List<PartnerNPCActionBehaviorType>.get_Item
	|-List<RecipeId>.get_Item
	|-List<SoundID>.get_Item
	|-List<RegexOptions>.get_Item
	|-List<UINamingWindow.NamingId>.get_Item
	|-List<Int32Enum>.get_Item
	|
	|-RVA: 0x248FDF0 Offset: 0x248FEF1 VA: 0x248FDF0
	|-List<BuildItemData>.get_Item
	|
	|-RVA: 0x31560A0 Offset: 0x31561A1 VA: 0x31560A0
	|-List<ButtonLinker.LinkObject>.get_Item
	|
	|-RVA: 0x315F1C0 Offset: 0x315F2C1 VA: 0x315F1C0
	|-List<CameraState.CustomBlendable>.get_Item
	|
	|-RVA: 0x31651B0 Offset: 0x31652B1 VA: 0x31651B0
	|-List<CinemachineStateDrivenCamera.HashPair>.get_Item
	|
	|-RVA: 0x3168180 Offset: 0x3168281 VA: 0x3168180
	|-List<TargetPositionCache.CacheCurve.Item>.get_Item
	|
	|-RVA: 0x316B660 Offset: 0x316B761 VA: 0x316B660
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.get_Item
	|
	|-RVA: 0x316EBD0 Offset: 0x316ECD1 VA: 0x316EBD0
	|-List<CropDataTable>.get_Item
	|
	|-RVA: 0x3172170 Offset: 0x3172271 VA: 0x3172170
	|-List<DropItemParam>.get_Item
	|
	|-RVA: 0x31DF150 Offset: 0x31DF251 VA: 0x31DF150
	|-List<EventFlagProgressData>.get_Item
	|
	|-RVA: 0x31E5210 Offset: 0x31E5311 VA: 0x31E5210
	|-List<MiningPointSaveData>.get_Item
	|
	|-RVA: 0x31E8770 Offset: 0x31E8871 VA: 0x31E8770
	|-List<MonsterHutSaveData>.get_Item
	|
	|-RVA: 0x31EBC70 Offset: 0x31EBD71 VA: 0x31EBC70
	|-List<MoviePlayer.SUBTITLEDATA>.get_Item
	|
	|-RVA: 0x31EECF0 Offset: 0x31EEDF1 VA: 0x31EECF0
	|-List<NPCActionData>.get_Item
	|
	|-RVA: 0x330AE00 Offset: 0x330AF01 VA: 0x330AE00
	|-List<ShopCatalogPage>.get_Item
	|
	|-RVA: 0x330DE60 Offset: 0x330DF61 VA: 0x330DE60
	|-List<ShopNpcTalk>.get_Item
	|
	|-RVA: 0x3311400 Offset: 0x3311501 VA: 0x3311400
	|-List<SubtitleDataTable.Data>.get_Item
	|
	|-RVA: 0x33144C0 Offset: 0x33145C1 VA: 0x33144C0
	|-List<SubtitleDataTable.DataList>.get_Item
	|
	|-RVA: 0x3317490 Offset: 0x3317591 VA: 0x3317490
	|-List<SubtitleHudDataTable.Data>.get_Item
	|
	|-RVA: 0x3320C80 Offset: 0x3320D81 VA: 0x3320C80
	|-List<CurveSample>.get_Item
	|
	|-RVA: 0x3324500 Offset: 0x3324601 VA: 0x3324500
	|-List<bool>.get_Item
	|
	|-RVA: 0x33274F0 Offset: 0x33275F1 VA: 0x33274F0
	|-List<byte>.get_Item
	|
	|-RVA: 0x332A4C0 Offset: 0x332A5C1 VA: 0x332A4C0
	|-List<char>.get_Item
	|
	|-RVA: 0x336A500 Offset: 0x336A601 VA: 0x336A500
	|-List<int>.get_Item
	|
	|-RVA: 0x32813F0 Offset: 0x32814F1 VA: 0x32813F0
	|-List<float>.get_Item
	|
	|-RVA: 0x32AB610 Offset: 0x32AB711 VA: 0x32AB610
	|-List<uint>.get_Item
	|
	|-RVA: 0x32AE5C0 Offset: 0x32AE6C1 VA: 0x32AE5C0
	|-List<ulong>.get_Item
	|
	|-RVA: 0x32B1570 Offset: 0x32B1671 VA: 0x32B1570
	|-List<ValueTuple<bool, ItemID>>.get_Item
	|-List<ValueTuple<bool, Int32Enum>>.get_Item
	|
	|-RVA: 0x32C35E0 Offset: 0x32C36E1 VA: 0x32C35E0
	|-List<ValueTuple<CharID, VariationNo, HairType>>.get_Item
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.get_Item
	|
	|-RVA: 0x3116AB0 Offset: 0x3116BB1 VA: 0x3116AB0
	|-List<UIMainManagerAttachObject.AttachSet>.get_Item
	|
	|-RVA: 0x3119B20 Offset: 0x3119C21 VA: 0x3119B20
	|-List<CapEdge>.get_Item
	|
	|-RVA: 0x3123380 Offset: 0x3123481 VA: 0x3123380
	|-List<MeshFaceConnectivity.EdgeData>.get_Item
	|
	|-RVA: 0x3130540 Offset: 0x3130641 VA: 0x3130540
	|-List<AnimatorClipInfo>.get_Item
	|
	|-RVA: 0x321C0D0 Offset: 0x321C1D1 VA: 0x321C0D0
	|-List<BeforeRenderHelper.OrderBlock>.get_Item
	|
	|-RVA: 0x3228B20 Offset: 0x3228C21 VA: 0x3228B20
	|-List<Color32>.get_Item
	|
	|-RVA: 0x322BAE0 Offset: 0x322BBE1 VA: 0x322BAE0
	|-List<Color>.get_Item
	|
	|-RVA: 0x3232790 Offset: 0x3232891 VA: 0x3232790
	|-List<RaycastResult>.get_Item
	|
	|-RVA: 0x32493E0 Offset: 0x32494E1 VA: 0x32493E0
	|-List<Playable>.get_Item
	|
	|-RVA: 0x33D0A00 Offset: 0x33D0B01 VA: 0x33D0A00
	|-List<AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x33DA700 Offset: 0x33DA801 VA: 0x33DA700
	|-List<DelayedActionManager.DelegateInfo>.get_Item
	|
	|-RVA: 0x31B8FA0 Offset: 0x31B90A1 VA: 0x31B8FA0
	|-List<GlyphRect>.get_Item
	|
	|-RVA: 0x31BBFD0 Offset: 0x31BC0D1 VA: 0x31BBFD0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.get_Item
	|
	|-RVA: 0x31C5BA0 Offset: 0x31C5CA1 VA: 0x31C5BA0
	|-List<TimeNotificationBehaviour.NotificationEntry>.get_Item
	|
	|-RVA: 0x31CBFA0 Offset: 0x31CC0A1 VA: 0x31CBFA0
	|-List<FocusController.FocusedElement>.get_Item
	|
	|-RVA: 0x31D2030 Offset: 0x31D2131 VA: 0x31D2030
	|-List<UIVertex>.get_Item
	|
	|-RVA: 0x31D5A10 Offset: 0x31D5B11 VA: 0x31D5A10
	|-List<UnitySynchronizationContext.WorkRequest>.get_Item
	|
	|-RVA: 0x31D8D80 Offset: 0x31D8E81 VA: 0x31D8D80
	|-List<Vector2>.get_Item
	|
	|-RVA: 0x2CE4960 Offset: 0x2CE4A61 VA: 0x2CE4960
	|-List<Vector3>.get_Item
	|
	|-RVA: 0x2CEAAA0 Offset: 0x2CEABA1 VA: 0x2CEAAA0
	|-List<Vector4>.get_Item
	|
	|-RVA: 0x2CEDB80 Offset: 0x2CEDC81 VA: 0x2CEDB80
	|-List<WarpPoints.WarpPoint>.get_Item
	|
	|-RVA: 0x2CF4810 Offset: 0x2CF4911 VA: 0x2CF4810
	|-List<stCommand_t>.get_Item
	|
	|-RVA: 0x31590F0 Offset: 0x31591F1 VA: 0x31590F0
	|-List<CharaCallTable.BustupTable>.get_Item
	|
	|-RVA: 0x315C100 Offset: 0x315C201 VA: 0x315C100
	|-List<CharaCallTable.CharaFaceIconTable>.get_Item
	|
	|-RVA: 0x3162200 Offset: 0x3162301 VA: 0x3162200
	|-List<CinemachineClearShot.Pair>.get_Item
	|
	|-RVA: 0x3175140 Offset: 0x3175241 VA: 0x3175140
	|-List<ErosionBrush.UndoStep>.get_Item
	|
	|-RVA: 0x31DBDD0 Offset: 0x31DBED1 VA: 0x31DBDD0
	|-List<EventCheckId>.get_Item
	|
	|-RVA: 0x31E21A0 Offset: 0x31E22A1 VA: 0x31E21A0
	|-List<FesNpcScoreData>.get_Item
	|
	|-RVA: 0x31F23A0 Offset: 0x31F24A1 VA: 0x31F23A0
	|-List<NpcPlaceSchedule>.get_Item
	|
	|-RVA: 0x31F5720 Offset: 0x31F5821 VA: 0x31F5720
	|-List<OrderLotterySaveParameter>.get_Item
	|
	|-RVA: 0x31F8800 Offset: 0x31F8901 VA: 0x31F8800
	|-List<OrderSaveParameter>.get_Item
	|
	|-RVA: 0x31FBB90 Offset: 0x31FBC91 VA: 0x31FBB90
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Item
	|
	|-RVA: 0x331A570 Offset: 0x331A671 VA: 0x331A570
	|-List<SRMonoBehaviourEx.FieldInfo>.get_Item
	|
	|-RVA: 0x331D920 Offset: 0x331DA21 VA: 0x331D920
	|-List<Schedule>.get_Item
	|
	|-RVA: 0x3358510 Offset: 0x3358611 VA: 0x3358510
	|-List<KeyValuePair<DateTime, object>>.get_Item
	|-List<KeyValuePair<DateTime, TimeType>>.get_Item
	|
	|-RVA: 0x335B560 Offset: 0x335B661 VA: 0x335B560
	|-List<KeyValuePair<int, object>>.get_Item
	|
	|-RVA: 0x335E5B0 Offset: 0x335E6B1 VA: 0x335E5B0
	|-List<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x33615F0 Offset: 0x33616F1 VA: 0x33615F0
	|-List<DateTime>.get_Item
	|
	|-RVA: 0x3364590 Offset: 0x3364691 VA: 0x3364590
	|-List<double>.get_Item
	|
	|-RVA: 0x3367550 Offset: 0x3367651 VA: 0x3367550
	|-List<short>.get_Item
	|
	|-RVA: 0x3370460 Offset: 0x3370561 VA: 0x3370460
	|-List<long>.get_Item
	|
	|-RVA: 0x3373410 Offset: 0x3373511 VA: 0x3373410
	|-List<InterpretedFrameInfo>.get_Item
	|
	|-RVA: 0x3376450 Offset: 0x3376551 VA: 0x3376450
	|-List<Nullable<Int32Enum>>.get_Item
	|
	|-RVA: 0x3405100 Offset: 0x3405201 VA: 0x3405100
	|-List<Nullable<Bounds>>.get_Item
	|
	|-RVA: 0x34086C0 Offset: 0x34087C1 VA: 0x34086C0
	|-List<Nullable<BoundsInt>>.get_Item
	|
	|-RVA: 0x340BC60 Offset: 0x340BD61 VA: 0x340BC60
	|-List<Nullable<Color32>>.get_Item
	|
	|-RVA: 0x340EC80 Offset: 0x340ED81 VA: 0x340EC80
	|-List<Nullable<Color>>.get_Item
	|
	|-RVA: 0x34120C0 Offset: 0x34121C1 VA: 0x34120C0
	|-List<Nullable<GradientAlphaKey>>.get_Item
	|
	|-RVA: 0x3415200 Offset: 0x3415301 VA: 0x3415200
	|-List<Nullable<GradientColorKey>>.get_Item
	|
	|-RVA: 0x3418650 Offset: 0x3418751 VA: 0x3418650
	|-List<Nullable<Keyframe>>.get_Item
	|
	|-RVA: 0x341BA90 Offset: 0x341BB91 VA: 0x341BA90
	|-List<Nullable<LayerMask>>.get_Item
	|
	|-RVA: 0x341EAC0 Offset: 0x341EBC1 VA: 0x341EAC0
	|-List<Nullable<Matrix4x4>>.get_Item
	|
	|-RVA: 0x34224F0 Offset: 0x34225F1 VA: 0x34224F0
	|-List<Nullable<Quaternion>>.get_Item
	|
	|-RVA: 0x32623A0 Offset: 0x32624A1 VA: 0x32623A0
	|-List<Nullable<RangeInt>>.get_Item
	|
	|-RVA: 0x32654E0 Offset: 0x32655E1 VA: 0x32654E0
	|-List<Nullable<Rect>>.get_Item
	|
	|-RVA: 0x3268940 Offset: 0x3268A41 VA: 0x3268940
	|-List<Nullable<RectInt>>.get_Item
	|
	|-RVA: 0x326BD80 Offset: 0x326BE81 VA: 0x326BD80
	|-List<Nullable<Vector2>>.get_Item
	|
	|-RVA: 0x326EEA0 Offset: 0x326EFA1 VA: 0x326EEA0
	|-List<Nullable<Vector2Int>>.get_Item
	|
	|-RVA: 0x3271FC0 Offset: 0x32720C1 VA: 0x3271FC0
	|-List<Nullable<Vector3>>.get_Item
	|
	|-RVA: 0x3275030 Offset: 0x3275131 VA: 0x3275030
	|-List<Nullable<Vector3Int>>.get_Item
	|
	|-RVA: 0x32780C0 Offset: 0x32781C1 VA: 0x32780C0
	|-List<Nullable<Vector4>>.get_Item
	|
	|-RVA: 0x327E430 Offset: 0x327E531 VA: 0x327E430
	|-List<sbyte>.get_Item
	|
	|-RVA: 0x32A8660 Offset: 0x32A8761 VA: 0x32A8660
	|-List<ushort>.get_Item
	|
	|-RVA: 0x32B4520 Offset: 0x32B4621 VA: 0x32B4520
	|-List<ValueTuple<Int32Enum, int>>.get_Item
	|
	|-RVA: 0x32B74D0 Offset: 0x32B75D1 VA: 0x32B74D0
	|-List<ValueTuple<Int32Enum, object>>.get_Item
	|
	|-RVA: 0x32BA520 Offset: 0x32BA621 VA: 0x32BA520
	|-List<ValueTuple<object, Int32Enum>>.get_Item
	|
	|-RVA: 0x32BD560 Offset: 0x32BD661 VA: 0x32BD560
	|-List<ValueTuple<object, object>>.get_Item
	|
	|-RVA: 0x32C05A0 Offset: 0x32C06A1 VA: 0x32C05A0
	|-List<ValueTuple<object, float>>.get_Item
	|
	|-RVA: 0x32C66D0 Offset: 0x32C67D1 VA: 0x32C66D0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.get_Item
	|
	|-RVA: 0x3110330 Offset: 0x3110431 VA: 0x3110330
	|-List<TexturePacker_JsonArray.Frame>.get_Item
	|
	|-RVA: 0x31139F0 Offset: 0x3113AF1 VA: 0x31139F0
	|-List<TutorialUnlockFlagData>.get_Item
	|
	|-RVA: 0x311D060 Offset: 0x311D161 VA: 0x311D060
	|-List<MeshDataConnectivity.Face>.get_Item
	|
	|-RVA: 0x3120030 Offset: 0x3120131 VA: 0x3120030
	|-List<MeshFaceConnectivity.EdgeData.SideData>.get_Item
	|
	|-RVA: 0x3126920 Offset: 0x3126A21 VA: 0x3126920
	|-List<NavMeshBuildMarkup>.get_Item
	|
	|-RVA: 0x3129970 Offset: 0x3129A71 VA: 0x3129970
	|-List<NavMeshBuildSource>.get_Item
	|
	|-RVA: 0x312D500 Offset: 0x312D601 VA: 0x312D500
	|-List<ConstraintSource>.get_Item
	|
	|-RVA: 0x321F140 Offset: 0x321F241 VA: 0x321F140
	|-List<BoneWeight>.get_Item
	|
	|-RVA: 0x32224A0 Offset: 0x32225A1 VA: 0x32224A0
	|-List<Bounds>.get_Item
	|
	|-RVA: 0x32257F0 Offset: 0x32258F1 VA: 0x32257F0
	|-List<BoundsInt>.get_Item
	|
	|-RVA: 0x322EBB0 Offset: 0x322ECB1 VA: 0x322EBB0
	|-List<CombineInstance>.get_Item
	|
	|-RVA: 0x3236030 Offset: 0x3236131 VA: 0x3236030
	|-List<GradientAlphaKey>.get_Item
	|
	|-RVA: 0x3239080 Offset: 0x3239181 VA: 0x3239080
	|-List<GradientColorKey>.get_Item
	|
	|-RVA: 0x323C3E0 Offset: 0x323C4E1 VA: 0x323C3E0
	|-List<Keyframe>.get_Item
	|
	|-RVA: 0x323F8A0 Offset: 0x323F9A1 VA: 0x323F8A0
	|-List<LayerMask>.get_Item
	|
	|-RVA: 0x32428A0 Offset: 0x32429A1 VA: 0x32428A0
	|-List<Matrix4x4>.get_Item
	|
	|-RVA: 0x3245F50 Offset: 0x3246051 VA: 0x3245F50
	|-List<ParticleSystem.Particle>.get_Item
	|
	|-RVA: 0x324C410 Offset: 0x324C511 VA: 0x324C410
	|-List<PlayableBinding>.get_Item
	|
	|-RVA: 0x324F7A0 Offset: 0x324F8A1 VA: 0x324F7A0
	|-List<PlayableGraph>.get_Item
	|
	|-RVA: 0x32527B0 Offset: 0x32528B1 VA: 0x32527B0
	|-List<Edge>.get_Item
	|
	|-RVA: 0x3255750 Offset: 0x3255851 VA: 0x3255750
	|-List<Quaternion>.get_Item
	|
	|-RVA: 0x32587E0 Offset: 0x32588E1 VA: 0x32587E0
	|-List<RangeInt>.get_Item
	|
	|-RVA: 0x325B7B0 Offset: 0x325B8B1 VA: 0x325B7B0
	|-List<RaycastHit2D>.get_Item
	|
	|-RVA: 0x325ED20 Offset: 0x325EE21 VA: 0x325ED20
	|-List<RaycastHit>.get_Item
	|
	|-RVA: 0x33C0B90 Offset: 0x33C0C91 VA: 0x33C0B90
	|-List<Rect>.get_Item
	|
	|-RVA: 0x33C3C20 Offset: 0x33C3D21 VA: 0x33C3C20
	|-List<RectInt>.get_Item
	|
	|-RVA: 0x33C6C30 Offset: 0x33C6D31 VA: 0x33C6C30
	|-List<ReflectionProbeBlendInfo>.get_Item
	|
	|-RVA: 0x33C9CC0 Offset: 0x33C9DC1 VA: 0x33C9CC0
	|-List<SphericalHarmonicsL2>.get_Item
	|
	|-RVA: 0x33CD9D0 Offset: 0x33CDAD1 VA: 0x33CD9D0
	|-List<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0x33D3DA0 Offset: 0x33D3EA1 VA: 0x33D3DA0
	|-List<AsyncOperationHandle<SceneInstance>>.get_Item
	|
	|-RVA: 0x33D7140 Offset: 0x33D7241 VA: 0x33D7140
	|-List<DiagnosticEvent>.get_Item
	|
	|-RVA: 0x33DDAB0 Offset: 0x33DDBB1 VA: 0x33DDAB0
	|-List<ObjectInitializationData>.get_Item
	|
	|-RVA: 0x31BF4B0 Offset: 0x31BF5B1 VA: 0x31BF4B0
	|-List<IntervalTreeNode>.get_Item
	|
	|-RVA: 0x31C2800 Offset: 0x31C2901 VA: 0x31C2800
	|-List<IntervalTree.Entry<object>>.get_Item
	|
	|-RVA: 0x31C8F10 Offset: 0x31C9011 VA: 0x31C8F10
	|-List<UICharInfo>.get_Item
	|
	|-RVA: 0x31CEFE0 Offset: 0x31CF0E1 VA: 0x31CEFE0
	|-List<UILineInfo>.get_Item
	|
	|-RVA: 0x2CE19C0 Offset: 0x2CE1AC1 VA: 0x2CE19C0
	|-List<Vector2Int>.get_Item
	|
	|-RVA: 0x2CE79F0 Offset: 0x2CE7AF1 VA: 0x2CE79F0
	|-List<Vector3Int>.get_Item
	|
	|-RVA: 0x2CF1840 Offset: 0x2CF1941 VA: 0x2CF1840
	|-List<YieldItemParam>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CA80 Offset: 0x248CB81 VA: 0x248CA80
	|-List<AS_ToolController.ChargeInfo>.set_Item
	|
	|-RVA: 0x327B540 Offset: 0x327B641 VA: 0x327B540
	|-List<Task>.set_Item
	|-List<ABSSequentiable>.set_Item
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>.set_Item
	|-List<FarmCropData>.set_Item
	|-List<FarmSupportMonsterData>.set_Item
	|-List<FishRecord>.set_Item
	|-List<FishSwim>.set_Item
	|-List<HUDMinimapControl.RectImage>.set_Item
	|-List<FurnitureSaveData>.set_Item
	|-List<KyubiController.FireballParameter>.set_Item
	|-List<OrderPopControl.StockDoOrder>.set_Item
	|-List<Contour>.set_Item
	|-List<Point2D>.set_Item
	|-List<QuestIconData>.set_Item
	|-List<UIEMCustomizeSet>.set_Item
	|-List<SimpleAnimationPlayable.StateInfo>.set_Item
	|-List<Instruction>.set_Item
	|-List<object>.set_Item
	|-List<string>.set_Item
	|-List<RegexCharClass.SingleRange>.set_Item
	|-List<RegexNode>.set_Item
	|-List<Simplifier.Vertex>.set_Item
	|-List<UltimateRope.RopeNode>.set_Item
	|-List<UnityEvent>.set_Item
	|-List<GameObject>.set_Item
	|-List<ScriptableObject>.set_Item
	|-List<Sprite>.set_Item
	|-List<SignalAsset>.set_Item
	|-List<Transform>.set_Item
	|
	|-RVA: 0x336D4F0 Offset: 0x336D5F1 VA: 0x336D4F0
	|-List<TaskStatus>.set_Item
	|-List<ActorID>.set_Item
	|-List<Int32Enum>.set_Item
	|
	|-RVA: 0x248FE80 Offset: 0x248FF81 VA: 0x248FE80
	|-List<BuildItemData>.set_Item
	|
	|-RVA: 0x31560E0 Offset: 0x31561E1 VA: 0x31560E0
	|-List<ButtonLinker.LinkObject>.set_Item
	|
	|-RVA: 0x3159130 Offset: 0x3159231 VA: 0x3159130
	|-List<CharaCallTable.BustupTable>.set_Item
	|
	|-RVA: 0x315C150 Offset: 0x315C251 VA: 0x315C150
	|-List<CharaCallTable.CharaFaceIconTable>.set_Item
	|
	|-RVA: 0x315F200 Offset: 0x315F301 VA: 0x315F200
	|-List<CameraState.CustomBlendable>.set_Item
	|
	|-RVA: 0x3162240 Offset: 0x3162341 VA: 0x3162240
	|-List<CinemachineClearShot.Pair>.set_Item
	|
	|-RVA: 0x31651F0 Offset: 0x31652F1 VA: 0x31651F0
	|-List<CinemachineStateDrivenCamera.HashPair>.set_Item
	|
	|-RVA: 0x31681F0 Offset: 0x31682F1 VA: 0x31681F0
	|-List<TargetPositionCache.CacheCurve.Item>.set_Item
	|
	|-RVA: 0x316B6D0 Offset: 0x316B7D1 VA: 0x316B6D0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.set_Item
	|
	|-RVA: 0x316EC30 Offset: 0x316ED31 VA: 0x316EC30
	|-List<CropDataTable>.set_Item
	|
	|-RVA: 0x31721B0 Offset: 0x31722B1 VA: 0x31721B0
	|-List<DropItemParam>.set_Item
	|
	|-RVA: 0x31751A0 Offset: 0x31752A1 VA: 0x31751A0
	|-List<ErosionBrush.UndoStep>.set_Item
	|
	|-RVA: 0x31DBE30 Offset: 0x31DBF31 VA: 0x31DBE30
	|-List<EventCheckId>.set_Item
	|
	|-RVA: 0x31DF190 Offset: 0x31DF291 VA: 0x31DF190
	|-List<EventFlagProgressData>.set_Item
	|
	|-RVA: 0x31E21E0 Offset: 0x31E22E1 VA: 0x31E21E0
	|-List<FesNpcScoreData>.set_Item
	|
	|-RVA: 0x31E5280 Offset: 0x31E5381 VA: 0x31E5280
	|-List<MiningPointSaveData>.set_Item
	|
	|-RVA: 0x31E87E0 Offset: 0x31E88E1 VA: 0x31E87E0
	|-List<MonsterHutSaveData>.set_Item
	|
	|-RVA: 0x31EBCB0 Offset: 0x31EBDB1 VA: 0x31EBCB0
	|-List<MoviePlayer.SUBTITLEDATA>.set_Item
	|
	|-RVA: 0x31EED60 Offset: 0x31EEE61 VA: 0x31EED60
	|-List<NPCActionData>.set_Item
	|
	|-RVA: 0x31F2400 Offset: 0x31F2501 VA: 0x31F2400
	|-List<NpcPlaceSchedule>.set_Item
	|
	|-RVA: 0x31F5770 Offset: 0x31F5871 VA: 0x31F5770
	|-List<OrderLotterySaveParameter>.set_Item
	|
	|-RVA: 0x31F8860 Offset: 0x31F8961 VA: 0x31F8860
	|-List<OrderSaveParameter>.set_Item
	|
	|-RVA: 0x31FBBD0 Offset: 0x31FBCD1 VA: 0x31FBBD0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.set_Item
	|
	|-RVA: 0x330AE40 Offset: 0x330AF41 VA: 0x330AE40
	|-List<ShopCatalogPage>.set_Item
	|
	|-RVA: 0x330DED0 Offset: 0x330DFD1 VA: 0x330DED0
	|-List<ShopNpcTalk>.set_Item
	|
	|-RVA: 0x3311450 Offset: 0x3311551 VA: 0x3311450
	|-List<SubtitleDataTable.Data>.set_Item
	|
	|-RVA: 0x3314500 Offset: 0x3314601 VA: 0x3314500
	|-List<SubtitleDataTable.DataList>.set_Item
	|
	|-RVA: 0x33174E0 Offset: 0x33175E1 VA: 0x33174E0
	|-List<SubtitleHudDataTable.Data>.set_Item
	|
	|-RVA: 0x331A5D0 Offset: 0x331A6D1 VA: 0x331A5D0
	|-List<SRMonoBehaviourEx.FieldInfo>.set_Item
	|
	|-RVA: 0x331D980 Offset: 0x331DA81 VA: 0x331D980
	|-List<Schedule>.set_Item
	|
	|-RVA: 0x3320D00 Offset: 0x3320E01 VA: 0x3320D00
	|-List<CurveSample>.set_Item
	|
	|-RVA: 0x3324540 Offset: 0x3324641 VA: 0x3324540
	|-List<bool>.set_Item
	|
	|-RVA: 0x3327530 Offset: 0x3327631 VA: 0x3327530
	|-List<byte>.set_Item
	|
	|-RVA: 0x332A500 Offset: 0x332A601 VA: 0x332A500
	|-List<char>.set_Item
	|
	|-RVA: 0x3358550 Offset: 0x3358651 VA: 0x3358550
	|-List<KeyValuePair<DateTime, object>>.set_Item
	|
	|-RVA: 0x335B5A0 Offset: 0x335B6A1 VA: 0x335B5A0
	|-List<KeyValuePair<int, object>>.set_Item
	|
	|-RVA: 0x335E5F0 Offset: 0x335E6F1 VA: 0x335E5F0
	|-List<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x3361630 Offset: 0x3361731 VA: 0x3361630
	|-List<DateTime>.set_Item
	|
	|-RVA: 0x33645D0 Offset: 0x33646D1 VA: 0x33645D0
	|-List<double>.set_Item
	|
	|-RVA: 0x3367590 Offset: 0x3367691 VA: 0x3367590
	|-List<short>.set_Item
	|
	|-RVA: 0x336A540 Offset: 0x336A641 VA: 0x336A540
	|-List<int>.set_Item
	|
	|-RVA: 0x33704A0 Offset: 0x33705A1 VA: 0x33704A0
	|-List<long>.set_Item
	|
	|-RVA: 0x3373450 Offset: 0x3373551 VA: 0x3373450
	|-List<InterpretedFrameInfo>.set_Item
	|
	|-RVA: 0x3376490 Offset: 0x3376591 VA: 0x3376490
	|-List<Nullable<Int32Enum>>.set_Item
	|
	|-RVA: 0x3405170 Offset: 0x3405271 VA: 0x3405170
	|-List<Nullable<Bounds>>.set_Item
	|
	|-RVA: 0x3408730 Offset: 0x3408831 VA: 0x3408730
	|-List<Nullable<BoundsInt>>.set_Item
	|
	|-RVA: 0x340BCA0 Offset: 0x340BDA1 VA: 0x340BCA0
	|-List<Nullable<Color32>>.set_Item
	|
	|-RVA: 0x340ECE0 Offset: 0x340EDE1 VA: 0x340ECE0
	|-List<Nullable<Color>>.set_Item
	|
	|-RVA: 0x3412110 Offset: 0x3412211 VA: 0x3412110
	|-List<Nullable<GradientAlphaKey>>.set_Item
	|
	|-RVA: 0x3415260 Offset: 0x3415361 VA: 0x3415260
	|-List<Nullable<GradientColorKey>>.set_Item
	|
	|-RVA: 0x34186B0 Offset: 0x34187B1 VA: 0x34186B0
	|-List<Nullable<Keyframe>>.set_Item
	|
	|-RVA: 0x341BAD0 Offset: 0x341BBD1 VA: 0x341BAD0
	|-List<Nullable<LayerMask>>.set_Item
	|
	|-RVA: 0x341EB40 Offset: 0x341EC41 VA: 0x341EB40
	|-List<Nullable<Matrix4x4>>.set_Item
	|
	|-RVA: 0x3422550 Offset: 0x3422651 VA: 0x3422550
	|-List<Nullable<Quaternion>>.set_Item
	|
	|-RVA: 0x32623F0 Offset: 0x32624F1 VA: 0x32623F0
	|-List<Nullable<RangeInt>>.set_Item
	|
	|-RVA: 0x3265540 Offset: 0x3265641 VA: 0x3265540
	|-List<Nullable<Rect>>.set_Item
	|
	|-RVA: 0x32689A0 Offset: 0x3268AA1 VA: 0x32689A0
	|-List<Nullable<RectInt>>.set_Item
	|
	|-RVA: 0x326BDD0 Offset: 0x326BED1 VA: 0x326BDD0
	|-List<Nullable<Vector2>>.set_Item
	|
	|-RVA: 0x326EEF0 Offset: 0x326EFF1 VA: 0x326EEF0
	|-List<Nullable<Vector2Int>>.set_Item
	|
	|-RVA: 0x3272000 Offset: 0x3272101 VA: 0x3272000
	|-List<Nullable<Vector3>>.set_Item
	|
	|-RVA: 0x3275070 Offset: 0x3275171 VA: 0x3275070
	|-List<Nullable<Vector3Int>>.set_Item
	|
	|-RVA: 0x3278120 Offset: 0x3278221 VA: 0x3278120
	|-List<Nullable<Vector4>>.set_Item
	|
	|-RVA: 0x327E470 Offset: 0x327E571 VA: 0x327E470
	|-List<sbyte>.set_Item
	|
	|-RVA: 0x3281430 Offset: 0x3281531 VA: 0x3281430
	|-List<float>.set_Item
	|
	|-RVA: 0x32A86A0 Offset: 0x32A87A1 VA: 0x32A86A0
	|-List<ushort>.set_Item
	|
	|-RVA: 0x32AB650 Offset: 0x32AB751 VA: 0x32AB650
	|-List<uint>.set_Item
	|
	|-RVA: 0x32AE600 Offset: 0x32AE701 VA: 0x32AE600
	|-List<ulong>.set_Item
	|
	|-RVA: 0x32B15B0 Offset: 0x32B16B1 VA: 0x32B15B0
	|-List<ValueTuple<bool, Int32Enum>>.set_Item
	|
	|-RVA: 0x32B4560 Offset: 0x32B4661 VA: 0x32B4560
	|-List<ValueTuple<Int32Enum, int>>.set_Item
	|
	|-RVA: 0x32B7510 Offset: 0x32B7611 VA: 0x32B7510
	|-List<ValueTuple<Int32Enum, object>>.set_Item
	|
	|-RVA: 0x32BA560 Offset: 0x32BA661 VA: 0x32BA560
	|-List<ValueTuple<object, Int32Enum>>.set_Item
	|
	|-RVA: 0x32BD5A0 Offset: 0x32BD6A1 VA: 0x32BD5A0
	|-List<ValueTuple<object, object>>.set_Item
	|
	|-RVA: 0x32C05E0 Offset: 0x32C06E1 VA: 0x32C05E0
	|-List<ValueTuple<object, float>>.set_Item
	|
	|-RVA: 0x32C3630 Offset: 0x32C3731 VA: 0x32C3630
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.set_Item
	|
	|-RVA: 0x32C6740 Offset: 0x32C6841 VA: 0x32C6740
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.set_Item
	|
	|-RVA: 0x31103A0 Offset: 0x31104A1 VA: 0x31103A0
	|-List<TexturePacker_JsonArray.Frame>.set_Item
	|
	|-RVA: 0x3113A40 Offset: 0x3113B41 VA: 0x3113A40
	|-List<TutorialUnlockFlagData>.set_Item
	|
	|-RVA: 0x3116AF0 Offset: 0x3116BF1 VA: 0x3116AF0
	|-List<UIMainManagerAttachObject.AttachSet>.set_Item
	|
	|-RVA: 0x3119B90 Offset: 0x3119C91 VA: 0x3119B90
	|-List<CapEdge>.set_Item
	|
	|-RVA: 0x311D0A0 Offset: 0x311D1A1 VA: 0x311D0A0
	|-List<MeshDataConnectivity.Face>.set_Item
	|
	|-RVA: 0x3120090 Offset: 0x3120191 VA: 0x3120090
	|-List<MeshFaceConnectivity.EdgeData.SideData>.set_Item
	|
	|-RVA: 0x31233F0 Offset: 0x31234F1 VA: 0x31233F0
	|-List<MeshFaceConnectivity.EdgeData>.set_Item
	|
	|-RVA: 0x3126960 Offset: 0x3126A61 VA: 0x3126960
	|-List<NavMeshBuildMarkup>.set_Item
	|
	|-RVA: 0x3129A00 Offset: 0x3129B01 VA: 0x3129A00
	|-List<NavMeshBuildSource>.set_Item
	|
	|-RVA: 0x312D540 Offset: 0x312D641 VA: 0x312D540
	|-List<ConstraintSource>.set_Item
	|
	|-RVA: 0x3130580 Offset: 0x3130681 VA: 0x3130580
	|-List<AnimatorClipInfo>.set_Item
	|
	|-RVA: 0x321C110 Offset: 0x321C211 VA: 0x321C110
	|-List<BeforeRenderHelper.OrderBlock>.set_Item
	|
	|-RVA: 0x321F1A0 Offset: 0x321F2A1 VA: 0x321F1A0
	|-List<BoneWeight>.set_Item
	|
	|-RVA: 0x3222500 Offset: 0x3222601 VA: 0x3222500
	|-List<Bounds>.set_Item
	|
	|-RVA: 0x3225850 Offset: 0x3225951 VA: 0x3225850
	|-List<BoundsInt>.set_Item
	|
	|-RVA: 0x3228B60 Offset: 0x3228C61 VA: 0x3228B60
	|-List<Color32>.set_Item
	|
	|-RVA: 0x322BB30 Offset: 0x322BC31 VA: 0x322BB30
	|-List<Color>.set_Item
	|
	|-RVA: 0x322EC40 Offset: 0x322ED41 VA: 0x322EC40
	|-List<CombineInstance>.set_Item
	|
	|-RVA: 0x3232810 Offset: 0x3232911 VA: 0x3232810
	|-List<RaycastResult>.set_Item
	|
	|-RVA: 0x3236070 Offset: 0x3236171 VA: 0x3236070
	|-List<GradientAlphaKey>.set_Item
	|
	|-RVA: 0x32390E0 Offset: 0x32391E1 VA: 0x32390E0
	|-List<GradientColorKey>.set_Item
	|
	|-RVA: 0x323C450 Offset: 0x323C551 VA: 0x323C450
	|-List<Keyframe>.set_Item
	|
	|-RVA: 0x323F8E0 Offset: 0x323F9E1 VA: 0x323F8E0
	|-List<LayerMask>.set_Item
	|
	|-RVA: 0x3242910 Offset: 0x3242A11 VA: 0x3242910
	|-List<Matrix4x4>.set_Item
	|
	|-RVA: 0x3245FB0 Offset: 0x32460B1 VA: 0x3245FB0
	|-List<ParticleSystem.Particle>.set_Item
	|
	|-RVA: 0x3249420 Offset: 0x3249521 VA: 0x3249420
	|-List<Playable>.set_Item
	|
	|-RVA: 0x324C470 Offset: 0x324C571 VA: 0x324C470
	|-List<PlayableBinding>.set_Item
	|
	|-RVA: 0x324F7E0 Offset: 0x324F8E1 VA: 0x324F7E0
	|-List<PlayableGraph>.set_Item
	|
	|-RVA: 0x32527F0 Offset: 0x32528F1 VA: 0x32527F0
	|-List<Edge>.set_Item
	|
	|-RVA: 0x32557A0 Offset: 0x32558A1 VA: 0x32557A0
	|-List<Quaternion>.set_Item
	|
	|-RVA: 0x3258820 Offset: 0x3258921 VA: 0x3258820
	|-List<RangeInt>.set_Item
	|
	|-RVA: 0x325B820 Offset: 0x325B921 VA: 0x325B820
	|-List<RaycastHit2D>.set_Item
	|
	|-RVA: 0x325ED90 Offset: 0x325EE91 VA: 0x325ED90
	|-List<RaycastHit>.set_Item
	|
	|-RVA: 0x33C0BE0 Offset: 0x33C0CE1 VA: 0x33C0BE0
	|-List<Rect>.set_Item
	|
	|-RVA: 0x33C3C60 Offset: 0x33C3D61 VA: 0x33C3C60
	|-List<RectInt>.set_Item
	|
	|-RVA: 0x33C6C70 Offset: 0x33C6D71 VA: 0x33C6C70
	|-List<ReflectionProbeBlendInfo>.set_Item
	|
	|-RVA: 0x33C9D50 Offset: 0x33C9E51 VA: 0x33C9D50
	|-List<SphericalHarmonicsL2>.set_Item
	|
	|-RVA: 0x33CDA10 Offset: 0x33CDB11 VA: 0x33CDA10
	|-List<VertexAttributeDescriptor>.set_Item
	|
	|-RVA: 0x33D0A60 Offset: 0x33D0B61 VA: 0x33D0A60
	|-List<AsyncOperationHandle>.set_Item
	|
	|-RVA: 0x33D3E00 Offset: 0x33D3F01 VA: 0x33D3E00
	|-List<AsyncOperationHandle<SceneInstance>>.set_Item
	|
	|-RVA: 0x33D71B0 Offset: 0x33D72B1 VA: 0x33D71B0
	|-List<DiagnosticEvent>.set_Item
	|
	|-RVA: 0x33DA760 Offset: 0x33DA861 VA: 0x33DA760
	|-List<DelayedActionManager.DelegateInfo>.set_Item
	|
	|-RVA: 0x33DDB20 Offset: 0x33DDC21 VA: 0x33DDB20
	|-List<ObjectInitializationData>.set_Item
	|
	|-RVA: 0x31B8FE0 Offset: 0x31B90E1 VA: 0x31B8FE0
	|-List<GlyphRect>.set_Item
	|
	|-RVA: 0x31BC040 Offset: 0x31BC141 VA: 0x31BC040
	|-List<AnimationOutputWeightProcessor.WeightInfo>.set_Item
	|
	|-RVA: 0x31BF510 Offset: 0x31BF611 VA: 0x31BF510
	|-List<IntervalTreeNode>.set_Item
	|
	|-RVA: 0x31C2860 Offset: 0x31C2961 VA: 0x31C2860
	|-List<IntervalTree.Entry<object>>.set_Item
	|
	|-RVA: 0x31C5C00 Offset: 0x31C5D01 VA: 0x31C5C00
	|-List<TimeNotificationBehaviour.NotificationEntry>.set_Item
	|
	|-RVA: 0x31C8F60 Offset: 0x31C9061 VA: 0x31C8F60
	|-List<UICharInfo>.set_Item
	|
	|-RVA: 0x31CBFE0 Offset: 0x31CC0E1 VA: 0x31CBFE0
	|-List<FocusController.FocusedElement>.set_Item
	|
	|-RVA: 0x31CF020 Offset: 0x31CF121 VA: 0x31CF020
	|-List<UILineInfo>.set_Item
	|
	|-RVA: 0x31D20B0 Offset: 0x31D21B1 VA: 0x31D20B0
	|-List<UIVertex>.set_Item
	|
	|-RVA: 0x31D5A70 Offset: 0x31D5B71 VA: 0x31D5A70
	|-List<UnitySynchronizationContext.WorkRequest>.set_Item
	|
	|-RVA: 0x31D8DC0 Offset: 0x31D8EC1 VA: 0x31D8DC0
	|-List<Vector2>.set_Item
	|
	|-RVA: 0x2CE1A00 Offset: 0x2CE1B01 VA: 0x2CE1A00
	|-List<Vector2Int>.set_Item
	|
	|-RVA: 0x2CE49B0 Offset: 0x2CE4AB1 VA: 0x2CE49B0
	|-List<Vector3>.set_Item
	|
	|-RVA: 0x2CE7A40 Offset: 0x2CE7B41 VA: 0x2CE7A40
	|-List<Vector3Int>.set_Item
	|
	|-RVA: 0x2CEAAF0 Offset: 0x2CEABF1 VA: 0x2CEAAF0
	|-List<Vector4>.set_Item
	|
	|-RVA: 0x2CEDC10 Offset: 0x2CEDD11 VA: 0x2CEDC10
	|-List<WarpPoints.WarpPoint>.set_Item
	|
	|-RVA: 0x2CF1880 Offset: 0x2CF1981 VA: 0x2CF1880
	|-List<YieldItemParam>.set_Item
	|
	|-RVA: 0x2CF4870 Offset: 0x2CF4971 VA: 0x2CF4870
	|-List<stCommand_t>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CB40 Offset: 0x248CC41 VA: 0x248CB40
	|-List<AS_ToolController.ChargeInfo>.IsCompatibleObject
	|
	|-RVA: 0x248FFD0 Offset: 0x24900D1 VA: 0x248FFD0
	|-List<BuildItemData>.IsCompatibleObject
	|
	|-RVA: 0x3156170 Offset: 0x3156271 VA: 0x3156170
	|-List<ButtonLinker.LinkObject>.IsCompatibleObject
	|
	|-RVA: 0x31591B0 Offset: 0x31592B1 VA: 0x31591B0
	|-List<CharaCallTable.BustupTable>.IsCompatibleObject
	|
	|-RVA: 0x315C1E0 Offset: 0x315C2E1 VA: 0x315C1E0
	|-List<CharaCallTable.CharaFaceIconTable>.IsCompatibleObject
	|
	|-RVA: 0x315F290 Offset: 0x315F391 VA: 0x315F290
	|-List<CameraState.CustomBlendable>.IsCompatibleObject
	|
	|-RVA: 0x31622C0 Offset: 0x31623C1 VA: 0x31622C0
	|-List<CinemachineClearShot.Pair>.IsCompatibleObject
	|
	|-RVA: 0x3165270 Offset: 0x3165371 VA: 0x3165270
	|-List<CinemachineStateDrivenCamera.HashPair>.IsCompatibleObject
	|
	|-RVA: 0x31682C0 Offset: 0x31683C1 VA: 0x31682C0
	|-List<TargetPositionCache.CacheCurve.Item>.IsCompatibleObject
	|
	|-RVA: 0x316B7B0 Offset: 0x316B8B1 VA: 0x316B7B0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.IsCompatibleObject
	|
	|-RVA: 0x316ED00 Offset: 0x316EE01 VA: 0x316ED00
	|-List<CropDataTable>.IsCompatibleObject
	|
	|-RVA: 0x3172230 Offset: 0x3172331 VA: 0x3172230
	|-List<DropItemParam>.IsCompatibleObject
	|
	|-RVA: 0x3175260 Offset: 0x3175361 VA: 0x3175260
	|-List<ErosionBrush.UndoStep>.IsCompatibleObject
	|
	|-RVA: 0x31DBEF0 Offset: 0x31DBFF1 VA: 0x31DBEF0
	|-List<EventCheckId>.IsCompatibleObject
	|
	|-RVA: 0x31DF220 Offset: 0x31DF321 VA: 0x31DF220
	|-List<EventFlagProgressData>.IsCompatibleObject
	|
	|-RVA: 0x31E2270 Offset: 0x31E2371 VA: 0x31E2270
	|-List<FesNpcScoreData>.IsCompatibleObject
	|
	|-RVA: 0x31E5360 Offset: 0x31E5461 VA: 0x31E5360
	|-List<MiningPointSaveData>.IsCompatibleObject
	|
	|-RVA: 0x31E88C0 Offset: 0x31E89C1 VA: 0x31E88C0
	|-List<MonsterHutSaveData>.IsCompatibleObject
	|
	|-RVA: 0x31EBD40 Offset: 0x31EBE41 VA: 0x31EBD40
	|-List<MoviePlayer.SUBTITLEDATA>.IsCompatibleObject
	|
	|-RVA: 0x31EEE40 Offset: 0x31EEF41 VA: 0x31EEE40
	|-List<NPCActionData>.IsCompatibleObject
	|
	|-RVA: 0x31F24C0 Offset: 0x31F25C1 VA: 0x31F24C0
	|-List<NpcPlaceSchedule>.IsCompatibleObject
	|
	|-RVA: 0x31F5800 Offset: 0x31F5901 VA: 0x31F5800
	|-List<OrderLotterySaveParameter>.IsCompatibleObject
	|
	|-RVA: 0x31F8920 Offset: 0x31F8A21 VA: 0x31F8920
	|-List<OrderSaveParameter>.IsCompatibleObject
	|
	|-RVA: 0x31FBC60 Offset: 0x31FBD61 VA: 0x31FBC60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.IsCompatibleObject
	|
	|-RVA: 0x330AED0 Offset: 0x330AFD1 VA: 0x330AED0
	|-List<ShopCatalogPage>.IsCompatibleObject
	|
	|-RVA: 0x330DFB0 Offset: 0x330E0B1 VA: 0x330DFB0
	|-List<ShopNpcTalk>.IsCompatibleObject
	|
	|-RVA: 0x33114E0 Offset: 0x33115E1 VA: 0x33114E0
	|-List<SubtitleDataTable.Data>.IsCompatibleObject
	|
	|-RVA: 0x3314580 Offset: 0x3314681 VA: 0x3314580
	|-List<SubtitleDataTable.DataList>.IsCompatibleObject
	|
	|-RVA: 0x3317570 Offset: 0x3317671 VA: 0x3317570
	|-List<SubtitleHudDataTable.Data>.IsCompatibleObject
	|
	|-RVA: 0x331A690 Offset: 0x331A791 VA: 0x331A690
	|-List<SRMonoBehaviourEx.FieldInfo>.IsCompatibleObject
	|
	|-RVA: 0x331DA30 Offset: 0x331DB31 VA: 0x331DA30
	|-List<Schedule>.IsCompatibleObject
	|
	|-RVA: 0x3320E00 Offset: 0x3320F01 VA: 0x3320E00
	|-List<CurveSample>.IsCompatibleObject
	|
	|-RVA: 0x33245C0 Offset: 0x33246C1 VA: 0x33245C0
	|-List<bool>.IsCompatibleObject
	|
	|-RVA: 0x33275B0 Offset: 0x33276B1 VA: 0x33275B0
	|-List<byte>.IsCompatibleObject
	|
	|-RVA: 0x332A580 Offset: 0x332A681 VA: 0x332A580
	|-List<char>.IsCompatibleObject
	|
	|-RVA: 0x33585E0 Offset: 0x33586E1 VA: 0x33585E0
	|-List<KeyValuePair<DateTime, object>>.IsCompatibleObject
	|
	|-RVA: 0x335B630 Offset: 0x335B731 VA: 0x335B630
	|-List<KeyValuePair<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x335E680 Offset: 0x335E781 VA: 0x335E680
	|-List<KeyValuePair<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x33616B0 Offset: 0x33617B1 VA: 0x33616B0
	|-List<DateTime>.IsCompatibleObject
	|
	|-RVA: 0x3364650 Offset: 0x3364751 VA: 0x3364650
	|-List<double>.IsCompatibleObject
	|
	|-RVA: 0x3367610 Offset: 0x3367711 VA: 0x3367610
	|-List<short>.IsCompatibleObject
	|
	|-RVA: 0x336A5C0 Offset: 0x336A6C1 VA: 0x336A5C0
	|-List<int>.IsCompatibleObject
	|
	|-RVA: 0x336D570 Offset: 0x336D671 VA: 0x336D570
	|-List<Int32Enum>.IsCompatibleObject
	|
	|-RVA: 0x3370520 Offset: 0x3370621 VA: 0x3370520
	|-List<long>.IsCompatibleObject
	|
	|-RVA: 0x33734E0 Offset: 0x33735E1 VA: 0x33734E0
	|-List<InterpretedFrameInfo>.IsCompatibleObject
	|
	|-RVA: 0x3376510 Offset: 0x3376611 VA: 0x3376510
	|-List<Nullable<Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x3405240 Offset: 0x3405341 VA: 0x3405240
	|-List<Nullable<Bounds>>.IsCompatibleObject
	|
	|-RVA: 0x3408800 Offset: 0x3408901 VA: 0x3408800
	|-List<Nullable<BoundsInt>>.IsCompatibleObject
	|
	|-RVA: 0x340BD20 Offset: 0x340BE21 VA: 0x340BD20
	|-List<Nullable<Color32>>.IsCompatibleObject
	|
	|-RVA: 0x340ED90 Offset: 0x340EE91 VA: 0x340ED90
	|-List<Nullable<Color>>.IsCompatibleObject
	|
	|-RVA: 0x34121A0 Offset: 0x34122A1 VA: 0x34121A0
	|-List<Nullable<GradientAlphaKey>>.IsCompatibleObject
	|
	|-RVA: 0x3415310 Offset: 0x3415411 VA: 0x3415310
	|-List<Nullable<GradientColorKey>>.IsCompatibleObject
	|
	|-RVA: 0x3418760 Offset: 0x3418861 VA: 0x3418760
	|-List<Nullable<Keyframe>>.IsCompatibleObject
	|
	|-RVA: 0x341BB50 Offset: 0x341BC51 VA: 0x341BB50
	|-List<Nullable<LayerMask>>.IsCompatibleObject
	|
	|-RVA: 0x341EC50 Offset: 0x341ED51 VA: 0x341EC50
	|-List<Nullable<Matrix4x4>>.IsCompatibleObject
	|
	|-RVA: 0x3422600 Offset: 0x3422701 VA: 0x3422600
	|-List<Nullable<Quaternion>>.IsCompatibleObject
	|
	|-RVA: 0x3262480 Offset: 0x3262581 VA: 0x3262480
	|-List<Nullable<RangeInt>>.IsCompatibleObject
	|
	|-RVA: 0x32655F0 Offset: 0x32656F1 VA: 0x32655F0
	|-List<Nullable<Rect>>.IsCompatibleObject
	|
	|-RVA: 0x3268A50 Offset: 0x3268B51 VA: 0x3268A50
	|-List<Nullable<RectInt>>.IsCompatibleObject
	|
	|-RVA: 0x326BE60 Offset: 0x326BF61 VA: 0x326BE60
	|-List<Nullable<Vector2>>.IsCompatibleObject
	|
	|-RVA: 0x326EF80 Offset: 0x326F081 VA: 0x326EF80
	|-List<Nullable<Vector2Int>>.IsCompatibleObject
	|
	|-RVA: 0x3272080 Offset: 0x3272181 VA: 0x3272080
	|-List<Nullable<Vector3>>.IsCompatibleObject
	|
	|-RVA: 0x32750F0 Offset: 0x32751F1 VA: 0x32750F0
	|-List<Nullable<Vector3Int>>.IsCompatibleObject
	|
	|-RVA: 0x32781D0 Offset: 0x32782D1 VA: 0x32781D0
	|-List<Nullable<Vector4>>.IsCompatibleObject
	|
	|-RVA: 0x327B5C0 Offset: 0x327B6C1 VA: 0x327B5C0
	|-List<object>.IsCompatibleObject
	|
	|-RVA: 0x327E4F0 Offset: 0x327E5F1 VA: 0x327E4F0
	|-List<sbyte>.IsCompatibleObject
	|
	|-RVA: 0x32814B0 Offset: 0x32815B1 VA: 0x32814B0
	|-List<float>.IsCompatibleObject
	|
	|-RVA: 0x32A8720 Offset: 0x32A8821 VA: 0x32A8720
	|-List<ushort>.IsCompatibleObject
	|
	|-RVA: 0x32AB6D0 Offset: 0x32AB7D1 VA: 0x32AB6D0
	|-List<uint>.IsCompatibleObject
	|
	|-RVA: 0x32AE680 Offset: 0x32AE781 VA: 0x32AE680
	|-List<ulong>.IsCompatibleObject
	|
	|-RVA: 0x32B1630 Offset: 0x32B1731 VA: 0x32B1630
	|-List<ValueTuple<bool, Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x32B45E0 Offset: 0x32B46E1 VA: 0x32B45E0
	|-List<ValueTuple<Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x32B75A0 Offset: 0x32B76A1 VA: 0x32B75A0
	|-List<ValueTuple<Int32Enum, object>>.IsCompatibleObject
	|
	|-RVA: 0x32BA5F0 Offset: 0x32BA6F1 VA: 0x32BA5F0
	|-List<ValueTuple<object, Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x32BD630 Offset: 0x32BD731 VA: 0x32BD630
	|-List<ValueTuple<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x32C0670 Offset: 0x32C0771 VA: 0x32C0670
	|-List<ValueTuple<object, float>>.IsCompatibleObject
	|
	|-RVA: 0x32C36C0 Offset: 0x32C37C1 VA: 0x32C36C0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IsCompatibleObject
	|
	|-RVA: 0x32C6830 Offset: 0x32C6931 VA: 0x32C6830
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IsCompatibleObject
	|
	|-RVA: 0x3110490 Offset: 0x3110591 VA: 0x3110490
	|-List<TexturePacker_JsonArray.Frame>.IsCompatibleObject
	|
	|-RVA: 0x3113AD0 Offset: 0x3113BD1 VA: 0x3113AD0
	|-List<TutorialUnlockFlagData>.IsCompatibleObject
	|
	|-RVA: 0x3116B80 Offset: 0x3116C81 VA: 0x3116B80
	|-List<UIMainManagerAttachObject.AttachSet>.IsCompatibleObject
	|
	|-RVA: 0x3119C70 Offset: 0x3119D71 VA: 0x3119C70
	|-List<CapEdge>.IsCompatibleObject
	|
	|-RVA: 0x311D120 Offset: 0x311D221 VA: 0x311D120
	|-List<MeshDataConnectivity.Face>.IsCompatibleObject
	|
	|-RVA: 0x3120140 Offset: 0x3120241 VA: 0x3120140
	|-List<MeshFaceConnectivity.EdgeData.SideData>.IsCompatibleObject
	|
	|-RVA: 0x31234D0 Offset: 0x31235D1 VA: 0x31234D0
	|-List<MeshFaceConnectivity.EdgeData>.IsCompatibleObject
	|
	|-RVA: 0x31269E0 Offset: 0x3126AE1 VA: 0x31269E0
	|-List<NavMeshBuildMarkup>.IsCompatibleObject
	|
	|-RVA: 0x3129B30 Offset: 0x3129C31 VA: 0x3129B30
	|-List<NavMeshBuildSource>.IsCompatibleObject
	|
	|-RVA: 0x312D5D0 Offset: 0x312D6D1 VA: 0x312D5D0
	|-List<ConstraintSource>.IsCompatibleObject
	|
	|-RVA: 0x3130600 Offset: 0x3130701 VA: 0x3130600
	|-List<AnimatorClipInfo>.IsCompatibleObject
	|
	|-RVA: 0x321C1A0 Offset: 0x321C2A1 VA: 0x321C1A0
	|-List<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|
	|-RVA: 0x321F250 Offset: 0x321F351 VA: 0x321F250
	|-List<BoneWeight>.IsCompatibleObject
	|
	|-RVA: 0x32225B0 Offset: 0x32226B1 VA: 0x32225B0
	|-List<Bounds>.IsCompatibleObject
	|
	|-RVA: 0x3225900 Offset: 0x3225A01 VA: 0x3225900
	|-List<BoundsInt>.IsCompatibleObject
	|
	|-RVA: 0x3228BE0 Offset: 0x3228CE1 VA: 0x3228BE0
	|-List<Color32>.IsCompatibleObject
	|
	|-RVA: 0x322BBD0 Offset: 0x322BCD1 VA: 0x322BBD0
	|-List<Color>.IsCompatibleObject
	|
	|-RVA: 0x322ED70 Offset: 0x322EE71 VA: 0x322ED70
	|-List<CombineInstance>.IsCompatibleObject
	|
	|-RVA: 0x3232920 Offset: 0x3232A21 VA: 0x3232920
	|-List<RaycastResult>.IsCompatibleObject
	|
	|-RVA: 0x32360F0 Offset: 0x32361F1 VA: 0x32360F0
	|-List<GradientAlphaKey>.IsCompatibleObject
	|
	|-RVA: 0x3239190 Offset: 0x3239291 VA: 0x3239190
	|-List<GradientColorKey>.IsCompatibleObject
	|
	|-RVA: 0x323C520 Offset: 0x323C621 VA: 0x323C520
	|-List<Keyframe>.IsCompatibleObject
	|
	|-RVA: 0x323F960 Offset: 0x323FA61 VA: 0x323F960
	|-List<LayerMask>.IsCompatibleObject
	|
	|-RVA: 0x32429F0 Offset: 0x3242AF1 VA: 0x32429F0
	|-List<Matrix4x4>.IsCompatibleObject
	|
	|-RVA: 0x3246070 Offset: 0x3246171 VA: 0x3246070
	|-List<ParticleSystem.Particle>.IsCompatibleObject
	|
	|-RVA: 0x32494A0 Offset: 0x32495A1 VA: 0x32494A0
	|-List<Playable>.IsCompatibleObject
	|
	|-RVA: 0x324C530 Offset: 0x324C631 VA: 0x324C530
	|-List<PlayableBinding>.IsCompatibleObject
	|
	|-RVA: 0x324F860 Offset: 0x324F961 VA: 0x324F860
	|-List<PlayableGraph>.IsCompatibleObject
	|
	|-RVA: 0x3252870 Offset: 0x3252971 VA: 0x3252870
	|-List<Edge>.IsCompatibleObject
	|
	|-RVA: 0x3255840 Offset: 0x3255941 VA: 0x3255840
	|-List<Quaternion>.IsCompatibleObject
	|
	|-RVA: 0x32588A0 Offset: 0x32589A1 VA: 0x32588A0
	|-List<RangeInt>.IsCompatibleObject
	|
	|-RVA: 0x325B900 Offset: 0x325BA01 VA: 0x325B900
	|-List<RaycastHit2D>.IsCompatibleObject
	|
	|-RVA: 0x325EE70 Offset: 0x325EF71 VA: 0x325EE70
	|-List<RaycastHit>.IsCompatibleObject
	|
	|-RVA: 0x33C0C80 Offset: 0x33C0D81 VA: 0x33C0C80
	|-List<Rect>.IsCompatibleObject
	|
	|-RVA: 0x33C3CE0 Offset: 0x33C3DE1 VA: 0x33C3CE0
	|-List<RectInt>.IsCompatibleObject
	|
	|-RVA: 0x33C6D00 Offset: 0x33C6E01 VA: 0x33C6D00
	|-List<ReflectionProbeBlendInfo>.IsCompatibleObject
	|
	|-RVA: 0x33C9E90 Offset: 0x33C9F91 VA: 0x33C9E90
	|-List<SphericalHarmonicsL2>.IsCompatibleObject
	|
	|-RVA: 0x33CDA90 Offset: 0x33CDB91 VA: 0x33CDA90
	|-List<VertexAttributeDescriptor>.IsCompatibleObject
	|
	|-RVA: 0x33D0B20 Offset: 0x33D0C21 VA: 0x33D0B20
	|-List<AsyncOperationHandle>.IsCompatibleObject
	|
	|-RVA: 0x33D3EC0 Offset: 0x33D3FC1 VA: 0x33D3EC0
	|-List<AsyncOperationHandle<SceneInstance>>.IsCompatibleObject
	|
	|-RVA: 0x33D7290 Offset: 0x33D7391 VA: 0x33D7290
	|-List<DiagnosticEvent>.IsCompatibleObject
	|
	|-RVA: 0x33DA820 Offset: 0x33DA921 VA: 0x33DA820
	|-List<DelayedActionManager.DelegateInfo>.IsCompatibleObject
	|
	|-RVA: 0x33DDC00 Offset: 0x33DDD01 VA: 0x33DDC00
	|-List<ObjectInitializationData>.IsCompatibleObject
	|
	|-RVA: 0x31B9060 Offset: 0x31B9161 VA: 0x31B9060
	|-List<GlyphRect>.IsCompatibleObject
	|
	|-RVA: 0x31BC110 Offset: 0x31BC211 VA: 0x31BC110
	|-List<AnimationOutputWeightProcessor.WeightInfo>.IsCompatibleObject
	|
	|-RVA: 0x31BF5C0 Offset: 0x31BF6C1 VA: 0x31BF5C0
	|-List<IntervalTreeNode>.IsCompatibleObject
	|
	|-RVA: 0x31C2920 Offset: 0x31C2A21 VA: 0x31C2920
	|-List<IntervalTree.Entry<object>>.IsCompatibleObject
	|
	|-RVA: 0x31C5CC0 Offset: 0x31C5DC1 VA: 0x31C5CC0
	|-List<TimeNotificationBehaviour.NotificationEntry>.IsCompatibleObject
	|
	|-RVA: 0x31C9000 Offset: 0x31C9101 VA: 0x31C9000
	|-List<UICharInfo>.IsCompatibleObject
	|
	|-RVA: 0x31CC070 Offset: 0x31CC171 VA: 0x31CC070
	|-List<FocusController.FocusedElement>.IsCompatibleObject
	|
	|-RVA: 0x31CF0A0 Offset: 0x31CF1A1 VA: 0x31CF0A0
	|-List<UILineInfo>.IsCompatibleObject
	|
	|-RVA: 0x31D21C0 Offset: 0x31D22C1 VA: 0x31D21C0
	|-List<UIVertex>.IsCompatibleObject
	|
	|-RVA: 0x31D5B30 Offset: 0x31D5C31 VA: 0x31D5B30
	|-List<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|
	|-RVA: 0x31D8E40 Offset: 0x31D8F41 VA: 0x31D8E40
	|-List<Vector2>.IsCompatibleObject
	|
	|-RVA: 0x2CE1A80 Offset: 0x2CE1B81 VA: 0x2CE1A80
	|-List<Vector2Int>.IsCompatibleObject
	|
	|-RVA: 0x2CE4A50 Offset: 0x2CE4B51 VA: 0x2CE4A50
	|-List<Vector3>.IsCompatibleObject
	|
	|-RVA: 0x2CE7AD0 Offset: 0x2CE7BD1 VA: 0x2CE7AD0
	|-List<Vector3Int>.IsCompatibleObject
	|
	|-RVA: 0x2CEAB90 Offset: 0x2CEAC91 VA: 0x2CEAB90
	|-List<Vector4>.IsCompatibleObject
	|
	|-RVA: 0x2CEDD60 Offset: 0x2CEDE61 VA: 0x2CEDD60
	|-List<WarpPoints.WarpPoint>.IsCompatibleObject
	|
	|-RVA: 0x2CF1900 Offset: 0x2CF1A01 VA: 0x2CF1900
	|-List<YieldItemParam>.IsCompatibleObject
	|
	|-RVA: 0x2CF4930 Offset: 0x2CF4A31 VA: 0x2CF4930
	|-List<stCommand_t>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CC30 Offset: 0x248CD31 VA: 0x248CC30
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x24900D0 Offset: 0x24901D1 VA: 0x24900D0
	|-List<BuildItemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3156260 Offset: 0x3156361 VA: 0x3156260
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31592A0 Offset: 0x31593A1 VA: 0x31592A0
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x315C2D0 Offset: 0x315C3D1 VA: 0x315C2D0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x315F380 Offset: 0x315F481 VA: 0x315F380
	|-List<CameraState.CustomBlendable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31623C0 Offset: 0x31624C1 VA: 0x31623C0
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3165370 Offset: 0x3165471 VA: 0x3165370
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31683B0 Offset: 0x31684B1 VA: 0x31683B0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_Item
	|
	|-RVA: 0x316B8A0 Offset: 0x316B9A1 VA: 0x316B8A0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x316EE20 Offset: 0x316EF21 VA: 0x316EE20
	|-List<CropDataTable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3172330 Offset: 0x3172431 VA: 0x3172330
	|-List<DropItemParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3175350 Offset: 0x3175451 VA: 0x3175350
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31DBFE0 Offset: 0x31DC0E1 VA: 0x31DBFE0
	|-List<EventCheckId>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31DF310 Offset: 0x31DF411 VA: 0x31DF310
	|-List<EventFlagProgressData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31E2360 Offset: 0x31E2461 VA: 0x31E2360
	|-List<FesNpcScoreData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31E5450 Offset: 0x31E5551 VA: 0x31E5450
	|-List<MiningPointSaveData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31E89B0 Offset: 0x31E8AB1 VA: 0x31E89B0
	|-List<MonsterHutSaveData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31EBE30 Offset: 0x31EBF31 VA: 0x31EBE30
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31EEF30 Offset: 0x31EF031 VA: 0x31EEF30
	|-List<NPCActionData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31F25B0 Offset: 0x31F26B1 VA: 0x31F25B0
	|-List<NpcPlaceSchedule>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31F58F0 Offset: 0x31F59F1 VA: 0x31F58F0
	|-List<OrderLotterySaveParameter>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31F8A10 Offset: 0x31F8B11 VA: 0x31F8A10
	|-List<OrderSaveParameter>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31FBD50 Offset: 0x31FBE51 VA: 0x31FBD50
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_Item
	|
	|-RVA: 0x330AFC0 Offset: 0x330B0C1 VA: 0x330AFC0
	|-List<ShopCatalogPage>.System.Collections.IList.get_Item
	|
	|-RVA: 0x330E0A0 Offset: 0x330E1A1 VA: 0x330E0A0
	|-List<ShopNpcTalk>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33115D0 Offset: 0x33116D1 VA: 0x33115D0
	|-List<SubtitleDataTable.Data>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3314680 Offset: 0x3314781 VA: 0x3314680
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3317660 Offset: 0x3317761 VA: 0x3317660
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.get_Item
	|
	|-RVA: 0x331A780 Offset: 0x331A881 VA: 0x331A780
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x331DB20 Offset: 0x331DC21 VA: 0x331DB20
	|-List<Schedule>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3320F00 Offset: 0x3321001 VA: 0x3320F00
	|-List<CurveSample>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33246C0 Offset: 0x33247C1 VA: 0x33246C0
	|-List<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33276B0 Offset: 0x33277B1 VA: 0x33276B0
	|-List<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x332A680 Offset: 0x332A781 VA: 0x332A680
	|-List<char>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33586D0 Offset: 0x33587D1 VA: 0x33586D0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x335B720 Offset: 0x335B821 VA: 0x335B720
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x335E770 Offset: 0x335E871 VA: 0x335E770
	|-List<KeyValuePair<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33617B0 Offset: 0x33618B1 VA: 0x33617B0
	|-List<DateTime>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3364750 Offset: 0x3364851 VA: 0x3364750
	|-List<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3367710 Offset: 0x3367811 VA: 0x3367710
	|-List<short>.System.Collections.IList.get_Item
	|
	|-RVA: 0x336A6C0 Offset: 0x336A7C1 VA: 0x336A6C0
	|-List<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x336D670 Offset: 0x336D771 VA: 0x336D670
	|-List<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3370620 Offset: 0x3370721 VA: 0x3370620
	|-List<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33735D0 Offset: 0x33736D1 VA: 0x33735D0
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3376610 Offset: 0x3376711 VA: 0x3376610
	|-List<Nullable<Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3405330 Offset: 0x3405431 VA: 0x3405330
	|-List<Nullable<Bounds>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x34088F0 Offset: 0x34089F1 VA: 0x34088F0
	|-List<Nullable<BoundsInt>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x340BE20 Offset: 0x340BF21 VA: 0x340BE20
	|-List<Nullable<Color32>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x340EE80 Offset: 0x340EF81 VA: 0x340EE80
	|-List<Nullable<Color>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3412290 Offset: 0x3412391 VA: 0x3412290
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3415400 Offset: 0x3415501 VA: 0x3415400
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3418850 Offset: 0x3418951 VA: 0x3418850
	|-List<Nullable<Keyframe>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x341BC50 Offset: 0x341BD51 VA: 0x341BC50
	|-List<Nullable<LayerMask>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x341ED50 Offset: 0x341EE51 VA: 0x341ED50
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x34226F0 Offset: 0x34227F1 VA: 0x34226F0
	|-List<Nullable<Quaternion>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3262570 Offset: 0x3262671 VA: 0x3262570
	|-List<Nullable<RangeInt>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32656E0 Offset: 0x32657E1 VA: 0x32656E0
	|-List<Nullable<Rect>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3268B40 Offset: 0x3268C41 VA: 0x3268B40
	|-List<Nullable<RectInt>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x326BF50 Offset: 0x326C051 VA: 0x326BF50
	|-List<Nullable<Vector2>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x326F070 Offset: 0x326F171 VA: 0x326F070
	|-List<Nullable<Vector2Int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3272170 Offset: 0x3272271 VA: 0x3272170
	|-List<Nullable<Vector3>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32751E0 Offset: 0x32752E1 VA: 0x32751E0
	|-List<Nullable<Vector3Int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32782C0 Offset: 0x32783C1 VA: 0x32782C0
	|-List<Nullable<Vector4>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x327B650 Offset: 0x327B751 VA: 0x327B650
	|-List<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x327E5F0 Offset: 0x327E6F1 VA: 0x327E5F0
	|-List<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32815B0 Offset: 0x32816B1 VA: 0x32815B0
	|-List<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32A8820 Offset: 0x32A8921 VA: 0x32A8820
	|-List<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32AB7D0 Offset: 0x32AB8D1 VA: 0x32AB7D0
	|-List<uint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32AE780 Offset: 0x32AE881 VA: 0x32AE780
	|-List<ulong>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32B1730 Offset: 0x32B1831 VA: 0x32B1730
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32B46E0 Offset: 0x32B47E1 VA: 0x32B46E0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32B7690 Offset: 0x32B7791 VA: 0x32B7690
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32BA6E0 Offset: 0x32BA7E1 VA: 0x32BA6E0
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32BD720 Offset: 0x32BD821 VA: 0x32BD720
	|-List<ValueTuple<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32C0760 Offset: 0x32C0861 VA: 0x32C0760
	|-List<ValueTuple<object, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32C37B0 Offset: 0x32C38B1 VA: 0x32C37B0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32C6920 Offset: 0x32C6A21 VA: 0x32C6920
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3110580 Offset: 0x3110681 VA: 0x3110580
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3113BC0 Offset: 0x3113CC1 VA: 0x3113BC0
	|-List<TutorialUnlockFlagData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3116C70 Offset: 0x3116D71 VA: 0x3116C70
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3119D60 Offset: 0x3119E61 VA: 0x3119D60
	|-List<CapEdge>.System.Collections.IList.get_Item
	|
	|-RVA: 0x311D220 Offset: 0x311D321 VA: 0x311D220
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3120230 Offset: 0x3120331 VA: 0x3120230
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31235C0 Offset: 0x31236C1 VA: 0x31235C0
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3126AD0 Offset: 0x3126BD1 VA: 0x3126AD0
	|-List<NavMeshBuildMarkup>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3129C30 Offset: 0x3129D31 VA: 0x3129C30
	|-List<NavMeshBuildSource>.System.Collections.IList.get_Item
	|
	|-RVA: 0x312D6C0 Offset: 0x312D7C1 VA: 0x312D6C0
	|-List<ConstraintSource>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3130700 Offset: 0x3130801 VA: 0x3130700
	|-List<AnimatorClipInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x321C290 Offset: 0x321C391 VA: 0x321C290
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|
	|-RVA: 0x321F340 Offset: 0x321F441 VA: 0x321F340
	|-List<BoneWeight>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32226A0 Offset: 0x32227A1 VA: 0x32226A0
	|-List<Bounds>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32259F0 Offset: 0x3225AF1 VA: 0x32259F0
	|-List<BoundsInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3228CE0 Offset: 0x3228DE1 VA: 0x3228CE0
	|-List<Color32>.System.Collections.IList.get_Item
	|
	|-RVA: 0x322BCC0 Offset: 0x322BDC1 VA: 0x322BCC0
	|-List<Color>.System.Collections.IList.get_Item
	|
	|-RVA: 0x322EE70 Offset: 0x322EF71 VA: 0x322EE70
	|-List<CombineInstance>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3232A20 Offset: 0x3232B21 VA: 0x3232A20
	|-List<RaycastResult>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32361F0 Offset: 0x32362F1 VA: 0x32361F0
	|-List<GradientAlphaKey>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3239280 Offset: 0x3239381 VA: 0x3239280
	|-List<GradientColorKey>.System.Collections.IList.get_Item
	|
	|-RVA: 0x323C610 Offset: 0x323C711 VA: 0x323C610
	|-List<Keyframe>.System.Collections.IList.get_Item
	|
	|-RVA: 0x323FA60 Offset: 0x323FB61 VA: 0x323FA60
	|-List<LayerMask>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3242AE0 Offset: 0x3242BE1 VA: 0x3242AE0
	|-List<Matrix4x4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3246180 Offset: 0x3246281 VA: 0x3246180
	|-List<ParticleSystem.Particle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3249590 Offset: 0x3249691 VA: 0x3249590
	|-List<Playable>.System.Collections.IList.get_Item
	|
	|-RVA: 0x324C620 Offset: 0x324C721 VA: 0x324C620
	|-List<PlayableBinding>.System.Collections.IList.get_Item
	|
	|-RVA: 0x324F950 Offset: 0x324FA51 VA: 0x324F950
	|-List<PlayableGraph>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3252970 Offset: 0x3252A71 VA: 0x3252970
	|-List<Edge>.System.Collections.IList.get_Item
	|
	|-RVA: 0x3255930 Offset: 0x3255A31 VA: 0x3255930
	|-List<Quaternion>.System.Collections.IList.get_Item
	|
	|-RVA: 0x32589A0 Offset: 0x3258AA1 VA: 0x32589A0
	|-List<RangeInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x325B9F0 Offset: 0x325BAF1 VA: 0x325B9F0
	|-List<RaycastHit2D>.System.Collections.IList.get_Item
	|
	|-RVA: 0x325EF60 Offset: 0x325F061 VA: 0x325EF60
	|-List<RaycastHit>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33C0D70 Offset: 0x33C0E71 VA: 0x33C0D70
	|-List<Rect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33C3DD0 Offset: 0x33C3ED1 VA: 0x33C3DD0
	|-List<RectInt>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33C6DF0 Offset: 0x33C6EF1 VA: 0x33C6DF0
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33C9F90 Offset: 0x33CA091 VA: 0x33C9F90
	|-List<SphericalHarmonicsL2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33CDB80 Offset: 0x33CDC81 VA: 0x33CDB80
	|-List<VertexAttributeDescriptor>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33D0C10 Offset: 0x33D0D11 VA: 0x33D0C10
	|-List<AsyncOperationHandle>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33D3FB0 Offset: 0x33D40B1 VA: 0x33D3FB0
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33D7380 Offset: 0x33D7481 VA: 0x33D7380
	|-List<DiagnosticEvent>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33DA910 Offset: 0x33DAA11 VA: 0x33DA910
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x33DDCF0 Offset: 0x33DDDF1 VA: 0x33DDCF0
	|-List<ObjectInitializationData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31B9150 Offset: 0x31B9251 VA: 0x31B9150
	|-List<GlyphRect>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31BC200 Offset: 0x31BC301 VA: 0x31BC200
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31BF6B0 Offset: 0x31BF7B1 VA: 0x31BF6B0
	|-List<IntervalTreeNode>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31C2A10 Offset: 0x31C2B11 VA: 0x31C2A10
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31C5DB0 Offset: 0x31C5EB1 VA: 0x31C5DB0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31C90F0 Offset: 0x31C91F1 VA: 0x31C90F0
	|-List<UICharInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31CC160 Offset: 0x31CC261 VA: 0x31CC160
	|-List<FocusController.FocusedElement>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31CF190 Offset: 0x31CF291 VA: 0x31CF190
	|-List<UILineInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31D22C0 Offset: 0x31D23C1 VA: 0x31D22C0
	|-List<UIVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31D5C20 Offset: 0x31D5D21 VA: 0x31D5C20
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x31D8F40 Offset: 0x31D9041 VA: 0x31D8F40
	|-List<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CE1B80 Offset: 0x2CE1C81 VA: 0x2CE1B80
	|-List<Vector2Int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CE4B40 Offset: 0x2CE4C41 VA: 0x2CE4B40
	|-List<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CE7BC0 Offset: 0x2CE7CC1 VA: 0x2CE7BC0
	|-List<Vector3Int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CEAC80 Offset: 0x2CEAD81 VA: 0x2CEAC80
	|-List<Vector4>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CEDE60 Offset: 0x2CEDF61 VA: 0x2CEDE60
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CF1A00 Offset: 0x2CF1B01 VA: 0x2CF1A00
	|-List<YieldItemParam>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2CF4A20 Offset: 0x2CF4B21 VA: 0x2CF4A20
	|-List<stCommand_t>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CCB0 Offset: 0x248CDB1 VA: 0x248CCB0
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2490180 Offset: 0x2490281 VA: 0x2490180
	|-List<BuildItemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31562D0 Offset: 0x31563D1 VA: 0x31562D0
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3159310 Offset: 0x3159411 VA: 0x3159310
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x315C340 Offset: 0x315C441 VA: 0x315C340
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x315F3F0 Offset: 0x315F4F1 VA: 0x315F3F0
	|-List<CameraState.CustomBlendable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3162430 Offset: 0x3162531 VA: 0x3162430
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31653E0 Offset: 0x31654E1 VA: 0x31653E0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3168440 Offset: 0x3168541 VA: 0x3168440
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.set_Item
	|
	|-RVA: 0x316B930 Offset: 0x316BA31 VA: 0x316B930
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.set_Item
	|
	|-RVA: 0x316EEA0 Offset: 0x316EFA1 VA: 0x316EEA0
	|-List<CropDataTable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31723A0 Offset: 0x31724A1 VA: 0x31723A0
	|-List<DropItemParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31753D0 Offset: 0x31754D1 VA: 0x31753D0
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31DC060 Offset: 0x31DC161 VA: 0x31DC060
	|-List<EventCheckId>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31DF380 Offset: 0x31DF481 VA: 0x31DF380
	|-List<EventFlagProgressData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31E23D0 Offset: 0x31E24D1 VA: 0x31E23D0
	|-List<FesNpcScoreData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31E54E0 Offset: 0x31E55E1 VA: 0x31E54E0
	|-List<MiningPointSaveData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31E8A40 Offset: 0x31E8B41 VA: 0x31E8A40
	|-List<MonsterHutSaveData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31EBEA0 Offset: 0x31EBFA1 VA: 0x31EBEA0
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31EEFC0 Offset: 0x31EF0C1 VA: 0x31EEFC0
	|-List<NPCActionData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31F2630 Offset: 0x31F2731 VA: 0x31F2630
	|-List<NpcPlaceSchedule>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31F5960 Offset: 0x31F5A61 VA: 0x31F5960
	|-List<OrderLotterySaveParameter>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31F8A90 Offset: 0x31F8B91 VA: 0x31F8A90
	|-List<OrderSaveParameter>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31FBDC0 Offset: 0x31FBEC1 VA: 0x31FBDC0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.set_Item
	|
	|-RVA: 0x330B030 Offset: 0x330B131 VA: 0x330B030
	|-List<ShopCatalogPage>.System.Collections.IList.set_Item
	|
	|-RVA: 0x330E130 Offset: 0x330E231 VA: 0x330E130
	|-List<ShopNpcTalk>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3311640 Offset: 0x3311741 VA: 0x3311640
	|-List<SubtitleDataTable.Data>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33146F0 Offset: 0x33147F1 VA: 0x33146F0
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33176D0 Offset: 0x33177D1 VA: 0x33176D0
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.set_Item
	|
	|-RVA: 0x331A800 Offset: 0x331A901 VA: 0x331A800
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x331DBA0 Offset: 0x331DCA1 VA: 0x331DBA0
	|-List<Schedule>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3320FA0 Offset: 0x33210A1 VA: 0x3320FA0
	|-List<CurveSample>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3324730 Offset: 0x3324831 VA: 0x3324730
	|-List<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3327720 Offset: 0x3327821 VA: 0x3327720
	|-List<byte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x332A6F0 Offset: 0x332A7F1 VA: 0x332A6F0
	|-List<char>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3358740 Offset: 0x3358841 VA: 0x3358740
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x335B790 Offset: 0x335B891 VA: 0x335B790
	|-List<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x335E7E0 Offset: 0x335E8E1 VA: 0x335E7E0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3361820 Offset: 0x3361921 VA: 0x3361820
	|-List<DateTime>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33647C0 Offset: 0x33648C1 VA: 0x33647C0
	|-List<double>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3367780 Offset: 0x3367881 VA: 0x3367780
	|-List<short>.System.Collections.IList.set_Item
	|
	|-RVA: 0x336A730 Offset: 0x336A831 VA: 0x336A730
	|-List<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x336D6E0 Offset: 0x336D7E1 VA: 0x336D6E0
	|-List<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3370690 Offset: 0x3370791 VA: 0x3370690
	|-List<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3373640 Offset: 0x3373741 VA: 0x3373640
	|-List<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3376680 Offset: 0x3376781 VA: 0x3376680
	|-List<Nullable<Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x34053C0 Offset: 0x34054C1 VA: 0x34053C0
	|-List<Nullable<Bounds>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3408980 Offset: 0x3408A81 VA: 0x3408980
	|-List<Nullable<BoundsInt>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x340BE90 Offset: 0x340BF91 VA: 0x340BE90
	|-List<Nullable<Color32>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x340EF00 Offset: 0x340F001 VA: 0x340EF00
	|-List<Nullable<Color>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3412300 Offset: 0x3412401 VA: 0x3412300
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3415480 Offset: 0x3415581 VA: 0x3415480
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x34188D0 Offset: 0x34189D1 VA: 0x34188D0
	|-List<Nullable<Keyframe>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x341BCC0 Offset: 0x341BDC1 VA: 0x341BCC0
	|-List<Nullable<LayerMask>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x341EDF0 Offset: 0x341EEF1 VA: 0x341EDF0
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3422770 Offset: 0x3422871 VA: 0x3422770
	|-List<Nullable<Quaternion>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32625E0 Offset: 0x32626E1 VA: 0x32625E0
	|-List<Nullable<RangeInt>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3265760 Offset: 0x3265861 VA: 0x3265760
	|-List<Nullable<Rect>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3268BC0 Offset: 0x3268CC1 VA: 0x3268BC0
	|-List<Nullable<RectInt>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x326BFC0 Offset: 0x326C0C1 VA: 0x326BFC0
	|-List<Nullable<Vector2>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x326F0E0 Offset: 0x326F1E1 VA: 0x326F0E0
	|-List<Nullable<Vector2Int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32721E0 Offset: 0x32722E1 VA: 0x32721E0
	|-List<Nullable<Vector3>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3275250 Offset: 0x3275351 VA: 0x3275250
	|-List<Nullable<Vector3Int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3278340 Offset: 0x3278441 VA: 0x3278340
	|-List<Nullable<Vector4>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x327B680 Offset: 0x327B781 VA: 0x327B680
	|-List<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x327E660 Offset: 0x327E761 VA: 0x327E660
	|-List<sbyte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3281620 Offset: 0x3281721 VA: 0x3281620
	|-List<float>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32A8890 Offset: 0x32A8991 VA: 0x32A8890
	|-List<ushort>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32AB840 Offset: 0x32AB941 VA: 0x32AB840
	|-List<uint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32AE7F0 Offset: 0x32AE8F1 VA: 0x32AE7F0
	|-List<ulong>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32B17A0 Offset: 0x32B18A1 VA: 0x32B17A0
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32B4750 Offset: 0x32B4851 VA: 0x32B4750
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32B7700 Offset: 0x32B7801 VA: 0x32B7700
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32BA750 Offset: 0x32BA851 VA: 0x32BA750
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32BD790 Offset: 0x32BD891 VA: 0x32BD790
	|-List<ValueTuple<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32C07D0 Offset: 0x32C08D1 VA: 0x32C07D0
	|-List<ValueTuple<object, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32C3820 Offset: 0x32C3921 VA: 0x32C3820
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32C69B0 Offset: 0x32C6AB1 VA: 0x32C69B0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3110610 Offset: 0x3110711 VA: 0x3110610
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3113C30 Offset: 0x3113D31 VA: 0x3113C30
	|-List<TutorialUnlockFlagData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3116CE0 Offset: 0x3116DE1 VA: 0x3116CE0
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3119DF0 Offset: 0x3119EF1 VA: 0x3119DF0
	|-List<CapEdge>.System.Collections.IList.set_Item
	|
	|-RVA: 0x311D290 Offset: 0x311D391 VA: 0x311D290
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31202B0 Offset: 0x31203B1 VA: 0x31202B0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3123650 Offset: 0x3123751 VA: 0x3123650
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3126B40 Offset: 0x3126C41 VA: 0x3126B40
	|-List<NavMeshBuildMarkup>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3129CE0 Offset: 0x3129DE1 VA: 0x3129CE0
	|-List<NavMeshBuildSource>.System.Collections.IList.set_Item
	|
	|-RVA: 0x312D730 Offset: 0x312D831 VA: 0x312D730
	|-List<ConstraintSource>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3130770 Offset: 0x3130871 VA: 0x3130770
	|-List<AnimatorClipInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x321C300 Offset: 0x321C401 VA: 0x321C300
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|
	|-RVA: 0x321F3C0 Offset: 0x321F4C1 VA: 0x321F3C0
	|-List<BoneWeight>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3222720 Offset: 0x3222821 VA: 0x3222720
	|-List<Bounds>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3225A70 Offset: 0x3225B71 VA: 0x3225A70
	|-List<BoundsInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3228D50 Offset: 0x3228E51 VA: 0x3228D50
	|-List<Color32>.System.Collections.IList.set_Item
	|
	|-RVA: 0x322BD30 Offset: 0x322BE31 VA: 0x322BD30
	|-List<Color>.System.Collections.IList.set_Item
	|
	|-RVA: 0x322EF20 Offset: 0x322F021 VA: 0x322EF20
	|-List<CombineInstance>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3232AC0 Offset: 0x3232BC1 VA: 0x3232AC0
	|-List<RaycastResult>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3236260 Offset: 0x3236361 VA: 0x3236260
	|-List<GradientAlphaKey>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3239300 Offset: 0x3239401 VA: 0x3239300
	|-List<GradientColorKey>.System.Collections.IList.set_Item
	|
	|-RVA: 0x323C6A0 Offset: 0x323C7A1 VA: 0x323C6A0
	|-List<Keyframe>.System.Collections.IList.set_Item
	|
	|-RVA: 0x323FAD0 Offset: 0x323FBD1 VA: 0x323FAD0
	|-List<LayerMask>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3242B70 Offset: 0x3242C71 VA: 0x3242B70
	|-List<Matrix4x4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3246200 Offset: 0x3246301 VA: 0x3246200
	|-List<ParticleSystem.Particle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3249600 Offset: 0x3249701 VA: 0x3249600
	|-List<Playable>.System.Collections.IList.set_Item
	|
	|-RVA: 0x324C6A0 Offset: 0x324C7A1 VA: 0x324C6A0
	|-List<PlayableBinding>.System.Collections.IList.set_Item
	|
	|-RVA: 0x324F9C0 Offset: 0x324FAC1 VA: 0x324F9C0
	|-List<PlayableGraph>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32529E0 Offset: 0x3252AE1 VA: 0x32529E0
	|-List<Edge>.System.Collections.IList.set_Item
	|
	|-RVA: 0x32559A0 Offset: 0x3255AA1 VA: 0x32559A0
	|-List<Quaternion>.System.Collections.IList.set_Item
	|
	|-RVA: 0x3258A10 Offset: 0x3258B11 VA: 0x3258A10
	|-List<RangeInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x325BA80 Offset: 0x325BB81 VA: 0x325BA80
	|-List<RaycastHit2D>.System.Collections.IList.set_Item
	|
	|-RVA: 0x325EFF0 Offset: 0x325F0F1 VA: 0x325EFF0
	|-List<RaycastHit>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33C0DE0 Offset: 0x33C0EE1 VA: 0x33C0DE0
	|-List<Rect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33C3E40 Offset: 0x33C3F41 VA: 0x33C3E40
	|-List<RectInt>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33C6E60 Offset: 0x33C6F61 VA: 0x33C6E60
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33CA040 Offset: 0x33CA141 VA: 0x33CA040
	|-List<SphericalHarmonicsL2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33CDBF0 Offset: 0x33CDCF1 VA: 0x33CDBF0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33D0C90 Offset: 0x33D0D91 VA: 0x33D0C90
	|-List<AsyncOperationHandle>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33D4030 Offset: 0x33D4131 VA: 0x33D4030
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33D7410 Offset: 0x33D7511 VA: 0x33D7410
	|-List<DiagnosticEvent>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33DA990 Offset: 0x33DAA91 VA: 0x33DA990
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x33DDD80 Offset: 0x33DDE81 VA: 0x33DDD80
	|-List<ObjectInitializationData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31B91C0 Offset: 0x31B92C1 VA: 0x31B91C0
	|-List<GlyphRect>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31BC290 Offset: 0x31BC391 VA: 0x31BC290
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31BF730 Offset: 0x31BF831 VA: 0x31BF730
	|-List<IntervalTreeNode>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31C2A90 Offset: 0x31C2B91 VA: 0x31C2A90
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31C5E30 Offset: 0x31C5F31 VA: 0x31C5E30
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31C9160 Offset: 0x31C9261 VA: 0x31C9160
	|-List<UICharInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31CC1D0 Offset: 0x31CC2D1 VA: 0x31CC1D0
	|-List<FocusController.FocusedElement>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31CF200 Offset: 0x31CF301 VA: 0x31CF200
	|-List<UILineInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31D2360 Offset: 0x31D2461 VA: 0x31D2360
	|-List<UIVertex>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31D5CA0 Offset: 0x31D5DA1 VA: 0x31D5CA0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x31D8FB0 Offset: 0x31D90B1 VA: 0x31D8FB0
	|-List<Vector2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CE1BF0 Offset: 0x2CE1CF1 VA: 0x2CE1BF0
	|-List<Vector2Int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CE4BB0 Offset: 0x2CE4CB1 VA: 0x2CE4BB0
	|-List<Vector3>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CE7C30 Offset: 0x2CE7D31 VA: 0x2CE7C30
	|-List<Vector3Int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CEACF0 Offset: 0x2CEADF1 VA: 0x2CEACF0
	|-List<Vector4>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CEDF10 Offset: 0x2CEE011 VA: 0x2CEDF10
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CF1A70 Offset: 0x2CF1B71 VA: 0x2CF1A70
	|-List<YieldItemParam>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2CF4AA0 Offset: 0x2CF4BA1 VA: 0x2CF4AA0
	|-List<stCommand_t>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327B830 Offset: 0x327B931 VA: 0x327B830
	|-List<AIInput>.Add
	|-List<AS_MagicController>.Add
	|-List<ActionBehaviorCommandBase>.Add
	|-List<ActionBehaviorCommandInformation>.Add
	|-List<ActionCommandBase>.Add
	|-List<Actor>.Add
	|-List<ActorController>.Add
	|-List<AdvShowOneImage.AdvSpriteLoader>.Add
	|-List<AdvShowOneImage>.Add
	|-List<AracneFlatWeb>.Add
	|-List<AttackCollider>.Add
	|-List<AudmuraCrystal>.Add
	|-List<AutomaticLOD.LODLevelData>.Add
	|-List<AutomaticLOD>.Add
	|-List<BaffamoDodgeManager.BaffamoMonster>.Add
	|-List<BasiliskController.WearFireController>.Add
	|-List<BehaviorManager.BehaviorThreadLoader>.Add
	|-List<BehaviorManager.BehaviorTree.ConditionalReevaluate>.Add
	|-List<BehaviorManager.BehaviorTree>.Add
	|-List<SharedVariable>.Add
	|-List<TaskCoroutine>.Add
	|-List<Task>.Add
	|-List<BehaviorTreeManager.EnemyBehaviorParameter>.Add
	|-List<BgmList>.Add
	|-List<BitBase>.Add
	|-List<BodyPartsCollision>.Add
	|-List<BossBehaviorParams>.Add
	|-List<BulletBase>.Add
	|-List<ButtonLinker>.Add
	|-List<CameraManager.CameraControllerPair>.Add
	|-List<CerberusController.DogParam>.Add
	|-List<Character>.Add
	|-List<CharacterBase>.Add
	|-List<CheerVoiceData>.Add
	|-List<ChildData>.Add
	|-List<ChoiceImage>.Add
	|-List<CinemachineBrain.BrainFrame>.Add
	|-List<CinemachineComponentBase>.Add
	|-List<CinemachineExtension>.Add
	|-List<CinemachineImpulseManager.ImpulseEvent>.Add
	|-List<CinemachineStoryboard.CanvasInfo>.Add
	|-List<CinemachineVirtualCameraBase>.Add
	|-List<ColliderStreamer>.Add
	|-List<CombinedMesh.MaterialMeshInfo>.Add
	|-List<CombinedMesh.ObjectInfo>.Add
	|-List<VariableBase>.Add
	|-List<CursorEvent>.Add
	|-List<ABSSequentiable>.Add
	|-List<Tween>.Add
	|-List<TweenCallback>.Add
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>.Add
	|-List<DamageText>.Add
	|-List<DateSlotControl>.Add
	|-List<DeadtreeController.ChestnutController>.Add
	|-List<DynamicBone.Particle>.Add
	|-List<DynamicBoneH.Particle>.Add
	|-List<EnvironmentSoundArea>.Add
	|-List<EnvironmentSoundDataTable>.Add
	|-List<EraseObject>.Add
	|-List<EventFlagManager.RequestDisableEventPointData>.Add
	|-List<EventStartData>.Add
	|-List<EventUnlockFlagData>.Add
	|-List<FarmCropData>.Add
	|-List<FarmSupportMonsterController>.Add
	|-List<FarmSupportMonsterData>.Add
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>.Add
	|-List<FesNpcScore>.Add
	|-List<FestivalSnowball>.Add
	|-List<ObjectLoader>.Add
	|-List<FishRecord>.Add
	|-List<FishSwim>.Add
	|-List<FishingPoint>.Add
	|-List<FracturedChunk.AdjacencyInfo>.Add
	|-List<FracturedChunk>.Add
	|-List<FriendJudgmentManager.FriendJudgmentMonster>.Add
	|-List<FriendMonsterManager.FarmInActorData>.Add
	|-List<FriendMonsterStatusData>.Add
	|-List<LightningRenderer>.Add
	|-List<LightningSpawnArea>.Add
	|-List<ProfileGroupDefinition>.Add
	|-List<RainSplashRenderer>.Add
	|-List<WeatherEnclosure>.Add
	|-List<GateSeasonInfomation>.Add
	|-List<GateTimeZoneMonsterInfomation>.Add
	|-List<HUDDualWorkSelectInput.DualSelect>.Add
	|-List<HUDMinimapControl.RectImage>.Add
	|-List<HasibirokouSonicWind>.Add
	|-List<HateController.HateParameter>.Add
	|-List<HoldItemController.ItemModel>.Add
	|-List<HumanController>.Add
	|-List<InosisiController.ThornsController>.Add
	|-List<ItemData>.Add
	|-List<ItemDataLinker>.Add
	|-List<FurnitureSaveData>.Add
	|-List<PlayerItemFurniture2>.Add
	|-List<ItemIconMng.ImageLoaderObj>.Add
	|-List<ItemIconMng.SpriteWork>.Add
	|-List<ItemMoveToBasket>.Add
	|-List<ItemStorage>.Add
	|-List<ItemTool>.Add
	|-List<ItemWeightData>.Add
	|-List<KrakenStickController>.Add
	|-List<KyubiController.FireballParameter>.Add
	|-List<LastBossBone>.Add
	|-List<LifeCycleAdvData>.Add
	|-List<AssetHandle>.Add
	|-List<AssetInfo>.Add
	|-List<MeshSimplify>.Add
	|-List<ObjectSerializationInfo.EmittableMemberAndConstructorParameter>.Add
	|-List<MiningPoint>.Add
	|-List<MobBrain>.Add
	|-List<Contraction>.Add
	|-List<Level2Map>.Add
	|-List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.Add
	|-List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>.Add
	|-List<MonsterAnimatorStateEvent.NormalizeTimeEvent>.Add
	|-List<MonsterBehaviorController.BehaviorActionParam>.Add
	|-List<MonsterControllerBase.DropItemDataParameter>.Add
	|-List<MonsterControllerBase>.Add
	|-List<MonsterHutController.OrderFarmInParameter>.Add
	|-List<MonsterProjectileActionScriptsController>.Add
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.Add
	|-List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>.Add
	|-List<NpcController>.Add
	|-List<NpcLifeCycleDataRecord>.Add
	|-List<NpcPatrolPoint>.Add
	|-List<NpcPatrolPointData>.Add
	|-List<NpcSaveParameter>.Add
	|-List<NpcTimeAction>.Add
	|-List<ObjectPooler.Pool>.Add
	|-List<OnGroundItem>.Add
	|-List<OrderData>.Add
	|-List<OrderHUDBlock>.Add
	|-List<OrderMasterData>.Add
	|-List<OrderPopControl.StockDoOrder>.Add
	|-List<PartnerManager.DestinationAngle>.Add
	|-List<PartnerManager.NPCChangeBaseParameter>.Add
	|-List<PartnerManager.PartnerSearchRange>.Add
	|-List<PartnerMonsterBehaviorController>.Add
	|-List<PartyMonster>.Add
	|-List<PlayerSkillBase>.Add
	|-List<Contour>.Add
	|-List<DTSweepConstraint>.Add
	|-List<DelaunayTriangle>.Add
	|-List<EdgeIntersectInfo>.Add
	|-List<Point2D>.Add
	|-List<Point2DList>.Add
	|-List<Polygon>.Add
	|-List<PolygonPoint>.Add
	|-List<SplitComplexPolygonNode>.Add
	|-List<TriangulationConstraint>.Add
	|-List<TriangulationPoint>.Add
	|-List<PreloadHandle>.Add
	|-List<QuestIconData>.Add
	|-List<FishShipmentRecords>.Add
	|-List<SeedLevelRecords>.Add
	|-List<ShipmentItemRecords>.Add
	|-List<SeedShopItemDataTable.SeedShopItemData>.Add
	|-List<ShopItem>.Add
	|-List<RF5Streamer>.Add
	|-List<SubtitleHandler>.Add
	|-List<ButtonHintBlock>.Add
	|-List<UIEMCustomizeSet>.Add
	|-List<WantedData>.Add
	|-List<SEController>.Add
	|-List<RandomData>.Add
	|-List<RecipeDataDispBlock>.Add
	|-List<RecipeDataTableArray.RecipeDataTable>.Add
	|-List<RecipeGroupBase>.Add
	|-List<MP4FileProcessing.Chunk>.Add
	|-List<ReviatanIcePillar>.Add
	|-List<InteractionTarget>.Add
	|-List<InteractionTrigger>.Add
	|-List<InfoEntry>.Add
	|-List<OptionDefinition>.Add
	|-List<Settings.KeyboardShortcut>.Add
	|-List<OptionsControlBase>.Add
	|-List<OptionsTabController.CategoryInstance>.Add
	|-List<SRServiceManager.ServiceStub>.Add
	|-List<TimelineToActionScriptExpoter.ActionScriptData>.Add
	|-List<SceneSplit>.Add
	|-List<SceneTransitionManager.GameObjectEnabled>.Add
	|-List<SceneTransitionManager.SceneGameObjectEnabled>.Add
	|-List<SearchCharacterController.SearchParameter>.Add
	|-List<SimpleAnimation.EditorState>.Add
	|-List<SimpleAnimationPlayable.StateInfo>.Add
	|-List<SnowmanManager.Mocomoco>.Add
	|-List<CubicBezierCurve>.Add
	|-List<ExtrusionSegment.Vertex>.Add
	|-List<MeshVertex>.Add
	|-List<SplineNode>.Add
	|-List<TrackSegment>.Add
	|-List<Streamer>.Add
	|-List<SubEventData>.Add
	|-List<SubEventMasterDataBase>.Add
	|-List<Action>.Add
	|-List<AggregateException>.Add
	|-List<byte[]>.Add
	|-List<Dictionary<int, Vector3>>.Add
	|-List<IList<string>>.Add
	|-List<List<ActionBehaviorCommandInformation>>.Add
	|-List<List<CinemachineVirtualCameraBase>>.Add
	|-List<List<FarmCropData>>.Add
	|-List<List<Point2D>>.Add
	|-List<List<PolygonPoint>>.Add
	|-List<List<int>>.Add
	|-List<List<object>>.Add
	|-List<List<Renderer>>.Add
	|-List<List<Vector2>>.Add
	|-List<List<Vector3>>.Add
	|-List<Stack<int>>.Add
	|-List<StackFrame>.Add
	|-List<Exception>.Add
	|-List<Func<FocusInterface>>.Add
	|-List<Directory.SearchData>.Add
	|-List<int[]>.Add
	|-List<Expression>.Add
	|-List<BranchLabel>.Add
	|-List<ByRefUpdater>.Add
	|-List<DebugInfo>.Add
	|-List<ExceptionHandler>.Add
	|-List<Instruction>.Add
	|-List<LabelScopeInfo>.Add
	|-List<LocalVariables.VariableScope>.Add
	|-List<ParameterExpression>.Add
	|-List<LocalDataStore>.Add
	|-List<ModifierSpec>.Add
	|-List<IPAddress>.Add
	|-List<MonoChunkStream.Chunk>.Add
	|-List<WebConnection>.Add
	|-List<WebConnectionGroup>.Add
	|-List<object>.Add
	|-List<Assembly>.Add
	|-List<FieldInfo>.Add
	|-List<MethodBase>.Add
	|-List<MethodInfo>.Add
	|-List<Module>.Add
	|-List<ExceptionDispatchInfo>.Add
	|-List<IContextProperty>.Add
	|-List<SerializationFieldInfo>.Add
	|-List<X509CertificateImpl>.Add
	|-List<string>.Add
	|-List<string[]>.Add
	|-List<RegexCharClass.SingleRange>.Add
	|-List<RegexNode>.Add
	|-List<StringBuilder>.Add
	|-List<Task>.Add
	|-List<Thread>.Add
	|-List<Timer>.Add
	|-List<TimeZoneInfo.AdjustmentRule>.Add
	|-List<TimeZoneInfo>.Add
	|-List<Type>.Add
	|-List<TypeIdentifier>.Add
	|-List<TypeSpec>.Add
	|-List<WeakReference>.Add
	|-List<SystemTextDisp>.Add
	|-List<KerningPair>.Add
	|-List<TMP_Character>.Add
	|-List<TMP_Dropdown.DropdownItem>.Add
	|-List<TMP_Dropdown.OptionData>.Add
	|-List<TMP_FontAsset>.Add
	|-List<TMP_GlyphPairAdjustmentRecord>.Add
	|-List<TMP_MaterialManager.FallbackMaterial>.Add
	|-List<TMP_MaterialManager.MaskingMaterial>.Add
	|-List<TMP_SpriteCharacter>.Add
	|-List<TMP_SpriteGlyph>.Add
	|-List<TMP_Style>.Add
	|-List<TMP_Text>.Add
	|-List<TimeManager.JustTimerData>.Add
	|-List<TimelineMsg>.Add
	|-List<ToolInteractionInterface>.Add
	|-List<UIFadeOnOffAnimate.ImageGroup>.Add
	|-List<UIItemBoxWindowOpenButton>.Add
	|-List<UIItemSlot>.Add
	|-List<UIOnOffAnimate>.Add
	|-List<UIOrderBoardMenu.OrderList>.Add
	|-List<DynamicsSetup.ParseMessage>.Add
	|-List<SpringBone>.Add
	|-List<SpringBoneSerialization.PivotSerializer>.Add
	|-List<SpringBoneSerialization.SpringBoneSerializer>.Add
	|-List<SpringColliderSerialization.IColliderSerializer>.Add
	|-List<SpringColliderSerialization.TransformSerializer>.Add
	|-List<TextRecordParsing.Record>.Add
	|-List<MeshData>.Add
	|-List<MeshFaceConnectivity.TriangleData>.Add
	|-List<SupportPlane>.Add
	|-List<VertexData>.Add
	|-List<MeshUniqueVertices.RepeatedVertex>.Add
	|-List<MeshUniqueVertices.SerializableBoneWeight>.Add
	|-List<Simplifier.Triangle>.Add
	|-List<Simplifier.Vertex>.Add
	|-List<UltimateRope.RopeBone>.Add
	|-List<UltimateRope.RopeNode>.Add
	|-List<NavMeshLink>.Add
	|-List<NavMeshModifier>.Add
	|-List<NavMeshModifierVolume>.Add
	|-List<NavMeshSurface>.Add
	|-List<AddressablesImpl.ResourceLocatorInfo>.Add
	|-List<IResourceLocator>.Add
	|-List<AnimationClip>.Add
	|-List<Camera>.Add
	|-List<Collider>.Add
	|-List<BaseRaycaster>.Add
	|-List<EventSystem>.Add
	|-List<EventTrigger.Entry>.Add
	|-List<PointerInputModule.ButtonState>.Add
	|-List<BaseInvokableCall>.Add
	|-List<UnityEvent>.Add
	|-List<GUILayoutEntry>.Add
	|-List<GameObject>.Add
	|-List<ISubsystem>.Add
	|-List<ISubsystemDescriptor>.Add
	|-List<ISubsystemDescriptorImpl>.Add
	|-List<Light>.Add
	|-List<Material>.Add
	|-List<PlayerEditorConnectionEvents.MessageTypeSubscribers>.Add
	|-List<UnityWebRequestAsyncOperation>.Add
	|-List<ParticleSystem>.Add
	|-List<RectTransform>.Add
	|-List<RenderTexture>.Add
	|-List<Renderer>.Add
	|-List<AsyncOperationHandle<SceneInstance>[]>.Add
	|-List<IAsyncOperation>.Add
	|-List<IUpdateReceiver>.Add
	|-List<IResourceLocation>.Add
	|-List<ResourceManager.InstanceOperation>.Add
	|-List<ScriptableObject>.Add
	|-List<SkinnedMeshRenderer>.Add
	|-List<Sprite>.Add
	|-List<Terrain>.Add
	|-List<Glyph>.Add
	|-List<Texture2D>.Add
	|-List<AnimationTrack>.Add
	|-List<IMarker>.Add
	|-List<ITimelineEvaluateCallback>.Add
	|-List<RuntimeElement>.Add
	|-List<SignalAsset>.Add
	|-List<TimelineClip>.Add
	|-List<TrackAsset>.Add
	|-List<Transform>.Add
	|-List<Dropdown.DropdownItem>.Add
	|-List<Dropdown.OptionData>.Add
	|-List<Graphic>.Add
	|-List<ICanvasElement>.Add
	|-List<Image>.Add
	|-List<RectMask2D>.Add
	|-List<StencilMaterial.MatEntry>.Add
	|-List<Toggle>.Add
	|-List<IEventDispatchingStrategy>.Add
	|-List<IEventHandler>.Add
	|-List<Panel>.Add
	|-List<VisualElement>.Add
	|-List<UpPointData>.Add
	|-List<SplineControlPoint>.Add
	|-List<XWeaponTrail.Element>.Add
	|
	|-RVA: 0x248CE70 Offset: 0x248CF71 VA: 0x248CE70
	|-List<AS_ToolController.ChargeInfo>.Add
	|
	|-RVA: 0x336D8A0 Offset: 0x336D9A1 VA: 0x336D8A0
	|-List<BeanID>.Add
	|-List<TaskStatus>.Add
	|-List<CraftCategoryId>.Add
	|-List<ActorID>.Add
	|-List<Alliance>.Add
	|-List<BadStatus>.Add
	|-List<BulletID>.Add
	|-List<DLCID>.Add
	|-List<EmotionType>.Add
	|-List<FarmFieldWorkArea>.Add
	|-List<GameFlagData>.Add
	|-List<MakingID>.Add
	|-List<NPCID>.Add
	|-List<PoliceBatchId>.Add
	|-List<StorageType>.Add
	|-List<VariationNo>.Add
	|-List<ItemID>.Add
	|-List<Prefab>.Add
	|-List<Texture>.Add
	|-List<LovePointManager.FavoriteType>.Add
	|-List<MonsterActionBehaviorType>.Add
	|-List<MonsterDataID>.Add
	|-List<MonsterModelDataID>.Add
	|-List<NpcSearchCollider.VoiceType>.Add
	|-List<PartnerNPCActionBehaviorType>.Add
	|-List<RecipeId>.Add
	|-List<SoundID>.Add
	|-List<Int32Enum>.Add
	|-List<RegexOptions>.Add
	|-List<UINamingWindow.NamingId>.Add
	|-List<ParticleSystemVertexStream>.Add
	|
	|-RVA: 0x2490370 Offset: 0x2490471 VA: 0x2490370
	|-List<BuildItemData>.Add
	|
	|-RVA: 0x3156490 Offset: 0x3156591 VA: 0x3156490
	|-List<ButtonLinker.LinkObject>.Add
	|
	|-RVA: 0x31594D0 Offset: 0x31595D1 VA: 0x31594D0
	|-List<CharaCallTable.BustupTable>.Add
	|
	|-RVA: 0x315C500 Offset: 0x315C601 VA: 0x315C500
	|-List<CharaCallTable.CharaFaceIconTable>.Add
	|
	|-RVA: 0x315F5B0 Offset: 0x315F6B1 VA: 0x315F5B0
	|-List<CameraState.CustomBlendable>.Add
	|
	|-RVA: 0x31625F0 Offset: 0x31626F1 VA: 0x31625F0
	|-List<CinemachineClearShot.Pair>.Add
	|
	|-RVA: 0x31655A0 Offset: 0x31656A1 VA: 0x31655A0
	|-List<CinemachineStateDrivenCamera.HashPair>.Add
	|
	|-RVA: 0x3168610 Offset: 0x3168711 VA: 0x3168610
	|-List<TargetPositionCache.CacheCurve.Item>.Add
	|
	|-RVA: 0x316BB00 Offset: 0x316BC01 VA: 0x316BB00
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Add
	|
	|-RVA: 0x316F070 Offset: 0x316F171 VA: 0x316F070
	|-List<CropDataTable>.Add
	|
	|-RVA: 0x3172560 Offset: 0x3172661 VA: 0x3172560
	|-List<DropItemParam>.Add
	|
	|-RVA: 0x3175590 Offset: 0x3175691 VA: 0x3175590
	|-List<ErosionBrush.UndoStep>.Add
	|
	|-RVA: 0x31DC220 Offset: 0x31DC321 VA: 0x31DC220
	|-List<EventCheckId>.Add
	|
	|-RVA: 0x31DF540 Offset: 0x31DF641 VA: 0x31DF540
	|-List<EventFlagProgressData>.Add
	|
	|-RVA: 0x31E2590 Offset: 0x31E2691 VA: 0x31E2590
	|-List<FesNpcScoreData>.Add
	|
	|-RVA: 0x31E56B0 Offset: 0x31E57B1 VA: 0x31E56B0
	|-List<MiningPointSaveData>.Add
	|
	|-RVA: 0x31E8C10 Offset: 0x31E8D11 VA: 0x31E8C10
	|-List<MonsterHutSaveData>.Add
	|
	|-RVA: 0x31EC060 Offset: 0x31EC161 VA: 0x31EC060
	|-List<MoviePlayer.SUBTITLEDATA>.Add
	|
	|-RVA: 0x31EF190 Offset: 0x31EF291 VA: 0x31EF190
	|-List<NPCActionData>.Add
	|
	|-RVA: 0x31F27F0 Offset: 0x31F28F1 VA: 0x31F27F0
	|-List<NpcPlaceSchedule>.Add
	|
	|-RVA: 0x31F5B20 Offset: 0x31F5C21 VA: 0x31F5B20
	|-List<OrderLotterySaveParameter>.Add
	|
	|-RVA: 0x31F8C50 Offset: 0x31F8D51 VA: 0x31F8C50
	|-List<OrderSaveParameter>.Add
	|
	|-RVA: 0x31FBF80 Offset: 0x31FC081 VA: 0x31FBF80
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Add
	|
	|-RVA: 0x330B1F0 Offset: 0x330B2F1 VA: 0x330B1F0
	|-List<ShopCatalogPage>.Add
	|
	|-RVA: 0x330E300 Offset: 0x330E401 VA: 0x330E300
	|-List<ShopNpcTalk>.Add
	|
	|-RVA: 0x3311800 Offset: 0x3311901 VA: 0x3311800
	|-List<SubtitleDataTable.Data>.Add
	|
	|-RVA: 0x33148B0 Offset: 0x33149B1 VA: 0x33148B0
	|-List<SubtitleDataTable.DataList>.Add
	|
	|-RVA: 0x3317890 Offset: 0x3317991 VA: 0x3317890
	|-List<SubtitleHudDataTable.Data>.Add
	|
	|-RVA: 0x331A9C0 Offset: 0x331AAC1 VA: 0x331A9C0
	|-List<SRMonoBehaviourEx.FieldInfo>.Add
	|
	|-RVA: 0x331DD60 Offset: 0x331DE61 VA: 0x331DD60
	|-List<Schedule>.Add
	|
	|-RVA: 0x3321180 Offset: 0x3321281 VA: 0x3321180
	|-List<CurveSample>.Add
	|
	|-RVA: 0x33248F0 Offset: 0x33249F1 VA: 0x33248F0
	|-List<bool>.Add
	|
	|-RVA: 0x33278E0 Offset: 0x33279E1 VA: 0x33278E0
	|-List<byte>.Add
	|
	|-RVA: 0x332A8B0 Offset: 0x332A9B1 VA: 0x332A8B0
	|-List<char>.Add
	|
	|-RVA: 0x3358900 Offset: 0x3358A01 VA: 0x3358900
	|-List<KeyValuePair<DateTime, object>>.Add
	|-List<KeyValuePair<DateTime, TimeType>>.Add
	|
	|-RVA: 0x335B950 Offset: 0x335BA51 VA: 0x335B950
	|-List<KeyValuePair<int, object>>.Add
	|
	|-RVA: 0x335E9A0 Offset: 0x335EAA1 VA: 0x335E9A0
	|-List<KeyValuePair<object, object>>.Add
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.Add
	|
	|-RVA: 0x33619E0 Offset: 0x3361AE1 VA: 0x33619E0
	|-List<DateTime>.Add
	|
	|-RVA: 0x3364980 Offset: 0x3364A81 VA: 0x3364980
	|-List<double>.Add
	|
	|-RVA: 0x3367940 Offset: 0x3367A41 VA: 0x3367940
	|-List<short>.Add
	|
	|-RVA: 0x336A8F0 Offset: 0x336A9F1 VA: 0x336A8F0
	|-List<int>.Add
	|
	|-RVA: 0x3370850 Offset: 0x3370951 VA: 0x3370850
	|-List<long>.Add
	|
	|-RVA: 0x3373800 Offset: 0x3373901 VA: 0x3373800
	|-List<InterpretedFrameInfo>.Add
	|
	|-RVA: 0x3376820 Offset: 0x3376921 VA: 0x3376820
	|-List<Nullable<Int32Enum>>.Add
	|
	|-RVA: 0x3405580 Offset: 0x3405681 VA: 0x3405580
	|-List<Nullable<Bounds>>.Add
	|
	|-RVA: 0x3408B40 Offset: 0x3408C41 VA: 0x3408B40
	|-List<Nullable<BoundsInt>>.Add
	|
	|-RVA: 0x340C030 Offset: 0x340C131 VA: 0x340C030
	|-List<Nullable<Color32>>.Add
	|
	|-RVA: 0x340F0C0 Offset: 0x340F1C1 VA: 0x340F0C0
	|-List<Nullable<Color>>.Add
	|
	|-RVA: 0x34124A0 Offset: 0x34125A1 VA: 0x34124A0
	|-List<Nullable<GradientAlphaKey>>.Add
	|
	|-RVA: 0x3415640 Offset: 0x3415741 VA: 0x3415640
	|-List<Nullable<GradientColorKey>>.Add
	|
	|-RVA: 0x3418A90 Offset: 0x3418B91 VA: 0x3418A90
	|-List<Nullable<Keyframe>>.Add
	|
	|-RVA: 0x341BE60 Offset: 0x341BF61 VA: 0x341BE60
	|-List<Nullable<LayerMask>>.Add
	|
	|-RVA: 0x341EFC0 Offset: 0x341F0C1 VA: 0x341EFC0
	|-List<Nullable<Matrix4x4>>.Add
	|
	|-RVA: 0x3422930 Offset: 0x3422A31 VA: 0x3422930
	|-List<Nullable<Quaternion>>.Add
	|
	|-RVA: 0x3262780 Offset: 0x3262881 VA: 0x3262780
	|-List<Nullable<RangeInt>>.Add
	|
	|-RVA: 0x3265920 Offset: 0x3265A21 VA: 0x3265920
	|-List<Nullable<Rect>>.Add
	|
	|-RVA: 0x3268D80 Offset: 0x3268E81 VA: 0x3268D80
	|-List<Nullable<RectInt>>.Add
	|
	|-RVA: 0x326C160 Offset: 0x326C261 VA: 0x326C160
	|-List<Nullable<Vector2>>.Add
	|
	|-RVA: 0x326F280 Offset: 0x326F381 VA: 0x326F280
	|-List<Nullable<Vector2Int>>.Add
	|
	|-RVA: 0x3272380 Offset: 0x3272481 VA: 0x3272380
	|-List<Nullable<Vector3>>.Add
	|
	|-RVA: 0x32753F0 Offset: 0x32754F1 VA: 0x32753F0
	|-List<Nullable<Vector3Int>>.Add
	|
	|-RVA: 0x3278500 Offset: 0x3278601 VA: 0x3278500
	|-List<Nullable<Vector4>>.Add
	|
	|-RVA: 0x327E820 Offset: 0x327E921 VA: 0x327E820
	|-List<sbyte>.Add
	|
	|-RVA: 0x32817E0 Offset: 0x32818E1 VA: 0x32817E0
	|-List<float>.Add
	|
	|-RVA: 0x32A8A50 Offset: 0x32A8B51 VA: 0x32A8A50
	|-List<ushort>.Add
	|
	|-RVA: 0x32ABA00 Offset: 0x32ABB01 VA: 0x32ABA00
	|-List<uint>.Add
	|
	|-RVA: 0x32AE9B0 Offset: 0x32AEAB1 VA: 0x32AE9B0
	|-List<ulong>.Add
	|
	|-RVA: 0x32C0990 Offset: 0x32C0A91 VA: 0x32C0990
	|-List<ValueTuple<CharacterBase, float>>.Add
	|-List<ValueTuple<object, float>>.Add
	|
	|-RVA: 0x32B78C0 Offset: 0x32B79C1 VA: 0x32B78C0
	|-List<ValueTuple<SoundID, EnvironmentSoundController>>.Add
	|-List<ValueTuple<Int32Enum, object>>.Add
	|
	|-RVA: 0x32B1960 Offset: 0x32B1A61 VA: 0x32B1960
	|-List<ValueTuple<bool, Int32Enum>>.Add
	|
	|-RVA: 0x32B4910 Offset: 0x32B4A11 VA: 0x32B4910
	|-List<ValueTuple<Int32Enum, int>>.Add
	|
	|-RVA: 0x32BA910 Offset: 0x32BAA11 VA: 0x32BA910
	|-List<ValueTuple<object, Int32Enum>>.Add
	|
	|-RVA: 0x32BD950 Offset: 0x32BDA51 VA: 0x32BD950
	|-List<ValueTuple<object, object>>.Add
	|
	|-RVA: 0x32C39E0 Offset: 0x32C3AE1 VA: 0x32C39E0
	|-List<ValueTuple<CharID, VariationNo, HairType>>.Add
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Add
	|
	|-RVA: 0x32C6B80 Offset: 0x32C6C81 VA: 0x32C6B80
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Add
	|-List<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>.Add
	|
	|-RVA: 0x31107E0 Offset: 0x31108E1 VA: 0x31107E0
	|-List<TexturePacker_JsonArray.Frame>.Add
	|
	|-RVA: 0x3113DF0 Offset: 0x3113EF1 VA: 0x3113DF0
	|-List<TutorialUnlockFlagData>.Add
	|
	|-RVA: 0x3116EA0 Offset: 0x3116FA1 VA: 0x3116EA0
	|-List<UIMainManagerAttachObject.AttachSet>.Add
	|
	|-RVA: 0x3119FC0 Offset: 0x311A0C1 VA: 0x3119FC0
	|-List<CapEdge>.Add
	|
	|-RVA: 0x311D450 Offset: 0x311D551 VA: 0x311D450
	|-List<MeshDataConnectivity.Face>.Add
	|
	|-RVA: 0x3120470 Offset: 0x3120571 VA: 0x3120470
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Add
	|
	|-RVA: 0x3123820 Offset: 0x3123921 VA: 0x3123820
	|-List<MeshFaceConnectivity.EdgeData>.Add
	|
	|-RVA: 0x3126D00 Offset: 0x3126E01 VA: 0x3126D00
	|-List<NavMeshBuildMarkup>.Add
	|
	|-RVA: 0x3129ED0 Offset: 0x3129FD1 VA: 0x3129ED0
	|-List<NavMeshBuildSource>.Add
	|
	|-RVA: 0x312D8F0 Offset: 0x312D9F1 VA: 0x312D8F0
	|-List<ConstraintSource>.Add
	|
	|-RVA: 0x3130930 Offset: 0x3130A31 VA: 0x3130930
	|-List<AnimatorClipInfo>.Add
	|
	|-RVA: 0x321C4C0 Offset: 0x321C5C1 VA: 0x321C4C0
	|-List<BeforeRenderHelper.OrderBlock>.Add
	|
	|-RVA: 0x321F580 Offset: 0x321F681 VA: 0x321F580
	|-List<BoneWeight>.Add
	|
	|-RVA: 0x32228E0 Offset: 0x32229E1 VA: 0x32228E0
	|-List<Bounds>.Add
	|
	|-RVA: 0x3225C30 Offset: 0x3225D31 VA: 0x3225C30
	|-List<BoundsInt>.Add
	|
	|-RVA: 0x3228F10 Offset: 0x3229011 VA: 0x3228F10
	|-List<Color32>.Add
	|
	|-RVA: 0x322BEF0 Offset: 0x322BFF1 VA: 0x322BEF0
	|-List<Color>.Add
	|
	|-RVA: 0x322F110 Offset: 0x322F211 VA: 0x322F110
	|-List<CombineInstance>.Add
	|
	|-RVA: 0x3232CA0 Offset: 0x3232DA1 VA: 0x3232CA0
	|-List<RaycastResult>.Add
	|
	|-RVA: 0x3236420 Offset: 0x3236521 VA: 0x3236420
	|-List<GradientAlphaKey>.Add
	|
	|-RVA: 0x32394C0 Offset: 0x32395C1 VA: 0x32394C0
	|-List<GradientColorKey>.Add
	|
	|-RVA: 0x323C870 Offset: 0x323C971 VA: 0x323C870
	|-List<Keyframe>.Add
	|
	|-RVA: 0x323FC90 Offset: 0x323FD91 VA: 0x323FC90
	|-List<LayerMask>.Add
	|
	|-RVA: 0x3242D40 Offset: 0x3242E41 VA: 0x3242D40
	|-List<Matrix4x4>.Add
	|
	|-RVA: 0x32463C0 Offset: 0x32464C1 VA: 0x32463C0
	|-List<ParticleSystem.Particle>.Add
	|
	|-RVA: 0x32497C0 Offset: 0x32498C1 VA: 0x32497C0
	|-List<Playable>.Add
	|
	|-RVA: 0x324C860 Offset: 0x324C961 VA: 0x324C860
	|-List<PlayableBinding>.Add
	|
	|-RVA: 0x324FB80 Offset: 0x324FC81 VA: 0x324FB80
	|-List<PlayableGraph>.Add
	|
	|-RVA: 0x3252BA0 Offset: 0x3252CA1 VA: 0x3252BA0
	|-List<Edge>.Add
	|
	|-RVA: 0x3255B60 Offset: 0x3255C61 VA: 0x3255B60
	|-List<Quaternion>.Add
	|
	|-RVA: 0x3258BD0 Offset: 0x3258CD1 VA: 0x3258BD0
	|-List<RangeInt>.Add
	|
	|-RVA: 0x325BC50 Offset: 0x325BD51 VA: 0x325BC50
	|-List<RaycastHit2D>.Add
	|
	|-RVA: 0x325F1C0 Offset: 0x325F2C1 VA: 0x325F1C0
	|-List<RaycastHit>.Add
	|
	|-RVA: 0x33C0FA0 Offset: 0x33C10A1 VA: 0x33C0FA0
	|-List<Rect>.Add
	|
	|-RVA: 0x33C4000 Offset: 0x33C4101 VA: 0x33C4000
	|-List<RectInt>.Add
	|
	|-RVA: 0x33C7020 Offset: 0x33C7121 VA: 0x33C7020
	|-List<ReflectionProbeBlendInfo>.Add
	|
	|-RVA: 0x33CA230 Offset: 0x33CA331 VA: 0x33CA230
	|-List<SphericalHarmonicsL2>.Add
	|
	|-RVA: 0x33CDDB0 Offset: 0x33CDEB1 VA: 0x33CDDB0
	|-List<VertexAttributeDescriptor>.Add
	|
	|-RVA: 0x33D0E50 Offset: 0x33D0F51 VA: 0x33D0E50
	|-List<AsyncOperationHandle>.Add
	|
	|-RVA: 0x33D41F0 Offset: 0x33D42F1 VA: 0x33D41F0
	|-List<AsyncOperationHandle<SceneInstance>>.Add
	|
	|-RVA: 0x33D75E0 Offset: 0x33D76E1 VA: 0x33D75E0
	|-List<DiagnosticEvent>.Add
	|
	|-RVA: 0x33DAB50 Offset: 0x33DAC51 VA: 0x33DAB50
	|-List<DelayedActionManager.DelegateInfo>.Add
	|
	|-RVA: 0x33DDF50 Offset: 0x33DE051 VA: 0x33DDF50
	|-List<ObjectInitializationData>.Add
	|
	|-RVA: 0x31B9380 Offset: 0x31B9481 VA: 0x31B9380
	|-List<GlyphRect>.Add
	|
	|-RVA: 0x31BC460 Offset: 0x31BC561 VA: 0x31BC460
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Add
	|
	|-RVA: 0x31BF8F0 Offset: 0x31BF9F1 VA: 0x31BF8F0
	|-List<IntervalTreeNode>.Add
	|
	|-RVA: 0x31C2C50 Offset: 0x31C2D51 VA: 0x31C2C50
	|-List<IntervalTree.Entry<object>>.Add
	|
	|-RVA: 0x31C5FF0 Offset: 0x31C60F1 VA: 0x31C5FF0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Add
	|
	|-RVA: 0x31C9320 Offset: 0x31C9421 VA: 0x31C9320
	|-List<UICharInfo>.Add
	|
	|-RVA: 0x31CC390 Offset: 0x31CC491 VA: 0x31CC390
	|-List<FocusController.FocusedElement>.Add
	|
	|-RVA: 0x31CF3C0 Offset: 0x31CF4C1 VA: 0x31CF3C0
	|-List<UILineInfo>.Add
	|
	|-RVA: 0x31D2540 Offset: 0x31D2641 VA: 0x31D2540
	|-List<UIVertex>.Add
	|
	|-RVA: 0x31D5E60 Offset: 0x31D5F61 VA: 0x31D5E60
	|-List<UnitySynchronizationContext.WorkRequest>.Add
	|
	|-RVA: 0x31D9170 Offset: 0x31D9271 VA: 0x31D9170
	|-List<Vector2>.Add
	|
	|-RVA: 0x2CE1DB0 Offset: 0x2CE1EB1 VA: 0x2CE1DB0
	|-List<Vector2Int>.Add
	|
	|-RVA: 0x2CE4D70 Offset: 0x2CE4E71 VA: 0x2CE4D70
	|-List<Vector3>.Add
	|
	|-RVA: 0x2CE7DF0 Offset: 0x2CE7EF1 VA: 0x2CE7DF0
	|-List<Vector3Int>.Add
	|
	|-RVA: 0x2CEAEB0 Offset: 0x2CEAFB1 VA: 0x2CEAEB0
	|-List<Vector4>.Add
	|
	|-RVA: 0x2CEE100 Offset: 0x2CEE201 VA: 0x2CEE100
	|-List<WarpPoints.WarpPoint>.Add
	|
	|-RVA: 0x2CF1C30 Offset: 0x2CF1D31 VA: 0x2CF1C30
	|-List<YieldItemParam>.Add
	|
	|-RVA: 0x2CF4C60 Offset: 0x2CF4D61 VA: 0x2CF4C60
	|-List<stCommand_t>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248CF50 Offset: 0x248D051 VA: 0x248CF50
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x24904F0 Offset: 0x24905F1 VA: 0x24904F0
	|-List<BuildItemData>.System.Collections.IList.Add
	|
	|-RVA: 0x3156550 Offset: 0x3156651 VA: 0x3156550
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.Add
	|
	|-RVA: 0x3159580 Offset: 0x3159681 VA: 0x3159580
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.Add
	|
	|-RVA: 0x315C5C0 Offset: 0x315C6C1 VA: 0x315C5C0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Add
	|
	|-RVA: 0x315F670 Offset: 0x315F771 VA: 0x315F670
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Add
	|
	|-RVA: 0x3162690 Offset: 0x3162791 VA: 0x3162690
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Add
	|
	|-RVA: 0x3165640 Offset: 0x3165741 VA: 0x3165640
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Add
	|
	|-RVA: 0x3168700 Offset: 0x3168801 VA: 0x3168700
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Add
	|
	|-RVA: 0x316BC00 Offset: 0x316BD01 VA: 0x316BC00
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Add
	|
	|-RVA: 0x316F160 Offset: 0x316F261 VA: 0x316F160
	|-List<CropDataTable>.System.Collections.IList.Add
	|
	|-RVA: 0x3172600 Offset: 0x3172701 VA: 0x3172600
	|-List<DropItemParam>.System.Collections.IList.Add
	|
	|-RVA: 0x3175670 Offset: 0x3175771 VA: 0x3175670
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.Add
	|
	|-RVA: 0x31DC300 Offset: 0x31DC401 VA: 0x31DC300
	|-List<EventCheckId>.System.Collections.IList.Add
	|
	|-RVA: 0x31DF600 Offset: 0x31DF701 VA: 0x31DF600
	|-List<EventFlagProgressData>.System.Collections.IList.Add
	|
	|-RVA: 0x31E2650 Offset: 0x31E2751 VA: 0x31E2650
	|-List<FesNpcScoreData>.System.Collections.IList.Add
	|
	|-RVA: 0x31E57B0 Offset: 0x31E58B1 VA: 0x31E57B0
	|-List<MiningPointSaveData>.System.Collections.IList.Add
	|
	|-RVA: 0x31E8D10 Offset: 0x31E8E11 VA: 0x31E8D10
	|-List<MonsterHutSaveData>.System.Collections.IList.Add
	|
	|-RVA: 0x31EC120 Offset: 0x31EC221 VA: 0x31EC120
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Add
	|
	|-RVA: 0x31EF290 Offset: 0x31EF391 VA: 0x31EF290
	|-List<NPCActionData>.System.Collections.IList.Add
	|
	|-RVA: 0x31F28D0 Offset: 0x31F29D1 VA: 0x31F28D0
	|-List<NpcPlaceSchedule>.System.Collections.IList.Add
	|
	|-RVA: 0x31F5BE0 Offset: 0x31F5CE1 VA: 0x31F5BE0
	|-List<OrderLotterySaveParameter>.System.Collections.IList.Add
	|
	|-RVA: 0x31F8D30 Offset: 0x31F8E31 VA: 0x31F8D30
	|-List<OrderSaveParameter>.System.Collections.IList.Add
	|
	|-RVA: 0x31FC040 Offset: 0x31FC141 VA: 0x31FC040
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Add
	|
	|-RVA: 0x330B2B0 Offset: 0x330B3B1 VA: 0x330B2B0
	|-List<ShopCatalogPage>.System.Collections.IList.Add
	|
	|-RVA: 0x330E400 Offset: 0x330E501 VA: 0x330E400
	|-List<ShopNpcTalk>.System.Collections.IList.Add
	|
	|-RVA: 0x33118C0 Offset: 0x33119C1 VA: 0x33118C0
	|-List<SubtitleDataTable.Data>.System.Collections.IList.Add
	|
	|-RVA: 0x3314960 Offset: 0x3314A61 VA: 0x3314960
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.Add
	|
	|-RVA: 0x3317950 Offset: 0x3317A51 VA: 0x3317950
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.Add
	|
	|-RVA: 0x331AAA0 Offset: 0x331ABA1 VA: 0x331AAA0
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x331DE30 Offset: 0x331DF31 VA: 0x331DE30
	|-List<Schedule>.System.Collections.IList.Add
	|
	|-RVA: 0x33212A0 Offset: 0x33213A1 VA: 0x33212A0
	|-List<CurveSample>.System.Collections.IList.Add
	|
	|-RVA: 0x33249A0 Offset: 0x3324AA1 VA: 0x33249A0
	|-List<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x3327980 Offset: 0x3327A81 VA: 0x3327980
	|-List<byte>.System.Collections.IList.Add
	|
	|-RVA: 0x332A950 Offset: 0x332AA51 VA: 0x332A950
	|-List<char>.System.Collections.IList.Add
	|
	|-RVA: 0x33589C0 Offset: 0x3358AC1 VA: 0x33589C0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x335BA10 Offset: 0x335BB11 VA: 0x335BA10
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x335EA60 Offset: 0x335EB61 VA: 0x335EA60
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x3361A80 Offset: 0x3361B81 VA: 0x3361A80
	|-List<DateTime>.System.Collections.IList.Add
	|
	|-RVA: 0x3364A30 Offset: 0x3364B31 VA: 0x3364A30
	|-List<double>.System.Collections.IList.Add
	|
	|-RVA: 0x33679E0 Offset: 0x3367AE1 VA: 0x33679E0
	|-List<short>.System.Collections.IList.Add
	|
	|-RVA: 0x336A990 Offset: 0x336AA91 VA: 0x336A990
	|-List<int>.System.Collections.IList.Add
	|
	|-RVA: 0x336D940 Offset: 0x336DA41 VA: 0x336D940
	|-List<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x33708F0 Offset: 0x33709F1 VA: 0x33708F0
	|-List<long>.System.Collections.IList.Add
	|
	|-RVA: 0x33738C0 Offset: 0x33739C1 VA: 0x33738C0
	|-List<InterpretedFrameInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x33768C0 Offset: 0x33769C1 VA: 0x33768C0
	|-List<Nullable<Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x3405670 Offset: 0x3405771 VA: 0x3405670
	|-List<Nullable<Bounds>>.System.Collections.IList.Add
	|
	|-RVA: 0x3408C30 Offset: 0x3408D31 VA: 0x3408C30
	|-List<Nullable<BoundsInt>>.System.Collections.IList.Add
	|
	|-RVA: 0x340C0D0 Offset: 0x340C1D1 VA: 0x340C0D0
	|-List<Nullable<Color32>>.System.Collections.IList.Add
	|
	|-RVA: 0x340F190 Offset: 0x340F291 VA: 0x340F190
	|-List<Nullable<Color>>.System.Collections.IList.Add
	|
	|-RVA: 0x3412560 Offset: 0x3412661 VA: 0x3412560
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.Add
	|
	|-RVA: 0x3415710 Offset: 0x3415811 VA: 0x3415710
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.Add
	|
	|-RVA: 0x3418B60 Offset: 0x3418C61 VA: 0x3418B60
	|-List<Nullable<Keyframe>>.System.Collections.IList.Add
	|
	|-RVA: 0x341BF00 Offset: 0x341C001 VA: 0x341BF00
	|-List<Nullable<LayerMask>>.System.Collections.IList.Add
	|
	|-RVA: 0x341F0F0 Offset: 0x341F1F1 VA: 0x341F0F0
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.Add
	|
	|-RVA: 0x3422A00 Offset: 0x3422B01 VA: 0x3422A00
	|-List<Nullable<Quaternion>>.System.Collections.IList.Add
	|
	|-RVA: 0x3262840 Offset: 0x3262941 VA: 0x3262840
	|-List<Nullable<RangeInt>>.System.Collections.IList.Add
	|
	|-RVA: 0x32659F0 Offset: 0x3265AF1 VA: 0x32659F0
	|-List<Nullable<Rect>>.System.Collections.IList.Add
	|
	|-RVA: 0x3268E50 Offset: 0x3268F51 VA: 0x3268E50
	|-List<Nullable<RectInt>>.System.Collections.IList.Add
	|
	|-RVA: 0x326C220 Offset: 0x326C321 VA: 0x326C220
	|-List<Nullable<Vector2>>.System.Collections.IList.Add
	|
	|-RVA: 0x326F340 Offset: 0x326F441 VA: 0x326F340
	|-List<Nullable<Vector2Int>>.System.Collections.IList.Add
	|
	|-RVA: 0x3272430 Offset: 0x3272531 VA: 0x3272430
	|-List<Nullable<Vector3>>.System.Collections.IList.Add
	|
	|-RVA: 0x32754A0 Offset: 0x32755A1 VA: 0x32754A0
	|-List<Nullable<Vector3Int>>.System.Collections.IList.Add
	|
	|-RVA: 0x32785D0 Offset: 0x32786D1 VA: 0x32785D0
	|-List<Nullable<Vector4>>.System.Collections.IList.Add
	|
	|-RVA: 0x327B8E0 Offset: 0x327B9E1 VA: 0x327B8E0
	|-List<object>.System.Collections.IList.Add
	|
	|-RVA: 0x327E8C0 Offset: 0x327E9C1 VA: 0x327E8C0
	|-List<sbyte>.System.Collections.IList.Add
	|
	|-RVA: 0x3281890 Offset: 0x3281991 VA: 0x3281890
	|-List<float>.System.Collections.IList.Add
	|
	|-RVA: 0x32A8AF0 Offset: 0x32A8BF1 VA: 0x32A8AF0
	|-List<ushort>.System.Collections.IList.Add
	|
	|-RVA: 0x32ABAA0 Offset: 0x32ABBA1 VA: 0x32ABAA0
	|-List<uint>.System.Collections.IList.Add
	|
	|-RVA: 0x32AEA50 Offset: 0x32AEB51 VA: 0x32AEA50
	|-List<ulong>.System.Collections.IList.Add
	|
	|-RVA: 0x32B1A00 Offset: 0x32B1B01 VA: 0x32B1A00
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x32B49B0 Offset: 0x32B4AB1 VA: 0x32B49B0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x32B7980 Offset: 0x32B7A81 VA: 0x32B7980
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x32BA9D0 Offset: 0x32BAAD1 VA: 0x32BA9D0
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x32BDA10 Offset: 0x32BDB11 VA: 0x32BDA10
	|-List<ValueTuple<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x32C0A50 Offset: 0x32C0B51 VA: 0x32C0A50
	|-List<ValueTuple<object, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x32C3AA0 Offset: 0x32C3BA1 VA: 0x32C3AA0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Add
	|
	|-RVA: 0x32C6C90 Offset: 0x32C6D91 VA: 0x32C6C90
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x31108F0 Offset: 0x31109F1 VA: 0x31108F0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Add
	|
	|-RVA: 0x3113EB0 Offset: 0x3113FB1 VA: 0x3113EB0
	|-List<TutorialUnlockFlagData>.System.Collections.IList.Add
	|
	|-RVA: 0x3116F60 Offset: 0x3117061 VA: 0x3116F60
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Add
	|
	|-RVA: 0x311A0C0 Offset: 0x311A1C1 VA: 0x311A0C0
	|-List<CapEdge>.System.Collections.IList.Add
	|
	|-RVA: 0x311D4F0 Offset: 0x311D5F1 VA: 0x311D4F0
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.Add
	|
	|-RVA: 0x3120540 Offset: 0x3120641 VA: 0x3120540
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Add
	|
	|-RVA: 0x3123920 Offset: 0x3123A21 VA: 0x3123920
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Add
	|
	|-RVA: 0x3126DB0 Offset: 0x3126EB1 VA: 0x3126DB0
	|-List<NavMeshBuildMarkup>.System.Collections.IList.Add
	|
	|-RVA: 0x312A020 Offset: 0x312A121 VA: 0x312A020
	|-List<NavMeshBuildSource>.System.Collections.IList.Add
	|
	|-RVA: 0x312D9B0 Offset: 0x312DAB1 VA: 0x312D9B0
	|-List<ConstraintSource>.System.Collections.IList.Add
	|
	|-RVA: 0x31309D0 Offset: 0x3130AD1 VA: 0x31309D0
	|-List<AnimatorClipInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x321C580 Offset: 0x321C681 VA: 0x321C580
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|
	|-RVA: 0x321F650 Offset: 0x321F751 VA: 0x321F650
	|-List<BoneWeight>.System.Collections.IList.Add
	|
	|-RVA: 0x32229B0 Offset: 0x3222AB1 VA: 0x32229B0
	|-List<Bounds>.System.Collections.IList.Add
	|
	|-RVA: 0x3225D00 Offset: 0x3225E01 VA: 0x3225D00
	|-List<BoundsInt>.System.Collections.IList.Add
	|
	|-RVA: 0x3228FB0 Offset: 0x32290B1 VA: 0x3228FB0
	|-List<Color32>.System.Collections.IList.Add
	|
	|-RVA: 0x322BFC0 Offset: 0x322C0C1 VA: 0x322BFC0
	|-List<Color>.System.Collections.IList.Add
	|
	|-RVA: 0x322F260 Offset: 0x322F361 VA: 0x322F260
	|-List<CombineInstance>.System.Collections.IList.Add
	|
	|-RVA: 0x3232DD0 Offset: 0x3232ED1 VA: 0x3232DD0
	|-List<RaycastResult>.System.Collections.IList.Add
	|
	|-RVA: 0x32364D0 Offset: 0x32365D1 VA: 0x32364D0
	|-List<GradientAlphaKey>.System.Collections.IList.Add
	|
	|-RVA: 0x3239590 Offset: 0x3239691 VA: 0x3239590
	|-List<GradientColorKey>.System.Collections.IList.Add
	|
	|-RVA: 0x323C960 Offset: 0x323CA61 VA: 0x323C960
	|-List<Keyframe>.System.Collections.IList.Add
	|
	|-RVA: 0x323FD30 Offset: 0x323FE31 VA: 0x323FD30
	|-List<LayerMask>.System.Collections.IList.Add
	|
	|-RVA: 0x3242E40 Offset: 0x3242F41 VA: 0x3242E40
	|-List<Matrix4x4>.System.Collections.IList.Add
	|
	|-RVA: 0x32464A0 Offset: 0x32465A1 VA: 0x32464A0
	|-List<ParticleSystem.Particle>.System.Collections.IList.Add
	|
	|-RVA: 0x3249870 Offset: 0x3249971 VA: 0x3249870
	|-List<Playable>.System.Collections.IList.Add
	|
	|-RVA: 0x324C940 Offset: 0x324CA41 VA: 0x324C940
	|-List<PlayableBinding>.System.Collections.IList.Add
	|
	|-RVA: 0x324FC30 Offset: 0x324FD31 VA: 0x324FC30
	|-List<PlayableGraph>.System.Collections.IList.Add
	|
	|-RVA: 0x3252C40 Offset: 0x3252D41 VA: 0x3252C40
	|-List<Edge>.System.Collections.IList.Add
	|
	|-RVA: 0x3255C30 Offset: 0x3255D31 VA: 0x3255C30
	|-List<Quaternion>.System.Collections.IList.Add
	|
	|-RVA: 0x3258C70 Offset: 0x3258D71 VA: 0x3258C70
	|-List<RangeInt>.System.Collections.IList.Add
	|
	|-RVA: 0x325BD50 Offset: 0x325BE51 VA: 0x325BD50
	|-List<RaycastHit2D>.System.Collections.IList.Add
	|
	|-RVA: 0x325F2C0 Offset: 0x325F3C1 VA: 0x325F2C0
	|-List<RaycastHit>.System.Collections.IList.Add
	|
	|-RVA: 0x33C1070 Offset: 0x33C1171 VA: 0x33C1070
	|-List<Rect>.System.Collections.IList.Add
	|
	|-RVA: 0x33C40B0 Offset: 0x33C41B1 VA: 0x33C40B0
	|-List<RectInt>.System.Collections.IList.Add
	|
	|-RVA: 0x33C70E0 Offset: 0x33C71E1 VA: 0x33C70E0
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x33CA390 Offset: 0x33CA491 VA: 0x33CA390
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Add
	|
	|-RVA: 0x33CDE60 Offset: 0x33CDF61 VA: 0x33CDE60
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Add
	|
	|-RVA: 0x33D0F30 Offset: 0x33D1031 VA: 0x33D0F30
	|-List<AsyncOperationHandle>.System.Collections.IList.Add
	|
	|-RVA: 0x33D42D0 Offset: 0x33D43D1 VA: 0x33D42D0
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Add
	|
	|-RVA: 0x33D76E0 Offset: 0x33D77E1 VA: 0x33D76E0
	|-List<DiagnosticEvent>.System.Collections.IList.Add
	|
	|-RVA: 0x33DAC30 Offset: 0x33DAD31 VA: 0x33DAC30
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x33DE050 Offset: 0x33DE151 VA: 0x33DE050
	|-List<ObjectInitializationData>.System.Collections.IList.Add
	|
	|-RVA: 0x31B9430 Offset: 0x31B9531 VA: 0x31B9430
	|-List<GlyphRect>.System.Collections.IList.Add
	|
	|-RVA: 0x31BC550 Offset: 0x31BC651 VA: 0x31BC550
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x31BF9C0 Offset: 0x31BFAC1 VA: 0x31BF9C0
	|-List<IntervalTreeNode>.System.Collections.IList.Add
	|
	|-RVA: 0x31C2D30 Offset: 0x31C2E31 VA: 0x31C2D30
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Add
	|
	|-RVA: 0x31C60D0 Offset: 0x31C61D1 VA: 0x31C60D0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x31C93F0 Offset: 0x31C94F1 VA: 0x31C93F0
	|-List<UICharInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x31CC450 Offset: 0x31CC551 VA: 0x31CC450
	|-List<FocusController.FocusedElement>.System.Collections.IList.Add
	|
	|-RVA: 0x31CF470 Offset: 0x31CF571 VA: 0x31CF470
	|-List<UILineInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x31D2670 Offset: 0x31D2771 VA: 0x31D2670
	|-List<UIVertex>.System.Collections.IList.Add
	|
	|-RVA: 0x31D5F40 Offset: 0x31D6041 VA: 0x31D5F40
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x31D9220 Offset: 0x31D9321 VA: 0x31D9220
	|-List<Vector2>.System.Collections.IList.Add
	|
	|-RVA: 0x2CE1E50 Offset: 0x2CE1F51 VA: 0x2CE1E50
	|-List<Vector2Int>.System.Collections.IList.Add
	|
	|-RVA: 0x2CE4E40 Offset: 0x2CE4F41 VA: 0x2CE4E40
	|-List<Vector3>.System.Collections.IList.Add
	|
	|-RVA: 0x2CE7EB0 Offset: 0x2CE7FB1 VA: 0x2CE7EB0
	|-List<Vector3Int>.System.Collections.IList.Add
	|
	|-RVA: 0x2CEAF80 Offset: 0x2CEB081 VA: 0x2CEAF80
	|-List<Vector4>.System.Collections.IList.Add
	|
	|-RVA: 0x2CEE280 Offset: 0x2CEE381 VA: 0x2CEE280
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.Add
	|
	|-RVA: 0x2CF1CD0 Offset: 0x2CF1DD1 VA: 0x2CF1CD0
	|-List<YieldItemParam>.System.Collections.IList.Add
	|
	|-RVA: 0x2CF4D40 Offset: 0x2CF4E41 VA: 0x2CF4D40
	|-List<stCommand_t>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D130 Offset: 0x248D231 VA: 0x248D130
	|-List<AS_ToolController.ChargeInfo>.AddRange
	|
	|-RVA: 0x2490700 Offset: 0x2490801 VA: 0x2490700
	|-List<BuildItemData>.AddRange
	|
	|-RVA: 0x327BAA0 Offset: 0x327BBA1 VA: 0x327BAA0
	|-List<BulletColliderBase>.AddRange
	|-List<EnvironmentSoundDataTable>.AddRange
	|-List<CellController>.AddRange
	|-List<FarmCropData>.AddRange
	|-List<GateSeasonInfomation>.AddRange
	|-List<GateTimeZoneMonsterInfomation>.AddRange
	|-List<ItemData>.AddRange
	|-List<ItemDataLinker>.AddRange
	|-List<MonsterActionInformation>.AddRange
	|-List<MonsterControllerBase.DropItemDataParameter>.AddRange
	|-List<PartyBase>.AddRange
	|-List<DelaunayTriangle>.AddRange
	|-List<Point2D>.AddRange
	|-List<TriangulationPoint>.AddRange
	|-List<SeedShopItemDataTable.SeedShopItemData>.AddRange
	|-List<OptionDefinition>.AddRange
	|-List<RF5ThumbnailData>.AddRange
	|-List<Streamer>.AddRange
	|-List<object>.AddRange
	|-List<ExceptionDispatchInfo>.AddRange
	|-List<string>.AddRange
	|-List<TimeZoneInfo.AdjustmentRule>.AddRange
	|-List<TimeZoneInfo>.AddRange
	|-List<Type>.AddRange
	|-List<TMP_Dropdown.OptionData>.AddRange
	|-List<DynamicsSetup.ParseMessage>.AddRange
	|-List<SpringBoneSerialization.PivotSerializer>.AddRange
	|-List<SpringBoneSerialization.SpringBoneSerializer>.AddRange
	|-List<SpringColliderSerialization.IColliderSerializer>.AddRange
	|-List<SpringColliderSerialization.TransformSerializer>.AddRange
	|-List<MeshData>.AddRange
	|-List<VertexData>.AddRange
	|-List<NavMeshObstacle>.AddRange
	|-List<Collider>.AddRange
	|-List<BaseInvokableCall>.AddRange
	|-List<IAnimationWindowPreview>.AddRange
	|-List<Material>.AddRange
	|-List<ParticleSystem>.AddRange
	|-List<Renderer>.AddRange
	|-List<IResourceLocation>.AddRange
	|-List<Terrain>.AddRange
	|-List<IMarker>.AddRange
	|-List<TimelineClip>.AddRange
	|-List<TrackAsset>.AddRange
	|-List<Dropdown.OptionData>.AddRange
	|-List<EventCallbackFunctorBase>.AddRange
	|-List<VisualElement>.AddRange
	|
	|-RVA: 0x3156710 Offset: 0x3156811 VA: 0x3156710
	|-List<ButtonLinker.LinkObject>.AddRange
	|
	|-RVA: 0x3159740 Offset: 0x3159841 VA: 0x3159740
	|-List<CharaCallTable.BustupTable>.AddRange
	|
	|-RVA: 0x315C790 Offset: 0x315C891 VA: 0x315C790
	|-List<CharaCallTable.CharaFaceIconTable>.AddRange
	|
	|-RVA: 0x315F830 Offset: 0x315F931 VA: 0x315F830
	|-List<CameraState.CustomBlendable>.AddRange
	|
	|-RVA: 0x3162850 Offset: 0x3162951 VA: 0x3162850
	|-List<CinemachineClearShot.Pair>.AddRange
	|
	|-RVA: 0x3165800 Offset: 0x3165901 VA: 0x3165800
	|-List<CinemachineStateDrivenCamera.HashPair>.AddRange
	|
	|-RVA: 0x31688E0 Offset: 0x31689E1 VA: 0x31688E0
	|-List<TargetPositionCache.CacheCurve.Item>.AddRange
	|
	|-RVA: 0x316BDF0 Offset: 0x316BEF1 VA: 0x316BDF0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.AddRange
	|
	|-RVA: 0x316F340 Offset: 0x316F441 VA: 0x316F340
	|-List<CropDataTable>.AddRange
	|
	|-RVA: 0x336DB00 Offset: 0x336DC01 VA: 0x336DB00
	|-List<ClothShopID>.AddRange
	|-List<HotSpringID>.AddRange
	|-List<RecipePanShopID>.AddRange
	|-List<VaccinationID>.AddRange
	|-List<ItemID>.AddRange
	|-List<MonsterActionBehaviorType>.AddRange
	|-List<Int32Enum>.AddRange
	|
	|-RVA: 0x31727C0 Offset: 0x31728C1 VA: 0x31727C0
	|-List<DropItemParam>.AddRange
	|
	|-RVA: 0x3175850 Offset: 0x3175951 VA: 0x3175850
	|-List<ErosionBrush.UndoStep>.AddRange
	|
	|-RVA: 0x31DC4E0 Offset: 0x31DC5E1 VA: 0x31DC4E0
	|-List<EventCheckId>.AddRange
	|
	|-RVA: 0x31DF7C0 Offset: 0x31DF8C1 VA: 0x31DF7C0
	|-List<EventFlagProgressData>.AddRange
	|
	|-RVA: 0x31E2810 Offset: 0x31E2911 VA: 0x31E2810
	|-List<FesNpcScoreData>.AddRange
	|
	|-RVA: 0x31E59A0 Offset: 0x31E5AA1 VA: 0x31E59A0
	|-List<MiningPointSaveData>.AddRange
	|
	|-RVA: 0x31E8EF0 Offset: 0x31E8FF1 VA: 0x31E8EF0
	|-List<MonsterHutSaveData>.AddRange
	|
	|-RVA: 0x31EC2E0 Offset: 0x31EC3E1 VA: 0x31EC2E0
	|-List<MoviePlayer.SUBTITLEDATA>.AddRange
	|
	|-RVA: 0x31EF480 Offset: 0x31EF581 VA: 0x31EF480
	|-List<NPCActionData>.AddRange
	|
	|-RVA: 0x31F2AB0 Offset: 0x31F2BB1 VA: 0x31F2AB0
	|-List<NpcPlaceSchedule>.AddRange
	|
	|-RVA: 0x31F5DB0 Offset: 0x31F5EB1 VA: 0x31F5DB0
	|-List<OrderLotterySaveParameter>.AddRange
	|
	|-RVA: 0x31F8F10 Offset: 0x31F9011 VA: 0x31F8F10
	|-List<OrderSaveParameter>.AddRange
	|
	|-RVA: 0x31FC200 Offset: 0x31FC301 VA: 0x31FC200
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.AddRange
	|
	|-RVA: 0x330B470 Offset: 0x330B571 VA: 0x330B470
	|-List<ShopCatalogPage>.AddRange
	|
	|-RVA: 0x330E5E0 Offset: 0x330E6E1 VA: 0x330E5E0
	|-List<ShopNpcTalk>.AddRange
	|
	|-RVA: 0x3311A90 Offset: 0x3311B91 VA: 0x3311A90
	|-List<SubtitleDataTable.Data>.AddRange
	|
	|-RVA: 0x3314B20 Offset: 0x3314C21 VA: 0x3314B20
	|-List<SubtitleDataTable.DataList>.AddRange
	|
	|-RVA: 0x3317B20 Offset: 0x3317C21 VA: 0x3317B20
	|-List<SubtitleHudDataTable.Data>.AddRange
	|
	|-RVA: 0x331AC80 Offset: 0x331AD81 VA: 0x331AC80
	|-List<SRMonoBehaviourEx.FieldInfo>.AddRange
	|
	|-RVA: 0x331E010 Offset: 0x331E111 VA: 0x331E010
	|-List<Schedule>.AddRange
	|
	|-RVA: 0x3321490 Offset: 0x3321591 VA: 0x3321490
	|-List<CurveSample>.AddRange
	|
	|-RVA: 0x3324B60 Offset: 0x3324C61 VA: 0x3324B60
	|-List<bool>.AddRange
	|
	|-RVA: 0x3327B40 Offset: 0x3327C41 VA: 0x3327B40
	|-List<byte>.AddRange
	|
	|-RVA: 0x332AB10 Offset: 0x332AC11 VA: 0x332AB10
	|-List<char>.AddRange
	|
	|-RVA: 0x3358B80 Offset: 0x3358C81 VA: 0x3358B80
	|-List<KeyValuePair<DateTime, object>>.AddRange
	|
	|-RVA: 0x335BBD0 Offset: 0x335BCD1 VA: 0x335BBD0
	|-List<KeyValuePair<int, object>>.AddRange
	|
	|-RVA: 0x335EC20 Offset: 0x335ED21 VA: 0x335EC20
	|-List<KeyValuePair<object, object>>.AddRange
	|
	|-RVA: 0x3361C40 Offset: 0x3361D41 VA: 0x3361C40
	|-List<DateTime>.AddRange
	|
	|-RVA: 0x3364BF0 Offset: 0x3364CF1 VA: 0x3364BF0
	|-List<double>.AddRange
	|
	|-RVA: 0x3367BA0 Offset: 0x3367CA1 VA: 0x3367BA0
	|-List<short>.AddRange
	|
	|-RVA: 0x336AB50 Offset: 0x336AC51 VA: 0x336AB50
	|-List<int>.AddRange
	|
	|-RVA: 0x3370AB0 Offset: 0x3370BB1 VA: 0x3370AB0
	|-List<long>.AddRange
	|
	|-RVA: 0x3373A80 Offset: 0x3373B81 VA: 0x3373A80
	|-List<InterpretedFrameInfo>.AddRange
	|
	|-RVA: 0x3376A70 Offset: 0x3376B71 VA: 0x3376A70
	|-List<Nullable<Int32Enum>>.AddRange
	|
	|-RVA: 0x3405840 Offset: 0x3405941 VA: 0x3405840
	|-List<Nullable<Bounds>>.AddRange
	|
	|-RVA: 0x3408E00 Offset: 0x3408F01 VA: 0x3408E00
	|-List<Nullable<BoundsInt>>.AddRange
	|
	|-RVA: 0x340C280 Offset: 0x340C381 VA: 0x340C280
	|-List<Nullable<Color32>>.AddRange
	|
	|-RVA: 0x340F360 Offset: 0x340F461 VA: 0x340F360
	|-List<Nullable<Color>>.AddRange
	|
	|-RVA: 0x3412710 Offset: 0x3412811 VA: 0x3412710
	|-List<Nullable<GradientAlphaKey>>.AddRange
	|
	|-RVA: 0x34158E0 Offset: 0x34159E1 VA: 0x34158E0
	|-List<Nullable<GradientColorKey>>.AddRange
	|
	|-RVA: 0x3418D30 Offset: 0x3418E31 VA: 0x3418D30
	|-List<Nullable<Keyframe>>.AddRange
	|
	|-RVA: 0x341C0B0 Offset: 0x341C1B1 VA: 0x341C0B0
	|-List<Nullable<LayerMask>>.AddRange
	|
	|-RVA: 0x341F2D0 Offset: 0x341F3D1 VA: 0x341F2D0
	|-List<Nullable<Matrix4x4>>.AddRange
	|
	|-RVA: 0x3422BD0 Offset: 0x3422CD1 VA: 0x3422BD0
	|-List<Nullable<Quaternion>>.AddRange
	|
	|-RVA: 0x32629F0 Offset: 0x3262AF1 VA: 0x32629F0
	|-List<Nullable<RangeInt>>.AddRange
	|
	|-RVA: 0x3265BC0 Offset: 0x3265CC1 VA: 0x3265BC0
	|-List<Nullable<Rect>>.AddRange
	|
	|-RVA: 0x3269020 Offset: 0x3269121 VA: 0x3269020
	|-List<Nullable<RectInt>>.AddRange
	|
	|-RVA: 0x326C3D0 Offset: 0x326C4D1 VA: 0x326C3D0
	|-List<Nullable<Vector2>>.AddRange
	|
	|-RVA: 0x326F4F0 Offset: 0x326F5F1 VA: 0x326F4F0
	|-List<Nullable<Vector2Int>>.AddRange
	|
	|-RVA: 0x32725E0 Offset: 0x32726E1 VA: 0x32725E0
	|-List<Nullable<Vector3>>.AddRange
	|
	|-RVA: 0x3275650 Offset: 0x3275751 VA: 0x3275650
	|-List<Nullable<Vector3Int>>.AddRange
	|
	|-RVA: 0x32787A0 Offset: 0x32788A1 VA: 0x32787A0
	|-List<Nullable<Vector4>>.AddRange
	|
	|-RVA: 0x327EA80 Offset: 0x327EB81 VA: 0x327EA80
	|-List<sbyte>.AddRange
	|
	|-RVA: 0x3281A50 Offset: 0x3281B51 VA: 0x3281A50
	|-List<float>.AddRange
	|
	|-RVA: 0x32A8CB0 Offset: 0x32A8DB1 VA: 0x32A8CB0
	|-List<ushort>.AddRange
	|
	|-RVA: 0x32ABC60 Offset: 0x32ABD61 VA: 0x32ABC60
	|-List<uint>.AddRange
	|
	|-RVA: 0x32AEC10 Offset: 0x32AED11 VA: 0x32AEC10
	|-List<ulong>.AddRange
	|
	|-RVA: 0x32B1BC0 Offset: 0x32B1CC1 VA: 0x32B1BC0
	|-List<ValueTuple<bool, ItemID>>.AddRange
	|-List<ValueTuple<bool, Int32Enum>>.AddRange
	|
	|-RVA: 0x32B4B70 Offset: 0x32B4C71 VA: 0x32B4B70
	|-List<ValueTuple<Int32Enum, int>>.AddRange
	|
	|-RVA: 0x32B7B40 Offset: 0x32B7C41 VA: 0x32B7B40
	|-List<ValueTuple<Int32Enum, object>>.AddRange
	|
	|-RVA: 0x32BAB90 Offset: 0x32BAC91 VA: 0x32BAB90
	|-List<ValueTuple<object, Int32Enum>>.AddRange
	|
	|-RVA: 0x32BDBD0 Offset: 0x32BDCD1 VA: 0x32BDBD0
	|-List<ValueTuple<object, object>>.AddRange
	|
	|-RVA: 0x32C0C10 Offset: 0x32C0D11 VA: 0x32C0C10
	|-List<ValueTuple<object, float>>.AddRange
	|
	|-RVA: 0x32C3C70 Offset: 0x32C3D71 VA: 0x32C3C70
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.AddRange
	|
	|-RVA: 0x32C6E80 Offset: 0x32C6F81 VA: 0x32C6E80
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.AddRange
	|
	|-RVA: 0x3110AE0 Offset: 0x3110BE1 VA: 0x3110AE0
	|-List<TexturePacker_JsonArray.Frame>.AddRange
	|
	|-RVA: 0x3114080 Offset: 0x3114181 VA: 0x3114080
	|-List<TutorialUnlockFlagData>.AddRange
	|
	|-RVA: 0x3117120 Offset: 0x3117221 VA: 0x3117120
	|-List<UIMainManagerAttachObject.AttachSet>.AddRange
	|
	|-RVA: 0x311A2B0 Offset: 0x311A3B1 VA: 0x311A2B0
	|-List<CapEdge>.AddRange
	|
	|-RVA: 0x311D6B0 Offset: 0x311D7B1 VA: 0x311D6B0
	|-List<MeshDataConnectivity.Face>.AddRange
	|
	|-RVA: 0x3120720 Offset: 0x3120821 VA: 0x3120720
	|-List<MeshFaceConnectivity.EdgeData.SideData>.AddRange
	|
	|-RVA: 0x3123B00 Offset: 0x3123C01 VA: 0x3123B00
	|-List<MeshFaceConnectivity.EdgeData>.AddRange
	|
	|-RVA: 0x3126F70 Offset: 0x3127071 VA: 0x3126F70
	|-List<NavMeshBuildMarkup>.AddRange
	|
	|-RVA: 0x312A220 Offset: 0x312A321 VA: 0x312A220
	|-List<NavMeshBuildSource>.AddRange
	|
	|-RVA: 0x312DB70 Offset: 0x312DC71 VA: 0x312DB70
	|-List<ConstraintSource>.AddRange
	|
	|-RVA: 0x3130B90 Offset: 0x3130C91 VA: 0x3130B90
	|-List<AnimatorClipInfo>.AddRange
	|
	|-RVA: 0x321C740 Offset: 0x321C841 VA: 0x321C740
	|-List<BeforeRenderHelper.OrderBlock>.AddRange
	|
	|-RVA: 0x321F830 Offset: 0x321F931 VA: 0x321F830
	|-List<BoneWeight>.AddRange
	|
	|-RVA: 0x3222B90 Offset: 0x3222C91 VA: 0x3222B90
	|-List<Bounds>.AddRange
	|
	|-RVA: 0x3225EE0 Offset: 0x3225FE1 VA: 0x3225EE0
	|-List<BoundsInt>.AddRange
	|
	|-RVA: 0x3229170 Offset: 0x3229271 VA: 0x3229170
	|-List<Color32>.AddRange
	|
	|-RVA: 0x322C190 Offset: 0x322C291 VA: 0x322C190
	|-List<Color>.AddRange
	|
	|-RVA: 0x322F460 Offset: 0x322F561 VA: 0x322F460
	|-List<CombineInstance>.AddRange
	|
	|-RVA: 0x3232FC0 Offset: 0x32330C1 VA: 0x3232FC0
	|-List<RaycastResult>.AddRange
	|
	|-RVA: 0x3236690 Offset: 0x3236791 VA: 0x3236690
	|-List<GradientAlphaKey>.AddRange
	|
	|-RVA: 0x3239770 Offset: 0x3239871 VA: 0x3239770
	|-List<GradientColorKey>.AddRange
	|
	|-RVA: 0x323CB40 Offset: 0x323CC41 VA: 0x323CB40
	|-List<Keyframe>.AddRange
	|
	|-RVA: 0x323FEF0 Offset: 0x323FFF1 VA: 0x323FEF0
	|-List<LayerMask>.AddRange
	|
	|-RVA: 0x3243030 Offset: 0x3243131 VA: 0x3243030
	|-List<Matrix4x4>.AddRange
	|
	|-RVA: 0x3246680 Offset: 0x3246781 VA: 0x3246680
	|-List<ParticleSystem.Particle>.AddRange
	|
	|-RVA: 0x3249A30 Offset: 0x3249B31 VA: 0x3249A30
	|-List<Playable>.AddRange
	|
	|-RVA: 0x324CB20 Offset: 0x324CC21 VA: 0x324CB20
	|-List<PlayableBinding>.AddRange
	|
	|-RVA: 0x324FDF0 Offset: 0x324FEF1 VA: 0x324FDF0
	|-List<PlayableGraph>.AddRange
	|
	|-RVA: 0x3252E00 Offset: 0x3252F01 VA: 0x3252E00
	|-List<Edge>.AddRange
	|
	|-RVA: 0x3255E00 Offset: 0x3255F01 VA: 0x3255E00
	|-List<Quaternion>.AddRange
	|
	|-RVA: 0x3258E30 Offset: 0x3258F31 VA: 0x3258E30
	|-List<RangeInt>.AddRange
	|
	|-RVA: 0x325BF40 Offset: 0x325C041 VA: 0x325BF40
	|-List<RaycastHit2D>.AddRange
	|
	|-RVA: 0x325F4B0 Offset: 0x325F5B1 VA: 0x325F4B0
	|-List<RaycastHit>.AddRange
	|
	|-RVA: 0x33C1240 Offset: 0x33C1341 VA: 0x33C1240
	|-List<Rect>.AddRange
	|
	|-RVA: 0x33C4270 Offset: 0x33C4371 VA: 0x33C4270
	|-List<RectInt>.AddRange
	|
	|-RVA: 0x33C72A0 Offset: 0x33C73A1 VA: 0x33C72A0
	|-List<ReflectionProbeBlendInfo>.AddRange
	|
	|-RVA: 0x33CA5A0 Offset: 0x33CA6A1 VA: 0x33CA5A0
	|-List<SphericalHarmonicsL2>.AddRange
	|
	|-RVA: 0x33CE020 Offset: 0x33CE121 VA: 0x33CE020
	|-List<VertexAttributeDescriptor>.AddRange
	|
	|-RVA: 0x33D1110 Offset: 0x33D1211 VA: 0x33D1110
	|-List<AsyncOperationHandle>.AddRange
	|
	|-RVA: 0x33D44B0 Offset: 0x33D45B1 VA: 0x33D44B0
	|-List<AsyncOperationHandle<SceneInstance>>.AddRange
	|
	|-RVA: 0x33D78C0 Offset: 0x33D79C1 VA: 0x33D78C0
	|-List<DiagnosticEvent>.AddRange
	|
	|-RVA: 0x33DAE10 Offset: 0x33DAF11 VA: 0x33DAE10
	|-List<DelayedActionManager.DelegateInfo>.AddRange
	|
	|-RVA: 0x33DE230 Offset: 0x33DE331 VA: 0x33DE230
	|-List<ObjectInitializationData>.AddRange
	|
	|-RVA: 0x31B95F0 Offset: 0x31B96F1 VA: 0x31B95F0
	|-List<GlyphRect>.AddRange
	|
	|-RVA: 0x31BC730 Offset: 0x31BC831 VA: 0x31BC730
	|-List<AnimationOutputWeightProcessor.WeightInfo>.AddRange
	|
	|-RVA: 0x31BFBA0 Offset: 0x31BFCA1 VA: 0x31BFBA0
	|-List<IntervalTreeNode>.AddRange
	|
	|-RVA: 0x31C2F10 Offset: 0x31C3011 VA: 0x31C2F10
	|-List<IntervalTree.Entry<object>>.AddRange
	|
	|-RVA: 0x31C62B0 Offset: 0x31C63B1 VA: 0x31C62B0
	|-List<TimeNotificationBehaviour.NotificationEntry>.AddRange
	|
	|-RVA: 0x31C95C0 Offset: 0x31C96C1 VA: 0x31C95C0
	|-List<UICharInfo>.AddRange
	|
	|-RVA: 0x31CC610 Offset: 0x31CC711 VA: 0x31CC610
	|-List<FocusController.FocusedElement>.AddRange
	|
	|-RVA: 0x31CF630 Offset: 0x31CF731 VA: 0x31CF630
	|-List<UILineInfo>.AddRange
	|
	|-RVA: 0x31D2870 Offset: 0x31D2971 VA: 0x31D2870
	|-List<UIVertex>.AddRange
	|
	|-RVA: 0x31D6120 Offset: 0x31D6221 VA: 0x31D6120
	|-List<UnitySynchronizationContext.WorkRequest>.AddRange
	|
	|-RVA: 0x31D93E0 Offset: 0x31D94E1 VA: 0x31D93E0
	|-List<Vector2>.AddRange
	|
	|-RVA: 0x2CE2010 Offset: 0x2CE2111 VA: 0x2CE2010
	|-List<Vector2Int>.AddRange
	|
	|-RVA: 0x2CE5010 Offset: 0x2CE5111 VA: 0x2CE5010
	|-List<Vector3>.AddRange
	|
	|-RVA: 0x2CE8080 Offset: 0x2CE8181 VA: 0x2CE8080
	|-List<Vector3Int>.AddRange
	|
	|-RVA: 0x2CEB150 Offset: 0x2CEB251 VA: 0x2CEB150
	|-List<Vector4>.AddRange
	|
	|-RVA: 0x2CEE490 Offset: 0x2CEE591 VA: 0x2CEE490
	|-List<WarpPoints.WarpPoint>.AddRange
	|
	|-RVA: 0x2CF1E90 Offset: 0x2CF1F91 VA: 0x2CF1E90
	|-List<YieldItemParam>.AddRange
	|
	|-RVA: 0x2CF4F20 Offset: 0x2CF5021 VA: 0x2CF4F20
	|-List<stCommand_t>.AddRange
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327BAD0 Offset: 0x327BBD1 VA: 0x327BAD0
	|-List<CubicBezierCurve>.AsReadOnly
	|-List<object>.AsReadOnly
	|
	|-RVA: 0x248D160 Offset: 0x248D261 VA: 0x248D160
	|-List<AS_ToolController.ChargeInfo>.AsReadOnly
	|
	|-RVA: 0x2490730 Offset: 0x2490831 VA: 0x2490730
	|-List<BuildItemData>.AsReadOnly
	|
	|-RVA: 0x3156740 Offset: 0x3156841 VA: 0x3156740
	|-List<ButtonLinker.LinkObject>.AsReadOnly
	|
	|-RVA: 0x3159770 Offset: 0x3159871 VA: 0x3159770
	|-List<CharaCallTable.BustupTable>.AsReadOnly
	|
	|-RVA: 0x315C7C0 Offset: 0x315C8C1 VA: 0x315C7C0
	|-List<CharaCallTable.CharaFaceIconTable>.AsReadOnly
	|
	|-RVA: 0x315F860 Offset: 0x315F961 VA: 0x315F860
	|-List<CameraState.CustomBlendable>.AsReadOnly
	|
	|-RVA: 0x3162880 Offset: 0x3162981 VA: 0x3162880
	|-List<CinemachineClearShot.Pair>.AsReadOnly
	|
	|-RVA: 0x3165830 Offset: 0x3165931 VA: 0x3165830
	|-List<CinemachineStateDrivenCamera.HashPair>.AsReadOnly
	|
	|-RVA: 0x3168910 Offset: 0x3168A11 VA: 0x3168910
	|-List<TargetPositionCache.CacheCurve.Item>.AsReadOnly
	|
	|-RVA: 0x316BE20 Offset: 0x316BF21 VA: 0x316BE20
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.AsReadOnly
	|
	|-RVA: 0x316F370 Offset: 0x316F471 VA: 0x316F370
	|-List<CropDataTable>.AsReadOnly
	|
	|-RVA: 0x31727F0 Offset: 0x31728F1 VA: 0x31727F0
	|-List<DropItemParam>.AsReadOnly
	|
	|-RVA: 0x3175880 Offset: 0x3175981 VA: 0x3175880
	|-List<ErosionBrush.UndoStep>.AsReadOnly
	|
	|-RVA: 0x31DC510 Offset: 0x31DC611 VA: 0x31DC510
	|-List<EventCheckId>.AsReadOnly
	|
	|-RVA: 0x31DF7F0 Offset: 0x31DF8F1 VA: 0x31DF7F0
	|-List<EventFlagProgressData>.AsReadOnly
	|
	|-RVA: 0x31E2840 Offset: 0x31E2941 VA: 0x31E2840
	|-List<FesNpcScoreData>.AsReadOnly
	|
	|-RVA: 0x31E59D0 Offset: 0x31E5AD1 VA: 0x31E59D0
	|-List<MiningPointSaveData>.AsReadOnly
	|
	|-RVA: 0x31E8F20 Offset: 0x31E9021 VA: 0x31E8F20
	|-List<MonsterHutSaveData>.AsReadOnly
	|
	|-RVA: 0x31EC310 Offset: 0x31EC411 VA: 0x31EC310
	|-List<MoviePlayer.SUBTITLEDATA>.AsReadOnly
	|
	|-RVA: 0x31EF4B0 Offset: 0x31EF5B1 VA: 0x31EF4B0
	|-List<NPCActionData>.AsReadOnly
	|
	|-RVA: 0x31F2AE0 Offset: 0x31F2BE1 VA: 0x31F2AE0
	|-List<NpcPlaceSchedule>.AsReadOnly
	|
	|-RVA: 0x31F5DE0 Offset: 0x31F5EE1 VA: 0x31F5DE0
	|-List<OrderLotterySaveParameter>.AsReadOnly
	|
	|-RVA: 0x31F8F40 Offset: 0x31F9041 VA: 0x31F8F40
	|-List<OrderSaveParameter>.AsReadOnly
	|
	|-RVA: 0x31FC230 Offset: 0x31FC331 VA: 0x31FC230
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.AsReadOnly
	|
	|-RVA: 0x330B4A0 Offset: 0x330B5A1 VA: 0x330B4A0
	|-List<ShopCatalogPage>.AsReadOnly
	|
	|-RVA: 0x330E610 Offset: 0x330E711 VA: 0x330E610
	|-List<ShopNpcTalk>.AsReadOnly
	|
	|-RVA: 0x3311AC0 Offset: 0x3311BC1 VA: 0x3311AC0
	|-List<SubtitleDataTable.Data>.AsReadOnly
	|
	|-RVA: 0x3314B50 Offset: 0x3314C51 VA: 0x3314B50
	|-List<SubtitleDataTable.DataList>.AsReadOnly
	|
	|-RVA: 0x3317B50 Offset: 0x3317C51 VA: 0x3317B50
	|-List<SubtitleHudDataTable.Data>.AsReadOnly
	|
	|-RVA: 0x331ACB0 Offset: 0x331ADB1 VA: 0x331ACB0
	|-List<SRMonoBehaviourEx.FieldInfo>.AsReadOnly
	|
	|-RVA: 0x331E040 Offset: 0x331E141 VA: 0x331E040
	|-List<Schedule>.AsReadOnly
	|
	|-RVA: 0x33214C0 Offset: 0x33215C1 VA: 0x33214C0
	|-List<CurveSample>.AsReadOnly
	|
	|-RVA: 0x3324B90 Offset: 0x3324C91 VA: 0x3324B90
	|-List<bool>.AsReadOnly
	|
	|-RVA: 0x3327B70 Offset: 0x3327C71 VA: 0x3327B70
	|-List<byte>.AsReadOnly
	|
	|-RVA: 0x332AB40 Offset: 0x332AC41 VA: 0x332AB40
	|-List<char>.AsReadOnly
	|
	|-RVA: 0x3358BB0 Offset: 0x3358CB1 VA: 0x3358BB0
	|-List<KeyValuePair<DateTime, object>>.AsReadOnly
	|
	|-RVA: 0x335BC00 Offset: 0x335BD01 VA: 0x335BC00
	|-List<KeyValuePair<int, object>>.AsReadOnly
	|
	|-RVA: 0x335EC50 Offset: 0x335ED51 VA: 0x335EC50
	|-List<KeyValuePair<object, object>>.AsReadOnly
	|
	|-RVA: 0x3361C70 Offset: 0x3361D71 VA: 0x3361C70
	|-List<DateTime>.AsReadOnly
	|
	|-RVA: 0x3364C20 Offset: 0x3364D21 VA: 0x3364C20
	|-List<double>.AsReadOnly
	|
	|-RVA: 0x3367BD0 Offset: 0x3367CD1 VA: 0x3367BD0
	|-List<short>.AsReadOnly
	|
	|-RVA: 0x336AB80 Offset: 0x336AC81 VA: 0x336AB80
	|-List<int>.AsReadOnly
	|
	|-RVA: 0x336DB30 Offset: 0x336DC31 VA: 0x336DB30
	|-List<Int32Enum>.AsReadOnly
	|
	|-RVA: 0x3370AE0 Offset: 0x3370BE1 VA: 0x3370AE0
	|-List<long>.AsReadOnly
	|
	|-RVA: 0x3373AB0 Offset: 0x3373BB1 VA: 0x3373AB0
	|-List<InterpretedFrameInfo>.AsReadOnly
	|
	|-RVA: 0x3376AA0 Offset: 0x3376BA1 VA: 0x3376AA0
	|-List<Nullable<Int32Enum>>.AsReadOnly
	|
	|-RVA: 0x3405870 Offset: 0x3405971 VA: 0x3405870
	|-List<Nullable<Bounds>>.AsReadOnly
	|
	|-RVA: 0x3408E30 Offset: 0x3408F31 VA: 0x3408E30
	|-List<Nullable<BoundsInt>>.AsReadOnly
	|
	|-RVA: 0x340C2B0 Offset: 0x340C3B1 VA: 0x340C2B0
	|-List<Nullable<Color32>>.AsReadOnly
	|
	|-RVA: 0x340F390 Offset: 0x340F491 VA: 0x340F390
	|-List<Nullable<Color>>.AsReadOnly
	|
	|-RVA: 0x3412740 Offset: 0x3412841 VA: 0x3412740
	|-List<Nullable<GradientAlphaKey>>.AsReadOnly
	|
	|-RVA: 0x3415910 Offset: 0x3415A11 VA: 0x3415910
	|-List<Nullable<GradientColorKey>>.AsReadOnly
	|
	|-RVA: 0x3418D60 Offset: 0x3418E61 VA: 0x3418D60
	|-List<Nullable<Keyframe>>.AsReadOnly
	|
	|-RVA: 0x341C0E0 Offset: 0x341C1E1 VA: 0x341C0E0
	|-List<Nullable<LayerMask>>.AsReadOnly
	|
	|-RVA: 0x341F300 Offset: 0x341F401 VA: 0x341F300
	|-List<Nullable<Matrix4x4>>.AsReadOnly
	|
	|-RVA: 0x3422C00 Offset: 0x3422D01 VA: 0x3422C00
	|-List<Nullable<Quaternion>>.AsReadOnly
	|
	|-RVA: 0x3262A20 Offset: 0x3262B21 VA: 0x3262A20
	|-List<Nullable<RangeInt>>.AsReadOnly
	|
	|-RVA: 0x3265BF0 Offset: 0x3265CF1 VA: 0x3265BF0
	|-List<Nullable<Rect>>.AsReadOnly
	|
	|-RVA: 0x3269050 Offset: 0x3269151 VA: 0x3269050
	|-List<Nullable<RectInt>>.AsReadOnly
	|
	|-RVA: 0x326C400 Offset: 0x326C501 VA: 0x326C400
	|-List<Nullable<Vector2>>.AsReadOnly
	|
	|-RVA: 0x326F520 Offset: 0x326F621 VA: 0x326F520
	|-List<Nullable<Vector2Int>>.AsReadOnly
	|
	|-RVA: 0x3272610 Offset: 0x3272711 VA: 0x3272610
	|-List<Nullable<Vector3>>.AsReadOnly
	|
	|-RVA: 0x3275680 Offset: 0x3275781 VA: 0x3275680
	|-List<Nullable<Vector3Int>>.AsReadOnly
	|
	|-RVA: 0x32787D0 Offset: 0x32788D1 VA: 0x32787D0
	|-List<Nullable<Vector4>>.AsReadOnly
	|
	|-RVA: 0x327EAB0 Offset: 0x327EBB1 VA: 0x327EAB0
	|-List<sbyte>.AsReadOnly
	|
	|-RVA: 0x3281A80 Offset: 0x3281B81 VA: 0x3281A80
	|-List<float>.AsReadOnly
	|
	|-RVA: 0x32A8CE0 Offset: 0x32A8DE1 VA: 0x32A8CE0
	|-List<ushort>.AsReadOnly
	|
	|-RVA: 0x32ABC90 Offset: 0x32ABD91 VA: 0x32ABC90
	|-List<uint>.AsReadOnly
	|
	|-RVA: 0x32AEC40 Offset: 0x32AED41 VA: 0x32AEC40
	|-List<ulong>.AsReadOnly
	|
	|-RVA: 0x32B1BF0 Offset: 0x32B1CF1 VA: 0x32B1BF0
	|-List<ValueTuple<bool, Int32Enum>>.AsReadOnly
	|
	|-RVA: 0x32B4BA0 Offset: 0x32B4CA1 VA: 0x32B4BA0
	|-List<ValueTuple<Int32Enum, int>>.AsReadOnly
	|
	|-RVA: 0x32B7B70 Offset: 0x32B7C71 VA: 0x32B7B70
	|-List<ValueTuple<Int32Enum, object>>.AsReadOnly
	|
	|-RVA: 0x32BABC0 Offset: 0x32BACC1 VA: 0x32BABC0
	|-List<ValueTuple<object, Int32Enum>>.AsReadOnly
	|
	|-RVA: 0x32BDC00 Offset: 0x32BDD01 VA: 0x32BDC00
	|-List<ValueTuple<object, object>>.AsReadOnly
	|
	|-RVA: 0x32C0C40 Offset: 0x32C0D41 VA: 0x32C0C40
	|-List<ValueTuple<object, float>>.AsReadOnly
	|
	|-RVA: 0x32C3CA0 Offset: 0x32C3DA1 VA: 0x32C3CA0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.AsReadOnly
	|
	|-RVA: 0x32C6EB0 Offset: 0x32C6FB1 VA: 0x32C6EB0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.AsReadOnly
	|
	|-RVA: 0x3110B10 Offset: 0x3110C11 VA: 0x3110B10
	|-List<TexturePacker_JsonArray.Frame>.AsReadOnly
	|
	|-RVA: 0x31140B0 Offset: 0x31141B1 VA: 0x31140B0
	|-List<TutorialUnlockFlagData>.AsReadOnly
	|
	|-RVA: 0x3117150 Offset: 0x3117251 VA: 0x3117150
	|-List<UIMainManagerAttachObject.AttachSet>.AsReadOnly
	|
	|-RVA: 0x311A2E0 Offset: 0x311A3E1 VA: 0x311A2E0
	|-List<CapEdge>.AsReadOnly
	|
	|-RVA: 0x311D6E0 Offset: 0x311D7E1 VA: 0x311D6E0
	|-List<MeshDataConnectivity.Face>.AsReadOnly
	|
	|-RVA: 0x3120750 Offset: 0x3120851 VA: 0x3120750
	|-List<MeshFaceConnectivity.EdgeData.SideData>.AsReadOnly
	|
	|-RVA: 0x3123B30 Offset: 0x3123C31 VA: 0x3123B30
	|-List<MeshFaceConnectivity.EdgeData>.AsReadOnly
	|
	|-RVA: 0x3126FA0 Offset: 0x31270A1 VA: 0x3126FA0
	|-List<NavMeshBuildMarkup>.AsReadOnly
	|
	|-RVA: 0x312A250 Offset: 0x312A351 VA: 0x312A250
	|-List<NavMeshBuildSource>.AsReadOnly
	|
	|-RVA: 0x312DBA0 Offset: 0x312DCA1 VA: 0x312DBA0
	|-List<ConstraintSource>.AsReadOnly
	|
	|-RVA: 0x3130BC0 Offset: 0x3130CC1 VA: 0x3130BC0
	|-List<AnimatorClipInfo>.AsReadOnly
	|
	|-RVA: 0x321C770 Offset: 0x321C871 VA: 0x321C770
	|-List<BeforeRenderHelper.OrderBlock>.AsReadOnly
	|
	|-RVA: 0x321F860 Offset: 0x321F961 VA: 0x321F860
	|-List<BoneWeight>.AsReadOnly
	|
	|-RVA: 0x3222BC0 Offset: 0x3222CC1 VA: 0x3222BC0
	|-List<Bounds>.AsReadOnly
	|
	|-RVA: 0x3225F10 Offset: 0x3226011 VA: 0x3225F10
	|-List<BoundsInt>.AsReadOnly
	|
	|-RVA: 0x32291A0 Offset: 0x32292A1 VA: 0x32291A0
	|-List<Color32>.AsReadOnly
	|
	|-RVA: 0x322C1C0 Offset: 0x322C2C1 VA: 0x322C1C0
	|-List<Color>.AsReadOnly
	|
	|-RVA: 0x322F490 Offset: 0x322F591 VA: 0x322F490
	|-List<CombineInstance>.AsReadOnly
	|
	|-RVA: 0x3232FF0 Offset: 0x32330F1 VA: 0x3232FF0
	|-List<RaycastResult>.AsReadOnly
	|
	|-RVA: 0x32366C0 Offset: 0x32367C1 VA: 0x32366C0
	|-List<GradientAlphaKey>.AsReadOnly
	|
	|-RVA: 0x32397A0 Offset: 0x32398A1 VA: 0x32397A0
	|-List<GradientColorKey>.AsReadOnly
	|
	|-RVA: 0x323CB70 Offset: 0x323CC71 VA: 0x323CB70
	|-List<Keyframe>.AsReadOnly
	|
	|-RVA: 0x323FF20 Offset: 0x3240021 VA: 0x323FF20
	|-List<LayerMask>.AsReadOnly
	|
	|-RVA: 0x3243060 Offset: 0x3243161 VA: 0x3243060
	|-List<Matrix4x4>.AsReadOnly
	|
	|-RVA: 0x32466B0 Offset: 0x32467B1 VA: 0x32466B0
	|-List<ParticleSystem.Particle>.AsReadOnly
	|
	|-RVA: 0x3249A60 Offset: 0x3249B61 VA: 0x3249A60
	|-List<Playable>.AsReadOnly
	|
	|-RVA: 0x324CB50 Offset: 0x324CC51 VA: 0x324CB50
	|-List<PlayableBinding>.AsReadOnly
	|
	|-RVA: 0x324FE20 Offset: 0x324FF21 VA: 0x324FE20
	|-List<PlayableGraph>.AsReadOnly
	|
	|-RVA: 0x3252E30 Offset: 0x3252F31 VA: 0x3252E30
	|-List<Edge>.AsReadOnly
	|
	|-RVA: 0x3255E30 Offset: 0x3255F31 VA: 0x3255E30
	|-List<Quaternion>.AsReadOnly
	|
	|-RVA: 0x3258E60 Offset: 0x3258F61 VA: 0x3258E60
	|-List<RangeInt>.AsReadOnly
	|
	|-RVA: 0x325BF70 Offset: 0x325C071 VA: 0x325BF70
	|-List<RaycastHit2D>.AsReadOnly
	|
	|-RVA: 0x325F4E0 Offset: 0x325F5E1 VA: 0x325F4E0
	|-List<RaycastHit>.AsReadOnly
	|
	|-RVA: 0x33C1270 Offset: 0x33C1371 VA: 0x33C1270
	|-List<Rect>.AsReadOnly
	|
	|-RVA: 0x33C42A0 Offset: 0x33C43A1 VA: 0x33C42A0
	|-List<RectInt>.AsReadOnly
	|
	|-RVA: 0x33C72D0 Offset: 0x33C73D1 VA: 0x33C72D0
	|-List<ReflectionProbeBlendInfo>.AsReadOnly
	|
	|-RVA: 0x33CA5D0 Offset: 0x33CA6D1 VA: 0x33CA5D0
	|-List<SphericalHarmonicsL2>.AsReadOnly
	|
	|-RVA: 0x33CE050 Offset: 0x33CE151 VA: 0x33CE050
	|-List<VertexAttributeDescriptor>.AsReadOnly
	|
	|-RVA: 0x33D1140 Offset: 0x33D1241 VA: 0x33D1140
	|-List<AsyncOperationHandle>.AsReadOnly
	|
	|-RVA: 0x33D44E0 Offset: 0x33D45E1 VA: 0x33D44E0
	|-List<AsyncOperationHandle<SceneInstance>>.AsReadOnly
	|
	|-RVA: 0x33D78F0 Offset: 0x33D79F1 VA: 0x33D78F0
	|-List<DiagnosticEvent>.AsReadOnly
	|
	|-RVA: 0x33DAE40 Offset: 0x33DAF41 VA: 0x33DAE40
	|-List<DelayedActionManager.DelegateInfo>.AsReadOnly
	|
	|-RVA: 0x33DE260 Offset: 0x33DE361 VA: 0x33DE260
	|-List<ObjectInitializationData>.AsReadOnly
	|
	|-RVA: 0x31B9620 Offset: 0x31B9721 VA: 0x31B9620
	|-List<GlyphRect>.AsReadOnly
	|
	|-RVA: 0x31BC760 Offset: 0x31BC861 VA: 0x31BC760
	|-List<AnimationOutputWeightProcessor.WeightInfo>.AsReadOnly
	|
	|-RVA: 0x31BFBD0 Offset: 0x31BFCD1 VA: 0x31BFBD0
	|-List<IntervalTreeNode>.AsReadOnly
	|
	|-RVA: 0x31C2F40 Offset: 0x31C3041 VA: 0x31C2F40
	|-List<IntervalTree.Entry<object>>.AsReadOnly
	|
	|-RVA: 0x31C62E0 Offset: 0x31C63E1 VA: 0x31C62E0
	|-List<TimeNotificationBehaviour.NotificationEntry>.AsReadOnly
	|
	|-RVA: 0x31C95F0 Offset: 0x31C96F1 VA: 0x31C95F0
	|-List<UICharInfo>.AsReadOnly
	|
	|-RVA: 0x31CC640 Offset: 0x31CC741 VA: 0x31CC640
	|-List<FocusController.FocusedElement>.AsReadOnly
	|
	|-RVA: 0x31CF660 Offset: 0x31CF761 VA: 0x31CF660
	|-List<UILineInfo>.AsReadOnly
	|
	|-RVA: 0x31D28A0 Offset: 0x31D29A1 VA: 0x31D28A0
	|-List<UIVertex>.AsReadOnly
	|
	|-RVA: 0x31D6150 Offset: 0x31D6251 VA: 0x31D6150
	|-List<UnitySynchronizationContext.WorkRequest>.AsReadOnly
	|
	|-RVA: 0x31D9410 Offset: 0x31D9511 VA: 0x31D9410
	|-List<Vector2>.AsReadOnly
	|
	|-RVA: 0x2CE2040 Offset: 0x2CE2141 VA: 0x2CE2040
	|-List<Vector2Int>.AsReadOnly
	|
	|-RVA: 0x2CE5040 Offset: 0x2CE5141 VA: 0x2CE5040
	|-List<Vector3>.AsReadOnly
	|
	|-RVA: 0x2CE80B0 Offset: 0x2CE81B1 VA: 0x2CE80B0
	|-List<Vector3Int>.AsReadOnly
	|
	|-RVA: 0x2CEB180 Offset: 0x2CEB281 VA: 0x2CEB180
	|-List<Vector4>.AsReadOnly
	|
	|-RVA: 0x2CEE4C0 Offset: 0x2CEE5C1 VA: 0x2CEE4C0
	|-List<WarpPoints.WarpPoint>.AsReadOnly
	|
	|-RVA: 0x2CF1EC0 Offset: 0x2CF1FC1 VA: 0x2CF1EC0
	|-List<YieldItemParam>.AsReadOnly
	|
	|-RVA: 0x2CF4F50 Offset: 0x2CF5051 VA: 0x2CF4F50
	|-List<stCommand_t>.AsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327BB40 Offset: 0x327BC41 VA: 0x327BB40
	|-List<AIInput>.Clear
	|-List<AS_MagicController>.Clear
	|-List<ActionBehaviorCommandBase>.Clear
	|-List<Actor>.Clear
	|-List<ActorController>.Clear
	|-List<AracneFlatWeb>.Clear
	|-List<AttackCollider>.Clear
	|-List<AudmuraCrystal>.Clear
	|-List<AutomaticLOD.LODLevelData>.Clear
	|-List<AutomaticLOD>.Clear
	|-List<BaffamoDodgeManager.BaffamoMonster>.Clear
	|-List<BeanSowingActionTerm>.Clear
	|-List<BehaviorManager.BehaviorTree.ConditionalReevaluate>.Clear
	|-List<Task>.Clear
	|-List<BehaviorTreeManager.EnemyBehaviorParameter>.Clear
	|-List<BitBase>.Clear
	|-List<BodyPartsCollision>.Clear
	|-List<BulletBase>.Clear
	|-List<CerberusController.DogParam>.Clear
	|-List<Character>.Clear
	|-List<CharacterBase>.Clear
	|-List<CheerVoiceData>.Clear
	|-List<ChildData>.Clear
	|-List<ChoiceImage>.Clear
	|-List<CinemachineBrain.BrainFrame>.Clear
	|-List<CinemachineImpulseManager.ImpulseEvent>.Clear
	|-List<CinemachineStoryboard.CanvasInfo>.Clear
	|-List<CombinedMesh.ObjectInfo>.Clear
	|-List<CursorEvent>.Clear
	|-List<ABSSequentiable>.Clear
	|-List<Tween>.Clear
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>.Clear
	|-List<DynamicBone.Particle>.Clear
	|-List<DynamicBoneH.Particle>.Clear
	|-List<EventFlagManager.RequestDisableEventPointData>.Clear
	|-List<EventUnlockFlagData>.Clear
	|-List<CellController>.Clear
	|-List<FarmSupportMonsterController>.Clear
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>.Clear
	|-List<FesNpcScore>.Clear
	|-List<FracturedChunk.AdjacencyInfo>.Clear
	|-List<FracturedChunk>.Clear
	|-List<FriendMonsterManager.FarmInActorData>.Clear
	|-List<FriendMonsterStatusData>.Clear
	|-List<LightningRenderer>.Clear
	|-List<RainSplashRenderer>.Clear
	|-List<GluttonFoodData>.Clear
	|-List<GluttonItemTerm>.Clear
	|-List<HateController.HateParameter>.Clear
	|-List<ItemEquip>.Clear
	|-List<PlayerItemFurniture2>.Clear
	|-List<ItemIconMng.ImageLoaderObj>.Clear
	|-List<ItemIconMng.SpriteWork>.Clear
	|-List<ItemMoveToBasket>.Clear
	|-List<KrakenStickController>.Clear
	|-List<KyubiController.FireballParameter>.Clear
	|-List<AssetHandle>.Clear
	|-List<AssetInfo>.Clear
	|-List<MeshSimplify>.Clear
	|-List<ObjectSerializationInfo.EmittableMemberAndConstructorParameter>.Clear
	|-List<MonsterActionInformation>.Clear
	|-List<MonsterControllerBase.DropItemDataParameter>.Clear
	|-List<MonsterControllerBase>.Clear
	|-List<MonsterHutController.OrderFarmInParameter>.Clear
	|-List<NpcSaveParameter>.Clear
	|-List<NpcTimeAction>.Clear
	|-List<ObjectPooler.Pool>.Clear
	|-List<OnGroundItem>.Clear
	|-List<OrderData>.Clear
	|-List<PartnerManager.NPCChangeBaseParameter>.Clear
	|-List<PartnerMonsterBehaviorController>.Clear
	|-List<PartyMonster>.Clear
	|-List<DelaunayTriangle>.Clear
	|-List<Point2D>.Clear
	|-List<SplitComplexPolygonNode>.Clear
	|-List<TriangulationPoint>.Clear
	|-List<PreloadHandle>.Clear
	|-List<FishShipmentRecords>.Clear
	|-List<SeedLevelRecords>.Clear
	|-List<ShipmentItemRecords>.Clear
	|-List<ButtonHintBlock>.Clear
	|-List<RandomData>.Clear
	|-List<RecipeDataDispBlock>.Clear
	|-List<ReviatanIcePillar>.Clear
	|-List<InteractionTrigger>.Clear
	|-List<OptionsControlBase>.Clear
	|-List<OptionsTabController.CategoryInstance>.Clear
	|-List<SceneSplit>.Clear
	|-List<SearchCharacterController.SearchParameter>.Clear
	|-List<SnowballObjectSpawnTerm>.Clear
	|-List<SnowmanManager.Mocomoco>.Clear
	|-List<CubicBezierCurve>.Clear
	|-List<ExtrusionSegment.Vertex>.Clear
	|-List<SplineNode>.Clear
	|-List<StampData>.Clear
	|-List<SubEventData>.Clear
	|-List<SubEventMasterDataBase>.Clear
	|-List<byte[]>.Clear
	|-List<List<FarmCropData>>.Clear
	|-List<List<int>>.Clear
	|-List<List<Vector3>>.Clear
	|-List<Stack<int>>.Clear
	|-List<object>.Clear
	|-List<FieldInfo>.Clear
	|-List<X509CertificateImpl>.Clear
	|-List<string>.Clear
	|-List<string[]>.Clear
	|-List<Timer>.Clear
	|-List<TMP_Character>.Clear
	|-List<TMP_Dropdown.DropdownItem>.Clear
	|-List<TMP_Dropdown.OptionData>.Clear
	|-List<TMP_FontAsset>.Clear
	|-List<TMP_GlyphPairAdjustmentRecord>.Clear
	|-List<TMP_MaterialManager.FallbackMaterial>.Clear
	|-List<TMP_SpriteCharacter>.Clear
	|-List<TMP_SpriteGlyph>.Clear
	|-List<TMP_Text>.Clear
	|-List<TimelineMsg>.Clear
	|-List<ToolInteractionInterface>.Clear
	|-List<MeshFaceConnectivity.TriangleData>.Clear
	|-List<VertexData>.Clear
	|-List<Simplifier.Vertex>.Clear
	|-List<NavMeshObstacle>.Clear
	|-List<AddressablesImpl.ResourceLocatorInfo>.Clear
	|-List<Collider>.Clear
	|-List<IEventSystemHandler>.Clear
	|-List<BaseInvokableCall>.Clear
	|-List<GameObject>.Clear
	|-List<ISubsystem>.Clear
	|-List<ISubsystemDescriptorImpl>.Clear
	|-List<Light>.Clear
	|-List<Material>.Clear
	|-List<ParticleSystem>.Clear
	|-List<RectTransform>.Clear
	|-List<RenderTexture>.Clear
	|-List<AsyncOperationHandle<SceneInstance>[]>.Clear
	|-List<IAsyncOperation>.Clear
	|-List<ScriptableObject>.Clear
	|-List<SkinnedMeshRenderer>.Clear
	|-List<Glyph>.Clear
	|-List<IMarker>.Clear
	|-List<ITimelineEvaluateCallback>.Clear
	|-List<RuntimeElement>.Clear
	|-List<TimelineClip>.Clear
	|-List<TrackAsset>.Clear
	|-List<Transform>.Clear
	|-List<Dropdown.DropdownItem>.Clear
	|-List<Dropdown.OptionData>.Clear
	|-List<Graphic>.Clear
	|-List<ICanvasElement>.Clear
	|-List<Image>.Clear
	|-List<RectMask2D>.Clear
	|-List<StencilMaterial.MatEntry>.Clear
	|-List<EventCallbackFunctorBase>.Clear
	|-List<IEventHandler>.Clear
	|-List<Panel>.Clear
	|-List<VisualElement>.Clear
	|-List<UpPointData>.Clear
	|-List<VoiceComment.CharaSprite>.Clear
	|-List<VoiceCommentData>.Clear
	|-List<SplineControlPoint>.Clear
	|-List<XWeaponTrail.Element>.Clear
	|
	|-RVA: 0x248D1D0 Offset: 0x248D2D1 VA: 0x248D1D0
	|-List<AS_ToolController.ChargeInfo>.Clear
	|
	|-RVA: 0x336DBA0 Offset: 0x336DCA1 VA: 0x336DBA0
	|-List<TaskStatus>.Clear
	|-List<ActorID>.Clear
	|-List<Alliance>.Clear
	|-List<BulletID>.Clear
	|-List<ClothShopID>.Clear
	|-List<DLCID>.Clear
	|-List<EmotionType>.Clear
	|-List<HotSpringID>.Clear
	|-List<RecipePanShopID>.Clear
	|-List<VaccinationID>.Clear
	|-List<VariationNo>.Clear
	|-List<ItemID>.Clear
	|-List<Prefab>.Clear
	|-List<Texture>.Clear
	|-List<LovePointManager.FavoriteType>.Clear
	|-List<MonsterActionBehaviorType>.Clear
	|-List<PartnerNPCActionBehaviorType>.Clear
	|-List<RecipeId>.Clear
	|-List<Int32Enum>.Clear
	|
	|-RVA: 0x24907A0 Offset: 0x24908A1 VA: 0x24907A0
	|-List<BuildItemData>.Clear
	|
	|-RVA: 0x31567B0 Offset: 0x31568B1 VA: 0x31567B0
	|-List<ButtonLinker.LinkObject>.Clear
	|
	|-RVA: 0x31597E0 Offset: 0x31598E1 VA: 0x31597E0
	|-List<CharaCallTable.BustupTable>.Clear
	|
	|-RVA: 0x315C830 Offset: 0x315C931 VA: 0x315C830
	|-List<CharaCallTable.CharaFaceIconTable>.Clear
	|
	|-RVA: 0x315F8D0 Offset: 0x315F9D1 VA: 0x315F8D0
	|-List<CameraState.CustomBlendable>.Clear
	|
	|-RVA: 0x31628F0 Offset: 0x31629F1 VA: 0x31628F0
	|-List<CinemachineClearShot.Pair>.Clear
	|
	|-RVA: 0x31658A0 Offset: 0x31659A1 VA: 0x31658A0
	|-List<CinemachineStateDrivenCamera.HashPair>.Clear
	|
	|-RVA: 0x3168980 Offset: 0x3168A81 VA: 0x3168980
	|-List<TargetPositionCache.CacheCurve.Item>.Clear
	|
	|-RVA: 0x316BE90 Offset: 0x316BF91 VA: 0x316BE90
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Clear
	|
	|-RVA: 0x316F3E0 Offset: 0x316F4E1 VA: 0x316F3E0
	|-List<CropDataTable>.Clear
	|
	|-RVA: 0x3172860 Offset: 0x3172961 VA: 0x3172860
	|-List<DropItemParam>.Clear
	|
	|-RVA: 0x31758F0 Offset: 0x31759F1 VA: 0x31758F0
	|-List<ErosionBrush.UndoStep>.Clear
	|
	|-RVA: 0x31DC580 Offset: 0x31DC681 VA: 0x31DC580
	|-List<EventCheckId>.Clear
	|
	|-RVA: 0x31DF860 Offset: 0x31DF961 VA: 0x31DF860
	|-List<EventFlagProgressData>.Clear
	|
	|-RVA: 0x31E28B0 Offset: 0x31E29B1 VA: 0x31E28B0
	|-List<FesNpcScoreData>.Clear
	|
	|-RVA: 0x31E5A40 Offset: 0x31E5B41 VA: 0x31E5A40
	|-List<MiningPointSaveData>.Clear
	|
	|-RVA: 0x31E8F90 Offset: 0x31E9091 VA: 0x31E8F90
	|-List<MonsterHutSaveData>.Clear
	|
	|-RVA: 0x31EC380 Offset: 0x31EC481 VA: 0x31EC380
	|-List<MoviePlayer.SUBTITLEDATA>.Clear
	|
	|-RVA: 0x31EF520 Offset: 0x31EF621 VA: 0x31EF520
	|-List<NPCActionData>.Clear
	|
	|-RVA: 0x31F2B50 Offset: 0x31F2C51 VA: 0x31F2B50
	|-List<NpcPlaceSchedule>.Clear
	|
	|-RVA: 0x31F5E50 Offset: 0x31F5F51 VA: 0x31F5E50
	|-List<OrderLotterySaveParameter>.Clear
	|
	|-RVA: 0x31F8FB0 Offset: 0x31F90B1 VA: 0x31F8FB0
	|-List<OrderSaveParameter>.Clear
	|
	|-RVA: 0x31FC2A0 Offset: 0x31FC3A1 VA: 0x31FC2A0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Clear
	|
	|-RVA: 0x330B510 Offset: 0x330B611 VA: 0x330B510
	|-List<ShopCatalogPage>.Clear
	|
	|-RVA: 0x330E680 Offset: 0x330E781 VA: 0x330E680
	|-List<ShopNpcTalk>.Clear
	|
	|-RVA: 0x3311B30 Offset: 0x3311C31 VA: 0x3311B30
	|-List<SubtitleDataTable.Data>.Clear
	|
	|-RVA: 0x3314BC0 Offset: 0x3314CC1 VA: 0x3314BC0
	|-List<SubtitleDataTable.DataList>.Clear
	|
	|-RVA: 0x3317BC0 Offset: 0x3317CC1 VA: 0x3317BC0
	|-List<SubtitleHudDataTable.Data>.Clear
	|
	|-RVA: 0x331AD20 Offset: 0x331AE21 VA: 0x331AD20
	|-List<SRMonoBehaviourEx.FieldInfo>.Clear
	|
	|-RVA: 0x331E0B0 Offset: 0x331E1B1 VA: 0x331E0B0
	|-List<Schedule>.Clear
	|
	|-RVA: 0x3321530 Offset: 0x3321631 VA: 0x3321530
	|-List<CurveSample>.Clear
	|
	|-RVA: 0x3324C00 Offset: 0x3324D01 VA: 0x3324C00
	|-List<bool>.Clear
	|
	|-RVA: 0x3327BE0 Offset: 0x3327CE1 VA: 0x3327BE0
	|-List<byte>.Clear
	|
	|-RVA: 0x332ABB0 Offset: 0x332ACB1 VA: 0x332ABB0
	|-List<char>.Clear
	|
	|-RVA: 0x3358C20 Offset: 0x3358D21 VA: 0x3358C20
	|-List<KeyValuePair<DateTime, object>>.Clear
	|
	|-RVA: 0x335BC70 Offset: 0x335BD71 VA: 0x335BC70
	|-List<KeyValuePair<int, object>>.Clear
	|
	|-RVA: 0x335ECC0 Offset: 0x335EDC1 VA: 0x335ECC0
	|-List<KeyValuePair<object, object>>.Clear
	|-List<KeyValuePair<AnimationClip, AnimationClip>>.Clear
	|
	|-RVA: 0x3361CE0 Offset: 0x3361DE1 VA: 0x3361CE0
	|-List<DateTime>.Clear
	|
	|-RVA: 0x3364C90 Offset: 0x3364D91 VA: 0x3364C90
	|-List<double>.Clear
	|
	|-RVA: 0x3367C40 Offset: 0x3367D41 VA: 0x3367C40
	|-List<short>.Clear
	|
	|-RVA: 0x336ABF0 Offset: 0x336ACF1 VA: 0x336ABF0
	|-List<int>.Clear
	|
	|-RVA: 0x3370B50 Offset: 0x3370C51 VA: 0x3370B50
	|-List<long>.Clear
	|
	|-RVA: 0x3373B20 Offset: 0x3373C21 VA: 0x3373B20
	|-List<InterpretedFrameInfo>.Clear
	|
	|-RVA: 0x3376B10 Offset: 0x3376C11 VA: 0x3376B10
	|-List<Nullable<Int32Enum>>.Clear
	|
	|-RVA: 0x34058E0 Offset: 0x34059E1 VA: 0x34058E0
	|-List<Nullable<Bounds>>.Clear
	|
	|-RVA: 0x3408EA0 Offset: 0x3408FA1 VA: 0x3408EA0
	|-List<Nullable<BoundsInt>>.Clear
	|
	|-RVA: 0x340C320 Offset: 0x340C421 VA: 0x340C320
	|-List<Nullable<Color32>>.Clear
	|
	|-RVA: 0x340F400 Offset: 0x340F501 VA: 0x340F400
	|-List<Nullable<Color>>.Clear
	|
	|-RVA: 0x34127B0 Offset: 0x34128B1 VA: 0x34127B0
	|-List<Nullable<GradientAlphaKey>>.Clear
	|
	|-RVA: 0x3415980 Offset: 0x3415A81 VA: 0x3415980
	|-List<Nullable<GradientColorKey>>.Clear
	|
	|-RVA: 0x3418DD0 Offset: 0x3418ED1 VA: 0x3418DD0
	|-List<Nullable<Keyframe>>.Clear
	|
	|-RVA: 0x341C150 Offset: 0x341C251 VA: 0x341C150
	|-List<Nullable<LayerMask>>.Clear
	|
	|-RVA: 0x341F370 Offset: 0x341F471 VA: 0x341F370
	|-List<Nullable<Matrix4x4>>.Clear
	|
	|-RVA: 0x3422C70 Offset: 0x3422D71 VA: 0x3422C70
	|-List<Nullable<Quaternion>>.Clear
	|
	|-RVA: 0x3262A90 Offset: 0x3262B91 VA: 0x3262A90
	|-List<Nullable<RangeInt>>.Clear
	|
	|-RVA: 0x3265C60 Offset: 0x3265D61 VA: 0x3265C60
	|-List<Nullable<Rect>>.Clear
	|
	|-RVA: 0x32690C0 Offset: 0x32691C1 VA: 0x32690C0
	|-List<Nullable<RectInt>>.Clear
	|
	|-RVA: 0x326C470 Offset: 0x326C571 VA: 0x326C470
	|-List<Nullable<Vector2>>.Clear
	|
	|-RVA: 0x326F590 Offset: 0x326F691 VA: 0x326F590
	|-List<Nullable<Vector2Int>>.Clear
	|
	|-RVA: 0x3272680 Offset: 0x3272781 VA: 0x3272680
	|-List<Nullable<Vector3>>.Clear
	|
	|-RVA: 0x32756F0 Offset: 0x32757F1 VA: 0x32756F0
	|-List<Nullable<Vector3Int>>.Clear
	|
	|-RVA: 0x3278840 Offset: 0x3278941 VA: 0x3278840
	|-List<Nullable<Vector4>>.Clear
	|
	|-RVA: 0x327EB20 Offset: 0x327EC21 VA: 0x327EB20
	|-List<sbyte>.Clear
	|
	|-RVA: 0x3281AF0 Offset: 0x3281BF1 VA: 0x3281AF0
	|-List<float>.Clear
	|
	|-RVA: 0x32A8D50 Offset: 0x32A8E51 VA: 0x32A8D50
	|-List<ushort>.Clear
	|
	|-RVA: 0x32ABD00 Offset: 0x32ABE01 VA: 0x32ABD00
	|-List<uint>.Clear
	|
	|-RVA: 0x32AECB0 Offset: 0x32AEDB1 VA: 0x32AECB0
	|-List<ulong>.Clear
	|
	|-RVA: 0x32C0CB0 Offset: 0x32C0DB1 VA: 0x32C0CB0
	|-List<ValueTuple<CharacterBase, float>>.Clear
	|-List<ValueTuple<object, float>>.Clear
	|
	|-RVA: 0x32B7BE0 Offset: 0x32B7CE1 VA: 0x32B7BE0
	|-List<ValueTuple<SoundID, EnvironmentSoundController>>.Clear
	|-List<ValueTuple<Int32Enum, object>>.Clear
	|
	|-RVA: 0x32B1C60 Offset: 0x32B1D61 VA: 0x32B1C60
	|-List<ValueTuple<bool, ItemID>>.Clear
	|-List<ValueTuple<bool, Int32Enum>>.Clear
	|
	|-RVA: 0x32B4C10 Offset: 0x32B4D11 VA: 0x32B4C10
	|-List<ValueTuple<Int32Enum, int>>.Clear
	|
	|-RVA: 0x32BAC30 Offset: 0x32BAD31 VA: 0x32BAC30
	|-List<ValueTuple<object, Int32Enum>>.Clear
	|
	|-RVA: 0x32BDC70 Offset: 0x32BDD71 VA: 0x32BDC70
	|-List<ValueTuple<object, object>>.Clear
	|
	|-RVA: 0x32C3D10 Offset: 0x32C3E11 VA: 0x32C3D10
	|-List<ValueTuple<CharID, VariationNo, HairType>>.Clear
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Clear
	|
	|-RVA: 0x32C6F20 Offset: 0x32C7021 VA: 0x32C6F20
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Clear
	|-List<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>.Clear
	|
	|-RVA: 0x3110B80 Offset: 0x3110C81 VA: 0x3110B80
	|-List<TexturePacker_JsonArray.Frame>.Clear
	|
	|-RVA: 0x3114120 Offset: 0x3114221 VA: 0x3114120
	|-List<TutorialUnlockFlagData>.Clear
	|
	|-RVA: 0x31171C0 Offset: 0x31172C1 VA: 0x31171C0
	|-List<UIMainManagerAttachObject.AttachSet>.Clear
	|
	|-RVA: 0x311A350 Offset: 0x311A451 VA: 0x311A350
	|-List<CapEdge>.Clear
	|
	|-RVA: 0x311D750 Offset: 0x311D851 VA: 0x311D750
	|-List<MeshDataConnectivity.Face>.Clear
	|
	|-RVA: 0x31207C0 Offset: 0x31208C1 VA: 0x31207C0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Clear
	|
	|-RVA: 0x3123BA0 Offset: 0x3123CA1 VA: 0x3123BA0
	|-List<MeshFaceConnectivity.EdgeData>.Clear
	|
	|-RVA: 0x3127010 Offset: 0x3127111 VA: 0x3127010
	|-List<NavMeshBuildMarkup>.Clear
	|
	|-RVA: 0x312A2C0 Offset: 0x312A3C1 VA: 0x312A2C0
	|-List<NavMeshBuildSource>.Clear
	|
	|-RVA: 0x312DC10 Offset: 0x312DD11 VA: 0x312DC10
	|-List<ConstraintSource>.Clear
	|
	|-RVA: 0x3130C30 Offset: 0x3130D31 VA: 0x3130C30
	|-List<AnimatorClipInfo>.Clear
	|
	|-RVA: 0x321C7E0 Offset: 0x321C8E1 VA: 0x321C7E0
	|-List<BeforeRenderHelper.OrderBlock>.Clear
	|
	|-RVA: 0x321F8D0 Offset: 0x321F9D1 VA: 0x321F8D0
	|-List<BoneWeight>.Clear
	|
	|-RVA: 0x3222C30 Offset: 0x3222D31 VA: 0x3222C30
	|-List<Bounds>.Clear
	|
	|-RVA: 0x3225F80 Offset: 0x3226081 VA: 0x3225F80
	|-List<BoundsInt>.Clear
	|
	|-RVA: 0x3229210 Offset: 0x3229311 VA: 0x3229210
	|-List<Color32>.Clear
	|
	|-RVA: 0x322C230 Offset: 0x322C331 VA: 0x322C230
	|-List<Color>.Clear
	|
	|-RVA: 0x322F500 Offset: 0x322F601 VA: 0x322F500
	|-List<CombineInstance>.Clear
	|
	|-RVA: 0x3233060 Offset: 0x3233161 VA: 0x3233060
	|-List<RaycastResult>.Clear
	|
	|-RVA: 0x3236730 Offset: 0x3236831 VA: 0x3236730
	|-List<GradientAlphaKey>.Clear
	|
	|-RVA: 0x3239810 Offset: 0x3239911 VA: 0x3239810
	|-List<GradientColorKey>.Clear
	|
	|-RVA: 0x323CBE0 Offset: 0x323CCE1 VA: 0x323CBE0
	|-List<Keyframe>.Clear
	|
	|-RVA: 0x323FF90 Offset: 0x3240091 VA: 0x323FF90
	|-List<LayerMask>.Clear
	|
	|-RVA: 0x32430D0 Offset: 0x32431D1 VA: 0x32430D0
	|-List<Matrix4x4>.Clear
	|
	|-RVA: 0x3246720 Offset: 0x3246821 VA: 0x3246720
	|-List<ParticleSystem.Particle>.Clear
	|
	|-RVA: 0x3249AD0 Offset: 0x3249BD1 VA: 0x3249AD0
	|-List<Playable>.Clear
	|
	|-RVA: 0x324CBC0 Offset: 0x324CCC1 VA: 0x324CBC0
	|-List<PlayableBinding>.Clear
	|
	|-RVA: 0x324FE90 Offset: 0x324FF91 VA: 0x324FE90
	|-List<PlayableGraph>.Clear
	|
	|-RVA: 0x3252EA0 Offset: 0x3252FA1 VA: 0x3252EA0
	|-List<Edge>.Clear
	|
	|-RVA: 0x3255EA0 Offset: 0x3255FA1 VA: 0x3255EA0
	|-List<Quaternion>.Clear
	|
	|-RVA: 0x3258ED0 Offset: 0x3258FD1 VA: 0x3258ED0
	|-List<RangeInt>.Clear
	|
	|-RVA: 0x325BFE0 Offset: 0x325C0E1 VA: 0x325BFE0
	|-List<RaycastHit2D>.Clear
	|
	|-RVA: 0x325F550 Offset: 0x325F651 VA: 0x325F550
	|-List<RaycastHit>.Clear
	|
	|-RVA: 0x33C12E0 Offset: 0x33C13E1 VA: 0x33C12E0
	|-List<Rect>.Clear
	|
	|-RVA: 0x33C4310 Offset: 0x33C4411 VA: 0x33C4310
	|-List<RectInt>.Clear
	|
	|-RVA: 0x33C7340 Offset: 0x33C7441 VA: 0x33C7340
	|-List<ReflectionProbeBlendInfo>.Clear
	|
	|-RVA: 0x33CA640 Offset: 0x33CA741 VA: 0x33CA640
	|-List<SphericalHarmonicsL2>.Clear
	|
	|-RVA: 0x33CE0C0 Offset: 0x33CE1C1 VA: 0x33CE0C0
	|-List<VertexAttributeDescriptor>.Clear
	|
	|-RVA: 0x33D11B0 Offset: 0x33D12B1 VA: 0x33D11B0
	|-List<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x33D4550 Offset: 0x33D4651 VA: 0x33D4550
	|-List<AsyncOperationHandle<SceneInstance>>.Clear
	|
	|-RVA: 0x33D7960 Offset: 0x33D7A61 VA: 0x33D7960
	|-List<DiagnosticEvent>.Clear
	|
	|-RVA: 0x33DAEB0 Offset: 0x33DAFB1 VA: 0x33DAEB0
	|-List<DelayedActionManager.DelegateInfo>.Clear
	|
	|-RVA: 0x33DE2D0 Offset: 0x33DE3D1 VA: 0x33DE2D0
	|-List<ObjectInitializationData>.Clear
	|
	|-RVA: 0x31B9690 Offset: 0x31B9791 VA: 0x31B9690
	|-List<GlyphRect>.Clear
	|
	|-RVA: 0x31BC7D0 Offset: 0x31BC8D1 VA: 0x31BC7D0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Clear
	|
	|-RVA: 0x31BFC40 Offset: 0x31BFD41 VA: 0x31BFC40
	|-List<IntervalTreeNode>.Clear
	|
	|-RVA: 0x31C2FB0 Offset: 0x31C30B1 VA: 0x31C2FB0
	|-List<IntervalTree.Entry<object>>.Clear
	|
	|-RVA: 0x31C6350 Offset: 0x31C6451 VA: 0x31C6350
	|-List<TimeNotificationBehaviour.NotificationEntry>.Clear
	|
	|-RVA: 0x31C9660 Offset: 0x31C9761 VA: 0x31C9660
	|-List<UICharInfo>.Clear
	|
	|-RVA: 0x31CC6B0 Offset: 0x31CC7B1 VA: 0x31CC6B0
	|-List<FocusController.FocusedElement>.Clear
	|
	|-RVA: 0x31CF6D0 Offset: 0x31CF7D1 VA: 0x31CF6D0
	|-List<UILineInfo>.Clear
	|
	|-RVA: 0x31D2910 Offset: 0x31D2A11 VA: 0x31D2910
	|-List<UIVertex>.Clear
	|
	|-RVA: 0x31D61C0 Offset: 0x31D62C1 VA: 0x31D61C0
	|-List<UnitySynchronizationContext.WorkRequest>.Clear
	|
	|-RVA: 0x31D9480 Offset: 0x31D9581 VA: 0x31D9480
	|-List<Vector2>.Clear
	|
	|-RVA: 0x2CE20B0 Offset: 0x2CE21B1 VA: 0x2CE20B0
	|-List<Vector2Int>.Clear
	|
	|-RVA: 0x2CE50B0 Offset: 0x2CE51B1 VA: 0x2CE50B0
	|-List<Vector3>.Clear
	|
	|-RVA: 0x2CE8120 Offset: 0x2CE8221 VA: 0x2CE8120
	|-List<Vector3Int>.Clear
	|
	|-RVA: 0x2CEB1F0 Offset: 0x2CEB2F1 VA: 0x2CEB1F0
	|-List<Vector4>.Clear
	|
	|-RVA: 0x2CEE530 Offset: 0x2CEE631 VA: 0x2CEE530
	|-List<WarpPoints.WarpPoint>.Clear
	|
	|-RVA: 0x2CF1F30 Offset: 0x2CF2031 VA: 0x2CF1F30
	|-List<YieldItemParam>.Clear
	|
	|-RVA: 0x2CF4FC0 Offset: 0x2CF50C1 VA: 0x2CF4FC0
	|-List<stCommand_t>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D220 Offset: 0x248D321 VA: 0x248D220
	|-List<AS_ToolController.ChargeInfo>.Contains
	|
	|-RVA: 0x327BB90 Offset: 0x327BC91 VA: 0x327BB90
	|-List<AracneFlatWeb>.Contains
	|-List<AttackCollider>.Contains
	|-List<BulletBase>.Contains
	|-List<Character>.Contains
	|-List<CharacterBase>.Contains
	|-List<CinemachineVirtualCameraBase>.Contains
	|-List<CursorEvent>.Contains
	|-List<FarmCropData>.Contains
	|-List<LightningSpawnArea>.Contains
	|-List<WeatherEnclosure>.Contains
	|-List<HasibirokouSonicWind>.Contains
	|-List<LastBossBone>.Contains
	|-List<MonsterProjectileActionScriptsController>.Contains
	|-List<Point2D>.Contains
	|-List<SplitComplexPolygonNode>.Contains
	|-List<InteractionTrigger>.Contains
	|-List<SubEventData>.Contains
	|-List<object>.Contains
	|-List<Assembly>.Contains
	|-List<string>.Contains
	|-List<ToolInteractionInterface>.Contains
	|-List<UIItemSlot>.Contains
	|-List<UIOnOffAnimate>.Contains
	|-List<Simplifier.Vertex>.Contains
	|-List<NavMeshModifier>.Contains
	|-List<NavMeshModifierVolume>.Contains
	|-List<NavMeshSurface>.Contains
	|-List<Collider>.Contains
	|-List<BaseRaycaster>.Contains
	|-List<GameObject>.Contains
	|-List<Light>.Contains
	|-List<Material>.Contains
	|-List<RenderTexture>.Contains
	|-List<Renderer>.Contains
	|-List<ScriptableObject>.Contains
	|-List<Terrain>.Contains
	|-List<SignalAsset>.Contains
	|-List<TimelineClip>.Contains
	|-List<Transform>.Contains
	|-List<Toggle>.Contains
	|-List<IEventHandler>.Contains
	|
	|-RVA: 0x24907F0 Offset: 0x24908F1 VA: 0x24907F0
	|-List<BuildItemData>.Contains
	|
	|-RVA: 0x3156800 Offset: 0x3156901 VA: 0x3156800
	|-List<ButtonLinker.LinkObject>.Contains
	|
	|-RVA: 0x3159830 Offset: 0x3159931 VA: 0x3159830
	|-List<CharaCallTable.BustupTable>.Contains
	|
	|-RVA: 0x315C880 Offset: 0x315C981 VA: 0x315C880
	|-List<CharaCallTable.CharaFaceIconTable>.Contains
	|
	|-RVA: 0x315F920 Offset: 0x315FA21 VA: 0x315F920
	|-List<CameraState.CustomBlendable>.Contains
	|
	|-RVA: 0x3162940 Offset: 0x3162A41 VA: 0x3162940
	|-List<CinemachineClearShot.Pair>.Contains
	|
	|-RVA: 0x31658F0 Offset: 0x31659F1 VA: 0x31658F0
	|-List<CinemachineStateDrivenCamera.HashPair>.Contains
	|
	|-RVA: 0x31689D0 Offset: 0x3168AD1 VA: 0x31689D0
	|-List<TargetPositionCache.CacheCurve.Item>.Contains
	|
	|-RVA: 0x316BEE0 Offset: 0x316BFE1 VA: 0x316BEE0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Contains
	|
	|-RVA: 0x336DBF0 Offset: 0x336DCF1 VA: 0x336DBF0
	|-List<CraftCategoryId>.Contains
	|-List<ActorID>.Contains
	|-List<Alliance>.Contains
	|-List<BadStatus>.Contains
	|-List<DLCID>.Contains
	|-List<FarmFieldWorkArea>.Contains
	|-List<GameFlagData>.Contains
	|-List<StorageType>.Contains
	|-List<ItemID>.Contains
	|-List<LovePointManager.FavoriteType>.Contains
	|-List<MonsterCharacterType>.Contains
	|-List<RecipeId>.Contains
	|-List<Int32Enum>.Contains
	|-List<ParticleSystemVertexStream>.Contains
	|
	|-RVA: 0x316F430 Offset: 0x316F531 VA: 0x316F430
	|-List<CropDataTable>.Contains
	|
	|-RVA: 0x31728B0 Offset: 0x31729B1 VA: 0x31728B0
	|-List<DropItemParam>.Contains
	|
	|-RVA: 0x3175940 Offset: 0x3175A41 VA: 0x3175940
	|-List<ErosionBrush.UndoStep>.Contains
	|
	|-RVA: 0x31DC5D0 Offset: 0x31DC6D1 VA: 0x31DC5D0
	|-List<EventCheckId>.Contains
	|
	|-RVA: 0x31DF8B0 Offset: 0x31DF9B1 VA: 0x31DF8B0
	|-List<EventFlagProgressData>.Contains
	|
	|-RVA: 0x31E2900 Offset: 0x31E2A01 VA: 0x31E2900
	|-List<FesNpcScoreData>.Contains
	|
	|-RVA: 0x31E5A90 Offset: 0x31E5B91 VA: 0x31E5A90
	|-List<MiningPointSaveData>.Contains
	|
	|-RVA: 0x31E8FE0 Offset: 0x31E90E1 VA: 0x31E8FE0
	|-List<MonsterHutSaveData>.Contains
	|
	|-RVA: 0x31EC3D0 Offset: 0x31EC4D1 VA: 0x31EC3D0
	|-List<MoviePlayer.SUBTITLEDATA>.Contains
	|
	|-RVA: 0x31EF570 Offset: 0x31EF671 VA: 0x31EF570
	|-List<NPCActionData>.Contains
	|
	|-RVA: 0x31F2BA0 Offset: 0x31F2CA1 VA: 0x31F2BA0
	|-List<NpcPlaceSchedule>.Contains
	|
	|-RVA: 0x31F5EA0 Offset: 0x31F5FA1 VA: 0x31F5EA0
	|-List<OrderLotterySaveParameter>.Contains
	|
	|-RVA: 0x31F9000 Offset: 0x31F9101 VA: 0x31F9000
	|-List<OrderSaveParameter>.Contains
	|
	|-RVA: 0x31FC2F0 Offset: 0x31FC3F1 VA: 0x31FC2F0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Contains
	|
	|-RVA: 0x330B560 Offset: 0x330B661 VA: 0x330B560
	|-List<ShopCatalogPage>.Contains
	|
	|-RVA: 0x330E6D0 Offset: 0x330E7D1 VA: 0x330E6D0
	|-List<ShopNpcTalk>.Contains
	|
	|-RVA: 0x3311B80 Offset: 0x3311C81 VA: 0x3311B80
	|-List<SubtitleDataTable.Data>.Contains
	|
	|-RVA: 0x3314C10 Offset: 0x3314D11 VA: 0x3314C10
	|-List<SubtitleDataTable.DataList>.Contains
	|
	|-RVA: 0x3317C10 Offset: 0x3317D11 VA: 0x3317C10
	|-List<SubtitleHudDataTable.Data>.Contains
	|
	|-RVA: 0x331AD70 Offset: 0x331AE71 VA: 0x331AD70
	|-List<SRMonoBehaviourEx.FieldInfo>.Contains
	|
	|-RVA: 0x331E100 Offset: 0x331E201 VA: 0x331E100
	|-List<Schedule>.Contains
	|
	|-RVA: 0x3321580 Offset: 0x3321681 VA: 0x3321580
	|-List<CurveSample>.Contains
	|
	|-RVA: 0x3324C50 Offset: 0x3324D51 VA: 0x3324C50
	|-List<bool>.Contains
	|
	|-RVA: 0x3327C30 Offset: 0x3327D31 VA: 0x3327C30
	|-List<byte>.Contains
	|
	|-RVA: 0x332AC00 Offset: 0x332AD01 VA: 0x332AC00
	|-List<char>.Contains
	|
	|-RVA: 0x3358C70 Offset: 0x3358D71 VA: 0x3358C70
	|-List<KeyValuePair<DateTime, object>>.Contains
	|
	|-RVA: 0x335BCC0 Offset: 0x335BDC1 VA: 0x335BCC0
	|-List<KeyValuePair<int, object>>.Contains
	|
	|-RVA: 0x335ED10 Offset: 0x335EE11 VA: 0x335ED10
	|-List<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x3361D30 Offset: 0x3361E31 VA: 0x3361D30
	|-List<DateTime>.Contains
	|
	|-RVA: 0x3364CE0 Offset: 0x3364DE1 VA: 0x3364CE0
	|-List<double>.Contains
	|
	|-RVA: 0x3367C90 Offset: 0x3367D91 VA: 0x3367C90
	|-List<short>.Contains
	|
	|-RVA: 0x336AC40 Offset: 0x336AD41 VA: 0x336AC40
	|-List<int>.Contains
	|
	|-RVA: 0x3370BA0 Offset: 0x3370CA1 VA: 0x3370BA0
	|-List<long>.Contains
	|
	|-RVA: 0x3373B70 Offset: 0x3373C71 VA: 0x3373B70
	|-List<InterpretedFrameInfo>.Contains
	|
	|-RVA: 0x3376B60 Offset: 0x3376C61 VA: 0x3376B60
	|-List<Nullable<Int32Enum>>.Contains
	|
	|-RVA: 0x3405930 Offset: 0x3405A31 VA: 0x3405930
	|-List<Nullable<Bounds>>.Contains
	|
	|-RVA: 0x3408EF0 Offset: 0x3408FF1 VA: 0x3408EF0
	|-List<Nullable<BoundsInt>>.Contains
	|
	|-RVA: 0x340C370 Offset: 0x340C471 VA: 0x340C370
	|-List<Nullable<Color32>>.Contains
	|
	|-RVA: 0x340F450 Offset: 0x340F551 VA: 0x340F450
	|-List<Nullable<Color>>.Contains
	|
	|-RVA: 0x3412800 Offset: 0x3412901 VA: 0x3412800
	|-List<Nullable<GradientAlphaKey>>.Contains
	|
	|-RVA: 0x34159D0 Offset: 0x3415AD1 VA: 0x34159D0
	|-List<Nullable<GradientColorKey>>.Contains
	|
	|-RVA: 0x3418E20 Offset: 0x3418F21 VA: 0x3418E20
	|-List<Nullable<Keyframe>>.Contains
	|
	|-RVA: 0x341C1A0 Offset: 0x341C2A1 VA: 0x341C1A0
	|-List<Nullable<LayerMask>>.Contains
	|
	|-RVA: 0x341F3C0 Offset: 0x341F4C1 VA: 0x341F3C0
	|-List<Nullable<Matrix4x4>>.Contains
	|
	|-RVA: 0x3422CC0 Offset: 0x3422DC1 VA: 0x3422CC0
	|-List<Nullable<Quaternion>>.Contains
	|
	|-RVA: 0x3262AE0 Offset: 0x3262BE1 VA: 0x3262AE0
	|-List<Nullable<RangeInt>>.Contains
	|
	|-RVA: 0x3265CB0 Offset: 0x3265DB1 VA: 0x3265CB0
	|-List<Nullable<Rect>>.Contains
	|
	|-RVA: 0x3269110 Offset: 0x3269211 VA: 0x3269110
	|-List<Nullable<RectInt>>.Contains
	|
	|-RVA: 0x326C4C0 Offset: 0x326C5C1 VA: 0x326C4C0
	|-List<Nullable<Vector2>>.Contains
	|
	|-RVA: 0x326F5E0 Offset: 0x326F6E1 VA: 0x326F5E0
	|-List<Nullable<Vector2Int>>.Contains
	|
	|-RVA: 0x32726D0 Offset: 0x32727D1 VA: 0x32726D0
	|-List<Nullable<Vector3>>.Contains
	|
	|-RVA: 0x3275740 Offset: 0x3275841 VA: 0x3275740
	|-List<Nullable<Vector3Int>>.Contains
	|
	|-RVA: 0x3278890 Offset: 0x3278991 VA: 0x3278890
	|-List<Nullable<Vector4>>.Contains
	|
	|-RVA: 0x327EB70 Offset: 0x327EC71 VA: 0x327EB70
	|-List<sbyte>.Contains
	|
	|-RVA: 0x3281B40 Offset: 0x3281C41 VA: 0x3281B40
	|-List<float>.Contains
	|
	|-RVA: 0x32A8DA0 Offset: 0x32A8EA1 VA: 0x32A8DA0
	|-List<ushort>.Contains
	|
	|-RVA: 0x32ABD50 Offset: 0x32ABE51 VA: 0x32ABD50
	|-List<uint>.Contains
	|
	|-RVA: 0x32AED00 Offset: 0x32AEE01 VA: 0x32AED00
	|-List<ulong>.Contains
	|
	|-RVA: 0x32B1CB0 Offset: 0x32B1DB1 VA: 0x32B1CB0
	|-List<ValueTuple<bool, Int32Enum>>.Contains
	|
	|-RVA: 0x32B4C60 Offset: 0x32B4D61 VA: 0x32B4C60
	|-List<ValueTuple<Int32Enum, int>>.Contains
	|
	|-RVA: 0x32B7C30 Offset: 0x32B7D31 VA: 0x32B7C30
	|-List<ValueTuple<Int32Enum, object>>.Contains
	|
	|-RVA: 0x32BAC80 Offset: 0x32BAD81 VA: 0x32BAC80
	|-List<ValueTuple<object, Int32Enum>>.Contains
	|
	|-RVA: 0x32BDCC0 Offset: 0x32BDDC1 VA: 0x32BDCC0
	|-List<ValueTuple<object, object>>.Contains
	|
	|-RVA: 0x32C0D00 Offset: 0x32C0E01 VA: 0x32C0D00
	|-List<ValueTuple<object, float>>.Contains
	|
	|-RVA: 0x32C3D60 Offset: 0x32C3E61 VA: 0x32C3D60
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Contains
	|
	|-RVA: 0x32C6F70 Offset: 0x32C7071 VA: 0x32C6F70
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Contains
	|
	|-RVA: 0x3110BD0 Offset: 0x3110CD1 VA: 0x3110BD0
	|-List<TexturePacker_JsonArray.Frame>.Contains
	|
	|-RVA: 0x3114170 Offset: 0x3114271 VA: 0x3114170
	|-List<TutorialUnlockFlagData>.Contains
	|
	|-RVA: 0x3117210 Offset: 0x3117311 VA: 0x3117210
	|-List<UIMainManagerAttachObject.AttachSet>.Contains
	|
	|-RVA: 0x311A3A0 Offset: 0x311A4A1 VA: 0x311A3A0
	|-List<CapEdge>.Contains
	|
	|-RVA: 0x311D7A0 Offset: 0x311D8A1 VA: 0x311D7A0
	|-List<MeshDataConnectivity.Face>.Contains
	|
	|-RVA: 0x3120810 Offset: 0x3120911 VA: 0x3120810
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Contains
	|
	|-RVA: 0x3123BF0 Offset: 0x3123CF1 VA: 0x3123BF0
	|-List<MeshFaceConnectivity.EdgeData>.Contains
	|
	|-RVA: 0x3127060 Offset: 0x3127161 VA: 0x3127060
	|-List<NavMeshBuildMarkup>.Contains
	|
	|-RVA: 0x312A310 Offset: 0x312A411 VA: 0x312A310
	|-List<NavMeshBuildSource>.Contains
	|
	|-RVA: 0x312DC60 Offset: 0x312DD61 VA: 0x312DC60
	|-List<ConstraintSource>.Contains
	|
	|-RVA: 0x3130C80 Offset: 0x3130D81 VA: 0x3130C80
	|-List<AnimatorClipInfo>.Contains
	|
	|-RVA: 0x321C830 Offset: 0x321C931 VA: 0x321C830
	|-List<BeforeRenderHelper.OrderBlock>.Contains
	|
	|-RVA: 0x321F920 Offset: 0x321FA21 VA: 0x321F920
	|-List<BoneWeight>.Contains
	|
	|-RVA: 0x3222C80 Offset: 0x3222D81 VA: 0x3222C80
	|-List<Bounds>.Contains
	|
	|-RVA: 0x3225FD0 Offset: 0x32260D1 VA: 0x3225FD0
	|-List<BoundsInt>.Contains
	|
	|-RVA: 0x3229260 Offset: 0x3229361 VA: 0x3229260
	|-List<Color32>.Contains
	|
	|-RVA: 0x322C280 Offset: 0x322C381 VA: 0x322C280
	|-List<Color>.Contains
	|
	|-RVA: 0x322F550 Offset: 0x322F651 VA: 0x322F550
	|-List<CombineInstance>.Contains
	|
	|-RVA: 0x32330B0 Offset: 0x32331B1 VA: 0x32330B0
	|-List<RaycastResult>.Contains
	|
	|-RVA: 0x3236780 Offset: 0x3236881 VA: 0x3236780
	|-List<GradientAlphaKey>.Contains
	|
	|-RVA: 0x3239860 Offset: 0x3239961 VA: 0x3239860
	|-List<GradientColorKey>.Contains
	|
	|-RVA: 0x323CC30 Offset: 0x323CD31 VA: 0x323CC30
	|-List<Keyframe>.Contains
	|
	|-RVA: 0x323FFE0 Offset: 0x32400E1 VA: 0x323FFE0
	|-List<LayerMask>.Contains
	|
	|-RVA: 0x3243120 Offset: 0x3243221 VA: 0x3243120
	|-List<Matrix4x4>.Contains
	|
	|-RVA: 0x3246770 Offset: 0x3246871 VA: 0x3246770
	|-List<ParticleSystem.Particle>.Contains
	|
	|-RVA: 0x3249B20 Offset: 0x3249C21 VA: 0x3249B20
	|-List<Playable>.Contains
	|
	|-RVA: 0x324CC10 Offset: 0x324CD11 VA: 0x324CC10
	|-List<PlayableBinding>.Contains
	|
	|-RVA: 0x324FEE0 Offset: 0x324FFE1 VA: 0x324FEE0
	|-List<PlayableGraph>.Contains
	|
	|-RVA: 0x3252EF0 Offset: 0x3252FF1 VA: 0x3252EF0
	|-List<Edge>.Contains
	|
	|-RVA: 0x3255EF0 Offset: 0x3255FF1 VA: 0x3255EF0
	|-List<Quaternion>.Contains
	|
	|-RVA: 0x3258F20 Offset: 0x3259021 VA: 0x3258F20
	|-List<RangeInt>.Contains
	|
	|-RVA: 0x325C030 Offset: 0x325C131 VA: 0x325C030
	|-List<RaycastHit2D>.Contains
	|
	|-RVA: 0x325F5A0 Offset: 0x325F6A1 VA: 0x325F5A0
	|-List<RaycastHit>.Contains
	|
	|-RVA: 0x33C1330 Offset: 0x33C1431 VA: 0x33C1330
	|-List<Rect>.Contains
	|
	|-RVA: 0x33C4360 Offset: 0x33C4461 VA: 0x33C4360
	|-List<RectInt>.Contains
	|
	|-RVA: 0x33C7390 Offset: 0x33C7491 VA: 0x33C7390
	|-List<ReflectionProbeBlendInfo>.Contains
	|
	|-RVA: 0x33CA690 Offset: 0x33CA791 VA: 0x33CA690
	|-List<SphericalHarmonicsL2>.Contains
	|
	|-RVA: 0x33CE110 Offset: 0x33CE211 VA: 0x33CE110
	|-List<VertexAttributeDescriptor>.Contains
	|
	|-RVA: 0x33D1200 Offset: 0x33D1301 VA: 0x33D1200
	|-List<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x33D45A0 Offset: 0x33D46A1 VA: 0x33D45A0
	|-List<AsyncOperationHandle<SceneInstance>>.Contains
	|
	|-RVA: 0x33D79B0 Offset: 0x33D7AB1 VA: 0x33D79B0
	|-List<DiagnosticEvent>.Contains
	|
	|-RVA: 0x33DAF00 Offset: 0x33DB001 VA: 0x33DAF00
	|-List<DelayedActionManager.DelegateInfo>.Contains
	|
	|-RVA: 0x33DE320 Offset: 0x33DE421 VA: 0x33DE320
	|-List<ObjectInitializationData>.Contains
	|
	|-RVA: 0x31B96E0 Offset: 0x31B97E1 VA: 0x31B96E0
	|-List<GlyphRect>.Contains
	|
	|-RVA: 0x31BC820 Offset: 0x31BC921 VA: 0x31BC820
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Contains
	|
	|-RVA: 0x31BFC90 Offset: 0x31BFD91 VA: 0x31BFC90
	|-List<IntervalTreeNode>.Contains
	|
	|-RVA: 0x31C3000 Offset: 0x31C3101 VA: 0x31C3000
	|-List<IntervalTree.Entry<object>>.Contains
	|
	|-RVA: 0x31C63A0 Offset: 0x31C64A1 VA: 0x31C63A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Contains
	|
	|-RVA: 0x31C96B0 Offset: 0x31C97B1 VA: 0x31C96B0
	|-List<UICharInfo>.Contains
	|
	|-RVA: 0x31CC700 Offset: 0x31CC801 VA: 0x31CC700
	|-List<FocusController.FocusedElement>.Contains
	|
	|-RVA: 0x31CF720 Offset: 0x31CF821 VA: 0x31CF720
	|-List<UILineInfo>.Contains
	|
	|-RVA: 0x31D2960 Offset: 0x31D2A61 VA: 0x31D2960
	|-List<UIVertex>.Contains
	|
	|-RVA: 0x31D6210 Offset: 0x31D6311 VA: 0x31D6210
	|-List<UnitySynchronizationContext.WorkRequest>.Contains
	|
	|-RVA: 0x31D94D0 Offset: 0x31D95D1 VA: 0x31D94D0
	|-List<Vector2>.Contains
	|
	|-RVA: 0x2CE2100 Offset: 0x2CE2201 VA: 0x2CE2100
	|-List<Vector2Int>.Contains
	|
	|-RVA: 0x2CE5100 Offset: 0x2CE5201 VA: 0x2CE5100
	|-List<Vector3>.Contains
	|
	|-RVA: 0x2CE8170 Offset: 0x2CE8271 VA: 0x2CE8170
	|-List<Vector3Int>.Contains
	|
	|-RVA: 0x2CEB240 Offset: 0x2CEB341 VA: 0x2CEB240
	|-List<Vector4>.Contains
	|
	|-RVA: 0x2CEE580 Offset: 0x2CEE681 VA: 0x2CEE580
	|-List<WarpPoints.WarpPoint>.Contains
	|
	|-RVA: 0x2CF1F80 Offset: 0x2CF2081 VA: 0x2CF1F80
	|-List<YieldItemParam>.Contains
	|
	|-RVA: 0x2CF5010 Offset: 0x2CF5111 VA: 0x2CF5010
	|-List<stCommand_t>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D340 Offset: 0x248D441 VA: 0x248D340
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x24909D0 Offset: 0x2490AD1 VA: 0x24909D0
	|-List<BuildItemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31568E0 Offset: 0x31569E1 VA: 0x31568E0
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.Contains
	|
	|-RVA: 0x3159910 Offset: 0x3159A11 VA: 0x3159910
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x315C970 Offset: 0x315CA71 VA: 0x315C970
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x315FA00 Offset: 0x315FB01 VA: 0x315FA00
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Contains
	|
	|-RVA: 0x3162A10 Offset: 0x3162B11 VA: 0x3162A10
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Contains
	|
	|-RVA: 0x31659C0 Offset: 0x3165AC1 VA: 0x31659C0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Contains
	|
	|-RVA: 0x3168B10 Offset: 0x3168C11 VA: 0x3168B10
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Contains
	|
	|-RVA: 0x316C030 Offset: 0x316C131 VA: 0x316C030
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Contains
	|
	|-RVA: 0x316F560 Offset: 0x316F661 VA: 0x316F560
	|-List<CropDataTable>.System.Collections.IList.Contains
	|
	|-RVA: 0x3172980 Offset: 0x3172A81 VA: 0x3172980
	|-List<DropItemParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x3175A60 Offset: 0x3175B61 VA: 0x3175A60
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.Contains
	|
	|-RVA: 0x31DC6F0 Offset: 0x31DC7F1 VA: 0x31DC6F0
	|-List<EventCheckId>.System.Collections.IList.Contains
	|
	|-RVA: 0x31DF990 Offset: 0x31DFA91 VA: 0x31DF990
	|-List<EventFlagProgressData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31E29E0 Offset: 0x31E2AE1 VA: 0x31E29E0
	|-List<FesNpcScoreData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31E5BE0 Offset: 0x31E5CE1 VA: 0x31E5BE0
	|-List<MiningPointSaveData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31E9120 Offset: 0x31E9221 VA: 0x31E9120
	|-List<MonsterHutSaveData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31EC4B0 Offset: 0x31EC5B1 VA: 0x31EC4B0
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Contains
	|
	|-RVA: 0x31EF6D0 Offset: 0x31EF7D1 VA: 0x31EF6D0
	|-List<NPCActionData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31F2CC0 Offset: 0x31F2DC1 VA: 0x31F2CC0
	|-List<NpcPlaceSchedule>.System.Collections.IList.Contains
	|
	|-RVA: 0x31F5F90 Offset: 0x31F6091 VA: 0x31F5F90
	|-List<OrderLotterySaveParameter>.System.Collections.IList.Contains
	|
	|-RVA: 0x31F9120 Offset: 0x31F9221 VA: 0x31F9120
	|-List<OrderSaveParameter>.System.Collections.IList.Contains
	|
	|-RVA: 0x31FC3D0 Offset: 0x31FC4D1 VA: 0x31FC3D0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Contains
	|
	|-RVA: 0x330B640 Offset: 0x330B741 VA: 0x330B640
	|-List<ShopCatalogPage>.System.Collections.IList.Contains
	|
	|-RVA: 0x330E810 Offset: 0x330E911 VA: 0x330E810
	|-List<ShopNpcTalk>.System.Collections.IList.Contains
	|
	|-RVA: 0x3311C70 Offset: 0x3311D71 VA: 0x3311C70
	|-List<SubtitleDataTable.Data>.System.Collections.IList.Contains
	|
	|-RVA: 0x3314CE0 Offset: 0x3314DE1 VA: 0x3314CE0
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.Contains
	|
	|-RVA: 0x3317D00 Offset: 0x3317E01 VA: 0x3317D00
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.Contains
	|
	|-RVA: 0x331AE90 Offset: 0x331AF91 VA: 0x331AE90
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x331E220 Offset: 0x331E321 VA: 0x331E220
	|-List<Schedule>.System.Collections.IList.Contains
	|
	|-RVA: 0x3321700 Offset: 0x3321801 VA: 0x3321700
	|-List<CurveSample>.System.Collections.IList.Contains
	|
	|-RVA: 0x3324D30 Offset: 0x3324E31 VA: 0x3324D30
	|-List<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x3327D10 Offset: 0x3327E11 VA: 0x3327D10
	|-List<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x332ACD0 Offset: 0x332ADD1 VA: 0x332ACD0
	|-List<char>.System.Collections.IList.Contains
	|
	|-RVA: 0x3358D50 Offset: 0x3358E51 VA: 0x3358D50
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x335BDA0 Offset: 0x335BEA1 VA: 0x335BDA0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x335EDF0 Offset: 0x335EEF1 VA: 0x335EDF0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3361E00 Offset: 0x3361F01 VA: 0x3361E00
	|-List<DateTime>.System.Collections.IList.Contains
	|
	|-RVA: 0x3364DB0 Offset: 0x3364EB1 VA: 0x3364DB0
	|-List<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x3367D60 Offset: 0x3367E61 VA: 0x3367D60
	|-List<short>.System.Collections.IList.Contains
	|
	|-RVA: 0x336AD10 Offset: 0x336AE11 VA: 0x336AD10
	|-List<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x336DCC0 Offset: 0x336DDC1 VA: 0x336DCC0
	|-List<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x3370C70 Offset: 0x3370D71 VA: 0x3370C70
	|-List<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x3373C50 Offset: 0x3373D51 VA: 0x3373C50
	|-List<InterpretedFrameInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x3376CD0 Offset: 0x3376DD1 VA: 0x3376CD0
	|-List<Nullable<Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3405B40 Offset: 0x3405C41 VA: 0x3405B40
	|-List<Nullable<Bounds>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3409100 Offset: 0x3409201 VA: 0x3409100
	|-List<Nullable<BoundsInt>>.System.Collections.IList.Contains
	|
	|-RVA: 0x340C4E0 Offset: 0x340C5E1 VA: 0x340C4E0
	|-List<Nullable<Color32>>.System.Collections.IList.Contains
	|
	|-RVA: 0x340F630 Offset: 0x340F731 VA: 0x340F630
	|-List<Nullable<Color>>.System.Collections.IList.Contains
	|
	|-RVA: 0x34129B0 Offset: 0x3412AB1 VA: 0x34129B0
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3415BB0 Offset: 0x3415CB1 VA: 0x3415BB0
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3419000 Offset: 0x3419101 VA: 0x3419000
	|-List<Nullable<Keyframe>>.System.Collections.IList.Contains
	|
	|-RVA: 0x341C310 Offset: 0x341C411 VA: 0x341C310
	|-List<Nullable<LayerMask>>.System.Collections.IList.Contains
	|
	|-RVA: 0x341F640 Offset: 0x341F741 VA: 0x341F640
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3422EA0 Offset: 0x3422FA1 VA: 0x3422EA0
	|-List<Nullable<Quaternion>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3262C90 Offset: 0x3262D91 VA: 0x3262C90
	|-List<Nullable<RangeInt>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3265E90 Offset: 0x3265F91 VA: 0x3265E90
	|-List<Nullable<Rect>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32692F0 Offset: 0x32693F1 VA: 0x32692F0
	|-List<Nullable<RectInt>>.System.Collections.IList.Contains
	|
	|-RVA: 0x326C670 Offset: 0x326C771 VA: 0x326C670
	|-List<Nullable<Vector2>>.System.Collections.IList.Contains
	|
	|-RVA: 0x326F790 Offset: 0x326F891 VA: 0x326F790
	|-List<Nullable<Vector2Int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3272860 Offset: 0x3272961 VA: 0x3272860
	|-List<Nullable<Vector3>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32758D0 Offset: 0x32759D1 VA: 0x32758D0
	|-List<Nullable<Vector3Int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3278A70 Offset: 0x3278B71 VA: 0x3278A70
	|-List<Nullable<Vector4>>.System.Collections.IList.Contains
	|
	|-RVA: 0x327BCC0 Offset: 0x327BDC1 VA: 0x327BCC0
	|-List<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x327EC50 Offset: 0x327ED51 VA: 0x327EC50
	|-List<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x3281C10 Offset: 0x3281D11 VA: 0x3281C10
	|-List<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x32A8E70 Offset: 0x32A8F71 VA: 0x32A8E70
	|-List<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x32ABE20 Offset: 0x32ABF21 VA: 0x32ABE20
	|-List<uint>.System.Collections.IList.Contains
	|
	|-RVA: 0x32AEDD0 Offset: 0x32AEED1 VA: 0x32AEDD0
	|-List<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x32B1D80 Offset: 0x32B1E81 VA: 0x32B1D80
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32B4D30 Offset: 0x32B4E31 VA: 0x32B4D30
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32B7D10 Offset: 0x32B7E11 VA: 0x32B7D10
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32BAD60 Offset: 0x32BAE61 VA: 0x32BAD60
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32BDDA0 Offset: 0x32BDEA1 VA: 0x32BDDA0
	|-List<ValueTuple<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32C0DE0 Offset: 0x32C0EE1 VA: 0x32C0DE0
	|-List<ValueTuple<object, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32C3E50 Offset: 0x32C3F51 VA: 0x32C3E50
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Contains
	|
	|-RVA: 0x32C70D0 Offset: 0x32C71D1 VA: 0x32C70D0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x3110D30 Offset: 0x3110E31 VA: 0x3110D30
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Contains
	|
	|-RVA: 0x3114260 Offset: 0x3114361 VA: 0x3114260
	|-List<TutorialUnlockFlagData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31172F0 Offset: 0x31173F1 VA: 0x31172F0
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Contains
	|
	|-RVA: 0x311A4F0 Offset: 0x311A5F1 VA: 0x311A4F0
	|-List<CapEdge>.System.Collections.IList.Contains
	|
	|-RVA: 0x311D870 Offset: 0x311D971 VA: 0x311D870
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.Contains
	|
	|-RVA: 0x3120930 Offset: 0x3120A31 VA: 0x3120930
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3123D30 Offset: 0x3123E31 VA: 0x3123D30
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x3127140 Offset: 0x3127241 VA: 0x3127140
	|-List<NavMeshBuildMarkup>.System.Collections.IList.Contains
	|
	|-RVA: 0x312A4D0 Offset: 0x312A5D1 VA: 0x312A4D0
	|-List<NavMeshBuildSource>.System.Collections.IList.Contains
	|
	|-RVA: 0x312DD40 Offset: 0x312DE41 VA: 0x312DD40
	|-List<ConstraintSource>.System.Collections.IList.Contains
	|
	|-RVA: 0x3130D50 Offset: 0x3130E51 VA: 0x3130D50
	|-List<AnimatorClipInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x321C910 Offset: 0x321CA11 VA: 0x321C910
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|
	|-RVA: 0x321FA40 Offset: 0x321FB41 VA: 0x321FA40
	|-List<BoneWeight>.System.Collections.IList.Contains
	|
	|-RVA: 0x3222DA0 Offset: 0x3222EA1 VA: 0x3222DA0
	|-List<Bounds>.System.Collections.IList.Contains
	|
	|-RVA: 0x32260F0 Offset: 0x32261F1 VA: 0x32260F0
	|-List<BoundsInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x3229340 Offset: 0x3229441 VA: 0x3229340
	|-List<Color32>.System.Collections.IList.Contains
	|
	|-RVA: 0x322C380 Offset: 0x322C481 VA: 0x322C380
	|-List<Color>.System.Collections.IList.Contains
	|
	|-RVA: 0x322F710 Offset: 0x322F811 VA: 0x322F710
	|-List<CombineInstance>.System.Collections.IList.Contains
	|
	|-RVA: 0x3233230 Offset: 0x3233331 VA: 0x3233230
	|-List<RaycastResult>.System.Collections.IList.Contains
	|
	|-RVA: 0x3236860 Offset: 0x3236961 VA: 0x3236860
	|-List<GradientAlphaKey>.System.Collections.IList.Contains
	|
	|-RVA: 0x3239980 Offset: 0x3239A81 VA: 0x3239980
	|-List<GradientColorKey>.System.Collections.IList.Contains
	|
	|-RVA: 0x323CD70 Offset: 0x323CE71 VA: 0x323CD70
	|-List<Keyframe>.System.Collections.IList.Contains
	|
	|-RVA: 0x32400C0 Offset: 0x32401C1 VA: 0x32400C0
	|-List<LayerMask>.System.Collections.IList.Contains
	|
	|-RVA: 0x3243280 Offset: 0x3243381 VA: 0x3243280
	|-List<Matrix4x4>.System.Collections.IList.Contains
	|
	|-RVA: 0x32468A0 Offset: 0x32469A1 VA: 0x32468A0
	|-List<ParticleSystem.Particle>.System.Collections.IList.Contains
	|
	|-RVA: 0x3249C00 Offset: 0x3249D01 VA: 0x3249C00
	|-List<Playable>.System.Collections.IList.Contains
	|
	|-RVA: 0x324CD30 Offset: 0x324CE31 VA: 0x324CD30
	|-List<PlayableBinding>.System.Collections.IList.Contains
	|
	|-RVA: 0x324FFC0 Offset: 0x32500C1 VA: 0x324FFC0
	|-List<PlayableGraph>.System.Collections.IList.Contains
	|
	|-RVA: 0x3252FC0 Offset: 0x32530C1 VA: 0x3252FC0
	|-List<Edge>.System.Collections.IList.Contains
	|
	|-RVA: 0x3255FF0 Offset: 0x32560F1 VA: 0x3255FF0
	|-List<Quaternion>.System.Collections.IList.Contains
	|
	|-RVA: 0x3258FF0 Offset: 0x32590F1 VA: 0x3258FF0
	|-List<RangeInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x325C180 Offset: 0x325C281 VA: 0x325C180
	|-List<RaycastHit2D>.System.Collections.IList.Contains
	|
	|-RVA: 0x325F700 Offset: 0x325F801 VA: 0x325F700
	|-List<RaycastHit>.System.Collections.IList.Contains
	|
	|-RVA: 0x33C1430 Offset: 0x33C1531 VA: 0x33C1430
	|-List<Rect>.System.Collections.IList.Contains
	|
	|-RVA: 0x33C4440 Offset: 0x33C4541 VA: 0x33C4440
	|-List<RectInt>.System.Collections.IList.Contains
	|
	|-RVA: 0x33C7470 Offset: 0x33C7571 VA: 0x33C7470
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x33CA870 Offset: 0x33CA971 VA: 0x33CA870
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Contains
	|
	|-RVA: 0x33CE1F0 Offset: 0x33CE2F1 VA: 0x33CE1F0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Contains
	|
	|-RVA: 0x33D1320 Offset: 0x33D1421 VA: 0x33D1320
	|-List<AsyncOperationHandle>.System.Collections.IList.Contains
	|
	|-RVA: 0x33D46C0 Offset: 0x33D47C1 VA: 0x33D46C0
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Contains
	|
	|-RVA: 0x33D7AF0 Offset: 0x33D7BF1 VA: 0x33D7AF0
	|-List<DiagnosticEvent>.System.Collections.IList.Contains
	|
	|-RVA: 0x33DB020 Offset: 0x33DB121 VA: 0x33DB020
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x33DE460 Offset: 0x33DE561 VA: 0x33DE460
	|-List<ObjectInitializationData>.System.Collections.IList.Contains
	|
	|-RVA: 0x31B97C0 Offset: 0x31B98C1 VA: 0x31B97C0
	|-List<GlyphRect>.System.Collections.IList.Contains
	|
	|-RVA: 0x31BC960 Offset: 0x31BCA61 VA: 0x31BC960
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x31BFDB0 Offset: 0x31BFEB1 VA: 0x31BFDB0
	|-List<IntervalTreeNode>.System.Collections.IList.Contains
	|
	|-RVA: 0x31C3120 Offset: 0x31C3221 VA: 0x31C3120
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x31C64C0 Offset: 0x31C65C1 VA: 0x31C64C0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x31C97A0 Offset: 0x31C98A1 VA: 0x31C97A0
	|-List<UICharInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x31CC7E0 Offset: 0x31CC8E1 VA: 0x31CC7E0
	|-List<FocusController.FocusedElement>.System.Collections.IList.Contains
	|
	|-RVA: 0x31CF800 Offset: 0x31CF901 VA: 0x31CF800
	|-List<UILineInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x31D2B00 Offset: 0x31D2C01 VA: 0x31D2B00
	|-List<UIVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x31D6330 Offset: 0x31D6431 VA: 0x31D6330
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x31D95B0 Offset: 0x31D96B1 VA: 0x31D95B0
	|-List<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CE21D0 Offset: 0x2CE22D1 VA: 0x2CE21D0
	|-List<Vector2Int>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CE51F0 Offset: 0x2CE52F1 VA: 0x2CE51F0
	|-List<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CE8260 Offset: 0x2CE8361 VA: 0x2CE8260
	|-List<Vector3Int>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CEB340 Offset: 0x2CEB441 VA: 0x2CEB340
	|-List<Vector4>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CEE760 Offset: 0x2CEE861 VA: 0x2CEE760
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CF2050 Offset: 0x2CF2151 VA: 0x2CF2050
	|-List<YieldItemParam>.System.Collections.IList.Contains
	|
	|-RVA: 0x2CF5130 Offset: 0x2CF5231 VA: 0x2CF5130
	|-List<stCommand_t>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D490 Offset: 0x248D591 VA: 0x248D490
	|-List<AS_ToolController.ChargeInfo>.CopyTo
	|
	|-RVA: 0x2490B50 Offset: 0x2490C51 VA: 0x2490B50
	|-List<BuildItemData>.CopyTo
	|
	|-RVA: 0x3156A30 Offset: 0x3156B31 VA: 0x3156A30
	|-List<ButtonLinker.LinkObject>.CopyTo
	|
	|-RVA: 0x3159A60 Offset: 0x3159B61 VA: 0x3159A60
	|-List<CharaCallTable.BustupTable>.CopyTo
	|
	|-RVA: 0x315CAC0 Offset: 0x315CBC1 VA: 0x315CAC0
	|-List<CharaCallTable.CharaFaceIconTable>.CopyTo
	|
	|-RVA: 0x315FB50 Offset: 0x315FC51 VA: 0x315FB50
	|-List<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3162B60 Offset: 0x3162C61 VA: 0x3162B60
	|-List<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3165B10 Offset: 0x3165C11 VA: 0x3165B10
	|-List<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3168C70 Offset: 0x3168D71 VA: 0x3168C70
	|-List<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x316C190 Offset: 0x316C291 VA: 0x316C190
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	|
	|-RVA: 0x316F6B0 Offset: 0x316F7B1 VA: 0x316F6B0
	|-List<CropDataTable>.CopyTo
	|
	|-RVA: 0x3172AD0 Offset: 0x3172BD1 VA: 0x3172AD0
	|-List<DropItemParam>.CopyTo
	|
	|-RVA: 0x3175BB0 Offset: 0x3175CB1 VA: 0x3175BB0
	|-List<ErosionBrush.UndoStep>.CopyTo
	|
	|-RVA: 0x31DC840 Offset: 0x31DC941 VA: 0x31DC840
	|-List<EventCheckId>.CopyTo
	|
	|-RVA: 0x31DFAE0 Offset: 0x31DFBE1 VA: 0x31DFAE0
	|-List<EventFlagProgressData>.CopyTo
	|
	|-RVA: 0x31E2B30 Offset: 0x31E2C31 VA: 0x31E2B30
	|-List<FesNpcScoreData>.CopyTo
	|
	|-RVA: 0x31E5D40 Offset: 0x31E5E41 VA: 0x31E5D40
	|-List<MiningPointSaveData>.CopyTo
	|
	|-RVA: 0x31E9280 Offset: 0x31E9381 VA: 0x31E9280
	|-List<MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x31EC600 Offset: 0x31EC701 VA: 0x31EC600
	|-List<MoviePlayer.SUBTITLEDATA>.CopyTo
	|
	|-RVA: 0x31EF830 Offset: 0x31EF931 VA: 0x31EF830
	|-List<NPCActionData>.CopyTo
	|
	|-RVA: 0x31F2E10 Offset: 0x31F2F11 VA: 0x31F2E10
	|-List<NpcPlaceSchedule>.CopyTo
	|
	|-RVA: 0x31F60E0 Offset: 0x31F61E1 VA: 0x31F60E0
	|-List<OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x31F9270 Offset: 0x31F9371 VA: 0x31F9270
	|-List<OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x31FC520 Offset: 0x31FC621 VA: 0x31FC520
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x330B790 Offset: 0x330B891 VA: 0x330B790
	|-List<ShopCatalogPage>.CopyTo
	|
	|-RVA: 0x330E970 Offset: 0x330EA71 VA: 0x330E970
	|-List<ShopNpcTalk>.CopyTo
	|
	|-RVA: 0x3311DC0 Offset: 0x3311EC1 VA: 0x3311DC0
	|-List<SubtitleDataTable.Data>.CopyTo
	|
	|-RVA: 0x3314E30 Offset: 0x3314F31 VA: 0x3314E30
	|-List<SubtitleDataTable.DataList>.CopyTo
	|
	|-RVA: 0x3317E50 Offset: 0x3317F51 VA: 0x3317E50
	|-List<SubtitleHudDataTable.Data>.CopyTo
	|
	|-RVA: 0x331AFE0 Offset: 0x331B0E1 VA: 0x331AFE0
	|-List<SRMonoBehaviourEx.FieldInfo>.CopyTo
	|
	|-RVA: 0x331E370 Offset: 0x331E471 VA: 0x331E370
	|-List<Schedule>.CopyTo
	|
	|-RVA: 0x3321870 Offset: 0x3321971 VA: 0x3321870
	|-List<CurveSample>.CopyTo
	|
	|-RVA: 0x3324E80 Offset: 0x3324F81 VA: 0x3324E80
	|-List<bool>.CopyTo
	|
	|-RVA: 0x3327E60 Offset: 0x3327F61 VA: 0x3327E60
	|-List<byte>.CopyTo
	|
	|-RVA: 0x332AE20 Offset: 0x332AF21 VA: 0x332AE20
	|-List<char>.CopyTo
	|
	|-RVA: 0x3358EA0 Offset: 0x3358FA1 VA: 0x3358EA0
	|-List<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x335BEF0 Offset: 0x335BFF1 VA: 0x335BEF0
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x335EF40 Offset: 0x335F041 VA: 0x335EF40
	|-List<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3361F50 Offset: 0x3362051 VA: 0x3361F50
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x3364F00 Offset: 0x3365001 VA: 0x3364F00
	|-List<double>.CopyTo
	|
	|-RVA: 0x3367EB0 Offset: 0x3367FB1 VA: 0x3367EB0
	|-List<short>.CopyTo
	|
	|-RVA: 0x336AE60 Offset: 0x336AF61 VA: 0x336AE60
	|-List<int>.CopyTo
	|
	|-RVA: 0x336DE10 Offset: 0x336DF11 VA: 0x336DE10
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x3370DC0 Offset: 0x3370EC1 VA: 0x3370DC0
	|-List<long>.CopyTo
	|
	|-RVA: 0x3373DA0 Offset: 0x3373EA1 VA: 0x3373DA0
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3376E20 Offset: 0x3376F21 VA: 0x3376E20
	|-List<Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x3405CB0 Offset: 0x3405DB1 VA: 0x3405CB0
	|-List<Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x3409270 Offset: 0x3409371 VA: 0x3409270
	|-List<Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x340C630 Offset: 0x340C731 VA: 0x340C630
	|-List<Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x340F7A0 Offset: 0x340F8A1 VA: 0x340F7A0
	|-List<Nullable<Color>>.CopyTo
	|
	|-RVA: 0x3412B00 Offset: 0x3412C01 VA: 0x3412B00
	|-List<Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x3415D20 Offset: 0x3415E21 VA: 0x3415D20
	|-List<Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x3419170 Offset: 0x3419271 VA: 0x3419170
	|-List<Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x341C460 Offset: 0x341C561 VA: 0x341C460
	|-List<Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x341F7C0 Offset: 0x341F8C1 VA: 0x341F7C0
	|-List<Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x3423010 Offset: 0x3423111 VA: 0x3423010
	|-List<Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x3262DE0 Offset: 0x3262EE1 VA: 0x3262DE0
	|-List<Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x3266000 Offset: 0x3266101 VA: 0x3266000
	|-List<Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x3269460 Offset: 0x3269561 VA: 0x3269460
	|-List<Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x326C7C0 Offset: 0x326C8C1 VA: 0x326C7C0
	|-List<Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x326F8E0 Offset: 0x326F9E1 VA: 0x326F8E0
	|-List<Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x32729B0 Offset: 0x3272AB1 VA: 0x32729B0
	|-List<Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x3275A20 Offset: 0x3275B21 VA: 0x3275A20
	|-List<Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x3278BE0 Offset: 0x3278CE1 VA: 0x3278BE0
	|-List<Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x327BE00 Offset: 0x327BF01 VA: 0x327BE00
	|-List<object>.CopyTo
	|-List<MethodBase>.CopyTo
	|-List<MethodInfo>.CopyTo
	|
	|-RVA: 0x327EDA0 Offset: 0x327EEA1 VA: 0x327EDA0
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x3281D60 Offset: 0x3281E61 VA: 0x3281D60
	|-List<float>.CopyTo
	|
	|-RVA: 0x32A8FC0 Offset: 0x32A90C1 VA: 0x32A8FC0
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x32ABF70 Offset: 0x32AC071 VA: 0x32ABF70
	|-List<uint>.CopyTo
	|
	|-RVA: 0x32AEF20 Offset: 0x32AF021 VA: 0x32AEF20
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x32B1ED0 Offset: 0x32B1FD1 VA: 0x32B1ED0
	|-List<ValueTuple<bool, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32B4E80 Offset: 0x32B4F81 VA: 0x32B4E80
	|-List<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x32B7E60 Offset: 0x32B7F61 VA: 0x32B7E60
	|-List<ValueTuple<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x32BAEB0 Offset: 0x32BAFB1 VA: 0x32BAEB0
	|-List<ValueTuple<object, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32BDEF0 Offset: 0x32BDFF1 VA: 0x32BDEF0
	|-List<ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x32C0F30 Offset: 0x32C1031 VA: 0x32C0F30
	|-List<ValueTuple<object, float>>.CopyTo
	|
	|-RVA: 0x32C3FA0 Offset: 0x32C40A1 VA: 0x32C3FA0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32C7230 Offset: 0x32C7331 VA: 0x32C7230
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CopyTo
	|
	|-RVA: 0x3110E90 Offset: 0x3110F91 VA: 0x3110E90
	|-List<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x31143B0 Offset: 0x31144B1 VA: 0x31143B0
	|-List<TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x3117440 Offset: 0x3117541 VA: 0x3117440
	|-List<UIMainManagerAttachObject.AttachSet>.CopyTo
	|
	|-RVA: 0x311A650 Offset: 0x311A751 VA: 0x311A650
	|-List<CapEdge>.CopyTo
	|
	|-RVA: 0x311D9C0 Offset: 0x311DAC1 VA: 0x311D9C0
	|-List<MeshDataConnectivity.Face>.CopyTo
	|
	|-RVA: 0x3120A80 Offset: 0x3120B81 VA: 0x3120A80
	|-List<MeshFaceConnectivity.EdgeData.SideData>.CopyTo
	|
	|-RVA: 0x3123E90 Offset: 0x3123F91 VA: 0x3123E90
	|-List<MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x3127290 Offset: 0x3127391 VA: 0x3127290
	|-List<NavMeshBuildMarkup>.CopyTo
	|
	|-RVA: 0x312A650 Offset: 0x312A751 VA: 0x312A650
	|-List<NavMeshBuildSource>.CopyTo
	|
	|-RVA: 0x312DE90 Offset: 0x312DF91 VA: 0x312DE90
	|-List<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3130EA0 Offset: 0x3130FA1 VA: 0x3130EA0
	|-List<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x321CA60 Offset: 0x321CB61 VA: 0x321CA60
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x321FB90 Offset: 0x321FC91 VA: 0x321FB90
	|-List<BoneWeight>.CopyTo
	|
	|-RVA: 0x3222EF0 Offset: 0x3222FF1 VA: 0x3222EF0
	|-List<Bounds>.CopyTo
	|
	|-RVA: 0x3226240 Offset: 0x3226341 VA: 0x3226240
	|-List<BoundsInt>.CopyTo
	|
	|-RVA: 0x3229490 Offset: 0x3229591 VA: 0x3229490
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x322C4D0 Offset: 0x322C5D1 VA: 0x322C4D0
	|-List<Color>.CopyTo
	|
	|-RVA: 0x322F890 Offset: 0x322F991 VA: 0x322F890
	|-List<CombineInstance>.CopyTo
	|
	|-RVA: 0x32333A0 Offset: 0x32334A1 VA: 0x32333A0
	|-List<RaycastResult>.CopyTo
	|
	|-RVA: 0x32369B0 Offset: 0x3236AB1 VA: 0x32369B0
	|-List<GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x3239AD0 Offset: 0x3239BD1 VA: 0x3239AD0
	|-List<GradientColorKey>.CopyTo
	|
	|-RVA: 0x323CED0 Offset: 0x323CFD1 VA: 0x323CED0
	|-List<Keyframe>.CopyTo
	|
	|-RVA: 0x3240210 Offset: 0x3240311 VA: 0x3240210
	|-List<LayerMask>.CopyTo
	|
	|-RVA: 0x32433E0 Offset: 0x32434E1 VA: 0x32433E0
	|-List<Matrix4x4>.CopyTo
	|
	|-RVA: 0x32469F0 Offset: 0x3246AF1 VA: 0x32469F0
	|-List<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x3249D50 Offset: 0x3249E51 VA: 0x3249D50
	|-List<Playable>.CopyTo
	|
	|-RVA: 0x324CE80 Offset: 0x324CF81 VA: 0x324CE80
	|-List<PlayableBinding>.CopyTo
	|
	|-RVA: 0x3250110 Offset: 0x3250211 VA: 0x3250110
	|-List<PlayableGraph>.CopyTo
	|
	|-RVA: 0x3253110 Offset: 0x3253211 VA: 0x3253110
	|-List<Edge>.CopyTo
	|
	|-RVA: 0x3256140 Offset: 0x3256241 VA: 0x3256140
	|-List<Quaternion>.CopyTo
	|
	|-RVA: 0x3259140 Offset: 0x3259241 VA: 0x3259140
	|-List<RangeInt>.CopyTo
	|
	|-RVA: 0x325C2E0 Offset: 0x325C3E1 VA: 0x325C2E0
	|-List<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x325F860 Offset: 0x325F961 VA: 0x325F860
	|-List<RaycastHit>.CopyTo
	|
	|-RVA: 0x33C1580 Offset: 0x33C1681 VA: 0x33C1580
	|-List<Rect>.CopyTo
	|
	|-RVA: 0x33C4590 Offset: 0x33C4691 VA: 0x33C4590
	|-List<RectInt>.CopyTo
	|
	|-RVA: 0x33C75C0 Offset: 0x33C76C1 VA: 0x33C75C0
	|-List<ReflectionProbeBlendInfo>.CopyTo
	|
	|-RVA: 0x33CA9F0 Offset: 0x33CAAF1 VA: 0x33CA9F0
	|-List<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x33CE340 Offset: 0x33CE441 VA: 0x33CE340
	|-List<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x33D1470 Offset: 0x33D1571 VA: 0x33D1470
	|-List<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x33D4810 Offset: 0x33D4911 VA: 0x33D4810
	|-List<AsyncOperationHandle<SceneInstance>>.CopyTo
	|
	|-RVA: 0x33D7C50 Offset: 0x33D7D51 VA: 0x33D7C50
	|-List<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x33DB170 Offset: 0x33DB271 VA: 0x33DB170
	|-List<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x33DE5C0 Offset: 0x33DE6C1 VA: 0x33DE5C0
	|-List<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x31B9910 Offset: 0x31B9A11 VA: 0x31B9910
	|-List<GlyphRect>.CopyTo
	|
	|-RVA: 0x31BCAC0 Offset: 0x31BCBC1 VA: 0x31BCAC0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x31BFF00 Offset: 0x31C0001 VA: 0x31BFF00
	|-List<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x31C3270 Offset: 0x31C3371 VA: 0x31C3270
	|-List<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x31C6610 Offset: 0x31C6711 VA: 0x31C6610
	|-List<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x31C98F0 Offset: 0x31C99F1 VA: 0x31C98F0
	|-List<UICharInfo>.CopyTo
	|
	|-RVA: 0x31CC930 Offset: 0x31CCA31 VA: 0x31CC930
	|-List<FocusController.FocusedElement>.CopyTo
	|
	|-RVA: 0x31CF950 Offset: 0x31CFA51 VA: 0x31CF950
	|-List<UILineInfo>.CopyTo
	|
	|-RVA: 0x31D2C70 Offset: 0x31D2D71 VA: 0x31D2C70
	|-List<UIVertex>.CopyTo
	|
	|-RVA: 0x31D6480 Offset: 0x31D6581 VA: 0x31D6480
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x31D9700 Offset: 0x31D9801 VA: 0x31D9700
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x2CE2320 Offset: 0x2CE2421 VA: 0x2CE2320
	|-List<Vector2Int>.CopyTo
	|
	|-RVA: 0x2CE5340 Offset: 0x2CE5441 VA: 0x2CE5340
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x2CE83B0 Offset: 0x2CE84B1 VA: 0x2CE83B0
	|-List<Vector3Int>.CopyTo
	|
	|-RVA: 0x2CEB490 Offset: 0x2CEB591 VA: 0x2CEB490
	|-List<Vector4>.CopyTo
	|
	|-RVA: 0x2CEE8E0 Offset: 0x2CEE9E1 VA: 0x2CEE8E0
	|-List<WarpPoints.WarpPoint>.CopyTo
	|
	|-RVA: 0x2CF21A0 Offset: 0x2CF22A1 VA: 0x2CF21A0
	|-List<YieldItemParam>.CopyTo
	|
	|-RVA: 0x2CF5280 Offset: 0x2CF5381 VA: 0x2CF5280
	|-List<stCommand_t>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D4C0 Offset: 0x248D5C1 VA: 0x248D4C0
	|-List<AS_ToolController.ChargeInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2490B80 Offset: 0x2490C81 VA: 0x2490B80
	|-List<BuildItemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3156A60 Offset: 0x3156B61 VA: 0x3156A60
	|-List<ButtonLinker.LinkObject>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3159A90 Offset: 0x3159B91 VA: 0x3159A90
	|-List<CharaCallTable.BustupTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x315CAF0 Offset: 0x315CBF1 VA: 0x315CAF0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x315FB80 Offset: 0x315FC81 VA: 0x315FB80
	|-List<CameraState.CustomBlendable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3162B90 Offset: 0x3162C91 VA: 0x3162B90
	|-List<CinemachineClearShot.Pair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3165B40 Offset: 0x3165C41 VA: 0x3165B40
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3168CA0 Offset: 0x3168DA1 VA: 0x3168CA0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x316C1C0 Offset: 0x316C2C1 VA: 0x316C1C0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x316F6E0 Offset: 0x316F7E1 VA: 0x316F6E0
	|-List<CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3172B00 Offset: 0x3172C01 VA: 0x3172B00
	|-List<DropItemParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3175BE0 Offset: 0x3175CE1 VA: 0x3175BE0
	|-List<ErosionBrush.UndoStep>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31DC870 Offset: 0x31DC971 VA: 0x31DC870
	|-List<EventCheckId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31DFB10 Offset: 0x31DFC11 VA: 0x31DFB10
	|-List<EventFlagProgressData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31E2B60 Offset: 0x31E2C61 VA: 0x31E2B60
	|-List<FesNpcScoreData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31E5D70 Offset: 0x31E5E71 VA: 0x31E5D70
	|-List<MiningPointSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31E92B0 Offset: 0x31E93B1 VA: 0x31E92B0
	|-List<MonsterHutSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31EC630 Offset: 0x31EC731 VA: 0x31EC630
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31EF860 Offset: 0x31EF961 VA: 0x31EF860
	|-List<NPCActionData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31F2E40 Offset: 0x31F2F41 VA: 0x31F2E40
	|-List<NpcPlaceSchedule>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31F6110 Offset: 0x31F6211 VA: 0x31F6110
	|-List<OrderLotterySaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31F92A0 Offset: 0x31F93A1 VA: 0x31F92A0
	|-List<OrderSaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31FC550 Offset: 0x31FC651 VA: 0x31FC550
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x330B7C0 Offset: 0x330B8C1 VA: 0x330B7C0
	|-List<ShopCatalogPage>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x330E9A0 Offset: 0x330EAA1 VA: 0x330E9A0
	|-List<ShopNpcTalk>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3311DF0 Offset: 0x3311EF1 VA: 0x3311DF0
	|-List<SubtitleDataTable.Data>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3314E60 Offset: 0x3314F61 VA: 0x3314E60
	|-List<SubtitleDataTable.DataList>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3317E80 Offset: 0x3317F81 VA: 0x3317E80
	|-List<SubtitleHudDataTable.Data>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x331B010 Offset: 0x331B111 VA: 0x331B010
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x331E3A0 Offset: 0x331E4A1 VA: 0x331E3A0
	|-List<Schedule>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33218A0 Offset: 0x33219A1 VA: 0x33218A0
	|-List<CurveSample>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3324EB0 Offset: 0x3324FB1 VA: 0x3324EB0
	|-List<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3327E90 Offset: 0x3327F91 VA: 0x3327E90
	|-List<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x332AE50 Offset: 0x332AF51 VA: 0x332AE50
	|-List<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3358ED0 Offset: 0x3358FD1 VA: 0x3358ED0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x335BF20 Offset: 0x335C021 VA: 0x335BF20
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x335EF70 Offset: 0x335F071 VA: 0x335EF70
	|-List<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3361F80 Offset: 0x3362081 VA: 0x3361F80
	|-List<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3364F30 Offset: 0x3365031 VA: 0x3364F30
	|-List<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3367EE0 Offset: 0x3367FE1 VA: 0x3367EE0
	|-List<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x336AE90 Offset: 0x336AF91 VA: 0x336AE90
	|-List<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x336DE40 Offset: 0x336DF41 VA: 0x336DE40
	|-List<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3370DF0 Offset: 0x3370EF1 VA: 0x3370DF0
	|-List<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3373DD0 Offset: 0x3373ED1 VA: 0x3373DD0
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3376E50 Offset: 0x3376F51 VA: 0x3376E50
	|-List<Nullable<Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3405CE0 Offset: 0x3405DE1 VA: 0x3405CE0
	|-List<Nullable<Bounds>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x34092A0 Offset: 0x34093A1 VA: 0x34092A0
	|-List<Nullable<BoundsInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x340C660 Offset: 0x340C761 VA: 0x340C660
	|-List<Nullable<Color32>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x340F7D0 Offset: 0x340F8D1 VA: 0x340F7D0
	|-List<Nullable<Color>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3412B30 Offset: 0x3412C31 VA: 0x3412B30
	|-List<Nullable<GradientAlphaKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3415D50 Offset: 0x3415E51 VA: 0x3415D50
	|-List<Nullable<GradientColorKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x34191A0 Offset: 0x34192A1 VA: 0x34191A0
	|-List<Nullable<Keyframe>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x341C490 Offset: 0x341C591 VA: 0x341C490
	|-List<Nullable<LayerMask>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x341F7F0 Offset: 0x341F8F1 VA: 0x341F7F0
	|-List<Nullable<Matrix4x4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3423040 Offset: 0x3423141 VA: 0x3423040
	|-List<Nullable<Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3262E10 Offset: 0x3262F11 VA: 0x3262E10
	|-List<Nullable<RangeInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3266030 Offset: 0x3266131 VA: 0x3266030
	|-List<Nullable<Rect>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3269490 Offset: 0x3269591 VA: 0x3269490
	|-List<Nullable<RectInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x326C7F0 Offset: 0x326C8F1 VA: 0x326C7F0
	|-List<Nullable<Vector2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x326F910 Offset: 0x326FA11 VA: 0x326F910
	|-List<Nullable<Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32729E0 Offset: 0x3272AE1 VA: 0x32729E0
	|-List<Nullable<Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3275A50 Offset: 0x3275B51 VA: 0x3275A50
	|-List<Nullable<Vector3Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3278C10 Offset: 0x3278D11 VA: 0x3278C10
	|-List<Nullable<Vector4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x327BE30 Offset: 0x327BF31 VA: 0x327BE30
	|-List<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x327EDD0 Offset: 0x327EED1 VA: 0x327EDD0
	|-List<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3281D90 Offset: 0x3281E91 VA: 0x3281D90
	|-List<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32A8FF0 Offset: 0x32A90F1 VA: 0x32A8FF0
	|-List<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32ABFA0 Offset: 0x32AC0A1 VA: 0x32ABFA0
	|-List<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32AEF50 Offset: 0x32AF051 VA: 0x32AEF50
	|-List<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32B1F00 Offset: 0x32B2001 VA: 0x32B1F00
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32B4EB0 Offset: 0x32B4FB1 VA: 0x32B4EB0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32B7E90 Offset: 0x32B7F91 VA: 0x32B7E90
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32BAEE0 Offset: 0x32BAFE1 VA: 0x32BAEE0
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32BDF20 Offset: 0x32BE021 VA: 0x32BDF20
	|-List<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32C0F60 Offset: 0x32C1061 VA: 0x32C0F60
	|-List<ValueTuple<object, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32C3FD0 Offset: 0x32C40D1 VA: 0x32C3FD0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32C7260 Offset: 0x32C7361 VA: 0x32C7260
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3110EC0 Offset: 0x3110FC1 VA: 0x3110EC0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31143E0 Offset: 0x31144E1 VA: 0x31143E0
	|-List<TutorialUnlockFlagData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3117470 Offset: 0x3117571 VA: 0x3117470
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x311A680 Offset: 0x311A781 VA: 0x311A680
	|-List<CapEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x311D9F0 Offset: 0x311DAF1 VA: 0x311D9F0
	|-List<MeshDataConnectivity.Face>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3120AB0 Offset: 0x3120BB1 VA: 0x3120AB0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3123EC0 Offset: 0x3123FC1 VA: 0x3123EC0
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31272C0 Offset: 0x31273C1 VA: 0x31272C0
	|-List<NavMeshBuildMarkup>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x312A680 Offset: 0x312A781 VA: 0x312A680
	|-List<NavMeshBuildSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x312DEC0 Offset: 0x312DFC1 VA: 0x312DEC0
	|-List<ConstraintSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3130ED0 Offset: 0x3130FD1 VA: 0x3130ED0
	|-List<AnimatorClipInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x321CA90 Offset: 0x321CB91 VA: 0x321CA90
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x321FBC0 Offset: 0x321FCC1 VA: 0x321FBC0
	|-List<BoneWeight>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3222F20 Offset: 0x3223021 VA: 0x3222F20
	|-List<Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3226270 Offset: 0x3226371 VA: 0x3226270
	|-List<BoundsInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32294C0 Offset: 0x32295C1 VA: 0x32294C0
	|-List<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x322C500 Offset: 0x322C601 VA: 0x322C500
	|-List<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x322F8C0 Offset: 0x322F9C1 VA: 0x322F8C0
	|-List<CombineInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32333D0 Offset: 0x32334D1 VA: 0x32333D0
	|-List<RaycastResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x32369E0 Offset: 0x3236AE1 VA: 0x32369E0
	|-List<GradientAlphaKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3239B00 Offset: 0x3239C01 VA: 0x3239B00
	|-List<GradientColorKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x323CF00 Offset: 0x323D001 VA: 0x323CF00
	|-List<Keyframe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3240240 Offset: 0x3240341 VA: 0x3240240
	|-List<LayerMask>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3243410 Offset: 0x3243511 VA: 0x3243410
	|-List<Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3246A20 Offset: 0x3246B21 VA: 0x3246A20
	|-List<ParticleSystem.Particle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3249D80 Offset: 0x3249E81 VA: 0x3249D80
	|-List<Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x324CEB0 Offset: 0x324CFB1 VA: 0x324CEB0
	|-List<PlayableBinding>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3250140 Offset: 0x3250241 VA: 0x3250140
	|-List<PlayableGraph>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3253140 Offset: 0x3253241 VA: 0x3253140
	|-List<Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3256170 Offset: 0x3256271 VA: 0x3256170
	|-List<Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3259170 Offset: 0x3259271 VA: 0x3259170
	|-List<RangeInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x325C310 Offset: 0x325C411 VA: 0x325C310
	|-List<RaycastHit2D>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x325F890 Offset: 0x325F991 VA: 0x325F890
	|-List<RaycastHit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33C15B0 Offset: 0x33C16B1 VA: 0x33C15B0
	|-List<Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33C45C0 Offset: 0x33C46C1 VA: 0x33C45C0
	|-List<RectInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33C75F0 Offset: 0x33C76F1 VA: 0x33C75F0
	|-List<ReflectionProbeBlendInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33CAA20 Offset: 0x33CAB21 VA: 0x33CAA20
	|-List<SphericalHarmonicsL2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33CE370 Offset: 0x33CE471 VA: 0x33CE370
	|-List<VertexAttributeDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33D14A0 Offset: 0x33D15A1 VA: 0x33D14A0
	|-List<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33D4840 Offset: 0x33D4941 VA: 0x33D4840
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33D7C80 Offset: 0x33D7D81 VA: 0x33D7C80
	|-List<DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33DB1A0 Offset: 0x33DB2A1 VA: 0x33DB1A0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x33DE5F0 Offset: 0x33DE6F1 VA: 0x33DE5F0
	|-List<ObjectInitializationData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31B9940 Offset: 0x31B9A41 VA: 0x31B9940
	|-List<GlyphRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31BCAF0 Offset: 0x31BCBF1 VA: 0x31BCAF0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31BFF30 Offset: 0x31C0031 VA: 0x31BFF30
	|-List<IntervalTreeNode>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31C32A0 Offset: 0x31C33A1 VA: 0x31C32A0
	|-List<IntervalTree.Entry<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31C6640 Offset: 0x31C6741 VA: 0x31C6640
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31C9920 Offset: 0x31C9A21 VA: 0x31C9920
	|-List<UICharInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31CC960 Offset: 0x31CCA61 VA: 0x31CC960
	|-List<FocusController.FocusedElement>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31CF980 Offset: 0x31CFA81 VA: 0x31CF980
	|-List<UILineInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31D2CA0 Offset: 0x31D2DA1 VA: 0x31D2CA0
	|-List<UIVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31D64B0 Offset: 0x31D65B1 VA: 0x31D64B0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31D9730 Offset: 0x31D9831 VA: 0x31D9730
	|-List<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CE2350 Offset: 0x2CE2451 VA: 0x2CE2350
	|-List<Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CE5370 Offset: 0x2CE5471 VA: 0x2CE5370
	|-List<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CE83E0 Offset: 0x2CE84E1 VA: 0x2CE83E0
	|-List<Vector3Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CEB4C0 Offset: 0x2CEB5C1 VA: 0x2CEB4C0
	|-List<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CEE910 Offset: 0x2CEEA11 VA: 0x2CEE910
	|-List<WarpPoints.WarpPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CF21D0 Offset: 0x2CF22D1 VA: 0x2CF21D0
	|-List<YieldItemParam>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CF52B0 Offset: 0x2CF53B1 VA: 0x2CF52B0
	|-List<stCommand_t>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D5E0 Offset: 0x248D6E1 VA: 0x248D5E0
	|-List<AS_ToolController.ChargeInfo>.CopyTo
	|
	|-RVA: 0x2490CA0 Offset: 0x2490DA1 VA: 0x2490CA0
	|-List<BuildItemData>.CopyTo
	|
	|-RVA: 0x3156B80 Offset: 0x3156C81 VA: 0x3156B80
	|-List<ButtonLinker.LinkObject>.CopyTo
	|
	|-RVA: 0x3159BB0 Offset: 0x3159CB1 VA: 0x3159BB0
	|-List<CharaCallTable.BustupTable>.CopyTo
	|
	|-RVA: 0x315CC10 Offset: 0x315CD11 VA: 0x315CC10
	|-List<CharaCallTable.CharaFaceIconTable>.CopyTo
	|
	|-RVA: 0x315FCA0 Offset: 0x315FDA1 VA: 0x315FCA0
	|-List<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3162CB0 Offset: 0x3162DB1 VA: 0x3162CB0
	|-List<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3165C60 Offset: 0x3165D61 VA: 0x3165C60
	|-List<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3168DC0 Offset: 0x3168EC1 VA: 0x3168DC0
	|-List<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x316C2E0 Offset: 0x316C3E1 VA: 0x316C2E0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	|
	|-RVA: 0x316F800 Offset: 0x316F901 VA: 0x316F800
	|-List<CropDataTable>.CopyTo
	|
	|-RVA: 0x3172C20 Offset: 0x3172D21 VA: 0x3172C20
	|-List<DropItemParam>.CopyTo
	|
	|-RVA: 0x3175D00 Offset: 0x3175E01 VA: 0x3175D00
	|-List<ErosionBrush.UndoStep>.CopyTo
	|
	|-RVA: 0x31DC990 Offset: 0x31DCA91 VA: 0x31DC990
	|-List<EventCheckId>.CopyTo
	|
	|-RVA: 0x31DFC30 Offset: 0x31DFD31 VA: 0x31DFC30
	|-List<EventFlagProgressData>.CopyTo
	|
	|-RVA: 0x31E2C80 Offset: 0x31E2D81 VA: 0x31E2C80
	|-List<FesNpcScoreData>.CopyTo
	|
	|-RVA: 0x31E5E90 Offset: 0x31E5F91 VA: 0x31E5E90
	|-List<MiningPointSaveData>.CopyTo
	|
	|-RVA: 0x31E93D0 Offset: 0x31E94D1 VA: 0x31E93D0
	|-List<MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x31EC750 Offset: 0x31EC851 VA: 0x31EC750
	|-List<MoviePlayer.SUBTITLEDATA>.CopyTo
	|
	|-RVA: 0x31EF980 Offset: 0x31EFA81 VA: 0x31EF980
	|-List<NPCActionData>.CopyTo
	|
	|-RVA: 0x31F2F60 Offset: 0x31F3061 VA: 0x31F2F60
	|-List<NpcPlaceSchedule>.CopyTo
	|
	|-RVA: 0x31F6230 Offset: 0x31F6331 VA: 0x31F6230
	|-List<OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x31F93C0 Offset: 0x31F94C1 VA: 0x31F93C0
	|-List<OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x31FC670 Offset: 0x31FC771 VA: 0x31FC670
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x330B8E0 Offset: 0x330B9E1 VA: 0x330B8E0
	|-List<ShopCatalogPage>.CopyTo
	|
	|-RVA: 0x330EAC0 Offset: 0x330EBC1 VA: 0x330EAC0
	|-List<ShopNpcTalk>.CopyTo
	|
	|-RVA: 0x3311F10 Offset: 0x3312011 VA: 0x3311F10
	|-List<SubtitleDataTable.Data>.CopyTo
	|
	|-RVA: 0x3314F80 Offset: 0x3315081 VA: 0x3314F80
	|-List<SubtitleDataTable.DataList>.CopyTo
	|
	|-RVA: 0x3317FA0 Offset: 0x33180A1 VA: 0x3317FA0
	|-List<SubtitleHudDataTable.Data>.CopyTo
	|
	|-RVA: 0x331B130 Offset: 0x331B231 VA: 0x331B130
	|-List<SRMonoBehaviourEx.FieldInfo>.CopyTo
	|
	|-RVA: 0x331E4C0 Offset: 0x331E5C1 VA: 0x331E4C0
	|-List<Schedule>.CopyTo
	|
	|-RVA: 0x33219C0 Offset: 0x3321AC1 VA: 0x33219C0
	|-List<CurveSample>.CopyTo
	|
	|-RVA: 0x3324FD0 Offset: 0x33250D1 VA: 0x3324FD0
	|-List<bool>.CopyTo
	|
	|-RVA: 0x3327FB0 Offset: 0x33280B1 VA: 0x3327FB0
	|-List<byte>.CopyTo
	|
	|-RVA: 0x332AF70 Offset: 0x332B071 VA: 0x332AF70
	|-List<char>.CopyTo
	|
	|-RVA: 0x3358FF0 Offset: 0x33590F1 VA: 0x3358FF0
	|-List<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x335C040 Offset: 0x335C141 VA: 0x335C040
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x335F090 Offset: 0x335F191 VA: 0x335F090
	|-List<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x33620A0 Offset: 0x33621A1 VA: 0x33620A0
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x3365050 Offset: 0x3365151 VA: 0x3365050
	|-List<double>.CopyTo
	|
	|-RVA: 0x3368000 Offset: 0x3368101 VA: 0x3368000
	|-List<short>.CopyTo
	|
	|-RVA: 0x336AFB0 Offset: 0x336B0B1 VA: 0x336AFB0
	|-List<int>.CopyTo
	|
	|-RVA: 0x336DF60 Offset: 0x336E061 VA: 0x336DF60
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x3370F10 Offset: 0x3371011 VA: 0x3370F10
	|-List<long>.CopyTo
	|
	|-RVA: 0x3373EF0 Offset: 0x3373FF1 VA: 0x3373EF0
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3376F70 Offset: 0x3377071 VA: 0x3376F70
	|-List<Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x3405E00 Offset: 0x3405F01 VA: 0x3405E00
	|-List<Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x34093C0 Offset: 0x34094C1 VA: 0x34093C0
	|-List<Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x340C780 Offset: 0x340C881 VA: 0x340C780
	|-List<Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x340F8F0 Offset: 0x340F9F1 VA: 0x340F8F0
	|-List<Nullable<Color>>.CopyTo
	|
	|-RVA: 0x3412C50 Offset: 0x3412D51 VA: 0x3412C50
	|-List<Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x3415E70 Offset: 0x3415F71 VA: 0x3415E70
	|-List<Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x34192C0 Offset: 0x34193C1 VA: 0x34192C0
	|-List<Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x341C5B0 Offset: 0x341C6B1 VA: 0x341C5B0
	|-List<Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x341F910 Offset: 0x341FA11 VA: 0x341F910
	|-List<Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x3423160 Offset: 0x3423261 VA: 0x3423160
	|-List<Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x3262F30 Offset: 0x3263031 VA: 0x3262F30
	|-List<Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x3266150 Offset: 0x3266251 VA: 0x3266150
	|-List<Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x32695B0 Offset: 0x32696B1 VA: 0x32695B0
	|-List<Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x326C910 Offset: 0x326CA11 VA: 0x326C910
	|-List<Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x326FA30 Offset: 0x326FB31 VA: 0x326FA30
	|-List<Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x3272B00 Offset: 0x3272C01 VA: 0x3272B00
	|-List<Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x3275B70 Offset: 0x3275C71 VA: 0x3275B70
	|-List<Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x3278D30 Offset: 0x3278E31 VA: 0x3278D30
	|-List<Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x327BF50 Offset: 0x327C051 VA: 0x327BF50
	|-List<object>.CopyTo
	|-List<string>.CopyTo
	|
	|-RVA: 0x327EEF0 Offset: 0x327EFF1 VA: 0x327EEF0
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x3281EB0 Offset: 0x3281FB1 VA: 0x3281EB0
	|-List<float>.CopyTo
	|
	|-RVA: 0x32A9110 Offset: 0x32A9211 VA: 0x32A9110
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x32AC0C0 Offset: 0x32AC1C1 VA: 0x32AC0C0
	|-List<uint>.CopyTo
	|
	|-RVA: 0x32AF070 Offset: 0x32AF171 VA: 0x32AF070
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x32B2020 Offset: 0x32B2121 VA: 0x32B2020
	|-List<ValueTuple<bool, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32B4FD0 Offset: 0x32B50D1 VA: 0x32B4FD0
	|-List<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x32B7FB0 Offset: 0x32B80B1 VA: 0x32B7FB0
	|-List<ValueTuple<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x32BB000 Offset: 0x32BB101 VA: 0x32BB000
	|-List<ValueTuple<object, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32BE040 Offset: 0x32BE141 VA: 0x32BE040
	|-List<ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x32C1080 Offset: 0x32C1181 VA: 0x32C1080
	|-List<ValueTuple<object, float>>.CopyTo
	|
	|-RVA: 0x32C40F0 Offset: 0x32C41F1 VA: 0x32C40F0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32C7380 Offset: 0x32C7481 VA: 0x32C7380
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CopyTo
	|
	|-RVA: 0x3110FE0 Offset: 0x31110E1 VA: 0x3110FE0
	|-List<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x3114500 Offset: 0x3114601 VA: 0x3114500
	|-List<TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x3117590 Offset: 0x3117691 VA: 0x3117590
	|-List<UIMainManagerAttachObject.AttachSet>.CopyTo
	|
	|-RVA: 0x311A7A0 Offset: 0x311A8A1 VA: 0x311A7A0
	|-List<CapEdge>.CopyTo
	|
	|-RVA: 0x311DB10 Offset: 0x311DC11 VA: 0x311DB10
	|-List<MeshDataConnectivity.Face>.CopyTo
	|
	|-RVA: 0x3120BD0 Offset: 0x3120CD1 VA: 0x3120BD0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.CopyTo
	|
	|-RVA: 0x3123FE0 Offset: 0x31240E1 VA: 0x3123FE0
	|-List<MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x31273E0 Offset: 0x31274E1 VA: 0x31273E0
	|-List<NavMeshBuildMarkup>.CopyTo
	|
	|-RVA: 0x312A7A0 Offset: 0x312A8A1 VA: 0x312A7A0
	|-List<NavMeshBuildSource>.CopyTo
	|
	|-RVA: 0x312DFE0 Offset: 0x312E0E1 VA: 0x312DFE0
	|-List<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3130FF0 Offset: 0x31310F1 VA: 0x3130FF0
	|-List<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x321CBB0 Offset: 0x321CCB1 VA: 0x321CBB0
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x321FCE0 Offset: 0x321FDE1 VA: 0x321FCE0
	|-List<BoneWeight>.CopyTo
	|
	|-RVA: 0x3223040 Offset: 0x3223141 VA: 0x3223040
	|-List<Bounds>.CopyTo
	|
	|-RVA: 0x3226390 Offset: 0x3226491 VA: 0x3226390
	|-List<BoundsInt>.CopyTo
	|
	|-RVA: 0x32295E0 Offset: 0x32296E1 VA: 0x32295E0
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x322C620 Offset: 0x322C721 VA: 0x322C620
	|-List<Color>.CopyTo
	|
	|-RVA: 0x322F9E0 Offset: 0x322FAE1 VA: 0x322F9E0
	|-List<CombineInstance>.CopyTo
	|
	|-RVA: 0x32334F0 Offset: 0x32335F1 VA: 0x32334F0
	|-List<RaycastResult>.CopyTo
	|
	|-RVA: 0x3236B00 Offset: 0x3236C01 VA: 0x3236B00
	|-List<GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x3239C20 Offset: 0x3239D21 VA: 0x3239C20
	|-List<GradientColorKey>.CopyTo
	|
	|-RVA: 0x323D020 Offset: 0x323D121 VA: 0x323D020
	|-List<Keyframe>.CopyTo
	|
	|-RVA: 0x3240360 Offset: 0x3240461 VA: 0x3240360
	|-List<LayerMask>.CopyTo
	|
	|-RVA: 0x3243530 Offset: 0x3243631 VA: 0x3243530
	|-List<Matrix4x4>.CopyTo
	|
	|-RVA: 0x3246B40 Offset: 0x3246C41 VA: 0x3246B40
	|-List<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x3249EA0 Offset: 0x3249FA1 VA: 0x3249EA0
	|-List<Playable>.CopyTo
	|
	|-RVA: 0x324CFD0 Offset: 0x324D0D1 VA: 0x324CFD0
	|-List<PlayableBinding>.CopyTo
	|
	|-RVA: 0x3250260 Offset: 0x3250361 VA: 0x3250260
	|-List<PlayableGraph>.CopyTo
	|
	|-RVA: 0x3253260 Offset: 0x3253361 VA: 0x3253260
	|-List<Edge>.CopyTo
	|
	|-RVA: 0x3256290 Offset: 0x3256391 VA: 0x3256290
	|-List<Quaternion>.CopyTo
	|
	|-RVA: 0x3259290 Offset: 0x3259391 VA: 0x3259290
	|-List<RangeInt>.CopyTo
	|
	|-RVA: 0x325C430 Offset: 0x325C531 VA: 0x325C430
	|-List<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x325F9B0 Offset: 0x325FAB1 VA: 0x325F9B0
	|-List<RaycastHit>.CopyTo
	|
	|-RVA: 0x33C16D0 Offset: 0x33C17D1 VA: 0x33C16D0
	|-List<Rect>.CopyTo
	|
	|-RVA: 0x33C46E0 Offset: 0x33C47E1 VA: 0x33C46E0
	|-List<RectInt>.CopyTo
	|
	|-RVA: 0x33C7710 Offset: 0x33C7811 VA: 0x33C7710
	|-List<ReflectionProbeBlendInfo>.CopyTo
	|
	|-RVA: 0x33CAB40 Offset: 0x33CAC41 VA: 0x33CAB40
	|-List<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x33CE490 Offset: 0x33CE591 VA: 0x33CE490
	|-List<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x33D15C0 Offset: 0x33D16C1 VA: 0x33D15C0
	|-List<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x33D4960 Offset: 0x33D4A61 VA: 0x33D4960
	|-List<AsyncOperationHandle<SceneInstance>>.CopyTo
	|
	|-RVA: 0x33D7DA0 Offset: 0x33D7EA1 VA: 0x33D7DA0
	|-List<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x33DB2C0 Offset: 0x33DB3C1 VA: 0x33DB2C0
	|-List<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x33DE710 Offset: 0x33DE811 VA: 0x33DE710
	|-List<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x31B9A60 Offset: 0x31B9B61 VA: 0x31B9A60
	|-List<GlyphRect>.CopyTo
	|
	|-RVA: 0x31BCC10 Offset: 0x31BCD11 VA: 0x31BCC10
	|-List<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x31C0050 Offset: 0x31C0151 VA: 0x31C0050
	|-List<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x31C33C0 Offset: 0x31C34C1 VA: 0x31C33C0
	|-List<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x31C6760 Offset: 0x31C6861 VA: 0x31C6760
	|-List<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x31C9A40 Offset: 0x31C9B41 VA: 0x31C9A40
	|-List<UICharInfo>.CopyTo
	|
	|-RVA: 0x31CCA80 Offset: 0x31CCB81 VA: 0x31CCA80
	|-List<FocusController.FocusedElement>.CopyTo
	|
	|-RVA: 0x31CFAA0 Offset: 0x31CFBA1 VA: 0x31CFAA0
	|-List<UILineInfo>.CopyTo
	|
	|-RVA: 0x31D2DC0 Offset: 0x31D2EC1 VA: 0x31D2DC0
	|-List<UIVertex>.CopyTo
	|
	|-RVA: 0x31D65D0 Offset: 0x31D66D1 VA: 0x31D65D0
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x31D9850 Offset: 0x31D9951 VA: 0x31D9850
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x2CE2470 Offset: 0x2CE2571 VA: 0x2CE2470
	|-List<Vector2Int>.CopyTo
	|
	|-RVA: 0x2CE5490 Offset: 0x2CE5591 VA: 0x2CE5490
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x2CE8500 Offset: 0x2CE8601 VA: 0x2CE8500
	|-List<Vector3Int>.CopyTo
	|
	|-RVA: 0x2CEB5E0 Offset: 0x2CEB6E1 VA: 0x2CEB5E0
	|-List<Vector4>.CopyTo
	|
	|-RVA: 0x2CEEA30 Offset: 0x2CEEB31 VA: 0x2CEEA30
	|-List<WarpPoints.WarpPoint>.CopyTo
	|
	|-RVA: 0x2CF22F0 Offset: 0x2CF23F1 VA: 0x2CF22F0
	|-List<YieldItemParam>.CopyTo
	|
	|-RVA: 0x2CF53D0 Offset: 0x2CF54D1 VA: 0x2CF53D0
	|-List<stCommand_t>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D650 Offset: 0x248D751 VA: 0x248D650
	|-List<AS_ToolController.ChargeInfo>.CopyTo
	|
	|-RVA: 0x2490D10 Offset: 0x2490E11 VA: 0x2490D10
	|-List<BuildItemData>.CopyTo
	|
	|-RVA: 0x3156BF0 Offset: 0x3156CF1 VA: 0x3156BF0
	|-List<ButtonLinker.LinkObject>.CopyTo
	|
	|-RVA: 0x3159C20 Offset: 0x3159D21 VA: 0x3159C20
	|-List<CharaCallTable.BustupTable>.CopyTo
	|
	|-RVA: 0x315CC80 Offset: 0x315CD81 VA: 0x315CC80
	|-List<CharaCallTable.CharaFaceIconTable>.CopyTo
	|
	|-RVA: 0x315FD10 Offset: 0x315FE11 VA: 0x315FD10
	|-List<CameraState.CustomBlendable>.CopyTo
	|
	|-RVA: 0x3162D20 Offset: 0x3162E21 VA: 0x3162D20
	|-List<CinemachineClearShot.Pair>.CopyTo
	|
	|-RVA: 0x3165CD0 Offset: 0x3165DD1 VA: 0x3165CD0
	|-List<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|
	|-RVA: 0x3168E30 Offset: 0x3168F31 VA: 0x3168E30
	|-List<TargetPositionCache.CacheCurve.Item>.CopyTo
	|
	|-RVA: 0x316C350 Offset: 0x316C451 VA: 0x316C350
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	|
	|-RVA: 0x316F870 Offset: 0x316F971 VA: 0x316F870
	|-List<CropDataTable>.CopyTo
	|
	|-RVA: 0x3172C90 Offset: 0x3172D91 VA: 0x3172C90
	|-List<DropItemParam>.CopyTo
	|
	|-RVA: 0x3175D70 Offset: 0x3175E71 VA: 0x3175D70
	|-List<ErosionBrush.UndoStep>.CopyTo
	|
	|-RVA: 0x31DCA00 Offset: 0x31DCB01 VA: 0x31DCA00
	|-List<EventCheckId>.CopyTo
	|
	|-RVA: 0x31DFCA0 Offset: 0x31DFDA1 VA: 0x31DFCA0
	|-List<EventFlagProgressData>.CopyTo
	|
	|-RVA: 0x31E2CF0 Offset: 0x31E2DF1 VA: 0x31E2CF0
	|-List<FesNpcScoreData>.CopyTo
	|
	|-RVA: 0x31E5F00 Offset: 0x31E6001 VA: 0x31E5F00
	|-List<MiningPointSaveData>.CopyTo
	|
	|-RVA: 0x31E9440 Offset: 0x31E9541 VA: 0x31E9440
	|-List<MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x31EC7C0 Offset: 0x31EC8C1 VA: 0x31EC7C0
	|-List<MoviePlayer.SUBTITLEDATA>.CopyTo
	|
	|-RVA: 0x31EF9F0 Offset: 0x31EFAF1 VA: 0x31EF9F0
	|-List<NPCActionData>.CopyTo
	|
	|-RVA: 0x31F2FD0 Offset: 0x31F30D1 VA: 0x31F2FD0
	|-List<NpcPlaceSchedule>.CopyTo
	|
	|-RVA: 0x31F62A0 Offset: 0x31F63A1 VA: 0x31F62A0
	|-List<OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x31F9430 Offset: 0x31F9531 VA: 0x31F9430
	|-List<OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x31FC6E0 Offset: 0x31FC7E1 VA: 0x31FC6E0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|
	|-RVA: 0x330B950 Offset: 0x330BA51 VA: 0x330B950
	|-List<ShopCatalogPage>.CopyTo
	|
	|-RVA: 0x330EB30 Offset: 0x330EC31 VA: 0x330EB30
	|-List<ShopNpcTalk>.CopyTo
	|
	|-RVA: 0x3311F80 Offset: 0x3312081 VA: 0x3311F80
	|-List<SubtitleDataTable.Data>.CopyTo
	|
	|-RVA: 0x3314FF0 Offset: 0x33150F1 VA: 0x3314FF0
	|-List<SubtitleDataTable.DataList>.CopyTo
	|
	|-RVA: 0x3318010 Offset: 0x3318111 VA: 0x3318010
	|-List<SubtitleHudDataTable.Data>.CopyTo
	|
	|-RVA: 0x331B1A0 Offset: 0x331B2A1 VA: 0x331B1A0
	|-List<SRMonoBehaviourEx.FieldInfo>.CopyTo
	|
	|-RVA: 0x331E530 Offset: 0x331E631 VA: 0x331E530
	|-List<Schedule>.CopyTo
	|
	|-RVA: 0x3321A30 Offset: 0x3321B31 VA: 0x3321A30
	|-List<CurveSample>.CopyTo
	|
	|-RVA: 0x3325040 Offset: 0x3325141 VA: 0x3325040
	|-List<bool>.CopyTo
	|
	|-RVA: 0x3328020 Offset: 0x3328121 VA: 0x3328020
	|-List<byte>.CopyTo
	|
	|-RVA: 0x332AFE0 Offset: 0x332B0E1 VA: 0x332AFE0
	|-List<char>.CopyTo
	|
	|-RVA: 0x3359060 Offset: 0x3359161 VA: 0x3359060
	|-List<KeyValuePair<DateTime, object>>.CopyTo
	|
	|-RVA: 0x335C0B0 Offset: 0x335C1B1 VA: 0x335C0B0
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x335F100 Offset: 0x335F201 VA: 0x335F100
	|-List<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3362110 Offset: 0x3362211 VA: 0x3362110
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x33650C0 Offset: 0x33651C1 VA: 0x33650C0
	|-List<double>.CopyTo
	|
	|-RVA: 0x3368070 Offset: 0x3368171 VA: 0x3368070
	|-List<short>.CopyTo
	|
	|-RVA: 0x336B020 Offset: 0x336B121 VA: 0x336B020
	|-List<int>.CopyTo
	|
	|-RVA: 0x336DFD0 Offset: 0x336E0D1 VA: 0x336DFD0
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x3370F80 Offset: 0x3371081 VA: 0x3370F80
	|-List<long>.CopyTo
	|
	|-RVA: 0x3373F60 Offset: 0x3374061 VA: 0x3373F60
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x3376FE0 Offset: 0x33770E1 VA: 0x3376FE0
	|-List<Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x3405E70 Offset: 0x3405F71 VA: 0x3405E70
	|-List<Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x3409430 Offset: 0x3409531 VA: 0x3409430
	|-List<Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x340C7F0 Offset: 0x340C8F1 VA: 0x340C7F0
	|-List<Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x340F960 Offset: 0x340FA61 VA: 0x340F960
	|-List<Nullable<Color>>.CopyTo
	|
	|-RVA: 0x3412CC0 Offset: 0x3412DC1 VA: 0x3412CC0
	|-List<Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x3415EE0 Offset: 0x3415FE1 VA: 0x3415EE0
	|-List<Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x3419330 Offset: 0x3419431 VA: 0x3419330
	|-List<Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x341C620 Offset: 0x341C721 VA: 0x341C620
	|-List<Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x341F980 Offset: 0x341FA81 VA: 0x341F980
	|-List<Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x34231D0 Offset: 0x34232D1 VA: 0x34231D0
	|-List<Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x3262FA0 Offset: 0x32630A1 VA: 0x3262FA0
	|-List<Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x32661C0 Offset: 0x32662C1 VA: 0x32661C0
	|-List<Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x3269620 Offset: 0x3269721 VA: 0x3269620
	|-List<Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x326C980 Offset: 0x326CA81 VA: 0x326C980
	|-List<Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x326FAA0 Offset: 0x326FBA1 VA: 0x326FAA0
	|-List<Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x3272B70 Offset: 0x3272C71 VA: 0x3272B70
	|-List<Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x3275BE0 Offset: 0x3275CE1 VA: 0x3275BE0
	|-List<Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x3278DA0 Offset: 0x3278EA1 VA: 0x3278DA0
	|-List<Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x327BFC0 Offset: 0x327C0C1 VA: 0x327BFC0
	|-List<object>.CopyTo
	|
	|-RVA: 0x327EF60 Offset: 0x327F061 VA: 0x327EF60
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x3281F20 Offset: 0x3282021 VA: 0x3281F20
	|-List<float>.CopyTo
	|
	|-RVA: 0x32A9180 Offset: 0x32A9281 VA: 0x32A9180
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x32AC130 Offset: 0x32AC231 VA: 0x32AC130
	|-List<uint>.CopyTo
	|
	|-RVA: 0x32AF0E0 Offset: 0x32AF1E1 VA: 0x32AF0E0
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x32B2090 Offset: 0x32B2191 VA: 0x32B2090
	|-List<ValueTuple<bool, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32B5040 Offset: 0x32B5141 VA: 0x32B5040
	|-List<ValueTuple<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x32B8020 Offset: 0x32B8121 VA: 0x32B8020
	|-List<ValueTuple<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x32BB070 Offset: 0x32BB171 VA: 0x32BB070
	|-List<ValueTuple<object, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32BE0B0 Offset: 0x32BE1B1 VA: 0x32BE0B0
	|-List<ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x32C10F0 Offset: 0x32C11F1 VA: 0x32C10F0
	|-List<ValueTuple<object, float>>.CopyTo
	|
	|-RVA: 0x32C4160 Offset: 0x32C4261 VA: 0x32C4160
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.CopyTo
	|
	|-RVA: 0x32C73F0 Offset: 0x32C74F1 VA: 0x32C73F0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.CopyTo
	|
	|-RVA: 0x3111050 Offset: 0x3111151 VA: 0x3111050
	|-List<TexturePacker_JsonArray.Frame>.CopyTo
	|
	|-RVA: 0x3114570 Offset: 0x3114671 VA: 0x3114570
	|-List<TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x3117600 Offset: 0x3117701 VA: 0x3117600
	|-List<UIMainManagerAttachObject.AttachSet>.CopyTo
	|
	|-RVA: 0x311A810 Offset: 0x311A911 VA: 0x311A810
	|-List<CapEdge>.CopyTo
	|
	|-RVA: 0x311DB80 Offset: 0x311DC81 VA: 0x311DB80
	|-List<MeshDataConnectivity.Face>.CopyTo
	|
	|-RVA: 0x3120C40 Offset: 0x3120D41 VA: 0x3120C40
	|-List<MeshFaceConnectivity.EdgeData.SideData>.CopyTo
	|
	|-RVA: 0x3124050 Offset: 0x3124151 VA: 0x3124050
	|-List<MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x3127450 Offset: 0x3127551 VA: 0x3127450
	|-List<NavMeshBuildMarkup>.CopyTo
	|
	|-RVA: 0x312A810 Offset: 0x312A911 VA: 0x312A810
	|-List<NavMeshBuildSource>.CopyTo
	|
	|-RVA: 0x312E050 Offset: 0x312E151 VA: 0x312E050
	|-List<ConstraintSource>.CopyTo
	|
	|-RVA: 0x3131060 Offset: 0x3131161 VA: 0x3131060
	|-List<AnimatorClipInfo>.CopyTo
	|
	|-RVA: 0x321CC20 Offset: 0x321CD21 VA: 0x321CC20
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x321FD50 Offset: 0x321FE51 VA: 0x321FD50
	|-List<BoneWeight>.CopyTo
	|
	|-RVA: 0x32230B0 Offset: 0x32231B1 VA: 0x32230B0
	|-List<Bounds>.CopyTo
	|
	|-RVA: 0x3226400 Offset: 0x3226501 VA: 0x3226400
	|-List<BoundsInt>.CopyTo
	|
	|-RVA: 0x3229650 Offset: 0x3229751 VA: 0x3229650
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x322C690 Offset: 0x322C791 VA: 0x322C690
	|-List<Color>.CopyTo
	|
	|-RVA: 0x322FA50 Offset: 0x322FB51 VA: 0x322FA50
	|-List<CombineInstance>.CopyTo
	|
	|-RVA: 0x3233560 Offset: 0x3233661 VA: 0x3233560
	|-List<RaycastResult>.CopyTo
	|
	|-RVA: 0x3236B70 Offset: 0x3236C71 VA: 0x3236B70
	|-List<GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x3239C90 Offset: 0x3239D91 VA: 0x3239C90
	|-List<GradientColorKey>.CopyTo
	|
	|-RVA: 0x323D090 Offset: 0x323D191 VA: 0x323D090
	|-List<Keyframe>.CopyTo
	|
	|-RVA: 0x32403D0 Offset: 0x32404D1 VA: 0x32403D0
	|-List<LayerMask>.CopyTo
	|
	|-RVA: 0x32435A0 Offset: 0x32436A1 VA: 0x32435A0
	|-List<Matrix4x4>.CopyTo
	|
	|-RVA: 0x3246BB0 Offset: 0x3246CB1 VA: 0x3246BB0
	|-List<ParticleSystem.Particle>.CopyTo
	|
	|-RVA: 0x3249F10 Offset: 0x324A011 VA: 0x3249F10
	|-List<Playable>.CopyTo
	|
	|-RVA: 0x324D040 Offset: 0x324D141 VA: 0x324D040
	|-List<PlayableBinding>.CopyTo
	|
	|-RVA: 0x32502D0 Offset: 0x32503D1 VA: 0x32502D0
	|-List<PlayableGraph>.CopyTo
	|
	|-RVA: 0x32532D0 Offset: 0x32533D1 VA: 0x32532D0
	|-List<Edge>.CopyTo
	|
	|-RVA: 0x3256300 Offset: 0x3256401 VA: 0x3256300
	|-List<Quaternion>.CopyTo
	|
	|-RVA: 0x3259300 Offset: 0x3259401 VA: 0x3259300
	|-List<RangeInt>.CopyTo
	|
	|-RVA: 0x325C4A0 Offset: 0x325C5A1 VA: 0x325C4A0
	|-List<RaycastHit2D>.CopyTo
	|
	|-RVA: 0x325FA20 Offset: 0x325FB21 VA: 0x325FA20
	|-List<RaycastHit>.CopyTo
	|
	|-RVA: 0x33C1740 Offset: 0x33C1841 VA: 0x33C1740
	|-List<Rect>.CopyTo
	|
	|-RVA: 0x33C4750 Offset: 0x33C4851 VA: 0x33C4750
	|-List<RectInt>.CopyTo
	|
	|-RVA: 0x33C7780 Offset: 0x33C7881 VA: 0x33C7780
	|-List<ReflectionProbeBlendInfo>.CopyTo
	|
	|-RVA: 0x33CABB0 Offset: 0x33CACB1 VA: 0x33CABB0
	|-List<SphericalHarmonicsL2>.CopyTo
	|
	|-RVA: 0x33CE500 Offset: 0x33CE601 VA: 0x33CE500
	|-List<VertexAttributeDescriptor>.CopyTo
	|
	|-RVA: 0x33D1630 Offset: 0x33D1731 VA: 0x33D1630
	|-List<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x33D49D0 Offset: 0x33D4AD1 VA: 0x33D49D0
	|-List<AsyncOperationHandle<SceneInstance>>.CopyTo
	|
	|-RVA: 0x33D7E10 Offset: 0x33D7F11 VA: 0x33D7E10
	|-List<DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x33DB330 Offset: 0x33DB431 VA: 0x33DB330
	|-List<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x33DE780 Offset: 0x33DE881 VA: 0x33DE780
	|-List<ObjectInitializationData>.CopyTo
	|
	|-RVA: 0x31B9AD0 Offset: 0x31B9BD1 VA: 0x31B9AD0
	|-List<GlyphRect>.CopyTo
	|
	|-RVA: 0x31BCC80 Offset: 0x31BCD81 VA: 0x31BCC80
	|-List<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|
	|-RVA: 0x31C00C0 Offset: 0x31C01C1 VA: 0x31C00C0
	|-List<IntervalTreeNode>.CopyTo
	|
	|-RVA: 0x31C3430 Offset: 0x31C3531 VA: 0x31C3430
	|-List<IntervalTree.Entry<object>>.CopyTo
	|
	|-RVA: 0x31C67D0 Offset: 0x31C68D1 VA: 0x31C67D0
	|-List<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|
	|-RVA: 0x31C9AB0 Offset: 0x31C9BB1 VA: 0x31C9AB0
	|-List<UICharInfo>.CopyTo
	|
	|-RVA: 0x31CCAF0 Offset: 0x31CCBF1 VA: 0x31CCAF0
	|-List<FocusController.FocusedElement>.CopyTo
	|
	|-RVA: 0x31CFB10 Offset: 0x31CFC11 VA: 0x31CFB10
	|-List<UILineInfo>.CopyTo
	|
	|-RVA: 0x31D2E30 Offset: 0x31D2F31 VA: 0x31D2E30
	|-List<UIVertex>.CopyTo
	|
	|-RVA: 0x31D6640 Offset: 0x31D6741 VA: 0x31D6640
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x31D98C0 Offset: 0x31D99C1 VA: 0x31D98C0
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x2CE24E0 Offset: 0x2CE25E1 VA: 0x2CE24E0
	|-List<Vector2Int>.CopyTo
	|
	|-RVA: 0x2CE5500 Offset: 0x2CE5601 VA: 0x2CE5500
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x2CE8570 Offset: 0x2CE8671 VA: 0x2CE8570
	|-List<Vector3Int>.CopyTo
	|
	|-RVA: 0x2CEB650 Offset: 0x2CEB751 VA: 0x2CEB650
	|-List<Vector4>.CopyTo
	|
	|-RVA: 0x2CEEAA0 Offset: 0x2CEEBA1 VA: 0x2CEEAA0
	|-List<WarpPoints.WarpPoint>.CopyTo
	|
	|-RVA: 0x2CF2360 Offset: 0x2CF2461 VA: 0x2CF2360
	|-List<YieldItemParam>.CopyTo
	|
	|-RVA: 0x2CF5440 Offset: 0x2CF5541 VA: 0x2CF5440
	|-List<stCommand_t>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D670 Offset: 0x248D771 VA: 0x248D670
	|-List<AS_ToolController.ChargeInfo>.EnsureCapacity
	|
	|-RVA: 0x2490D30 Offset: 0x2490E31 VA: 0x2490D30
	|-List<BuildItemData>.EnsureCapacity
	|
	|-RVA: 0x3156C10 Offset: 0x3156D11 VA: 0x3156C10
	|-List<ButtonLinker.LinkObject>.EnsureCapacity
	|
	|-RVA: 0x3159C40 Offset: 0x3159D41 VA: 0x3159C40
	|-List<CharaCallTable.BustupTable>.EnsureCapacity
	|
	|-RVA: 0x315CCA0 Offset: 0x315CDA1 VA: 0x315CCA0
	|-List<CharaCallTable.CharaFaceIconTable>.EnsureCapacity
	|
	|-RVA: 0x315FD30 Offset: 0x315FE31 VA: 0x315FD30
	|-List<CameraState.CustomBlendable>.EnsureCapacity
	|
	|-RVA: 0x3162D40 Offset: 0x3162E41 VA: 0x3162D40
	|-List<CinemachineClearShot.Pair>.EnsureCapacity
	|
	|-RVA: 0x3165CF0 Offset: 0x3165DF1 VA: 0x3165CF0
	|-List<CinemachineStateDrivenCamera.HashPair>.EnsureCapacity
	|
	|-RVA: 0x3168E50 Offset: 0x3168F51 VA: 0x3168E50
	|-List<TargetPositionCache.CacheCurve.Item>.EnsureCapacity
	|
	|-RVA: 0x316C370 Offset: 0x316C471 VA: 0x316C370
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.EnsureCapacity
	|
	|-RVA: 0x316F890 Offset: 0x316F991 VA: 0x316F890
	|-List<CropDataTable>.EnsureCapacity
	|
	|-RVA: 0x3172CB0 Offset: 0x3172DB1 VA: 0x3172CB0
	|-List<DropItemParam>.EnsureCapacity
	|
	|-RVA: 0x3175D90 Offset: 0x3175E91 VA: 0x3175D90
	|-List<ErosionBrush.UndoStep>.EnsureCapacity
	|
	|-RVA: 0x31DCA20 Offset: 0x31DCB21 VA: 0x31DCA20
	|-List<EventCheckId>.EnsureCapacity
	|
	|-RVA: 0x31DFCC0 Offset: 0x31DFDC1 VA: 0x31DFCC0
	|-List<EventFlagProgressData>.EnsureCapacity
	|
	|-RVA: 0x31E2D10 Offset: 0x31E2E11 VA: 0x31E2D10
	|-List<FesNpcScoreData>.EnsureCapacity
	|
	|-RVA: 0x31E5F20 Offset: 0x31E6021 VA: 0x31E5F20
	|-List<MiningPointSaveData>.EnsureCapacity
	|
	|-RVA: 0x31E9460 Offset: 0x31E9561 VA: 0x31E9460
	|-List<MonsterHutSaveData>.EnsureCapacity
	|
	|-RVA: 0x31EC7E0 Offset: 0x31EC8E1 VA: 0x31EC7E0
	|-List<MoviePlayer.SUBTITLEDATA>.EnsureCapacity
	|
	|-RVA: 0x31EFA10 Offset: 0x31EFB11 VA: 0x31EFA10
	|-List<NPCActionData>.EnsureCapacity
	|
	|-RVA: 0x31F2FF0 Offset: 0x31F30F1 VA: 0x31F2FF0
	|-List<NpcPlaceSchedule>.EnsureCapacity
	|
	|-RVA: 0x31F62C0 Offset: 0x31F63C1 VA: 0x31F62C0
	|-List<OrderLotterySaveParameter>.EnsureCapacity
	|
	|-RVA: 0x31F9450 Offset: 0x31F9551 VA: 0x31F9450
	|-List<OrderSaveParameter>.EnsureCapacity
	|
	|-RVA: 0x31FC700 Offset: 0x31FC801 VA: 0x31FC700
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.EnsureCapacity
	|
	|-RVA: 0x330B970 Offset: 0x330BA71 VA: 0x330B970
	|-List<ShopCatalogPage>.EnsureCapacity
	|
	|-RVA: 0x330EB50 Offset: 0x330EC51 VA: 0x330EB50
	|-List<ShopNpcTalk>.EnsureCapacity
	|
	|-RVA: 0x3311FA0 Offset: 0x33120A1 VA: 0x3311FA0
	|-List<SubtitleDataTable.Data>.EnsureCapacity
	|
	|-RVA: 0x3315010 Offset: 0x3315111 VA: 0x3315010
	|-List<SubtitleDataTable.DataList>.EnsureCapacity
	|
	|-RVA: 0x3318030 Offset: 0x3318131 VA: 0x3318030
	|-List<SubtitleHudDataTable.Data>.EnsureCapacity
	|
	|-RVA: 0x331B1C0 Offset: 0x331B2C1 VA: 0x331B1C0
	|-List<SRMonoBehaviourEx.FieldInfo>.EnsureCapacity
	|
	|-RVA: 0x331E550 Offset: 0x331E651 VA: 0x331E550
	|-List<Schedule>.EnsureCapacity
	|
	|-RVA: 0x3321A50 Offset: 0x3321B51 VA: 0x3321A50
	|-List<CurveSample>.EnsureCapacity
	|
	|-RVA: 0x3325060 Offset: 0x3325161 VA: 0x3325060
	|-List<bool>.EnsureCapacity
	|
	|-RVA: 0x3328040 Offset: 0x3328141 VA: 0x3328040
	|-List<byte>.EnsureCapacity
	|
	|-RVA: 0x332B000 Offset: 0x332B101 VA: 0x332B000
	|-List<char>.EnsureCapacity
	|
	|-RVA: 0x3359080 Offset: 0x3359181 VA: 0x3359080
	|-List<KeyValuePair<DateTime, object>>.EnsureCapacity
	|
	|-RVA: 0x335C0D0 Offset: 0x335C1D1 VA: 0x335C0D0
	|-List<KeyValuePair<int, object>>.EnsureCapacity
	|
	|-RVA: 0x335F120 Offset: 0x335F221 VA: 0x335F120
	|-List<KeyValuePair<object, object>>.EnsureCapacity
	|
	|-RVA: 0x3362130 Offset: 0x3362231 VA: 0x3362130
	|-List<DateTime>.EnsureCapacity
	|
	|-RVA: 0x33650E0 Offset: 0x33651E1 VA: 0x33650E0
	|-List<double>.EnsureCapacity
	|
	|-RVA: 0x3368090 Offset: 0x3368191 VA: 0x3368090
	|-List<short>.EnsureCapacity
	|
	|-RVA: 0x336B040 Offset: 0x336B141 VA: 0x336B040
	|-List<int>.EnsureCapacity
	|
	|-RVA: 0x336DFF0 Offset: 0x336E0F1 VA: 0x336DFF0
	|-List<Int32Enum>.EnsureCapacity
	|
	|-RVA: 0x3370FA0 Offset: 0x33710A1 VA: 0x3370FA0
	|-List<long>.EnsureCapacity
	|
	|-RVA: 0x3373F80 Offset: 0x3374081 VA: 0x3373F80
	|-List<InterpretedFrameInfo>.EnsureCapacity
	|
	|-RVA: 0x3377000 Offset: 0x3377101 VA: 0x3377000
	|-List<Nullable<Int32Enum>>.EnsureCapacity
	|
	|-RVA: 0x3405E90 Offset: 0x3405F91 VA: 0x3405E90
	|-List<Nullable<Bounds>>.EnsureCapacity
	|
	|-RVA: 0x3409450 Offset: 0x3409551 VA: 0x3409450
	|-List<Nullable<BoundsInt>>.EnsureCapacity
	|
	|-RVA: 0x340C810 Offset: 0x340C911 VA: 0x340C810
	|-List<Nullable<Color32>>.EnsureCapacity
	|
	|-RVA: 0x340F980 Offset: 0x340FA81 VA: 0x340F980
	|-List<Nullable<Color>>.EnsureCapacity
	|
	|-RVA: 0x3412CE0 Offset: 0x3412DE1 VA: 0x3412CE0
	|-List<Nullable<GradientAlphaKey>>.EnsureCapacity
	|
	|-RVA: 0x3415F00 Offset: 0x3416001 VA: 0x3415F00
	|-List<Nullable<GradientColorKey>>.EnsureCapacity
	|
	|-RVA: 0x3419350 Offset: 0x3419451 VA: 0x3419350
	|-List<Nullable<Keyframe>>.EnsureCapacity
	|
	|-RVA: 0x341C640 Offset: 0x341C741 VA: 0x341C640
	|-List<Nullable<LayerMask>>.EnsureCapacity
	|
	|-RVA: 0x341F9A0 Offset: 0x341FAA1 VA: 0x341F9A0
	|-List<Nullable<Matrix4x4>>.EnsureCapacity
	|
	|-RVA: 0x34231F0 Offset: 0x34232F1 VA: 0x34231F0
	|-List<Nullable<Quaternion>>.EnsureCapacity
	|
	|-RVA: 0x3262FC0 Offset: 0x32630C1 VA: 0x3262FC0
	|-List<Nullable<RangeInt>>.EnsureCapacity
	|
	|-RVA: 0x32661E0 Offset: 0x32662E1 VA: 0x32661E0
	|-List<Nullable<Rect>>.EnsureCapacity
	|
	|-RVA: 0x3269640 Offset: 0x3269741 VA: 0x3269640
	|-List<Nullable<RectInt>>.EnsureCapacity
	|
	|-RVA: 0x326C9A0 Offset: 0x326CAA1 VA: 0x326C9A0
	|-List<Nullable<Vector2>>.EnsureCapacity
	|
	|-RVA: 0x326FAC0 Offset: 0x326FBC1 VA: 0x326FAC0
	|-List<Nullable<Vector2Int>>.EnsureCapacity
	|
	|-RVA: 0x3272B90 Offset: 0x3272C91 VA: 0x3272B90
	|-List<Nullable<Vector3>>.EnsureCapacity
	|
	|-RVA: 0x3275C00 Offset: 0x3275D01 VA: 0x3275C00
	|-List<Nullable<Vector3Int>>.EnsureCapacity
	|
	|-RVA: 0x3278DC0 Offset: 0x3278EC1 VA: 0x3278DC0
	|-List<Nullable<Vector4>>.EnsureCapacity
	|
	|-RVA: 0x327BFE0 Offset: 0x327C0E1 VA: 0x327BFE0
	|-List<object>.EnsureCapacity
	|
	|-RVA: 0x327EF80 Offset: 0x327F081 VA: 0x327EF80
	|-List<sbyte>.EnsureCapacity
	|
	|-RVA: 0x3281F40 Offset: 0x3282041 VA: 0x3281F40
	|-List<float>.EnsureCapacity
	|
	|-RVA: 0x32A91A0 Offset: 0x32A92A1 VA: 0x32A91A0
	|-List<ushort>.EnsureCapacity
	|
	|-RVA: 0x32AC150 Offset: 0x32AC251 VA: 0x32AC150
	|-List<uint>.EnsureCapacity
	|
	|-RVA: 0x32AF100 Offset: 0x32AF201 VA: 0x32AF100
	|-List<ulong>.EnsureCapacity
	|
	|-RVA: 0x32B20B0 Offset: 0x32B21B1 VA: 0x32B20B0
	|-List<ValueTuple<bool, Int32Enum>>.EnsureCapacity
	|
	|-RVA: 0x32B5060 Offset: 0x32B5161 VA: 0x32B5060
	|-List<ValueTuple<Int32Enum, int>>.EnsureCapacity
	|
	|-RVA: 0x32B8040 Offset: 0x32B8141 VA: 0x32B8040
	|-List<ValueTuple<Int32Enum, object>>.EnsureCapacity
	|
	|-RVA: 0x32BB090 Offset: 0x32BB191 VA: 0x32BB090
	|-List<ValueTuple<object, Int32Enum>>.EnsureCapacity
	|
	|-RVA: 0x32BE0D0 Offset: 0x32BE1D1 VA: 0x32BE0D0
	|-List<ValueTuple<object, object>>.EnsureCapacity
	|
	|-RVA: 0x32C1110 Offset: 0x32C1211 VA: 0x32C1110
	|-List<ValueTuple<object, float>>.EnsureCapacity
	|
	|-RVA: 0x32C4180 Offset: 0x32C4281 VA: 0x32C4180
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.EnsureCapacity
	|
	|-RVA: 0x32C7410 Offset: 0x32C7511 VA: 0x32C7410
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.EnsureCapacity
	|
	|-RVA: 0x3111070 Offset: 0x3111171 VA: 0x3111070
	|-List<TexturePacker_JsonArray.Frame>.EnsureCapacity
	|
	|-RVA: 0x3114590 Offset: 0x3114691 VA: 0x3114590
	|-List<TutorialUnlockFlagData>.EnsureCapacity
	|
	|-RVA: 0x3117620 Offset: 0x3117721 VA: 0x3117620
	|-List<UIMainManagerAttachObject.AttachSet>.EnsureCapacity
	|
	|-RVA: 0x311A830 Offset: 0x311A931 VA: 0x311A830
	|-List<CapEdge>.EnsureCapacity
	|
	|-RVA: 0x311DBA0 Offset: 0x311DCA1 VA: 0x311DBA0
	|-List<MeshDataConnectivity.Face>.EnsureCapacity
	|
	|-RVA: 0x3120C60 Offset: 0x3120D61 VA: 0x3120C60
	|-List<MeshFaceConnectivity.EdgeData.SideData>.EnsureCapacity
	|
	|-RVA: 0x3124070 Offset: 0x3124171 VA: 0x3124070
	|-List<MeshFaceConnectivity.EdgeData>.EnsureCapacity
	|
	|-RVA: 0x3127470 Offset: 0x3127571 VA: 0x3127470
	|-List<NavMeshBuildMarkup>.EnsureCapacity
	|
	|-RVA: 0x312A830 Offset: 0x312A931 VA: 0x312A830
	|-List<NavMeshBuildSource>.EnsureCapacity
	|
	|-RVA: 0x312E070 Offset: 0x312E171 VA: 0x312E070
	|-List<ConstraintSource>.EnsureCapacity
	|
	|-RVA: 0x3131080 Offset: 0x3131181 VA: 0x3131080
	|-List<AnimatorClipInfo>.EnsureCapacity
	|
	|-RVA: 0x321CC40 Offset: 0x321CD41 VA: 0x321CC40
	|-List<BeforeRenderHelper.OrderBlock>.EnsureCapacity
	|
	|-RVA: 0x321FD70 Offset: 0x321FE71 VA: 0x321FD70
	|-List<BoneWeight>.EnsureCapacity
	|
	|-RVA: 0x32230D0 Offset: 0x32231D1 VA: 0x32230D0
	|-List<Bounds>.EnsureCapacity
	|
	|-RVA: 0x3226420 Offset: 0x3226521 VA: 0x3226420
	|-List<BoundsInt>.EnsureCapacity
	|
	|-RVA: 0x3229670 Offset: 0x3229771 VA: 0x3229670
	|-List<Color32>.EnsureCapacity
	|
	|-RVA: 0x322C6B0 Offset: 0x322C7B1 VA: 0x322C6B0
	|-List<Color>.EnsureCapacity
	|
	|-RVA: 0x322FA70 Offset: 0x322FB71 VA: 0x322FA70
	|-List<CombineInstance>.EnsureCapacity
	|
	|-RVA: 0x3233580 Offset: 0x3233681 VA: 0x3233580
	|-List<RaycastResult>.EnsureCapacity
	|
	|-RVA: 0x3236B90 Offset: 0x3236C91 VA: 0x3236B90
	|-List<GradientAlphaKey>.EnsureCapacity
	|
	|-RVA: 0x3239CB0 Offset: 0x3239DB1 VA: 0x3239CB0
	|-List<GradientColorKey>.EnsureCapacity
	|
	|-RVA: 0x323D0B0 Offset: 0x323D1B1 VA: 0x323D0B0
	|-List<Keyframe>.EnsureCapacity
	|
	|-RVA: 0x32403F0 Offset: 0x32404F1 VA: 0x32403F0
	|-List<LayerMask>.EnsureCapacity
	|
	|-RVA: 0x32435C0 Offset: 0x32436C1 VA: 0x32435C0
	|-List<Matrix4x4>.EnsureCapacity
	|
	|-RVA: 0x3246BD0 Offset: 0x3246CD1 VA: 0x3246BD0
	|-List<ParticleSystem.Particle>.EnsureCapacity
	|
	|-RVA: 0x3249F30 Offset: 0x324A031 VA: 0x3249F30
	|-List<Playable>.EnsureCapacity
	|
	|-RVA: 0x324D060 Offset: 0x324D161 VA: 0x324D060
	|-List<PlayableBinding>.EnsureCapacity
	|
	|-RVA: 0x32502F0 Offset: 0x32503F1 VA: 0x32502F0
	|-List<PlayableGraph>.EnsureCapacity
	|
	|-RVA: 0x32532F0 Offset: 0x32533F1 VA: 0x32532F0
	|-List<Edge>.EnsureCapacity
	|
	|-RVA: 0x3256320 Offset: 0x3256421 VA: 0x3256320
	|-List<Quaternion>.EnsureCapacity
	|
	|-RVA: 0x3259320 Offset: 0x3259421 VA: 0x3259320
	|-List<RangeInt>.EnsureCapacity
	|
	|-RVA: 0x325C4C0 Offset: 0x325C5C1 VA: 0x325C4C0
	|-List<RaycastHit2D>.EnsureCapacity
	|
	|-RVA: 0x325FA40 Offset: 0x325FB41 VA: 0x325FA40
	|-List<RaycastHit>.EnsureCapacity
	|
	|-RVA: 0x33C1760 Offset: 0x33C1861 VA: 0x33C1760
	|-List<Rect>.EnsureCapacity
	|
	|-RVA: 0x33C4770 Offset: 0x33C4871 VA: 0x33C4770
	|-List<RectInt>.EnsureCapacity
	|
	|-RVA: 0x33C77A0 Offset: 0x33C78A1 VA: 0x33C77A0
	|-List<ReflectionProbeBlendInfo>.EnsureCapacity
	|
	|-RVA: 0x33CABD0 Offset: 0x33CACD1 VA: 0x33CABD0
	|-List<SphericalHarmonicsL2>.EnsureCapacity
	|
	|-RVA: 0x33CE520 Offset: 0x33CE621 VA: 0x33CE520
	|-List<VertexAttributeDescriptor>.EnsureCapacity
	|
	|-RVA: 0x33D1650 Offset: 0x33D1751 VA: 0x33D1650
	|-List<AsyncOperationHandle>.EnsureCapacity
	|
	|-RVA: 0x33D49F0 Offset: 0x33D4AF1 VA: 0x33D49F0
	|-List<AsyncOperationHandle<SceneInstance>>.EnsureCapacity
	|
	|-RVA: 0x33D7E30 Offset: 0x33D7F31 VA: 0x33D7E30
	|-List<DiagnosticEvent>.EnsureCapacity
	|
	|-RVA: 0x33DB350 Offset: 0x33DB451 VA: 0x33DB350
	|-List<DelayedActionManager.DelegateInfo>.EnsureCapacity
	|
	|-RVA: 0x33DE7A0 Offset: 0x33DE8A1 VA: 0x33DE7A0
	|-List<ObjectInitializationData>.EnsureCapacity
	|
	|-RVA: 0x31B9AF0 Offset: 0x31B9BF1 VA: 0x31B9AF0
	|-List<GlyphRect>.EnsureCapacity
	|
	|-RVA: 0x31BCCA0 Offset: 0x31BCDA1 VA: 0x31BCCA0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.EnsureCapacity
	|
	|-RVA: 0x31C00E0 Offset: 0x31C01E1 VA: 0x31C00E0
	|-List<IntervalTreeNode>.EnsureCapacity
	|
	|-RVA: 0x31C3450 Offset: 0x31C3551 VA: 0x31C3450
	|-List<IntervalTree.Entry<object>>.EnsureCapacity
	|
	|-RVA: 0x31C67F0 Offset: 0x31C68F1 VA: 0x31C67F0
	|-List<TimeNotificationBehaviour.NotificationEntry>.EnsureCapacity
	|
	|-RVA: 0x31C9AD0 Offset: 0x31C9BD1 VA: 0x31C9AD0
	|-List<UICharInfo>.EnsureCapacity
	|
	|-RVA: 0x31CCB10 Offset: 0x31CCC11 VA: 0x31CCB10
	|-List<FocusController.FocusedElement>.EnsureCapacity
	|
	|-RVA: 0x31CFB30 Offset: 0x31CFC31 VA: 0x31CFB30
	|-List<UILineInfo>.EnsureCapacity
	|
	|-RVA: 0x31D2E50 Offset: 0x31D2F51 VA: 0x31D2E50
	|-List<UIVertex>.EnsureCapacity
	|
	|-RVA: 0x31D6660 Offset: 0x31D6761 VA: 0x31D6660
	|-List<UnitySynchronizationContext.WorkRequest>.EnsureCapacity
	|
	|-RVA: 0x31D98E0 Offset: 0x31D99E1 VA: 0x31D98E0
	|-List<Vector2>.EnsureCapacity
	|
	|-RVA: 0x2CE2500 Offset: 0x2CE2601 VA: 0x2CE2500
	|-List<Vector2Int>.EnsureCapacity
	|
	|-RVA: 0x2CE5520 Offset: 0x2CE5621 VA: 0x2CE5520
	|-List<Vector3>.EnsureCapacity
	|
	|-RVA: 0x2CE8590 Offset: 0x2CE8691 VA: 0x2CE8590
	|-List<Vector3Int>.EnsureCapacity
	|
	|-RVA: 0x2CEB670 Offset: 0x2CEB771 VA: 0x2CEB670
	|-List<Vector4>.EnsureCapacity
	|
	|-RVA: 0x2CEEAC0 Offset: 0x2CEEBC1 VA: 0x2CEEAC0
	|-List<WarpPoints.WarpPoint>.EnsureCapacity
	|
	|-RVA: 0x2CF2380 Offset: 0x2CF2481 VA: 0x2CF2380
	|-List<YieldItemParam>.EnsureCapacity
	|
	|-RVA: 0x2CF5460 Offset: 0x2CF5561 VA: 0x2CF5460
	|-List<stCommand_t>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public bool Exists(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248D6D0 Offset: 0x248D7D1 VA: 0x248D6D0
	|-List<AS_ToolController.ChargeInfo>.Exists
	|
	|-RVA: 0x2490D90 Offset: 0x2490E91 VA: 0x2490D90
	|-List<BuildItemData>.Exists
	|
	|-RVA: 0x3156C70 Offset: 0x3156D71 VA: 0x3156C70
	|-List<ButtonLinker.LinkObject>.Exists
	|
	|-RVA: 0x3159CA0 Offset: 0x3159DA1 VA: 0x3159CA0
	|-List<CharaCallTable.BustupTable>.Exists
	|
	|-RVA: 0x315CD00 Offset: 0x315CE01 VA: 0x315CD00
	|-List<CharaCallTable.CharaFaceIconTable>.Exists
	|
	|-RVA: 0x315FD90 Offset: 0x315FE91 VA: 0x315FD90
	|-List<CameraState.CustomBlendable>.Exists
	|
	|-RVA: 0x3162DA0 Offset: 0x3162EA1 VA: 0x3162DA0
	|-List<CinemachineClearShot.Pair>.Exists
	|
	|-RVA: 0x3165D50 Offset: 0x3165E51 VA: 0x3165D50
	|-List<CinemachineStateDrivenCamera.HashPair>.Exists
	|
	|-RVA: 0x3168EB0 Offset: 0x3168FB1 VA: 0x3168EB0
	|-List<TargetPositionCache.CacheCurve.Item>.Exists
	|
	|-RVA: 0x316C3D0 Offset: 0x316C4D1 VA: 0x316C3D0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Exists
	|
	|-RVA: 0x316F8F0 Offset: 0x316F9F1 VA: 0x316F8F0
	|-List<CropDataTable>.Exists
	|
	|-RVA: 0x336E050 Offset: 0x336E151 VA: 0x336E050
	|-List<ActorID>.Exists
	|-List<Int32Enum>.Exists
	|
	|-RVA: 0x3172D10 Offset: 0x3172E11 VA: 0x3172D10
	|-List<DropItemParam>.Exists
	|
	|-RVA: 0x3175DF0 Offset: 0x3175EF1 VA: 0x3175DF0
	|-List<ErosionBrush.UndoStep>.Exists
	|
	|-RVA: 0x31DCA80 Offset: 0x31DCB81 VA: 0x31DCA80
	|-List<EventCheckId>.Exists
	|
	|-RVA: 0x31DFD20 Offset: 0x31DFE21 VA: 0x31DFD20
	|-List<EventFlagProgressData>.Exists
	|
	|-RVA: 0x327C040 Offset: 0x327C141 VA: 0x327C040
	|-List<FesNpcScore>.Exists
	|-List<OnGroundItem>.Exists
	|-List<SceneTransitionManager.GameObjectEnabled>.Exists
	|-List<object>.Exists
	|-List<ScriptableObject>.Exists
	|
	|-RVA: 0x31E2D70 Offset: 0x31E2E71 VA: 0x31E2D70
	|-List<FesNpcScoreData>.Exists
	|
	|-RVA: 0x31E5F80 Offset: 0x31E6081 VA: 0x31E5F80
	|-List<MiningPointSaveData>.Exists
	|
	|-RVA: 0x31E94C0 Offset: 0x31E95C1 VA: 0x31E94C0
	|-List<MonsterHutSaveData>.Exists
	|
	|-RVA: 0x31EC840 Offset: 0x31EC941 VA: 0x31EC840
	|-List<MoviePlayer.SUBTITLEDATA>.Exists
	|
	|-RVA: 0x31EFA70 Offset: 0x31EFB71 VA: 0x31EFA70
	|-List<NPCActionData>.Exists
	|
	|-RVA: 0x31F3050 Offset: 0x31F3151 VA: 0x31F3050
	|-List<NpcPlaceSchedule>.Exists
	|
	|-RVA: 0x31F6320 Offset: 0x31F6421 VA: 0x31F6320
	|-List<OrderLotterySaveParameter>.Exists
	|
	|-RVA: 0x31F94B0 Offset: 0x31F95B1 VA: 0x31F94B0
	|-List<OrderSaveParameter>.Exists
	|
	|-RVA: 0x31FC760 Offset: 0x31FC861 VA: 0x31FC760
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Exists
	|
	|-RVA: 0x330B9D0 Offset: 0x330BAD1 VA: 0x330B9D0
	|-List<ShopCatalogPage>.Exists
	|
	|-RVA: 0x330EBB0 Offset: 0x330ECB1 VA: 0x330EBB0
	|-List<ShopNpcTalk>.Exists
	|
	|-RVA: 0x3312000 Offset: 0x3312101 VA: 0x3312000
	|-List<SubtitleDataTable.Data>.Exists
	|
	|-RVA: 0x3315070 Offset: 0x3315171 VA: 0x3315070
	|-List<SubtitleDataTable.DataList>.Exists
	|
	|-RVA: 0x3318090 Offset: 0x3318191 VA: 0x3318090
	|-List<SubtitleHudDataTable.Data>.Exists
	|
	|-RVA: 0x331B220 Offset: 0x331B321 VA: 0x331B220
	|-List<SRMonoBehaviourEx.FieldInfo>.Exists
	|
	|-RVA: 0x331E5B0 Offset: 0x331E6B1 VA: 0x331E5B0
	|-List<Schedule>.Exists
	|
	|-RVA: 0x3321AB0 Offset: 0x3321BB1 VA: 0x3321AB0
	|-List<CurveSample>.Exists
	|
	|-RVA: 0x33250C0 Offset: 0x33251C1 VA: 0x33250C0
	|-List<bool>.Exists
	|
	|-RVA: 0x33280A0 Offset: 0x33281A1 VA: 0x33280A0
	|-List<byte>.Exists
	|
	|-RVA: 0x332B060 Offset: 0x332B161 VA: 0x332B060
	|-List<char>.Exists
	|
	|-RVA: 0x33590E0 Offset: 0x33591E1 VA: 0x33590E0
	|-List<KeyValuePair<DateTime, object>>.Exists
	|
	|-RVA: 0x335C130 Offset: 0x335C231 VA: 0x335C130
	|-List<KeyValuePair<int, object>>.Exists
	|
	|-RVA: 0x335F180 Offset: 0x335F281 VA: 0x335F180
	|-List<KeyValuePair<object, object>>.Exists
	|
	|-RVA: 0x3362190 Offset: 0x3362291 VA: 0x3362190
	|-List<DateTime>.Exists
	|
	|-RVA: 0x3365140 Offset: 0x3365241 VA: 0x3365140
	|-List<double>.Exists
	|
	|-RVA: 0x33680F0 Offset: 0x33681F1 VA: 0x33680F0
	|-List<short>.Exists
	|
	|-RVA: 0x336B0A0 Offset: 0x336B1A1 VA: 0x336B0A0
	|-List<int>.Exists
	|
	|-RVA: 0x3371000 Offset: 0x3371101 VA: 0x3371000
	|-List<long>.Exists
	|
	|-RVA: 0x3373FE0 Offset: 0x33740E1 VA: 0x3373FE0
	|-List<InterpretedFrameInfo>.Exists
	|
	|-RVA: 0x3377060 Offset: 0x3377161 VA: 0x3377060
	|-List<Nullable<Int32Enum>>.Exists
	|
	|-RVA: 0x3405EF0 Offset: 0x3405FF1 VA: 0x3405EF0
	|-List<Nullable<Bounds>>.Exists
	|
	|-RVA: 0x34094B0 Offset: 0x34095B1 VA: 0x34094B0
	|-List<Nullable<BoundsInt>>.Exists
	|
	|-RVA: 0x340C870 Offset: 0x340C971 VA: 0x340C870
	|-List<Nullable<Color32>>.Exists
	|
	|-RVA: 0x340F9E0 Offset: 0x340FAE1 VA: 0x340F9E0
	|-List<Nullable<Color>>.Exists
	|
	|-RVA: 0x3412D40 Offset: 0x3412E41 VA: 0x3412D40
	|-List<Nullable<GradientAlphaKey>>.Exists
	|
	|-RVA: 0x3415F60 Offset: 0x3416061 VA: 0x3415F60
	|-List<Nullable<GradientColorKey>>.Exists
	|
	|-RVA: 0x34193B0 Offset: 0x34194B1 VA: 0x34193B0
	|-List<Nullable<Keyframe>>.Exists
	|
	|-RVA: 0x341C6A0 Offset: 0x341C7A1 VA: 0x341C6A0
	|-List<Nullable<LayerMask>>.Exists
	|
	|-RVA: 0x341FA00 Offset: 0x341FB01 VA: 0x341FA00
	|-List<Nullable<Matrix4x4>>.Exists
	|
	|-RVA: 0x3423250 Offset: 0x3423351 VA: 0x3423250
	|-List<Nullable<Quaternion>>.Exists
	|
	|-RVA: 0x3263020 Offset: 0x3263121 VA: 0x3263020
	|-List<Nullable<RangeInt>>.Exists
	|
	|-RVA: 0x3266240 Offset: 0x3266341 VA: 0x3266240
	|-List<Nullable<Rect>>.Exists
	|
	|-RVA: 0x32696A0 Offset: 0x32697A1 VA: 0x32696A0
	|-List<Nullable<RectInt>>.Exists
	|
	|-RVA: 0x326CA00 Offset: 0x326CB01 VA: 0x326CA00
	|-List<Nullable<Vector2>>.Exists
	|
	|-RVA: 0x326FB20 Offset: 0x326FC21 VA: 0x326FB20
	|-List<Nullable<Vector2Int>>.Exists
	|
	|-RVA: 0x3272BF0 Offset: 0x3272CF1 VA: 0x3272BF0
	|-List<Nullable<Vector3>>.Exists
	|
	|-RVA: 0x3275C60 Offset: 0x3275D61 VA: 0x3275C60
	|-List<Nullable<Vector3Int>>.Exists
	|
	|-RVA: 0x3278E20 Offset: 0x3278F21 VA: 0x3278E20
	|-List<Nullable<Vector4>>.Exists
	|
	|-RVA: 0x327EFE0 Offset: 0x327F0E1 VA: 0x327EFE0
	|-List<sbyte>.Exists
	|
	|-RVA: 0x3281FA0 Offset: 0x32820A1 VA: 0x3281FA0
	|-List<float>.Exists
	|
	|-RVA: 0x32A9200 Offset: 0x32A9301 VA: 0x32A9200
	|-List<ushort>.Exists
	|
	|-RVA: 0x32AC1B0 Offset: 0x32AC2B1 VA: 0x32AC1B0
	|-List<uint>.Exists
	|
	|-RVA: 0x32AF160 Offset: 0x32AF261 VA: 0x32AF160
	|-List<ulong>.Exists
	|
	|-RVA: 0x32B2110 Offset: 0x32B2211 VA: 0x32B2110
	|-List<ValueTuple<bool, Int32Enum>>.Exists
	|
	|-RVA: 0x32B50C0 Offset: 0x32B51C1 VA: 0x32B50C0
	|-List<ValueTuple<Int32Enum, int>>.Exists
	|
	|-RVA: 0x32B80A0 Offset: 0x32B81A1 VA: 0x32B80A0
	|-List<ValueTuple<Int32Enum, object>>.Exists
	|
	|-RVA: 0x32BB0F0 Offset: 0x32BB1F1 VA: 0x32BB0F0
	|-List<ValueTuple<object, Int32Enum>>.Exists
	|
	|-RVA: 0x32BE130 Offset: 0x32BE231 VA: 0x32BE130
	|-List<ValueTuple<object, object>>.Exists
	|
	|-RVA: 0x32C1170 Offset: 0x32C1271 VA: 0x32C1170
	|-List<ValueTuple<object, float>>.Exists
	|
	|-RVA: 0x32C41E0 Offset: 0x32C42E1 VA: 0x32C41E0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Exists
	|
	|-RVA: 0x32C7470 Offset: 0x32C7571 VA: 0x32C7470
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Exists
	|
	|-RVA: 0x31110D0 Offset: 0x31111D1 VA: 0x31110D0
	|-List<TexturePacker_JsonArray.Frame>.Exists
	|
	|-RVA: 0x31145F0 Offset: 0x31146F1 VA: 0x31145F0
	|-List<TutorialUnlockFlagData>.Exists
	|
	|-RVA: 0x3117680 Offset: 0x3117781 VA: 0x3117680
	|-List<UIMainManagerAttachObject.AttachSet>.Exists
	|
	|-RVA: 0x311A890 Offset: 0x311A991 VA: 0x311A890
	|-List<CapEdge>.Exists
	|
	|-RVA: 0x311DC00 Offset: 0x311DD01 VA: 0x311DC00
	|-List<MeshDataConnectivity.Face>.Exists
	|
	|-RVA: 0x3120CC0 Offset: 0x3120DC1 VA: 0x3120CC0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Exists
	|
	|-RVA: 0x31240D0 Offset: 0x31241D1 VA: 0x31240D0
	|-List<MeshFaceConnectivity.EdgeData>.Exists
	|
	|-RVA: 0x31274D0 Offset: 0x31275D1 VA: 0x31274D0
	|-List<NavMeshBuildMarkup>.Exists
	|
	|-RVA: 0x312A890 Offset: 0x312A991 VA: 0x312A890
	|-List<NavMeshBuildSource>.Exists
	|
	|-RVA: 0x312E0D0 Offset: 0x312E1D1 VA: 0x312E0D0
	|-List<ConstraintSource>.Exists
	|
	|-RVA: 0x31310E0 Offset: 0x31311E1 VA: 0x31310E0
	|-List<AnimatorClipInfo>.Exists
	|
	|-RVA: 0x321CCA0 Offset: 0x321CDA1 VA: 0x321CCA0
	|-List<BeforeRenderHelper.OrderBlock>.Exists
	|
	|-RVA: 0x321FDD0 Offset: 0x321FED1 VA: 0x321FDD0
	|-List<BoneWeight>.Exists
	|
	|-RVA: 0x3223130 Offset: 0x3223231 VA: 0x3223130
	|-List<Bounds>.Exists
	|
	|-RVA: 0x3226480 Offset: 0x3226581 VA: 0x3226480
	|-List<BoundsInt>.Exists
	|
	|-RVA: 0x32296D0 Offset: 0x32297D1 VA: 0x32296D0
	|-List<Color32>.Exists
	|
	|-RVA: 0x322C710 Offset: 0x322C811 VA: 0x322C710
	|-List<Color>.Exists
	|
	|-RVA: 0x322FAD0 Offset: 0x322FBD1 VA: 0x322FAD0
	|-List<CombineInstance>.Exists
	|
	|-RVA: 0x32335E0 Offset: 0x32336E1 VA: 0x32335E0
	|-List<RaycastResult>.Exists
	|
	|-RVA: 0x3236BF0 Offset: 0x3236CF1 VA: 0x3236BF0
	|-List<GradientAlphaKey>.Exists
	|
	|-RVA: 0x3239D10 Offset: 0x3239E11 VA: 0x3239D10
	|-List<GradientColorKey>.Exists
	|
	|-RVA: 0x323D110 Offset: 0x323D211 VA: 0x323D110
	|-List<Keyframe>.Exists
	|
	|-RVA: 0x3240450 Offset: 0x3240551 VA: 0x3240450
	|-List<LayerMask>.Exists
	|
	|-RVA: 0x3243620 Offset: 0x3243721 VA: 0x3243620
	|-List<Matrix4x4>.Exists
	|
	|-RVA: 0x3246C30 Offset: 0x3246D31 VA: 0x3246C30
	|-List<ParticleSystem.Particle>.Exists
	|
	|-RVA: 0x3249F90 Offset: 0x324A091 VA: 0x3249F90
	|-List<Playable>.Exists
	|
	|-RVA: 0x324D0C0 Offset: 0x324D1C1 VA: 0x324D0C0
	|-List<PlayableBinding>.Exists
	|
	|-RVA: 0x3250350 Offset: 0x3250451 VA: 0x3250350
	|-List<PlayableGraph>.Exists
	|
	|-RVA: 0x3253350 Offset: 0x3253451 VA: 0x3253350
	|-List<Edge>.Exists
	|
	|-RVA: 0x3256380 Offset: 0x3256481 VA: 0x3256380
	|-List<Quaternion>.Exists
	|
	|-RVA: 0x3259380 Offset: 0x3259481 VA: 0x3259380
	|-List<RangeInt>.Exists
	|
	|-RVA: 0x325C520 Offset: 0x325C621 VA: 0x325C520
	|-List<RaycastHit2D>.Exists
	|
	|-RVA: 0x325FAA0 Offset: 0x325FBA1 VA: 0x325FAA0
	|-List<RaycastHit>.Exists
	|
	|-RVA: 0x33C17C0 Offset: 0x33C18C1 VA: 0x33C17C0
	|-List<Rect>.Exists
	|
	|-RVA: 0x33C47D0 Offset: 0x33C48D1 VA: 0x33C47D0
	|-List<RectInt>.Exists
	|
	|-RVA: 0x33C7800 Offset: 0x33C7901 VA: 0x33C7800
	|-List<ReflectionProbeBlendInfo>.Exists
	|
	|-RVA: 0x33CAC30 Offset: 0x33CAD31 VA: 0x33CAC30
	|-List<SphericalHarmonicsL2>.Exists
	|
	|-RVA: 0x33CE580 Offset: 0x33CE681 VA: 0x33CE580
	|-List<VertexAttributeDescriptor>.Exists
	|
	|-RVA: 0x33D16B0 Offset: 0x33D17B1 VA: 0x33D16B0
	|-List<AsyncOperationHandle>.Exists
	|
	|-RVA: 0x33D4A50 Offset: 0x33D4B51 VA: 0x33D4A50
	|-List<AsyncOperationHandle<SceneInstance>>.Exists
	|
	|-RVA: 0x33D7E90 Offset: 0x33D7F91 VA: 0x33D7E90
	|-List<DiagnosticEvent>.Exists
	|
	|-RVA: 0x33DB3B0 Offset: 0x33DB4B1 VA: 0x33DB3B0
	|-List<DelayedActionManager.DelegateInfo>.Exists
	|
	|-RVA: 0x33DE800 Offset: 0x33DE901 VA: 0x33DE800
	|-List<ObjectInitializationData>.Exists
	|
	|-RVA: 0x31B9B50 Offset: 0x31B9C51 VA: 0x31B9B50
	|-List<GlyphRect>.Exists
	|
	|-RVA: 0x31BCD00 Offset: 0x31BCE01 VA: 0x31BCD00
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Exists
	|
	|-RVA: 0x31C0140 Offset: 0x31C0241 VA: 0x31C0140
	|-List<IntervalTreeNode>.Exists
	|
	|-RVA: 0x31C34B0 Offset: 0x31C35B1 VA: 0x31C34B0
	|-List<IntervalTree.Entry<object>>.Exists
	|
	|-RVA: 0x31C6850 Offset: 0x31C6951 VA: 0x31C6850
	|-List<TimeNotificationBehaviour.NotificationEntry>.Exists
	|
	|-RVA: 0x31C9B30 Offset: 0x31C9C31 VA: 0x31C9B30
	|-List<UICharInfo>.Exists
	|
	|-RVA: 0x31CCB70 Offset: 0x31CCC71 VA: 0x31CCB70
	|-List<FocusController.FocusedElement>.Exists
	|
	|-RVA: 0x31CFB90 Offset: 0x31CFC91 VA: 0x31CFB90
	|-List<UILineInfo>.Exists
	|
	|-RVA: 0x31D2EB0 Offset: 0x31D2FB1 VA: 0x31D2EB0
	|-List<UIVertex>.Exists
	|
	|-RVA: 0x31D66C0 Offset: 0x31D67C1 VA: 0x31D66C0
	|-List<UnitySynchronizationContext.WorkRequest>.Exists
	|
	|-RVA: 0x31D9940 Offset: 0x31D9A41 VA: 0x31D9940
	|-List<Vector2>.Exists
	|
	|-RVA: 0x2CE2560 Offset: 0x2CE2661 VA: 0x2CE2560
	|-List<Vector2Int>.Exists
	|
	|-RVA: 0x2CE5580 Offset: 0x2CE5681 VA: 0x2CE5580
	|-List<Vector3>.Exists
	|
	|-RVA: 0x2CE85F0 Offset: 0x2CE86F1 VA: 0x2CE85F0
	|-List<Vector3Int>.Exists
	|
	|-RVA: 0x2CEB6D0 Offset: 0x2CEB7D1 VA: 0x2CEB6D0
	|-List<Vector4>.Exists
	|
	|-RVA: 0x2CEEB20 Offset: 0x2CEEC21 VA: 0x2CEEB20
	|-List<WarpPoints.WarpPoint>.Exists
	|
	|-RVA: 0x2CF23E0 Offset: 0x2CF24E1 VA: 0x2CF23E0
	|-List<YieldItemParam>.Exists
	|
	|-RVA: 0x2CF54C0 Offset: 0x2CF55C1 VA: 0x2CF54C0
	|-List<stCommand_t>.Exists
	*/

	// RVA: -1 Offset: -1
	public T Find(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327C080 Offset: 0x327C181 VA: 0x327C080
	|-List<Actor>.Find
	|-List<AdvShowOneImage.AdvSpriteLoader>.Find
	|-List<AttackCollider>.Find
	|-List<DamageText>.Find
	|-List<EnemyPatrolData.PatrolParameter>.Find
	|-List<EventFlagManager.RequestDisableEventPointData>.Find
	|-List<EventUnlockFlagData>.Find
	|-List<CellController>.Find
	|-List<FarmCropData>.Find
	|-List<FriendMonsterStatusData>.Find
	|-List<HUDDualWorkSelectInput.DualSelect>.Find
	|-List<ItemIconMng.ImageLoaderObj>.Find
	|-List<ItemIconMng.SpriteWork>.Find
	|-List<MonsterControllerBase>.Find
	|-List<OrderData>.Find
	|-List<FishShipmentRecords>.Find
	|-List<SeedLevelRecords>.Find
	|-List<ShipmentItemRecords>.Find
	|-List<SeedShopItemDataTable.SeedShopItemData>.Find
	|-List<WantedData>.Find
	|-List<TimelineMsg>.Find
	|-List<UIShopRandomItemTable.Datas>.Find
	|-List<UIShopRandomItemTable.RandomIdList>.Find
	|-List<Toggle>.Find
	|-List<object>.Find
	|
	|-RVA: 0x31E9500 Offset: 0x31E9601 VA: 0x31E9500
	|-List<MonsterHutSaveData>.Find
	|
	|-RVA: 0x248D710 Offset: 0x248D811 VA: 0x248D710
	|-List<AS_ToolController.ChargeInfo>.Find
	|
	|-RVA: 0x2490DD0 Offset: 0x2490ED1 VA: 0x2490DD0
	|-List<BuildItemData>.Find
	|
	|-RVA: 0x3156CB0 Offset: 0x3156DB1 VA: 0x3156CB0
	|-List<ButtonLinker.LinkObject>.Find
	|
	|-RVA: 0x3159CE0 Offset: 0x3159DE1 VA: 0x3159CE0
	|-List<CharaCallTable.BustupTable>.Find
	|
	|-RVA: 0x315CD40 Offset: 0x315CE41 VA: 0x315CD40
	|-List<CharaCallTable.CharaFaceIconTable>.Find
	|
	|-RVA: 0x315FDD0 Offset: 0x315FED1 VA: 0x315FDD0
	|-List<CameraState.CustomBlendable>.Find
	|
	|-RVA: 0x3162DE0 Offset: 0x3162EE1 VA: 0x3162DE0
	|-List<CinemachineClearShot.Pair>.Find
	|
	|-RVA: 0x3165D90 Offset: 0x3165E91 VA: 0x3165D90
	|-List<CinemachineStateDrivenCamera.HashPair>.Find
	|
	|-RVA: 0x3168EF0 Offset: 0x3168FF1 VA: 0x3168EF0
	|-List<TargetPositionCache.CacheCurve.Item>.Find
	|
	|-RVA: 0x316C410 Offset: 0x316C511 VA: 0x316C410
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Find
	|
	|-RVA: 0x316F930 Offset: 0x316FA31 VA: 0x316F930
	|-List<CropDataTable>.Find
	|
	|-RVA: 0x3172D50 Offset: 0x3172E51 VA: 0x3172D50
	|-List<DropItemParam>.Find
	|
	|-RVA: 0x3175E30 Offset: 0x3175F31 VA: 0x3175E30
	|-List<ErosionBrush.UndoStep>.Find
	|
	|-RVA: 0x31DCAC0 Offset: 0x31DCBC1 VA: 0x31DCAC0
	|-List<EventCheckId>.Find
	|
	|-RVA: 0x31DFD60 Offset: 0x31DFE61 VA: 0x31DFD60
	|-List<EventFlagProgressData>.Find
	|
	|-RVA: 0x31E2DB0 Offset: 0x31E2EB1 VA: 0x31E2DB0
	|-List<FesNpcScoreData>.Find
	|
	|-RVA: 0x31E5FC0 Offset: 0x31E60C1 VA: 0x31E5FC0
	|-List<MiningPointSaveData>.Find
	|
	|-RVA: 0x31EC880 Offset: 0x31EC981 VA: 0x31EC880
	|-List<MoviePlayer.SUBTITLEDATA>.Find
	|
	|-RVA: 0x31EFAB0 Offset: 0x31EFBB1 VA: 0x31EFAB0
	|-List<NPCActionData>.Find
	|
	|-RVA: 0x31F3090 Offset: 0x31F3191 VA: 0x31F3090
	|-List<NpcPlaceSchedule>.Find
	|
	|-RVA: 0x31F6360 Offset: 0x31F6461 VA: 0x31F6360
	|-List<OrderLotterySaveParameter>.Find
	|
	|-RVA: 0x31F94F0 Offset: 0x31F95F1 VA: 0x31F94F0
	|-List<OrderSaveParameter>.Find
	|
	|-RVA: 0x31FC7A0 Offset: 0x31FC8A1 VA: 0x31FC7A0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Find
	|
	|-RVA: 0x330BA10 Offset: 0x330BB11 VA: 0x330BA10
	|-List<ShopCatalogPage>.Find
	|
	|-RVA: 0x330EBF0 Offset: 0x330ECF1 VA: 0x330EBF0
	|-List<ShopNpcTalk>.Find
	|
	|-RVA: 0x3312040 Offset: 0x3312141 VA: 0x3312040
	|-List<SubtitleDataTable.Data>.Find
	|
	|-RVA: 0x33150B0 Offset: 0x33151B1 VA: 0x33150B0
	|-List<SubtitleDataTable.DataList>.Find
	|
	|-RVA: 0x33180D0 Offset: 0x33181D1 VA: 0x33180D0
	|-List<SubtitleHudDataTable.Data>.Find
	|
	|-RVA: 0x331B260 Offset: 0x331B361 VA: 0x331B260
	|-List<SRMonoBehaviourEx.FieldInfo>.Find
	|
	|-RVA: 0x331E5F0 Offset: 0x331E6F1 VA: 0x331E5F0
	|-List<Schedule>.Find
	|
	|-RVA: 0x3321AF0 Offset: 0x3321BF1 VA: 0x3321AF0
	|-List<CurveSample>.Find
	|
	|-RVA: 0x3325100 Offset: 0x3325201 VA: 0x3325100
	|-List<bool>.Find
	|
	|-RVA: 0x33280E0 Offset: 0x33281E1 VA: 0x33280E0
	|-List<byte>.Find
	|
	|-RVA: 0x332B0A0 Offset: 0x332B1A1 VA: 0x332B0A0
	|-List<char>.Find
	|
	|-RVA: 0x3359120 Offset: 0x3359221 VA: 0x3359120
	|-List<KeyValuePair<DateTime, object>>.Find
	|
	|-RVA: 0x335C170 Offset: 0x335C271 VA: 0x335C170
	|-List<KeyValuePair<int, object>>.Find
	|
	|-RVA: 0x335F1C0 Offset: 0x335F2C1 VA: 0x335F1C0
	|-List<KeyValuePair<object, object>>.Find
	|
	|-RVA: 0x33621D0 Offset: 0x33622D1 VA: 0x33621D0
	|-List<DateTime>.Find
	|
	|-RVA: 0x3365180 Offset: 0x3365281 VA: 0x3365180
	|-List<double>.Find
	|
	|-RVA: 0x3368130 Offset: 0x3368231 VA: 0x3368130
	|-List<short>.Find
	|
	|-RVA: 0x336B0E0 Offset: 0x336B1E1 VA: 0x336B0E0
	|-List<int>.Find
	|
	|-RVA: 0x336E090 Offset: 0x336E191 VA: 0x336E090
	|-List<Int32Enum>.Find
	|
	|-RVA: 0x3371040 Offset: 0x3371141 VA: 0x3371040
	|-List<long>.Find
	|
	|-RVA: 0x3374020 Offset: 0x3374121 VA: 0x3374020
	|-List<InterpretedFrameInfo>.Find
	|
	|-RVA: 0x33770A0 Offset: 0x33771A1 VA: 0x33770A0
	|-List<Nullable<Int32Enum>>.Find
	|
	|-RVA: 0x3405F30 Offset: 0x3406031 VA: 0x3405F30
	|-List<Nullable<Bounds>>.Find
	|
	|-RVA: 0x34094F0 Offset: 0x34095F1 VA: 0x34094F0
	|-List<Nullable<BoundsInt>>.Find
	|
	|-RVA: 0x340C8B0 Offset: 0x340C9B1 VA: 0x340C8B0
	|-List<Nullable<Color32>>.Find
	|
	|-RVA: 0x340FA20 Offset: 0x340FB21 VA: 0x340FA20
	|-List<Nullable<Color>>.Find
	|
	|-RVA: 0x3412D80 Offset: 0x3412E81 VA: 0x3412D80
	|-List<Nullable<GradientAlphaKey>>.Find
	|
	|-RVA: 0x3415FA0 Offset: 0x34160A1 VA: 0x3415FA0
	|-List<Nullable<GradientColorKey>>.Find
	|
	|-RVA: 0x34193F0 Offset: 0x34194F1 VA: 0x34193F0
	|-List<Nullable<Keyframe>>.Find
	|
	|-RVA: 0x341C6E0 Offset: 0x341C7E1 VA: 0x341C6E0
	|-List<Nullable<LayerMask>>.Find
	|
	|-RVA: 0x341FA40 Offset: 0x341FB41 VA: 0x341FA40
	|-List<Nullable<Matrix4x4>>.Find
	|
	|-RVA: 0x3423290 Offset: 0x3423391 VA: 0x3423290
	|-List<Nullable<Quaternion>>.Find
	|
	|-RVA: 0x3263060 Offset: 0x3263161 VA: 0x3263060
	|-List<Nullable<RangeInt>>.Find
	|
	|-RVA: 0x3266280 Offset: 0x3266381 VA: 0x3266280
	|-List<Nullable<Rect>>.Find
	|
	|-RVA: 0x32696E0 Offset: 0x32697E1 VA: 0x32696E0
	|-List<Nullable<RectInt>>.Find
	|
	|-RVA: 0x326CA40 Offset: 0x326CB41 VA: 0x326CA40
	|-List<Nullable<Vector2>>.Find
	|
	|-RVA: 0x326FB60 Offset: 0x326FC61 VA: 0x326FB60
	|-List<Nullable<Vector2Int>>.Find
	|
	|-RVA: 0x3272C30 Offset: 0x3272D31 VA: 0x3272C30
	|-List<Nullable<Vector3>>.Find
	|
	|-RVA: 0x3275CA0 Offset: 0x3275DA1 VA: 0x3275CA0
	|-List<Nullable<Vector3Int>>.Find
	|
	|-RVA: 0x3278E60 Offset: 0x3278F61 VA: 0x3278E60
	|-List<Nullable<Vector4>>.Find
	|
	|-RVA: 0x327F020 Offset: 0x327F121 VA: 0x327F020
	|-List<sbyte>.Find
	|
	|-RVA: 0x3281FE0 Offset: 0x32820E1 VA: 0x3281FE0
	|-List<float>.Find
	|
	|-RVA: 0x32A9240 Offset: 0x32A9341 VA: 0x32A9240
	|-List<ushort>.Find
	|
	|-RVA: 0x32AC1F0 Offset: 0x32AC2F1 VA: 0x32AC1F0
	|-List<uint>.Find
	|
	|-RVA: 0x32AF1A0 Offset: 0x32AF2A1 VA: 0x32AF1A0
	|-List<ulong>.Find
	|
	|-RVA: 0x32B2150 Offset: 0x32B2251 VA: 0x32B2150
	|-List<ValueTuple<bool, Int32Enum>>.Find
	|
	|-RVA: 0x32B5100 Offset: 0x32B5201 VA: 0x32B5100
	|-List<ValueTuple<Int32Enum, int>>.Find
	|
	|-RVA: 0x32B80E0 Offset: 0x32B81E1 VA: 0x32B80E0
	|-List<ValueTuple<Int32Enum, object>>.Find
	|
	|-RVA: 0x32BB130 Offset: 0x32BB231 VA: 0x32BB130
	|-List<ValueTuple<object, Int32Enum>>.Find
	|
	|-RVA: 0x32BE170 Offset: 0x32BE271 VA: 0x32BE170
	|-List<ValueTuple<object, object>>.Find
	|
	|-RVA: 0x32C11B0 Offset: 0x32C12B1 VA: 0x32C11B0
	|-List<ValueTuple<object, float>>.Find
	|
	|-RVA: 0x32C4220 Offset: 0x32C4321 VA: 0x32C4220
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Find
	|
	|-RVA: 0x32C74B0 Offset: 0x32C75B1 VA: 0x32C74B0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Find
	|
	|-RVA: 0x3111110 Offset: 0x3111211 VA: 0x3111110
	|-List<TexturePacker_JsonArray.Frame>.Find
	|
	|-RVA: 0x3114630 Offset: 0x3114731 VA: 0x3114630
	|-List<TutorialUnlockFlagData>.Find
	|
	|-RVA: 0x31176C0 Offset: 0x31177C1 VA: 0x31176C0
	|-List<UIMainManagerAttachObject.AttachSet>.Find
	|
	|-RVA: 0x311A8D0 Offset: 0x311A9D1 VA: 0x311A8D0
	|-List<CapEdge>.Find
	|
	|-RVA: 0x311DC40 Offset: 0x311DD41 VA: 0x311DC40
	|-List<MeshDataConnectivity.Face>.Find
	|
	|-RVA: 0x3120D00 Offset: 0x3120E01 VA: 0x3120D00
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Find
	|
	|-RVA: 0x3124110 Offset: 0x3124211 VA: 0x3124110
	|-List<MeshFaceConnectivity.EdgeData>.Find
	|
	|-RVA: 0x3127510 Offset: 0x3127611 VA: 0x3127510
	|-List<NavMeshBuildMarkup>.Find
	|
	|-RVA: 0x312A8D0 Offset: 0x312A9D1 VA: 0x312A8D0
	|-List<NavMeshBuildSource>.Find
	|
	|-RVA: 0x312E110 Offset: 0x312E211 VA: 0x312E110
	|-List<ConstraintSource>.Find
	|
	|-RVA: 0x3131120 Offset: 0x3131221 VA: 0x3131120
	|-List<AnimatorClipInfo>.Find
	|
	|-RVA: 0x321CCE0 Offset: 0x321CDE1 VA: 0x321CCE0
	|-List<BeforeRenderHelper.OrderBlock>.Find
	|
	|-RVA: 0x321FE10 Offset: 0x321FF11 VA: 0x321FE10
	|-List<BoneWeight>.Find
	|
	|-RVA: 0x3223170 Offset: 0x3223271 VA: 0x3223170
	|-List<Bounds>.Find
	|
	|-RVA: 0x32264C0 Offset: 0x32265C1 VA: 0x32264C0
	|-List<BoundsInt>.Find
	|
	|-RVA: 0x3229710 Offset: 0x3229811 VA: 0x3229710
	|-List<Color32>.Find
	|
	|-RVA: 0x322C750 Offset: 0x322C851 VA: 0x322C750
	|-List<Color>.Find
	|
	|-RVA: 0x322FB10 Offset: 0x322FC11 VA: 0x322FB10
	|-List<CombineInstance>.Find
	|
	|-RVA: 0x3233620 Offset: 0x3233721 VA: 0x3233620
	|-List<RaycastResult>.Find
	|
	|-RVA: 0x3236C30 Offset: 0x3236D31 VA: 0x3236C30
	|-List<GradientAlphaKey>.Find
	|
	|-RVA: 0x3239D50 Offset: 0x3239E51 VA: 0x3239D50
	|-List<GradientColorKey>.Find
	|
	|-RVA: 0x323D150 Offset: 0x323D251 VA: 0x323D150
	|-List<Keyframe>.Find
	|
	|-RVA: 0x3240490 Offset: 0x3240591 VA: 0x3240490
	|-List<LayerMask>.Find
	|
	|-RVA: 0x3243660 Offset: 0x3243761 VA: 0x3243660
	|-List<Matrix4x4>.Find
	|
	|-RVA: 0x3246C70 Offset: 0x3246D71 VA: 0x3246C70
	|-List<ParticleSystem.Particle>.Find
	|
	|-RVA: 0x3249FD0 Offset: 0x324A0D1 VA: 0x3249FD0
	|-List<Playable>.Find
	|
	|-RVA: 0x324D100 Offset: 0x324D201 VA: 0x324D100
	|-List<PlayableBinding>.Find
	|
	|-RVA: 0x3250390 Offset: 0x3250491 VA: 0x3250390
	|-List<PlayableGraph>.Find
	|
	|-RVA: 0x3253390 Offset: 0x3253491 VA: 0x3253390
	|-List<Edge>.Find
	|
	|-RVA: 0x32563C0 Offset: 0x32564C1 VA: 0x32563C0
	|-List<Quaternion>.Find
	|
	|-RVA: 0x32593C0 Offset: 0x32594C1 VA: 0x32593C0
	|-List<RangeInt>.Find
	|
	|-RVA: 0x325C560 Offset: 0x325C661 VA: 0x325C560
	|-List<RaycastHit2D>.Find
	|
	|-RVA: 0x325FAE0 Offset: 0x325FBE1 VA: 0x325FAE0
	|-List<RaycastHit>.Find
	|
	|-RVA: 0x33C1800 Offset: 0x33C1901 VA: 0x33C1800
	|-List<Rect>.Find
	|
	|-RVA: 0x33C4810 Offset: 0x33C4911 VA: 0x33C4810
	|-List<RectInt>.Find
	|
	|-RVA: 0x33C7840 Offset: 0x33C7941 VA: 0x33C7840
	|-List<ReflectionProbeBlendInfo>.Find
	|
	|-RVA: 0x33CAC70 Offset: 0x33CAD71 VA: 0x33CAC70
	|-List<SphericalHarmonicsL2>.Find
	|
	|-RVA: 0x33CE5C0 Offset: 0x33CE6C1 VA: 0x33CE5C0
	|-List<VertexAttributeDescriptor>.Find
	|
	|-RVA: 0x33D16F0 Offset: 0x33D17F1 VA: 0x33D16F0
	|-List<AsyncOperationHandle>.Find
	|
	|-RVA: 0x33D4A90 Offset: 0x33D4B91 VA: 0x33D4A90
	|-List<AsyncOperationHandle<SceneInstance>>.Find
	|
	|-RVA: 0x33D7ED0 Offset: 0x33D7FD1 VA: 0x33D7ED0
	|-List<DiagnosticEvent>.Find
	|
	|-RVA: 0x33DB3F0 Offset: 0x33DB4F1 VA: 0x33DB3F0
	|-List<DelayedActionManager.DelegateInfo>.Find
	|
	|-RVA: 0x33DE840 Offset: 0x33DE941 VA: 0x33DE840
	|-List<ObjectInitializationData>.Find
	|
	|-RVA: 0x31B9B90 Offset: 0x31B9C91 VA: 0x31B9B90
	|-List<GlyphRect>.Find
	|
	|-RVA: 0x31BCD40 Offset: 0x31BCE41 VA: 0x31BCD40
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Find
	|
	|-RVA: 0x31C0180 Offset: 0x31C0281 VA: 0x31C0180
	|-List<IntervalTreeNode>.Find
	|
	|-RVA: 0x31C34F0 Offset: 0x31C35F1 VA: 0x31C34F0
	|-List<IntervalTree.Entry<object>>.Find
	|
	|-RVA: 0x31C6890 Offset: 0x31C6991 VA: 0x31C6890
	|-List<TimeNotificationBehaviour.NotificationEntry>.Find
	|
	|-RVA: 0x31C9B70 Offset: 0x31C9C71 VA: 0x31C9B70
	|-List<UICharInfo>.Find
	|
	|-RVA: 0x31CCBB0 Offset: 0x31CCCB1 VA: 0x31CCBB0
	|-List<FocusController.FocusedElement>.Find
	|
	|-RVA: 0x31CFBD0 Offset: 0x31CFCD1 VA: 0x31CFBD0
	|-List<UILineInfo>.Find
	|
	|-RVA: 0x31D2EF0 Offset: 0x31D2FF1 VA: 0x31D2EF0
	|-List<UIVertex>.Find
	|
	|-RVA: 0x31D6700 Offset: 0x31D6801 VA: 0x31D6700
	|-List<UnitySynchronizationContext.WorkRequest>.Find
	|
	|-RVA: 0x31D9980 Offset: 0x31D9A81 VA: 0x31D9980
	|-List<Vector2>.Find
	|
	|-RVA: 0x2CE25A0 Offset: 0x2CE26A1 VA: 0x2CE25A0
	|-List<Vector2Int>.Find
	|
	|-RVA: 0x2CE55C0 Offset: 0x2CE56C1 VA: 0x2CE55C0
	|-List<Vector3>.Find
	|
	|-RVA: 0x2CE8630 Offset: 0x2CE8731 VA: 0x2CE8630
	|-List<Vector3Int>.Find
	|
	|-RVA: 0x2CEB710 Offset: 0x2CEB811 VA: 0x2CEB710
	|-List<Vector4>.Find
	|
	|-RVA: 0x2CEEB60 Offset: 0x2CEEC61 VA: 0x2CEEB60
	|-List<WarpPoints.WarpPoint>.Find
	|
	|-RVA: 0x2CF2420 Offset: 0x2CF2521 VA: 0x2CF2420
	|-List<YieldItemParam>.Find
	|
	|-RVA: 0x2CF5500 Offset: 0x2CF5601 VA: 0x2CF5500
	|-List<stCommand_t>.Find
	*/

	// RVA: -1 Offset: -1
	public List<T> FindAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327C180 Offset: 0x327C281 VA: 0x327C180
	|-List<AttackCollider>.FindAll
	|-List<CellController>.FindAll
	|-List<FarmCropData>.FindAll
	|-List<FurnitureSaveData>.FindAll
	|-List<MiningPoint>.FindAll
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.FindAll
	|-List<OnGroundItem>.FindAll
	|-List<object>.FindAll
	|
	|-RVA: 0x316FAB0 Offset: 0x316FBB1 VA: 0x316FAB0
	|-List<CropDataTable>.FindAll
	|
	|-RVA: 0x31E6110 Offset: 0x31E6211 VA: 0x31E6110
	|-List<MiningPointSaveData>.FindAll
	|
	|-RVA: 0x248D840 Offset: 0x248D941 VA: 0x248D840
	|-List<AS_ToolController.ChargeInfo>.FindAll
	|
	|-RVA: 0x2490FC0 Offset: 0x24910C1 VA: 0x2490FC0
	|-List<BuildItemData>.FindAll
	|
	|-RVA: 0x3156DB0 Offset: 0x3156EB1 VA: 0x3156DB0
	|-List<ButtonLinker.LinkObject>.FindAll
	|
	|-RVA: 0x3159DE0 Offset: 0x3159EE1 VA: 0x3159DE0
	|-List<CharaCallTable.BustupTable>.FindAll
	|
	|-RVA: 0x315CE50 Offset: 0x315CF51 VA: 0x315CE50
	|-List<CharaCallTable.CharaFaceIconTable>.FindAll
	|
	|-RVA: 0x315FED0 Offset: 0x315FFD1 VA: 0x315FED0
	|-List<CameraState.CustomBlendable>.FindAll
	|
	|-RVA: 0x3162EE0 Offset: 0x3162FE1 VA: 0x3162EE0
	|-List<CinemachineClearShot.Pair>.FindAll
	|
	|-RVA: 0x3165E90 Offset: 0x3165F91 VA: 0x3165E90
	|-List<CinemachineStateDrivenCamera.HashPair>.FindAll
	|
	|-RVA: 0x3169040 Offset: 0x3169141 VA: 0x3169040
	|-List<TargetPositionCache.CacheCurve.Item>.FindAll
	|
	|-RVA: 0x316C560 Offset: 0x316C661 VA: 0x316C560
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.FindAll
	|
	|-RVA: 0x3172E50 Offset: 0x3172F51 VA: 0x3172E50
	|-List<DropItemParam>.FindAll
	|
	|-RVA: 0x3175F60 Offset: 0x3176061 VA: 0x3175F60
	|-List<ErosionBrush.UndoStep>.FindAll
	|
	|-RVA: 0x31DCBF0 Offset: 0x31DCCF1 VA: 0x31DCBF0
	|-List<EventCheckId>.FindAll
	|
	|-RVA: 0x31DFE60 Offset: 0x31DFF61 VA: 0x31DFE60
	|-List<EventFlagProgressData>.FindAll
	|
	|-RVA: 0x31E2EB0 Offset: 0x31E2FB1 VA: 0x31E2EB0
	|-List<FesNpcScoreData>.FindAll
	|
	|-RVA: 0x31E9650 Offset: 0x31E9751 VA: 0x31E9650
	|-List<MonsterHutSaveData>.FindAll
	|
	|-RVA: 0x31EC980 Offset: 0x31ECA81 VA: 0x31EC980
	|-List<MoviePlayer.SUBTITLEDATA>.FindAll
	|
	|-RVA: 0x31EFC20 Offset: 0x31EFD21 VA: 0x31EFC20
	|-List<NPCActionData>.FindAll
	|
	|-RVA: 0x31F31C0 Offset: 0x31F32C1 VA: 0x31F31C0
	|-List<NpcPlaceSchedule>.FindAll
	|
	|-RVA: 0x31F6470 Offset: 0x31F6571 VA: 0x31F6470
	|-List<OrderLotterySaveParameter>.FindAll
	|
	|-RVA: 0x31F9620 Offset: 0x31F9721 VA: 0x31F9620
	|-List<OrderSaveParameter>.FindAll
	|
	|-RVA: 0x31FC8A0 Offset: 0x31FC9A1 VA: 0x31FC8A0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.FindAll
	|
	|-RVA: 0x330BB10 Offset: 0x330BC11 VA: 0x330BB10
	|-List<ShopCatalogPage>.FindAll
	|
	|-RVA: 0x330ED50 Offset: 0x330EE51 VA: 0x330ED50
	|-List<ShopNpcTalk>.FindAll
	|
	|-RVA: 0x3312150 Offset: 0x3312251 VA: 0x3312150
	|-List<SubtitleDataTable.Data>.FindAll
	|
	|-RVA: 0x33151B0 Offset: 0x33152B1 VA: 0x33151B0
	|-List<SubtitleDataTable.DataList>.FindAll
	|
	|-RVA: 0x33181E0 Offset: 0x33182E1 VA: 0x33181E0
	|-List<SubtitleHudDataTable.Data>.FindAll
	|
	|-RVA: 0x331B390 Offset: 0x331B491 VA: 0x331B390
	|-List<SRMonoBehaviourEx.FieldInfo>.FindAll
	|
	|-RVA: 0x331E720 Offset: 0x331E821 VA: 0x331E720
	|-List<Schedule>.FindAll
	|
	|-RVA: 0x3321C80 Offset: 0x3321D81 VA: 0x3321C80
	|-List<CurveSample>.FindAll
	|
	|-RVA: 0x3325200 Offset: 0x3325301 VA: 0x3325200
	|-List<bool>.FindAll
	|
	|-RVA: 0x33281E0 Offset: 0x33282E1 VA: 0x33281E0
	|-List<byte>.FindAll
	|
	|-RVA: 0x332B1A0 Offset: 0x332B2A1 VA: 0x332B1A0
	|-List<char>.FindAll
	|
	|-RVA: 0x3359220 Offset: 0x3359321 VA: 0x3359220
	|-List<KeyValuePair<DateTime, object>>.FindAll
	|
	|-RVA: 0x335C270 Offset: 0x335C371 VA: 0x335C270
	|-List<KeyValuePair<int, object>>.FindAll
	|
	|-RVA: 0x335F2C0 Offset: 0x335F3C1 VA: 0x335F2C0
	|-List<KeyValuePair<object, object>>.FindAll
	|
	|-RVA: 0x33622D0 Offset: 0x33623D1 VA: 0x33622D0
	|-List<DateTime>.FindAll
	|
	|-RVA: 0x3365280 Offset: 0x3365381 VA: 0x3365280
	|-List<double>.FindAll
	|
	|-RVA: 0x3368230 Offset: 0x3368331 VA: 0x3368230
	|-List<short>.FindAll
	|
	|-RVA: 0x336B1E0 Offset: 0x336B2E1 VA: 0x336B1E0
	|-List<int>.FindAll
	|
	|-RVA: 0x336E190 Offset: 0x336E291 VA: 0x336E190
	|-List<Int32Enum>.FindAll
	|
	|-RVA: 0x3371140 Offset: 0x3371241 VA: 0x3371140
	|-List<long>.FindAll
	|
	|-RVA: 0x3374120 Offset: 0x3374221 VA: 0x3374120
	|-List<InterpretedFrameInfo>.FindAll
	|
	|-RVA: 0x33771A0 Offset: 0x33772A1 VA: 0x33771A0
	|-List<Nullable<Int32Enum>>.FindAll
	|
	|-RVA: 0x3406080 Offset: 0x3406181 VA: 0x3406080
	|-List<Nullable<Bounds>>.FindAll
	|
	|-RVA: 0x3409640 Offset: 0x3409741 VA: 0x3409640
	|-List<Nullable<BoundsInt>>.FindAll
	|
	|-RVA: 0x340C9B0 Offset: 0x340CAB1 VA: 0x340C9B0
	|-List<Nullable<Color32>>.FindAll
	|
	|-RVA: 0x340FB50 Offset: 0x340FC51 VA: 0x340FB50
	|-List<Nullable<Color>>.FindAll
	|
	|-RVA: 0x3412E90 Offset: 0x3412F91 VA: 0x3412E90
	|-List<Nullable<GradientAlphaKey>>.FindAll
	|
	|-RVA: 0x34160D0 Offset: 0x34161D1 VA: 0x34160D0
	|-List<Nullable<GradientColorKey>>.FindAll
	|
	|-RVA: 0x3419520 Offset: 0x3419621 VA: 0x3419520
	|-List<Nullable<Keyframe>>.FindAll
	|
	|-RVA: 0x341C7E0 Offset: 0x341C8E1 VA: 0x341C7E0
	|-List<Nullable<LayerMask>>.FindAll
	|
	|-RVA: 0x341FBE0 Offset: 0x341FCE1 VA: 0x341FBE0
	|-List<Nullable<Matrix4x4>>.FindAll
	|
	|-RVA: 0x34233C0 Offset: 0x34234C1 VA: 0x34233C0
	|-List<Nullable<Quaternion>>.FindAll
	|
	|-RVA: 0x3263170 Offset: 0x3263271 VA: 0x3263170
	|-List<Nullable<RangeInt>>.FindAll
	|
	|-RVA: 0x32663B0 Offset: 0x32664B1 VA: 0x32663B0
	|-List<Nullable<Rect>>.FindAll
	|
	|-RVA: 0x3269810 Offset: 0x3269911 VA: 0x3269810
	|-List<Nullable<RectInt>>.FindAll
	|
	|-RVA: 0x326CB50 Offset: 0x326CC51 VA: 0x326CB50
	|-List<Nullable<Vector2>>.FindAll
	|
	|-RVA: 0x326FC70 Offset: 0x326FD71 VA: 0x326FC70
	|-List<Nullable<Vector2Int>>.FindAll
	|
	|-RVA: 0x3272D30 Offset: 0x3272E31 VA: 0x3272D30
	|-List<Nullable<Vector3>>.FindAll
	|
	|-RVA: 0x3275DA0 Offset: 0x3275EA1 VA: 0x3275DA0
	|-List<Nullable<Vector3Int>>.FindAll
	|
	|-RVA: 0x3278F90 Offset: 0x3279091 VA: 0x3278F90
	|-List<Nullable<Vector4>>.FindAll
	|
	|-RVA: 0x327F120 Offset: 0x327F221 VA: 0x327F120
	|-List<sbyte>.FindAll
	|
	|-RVA: 0x32820E0 Offset: 0x32821E1 VA: 0x32820E0
	|-List<float>.FindAll
	|
	|-RVA: 0x32A9340 Offset: 0x32A9441 VA: 0x32A9340
	|-List<ushort>.FindAll
	|
	|-RVA: 0x32AC2F0 Offset: 0x32AC3F1 VA: 0x32AC2F0
	|-List<uint>.FindAll
	|
	|-RVA: 0x32AF2A0 Offset: 0x32AF3A1 VA: 0x32AF2A0
	|-List<ulong>.FindAll
	|
	|-RVA: 0x32B2250 Offset: 0x32B2351 VA: 0x32B2250
	|-List<ValueTuple<bool, Int32Enum>>.FindAll
	|
	|-RVA: 0x32B5200 Offset: 0x32B5301 VA: 0x32B5200
	|-List<ValueTuple<Int32Enum, int>>.FindAll
	|
	|-RVA: 0x32B81E0 Offset: 0x32B82E1 VA: 0x32B81E0
	|-List<ValueTuple<Int32Enum, object>>.FindAll
	|
	|-RVA: 0x32BB230 Offset: 0x32BB331 VA: 0x32BB230
	|-List<ValueTuple<object, Int32Enum>>.FindAll
	|
	|-RVA: 0x32BE270 Offset: 0x32BE371 VA: 0x32BE270
	|-List<ValueTuple<object, object>>.FindAll
	|
	|-RVA: 0x32C12B0 Offset: 0x32C13B1 VA: 0x32C12B0
	|-List<ValueTuple<object, float>>.FindAll
	|
	|-RVA: 0x32C4330 Offset: 0x32C4431 VA: 0x32C4330
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.FindAll
	|
	|-RVA: 0x32C7620 Offset: 0x32C7721 VA: 0x32C7620
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.FindAll
	|
	|-RVA: 0x3111280 Offset: 0x3111381 VA: 0x3111280
	|-List<TexturePacker_JsonArray.Frame>.FindAll
	|
	|-RVA: 0x3114740 Offset: 0x3114841 VA: 0x3114740
	|-List<TutorialUnlockFlagData>.FindAll
	|
	|-RVA: 0x31177C0 Offset: 0x31178C1 VA: 0x31177C0
	|-List<UIMainManagerAttachObject.AttachSet>.FindAll
	|
	|-RVA: 0x311AA20 Offset: 0x311AB21 VA: 0x311AA20
	|-List<CapEdge>.FindAll
	|
	|-RVA: 0x311DD40 Offset: 0x311DE41 VA: 0x311DD40
	|-List<MeshDataConnectivity.Face>.FindAll
	|
	|-RVA: 0x3120E30 Offset: 0x3120F31 VA: 0x3120E30
	|-List<MeshFaceConnectivity.EdgeData.SideData>.FindAll
	|
	|-RVA: 0x3124270 Offset: 0x3124371 VA: 0x3124270
	|-List<MeshFaceConnectivity.EdgeData>.FindAll
	|
	|-RVA: 0x3127610 Offset: 0x3127711 VA: 0x3127610
	|-List<NavMeshBuildMarkup>.FindAll
	|
	|-RVA: 0x312AAA0 Offset: 0x312ABA1 VA: 0x312AAA0
	|-List<NavMeshBuildSource>.FindAll
	|
	|-RVA: 0x312E210 Offset: 0x312E311 VA: 0x312E210
	|-List<ConstraintSource>.FindAll
	|
	|-RVA: 0x3131220 Offset: 0x3131321 VA: 0x3131220
	|-List<AnimatorClipInfo>.FindAll
	|
	|-RVA: 0x321CDE0 Offset: 0x321CEE1 VA: 0x321CDE0
	|-List<BeforeRenderHelper.OrderBlock>.FindAll
	|
	|-RVA: 0x321FF40 Offset: 0x3220041 VA: 0x321FF40
	|-List<BoneWeight>.FindAll
	|
	|-RVA: 0x32232A0 Offset: 0x32233A1 VA: 0x32232A0
	|-List<Bounds>.FindAll
	|
	|-RVA: 0x32265F0 Offset: 0x32266F1 VA: 0x32265F0
	|-List<BoundsInt>.FindAll
	|
	|-RVA: 0x3229810 Offset: 0x3229911 VA: 0x3229810
	|-List<Color32>.FindAll
	|
	|-RVA: 0x322C870 Offset: 0x322C971 VA: 0x322C870
	|-List<Color>.FindAll
	|
	|-RVA: 0x322FCE0 Offset: 0x322FDE1 VA: 0x322FCE0
	|-List<CombineInstance>.FindAll
	|
	|-RVA: 0x32337B0 Offset: 0x32338B1 VA: 0x32337B0
	|-List<RaycastResult>.FindAll
	|
	|-RVA: 0x3236D40 Offset: 0x3236E41 VA: 0x3236D40
	|-List<GradientAlphaKey>.FindAll
	|
	|-RVA: 0x3239E80 Offset: 0x3239F81 VA: 0x3239E80
	|-List<GradientColorKey>.FindAll
	|
	|-RVA: 0x323D2A0 Offset: 0x323D3A1 VA: 0x323D2A0
	|-List<Keyframe>.FindAll
	|
	|-RVA: 0x3240590 Offset: 0x3240691 VA: 0x3240590
	|-List<LayerMask>.FindAll
	|
	|-RVA: 0x32437D0 Offset: 0x32438D1 VA: 0x32437D0
	|-List<Matrix4x4>.FindAll
	|
	|-RVA: 0x3246DD0 Offset: 0x3246ED1 VA: 0x3246DD0
	|-List<ParticleSystem.Particle>.FindAll
	|
	|-RVA: 0x324A0D0 Offset: 0x324A1D1 VA: 0x324A0D0
	|-List<Playable>.FindAll
	|
	|-RVA: 0x324D230 Offset: 0x324D331 VA: 0x324D230
	|-List<PlayableBinding>.FindAll
	|
	|-RVA: 0x3250490 Offset: 0x3250591 VA: 0x3250490
	|-List<PlayableGraph>.FindAll
	|
	|-RVA: 0x3253490 Offset: 0x3253591 VA: 0x3253490
	|-List<Edge>.FindAll
	|
	|-RVA: 0x32564E0 Offset: 0x32565E1 VA: 0x32564E0
	|-List<Quaternion>.FindAll
	|
	|-RVA: 0x32594C0 Offset: 0x32595C1 VA: 0x32594C0
	|-List<RangeInt>.FindAll
	|
	|-RVA: 0x325C6B0 Offset: 0x325C7B1 VA: 0x325C6B0
	|-List<RaycastHit2D>.FindAll
	|
	|-RVA: 0x325FC50 Offset: 0x325FD51 VA: 0x325FC50
	|-List<RaycastHit>.FindAll
	|
	|-RVA: 0x33C1920 Offset: 0x33C1A21 VA: 0x33C1920
	|-List<Rect>.FindAll
	|
	|-RVA: 0x33C4910 Offset: 0x33C4A11 VA: 0x33C4910
	|-List<RectInt>.FindAll
	|
	|-RVA: 0x33C7940 Offset: 0x33C7A41 VA: 0x33C7940
	|-List<ReflectionProbeBlendInfo>.FindAll
	|
	|-RVA: 0x33CAE60 Offset: 0x33CAF61 VA: 0x33CAE60
	|-List<SphericalHarmonicsL2>.FindAll
	|
	|-RVA: 0x33CE6C0 Offset: 0x33CE7C1 VA: 0x33CE6C0
	|-List<VertexAttributeDescriptor>.FindAll
	|
	|-RVA: 0x33D1820 Offset: 0x33D1921 VA: 0x33D1820
	|-List<AsyncOperationHandle>.FindAll
	|
	|-RVA: 0x33D4BC0 Offset: 0x33D4CC1 VA: 0x33D4BC0
	|-List<AsyncOperationHandle<SceneInstance>>.FindAll
	|
	|-RVA: 0x33D8030 Offset: 0x33D8131 VA: 0x33D8030
	|-List<DiagnosticEvent>.FindAll
	|
	|-RVA: 0x33DB520 Offset: 0x33DB621 VA: 0x33DB520
	|-List<DelayedActionManager.DelegateInfo>.FindAll
	|
	|-RVA: 0x33DE9A0 Offset: 0x33DEAA1 VA: 0x33DE9A0
	|-List<ObjectInitializationData>.FindAll
	|
	|-RVA: 0x31B9C90 Offset: 0x31B9D91 VA: 0x31B9C90
	|-List<GlyphRect>.FindAll
	|
	|-RVA: 0x31BCE90 Offset: 0x31BCF91 VA: 0x31BCE90
	|-List<AnimationOutputWeightProcessor.WeightInfo>.FindAll
	|
	|-RVA: 0x31C02B0 Offset: 0x31C03B1 VA: 0x31C02B0
	|-List<IntervalTreeNode>.FindAll
	|
	|-RVA: 0x31C3620 Offset: 0x31C3721 VA: 0x31C3620
	|-List<IntervalTree.Entry<object>>.FindAll
	|
	|-RVA: 0x31C69C0 Offset: 0x31C6AC1 VA: 0x31C69C0
	|-List<TimeNotificationBehaviour.NotificationEntry>.FindAll
	|
	|-RVA: 0x31C9C90 Offset: 0x31C9D91 VA: 0x31C9C90
	|-List<UICharInfo>.FindAll
	|
	|-RVA: 0x31CCCB0 Offset: 0x31CCDB1 VA: 0x31CCCB0
	|-List<FocusController.FocusedElement>.FindAll
	|
	|-RVA: 0x31CFCD0 Offset: 0x31CFDD1 VA: 0x31CFCD0
	|-List<UILineInfo>.FindAll
	|
	|-RVA: 0x31D30A0 Offset: 0x31D31A1 VA: 0x31D30A0
	|-List<UIVertex>.FindAll
	|
	|-RVA: 0x31D6830 Offset: 0x31D6931 VA: 0x31D6830
	|-List<UnitySynchronizationContext.WorkRequest>.FindAll
	|
	|-RVA: 0x31D9A90 Offset: 0x31D9B91 VA: 0x31D9A90
	|-List<Vector2>.FindAll
	|
	|-RVA: 0x2CE26A0 Offset: 0x2CE27A1 VA: 0x2CE26A0
	|-List<Vector2Int>.FindAll
	|
	|-RVA: 0x2CE56E0 Offset: 0x2CE57E1 VA: 0x2CE56E0
	|-List<Vector3>.FindAll
	|
	|-RVA: 0x2CE8740 Offset: 0x2CE8841 VA: 0x2CE8740
	|-List<Vector3Int>.FindAll
	|
	|-RVA: 0x2CEB830 Offset: 0x2CEB931 VA: 0x2CEB830
	|-List<Vector4>.FindAll
	|
	|-RVA: 0x2CEED50 Offset: 0x2CEEE51 VA: 0x2CEED50
	|-List<WarpPoints.WarpPoint>.FindAll
	|
	|-RVA: 0x2CF2520 Offset: 0x2CF2621 VA: 0x2CF2520
	|-List<YieldItemParam>.FindAll
	|
	|-RVA: 0x2CF5630 Offset: 0x2CF5731 VA: 0x2CF5630
	|-List<stCommand_t>.FindAll
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248DA40 Offset: 0x248DB41 VA: 0x248DA40
	|-List<AS_ToolController.ChargeInfo>.FindIndex
	|
	|-RVA: 0x327C320 Offset: 0x327C421 VA: 0x327C320
	|-List<Actor>.FindIndex
	|-List<AdvOneImageDataTable.DataTable>.FindIndex
	|-List<DamageText>.FindIndex
	|-List<FarmSupportMonsterData>.FindIndex
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>.FindIndex
	|-List<FishRecord>.FindIndex
	|-List<HUDDualWorkSelectInput.DualSelect>.FindIndex
	|-List<MiningPoint>.FindIndex
	|-List<MonsterControllerBase.DropItemDataParameter>.FindIndex
	|-List<MonsterHutController.OrderFarmInParameter>.FindIndex
	|-List<UIEMCustomizeSet>.FindIndex
	|-List<SimpleAnimationPlayable.StateInfo>.FindIndex
	|-List<object>.FindIndex
	|-List<KerningPair>.FindIndex
	|-List<TMP_MaterialManager.MaskingMaterial>.FindIndex
	|-List<TextRecordParsing.Record>.FindIndex
	|
	|-RVA: 0x2491300 Offset: 0x2491401 VA: 0x2491300
	|-List<BuildItemData>.FindIndex
	|
	|-RVA: 0x3156F60 Offset: 0x3157061 VA: 0x3156F60
	|-List<ButtonLinker.LinkObject>.FindIndex
	|
	|-RVA: 0x3159F90 Offset: 0x315A091 VA: 0x3159F90
	|-List<CharaCallTable.BustupTable>.FindIndex
	|
	|-RVA: 0x315CFC0 Offset: 0x315D0C1 VA: 0x315CFC0
	|-List<CharaCallTable.CharaFaceIconTable>.FindIndex
	|
	|-RVA: 0x3160080 Offset: 0x3160181 VA: 0x3160080
	|-List<CameraState.CustomBlendable>.FindIndex
	|
	|-RVA: 0x3163080 Offset: 0x3163181 VA: 0x3163080
	|-List<CinemachineClearShot.Pair>.FindIndex
	|
	|-RVA: 0x3166030 Offset: 0x3166131 VA: 0x3166030
	|-List<CinemachineStateDrivenCamera.HashPair>.FindIndex
	|
	|-RVA: 0x3169260 Offset: 0x3169361 VA: 0x3169260
	|-List<TargetPositionCache.CacheCurve.Item>.FindIndex
	|
	|-RVA: 0x316C780 Offset: 0x316C881 VA: 0x316C780
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.FindIndex
	|
	|-RVA: 0x316FCE0 Offset: 0x316FDE1 VA: 0x316FCE0
	|-List<CropDataTable>.FindIndex
	|
	|-RVA: 0x336E330 Offset: 0x336E431 VA: 0x336E330
	|-List<StorageType>.FindIndex
	|-List<Int32Enum>.FindIndex
	|
	|-RVA: 0x3172FF0 Offset: 0x31730F1 VA: 0x3172FF0
	|-List<DropItemParam>.FindIndex
	|
	|-RVA: 0x3176160 Offset: 0x3176261 VA: 0x3176160
	|-List<ErosionBrush.UndoStep>.FindIndex
	|
	|-RVA: 0x31DCDF0 Offset: 0x31DCEF1 VA: 0x31DCDF0
	|-List<EventCheckId>.FindIndex
	|
	|-RVA: 0x31E0010 Offset: 0x31E0111 VA: 0x31E0010
	|-List<EventFlagProgressData>.FindIndex
	|
	|-RVA: 0x31E3060 Offset: 0x31E3161 VA: 0x31E3060
	|-List<FesNpcScoreData>.FindIndex
	|
	|-RVA: 0x31E6330 Offset: 0x31E6431 VA: 0x31E6330
	|-List<MiningPointSaveData>.FindIndex
	|
	|-RVA: 0x31E9870 Offset: 0x31E9971 VA: 0x31E9870
	|-List<MonsterHutSaveData>.FindIndex
	|
	|-RVA: 0x31ECB30 Offset: 0x31ECC31 VA: 0x31ECB30
	|-List<MoviePlayer.SUBTITLEDATA>.FindIndex
	|
	|-RVA: 0x31EFEA0 Offset: 0x31EFFA1 VA: 0x31EFEA0
	|-List<NPCActionData>.FindIndex
	|
	|-RVA: 0x31F33C0 Offset: 0x31F34C1 VA: 0x31F33C0
	|-List<NpcPlaceSchedule>.FindIndex
	|
	|-RVA: 0x31F65E0 Offset: 0x31F66E1 VA: 0x31F65E0
	|-List<OrderLotterySaveParameter>.FindIndex
	|
	|-RVA: 0x31F9820 Offset: 0x31F9921 VA: 0x31F9820
	|-List<OrderSaveParameter>.FindIndex
	|
	|-RVA: 0x31FCA50 Offset: 0x31FCB51 VA: 0x31FCA50
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.FindIndex
	|
	|-RVA: 0x330BCC0 Offset: 0x330BDC1 VA: 0x330BCC0
	|-List<ShopCatalogPage>.FindIndex
	|
	|-RVA: 0x330EFA0 Offset: 0x330F0A1 VA: 0x330EFA0
	|-List<ShopNpcTalk>.FindIndex
	|
	|-RVA: 0x33122C0 Offset: 0x33123C1 VA: 0x33122C0
	|-List<SubtitleDataTable.Data>.FindIndex
	|
	|-RVA: 0x3315350 Offset: 0x3315451 VA: 0x3315350
	|-List<SubtitleDataTable.DataList>.FindIndex
	|
	|-RVA: 0x3318350 Offset: 0x3318451 VA: 0x3318350
	|-List<SubtitleHudDataTable.Data>.FindIndex
	|
	|-RVA: 0x331B590 Offset: 0x331B691 VA: 0x331B590
	|-List<SRMonoBehaviourEx.FieldInfo>.FindIndex
	|
	|-RVA: 0x331E920 Offset: 0x331EA21 VA: 0x331E920
	|-List<Schedule>.FindIndex
	|
	|-RVA: 0x3321F30 Offset: 0x3322031 VA: 0x3321F30
	|-List<CurveSample>.FindIndex
	|
	|-RVA: 0x33253A0 Offset: 0x33254A1 VA: 0x33253A0
	|-List<bool>.FindIndex
	|
	|-RVA: 0x3328380 Offset: 0x3328481 VA: 0x3328380
	|-List<byte>.FindIndex
	|
	|-RVA: 0x332B340 Offset: 0x332B441 VA: 0x332B340
	|-List<char>.FindIndex
	|
	|-RVA: 0x33593D0 Offset: 0x33594D1 VA: 0x33593D0
	|-List<KeyValuePair<DateTime, object>>.FindIndex
	|
	|-RVA: 0x335C420 Offset: 0x335C521 VA: 0x335C420
	|-List<KeyValuePair<int, object>>.FindIndex
	|
	|-RVA: 0x335F470 Offset: 0x335F571 VA: 0x335F470
	|-List<KeyValuePair<object, object>>.FindIndex
	|
	|-RVA: 0x3362470 Offset: 0x3362571 VA: 0x3362470
	|-List<DateTime>.FindIndex
	|
	|-RVA: 0x3365420 Offset: 0x3365521 VA: 0x3365420
	|-List<double>.FindIndex
	|
	|-RVA: 0x33683D0 Offset: 0x33684D1 VA: 0x33683D0
	|-List<short>.FindIndex
	|
	|-RVA: 0x336B380 Offset: 0x336B481 VA: 0x336B380
	|-List<int>.FindIndex
	|
	|-RVA: 0x33712E0 Offset: 0x33713E1 VA: 0x33712E0
	|-List<long>.FindIndex
	|
	|-RVA: 0x33742D0 Offset: 0x33743D1 VA: 0x33742D0
	|-List<InterpretedFrameInfo>.FindIndex
	|
	|-RVA: 0x3377340 Offset: 0x3377441 VA: 0x3377340
	|-List<Nullable<Int32Enum>>.FindIndex
	|
	|-RVA: 0x34062A0 Offset: 0x34063A1 VA: 0x34062A0
	|-List<Nullable<Bounds>>.FindIndex
	|
	|-RVA: 0x3409860 Offset: 0x3409961 VA: 0x3409860
	|-List<Nullable<BoundsInt>>.FindIndex
	|
	|-RVA: 0x340CB50 Offset: 0x340CC51 VA: 0x340CB50
	|-List<Nullable<Color32>>.FindIndex
	|
	|-RVA: 0x340FD50 Offset: 0x340FE51 VA: 0x340FD50
	|-List<Nullable<Color>>.FindIndex
	|
	|-RVA: 0x3413000 Offset: 0x3413101 VA: 0x3413000
	|-List<Nullable<GradientAlphaKey>>.FindIndex
	|
	|-RVA: 0x34162D0 Offset: 0x34163D1 VA: 0x34162D0
	|-List<Nullable<GradientColorKey>>.FindIndex
	|
	|-RVA: 0x3419720 Offset: 0x3419821 VA: 0x3419720
	|-List<Nullable<Keyframe>>.FindIndex
	|
	|-RVA: 0x341C980 Offset: 0x341CA81 VA: 0x341C980
	|-List<Nullable<LayerMask>>.FindIndex
	|
	|-RVA: 0x341FEB0 Offset: 0x341FFB1 VA: 0x341FEB0
	|-List<Nullable<Matrix4x4>>.FindIndex
	|
	|-RVA: 0x34235C0 Offset: 0x34236C1 VA: 0x34235C0
	|-List<Nullable<Quaternion>>.FindIndex
	|
	|-RVA: 0x32632E0 Offset: 0x32633E1 VA: 0x32632E0
	|-List<Nullable<RangeInt>>.FindIndex
	|
	|-RVA: 0x32665B0 Offset: 0x32666B1 VA: 0x32665B0
	|-List<Nullable<Rect>>.FindIndex
	|
	|-RVA: 0x3269A10 Offset: 0x3269B11 VA: 0x3269A10
	|-List<Nullable<RectInt>>.FindIndex
	|
	|-RVA: 0x326CCC0 Offset: 0x326CDC1 VA: 0x326CCC0
	|-List<Nullable<Vector2>>.FindIndex
	|
	|-RVA: 0x326FDE0 Offset: 0x326FEE1 VA: 0x326FDE0
	|-List<Nullable<Vector2Int>>.FindIndex
	|
	|-RVA: 0x3272EE0 Offset: 0x3272FE1 VA: 0x3272EE0
	|-List<Nullable<Vector3>>.FindIndex
	|
	|-RVA: 0x3275F50 Offset: 0x3276051 VA: 0x3275F50
	|-List<Nullable<Vector3Int>>.FindIndex
	|
	|-RVA: 0x3279190 Offset: 0x3279291 VA: 0x3279190
	|-List<Nullable<Vector4>>.FindIndex
	|
	|-RVA: 0x327F2C0 Offset: 0x327F3C1 VA: 0x327F2C0
	|-List<sbyte>.FindIndex
	|
	|-RVA: 0x3282280 Offset: 0x3282381 VA: 0x3282280
	|-List<float>.FindIndex
	|
	|-RVA: 0x32A94E0 Offset: 0x32A95E1 VA: 0x32A94E0
	|-List<ushort>.FindIndex
	|
	|-RVA: 0x32AC490 Offset: 0x32AC591 VA: 0x32AC490
	|-List<uint>.FindIndex
	|
	|-RVA: 0x32AF440 Offset: 0x32AF541 VA: 0x32AF440
	|-List<ulong>.FindIndex
	|
	|-RVA: 0x32B23F0 Offset: 0x32B24F1 VA: 0x32B23F0
	|-List<ValueTuple<bool, Int32Enum>>.FindIndex
	|
	|-RVA: 0x32B53A0 Offset: 0x32B54A1 VA: 0x32B53A0
	|-List<ValueTuple<Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x32B8390 Offset: 0x32B8491 VA: 0x32B8390
	|-List<ValueTuple<Int32Enum, object>>.FindIndex
	|
	|-RVA: 0x32BB3E0 Offset: 0x32BB4E1 VA: 0x32BB3E0
	|-List<ValueTuple<object, Int32Enum>>.FindIndex
	|
	|-RVA: 0x32BE420 Offset: 0x32BE521 VA: 0x32BE420
	|-List<ValueTuple<object, object>>.FindIndex
	|
	|-RVA: 0x32C1460 Offset: 0x32C1561 VA: 0x32C1460
	|-List<ValueTuple<object, float>>.FindIndex
	|
	|-RVA: 0x32C44A0 Offset: 0x32C45A1 VA: 0x32C44A0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.FindIndex
	|
	|-RVA: 0x32C78A0 Offset: 0x32C79A1 VA: 0x32C78A0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.FindIndex
	|
	|-RVA: 0x3111500 Offset: 0x3111601 VA: 0x3111500
	|-List<TexturePacker_JsonArray.Frame>.FindIndex
	|
	|-RVA: 0x31148B0 Offset: 0x31149B1 VA: 0x31148B0
	|-List<TutorialUnlockFlagData>.FindIndex
	|
	|-RVA: 0x3117970 Offset: 0x3117A71 VA: 0x3117970
	|-List<UIMainManagerAttachObject.AttachSet>.FindIndex
	|
	|-RVA: 0x311AC40 Offset: 0x311AD41 VA: 0x311AC40
	|-List<CapEdge>.FindIndex
	|
	|-RVA: 0x311DEE0 Offset: 0x311DFE1 VA: 0x311DEE0
	|-List<MeshDataConnectivity.Face>.FindIndex
	|
	|-RVA: 0x3121030 Offset: 0x3121131 VA: 0x3121030
	|-List<MeshFaceConnectivity.EdgeData.SideData>.FindIndex
	|
	|-RVA: 0x31244C0 Offset: 0x31245C1 VA: 0x31244C0
	|-List<MeshFaceConnectivity.EdgeData>.FindIndex
	|
	|-RVA: 0x31277C0 Offset: 0x31278C1 VA: 0x31277C0
	|-List<NavMeshBuildMarkup>.FindIndex
	|
	|-RVA: 0x312ADB0 Offset: 0x312AEB1 VA: 0x312ADB0
	|-List<NavMeshBuildSource>.FindIndex
	|
	|-RVA: 0x312E3C0 Offset: 0x312E4C1 VA: 0x312E3C0
	|-List<ConstraintSource>.FindIndex
	|
	|-RVA: 0x31313C0 Offset: 0x31314C1 VA: 0x31313C0
	|-List<AnimatorClipInfo>.FindIndex
	|
	|-RVA: 0x321CF90 Offset: 0x321D091 VA: 0x321CF90
	|-List<BeforeRenderHelper.OrderBlock>.FindIndex
	|
	|-RVA: 0x3220140 Offset: 0x3220241 VA: 0x3220140
	|-List<BoneWeight>.FindIndex
	|
	|-RVA: 0x32234A0 Offset: 0x32235A1 VA: 0x32234A0
	|-List<Bounds>.FindIndex
	|
	|-RVA: 0x32267F0 Offset: 0x32268F1 VA: 0x32267F0
	|-List<BoundsInt>.FindIndex
	|
	|-RVA: 0x32299B0 Offset: 0x3229AB1 VA: 0x32299B0
	|-List<Color32>.FindIndex
	|
	|-RVA: 0x322C9C0 Offset: 0x322CAC1 VA: 0x322C9C0
	|-List<Color>.FindIndex
	|
	|-RVA: 0x322FFF0 Offset: 0x32300F1 VA: 0x322FFF0
	|-List<CombineInstance>.FindIndex
	|
	|-RVA: 0x3233A60 Offset: 0x3233B61 VA: 0x3233A60
	|-List<RaycastResult>.FindIndex
	|
	|-RVA: 0x3236EF0 Offset: 0x3236FF1 VA: 0x3236EF0
	|-List<GradientAlphaKey>.FindIndex
	|
	|-RVA: 0x323A080 Offset: 0x323A181 VA: 0x323A080
	|-List<GradientColorKey>.FindIndex
	|
	|-RVA: 0x323D4C0 Offset: 0x323D5C1 VA: 0x323D4C0
	|-List<Keyframe>.FindIndex
	|
	|-RVA: 0x3240730 Offset: 0x3240831 VA: 0x3240730
	|-List<LayerMask>.FindIndex
	|
	|-RVA: 0x3243A50 Offset: 0x3243B51 VA: 0x3243A50
	|-List<Matrix4x4>.FindIndex
	|
	|-RVA: 0x3246FF0 Offset: 0x32470F1 VA: 0x3246FF0
	|-List<ParticleSystem.Particle>.FindIndex
	|
	|-RVA: 0x324A280 Offset: 0x324A381 VA: 0x324A280
	|-List<Playable>.FindIndex
	|
	|-RVA: 0x324D430 Offset: 0x324D531 VA: 0x324D430
	|-List<PlayableBinding>.FindIndex
	|
	|-RVA: 0x3250640 Offset: 0x3250741 VA: 0x3250640
	|-List<PlayableGraph>.FindIndex
	|
	|-RVA: 0x3253630 Offset: 0x3253731 VA: 0x3253630
	|-List<Edge>.FindIndex
	|
	|-RVA: 0x3256630 Offset: 0x3256731 VA: 0x3256630
	|-List<Quaternion>.FindIndex
	|
	|-RVA: 0x3259660 Offset: 0x3259761 VA: 0x3259660
	|-List<RangeInt>.FindIndex
	|
	|-RVA: 0x325C8D0 Offset: 0x325C9D1 VA: 0x325C8D0
	|-List<RaycastHit2D>.FindIndex
	|
	|-RVA: 0x325FED0 Offset: 0x325FFD1 VA: 0x325FED0
	|-List<RaycastHit>.FindIndex
	|
	|-RVA: 0x33C1A70 Offset: 0x33C1B71 VA: 0x33C1A70
	|-List<Rect>.FindIndex
	|
	|-RVA: 0x33C4AC0 Offset: 0x33C4BC1 VA: 0x33C4AC0
	|-List<RectInt>.FindIndex
	|
	|-RVA: 0x33C7AF0 Offset: 0x33C7BF1 VA: 0x33C7AF0
	|-List<ReflectionProbeBlendInfo>.FindIndex
	|
	|-RVA: 0x33CB1A0 Offset: 0x33CB2A1 VA: 0x33CB1A0
	|-List<SphericalHarmonicsL2>.FindIndex
	|
	|-RVA: 0x33CE870 Offset: 0x33CE971 VA: 0x33CE870
	|-List<VertexAttributeDescriptor>.FindIndex
	|
	|-RVA: 0x33D1A20 Offset: 0x33D1B21 VA: 0x33D1A20
	|-List<AsyncOperationHandle>.FindIndex
	|
	|-RVA: 0x33D4DC0 Offset: 0x33D4EC1 VA: 0x33D4DC0
	|-List<AsyncOperationHandle<SceneInstance>>.FindIndex
	|
	|-RVA: 0x33D8280 Offset: 0x33D8381 VA: 0x33D8280
	|-List<DiagnosticEvent>.FindIndex
	|
	|-RVA: 0x33DB720 Offset: 0x33DB821 VA: 0x33DB720
	|-List<DelayedActionManager.DelegateInfo>.FindIndex
	|
	|-RVA: 0x33DEBF0 Offset: 0x33DECF1 VA: 0x33DEBF0
	|-List<ObjectInitializationData>.FindIndex
	|
	|-RVA: 0x31B9E40 Offset: 0x31B9F41 VA: 0x31B9E40
	|-List<GlyphRect>.FindIndex
	|
	|-RVA: 0x31BD0B0 Offset: 0x31BD1B1 VA: 0x31BD0B0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.FindIndex
	|
	|-RVA: 0x31C04B0 Offset: 0x31C05B1 VA: 0x31C04B0
	|-List<IntervalTreeNode>.FindIndex
	|
	|-RVA: 0x31C3820 Offset: 0x31C3921 VA: 0x31C3820
	|-List<IntervalTree.Entry<object>>.FindIndex
	|
	|-RVA: 0x31C6BC0 Offset: 0x31C6CC1 VA: 0x31C6BC0
	|-List<TimeNotificationBehaviour.NotificationEntry>.FindIndex
	|
	|-RVA: 0x31C9DE0 Offset: 0x31C9EE1 VA: 0x31C9DE0
	|-List<UICharInfo>.FindIndex
	|
	|-RVA: 0x31CCE60 Offset: 0x31CCF61 VA: 0x31CCE60
	|-List<FocusController.FocusedElement>.FindIndex
	|
	|-RVA: 0x31CFE80 Offset: 0x31CFF81 VA: 0x31CFE80
	|-List<UILineInfo>.FindIndex
	|
	|-RVA: 0x31D3390 Offset: 0x31D3491 VA: 0x31D3390
	|-List<UIVertex>.FindIndex
	|
	|-RVA: 0x31D6A30 Offset: 0x31D6B31 VA: 0x31D6A30
	|-List<UnitySynchronizationContext.WorkRequest>.FindIndex
	|
	|-RVA: 0x31D9C40 Offset: 0x31D9D41 VA: 0x31D9C40
	|-List<Vector2>.FindIndex
	|
	|-RVA: 0x2CE2840 Offset: 0x2CE2941 VA: 0x2CE2840
	|-List<Vector2Int>.FindIndex
	|
	|-RVA: 0x2CE5830 Offset: 0x2CE5931 VA: 0x2CE5830
	|-List<Vector3>.FindIndex
	|
	|-RVA: 0x2CE88B0 Offset: 0x2CE89B1 VA: 0x2CE88B0
	|-List<Vector3Int>.FindIndex
	|
	|-RVA: 0x2CEB980 Offset: 0x2CEBA81 VA: 0x2CEB980
	|-List<Vector4>.FindIndex
	|
	|-RVA: 0x2CEF090 Offset: 0x2CEF191 VA: 0x2CEF090
	|-List<WarpPoints.WarpPoint>.FindIndex
	|
	|-RVA: 0x2CF26C0 Offset: 0x2CF27C1 VA: 0x2CF26C0
	|-List<YieldItemParam>.FindIndex
	|
	|-RVA: 0x2CF5830 Offset: 0x2CF5931 VA: 0x2CF5830
	|-List<stCommand_t>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248DA80 Offset: 0x248DB81 VA: 0x248DA80
	|-List<AS_ToolController.ChargeInfo>.FindIndex
	|
	|-RVA: 0x2491340 Offset: 0x2491441 VA: 0x2491340
	|-List<BuildItemData>.FindIndex
	|
	|-RVA: 0x3156FA0 Offset: 0x31570A1 VA: 0x3156FA0
	|-List<ButtonLinker.LinkObject>.FindIndex
	|
	|-RVA: 0x3159FD0 Offset: 0x315A0D1 VA: 0x3159FD0
	|-List<CharaCallTable.BustupTable>.FindIndex
	|
	|-RVA: 0x315D000 Offset: 0x315D101 VA: 0x315D000
	|-List<CharaCallTable.CharaFaceIconTable>.FindIndex
	|
	|-RVA: 0x31600C0 Offset: 0x31601C1 VA: 0x31600C0
	|-List<CameraState.CustomBlendable>.FindIndex
	|
	|-RVA: 0x31630C0 Offset: 0x31631C1 VA: 0x31630C0
	|-List<CinemachineClearShot.Pair>.FindIndex
	|
	|-RVA: 0x3166070 Offset: 0x3166171 VA: 0x3166070
	|-List<CinemachineStateDrivenCamera.HashPair>.FindIndex
	|
	|-RVA: 0x31692A0 Offset: 0x31693A1 VA: 0x31692A0
	|-List<TargetPositionCache.CacheCurve.Item>.FindIndex
	|
	|-RVA: 0x316C7C0 Offset: 0x316C8C1 VA: 0x316C7C0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.FindIndex
	|
	|-RVA: 0x316FD20 Offset: 0x316FE21 VA: 0x316FD20
	|-List<CropDataTable>.FindIndex
	|
	|-RVA: 0x3173030 Offset: 0x3173131 VA: 0x3173030
	|-List<DropItemParam>.FindIndex
	|
	|-RVA: 0x31761A0 Offset: 0x31762A1 VA: 0x31761A0
	|-List<ErosionBrush.UndoStep>.FindIndex
	|
	|-RVA: 0x31DCE30 Offset: 0x31DCF31 VA: 0x31DCE30
	|-List<EventCheckId>.FindIndex
	|
	|-RVA: 0x31E0050 Offset: 0x31E0151 VA: 0x31E0050
	|-List<EventFlagProgressData>.FindIndex
	|
	|-RVA: 0x31E30A0 Offset: 0x31E31A1 VA: 0x31E30A0
	|-List<FesNpcScoreData>.FindIndex
	|
	|-RVA: 0x31E6370 Offset: 0x31E6471 VA: 0x31E6370
	|-List<MiningPointSaveData>.FindIndex
	|
	|-RVA: 0x31E98B0 Offset: 0x31E99B1 VA: 0x31E98B0
	|-List<MonsterHutSaveData>.FindIndex
	|
	|-RVA: 0x31ECB70 Offset: 0x31ECC71 VA: 0x31ECB70
	|-List<MoviePlayer.SUBTITLEDATA>.FindIndex
	|
	|-RVA: 0x31EFEE0 Offset: 0x31EFFE1 VA: 0x31EFEE0
	|-List<NPCActionData>.FindIndex
	|
	|-RVA: 0x31F3400 Offset: 0x31F3501 VA: 0x31F3400
	|-List<NpcPlaceSchedule>.FindIndex
	|
	|-RVA: 0x31F6620 Offset: 0x31F6721 VA: 0x31F6620
	|-List<OrderLotterySaveParameter>.FindIndex
	|
	|-RVA: 0x31F9860 Offset: 0x31F9961 VA: 0x31F9860
	|-List<OrderSaveParameter>.FindIndex
	|
	|-RVA: 0x31FCA90 Offset: 0x31FCB91 VA: 0x31FCA90
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.FindIndex
	|
	|-RVA: 0x330BD00 Offset: 0x330BE01 VA: 0x330BD00
	|-List<ShopCatalogPage>.FindIndex
	|
	|-RVA: 0x330EFE0 Offset: 0x330F0E1 VA: 0x330EFE0
	|-List<ShopNpcTalk>.FindIndex
	|
	|-RVA: 0x3312300 Offset: 0x3312401 VA: 0x3312300
	|-List<SubtitleDataTable.Data>.FindIndex
	|
	|-RVA: 0x3315390 Offset: 0x3315491 VA: 0x3315390
	|-List<SubtitleDataTable.DataList>.FindIndex
	|
	|-RVA: 0x3318390 Offset: 0x3318491 VA: 0x3318390
	|-List<SubtitleHudDataTable.Data>.FindIndex
	|
	|-RVA: 0x331B5D0 Offset: 0x331B6D1 VA: 0x331B5D0
	|-List<SRMonoBehaviourEx.FieldInfo>.FindIndex
	|
	|-RVA: 0x331E960 Offset: 0x331EA61 VA: 0x331E960
	|-List<Schedule>.FindIndex
	|
	|-RVA: 0x3321F70 Offset: 0x3322071 VA: 0x3321F70
	|-List<CurveSample>.FindIndex
	|
	|-RVA: 0x33253E0 Offset: 0x33254E1 VA: 0x33253E0
	|-List<bool>.FindIndex
	|
	|-RVA: 0x33283C0 Offset: 0x33284C1 VA: 0x33283C0
	|-List<byte>.FindIndex
	|
	|-RVA: 0x332B380 Offset: 0x332B481 VA: 0x332B380
	|-List<char>.FindIndex
	|
	|-RVA: 0x3359410 Offset: 0x3359511 VA: 0x3359410
	|-List<KeyValuePair<DateTime, object>>.FindIndex
	|
	|-RVA: 0x335C460 Offset: 0x335C561 VA: 0x335C460
	|-List<KeyValuePair<int, object>>.FindIndex
	|
	|-RVA: 0x335F4B0 Offset: 0x335F5B1 VA: 0x335F4B0
	|-List<KeyValuePair<object, object>>.FindIndex
	|
	|-RVA: 0x33624B0 Offset: 0x33625B1 VA: 0x33624B0
	|-List<DateTime>.FindIndex
	|
	|-RVA: 0x3365460 Offset: 0x3365561 VA: 0x3365460
	|-List<double>.FindIndex
	|
	|-RVA: 0x3368410 Offset: 0x3368511 VA: 0x3368410
	|-List<short>.FindIndex
	|
	|-RVA: 0x336B3C0 Offset: 0x336B4C1 VA: 0x336B3C0
	|-List<int>.FindIndex
	|
	|-RVA: 0x336E370 Offset: 0x336E471 VA: 0x336E370
	|-List<Int32Enum>.FindIndex
	|
	|-RVA: 0x3371320 Offset: 0x3371421 VA: 0x3371320
	|-List<long>.FindIndex
	|
	|-RVA: 0x3374310 Offset: 0x3374411 VA: 0x3374310
	|-List<InterpretedFrameInfo>.FindIndex
	|
	|-RVA: 0x3377380 Offset: 0x3377481 VA: 0x3377380
	|-List<Nullable<Int32Enum>>.FindIndex
	|
	|-RVA: 0x34062E0 Offset: 0x34063E1 VA: 0x34062E0
	|-List<Nullable<Bounds>>.FindIndex
	|
	|-RVA: 0x34098A0 Offset: 0x34099A1 VA: 0x34098A0
	|-List<Nullable<BoundsInt>>.FindIndex
	|
	|-RVA: 0x340CB90 Offset: 0x340CC91 VA: 0x340CB90
	|-List<Nullable<Color32>>.FindIndex
	|
	|-RVA: 0x340FD90 Offset: 0x340FE91 VA: 0x340FD90
	|-List<Nullable<Color>>.FindIndex
	|
	|-RVA: 0x3413040 Offset: 0x3413141 VA: 0x3413040
	|-List<Nullable<GradientAlphaKey>>.FindIndex
	|
	|-RVA: 0x3416310 Offset: 0x3416411 VA: 0x3416310
	|-List<Nullable<GradientColorKey>>.FindIndex
	|
	|-RVA: 0x3419760 Offset: 0x3419861 VA: 0x3419760
	|-List<Nullable<Keyframe>>.FindIndex
	|
	|-RVA: 0x341C9C0 Offset: 0x341CAC1 VA: 0x341C9C0
	|-List<Nullable<LayerMask>>.FindIndex
	|
	|-RVA: 0x341FEF0 Offset: 0x341FFF1 VA: 0x341FEF0
	|-List<Nullable<Matrix4x4>>.FindIndex
	|
	|-RVA: 0x3423600 Offset: 0x3423701 VA: 0x3423600
	|-List<Nullable<Quaternion>>.FindIndex
	|
	|-RVA: 0x3263320 Offset: 0x3263421 VA: 0x3263320
	|-List<Nullable<RangeInt>>.FindIndex
	|
	|-RVA: 0x32665F0 Offset: 0x32666F1 VA: 0x32665F0
	|-List<Nullable<Rect>>.FindIndex
	|
	|-RVA: 0x3269A50 Offset: 0x3269B51 VA: 0x3269A50
	|-List<Nullable<RectInt>>.FindIndex
	|
	|-RVA: 0x326CD00 Offset: 0x326CE01 VA: 0x326CD00
	|-List<Nullable<Vector2>>.FindIndex
	|
	|-RVA: 0x326FE20 Offset: 0x326FF21 VA: 0x326FE20
	|-List<Nullable<Vector2Int>>.FindIndex
	|
	|-RVA: 0x3272F20 Offset: 0x3273021 VA: 0x3272F20
	|-List<Nullable<Vector3>>.FindIndex
	|
	|-RVA: 0x3275F90 Offset: 0x3276091 VA: 0x3275F90
	|-List<Nullable<Vector3Int>>.FindIndex
	|
	|-RVA: 0x32791D0 Offset: 0x32792D1 VA: 0x32791D0
	|-List<Nullable<Vector4>>.FindIndex
	|
	|-RVA: 0x327C360 Offset: 0x327C461 VA: 0x327C360
	|-List<object>.FindIndex
	|
	|-RVA: 0x327F300 Offset: 0x327F401 VA: 0x327F300
	|-List<sbyte>.FindIndex
	|
	|-RVA: 0x32822C0 Offset: 0x32823C1 VA: 0x32822C0
	|-List<float>.FindIndex
	|
	|-RVA: 0x32A9520 Offset: 0x32A9621 VA: 0x32A9520
	|-List<ushort>.FindIndex
	|
	|-RVA: 0x32AC4D0 Offset: 0x32AC5D1 VA: 0x32AC4D0
	|-List<uint>.FindIndex
	|
	|-RVA: 0x32AF480 Offset: 0x32AF581 VA: 0x32AF480
	|-List<ulong>.FindIndex
	|
	|-RVA: 0x32B2430 Offset: 0x32B2531 VA: 0x32B2430
	|-List<ValueTuple<bool, Int32Enum>>.FindIndex
	|
	|-RVA: 0x32B53E0 Offset: 0x32B54E1 VA: 0x32B53E0
	|-List<ValueTuple<Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x32B83D0 Offset: 0x32B84D1 VA: 0x32B83D0
	|-List<ValueTuple<Int32Enum, object>>.FindIndex
	|
	|-RVA: 0x32BB420 Offset: 0x32BB521 VA: 0x32BB420
	|-List<ValueTuple<object, Int32Enum>>.FindIndex
	|
	|-RVA: 0x32BE460 Offset: 0x32BE561 VA: 0x32BE460
	|-List<ValueTuple<object, object>>.FindIndex
	|
	|-RVA: 0x32C14A0 Offset: 0x32C15A1 VA: 0x32C14A0
	|-List<ValueTuple<object, float>>.FindIndex
	|
	|-RVA: 0x32C44E0 Offset: 0x32C45E1 VA: 0x32C44E0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.FindIndex
	|
	|-RVA: 0x32C78E0 Offset: 0x32C79E1 VA: 0x32C78E0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.FindIndex
	|
	|-RVA: 0x3111540 Offset: 0x3111641 VA: 0x3111540
	|-List<TexturePacker_JsonArray.Frame>.FindIndex
	|
	|-RVA: 0x31148F0 Offset: 0x31149F1 VA: 0x31148F0
	|-List<TutorialUnlockFlagData>.FindIndex
	|
	|-RVA: 0x31179B0 Offset: 0x3117AB1 VA: 0x31179B0
	|-List<UIMainManagerAttachObject.AttachSet>.FindIndex
	|
	|-RVA: 0x311AC80 Offset: 0x311AD81 VA: 0x311AC80
	|-List<CapEdge>.FindIndex
	|
	|-RVA: 0x311DF20 Offset: 0x311E021 VA: 0x311DF20
	|-List<MeshDataConnectivity.Face>.FindIndex
	|
	|-RVA: 0x3121070 Offset: 0x3121171 VA: 0x3121070
	|-List<MeshFaceConnectivity.EdgeData.SideData>.FindIndex
	|
	|-RVA: 0x3124500 Offset: 0x3124601 VA: 0x3124500
	|-List<MeshFaceConnectivity.EdgeData>.FindIndex
	|
	|-RVA: 0x3127800 Offset: 0x3127901 VA: 0x3127800
	|-List<NavMeshBuildMarkup>.FindIndex
	|
	|-RVA: 0x312ADF0 Offset: 0x312AEF1 VA: 0x312ADF0
	|-List<NavMeshBuildSource>.FindIndex
	|
	|-RVA: 0x312E400 Offset: 0x312E501 VA: 0x312E400
	|-List<ConstraintSource>.FindIndex
	|
	|-RVA: 0x3131400 Offset: 0x3131501 VA: 0x3131400
	|-List<AnimatorClipInfo>.FindIndex
	|
	|-RVA: 0x321CFD0 Offset: 0x321D0D1 VA: 0x321CFD0
	|-List<BeforeRenderHelper.OrderBlock>.FindIndex
	|
	|-RVA: 0x3220180 Offset: 0x3220281 VA: 0x3220180
	|-List<BoneWeight>.FindIndex
	|
	|-RVA: 0x32234E0 Offset: 0x32235E1 VA: 0x32234E0
	|-List<Bounds>.FindIndex
	|
	|-RVA: 0x3226830 Offset: 0x3226931 VA: 0x3226830
	|-List<BoundsInt>.FindIndex
	|
	|-RVA: 0x32299F0 Offset: 0x3229AF1 VA: 0x32299F0
	|-List<Color32>.FindIndex
	|
	|-RVA: 0x322CA00 Offset: 0x322CB01 VA: 0x322CA00
	|-List<Color>.FindIndex
	|
	|-RVA: 0x3230030 Offset: 0x3230131 VA: 0x3230030
	|-List<CombineInstance>.FindIndex
	|
	|-RVA: 0x3233AA0 Offset: 0x3233BA1 VA: 0x3233AA0
	|-List<RaycastResult>.FindIndex
	|
	|-RVA: 0x3236F30 Offset: 0x3237031 VA: 0x3236F30
	|-List<GradientAlphaKey>.FindIndex
	|
	|-RVA: 0x323A0C0 Offset: 0x323A1C1 VA: 0x323A0C0
	|-List<GradientColorKey>.FindIndex
	|
	|-RVA: 0x323D500 Offset: 0x323D601 VA: 0x323D500
	|-List<Keyframe>.FindIndex
	|
	|-RVA: 0x3240770 Offset: 0x3240871 VA: 0x3240770
	|-List<LayerMask>.FindIndex
	|
	|-RVA: 0x3243A90 Offset: 0x3243B91 VA: 0x3243A90
	|-List<Matrix4x4>.FindIndex
	|
	|-RVA: 0x3247030 Offset: 0x3247131 VA: 0x3247030
	|-List<ParticleSystem.Particle>.FindIndex
	|
	|-RVA: 0x324A2C0 Offset: 0x324A3C1 VA: 0x324A2C0
	|-List<Playable>.FindIndex
	|
	|-RVA: 0x324D470 Offset: 0x324D571 VA: 0x324D470
	|-List<PlayableBinding>.FindIndex
	|
	|-RVA: 0x3250680 Offset: 0x3250781 VA: 0x3250680
	|-List<PlayableGraph>.FindIndex
	|
	|-RVA: 0x3253670 Offset: 0x3253771 VA: 0x3253670
	|-List<Edge>.FindIndex
	|
	|-RVA: 0x3256670 Offset: 0x3256771 VA: 0x3256670
	|-List<Quaternion>.FindIndex
	|
	|-RVA: 0x32596A0 Offset: 0x32597A1 VA: 0x32596A0
	|-List<RangeInt>.FindIndex
	|
	|-RVA: 0x325C910 Offset: 0x325CA11 VA: 0x325C910
	|-List<RaycastHit2D>.FindIndex
	|
	|-RVA: 0x325FF10 Offset: 0x3260011 VA: 0x325FF10
	|-List<RaycastHit>.FindIndex
	|
	|-RVA: 0x33C1AB0 Offset: 0x33C1BB1 VA: 0x33C1AB0
	|-List<Rect>.FindIndex
	|
	|-RVA: 0x33C4B00 Offset: 0x33C4C01 VA: 0x33C4B00
	|-List<RectInt>.FindIndex
	|
	|-RVA: 0x33C7B30 Offset: 0x33C7C31 VA: 0x33C7B30
	|-List<ReflectionProbeBlendInfo>.FindIndex
	|
	|-RVA: 0x33CB1E0 Offset: 0x33CB2E1 VA: 0x33CB1E0
	|-List<SphericalHarmonicsL2>.FindIndex
	|
	|-RVA: 0x33CE8B0 Offset: 0x33CE9B1 VA: 0x33CE8B0
	|-List<VertexAttributeDescriptor>.FindIndex
	|
	|-RVA: 0x33D1A60 Offset: 0x33D1B61 VA: 0x33D1A60
	|-List<AsyncOperationHandle>.FindIndex
	|
	|-RVA: 0x33D4E00 Offset: 0x33D4F01 VA: 0x33D4E00
	|-List<AsyncOperationHandle<SceneInstance>>.FindIndex
	|
	|-RVA: 0x33D82C0 Offset: 0x33D83C1 VA: 0x33D82C0
	|-List<DiagnosticEvent>.FindIndex
	|
	|-RVA: 0x33DB760 Offset: 0x33DB861 VA: 0x33DB760
	|-List<DelayedActionManager.DelegateInfo>.FindIndex
	|
	|-RVA: 0x33DEC30 Offset: 0x33DED31 VA: 0x33DEC30
	|-List<ObjectInitializationData>.FindIndex
	|
	|-RVA: 0x31B9E80 Offset: 0x31B9F81 VA: 0x31B9E80
	|-List<GlyphRect>.FindIndex
	|
	|-RVA: 0x31BD0F0 Offset: 0x31BD1F1 VA: 0x31BD0F0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.FindIndex
	|
	|-RVA: 0x31C04F0 Offset: 0x31C05F1 VA: 0x31C04F0
	|-List<IntervalTreeNode>.FindIndex
	|
	|-RVA: 0x31C3860 Offset: 0x31C3961 VA: 0x31C3860
	|-List<IntervalTree.Entry<object>>.FindIndex
	|
	|-RVA: 0x31C6C00 Offset: 0x31C6D01 VA: 0x31C6C00
	|-List<TimeNotificationBehaviour.NotificationEntry>.FindIndex
	|
	|-RVA: 0x31C9E20 Offset: 0x31C9F21 VA: 0x31C9E20
	|-List<UICharInfo>.FindIndex
	|
	|-RVA: 0x31CCEA0 Offset: 0x31CCFA1 VA: 0x31CCEA0
	|-List<FocusController.FocusedElement>.FindIndex
	|
	|-RVA: 0x31CFEC0 Offset: 0x31CFFC1 VA: 0x31CFEC0
	|-List<UILineInfo>.FindIndex
	|
	|-RVA: 0x31D33D0 Offset: 0x31D34D1 VA: 0x31D33D0
	|-List<UIVertex>.FindIndex
	|
	|-RVA: 0x31D6A70 Offset: 0x31D6B71 VA: 0x31D6A70
	|-List<UnitySynchronizationContext.WorkRequest>.FindIndex
	|
	|-RVA: 0x31D9C80 Offset: 0x31D9D81 VA: 0x31D9C80
	|-List<Vector2>.FindIndex
	|
	|-RVA: 0x2CE2880 Offset: 0x2CE2981 VA: 0x2CE2880
	|-List<Vector2Int>.FindIndex
	|
	|-RVA: 0x2CE5870 Offset: 0x2CE5971 VA: 0x2CE5870
	|-List<Vector3>.FindIndex
	|
	|-RVA: 0x2CE88F0 Offset: 0x2CE89F1 VA: 0x2CE88F0
	|-List<Vector3Int>.FindIndex
	|
	|-RVA: 0x2CEB9C0 Offset: 0x2CEBAC1 VA: 0x2CEB9C0
	|-List<Vector4>.FindIndex
	|
	|-RVA: 0x2CEF0D0 Offset: 0x2CEF1D1 VA: 0x2CEF0D0
	|-List<WarpPoints.WarpPoint>.FindIndex
	|
	|-RVA: 0x2CF2700 Offset: 0x2CF2801 VA: 0x2CF2700
	|-List<YieldItemParam>.FindIndex
	|
	|-RVA: 0x2CF5870 Offset: 0x2CF5971 VA: 0x2CF5870
	|-List<stCommand_t>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public List.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327C490 Offset: 0x327C591 VA: 0x327C490
	|-List<AIInput>.GetEnumerator
	|-List<AS_MagicController>.GetEnumerator
	|-List<ActionBehaviorCommandData>.GetEnumerator
	|-List<ActionBehaviorCommandInformation>.GetEnumerator
	|-List<Actor>.GetEnumerator
	|-List<ActorController>.GetEnumerator
	|-List<ActorData>.GetEnumerator
	|-List<AdvShowOneImage.AdvSpriteLoader>.GetEnumerator
	|-List<AdvShowOneImage>.GetEnumerator
	|-List<AttackCollider>.GetEnumerator
	|-List<AudmuraCrystal>.GetEnumerator
	|-List<AutomaticLOD.LODLevelData>.GetEnumerator
	|-List<AutomaticLOD>.GetEnumerator
	|-List<BaffamoDodgeManager.BaffamoMonster>.GetEnumerator
	|-List<BgmList>.GetEnumerator
	|-List<BitBase>.GetEnumerator
	|-List<BodyPartsCollision>.GetEnumerator
	|-List<BulletBase>.GetEnumerator
	|-List<BulletColliderBase>.GetEnumerator
	|-List<BulletSubModule>.GetEnumerator
	|-List<ButtonLinker>.GetEnumerator
	|-List<CameraManager.CameraControllerPair>.GetEnumerator
	|-List<CerberusController.DogParam>.GetEnumerator
	|-List<Character>.GetEnumerator
	|-List<CharacterBase>.GetEnumerator
	|-List<CheerVoiceData>.GetEnumerator
	|-List<ChildData>.GetEnumerator
	|-List<CinemachineCollider.VcamExtraState>.GetEnumerator
	|-List<ColliderStreamer>.GetEnumerator
	|-List<CombinedMesh.MaterialMeshInfo>.GetEnumerator
	|-List<CombinedMesh.ObjectInfo>.GetEnumerator
	|-List<CursorEvent>.GetEnumerator
	|-List<DLCPair>.GetEnumerator
	|-List<DeadtreeController.ChestnutController>.GetEnumerator
	|-List<EmotionController>.GetEnumerator
	|-List<EnemyPatrolData.PatrolParameter.PatrollBehaviorTypeKeyAndValue>.GetEnumerator
	|-List<EraseObject>.GetEnumerator
	|-List<EventFlagManager.RequestDisableEventPointData>.GetEnumerator
	|-List<EventPointData>.GetEnumerator
	|-List<EventStartData>.GetEnumerator
	|-List<EventUnlockFlagData>.GetEnumerator
	|-List<CellController>.GetEnumerator
	|-List<FarmCropData>.GetEnumerator
	|-List<FesNpcScore>.GetEnumerator
	|-List<ObjectLoader>.GetEnumerator
	|-List<FishSwim>.GetEnumerator
	|-List<FocusObjectName.BorderElement>.GetEnumerator
	|-List<FracturedChunk.AdjacencyInfo>.GetEnumerator
	|-List<FracturedChunk>.GetEnumerator
	|-List<FriendMonsterManager.FarmInActorData>.GetEnumerator
	|-List<FriendMonsterStatusData>.GetEnumerator
	|-List<BoolKeyframeGroup>.GetEnumerator
	|-List<ColorKeyframe>.GetEnumerator
	|-List<ColorKeyframeGroup>.GetEnumerator
	|-List<NumberKeyframe>.GetEnumerator
	|-List<NumberKeyframeGroup>.GetEnumerator
	|-List<ProfileGroupDefinition>.GetEnumerator
	|-List<TextureKeyframeGroup>.GetEnumerator
	|-List<GateSeasonInfomation>.GetEnumerator
	|-List<GateTimeZoneMonsterInfomation>.GetEnumerator
	|-List<GroupSoundData>.GetEnumerator
	|-List<HUDDualWorkSelectInput.DualSelect>.GetEnumerator
	|-List<HasibirokouSonicWind>.GetEnumerator
	|-List<HateController.HateParameter>.GetEnumerator
	|-List<HumanData>.GetEnumerator
	|-List<HumanDataArray>.GetEnumerator
	|-List<InosisiController.ThornsController>.GetEnumerator
	|-List<ItemDataLinker>.GetEnumerator
	|-List<ItemEquip>.GetEnumerator
	|-List<FurnitureSaveData>.GetEnumerator
	|-List<PlayerItemFurniture2>.GetEnumerator
	|-List<ItemMoveToBasket>.GetEnumerator
	|-List<ItemWeightData>.GetEnumerator
	|-List<KrakenStickController>.GetEnumerator
	|-List<LastBossBone>.GetEnumerator
	|-List<AssetHandle>.GetEnumerator
	|-List<AssetInfo>.GetEnumerator
	|-List<MainEventFlagProgressData>.GetEnumerator
	|-List<MiningPair>.GetEnumerator
	|-List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter>.GetEnumerator
	|-List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>.GetEnumerator
	|-List<MonsterActionBehaviorData>.GetEnumerator
	|-List<MonsterActionInformation>.GetEnumerator
	|-List<MonsterAnimatorStateEvent.NormalizeTimeEvent>.GetEnumerator
	|-List<MonsterControllerBase.DropItemDataParameter>.GetEnumerator
	|-List<MonsterControllerBase>.GetEnumerator
	|-List<MonsterModelData>.GetEnumerator
	|-List<MonsterProjectileActionScriptsController>.GetEnumerator
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.GetEnumerator
	|-List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>.GetEnumerator
	|-List<NpcController>.GetEnumerator
	|-List<NpcData>.GetEnumerator
	|-List<NpcLifeCycleDataRecord>.GetEnumerator
	|-List<NpcPatrolPointData>.GetEnumerator
	|-List<NpcSaveParameter>.GetEnumerator
	|-List<NpcStatusData>.GetEnumerator
	|-List<NpcTimeAction>.GetEnumerator
	|-List<ObjectPooler.Pool>.GetEnumerator
	|-List<OnGroundItem>.GetEnumerator
	|-List<OrderData>.GetEnumerator
	|-List<OrderHUDBlock>.GetEnumerator
	|-List<OrderMasterData>.GetEnumerator
	|-List<PartnerManager.NPCChangeBaseParameter>.GetEnumerator
	|-List<PartnerMonsterBehaviorController>.GetEnumerator
	|-List<PatrolPointMotionData>.GetEnumerator
	|-List<PetNpcPetData>.GetEnumerator
	|-List<PlayerCheerVoiceData>.GetEnumerator
	|-List<Contour>.GetEnumerator
	|-List<DTSweepConstraint>.GetEnumerator
	|-List<DelaunayTriangle>.GetEnumerator
	|-List<EdgeIntersectInfo>.GetEnumerator
	|-List<Point2D>.GetEnumerator
	|-List<Point2DList>.GetEnumerator
	|-List<Polygon>.GetEnumerator
	|-List<PolygonPoint>.GetEnumerator
	|-List<TriangulationConstraint>.GetEnumerator
	|-List<TriangulationPoint>.GetEnumerator
	|-List<PreloadHandle>.GetEnumerator
	|-List<PadBindData>.GetEnumerator
	|-List<FishShipmentRecords>.GetEnumerator
	|-List<ShipmentItemRecords>.GetEnumerator
	|-List<RF5Streamer>.GetEnumerator
	|-List<SubtitleHandler>.GetEnumerator
	|-List<ButtonHintBlock>.GetEnumerator
	|-List<SEController>.GetEnumerator
	|-List<RandomData>.GetEnumerator
	|-List<RecipeDataDispBlock>.GetEnumerator
	|-List<RecipeDataTableArray.RecipeDataTable>.GetEnumerator
	|-List<MP4FileProcessing.Chunk>.GetEnumerator
	|-List<ReviatanIcePillar>.GetEnumerator
	|-List<OptionDefinition>.GetEnumerator
	|-List<OptionsTabController.CategoryInstance>.GetEnumerator
	|-List<SRServiceManager.ServiceStub>.GetEnumerator
	|-List<TimelineToActionScriptExpoter.ActionScriptData>.GetEnumerator
	|-List<ScenarioTalkData>.GetEnumerator
	|-List<SceneSplit>.GetEnumerator
	|-List<SceneTransitionManager.GameObjectEnabled>.GetEnumerator
	|-List<SearchCharacterController.SearchParameter>.GetEnumerator
	|-List<SnowmanManager.Mocomoco>.GetEnumerator
	|-List<CubicBezierCurve>.GetEnumerator
	|-List<ExtrusionSegment.Vertex>.GetEnumerator
	|-List<MeshVertex>.GetEnumerator
	|-List<SplineNode>.GetEnumerator
	|-List<TransformedMesh>.GetEnumerator
	|-List<SubEventData>.GetEnumerator
	|-List<SubEventMasterDataBase>.GetEnumerator
	|-List<List<FarmCropData>>.GetEnumerator
	|-List<List<PolygonPoint>>.GetEnumerator
	|-List<BranchLabel>.GetEnumerator
	|-List<ByRefUpdater>.GetEnumerator
	|-List<LabelScopeInfo>.GetEnumerator
	|-List<IPAddress>.GetEnumerator
	|-List<MonoChunkStream.Chunk>.GetEnumerator
	|-List<WebConnection>.GetEnumerator
	|-List<WebConnectionGroup>.GetEnumerator
	|-List<Assembly>.GetEnumerator
	|-List<X509CertificateImpl>.GetEnumerator
	|-List<string>.GetEnumerator
	|-List<string[]>.GetEnumerator
	|-List<Thread>.GetEnumerator
	|-List<Type>.GetEnumerator
	|-List<TimeManager.JustTimerData>.GetEnumerator
	|-List<ToolInteractionInterface>.GetEnumerator
	|-List<UIButtonLinkerInScrollBox>.GetEnumerator
	|-List<UIFadeOnOffAnimate.ImageGroup>.GetEnumerator
	|-List<UIItemSlot>.GetEnumerator
	|-List<DynamicsSetup.ParseMessage>.GetEnumerator
	|-List<SpringBone>.GetEnumerator
	|-List<MeshData>.GetEnumerator
	|-List<SupportPlane>.GetEnumerator
	|-List<UltimateRope.RopeBone>.GetEnumerator
	|-List<UltimateRope.RopeNode>.GetEnumerator
	|-List<NavMeshLink>.GetEnumerator
	|-List<NavMeshModifier>.GetEnumerator
	|-List<NavMeshModifierVolume>.GetEnumerator
	|-List<NavMeshObstacle>.GetEnumerator
	|-List<AddressablesImpl.ResourceLocatorInfo>.GetEnumerator
	|-List<Animator>.GetEnumerator
	|-List<Collider>.GetEnumerator
	|-List<PersistentCall>.GetEnumerator
	|-List<IAnimationWindowPreview>.GetEnumerator
	|-List<GUILayoutEntry>.GetEnumerator
	|-List<GameObject>.GetEnumerator
	|-List<GameObject[]>.GetEnumerator
	|-List<ISubsystem>.GetEnumerator
	|-List<ISubsystemDescriptor>.GetEnumerator
	|-List<ISubsystemDescriptorImpl>.GetEnumerator
	|-List<Material>.GetEnumerator
	|-List<ParticleSystem>.GetEnumerator
	|-List<RenderTexture>.GetEnumerator
	|-List<IUpdateReceiver>.GetEnumerator
	|-List<IResourceLocation>.GetEnumerator
	|-List<ResourceManager.InstanceOperation>.GetEnumerator
	|-List<ScriptableObject>.GetEnumerator
	|-List<SkinnedMeshRenderer>.GetEnumerator
	|-List<Terrain>.GetEnumerator
	|-List<RuntimeElement>.GetEnumerator
	|-List<TimelineClip>.GetEnumerator
	|-List<Transform>.GetEnumerator
	|-List<Image>.GetEnumerator
	|-List<EventCallbackFunctorBase>.GetEnumerator
	|-List<IEventDispatchingStrategy>.GetEnumerator
	|-List<Panel>.GetEnumerator
	|-List<VisualElement>.GetEnumerator
	|-List<UpPointData>.GetEnumerator
	|-List<ModifierSpec>.GetEnumerator
	|-List<object>.GetEnumerator
	|-List<MethodInfo>.GetEnumerator
	|-List<ExceptionDispatchInfo>.GetEnumerator
	|-List<IContextProperty>.GetEnumerator
	|-List<IAsyncLocal>.GetEnumerator
	|-List<Task>.GetEnumerator
	|-List<TypeIdentifier>.GetEnumerator
	|
	|-RVA: 0x316FEA0 Offset: 0x316FFA1 VA: 0x316FEA0
	|-List<CropDataTable>.GetEnumerator
	|
	|-RVA: 0x336E4A0 Offset: 0x336E5A1 VA: 0x336E4A0
	|-List<ActorID>.GetEnumerator
	|-List<Alliance>.GetEnumerator
	|-List<GameFlagData>.GetEnumerator
	|-List<NPCID>.GetEnumerator
	|-List<VariationNo>.GetEnumerator
	|-List<ItemID>.GetEnumerator
	|-List<Prefab>.GetEnumerator
	|-List<Texture>.GetEnumerator
	|-List<MonsterModelDataID>.GetEnumerator
	|-List<SoundID>.GetEnumerator
	|-List<UITextDic.DICID>.GetEnumerator
	|-List<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x3173160 Offset: 0x3173261 VA: 0x3173160
	|-List<DropItemParam>.GetEnumerator
	|
	|-RVA: 0x31DCFA0 Offset: 0x31DD0A1 VA: 0x31DCFA0
	|-List<EventCheckId>.GetEnumerator
	|
	|-RVA: 0x31E0190 Offset: 0x31E0291 VA: 0x31E0190
	|-List<EventFlagProgressData>.GetEnumerator
	|
	|-RVA: 0x31E31E0 Offset: 0x31E32E1 VA: 0x31E31E0
	|-List<FesNpcScoreData>.GetEnumerator
	|
	|-RVA: 0x31E64F0 Offset: 0x31E65F1 VA: 0x31E64F0
	|-List<MiningPointSaveData>.GetEnumerator
	|
	|-RVA: 0x31F0080 Offset: 0x31F0181 VA: 0x31F0080
	|-List<NPCActionData>.GetEnumerator
	|
	|-RVA: 0x31F3570 Offset: 0x31F3671 VA: 0x31F3570
	|-List<NpcPlaceSchedule>.GetEnumerator
	|
	|-RVA: 0x31F6780 Offset: 0x31F6881 VA: 0x31F6780
	|-List<OrderLotterySaveParameter>.GetEnumerator
	|
	|-RVA: 0x31F99D0 Offset: 0x31F9AD1 VA: 0x31F99D0
	|-List<OrderSaveParameter>.GetEnumerator
	|
	|-RVA: 0x31FCBD0 Offset: 0x31FCCD1 VA: 0x31FCBD0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetEnumerator
	|
	|-RVA: 0x331EAD0 Offset: 0x331EBD1 VA: 0x331EAD0
	|-List<Schedule>.GetEnumerator
	|
	|-RVA: 0x3322120 Offset: 0x3322221 VA: 0x3322120
	|-List<CurveSample>.GetEnumerator
	|
	|-RVA: 0x335C5A0 Offset: 0x335C6A1 VA: 0x335C5A0
	|-List<KeyValuePair<int, FishSwim>>.GetEnumerator
	|-List<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x336B4F0 Offset: 0x336B5F1 VA: 0x336B4F0
	|-List<int>.GetEnumerator
	|
	|-RVA: 0x32C15E0 Offset: 0x32C16E1 VA: 0x32C15E0
	|-List<ValueTuple<CharacterBase, float>>.GetEnumerator
	|-List<ValueTuple<object, float>>.GetEnumerator
	|
	|-RVA: 0x32B8510 Offset: 0x32B8611 VA: 0x32B8510
	|-List<ValueTuple<SoundID, EnvironmentSoundController>>.GetEnumerator
	|-List<ValueTuple<Int32Enum, object>>.GetEnumerator
	|
	|-RVA: 0x32C7A70 Offset: 0x32C7B71 VA: 0x32C7A70
	|-List<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>>.GetEnumerator
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.GetEnumerator
	|
	|-RVA: 0x3114A50 Offset: 0x3114B51 VA: 0x3114A50
	|-List<TutorialUnlockFlagData>.GetEnumerator
	|
	|-RVA: 0x311E050 Offset: 0x311E151 VA: 0x311E050
	|-List<MeshDataConnectivity.Face>.GetEnumerator
	|
	|-RVA: 0x31211E0 Offset: 0x31212E1 VA: 0x31211E0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.GetEnumerator
	|
	|-RVA: 0x312AFC0 Offset: 0x312B0C1 VA: 0x312AFC0
	|-List<NavMeshBuildSource>.GetEnumerator
	|
	|-RVA: 0x33D1BD0 Offset: 0x33D1CD1 VA: 0x33D1BD0
	|-List<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x33D4F70 Offset: 0x33D5071 VA: 0x33D4F70
	|-List<AsyncOperationHandle<SceneInstance>>.GetEnumerator
	|
	|-RVA: 0x33DEDC0 Offset: 0x33DEEC1 VA: 0x33DEDC0
	|-List<ObjectInitializationData>.GetEnumerator
	|
	|-RVA: 0x2CE59C0 Offset: 0x2CE5AC1 VA: 0x2CE59C0
	|-List<Vector3>.GetEnumerator
	|
	|-RVA: 0x248DBF0 Offset: 0x248DCF1 VA: 0x248DBF0
	|-List<AS_ToolController.ChargeInfo>.GetEnumerator
	|
	|-RVA: 0x2491520 Offset: 0x2491621 VA: 0x2491520
	|-List<BuildItemData>.GetEnumerator
	|
	|-RVA: 0x31570E0 Offset: 0x31571E1 VA: 0x31570E0
	|-List<ButtonLinker.LinkObject>.GetEnumerator
	|
	|-RVA: 0x315A110 Offset: 0x315A211 VA: 0x315A110
	|-List<CharaCallTable.BustupTable>.GetEnumerator
	|
	|-RVA: 0x315D160 Offset: 0x315D261 VA: 0x315D160
	|-List<CharaCallTable.CharaFaceIconTable>.GetEnumerator
	|
	|-RVA: 0x3160200 Offset: 0x3160301 VA: 0x3160200
	|-List<CameraState.CustomBlendable>.GetEnumerator
	|
	|-RVA: 0x31631F0 Offset: 0x31632F1 VA: 0x31631F0
	|-List<CinemachineClearShot.Pair>.GetEnumerator
	|
	|-RVA: 0x31661A0 Offset: 0x31662A1 VA: 0x31661A0
	|-List<CinemachineStateDrivenCamera.HashPair>.GetEnumerator
	|
	|-RVA: 0x3169420 Offset: 0x3169521 VA: 0x3169420
	|-List<TargetPositionCache.CacheCurve.Item>.GetEnumerator
	|
	|-RVA: 0x316C940 Offset: 0x316CA41 VA: 0x316C940
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.GetEnumerator
	|
	|-RVA: 0x3176310 Offset: 0x3176411 VA: 0x3176310
	|-List<ErosionBrush.UndoStep>.GetEnumerator
	|
	|-RVA: 0x31E9A30 Offset: 0x31E9B31 VA: 0x31E9A30
	|-List<MonsterHutSaveData>.GetEnumerator
	|
	|-RVA: 0x31ECCB0 Offset: 0x31ECDB1 VA: 0x31ECCB0
	|-List<MoviePlayer.SUBTITLEDATA>.GetEnumerator
	|
	|-RVA: 0x330BE40 Offset: 0x330BF41 VA: 0x330BE40
	|-List<ShopCatalogPage>.GetEnumerator
	|
	|-RVA: 0x330F170 Offset: 0x330F271 VA: 0x330F170
	|-List<ShopNpcTalk>.GetEnumerator
	|
	|-RVA: 0x3312460 Offset: 0x3312561 VA: 0x3312460
	|-List<SubtitleDataTable.Data>.GetEnumerator
	|
	|-RVA: 0x33154C0 Offset: 0x33155C1 VA: 0x33154C0
	|-List<SubtitleDataTable.DataList>.GetEnumerator
	|
	|-RVA: 0x33184F0 Offset: 0x33185F1 VA: 0x33184F0
	|-List<SubtitleHudDataTable.Data>.GetEnumerator
	|
	|-RVA: 0x331B740 Offset: 0x331B841 VA: 0x331B740
	|-List<SRMonoBehaviourEx.FieldInfo>.GetEnumerator
	|
	|-RVA: 0x3325520 Offset: 0x3325621 VA: 0x3325520
	|-List<bool>.GetEnumerator
	|
	|-RVA: 0x3328500 Offset: 0x3328601 VA: 0x3328500
	|-List<byte>.GetEnumerator
	|
	|-RVA: 0x332B4B0 Offset: 0x332B5B1 VA: 0x332B4B0
	|-List<char>.GetEnumerator
	|
	|-RVA: 0x3359550 Offset: 0x3359651 VA: 0x3359550
	|-List<KeyValuePair<DateTime, object>>.GetEnumerator
	|
	|-RVA: 0x335F5F0 Offset: 0x335F6F1 VA: 0x335F5F0
	|-List<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x33625E0 Offset: 0x33626E1 VA: 0x33625E0
	|-List<DateTime>.GetEnumerator
	|
	|-RVA: 0x3365590 Offset: 0x3365691 VA: 0x3365590
	|-List<double>.GetEnumerator
	|
	|-RVA: 0x3368540 Offset: 0x3368641 VA: 0x3368540
	|-List<short>.GetEnumerator
	|
	|-RVA: 0x3371450 Offset: 0x3371551 VA: 0x3371450
	|-List<long>.GetEnumerator
	|
	|-RVA: 0x3374450 Offset: 0x3374551 VA: 0x3374450
	|-List<InterpretedFrameInfo>.GetEnumerator
	|
	|-RVA: 0x33774B0 Offset: 0x33775B1 VA: 0x33774B0
	|-List<Nullable<Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x3406460 Offset: 0x3406561 VA: 0x3406460
	|-List<Nullable<Bounds>>.GetEnumerator
	|
	|-RVA: 0x3409A20 Offset: 0x3409B21 VA: 0x3409A20
	|-List<Nullable<BoundsInt>>.GetEnumerator
	|
	|-RVA: 0x340CCC0 Offset: 0x340CDC1 VA: 0x340CCC0
	|-List<Nullable<Color32>>.GetEnumerator
	|
	|-RVA: 0x340FF00 Offset: 0x3410001 VA: 0x340FF00
	|-List<Nullable<Color>>.GetEnumerator
	|
	|-RVA: 0x34131A0 Offset: 0x34132A1 VA: 0x34131A0
	|-List<Nullable<GradientAlphaKey>>.GetEnumerator
	|
	|-RVA: 0x3416480 Offset: 0x3416581 VA: 0x3416480
	|-List<Nullable<GradientColorKey>>.GetEnumerator
	|
	|-RVA: 0x34198D0 Offset: 0x34199D1 VA: 0x34198D0
	|-List<Nullable<Keyframe>>.GetEnumerator
	|
	|-RVA: 0x341CAF0 Offset: 0x341CBF1 VA: 0x341CAF0
	|-List<Nullable<LayerMask>>.GetEnumerator
	|
	|-RVA: 0x34200A0 Offset: 0x34201A1 VA: 0x34200A0
	|-List<Nullable<Matrix4x4>>.GetEnumerator
	|
	|-RVA: 0x3423770 Offset: 0x3423871 VA: 0x3423770
	|-List<Nullable<Quaternion>>.GetEnumerator
	|
	|-RVA: 0x3263480 Offset: 0x3263581 VA: 0x3263480
	|-List<Nullable<RangeInt>>.GetEnumerator
	|
	|-RVA: 0x3266760 Offset: 0x3266861 VA: 0x3266760
	|-List<Nullable<Rect>>.GetEnumerator
	|
	|-RVA: 0x3269BC0 Offset: 0x3269CC1 VA: 0x3269BC0
	|-List<Nullable<RectInt>>.GetEnumerator
	|
	|-RVA: 0x326CE60 Offset: 0x326CF61 VA: 0x326CE60
	|-List<Nullable<Vector2>>.GetEnumerator
	|
	|-RVA: 0x326FF80 Offset: 0x3270081 VA: 0x326FF80
	|-List<Nullable<Vector2Int>>.GetEnumerator
	|
	|-RVA: 0x3273060 Offset: 0x3273161 VA: 0x3273060
	|-List<Nullable<Vector3>>.GetEnumerator
	|
	|-RVA: 0x32760D0 Offset: 0x32761D1 VA: 0x32760D0
	|-List<Nullable<Vector3Int>>.GetEnumerator
	|
	|-RVA: 0x3279340 Offset: 0x3279441 VA: 0x3279340
	|-List<Nullable<Vector4>>.GetEnumerator
	|
	|-RVA: 0x327F440 Offset: 0x327F541 VA: 0x327F440
	|-List<sbyte>.GetEnumerator
	|
	|-RVA: 0x32823F0 Offset: 0x32824F1 VA: 0x32823F0
	|-List<float>.GetEnumerator
	|
	|-RVA: 0x32A9650 Offset: 0x32A9751 VA: 0x32A9650
	|-List<ushort>.GetEnumerator
	|
	|-RVA: 0x32AC600 Offset: 0x32AC701 VA: 0x32AC600
	|-List<uint>.GetEnumerator
	|
	|-RVA: 0x32AF5B0 Offset: 0x32AF6B1 VA: 0x32AF5B0
	|-List<ulong>.GetEnumerator
	|
	|-RVA: 0x32B2560 Offset: 0x32B2661 VA: 0x32B2560
	|-List<ValueTuple<bool, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x32B5510 Offset: 0x32B5611 VA: 0x32B5510
	|-List<ValueTuple<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x32BB560 Offset: 0x32BB661 VA: 0x32BB560
	|-List<ValueTuple<object, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x32BE5A0 Offset: 0x32BE6A1 VA: 0x32BE5A0
	|-List<ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x32C4640 Offset: 0x32C4741 VA: 0x32C4640
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x31116D0 Offset: 0x31117D1 VA: 0x31116D0
	|-List<TexturePacker_JsonArray.Frame>.GetEnumerator
	|
	|-RVA: 0x3117AF0 Offset: 0x3117BF1 VA: 0x3117AF0
	|-List<UIMainManagerAttachObject.AttachSet>.GetEnumerator
	|
	|-RVA: 0x311AE00 Offset: 0x311AF01 VA: 0x311AE00
	|-List<CapEdge>.GetEnumerator
	|
	|-RVA: 0x3124690 Offset: 0x3124791 VA: 0x3124690
	|-List<MeshFaceConnectivity.EdgeData>.GetEnumerator
	|
	|-RVA: 0x3127940 Offset: 0x3127A41 VA: 0x3127940
	|-List<NavMeshBuildMarkup>.GetEnumerator
	|
	|-RVA: 0x312E540 Offset: 0x312E641 VA: 0x312E540
	|-List<ConstraintSource>.GetEnumerator
	|
	|-RVA: 0x3131530 Offset: 0x3131631 VA: 0x3131530
	|-List<AnimatorClipInfo>.GetEnumerator
	|
	|-RVA: 0x321D110 Offset: 0x321D211 VA: 0x321D110
	|-List<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|
	|-RVA: 0x32202F0 Offset: 0x32203F1 VA: 0x32202F0
	|-List<BoneWeight>.GetEnumerator
	|
	|-RVA: 0x3223650 Offset: 0x3223751 VA: 0x3223650
	|-List<Bounds>.GetEnumerator
	|
	|-RVA: 0x32269A0 Offset: 0x3226AA1 VA: 0x32269A0
	|-List<BoundsInt>.GetEnumerator
	|
	|-RVA: 0x3229B20 Offset: 0x3229C21 VA: 0x3229B20
	|-List<Color32>.GetEnumerator
	|
	|-RVA: 0x322CB50 Offset: 0x322CC51 VA: 0x322CB50
	|-List<Color>.GetEnumerator
	|
	|-RVA: 0x3230200 Offset: 0x3230301 VA: 0x3230200
	|-List<CombineInstance>.GetEnumerator
	|
	|-RVA: 0x3233C50 Offset: 0x3233D51 VA: 0x3233C50
	|-List<RaycastResult>.GetEnumerator
	|
	|-RVA: 0x3237070 Offset: 0x3237171 VA: 0x3237070
	|-List<GradientAlphaKey>.GetEnumerator
	|
	|-RVA: 0x323A230 Offset: 0x323A331 VA: 0x323A230
	|-List<GradientColorKey>.GetEnumerator
	|
	|-RVA: 0x323D680 Offset: 0x323D781 VA: 0x323D680
	|-List<Keyframe>.GetEnumerator
	|
	|-RVA: 0x32408A0 Offset: 0x32409A1 VA: 0x32408A0
	|-List<LayerMask>.GetEnumerator
	|
	|-RVA: 0x3243C20 Offset: 0x3243D21 VA: 0x3243C20
	|-List<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x32471B0 Offset: 0x32472B1 VA: 0x32471B0
	|-List<ParticleSystem.Particle>.GetEnumerator
	|
	|-RVA: 0x324A400 Offset: 0x324A501 VA: 0x324A400
	|-List<Playable>.GetEnumerator
	|
	|-RVA: 0x324D5E0 Offset: 0x324D6E1 VA: 0x324D5E0
	|-List<PlayableBinding>.GetEnumerator
	|
	|-RVA: 0x32507C0 Offset: 0x32508C1 VA: 0x32507C0
	|-List<PlayableGraph>.GetEnumerator
	|
	|-RVA: 0x32537A0 Offset: 0x32538A1 VA: 0x32537A0
	|-List<Edge>.GetEnumerator
	|
	|-RVA: 0x32567C0 Offset: 0x32568C1 VA: 0x32567C0
	|-List<Quaternion>.GetEnumerator
	|
	|-RVA: 0x32597D0 Offset: 0x32598D1 VA: 0x32597D0
	|-List<RangeInt>.GetEnumerator
	|
	|-RVA: 0x325CA90 Offset: 0x325CB91 VA: 0x325CA90
	|-List<RaycastHit2D>.GetEnumerator
	|
	|-RVA: 0x32600B0 Offset: 0x32601B1 VA: 0x32600B0
	|-List<RaycastHit>.GetEnumerator
	|
	|-RVA: 0x33C1C00 Offset: 0x33C1D01 VA: 0x33C1C00
	|-List<Rect>.GetEnumerator
	|
	|-RVA: 0x33C4C40 Offset: 0x33C4D41 VA: 0x33C4C40
	|-List<RectInt>.GetEnumerator
	|
	|-RVA: 0x33C7C70 Offset: 0x33C7D71 VA: 0x33C7C70
	|-List<ReflectionProbeBlendInfo>.GetEnumerator
	|
	|-RVA: 0x33CB3C0 Offset: 0x33CB4C1 VA: 0x33CB3C0
	|-List<SphericalHarmonicsL2>.GetEnumerator
	|
	|-RVA: 0x33CE9F0 Offset: 0x33CEAF1 VA: 0x33CE9F0
	|-List<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0x33D8450 Offset: 0x33D8551 VA: 0x33D8450
	|-List<DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x33DB8D0 Offset: 0x33DB9D1 VA: 0x33DB8D0
	|-List<DelayedActionManager.DelegateInfo>.GetEnumerator
	|
	|-RVA: 0x31B9FC0 Offset: 0x31BA0C1 VA: 0x31B9FC0
	|-List<GlyphRect>.GetEnumerator
	|
	|-RVA: 0x31BD270 Offset: 0x31BD371 VA: 0x31BD270
	|-List<AnimationOutputWeightProcessor.WeightInfo>.GetEnumerator
	|
	|-RVA: 0x31C0660 Offset: 0x31C0761 VA: 0x31C0660
	|-List<IntervalTreeNode>.GetEnumerator
	|
	|-RVA: 0x31C39D0 Offset: 0x31C3AD1 VA: 0x31C39D0
	|-List<IntervalTree.Entry<object>>.GetEnumerator
	|
	|-RVA: 0x31C6D70 Offset: 0x31C6E71 VA: 0x31C6D70
	|-List<TimeNotificationBehaviour.NotificationEntry>.GetEnumerator
	|
	|-RVA: 0x31C9F70 Offset: 0x31CA071 VA: 0x31C9F70
	|-List<UICharInfo>.GetEnumerator
	|
	|-RVA: 0x31CCFE0 Offset: 0x31CD0E1 VA: 0x31CCFE0
	|-List<FocusController.FocusedElement>.GetEnumerator
	|
	|-RVA: 0x31D0000 Offset: 0x31D0101 VA: 0x31D0000
	|-List<UILineInfo>.GetEnumerator
	|
	|-RVA: 0x31D3590 Offset: 0x31D3691 VA: 0x31D3590
	|-List<UIVertex>.GetEnumerator
	|
	|-RVA: 0x31D6BE0 Offset: 0x31D6CE1 VA: 0x31D6BE0
	|-List<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|
	|-RVA: 0x31D9DC0 Offset: 0x31D9EC1 VA: 0x31D9DC0
	|-List<Vector2>.GetEnumerator
	|
	|-RVA: 0x2CE29B0 Offset: 0x2CE2AB1 VA: 0x2CE29B0
	|-List<Vector2Int>.GetEnumerator
	|
	|-RVA: 0x2CE8A50 Offset: 0x2CE8B51 VA: 0x2CE8A50
	|-List<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x2CEBB10 Offset: 0x2CEBC11 VA: 0x2CEBB10
	|-List<Vector4>.GetEnumerator
	|
	|-RVA: 0x2CEF2A0 Offset: 0x2CEF3A1 VA: 0x2CEF2A0
	|-List<WarpPoints.WarpPoint>.GetEnumerator
	|
	|-RVA: 0x2CF2830 Offset: 0x2CF2931 VA: 0x2CF2830
	|-List<YieldItemParam>.GetEnumerator
	|
	|-RVA: 0x2CF59E0 Offset: 0x2CF5AE1 VA: 0x2CF59E0
	|-List<stCommand_t>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248DC50 Offset: 0x248DD51 VA: 0x248DC50
	|-List<AS_ToolController.ChargeInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2491590 Offset: 0x2491691 VA: 0x2491590
	|-List<BuildItemData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3157140 Offset: 0x3157241 VA: 0x3157140
	|-List<ButtonLinker.LinkObject>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x315A170 Offset: 0x315A271 VA: 0x315A170
	|-List<CharaCallTable.BustupTable>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x315D1C0 Offset: 0x315D2C1 VA: 0x315D1C0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3160260 Offset: 0x3160361 VA: 0x3160260
	|-List<CameraState.CustomBlendable>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3163250 Offset: 0x3163351 VA: 0x3163250
	|-List<CinemachineClearShot.Pair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3166200 Offset: 0x3166301 VA: 0x3166200
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3169490 Offset: 0x3169591 VA: 0x3169490
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x316C9B0 Offset: 0x316CAB1 VA: 0x316C9B0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x316FF30 Offset: 0x3170031 VA: 0x316FF30
	|-List<CropDataTable>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31731C0 Offset: 0x31732C1 VA: 0x31731C0
	|-List<DropItemParam>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3176380 Offset: 0x3176481 VA: 0x3176380
	|-List<ErosionBrush.UndoStep>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31DD000 Offset: 0x31DD101 VA: 0x31DD000
	|-List<EventCheckId>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31E01F0 Offset: 0x31E02F1 VA: 0x31E01F0
	|-List<EventFlagProgressData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31E3240 Offset: 0x31E3341 VA: 0x31E3240
	|-List<FesNpcScoreData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31E6560 Offset: 0x31E6661 VA: 0x31E6560
	|-List<MiningPointSaveData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31E9AA0 Offset: 0x31E9BA1 VA: 0x31E9AA0
	|-List<MonsterHutSaveData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31ECD10 Offset: 0x31ECE11 VA: 0x31ECD10
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31F0100 Offset: 0x31F0201 VA: 0x31F0100
	|-List<NPCActionData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31F35D0 Offset: 0x31F36D1 VA: 0x31F35D0
	|-List<NpcPlaceSchedule>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31F67E0 Offset: 0x31F68E1 VA: 0x31F67E0
	|-List<OrderLotterySaveParameter>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31F9A40 Offset: 0x31F9B41 VA: 0x31F9A40
	|-List<OrderSaveParameter>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31FCC30 Offset: 0x31FCD31 VA: 0x31FCC30
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x330BEA0 Offset: 0x330BFA1 VA: 0x330BEA0
	|-List<ShopCatalogPage>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x330F1E0 Offset: 0x330F2E1 VA: 0x330F1E0
	|-List<ShopNpcTalk>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33124C0 Offset: 0x33125C1 VA: 0x33124C0
	|-List<SubtitleDataTable.Data>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3315520 Offset: 0x3315621 VA: 0x3315520
	|-List<SubtitleDataTable.DataList>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3318550 Offset: 0x3318651 VA: 0x3318550
	|-List<SubtitleHudDataTable.Data>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x331B7B0 Offset: 0x331B8B1 VA: 0x331B7B0
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x331EB30 Offset: 0x331EC31 VA: 0x331EB30
	|-List<Schedule>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33221B0 Offset: 0x33222B1 VA: 0x33221B0
	|-List<CurveSample>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3325580 Offset: 0x3325681 VA: 0x3325580
	|-List<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3328560 Offset: 0x3328661 VA: 0x3328560
	|-List<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x332B510 Offset: 0x332B611 VA: 0x332B510
	|-List<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33595B0 Offset: 0x33596B1 VA: 0x33595B0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x335C600 Offset: 0x335C701 VA: 0x335C600
	|-List<KeyValuePair<int, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x335F650 Offset: 0x335F751 VA: 0x335F650
	|-List<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3362640 Offset: 0x3362741 VA: 0x3362640
	|-List<DateTime>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33655F0 Offset: 0x33656F1 VA: 0x33655F0
	|-List<double>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33685A0 Offset: 0x33686A1 VA: 0x33685A0
	|-List<short>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x336B550 Offset: 0x336B651 VA: 0x336B550
	|-List<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x336E500 Offset: 0x336E601 VA: 0x336E500
	|-List<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33714B0 Offset: 0x33715B1 VA: 0x33714B0
	|-List<long>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33744B0 Offset: 0x33745B1 VA: 0x33744B0
	|-List<InterpretedFrameInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3377510 Offset: 0x3377611 VA: 0x3377510
	|-List<Nullable<Int32Enum>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x34064D0 Offset: 0x34065D1 VA: 0x34064D0
	|-List<Nullable<Bounds>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3409A90 Offset: 0x3409B91 VA: 0x3409A90
	|-List<Nullable<BoundsInt>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x340CD20 Offset: 0x340CE21 VA: 0x340CD20
	|-List<Nullable<Color32>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x340FF60 Offset: 0x3410061 VA: 0x340FF60
	|-List<Nullable<Color>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3413200 Offset: 0x3413301 VA: 0x3413200
	|-List<Nullable<GradientAlphaKey>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x34164E0 Offset: 0x34165E1 VA: 0x34164E0
	|-List<Nullable<GradientColorKey>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3419940 Offset: 0x3419A41 VA: 0x3419940
	|-List<Nullable<Keyframe>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x341CB50 Offset: 0x341CC51 VA: 0x341CB50
	|-List<Nullable<LayerMask>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3420130 Offset: 0x3420231 VA: 0x3420130
	|-List<Nullable<Matrix4x4>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x34237D0 Offset: 0x34238D1 VA: 0x34237D0
	|-List<Nullable<Quaternion>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32634E0 Offset: 0x32635E1 VA: 0x32634E0
	|-List<Nullable<RangeInt>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32667C0 Offset: 0x32668C1 VA: 0x32667C0
	|-List<Nullable<Rect>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3269C20 Offset: 0x3269D21 VA: 0x3269C20
	|-List<Nullable<RectInt>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x326CEC0 Offset: 0x326CFC1 VA: 0x326CEC0
	|-List<Nullable<Vector2>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x326FFE0 Offset: 0x32700E1 VA: 0x326FFE0
	|-List<Nullable<Vector2Int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32730C0 Offset: 0x32731C1 VA: 0x32730C0
	|-List<Nullable<Vector3>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3276130 Offset: 0x3276231 VA: 0x3276130
	|-List<Nullable<Vector3Int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32793A0 Offset: 0x32794A1 VA: 0x32793A0
	|-List<Nullable<Vector4>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x327C4F0 Offset: 0x327C5F1 VA: 0x327C4F0
	|-List<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x327F4A0 Offset: 0x327F5A1 VA: 0x327F4A0
	|-List<sbyte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3282450 Offset: 0x3282551 VA: 0x3282450
	|-List<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32A96B0 Offset: 0x32A97B1 VA: 0x32A96B0
	|-List<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32AC660 Offset: 0x32AC761 VA: 0x32AC660
	|-List<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32AF610 Offset: 0x32AF711 VA: 0x32AF610
	|-List<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32B25C0 Offset: 0x32B26C1 VA: 0x32B25C0
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32B5570 Offset: 0x32B5671 VA: 0x32B5570
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32B8570 Offset: 0x32B8671 VA: 0x32B8570
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32BB5C0 Offset: 0x32BB6C1 VA: 0x32BB5C0
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32BE600 Offset: 0x32BE701 VA: 0x32BE600
	|-List<ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32C1640 Offset: 0x32C1741 VA: 0x32C1640
	|-List<ValueTuple<object, float>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32C46A0 Offset: 0x32C47A1 VA: 0x32C46A0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32C7AF0 Offset: 0x32C7BF1 VA: 0x32C7AF0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3111750 Offset: 0x3111851 VA: 0x3111750
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3114AB0 Offset: 0x3114BB1 VA: 0x3114AB0
	|-List<TutorialUnlockFlagData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3117B50 Offset: 0x3117C51 VA: 0x3117B50
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x311AE70 Offset: 0x311AF71 VA: 0x311AE70
	|-List<CapEdge>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x311E0B0 Offset: 0x311E1B1 VA: 0x311E0B0
	|-List<MeshDataConnectivity.Face>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3121240 Offset: 0x3121341 VA: 0x3121240
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3124700 Offset: 0x3124801 VA: 0x3124700
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31279A0 Offset: 0x3127AA1 VA: 0x31279A0
	|-List<NavMeshBuildMarkup>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x312B060 Offset: 0x312B161 VA: 0x312B060
	|-List<NavMeshBuildSource>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x312E5A0 Offset: 0x312E6A1 VA: 0x312E5A0
	|-List<ConstraintSource>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3131590 Offset: 0x3131691 VA: 0x3131590
	|-List<AnimatorClipInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x321D170 Offset: 0x321D271 VA: 0x321D170
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3220360 Offset: 0x3220461 VA: 0x3220360
	|-List<BoneWeight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32236B0 Offset: 0x32237B1 VA: 0x32236B0
	|-List<Bounds>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3226A00 Offset: 0x3226B01 VA: 0x3226A00
	|-List<BoundsInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3229B80 Offset: 0x3229C81 VA: 0x3229B80
	|-List<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x322CBB0 Offset: 0x322CCB1 VA: 0x322CBB0
	|-List<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32302A0 Offset: 0x32303A1 VA: 0x32302A0
	|-List<CombineInstance>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3233CE0 Offset: 0x3233DE1 VA: 0x3233CE0
	|-List<RaycastResult>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x32370D0 Offset: 0x32371D1 VA: 0x32370D0
	|-List<GradientAlphaKey>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x323A290 Offset: 0x323A391 VA: 0x323A290
	|-List<GradientColorKey>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x323D6F0 Offset: 0x323D7F1 VA: 0x323D6F0
	|-List<Keyframe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3240900 Offset: 0x3240A01 VA: 0x3240900
	|-List<LayerMask>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3243CA0 Offset: 0x3243DA1 VA: 0x3243CA0
	|-List<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3247230 Offset: 0x3247331 VA: 0x3247230
	|-List<ParticleSystem.Particle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x324A460 Offset: 0x324A561 VA: 0x324A460
	|-List<Playable>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x324D650 Offset: 0x324D751 VA: 0x324D650
	|-List<PlayableBinding>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3250820 Offset: 0x3250921 VA: 0x3250820
	|-List<PlayableGraph>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3253800 Offset: 0x3253901 VA: 0x3253800
	|-List<Edge>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3256820 Offset: 0x3256921 VA: 0x3256820
	|-List<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3259830 Offset: 0x3259931 VA: 0x3259830
	|-List<RangeInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x325CB00 Offset: 0x325CC01 VA: 0x325CB00
	|-List<RaycastHit2D>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3260120 Offset: 0x3260221 VA: 0x3260120
	|-List<RaycastHit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33C1C60 Offset: 0x33C1D61 VA: 0x33C1C60
	|-List<Rect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33C4CA0 Offset: 0x33C4DA1 VA: 0x33C4CA0
	|-List<RectInt>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33C7CD0 Offset: 0x33C7DD1 VA: 0x33C7CD0
	|-List<ReflectionProbeBlendInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33CB460 Offset: 0x33CB561 VA: 0x33CB460
	|-List<SphericalHarmonicsL2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33CEA50 Offset: 0x33CEB51 VA: 0x33CEA50
	|-List<VertexAttributeDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33D1C30 Offset: 0x33D1D31 VA: 0x33D1C30
	|-List<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33D4FD0 Offset: 0x33D50D1 VA: 0x33D4FD0
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33D84C0 Offset: 0x33D85C1 VA: 0x33D84C0
	|-List<DiagnosticEvent>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33DB940 Offset: 0x33DBA41 VA: 0x33DB940
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x33DEE30 Offset: 0x33DEF31 VA: 0x33DEE30
	|-List<ObjectInitializationData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31BA020 Offset: 0x31BA121 VA: 0x31BA020
	|-List<GlyphRect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31BD2E0 Offset: 0x31BD3E1 VA: 0x31BD2E0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31C06C0 Offset: 0x31C07C1 VA: 0x31C06C0
	|-List<IntervalTreeNode>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31C3A30 Offset: 0x31C3B31 VA: 0x31C3A30
	|-List<IntervalTree.Entry<object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31C6DD0 Offset: 0x31C6ED1 VA: 0x31C6DD0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31C9FD0 Offset: 0x31CA0D1 VA: 0x31C9FD0
	|-List<UICharInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31CD040 Offset: 0x31CD141 VA: 0x31CD040
	|-List<FocusController.FocusedElement>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31D0060 Offset: 0x31D0161 VA: 0x31D0060
	|-List<UILineInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31D3620 Offset: 0x31D3721 VA: 0x31D3620
	|-List<UIVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31D6C40 Offset: 0x31D6D41 VA: 0x31D6C40
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31D9E20 Offset: 0x31D9F21 VA: 0x31D9E20
	|-List<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CE2A10 Offset: 0x2CE2B11 VA: 0x2CE2A10
	|-List<Vector2Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CE5A20 Offset: 0x2CE5B21 VA: 0x2CE5A20
	|-List<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CE8AB0 Offset: 0x2CE8BB1 VA: 0x2CE8AB0
	|-List<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CEBB70 Offset: 0x2CEBC71 VA: 0x2CEBB70
	|-List<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CEF320 Offset: 0x2CEF421 VA: 0x2CEF320
	|-List<WarpPoints.WarpPoint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CF2890 Offset: 0x2CF2991 VA: 0x2CF2890
	|-List<YieldItemParam>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CF5A40 Offset: 0x2CF5B41 VA: 0x2CF5A40
	|-List<stCommand_t>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248DCE0 Offset: 0x248DDE1 VA: 0x248DCE0
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2491630 Offset: 0x2491731 VA: 0x2491630
	|-List<BuildItemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31571C0 Offset: 0x31572C1 VA: 0x31571C0
	|-List<ButtonLinker.LinkObject>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x315A1F0 Offset: 0x315A2F1 VA: 0x315A1F0
	|-List<CharaCallTable.BustupTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x315D240 Offset: 0x315D341 VA: 0x315D240
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31602E0 Offset: 0x31603E1 VA: 0x31602E0
	|-List<CameraState.CustomBlendable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31632D0 Offset: 0x31633D1 VA: 0x31632D0
	|-List<CinemachineClearShot.Pair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3166280 Offset: 0x3166381 VA: 0x3166280
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3169520 Offset: 0x3169621 VA: 0x3169520
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x316CA40 Offset: 0x316CB41 VA: 0x316CA40
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x316FFF0 Offset: 0x31700F1 VA: 0x316FFF0
	|-List<CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3173240 Offset: 0x3173341 VA: 0x3173240
	|-List<DropItemParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3176410 Offset: 0x3176511 VA: 0x3176410
	|-List<ErosionBrush.UndoStep>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31DD090 Offset: 0x31DD191 VA: 0x31DD090
	|-List<EventCheckId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31E0270 Offset: 0x31E0371 VA: 0x31E0270
	|-List<EventFlagProgressData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31E32C0 Offset: 0x31E33C1 VA: 0x31E32C0
	|-List<FesNpcScoreData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31E65F0 Offset: 0x31E66F1 VA: 0x31E65F0
	|-List<MiningPointSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31E9B30 Offset: 0x31E9C31 VA: 0x31E9B30
	|-List<MonsterHutSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31ECD90 Offset: 0x31ECE91 VA: 0x31ECD90
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31F01A0 Offset: 0x31F02A1 VA: 0x31F01A0
	|-List<NPCActionData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31F3660 Offset: 0x31F3761 VA: 0x31F3660
	|-List<NpcPlaceSchedule>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31F6860 Offset: 0x31F6961 VA: 0x31F6860
	|-List<OrderLotterySaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31F9AD0 Offset: 0x31F9BD1 VA: 0x31F9AD0
	|-List<OrderSaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31FCCB0 Offset: 0x31FCDB1 VA: 0x31FCCB0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x330BF20 Offset: 0x330C021 VA: 0x330BF20
	|-List<ShopCatalogPage>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x330F280 Offset: 0x330F381 VA: 0x330F280
	|-List<ShopNpcTalk>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3312540 Offset: 0x3312641 VA: 0x3312540
	|-List<SubtitleDataTable.Data>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33155A0 Offset: 0x33156A1 VA: 0x33155A0
	|-List<SubtitleDataTable.DataList>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33185D0 Offset: 0x33186D1 VA: 0x33185D0
	|-List<SubtitleHudDataTable.Data>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x331B840 Offset: 0x331B941 VA: 0x331B840
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x331EBC0 Offset: 0x331ECC1 VA: 0x331EBC0
	|-List<Schedule>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3322260 Offset: 0x3322361 VA: 0x3322260
	|-List<CurveSample>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3325600 Offset: 0x3325701 VA: 0x3325600
	|-List<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33285E0 Offset: 0x33286E1 VA: 0x33285E0
	|-List<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x332B590 Offset: 0x332B691 VA: 0x332B590
	|-List<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3359630 Offset: 0x3359731 VA: 0x3359630
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x335C680 Offset: 0x335C781 VA: 0x335C680
	|-List<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x335F6D0 Offset: 0x335F7D1 VA: 0x335F6D0
	|-List<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33626C0 Offset: 0x33627C1 VA: 0x33626C0
	|-List<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3365670 Offset: 0x3365771 VA: 0x3365670
	|-List<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3368620 Offset: 0x3368721 VA: 0x3368620
	|-List<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x336B5D0 Offset: 0x336B6D1 VA: 0x336B5D0
	|-List<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x336E580 Offset: 0x336E681 VA: 0x336E580
	|-List<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3371530 Offset: 0x3371631 VA: 0x3371530
	|-List<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3374530 Offset: 0x3374631 VA: 0x3374530
	|-List<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3377590 Offset: 0x3377691 VA: 0x3377590
	|-List<Nullable<Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3406560 Offset: 0x3406661 VA: 0x3406560
	|-List<Nullable<Bounds>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3409B20 Offset: 0x3409C21 VA: 0x3409B20
	|-List<Nullable<BoundsInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x340CDA0 Offset: 0x340CEA1 VA: 0x340CDA0
	|-List<Nullable<Color32>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x340FFF0 Offset: 0x34100F1 VA: 0x340FFF0
	|-List<Nullable<Color>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3413280 Offset: 0x3413381 VA: 0x3413280
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3416570 Offset: 0x3416671 VA: 0x3416570
	|-List<Nullable<GradientColorKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x34199D0 Offset: 0x3419AD1 VA: 0x34199D0
	|-List<Nullable<Keyframe>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x341CBD0 Offset: 0x341CCD1 VA: 0x341CBD0
	|-List<Nullable<LayerMask>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x34201E0 Offset: 0x34202E1 VA: 0x34201E0
	|-List<Nullable<Matrix4x4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3423860 Offset: 0x3423961 VA: 0x3423860
	|-List<Nullable<Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3263560 Offset: 0x3263661 VA: 0x3263560
	|-List<Nullable<RangeInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3266850 Offset: 0x3266951 VA: 0x3266850
	|-List<Nullable<Rect>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3269CB0 Offset: 0x3269DB1 VA: 0x3269CB0
	|-List<Nullable<RectInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x326CF40 Offset: 0x326D041 VA: 0x326CF40
	|-List<Nullable<Vector2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3270060 Offset: 0x3270161 VA: 0x3270060
	|-List<Nullable<Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3273140 Offset: 0x3273241 VA: 0x3273140
	|-List<Nullable<Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32761B0 Offset: 0x32762B1 VA: 0x32761B0
	|-List<Nullable<Vector3Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3279430 Offset: 0x3279531 VA: 0x3279430
	|-List<Nullable<Vector4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x327C570 Offset: 0x327C671 VA: 0x327C570
	|-List<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x327F520 Offset: 0x327F621 VA: 0x327F520
	|-List<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32824D0 Offset: 0x32825D1 VA: 0x32824D0
	|-List<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32A9730 Offset: 0x32A9831 VA: 0x32A9730
	|-List<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32AC6E0 Offset: 0x32AC7E1 VA: 0x32AC6E0
	|-List<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32AF690 Offset: 0x32AF791 VA: 0x32AF690
	|-List<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32B2640 Offset: 0x32B2741 VA: 0x32B2640
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32B55F0 Offset: 0x32B56F1 VA: 0x32B55F0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32B85F0 Offset: 0x32B86F1 VA: 0x32B85F0
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32BB640 Offset: 0x32BB741 VA: 0x32BB640
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32BE680 Offset: 0x32BE781 VA: 0x32BE680
	|-List<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32C16C0 Offset: 0x32C17C1 VA: 0x32C16C0
	|-List<ValueTuple<object, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32C4720 Offset: 0x32C4821 VA: 0x32C4720
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32C7B90 Offset: 0x32C7C91 VA: 0x32C7B90
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31117F0 Offset: 0x31118F1 VA: 0x31117F0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3114B30 Offset: 0x3114C31 VA: 0x3114B30
	|-List<TutorialUnlockFlagData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3117BD0 Offset: 0x3117CD1 VA: 0x3117BD0
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x311AF00 Offset: 0x311B001 VA: 0x311AF00
	|-List<CapEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x311E130 Offset: 0x311E231 VA: 0x311E130
	|-List<MeshDataConnectivity.Face>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31212D0 Offset: 0x31213D1 VA: 0x31212D0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31247A0 Offset: 0x31248A1 VA: 0x31247A0
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3127A20 Offset: 0x3127B21 VA: 0x3127A20
	|-List<NavMeshBuildMarkup>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x312B120 Offset: 0x312B221 VA: 0x312B120
	|-List<NavMeshBuildSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x312E620 Offset: 0x312E721 VA: 0x312E620
	|-List<ConstraintSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3131610 Offset: 0x3131711 VA: 0x3131610
	|-List<AnimatorClipInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x321D1F0 Offset: 0x321D2F1 VA: 0x321D1F0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32203F0 Offset: 0x32204F1 VA: 0x32203F0
	|-List<BoneWeight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3223740 Offset: 0x3223841 VA: 0x3223740
	|-List<Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3226A90 Offset: 0x3226B91 VA: 0x3226A90
	|-List<BoundsInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3229C00 Offset: 0x3229D01 VA: 0x3229C00
	|-List<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x322CC30 Offset: 0x322CD31 VA: 0x322CC30
	|-List<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3230370 Offset: 0x3230471 VA: 0x3230370
	|-List<CombineInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3233D90 Offset: 0x3233E91 VA: 0x3233D90
	|-List<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3237150 Offset: 0x3237251 VA: 0x3237150
	|-List<GradientAlphaKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x323A320 Offset: 0x323A421 VA: 0x323A320
	|-List<GradientColorKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x323D780 Offset: 0x323D881 VA: 0x323D780
	|-List<Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3240980 Offset: 0x3240A81 VA: 0x3240980
	|-List<LayerMask>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3243D40 Offset: 0x3243E41 VA: 0x3243D40
	|-List<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32472D0 Offset: 0x32473D1 VA: 0x32472D0
	|-List<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x324A4E0 Offset: 0x324A5E1 VA: 0x324A4E0
	|-List<Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x324D6E0 Offset: 0x324D7E1 VA: 0x324D6E0
	|-List<PlayableBinding>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32508A0 Offset: 0x32509A1 VA: 0x32508A0
	|-List<PlayableGraph>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3253880 Offset: 0x3253981 VA: 0x3253880
	|-List<Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32568A0 Offset: 0x32569A1 VA: 0x32568A0
	|-List<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32598B0 Offset: 0x32599B1 VA: 0x32598B0
	|-List<RangeInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x325CB90 Offset: 0x325CC91 VA: 0x325CB90
	|-List<RaycastHit2D>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x32601C0 Offset: 0x32602C1 VA: 0x32601C0
	|-List<RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33C1CE0 Offset: 0x33C1DE1 VA: 0x33C1CE0
	|-List<Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33C4D20 Offset: 0x33C4E21 VA: 0x33C4D20
	|-List<RectInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33C7D50 Offset: 0x33C7E51 VA: 0x33C7D50
	|-List<ReflectionProbeBlendInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33CB530 Offset: 0x33CB631 VA: 0x33CB530
	|-List<SphericalHarmonicsL2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33CEAD0 Offset: 0x33CEBD1 VA: 0x33CEAD0
	|-List<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33D1CC0 Offset: 0x33D1DC1 VA: 0x33D1CC0
	|-List<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33D5060 Offset: 0x33D5161 VA: 0x33D5060
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33D8560 Offset: 0x33D8661 VA: 0x33D8560
	|-List<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33DB9D0 Offset: 0x33DBAD1 VA: 0x33DB9D0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x33DEED0 Offset: 0x33DEFD1 VA: 0x33DEED0
	|-List<ObjectInitializationData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31BA0A0 Offset: 0x31BA1A1 VA: 0x31BA0A0
	|-List<GlyphRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31BD370 Offset: 0x31BD471 VA: 0x31BD370
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31C0750 Offset: 0x31C0851 VA: 0x31C0750
	|-List<IntervalTreeNode>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31C3AC0 Offset: 0x31C3BC1 VA: 0x31C3AC0
	|-List<IntervalTree.Entry<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31C6E60 Offset: 0x31C6F61 VA: 0x31C6E60
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31CA050 Offset: 0x31CA151 VA: 0x31CA050
	|-List<UICharInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31CD0C0 Offset: 0x31CD1C1 VA: 0x31CD0C0
	|-List<FocusController.FocusedElement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31D00E0 Offset: 0x31D01E1 VA: 0x31D00E0
	|-List<UILineInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31D36D0 Offset: 0x31D37D1 VA: 0x31D36D0
	|-List<UIVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31D6CD0 Offset: 0x31D6DD1 VA: 0x31D6CD0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31D9EA0 Offset: 0x31D9FA1 VA: 0x31D9EA0
	|-List<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CE2A90 Offset: 0x2CE2B91 VA: 0x2CE2A90
	|-List<Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CE5AA0 Offset: 0x2CE5BA1 VA: 0x2CE5AA0
	|-List<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CE8B30 Offset: 0x2CE8C31 VA: 0x2CE8B30
	|-List<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CEBBF0 Offset: 0x2CEBCF1 VA: 0x2CEBBF0
	|-List<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CEF3C0 Offset: 0x2CEF4C1 VA: 0x2CEF3C0
	|-List<WarpPoints.WarpPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CF2910 Offset: 0x2CF2A11 VA: 0x2CF2910
	|-List<YieldItemParam>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CF5AD0 Offset: 0x2CF5BD1 VA: 0x2CF5AD0
	|-List<stCommand_t>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public List<T> GetRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x336B650 Offset: 0x336B751 VA: 0x336B650
	|-List<int>.GetRange
	|
	|-RVA: 0x248DD70 Offset: 0x248DE71 VA: 0x248DD70
	|-List<AS_ToolController.ChargeInfo>.GetRange
	|
	|-RVA: 0x24916D0 Offset: 0x24917D1 VA: 0x24916D0
	|-List<BuildItemData>.GetRange
	|
	|-RVA: 0x3157240 Offset: 0x3157341 VA: 0x3157240
	|-List<ButtonLinker.LinkObject>.GetRange
	|
	|-RVA: 0x315A270 Offset: 0x315A371 VA: 0x315A270
	|-List<CharaCallTable.BustupTable>.GetRange
	|
	|-RVA: 0x315D2C0 Offset: 0x315D3C1 VA: 0x315D2C0
	|-List<CharaCallTable.CharaFaceIconTable>.GetRange
	|
	|-RVA: 0x3160360 Offset: 0x3160461 VA: 0x3160360
	|-List<CameraState.CustomBlendable>.GetRange
	|
	|-RVA: 0x3163350 Offset: 0x3163451 VA: 0x3163350
	|-List<CinemachineClearShot.Pair>.GetRange
	|
	|-RVA: 0x3166300 Offset: 0x3166401 VA: 0x3166300
	|-List<CinemachineStateDrivenCamera.HashPair>.GetRange
	|
	|-RVA: 0x31695B0 Offset: 0x31696B1 VA: 0x31695B0
	|-List<TargetPositionCache.CacheCurve.Item>.GetRange
	|
	|-RVA: 0x316CAD0 Offset: 0x316CBD1 VA: 0x316CAD0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.GetRange
	|
	|-RVA: 0x31700B0 Offset: 0x31701B1 VA: 0x31700B0
	|-List<CropDataTable>.GetRange
	|
	|-RVA: 0x31732C0 Offset: 0x31733C1 VA: 0x31732C0
	|-List<DropItemParam>.GetRange
	|
	|-RVA: 0x31764A0 Offset: 0x31765A1 VA: 0x31764A0
	|-List<ErosionBrush.UndoStep>.GetRange
	|
	|-RVA: 0x31DD120 Offset: 0x31DD221 VA: 0x31DD120
	|-List<EventCheckId>.GetRange
	|
	|-RVA: 0x31E02F0 Offset: 0x31E03F1 VA: 0x31E02F0
	|-List<EventFlagProgressData>.GetRange
	|
	|-RVA: 0x31E3340 Offset: 0x31E3441 VA: 0x31E3340
	|-List<FesNpcScoreData>.GetRange
	|
	|-RVA: 0x31E6680 Offset: 0x31E6781 VA: 0x31E6680
	|-List<MiningPointSaveData>.GetRange
	|
	|-RVA: 0x31E9BC0 Offset: 0x31E9CC1 VA: 0x31E9BC0
	|-List<MonsterHutSaveData>.GetRange
	|
	|-RVA: 0x31ECE10 Offset: 0x31ECF11 VA: 0x31ECE10
	|-List<MoviePlayer.SUBTITLEDATA>.GetRange
	|
	|-RVA: 0x31F0240 Offset: 0x31F0341 VA: 0x31F0240
	|-List<NPCActionData>.GetRange
	|
	|-RVA: 0x31F36F0 Offset: 0x31F37F1 VA: 0x31F36F0
	|-List<NpcPlaceSchedule>.GetRange
	|
	|-RVA: 0x31F68E0 Offset: 0x31F69E1 VA: 0x31F68E0
	|-List<OrderLotterySaveParameter>.GetRange
	|
	|-RVA: 0x31F9B60 Offset: 0x31F9C61 VA: 0x31F9B60
	|-List<OrderSaveParameter>.GetRange
	|
	|-RVA: 0x31FCD30 Offset: 0x31FCE31 VA: 0x31FCD30
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetRange
	|
	|-RVA: 0x330BFA0 Offset: 0x330C0A1 VA: 0x330BFA0
	|-List<ShopCatalogPage>.GetRange
	|
	|-RVA: 0x330F320 Offset: 0x330F421 VA: 0x330F320
	|-List<ShopNpcTalk>.GetRange
	|
	|-RVA: 0x33125C0 Offset: 0x33126C1 VA: 0x33125C0
	|-List<SubtitleDataTable.Data>.GetRange
	|
	|-RVA: 0x3315620 Offset: 0x3315721 VA: 0x3315620
	|-List<SubtitleDataTable.DataList>.GetRange
	|
	|-RVA: 0x3318650 Offset: 0x3318751 VA: 0x3318650
	|-List<SubtitleHudDataTable.Data>.GetRange
	|
	|-RVA: 0x331B8D0 Offset: 0x331B9D1 VA: 0x331B8D0
	|-List<SRMonoBehaviourEx.FieldInfo>.GetRange
	|
	|-RVA: 0x331EC50 Offset: 0x331ED51 VA: 0x331EC50
	|-List<Schedule>.GetRange
	|
	|-RVA: 0x3322310 Offset: 0x3322411 VA: 0x3322310
	|-List<CurveSample>.GetRange
	|
	|-RVA: 0x3325680 Offset: 0x3325781 VA: 0x3325680
	|-List<bool>.GetRange
	|
	|-RVA: 0x3328660 Offset: 0x3328761 VA: 0x3328660
	|-List<byte>.GetRange
	|
	|-RVA: 0x332B610 Offset: 0x332B711 VA: 0x332B610
	|-List<char>.GetRange
	|
	|-RVA: 0x33596B0 Offset: 0x33597B1 VA: 0x33596B0
	|-List<KeyValuePair<DateTime, object>>.GetRange
	|
	|-RVA: 0x335C700 Offset: 0x335C801 VA: 0x335C700
	|-List<KeyValuePair<int, object>>.GetRange
	|
	|-RVA: 0x335F750 Offset: 0x335F851 VA: 0x335F750
	|-List<KeyValuePair<object, object>>.GetRange
	|
	|-RVA: 0x3362740 Offset: 0x3362841 VA: 0x3362740
	|-List<DateTime>.GetRange
	|
	|-RVA: 0x33656F0 Offset: 0x33657F1 VA: 0x33656F0
	|-List<double>.GetRange
	|
	|-RVA: 0x33686A0 Offset: 0x33687A1 VA: 0x33686A0
	|-List<short>.GetRange
	|
	|-RVA: 0x336E600 Offset: 0x336E701 VA: 0x336E600
	|-List<Int32Enum>.GetRange
	|
	|-RVA: 0x33715B0 Offset: 0x33716B1 VA: 0x33715B0
	|-List<long>.GetRange
	|
	|-RVA: 0x33745B0 Offset: 0x33746B1 VA: 0x33745B0
	|-List<InterpretedFrameInfo>.GetRange
	|
	|-RVA: 0x3377610 Offset: 0x3377711 VA: 0x3377610
	|-List<Nullable<Int32Enum>>.GetRange
	|
	|-RVA: 0x34065F0 Offset: 0x34066F1 VA: 0x34065F0
	|-List<Nullable<Bounds>>.GetRange
	|
	|-RVA: 0x3409BB0 Offset: 0x3409CB1 VA: 0x3409BB0
	|-List<Nullable<BoundsInt>>.GetRange
	|
	|-RVA: 0x340CE20 Offset: 0x340CF21 VA: 0x340CE20
	|-List<Nullable<Color32>>.GetRange
	|
	|-RVA: 0x3410080 Offset: 0x3410181 VA: 0x3410080
	|-List<Nullable<Color>>.GetRange
	|
	|-RVA: 0x3413300 Offset: 0x3413401 VA: 0x3413300
	|-List<Nullable<GradientAlphaKey>>.GetRange
	|
	|-RVA: 0x3416600 Offset: 0x3416701 VA: 0x3416600
	|-List<Nullable<GradientColorKey>>.GetRange
	|
	|-RVA: 0x3419A60 Offset: 0x3419B61 VA: 0x3419A60
	|-List<Nullable<Keyframe>>.GetRange
	|
	|-RVA: 0x341CC50 Offset: 0x341CD51 VA: 0x341CC50
	|-List<Nullable<LayerMask>>.GetRange
	|
	|-RVA: 0x3420290 Offset: 0x3420391 VA: 0x3420290
	|-List<Nullable<Matrix4x4>>.GetRange
	|
	|-RVA: 0x34238F0 Offset: 0x34239F1 VA: 0x34238F0
	|-List<Nullable<Quaternion>>.GetRange
	|
	|-RVA: 0x32635E0 Offset: 0x32636E1 VA: 0x32635E0
	|-List<Nullable<RangeInt>>.GetRange
	|
	|-RVA: 0x32668E0 Offset: 0x32669E1 VA: 0x32668E0
	|-List<Nullable<Rect>>.GetRange
	|
	|-RVA: 0x3269D40 Offset: 0x3269E41 VA: 0x3269D40
	|-List<Nullable<RectInt>>.GetRange
	|
	|-RVA: 0x326CFC0 Offset: 0x326D0C1 VA: 0x326CFC0
	|-List<Nullable<Vector2>>.GetRange
	|
	|-RVA: 0x32700E0 Offset: 0x32701E1 VA: 0x32700E0
	|-List<Nullable<Vector2Int>>.GetRange
	|
	|-RVA: 0x32731C0 Offset: 0x32732C1 VA: 0x32731C0
	|-List<Nullable<Vector3>>.GetRange
	|
	|-RVA: 0x3276230 Offset: 0x3276331 VA: 0x3276230
	|-List<Nullable<Vector3Int>>.GetRange
	|
	|-RVA: 0x32794C0 Offset: 0x32795C1 VA: 0x32794C0
	|-List<Nullable<Vector4>>.GetRange
	|
	|-RVA: 0x327C5F0 Offset: 0x327C6F1 VA: 0x327C5F0
	|-List<object>.GetRange
	|
	|-RVA: 0x327F5A0 Offset: 0x327F6A1 VA: 0x327F5A0
	|-List<sbyte>.GetRange
	|
	|-RVA: 0x3282550 Offset: 0x3282651 VA: 0x3282550
	|-List<float>.GetRange
	|
	|-RVA: 0x32A97B0 Offset: 0x32A98B1 VA: 0x32A97B0
	|-List<ushort>.GetRange
	|
	|-RVA: 0x32AC760 Offset: 0x32AC861 VA: 0x32AC760
	|-List<uint>.GetRange
	|
	|-RVA: 0x32AF710 Offset: 0x32AF811 VA: 0x32AF710
	|-List<ulong>.GetRange
	|
	|-RVA: 0x32B26C0 Offset: 0x32B27C1 VA: 0x32B26C0
	|-List<ValueTuple<bool, Int32Enum>>.GetRange
	|
	|-RVA: 0x32B5670 Offset: 0x32B5771 VA: 0x32B5670
	|-List<ValueTuple<Int32Enum, int>>.GetRange
	|
	|-RVA: 0x32B8670 Offset: 0x32B8771 VA: 0x32B8670
	|-List<ValueTuple<Int32Enum, object>>.GetRange
	|
	|-RVA: 0x32BB6C0 Offset: 0x32BB7C1 VA: 0x32BB6C0
	|-List<ValueTuple<object, Int32Enum>>.GetRange
	|
	|-RVA: 0x32BE700 Offset: 0x32BE801 VA: 0x32BE700
	|-List<ValueTuple<object, object>>.GetRange
	|
	|-RVA: 0x32C1740 Offset: 0x32C1841 VA: 0x32C1740
	|-List<ValueTuple<object, float>>.GetRange
	|
	|-RVA: 0x32C47A0 Offset: 0x32C48A1 VA: 0x32C47A0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.GetRange
	|
	|-RVA: 0x32C7C30 Offset: 0x32C7D31 VA: 0x32C7C30
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.GetRange
	|
	|-RVA: 0x3111890 Offset: 0x3111991 VA: 0x3111890
	|-List<TexturePacker_JsonArray.Frame>.GetRange
	|
	|-RVA: 0x3114BB0 Offset: 0x3114CB1 VA: 0x3114BB0
	|-List<TutorialUnlockFlagData>.GetRange
	|
	|-RVA: 0x3117C50 Offset: 0x3117D51 VA: 0x3117C50
	|-List<UIMainManagerAttachObject.AttachSet>.GetRange
	|
	|-RVA: 0x311AF90 Offset: 0x311B091 VA: 0x311AF90
	|-List<CapEdge>.GetRange
	|
	|-RVA: 0x311E1B0 Offset: 0x311E2B1 VA: 0x311E1B0
	|-List<MeshDataConnectivity.Face>.GetRange
	|
	|-RVA: 0x3121360 Offset: 0x3121461 VA: 0x3121360
	|-List<MeshFaceConnectivity.EdgeData.SideData>.GetRange
	|
	|-RVA: 0x3124840 Offset: 0x3124941 VA: 0x3124840
	|-List<MeshFaceConnectivity.EdgeData>.GetRange
	|
	|-RVA: 0x3127AA0 Offset: 0x3127BA1 VA: 0x3127AA0
	|-List<NavMeshBuildMarkup>.GetRange
	|
	|-RVA: 0x312B1E0 Offset: 0x312B2E1 VA: 0x312B1E0
	|-List<NavMeshBuildSource>.GetRange
	|
	|-RVA: 0x312E6A0 Offset: 0x312E7A1 VA: 0x312E6A0
	|-List<ConstraintSource>.GetRange
	|
	|-RVA: 0x3131690 Offset: 0x3131791 VA: 0x3131690
	|-List<AnimatorClipInfo>.GetRange
	|
	|-RVA: 0x321D270 Offset: 0x321D371 VA: 0x321D270
	|-List<BeforeRenderHelper.OrderBlock>.GetRange
	|
	|-RVA: 0x3220480 Offset: 0x3220581 VA: 0x3220480
	|-List<BoneWeight>.GetRange
	|
	|-RVA: 0x32237D0 Offset: 0x32238D1 VA: 0x32237D0
	|-List<Bounds>.GetRange
	|
	|-RVA: 0x3226B20 Offset: 0x3226C21 VA: 0x3226B20
	|-List<BoundsInt>.GetRange
	|
	|-RVA: 0x3229C80 Offset: 0x3229D81 VA: 0x3229C80
	|-List<Color32>.GetRange
	|
	|-RVA: 0x322CCB0 Offset: 0x322CDB1 VA: 0x322CCB0
	|-List<Color>.GetRange
	|
	|-RVA: 0x3230440 Offset: 0x3230541 VA: 0x3230440
	|-List<CombineInstance>.GetRange
	|
	|-RVA: 0x3233E40 Offset: 0x3233F41 VA: 0x3233E40
	|-List<RaycastResult>.GetRange
	|
	|-RVA: 0x32371D0 Offset: 0x32372D1 VA: 0x32371D0
	|-List<GradientAlphaKey>.GetRange
	|
	|-RVA: 0x323A3B0 Offset: 0x323A4B1 VA: 0x323A3B0
	|-List<GradientColorKey>.GetRange
	|
	|-RVA: 0x323D810 Offset: 0x323D911 VA: 0x323D810
	|-List<Keyframe>.GetRange
	|
	|-RVA: 0x3240A00 Offset: 0x3240B01 VA: 0x3240A00
	|-List<LayerMask>.GetRange
	|
	|-RVA: 0x3243DE0 Offset: 0x3243EE1 VA: 0x3243DE0
	|-List<Matrix4x4>.GetRange
	|
	|-RVA: 0x3247370 Offset: 0x3247471 VA: 0x3247370
	|-List<ParticleSystem.Particle>.GetRange
	|
	|-RVA: 0x324A560 Offset: 0x324A661 VA: 0x324A560
	|-List<Playable>.GetRange
	|
	|-RVA: 0x324D770 Offset: 0x324D871 VA: 0x324D770
	|-List<PlayableBinding>.GetRange
	|
	|-RVA: 0x3250920 Offset: 0x3250A21 VA: 0x3250920
	|-List<PlayableGraph>.GetRange
	|
	|-RVA: 0x3253900 Offset: 0x3253A01 VA: 0x3253900
	|-List<Edge>.GetRange
	|
	|-RVA: 0x3256920 Offset: 0x3256A21 VA: 0x3256920
	|-List<Quaternion>.GetRange
	|
	|-RVA: 0x3259930 Offset: 0x3259A31 VA: 0x3259930
	|-List<RangeInt>.GetRange
	|
	|-RVA: 0x325CC20 Offset: 0x325CD21 VA: 0x325CC20
	|-List<RaycastHit2D>.GetRange
	|
	|-RVA: 0x3260260 Offset: 0x3260361 VA: 0x3260260
	|-List<RaycastHit>.GetRange
	|
	|-RVA: 0x33C1D60 Offset: 0x33C1E61 VA: 0x33C1D60
	|-List<Rect>.GetRange
	|
	|-RVA: 0x33C4DA0 Offset: 0x33C4EA1 VA: 0x33C4DA0
	|-List<RectInt>.GetRange
	|
	|-RVA: 0x33C7DD0 Offset: 0x33C7ED1 VA: 0x33C7DD0
	|-List<ReflectionProbeBlendInfo>.GetRange
	|
	|-RVA: 0x33CB600 Offset: 0x33CB701 VA: 0x33CB600
	|-List<SphericalHarmonicsL2>.GetRange
	|
	|-RVA: 0x33CEB50 Offset: 0x33CEC51 VA: 0x33CEB50
	|-List<VertexAttributeDescriptor>.GetRange
	|
	|-RVA: 0x33D1D50 Offset: 0x33D1E51 VA: 0x33D1D50
	|-List<AsyncOperationHandle>.GetRange
	|
	|-RVA: 0x33D50F0 Offset: 0x33D51F1 VA: 0x33D50F0
	|-List<AsyncOperationHandle<SceneInstance>>.GetRange
	|
	|-RVA: 0x33D8600 Offset: 0x33D8701 VA: 0x33D8600
	|-List<DiagnosticEvent>.GetRange
	|
	|-RVA: 0x33DBA60 Offset: 0x33DBB61 VA: 0x33DBA60
	|-List<DelayedActionManager.DelegateInfo>.GetRange
	|
	|-RVA: 0x33DEF70 Offset: 0x33DF071 VA: 0x33DEF70
	|-List<ObjectInitializationData>.GetRange
	|
	|-RVA: 0x31BA120 Offset: 0x31BA221 VA: 0x31BA120
	|-List<GlyphRect>.GetRange
	|
	|-RVA: 0x31BD400 Offset: 0x31BD501 VA: 0x31BD400
	|-List<AnimationOutputWeightProcessor.WeightInfo>.GetRange
	|
	|-RVA: 0x31C07E0 Offset: 0x31C08E1 VA: 0x31C07E0
	|-List<IntervalTreeNode>.GetRange
	|
	|-RVA: 0x31C3B50 Offset: 0x31C3C51 VA: 0x31C3B50
	|-List<IntervalTree.Entry<object>>.GetRange
	|
	|-RVA: 0x31C6EF0 Offset: 0x31C6FF1 VA: 0x31C6EF0
	|-List<TimeNotificationBehaviour.NotificationEntry>.GetRange
	|
	|-RVA: 0x31CA0D0 Offset: 0x31CA1D1 VA: 0x31CA0D0
	|-List<UICharInfo>.GetRange
	|
	|-RVA: 0x31CD140 Offset: 0x31CD241 VA: 0x31CD140
	|-List<FocusController.FocusedElement>.GetRange
	|
	|-RVA: 0x31D0160 Offset: 0x31D0261 VA: 0x31D0160
	|-List<UILineInfo>.GetRange
	|
	|-RVA: 0x31D3780 Offset: 0x31D3881 VA: 0x31D3780
	|-List<UIVertex>.GetRange
	|
	|-RVA: 0x31D6D60 Offset: 0x31D6E61 VA: 0x31D6D60
	|-List<UnitySynchronizationContext.WorkRequest>.GetRange
	|
	|-RVA: 0x31D9F20 Offset: 0x31DA021 VA: 0x31D9F20
	|-List<Vector2>.GetRange
	|
	|-RVA: 0x2CE2B10 Offset: 0x2CE2C11 VA: 0x2CE2B10
	|-List<Vector2Int>.GetRange
	|
	|-RVA: 0x2CE5B20 Offset: 0x2CE5C21 VA: 0x2CE5B20
	|-List<Vector3>.GetRange
	|
	|-RVA: 0x2CE8BB0 Offset: 0x2CE8CB1 VA: 0x2CE8BB0
	|-List<Vector3Int>.GetRange
	|
	|-RVA: 0x2CEBC70 Offset: 0x2CEBD71 VA: 0x2CEBC70
	|-List<Vector4>.GetRange
	|
	|-RVA: 0x2CEF460 Offset: 0x2CEF561 VA: 0x2CEF460
	|-List<WarpPoints.WarpPoint>.GetRange
	|
	|-RVA: 0x2CF2990 Offset: 0x2CF2A91 VA: 0x2CF2990
	|-List<YieldItemParam>.GetRange
	|
	|-RVA: 0x2CF5B60 Offset: 0x2CF5C61 VA: 0x2CF5B60
	|-List<stCommand_t>.GetRange
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248DE70 Offset: 0x248DF71 VA: 0x248DE70
	|-List<AS_ToolController.ChargeInfo>.IndexOf
	|
	|-RVA: 0x24917D0 Offset: 0x24918D1 VA: 0x24917D0
	|-List<BuildItemData>.IndexOf
	|
	|-RVA: 0x3157340 Offset: 0x3157441 VA: 0x3157340
	|-List<ButtonLinker.LinkObject>.IndexOf
	|
	|-RVA: 0x315A370 Offset: 0x315A471 VA: 0x315A370
	|-List<CharaCallTable.BustupTable>.IndexOf
	|
	|-RVA: 0x315D3C0 Offset: 0x315D4C1 VA: 0x315D3C0
	|-List<CharaCallTable.CharaFaceIconTable>.IndexOf
	|
	|-RVA: 0x3160460 Offset: 0x3160561 VA: 0x3160460
	|-List<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x3163450 Offset: 0x3163551 VA: 0x3163450
	|-List<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x3166400 Offset: 0x3166501 VA: 0x3166400
	|-List<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x31696B0 Offset: 0x31697B1 VA: 0x31696B0
	|-List<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x316CBD0 Offset: 0x316CCD1 VA: 0x316CBD0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x336E700 Offset: 0x336E801 VA: 0x336E700
	|-List<CraftCategoryId>.IndexOf
	|-List<ActorID>.IndexOf
	|-List<BadStatus>.IndexOf
	|-List<GameFlagData>.IndexOf
	|-List<Int32Enum>.IndexOf
	|
	|-RVA: 0x31701B0 Offset: 0x31702B1 VA: 0x31701B0
	|-List<CropDataTable>.IndexOf
	|
	|-RVA: 0x31733C0 Offset: 0x31734C1 VA: 0x31733C0
	|-List<DropItemParam>.IndexOf
	|
	|-RVA: 0x31765A0 Offset: 0x31766A1 VA: 0x31765A0
	|-List<ErosionBrush.UndoStep>.IndexOf
	|
	|-RVA: 0x31DD220 Offset: 0x31DD321 VA: 0x31DD220
	|-List<EventCheckId>.IndexOf
	|
	|-RVA: 0x31E03F0 Offset: 0x31E04F1 VA: 0x31E03F0
	|-List<EventFlagProgressData>.IndexOf
	|
	|-RVA: 0x327C6F0 Offset: 0x327C7F1 VA: 0x327C6F0
	|-List<EventStartData>.IndexOf
	|-List<FarmCropData>.IndexOf
	|-List<OrderData>.IndexOf
	|-List<Point2D>.IndexOf
	|-List<SplitComplexPolygonNode>.IndexOf
	|-List<SplineNode>.IndexOf
	|-List<TransformedMesh>.IndexOf
	|-List<object>.IndexOf
	|-List<string>.IndexOf
	|-List<Thread>.IndexOf
	|-List<EventSystem>.IndexOf
	|-List<SignalAsset>.IndexOf
	|
	|-RVA: 0x31E3440 Offset: 0x31E3541 VA: 0x31E3440
	|-List<FesNpcScoreData>.IndexOf
	|
	|-RVA: 0x31E6780 Offset: 0x31E6881 VA: 0x31E6780
	|-List<MiningPointSaveData>.IndexOf
	|
	|-RVA: 0x31E9CC0 Offset: 0x31E9DC1 VA: 0x31E9CC0
	|-List<MonsterHutSaveData>.IndexOf
	|
	|-RVA: 0x31ECF10 Offset: 0x31ED011 VA: 0x31ECF10
	|-List<MoviePlayer.SUBTITLEDATA>.IndexOf
	|
	|-RVA: 0x31F0340 Offset: 0x31F0441 VA: 0x31F0340
	|-List<NPCActionData>.IndexOf
	|
	|-RVA: 0x31F37F0 Offset: 0x31F38F1 VA: 0x31F37F0
	|-List<NpcPlaceSchedule>.IndexOf
	|
	|-RVA: 0x31F69E0 Offset: 0x31F6AE1 VA: 0x31F69E0
	|-List<OrderLotterySaveParameter>.IndexOf
	|
	|-RVA: 0x31F9C60 Offset: 0x31F9D61 VA: 0x31F9C60
	|-List<OrderSaveParameter>.IndexOf
	|
	|-RVA: 0x31FCE30 Offset: 0x31FCF31 VA: 0x31FCE30
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x330C0A0 Offset: 0x330C1A1 VA: 0x330C0A0
	|-List<ShopCatalogPage>.IndexOf
	|
	|-RVA: 0x330F420 Offset: 0x330F521 VA: 0x330F420
	|-List<ShopNpcTalk>.IndexOf
	|
	|-RVA: 0x33126C0 Offset: 0x33127C1 VA: 0x33126C0
	|-List<SubtitleDataTable.Data>.IndexOf
	|
	|-RVA: 0x3315720 Offset: 0x3315821 VA: 0x3315720
	|-List<SubtitleDataTable.DataList>.IndexOf
	|
	|-RVA: 0x3318750 Offset: 0x3318851 VA: 0x3318750
	|-List<SubtitleHudDataTable.Data>.IndexOf
	|
	|-RVA: 0x331B9D0 Offset: 0x331BAD1 VA: 0x331B9D0
	|-List<SRMonoBehaviourEx.FieldInfo>.IndexOf
	|
	|-RVA: 0x331ED50 Offset: 0x331EE51 VA: 0x331ED50
	|-List<Schedule>.IndexOf
	|
	|-RVA: 0x3322410 Offset: 0x3322511 VA: 0x3322410
	|-List<CurveSample>.IndexOf
	|
	|-RVA: 0x3325780 Offset: 0x3325881 VA: 0x3325780
	|-List<bool>.IndexOf
	|
	|-RVA: 0x3328760 Offset: 0x3328861 VA: 0x3328760
	|-List<byte>.IndexOf
	|
	|-RVA: 0x332B710 Offset: 0x332B811 VA: 0x332B710
	|-List<char>.IndexOf
	|
	|-RVA: 0x33597B0 Offset: 0x33598B1 VA: 0x33597B0
	|-List<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x335C800 Offset: 0x335C901 VA: 0x335C800
	|-List<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x335F850 Offset: 0x335F951 VA: 0x335F850
	|-List<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x3362840 Offset: 0x3362941 VA: 0x3362840
	|-List<DateTime>.IndexOf
	|
	|-RVA: 0x33657F0 Offset: 0x33658F1 VA: 0x33657F0
	|-List<double>.IndexOf
	|
	|-RVA: 0x33687A0 Offset: 0x33688A1 VA: 0x33687A0
	|-List<short>.IndexOf
	|
	|-RVA: 0x336B750 Offset: 0x336B851 VA: 0x336B750
	|-List<int>.IndexOf
	|
	|-RVA: 0x33716B0 Offset: 0x33717B1 VA: 0x33716B0
	|-List<long>.IndexOf
	|
	|-RVA: 0x33746B0 Offset: 0x33747B1 VA: 0x33746B0
	|-List<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x3377710 Offset: 0x3377811 VA: 0x3377710
	|-List<Nullable<Int32Enum>>.IndexOf
	|
	|-RVA: 0x34066F0 Offset: 0x34067F1 VA: 0x34066F0
	|-List<Nullable<Bounds>>.IndexOf
	|
	|-RVA: 0x3409CB0 Offset: 0x3409DB1 VA: 0x3409CB0
	|-List<Nullable<BoundsInt>>.IndexOf
	|
	|-RVA: 0x340CF20 Offset: 0x340D021 VA: 0x340CF20
	|-List<Nullable<Color32>>.IndexOf
	|
	|-RVA: 0x3410180 Offset: 0x3410281 VA: 0x3410180
	|-List<Nullable<Color>>.IndexOf
	|
	|-RVA: 0x3413400 Offset: 0x3413501 VA: 0x3413400
	|-List<Nullable<GradientAlphaKey>>.IndexOf
	|
	|-RVA: 0x3416700 Offset: 0x3416801 VA: 0x3416700
	|-List<Nullable<GradientColorKey>>.IndexOf
	|
	|-RVA: 0x3419B60 Offset: 0x3419C61 VA: 0x3419B60
	|-List<Nullable<Keyframe>>.IndexOf
	|
	|-RVA: 0x341CD50 Offset: 0x341CE51 VA: 0x341CD50
	|-List<Nullable<LayerMask>>.IndexOf
	|
	|-RVA: 0x3420390 Offset: 0x3420491 VA: 0x3420390
	|-List<Nullable<Matrix4x4>>.IndexOf
	|
	|-RVA: 0x34239F0 Offset: 0x3423AF1 VA: 0x34239F0
	|-List<Nullable<Quaternion>>.IndexOf
	|
	|-RVA: 0x32636E0 Offset: 0x32637E1 VA: 0x32636E0
	|-List<Nullable<RangeInt>>.IndexOf
	|
	|-RVA: 0x32669E0 Offset: 0x3266AE1 VA: 0x32669E0
	|-List<Nullable<Rect>>.IndexOf
	|
	|-RVA: 0x3269E40 Offset: 0x3269F41 VA: 0x3269E40
	|-List<Nullable<RectInt>>.IndexOf
	|
	|-RVA: 0x326D0C0 Offset: 0x326D1C1 VA: 0x326D0C0
	|-List<Nullable<Vector2>>.IndexOf
	|
	|-RVA: 0x32701E0 Offset: 0x32702E1 VA: 0x32701E0
	|-List<Nullable<Vector2Int>>.IndexOf
	|
	|-RVA: 0x32732C0 Offset: 0x32733C1 VA: 0x32732C0
	|-List<Nullable<Vector3>>.IndexOf
	|
	|-RVA: 0x3276330 Offset: 0x3276431 VA: 0x3276330
	|-List<Nullable<Vector3Int>>.IndexOf
	|
	|-RVA: 0x32795C0 Offset: 0x32796C1 VA: 0x32795C0
	|-List<Nullable<Vector4>>.IndexOf
	|
	|-RVA: 0x327F6A0 Offset: 0x327F7A1 VA: 0x327F6A0
	|-List<sbyte>.IndexOf
	|
	|-RVA: 0x3282650 Offset: 0x3282751 VA: 0x3282650
	|-List<float>.IndexOf
	|
	|-RVA: 0x32A98B0 Offset: 0x32A99B1 VA: 0x32A98B0
	|-List<ushort>.IndexOf
	|
	|-RVA: 0x32AC860 Offset: 0x32AC961 VA: 0x32AC860
	|-List<uint>.IndexOf
	|
	|-RVA: 0x32AF810 Offset: 0x32AF911 VA: 0x32AF810
	|-List<ulong>.IndexOf
	|
	|-RVA: 0x32B27C0 Offset: 0x32B28C1 VA: 0x32B27C0
	|-List<ValueTuple<bool, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32B5770 Offset: 0x32B5871 VA: 0x32B5770
	|-List<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x32B8770 Offset: 0x32B8871 VA: 0x32B8770
	|-List<ValueTuple<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x32BB7C0 Offset: 0x32BB8C1 VA: 0x32BB7C0
	|-List<ValueTuple<object, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32BE800 Offset: 0x32BE901 VA: 0x32BE800
	|-List<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x32C1840 Offset: 0x32C1941 VA: 0x32C1840
	|-List<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x32C48A0 Offset: 0x32C49A1 VA: 0x32C48A0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.IndexOf
	|
	|-RVA: 0x32C7D30 Offset: 0x32C7E31 VA: 0x32C7D30
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.IndexOf
	|
	|-RVA: 0x3111990 Offset: 0x3111A91 VA: 0x3111990
	|-List<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x3114CB0 Offset: 0x3114DB1 VA: 0x3114CB0
	|-List<TutorialUnlockFlagData>.IndexOf
	|
	|-RVA: 0x3117D50 Offset: 0x3117E51 VA: 0x3117D50
	|-List<UIMainManagerAttachObject.AttachSet>.IndexOf
	|
	|-RVA: 0x311B090 Offset: 0x311B191 VA: 0x311B090
	|-List<CapEdge>.IndexOf
	|
	|-RVA: 0x311E2B0 Offset: 0x311E3B1 VA: 0x311E2B0
	|-List<MeshDataConnectivity.Face>.IndexOf
	|
	|-RVA: 0x3121460 Offset: 0x3121561 VA: 0x3121460
	|-List<MeshFaceConnectivity.EdgeData.SideData>.IndexOf
	|
	|-RVA: 0x3124940 Offset: 0x3124A41 VA: 0x3124940
	|-List<MeshFaceConnectivity.EdgeData>.IndexOf
	|
	|-RVA: 0x3127BA0 Offset: 0x3127CA1 VA: 0x3127BA0
	|-List<NavMeshBuildMarkup>.IndexOf
	|
	|-RVA: 0x312B2E0 Offset: 0x312B3E1 VA: 0x312B2E0
	|-List<NavMeshBuildSource>.IndexOf
	|
	|-RVA: 0x312E7A0 Offset: 0x312E8A1 VA: 0x312E7A0
	|-List<ConstraintSource>.IndexOf
	|
	|-RVA: 0x3131790 Offset: 0x3131891 VA: 0x3131790
	|-List<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x321D370 Offset: 0x321D471 VA: 0x321D370
	|-List<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x3220580 Offset: 0x3220681 VA: 0x3220580
	|-List<BoneWeight>.IndexOf
	|
	|-RVA: 0x32238D0 Offset: 0x32239D1 VA: 0x32238D0
	|-List<Bounds>.IndexOf
	|
	|-RVA: 0x3226C20 Offset: 0x3226D21 VA: 0x3226C20
	|-List<BoundsInt>.IndexOf
	|
	|-RVA: 0x3229D80 Offset: 0x3229E81 VA: 0x3229D80
	|-List<Color32>.IndexOf
	|
	|-RVA: 0x322CDB0 Offset: 0x322CEB1 VA: 0x322CDB0
	|-List<Color>.IndexOf
	|
	|-RVA: 0x3230540 Offset: 0x3230641 VA: 0x3230540
	|-List<CombineInstance>.IndexOf
	|
	|-RVA: 0x3233F40 Offset: 0x3234041 VA: 0x3233F40
	|-List<RaycastResult>.IndexOf
	|
	|-RVA: 0x32372D0 Offset: 0x32373D1 VA: 0x32372D0
	|-List<GradientAlphaKey>.IndexOf
	|
	|-RVA: 0x323A4B0 Offset: 0x323A5B1 VA: 0x323A4B0
	|-List<GradientColorKey>.IndexOf
	|
	|-RVA: 0x323D910 Offset: 0x323DA11 VA: 0x323D910
	|-List<Keyframe>.IndexOf
	|
	|-RVA: 0x3240B00 Offset: 0x3240C01 VA: 0x3240B00
	|-List<LayerMask>.IndexOf
	|
	|-RVA: 0x3243EE0 Offset: 0x3243FE1 VA: 0x3243EE0
	|-List<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3247470 Offset: 0x3247571 VA: 0x3247470
	|-List<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x324A660 Offset: 0x324A761 VA: 0x324A660
	|-List<Playable>.IndexOf
	|
	|-RVA: 0x324D870 Offset: 0x324D971 VA: 0x324D870
	|-List<PlayableBinding>.IndexOf
	|
	|-RVA: 0x3250A20 Offset: 0x3250B21 VA: 0x3250A20
	|-List<PlayableGraph>.IndexOf
	|
	|-RVA: 0x3253A00 Offset: 0x3253B01 VA: 0x3253A00
	|-List<Edge>.IndexOf
	|
	|-RVA: 0x3256A20 Offset: 0x3256B21 VA: 0x3256A20
	|-List<Quaternion>.IndexOf
	|
	|-RVA: 0x3259A30 Offset: 0x3259B31 VA: 0x3259A30
	|-List<RangeInt>.IndexOf
	|
	|-RVA: 0x325CD20 Offset: 0x325CE21 VA: 0x325CD20
	|-List<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x3260360 Offset: 0x3260461 VA: 0x3260360
	|-List<RaycastHit>.IndexOf
	|
	|-RVA: 0x33C1E60 Offset: 0x33C1F61 VA: 0x33C1E60
	|-List<Rect>.IndexOf
	|
	|-RVA: 0x33C4EA0 Offset: 0x33C4FA1 VA: 0x33C4EA0
	|-List<RectInt>.IndexOf
	|
	|-RVA: 0x33C7ED0 Offset: 0x33C7FD1 VA: 0x33C7ED0
	|-List<ReflectionProbeBlendInfo>.IndexOf
	|
	|-RVA: 0x33CB700 Offset: 0x33CB801 VA: 0x33CB700
	|-List<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x33CEC50 Offset: 0x33CED51 VA: 0x33CEC50
	|-List<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x33D1E50 Offset: 0x33D1F51 VA: 0x33D1E50
	|-List<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x33D51F0 Offset: 0x33D52F1 VA: 0x33D51F0
	|-List<AsyncOperationHandle<SceneInstance>>.IndexOf
	|
	|-RVA: 0x33D8700 Offset: 0x33D8801 VA: 0x33D8700
	|-List<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x33DBB60 Offset: 0x33DBC61 VA: 0x33DBB60
	|-List<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x33DF070 Offset: 0x33DF171 VA: 0x33DF070
	|-List<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x31BA220 Offset: 0x31BA321 VA: 0x31BA220
	|-List<GlyphRect>.IndexOf
	|
	|-RVA: 0x31BD500 Offset: 0x31BD601 VA: 0x31BD500
	|-List<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x31C08E0 Offset: 0x31C09E1 VA: 0x31C08E0
	|-List<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x31C3C50 Offset: 0x31C3D51 VA: 0x31C3C50
	|-List<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x31C6FF0 Offset: 0x31C70F1 VA: 0x31C6FF0
	|-List<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x31CA1D0 Offset: 0x31CA2D1 VA: 0x31CA1D0
	|-List<UICharInfo>.IndexOf
	|
	|-RVA: 0x31CD240 Offset: 0x31CD341 VA: 0x31CD240
	|-List<FocusController.FocusedElement>.IndexOf
	|
	|-RVA: 0x31D0260 Offset: 0x31D0361 VA: 0x31D0260
	|-List<UILineInfo>.IndexOf
	|
	|-RVA: 0x31D3880 Offset: 0x31D3981 VA: 0x31D3880
	|-List<UIVertex>.IndexOf
	|
	|-RVA: 0x31D6E60 Offset: 0x31D6F61 VA: 0x31D6E60
	|-List<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x31DA020 Offset: 0x31DA121 VA: 0x31DA020
	|-List<Vector2>.IndexOf
	|
	|-RVA: 0x2CE2C10 Offset: 0x2CE2D11 VA: 0x2CE2C10
	|-List<Vector2Int>.IndexOf
	|
	|-RVA: 0x2CE5C20 Offset: 0x2CE5D21 VA: 0x2CE5C20
	|-List<Vector3>.IndexOf
	|
	|-RVA: 0x2CE8CB0 Offset: 0x2CE8DB1 VA: 0x2CE8CB0
	|-List<Vector3Int>.IndexOf
	|
	|-RVA: 0x2CEBD70 Offset: 0x2CEBE71 VA: 0x2CEBD70
	|-List<Vector4>.IndexOf
	|
	|-RVA: 0x2CEF560 Offset: 0x2CEF661 VA: 0x2CEF560
	|-List<WarpPoints.WarpPoint>.IndexOf
	|
	|-RVA: 0x2CF2A90 Offset: 0x2CF2B91 VA: 0x2CF2A90
	|-List<YieldItemParam>.IndexOf
	|
	|-RVA: 0x2CF5C60 Offset: 0x2CF5D61 VA: 0x2CF5C60
	|-List<stCommand_t>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248DEE0 Offset: 0x248DFE1 VA: 0x248DEE0
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x24918A0 Offset: 0x24919A1 VA: 0x24918A0
	|-List<BuildItemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3157370 Offset: 0x3157471 VA: 0x3157370
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x315A3A0 Offset: 0x315A4A1 VA: 0x315A3A0
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x315D3F0 Offset: 0x315D4F1 VA: 0x315D3F0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3160490 Offset: 0x3160591 VA: 0x3160490
	|-List<CameraState.CustomBlendable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3163480 Offset: 0x3163581 VA: 0x3163480
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3166430 Offset: 0x3166531 VA: 0x3166430
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3169730 Offset: 0x3169831 VA: 0x3169730
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x316CC50 Offset: 0x316CD51 VA: 0x316CC50
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3170240 Offset: 0x3170341 VA: 0x3170240
	|-List<CropDataTable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31733F0 Offset: 0x31734F1 VA: 0x31733F0
	|-List<DropItemParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3176610 Offset: 0x3176711 VA: 0x3176610
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31DD290 Offset: 0x31DD391 VA: 0x31DD290
	|-List<EventCheckId>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31E0420 Offset: 0x31E0521 VA: 0x31E0420
	|-List<EventFlagProgressData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31E3470 Offset: 0x31E3571 VA: 0x31E3470
	|-List<FesNpcScoreData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31E6800 Offset: 0x31E6901 VA: 0x31E6800
	|-List<MiningPointSaveData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31E9D40 Offset: 0x31E9E41 VA: 0x31E9D40
	|-List<MonsterHutSaveData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31ECF40 Offset: 0x31ED041 VA: 0x31ECF40
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31F03D0 Offset: 0x31F04D1 VA: 0x31F03D0
	|-List<NPCActionData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31F3860 Offset: 0x31F3961 VA: 0x31F3860
	|-List<NpcPlaceSchedule>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31F6A10 Offset: 0x31F6B11 VA: 0x31F6A10
	|-List<OrderLotterySaveParameter>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31F9CD0 Offset: 0x31F9DD1 VA: 0x31F9CD0
	|-List<OrderSaveParameter>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31FCE60 Offset: 0x31FCF61 VA: 0x31FCE60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x330C0D0 Offset: 0x330C1D1 VA: 0x330C0D0
	|-List<ShopCatalogPage>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x330F4A0 Offset: 0x330F5A1 VA: 0x330F4A0
	|-List<ShopNpcTalk>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33126F0 Offset: 0x33127F1 VA: 0x33126F0
	|-List<SubtitleDataTable.Data>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3315750 Offset: 0x3315851 VA: 0x3315750
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3318780 Offset: 0x3318881 VA: 0x3318780
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x331BA40 Offset: 0x331BB41 VA: 0x331BA40
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x331EDC0 Offset: 0x331EEC1 VA: 0x331EDC0
	|-List<Schedule>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33224B0 Offset: 0x33225B1 VA: 0x33224B0
	|-List<CurveSample>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33257B0 Offset: 0x33258B1 VA: 0x33257B0
	|-List<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3328790 Offset: 0x3328891 VA: 0x3328790
	|-List<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x332B740 Offset: 0x332B841 VA: 0x332B740
	|-List<char>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33597E0 Offset: 0x33598E1 VA: 0x33597E0
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x335C830 Offset: 0x335C931 VA: 0x335C830
	|-List<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x335F880 Offset: 0x335F981 VA: 0x335F880
	|-List<KeyValuePair<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3362870 Offset: 0x3362971 VA: 0x3362870
	|-List<DateTime>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3365820 Offset: 0x3365921 VA: 0x3365820
	|-List<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33687D0 Offset: 0x33688D1 VA: 0x33687D0
	|-List<short>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x336B780 Offset: 0x336B881 VA: 0x336B780
	|-List<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x336E730 Offset: 0x336E831 VA: 0x336E730
	|-List<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33716E0 Offset: 0x33717E1 VA: 0x33716E0
	|-List<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33746E0 Offset: 0x33747E1 VA: 0x33746E0
	|-List<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3377740 Offset: 0x3377841 VA: 0x3377740
	|-List<Nullable<Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3406770 Offset: 0x3406871 VA: 0x3406770
	|-List<Nullable<Bounds>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3409D30 Offset: 0x3409E31 VA: 0x3409D30
	|-List<Nullable<BoundsInt>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x340CF50 Offset: 0x340D051 VA: 0x340CF50
	|-List<Nullable<Color32>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x34101F0 Offset: 0x34102F1 VA: 0x34101F0
	|-List<Nullable<Color>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3413430 Offset: 0x3413531 VA: 0x3413430
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3416770 Offset: 0x3416871 VA: 0x3416770
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3419BD0 Offset: 0x3419CD1 VA: 0x3419BD0
	|-List<Nullable<Keyframe>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x341CD80 Offset: 0x341CE81 VA: 0x341CD80
	|-List<Nullable<LayerMask>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3420430 Offset: 0x3420531 VA: 0x3420430
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3423A60 Offset: 0x3423B61 VA: 0x3423A60
	|-List<Nullable<Quaternion>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3263710 Offset: 0x3263811 VA: 0x3263710
	|-List<Nullable<RangeInt>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3266A50 Offset: 0x3266B51 VA: 0x3266A50
	|-List<Nullable<Rect>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3269EB0 Offset: 0x3269FB1 VA: 0x3269EB0
	|-List<Nullable<RectInt>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x326D0F0 Offset: 0x326D1F1 VA: 0x326D0F0
	|-List<Nullable<Vector2>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3270210 Offset: 0x3270311 VA: 0x3270210
	|-List<Nullable<Vector2Int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32732F0 Offset: 0x32733F1 VA: 0x32732F0
	|-List<Nullable<Vector3>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3276360 Offset: 0x3276461 VA: 0x3276360
	|-List<Nullable<Vector3Int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3279630 Offset: 0x3279731 VA: 0x3279630
	|-List<Nullable<Vector4>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x327C720 Offset: 0x327C821 VA: 0x327C720
	|-List<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x327F6D0 Offset: 0x327F7D1 VA: 0x327F6D0
	|-List<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3282680 Offset: 0x3282781 VA: 0x3282680
	|-List<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32A98E0 Offset: 0x32A99E1 VA: 0x32A98E0
	|-List<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32AC890 Offset: 0x32AC991 VA: 0x32AC890
	|-List<uint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32AF840 Offset: 0x32AF941 VA: 0x32AF840
	|-List<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32B27F0 Offset: 0x32B28F1 VA: 0x32B27F0
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32B57A0 Offset: 0x32B58A1 VA: 0x32B57A0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32B87A0 Offset: 0x32B88A1 VA: 0x32B87A0
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32BB7F0 Offset: 0x32BB8F1 VA: 0x32BB7F0
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32BE830 Offset: 0x32BE931 VA: 0x32BE830
	|-List<ValueTuple<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32C1870 Offset: 0x32C1971 VA: 0x32C1870
	|-List<ValueTuple<object, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32C48D0 Offset: 0x32C49D1 VA: 0x32C48D0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32C7DC0 Offset: 0x32C7EC1 VA: 0x32C7DC0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3111A20 Offset: 0x3111B21 VA: 0x3111A20
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3114CE0 Offset: 0x3114DE1 VA: 0x3114CE0
	|-List<TutorialUnlockFlagData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3117D80 Offset: 0x3117E81 VA: 0x3117D80
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x311B110 Offset: 0x311B211 VA: 0x311B110
	|-List<CapEdge>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x311E2E0 Offset: 0x311E3E1 VA: 0x311E2E0
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31214D0 Offset: 0x31215D1 VA: 0x31214D0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31249C0 Offset: 0x3124AC1 VA: 0x31249C0
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3127BD0 Offset: 0x3127CD1 VA: 0x3127BD0
	|-List<NavMeshBuildMarkup>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x312B3A0 Offset: 0x312B4A1 VA: 0x312B3A0
	|-List<NavMeshBuildSource>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x312E7D0 Offset: 0x312E8D1 VA: 0x312E7D0
	|-List<ConstraintSource>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31317C0 Offset: 0x31318C1 VA: 0x31317C0
	|-List<AnimatorClipInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x321D3A0 Offset: 0x321D4A1 VA: 0x321D3A0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32205F0 Offset: 0x32206F1 VA: 0x32205F0
	|-List<BoneWeight>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3223940 Offset: 0x3223A41 VA: 0x3223940
	|-List<Bounds>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3226C90 Offset: 0x3226D91 VA: 0x3226C90
	|-List<BoundsInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3229DB0 Offset: 0x3229EB1 VA: 0x3229DB0
	|-List<Color32>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x322CDE0 Offset: 0x322CEE1 VA: 0x322CDE0
	|-List<Color>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3230600 Offset: 0x3230701 VA: 0x3230600
	|-List<CombineInstance>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3233FE0 Offset: 0x32340E1 VA: 0x3233FE0
	|-List<RaycastResult>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3237300 Offset: 0x3237401 VA: 0x3237300
	|-List<GradientAlphaKey>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x323A520 Offset: 0x323A621 VA: 0x323A520
	|-List<GradientColorKey>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x323D990 Offset: 0x323DA91 VA: 0x323D990
	|-List<Keyframe>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3240B30 Offset: 0x3240C31 VA: 0x3240B30
	|-List<LayerMask>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3243F70 Offset: 0x3244071 VA: 0x3243F70
	|-List<Matrix4x4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3247500 Offset: 0x3247601 VA: 0x3247500
	|-List<ParticleSystem.Particle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x324A690 Offset: 0x324A791 VA: 0x324A690
	|-List<Playable>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x324D8E0 Offset: 0x324D9E1 VA: 0x324D8E0
	|-List<PlayableBinding>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3250A50 Offset: 0x3250B51 VA: 0x3250A50
	|-List<PlayableGraph>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3253A30 Offset: 0x3253B31 VA: 0x3253A30
	|-List<Edge>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3256A50 Offset: 0x3256B51 VA: 0x3256A50
	|-List<Quaternion>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x3259A60 Offset: 0x3259B61 VA: 0x3259A60
	|-List<RangeInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x325CDA0 Offset: 0x325CEA1 VA: 0x325CDA0
	|-List<RaycastHit2D>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x32603F0 Offset: 0x32604F1 VA: 0x32603F0
	|-List<RaycastHit>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33C1E90 Offset: 0x33C1F91 VA: 0x33C1E90
	|-List<Rect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33C4ED0 Offset: 0x33C4FD1 VA: 0x33C4ED0
	|-List<RectInt>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33C7F00 Offset: 0x33C8001 VA: 0x33C7F00
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33CB7D0 Offset: 0x33CB8D1 VA: 0x33CB7D0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33CEC80 Offset: 0x33CED81 VA: 0x33CEC80
	|-List<VertexAttributeDescriptor>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33D1EC0 Offset: 0x33D1FC1 VA: 0x33D1EC0
	|-List<AsyncOperationHandle>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33D5260 Offset: 0x33D5361 VA: 0x33D5260
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33D8780 Offset: 0x33D8881 VA: 0x33D8780
	|-List<DiagnosticEvent>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33DBBD0 Offset: 0x33DBCD1 VA: 0x33DBBD0
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x33DF0F0 Offset: 0x33DF1F1 VA: 0x33DF0F0
	|-List<ObjectInitializationData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31BA250 Offset: 0x31BA351 VA: 0x31BA250
	|-List<GlyphRect>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31BD580 Offset: 0x31BD681 VA: 0x31BD580
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31C0950 Offset: 0x31C0A51 VA: 0x31C0950
	|-List<IntervalTreeNode>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31C3CC0 Offset: 0x31C3DC1 VA: 0x31C3CC0
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31C7060 Offset: 0x31C7161 VA: 0x31C7060
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31CA200 Offset: 0x31CA301 VA: 0x31CA200
	|-List<UICharInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31CD270 Offset: 0x31CD371 VA: 0x31CD270
	|-List<FocusController.FocusedElement>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31D0290 Offset: 0x31D0391 VA: 0x31D0290
	|-List<UILineInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31D3930 Offset: 0x31D3A31 VA: 0x31D3930
	|-List<UIVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31D6ED0 Offset: 0x31D6FD1 VA: 0x31D6ED0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x31DA050 Offset: 0x31DA151 VA: 0x31DA050
	|-List<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CE2C40 Offset: 0x2CE2D41 VA: 0x2CE2C40
	|-List<Vector2Int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CE5C50 Offset: 0x2CE5D51 VA: 0x2CE5C50
	|-List<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CE8CE0 Offset: 0x2CE8DE1 VA: 0x2CE8CE0
	|-List<Vector3Int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CEBDA0 Offset: 0x2CEBEA1 VA: 0x2CEBDA0
	|-List<Vector4>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CEF630 Offset: 0x2CEF731 VA: 0x2CEF630
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CF2AC0 Offset: 0x2CF2BC1 VA: 0x2CF2AC0
	|-List<YieldItemParam>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2CF5CD0 Offset: 0x2CF5DD1 VA: 0x2CF5CD0
	|-List<stCommand_t>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248E030 Offset: 0x248E131 VA: 0x248E030
	|-List<AS_ToolController.ChargeInfo>.Insert
	|
	|-RVA: 0x327C860 Offset: 0x327C961 VA: 0x327C860
	|-List<Actor>.Insert
	|-List<AutomaticLOD.LODLevelData>.Insert
	|-List<Task>.Insert
	|-List<CinemachineBrain>.Insert
	|-List<CinemachineVirtualCameraBase>.Insert
	|-List<Point2D>.Insert
	|-List<SimpleAnimationPlayable.StateInfo>.Insert
	|-List<CubicBezierCurve>.Insert
	|-List<SplineNode>.Insert
	|-List<TrackSegment>.Insert
	|-List<Directory.SearchData>.Insert
	|-List<object>.Insert
	|-List<UltimateRope.RopeNode>.Insert
	|-List<EventSystem>.Insert
	|-List<XWeaponTrail.Element>.Insert
	|
	|-RVA: 0x2491A20 Offset: 0x2491B21 VA: 0x2491A20
	|-List<BuildItemData>.Insert
	|
	|-RVA: 0x31574C0 Offset: 0x31575C1 VA: 0x31574C0
	|-List<ButtonLinker.LinkObject>.Insert
	|
	|-RVA: 0x315A4F0 Offset: 0x315A5F1 VA: 0x315A4F0
	|-List<CharaCallTable.BustupTable>.Insert
	|
	|-RVA: 0x315D540 Offset: 0x315D641 VA: 0x315D540
	|-List<CharaCallTable.CharaFaceIconTable>.Insert
	|
	|-RVA: 0x31605E0 Offset: 0x31606E1 VA: 0x31605E0
	|-List<CameraState.CustomBlendable>.Insert
	|
	|-RVA: 0x31635D0 Offset: 0x31636D1 VA: 0x31635D0
	|-List<CinemachineClearShot.Pair>.Insert
	|
	|-RVA: 0x3166580 Offset: 0x3166681 VA: 0x3166580
	|-List<CinemachineStateDrivenCamera.HashPair>.Insert
	|
	|-RVA: 0x3169880 Offset: 0x3169981 VA: 0x3169880
	|-List<TargetPositionCache.CacheCurve.Item>.Insert
	|
	|-RVA: 0x316CDB0 Offset: 0x316CEB1 VA: 0x316CDB0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Insert
	|
	|-RVA: 0x3170390 Offset: 0x3170491 VA: 0x3170390
	|-List<CropDataTable>.Insert
	|
	|-RVA: 0x3173540 Offset: 0x3173641 VA: 0x3173540
	|-List<DropItemParam>.Insert
	|
	|-RVA: 0x3176760 Offset: 0x3176861 VA: 0x3176760
	|-List<ErosionBrush.UndoStep>.Insert
	|
	|-RVA: 0x31DD3E0 Offset: 0x31DD4E1 VA: 0x31DD3E0
	|-List<EventCheckId>.Insert
	|
	|-RVA: 0x31E0570 Offset: 0x31E0671 VA: 0x31E0570
	|-List<EventFlagProgressData>.Insert
	|
	|-RVA: 0x31E35C0 Offset: 0x31E36C1 VA: 0x31E35C0
	|-List<FesNpcScoreData>.Insert
	|
	|-RVA: 0x31E6960 Offset: 0x31E6A61 VA: 0x31E6960
	|-List<MiningPointSaveData>.Insert
	|
	|-RVA: 0x31E9E90 Offset: 0x31E9F91 VA: 0x31E9E90
	|-List<MonsterHutSaveData>.Insert
	|
	|-RVA: 0x31ED090 Offset: 0x31ED191 VA: 0x31ED090
	|-List<MoviePlayer.SUBTITLEDATA>.Insert
	|
	|-RVA: 0x31F0530 Offset: 0x31F0631 VA: 0x31F0530
	|-List<NPCActionData>.Insert
	|
	|-RVA: 0x31F39B0 Offset: 0x31F3AB1 VA: 0x31F39B0
	|-List<NpcPlaceSchedule>.Insert
	|
	|-RVA: 0x31F6B60 Offset: 0x31F6C61 VA: 0x31F6B60
	|-List<OrderLotterySaveParameter>.Insert
	|
	|-RVA: 0x31F9E20 Offset: 0x31F9F21 VA: 0x31F9E20
	|-List<OrderSaveParameter>.Insert
	|
	|-RVA: 0x31FCFB0 Offset: 0x31FD0B1 VA: 0x31FCFB0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Insert
	|
	|-RVA: 0x330C220 Offset: 0x330C321 VA: 0x330C220
	|-List<ShopCatalogPage>.Insert
	|
	|-RVA: 0x330F5F0 Offset: 0x330F6F1 VA: 0x330F5F0
	|-List<ShopNpcTalk>.Insert
	|
	|-RVA: 0x3312840 Offset: 0x3312941 VA: 0x3312840
	|-List<SubtitleDataTable.Data>.Insert
	|
	|-RVA: 0x33158A0 Offset: 0x33159A1 VA: 0x33158A0
	|-List<SubtitleDataTable.DataList>.Insert
	|
	|-RVA: 0x33188D0 Offset: 0x33189D1 VA: 0x33188D0
	|-List<SubtitleHudDataTable.Data>.Insert
	|
	|-RVA: 0x336E880 Offset: 0x336E981 VA: 0x336E880
	|-List<RecipeId>.Insert
	|-List<Int32Enum>.Insert
	|
	|-RVA: 0x331BB90 Offset: 0x331BC91 VA: 0x331BB90
	|-List<SRMonoBehaviourEx.FieldInfo>.Insert
	|
	|-RVA: 0x331EF10 Offset: 0x331F011 VA: 0x331EF10
	|-List<Schedule>.Insert
	|
	|-RVA: 0x3322610 Offset: 0x3322711 VA: 0x3322610
	|-List<CurveSample>.Insert
	|
	|-RVA: 0x3325900 Offset: 0x3325A01 VA: 0x3325900
	|-List<bool>.Insert
	|
	|-RVA: 0x33288E0 Offset: 0x33289E1 VA: 0x33288E0
	|-List<byte>.Insert
	|
	|-RVA: 0x332B890 Offset: 0x332B991 VA: 0x332B890
	|-List<char>.Insert
	|
	|-RVA: 0x3359930 Offset: 0x3359A31 VA: 0x3359930
	|-List<KeyValuePair<DateTime, object>>.Insert
	|
	|-RVA: 0x335C980 Offset: 0x335CA81 VA: 0x335C980
	|-List<KeyValuePair<int, object>>.Insert
	|
	|-RVA: 0x335F9D0 Offset: 0x335FAD1 VA: 0x335F9D0
	|-List<KeyValuePair<object, object>>.Insert
	|
	|-RVA: 0x33629C0 Offset: 0x3362AC1 VA: 0x33629C0
	|-List<DateTime>.Insert
	|
	|-RVA: 0x3365970 Offset: 0x3365A71 VA: 0x3365970
	|-List<double>.Insert
	|
	|-RVA: 0x3368920 Offset: 0x3368A21 VA: 0x3368920
	|-List<short>.Insert
	|
	|-RVA: 0x336B8D0 Offset: 0x336B9D1 VA: 0x336B8D0
	|-List<int>.Insert
	|
	|-RVA: 0x3371830 Offset: 0x3371931 VA: 0x3371830
	|-List<long>.Insert
	|
	|-RVA: 0x3374830 Offset: 0x3374931 VA: 0x3374830
	|-List<InterpretedFrameInfo>.Insert
	|
	|-RVA: 0x3377890 Offset: 0x3377991 VA: 0x3377890
	|-List<Nullable<Int32Enum>>.Insert
	|
	|-RVA: 0x34068E0 Offset: 0x34069E1 VA: 0x34068E0
	|-List<Nullable<Bounds>>.Insert
	|
	|-RVA: 0x3409EA0 Offset: 0x3409FA1 VA: 0x3409EA0
	|-List<Nullable<BoundsInt>>.Insert
	|
	|-RVA: 0x340D0A0 Offset: 0x340D1A1 VA: 0x340D0A0
	|-List<Nullable<Color32>>.Insert
	|
	|-RVA: 0x3410350 Offset: 0x3410451 VA: 0x3410350
	|-List<Nullable<Color>>.Insert
	|
	|-RVA: 0x3413580 Offset: 0x3413681 VA: 0x3413580
	|-List<Nullable<GradientAlphaKey>>.Insert
	|
	|-RVA: 0x34168D0 Offset: 0x34169D1 VA: 0x34168D0
	|-List<Nullable<GradientColorKey>>.Insert
	|
	|-RVA: 0x3419D30 Offset: 0x3419E31 VA: 0x3419D30
	|-List<Nullable<Keyframe>>.Insert
	|
	|-RVA: 0x341CED0 Offset: 0x341CFD1 VA: 0x341CED0
	|-List<Nullable<LayerMask>>.Insert
	|
	|-RVA: 0x34205B0 Offset: 0x34206B1 VA: 0x34205B0
	|-List<Nullable<Matrix4x4>>.Insert
	|
	|-RVA: 0x3423BC0 Offset: 0x3423CC1 VA: 0x3423BC0
	|-List<Nullable<Quaternion>>.Insert
	|
	|-RVA: 0x3263860 Offset: 0x3263961 VA: 0x3263860
	|-List<Nullable<RangeInt>>.Insert
	|
	|-RVA: 0x3266BB0 Offset: 0x3266CB1 VA: 0x3266BB0
	|-List<Nullable<Rect>>.Insert
	|
	|-RVA: 0x326A010 Offset: 0x326A111 VA: 0x326A010
	|-List<Nullable<RectInt>>.Insert
	|
	|-RVA: 0x326D240 Offset: 0x326D341 VA: 0x326D240
	|-List<Nullable<Vector2>>.Insert
	|
	|-RVA: 0x3270360 Offset: 0x3270461 VA: 0x3270360
	|-List<Nullable<Vector2Int>>.Insert
	|
	|-RVA: 0x3273440 Offset: 0x3273541 VA: 0x3273440
	|-List<Nullable<Vector3>>.Insert
	|
	|-RVA: 0x32764B0 Offset: 0x32765B1 VA: 0x32764B0
	|-List<Nullable<Vector3Int>>.Insert
	|
	|-RVA: 0x3279790 Offset: 0x3279891 VA: 0x3279790
	|-List<Nullable<Vector4>>.Insert
	|
	|-RVA: 0x327F820 Offset: 0x327F921 VA: 0x327F820
	|-List<sbyte>.Insert
	|
	|-RVA: 0x32827D0 Offset: 0x32828D1 VA: 0x32827D0
	|-List<float>.Insert
	|
	|-RVA: 0x32A9A30 Offset: 0x32A9B31 VA: 0x32A9A30
	|-List<ushort>.Insert
	|
	|-RVA: 0x32AC9E0 Offset: 0x32ACAE1 VA: 0x32AC9E0
	|-List<uint>.Insert
	|
	|-RVA: 0x32AF990 Offset: 0x32AFA91 VA: 0x32AF990
	|-List<ulong>.Insert
	|
	|-RVA: 0x32B2940 Offset: 0x32B2A41 VA: 0x32B2940
	|-List<ValueTuple<bool, Int32Enum>>.Insert
	|
	|-RVA: 0x32B58F0 Offset: 0x32B59F1 VA: 0x32B58F0
	|-List<ValueTuple<Int32Enum, int>>.Insert
	|
	|-RVA: 0x32B88F0 Offset: 0x32B89F1 VA: 0x32B88F0
	|-List<ValueTuple<Int32Enum, object>>.Insert
	|
	|-RVA: 0x32BB940 Offset: 0x32BBA41 VA: 0x32BB940
	|-List<ValueTuple<object, Int32Enum>>.Insert
	|
	|-RVA: 0x32BE980 Offset: 0x32BEA81 VA: 0x32BE980
	|-List<ValueTuple<object, object>>.Insert
	|
	|-RVA: 0x32C19C0 Offset: 0x32C1AC1 VA: 0x32C19C0
	|-List<ValueTuple<object, float>>.Insert
	|
	|-RVA: 0x32C4A20 Offset: 0x32C4B21 VA: 0x32C4A20
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Insert
	|
	|-RVA: 0x32C7F20 Offset: 0x32C8021 VA: 0x32C7F20
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Insert
	|
	|-RVA: 0x3111B80 Offset: 0x3111C81 VA: 0x3111B80
	|-List<TexturePacker_JsonArray.Frame>.Insert
	|
	|-RVA: 0x3114E30 Offset: 0x3114F31 VA: 0x3114E30
	|-List<TutorialUnlockFlagData>.Insert
	|
	|-RVA: 0x3117ED0 Offset: 0x3117FD1 VA: 0x3117ED0
	|-List<UIMainManagerAttachObject.AttachSet>.Insert
	|
	|-RVA: 0x311B270 Offset: 0x311B371 VA: 0x311B270
	|-List<CapEdge>.Insert
	|
	|-RVA: 0x311E430 Offset: 0x311E531 VA: 0x311E430
	|-List<MeshDataConnectivity.Face>.Insert
	|
	|-RVA: 0x3121620 Offset: 0x3121721 VA: 0x3121620
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Insert
	|
	|-RVA: 0x3124B10 Offset: 0x3124C11 VA: 0x3124B10
	|-List<MeshFaceConnectivity.EdgeData>.Insert
	|
	|-RVA: 0x3127D20 Offset: 0x3127E21 VA: 0x3127D20
	|-List<NavMeshBuildMarkup>.Insert
	|
	|-RVA: 0x312B510 Offset: 0x312B611 VA: 0x312B510
	|-List<NavMeshBuildSource>.Insert
	|
	|-RVA: 0x312E920 Offset: 0x312EA21 VA: 0x312E920
	|-List<ConstraintSource>.Insert
	|
	|-RVA: 0x3131910 Offset: 0x3131A11 VA: 0x3131910
	|-List<AnimatorClipInfo>.Insert
	|
	|-RVA: 0x321D4F0 Offset: 0x321D5F1 VA: 0x321D4F0
	|-List<BeforeRenderHelper.OrderBlock>.Insert
	|
	|-RVA: 0x3220740 Offset: 0x3220841 VA: 0x3220740
	|-List<BoneWeight>.Insert
	|
	|-RVA: 0x3223A90 Offset: 0x3223B91 VA: 0x3223A90
	|-List<Bounds>.Insert
	|
	|-RVA: 0x3226DE0 Offset: 0x3226EE1 VA: 0x3226DE0
	|-List<BoundsInt>.Insert
	|
	|-RVA: 0x3229F00 Offset: 0x322A001 VA: 0x3229F00
	|-List<Color32>.Insert
	|
	|-RVA: 0x322CF30 Offset: 0x322D031 VA: 0x322CF30
	|-List<Color>.Insert
	|
	|-RVA: 0x3230770 Offset: 0x3230871 VA: 0x3230770
	|-List<CombineInstance>.Insert
	|
	|-RVA: 0x3234140 Offset: 0x3234241 VA: 0x3234140
	|-List<RaycastResult>.Insert
	|
	|-RVA: 0x3237450 Offset: 0x3237551 VA: 0x3237450
	|-List<GradientAlphaKey>.Insert
	|
	|-RVA: 0x323A670 Offset: 0x323A771 VA: 0x323A670
	|-List<GradientColorKey>.Insert
	|
	|-RVA: 0x323DAE0 Offset: 0x323DBE1 VA: 0x323DAE0
	|-List<Keyframe>.Insert
	|
	|-RVA: 0x3240C80 Offset: 0x3240D81 VA: 0x3240C80
	|-List<LayerMask>.Insert
	|
	|-RVA: 0x32440D0 Offset: 0x32441D1 VA: 0x32440D0
	|-List<Matrix4x4>.Insert
	|
	|-RVA: 0x3247650 Offset: 0x3247751 VA: 0x3247650
	|-List<ParticleSystem.Particle>.Insert
	|
	|-RVA: 0x324A7E0 Offset: 0x324A8E1 VA: 0x324A7E0
	|-List<Playable>.Insert
	|
	|-RVA: 0x324DA30 Offset: 0x324DB31 VA: 0x324DA30
	|-List<PlayableBinding>.Insert
	|
	|-RVA: 0x3250BA0 Offset: 0x3250CA1 VA: 0x3250BA0
	|-List<PlayableGraph>.Insert
	|
	|-RVA: 0x3253B80 Offset: 0x3253C81 VA: 0x3253B80
	|-List<Edge>.Insert
	|
	|-RVA: 0x3256BA0 Offset: 0x3256CA1 VA: 0x3256BA0
	|-List<Quaternion>.Insert
	|
	|-RVA: 0x3259BB0 Offset: 0x3259CB1 VA: 0x3259BB0
	|-List<RangeInt>.Insert
	|
	|-RVA: 0x325CF00 Offset: 0x325D001 VA: 0x325CF00
	|-List<RaycastHit2D>.Insert
	|
	|-RVA: 0x3260550 Offset: 0x3260651 VA: 0x3260550
	|-List<RaycastHit>.Insert
	|
	|-RVA: 0x33C1FE0 Offset: 0x33C20E1 VA: 0x33C1FE0
	|-List<Rect>.Insert
	|
	|-RVA: 0x33C5020 Offset: 0x33C5121 VA: 0x33C5020
	|-List<RectInt>.Insert
	|
	|-RVA: 0x33C8050 Offset: 0x33C8151 VA: 0x33C8050
	|-List<ReflectionProbeBlendInfo>.Insert
	|
	|-RVA: 0x33CB950 Offset: 0x33CBA51 VA: 0x33CB950
	|-List<SphericalHarmonicsL2>.Insert
	|
	|-RVA: 0x33CEDD0 Offset: 0x33CEED1 VA: 0x33CEDD0
	|-List<VertexAttributeDescriptor>.Insert
	|
	|-RVA: 0x33D2010 Offset: 0x33D2111 VA: 0x33D2010
	|-List<AsyncOperationHandle>.Insert
	|
	|-RVA: 0x33D53B0 Offset: 0x33D54B1 VA: 0x33D53B0
	|-List<AsyncOperationHandle<SceneInstance>>.Insert
	|
	|-RVA: 0x33D88D0 Offset: 0x33D89D1 VA: 0x33D88D0
	|-List<DiagnosticEvent>.Insert
	|
	|-RVA: 0x33DBD20 Offset: 0x33DBE21 VA: 0x33DBD20
	|-List<DelayedActionManager.DelegateInfo>.Insert
	|
	|-RVA: 0x33DF240 Offset: 0x33DF341 VA: 0x33DF240
	|-List<ObjectInitializationData>.Insert
	|
	|-RVA: 0x31BA3A0 Offset: 0x31BA4A1 VA: 0x31BA3A0
	|-List<GlyphRect>.Insert
	|
	|-RVA: 0x31BD6D0 Offset: 0x31BD7D1 VA: 0x31BD6D0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Insert
	|
	|-RVA: 0x31C0AA0 Offset: 0x31C0BA1 VA: 0x31C0AA0
	|-List<IntervalTreeNode>.Insert
	|
	|-RVA: 0x31C3E10 Offset: 0x31C3F11 VA: 0x31C3E10
	|-List<IntervalTree.Entry<object>>.Insert
	|
	|-RVA: 0x31C71B0 Offset: 0x31C72B1 VA: 0x31C71B0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Insert
	|
	|-RVA: 0x31CA350 Offset: 0x31CA451 VA: 0x31CA350
	|-List<UICharInfo>.Insert
	|
	|-RVA: 0x31CD3C0 Offset: 0x31CD4C1 VA: 0x31CD3C0
	|-List<FocusController.FocusedElement>.Insert
	|
	|-RVA: 0x31D03E0 Offset: 0x31D04E1 VA: 0x31D03E0
	|-List<UILineInfo>.Insert
	|
	|-RVA: 0x31D3AA0 Offset: 0x31D3BA1 VA: 0x31D3AA0
	|-List<UIVertex>.Insert
	|
	|-RVA: 0x31D7020 Offset: 0x31D7121 VA: 0x31D7020
	|-List<UnitySynchronizationContext.WorkRequest>.Insert
	|
	|-RVA: 0x31DA1A0 Offset: 0x31DA2A1 VA: 0x31DA1A0
	|-List<Vector2>.Insert
	|
	|-RVA: 0x2CE2D90 Offset: 0x2CE2E91 VA: 0x2CE2D90
	|-List<Vector2Int>.Insert
	|
	|-RVA: 0x2CE5DA0 Offset: 0x2CE5EA1 VA: 0x2CE5DA0
	|-List<Vector3>.Insert
	|
	|-RVA: 0x2CE8E30 Offset: 0x2CE8F31 VA: 0x2CE8E30
	|-List<Vector3Int>.Insert
	|
	|-RVA: 0x2CEBEF0 Offset: 0x2CEBFF1 VA: 0x2CEBEF0
	|-List<Vector4>.Insert
	|
	|-RVA: 0x2CEF7B0 Offset: 0x2CEF8B1 VA: 0x2CEF7B0
	|-List<WarpPoints.WarpPoint>.Insert
	|
	|-RVA: 0x2CF2C10 Offset: 0x2CF2D11 VA: 0x2CF2C10
	|-List<YieldItemParam>.Insert
	|
	|-RVA: 0x2CF5E20 Offset: 0x2CF5F21 VA: 0x2CF5E20
	|-List<stCommand_t>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248E160 Offset: 0x248E261 VA: 0x248E160
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2491BF0 Offset: 0x2491CF1 VA: 0x2491BF0
	|-List<BuildItemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31575D0 Offset: 0x31576D1 VA: 0x31575D0
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.Insert
	|
	|-RVA: 0x315A600 Offset: 0x315A701 VA: 0x315A600
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x315D650 Offset: 0x315D751 VA: 0x315D650
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x31606F0 Offset: 0x31607F1 VA: 0x31606F0
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Insert
	|
	|-RVA: 0x31636D0 Offset: 0x31637D1 VA: 0x31636D0
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Insert
	|
	|-RVA: 0x3166680 Offset: 0x3166781 VA: 0x3166680
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Insert
	|
	|-RVA: 0x31699C0 Offset: 0x3169AC1 VA: 0x31699C0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Insert
	|
	|-RVA: 0x316CF00 Offset: 0x316D001 VA: 0x316CF00
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Insert
	|
	|-RVA: 0x31704D0 Offset: 0x31705D1 VA: 0x31704D0
	|-List<CropDataTable>.System.Collections.IList.Insert
	|
	|-RVA: 0x3173640 Offset: 0x3173741 VA: 0x3173640
	|-List<DropItemParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x3176890 Offset: 0x3176991 VA: 0x3176890
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.Insert
	|
	|-RVA: 0x31DD510 Offset: 0x31DD611 VA: 0x31DD510
	|-List<EventCheckId>.System.Collections.IList.Insert
	|
	|-RVA: 0x31E0680 Offset: 0x31E0781 VA: 0x31E0680
	|-List<EventFlagProgressData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31E36D0 Offset: 0x31E37D1 VA: 0x31E36D0
	|-List<FesNpcScoreData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31E6AB0 Offset: 0x31E6BB1 VA: 0x31E6AB0
	|-List<MiningPointSaveData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31E9FD0 Offset: 0x31EA0D1 VA: 0x31E9FD0
	|-List<MonsterHutSaveData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31ED1A0 Offset: 0x31ED2A1 VA: 0x31ED1A0
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Insert
	|
	|-RVA: 0x31F0680 Offset: 0x31F0781 VA: 0x31F0680
	|-List<NPCActionData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31F3AE0 Offset: 0x31F3BE1 VA: 0x31F3AE0
	|-List<NpcPlaceSchedule>.System.Collections.IList.Insert
	|
	|-RVA: 0x31F6C70 Offset: 0x31F6D71 VA: 0x31F6C70
	|-List<OrderLotterySaveParameter>.System.Collections.IList.Insert
	|
	|-RVA: 0x31F9F50 Offset: 0x31FA051 VA: 0x31F9F50
	|-List<OrderSaveParameter>.System.Collections.IList.Insert
	|
	|-RVA: 0x31FD0C0 Offset: 0x31FD1C1 VA: 0x31FD0C0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Insert
	|
	|-RVA: 0x330C330 Offset: 0x330C431 VA: 0x330C330
	|-List<ShopCatalogPage>.System.Collections.IList.Insert
	|
	|-RVA: 0x330F740 Offset: 0x330F841 VA: 0x330F740
	|-List<ShopNpcTalk>.System.Collections.IList.Insert
	|
	|-RVA: 0x3312950 Offset: 0x3312A51 VA: 0x3312950
	|-List<SubtitleDataTable.Data>.System.Collections.IList.Insert
	|
	|-RVA: 0x33159A0 Offset: 0x3315AA1 VA: 0x33159A0
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.Insert
	|
	|-RVA: 0x33189E0 Offset: 0x3318AE1 VA: 0x33189E0
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.Insert
	|
	|-RVA: 0x331BCC0 Offset: 0x331BDC1 VA: 0x331BCC0
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x331F030 Offset: 0x331F131 VA: 0x331F030
	|-List<Schedule>.System.Collections.IList.Insert
	|
	|-RVA: 0x3322780 Offset: 0x3322881 VA: 0x3322780
	|-List<CurveSample>.System.Collections.IList.Insert
	|
	|-RVA: 0x3325A00 Offset: 0x3325B01 VA: 0x3325A00
	|-List<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x33289E0 Offset: 0x3328AE1 VA: 0x33289E0
	|-List<byte>.System.Collections.IList.Insert
	|
	|-RVA: 0x332B990 Offset: 0x332BA91 VA: 0x332B990
	|-List<char>.System.Collections.IList.Insert
	|
	|-RVA: 0x3359A40 Offset: 0x3359B41 VA: 0x3359A40
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x335CA90 Offset: 0x335CB91 VA: 0x335CA90
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x335FAE0 Offset: 0x335FBE1 VA: 0x335FAE0
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3362AC0 Offset: 0x3362BC1 VA: 0x3362AC0
	|-List<DateTime>.System.Collections.IList.Insert
	|
	|-RVA: 0x3365A70 Offset: 0x3365B71 VA: 0x3365A70
	|-List<double>.System.Collections.IList.Insert
	|
	|-RVA: 0x3368A20 Offset: 0x3368B21 VA: 0x3368A20
	|-List<short>.System.Collections.IList.Insert
	|
	|-RVA: 0x336B9D0 Offset: 0x336BAD1 VA: 0x336B9D0
	|-List<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x336E980 Offset: 0x336EA81 VA: 0x336E980
	|-List<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x3371930 Offset: 0x3371A31 VA: 0x3371930
	|-List<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x3374940 Offset: 0x3374A41 VA: 0x3374940
	|-List<InterpretedFrameInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x3377990 Offset: 0x3377A91 VA: 0x3377990
	|-List<Nullable<Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3406A20 Offset: 0x3406B21 VA: 0x3406A20
	|-List<Nullable<Bounds>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3409FE0 Offset: 0x340A0E1 VA: 0x3409FE0
	|-List<Nullable<BoundsInt>>.System.Collections.IList.Insert
	|
	|-RVA: 0x340D1A0 Offset: 0x340D2A1 VA: 0x340D1A0
	|-List<Nullable<Color32>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3410470 Offset: 0x3410571 VA: 0x3410470
	|-List<Nullable<Color>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3413690 Offset: 0x3413791 VA: 0x3413690
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.Insert
	|
	|-RVA: 0x34169F0 Offset: 0x3416AF1 VA: 0x34169F0
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3419E50 Offset: 0x3419F51 VA: 0x3419E50
	|-List<Nullable<Keyframe>>.System.Collections.IList.Insert
	|
	|-RVA: 0x341CFD0 Offset: 0x341D0D1 VA: 0x341CFD0
	|-List<Nullable<LayerMask>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3420730 Offset: 0x3420831 VA: 0x3420730
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3423CE0 Offset: 0x3423DE1 VA: 0x3423CE0
	|-List<Nullable<Quaternion>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3263970 Offset: 0x3263A71 VA: 0x3263970
	|-List<Nullable<RangeInt>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3266CD0 Offset: 0x3266DD1 VA: 0x3266CD0
	|-List<Nullable<Rect>>.System.Collections.IList.Insert
	|
	|-RVA: 0x326A130 Offset: 0x326A231 VA: 0x326A130
	|-List<Nullable<RectInt>>.System.Collections.IList.Insert
	|
	|-RVA: 0x326D350 Offset: 0x326D451 VA: 0x326D350
	|-List<Nullable<Vector2>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3270470 Offset: 0x3270571 VA: 0x3270470
	|-List<Nullable<Vector2Int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3273550 Offset: 0x3273651 VA: 0x3273550
	|-List<Nullable<Vector3>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32765C0 Offset: 0x32766C1 VA: 0x32765C0
	|-List<Nullable<Vector3Int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32798B0 Offset: 0x32799B1 VA: 0x32798B0
	|-List<Nullable<Vector4>>.System.Collections.IList.Insert
	|
	|-RVA: 0x327C960 Offset: 0x327CA61 VA: 0x327C960
	|-List<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x327F920 Offset: 0x327FA21 VA: 0x327F920
	|-List<sbyte>.System.Collections.IList.Insert
	|
	|-RVA: 0x32828D0 Offset: 0x32829D1 VA: 0x32828D0
	|-List<float>.System.Collections.IList.Insert
	|
	|-RVA: 0x32A9B30 Offset: 0x32A9C31 VA: 0x32A9B30
	|-List<ushort>.System.Collections.IList.Insert
	|
	|-RVA: 0x32ACAE0 Offset: 0x32ACBE1 VA: 0x32ACAE0
	|-List<uint>.System.Collections.IList.Insert
	|
	|-RVA: 0x32AFA90 Offset: 0x32AFB91 VA: 0x32AFA90
	|-List<ulong>.System.Collections.IList.Insert
	|
	|-RVA: 0x32B2A40 Offset: 0x32B2B41 VA: 0x32B2A40
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32B59F0 Offset: 0x32B5AF1 VA: 0x32B59F0
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32B8A00 Offset: 0x32B8B01 VA: 0x32B8A00
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32BBA50 Offset: 0x32BBB51 VA: 0x32BBA50
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32BEA90 Offset: 0x32BEB91 VA: 0x32BEA90
	|-List<ValueTuple<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32C1AD0 Offset: 0x32C1BD1 VA: 0x32C1AD0
	|-List<ValueTuple<object, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32C4B30 Offset: 0x32C4C31 VA: 0x32C4B30
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Insert
	|
	|-RVA: 0x32C8080 Offset: 0x32C8181 VA: 0x32C8080
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x3111CE0 Offset: 0x3111DE1 VA: 0x3111CE0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Insert
	|
	|-RVA: 0x3114F40 Offset: 0x3115041 VA: 0x3114F40
	|-List<TutorialUnlockFlagData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3117FE0 Offset: 0x31180E1 VA: 0x3117FE0
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Insert
	|
	|-RVA: 0x311B3C0 Offset: 0x311B4C1 VA: 0x311B3C0
	|-List<CapEdge>.System.Collections.IList.Insert
	|
	|-RVA: 0x311E530 Offset: 0x311E631 VA: 0x311E530
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.Insert
	|
	|-RVA: 0x3121740 Offset: 0x3121841 VA: 0x3121740
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3124C60 Offset: 0x3124D61 VA: 0x3124C60
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Insert
	|
	|-RVA: 0x3127E30 Offset: 0x3127F31 VA: 0x3127E30
	|-List<NavMeshBuildMarkup>.System.Collections.IList.Insert
	|
	|-RVA: 0x312B6B0 Offset: 0x312B7B1 VA: 0x312B6B0
	|-List<NavMeshBuildSource>.System.Collections.IList.Insert
	|
	|-RVA: 0x312EA30 Offset: 0x312EB31 VA: 0x312EA30
	|-List<ConstraintSource>.System.Collections.IList.Insert
	|
	|-RVA: 0x3131A10 Offset: 0x3131B11 VA: 0x3131A10
	|-List<AnimatorClipInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x321D600 Offset: 0x321D701 VA: 0x321D600
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|
	|-RVA: 0x3220860 Offset: 0x3220961 VA: 0x3220860
	|-List<BoneWeight>.System.Collections.IList.Insert
	|
	|-RVA: 0x3223BB0 Offset: 0x3223CB1 VA: 0x3223BB0
	|-List<Bounds>.System.Collections.IList.Insert
	|
	|-RVA: 0x3226F00 Offset: 0x3227001 VA: 0x3226F00
	|-List<BoundsInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x322A000 Offset: 0x322A101 VA: 0x322A000
	|-List<Color32>.System.Collections.IList.Insert
	|
	|-RVA: 0x322D050 Offset: 0x322D151 VA: 0x322D050
	|-List<Color>.System.Collections.IList.Insert
	|
	|-RVA: 0x3230910 Offset: 0x3230A11 VA: 0x3230910
	|-List<CombineInstance>.System.Collections.IList.Insert
	|
	|-RVA: 0x32342B0 Offset: 0x32343B1 VA: 0x32342B0
	|-List<RaycastResult>.System.Collections.IList.Insert
	|
	|-RVA: 0x3237560 Offset: 0x3237661 VA: 0x3237560
	|-List<GradientAlphaKey>.System.Collections.IList.Insert
	|
	|-RVA: 0x323A790 Offset: 0x323A891 VA: 0x323A790
	|-List<GradientColorKey>.System.Collections.IList.Insert
	|
	|-RVA: 0x323DC20 Offset: 0x323DD21 VA: 0x323DC20
	|-List<Keyframe>.System.Collections.IList.Insert
	|
	|-RVA: 0x3240D80 Offset: 0x3240E81 VA: 0x3240D80
	|-List<LayerMask>.System.Collections.IList.Insert
	|
	|-RVA: 0x3244220 Offset: 0x3244321 VA: 0x3244220
	|-List<Matrix4x4>.System.Collections.IList.Insert
	|
	|-RVA: 0x3247780 Offset: 0x3247881 VA: 0x3247780
	|-List<ParticleSystem.Particle>.System.Collections.IList.Insert
	|
	|-RVA: 0x324A8F0 Offset: 0x324A9F1 VA: 0x324A8F0
	|-List<Playable>.System.Collections.IList.Insert
	|
	|-RVA: 0x324DB60 Offset: 0x324DC61 VA: 0x324DB60
	|-List<PlayableBinding>.System.Collections.IList.Insert
	|
	|-RVA: 0x3250CB0 Offset: 0x3250DB1 VA: 0x3250CB0
	|-List<PlayableGraph>.System.Collections.IList.Insert
	|
	|-RVA: 0x3253C80 Offset: 0x3253D81 VA: 0x3253C80
	|-List<Edge>.System.Collections.IList.Insert
	|
	|-RVA: 0x3256CC0 Offset: 0x3256DC1 VA: 0x3256CC0
	|-List<Quaternion>.System.Collections.IList.Insert
	|
	|-RVA: 0x3259CB0 Offset: 0x3259DB1 VA: 0x3259CB0
	|-List<RangeInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x325D050 Offset: 0x325D151 VA: 0x325D050
	|-List<RaycastHit2D>.System.Collections.IList.Insert
	|
	|-RVA: 0x32606A0 Offset: 0x32607A1 VA: 0x32606A0
	|-List<RaycastHit>.System.Collections.IList.Insert
	|
	|-RVA: 0x33C2100 Offset: 0x33C2201 VA: 0x33C2100
	|-List<Rect>.System.Collections.IList.Insert
	|
	|-RVA: 0x33C5130 Offset: 0x33C5231 VA: 0x33C5130
	|-List<RectInt>.System.Collections.IList.Insert
	|
	|-RVA: 0x33C8160 Offset: 0x33C8261 VA: 0x33C8160
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x33CBB10 Offset: 0x33CBC11 VA: 0x33CBB10
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Insert
	|
	|-RVA: 0x33CEEE0 Offset: 0x33CEFE1 VA: 0x33CEEE0
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Insert
	|
	|-RVA: 0x33D2140 Offset: 0x33D2241 VA: 0x33D2140
	|-List<AsyncOperationHandle>.System.Collections.IList.Insert
	|
	|-RVA: 0x33D54E0 Offset: 0x33D55E1 VA: 0x33D54E0
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Insert
	|
	|-RVA: 0x33D8A20 Offset: 0x33D8B21 VA: 0x33D8A20
	|-List<DiagnosticEvent>.System.Collections.IList.Insert
	|
	|-RVA: 0x33DBE50 Offset: 0x33DBF51 VA: 0x33DBE50
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x33DF390 Offset: 0x33DF491 VA: 0x33DF390
	|-List<ObjectInitializationData>.System.Collections.IList.Insert
	|
	|-RVA: 0x31BA4B0 Offset: 0x31BA5B1 VA: 0x31BA4B0
	|-List<GlyphRect>.System.Collections.IList.Insert
	|
	|-RVA: 0x31BD810 Offset: 0x31BD911 VA: 0x31BD810
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x31C0BC0 Offset: 0x31C0CC1 VA: 0x31C0BC0
	|-List<IntervalTreeNode>.System.Collections.IList.Insert
	|
	|-RVA: 0x31C3F40 Offset: 0x31C4041 VA: 0x31C3F40
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x31C72E0 Offset: 0x31C73E1 VA: 0x31C72E0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x31CA470 Offset: 0x31CA571 VA: 0x31CA470
	|-List<UICharInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x31CD4D0 Offset: 0x31CD5D1 VA: 0x31CD4D0
	|-List<FocusController.FocusedElement>.System.Collections.IList.Insert
	|
	|-RVA: 0x31D04F0 Offset: 0x31D05F1 VA: 0x31D04F0
	|-List<UILineInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x31D3C20 Offset: 0x31D3D21 VA: 0x31D3C20
	|-List<UIVertex>.System.Collections.IList.Insert
	|
	|-RVA: 0x31D7150 Offset: 0x31D7251 VA: 0x31D7150
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x31DA2B0 Offset: 0x31DA3B1 VA: 0x31DA2B0
	|-List<Vector2>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CE2E90 Offset: 0x2CE2F91 VA: 0x2CE2E90
	|-List<Vector2Int>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CE5EC0 Offset: 0x2CE5FC1 VA: 0x2CE5EC0
	|-List<Vector3>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CE8F40 Offset: 0x2CE9041 VA: 0x2CE8F40
	|-List<Vector3Int>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CEC010 Offset: 0x2CEC111 VA: 0x2CEC010
	|-List<Vector4>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CEF970 Offset: 0x2CEFA71 VA: 0x2CEF970
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CF2D10 Offset: 0x2CF2E11 VA: 0x2CF2D10
	|-List<YieldItemParam>.System.Collections.IList.Insert
	|
	|-RVA: 0x2CF5F50 Offset: 0x2CF6051 VA: 0x2CF5F50
	|-List<stCommand_t>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248E320 Offset: 0x248E421 VA: 0x248E320
	|-List<AS_ToolController.ChargeInfo>.InsertRange
	|
	|-RVA: 0x2491DE0 Offset: 0x2491EE1 VA: 0x2491DE0
	|-List<BuildItemData>.InsertRange
	|
	|-RVA: 0x3157790 Offset: 0x3157891 VA: 0x3157790
	|-List<ButtonLinker.LinkObject>.InsertRange
	|
	|-RVA: 0x315A7C0 Offset: 0x315A8C1 VA: 0x315A7C0
	|-List<CharaCallTable.BustupTable>.InsertRange
	|
	|-RVA: 0x315D810 Offset: 0x315D911 VA: 0x315D810
	|-List<CharaCallTable.CharaFaceIconTable>.InsertRange
	|
	|-RVA: 0x31608B0 Offset: 0x31609B1 VA: 0x31608B0
	|-List<CameraState.CustomBlendable>.InsertRange
	|
	|-RVA: 0x3163890 Offset: 0x3163991 VA: 0x3163890
	|-List<CinemachineClearShot.Pair>.InsertRange
	|
	|-RVA: 0x3166840 Offset: 0x3166941 VA: 0x3166840
	|-List<CinemachineStateDrivenCamera.HashPair>.InsertRange
	|
	|-RVA: 0x3169B90 Offset: 0x3169C91 VA: 0x3169B90
	|-List<TargetPositionCache.CacheCurve.Item>.InsertRange
	|
	|-RVA: 0x316D0D0 Offset: 0x316D1D1 VA: 0x316D0D0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.InsertRange
	|
	|-RVA: 0x31706A0 Offset: 0x31707A1 VA: 0x31706A0
	|-List<CropDataTable>.InsertRange
	|
	|-RVA: 0x3173800 Offset: 0x3173901 VA: 0x3173800
	|-List<DropItemParam>.InsertRange
	|
	|-RVA: 0x3176A50 Offset: 0x3176B51 VA: 0x3176A50
	|-List<ErosionBrush.UndoStep>.InsertRange
	|
	|-RVA: 0x31DD6D0 Offset: 0x31DD7D1 VA: 0x31DD6D0
	|-List<EventCheckId>.InsertRange
	|
	|-RVA: 0x31E0840 Offset: 0x31E0941 VA: 0x31E0840
	|-List<EventFlagProgressData>.InsertRange
	|
	|-RVA: 0x31E3890 Offset: 0x31E3991 VA: 0x31E3890
	|-List<FesNpcScoreData>.InsertRange
	|
	|-RVA: 0x31E6C80 Offset: 0x31E6D81 VA: 0x31E6C80
	|-List<MiningPointSaveData>.InsertRange
	|
	|-RVA: 0x31EA1A0 Offset: 0x31EA2A1 VA: 0x31EA1A0
	|-List<MonsterHutSaveData>.InsertRange
	|
	|-RVA: 0x31ED360 Offset: 0x31ED461 VA: 0x31ED360
	|-List<MoviePlayer.SUBTITLEDATA>.InsertRange
	|
	|-RVA: 0x31F0850 Offset: 0x31F0951 VA: 0x31F0850
	|-List<NPCActionData>.InsertRange
	|
	|-RVA: 0x31F3CA0 Offset: 0x31F3DA1 VA: 0x31F3CA0
	|-List<NpcPlaceSchedule>.InsertRange
	|
	|-RVA: 0x31F6E30 Offset: 0x31F6F31 VA: 0x31F6E30
	|-List<OrderLotterySaveParameter>.InsertRange
	|
	|-RVA: 0x31FA110 Offset: 0x31FA211 VA: 0x31FA110
	|-List<OrderSaveParameter>.InsertRange
	|
	|-RVA: 0x31FD280 Offset: 0x31FD381 VA: 0x31FD280
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.InsertRange
	|
	|-RVA: 0x330C4F0 Offset: 0x330C5F1 VA: 0x330C4F0
	|-List<ShopCatalogPage>.InsertRange
	|
	|-RVA: 0x330F910 Offset: 0x330FA11 VA: 0x330F910
	|-List<ShopNpcTalk>.InsertRange
	|
	|-RVA: 0x3312B10 Offset: 0x3312C11 VA: 0x3312B10
	|-List<SubtitleDataTable.Data>.InsertRange
	|
	|-RVA: 0x3315B60 Offset: 0x3315C61 VA: 0x3315B60
	|-List<SubtitleDataTable.DataList>.InsertRange
	|
	|-RVA: 0x3318BA0 Offset: 0x3318CA1 VA: 0x3318BA0
	|-List<SubtitleHudDataTable.Data>.InsertRange
	|
	|-RVA: 0x331BE80 Offset: 0x331BF81 VA: 0x331BE80
	|-List<SRMonoBehaviourEx.FieldInfo>.InsertRange
	|
	|-RVA: 0x331F1F0 Offset: 0x331F2F1 VA: 0x331F1F0
	|-List<Schedule>.InsertRange
	|
	|-RVA: 0x3322960 Offset: 0x3322A61 VA: 0x3322960
	|-List<CurveSample>.InsertRange
	|
	|-RVA: 0x3325BC0 Offset: 0x3325CC1 VA: 0x3325BC0
	|-List<bool>.InsertRange
	|
	|-RVA: 0x3328BA0 Offset: 0x3328CA1 VA: 0x3328BA0
	|-List<byte>.InsertRange
	|
	|-RVA: 0x332BB50 Offset: 0x332BC51 VA: 0x332BB50
	|-List<char>.InsertRange
	|
	|-RVA: 0x3359C00 Offset: 0x3359D01 VA: 0x3359C00
	|-List<KeyValuePair<DateTime, object>>.InsertRange
	|
	|-RVA: 0x335CC50 Offset: 0x335CD51 VA: 0x335CC50
	|-List<KeyValuePair<int, object>>.InsertRange
	|
	|-RVA: 0x335FCA0 Offset: 0x335FDA1 VA: 0x335FCA0
	|-List<KeyValuePair<object, object>>.InsertRange
	|
	|-RVA: 0x3362C80 Offset: 0x3362D81 VA: 0x3362C80
	|-List<DateTime>.InsertRange
	|
	|-RVA: 0x3365C30 Offset: 0x3365D31 VA: 0x3365C30
	|-List<double>.InsertRange
	|
	|-RVA: 0x3368BE0 Offset: 0x3368CE1 VA: 0x3368BE0
	|-List<short>.InsertRange
	|
	|-RVA: 0x336BB90 Offset: 0x336BC91 VA: 0x336BB90
	|-List<int>.InsertRange
	|
	|-RVA: 0x336EB40 Offset: 0x336EC41 VA: 0x336EB40
	|-List<Int32Enum>.InsertRange
	|
	|-RVA: 0x3371AF0 Offset: 0x3371BF1 VA: 0x3371AF0
	|-List<long>.InsertRange
	|
	|-RVA: 0x3374B00 Offset: 0x3374C01 VA: 0x3374B00
	|-List<InterpretedFrameInfo>.InsertRange
	|
	|-RVA: 0x3377B30 Offset: 0x3377C31 VA: 0x3377B30
	|-List<Nullable<Int32Enum>>.InsertRange
	|
	|-RVA: 0x3406BE0 Offset: 0x3406CE1 VA: 0x3406BE0
	|-List<Nullable<Bounds>>.InsertRange
	|
	|-RVA: 0x340A1A0 Offset: 0x340A2A1 VA: 0x340A1A0
	|-List<Nullable<BoundsInt>>.InsertRange
	|
	|-RVA: 0x340D340 Offset: 0x340D441 VA: 0x340D340
	|-List<Nullable<Color32>>.InsertRange
	|
	|-RVA: 0x3410630 Offset: 0x3410731 VA: 0x3410630
	|-List<Nullable<Color>>.InsertRange
	|
	|-RVA: 0x3413830 Offset: 0x3413931 VA: 0x3413830
	|-List<Nullable<GradientAlphaKey>>.InsertRange
	|
	|-RVA: 0x3416BB0 Offset: 0x3416CB1 VA: 0x3416BB0
	|-List<Nullable<GradientColorKey>>.InsertRange
	|
	|-RVA: 0x341A010 Offset: 0x341A111 VA: 0x341A010
	|-List<Nullable<Keyframe>>.InsertRange
	|
	|-RVA: 0x341D170 Offset: 0x341D271 VA: 0x341D170
	|-List<Nullable<LayerMask>>.InsertRange
	|
	|-RVA: 0x3420900 Offset: 0x3420A01 VA: 0x3420900
	|-List<Nullable<Matrix4x4>>.InsertRange
	|
	|-RVA: 0x3423EA0 Offset: 0x3423FA1 VA: 0x3423EA0
	|-List<Nullable<Quaternion>>.InsertRange
	|
	|-RVA: 0x3263B10 Offset: 0x3263C11 VA: 0x3263B10
	|-List<Nullable<RangeInt>>.InsertRange
	|
	|-RVA: 0x3266E90 Offset: 0x3266F91 VA: 0x3266E90
	|-List<Nullable<Rect>>.InsertRange
	|
	|-RVA: 0x326A2F0 Offset: 0x326A3F1 VA: 0x326A2F0
	|-List<Nullable<RectInt>>.InsertRange
	|
	|-RVA: 0x326D4F0 Offset: 0x326D5F1 VA: 0x326D4F0
	|-List<Nullable<Vector2>>.InsertRange
	|
	|-RVA: 0x3270610 Offset: 0x3270711 VA: 0x3270610
	|-List<Nullable<Vector2Int>>.InsertRange
	|
	|-RVA: 0x32736F0 Offset: 0x32737F1 VA: 0x32736F0
	|-List<Nullable<Vector3>>.InsertRange
	|
	|-RVA: 0x3276760 Offset: 0x3276861 VA: 0x3276760
	|-List<Nullable<Vector3Int>>.InsertRange
	|
	|-RVA: 0x3279A70 Offset: 0x3279B71 VA: 0x3279A70
	|-List<Nullable<Vector4>>.InsertRange
	|
	|-RVA: 0x327CB10 Offset: 0x327CC11 VA: 0x327CB10
	|-List<object>.InsertRange
	|-List<RegexNode>.InsertRange
	|
	|-RVA: 0x327FAE0 Offset: 0x327FBE1 VA: 0x327FAE0
	|-List<sbyte>.InsertRange
	|
	|-RVA: 0x3282A90 Offset: 0x3282B91 VA: 0x3282A90
	|-List<float>.InsertRange
	|
	|-RVA: 0x32A9CF0 Offset: 0x32A9DF1 VA: 0x32A9CF0
	|-List<ushort>.InsertRange
	|
	|-RVA: 0x32ACCA0 Offset: 0x32ACDA1 VA: 0x32ACCA0
	|-List<uint>.InsertRange
	|
	|-RVA: 0x32AFC50 Offset: 0x32AFD51 VA: 0x32AFC50
	|-List<ulong>.InsertRange
	|
	|-RVA: 0x32B2C00 Offset: 0x32B2D01 VA: 0x32B2C00
	|-List<ValueTuple<bool, Int32Enum>>.InsertRange
	|
	|-RVA: 0x32B5BB0 Offset: 0x32B5CB1 VA: 0x32B5BB0
	|-List<ValueTuple<Int32Enum, int>>.InsertRange
	|
	|-RVA: 0x32B8BC0 Offset: 0x32B8CC1 VA: 0x32B8BC0
	|-List<ValueTuple<Int32Enum, object>>.InsertRange
	|
	|-RVA: 0x32BBC10 Offset: 0x32BBD11 VA: 0x32BBC10
	|-List<ValueTuple<object, Int32Enum>>.InsertRange
	|
	|-RVA: 0x32BEC50 Offset: 0x32BED51 VA: 0x32BEC50
	|-List<ValueTuple<object, object>>.InsertRange
	|
	|-RVA: 0x32C1C90 Offset: 0x32C1D91 VA: 0x32C1C90
	|-List<ValueTuple<object, float>>.InsertRange
	|
	|-RVA: 0x32C4CF0 Offset: 0x32C4DF1 VA: 0x32C4CF0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.InsertRange
	|
	|-RVA: 0x32C8250 Offset: 0x32C8351 VA: 0x32C8250
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.InsertRange
	|
	|-RVA: 0x3111EB0 Offset: 0x3111FB1 VA: 0x3111EB0
	|-List<TexturePacker_JsonArray.Frame>.InsertRange
	|
	|-RVA: 0x3115100 Offset: 0x3115201 VA: 0x3115100
	|-List<TutorialUnlockFlagData>.InsertRange
	|
	|-RVA: 0x31181A0 Offset: 0x31182A1 VA: 0x31181A0
	|-List<UIMainManagerAttachObject.AttachSet>.InsertRange
	|
	|-RVA: 0x311B590 Offset: 0x311B691 VA: 0x311B590
	|-List<CapEdge>.InsertRange
	|
	|-RVA: 0x311E6F0 Offset: 0x311E7F1 VA: 0x311E6F0
	|-List<MeshDataConnectivity.Face>.InsertRange
	|
	|-RVA: 0x3121900 Offset: 0x3121A01 VA: 0x3121900
	|-List<MeshFaceConnectivity.EdgeData.SideData>.InsertRange
	|
	|-RVA: 0x3124E30 Offset: 0x3124F31 VA: 0x3124E30
	|-List<MeshFaceConnectivity.EdgeData>.InsertRange
	|
	|-RVA: 0x3127FF0 Offset: 0x31280F1 VA: 0x3127FF0
	|-List<NavMeshBuildMarkup>.InsertRange
	|
	|-RVA: 0x312B8A0 Offset: 0x312B9A1 VA: 0x312B8A0
	|-List<NavMeshBuildSource>.InsertRange
	|
	|-RVA: 0x312EBF0 Offset: 0x312ECF1 VA: 0x312EBF0
	|-List<ConstraintSource>.InsertRange
	|
	|-RVA: 0x3131BD0 Offset: 0x3131CD1 VA: 0x3131BD0
	|-List<AnimatorClipInfo>.InsertRange
	|
	|-RVA: 0x321D7C0 Offset: 0x321D8C1 VA: 0x321D7C0
	|-List<BeforeRenderHelper.OrderBlock>.InsertRange
	|
	|-RVA: 0x3220A20 Offset: 0x3220B21 VA: 0x3220A20
	|-List<BoneWeight>.InsertRange
	|
	|-RVA: 0x3223D70 Offset: 0x3223E71 VA: 0x3223D70
	|-List<Bounds>.InsertRange
	|
	|-RVA: 0x32270C0 Offset: 0x32271C1 VA: 0x32270C0
	|-List<BoundsInt>.InsertRange
	|
	|-RVA: 0x322A1C0 Offset: 0x322A2C1 VA: 0x322A1C0
	|-List<Color32>.InsertRange
	|
	|-RVA: 0x322D210 Offset: 0x322D311 VA: 0x322D210
	|-List<Color>.InsertRange
	|
	|-RVA: 0x3230B00 Offset: 0x3230C01 VA: 0x3230B00
	|-List<CombineInstance>.InsertRange
	|
	|-RVA: 0x3234490 Offset: 0x3234591 VA: 0x3234490
	|-List<RaycastResult>.InsertRange
	|
	|-RVA: 0x3237720 Offset: 0x3237821 VA: 0x3237720
	|-List<GradientAlphaKey>.InsertRange
	|
	|-RVA: 0x323A950 Offset: 0x323AA51 VA: 0x323A950
	|-List<GradientColorKey>.InsertRange
	|
	|-RVA: 0x323DDF0 Offset: 0x323DEF1 VA: 0x323DDF0
	|-List<Keyframe>.InsertRange
	|
	|-RVA: 0x3240F40 Offset: 0x3241041 VA: 0x3240F40
	|-List<LayerMask>.InsertRange
	|
	|-RVA: 0x32443F0 Offset: 0x32444F1 VA: 0x32443F0
	|-List<Matrix4x4>.InsertRange
	|
	|-RVA: 0x3247940 Offset: 0x3247A41 VA: 0x3247940
	|-List<ParticleSystem.Particle>.InsertRange
	|
	|-RVA: 0x324AAB0 Offset: 0x324ABB1 VA: 0x324AAB0
	|-List<Playable>.InsertRange
	|
	|-RVA: 0x324DD20 Offset: 0x324DE21 VA: 0x324DD20
	|-List<PlayableBinding>.InsertRange
	|
	|-RVA: 0x3250E70 Offset: 0x3250F71 VA: 0x3250E70
	|-List<PlayableGraph>.InsertRange
	|
	|-RVA: 0x3253E40 Offset: 0x3253F41 VA: 0x3253E40
	|-List<Edge>.InsertRange
	|
	|-RVA: 0x3256E80 Offset: 0x3256F81 VA: 0x3256E80
	|-List<Quaternion>.InsertRange
	|
	|-RVA: 0x3259E70 Offset: 0x3259F71 VA: 0x3259E70
	|-List<RangeInt>.InsertRange
	|
	|-RVA: 0x325D220 Offset: 0x325D321 VA: 0x325D220
	|-List<RaycastHit2D>.InsertRange
	|
	|-RVA: 0x3260870 Offset: 0x3260971 VA: 0x3260870
	|-List<RaycastHit>.InsertRange
	|
	|-RVA: 0x33C22C0 Offset: 0x33C23C1 VA: 0x33C22C0
	|-List<Rect>.InsertRange
	|
	|-RVA: 0x33C52F0 Offset: 0x33C53F1 VA: 0x33C52F0
	|-List<RectInt>.InsertRange
	|
	|-RVA: 0x33C8320 Offset: 0x33C8421 VA: 0x33C8320
	|-List<ReflectionProbeBlendInfo>.InsertRange
	|
	|-RVA: 0x33CBD00 Offset: 0x33CBE01 VA: 0x33CBD00
	|-List<SphericalHarmonicsL2>.InsertRange
	|
	|-RVA: 0x33CF0A0 Offset: 0x33CF1A1 VA: 0x33CF0A0
	|-List<VertexAttributeDescriptor>.InsertRange
	|
	|-RVA: 0x33D2300 Offset: 0x33D2401 VA: 0x33D2300
	|-List<AsyncOperationHandle>.InsertRange
	|
	|-RVA: 0x33D56A0 Offset: 0x33D57A1 VA: 0x33D56A0
	|-List<AsyncOperationHandle<SceneInstance>>.InsertRange
	|
	|-RVA: 0x33D8BF0 Offset: 0x33D8CF1 VA: 0x33D8BF0
	|-List<DiagnosticEvent>.InsertRange
	|
	|-RVA: 0x33DC010 Offset: 0x33DC111 VA: 0x33DC010
	|-List<DelayedActionManager.DelegateInfo>.InsertRange
	|
	|-RVA: 0x33DF560 Offset: 0x33DF661 VA: 0x33DF560
	|-List<ObjectInitializationData>.InsertRange
	|
	|-RVA: 0x31BA670 Offset: 0x31BA771 VA: 0x31BA670
	|-List<GlyphRect>.InsertRange
	|
	|-RVA: 0x31BD9E0 Offset: 0x31BDAE1 VA: 0x31BD9E0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.InsertRange
	|
	|-RVA: 0x31C0D80 Offset: 0x31C0E81 VA: 0x31C0D80
	|-List<IntervalTreeNode>.InsertRange
	|
	|-RVA: 0x31C4100 Offset: 0x31C4201 VA: 0x31C4100
	|-List<IntervalTree.Entry<object>>.InsertRange
	|
	|-RVA: 0x31C74A0 Offset: 0x31C75A1 VA: 0x31C74A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.InsertRange
	|
	|-RVA: 0x31CA630 Offset: 0x31CA731 VA: 0x31CA630
	|-List<UICharInfo>.InsertRange
	|
	|-RVA: 0x31CD690 Offset: 0x31CD791 VA: 0x31CD690
	|-List<FocusController.FocusedElement>.InsertRange
	|
	|-RVA: 0x31D06B0 Offset: 0x31D07B1 VA: 0x31D06B0
	|-List<UILineInfo>.InsertRange
	|
	|-RVA: 0x31D3E00 Offset: 0x31D3F01 VA: 0x31D3E00
	|-List<UIVertex>.InsertRange
	|
	|-RVA: 0x31D7310 Offset: 0x31D7411 VA: 0x31D7310
	|-List<UnitySynchronizationContext.WorkRequest>.InsertRange
	|
	|-RVA: 0x31DA470 Offset: 0x31DA571 VA: 0x31DA470
	|-List<Vector2>.InsertRange
	|
	|-RVA: 0x2CE3050 Offset: 0x2CE3151 VA: 0x2CE3050
	|-List<Vector2Int>.InsertRange
	|
	|-RVA: 0x2CE6080 Offset: 0x2CE6181 VA: 0x2CE6080
	|-List<Vector3>.InsertRange
	|
	|-RVA: 0x2CE9100 Offset: 0x2CE9201 VA: 0x2CE9100
	|-List<Vector3Int>.InsertRange
	|
	|-RVA: 0x2CEC1D0 Offset: 0x2CEC2D1 VA: 0x2CEC1D0
	|-List<Vector4>.InsertRange
	|
	|-RVA: 0x2CEFB60 Offset: 0x2CEFC61 VA: 0x2CEFB60
	|-List<WarpPoints.WarpPoint>.InsertRange
	|
	|-RVA: 0x2CF2ED0 Offset: 0x2CF2FD1 VA: 0x2CF2ED0
	|-List<YieldItemParam>.InsertRange
	|
	|-RVA: 0x2CF6110 Offset: 0x2CF6211 VA: 0x2CF6110
	|-List<stCommand_t>.InsertRange
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327D110 Offset: 0x327D211 VA: 0x327D110
	|-List<AIInput>.Remove
	|-List<Actor>.Remove
	|-List<AdvShowOneImage.AdvSpriteLoader>.Remove
	|-List<AdvShowOneImage>.Remove
	|-List<AracneFlatWeb>.Remove
	|-List<AudmuraCrystal>.Remove
	|-List<AutomaticLOD>.Remove
	|-List<BehaviorManager.BehaviorTree>.Remove
	|-List<TaskCoroutine>.Remove
	|-List<BehaviorTreeManager.EnemyBehaviorParameter>.Remove
	|-List<BulletBase>.Remove
	|-List<Character>.Remove
	|-List<CinemachineBrain>.Remove
	|-List<CinemachineExtension>.Remove
	|-List<CinemachineVirtualCameraBase>.Remove
	|-List<CursorEvent>.Remove
	|-List<Tween>.Remove
	|-List<TweenCallback>.Remove
	|-List<DamageText>.Remove
	|-List<EnvironmentSoundArea>.Remove
	|-List<EraseObject>.Remove
	|-List<EventUnlockFlagData>.Remove
	|-List<FarmSupportMonsterController>.Remove
	|-List<FarmSupportMonsterManager.OrderFarmInParameter>.Remove
	|-List<ObjectLoader>.Remove
	|-List<FracturedChunk.AdjacencyInfo>.Remove
	|-List<FracturedChunk>.Remove
	|-List<FriendJudgmentManager.FriendJudgmentMonster>.Remove
	|-List<FriendMonsterManager.FarmInActorData>.Remove
	|-List<FriendMonsterStatusData>.Remove
	|-List<LightningSpawnArea>.Remove
	|-List<WeatherEnclosure>.Remove
	|-List<HUDDualWorkSelectInput.DualSelect>.Remove
	|-List<HasibirokouSonicWind>.Remove
	|-List<ItemDataLinker>.Remove
	|-List<PlayerItemFurniture2>.Remove
	|-List<ItemIconMng.ImageLoaderObj>.Remove
	|-List<ItemTool>.Remove
	|-List<LastBossBone>.Remove
	|-List<AssetHandle>.Remove
	|-List<AssetInfo>.Remove
	|-List<MeshSimplify>.Remove
	|-List<MobBrain>.Remove
	|-List<MonsterControllerBase>.Remove
	|-List<MonsterHutController.OrderFarmInParameter>.Remove
	|-List<MonsterProjectileActionScriptsController>.Remove
	|-List<NpcController>.Remove
	|-List<OrderData>.Remove
	|-List<OrderHUDBlock>.Remove
	|-List<PartnerManager.NPCChangeBaseParameter>.Remove
	|-List<DelaunayTriangle>.Remove
	|-List<Point2D>.Remove
	|-List<SplitComplexPolygonNode>.Remove
	|-List<PreloadHandle>.Remove
	|-List<SubtitleHandler>.Remove
	|-List<ReviatanIcePillar>.Remove
	|-List<InteractionTrigger>.Remove
	|-List<OptionDefinition>.Remove
	|-List<OptionsControlBase>.Remove
	|-List<SceneSplit>.Remove
	|-List<SceneTransitionManager.SceneGameObjectEnabled>.Remove
	|-List<CubicBezierCurve>.Remove
	|-List<Streamer>.Remove
	|-List<SubEventData>.Remove
	|-List<LocalDataStore>.Remove
	|-List<object>.Remove
	|-List<string>.Remove
	|-List<string[]>.Remove
	|-List<Thread>.Remove
	|-List<TimeZoneInfo.AdjustmentRule>.Remove
	|-List<SystemTextDisp>.Remove
	|-List<TMP_Text>.Remove
	|-List<TimeManager.JustTimerData>.Remove
	|-List<UIOnOffAnimate>.Remove
	|-List<Simplifier.Triangle>.Remove
	|-List<Simplifier.Vertex>.Remove
	|-List<NavMeshLink>.Remove
	|-List<NavMeshModifier>.Remove
	|-List<NavMeshModifierVolume>.Remove
	|-List<NavMeshSurface>.Remove
	|-List<Collider>.Remove
	|-List<BaseRaycaster>.Remove
	|-List<EventSystem>.Remove
	|-List<GameObject>.Remove
	|-List<Light>.Remove
	|-List<PlayerEditorConnectionEvents.MessageTypeSubscribers>.Remove
	|-List<UnityWebRequestAsyncOperation>.Remove
	|-List<ParticleSystem>.Remove
	|-List<RenderTexture>.Remove
	|-List<AsyncOperationHandle<SceneInstance>[]>.Remove
	|-List<ScriptableObject>.Remove
	|-List<Sprite>.Remove
	|-List<Terrain>.Remove
	|-List<TimelineClip>.Remove
	|-List<Transform>.Remove
	|-List<ICanvasElement>.Remove
	|-List<Image>.Remove
	|-List<Toggle>.Remove
	|
	|-RVA: 0x248E980 Offset: 0x248EA81 VA: 0x248E980
	|-List<AS_ToolController.ChargeInfo>.Remove
	|
	|-RVA: 0x2492480 Offset: 0x2492581 VA: 0x2492480
	|-List<BuildItemData>.Remove
	|
	|-RVA: 0x3157D90 Offset: 0x3157E91 VA: 0x3157D90
	|-List<ButtonLinker.LinkObject>.Remove
	|
	|-RVA: 0x315ADC0 Offset: 0x315AEC1 VA: 0x315ADC0
	|-List<CharaCallTable.BustupTable>.Remove
	|
	|-RVA: 0x315DE20 Offset: 0x315DF21 VA: 0x315DE20
	|-List<CharaCallTable.CharaFaceIconTable>.Remove
	|
	|-RVA: 0x3160EB0 Offset: 0x3160FB1 VA: 0x3160EB0
	|-List<CameraState.CustomBlendable>.Remove
	|
	|-RVA: 0x3163E90 Offset: 0x3163F91 VA: 0x3163E90
	|-List<CinemachineClearShot.Pair>.Remove
	|
	|-RVA: 0x3166E40 Offset: 0x3166F41 VA: 0x3166E40
	|-List<CinemachineStateDrivenCamera.HashPair>.Remove
	|
	|-RVA: 0x316A200 Offset: 0x316A301 VA: 0x316A200
	|-List<TargetPositionCache.CacheCurve.Item>.Remove
	|
	|-RVA: 0x316D740 Offset: 0x316D841 VA: 0x316D740
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Remove
	|
	|-RVA: 0x3170D10 Offset: 0x3170E11 VA: 0x3170D10
	|-List<CropDataTable>.Remove
	|
	|-RVA: 0x336F140 Offset: 0x336F241 VA: 0x336F140
	|-List<BadStatus>.Remove
	|-List<EmotionType>.Remove
	|-List<FarmFieldWorkArea>.Remove
	|-List<PoliceBatchId>.Remove
	|-List<RecipeId>.Remove
	|-List<Int32Enum>.Remove
	|-List<ParticleSystemVertexStream>.Remove
	|
	|-RVA: 0x3173E00 Offset: 0x3173F01 VA: 0x3173E00
	|-List<DropItemParam>.Remove
	|
	|-RVA: 0x31770B0 Offset: 0x31771B1 VA: 0x31770B0
	|-List<ErosionBrush.UndoStep>.Remove
	|
	|-RVA: 0x31DDD30 Offset: 0x31DDE31 VA: 0x31DDD30
	|-List<EventCheckId>.Remove
	|
	|-RVA: 0x31E0E40 Offset: 0x31E0F41 VA: 0x31E0E40
	|-List<EventFlagProgressData>.Remove
	|
	|-RVA: 0x31E3E90 Offset: 0x31E3F91 VA: 0x31E3E90
	|-List<FesNpcScoreData>.Remove
	|
	|-RVA: 0x31E72F0 Offset: 0x31E73F1 VA: 0x31E72F0
	|-List<MiningPointSaveData>.Remove
	|
	|-RVA: 0x31EA810 Offset: 0x31EA911 VA: 0x31EA810
	|-List<MonsterHutSaveData>.Remove
	|
	|-RVA: 0x31ED960 Offset: 0x31EDA61 VA: 0x31ED960
	|-List<MoviePlayer.SUBTITLEDATA>.Remove
	|
	|-RVA: 0x31F0EC0 Offset: 0x31F0FC1 VA: 0x31F0EC0
	|-List<NPCActionData>.Remove
	|
	|-RVA: 0x31F4300 Offset: 0x31F4401 VA: 0x31F4300
	|-List<NpcPlaceSchedule>.Remove
	|
	|-RVA: 0x31F7440 Offset: 0x31F7541 VA: 0x31F7440
	|-List<OrderLotterySaveParameter>.Remove
	|
	|-RVA: 0x31FA770 Offset: 0x31FA871 VA: 0x31FA770
	|-List<OrderSaveParameter>.Remove
	|
	|-RVA: 0x31FD880 Offset: 0x31FD981 VA: 0x31FD880
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Remove
	|
	|-RVA: 0x330CAF0 Offset: 0x330CBF1 VA: 0x330CAF0
	|-List<ShopCatalogPage>.Remove
	|
	|-RVA: 0x330FF80 Offset: 0x3310081 VA: 0x330FF80
	|-List<ShopNpcTalk>.Remove
	|
	|-RVA: 0x3313120 Offset: 0x3313221 VA: 0x3313120
	|-List<SubtitleDataTable.Data>.Remove
	|
	|-RVA: 0x3316160 Offset: 0x3316261 VA: 0x3316160
	|-List<SubtitleDataTable.DataList>.Remove
	|
	|-RVA: 0x33191B0 Offset: 0x33192B1 VA: 0x33191B0
	|-List<SubtitleHudDataTable.Data>.Remove
	|
	|-RVA: 0x331C4E0 Offset: 0x331C5E1 VA: 0x331C4E0
	|-List<SRMonoBehaviourEx.FieldInfo>.Remove
	|
	|-RVA: 0x331F850 Offset: 0x331F951 VA: 0x331F850
	|-List<Schedule>.Remove
	|
	|-RVA: 0x3322FE0 Offset: 0x33230E1 VA: 0x3322FE0
	|-List<CurveSample>.Remove
	|
	|-RVA: 0x33261C0 Offset: 0x33262C1 VA: 0x33261C0
	|-List<bool>.Remove
	|
	|-RVA: 0x33291A0 Offset: 0x33292A1 VA: 0x33291A0
	|-List<byte>.Remove
	|
	|-RVA: 0x332C150 Offset: 0x332C251 VA: 0x332C150
	|-List<char>.Remove
	|
	|-RVA: 0x335A200 Offset: 0x335A301 VA: 0x335A200
	|-List<KeyValuePair<DateTime, object>>.Remove
	|
	|-RVA: 0x335D250 Offset: 0x335D351 VA: 0x335D250
	|-List<KeyValuePair<int, object>>.Remove
	|
	|-RVA: 0x33602A0 Offset: 0x33603A1 VA: 0x33602A0
	|-List<KeyValuePair<object, object>>.Remove
	|
	|-RVA: 0x3363280 Offset: 0x3363381 VA: 0x3363280
	|-List<DateTime>.Remove
	|
	|-RVA: 0x3366230 Offset: 0x3366331 VA: 0x3366230
	|-List<double>.Remove
	|
	|-RVA: 0x33691E0 Offset: 0x33692E1 VA: 0x33691E0
	|-List<short>.Remove
	|
	|-RVA: 0x336C190 Offset: 0x336C291 VA: 0x336C190
	|-List<int>.Remove
	|
	|-RVA: 0x33720F0 Offset: 0x33721F1 VA: 0x33720F0
	|-List<long>.Remove
	|
	|-RVA: 0x3375100 Offset: 0x3375201 VA: 0x3375100
	|-List<InterpretedFrameInfo>.Remove
	|
	|-RVA: 0x3378130 Offset: 0x3378231 VA: 0x3378130
	|-List<Nullable<Int32Enum>>.Remove
	|
	|-RVA: 0x3407250 Offset: 0x3407351 VA: 0x3407250
	|-List<Nullable<Bounds>>.Remove
	|
	|-RVA: 0x340A810 Offset: 0x340A911 VA: 0x340A810
	|-List<Nullable<BoundsInt>>.Remove
	|
	|-RVA: 0x340D940 Offset: 0x340DA41 VA: 0x340D940
	|-List<Nullable<Color32>>.Remove
	|
	|-RVA: 0x3410C90 Offset: 0x3410D91 VA: 0x3410C90
	|-List<Nullable<Color>>.Remove
	|
	|-RVA: 0x3413E40 Offset: 0x3413F41 VA: 0x3413E40
	|-List<Nullable<GradientAlphaKey>>.Remove
	|
	|-RVA: 0x3417210 Offset: 0x3417311 VA: 0x3417210
	|-List<Nullable<GradientColorKey>>.Remove
	|
	|-RVA: 0x341A670 Offset: 0x341A771 VA: 0x341A670
	|-List<Nullable<Keyframe>>.Remove
	|
	|-RVA: 0x341D770 Offset: 0x341D871 VA: 0x341D770
	|-List<Nullable<LayerMask>>.Remove
	|
	|-RVA: 0x3420F80 Offset: 0x3421081 VA: 0x3420F80
	|-List<Nullable<Matrix4x4>>.Remove
	|
	|-RVA: 0x3424500 Offset: 0x3424601 VA: 0x3424500
	|-List<Nullable<Quaternion>>.Remove
	|
	|-RVA: 0x3264120 Offset: 0x3264221 VA: 0x3264120
	|-List<Nullable<RangeInt>>.Remove
	|
	|-RVA: 0x32674F0 Offset: 0x32675F1 VA: 0x32674F0
	|-List<Nullable<Rect>>.Remove
	|
	|-RVA: 0x326A950 Offset: 0x326AA51 VA: 0x326A950
	|-List<Nullable<RectInt>>.Remove
	|
	|-RVA: 0x326DB00 Offset: 0x326DC01 VA: 0x326DB00
	|-List<Nullable<Vector2>>.Remove
	|
	|-RVA: 0x3270C20 Offset: 0x3270D21 VA: 0x3270C20
	|-List<Nullable<Vector2Int>>.Remove
	|
	|-RVA: 0x3273CF0 Offset: 0x3273DF1 VA: 0x3273CF0
	|-List<Nullable<Vector3>>.Remove
	|
	|-RVA: 0x3276D60 Offset: 0x3276E61 VA: 0x3276D60
	|-List<Nullable<Vector3Int>>.Remove
	|
	|-RVA: 0x327A0D0 Offset: 0x327A1D1 VA: 0x327A0D0
	|-List<Nullable<Vector4>>.Remove
	|
	|-RVA: 0x32800E0 Offset: 0x32801E1 VA: 0x32800E0
	|-List<sbyte>.Remove
	|
	|-RVA: 0x3283090 Offset: 0x3283191 VA: 0x3283090
	|-List<float>.Remove
	|
	|-RVA: 0x32AA2F0 Offset: 0x32AA3F1 VA: 0x32AA2F0
	|-List<ushort>.Remove
	|
	|-RVA: 0x32AD2A0 Offset: 0x32AD3A1 VA: 0x32AD2A0
	|-List<uint>.Remove
	|
	|-RVA: 0x32B0250 Offset: 0x32B0351 VA: 0x32B0250
	|-List<ulong>.Remove
	|
	|-RVA: 0x32B3200 Offset: 0x32B3301 VA: 0x32B3200
	|-List<ValueTuple<bool, Int32Enum>>.Remove
	|
	|-RVA: 0x32B61B0 Offset: 0x32B62B1 VA: 0x32B61B0
	|-List<ValueTuple<Int32Enum, int>>.Remove
	|
	|-RVA: 0x32B91C0 Offset: 0x32B92C1 VA: 0x32B91C0
	|-List<ValueTuple<Int32Enum, object>>.Remove
	|
	|-RVA: 0x32BC210 Offset: 0x32BC311 VA: 0x32BC210
	|-List<ValueTuple<object, Int32Enum>>.Remove
	|
	|-RVA: 0x32BF250 Offset: 0x32BF351 VA: 0x32BF250
	|-List<ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x32C2290 Offset: 0x32C2391 VA: 0x32C2290
	|-List<ValueTuple<object, float>>.Remove
	|
	|-RVA: 0x32C5300 Offset: 0x32C5401 VA: 0x32C5300
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Remove
	|
	|-RVA: 0x32C88C0 Offset: 0x32C89C1 VA: 0x32C88C0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Remove
	|
	|-RVA: 0x3112520 Offset: 0x3112621 VA: 0x3112520
	|-List<TexturePacker_JsonArray.Frame>.Remove
	|
	|-RVA: 0x3115710 Offset: 0x3115811 VA: 0x3115710
	|-List<TutorialUnlockFlagData>.Remove
	|
	|-RVA: 0x31187A0 Offset: 0x31188A1 VA: 0x31187A0
	|-List<UIMainManagerAttachObject.AttachSet>.Remove
	|
	|-RVA: 0x311BC00 Offset: 0x311BD01 VA: 0x311BC00
	|-List<CapEdge>.Remove
	|
	|-RVA: 0x311ECF0 Offset: 0x311EDF1 VA: 0x311ECF0
	|-List<MeshDataConnectivity.Face>.Remove
	|
	|-RVA: 0x3121F60 Offset: 0x3122061 VA: 0x3121F60
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Remove
	|
	|-RVA: 0x31254A0 Offset: 0x31255A1 VA: 0x31254A0
	|-List<MeshFaceConnectivity.EdgeData>.Remove
	|
	|-RVA: 0x31285F0 Offset: 0x31286F1 VA: 0x31285F0
	|-List<NavMeshBuildMarkup>.Remove
	|
	|-RVA: 0x312BF30 Offset: 0x312C031 VA: 0x312BF30
	|-List<NavMeshBuildSource>.Remove
	|
	|-RVA: 0x312F1F0 Offset: 0x312F2F1 VA: 0x312F1F0
	|-List<ConstraintSource>.Remove
	|
	|-RVA: 0x31321D0 Offset: 0x31322D1 VA: 0x31321D0
	|-List<AnimatorClipInfo>.Remove
	|
	|-RVA: 0x321DDC0 Offset: 0x321DEC1 VA: 0x321DDC0
	|-List<BeforeRenderHelper.OrderBlock>.Remove
	|
	|-RVA: 0x3221080 Offset: 0x3221181 VA: 0x3221080
	|-List<BoneWeight>.Remove
	|
	|-RVA: 0x32243D0 Offset: 0x32244D1 VA: 0x32243D0
	|-List<Bounds>.Remove
	|
	|-RVA: 0x3227720 Offset: 0x3227821 VA: 0x3227720
	|-List<BoundsInt>.Remove
	|
	|-RVA: 0x322A7C0 Offset: 0x322A8C1 VA: 0x322A7C0
	|-List<Color32>.Remove
	|
	|-RVA: 0x322D810 Offset: 0x322D911 VA: 0x322D810
	|-List<Color>.Remove
	|
	|-RVA: 0x3231190 Offset: 0x3231291 VA: 0x3231190
	|-List<CombineInstance>.Remove
	|
	|-RVA: 0x3234B10 Offset: 0x3234C11 VA: 0x3234B10
	|-List<RaycastResult>.Remove
	|
	|-RVA: 0x3237D20 Offset: 0x3237E21 VA: 0x3237D20
	|-List<GradientAlphaKey>.Remove
	|
	|-RVA: 0x323AFB0 Offset: 0x323B0B1 VA: 0x323AFB0
	|-List<GradientColorKey>.Remove
	|
	|-RVA: 0x323E460 Offset: 0x323E561 VA: 0x323E460
	|-List<Keyframe>.Remove
	|
	|-RVA: 0x3241540 Offset: 0x3241641 VA: 0x3241540
	|-List<LayerMask>.Remove
	|
	|-RVA: 0x3244A60 Offset: 0x3244B61 VA: 0x3244A60
	|-List<Matrix4x4>.Remove
	|
	|-RVA: 0x3247FB0 Offset: 0x32480B1 VA: 0x3247FB0
	|-List<ParticleSystem.Particle>.Remove
	|
	|-RVA: 0x324B0B0 Offset: 0x324B1B1 VA: 0x324B0B0
	|-List<Playable>.Remove
	|
	|-RVA: 0x324E380 Offset: 0x324E481 VA: 0x324E380
	|-List<PlayableBinding>.Remove
	|
	|-RVA: 0x3251470 Offset: 0x3251571 VA: 0x3251470
	|-List<PlayableGraph>.Remove
	|
	|-RVA: 0x3254440 Offset: 0x3254541 VA: 0x3254440
	|-List<Edge>.Remove
	|
	|-RVA: 0x3257480 Offset: 0x3257581 VA: 0x3257480
	|-List<Quaternion>.Remove
	|
	|-RVA: 0x325A470 Offset: 0x325A571 VA: 0x325A470
	|-List<RangeInt>.Remove
	|
	|-RVA: 0x325D890 Offset: 0x325D991 VA: 0x325D890
	|-List<RaycastHit2D>.Remove
	|
	|-RVA: 0x3260EE0 Offset: 0x3260FE1 VA: 0x3260EE0
	|-List<RaycastHit>.Remove
	|
	|-RVA: 0x33C28C0 Offset: 0x33C29C1 VA: 0x33C28C0
	|-List<Rect>.Remove
	|
	|-RVA: 0x33C58F0 Offset: 0x33C59F1 VA: 0x33C58F0
	|-List<RectInt>.Remove
	|
	|-RVA: 0x33C8920 Offset: 0x33C8A21 VA: 0x33C8920
	|-List<ReflectionProbeBlendInfo>.Remove
	|
	|-RVA: 0x33CC3A0 Offset: 0x33CC4A1 VA: 0x33CC3A0
	|-List<SphericalHarmonicsL2>.Remove
	|
	|-RVA: 0x33CF6A0 Offset: 0x33CF7A1 VA: 0x33CF6A0
	|-List<VertexAttributeDescriptor>.Remove
	|
	|-RVA: 0x33D2960 Offset: 0x33D2A61 VA: 0x33D2960
	|-List<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x33D5D00 Offset: 0x33D5E01 VA: 0x33D5D00
	|-List<AsyncOperationHandle<SceneInstance>>.Remove
	|
	|-RVA: 0x33D9260 Offset: 0x33D9361 VA: 0x33D9260
	|-List<DiagnosticEvent>.Remove
	|
	|-RVA: 0x33DC670 Offset: 0x33DC771 VA: 0x33DC670
	|-List<DelayedActionManager.DelegateInfo>.Remove
	|
	|-RVA: 0x33DFBD0 Offset: 0x33DFCD1 VA: 0x33DFBD0
	|-List<ObjectInitializationData>.Remove
	|
	|-RVA: 0x31BAC70 Offset: 0x31BAD71 VA: 0x31BAC70
	|-List<GlyphRect>.Remove
	|
	|-RVA: 0x31BE050 Offset: 0x31BE151 VA: 0x31BE050
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Remove
	|
	|-RVA: 0x31C13E0 Offset: 0x31C14E1 VA: 0x31C13E0
	|-List<IntervalTreeNode>.Remove
	|
	|-RVA: 0x31C4760 Offset: 0x31C4861 VA: 0x31C4760
	|-List<IntervalTree.Entry<object>>.Remove
	|
	|-RVA: 0x31C7B00 Offset: 0x31C7C01 VA: 0x31C7B00
	|-List<TimeNotificationBehaviour.NotificationEntry>.Remove
	|
	|-RVA: 0x31CAC30 Offset: 0x31CAD31 VA: 0x31CAC30
	|-List<UICharInfo>.Remove
	|
	|-RVA: 0x31CDC90 Offset: 0x31CDD91 VA: 0x31CDC90
	|-List<FocusController.FocusedElement>.Remove
	|
	|-RVA: 0x31D0CB0 Offset: 0x31D0DB1 VA: 0x31D0CB0
	|-List<UILineInfo>.Remove
	|
	|-RVA: 0x31D4480 Offset: 0x31D4581 VA: 0x31D4480
	|-List<UIVertex>.Remove
	|
	|-RVA: 0x31D7970 Offset: 0x31D7A71 VA: 0x31D7970
	|-List<UnitySynchronizationContext.WorkRequest>.Remove
	|
	|-RVA: 0x31DAA70 Offset: 0x31DAB71 VA: 0x31DAA70
	|-List<Vector2>.Remove
	|
	|-RVA: 0x2CE3650 Offset: 0x2CE3751 VA: 0x2CE3650
	|-List<Vector2Int>.Remove
	|
	|-RVA: 0x2CE6680 Offset: 0x2CE6781 VA: 0x2CE6680
	|-List<Vector3>.Remove
	|
	|-RVA: 0x2CE9710 Offset: 0x2CE9811 VA: 0x2CE9710
	|-List<Vector3Int>.Remove
	|
	|-RVA: 0x2CEC7D0 Offset: 0x2CEC8D1 VA: 0x2CEC7D0
	|-List<Vector4>.Remove
	|
	|-RVA: 0x2CF0200 Offset: 0x2CF0301 VA: 0x2CF0200
	|-List<WarpPoints.WarpPoint>.Remove
	|
	|-RVA: 0x2CF34D0 Offset: 0x2CF35D1 VA: 0x2CF34D0
	|-List<YieldItemParam>.Remove
	|
	|-RVA: 0x2CF6770 Offset: 0x2CF6871 VA: 0x2CF6770
	|-List<stCommand_t>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248EA30 Offset: 0x248EB31 VA: 0x248EA30
	|-List<AS_ToolController.ChargeInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2492580 Offset: 0x2492681 VA: 0x2492580
	|-List<BuildItemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3157E00 Offset: 0x3157F01 VA: 0x3157E00
	|-List<ButtonLinker.LinkObject>.System.Collections.IList.Remove
	|
	|-RVA: 0x315AE30 Offset: 0x315AF31 VA: 0x315AE30
	|-List<CharaCallTable.BustupTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x315DEA0 Offset: 0x315DFA1 VA: 0x315DEA0
	|-List<CharaCallTable.CharaFaceIconTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x3160F20 Offset: 0x3161021 VA: 0x3160F20
	|-List<CameraState.CustomBlendable>.System.Collections.IList.Remove
	|
	|-RVA: 0x3163F00 Offset: 0x3164001 VA: 0x3163F00
	|-List<CinemachineClearShot.Pair>.System.Collections.IList.Remove
	|
	|-RVA: 0x3166EB0 Offset: 0x3166FB1 VA: 0x3166EB0
	|-List<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Remove
	|
	|-RVA: 0x316A2C0 Offset: 0x316A3C1 VA: 0x316A2C0
	|-List<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Remove
	|
	|-RVA: 0x316D800 Offset: 0x316D901 VA: 0x316D800
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Remove
	|
	|-RVA: 0x3170DC0 Offset: 0x3170EC1 VA: 0x3170DC0
	|-List<CropDataTable>.System.Collections.IList.Remove
	|
	|-RVA: 0x3173E70 Offset: 0x3173F71 VA: 0x3173E70
	|-List<DropItemParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x3177160 Offset: 0x3177261 VA: 0x3177160
	|-List<ErosionBrush.UndoStep>.System.Collections.IList.Remove
	|
	|-RVA: 0x31DDDE0 Offset: 0x31DDEE1 VA: 0x31DDDE0
	|-List<EventCheckId>.System.Collections.IList.Remove
	|
	|-RVA: 0x31E0EB0 Offset: 0x31E0FB1 VA: 0x31E0EB0
	|-List<EventFlagProgressData>.System.Collections.IList.Remove
	|
	|-RVA: 0x31E3F00 Offset: 0x31E4001 VA: 0x31E3F00
	|-List<FesNpcScoreData>.System.Collections.IList.Remove
	|
	|-RVA: 0x31E73B0 Offset: 0x31E74B1 VA: 0x31E73B0
	|-List<MiningPointSaveData>.System.Collections.IList.Remove
	|
	|-RVA: 0x31EA8D0 Offset: 0x31EA9D1 VA: 0x31EA8D0
	|-List<MonsterHutSaveData>.System.Collections.IList.Remove
	|
	|-RVA: 0x31ED9D0 Offset: 0x31EDAD1 VA: 0x31ED9D0
	|-List<MoviePlayer.SUBTITLEDATA>.System.Collections.IList.Remove
	|
	|-RVA: 0x31F0F90 Offset: 0x31F1091 VA: 0x31F0F90
	|-List<NPCActionData>.System.Collections.IList.Remove
	|
	|-RVA: 0x31F43B0 Offset: 0x31F44B1 VA: 0x31F43B0
	|-List<NpcPlaceSchedule>.System.Collections.IList.Remove
	|
	|-RVA: 0x31F74C0 Offset: 0x31F75C1 VA: 0x31F74C0
	|-List<OrderLotterySaveParameter>.System.Collections.IList.Remove
	|
	|-RVA: 0x31FA820 Offset: 0x31FA921 VA: 0x31FA820
	|-List<OrderSaveParameter>.System.Collections.IList.Remove
	|
	|-RVA: 0x31FD8F0 Offset: 0x31FD9F1 VA: 0x31FD8F0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Remove
	|
	|-RVA: 0x330CB60 Offset: 0x330CC61 VA: 0x330CB60
	|-List<ShopCatalogPage>.System.Collections.IList.Remove
	|
	|-RVA: 0x3310040 Offset: 0x3310141 VA: 0x3310040
	|-List<ShopNpcTalk>.System.Collections.IList.Remove
	|
	|-RVA: 0x33131A0 Offset: 0x33132A1 VA: 0x33131A0
	|-List<SubtitleDataTable.Data>.System.Collections.IList.Remove
	|
	|-RVA: 0x33161D0 Offset: 0x33162D1 VA: 0x33161D0
	|-List<SubtitleDataTable.DataList>.System.Collections.IList.Remove
	|
	|-RVA: 0x3319230 Offset: 0x3319331 VA: 0x3319230
	|-List<SubtitleHudDataTable.Data>.System.Collections.IList.Remove
	|
	|-RVA: 0x331C590 Offset: 0x331C691 VA: 0x331C590
	|-List<SRMonoBehaviourEx.FieldInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x331F900 Offset: 0x331FA01 VA: 0x331F900
	|-List<Schedule>.System.Collections.IList.Remove
	|
	|-RVA: 0x33230C0 Offset: 0x33231C1 VA: 0x33230C0
	|-List<CurveSample>.System.Collections.IList.Remove
	|
	|-RVA: 0x3326240 Offset: 0x3326341 VA: 0x3326240
	|-List<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x3329210 Offset: 0x3329311 VA: 0x3329210
	|-List<byte>.System.Collections.IList.Remove
	|
	|-RVA: 0x332C1C0 Offset: 0x332C2C1 VA: 0x332C1C0
	|-List<char>.System.Collections.IList.Remove
	|
	|-RVA: 0x335A270 Offset: 0x335A371 VA: 0x335A270
	|-List<KeyValuePair<DateTime, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x335D2C0 Offset: 0x335D3C1 VA: 0x335D2C0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3360310 Offset: 0x3360411 VA: 0x3360310
	|-List<KeyValuePair<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x33632F0 Offset: 0x33633F1 VA: 0x33632F0
	|-List<DateTime>.System.Collections.IList.Remove
	|
	|-RVA: 0x33662A0 Offset: 0x33663A1 VA: 0x33662A0
	|-List<double>.System.Collections.IList.Remove
	|
	|-RVA: 0x3369250 Offset: 0x3369351 VA: 0x3369250
	|-List<short>.System.Collections.IList.Remove
	|
	|-RVA: 0x336C200 Offset: 0x336C301 VA: 0x336C200
	|-List<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x336F1B0 Offset: 0x336F2B1 VA: 0x336F1B0
	|-List<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x3372160 Offset: 0x3372261 VA: 0x3372160
	|-List<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x3375170 Offset: 0x3375271 VA: 0x3375170
	|-List<InterpretedFrameInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x33781A0 Offset: 0x33782A1 VA: 0x33781A0
	|-List<Nullable<Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3407310 Offset: 0x3407411 VA: 0x3407310
	|-List<Nullable<Bounds>>.System.Collections.IList.Remove
	|
	|-RVA: 0x340A8D0 Offset: 0x340A9D1 VA: 0x340A8D0
	|-List<Nullable<BoundsInt>>.System.Collections.IList.Remove
	|
	|-RVA: 0x340D9B0 Offset: 0x340DAB1 VA: 0x340D9B0
	|-List<Nullable<Color32>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3410D40 Offset: 0x3410E41 VA: 0x3410D40
	|-List<Nullable<Color>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3413EC0 Offset: 0x3413FC1 VA: 0x3413EC0
	|-List<Nullable<GradientAlphaKey>>.System.Collections.IList.Remove
	|
	|-RVA: 0x34172C0 Offset: 0x34173C1 VA: 0x34172C0
	|-List<Nullable<GradientColorKey>>.System.Collections.IList.Remove
	|
	|-RVA: 0x341A720 Offset: 0x341A821 VA: 0x341A720
	|-List<Nullable<Keyframe>>.System.Collections.IList.Remove
	|
	|-RVA: 0x341D7E0 Offset: 0x341D8E1 VA: 0x341D7E0
	|-List<Nullable<LayerMask>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3421060 Offset: 0x3421161 VA: 0x3421060
	|-List<Nullable<Matrix4x4>>.System.Collections.IList.Remove
	|
	|-RVA: 0x34245B0 Offset: 0x34246B1 VA: 0x34245B0
	|-List<Nullable<Quaternion>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32641A0 Offset: 0x32642A1 VA: 0x32641A0
	|-List<Nullable<RangeInt>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32675A0 Offset: 0x32676A1 VA: 0x32675A0
	|-List<Nullable<Rect>>.System.Collections.IList.Remove
	|
	|-RVA: 0x326AA00 Offset: 0x326AB01 VA: 0x326AA00
	|-List<Nullable<RectInt>>.System.Collections.IList.Remove
	|
	|-RVA: 0x326DB80 Offset: 0x326DC81 VA: 0x326DB80
	|-List<Nullable<Vector2>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3270CA0 Offset: 0x3270DA1 VA: 0x3270CA0
	|-List<Nullable<Vector2Int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3273D60 Offset: 0x3273E61 VA: 0x3273D60
	|-List<Nullable<Vector3>>.System.Collections.IList.Remove
	|
	|-RVA: 0x3276DD0 Offset: 0x3276ED1 VA: 0x3276DD0
	|-List<Nullable<Vector3Int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x327A180 Offset: 0x327A281 VA: 0x327A180
	|-List<Nullable<Vector4>>.System.Collections.IList.Remove
	|
	|-RVA: 0x327D180 Offset: 0x327D281 VA: 0x327D180
	|-List<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x3280150 Offset: 0x3280251 VA: 0x3280150
	|-List<sbyte>.System.Collections.IList.Remove
	|
	|-RVA: 0x3283100 Offset: 0x3283201 VA: 0x3283100
	|-List<float>.System.Collections.IList.Remove
	|
	|-RVA: 0x32AA360 Offset: 0x32AA461 VA: 0x32AA360
	|-List<ushort>.System.Collections.IList.Remove
	|
	|-RVA: 0x32AD310 Offset: 0x32AD411 VA: 0x32AD310
	|-List<uint>.System.Collections.IList.Remove
	|
	|-RVA: 0x32B02C0 Offset: 0x32B03C1 VA: 0x32B02C0
	|-List<ulong>.System.Collections.IList.Remove
	|
	|-RVA: 0x32B3270 Offset: 0x32B3371 VA: 0x32B3270
	|-List<ValueTuple<bool, Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32B6220 Offset: 0x32B6321 VA: 0x32B6220
	|-List<ValueTuple<Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32B9230 Offset: 0x32B9331 VA: 0x32B9230
	|-List<ValueTuple<Int32Enum, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32BC280 Offset: 0x32BC381 VA: 0x32BC280
	|-List<ValueTuple<object, Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32BF2C0 Offset: 0x32BF3C1 VA: 0x32BF2C0
	|-List<ValueTuple<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32C2300 Offset: 0x32C2401 VA: 0x32C2300
	|-List<ValueTuple<object, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32C5380 Offset: 0x32C5481 VA: 0x32C5380
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.System.Collections.IList.Remove
	|
	|-RVA: 0x32C8990 Offset: 0x32C8A91 VA: 0x32C8990
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x31125F0 Offset: 0x31126F1 VA: 0x31125F0
	|-List<TexturePacker_JsonArray.Frame>.System.Collections.IList.Remove
	|
	|-RVA: 0x3115790 Offset: 0x3115891 VA: 0x3115790
	|-List<TutorialUnlockFlagData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3118810 Offset: 0x3118911 VA: 0x3118810
	|-List<UIMainManagerAttachObject.AttachSet>.System.Collections.IList.Remove
	|
	|-RVA: 0x311BCC0 Offset: 0x311BDC1 VA: 0x311BCC0
	|-List<CapEdge>.System.Collections.IList.Remove
	|
	|-RVA: 0x311ED60 Offset: 0x311EE61 VA: 0x311ED60
	|-List<MeshDataConnectivity.Face>.System.Collections.IList.Remove
	|
	|-RVA: 0x3122010 Offset: 0x3122111 VA: 0x3122010
	|-List<MeshFaceConnectivity.EdgeData.SideData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3125560 Offset: 0x3125661 VA: 0x3125560
	|-List<MeshFaceConnectivity.EdgeData>.System.Collections.IList.Remove
	|
	|-RVA: 0x3128660 Offset: 0x3128761 VA: 0x3128660
	|-List<NavMeshBuildMarkup>.System.Collections.IList.Remove
	|
	|-RVA: 0x312C030 Offset: 0x312C131 VA: 0x312C030
	|-List<NavMeshBuildSource>.System.Collections.IList.Remove
	|
	|-RVA: 0x312F260 Offset: 0x312F361 VA: 0x312F260
	|-List<ConstraintSource>.System.Collections.IList.Remove
	|
	|-RVA: 0x3132240 Offset: 0x3132341 VA: 0x3132240
	|-List<AnimatorClipInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x321DE30 Offset: 0x321DF31 VA: 0x321DE30
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|
	|-RVA: 0x3221130 Offset: 0x3221231 VA: 0x3221130
	|-List<BoneWeight>.System.Collections.IList.Remove
	|
	|-RVA: 0x3224480 Offset: 0x3224581 VA: 0x3224480
	|-List<Bounds>.System.Collections.IList.Remove
	|
	|-RVA: 0x32277D0 Offset: 0x32278D1 VA: 0x32277D0
	|-List<BoundsInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x322A840 Offset: 0x322A941 VA: 0x322A840
	|-List<Color32>.System.Collections.IList.Remove
	|
	|-RVA: 0x322D880 Offset: 0x322D981 VA: 0x322D880
	|-List<Color>.System.Collections.IList.Remove
	|
	|-RVA: 0x3231290 Offset: 0x3231391 VA: 0x3231290
	|-List<CombineInstance>.System.Collections.IList.Remove
	|
	|-RVA: 0x3234BF0 Offset: 0x3234CF1 VA: 0x3234BF0
	|-List<RaycastResult>.System.Collections.IList.Remove
	|
	|-RVA: 0x3237D90 Offset: 0x3237E91 VA: 0x3237D90
	|-List<GradientAlphaKey>.System.Collections.IList.Remove
	|
	|-RVA: 0x323B060 Offset: 0x323B161 VA: 0x323B060
	|-List<GradientColorKey>.System.Collections.IList.Remove
	|
	|-RVA: 0x323E520 Offset: 0x323E621 VA: 0x323E520
	|-List<Keyframe>.System.Collections.IList.Remove
	|
	|-RVA: 0x32415C0 Offset: 0x32416C1 VA: 0x32415C0
	|-List<LayerMask>.System.Collections.IList.Remove
	|
	|-RVA: 0x3244B30 Offset: 0x3244C31 VA: 0x3244B30
	|-List<Matrix4x4>.System.Collections.IList.Remove
	|
	|-RVA: 0x3248060 Offset: 0x3248161 VA: 0x3248060
	|-List<ParticleSystem.Particle>.System.Collections.IList.Remove
	|
	|-RVA: 0x324B120 Offset: 0x324B221 VA: 0x324B120
	|-List<Playable>.System.Collections.IList.Remove
	|
	|-RVA: 0x324E430 Offset: 0x324E531 VA: 0x324E430
	|-List<PlayableBinding>.System.Collections.IList.Remove
	|
	|-RVA: 0x32514E0 Offset: 0x32515E1 VA: 0x32514E0
	|-List<PlayableGraph>.System.Collections.IList.Remove
	|
	|-RVA: 0x32544B0 Offset: 0x32545B1 VA: 0x32544B0
	|-List<Edge>.System.Collections.IList.Remove
	|
	|-RVA: 0x32574F0 Offset: 0x32575F1 VA: 0x32574F0
	|-List<Quaternion>.System.Collections.IList.Remove
	|
	|-RVA: 0x325A4E0 Offset: 0x325A5E1 VA: 0x325A4E0
	|-List<RangeInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x325D950 Offset: 0x325DA51 VA: 0x325D950
	|-List<RaycastHit2D>.System.Collections.IList.Remove
	|
	|-RVA: 0x3260FB0 Offset: 0x32610B1 VA: 0x3260FB0
	|-List<RaycastHit>.System.Collections.IList.Remove
	|
	|-RVA: 0x33C2930 Offset: 0x33C2A31 VA: 0x33C2930
	|-List<Rect>.System.Collections.IList.Remove
	|
	|-RVA: 0x33C5960 Offset: 0x33C5A61 VA: 0x33C5960
	|-List<RectInt>.System.Collections.IList.Remove
	|
	|-RVA: 0x33C8990 Offset: 0x33C8A91 VA: 0x33C8990
	|-List<ReflectionProbeBlendInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x33CC4B0 Offset: 0x33CC5B1 VA: 0x33CC4B0
	|-List<SphericalHarmonicsL2>.System.Collections.IList.Remove
	|
	|-RVA: 0x33CF710 Offset: 0x33CF811 VA: 0x33CF710
	|-List<VertexAttributeDescriptor>.System.Collections.IList.Remove
	|
	|-RVA: 0x33D2A10 Offset: 0x33D2B11 VA: 0x33D2A10
	|-List<AsyncOperationHandle>.System.Collections.IList.Remove
	|
	|-RVA: 0x33D5DB0 Offset: 0x33D5EB1 VA: 0x33D5DB0
	|-List<AsyncOperationHandle<SceneInstance>>.System.Collections.IList.Remove
	|
	|-RVA: 0x33D9320 Offset: 0x33D9421 VA: 0x33D9320
	|-List<DiagnosticEvent>.System.Collections.IList.Remove
	|
	|-RVA: 0x33DC720 Offset: 0x33DC821 VA: 0x33DC720
	|-List<DelayedActionManager.DelegateInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x33DFC90 Offset: 0x33DFD91 VA: 0x33DFC90
	|-List<ObjectInitializationData>.System.Collections.IList.Remove
	|
	|-RVA: 0x31BACE0 Offset: 0x31BADE1 VA: 0x31BACE0
	|-List<GlyphRect>.System.Collections.IList.Remove
	|
	|-RVA: 0x31BE110 Offset: 0x31BE211 VA: 0x31BE110
	|-List<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x31C1490 Offset: 0x31C1591 VA: 0x31C1490
	|-List<IntervalTreeNode>.System.Collections.IList.Remove
	|
	|-RVA: 0x31C4810 Offset: 0x31C4911 VA: 0x31C4810
	|-List<IntervalTree.Entry<object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x31C7BB0 Offset: 0x31C7CB1 VA: 0x31C7BB0
	|-List<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x31CACA0 Offset: 0x31CADA1 VA: 0x31CACA0
	|-List<UICharInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x31CDD00 Offset: 0x31CDE01 VA: 0x31CDD00
	|-List<FocusController.FocusedElement>.System.Collections.IList.Remove
	|
	|-RVA: 0x31D0D20 Offset: 0x31D0E21 VA: 0x31D0D20
	|-List<UILineInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x31D4570 Offset: 0x31D4671 VA: 0x31D4570
	|-List<UIVertex>.System.Collections.IList.Remove
	|
	|-RVA: 0x31D7A20 Offset: 0x31D7B21 VA: 0x31D7A20
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x31DAAE0 Offset: 0x31DABE1 VA: 0x31DAAE0
	|-List<Vector2>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CE36C0 Offset: 0x2CE37C1 VA: 0x2CE36C0
	|-List<Vector2Int>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CE66F0 Offset: 0x2CE67F1 VA: 0x2CE66F0
	|-List<Vector3>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CE9790 Offset: 0x2CE9891 VA: 0x2CE9790
	|-List<Vector3Int>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CEC840 Offset: 0x2CEC941 VA: 0x2CEC840
	|-List<Vector4>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CF0300 Offset: 0x2CF0401 VA: 0x2CF0300
	|-List<WarpPoints.WarpPoint>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CF3540 Offset: 0x2CF3641 VA: 0x2CF3540
	|-List<YieldItemParam>.System.Collections.IList.Remove
	|
	|-RVA: 0x2CF6820 Offset: 0x2CF6921 VA: 0x2CF6820
	|-List<stCommand_t>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248EB70 Offset: 0x248EC71 VA: 0x248EB70
	|-List<AS_ToolController.ChargeInfo>.RemoveAll
	|
	|-RVA: 0x327D2C0 Offset: 0x327D3C1 VA: 0x327D2C0
	|-List<AdvShowOneImage>.RemoveAll
	|-List<AudmuraCrystal>.RemoveAll
	|-List<DamageHpPercentChecker.DamageHPPercentChecker>.RemoveAll
	|-List<EventUnlockFlagData>.RemoveAll
	|-List<FriendJudgmentManager.FriendJudgmentMonster>.RemoveAll
	|-List<HUDDualWorkSelectInput.DualSelect>.RemoveAll
	|-List<ItemData>.RemoveAll
	|-List<ItemDataLinker>.RemoveAll
	|-List<ItemMoveToBasket>.RemoveAll
	|-List<KyubiController.FireballParameter>.RemoveAll
	|-List<OrderData>.RemoveAll
	|-List<OrderPopControl.StockDoOrder>.RemoveAll
	|-List<PartnerManager.NPCChangeBaseParameter>.RemoveAll
	|-List<PartyBase>.RemoveAll
	|-List<FishShipmentRecords>.RemoveAll
	|-List<SeedShopItemDataTable.SeedShopItemData>.RemoveAll
	|-List<SubtitleHandler>.RemoveAll
	|-List<object>.RemoveAll
	|-List<string>.RemoveAll
	|-List<Task>.RemoveAll
	|-List<UIItemSlot>.RemoveAll
	|-List<UIOrderBoardMenu.OrderList>.RemoveAll
	|-List<NavMeshModifier>.RemoveAll
	|-List<NavMeshModifierVolume>.RemoveAll
	|-List<AddressablesImpl.ResourceLocatorInfo>.RemoveAll
	|-List<Component>.RemoveAll
	|-List<BaseInvokableCall>.RemoveAll
	|-List<GameObject>.RemoveAll
	|
	|-RVA: 0x24926F0 Offset: 0x24927F1 VA: 0x24926F0
	|-List<BuildItemData>.RemoveAll
	|
	|-RVA: 0x3157F40 Offset: 0x3158041 VA: 0x3157F40
	|-List<ButtonLinker.LinkObject>.RemoveAll
	|
	|-RVA: 0x315AF70 Offset: 0x315B071 VA: 0x315AF70
	|-List<CharaCallTable.BustupTable>.RemoveAll
	|
	|-RVA: 0x315DFF0 Offset: 0x315E0F1 VA: 0x315DFF0
	|-List<CharaCallTable.CharaFaceIconTable>.RemoveAll
	|
	|-RVA: 0x3161060 Offset: 0x3161161 VA: 0x3161060
	|-List<CameraState.CustomBlendable>.RemoveAll
	|
	|-RVA: 0x3164040 Offset: 0x3164141 VA: 0x3164040
	|-List<CinemachineClearShot.Pair>.RemoveAll
	|
	|-RVA: 0x3166FF0 Offset: 0x31670F1 VA: 0x3166FF0
	|-List<CinemachineStateDrivenCamera.HashPair>.RemoveAll
	|
	|-RVA: 0x316A410 Offset: 0x316A511 VA: 0x316A410
	|-List<TargetPositionCache.CacheCurve.Item>.RemoveAll
	|
	|-RVA: 0x316D950 Offset: 0x316DA51 VA: 0x316D950
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.RemoveAll
	|
	|-RVA: 0x3170F00 Offset: 0x3171001 VA: 0x3170F00
	|-List<CropDataTable>.RemoveAll
	|
	|-RVA: 0x3173FB0 Offset: 0x31740B1 VA: 0x3173FB0
	|-List<DropItemParam>.RemoveAll
	|
	|-RVA: 0x31772A0 Offset: 0x31773A1 VA: 0x31772A0
	|-List<ErosionBrush.UndoStep>.RemoveAll
	|
	|-RVA: 0x31DDF20 Offset: 0x31DE021 VA: 0x31DDF20
	|-List<EventCheckId>.RemoveAll
	|
	|-RVA: 0x31E0FF0 Offset: 0x31E10F1 VA: 0x31E0FF0
	|-List<EventFlagProgressData>.RemoveAll
	|
	|-RVA: 0x31E4040 Offset: 0x31E4141 VA: 0x31E4040
	|-List<FesNpcScoreData>.RemoveAll
	|
	|-RVA: 0x31E7500 Offset: 0x31E7601 VA: 0x31E7500
	|-List<MiningPointSaveData>.RemoveAll
	|
	|-RVA: 0x31EAA20 Offset: 0x31EAB21 VA: 0x31EAA20
	|-List<MonsterHutSaveData>.RemoveAll
	|
	|-RVA: 0x31EDB10 Offset: 0x31EDC11 VA: 0x31EDB10
	|-List<MoviePlayer.SUBTITLEDATA>.RemoveAll
	|
	|-RVA: 0x31F10E0 Offset: 0x31F11E1 VA: 0x31F10E0
	|-List<NPCActionData>.RemoveAll
	|
	|-RVA: 0x31F44F0 Offset: 0x31F45F1 VA: 0x31F44F0
	|-List<NpcPlaceSchedule>.RemoveAll
	|
	|-RVA: 0x31F7610 Offset: 0x31F7711 VA: 0x31F7610
	|-List<OrderLotterySaveParameter>.RemoveAll
	|
	|-RVA: 0x31FA960 Offset: 0x31FAA61 VA: 0x31FA960
	|-List<OrderSaveParameter>.RemoveAll
	|
	|-RVA: 0x31FDA30 Offset: 0x31FDB31 VA: 0x31FDA30
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.RemoveAll
	|
	|-RVA: 0x330CCA0 Offset: 0x330CDA1 VA: 0x330CCA0
	|-List<ShopCatalogPage>.RemoveAll
	|
	|-RVA: 0x3310190 Offset: 0x3310291 VA: 0x3310190
	|-List<ShopNpcTalk>.RemoveAll
	|
	|-RVA: 0x33132F0 Offset: 0x33133F1 VA: 0x33132F0
	|-List<SubtitleDataTable.Data>.RemoveAll
	|
	|-RVA: 0x3316310 Offset: 0x3316411 VA: 0x3316310
	|-List<SubtitleDataTable.DataList>.RemoveAll
	|
	|-RVA: 0x3319380 Offset: 0x3319481 VA: 0x3319380
	|-List<SubtitleHudDataTable.Data>.RemoveAll
	|
	|-RVA: 0x331C6D0 Offset: 0x331C7D1 VA: 0x331C6D0
	|-List<SRMonoBehaviourEx.FieldInfo>.RemoveAll
	|
	|-RVA: 0x331FA40 Offset: 0x331FB41 VA: 0x331FA40
	|-List<Schedule>.RemoveAll
	|
	|-RVA: 0x3323220 Offset: 0x3323321 VA: 0x3323220
	|-List<CurveSample>.RemoveAll
	|
	|-RVA: 0x3326380 Offset: 0x3326481 VA: 0x3326380
	|-List<bool>.RemoveAll
	|
	|-RVA: 0x3329350 Offset: 0x3329451 VA: 0x3329350
	|-List<byte>.RemoveAll
	|
	|-RVA: 0x332C300 Offset: 0x332C401 VA: 0x332C300
	|-List<char>.RemoveAll
	|
	|-RVA: 0x335A3B0 Offset: 0x335A4B1 VA: 0x335A3B0
	|-List<KeyValuePair<DateTime, object>>.RemoveAll
	|
	|-RVA: 0x335D400 Offset: 0x335D501 VA: 0x335D400
	|-List<KeyValuePair<int, object>>.RemoveAll
	|
	|-RVA: 0x3360450 Offset: 0x3360551 VA: 0x3360450
	|-List<KeyValuePair<object, object>>.RemoveAll
	|
	|-RVA: 0x3363430 Offset: 0x3363531 VA: 0x3363430
	|-List<DateTime>.RemoveAll
	|
	|-RVA: 0x33663E0 Offset: 0x33664E1 VA: 0x33663E0
	|-List<double>.RemoveAll
	|
	|-RVA: 0x3369390 Offset: 0x3369491 VA: 0x3369390
	|-List<short>.RemoveAll
	|
	|-RVA: 0x336C340 Offset: 0x336C441 VA: 0x336C340
	|-List<int>.RemoveAll
	|
	|-RVA: 0x336F2F0 Offset: 0x336F3F1 VA: 0x336F2F0
	|-List<Int32Enum>.RemoveAll
	|
	|-RVA: 0x33722A0 Offset: 0x33723A1 VA: 0x33722A0
	|-List<long>.RemoveAll
	|
	|-RVA: 0x33752B0 Offset: 0x33753B1 VA: 0x33752B0
	|-List<InterpretedFrameInfo>.RemoveAll
	|
	|-RVA: 0x33782E0 Offset: 0x33783E1 VA: 0x33782E0
	|-List<Nullable<Int32Enum>>.RemoveAll
	|
	|-RVA: 0x3407470 Offset: 0x3407571 VA: 0x3407470
	|-List<Nullable<Bounds>>.RemoveAll
	|
	|-RVA: 0x340AA30 Offset: 0x340AB31 VA: 0x340AA30
	|-List<Nullable<BoundsInt>>.RemoveAll
	|
	|-RVA: 0x340DAF0 Offset: 0x340DBF1 VA: 0x340DAF0
	|-List<Nullable<Color32>>.RemoveAll
	|
	|-RVA: 0x3410EA0 Offset: 0x3410FA1 VA: 0x3410EA0
	|-List<Nullable<Color>>.RemoveAll
	|
	|-RVA: 0x3414010 Offset: 0x3414111 VA: 0x3414010
	|-List<Nullable<GradientAlphaKey>>.RemoveAll
	|
	|-RVA: 0x3417420 Offset: 0x3417521 VA: 0x3417420
	|-List<Nullable<GradientColorKey>>.RemoveAll
	|
	|-RVA: 0x341A880 Offset: 0x341A981 VA: 0x341A880
	|-List<Nullable<Keyframe>>.RemoveAll
	|
	|-RVA: 0x341D920 Offset: 0x341DA21 VA: 0x341D920
	|-List<Nullable<LayerMask>>.RemoveAll
	|
	|-RVA: 0x34211D0 Offset: 0x34212D1 VA: 0x34211D0
	|-List<Nullable<Matrix4x4>>.RemoveAll
	|
	|-RVA: 0x3424710 Offset: 0x3424811 VA: 0x3424710
	|-List<Nullable<Quaternion>>.RemoveAll
	|
	|-RVA: 0x32642F0 Offset: 0x32643F1 VA: 0x32642F0
	|-List<Nullable<RangeInt>>.RemoveAll
	|
	|-RVA: 0x3267700 Offset: 0x3267801 VA: 0x3267700
	|-List<Nullable<Rect>>.RemoveAll
	|
	|-RVA: 0x326AB60 Offset: 0x326AC61 VA: 0x326AB60
	|-List<Nullable<RectInt>>.RemoveAll
	|
	|-RVA: 0x326DCD0 Offset: 0x326DDD1 VA: 0x326DCD0
	|-List<Nullable<Vector2>>.RemoveAll
	|
	|-RVA: 0x3270DF0 Offset: 0x3270EF1 VA: 0x3270DF0
	|-List<Nullable<Vector2Int>>.RemoveAll
	|
	|-RVA: 0x3273EA0 Offset: 0x3273FA1 VA: 0x3273EA0
	|-List<Nullable<Vector3>>.RemoveAll
	|
	|-RVA: 0x3276F10 Offset: 0x3277011 VA: 0x3276F10
	|-List<Nullable<Vector3Int>>.RemoveAll
	|
	|-RVA: 0x327A2E0 Offset: 0x327A3E1 VA: 0x327A2E0
	|-List<Nullable<Vector4>>.RemoveAll
	|
	|-RVA: 0x3280290 Offset: 0x3280391 VA: 0x3280290
	|-List<sbyte>.RemoveAll
	|
	|-RVA: 0x3283240 Offset: 0x3283341 VA: 0x3283240
	|-List<float>.RemoveAll
	|
	|-RVA: 0x32AA4A0 Offset: 0x32AA5A1 VA: 0x32AA4A0
	|-List<ushort>.RemoveAll
	|
	|-RVA: 0x32AD450 Offset: 0x32AD551 VA: 0x32AD450
	|-List<uint>.RemoveAll
	|
	|-RVA: 0x32B0400 Offset: 0x32B0501 VA: 0x32B0400
	|-List<ulong>.RemoveAll
	|
	|-RVA: 0x32B33B0 Offset: 0x32B34B1 VA: 0x32B33B0
	|-List<ValueTuple<bool, Int32Enum>>.RemoveAll
	|
	|-RVA: 0x32B6360 Offset: 0x32B6461 VA: 0x32B6360
	|-List<ValueTuple<Int32Enum, int>>.RemoveAll
	|
	|-RVA: 0x32B9370 Offset: 0x32B9471 VA: 0x32B9370
	|-List<ValueTuple<Int32Enum, object>>.RemoveAll
	|
	|-RVA: 0x32BC3C0 Offset: 0x32BC4C1 VA: 0x32BC3C0
	|-List<ValueTuple<object, Int32Enum>>.RemoveAll
	|
	|-RVA: 0x32BF400 Offset: 0x32BF501 VA: 0x32BF400
	|-List<ValueTuple<object, object>>.RemoveAll
	|
	|-RVA: 0x32C2440 Offset: 0x32C2541 VA: 0x32C2440
	|-List<ValueTuple<object, float>>.RemoveAll
	|
	|-RVA: 0x32C54D0 Offset: 0x32C55D1 VA: 0x32C54D0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.RemoveAll
	|
	|-RVA: 0x32C8AE0 Offset: 0x32C8BE1 VA: 0x32C8AE0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.RemoveAll
	|
	|-RVA: 0x3112740 Offset: 0x3112841 VA: 0x3112740
	|-List<TexturePacker_JsonArray.Frame>.RemoveAll
	|
	|-RVA: 0x31158E0 Offset: 0x31159E1 VA: 0x31158E0
	|-List<TutorialUnlockFlagData>.RemoveAll
	|
	|-RVA: 0x3118950 Offset: 0x3118A51 VA: 0x3118950
	|-List<UIMainManagerAttachObject.AttachSet>.RemoveAll
	|
	|-RVA: 0x311BE10 Offset: 0x311BF11 VA: 0x311BE10
	|-List<CapEdge>.RemoveAll
	|
	|-RVA: 0x311EEA0 Offset: 0x311EFA1 VA: 0x311EEA0
	|-List<MeshDataConnectivity.Face>.RemoveAll
	|
	|-RVA: 0x3122150 Offset: 0x3122251 VA: 0x3122150
	|-List<MeshFaceConnectivity.EdgeData.SideData>.RemoveAll
	|
	|-RVA: 0x31256B0 Offset: 0x31257B1 VA: 0x31256B0
	|-List<MeshFaceConnectivity.EdgeData>.RemoveAll
	|
	|-RVA: 0x31287A0 Offset: 0x31288A1 VA: 0x31287A0
	|-List<NavMeshBuildMarkup>.RemoveAll
	|
	|-RVA: 0x312C1A0 Offset: 0x312C2A1 VA: 0x312C1A0
	|-List<NavMeshBuildSource>.RemoveAll
	|
	|-RVA: 0x312F3A0 Offset: 0x312F4A1 VA: 0x312F3A0
	|-List<ConstraintSource>.RemoveAll
	|
	|-RVA: 0x3132380 Offset: 0x3132481 VA: 0x3132380
	|-List<AnimatorClipInfo>.RemoveAll
	|
	|-RVA: 0x321DF70 Offset: 0x321E071 VA: 0x321DF70
	|-List<BeforeRenderHelper.OrderBlock>.RemoveAll
	|
	|-RVA: 0x3221270 Offset: 0x3221371 VA: 0x3221270
	|-List<BoneWeight>.RemoveAll
	|
	|-RVA: 0x32245C0 Offset: 0x32246C1 VA: 0x32245C0
	|-List<Bounds>.RemoveAll
	|
	|-RVA: 0x3227910 Offset: 0x3227A11 VA: 0x3227910
	|-List<BoundsInt>.RemoveAll
	|
	|-RVA: 0x322A980 Offset: 0x322AA81 VA: 0x322A980
	|-List<Color32>.RemoveAll
	|
	|-RVA: 0x322D9D0 Offset: 0x322DAD1 VA: 0x322D9D0
	|-List<Color>.RemoveAll
	|
	|-RVA: 0x3231400 Offset: 0x3231501 VA: 0x3231400
	|-List<CombineInstance>.RemoveAll
	|
	|-RVA: 0x3234D50 Offset: 0x3234E51 VA: 0x3234D50
	|-List<RaycastResult>.RemoveAll
	|
	|-RVA: 0x3237ED0 Offset: 0x3237FD1 VA: 0x3237ED0
	|-List<GradientAlphaKey>.RemoveAll
	|
	|-RVA: 0x323B1A0 Offset: 0x323B2A1 VA: 0x323B1A0
	|-List<GradientColorKey>.RemoveAll
	|
	|-RVA: 0x323E670 Offset: 0x323E771 VA: 0x323E670
	|-List<Keyframe>.RemoveAll
	|
	|-RVA: 0x3241700 Offset: 0x3241801 VA: 0x3241700
	|-List<LayerMask>.RemoveAll
	|
	|-RVA: 0x3244C80 Offset: 0x3244D81 VA: 0x3244C80
	|-List<Matrix4x4>.RemoveAll
	|
	|-RVA: 0x32481A0 Offset: 0x32482A1 VA: 0x32481A0
	|-List<ParticleSystem.Particle>.RemoveAll
	|
	|-RVA: 0x324B260 Offset: 0x324B361 VA: 0x324B260
	|-List<Playable>.RemoveAll
	|
	|-RVA: 0x324E570 Offset: 0x324E671 VA: 0x324E570
	|-List<PlayableBinding>.RemoveAll
	|
	|-RVA: 0x3251620 Offset: 0x3251721 VA: 0x3251620
	|-List<PlayableGraph>.RemoveAll
	|
	|-RVA: 0x32545F0 Offset: 0x32546F1 VA: 0x32545F0
	|-List<Edge>.RemoveAll
	|
	|-RVA: 0x3257640 Offset: 0x3257741 VA: 0x3257640
	|-List<Quaternion>.RemoveAll
	|
	|-RVA: 0x325A620 Offset: 0x325A721 VA: 0x325A620
	|-List<RangeInt>.RemoveAll
	|
	|-RVA: 0x325DAA0 Offset: 0x325DBA1 VA: 0x325DAA0
	|-List<RaycastHit2D>.RemoveAll
	|
	|-RVA: 0x3261100 Offset: 0x3261201 VA: 0x3261100
	|-List<RaycastHit>.RemoveAll
	|
	|-RVA: 0x33C2A80 Offset: 0x33C2B81 VA: 0x33C2A80
	|-List<Rect>.RemoveAll
	|
	|-RVA: 0x33C5AA0 Offset: 0x33C5BA1 VA: 0x33C5AA0
	|-List<RectInt>.RemoveAll
	|
	|-RVA: 0x33C8AD0 Offset: 0x33C8BD1 VA: 0x33C8AD0
	|-List<ReflectionProbeBlendInfo>.RemoveAll
	|
	|-RVA: 0x33CC620 Offset: 0x33CC721 VA: 0x33CC620
	|-List<SphericalHarmonicsL2>.RemoveAll
	|
	|-RVA: 0x33CF850 Offset: 0x33CF951 VA: 0x33CF850
	|-List<VertexAttributeDescriptor>.RemoveAll
	|
	|-RVA: 0x33D2B50 Offset: 0x33D2C51 VA: 0x33D2B50
	|-List<AsyncOperationHandle>.RemoveAll
	|
	|-RVA: 0x33D5EF0 Offset: 0x33D5FF1 VA: 0x33D5EF0
	|-List<AsyncOperationHandle<SceneInstance>>.RemoveAll
	|
	|-RVA: 0x33D9470 Offset: 0x33D9571 VA: 0x33D9470
	|-List<DiagnosticEvent>.RemoveAll
	|
	|-RVA: 0x33DC860 Offset: 0x33DC961 VA: 0x33DC860
	|-List<DelayedActionManager.DelegateInfo>.RemoveAll
	|
	|-RVA: 0x33DFDE0 Offset: 0x33DFEE1 VA: 0x33DFDE0
	|-List<ObjectInitializationData>.RemoveAll
	|
	|-RVA: 0x31BAE20 Offset: 0x31BAF21 VA: 0x31BAE20
	|-List<GlyphRect>.RemoveAll
	|
	|-RVA: 0x31BE260 Offset: 0x31BE361 VA: 0x31BE260
	|-List<AnimationOutputWeightProcessor.WeightInfo>.RemoveAll
	|
	|-RVA: 0x31C15D0 Offset: 0x31C16D1 VA: 0x31C15D0
	|-List<IntervalTreeNode>.RemoveAll
	|
	|-RVA: 0x31C4950 Offset: 0x31C4A51 VA: 0x31C4950
	|-List<IntervalTree.Entry<object>>.RemoveAll
	|
	|-RVA: 0x31C7CF0 Offset: 0x31C7DF1 VA: 0x31C7CF0
	|-List<TimeNotificationBehaviour.NotificationEntry>.RemoveAll
	|
	|-RVA: 0x31CADF0 Offset: 0x31CAEF1 VA: 0x31CADF0
	|-List<UICharInfo>.RemoveAll
	|
	|-RVA: 0x31CDE40 Offset: 0x31CDF41 VA: 0x31CDE40
	|-List<FocusController.FocusedElement>.RemoveAll
	|
	|-RVA: 0x31D0E60 Offset: 0x31D0F61 VA: 0x31D0E60
	|-List<UILineInfo>.RemoveAll
	|
	|-RVA: 0x31D46D0 Offset: 0x31D47D1 VA: 0x31D46D0
	|-List<UIVertex>.RemoveAll
	|
	|-RVA: 0x31D7B60 Offset: 0x31D7C61 VA: 0x31D7B60
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveAll
	|
	|-RVA: 0x31DAC20 Offset: 0x31DAD21 VA: 0x31DAC20
	|-List<Vector2>.RemoveAll
	|
	|-RVA: 0x2CE3800 Offset: 0x2CE3901 VA: 0x2CE3800
	|-List<Vector2Int>.RemoveAll
	|
	|-RVA: 0x2CE6840 Offset: 0x2CE6941 VA: 0x2CE6840
	|-List<Vector3>.RemoveAll
	|
	|-RVA: 0x2CE98E0 Offset: 0x2CE99E1 VA: 0x2CE98E0
	|-List<Vector3Int>.RemoveAll
	|
	|-RVA: 0x2CEC990 Offset: 0x2CECA91 VA: 0x2CEC990
	|-List<Vector4>.RemoveAll
	|
	|-RVA: 0x2CF0470 Offset: 0x2CF0571 VA: 0x2CF0470
	|-List<WarpPoints.WarpPoint>.RemoveAll
	|
	|-RVA: 0x2CF3680 Offset: 0x2CF3781 VA: 0x2CF3680
	|-List<YieldItemParam>.RemoveAll
	|
	|-RVA: 0x2CF6960 Offset: 0x2CF6A61 VA: 0x2CF6960
	|-List<stCommand_t>.RemoveAll
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248EDF0 Offset: 0x248EEF1 VA: 0x248EDF0
	|-List<AS_ToolController.ChargeInfo>.RemoveAt
	|
	|-RVA: 0x327D4C0 Offset: 0x327D5C1 VA: 0x327D4C0
	|-List<Actor>.RemoveAt
	|-List<AutomaticLOD.LODLevelData>.RemoveAt
	|-List<BehaviorManager.BehaviorThreadLoader>.RemoveAt
	|-List<BehaviorManager.BehaviorTree.ConditionalReevaluate>.RemoveAt
	|-List<VariableSynchronizer.SynchronizedVariable>.RemoveAt
	|-List<CheerVoiceData>.RemoveAt
	|-List<CinemachineBrain.BrainFrame>.RemoveAt
	|-List<CinemachineExtension>.RemoveAt
	|-List<CinemachineImpulseManager.ImpulseEvent>.RemoveAt
	|-List<CinemachineVirtualCameraBase>.RemoveAt
	|-List<ABSSequentiable>.RemoveAt
	|-List<EventStartData>.RemoveAt
	|-List<FishSwim>.RemoveAt
	|-List<FishingPoint>.RemoveAt
	|-List<FracturedChunk.AdjacencyInfo>.RemoveAt
	|-List<FracturedChunk>.RemoveAt
	|-List<HUDMinimapControl.RectImage>.RemoveAt
	|-List<HateController.HateParameter>.RemoveAt
	|-List<ItemData>.RemoveAt
	|-List<KrakenStickController>.RemoveAt
	|-List<LifeCycleAdvData>.RemoveAt
	|-List<MiningPoint>.RemoveAt
	|-List<MobBrain>.RemoveAt
	|-List<MonsterControllerBase.DropItemDataParameter>.RemoveAt
	|-List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter>.RemoveAt
	|-List<OrderData>.RemoveAt
	|-List<PartyBase>.RemoveAt
	|-List<Contour>.RemoveAt
	|-List<Point2D>.RemoveAt
	|-List<PolygonPoint>.RemoveAt
	|-List<SplitComplexPolygonNode>.RemoveAt
	|-List<PreloadHandle>.RemoveAt
	|-List<SubtitleHandler>.RemoveAt
	|-List<RF5ThumbnailData>.RemoveAt
	|-List<SplineNode>.RemoveAt
	|-List<TrackSegment>.RemoveAt
	|-List<List<PolygonPoint>>.RemoveAt
	|-List<List<object>>.RemoveAt
	|-List<Stack<int>>.RemoveAt
	|-List<Directory.SearchData>.RemoveAt
	|-List<Instruction>.RemoveAt
	|-List<object>.RemoveAt
	|-List<StringBuilder>.RemoveAt
	|-List<WeakReference>.RemoveAt
	|-List<KerningPair>.RemoveAt
	|-List<TMP_Character>.RemoveAt
	|-List<TMP_MaterialManager.MaskingMaterial>.RemoveAt
	|-List<Simplifier.Vertex>.RemoveAt
	|-List<UltimateRope.RopeNode>.RemoveAt
	|-List<BaseInputModule>.RemoveAt
	|-List<EventSystem>.RemoveAt
	|-List<UnityEvent>.RemoveAt
	|-List<GameObject>.RemoveAt
	|-List<ISubsystem>.RemoveAt
	|-List<Material>.RemoveAt
	|-List<SignalAsset>.RemoveAt
	|-List<Image>.RemoveAt
	|-List<StencilMaterial.MatEntry>.RemoveAt
	|-List<XWeaponTrail.Element>.RemoveAt
	|
	|-RVA: 0x336F4F0 Offset: 0x336F5F1 VA: 0x336F4F0
	|-List<TaskStatus>.RemoveAt
	|-List<ItemID>.RemoveAt
	|-List<Int32Enum>.RemoveAt
	|-List<RegexOptions>.RemoveAt
	|
	|-RVA: 0x2492AB0 Offset: 0x2492BB1 VA: 0x2492AB0
	|-List<BuildItemData>.RemoveAt
	|
	|-RVA: 0x3158170 Offset: 0x3158271 VA: 0x3158170
	|-List<ButtonLinker.LinkObject>.RemoveAt
	|
	|-RVA: 0x315B190 Offset: 0x315B291 VA: 0x315B190
	|-List<CharaCallTable.BustupTable>.RemoveAt
	|
	|-RVA: 0x315E250 Offset: 0x315E351 VA: 0x315E250
	|-List<CharaCallTable.CharaFaceIconTable>.RemoveAt
	|
	|-RVA: 0x3161280 Offset: 0x3161381 VA: 0x3161280
	|-List<CameraState.CustomBlendable>.RemoveAt
	|
	|-RVA: 0x3164240 Offset: 0x3164341 VA: 0x3164240
	|-List<CinemachineClearShot.Pair>.RemoveAt
	|
	|-RVA: 0x31671F0 Offset: 0x31672F1 VA: 0x31671F0
	|-List<CinemachineStateDrivenCamera.HashPair>.RemoveAt
	|
	|-RVA: 0x316A6B0 Offset: 0x316A7B1 VA: 0x316A6B0
	|-List<TargetPositionCache.CacheCurve.Item>.RemoveAt
	|
	|-RVA: 0x316DC00 Offset: 0x316DD01 VA: 0x316DC00
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.RemoveAt
	|
	|-RVA: 0x31711A0 Offset: 0x31712A1 VA: 0x31711A0
	|-List<CropDataTable>.RemoveAt
	|
	|-RVA: 0x31741B0 Offset: 0x31742B1 VA: 0x31741B0
	|-List<DropItemParam>.RemoveAt
	|
	|-RVA: 0x3177520 Offset: 0x3177621 VA: 0x3177520
	|-List<ErosionBrush.UndoStep>.RemoveAt
	|
	|-RVA: 0x31DE1A0 Offset: 0x31DE2A1 VA: 0x31DE1A0
	|-List<EventCheckId>.RemoveAt
	|
	|-RVA: 0x31E1220 Offset: 0x31E1321 VA: 0x31E1220
	|-List<EventFlagProgressData>.RemoveAt
	|
	|-RVA: 0x31E4270 Offset: 0x31E4371 VA: 0x31E4270
	|-List<FesNpcScoreData>.RemoveAt
	|
	|-RVA: 0x31E77B0 Offset: 0x31E78B1 VA: 0x31E77B0
	|-List<MiningPointSaveData>.RemoveAt
	|
	|-RVA: 0x31EACD0 Offset: 0x31EADD1 VA: 0x31EACD0
	|-List<MonsterHutSaveData>.RemoveAt
	|
	|-RVA: 0x31EDD40 Offset: 0x31EDE41 VA: 0x31EDD40
	|-List<MoviePlayer.SUBTITLEDATA>.RemoveAt
	|
	|-RVA: 0x31F13D0 Offset: 0x31F14D1 VA: 0x31F13D0
	|-List<NPCActionData>.RemoveAt
	|
	|-RVA: 0x31F4770 Offset: 0x31F4871 VA: 0x31F4770
	|-List<NpcPlaceSchedule>.RemoveAt
	|
	|-RVA: 0x31F7870 Offset: 0x31F7971 VA: 0x31F7870
	|-List<OrderLotterySaveParameter>.RemoveAt
	|
	|-RVA: 0x31FABE0 Offset: 0x31FACE1 VA: 0x31FABE0
	|-List<OrderSaveParameter>.RemoveAt
	|
	|-RVA: 0x31FDC60 Offset: 0x31FDD61 VA: 0x31FDC60
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.RemoveAt
	|
	|-RVA: 0x330CEC0 Offset: 0x330CFC1 VA: 0x330CEC0
	|-List<ShopCatalogPage>.RemoveAt
	|
	|-RVA: 0x3310460 Offset: 0x3310561 VA: 0x3310460
	|-List<ShopNpcTalk>.RemoveAt
	|
	|-RVA: 0x3313550 Offset: 0x3313651 VA: 0x3313550
	|-List<SubtitleDataTable.Data>.RemoveAt
	|
	|-RVA: 0x3316520 Offset: 0x3316621 VA: 0x3316520
	|-List<SubtitleDataTable.DataList>.RemoveAt
	|
	|-RVA: 0x33195E0 Offset: 0x33196E1 VA: 0x33195E0
	|-List<SubtitleHudDataTable.Data>.RemoveAt
	|
	|-RVA: 0x331C950 Offset: 0x331CA51 VA: 0x331C950
	|-List<SRMonoBehaviourEx.FieldInfo>.RemoveAt
	|
	|-RVA: 0x331FCB0 Offset: 0x331FDB1 VA: 0x331FCB0
	|-List<Schedule>.RemoveAt
	|
	|-RVA: 0x3323540 Offset: 0x3323641 VA: 0x3323540
	|-List<CurveSample>.RemoveAt
	|
	|-RVA: 0x3326580 Offset: 0x3326681 VA: 0x3326580
	|-List<bool>.RemoveAt
	|
	|-RVA: 0x3329550 Offset: 0x3329651 VA: 0x3329550
	|-List<byte>.RemoveAt
	|
	|-RVA: 0x332C500 Offset: 0x332C601 VA: 0x332C500
	|-List<char>.RemoveAt
	|
	|-RVA: 0x335A5E0 Offset: 0x335A6E1 VA: 0x335A5E0
	|-List<KeyValuePair<DateTime, object>>.RemoveAt
	|
	|-RVA: 0x335D630 Offset: 0x335D731 VA: 0x335D630
	|-List<KeyValuePair<int, object>>.RemoveAt
	|
	|-RVA: 0x3360670 Offset: 0x3360771 VA: 0x3360670
	|-List<KeyValuePair<object, object>>.RemoveAt
	|
	|-RVA: 0x3363630 Offset: 0x3363731 VA: 0x3363630
	|-List<DateTime>.RemoveAt
	|
	|-RVA: 0x33665E0 Offset: 0x33666E1 VA: 0x33665E0
	|-List<double>.RemoveAt
	|
	|-RVA: 0x3369590 Offset: 0x3369691 VA: 0x3369590
	|-List<short>.RemoveAt
	|
	|-RVA: 0x336C540 Offset: 0x336C641 VA: 0x336C540
	|-List<int>.RemoveAt
	|
	|-RVA: 0x33724A0 Offset: 0x33725A1 VA: 0x33724A0
	|-List<long>.RemoveAt
	|
	|-RVA: 0x33754D0 Offset: 0x33755D1 VA: 0x33754D0
	|-List<InterpretedFrameInfo>.RemoveAt
	|
	|-RVA: 0x33784E0 Offset: 0x33785E1 VA: 0x33784E0
	|-List<Nullable<Int32Enum>>.RemoveAt
	|
	|-RVA: 0x3407710 Offset: 0x3407811 VA: 0x3407710
	|-List<Nullable<Bounds>>.RemoveAt
	|
	|-RVA: 0x340ACD0 Offset: 0x340ADD1 VA: 0x340ACD0
	|-List<Nullable<BoundsInt>>.RemoveAt
	|
	|-RVA: 0x340DCF0 Offset: 0x340DDF1 VA: 0x340DCF0
	|-List<Nullable<Color32>>.RemoveAt
	|
	|-RVA: 0x3411120 Offset: 0x3411221 VA: 0x3411120
	|-List<Nullable<Color>>.RemoveAt
	|
	|-RVA: 0x3414270 Offset: 0x3414371 VA: 0x3414270
	|-List<Nullable<GradientAlphaKey>>.RemoveAt
	|
	|-RVA: 0x3417690 Offset: 0x3417791 VA: 0x3417690
	|-List<Nullable<GradientColorKey>>.RemoveAt
	|
	|-RVA: 0x341AAF0 Offset: 0x341ABF1 VA: 0x341AAF0
	|-List<Nullable<Keyframe>>.RemoveAt
	|
	|-RVA: 0x341DB20 Offset: 0x341DC21 VA: 0x341DB20
	|-List<Nullable<LayerMask>>.RemoveAt
	|
	|-RVA: 0x3421510 Offset: 0x3421611 VA: 0x3421510
	|-List<Nullable<Matrix4x4>>.RemoveAt
	|
	|-RVA: 0x3424990 Offset: 0x3424A91 VA: 0x3424990
	|-List<Nullable<Quaternion>>.RemoveAt
	|
	|-RVA: 0x3264550 Offset: 0x3264651 VA: 0x3264550
	|-List<Nullable<RangeInt>>.RemoveAt
	|
	|-RVA: 0x3267980 Offset: 0x3267A81 VA: 0x3267980
	|-List<Nullable<Rect>>.RemoveAt
	|
	|-RVA: 0x326ADE0 Offset: 0x326AEE1 VA: 0x326ADE0
	|-List<Nullable<RectInt>>.RemoveAt
	|
	|-RVA: 0x326DF30 Offset: 0x326E031 VA: 0x326DF30
	|-List<Nullable<Vector2>>.RemoveAt
	|
	|-RVA: 0x3271050 Offset: 0x3271151 VA: 0x3271050
	|-List<Nullable<Vector2Int>>.RemoveAt
	|
	|-RVA: 0x32740C0 Offset: 0x32741C1 VA: 0x32740C0
	|-List<Nullable<Vector3>>.RemoveAt
	|
	|-RVA: 0x3277130 Offset: 0x3277231 VA: 0x3277130
	|-List<Nullable<Vector3Int>>.RemoveAt
	|
	|-RVA: 0x327A560 Offset: 0x327A661 VA: 0x327A560
	|-List<Nullable<Vector4>>.RemoveAt
	|
	|-RVA: 0x3280490 Offset: 0x3280591 VA: 0x3280490
	|-List<sbyte>.RemoveAt
	|
	|-RVA: 0x3283440 Offset: 0x3283541 VA: 0x3283440
	|-List<float>.RemoveAt
	|
	|-RVA: 0x32AA6A0 Offset: 0x32AA7A1 VA: 0x32AA6A0
	|-List<ushort>.RemoveAt
	|
	|-RVA: 0x32AD650 Offset: 0x32AD751 VA: 0x32AD650
	|-List<uint>.RemoveAt
	|
	|-RVA: 0x32B0600 Offset: 0x32B0701 VA: 0x32B0600
	|-List<ulong>.RemoveAt
	|
	|-RVA: 0x32B35B0 Offset: 0x32B36B1 VA: 0x32B35B0
	|-List<ValueTuple<bool, Int32Enum>>.RemoveAt
	|
	|-RVA: 0x32B6560 Offset: 0x32B6661 VA: 0x32B6560
	|-List<ValueTuple<Int32Enum, int>>.RemoveAt
	|
	|-RVA: 0x32B95A0 Offset: 0x32B96A1 VA: 0x32B95A0
	|-List<ValueTuple<Int32Enum, object>>.RemoveAt
	|
	|-RVA: 0x32BC5E0 Offset: 0x32BC6E1 VA: 0x32BC5E0
	|-List<ValueTuple<object, Int32Enum>>.RemoveAt
	|
	|-RVA: 0x32BF620 Offset: 0x32BF721 VA: 0x32BF620
	|-List<ValueTuple<object, object>>.RemoveAt
	|
	|-RVA: 0x32C2660 Offset: 0x32C2761 VA: 0x32C2660
	|-List<ValueTuple<object, float>>.RemoveAt
	|
	|-RVA: 0x32C5730 Offset: 0x32C5831 VA: 0x32C5730
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.RemoveAt
	|
	|-RVA: 0x32C8DE0 Offset: 0x32C8EE1 VA: 0x32C8DE0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.RemoveAt
	|
	|-RVA: 0x3112A40 Offset: 0x3112B41 VA: 0x3112A40
	|-List<TexturePacker_JsonArray.Frame>.RemoveAt
	|
	|-RVA: 0x3115B40 Offset: 0x3115C41 VA: 0x3115B40
	|-List<TutorialUnlockFlagData>.RemoveAt
	|
	|-RVA: 0x3118B80 Offset: 0x3118C81 VA: 0x3118B80
	|-List<UIMainManagerAttachObject.AttachSet>.RemoveAt
	|
	|-RVA: 0x311C0C0 Offset: 0x311C1C1 VA: 0x311C0C0
	|-List<CapEdge>.RemoveAt
	|
	|-RVA: 0x311F0A0 Offset: 0x311F1A1 VA: 0x311F0A0
	|-List<MeshDataConnectivity.Face>.RemoveAt
	|
	|-RVA: 0x31223C0 Offset: 0x31224C1 VA: 0x31223C0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.RemoveAt
	|
	|-RVA: 0x3125980 Offset: 0x3125A81 VA: 0x3125980
	|-List<MeshFaceConnectivity.EdgeData>.RemoveAt
	|
	|-RVA: 0x31289C0 Offset: 0x3128AC1 VA: 0x31289C0
	|-List<NavMeshBuildMarkup>.RemoveAt
	|
	|-RVA: 0x312C520 Offset: 0x312C621 VA: 0x312C520
	|-List<NavMeshBuildSource>.RemoveAt
	|
	|-RVA: 0x312F5C0 Offset: 0x312F6C1 VA: 0x312F5C0
	|-List<ConstraintSource>.RemoveAt
	|
	|-RVA: 0x3132580 Offset: 0x3132681 VA: 0x3132580
	|-List<AnimatorClipInfo>.RemoveAt
	|
	|-RVA: 0x321E1A0 Offset: 0x321E2A1 VA: 0x321E1A0
	|-List<BeforeRenderHelper.OrderBlock>.RemoveAt
	|
	|-RVA: 0x32214E0 Offset: 0x32215E1 VA: 0x32214E0
	|-List<BoneWeight>.RemoveAt
	|
	|-RVA: 0x3224830 Offset: 0x3224931 VA: 0x3224830
	|-List<Bounds>.RemoveAt
	|
	|-RVA: 0x3227B80 Offset: 0x3227C81 VA: 0x3227B80
	|-List<BoundsInt>.RemoveAt
	|
	|-RVA: 0x322AB80 Offset: 0x322AC81 VA: 0x322AB80
	|-List<Color32>.RemoveAt
	|
	|-RVA: 0x322DC00 Offset: 0x322DD01 VA: 0x322DC00
	|-List<Color>.RemoveAt
	|
	|-RVA: 0x3231780 Offset: 0x3231881 VA: 0x3231780
	|-List<CombineInstance>.RemoveAt
	|
	|-RVA: 0x3235070 Offset: 0x3235171 VA: 0x3235070
	|-List<RaycastResult>.RemoveAt
	|
	|-RVA: 0x32380F0 Offset: 0x32381F1 VA: 0x32380F0
	|-List<GradientAlphaKey>.RemoveAt
	|
	|-RVA: 0x323B420 Offset: 0x323B521 VA: 0x323B420
	|-List<GradientColorKey>.RemoveAt
	|
	|-RVA: 0x323E910 Offset: 0x323EA11 VA: 0x323E910
	|-List<Keyframe>.RemoveAt
	|
	|-RVA: 0x3241900 Offset: 0x3241A01 VA: 0x3241900
	|-List<LayerMask>.RemoveAt
	|
	|-RVA: 0x3244F70 Offset: 0x3245071 VA: 0x3244F70
	|-List<Matrix4x4>.RemoveAt
	|
	|-RVA: 0x3248430 Offset: 0x3248531 VA: 0x3248430
	|-List<ParticleSystem.Particle>.RemoveAt
	|
	|-RVA: 0x324B480 Offset: 0x324B581 VA: 0x324B480
	|-List<Playable>.RemoveAt
	|
	|-RVA: 0x324E7F0 Offset: 0x324E8F1 VA: 0x324E7F0
	|-List<PlayableBinding>.RemoveAt
	|
	|-RVA: 0x3251840 Offset: 0x3251941 VA: 0x3251840
	|-List<PlayableGraph>.RemoveAt
	|
	|-RVA: 0x32547F0 Offset: 0x32548F1 VA: 0x32547F0
	|-List<Edge>.RemoveAt
	|
	|-RVA: 0x3257870 Offset: 0x3257971 VA: 0x3257870
	|-List<Quaternion>.RemoveAt
	|
	|-RVA: 0x325A820 Offset: 0x325A921 VA: 0x325A820
	|-List<RangeInt>.RemoveAt
	|
	|-RVA: 0x325DD50 Offset: 0x325DE51 VA: 0x325DD50
	|-List<RaycastHit2D>.RemoveAt
	|
	|-RVA: 0x32613F0 Offset: 0x32614F1 VA: 0x32613F0
	|-List<RaycastHit>.RemoveAt
	|
	|-RVA: 0x33C2CB0 Offset: 0x33C2DB1 VA: 0x33C2CB0
	|-List<Rect>.RemoveAt
	|
	|-RVA: 0x33C5CC0 Offset: 0x33C5DC1 VA: 0x33C5CC0
	|-List<RectInt>.RemoveAt
	|
	|-RVA: 0x33C8CF0 Offset: 0x33C8DF1 VA: 0x33C8CF0
	|-List<ReflectionProbeBlendInfo>.RemoveAt
	|
	|-RVA: 0x33CC9D0 Offset: 0x33CCAD1 VA: 0x33CC9D0
	|-List<SphericalHarmonicsL2>.RemoveAt
	|
	|-RVA: 0x33CFA70 Offset: 0x33CFB71 VA: 0x33CFA70
	|-List<VertexAttributeDescriptor>.RemoveAt
	|
	|-RVA: 0x33D2DD0 Offset: 0x33D2ED1 VA: 0x33D2DD0
	|-List<AsyncOperationHandle>.RemoveAt
	|
	|-RVA: 0x33D6170 Offset: 0x33D6271 VA: 0x33D6170
	|-List<AsyncOperationHandle<SceneInstance>>.RemoveAt
	|
	|-RVA: 0x33D9740 Offset: 0x33D9841 VA: 0x33D9740
	|-List<DiagnosticEvent>.RemoveAt
	|
	|-RVA: 0x33DCAE0 Offset: 0x33DCBE1 VA: 0x33DCAE0
	|-List<DelayedActionManager.DelegateInfo>.RemoveAt
	|
	|-RVA: 0x33E00B0 Offset: 0x33E01B1 VA: 0x33E00B0
	|-List<ObjectInitializationData>.RemoveAt
	|
	|-RVA: 0x31BB040 Offset: 0x31BB141 VA: 0x31BB040
	|-List<GlyphRect>.RemoveAt
	|
	|-RVA: 0x31BE500 Offset: 0x31BE601 VA: 0x31BE500
	|-List<AnimationOutputWeightProcessor.WeightInfo>.RemoveAt
	|
	|-RVA: 0x31C1840 Offset: 0x31C1941 VA: 0x31C1840
	|-List<IntervalTreeNode>.RemoveAt
	|
	|-RVA: 0x31C4BD0 Offset: 0x31C4CD1 VA: 0x31C4BD0
	|-List<IntervalTree.Entry<object>>.RemoveAt
	|
	|-RVA: 0x31C7F70 Offset: 0x31C8071 VA: 0x31C7F70
	|-List<TimeNotificationBehaviour.NotificationEntry>.RemoveAt
	|
	|-RVA: 0x31CB030 Offset: 0x31CB131 VA: 0x31CB030
	|-List<UICharInfo>.RemoveAt
	|
	|-RVA: 0x31CE060 Offset: 0x31CE161 VA: 0x31CE060
	|-List<FocusController.FocusedElement>.RemoveAt
	|
	|-RVA: 0x31D1080 Offset: 0x31D1181 VA: 0x31D1080
	|-List<UILineInfo>.RemoveAt
	|
	|-RVA: 0x31D4A20 Offset: 0x31D4B21 VA: 0x31D4A20
	|-List<UIVertex>.RemoveAt
	|
	|-RVA: 0x31D7DE0 Offset: 0x31D7EE1 VA: 0x31D7DE0
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveAt
	|
	|-RVA: 0x31DAE40 Offset: 0x31DAF41 VA: 0x31DAE40
	|-List<Vector2>.RemoveAt
	|
	|-RVA: 0x2CE3A00 Offset: 0x2CE3B01 VA: 0x2CE3A00
	|-List<Vector2Int>.RemoveAt
	|
	|-RVA: 0x2CE6A80 Offset: 0x2CE6B81 VA: 0x2CE6A80
	|-List<Vector3>.RemoveAt
	|
	|-RVA: 0x2CE9B40 Offset: 0x2CE9C41 VA: 0x2CE9B40
	|-List<Vector3Int>.RemoveAt
	|
	|-RVA: 0x2CECBC0 Offset: 0x2CECCC1 VA: 0x2CECBC0
	|-List<Vector4>.RemoveAt
	|
	|-RVA: 0x2CF0830 Offset: 0x2CF0931 VA: 0x2CF0830
	|-List<WarpPoints.WarpPoint>.RemoveAt
	|
	|-RVA: 0x2CF3880 Offset: 0x2CF3981 VA: 0x2CF3880
	|-List<YieldItemParam>.RemoveAt
	|
	|-RVA: 0x2CF6BE0 Offset: 0x2CF6CE1 VA: 0x2CF6BE0
	|-List<stCommand_t>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248EEF0 Offset: 0x248EFF1 VA: 0x248EEF0
	|-List<AS_ToolController.ChargeInfo>.RemoveRange
	|
	|-RVA: 0x2492C10 Offset: 0x2492D11 VA: 0x2492C10
	|-List<BuildItemData>.RemoveRange
	|
	|-RVA: 0x3158240 Offset: 0x3158341 VA: 0x3158240
	|-List<ButtonLinker.LinkObject>.RemoveRange
	|
	|-RVA: 0x315B250 Offset: 0x315B351 VA: 0x315B250
	|-List<CharaCallTable.BustupTable>.RemoveRange
	|
	|-RVA: 0x315E310 Offset: 0x315E411 VA: 0x315E310
	|-List<CharaCallTable.CharaFaceIconTable>.RemoveRange
	|
	|-RVA: 0x3161350 Offset: 0x3161451 VA: 0x3161350
	|-List<CameraState.CustomBlendable>.RemoveRange
	|
	|-RVA: 0x3164300 Offset: 0x3164401 VA: 0x3164300
	|-List<CinemachineClearShot.Pair>.RemoveRange
	|
	|-RVA: 0x31672B0 Offset: 0x31673B1 VA: 0x31672B0
	|-List<CinemachineStateDrivenCamera.HashPair>.RemoveRange
	|
	|-RVA: 0x316A790 Offset: 0x316A891 VA: 0x316A790
	|-List<TargetPositionCache.CacheCurve.Item>.RemoveRange
	|
	|-RVA: 0x316DCF0 Offset: 0x316DDF1 VA: 0x316DCF0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.RemoveRange
	|
	|-RVA: 0x31712C0 Offset: 0x31713C1 VA: 0x31712C0
	|-List<CropDataTable>.RemoveRange
	|
	|-RVA: 0x3174270 Offset: 0x3174371 VA: 0x3174270
	|-List<DropItemParam>.RemoveRange
	|
	|-RVA: 0x3177620 Offset: 0x3177721 VA: 0x3177620
	|-List<ErosionBrush.UndoStep>.RemoveRange
	|
	|-RVA: 0x31DE2A0 Offset: 0x31DE3A1 VA: 0x31DE2A0
	|-List<EventCheckId>.RemoveRange
	|
	|-RVA: 0x31E12F0 Offset: 0x31E13F1 VA: 0x31E12F0
	|-List<EventFlagProgressData>.RemoveRange
	|
	|-RVA: 0x31E4340 Offset: 0x31E4441 VA: 0x31E4340
	|-List<FesNpcScoreData>.RemoveRange
	|
	|-RVA: 0x31E78A0 Offset: 0x31E79A1 VA: 0x31E78A0
	|-List<MiningPointSaveData>.RemoveRange
	|
	|-RVA: 0x31EADC0 Offset: 0x31EAEC1 VA: 0x31EADC0
	|-List<MonsterHutSaveData>.RemoveRange
	|
	|-RVA: 0x31EDE10 Offset: 0x31EDF11 VA: 0x31EDE10
	|-List<MoviePlayer.SUBTITLEDATA>.RemoveRange
	|
	|-RVA: 0x31F14D0 Offset: 0x31F15D1 VA: 0x31F14D0
	|-List<NPCActionData>.RemoveRange
	|
	|-RVA: 0x31F4870 Offset: 0x31F4971 VA: 0x31F4870
	|-List<NpcPlaceSchedule>.RemoveRange
	|
	|-RVA: 0x31F7930 Offset: 0x31F7A31 VA: 0x31F7930
	|-List<OrderLotterySaveParameter>.RemoveRange
	|
	|-RVA: 0x31FACE0 Offset: 0x31FADE1 VA: 0x31FACE0
	|-List<OrderSaveParameter>.RemoveRange
	|
	|-RVA: 0x31FDD30 Offset: 0x31FDE31 VA: 0x31FDD30
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.RemoveRange
	|
	|-RVA: 0x327D580 Offset: 0x327D681 VA: 0x327D580
	|-List<Point2D>.RemoveRange
	|-List<object>.RemoveRange
	|-List<RegexCharClass.SingleRange>.RemoveRange
	|-List<RegexNode>.RemoveRange
	|-List<UIButtonLinkerInScrollBox>.RemoveRange
	|-List<Camera>.RemoveRange
	|
	|-RVA: 0x330CF90 Offset: 0x330D091 VA: 0x330CF90
	|-List<ShopCatalogPage>.RemoveRange
	|
	|-RVA: 0x3310550 Offset: 0x3310651 VA: 0x3310550
	|-List<ShopNpcTalk>.RemoveRange
	|
	|-RVA: 0x3313610 Offset: 0x3313711 VA: 0x3313610
	|-List<SubtitleDataTable.Data>.RemoveRange
	|
	|-RVA: 0x33165E0 Offset: 0x33166E1 VA: 0x33165E0
	|-List<SubtitleDataTable.DataList>.RemoveRange
	|
	|-RVA: 0x33196A0 Offset: 0x33197A1 VA: 0x33196A0
	|-List<SubtitleHudDataTable.Data>.RemoveRange
	|
	|-RVA: 0x331CA50 Offset: 0x331CB51 VA: 0x331CA50
	|-List<SRMonoBehaviourEx.FieldInfo>.RemoveRange
	|
	|-RVA: 0x331FDA0 Offset: 0x331FEA1 VA: 0x331FDA0
	|-List<Schedule>.RemoveRange
	|
	|-RVA: 0x3323650 Offset: 0x3323751 VA: 0x3323650
	|-List<CurveSample>.RemoveRange
	|
	|-RVA: 0x3326640 Offset: 0x3326741 VA: 0x3326640
	|-List<bool>.RemoveRange
	|
	|-RVA: 0x3329610 Offset: 0x3329711 VA: 0x3329610
	|-List<byte>.RemoveRange
	|
	|-RVA: 0x332C5C0 Offset: 0x332C6C1 VA: 0x332C5C0
	|-List<char>.RemoveRange
	|
	|-RVA: 0x335A6B0 Offset: 0x335A7B1 VA: 0x335A6B0
	|-List<KeyValuePair<DateTime, object>>.RemoveRange
	|
	|-RVA: 0x335D700 Offset: 0x335D801 VA: 0x335D700
	|-List<KeyValuePair<int, object>>.RemoveRange
	|
	|-RVA: 0x3360740 Offset: 0x3360841 VA: 0x3360740
	|-List<KeyValuePair<object, object>>.RemoveRange
	|
	|-RVA: 0x33636F0 Offset: 0x33637F1 VA: 0x33636F0
	|-List<DateTime>.RemoveRange
	|
	|-RVA: 0x33666A0 Offset: 0x33667A1 VA: 0x33666A0
	|-List<double>.RemoveRange
	|
	|-RVA: 0x3369650 Offset: 0x3369751 VA: 0x3369650
	|-List<short>.RemoveRange
	|
	|-RVA: 0x336C600 Offset: 0x336C701 VA: 0x336C600
	|-List<int>.RemoveRange
	|
	|-RVA: 0x336F5B0 Offset: 0x336F6B1 VA: 0x336F5B0
	|-List<Int32Enum>.RemoveRange
	|-List<RegexOptions>.RemoveRange
	|
	|-RVA: 0x3372560 Offset: 0x3372661 VA: 0x3372560
	|-List<long>.RemoveRange
	|
	|-RVA: 0x33755A0 Offset: 0x33756A1 VA: 0x33755A0
	|-List<InterpretedFrameInfo>.RemoveRange
	|
	|-RVA: 0x33785A0 Offset: 0x33786A1 VA: 0x33785A0
	|-List<Nullable<Int32Enum>>.RemoveRange
	|
	|-RVA: 0x34077F0 Offset: 0x34078F1 VA: 0x34077F0
	|-List<Nullable<Bounds>>.RemoveRange
	|
	|-RVA: 0x340ADB0 Offset: 0x340AEB1 VA: 0x340ADB0
	|-List<Nullable<BoundsInt>>.RemoveRange
	|
	|-RVA: 0x340DDB0 Offset: 0x340DEB1 VA: 0x340DDB0
	|-List<Nullable<Color32>>.RemoveRange
	|
	|-RVA: 0x3411210 Offset: 0x3411311 VA: 0x3411210
	|-List<Nullable<Color>>.RemoveRange
	|
	|-RVA: 0x3414330 Offset: 0x3414431 VA: 0x3414330
	|-List<Nullable<GradientAlphaKey>>.RemoveRange
	|
	|-RVA: 0x3417780 Offset: 0x3417881 VA: 0x3417780
	|-List<Nullable<GradientColorKey>>.RemoveRange
	|
	|-RVA: 0x341ABE0 Offset: 0x341ACE1 VA: 0x341ABE0
	|-List<Nullable<Keyframe>>.RemoveRange
	|
	|-RVA: 0x341DBE0 Offset: 0x341DCE1 VA: 0x341DBE0
	|-List<Nullable<LayerMask>>.RemoveRange
	|
	|-RVA: 0x3421620 Offset: 0x3421721 VA: 0x3421620
	|-List<Nullable<Matrix4x4>>.RemoveRange
	|
	|-RVA: 0x3424A80 Offset: 0x3424B81 VA: 0x3424A80
	|-List<Nullable<Quaternion>>.RemoveRange
	|
	|-RVA: 0x3264610 Offset: 0x3264711 VA: 0x3264610
	|-List<Nullable<RangeInt>>.RemoveRange
	|
	|-RVA: 0x3267A70 Offset: 0x3267B71 VA: 0x3267A70
	|-List<Nullable<Rect>>.RemoveRange
	|
	|-RVA: 0x326AED0 Offset: 0x326AFD1 VA: 0x326AED0
	|-List<Nullable<RectInt>>.RemoveRange
	|
	|-RVA: 0x326DFF0 Offset: 0x326E0F1 VA: 0x326DFF0
	|-List<Nullable<Vector2>>.RemoveRange
	|
	|-RVA: 0x3271110 Offset: 0x3271211 VA: 0x3271110
	|-List<Nullable<Vector2Int>>.RemoveRange
	|
	|-RVA: 0x3274180 Offset: 0x3274281 VA: 0x3274180
	|-List<Nullable<Vector3>>.RemoveRange
	|
	|-RVA: 0x32771F0 Offset: 0x32772F1 VA: 0x32771F0
	|-List<Nullable<Vector3Int>>.RemoveRange
	|
	|-RVA: 0x327A650 Offset: 0x327A751 VA: 0x327A650
	|-List<Nullable<Vector4>>.RemoveRange
	|
	|-RVA: 0x3280550 Offset: 0x3280651 VA: 0x3280550
	|-List<sbyte>.RemoveRange
	|
	|-RVA: 0x3283500 Offset: 0x3283601 VA: 0x3283500
	|-List<float>.RemoveRange
	|
	|-RVA: 0x32AA760 Offset: 0x32AA861 VA: 0x32AA760
	|-List<ushort>.RemoveRange
	|
	|-RVA: 0x32AD710 Offset: 0x32AD811 VA: 0x32AD710
	|-List<uint>.RemoveRange
	|
	|-RVA: 0x32B06C0 Offset: 0x32B07C1 VA: 0x32B06C0
	|-List<ulong>.RemoveRange
	|
	|-RVA: 0x32B3670 Offset: 0x32B3771 VA: 0x32B3670
	|-List<ValueTuple<bool, Int32Enum>>.RemoveRange
	|
	|-RVA: 0x32B6620 Offset: 0x32B6721 VA: 0x32B6620
	|-List<ValueTuple<Int32Enum, int>>.RemoveRange
	|
	|-RVA: 0x32B9670 Offset: 0x32B9771 VA: 0x32B9670
	|-List<ValueTuple<Int32Enum, object>>.RemoveRange
	|
	|-RVA: 0x32BC6B0 Offset: 0x32BC7B1 VA: 0x32BC6B0
	|-List<ValueTuple<object, Int32Enum>>.RemoveRange
	|
	|-RVA: 0x32BF6F0 Offset: 0x32BF7F1 VA: 0x32BF6F0
	|-List<ValueTuple<object, object>>.RemoveRange
	|
	|-RVA: 0x32C2730 Offset: 0x32C2831 VA: 0x32C2730
	|-List<ValueTuple<object, float>>.RemoveRange
	|
	|-RVA: 0x32C57F0 Offset: 0x32C58F1 VA: 0x32C57F0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.RemoveRange
	|
	|-RVA: 0x32C8EE0 Offset: 0x32C8FE1 VA: 0x32C8EE0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.RemoveRange
	|
	|-RVA: 0x3112B40 Offset: 0x3112C41 VA: 0x3112B40
	|-List<TexturePacker_JsonArray.Frame>.RemoveRange
	|
	|-RVA: 0x3115C00 Offset: 0x3115D01 VA: 0x3115C00
	|-List<TutorialUnlockFlagData>.RemoveRange
	|
	|-RVA: 0x3118C50 Offset: 0x3118D51 VA: 0x3118C50
	|-List<UIMainManagerAttachObject.AttachSet>.RemoveRange
	|
	|-RVA: 0x311C1B0 Offset: 0x311C2B1 VA: 0x311C1B0
	|-List<CapEdge>.RemoveRange
	|
	|-RVA: 0x311F160 Offset: 0x311F261 VA: 0x311F160
	|-List<MeshDataConnectivity.Face>.RemoveRange
	|
	|-RVA: 0x31224B0 Offset: 0x31225B1 VA: 0x31224B0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.RemoveRange
	|
	|-RVA: 0x3125A70 Offset: 0x3125B71 VA: 0x3125A70
	|-List<MeshFaceConnectivity.EdgeData>.RemoveRange
	|
	|-RVA: 0x3128A80 Offset: 0x3128B81 VA: 0x3128A80
	|-List<NavMeshBuildMarkup>.RemoveRange
	|
	|-RVA: 0x312C650 Offset: 0x312C751 VA: 0x312C650
	|-List<NavMeshBuildSource>.RemoveRange
	|
	|-RVA: 0x312F690 Offset: 0x312F791 VA: 0x312F690
	|-List<ConstraintSource>.RemoveRange
	|
	|-RVA: 0x3132640 Offset: 0x3132741 VA: 0x3132640
	|-List<AnimatorClipInfo>.RemoveRange
	|
	|-RVA: 0x321E270 Offset: 0x321E371 VA: 0x321E270
	|-List<BeforeRenderHelper.OrderBlock>.RemoveRange
	|
	|-RVA: 0x32215D0 Offset: 0x32216D1 VA: 0x32215D0
	|-List<BoneWeight>.RemoveRange
	|
	|-RVA: 0x3224920 Offset: 0x3224A21 VA: 0x3224920
	|-List<Bounds>.RemoveRange
	|
	|-RVA: 0x3227C70 Offset: 0x3227D71 VA: 0x3227C70
	|-List<BoundsInt>.RemoveRange
	|
	|-RVA: 0x322AC40 Offset: 0x322AD41 VA: 0x322AC40
	|-List<Color32>.RemoveRange
	|
	|-RVA: 0x322DCC0 Offset: 0x322DDC1 VA: 0x322DCC0
	|-List<Color>.RemoveRange
	|
	|-RVA: 0x32318B0 Offset: 0x32319B1 VA: 0x32318B0
	|-List<CombineInstance>.RemoveRange
	|
	|-RVA: 0x3235190 Offset: 0x3235291 VA: 0x3235190
	|-List<RaycastResult>.RemoveRange
	|
	|-RVA: 0x32381B0 Offset: 0x32382B1 VA: 0x32381B0
	|-List<GradientAlphaKey>.RemoveRange
	|
	|-RVA: 0x323B510 Offset: 0x323B611 VA: 0x323B510
	|-List<GradientColorKey>.RemoveRange
	|
	|-RVA: 0x323E9F0 Offset: 0x323EAF1 VA: 0x323E9F0
	|-List<Keyframe>.RemoveRange
	|
	|-RVA: 0x32419C0 Offset: 0x3241AC1 VA: 0x32419C0
	|-List<LayerMask>.RemoveRange
	|
	|-RVA: 0x3245070 Offset: 0x3245171 VA: 0x3245070
	|-List<Matrix4x4>.RemoveRange
	|
	|-RVA: 0x3248530 Offset: 0x3248631 VA: 0x3248530
	|-List<ParticleSystem.Particle>.RemoveRange
	|
	|-RVA: 0x324B540 Offset: 0x324B641 VA: 0x324B540
	|-List<Playable>.RemoveRange
	|
	|-RVA: 0x324E8F0 Offset: 0x324E9F1 VA: 0x324E8F0
	|-List<PlayableBinding>.RemoveRange
	|
	|-RVA: 0x3251900 Offset: 0x3251A01 VA: 0x3251900
	|-List<PlayableGraph>.RemoveRange
	|
	|-RVA: 0x32548B0 Offset: 0x32549B1 VA: 0x32548B0
	|-List<Edge>.RemoveRange
	|
	|-RVA: 0x3257930 Offset: 0x3257A31 VA: 0x3257930
	|-List<Quaternion>.RemoveRange
	|
	|-RVA: 0x325A8E0 Offset: 0x325A9E1 VA: 0x325A8E0
	|-List<RangeInt>.RemoveRange
	|
	|-RVA: 0x325DE40 Offset: 0x325DF41 VA: 0x325DE40
	|-List<RaycastHit2D>.RemoveRange
	|
	|-RVA: 0x32614F0 Offset: 0x32615F1 VA: 0x32614F0
	|-List<RaycastHit>.RemoveRange
	|
	|-RVA: 0x33C2D70 Offset: 0x33C2E71 VA: 0x33C2D70
	|-List<Rect>.RemoveRange
	|
	|-RVA: 0x33C5D80 Offset: 0x33C5E81 VA: 0x33C5D80
	|-List<RectInt>.RemoveRange
	|
	|-RVA: 0x33C8DC0 Offset: 0x33C8EC1 VA: 0x33C8DC0
	|-List<ReflectionProbeBlendInfo>.RemoveRange
	|
	|-RVA: 0x33CCB20 Offset: 0x33CCC21 VA: 0x33CCB20
	|-List<SphericalHarmonicsL2>.RemoveRange
	|
	|-RVA: 0x33CFB30 Offset: 0x33CFC31 VA: 0x33CFB30
	|-List<VertexAttributeDescriptor>.RemoveRange
	|
	|-RVA: 0x33D2ED0 Offset: 0x33D2FD1 VA: 0x33D2ED0
	|-List<AsyncOperationHandle>.RemoveRange
	|
	|-RVA: 0x33D6270 Offset: 0x33D6371 VA: 0x33D6270
	|-List<AsyncOperationHandle<SceneInstance>>.RemoveRange
	|
	|-RVA: 0x33D9830 Offset: 0x33D9931 VA: 0x33D9830
	|-List<DiagnosticEvent>.RemoveRange
	|
	|-RVA: 0x33DCBE0 Offset: 0x33DCCE1 VA: 0x33DCBE0
	|-List<DelayedActionManager.DelegateInfo>.RemoveRange
	|
	|-RVA: 0x33E01A0 Offset: 0x33E02A1 VA: 0x33E01A0
	|-List<ObjectInitializationData>.RemoveRange
	|
	|-RVA: 0x31BB100 Offset: 0x31BB201 VA: 0x31BB100
	|-List<GlyphRect>.RemoveRange
	|
	|-RVA: 0x31BE5E0 Offset: 0x31BE6E1 VA: 0x31BE5E0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.RemoveRange
	|
	|-RVA: 0x31C1930 Offset: 0x31C1A31 VA: 0x31C1930
	|-List<IntervalTreeNode>.RemoveRange
	|
	|-RVA: 0x31C4CD0 Offset: 0x31C4DD1 VA: 0x31C4CD0
	|-List<IntervalTree.Entry<object>>.RemoveRange
	|
	|-RVA: 0x31C8070 Offset: 0x31C8171 VA: 0x31C8070
	|-List<TimeNotificationBehaviour.NotificationEntry>.RemoveRange
	|
	|-RVA: 0x31CB0F0 Offset: 0x31CB1F1 VA: 0x31CB0F0
	|-List<UICharInfo>.RemoveRange
	|
	|-RVA: 0x31CE130 Offset: 0x31CE231 VA: 0x31CE130
	|-List<FocusController.FocusedElement>.RemoveRange
	|
	|-RVA: 0x31D1140 Offset: 0x31D1241 VA: 0x31D1140
	|-List<UILineInfo>.RemoveRange
	|
	|-RVA: 0x31D4B40 Offset: 0x31D4C41 VA: 0x31D4B40
	|-List<UIVertex>.RemoveRange
	|
	|-RVA: 0x31D7EE0 Offset: 0x31D7FE1 VA: 0x31D7EE0
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveRange
	|
	|-RVA: 0x31DAF00 Offset: 0x31DB001 VA: 0x31DAF00
	|-List<Vector2>.RemoveRange
	|
	|-RVA: 0x2CE3AC0 Offset: 0x2CE3BC1 VA: 0x2CE3AC0
	|-List<Vector2Int>.RemoveRange
	|
	|-RVA: 0x2CE6B40 Offset: 0x2CE6C41 VA: 0x2CE6B40
	|-List<Vector3>.RemoveRange
	|
	|-RVA: 0x2CE9C00 Offset: 0x2CE9D01 VA: 0x2CE9C00
	|-List<Vector3Int>.RemoveRange
	|
	|-RVA: 0x2CECC80 Offset: 0x2CECD81 VA: 0x2CECC80
	|-List<Vector4>.RemoveRange
	|
	|-RVA: 0x2CF0990 Offset: 0x2CF0A91 VA: 0x2CF0990
	|-List<WarpPoints.WarpPoint>.RemoveRange
	|
	|-RVA: 0x2CF3940 Offset: 0x2CF3A41 VA: 0x2CF3940
	|-List<YieldItemParam>.RemoveRange
	|
	|-RVA: 0x2CF6CE0 Offset: 0x2CF6DE1 VA: 0x2CF6CE0
	|-List<stCommand_t>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public void Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248EFE0 Offset: 0x248F0E1 VA: 0x248EFE0
	|-List<AS_ToolController.ChargeInfo>.Reverse
	|
	|-RVA: 0x2492D00 Offset: 0x2492E01 VA: 0x2492D00
	|-List<BuildItemData>.Reverse
	|
	|-RVA: 0x3158330 Offset: 0x3158431 VA: 0x3158330
	|-List<ButtonLinker.LinkObject>.Reverse
	|
	|-RVA: 0x315B340 Offset: 0x315B441 VA: 0x315B340
	|-List<CharaCallTable.BustupTable>.Reverse
	|
	|-RVA: 0x315E400 Offset: 0x315E501 VA: 0x315E400
	|-List<CharaCallTable.CharaFaceIconTable>.Reverse
	|
	|-RVA: 0x3161440 Offset: 0x3161541 VA: 0x3161440
	|-List<CameraState.CustomBlendable>.Reverse
	|
	|-RVA: 0x31643F0 Offset: 0x31644F1 VA: 0x31643F0
	|-List<CinemachineClearShot.Pair>.Reverse
	|
	|-RVA: 0x31673A0 Offset: 0x31674A1 VA: 0x31673A0
	|-List<CinemachineStateDrivenCamera.HashPair>.Reverse
	|
	|-RVA: 0x316A880 Offset: 0x316A981 VA: 0x316A880
	|-List<TargetPositionCache.CacheCurve.Item>.Reverse
	|
	|-RVA: 0x316DDE0 Offset: 0x316DEE1 VA: 0x316DDE0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Reverse
	|
	|-RVA: 0x31713B0 Offset: 0x31714B1 VA: 0x31713B0
	|-List<CropDataTable>.Reverse
	|
	|-RVA: 0x3174360 Offset: 0x3174461 VA: 0x3174360
	|-List<DropItemParam>.Reverse
	|
	|-RVA: 0x3177710 Offset: 0x3177811 VA: 0x3177710
	|-List<ErosionBrush.UndoStep>.Reverse
	|
	|-RVA: 0x31DE390 Offset: 0x31DE491 VA: 0x31DE390
	|-List<EventCheckId>.Reverse
	|
	|-RVA: 0x31E13E0 Offset: 0x31E14E1 VA: 0x31E13E0
	|-List<EventFlagProgressData>.Reverse
	|
	|-RVA: 0x31E4430 Offset: 0x31E4531 VA: 0x31E4430
	|-List<FesNpcScoreData>.Reverse
	|
	|-RVA: 0x31E7990 Offset: 0x31E7A91 VA: 0x31E7990
	|-List<MiningPointSaveData>.Reverse
	|
	|-RVA: 0x31EAEB0 Offset: 0x31EAFB1 VA: 0x31EAEB0
	|-List<MonsterHutSaveData>.Reverse
	|
	|-RVA: 0x31EDF00 Offset: 0x31EE001 VA: 0x31EDF00
	|-List<MoviePlayer.SUBTITLEDATA>.Reverse
	|
	|-RVA: 0x31F15C0 Offset: 0x31F16C1 VA: 0x31F15C0
	|-List<NPCActionData>.Reverse
	|
	|-RVA: 0x31F4960 Offset: 0x31F4A61 VA: 0x31F4960
	|-List<NpcPlaceSchedule>.Reverse
	|
	|-RVA: 0x31F7A20 Offset: 0x31F7B21 VA: 0x31F7A20
	|-List<OrderLotterySaveParameter>.Reverse
	|
	|-RVA: 0x31FADD0 Offset: 0x31FAED1 VA: 0x31FADD0
	|-List<OrderSaveParameter>.Reverse
	|
	|-RVA: 0x31FDE20 Offset: 0x31FDF21 VA: 0x31FDE20
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Reverse
	|
	|-RVA: 0x327D670 Offset: 0x327D771 VA: 0x327D670
	|-List<Point2D>.Reverse
	|-List<object>.Reverse
	|-List<MethodInfo>.Reverse
	|
	|-RVA: 0x330D080 Offset: 0x330D181 VA: 0x330D080
	|-List<ShopCatalogPage>.Reverse
	|
	|-RVA: 0x3310640 Offset: 0x3310741 VA: 0x3310640
	|-List<ShopNpcTalk>.Reverse
	|
	|-RVA: 0x3313700 Offset: 0x3313801 VA: 0x3313700
	|-List<SubtitleDataTable.Data>.Reverse
	|
	|-RVA: 0x33166D0 Offset: 0x33167D1 VA: 0x33166D0
	|-List<SubtitleDataTable.DataList>.Reverse
	|
	|-RVA: 0x3319790 Offset: 0x3319891 VA: 0x3319790
	|-List<SubtitleHudDataTable.Data>.Reverse
	|
	|-RVA: 0x331CB40 Offset: 0x331CC41 VA: 0x331CB40
	|-List<SRMonoBehaviourEx.FieldInfo>.Reverse
	|
	|-RVA: 0x331FE90 Offset: 0x331FF91 VA: 0x331FE90
	|-List<Schedule>.Reverse
	|
	|-RVA: 0x3323740 Offset: 0x3323841 VA: 0x3323740
	|-List<CurveSample>.Reverse
	|
	|-RVA: 0x3326730 Offset: 0x3326831 VA: 0x3326730
	|-List<bool>.Reverse
	|
	|-RVA: 0x3329700 Offset: 0x3329801 VA: 0x3329700
	|-List<byte>.Reverse
	|
	|-RVA: 0x332C6B0 Offset: 0x332C7B1 VA: 0x332C6B0
	|-List<char>.Reverse
	|
	|-RVA: 0x335A7A0 Offset: 0x335A8A1 VA: 0x335A7A0
	|-List<KeyValuePair<DateTime, object>>.Reverse
	|
	|-RVA: 0x335D7F0 Offset: 0x335D8F1 VA: 0x335D7F0
	|-List<KeyValuePair<int, object>>.Reverse
	|
	|-RVA: 0x3360830 Offset: 0x3360931 VA: 0x3360830
	|-List<KeyValuePair<object, object>>.Reverse
	|
	|-RVA: 0x33637E0 Offset: 0x33638E1 VA: 0x33637E0
	|-List<DateTime>.Reverse
	|
	|-RVA: 0x3366790 Offset: 0x3366891 VA: 0x3366790
	|-List<double>.Reverse
	|
	|-RVA: 0x3369740 Offset: 0x3369841 VA: 0x3369740
	|-List<short>.Reverse
	|
	|-RVA: 0x336C6F0 Offset: 0x336C7F1 VA: 0x336C6F0
	|-List<int>.Reverse
	|
	|-RVA: 0x336F6A0 Offset: 0x336F7A1 VA: 0x336F6A0
	|-List<Int32Enum>.Reverse
	|
	|-RVA: 0x3372650 Offset: 0x3372751 VA: 0x3372650
	|-List<long>.Reverse
	|
	|-RVA: 0x3375690 Offset: 0x3375791 VA: 0x3375690
	|-List<InterpretedFrameInfo>.Reverse
	|
	|-RVA: 0x3378690 Offset: 0x3378791 VA: 0x3378690
	|-List<Nullable<Int32Enum>>.Reverse
	|
	|-RVA: 0x34078E0 Offset: 0x34079E1 VA: 0x34078E0
	|-List<Nullable<Bounds>>.Reverse
	|
	|-RVA: 0x340AEA0 Offset: 0x340AFA1 VA: 0x340AEA0
	|-List<Nullable<BoundsInt>>.Reverse
	|
	|-RVA: 0x340DEA0 Offset: 0x340DFA1 VA: 0x340DEA0
	|-List<Nullable<Color32>>.Reverse
	|
	|-RVA: 0x3411300 Offset: 0x3411401 VA: 0x3411300
	|-List<Nullable<Color>>.Reverse
	|
	|-RVA: 0x3414420 Offset: 0x3414521 VA: 0x3414420
	|-List<Nullable<GradientAlphaKey>>.Reverse
	|
	|-RVA: 0x3417870 Offset: 0x3417971 VA: 0x3417870
	|-List<Nullable<GradientColorKey>>.Reverse
	|
	|-RVA: 0x341ACD0 Offset: 0x341ADD1 VA: 0x341ACD0
	|-List<Nullable<Keyframe>>.Reverse
	|
	|-RVA: 0x341DCD0 Offset: 0x341DDD1 VA: 0x341DCD0
	|-List<Nullable<LayerMask>>.Reverse
	|
	|-RVA: 0x3421710 Offset: 0x3421811 VA: 0x3421710
	|-List<Nullable<Matrix4x4>>.Reverse
	|
	|-RVA: 0x3424B70 Offset: 0x3424C71 VA: 0x3424B70
	|-List<Nullable<Quaternion>>.Reverse
	|
	|-RVA: 0x3264700 Offset: 0x3264801 VA: 0x3264700
	|-List<Nullable<RangeInt>>.Reverse
	|
	|-RVA: 0x3267B60 Offset: 0x3267C61 VA: 0x3267B60
	|-List<Nullable<Rect>>.Reverse
	|
	|-RVA: 0x326AFC0 Offset: 0x326B0C1 VA: 0x326AFC0
	|-List<Nullable<RectInt>>.Reverse
	|
	|-RVA: 0x326E0E0 Offset: 0x326E1E1 VA: 0x326E0E0
	|-List<Nullable<Vector2>>.Reverse
	|
	|-RVA: 0x3271200 Offset: 0x3271301 VA: 0x3271200
	|-List<Nullable<Vector2Int>>.Reverse
	|
	|-RVA: 0x3274270 Offset: 0x3274371 VA: 0x3274270
	|-List<Nullable<Vector3>>.Reverse
	|
	|-RVA: 0x32772E0 Offset: 0x32773E1 VA: 0x32772E0
	|-List<Nullable<Vector3Int>>.Reverse
	|
	|-RVA: 0x327A740 Offset: 0x327A841 VA: 0x327A740
	|-List<Nullable<Vector4>>.Reverse
	|
	|-RVA: 0x3280640 Offset: 0x3280741 VA: 0x3280640
	|-List<sbyte>.Reverse
	|
	|-RVA: 0x32835F0 Offset: 0x32836F1 VA: 0x32835F0
	|-List<float>.Reverse
	|
	|-RVA: 0x32AA850 Offset: 0x32AA951 VA: 0x32AA850
	|-List<ushort>.Reverse
	|
	|-RVA: 0x32AD800 Offset: 0x32AD901 VA: 0x32AD800
	|-List<uint>.Reverse
	|
	|-RVA: 0x32B07B0 Offset: 0x32B08B1 VA: 0x32B07B0
	|-List<ulong>.Reverse
	|
	|-RVA: 0x32B3760 Offset: 0x32B3861 VA: 0x32B3760
	|-List<ValueTuple<bool, Int32Enum>>.Reverse
	|
	|-RVA: 0x32B6710 Offset: 0x32B6811 VA: 0x32B6710
	|-List<ValueTuple<Int32Enum, int>>.Reverse
	|
	|-RVA: 0x32B9760 Offset: 0x32B9861 VA: 0x32B9760
	|-List<ValueTuple<Int32Enum, object>>.Reverse
	|
	|-RVA: 0x32BC7A0 Offset: 0x32BC8A1 VA: 0x32BC7A0
	|-List<ValueTuple<object, Int32Enum>>.Reverse
	|
	|-RVA: 0x32BF7E0 Offset: 0x32BF8E1 VA: 0x32BF7E0
	|-List<ValueTuple<object, object>>.Reverse
	|
	|-RVA: 0x32C2820 Offset: 0x32C2921 VA: 0x32C2820
	|-List<ValueTuple<object, float>>.Reverse
	|
	|-RVA: 0x32C58E0 Offset: 0x32C59E1 VA: 0x32C58E0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Reverse
	|
	|-RVA: 0x32C8FD0 Offset: 0x32C90D1 VA: 0x32C8FD0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Reverse
	|
	|-RVA: 0x3112C30 Offset: 0x3112D31 VA: 0x3112C30
	|-List<TexturePacker_JsonArray.Frame>.Reverse
	|
	|-RVA: 0x3115CF0 Offset: 0x3115DF1 VA: 0x3115CF0
	|-List<TutorialUnlockFlagData>.Reverse
	|
	|-RVA: 0x3118D40 Offset: 0x3118E41 VA: 0x3118D40
	|-List<UIMainManagerAttachObject.AttachSet>.Reverse
	|
	|-RVA: 0x311C2A0 Offset: 0x311C3A1 VA: 0x311C2A0
	|-List<CapEdge>.Reverse
	|
	|-RVA: 0x311F250 Offset: 0x311F351 VA: 0x311F250
	|-List<MeshDataConnectivity.Face>.Reverse
	|
	|-RVA: 0x31225A0 Offset: 0x31226A1 VA: 0x31225A0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Reverse
	|
	|-RVA: 0x3125B60 Offset: 0x3125C61 VA: 0x3125B60
	|-List<MeshFaceConnectivity.EdgeData>.Reverse
	|
	|-RVA: 0x3128B70 Offset: 0x3128C71 VA: 0x3128B70
	|-List<NavMeshBuildMarkup>.Reverse
	|
	|-RVA: 0x312C740 Offset: 0x312C841 VA: 0x312C740
	|-List<NavMeshBuildSource>.Reverse
	|
	|-RVA: 0x312F780 Offset: 0x312F881 VA: 0x312F780
	|-List<ConstraintSource>.Reverse
	|
	|-RVA: 0x3132730 Offset: 0x3132831 VA: 0x3132730
	|-List<AnimatorClipInfo>.Reverse
	|
	|-RVA: 0x321E360 Offset: 0x321E461 VA: 0x321E360
	|-List<BeforeRenderHelper.OrderBlock>.Reverse
	|
	|-RVA: 0x32216C0 Offset: 0x32217C1 VA: 0x32216C0
	|-List<BoneWeight>.Reverse
	|
	|-RVA: 0x3224A10 Offset: 0x3224B11 VA: 0x3224A10
	|-List<Bounds>.Reverse
	|
	|-RVA: 0x3227D60 Offset: 0x3227E61 VA: 0x3227D60
	|-List<BoundsInt>.Reverse
	|
	|-RVA: 0x322AD30 Offset: 0x322AE31 VA: 0x322AD30
	|-List<Color32>.Reverse
	|
	|-RVA: 0x322DDB0 Offset: 0x322DEB1 VA: 0x322DDB0
	|-List<Color>.Reverse
	|
	|-RVA: 0x32319A0 Offset: 0x3231AA1 VA: 0x32319A0
	|-List<CombineInstance>.Reverse
	|
	|-RVA: 0x3235280 Offset: 0x3235381 VA: 0x3235280
	|-List<RaycastResult>.Reverse
	|
	|-RVA: 0x32382A0 Offset: 0x32383A1 VA: 0x32382A0
	|-List<GradientAlphaKey>.Reverse
	|
	|-RVA: 0x323B600 Offset: 0x323B701 VA: 0x323B600
	|-List<GradientColorKey>.Reverse
	|
	|-RVA: 0x323EAE0 Offset: 0x323EBE1 VA: 0x323EAE0
	|-List<Keyframe>.Reverse
	|
	|-RVA: 0x3241AB0 Offset: 0x3241BB1 VA: 0x3241AB0
	|-List<LayerMask>.Reverse
	|
	|-RVA: 0x3245160 Offset: 0x3245261 VA: 0x3245160
	|-List<Matrix4x4>.Reverse
	|
	|-RVA: 0x3248620 Offset: 0x3248721 VA: 0x3248620
	|-List<ParticleSystem.Particle>.Reverse
	|
	|-RVA: 0x324B630 Offset: 0x324B731 VA: 0x324B630
	|-List<Playable>.Reverse
	|
	|-RVA: 0x324E9E0 Offset: 0x324EAE1 VA: 0x324E9E0
	|-List<PlayableBinding>.Reverse
	|
	|-RVA: 0x32519F0 Offset: 0x3251AF1 VA: 0x32519F0
	|-List<PlayableGraph>.Reverse
	|
	|-RVA: 0x32549A0 Offset: 0x3254AA1 VA: 0x32549A0
	|-List<Edge>.Reverse
	|
	|-RVA: 0x3257A20 Offset: 0x3257B21 VA: 0x3257A20
	|-List<Quaternion>.Reverse
	|
	|-RVA: 0x325A9D0 Offset: 0x325AAD1 VA: 0x325A9D0
	|-List<RangeInt>.Reverse
	|
	|-RVA: 0x325DF30 Offset: 0x325E031 VA: 0x325DF30
	|-List<RaycastHit2D>.Reverse
	|
	|-RVA: 0x32615E0 Offset: 0x32616E1 VA: 0x32615E0
	|-List<RaycastHit>.Reverse
	|
	|-RVA: 0x33C2E60 Offset: 0x33C2F61 VA: 0x33C2E60
	|-List<Rect>.Reverse
	|
	|-RVA: 0x33C5E70 Offset: 0x33C5F71 VA: 0x33C5E70
	|-List<RectInt>.Reverse
	|
	|-RVA: 0x33C8EB0 Offset: 0x33C8FB1 VA: 0x33C8EB0
	|-List<ReflectionProbeBlendInfo>.Reverse
	|
	|-RVA: 0x33CCC10 Offset: 0x33CCD11 VA: 0x33CCC10
	|-List<SphericalHarmonicsL2>.Reverse
	|
	|-RVA: 0x33CFC20 Offset: 0x33CFD21 VA: 0x33CFC20
	|-List<VertexAttributeDescriptor>.Reverse
	|
	|-RVA: 0x33D2FC0 Offset: 0x33D30C1 VA: 0x33D2FC0
	|-List<AsyncOperationHandle>.Reverse
	|
	|-RVA: 0x33D6360 Offset: 0x33D6461 VA: 0x33D6360
	|-List<AsyncOperationHandle<SceneInstance>>.Reverse
	|
	|-RVA: 0x33D9920 Offset: 0x33D9A21 VA: 0x33D9920
	|-List<DiagnosticEvent>.Reverse
	|
	|-RVA: 0x33DCCD0 Offset: 0x33DCDD1 VA: 0x33DCCD0
	|-List<DelayedActionManager.DelegateInfo>.Reverse
	|
	|-RVA: 0x33E0290 Offset: 0x33E0391 VA: 0x33E0290
	|-List<ObjectInitializationData>.Reverse
	|
	|-RVA: 0x31BB1F0 Offset: 0x31BB2F1 VA: 0x31BB1F0
	|-List<GlyphRect>.Reverse
	|
	|-RVA: 0x31BE6D0 Offset: 0x31BE7D1 VA: 0x31BE6D0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Reverse
	|
	|-RVA: 0x31C1A20 Offset: 0x31C1B21 VA: 0x31C1A20
	|-List<IntervalTreeNode>.Reverse
	|
	|-RVA: 0x31C4DC0 Offset: 0x31C4EC1 VA: 0x31C4DC0
	|-List<IntervalTree.Entry<object>>.Reverse
	|
	|-RVA: 0x31C8160 Offset: 0x31C8261 VA: 0x31C8160
	|-List<TimeNotificationBehaviour.NotificationEntry>.Reverse
	|
	|-RVA: 0x31CB1E0 Offset: 0x31CB2E1 VA: 0x31CB1E0
	|-List<UICharInfo>.Reverse
	|
	|-RVA: 0x31CE220 Offset: 0x31CE321 VA: 0x31CE220
	|-List<FocusController.FocusedElement>.Reverse
	|
	|-RVA: 0x31D1230 Offset: 0x31D1331 VA: 0x31D1230
	|-List<UILineInfo>.Reverse
	|
	|-RVA: 0x31D4C30 Offset: 0x31D4D31 VA: 0x31D4C30
	|-List<UIVertex>.Reverse
	|
	|-RVA: 0x31D7FD0 Offset: 0x31D80D1 VA: 0x31D7FD0
	|-List<UnitySynchronizationContext.WorkRequest>.Reverse
	|
	|-RVA: 0x31DAFF0 Offset: 0x31DB0F1 VA: 0x31DAFF0
	|-List<Vector2>.Reverse
	|
	|-RVA: 0x2CE3BB0 Offset: 0x2CE3CB1 VA: 0x2CE3BB0
	|-List<Vector2Int>.Reverse
	|
	|-RVA: 0x2CE6C30 Offset: 0x2CE6D31 VA: 0x2CE6C30
	|-List<Vector3>.Reverse
	|
	|-RVA: 0x2CE9CF0 Offset: 0x2CE9DF1 VA: 0x2CE9CF0
	|-List<Vector3Int>.Reverse
	|
	|-RVA: 0x2CECD70 Offset: 0x2CECE71 VA: 0x2CECD70
	|-List<Vector4>.Reverse
	|
	|-RVA: 0x2CF0A80 Offset: 0x2CF0B81 VA: 0x2CF0A80
	|-List<WarpPoints.WarpPoint>.Reverse
	|
	|-RVA: 0x2CF3A30 Offset: 0x2CF3B31 VA: 0x2CF3A30
	|-List<YieldItemParam>.Reverse
	|
	|-RVA: 0x2CF6DD0 Offset: 0x2CF6ED1 VA: 0x2CF6DD0
	|-List<stCommand_t>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Reverse(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248F040 Offset: 0x248F141 VA: 0x248F040
	|-List<AS_ToolController.ChargeInfo>.Reverse
	|
	|-RVA: 0x2492D60 Offset: 0x2492E61 VA: 0x2492D60
	|-List<BuildItemData>.Reverse
	|
	|-RVA: 0x3158390 Offset: 0x3158491 VA: 0x3158390
	|-List<ButtonLinker.LinkObject>.Reverse
	|
	|-RVA: 0x315B3A0 Offset: 0x315B4A1 VA: 0x315B3A0
	|-List<CharaCallTable.BustupTable>.Reverse
	|
	|-RVA: 0x315E460 Offset: 0x315E561 VA: 0x315E460
	|-List<CharaCallTable.CharaFaceIconTable>.Reverse
	|
	|-RVA: 0x31614A0 Offset: 0x31615A1 VA: 0x31614A0
	|-List<CameraState.CustomBlendable>.Reverse
	|
	|-RVA: 0x3164450 Offset: 0x3164551 VA: 0x3164450
	|-List<CinemachineClearShot.Pair>.Reverse
	|
	|-RVA: 0x3167400 Offset: 0x3167501 VA: 0x3167400
	|-List<CinemachineStateDrivenCamera.HashPair>.Reverse
	|
	|-RVA: 0x316A8E0 Offset: 0x316A9E1 VA: 0x316A8E0
	|-List<TargetPositionCache.CacheCurve.Item>.Reverse
	|
	|-RVA: 0x316DE40 Offset: 0x316DF41 VA: 0x316DE40
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Reverse
	|
	|-RVA: 0x3171410 Offset: 0x3171511 VA: 0x3171410
	|-List<CropDataTable>.Reverse
	|
	|-RVA: 0x31743C0 Offset: 0x31744C1 VA: 0x31743C0
	|-List<DropItemParam>.Reverse
	|
	|-RVA: 0x3177770 Offset: 0x3177871 VA: 0x3177770
	|-List<ErosionBrush.UndoStep>.Reverse
	|
	|-RVA: 0x31DE3F0 Offset: 0x31DE4F1 VA: 0x31DE3F0
	|-List<EventCheckId>.Reverse
	|
	|-RVA: 0x31E1440 Offset: 0x31E1541 VA: 0x31E1440
	|-List<EventFlagProgressData>.Reverse
	|
	|-RVA: 0x31E4490 Offset: 0x31E4591 VA: 0x31E4490
	|-List<FesNpcScoreData>.Reverse
	|
	|-RVA: 0x31E79F0 Offset: 0x31E7AF1 VA: 0x31E79F0
	|-List<MiningPointSaveData>.Reverse
	|
	|-RVA: 0x31EAF10 Offset: 0x31EB011 VA: 0x31EAF10
	|-List<MonsterHutSaveData>.Reverse
	|
	|-RVA: 0x31EDF60 Offset: 0x31EE061 VA: 0x31EDF60
	|-List<MoviePlayer.SUBTITLEDATA>.Reverse
	|
	|-RVA: 0x31F1620 Offset: 0x31F1721 VA: 0x31F1620
	|-List<NPCActionData>.Reverse
	|
	|-RVA: 0x31F49C0 Offset: 0x31F4AC1 VA: 0x31F49C0
	|-List<NpcPlaceSchedule>.Reverse
	|
	|-RVA: 0x31F7A80 Offset: 0x31F7B81 VA: 0x31F7A80
	|-List<OrderLotterySaveParameter>.Reverse
	|
	|-RVA: 0x31FAE30 Offset: 0x31FAF31 VA: 0x31FAE30
	|-List<OrderSaveParameter>.Reverse
	|
	|-RVA: 0x31FDE80 Offset: 0x31FDF81 VA: 0x31FDE80
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Reverse
	|
	|-RVA: 0x330D0E0 Offset: 0x330D1E1 VA: 0x330D0E0
	|-List<ShopCatalogPage>.Reverse
	|
	|-RVA: 0x33106A0 Offset: 0x33107A1 VA: 0x33106A0
	|-List<ShopNpcTalk>.Reverse
	|
	|-RVA: 0x3313760 Offset: 0x3313861 VA: 0x3313760
	|-List<SubtitleDataTable.Data>.Reverse
	|
	|-RVA: 0x3316730 Offset: 0x3316831 VA: 0x3316730
	|-List<SubtitleDataTable.DataList>.Reverse
	|
	|-RVA: 0x33197F0 Offset: 0x33198F1 VA: 0x33197F0
	|-List<SubtitleHudDataTable.Data>.Reverse
	|
	|-RVA: 0x331CBA0 Offset: 0x331CCA1 VA: 0x331CBA0
	|-List<SRMonoBehaviourEx.FieldInfo>.Reverse
	|
	|-RVA: 0x331FEF0 Offset: 0x331FFF1 VA: 0x331FEF0
	|-List<Schedule>.Reverse
	|
	|-RVA: 0x33237A0 Offset: 0x33238A1 VA: 0x33237A0
	|-List<CurveSample>.Reverse
	|
	|-RVA: 0x3326790 Offset: 0x3326891 VA: 0x3326790
	|-List<bool>.Reverse
	|
	|-RVA: 0x3329760 Offset: 0x3329861 VA: 0x3329760
	|-List<byte>.Reverse
	|
	|-RVA: 0x332C710 Offset: 0x332C811 VA: 0x332C710
	|-List<char>.Reverse
	|
	|-RVA: 0x335A800 Offset: 0x335A901 VA: 0x335A800
	|-List<KeyValuePair<DateTime, object>>.Reverse
	|
	|-RVA: 0x335D850 Offset: 0x335D951 VA: 0x335D850
	|-List<KeyValuePair<int, object>>.Reverse
	|
	|-RVA: 0x3360890 Offset: 0x3360991 VA: 0x3360890
	|-List<KeyValuePair<object, object>>.Reverse
	|
	|-RVA: 0x3363840 Offset: 0x3363941 VA: 0x3363840
	|-List<DateTime>.Reverse
	|
	|-RVA: 0x33667F0 Offset: 0x33668F1 VA: 0x33667F0
	|-List<double>.Reverse
	|
	|-RVA: 0x33697A0 Offset: 0x33698A1 VA: 0x33697A0
	|-List<short>.Reverse
	|
	|-RVA: 0x336C750 Offset: 0x336C851 VA: 0x336C750
	|-List<int>.Reverse
	|
	|-RVA: 0x336F700 Offset: 0x336F801 VA: 0x336F700
	|-List<Int32Enum>.Reverse
	|
	|-RVA: 0x33726B0 Offset: 0x33727B1 VA: 0x33726B0
	|-List<long>.Reverse
	|
	|-RVA: 0x33756F0 Offset: 0x33757F1 VA: 0x33756F0
	|-List<InterpretedFrameInfo>.Reverse
	|
	|-RVA: 0x33786F0 Offset: 0x33787F1 VA: 0x33786F0
	|-List<Nullable<Int32Enum>>.Reverse
	|
	|-RVA: 0x3407940 Offset: 0x3407A41 VA: 0x3407940
	|-List<Nullable<Bounds>>.Reverse
	|
	|-RVA: 0x340AF00 Offset: 0x340B001 VA: 0x340AF00
	|-List<Nullable<BoundsInt>>.Reverse
	|
	|-RVA: 0x340DF00 Offset: 0x340E001 VA: 0x340DF00
	|-List<Nullable<Color32>>.Reverse
	|
	|-RVA: 0x3411360 Offset: 0x3411461 VA: 0x3411360
	|-List<Nullable<Color>>.Reverse
	|
	|-RVA: 0x3414480 Offset: 0x3414581 VA: 0x3414480
	|-List<Nullable<GradientAlphaKey>>.Reverse
	|
	|-RVA: 0x34178D0 Offset: 0x34179D1 VA: 0x34178D0
	|-List<Nullable<GradientColorKey>>.Reverse
	|
	|-RVA: 0x341AD30 Offset: 0x341AE31 VA: 0x341AD30
	|-List<Nullable<Keyframe>>.Reverse
	|
	|-RVA: 0x341DD30 Offset: 0x341DE31 VA: 0x341DD30
	|-List<Nullable<LayerMask>>.Reverse
	|
	|-RVA: 0x3421770 Offset: 0x3421871 VA: 0x3421770
	|-List<Nullable<Matrix4x4>>.Reverse
	|
	|-RVA: 0x3424BD0 Offset: 0x3424CD1 VA: 0x3424BD0
	|-List<Nullable<Quaternion>>.Reverse
	|
	|-RVA: 0x3264760 Offset: 0x3264861 VA: 0x3264760
	|-List<Nullable<RangeInt>>.Reverse
	|
	|-RVA: 0x3267BC0 Offset: 0x3267CC1 VA: 0x3267BC0
	|-List<Nullable<Rect>>.Reverse
	|
	|-RVA: 0x326B020 Offset: 0x326B121 VA: 0x326B020
	|-List<Nullable<RectInt>>.Reverse
	|
	|-RVA: 0x326E140 Offset: 0x326E241 VA: 0x326E140
	|-List<Nullable<Vector2>>.Reverse
	|
	|-RVA: 0x3271260 Offset: 0x3271361 VA: 0x3271260
	|-List<Nullable<Vector2Int>>.Reverse
	|
	|-RVA: 0x32742D0 Offset: 0x32743D1 VA: 0x32742D0
	|-List<Nullable<Vector3>>.Reverse
	|
	|-RVA: 0x3277340 Offset: 0x3277441 VA: 0x3277340
	|-List<Nullable<Vector3Int>>.Reverse
	|
	|-RVA: 0x327A7A0 Offset: 0x327A8A1 VA: 0x327A7A0
	|-List<Nullable<Vector4>>.Reverse
	|
	|-RVA: 0x327D6D0 Offset: 0x327D7D1 VA: 0x327D6D0
	|-List<object>.Reverse
	|-List<RegexNode>.Reverse
	|
	|-RVA: 0x32806A0 Offset: 0x32807A1 VA: 0x32806A0
	|-List<sbyte>.Reverse
	|
	|-RVA: 0x3283650 Offset: 0x3283751 VA: 0x3283650
	|-List<float>.Reverse
	|
	|-RVA: 0x32AA8B0 Offset: 0x32AA9B1 VA: 0x32AA8B0
	|-List<ushort>.Reverse
	|
	|-RVA: 0x32AD860 Offset: 0x32AD961 VA: 0x32AD860
	|-List<uint>.Reverse
	|
	|-RVA: 0x32B0810 Offset: 0x32B0911 VA: 0x32B0810
	|-List<ulong>.Reverse
	|
	|-RVA: 0x32B37C0 Offset: 0x32B38C1 VA: 0x32B37C0
	|-List<ValueTuple<bool, Int32Enum>>.Reverse
	|
	|-RVA: 0x32B6770 Offset: 0x32B6871 VA: 0x32B6770
	|-List<ValueTuple<Int32Enum, int>>.Reverse
	|
	|-RVA: 0x32B97C0 Offset: 0x32B98C1 VA: 0x32B97C0
	|-List<ValueTuple<Int32Enum, object>>.Reverse
	|
	|-RVA: 0x32BC800 Offset: 0x32BC901 VA: 0x32BC800
	|-List<ValueTuple<object, Int32Enum>>.Reverse
	|
	|-RVA: 0x32BF840 Offset: 0x32BF941 VA: 0x32BF840
	|-List<ValueTuple<object, object>>.Reverse
	|
	|-RVA: 0x32C2880 Offset: 0x32C2981 VA: 0x32C2880
	|-List<ValueTuple<object, float>>.Reverse
	|
	|-RVA: 0x32C5940 Offset: 0x32C5A41 VA: 0x32C5940
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Reverse
	|
	|-RVA: 0x32C9030 Offset: 0x32C9131 VA: 0x32C9030
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Reverse
	|
	|-RVA: 0x3112C90 Offset: 0x3112D91 VA: 0x3112C90
	|-List<TexturePacker_JsonArray.Frame>.Reverse
	|
	|-RVA: 0x3115D50 Offset: 0x3115E51 VA: 0x3115D50
	|-List<TutorialUnlockFlagData>.Reverse
	|
	|-RVA: 0x3118DA0 Offset: 0x3118EA1 VA: 0x3118DA0
	|-List<UIMainManagerAttachObject.AttachSet>.Reverse
	|
	|-RVA: 0x311C300 Offset: 0x311C401 VA: 0x311C300
	|-List<CapEdge>.Reverse
	|
	|-RVA: 0x311F2B0 Offset: 0x311F3B1 VA: 0x311F2B0
	|-List<MeshDataConnectivity.Face>.Reverse
	|
	|-RVA: 0x3122600 Offset: 0x3122701 VA: 0x3122600
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Reverse
	|
	|-RVA: 0x3125BC0 Offset: 0x3125CC1 VA: 0x3125BC0
	|-List<MeshFaceConnectivity.EdgeData>.Reverse
	|
	|-RVA: 0x3128BD0 Offset: 0x3128CD1 VA: 0x3128BD0
	|-List<NavMeshBuildMarkup>.Reverse
	|
	|-RVA: 0x312C7A0 Offset: 0x312C8A1 VA: 0x312C7A0
	|-List<NavMeshBuildSource>.Reverse
	|
	|-RVA: 0x312F7E0 Offset: 0x312F8E1 VA: 0x312F7E0
	|-List<ConstraintSource>.Reverse
	|
	|-RVA: 0x3132790 Offset: 0x3132891 VA: 0x3132790
	|-List<AnimatorClipInfo>.Reverse
	|
	|-RVA: 0x321E3C0 Offset: 0x321E4C1 VA: 0x321E3C0
	|-List<BeforeRenderHelper.OrderBlock>.Reverse
	|
	|-RVA: 0x3221720 Offset: 0x3221821 VA: 0x3221720
	|-List<BoneWeight>.Reverse
	|
	|-RVA: 0x3224A70 Offset: 0x3224B71 VA: 0x3224A70
	|-List<Bounds>.Reverse
	|
	|-RVA: 0x3227DC0 Offset: 0x3227EC1 VA: 0x3227DC0
	|-List<BoundsInt>.Reverse
	|
	|-RVA: 0x322AD90 Offset: 0x322AE91 VA: 0x322AD90
	|-List<Color32>.Reverse
	|
	|-RVA: 0x322DE10 Offset: 0x322DF11 VA: 0x322DE10
	|-List<Color>.Reverse
	|
	|-RVA: 0x3231A00 Offset: 0x3231B01 VA: 0x3231A00
	|-List<CombineInstance>.Reverse
	|
	|-RVA: 0x32352E0 Offset: 0x32353E1 VA: 0x32352E0
	|-List<RaycastResult>.Reverse
	|
	|-RVA: 0x3238300 Offset: 0x3238401 VA: 0x3238300
	|-List<GradientAlphaKey>.Reverse
	|
	|-RVA: 0x323B660 Offset: 0x323B761 VA: 0x323B660
	|-List<GradientColorKey>.Reverse
	|
	|-RVA: 0x323EB40 Offset: 0x323EC41 VA: 0x323EB40
	|-List<Keyframe>.Reverse
	|
	|-RVA: 0x3241B10 Offset: 0x3241C11 VA: 0x3241B10
	|-List<LayerMask>.Reverse
	|
	|-RVA: 0x32451C0 Offset: 0x32452C1 VA: 0x32451C0
	|-List<Matrix4x4>.Reverse
	|
	|-RVA: 0x3248680 Offset: 0x3248781 VA: 0x3248680
	|-List<ParticleSystem.Particle>.Reverse
	|
	|-RVA: 0x324B690 Offset: 0x324B791 VA: 0x324B690
	|-List<Playable>.Reverse
	|
	|-RVA: 0x324EA40 Offset: 0x324EB41 VA: 0x324EA40
	|-List<PlayableBinding>.Reverse
	|
	|-RVA: 0x3251A50 Offset: 0x3251B51 VA: 0x3251A50
	|-List<PlayableGraph>.Reverse
	|
	|-RVA: 0x3254A00 Offset: 0x3254B01 VA: 0x3254A00
	|-List<Edge>.Reverse
	|
	|-RVA: 0x3257A80 Offset: 0x3257B81 VA: 0x3257A80
	|-List<Quaternion>.Reverse
	|
	|-RVA: 0x325AA30 Offset: 0x325AB31 VA: 0x325AA30
	|-List<RangeInt>.Reverse
	|
	|-RVA: 0x325DF90 Offset: 0x325E091 VA: 0x325DF90
	|-List<RaycastHit2D>.Reverse
	|
	|-RVA: 0x3261640 Offset: 0x3261741 VA: 0x3261640
	|-List<RaycastHit>.Reverse
	|
	|-RVA: 0x33C2EC0 Offset: 0x33C2FC1 VA: 0x33C2EC0
	|-List<Rect>.Reverse
	|
	|-RVA: 0x33C5ED0 Offset: 0x33C5FD1 VA: 0x33C5ED0
	|-List<RectInt>.Reverse
	|
	|-RVA: 0x33C8F10 Offset: 0x33C9011 VA: 0x33C8F10
	|-List<ReflectionProbeBlendInfo>.Reverse
	|
	|-RVA: 0x33CCC70 Offset: 0x33CCD71 VA: 0x33CCC70
	|-List<SphericalHarmonicsL2>.Reverse
	|
	|-RVA: 0x33CFC80 Offset: 0x33CFD81 VA: 0x33CFC80
	|-List<VertexAttributeDescriptor>.Reverse
	|
	|-RVA: 0x33D3020 Offset: 0x33D3121 VA: 0x33D3020
	|-List<AsyncOperationHandle>.Reverse
	|
	|-RVA: 0x33D63C0 Offset: 0x33D64C1 VA: 0x33D63C0
	|-List<AsyncOperationHandle<SceneInstance>>.Reverse
	|
	|-RVA: 0x33D9980 Offset: 0x33D9A81 VA: 0x33D9980
	|-List<DiagnosticEvent>.Reverse
	|
	|-RVA: 0x33DCD30 Offset: 0x33DCE31 VA: 0x33DCD30
	|-List<DelayedActionManager.DelegateInfo>.Reverse
	|
	|-RVA: 0x33E02F0 Offset: 0x33E03F1 VA: 0x33E02F0
	|-List<ObjectInitializationData>.Reverse
	|
	|-RVA: 0x31BB250 Offset: 0x31BB351 VA: 0x31BB250
	|-List<GlyphRect>.Reverse
	|
	|-RVA: 0x31BE730 Offset: 0x31BE831 VA: 0x31BE730
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Reverse
	|
	|-RVA: 0x31C1A80 Offset: 0x31C1B81 VA: 0x31C1A80
	|-List<IntervalTreeNode>.Reverse
	|
	|-RVA: 0x31C4E20 Offset: 0x31C4F21 VA: 0x31C4E20
	|-List<IntervalTree.Entry<object>>.Reverse
	|
	|-RVA: 0x31C81C0 Offset: 0x31C82C1 VA: 0x31C81C0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Reverse
	|
	|-RVA: 0x31CB240 Offset: 0x31CB341 VA: 0x31CB240
	|-List<UICharInfo>.Reverse
	|
	|-RVA: 0x31CE280 Offset: 0x31CE381 VA: 0x31CE280
	|-List<FocusController.FocusedElement>.Reverse
	|
	|-RVA: 0x31D1290 Offset: 0x31D1391 VA: 0x31D1290
	|-List<UILineInfo>.Reverse
	|
	|-RVA: 0x31D4C90 Offset: 0x31D4D91 VA: 0x31D4C90
	|-List<UIVertex>.Reverse
	|
	|-RVA: 0x31D8030 Offset: 0x31D8131 VA: 0x31D8030
	|-List<UnitySynchronizationContext.WorkRequest>.Reverse
	|
	|-RVA: 0x31DB050 Offset: 0x31DB151 VA: 0x31DB050
	|-List<Vector2>.Reverse
	|
	|-RVA: 0x2CE3C10 Offset: 0x2CE3D11 VA: 0x2CE3C10
	|-List<Vector2Int>.Reverse
	|
	|-RVA: 0x2CE6C90 Offset: 0x2CE6D91 VA: 0x2CE6C90
	|-List<Vector3>.Reverse
	|
	|-RVA: 0x2CE9D50 Offset: 0x2CE9E51 VA: 0x2CE9D50
	|-List<Vector3Int>.Reverse
	|
	|-RVA: 0x2CECDD0 Offset: 0x2CECED1 VA: 0x2CECDD0
	|-List<Vector4>.Reverse
	|
	|-RVA: 0x2CF0AE0 Offset: 0x2CF0BE1 VA: 0x2CF0AE0
	|-List<WarpPoints.WarpPoint>.Reverse
	|
	|-RVA: 0x2CF3A90 Offset: 0x2CF3B91 VA: 0x2CF3A90
	|-List<YieldItemParam>.Reverse
	|
	|-RVA: 0x2CF6E30 Offset: 0x2CF6F31 VA: 0x2CF6E30
	|-List<stCommand_t>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248F100 Offset: 0x248F201 VA: 0x248F100
	|-List<AS_ToolController.ChargeInfo>.Sort
	|
	|-RVA: 0x2492E20 Offset: 0x2492F21 VA: 0x2492E20
	|-List<BuildItemData>.Sort
	|
	|-RVA: 0x3158450 Offset: 0x3158551 VA: 0x3158450
	|-List<ButtonLinker.LinkObject>.Sort
	|
	|-RVA: 0x315B460 Offset: 0x315B561 VA: 0x315B460
	|-List<CharaCallTable.BustupTable>.Sort
	|
	|-RVA: 0x315E520 Offset: 0x315E621 VA: 0x315E520
	|-List<CharaCallTable.CharaFaceIconTable>.Sort
	|
	|-RVA: 0x3161560 Offset: 0x3161661 VA: 0x3161560
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x3164510 Offset: 0x3164611 VA: 0x3164510
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x31674C0 Offset: 0x31675C1 VA: 0x31674C0
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x316A9A0 Offset: 0x316AAA1 VA: 0x316A9A0
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x316DF00 Offset: 0x316E001 VA: 0x316DF00
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	|
	|-RVA: 0x31714D0 Offset: 0x31715D1 VA: 0x31714D0
	|-List<CropDataTable>.Sort
	|
	|-RVA: 0x3174480 Offset: 0x3174581 VA: 0x3174480
	|-List<DropItemParam>.Sort
	|
	|-RVA: 0x3177830 Offset: 0x3177931 VA: 0x3177830
	|-List<ErosionBrush.UndoStep>.Sort
	|
	|-RVA: 0x31DE4B0 Offset: 0x31DE5B1 VA: 0x31DE4B0
	|-List<EventCheckId>.Sort
	|
	|-RVA: 0x31E1500 Offset: 0x31E1601 VA: 0x31E1500
	|-List<EventFlagProgressData>.Sort
	|
	|-RVA: 0x31E4550 Offset: 0x31E4651 VA: 0x31E4550
	|-List<FesNpcScoreData>.Sort
	|
	|-RVA: 0x31E7AB0 Offset: 0x31E7BB1 VA: 0x31E7AB0
	|-List<MiningPointSaveData>.Sort
	|
	|-RVA: 0x31EAFD0 Offset: 0x31EB0D1 VA: 0x31EAFD0
	|-List<MonsterHutSaveData>.Sort
	|
	|-RVA: 0x31EE020 Offset: 0x31EE121 VA: 0x31EE020
	|-List<MoviePlayer.SUBTITLEDATA>.Sort
	|
	|-RVA: 0x31F16E0 Offset: 0x31F17E1 VA: 0x31F16E0
	|-List<NPCActionData>.Sort
	|
	|-RVA: 0x31F4A80 Offset: 0x31F4B81 VA: 0x31F4A80
	|-List<NpcPlaceSchedule>.Sort
	|
	|-RVA: 0x31F7B40 Offset: 0x31F7C41 VA: 0x31F7B40
	|-List<OrderLotterySaveParameter>.Sort
	|
	|-RVA: 0x31FAEF0 Offset: 0x31FAFF1 VA: 0x31FAEF0
	|-List<OrderSaveParameter>.Sort
	|
	|-RVA: 0x31FDF40 Offset: 0x31FE041 VA: 0x31FDF40
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x330D1A0 Offset: 0x330D2A1 VA: 0x330D1A0
	|-List<ShopCatalogPage>.Sort
	|
	|-RVA: 0x3310760 Offset: 0x3310861 VA: 0x3310760
	|-List<ShopNpcTalk>.Sort
	|
	|-RVA: 0x3313820 Offset: 0x3313921 VA: 0x3313820
	|-List<SubtitleDataTable.Data>.Sort
	|
	|-RVA: 0x33167F0 Offset: 0x33168F1 VA: 0x33167F0
	|-List<SubtitleDataTable.DataList>.Sort
	|
	|-RVA: 0x33198B0 Offset: 0x33199B1 VA: 0x33198B0
	|-List<SubtitleHudDataTable.Data>.Sort
	|
	|-RVA: 0x331CC60 Offset: 0x331CD61 VA: 0x331CC60
	|-List<SRMonoBehaviourEx.FieldInfo>.Sort
	|
	|-RVA: 0x331FFB0 Offset: 0x33200B1 VA: 0x331FFB0
	|-List<Schedule>.Sort
	|
	|-RVA: 0x3323860 Offset: 0x3323961 VA: 0x3323860
	|-List<CurveSample>.Sort
	|
	|-RVA: 0x3326850 Offset: 0x3326951 VA: 0x3326850
	|-List<bool>.Sort
	|
	|-RVA: 0x3329820 Offset: 0x3329921 VA: 0x3329820
	|-List<byte>.Sort
	|
	|-RVA: 0x332C7D0 Offset: 0x332C8D1 VA: 0x332C7D0
	|-List<char>.Sort
	|
	|-RVA: 0x335A8C0 Offset: 0x335A9C1 VA: 0x335A8C0
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x335D910 Offset: 0x335DA11 VA: 0x335D910
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3360950 Offset: 0x3360A51 VA: 0x3360950
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3363900 Offset: 0x3363A01 VA: 0x3363900
	|-List<DateTime>.Sort
	|
	|-RVA: 0x33668B0 Offset: 0x33669B1 VA: 0x33668B0
	|-List<double>.Sort
	|
	|-RVA: 0x3369860 Offset: 0x3369961 VA: 0x3369860
	|-List<short>.Sort
	|
	|-RVA: 0x336C810 Offset: 0x336C911 VA: 0x336C810
	|-List<int>.Sort
	|
	|-RVA: 0x336F7C0 Offset: 0x336F8C1 VA: 0x336F7C0
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3372770 Offset: 0x3372871 VA: 0x3372770
	|-List<long>.Sort
	|
	|-RVA: 0x33757B0 Offset: 0x33758B1 VA: 0x33757B0
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x33787B0 Offset: 0x33788B1 VA: 0x33787B0
	|-List<Nullable<Int32Enum>>.Sort
	|
	|-RVA: 0x3407A00 Offset: 0x3407B01 VA: 0x3407A00
	|-List<Nullable<Bounds>>.Sort
	|
	|-RVA: 0x340AFC0 Offset: 0x340B0C1 VA: 0x340AFC0
	|-List<Nullable<BoundsInt>>.Sort
	|
	|-RVA: 0x340DFC0 Offset: 0x340E0C1 VA: 0x340DFC0
	|-List<Nullable<Color32>>.Sort
	|
	|-RVA: 0x3411420 Offset: 0x3411521 VA: 0x3411420
	|-List<Nullable<Color>>.Sort
	|
	|-RVA: 0x3414540 Offset: 0x3414641 VA: 0x3414540
	|-List<Nullable<GradientAlphaKey>>.Sort
	|
	|-RVA: 0x3417990 Offset: 0x3417A91 VA: 0x3417990
	|-List<Nullable<GradientColorKey>>.Sort
	|
	|-RVA: 0x341ADF0 Offset: 0x341AEF1 VA: 0x341ADF0
	|-List<Nullable<Keyframe>>.Sort
	|
	|-RVA: 0x341DDF0 Offset: 0x341DEF1 VA: 0x341DDF0
	|-List<Nullable<LayerMask>>.Sort
	|
	|-RVA: 0x3421830 Offset: 0x3421931 VA: 0x3421830
	|-List<Nullable<Matrix4x4>>.Sort
	|
	|-RVA: 0x3424C90 Offset: 0x3424D91 VA: 0x3424C90
	|-List<Nullable<Quaternion>>.Sort
	|
	|-RVA: 0x3264820 Offset: 0x3264921 VA: 0x3264820
	|-List<Nullable<RangeInt>>.Sort
	|
	|-RVA: 0x3267C80 Offset: 0x3267D81 VA: 0x3267C80
	|-List<Nullable<Rect>>.Sort
	|
	|-RVA: 0x326B0E0 Offset: 0x326B1E1 VA: 0x326B0E0
	|-List<Nullable<RectInt>>.Sort
	|
	|-RVA: 0x326E200 Offset: 0x326E301 VA: 0x326E200
	|-List<Nullable<Vector2>>.Sort
	|
	|-RVA: 0x3271320 Offset: 0x3271421 VA: 0x3271320
	|-List<Nullable<Vector2Int>>.Sort
	|
	|-RVA: 0x3274390 Offset: 0x3274491 VA: 0x3274390
	|-List<Nullable<Vector3>>.Sort
	|
	|-RVA: 0x3277400 Offset: 0x3277501 VA: 0x3277400
	|-List<Nullable<Vector3Int>>.Sort
	|
	|-RVA: 0x327A860 Offset: 0x327A961 VA: 0x327A860
	|-List<Nullable<Vector4>>.Sort
	|
	|-RVA: 0x327D790 Offset: 0x327D891 VA: 0x327D790
	|-List<object>.Sort
	|
	|-RVA: 0x3280760 Offset: 0x3280861 VA: 0x3280760
	|-List<sbyte>.Sort
	|
	|-RVA: 0x3283710 Offset: 0x3283811 VA: 0x3283710
	|-List<float>.Sort
	|
	|-RVA: 0x32AA970 Offset: 0x32AAA71 VA: 0x32AA970
	|-List<ushort>.Sort
	|
	|-RVA: 0x32AD920 Offset: 0x32ADA21 VA: 0x32AD920
	|-List<uint>.Sort
	|
	|-RVA: 0x32B08D0 Offset: 0x32B09D1 VA: 0x32B08D0
	|-List<ulong>.Sort
	|
	|-RVA: 0x32B3880 Offset: 0x32B3981 VA: 0x32B3880
	|-List<ValueTuple<bool, Int32Enum>>.Sort
	|
	|-RVA: 0x32B6830 Offset: 0x32B6931 VA: 0x32B6830
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x32B9880 Offset: 0x32B9981 VA: 0x32B9880
	|-List<ValueTuple<Int32Enum, object>>.Sort
	|
	|-RVA: 0x32BC8C0 Offset: 0x32BC9C1 VA: 0x32BC8C0
	|-List<ValueTuple<object, Int32Enum>>.Sort
	|
	|-RVA: 0x32BF900 Offset: 0x32BFA01 VA: 0x32BF900
	|-List<ValueTuple<object, object>>.Sort
	|
	|-RVA: 0x32C2940 Offset: 0x32C2A41 VA: 0x32C2940
	|-List<ValueTuple<object, float>>.Sort
	|
	|-RVA: 0x32C5A00 Offset: 0x32C5B01 VA: 0x32C5A00
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Sort
	|
	|-RVA: 0x32C90F0 Offset: 0x32C91F1 VA: 0x32C90F0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Sort
	|
	|-RVA: 0x3112D50 Offset: 0x3112E51 VA: 0x3112D50
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3115E10 Offset: 0x3115F11 VA: 0x3115E10
	|-List<TutorialUnlockFlagData>.Sort
	|
	|-RVA: 0x3118E60 Offset: 0x3118F61 VA: 0x3118E60
	|-List<UIMainManagerAttachObject.AttachSet>.Sort
	|
	|-RVA: 0x311C3C0 Offset: 0x311C4C1 VA: 0x311C3C0
	|-List<CapEdge>.Sort
	|
	|-RVA: 0x311F370 Offset: 0x311F471 VA: 0x311F370
	|-List<MeshDataConnectivity.Face>.Sort
	|
	|-RVA: 0x31226C0 Offset: 0x31227C1 VA: 0x31226C0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Sort
	|
	|-RVA: 0x3125C80 Offset: 0x3125D81 VA: 0x3125C80
	|-List<MeshFaceConnectivity.EdgeData>.Sort
	|
	|-RVA: 0x3128C90 Offset: 0x3128D91 VA: 0x3128C90
	|-List<NavMeshBuildMarkup>.Sort
	|
	|-RVA: 0x312C860 Offset: 0x312C961 VA: 0x312C860
	|-List<NavMeshBuildSource>.Sort
	|
	|-RVA: 0x312F8A0 Offset: 0x312F9A1 VA: 0x312F8A0
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x3132850 Offset: 0x3132951 VA: 0x3132850
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x321E480 Offset: 0x321E581 VA: 0x321E480
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x32217E0 Offset: 0x32218E1 VA: 0x32217E0
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3224B30 Offset: 0x3224C31 VA: 0x3224B30
	|-List<Bounds>.Sort
	|
	|-RVA: 0x3227E80 Offset: 0x3227F81 VA: 0x3227E80
	|-List<BoundsInt>.Sort
	|
	|-RVA: 0x322AE50 Offset: 0x322AF51 VA: 0x322AE50
	|-List<Color32>.Sort
	|
	|-RVA: 0x322DED0 Offset: 0x322DFD1 VA: 0x322DED0
	|-List<Color>.Sort
	|
	|-RVA: 0x3231AC0 Offset: 0x3231BC1 VA: 0x3231AC0
	|-List<CombineInstance>.Sort
	|
	|-RVA: 0x32353A0 Offset: 0x32354A1 VA: 0x32353A0
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x32383C0 Offset: 0x32384C1 VA: 0x32383C0
	|-List<GradientAlphaKey>.Sort
	|
	|-RVA: 0x323B720 Offset: 0x323B821 VA: 0x323B720
	|-List<GradientColorKey>.Sort
	|
	|-RVA: 0x323EC00 Offset: 0x323ED01 VA: 0x323EC00
	|-List<Keyframe>.Sort
	|
	|-RVA: 0x3241BD0 Offset: 0x3241CD1 VA: 0x3241BD0
	|-List<LayerMask>.Sort
	|
	|-RVA: 0x3245280 Offset: 0x3245381 VA: 0x3245280
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x3248740 Offset: 0x3248841 VA: 0x3248740
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x324B750 Offset: 0x324B851 VA: 0x324B750
	|-List<Playable>.Sort
	|
	|-RVA: 0x324EB00 Offset: 0x324EC01 VA: 0x324EB00
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3251B10 Offset: 0x3251C11 VA: 0x3251B10
	|-List<PlayableGraph>.Sort
	|
	|-RVA: 0x3254AC0 Offset: 0x3254BC1 VA: 0x3254AC0
	|-List<Edge>.Sort
	|
	|-RVA: 0x3257B40 Offset: 0x3257C41 VA: 0x3257B40
	|-List<Quaternion>.Sort
	|
	|-RVA: 0x325AAF0 Offset: 0x325ABF1 VA: 0x325AAF0
	|-List<RangeInt>.Sort
	|
	|-RVA: 0x325E050 Offset: 0x325E151 VA: 0x325E050
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x3261700 Offset: 0x3261801 VA: 0x3261700
	|-List<RaycastHit>.Sort
	|
	|-RVA: 0x33C2F80 Offset: 0x33C3081 VA: 0x33C2F80
	|-List<Rect>.Sort
	|
	|-RVA: 0x33C5F90 Offset: 0x33C6091 VA: 0x33C5F90
	|-List<RectInt>.Sort
	|
	|-RVA: 0x33C8FD0 Offset: 0x33C90D1 VA: 0x33C8FD0
	|-List<ReflectionProbeBlendInfo>.Sort
	|
	|-RVA: 0x33CCD30 Offset: 0x33CCE31 VA: 0x33CCD30
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x33CFD40 Offset: 0x33CFE41 VA: 0x33CFD40
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x33D30E0 Offset: 0x33D31E1 VA: 0x33D30E0
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x33D6480 Offset: 0x33D6581 VA: 0x33D6480
	|-List<AsyncOperationHandle<SceneInstance>>.Sort
	|
	|-RVA: 0x33D9A40 Offset: 0x33D9B41 VA: 0x33D9A40
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x33DCDF0 Offset: 0x33DCEF1 VA: 0x33DCDF0
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x33E03B0 Offset: 0x33E04B1 VA: 0x33E03B0
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x31BB310 Offset: 0x31BB411 VA: 0x31BB310
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x31BE7F0 Offset: 0x31BE8F1 VA: 0x31BE7F0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x31C1B40 Offset: 0x31C1C41 VA: 0x31C1B40
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x31C4EE0 Offset: 0x31C4FE1 VA: 0x31C4EE0
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x31C8280 Offset: 0x31C8381 VA: 0x31C8280
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x31CB300 Offset: 0x31CB401 VA: 0x31CB300
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x31CE340 Offset: 0x31CE441 VA: 0x31CE340
	|-List<FocusController.FocusedElement>.Sort
	|
	|-RVA: 0x31D1350 Offset: 0x31D1451 VA: 0x31D1350
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x31D4D50 Offset: 0x31D4E51 VA: 0x31D4D50
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x31D80F0 Offset: 0x31D81F1 VA: 0x31D80F0
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x31DB110 Offset: 0x31DB211 VA: 0x31DB110
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2CE3CD0 Offset: 0x2CE3DD1 VA: 0x2CE3CD0
	|-List<Vector2Int>.Sort
	|
	|-RVA: 0x2CE6D50 Offset: 0x2CE6E51 VA: 0x2CE6D50
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2CE9E10 Offset: 0x2CE9F11 VA: 0x2CE9E10
	|-List<Vector3Int>.Sort
	|
	|-RVA: 0x2CECE90 Offset: 0x2CECF91 VA: 0x2CECE90
	|-List<Vector4>.Sort
	|
	|-RVA: 0x2CF0BA0 Offset: 0x2CF0CA1 VA: 0x2CF0BA0
	|-List<WarpPoints.WarpPoint>.Sort
	|
	|-RVA: 0x2CF3B50 Offset: 0x2CF3C51 VA: 0x2CF3B50
	|-List<YieldItemParam>.Sort
	|
	|-RVA: 0x2CF6EF0 Offset: 0x2CF6FF1 VA: 0x2CF6EF0
	|-List<stCommand_t>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248F160 Offset: 0x248F261 VA: 0x248F160
	|-List<AS_ToolController.ChargeInfo>.Sort
	|
	|-RVA: 0x2492E80 Offset: 0x2492F81 VA: 0x2492E80
	|-List<BuildItemData>.Sort
	|
	|-RVA: 0x31584B0 Offset: 0x31585B1 VA: 0x31584B0
	|-List<ButtonLinker.LinkObject>.Sort
	|
	|-RVA: 0x315B4C0 Offset: 0x315B5C1 VA: 0x315B4C0
	|-List<CharaCallTable.BustupTable>.Sort
	|
	|-RVA: 0x315E580 Offset: 0x315E681 VA: 0x315E580
	|-List<CharaCallTable.CharaFaceIconTable>.Sort
	|
	|-RVA: 0x31615C0 Offset: 0x31616C1 VA: 0x31615C0
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x3164570 Offset: 0x3164671 VA: 0x3164570
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3167520 Offset: 0x3167621 VA: 0x3167520
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x316AA00 Offset: 0x316AB01 VA: 0x316AA00
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x316DF60 Offset: 0x316E061 VA: 0x316DF60
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	|
	|-RVA: 0x3171530 Offset: 0x3171631 VA: 0x3171530
	|-List<CropDataTable>.Sort
	|
	|-RVA: 0x31744E0 Offset: 0x31745E1 VA: 0x31744E0
	|-List<DropItemParam>.Sort
	|
	|-RVA: 0x3177890 Offset: 0x3177991 VA: 0x3177890
	|-List<ErosionBrush.UndoStep>.Sort
	|
	|-RVA: 0x31DE510 Offset: 0x31DE611 VA: 0x31DE510
	|-List<EventCheckId>.Sort
	|
	|-RVA: 0x31E1560 Offset: 0x31E1661 VA: 0x31E1560
	|-List<EventFlagProgressData>.Sort
	|
	|-RVA: 0x31E45B0 Offset: 0x31E46B1 VA: 0x31E45B0
	|-List<FesNpcScoreData>.Sort
	|
	|-RVA: 0x31E7B10 Offset: 0x31E7C11 VA: 0x31E7B10
	|-List<MiningPointSaveData>.Sort
	|
	|-RVA: 0x327D7F0 Offset: 0x327D8F1 VA: 0x327D7F0
	|-List<Contraction>.Sort
	|-List<TriangulationPoint>.Sort
	|-List<object>.Sort
	|-List<MeshData>.Sort
	|
	|-RVA: 0x31EB030 Offset: 0x31EB131 VA: 0x31EB030
	|-List<MonsterHutSaveData>.Sort
	|
	|-RVA: 0x31EE080 Offset: 0x31EE181 VA: 0x31EE080
	|-List<MoviePlayer.SUBTITLEDATA>.Sort
	|
	|-RVA: 0x31F1740 Offset: 0x31F1841 VA: 0x31F1740
	|-List<NPCActionData>.Sort
	|
	|-RVA: 0x31F4AE0 Offset: 0x31F4BE1 VA: 0x31F4AE0
	|-List<NpcPlaceSchedule>.Sort
	|
	|-RVA: 0x31F7BA0 Offset: 0x31F7CA1 VA: 0x31F7BA0
	|-List<OrderLotterySaveParameter>.Sort
	|
	|-RVA: 0x31FAF50 Offset: 0x31FB051 VA: 0x31FAF50
	|-List<OrderSaveParameter>.Sort
	|
	|-RVA: 0x31FDFA0 Offset: 0x31FE0A1 VA: 0x31FDFA0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x330D200 Offset: 0x330D301 VA: 0x330D200
	|-List<ShopCatalogPage>.Sort
	|
	|-RVA: 0x33107C0 Offset: 0x33108C1 VA: 0x33107C0
	|-List<ShopNpcTalk>.Sort
	|
	|-RVA: 0x3313880 Offset: 0x3313981 VA: 0x3313880
	|-List<SubtitleDataTable.Data>.Sort
	|
	|-RVA: 0x3316850 Offset: 0x3316951 VA: 0x3316850
	|-List<SubtitleDataTable.DataList>.Sort
	|
	|-RVA: 0x3319910 Offset: 0x3319A11 VA: 0x3319910
	|-List<SubtitleHudDataTable.Data>.Sort
	|
	|-RVA: 0x331CCC0 Offset: 0x331CDC1 VA: 0x331CCC0
	|-List<SRMonoBehaviourEx.FieldInfo>.Sort
	|
	|-RVA: 0x3320010 Offset: 0x3320111 VA: 0x3320010
	|-List<Schedule>.Sort
	|
	|-RVA: 0x33238C0 Offset: 0x33239C1 VA: 0x33238C0
	|-List<CurveSample>.Sort
	|
	|-RVA: 0x33268B0 Offset: 0x33269B1 VA: 0x33268B0
	|-List<bool>.Sort
	|
	|-RVA: 0x3329880 Offset: 0x3329981 VA: 0x3329880
	|-List<byte>.Sort
	|
	|-RVA: 0x332C830 Offset: 0x332C931 VA: 0x332C830
	|-List<char>.Sort
	|
	|-RVA: 0x335A920 Offset: 0x335AA21 VA: 0x335A920
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x335D970 Offset: 0x335DA71 VA: 0x335D970
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x33609B0 Offset: 0x3360AB1 VA: 0x33609B0
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3363960 Offset: 0x3363A61 VA: 0x3363960
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3366910 Offset: 0x3366A11 VA: 0x3366910
	|-List<double>.Sort
	|
	|-RVA: 0x33698C0 Offset: 0x33699C1 VA: 0x33698C0
	|-List<short>.Sort
	|
	|-RVA: 0x336C870 Offset: 0x336C971 VA: 0x336C870
	|-List<int>.Sort
	|
	|-RVA: 0x336F820 Offset: 0x336F921 VA: 0x336F820
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x33727D0 Offset: 0x33728D1 VA: 0x33727D0
	|-List<long>.Sort
	|
	|-RVA: 0x3375810 Offset: 0x3375911 VA: 0x3375810
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3378810 Offset: 0x3378911 VA: 0x3378810
	|-List<Nullable<Int32Enum>>.Sort
	|
	|-RVA: 0x3407A60 Offset: 0x3407B61 VA: 0x3407A60
	|-List<Nullable<Bounds>>.Sort
	|
	|-RVA: 0x340B020 Offset: 0x340B121 VA: 0x340B020
	|-List<Nullable<BoundsInt>>.Sort
	|
	|-RVA: 0x340E020 Offset: 0x340E121 VA: 0x340E020
	|-List<Nullable<Color32>>.Sort
	|
	|-RVA: 0x3411480 Offset: 0x3411581 VA: 0x3411480
	|-List<Nullable<Color>>.Sort
	|
	|-RVA: 0x34145A0 Offset: 0x34146A1 VA: 0x34145A0
	|-List<Nullable<GradientAlphaKey>>.Sort
	|
	|-RVA: 0x34179F0 Offset: 0x3417AF1 VA: 0x34179F0
	|-List<Nullable<GradientColorKey>>.Sort
	|
	|-RVA: 0x341AE50 Offset: 0x341AF51 VA: 0x341AE50
	|-List<Nullable<Keyframe>>.Sort
	|
	|-RVA: 0x341DE50 Offset: 0x341DF51 VA: 0x341DE50
	|-List<Nullable<LayerMask>>.Sort
	|
	|-RVA: 0x3421890 Offset: 0x3421991 VA: 0x3421890
	|-List<Nullable<Matrix4x4>>.Sort
	|
	|-RVA: 0x3424CF0 Offset: 0x3424DF1 VA: 0x3424CF0
	|-List<Nullable<Quaternion>>.Sort
	|
	|-RVA: 0x3264880 Offset: 0x3264981 VA: 0x3264880
	|-List<Nullable<RangeInt>>.Sort
	|
	|-RVA: 0x3267CE0 Offset: 0x3267DE1 VA: 0x3267CE0
	|-List<Nullable<Rect>>.Sort
	|
	|-RVA: 0x326B140 Offset: 0x326B241 VA: 0x326B140
	|-List<Nullable<RectInt>>.Sort
	|
	|-RVA: 0x326E260 Offset: 0x326E361 VA: 0x326E260
	|-List<Nullable<Vector2>>.Sort
	|
	|-RVA: 0x3271380 Offset: 0x3271481 VA: 0x3271380
	|-List<Nullable<Vector2Int>>.Sort
	|
	|-RVA: 0x32743F0 Offset: 0x32744F1 VA: 0x32743F0
	|-List<Nullable<Vector3>>.Sort
	|
	|-RVA: 0x3277460 Offset: 0x3277561 VA: 0x3277460
	|-List<Nullable<Vector3Int>>.Sort
	|
	|-RVA: 0x327A8C0 Offset: 0x327A9C1 VA: 0x327A8C0
	|-List<Nullable<Vector4>>.Sort
	|
	|-RVA: 0x32807C0 Offset: 0x32808C1 VA: 0x32807C0
	|-List<sbyte>.Sort
	|
	|-RVA: 0x3283770 Offset: 0x3283871 VA: 0x3283770
	|-List<float>.Sort
	|
	|-RVA: 0x32AA9D0 Offset: 0x32AAAD1 VA: 0x32AA9D0
	|-List<ushort>.Sort
	|
	|-RVA: 0x32AD980 Offset: 0x32ADA81 VA: 0x32AD980
	|-List<uint>.Sort
	|
	|-RVA: 0x32B0930 Offset: 0x32B0A31 VA: 0x32B0930
	|-List<ulong>.Sort
	|
	|-RVA: 0x32B38E0 Offset: 0x32B39E1 VA: 0x32B38E0
	|-List<ValueTuple<bool, Int32Enum>>.Sort
	|
	|-RVA: 0x32B6890 Offset: 0x32B6991 VA: 0x32B6890
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x32B98E0 Offset: 0x32B99E1 VA: 0x32B98E0
	|-List<ValueTuple<Int32Enum, object>>.Sort
	|
	|-RVA: 0x32BC920 Offset: 0x32BCA21 VA: 0x32BC920
	|-List<ValueTuple<object, Int32Enum>>.Sort
	|
	|-RVA: 0x32BF960 Offset: 0x32BFA61 VA: 0x32BF960
	|-List<ValueTuple<object, object>>.Sort
	|
	|-RVA: 0x32C29A0 Offset: 0x32C2AA1 VA: 0x32C29A0
	|-List<ValueTuple<object, float>>.Sort
	|
	|-RVA: 0x32C5A60 Offset: 0x32C5B61 VA: 0x32C5A60
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Sort
	|
	|-RVA: 0x32C9150 Offset: 0x32C9251 VA: 0x32C9150
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Sort
	|
	|-RVA: 0x3112DB0 Offset: 0x3112EB1 VA: 0x3112DB0
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3115E70 Offset: 0x3115F71 VA: 0x3115E70
	|-List<TutorialUnlockFlagData>.Sort
	|
	|-RVA: 0x3118EC0 Offset: 0x3118FC1 VA: 0x3118EC0
	|-List<UIMainManagerAttachObject.AttachSet>.Sort
	|
	|-RVA: 0x311C420 Offset: 0x311C521 VA: 0x311C420
	|-List<CapEdge>.Sort
	|
	|-RVA: 0x311F3D0 Offset: 0x311F4D1 VA: 0x311F3D0
	|-List<MeshDataConnectivity.Face>.Sort
	|
	|-RVA: 0x3122720 Offset: 0x3122821 VA: 0x3122720
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Sort
	|
	|-RVA: 0x3125CE0 Offset: 0x3125DE1 VA: 0x3125CE0
	|-List<MeshFaceConnectivity.EdgeData>.Sort
	|
	|-RVA: 0x3128CF0 Offset: 0x3128DF1 VA: 0x3128CF0
	|-List<NavMeshBuildMarkup>.Sort
	|
	|-RVA: 0x312C8C0 Offset: 0x312C9C1 VA: 0x312C8C0
	|-List<NavMeshBuildSource>.Sort
	|
	|-RVA: 0x312F900 Offset: 0x312FA01 VA: 0x312F900
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x31328B0 Offset: 0x31329B1 VA: 0x31328B0
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x321E4E0 Offset: 0x321E5E1 VA: 0x321E4E0
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3221840 Offset: 0x3221941 VA: 0x3221840
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3224B90 Offset: 0x3224C91 VA: 0x3224B90
	|-List<Bounds>.Sort
	|
	|-RVA: 0x3227EE0 Offset: 0x3227FE1 VA: 0x3227EE0
	|-List<BoundsInt>.Sort
	|
	|-RVA: 0x322AEB0 Offset: 0x322AFB1 VA: 0x322AEB0
	|-List<Color32>.Sort
	|
	|-RVA: 0x322DF30 Offset: 0x322E031 VA: 0x322DF30
	|-List<Color>.Sort
	|
	|-RVA: 0x3231B20 Offset: 0x3231C21 VA: 0x3231B20
	|-List<CombineInstance>.Sort
	|
	|-RVA: 0x3235400 Offset: 0x3235501 VA: 0x3235400
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3238420 Offset: 0x3238521 VA: 0x3238420
	|-List<GradientAlphaKey>.Sort
	|
	|-RVA: 0x323B780 Offset: 0x323B881 VA: 0x323B780
	|-List<GradientColorKey>.Sort
	|
	|-RVA: 0x323EC60 Offset: 0x323ED61 VA: 0x323EC60
	|-List<Keyframe>.Sort
	|
	|-RVA: 0x3241C30 Offset: 0x3241D31 VA: 0x3241C30
	|-List<LayerMask>.Sort
	|
	|-RVA: 0x32452E0 Offset: 0x32453E1 VA: 0x32452E0
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x32487A0 Offset: 0x32488A1 VA: 0x32487A0
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x324B7B0 Offset: 0x324B8B1 VA: 0x324B7B0
	|-List<Playable>.Sort
	|
	|-RVA: 0x324EB60 Offset: 0x324EC61 VA: 0x324EB60
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3251B70 Offset: 0x3251C71 VA: 0x3251B70
	|-List<PlayableGraph>.Sort
	|
	|-RVA: 0x3254B20 Offset: 0x3254C21 VA: 0x3254B20
	|-List<Edge>.Sort
	|
	|-RVA: 0x3257BA0 Offset: 0x3257CA1 VA: 0x3257BA0
	|-List<Quaternion>.Sort
	|
	|-RVA: 0x325AB50 Offset: 0x325AC51 VA: 0x325AB50
	|-List<RangeInt>.Sort
	|
	|-RVA: 0x325E0B0 Offset: 0x325E1B1 VA: 0x325E0B0
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x3261760 Offset: 0x3261861 VA: 0x3261760
	|-List<RaycastHit>.Sort
	|
	|-RVA: 0x33C2FE0 Offset: 0x33C30E1 VA: 0x33C2FE0
	|-List<Rect>.Sort
	|
	|-RVA: 0x33C5FF0 Offset: 0x33C60F1 VA: 0x33C5FF0
	|-List<RectInt>.Sort
	|
	|-RVA: 0x33C9030 Offset: 0x33C9131 VA: 0x33C9030
	|-List<ReflectionProbeBlendInfo>.Sort
	|
	|-RVA: 0x33CCD90 Offset: 0x33CCE91 VA: 0x33CCD90
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x33CFDA0 Offset: 0x33CFEA1 VA: 0x33CFDA0
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x33D3140 Offset: 0x33D3241 VA: 0x33D3140
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x33D64E0 Offset: 0x33D65E1 VA: 0x33D64E0
	|-List<AsyncOperationHandle<SceneInstance>>.Sort
	|
	|-RVA: 0x33D9AA0 Offset: 0x33D9BA1 VA: 0x33D9AA0
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x33DCE50 Offset: 0x33DCF51 VA: 0x33DCE50
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x33E0410 Offset: 0x33E0511 VA: 0x33E0410
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x31BB370 Offset: 0x31BB471 VA: 0x31BB370
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x31BE850 Offset: 0x31BE951 VA: 0x31BE850
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x31C1BA0 Offset: 0x31C1CA1 VA: 0x31C1BA0
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x31C4F40 Offset: 0x31C5041 VA: 0x31C4F40
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x31C82E0 Offset: 0x31C83E1 VA: 0x31C82E0
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x31CB360 Offset: 0x31CB461 VA: 0x31CB360
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x31CE3A0 Offset: 0x31CE4A1 VA: 0x31CE3A0
	|-List<FocusController.FocusedElement>.Sort
	|
	|-RVA: 0x31D13B0 Offset: 0x31D14B1 VA: 0x31D13B0
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x31D4DB0 Offset: 0x31D4EB1 VA: 0x31D4DB0
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x31D8150 Offset: 0x31D8251 VA: 0x31D8150
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x31DB170 Offset: 0x31DB271 VA: 0x31DB170
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2CE3D30 Offset: 0x2CE3E31 VA: 0x2CE3D30
	|-List<Vector2Int>.Sort
	|
	|-RVA: 0x2CE6DB0 Offset: 0x2CE6EB1 VA: 0x2CE6DB0
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2CE9E70 Offset: 0x2CE9F71 VA: 0x2CE9E70
	|-List<Vector3Int>.Sort
	|
	|-RVA: 0x2CECEF0 Offset: 0x2CECFF1 VA: 0x2CECEF0
	|-List<Vector4>.Sort
	|
	|-RVA: 0x2CF0C00 Offset: 0x2CF0D01 VA: 0x2CF0C00
	|-List<WarpPoints.WarpPoint>.Sort
	|
	|-RVA: 0x2CF3BB0 Offset: 0x2CF3CB1 VA: 0x2CF3BB0
	|-List<YieldItemParam>.Sort
	|
	|-RVA: 0x2CF6F50 Offset: 0x2CF7051 VA: 0x2CF6F50
	|-List<stCommand_t>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(int index, int count, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248F1D0 Offset: 0x248F2D1 VA: 0x248F1D0
	|-List<AS_ToolController.ChargeInfo>.Sort
	|
	|-RVA: 0x2492EF0 Offset: 0x2492FF1 VA: 0x2492EF0
	|-List<BuildItemData>.Sort
	|
	|-RVA: 0x3158520 Offset: 0x3158621 VA: 0x3158520
	|-List<ButtonLinker.LinkObject>.Sort
	|
	|-RVA: 0x315B530 Offset: 0x315B631 VA: 0x315B530
	|-List<CharaCallTable.BustupTable>.Sort
	|
	|-RVA: 0x315E5F0 Offset: 0x315E6F1 VA: 0x315E5F0
	|-List<CharaCallTable.CharaFaceIconTable>.Sort
	|
	|-RVA: 0x3161630 Offset: 0x3161731 VA: 0x3161630
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x31645E0 Offset: 0x31646E1 VA: 0x31645E0
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3167590 Offset: 0x3167691 VA: 0x3167590
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x316AA70 Offset: 0x316AB71 VA: 0x316AA70
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x316DFD0 Offset: 0x316E0D1 VA: 0x316DFD0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	|
	|-RVA: 0x31715A0 Offset: 0x31716A1 VA: 0x31715A0
	|-List<CropDataTable>.Sort
	|
	|-RVA: 0x3174550 Offset: 0x3174651 VA: 0x3174550
	|-List<DropItemParam>.Sort
	|
	|-RVA: 0x3177900 Offset: 0x3177A01 VA: 0x3177900
	|-List<ErosionBrush.UndoStep>.Sort
	|
	|-RVA: 0x31DE580 Offset: 0x31DE681 VA: 0x31DE580
	|-List<EventCheckId>.Sort
	|
	|-RVA: 0x31E15D0 Offset: 0x31E16D1 VA: 0x31E15D0
	|-List<EventFlagProgressData>.Sort
	|
	|-RVA: 0x31E4620 Offset: 0x31E4721 VA: 0x31E4620
	|-List<FesNpcScoreData>.Sort
	|
	|-RVA: 0x31E7B80 Offset: 0x31E7C81 VA: 0x31E7B80
	|-List<MiningPointSaveData>.Sort
	|
	|-RVA: 0x31EB0A0 Offset: 0x31EB1A1 VA: 0x31EB0A0
	|-List<MonsterHutSaveData>.Sort
	|
	|-RVA: 0x31EE0F0 Offset: 0x31EE1F1 VA: 0x31EE0F0
	|-List<MoviePlayer.SUBTITLEDATA>.Sort
	|
	|-RVA: 0x31F17B0 Offset: 0x31F18B1 VA: 0x31F17B0
	|-List<NPCActionData>.Sort
	|
	|-RVA: 0x31F4B50 Offset: 0x31F4C51 VA: 0x31F4B50
	|-List<NpcPlaceSchedule>.Sort
	|
	|-RVA: 0x31F7C10 Offset: 0x31F7D11 VA: 0x31F7C10
	|-List<OrderLotterySaveParameter>.Sort
	|
	|-RVA: 0x31FAFC0 Offset: 0x31FB0C1 VA: 0x31FAFC0
	|-List<OrderSaveParameter>.Sort
	|
	|-RVA: 0x31FE010 Offset: 0x31FE111 VA: 0x31FE010
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x330D270 Offset: 0x330D371 VA: 0x330D270
	|-List<ShopCatalogPage>.Sort
	|
	|-RVA: 0x3310830 Offset: 0x3310931 VA: 0x3310830
	|-List<ShopNpcTalk>.Sort
	|
	|-RVA: 0x33138F0 Offset: 0x33139F1 VA: 0x33138F0
	|-List<SubtitleDataTable.Data>.Sort
	|
	|-RVA: 0x33168C0 Offset: 0x33169C1 VA: 0x33168C0
	|-List<SubtitleDataTable.DataList>.Sort
	|
	|-RVA: 0x3319980 Offset: 0x3319A81 VA: 0x3319980
	|-List<SubtitleHudDataTable.Data>.Sort
	|
	|-RVA: 0x331CD30 Offset: 0x331CE31 VA: 0x331CD30
	|-List<SRMonoBehaviourEx.FieldInfo>.Sort
	|
	|-RVA: 0x3320080 Offset: 0x3320181 VA: 0x3320080
	|-List<Schedule>.Sort
	|
	|-RVA: 0x3323930 Offset: 0x3323A31 VA: 0x3323930
	|-List<CurveSample>.Sort
	|
	|-RVA: 0x3326920 Offset: 0x3326A21 VA: 0x3326920
	|-List<bool>.Sort
	|
	|-RVA: 0x33298F0 Offset: 0x33299F1 VA: 0x33298F0
	|-List<byte>.Sort
	|
	|-RVA: 0x332C8A0 Offset: 0x332C9A1 VA: 0x332C8A0
	|-List<char>.Sort
	|
	|-RVA: 0x335A990 Offset: 0x335AA91 VA: 0x335A990
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x335D9E0 Offset: 0x335DAE1 VA: 0x335D9E0
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3360A20 Offset: 0x3360B21 VA: 0x3360A20
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x33639D0 Offset: 0x3363AD1 VA: 0x33639D0
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3366980 Offset: 0x3366A81 VA: 0x3366980
	|-List<double>.Sort
	|
	|-RVA: 0x3369930 Offset: 0x3369A31 VA: 0x3369930
	|-List<short>.Sort
	|
	|-RVA: 0x336C8E0 Offset: 0x336C9E1 VA: 0x336C8E0
	|-List<int>.Sort
	|
	|-RVA: 0x336F890 Offset: 0x336F991 VA: 0x336F890
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3372840 Offset: 0x3372941 VA: 0x3372840
	|-List<long>.Sort
	|
	|-RVA: 0x3375880 Offset: 0x3375981 VA: 0x3375880
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3378880 Offset: 0x3378981 VA: 0x3378880
	|-List<Nullable<Int32Enum>>.Sort
	|
	|-RVA: 0x3407AD0 Offset: 0x3407BD1 VA: 0x3407AD0
	|-List<Nullable<Bounds>>.Sort
	|
	|-RVA: 0x340B090 Offset: 0x340B191 VA: 0x340B090
	|-List<Nullable<BoundsInt>>.Sort
	|
	|-RVA: 0x340E090 Offset: 0x340E191 VA: 0x340E090
	|-List<Nullable<Color32>>.Sort
	|
	|-RVA: 0x34114F0 Offset: 0x34115F1 VA: 0x34114F0
	|-List<Nullable<Color>>.Sort
	|
	|-RVA: 0x3414610 Offset: 0x3414711 VA: 0x3414610
	|-List<Nullable<GradientAlphaKey>>.Sort
	|
	|-RVA: 0x3417A60 Offset: 0x3417B61 VA: 0x3417A60
	|-List<Nullable<GradientColorKey>>.Sort
	|
	|-RVA: 0x341AEC0 Offset: 0x341AFC1 VA: 0x341AEC0
	|-List<Nullable<Keyframe>>.Sort
	|
	|-RVA: 0x341DEC0 Offset: 0x341DFC1 VA: 0x341DEC0
	|-List<Nullable<LayerMask>>.Sort
	|
	|-RVA: 0x3421900 Offset: 0x3421A01 VA: 0x3421900
	|-List<Nullable<Matrix4x4>>.Sort
	|
	|-RVA: 0x3424D60 Offset: 0x3424E61 VA: 0x3424D60
	|-List<Nullable<Quaternion>>.Sort
	|
	|-RVA: 0x32648F0 Offset: 0x32649F1 VA: 0x32648F0
	|-List<Nullable<RangeInt>>.Sort
	|
	|-RVA: 0x3267D50 Offset: 0x3267E51 VA: 0x3267D50
	|-List<Nullable<Rect>>.Sort
	|
	|-RVA: 0x326B1B0 Offset: 0x326B2B1 VA: 0x326B1B0
	|-List<Nullable<RectInt>>.Sort
	|
	|-RVA: 0x326E2D0 Offset: 0x326E3D1 VA: 0x326E2D0
	|-List<Nullable<Vector2>>.Sort
	|
	|-RVA: 0x32713F0 Offset: 0x32714F1 VA: 0x32713F0
	|-List<Nullable<Vector2Int>>.Sort
	|
	|-RVA: 0x3274460 Offset: 0x3274561 VA: 0x3274460
	|-List<Nullable<Vector3>>.Sort
	|
	|-RVA: 0x32774D0 Offset: 0x32775D1 VA: 0x32774D0
	|-List<Nullable<Vector3Int>>.Sort
	|
	|-RVA: 0x327A930 Offset: 0x327AA31 VA: 0x327A930
	|-List<Nullable<Vector4>>.Sort
	|
	|-RVA: 0x327D860 Offset: 0x327D961 VA: 0x327D860
	|-List<object>.Sort
	|-List<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x3280830 Offset: 0x3280931 VA: 0x3280830
	|-List<sbyte>.Sort
	|
	|-RVA: 0x32837E0 Offset: 0x32838E1 VA: 0x32837E0
	|-List<float>.Sort
	|
	|-RVA: 0x32AAA40 Offset: 0x32AAB41 VA: 0x32AAA40
	|-List<ushort>.Sort
	|
	|-RVA: 0x32AD9F0 Offset: 0x32ADAF1 VA: 0x32AD9F0
	|-List<uint>.Sort
	|
	|-RVA: 0x32B09A0 Offset: 0x32B0AA1 VA: 0x32B09A0
	|-List<ulong>.Sort
	|
	|-RVA: 0x32B3950 Offset: 0x32B3A51 VA: 0x32B3950
	|-List<ValueTuple<bool, Int32Enum>>.Sort
	|
	|-RVA: 0x32B6900 Offset: 0x32B6A01 VA: 0x32B6900
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x32B9950 Offset: 0x32B9A51 VA: 0x32B9950
	|-List<ValueTuple<Int32Enum, object>>.Sort
	|
	|-RVA: 0x32BC990 Offset: 0x32BCA91 VA: 0x32BC990
	|-List<ValueTuple<object, Int32Enum>>.Sort
	|
	|-RVA: 0x32BF9D0 Offset: 0x32BFAD1 VA: 0x32BF9D0
	|-List<ValueTuple<object, object>>.Sort
	|
	|-RVA: 0x32C2A10 Offset: 0x32C2B11 VA: 0x32C2A10
	|-List<ValueTuple<object, float>>.Sort
	|
	|-RVA: 0x32C5AD0 Offset: 0x32C5BD1 VA: 0x32C5AD0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Sort
	|
	|-RVA: 0x32C91C0 Offset: 0x32C92C1 VA: 0x32C91C0
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Sort
	|
	|-RVA: 0x3112E20 Offset: 0x3112F21 VA: 0x3112E20
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3115EE0 Offset: 0x3115FE1 VA: 0x3115EE0
	|-List<TutorialUnlockFlagData>.Sort
	|
	|-RVA: 0x3118F30 Offset: 0x3119031 VA: 0x3118F30
	|-List<UIMainManagerAttachObject.AttachSet>.Sort
	|
	|-RVA: 0x311C490 Offset: 0x311C591 VA: 0x311C490
	|-List<CapEdge>.Sort
	|
	|-RVA: 0x311F440 Offset: 0x311F541 VA: 0x311F440
	|-List<MeshDataConnectivity.Face>.Sort
	|
	|-RVA: 0x3122790 Offset: 0x3122891 VA: 0x3122790
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Sort
	|
	|-RVA: 0x3125D50 Offset: 0x3125E51 VA: 0x3125D50
	|-List<MeshFaceConnectivity.EdgeData>.Sort
	|
	|-RVA: 0x3128D60 Offset: 0x3128E61 VA: 0x3128D60
	|-List<NavMeshBuildMarkup>.Sort
	|
	|-RVA: 0x312C930 Offset: 0x312CA31 VA: 0x312C930
	|-List<NavMeshBuildSource>.Sort
	|
	|-RVA: 0x312F970 Offset: 0x312FA71 VA: 0x312F970
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x3132920 Offset: 0x3132A21 VA: 0x3132920
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x321E550 Offset: 0x321E651 VA: 0x321E550
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x32218B0 Offset: 0x32219B1 VA: 0x32218B0
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3224C00 Offset: 0x3224D01 VA: 0x3224C00
	|-List<Bounds>.Sort
	|
	|-RVA: 0x3227F50 Offset: 0x3228051 VA: 0x3227F50
	|-List<BoundsInt>.Sort
	|
	|-RVA: 0x322AF20 Offset: 0x322B021 VA: 0x322AF20
	|-List<Color32>.Sort
	|
	|-RVA: 0x322DFA0 Offset: 0x322E0A1 VA: 0x322DFA0
	|-List<Color>.Sort
	|
	|-RVA: 0x3231B90 Offset: 0x3231C91 VA: 0x3231B90
	|-List<CombineInstance>.Sort
	|
	|-RVA: 0x3235470 Offset: 0x3235571 VA: 0x3235470
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3238490 Offset: 0x3238591 VA: 0x3238490
	|-List<GradientAlphaKey>.Sort
	|
	|-RVA: 0x323B7F0 Offset: 0x323B8F1 VA: 0x323B7F0
	|-List<GradientColorKey>.Sort
	|
	|-RVA: 0x323ECD0 Offset: 0x323EDD1 VA: 0x323ECD0
	|-List<Keyframe>.Sort
	|
	|-RVA: 0x3241CA0 Offset: 0x3241DA1 VA: 0x3241CA0
	|-List<LayerMask>.Sort
	|
	|-RVA: 0x3245350 Offset: 0x3245451 VA: 0x3245350
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x3248810 Offset: 0x3248911 VA: 0x3248810
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x324B820 Offset: 0x324B921 VA: 0x324B820
	|-List<Playable>.Sort
	|
	|-RVA: 0x324EBD0 Offset: 0x324ECD1 VA: 0x324EBD0
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3251BE0 Offset: 0x3251CE1 VA: 0x3251BE0
	|-List<PlayableGraph>.Sort
	|
	|-RVA: 0x3254B90 Offset: 0x3254C91 VA: 0x3254B90
	|-List<Edge>.Sort
	|
	|-RVA: 0x3257C10 Offset: 0x3257D11 VA: 0x3257C10
	|-List<Quaternion>.Sort
	|
	|-RVA: 0x325ABC0 Offset: 0x325ACC1 VA: 0x325ABC0
	|-List<RangeInt>.Sort
	|
	|-RVA: 0x325E120 Offset: 0x325E221 VA: 0x325E120
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x32617D0 Offset: 0x32618D1 VA: 0x32617D0
	|-List<RaycastHit>.Sort
	|
	|-RVA: 0x33C3050 Offset: 0x33C3151 VA: 0x33C3050
	|-List<Rect>.Sort
	|
	|-RVA: 0x33C6060 Offset: 0x33C6161 VA: 0x33C6060
	|-List<RectInt>.Sort
	|
	|-RVA: 0x33C90A0 Offset: 0x33C91A1 VA: 0x33C90A0
	|-List<ReflectionProbeBlendInfo>.Sort
	|
	|-RVA: 0x33CCE00 Offset: 0x33CCF01 VA: 0x33CCE00
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x33CFE10 Offset: 0x33CFF11 VA: 0x33CFE10
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x33D31B0 Offset: 0x33D32B1 VA: 0x33D31B0
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x33D6550 Offset: 0x33D6651 VA: 0x33D6550
	|-List<AsyncOperationHandle<SceneInstance>>.Sort
	|
	|-RVA: 0x33D9B10 Offset: 0x33D9C11 VA: 0x33D9B10
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x33DCEC0 Offset: 0x33DCFC1 VA: 0x33DCEC0
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x33E0480 Offset: 0x33E0581 VA: 0x33E0480
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x31BB3E0 Offset: 0x31BB4E1 VA: 0x31BB3E0
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x31BE8C0 Offset: 0x31BE9C1 VA: 0x31BE8C0
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x31C1C10 Offset: 0x31C1D11 VA: 0x31C1C10
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x31C4FB0 Offset: 0x31C50B1 VA: 0x31C4FB0
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x31C8350 Offset: 0x31C8451 VA: 0x31C8350
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x31CB3D0 Offset: 0x31CB4D1 VA: 0x31CB3D0
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x31CE410 Offset: 0x31CE511 VA: 0x31CE410
	|-List<FocusController.FocusedElement>.Sort
	|
	|-RVA: 0x31D1420 Offset: 0x31D1521 VA: 0x31D1420
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x31D4E20 Offset: 0x31D4F21 VA: 0x31D4E20
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x31D81C0 Offset: 0x31D82C1 VA: 0x31D81C0
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x31DB1E0 Offset: 0x31DB2E1 VA: 0x31DB1E0
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2CE3DA0 Offset: 0x2CE3EA1 VA: 0x2CE3DA0
	|-List<Vector2Int>.Sort
	|
	|-RVA: 0x2CE6E20 Offset: 0x2CE6F21 VA: 0x2CE6E20
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2CE9EE0 Offset: 0x2CE9FE1 VA: 0x2CE9EE0
	|-List<Vector3Int>.Sort
	|
	|-RVA: 0x2CECF60 Offset: 0x2CED061 VA: 0x2CECF60
	|-List<Vector4>.Sort
	|
	|-RVA: 0x2CF0C70 Offset: 0x2CF0D71 VA: 0x2CF0C70
	|-List<WarpPoints.WarpPoint>.Sort
	|
	|-RVA: 0x2CF3C20 Offset: 0x2CF3D21 VA: 0x2CF3C20
	|-List<YieldItemParam>.Sort
	|
	|-RVA: 0x2CF6FC0 Offset: 0x2CF70C1 VA: 0x2CF6FC0
	|-List<stCommand_t>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327D930 Offset: 0x327DA31 VA: 0x327D930
	|-List<<>f__AnonymousType0<SpringBone, int>>.Sort
	|-List<BgmList>.Sort
	|-List<CameraManager.CameraControllerPair>.Sort
	|-List<CinemachineComponentBase>.Sort
	|-List<FesNpcScore>.Sort
	|-List<HUDDualWorkSelectInput.DualSelect>.Sort
	|-List<ItemData>.Sort
	|-List<AssetHandle>.Sort
	|-List<Level2Map>.Sort
	|-List<MonsterActionInformation>.Sort
	|-List<NpcLifeCycleDataRecord>.Sort
	|-List<FishShipmentRecords>.Sort
	|-List<ShipmentItemRecords>.Sort
	|-List<SeedShopItemDataTable.SeedShopItemData>.Sort
	|-List<OptionDefinition>.Sort
	|-List<object>.Sort
	|-List<TimeZoneInfo.AdjustmentRule>.Sort
	|-List<Camera>.Sort
	|-List<TimelineClip>.Sort
	|-List<Graphic>.Sort
	|
	|-RVA: 0x248F2A0 Offset: 0x248F3A1 VA: 0x248F2A0
	|-List<AS_ToolController.ChargeInfo>.Sort
	|
	|-RVA: 0x2492FC0 Offset: 0x24930C1 VA: 0x2492FC0
	|-List<BuildItemData>.Sort
	|
	|-RVA: 0x31585F0 Offset: 0x31586F1 VA: 0x31585F0
	|-List<ButtonLinker.LinkObject>.Sort
	|
	|-RVA: 0x315B600 Offset: 0x315B701 VA: 0x315B600
	|-List<CharaCallTable.BustupTable>.Sort
	|
	|-RVA: 0x315E6C0 Offset: 0x315E7C1 VA: 0x315E6C0
	|-List<CharaCallTable.CharaFaceIconTable>.Sort
	|
	|-RVA: 0x3161700 Offset: 0x3161801 VA: 0x3161700
	|-List<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x31646B0 Offset: 0x31647B1 VA: 0x31646B0
	|-List<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x3167660 Offset: 0x3167761 VA: 0x3167660
	|-List<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x316AB40 Offset: 0x316AC41 VA: 0x316AB40
	|-List<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x316E0A0 Offset: 0x316E1A1 VA: 0x316E0A0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	|
	|-RVA: 0x3171670 Offset: 0x3171771 VA: 0x3171670
	|-List<CropDataTable>.Sort
	|
	|-RVA: 0x336F960 Offset: 0x336FA61 VA: 0x336F960
	|-List<ActorID>.Sort
	|-List<RecipeId>.Sort
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x3174620 Offset: 0x3174721 VA: 0x3174620
	|-List<DropItemParam>.Sort
	|
	|-RVA: 0x31779D0 Offset: 0x3177AD1 VA: 0x31779D0
	|-List<ErosionBrush.UndoStep>.Sort
	|
	|-RVA: 0x31DE650 Offset: 0x31DE751 VA: 0x31DE650
	|-List<EventCheckId>.Sort
	|
	|-RVA: 0x31E16A0 Offset: 0x31E17A1 VA: 0x31E16A0
	|-List<EventFlagProgressData>.Sort
	|
	|-RVA: 0x31E46F0 Offset: 0x31E47F1 VA: 0x31E46F0
	|-List<FesNpcScoreData>.Sort
	|
	|-RVA: 0x31E7C50 Offset: 0x31E7D51 VA: 0x31E7C50
	|-List<MiningPointSaveData>.Sort
	|
	|-RVA: 0x31EB170 Offset: 0x31EB271 VA: 0x31EB170
	|-List<MonsterHutSaveData>.Sort
	|
	|-RVA: 0x31EE1C0 Offset: 0x31EE2C1 VA: 0x31EE1C0
	|-List<MoviePlayer.SUBTITLEDATA>.Sort
	|
	|-RVA: 0x31F1880 Offset: 0x31F1981 VA: 0x31F1880
	|-List<NPCActionData>.Sort
	|
	|-RVA: 0x31F4C20 Offset: 0x31F4D21 VA: 0x31F4C20
	|-List<NpcPlaceSchedule>.Sort
	|
	|-RVA: 0x31F7CE0 Offset: 0x31F7DE1 VA: 0x31F7CE0
	|-List<OrderLotterySaveParameter>.Sort
	|
	|-RVA: 0x31FB090 Offset: 0x31FB191 VA: 0x31FB090
	|-List<OrderSaveParameter>.Sort
	|
	|-RVA: 0x31FE0E0 Offset: 0x31FE1E1 VA: 0x31FE0E0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.Sort
	|
	|-RVA: 0x330D340 Offset: 0x330D441 VA: 0x330D340
	|-List<ShopCatalogPage>.Sort
	|
	|-RVA: 0x3310900 Offset: 0x3310A01 VA: 0x3310900
	|-List<ShopNpcTalk>.Sort
	|
	|-RVA: 0x33139C0 Offset: 0x3313AC1 VA: 0x33139C0
	|-List<SubtitleDataTable.Data>.Sort
	|
	|-RVA: 0x3316990 Offset: 0x3316A91 VA: 0x3316990
	|-List<SubtitleDataTable.DataList>.Sort
	|
	|-RVA: 0x3319A50 Offset: 0x3319B51 VA: 0x3319A50
	|-List<SubtitleHudDataTable.Data>.Sort
	|
	|-RVA: 0x331CE00 Offset: 0x331CF01 VA: 0x331CE00
	|-List<SRMonoBehaviourEx.FieldInfo>.Sort
	|
	|-RVA: 0x3320150 Offset: 0x3320251 VA: 0x3320150
	|-List<Schedule>.Sort
	|
	|-RVA: 0x3323A00 Offset: 0x3323B01 VA: 0x3323A00
	|-List<CurveSample>.Sort
	|
	|-RVA: 0x33269F0 Offset: 0x3326AF1 VA: 0x33269F0
	|-List<bool>.Sort
	|
	|-RVA: 0x33299C0 Offset: 0x3329AC1 VA: 0x33299C0
	|-List<byte>.Sort
	|
	|-RVA: 0x332C970 Offset: 0x332CA71 VA: 0x332C970
	|-List<char>.Sort
	|
	|-RVA: 0x335AA60 Offset: 0x335AB61 VA: 0x335AA60
	|-List<KeyValuePair<DateTime, object>>.Sort
	|
	|-RVA: 0x335DAB0 Offset: 0x335DBB1 VA: 0x335DAB0
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x3360AF0 Offset: 0x3360BF1 VA: 0x3360AF0
	|-List<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x3363AA0 Offset: 0x3363BA1 VA: 0x3363AA0
	|-List<DateTime>.Sort
	|
	|-RVA: 0x3366A50 Offset: 0x3366B51 VA: 0x3366A50
	|-List<double>.Sort
	|
	|-RVA: 0x3369A00 Offset: 0x3369B01 VA: 0x3369A00
	|-List<short>.Sort
	|
	|-RVA: 0x336C9B0 Offset: 0x336CAB1 VA: 0x336C9B0
	|-List<int>.Sort
	|
	|-RVA: 0x3372910 Offset: 0x3372A11 VA: 0x3372910
	|-List<long>.Sort
	|
	|-RVA: 0x3375950 Offset: 0x3375A51 VA: 0x3375950
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x3378950 Offset: 0x3378A51 VA: 0x3378950
	|-List<Nullable<Int32Enum>>.Sort
	|
	|-RVA: 0x3407BA0 Offset: 0x3407CA1 VA: 0x3407BA0
	|-List<Nullable<Bounds>>.Sort
	|
	|-RVA: 0x340B160 Offset: 0x340B261 VA: 0x340B160
	|-List<Nullable<BoundsInt>>.Sort
	|
	|-RVA: 0x340E160 Offset: 0x340E261 VA: 0x340E160
	|-List<Nullable<Color32>>.Sort
	|
	|-RVA: 0x34115C0 Offset: 0x34116C1 VA: 0x34115C0
	|-List<Nullable<Color>>.Sort
	|
	|-RVA: 0x34146E0 Offset: 0x34147E1 VA: 0x34146E0
	|-List<Nullable<GradientAlphaKey>>.Sort
	|
	|-RVA: 0x3417B30 Offset: 0x3417C31 VA: 0x3417B30
	|-List<Nullable<GradientColorKey>>.Sort
	|
	|-RVA: 0x341AF90 Offset: 0x341B091 VA: 0x341AF90
	|-List<Nullable<Keyframe>>.Sort
	|
	|-RVA: 0x341DF90 Offset: 0x341E091 VA: 0x341DF90
	|-List<Nullable<LayerMask>>.Sort
	|
	|-RVA: 0x34219D0 Offset: 0x3421AD1 VA: 0x34219D0
	|-List<Nullable<Matrix4x4>>.Sort
	|
	|-RVA: 0x3424E30 Offset: 0x3424F31 VA: 0x3424E30
	|-List<Nullable<Quaternion>>.Sort
	|
	|-RVA: 0x32649C0 Offset: 0x3264AC1 VA: 0x32649C0
	|-List<Nullable<RangeInt>>.Sort
	|
	|-RVA: 0x3267E20 Offset: 0x3267F21 VA: 0x3267E20
	|-List<Nullable<Rect>>.Sort
	|
	|-RVA: 0x326B280 Offset: 0x326B381 VA: 0x326B280
	|-List<Nullable<RectInt>>.Sort
	|
	|-RVA: 0x326E3A0 Offset: 0x326E4A1 VA: 0x326E3A0
	|-List<Nullable<Vector2>>.Sort
	|
	|-RVA: 0x32714C0 Offset: 0x32715C1 VA: 0x32714C0
	|-List<Nullable<Vector2Int>>.Sort
	|
	|-RVA: 0x3274530 Offset: 0x3274631 VA: 0x3274530
	|-List<Nullable<Vector3>>.Sort
	|
	|-RVA: 0x32775A0 Offset: 0x32776A1 VA: 0x32775A0
	|-List<Nullable<Vector3Int>>.Sort
	|
	|-RVA: 0x327AA00 Offset: 0x327AB01 VA: 0x327AA00
	|-List<Nullable<Vector4>>.Sort
	|
	|-RVA: 0x3280900 Offset: 0x3280A01 VA: 0x3280900
	|-List<sbyte>.Sort
	|
	|-RVA: 0x32838B0 Offset: 0x32839B1 VA: 0x32838B0
	|-List<float>.Sort
	|
	|-RVA: 0x32AAB10 Offset: 0x32AAC11 VA: 0x32AAB10
	|-List<ushort>.Sort
	|
	|-RVA: 0x32ADAC0 Offset: 0x32ADBC1 VA: 0x32ADAC0
	|-List<uint>.Sort
	|
	|-RVA: 0x32B0A70 Offset: 0x32B0B71 VA: 0x32B0A70
	|-List<ulong>.Sort
	|
	|-RVA: 0x32C2AE0 Offset: 0x32C2BE1 VA: 0x32C2AE0
	|-List<ValueTuple<CharacterBase, float>>.Sort
	|-List<ValueTuple<object, float>>.Sort
	|
	|-RVA: 0x32B3A20 Offset: 0x32B3B21 VA: 0x32B3A20
	|-List<ValueTuple<bool, Int32Enum>>.Sort
	|
	|-RVA: 0x32B69D0 Offset: 0x32B6AD1 VA: 0x32B69D0
	|-List<ValueTuple<Int32Enum, int>>.Sort
	|
	|-RVA: 0x32B9A20 Offset: 0x32B9B21 VA: 0x32B9A20
	|-List<ValueTuple<Int32Enum, object>>.Sort
	|
	|-RVA: 0x32BCA60 Offset: 0x32BCB61 VA: 0x32BCA60
	|-List<ValueTuple<object, Int32Enum>>.Sort
	|
	|-RVA: 0x32BFAA0 Offset: 0x32BFBA1 VA: 0x32BFAA0
	|-List<ValueTuple<object, object>>.Sort
	|
	|-RVA: 0x32C5BA0 Offset: 0x32C5CA1 VA: 0x32C5BA0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.Sort
	|
	|-RVA: 0x32C9290 Offset: 0x32C9391 VA: 0x32C9290
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.Sort
	|
	|-RVA: 0x3112EF0 Offset: 0x3112FF1 VA: 0x3112EF0
	|-List<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x3115FB0 Offset: 0x31160B1 VA: 0x3115FB0
	|-List<TutorialUnlockFlagData>.Sort
	|
	|-RVA: 0x3119000 Offset: 0x3119101 VA: 0x3119000
	|-List<UIMainManagerAttachObject.AttachSet>.Sort
	|
	|-RVA: 0x311C560 Offset: 0x311C661 VA: 0x311C560
	|-List<CapEdge>.Sort
	|
	|-RVA: 0x311F510 Offset: 0x311F611 VA: 0x311F510
	|-List<MeshDataConnectivity.Face>.Sort
	|
	|-RVA: 0x3122860 Offset: 0x3122961 VA: 0x3122860
	|-List<MeshFaceConnectivity.EdgeData.SideData>.Sort
	|
	|-RVA: 0x3125E20 Offset: 0x3125F21 VA: 0x3125E20
	|-List<MeshFaceConnectivity.EdgeData>.Sort
	|
	|-RVA: 0x3128E30 Offset: 0x3128F31 VA: 0x3128E30
	|-List<NavMeshBuildMarkup>.Sort
	|
	|-RVA: 0x312CA00 Offset: 0x312CB01 VA: 0x312CA00
	|-List<NavMeshBuildSource>.Sort
	|
	|-RVA: 0x312FA40 Offset: 0x312FB41 VA: 0x312FA40
	|-List<ConstraintSource>.Sort
	|
	|-RVA: 0x31329F0 Offset: 0x3132AF1 VA: 0x31329F0
	|-List<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x321E620 Offset: 0x321E721 VA: 0x321E620
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x3221980 Offset: 0x3221A81 VA: 0x3221980
	|-List<BoneWeight>.Sort
	|
	|-RVA: 0x3224CD0 Offset: 0x3224DD1 VA: 0x3224CD0
	|-List<Bounds>.Sort
	|
	|-RVA: 0x3228020 Offset: 0x3228121 VA: 0x3228020
	|-List<BoundsInt>.Sort
	|
	|-RVA: 0x322AFF0 Offset: 0x322B0F1 VA: 0x322AFF0
	|-List<Color32>.Sort
	|
	|-RVA: 0x322E070 Offset: 0x322E171 VA: 0x322E070
	|-List<Color>.Sort
	|
	|-RVA: 0x3231C60 Offset: 0x3231D61 VA: 0x3231C60
	|-List<CombineInstance>.Sort
	|
	|-RVA: 0x3235540 Offset: 0x3235641 VA: 0x3235540
	|-List<RaycastResult>.Sort
	|
	|-RVA: 0x3238560 Offset: 0x3238661 VA: 0x3238560
	|-List<GradientAlphaKey>.Sort
	|
	|-RVA: 0x323B8C0 Offset: 0x323B9C1 VA: 0x323B8C0
	|-List<GradientColorKey>.Sort
	|
	|-RVA: 0x323EDA0 Offset: 0x323EEA1 VA: 0x323EDA0
	|-List<Keyframe>.Sort
	|
	|-RVA: 0x3241D70 Offset: 0x3241E71 VA: 0x3241D70
	|-List<LayerMask>.Sort
	|
	|-RVA: 0x3245420 Offset: 0x3245521 VA: 0x3245420
	|-List<Matrix4x4>.Sort
	|
	|-RVA: 0x32488E0 Offset: 0x32489E1 VA: 0x32488E0
	|-List<ParticleSystem.Particle>.Sort
	|
	|-RVA: 0x324B8F0 Offset: 0x324B9F1 VA: 0x324B8F0
	|-List<Playable>.Sort
	|
	|-RVA: 0x324ECA0 Offset: 0x324EDA1 VA: 0x324ECA0
	|-List<PlayableBinding>.Sort
	|
	|-RVA: 0x3251CB0 Offset: 0x3251DB1 VA: 0x3251CB0
	|-List<PlayableGraph>.Sort
	|
	|-RVA: 0x3254C60 Offset: 0x3254D61 VA: 0x3254C60
	|-List<Edge>.Sort
	|
	|-RVA: 0x3257CE0 Offset: 0x3257DE1 VA: 0x3257CE0
	|-List<Quaternion>.Sort
	|
	|-RVA: 0x325AC90 Offset: 0x325AD91 VA: 0x325AC90
	|-List<RangeInt>.Sort
	|
	|-RVA: 0x325E1F0 Offset: 0x325E2F1 VA: 0x325E1F0
	|-List<RaycastHit2D>.Sort
	|
	|-RVA: 0x32618A0 Offset: 0x32619A1 VA: 0x32618A0
	|-List<RaycastHit>.Sort
	|
	|-RVA: 0x33C3120 Offset: 0x33C3221 VA: 0x33C3120
	|-List<Rect>.Sort
	|
	|-RVA: 0x33C6130 Offset: 0x33C6231 VA: 0x33C6130
	|-List<RectInt>.Sort
	|
	|-RVA: 0x33C9170 Offset: 0x33C9271 VA: 0x33C9170
	|-List<ReflectionProbeBlendInfo>.Sort
	|
	|-RVA: 0x33CCED0 Offset: 0x33CCFD1 VA: 0x33CCED0
	|-List<SphericalHarmonicsL2>.Sort
	|
	|-RVA: 0x33CFEE0 Offset: 0x33CFFE1 VA: 0x33CFEE0
	|-List<VertexAttributeDescriptor>.Sort
	|
	|-RVA: 0x33D3280 Offset: 0x33D3381 VA: 0x33D3280
	|-List<AsyncOperationHandle>.Sort
	|
	|-RVA: 0x33D6620 Offset: 0x33D6721 VA: 0x33D6620
	|-List<AsyncOperationHandle<SceneInstance>>.Sort
	|
	|-RVA: 0x33D9BE0 Offset: 0x33D9CE1 VA: 0x33D9BE0
	|-List<DiagnosticEvent>.Sort
	|
	|-RVA: 0x33DCF90 Offset: 0x33DD091 VA: 0x33DCF90
	|-List<DelayedActionManager.DelegateInfo>.Sort
	|
	|-RVA: 0x33E0550 Offset: 0x33E0651 VA: 0x33E0550
	|-List<ObjectInitializationData>.Sort
	|
	|-RVA: 0x31BB4B0 Offset: 0x31BB5B1 VA: 0x31BB4B0
	|-List<GlyphRect>.Sort
	|
	|-RVA: 0x31BE990 Offset: 0x31BEA91 VA: 0x31BE990
	|-List<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x31C1CE0 Offset: 0x31C1DE1 VA: 0x31C1CE0
	|-List<IntervalTreeNode>.Sort
	|
	|-RVA: 0x31C5080 Offset: 0x31C5181 VA: 0x31C5080
	|-List<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x31C8420 Offset: 0x31C8521 VA: 0x31C8420
	|-List<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x31CB4A0 Offset: 0x31CB5A1 VA: 0x31CB4A0
	|-List<UICharInfo>.Sort
	|
	|-RVA: 0x31CE4E0 Offset: 0x31CE5E1 VA: 0x31CE4E0
	|-List<FocusController.FocusedElement>.Sort
	|
	|-RVA: 0x31D14F0 Offset: 0x31D15F1 VA: 0x31D14F0
	|-List<UILineInfo>.Sort
	|
	|-RVA: 0x31D4EF0 Offset: 0x31D4FF1 VA: 0x31D4EF0
	|-List<UIVertex>.Sort
	|
	|-RVA: 0x31D8290 Offset: 0x31D8391 VA: 0x31D8290
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x31DB2B0 Offset: 0x31DB3B1 VA: 0x31DB2B0
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2CE3E70 Offset: 0x2CE3F71 VA: 0x2CE3E70
	|-List<Vector2Int>.Sort
	|
	|-RVA: 0x2CE6EF0 Offset: 0x2CE6FF1 VA: 0x2CE6EF0
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2CE9FB0 Offset: 0x2CEA0B1 VA: 0x2CE9FB0
	|-List<Vector3Int>.Sort
	|
	|-RVA: 0x2CED030 Offset: 0x2CED131 VA: 0x2CED030
	|-List<Vector4>.Sort
	|
	|-RVA: 0x2CF0D40 Offset: 0x2CF0E41 VA: 0x2CF0D40
	|-List<WarpPoints.WarpPoint>.Sort
	|
	|-RVA: 0x2CF3CF0 Offset: 0x2CF3DF1 VA: 0x2CF3CF0
	|-List<YieldItemParam>.Sort
	|
	|-RVA: 0x2CF7090 Offset: 0x2CF7191 VA: 0x2CF7090
	|-List<stCommand_t>.Sort
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327D9B0 Offset: 0x327DAB1 VA: 0x327D9B0
	|-List<ActionCommandBase>.ToArray
	|-List<CinemachineComponentBase>.ToArray
	|-List<CinemachineVirtualCameraBase>.ToArray
	|-List<EnvironmentSoundDataTable>.ToArray
	|-List<FarmCropData>.ToArray
	|-List<HumanController>.ToArray
	|-List<ItemData>.ToArray
	|-List<ItemIconMng.ImageLoaderObj>.ToArray
	|-List<ObjectSerializationInfo.EmittableMemberAndConstructorParameter>.ToArray
	|-List<InteractionTarget>.ToArray
	|-List<Settings.KeyboardShortcut>.ToArray
	|-List<SimpleAnimation.EditorState>.ToArray
	|-List<Streamer>.ToArray
	|-List<byte[]>.ToArray
	|-List<ByRefUpdater>.ToArray
	|-List<DebugInfo>.ToArray
	|-List<ExceptionHandler>.ToArray
	|-List<Instruction>.ToArray
	|-List<FieldInfo>.ToArray
	|-List<Type>.ToArray
	|-List<SpringBone>.ToArray
	|-List<VertexData>.ToArray
	|-List<UltimateRope.RopeBone>.ToArray
	|-List<Camera>.ToArray
	|-List<GameObject>.ToArray
	|-List<Material>.ToArray
	|-List<Renderer>.ToArray
	|-List<TimelineClip>.ToArray
	|-List<TrackAsset>.ToArray
	|-List<Transform>.ToArray
	|-List<Contraction>.ToArray
	|-List<Level2Map>.ToArray
	|-List<StackFrame>.ToArray
	|-List<object>.ToArray
	|-List<Module>.ToArray
	|-List<IContextProperty>.ToArray
	|-List<string>.ToArray
	|-List<TimeZoneInfo.AdjustmentRule>.ToArray
	|
	|-RVA: 0x3164730 Offset: 0x3164831 VA: 0x3164730
	|-List<CinemachineClearShot.Pair>.ToArray
	|
	|-RVA: 0x336F9E0 Offset: 0x336FAE1 VA: 0x336F9E0
	|-List<DLCID>.ToArray
	|-List<MakingID>.ToArray
	|-List<ItemID>.ToArray
	|-List<Int32Enum>.ToArray
	|
	|-RVA: 0x31E7CD0 Offset: 0x31E7DD1 VA: 0x31E7CD0
	|-List<MiningPointSaveData>.ToArray
	|
	|-RVA: 0x31EB1F0 Offset: 0x31EB2F1 VA: 0x31EB1F0
	|-List<MonsterHutSaveData>.ToArray
	|
	|-RVA: 0x3329A40 Offset: 0x3329B41 VA: 0x3329A40
	|-List<byte>.ToArray
	|
	|-RVA: 0x33759D0 Offset: 0x3375AD1 VA: 0x33759D0
	|-List<InterpretedFrameInfo>.ToArray
	|
	|-RVA: 0x32ADB40 Offset: 0x32ADC41 VA: 0x32ADB40
	|-List<uint>.ToArray
	|
	|-RVA: 0x3128EB0 Offset: 0x3128FB1 VA: 0x3128EB0
	|-List<NavMeshBuildMarkup>.ToArray
	|
	|-RVA: 0x3221A00 Offset: 0x3221B01 VA: 0x3221A00
	|-List<BoneWeight>.ToArray
	|
	|-RVA: 0x322B070 Offset: 0x322B171 VA: 0x322B070
	|-List<Color32>.ToArray
	|
	|-RVA: 0x3231CE0 Offset: 0x3231DE1 VA: 0x3231CE0
	|-List<CombineInstance>.ToArray
	|
	|-RVA: 0x33D66A0 Offset: 0x33D67A1 VA: 0x33D66A0
	|-List<AsyncOperationHandle<SceneInstance>>.ToArray
	|
	|-RVA: 0x31D4F70 Offset: 0x31D5071 VA: 0x31D4F70
	|-List<UIVertex>.ToArray
	|
	|-RVA: 0x31DB330 Offset: 0x31DB431 VA: 0x31DB330
	|-List<Vector2>.ToArray
	|
	|-RVA: 0x2CE6F70 Offset: 0x2CE7071 VA: 0x2CE6F70
	|-List<Vector3>.ToArray
	|
	|-RVA: 0x2CED0B0 Offset: 0x2CED1B1 VA: 0x2CED0B0
	|-List<Vector4>.ToArray
	|
	|-RVA: 0x2CF7110 Offset: 0x2CF7211 VA: 0x2CF7110
	|-List<stCommand_t>.ToArray
	|
	|-RVA: 0x248F320 Offset: 0x248F421 VA: 0x248F320
	|-List<AS_ToolController.ChargeInfo>.ToArray
	|
	|-RVA: 0x2493040 Offset: 0x2493141 VA: 0x2493040
	|-List<BuildItemData>.ToArray
	|
	|-RVA: 0x3158670 Offset: 0x3158771 VA: 0x3158670
	|-List<ButtonLinker.LinkObject>.ToArray
	|
	|-RVA: 0x315B680 Offset: 0x315B781 VA: 0x315B680
	|-List<CharaCallTable.BustupTable>.ToArray
	|
	|-RVA: 0x315E740 Offset: 0x315E841 VA: 0x315E740
	|-List<CharaCallTable.CharaFaceIconTable>.ToArray
	|
	|-RVA: 0x3161780 Offset: 0x3161881 VA: 0x3161780
	|-List<CameraState.CustomBlendable>.ToArray
	|
	|-RVA: 0x31676E0 Offset: 0x31677E1 VA: 0x31676E0
	|-List<CinemachineStateDrivenCamera.HashPair>.ToArray
	|
	|-RVA: 0x316ABC0 Offset: 0x316ACC1 VA: 0x316ABC0
	|-List<TargetPositionCache.CacheCurve.Item>.ToArray
	|
	|-RVA: 0x316E120 Offset: 0x316E221 VA: 0x316E120
	|-List<TargetPositionCache.CacheEntry.RecordingItem>.ToArray
	|
	|-RVA: 0x31716F0 Offset: 0x31717F1 VA: 0x31716F0
	|-List<CropDataTable>.ToArray
	|
	|-RVA: 0x31746A0 Offset: 0x31747A1 VA: 0x31746A0
	|-List<DropItemParam>.ToArray
	|
	|-RVA: 0x3177A50 Offset: 0x3177B51 VA: 0x3177A50
	|-List<ErosionBrush.UndoStep>.ToArray
	|
	|-RVA: 0x31DE6D0 Offset: 0x31DE7D1 VA: 0x31DE6D0
	|-List<EventCheckId>.ToArray
	|
	|-RVA: 0x31E1720 Offset: 0x31E1821 VA: 0x31E1720
	|-List<EventFlagProgressData>.ToArray
	|
	|-RVA: 0x31E4770 Offset: 0x31E4871 VA: 0x31E4770
	|-List<FesNpcScoreData>.ToArray
	|
	|-RVA: 0x31EE240 Offset: 0x31EE341 VA: 0x31EE240
	|-List<MoviePlayer.SUBTITLEDATA>.ToArray
	|
	|-RVA: 0x31F1900 Offset: 0x31F1A01 VA: 0x31F1900
	|-List<NPCActionData>.ToArray
	|
	|-RVA: 0x31F4CA0 Offset: 0x31F4DA1 VA: 0x31F4CA0
	|-List<NpcPlaceSchedule>.ToArray
	|
	|-RVA: 0x31F7D60 Offset: 0x31F7E61 VA: 0x31F7D60
	|-List<OrderLotterySaveParameter>.ToArray
	|
	|-RVA: 0x31FB110 Offset: 0x31FB211 VA: 0x31FB110
	|-List<OrderSaveParameter>.ToArray
	|
	|-RVA: 0x31FE160 Offset: 0x31FE261 VA: 0x31FE160
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>.ToArray
	|
	|-RVA: 0x330D3C0 Offset: 0x330D4C1 VA: 0x330D3C0
	|-List<ShopCatalogPage>.ToArray
	|
	|-RVA: 0x3310980 Offset: 0x3310A81 VA: 0x3310980
	|-List<ShopNpcTalk>.ToArray
	|
	|-RVA: 0x3313A40 Offset: 0x3313B41 VA: 0x3313A40
	|-List<SubtitleDataTable.Data>.ToArray
	|
	|-RVA: 0x3316A10 Offset: 0x3316B11 VA: 0x3316A10
	|-List<SubtitleDataTable.DataList>.ToArray
	|
	|-RVA: 0x3319AD0 Offset: 0x3319BD1 VA: 0x3319AD0
	|-List<SubtitleHudDataTable.Data>.ToArray
	|
	|-RVA: 0x331CE80 Offset: 0x331CF81 VA: 0x331CE80
	|-List<SRMonoBehaviourEx.FieldInfo>.ToArray
	|
	|-RVA: 0x33201D0 Offset: 0x33202D1 VA: 0x33201D0
	|-List<Schedule>.ToArray
	|
	|-RVA: 0x3323A80 Offset: 0x3323B81 VA: 0x3323A80
	|-List<CurveSample>.ToArray
	|
	|-RVA: 0x3326A70 Offset: 0x3326B71 VA: 0x3326A70
	|-List<bool>.ToArray
	|
	|-RVA: 0x332C9F0 Offset: 0x332CAF1 VA: 0x332C9F0
	|-List<char>.ToArray
	|
	|-RVA: 0x335AAE0 Offset: 0x335ABE1 VA: 0x335AAE0
	|-List<KeyValuePair<DateTime, object>>.ToArray
	|
	|-RVA: 0x335DB30 Offset: 0x335DC31 VA: 0x335DB30
	|-List<KeyValuePair<int, object>>.ToArray
	|
	|-RVA: 0x3360B70 Offset: 0x3360C71 VA: 0x3360B70
	|-List<KeyValuePair<object, object>>.ToArray
	|
	|-RVA: 0x3363B20 Offset: 0x3363C21 VA: 0x3363B20
	|-List<DateTime>.ToArray
	|
	|-RVA: 0x3366AD0 Offset: 0x3366BD1 VA: 0x3366AD0
	|-List<double>.ToArray
	|
	|-RVA: 0x3369A80 Offset: 0x3369B81 VA: 0x3369A80
	|-List<short>.ToArray
	|
	|-RVA: 0x336CA30 Offset: 0x336CB31 VA: 0x336CA30
	|-List<int>.ToArray
	|
	|-RVA: 0x3372990 Offset: 0x3372A91 VA: 0x3372990
	|-List<long>.ToArray
	|
	|-RVA: 0x33789D0 Offset: 0x3378AD1 VA: 0x33789D0
	|-List<Nullable<Int32Enum>>.ToArray
	|
	|-RVA: 0x3407C20 Offset: 0x3407D21 VA: 0x3407C20
	|-List<Nullable<Bounds>>.ToArray
	|
	|-RVA: 0x340B1E0 Offset: 0x340B2E1 VA: 0x340B1E0
	|-List<Nullable<BoundsInt>>.ToArray
	|
	|-RVA: 0x340E1E0 Offset: 0x340E2E1 VA: 0x340E1E0
	|-List<Nullable<Color32>>.ToArray
	|
	|-RVA: 0x3411640 Offset: 0x3411741 VA: 0x3411640
	|-List<Nullable<Color>>.ToArray
	|
	|-RVA: 0x3414760 Offset: 0x3414861 VA: 0x3414760
	|-List<Nullable<GradientAlphaKey>>.ToArray
	|
	|-RVA: 0x3417BB0 Offset: 0x3417CB1 VA: 0x3417BB0
	|-List<Nullable<GradientColorKey>>.ToArray
	|
	|-RVA: 0x341B010 Offset: 0x341B111 VA: 0x341B010
	|-List<Nullable<Keyframe>>.ToArray
	|
	|-RVA: 0x341E010 Offset: 0x341E111 VA: 0x341E010
	|-List<Nullable<LayerMask>>.ToArray
	|
	|-RVA: 0x3421A50 Offset: 0x3421B51 VA: 0x3421A50
	|-List<Nullable<Matrix4x4>>.ToArray
	|
	|-RVA: 0x3424EB0 Offset: 0x3424FB1 VA: 0x3424EB0
	|-List<Nullable<Quaternion>>.ToArray
	|
	|-RVA: 0x3264A40 Offset: 0x3264B41 VA: 0x3264A40
	|-List<Nullable<RangeInt>>.ToArray
	|
	|-RVA: 0x3267EA0 Offset: 0x3267FA1 VA: 0x3267EA0
	|-List<Nullable<Rect>>.ToArray
	|
	|-RVA: 0x326B300 Offset: 0x326B401 VA: 0x326B300
	|-List<Nullable<RectInt>>.ToArray
	|
	|-RVA: 0x326E420 Offset: 0x326E521 VA: 0x326E420
	|-List<Nullable<Vector2>>.ToArray
	|
	|-RVA: 0x3271540 Offset: 0x3271641 VA: 0x3271540
	|-List<Nullable<Vector2Int>>.ToArray
	|
	|-RVA: 0x32745B0 Offset: 0x32746B1 VA: 0x32745B0
	|-List<Nullable<Vector3>>.ToArray
	|
	|-RVA: 0x3277620 Offset: 0x3277721 VA: 0x3277620
	|-List<Nullable<Vector3Int>>.ToArray
	|
	|-RVA: 0x327AA80 Offset: 0x327AB81 VA: 0x327AA80
	|-List<Nullable<Vector4>>.ToArray
	|
	|-RVA: 0x3280980 Offset: 0x3280A81 VA: 0x3280980
	|-List<sbyte>.ToArray
	|
	|-RVA: 0x3283930 Offset: 0x3283A31 VA: 0x3283930
	|-List<float>.ToArray
	|
	|-RVA: 0x32AAB90 Offset: 0x32AAC91 VA: 0x32AAB90
	|-List<ushort>.ToArray
	|
	|-RVA: 0x32B0AF0 Offset: 0x32B0BF1 VA: 0x32B0AF0
	|-List<ulong>.ToArray
	|
	|-RVA: 0x32B3AA0 Offset: 0x32B3BA1 VA: 0x32B3AA0
	|-List<ValueTuple<bool, Int32Enum>>.ToArray
	|
	|-RVA: 0x32B6A50 Offset: 0x32B6B51 VA: 0x32B6A50
	|-List<ValueTuple<Int32Enum, int>>.ToArray
	|
	|-RVA: 0x32B9AA0 Offset: 0x32B9BA1 VA: 0x32B9AA0
	|-List<ValueTuple<Int32Enum, object>>.ToArray
	|
	|-RVA: 0x32BCAE0 Offset: 0x32BCBE1 VA: 0x32BCAE0
	|-List<ValueTuple<object, Int32Enum>>.ToArray
	|
	|-RVA: 0x32BFB20 Offset: 0x32BFC21 VA: 0x32BFB20
	|-List<ValueTuple<object, object>>.ToArray
	|
	|-RVA: 0x32C2B60 Offset: 0x32C2C61 VA: 0x32C2B60
	|-List<ValueTuple<object, float>>.ToArray
	|
	|-RVA: 0x32C5C20 Offset: 0x32C5D21 VA: 0x32C5C20
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>.ToArray
	|
	|-RVA: 0x32C9310 Offset: 0x32C9411 VA: 0x32C9310
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>.ToArray
	|
	|-RVA: 0x3112F70 Offset: 0x3113071 VA: 0x3112F70
	|-List<TexturePacker_JsonArray.Frame>.ToArray
	|
	|-RVA: 0x3116030 Offset: 0x3116131 VA: 0x3116030
	|-List<TutorialUnlockFlagData>.ToArray
	|
	|-RVA: 0x3119080 Offset: 0x3119181 VA: 0x3119080
	|-List<UIMainManagerAttachObject.AttachSet>.ToArray
	|
	|-RVA: 0x311C5E0 Offset: 0x311C6E1 VA: 0x311C5E0
	|-List<CapEdge>.ToArray
	|
	|-RVA: 0x311F590 Offset: 0x311F691 VA: 0x311F590
	|-List<MeshDataConnectivity.Face>.ToArray
	|
	|-RVA: 0x31228E0 Offset: 0x31229E1 VA: 0x31228E0
	|-List<MeshFaceConnectivity.EdgeData.SideData>.ToArray
	|
	|-RVA: 0x3125EA0 Offset: 0x3125FA1 VA: 0x3125EA0
	|-List<MeshFaceConnectivity.EdgeData>.ToArray
	|
	|-RVA: 0x312CA80 Offset: 0x312CB81 VA: 0x312CA80
	|-List<NavMeshBuildSource>.ToArray
	|
	|-RVA: 0x312FAC0 Offset: 0x312FBC1 VA: 0x312FAC0
	|-List<ConstraintSource>.ToArray
	|
	|-RVA: 0x3132A70 Offset: 0x3132B71 VA: 0x3132A70
	|-List<AnimatorClipInfo>.ToArray
	|
	|-RVA: 0x321E6A0 Offset: 0x321E7A1 VA: 0x321E6A0
	|-List<BeforeRenderHelper.OrderBlock>.ToArray
	|
	|-RVA: 0x3224D50 Offset: 0x3224E51 VA: 0x3224D50
	|-List<Bounds>.ToArray
	|
	|-RVA: 0x32280A0 Offset: 0x32281A1 VA: 0x32280A0
	|-List<BoundsInt>.ToArray
	|
	|-RVA: 0x322E0F0 Offset: 0x322E1F1 VA: 0x322E0F0
	|-List<Color>.ToArray
	|
	|-RVA: 0x32355C0 Offset: 0x32356C1 VA: 0x32355C0
	|-List<RaycastResult>.ToArray
	|
	|-RVA: 0x32385E0 Offset: 0x32386E1 VA: 0x32385E0
	|-List<GradientAlphaKey>.ToArray
	|
	|-RVA: 0x323B940 Offset: 0x323BA41 VA: 0x323B940
	|-List<GradientColorKey>.ToArray
	|
	|-RVA: 0x323EE20 Offset: 0x323EF21 VA: 0x323EE20
	|-List<Keyframe>.ToArray
	|
	|-RVA: 0x3241DF0 Offset: 0x3241EF1 VA: 0x3241DF0
	|-List<LayerMask>.ToArray
	|
	|-RVA: 0x32454A0 Offset: 0x32455A1 VA: 0x32454A0
	|-List<Matrix4x4>.ToArray
	|
	|-RVA: 0x3248960 Offset: 0x3248A61 VA: 0x3248960
	|-List<ParticleSystem.Particle>.ToArray
	|
	|-RVA: 0x324B970 Offset: 0x324BA71 VA: 0x324B970
	|-List<Playable>.ToArray
	|
	|-RVA: 0x324ED20 Offset: 0x324EE21 VA: 0x324ED20
	|-List<PlayableBinding>.ToArray
	|
	|-RVA: 0x3251D30 Offset: 0x3251E31 VA: 0x3251D30
	|-List<PlayableGraph>.ToArray
	|
	|-RVA: 0x3254CE0 Offset: 0x3254DE1 VA: 0x3254CE0
	|-List<Edge>.ToArray
	|
	|-RVA: 0x3257D60 Offset: 0x3257E61 VA: 0x3257D60
	|-List<Quaternion>.ToArray
	|
	|-RVA: 0x325AD10 Offset: 0x325AE11 VA: 0x325AD10
	|-List<RangeInt>.ToArray
	|
	|-RVA: 0x325E270 Offset: 0x325E371 VA: 0x325E270
	|-List<RaycastHit2D>.ToArray
	|
	|-RVA: 0x3261920 Offset: 0x3261A21 VA: 0x3261920
	|-List<RaycastHit>.ToArray
	|
	|-RVA: 0x33C31A0 Offset: 0x33C32A1 VA: 0x33C31A0
	|-List<Rect>.ToArray
	|
	|-RVA: 0x33C61B0 Offset: 0x33C62B1 VA: 0x33C61B0
	|-List<RectInt>.ToArray
	|
	|-RVA: 0x33C91F0 Offset: 0x33C92F1 VA: 0x33C91F0
	|-List<ReflectionProbeBlendInfo>.ToArray
	|
	|-RVA: 0x33CCF50 Offset: 0x33CD051 VA: 0x33CCF50
	|-List<SphericalHarmonicsL2>.ToArray
	|
	|-RVA: 0x33CFF60 Offset: 0x33D0061 VA: 0x33CFF60
	|-List<VertexAttributeDescriptor>.ToArray
	|
	|-RVA: 0x33D3300 Offset: 0x33D3401 VA: 0x33D3300
	|-List<AsyncOperationHandle>.ToArray
	|
	|-RVA: 0x33D9C60 Offset: 0x33D9D61 VA: 0x33D9C60
	|-List<DiagnosticEvent>.ToArray
	|
	|-RVA: 0x33DD010 Offset: 0x33DD111 VA: 0x33DD010
	|-List<DelayedActionManager.DelegateInfo>.ToArray
	|
	|-RVA: 0x33E05D0 Offset: 0x33E06D1 VA: 0x33E05D0
	|-List<ObjectInitializationData>.ToArray
	|
	|-RVA: 0x31BB530 Offset: 0x31BB631 VA: 0x31BB530
	|-List<GlyphRect>.ToArray
	|
	|-RVA: 0x31BEA10 Offset: 0x31BEB11 VA: 0x31BEA10
	|-List<AnimationOutputWeightProcessor.WeightInfo>.ToArray
	|
	|-RVA: 0x31C1D60 Offset: 0x31C1E61 VA: 0x31C1D60
	|-List<IntervalTreeNode>.ToArray
	|
	|-RVA: 0x31C5100 Offset: 0x31C5201 VA: 0x31C5100
	|-List<IntervalTree.Entry<object>>.ToArray
	|
	|-RVA: 0x31C84A0 Offset: 0x31C85A1 VA: 0x31C84A0
	|-List<TimeNotificationBehaviour.NotificationEntry>.ToArray
	|
	|-RVA: 0x31CB520 Offset: 0x31CB621 VA: 0x31CB520
	|-List<UICharInfo>.ToArray
	|
	|-RVA: 0x31CE560 Offset: 0x31CE661 VA: 0x31CE560
	|-List<FocusController.FocusedElement>.ToArray
	|
	|-RVA: 0x31D1570 Offset: 0x31D1671 VA: 0x31D1570
	|-List<UILineInfo>.ToArray
	|
	|-RVA: 0x31D8310 Offset: 0x31D8411 VA: 0x31D8310
	|-List<UnitySynchronizationContext.WorkRequest>.ToArray
	|
	|-RVA: 0x2CE3EF0 Offset: 0x2CE3FF1 VA: 0x2CE3EF0
	|-List<Vector2Int>.ToArray
	|
	|-RVA: 0x2CEA030 Offset: 0x2CEA131 VA: 0x2CEA030
	|-List<Vector3Int>.ToArray
	|
	|-RVA: 0x2CF0DC0 Offset: 0x2CF0EC1 VA: 0x2CF0DC0
	|-List<WarpPoints.WarpPoint>.ToArray
	|
	|-RVA: 0x2CF3D70 Offset: 0x2CF3E71 VA: 0x2CF3D70
	|-List<YieldItemParam>.ToArray
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x248F3A0 Offset: 0x248F4A1 VA: 0x248F3A0
	|-List<AS_ToolController.ChargeInfo>..cctor
	|
	|-RVA: 0x24930C0 Offset: 0x24931C1 VA: 0x24930C0
	|-List<BuildItemData>..cctor
	|
	|-RVA: 0x31586F0 Offset: 0x31587F1 VA: 0x31586F0
	|-List<ButtonLinker.LinkObject>..cctor
	|
	|-RVA: 0x315B700 Offset: 0x315B801 VA: 0x315B700
	|-List<CharaCallTable.BustupTable>..cctor
	|
	|-RVA: 0x315E7C0 Offset: 0x315E8C1 VA: 0x315E7C0
	|-List<CharaCallTable.CharaFaceIconTable>..cctor
	|
	|-RVA: 0x3161800 Offset: 0x3161901 VA: 0x3161800
	|-List<CameraState.CustomBlendable>..cctor
	|
	|-RVA: 0x31647B0 Offset: 0x31648B1 VA: 0x31647B0
	|-List<CinemachineClearShot.Pair>..cctor
	|
	|-RVA: 0x3167760 Offset: 0x3167861 VA: 0x3167760
	|-List<CinemachineStateDrivenCamera.HashPair>..cctor
	|
	|-RVA: 0x316AC40 Offset: 0x316AD41 VA: 0x316AC40
	|-List<TargetPositionCache.CacheCurve.Item>..cctor
	|
	|-RVA: 0x316E1A0 Offset: 0x316E2A1 VA: 0x316E1A0
	|-List<TargetPositionCache.CacheEntry.RecordingItem>..cctor
	|
	|-RVA: 0x3171770 Offset: 0x3171871 VA: 0x3171770
	|-List<CropDataTable>..cctor
	|
	|-RVA: 0x3174720 Offset: 0x3174821 VA: 0x3174720
	|-List<DropItemParam>..cctor
	|
	|-RVA: 0x3177AD0 Offset: 0x3177BD1 VA: 0x3177AD0
	|-List<ErosionBrush.UndoStep>..cctor
	|
	|-RVA: 0x31DE750 Offset: 0x31DE851 VA: 0x31DE750
	|-List<EventCheckId>..cctor
	|
	|-RVA: 0x31E17A0 Offset: 0x31E18A1 VA: 0x31E17A0
	|-List<EventFlagProgressData>..cctor
	|
	|-RVA: 0x31E47F0 Offset: 0x31E48F1 VA: 0x31E47F0
	|-List<FesNpcScoreData>..cctor
	|
	|-RVA: 0x31E7D50 Offset: 0x31E7E51 VA: 0x31E7D50
	|-List<MiningPointSaveData>..cctor
	|
	|-RVA: 0x31EB270 Offset: 0x31EB371 VA: 0x31EB270
	|-List<MonsterHutSaveData>..cctor
	|
	|-RVA: 0x31EE2C0 Offset: 0x31EE3C1 VA: 0x31EE2C0
	|-List<MoviePlayer.SUBTITLEDATA>..cctor
	|
	|-RVA: 0x31F1980 Offset: 0x31F1A81 VA: 0x31F1980
	|-List<NPCActionData>..cctor
	|
	|-RVA: 0x31F4D20 Offset: 0x31F4E21 VA: 0x31F4D20
	|-List<NpcPlaceSchedule>..cctor
	|
	|-RVA: 0x31F7DE0 Offset: 0x31F7EE1 VA: 0x31F7DE0
	|-List<OrderLotterySaveParameter>..cctor
	|
	|-RVA: 0x31FB190 Offset: 0x31FB291 VA: 0x31FB190
	|-List<OrderSaveParameter>..cctor
	|
	|-RVA: 0x31FE1E0 Offset: 0x31FE2E1 VA: 0x31FE1E0
	|-List<PackedPlayModeBuildLogs.RuntimeBuildLog>..cctor
	|
	|-RVA: 0x330D440 Offset: 0x330D541 VA: 0x330D440
	|-List<ShopCatalogPage>..cctor
	|
	|-RVA: 0x3310A00 Offset: 0x3310B01 VA: 0x3310A00
	|-List<ShopNpcTalk>..cctor
	|
	|-RVA: 0x3313AC0 Offset: 0x3313BC1 VA: 0x3313AC0
	|-List<SubtitleDataTable.Data>..cctor
	|
	|-RVA: 0x3316A90 Offset: 0x3316B91 VA: 0x3316A90
	|-List<SubtitleDataTable.DataList>..cctor
	|
	|-RVA: 0x3319B50 Offset: 0x3319C51 VA: 0x3319B50
	|-List<SubtitleHudDataTable.Data>..cctor
	|
	|-RVA: 0x331CF00 Offset: 0x331D001 VA: 0x331CF00
	|-List<SRMonoBehaviourEx.FieldInfo>..cctor
	|
	|-RVA: 0x3320250 Offset: 0x3320351 VA: 0x3320250
	|-List<Schedule>..cctor
	|
	|-RVA: 0x3323B00 Offset: 0x3323C01 VA: 0x3323B00
	|-List<CurveSample>..cctor
	|
	|-RVA: 0x3326AF0 Offset: 0x3326BF1 VA: 0x3326AF0
	|-List<bool>..cctor
	|
	|-RVA: 0x3329AC0 Offset: 0x3329BC1 VA: 0x3329AC0
	|-List<byte>..cctor
	|
	|-RVA: 0x332CA70 Offset: 0x332CB71 VA: 0x332CA70
	|-List<char>..cctor
	|
	|-RVA: 0x335AB60 Offset: 0x335AC61 VA: 0x335AB60
	|-List<KeyValuePair<DateTime, object>>..cctor
	|
	|-RVA: 0x335DBB0 Offset: 0x335DCB1 VA: 0x335DBB0
	|-List<KeyValuePair<int, object>>..cctor
	|
	|-RVA: 0x3360BF0 Offset: 0x3360CF1 VA: 0x3360BF0
	|-List<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x3363BA0 Offset: 0x3363CA1 VA: 0x3363BA0
	|-List<DateTime>..cctor
	|
	|-RVA: 0x3366B50 Offset: 0x3366C51 VA: 0x3366B50
	|-List<double>..cctor
	|
	|-RVA: 0x3369B00 Offset: 0x3369C01 VA: 0x3369B00
	|-List<short>..cctor
	|
	|-RVA: 0x336CAB0 Offset: 0x336CBB1 VA: 0x336CAB0
	|-List<int>..cctor
	|
	|-RVA: 0x336FA60 Offset: 0x336FB61 VA: 0x336FA60
	|-List<Int32Enum>..cctor
	|
	|-RVA: 0x3372A10 Offset: 0x3372B11 VA: 0x3372A10
	|-List<long>..cctor
	|
	|-RVA: 0x3375A50 Offset: 0x3375B51 VA: 0x3375A50
	|-List<InterpretedFrameInfo>..cctor
	|
	|-RVA: 0x3378A50 Offset: 0x3378B51 VA: 0x3378A50
	|-List<Nullable<Int32Enum>>..cctor
	|
	|-RVA: 0x3407CA0 Offset: 0x3407DA1 VA: 0x3407CA0
	|-List<Nullable<Bounds>>..cctor
	|
	|-RVA: 0x340B260 Offset: 0x340B361 VA: 0x340B260
	|-List<Nullable<BoundsInt>>..cctor
	|
	|-RVA: 0x340E260 Offset: 0x340E361 VA: 0x340E260
	|-List<Nullable<Color32>>..cctor
	|
	|-RVA: 0x34116C0 Offset: 0x34117C1 VA: 0x34116C0
	|-List<Nullable<Color>>..cctor
	|
	|-RVA: 0x34147E0 Offset: 0x34148E1 VA: 0x34147E0
	|-List<Nullable<GradientAlphaKey>>..cctor
	|
	|-RVA: 0x3417C30 Offset: 0x3417D31 VA: 0x3417C30
	|-List<Nullable<GradientColorKey>>..cctor
	|
	|-RVA: 0x341B090 Offset: 0x341B191 VA: 0x341B090
	|-List<Nullable<Keyframe>>..cctor
	|
	|-RVA: 0x341E090 Offset: 0x341E191 VA: 0x341E090
	|-List<Nullable<LayerMask>>..cctor
	|
	|-RVA: 0x3421AD0 Offset: 0x3421BD1 VA: 0x3421AD0
	|-List<Nullable<Matrix4x4>>..cctor
	|
	|-RVA: 0x3424F30 Offset: 0x3425031 VA: 0x3424F30
	|-List<Nullable<Quaternion>>..cctor
	|
	|-RVA: 0x3264AC0 Offset: 0x3264BC1 VA: 0x3264AC0
	|-List<Nullable<RangeInt>>..cctor
	|
	|-RVA: 0x3267F20 Offset: 0x3268021 VA: 0x3267F20
	|-List<Nullable<Rect>>..cctor
	|
	|-RVA: 0x326B380 Offset: 0x326B481 VA: 0x326B380
	|-List<Nullable<RectInt>>..cctor
	|
	|-RVA: 0x326E4A0 Offset: 0x326E5A1 VA: 0x326E4A0
	|-List<Nullable<Vector2>>..cctor
	|
	|-RVA: 0x32715C0 Offset: 0x32716C1 VA: 0x32715C0
	|-List<Nullable<Vector2Int>>..cctor
	|
	|-RVA: 0x3274630 Offset: 0x3274731 VA: 0x3274630
	|-List<Nullable<Vector3>>..cctor
	|
	|-RVA: 0x32776A0 Offset: 0x32777A1 VA: 0x32776A0
	|-List<Nullable<Vector3Int>>..cctor
	|
	|-RVA: 0x327AB00 Offset: 0x327AC01 VA: 0x327AB00
	|-List<Nullable<Vector4>>..cctor
	|
	|-RVA: 0x327DA30 Offset: 0x327DB31 VA: 0x327DA30
	|-List<object>..cctor
	|
	|-RVA: 0x3280A00 Offset: 0x3280B01 VA: 0x3280A00
	|-List<sbyte>..cctor
	|
	|-RVA: 0x32839B0 Offset: 0x3283AB1 VA: 0x32839B0
	|-List<float>..cctor
	|
	|-RVA: 0x32AAC10 Offset: 0x32AAD11 VA: 0x32AAC10
	|-List<ushort>..cctor
	|
	|-RVA: 0x32ADBC0 Offset: 0x32ADCC1 VA: 0x32ADBC0
	|-List<uint>..cctor
	|
	|-RVA: 0x32B0B70 Offset: 0x32B0C71 VA: 0x32B0B70
	|-List<ulong>..cctor
	|
	|-RVA: 0x32B3B20 Offset: 0x32B3C21 VA: 0x32B3B20
	|-List<ValueTuple<bool, Int32Enum>>..cctor
	|
	|-RVA: 0x32B6AD0 Offset: 0x32B6BD1 VA: 0x32B6AD0
	|-List<ValueTuple<Int32Enum, int>>..cctor
	|
	|-RVA: 0x32B9B20 Offset: 0x32B9C21 VA: 0x32B9B20
	|-List<ValueTuple<Int32Enum, object>>..cctor
	|
	|-RVA: 0x32BCB60 Offset: 0x32BCC61 VA: 0x32BCB60
	|-List<ValueTuple<object, Int32Enum>>..cctor
	|
	|-RVA: 0x32BFBA0 Offset: 0x32BFCA1 VA: 0x32BFBA0
	|-List<ValueTuple<object, object>>..cctor
	|
	|-RVA: 0x32C2BE0 Offset: 0x32C2CE1 VA: 0x32C2BE0
	|-List<ValueTuple<object, float>>..cctor
	|
	|-RVA: 0x32C5CA0 Offset: 0x32C5DA1 VA: 0x32C5CA0
	|-List<ValueTuple<Int32Enum, Int32Enum, Int32Enum>>..cctor
	|
	|-RVA: 0x32C9390 Offset: 0x32C9491 VA: 0x32C9390
	|-List<ValueTuple<int, object, Vector3, Quaternion, object, object>>..cctor
	|
	|-RVA: 0x3112FF0 Offset: 0x31130F1 VA: 0x3112FF0
	|-List<TexturePacker_JsonArray.Frame>..cctor
	|
	|-RVA: 0x31160B0 Offset: 0x31161B1 VA: 0x31160B0
	|-List<TutorialUnlockFlagData>..cctor
	|
	|-RVA: 0x3119100 Offset: 0x3119201 VA: 0x3119100
	|-List<UIMainManagerAttachObject.AttachSet>..cctor
	|
	|-RVA: 0x311C660 Offset: 0x311C761 VA: 0x311C660
	|-List<CapEdge>..cctor
	|
	|-RVA: 0x311F610 Offset: 0x311F711 VA: 0x311F610
	|-List<MeshDataConnectivity.Face>..cctor
	|
	|-RVA: 0x3122960 Offset: 0x3122A61 VA: 0x3122960
	|-List<MeshFaceConnectivity.EdgeData.SideData>..cctor
	|
	|-RVA: 0x3125F20 Offset: 0x3126021 VA: 0x3125F20
	|-List<MeshFaceConnectivity.EdgeData>..cctor
	|
	|-RVA: 0x3128F30 Offset: 0x3129031 VA: 0x3128F30
	|-List<NavMeshBuildMarkup>..cctor
	|
	|-RVA: 0x312CB00 Offset: 0x312CC01 VA: 0x312CB00
	|-List<NavMeshBuildSource>..cctor
	|
	|-RVA: 0x312FB40 Offset: 0x312FC41 VA: 0x312FB40
	|-List<ConstraintSource>..cctor
	|
	|-RVA: 0x3132AF0 Offset: 0x3132BF1 VA: 0x3132AF0
	|-List<AnimatorClipInfo>..cctor
	|
	|-RVA: 0x321E720 Offset: 0x321E821 VA: 0x321E720
	|-List<BeforeRenderHelper.OrderBlock>..cctor
	|
	|-RVA: 0x3221A80 Offset: 0x3221B81 VA: 0x3221A80
	|-List<BoneWeight>..cctor
	|
	|-RVA: 0x3224DD0 Offset: 0x3224ED1 VA: 0x3224DD0
	|-List<Bounds>..cctor
	|
	|-RVA: 0x3228120 Offset: 0x3228221 VA: 0x3228120
	|-List<BoundsInt>..cctor
	|
	|-RVA: 0x322B0F0 Offset: 0x322B1F1 VA: 0x322B0F0
	|-List<Color32>..cctor
	|
	|-RVA: 0x322E170 Offset: 0x322E271 VA: 0x322E170
	|-List<Color>..cctor
	|
	|-RVA: 0x3231D60 Offset: 0x3231E61 VA: 0x3231D60
	|-List<CombineInstance>..cctor
	|
	|-RVA: 0x3235640 Offset: 0x3235741 VA: 0x3235640
	|-List<RaycastResult>..cctor
	|
	|-RVA: 0x3238660 Offset: 0x3238761 VA: 0x3238660
	|-List<GradientAlphaKey>..cctor
	|
	|-RVA: 0x323B9C0 Offset: 0x323BAC1 VA: 0x323B9C0
	|-List<GradientColorKey>..cctor
	|
	|-RVA: 0x323EEA0 Offset: 0x323EFA1 VA: 0x323EEA0
	|-List<Keyframe>..cctor
	|
	|-RVA: 0x3241E70 Offset: 0x3241F71 VA: 0x3241E70
	|-List<LayerMask>..cctor
	|
	|-RVA: 0x3245520 Offset: 0x3245621 VA: 0x3245520
	|-List<Matrix4x4>..cctor
	|
	|-RVA: 0x32489E0 Offset: 0x3248AE1 VA: 0x32489E0
	|-List<ParticleSystem.Particle>..cctor
	|
	|-RVA: 0x324B9F0 Offset: 0x324BAF1 VA: 0x324B9F0
	|-List<Playable>..cctor
	|
	|-RVA: 0x324EDA0 Offset: 0x324EEA1 VA: 0x324EDA0
	|-List<PlayableBinding>..cctor
	|
	|-RVA: 0x3251DB0 Offset: 0x3251EB1 VA: 0x3251DB0
	|-List<PlayableGraph>..cctor
	|
	|-RVA: 0x3254D60 Offset: 0x3254E61 VA: 0x3254D60
	|-List<Edge>..cctor
	|
	|-RVA: 0x3257DE0 Offset: 0x3257EE1 VA: 0x3257DE0
	|-List<Quaternion>..cctor
	|
	|-RVA: 0x325AD90 Offset: 0x325AE91 VA: 0x325AD90
	|-List<RangeInt>..cctor
	|
	|-RVA: 0x325E2F0 Offset: 0x325E3F1 VA: 0x325E2F0
	|-List<RaycastHit2D>..cctor
	|
	|-RVA: 0x32619A0 Offset: 0x3261AA1 VA: 0x32619A0
	|-List<RaycastHit>..cctor
	|
	|-RVA: 0x33C3220 Offset: 0x33C3321 VA: 0x33C3220
	|-List<Rect>..cctor
	|
	|-RVA: 0x33C6230 Offset: 0x33C6331 VA: 0x33C6230
	|-List<RectInt>..cctor
	|
	|-RVA: 0x33C9270 Offset: 0x33C9371 VA: 0x33C9270
	|-List<ReflectionProbeBlendInfo>..cctor
	|
	|-RVA: 0x33CCFD0 Offset: 0x33CD0D1 VA: 0x33CCFD0
	|-List<SphericalHarmonicsL2>..cctor
	|
	|-RVA: 0x33CFFE0 Offset: 0x33D00E1 VA: 0x33CFFE0
	|-List<VertexAttributeDescriptor>..cctor
	|
	|-RVA: 0x33D3380 Offset: 0x33D3481 VA: 0x33D3380
	|-List<AsyncOperationHandle>..cctor
	|
	|-RVA: 0x33D6720 Offset: 0x33D6821 VA: 0x33D6720
	|-List<AsyncOperationHandle<SceneInstance>>..cctor
	|
	|-RVA: 0x33D9CE0 Offset: 0x33D9DE1 VA: 0x33D9CE0
	|-List<DiagnosticEvent>..cctor
	|
	|-RVA: 0x33DD090 Offset: 0x33DD191 VA: 0x33DD090
	|-List<DelayedActionManager.DelegateInfo>..cctor
	|
	|-RVA: 0x33E0650 Offset: 0x33E0751 VA: 0x33E0650
	|-List<ObjectInitializationData>..cctor
	|
	|-RVA: 0x31BB5B0 Offset: 0x31BB6B1 VA: 0x31BB5B0
	|-List<GlyphRect>..cctor
	|
	|-RVA: 0x31BEA90 Offset: 0x31BEB91 VA: 0x31BEA90
	|-List<AnimationOutputWeightProcessor.WeightInfo>..cctor
	|
	|-RVA: 0x31C1DE0 Offset: 0x31C1EE1 VA: 0x31C1DE0
	|-List<IntervalTreeNode>..cctor
	|
	|-RVA: 0x31C5180 Offset: 0x31C5281 VA: 0x31C5180
	|-List<IntervalTree.Entry<object>>..cctor
	|
	|-RVA: 0x31C8520 Offset: 0x31C8621 VA: 0x31C8520
	|-List<TimeNotificationBehaviour.NotificationEntry>..cctor
	|
	|-RVA: 0x31CB5A0 Offset: 0x31CB6A1 VA: 0x31CB5A0
	|-List<UICharInfo>..cctor
	|
	|-RVA: 0x31CE5E0 Offset: 0x31CE6E1 VA: 0x31CE5E0
	|-List<FocusController.FocusedElement>..cctor
	|
	|-RVA: 0x31D15F0 Offset: 0x31D16F1 VA: 0x31D15F0
	|-List<UILineInfo>..cctor
	|
	|-RVA: 0x31D4FF0 Offset: 0x31D50F1 VA: 0x31D4FF0
	|-List<UIVertex>..cctor
	|
	|-RVA: 0x31D8390 Offset: 0x31D8491 VA: 0x31D8390
	|-List<UnitySynchronizationContext.WorkRequest>..cctor
	|
	|-RVA: 0x31DB3B0 Offset: 0x31DB4B1 VA: 0x31DB3B0
	|-List<Vector2>..cctor
	|
	|-RVA: 0x2CE3F70 Offset: 0x2CE4071 VA: 0x2CE3F70
	|-List<Vector2Int>..cctor
	|
	|-RVA: 0x2CE6FF0 Offset: 0x2CE70F1 VA: 0x2CE6FF0
	|-List<Vector3>..cctor
	|
	|-RVA: 0x2CEA0B0 Offset: 0x2CEA1B1 VA: 0x2CEA0B0
	|-List<Vector3Int>..cctor
	|
	|-RVA: 0x2CED130 Offset: 0x2CED231 VA: 0x2CED130
	|-List<Vector4>..cctor
	|
	|-RVA: 0x2CF0E40 Offset: 0x2CF0F41 VA: 0x2CF0E40
	|-List<WarpPoints.WarpPoint>..cctor
	|
	|-RVA: 0x2CF3DF0 Offset: 0x2CF3EF1 VA: 0x2CF3DF0
	|-List<YieldItemParam>..cctor
	|
	|-RVA: 0x2CF7190 Offset: 0x2CF7291 VA: 0x2CF7190
	|-List<stCommand_t>..cctor
	*/
}

