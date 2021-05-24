[DebuggerDisplayAttribute] // RVA: 0xB3810 Offset: 0xB3911 VA: 0xB3810
[DefaultMemberAttribute] // RVA: 0xB3810 Offset: 0xB3911 VA: 0xB3810
[DebuggerTypeProxyAttribute] // RVA: 0xB3810 Offset: 0xB3911 VA: 0xB3810
[Serializable]
public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback // TypeDefIndex: 1422
{
	// Fields
	private int[] buckets; // 0x0
	private Dictionary.Entry<TKey, TValue>[] entries; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private int freeList; // 0x0
	private int freeCount; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary.KeyCollection<TKey, TValue> keys; // 0x0
	private Dictionary.ValueCollection<TKey, TValue> values; // 0x0
	private object _syncRoot; // 0x0
	private const string VersionName = "Version";
	private const string HashSizeName = "HashSize";
	private const string KeyValuePairsName = "KeyValuePairs";
	private const string ComparerName = "Comparer";

	// Properties
	public int Count { get; }
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	public TValue Item { get; set; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E2CE60 Offset: 0x2E2CF61 VA: 0x2E2CE60
	|-Dictionary<BaffamoID, BaffamoFestivalData>..ctor
	|-Dictionary<BeanID, BeanData>..ctor
	|-Dictionary<ActorID, ActorData>..ctor
	|-Dictionary<ActorID, LifeCycleScriptPlayer>..ctor
	|-Dictionary<ActorID, HumanStatusData>..ctor
	|-Dictionary<ActorID, ItemStorageData>..ctor
	|-Dictionary<ActorID, NpcStatusData>..ctor
	|-Dictionary<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>..ctor
	|-Dictionary<ActorID, List<MonsterDataID>>..ctor
	|-Dictionary<ActorID, SphereCollider>..ctor
	|-Dictionary<AttackAttribute, ParticleSystem>..ctor
	|-Dictionary<BadStatus, BadStatusEffectController.ObjInfo>..ctor
	|-Dictionary<CharID, HumanDataArray>..ctor
	|-Dictionary<FocusObjectType, FocusObjectName.BorderElement>..ctor
	|-Dictionary<FocusObjectType, Func<FocusInterface, Color>>..ctor
	|-Dictionary<Gender, List<SoundID>>..ctor
	|-Dictionary<HairType, Dictionary<VariationNo, HumanData>>..ctor
	|-Dictionary<ToolChargeLevel, ParticleSystem>..ctor
	|-Dictionary<VariationNo, HumanData>..ctor
	|-Dictionary<WantedFieldType, WantedField>..ctor
	|-Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>>..ctor
	|-Dictionary<EquipSlotType, AS_ToolController.ToolActionData>..ctor
	|-Dictionary<EquipSlotType, HumanEquipItem>..ctor
	|-Dictionary<FaceType, string>..ctor
	|-Dictionary<FarmAction, SkillActionID[]>..ctor
	|-Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>..ctor
	|-Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox>..ctor
	|-Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>>..ctor
	|-Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox>..ctor
	|-Dictionary<FieldWoodBoxSpawnID, GameObject>..ctor
	|-Dictionary<FoodID, GluttonFood>..ctor
	|-Dictionary<GateDataID, GateController>..ctor
	|-Dictionary<GimmickLayoutID, HashSet<GimmickBase>>..ctor
	|-Dictionary<HumanMagicMotionType, HumanMagicMotionController.HumanMagicMotion>..ctor
	|-Dictionary<ItemID, ItemPoolData>..ctor
	|-Dictionary<Master, BossDataAssetBase>..ctor
	|-Dictionary<Master, MonsterActionCodeDataTableArray>..ctor
	|-Dictionary<Texture, Texture>..ctor
	|-Dictionary<MonsterActionBehaviorDataID, List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>>..ctor
	|-Dictionary<MonsterDoctor.EvaluationType, string>..ctor
	|-Dictionary<MonsterModelDataID, MonsterModelData>..ctor
	|-Dictionary<NPCActionBehaviorDataID, List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>>..ctor
	|-Dictionary<SnowmanObjectID, MocomocoData>..ctor
	|-Dictionary<SnowmanObjectID, SnowballData>..ctor
	|-Dictionary<SoundID, EnvironmentSoundDataTable>..ctor
	|-Dictionary<SoundID, EnvironmentSoundController>..ctor
	|-Dictionary<SoundID, AudioClip>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|-Dictionary<SystemLanguage, string>..ctor
	|
	|-RVA: 0x2FEC070 Offset: 0x2FEC171 VA: 0x2FEC070
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>..ctor
	|-Dictionary<SharedVariable, object>..ctor
	|-Dictionary<Task, Dictionary<string, object>>..ctor
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>..ctor
	|-Dictionary<ICinemachineCamera, object>..ctor
	|-Dictionary<ObjectSerializationInfo.EmittableMember, FieldInfo>..ctor
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>..ctor
	|-Dictionary<OptionDefinition, OptionsControlBase>..ctor
	|-Dictionary<Action, LinkedListNode<Action>>..ctor
	|-Dictionary<byte[], Encoding>..ctor
	|-Dictionary<ParameterExpression, LocalVariable>..ctor
	|-Dictionary<object, BehaviorManager.ThirdPartyTask>..ctor
	|-Dictionary<object, ICollection<OptionDefinition>>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<FieldInfo, Dictionary<Type, bool>>..ctor
	|-Dictionary<FieldInfo, Instruction>..ctor
	|-Dictionary<string, ActionCode>..ctor
	|-Dictionary<string, IKeyframeGroup>..ctor
	|-Dictionary<string, ProfileFeatureDefinition>..ctor
	|-Dictionary<string, ProfileGroupDefinition>..ctor
	|-Dictionary<string, Texture[]>..ctor
	|-Dictionary<string, ObjectSerializationInfo.EmittableMember>..ctor
	|-Dictionary<string, PadBindData>..ctor
	|-Dictionary<string, InfoBlock>..ctor
	|-Dictionary<string, Dictionary<string, object>>..ctor
	|-Dictionary<string, IList<InfoEntry>>..ctor
	|-Dictionary<string, List<TaskCoroutine>>..ctor
	|-Dictionary<string, List<OptionDefinition>>..ctor
	|-Dictionary<string, List<GameObject>>..ctor
	|-Dictionary<string, Delegate>..ctor
	|-Dictionary<string, Func<bool>>..ctor
	|-Dictionary<string, CultureInfo>..ctor
	|-Dictionary<string, LocalDataStoreSlot>..ctor
	|-Dictionary<string, WebConnectionGroup>..ctor
	|-Dictionary<string, object>..ctor
	|-Dictionary<string, ResourceSet>..ctor
	|-Dictionary<string, string>..ctor
	|-Dictionary<string, Tuple<Guid, string>>..ctor
	|-Dictionary<string, Type>..ctor
	|-Dictionary<string, TeleportPositionDataObject>..ctor
	|-Dictionary<string, ResourceLocationData>..ctor
	|-Dictionary<string, GameObject>..ctor
	|-Dictionary<string, Material>..ctor
	|-Dictionary<string, ResourceLocationBase>..ctor
	|-Dictionary<string, Sprite>..ctor
	|-Dictionary<string, Transform>..ctor
	|-Dictionary<Thread, StackTrace>..ctor
	|-Dictionary<Type, IMessagePackFormatter>..ctor
	|-Dictionary<Type, AttributeUsageAttribute>..ctor
	|-Dictionary<Type, Dictionary<string, Delegate>>..ctor
	|-Dictionary<Type, IList<SRMonoBehaviourEx.FieldInfo>>..ctor
	|-Dictionary<Type, object>..ctor
	|-Dictionary<Type, FieldInfo[]>..ctor
	|-Dictionary<Type, TypeInformation>..ctor
	|-Dictionary<Type, Type>..ctor
	|-Dictionary<Type, TrackBindingTypeAttribute>..ctor
	|-Dictionary<TimeParamTable, HashSet<MaterialChangeTime>>..ctor
	|-Dictionary<TimeParamTable, HashSet<ObjectChangeTime>>..ctor
	|-Dictionary<TimeParamTable, HashSet<RendererChangeTime>>..ctor
	|-Dictionary<TimeParamTable, HashSet<Material>>..ctor
	|-Dictionary<MeshUniqueVertices.UniqueVertex, MeshUniqueVertices.RepeatedVertexList>..ctor
	|-Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>..ctor
	|-Dictionary<Camera, Camera>..ctor
	|-Dictionary<Canvas, IndexedSet<Graphic>>..ctor
	|-Dictionary<Collider, CharacterBase>..ctor
	|-Dictionary<Collider, CharacterNearCullingController>..ctor
	|-Dictionary<Font, HashSet<Text>>..ctor
	|-Dictionary<GameObject, Material[]>..ctor
	|-Dictionary<GameObject, Renderer[]>..ctor
	|-Dictionary<GameObject, Transform>..ctor
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>..ctor
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>..ctor
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>..ctor
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>..ctor
	|-Dictionary<Transform, List<SpringBone>>..ctor
	|
	|-RVA: 0x2A16150 Offset: 0x2A16251 VA: 0x2A16150
	|-Dictionary<JSONDeserialization.TaskField, List<int>>..ctor
	|-Dictionary<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x2A197E0 Offset: 0x2A198E1 VA: 0x2A197E0
	|-Dictionary<BitVector32Int, object>..ctor
	|
	|-RVA: 0x2DC4F00 Offset: 0x2DC5001 VA: 0x2DC4F00
	|-Dictionary<Character, float>..ctor
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x2DF9320 Offset: 0x2DF9421 VA: 0x2DF9320
	|-Dictionary<CinemachineVirtualCameraBase, int>..ctor
	|-Dictionary<MonsterControllerBase, int>..ctor
	|-Dictionary<OnGroundItem, int>..ctor
	|-Dictionary<ParameterExpression, int>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<string, int>..ctor
	|-Dictionary<Type, int>..ctor
	|-Dictionary<Camera, int>..ctor
	|-Dictionary<GameObject, int>..ctor
	|-Dictionary<Graphic, int>..ctor
	|-Dictionary<ICanvasElement, int>..ctor
	|-Dictionary<IClipper, int>..ctor
	|
	|-RVA: 0x2E298A0 Offset: 0x2E299A1 VA: 0x2E298A0
	|-Dictionary<ActorID, CharID>..ctor
	|-Dictionary<ActorID, Master>..ctor
	|-Dictionary<ActorID, RF5SystemData.FLAG>..ctor
	|-Dictionary<AttackAttribute, EffectID>..ctor
	|-Dictionary<BadStatus, Prefab>..ctor
	|-Dictionary<EmotionType, Prefab>..ctor
	|-Dictionary<FieldPlaceId, Place>..ctor
	|-Dictionary<GameFlagData, NPCID>..ctor
	|-Dictionary<MakingID, CalendarDataTable.FestivalId>..ctor
	|-Dictionary<Place, FieldPlaceId>..ctor
	|-Dictionary<Season, Texture>..ctor
	|-Dictionary<DualWorkType, Prefab>..ctor
	|-Dictionary<FestivalType, Event>..ctor
	|-Dictionary<GateEnemyModelContainer.GateType, EffectID>..ctor
	|-Dictionary<ItemID, SkillID>..ctor
	|-Dictionary<ItemID, ItemID>..ctor
	|-Dictionary<ItemType, EquipPointType>..ctor
	|-Dictionary<AKey, Key>..ctor
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|-Dictionary<TitleCanvasControl.TitleCallID, RF5SystemData.FLAG>..ctor
	|-Dictionary<RuntimePlatform, AddressablesPlatform>..ctor
	|
	|-RVA: 0x2E262E0 Offset: 0x2E263E1 VA: 0x2E262E0
	|-Dictionary<ActorID, int>..ctor
	|-Dictionary<ButtonGuideId, int>..ctor
	|-Dictionary<UseCameraType, int>..ctor
	|-Dictionary<Weather, int>..ctor
	|-Dictionary<ItemID, int>..ctor
	|-Dictionary<RF5SystemData.FLAG, int>..ctor
	|-Dictionary<Int32Enum, int>..ctor
	|-Dictionary<UIMainManager.AttachId, int>..ctor
	|
	|-RVA: 0x2E30480 Offset: 0x2E30581 VA: 0x2E30480
	|-Dictionary<ActorID, float>..ctor
	|-Dictionary<AttackAttribute, float>..ctor
	|-Dictionary<CharID, float>..ctor
	|-Dictionary<EmotionType, float>..ctor
	|-Dictionary<PartnerMovementOrderType, float>..ctor
	|-Dictionary<Int32Enum, float>..ctor
	|
	|-RVA: 0x2F74A20 Offset: 0x2F74B21 VA: 0x2F74A20
	|-Dictionary<MonsterFootStepEventDataID, MonsterFootStepEventDataTable>..ctor
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2F95C30 Offset: 0x2F95D31 VA: 0x2F95C30
	|-Dictionary<TutorialScriptType, TutorialUnlockFlagData>..ctor
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2F78540 Offset: 0x2F78641 VA: 0x2F78540
	|-Dictionary<EventCheckId, object>..ctor
	|
	|-RVA: 0x2F7C070 Offset: 0x2F7C171 VA: 0x2F7C070
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x2F80140 Offset: 0x2F80241 VA: 0x2F80140
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x2F83C70 Offset: 0x2F83D71 VA: 0x2F83C70
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x2F87380 Offset: 0x2F87481 VA: 0x2F87380
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x2E22C60 Offset: 0x2E22D61 VA: 0x2E22C60
	|-Dictionary<FieldSceneId, KeyValuePair<FarmManager.FARM_ID, int>>..ctor
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2E1BF60 Offset: 0x2E1C061 VA: 0x2E1BF60
	|-Dictionary<ItemCategory, PartnerNPCWeaponBehaviorDataTable>..ctor
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2E1F680 Offset: 0x2E1F781 VA: 0x2E1F680
	|-Dictionary<ItemType, bool>..ctor
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2E37110 Offset: 0x2E37211 VA: 0x2E37110
	|-Dictionary<MixerVolumeGroup, ValueTuple<float, float>>..ctor
	|-Dictionary<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2F70D70 Offset: 0x2F70E71 VA: 0x2F70D70
	|-Dictionary<MonsterDataID, MonsterDataTable>..ctor
	|-Dictionary<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2F8AA00 Offset: 0x2F8AB01 VA: 0x2F8AA00
	|-Dictionary<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2F8E790 Offset: 0x2F8E891 VA: 0x2F8E790
	|-Dictionary<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2F91EA0 Offset: 0x2F91FA1 VA: 0x2F91EA0
	|-Dictionary<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2D7FFB0 Offset: 0x2D800B1 VA: 0x2D7FFB0
	|-Dictionary<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2D83B10 Offset: 0x2D83C11 VA: 0x2D83B10
	|-Dictionary<Parameter, object>..ctor
	|
	|-RVA: 0x2E33A40 Offset: 0x2E33B41 VA: 0x2E33A40
	|-Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>..ctor
	|-Dictionary<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2D87880 Offset: 0x2D87981 VA: 0x2D87880
	|-Dictionary<bool, object>..ctor
	|
	|-RVA: 0x2D8AF00 Offset: 0x2D8B001 VA: 0x2D8AF00
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x2D8E520 Offset: 0x2D8E621 VA: 0x2D8E520
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x2D91B40 Offset: 0x2D91C41 VA: 0x2D91B40
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x2D95160 Offset: 0x2D95261 VA: 0x2D95160
	|-Dictionary<double, object>..ctor
	|
	|-RVA: 0x2DD29F0 Offset: 0x2DD2AF1 VA: 0x2DD29F0
	|-Dictionary<Enum, TransitionTables>..ctor
	|-Dictionary<object, TransitionTables>..ctor
	|
	|-RVA: 0x2D98770 Offset: 0x2D98871 VA: 0x2D98770
	|-Dictionary<Guid, MonoTlsProvider>..ctor
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x2D9BDF0 Offset: 0x2D9BEF1 VA: 0x2D9BDF0
	|-Dictionary<short, object>..ctor
	|
	|-RVA: 0x2F5F790 Offset: 0x2F5F891 VA: 0x2F5F790
	|-Dictionary<int, ActorUtility.ActorCreateData>..ctor
	|-Dictionary<int, BehaviorManager.BehaviorTree.ConditionalReevaluate>..ctor
	|-Dictionary<int, Task>..ctor
	|-Dictionary<int, BossBehaviorController>..ctor
	|-Dictionary<int, BossStageManager>..ctor
	|-Dictionary<int, DLCPair>..ctor
	|-Dictionary<int, HairType[]>..ctor
	|-Dictionary<int, EventControllerBase.FirstMatchInfo>..ctor
	|-Dictionary<int, FishSwim>..ctor
	|-Dictionary<int, HarinezumiController.NeedleController>..ctor
	|-Dictionary<int, ItemID[]>..ctor
	|-Dictionary<int, ASSET_TABLE>..ctor
	|-Dictionary<int, AssetHandle>..ctor
	|-Dictionary<int, AssetInfo>..ctor
	|-Dictionary<int, ObjectSerializationInfo.EmittableMember>..ctor
	|-Dictionary<int, MonsterActionInformation>..ctor
	|-Dictionary<int, MonsterActionInformationBase>..ctor
	|-Dictionary<int, MonsterBehaviorController.BehaviorActionParam>..ctor
	|-Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState>..ctor
	|-Dictionary<int, MonsterBehaviorController>..ctor
	|-Dictionary<int, NPCBehaviorDataTable>..ctor
	|-Dictionary<int, NPCFindTargetDataTable>..ctor
	|-Dictionary<int, OnGroundItem>..ctor
	|-Dictionary<int, PartnerNPCBehaviorController>..ctor
	|-Dictionary<int, RopePersistManager.RopeData>..ctor
	|-Dictionary<int, Action>..ctor
	|-Dictionary<int, Action<int>>..ctor
	|-Dictionary<int, Dictionary<int, List<OrderMasterData>>>..ctor
	|-Dictionary<int, Dictionary<string, object>>..ctor
	|-Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>>..ctor
	|-Dictionary<int, List<BossBehaviorParams>>..ctor
	|-Dictionary<int, List<Character>>..ctor
	|-Dictionary<int, List<MonsterBehaviorController.BehaviorActionParam>>..ctor
	|-Dictionary<int, List<OrderMasterData>>..ctor
	|-Dictionary<int, List<PartnerManager.DestinationAngle>>..ctor
	|-Dictionary<int, List<object>>..ctor
	|-Dictionary<int, List<WeakReference>>..ctor
	|-Dictionary<int, List<TimeManager.JustTimerData>>..ctor
	|-Dictionary<int, List<MeshDataConnectivity.Face>>..ctor
	|-Dictionary<int, Func<string>>..ctor
	|-Dictionary<int, CultureInfo>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, string>..ctor
	|-Dictionary<int, Task>..ctor
	|-Dictionary<int, TMP_ColorGradient>..ctor
	|-Dictionary<int, TMP_FontAsset>..ctor
	|-Dictionary<int, TMP_SpriteAsset>..ctor
	|-Dictionary<int, TMP_Style>..ctor
	|-Dictionary<int, TextureChangeMaterialParam>..ctor
	|-Dictionary<int, DiagnosticInfo>..ctor
	|-Dictionary<int, PointerEventData>..ctor
	|-Dictionary<int, TerrainUtility.TerrainMap>..ctor
	|-Dictionary<int, GUILayoutUtility.LayoutCache>..ctor
	|-Dictionary<int, GameObject>..ctor
	|-Dictionary<int, Material>..ctor
	|-Dictionary<int, ParticleSystem>..ctor
	|-Dictionary<int, IAsyncOperation>..ctor
	|-Dictionary<int, IResourceProvider>..ctor
	|-Dictionary<int, Panel>..ctor
	|
	|-RVA: 0x2D39FC0 Offset: 0x2D3A0C1 VA: 0x2D39FC0
	|-Dictionary<int, CropDataTable>..ctor
	|
	|-RVA: 0x2D3DBC0 Offset: 0x2D3DCC1 VA: 0x2D3DBC0
	|-Dictionary<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2D41530 Offset: 0x2D41631 VA: 0x2D41530
	|-Dictionary<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2D44B00 Offset: 0x2D44C01 VA: 0x2D44B00
	|-Dictionary<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2D56000 Offset: 0x2D56101 VA: 0x2D56000
	|-Dictionary<int, MineTypeID>..ctor
	|-Dictionary<int, MonsterDataID>..ctor
	|-Dictionary<int, SoundID>..ctor
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x2D487D0 Offset: 0x2D488D1 VA: 0x2D487D0
	|-Dictionary<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2D4BEA0 Offset: 0x2D4BFA1 VA: 0x2D4BEA0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x2D4F480 Offset: 0x2D4F581 VA: 0x2D4F480
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x2D52A40 Offset: 0x2D52B41 VA: 0x2D52A40
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x2F5C100 Offset: 0x2F5C201 VA: 0x2F5C100
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x2F62DB0 Offset: 0x2F62EB1 VA: 0x2F62DB0
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2F668D0 Offset: 0x2F669D1 VA: 0x2F668D0
	|-Dictionary<int, SceneInstance>..ctor
	|
	|-RVA: 0x2F69FA0 Offset: 0x2F6A0A1 VA: 0x2F69FA0
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x2F6D620 Offset: 0x2F6D721 VA: 0x2F6D620
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x2F99380 Offset: 0x2F99481 VA: 0x2F99380
	|-Dictionary<long, object>..ctor
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>..ctor
	|
	|-RVA: 0x2F9C9A0 Offset: 0x2F9CAA1 VA: 0x2F9C9A0
	|-Dictionary<Memory<object>, object>..ctor
	|
	|-RVA: 0x2FA0030 Offset: 0x2FA0131 VA: 0x2FA0030
	|-Dictionary<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2FA3810 Offset: 0x2FA3911 VA: 0x2FA3810
	|-Dictionary<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2FA7770 Offset: 0x2FA7871 VA: 0x2FA7770
	|-Dictionary<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2FAB6D0 Offset: 0x2FAB7D1 VA: 0x2FAB6D0
	|-Dictionary<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2FAEEB0 Offset: 0x2FAEFB1 VA: 0x2FAEEB0
	|-Dictionary<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2F19FA0 Offset: 0x2F1A0A1 VA: 0x2F19FA0
	|-Dictionary<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2F1D870 Offset: 0x2F1D971 VA: 0x2F1D870
	|-Dictionary<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2F21570 Offset: 0x2F21671 VA: 0x2F21570
	|-Dictionary<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2F252A0 Offset: 0x2F253A1 VA: 0x2F252A0
	|-Dictionary<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2F28A80 Offset: 0x2F28B81 VA: 0x2F28A80
	|-Dictionary<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2F2CFF0 Offset: 0x2F2D0F1 VA: 0x2F2CFF0
	|-Dictionary<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2F30CF0 Offset: 0x2F30DF1 VA: 0x2F30CF0
	|-Dictionary<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2F345C0 Offset: 0x2F346C1 VA: 0x2F345C0
	|-Dictionary<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2EFD2D0 Offset: 0x2EFD3D1 VA: 0x2EFD2D0
	|-Dictionary<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2F00FD0 Offset: 0x2F010D1 VA: 0x2F00FD0
	|-Dictionary<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2F048A0 Offset: 0x2F049A1 VA: 0x2F048A0
	|-Dictionary<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2F08170 Offset: 0x2F08271 VA: 0x2F08170
	|-Dictionary<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2F0B9B0 Offset: 0x2F0BAB1 VA: 0x2F0B9B0
	|-Dictionary<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2F0F1F0 Offset: 0x2F0F2F1 VA: 0x2F0F1F0
	|-Dictionary<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2F12EF0 Offset: 0x2F12FF1 VA: 0x2F12EF0
	|-Dictionary<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2F165B0 Offset: 0x2F166B1 VA: 0x2F165B0
	|-Dictionary<object, EventCheckId>..ctor
	|
	|-RVA: 0x2FF2D90 Offset: 0x2FF2E91 VA: 0x2FF2D90
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2FF6AD0 Offset: 0x2FF6BD1 VA: 0x2FF6AD0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2FFA4A0 Offset: 0x2FFA5A1 VA: 0x2FFA4A0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2FFDBD0 Offset: 0x2FFDCD1 VA: 0x2FFDBD0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x30012C0 Offset: 0x30013C1 VA: 0x30012C0
	|-Dictionary<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x3004E00 Offset: 0x3004F01 VA: 0x3004E00
	|-Dictionary<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x3008530 Offset: 0x3008631 VA: 0x3008530
	|-Dictionary<object, OrderSaveData>..ctor
	|
	|-RVA: 0x300C080 Offset: 0x300C181 VA: 0x300C080
	|-Dictionary<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2DDD790 Offset: 0x2DDD891 VA: 0x2DDD790
	|-Dictionary<object, Parameter>..ctor
	|
	|-RVA: 0x2DE13C0 Offset: 0x2DE14C1 VA: 0x2DE13C0
	|-Dictionary<object, NumberControl.ValueRange>..ctor
	|-Dictionary<Type, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2DE4A90 Offset: 0x2DE4B91 VA: 0x2DE4A90
	|-Dictionary<object, bool>..ctor
	|-Dictionary<Type, bool>..ctor
	|-Dictionary<Camera, bool>..ctor
	|
	|-RVA: 0x2DE8170 Offset: 0x2DE8271 VA: 0x2DE8170
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x2DEB830 Offset: 0x2DEB931 VA: 0x2DEB830
	|-Dictionary<object, char>..ctor
	|
	|-RVA: 0x2DEEEF0 Offset: 0x2DEEFF1 VA: 0x2DEEEF0
	|-Dictionary<object, DateTime>..ctor
	|
	|-RVA: 0x2DF25A0 Offset: 0x2DF26A1 VA: 0x2DF25A0
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x2DF5C60 Offset: 0x2DF5D61 VA: 0x2DF5C60
	|-Dictionary<object, short>..ctor
	|
	|-RVA: 0x30B88E0 Offset: 0x30B89E1 VA: 0x30B88E0
	|-Dictionary<object, Int32Enum>..ctor
	|-Dictionary<string, FieldPlaceId>..ctor
	|-Dictionary<string, GameFlagData>..ctor
	|-Dictionary<string, SoundID>..ctor
	|-Dictionary<string, SystemLanguage>..ctor
	|-Dictionary<string, StylePropertyID>..ctor
	|-Dictionary<Event, TextEditor.TextEditOp>..ctor
	|-Dictionary<GameObject, Prefab>..ctor
	|
	|-RVA: 0x30BBFA0 Offset: 0x30BC0A1 VA: 0x30BBFA0
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x30BF650 Offset: 0x30BF751 VA: 0x30BF650
	|-Dictionary<object, Memory<object>>..ctor
	|
	|-RVA: 0x30C2D70 Offset: 0x30C2E71 VA: 0x30C2D70
	|-Dictionary<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x30C6510 Offset: 0x30C6611 VA: 0x30C6510
	|-Dictionary<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x30CA170 Offset: 0x30CA271 VA: 0x30CA170
	|-Dictionary<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x30CDDD0 Offset: 0x30CDED1 VA: 0x30CDDD0
	|-Dictionary<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x30D1570 Offset: 0x30D1671 VA: 0x30D1570
	|-Dictionary<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x300FAB0 Offset: 0x300FBB1 VA: 0x300FAB0
	|-Dictionary<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3013300 Offset: 0x3013401 VA: 0x3013300
	|-Dictionary<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3016DF0 Offset: 0x3016EF1 VA: 0x3016DF0
	|-Dictionary<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x301A920 Offset: 0x301AA21 VA: 0x301A920
	|-Dictionary<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x301E0C0 Offset: 0x301E1C1 VA: 0x301E0C0
	|-Dictionary<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x30220C0 Offset: 0x30221C1 VA: 0x30220C0
	|-Dictionary<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3025BC0 Offset: 0x3025CC1 VA: 0x3025BC0
	|-Dictionary<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3029410 Offset: 0x3029511 VA: 0x3029410
	|-Dictionary<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2FD69F0 Offset: 0x2FD6AF1 VA: 0x2FD69F0
	|-Dictionary<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2FDA4F0 Offset: 0x2FDA5F1 VA: 0x2FDA4F0
	|-Dictionary<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2FDDD40 Offset: 0x2FDDE41 VA: 0x2FDDD40
	|-Dictionary<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2FE1590 Offset: 0x2FE1691 VA: 0x2FE1590
	|-Dictionary<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2FE4D80 Offset: 0x2FE4E81 VA: 0x2FE4D80
	|-Dictionary<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2FE8570 Offset: 0x2FE8671 VA: 0x2FE8570
	|-Dictionary<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2FEF670 Offset: 0x2FEF771 VA: 0x2FEF670
	|-Dictionary<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2DBE120 Offset: 0x2DBE221 VA: 0x2DBE120
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2DC1840 Offset: 0x2DC1941 VA: 0x2DC1840
	|-Dictionary<object, sbyte>..ctor
	|
	|-RVA: 0x2DC85C0 Offset: 0x2DC86C1 VA: 0x2DC85C0
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x2DCBC80 Offset: 0x2DCBD81 VA: 0x2DCBC80
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x2DCF340 Offset: 0x2DCF441 VA: 0x2DCF340
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x2DD6410 Offset: 0x2DD6511 VA: 0x2DD6410
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x2DD9DD0 Offset: 0x2DD9ED1 VA: 0x2DD9DD0
	|-Dictionary<object, BoundsInt>..ctor
	|
	|-RVA: 0x30D5070 Offset: 0x30D5171 VA: 0x30D5070
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x30D8730 Offset: 0x30D8831 VA: 0x30D8730
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x30DBE50 Offset: 0x30DBF51 VA: 0x30DBE50
	|-Dictionary<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x30DF540 Offset: 0x30DF641 VA: 0x30DF540
	|-Dictionary<object, GradientColorKey>..ctor
	|
	|-RVA: 0x30E2F10 Offset: 0x30E3011 VA: 0x30E2F10
	|-Dictionary<object, Keyframe>..ctor
	|
	|-RVA: 0x30E6A50 Offset: 0x30E6B51 VA: 0x30E6A50
	|-Dictionary<object, LayerMask>..ctor
	|
	|-RVA: 0x30EA110 Offset: 0x30EA211 VA: 0x30EA110
	|-Dictionary<object, Matrix4x4>..ctor
	|
	|-RVA: 0x30EDDC0 Offset: 0x30EDEC1 VA: 0x30EDDC0
	|-Dictionary<object, Playable>..ctor
	|-Dictionary<TrackAsset, Playable>..ctor
	|
	|-RVA: 0x309CBC0 Offset: 0x309CCC1 VA: 0x309CBC0
	|-Dictionary<object, Quaternion>..ctor
	|
	|-RVA: 0x30A02E0 Offset: 0x30A03E1 VA: 0x30A02E0
	|-Dictionary<object, RangeInt>..ctor
	|
	|-RVA: 0x30A3990 Offset: 0x30A3A91 VA: 0x30A3990
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x30A70B0 Offset: 0x30A71B1 VA: 0x30A70B0
	|-Dictionary<object, RectInt>..ctor
	|
	|-RVA: 0x30AA7A0 Offset: 0x30AA8A1 VA: 0x30AA7A0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x30AE170 Offset: 0x30AE271 VA: 0x30AE170
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>..ctor
	|
	|-RVA: 0x30B1B40 Offset: 0x30B1C41 VA: 0x30B1B40
	|-Dictionary<object, Vector2>..ctor
	|
	|-RVA: 0x30B5230 Offset: 0x30B5331 VA: 0x30B5230
	|-Dictionary<object, Vector2Int>..ctor
	|
	|-RVA: 0x3080EC0 Offset: 0x3080FC1 VA: 0x3080EC0
	|-Dictionary<object, Vector3>..ctor
	|
	|-RVA: 0x30845D0 Offset: 0x30846D1 VA: 0x30845D0
	|-Dictionary<object, Vector3Int>..ctor
	|
	|-RVA: 0x3087D00 Offset: 0x3087E01 VA: 0x3087D00
	|-Dictionary<object, Vector4>..ctor
	|
	|-RVA: 0x308B420 Offset: 0x308B521 VA: 0x308B420
	|-Dictionary<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x308EAB0 Offset: 0x308EBB1 VA: 0x308EAB0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x3092140 Offset: 0x3092241 VA: 0x3092140
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3095760 Offset: 0x3095861 VA: 0x3095760
	|-Dictionary<float, CurveSample>..ctor
	|
	|-RVA: 0x30995B0 Offset: 0x30996B1 VA: 0x30995B0
	|-Dictionary<float, object>..ctor
	|
	|-RVA: 0x319CB10 Offset: 0x319CC11 VA: 0x319CB10
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x31A36F0 Offset: 0x31A37F1 VA: 0x31A36F0
	|-Dictionary<uint, ActorID>..ctor
	|-Dictionary<uint, PartnerMovementOrderType>..ctor
	|-Dictionary<uint, Int32Enum>..ctor
	|
	|-RVA: 0x31A6CB0 Offset: 0x31A6DB1 VA: 0x31A6CB0
	|-Dictionary<uint, FarmMonsterBehaviorController>..ctor
	|-Dictionary<uint, FriendMonsterStatus>..ctor
	|-Dictionary<uint, Point2DList>..ctor
	|-Dictionary<uint, TriangulationConstraint>..ctor
	|-Dictionary<uint, TriangulationPoint>..ctor
	|-Dictionary<uint, SaveDataBase.ReaderFunc>..ctor
	|-Dictionary<uint, object>..ctor
	|-Dictionary<uint, TMP_Character>..ctor
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>..ctor
	|-Dictionary<uint, TMP_SpriteCharacter>..ctor
	|-Dictionary<uint, TMP_SpriteGlyph>..ctor
	|-Dictionary<uint, Glyph>..ctor
	|
	|-RVA: 0x31A0130 Offset: 0x31A0231 VA: 0x31A0130
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x31AA2D0 Offset: 0x31AA3D1 VA: 0x31AA2D0
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x31AD8F0 Offset: 0x31AD9F1 VA: 0x31AD8F0
	|-Dictionary<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x31B0F60 Offset: 0x31B1061 VA: 0x31B0F60
	|-Dictionary<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x31B4B10 Offset: 0x31B4C11 VA: 0x31B4B10
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x302CF10 Offset: 0x302D011 VA: 0x302CF10
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x30308C0 Offset: 0x30309C1 VA: 0x30308C0
	|-Dictionary<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x3033F50 Offset: 0x3034051 VA: 0x3033F50
	|-Dictionary<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x3037570 Offset: 0x3037671 VA: 0x3037570
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x303B0A0 Offset: 0x303B1A1 VA: 0x303B0A0
	|-Dictionary<BoundsInt, object>..ctor
	|
	|-RVA: 0x303EBD0 Offset: 0x303ECD1 VA: 0x303EBD0
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x3042330 Offset: 0x3042431 VA: 0x3042330
	|-Dictionary<Color32, object>..ctor
	|
	|-RVA: 0x3045990 Offset: 0x3045A91 VA: 0x3045990
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>..ctor
	|
	|-RVA: 0x30644C0 Offset: 0x30645C1 VA: 0x30644C0
	|-Dictionary<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x3067B40 Offset: 0x3067C41 VA: 0x3067B40
	|-Dictionary<GradientColorKey, object>..ctor
	|
	|-RVA: 0x306B670 Offset: 0x306B771 VA: 0x306B670
	|-Dictionary<Keyframe, object>..ctor
	|
	|-RVA: 0x306F3F0 Offset: 0x306F4F1 VA: 0x306F3F0
	|-Dictionary<LayerMask, object>..ctor
	|
	|-RVA: 0x3072A50 Offset: 0x3072B51 VA: 0x3072A50
	|-Dictionary<Matrix4x4, object>..ctor
	|
	|-RVA: 0x3076A50 Offset: 0x3076B51 VA: 0x3076A50
	|-Dictionary<IntVec3, List<int>>..ctor
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x307A140 Offset: 0x307A241 VA: 0x307A140
	|-Dictionary<Quaternion, object>..ctor
	|
	|-RVA: 0x307D8A0 Offset: 0x307D9A1 VA: 0x307D8A0
	|-Dictionary<RangeInt, object>..ctor
	|
	|-RVA: 0x3048FB0 Offset: 0x30490B1 VA: 0x3048FB0
	|-Dictionary<Rect, object>..ctor
	|
	|-RVA: 0x304C710 Offset: 0x304C811 VA: 0x304C710
	|-Dictionary<RectInt, object>..ctor
	|
	|-RVA: 0x304FD90 Offset: 0x304FE91 VA: 0x304FD90
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x3053400 Offset: 0x3053501 VA: 0x3053400
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x3056A20 Offset: 0x3056B21 VA: 0x3056A20
	|-Dictionary<Vector2, object>..ctor
	|
	|-RVA: 0x305A0A0 Offset: 0x305A1A1 VA: 0x305A0A0
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x305D6C0 Offset: 0x305D7C1 VA: 0x305D6C0
	|-Dictionary<Vector3, List<int>>..ctor
	|-Dictionary<Vector3, object>..ctor
	|
	|-RVA: 0x3060DB0 Offset: 0x3060EB1 VA: 0x3060DB0
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x2E3A7A0 Offset: 0x2E3A8A1 VA: 0x2E3A7A0
	|-Dictionary<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16180 Offset: 0x2A16281 VA: 0x2A16180
	|-Dictionary<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x2A19810 Offset: 0x2A19911 VA: 0x2A19810
	|-Dictionary<BitVector32Int, object>..ctor
	|
	|-RVA: 0x2FEC0A0 Offset: 0x2FEC1A1 VA: 0x2FEC0A0
	|-Dictionary<CharacterBase, DamageTextController>..ctor
	|-Dictionary<Tween, TweenLink>..ctor
	|-Dictionary<Enum, StateElement>..ctor
	|-Dictionary<object, IList<IResourceLocation>>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<string, string>..ctor
	|-Dictionary<string, UriParser>..ctor
	|-Dictionary<Type, ITweenPlugin>..ctor
	|-Dictionary<Type, MonoCustomAttrs.AttributeInfo>..ctor
	|-Dictionary<Collider, FocusInterface>..ctor
	|
	|-RVA: 0x2E2CE90 Offset: 0x2E2CF91 VA: 0x2E2CE90
	|-Dictionary<ActorID, MobTravelerName>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x2F78570 Offset: 0x2F78671 VA: 0x2F78570
	|-Dictionary<EventCheckId, object>..ctor
	|
	|-RVA: 0x2F7C0A0 Offset: 0x2F7C1A1 VA: 0x2F7C0A0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x2F80170 Offset: 0x2F80271 VA: 0x2F80170
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x2F83CA0 Offset: 0x2F83DA1 VA: 0x2F83CA0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x2F873B0 Offset: 0x2F874B1 VA: 0x2F873B0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x2F8AA30 Offset: 0x2F8AB31 VA: 0x2F8AA30
	|-Dictionary<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2F8E7C0 Offset: 0x2F8E8C1 VA: 0x2F8E7C0
	|-Dictionary<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2F91ED0 Offset: 0x2F91FD1 VA: 0x2F91ED0
	|-Dictionary<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2D7FFE0 Offset: 0x2D800E1 VA: 0x2D7FFE0
	|-Dictionary<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2D83B40 Offset: 0x2D83C41 VA: 0x2D83B40
	|-Dictionary<Parameter, object>..ctor
	|
	|-RVA: 0x2D878B0 Offset: 0x2D879B1 VA: 0x2D878B0
	|-Dictionary<bool, object>..ctor
	|
	|-RVA: 0x2D8AF30 Offset: 0x2D8B031 VA: 0x2D8AF30
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x2D8E550 Offset: 0x2D8E651 VA: 0x2D8E550
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x2D91B70 Offset: 0x2D91C71 VA: 0x2D91B70
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x2D95190 Offset: 0x2D95291 VA: 0x2D95190
	|-Dictionary<double, object>..ctor
	|
	|-RVA: 0x2D987A0 Offset: 0x2D988A1 VA: 0x2D987A0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x2D9BE20 Offset: 0x2D9BF21 VA: 0x2D9BE20
	|-Dictionary<short, object>..ctor
	|
	|-RVA: 0x2D39FF0 Offset: 0x2D3A0F1 VA: 0x2D39FF0
	|-Dictionary<int, CropDataTable>..ctor
	|
	|-RVA: 0x2D3DBF0 Offset: 0x2D3DCF1 VA: 0x2D3DBF0
	|-Dictionary<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2F5F7C0 Offset: 0x2F5F8C1 VA: 0x2F5F7C0
	|-Dictionary<int, FarmSupportMonsterManager.FarmScene>..ctor
	|-Dictionary<int, List<Vector3>>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, TimeType>..ctor
	|
	|-RVA: 0x2D41560 Offset: 0x2D41661 VA: 0x2D41560
	|-Dictionary<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2D44B30 Offset: 0x2D44C31 VA: 0x2D44B30
	|-Dictionary<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2D48800 Offset: 0x2D48901 VA: 0x2D48800
	|-Dictionary<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2D4BED0 Offset: 0x2D4BFD1 VA: 0x2D4BED0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x2D4F4B0 Offset: 0x2D4F5B1 VA: 0x2D4F4B0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x2D52A70 Offset: 0x2D52B71 VA: 0x2D52A70
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x2D56030 Offset: 0x2D56131 VA: 0x2D56030
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x2F5C130 Offset: 0x2F5C231 VA: 0x2F5C130
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x2F62DE0 Offset: 0x2F62EE1 VA: 0x2F62DE0
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2F66900 Offset: 0x2F66A01 VA: 0x2F66900
	|-Dictionary<int, SceneInstance>..ctor
	|
	|-RVA: 0x2F69FD0 Offset: 0x2F6A0D1 VA: 0x2F69FD0
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x2F6D650 Offset: 0x2F6D751 VA: 0x2F6D650
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x2F70DA0 Offset: 0x2F70EA1 VA: 0x2F70DA0
	|-Dictionary<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2F74A50 Offset: 0x2F74B51 VA: 0x2F74A50
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E1BF90 Offset: 0x2E1C091 VA: 0x2E1BF90
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2E1F6B0 Offset: 0x2E1F7B1 VA: 0x2E1F6B0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2E22C90 Offset: 0x2E22D91 VA: 0x2E22C90
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2E26310 Offset: 0x2E26411 VA: 0x2E26310
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x2E298D0 Offset: 0x2E299D1 VA: 0x2E298D0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2E304B0 Offset: 0x2E305B1 VA: 0x2E304B0
	|-Dictionary<Int32Enum, float>..ctor
	|
	|-RVA: 0x2E33A70 Offset: 0x2E33B71 VA: 0x2E33A70
	|-Dictionary<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2E37140 Offset: 0x2E37241 VA: 0x2E37140
	|-Dictionary<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2F95C60 Offset: 0x2F95D61 VA: 0x2F95C60
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2F993B0 Offset: 0x2F994B1 VA: 0x2F993B0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x2F9C9D0 Offset: 0x2F9CAD1 VA: 0x2F9C9D0
	|-Dictionary<Memory<object>, object>..ctor
	|
	|-RVA: 0x2FA0060 Offset: 0x2FA0161 VA: 0x2FA0060
	|-Dictionary<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2FA3840 Offset: 0x2FA3941 VA: 0x2FA3840
	|-Dictionary<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2FA77A0 Offset: 0x2FA78A1 VA: 0x2FA77A0
	|-Dictionary<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2FAB700 Offset: 0x2FAB801 VA: 0x2FAB700
	|-Dictionary<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2FAEEE0 Offset: 0x2FAEFE1 VA: 0x2FAEEE0
	|-Dictionary<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2F19FD0 Offset: 0x2F1A0D1 VA: 0x2F19FD0
	|-Dictionary<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2F1D8A0 Offset: 0x2F1D9A1 VA: 0x2F1D8A0
	|-Dictionary<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2F215A0 Offset: 0x2F216A1 VA: 0x2F215A0
	|-Dictionary<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2F252D0 Offset: 0x2F253D1 VA: 0x2F252D0
	|-Dictionary<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2F28AB0 Offset: 0x2F28BB1 VA: 0x2F28AB0
	|-Dictionary<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2F2D020 Offset: 0x2F2D121 VA: 0x2F2D020
	|-Dictionary<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2F30D20 Offset: 0x2F30E21 VA: 0x2F30D20
	|-Dictionary<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2F345F0 Offset: 0x2F346F1 VA: 0x2F345F0
	|-Dictionary<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2EFD300 Offset: 0x2EFD401 VA: 0x2EFD300
	|-Dictionary<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2F01000 Offset: 0x2F01101 VA: 0x2F01000
	|-Dictionary<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2F048D0 Offset: 0x2F049D1 VA: 0x2F048D0
	|-Dictionary<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2F081A0 Offset: 0x2F082A1 VA: 0x2F081A0
	|-Dictionary<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2F0B9E0 Offset: 0x2F0BAE1 VA: 0x2F0B9E0
	|-Dictionary<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2F0F220 Offset: 0x2F0F321 VA: 0x2F0F220
	|-Dictionary<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2F12F20 Offset: 0x2F13021 VA: 0x2F12F20
	|-Dictionary<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2F165E0 Offset: 0x2F166E1 VA: 0x2F165E0
	|-Dictionary<object, EventCheckId>..ctor
	|
	|-RVA: 0x2FF2DC0 Offset: 0x2FF2EC1 VA: 0x2FF2DC0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2FF6B00 Offset: 0x2FF6C01 VA: 0x2FF6B00
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2FFA4D0 Offset: 0x2FFA5D1 VA: 0x2FFA4D0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2FFDC00 Offset: 0x2FFDD01 VA: 0x2FFDC00
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x30012F0 Offset: 0x30013F1 VA: 0x30012F0
	|-Dictionary<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x3004E30 Offset: 0x3004F31 VA: 0x3004E30
	|-Dictionary<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x3008560 Offset: 0x3008661 VA: 0x3008560
	|-Dictionary<object, OrderSaveData>..ctor
	|
	|-RVA: 0x300C0B0 Offset: 0x300C1B1 VA: 0x300C0B0
	|-Dictionary<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2DDD7C0 Offset: 0x2DDD8C1 VA: 0x2DDD7C0
	|-Dictionary<object, Parameter>..ctor
	|
	|-RVA: 0x2DE13F0 Offset: 0x2DE14F1 VA: 0x2DE13F0
	|-Dictionary<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2DE4AC0 Offset: 0x2DE4BC1 VA: 0x2DE4AC0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x2DE81A0 Offset: 0x2DE82A1 VA: 0x2DE81A0
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x2DEB860 Offset: 0x2DEB961 VA: 0x2DEB860
	|-Dictionary<object, char>..ctor
	|
	|-RVA: 0x2DEEF20 Offset: 0x2DEF021 VA: 0x2DEEF20
	|-Dictionary<object, DateTime>..ctor
	|
	|-RVA: 0x2DF25D0 Offset: 0x2DF26D1 VA: 0x2DF25D0
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x2DF5C90 Offset: 0x2DF5D91 VA: 0x2DF5C90
	|-Dictionary<object, short>..ctor
	|
	|-RVA: 0x2DF9350 Offset: 0x2DF9451 VA: 0x2DF9350
	|-Dictionary<object, int>..ctor
	|-Dictionary<string, int>..ctor
	|-Dictionary<Type, int>..ctor
	|
	|-RVA: 0x30B8910 Offset: 0x30B8A11 VA: 0x30B8910
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x30BBFD0 Offset: 0x30BC0D1 VA: 0x30BBFD0
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x30BF680 Offset: 0x30BF781 VA: 0x30BF680
	|-Dictionary<object, Memory<object>>..ctor
	|
	|-RVA: 0x30C2DA0 Offset: 0x30C2EA1 VA: 0x30C2DA0
	|-Dictionary<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x30C6540 Offset: 0x30C6641 VA: 0x30C6540
	|-Dictionary<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x30CA1A0 Offset: 0x30CA2A1 VA: 0x30CA1A0
	|-Dictionary<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x30CDE00 Offset: 0x30CDF01 VA: 0x30CDE00
	|-Dictionary<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x30D15A0 Offset: 0x30D16A1 VA: 0x30D15A0
	|-Dictionary<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x300FAE0 Offset: 0x300FBE1 VA: 0x300FAE0
	|-Dictionary<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3013330 Offset: 0x3013431 VA: 0x3013330
	|-Dictionary<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3016E20 Offset: 0x3016F21 VA: 0x3016E20
	|-Dictionary<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x301A950 Offset: 0x301AA51 VA: 0x301A950
	|-Dictionary<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x301E0F0 Offset: 0x301E1F1 VA: 0x301E0F0
	|-Dictionary<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x30220F0 Offset: 0x30221F1 VA: 0x30220F0
	|-Dictionary<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3025BF0 Offset: 0x3025CF1 VA: 0x3025BF0
	|-Dictionary<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3029440 Offset: 0x3029541 VA: 0x3029440
	|-Dictionary<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2FD6A20 Offset: 0x2FD6B21 VA: 0x2FD6A20
	|-Dictionary<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2FDA520 Offset: 0x2FDA621 VA: 0x2FDA520
	|-Dictionary<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2FDDD70 Offset: 0x2FDDE71 VA: 0x2FDDD70
	|-Dictionary<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2FE15C0 Offset: 0x2FE16C1 VA: 0x2FE15C0
	|-Dictionary<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2FE4DB0 Offset: 0x2FE4EB1 VA: 0x2FE4DB0
	|-Dictionary<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2FE85A0 Offset: 0x2FE86A1 VA: 0x2FE85A0
	|-Dictionary<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2FEF6A0 Offset: 0x2FEF7A1 VA: 0x2FEF6A0
	|-Dictionary<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2DBE150 Offset: 0x2DBE251 VA: 0x2DBE150
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2DC1870 Offset: 0x2DC1971 VA: 0x2DC1870
	|-Dictionary<object, sbyte>..ctor
	|
	|-RVA: 0x2DC4F30 Offset: 0x2DC5031 VA: 0x2DC4F30
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x2DC85F0 Offset: 0x2DC86F1 VA: 0x2DC85F0
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x2DCBCB0 Offset: 0x2DCBDB1 VA: 0x2DCBCB0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x2DCF370 Offset: 0x2DCF471 VA: 0x2DCF370
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x2DD2A20 Offset: 0x2DD2B21 VA: 0x2DD2A20
	|-Dictionary<object, TransitionTables>..ctor
	|
	|-RVA: 0x2DD6440 Offset: 0x2DD6541 VA: 0x2DD6440
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x2DD9E00 Offset: 0x2DD9F01 VA: 0x2DD9E00
	|-Dictionary<object, BoundsInt>..ctor
	|
	|-RVA: 0x30D50A0 Offset: 0x30D51A1 VA: 0x30D50A0
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x30D8760 Offset: 0x30D8861 VA: 0x30D8760
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x30DBE80 Offset: 0x30DBF81 VA: 0x30DBE80
	|-Dictionary<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x30DF570 Offset: 0x30DF671 VA: 0x30DF570
	|-Dictionary<object, GradientColorKey>..ctor
	|
	|-RVA: 0x30E2F40 Offset: 0x30E3041 VA: 0x30E2F40
	|-Dictionary<object, Keyframe>..ctor
	|
	|-RVA: 0x30E6A80 Offset: 0x30E6B81 VA: 0x30E6A80
	|-Dictionary<object, LayerMask>..ctor
	|
	|-RVA: 0x30EA140 Offset: 0x30EA241 VA: 0x30EA140
	|-Dictionary<object, Matrix4x4>..ctor
	|
	|-RVA: 0x30EDDF0 Offset: 0x30EDEF1 VA: 0x30EDDF0
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x309CBF0 Offset: 0x309CCF1 VA: 0x309CBF0
	|-Dictionary<object, Quaternion>..ctor
	|
	|-RVA: 0x30A0310 Offset: 0x30A0411 VA: 0x30A0310
	|-Dictionary<object, RangeInt>..ctor
	|
	|-RVA: 0x30A39C0 Offset: 0x30A3AC1 VA: 0x30A39C0
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x30A70E0 Offset: 0x30A71E1 VA: 0x30A70E0
	|-Dictionary<object, RectInt>..ctor
	|
	|-RVA: 0x30AA7D0 Offset: 0x30AA8D1 VA: 0x30AA7D0
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x30AE1A0 Offset: 0x30AE2A1 VA: 0x30AE1A0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x30B1B70 Offset: 0x30B1C71 VA: 0x30B1B70
	|-Dictionary<object, Vector2>..ctor
	|
	|-RVA: 0x30B5260 Offset: 0x30B5361 VA: 0x30B5260
	|-Dictionary<object, Vector2Int>..ctor
	|
	|-RVA: 0x3080EF0 Offset: 0x3080FF1 VA: 0x3080EF0
	|-Dictionary<object, Vector3>..ctor
	|
	|-RVA: 0x3084600 Offset: 0x3084701 VA: 0x3084600
	|-Dictionary<object, Vector3Int>..ctor
	|
	|-RVA: 0x3087D30 Offset: 0x3087E31 VA: 0x3087D30
	|-Dictionary<object, Vector4>..ctor
	|
	|-RVA: 0x308B450 Offset: 0x308B551 VA: 0x308B450
	|-Dictionary<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x308EAE0 Offset: 0x308EBE1 VA: 0x308EAE0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x3092170 Offset: 0x3092271 VA: 0x3092170
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3095790 Offset: 0x3095891 VA: 0x3095790
	|-Dictionary<float, CurveSample>..ctor
	|
	|-RVA: 0x30995E0 Offset: 0x30996E1 VA: 0x30995E0
	|-Dictionary<float, object>..ctor
	|
	|-RVA: 0x319CB40 Offset: 0x319CC41 VA: 0x319CB40
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x31A0160 Offset: 0x31A0261 VA: 0x31A0160
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x31A3720 Offset: 0x31A3821 VA: 0x31A3720
	|-Dictionary<uint, Int32Enum>..ctor
	|
	|-RVA: 0x31A6CE0 Offset: 0x31A6DE1 VA: 0x31A6CE0
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x31AA300 Offset: 0x31AA401 VA: 0x31AA300
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x31AD920 Offset: 0x31ADA21 VA: 0x31AD920
	|-Dictionary<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x31B0F90 Offset: 0x31B1091 VA: 0x31B0F90
	|-Dictionary<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x31B4B40 Offset: 0x31B4C41 VA: 0x31B4B40
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x302CF40 Offset: 0x302D041 VA: 0x302CF40
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x30308F0 Offset: 0x30309F1 VA: 0x30308F0
	|-Dictionary<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x3033F80 Offset: 0x3034081 VA: 0x3033F80
	|-Dictionary<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x30375A0 Offset: 0x30376A1 VA: 0x30375A0
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x303B0D0 Offset: 0x303B1D1 VA: 0x303B0D0
	|-Dictionary<BoundsInt, object>..ctor
	|
	|-RVA: 0x303EC00 Offset: 0x303ED01 VA: 0x303EC00
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x3042360 Offset: 0x3042461 VA: 0x3042360
	|-Dictionary<Color32, object>..ctor
	|
	|-RVA: 0x30459C0 Offset: 0x3045AC1 VA: 0x30459C0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x30644F0 Offset: 0x30645F1 VA: 0x30644F0
	|-Dictionary<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x3067B70 Offset: 0x3067C71 VA: 0x3067B70
	|-Dictionary<GradientColorKey, object>..ctor
	|
	|-RVA: 0x306B6A0 Offset: 0x306B7A1 VA: 0x306B6A0
	|-Dictionary<Keyframe, object>..ctor
	|
	|-RVA: 0x306F420 Offset: 0x306F521 VA: 0x306F420
	|-Dictionary<LayerMask, object>..ctor
	|
	|-RVA: 0x3072A80 Offset: 0x3072B81 VA: 0x3072A80
	|-Dictionary<Matrix4x4, object>..ctor
	|
	|-RVA: 0x3076A80 Offset: 0x3076B81 VA: 0x3076A80
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x307A170 Offset: 0x307A271 VA: 0x307A170
	|-Dictionary<Quaternion, object>..ctor
	|
	|-RVA: 0x307D8D0 Offset: 0x307D9D1 VA: 0x307D8D0
	|-Dictionary<RangeInt, object>..ctor
	|
	|-RVA: 0x3048FE0 Offset: 0x30490E1 VA: 0x3048FE0
	|-Dictionary<Rect, object>..ctor
	|
	|-RVA: 0x304C740 Offset: 0x304C841 VA: 0x304C740
	|-Dictionary<RectInt, object>..ctor
	|
	|-RVA: 0x304FDC0 Offset: 0x304FEC1 VA: 0x304FDC0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x3053430 Offset: 0x3053531 VA: 0x3053430
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x3056A50 Offset: 0x3056B51 VA: 0x3056A50
	|-Dictionary<Vector2, object>..ctor
	|
	|-RVA: 0x305A0D0 Offset: 0x305A1D1 VA: 0x305A0D0
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x305D6F0 Offset: 0x305D7F1 VA: 0x305D6F0
	|-Dictionary<Vector3, object>..ctor
	|
	|-RVA: 0x3060DE0 Offset: 0x3060EE1 VA: 0x3060DE0
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x2E3A7D0 Offset: 0x2E3A8D1 VA: 0x2E3A7D0
	|-Dictionary<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC0D0 Offset: 0x2FEC1D1 VA: 0x2FEC0D0
	|-Dictionary<BehaviorManager.ThirdPartyTask, object>..ctor
	|-Dictionary<BinaryDeserialization.ObjectFieldMap, List<int>>..ctor
	|-Dictionary<int[], SceneSplit>..ctor
	|-Dictionary<int[], Terrain>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<string, SimpleCollator>..ctor
	|-Dictionary<string, GUIStyle>..ctor
	|
	|-RVA: 0x2A161B0 Offset: 0x2A162B1 VA: 0x2A161B0
	|-Dictionary<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x2A19840 Offset: 0x2A19941 VA: 0x2A19840
	|-Dictionary<BitVector32Int, object>..ctor
	|
	|-RVA: 0x2F785A0 Offset: 0x2F786A1 VA: 0x2F785A0
	|-Dictionary<EventCheckId, object>..ctor
	|
	|-RVA: 0x2F7C0D0 Offset: 0x2F7C1D1 VA: 0x2F7C0D0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x2F801A0 Offset: 0x2F802A1 VA: 0x2F801A0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x2F83CD0 Offset: 0x2F83DD1 VA: 0x2F83CD0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x2F873E0 Offset: 0x2F874E1 VA: 0x2F873E0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x2F8AA60 Offset: 0x2F8AB61 VA: 0x2F8AA60
	|-Dictionary<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2F8E7F0 Offset: 0x2F8E8F1 VA: 0x2F8E7F0
	|-Dictionary<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2F91F00 Offset: 0x2F92001 VA: 0x2F91F00
	|-Dictionary<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2D80010 Offset: 0x2D80111 VA: 0x2D80010
	|-Dictionary<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2D83B70 Offset: 0x2D83C71 VA: 0x2D83B70
	|-Dictionary<Parameter, object>..ctor
	|
	|-RVA: 0x2D878E0 Offset: 0x2D879E1 VA: 0x2D878E0
	|-Dictionary<bool, object>..ctor
	|
	|-RVA: 0x2D8AF60 Offset: 0x2D8B061 VA: 0x2D8AF60
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x2D8E580 Offset: 0x2D8E681 VA: 0x2D8E580
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x2D91BA0 Offset: 0x2D91CA1 VA: 0x2D91BA0
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x2D951C0 Offset: 0x2D952C1 VA: 0x2D951C0
	|-Dictionary<double, object>..ctor
	|
	|-RVA: 0x2D987D0 Offset: 0x2D988D1 VA: 0x2D987D0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x2D9BE50 Offset: 0x2D9BF51 VA: 0x2D9BE50
	|-Dictionary<short, object>..ctor
	|
	|-RVA: 0x2D3A020 Offset: 0x2D3A121 VA: 0x2D3A020
	|-Dictionary<int, CropDataTable>..ctor
	|
	|-RVA: 0x2D3DC20 Offset: 0x2D3DD21 VA: 0x2D3DC20
	|-Dictionary<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2D41590 Offset: 0x2D41691 VA: 0x2D41590
	|-Dictionary<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2D44B60 Offset: 0x2D44C61 VA: 0x2D44B60
	|-Dictionary<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2D48830 Offset: 0x2D48931 VA: 0x2D48830
	|-Dictionary<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2D4BF00 Offset: 0x2D4C001 VA: 0x2D4BF00
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x2D4F4E0 Offset: 0x2D4F5E1 VA: 0x2D4F4E0
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x2D52AA0 Offset: 0x2D52BA1 VA: 0x2D52AA0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x2D56060 Offset: 0x2D56161 VA: 0x2D56060
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x2F5C160 Offset: 0x2F5C261 VA: 0x2F5C160
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x2F5F7F0 Offset: 0x2F5F8F1 VA: 0x2F5F7F0
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x2F62E10 Offset: 0x2F62F11 VA: 0x2F62E10
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2F66930 Offset: 0x2F66A31 VA: 0x2F66930
	|-Dictionary<int, SceneInstance>..ctor
	|
	|-RVA: 0x2F6A000 Offset: 0x2F6A101 VA: 0x2F6A000
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x2F6D680 Offset: 0x2F6D781 VA: 0x2F6D680
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x2F70DD0 Offset: 0x2F70ED1 VA: 0x2F70DD0
	|-Dictionary<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2F74A80 Offset: 0x2F74B81 VA: 0x2F74A80
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E1BFC0 Offset: 0x2E1C0C1 VA: 0x2E1BFC0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2E1F6E0 Offset: 0x2E1F7E1 VA: 0x2E1F6E0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2E22CC0 Offset: 0x2E22DC1 VA: 0x2E22CC0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2E26340 Offset: 0x2E26441 VA: 0x2E26340
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x2E29900 Offset: 0x2E29A01 VA: 0x2E29900
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2E2CEC0 Offset: 0x2E2CFC1 VA: 0x2E2CEC0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x2E304E0 Offset: 0x2E305E1 VA: 0x2E304E0
	|-Dictionary<Int32Enum, float>..ctor
	|
	|-RVA: 0x2E33AA0 Offset: 0x2E33BA1 VA: 0x2E33AA0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2E37170 Offset: 0x2E37271 VA: 0x2E37170
	|-Dictionary<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2F95C90 Offset: 0x2F95D91 VA: 0x2F95C90
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2F993E0 Offset: 0x2F994E1 VA: 0x2F993E0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x2F9CA00 Offset: 0x2F9CB01 VA: 0x2F9CA00
	|-Dictionary<Memory<object>, object>..ctor
	|
	|-RVA: 0x2FA0090 Offset: 0x2FA0191 VA: 0x2FA0090
	|-Dictionary<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2FA3870 Offset: 0x2FA3971 VA: 0x2FA3870
	|-Dictionary<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2FA77D0 Offset: 0x2FA78D1 VA: 0x2FA77D0
	|-Dictionary<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2FAB730 Offset: 0x2FAB831 VA: 0x2FAB730
	|-Dictionary<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2FAEF10 Offset: 0x2FAF011 VA: 0x2FAEF10
	|-Dictionary<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2F1A000 Offset: 0x2F1A101 VA: 0x2F1A000
	|-Dictionary<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2F1D8D0 Offset: 0x2F1D9D1 VA: 0x2F1D8D0
	|-Dictionary<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2F215D0 Offset: 0x2F216D1 VA: 0x2F215D0
	|-Dictionary<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2F25300 Offset: 0x2F25401 VA: 0x2F25300
	|-Dictionary<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2F28AE0 Offset: 0x2F28BE1 VA: 0x2F28AE0
	|-Dictionary<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2F2D050 Offset: 0x2F2D151 VA: 0x2F2D050
	|-Dictionary<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2F30D50 Offset: 0x2F30E51 VA: 0x2F30D50
	|-Dictionary<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2F34620 Offset: 0x2F34721 VA: 0x2F34620
	|-Dictionary<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2EFD330 Offset: 0x2EFD431 VA: 0x2EFD330
	|-Dictionary<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2F01030 Offset: 0x2F01131 VA: 0x2F01030
	|-Dictionary<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2F04900 Offset: 0x2F04A01 VA: 0x2F04900
	|-Dictionary<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2F081D0 Offset: 0x2F082D1 VA: 0x2F081D0
	|-Dictionary<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2F0BA10 Offset: 0x2F0BB11 VA: 0x2F0BA10
	|-Dictionary<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2F0F250 Offset: 0x2F0F351 VA: 0x2F0F250
	|-Dictionary<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2F12F50 Offset: 0x2F13051 VA: 0x2F12F50
	|-Dictionary<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2F16610 Offset: 0x2F16711 VA: 0x2F16610
	|-Dictionary<object, EventCheckId>..ctor
	|
	|-RVA: 0x2FF2DF0 Offset: 0x2FF2EF1 VA: 0x2FF2DF0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2FF6B30 Offset: 0x2FF6C31 VA: 0x2FF6B30
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2FFA500 Offset: 0x2FFA601 VA: 0x2FFA500
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2FFDC30 Offset: 0x2FFDD31 VA: 0x2FFDC30
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x3001320 Offset: 0x3001421 VA: 0x3001320
	|-Dictionary<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x3004E60 Offset: 0x3004F61 VA: 0x3004E60
	|-Dictionary<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x3008590 Offset: 0x3008691 VA: 0x3008590
	|-Dictionary<object, OrderSaveData>..ctor
	|
	|-RVA: 0x300C0E0 Offset: 0x300C1E1 VA: 0x300C0E0
	|-Dictionary<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2DDD7F0 Offset: 0x2DDD8F1 VA: 0x2DDD7F0
	|-Dictionary<object, Parameter>..ctor
	|
	|-RVA: 0x2DE1420 Offset: 0x2DE1521 VA: 0x2DE1420
	|-Dictionary<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2DE4AF0 Offset: 0x2DE4BF1 VA: 0x2DE4AF0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x2DE81D0 Offset: 0x2DE82D1 VA: 0x2DE81D0
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x2DEB890 Offset: 0x2DEB991 VA: 0x2DEB890
	|-Dictionary<object, char>..ctor
	|
	|-RVA: 0x2DEEF50 Offset: 0x2DEF051 VA: 0x2DEEF50
	|-Dictionary<object, DateTime>..ctor
	|
	|-RVA: 0x2DF2600 Offset: 0x2DF2701 VA: 0x2DF2600
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x2DF5CC0 Offset: 0x2DF5DC1 VA: 0x2DF5CC0
	|-Dictionary<object, short>..ctor
	|
	|-RVA: 0x2DF9380 Offset: 0x2DF9481 VA: 0x2DF9380
	|-Dictionary<object, int>..ctor
	|-Dictionary<Simplifier.VertexDataHash, int>..ctor
	|
	|-RVA: 0x30B8940 Offset: 0x30B8A41 VA: 0x30B8940
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x30BC000 Offset: 0x30BC101 VA: 0x30BC000
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x30BF6B0 Offset: 0x30BF7B1 VA: 0x30BF6B0
	|-Dictionary<object, Memory<object>>..ctor
	|
	|-RVA: 0x30C2DD0 Offset: 0x30C2ED1 VA: 0x30C2DD0
	|-Dictionary<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x30C6570 Offset: 0x30C6671 VA: 0x30C6570
	|-Dictionary<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x30CA1D0 Offset: 0x30CA2D1 VA: 0x30CA1D0
	|-Dictionary<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x30CDE30 Offset: 0x30CDF31 VA: 0x30CDE30
	|-Dictionary<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x30D15D0 Offset: 0x30D16D1 VA: 0x30D15D0
	|-Dictionary<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x300FB10 Offset: 0x300FC11 VA: 0x300FB10
	|-Dictionary<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3013360 Offset: 0x3013461 VA: 0x3013360
	|-Dictionary<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3016E50 Offset: 0x3016F51 VA: 0x3016E50
	|-Dictionary<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x301A980 Offset: 0x301AA81 VA: 0x301A980
	|-Dictionary<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x301E120 Offset: 0x301E221 VA: 0x301E120
	|-Dictionary<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3022120 Offset: 0x3022221 VA: 0x3022120
	|-Dictionary<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3025C20 Offset: 0x3025D21 VA: 0x3025C20
	|-Dictionary<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x3029470 Offset: 0x3029571 VA: 0x3029470
	|-Dictionary<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2FD6A50 Offset: 0x2FD6B51 VA: 0x2FD6A50
	|-Dictionary<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2FDA550 Offset: 0x2FDA651 VA: 0x2FDA550
	|-Dictionary<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2FDDDA0 Offset: 0x2FDDEA1 VA: 0x2FDDDA0
	|-Dictionary<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2FE15F0 Offset: 0x2FE16F1 VA: 0x2FE15F0
	|-Dictionary<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2FE4DE0 Offset: 0x2FE4EE1 VA: 0x2FE4DE0
	|-Dictionary<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2FE85D0 Offset: 0x2FE86D1 VA: 0x2FE85D0
	|-Dictionary<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2FEF6D0 Offset: 0x2FEF7D1 VA: 0x2FEF6D0
	|-Dictionary<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2DBE180 Offset: 0x2DBE281 VA: 0x2DBE180
	|-Dictionary<object, ResourceLocator>..ctor
	|-Dictionary<string, ResourceLocator>..ctor
	|
	|-RVA: 0x2DC18A0 Offset: 0x2DC19A1 VA: 0x2DC18A0
	|-Dictionary<object, sbyte>..ctor
	|
	|-RVA: 0x2DC4F60 Offset: 0x2DC5061 VA: 0x2DC4F60
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x2DC8620 Offset: 0x2DC8721 VA: 0x2DC8620
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x2DCBCE0 Offset: 0x2DCBDE1 VA: 0x2DCBCE0
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x2DCF3A0 Offset: 0x2DCF4A1 VA: 0x2DCF3A0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x2DD2A50 Offset: 0x2DD2B51 VA: 0x2DD2A50
	|-Dictionary<object, TransitionTables>..ctor
	|
	|-RVA: 0x2DD6470 Offset: 0x2DD6571 VA: 0x2DD6470
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x2DD9E30 Offset: 0x2DD9F31 VA: 0x2DD9E30
	|-Dictionary<object, BoundsInt>..ctor
	|
	|-RVA: 0x30D50D0 Offset: 0x30D51D1 VA: 0x30D50D0
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x30D8790 Offset: 0x30D8891 VA: 0x30D8790
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x30DBEB0 Offset: 0x30DBFB1 VA: 0x30DBEB0
	|-Dictionary<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x30DF5A0 Offset: 0x30DF6A1 VA: 0x30DF5A0
	|-Dictionary<object, GradientColorKey>..ctor
	|
	|-RVA: 0x30E2F70 Offset: 0x30E3071 VA: 0x30E2F70
	|-Dictionary<object, Keyframe>..ctor
	|
	|-RVA: 0x30E6AB0 Offset: 0x30E6BB1 VA: 0x30E6AB0
	|-Dictionary<object, LayerMask>..ctor
	|
	|-RVA: 0x30EA170 Offset: 0x30EA271 VA: 0x30EA170
	|-Dictionary<object, Matrix4x4>..ctor
	|
	|-RVA: 0x30EDE20 Offset: 0x30EDF21 VA: 0x30EDE20
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x309CC20 Offset: 0x309CD21 VA: 0x309CC20
	|-Dictionary<object, Quaternion>..ctor
	|
	|-RVA: 0x30A0340 Offset: 0x30A0441 VA: 0x30A0340
	|-Dictionary<object, RangeInt>..ctor
	|
	|-RVA: 0x30A39F0 Offset: 0x30A3AF1 VA: 0x30A39F0
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x30A7110 Offset: 0x30A7211 VA: 0x30A7110
	|-Dictionary<object, RectInt>..ctor
	|
	|-RVA: 0x30AA800 Offset: 0x30AA901 VA: 0x30AA800
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x30AE1D0 Offset: 0x30AE2D1 VA: 0x30AE1D0
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x30B1BA0 Offset: 0x30B1CA1 VA: 0x30B1BA0
	|-Dictionary<object, Vector2>..ctor
	|
	|-RVA: 0x30B5290 Offset: 0x30B5391 VA: 0x30B5290
	|-Dictionary<object, Vector2Int>..ctor
	|
	|-RVA: 0x3080F20 Offset: 0x3081021 VA: 0x3080F20
	|-Dictionary<object, Vector3>..ctor
	|
	|-RVA: 0x3084630 Offset: 0x3084731 VA: 0x3084630
	|-Dictionary<object, Vector3Int>..ctor
	|
	|-RVA: 0x3087D60 Offset: 0x3087E61 VA: 0x3087D60
	|-Dictionary<object, Vector4>..ctor
	|
	|-RVA: 0x308B480 Offset: 0x308B581 VA: 0x308B480
	|-Dictionary<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x308EB10 Offset: 0x308EC11 VA: 0x308EB10
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x30921A0 Offset: 0x30922A1 VA: 0x30921A0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x30957C0 Offset: 0x30958C1 VA: 0x30957C0
	|-Dictionary<float, CurveSample>..ctor
	|
	|-RVA: 0x3099610 Offset: 0x3099711 VA: 0x3099610
	|-Dictionary<float, object>..ctor
	|
	|-RVA: 0x319CB70 Offset: 0x319CC71 VA: 0x319CB70
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x31A0190 Offset: 0x31A0291 VA: 0x31A0190
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x31A3750 Offset: 0x31A3851 VA: 0x31A3750
	|-Dictionary<uint, Int32Enum>..ctor
	|
	|-RVA: 0x31A6D10 Offset: 0x31A6E11 VA: 0x31A6D10
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x31AA330 Offset: 0x31AA431 VA: 0x31AA330
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x31AD950 Offset: 0x31ADA51 VA: 0x31AD950
	|-Dictionary<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x31B0FC0 Offset: 0x31B10C1 VA: 0x31B0FC0
	|-Dictionary<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x31B4B70 Offset: 0x31B4C71 VA: 0x31B4B70
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x302CF70 Offset: 0x302D071 VA: 0x302CF70
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x3030920 Offset: 0x3030A21 VA: 0x3030920
	|-Dictionary<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x3033FB0 Offset: 0x30340B1 VA: 0x3033FB0
	|-Dictionary<MeshDataConnectivity.Face, List<int>>..ctor
	|-Dictionary<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x30375D0 Offset: 0x30376D1 VA: 0x30375D0
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x303B100 Offset: 0x303B201 VA: 0x303B100
	|-Dictionary<BoundsInt, object>..ctor
	|
	|-RVA: 0x303EC30 Offset: 0x303ED31 VA: 0x303EC30
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x3042390 Offset: 0x3042491 VA: 0x3042390
	|-Dictionary<Color32, object>..ctor
	|
	|-RVA: 0x30459F0 Offset: 0x3045AF1 VA: 0x30459F0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x3064520 Offset: 0x3064621 VA: 0x3064520
	|-Dictionary<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x3067BA0 Offset: 0x3067CA1 VA: 0x3067BA0
	|-Dictionary<GradientColorKey, object>..ctor
	|
	|-RVA: 0x306B6D0 Offset: 0x306B7D1 VA: 0x306B6D0
	|-Dictionary<Keyframe, object>..ctor
	|
	|-RVA: 0x306F450 Offset: 0x306F551 VA: 0x306F450
	|-Dictionary<LayerMask, object>..ctor
	|
	|-RVA: 0x3072AB0 Offset: 0x3072BB1 VA: 0x3072AB0
	|-Dictionary<Matrix4x4, object>..ctor
	|
	|-RVA: 0x3076AB0 Offset: 0x3076BB1 VA: 0x3076AB0
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x307A1A0 Offset: 0x307A2A1 VA: 0x307A1A0
	|-Dictionary<Quaternion, object>..ctor
	|
	|-RVA: 0x307D900 Offset: 0x307DA01 VA: 0x307D900
	|-Dictionary<RangeInt, object>..ctor
	|
	|-RVA: 0x3049010 Offset: 0x3049111 VA: 0x3049010
	|-Dictionary<Rect, object>..ctor
	|
	|-RVA: 0x304C770 Offset: 0x304C871 VA: 0x304C770
	|-Dictionary<RectInt, object>..ctor
	|
	|-RVA: 0x304FDF0 Offset: 0x304FEF1 VA: 0x304FDF0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x3053460 Offset: 0x3053561 VA: 0x3053460
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	|-Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyID[]>..ctor
	|
	|-RVA: 0x3056A80 Offset: 0x3056B81 VA: 0x3056A80
	|-Dictionary<Vector2, object>..ctor
	|
	|-RVA: 0x305A100 Offset: 0x305A201 VA: 0x305A100
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x305D720 Offset: 0x305D821 VA: 0x305D720
	|-Dictionary<Vector3, object>..ctor
	|
	|-RVA: 0x3060E10 Offset: 0x3060F11 VA: 0x3060E10
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x2E3A800 Offset: 0x2E3A901 VA: 0x2E3A800
	|-Dictionary<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A161E0 Offset: 0x2A162E1 VA: 0x2A161E0
	|-Dictionary<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x2A19870 Offset: 0x2A19971 VA: 0x2A19870
	|-Dictionary<BitVector32Int, object>..ctor
	|
	|-RVA: 0x2F785D0 Offset: 0x2F786D1 VA: 0x2F785D0
	|-Dictionary<EventCheckId, object>..ctor
	|
	|-RVA: 0x2F7C100 Offset: 0x2F7C201 VA: 0x2F7C100
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x2F801D0 Offset: 0x2F802D1 VA: 0x2F801D0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x2F83D00 Offset: 0x2F83E01 VA: 0x2F83D00
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x2F87410 Offset: 0x2F87511 VA: 0x2F87410
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x2F8AA90 Offset: 0x2F8AB91 VA: 0x2F8AA90
	|-Dictionary<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2F8E820 Offset: 0x2F8E921 VA: 0x2F8E820
	|-Dictionary<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2F91F30 Offset: 0x2F92031 VA: 0x2F91F30
	|-Dictionary<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2D80040 Offset: 0x2D80141 VA: 0x2D80040
	|-Dictionary<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2D83BA0 Offset: 0x2D83CA1 VA: 0x2D83BA0
	|-Dictionary<Parameter, object>..ctor
	|
	|-RVA: 0x2D87910 Offset: 0x2D87A11 VA: 0x2D87910
	|-Dictionary<bool, object>..ctor
	|
	|-RVA: 0x2D8AF90 Offset: 0x2D8B091 VA: 0x2D8AF90
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x2D8E5B0 Offset: 0x2D8E6B1 VA: 0x2D8E5B0
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x2D91BD0 Offset: 0x2D91CD1 VA: 0x2D91BD0
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x2D951F0 Offset: 0x2D952F1 VA: 0x2D951F0
	|-Dictionary<double, object>..ctor
	|
	|-RVA: 0x2D98800 Offset: 0x2D98901 VA: 0x2D98800
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x2D9BE80 Offset: 0x2D9BF81 VA: 0x2D9BE80
	|-Dictionary<short, object>..ctor
	|
	|-RVA: 0x2D3A050 Offset: 0x2D3A151 VA: 0x2D3A050
	|-Dictionary<int, CropDataTable>..ctor
	|
	|-RVA: 0x2D3DC50 Offset: 0x2D3DD51 VA: 0x2D3DC50
	|-Dictionary<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2D415C0 Offset: 0x2D416C1 VA: 0x2D415C0
	|-Dictionary<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2D44B90 Offset: 0x2D44C91 VA: 0x2D44B90
	|-Dictionary<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2D48860 Offset: 0x2D48961 VA: 0x2D48860
	|-Dictionary<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2D4BF30 Offset: 0x2D4C031 VA: 0x2D4BF30
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x2D4F510 Offset: 0x2D4F611 VA: 0x2D4F510
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x2D52AD0 Offset: 0x2D52BD1 VA: 0x2D52AD0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x2D56090 Offset: 0x2D56191 VA: 0x2D56090
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x2F5C190 Offset: 0x2F5C291 VA: 0x2F5C190
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x2F5F820 Offset: 0x2F5F921 VA: 0x2F5F820
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x2F62E40 Offset: 0x2F62F41 VA: 0x2F62E40
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2F66960 Offset: 0x2F66A61 VA: 0x2F66960
	|-Dictionary<int, SceneInstance>..ctor
	|
	|-RVA: 0x2F6A030 Offset: 0x2F6A131 VA: 0x2F6A030
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x2F6D6B0 Offset: 0x2F6D7B1 VA: 0x2F6D6B0
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x2F70E00 Offset: 0x2F70F01 VA: 0x2F70E00
	|-Dictionary<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2F74AB0 Offset: 0x2F74BB1 VA: 0x2F74AB0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E1BFF0 Offset: 0x2E1C0F1 VA: 0x2E1BFF0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2E1F710 Offset: 0x2E1F811 VA: 0x2E1F710
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2E22CF0 Offset: 0x2E22DF1 VA: 0x2E22CF0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2E26370 Offset: 0x2E26471 VA: 0x2E26370
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x2E29930 Offset: 0x2E29A31 VA: 0x2E29930
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2E2CEF0 Offset: 0x2E2CFF1 VA: 0x2E2CEF0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x2E30510 Offset: 0x2E30611 VA: 0x2E30510
	|-Dictionary<Int32Enum, float>..ctor
	|
	|-RVA: 0x2E33AD0 Offset: 0x2E33BD1 VA: 0x2E33AD0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2E371A0 Offset: 0x2E372A1 VA: 0x2E371A0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2F95CC0 Offset: 0x2F95DC1 VA: 0x2F95CC0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2F99410 Offset: 0x2F99511 VA: 0x2F99410
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x2F9CA30 Offset: 0x2F9CB31 VA: 0x2F9CA30
	|-Dictionary<Memory<object>, object>..ctor
	|
	|-RVA: 0x2FA00C0 Offset: 0x2FA01C1 VA: 0x2FA00C0
	|-Dictionary<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2FA38A0 Offset: 0x2FA39A1 VA: 0x2FA38A0
	|-Dictionary<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2FA7800 Offset: 0x2FA7901 VA: 0x2FA7800
	|-Dictionary<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2FAB760 Offset: 0x2FAB861 VA: 0x2FAB760
	|-Dictionary<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2FAEF40 Offset: 0x2FAF041 VA: 0x2FAEF40
	|-Dictionary<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2F1A030 Offset: 0x2F1A131 VA: 0x2F1A030
	|-Dictionary<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2F1D900 Offset: 0x2F1DA01 VA: 0x2F1D900
	|-Dictionary<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2F21600 Offset: 0x2F21701 VA: 0x2F21600
	|-Dictionary<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2F25330 Offset: 0x2F25431 VA: 0x2F25330
	|-Dictionary<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2F28B10 Offset: 0x2F28C11 VA: 0x2F28B10
	|-Dictionary<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2F2D080 Offset: 0x2F2D181 VA: 0x2F2D080
	|-Dictionary<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2F30D80 Offset: 0x2F30E81 VA: 0x2F30D80
	|-Dictionary<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2F34650 Offset: 0x2F34751 VA: 0x2F34650
	|-Dictionary<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2EFD360 Offset: 0x2EFD461 VA: 0x2EFD360
	|-Dictionary<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2F01060 Offset: 0x2F01161 VA: 0x2F01060
	|-Dictionary<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2F04930 Offset: 0x2F04A31 VA: 0x2F04930
	|-Dictionary<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2F08200 Offset: 0x2F08301 VA: 0x2F08200
	|-Dictionary<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2F0BA40 Offset: 0x2F0BB41 VA: 0x2F0BA40
	|-Dictionary<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2F0F280 Offset: 0x2F0F381 VA: 0x2F0F280
	|-Dictionary<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2F12F80 Offset: 0x2F13081 VA: 0x2F12F80
	|-Dictionary<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2F16640 Offset: 0x2F16741 VA: 0x2F16640
	|-Dictionary<object, EventCheckId>..ctor
	|
	|-RVA: 0x2FF2E20 Offset: 0x2FF2F21 VA: 0x2FF2E20
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2FF6B60 Offset: 0x2FF6C61 VA: 0x2FF6B60
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2FFA530 Offset: 0x2FFA631 VA: 0x2FFA530
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2FFDC60 Offset: 0x2FFDD61 VA: 0x2FFDC60
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x3001350 Offset: 0x3001451 VA: 0x3001350
	|-Dictionary<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x3004E90 Offset: 0x3004F91 VA: 0x3004E90
	|-Dictionary<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x30085C0 Offset: 0x30086C1 VA: 0x30085C0
	|-Dictionary<object, OrderSaveData>..ctor
	|
	|-RVA: 0x300C110 Offset: 0x300C211 VA: 0x300C110
	|-Dictionary<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2DDD820 Offset: 0x2DDD921 VA: 0x2DDD820
	|-Dictionary<object, Parameter>..ctor
	|
	|-RVA: 0x2DE1450 Offset: 0x2DE1551 VA: 0x2DE1450
	|-Dictionary<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2DE4B20 Offset: 0x2DE4C21 VA: 0x2DE4B20
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x2DE8200 Offset: 0x2DE8301 VA: 0x2DE8200
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x2DEB8C0 Offset: 0x2DEB9C1 VA: 0x2DEB8C0
	|-Dictionary<object, char>..ctor
	|
	|-RVA: 0x2DEEF80 Offset: 0x2DEF081 VA: 0x2DEEF80
	|-Dictionary<object, DateTime>..ctor
	|
	|-RVA: 0x2DF2630 Offset: 0x2DF2731 VA: 0x2DF2630
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x2DF5CF0 Offset: 0x2DF5DF1 VA: 0x2DF5CF0
	|-Dictionary<object, short>..ctor
	|
	|-RVA: 0x2DF93B0 Offset: 0x2DF94B1 VA: 0x2DF93B0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x30B8970 Offset: 0x30B8A71 VA: 0x30B8970
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x30BC030 Offset: 0x30BC131 VA: 0x30BC030
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x30BF6E0 Offset: 0x30BF7E1 VA: 0x30BF6E0
	|-Dictionary<object, Memory<object>>..ctor
	|
	|-RVA: 0x30C2E00 Offset: 0x30C2F01 VA: 0x30C2E00
	|-Dictionary<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x30C65A0 Offset: 0x30C66A1 VA: 0x30C65A0
	|-Dictionary<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x30CA200 Offset: 0x30CA301 VA: 0x30CA200
	|-Dictionary<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x30CDE60 Offset: 0x30CDF61 VA: 0x30CDE60
	|-Dictionary<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x30D1600 Offset: 0x30D1701 VA: 0x30D1600
	|-Dictionary<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x300FB40 Offset: 0x300FC41 VA: 0x300FB40
	|-Dictionary<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x3013390 Offset: 0x3013491 VA: 0x3013390
	|-Dictionary<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3016E80 Offset: 0x3016F81 VA: 0x3016E80
	|-Dictionary<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x301A9B0 Offset: 0x301AAB1 VA: 0x301A9B0
	|-Dictionary<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x301E150 Offset: 0x301E251 VA: 0x301E150
	|-Dictionary<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3022150 Offset: 0x3022251 VA: 0x3022150
	|-Dictionary<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3025C50 Offset: 0x3025D51 VA: 0x3025C50
	|-Dictionary<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x30294A0 Offset: 0x30295A1 VA: 0x30294A0
	|-Dictionary<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2FD6A80 Offset: 0x2FD6B81 VA: 0x2FD6A80
	|-Dictionary<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2FDA580 Offset: 0x2FDA681 VA: 0x2FDA580
	|-Dictionary<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2FDDDD0 Offset: 0x2FDDED1 VA: 0x2FDDDD0
	|-Dictionary<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2FE1620 Offset: 0x2FE1721 VA: 0x2FE1620
	|-Dictionary<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2FE4E10 Offset: 0x2FE4F11 VA: 0x2FE4E10
	|-Dictionary<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2FE8600 Offset: 0x2FE8701 VA: 0x2FE8600
	|-Dictionary<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2FEC100 Offset: 0x2FEC201 VA: 0x2FEC100
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x2FEF700 Offset: 0x2FEF801 VA: 0x2FEF700
	|-Dictionary<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2DBE1B0 Offset: 0x2DBE2B1 VA: 0x2DBE1B0
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2DC18D0 Offset: 0x2DC19D1 VA: 0x2DC18D0
	|-Dictionary<object, sbyte>..ctor
	|
	|-RVA: 0x2DC4F90 Offset: 0x2DC5091 VA: 0x2DC4F90
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x2DC8650 Offset: 0x2DC8751 VA: 0x2DC8650
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x2DCBD10 Offset: 0x2DCBE11 VA: 0x2DCBD10
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x2DCF3D0 Offset: 0x2DCF4D1 VA: 0x2DCF3D0
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x2DD2A80 Offset: 0x2DD2B81 VA: 0x2DD2A80
	|-Dictionary<object, TransitionTables>..ctor
	|
	|-RVA: 0x2DD64A0 Offset: 0x2DD65A1 VA: 0x2DD64A0
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x2DD9E60 Offset: 0x2DD9F61 VA: 0x2DD9E60
	|-Dictionary<object, BoundsInt>..ctor
	|
	|-RVA: 0x30D5100 Offset: 0x30D5201 VA: 0x30D5100
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x30D87C0 Offset: 0x30D88C1 VA: 0x30D87C0
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x30DBEE0 Offset: 0x30DBFE1 VA: 0x30DBEE0
	|-Dictionary<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x30DF5D0 Offset: 0x30DF6D1 VA: 0x30DF5D0
	|-Dictionary<object, GradientColorKey>..ctor
	|
	|-RVA: 0x30E2FA0 Offset: 0x30E30A1 VA: 0x30E2FA0
	|-Dictionary<object, Keyframe>..ctor
	|
	|-RVA: 0x30E6AE0 Offset: 0x30E6BE1 VA: 0x30E6AE0
	|-Dictionary<object, LayerMask>..ctor
	|
	|-RVA: 0x30EA1A0 Offset: 0x30EA2A1 VA: 0x30EA1A0
	|-Dictionary<object, Matrix4x4>..ctor
	|
	|-RVA: 0x30EDE50 Offset: 0x30EDF51 VA: 0x30EDE50
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x309CC50 Offset: 0x309CD51 VA: 0x309CC50
	|-Dictionary<object, Quaternion>..ctor
	|
	|-RVA: 0x30A0370 Offset: 0x30A0471 VA: 0x30A0370
	|-Dictionary<object, RangeInt>..ctor
	|
	|-RVA: 0x30A3A20 Offset: 0x30A3B21 VA: 0x30A3A20
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x30A7140 Offset: 0x30A7241 VA: 0x30A7140
	|-Dictionary<object, RectInt>..ctor
	|
	|-RVA: 0x30AA830 Offset: 0x30AA931 VA: 0x30AA830
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x30AE200 Offset: 0x30AE301 VA: 0x30AE200
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x30B1BD0 Offset: 0x30B1CD1 VA: 0x30B1BD0
	|-Dictionary<object, Vector2>..ctor
	|
	|-RVA: 0x30B52C0 Offset: 0x30B53C1 VA: 0x30B52C0
	|-Dictionary<object, Vector2Int>..ctor
	|
	|-RVA: 0x3080F50 Offset: 0x3081051 VA: 0x3080F50
	|-Dictionary<object, Vector3>..ctor
	|
	|-RVA: 0x3084660 Offset: 0x3084761 VA: 0x3084660
	|-Dictionary<object, Vector3Int>..ctor
	|
	|-RVA: 0x3087D90 Offset: 0x3087E91 VA: 0x3087D90
	|-Dictionary<object, Vector4>..ctor
	|
	|-RVA: 0x308B4B0 Offset: 0x308B5B1 VA: 0x308B4B0
	|-Dictionary<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x308EB40 Offset: 0x308EC41 VA: 0x308EB40
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x30921D0 Offset: 0x30922D1 VA: 0x30921D0
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x30957F0 Offset: 0x30958F1 VA: 0x30957F0
	|-Dictionary<float, CurveSample>..ctor
	|
	|-RVA: 0x3099640 Offset: 0x3099741 VA: 0x3099640
	|-Dictionary<float, object>..ctor
	|
	|-RVA: 0x319CBA0 Offset: 0x319CCA1 VA: 0x319CBA0
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x31A01C0 Offset: 0x31A02C1 VA: 0x31A01C0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x31A3780 Offset: 0x31A3881 VA: 0x31A3780
	|-Dictionary<uint, Int32Enum>..ctor
	|
	|-RVA: 0x31A6D40 Offset: 0x31A6E41 VA: 0x31A6D40
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x31AA360 Offset: 0x31AA461 VA: 0x31AA360
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x31AD980 Offset: 0x31ADA81 VA: 0x31AD980
	|-Dictionary<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x31B0FF0 Offset: 0x31B10F1 VA: 0x31B0FF0
	|-Dictionary<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x31B4BA0 Offset: 0x31B4CA1 VA: 0x31B4BA0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x302CFA0 Offset: 0x302D0A1 VA: 0x302CFA0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x3030950 Offset: 0x3030A51 VA: 0x3030950
	|-Dictionary<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x3033FE0 Offset: 0x30340E1 VA: 0x3033FE0
	|-Dictionary<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x3037600 Offset: 0x3037701 VA: 0x3037600
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x303B130 Offset: 0x303B231 VA: 0x303B130
	|-Dictionary<BoundsInt, object>..ctor
	|
	|-RVA: 0x303EC60 Offset: 0x303ED61 VA: 0x303EC60
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x30423C0 Offset: 0x30424C1 VA: 0x30423C0
	|-Dictionary<Color32, object>..ctor
	|
	|-RVA: 0x3045A20 Offset: 0x3045B21 VA: 0x3045A20
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x3064550 Offset: 0x3064651 VA: 0x3064550
	|-Dictionary<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x3067BD0 Offset: 0x3067CD1 VA: 0x3067BD0
	|-Dictionary<GradientColorKey, object>..ctor
	|
	|-RVA: 0x306B700 Offset: 0x306B801 VA: 0x306B700
	|-Dictionary<Keyframe, object>..ctor
	|
	|-RVA: 0x306F480 Offset: 0x306F581 VA: 0x306F480
	|-Dictionary<LayerMask, object>..ctor
	|
	|-RVA: 0x3072AE0 Offset: 0x3072BE1 VA: 0x3072AE0
	|-Dictionary<Matrix4x4, object>..ctor
	|
	|-RVA: 0x3076AE0 Offset: 0x3076BE1 VA: 0x3076AE0
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x307A1D0 Offset: 0x307A2D1 VA: 0x307A1D0
	|-Dictionary<Quaternion, object>..ctor
	|
	|-RVA: 0x307D930 Offset: 0x307DA31 VA: 0x307D930
	|-Dictionary<RangeInt, object>..ctor
	|
	|-RVA: 0x3049040 Offset: 0x3049141 VA: 0x3049040
	|-Dictionary<Rect, object>..ctor
	|
	|-RVA: 0x304C7A0 Offset: 0x304C8A1 VA: 0x304C7A0
	|-Dictionary<RectInt, object>..ctor
	|
	|-RVA: 0x304FE20 Offset: 0x304FF21 VA: 0x304FE20
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x3053490 Offset: 0x3053591 VA: 0x3053490
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x3056AB0 Offset: 0x3056BB1 VA: 0x3056AB0
	|-Dictionary<Vector2, object>..ctor
	|
	|-RVA: 0x305A130 Offset: 0x305A231 VA: 0x305A130
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x305D750 Offset: 0x305D851 VA: 0x305D750
	|-Dictionary<Vector3, object>..ctor
	|
	|-RVA: 0x3060E40 Offset: 0x3060F41 VA: 0x3060E40
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x2E3A830 Offset: 0x2E3A931 VA: 0x2E3A830
	|-Dictionary<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16310 Offset: 0x2A16411 VA: 0x2A16310
	|-Dictionary<JSONDeserialization.TaskField, object>..ctor
	|
	|-RVA: 0x2A199A0 Offset: 0x2A19AA1 VA: 0x2A199A0
	|-Dictionary<BitVector32Int, object>..ctor
	|
	|-RVA: 0x2F78700 Offset: 0x2F78801 VA: 0x2F78700
	|-Dictionary<EventCheckId, object>..ctor
	|
	|-RVA: 0x2F7C230 Offset: 0x2F7C331 VA: 0x2F7C230
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>..ctor
	|
	|-RVA: 0x2F80300 Offset: 0x2F80401 VA: 0x2F80300
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>..ctor
	|
	|-RVA: 0x2F83E30 Offset: 0x2F83F31 VA: 0x2F83E30
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>..ctor
	|
	|-RVA: 0x2F87540 Offset: 0x2F87641 VA: 0x2F87540
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>..ctor
	|
	|-RVA: 0x2F8ABC0 Offset: 0x2F8ACC1 VA: 0x2F8ABC0
	|-Dictionary<MonsterHutSaveData, object>..ctor
	|
	|-RVA: 0x2F8E950 Offset: 0x2F8EA51 VA: 0x2F8E950
	|-Dictionary<OrderLotterySaveParameter, object>..ctor
	|
	|-RVA: 0x2F92060 Offset: 0x2F92161 VA: 0x2F92060
	|-Dictionary<OrderSaveData, object>..ctor
	|
	|-RVA: 0x2D80170 Offset: 0x2D80271 VA: 0x2D80170
	|-Dictionary<OrderSaveParameter, object>..ctor
	|
	|-RVA: 0x2D83CD0 Offset: 0x2D83DD1 VA: 0x2D83CD0
	|-Dictionary<Parameter, object>..ctor
	|
	|-RVA: 0x2D87A40 Offset: 0x2D87B41 VA: 0x2D87A40
	|-Dictionary<bool, object>..ctor
	|
	|-RVA: 0x2D8B0C0 Offset: 0x2D8B1C1 VA: 0x2D8B0C0
	|-Dictionary<byte, object>..ctor
	|
	|-RVA: 0x2D8E6E0 Offset: 0x2D8E7E1 VA: 0x2D8E6E0
	|-Dictionary<char, object>..ctor
	|
	|-RVA: 0x2D91D00 Offset: 0x2D91E01 VA: 0x2D91D00
	|-Dictionary<DateTime, object>..ctor
	|
	|-RVA: 0x2D95320 Offset: 0x2D95421 VA: 0x2D95320
	|-Dictionary<double, object>..ctor
	|
	|-RVA: 0x2D98930 Offset: 0x2D98A31 VA: 0x2D98930
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x2D9BFB0 Offset: 0x2D9C0B1 VA: 0x2D9BFB0
	|-Dictionary<short, object>..ctor
	|
	|-RVA: 0x2D3A180 Offset: 0x2D3A281 VA: 0x2D3A180
	|-Dictionary<int, CropDataTable>..ctor
	|
	|-RVA: 0x2D3DD80 Offset: 0x2D3DE81 VA: 0x2D3DD80
	|-Dictionary<int, EffectDataTable>..ctor
	|
	|-RVA: 0x2D416F0 Offset: 0x2D417F1 VA: 0x2D416F0
	|-Dictionary<int, GimmickLayoutDataTable>..ctor
	|
	|-RVA: 0x2D44CC0 Offset: 0x2D44DC1 VA: 0x2D44CC0
	|-Dictionary<int, MineTypeDataTable>..ctor
	|
	|-RVA: 0x2D48990 Offset: 0x2D48A91 VA: 0x2D48990
	|-Dictionary<int, MiningDataTable>..ctor
	|
	|-RVA: 0x2D4C060 Offset: 0x2D4C161 VA: 0x2D4C060
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x2D4F640 Offset: 0x2D4F741 VA: 0x2D4F640
	|-Dictionary<int, char>..ctor
	|
	|-RVA: 0x2D52C00 Offset: 0x2D52D01 VA: 0x2D52C00
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x2D561C0 Offset: 0x2D562C1 VA: 0x2D561C0
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x2F5C2C0 Offset: 0x2F5C3C1 VA: 0x2F5C2C0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x2F5F950 Offset: 0x2F5FA51 VA: 0x2F5F950
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x2F62F70 Offset: 0x2F63071 VA: 0x2F62F70
	|-Dictionary<int, DiagnosticEvent>..ctor
	|
	|-RVA: 0x2F66A90 Offset: 0x2F66B91 VA: 0x2F66A90
	|-Dictionary<int, SceneInstance>..ctor
	|
	|-RVA: 0x2F6A160 Offset: 0x2F6A261 VA: 0x2F6A160
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x2F6D7E0 Offset: 0x2F6D8E1 VA: 0x2F6D7E0
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x2F70F30 Offset: 0x2F71031 VA: 0x2F70F30
	|-Dictionary<Int32Enum, MonsterDataTable>..ctor
	|
	|-RVA: 0x2F74BE0 Offset: 0x2F74CE1 VA: 0x2F74BE0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>..ctor
	|
	|-RVA: 0x2E1C120 Offset: 0x2E1C221 VA: 0x2E1C120
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>..ctor
	|
	|-RVA: 0x2E1F840 Offset: 0x2E1F941 VA: 0x2E1F840
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2E22E20 Offset: 0x2E22F21 VA: 0x2E22E20
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2E264A0 Offset: 0x2E265A1 VA: 0x2E264A0
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x2E29A60 Offset: 0x2E29B61 VA: 0x2E29A60
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2E2D020 Offset: 0x2E2D121 VA: 0x2E2D020
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x2E30640 Offset: 0x2E30741 VA: 0x2E30640
	|-Dictionary<Int32Enum, float>..ctor
	|
	|-RVA: 0x2E33C00 Offset: 0x2E33D01 VA: 0x2E33C00
	|-Dictionary<Int32Enum, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2E372D0 Offset: 0x2E373D1 VA: 0x2E372D0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>..ctor
	|
	|-RVA: 0x2F95DF0 Offset: 0x2F95EF1 VA: 0x2F95DF0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>..ctor
	|
	|-RVA: 0x2F99540 Offset: 0x2F99641 VA: 0x2F99540
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x2F9CB60 Offset: 0x2F9CC61 VA: 0x2F9CB60
	|-Dictionary<Memory<object>, object>..ctor
	|
	|-RVA: 0x2FA01F0 Offset: 0x2FA02F1 VA: 0x2FA01F0
	|-Dictionary<Nullable<Int32Enum>, object>..ctor
	|
	|-RVA: 0x2FA39D0 Offset: 0x2FA3AD1 VA: 0x2FA39D0
	|-Dictionary<Nullable<Bounds>, object>..ctor
	|
	|-RVA: 0x2FA7930 Offset: 0x2FA7A31 VA: 0x2FA7930
	|-Dictionary<Nullable<BoundsInt>, object>..ctor
	|
	|-RVA: 0x2FAB890 Offset: 0x2FAB991 VA: 0x2FAB890
	|-Dictionary<Nullable<Color32>, object>..ctor
	|
	|-RVA: 0x2FAF070 Offset: 0x2FAF171 VA: 0x2FAF070
	|-Dictionary<Nullable<Color>, object>..ctor
	|
	|-RVA: 0x2F1A160 Offset: 0x2F1A261 VA: 0x2F1A160
	|-Dictionary<Nullable<GradientAlphaKey>, object>..ctor
	|
	|-RVA: 0x2F1DA30 Offset: 0x2F1DB31 VA: 0x2F1DA30
	|-Dictionary<Nullable<GradientColorKey>, object>..ctor
	|
	|-RVA: 0x2F21730 Offset: 0x2F21831 VA: 0x2F21730
	|-Dictionary<Nullable<Keyframe>, object>..ctor
	|
	|-RVA: 0x2F25460 Offset: 0x2F25561 VA: 0x2F25460
	|-Dictionary<Nullable<LayerMask>, object>..ctor
	|
	|-RVA: 0x2F28C40 Offset: 0x2F28D41 VA: 0x2F28C40
	|-Dictionary<Nullable<Matrix4x4>, object>..ctor
	|
	|-RVA: 0x2F2D1B0 Offset: 0x2F2D2B1 VA: 0x2F2D1B0
	|-Dictionary<Nullable<Quaternion>, object>..ctor
	|
	|-RVA: 0x2F30EB0 Offset: 0x2F30FB1 VA: 0x2F30EB0
	|-Dictionary<Nullable<RangeInt>, object>..ctor
	|
	|-RVA: 0x2F34780 Offset: 0x2F34881 VA: 0x2F34780
	|-Dictionary<Nullable<Rect>, object>..ctor
	|
	|-RVA: 0x2EFD490 Offset: 0x2EFD591 VA: 0x2EFD490
	|-Dictionary<Nullable<RectInt>, object>..ctor
	|
	|-RVA: 0x2F01190 Offset: 0x2F01291 VA: 0x2F01190
	|-Dictionary<Nullable<Vector2>, object>..ctor
	|
	|-RVA: 0x2F04A60 Offset: 0x2F04B61 VA: 0x2F04A60
	|-Dictionary<Nullable<Vector2Int>, object>..ctor
	|
	|-RVA: 0x2F08330 Offset: 0x2F08431 VA: 0x2F08330
	|-Dictionary<Nullable<Vector3>, object>..ctor
	|
	|-RVA: 0x2F0BB70 Offset: 0x2F0BC71 VA: 0x2F0BB70
	|-Dictionary<Nullable<Vector3Int>, object>..ctor
	|
	|-RVA: 0x2F0F3B0 Offset: 0x2F0F4B1 VA: 0x2F0F3B0
	|-Dictionary<Nullable<Vector4>, object>..ctor
	|
	|-RVA: 0x2F130B0 Offset: 0x2F131B1 VA: 0x2F130B0
	|-Dictionary<object, BitVector32Int>..ctor
	|
	|-RVA: 0x2F16770 Offset: 0x2F16871 VA: 0x2F16770
	|-Dictionary<object, EventCheckId>..ctor
	|
	|-RVA: 0x2FF2F50 Offset: 0x2FF3051 VA: 0x2FF2F50
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>..ctor
	|
	|-RVA: 0x2FF6C90 Offset: 0x2FF6D91 VA: 0x2FF6C90
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>..ctor
	|
	|-RVA: 0x2FFA660 Offset: 0x2FFA761 VA: 0x2FFA660
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>..ctor
	|
	|-RVA: 0x2FFDD90 Offset: 0x2FFDE91 VA: 0x2FFDD90
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>..ctor
	|
	|-RVA: 0x3001480 Offset: 0x3001581 VA: 0x3001480
	|-Dictionary<object, MonsterHutSaveData>..ctor
	|
	|-RVA: 0x3004FC0 Offset: 0x30050C1 VA: 0x3004FC0
	|-Dictionary<object, OrderLotterySaveParameter>..ctor
	|
	|-RVA: 0x30086F0 Offset: 0x30087F1 VA: 0x30086F0
	|-Dictionary<object, OrderSaveData>..ctor
	|
	|-RVA: 0x300C240 Offset: 0x300C341 VA: 0x300C240
	|-Dictionary<object, OrderSaveParameter>..ctor
	|
	|-RVA: 0x2DDD950 Offset: 0x2DDDA51 VA: 0x2DDD950
	|-Dictionary<object, Parameter>..ctor
	|
	|-RVA: 0x2DE1580 Offset: 0x2DE1681 VA: 0x2DE1580
	|-Dictionary<object, NumberControl.ValueRange>..ctor
	|
	|-RVA: 0x2DE4C50 Offset: 0x2DE4D51 VA: 0x2DE4C50
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x2DE8330 Offset: 0x2DE8431 VA: 0x2DE8330
	|-Dictionary<object, byte>..ctor
	|
	|-RVA: 0x2DEB9F0 Offset: 0x2DEBAF1 VA: 0x2DEB9F0
	|-Dictionary<object, char>..ctor
	|
	|-RVA: 0x2DEF0B0 Offset: 0x2DEF1B1 VA: 0x2DEF0B0
	|-Dictionary<object, DateTime>..ctor
	|
	|-RVA: 0x2DF2760 Offset: 0x2DF2861 VA: 0x2DF2760
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x2DF5E20 Offset: 0x2DF5F21 VA: 0x2DF5E20
	|-Dictionary<object, short>..ctor
	|
	|-RVA: 0x2DF94E0 Offset: 0x2DF95E1 VA: 0x2DF94E0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x30B8AA0 Offset: 0x30B8BA1 VA: 0x30B8AA0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x30BC160 Offset: 0x30BC261 VA: 0x30BC160
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x30BF810 Offset: 0x30BF911 VA: 0x30BF810
	|-Dictionary<object, Memory<object>>..ctor
	|
	|-RVA: 0x30C2F30 Offset: 0x30C3031 VA: 0x30C2F30
	|-Dictionary<object, Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x30C66D0 Offset: 0x30C67D1 VA: 0x30C66D0
	|-Dictionary<object, Nullable<Bounds>>..ctor
	|
	|-RVA: 0x30CA330 Offset: 0x30CA431 VA: 0x30CA330
	|-Dictionary<object, Nullable<BoundsInt>>..ctor
	|
	|-RVA: 0x30CDF90 Offset: 0x30CE091 VA: 0x30CDF90
	|-Dictionary<object, Nullable<Color32>>..ctor
	|
	|-RVA: 0x30D1730 Offset: 0x30D1831 VA: 0x30D1730
	|-Dictionary<object, Nullable<Color>>..ctor
	|
	|-RVA: 0x300FC70 Offset: 0x300FD71 VA: 0x300FC70
	|-Dictionary<object, Nullable<GradientAlphaKey>>..ctor
	|
	|-RVA: 0x30134C0 Offset: 0x30135C1 VA: 0x30134C0
	|-Dictionary<object, Nullable<GradientColorKey>>..ctor
	|
	|-RVA: 0x3016FB0 Offset: 0x30170B1 VA: 0x3016FB0
	|-Dictionary<object, Nullable<Keyframe>>..ctor
	|
	|-RVA: 0x301AAE0 Offset: 0x301ABE1 VA: 0x301AAE0
	|-Dictionary<object, Nullable<LayerMask>>..ctor
	|
	|-RVA: 0x301E280 Offset: 0x301E381 VA: 0x301E280
	|-Dictionary<object, Nullable<Matrix4x4>>..ctor
	|
	|-RVA: 0x3022280 Offset: 0x3022381 VA: 0x3022280
	|-Dictionary<object, Nullable<Quaternion>>..ctor
	|
	|-RVA: 0x3025D80 Offset: 0x3025E81 VA: 0x3025D80
	|-Dictionary<object, Nullable<RangeInt>>..ctor
	|
	|-RVA: 0x30295D0 Offset: 0x30296D1 VA: 0x30295D0
	|-Dictionary<object, Nullable<Rect>>..ctor
	|
	|-RVA: 0x2FD6BB0 Offset: 0x2FD6CB1 VA: 0x2FD6BB0
	|-Dictionary<object, Nullable<RectInt>>..ctor
	|
	|-RVA: 0x2FDA6B0 Offset: 0x2FDA7B1 VA: 0x2FDA6B0
	|-Dictionary<object, Nullable<Vector2>>..ctor
	|
	|-RVA: 0x2FDDF00 Offset: 0x2FDE001 VA: 0x2FDDF00
	|-Dictionary<object, Nullable<Vector2Int>>..ctor
	|
	|-RVA: 0x2FE1750 Offset: 0x2FE1851 VA: 0x2FE1750
	|-Dictionary<object, Nullable<Vector3>>..ctor
	|
	|-RVA: 0x2FE4F40 Offset: 0x2FE5041 VA: 0x2FE4F40
	|-Dictionary<object, Nullable<Vector3Int>>..ctor
	|
	|-RVA: 0x2FE8730 Offset: 0x2FE8831 VA: 0x2FE8730
	|-Dictionary<object, Nullable<Vector4>>..ctor
	|
	|-RVA: 0x2FEC230 Offset: 0x2FEC331 VA: 0x2FEC230
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x2FEF830 Offset: 0x2FEF931 VA: 0x2FEF830
	|-Dictionary<object, ReadOnlyMemory<object>>..ctor
	|
	|-RVA: 0x2DBE2E0 Offset: 0x2DBE3E1 VA: 0x2DBE2E0
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2DC1A00 Offset: 0x2DC1B01 VA: 0x2DC1A00
	|-Dictionary<object, sbyte>..ctor
	|
	|-RVA: 0x2DC50C0 Offset: 0x2DC51C1 VA: 0x2DC50C0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x2DC8780 Offset: 0x2DC8881 VA: 0x2DC8780
	|-Dictionary<object, ushort>..ctor
	|
	|-RVA: 0x2DCBE40 Offset: 0x2DCBF41 VA: 0x2DCBE40
	|-Dictionary<object, uint>..ctor
	|
	|-RVA: 0x2DCF500 Offset: 0x2DCF601 VA: 0x2DCF500
	|-Dictionary<object, ulong>..ctor
	|
	|-RVA: 0x2DD2BB0 Offset: 0x2DD2CB1 VA: 0x2DD2BB0
	|-Dictionary<object, TransitionTables>..ctor
	|
	|-RVA: 0x2DD65D0 Offset: 0x2DD66D1 VA: 0x2DD65D0
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x2DD9F90 Offset: 0x2DDA091 VA: 0x2DD9F90
	|-Dictionary<object, BoundsInt>..ctor
	|
	|-RVA: 0x30D5230 Offset: 0x30D5331 VA: 0x30D5230
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x30D88F0 Offset: 0x30D89F1 VA: 0x30D88F0
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x30DC010 Offset: 0x30DC111 VA: 0x30DC010
	|-Dictionary<object, GradientAlphaKey>..ctor
	|
	|-RVA: 0x30DF700 Offset: 0x30DF801 VA: 0x30DF700
	|-Dictionary<object, GradientColorKey>..ctor
	|
	|-RVA: 0x30E30D0 Offset: 0x30E31D1 VA: 0x30E30D0
	|-Dictionary<object, Keyframe>..ctor
	|
	|-RVA: 0x30E6C10 Offset: 0x30E6D11 VA: 0x30E6C10
	|-Dictionary<object, LayerMask>..ctor
	|
	|-RVA: 0x30EA2D0 Offset: 0x30EA3D1 VA: 0x30EA2D0
	|-Dictionary<object, Matrix4x4>..ctor
	|
	|-RVA: 0x30EDF80 Offset: 0x30EE081 VA: 0x30EDF80
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x309CD80 Offset: 0x309CE81 VA: 0x309CD80
	|-Dictionary<object, Quaternion>..ctor
	|
	|-RVA: 0x30A04A0 Offset: 0x30A05A1 VA: 0x30A04A0
	|-Dictionary<object, RangeInt>..ctor
	|
	|-RVA: 0x30A3B50 Offset: 0x30A3C51 VA: 0x30A3B50
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x30A7270 Offset: 0x30A7371 VA: 0x30A7270
	|-Dictionary<object, RectInt>..ctor
	|
	|-RVA: 0x30AA960 Offset: 0x30AAA61 VA: 0x30AA960
	|-Dictionary<object, AsyncOperationHandle>..ctor
	|
	|-RVA: 0x30AE330 Offset: 0x30AE431 VA: 0x30AE330
	|-Dictionary<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x30B1D00 Offset: 0x30B1E01 VA: 0x30B1D00
	|-Dictionary<object, Vector2>..ctor
	|
	|-RVA: 0x30B53F0 Offset: 0x30B54F1 VA: 0x30B53F0
	|-Dictionary<object, Vector2Int>..ctor
	|
	|-RVA: 0x3081080 Offset: 0x3081181 VA: 0x3081080
	|-Dictionary<object, Vector3>..ctor
	|
	|-RVA: 0x3084790 Offset: 0x3084891 VA: 0x3084790
	|-Dictionary<object, Vector3Int>..ctor
	|
	|-RVA: 0x3087EC0 Offset: 0x3087FC1 VA: 0x3087EC0
	|-Dictionary<object, Vector4>..ctor
	|
	|-RVA: 0x308B5E0 Offset: 0x308B6E1 VA: 0x308B5E0
	|-Dictionary<ReadOnlyMemory<object>, object>..ctor
	|
	|-RVA: 0x308EC70 Offset: 0x308ED71 VA: 0x308EC70
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x3092300 Offset: 0x3092401 VA: 0x3092300
	|-Dictionary<sbyte, object>..ctor
	|
	|-RVA: 0x3095920 Offset: 0x3095A21 VA: 0x3095920
	|-Dictionary<float, CurveSample>..ctor
	|
	|-RVA: 0x3099770 Offset: 0x3099871 VA: 0x3099770
	|-Dictionary<float, object>..ctor
	|
	|-RVA: 0x319CCD0 Offset: 0x319CDD1 VA: 0x319CCD0
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x31A02F0 Offset: 0x31A03F1 VA: 0x31A02F0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x31A38B0 Offset: 0x31A39B1 VA: 0x31A38B0
	|-Dictionary<uint, Int32Enum>..ctor
	|
	|-RVA: 0x31A6E70 Offset: 0x31A6F71 VA: 0x31A6E70
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x31AA490 Offset: 0x31AA591 VA: 0x31AA490
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x31ADAB0 Offset: 0x31ADBB1 VA: 0x31ADAB0
	|-Dictionary<EdgeKeyByHash, int>..ctor
	|
	|-RVA: 0x31B1120 Offset: 0x31B1221 VA: 0x31B1120
	|-Dictionary<EdgeKeyByHash, CapEdge>..ctor
	|
	|-RVA: 0x31B4CD0 Offset: 0x31B4DD1 VA: 0x31B4CD0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>..ctor
	|
	|-RVA: 0x302D0D0 Offset: 0x302D1D1 VA: 0x302D0D0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>..ctor
	|
	|-RVA: 0x3030A80 Offset: 0x3030B81 VA: 0x3030A80
	|-Dictionary<MeshDataConnectivity.Face, bool>..ctor
	|
	|-RVA: 0x3034110 Offset: 0x3034211 VA: 0x3034110
	|-Dictionary<MeshDataConnectivity.Face, object>..ctor
	|
	|-RVA: 0x3037730 Offset: 0x3037831 VA: 0x3037730
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x303B260 Offset: 0x303B361 VA: 0x303B260
	|-Dictionary<BoundsInt, object>..ctor
	|
	|-RVA: 0x303ED90 Offset: 0x303EE91 VA: 0x303ED90
	|-Dictionary<Color, object>..ctor
	|
	|-RVA: 0x30424F0 Offset: 0x30425F1 VA: 0x30424F0
	|-Dictionary<Color32, object>..ctor
	|
	|-RVA: 0x3045B50 Offset: 0x3045C51 VA: 0x3045B50
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>..ctor
	|
	|-RVA: 0x3064680 Offset: 0x3064781 VA: 0x3064680
	|-Dictionary<GradientAlphaKey, object>..ctor
	|
	|-RVA: 0x3067D00 Offset: 0x3067E01 VA: 0x3067D00
	|-Dictionary<GradientColorKey, object>..ctor
	|
	|-RVA: 0x306B830 Offset: 0x306B931 VA: 0x306B830
	|-Dictionary<Keyframe, object>..ctor
	|
	|-RVA: 0x306F5B0 Offset: 0x306F6B1 VA: 0x306F5B0
	|-Dictionary<LayerMask, object>..ctor
	|
	|-RVA: 0x3072C10 Offset: 0x3072D11 VA: 0x3072C10
	|-Dictionary<Matrix4x4, object>..ctor
	|
	|-RVA: 0x3076C10 Offset: 0x3076D11 VA: 0x3076C10
	|-Dictionary<IntVec3, object>..ctor
	|
	|-RVA: 0x307A300 Offset: 0x307A401 VA: 0x307A300
	|-Dictionary<Quaternion, object>..ctor
	|
	|-RVA: 0x307DA60 Offset: 0x307DB61 VA: 0x307DA60
	|-Dictionary<RangeInt, object>..ctor
	|
	|-RVA: 0x3049170 Offset: 0x3049271 VA: 0x3049170
	|-Dictionary<Rect, object>..ctor
	|
	|-RVA: 0x304C8D0 Offset: 0x304C9D1 VA: 0x304C8D0
	|-Dictionary<RectInt, object>..ctor
	|
	|-RVA: 0x304FF50 Offset: 0x3050051 VA: 0x304FF50
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>..ctor
	|
	|-RVA: 0x30535C0 Offset: 0x30536C1 VA: 0x30535C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x3056BE0 Offset: 0x3056CE1 VA: 0x3056BE0
	|-Dictionary<Vector2, object>..ctor
	|
	|-RVA: 0x305A260 Offset: 0x305A361 VA: 0x305A260
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x305D880 Offset: 0x305D981 VA: 0x305D880
	|-Dictionary<Vector3, object>..ctor
	|
	|-RVA: 0x3060F70 Offset: 0x3061071 VA: 0x3060F70
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x2E3A960 Offset: 0x2E3AA61 VA: 0x2E3A960
	|-Dictionary<Vector4, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E2D130 Offset: 0x2E2D231 VA: 0x2E2D130
	|-Dictionary<BeanID, BeanData>.get_Count
	|-Dictionary<Int32Enum, object>.get_Count
	|
	|-RVA: 0x2FEC340 Offset: 0x2FEC441 VA: 0x2FEC340
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>.get_Count
	|-Dictionary<OptionDefinition, OptionsControlBase>.get_Count
	|-Dictionary<ParameterExpression, LocalVariable>.get_Count
	|-Dictionary<object, object>.get_Count
	|-Dictionary<string, WebConnectionGroup>.get_Count
	|-Dictionary<string, object>.get_Count
	|-Dictionary<string, string>.get_Count
	|-Dictionary<string, UriParser>.get_Count
	|-Dictionary<TimeParamTable, HashSet<Material>>.get_Count
	|-Dictionary<Font, HashSet<Text>>.get_Count
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.get_Count
	|
	|-RVA: 0x2A16420 Offset: 0x2A16521 VA: 0x2A16420
	|-Dictionary<JSONDeserialization.TaskField, List<int>>.get_Count
	|-Dictionary<JSONDeserialization.TaskField, object>.get_Count
	|
	|-RVA: 0x2A19AB0 Offset: 0x2A19BB1 VA: 0x2A19AB0
	|-Dictionary<BitVector32Int, object>.get_Count
	|
	|-RVA: 0x2DC51D0 Offset: 0x2DC52D1 VA: 0x2DC51D0
	|-Dictionary<Character, float>.get_Count
	|-Dictionary<object, float>.get_Count
	|
	|-RVA: 0x2E30750 Offset: 0x2E30851 VA: 0x2E30750
	|-Dictionary<ActorID, float>.get_Count
	|-Dictionary<AttackAttribute, float>.get_Count
	|-Dictionary<Int32Enum, float>.get_Count
	|
	|-RVA: 0x2E29B70 Offset: 0x2E29C71 VA: 0x2E29B70
	|-Dictionary<Season, Texture>.get_Count
	|-Dictionary<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x2F78810 Offset: 0x2F78911 VA: 0x2F78810
	|-Dictionary<EventCheckId, object>.get_Count
	|
	|-RVA: 0x2F7C340 Offset: 0x2F7C441 VA: 0x2F7C340
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.get_Count
	|
	|-RVA: 0x2F80410 Offset: 0x2F80511 VA: 0x2F80410
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.get_Count
	|
	|-RVA: 0x2F83F40 Offset: 0x2F84041 VA: 0x2F83F40
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.get_Count
	|
	|-RVA: 0x2F87650 Offset: 0x2F87751 VA: 0x2F87650
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.get_Count
	|
	|-RVA: 0x2DF95F0 Offset: 0x2DF96F1 VA: 0x2DF95F0
	|-Dictionary<MonsterControllerBase, int>.get_Count
	|-Dictionary<object, int>.get_Count
	|-Dictionary<string, int>.get_Count
	|
	|-RVA: 0x2F8ACD0 Offset: 0x2F8ADD1 VA: 0x2F8ACD0
	|-Dictionary<MonsterHutSaveData, object>.get_Count
	|
	|-RVA: 0x2F8EA60 Offset: 0x2F8EB61 VA: 0x2F8EA60
	|-Dictionary<OrderLotterySaveParameter, object>.get_Count
	|
	|-RVA: 0x2F92170 Offset: 0x2F92271 VA: 0x2F92170
	|-Dictionary<OrderSaveData, object>.get_Count
	|
	|-RVA: 0x2D80280 Offset: 0x2D80381 VA: 0x2D80280
	|-Dictionary<OrderSaveParameter, object>.get_Count
	|
	|-RVA: 0x2D83DE0 Offset: 0x2D83EE1 VA: 0x2D83DE0
	|-Dictionary<Parameter, object>.get_Count
	|
	|-RVA: 0x2D87B50 Offset: 0x2D87C51 VA: 0x2D87B50
	|-Dictionary<bool, object>.get_Count
	|
	|-RVA: 0x2D8B1D0 Offset: 0x2D8B2D1 VA: 0x2D8B1D0
	|-Dictionary<byte, object>.get_Count
	|
	|-RVA: 0x2D8E7F0 Offset: 0x2D8E8F1 VA: 0x2D8E7F0
	|-Dictionary<char, object>.get_Count
	|
	|-RVA: 0x2D91E10 Offset: 0x2D91F11 VA: 0x2D91E10
	|-Dictionary<DateTime, object>.get_Count
	|
	|-RVA: 0x2D95430 Offset: 0x2D95531 VA: 0x2D95430
	|-Dictionary<double, object>.get_Count
	|
	|-RVA: 0x2D98A40 Offset: 0x2D98B41 VA: 0x2D98A40
	|-Dictionary<Guid, object>.get_Count
	|
	|-RVA: 0x2D9C0C0 Offset: 0x2D9C1C1 VA: 0x2D9C0C0
	|-Dictionary<short, object>.get_Count
	|
	|-RVA: 0x2D3A290 Offset: 0x2D3A391 VA: 0x2D3A290
	|-Dictionary<int, CropDataTable>.get_Count
	|
	|-RVA: 0x2D3DE90 Offset: 0x2D3DF91 VA: 0x2D3DE90
	|-Dictionary<int, EffectDataTable>.get_Count
	|
	|-RVA: 0x2F5FA60 Offset: 0x2F5FB61 VA: 0x2F5FA60
	|-Dictionary<int, FishSwim>.get_Count
	|-Dictionary<int, HarinezumiController.NeedleController>.get_Count
	|-Dictionary<int, AssetHandle>.get_Count
	|-Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState>.get_Count
	|-Dictionary<int, Dictionary<int, List<OrderMasterData>>>.get_Count
	|-Dictionary<int, List<BossBehaviorParams>>.get_Count
	|-Dictionary<int, List<OrderMasterData>>.get_Count
	|-Dictionary<int, object>.get_Count
	|-Dictionary<int, TimeType>.get_Count
	|-Dictionary<int, TerrainUtility.TerrainMap>.get_Count
	|-Dictionary<int, IAsyncOperation>.get_Count
	|
	|-RVA: 0x2D41800 Offset: 0x2D41901 VA: 0x2D41800
	|-Dictionary<int, GimmickLayoutDataTable>.get_Count
	|
	|-RVA: 0x2D44DD0 Offset: 0x2D44ED1 VA: 0x2D44DD0
	|-Dictionary<int, MineTypeDataTable>.get_Count
	|
	|-RVA: 0x2D562D0 Offset: 0x2D563D1 VA: 0x2D562D0
	|-Dictionary<int, MineTypeID>.get_Count
	|-Dictionary<int, Int32Enum>.get_Count
	|
	|-RVA: 0x2D48AA0 Offset: 0x2D48BA1 VA: 0x2D48AA0
	|-Dictionary<int, MiningDataTable>.get_Count
	|
	|-RVA: 0x2D4C170 Offset: 0x2D4C271 VA: 0x2D4C170
	|-Dictionary<int, bool>.get_Count
	|
	|-RVA: 0x2D4F750 Offset: 0x2D4F851 VA: 0x2D4F750
	|-Dictionary<int, char>.get_Count
	|
	|-RVA: 0x2D52D10 Offset: 0x2D52E11 VA: 0x2D52D10
	|-Dictionary<int, int>.get_Count
	|
	|-RVA: 0x2F5C3D0 Offset: 0x2F5C4D1 VA: 0x2F5C3D0
	|-Dictionary<int, long>.get_Count
	|
	|-RVA: 0x2F63080 Offset: 0x2F63181 VA: 0x2F63080
	|-Dictionary<int, DiagnosticEvent>.get_Count
	|
	|-RVA: 0x2F66BA0 Offset: 0x2F66CA1 VA: 0x2F66BA0
	|-Dictionary<int, SceneInstance>.get_Count
	|
	|-RVA: 0x2F6A270 Offset: 0x2F6A371 VA: 0x2F6A270
	|-Dictionary<int, Vector2Int>.get_Count
	|
	|-RVA: 0x2F6D8F0 Offset: 0x2F6D9F1 VA: 0x2F6D8F0
	|-Dictionary<int, Vector3>.get_Count
	|
	|-RVA: 0x2F71040 Offset: 0x2F71141 VA: 0x2F71040
	|-Dictionary<Int32Enum, MonsterDataTable>.get_Count
	|
	|-RVA: 0x2F74CF0 Offset: 0x2F74DF1 VA: 0x2F74CF0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.get_Count
	|
	|-RVA: 0x2E1C230 Offset: 0x2E1C331 VA: 0x2E1C230
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Count
	|
	|-RVA: 0x2E1F950 Offset: 0x2E1FA51 VA: 0x2E1F950
	|-Dictionary<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x2E22F30 Offset: 0x2E23031 VA: 0x2E22F30
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x2E265B0 Offset: 0x2E266B1 VA: 0x2E265B0
	|-Dictionary<Int32Enum, int>.get_Count
	|
	|-RVA: 0x2E33D10 Offset: 0x2E33E11 VA: 0x2E33D10
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.get_Count
	|
	|-RVA: 0x2E373E0 Offset: 0x2E374E1 VA: 0x2E373E0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.get_Count
	|
	|-RVA: 0x2F95F00 Offset: 0x2F96001 VA: 0x2F95F00
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.get_Count
	|
	|-RVA: 0x2F99650 Offset: 0x2F99751 VA: 0x2F99650
	|-Dictionary<long, object>.get_Count
	|
	|-RVA: 0x2F9CC70 Offset: 0x2F9CD71 VA: 0x2F9CC70
	|-Dictionary<Memory<object>, object>.get_Count
	|
	|-RVA: 0x2FA0300 Offset: 0x2FA0401 VA: 0x2FA0300
	|-Dictionary<Nullable<Int32Enum>, object>.get_Count
	|
	|-RVA: 0x2FA3AE0 Offset: 0x2FA3BE1 VA: 0x2FA3AE0
	|-Dictionary<Nullable<Bounds>, object>.get_Count
	|
	|-RVA: 0x2FA7A40 Offset: 0x2FA7B41 VA: 0x2FA7A40
	|-Dictionary<Nullable<BoundsInt>, object>.get_Count
	|
	|-RVA: 0x2FAB9A0 Offset: 0x2FABAA1 VA: 0x2FAB9A0
	|-Dictionary<Nullable<Color32>, object>.get_Count
	|
	|-RVA: 0x2FAF180 Offset: 0x2FAF281 VA: 0x2FAF180
	|-Dictionary<Nullable<Color>, object>.get_Count
	|
	|-RVA: 0x2F1A270 Offset: 0x2F1A371 VA: 0x2F1A270
	|-Dictionary<Nullable<GradientAlphaKey>, object>.get_Count
	|
	|-RVA: 0x2F1DB40 Offset: 0x2F1DC41 VA: 0x2F1DB40
	|-Dictionary<Nullable<GradientColorKey>, object>.get_Count
	|
	|-RVA: 0x2F21840 Offset: 0x2F21941 VA: 0x2F21840
	|-Dictionary<Nullable<Keyframe>, object>.get_Count
	|
	|-RVA: 0x2F25570 Offset: 0x2F25671 VA: 0x2F25570
	|-Dictionary<Nullable<LayerMask>, object>.get_Count
	|
	|-RVA: 0x2F28D50 Offset: 0x2F28E51 VA: 0x2F28D50
	|-Dictionary<Nullable<Matrix4x4>, object>.get_Count
	|
	|-RVA: 0x2F2D2C0 Offset: 0x2F2D3C1 VA: 0x2F2D2C0
	|-Dictionary<Nullable<Quaternion>, object>.get_Count
	|
	|-RVA: 0x2F30FC0 Offset: 0x2F310C1 VA: 0x2F30FC0
	|-Dictionary<Nullable<RangeInt>, object>.get_Count
	|
	|-RVA: 0x2F34890 Offset: 0x2F34991 VA: 0x2F34890
	|-Dictionary<Nullable<Rect>, object>.get_Count
	|
	|-RVA: 0x2EFD5A0 Offset: 0x2EFD6A1 VA: 0x2EFD5A0
	|-Dictionary<Nullable<RectInt>, object>.get_Count
	|
	|-RVA: 0x2F012A0 Offset: 0x2F013A1 VA: 0x2F012A0
	|-Dictionary<Nullable<Vector2>, object>.get_Count
	|
	|-RVA: 0x2F04B70 Offset: 0x2F04C71 VA: 0x2F04B70
	|-Dictionary<Nullable<Vector2Int>, object>.get_Count
	|
	|-RVA: 0x2F08440 Offset: 0x2F08541 VA: 0x2F08440
	|-Dictionary<Nullable<Vector3>, object>.get_Count
	|
	|-RVA: 0x2F0BC80 Offset: 0x2F0BD81 VA: 0x2F0BC80
	|-Dictionary<Nullable<Vector3Int>, object>.get_Count
	|
	|-RVA: 0x2F0F4C0 Offset: 0x2F0F5C1 VA: 0x2F0F4C0
	|-Dictionary<Nullable<Vector4>, object>.get_Count
	|
	|-RVA: 0x2F131C0 Offset: 0x2F132C1 VA: 0x2F131C0
	|-Dictionary<object, BitVector32Int>.get_Count
	|
	|-RVA: 0x2F16880 Offset: 0x2F16981 VA: 0x2F16880
	|-Dictionary<object, EventCheckId>.get_Count
	|
	|-RVA: 0x2FF3060 Offset: 0x2FF3161 VA: 0x2FF3060
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.get_Count
	|
	|-RVA: 0x2FF6DA0 Offset: 0x2FF6EA1 VA: 0x2FF6DA0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.get_Count
	|
	|-RVA: 0x2FFA770 Offset: 0x2FFA871 VA: 0x2FFA770
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.get_Count
	|
	|-RVA: 0x2FFDEA0 Offset: 0x2FFDFA1 VA: 0x2FFDEA0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.get_Count
	|
	|-RVA: 0x3001590 Offset: 0x3001691 VA: 0x3001590
	|-Dictionary<object, MonsterHutSaveData>.get_Count
	|
	|-RVA: 0x30050D0 Offset: 0x30051D1 VA: 0x30050D0
	|-Dictionary<object, OrderLotterySaveParameter>.get_Count
	|
	|-RVA: 0x3008800 Offset: 0x3008901 VA: 0x3008800
	|-Dictionary<object, OrderSaveData>.get_Count
	|
	|-RVA: 0x300C350 Offset: 0x300C451 VA: 0x300C350
	|-Dictionary<object, OrderSaveParameter>.get_Count
	|
	|-RVA: 0x2DDDA60 Offset: 0x2DDDB61 VA: 0x2DDDA60
	|-Dictionary<object, Parameter>.get_Count
	|
	|-RVA: 0x2DE1690 Offset: 0x2DE1791 VA: 0x2DE1690
	|-Dictionary<object, NumberControl.ValueRange>.get_Count
	|
	|-RVA: 0x2DE4D60 Offset: 0x2DE4E61 VA: 0x2DE4D60
	|-Dictionary<object, bool>.get_Count
	|
	|-RVA: 0x2DE8440 Offset: 0x2DE8541 VA: 0x2DE8440
	|-Dictionary<object, byte>.get_Count
	|
	|-RVA: 0x2DEBB00 Offset: 0x2DEBC01 VA: 0x2DEBB00
	|-Dictionary<object, char>.get_Count
	|
	|-RVA: 0x2DEF1C0 Offset: 0x2DEF2C1 VA: 0x2DEF1C0
	|-Dictionary<object, DateTime>.get_Count
	|
	|-RVA: 0x2DF2870 Offset: 0x2DF2971 VA: 0x2DF2870
	|-Dictionary<object, double>.get_Count
	|
	|-RVA: 0x2DF5F30 Offset: 0x2DF6031 VA: 0x2DF5F30
	|-Dictionary<object, short>.get_Count
	|
	|-RVA: 0x30B8BB0 Offset: 0x30B8CB1 VA: 0x30B8BB0
	|-Dictionary<object, Int32Enum>.get_Count
	|
	|-RVA: 0x30BC270 Offset: 0x30BC371 VA: 0x30BC270
	|-Dictionary<object, long>.get_Count
	|
	|-RVA: 0x30BF920 Offset: 0x30BFA21 VA: 0x30BF920
	|-Dictionary<object, Memory<object>>.get_Count
	|
	|-RVA: 0x30C3040 Offset: 0x30C3141 VA: 0x30C3040
	|-Dictionary<object, Nullable<Int32Enum>>.get_Count
	|
	|-RVA: 0x30C67E0 Offset: 0x30C68E1 VA: 0x30C67E0
	|-Dictionary<object, Nullable<Bounds>>.get_Count
	|
	|-RVA: 0x30CA440 Offset: 0x30CA541 VA: 0x30CA440
	|-Dictionary<object, Nullable<BoundsInt>>.get_Count
	|
	|-RVA: 0x30CE0A0 Offset: 0x30CE1A1 VA: 0x30CE0A0
	|-Dictionary<object, Nullable<Color32>>.get_Count
	|
	|-RVA: 0x30D1840 Offset: 0x30D1941 VA: 0x30D1840
	|-Dictionary<object, Nullable<Color>>.get_Count
	|
	|-RVA: 0x300FD80 Offset: 0x300FE81 VA: 0x300FD80
	|-Dictionary<object, Nullable<GradientAlphaKey>>.get_Count
	|
	|-RVA: 0x30135D0 Offset: 0x30136D1 VA: 0x30135D0
	|-Dictionary<object, Nullable<GradientColorKey>>.get_Count
	|
	|-RVA: 0x30170C0 Offset: 0x30171C1 VA: 0x30170C0
	|-Dictionary<object, Nullable<Keyframe>>.get_Count
	|
	|-RVA: 0x301ABF0 Offset: 0x301ACF1 VA: 0x301ABF0
	|-Dictionary<object, Nullable<LayerMask>>.get_Count
	|
	|-RVA: 0x301E390 Offset: 0x301E491 VA: 0x301E390
	|-Dictionary<object, Nullable<Matrix4x4>>.get_Count
	|
	|-RVA: 0x3022390 Offset: 0x3022491 VA: 0x3022390
	|-Dictionary<object, Nullable<Quaternion>>.get_Count
	|
	|-RVA: 0x3025E90 Offset: 0x3025F91 VA: 0x3025E90
	|-Dictionary<object, Nullable<RangeInt>>.get_Count
	|
	|-RVA: 0x30296E0 Offset: 0x30297E1 VA: 0x30296E0
	|-Dictionary<object, Nullable<Rect>>.get_Count
	|
	|-RVA: 0x2FD6CC0 Offset: 0x2FD6DC1 VA: 0x2FD6CC0
	|-Dictionary<object, Nullable<RectInt>>.get_Count
	|
	|-RVA: 0x2FDA7C0 Offset: 0x2FDA8C1 VA: 0x2FDA7C0
	|-Dictionary<object, Nullable<Vector2>>.get_Count
	|
	|-RVA: 0x2FDE010 Offset: 0x2FDE111 VA: 0x2FDE010
	|-Dictionary<object, Nullable<Vector2Int>>.get_Count
	|
	|-RVA: 0x2FE1860 Offset: 0x2FE1961 VA: 0x2FE1860
	|-Dictionary<object, Nullable<Vector3>>.get_Count
	|
	|-RVA: 0x2FE5050 Offset: 0x2FE5151 VA: 0x2FE5050
	|-Dictionary<object, Nullable<Vector3Int>>.get_Count
	|
	|-RVA: 0x2FE8840 Offset: 0x2FE8941 VA: 0x2FE8840
	|-Dictionary<object, Nullable<Vector4>>.get_Count
	|
	|-RVA: 0x2FEF940 Offset: 0x2FEFA41 VA: 0x2FEF940
	|-Dictionary<object, ReadOnlyMemory<object>>.get_Count
	|
	|-RVA: 0x2DBE3F0 Offset: 0x2DBE4F1 VA: 0x2DBE3F0
	|-Dictionary<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x2DC1B10 Offset: 0x2DC1C11 VA: 0x2DC1B10
	|-Dictionary<object, sbyte>.get_Count
	|
	|-RVA: 0x2DC8890 Offset: 0x2DC8991 VA: 0x2DC8890
	|-Dictionary<object, ushort>.get_Count
	|
	|-RVA: 0x2DCBF50 Offset: 0x2DCC051 VA: 0x2DCBF50
	|-Dictionary<object, uint>.get_Count
	|
	|-RVA: 0x2DCF610 Offset: 0x2DCF711 VA: 0x2DCF610
	|-Dictionary<object, ulong>.get_Count
	|
	|-RVA: 0x2DD2CC0 Offset: 0x2DD2DC1 VA: 0x2DD2CC0
	|-Dictionary<object, TransitionTables>.get_Count
	|
	|-RVA: 0x2DD66E0 Offset: 0x2DD67E1 VA: 0x2DD66E0
	|-Dictionary<object, Bounds>.get_Count
	|
	|-RVA: 0x2DDA0A0 Offset: 0x2DDA1A1 VA: 0x2DDA0A0
	|-Dictionary<object, BoundsInt>.get_Count
	|
	|-RVA: 0x30D5340 Offset: 0x30D5441 VA: 0x30D5340
	|-Dictionary<object, Color32>.get_Count
	|
	|-RVA: 0x30D8A00 Offset: 0x30D8B01 VA: 0x30D8A00
	|-Dictionary<object, Color>.get_Count
	|
	|-RVA: 0x30DC120 Offset: 0x30DC221 VA: 0x30DC120
	|-Dictionary<object, GradientAlphaKey>.get_Count
	|
	|-RVA: 0x30DF810 Offset: 0x30DF911 VA: 0x30DF810
	|-Dictionary<object, GradientColorKey>.get_Count
	|
	|-RVA: 0x30E31E0 Offset: 0x30E32E1 VA: 0x30E31E0
	|-Dictionary<object, Keyframe>.get_Count
	|
	|-RVA: 0x30E6D20 Offset: 0x30E6E21 VA: 0x30E6D20
	|-Dictionary<object, LayerMask>.get_Count
	|
	|-RVA: 0x30EA3E0 Offset: 0x30EA4E1 VA: 0x30EA3E0
	|-Dictionary<object, Matrix4x4>.get_Count
	|
	|-RVA: 0x30EE090 Offset: 0x30EE191 VA: 0x30EE090
	|-Dictionary<object, Playable>.get_Count
	|
	|-RVA: 0x309CE90 Offset: 0x309CF91 VA: 0x309CE90
	|-Dictionary<object, Quaternion>.get_Count
	|
	|-RVA: 0x30A05B0 Offset: 0x30A06B1 VA: 0x30A05B0
	|-Dictionary<object, RangeInt>.get_Count
	|
	|-RVA: 0x30A3C60 Offset: 0x30A3D61 VA: 0x30A3C60
	|-Dictionary<object, Rect>.get_Count
	|
	|-RVA: 0x30A7380 Offset: 0x30A7481 VA: 0x30A7380
	|-Dictionary<object, RectInt>.get_Count
	|
	|-RVA: 0x30AAA70 Offset: 0x30AAB71 VA: 0x30AAA70
	|-Dictionary<object, AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x30AE440 Offset: 0x30AE541 VA: 0x30AE440
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x30B1E10 Offset: 0x30B1F11 VA: 0x30B1E10
	|-Dictionary<object, Vector2>.get_Count
	|
	|-RVA: 0x30B5500 Offset: 0x30B5601 VA: 0x30B5500
	|-Dictionary<object, Vector2Int>.get_Count
	|
	|-RVA: 0x3081190 Offset: 0x3081291 VA: 0x3081190
	|-Dictionary<object, Vector3>.get_Count
	|
	|-RVA: 0x30848A0 Offset: 0x30849A1 VA: 0x30848A0
	|-Dictionary<object, Vector3Int>.get_Count
	|
	|-RVA: 0x3087FD0 Offset: 0x30880D1 VA: 0x3087FD0
	|-Dictionary<object, Vector4>.get_Count
	|
	|-RVA: 0x308B6F0 Offset: 0x308B7F1 VA: 0x308B6F0
	|-Dictionary<ReadOnlyMemory<object>, object>.get_Count
	|
	|-RVA: 0x308ED80 Offset: 0x308EE81 VA: 0x308ED80
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Count
	|
	|-RVA: 0x3092410 Offset: 0x3092511 VA: 0x3092410
	|-Dictionary<sbyte, object>.get_Count
	|
	|-RVA: 0x3095A30 Offset: 0x3095B31 VA: 0x3095A30
	|-Dictionary<float, CurveSample>.get_Count
	|
	|-RVA: 0x3099880 Offset: 0x3099981 VA: 0x3099880
	|-Dictionary<float, object>.get_Count
	|
	|-RVA: 0x319CDE0 Offset: 0x319CEE1 VA: 0x319CDE0
	|-Dictionary<ushort, object>.get_Count
	|
	|-RVA: 0x31A6F80 Offset: 0x31A7081 VA: 0x31A6F80
	|-Dictionary<uint, TriangulationConstraint>.get_Count
	|-Dictionary<uint, object>.get_Count
	|
	|-RVA: 0x31A0400 Offset: 0x31A0501 VA: 0x31A0400
	|-Dictionary<uint, int>.get_Count
	|
	|-RVA: 0x31A39C0 Offset: 0x31A3AC1 VA: 0x31A39C0
	|-Dictionary<uint, Int32Enum>.get_Count
	|
	|-RVA: 0x31AA5A0 Offset: 0x31AA6A1 VA: 0x31AA5A0
	|-Dictionary<ulong, object>.get_Count
	|
	|-RVA: 0x31ADBC0 Offset: 0x31ADCC1 VA: 0x31ADBC0
	|-Dictionary<EdgeKeyByHash, int>.get_Count
	|
	|-RVA: 0x31B1230 Offset: 0x31B1331 VA: 0x31B1230
	|-Dictionary<EdgeKeyByHash, CapEdge>.get_Count
	|
	|-RVA: 0x31B4DE0 Offset: 0x31B4EE1 VA: 0x31B4DE0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Count
	|
	|-RVA: 0x302D1E0 Offset: 0x302D2E1 VA: 0x302D1E0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.get_Count
	|
	|-RVA: 0x3030B90 Offset: 0x3030C91 VA: 0x3030B90
	|-Dictionary<MeshDataConnectivity.Face, bool>.get_Count
	|
	|-RVA: 0x3034220 Offset: 0x3034321 VA: 0x3034220
	|-Dictionary<MeshDataConnectivity.Face, object>.get_Count
	|
	|-RVA: 0x3037840 Offset: 0x3037941 VA: 0x3037840
	|-Dictionary<Bounds, object>.get_Count
	|
	|-RVA: 0x303B370 Offset: 0x303B471 VA: 0x303B370
	|-Dictionary<BoundsInt, object>.get_Count
	|
	|-RVA: 0x303EEA0 Offset: 0x303EFA1 VA: 0x303EEA0
	|-Dictionary<Color, object>.get_Count
	|
	|-RVA: 0x3042600 Offset: 0x3042701 VA: 0x3042600
	|-Dictionary<Color32, object>.get_Count
	|
	|-RVA: 0x3045C60 Offset: 0x3045D61 VA: 0x3045C60
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Count
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Count
	|
	|-RVA: 0x3064790 Offset: 0x3064891 VA: 0x3064790
	|-Dictionary<GradientAlphaKey, object>.get_Count
	|
	|-RVA: 0x3067E10 Offset: 0x3067F11 VA: 0x3067E10
	|-Dictionary<GradientColorKey, object>.get_Count
	|
	|-RVA: 0x306B940 Offset: 0x306BA41 VA: 0x306B940
	|-Dictionary<Keyframe, object>.get_Count
	|
	|-RVA: 0x306F6C0 Offset: 0x306F7C1 VA: 0x306F6C0
	|-Dictionary<LayerMask, object>.get_Count
	|
	|-RVA: 0x3072D20 Offset: 0x3072E21 VA: 0x3072D20
	|-Dictionary<Matrix4x4, object>.get_Count
	|
	|-RVA: 0x3076D20 Offset: 0x3076E21 VA: 0x3076D20
	|-Dictionary<IntVec3, List<int>>.get_Count
	|-Dictionary<IntVec3, object>.get_Count
	|
	|-RVA: 0x307A410 Offset: 0x307A511 VA: 0x307A410
	|-Dictionary<Quaternion, object>.get_Count
	|
	|-RVA: 0x307DB70 Offset: 0x307DC71 VA: 0x307DB70
	|-Dictionary<RangeInt, object>.get_Count
	|
	|-RVA: 0x3049280 Offset: 0x3049381 VA: 0x3049280
	|-Dictionary<Rect, object>.get_Count
	|
	|-RVA: 0x304C9E0 Offset: 0x304CAE1 VA: 0x304C9E0
	|-Dictionary<RectInt, object>.get_Count
	|
	|-RVA: 0x3050060 Offset: 0x3050161 VA: 0x3050060
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.get_Count
	|
	|-RVA: 0x30536D0 Offset: 0x30537D1 VA: 0x30536D0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Count
	|
	|-RVA: 0x3056CF0 Offset: 0x3056DF1 VA: 0x3056CF0
	|-Dictionary<Vector2, object>.get_Count
	|
	|-RVA: 0x305A370 Offset: 0x305A471 VA: 0x305A370
	|-Dictionary<Vector2Int, object>.get_Count
	|
	|-RVA: 0x305D990 Offset: 0x305DA91 VA: 0x305D990
	|-Dictionary<Vector3, object>.get_Count
	|
	|-RVA: 0x3061080 Offset: 0x3061181 VA: 0x3061080
	|-Dictionary<Vector3Int, object>.get_Count
	|
	|-RVA: 0x2E3AA70 Offset: 0x2E3AB71 VA: 0x2E3AA70
	|-Dictionary<Vector4, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16430 Offset: 0x2A16531 VA: 0x2A16430
	|-Dictionary<JSONDeserialization.TaskField, List<int>>.get_Keys
	|-Dictionary<JSONDeserialization.TaskField, object>.get_Keys
	|
	|-RVA: 0x2FEC350 Offset: 0x2FEC451 VA: 0x2FEC350
	|-Dictionary<BinaryDeserialization.ObjectFieldMap, List<int>>.get_Keys
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.get_Keys
	|-Dictionary<OptionDefinition, OptionsControlBase>.get_Keys
	|-Dictionary<ParameterExpression, LocalVariable>.get_Keys
	|-Dictionary<object, IList<IResourceLocation>>.get_Keys
	|-Dictionary<string, BoolKeyframeGroup>.get_Keys
	|-Dictionary<string, ColorKeyframeGroup>.get_Keys
	|-Dictionary<string, IKeyframeGroup>.get_Keys
	|-Dictionary<string, NumberKeyframeGroup>.get_Keys
	|-Dictionary<string, SpherePointKeyframeGroup>.get_Keys
	|-Dictionary<string, TextureKeyframeGroup>.get_Keys
	|-Dictionary<string, IList<InfoEntry>>.get_Keys
	|-Dictionary<Collider, CharacterBase>.get_Keys
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.get_Keys
	|-Dictionary<object, object>.get_Keys
	|
	|-RVA: 0x2DC51E0 Offset: 0x2DC52E1 VA: 0x2DC51E0
	|-Dictionary<Character, float>.get_Keys
	|-Dictionary<object, float>.get_Keys
	|
	|-RVA: 0x2E2D140 Offset: 0x2E2D241 VA: 0x2E2D140
	|-Dictionary<ActorID, HumanStatusData>.get_Keys
	|-Dictionary<ActorID, ItemStorageData>.get_Keys
	|-Dictionary<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.get_Keys
	|-Dictionary<Int32Enum, object>.get_Keys
	|
	|-RVA: 0x2E30760 Offset: 0x2E30861 VA: 0x2E30760
	|-Dictionary<ActorID, float>.get_Keys
	|-Dictionary<Int32Enum, float>.get_Keys
	|
	|-RVA: 0x2E265C0 Offset: 0x2E266C1 VA: 0x2E265C0
	|-Dictionary<RF5SystemData.FLAG, int>.get_Keys
	|-Dictionary<Int32Enum, int>.get_Keys
	|
	|-RVA: 0x2F5FA70 Offset: 0x2F5FB71 VA: 0x2F5FA70
	|-Dictionary<int, Dictionary<int, List<OrderMasterData>>>.get_Keys
	|-Dictionary<int, List<OrderMasterData>>.get_Keys
	|-Dictionary<int, List<TimeManager.JustTimerData>>.get_Keys
	|-Dictionary<int, List<MeshDataConnectivity.Face>>.get_Keys
	|-Dictionary<int, object>.get_Keys
	|
	|-RVA: 0x30B8BC0 Offset: 0x30B8CC1 VA: 0x30B8BC0
	|-Dictionary<string, SystemLanguage>.get_Keys
	|-Dictionary<object, Int32Enum>.get_Keys
	|
	|-RVA: 0x31A6F90 Offset: 0x31A7091 VA: 0x31A6F90
	|-Dictionary<uint, FriendMonsterStatus>.get_Keys
	|-Dictionary<uint, object>.get_Keys
	|
	|-RVA: 0x3045C70 Offset: 0x3045D71 VA: 0x3045C70
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.get_Keys
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Keys
	|
	|-RVA: 0x2A19AC0 Offset: 0x2A19BC1 VA: 0x2A19AC0
	|-Dictionary<BitVector32Int, object>.get_Keys
	|
	|-RVA: 0x2F78820 Offset: 0x2F78921 VA: 0x2F78820
	|-Dictionary<EventCheckId, object>.get_Keys
	|
	|-RVA: 0x2F7C350 Offset: 0x2F7C451 VA: 0x2F7C350
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.get_Keys
	|
	|-RVA: 0x2F80420 Offset: 0x2F80521 VA: 0x2F80420
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.get_Keys
	|
	|-RVA: 0x2F83F50 Offset: 0x2F84051 VA: 0x2F83F50
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.get_Keys
	|
	|-RVA: 0x2F87660 Offset: 0x2F87761 VA: 0x2F87660
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.get_Keys
	|
	|-RVA: 0x2F8ACE0 Offset: 0x2F8ADE1 VA: 0x2F8ACE0
	|-Dictionary<MonsterHutSaveData, object>.get_Keys
	|
	|-RVA: 0x2F8EA70 Offset: 0x2F8EB71 VA: 0x2F8EA70
	|-Dictionary<OrderLotterySaveParameter, object>.get_Keys
	|
	|-RVA: 0x2F92180 Offset: 0x2F92281 VA: 0x2F92180
	|-Dictionary<OrderSaveData, object>.get_Keys
	|
	|-RVA: 0x2D80290 Offset: 0x2D80391 VA: 0x2D80290
	|-Dictionary<OrderSaveParameter, object>.get_Keys
	|
	|-RVA: 0x2D83DF0 Offset: 0x2D83EF1 VA: 0x2D83DF0
	|-Dictionary<Parameter, object>.get_Keys
	|
	|-RVA: 0x2D87B60 Offset: 0x2D87C61 VA: 0x2D87B60
	|-Dictionary<bool, object>.get_Keys
	|
	|-RVA: 0x2D8B1E0 Offset: 0x2D8B2E1 VA: 0x2D8B1E0
	|-Dictionary<byte, object>.get_Keys
	|
	|-RVA: 0x2D8E800 Offset: 0x2D8E901 VA: 0x2D8E800
	|-Dictionary<char, object>.get_Keys
	|
	|-RVA: 0x2D91E20 Offset: 0x2D91F21 VA: 0x2D91E20
	|-Dictionary<DateTime, object>.get_Keys
	|
	|-RVA: 0x2D95440 Offset: 0x2D95541 VA: 0x2D95440
	|-Dictionary<double, object>.get_Keys
	|
	|-RVA: 0x2D98A50 Offset: 0x2D98B51 VA: 0x2D98A50
	|-Dictionary<Guid, object>.get_Keys
	|
	|-RVA: 0x2D9C0D0 Offset: 0x2D9C1D1 VA: 0x2D9C0D0
	|-Dictionary<short, object>.get_Keys
	|
	|-RVA: 0x2D3A2A0 Offset: 0x2D3A3A1 VA: 0x2D3A2A0
	|-Dictionary<int, CropDataTable>.get_Keys
	|
	|-RVA: 0x2D3DEA0 Offset: 0x2D3DFA1 VA: 0x2D3DEA0
	|-Dictionary<int, EffectDataTable>.get_Keys
	|
	|-RVA: 0x2D41810 Offset: 0x2D41911 VA: 0x2D41810
	|-Dictionary<int, GimmickLayoutDataTable>.get_Keys
	|
	|-RVA: 0x2D44DE0 Offset: 0x2D44EE1 VA: 0x2D44DE0
	|-Dictionary<int, MineTypeDataTable>.get_Keys
	|
	|-RVA: 0x2D48AB0 Offset: 0x2D48BB1 VA: 0x2D48AB0
	|-Dictionary<int, MiningDataTable>.get_Keys
	|
	|-RVA: 0x2D4C180 Offset: 0x2D4C281 VA: 0x2D4C180
	|-Dictionary<int, bool>.get_Keys
	|
	|-RVA: 0x2D4F760 Offset: 0x2D4F861 VA: 0x2D4F760
	|-Dictionary<int, char>.get_Keys
	|
	|-RVA: 0x2D52D20 Offset: 0x2D52E21 VA: 0x2D52D20
	|-Dictionary<int, int>.get_Keys
	|
	|-RVA: 0x2D562E0 Offset: 0x2D563E1 VA: 0x2D562E0
	|-Dictionary<int, Int32Enum>.get_Keys
	|
	|-RVA: 0x2F5C3E0 Offset: 0x2F5C4E1 VA: 0x2F5C3E0
	|-Dictionary<int, long>.get_Keys
	|
	|-RVA: 0x2F63090 Offset: 0x2F63191 VA: 0x2F63090
	|-Dictionary<int, DiagnosticEvent>.get_Keys
	|
	|-RVA: 0x2F66BB0 Offset: 0x2F66CB1 VA: 0x2F66BB0
	|-Dictionary<int, SceneInstance>.get_Keys
	|
	|-RVA: 0x2F6A280 Offset: 0x2F6A381 VA: 0x2F6A280
	|-Dictionary<int, Vector2Int>.get_Keys
	|
	|-RVA: 0x2F6D900 Offset: 0x2F6DA01 VA: 0x2F6D900
	|-Dictionary<int, Vector3>.get_Keys
	|
	|-RVA: 0x2F71050 Offset: 0x2F71151 VA: 0x2F71050
	|-Dictionary<Int32Enum, MonsterDataTable>.get_Keys
	|
	|-RVA: 0x2F74D00 Offset: 0x2F74E01 VA: 0x2F74D00
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.get_Keys
	|
	|-RVA: 0x2E1C240 Offset: 0x2E1C341 VA: 0x2E1C240
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Keys
	|
	|-RVA: 0x2E1F960 Offset: 0x2E1FA61 VA: 0x2E1F960
	|-Dictionary<Int32Enum, bool>.get_Keys
	|
	|-RVA: 0x2E22F40 Offset: 0x2E23041 VA: 0x2E22F40
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Keys
	|
	|-RVA: 0x2E29B80 Offset: 0x2E29C81 VA: 0x2E29B80
	|-Dictionary<Int32Enum, Int32Enum>.get_Keys
	|
	|-RVA: 0x2E33D20 Offset: 0x2E33E21 VA: 0x2E33D20
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.get_Keys
	|
	|-RVA: 0x2E373F0 Offset: 0x2E374F1 VA: 0x2E373F0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.get_Keys
	|
	|-RVA: 0x2F95F10 Offset: 0x2F96011 VA: 0x2F95F10
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.get_Keys
	|
	|-RVA: 0x2F99660 Offset: 0x2F99761 VA: 0x2F99660
	|-Dictionary<long, object>.get_Keys
	|
	|-RVA: 0x2F9CC80 Offset: 0x2F9CD81 VA: 0x2F9CC80
	|-Dictionary<Memory<object>, object>.get_Keys
	|
	|-RVA: 0x2FA0310 Offset: 0x2FA0411 VA: 0x2FA0310
	|-Dictionary<Nullable<Int32Enum>, object>.get_Keys
	|
	|-RVA: 0x2FA3AF0 Offset: 0x2FA3BF1 VA: 0x2FA3AF0
	|-Dictionary<Nullable<Bounds>, object>.get_Keys
	|
	|-RVA: 0x2FA7A50 Offset: 0x2FA7B51 VA: 0x2FA7A50
	|-Dictionary<Nullable<BoundsInt>, object>.get_Keys
	|
	|-RVA: 0x2FAB9B0 Offset: 0x2FABAB1 VA: 0x2FAB9B0
	|-Dictionary<Nullable<Color32>, object>.get_Keys
	|
	|-RVA: 0x2FAF190 Offset: 0x2FAF291 VA: 0x2FAF190
	|-Dictionary<Nullable<Color>, object>.get_Keys
	|
	|-RVA: 0x2F1A280 Offset: 0x2F1A381 VA: 0x2F1A280
	|-Dictionary<Nullable<GradientAlphaKey>, object>.get_Keys
	|
	|-RVA: 0x2F1DB50 Offset: 0x2F1DC51 VA: 0x2F1DB50
	|-Dictionary<Nullable<GradientColorKey>, object>.get_Keys
	|
	|-RVA: 0x2F21850 Offset: 0x2F21951 VA: 0x2F21850
	|-Dictionary<Nullable<Keyframe>, object>.get_Keys
	|
	|-RVA: 0x2F25580 Offset: 0x2F25681 VA: 0x2F25580
	|-Dictionary<Nullable<LayerMask>, object>.get_Keys
	|
	|-RVA: 0x2F28D60 Offset: 0x2F28E61 VA: 0x2F28D60
	|-Dictionary<Nullable<Matrix4x4>, object>.get_Keys
	|
	|-RVA: 0x2F2D2D0 Offset: 0x2F2D3D1 VA: 0x2F2D2D0
	|-Dictionary<Nullable<Quaternion>, object>.get_Keys
	|
	|-RVA: 0x2F30FD0 Offset: 0x2F310D1 VA: 0x2F30FD0
	|-Dictionary<Nullable<RangeInt>, object>.get_Keys
	|
	|-RVA: 0x2F348A0 Offset: 0x2F349A1 VA: 0x2F348A0
	|-Dictionary<Nullable<Rect>, object>.get_Keys
	|
	|-RVA: 0x2EFD5B0 Offset: 0x2EFD6B1 VA: 0x2EFD5B0
	|-Dictionary<Nullable<RectInt>, object>.get_Keys
	|
	|-RVA: 0x2F012B0 Offset: 0x2F013B1 VA: 0x2F012B0
	|-Dictionary<Nullable<Vector2>, object>.get_Keys
	|
	|-RVA: 0x2F04B80 Offset: 0x2F04C81 VA: 0x2F04B80
	|-Dictionary<Nullable<Vector2Int>, object>.get_Keys
	|
	|-RVA: 0x2F08450 Offset: 0x2F08551 VA: 0x2F08450
	|-Dictionary<Nullable<Vector3>, object>.get_Keys
	|
	|-RVA: 0x2F0BC90 Offset: 0x2F0BD91 VA: 0x2F0BC90
	|-Dictionary<Nullable<Vector3Int>, object>.get_Keys
	|
	|-RVA: 0x2F0F4D0 Offset: 0x2F0F5D1 VA: 0x2F0F4D0
	|-Dictionary<Nullable<Vector4>, object>.get_Keys
	|
	|-RVA: 0x2F131D0 Offset: 0x2F132D1 VA: 0x2F131D0
	|-Dictionary<object, BitVector32Int>.get_Keys
	|
	|-RVA: 0x2F16890 Offset: 0x2F16991 VA: 0x2F16890
	|-Dictionary<object, EventCheckId>.get_Keys
	|
	|-RVA: 0x2FF3070 Offset: 0x2FF3171 VA: 0x2FF3070
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.get_Keys
	|
	|-RVA: 0x2FF6DB0 Offset: 0x2FF6EB1 VA: 0x2FF6DB0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.get_Keys
	|
	|-RVA: 0x2FFA780 Offset: 0x2FFA881 VA: 0x2FFA780
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.get_Keys
	|
	|-RVA: 0x2FFDEB0 Offset: 0x2FFDFB1 VA: 0x2FFDEB0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.get_Keys
	|
	|-RVA: 0x30015A0 Offset: 0x30016A1 VA: 0x30015A0
	|-Dictionary<object, MonsterHutSaveData>.get_Keys
	|
	|-RVA: 0x30050E0 Offset: 0x30051E1 VA: 0x30050E0
	|-Dictionary<object, OrderLotterySaveParameter>.get_Keys
	|
	|-RVA: 0x3008810 Offset: 0x3008911 VA: 0x3008810
	|-Dictionary<object, OrderSaveData>.get_Keys
	|
	|-RVA: 0x300C360 Offset: 0x300C461 VA: 0x300C360
	|-Dictionary<object, OrderSaveParameter>.get_Keys
	|
	|-RVA: 0x2DDDA70 Offset: 0x2DDDB71 VA: 0x2DDDA70
	|-Dictionary<object, Parameter>.get_Keys
	|
	|-RVA: 0x2DE16A0 Offset: 0x2DE17A1 VA: 0x2DE16A0
	|-Dictionary<object, NumberControl.ValueRange>.get_Keys
	|
	|-RVA: 0x2DE4D70 Offset: 0x2DE4E71 VA: 0x2DE4D70
	|-Dictionary<object, bool>.get_Keys
	|
	|-RVA: 0x2DE8450 Offset: 0x2DE8551 VA: 0x2DE8450
	|-Dictionary<object, byte>.get_Keys
	|
	|-RVA: 0x2DEBB10 Offset: 0x2DEBC11 VA: 0x2DEBB10
	|-Dictionary<object, char>.get_Keys
	|
	|-RVA: 0x2DEF1D0 Offset: 0x2DEF2D1 VA: 0x2DEF1D0
	|-Dictionary<object, DateTime>.get_Keys
	|
	|-RVA: 0x2DF2880 Offset: 0x2DF2981 VA: 0x2DF2880
	|-Dictionary<object, double>.get_Keys
	|
	|-RVA: 0x2DF5F40 Offset: 0x2DF6041 VA: 0x2DF5F40
	|-Dictionary<object, short>.get_Keys
	|
	|-RVA: 0x2DF9600 Offset: 0x2DF9701 VA: 0x2DF9600
	|-Dictionary<object, int>.get_Keys
	|
	|-RVA: 0x30BC280 Offset: 0x30BC381 VA: 0x30BC280
	|-Dictionary<object, long>.get_Keys
	|
	|-RVA: 0x30BF930 Offset: 0x30BFA31 VA: 0x30BF930
	|-Dictionary<object, Memory<object>>.get_Keys
	|
	|-RVA: 0x30C3050 Offset: 0x30C3151 VA: 0x30C3050
	|-Dictionary<object, Nullable<Int32Enum>>.get_Keys
	|
	|-RVA: 0x30C67F0 Offset: 0x30C68F1 VA: 0x30C67F0
	|-Dictionary<object, Nullable<Bounds>>.get_Keys
	|
	|-RVA: 0x30CA450 Offset: 0x30CA551 VA: 0x30CA450
	|-Dictionary<object, Nullable<BoundsInt>>.get_Keys
	|
	|-RVA: 0x30CE0B0 Offset: 0x30CE1B1 VA: 0x30CE0B0
	|-Dictionary<object, Nullable<Color32>>.get_Keys
	|
	|-RVA: 0x30D1850 Offset: 0x30D1951 VA: 0x30D1850
	|-Dictionary<object, Nullable<Color>>.get_Keys
	|
	|-RVA: 0x300FD90 Offset: 0x300FE91 VA: 0x300FD90
	|-Dictionary<object, Nullable<GradientAlphaKey>>.get_Keys
	|
	|-RVA: 0x30135E0 Offset: 0x30136E1 VA: 0x30135E0
	|-Dictionary<object, Nullable<GradientColorKey>>.get_Keys
	|
	|-RVA: 0x30170D0 Offset: 0x30171D1 VA: 0x30170D0
	|-Dictionary<object, Nullable<Keyframe>>.get_Keys
	|
	|-RVA: 0x301AC00 Offset: 0x301AD01 VA: 0x301AC00
	|-Dictionary<object, Nullable<LayerMask>>.get_Keys
	|
	|-RVA: 0x301E3A0 Offset: 0x301E4A1 VA: 0x301E3A0
	|-Dictionary<object, Nullable<Matrix4x4>>.get_Keys
	|
	|-RVA: 0x30223A0 Offset: 0x30224A1 VA: 0x30223A0
	|-Dictionary<object, Nullable<Quaternion>>.get_Keys
	|
	|-RVA: 0x3025EA0 Offset: 0x3025FA1 VA: 0x3025EA0
	|-Dictionary<object, Nullable<RangeInt>>.get_Keys
	|
	|-RVA: 0x30296F0 Offset: 0x30297F1 VA: 0x30296F0
	|-Dictionary<object, Nullable<Rect>>.get_Keys
	|
	|-RVA: 0x2FD6CD0 Offset: 0x2FD6DD1 VA: 0x2FD6CD0
	|-Dictionary<object, Nullable<RectInt>>.get_Keys
	|
	|-RVA: 0x2FDA7D0 Offset: 0x2FDA8D1 VA: 0x2FDA7D0
	|-Dictionary<object, Nullable<Vector2>>.get_Keys
	|
	|-RVA: 0x2FDE020 Offset: 0x2FDE121 VA: 0x2FDE020
	|-Dictionary<object, Nullable<Vector2Int>>.get_Keys
	|
	|-RVA: 0x2FE1870 Offset: 0x2FE1971 VA: 0x2FE1870
	|-Dictionary<object, Nullable<Vector3>>.get_Keys
	|
	|-RVA: 0x2FE5060 Offset: 0x2FE5161 VA: 0x2FE5060
	|-Dictionary<object, Nullable<Vector3Int>>.get_Keys
	|
	|-RVA: 0x2FE8850 Offset: 0x2FE8951 VA: 0x2FE8850
	|-Dictionary<object, Nullable<Vector4>>.get_Keys
	|
	|-RVA: 0x2FEF950 Offset: 0x2FEFA51 VA: 0x2FEF950
	|-Dictionary<object, ReadOnlyMemory<object>>.get_Keys
	|
	|-RVA: 0x2DBE400 Offset: 0x2DBE501 VA: 0x2DBE400
	|-Dictionary<object, ResourceLocator>.get_Keys
	|
	|-RVA: 0x2DC1B20 Offset: 0x2DC1C21 VA: 0x2DC1B20
	|-Dictionary<object, sbyte>.get_Keys
	|
	|-RVA: 0x2DC88A0 Offset: 0x2DC89A1 VA: 0x2DC88A0
	|-Dictionary<object, ushort>.get_Keys
	|
	|-RVA: 0x2DCBF60 Offset: 0x2DCC061 VA: 0x2DCBF60
	|-Dictionary<object, uint>.get_Keys
	|
	|-RVA: 0x2DCF620 Offset: 0x2DCF721 VA: 0x2DCF620
	|-Dictionary<object, ulong>.get_Keys
	|
	|-RVA: 0x2DD2CD0 Offset: 0x2DD2DD1 VA: 0x2DD2CD0
	|-Dictionary<object, TransitionTables>.get_Keys
	|
	|-RVA: 0x2DD66F0 Offset: 0x2DD67F1 VA: 0x2DD66F0
	|-Dictionary<object, Bounds>.get_Keys
	|
	|-RVA: 0x2DDA0B0 Offset: 0x2DDA1B1 VA: 0x2DDA0B0
	|-Dictionary<object, BoundsInt>.get_Keys
	|
	|-RVA: 0x30D5350 Offset: 0x30D5451 VA: 0x30D5350
	|-Dictionary<object, Color32>.get_Keys
	|
	|-RVA: 0x30D8A10 Offset: 0x30D8B11 VA: 0x30D8A10
	|-Dictionary<object, Color>.get_Keys
	|
	|-RVA: 0x30DC130 Offset: 0x30DC231 VA: 0x30DC130
	|-Dictionary<object, GradientAlphaKey>.get_Keys
	|
	|-RVA: 0x30DF820 Offset: 0x30DF921 VA: 0x30DF820
	|-Dictionary<object, GradientColorKey>.get_Keys
	|
	|-RVA: 0x30E31F0 Offset: 0x30E32F1 VA: 0x30E31F0
	|-Dictionary<object, Keyframe>.get_Keys
	|
	|-RVA: 0x30E6D30 Offset: 0x30E6E31 VA: 0x30E6D30
	|-Dictionary<object, LayerMask>.get_Keys
	|
	|-RVA: 0x30EA3F0 Offset: 0x30EA4F1 VA: 0x30EA3F0
	|-Dictionary<object, Matrix4x4>.get_Keys
	|
	|-RVA: 0x30EE0A0 Offset: 0x30EE1A1 VA: 0x30EE0A0
	|-Dictionary<object, Playable>.get_Keys
	|
	|-RVA: 0x309CEA0 Offset: 0x309CFA1 VA: 0x309CEA0
	|-Dictionary<object, Quaternion>.get_Keys
	|
	|-RVA: 0x30A05C0 Offset: 0x30A06C1 VA: 0x30A05C0
	|-Dictionary<object, RangeInt>.get_Keys
	|
	|-RVA: 0x30A3C70 Offset: 0x30A3D71 VA: 0x30A3C70
	|-Dictionary<object, Rect>.get_Keys
	|
	|-RVA: 0x30A7390 Offset: 0x30A7491 VA: 0x30A7390
	|-Dictionary<object, RectInt>.get_Keys
	|
	|-RVA: 0x30AAA80 Offset: 0x30AAB81 VA: 0x30AAA80
	|-Dictionary<object, AsyncOperationHandle>.get_Keys
	|
	|-RVA: 0x30AE450 Offset: 0x30AE551 VA: 0x30AE450
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Keys
	|
	|-RVA: 0x30B1E20 Offset: 0x30B1F21 VA: 0x30B1E20
	|-Dictionary<object, Vector2>.get_Keys
	|
	|-RVA: 0x30B5510 Offset: 0x30B5611 VA: 0x30B5510
	|-Dictionary<object, Vector2Int>.get_Keys
	|
	|-RVA: 0x30811A0 Offset: 0x30812A1 VA: 0x30811A0
	|-Dictionary<object, Vector3>.get_Keys
	|
	|-RVA: 0x30848B0 Offset: 0x30849B1 VA: 0x30848B0
	|-Dictionary<object, Vector3Int>.get_Keys
	|
	|-RVA: 0x3087FE0 Offset: 0x30880E1 VA: 0x3087FE0
	|-Dictionary<object, Vector4>.get_Keys
	|
	|-RVA: 0x308B700 Offset: 0x308B801 VA: 0x308B700
	|-Dictionary<ReadOnlyMemory<object>, object>.get_Keys
	|
	|-RVA: 0x308ED90 Offset: 0x308EE91 VA: 0x308ED90
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Keys
	|
	|-RVA: 0x3092420 Offset: 0x3092521 VA: 0x3092420
	|-Dictionary<sbyte, object>.get_Keys
	|
	|-RVA: 0x3095A40 Offset: 0x3095B41 VA: 0x3095A40
	|-Dictionary<float, CurveSample>.get_Keys
	|
	|-RVA: 0x3099890 Offset: 0x3099991 VA: 0x3099890
	|-Dictionary<float, object>.get_Keys
	|
	|-RVA: 0x319CDF0 Offset: 0x319CEF1 VA: 0x319CDF0
	|-Dictionary<ushort, object>.get_Keys
	|
	|-RVA: 0x31A0410 Offset: 0x31A0511 VA: 0x31A0410
	|-Dictionary<uint, int>.get_Keys
	|
	|-RVA: 0x31A39D0 Offset: 0x31A3AD1 VA: 0x31A39D0
	|-Dictionary<uint, Int32Enum>.get_Keys
	|
	|-RVA: 0x31AA5B0 Offset: 0x31AA6B1 VA: 0x31AA5B0
	|-Dictionary<ulong, object>.get_Keys
	|
	|-RVA: 0x31ADBD0 Offset: 0x31ADCD1 VA: 0x31ADBD0
	|-Dictionary<EdgeKeyByHash, int>.get_Keys
	|
	|-RVA: 0x31B1240 Offset: 0x31B1341 VA: 0x31B1240
	|-Dictionary<EdgeKeyByHash, CapEdge>.get_Keys
	|
	|-RVA: 0x31B4DF0 Offset: 0x31B4EF1 VA: 0x31B4DF0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Keys
	|
	|-RVA: 0x302D1F0 Offset: 0x302D2F1 VA: 0x302D1F0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.get_Keys
	|
	|-RVA: 0x3030BA0 Offset: 0x3030CA1 VA: 0x3030BA0
	|-Dictionary<MeshDataConnectivity.Face, bool>.get_Keys
	|
	|-RVA: 0x3034230 Offset: 0x3034331 VA: 0x3034230
	|-Dictionary<MeshDataConnectivity.Face, object>.get_Keys
	|
	|-RVA: 0x3037850 Offset: 0x3037951 VA: 0x3037850
	|-Dictionary<Bounds, object>.get_Keys
	|
	|-RVA: 0x303B380 Offset: 0x303B481 VA: 0x303B380
	|-Dictionary<BoundsInt, object>.get_Keys
	|
	|-RVA: 0x303EEB0 Offset: 0x303EFB1 VA: 0x303EEB0
	|-Dictionary<Color, object>.get_Keys
	|
	|-RVA: 0x3042610 Offset: 0x3042711 VA: 0x3042610
	|-Dictionary<Color32, object>.get_Keys
	|
	|-RVA: 0x30647A0 Offset: 0x30648A1 VA: 0x30647A0
	|-Dictionary<GradientAlphaKey, object>.get_Keys
	|
	|-RVA: 0x3067E20 Offset: 0x3067F21 VA: 0x3067E20
	|-Dictionary<GradientColorKey, object>.get_Keys
	|
	|-RVA: 0x306B950 Offset: 0x306BA51 VA: 0x306B950
	|-Dictionary<Keyframe, object>.get_Keys
	|
	|-RVA: 0x306F6D0 Offset: 0x306F7D1 VA: 0x306F6D0
	|-Dictionary<LayerMask, object>.get_Keys
	|
	|-RVA: 0x3072D30 Offset: 0x3072E31 VA: 0x3072D30
	|-Dictionary<Matrix4x4, object>.get_Keys
	|
	|-RVA: 0x3076D30 Offset: 0x3076E31 VA: 0x3076D30
	|-Dictionary<IntVec3, object>.get_Keys
	|
	|-RVA: 0x307A420 Offset: 0x307A521 VA: 0x307A420
	|-Dictionary<Quaternion, object>.get_Keys
	|
	|-RVA: 0x307DB80 Offset: 0x307DC81 VA: 0x307DB80
	|-Dictionary<RangeInt, object>.get_Keys
	|
	|-RVA: 0x3049290 Offset: 0x3049391 VA: 0x3049290
	|-Dictionary<Rect, object>.get_Keys
	|
	|-RVA: 0x304C9F0 Offset: 0x304CAF1 VA: 0x304C9F0
	|-Dictionary<RectInt, object>.get_Keys
	|
	|-RVA: 0x3050070 Offset: 0x3050171 VA: 0x3050070
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.get_Keys
	|
	|-RVA: 0x30536E0 Offset: 0x30537E1 VA: 0x30536E0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Keys
	|
	|-RVA: 0x3056D00 Offset: 0x3056E01 VA: 0x3056D00
	|-Dictionary<Vector2, object>.get_Keys
	|
	|-RVA: 0x305A380 Offset: 0x305A481 VA: 0x305A380
	|-Dictionary<Vector2Int, object>.get_Keys
	|
	|-RVA: 0x305D9A0 Offset: 0x305DAA1 VA: 0x305D9A0
	|-Dictionary<Vector3, object>.get_Keys
	|
	|-RVA: 0x3061090 Offset: 0x3061191 VA: 0x3061090
	|-Dictionary<Vector3Int, object>.get_Keys
	|
	|-RVA: 0x2E3AA80 Offset: 0x2E3AB81 VA: 0x2E3AA80
	|-Dictionary<Vector4, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A164D0 Offset: 0x2A165D1 VA: 0x2A164D0
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2A19B60 Offset: 0x2A19C61 VA: 0x2A19B60
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E29C20 Offset: 0x2E29D21 VA: 0x2E29C20
	|-Dictionary<Season, Texture>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F788C0 Offset: 0x2F789C1 VA: 0x2F788C0
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F7C3F0 Offset: 0x2F7C4F1 VA: 0x2F7C3F0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F804C0 Offset: 0x2F805C1 VA: 0x2F804C0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F83FF0 Offset: 0x2F840F1 VA: 0x2F83FF0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F87700 Offset: 0x2F87801 VA: 0x2F87700
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F8AD80 Offset: 0x2F8AE81 VA: 0x2F8AD80
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F8EB10 Offset: 0x2F8EC11 VA: 0x2F8EB10
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F92220 Offset: 0x2F92321 VA: 0x2F92220
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D80330 Offset: 0x2D80431 VA: 0x2D80330
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D83E90 Offset: 0x2D83F91 VA: 0x2D83E90
	|-Dictionary<Parameter, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D87C00 Offset: 0x2D87D01 VA: 0x2D87C00
	|-Dictionary<bool, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D8B280 Offset: 0x2D8B381 VA: 0x2D8B280
	|-Dictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D8E8A0 Offset: 0x2D8E9A1 VA: 0x2D8E8A0
	|-Dictionary<char, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D91EC0 Offset: 0x2D91FC1 VA: 0x2D91EC0
	|-Dictionary<DateTime, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D954E0 Offset: 0x2D955E1 VA: 0x2D954E0
	|-Dictionary<double, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D98AF0 Offset: 0x2D98BF1 VA: 0x2D98AF0
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D9C170 Offset: 0x2D9C271 VA: 0x2D9C170
	|-Dictionary<short, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D3A340 Offset: 0x2D3A441 VA: 0x2D3A340
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D3DF40 Offset: 0x2D3E041 VA: 0x2D3DF40
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D418B0 Offset: 0x2D419B1 VA: 0x2D418B0
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D44E80 Offset: 0x2D44F81 VA: 0x2D44E80
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D48B50 Offset: 0x2D48C51 VA: 0x2D48B50
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D4C220 Offset: 0x2D4C321 VA: 0x2D4C220
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D4F800 Offset: 0x2D4F901 VA: 0x2D4F800
	|-Dictionary<int, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D52DC0 Offset: 0x2D52EC1 VA: 0x2D52DC0
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2D56380 Offset: 0x2D56481 VA: 0x2D56380
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F5C480 Offset: 0x2F5C581 VA: 0x2F5C480
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F5FB10 Offset: 0x2F5FC11 VA: 0x2F5FB10
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F63130 Offset: 0x2F63231 VA: 0x2F63130
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F66C50 Offset: 0x2F66D51 VA: 0x2F66C50
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F6A320 Offset: 0x2F6A421 VA: 0x2F6A320
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F6D9A0 Offset: 0x2F6DAA1 VA: 0x2F6D9A0
	|-Dictionary<int, Vector3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F710F0 Offset: 0x2F711F1 VA: 0x2F710F0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F74DA0 Offset: 0x2F74EA1 VA: 0x2F74DA0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E1C2E0 Offset: 0x2E1C3E1 VA: 0x2E1C2E0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E1FA00 Offset: 0x2E1FB01 VA: 0x2E1FA00
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E22FE0 Offset: 0x2E230E1 VA: 0x2E22FE0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E26660 Offset: 0x2E26761 VA: 0x2E26660
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E2D1E0 Offset: 0x2E2D2E1 VA: 0x2E2D1E0
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E30800 Offset: 0x2E30901 VA: 0x2E30800
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E33DC0 Offset: 0x2E33EC1 VA: 0x2E33DC0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E37490 Offset: 0x2E37591 VA: 0x2E37490
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F95FB0 Offset: 0x2F960B1 VA: 0x2F95FB0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F99700 Offset: 0x2F99801 VA: 0x2F99700
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F9CD20 Offset: 0x2F9CE21 VA: 0x2F9CD20
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FA03B0 Offset: 0x2FA04B1 VA: 0x2FA03B0
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FA3B90 Offset: 0x2FA3C91 VA: 0x2FA3B90
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FA7AF0 Offset: 0x2FA7BF1 VA: 0x2FA7AF0
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FABA50 Offset: 0x2FABB51 VA: 0x2FABA50
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FAF230 Offset: 0x2FAF331 VA: 0x2FAF230
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F1A320 Offset: 0x2F1A421 VA: 0x2F1A320
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F1DBF0 Offset: 0x2F1DCF1 VA: 0x2F1DBF0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F218F0 Offset: 0x2F219F1 VA: 0x2F218F0
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F25620 Offset: 0x2F25721 VA: 0x2F25620
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F28E00 Offset: 0x2F28F01 VA: 0x2F28E00
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F2D370 Offset: 0x2F2D471 VA: 0x2F2D370
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F31070 Offset: 0x2F31171 VA: 0x2F31070
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F34940 Offset: 0x2F34A41 VA: 0x2F34940
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2EFD650 Offset: 0x2EFD751 VA: 0x2EFD650
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F01350 Offset: 0x2F01451 VA: 0x2F01350
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F04C20 Offset: 0x2F04D21 VA: 0x2F04C20
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F084F0 Offset: 0x2F085F1 VA: 0x2F084F0
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F0BD30 Offset: 0x2F0BE31 VA: 0x2F0BD30
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F0F570 Offset: 0x2F0F671 VA: 0x2F0F570
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F13270 Offset: 0x2F13371 VA: 0x2F13270
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2F16930 Offset: 0x2F16A31 VA: 0x2F16930
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FF3110 Offset: 0x2FF3211 VA: 0x2FF3110
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FF6E50 Offset: 0x2FF6F51 VA: 0x2FF6E50
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FFA820 Offset: 0x2FFA921 VA: 0x2FFA820
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FFDF50 Offset: 0x2FFE051 VA: 0x2FFDF50
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3001640 Offset: 0x3001741 VA: 0x3001640
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3005180 Offset: 0x3005281 VA: 0x3005180
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30088B0 Offset: 0x30089B1 VA: 0x30088B0
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x300C400 Offset: 0x300C501 VA: 0x300C400
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DDDB10 Offset: 0x2DDDC11 VA: 0x2DDDB10
	|-Dictionary<object, Parameter>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DE1740 Offset: 0x2DE1841 VA: 0x2DE1740
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DE4E10 Offset: 0x2DE4F11 VA: 0x2DE4E10
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DE84F0 Offset: 0x2DE85F1 VA: 0x2DE84F0
	|-Dictionary<object, byte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DEBBB0 Offset: 0x2DEBCB1 VA: 0x2DEBBB0
	|-Dictionary<object, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DEF270 Offset: 0x2DEF371 VA: 0x2DEF270
	|-Dictionary<object, DateTime>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DF2920 Offset: 0x2DF2A21 VA: 0x2DF2920
	|-Dictionary<object, double>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DF5FE0 Offset: 0x2DF60E1 VA: 0x2DF5FE0
	|-Dictionary<object, short>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DF96A0 Offset: 0x2DF97A1 VA: 0x2DF96A0
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30B8C60 Offset: 0x30B8D61 VA: 0x30B8C60
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30BC320 Offset: 0x30BC421 VA: 0x30BC320
	|-Dictionary<object, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30BF9D0 Offset: 0x30BFAD1 VA: 0x30BF9D0
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30C30F0 Offset: 0x30C31F1 VA: 0x30C30F0
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30C6890 Offset: 0x30C6991 VA: 0x30C6890
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30CA4F0 Offset: 0x30CA5F1 VA: 0x30CA4F0
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30CE150 Offset: 0x30CE251 VA: 0x30CE150
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30D18F0 Offset: 0x30D19F1 VA: 0x30D18F0
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x300FE30 Offset: 0x300FF31 VA: 0x300FE30
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3013680 Offset: 0x3013781 VA: 0x3013680
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3017170 Offset: 0x3017271 VA: 0x3017170
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x301ACA0 Offset: 0x301ADA1 VA: 0x301ACA0
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x301E440 Offset: 0x301E541 VA: 0x301E440
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3022440 Offset: 0x3022541 VA: 0x3022440
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3025F40 Offset: 0x3026041 VA: 0x3025F40
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3029790 Offset: 0x3029891 VA: 0x3029790
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FD6D70 Offset: 0x2FD6E71 VA: 0x2FD6D70
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FDA870 Offset: 0x2FDA971 VA: 0x2FDA870
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FDE0C0 Offset: 0x2FDE1C1 VA: 0x2FDE0C0
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FE1910 Offset: 0x2FE1A11 VA: 0x2FE1910
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FE5100 Offset: 0x2FE5201 VA: 0x2FE5100
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FE88F0 Offset: 0x2FE89F1 VA: 0x2FE88F0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FEC3F0 Offset: 0x2FEC4F1 VA: 0x2FEC3F0
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2FEF9F0 Offset: 0x2FEFAF1 VA: 0x2FEF9F0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DBE4A0 Offset: 0x2DBE5A1 VA: 0x2DBE4A0
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DC1BC0 Offset: 0x2DC1CC1 VA: 0x2DC1BC0
	|-Dictionary<object, sbyte>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DC5280 Offset: 0x2DC5381 VA: 0x2DC5280
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DC8940 Offset: 0x2DC8A41 VA: 0x2DC8940
	|-Dictionary<object, ushort>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DCC000 Offset: 0x2DCC101 VA: 0x2DCC000
	|-Dictionary<object, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DCF6C0 Offset: 0x2DCF7C1 VA: 0x2DCF6C0
	|-Dictionary<object, ulong>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DD2D70 Offset: 0x2DD2E71 VA: 0x2DD2D70
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DD6790 Offset: 0x2DD6891 VA: 0x2DD6790
	|-Dictionary<object, Bounds>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DDA150 Offset: 0x2DDA251 VA: 0x2DDA150
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30D53F0 Offset: 0x30D54F1 VA: 0x30D53F0
	|-Dictionary<object, Color32>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30D8AB0 Offset: 0x30D8BB1 VA: 0x30D8AB0
	|-Dictionary<object, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30DC1D0 Offset: 0x30DC2D1 VA: 0x30DC1D0
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30DF8C0 Offset: 0x30DF9C1 VA: 0x30DF8C0
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30E3290 Offset: 0x30E3391 VA: 0x30E3290
	|-Dictionary<object, Keyframe>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30E6DD0 Offset: 0x30E6ED1 VA: 0x30E6DD0
	|-Dictionary<object, LayerMask>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30EA490 Offset: 0x30EA591 VA: 0x30EA490
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30EE140 Offset: 0x30EE241 VA: 0x30EE140
	|-Dictionary<object, Playable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x309CF40 Offset: 0x309D041 VA: 0x309CF40
	|-Dictionary<object, Quaternion>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30A0660 Offset: 0x30A0761 VA: 0x30A0660
	|-Dictionary<object, RangeInt>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30A3D10 Offset: 0x30A3E11 VA: 0x30A3D10
	|-Dictionary<object, Rect>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30A7430 Offset: 0x30A7531 VA: 0x30A7430
	|-Dictionary<object, RectInt>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30AAB20 Offset: 0x30AAC21 VA: 0x30AAB20
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30AE4F0 Offset: 0x30AE5F1 VA: 0x30AE4F0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30B1EC0 Offset: 0x30B1FC1 VA: 0x30B1EC0
	|-Dictionary<object, Vector2>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30B55B0 Offset: 0x30B56B1 VA: 0x30B55B0
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3081240 Offset: 0x3081341 VA: 0x3081240
	|-Dictionary<object, Vector3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3084950 Offset: 0x3084A51 VA: 0x3084950
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3088080 Offset: 0x3088181 VA: 0x3088080
	|-Dictionary<object, Vector4>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x308B7A0 Offset: 0x308B8A1 VA: 0x308B7A0
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x308EE30 Offset: 0x308EF31 VA: 0x308EE30
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30924C0 Offset: 0x30925C1 VA: 0x30924C0
	|-Dictionary<sbyte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3095AE0 Offset: 0x3095BE1 VA: 0x3095AE0
	|-Dictionary<float, CurveSample>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3099930 Offset: 0x3099A31 VA: 0x3099930
	|-Dictionary<float, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x319CE90 Offset: 0x319CF91 VA: 0x319CE90
	|-Dictionary<ushort, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31A04B0 Offset: 0x31A05B1 VA: 0x31A04B0
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31A3A70 Offset: 0x31A3B71 VA: 0x31A3A70
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31A7030 Offset: 0x31A7131 VA: 0x31A7030
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31AA650 Offset: 0x31AA751 VA: 0x31AA650
	|-Dictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31ADC70 Offset: 0x31ADD71 VA: 0x31ADC70
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31B12E0 Offset: 0x31B13E1 VA: 0x31B12E0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x31B4E90 Offset: 0x31B4F91 VA: 0x31B4E90
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x302D290 Offset: 0x302D391 VA: 0x302D290
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3030C40 Offset: 0x3030D41 VA: 0x3030C40
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30342D0 Offset: 0x30343D1 VA: 0x30342D0
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30378F0 Offset: 0x30379F1 VA: 0x30378F0
	|-Dictionary<Bounds, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x303B420 Offset: 0x303B521 VA: 0x303B420
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x303EF50 Offset: 0x303F051 VA: 0x303EF50
	|-Dictionary<Color, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x30426B0 Offset: 0x30427B1 VA: 0x30426B0
	|-Dictionary<Color32, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3045D10 Offset: 0x3045E11 VA: 0x3045D10
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3064840 Offset: 0x3064941 VA: 0x3064840
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3067EC0 Offset: 0x3067FC1 VA: 0x3067EC0
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x306B9F0 Offset: 0x306BAF1 VA: 0x306B9F0
	|-Dictionary<Keyframe, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x306F770 Offset: 0x306F871 VA: 0x306F770
	|-Dictionary<LayerMask, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3072DD0 Offset: 0x3072ED1 VA: 0x3072DD0
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3076DD0 Offset: 0x3076ED1 VA: 0x3076DD0
	|-Dictionary<IntVec3, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x307A4C0 Offset: 0x307A5C1 VA: 0x307A4C0
	|-Dictionary<Quaternion, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x307DC20 Offset: 0x307DD21 VA: 0x307DC20
	|-Dictionary<RangeInt, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3049330 Offset: 0x3049431 VA: 0x3049330
	|-Dictionary<Rect, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x304CA90 Offset: 0x304CB91 VA: 0x304CA90
	|-Dictionary<RectInt, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3050110 Offset: 0x3050211 VA: 0x3050110
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3053780 Offset: 0x3053881 VA: 0x3053780
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3056DA0 Offset: 0x3056EA1 VA: 0x3056DA0
	|-Dictionary<Vector2, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x305A420 Offset: 0x305A521 VA: 0x305A420
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x305DA40 Offset: 0x305DB41 VA: 0x305DA40
	|-Dictionary<Vector3, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3061130 Offset: 0x3061231 VA: 0x3061130
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2E3AB20 Offset: 0x2E3AC21 VA: 0x2E3AB20
	|-Dictionary<Vector4, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E2D280 Offset: 0x2E2D381 VA: 0x2E2D280
	|-Dictionary<BeanID, BeanData>.get_Values
	|-Dictionary<ActorID, LifeCycleScriptPlayer>.get_Values
	|-Dictionary<BadStatus, BadStatusEffectController.ObjInfo>.get_Values
	|-Dictionary<ToolChargeLevel, ParticleSystem>.get_Values
	|-Dictionary<EquipSlotType, HumanEquipItem>.get_Values
	|-Dictionary<GateDataID, GateController>.get_Values
	|-Dictionary<ItemID, ItemPoolData>.get_Values
	|-Dictionary<SnowmanObjectID, SnowballData>.get_Values
	|-Dictionary<SoundID, EnvironmentSoundController>.get_Values
	|-Dictionary<Int32Enum, object>.get_Values
	|
	|-RVA: 0x2E29CC0 Offset: 0x2E29DC1 VA: 0x2E29CC0
	|-Dictionary<EmotionType, Prefab>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.get_Values
	|
	|-RVA: 0x2DF9740 Offset: 0x2DF9841 VA: 0x2DF9740
	|-Dictionary<MonsterControllerBase, int>.get_Values
	|-Dictionary<object, int>.get_Values
	|
	|-RVA: 0x2F71190 Offset: 0x2F71291 VA: 0x2F71190
	|-Dictionary<MonsterDataID, MonsterDataTable>.get_Values
	|-Dictionary<Int32Enum, MonsterDataTable>.get_Values
	|
	|-RVA: 0x2F5FBB0 Offset: 0x2F5FCB1 VA: 0x2F5FBB0
	|-Dictionary<int, BossStageManager>.get_Values
	|-Dictionary<int, AssetHandle>.get_Values
	|-Dictionary<int, ObjectSerializationInfo.EmittableMember>.get_Values
	|-Dictionary<int, PointerEventData>.get_Values
	|-Dictionary<int, object>.get_Values
	|
	|-RVA: 0x2F631D0 Offset: 0x2F632D1 VA: 0x2F631D0
	|-Dictionary<int, DiagnosticEvent>.get_Values
	|
	|-RVA: 0x2F66CF0 Offset: 0x2F66DF1 VA: 0x2F66CF0
	|-Dictionary<int, SceneInstance>.get_Values
	|
	|-RVA: 0x2FEC490 Offset: 0x2FEC591 VA: 0x2FEC490
	|-Dictionary<string, ActionCode>.get_Values
	|-Dictionary<string, ObjectSerializationInfo.EmittableMember>.get_Values
	|-Dictionary<string, WebConnectionGroup>.get_Values
	|-Dictionary<string, string>.get_Values
	|-Dictionary<string, GUIStyle>.get_Values
	|-Dictionary<string, Transform>.get_Values
	|-Dictionary<Collider, CharacterNearCullingController>.get_Values
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.get_Values
	|-Dictionary<object, object>.get_Values
	|
	|-RVA: 0x31A70D0 Offset: 0x31A71D1 VA: 0x31A70D0
	|-Dictionary<uint, FriendMonsterStatus>.get_Values
	|-Dictionary<uint, object>.get_Values
	|
	|-RVA: 0x31B1380 Offset: 0x31B1481 VA: 0x31B1380
	|-Dictionary<EdgeKeyByHash, CapEdge>.get_Values
	|
	|-RVA: 0x2A16570 Offset: 0x2A16671 VA: 0x2A16570
	|-Dictionary<JSONDeserialization.TaskField, object>.get_Values
	|
	|-RVA: 0x2A19C00 Offset: 0x2A19D01 VA: 0x2A19C00
	|-Dictionary<BitVector32Int, object>.get_Values
	|
	|-RVA: 0x2F78960 Offset: 0x2F78A61 VA: 0x2F78960
	|-Dictionary<EventCheckId, object>.get_Values
	|
	|-RVA: 0x2F7C490 Offset: 0x2F7C591 VA: 0x2F7C490
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.get_Values
	|
	|-RVA: 0x2F80560 Offset: 0x2F80661 VA: 0x2F80560
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.get_Values
	|
	|-RVA: 0x2F84090 Offset: 0x2F84191 VA: 0x2F84090
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.get_Values
	|
	|-RVA: 0x2F877A0 Offset: 0x2F878A1 VA: 0x2F877A0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.get_Values
	|
	|-RVA: 0x2F8AE20 Offset: 0x2F8AF21 VA: 0x2F8AE20
	|-Dictionary<MonsterHutSaveData, object>.get_Values
	|
	|-RVA: 0x2F8EBB0 Offset: 0x2F8ECB1 VA: 0x2F8EBB0
	|-Dictionary<OrderLotterySaveParameter, object>.get_Values
	|
	|-RVA: 0x2F922C0 Offset: 0x2F923C1 VA: 0x2F922C0
	|-Dictionary<OrderSaveData, object>.get_Values
	|
	|-RVA: 0x2D803D0 Offset: 0x2D804D1 VA: 0x2D803D0
	|-Dictionary<OrderSaveParameter, object>.get_Values
	|
	|-RVA: 0x2D83F30 Offset: 0x2D84031 VA: 0x2D83F30
	|-Dictionary<Parameter, object>.get_Values
	|
	|-RVA: 0x2D87CA0 Offset: 0x2D87DA1 VA: 0x2D87CA0
	|-Dictionary<bool, object>.get_Values
	|
	|-RVA: 0x2D8B320 Offset: 0x2D8B421 VA: 0x2D8B320
	|-Dictionary<byte, object>.get_Values
	|
	|-RVA: 0x2D8E940 Offset: 0x2D8EA41 VA: 0x2D8E940
	|-Dictionary<char, object>.get_Values
	|
	|-RVA: 0x2D91F60 Offset: 0x2D92061 VA: 0x2D91F60
	|-Dictionary<DateTime, object>.get_Values
	|
	|-RVA: 0x2D95580 Offset: 0x2D95681 VA: 0x2D95580
	|-Dictionary<double, object>.get_Values
	|
	|-RVA: 0x2D98B90 Offset: 0x2D98C91 VA: 0x2D98B90
	|-Dictionary<Guid, object>.get_Values
	|
	|-RVA: 0x2D9C210 Offset: 0x2D9C311 VA: 0x2D9C210
	|-Dictionary<short, object>.get_Values
	|
	|-RVA: 0x2D3A3E0 Offset: 0x2D3A4E1 VA: 0x2D3A3E0
	|-Dictionary<int, CropDataTable>.get_Values
	|
	|-RVA: 0x2D3DFE0 Offset: 0x2D3E0E1 VA: 0x2D3DFE0
	|-Dictionary<int, EffectDataTable>.get_Values
	|
	|-RVA: 0x2D41950 Offset: 0x2D41A51 VA: 0x2D41950
	|-Dictionary<int, GimmickLayoutDataTable>.get_Values
	|
	|-RVA: 0x2D44F20 Offset: 0x2D45021 VA: 0x2D44F20
	|-Dictionary<int, MineTypeDataTable>.get_Values
	|
	|-RVA: 0x2D48BF0 Offset: 0x2D48CF1 VA: 0x2D48BF0
	|-Dictionary<int, MiningDataTable>.get_Values
	|
	|-RVA: 0x2D4C2C0 Offset: 0x2D4C3C1 VA: 0x2D4C2C0
	|-Dictionary<int, bool>.get_Values
	|
	|-RVA: 0x2D4F8A0 Offset: 0x2D4F9A1 VA: 0x2D4F8A0
	|-Dictionary<int, char>.get_Values
	|
	|-RVA: 0x2D52E60 Offset: 0x2D52F61 VA: 0x2D52E60
	|-Dictionary<int, int>.get_Values
	|
	|-RVA: 0x2D56420 Offset: 0x2D56521 VA: 0x2D56420
	|-Dictionary<int, Int32Enum>.get_Values
	|
	|-RVA: 0x2F5C520 Offset: 0x2F5C621 VA: 0x2F5C520
	|-Dictionary<int, long>.get_Values
	|
	|-RVA: 0x2F6A3C0 Offset: 0x2F6A4C1 VA: 0x2F6A3C0
	|-Dictionary<int, Vector2Int>.get_Values
	|
	|-RVA: 0x2F6DA40 Offset: 0x2F6DB41 VA: 0x2F6DA40
	|-Dictionary<int, Vector3>.get_Values
	|
	|-RVA: 0x2F74E40 Offset: 0x2F74F41 VA: 0x2F74E40
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.get_Values
	|
	|-RVA: 0x2E1C380 Offset: 0x2E1C481 VA: 0x2E1C380
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Values
	|
	|-RVA: 0x2E1FAA0 Offset: 0x2E1FBA1 VA: 0x2E1FAA0
	|-Dictionary<Int32Enum, bool>.get_Values
	|
	|-RVA: 0x2E23080 Offset: 0x2E23181 VA: 0x2E23080
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Values
	|
	|-RVA: 0x2E26700 Offset: 0x2E26801 VA: 0x2E26700
	|-Dictionary<Int32Enum, int>.get_Values
	|
	|-RVA: 0x2E308A0 Offset: 0x2E309A1 VA: 0x2E308A0
	|-Dictionary<Int32Enum, float>.get_Values
	|
	|-RVA: 0x2E33E60 Offset: 0x2E33F61 VA: 0x2E33E60
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.get_Values
	|
	|-RVA: 0x2E37530 Offset: 0x2E37631 VA: 0x2E37530
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.get_Values
	|
	|-RVA: 0x2F96050 Offset: 0x2F96151 VA: 0x2F96050
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.get_Values
	|
	|-RVA: 0x2F997A0 Offset: 0x2F998A1 VA: 0x2F997A0
	|-Dictionary<long, object>.get_Values
	|
	|-RVA: 0x2F9CDC0 Offset: 0x2F9CEC1 VA: 0x2F9CDC0
	|-Dictionary<Memory<object>, object>.get_Values
	|
	|-RVA: 0x2FA0450 Offset: 0x2FA0551 VA: 0x2FA0450
	|-Dictionary<Nullable<Int32Enum>, object>.get_Values
	|
	|-RVA: 0x2FA3C30 Offset: 0x2FA3D31 VA: 0x2FA3C30
	|-Dictionary<Nullable<Bounds>, object>.get_Values
	|
	|-RVA: 0x2FA7B90 Offset: 0x2FA7C91 VA: 0x2FA7B90
	|-Dictionary<Nullable<BoundsInt>, object>.get_Values
	|
	|-RVA: 0x2FABAF0 Offset: 0x2FABBF1 VA: 0x2FABAF0
	|-Dictionary<Nullable<Color32>, object>.get_Values
	|
	|-RVA: 0x2FAF2D0 Offset: 0x2FAF3D1 VA: 0x2FAF2D0
	|-Dictionary<Nullable<Color>, object>.get_Values
	|
	|-RVA: 0x2F1A3C0 Offset: 0x2F1A4C1 VA: 0x2F1A3C0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.get_Values
	|
	|-RVA: 0x2F1DC90 Offset: 0x2F1DD91 VA: 0x2F1DC90
	|-Dictionary<Nullable<GradientColorKey>, object>.get_Values
	|
	|-RVA: 0x2F21990 Offset: 0x2F21A91 VA: 0x2F21990
	|-Dictionary<Nullable<Keyframe>, object>.get_Values
	|
	|-RVA: 0x2F256C0 Offset: 0x2F257C1 VA: 0x2F256C0
	|-Dictionary<Nullable<LayerMask>, object>.get_Values
	|
	|-RVA: 0x2F28EA0 Offset: 0x2F28FA1 VA: 0x2F28EA0
	|-Dictionary<Nullable<Matrix4x4>, object>.get_Values
	|
	|-RVA: 0x2F2D410 Offset: 0x2F2D511 VA: 0x2F2D410
	|-Dictionary<Nullable<Quaternion>, object>.get_Values
	|
	|-RVA: 0x2F31110 Offset: 0x2F31211 VA: 0x2F31110
	|-Dictionary<Nullable<RangeInt>, object>.get_Values
	|
	|-RVA: 0x2F349E0 Offset: 0x2F34AE1 VA: 0x2F349E0
	|-Dictionary<Nullable<Rect>, object>.get_Values
	|
	|-RVA: 0x2EFD6F0 Offset: 0x2EFD7F1 VA: 0x2EFD6F0
	|-Dictionary<Nullable<RectInt>, object>.get_Values
	|
	|-RVA: 0x2F013F0 Offset: 0x2F014F1 VA: 0x2F013F0
	|-Dictionary<Nullable<Vector2>, object>.get_Values
	|
	|-RVA: 0x2F04CC0 Offset: 0x2F04DC1 VA: 0x2F04CC0
	|-Dictionary<Nullable<Vector2Int>, object>.get_Values
	|
	|-RVA: 0x2F08590 Offset: 0x2F08691 VA: 0x2F08590
	|-Dictionary<Nullable<Vector3>, object>.get_Values
	|
	|-RVA: 0x2F0BDD0 Offset: 0x2F0BED1 VA: 0x2F0BDD0
	|-Dictionary<Nullable<Vector3Int>, object>.get_Values
	|
	|-RVA: 0x2F0F610 Offset: 0x2F0F711 VA: 0x2F0F610
	|-Dictionary<Nullable<Vector4>, object>.get_Values
	|
	|-RVA: 0x2F13310 Offset: 0x2F13411 VA: 0x2F13310
	|-Dictionary<object, BitVector32Int>.get_Values
	|
	|-RVA: 0x2F169D0 Offset: 0x2F16AD1 VA: 0x2F169D0
	|-Dictionary<object, EventCheckId>.get_Values
	|
	|-RVA: 0x2FF31B0 Offset: 0x2FF32B1 VA: 0x2FF31B0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.get_Values
	|
	|-RVA: 0x2FF6EF0 Offset: 0x2FF6FF1 VA: 0x2FF6EF0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.get_Values
	|
	|-RVA: 0x2FFA8C0 Offset: 0x2FFA9C1 VA: 0x2FFA8C0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.get_Values
	|
	|-RVA: 0x2FFDFF0 Offset: 0x2FFE0F1 VA: 0x2FFDFF0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.get_Values
	|
	|-RVA: 0x30016E0 Offset: 0x30017E1 VA: 0x30016E0
	|-Dictionary<object, MonsterHutSaveData>.get_Values
	|
	|-RVA: 0x3005220 Offset: 0x3005321 VA: 0x3005220
	|-Dictionary<object, OrderLotterySaveParameter>.get_Values
	|
	|-RVA: 0x3008950 Offset: 0x3008A51 VA: 0x3008950
	|-Dictionary<object, OrderSaveData>.get_Values
	|
	|-RVA: 0x300C4A0 Offset: 0x300C5A1 VA: 0x300C4A0
	|-Dictionary<object, OrderSaveParameter>.get_Values
	|
	|-RVA: 0x2DDDBB0 Offset: 0x2DDDCB1 VA: 0x2DDDBB0
	|-Dictionary<object, Parameter>.get_Values
	|
	|-RVA: 0x2DE17E0 Offset: 0x2DE18E1 VA: 0x2DE17E0
	|-Dictionary<object, NumberControl.ValueRange>.get_Values
	|
	|-RVA: 0x2DE4EB0 Offset: 0x2DE4FB1 VA: 0x2DE4EB0
	|-Dictionary<object, bool>.get_Values
	|
	|-RVA: 0x2DE8590 Offset: 0x2DE8691 VA: 0x2DE8590
	|-Dictionary<object, byte>.get_Values
	|
	|-RVA: 0x2DEBC50 Offset: 0x2DEBD51 VA: 0x2DEBC50
	|-Dictionary<object, char>.get_Values
	|
	|-RVA: 0x2DEF310 Offset: 0x2DEF411 VA: 0x2DEF310
	|-Dictionary<object, DateTime>.get_Values
	|
	|-RVA: 0x2DF29C0 Offset: 0x2DF2AC1 VA: 0x2DF29C0
	|-Dictionary<object, double>.get_Values
	|
	|-RVA: 0x2DF6080 Offset: 0x2DF6181 VA: 0x2DF6080
	|-Dictionary<object, short>.get_Values
	|
	|-RVA: 0x30B8D00 Offset: 0x30B8E01 VA: 0x30B8D00
	|-Dictionary<object, Int32Enum>.get_Values
	|
	|-RVA: 0x30BC3C0 Offset: 0x30BC4C1 VA: 0x30BC3C0
	|-Dictionary<object, long>.get_Values
	|
	|-RVA: 0x30BFA70 Offset: 0x30BFB71 VA: 0x30BFA70
	|-Dictionary<object, Memory<object>>.get_Values
	|
	|-RVA: 0x30C3190 Offset: 0x30C3291 VA: 0x30C3190
	|-Dictionary<object, Nullable<Int32Enum>>.get_Values
	|
	|-RVA: 0x30C6930 Offset: 0x30C6A31 VA: 0x30C6930
	|-Dictionary<object, Nullable<Bounds>>.get_Values
	|
	|-RVA: 0x30CA590 Offset: 0x30CA691 VA: 0x30CA590
	|-Dictionary<object, Nullable<BoundsInt>>.get_Values
	|
	|-RVA: 0x30CE1F0 Offset: 0x30CE2F1 VA: 0x30CE1F0
	|-Dictionary<object, Nullable<Color32>>.get_Values
	|
	|-RVA: 0x30D1990 Offset: 0x30D1A91 VA: 0x30D1990
	|-Dictionary<object, Nullable<Color>>.get_Values
	|
	|-RVA: 0x300FED0 Offset: 0x300FFD1 VA: 0x300FED0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.get_Values
	|
	|-RVA: 0x3013720 Offset: 0x3013821 VA: 0x3013720
	|-Dictionary<object, Nullable<GradientColorKey>>.get_Values
	|
	|-RVA: 0x3017210 Offset: 0x3017311 VA: 0x3017210
	|-Dictionary<object, Nullable<Keyframe>>.get_Values
	|
	|-RVA: 0x301AD40 Offset: 0x301AE41 VA: 0x301AD40
	|-Dictionary<object, Nullable<LayerMask>>.get_Values
	|
	|-RVA: 0x301E4E0 Offset: 0x301E5E1 VA: 0x301E4E0
	|-Dictionary<object, Nullable<Matrix4x4>>.get_Values
	|
	|-RVA: 0x30224E0 Offset: 0x30225E1 VA: 0x30224E0
	|-Dictionary<object, Nullable<Quaternion>>.get_Values
	|
	|-RVA: 0x3025FE0 Offset: 0x30260E1 VA: 0x3025FE0
	|-Dictionary<object, Nullable<RangeInt>>.get_Values
	|
	|-RVA: 0x3029830 Offset: 0x3029931 VA: 0x3029830
	|-Dictionary<object, Nullable<Rect>>.get_Values
	|
	|-RVA: 0x2FD6E10 Offset: 0x2FD6F11 VA: 0x2FD6E10
	|-Dictionary<object, Nullable<RectInt>>.get_Values
	|
	|-RVA: 0x2FDA910 Offset: 0x2FDAA11 VA: 0x2FDA910
	|-Dictionary<object, Nullable<Vector2>>.get_Values
	|
	|-RVA: 0x2FDE160 Offset: 0x2FDE261 VA: 0x2FDE160
	|-Dictionary<object, Nullable<Vector2Int>>.get_Values
	|
	|-RVA: 0x2FE19B0 Offset: 0x2FE1AB1 VA: 0x2FE19B0
	|-Dictionary<object, Nullable<Vector3>>.get_Values
	|
	|-RVA: 0x2FE51A0 Offset: 0x2FE52A1 VA: 0x2FE51A0
	|-Dictionary<object, Nullable<Vector3Int>>.get_Values
	|
	|-RVA: 0x2FE8990 Offset: 0x2FE8A91 VA: 0x2FE8990
	|-Dictionary<object, Nullable<Vector4>>.get_Values
	|
	|-RVA: 0x2FEFA90 Offset: 0x2FEFB91 VA: 0x2FEFA90
	|-Dictionary<object, ReadOnlyMemory<object>>.get_Values
	|
	|-RVA: 0x2DBE540 Offset: 0x2DBE641 VA: 0x2DBE540
	|-Dictionary<object, ResourceLocator>.get_Values
	|
	|-RVA: 0x2DC1C60 Offset: 0x2DC1D61 VA: 0x2DC1C60
	|-Dictionary<object, sbyte>.get_Values
	|
	|-RVA: 0x2DC5320 Offset: 0x2DC5421 VA: 0x2DC5320
	|-Dictionary<object, float>.get_Values
	|
	|-RVA: 0x2DC89E0 Offset: 0x2DC8AE1 VA: 0x2DC89E0
	|-Dictionary<object, ushort>.get_Values
	|
	|-RVA: 0x2DCC0A0 Offset: 0x2DCC1A1 VA: 0x2DCC0A0
	|-Dictionary<object, uint>.get_Values
	|
	|-RVA: 0x2DCF760 Offset: 0x2DCF861 VA: 0x2DCF760
	|-Dictionary<object, ulong>.get_Values
	|
	|-RVA: 0x2DD2E10 Offset: 0x2DD2F11 VA: 0x2DD2E10
	|-Dictionary<object, TransitionTables>.get_Values
	|
	|-RVA: 0x2DD6830 Offset: 0x2DD6931 VA: 0x2DD6830
	|-Dictionary<object, Bounds>.get_Values
	|
	|-RVA: 0x2DDA1F0 Offset: 0x2DDA2F1 VA: 0x2DDA1F0
	|-Dictionary<object, BoundsInt>.get_Values
	|
	|-RVA: 0x30D5490 Offset: 0x30D5591 VA: 0x30D5490
	|-Dictionary<object, Color32>.get_Values
	|
	|-RVA: 0x30D8B50 Offset: 0x30D8C51 VA: 0x30D8B50
	|-Dictionary<object, Color>.get_Values
	|
	|-RVA: 0x30DC270 Offset: 0x30DC371 VA: 0x30DC270
	|-Dictionary<object, GradientAlphaKey>.get_Values
	|
	|-RVA: 0x30DF960 Offset: 0x30DFA61 VA: 0x30DF960
	|-Dictionary<object, GradientColorKey>.get_Values
	|
	|-RVA: 0x30E3330 Offset: 0x30E3431 VA: 0x30E3330
	|-Dictionary<object, Keyframe>.get_Values
	|
	|-RVA: 0x30E6E70 Offset: 0x30E6F71 VA: 0x30E6E70
	|-Dictionary<object, LayerMask>.get_Values
	|
	|-RVA: 0x30EA530 Offset: 0x30EA631 VA: 0x30EA530
	|-Dictionary<object, Matrix4x4>.get_Values
	|
	|-RVA: 0x30EE1E0 Offset: 0x30EE2E1 VA: 0x30EE1E0
	|-Dictionary<object, Playable>.get_Values
	|
	|-RVA: 0x309CFE0 Offset: 0x309D0E1 VA: 0x309CFE0
	|-Dictionary<object, Quaternion>.get_Values
	|
	|-RVA: 0x30A0700 Offset: 0x30A0801 VA: 0x30A0700
	|-Dictionary<object, RangeInt>.get_Values
	|
	|-RVA: 0x30A3DB0 Offset: 0x30A3EB1 VA: 0x30A3DB0
	|-Dictionary<object, Rect>.get_Values
	|
	|-RVA: 0x30A74D0 Offset: 0x30A75D1 VA: 0x30A74D0
	|-Dictionary<object, RectInt>.get_Values
	|
	|-RVA: 0x30AABC0 Offset: 0x30AACC1 VA: 0x30AABC0
	|-Dictionary<object, AsyncOperationHandle>.get_Values
	|
	|-RVA: 0x30AE590 Offset: 0x30AE691 VA: 0x30AE590
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Values
	|
	|-RVA: 0x30B1F60 Offset: 0x30B2061 VA: 0x30B1F60
	|-Dictionary<object, Vector2>.get_Values
	|
	|-RVA: 0x30B5650 Offset: 0x30B5751 VA: 0x30B5650
	|-Dictionary<object, Vector2Int>.get_Values
	|
	|-RVA: 0x30812E0 Offset: 0x30813E1 VA: 0x30812E0
	|-Dictionary<object, Vector3>.get_Values
	|
	|-RVA: 0x30849F0 Offset: 0x3084AF1 VA: 0x30849F0
	|-Dictionary<object, Vector3Int>.get_Values
	|
	|-RVA: 0x3088120 Offset: 0x3088221 VA: 0x3088120
	|-Dictionary<object, Vector4>.get_Values
	|
	|-RVA: 0x308B840 Offset: 0x308B941 VA: 0x308B840
	|-Dictionary<ReadOnlyMemory<object>, object>.get_Values
	|
	|-RVA: 0x308EED0 Offset: 0x308EFD1 VA: 0x308EED0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Values
	|
	|-RVA: 0x3092560 Offset: 0x3092661 VA: 0x3092560
	|-Dictionary<sbyte, object>.get_Values
	|
	|-RVA: 0x3095B80 Offset: 0x3095C81 VA: 0x3095B80
	|-Dictionary<float, CurveSample>.get_Values
	|
	|-RVA: 0x30999D0 Offset: 0x3099AD1 VA: 0x30999D0
	|-Dictionary<float, object>.get_Values
	|
	|-RVA: 0x319CF30 Offset: 0x319D031 VA: 0x319CF30
	|-Dictionary<ushort, object>.get_Values
	|
	|-RVA: 0x31A0550 Offset: 0x31A0651 VA: 0x31A0550
	|-Dictionary<uint, int>.get_Values
	|
	|-RVA: 0x31A3B10 Offset: 0x31A3C11 VA: 0x31A3B10
	|-Dictionary<uint, Int32Enum>.get_Values
	|
	|-RVA: 0x31AA6F0 Offset: 0x31AA7F1 VA: 0x31AA6F0
	|-Dictionary<ulong, object>.get_Values
	|
	|-RVA: 0x31ADD10 Offset: 0x31ADE11 VA: 0x31ADD10
	|-Dictionary<EdgeKeyByHash, int>.get_Values
	|
	|-RVA: 0x31B4F30 Offset: 0x31B5031 VA: 0x31B4F30
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Values
	|
	|-RVA: 0x302D330 Offset: 0x302D431 VA: 0x302D330
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.get_Values
	|
	|-RVA: 0x3030CE0 Offset: 0x3030DE1 VA: 0x3030CE0
	|-Dictionary<MeshDataConnectivity.Face, bool>.get_Values
	|
	|-RVA: 0x3034370 Offset: 0x3034471 VA: 0x3034370
	|-Dictionary<MeshDataConnectivity.Face, object>.get_Values
	|
	|-RVA: 0x3037990 Offset: 0x3037A91 VA: 0x3037990
	|-Dictionary<Bounds, object>.get_Values
	|
	|-RVA: 0x303B4C0 Offset: 0x303B5C1 VA: 0x303B4C0
	|-Dictionary<BoundsInt, object>.get_Values
	|
	|-RVA: 0x303EFF0 Offset: 0x303F0F1 VA: 0x303EFF0
	|-Dictionary<Color, object>.get_Values
	|
	|-RVA: 0x3042750 Offset: 0x3042851 VA: 0x3042750
	|-Dictionary<Color32, object>.get_Values
	|
	|-RVA: 0x3045DB0 Offset: 0x3045EB1 VA: 0x3045DB0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Values
	|
	|-RVA: 0x30648E0 Offset: 0x30649E1 VA: 0x30648E0
	|-Dictionary<GradientAlphaKey, object>.get_Values
	|
	|-RVA: 0x3067F60 Offset: 0x3068061 VA: 0x3067F60
	|-Dictionary<GradientColorKey, object>.get_Values
	|
	|-RVA: 0x306BA90 Offset: 0x306BB91 VA: 0x306BA90
	|-Dictionary<Keyframe, object>.get_Values
	|
	|-RVA: 0x306F810 Offset: 0x306F911 VA: 0x306F810
	|-Dictionary<LayerMask, object>.get_Values
	|
	|-RVA: 0x3072E70 Offset: 0x3072F71 VA: 0x3072E70
	|-Dictionary<Matrix4x4, object>.get_Values
	|
	|-RVA: 0x3076E70 Offset: 0x3076F71 VA: 0x3076E70
	|-Dictionary<IntVec3, object>.get_Values
	|
	|-RVA: 0x307A560 Offset: 0x307A661 VA: 0x307A560
	|-Dictionary<Quaternion, object>.get_Values
	|
	|-RVA: 0x307DCC0 Offset: 0x307DDC1 VA: 0x307DCC0
	|-Dictionary<RangeInt, object>.get_Values
	|
	|-RVA: 0x30493D0 Offset: 0x30494D1 VA: 0x30493D0
	|-Dictionary<Rect, object>.get_Values
	|
	|-RVA: 0x304CB30 Offset: 0x304CC31 VA: 0x304CB30
	|-Dictionary<RectInt, object>.get_Values
	|
	|-RVA: 0x30501B0 Offset: 0x30502B1 VA: 0x30501B0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.get_Values
	|
	|-RVA: 0x3053820 Offset: 0x3053921 VA: 0x3053820
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Values
	|
	|-RVA: 0x3056E40 Offset: 0x3056F41 VA: 0x3056E40
	|-Dictionary<Vector2, object>.get_Values
	|
	|-RVA: 0x305A4C0 Offset: 0x305A5C1 VA: 0x305A4C0
	|-Dictionary<Vector2Int, object>.get_Values
	|
	|-RVA: 0x305DAE0 Offset: 0x305DBE1 VA: 0x305DAE0
	|-Dictionary<Vector3, object>.get_Values
	|
	|-RVA: 0x30611D0 Offset: 0x30612D1 VA: 0x30611D0
	|-Dictionary<Vector3Int, object>.get_Values
	|
	|-RVA: 0x2E3ABC0 Offset: 0x2E3ACC1 VA: 0x2E3ABC0
	|-Dictionary<Vector4, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E2D320 Offset: 0x2E2D421 VA: 0x2E2D320
	|-Dictionary<BaffamoID, BaffamoFestivalData>.get_Item
	|-Dictionary<BeanID, BeanData>.get_Item
	|-Dictionary<ActorID, ActorData>.get_Item
	|-Dictionary<ActorID, LifeCycleScriptPlayer>.get_Item
	|-Dictionary<ActorID, HumanStatusData>.get_Item
	|-Dictionary<ActorID, ItemStorageData>.get_Item
	|-Dictionary<ActorID, NpcStatusData>.get_Item
	|-Dictionary<ActorID, List<MonsterDataID>>.get_Item
	|-Dictionary<BadStatus, BadStatusEffectController.ObjInfo>.get_Item
	|-Dictionary<CharID, HumanDataArray>.get_Item
	|-Dictionary<CharID, SerializeMobCharVariationTalkDataTableArray>.get_Item
	|-Dictionary<FocusObjectType, FocusObjectName.BorderElement>.get_Item
	|-Dictionary<FocusObjectType, Func<FocusInterface, Color>>.get_Item
	|-Dictionary<Gender, List<SoundID>>.get_Item
	|-Dictionary<HairType, Dictionary<VariationNo, HumanData>>.get_Item
	|-Dictionary<Season, string>.get_Item
	|-Dictionary<TrackinCameraType, TrackingCameraSetting>.get_Item
	|-Dictionary<VariationNo, HumanData>.get_Item
	|-Dictionary<VariationNo, MobTalkData>.get_Item
	|-Dictionary<WantedFieldType, WantedField>.get_Item
	|-Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.get_Item
	|-Dictionary<EquipSlotType, AS_ToolController.ToolActionData>.get_Item
	|-Dictionary<EquipSlotType, HumanEquipItem>.get_Item
	|-Dictionary<FaceType, string>.get_Item
	|-Dictionary<FarmAction, SkillActionID[]>.get_Item
	|-Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.get_Item
	|-Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox>.get_Item
	|-Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>>.get_Item
	|-Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox>.get_Item
	|-Dictionary<FieldWoodBoxSpawnID, GameObject>.get_Item
	|-Dictionary<FoodID, GluttonFood>.get_Item
	|-Dictionary<GateDataID, GateController>.get_Item
	|-Dictionary<GimmickLayoutID, HashSet<GimmickBase>>.get_Item
	|-Dictionary<HumanMagicMotionType, HumanMagicMotionController.HumanMagicMotion>.get_Item
	|-Dictionary<ItemID, ItemPoolData>.get_Item
	|-Dictionary<Master, BossDataAssetBase>.get_Item
	|-Dictionary<Master, MonsterActionCodeDataTableArray>.get_Item
	|-Dictionary<MonsterActionBehaviorDataID, List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>>.get_Item
	|-Dictionary<MonsterDoctor.EvaluationType, string>.get_Item
	|-Dictionary<MonsterModelDataID, MonsterModelData>.get_Item
	|-Dictionary<MoveParamID, CharacterMoveParam>.get_Item
	|-Dictionary<NPCActionBehaviorDataID, List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>>.get_Item
	|-Dictionary<SnowmanObjectID, MocomocoData>.get_Item
	|-Dictionary<SnowmanObjectID, SnowballData>.get_Item
	|-Dictionary<SoundID, EnvironmentSoundDataTable>.get_Item
	|-Dictionary<SoundID, EnvironmentSoundController>.get_Item
	|-Dictionary<SoundID, AudioClip>.get_Item
	|-Dictionary<SystemLanguage, string>.get_Item
	|-Dictionary<Int32Enum, object>.get_Item
	|
	|-RVA: 0x2FEC530 Offset: 0x2FEC631 VA: 0x2FEC530
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>.get_Item
	|-Dictionary<BinaryDeserialization.ObjectFieldMap, List<int>>.get_Item
	|-Dictionary<CharacterBase, DamageTextController>.get_Item
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.get_Item
	|-Dictionary<OptionDefinition, OptionsControlBase>.get_Item
	|-Dictionary<Enum, StateElement>.get_Item
	|-Dictionary<int[], SceneSplit>.get_Item
	|-Dictionary<object, BehaviorManager.ThirdPartyTask>.get_Item
	|-Dictionary<object, ICollection<OptionDefinition>>.get_Item
	|-Dictionary<string, ActionCode>.get_Item
	|-Dictionary<string, IKeyframeGroup>.get_Item
	|-Dictionary<string, ProfileFeatureDefinition>.get_Item
	|-Dictionary<string, List<TaskCoroutine>>.get_Item
	|-Dictionary<string, List<GameObject>>.get_Item
	|-Dictionary<string, Func<bool>>.get_Item
	|-Dictionary<string, object>.get_Item
	|-Dictionary<string, string>.get_Item
	|-Dictionary<string, TeleportPortalData>.get_Item
	|-Dictionary<string, TeleportPositionDataObject>.get_Item
	|-Dictionary<string, SpringCapsuleCollider>.get_Item
	|-Dictionary<string, SpringPanelCollider>.get_Item
	|-Dictionary<string, SpringSphereCollider>.get_Item
	|-Dictionary<string, ResourceLocationData>.get_Item
	|-Dictionary<string, GameObject>.get_Item
	|-Dictionary<string, ResourceLocationBase>.get_Item
	|-Dictionary<string, Sprite>.get_Item
	|-Dictionary<string, Transform>.get_Item
	|-Dictionary<Thread, StackTrace>.get_Item
	|-Dictionary<Type, object>.get_Item
	|-Dictionary<MeshUniqueVertices.UniqueVertex, MeshUniqueVertices.RepeatedVertexList>.get_Item
	|-Dictionary<GameObject, Transform>.get_Item
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.get_Item
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.get_Item
	|-Dictionary<object, object>.get_Item
	|
	|-RVA: 0x2A16610 Offset: 0x2A16711 VA: 0x2A16610
	|-Dictionary<JSONDeserialization.TaskField, List<int>>.get_Item
	|-Dictionary<JSONDeserialization.TaskField, object>.get_Item
	|
	|-RVA: 0x2DC53C0 Offset: 0x2DC54C1 VA: 0x2DC53C0
	|-Dictionary<Character, float>.get_Item
	|-Dictionary<object, float>.get_Item
	|
	|-RVA: 0x2E29D60 Offset: 0x2E29E61 VA: 0x2E29D60
	|-Dictionary<ActorID, CharID>.get_Item
	|-Dictionary<ActorID, Master>.get_Item
	|-Dictionary<BadStatus, Prefab>.get_Item
	|-Dictionary<FieldPlaceId, Place>.get_Item
	|-Dictionary<GameFlagData, NPCID>.get_Item
	|-Dictionary<MakingID, CalendarDataTable.FestivalId>.get_Item
	|-Dictionary<Place, FieldPlaceId>.get_Item
	|-Dictionary<DualWorkType, Prefab>.get_Item
	|-Dictionary<FestivalType, Event>.get_Item
	|-Dictionary<GateEnemyModelContainer.GateType, EffectID>.get_Item
	|-Dictionary<ItemID, SkillID>.get_Item
	|-Dictionary<ItemID, ItemID>.get_Item
	|-Dictionary<ItemType, EquipPointType>.get_Item
	|-Dictionary<AKey, Key>.get_Item
	|-Dictionary<TitleCanvasControl.TitleCallID, RF5SystemData.FLAG>.get_Item
	|-Dictionary<RuntimePlatform, AddressablesPlatform>.get_Item
	|-Dictionary<Season, Texture>.get_Item
	|-Dictionary<Int32Enum, Int32Enum>.get_Item
	|
	|-RVA: 0x2E267A0 Offset: 0x2E268A1 VA: 0x2E267A0
	|-Dictionary<ActorID, int>.get_Item
	|-Dictionary<ButtonGuideId, int>.get_Item
	|-Dictionary<UseCameraType, int>.get_Item
	|-Dictionary<Weather, int>.get_Item
	|-Dictionary<ItemID, int>.get_Item
	|-Dictionary<RF5SystemData.FLAG, int>.get_Item
	|-Dictionary<UIMainManager.AttachId, int>.get_Item
	|-Dictionary<Int32Enum, int>.get_Item
	|
	|-RVA: 0x2E30940 Offset: 0x2E30A41 VA: 0x2E30940
	|-Dictionary<ActorID, float>.get_Item
	|-Dictionary<PartnerMovementOrderType, float>.get_Item
	|-Dictionary<Int32Enum, float>.get_Item
	|
	|-RVA: 0x2F74EE0 Offset: 0x2F74FE1 VA: 0x2F74EE0
	|-Dictionary<MonsterFootStepEventDataID, MonsterFootStepEventDataTable>.get_Item
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.get_Item
	|
	|-RVA: 0x2F960F0 Offset: 0x2F961F1 VA: 0x2F960F0
	|-Dictionary<TutorialScriptType, TutorialUnlockFlagData>.get_Item
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.get_Item
	|
	|-RVA: 0x2E23120 Offset: 0x2E23221 VA: 0x2E23120
	|-Dictionary<FieldSceneId, KeyValuePair<FarmManager.FARM_ID, int>>.get_Item
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.get_Item
	|
	|-RVA: 0x2E1C420 Offset: 0x2E1C521 VA: 0x2E1C420
	|-Dictionary<ItemCategory, PartnerNPCWeaponBehaviorDataTable>.get_Item
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.get_Item
	|
	|-RVA: 0x2E1FB40 Offset: 0x2E1FC41 VA: 0x2E1FB40
	|-Dictionary<ItemType, bool>.get_Item
	|-Dictionary<Int32Enum, bool>.get_Item
	|
	|-RVA: 0x2E375D0 Offset: 0x2E376D1 VA: 0x2E375D0
	|-Dictionary<MixerVolumeGroup, ValueTuple<float, float>>.get_Item
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.get_Item
	|
	|-RVA: 0x2F71230 Offset: 0x2F71331 VA: 0x2F71230
	|-Dictionary<MonsterDataID, MonsterDataTable>.get_Item
	|-Dictionary<Int32Enum, MonsterDataTable>.get_Item
	|
	|-RVA: 0x2DF97E0 Offset: 0x2DF98E1 VA: 0x2DF97E0
	|-Dictionary<OnGroundItem, int>.get_Item
	|-Dictionary<ParameterExpression, int>.get_Item
	|-Dictionary<string, int>.get_Item
	|-Dictionary<Type, int>.get_Item
	|-Dictionary<Simplifier.VertexDataHash, int>.get_Item
	|-Dictionary<Camera, int>.get_Item
	|-Dictionary<GameObject, int>.get_Item
	|-Dictionary<object, int>.get_Item
	|
	|-RVA: 0x2E33F00 Offset: 0x2E34001 VA: 0x2E33F00
	|-Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.get_Item
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.get_Item
	|
	|-RVA: 0x2DD2EB0 Offset: 0x2DD2FB1 VA: 0x2DD2EB0
	|-Dictionary<Enum, TransitionTables>.get_Item
	|-Dictionary<object, TransitionTables>.get_Item
	|
	|-RVA: 0x2F5FC50 Offset: 0x2F5FD51 VA: 0x2F5FC50
	|-Dictionary<int, ActorUtility.ActorCreateData>.get_Item
	|-Dictionary<int, Task>.get_Item
	|-Dictionary<int, BossBehaviorController>.get_Item
	|-Dictionary<int, BossStageManager>.get_Item
	|-Dictionary<int, DLCPair>.get_Item
	|-Dictionary<int, HairType[]>.get_Item
	|-Dictionary<int, EventControllerBase.FirstMatchInfo>.get_Item
	|-Dictionary<int, FarmSupportMonsterManager.FarmScene>.get_Item
	|-Dictionary<int, FishSwim>.get_Item
	|-Dictionary<int, HarinezumiController.NeedleController>.get_Item
	|-Dictionary<int, ItemID[]>.get_Item
	|-Dictionary<int, ASSET_TABLE>.get_Item
	|-Dictionary<int, AssetHandle>.get_Item
	|-Dictionary<int, MonsterActionInformation>.get_Item
	|-Dictionary<int, MonsterActionInformationBase>.get_Item
	|-Dictionary<int, MonsterBehaviorController.BehaviorActionParam>.get_Item
	|-Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState>.get_Item
	|-Dictionary<int, MonsterBehaviorController>.get_Item
	|-Dictionary<int, NPCBehaviorDataTable>.get_Item
	|-Dictionary<int, NPCFindTargetDataTable>.get_Item
	|-Dictionary<int, PartnerNPCBehaviorController>.get_Item
	|-Dictionary<int, Action>.get_Item
	|-Dictionary<int, Action<int>>.get_Item
	|-Dictionary<int, Dictionary<int, List<OrderMasterData>>>.get_Item
	|-Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>>.get_Item
	|-Dictionary<int, List<BossBehaviorParams>>.get_Item
	|-Dictionary<int, List<Character>>.get_Item
	|-Dictionary<int, List<MonsterBehaviorController.BehaviorActionParam>>.get_Item
	|-Dictionary<int, List<OrderMasterData>>.get_Item
	|-Dictionary<int, List<PartnerManager.DestinationAngle>>.get_Item
	|-Dictionary<int, List<TimeManager.JustTimerData>>.get_Item
	|-Dictionary<int, List<MeshDataConnectivity.Face>>.get_Item
	|-Dictionary<int, List<Vector3>>.get_Item
	|-Dictionary<int, Func<string>>.get_Item
	|-Dictionary<int, GameObject>.get_Item
	|-Dictionary<int, object>.get_Item
	|-Dictionary<int, string>.get_Item
	|-Dictionary<int, TimeType>.get_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.get_Item
	|
	|-RVA: 0x2D564C0 Offset: 0x2D565C1 VA: 0x2D564C0
	|-Dictionary<int, MineTypeID>.get_Item
	|-Dictionary<int, MonsterDataID>.get_Item
	|-Dictionary<int, SoundID>.get_Item
	|-Dictionary<int, Int32Enum>.get_Item
	|
	|-RVA: 0x2D4C360 Offset: 0x2D4C461 VA: 0x2D4C360
	|-Dictionary<int, bool>.get_Item
	|
	|-RVA: 0x2D52F00 Offset: 0x2D53001 VA: 0x2D52F00
	|-Dictionary<int, int>.get_Item
	|
	|-RVA: 0x2F66D90 Offset: 0x2F66E91 VA: 0x2F66D90
	|-Dictionary<int, SceneInstance>.get_Item
	|
	|-RVA: 0x2F6A460 Offset: 0x2F6A561 VA: 0x2F6A460
	|-Dictionary<int, Vector2Int>.get_Item
	|
	|-RVA: 0x2F6DAE0 Offset: 0x2F6DBE1 VA: 0x2F6DAE0
	|-Dictionary<int, Vector3>.get_Item
	|
	|-RVA: 0x30B8DA0 Offset: 0x30B8EA1 VA: 0x30B8DA0
	|-Dictionary<string, FieldPlaceId>.get_Item
	|-Dictionary<string, GameFlagData>.get_Item
	|-Dictionary<string, SoundID>.get_Item
	|-Dictionary<string, SystemLanguage>.get_Item
	|-Dictionary<Event, TextEditor.TextEditOp>.get_Item
	|-Dictionary<object, Int32Enum>.get_Item
	|
	|-RVA: 0x31A3BB0 Offset: 0x31A3CB1 VA: 0x31A3BB0
	|-Dictionary<uint, ActorID>.get_Item
	|-Dictionary<uint, PartnerMovementOrderType>.get_Item
	|-Dictionary<uint, Int32Enum>.get_Item
	|
	|-RVA: 0x31A7170 Offset: 0x31A7271 VA: 0x31A7170
	|-Dictionary<uint, FriendMonsterStatus>.get_Item
	|-Dictionary<uint, SaveDataBase.ReaderFunc>.get_Item
	|-Dictionary<uint, TMP_Character>.get_Item
	|-Dictionary<uint, TMP_SpriteGlyph>.get_Item
	|-Dictionary<uint, Glyph>.get_Item
	|-Dictionary<uint, object>.get_Item
	|
	|-RVA: 0x31ADDB0 Offset: 0x31ADEB1 VA: 0x31ADDB0
	|-Dictionary<EdgeKeyByHash, int>.get_Item
	|
	|-RVA: 0x31B4FD0 Offset: 0x31B50D1 VA: 0x31B4FD0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.get_Item
	|
	|-RVA: 0x302D3D0 Offset: 0x302D4D1 VA: 0x302D3D0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.get_Item
	|
	|-RVA: 0x3034410 Offset: 0x3034511 VA: 0x3034410
	|-Dictionary<MeshDataConnectivity.Face, List<int>>.get_Item
	|-Dictionary<MeshDataConnectivity.Face, object>.get_Item
	|
	|-RVA: 0x2DE4F50 Offset: 0x2DE5051 VA: 0x2DE4F50
	|-Dictionary<Camera, bool>.get_Item
	|-Dictionary<object, bool>.get_Item
	|
	|-RVA: 0x305DB80 Offset: 0x305DC81 VA: 0x305DB80
	|-Dictionary<Vector3, List<int>>.get_Item
	|-Dictionary<Vector3, object>.get_Item
	|
	|-RVA: 0x2A19CA0 Offset: 0x2A19DA1 VA: 0x2A19CA0
	|-Dictionary<BitVector32Int, object>.get_Item
	|
	|-RVA: 0x2F78A00 Offset: 0x2F78B01 VA: 0x2F78A00
	|-Dictionary<EventCheckId, object>.get_Item
	|
	|-RVA: 0x2F7C530 Offset: 0x2F7C631 VA: 0x2F7C530
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.get_Item
	|
	|-RVA: 0x2F80600 Offset: 0x2F80701 VA: 0x2F80600
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.get_Item
	|
	|-RVA: 0x2F84130 Offset: 0x2F84231 VA: 0x2F84130
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.get_Item
	|
	|-RVA: 0x2F87840 Offset: 0x2F87941 VA: 0x2F87840
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.get_Item
	|
	|-RVA: 0x2F8AEC0 Offset: 0x2F8AFC1 VA: 0x2F8AEC0
	|-Dictionary<MonsterHutSaveData, object>.get_Item
	|
	|-RVA: 0x2F8EC50 Offset: 0x2F8ED51 VA: 0x2F8EC50
	|-Dictionary<OrderLotterySaveParameter, object>.get_Item
	|
	|-RVA: 0x2F92360 Offset: 0x2F92461 VA: 0x2F92360
	|-Dictionary<OrderSaveData, object>.get_Item
	|
	|-RVA: 0x2D80470 Offset: 0x2D80571 VA: 0x2D80470
	|-Dictionary<OrderSaveParameter, object>.get_Item
	|
	|-RVA: 0x2D83FD0 Offset: 0x2D840D1 VA: 0x2D83FD0
	|-Dictionary<Parameter, object>.get_Item
	|
	|-RVA: 0x2D87D40 Offset: 0x2D87E41 VA: 0x2D87D40
	|-Dictionary<bool, object>.get_Item
	|
	|-RVA: 0x2D8B3C0 Offset: 0x2D8B4C1 VA: 0x2D8B3C0
	|-Dictionary<byte, object>.get_Item
	|
	|-RVA: 0x2D8E9E0 Offset: 0x2D8EAE1 VA: 0x2D8E9E0
	|-Dictionary<char, object>.get_Item
	|
	|-RVA: 0x2D92000 Offset: 0x2D92101 VA: 0x2D92000
	|-Dictionary<DateTime, object>.get_Item
	|
	|-RVA: 0x2D95620 Offset: 0x2D95721 VA: 0x2D95620
	|-Dictionary<double, object>.get_Item
	|
	|-RVA: 0x2D98C30 Offset: 0x2D98D31 VA: 0x2D98C30
	|-Dictionary<Guid, object>.get_Item
	|
	|-RVA: 0x2D9C2B0 Offset: 0x2D9C3B1 VA: 0x2D9C2B0
	|-Dictionary<short, object>.get_Item
	|
	|-RVA: 0x2D3A480 Offset: 0x2D3A581 VA: 0x2D3A480
	|-Dictionary<int, CropDataTable>.get_Item
	|
	|-RVA: 0x2D3E080 Offset: 0x2D3E181 VA: 0x2D3E080
	|-Dictionary<int, EffectDataTable>.get_Item
	|
	|-RVA: 0x2D419F0 Offset: 0x2D41AF1 VA: 0x2D419F0
	|-Dictionary<int, GimmickLayoutDataTable>.get_Item
	|
	|-RVA: 0x2D44FC0 Offset: 0x2D450C1 VA: 0x2D44FC0
	|-Dictionary<int, MineTypeDataTable>.get_Item
	|
	|-RVA: 0x2D48C90 Offset: 0x2D48D91 VA: 0x2D48C90
	|-Dictionary<int, MiningDataTable>.get_Item
	|
	|-RVA: 0x2D4F940 Offset: 0x2D4FA41 VA: 0x2D4F940
	|-Dictionary<int, char>.get_Item
	|
	|-RVA: 0x2F5C5C0 Offset: 0x2F5C6C1 VA: 0x2F5C5C0
	|-Dictionary<int, long>.get_Item
	|
	|-RVA: 0x2F63270 Offset: 0x2F63371 VA: 0x2F63270
	|-Dictionary<int, DiagnosticEvent>.get_Item
	|
	|-RVA: 0x2F99840 Offset: 0x2F99941 VA: 0x2F99840
	|-Dictionary<long, object>.get_Item
	|
	|-RVA: 0x2F9CE60 Offset: 0x2F9CF61 VA: 0x2F9CE60
	|-Dictionary<Memory<object>, object>.get_Item
	|
	|-RVA: 0x2FA04F0 Offset: 0x2FA05F1 VA: 0x2FA04F0
	|-Dictionary<Nullable<Int32Enum>, object>.get_Item
	|
	|-RVA: 0x2FA3CD0 Offset: 0x2FA3DD1 VA: 0x2FA3CD0
	|-Dictionary<Nullable<Bounds>, object>.get_Item
	|
	|-RVA: 0x2FA7C30 Offset: 0x2FA7D31 VA: 0x2FA7C30
	|-Dictionary<Nullable<BoundsInt>, object>.get_Item
	|
	|-RVA: 0x2FABB90 Offset: 0x2FABC91 VA: 0x2FABB90
	|-Dictionary<Nullable<Color32>, object>.get_Item
	|
	|-RVA: 0x2FAF370 Offset: 0x2FAF471 VA: 0x2FAF370
	|-Dictionary<Nullable<Color>, object>.get_Item
	|
	|-RVA: 0x2F1A460 Offset: 0x2F1A561 VA: 0x2F1A460
	|-Dictionary<Nullable<GradientAlphaKey>, object>.get_Item
	|
	|-RVA: 0x2F1DD30 Offset: 0x2F1DE31 VA: 0x2F1DD30
	|-Dictionary<Nullable<GradientColorKey>, object>.get_Item
	|
	|-RVA: 0x2F21A30 Offset: 0x2F21B31 VA: 0x2F21A30
	|-Dictionary<Nullable<Keyframe>, object>.get_Item
	|
	|-RVA: 0x2F25760 Offset: 0x2F25861 VA: 0x2F25760
	|-Dictionary<Nullable<LayerMask>, object>.get_Item
	|
	|-RVA: 0x2F28F40 Offset: 0x2F29041 VA: 0x2F28F40
	|-Dictionary<Nullable<Matrix4x4>, object>.get_Item
	|
	|-RVA: 0x2F2D4B0 Offset: 0x2F2D5B1 VA: 0x2F2D4B0
	|-Dictionary<Nullable<Quaternion>, object>.get_Item
	|
	|-RVA: 0x2F311B0 Offset: 0x2F312B1 VA: 0x2F311B0
	|-Dictionary<Nullable<RangeInt>, object>.get_Item
	|
	|-RVA: 0x2F34A80 Offset: 0x2F34B81 VA: 0x2F34A80
	|-Dictionary<Nullable<Rect>, object>.get_Item
	|
	|-RVA: 0x2EFD790 Offset: 0x2EFD891 VA: 0x2EFD790
	|-Dictionary<Nullable<RectInt>, object>.get_Item
	|
	|-RVA: 0x2F01490 Offset: 0x2F01591 VA: 0x2F01490
	|-Dictionary<Nullable<Vector2>, object>.get_Item
	|
	|-RVA: 0x2F04D60 Offset: 0x2F04E61 VA: 0x2F04D60
	|-Dictionary<Nullable<Vector2Int>, object>.get_Item
	|
	|-RVA: 0x2F08630 Offset: 0x2F08731 VA: 0x2F08630
	|-Dictionary<Nullable<Vector3>, object>.get_Item
	|
	|-RVA: 0x2F0BE70 Offset: 0x2F0BF71 VA: 0x2F0BE70
	|-Dictionary<Nullable<Vector3Int>, object>.get_Item
	|
	|-RVA: 0x2F0F6B0 Offset: 0x2F0F7B1 VA: 0x2F0F6B0
	|-Dictionary<Nullable<Vector4>, object>.get_Item
	|
	|-RVA: 0x2F133B0 Offset: 0x2F134B1 VA: 0x2F133B0
	|-Dictionary<object, BitVector32Int>.get_Item
	|
	|-RVA: 0x2F16A70 Offset: 0x2F16B71 VA: 0x2F16A70
	|-Dictionary<object, EventCheckId>.get_Item
	|
	|-RVA: 0x2FF3250 Offset: 0x2FF3351 VA: 0x2FF3250
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.get_Item
	|
	|-RVA: 0x2FF6F90 Offset: 0x2FF7091 VA: 0x2FF6F90
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.get_Item
	|
	|-RVA: 0x2FFA960 Offset: 0x2FFAA61 VA: 0x2FFA960
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.get_Item
	|
	|-RVA: 0x2FFE090 Offset: 0x2FFE191 VA: 0x2FFE090
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.get_Item
	|
	|-RVA: 0x3001780 Offset: 0x3001881 VA: 0x3001780
	|-Dictionary<object, MonsterHutSaveData>.get_Item
	|
	|-RVA: 0x30052C0 Offset: 0x30053C1 VA: 0x30052C0
	|-Dictionary<object, OrderLotterySaveParameter>.get_Item
	|
	|-RVA: 0x30089F0 Offset: 0x3008AF1 VA: 0x30089F0
	|-Dictionary<object, OrderSaveData>.get_Item
	|
	|-RVA: 0x300C540 Offset: 0x300C641 VA: 0x300C540
	|-Dictionary<object, OrderSaveParameter>.get_Item
	|
	|-RVA: 0x2DDDC50 Offset: 0x2DDDD51 VA: 0x2DDDC50
	|-Dictionary<object, Parameter>.get_Item
	|
	|-RVA: 0x2DE1880 Offset: 0x2DE1981 VA: 0x2DE1880
	|-Dictionary<object, NumberControl.ValueRange>.get_Item
	|
	|-RVA: 0x2DE8630 Offset: 0x2DE8731 VA: 0x2DE8630
	|-Dictionary<object, byte>.get_Item
	|
	|-RVA: 0x2DEBCF0 Offset: 0x2DEBDF1 VA: 0x2DEBCF0
	|-Dictionary<object, char>.get_Item
	|
	|-RVA: 0x2DEF3B0 Offset: 0x2DEF4B1 VA: 0x2DEF3B0
	|-Dictionary<object, DateTime>.get_Item
	|
	|-RVA: 0x2DF2A60 Offset: 0x2DF2B61 VA: 0x2DF2A60
	|-Dictionary<object, double>.get_Item
	|
	|-RVA: 0x2DF6120 Offset: 0x2DF6221 VA: 0x2DF6120
	|-Dictionary<object, short>.get_Item
	|
	|-RVA: 0x30BC460 Offset: 0x30BC561 VA: 0x30BC460
	|-Dictionary<object, long>.get_Item
	|
	|-RVA: 0x30BFB10 Offset: 0x30BFC11 VA: 0x30BFB10
	|-Dictionary<object, Memory<object>>.get_Item
	|
	|-RVA: 0x30C3230 Offset: 0x30C3331 VA: 0x30C3230
	|-Dictionary<object, Nullable<Int32Enum>>.get_Item
	|
	|-RVA: 0x30C69D0 Offset: 0x30C6AD1 VA: 0x30C69D0
	|-Dictionary<object, Nullable<Bounds>>.get_Item
	|
	|-RVA: 0x30CA630 Offset: 0x30CA731 VA: 0x30CA630
	|-Dictionary<object, Nullable<BoundsInt>>.get_Item
	|
	|-RVA: 0x30CE290 Offset: 0x30CE391 VA: 0x30CE290
	|-Dictionary<object, Nullable<Color32>>.get_Item
	|
	|-RVA: 0x30D1A30 Offset: 0x30D1B31 VA: 0x30D1A30
	|-Dictionary<object, Nullable<Color>>.get_Item
	|
	|-RVA: 0x300FF70 Offset: 0x3010071 VA: 0x300FF70
	|-Dictionary<object, Nullable<GradientAlphaKey>>.get_Item
	|
	|-RVA: 0x30137C0 Offset: 0x30138C1 VA: 0x30137C0
	|-Dictionary<object, Nullable<GradientColorKey>>.get_Item
	|
	|-RVA: 0x30172B0 Offset: 0x30173B1 VA: 0x30172B0
	|-Dictionary<object, Nullable<Keyframe>>.get_Item
	|
	|-RVA: 0x301ADE0 Offset: 0x301AEE1 VA: 0x301ADE0
	|-Dictionary<object, Nullable<LayerMask>>.get_Item
	|
	|-RVA: 0x301E580 Offset: 0x301E681 VA: 0x301E580
	|-Dictionary<object, Nullable<Matrix4x4>>.get_Item
	|
	|-RVA: 0x3022580 Offset: 0x3022681 VA: 0x3022580
	|-Dictionary<object, Nullable<Quaternion>>.get_Item
	|
	|-RVA: 0x3026080 Offset: 0x3026181 VA: 0x3026080
	|-Dictionary<object, Nullable<RangeInt>>.get_Item
	|
	|-RVA: 0x30298D0 Offset: 0x30299D1 VA: 0x30298D0
	|-Dictionary<object, Nullable<Rect>>.get_Item
	|
	|-RVA: 0x2FD6EB0 Offset: 0x2FD6FB1 VA: 0x2FD6EB0
	|-Dictionary<object, Nullable<RectInt>>.get_Item
	|
	|-RVA: 0x2FDA9B0 Offset: 0x2FDAAB1 VA: 0x2FDA9B0
	|-Dictionary<object, Nullable<Vector2>>.get_Item
	|
	|-RVA: 0x2FDE200 Offset: 0x2FDE301 VA: 0x2FDE200
	|-Dictionary<object, Nullable<Vector2Int>>.get_Item
	|
	|-RVA: 0x2FE1A50 Offset: 0x2FE1B51 VA: 0x2FE1A50
	|-Dictionary<object, Nullable<Vector3>>.get_Item
	|
	|-RVA: 0x2FE5240 Offset: 0x2FE5341 VA: 0x2FE5240
	|-Dictionary<object, Nullable<Vector3Int>>.get_Item
	|
	|-RVA: 0x2FE8A30 Offset: 0x2FE8B31 VA: 0x2FE8A30
	|-Dictionary<object, Nullable<Vector4>>.get_Item
	|
	|-RVA: 0x2FEFB30 Offset: 0x2FEFC31 VA: 0x2FEFB30
	|-Dictionary<object, ReadOnlyMemory<object>>.get_Item
	|
	|-RVA: 0x2DBE5E0 Offset: 0x2DBE6E1 VA: 0x2DBE5E0
	|-Dictionary<object, ResourceLocator>.get_Item
	|
	|-RVA: 0x2DC1D00 Offset: 0x2DC1E01 VA: 0x2DC1D00
	|-Dictionary<object, sbyte>.get_Item
	|
	|-RVA: 0x2DC8A80 Offset: 0x2DC8B81 VA: 0x2DC8A80
	|-Dictionary<object, ushort>.get_Item
	|
	|-RVA: 0x2DCC140 Offset: 0x2DCC241 VA: 0x2DCC140
	|-Dictionary<object, uint>.get_Item
	|
	|-RVA: 0x2DCF800 Offset: 0x2DCF901 VA: 0x2DCF800
	|-Dictionary<object, ulong>.get_Item
	|
	|-RVA: 0x2DD68D0 Offset: 0x2DD69D1 VA: 0x2DD68D0
	|-Dictionary<object, Bounds>.get_Item
	|
	|-RVA: 0x2DDA290 Offset: 0x2DDA391 VA: 0x2DDA290
	|-Dictionary<object, BoundsInt>.get_Item
	|
	|-RVA: 0x30D5530 Offset: 0x30D5631 VA: 0x30D5530
	|-Dictionary<object, Color32>.get_Item
	|
	|-RVA: 0x30D8BF0 Offset: 0x30D8CF1 VA: 0x30D8BF0
	|-Dictionary<object, Color>.get_Item
	|
	|-RVA: 0x30DC310 Offset: 0x30DC411 VA: 0x30DC310
	|-Dictionary<object, GradientAlphaKey>.get_Item
	|
	|-RVA: 0x30DFA00 Offset: 0x30DFB01 VA: 0x30DFA00
	|-Dictionary<object, GradientColorKey>.get_Item
	|
	|-RVA: 0x30E33D0 Offset: 0x30E34D1 VA: 0x30E33D0
	|-Dictionary<object, Keyframe>.get_Item
	|
	|-RVA: 0x30E6F10 Offset: 0x30E7011 VA: 0x30E6F10
	|-Dictionary<object, LayerMask>.get_Item
	|
	|-RVA: 0x30EA5D0 Offset: 0x30EA6D1 VA: 0x30EA5D0
	|-Dictionary<object, Matrix4x4>.get_Item
	|
	|-RVA: 0x30EE280 Offset: 0x30EE381 VA: 0x30EE280
	|-Dictionary<object, Playable>.get_Item
	|
	|-RVA: 0x309D080 Offset: 0x309D181 VA: 0x309D080
	|-Dictionary<object, Quaternion>.get_Item
	|
	|-RVA: 0x30A07A0 Offset: 0x30A08A1 VA: 0x30A07A0
	|-Dictionary<object, RangeInt>.get_Item
	|
	|-RVA: 0x30A3E50 Offset: 0x30A3F51 VA: 0x30A3E50
	|-Dictionary<object, Rect>.get_Item
	|
	|-RVA: 0x30A7570 Offset: 0x30A7671 VA: 0x30A7570
	|-Dictionary<object, RectInt>.get_Item
	|
	|-RVA: 0x30AAC60 Offset: 0x30AAD61 VA: 0x30AAC60
	|-Dictionary<object, AsyncOperationHandle>.get_Item
	|
	|-RVA: 0x30AE630 Offset: 0x30AE731 VA: 0x30AE630
	|-Dictionary<object, AsyncOperationHandle<object>>.get_Item
	|
	|-RVA: 0x30B2000 Offset: 0x30B2101 VA: 0x30B2000
	|-Dictionary<object, Vector2>.get_Item
	|
	|-RVA: 0x30B56F0 Offset: 0x30B57F1 VA: 0x30B56F0
	|-Dictionary<object, Vector2Int>.get_Item
	|
	|-RVA: 0x3081380 Offset: 0x3081481 VA: 0x3081380
	|-Dictionary<object, Vector3>.get_Item
	|
	|-RVA: 0x3084A90 Offset: 0x3084B91 VA: 0x3084A90
	|-Dictionary<object, Vector3Int>.get_Item
	|
	|-RVA: 0x30881C0 Offset: 0x30882C1 VA: 0x30881C0
	|-Dictionary<object, Vector4>.get_Item
	|
	|-RVA: 0x308B8E0 Offset: 0x308B9E1 VA: 0x308B8E0
	|-Dictionary<ReadOnlyMemory<object>, object>.get_Item
	|
	|-RVA: 0x308EF70 Offset: 0x308F071 VA: 0x308EF70
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.get_Item
	|
	|-RVA: 0x3092600 Offset: 0x3092701 VA: 0x3092600
	|-Dictionary<sbyte, object>.get_Item
	|
	|-RVA: 0x3095C20 Offset: 0x3095D21 VA: 0x3095C20
	|-Dictionary<float, CurveSample>.get_Item
	|
	|-RVA: 0x3099A70 Offset: 0x3099B71 VA: 0x3099A70
	|-Dictionary<float, object>.get_Item
	|
	|-RVA: 0x319CFD0 Offset: 0x319D0D1 VA: 0x319CFD0
	|-Dictionary<ushort, object>.get_Item
	|
	|-RVA: 0x31A05F0 Offset: 0x31A06F1 VA: 0x31A05F0
	|-Dictionary<uint, int>.get_Item
	|
	|-RVA: 0x31AA790 Offset: 0x31AA891 VA: 0x31AA790
	|-Dictionary<ulong, object>.get_Item
	|
	|-RVA: 0x31B1420 Offset: 0x31B1521 VA: 0x31B1420
	|-Dictionary<EdgeKeyByHash, CapEdge>.get_Item
	|
	|-RVA: 0x3030D80 Offset: 0x3030E81 VA: 0x3030D80
	|-Dictionary<MeshDataConnectivity.Face, bool>.get_Item
	|
	|-RVA: 0x3037A30 Offset: 0x3037B31 VA: 0x3037A30
	|-Dictionary<Bounds, object>.get_Item
	|
	|-RVA: 0x303B560 Offset: 0x303B661 VA: 0x303B560
	|-Dictionary<BoundsInt, object>.get_Item
	|
	|-RVA: 0x303F090 Offset: 0x303F191 VA: 0x303F090
	|-Dictionary<Color, object>.get_Item
	|
	|-RVA: 0x30427F0 Offset: 0x30428F1 VA: 0x30427F0
	|-Dictionary<Color32, object>.get_Item
	|
	|-RVA: 0x3045E50 Offset: 0x3045F51 VA: 0x3045E50
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.get_Item
	|
	|-RVA: 0x3064980 Offset: 0x3064A81 VA: 0x3064980
	|-Dictionary<GradientAlphaKey, object>.get_Item
	|
	|-RVA: 0x3068000 Offset: 0x3068101 VA: 0x3068000
	|-Dictionary<GradientColorKey, object>.get_Item
	|
	|-RVA: 0x306BB30 Offset: 0x306BC31 VA: 0x306BB30
	|-Dictionary<Keyframe, object>.get_Item
	|
	|-RVA: 0x306F8B0 Offset: 0x306F9B1 VA: 0x306F8B0
	|-Dictionary<LayerMask, object>.get_Item
	|
	|-RVA: 0x3072F10 Offset: 0x3073011 VA: 0x3072F10
	|-Dictionary<Matrix4x4, object>.get_Item
	|
	|-RVA: 0x3076F10 Offset: 0x3077011 VA: 0x3076F10
	|-Dictionary<IntVec3, object>.get_Item
	|
	|-RVA: 0x307A600 Offset: 0x307A701 VA: 0x307A600
	|-Dictionary<Quaternion, object>.get_Item
	|
	|-RVA: 0x307DD60 Offset: 0x307DE61 VA: 0x307DD60
	|-Dictionary<RangeInt, object>.get_Item
	|
	|-RVA: 0x3049470 Offset: 0x3049571 VA: 0x3049470
	|-Dictionary<Rect, object>.get_Item
	|
	|-RVA: 0x304CBD0 Offset: 0x304CCD1 VA: 0x304CBD0
	|-Dictionary<RectInt, object>.get_Item
	|
	|-RVA: 0x3050250 Offset: 0x3050351 VA: 0x3050250
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.get_Item
	|
	|-RVA: 0x30538C0 Offset: 0x30539C1 VA: 0x30538C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Item
	|
	|-RVA: 0x3056EE0 Offset: 0x3056FE1 VA: 0x3056EE0
	|-Dictionary<Vector2, object>.get_Item
	|
	|-RVA: 0x305A560 Offset: 0x305A661 VA: 0x305A560
	|-Dictionary<Vector2Int, object>.get_Item
	|
	|-RVA: 0x3061270 Offset: 0x3061371 VA: 0x3061270
	|-Dictionary<Vector3Int, object>.get_Item
	|
	|-RVA: 0x2E3AC60 Offset: 0x2E3AD61 VA: 0x2E3AC60
	|-Dictionary<Vector4, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16700 Offset: 0x2A16801 VA: 0x2A16700
	|-Dictionary<JSONDeserialization.TaskField, object>.set_Item
	|
	|-RVA: 0x2A19D80 Offset: 0x2A19E81 VA: 0x2A19D80
	|-Dictionary<BitVector32Int, object>.set_Item
	|
	|-RVA: 0x2FEC610 Offset: 0x2FEC711 VA: 0x2FEC610
	|-Dictionary<ICinemachineCamera, object>.set_Item
	|-Dictionary<Tween, TweenLink>.set_Item
	|-Dictionary<Action, LinkedListNode<Action>>.set_Item
	|-Dictionary<byte[], Encoding>.set_Item
	|-Dictionary<Enum, StateElement>.set_Item
	|-Dictionary<int[], Terrain>.set_Item
	|-Dictionary<ParameterExpression, LocalVariable>.set_Item
	|-Dictionary<object, object>.set_Item
	|-Dictionary<string, ActionCode>.set_Item
	|-Dictionary<string, IKeyframeGroup>.set_Item
	|-Dictionary<string, ProfileFeatureDefinition>.set_Item
	|-Dictionary<string, ProfileGroupDefinition>.set_Item
	|-Dictionary<string, Texture[]>.set_Item
	|-Dictionary<string, SimpleCollator>.set_Item
	|-Dictionary<string, List<TaskCoroutine>>.set_Item
	|-Dictionary<string, Delegate>.set_Item
	|-Dictionary<string, CultureInfo>.set_Item
	|-Dictionary<string, object>.set_Item
	|-Dictionary<string, string>.set_Item
	|-Dictionary<string, UriParser>.set_Item
	|-Dictionary<string, TeleportPositionDataObject>.set_Item
	|-Dictionary<string, GUIStyle>.set_Item
	|-Dictionary<Type, AttributeUsageAttribute>.set_Item
	|-Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>.set_Item
	|-Dictionary<Camera, Camera>.set_Item
	|-Dictionary<GameObject, Transform>.set_Item
	|-Dictionary<Transform, List<SpringBone>>.set_Item
	|
	|-RVA: 0x2E2D400 Offset: 0x2E2D501 VA: 0x2E2D400
	|-Dictionary<ActorID, HumanStatusData>.set_Item
	|-Dictionary<ActorID, ItemStorageData>.set_Item
	|-Dictionary<WantedFieldType, WantedField>.set_Item
	|-Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.set_Item
	|-Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox>.set_Item
	|-Dictionary<FieldWoodBoxSpawnID, GameObject>.set_Item
	|-Dictionary<Master, BossDataAssetBase>.set_Item
	|-Dictionary<Master, MonsterActionCodeDataTableArray>.set_Item
	|-Dictionary<Texture, Texture>.set_Item
	|-Dictionary<SoundID, AudioClip>.set_Item
	|-Dictionary<Int32Enum, object>.set_Item
	|
	|-RVA: 0x2E30A10 Offset: 0x2E30B11 VA: 0x2E30A10
	|-Dictionary<ActorID, float>.set_Item
	|-Dictionary<AttackAttribute, float>.set_Item
	|-Dictionary<PartnerMovementOrderType, float>.set_Item
	|-Dictionary<Int32Enum, float>.set_Item
	|
	|-RVA: 0x2E29E30 Offset: 0x2E29F31 VA: 0x2E29E30
	|-Dictionary<Season, Texture>.set_Item
	|-Dictionary<Int32Enum, Int32Enum>.set_Item
	|
	|-RVA: 0x2F78B00 Offset: 0x2F78C01 VA: 0x2F78B00
	|-Dictionary<EventCheckId, object>.set_Item
	|
	|-RVA: 0x2F7C660 Offset: 0x2F7C761 VA: 0x2F7C660
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.set_Item
	|
	|-RVA: 0x2F80700 Offset: 0x2F80801 VA: 0x2F80700
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.set_Item
	|
	|-RVA: 0x2F84220 Offset: 0x2F84321 VA: 0x2F84220
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.set_Item
	|
	|-RVA: 0x2F87930 Offset: 0x2F87A31 VA: 0x2F87930
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.set_Item
	|
	|-RVA: 0x2E26870 Offset: 0x2E26971 VA: 0x2E26870
	|-Dictionary<ItemID, int>.set_Item
	|-Dictionary<Int32Enum, int>.set_Item
	|
	|-RVA: 0x2F8AFD0 Offset: 0x2F8B0D1 VA: 0x2F8AFD0
	|-Dictionary<MonsterHutSaveData, object>.set_Item
	|
	|-RVA: 0x2F8ED40 Offset: 0x2F8EE41 VA: 0x2F8ED40
	|-Dictionary<OrderLotterySaveParameter, object>.set_Item
	|
	|-RVA: 0x2F92470 Offset: 0x2F92571 VA: 0x2F92470
	|-Dictionary<OrderSaveData, object>.set_Item
	|
	|-RVA: 0x2D80570 Offset: 0x2D80671 VA: 0x2D80570
	|-Dictionary<OrderSaveParameter, object>.set_Item
	|
	|-RVA: 0x2D840E0 Offset: 0x2D841E1 VA: 0x2D840E0
	|-Dictionary<Parameter, object>.set_Item
	|
	|-RVA: 0x2D87E20 Offset: 0x2D87F21 VA: 0x2D87E20
	|-Dictionary<bool, object>.set_Item
	|
	|-RVA: 0x2D8B4A0 Offset: 0x2D8B5A1 VA: 0x2D8B4A0
	|-Dictionary<byte, object>.set_Item
	|
	|-RVA: 0x2D8EAC0 Offset: 0x2D8EBC1 VA: 0x2D8EAC0
	|-Dictionary<char, object>.set_Item
	|
	|-RVA: 0x2D920E0 Offset: 0x2D921E1 VA: 0x2D920E0
	|-Dictionary<DateTime, object>.set_Item
	|
	|-RVA: 0x2D95700 Offset: 0x2D95801 VA: 0x2D95700
	|-Dictionary<double, object>.set_Item
	|
	|-RVA: 0x2D98D20 Offset: 0x2D98E21 VA: 0x2D98D20
	|-Dictionary<Guid, object>.set_Item
	|
	|-RVA: 0x2D9C390 Offset: 0x2D9C491 VA: 0x2D9C390
	|-Dictionary<short, object>.set_Item
	|
	|-RVA: 0x2D3A570 Offset: 0x2D3A671 VA: 0x2D3A570
	|-Dictionary<int, CropDataTable>.set_Item
	|
	|-RVA: 0x2D3E170 Offset: 0x2D3E271 VA: 0x2D3E170
	|-Dictionary<int, EffectDataTable>.set_Item
	|
	|-RVA: 0x2D41AC0 Offset: 0x2D41BC1 VA: 0x2D41AC0
	|-Dictionary<int, GimmickLayoutDataTable>.set_Item
	|
	|-RVA: 0x2D450C0 Offset: 0x2D451C1 VA: 0x2D450C0
	|-Dictionary<int, MineTypeDataTable>.set_Item
	|
	|-RVA: 0x2D56590 Offset: 0x2D56691 VA: 0x2D56590
	|-Dictionary<int, MineTypeID>.set_Item
	|-Dictionary<int, Int32Enum>.set_Item
	|
	|-RVA: 0x2D48D70 Offset: 0x2D48E71 VA: 0x2D48D70
	|-Dictionary<int, MiningDataTable>.set_Item
	|
	|-RVA: 0x2F5FD30 Offset: 0x2F5FE31 VA: 0x2F5FD30
	|-Dictionary<int, OnGroundItem>.set_Item
	|-Dictionary<int, List<WeakReference>>.set_Item
	|-Dictionary<int, Func<string>>.set_Item
	|-Dictionary<int, CultureInfo>.set_Item
	|-Dictionary<int, object>.set_Item
	|-Dictionary<int, string>.set_Item
	|-Dictionary<int, Task>.set_Item
	|-Dictionary<int, TextureChangeMaterialParam>.set_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.set_Item
	|-Dictionary<int, GUILayoutUtility.LayoutCache>.set_Item
	|-Dictionary<int, GameObject>.set_Item
	|
	|-RVA: 0x2D4C430 Offset: 0x2D4C531 VA: 0x2D4C430
	|-Dictionary<int, bool>.set_Item
	|
	|-RVA: 0x2D4FA10 Offset: 0x2D4FB11 VA: 0x2D4FA10
	|-Dictionary<int, char>.set_Item
	|
	|-RVA: 0x2D52FD0 Offset: 0x2D530D1 VA: 0x2D52FD0
	|-Dictionary<int, int>.set_Item
	|
	|-RVA: 0x2F5C6A0 Offset: 0x2F5C7A1 VA: 0x2F5C6A0
	|-Dictionary<int, long>.set_Item
	|
	|-RVA: 0x2F63370 Offset: 0x2F63471 VA: 0x2F63370
	|-Dictionary<int, DiagnosticEvent>.set_Item
	|
	|-RVA: 0x2F66E70 Offset: 0x2F66F71 VA: 0x2F66E70
	|-Dictionary<int, SceneInstance>.set_Item
	|
	|-RVA: 0x2F6A540 Offset: 0x2F6A641 VA: 0x2F6A540
	|-Dictionary<int, Vector2Int>.set_Item
	|
	|-RVA: 0x2F6DBC0 Offset: 0x2F6DCC1 VA: 0x2F6DBC0
	|-Dictionary<int, Vector3>.set_Item
	|
	|-RVA: 0x2F71320 Offset: 0x2F71421 VA: 0x2F71320
	|-Dictionary<Int32Enum, MonsterDataTable>.set_Item
	|
	|-RVA: 0x2F74FE0 Offset: 0x2F750E1 VA: 0x2F74FE0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.set_Item
	|
	|-RVA: 0x2E1C500 Offset: 0x2E1C601 VA: 0x2E1C500
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.set_Item
	|
	|-RVA: 0x2E1FC10 Offset: 0x2E1FD11 VA: 0x2E1FC10
	|-Dictionary<Int32Enum, bool>.set_Item
	|
	|-RVA: 0x2E23200 Offset: 0x2E23301 VA: 0x2E23200
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.set_Item
	|
	|-RVA: 0x2E33FE0 Offset: 0x2E340E1 VA: 0x2E33FE0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.set_Item
	|
	|-RVA: 0x2E376B0 Offset: 0x2E377B1 VA: 0x2E376B0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.set_Item
	|
	|-RVA: 0x2F961D0 Offset: 0x2F962D1 VA: 0x2F961D0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.set_Item
	|
	|-RVA: 0x2F99920 Offset: 0x2F99A21 VA: 0x2F99920
	|-Dictionary<long, object>.set_Item
	|
	|-RVA: 0x2DF98C0 Offset: 0x2DF99C1 VA: 0x2DF98C0
	|-Dictionary<ParameterExpression, int>.set_Item
	|-Dictionary<object, int>.set_Item
	|-Dictionary<string, int>.set_Item
	|
	|-RVA: 0x2F9CF50 Offset: 0x2F9D051 VA: 0x2F9CF50
	|-Dictionary<Memory<object>, object>.set_Item
	|
	|-RVA: 0x2FA05D0 Offset: 0x2FA06D1 VA: 0x2FA05D0
	|-Dictionary<Nullable<Int32Enum>, object>.set_Item
	|
	|-RVA: 0x2FA3DE0 Offset: 0x2FA3EE1 VA: 0x2FA3DE0
	|-Dictionary<Nullable<Bounds>, object>.set_Item
	|
	|-RVA: 0x2FA7D40 Offset: 0x2FA7E41 VA: 0x2FA7D40
	|-Dictionary<Nullable<BoundsInt>, object>.set_Item
	|
	|-RVA: 0x2FABC70 Offset: 0x2FABD71 VA: 0x2FABC70
	|-Dictionary<Nullable<Color32>, object>.set_Item
	|
	|-RVA: 0x2FAF470 Offset: 0x2FAF571 VA: 0x2FAF470
	|-Dictionary<Nullable<Color>, object>.set_Item
	|
	|-RVA: 0x2F1A550 Offset: 0x2F1A651 VA: 0x2F1A550
	|-Dictionary<Nullable<GradientAlphaKey>, object>.set_Item
	|
	|-RVA: 0x2F1DE30 Offset: 0x2F1DF31 VA: 0x2F1DE30
	|-Dictionary<Nullable<GradientColorKey>, object>.set_Item
	|
	|-RVA: 0x2F21B30 Offset: 0x2F21C31 VA: 0x2F21B30
	|-Dictionary<Nullable<Keyframe>, object>.set_Item
	|
	|-RVA: 0x2F25840 Offset: 0x2F25941 VA: 0x2F25840
	|-Dictionary<Nullable<LayerMask>, object>.set_Item
	|
	|-RVA: 0x2F29080 Offset: 0x2F29181 VA: 0x2F29080
	|-Dictionary<Nullable<Matrix4x4>, object>.set_Item
	|
	|-RVA: 0x2F2D5B0 Offset: 0x2F2D6B1 VA: 0x2F2D5B0
	|-Dictionary<Nullable<Quaternion>, object>.set_Item
	|
	|-RVA: 0x2F312A0 Offset: 0x2F313A1 VA: 0x2F312A0
	|-Dictionary<Nullable<RangeInt>, object>.set_Item
	|
	|-RVA: 0x2F34B80 Offset: 0x2F34C81 VA: 0x2F34B80
	|-Dictionary<Nullable<Rect>, object>.set_Item
	|
	|-RVA: 0x2EFD890 Offset: 0x2EFD991 VA: 0x2EFD890
	|-Dictionary<Nullable<RectInt>, object>.set_Item
	|
	|-RVA: 0x2F01580 Offset: 0x2F01681 VA: 0x2F01580
	|-Dictionary<Nullable<Vector2>, object>.set_Item
	|
	|-RVA: 0x2F04E50 Offset: 0x2F04F51 VA: 0x2F04E50
	|-Dictionary<Nullable<Vector2Int>, object>.set_Item
	|
	|-RVA: 0x2F08720 Offset: 0x2F08821 VA: 0x2F08720
	|-Dictionary<Nullable<Vector3>, object>.set_Item
	|
	|-RVA: 0x2F0BF60 Offset: 0x2F0C061 VA: 0x2F0BF60
	|-Dictionary<Nullable<Vector3Int>, object>.set_Item
	|
	|-RVA: 0x2F0F7B0 Offset: 0x2F0F8B1 VA: 0x2F0F7B0
	|-Dictionary<Nullable<Vector4>, object>.set_Item
	|
	|-RVA: 0x2F13490 Offset: 0x2F13591 VA: 0x2F13490
	|-Dictionary<object, BitVector32Int>.set_Item
	|
	|-RVA: 0x2F16B60 Offset: 0x2F16C61 VA: 0x2F16B60
	|-Dictionary<object, EventCheckId>.set_Item
	|
	|-RVA: 0x2FF3360 Offset: 0x2FF3461 VA: 0x2FF3360
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.set_Item
	|
	|-RVA: 0x2FF7080 Offset: 0x2FF7181 VA: 0x2FF7080
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.set_Item
	|
	|-RVA: 0x2FFAA40 Offset: 0x2FFAB41 VA: 0x2FFAA40
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.set_Item
	|
	|-RVA: 0x2FFE170 Offset: 0x2FFE271 VA: 0x2FFE170
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.set_Item
	|
	|-RVA: 0x3001880 Offset: 0x3001981 VA: 0x3001880
	|-Dictionary<object, MonsterHutSaveData>.set_Item
	|
	|-RVA: 0x30053A0 Offset: 0x30054A1 VA: 0x30053A0
	|-Dictionary<object, OrderLotterySaveParameter>.set_Item
	|
	|-RVA: 0x3008AF0 Offset: 0x3008BF1 VA: 0x3008AF0
	|-Dictionary<object, OrderSaveData>.set_Item
	|
	|-RVA: 0x300C630 Offset: 0x300C731 VA: 0x300C630
	|-Dictionary<object, OrderSaveParameter>.set_Item
	|
	|-RVA: 0x2DDDD40 Offset: 0x2DDDE41 VA: 0x2DDDD40
	|-Dictionary<object, Parameter>.set_Item
	|
	|-RVA: 0x2DE1960 Offset: 0x2DE1A61 VA: 0x2DE1960
	|-Dictionary<object, NumberControl.ValueRange>.set_Item
	|
	|-RVA: 0x2DE5030 Offset: 0x2DE5131 VA: 0x2DE5030
	|-Dictionary<object, bool>.set_Item
	|-Dictionary<Camera, bool>.set_Item
	|
	|-RVA: 0x2DE8710 Offset: 0x2DE8811 VA: 0x2DE8710
	|-Dictionary<object, byte>.set_Item
	|
	|-RVA: 0x2DEBDD0 Offset: 0x2DEBED1 VA: 0x2DEBDD0
	|-Dictionary<object, char>.set_Item
	|
	|-RVA: 0x2DEF490 Offset: 0x2DEF591 VA: 0x2DEF490
	|-Dictionary<object, DateTime>.set_Item
	|
	|-RVA: 0x2DF2B40 Offset: 0x2DF2C41 VA: 0x2DF2B40
	|-Dictionary<object, double>.set_Item
	|
	|-RVA: 0x2DF6200 Offset: 0x2DF6301 VA: 0x2DF6200
	|-Dictionary<object, short>.set_Item
	|
	|-RVA: 0x30B8E80 Offset: 0x30B8F81 VA: 0x30B8E80
	|-Dictionary<object, Int32Enum>.set_Item
	|-Dictionary<Event, TextEditor.TextEditOp>.set_Item
	|
	|-RVA: 0x30BC540 Offset: 0x30BC641 VA: 0x30BC540
	|-Dictionary<object, long>.set_Item
	|
	|-RVA: 0x30BFBF0 Offset: 0x30BFCF1 VA: 0x30BFBF0
	|-Dictionary<object, Memory<object>>.set_Item
	|
	|-RVA: 0x30C3310 Offset: 0x30C3411 VA: 0x30C3310
	|-Dictionary<object, Nullable<Int32Enum>>.set_Item
	|
	|-RVA: 0x30C6AD0 Offset: 0x30C6BD1 VA: 0x30C6AD0
	|-Dictionary<object, Nullable<Bounds>>.set_Item
	|
	|-RVA: 0x30CA730 Offset: 0x30CA831 VA: 0x30CA730
	|-Dictionary<object, Nullable<BoundsInt>>.set_Item
	|
	|-RVA: 0x30CE370 Offset: 0x30CE471 VA: 0x30CE370
	|-Dictionary<object, Nullable<Color32>>.set_Item
	|
	|-RVA: 0x30D1B20 Offset: 0x30D1C21 VA: 0x30D1B20
	|-Dictionary<object, Nullable<Color>>.set_Item
	|
	|-RVA: 0x3010050 Offset: 0x3010151 VA: 0x3010050
	|-Dictionary<object, Nullable<GradientAlphaKey>>.set_Item
	|
	|-RVA: 0x30138B0 Offset: 0x30139B1 VA: 0x30138B0
	|-Dictionary<object, Nullable<GradientColorKey>>.set_Item
	|
	|-RVA: 0x30173A0 Offset: 0x30174A1 VA: 0x30173A0
	|-Dictionary<object, Nullable<Keyframe>>.set_Item
	|
	|-RVA: 0x301AEC0 Offset: 0x301AFC1 VA: 0x301AEC0
	|-Dictionary<object, Nullable<LayerMask>>.set_Item
	|
	|-RVA: 0x301E690 Offset: 0x301E791 VA: 0x301E690
	|-Dictionary<object, Nullable<Matrix4x4>>.set_Item
	|
	|-RVA: 0x3022670 Offset: 0x3022771 VA: 0x3022670
	|-Dictionary<object, Nullable<Quaternion>>.set_Item
	|
	|-RVA: 0x3026160 Offset: 0x3026261 VA: 0x3026160
	|-Dictionary<object, Nullable<RangeInt>>.set_Item
	|
	|-RVA: 0x30299C0 Offset: 0x3029AC1 VA: 0x30299C0
	|-Dictionary<object, Nullable<Rect>>.set_Item
	|
	|-RVA: 0x2FD6FA0 Offset: 0x2FD70A1 VA: 0x2FD6FA0
	|-Dictionary<object, Nullable<RectInt>>.set_Item
	|
	|-RVA: 0x2FDAA90 Offset: 0x2FDAB91 VA: 0x2FDAA90
	|-Dictionary<object, Nullable<Vector2>>.set_Item
	|
	|-RVA: 0x2FDE2E0 Offset: 0x2FDE3E1 VA: 0x2FDE2E0
	|-Dictionary<object, Nullable<Vector2Int>>.set_Item
	|
	|-RVA: 0x2FE1B30 Offset: 0x2FE1C31 VA: 0x2FE1B30
	|-Dictionary<object, Nullable<Vector3>>.set_Item
	|
	|-RVA: 0x2FE5320 Offset: 0x2FE5421 VA: 0x2FE5320
	|-Dictionary<object, Nullable<Vector3Int>>.set_Item
	|
	|-RVA: 0x2FE8B20 Offset: 0x2FE8C21 VA: 0x2FE8B20
	|-Dictionary<object, Nullable<Vector4>>.set_Item
	|
	|-RVA: 0x2FEFC10 Offset: 0x2FEFD11 VA: 0x2FEFC10
	|-Dictionary<object, ReadOnlyMemory<object>>.set_Item
	|
	|-RVA: 0x2DBE6C0 Offset: 0x2DBE7C1 VA: 0x2DBE6C0
	|-Dictionary<object, ResourceLocator>.set_Item
	|-Dictionary<string, ResourceLocator>.set_Item
	|
	|-RVA: 0x2DC1DE0 Offset: 0x2DC1EE1 VA: 0x2DC1DE0
	|-Dictionary<object, sbyte>.set_Item
	|
	|-RVA: 0x2DC54A0 Offset: 0x2DC55A1 VA: 0x2DC54A0
	|-Dictionary<object, float>.set_Item
	|
	|-RVA: 0x2DC8B60 Offset: 0x2DC8C61 VA: 0x2DC8B60
	|-Dictionary<object, ushort>.set_Item
	|
	|-RVA: 0x2DCC220 Offset: 0x2DCC321 VA: 0x2DCC220
	|-Dictionary<object, uint>.set_Item
	|
	|-RVA: 0x2DCF8E0 Offset: 0x2DCF9E1 VA: 0x2DCF8E0
	|-Dictionary<object, ulong>.set_Item
	|
	|-RVA: 0x2DD2FA0 Offset: 0x2DD30A1 VA: 0x2DD2FA0
	|-Dictionary<object, TransitionTables>.set_Item
	|
	|-RVA: 0x2DD69C0 Offset: 0x2DD6AC1 VA: 0x2DD69C0
	|-Dictionary<object, Bounds>.set_Item
	|
	|-RVA: 0x2DDA380 Offset: 0x2DDA481 VA: 0x2DDA380
	|-Dictionary<object, BoundsInt>.set_Item
	|
	|-RVA: 0x30D5610 Offset: 0x30D5711 VA: 0x30D5610
	|-Dictionary<object, Color32>.set_Item
	|
	|-RVA: 0x30D8CD0 Offset: 0x30D8DD1 VA: 0x30D8CD0
	|-Dictionary<object, Color>.set_Item
	|
	|-RVA: 0x30DC3F0 Offset: 0x30DC4F1 VA: 0x30DC3F0
	|-Dictionary<object, GradientAlphaKey>.set_Item
	|
	|-RVA: 0x30DFAF0 Offset: 0x30DFBF1 VA: 0x30DFAF0
	|-Dictionary<object, GradientColorKey>.set_Item
	|
	|-RVA: 0x30E34D0 Offset: 0x30E35D1 VA: 0x30E34D0
	|-Dictionary<object, Keyframe>.set_Item
	|
	|-RVA: 0x30E6FF0 Offset: 0x30E70F1 VA: 0x30E6FF0
	|-Dictionary<object, LayerMask>.set_Item
	|
	|-RVA: 0x30EA6D0 Offset: 0x30EA7D1 VA: 0x30EA6D0
	|-Dictionary<object, Matrix4x4>.set_Item
	|
	|-RVA: 0x30EE360 Offset: 0x30EE461 VA: 0x30EE360
	|-Dictionary<object, Playable>.set_Item
	|-Dictionary<TrackAsset, Playable>.set_Item
	|
	|-RVA: 0x309D160 Offset: 0x309D261 VA: 0x309D160
	|-Dictionary<object, Quaternion>.set_Item
	|
	|-RVA: 0x30A0880 Offset: 0x30A0981 VA: 0x30A0880
	|-Dictionary<object, RangeInt>.set_Item
	|
	|-RVA: 0x30A3F30 Offset: 0x30A4031 VA: 0x30A3F30
	|-Dictionary<object, Rect>.set_Item
	|
	|-RVA: 0x30A7650 Offset: 0x30A7751 VA: 0x30A7650
	|-Dictionary<object, RectInt>.set_Item
	|
	|-RVA: 0x30AAD50 Offset: 0x30AAE51 VA: 0x30AAD50
	|-Dictionary<object, AsyncOperationHandle>.set_Item
	|
	|-RVA: 0x30AE720 Offset: 0x30AE821 VA: 0x30AE720
	|-Dictionary<object, AsyncOperationHandle<object>>.set_Item
	|
	|-RVA: 0x30B20E0 Offset: 0x30B21E1 VA: 0x30B20E0
	|-Dictionary<object, Vector2>.set_Item
	|
	|-RVA: 0x30B57D0 Offset: 0x30B58D1 VA: 0x30B57D0
	|-Dictionary<object, Vector2Int>.set_Item
	|
	|-RVA: 0x3081460 Offset: 0x3081561 VA: 0x3081460
	|-Dictionary<object, Vector3>.set_Item
	|
	|-RVA: 0x3084B70 Offset: 0x3084C71 VA: 0x3084B70
	|-Dictionary<object, Vector3Int>.set_Item
	|
	|-RVA: 0x30882A0 Offset: 0x30883A1 VA: 0x30882A0
	|-Dictionary<object, Vector4>.set_Item
	|
	|-RVA: 0x308B9D0 Offset: 0x308BAD1 VA: 0x308B9D0
	|-Dictionary<ReadOnlyMemory<object>, object>.set_Item
	|
	|-RVA: 0x308F050 Offset: 0x308F151 VA: 0x308F050
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.set_Item
	|
	|-RVA: 0x30926E0 Offset: 0x30927E1 VA: 0x30926E0
	|-Dictionary<sbyte, object>.set_Item
	|
	|-RVA: 0x3095D40 Offset: 0x3095E41 VA: 0x3095D40
	|-Dictionary<float, CurveSample>.set_Item
	|
	|-RVA: 0x3099B50 Offset: 0x3099C51 VA: 0x3099B50
	|-Dictionary<float, object>.set_Item
	|
	|-RVA: 0x319D0B0 Offset: 0x319D1B1 VA: 0x319D0B0
	|-Dictionary<ushort, object>.set_Item
	|
	|-RVA: 0x31A06C0 Offset: 0x31A07C1 VA: 0x31A06C0
	|-Dictionary<uint, int>.set_Item
	|
	|-RVA: 0x31A3C80 Offset: 0x31A3D81 VA: 0x31A3C80
	|-Dictionary<uint, Int32Enum>.set_Item
	|
	|-RVA: 0x31A7250 Offset: 0x31A7351 VA: 0x31A7250
	|-Dictionary<uint, object>.set_Item
	|
	|-RVA: 0x31AA870 Offset: 0x31AA971 VA: 0x31AA870
	|-Dictionary<ulong, object>.set_Item
	|
	|-RVA: 0x31ADE90 Offset: 0x31ADF91 VA: 0x31ADE90
	|-Dictionary<EdgeKeyByHash, int>.set_Item
	|
	|-RVA: 0x31B1520 Offset: 0x31B1621 VA: 0x31B1520
	|-Dictionary<EdgeKeyByHash, CapEdge>.set_Item
	|
	|-RVA: 0x31B50D0 Offset: 0x31B51D1 VA: 0x31B50D0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.set_Item
	|
	|-RVA: 0x302D4C0 Offset: 0x302D5C1 VA: 0x302D4C0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.set_Item
	|
	|-RVA: 0x3030E60 Offset: 0x3030F61 VA: 0x3030E60
	|-Dictionary<MeshDataConnectivity.Face, bool>.set_Item
	|
	|-RVA: 0x30344F0 Offset: 0x30345F1 VA: 0x30344F0
	|-Dictionary<MeshDataConnectivity.Face, object>.set_Item
	|
	|-RVA: 0x3037B30 Offset: 0x3037C31 VA: 0x3037B30
	|-Dictionary<Bounds, object>.set_Item
	|
	|-RVA: 0x303B660 Offset: 0x303B761 VA: 0x303B660
	|-Dictionary<BoundsInt, object>.set_Item
	|
	|-RVA: 0x303F190 Offset: 0x303F291 VA: 0x303F190
	|-Dictionary<Color, object>.set_Item
	|
	|-RVA: 0x30428D0 Offset: 0x30429D1 VA: 0x30428D0
	|-Dictionary<Color32, object>.set_Item
	|
	|-RVA: 0x3045F30 Offset: 0x3046031 VA: 0x3045F30
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.set_Item
	|
	|-RVA: 0x3064A70 Offset: 0x3064B71 VA: 0x3064A70
	|-Dictionary<GradientAlphaKey, object>.set_Item
	|
	|-RVA: 0x3068100 Offset: 0x3068201 VA: 0x3068100
	|-Dictionary<GradientColorKey, object>.set_Item
	|
	|-RVA: 0x306BC40 Offset: 0x306BD41 VA: 0x306BC40
	|-Dictionary<Keyframe, object>.set_Item
	|
	|-RVA: 0x306F990 Offset: 0x306FA91 VA: 0x306F990
	|-Dictionary<LayerMask, object>.set_Item
	|
	|-RVA: 0x3073030 Offset: 0x3073131 VA: 0x3073030
	|-Dictionary<Matrix4x4, object>.set_Item
	|
	|-RVA: 0x3077010 Offset: 0x3077111 VA: 0x3077010
	|-Dictionary<IntVec3, object>.set_Item
	|
	|-RVA: 0x307A700 Offset: 0x307A801 VA: 0x307A700
	|-Dictionary<Quaternion, object>.set_Item
	|
	|-RVA: 0x307DE40 Offset: 0x307DF41 VA: 0x307DE40
	|-Dictionary<RangeInt, object>.set_Item
	|
	|-RVA: 0x3049570 Offset: 0x3049671 VA: 0x3049570
	|-Dictionary<Rect, object>.set_Item
	|
	|-RVA: 0x304CCC0 Offset: 0x304CDC1 VA: 0x304CCC0
	|-Dictionary<RectInt, object>.set_Item
	|
	|-RVA: 0x3050330 Offset: 0x3050431 VA: 0x3050330
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.set_Item
	|
	|-RVA: 0x30539A0 Offset: 0x3053AA1 VA: 0x30539A0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.set_Item
	|
	|-RVA: 0x3056FD0 Offset: 0x30570D1 VA: 0x3056FD0
	|-Dictionary<Vector2, object>.set_Item
	|
	|-RVA: 0x305A640 Offset: 0x305A741 VA: 0x305A640
	|-Dictionary<Vector2Int, object>.set_Item
	|
	|-RVA: 0x305DC80 Offset: 0x305DD81 VA: 0x305DC80
	|-Dictionary<Vector3, object>.set_Item
	|
	|-RVA: 0x3061360 Offset: 0x3061461 VA: 0x3061360
	|-Dictionary<Vector3Int, object>.set_Item
	|
	|-RVA: 0x2E3AD60 Offset: 0x2E3AE61 VA: 0x2E3AD60
	|-Dictionary<Vector4, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E2D430 Offset: 0x2E2D531 VA: 0x2E2D430
	|-Dictionary<BaffamoID, BaffamoFestivalData>.Add
	|-Dictionary<BeanID, BeanData>.Add
	|-Dictionary<ActorID, ActorData>.Add
	|-Dictionary<ActorID, LifeCycleScriptPlayer>.Add
	|-Dictionary<ActorID, HumanStatusData>.Add
	|-Dictionary<ActorID, ItemStorageData>.Add
	|-Dictionary<ActorID, MobTravelerName>.Add
	|-Dictionary<ActorID, NpcStatusData>.Add
	|-Dictionary<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.Add
	|-Dictionary<ActorID, List<MonsterDataID>>.Add
	|-Dictionary<ActorID, SphereCollider>.Add
	|-Dictionary<AttackAttribute, ParticleSystem>.Add
	|-Dictionary<BadStatus, BadStatusEffectController.ObjInfo>.Add
	|-Dictionary<CharID, HumanDataArray>.Add
	|-Dictionary<FocusObjectType, FocusObjectName.BorderElement>.Add
	|-Dictionary<FocusObjectType, Func<FocusInterface, Color>>.Add
	|-Dictionary<Gender, List<SoundID>>.Add
	|-Dictionary<HairType, Dictionary<VariationNo, HumanData>>.Add
	|-Dictionary<ToolChargeLevel, ParticleSystem>.Add
	|-Dictionary<VariationNo, HumanData>.Add
	|-Dictionary<WantedFieldType, WantedField>.Add
	|-Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.Add
	|-Dictionary<EquipSlotType, AS_ToolController.ToolActionData>.Add
	|-Dictionary<EquipSlotType, HumanEquipItem>.Add
	|-Dictionary<FaceType, string>.Add
	|-Dictionary<FarmAction, SkillActionID[]>.Add
	|-Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox>.Add
	|-Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>>.Add
	|-Dictionary<FoodID, GluttonFood>.Add
	|-Dictionary<GateDataID, GateController>.Add
	|-Dictionary<GimmickLayoutID, HashSet<GimmickBase>>.Add
	|-Dictionary<HumanMagicMotionType, HumanMagicMotionController.HumanMagicMotion>.Add
	|-Dictionary<ItemID, ItemPoolData>.Add
	|-Dictionary<Master, BossDataAssetBase>.Add
	|-Dictionary<Master, MonsterActionCodeDataTableArray>.Add
	|-Dictionary<MonsterActionBehaviorDataID, List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>>.Add
	|-Dictionary<MonsterDoctor.EvaluationType, string>.Add
	|-Dictionary<MonsterModelDataID, MonsterModelData>.Add
	|-Dictionary<MoveParamID, CharacterMoveParam>.Add
	|-Dictionary<NPCActionBehaviorDataID, List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>>.Add
	|-Dictionary<SnowmanObjectID, MocomocoData>.Add
	|-Dictionary<SnowmanObjectID, SnowballData>.Add
	|-Dictionary<SoundID, EnvironmentSoundDataTable>.Add
	|-Dictionary<SoundID, EnvironmentSoundController>.Add
	|-Dictionary<SoundID, AudioClip>.Add
	|-Dictionary<Int32Enum, object>.Add
	|-Dictionary<SystemLanguage, string>.Add
	|
	|-RVA: 0x2FEC640 Offset: 0x2FEC741 VA: 0x2FEC640
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>.Add
	|-Dictionary<BehaviorManager.ThirdPartyTask, object>.Add
	|-Dictionary<SharedVariable, object>.Add
	|-Dictionary<Task, Dictionary<string, object>>.Add
	|-Dictionary<BinaryDeserialization.ObjectFieldMap, List<int>>.Add
	|-Dictionary<CharacterBase, DamageTextController>.Add
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.Add
	|-Dictionary<Tween, TweenLink>.Add
	|-Dictionary<ObjectSerializationInfo.EmittableMember, FieldInfo>.Add
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.Add
	|-Dictionary<OptionDefinition, OptionsControlBase>.Add
	|-Dictionary<int[], SceneSplit>.Add
	|-Dictionary<int[], Terrain>.Add
	|-Dictionary<ParameterExpression, LocalVariable>.Add
	|-Dictionary<object, BehaviorManager.ThirdPartyTask>.Add
	|-Dictionary<object, ICollection<OptionDefinition>>.Add
	|-Dictionary<object, IList<IResourceLocation>>.Add
	|-Dictionary<object, object>.Add
	|-Dictionary<FieldInfo, Dictionary<Type, bool>>.Add
	|-Dictionary<FieldInfo, Instruction>.Add
	|-Dictionary<string, ActionCode>.Add
	|-Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>.Add
	|-Dictionary<string, ProfileGroupDefinition>.Add
	|-Dictionary<string, ObjectSerializationInfo.EmittableMember>.Add
	|-Dictionary<string, PadBindData>.Add
	|-Dictionary<string, InfoBlock>.Add
	|-Dictionary<string, Dictionary<string, object>>.Add
	|-Dictionary<string, IList<InfoEntry>>.Add
	|-Dictionary<string, List<TaskCoroutine>>.Add
	|-Dictionary<string, List<OptionDefinition>>.Add
	|-Dictionary<string, List<GameObject>>.Add
	|-Dictionary<string, Delegate>.Add
	|-Dictionary<string, Func<bool>>.Add
	|-Dictionary<string, LocalDataStoreSlot>.Add
	|-Dictionary<string, WebConnectionGroup>.Add
	|-Dictionary<string, object>.Add
	|-Dictionary<string, ResourceSet>.Add
	|-Dictionary<string, string>.Add
	|-Dictionary<string, Tuple<Guid, string>>.Add
	|-Dictionary<string, Type>.Add
	|-Dictionary<string, ResourceLocationData>.Add
	|-Dictionary<string, GameObject>.Add
	|-Dictionary<string, ResourceLocationBase>.Add
	|-Dictionary<string, Sprite>.Add
	|-Dictionary<string, Transform>.Add
	|-Dictionary<Thread, StackTrace>.Add
	|-Dictionary<Type, ITweenPlugin>.Add
	|-Dictionary<Type, Dictionary<string, Delegate>>.Add
	|-Dictionary<Type, IList<SRMonoBehaviourEx.FieldInfo>>.Add
	|-Dictionary<Type, MonoCustomAttrs.AttributeInfo>.Add
	|-Dictionary<Type, object>.Add
	|-Dictionary<Type, FieldInfo[]>.Add
	|-Dictionary<Type, TypeInformation>.Add
	|-Dictionary<Type, Type>.Add
	|-Dictionary<Type, TrackBindingTypeAttribute>.Add
	|-Dictionary<TimeParamTable, HashSet<MaterialChangeTime>>.Add
	|-Dictionary<TimeParamTable, HashSet<ObjectChangeTime>>.Add
	|-Dictionary<TimeParamTable, HashSet<RendererChangeTime>>.Add
	|-Dictionary<TimeParamTable, HashSet<Material>>.Add
	|-Dictionary<MeshUniqueVertices.UniqueVertex, MeshUniqueVertices.RepeatedVertexList>.Add
	|-Dictionary<Canvas, IndexedSet<Graphic>>.Add
	|-Dictionary<Collider, CharacterBase>.Add
	|-Dictionary<Collider, CharacterNearCullingController>.Add
	|-Dictionary<Collider, FocusInterface>.Add
	|-Dictionary<Font, HashSet<Text>>.Add
	|-Dictionary<GameObject, Material[]>.Add
	|-Dictionary<GameObject, Renderer[]>.Add
	|-Dictionary<GameObject, Transform>.Add
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.Add
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.Add
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>.Add
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.Add
	|
	|-RVA: 0x2A16730 Offset: 0x2A16831 VA: 0x2A16730
	|-Dictionary<JSONDeserialization.TaskField, List<int>>.Add
	|-Dictionary<JSONDeserialization.TaskField, object>.Add
	|
	|-RVA: 0x2A19DB0 Offset: 0x2A19EB1 VA: 0x2A19DB0
	|-Dictionary<BitVector32Int, object>.Add
	|
	|-RVA: 0x2DC54D0 Offset: 0x2DC55D1 VA: 0x2DC54D0
	|-Dictionary<Character, float>.Add
	|-Dictionary<object, float>.Add
	|
	|-RVA: 0x2DF98F0 Offset: 0x2DF99F1 VA: 0x2DF98F0
	|-Dictionary<CinemachineVirtualCameraBase, int>.Add
	|-Dictionary<MonsterControllerBase, int>.Add
	|-Dictionary<OnGroundItem, int>.Add
	|-Dictionary<object, int>.Add
	|-Dictionary<string, int>.Add
	|-Dictionary<Type, int>.Add
	|-Dictionary<Simplifier.VertexDataHash, int>.Add
	|-Dictionary<Camera, int>.Add
	|-Dictionary<GameObject, int>.Add
	|
	|-RVA: 0x2E29E60 Offset: 0x2E29F61 VA: 0x2E29E60
	|-Dictionary<ActorID, CharID>.Add
	|-Dictionary<ActorID, Master>.Add
	|-Dictionary<ActorID, RF5SystemData.FLAG>.Add
	|-Dictionary<AttackAttribute, EffectID>.Add
	|-Dictionary<BadStatus, Prefab>.Add
	|-Dictionary<EmotionType, Prefab>.Add
	|-Dictionary<FieldPlaceId, Place>.Add
	|-Dictionary<GameFlagData, NPCID>.Add
	|-Dictionary<MakingID, CalendarDataTable.FestivalId>.Add
	|-Dictionary<Place, FieldPlaceId>.Add
	|-Dictionary<Season, Texture>.Add
	|-Dictionary<DualWorkType, Prefab>.Add
	|-Dictionary<FestivalType, Event>.Add
	|-Dictionary<GateEnemyModelContainer.GateType, EffectID>.Add
	|-Dictionary<ItemID, SkillID>.Add
	|-Dictionary<ItemID, ItemID>.Add
	|-Dictionary<ItemType, EquipPointType>.Add
	|-Dictionary<AKey, Key>.Add
	|-Dictionary<Int32Enum, Int32Enum>.Add
	|-Dictionary<TitleCanvasControl.TitleCallID, RF5SystemData.FLAG>.Add
	|-Dictionary<RuntimePlatform, AddressablesPlatform>.Add
	|
	|-RVA: 0x2E268A0 Offset: 0x2E269A1 VA: 0x2E268A0
	|-Dictionary<ActorID, int>.Add
	|-Dictionary<ButtonGuideId, int>.Add
	|-Dictionary<UseCameraType, int>.Add
	|-Dictionary<Weather, int>.Add
	|-Dictionary<RF5SystemData.FLAG, int>.Add
	|-Dictionary<Int32Enum, int>.Add
	|-Dictionary<UIMainManager.AttachId, int>.Add
	|
	|-RVA: 0x2E30A40 Offset: 0x2E30B41 VA: 0x2E30A40
	|-Dictionary<ActorID, float>.Add
	|-Dictionary<AttackAttribute, float>.Add
	|-Dictionary<CharID, float>.Add
	|-Dictionary<EmotionType, float>.Add
	|-Dictionary<PartnerMovementOrderType, float>.Add
	|-Dictionary<Int32Enum, float>.Add
	|
	|-RVA: 0x2F75050 Offset: 0x2F75151 VA: 0x2F75050
	|-Dictionary<MonsterFootStepEventDataID, MonsterFootStepEventDataTable>.Add
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.Add
	|
	|-RVA: 0x2F96200 Offset: 0x2F96301 VA: 0x2F96200
	|-Dictionary<TutorialScriptType, TutorialUnlockFlagData>.Add
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.Add
	|
	|-RVA: 0x2F78B60 Offset: 0x2F78C61 VA: 0x2F78B60
	|-Dictionary<EventCheckId, object>.Add
	|
	|-RVA: 0x2F7C6F0 Offset: 0x2F7C7F1 VA: 0x2F7C6F0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.Add
	|
	|-RVA: 0x2F80760 Offset: 0x2F80861 VA: 0x2F80760
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.Add
	|
	|-RVA: 0x2F84250 Offset: 0x2F84351 VA: 0x2F84250
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.Add
	|
	|-RVA: 0x2F87960 Offset: 0x2F87A61 VA: 0x2F87960
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.Add
	|
	|-RVA: 0x2E23230 Offset: 0x2E23331 VA: 0x2E23230
	|-Dictionary<FieldSceneId, KeyValuePair<FarmManager.FARM_ID, int>>.Add
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.Add
	|
	|-RVA: 0x2E1C530 Offset: 0x2E1C631 VA: 0x2E1C530
	|-Dictionary<ItemCategory, PartnerNPCWeaponBehaviorDataTable>.Add
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Add
	|
	|-RVA: 0x2E1FC40 Offset: 0x2E1FD41 VA: 0x2E1FC40
	|-Dictionary<ItemType, bool>.Add
	|-Dictionary<Int32Enum, bool>.Add
	|
	|-RVA: 0x2E376E0 Offset: 0x2E377E1 VA: 0x2E376E0
	|-Dictionary<MixerVolumeGroup, ValueTuple<float, float>>.Add
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.Add
	|
	|-RVA: 0x2F713C0 Offset: 0x2F714C1 VA: 0x2F713C0
	|-Dictionary<MonsterDataID, MonsterDataTable>.Add
	|-Dictionary<Int32Enum, MonsterDataTable>.Add
	|
	|-RVA: 0x2F8B040 Offset: 0x2F8B141 VA: 0x2F8B040
	|-Dictionary<MonsterHutSaveData, object>.Add
	|
	|-RVA: 0x2F8ED70 Offset: 0x2F8EE71 VA: 0x2F8ED70
	|-Dictionary<OrderLotterySaveParameter, object>.Add
	|
	|-RVA: 0x2F924E0 Offset: 0x2F925E1 VA: 0x2F924E0
	|-Dictionary<OrderSaveData, object>.Add
	|
	|-RVA: 0x2D805D0 Offset: 0x2D806D1 VA: 0x2D805D0
	|-Dictionary<OrderSaveParameter, object>.Add
	|
	|-RVA: 0x2D84170 Offset: 0x2D84271 VA: 0x2D84170
	|-Dictionary<Parameter, object>.Add
	|
	|-RVA: 0x2E34010 Offset: 0x2E34111 VA: 0x2E34010
	|-Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.Add
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.Add
	|
	|-RVA: 0x2D87E50 Offset: 0x2D87F51 VA: 0x2D87E50
	|-Dictionary<bool, object>.Add
	|
	|-RVA: 0x2D8B4D0 Offset: 0x2D8B5D1 VA: 0x2D8B4D0
	|-Dictionary<byte, object>.Add
	|
	|-RVA: 0x2D8EAF0 Offset: 0x2D8EBF1 VA: 0x2D8EAF0
	|-Dictionary<char, object>.Add
	|
	|-RVA: 0x2D92110 Offset: 0x2D92211 VA: 0x2D92110
	|-Dictionary<DateTime, object>.Add
	|
	|-RVA: 0x2D95730 Offset: 0x2D95831 VA: 0x2D95730
	|-Dictionary<double, object>.Add
	|
	|-RVA: 0x2DD3000 Offset: 0x2DD3101 VA: 0x2DD3000
	|-Dictionary<Enum, TransitionTables>.Add
	|-Dictionary<object, TransitionTables>.Add
	|
	|-RVA: 0x2D98D50 Offset: 0x2D98E51 VA: 0x2D98D50
	|-Dictionary<Guid, MonoTlsProvider>.Add
	|-Dictionary<Guid, object>.Add
	|
	|-RVA: 0x2D9C3C0 Offset: 0x2D9C4C1 VA: 0x2D9C3C0
	|-Dictionary<short, object>.Add
	|
	|-RVA: 0x2F5FD60 Offset: 0x2F5FE61 VA: 0x2F5FD60
	|-Dictionary<int, ActorUtility.ActorCreateData>.Add
	|-Dictionary<int, BehaviorManager.BehaviorTree.ConditionalReevaluate>.Add
	|-Dictionary<int, Task>.Add
	|-Dictionary<int, BossBehaviorController>.Add
	|-Dictionary<int, BossStageManager>.Add
	|-Dictionary<int, DLCPair>.Add
	|-Dictionary<int, HairType[]>.Add
	|-Dictionary<int, EventControllerBase.FirstMatchInfo>.Add
	|-Dictionary<int, FarmSupportMonsterManager.FarmScene>.Add
	|-Dictionary<int, FishSwim>.Add
	|-Dictionary<int, HarinezumiController.NeedleController>.Add
	|-Dictionary<int, ItemID[]>.Add
	|-Dictionary<int, ASSET_TABLE>.Add
	|-Dictionary<int, AssetHandle>.Add
	|-Dictionary<int, AssetInfo>.Add
	|-Dictionary<int, ObjectSerializationInfo.EmittableMember>.Add
	|-Dictionary<int, MonsterActionInformation>.Add
	|-Dictionary<int, MonsterActionInformationBase>.Add
	|-Dictionary<int, MonsterBehaviorController.BehaviorActionParam>.Add
	|-Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState>.Add
	|-Dictionary<int, MonsterBehaviorController>.Add
	|-Dictionary<int, NPCBehaviorDataTable>.Add
	|-Dictionary<int, NPCFindTargetDataTable>.Add
	|-Dictionary<int, PartnerNPCBehaviorController>.Add
	|-Dictionary<int, Action>.Add
	|-Dictionary<int, Action<int>>.Add
	|-Dictionary<int, Dictionary<int, List<OrderMasterData>>>.Add
	|-Dictionary<int, Dictionary<string, object>>.Add
	|-Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>>.Add
	|-Dictionary<int, List<BossBehaviorParams>>.Add
	|-Dictionary<int, List<Character>>.Add
	|-Dictionary<int, List<MonsterBehaviorController.BehaviorActionParam>>.Add
	|-Dictionary<int, List<OrderMasterData>>.Add
	|-Dictionary<int, List<PartnerManager.DestinationAngle>>.Add
	|-Dictionary<int, List<object>>.Add
	|-Dictionary<int, List<TimeManager.JustTimerData>>.Add
	|-Dictionary<int, List<MeshDataConnectivity.Face>>.Add
	|-Dictionary<int, List<Vector3>>.Add
	|-Dictionary<int, object>.Add
	|-Dictionary<int, string>.Add
	|-Dictionary<int, TimeType>.Add
	|-Dictionary<int, TMP_ColorGradient>.Add
	|-Dictionary<int, TMP_FontAsset>.Add
	|-Dictionary<int, TMP_SpriteAsset>.Add
	|-Dictionary<int, TMP_Style>.Add
	|-Dictionary<int, DiagnosticInfo>.Add
	|-Dictionary<int, PointerEventData>.Add
	|-Dictionary<int, TerrainUtility.TerrainMap>.Add
	|-Dictionary<int, Material>.Add
	|-Dictionary<int, IAsyncOperation>.Add
	|-Dictionary<int, IResourceProvider>.Add
	|
	|-RVA: 0x2D3A600 Offset: 0x2D3A701 VA: 0x2D3A600
	|-Dictionary<int, CropDataTable>.Add
	|
	|-RVA: 0x2D3E1D0 Offset: 0x2D3E2D1 VA: 0x2D3E1D0
	|-Dictionary<int, EffectDataTable>.Add
	|
	|-RVA: 0x2D41AF0 Offset: 0x2D41BF1 VA: 0x2D41AF0
	|-Dictionary<int, GimmickLayoutDataTable>.Add
	|
	|-RVA: 0x2D45140 Offset: 0x2D45241 VA: 0x2D45140
	|-Dictionary<int, MineTypeDataTable>.Add
	|
	|-RVA: 0x2D565C0 Offset: 0x2D566C1 VA: 0x2D565C0
	|-Dictionary<int, MineTypeID>.Add
	|-Dictionary<int, MonsterDataID>.Add
	|-Dictionary<int, SoundID>.Add
	|-Dictionary<int, Int32Enum>.Add
	|
	|-RVA: 0x2D48DA0 Offset: 0x2D48EA1 VA: 0x2D48DA0
	|-Dictionary<int, MiningDataTable>.Add
	|
	|-RVA: 0x2D4C460 Offset: 0x2D4C561 VA: 0x2D4C460
	|-Dictionary<int, bool>.Add
	|
	|-RVA: 0x2D4FA40 Offset: 0x2D4FB41 VA: 0x2D4FA40
	|-Dictionary<int, char>.Add
	|
	|-RVA: 0x2D53000 Offset: 0x2D53101 VA: 0x2D53000
	|-Dictionary<int, int>.Add
	|
	|-RVA: 0x2F5C6D0 Offset: 0x2F5C7D1 VA: 0x2F5C6D0
	|-Dictionary<int, long>.Add
	|
	|-RVA: 0x2F633E0 Offset: 0x2F634E1 VA: 0x2F633E0
	|-Dictionary<int, DiagnosticEvent>.Add
	|
	|-RVA: 0x2F66EA0 Offset: 0x2F66FA1 VA: 0x2F66EA0
	|-Dictionary<int, SceneInstance>.Add
	|
	|-RVA: 0x2F6A570 Offset: 0x2F6A671 VA: 0x2F6A570
	|-Dictionary<int, Vector2Int>.Add
	|
	|-RVA: 0x2F6DBF0 Offset: 0x2F6DCF1 VA: 0x2F6DBF0
	|-Dictionary<int, Vector3>.Add
	|
	|-RVA: 0x2F99950 Offset: 0x2F99A51 VA: 0x2F99950
	|-Dictionary<long, object>.Add
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>.Add
	|
	|-RVA: 0x2F9CF80 Offset: 0x2F9D081 VA: 0x2F9CF80
	|-Dictionary<Memory<object>, object>.Add
	|
	|-RVA: 0x2FA0600 Offset: 0x2FA0701 VA: 0x2FA0600
	|-Dictionary<Nullable<Int32Enum>, object>.Add
	|
	|-RVA: 0x2FA3E50 Offset: 0x2FA3F51 VA: 0x2FA3E50
	|-Dictionary<Nullable<Bounds>, object>.Add
	|
	|-RVA: 0x2FA7DB0 Offset: 0x2FA7EB1 VA: 0x2FA7DB0
	|-Dictionary<Nullable<BoundsInt>, object>.Add
	|
	|-RVA: 0x2FABCA0 Offset: 0x2FABDA1 VA: 0x2FABCA0
	|-Dictionary<Nullable<Color32>, object>.Add
	|
	|-RVA: 0x2FAF4D0 Offset: 0x2FAF5D1 VA: 0x2FAF4D0
	|-Dictionary<Nullable<Color>, object>.Add
	|
	|-RVA: 0x2F1A580 Offset: 0x2F1A681 VA: 0x2F1A580
	|-Dictionary<Nullable<GradientAlphaKey>, object>.Add
	|
	|-RVA: 0x2F1DE90 Offset: 0x2F1DF91 VA: 0x2F1DE90
	|-Dictionary<Nullable<GradientColorKey>, object>.Add
	|
	|-RVA: 0x2F21B90 Offset: 0x2F21C91 VA: 0x2F21B90
	|-Dictionary<Nullable<Keyframe>, object>.Add
	|
	|-RVA: 0x2F25870 Offset: 0x2F25971 VA: 0x2F25870
	|-Dictionary<Nullable<LayerMask>, object>.Add
	|
	|-RVA: 0x2F29120 Offset: 0x2F29221 VA: 0x2F29120
	|-Dictionary<Nullable<Matrix4x4>, object>.Add
	|
	|-RVA: 0x2F2D610 Offset: 0x2F2D711 VA: 0x2F2D610
	|-Dictionary<Nullable<Quaternion>, object>.Add
	|
	|-RVA: 0x2F312D0 Offset: 0x2F313D1 VA: 0x2F312D0
	|-Dictionary<Nullable<RangeInt>, object>.Add
	|
	|-RVA: 0x2F34BE0 Offset: 0x2F34CE1 VA: 0x2F34BE0
	|-Dictionary<Nullable<Rect>, object>.Add
	|
	|-RVA: 0x2EFD8F0 Offset: 0x2EFD9F1 VA: 0x2EFD8F0
	|-Dictionary<Nullable<RectInt>, object>.Add
	|
	|-RVA: 0x2F015B0 Offset: 0x2F016B1 VA: 0x2F015B0
	|-Dictionary<Nullable<Vector2>, object>.Add
	|
	|-RVA: 0x2F04E80 Offset: 0x2F04F81 VA: 0x2F04E80
	|-Dictionary<Nullable<Vector2Int>, object>.Add
	|
	|-RVA: 0x2F08750 Offset: 0x2F08851 VA: 0x2F08750
	|-Dictionary<Nullable<Vector3>, object>.Add
	|
	|-RVA: 0x2F0BF90 Offset: 0x2F0C091 VA: 0x2F0BF90
	|-Dictionary<Nullable<Vector3Int>, object>.Add
	|
	|-RVA: 0x2F0F810 Offset: 0x2F0F911 VA: 0x2F0F810
	|-Dictionary<Nullable<Vector4>, object>.Add
	|
	|-RVA: 0x2F134C0 Offset: 0x2F135C1 VA: 0x2F134C0
	|-Dictionary<object, BitVector32Int>.Add
	|
	|-RVA: 0x2F16BC0 Offset: 0x2F16CC1 VA: 0x2F16BC0
	|-Dictionary<object, EventCheckId>.Add
	|
	|-RVA: 0x2FF33F0 Offset: 0x2FF34F1 VA: 0x2FF33F0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.Add
	|
	|-RVA: 0x2FF70E0 Offset: 0x2FF71E1 VA: 0x2FF70E0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.Add
	|
	|-RVA: 0x2FFAA70 Offset: 0x2FFAB71 VA: 0x2FFAA70
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.Add
	|
	|-RVA: 0x2FFE1A0 Offset: 0x2FFE2A1 VA: 0x2FFE1A0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.Add
	|
	|-RVA: 0x30018F0 Offset: 0x30019F1 VA: 0x30018F0
	|-Dictionary<object, MonsterHutSaveData>.Add
	|
	|-RVA: 0x30053D0 Offset: 0x30054D1 VA: 0x30053D0
	|-Dictionary<object, OrderLotterySaveParameter>.Add
	|
	|-RVA: 0x3008B60 Offset: 0x3008C61 VA: 0x3008B60
	|-Dictionary<object, OrderSaveData>.Add
	|
	|-RVA: 0x300C690 Offset: 0x300C791 VA: 0x300C690
	|-Dictionary<object, OrderSaveParameter>.Add
	|
	|-RVA: 0x2DDDDD0 Offset: 0x2DDDED1 VA: 0x2DDDDD0
	|-Dictionary<object, Parameter>.Add
	|
	|-RVA: 0x2DE1990 Offset: 0x2DE1A91 VA: 0x2DE1990
	|-Dictionary<object, NumberControl.ValueRange>.Add
	|-Dictionary<Type, NumberControl.ValueRange>.Add
	|
	|-RVA: 0x2DE5060 Offset: 0x2DE5161 VA: 0x2DE5060
	|-Dictionary<object, bool>.Add
	|-Dictionary<Type, bool>.Add
	|-Dictionary<Camera, bool>.Add
	|
	|-RVA: 0x2DE8740 Offset: 0x2DE8841 VA: 0x2DE8740
	|-Dictionary<object, byte>.Add
	|
	|-RVA: 0x2DEBE00 Offset: 0x2DEBF01 VA: 0x2DEBE00
	|-Dictionary<object, char>.Add
	|
	|-RVA: 0x2DEF4C0 Offset: 0x2DEF5C1 VA: 0x2DEF4C0
	|-Dictionary<object, DateTime>.Add
	|
	|-RVA: 0x2DF2B70 Offset: 0x2DF2C71 VA: 0x2DF2B70
	|-Dictionary<object, double>.Add
	|
	|-RVA: 0x2DF6230 Offset: 0x2DF6331 VA: 0x2DF6230
	|-Dictionary<object, short>.Add
	|
	|-RVA: 0x30B8EB0 Offset: 0x30B8FB1 VA: 0x30B8EB0
	|-Dictionary<object, Int32Enum>.Add
	|-Dictionary<string, FieldPlaceId>.Add
	|-Dictionary<string, GameFlagData>.Add
	|-Dictionary<string, SoundID>.Add
	|-Dictionary<string, SystemLanguage>.Add
	|-Dictionary<string, StylePropertyID>.Add
	|-Dictionary<GameObject, Prefab>.Add
	|
	|-RVA: 0x30BC570 Offset: 0x30BC671 VA: 0x30BC570
	|-Dictionary<object, long>.Add
	|
	|-RVA: 0x30BFC20 Offset: 0x30BFD21 VA: 0x30BFC20
	|-Dictionary<object, Memory<object>>.Add
	|
	|-RVA: 0x30C3340 Offset: 0x30C3441 VA: 0x30C3340
	|-Dictionary<object, Nullable<Int32Enum>>.Add
	|
	|-RVA: 0x30C6B40 Offset: 0x30C6C41 VA: 0x30C6B40
	|-Dictionary<object, Nullable<Bounds>>.Add
	|
	|-RVA: 0x30CA7A0 Offset: 0x30CA8A1 VA: 0x30CA7A0
	|-Dictionary<object, Nullable<BoundsInt>>.Add
	|
	|-RVA: 0x30CE3A0 Offset: 0x30CE4A1 VA: 0x30CE3A0
	|-Dictionary<object, Nullable<Color32>>.Add
	|
	|-RVA: 0x30D1B80 Offset: 0x30D1C81 VA: 0x30D1B80
	|-Dictionary<object, Nullable<Color>>.Add
	|
	|-RVA: 0x3010080 Offset: 0x3010181 VA: 0x3010080
	|-Dictionary<object, Nullable<GradientAlphaKey>>.Add
	|
	|-RVA: 0x3013910 Offset: 0x3013A11 VA: 0x3013910
	|-Dictionary<object, Nullable<GradientColorKey>>.Add
	|
	|-RVA: 0x3017400 Offset: 0x3017501 VA: 0x3017400
	|-Dictionary<object, Nullable<Keyframe>>.Add
	|
	|-RVA: 0x301AEF0 Offset: 0x301AFF1 VA: 0x301AEF0
	|-Dictionary<object, Nullable<LayerMask>>.Add
	|
	|-RVA: 0x301E730 Offset: 0x301E831 VA: 0x301E730
	|-Dictionary<object, Nullable<Matrix4x4>>.Add
	|
	|-RVA: 0x30226D0 Offset: 0x30227D1 VA: 0x30226D0
	|-Dictionary<object, Nullable<Quaternion>>.Add
	|
	|-RVA: 0x3026190 Offset: 0x3026291 VA: 0x3026190
	|-Dictionary<object, Nullable<RangeInt>>.Add
	|
	|-RVA: 0x3029A20 Offset: 0x3029B21 VA: 0x3029A20
	|-Dictionary<object, Nullable<Rect>>.Add
	|
	|-RVA: 0x2FD7000 Offset: 0x2FD7101 VA: 0x2FD7000
	|-Dictionary<object, Nullable<RectInt>>.Add
	|
	|-RVA: 0x2FDAAC0 Offset: 0x2FDABC1 VA: 0x2FDAAC0
	|-Dictionary<object, Nullable<Vector2>>.Add
	|
	|-RVA: 0x2FDE310 Offset: 0x2FDE411 VA: 0x2FDE310
	|-Dictionary<object, Nullable<Vector2Int>>.Add
	|
	|-RVA: 0x2FE1B60 Offset: 0x2FE1C61 VA: 0x2FE1B60
	|-Dictionary<object, Nullable<Vector3>>.Add
	|
	|-RVA: 0x2FE5350 Offset: 0x2FE5451 VA: 0x2FE5350
	|-Dictionary<object, Nullable<Vector3Int>>.Add
	|
	|-RVA: 0x2FE8B80 Offset: 0x2FE8C81 VA: 0x2FE8B80
	|-Dictionary<object, Nullable<Vector4>>.Add
	|
	|-RVA: 0x2FEFC40 Offset: 0x2FEFD41 VA: 0x2FEFC40
	|-Dictionary<object, ReadOnlyMemory<object>>.Add
	|
	|-RVA: 0x2DBE6F0 Offset: 0x2DBE7F1 VA: 0x2DBE6F0
	|-Dictionary<object, ResourceLocator>.Add
	|-Dictionary<string, ResourceLocator>.Add
	|
	|-RVA: 0x2DC1E10 Offset: 0x2DC1F11 VA: 0x2DC1E10
	|-Dictionary<object, sbyte>.Add
	|
	|-RVA: 0x2DC8B90 Offset: 0x2DC8C91 VA: 0x2DC8B90
	|-Dictionary<object, ushort>.Add
	|
	|-RVA: 0x2DCC250 Offset: 0x2DCC351 VA: 0x2DCC250
	|-Dictionary<object, uint>.Add
	|
	|-RVA: 0x2DCF910 Offset: 0x2DCFA11 VA: 0x2DCF910
	|-Dictionary<object, ulong>.Add
	|
	|-RVA: 0x2DD6A20 Offset: 0x2DD6B21 VA: 0x2DD6A20
	|-Dictionary<object, Bounds>.Add
	|
	|-RVA: 0x2DDA3E0 Offset: 0x2DDA4E1 VA: 0x2DDA3E0
	|-Dictionary<object, BoundsInt>.Add
	|
	|-RVA: 0x30D5640 Offset: 0x30D5741 VA: 0x30D5640
	|-Dictionary<object, Color32>.Add
	|
	|-RVA: 0x30D8D00 Offset: 0x30D8E01 VA: 0x30D8D00
	|-Dictionary<object, Color>.Add
	|
	|-RVA: 0x30DC420 Offset: 0x30DC521 VA: 0x30DC420
	|-Dictionary<object, GradientAlphaKey>.Add
	|
	|-RVA: 0x30DFB50 Offset: 0x30DFC51 VA: 0x30DFB50
	|-Dictionary<object, GradientColorKey>.Add
	|
	|-RVA: 0x30E3540 Offset: 0x30E3641 VA: 0x30E3540
	|-Dictionary<object, Keyframe>.Add
	|
	|-RVA: 0x30E7020 Offset: 0x30E7121 VA: 0x30E7020
	|-Dictionary<object, LayerMask>.Add
	|
	|-RVA: 0x30EA750 Offset: 0x30EA851 VA: 0x30EA750
	|-Dictionary<object, Matrix4x4>.Add
	|
	|-RVA: 0x30EE390 Offset: 0x30EE491 VA: 0x30EE390
	|-Dictionary<object, Playable>.Add
	|
	|-RVA: 0x309D190 Offset: 0x309D291 VA: 0x309D190
	|-Dictionary<object, Quaternion>.Add
	|
	|-RVA: 0x30A08B0 Offset: 0x30A09B1 VA: 0x30A08B0
	|-Dictionary<object, RangeInt>.Add
	|
	|-RVA: 0x30A3F60 Offset: 0x30A4061 VA: 0x30A3F60
	|-Dictionary<object, Rect>.Add
	|
	|-RVA: 0x30A7680 Offset: 0x30A7781 VA: 0x30A7680
	|-Dictionary<object, RectInt>.Add
	|
	|-RVA: 0x30AADB0 Offset: 0x30AAEB1 VA: 0x30AADB0
	|-Dictionary<object, AsyncOperationHandle>.Add
	|
	|-RVA: 0x30AE780 Offset: 0x30AE881 VA: 0x30AE780
	|-Dictionary<object, AsyncOperationHandle<object>>.Add
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>.Add
	|
	|-RVA: 0x30B2110 Offset: 0x30B2211 VA: 0x30B2110
	|-Dictionary<object, Vector2>.Add
	|
	|-RVA: 0x30B5800 Offset: 0x30B5901 VA: 0x30B5800
	|-Dictionary<object, Vector2Int>.Add
	|
	|-RVA: 0x3081490 Offset: 0x3081591 VA: 0x3081490
	|-Dictionary<object, Vector3>.Add
	|
	|-RVA: 0x3084BA0 Offset: 0x3084CA1 VA: 0x3084BA0
	|-Dictionary<object, Vector3Int>.Add
	|
	|-RVA: 0x30882D0 Offset: 0x30883D1 VA: 0x30882D0
	|-Dictionary<object, Vector4>.Add
	|
	|-RVA: 0x308BA00 Offset: 0x308BB01 VA: 0x308BA00
	|-Dictionary<ReadOnlyMemory<object>, object>.Add
	|
	|-RVA: 0x308F080 Offset: 0x308F181 VA: 0x308F080
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.Add
	|
	|-RVA: 0x3092710 Offset: 0x3092811 VA: 0x3092710
	|-Dictionary<sbyte, object>.Add
	|
	|-RVA: 0x3095DD0 Offset: 0x3095ED1 VA: 0x3095DD0
	|-Dictionary<float, CurveSample>.Add
	|
	|-RVA: 0x3099B80 Offset: 0x3099C81 VA: 0x3099B80
	|-Dictionary<float, object>.Add
	|
	|-RVA: 0x319D0E0 Offset: 0x319D1E1 VA: 0x319D0E0
	|-Dictionary<ushort, object>.Add
	|
	|-RVA: 0x31A3CB0 Offset: 0x31A3DB1 VA: 0x31A3CB0
	|-Dictionary<uint, ActorID>.Add
	|-Dictionary<uint, PartnerMovementOrderType>.Add
	|-Dictionary<uint, Int32Enum>.Add
	|
	|-RVA: 0x31A7280 Offset: 0x31A7381 VA: 0x31A7280
	|-Dictionary<uint, FarmMonsterBehaviorController>.Add
	|-Dictionary<uint, FriendMonsterStatus>.Add
	|-Dictionary<uint, Point2DList>.Add
	|-Dictionary<uint, TriangulationConstraint>.Add
	|-Dictionary<uint, TriangulationPoint>.Add
	|-Dictionary<uint, SaveDataBase.ReaderFunc>.Add
	|-Dictionary<uint, object>.Add
	|-Dictionary<uint, TMP_Character>.Add
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.Add
	|-Dictionary<uint, TMP_SpriteCharacter>.Add
	|-Dictionary<uint, TMP_SpriteGlyph>.Add
	|-Dictionary<uint, Glyph>.Add
	|
	|-RVA: 0x31A06F0 Offset: 0x31A07F1 VA: 0x31A06F0
	|-Dictionary<uint, int>.Add
	|
	|-RVA: 0x31AA8A0 Offset: 0x31AA9A1 VA: 0x31AA8A0
	|-Dictionary<ulong, object>.Add
	|
	|-RVA: 0x31ADEC0 Offset: 0x31ADFC1 VA: 0x31ADEC0
	|-Dictionary<EdgeKeyByHash, int>.Add
	|
	|-RVA: 0x31B15A0 Offset: 0x31B16A1 VA: 0x31B15A0
	|-Dictionary<EdgeKeyByHash, CapEdge>.Add
	|
	|-RVA: 0x31B5140 Offset: 0x31B5241 VA: 0x31B5140
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Add
	|
	|-RVA: 0x302D520 Offset: 0x302D621 VA: 0x302D520
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.Add
	|
	|-RVA: 0x3030E90 Offset: 0x3030F91 VA: 0x3030E90
	|-Dictionary<MeshDataConnectivity.Face, bool>.Add
	|
	|-RVA: 0x3034520 Offset: 0x3034621 VA: 0x3034520
	|-Dictionary<MeshDataConnectivity.Face, List<int>>.Add
	|-Dictionary<MeshDataConnectivity.Face, object>.Add
	|
	|-RVA: 0x3037B90 Offset: 0x3037C91 VA: 0x3037B90
	|-Dictionary<Bounds, object>.Add
	|
	|-RVA: 0x303B6C0 Offset: 0x303B7C1 VA: 0x303B6C0
	|-Dictionary<BoundsInt, object>.Add
	|
	|-RVA: 0x303F1C0 Offset: 0x303F2C1 VA: 0x303F1C0
	|-Dictionary<Color, object>.Add
	|
	|-RVA: 0x3042900 Offset: 0x3042A01 VA: 0x3042900
	|-Dictionary<Color32, object>.Add
	|
	|-RVA: 0x3045F60 Offset: 0x3046061 VA: 0x3045F60
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Add
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.Add
	|
	|-RVA: 0x3064AA0 Offset: 0x3064BA1 VA: 0x3064AA0
	|-Dictionary<GradientAlphaKey, object>.Add
	|
	|-RVA: 0x3068160 Offset: 0x3068261 VA: 0x3068160
	|-Dictionary<GradientColorKey, object>.Add
	|
	|-RVA: 0x306BCB0 Offset: 0x306BDB1 VA: 0x306BCB0
	|-Dictionary<Keyframe, object>.Add
	|
	|-RVA: 0x306F9C0 Offset: 0x306FAC1 VA: 0x306F9C0
	|-Dictionary<LayerMask, object>.Add
	|
	|-RVA: 0x30730B0 Offset: 0x30731B1 VA: 0x30730B0
	|-Dictionary<Matrix4x4, object>.Add
	|
	|-RVA: 0x3077040 Offset: 0x3077141 VA: 0x3077040
	|-Dictionary<IntVec3, List<int>>.Add
	|-Dictionary<IntVec3, object>.Add
	|
	|-RVA: 0x307A730 Offset: 0x307A831 VA: 0x307A730
	|-Dictionary<Quaternion, object>.Add
	|
	|-RVA: 0x307DE70 Offset: 0x307DF71 VA: 0x307DE70
	|-Dictionary<RangeInt, object>.Add
	|
	|-RVA: 0x30495A0 Offset: 0x30496A1 VA: 0x30495A0
	|-Dictionary<Rect, object>.Add
	|
	|-RVA: 0x304CCF0 Offset: 0x304CDF1 VA: 0x304CCF0
	|-Dictionary<RectInt, object>.Add
	|
	|-RVA: 0x3050360 Offset: 0x3050461 VA: 0x3050360
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.Add
	|
	|-RVA: 0x30539D0 Offset: 0x3053AD1 VA: 0x30539D0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Add
	|
	|-RVA: 0x3057000 Offset: 0x3057101 VA: 0x3057000
	|-Dictionary<Vector2, object>.Add
	|
	|-RVA: 0x305A670 Offset: 0x305A771 VA: 0x305A670
	|-Dictionary<Vector2Int, object>.Add
	|
	|-RVA: 0x305DCB0 Offset: 0x305DDB1 VA: 0x305DCB0
	|-Dictionary<Vector3, List<int>>.Add
	|-Dictionary<Vector3, object>.Add
	|
	|-RVA: 0x3061390 Offset: 0x3061491 VA: 0x3061390
	|-Dictionary<Vector3Int, object>.Add
	|
	|-RVA: 0x2E3AD90 Offset: 0x2E3AE91 VA: 0x2E3AD90
	|-Dictionary<Vector4, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16760 Offset: 0x2A16861 VA: 0x2A16760
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2A19DE0 Offset: 0x2A19EE1 VA: 0x2A19DE0
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E29E90 Offset: 0x2E29F91 VA: 0x2E29E90
	|-Dictionary<Season, Texture>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F78BC0 Offset: 0x2F78CC1 VA: 0x2F78BC0
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F7C780 Offset: 0x2F7C881 VA: 0x2F7C780
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F807C0 Offset: 0x2F808C1 VA: 0x2F807C0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F84280 Offset: 0x2F84381 VA: 0x2F84280
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F87990 Offset: 0x2F87A91 VA: 0x2F87990
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F8B0B0 Offset: 0x2F8B1B1 VA: 0x2F8B0B0
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F8EDA0 Offset: 0x2F8EEA1 VA: 0x2F8EDA0
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F92550 Offset: 0x2F92651 VA: 0x2F92550
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D80630 Offset: 0x2D80731 VA: 0x2D80630
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D84200 Offset: 0x2D84301 VA: 0x2D84200
	|-Dictionary<Parameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D87E80 Offset: 0x2D87F81 VA: 0x2D87E80
	|-Dictionary<bool, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D8B500 Offset: 0x2D8B601 VA: 0x2D8B500
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D8EB20 Offset: 0x2D8EC21 VA: 0x2D8EB20
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D92140 Offset: 0x2D92241 VA: 0x2D92140
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D95760 Offset: 0x2D95861 VA: 0x2D95760
	|-Dictionary<double, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D98D80 Offset: 0x2D98E81 VA: 0x2D98D80
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D9C3F0 Offset: 0x2D9C4F1 VA: 0x2D9C3F0
	|-Dictionary<short, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D3A690 Offset: 0x2D3A791 VA: 0x2D3A690
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D3E230 Offset: 0x2D3E331 VA: 0x2D3E230
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D41B20 Offset: 0x2D41C21 VA: 0x2D41B20
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D451C0 Offset: 0x2D452C1 VA: 0x2D451C0
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D48DD0 Offset: 0x2D48ED1 VA: 0x2D48DD0
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D4C490 Offset: 0x2D4C591 VA: 0x2D4C490
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D4FA70 Offset: 0x2D4FB71 VA: 0x2D4FA70
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D53030 Offset: 0x2D53131 VA: 0x2D53030
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2D565F0 Offset: 0x2D566F1 VA: 0x2D565F0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F5C700 Offset: 0x2F5C801 VA: 0x2F5C700
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F5FD90 Offset: 0x2F5FE91 VA: 0x2F5FD90
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F63450 Offset: 0x2F63551 VA: 0x2F63450
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F66ED0 Offset: 0x2F66FD1 VA: 0x2F66ED0
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F6A5A0 Offset: 0x2F6A6A1 VA: 0x2F6A5A0
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F6DC20 Offset: 0x2F6DD21 VA: 0x2F6DC20
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F71460 Offset: 0x2F71561 VA: 0x2F71460
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F750C0 Offset: 0x2F751C1 VA: 0x2F750C0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E1C560 Offset: 0x2E1C661 VA: 0x2E1C560
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E1FC70 Offset: 0x2E1FD71 VA: 0x2E1FC70
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E23260 Offset: 0x2E23361 VA: 0x2E23260
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E268D0 Offset: 0x2E269D1 VA: 0x2E268D0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E2D460 Offset: 0x2E2D561 VA: 0x2E2D460
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E30A70 Offset: 0x2E30B71 VA: 0x2E30A70
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E34040 Offset: 0x2E34141 VA: 0x2E34040
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E37710 Offset: 0x2E37811 VA: 0x2E37710
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F96230 Offset: 0x2F96331 VA: 0x2F96230
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F99980 Offset: 0x2F99A81 VA: 0x2F99980
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F9CFB0 Offset: 0x2F9D0B1 VA: 0x2F9CFB0
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FA0630 Offset: 0x2FA0731 VA: 0x2FA0630
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FA3EC0 Offset: 0x2FA3FC1 VA: 0x2FA3EC0
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FA7E20 Offset: 0x2FA7F21 VA: 0x2FA7E20
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FABCD0 Offset: 0x2FABDD1 VA: 0x2FABCD0
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FAF530 Offset: 0x2FAF631 VA: 0x2FAF530
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F1A5B0 Offset: 0x2F1A6B1 VA: 0x2F1A5B0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F1DEF0 Offset: 0x2F1DFF1 VA: 0x2F1DEF0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F21BF0 Offset: 0x2F21CF1 VA: 0x2F21BF0
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F258A0 Offset: 0x2F259A1 VA: 0x2F258A0
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F291C0 Offset: 0x2F292C1 VA: 0x2F291C0
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F2D670 Offset: 0x2F2D771 VA: 0x2F2D670
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F31300 Offset: 0x2F31401 VA: 0x2F31300
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F34C40 Offset: 0x2F34D41 VA: 0x2F34C40
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2EFD950 Offset: 0x2EFDA51 VA: 0x2EFD950
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F015E0 Offset: 0x2F016E1 VA: 0x2F015E0
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F04EB0 Offset: 0x2F04FB1 VA: 0x2F04EB0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F08780 Offset: 0x2F08881 VA: 0x2F08780
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F0BFC0 Offset: 0x2F0C0C1 VA: 0x2F0BFC0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F0F870 Offset: 0x2F0F971 VA: 0x2F0F870
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F134F0 Offset: 0x2F135F1 VA: 0x2F134F0
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2F16C20 Offset: 0x2F16D21 VA: 0x2F16C20
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FF3480 Offset: 0x2FF3581 VA: 0x2FF3480
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FF7140 Offset: 0x2FF7241 VA: 0x2FF7140
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FFAAA0 Offset: 0x2FFABA1 VA: 0x2FFAAA0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FFE1D0 Offset: 0x2FFE2D1 VA: 0x2FFE1D0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3001960 Offset: 0x3001A61 VA: 0x3001960
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3005400 Offset: 0x3005501 VA: 0x3005400
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3008BD0 Offset: 0x3008CD1 VA: 0x3008BD0
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x300C6F0 Offset: 0x300C7F1 VA: 0x300C6F0
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DDDE60 Offset: 0x2DDDF61 VA: 0x2DDDE60
	|-Dictionary<object, Parameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DE19C0 Offset: 0x2DE1AC1 VA: 0x2DE19C0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DE5090 Offset: 0x2DE5191 VA: 0x2DE5090
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DE8770 Offset: 0x2DE8871 VA: 0x2DE8770
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DEBE30 Offset: 0x2DEBF31 VA: 0x2DEBE30
	|-Dictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DEF4F0 Offset: 0x2DEF5F1 VA: 0x2DEF4F0
	|-Dictionary<object, DateTime>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DF2BA0 Offset: 0x2DF2CA1 VA: 0x2DF2BA0
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DF6260 Offset: 0x2DF6361 VA: 0x2DF6260
	|-Dictionary<object, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DF9920 Offset: 0x2DF9A21 VA: 0x2DF9920
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30B8EE0 Offset: 0x30B8FE1 VA: 0x30B8EE0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30BC5A0 Offset: 0x30BC6A1 VA: 0x30BC5A0
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30BFC50 Offset: 0x30BFD51 VA: 0x30BFC50
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30C3370 Offset: 0x30C3471 VA: 0x30C3370
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30C6BB0 Offset: 0x30C6CB1 VA: 0x30C6BB0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30CA810 Offset: 0x30CA911 VA: 0x30CA810
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30CE3D0 Offset: 0x30CE4D1 VA: 0x30CE3D0
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30D1BE0 Offset: 0x30D1CE1 VA: 0x30D1BE0
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30100B0 Offset: 0x30101B1 VA: 0x30100B0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3013970 Offset: 0x3013A71 VA: 0x3013970
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3017460 Offset: 0x3017561 VA: 0x3017460
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x301AF20 Offset: 0x301B021 VA: 0x301AF20
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x301E7D0 Offset: 0x301E8D1 VA: 0x301E7D0
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3022730 Offset: 0x3022831 VA: 0x3022730
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30261C0 Offset: 0x30262C1 VA: 0x30261C0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3029A80 Offset: 0x3029B81 VA: 0x3029A80
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FD7060 Offset: 0x2FD7161 VA: 0x2FD7060
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FDAAF0 Offset: 0x2FDABF1 VA: 0x2FDAAF0
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FDE340 Offset: 0x2FDE441 VA: 0x2FDE340
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FE1B90 Offset: 0x2FE1C91 VA: 0x2FE1B90
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FE5380 Offset: 0x2FE5481 VA: 0x2FE5380
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FE8BE0 Offset: 0x2FE8CE1 VA: 0x2FE8BE0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FEC670 Offset: 0x2FEC771 VA: 0x2FEC670
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2FEFC70 Offset: 0x2FEFD71 VA: 0x2FEFC70
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DBE720 Offset: 0x2DBE821 VA: 0x2DBE720
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DC1E40 Offset: 0x2DC1F41 VA: 0x2DC1E40
	|-Dictionary<object, sbyte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DC5500 Offset: 0x2DC5601 VA: 0x2DC5500
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DC8BC0 Offset: 0x2DC8CC1 VA: 0x2DC8BC0
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DCC280 Offset: 0x2DCC381 VA: 0x2DCC280
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DCF940 Offset: 0x2DCFA41 VA: 0x2DCF940
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DD3060 Offset: 0x2DD3161 VA: 0x2DD3060
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DD6A80 Offset: 0x2DD6B81 VA: 0x2DD6A80
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DDA440 Offset: 0x2DDA541 VA: 0x2DDA440
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30D5670 Offset: 0x30D5771 VA: 0x30D5670
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30D8D30 Offset: 0x30D8E31 VA: 0x30D8D30
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30DC450 Offset: 0x30DC551 VA: 0x30DC450
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30DFBB0 Offset: 0x30DFCB1 VA: 0x30DFBB0
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30E35B0 Offset: 0x30E36B1 VA: 0x30E35B0
	|-Dictionary<object, Keyframe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30E7050 Offset: 0x30E7151 VA: 0x30E7050
	|-Dictionary<object, LayerMask>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30EA7D0 Offset: 0x30EA8D1 VA: 0x30EA7D0
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30EE3C0 Offset: 0x30EE4C1 VA: 0x30EE3C0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x309D1C0 Offset: 0x309D2C1 VA: 0x309D1C0
	|-Dictionary<object, Quaternion>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30A08E0 Offset: 0x30A09E1 VA: 0x30A08E0
	|-Dictionary<object, RangeInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30A3F90 Offset: 0x30A4091 VA: 0x30A3F90
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30A76B0 Offset: 0x30A77B1 VA: 0x30A76B0
	|-Dictionary<object, RectInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30AAE10 Offset: 0x30AAF11 VA: 0x30AAE10
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30AE7E0 Offset: 0x30AE8E1 VA: 0x30AE7E0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30B2140 Offset: 0x30B2241 VA: 0x30B2140
	|-Dictionary<object, Vector2>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30B5830 Offset: 0x30B5931 VA: 0x30B5830
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30814C0 Offset: 0x30815C1 VA: 0x30814C0
	|-Dictionary<object, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3084BD0 Offset: 0x3084CD1 VA: 0x3084BD0
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3088300 Offset: 0x3088401 VA: 0x3088300
	|-Dictionary<object, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x308BA30 Offset: 0x308BB31 VA: 0x308BA30
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x308F0B0 Offset: 0x308F1B1 VA: 0x308F0B0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3092740 Offset: 0x3092841 VA: 0x3092740
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3095E60 Offset: 0x3095F61 VA: 0x3095E60
	|-Dictionary<float, CurveSample>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3099BB0 Offset: 0x3099CB1 VA: 0x3099BB0
	|-Dictionary<float, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x319D110 Offset: 0x319D211 VA: 0x319D110
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31A0720 Offset: 0x31A0821 VA: 0x31A0720
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31A3CE0 Offset: 0x31A3DE1 VA: 0x31A3CE0
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31A72B0 Offset: 0x31A73B1 VA: 0x31A72B0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31AA8D0 Offset: 0x31AA9D1 VA: 0x31AA8D0
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31ADEF0 Offset: 0x31ADFF1 VA: 0x31ADEF0
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31B1620 Offset: 0x31B1721 VA: 0x31B1620
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x31B51B0 Offset: 0x31B52B1 VA: 0x31B51B0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x302D580 Offset: 0x302D681 VA: 0x302D580
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3030EC0 Offset: 0x3030FC1 VA: 0x3030EC0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3034550 Offset: 0x3034651 VA: 0x3034550
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3037BF0 Offset: 0x3037CF1 VA: 0x3037BF0
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x303B720 Offset: 0x303B821 VA: 0x303B720
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x303F1F0 Offset: 0x303F2F1 VA: 0x303F1F0
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3042930 Offset: 0x3042A31 VA: 0x3042930
	|-Dictionary<Color32, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3045F90 Offset: 0x3046091 VA: 0x3045F90
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3064AD0 Offset: 0x3064BD1 VA: 0x3064AD0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30681C0 Offset: 0x30682C1 VA: 0x30681C0
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x306BD20 Offset: 0x306BE21 VA: 0x306BD20
	|-Dictionary<Keyframe, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x306F9F0 Offset: 0x306FAF1 VA: 0x306F9F0
	|-Dictionary<LayerMask, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3073130 Offset: 0x3073231 VA: 0x3073130
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3077070 Offset: 0x3077171 VA: 0x3077070
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x307A760 Offset: 0x307A861 VA: 0x307A760
	|-Dictionary<Quaternion, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x307DEA0 Offset: 0x307DFA1 VA: 0x307DEA0
	|-Dictionary<RangeInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30495D0 Offset: 0x30496D1 VA: 0x30495D0
	|-Dictionary<Rect, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x304CD20 Offset: 0x304CE21 VA: 0x304CD20
	|-Dictionary<RectInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3050390 Offset: 0x3050491 VA: 0x3050390
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3053A00 Offset: 0x3053B01 VA: 0x3053A00
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3057030 Offset: 0x3057131 VA: 0x3057030
	|-Dictionary<Vector2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x305A6A0 Offset: 0x305A7A1 VA: 0x305A6A0
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x305DCE0 Offset: 0x305DDE1 VA: 0x305DCE0
	|-Dictionary<Vector3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x30613C0 Offset: 0x30614C1 VA: 0x30613C0
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2E3ADC0 Offset: 0x2E3AEC1 VA: 0x2E3ADC0
	|-Dictionary<Vector4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16790 Offset: 0x2A16891 VA: 0x2A16790
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2A19E10 Offset: 0x2A19F11 VA: 0x2A19E10
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E29EC0 Offset: 0x2E29FC1 VA: 0x2E29EC0
	|-Dictionary<Season, Texture>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F78C20 Offset: 0x2F78D21 VA: 0x2F78C20
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F7C810 Offset: 0x2F7C911 VA: 0x2F7C810
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F80820 Offset: 0x2F80921 VA: 0x2F80820
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F842C0 Offset: 0x2F843C1 VA: 0x2F842C0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F879C0 Offset: 0x2F87AC1 VA: 0x2F879C0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F8B120 Offset: 0x2F8B221 VA: 0x2F8B120
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F8EDE0 Offset: 0x2F8EEE1 VA: 0x2F8EDE0
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F925C0 Offset: 0x2F926C1 VA: 0x2F925C0
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D80690 Offset: 0x2D80791 VA: 0x2D80690
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D84290 Offset: 0x2D84391 VA: 0x2D84290
	|-Dictionary<Parameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D87EB0 Offset: 0x2D87FB1 VA: 0x2D87EB0
	|-Dictionary<bool, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D8B530 Offset: 0x2D8B631 VA: 0x2D8B530
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D8EB50 Offset: 0x2D8EC51 VA: 0x2D8EB50
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D92170 Offset: 0x2D92271 VA: 0x2D92170
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D95790 Offset: 0x2D95891 VA: 0x2D95790
	|-Dictionary<double, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D98DB0 Offset: 0x2D98EB1 VA: 0x2D98DB0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D9C420 Offset: 0x2D9C521 VA: 0x2D9C420
	|-Dictionary<short, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D3A720 Offset: 0x2D3A821 VA: 0x2D3A720
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D3E2A0 Offset: 0x2D3E3A1 VA: 0x2D3E2A0
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D41B50 Offset: 0x2D41C51 VA: 0x2D41B50
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D45250 Offset: 0x2D45351 VA: 0x2D45250
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D48E00 Offset: 0x2D48F01 VA: 0x2D48E00
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D4C4C0 Offset: 0x2D4C5C1 VA: 0x2D4C4C0
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D4FAA0 Offset: 0x2D4FBA1 VA: 0x2D4FAA0
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D53060 Offset: 0x2D53161 VA: 0x2D53060
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2D56620 Offset: 0x2D56721 VA: 0x2D56620
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F5C730 Offset: 0x2F5C831 VA: 0x2F5C730
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F5FDC0 Offset: 0x2F5FEC1 VA: 0x2F5FDC0
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F634D0 Offset: 0x2F635D1 VA: 0x2F634D0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F66F00 Offset: 0x2F67001 VA: 0x2F66F00
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F6A5E0 Offset: 0x2F6A6E1 VA: 0x2F6A5E0
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F6DC60 Offset: 0x2F6DD61 VA: 0x2F6DC60
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F714F0 Offset: 0x2F715F1 VA: 0x2F714F0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F75140 Offset: 0x2F75241 VA: 0x2F75140
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E1C5A0 Offset: 0x2E1C6A1 VA: 0x2E1C5A0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E1FCA0 Offset: 0x2E1FDA1 VA: 0x2E1FCA0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E232A0 Offset: 0x2E233A1 VA: 0x2E232A0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E26900 Offset: 0x2E26A01 VA: 0x2E26900
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E2D490 Offset: 0x2E2D591 VA: 0x2E2D490
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E30AA0 Offset: 0x2E30BA1 VA: 0x2E30AA0
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E34070 Offset: 0x2E34171 VA: 0x2E34070
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E37740 Offset: 0x2E37841 VA: 0x2E37740
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F96270 Offset: 0x2F96371 VA: 0x2F96270
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F999B0 Offset: 0x2F99AB1 VA: 0x2F999B0
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F9CFE0 Offset: 0x2F9D0E1 VA: 0x2F9CFE0
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FA0660 Offset: 0x2FA0761 VA: 0x2FA0660
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FA3F30 Offset: 0x2FA4031 VA: 0x2FA3F30
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FA7E90 Offset: 0x2FA7F91 VA: 0x2FA7E90
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FABD00 Offset: 0x2FABE01 VA: 0x2FABD00
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FAF590 Offset: 0x2FAF691 VA: 0x2FAF590
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F1A5F0 Offset: 0x2F1A6F1 VA: 0x2F1A5F0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F1DF50 Offset: 0x2F1E051 VA: 0x2F1DF50
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F21C50 Offset: 0x2F21D51 VA: 0x2F21C50
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F258D0 Offset: 0x2F259D1 VA: 0x2F258D0
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F29260 Offset: 0x2F29361 VA: 0x2F29260
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F2D6D0 Offset: 0x2F2D7D1 VA: 0x2F2D6D0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F31340 Offset: 0x2F31441 VA: 0x2F31340
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F34CA0 Offset: 0x2F34DA1 VA: 0x2F34CA0
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2EFD9B0 Offset: 0x2EFDAB1 VA: 0x2EFD9B0
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F01620 Offset: 0x2F01721 VA: 0x2F01620
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F04EF0 Offset: 0x2F04FF1 VA: 0x2F04EF0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F087B0 Offset: 0x2F088B1 VA: 0x2F087B0
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F0BFF0 Offset: 0x2F0C0F1 VA: 0x2F0BFF0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F0F8D0 Offset: 0x2F0F9D1 VA: 0x2F0F8D0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F13520 Offset: 0x2F13621 VA: 0x2F13520
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2F16C90 Offset: 0x2F16D91 VA: 0x2F16C90
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FF3510 Offset: 0x2FF3611 VA: 0x2FF3510
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FF71B0 Offset: 0x2FF72B1 VA: 0x2FF71B0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FFAAE0 Offset: 0x2FFABE1 VA: 0x2FFAAE0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FFE210 Offset: 0x2FFE311 VA: 0x2FFE210
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30019E0 Offset: 0x3001AE1 VA: 0x30019E0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3005440 Offset: 0x3005541 VA: 0x3005440
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3008C50 Offset: 0x3008D51 VA: 0x3008C50
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x300C760 Offset: 0x300C861 VA: 0x300C760
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DDDEE0 Offset: 0x2DDDFE1 VA: 0x2DDDEE0
	|-Dictionary<object, Parameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DE19F0 Offset: 0x2DE1AF1 VA: 0x2DE19F0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DE50C0 Offset: 0x2DE51C1 VA: 0x2DE50C0
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DE87A0 Offset: 0x2DE88A1 VA: 0x2DE87A0
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DEBE60 Offset: 0x2DEBF61 VA: 0x2DEBE60
	|-Dictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DEF520 Offset: 0x2DEF621 VA: 0x2DEF520
	|-Dictionary<object, DateTime>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DF2BD0 Offset: 0x2DF2CD1 VA: 0x2DF2BD0
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DF6290 Offset: 0x2DF6391 VA: 0x2DF6290
	|-Dictionary<object, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DF9950 Offset: 0x2DF9A51 VA: 0x2DF9950
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30B8F10 Offset: 0x30B9011 VA: 0x30B8F10
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30BC5D0 Offset: 0x30BC6D1 VA: 0x30BC5D0
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30BFC90 Offset: 0x30BFD91 VA: 0x30BFC90
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30C33A0 Offset: 0x30C34A1 VA: 0x30C33A0
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30C6C30 Offset: 0x30C6D31 VA: 0x30C6C30
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30CA890 Offset: 0x30CA991 VA: 0x30CA890
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30CE400 Offset: 0x30CE501 VA: 0x30CE400
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30D1C50 Offset: 0x30D1D51 VA: 0x30D1C50
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30100F0 Offset: 0x30101F1 VA: 0x30100F0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30139E0 Offset: 0x3013AE1 VA: 0x30139E0
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30174D0 Offset: 0x30175D1 VA: 0x30174D0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x301AF50 Offset: 0x301B051 VA: 0x301AF50
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x301E870 Offset: 0x301E971 VA: 0x301E870
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30227A0 Offset: 0x30228A1 VA: 0x30227A0
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3026200 Offset: 0x3026301 VA: 0x3026200
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3029AF0 Offset: 0x3029BF1 VA: 0x3029AF0
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FD70D0 Offset: 0x2FD71D1 VA: 0x2FD70D0
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FDAB30 Offset: 0x2FDAC31 VA: 0x2FDAB30
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FDE380 Offset: 0x2FDE481 VA: 0x2FDE380
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FE1BD0 Offset: 0x2FE1CD1 VA: 0x2FE1BD0
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FE53C0 Offset: 0x2FE54C1 VA: 0x2FE53C0
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FE8C50 Offset: 0x2FE8D51 VA: 0x2FE8C50
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FEC6A0 Offset: 0x2FEC7A1 VA: 0x2FEC6A0
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2FEFCB0 Offset: 0x2FEFDB1 VA: 0x2FEFCB0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DBE760 Offset: 0x2DBE861 VA: 0x2DBE760
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DC1E70 Offset: 0x2DC1F71 VA: 0x2DC1E70
	|-Dictionary<object, sbyte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DC5530 Offset: 0x2DC5631 VA: 0x2DC5530
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DC8BF0 Offset: 0x2DC8CF1 VA: 0x2DC8BF0
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DCC2B0 Offset: 0x2DCC3B1 VA: 0x2DCC2B0
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DCF970 Offset: 0x2DCFA71 VA: 0x2DCF970
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DD30D0 Offset: 0x2DD31D1 VA: 0x2DD30D0
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DD6AF0 Offset: 0x2DD6BF1 VA: 0x2DD6AF0
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DDA4B0 Offset: 0x2DDA5B1 VA: 0x2DDA4B0
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30D56A0 Offset: 0x30D57A1 VA: 0x30D56A0
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30D8D60 Offset: 0x30D8E61 VA: 0x30D8D60
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30DC480 Offset: 0x30DC581 VA: 0x30DC480
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30DFC20 Offset: 0x30DFD21 VA: 0x30DFC20
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30E3630 Offset: 0x30E3731 VA: 0x30E3630
	|-Dictionary<object, Keyframe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30E7080 Offset: 0x30E7181 VA: 0x30E7080
	|-Dictionary<object, LayerMask>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30EA860 Offset: 0x30EA961 VA: 0x30EA860
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30EE400 Offset: 0x30EE501 VA: 0x30EE400
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x309D1F0 Offset: 0x309D2F1 VA: 0x309D1F0
	|-Dictionary<object, Quaternion>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30A0910 Offset: 0x30A0A11 VA: 0x30A0910
	|-Dictionary<object, RangeInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30A3FC0 Offset: 0x30A40C1 VA: 0x30A3FC0
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30A76F0 Offset: 0x30A77F1 VA: 0x30A76F0
	|-Dictionary<object, RectInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30AAE80 Offset: 0x30AAF81 VA: 0x30AAE80
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30AE850 Offset: 0x30AE951 VA: 0x30AE850
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30B2170 Offset: 0x30B2271 VA: 0x30B2170
	|-Dictionary<object, Vector2>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30B5860 Offset: 0x30B5961 VA: 0x30B5860
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30814F0 Offset: 0x30815F1 VA: 0x30814F0
	|-Dictionary<object, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3084C10 Offset: 0x3084D11 VA: 0x3084C10
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3088330 Offset: 0x3088431 VA: 0x3088330
	|-Dictionary<object, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x308BA60 Offset: 0x308BB61 VA: 0x308BA60
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x308F0E0 Offset: 0x308F1E1 VA: 0x308F0E0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3092770 Offset: 0x3092871 VA: 0x3092770
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3095F00 Offset: 0x3096001 VA: 0x3095F00
	|-Dictionary<float, CurveSample>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3099BE0 Offset: 0x3099CE1 VA: 0x3099BE0
	|-Dictionary<float, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x319D140 Offset: 0x319D241 VA: 0x319D140
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31A0750 Offset: 0x31A0851 VA: 0x31A0750
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31A3D10 Offset: 0x31A3E11 VA: 0x31A3D10
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31A72E0 Offset: 0x31A73E1 VA: 0x31A72E0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31AA900 Offset: 0x31AAA01 VA: 0x31AA900
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31ADF20 Offset: 0x31AE021 VA: 0x31ADF20
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31B16A0 Offset: 0x31B17A1 VA: 0x31B16A0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x31B5230 Offset: 0x31B5331 VA: 0x31B5230
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x302D5F0 Offset: 0x302D6F1 VA: 0x302D5F0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3030EF0 Offset: 0x3030FF1 VA: 0x3030EF0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3034580 Offset: 0x3034681 VA: 0x3034580
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3037C50 Offset: 0x3037D51 VA: 0x3037C50
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x303B780 Offset: 0x303B881 VA: 0x303B780
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x303F230 Offset: 0x303F331 VA: 0x303F230
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3042960 Offset: 0x3042A61 VA: 0x3042960
	|-Dictionary<Color32, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3045FC0 Offset: 0x30460C1 VA: 0x3045FC0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3064B10 Offset: 0x3064C11 VA: 0x3064B10
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3068220 Offset: 0x3068321 VA: 0x3068220
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x306BD90 Offset: 0x306BE91 VA: 0x306BD90
	|-Dictionary<Keyframe, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x306FA20 Offset: 0x306FB21 VA: 0x306FA20
	|-Dictionary<LayerMask, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30731B0 Offset: 0x30732B1 VA: 0x30731B0
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30770B0 Offset: 0x30771B1 VA: 0x30770B0
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x307A7A0 Offset: 0x307A8A1 VA: 0x307A7A0
	|-Dictionary<Quaternion, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x307DED0 Offset: 0x307DFD1 VA: 0x307DED0
	|-Dictionary<RangeInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3049610 Offset: 0x3049711 VA: 0x3049610
	|-Dictionary<Rect, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x304CD50 Offset: 0x304CE51 VA: 0x304CD50
	|-Dictionary<RectInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x30503C0 Offset: 0x30504C1 VA: 0x30503C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3053A30 Offset: 0x3053B31 VA: 0x3053A30
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3057070 Offset: 0x3057171 VA: 0x3057070
	|-Dictionary<Vector2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x305A6D0 Offset: 0x305A7D1 VA: 0x305A6D0
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x305DD20 Offset: 0x305DE21 VA: 0x305DD20
	|-Dictionary<Vector3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3061400 Offset: 0x3061501 VA: 0x3061400
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2E3AE00 Offset: 0x2E3AF01 VA: 0x2E3AE00
	|-Dictionary<Vector4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16860 Offset: 0x2A16961 VA: 0x2A16860
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2A19EE0 Offset: 0x2A19FE1 VA: 0x2A19EE0
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E29F80 Offset: 0x2E2A081 VA: 0x2E29F80
	|-Dictionary<Season, Texture>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F78D10 Offset: 0x2F78E11 VA: 0x2F78D10
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F7C920 Offset: 0x2F7CA21 VA: 0x2F7C920
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F80910 Offset: 0x2F80A11 VA: 0x2F80910
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F84390 Offset: 0x2F84491 VA: 0x2F84390
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F87A90 Offset: 0x2F87B91 VA: 0x2F87A90
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F8B220 Offset: 0x2F8B321 VA: 0x2F8B220
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F8EEB0 Offset: 0x2F8EFB1 VA: 0x2F8EEB0
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F926C0 Offset: 0x2F927C1 VA: 0x2F926C0
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D80780 Offset: 0x2D80881 VA: 0x2D80780
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D84380 Offset: 0x2D84481 VA: 0x2D84380
	|-Dictionary<Parameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D87F80 Offset: 0x2D88081 VA: 0x2D87F80
	|-Dictionary<bool, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D8B5F0 Offset: 0x2D8B6F1 VA: 0x2D8B5F0
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D8EC10 Offset: 0x2D8ED11 VA: 0x2D8EC10
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D92230 Offset: 0x2D92331 VA: 0x2D92230
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D95860 Offset: 0x2D95961 VA: 0x2D95860
	|-Dictionary<double, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D98E80 Offset: 0x2D98F81 VA: 0x2D98E80
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D9C4E0 Offset: 0x2D9C5E1 VA: 0x2D9C4E0
	|-Dictionary<short, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D3A840 Offset: 0x2D3A941 VA: 0x2D3A840
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D3E3B0 Offset: 0x2D3E4B1 VA: 0x2D3E3B0
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D41C10 Offset: 0x2D41D11 VA: 0x2D41C10
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D453A0 Offset: 0x2D454A1 VA: 0x2D453A0
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D48ED0 Offset: 0x2D48FD1 VA: 0x2D48ED0
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D4C580 Offset: 0x2D4C681 VA: 0x2D4C580
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D4FB60 Offset: 0x2D4FC61 VA: 0x2D4FB60
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D53120 Offset: 0x2D53221 VA: 0x2D53120
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2D566E0 Offset: 0x2D567E1 VA: 0x2D566E0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F5C7F0 Offset: 0x2F5C8F1 VA: 0x2F5C7F0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F5FE80 Offset: 0x2F5FF81 VA: 0x2F5FE80
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F63600 Offset: 0x2F63701 VA: 0x2F63600
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F66FD0 Offset: 0x2F670D1 VA: 0x2F66FD0
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F6A6A0 Offset: 0x2F6A7A1 VA: 0x2F6A6A0
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F6DD40 Offset: 0x2F6DE41 VA: 0x2F6DD40
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F71610 Offset: 0x2F71711 VA: 0x2F71610
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F75270 Offset: 0x2F75371 VA: 0x2F75270
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E1C670 Offset: 0x2E1C771 VA: 0x2E1C670
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E1FD60 Offset: 0x2E1FE61 VA: 0x2E1FD60
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E23360 Offset: 0x2E23461 VA: 0x2E23360
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E269C0 Offset: 0x2E26AC1 VA: 0x2E269C0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E2D550 Offset: 0x2E2D651 VA: 0x2E2D550
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E30B60 Offset: 0x2E30C61 VA: 0x2E30B60
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E34140 Offset: 0x2E34241 VA: 0x2E34140
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E37810 Offset: 0x2E37911 VA: 0x2E37810
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F96340 Offset: 0x2F96441 VA: 0x2F96340
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F99A70 Offset: 0x2F99B71 VA: 0x2F99A70
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F9D0B0 Offset: 0x2F9D1B1 VA: 0x2F9D0B0
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FA0720 Offset: 0x2FA0821 VA: 0x2FA0720
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FA4030 Offset: 0x2FA4131 VA: 0x2FA4030
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FA7F90 Offset: 0x2FA8091 VA: 0x2FA7F90
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FABDC0 Offset: 0x2FABEC1 VA: 0x2FABDC0
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FAF680 Offset: 0x2FAF781 VA: 0x2FAF680
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F1A6C0 Offset: 0x2F1A7C1 VA: 0x2F1A6C0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F1E040 Offset: 0x2F1E141 VA: 0x2F1E040
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F21D40 Offset: 0x2F21E41 VA: 0x2F21D40
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F25990 Offset: 0x2F25A91 VA: 0x2F25990
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F29380 Offset: 0x2F29481 VA: 0x2F29380
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F2D7C0 Offset: 0x2F2D8C1 VA: 0x2F2D7C0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F31410 Offset: 0x2F31511 VA: 0x2F31410
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F34D90 Offset: 0x2F34E91 VA: 0x2F34D90
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2EFDAA0 Offset: 0x2EFDBA1 VA: 0x2EFDAA0
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F016F0 Offset: 0x2F017F1 VA: 0x2F016F0
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F04FC0 Offset: 0x2F050C1 VA: 0x2F04FC0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F08880 Offset: 0x2F08981 VA: 0x2F08880
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F0C0C0 Offset: 0x2F0C1C1 VA: 0x2F0C0C0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F0F9C0 Offset: 0x2F0FAC1 VA: 0x2F0F9C0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F135E0 Offset: 0x2F136E1 VA: 0x2F135E0
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2F16DA0 Offset: 0x2F16EA1 VA: 0x2F16DA0
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FF3670 Offset: 0x2FF3771 VA: 0x2FF3670
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FF72C0 Offset: 0x2FF73C1 VA: 0x2FF72C0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FFABB0 Offset: 0x2FFACB1 VA: 0x2FFABB0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FFE2E0 Offset: 0x2FFE3E1 VA: 0x2FFE2E0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3001B10 Offset: 0x3001C11 VA: 0x3001B10
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3005510 Offset: 0x3005611 VA: 0x3005510
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3008D80 Offset: 0x3008E81 VA: 0x3008D80
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x300C870 Offset: 0x300C971 VA: 0x300C870
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DDE000 Offset: 0x2DDE101 VA: 0x2DDE000
	|-Dictionary<object, Parameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DE1AC0 Offset: 0x2DE1BC1 VA: 0x2DE1AC0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DE5190 Offset: 0x2DE5291 VA: 0x2DE5190
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DE8860 Offset: 0x2DE8961 VA: 0x2DE8860
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DEBF20 Offset: 0x2DEC021 VA: 0x2DEBF20
	|-Dictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DEF5E0 Offset: 0x2DEF6E1 VA: 0x2DEF5E0
	|-Dictionary<object, DateTime>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DF2C90 Offset: 0x2DF2D91 VA: 0x2DF2C90
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DF6350 Offset: 0x2DF6451 VA: 0x2DF6350
	|-Dictionary<object, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DF9A10 Offset: 0x2DF9B11 VA: 0x2DF9A10
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30B8FD0 Offset: 0x30B90D1 VA: 0x30B8FD0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30BC690 Offset: 0x30BC791 VA: 0x30BC690
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30BFD60 Offset: 0x30BFE61 VA: 0x30BFD60
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30C3460 Offset: 0x30C3561 VA: 0x30C3460
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30C6D60 Offset: 0x30C6E61 VA: 0x30C6D60
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30CA9C0 Offset: 0x30CAAC1 VA: 0x30CA9C0
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30CE4C0 Offset: 0x30CE5C1 VA: 0x30CE4C0
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30D1D60 Offset: 0x30D1E61 VA: 0x30D1D60
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30101C0 Offset: 0x30102C1 VA: 0x30101C0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3013AF0 Offset: 0x3013BF1 VA: 0x3013AF0
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30175E0 Offset: 0x30176E1 VA: 0x30175E0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x301B010 Offset: 0x301B111 VA: 0x301B010
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x301E9F0 Offset: 0x301EAF1 VA: 0x301E9F0
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30228B0 Offset: 0x30229B1 VA: 0x30228B0
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30262D0 Offset: 0x30263D1 VA: 0x30262D0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3029C00 Offset: 0x3029D01 VA: 0x3029C00
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FD71E0 Offset: 0x2FD72E1 VA: 0x2FD71E0
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FDAC00 Offset: 0x2FDAD01 VA: 0x2FDAC00
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FDE450 Offset: 0x2FDE551 VA: 0x2FDE450
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FE1CA0 Offset: 0x2FE1DA1 VA: 0x2FE1CA0
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FE5490 Offset: 0x2FE5591 VA: 0x2FE5490
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FE8D60 Offset: 0x2FE8E61 VA: 0x2FE8D60
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FEC760 Offset: 0x2FEC861 VA: 0x2FEC760
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2FEFD80 Offset: 0x2FEFE81 VA: 0x2FEFD80
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DBE830 Offset: 0x2DBE931 VA: 0x2DBE830
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DC1F30 Offset: 0x2DC2031 VA: 0x2DC1F30
	|-Dictionary<object, sbyte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DC55F0 Offset: 0x2DC56F1 VA: 0x2DC55F0
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DC8CB0 Offset: 0x2DC8DB1 VA: 0x2DC8CB0
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DCC370 Offset: 0x2DCC471 VA: 0x2DCC370
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DCFA30 Offset: 0x2DCFB31 VA: 0x2DCFA30
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DD31E0 Offset: 0x2DD32E1 VA: 0x2DD31E0
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DD6C00 Offset: 0x2DD6D01 VA: 0x2DD6C00
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DDA5C0 Offset: 0x2DDA6C1 VA: 0x2DDA5C0
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30D5760 Offset: 0x30D5861 VA: 0x30D5760
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30D8E30 Offset: 0x30D8F31 VA: 0x30D8E30
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30DC550 Offset: 0x30DC651 VA: 0x30DC550
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30DFD30 Offset: 0x30DFE31 VA: 0x30DFD30
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30E3760 Offset: 0x30E3861 VA: 0x30E3760
	|-Dictionary<object, Keyframe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30E7140 Offset: 0x30E7241 VA: 0x30E7140
	|-Dictionary<object, LayerMask>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30EA9B0 Offset: 0x30EAAB1 VA: 0x30EA9B0
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30EE4D0 Offset: 0x30EE5D1 VA: 0x30EE4D0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x309D2C0 Offset: 0x309D3C1 VA: 0x309D2C0
	|-Dictionary<object, Quaternion>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30A09D0 Offset: 0x30A0AD1 VA: 0x30A09D0
	|-Dictionary<object, RangeInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30A4090 Offset: 0x30A4191 VA: 0x30A4090
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30A77C0 Offset: 0x30A78C1 VA: 0x30A77C0
	|-Dictionary<object, RectInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30AAF90 Offset: 0x30AB091 VA: 0x30AAF90
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30AE960 Offset: 0x30AEA61 VA: 0x30AE960
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30B2240 Offset: 0x30B2341 VA: 0x30B2240
	|-Dictionary<object, Vector2>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30B5920 Offset: 0x30B5A21 VA: 0x30B5920
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30815C0 Offset: 0x30816C1 VA: 0x30815C0
	|-Dictionary<object, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3084CE0 Offset: 0x3084DE1 VA: 0x3084CE0
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3088400 Offset: 0x3088501 VA: 0x3088400
	|-Dictionary<object, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x308BB30 Offset: 0x308BC31 VA: 0x308BB30
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x308F1A0 Offset: 0x308F2A1 VA: 0x308F1A0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3092830 Offset: 0x3092931 VA: 0x3092830
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3096090 Offset: 0x3096191 VA: 0x3096090
	|-Dictionary<float, CurveSample>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3099CB0 Offset: 0x3099DB1 VA: 0x3099CB0
	|-Dictionary<float, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x319D200 Offset: 0x319D301 VA: 0x319D200
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31A0810 Offset: 0x31A0911 VA: 0x31A0810
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31A3DD0 Offset: 0x31A3ED1 VA: 0x31A3DD0
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31A73A0 Offset: 0x31A74A1 VA: 0x31A73A0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31AA9C0 Offset: 0x31AAAC1 VA: 0x31AA9C0
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31ADFE0 Offset: 0x31AE0E1 VA: 0x31ADFE0
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31B17E0 Offset: 0x31B18E1 VA: 0x31B17E0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x31B5360 Offset: 0x31B5461 VA: 0x31B5360
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x302D700 Offset: 0x302D801 VA: 0x302D700
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3030FC0 Offset: 0x30310C1 VA: 0x3030FC0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3034640 Offset: 0x3034741 VA: 0x3034640
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3037D40 Offset: 0x3037E41 VA: 0x3037D40
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x303B870 Offset: 0x303B971 VA: 0x303B870
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x303F300 Offset: 0x303F401 VA: 0x303F300
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3042A30 Offset: 0x3042B31 VA: 0x3042A30
	|-Dictionary<Color32, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3046080 Offset: 0x3046181 VA: 0x3046080
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3064BE0 Offset: 0x3064CE1 VA: 0x3064BE0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3068310 Offset: 0x3068411 VA: 0x3068310
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x306BE90 Offset: 0x306BF91 VA: 0x306BE90
	|-Dictionary<Keyframe, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x306FAF0 Offset: 0x306FBF1 VA: 0x306FAF0
	|-Dictionary<LayerMask, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30732C0 Offset: 0x30733C1 VA: 0x30732C0
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3077180 Offset: 0x3077281 VA: 0x3077180
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x307A870 Offset: 0x307A971 VA: 0x307A870
	|-Dictionary<Quaternion, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x307DF90 Offset: 0x307E091 VA: 0x307DF90
	|-Dictionary<RangeInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30496E0 Offset: 0x30497E1 VA: 0x30496E0
	|-Dictionary<Rect, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x304CE20 Offset: 0x304CF21 VA: 0x304CE20
	|-Dictionary<RectInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3050480 Offset: 0x3050581 VA: 0x3050480
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3053AF0 Offset: 0x3053BF1 VA: 0x3053AF0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3057140 Offset: 0x3057241 VA: 0x3057140
	|-Dictionary<Vector2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x305A790 Offset: 0x305A891 VA: 0x305A790
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x305DDF0 Offset: 0x305DEF1 VA: 0x305DDF0
	|-Dictionary<Vector3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x30614D0 Offset: 0x30615D1 VA: 0x30614D0
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2E3AED0 Offset: 0x2E3AFD1 VA: 0x2E3AED0
	|-Dictionary<Vector4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E2D630 Offset: 0x2E2D731 VA: 0x2E2D630
	|-Dictionary<BaffamoID, BaffamoFestivalData>.Clear
	|-Dictionary<BeanID, BeanData>.Clear
	|-Dictionary<ActorID, ActorData>.Clear
	|-Dictionary<ActorID, LifeCycleScriptPlayer>.Clear
	|-Dictionary<ActorID, HumanStatusData>.Clear
	|-Dictionary<ActorID, MobTravelerName>.Clear
	|-Dictionary<ActorID, NpcStatusData>.Clear
	|-Dictionary<ActorID, List<MonsterDataID>>.Clear
	|-Dictionary<CharID, HumanDataArray>.Clear
	|-Dictionary<HairType, Dictionary<VariationNo, HumanData>>.Clear
	|-Dictionary<ToolChargeLevel, ParticleSystem>.Clear
	|-Dictionary<FoodID, GluttonFood>.Clear
	|-Dictionary<GateDataID, GateController>.Clear
	|-Dictionary<ItemID, ItemPoolData>.Clear
	|-Dictionary<MonsterModelDataID, MonsterModelData>.Clear
	|-Dictionary<SnowmanObjectID, SnowballData>.Clear
	|-Dictionary<Int32Enum, object>.Clear
	|
	|-RVA: 0x2A16960 Offset: 0x2A16A61 VA: 0x2A16960
	|-Dictionary<JSONDeserialization.TaskField, object>.Clear
	|
	|-RVA: 0x2A19FC0 Offset: 0x2A1A0C1 VA: 0x2A19FC0
	|-Dictionary<BitVector32Int, object>.Clear
	|
	|-RVA: 0x2DC56D0 Offset: 0x2DC57D1 VA: 0x2DC56D0
	|-Dictionary<Character, float>.Clear
	|-Dictionary<object, float>.Clear
	|
	|-RVA: 0x2FEC840 Offset: 0x2FEC941 VA: 0x2FEC840
	|-Dictionary<Tween, TweenLink>.Clear
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.Clear
	|-Dictionary<OptionDefinition, OptionsControlBase>.Clear
	|-Dictionary<object, object>.Clear
	|-Dictionary<string, ActionCode>.Clear
	|-Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>.Clear
	|-Dictionary<string, IKeyframeGroup>.Clear
	|-Dictionary<string, PadBindData>.Clear
	|-Dictionary<string, List<GameObject>>.Clear
	|-Dictionary<string, string>.Clear
	|-Dictionary<string, Sprite>.Clear
	|-Dictionary<Type, ITweenPlugin>.Clear
	|-Dictionary<Type, object>.Clear
	|-Dictionary<Camera, Camera>.Clear
	|-Dictionary<Collider, CharacterNearCullingController>.Clear
	|-Dictionary<Collider, FocusInterface>.Clear
	|-Dictionary<GameObject, Renderer[]>.Clear
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.Clear
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.Clear
	|
	|-RVA: 0x2E2A070 Offset: 0x2E2A171 VA: 0x2E2A070
	|-Dictionary<ActorID, CharID>.Clear
	|-Dictionary<Season, Texture>.Clear
	|-Dictionary<Int32Enum, Int32Enum>.Clear
	|
	|-RVA: 0x2E30C50 Offset: 0x2E30D51 VA: 0x2E30C50
	|-Dictionary<ActorID, float>.Clear
	|-Dictionary<AttackAttribute, float>.Clear
	|-Dictionary<Int32Enum, float>.Clear
	|
	|-RVA: 0x2E26AB0 Offset: 0x2E26BB1 VA: 0x2E26AB0
	|-Dictionary<Weather, int>.Clear
	|-Dictionary<ItemID, int>.Clear
	|-Dictionary<Int32Enum, int>.Clear
	|
	|-RVA: 0x2F78E40 Offset: 0x2F78F41 VA: 0x2F78E40
	|-Dictionary<EventCheckId, object>.Clear
	|
	|-RVA: 0x2F7CAA0 Offset: 0x2F7CBA1 VA: 0x2F7CAA0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.Clear
	|
	|-RVA: 0x2F80A40 Offset: 0x2F80B41 VA: 0x2F80A40
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.Clear
	|
	|-RVA: 0x2F84490 Offset: 0x2F84591 VA: 0x2F84490
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.Clear
	|
	|-RVA: 0x2F87B90 Offset: 0x2F87C91 VA: 0x2F87B90
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.Clear
	|
	|-RVA: 0x2DF9AF0 Offset: 0x2DF9BF1 VA: 0x2DF9AF0
	|-Dictionary<MonsterControllerBase, int>.Clear
	|-Dictionary<object, int>.Clear
	|-Dictionary<string, int>.Clear
	|-Dictionary<Camera, int>.Clear
	|
	|-RVA: 0x2F8B370 Offset: 0x2F8B471 VA: 0x2F8B370
	|-Dictionary<MonsterHutSaveData, object>.Clear
	|
	|-RVA: 0x2F8EFB0 Offset: 0x2F8F0B1 VA: 0x2F8EFB0
	|-Dictionary<OrderLotterySaveParameter, object>.Clear
	|
	|-RVA: 0x2F92810 Offset: 0x2F92911 VA: 0x2F92810
	|-Dictionary<OrderSaveData, object>.Clear
	|
	|-RVA: 0x2D808B0 Offset: 0x2D809B1 VA: 0x2D808B0
	|-Dictionary<OrderSaveParameter, object>.Clear
	|
	|-RVA: 0x2D844B0 Offset: 0x2D845B1 VA: 0x2D844B0
	|-Dictionary<Parameter, object>.Clear
	|
	|-RVA: 0x2E34240 Offset: 0x2E34341 VA: 0x2E34240
	|-Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.Clear
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.Clear
	|
	|-RVA: 0x2D88070 Offset: 0x2D88171 VA: 0x2D88070
	|-Dictionary<bool, object>.Clear
	|
	|-RVA: 0x2D8B6D0 Offset: 0x2D8B7D1 VA: 0x2D8B6D0
	|-Dictionary<byte, object>.Clear
	|
	|-RVA: 0x2D8ECF0 Offset: 0x2D8EDF1 VA: 0x2D8ECF0
	|-Dictionary<char, object>.Clear
	|
	|-RVA: 0x2D92310 Offset: 0x2D92411 VA: 0x2D92310
	|-Dictionary<DateTime, object>.Clear
	|
	|-RVA: 0x2D95940 Offset: 0x2D95A41 VA: 0x2D95940
	|-Dictionary<double, object>.Clear
	|
	|-RVA: 0x2D98F80 Offset: 0x2D99081 VA: 0x2D98F80
	|-Dictionary<Guid, object>.Clear
	|
	|-RVA: 0x2D9C5C0 Offset: 0x2D9C6C1 VA: 0x2D9C5C0
	|-Dictionary<short, object>.Clear
	|
	|-RVA: 0x2F5FF60 Offset: 0x2F60061 VA: 0x2F5FF60
	|-Dictionary<int, BehaviorManager.BehaviorTree.ConditionalReevaluate>.Clear
	|-Dictionary<int, BossBehaviorController>.Clear
	|-Dictionary<int, BossStageManager>.Clear
	|-Dictionary<int, DLCPair>.Clear
	|-Dictionary<int, FishSwim>.Clear
	|-Dictionary<int, HarinezumiController.NeedleController>.Clear
	|-Dictionary<int, ASSET_TABLE>.Clear
	|-Dictionary<int, AssetHandle>.Clear
	|-Dictionary<int, AssetInfo>.Clear
	|-Dictionary<int, MonsterBehaviorController>.Clear
	|-Dictionary<int, PartnerNPCBehaviorController>.Clear
	|-Dictionary<int, object>.Clear
	|-Dictionary<int, string>.Clear
	|-Dictionary<int, TMP_Style>.Clear
	|-Dictionary<int, PointerEventData>.Clear
	|-Dictionary<int, TerrainUtility.TerrainMap>.Clear
	|
	|-RVA: 0x2D3A980 Offset: 0x2D3AA81 VA: 0x2D3A980
	|-Dictionary<int, CropDataTable>.Clear
	|
	|-RVA: 0x2D3E4E0 Offset: 0x2D3E5E1 VA: 0x2D3E4E0
	|-Dictionary<int, EffectDataTable>.Clear
	|
	|-RVA: 0x2D41D00 Offset: 0x2D41E01 VA: 0x2D41D00
	|-Dictionary<int, GimmickLayoutDataTable>.Clear
	|
	|-RVA: 0x2D45510 Offset: 0x2D45611 VA: 0x2D45510
	|-Dictionary<int, MineTypeDataTable>.Clear
	|
	|-RVA: 0x2D48FD0 Offset: 0x2D490D1 VA: 0x2D48FD0
	|-Dictionary<int, MiningDataTable>.Clear
	|
	|-RVA: 0x2D4C670 Offset: 0x2D4C771 VA: 0x2D4C670
	|-Dictionary<int, bool>.Clear
	|
	|-RVA: 0x2D4FC50 Offset: 0x2D4FD51 VA: 0x2D4FC50
	|-Dictionary<int, char>.Clear
	|
	|-RVA: 0x2D53210 Offset: 0x2D53311 VA: 0x2D53210
	|-Dictionary<int, int>.Clear
	|
	|-RVA: 0x2D567D0 Offset: 0x2D568D1 VA: 0x2D567D0
	|-Dictionary<int, Int32Enum>.Clear
	|
	|-RVA: 0x2F5C8D0 Offset: 0x2F5C9D1 VA: 0x2F5C8D0
	|-Dictionary<int, long>.Clear
	|
	|-RVA: 0x2F63740 Offset: 0x2F63841 VA: 0x2F63740
	|-Dictionary<int, DiagnosticEvent>.Clear
	|
	|-RVA: 0x2F670D0 Offset: 0x2F671D1 VA: 0x2F670D0
	|-Dictionary<int, SceneInstance>.Clear
	|
	|-RVA: 0x2F6A780 Offset: 0x2F6A881 VA: 0x2F6A780
	|-Dictionary<int, Vector2Int>.Clear
	|
	|-RVA: 0x2F6DE40 Offset: 0x2F6DF41 VA: 0x2F6DE40
	|-Dictionary<int, Vector3>.Clear
	|
	|-RVA: 0x2F71750 Offset: 0x2F71851 VA: 0x2F71750
	|-Dictionary<Int32Enum, MonsterDataTable>.Clear
	|
	|-RVA: 0x2F753B0 Offset: 0x2F754B1 VA: 0x2F753B0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.Clear
	|
	|-RVA: 0x2E1C770 Offset: 0x2E1C871 VA: 0x2E1C770
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Clear
	|
	|-RVA: 0x2E1FE50 Offset: 0x2E1FF51 VA: 0x2E1FE50
	|-Dictionary<Int32Enum, bool>.Clear
	|
	|-RVA: 0x2E23440 Offset: 0x2E23541 VA: 0x2E23440
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.Clear
	|
	|-RVA: 0x2E37900 Offset: 0x2E37A01 VA: 0x2E37900
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.Clear
	|
	|-RVA: 0x2F96440 Offset: 0x2F96541 VA: 0x2F96440
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.Clear
	|
	|-RVA: 0x2F99B50 Offset: 0x2F99C51 VA: 0x2F99B50
	|-Dictionary<long, object>.Clear
	|
	|-RVA: 0x2F9D1B0 Offset: 0x2F9D2B1 VA: 0x2F9D1B0
	|-Dictionary<Memory<object>, object>.Clear
	|
	|-RVA: 0x2FA0800 Offset: 0x2FA0901 VA: 0x2FA0800
	|-Dictionary<Nullable<Int32Enum>, object>.Clear
	|
	|-RVA: 0x2FA4180 Offset: 0x2FA4281 VA: 0x2FA4180
	|-Dictionary<Nullable<Bounds>, object>.Clear
	|
	|-RVA: 0x2FA80E0 Offset: 0x2FA81E1 VA: 0x2FA80E0
	|-Dictionary<Nullable<BoundsInt>, object>.Clear
	|
	|-RVA: 0x2FABEA0 Offset: 0x2FABFA1 VA: 0x2FABEA0
	|-Dictionary<Nullable<Color32>, object>.Clear
	|
	|-RVA: 0x2FAF7B0 Offset: 0x2FAF8B1 VA: 0x2FAF7B0
	|-Dictionary<Nullable<Color>, object>.Clear
	|
	|-RVA: 0x2F1A7C0 Offset: 0x2F1A8C1 VA: 0x2F1A7C0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.Clear
	|
	|-RVA: 0x2F1E170 Offset: 0x2F1E271 VA: 0x2F1E170
	|-Dictionary<Nullable<GradientColorKey>, object>.Clear
	|
	|-RVA: 0x2F21E70 Offset: 0x2F21F71 VA: 0x2F21E70
	|-Dictionary<Nullable<Keyframe>, object>.Clear
	|
	|-RVA: 0x2F25A70 Offset: 0x2F25B71 VA: 0x2F25A70
	|-Dictionary<Nullable<LayerMask>, object>.Clear
	|
	|-RVA: 0x2F29520 Offset: 0x2F29621 VA: 0x2F29520
	|-Dictionary<Nullable<Matrix4x4>, object>.Clear
	|
	|-RVA: 0x2F2D8F0 Offset: 0x2F2D9F1 VA: 0x2F2D8F0
	|-Dictionary<Nullable<Quaternion>, object>.Clear
	|
	|-RVA: 0x2F31510 Offset: 0x2F31611 VA: 0x2F31510
	|-Dictionary<Nullable<RangeInt>, object>.Clear
	|
	|-RVA: 0x2F34EC0 Offset: 0x2F34FC1 VA: 0x2F34EC0
	|-Dictionary<Nullable<Rect>, object>.Clear
	|
	|-RVA: 0x2EFDBD0 Offset: 0x2EFDCD1 VA: 0x2EFDBD0
	|-Dictionary<Nullable<RectInt>, object>.Clear
	|
	|-RVA: 0x2F017F0 Offset: 0x2F018F1 VA: 0x2F017F0
	|-Dictionary<Nullable<Vector2>, object>.Clear
	|
	|-RVA: 0x2F050C0 Offset: 0x2F051C1 VA: 0x2F050C0
	|-Dictionary<Nullable<Vector2Int>, object>.Clear
	|
	|-RVA: 0x2F08980 Offset: 0x2F08A81 VA: 0x2F08980
	|-Dictionary<Nullable<Vector3>, object>.Clear
	|
	|-RVA: 0x2F0C1C0 Offset: 0x2F0C2C1 VA: 0x2F0C1C0
	|-Dictionary<Nullable<Vector3Int>, object>.Clear
	|
	|-RVA: 0x2F0FAF0 Offset: 0x2F0FBF1 VA: 0x2F0FAF0
	|-Dictionary<Nullable<Vector4>, object>.Clear
	|
	|-RVA: 0x2F136C0 Offset: 0x2F137C1 VA: 0x2F136C0
	|-Dictionary<object, BitVector32Int>.Clear
	|
	|-RVA: 0x2F16EC0 Offset: 0x2F16FC1 VA: 0x2F16EC0
	|-Dictionary<object, EventCheckId>.Clear
	|
	|-RVA: 0x2FF37F0 Offset: 0x2FF38F1 VA: 0x2FF37F0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.Clear
	|
	|-RVA: 0x2FF73E0 Offset: 0x2FF74E1 VA: 0x2FF73E0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.Clear
	|
	|-RVA: 0x2FFACB0 Offset: 0x2FFADB1 VA: 0x2FFACB0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.Clear
	|
	|-RVA: 0x2FFE3E0 Offset: 0x2FFE4E1 VA: 0x2FFE3E0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.Clear
	|
	|-RVA: 0x3001C50 Offset: 0x3001D51 VA: 0x3001C50
	|-Dictionary<object, MonsterHutSaveData>.Clear
	|
	|-RVA: 0x3005610 Offset: 0x3005711 VA: 0x3005610
	|-Dictionary<object, OrderLotterySaveParameter>.Clear
	|
	|-RVA: 0x3008EC0 Offset: 0x3008FC1 VA: 0x3008EC0
	|-Dictionary<object, OrderSaveData>.Clear
	|
	|-RVA: 0x300C990 Offset: 0x300CA91 VA: 0x300C990
	|-Dictionary<object, OrderSaveParameter>.Clear
	|
	|-RVA: 0x2DDE140 Offset: 0x2DDE241 VA: 0x2DDE140
	|-Dictionary<object, Parameter>.Clear
	|
	|-RVA: 0x2DE1BC0 Offset: 0x2DE1CC1 VA: 0x2DE1BC0
	|-Dictionary<object, NumberControl.ValueRange>.Clear
	|
	|-RVA: 0x2DE5270 Offset: 0x2DE5371 VA: 0x2DE5270
	|-Dictionary<object, bool>.Clear
	|-Dictionary<Camera, bool>.Clear
	|
	|-RVA: 0x2DE8940 Offset: 0x2DE8A41 VA: 0x2DE8940
	|-Dictionary<object, byte>.Clear
	|
	|-RVA: 0x2DEC000 Offset: 0x2DEC101 VA: 0x2DEC000
	|-Dictionary<object, char>.Clear
	|
	|-RVA: 0x2DEF6C0 Offset: 0x2DEF7C1 VA: 0x2DEF6C0
	|-Dictionary<object, DateTime>.Clear
	|
	|-RVA: 0x2DF2D70 Offset: 0x2DF2E71 VA: 0x2DF2D70
	|-Dictionary<object, double>.Clear
	|
	|-RVA: 0x2DF6430 Offset: 0x2DF6531 VA: 0x2DF6430
	|-Dictionary<object, short>.Clear
	|
	|-RVA: 0x30B90B0 Offset: 0x30B91B1 VA: 0x30B90B0
	|-Dictionary<object, Int32Enum>.Clear
	|
	|-RVA: 0x30BC770 Offset: 0x30BC871 VA: 0x30BC770
	|-Dictionary<object, long>.Clear
	|
	|-RVA: 0x30BFE60 Offset: 0x30BFF61 VA: 0x30BFE60
	|-Dictionary<object, Memory<object>>.Clear
	|
	|-RVA: 0x30C3540 Offset: 0x30C3641 VA: 0x30C3540
	|-Dictionary<object, Nullable<Int32Enum>>.Clear
	|
	|-RVA: 0x30C6EA0 Offset: 0x30C6FA1 VA: 0x30C6EA0
	|-Dictionary<object, Nullable<Bounds>>.Clear
	|
	|-RVA: 0x30CAB00 Offset: 0x30CAC01 VA: 0x30CAB00
	|-Dictionary<object, Nullable<BoundsInt>>.Clear
	|
	|-RVA: 0x30CE5A0 Offset: 0x30CE6A1 VA: 0x30CE5A0
	|-Dictionary<object, Nullable<Color32>>.Clear
	|
	|-RVA: 0x30D1E80 Offset: 0x30D1F81 VA: 0x30D1E80
	|-Dictionary<object, Nullable<Color>>.Clear
	|
	|-RVA: 0x30102C0 Offset: 0x30103C1 VA: 0x30102C0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.Clear
	|
	|-RVA: 0x3013C10 Offset: 0x3013D11 VA: 0x3013C10
	|-Dictionary<object, Nullable<GradientColorKey>>.Clear
	|
	|-RVA: 0x3017700 Offset: 0x3017801 VA: 0x3017700
	|-Dictionary<object, Nullable<Keyframe>>.Clear
	|
	|-RVA: 0x301B0F0 Offset: 0x301B1F1 VA: 0x301B0F0
	|-Dictionary<object, Nullable<LayerMask>>.Clear
	|
	|-RVA: 0x301EB90 Offset: 0x301EC91 VA: 0x301EB90
	|-Dictionary<object, Nullable<Matrix4x4>>.Clear
	|
	|-RVA: 0x30229D0 Offset: 0x3022AD1 VA: 0x30229D0
	|-Dictionary<object, Nullable<Quaternion>>.Clear
	|
	|-RVA: 0x30263D0 Offset: 0x30264D1 VA: 0x30263D0
	|-Dictionary<object, Nullable<RangeInt>>.Clear
	|
	|-RVA: 0x3029D20 Offset: 0x3029E21 VA: 0x3029D20
	|-Dictionary<object, Nullable<Rect>>.Clear
	|
	|-RVA: 0x2FD7300 Offset: 0x2FD7401 VA: 0x2FD7300
	|-Dictionary<object, Nullable<RectInt>>.Clear
	|
	|-RVA: 0x2FDAD00 Offset: 0x2FDAE01 VA: 0x2FDAD00
	|-Dictionary<object, Nullable<Vector2>>.Clear
	|
	|-RVA: 0x2FDE550 Offset: 0x2FDE651 VA: 0x2FDE550
	|-Dictionary<object, Nullable<Vector2Int>>.Clear
	|
	|-RVA: 0x2FE1DA0 Offset: 0x2FE1EA1 VA: 0x2FE1DA0
	|-Dictionary<object, Nullable<Vector3>>.Clear
	|
	|-RVA: 0x2FE5590 Offset: 0x2FE5691 VA: 0x2FE5590
	|-Dictionary<object, Nullable<Vector3Int>>.Clear
	|
	|-RVA: 0x2FE8E80 Offset: 0x2FE8F81 VA: 0x2FE8E80
	|-Dictionary<object, Nullable<Vector4>>.Clear
	|
	|-RVA: 0x2FEFE80 Offset: 0x2FEFF81 VA: 0x2FEFE80
	|-Dictionary<object, ReadOnlyMemory<object>>.Clear
	|
	|-RVA: 0x2DBE930 Offset: 0x2DBEA31 VA: 0x2DBE930
	|-Dictionary<object, ResourceLocator>.Clear
	|
	|-RVA: 0x2DC2010 Offset: 0x2DC2111 VA: 0x2DC2010
	|-Dictionary<object, sbyte>.Clear
	|
	|-RVA: 0x2DC8D90 Offset: 0x2DC8E91 VA: 0x2DC8D90
	|-Dictionary<object, ushort>.Clear
	|
	|-RVA: 0x2DCC450 Offset: 0x2DCC551 VA: 0x2DCC450
	|-Dictionary<object, uint>.Clear
	|
	|-RVA: 0x2DCFB10 Offset: 0x2DCFC11 VA: 0x2DCFB10
	|-Dictionary<object, ulong>.Clear
	|
	|-RVA: 0x2DD3300 Offset: 0x2DD3401 VA: 0x2DD3300
	|-Dictionary<object, TransitionTables>.Clear
	|
	|-RVA: 0x2DD6D20 Offset: 0x2DD6E21 VA: 0x2DD6D20
	|-Dictionary<object, Bounds>.Clear
	|
	|-RVA: 0x2DDA6E0 Offset: 0x2DDA7E1 VA: 0x2DDA6E0
	|-Dictionary<object, BoundsInt>.Clear
	|
	|-RVA: 0x30D5840 Offset: 0x30D5941 VA: 0x30D5840
	|-Dictionary<object, Color32>.Clear
	|
	|-RVA: 0x30D8F30 Offset: 0x30D9031 VA: 0x30D8F30
	|-Dictionary<object, Color>.Clear
	|
	|-RVA: 0x30DC640 Offset: 0x30DC741 VA: 0x30DC640
	|-Dictionary<object, GradientAlphaKey>.Clear
	|
	|-RVA: 0x30DFE50 Offset: 0x30DFF51 VA: 0x30DFE50
	|-Dictionary<object, GradientColorKey>.Clear
	|
	|-RVA: 0x30E38A0 Offset: 0x30E39A1 VA: 0x30E38A0
	|-Dictionary<object, Keyframe>.Clear
	|
	|-RVA: 0x30E7220 Offset: 0x30E7321 VA: 0x30E7220
	|-Dictionary<object, LayerMask>.Clear
	|
	|-RVA: 0x30EAB20 Offset: 0x30EAC21 VA: 0x30EAB20
	|-Dictionary<object, Matrix4x4>.Clear
	|
	|-RVA: 0x30EE5D0 Offset: 0x30EE6D1 VA: 0x30EE5D0
	|-Dictionary<object, Playable>.Clear
	|-Dictionary<TrackAsset, Playable>.Clear
	|
	|-RVA: 0x309D3C0 Offset: 0x309D4C1 VA: 0x309D3C0
	|-Dictionary<object, Quaternion>.Clear
	|
	|-RVA: 0x30A0AB0 Offset: 0x30A0BB1 VA: 0x30A0AB0
	|-Dictionary<object, RangeInt>.Clear
	|
	|-RVA: 0x30A4190 Offset: 0x30A4291 VA: 0x30A4190
	|-Dictionary<object, Rect>.Clear
	|
	|-RVA: 0x30A78C0 Offset: 0x30A79C1 VA: 0x30A78C0
	|-Dictionary<object, RectInt>.Clear
	|
	|-RVA: 0x30AB0B0 Offset: 0x30AB1B1 VA: 0x30AB0B0
	|-Dictionary<object, AsyncOperationHandle>.Clear
	|
	|-RVA: 0x30AEA80 Offset: 0x30AEB81 VA: 0x30AEA80
	|-Dictionary<object, AsyncOperationHandle<object>>.Clear
	|
	|-RVA: 0x30B2330 Offset: 0x30B2431 VA: 0x30B2330
	|-Dictionary<object, Vector2>.Clear
	|
	|-RVA: 0x30B5A00 Offset: 0x30B5B01 VA: 0x30B5A00
	|-Dictionary<object, Vector2Int>.Clear
	|
	|-RVA: 0x30816C0 Offset: 0x30817C1 VA: 0x30816C0
	|-Dictionary<object, Vector3>.Clear
	|
	|-RVA: 0x3084DE0 Offset: 0x3084EE1 VA: 0x3084DE0
	|-Dictionary<object, Vector3Int>.Clear
	|
	|-RVA: 0x3088500 Offset: 0x3088601 VA: 0x3088500
	|-Dictionary<object, Vector4>.Clear
	|
	|-RVA: 0x308BC30 Offset: 0x308BD31 VA: 0x308BC30
	|-Dictionary<ReadOnlyMemory<object>, object>.Clear
	|
	|-RVA: 0x308F280 Offset: 0x308F381 VA: 0x308F280
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.Clear
	|
	|-RVA: 0x3092910 Offset: 0x3092A11 VA: 0x3092910
	|-Dictionary<sbyte, object>.Clear
	|
	|-RVA: 0x3096240 Offset: 0x3096341 VA: 0x3096240
	|-Dictionary<float, CurveSample>.Clear
	|
	|-RVA: 0x3099D90 Offset: 0x3099E91 VA: 0x3099D90
	|-Dictionary<float, object>.Clear
	|
	|-RVA: 0x319D2E0 Offset: 0x319D3E1 VA: 0x319D2E0
	|-Dictionary<ushort, object>.Clear
	|
	|-RVA: 0x31A3EC0 Offset: 0x31A3FC1 VA: 0x31A3EC0
	|-Dictionary<uint, ActorID>.Clear
	|-Dictionary<uint, PartnerMovementOrderType>.Clear
	|-Dictionary<uint, Int32Enum>.Clear
	|
	|-RVA: 0x31A7480 Offset: 0x31A7581 VA: 0x31A7480
	|-Dictionary<uint, FriendMonsterStatus>.Clear
	|-Dictionary<uint, object>.Clear
	|-Dictionary<uint, TMP_Character>.Clear
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.Clear
	|-Dictionary<uint, TMP_SpriteCharacter>.Clear
	|-Dictionary<uint, TMP_SpriteGlyph>.Clear
	|-Dictionary<uint, Glyph>.Clear
	|
	|-RVA: 0x31A0900 Offset: 0x31A0A01 VA: 0x31A0900
	|-Dictionary<uint, int>.Clear
	|
	|-RVA: 0x31AAAA0 Offset: 0x31AABA1 VA: 0x31AAAA0
	|-Dictionary<ulong, object>.Clear
	|
	|-RVA: 0x31AE0C0 Offset: 0x31AE1C1 VA: 0x31AE0C0
	|-Dictionary<EdgeKeyByHash, int>.Clear
	|
	|-RVA: 0x31B1930 Offset: 0x31B1A31 VA: 0x31B1930
	|-Dictionary<EdgeKeyByHash, CapEdge>.Clear
	|
	|-RVA: 0x31B54A0 Offset: 0x31B55A1 VA: 0x31B54A0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Clear
	|
	|-RVA: 0x302D820 Offset: 0x302D921 VA: 0x302D820
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.Clear
	|
	|-RVA: 0x30310A0 Offset: 0x30311A1 VA: 0x30310A0
	|-Dictionary<MeshDataConnectivity.Face, bool>.Clear
	|
	|-RVA: 0x3034720 Offset: 0x3034821 VA: 0x3034720
	|-Dictionary<MeshDataConnectivity.Face, object>.Clear
	|
	|-RVA: 0x3037E70 Offset: 0x3037F71 VA: 0x3037E70
	|-Dictionary<Bounds, object>.Clear
	|
	|-RVA: 0x303B9A0 Offset: 0x303BAA1 VA: 0x303B9A0
	|-Dictionary<BoundsInt, object>.Clear
	|
	|-RVA: 0x303F400 Offset: 0x303F501 VA: 0x303F400
	|-Dictionary<Color, object>.Clear
	|
	|-RVA: 0x3042B10 Offset: 0x3042C11 VA: 0x3042B10
	|-Dictionary<Color32, object>.Clear
	|
	|-RVA: 0x3046160 Offset: 0x3046261 VA: 0x3046160
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Clear
	|
	|-RVA: 0x3064CD0 Offset: 0x3064DD1 VA: 0x3064CD0
	|-Dictionary<GradientAlphaKey, object>.Clear
	|
	|-RVA: 0x3068440 Offset: 0x3068541 VA: 0x3068440
	|-Dictionary<GradientColorKey, object>.Clear
	|
	|-RVA: 0x306BFE0 Offset: 0x306C0E1 VA: 0x306BFE0
	|-Dictionary<Keyframe, object>.Clear
	|
	|-RVA: 0x306FBD0 Offset: 0x306FCD1 VA: 0x306FBD0
	|-Dictionary<LayerMask, object>.Clear
	|
	|-RVA: 0x3073430 Offset: 0x3073531 VA: 0x3073430
	|-Dictionary<Matrix4x4, object>.Clear
	|
	|-RVA: 0x3077280 Offset: 0x3077381 VA: 0x3077280
	|-Dictionary<IntVec3, object>.Clear
	|
	|-RVA: 0x307A970 Offset: 0x307AA71 VA: 0x307A970
	|-Dictionary<Quaternion, object>.Clear
	|
	|-RVA: 0x307E070 Offset: 0x307E171 VA: 0x307E070
	|-Dictionary<RangeInt, object>.Clear
	|
	|-RVA: 0x30497E0 Offset: 0x30498E1 VA: 0x30497E0
	|-Dictionary<Rect, object>.Clear
	|
	|-RVA: 0x304CF20 Offset: 0x304D021 VA: 0x304CF20
	|-Dictionary<RectInt, object>.Clear
	|
	|-RVA: 0x3050560 Offset: 0x3050661 VA: 0x3050560
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.Clear
	|
	|-RVA: 0x3053BD0 Offset: 0x3053CD1 VA: 0x3053BD0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Clear
	|
	|-RVA: 0x3057230 Offset: 0x3057331 VA: 0x3057230
	|-Dictionary<Vector2, object>.Clear
	|
	|-RVA: 0x305A870 Offset: 0x305A971 VA: 0x305A870
	|-Dictionary<Vector2Int, object>.Clear
	|
	|-RVA: 0x305DEF0 Offset: 0x305DFF1 VA: 0x305DEF0
	|-Dictionary<Vector3, object>.Clear
	|
	|-RVA: 0x30615D0 Offset: 0x30616D1 VA: 0x30615D0
	|-Dictionary<Vector3Int, object>.Clear
	|
	|-RVA: 0x2E3AFD0 Offset: 0x2E3B0D1 VA: 0x2E3AFD0
	|-Dictionary<Vector4, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC8E0 Offset: 0x2FEC9E1 VA: 0x2FEC8E0
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>.ContainsKey
	|-Dictionary<BinaryDeserialization.ObjectFieldMap, List<int>>.ContainsKey
	|-Dictionary<CharacterBase, DamageTextController>.ContainsKey
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.ContainsKey
	|-Dictionary<Tween, TweenLink>.ContainsKey
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.ContainsKey
	|-Dictionary<OptionDefinition, OptionsControlBase>.ContainsKey
	|-Dictionary<Action, LinkedListNode<Action>>.ContainsKey
	|-Dictionary<int[], SceneSplit>.ContainsKey
	|-Dictionary<int[], Terrain>.ContainsKey
	|-Dictionary<object, BehaviorManager.ThirdPartyTask>.ContainsKey
	|-Dictionary<object, ICollection<OptionDefinition>>.ContainsKey
	|-Dictionary<object, object>.ContainsKey
	|-Dictionary<string, ActionCode>.ContainsKey
	|-Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>.ContainsKey
	|-Dictionary<string, IKeyframeGroup>.ContainsKey
	|-Dictionary<string, ProfileFeatureDefinition>.ContainsKey
	|-Dictionary<string, ObjectSerializationInfo.EmittableMember>.ContainsKey
	|-Dictionary<string, PadBindData>.ContainsKey
	|-Dictionary<string, InfoBlock>.ContainsKey
	|-Dictionary<string, List<TaskCoroutine>>.ContainsKey
	|-Dictionary<string, List<GameObject>>.ContainsKey
	|-Dictionary<string, Func<bool>>.ContainsKey
	|-Dictionary<string, WebConnectionGroup>.ContainsKey
	|-Dictionary<string, object>.ContainsKey
	|-Dictionary<string, TeleportPortalData>.ContainsKey
	|-Dictionary<string, TeleportPositionDataObject>.ContainsKey
	|-Dictionary<string, SpringCapsuleCollider>.ContainsKey
	|-Dictionary<string, SpringPanelCollider>.ContainsKey
	|-Dictionary<string, SpringSphereCollider>.ContainsKey
	|-Dictionary<string, GameObject>.ContainsKey
	|-Dictionary<string, ResourceLocationBase>.ContainsKey
	|-Dictionary<string, Sprite>.ContainsKey
	|-Dictionary<string, Transform>.ContainsKey
	|-Dictionary<Type, object>.ContainsKey
	|-Dictionary<TimeParamTable, HashSet<MaterialChangeTime>>.ContainsKey
	|-Dictionary<MeshUniqueVertices.UniqueVertex, MeshUniqueVertices.RepeatedVertexList>.ContainsKey
	|-Dictionary<GameObject, Transform>.ContainsKey
	|-Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>>.ContainsKey
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.ContainsKey
	|
	|-RVA: 0x2A16A00 Offset: 0x2A16B01 VA: 0x2A16A00
	|-Dictionary<JSONDeserialization.TaskField, object>.ContainsKey
	|
	|-RVA: 0x2A1A060 Offset: 0x2A1A161 VA: 0x2A1A060
	|-Dictionary<BitVector32Int, object>.ContainsKey
	|
	|-RVA: 0x2E2D6D0 Offset: 0x2E2D7D1 VA: 0x2E2D6D0
	|-Dictionary<ActorID, ActorData>.ContainsKey
	|-Dictionary<ActorID, LifeCycleScriptPlayer>.ContainsKey
	|-Dictionary<ActorID, ItemStorageData>.ContainsKey
	|-Dictionary<ActorID, NpcStatusData>.ContainsKey
	|-Dictionary<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.ContainsKey
	|-Dictionary<ActorID, List<MonsterDataID>>.ContainsKey
	|-Dictionary<BadStatus, BadStatusEffectController.ObjInfo>.ContainsKey
	|-Dictionary<CharID, HumanDataArray>.ContainsKey
	|-Dictionary<HairType, Dictionary<VariationNo, HumanData>>.ContainsKey
	|-Dictionary<Season, string>.ContainsKey
	|-Dictionary<ToolChargeLevel, ParticleSystem>.ContainsKey
	|-Dictionary<TrackinCameraType, TrackingCameraSetting>.ContainsKey
	|-Dictionary<VariationNo, HumanData>.ContainsKey
	|-Dictionary<WantedFieldType, WantedField>.ContainsKey
	|-Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.ContainsKey
	|-Dictionary<EquipSlotType, AS_ToolController.ToolActionData>.ContainsKey
	|-Dictionary<EquipSlotType, HumanEquipItem>.ContainsKey
	|-Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.ContainsKey
	|-Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox>.ContainsKey
	|-Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>>.ContainsKey
	|-Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox>.ContainsKey
	|-Dictionary<FieldWoodBoxSpawnID, GameObject>.ContainsKey
	|-Dictionary<GateDataID, GateController>.ContainsKey
	|-Dictionary<GimmickLayoutID, HashSet<GimmickBase>>.ContainsKey
	|-Dictionary<ItemID, ItemPoolData>.ContainsKey
	|-Dictionary<Master, BossDataAssetBase>.ContainsKey
	|-Dictionary<Master, MonsterActionCodeDataTableArray>.ContainsKey
	|-Dictionary<Texture, Texture>.ContainsKey
	|-Dictionary<MonsterActionBehaviorDataID, List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>>.ContainsKey
	|-Dictionary<MonsterModelDataID, MonsterModelData>.ContainsKey
	|-Dictionary<MoveParamID, CharacterMoveParam>.ContainsKey
	|-Dictionary<NPCActionBehaviorDataID, List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>>.ContainsKey
	|-Dictionary<SoundID, EnvironmentSoundDataTable>.ContainsKey
	|-Dictionary<SoundID, AudioClip>.ContainsKey
	|-Dictionary<Int32Enum, object>.ContainsKey
	|-Dictionary<SystemLanguage, string>.ContainsKey
	|
	|-RVA: 0x2E2A110 Offset: 0x2E2A211 VA: 0x2E2A110
	|-Dictionary<ActorID, CharID>.ContainsKey
	|-Dictionary<FieldPlaceId, Place>.ContainsKey
	|-Dictionary<Place, FieldPlaceId>.ContainsKey
	|-Dictionary<Season, Texture>.ContainsKey
	|-Dictionary<ItemID, ItemID>.ContainsKey
	|-Dictionary<ItemType, EquipPointType>.ContainsKey
	|-Dictionary<Int32Enum, Int32Enum>.ContainsKey
	|-Dictionary<RuntimePlatform, AddressablesPlatform>.ContainsKey
	|
	|-RVA: 0x2E30CF0 Offset: 0x2E30DF1 VA: 0x2E30CF0
	|-Dictionary<ActorID, float>.ContainsKey
	|-Dictionary<AttackAttribute, float>.ContainsKey
	|-Dictionary<Int32Enum, float>.ContainsKey
	|
	|-RVA: 0x2F75450 Offset: 0x2F75551 VA: 0x2F75450
	|-Dictionary<MonsterFootStepEventDataID, MonsterFootStepEventDataTable>.ContainsKey
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.ContainsKey
	|
	|-RVA: 0x2F964E0 Offset: 0x2F965E1 VA: 0x2F964E0
	|-Dictionary<TutorialScriptType, TutorialUnlockFlagData>.ContainsKey
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.ContainsKey
	|
	|-RVA: 0x2F78EE0 Offset: 0x2F78FE1 VA: 0x2F78EE0
	|-Dictionary<EventCheckId, object>.ContainsKey
	|
	|-RVA: 0x2F7CB40 Offset: 0x2F7CC41 VA: 0x2F7CB40
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.ContainsKey
	|
	|-RVA: 0x2F80AE0 Offset: 0x2F80BE1 VA: 0x2F80AE0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.ContainsKey
	|
	|-RVA: 0x2F84530 Offset: 0x2F84631 VA: 0x2F84530
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.ContainsKey
	|
	|-RVA: 0x2F87C30 Offset: 0x2F87D31 VA: 0x2F87C30
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.ContainsKey
	|
	|-RVA: 0x2E234E0 Offset: 0x2E235E1 VA: 0x2E234E0
	|-Dictionary<FieldSceneId, KeyValuePair<FarmManager.FARM_ID, int>>.ContainsKey
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.ContainsKey
	|
	|-RVA: 0x2E1C810 Offset: 0x2E1C911 VA: 0x2E1C810
	|-Dictionary<ItemCategory, PartnerNPCWeaponBehaviorDataTable>.ContainsKey
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.ContainsKey
	|
	|-RVA: 0x2E26B50 Offset: 0x2E26C51 VA: 0x2E26B50
	|-Dictionary<ItemID, int>.ContainsKey
	|-Dictionary<Int32Enum, int>.ContainsKey
	|
	|-RVA: 0x2E1FEF0 Offset: 0x2E1FFF1 VA: 0x2E1FEF0
	|-Dictionary<ItemType, bool>.ContainsKey
	|-Dictionary<Int32Enum, bool>.ContainsKey
	|
	|-RVA: 0x2F717F0 Offset: 0x2F718F1 VA: 0x2F717F0
	|-Dictionary<MonsterDataID, MonsterDataTable>.ContainsKey
	|-Dictionary<Int32Enum, MonsterDataTable>.ContainsKey
	|
	|-RVA: 0x2F8B410 Offset: 0x2F8B511 VA: 0x2F8B410
	|-Dictionary<MonsterHutSaveData, object>.ContainsKey
	|
	|-RVA: 0x2DF9B90 Offset: 0x2DF9C91 VA: 0x2DF9B90
	|-Dictionary<OnGroundItem, int>.ContainsKey
	|-Dictionary<ParameterExpression, int>.ContainsKey
	|-Dictionary<object, int>.ContainsKey
	|-Dictionary<string, int>.ContainsKey
	|-Dictionary<Type, int>.ContainsKey
	|-Dictionary<Simplifier.VertexDataHash, int>.ContainsKey
	|-Dictionary<Camera, int>.ContainsKey
	|-Dictionary<GameObject, int>.ContainsKey
	|
	|-RVA: 0x2F8F050 Offset: 0x2F8F151 VA: 0x2F8F050
	|-Dictionary<OrderLotterySaveParameter, object>.ContainsKey
	|
	|-RVA: 0x2F928B0 Offset: 0x2F929B1 VA: 0x2F928B0
	|-Dictionary<OrderSaveData, object>.ContainsKey
	|
	|-RVA: 0x2D80950 Offset: 0x2D80A51 VA: 0x2D80950
	|-Dictionary<OrderSaveParameter, object>.ContainsKey
	|
	|-RVA: 0x2D84550 Offset: 0x2D84651 VA: 0x2D84550
	|-Dictionary<Parameter, object>.ContainsKey
	|
	|-RVA: 0x2E342E0 Offset: 0x2E343E1 VA: 0x2E342E0
	|-Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.ContainsKey
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.ContainsKey
	|
	|-RVA: 0x2D88110 Offset: 0x2D88211 VA: 0x2D88110
	|-Dictionary<bool, object>.ContainsKey
	|
	|-RVA: 0x2D8B770 Offset: 0x2D8B871 VA: 0x2D8B770
	|-Dictionary<byte, object>.ContainsKey
	|
	|-RVA: 0x2D8ED90 Offset: 0x2D8EE91 VA: 0x2D8ED90
	|-Dictionary<char, object>.ContainsKey
	|
	|-RVA: 0x2D923B0 Offset: 0x2D924B1 VA: 0x2D923B0
	|-Dictionary<DateTime, object>.ContainsKey
	|
	|-RVA: 0x2D959E0 Offset: 0x2D95AE1 VA: 0x2D959E0
	|-Dictionary<double, object>.ContainsKey
	|
	|-RVA: 0x2DD33A0 Offset: 0x2DD34A1 VA: 0x2DD33A0
	|-Dictionary<Enum, TransitionTables>.ContainsKey
	|-Dictionary<object, TransitionTables>.ContainsKey
	|
	|-RVA: 0x2D99020 Offset: 0x2D99121 VA: 0x2D99020
	|-Dictionary<Guid, MonoTlsProvider>.ContainsKey
	|-Dictionary<Guid, object>.ContainsKey
	|
	|-RVA: 0x2D9C660 Offset: 0x2D9C761 VA: 0x2D9C660
	|-Dictionary<short, object>.ContainsKey
	|
	|-RVA: 0x2F60000 Offset: 0x2F60101 VA: 0x2F60000
	|-Dictionary<int, ActorUtility.ActorCreateData>.ContainsKey
	|-Dictionary<int, BossBehaviorController>.ContainsKey
	|-Dictionary<int, BossStageManager>.ContainsKey
	|-Dictionary<int, DLCPair>.ContainsKey
	|-Dictionary<int, EventControllerBase.FirstMatchInfo>.ContainsKey
	|-Dictionary<int, HarinezumiController.NeedleController>.ContainsKey
	|-Dictionary<int, ItemID[]>.ContainsKey
	|-Dictionary<int, ASSET_TABLE>.ContainsKey
	|-Dictionary<int, AssetHandle>.ContainsKey
	|-Dictionary<int, AssetInfo>.ContainsKey
	|-Dictionary<int, ObjectSerializationInfo.EmittableMember>.ContainsKey
	|-Dictionary<int, MonsterActionInformationBase>.ContainsKey
	|-Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState>.ContainsKey
	|-Dictionary<int, MonsterBehaviorController>.ContainsKey
	|-Dictionary<int, NPCBehaviorDataTable>.ContainsKey
	|-Dictionary<int, OnGroundItem>.ContainsKey
	|-Dictionary<int, PartnerNPCBehaviorController>.ContainsKey
	|-Dictionary<int, Dictionary<int, List<OrderMasterData>>>.ContainsKey
	|-Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>>.ContainsKey
	|-Dictionary<int, List<Character>>.ContainsKey
	|-Dictionary<int, List<OrderMasterData>>.ContainsKey
	|-Dictionary<int, List<TimeManager.JustTimerData>>.ContainsKey
	|-Dictionary<int, List<MeshDataConnectivity.Face>>.ContainsKey
	|-Dictionary<int, Func<string>>.ContainsKey
	|-Dictionary<int, object>.ContainsKey
	|-Dictionary<int, string>.ContainsKey
	|-Dictionary<int, TMP_ColorGradient>.ContainsKey
	|-Dictionary<int, TMP_FontAsset>.ContainsKey
	|-Dictionary<int, TMP_SpriteAsset>.ContainsKey
	|-Dictionary<int, TMP_Style>.ContainsKey
	|-Dictionary<int, TerrainUtility.TerrainMap>.ContainsKey
	|-Dictionary<int, GameObject>.ContainsKey
	|-Dictionary<int, IAsyncOperation>.ContainsKey
	|
	|-RVA: 0x2D3AA20 Offset: 0x2D3AB21 VA: 0x2D3AA20
	|-Dictionary<int, CropDataTable>.ContainsKey
	|
	|-RVA: 0x2D3E580 Offset: 0x2D3E681 VA: 0x2D3E580
	|-Dictionary<int, EffectDataTable>.ContainsKey
	|
	|-RVA: 0x2D41DA0 Offset: 0x2D41EA1 VA: 0x2D41DA0
	|-Dictionary<int, GimmickLayoutDataTable>.ContainsKey
	|
	|-RVA: 0x2D455B0 Offset: 0x2D456B1 VA: 0x2D455B0
	|-Dictionary<int, MineTypeDataTable>.ContainsKey
	|
	|-RVA: 0x2D49070 Offset: 0x2D49171 VA: 0x2D49070
	|-Dictionary<int, MiningDataTable>.ContainsKey
	|
	|-RVA: 0x2D56870 Offset: 0x2D56971 VA: 0x2D56870
	|-Dictionary<int, MonsterDataID>.ContainsKey
	|-Dictionary<int, SoundID>.ContainsKey
	|-Dictionary<int, Int32Enum>.ContainsKey
	|
	|-RVA: 0x2D4C710 Offset: 0x2D4C811 VA: 0x2D4C710
	|-Dictionary<int, bool>.ContainsKey
	|
	|-RVA: 0x2D4FCF0 Offset: 0x2D4FDF1 VA: 0x2D4FCF0
	|-Dictionary<int, char>.ContainsKey
	|
	|-RVA: 0x2D532B0 Offset: 0x2D533B1 VA: 0x2D532B0
	|-Dictionary<int, int>.ContainsKey
	|
	|-RVA: 0x2F5C970 Offset: 0x2F5CA71 VA: 0x2F5C970
	|-Dictionary<int, long>.ContainsKey
	|
	|-RVA: 0x2F637E0 Offset: 0x2F638E1 VA: 0x2F637E0
	|-Dictionary<int, DiagnosticEvent>.ContainsKey
	|
	|-RVA: 0x2F67170 Offset: 0x2F67271 VA: 0x2F67170
	|-Dictionary<int, SceneInstance>.ContainsKey
	|
	|-RVA: 0x2F6A820 Offset: 0x2F6A921 VA: 0x2F6A820
	|-Dictionary<int, Vector2Int>.ContainsKey
	|
	|-RVA: 0x2F6DEE0 Offset: 0x2F6DFE1 VA: 0x2F6DEE0
	|-Dictionary<int, Vector3>.ContainsKey
	|
	|-RVA: 0x2E379A0 Offset: 0x2E37AA1 VA: 0x2E379A0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.ContainsKey
	|
	|-RVA: 0x2F99BF0 Offset: 0x2F99CF1 VA: 0x2F99BF0
	|-Dictionary<long, object>.ContainsKey
	|
	|-RVA: 0x2F9D250 Offset: 0x2F9D351 VA: 0x2F9D250
	|-Dictionary<Memory<object>, object>.ContainsKey
	|
	|-RVA: 0x2FA08A0 Offset: 0x2FA09A1 VA: 0x2FA08A0
	|-Dictionary<Nullable<Int32Enum>, object>.ContainsKey
	|
	|-RVA: 0x2FA4220 Offset: 0x2FA4321 VA: 0x2FA4220
	|-Dictionary<Nullable<Bounds>, object>.ContainsKey
	|
	|-RVA: 0x2FA8180 Offset: 0x2FA8281 VA: 0x2FA8180
	|-Dictionary<Nullable<BoundsInt>, object>.ContainsKey
	|
	|-RVA: 0x2FABF40 Offset: 0x2FAC041 VA: 0x2FABF40
	|-Dictionary<Nullable<Color32>, object>.ContainsKey
	|
	|-RVA: 0x2FAF850 Offset: 0x2FAF951 VA: 0x2FAF850
	|-Dictionary<Nullable<Color>, object>.ContainsKey
	|
	|-RVA: 0x2F1A860 Offset: 0x2F1A961 VA: 0x2F1A860
	|-Dictionary<Nullable<GradientAlphaKey>, object>.ContainsKey
	|
	|-RVA: 0x2F1E210 Offset: 0x2F1E311 VA: 0x2F1E210
	|-Dictionary<Nullable<GradientColorKey>, object>.ContainsKey
	|
	|-RVA: 0x2F21F10 Offset: 0x2F22011 VA: 0x2F21F10
	|-Dictionary<Nullable<Keyframe>, object>.ContainsKey
	|
	|-RVA: 0x2F25B10 Offset: 0x2F25C11 VA: 0x2F25B10
	|-Dictionary<Nullable<LayerMask>, object>.ContainsKey
	|
	|-RVA: 0x2F295C0 Offset: 0x2F296C1 VA: 0x2F295C0
	|-Dictionary<Nullable<Matrix4x4>, object>.ContainsKey
	|
	|-RVA: 0x2F2D990 Offset: 0x2F2DA91 VA: 0x2F2D990
	|-Dictionary<Nullable<Quaternion>, object>.ContainsKey
	|
	|-RVA: 0x2F315B0 Offset: 0x2F316B1 VA: 0x2F315B0
	|-Dictionary<Nullable<RangeInt>, object>.ContainsKey
	|
	|-RVA: 0x2F34F60 Offset: 0x2F35061 VA: 0x2F34F60
	|-Dictionary<Nullable<Rect>, object>.ContainsKey
	|
	|-RVA: 0x2EFDC70 Offset: 0x2EFDD71 VA: 0x2EFDC70
	|-Dictionary<Nullable<RectInt>, object>.ContainsKey
	|
	|-RVA: 0x2F01890 Offset: 0x2F01991 VA: 0x2F01890
	|-Dictionary<Nullable<Vector2>, object>.ContainsKey
	|
	|-RVA: 0x2F05160 Offset: 0x2F05261 VA: 0x2F05160
	|-Dictionary<Nullable<Vector2Int>, object>.ContainsKey
	|
	|-RVA: 0x2F08A20 Offset: 0x2F08B21 VA: 0x2F08A20
	|-Dictionary<Nullable<Vector3>, object>.ContainsKey
	|
	|-RVA: 0x2F0C260 Offset: 0x2F0C361 VA: 0x2F0C260
	|-Dictionary<Nullable<Vector3Int>, object>.ContainsKey
	|
	|-RVA: 0x2F0FB90 Offset: 0x2F0FC91 VA: 0x2F0FB90
	|-Dictionary<Nullable<Vector4>, object>.ContainsKey
	|
	|-RVA: 0x2F13760 Offset: 0x2F13861 VA: 0x2F13760
	|-Dictionary<object, BitVector32Int>.ContainsKey
	|
	|-RVA: 0x2F16F60 Offset: 0x2F17061 VA: 0x2F16F60
	|-Dictionary<object, EventCheckId>.ContainsKey
	|
	|-RVA: 0x2FF3890 Offset: 0x2FF3991 VA: 0x2FF3890
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.ContainsKey
	|
	|-RVA: 0x2FF7480 Offset: 0x2FF7581 VA: 0x2FF7480
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.ContainsKey
	|
	|-RVA: 0x2FFAD50 Offset: 0x2FFAE51 VA: 0x2FFAD50
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.ContainsKey
	|
	|-RVA: 0x2FFE480 Offset: 0x2FFE581 VA: 0x2FFE480
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.ContainsKey
	|
	|-RVA: 0x3001CF0 Offset: 0x3001DF1 VA: 0x3001CF0
	|-Dictionary<object, MonsterHutSaveData>.ContainsKey
	|
	|-RVA: 0x30056B0 Offset: 0x30057B1 VA: 0x30056B0
	|-Dictionary<object, OrderLotterySaveParameter>.ContainsKey
	|
	|-RVA: 0x3008F60 Offset: 0x3009061 VA: 0x3008F60
	|-Dictionary<object, OrderSaveData>.ContainsKey
	|
	|-RVA: 0x300CA30 Offset: 0x300CB31 VA: 0x300CA30
	|-Dictionary<object, OrderSaveParameter>.ContainsKey
	|
	|-RVA: 0x2DDE1E0 Offset: 0x2DDE2E1 VA: 0x2DDE1E0
	|-Dictionary<object, Parameter>.ContainsKey
	|
	|-RVA: 0x2DE1C60 Offset: 0x2DE1D61 VA: 0x2DE1C60
	|-Dictionary<object, NumberControl.ValueRange>.ContainsKey
	|
	|-RVA: 0x2DE5310 Offset: 0x2DE5411 VA: 0x2DE5310
	|-Dictionary<object, bool>.ContainsKey
	|-Dictionary<string, bool>.ContainsKey
	|-Dictionary<Camera, bool>.ContainsKey
	|
	|-RVA: 0x2DE89E0 Offset: 0x2DE8AE1 VA: 0x2DE89E0
	|-Dictionary<object, byte>.ContainsKey
	|
	|-RVA: 0x2DEC0A0 Offset: 0x2DEC1A1 VA: 0x2DEC0A0
	|-Dictionary<object, char>.ContainsKey
	|
	|-RVA: 0x2DEF760 Offset: 0x2DEF861 VA: 0x2DEF760
	|-Dictionary<object, DateTime>.ContainsKey
	|
	|-RVA: 0x2DF2E10 Offset: 0x2DF2F11 VA: 0x2DF2E10
	|-Dictionary<object, double>.ContainsKey
	|
	|-RVA: 0x2DF64D0 Offset: 0x2DF65D1 VA: 0x2DF64D0
	|-Dictionary<object, short>.ContainsKey
	|
	|-RVA: 0x30B9150 Offset: 0x30B9251 VA: 0x30B9150
	|-Dictionary<object, Int32Enum>.ContainsKey
	|-Dictionary<string, FieldPlaceId>.ContainsKey
	|-Dictionary<string, GameFlagData>.ContainsKey
	|-Dictionary<string, SoundID>.ContainsKey
	|-Dictionary<Event, TextEditor.TextEditOp>.ContainsKey
	|
	|-RVA: 0x30BC810 Offset: 0x30BC911 VA: 0x30BC810
	|-Dictionary<object, long>.ContainsKey
	|
	|-RVA: 0x30BFF00 Offset: 0x30C0001 VA: 0x30BFF00
	|-Dictionary<object, Memory<object>>.ContainsKey
	|
	|-RVA: 0x30C35E0 Offset: 0x30C36E1 VA: 0x30C35E0
	|-Dictionary<object, Nullable<Int32Enum>>.ContainsKey
	|
	|-RVA: 0x30C6F40 Offset: 0x30C7041 VA: 0x30C6F40
	|-Dictionary<object, Nullable<Bounds>>.ContainsKey
	|
	|-RVA: 0x30CABA0 Offset: 0x30CACA1 VA: 0x30CABA0
	|-Dictionary<object, Nullable<BoundsInt>>.ContainsKey
	|
	|-RVA: 0x30CE640 Offset: 0x30CE741 VA: 0x30CE640
	|-Dictionary<object, Nullable<Color32>>.ContainsKey
	|
	|-RVA: 0x30D1F20 Offset: 0x30D2021 VA: 0x30D1F20
	|-Dictionary<object, Nullable<Color>>.ContainsKey
	|
	|-RVA: 0x3010360 Offset: 0x3010461 VA: 0x3010360
	|-Dictionary<object, Nullable<GradientAlphaKey>>.ContainsKey
	|
	|-RVA: 0x3013CB0 Offset: 0x3013DB1 VA: 0x3013CB0
	|-Dictionary<object, Nullable<GradientColorKey>>.ContainsKey
	|
	|-RVA: 0x30177A0 Offset: 0x30178A1 VA: 0x30177A0
	|-Dictionary<object, Nullable<Keyframe>>.ContainsKey
	|
	|-RVA: 0x301B190 Offset: 0x301B291 VA: 0x301B190
	|-Dictionary<object, Nullable<LayerMask>>.ContainsKey
	|
	|-RVA: 0x301EC30 Offset: 0x301ED31 VA: 0x301EC30
	|-Dictionary<object, Nullable<Matrix4x4>>.ContainsKey
	|
	|-RVA: 0x3022A70 Offset: 0x3022B71 VA: 0x3022A70
	|-Dictionary<object, Nullable<Quaternion>>.ContainsKey
	|
	|-RVA: 0x3026470 Offset: 0x3026571 VA: 0x3026470
	|-Dictionary<object, Nullable<RangeInt>>.ContainsKey
	|
	|-RVA: 0x3029DC0 Offset: 0x3029EC1 VA: 0x3029DC0
	|-Dictionary<object, Nullable<Rect>>.ContainsKey
	|
	|-RVA: 0x2FD73A0 Offset: 0x2FD74A1 VA: 0x2FD73A0
	|-Dictionary<object, Nullable<RectInt>>.ContainsKey
	|
	|-RVA: 0x2FDADA0 Offset: 0x2FDAEA1 VA: 0x2FDADA0
	|-Dictionary<object, Nullable<Vector2>>.ContainsKey
	|
	|-RVA: 0x2FDE5F0 Offset: 0x2FDE6F1 VA: 0x2FDE5F0
	|-Dictionary<object, Nullable<Vector2Int>>.ContainsKey
	|
	|-RVA: 0x2FE1E40 Offset: 0x2FE1F41 VA: 0x2FE1E40
	|-Dictionary<object, Nullable<Vector3>>.ContainsKey
	|
	|-RVA: 0x2FE5630 Offset: 0x2FE5731 VA: 0x2FE5630
	|-Dictionary<object, Nullable<Vector3Int>>.ContainsKey
	|
	|-RVA: 0x2FE8F20 Offset: 0x2FE9021 VA: 0x2FE8F20
	|-Dictionary<object, Nullable<Vector4>>.ContainsKey
	|
	|-RVA: 0x2FEFF20 Offset: 0x2FF0021 VA: 0x2FEFF20
	|-Dictionary<object, ReadOnlyMemory<object>>.ContainsKey
	|
	|-RVA: 0x2DBE9D0 Offset: 0x2DBEAD1 VA: 0x2DBE9D0
	|-Dictionary<object, ResourceLocator>.ContainsKey
	|
	|-RVA: 0x2DC20B0 Offset: 0x2DC21B1 VA: 0x2DC20B0
	|-Dictionary<object, sbyte>.ContainsKey
	|
	|-RVA: 0x2DC5770 Offset: 0x2DC5871 VA: 0x2DC5770
	|-Dictionary<object, float>.ContainsKey
	|
	|-RVA: 0x2DC8E30 Offset: 0x2DC8F31 VA: 0x2DC8E30
	|-Dictionary<object, ushort>.ContainsKey
	|
	|-RVA: 0x2DCC4F0 Offset: 0x2DCC5F1 VA: 0x2DCC4F0
	|-Dictionary<object, uint>.ContainsKey
	|
	|-RVA: 0x2DCFBB0 Offset: 0x2DCFCB1 VA: 0x2DCFBB0
	|-Dictionary<object, ulong>.ContainsKey
	|
	|-RVA: 0x2DD6DC0 Offset: 0x2DD6EC1 VA: 0x2DD6DC0
	|-Dictionary<object, Bounds>.ContainsKey
	|
	|-RVA: 0x2DDA780 Offset: 0x2DDA881 VA: 0x2DDA780
	|-Dictionary<object, BoundsInt>.ContainsKey
	|
	|-RVA: 0x30D58E0 Offset: 0x30D59E1 VA: 0x30D58E0
	|-Dictionary<object, Color32>.ContainsKey
	|
	|-RVA: 0x30D8FD0 Offset: 0x30D90D1 VA: 0x30D8FD0
	|-Dictionary<object, Color>.ContainsKey
	|
	|-RVA: 0x30DC6E0 Offset: 0x30DC7E1 VA: 0x30DC6E0
	|-Dictionary<object, GradientAlphaKey>.ContainsKey
	|
	|-RVA: 0x30DFEF0 Offset: 0x30DFFF1 VA: 0x30DFEF0
	|-Dictionary<object, GradientColorKey>.ContainsKey
	|
	|-RVA: 0x30E3940 Offset: 0x30E3A41 VA: 0x30E3940
	|-Dictionary<object, Keyframe>.ContainsKey
	|
	|-RVA: 0x30E72C0 Offset: 0x30E73C1 VA: 0x30E72C0
	|-Dictionary<object, LayerMask>.ContainsKey
	|
	|-RVA: 0x30EABC0 Offset: 0x30EACC1 VA: 0x30EABC0
	|-Dictionary<object, Matrix4x4>.ContainsKey
	|
	|-RVA: 0x30EE670 Offset: 0x30EE771 VA: 0x30EE670
	|-Dictionary<object, Playable>.ContainsKey
	|-Dictionary<TrackAsset, Playable>.ContainsKey
	|
	|-RVA: 0x309D460 Offset: 0x309D561 VA: 0x309D460
	|-Dictionary<object, Quaternion>.ContainsKey
	|
	|-RVA: 0x30A0B50 Offset: 0x30A0C51 VA: 0x30A0B50
	|-Dictionary<object, RangeInt>.ContainsKey
	|
	|-RVA: 0x30A4230 Offset: 0x30A4331 VA: 0x30A4230
	|-Dictionary<object, Rect>.ContainsKey
	|
	|-RVA: 0x30A7960 Offset: 0x30A7A61 VA: 0x30A7960
	|-Dictionary<object, RectInt>.ContainsKey
	|
	|-RVA: 0x30AB150 Offset: 0x30AB251 VA: 0x30AB150
	|-Dictionary<object, AsyncOperationHandle>.ContainsKey
	|
	|-RVA: 0x30AEB20 Offset: 0x30AEC21 VA: 0x30AEB20
	|-Dictionary<object, AsyncOperationHandle<object>>.ContainsKey
	|
	|-RVA: 0x30B23D0 Offset: 0x30B24D1 VA: 0x30B23D0
	|-Dictionary<object, Vector2>.ContainsKey
	|
	|-RVA: 0x30B5AA0 Offset: 0x30B5BA1 VA: 0x30B5AA0
	|-Dictionary<object, Vector2Int>.ContainsKey
	|
	|-RVA: 0x3081760 Offset: 0x3081861 VA: 0x3081760
	|-Dictionary<object, Vector3>.ContainsKey
	|
	|-RVA: 0x3084E80 Offset: 0x3084F81 VA: 0x3084E80
	|-Dictionary<object, Vector3Int>.ContainsKey
	|
	|-RVA: 0x30885A0 Offset: 0x30886A1 VA: 0x30885A0
	|-Dictionary<object, Vector4>.ContainsKey
	|
	|-RVA: 0x308BCD0 Offset: 0x308BDD1 VA: 0x308BCD0
	|-Dictionary<ReadOnlyMemory<object>, object>.ContainsKey
	|
	|-RVA: 0x308F320 Offset: 0x308F421 VA: 0x308F320
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.ContainsKey
	|
	|-RVA: 0x30929B0 Offset: 0x3092AB1 VA: 0x30929B0
	|-Dictionary<sbyte, object>.ContainsKey
	|
	|-RVA: 0x30962E0 Offset: 0x30963E1 VA: 0x30962E0
	|-Dictionary<float, CurveSample>.ContainsKey
	|
	|-RVA: 0x3099E30 Offset: 0x3099F31 VA: 0x3099E30
	|-Dictionary<float, object>.ContainsKey
	|
	|-RVA: 0x319D380 Offset: 0x319D481 VA: 0x319D380
	|-Dictionary<ushort, object>.ContainsKey
	|
	|-RVA: 0x31A3F60 Offset: 0x31A4061 VA: 0x31A3F60
	|-Dictionary<uint, ActorID>.ContainsKey
	|-Dictionary<uint, PartnerMovementOrderType>.ContainsKey
	|-Dictionary<uint, Int32Enum>.ContainsKey
	|
	|-RVA: 0x31A7520 Offset: 0x31A7621 VA: 0x31A7520
	|-Dictionary<uint, FriendMonsterStatus>.ContainsKey
	|-Dictionary<uint, TriangulationConstraint>.ContainsKey
	|-Dictionary<uint, TriangulationPoint>.ContainsKey
	|-Dictionary<uint, SaveDataBase.ReaderFunc>.ContainsKey
	|-Dictionary<uint, object>.ContainsKey
	|-Dictionary<uint, TMP_Character>.ContainsKey
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.ContainsKey
	|-Dictionary<uint, TMP_SpriteCharacter>.ContainsKey
	|-Dictionary<uint, TMP_SpriteGlyph>.ContainsKey
	|-Dictionary<uint, Glyph>.ContainsKey
	|
	|-RVA: 0x31A09A0 Offset: 0x31A0AA1 VA: 0x31A09A0
	|-Dictionary<uint, int>.ContainsKey
	|
	|-RVA: 0x31AAB40 Offset: 0x31AAC41 VA: 0x31AAB40
	|-Dictionary<ulong, object>.ContainsKey
	|
	|-RVA: 0x31AE160 Offset: 0x31AE261 VA: 0x31AE160
	|-Dictionary<EdgeKeyByHash, int>.ContainsKey
	|
	|-RVA: 0x31B19D0 Offset: 0x31B1AD1 VA: 0x31B19D0
	|-Dictionary<EdgeKeyByHash, CapEdge>.ContainsKey
	|
	|-RVA: 0x31B5540 Offset: 0x31B5641 VA: 0x31B5540
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.ContainsKey
	|
	|-RVA: 0x302D8C0 Offset: 0x302D9C1 VA: 0x302D8C0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.ContainsKey
	|
	|-RVA: 0x3031140 Offset: 0x3031241 VA: 0x3031140
	|-Dictionary<MeshDataConnectivity.Face, bool>.ContainsKey
	|
	|-RVA: 0x30347C0 Offset: 0x30348C1 VA: 0x30347C0
	|-Dictionary<MeshDataConnectivity.Face, List<int>>.ContainsKey
	|-Dictionary<MeshDataConnectivity.Face, object>.ContainsKey
	|
	|-RVA: 0x3037F10 Offset: 0x3038011 VA: 0x3037F10
	|-Dictionary<Bounds, object>.ContainsKey
	|
	|-RVA: 0x303BA40 Offset: 0x303BB41 VA: 0x303BA40
	|-Dictionary<BoundsInt, object>.ContainsKey
	|
	|-RVA: 0x303F4A0 Offset: 0x303F5A1 VA: 0x303F4A0
	|-Dictionary<Color, object>.ContainsKey
	|
	|-RVA: 0x3042BB0 Offset: 0x3042CB1 VA: 0x3042BB0
	|-Dictionary<Color32, object>.ContainsKey
	|
	|-RVA: 0x3046200 Offset: 0x3046301 VA: 0x3046200
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.ContainsKey
	|
	|-RVA: 0x3064D70 Offset: 0x3064E71 VA: 0x3064D70
	|-Dictionary<GradientAlphaKey, object>.ContainsKey
	|
	|-RVA: 0x30684E0 Offset: 0x30685E1 VA: 0x30684E0
	|-Dictionary<GradientColorKey, object>.ContainsKey
	|
	|-RVA: 0x306C080 Offset: 0x306C181 VA: 0x306C080
	|-Dictionary<Keyframe, object>.ContainsKey
	|
	|-RVA: 0x306FC70 Offset: 0x306FD71 VA: 0x306FC70
	|-Dictionary<LayerMask, object>.ContainsKey
	|
	|-RVA: 0x30734D0 Offset: 0x30735D1 VA: 0x30734D0
	|-Dictionary<Matrix4x4, object>.ContainsKey
	|
	|-RVA: 0x3077320 Offset: 0x3077421 VA: 0x3077320
	|-Dictionary<IntVec3, object>.ContainsKey
	|
	|-RVA: 0x307AA10 Offset: 0x307AB11 VA: 0x307AA10
	|-Dictionary<Quaternion, object>.ContainsKey
	|
	|-RVA: 0x307E110 Offset: 0x307E211 VA: 0x307E110
	|-Dictionary<RangeInt, object>.ContainsKey
	|
	|-RVA: 0x3049880 Offset: 0x3049981 VA: 0x3049880
	|-Dictionary<Rect, object>.ContainsKey
	|
	|-RVA: 0x304CFC0 Offset: 0x304D0C1 VA: 0x304CFC0
	|-Dictionary<RectInt, object>.ContainsKey
	|
	|-RVA: 0x3050600 Offset: 0x3050701 VA: 0x3050600
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.ContainsKey
	|
	|-RVA: 0x3053C70 Offset: 0x3053D71 VA: 0x3053C70
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.ContainsKey
	|
	|-RVA: 0x30572D0 Offset: 0x30573D1 VA: 0x30572D0
	|-Dictionary<Vector2, object>.ContainsKey
	|
	|-RVA: 0x305A910 Offset: 0x305AA11 VA: 0x305A910
	|-Dictionary<Vector2Int, object>.ContainsKey
	|
	|-RVA: 0x305DF90 Offset: 0x305E091 VA: 0x305DF90
	|-Dictionary<Vector3, List<int>>.ContainsKey
	|-Dictionary<Vector3, object>.ContainsKey
	|
	|-RVA: 0x3061670 Offset: 0x3061771 VA: 0x3061670
	|-Dictionary<Vector3Int, object>.ContainsKey
	|
	|-RVA: 0x2E3B070 Offset: 0x2E3B171 VA: 0x2E3B070
	|-Dictionary<Vector4, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16A40 Offset: 0x2A16B41 VA: 0x2A16A40
	|-Dictionary<JSONDeserialization.TaskField, object>.ContainsValue
	|
	|-RVA: 0x2A1A0A0 Offset: 0x2A1A1A1 VA: 0x2A1A0A0
	|-Dictionary<BitVector32Int, object>.ContainsValue
	|
	|-RVA: 0x2E2A150 Offset: 0x2E2A251 VA: 0x2E2A150
	|-Dictionary<MakingID, CalendarDataTable.FestivalId>.ContainsValue
	|-Dictionary<Int32Enum, Int32Enum>.ContainsValue
	|
	|-RVA: 0x2F78F50 Offset: 0x2F79051 VA: 0x2F78F50
	|-Dictionary<EventCheckId, object>.ContainsValue
	|
	|-RVA: 0x2F7CBD0 Offset: 0x2F7CCD1 VA: 0x2F7CBD0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.ContainsValue
	|
	|-RVA: 0x2F80B50 Offset: 0x2F80C51 VA: 0x2F80B50
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.ContainsValue
	|
	|-RVA: 0x2F84570 Offset: 0x2F84671 VA: 0x2F84570
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.ContainsValue
	|
	|-RVA: 0x2F87C70 Offset: 0x2F87D71 VA: 0x2F87C70
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.ContainsValue
	|
	|-RVA: 0x2F8B490 Offset: 0x2F8B591 VA: 0x2F8B490
	|-Dictionary<MonsterHutSaveData, object>.ContainsValue
	|
	|-RVA: 0x2F8F090 Offset: 0x2F8F191 VA: 0x2F8F090
	|-Dictionary<OrderLotterySaveParameter, object>.ContainsValue
	|
	|-RVA: 0x2F92930 Offset: 0x2F92A31 VA: 0x2F92930
	|-Dictionary<OrderSaveData, object>.ContainsValue
	|
	|-RVA: 0x2D809C0 Offset: 0x2D80AC1 VA: 0x2D809C0
	|-Dictionary<OrderSaveParameter, object>.ContainsValue
	|
	|-RVA: 0x2D845D0 Offset: 0x2D846D1 VA: 0x2D845D0
	|-Dictionary<Parameter, object>.ContainsValue
	|
	|-RVA: 0x2D88150 Offset: 0x2D88251 VA: 0x2D88150
	|-Dictionary<bool, object>.ContainsValue
	|
	|-RVA: 0x2D8B7B0 Offset: 0x2D8B8B1 VA: 0x2D8B7B0
	|-Dictionary<byte, object>.ContainsValue
	|
	|-RVA: 0x2D8EDD0 Offset: 0x2D8EED1 VA: 0x2D8EDD0
	|-Dictionary<char, object>.ContainsValue
	|
	|-RVA: 0x2D923F0 Offset: 0x2D924F1 VA: 0x2D923F0
	|-Dictionary<DateTime, object>.ContainsValue
	|
	|-RVA: 0x2D95A20 Offset: 0x2D95B21 VA: 0x2D95A20
	|-Dictionary<double, object>.ContainsValue
	|
	|-RVA: 0x2D99060 Offset: 0x2D99161 VA: 0x2D99060
	|-Dictionary<Guid, object>.ContainsValue
	|
	|-RVA: 0x2D9C6A0 Offset: 0x2D9C7A1 VA: 0x2D9C6A0
	|-Dictionary<short, object>.ContainsValue
	|
	|-RVA: 0x2D3AA60 Offset: 0x2D3AB61 VA: 0x2D3AA60
	|-Dictionary<int, CropDataTable>.ContainsValue
	|
	|-RVA: 0x2D3E5C0 Offset: 0x2D3E6C1 VA: 0x2D3E5C0
	|-Dictionary<int, EffectDataTable>.ContainsValue
	|
	|-RVA: 0x2D41DE0 Offset: 0x2D41EE1 VA: 0x2D41DE0
	|-Dictionary<int, GimmickLayoutDataTable>.ContainsValue
	|
	|-RVA: 0x2D455F0 Offset: 0x2D456F1 VA: 0x2D455F0
	|-Dictionary<int, MineTypeDataTable>.ContainsValue
	|
	|-RVA: 0x2D490B0 Offset: 0x2D491B1 VA: 0x2D490B0
	|-Dictionary<int, MiningDataTable>.ContainsValue
	|
	|-RVA: 0x2D4C750 Offset: 0x2D4C851 VA: 0x2D4C750
	|-Dictionary<int, bool>.ContainsValue
	|
	|-RVA: 0x2D4FD30 Offset: 0x2D4FE31 VA: 0x2D4FD30
	|-Dictionary<int, char>.ContainsValue
	|
	|-RVA: 0x2D532F0 Offset: 0x2D533F1 VA: 0x2D532F0
	|-Dictionary<int, int>.ContainsValue
	|
	|-RVA: 0x2D568B0 Offset: 0x2D569B1 VA: 0x2D568B0
	|-Dictionary<int, Int32Enum>.ContainsValue
	|
	|-RVA: 0x2F5C9B0 Offset: 0x2F5CAB1 VA: 0x2F5C9B0
	|-Dictionary<int, long>.ContainsValue
	|
	|-RVA: 0x2F60040 Offset: 0x2F60141 VA: 0x2F60040
	|-Dictionary<int, object>.ContainsValue
	|-Dictionary<int, string>.ContainsValue
	|
	|-RVA: 0x2F63820 Offset: 0x2F63921 VA: 0x2F63820
	|-Dictionary<int, DiagnosticEvent>.ContainsValue
	|
	|-RVA: 0x2F671B0 Offset: 0x2F672B1 VA: 0x2F671B0
	|-Dictionary<int, SceneInstance>.ContainsValue
	|
	|-RVA: 0x2F6A860 Offset: 0x2F6A961 VA: 0x2F6A860
	|-Dictionary<int, Vector2Int>.ContainsValue
	|
	|-RVA: 0x2F6DF20 Offset: 0x2F6E021 VA: 0x2F6DF20
	|-Dictionary<int, Vector3>.ContainsValue
	|
	|-RVA: 0x2F71830 Offset: 0x2F71931 VA: 0x2F71830
	|-Dictionary<Int32Enum, MonsterDataTable>.ContainsValue
	|
	|-RVA: 0x2F75490 Offset: 0x2F75591 VA: 0x2F75490
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.ContainsValue
	|
	|-RVA: 0x2E1C850 Offset: 0x2E1C951 VA: 0x2E1C850
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.ContainsValue
	|
	|-RVA: 0x2E1FF30 Offset: 0x2E20031 VA: 0x2E1FF30
	|-Dictionary<Int32Enum, bool>.ContainsValue
	|
	|-RVA: 0x2E23520 Offset: 0x2E23621 VA: 0x2E23520
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.ContainsValue
	|
	|-RVA: 0x2E26B90 Offset: 0x2E26C91 VA: 0x2E26B90
	|-Dictionary<Int32Enum, int>.ContainsValue
	|
	|-RVA: 0x2E2D710 Offset: 0x2E2D811 VA: 0x2E2D710
	|-Dictionary<Int32Enum, object>.ContainsValue
	|
	|-RVA: 0x2E30D30 Offset: 0x2E30E31 VA: 0x2E30D30
	|-Dictionary<Int32Enum, float>.ContainsValue
	|
	|-RVA: 0x2E34320 Offset: 0x2E34421 VA: 0x2E34320
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.ContainsValue
	|
	|-RVA: 0x2E379E0 Offset: 0x2E37AE1 VA: 0x2E379E0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.ContainsValue
	|
	|-RVA: 0x2F96520 Offset: 0x2F96621 VA: 0x2F96520
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.ContainsValue
	|
	|-RVA: 0x2F99C30 Offset: 0x2F99D31 VA: 0x2F99C30
	|-Dictionary<long, object>.ContainsValue
	|
	|-RVA: 0x2F9D290 Offset: 0x2F9D391 VA: 0x2F9D290
	|-Dictionary<Memory<object>, object>.ContainsValue
	|
	|-RVA: 0x2FA08E0 Offset: 0x2FA09E1 VA: 0x2FA08E0
	|-Dictionary<Nullable<Int32Enum>, object>.ContainsValue
	|
	|-RVA: 0x2FA42A0 Offset: 0x2FA43A1 VA: 0x2FA42A0
	|-Dictionary<Nullable<Bounds>, object>.ContainsValue
	|
	|-RVA: 0x2FA8200 Offset: 0x2FA8301 VA: 0x2FA8200
	|-Dictionary<Nullable<BoundsInt>, object>.ContainsValue
	|
	|-RVA: 0x2FABF80 Offset: 0x2FAC081 VA: 0x2FABF80
	|-Dictionary<Nullable<Color32>, object>.ContainsValue
	|
	|-RVA: 0x2FAF8C0 Offset: 0x2FAF9C1 VA: 0x2FAF8C0
	|-Dictionary<Nullable<Color>, object>.ContainsValue
	|
	|-RVA: 0x2F1A8A0 Offset: 0x2F1A9A1 VA: 0x2F1A8A0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.ContainsValue
	|
	|-RVA: 0x2F1E280 Offset: 0x2F1E381 VA: 0x2F1E280
	|-Dictionary<Nullable<GradientColorKey>, object>.ContainsValue
	|
	|-RVA: 0x2F21F80 Offset: 0x2F22081 VA: 0x2F21F80
	|-Dictionary<Nullable<Keyframe>, object>.ContainsValue
	|
	|-RVA: 0x2F25B50 Offset: 0x2F25C51 VA: 0x2F25B50
	|-Dictionary<Nullable<LayerMask>, object>.ContainsValue
	|
	|-RVA: 0x2F29660 Offset: 0x2F29761 VA: 0x2F29660
	|-Dictionary<Nullable<Matrix4x4>, object>.ContainsValue
	|
	|-RVA: 0x2F2DA00 Offset: 0x2F2DB01 VA: 0x2F2DA00
	|-Dictionary<Nullable<Quaternion>, object>.ContainsValue
	|
	|-RVA: 0x2F315F0 Offset: 0x2F316F1 VA: 0x2F315F0
	|-Dictionary<Nullable<RangeInt>, object>.ContainsValue
	|
	|-RVA: 0x2F34FD0 Offset: 0x2F350D1 VA: 0x2F34FD0
	|-Dictionary<Nullable<Rect>, object>.ContainsValue
	|
	|-RVA: 0x2EFDCE0 Offset: 0x2EFDDE1 VA: 0x2EFDCE0
	|-Dictionary<Nullable<RectInt>, object>.ContainsValue
	|
	|-RVA: 0x2F018D0 Offset: 0x2F019D1 VA: 0x2F018D0
	|-Dictionary<Nullable<Vector2>, object>.ContainsValue
	|
	|-RVA: 0x2F051A0 Offset: 0x2F052A1 VA: 0x2F051A0
	|-Dictionary<Nullable<Vector2Int>, object>.ContainsValue
	|
	|-RVA: 0x2F08A60 Offset: 0x2F08B61 VA: 0x2F08A60
	|-Dictionary<Nullable<Vector3>, object>.ContainsValue
	|
	|-RVA: 0x2F0C2A0 Offset: 0x2F0C3A1 VA: 0x2F0C2A0
	|-Dictionary<Nullable<Vector3Int>, object>.ContainsValue
	|
	|-RVA: 0x2F0FC00 Offset: 0x2F0FD01 VA: 0x2F0FC00
	|-Dictionary<Nullable<Vector4>, object>.ContainsValue
	|
	|-RVA: 0x2F137A0 Offset: 0x2F138A1 VA: 0x2F137A0
	|-Dictionary<object, BitVector32Int>.ContainsValue
	|
	|-RVA: 0x2F16FA0 Offset: 0x2F170A1 VA: 0x2F16FA0
	|-Dictionary<object, EventCheckId>.ContainsValue
	|
	|-RVA: 0x2FF38D0 Offset: 0x2FF39D1 VA: 0x2FF38D0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.ContainsValue
	|
	|-RVA: 0x2FF74C0 Offset: 0x2FF75C1 VA: 0x2FF74C0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.ContainsValue
	|
	|-RVA: 0x2FFAD90 Offset: 0x2FFAE91 VA: 0x2FFAD90
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.ContainsValue
	|
	|-RVA: 0x2FFE4C0 Offset: 0x2FFE5C1 VA: 0x2FFE4C0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.ContainsValue
	|
	|-RVA: 0x3001D30 Offset: 0x3001E31 VA: 0x3001D30
	|-Dictionary<object, MonsterHutSaveData>.ContainsValue
	|
	|-RVA: 0x30056F0 Offset: 0x30057F1 VA: 0x30056F0
	|-Dictionary<object, OrderLotterySaveParameter>.ContainsValue
	|
	|-RVA: 0x3008FA0 Offset: 0x30090A1 VA: 0x3008FA0
	|-Dictionary<object, OrderSaveData>.ContainsValue
	|
	|-RVA: 0x300CA70 Offset: 0x300CB71 VA: 0x300CA70
	|-Dictionary<object, OrderSaveParameter>.ContainsValue
	|
	|-RVA: 0x2DDE220 Offset: 0x2DDE321 VA: 0x2DDE220
	|-Dictionary<object, Parameter>.ContainsValue
	|
	|-RVA: 0x2DE1CA0 Offset: 0x2DE1DA1 VA: 0x2DE1CA0
	|-Dictionary<object, NumberControl.ValueRange>.ContainsValue
	|
	|-RVA: 0x2DE5350 Offset: 0x2DE5451 VA: 0x2DE5350
	|-Dictionary<object, bool>.ContainsValue
	|
	|-RVA: 0x2DE8A20 Offset: 0x2DE8B21 VA: 0x2DE8A20
	|-Dictionary<object, byte>.ContainsValue
	|
	|-RVA: 0x2DEC0E0 Offset: 0x2DEC1E1 VA: 0x2DEC0E0
	|-Dictionary<object, char>.ContainsValue
	|
	|-RVA: 0x2DEF7A0 Offset: 0x2DEF8A1 VA: 0x2DEF7A0
	|-Dictionary<object, DateTime>.ContainsValue
	|
	|-RVA: 0x2DF2E50 Offset: 0x2DF2F51 VA: 0x2DF2E50
	|-Dictionary<object, double>.ContainsValue
	|
	|-RVA: 0x2DF6510 Offset: 0x2DF6611 VA: 0x2DF6510
	|-Dictionary<object, short>.ContainsValue
	|
	|-RVA: 0x2DF9BD0 Offset: 0x2DF9CD1 VA: 0x2DF9BD0
	|-Dictionary<object, int>.ContainsValue
	|
	|-RVA: 0x30B9190 Offset: 0x30B9291 VA: 0x30B9190
	|-Dictionary<object, Int32Enum>.ContainsValue
	|
	|-RVA: 0x30BC850 Offset: 0x30BC951 VA: 0x30BC850
	|-Dictionary<object, long>.ContainsValue
	|
	|-RVA: 0x30BFF40 Offset: 0x30C0041 VA: 0x30BFF40
	|-Dictionary<object, Memory<object>>.ContainsValue
	|
	|-RVA: 0x30C3620 Offset: 0x30C3721 VA: 0x30C3620
	|-Dictionary<object, Nullable<Int32Enum>>.ContainsValue
	|
	|-RVA: 0x30C6F80 Offset: 0x30C7081 VA: 0x30C6F80
	|-Dictionary<object, Nullable<Bounds>>.ContainsValue
	|
	|-RVA: 0x30CABE0 Offset: 0x30CACE1 VA: 0x30CABE0
	|-Dictionary<object, Nullable<BoundsInt>>.ContainsValue
	|
	|-RVA: 0x30CE680 Offset: 0x30CE781 VA: 0x30CE680
	|-Dictionary<object, Nullable<Color32>>.ContainsValue
	|
	|-RVA: 0x30D1F60 Offset: 0x30D2061 VA: 0x30D1F60
	|-Dictionary<object, Nullable<Color>>.ContainsValue
	|
	|-RVA: 0x30103A0 Offset: 0x30104A1 VA: 0x30103A0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.ContainsValue
	|
	|-RVA: 0x3013CF0 Offset: 0x3013DF1 VA: 0x3013CF0
	|-Dictionary<object, Nullable<GradientColorKey>>.ContainsValue
	|
	|-RVA: 0x30177E0 Offset: 0x30178E1 VA: 0x30177E0
	|-Dictionary<object, Nullable<Keyframe>>.ContainsValue
	|
	|-RVA: 0x301B1D0 Offset: 0x301B2D1 VA: 0x301B1D0
	|-Dictionary<object, Nullable<LayerMask>>.ContainsValue
	|
	|-RVA: 0x301EC70 Offset: 0x301ED71 VA: 0x301EC70
	|-Dictionary<object, Nullable<Matrix4x4>>.ContainsValue
	|
	|-RVA: 0x3022AB0 Offset: 0x3022BB1 VA: 0x3022AB0
	|-Dictionary<object, Nullable<Quaternion>>.ContainsValue
	|
	|-RVA: 0x30264B0 Offset: 0x30265B1 VA: 0x30264B0
	|-Dictionary<object, Nullable<RangeInt>>.ContainsValue
	|
	|-RVA: 0x3029E00 Offset: 0x3029F01 VA: 0x3029E00
	|-Dictionary<object, Nullable<Rect>>.ContainsValue
	|
	|-RVA: 0x2FD73E0 Offset: 0x2FD74E1 VA: 0x2FD73E0
	|-Dictionary<object, Nullable<RectInt>>.ContainsValue
	|
	|-RVA: 0x2FDADE0 Offset: 0x2FDAEE1 VA: 0x2FDADE0
	|-Dictionary<object, Nullable<Vector2>>.ContainsValue
	|
	|-RVA: 0x2FDE630 Offset: 0x2FDE731 VA: 0x2FDE630
	|-Dictionary<object, Nullable<Vector2Int>>.ContainsValue
	|
	|-RVA: 0x2FE1E80 Offset: 0x2FE1F81 VA: 0x2FE1E80
	|-Dictionary<object, Nullable<Vector3>>.ContainsValue
	|
	|-RVA: 0x2FE5670 Offset: 0x2FE5771 VA: 0x2FE5670
	|-Dictionary<object, Nullable<Vector3Int>>.ContainsValue
	|
	|-RVA: 0x2FE8F60 Offset: 0x2FE9061 VA: 0x2FE8F60
	|-Dictionary<object, Nullable<Vector4>>.ContainsValue
	|
	|-RVA: 0x2FEC920 Offset: 0x2FECA21 VA: 0x2FEC920
	|-Dictionary<object, object>.ContainsValue
	|-Dictionary<string, ResourceSet>.ContainsValue
	|
	|-RVA: 0x2FEFF60 Offset: 0x2FF0061 VA: 0x2FEFF60
	|-Dictionary<object, ReadOnlyMemory<object>>.ContainsValue
	|
	|-RVA: 0x2DBEA10 Offset: 0x2DBEB11 VA: 0x2DBEA10
	|-Dictionary<object, ResourceLocator>.ContainsValue
	|
	|-RVA: 0x2DC20F0 Offset: 0x2DC21F1 VA: 0x2DC20F0
	|-Dictionary<object, sbyte>.ContainsValue
	|
	|-RVA: 0x2DC57B0 Offset: 0x2DC58B1 VA: 0x2DC57B0
	|-Dictionary<object, float>.ContainsValue
	|
	|-RVA: 0x2DC8E70 Offset: 0x2DC8F71 VA: 0x2DC8E70
	|-Dictionary<object, ushort>.ContainsValue
	|
	|-RVA: 0x2DCC530 Offset: 0x2DCC631 VA: 0x2DCC530
	|-Dictionary<object, uint>.ContainsValue
	|
	|-RVA: 0x2DCFBF0 Offset: 0x2DCFCF1 VA: 0x2DCFBF0
	|-Dictionary<object, ulong>.ContainsValue
	|
	|-RVA: 0x2DD33E0 Offset: 0x2DD34E1 VA: 0x2DD33E0
	|-Dictionary<object, TransitionTables>.ContainsValue
	|
	|-RVA: 0x2DD6E00 Offset: 0x2DD6F01 VA: 0x2DD6E00
	|-Dictionary<object, Bounds>.ContainsValue
	|
	|-RVA: 0x2DDA7C0 Offset: 0x2DDA8C1 VA: 0x2DDA7C0
	|-Dictionary<object, BoundsInt>.ContainsValue
	|
	|-RVA: 0x30D5920 Offset: 0x30D5A21 VA: 0x30D5920
	|-Dictionary<object, Color32>.ContainsValue
	|
	|-RVA: 0x30D9010 Offset: 0x30D9111 VA: 0x30D9010
	|-Dictionary<object, Color>.ContainsValue
	|
	|-RVA: 0x30DC720 Offset: 0x30DC821 VA: 0x30DC720
	|-Dictionary<object, GradientAlphaKey>.ContainsValue
	|
	|-RVA: 0x30DFF30 Offset: 0x30E0031 VA: 0x30DFF30
	|-Dictionary<object, GradientColorKey>.ContainsValue
	|
	|-RVA: 0x30E3980 Offset: 0x30E3A81 VA: 0x30E3980
	|-Dictionary<object, Keyframe>.ContainsValue
	|
	|-RVA: 0x30E7300 Offset: 0x30E7401 VA: 0x30E7300
	|-Dictionary<object, LayerMask>.ContainsValue
	|
	|-RVA: 0x30EAC00 Offset: 0x30EAD01 VA: 0x30EAC00
	|-Dictionary<object, Matrix4x4>.ContainsValue
	|
	|-RVA: 0x30EE6B0 Offset: 0x30EE7B1 VA: 0x30EE6B0
	|-Dictionary<object, Playable>.ContainsValue
	|
	|-RVA: 0x309D4A0 Offset: 0x309D5A1 VA: 0x309D4A0
	|-Dictionary<object, Quaternion>.ContainsValue
	|
	|-RVA: 0x30A0B90 Offset: 0x30A0C91 VA: 0x30A0B90
	|-Dictionary<object, RangeInt>.ContainsValue
	|
	|-RVA: 0x30A4270 Offset: 0x30A4371 VA: 0x30A4270
	|-Dictionary<object, Rect>.ContainsValue
	|
	|-RVA: 0x30A79A0 Offset: 0x30A7AA1 VA: 0x30A79A0
	|-Dictionary<object, RectInt>.ContainsValue
	|
	|-RVA: 0x30AB190 Offset: 0x30AB291 VA: 0x30AB190
	|-Dictionary<object, AsyncOperationHandle>.ContainsValue
	|
	|-RVA: 0x30AEB60 Offset: 0x30AEC61 VA: 0x30AEB60
	|-Dictionary<object, AsyncOperationHandle<object>>.ContainsValue
	|
	|-RVA: 0x30B2410 Offset: 0x30B2511 VA: 0x30B2410
	|-Dictionary<object, Vector2>.ContainsValue
	|
	|-RVA: 0x30B5AE0 Offset: 0x30B5BE1 VA: 0x30B5AE0
	|-Dictionary<object, Vector2Int>.ContainsValue
	|
	|-RVA: 0x30817A0 Offset: 0x30818A1 VA: 0x30817A0
	|-Dictionary<object, Vector3>.ContainsValue
	|
	|-RVA: 0x3084EC0 Offset: 0x3084FC1 VA: 0x3084EC0
	|-Dictionary<object, Vector3Int>.ContainsValue
	|
	|-RVA: 0x30885E0 Offset: 0x30886E1 VA: 0x30885E0
	|-Dictionary<object, Vector4>.ContainsValue
	|
	|-RVA: 0x308BD10 Offset: 0x308BE11 VA: 0x308BD10
	|-Dictionary<ReadOnlyMemory<object>, object>.ContainsValue
	|
	|-RVA: 0x308F360 Offset: 0x308F461 VA: 0x308F360
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.ContainsValue
	|
	|-RVA: 0x30929F0 Offset: 0x3092AF1 VA: 0x30929F0
	|-Dictionary<sbyte, object>.ContainsValue
	|
	|-RVA: 0x3096320 Offset: 0x3096421 VA: 0x3096320
	|-Dictionary<float, CurveSample>.ContainsValue
	|
	|-RVA: 0x3099E70 Offset: 0x3099F71 VA: 0x3099E70
	|-Dictionary<float, object>.ContainsValue
	|
	|-RVA: 0x319D3C0 Offset: 0x319D4C1 VA: 0x319D3C0
	|-Dictionary<ushort, object>.ContainsValue
	|
	|-RVA: 0x31A09E0 Offset: 0x31A0AE1 VA: 0x31A09E0
	|-Dictionary<uint, int>.ContainsValue
	|
	|-RVA: 0x31A3FA0 Offset: 0x31A40A1 VA: 0x31A3FA0
	|-Dictionary<uint, Int32Enum>.ContainsValue
	|
	|-RVA: 0x31A7560 Offset: 0x31A7661 VA: 0x31A7560
	|-Dictionary<uint, object>.ContainsValue
	|
	|-RVA: 0x31AAB80 Offset: 0x31AAC81 VA: 0x31AAB80
	|-Dictionary<ulong, object>.ContainsValue
	|
	|-RVA: 0x31AE1A0 Offset: 0x31AE2A1 VA: 0x31AE1A0
	|-Dictionary<EdgeKeyByHash, int>.ContainsValue
	|
	|-RVA: 0x31B1A10 Offset: 0x31B1B11 VA: 0x31B1A10
	|-Dictionary<EdgeKeyByHash, CapEdge>.ContainsValue
	|
	|-RVA: 0x31B5580 Offset: 0x31B5681 VA: 0x31B5580
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.ContainsValue
	|
	|-RVA: 0x302D900 Offset: 0x302DA01 VA: 0x302D900
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.ContainsValue
	|
	|-RVA: 0x3031180 Offset: 0x3031281 VA: 0x3031180
	|-Dictionary<MeshDataConnectivity.Face, bool>.ContainsValue
	|
	|-RVA: 0x3034800 Offset: 0x3034901 VA: 0x3034800
	|-Dictionary<MeshDataConnectivity.Face, object>.ContainsValue
	|
	|-RVA: 0x3037F80 Offset: 0x3038081 VA: 0x3037F80
	|-Dictionary<Bounds, object>.ContainsValue
	|
	|-RVA: 0x303BAB0 Offset: 0x303BBB1 VA: 0x303BAB0
	|-Dictionary<BoundsInt, object>.ContainsValue
	|
	|-RVA: 0x303F4E0 Offset: 0x303F5E1 VA: 0x303F4E0
	|-Dictionary<Color, object>.ContainsValue
	|
	|-RVA: 0x3042BF0 Offset: 0x3042CF1 VA: 0x3042BF0
	|-Dictionary<Color32, object>.ContainsValue
	|
	|-RVA: 0x3046240 Offset: 0x3046341 VA: 0x3046240
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.ContainsValue
	|
	|-RVA: 0x3064DB0 Offset: 0x3064EB1 VA: 0x3064DB0
	|-Dictionary<GradientAlphaKey, object>.ContainsValue
	|
	|-RVA: 0x3068550 Offset: 0x3068651 VA: 0x3068550
	|-Dictionary<GradientColorKey, object>.ContainsValue
	|
	|-RVA: 0x306C100 Offset: 0x306C201 VA: 0x306C100
	|-Dictionary<Keyframe, object>.ContainsValue
	|
	|-RVA: 0x306FCB0 Offset: 0x306FDB1 VA: 0x306FCB0
	|-Dictionary<LayerMask, object>.ContainsValue
	|
	|-RVA: 0x3073560 Offset: 0x3073661 VA: 0x3073560
	|-Dictionary<Matrix4x4, object>.ContainsValue
	|
	|-RVA: 0x3077360 Offset: 0x3077461 VA: 0x3077360
	|-Dictionary<IntVec3, object>.ContainsValue
	|
	|-RVA: 0x307AA50 Offset: 0x307AB51 VA: 0x307AA50
	|-Dictionary<Quaternion, object>.ContainsValue
	|
	|-RVA: 0x307E150 Offset: 0x307E251 VA: 0x307E150
	|-Dictionary<RangeInt, object>.ContainsValue
	|
	|-RVA: 0x30498C0 Offset: 0x30499C1 VA: 0x30498C0
	|-Dictionary<Rect, object>.ContainsValue
	|
	|-RVA: 0x304D000 Offset: 0x304D101 VA: 0x304D000
	|-Dictionary<RectInt, object>.ContainsValue
	|
	|-RVA: 0x3050640 Offset: 0x3050741 VA: 0x3050640
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.ContainsValue
	|
	|-RVA: 0x3053CB0 Offset: 0x3053DB1 VA: 0x3053CB0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.ContainsValue
	|
	|-RVA: 0x3057310 Offset: 0x3057411 VA: 0x3057310
	|-Dictionary<Vector2, object>.ContainsValue
	|
	|-RVA: 0x305A950 Offset: 0x305AA51 VA: 0x305A950
	|-Dictionary<Vector2Int, object>.ContainsValue
	|
	|-RVA: 0x305DFD0 Offset: 0x305E0D1 VA: 0x305DFD0
	|-Dictionary<Vector3, object>.ContainsValue
	|
	|-RVA: 0x30616B0 Offset: 0x30617B1 VA: 0x30616B0
	|-Dictionary<Vector3Int, object>.ContainsValue
	|
	|-RVA: 0x2E3B0B0 Offset: 0x2E3B1B1 VA: 0x2E3B0B0
	|-Dictionary<Vector4, object>.ContainsValue
	*/

	// RVA: -1 Offset: -1
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16BA0 Offset: 0x2A16CA1 VA: 0x2A16BA0
	|-Dictionary<JSONDeserialization.TaskField, object>.CopyTo
	|
	|-RVA: 0x2A1A200 Offset: 0x2A1A301 VA: 0x2A1A200
	|-Dictionary<BitVector32Int, object>.CopyTo
	|
	|-RVA: 0x2F790B0 Offset: 0x2F791B1 VA: 0x2F790B0
	|-Dictionary<EventCheckId, object>.CopyTo
	|
	|-RVA: 0x2F7CD30 Offset: 0x2F7CE31 VA: 0x2F7CD30
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.CopyTo
	|
	|-RVA: 0x2F80CB0 Offset: 0x2F80DB1 VA: 0x2F80CB0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.CopyTo
	|
	|-RVA: 0x2F846D0 Offset: 0x2F847D1 VA: 0x2F846D0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.CopyTo
	|
	|-RVA: 0x2F87DD0 Offset: 0x2F87ED1 VA: 0x2F87DD0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.CopyTo
	|
	|-RVA: 0x2F8B5F0 Offset: 0x2F8B6F1 VA: 0x2F8B5F0
	|-Dictionary<MonsterHutSaveData, object>.CopyTo
	|
	|-RVA: 0x2F8F1F0 Offset: 0x2F8F2F1 VA: 0x2F8F1F0
	|-Dictionary<OrderLotterySaveParameter, object>.CopyTo
	|
	|-RVA: 0x2F92A90 Offset: 0x2F92B91 VA: 0x2F92A90
	|-Dictionary<OrderSaveData, object>.CopyTo
	|
	|-RVA: 0x2D80B20 Offset: 0x2D80C21 VA: 0x2D80B20
	|-Dictionary<OrderSaveParameter, object>.CopyTo
	|
	|-RVA: 0x2D84730 Offset: 0x2D84831 VA: 0x2D84730
	|-Dictionary<Parameter, object>.CopyTo
	|
	|-RVA: 0x2D882B0 Offset: 0x2D883B1 VA: 0x2D882B0
	|-Dictionary<bool, object>.CopyTo
	|
	|-RVA: 0x2D8B910 Offset: 0x2D8BA11 VA: 0x2D8B910
	|-Dictionary<byte, object>.CopyTo
	|
	|-RVA: 0x2D8EF30 Offset: 0x2D8F031 VA: 0x2D8EF30
	|-Dictionary<char, object>.CopyTo
	|
	|-RVA: 0x2D92550 Offset: 0x2D92651 VA: 0x2D92550
	|-Dictionary<DateTime, object>.CopyTo
	|
	|-RVA: 0x2D95B80 Offset: 0x2D95C81 VA: 0x2D95B80
	|-Dictionary<double, object>.CopyTo
	|
	|-RVA: 0x2D991C0 Offset: 0x2D992C1 VA: 0x2D991C0
	|-Dictionary<Guid, object>.CopyTo
	|
	|-RVA: 0x2D9C800 Offset: 0x2D9C901 VA: 0x2D9C800
	|-Dictionary<short, object>.CopyTo
	|
	|-RVA: 0x2D3ABC0 Offset: 0x2D3ACC1 VA: 0x2D3ABC0
	|-Dictionary<int, CropDataTable>.CopyTo
	|
	|-RVA: 0x2D3E720 Offset: 0x2D3E821 VA: 0x2D3E720
	|-Dictionary<int, EffectDataTable>.CopyTo
	|
	|-RVA: 0x2D41EF0 Offset: 0x2D41FF1 VA: 0x2D41EF0
	|-Dictionary<int, GimmickLayoutDataTable>.CopyTo
	|
	|-RVA: 0x2D45780 Offset: 0x2D45881 VA: 0x2D45780
	|-Dictionary<int, MineTypeDataTable>.CopyTo
	|
	|-RVA: 0x2D491C0 Offset: 0x2D492C1 VA: 0x2D491C0
	|-Dictionary<int, MiningDataTable>.CopyTo
	|
	|-RVA: 0x2D4C860 Offset: 0x2D4C961 VA: 0x2D4C860
	|-Dictionary<int, bool>.CopyTo
	|
	|-RVA: 0x2D4FE30 Offset: 0x2D4FF31 VA: 0x2D4FE30
	|-Dictionary<int, char>.CopyTo
	|
	|-RVA: 0x2D533F0 Offset: 0x2D534F1 VA: 0x2D533F0
	|-Dictionary<int, int>.CopyTo
	|
	|-RVA: 0x2D569B0 Offset: 0x2D56AB1 VA: 0x2D569B0
	|-Dictionary<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x2F5CAC0 Offset: 0x2F5CBC1 VA: 0x2F5CAC0
	|-Dictionary<int, long>.CopyTo
	|
	|-RVA: 0x2F601A0 Offset: 0x2F602A1 VA: 0x2F601A0
	|-Dictionary<int, object>.CopyTo
	|
	|-RVA: 0x2F63990 Offset: 0x2F63A91 VA: 0x2F63990
	|-Dictionary<int, DiagnosticEvent>.CopyTo
	|
	|-RVA: 0x2F672C0 Offset: 0x2F673C1 VA: 0x2F672C0
	|-Dictionary<int, SceneInstance>.CopyTo
	|
	|-RVA: 0x2F6A970 Offset: 0x2F6AA71 VA: 0x2F6A970
	|-Dictionary<int, Vector2Int>.CopyTo
	|
	|-RVA: 0x2F6E040 Offset: 0x2F6E141 VA: 0x2F6E040
	|-Dictionary<int, Vector3>.CopyTo
	|
	|-RVA: 0x2F719A0 Offset: 0x2F71AA1 VA: 0x2F719A0
	|-Dictionary<Int32Enum, MonsterDataTable>.CopyTo
	|
	|-RVA: 0x2F75600 Offset: 0x2F75701 VA: 0x2F75600
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.CopyTo
	|
	|-RVA: 0x2E1C960 Offset: 0x2E1CA61 VA: 0x2E1C960
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.CopyTo
	|
	|-RVA: 0x2E20040 Offset: 0x2E20141 VA: 0x2E20040
	|-Dictionary<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x2E23630 Offset: 0x2E23731 VA: 0x2E23630
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x2E26C90 Offset: 0x2E26D91 VA: 0x2E26C90
	|-Dictionary<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x2E2A250 Offset: 0x2E2A351 VA: 0x2E2A250
	|-Dictionary<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x2E2D870 Offset: 0x2E2D971 VA: 0x2E2D870
	|-Dictionary<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x2E30E30 Offset: 0x2E30F31 VA: 0x2E30E30
	|-Dictionary<Int32Enum, float>.CopyTo
	|
	|-RVA: 0x2E34430 Offset: 0x2E34531 VA: 0x2E34430
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x2E37AF0 Offset: 0x2E37BF1 VA: 0x2E37AF0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.CopyTo
	|
	|-RVA: 0x2F96640 Offset: 0x2F96741 VA: 0x2F96640
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.CopyTo
	|
	|-RVA: 0x2F99D90 Offset: 0x2F99E91 VA: 0x2F99D90
	|-Dictionary<long, object>.CopyTo
	|
	|-RVA: 0x2F9D3F0 Offset: 0x2F9D4F1 VA: 0x2F9D3F0
	|-Dictionary<Memory<object>, object>.CopyTo
	|
	|-RVA: 0x2FA0A40 Offset: 0x2FA0B41 VA: 0x2FA0A40
	|-Dictionary<Nullable<Int32Enum>, object>.CopyTo
	|
	|-RVA: 0x2FA4400 Offset: 0x2FA4501 VA: 0x2FA4400
	|-Dictionary<Nullable<Bounds>, object>.CopyTo
	|
	|-RVA: 0x2FA8360 Offset: 0x2FA8461 VA: 0x2FA8360
	|-Dictionary<Nullable<BoundsInt>, object>.CopyTo
	|
	|-RVA: 0x2FAC0E0 Offset: 0x2FAC1E1 VA: 0x2FAC0E0
	|-Dictionary<Nullable<Color32>, object>.CopyTo
	|
	|-RVA: 0x2FAFA20 Offset: 0x2FAFB21 VA: 0x2FAFA20
	|-Dictionary<Nullable<Color>, object>.CopyTo
	|
	|-RVA: 0x2F1AA00 Offset: 0x2F1AB01 VA: 0x2F1AA00
	|-Dictionary<Nullable<GradientAlphaKey>, object>.CopyTo
	|
	|-RVA: 0x2F1E3E0 Offset: 0x2F1E4E1 VA: 0x2F1E3E0
	|-Dictionary<Nullable<GradientColorKey>, object>.CopyTo
	|
	|-RVA: 0x2F220E0 Offset: 0x2F221E1 VA: 0x2F220E0
	|-Dictionary<Nullable<Keyframe>, object>.CopyTo
	|
	|-RVA: 0x2F25CB0 Offset: 0x2F25DB1 VA: 0x2F25CB0
	|-Dictionary<Nullable<LayerMask>, object>.CopyTo
	|
	|-RVA: 0x2F297C0 Offset: 0x2F298C1 VA: 0x2F297C0
	|-Dictionary<Nullable<Matrix4x4>, object>.CopyTo
	|
	|-RVA: 0x2F2DB60 Offset: 0x2F2DC61 VA: 0x2F2DB60
	|-Dictionary<Nullable<Quaternion>, object>.CopyTo
	|
	|-RVA: 0x2F31750 Offset: 0x2F31851 VA: 0x2F31750
	|-Dictionary<Nullable<RangeInt>, object>.CopyTo
	|
	|-RVA: 0x2F35130 Offset: 0x2F35231 VA: 0x2F35130
	|-Dictionary<Nullable<Rect>, object>.CopyTo
	|
	|-RVA: 0x2EFDE40 Offset: 0x2EFDF41 VA: 0x2EFDE40
	|-Dictionary<Nullable<RectInt>, object>.CopyTo
	|
	|-RVA: 0x2F01A30 Offset: 0x2F01B31 VA: 0x2F01A30
	|-Dictionary<Nullable<Vector2>, object>.CopyTo
	|
	|-RVA: 0x2F05300 Offset: 0x2F05401 VA: 0x2F05300
	|-Dictionary<Nullable<Vector2Int>, object>.CopyTo
	|
	|-RVA: 0x2F08BC0 Offset: 0x2F08CC1 VA: 0x2F08BC0
	|-Dictionary<Nullable<Vector3>, object>.CopyTo
	|
	|-RVA: 0x2F0C400 Offset: 0x2F0C501 VA: 0x2F0C400
	|-Dictionary<Nullable<Vector3Int>, object>.CopyTo
	|
	|-RVA: 0x2F0FD60 Offset: 0x2F0FE61 VA: 0x2F0FD60
	|-Dictionary<Nullable<Vector4>, object>.CopyTo
	|
	|-RVA: 0x2F138B0 Offset: 0x2F139B1 VA: 0x2F138B0
	|-Dictionary<object, BitVector32Int>.CopyTo
	|
	|-RVA: 0x2F170F0 Offset: 0x2F171F1 VA: 0x2F170F0
	|-Dictionary<object, EventCheckId>.CopyTo
	|
	|-RVA: 0x2FF3A70 Offset: 0x2FF3B71 VA: 0x2FF3A70
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.CopyTo
	|
	|-RVA: 0x2FF7610 Offset: 0x2FF7711 VA: 0x2FF7610
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.CopyTo
	|
	|-RVA: 0x2FFAEB0 Offset: 0x2FFAFB1 VA: 0x2FFAEB0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.CopyTo
	|
	|-RVA: 0x2FFE5D0 Offset: 0x2FFE6D1 VA: 0x2FFE5D0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.CopyTo
	|
	|-RVA: 0x3001EA0 Offset: 0x3001FA1 VA: 0x3001EA0
	|-Dictionary<object, MonsterHutSaveData>.CopyTo
	|
	|-RVA: 0x3005810 Offset: 0x3005911 VA: 0x3005810
	|-Dictionary<object, OrderLotterySaveParameter>.CopyTo
	|
	|-RVA: 0x3009110 Offset: 0x3009211 VA: 0x3009110
	|-Dictionary<object, OrderSaveData>.CopyTo
	|
	|-RVA: 0x300CBC0 Offset: 0x300CCC1 VA: 0x300CBC0
	|-Dictionary<object, OrderSaveParameter>.CopyTo
	|
	|-RVA: 0x2DDE390 Offset: 0x2DDE491 VA: 0x2DDE390
	|-Dictionary<object, Parameter>.CopyTo
	|
	|-RVA: 0x2DE1DB0 Offset: 0x2DE1EB1 VA: 0x2DE1DB0
	|-Dictionary<object, NumberControl.ValueRange>.CopyTo
	|
	|-RVA: 0x2DE5460 Offset: 0x2DE5561 VA: 0x2DE5460
	|-Dictionary<object, bool>.CopyTo
	|
	|-RVA: 0x2DE8B30 Offset: 0x2DE8C31 VA: 0x2DE8B30
	|-Dictionary<object, byte>.CopyTo
	|
	|-RVA: 0x2DEC1F0 Offset: 0x2DEC2F1 VA: 0x2DEC1F0
	|-Dictionary<object, char>.CopyTo
	|
	|-RVA: 0x2DEF8B0 Offset: 0x2DEF9B1 VA: 0x2DEF8B0
	|-Dictionary<object, DateTime>.CopyTo
	|
	|-RVA: 0x2DF2F60 Offset: 0x2DF3061 VA: 0x2DF2F60
	|-Dictionary<object, double>.CopyTo
	|
	|-RVA: 0x2DF6620 Offset: 0x2DF6721 VA: 0x2DF6620
	|-Dictionary<object, short>.CopyTo
	|
	|-RVA: 0x2DF9CE0 Offset: 0x2DF9DE1 VA: 0x2DF9CE0
	|-Dictionary<object, int>.CopyTo
	|
	|-RVA: 0x30B92A0 Offset: 0x30B93A1 VA: 0x30B92A0
	|-Dictionary<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x30BC960 Offset: 0x30BCA61 VA: 0x30BC960
	|-Dictionary<object, long>.CopyTo
	|
	|-RVA: 0x30C0050 Offset: 0x30C0151 VA: 0x30C0050
	|-Dictionary<object, Memory<object>>.CopyTo
	|
	|-RVA: 0x30C37E0 Offset: 0x30C38E1 VA: 0x30C37E0
	|-Dictionary<object, Nullable<Int32Enum>>.CopyTo
	|
	|-RVA: 0x30C71D0 Offset: 0x30C72D1 VA: 0x30C71D0
	|-Dictionary<object, Nullable<Bounds>>.CopyTo
	|
	|-RVA: 0x30CAE30 Offset: 0x30CAF31 VA: 0x30CAE30
	|-Dictionary<object, Nullable<BoundsInt>>.CopyTo
	|
	|-RVA: 0x30CE840 Offset: 0x30CE941 VA: 0x30CE840
	|-Dictionary<object, Nullable<Color32>>.CopyTo
	|
	|-RVA: 0x30D2180 Offset: 0x30D2281 VA: 0x30D2180
	|-Dictionary<object, Nullable<Color>>.CopyTo
	|
	|-RVA: 0x3010580 Offset: 0x3010681 VA: 0x3010580
	|-Dictionary<object, Nullable<GradientAlphaKey>>.CopyTo
	|
	|-RVA: 0x3013F10 Offset: 0x3014011 VA: 0x3013F10
	|-Dictionary<object, Nullable<GradientColorKey>>.CopyTo
	|
	|-RVA: 0x3017A00 Offset: 0x3017B01 VA: 0x3017A00
	|-Dictionary<object, Nullable<Keyframe>>.CopyTo
	|
	|-RVA: 0x301B390 Offset: 0x301B491 VA: 0x301B390
	|-Dictionary<object, Nullable<LayerMask>>.CopyTo
	|
	|-RVA: 0x301EF30 Offset: 0x301F031 VA: 0x301EF30
	|-Dictionary<object, Nullable<Matrix4x4>>.CopyTo
	|
	|-RVA: 0x3022CD0 Offset: 0x3022DD1 VA: 0x3022CD0
	|-Dictionary<object, Nullable<Quaternion>>.CopyTo
	|
	|-RVA: 0x3026690 Offset: 0x3026791 VA: 0x3026690
	|-Dictionary<object, Nullable<RangeInt>>.CopyTo
	|
	|-RVA: 0x302A020 Offset: 0x302A121 VA: 0x302A020
	|-Dictionary<object, Nullable<Rect>>.CopyTo
	|
	|-RVA: 0x2FD7600 Offset: 0x2FD7701 VA: 0x2FD7600
	|-Dictionary<object, Nullable<RectInt>>.CopyTo
	|
	|-RVA: 0x2FDAFC0 Offset: 0x2FDB0C1 VA: 0x2FDAFC0
	|-Dictionary<object, Nullable<Vector2>>.CopyTo
	|
	|-RVA: 0x2FDE810 Offset: 0x2FDE911 VA: 0x2FDE810
	|-Dictionary<object, Nullable<Vector2Int>>.CopyTo
	|
	|-RVA: 0x2FE2050 Offset: 0x2FE2151 VA: 0x2FE2050
	|-Dictionary<object, Nullable<Vector3>>.CopyTo
	|
	|-RVA: 0x2FE5840 Offset: 0x2FE5941 VA: 0x2FE5840
	|-Dictionary<object, Nullable<Vector3Int>>.CopyTo
	|
	|-RVA: 0x2FE9180 Offset: 0x2FE9281 VA: 0x2FE9180
	|-Dictionary<object, Nullable<Vector4>>.CopyTo
	|
	|-RVA: 0x2FECA80 Offset: 0x2FECB81 VA: 0x2FECA80
	|-Dictionary<object, object>.CopyTo
	|
	|-RVA: 0x2FF0070 Offset: 0x2FF0171 VA: 0x2FF0070
	|-Dictionary<object, ReadOnlyMemory<object>>.CopyTo
	|
	|-RVA: 0x2DBEB20 Offset: 0x2DBEC21 VA: 0x2DBEB20
	|-Dictionary<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x2DC2200 Offset: 0x2DC2301 VA: 0x2DC2200
	|-Dictionary<object, sbyte>.CopyTo
	|
	|-RVA: 0x2DC58C0 Offset: 0x2DC59C1 VA: 0x2DC58C0
	|-Dictionary<object, float>.CopyTo
	|
	|-RVA: 0x2DC8F80 Offset: 0x2DC9081 VA: 0x2DC8F80
	|-Dictionary<object, ushort>.CopyTo
	|
	|-RVA: 0x2DCC640 Offset: 0x2DCC741 VA: 0x2DCC640
	|-Dictionary<object, uint>.CopyTo
	|
	|-RVA: 0x2DCFD00 Offset: 0x2DCFE01 VA: 0x2DCFD00
	|-Dictionary<object, ulong>.CopyTo
	|
	|-RVA: 0x2DD3530 Offset: 0x2DD3631 VA: 0x2DD3530
	|-Dictionary<object, TransitionTables>.CopyTo
	|
	|-RVA: 0x2DD6F50 Offset: 0x2DD7051 VA: 0x2DD6F50
	|-Dictionary<object, Bounds>.CopyTo
	|
	|-RVA: 0x2DDA910 Offset: 0x2DDAA11 VA: 0x2DDA910
	|-Dictionary<object, BoundsInt>.CopyTo
	|
	|-RVA: 0x30D5A30 Offset: 0x30D5B31 VA: 0x30D5A30
	|-Dictionary<object, Color32>.CopyTo
	|
	|-RVA: 0x30D9140 Offset: 0x30D9241 VA: 0x30D9140
	|-Dictionary<object, Color>.CopyTo
	|
	|-RVA: 0x30DC830 Offset: 0x30DC931 VA: 0x30DC830
	|-Dictionary<object, GradientAlphaKey>.CopyTo
	|
	|-RVA: 0x30E0080 Offset: 0x30E0181 VA: 0x30E0080
	|-Dictionary<object, GradientColorKey>.CopyTo
	|
	|-RVA: 0x30E3AF0 Offset: 0x30E3BF1 VA: 0x30E3AF0
	|-Dictionary<object, Keyframe>.CopyTo
	|
	|-RVA: 0x30E7410 Offset: 0x30E7511 VA: 0x30E7410
	|-Dictionary<object, LayerMask>.CopyTo
	|
	|-RVA: 0x30EAD90 Offset: 0x30EAE91 VA: 0x30EAD90
	|-Dictionary<object, Matrix4x4>.CopyTo
	|
	|-RVA: 0x30EE7C0 Offset: 0x30EE8C1 VA: 0x30EE7C0
	|-Dictionary<object, Playable>.CopyTo
	|
	|-RVA: 0x309D5D0 Offset: 0x309D6D1 VA: 0x309D5D0
	|-Dictionary<object, Quaternion>.CopyTo
	|
	|-RVA: 0x30A0CA0 Offset: 0x30A0DA1 VA: 0x30A0CA0
	|-Dictionary<object, RangeInt>.CopyTo
	|
	|-RVA: 0x30A43A0 Offset: 0x30A44A1 VA: 0x30A43A0
	|-Dictionary<object, Rect>.CopyTo
	|
	|-RVA: 0x30A7AB0 Offset: 0x30A7BB1 VA: 0x30A7AB0
	|-Dictionary<object, RectInt>.CopyTo
	|
	|-RVA: 0x30AB2E0 Offset: 0x30AB3E1 VA: 0x30AB2E0
	|-Dictionary<object, AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x30AECB0 Offset: 0x30AEDB1 VA: 0x30AECB0
	|-Dictionary<object, AsyncOperationHandle<object>>.CopyTo
	|
	|-RVA: 0x30B2520 Offset: 0x30B2621 VA: 0x30B2520
	|-Dictionary<object, Vector2>.CopyTo
	|
	|-RVA: 0x30B5BF0 Offset: 0x30B5CF1 VA: 0x30B5BF0
	|-Dictionary<object, Vector2Int>.CopyTo
	|
	|-RVA: 0x30818C0 Offset: 0x30819C1 VA: 0x30818C0
	|-Dictionary<object, Vector3>.CopyTo
	|
	|-RVA: 0x3084FE0 Offset: 0x30850E1 VA: 0x3084FE0
	|-Dictionary<object, Vector3Int>.CopyTo
	|
	|-RVA: 0x3088710 Offset: 0x3088811 VA: 0x3088710
	|-Dictionary<object, Vector4>.CopyTo
	|
	|-RVA: 0x308BE70 Offset: 0x308BF71 VA: 0x308BE70
	|-Dictionary<ReadOnlyMemory<object>, object>.CopyTo
	|
	|-RVA: 0x308F470 Offset: 0x308F571 VA: 0x308F470
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x3092B50 Offset: 0x3092C51 VA: 0x3092B50
	|-Dictionary<sbyte, object>.CopyTo
	|
	|-RVA: 0x30964E0 Offset: 0x30965E1 VA: 0x30964E0
	|-Dictionary<float, CurveSample>.CopyTo
	|
	|-RVA: 0x3099FD0 Offset: 0x309A0D1 VA: 0x3099FD0
	|-Dictionary<float, object>.CopyTo
	|
	|-RVA: 0x319D520 Offset: 0x319D621 VA: 0x319D520
	|-Dictionary<ushort, object>.CopyTo
	|
	|-RVA: 0x31A0AE0 Offset: 0x31A0BE1 VA: 0x31A0AE0
	|-Dictionary<uint, int>.CopyTo
	|
	|-RVA: 0x31A40A0 Offset: 0x31A41A1 VA: 0x31A40A0
	|-Dictionary<uint, Int32Enum>.CopyTo
	|
	|-RVA: 0x31A76C0 Offset: 0x31A77C1 VA: 0x31A76C0
	|-Dictionary<uint, object>.CopyTo
	|
	|-RVA: 0x31AACE0 Offset: 0x31AADE1 VA: 0x31AACE0
	|-Dictionary<ulong, object>.CopyTo
	|
	|-RVA: 0x31AE2B0 Offset: 0x31AE3B1 VA: 0x31AE2B0
	|-Dictionary<EdgeKeyByHash, int>.CopyTo
	|
	|-RVA: 0x31B1B90 Offset: 0x31B1C91 VA: 0x31B1B90
	|-Dictionary<EdgeKeyByHash, CapEdge>.CopyTo
	|
	|-RVA: 0x31B56F0 Offset: 0x31B57F1 VA: 0x31B56F0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.CopyTo
	|
	|-RVA: 0x302DA50 Offset: 0x302DB51 VA: 0x302DA50
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.CopyTo
	|
	|-RVA: 0x3031290 Offset: 0x3031391 VA: 0x3031290
	|-Dictionary<MeshDataConnectivity.Face, bool>.CopyTo
	|
	|-RVA: 0x3034960 Offset: 0x3034A61 VA: 0x3034960
	|-Dictionary<MeshDataConnectivity.Face, object>.CopyTo
	|
	|-RVA: 0x30380E0 Offset: 0x30381E1 VA: 0x30380E0
	|-Dictionary<Bounds, object>.CopyTo
	|
	|-RVA: 0x303BC10 Offset: 0x303BD11 VA: 0x303BC10
	|-Dictionary<BoundsInt, object>.CopyTo
	|
	|-RVA: 0x303F640 Offset: 0x303F741 VA: 0x303F640
	|-Dictionary<Color, object>.CopyTo
	|
	|-RVA: 0x3042D50 Offset: 0x3042E51 VA: 0x3042D50
	|-Dictionary<Color32, object>.CopyTo
	|
	|-RVA: 0x30463A0 Offset: 0x30464A1 VA: 0x30463A0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.CopyTo
	|
	|-RVA: 0x3064F10 Offset: 0x3065011 VA: 0x3064F10
	|-Dictionary<GradientAlphaKey, object>.CopyTo
	|
	|-RVA: 0x30686B0 Offset: 0x30687B1 VA: 0x30686B0
	|-Dictionary<GradientColorKey, object>.CopyTo
	|
	|-RVA: 0x306C260 Offset: 0x306C361 VA: 0x306C260
	|-Dictionary<Keyframe, object>.CopyTo
	|
	|-RVA: 0x306FE10 Offset: 0x306FF11 VA: 0x306FE10
	|-Dictionary<LayerMask, object>.CopyTo
	|
	|-RVA: 0x30736C0 Offset: 0x30737C1 VA: 0x30736C0
	|-Dictionary<Matrix4x4, object>.CopyTo
	|
	|-RVA: 0x30774C0 Offset: 0x30775C1 VA: 0x30774C0
	|-Dictionary<IntVec3, object>.CopyTo
	|
	|-RVA: 0x307ABB0 Offset: 0x307ACB1 VA: 0x307ABB0
	|-Dictionary<Quaternion, object>.CopyTo
	|
	|-RVA: 0x307E2B0 Offset: 0x307E3B1 VA: 0x307E2B0
	|-Dictionary<RangeInt, object>.CopyTo
	|
	|-RVA: 0x3049A20 Offset: 0x3049B21 VA: 0x3049A20
	|-Dictionary<Rect, object>.CopyTo
	|
	|-RVA: 0x304D160 Offset: 0x304D261 VA: 0x304D160
	|-Dictionary<RectInt, object>.CopyTo
	|
	|-RVA: 0x3050750 Offset: 0x3050851 VA: 0x3050750
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.CopyTo
	|
	|-RVA: 0x3053E10 Offset: 0x3053F11 VA: 0x3053E10
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0x3057470 Offset: 0x3057571 VA: 0x3057470
	|-Dictionary<Vector2, object>.CopyTo
	|
	|-RVA: 0x305AAB0 Offset: 0x305ABB1 VA: 0x305AAB0
	|-Dictionary<Vector2Int, object>.CopyTo
	|
	|-RVA: 0x305E130 Offset: 0x305E231 VA: 0x305E130
	|-Dictionary<Vector3, object>.CopyTo
	|
	|-RVA: 0x3061810 Offset: 0x3061911 VA: 0x3061810
	|-Dictionary<Vector3Int, object>.CopyTo
	|
	|-RVA: 0x2E3B210 Offset: 0x2E3B311 VA: 0x2E3B210
	|-Dictionary<Vector4, object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECCA0 Offset: 0x2FECDA1 VA: 0x2FECCA0
	|-Dictionary<SharedVariable, object>.GetEnumerator
	|-Dictionary<CharacterBase, DamageTextController>.GetEnumerator
	|-Dictionary<ICinemachineCamera, object>.GetEnumerator
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.GetEnumerator
	|-Dictionary<OptionDefinition, OptionsControlBase>.GetEnumerator
	|-Dictionary<byte[], Encoding>.GetEnumerator
	|-Dictionary<int[], SceneSplit>.GetEnumerator
	|-Dictionary<int[], Terrain>.GetEnumerator
	|-Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>.GetEnumerator
	|-Dictionary<string, Texture[]>.GetEnumerator
	|-Dictionary<string, InfoBlock>.GetEnumerator
	|-Dictionary<string, SeasonTextureData>.GetEnumerator
	|-Dictionary<string, IList<InfoEntry>>.GetEnumerator
	|-Dictionary<string, List<TaskCoroutine>>.GetEnumerator
	|-Dictionary<string, List<OptionDefinition>>.GetEnumerator
	|-Dictionary<string, object>.GetEnumerator
	|-Dictionary<string, ResourceLocationBase>.GetEnumerator
	|-Dictionary<TimeParamTable, HashSet<ObjectChangeTime>>.GetEnumerator
	|-Dictionary<TimeParamTable, HashSet<RendererChangeTime>>.GetEnumerator
	|-Dictionary<TimeParamTable, HashSet<Material>>.GetEnumerator
	|-Dictionary<Camera, Camera>.GetEnumerator
	|-Dictionary<Collider, CharacterNearCullingController>.GetEnumerator
	|-Dictionary<GameObject, Material[]>.GetEnumerator
	|-Dictionary<GameObject, Renderer[]>.GetEnumerator
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>.GetEnumerator
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.GetEnumerator
	|-Dictionary<Transform, List<SpringBone>>.GetEnumerator
	|-Dictionary<object, object>.GetEnumerator
	|-Dictionary<string, string>.GetEnumerator
	|
	|-RVA: 0x2E2DA90 Offset: 0x2E2DB91 VA: 0x2E2DA90
	|-Dictionary<BadStatus, BadStatusEffectController.ObjInfo>.GetEnumerator
	|-Dictionary<VariationNo, HumanData>.GetEnumerator
	|-Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>>.GetEnumerator
	|-Dictionary<EquipSlotType, AS_ToolController.ToolActionData>.GetEnumerator
	|-Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.GetEnumerator
	|-Dictionary<SoundID, EnvironmentSoundDataTable>.GetEnumerator
	|-Dictionary<SoundID, EnvironmentSoundController>.GetEnumerator
	|-Dictionary<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x2E2A460 Offset: 0x2E2A561 VA: 0x2E2A460
	|-Dictionary<EmotionType, Prefab>.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2DF9F00 Offset: 0x2DFA001 VA: 0x2DF9F00
	|-Dictionary<MonsterControllerBase, int>.GetEnumerator
	|-Dictionary<object, int>.GetEnumerator
	|
	|-RVA: 0x2E34670 Offset: 0x2E34771 VA: 0x2E34670
	|-Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>>.GetEnumerator
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x2F603C0 Offset: 0x2F604C1 VA: 0x2F603C0
	|-Dictionary<int, BossBehaviorController>.GetEnumerator
	|-Dictionary<int, FishSwim>.GetEnumerator
	|-Dictionary<int, HarinezumiController.NeedleController>.GetEnumerator
	|-Dictionary<int, MonsterBehaviorController>.GetEnumerator
	|-Dictionary<int, PartnerNPCBehaviorController>.GetEnumerator
	|-Dictionary<int, List<MeshDataConnectivity.Face>>.GetEnumerator
	|-Dictionary<int, string>.GetEnumerator
	|-Dictionary<int, PointerEventData>.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.GetEnumerator
	|-Dictionary<int, Panel>.GetEnumerator
	|-Dictionary<int, object>.GetEnumerator
	|
	|-RVA: 0x2D53600 Offset: 0x2D53701 VA: 0x2D53600
	|-Dictionary<int, int>.GetEnumerator
	|
	|-RVA: 0x2F6E250 Offset: 0x2F6E351 VA: 0x2F6E250
	|-Dictionary<int, Vector3>.GetEnumerator
	|
	|-RVA: 0x31A78E0 Offset: 0x31A79E1 VA: 0x31A78E0
	|-Dictionary<uint, FarmMonsterBehaviorController>.GetEnumerator
	|-Dictionary<uint, TriangulationConstraint>.GetEnumerator
	|-Dictionary<uint, object>.GetEnumerator
	|
	|-RVA: 0x30314B0 Offset: 0x30315B1 VA: 0x30314B0
	|-Dictionary<MeshDataConnectivity.Face, bool>.GetEnumerator
	|
	|-RVA: 0x3034B80 Offset: 0x3034C81 VA: 0x3034B80
	|-Dictionary<MeshDataConnectivity.Face, List<int>>.GetEnumerator
	|-Dictionary<MeshDataConnectivity.Face, object>.GetEnumerator
	|
	|-RVA: 0x30465C0 Offset: 0x30466C1 VA: 0x30465C0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.GetEnumerator
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.GetEnumerator
	|
	|-RVA: 0x3077700 Offset: 0x3077801 VA: 0x3077700
	|-Dictionary<IntVec3, List<int>>.GetEnumerator
	|-Dictionary<IntVec3, object>.GetEnumerator
	|
	|-RVA: 0x305E370 Offset: 0x305E471 VA: 0x305E370
	|-Dictionary<Vector3, List<int>>.GetEnumerator
	|-Dictionary<Vector3, object>.GetEnumerator
	|
	|-RVA: 0x2A16DE0 Offset: 0x2A16EE1 VA: 0x2A16DE0
	|-Dictionary<JSONDeserialization.TaskField, object>.GetEnumerator
	|
	|-RVA: 0x2A1A420 Offset: 0x2A1A521 VA: 0x2A1A420
	|-Dictionary<BitVector32Int, object>.GetEnumerator
	|
	|-RVA: 0x2F79310 Offset: 0x2F79411 VA: 0x2F79310
	|-Dictionary<EventCheckId, object>.GetEnumerator
	|
	|-RVA: 0x2F7CFE0 Offset: 0x2F7D0E1 VA: 0x2F7CFE0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.GetEnumerator
	|
	|-RVA: 0x2F80F10 Offset: 0x2F81011 VA: 0x2F80F10
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.GetEnumerator
	|
	|-RVA: 0x2F84910 Offset: 0x2F84A11 VA: 0x2F84910
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.GetEnumerator
	|
	|-RVA: 0x2F88010 Offset: 0x2F88111 VA: 0x2F88010
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.GetEnumerator
	|
	|-RVA: 0x2F8B870 Offset: 0x2F8B971 VA: 0x2F8B870
	|-Dictionary<MonsterHutSaveData, object>.GetEnumerator
	|
	|-RVA: 0x2F8F430 Offset: 0x2F8F531 VA: 0x2F8F430
	|-Dictionary<OrderLotterySaveParameter, object>.GetEnumerator
	|
	|-RVA: 0x2F92D10 Offset: 0x2F92E11 VA: 0x2F92D10
	|-Dictionary<OrderSaveData, object>.GetEnumerator
	|
	|-RVA: 0x2D80D90 Offset: 0x2D80E91 VA: 0x2D80D90
	|-Dictionary<OrderSaveParameter, object>.GetEnumerator
	|
	|-RVA: 0x2D849F0 Offset: 0x2D84AF1 VA: 0x2D849F0
	|-Dictionary<Parameter, object>.GetEnumerator
	|
	|-RVA: 0x2D884D0 Offset: 0x2D885D1 VA: 0x2D884D0
	|-Dictionary<bool, object>.GetEnumerator
	|
	|-RVA: 0x2D8BB30 Offset: 0x2D8BC31 VA: 0x2D8BB30
	|-Dictionary<byte, object>.GetEnumerator
	|
	|-RVA: 0x2D8F150 Offset: 0x2D8F251 VA: 0x2D8F150
	|-Dictionary<char, object>.GetEnumerator
	|
	|-RVA: 0x2D92770 Offset: 0x2D92871 VA: 0x2D92770
	|-Dictionary<DateTime, object>.GetEnumerator
	|
	|-RVA: 0x2D95DA0 Offset: 0x2D95EA1 VA: 0x2D95DA0
	|-Dictionary<double, object>.GetEnumerator
	|
	|-RVA: 0x2D99400 Offset: 0x2D99501 VA: 0x2D99400
	|-Dictionary<Guid, object>.GetEnumerator
	|
	|-RVA: 0x2D9CA20 Offset: 0x2D9CB21 VA: 0x2D9CA20
	|-Dictionary<short, object>.GetEnumerator
	|
	|-RVA: 0x2D3AEA0 Offset: 0x2D3AFA1 VA: 0x2D3AEA0
	|-Dictionary<int, CropDataTable>.GetEnumerator
	|
	|-RVA: 0x2D3E970 Offset: 0x2D3EA71 VA: 0x2D3E970
	|-Dictionary<int, EffectDataTable>.GetEnumerator
	|
	|-RVA: 0x2D42100 Offset: 0x2D42201 VA: 0x2D42100
	|-Dictionary<int, GimmickLayoutDataTable>.GetEnumerator
	|
	|-RVA: 0x2D45A40 Offset: 0x2D45B41 VA: 0x2D45A40
	|-Dictionary<int, MineTypeDataTable>.GetEnumerator
	|
	|-RVA: 0x2D49400 Offset: 0x2D49501 VA: 0x2D49400
	|-Dictionary<int, MiningDataTable>.GetEnumerator
	|
	|-RVA: 0x2D4CA70 Offset: 0x2D4CB71 VA: 0x2D4CA70
	|-Dictionary<int, bool>.GetEnumerator
	|
	|-RVA: 0x2D50040 Offset: 0x2D50141 VA: 0x2D50040
	|-Dictionary<int, char>.GetEnumerator
	|
	|-RVA: 0x2D56BC0 Offset: 0x2D56CC1 VA: 0x2D56BC0
	|-Dictionary<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2F5CCD0 Offset: 0x2F5CDD1 VA: 0x2F5CCD0
	|-Dictionary<int, long>.GetEnumerator
	|
	|-RVA: 0x2F63C30 Offset: 0x2F63D31 VA: 0x2F63C30
	|-Dictionary<int, DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x2F67500 Offset: 0x2F67601 VA: 0x2F67500
	|-Dictionary<int, SceneInstance>.GetEnumerator
	|
	|-RVA: 0x2F6AB90 Offset: 0x2F6AC91 VA: 0x2F6AB90
	|-Dictionary<int, Vector2Int>.GetEnumerator
	|
	|-RVA: 0x2F71C60 Offset: 0x2F71D61 VA: 0x2F71C60
	|-Dictionary<Int32Enum, MonsterDataTable>.GetEnumerator
	|
	|-RVA: 0x2F758A0 Offset: 0x2F759A1 VA: 0x2F758A0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.GetEnumerator
	|
	|-RVA: 0x2E1CB90 Offset: 0x2E1CC91 VA: 0x2E1CB90
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.GetEnumerator
	|
	|-RVA: 0x2E20250 Offset: 0x2E20351 VA: 0x2E20250
	|-Dictionary<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x2E23850 Offset: 0x2E23951 VA: 0x2E23850
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x2E26EA0 Offset: 0x2E26FA1 VA: 0x2E26EA0
	|-Dictionary<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x2E31040 Offset: 0x2E31141 VA: 0x2E31040
	|-Dictionary<Int32Enum, float>.GetEnumerator
	|
	|-RVA: 0x2E37D10 Offset: 0x2E37E11 VA: 0x2E37D10
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.GetEnumerator
	|
	|-RVA: 0x2F96850 Offset: 0x2F96951 VA: 0x2F96850
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.GetEnumerator
	|
	|-RVA: 0x2F99FB0 Offset: 0x2F9A0B1 VA: 0x2F99FB0
	|-Dictionary<long, object>.GetEnumerator
	|
	|-RVA: 0x2F9D630 Offset: 0x2F9D731 VA: 0x2F9D630
	|-Dictionary<Memory<object>, object>.GetEnumerator
	|
	|-RVA: 0x2FA0C60 Offset: 0x2FA0D61 VA: 0x2FA0C60
	|-Dictionary<Nullable<Int32Enum>, object>.GetEnumerator
	|
	|-RVA: 0x2FA4680 Offset: 0x2FA4781 VA: 0x2FA4680
	|-Dictionary<Nullable<Bounds>, object>.GetEnumerator
	|
	|-RVA: 0x2FA85E0 Offset: 0x2FA86E1 VA: 0x2FA85E0
	|-Dictionary<Nullable<BoundsInt>, object>.GetEnumerator
	|
	|-RVA: 0x2FAC300 Offset: 0x2FAC401 VA: 0x2FAC300
	|-Dictionary<Nullable<Color32>, object>.GetEnumerator
	|
	|-RVA: 0x2FAFC80 Offset: 0x2FAFD81 VA: 0x2FAFC80
	|-Dictionary<Nullable<Color>, object>.GetEnumerator
	|
	|-RVA: 0x2F1AC40 Offset: 0x2F1AD41 VA: 0x2F1AC40
	|-Dictionary<Nullable<GradientAlphaKey>, object>.GetEnumerator
	|
	|-RVA: 0x2F1E640 Offset: 0x2F1E741 VA: 0x2F1E640
	|-Dictionary<Nullable<GradientColorKey>, object>.GetEnumerator
	|
	|-RVA: 0x2F22350 Offset: 0x2F22451 VA: 0x2F22350
	|-Dictionary<Nullable<Keyframe>, object>.GetEnumerator
	|
	|-RVA: 0x2F25ED0 Offset: 0x2F25FD1 VA: 0x2F25ED0
	|-Dictionary<Nullable<LayerMask>, object>.GetEnumerator
	|
	|-RVA: 0x2F29AA0 Offset: 0x2F29BA1 VA: 0x2F29AA0
	|-Dictionary<Nullable<Matrix4x4>, object>.GetEnumerator
	|
	|-RVA: 0x2F2DDC0 Offset: 0x2F2DEC1 VA: 0x2F2DDC0
	|-Dictionary<Nullable<Quaternion>, object>.GetEnumerator
	|
	|-RVA: 0x2F31990 Offset: 0x2F31A91 VA: 0x2F31990
	|-Dictionary<Nullable<RangeInt>, object>.GetEnumerator
	|
	|-RVA: 0x2F35390 Offset: 0x2F35491 VA: 0x2F35390
	|-Dictionary<Nullable<Rect>, object>.GetEnumerator
	|
	|-RVA: 0x2EFE0A0 Offset: 0x2EFE1A1 VA: 0x2EFE0A0
	|-Dictionary<Nullable<RectInt>, object>.GetEnumerator
	|
	|-RVA: 0x2F01C70 Offset: 0x2F01D71 VA: 0x2F01C70
	|-Dictionary<Nullable<Vector2>, object>.GetEnumerator
	|
	|-RVA: 0x2F05540 Offset: 0x2F05641 VA: 0x2F05540
	|-Dictionary<Nullable<Vector2Int>, object>.GetEnumerator
	|
	|-RVA: 0x2F08E00 Offset: 0x2F08F01 VA: 0x2F08E00
	|-Dictionary<Nullable<Vector3>, object>.GetEnumerator
	|
	|-RVA: 0x2F0C640 Offset: 0x2F0C741 VA: 0x2F0C640
	|-Dictionary<Nullable<Vector3Int>, object>.GetEnumerator
	|
	|-RVA: 0x2F0FFC0 Offset: 0x2F100C1 VA: 0x2F0FFC0
	|-Dictionary<Nullable<Vector4>, object>.GetEnumerator
	|
	|-RVA: 0x2F13AD0 Offset: 0x2F13BD1 VA: 0x2F13AD0
	|-Dictionary<object, BitVector32Int>.GetEnumerator
	|
	|-RVA: 0x2F17340 Offset: 0x2F17441 VA: 0x2F17340
	|-Dictionary<object, EventCheckId>.GetEnumerator
	|
	|-RVA: 0x2FF3D20 Offset: 0x2FF3E21 VA: 0x2FF3D20
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.GetEnumerator
	|
	|-RVA: 0x2FF7870 Offset: 0x2FF7971 VA: 0x2FF7870
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.GetEnumerator
	|
	|-RVA: 0x2FFB0F0 Offset: 0x2FFB1F1 VA: 0x2FFB0F0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.GetEnumerator
	|
	|-RVA: 0x2FFE810 Offset: 0x2FFE911 VA: 0x2FFE810
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.GetEnumerator
	|
	|-RVA: 0x3002120 Offset: 0x3002221 VA: 0x3002120
	|-Dictionary<object, MonsterHutSaveData>.GetEnumerator
	|
	|-RVA: 0x3005A50 Offset: 0x3005B51 VA: 0x3005A50
	|-Dictionary<object, OrderLotterySaveParameter>.GetEnumerator
	|
	|-RVA: 0x3009390 Offset: 0x3009491 VA: 0x3009390
	|-Dictionary<object, OrderSaveData>.GetEnumerator
	|
	|-RVA: 0x300CE30 Offset: 0x300CF31 VA: 0x300CE30
	|-Dictionary<object, OrderSaveParameter>.GetEnumerator
	|
	|-RVA: 0x2DDE650 Offset: 0x2DDE751 VA: 0x2DDE650
	|-Dictionary<object, Parameter>.GetEnumerator
	|
	|-RVA: 0x2DE1FF0 Offset: 0x2DE20F1 VA: 0x2DE1FF0
	|-Dictionary<object, NumberControl.ValueRange>.GetEnumerator
	|
	|-RVA: 0x2DE5680 Offset: 0x2DE5781 VA: 0x2DE5680
	|-Dictionary<object, bool>.GetEnumerator
	|
	|-RVA: 0x2DE8D50 Offset: 0x2DE8E51 VA: 0x2DE8D50
	|-Dictionary<object, byte>.GetEnumerator
	|
	|-RVA: 0x2DEC410 Offset: 0x2DEC511 VA: 0x2DEC410
	|-Dictionary<object, char>.GetEnumerator
	|
	|-RVA: 0x2DEFAD0 Offset: 0x2DEFBD1 VA: 0x2DEFAD0
	|-Dictionary<object, DateTime>.GetEnumerator
	|
	|-RVA: 0x2DF3180 Offset: 0x2DF3281 VA: 0x2DF3180
	|-Dictionary<object, double>.GetEnumerator
	|
	|-RVA: 0x2DF6840 Offset: 0x2DF6941 VA: 0x2DF6840
	|-Dictionary<object, short>.GetEnumerator
	|
	|-RVA: 0x30B94C0 Offset: 0x30B95C1 VA: 0x30B94C0
	|-Dictionary<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x30BCB80 Offset: 0x30BCC81 VA: 0x30BCB80
	|-Dictionary<object, long>.GetEnumerator
	|
	|-RVA: 0x30C0290 Offset: 0x30C0391 VA: 0x30C0290
	|-Dictionary<object, Memory<object>>.GetEnumerator
	|
	|-RVA: 0x30C3A00 Offset: 0x30C3B01 VA: 0x30C3A00
	|-Dictionary<object, Nullable<Int32Enum>>.GetEnumerator
	|
	|-RVA: 0x30C7450 Offset: 0x30C7551 VA: 0x30C7450
	|-Dictionary<object, Nullable<Bounds>>.GetEnumerator
	|
	|-RVA: 0x30CB0B0 Offset: 0x30CB1B1 VA: 0x30CB0B0
	|-Dictionary<object, Nullable<BoundsInt>>.GetEnumerator
	|
	|-RVA: 0x30CEA60 Offset: 0x30CEB61 VA: 0x30CEA60
	|-Dictionary<object, Nullable<Color32>>.GetEnumerator
	|
	|-RVA: 0x30D23E0 Offset: 0x30D24E1 VA: 0x30D23E0
	|-Dictionary<object, Nullable<Color>>.GetEnumerator
	|
	|-RVA: 0x30107C0 Offset: 0x30108C1 VA: 0x30107C0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.GetEnumerator
	|
	|-RVA: 0x3014160 Offset: 0x3014261 VA: 0x3014160
	|-Dictionary<object, Nullable<GradientColorKey>>.GetEnumerator
	|
	|-RVA: 0x3017C70 Offset: 0x3017D71 VA: 0x3017C70
	|-Dictionary<object, Nullable<Keyframe>>.GetEnumerator
	|
	|-RVA: 0x301B5B0 Offset: 0x301B6B1 VA: 0x301B5B0
	|-Dictionary<object, Nullable<LayerMask>>.GetEnumerator
	|
	|-RVA: 0x301F200 Offset: 0x301F301 VA: 0x301F200
	|-Dictionary<object, Nullable<Matrix4x4>>.GetEnumerator
	|
	|-RVA: 0x3022F30 Offset: 0x3023031 VA: 0x3022F30
	|-Dictionary<object, Nullable<Quaternion>>.GetEnumerator
	|
	|-RVA: 0x30268D0 Offset: 0x30269D1 VA: 0x30268D0
	|-Dictionary<object, Nullable<RangeInt>>.GetEnumerator
	|
	|-RVA: 0x302A280 Offset: 0x302A381 VA: 0x302A280
	|-Dictionary<object, Nullable<Rect>>.GetEnumerator
	|
	|-RVA: 0x2FD7860 Offset: 0x2FD7961 VA: 0x2FD7860
	|-Dictionary<object, Nullable<RectInt>>.GetEnumerator
	|
	|-RVA: 0x2FDB200 Offset: 0x2FDB301 VA: 0x2FDB200
	|-Dictionary<object, Nullable<Vector2>>.GetEnumerator
	|
	|-RVA: 0x2FDEA50 Offset: 0x2FDEB51 VA: 0x2FDEA50
	|-Dictionary<object, Nullable<Vector2Int>>.GetEnumerator
	|
	|-RVA: 0x2FE2290 Offset: 0x2FE2391 VA: 0x2FE2290
	|-Dictionary<object, Nullable<Vector3>>.GetEnumerator
	|
	|-RVA: 0x2FE5A80 Offset: 0x2FE5B81 VA: 0x2FE5A80
	|-Dictionary<object, Nullable<Vector3Int>>.GetEnumerator
	|
	|-RVA: 0x2FE93E0 Offset: 0x2FE94E1 VA: 0x2FE93E0
	|-Dictionary<object, Nullable<Vector4>>.GetEnumerator
	|
	|-RVA: 0x2FF02B0 Offset: 0x2FF03B1 VA: 0x2FF02B0
	|-Dictionary<object, ReadOnlyMemory<object>>.GetEnumerator
	|
	|-RVA: 0x2DBED60 Offset: 0x2DBEE61 VA: 0x2DBED60
	|-Dictionary<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x2DC2420 Offset: 0x2DC2521 VA: 0x2DC2420
	|-Dictionary<object, sbyte>.GetEnumerator
	|
	|-RVA: 0x2DC5AE0 Offset: 0x2DC5BE1 VA: 0x2DC5AE0
	|-Dictionary<object, float>.GetEnumerator
	|
	|-RVA: 0x2DC91A0 Offset: 0x2DC92A1 VA: 0x2DC91A0
	|-Dictionary<object, ushort>.GetEnumerator
	|
	|-RVA: 0x2DCC860 Offset: 0x2DCC961 VA: 0x2DCC860
	|-Dictionary<object, uint>.GetEnumerator
	|
	|-RVA: 0x2DCFF20 Offset: 0x2DD0021 VA: 0x2DCFF20
	|-Dictionary<object, ulong>.GetEnumerator
	|
	|-RVA: 0x2DD37A0 Offset: 0x2DD38A1 VA: 0x2DD37A0
	|-Dictionary<object, TransitionTables>.GetEnumerator
	|
	|-RVA: 0x2DD71A0 Offset: 0x2DD72A1 VA: 0x2DD71A0
	|-Dictionary<object, Bounds>.GetEnumerator
	|
	|-RVA: 0x2DDAB60 Offset: 0x2DDAC61 VA: 0x2DDAB60
	|-Dictionary<object, BoundsInt>.GetEnumerator
	|
	|-RVA: 0x30D5C50 Offset: 0x30D5D51 VA: 0x30D5C50
	|-Dictionary<object, Color32>.GetEnumerator
	|
	|-RVA: 0x30D9380 Offset: 0x30D9481 VA: 0x30D9380
	|-Dictionary<object, Color>.GetEnumerator
	|
	|-RVA: 0x30DCA50 Offset: 0x30DCB51 VA: 0x30DCA50
	|-Dictionary<object, GradientAlphaKey>.GetEnumerator
	|
	|-RVA: 0x30E02E0 Offset: 0x30E03E1 VA: 0x30E02E0
	|-Dictionary<object, GradientColorKey>.GetEnumerator
	|
	|-RVA: 0x30E3D70 Offset: 0x30E3E71 VA: 0x30E3D70
	|-Dictionary<object, Keyframe>.GetEnumerator
	|
	|-RVA: 0x30E7630 Offset: 0x30E7731 VA: 0x30E7630
	|-Dictionary<object, LayerMask>.GetEnumerator
	|
	|-RVA: 0x30EB050 Offset: 0x30EB151 VA: 0x30EB050
	|-Dictionary<object, Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x30EEA00 Offset: 0x30EEB01 VA: 0x30EEA00
	|-Dictionary<object, Playable>.GetEnumerator
	|
	|-RVA: 0x309D810 Offset: 0x309D911 VA: 0x309D810
	|-Dictionary<object, Quaternion>.GetEnumerator
	|
	|-RVA: 0x30A0EC0 Offset: 0x30A0FC1 VA: 0x30A0EC0
	|-Dictionary<object, RangeInt>.GetEnumerator
	|
	|-RVA: 0x30A45E0 Offset: 0x30A46E1 VA: 0x30A45E0
	|-Dictionary<object, Rect>.GetEnumerator
	|
	|-RVA: 0x30A7CF0 Offset: 0x30A7DF1 VA: 0x30A7CF0
	|-Dictionary<object, RectInt>.GetEnumerator
	|
	|-RVA: 0x30AB530 Offset: 0x30AB631 VA: 0x30AB530
	|-Dictionary<object, AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x30AEF00 Offset: 0x30AF001 VA: 0x30AEF00
	|-Dictionary<object, AsyncOperationHandle<object>>.GetEnumerator
	|
	|-RVA: 0x30B2740 Offset: 0x30B2841 VA: 0x30B2740
	|-Dictionary<object, Vector2>.GetEnumerator
	|
	|-RVA: 0x30B5E10 Offset: 0x30B5F11 VA: 0x30B5E10
	|-Dictionary<object, Vector2Int>.GetEnumerator
	|
	|-RVA: 0x3081B00 Offset: 0x3081C01 VA: 0x3081B00
	|-Dictionary<object, Vector3>.GetEnumerator
	|
	|-RVA: 0x3085220 Offset: 0x3085321 VA: 0x3085220
	|-Dictionary<object, Vector3Int>.GetEnumerator
	|
	|-RVA: 0x3088950 Offset: 0x3088A51 VA: 0x3088950
	|-Dictionary<object, Vector4>.GetEnumerator
	|
	|-RVA: 0x308C0B0 Offset: 0x308C1B1 VA: 0x308C0B0
	|-Dictionary<ReadOnlyMemory<object>, object>.GetEnumerator
	|
	|-RVA: 0x308F680 Offset: 0x308F781 VA: 0x308F680
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x3092D70 Offset: 0x3092E71 VA: 0x3092D70
	|-Dictionary<sbyte, object>.GetEnumerator
	|
	|-RVA: 0x30967C0 Offset: 0x30968C1 VA: 0x30967C0
	|-Dictionary<float, CurveSample>.GetEnumerator
	|
	|-RVA: 0x309A1F0 Offset: 0x309A2F1 VA: 0x309A1F0
	|-Dictionary<float, object>.GetEnumerator
	|
	|-RVA: 0x319D740 Offset: 0x319D841 VA: 0x319D740
	|-Dictionary<ushort, object>.GetEnumerator
	|
	|-RVA: 0x31A0CF0 Offset: 0x31A0DF1 VA: 0x31A0CF0
	|-Dictionary<uint, int>.GetEnumerator
	|
	|-RVA: 0x31A42B0 Offset: 0x31A43B1 VA: 0x31A42B0
	|-Dictionary<uint, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x31AAF00 Offset: 0x31AB001 VA: 0x31AAF00
	|-Dictionary<ulong, object>.GetEnumerator
	|
	|-RVA: 0x31AE4D0 Offset: 0x31AE5D1 VA: 0x31AE4D0
	|-Dictionary<EdgeKeyByHash, int>.GetEnumerator
	|
	|-RVA: 0x31B1E20 Offset: 0x31B1F21 VA: 0x31B1E20
	|-Dictionary<EdgeKeyByHash, CapEdge>.GetEnumerator
	|
	|-RVA: 0x31B5990 Offset: 0x31B5A91 VA: 0x31B5990
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.GetEnumerator
	|
	|-RVA: 0x302DCB0 Offset: 0x302DDB1 VA: 0x302DCB0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.GetEnumerator
	|
	|-RVA: 0x3038340 Offset: 0x3038441 VA: 0x3038340
	|-Dictionary<Bounds, object>.GetEnumerator
	|
	|-RVA: 0x303BE70 Offset: 0x303BF71 VA: 0x303BE70
	|-Dictionary<BoundsInt, object>.GetEnumerator
	|
	|-RVA: 0x303F880 Offset: 0x303F981 VA: 0x303F880
	|-Dictionary<Color, object>.GetEnumerator
	|
	|-RVA: 0x3042F70 Offset: 0x3043071 VA: 0x3042F70
	|-Dictionary<Color32, object>.GetEnumerator
	|
	|-RVA: 0x3065130 Offset: 0x3065231 VA: 0x3065130
	|-Dictionary<GradientAlphaKey, object>.GetEnumerator
	|
	|-RVA: 0x3068910 Offset: 0x3068A11 VA: 0x3068910
	|-Dictionary<GradientColorKey, object>.GetEnumerator
	|
	|-RVA: 0x306C4E0 Offset: 0x306C5E1 VA: 0x306C4E0
	|-Dictionary<Keyframe, object>.GetEnumerator
	|
	|-RVA: 0x3070030 Offset: 0x3070131 VA: 0x3070030
	|-Dictionary<LayerMask, object>.GetEnumerator
	|
	|-RVA: 0x3073980 Offset: 0x3073A81 VA: 0x3073980
	|-Dictionary<Matrix4x4, object>.GetEnumerator
	|
	|-RVA: 0x307ADF0 Offset: 0x307AEF1 VA: 0x307ADF0
	|-Dictionary<Quaternion, object>.GetEnumerator
	|
	|-RVA: 0x307E4D0 Offset: 0x307E5D1 VA: 0x307E4D0
	|-Dictionary<RangeInt, object>.GetEnumerator
	|
	|-RVA: 0x3049C60 Offset: 0x3049D61 VA: 0x3049C60
	|-Dictionary<Rect, object>.GetEnumerator
	|
	|-RVA: 0x304D3A0 Offset: 0x304D4A1 VA: 0x304D3A0
	|-Dictionary<RectInt, object>.GetEnumerator
	|
	|-RVA: 0x3050970 Offset: 0x3050A71 VA: 0x3050970
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.GetEnumerator
	|
	|-RVA: 0x3054030 Offset: 0x3054131 VA: 0x3054030
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0x3057690 Offset: 0x3057791 VA: 0x3057690
	|-Dictionary<Vector2, object>.GetEnumerator
	|
	|-RVA: 0x305ACD0 Offset: 0x305ADD1 VA: 0x305ACD0
	|-Dictionary<Vector2Int, object>.GetEnumerator
	|
	|-RVA: 0x3061A50 Offset: 0x3061B51 VA: 0x3061A50
	|-Dictionary<Vector3Int, object>.GetEnumerator
	|
	|-RVA: 0x2E3B450 Offset: 0x2E3B551 VA: 0x2E3B450
	|-Dictionary<Vector4, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16E50 Offset: 0x2A16F51 VA: 0x2A16E50
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2A1A490 Offset: 0x2A1A591 VA: 0x2A1A490
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E2A4C0 Offset: 0x2E2A5C1 VA: 0x2E2A4C0
	|-Dictionary<Season, Texture>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F79380 Offset: 0x2F79481 VA: 0x2F79380
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F7D070 Offset: 0x2F7D171 VA: 0x2F7D070
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F80F80 Offset: 0x2F81081 VA: 0x2F80F80
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F84980 Offset: 0x2F84A81 VA: 0x2F84980
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F88080 Offset: 0x2F88181 VA: 0x2F88080
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F8B8F0 Offset: 0x2F8B9F1 VA: 0x2F8B8F0
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F8F4A0 Offset: 0x2F8F5A1 VA: 0x2F8F4A0
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F92D90 Offset: 0x2F92E91 VA: 0x2F92D90
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D80E10 Offset: 0x2D80F11 VA: 0x2D80E10
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D84A80 Offset: 0x2D84B81 VA: 0x2D84A80
	|-Dictionary<Parameter, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D88540 Offset: 0x2D88641 VA: 0x2D88540
	|-Dictionary<bool, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D8BBA0 Offset: 0x2D8BCA1 VA: 0x2D8BBA0
	|-Dictionary<byte, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D8F1C0 Offset: 0x2D8F2C1 VA: 0x2D8F1C0
	|-Dictionary<char, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D927E0 Offset: 0x2D928E1 VA: 0x2D927E0
	|-Dictionary<DateTime, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D95E10 Offset: 0x2D95F11 VA: 0x2D95E10
	|-Dictionary<double, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D99470 Offset: 0x2D99571 VA: 0x2D99470
	|-Dictionary<Guid, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D9CA90 Offset: 0x2D9CB91 VA: 0x2D9CA90
	|-Dictionary<short, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D3AF20 Offset: 0x2D3B021 VA: 0x2D3AF20
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D3E9E0 Offset: 0x2D3EAE1 VA: 0x2D3E9E0
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D42160 Offset: 0x2D42261 VA: 0x2D42160
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D45AD0 Offset: 0x2D45BD1 VA: 0x2D45AD0
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D49470 Offset: 0x2D49571 VA: 0x2D49470
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D4CAD0 Offset: 0x2D4CBD1 VA: 0x2D4CAD0
	|-Dictionary<int, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D500A0 Offset: 0x2D501A1 VA: 0x2D500A0
	|-Dictionary<int, char>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D53660 Offset: 0x2D53761 VA: 0x2D53660
	|-Dictionary<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2D56C20 Offset: 0x2D56D21 VA: 0x2D56C20
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F5CD40 Offset: 0x2F5CE41 VA: 0x2F5CD40
	|-Dictionary<int, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F60430 Offset: 0x2F60531 VA: 0x2F60430
	|-Dictionary<int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F63CB0 Offset: 0x2F63DB1 VA: 0x2F63CB0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F67570 Offset: 0x2F67671 VA: 0x2F67570
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F6ABF0 Offset: 0x2F6ACF1 VA: 0x2F6ABF0
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F6E2C0 Offset: 0x2F6E3C1 VA: 0x2F6E2C0
	|-Dictionary<int, Vector3>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F71CF0 Offset: 0x2F71DF1 VA: 0x2F71CF0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F75920 Offset: 0x2F75A21 VA: 0x2F75920
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E1CC00 Offset: 0x2E1CD01 VA: 0x2E1CC00
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E202B0 Offset: 0x2E203B1 VA: 0x2E202B0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E238B0 Offset: 0x2E239B1 VA: 0x2E238B0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E26F00 Offset: 0x2E27001 VA: 0x2E26F00
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E2DB00 Offset: 0x2E2DC01 VA: 0x2E2DB00
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E310A0 Offset: 0x2E311A1 VA: 0x2E310A0
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E346E0 Offset: 0x2E347E1 VA: 0x2E346E0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E37D70 Offset: 0x2E37E71 VA: 0x2E37D70
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F968C0 Offset: 0x2F969C1 VA: 0x2F968C0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F9A020 Offset: 0x2F9A121 VA: 0x2F9A020
	|-Dictionary<long, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F9D6A0 Offset: 0x2F9D7A1 VA: 0x2F9D6A0
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FA0CD0 Offset: 0x2FA0DD1 VA: 0x2FA0CD0
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FA4700 Offset: 0x2FA4801 VA: 0x2FA4700
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FA8660 Offset: 0x2FA8761 VA: 0x2FA8660
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FAC370 Offset: 0x2FAC471 VA: 0x2FAC370
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FAFCF0 Offset: 0x2FAFDF1 VA: 0x2FAFCF0
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F1ACB0 Offset: 0x2F1ADB1 VA: 0x2F1ACB0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F1E6B0 Offset: 0x2F1E7B1 VA: 0x2F1E6B0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F223D0 Offset: 0x2F224D1 VA: 0x2F223D0
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F25F40 Offset: 0x2F26041 VA: 0x2F25F40
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F29B40 Offset: 0x2F29C41 VA: 0x2F29B40
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F2DE30 Offset: 0x2F2DF31 VA: 0x2F2DE30
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F31A00 Offset: 0x2F31B01 VA: 0x2F31A00
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F35400 Offset: 0x2F35501 VA: 0x2F35400
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2EFE110 Offset: 0x2EFE211 VA: 0x2EFE110
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F01CE0 Offset: 0x2F01DE1 VA: 0x2F01CE0
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F055B0 Offset: 0x2F056B1 VA: 0x2F055B0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F08E70 Offset: 0x2F08F71 VA: 0x2F08E70
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F0C6B0 Offset: 0x2F0C7B1 VA: 0x2F0C6B0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F10030 Offset: 0x2F10131 VA: 0x2F10030
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F13B40 Offset: 0x2F13C41 VA: 0x2F13B40
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2F173B0 Offset: 0x2F174B1 VA: 0x2F173B0
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FF3DB0 Offset: 0x2FF3EB1 VA: 0x2FF3DB0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FF78E0 Offset: 0x2FF79E1 VA: 0x2FF78E0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FFB160 Offset: 0x2FFB261 VA: 0x2FFB160
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FFE880 Offset: 0x2FFE981 VA: 0x2FFE880
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30021A0 Offset: 0x30022A1 VA: 0x30021A0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3005AC0 Offset: 0x3005BC1 VA: 0x3005AC0
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3009410 Offset: 0x3009511 VA: 0x3009410
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x300CEB0 Offset: 0x300CFB1 VA: 0x300CEB0
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DDE6E0 Offset: 0x2DDE7E1 VA: 0x2DDE6E0
	|-Dictionary<object, Parameter>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DE2060 Offset: 0x2DE2161 VA: 0x2DE2060
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DE56F0 Offset: 0x2DE57F1 VA: 0x2DE56F0
	|-Dictionary<object, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DE8DC0 Offset: 0x2DE8EC1 VA: 0x2DE8DC0
	|-Dictionary<object, byte>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DEC480 Offset: 0x2DEC581 VA: 0x2DEC480
	|-Dictionary<object, char>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DEFB40 Offset: 0x2DEFC41 VA: 0x2DEFB40
	|-Dictionary<object, DateTime>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DF31F0 Offset: 0x2DF32F1 VA: 0x2DF31F0
	|-Dictionary<object, double>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DF68B0 Offset: 0x2DF69B1 VA: 0x2DF68B0
	|-Dictionary<object, short>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DF9F70 Offset: 0x2DFA071 VA: 0x2DF9F70
	|-Dictionary<object, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30B9530 Offset: 0x30B9631 VA: 0x30B9530
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30BCBF0 Offset: 0x30BCCF1 VA: 0x30BCBF0
	|-Dictionary<object, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30C0300 Offset: 0x30C0401 VA: 0x30C0300
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30C3A70 Offset: 0x30C3B71 VA: 0x30C3A70
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30C74D0 Offset: 0x30C75D1 VA: 0x30C74D0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30CB130 Offset: 0x30CB231 VA: 0x30CB130
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30CEAD0 Offset: 0x30CEBD1 VA: 0x30CEAD0
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30D2450 Offset: 0x30D2551 VA: 0x30D2450
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3010830 Offset: 0x3010931 VA: 0x3010830
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30141D0 Offset: 0x30142D1 VA: 0x30141D0
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3017CF0 Offset: 0x3017DF1 VA: 0x3017CF0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x301B620 Offset: 0x301B721 VA: 0x301B620
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x301F2A0 Offset: 0x301F3A1 VA: 0x301F2A0
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3022FA0 Offset: 0x30230A1 VA: 0x3022FA0
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3026940 Offset: 0x3026A41 VA: 0x3026940
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x302A2F0 Offset: 0x302A3F1 VA: 0x302A2F0
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FD78D0 Offset: 0x2FD79D1 VA: 0x2FD78D0
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FDB270 Offset: 0x2FDB371 VA: 0x2FDB270
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FDEAC0 Offset: 0x2FDEBC1 VA: 0x2FDEAC0
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FE2300 Offset: 0x2FE2401 VA: 0x2FE2300
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FE5AF0 Offset: 0x2FE5BF1 VA: 0x2FE5AF0
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FE9450 Offset: 0x2FE9551 VA: 0x2FE9450
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FECD10 Offset: 0x2FECE11 VA: 0x2FECD10
	|-Dictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2FF0320 Offset: 0x2FF0421 VA: 0x2FF0320
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DBEDD0 Offset: 0x2DBEED1 VA: 0x2DBEDD0
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DC2490 Offset: 0x2DC2591 VA: 0x2DC2490
	|-Dictionary<object, sbyte>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DC5B50 Offset: 0x2DC5C51 VA: 0x2DC5B50
	|-Dictionary<object, float>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DC9210 Offset: 0x2DC9311 VA: 0x2DC9210
	|-Dictionary<object, ushort>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DCC8D0 Offset: 0x2DCC9D1 VA: 0x2DCC8D0
	|-Dictionary<object, uint>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DCFF90 Offset: 0x2DD0091 VA: 0x2DCFF90
	|-Dictionary<object, ulong>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DD3820 Offset: 0x2DD3921 VA: 0x2DD3820
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DD7210 Offset: 0x2DD7311 VA: 0x2DD7210
	|-Dictionary<object, Bounds>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2DDABD0 Offset: 0x2DDACD1 VA: 0x2DDABD0
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30D5CC0 Offset: 0x30D5DC1 VA: 0x30D5CC0
	|-Dictionary<object, Color32>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30D93F0 Offset: 0x30D94F1 VA: 0x30D93F0
	|-Dictionary<object, Color>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30DCAC0 Offset: 0x30DCBC1 VA: 0x30DCAC0
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30E0350 Offset: 0x30E0451 VA: 0x30E0350
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30E3DF0 Offset: 0x30E3EF1 VA: 0x30E3DF0
	|-Dictionary<object, Keyframe>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30E76A0 Offset: 0x30E77A1 VA: 0x30E76A0
	|-Dictionary<object, LayerMask>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30EB0E0 Offset: 0x30EB1E1 VA: 0x30EB0E0
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30EEA70 Offset: 0x30EEB71 VA: 0x30EEA70
	|-Dictionary<object, Playable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x309D880 Offset: 0x309D981 VA: 0x309D880
	|-Dictionary<object, Quaternion>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30A0F30 Offset: 0x30A1031 VA: 0x30A0F30
	|-Dictionary<object, RangeInt>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30A4650 Offset: 0x30A4751 VA: 0x30A4650
	|-Dictionary<object, Rect>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30A7D60 Offset: 0x30A7E61 VA: 0x30A7D60
	|-Dictionary<object, RectInt>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30AB5A0 Offset: 0x30AB6A1 VA: 0x30AB5A0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30AEF70 Offset: 0x30AF071 VA: 0x30AEF70
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30B27B0 Offset: 0x30B28B1 VA: 0x30B27B0
	|-Dictionary<object, Vector2>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30B5E80 Offset: 0x30B5F81 VA: 0x30B5E80
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3081B70 Offset: 0x3081C71 VA: 0x3081B70
	|-Dictionary<object, Vector3>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3085290 Offset: 0x3085391 VA: 0x3085290
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30889C0 Offset: 0x3088AC1 VA: 0x30889C0
	|-Dictionary<object, Vector4>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x308C120 Offset: 0x308C221 VA: 0x308C120
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x308F6F0 Offset: 0x308F7F1 VA: 0x308F6F0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3092DE0 Offset: 0x3092EE1 VA: 0x3092DE0
	|-Dictionary<sbyte, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3096850 Offset: 0x3096951 VA: 0x3096850
	|-Dictionary<float, CurveSample>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x309A260 Offset: 0x309A361 VA: 0x309A260
	|-Dictionary<float, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x319D7B0 Offset: 0x319D8B1 VA: 0x319D7B0
	|-Dictionary<ushort, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31A0D50 Offset: 0x31A0E51 VA: 0x31A0D50
	|-Dictionary<uint, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31A4310 Offset: 0x31A4411 VA: 0x31A4310
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31A7950 Offset: 0x31A7A51 VA: 0x31A7950
	|-Dictionary<uint, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31AAF70 Offset: 0x31AB071 VA: 0x31AAF70
	|-Dictionary<ulong, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31AE530 Offset: 0x31AE631 VA: 0x31AE530
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31B1EA0 Offset: 0x31B1FA1 VA: 0x31B1EA0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x31B5A10 Offset: 0x31B5B11 VA: 0x31B5A10
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x302DD20 Offset: 0x302DE21 VA: 0x302DD20
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3031510 Offset: 0x3031611 VA: 0x3031510
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3034BF0 Offset: 0x3034CF1 VA: 0x3034BF0
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30383B0 Offset: 0x30384B1 VA: 0x30383B0
	|-Dictionary<Bounds, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x303BEE0 Offset: 0x303BFE1 VA: 0x303BEE0
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x303F8F0 Offset: 0x303F9F1 VA: 0x303F8F0
	|-Dictionary<Color, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3042FE0 Offset: 0x30430E1 VA: 0x3042FE0
	|-Dictionary<Color32, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3046630 Offset: 0x3046731 VA: 0x3046630
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30651A0 Offset: 0x30652A1 VA: 0x30651A0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3068980 Offset: 0x3068A81 VA: 0x3068980
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x306C560 Offset: 0x306C661 VA: 0x306C560
	|-Dictionary<Keyframe, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30700A0 Offset: 0x30701A1 VA: 0x30700A0
	|-Dictionary<LayerMask, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3073A10 Offset: 0x3073B11 VA: 0x3073A10
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3077770 Offset: 0x3077871 VA: 0x3077770
	|-Dictionary<IntVec3, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x307AE60 Offset: 0x307AF61 VA: 0x307AE60
	|-Dictionary<Quaternion, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x307E540 Offset: 0x307E641 VA: 0x307E540
	|-Dictionary<RangeInt, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3049CD0 Offset: 0x3049DD1 VA: 0x3049CD0
	|-Dictionary<Rect, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x304D410 Offset: 0x304D511 VA: 0x304D410
	|-Dictionary<RectInt, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30509D0 Offset: 0x3050AD1 VA: 0x30509D0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x30540A0 Offset: 0x30541A1 VA: 0x30540A0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3057700 Offset: 0x3057801 VA: 0x3057700
	|-Dictionary<Vector2, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x305AD40 Offset: 0x305AE41 VA: 0x305AD40
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x305E3E0 Offset: 0x305E4E1 VA: 0x305E3E0
	|-Dictionary<Vector3, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3061AC0 Offset: 0x3061BC1 VA: 0x3061AC0
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2E3B4C0 Offset: 0x2E3B5C1 VA: 0x2E3B4C0
	|-Dictionary<Vector4, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A16EE0 Offset: 0x2A16FE1 VA: 0x2A16EE0
	|-Dictionary<JSONDeserialization.TaskField, object>.GetObjectData
	|
	|-RVA: 0x2A1A520 Offset: 0x2A1A621 VA: 0x2A1A520
	|-Dictionary<BitVector32Int, object>.GetObjectData
	|
	|-RVA: 0x2E2A540 Offset: 0x2E2A641 VA: 0x2E2A540
	|-Dictionary<Season, Texture>.GetObjectData
	|-Dictionary<Int32Enum, Int32Enum>.GetObjectData
	|
	|-RVA: 0x2F79420 Offset: 0x2F79521 VA: 0x2F79420
	|-Dictionary<EventCheckId, object>.GetObjectData
	|
	|-RVA: 0x2F7D120 Offset: 0x2F7D221 VA: 0x2F7D120
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.GetObjectData
	|
	|-RVA: 0x2F81020 Offset: 0x2F81121 VA: 0x2F81020
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.GetObjectData
	|
	|-RVA: 0x2F84A10 Offset: 0x2F84B11 VA: 0x2F84A10
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.GetObjectData
	|
	|-RVA: 0x2F88110 Offset: 0x2F88211 VA: 0x2F88110
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.GetObjectData
	|
	|-RVA: 0x2F8B990 Offset: 0x2F8BA91 VA: 0x2F8B990
	|-Dictionary<MonsterHutSaveData, object>.GetObjectData
	|
	|-RVA: 0x2F8F530 Offset: 0x2F8F631 VA: 0x2F8F530
	|-Dictionary<OrderLotterySaveParameter, object>.GetObjectData
	|
	|-RVA: 0x2F92E30 Offset: 0x2F92F31 VA: 0x2F92E30
	|-Dictionary<OrderSaveData, object>.GetObjectData
	|
	|-RVA: 0x2D80EB0 Offset: 0x2D80FB1 VA: 0x2D80EB0
	|-Dictionary<OrderSaveParameter, object>.GetObjectData
	|
	|-RVA: 0x2D84B30 Offset: 0x2D84C31 VA: 0x2D84B30
	|-Dictionary<Parameter, object>.GetObjectData
	|
	|-RVA: 0x2D885D0 Offset: 0x2D886D1 VA: 0x2D885D0
	|-Dictionary<bool, object>.GetObjectData
	|
	|-RVA: 0x2D8BC30 Offset: 0x2D8BD31 VA: 0x2D8BC30
	|-Dictionary<byte, object>.GetObjectData
	|
	|-RVA: 0x2D8F250 Offset: 0x2D8F351 VA: 0x2D8F250
	|-Dictionary<char, object>.GetObjectData
	|
	|-RVA: 0x2D92870 Offset: 0x2D92971 VA: 0x2D92870
	|-Dictionary<DateTime, object>.GetObjectData
	|
	|-RVA: 0x2D95EA0 Offset: 0x2D95FA1 VA: 0x2D95EA0
	|-Dictionary<double, object>.GetObjectData
	|
	|-RVA: 0x2D99500 Offset: 0x2D99601 VA: 0x2D99500
	|-Dictionary<Guid, object>.GetObjectData
	|
	|-RVA: 0x2D9CB20 Offset: 0x2D9CC21 VA: 0x2D9CB20
	|-Dictionary<short, object>.GetObjectData
	|
	|-RVA: 0x2D3AFC0 Offset: 0x2D3B0C1 VA: 0x2D3AFC0
	|-Dictionary<int, CropDataTable>.GetObjectData
	|
	|-RVA: 0x2D3EA70 Offset: 0x2D3EB71 VA: 0x2D3EA70
	|-Dictionary<int, EffectDataTable>.GetObjectData
	|
	|-RVA: 0x2D421E0 Offset: 0x2D422E1 VA: 0x2D421E0
	|-Dictionary<int, GimmickLayoutDataTable>.GetObjectData
	|
	|-RVA: 0x2D45B80 Offset: 0x2D45C81 VA: 0x2D45B80
	|-Dictionary<int, MineTypeDataTable>.GetObjectData
	|
	|-RVA: 0x2D49500 Offset: 0x2D49601 VA: 0x2D49500
	|-Dictionary<int, MiningDataTable>.GetObjectData
	|
	|-RVA: 0x2D4CB50 Offset: 0x2D4CC51 VA: 0x2D4CB50
	|-Dictionary<int, bool>.GetObjectData
	|
	|-RVA: 0x2D50120 Offset: 0x2D50221 VA: 0x2D50120
	|-Dictionary<int, char>.GetObjectData
	|
	|-RVA: 0x2D536E0 Offset: 0x2D537E1 VA: 0x2D536E0
	|-Dictionary<int, int>.GetObjectData
	|
	|-RVA: 0x2D56CA0 Offset: 0x2D56DA1 VA: 0x2D56CA0
	|-Dictionary<int, Int32Enum>.GetObjectData
	|
	|-RVA: 0x2F5CDD0 Offset: 0x2F5CED1 VA: 0x2F5CDD0
	|-Dictionary<int, long>.GetObjectData
	|
	|-RVA: 0x2F604C0 Offset: 0x2F605C1 VA: 0x2F604C0
	|-Dictionary<int, object>.GetObjectData
	|-Dictionary<int, TerrainUtility.TerrainMap>.GetObjectData
	|
	|-RVA: 0x2F63D60 Offset: 0x2F63E61 VA: 0x2F63D60
	|-Dictionary<int, DiagnosticEvent>.GetObjectData
	|
	|-RVA: 0x2F67600 Offset: 0x2F67701 VA: 0x2F67600
	|-Dictionary<int, SceneInstance>.GetObjectData
	|
	|-RVA: 0x2F6AC70 Offset: 0x2F6AD71 VA: 0x2F6AC70
	|-Dictionary<int, Vector2Int>.GetObjectData
	|
	|-RVA: 0x2F6E350 Offset: 0x2F6E451 VA: 0x2F6E350
	|-Dictionary<int, Vector3>.GetObjectData
	|
	|-RVA: 0x2F71DB0 Offset: 0x2F71EB1 VA: 0x2F71DB0
	|-Dictionary<Int32Enum, MonsterDataTable>.GetObjectData
	|
	|-RVA: 0x2F759D0 Offset: 0x2F75AD1 VA: 0x2F759D0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.GetObjectData
	|
	|-RVA: 0x2E1CC90 Offset: 0x2E1CD91 VA: 0x2E1CC90
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.GetObjectData
	|
	|-RVA: 0x2E20330 Offset: 0x2E20431 VA: 0x2E20330
	|-Dictionary<Int32Enum, bool>.GetObjectData
	|
	|-RVA: 0x2E23930 Offset: 0x2E23A31 VA: 0x2E23930
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.GetObjectData
	|
	|-RVA: 0x2E26F80 Offset: 0x2E27081 VA: 0x2E26F80
	|-Dictionary<Int32Enum, int>.GetObjectData
	|
	|-RVA: 0x2E2DB90 Offset: 0x2E2DC91 VA: 0x2E2DB90
	|-Dictionary<Int32Enum, object>.GetObjectData
	|
	|-RVA: 0x2E31120 Offset: 0x2E31221 VA: 0x2E31120
	|-Dictionary<Int32Enum, float>.GetObjectData
	|
	|-RVA: 0x2E34770 Offset: 0x2E34871 VA: 0x2E34770
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.GetObjectData
	|
	|-RVA: 0x2E37DF0 Offset: 0x2E37EF1 VA: 0x2E37DF0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.GetObjectData
	|
	|-RVA: 0x2F96950 Offset: 0x2F96A51 VA: 0x2F96950
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.GetObjectData
	|
	|-RVA: 0x2F9A0B0 Offset: 0x2F9A1B1 VA: 0x2F9A0B0
	|-Dictionary<long, object>.GetObjectData
	|
	|-RVA: 0x2F9D730 Offset: 0x2F9D831 VA: 0x2F9D730
	|-Dictionary<Memory<object>, object>.GetObjectData
	|
	|-RVA: 0x2FA0D60 Offset: 0x2FA0E61 VA: 0x2FA0D60
	|-Dictionary<Nullable<Int32Enum>, object>.GetObjectData
	|
	|-RVA: 0x2FA47A0 Offset: 0x2FA48A1 VA: 0x2FA47A0
	|-Dictionary<Nullable<Bounds>, object>.GetObjectData
	|
	|-RVA: 0x2FA8700 Offset: 0x2FA8801 VA: 0x2FA8700
	|-Dictionary<Nullable<BoundsInt>, object>.GetObjectData
	|
	|-RVA: 0x2FAC400 Offset: 0x2FAC501 VA: 0x2FAC400
	|-Dictionary<Nullable<Color32>, object>.GetObjectData
	|
	|-RVA: 0x2FAFD90 Offset: 0x2FAFE91 VA: 0x2FAFD90
	|-Dictionary<Nullable<Color>, object>.GetObjectData
	|
	|-RVA: 0x2F1AD40 Offset: 0x2F1AE41 VA: 0x2F1AD40
	|-Dictionary<Nullable<GradientAlphaKey>, object>.GetObjectData
	|
	|-RVA: 0x2F1E750 Offset: 0x2F1E851 VA: 0x2F1E750
	|-Dictionary<Nullable<GradientColorKey>, object>.GetObjectData
	|
	|-RVA: 0x2F22470 Offset: 0x2F22571 VA: 0x2F22470
	|-Dictionary<Nullable<Keyframe>, object>.GetObjectData
	|
	|-RVA: 0x2F25FD0 Offset: 0x2F260D1 VA: 0x2F25FD0
	|-Dictionary<Nullable<LayerMask>, object>.GetObjectData
	|
	|-RVA: 0x2F29C00 Offset: 0x2F29D01 VA: 0x2F29C00
	|-Dictionary<Nullable<Matrix4x4>, object>.GetObjectData
	|
	|-RVA: 0x2F2DED0 Offset: 0x2F2DFD1 VA: 0x2F2DED0
	|-Dictionary<Nullable<Quaternion>, object>.GetObjectData
	|
	|-RVA: 0x2F31A90 Offset: 0x2F31B91 VA: 0x2F31A90
	|-Dictionary<Nullable<RangeInt>, object>.GetObjectData
	|
	|-RVA: 0x2F354A0 Offset: 0x2F355A1 VA: 0x2F354A0
	|-Dictionary<Nullable<Rect>, object>.GetObjectData
	|
	|-RVA: 0x2EFE1B0 Offset: 0x2EFE2B1 VA: 0x2EFE1B0
	|-Dictionary<Nullable<RectInt>, object>.GetObjectData
	|
	|-RVA: 0x2F01D70 Offset: 0x2F01E71 VA: 0x2F01D70
	|-Dictionary<Nullable<Vector2>, object>.GetObjectData
	|
	|-RVA: 0x2F05640 Offset: 0x2F05741 VA: 0x2F05640
	|-Dictionary<Nullable<Vector2Int>, object>.GetObjectData
	|
	|-RVA: 0x2F08F00 Offset: 0x2F09001 VA: 0x2F08F00
	|-Dictionary<Nullable<Vector3>, object>.GetObjectData
	|
	|-RVA: 0x2F0C740 Offset: 0x2F0C841 VA: 0x2F0C740
	|-Dictionary<Nullable<Vector3Int>, object>.GetObjectData
	|
	|-RVA: 0x2F100D0 Offset: 0x2F101D1 VA: 0x2F100D0
	|-Dictionary<Nullable<Vector4>, object>.GetObjectData
	|
	|-RVA: 0x2F13BD0 Offset: 0x2F13CD1 VA: 0x2F13BD0
	|-Dictionary<object, BitVector32Int>.GetObjectData
	|
	|-RVA: 0x2F17450 Offset: 0x2F17551 VA: 0x2F17450
	|-Dictionary<object, EventCheckId>.GetObjectData
	|
	|-RVA: 0x2FF3E60 Offset: 0x2FF3F61 VA: 0x2FF3E60
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.GetObjectData
	|
	|-RVA: 0x2FF7980 Offset: 0x2FF7A81 VA: 0x2FF7980
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.GetObjectData
	|
	|-RVA: 0x2FFB1F0 Offset: 0x2FFB2F1 VA: 0x2FFB1F0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.GetObjectData
	|
	|-RVA: 0x2FFE910 Offset: 0x2FFEA11 VA: 0x2FFE910
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.GetObjectData
	|
	|-RVA: 0x3002240 Offset: 0x3002341 VA: 0x3002240
	|-Dictionary<object, MonsterHutSaveData>.GetObjectData
	|
	|-RVA: 0x3005B50 Offset: 0x3005C51 VA: 0x3005B50
	|-Dictionary<object, OrderLotterySaveParameter>.GetObjectData
	|
	|-RVA: 0x30094B0 Offset: 0x30095B1 VA: 0x30094B0
	|-Dictionary<object, OrderSaveData>.GetObjectData
	|
	|-RVA: 0x300CF50 Offset: 0x300D051 VA: 0x300CF50
	|-Dictionary<object, OrderSaveParameter>.GetObjectData
	|
	|-RVA: 0x2DDE790 Offset: 0x2DDE891 VA: 0x2DDE790
	|-Dictionary<object, Parameter>.GetObjectData
	|
	|-RVA: 0x2DE20F0 Offset: 0x2DE21F1 VA: 0x2DE20F0
	|-Dictionary<object, NumberControl.ValueRange>.GetObjectData
	|
	|-RVA: 0x2DE5780 Offset: 0x2DE5881 VA: 0x2DE5780
	|-Dictionary<object, bool>.GetObjectData
	|
	|-RVA: 0x2DE8E50 Offset: 0x2DE8F51 VA: 0x2DE8E50
	|-Dictionary<object, byte>.GetObjectData
	|
	|-RVA: 0x2DEC510 Offset: 0x2DEC611 VA: 0x2DEC510
	|-Dictionary<object, char>.GetObjectData
	|
	|-RVA: 0x2DEFBD0 Offset: 0x2DEFCD1 VA: 0x2DEFBD0
	|-Dictionary<object, DateTime>.GetObjectData
	|
	|-RVA: 0x2DF3280 Offset: 0x2DF3381 VA: 0x2DF3280
	|-Dictionary<object, double>.GetObjectData
	|
	|-RVA: 0x2DF6940 Offset: 0x2DF6A41 VA: 0x2DF6940
	|-Dictionary<object, short>.GetObjectData
	|
	|-RVA: 0x2DFA000 Offset: 0x2DFA101 VA: 0x2DFA000
	|-Dictionary<object, int>.GetObjectData
	|
	|-RVA: 0x30B95C0 Offset: 0x30B96C1 VA: 0x30B95C0
	|-Dictionary<object, Int32Enum>.GetObjectData
	|
	|-RVA: 0x30BCC80 Offset: 0x30BCD81 VA: 0x30BCC80
	|-Dictionary<object, long>.GetObjectData
	|
	|-RVA: 0x30C0390 Offset: 0x30C0491 VA: 0x30C0390
	|-Dictionary<object, Memory<object>>.GetObjectData
	|
	|-RVA: 0x30C3B00 Offset: 0x30C3C01 VA: 0x30C3B00
	|-Dictionary<object, Nullable<Int32Enum>>.GetObjectData
	|
	|-RVA: 0x30C7570 Offset: 0x30C7671 VA: 0x30C7570
	|-Dictionary<object, Nullable<Bounds>>.GetObjectData
	|
	|-RVA: 0x30CB1D0 Offset: 0x30CB2D1 VA: 0x30CB1D0
	|-Dictionary<object, Nullable<BoundsInt>>.GetObjectData
	|
	|-RVA: 0x30CEB60 Offset: 0x30CEC61 VA: 0x30CEB60
	|-Dictionary<object, Nullable<Color32>>.GetObjectData
	|
	|-RVA: 0x30D24F0 Offset: 0x30D25F1 VA: 0x30D24F0
	|-Dictionary<object, Nullable<Color>>.GetObjectData
	|
	|-RVA: 0x30108C0 Offset: 0x30109C1 VA: 0x30108C0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.GetObjectData
	|
	|-RVA: 0x3014270 Offset: 0x3014371 VA: 0x3014270
	|-Dictionary<object, Nullable<GradientColorKey>>.GetObjectData
	|
	|-RVA: 0x3017D90 Offset: 0x3017E91 VA: 0x3017D90
	|-Dictionary<object, Nullable<Keyframe>>.GetObjectData
	|
	|-RVA: 0x301B6B0 Offset: 0x301B7B1 VA: 0x301B6B0
	|-Dictionary<object, Nullable<LayerMask>>.GetObjectData
	|
	|-RVA: 0x301F360 Offset: 0x301F461 VA: 0x301F360
	|-Dictionary<object, Nullable<Matrix4x4>>.GetObjectData
	|
	|-RVA: 0x3023040 Offset: 0x3023141 VA: 0x3023040
	|-Dictionary<object, Nullable<Quaternion>>.GetObjectData
	|
	|-RVA: 0x30269D0 Offset: 0x3026AD1 VA: 0x30269D0
	|-Dictionary<object, Nullable<RangeInt>>.GetObjectData
	|
	|-RVA: 0x302A390 Offset: 0x302A491 VA: 0x302A390
	|-Dictionary<object, Nullable<Rect>>.GetObjectData
	|
	|-RVA: 0x2FD7970 Offset: 0x2FD7A71 VA: 0x2FD7970
	|-Dictionary<object, Nullable<RectInt>>.GetObjectData
	|
	|-RVA: 0x2FDB300 Offset: 0x2FDB401 VA: 0x2FDB300
	|-Dictionary<object, Nullable<Vector2>>.GetObjectData
	|
	|-RVA: 0x2FDEB50 Offset: 0x2FDEC51 VA: 0x2FDEB50
	|-Dictionary<object, Nullable<Vector2Int>>.GetObjectData
	|
	|-RVA: 0x2FE2390 Offset: 0x2FE2491 VA: 0x2FE2390
	|-Dictionary<object, Nullable<Vector3>>.GetObjectData
	|
	|-RVA: 0x2FE5B80 Offset: 0x2FE5C81 VA: 0x2FE5B80
	|-Dictionary<object, Nullable<Vector3Int>>.GetObjectData
	|
	|-RVA: 0x2FE94F0 Offset: 0x2FE95F1 VA: 0x2FE94F0
	|-Dictionary<object, Nullable<Vector4>>.GetObjectData
	|
	|-RVA: 0x2FECDA0 Offset: 0x2FECEA1 VA: 0x2FECDA0
	|-Dictionary<object, object>.GetObjectData
	|
	|-RVA: 0x2FF03B0 Offset: 0x2FF04B1 VA: 0x2FF03B0
	|-Dictionary<object, ReadOnlyMemory<object>>.GetObjectData
	|
	|-RVA: 0x2DBEE60 Offset: 0x2DBEF61 VA: 0x2DBEE60
	|-Dictionary<object, ResourceLocator>.GetObjectData
	|
	|-RVA: 0x2DC2520 Offset: 0x2DC2621 VA: 0x2DC2520
	|-Dictionary<object, sbyte>.GetObjectData
	|
	|-RVA: 0x2DC5BE0 Offset: 0x2DC5CE1 VA: 0x2DC5BE0
	|-Dictionary<object, float>.GetObjectData
	|
	|-RVA: 0x2DC92A0 Offset: 0x2DC93A1 VA: 0x2DC92A0
	|-Dictionary<object, ushort>.GetObjectData
	|
	|-RVA: 0x2DCC960 Offset: 0x2DCCA61 VA: 0x2DCC960
	|-Dictionary<object, uint>.GetObjectData
	|
	|-RVA: 0x2DD0020 Offset: 0x2DD0121 VA: 0x2DD0020
	|-Dictionary<object, ulong>.GetObjectData
	|
	|-RVA: 0x2DD38C0 Offset: 0x2DD39C1 VA: 0x2DD38C0
	|-Dictionary<object, TransitionTables>.GetObjectData
	|
	|-RVA: 0x2DD72B0 Offset: 0x2DD73B1 VA: 0x2DD72B0
	|-Dictionary<object, Bounds>.GetObjectData
	|
	|-RVA: 0x2DDAC70 Offset: 0x2DDAD71 VA: 0x2DDAC70
	|-Dictionary<object, BoundsInt>.GetObjectData
	|
	|-RVA: 0x30D5D50 Offset: 0x30D5E51 VA: 0x30D5D50
	|-Dictionary<object, Color32>.GetObjectData
	|
	|-RVA: 0x30D9480 Offset: 0x30D9581 VA: 0x30D9480
	|-Dictionary<object, Color>.GetObjectData
	|
	|-RVA: 0x30DCB50 Offset: 0x30DCC51 VA: 0x30DCB50
	|-Dictionary<object, GradientAlphaKey>.GetObjectData
	|
	|-RVA: 0x30E03F0 Offset: 0x30E04F1 VA: 0x30E03F0
	|-Dictionary<object, GradientColorKey>.GetObjectData
	|
	|-RVA: 0x30E3E90 Offset: 0x30E3F91 VA: 0x30E3E90
	|-Dictionary<object, Keyframe>.GetObjectData
	|
	|-RVA: 0x30E7730 Offset: 0x30E7831 VA: 0x30E7730
	|-Dictionary<object, LayerMask>.GetObjectData
	|
	|-RVA: 0x30EB190 Offset: 0x30EB291 VA: 0x30EB190
	|-Dictionary<object, Matrix4x4>.GetObjectData
	|
	|-RVA: 0x30EEB00 Offset: 0x30EEC01 VA: 0x30EEB00
	|-Dictionary<object, Playable>.GetObjectData
	|
	|-RVA: 0x309D910 Offset: 0x309DA11 VA: 0x309D910
	|-Dictionary<object, Quaternion>.GetObjectData
	|
	|-RVA: 0x30A0FC0 Offset: 0x30A10C1 VA: 0x30A0FC0
	|-Dictionary<object, RangeInt>.GetObjectData
	|
	|-RVA: 0x30A46E0 Offset: 0x30A47E1 VA: 0x30A46E0
	|-Dictionary<object, Rect>.GetObjectData
	|
	|-RVA: 0x30A7DF0 Offset: 0x30A7EF1 VA: 0x30A7DF0
	|-Dictionary<object, RectInt>.GetObjectData
	|
	|-RVA: 0x30AB640 Offset: 0x30AB741 VA: 0x30AB640
	|-Dictionary<object, AsyncOperationHandle>.GetObjectData
	|
	|-RVA: 0x30AF010 Offset: 0x30AF111 VA: 0x30AF010
	|-Dictionary<object, AsyncOperationHandle<object>>.GetObjectData
	|
	|-RVA: 0x30B2840 Offset: 0x30B2941 VA: 0x30B2840
	|-Dictionary<object, Vector2>.GetObjectData
	|
	|-RVA: 0x30B5F10 Offset: 0x30B6011 VA: 0x30B5F10
	|-Dictionary<object, Vector2Int>.GetObjectData
	|
	|-RVA: 0x3081C00 Offset: 0x3081D01 VA: 0x3081C00
	|-Dictionary<object, Vector3>.GetObjectData
	|
	|-RVA: 0x3085320 Offset: 0x3085421 VA: 0x3085320
	|-Dictionary<object, Vector3Int>.GetObjectData
	|
	|-RVA: 0x3088A50 Offset: 0x3088B51 VA: 0x3088A50
	|-Dictionary<object, Vector4>.GetObjectData
	|
	|-RVA: 0x308C1B0 Offset: 0x308C2B1 VA: 0x308C1B0
	|-Dictionary<ReadOnlyMemory<object>, object>.GetObjectData
	|
	|-RVA: 0x308F780 Offset: 0x308F881 VA: 0x308F780
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.GetObjectData
	|
	|-RVA: 0x3092E70 Offset: 0x3092F71 VA: 0x3092E70
	|-Dictionary<sbyte, object>.GetObjectData
	|
	|-RVA: 0x3096900 Offset: 0x3096A01 VA: 0x3096900
	|-Dictionary<float, CurveSample>.GetObjectData
	|
	|-RVA: 0x309A2F0 Offset: 0x309A3F1 VA: 0x309A2F0
	|-Dictionary<float, object>.GetObjectData
	|
	|-RVA: 0x319D840 Offset: 0x319D941 VA: 0x319D840
	|-Dictionary<ushort, object>.GetObjectData
	|
	|-RVA: 0x31A0DD0 Offset: 0x31A0ED1 VA: 0x31A0DD0
	|-Dictionary<uint, int>.GetObjectData
	|
	|-RVA: 0x31A4390 Offset: 0x31A4491 VA: 0x31A4390
	|-Dictionary<uint, Int32Enum>.GetObjectData
	|
	|-RVA: 0x31A79E0 Offset: 0x31A7AE1 VA: 0x31A79E0
	|-Dictionary<uint, object>.GetObjectData
	|
	|-RVA: 0x31AB000 Offset: 0x31AB101 VA: 0x31AB000
	|-Dictionary<ulong, object>.GetObjectData
	|
	|-RVA: 0x31AE5B0 Offset: 0x31AE6B1 VA: 0x31AE5B0
	|-Dictionary<EdgeKeyByHash, int>.GetObjectData
	|
	|-RVA: 0x31B1F40 Offset: 0x31B2041 VA: 0x31B1F40
	|-Dictionary<EdgeKeyByHash, CapEdge>.GetObjectData
	|
	|-RVA: 0x31B5AC0 Offset: 0x31B5BC1 VA: 0x31B5AC0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.GetObjectData
	|
	|-RVA: 0x302DDB0 Offset: 0x302DEB1 VA: 0x302DDB0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.GetObjectData
	|
	|-RVA: 0x3031590 Offset: 0x3031691 VA: 0x3031590
	|-Dictionary<MeshDataConnectivity.Face, bool>.GetObjectData
	|
	|-RVA: 0x3034C80 Offset: 0x3034D81 VA: 0x3034C80
	|-Dictionary<MeshDataConnectivity.Face, object>.GetObjectData
	|
	|-RVA: 0x3038450 Offset: 0x3038551 VA: 0x3038450
	|-Dictionary<Bounds, object>.GetObjectData
	|
	|-RVA: 0x303BF80 Offset: 0x303C081 VA: 0x303BF80
	|-Dictionary<BoundsInt, object>.GetObjectData
	|
	|-RVA: 0x303F980 Offset: 0x303FA81 VA: 0x303F980
	|-Dictionary<Color, object>.GetObjectData
	|
	|-RVA: 0x3043070 Offset: 0x3043171 VA: 0x3043070
	|-Dictionary<Color32, object>.GetObjectData
	|
	|-RVA: 0x30466C0 Offset: 0x30467C1 VA: 0x30466C0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.GetObjectData
	|
	|-RVA: 0x3065230 Offset: 0x3065331 VA: 0x3065230
	|-Dictionary<GradientAlphaKey, object>.GetObjectData
	|
	|-RVA: 0x3068A20 Offset: 0x3068B21 VA: 0x3068A20
	|-Dictionary<GradientColorKey, object>.GetObjectData
	|
	|-RVA: 0x306C600 Offset: 0x306C701 VA: 0x306C600
	|-Dictionary<Keyframe, object>.GetObjectData
	|
	|-RVA: 0x3070130 Offset: 0x3070231 VA: 0x3070130
	|-Dictionary<LayerMask, object>.GetObjectData
	|
	|-RVA: 0x3073AC0 Offset: 0x3073BC1 VA: 0x3073AC0
	|-Dictionary<Matrix4x4, object>.GetObjectData
	|
	|-RVA: 0x3077800 Offset: 0x3077901 VA: 0x3077800
	|-Dictionary<IntVec3, object>.GetObjectData
	|
	|-RVA: 0x307AEF0 Offset: 0x307AFF1 VA: 0x307AEF0
	|-Dictionary<Quaternion, object>.GetObjectData
	|
	|-RVA: 0x307E5D0 Offset: 0x307E6D1 VA: 0x307E5D0
	|-Dictionary<RangeInt, object>.GetObjectData
	|
	|-RVA: 0x3049D60 Offset: 0x3049E61 VA: 0x3049D60
	|-Dictionary<Rect, object>.GetObjectData
	|
	|-RVA: 0x304D4A0 Offset: 0x304D5A1 VA: 0x304D4A0
	|-Dictionary<RectInt, object>.GetObjectData
	|
	|-RVA: 0x3050A50 Offset: 0x3050B51 VA: 0x3050A50
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.GetObjectData
	|
	|-RVA: 0x3054130 Offset: 0x3054231 VA: 0x3054130
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.GetObjectData
	|
	|-RVA: 0x3057790 Offset: 0x3057891 VA: 0x3057790
	|-Dictionary<Vector2, object>.GetObjectData
	|
	|-RVA: 0x305ADD0 Offset: 0x305AED1 VA: 0x305ADD0
	|-Dictionary<Vector2Int, object>.GetObjectData
	|
	|-RVA: 0x305E470 Offset: 0x305E571 VA: 0x305E470
	|-Dictionary<Vector3, object>.GetObjectData
	|
	|-RVA: 0x3061B50 Offset: 0x3061C51 VA: 0x3061B50
	|-Dictionary<Vector3Int, object>.GetObjectData
	|
	|-RVA: 0x2E3B550 Offset: 0x2E3B651 VA: 0x2E3B550
	|-Dictionary<Vector4, object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	private int FindEntry(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A170F0 Offset: 0x2A171F1 VA: 0x2A170F0
	|-Dictionary<JSONDeserialization.TaskField, object>.FindEntry
	|
	|-RVA: 0x2A1A730 Offset: 0x2A1A831 VA: 0x2A1A730
	|-Dictionary<BitVector32Int, object>.FindEntry
	|
	|-RVA: 0x2F79630 Offset: 0x2F79731 VA: 0x2F79630
	|-Dictionary<EventCheckId, object>.FindEntry
	|
	|-RVA: 0x2F7D330 Offset: 0x2F7D431 VA: 0x2F7D330
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.FindEntry
	|
	|-RVA: 0x2F81230 Offset: 0x2F81331 VA: 0x2F81230
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.FindEntry
	|
	|-RVA: 0x2F84C20 Offset: 0x2F84D21 VA: 0x2F84C20
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.FindEntry
	|
	|-RVA: 0x2F88320 Offset: 0x2F88421 VA: 0x2F88320
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.FindEntry
	|
	|-RVA: 0x2F8BBA0 Offset: 0x2F8BCA1 VA: 0x2F8BBA0
	|-Dictionary<MonsterHutSaveData, object>.FindEntry
	|
	|-RVA: 0x2F8F740 Offset: 0x2F8F841 VA: 0x2F8F740
	|-Dictionary<OrderLotterySaveParameter, object>.FindEntry
	|
	|-RVA: 0x2F93040 Offset: 0x2F93141 VA: 0x2F93040
	|-Dictionary<OrderSaveData, object>.FindEntry
	|
	|-RVA: 0x2D810C0 Offset: 0x2D811C1 VA: 0x2D810C0
	|-Dictionary<OrderSaveParameter, object>.FindEntry
	|
	|-RVA: 0x2D84D40 Offset: 0x2D84E41 VA: 0x2D84D40
	|-Dictionary<Parameter, object>.FindEntry
	|
	|-RVA: 0x2D887E0 Offset: 0x2D888E1 VA: 0x2D887E0
	|-Dictionary<bool, object>.FindEntry
	|
	|-RVA: 0x2D8BE40 Offset: 0x2D8BF41 VA: 0x2D8BE40
	|-Dictionary<byte, object>.FindEntry
	|
	|-RVA: 0x2D8F460 Offset: 0x2D8F561 VA: 0x2D8F460
	|-Dictionary<char, object>.FindEntry
	|
	|-RVA: 0x2D92A80 Offset: 0x2D92B81 VA: 0x2D92A80
	|-Dictionary<DateTime, object>.FindEntry
	|
	|-RVA: 0x2D960B0 Offset: 0x2D961B1 VA: 0x2D960B0
	|-Dictionary<double, object>.FindEntry
	|
	|-RVA: 0x2D99710 Offset: 0x2D99811 VA: 0x2D99710
	|-Dictionary<Guid, object>.FindEntry
	|
	|-RVA: 0x2D9CD30 Offset: 0x2D9CE31 VA: 0x2D9CD30
	|-Dictionary<short, object>.FindEntry
	|
	|-RVA: 0x2D3B1D0 Offset: 0x2D3B2D1 VA: 0x2D3B1D0
	|-Dictionary<int, CropDataTable>.FindEntry
	|
	|-RVA: 0x2D3EC80 Offset: 0x2D3ED81 VA: 0x2D3EC80
	|-Dictionary<int, EffectDataTable>.FindEntry
	|
	|-RVA: 0x2D423F0 Offset: 0x2D424F1 VA: 0x2D423F0
	|-Dictionary<int, GimmickLayoutDataTable>.FindEntry
	|
	|-RVA: 0x2D45D90 Offset: 0x2D45E91 VA: 0x2D45D90
	|-Dictionary<int, MineTypeDataTable>.FindEntry
	|
	|-RVA: 0x2D49710 Offset: 0x2D49811 VA: 0x2D49710
	|-Dictionary<int, MiningDataTable>.FindEntry
	|
	|-RVA: 0x2D4CD60 Offset: 0x2D4CE61 VA: 0x2D4CD60
	|-Dictionary<int, bool>.FindEntry
	|
	|-RVA: 0x2D50330 Offset: 0x2D50431 VA: 0x2D50330
	|-Dictionary<int, char>.FindEntry
	|
	|-RVA: 0x2D538F0 Offset: 0x2D539F1 VA: 0x2D538F0
	|-Dictionary<int, int>.FindEntry
	|
	|-RVA: 0x2D56EB0 Offset: 0x2D56FB1 VA: 0x2D56EB0
	|-Dictionary<int, Int32Enum>.FindEntry
	|
	|-RVA: 0x2F5CFE0 Offset: 0x2F5D0E1 VA: 0x2F5CFE0
	|-Dictionary<int, long>.FindEntry
	|
	|-RVA: 0x2F606D0 Offset: 0x2F607D1 VA: 0x2F606D0
	|-Dictionary<int, object>.FindEntry
	|
	|-RVA: 0x2F63F70 Offset: 0x2F64071 VA: 0x2F63F70
	|-Dictionary<int, DiagnosticEvent>.FindEntry
	|
	|-RVA: 0x2F67810 Offset: 0x2F67911 VA: 0x2F67810
	|-Dictionary<int, SceneInstance>.FindEntry
	|
	|-RVA: 0x2F6AE80 Offset: 0x2F6AF81 VA: 0x2F6AE80
	|-Dictionary<int, Vector2Int>.FindEntry
	|
	|-RVA: 0x2F6E560 Offset: 0x2F6E661 VA: 0x2F6E560
	|-Dictionary<int, Vector3>.FindEntry
	|
	|-RVA: 0x2F71FC0 Offset: 0x2F720C1 VA: 0x2F71FC0
	|-Dictionary<Int32Enum, MonsterDataTable>.FindEntry
	|
	|-RVA: 0x2F75BE0 Offset: 0x2F75CE1 VA: 0x2F75BE0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.FindEntry
	|
	|-RVA: 0x2E1CEA0 Offset: 0x2E1CFA1 VA: 0x2E1CEA0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.FindEntry
	|
	|-RVA: 0x2E20540 Offset: 0x2E20641 VA: 0x2E20540
	|-Dictionary<Int32Enum, bool>.FindEntry
	|
	|-RVA: 0x2E23B40 Offset: 0x2E23C41 VA: 0x2E23B40
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.FindEntry
	|
	|-RVA: 0x2E27190 Offset: 0x2E27291 VA: 0x2E27190
	|-Dictionary<Int32Enum, int>.FindEntry
	|
	|-RVA: 0x2E2A750 Offset: 0x2E2A851 VA: 0x2E2A750
	|-Dictionary<Int32Enum, Int32Enum>.FindEntry
	|
	|-RVA: 0x2E2DDA0 Offset: 0x2E2DEA1 VA: 0x2E2DDA0
	|-Dictionary<Int32Enum, object>.FindEntry
	|
	|-RVA: 0x2E31330 Offset: 0x2E31431 VA: 0x2E31330
	|-Dictionary<Int32Enum, float>.FindEntry
	|
	|-RVA: 0x2E34980 Offset: 0x2E34A81 VA: 0x2E34980
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.FindEntry
	|
	|-RVA: 0x2E38000 Offset: 0x2E38101 VA: 0x2E38000
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.FindEntry
	|
	|-RVA: 0x2F96B60 Offset: 0x2F96C61 VA: 0x2F96B60
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.FindEntry
	|
	|-RVA: 0x2F9A2C0 Offset: 0x2F9A3C1 VA: 0x2F9A2C0
	|-Dictionary<long, object>.FindEntry
	|
	|-RVA: 0x2F9D940 Offset: 0x2F9DA41 VA: 0x2F9D940
	|-Dictionary<Memory<object>, object>.FindEntry
	|
	|-RVA: 0x2FA0F70 Offset: 0x2FA1071 VA: 0x2FA0F70
	|-Dictionary<Nullable<Int32Enum>, object>.FindEntry
	|
	|-RVA: 0x2FA49B0 Offset: 0x2FA4AB1 VA: 0x2FA49B0
	|-Dictionary<Nullable<Bounds>, object>.FindEntry
	|
	|-RVA: 0x2FA8910 Offset: 0x2FA8A11 VA: 0x2FA8910
	|-Dictionary<Nullable<BoundsInt>, object>.FindEntry
	|
	|-RVA: 0x2FAC610 Offset: 0x2FAC711 VA: 0x2FAC610
	|-Dictionary<Nullable<Color32>, object>.FindEntry
	|
	|-RVA: 0x2FAFFA0 Offset: 0x2FB00A1 VA: 0x2FAFFA0
	|-Dictionary<Nullable<Color>, object>.FindEntry
	|
	|-RVA: 0x2F1AF50 Offset: 0x2F1B051 VA: 0x2F1AF50
	|-Dictionary<Nullable<GradientAlphaKey>, object>.FindEntry
	|
	|-RVA: 0x2F1E960 Offset: 0x2F1EA61 VA: 0x2F1E960
	|-Dictionary<Nullable<GradientColorKey>, object>.FindEntry
	|
	|-RVA: 0x2F22680 Offset: 0x2F22781 VA: 0x2F22680
	|-Dictionary<Nullable<Keyframe>, object>.FindEntry
	|
	|-RVA: 0x2F261E0 Offset: 0x2F262E1 VA: 0x2F261E0
	|-Dictionary<Nullable<LayerMask>, object>.FindEntry
	|
	|-RVA: 0x2F29E10 Offset: 0x2F29F11 VA: 0x2F29E10
	|-Dictionary<Nullable<Matrix4x4>, object>.FindEntry
	|
	|-RVA: 0x2F2E0E0 Offset: 0x2F2E1E1 VA: 0x2F2E0E0
	|-Dictionary<Nullable<Quaternion>, object>.FindEntry
	|
	|-RVA: 0x2F31CA0 Offset: 0x2F31DA1 VA: 0x2F31CA0
	|-Dictionary<Nullable<RangeInt>, object>.FindEntry
	|
	|-RVA: 0x2F356B0 Offset: 0x2F357B1 VA: 0x2F356B0
	|-Dictionary<Nullable<Rect>, object>.FindEntry
	|
	|-RVA: 0x2EFE3C0 Offset: 0x2EFE4C1 VA: 0x2EFE3C0
	|-Dictionary<Nullable<RectInt>, object>.FindEntry
	|
	|-RVA: 0x2F01F80 Offset: 0x2F02081 VA: 0x2F01F80
	|-Dictionary<Nullable<Vector2>, object>.FindEntry
	|
	|-RVA: 0x2F05850 Offset: 0x2F05951 VA: 0x2F05850
	|-Dictionary<Nullable<Vector2Int>, object>.FindEntry
	|
	|-RVA: 0x2F09110 Offset: 0x2F09211 VA: 0x2F09110
	|-Dictionary<Nullable<Vector3>, object>.FindEntry
	|
	|-RVA: 0x2F0C950 Offset: 0x2F0CA51 VA: 0x2F0C950
	|-Dictionary<Nullable<Vector3Int>, object>.FindEntry
	|
	|-RVA: 0x2F102E0 Offset: 0x2F103E1 VA: 0x2F102E0
	|-Dictionary<Nullable<Vector4>, object>.FindEntry
	|
	|-RVA: 0x2F13DE0 Offset: 0x2F13EE1 VA: 0x2F13DE0
	|-Dictionary<object, BitVector32Int>.FindEntry
	|
	|-RVA: 0x2F17660 Offset: 0x2F17761 VA: 0x2F17660
	|-Dictionary<object, EventCheckId>.FindEntry
	|
	|-RVA: 0x2FF4070 Offset: 0x2FF4171 VA: 0x2FF4070
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.FindEntry
	|
	|-RVA: 0x2FF7B90 Offset: 0x2FF7C91 VA: 0x2FF7B90
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.FindEntry
	|
	|-RVA: 0x2FFB400 Offset: 0x2FFB501 VA: 0x2FFB400
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.FindEntry
	|
	|-RVA: 0x2FFEB20 Offset: 0x2FFEC21 VA: 0x2FFEB20
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.FindEntry
	|
	|-RVA: 0x3002450 Offset: 0x3002551 VA: 0x3002450
	|-Dictionary<object, MonsterHutSaveData>.FindEntry
	|
	|-RVA: 0x3005D60 Offset: 0x3005E61 VA: 0x3005D60
	|-Dictionary<object, OrderLotterySaveParameter>.FindEntry
	|
	|-RVA: 0x30096C0 Offset: 0x30097C1 VA: 0x30096C0
	|-Dictionary<object, OrderSaveData>.FindEntry
	|
	|-RVA: 0x300D160 Offset: 0x300D261 VA: 0x300D160
	|-Dictionary<object, OrderSaveParameter>.FindEntry
	|
	|-RVA: 0x2DDE9A0 Offset: 0x2DDEAA1 VA: 0x2DDE9A0
	|-Dictionary<object, Parameter>.FindEntry
	|
	|-RVA: 0x2DE2300 Offset: 0x2DE2401 VA: 0x2DE2300
	|-Dictionary<object, NumberControl.ValueRange>.FindEntry
	|
	|-RVA: 0x2DE5990 Offset: 0x2DE5A91 VA: 0x2DE5990
	|-Dictionary<object, bool>.FindEntry
	|
	|-RVA: 0x2DE9060 Offset: 0x2DE9161 VA: 0x2DE9060
	|-Dictionary<object, byte>.FindEntry
	|
	|-RVA: 0x2DEC720 Offset: 0x2DEC821 VA: 0x2DEC720
	|-Dictionary<object, char>.FindEntry
	|
	|-RVA: 0x2DEFDE0 Offset: 0x2DEFEE1 VA: 0x2DEFDE0
	|-Dictionary<object, DateTime>.FindEntry
	|
	|-RVA: 0x2DF3490 Offset: 0x2DF3591 VA: 0x2DF3490
	|-Dictionary<object, double>.FindEntry
	|
	|-RVA: 0x2DF6B50 Offset: 0x2DF6C51 VA: 0x2DF6B50
	|-Dictionary<object, short>.FindEntry
	|
	|-RVA: 0x2DFA210 Offset: 0x2DFA311 VA: 0x2DFA210
	|-Dictionary<object, int>.FindEntry
	|
	|-RVA: 0x30B97D0 Offset: 0x30B98D1 VA: 0x30B97D0
	|-Dictionary<object, Int32Enum>.FindEntry
	|
	|-RVA: 0x30BCE90 Offset: 0x30BCF91 VA: 0x30BCE90
	|-Dictionary<object, long>.FindEntry
	|
	|-RVA: 0x30C05A0 Offset: 0x30C06A1 VA: 0x30C05A0
	|-Dictionary<object, Memory<object>>.FindEntry
	|
	|-RVA: 0x30C3D10 Offset: 0x30C3E11 VA: 0x30C3D10
	|-Dictionary<object, Nullable<Int32Enum>>.FindEntry
	|
	|-RVA: 0x30C7780 Offset: 0x30C7881 VA: 0x30C7780
	|-Dictionary<object, Nullable<Bounds>>.FindEntry
	|
	|-RVA: 0x30CB3E0 Offset: 0x30CB4E1 VA: 0x30CB3E0
	|-Dictionary<object, Nullable<BoundsInt>>.FindEntry
	|
	|-RVA: 0x30CED70 Offset: 0x30CEE71 VA: 0x30CED70
	|-Dictionary<object, Nullable<Color32>>.FindEntry
	|
	|-RVA: 0x30D2700 Offset: 0x30D2801 VA: 0x30D2700
	|-Dictionary<object, Nullable<Color>>.FindEntry
	|
	|-RVA: 0x3010AD0 Offset: 0x3010BD1 VA: 0x3010AD0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.FindEntry
	|
	|-RVA: 0x3014480 Offset: 0x3014581 VA: 0x3014480
	|-Dictionary<object, Nullable<GradientColorKey>>.FindEntry
	|
	|-RVA: 0x3017FA0 Offset: 0x30180A1 VA: 0x3017FA0
	|-Dictionary<object, Nullable<Keyframe>>.FindEntry
	|
	|-RVA: 0x301B8C0 Offset: 0x301B9C1 VA: 0x301B8C0
	|-Dictionary<object, Nullable<LayerMask>>.FindEntry
	|
	|-RVA: 0x301F570 Offset: 0x301F671 VA: 0x301F570
	|-Dictionary<object, Nullable<Matrix4x4>>.FindEntry
	|
	|-RVA: 0x3023250 Offset: 0x3023351 VA: 0x3023250
	|-Dictionary<object, Nullable<Quaternion>>.FindEntry
	|
	|-RVA: 0x3026BE0 Offset: 0x3026CE1 VA: 0x3026BE0
	|-Dictionary<object, Nullable<RangeInt>>.FindEntry
	|
	|-RVA: 0x302A5A0 Offset: 0x302A6A1 VA: 0x302A5A0
	|-Dictionary<object, Nullable<Rect>>.FindEntry
	|
	|-RVA: 0x2FD7B80 Offset: 0x2FD7C81 VA: 0x2FD7B80
	|-Dictionary<object, Nullable<RectInt>>.FindEntry
	|
	|-RVA: 0x2FDB510 Offset: 0x2FDB611 VA: 0x2FDB510
	|-Dictionary<object, Nullable<Vector2>>.FindEntry
	|
	|-RVA: 0x2FDED60 Offset: 0x2FDEE61 VA: 0x2FDED60
	|-Dictionary<object, Nullable<Vector2Int>>.FindEntry
	|
	|-RVA: 0x2FE25A0 Offset: 0x2FE26A1 VA: 0x2FE25A0
	|-Dictionary<object, Nullable<Vector3>>.FindEntry
	|
	|-RVA: 0x2FE5D90 Offset: 0x2FE5E91 VA: 0x2FE5D90
	|-Dictionary<object, Nullable<Vector3Int>>.FindEntry
	|
	|-RVA: 0x2FE9700 Offset: 0x2FE9801 VA: 0x2FE9700
	|-Dictionary<object, Nullable<Vector4>>.FindEntry
	|
	|-RVA: 0x2FECFB0 Offset: 0x2FED0B1 VA: 0x2FECFB0
	|-Dictionary<object, object>.FindEntry
	|
	|-RVA: 0x2FF05C0 Offset: 0x2FF06C1 VA: 0x2FF05C0
	|-Dictionary<object, ReadOnlyMemory<object>>.FindEntry
	|
	|-RVA: 0x2DBF070 Offset: 0x2DBF171 VA: 0x2DBF070
	|-Dictionary<object, ResourceLocator>.FindEntry
	|
	|-RVA: 0x2DC2730 Offset: 0x2DC2831 VA: 0x2DC2730
	|-Dictionary<object, sbyte>.FindEntry
	|
	|-RVA: 0x2DC5DF0 Offset: 0x2DC5EF1 VA: 0x2DC5DF0
	|-Dictionary<object, float>.FindEntry
	|
	|-RVA: 0x2DC94B0 Offset: 0x2DC95B1 VA: 0x2DC94B0
	|-Dictionary<object, ushort>.FindEntry
	|
	|-RVA: 0x2DCCB70 Offset: 0x2DCCC71 VA: 0x2DCCB70
	|-Dictionary<object, uint>.FindEntry
	|
	|-RVA: 0x2DD0230 Offset: 0x2DD0331 VA: 0x2DD0230
	|-Dictionary<object, ulong>.FindEntry
	|
	|-RVA: 0x2DD3AD0 Offset: 0x2DD3BD1 VA: 0x2DD3AD0
	|-Dictionary<object, TransitionTables>.FindEntry
	|
	|-RVA: 0x2DD74C0 Offset: 0x2DD75C1 VA: 0x2DD74C0
	|-Dictionary<object, Bounds>.FindEntry
	|
	|-RVA: 0x2DDAE80 Offset: 0x2DDAF81 VA: 0x2DDAE80
	|-Dictionary<object, BoundsInt>.FindEntry
	|
	|-RVA: 0x30D5F60 Offset: 0x30D6061 VA: 0x30D5F60
	|-Dictionary<object, Color32>.FindEntry
	|
	|-RVA: 0x30D9690 Offset: 0x30D9791 VA: 0x30D9690
	|-Dictionary<object, Color>.FindEntry
	|
	|-RVA: 0x30DCD60 Offset: 0x30DCE61 VA: 0x30DCD60
	|-Dictionary<object, GradientAlphaKey>.FindEntry
	|
	|-RVA: 0x30E0600 Offset: 0x30E0701 VA: 0x30E0600
	|-Dictionary<object, GradientColorKey>.FindEntry
	|
	|-RVA: 0x30E40A0 Offset: 0x30E41A1 VA: 0x30E40A0
	|-Dictionary<object, Keyframe>.FindEntry
	|
	|-RVA: 0x30E7940 Offset: 0x30E7A41 VA: 0x30E7940
	|-Dictionary<object, LayerMask>.FindEntry
	|
	|-RVA: 0x30EB3A0 Offset: 0x30EB4A1 VA: 0x30EB3A0
	|-Dictionary<object, Matrix4x4>.FindEntry
	|
	|-RVA: 0x30EED10 Offset: 0x30EEE11 VA: 0x30EED10
	|-Dictionary<object, Playable>.FindEntry
	|
	|-RVA: 0x309DB20 Offset: 0x309DC21 VA: 0x309DB20
	|-Dictionary<object, Quaternion>.FindEntry
	|
	|-RVA: 0x30A11D0 Offset: 0x30A12D1 VA: 0x30A11D0
	|-Dictionary<object, RangeInt>.FindEntry
	|
	|-RVA: 0x30A48F0 Offset: 0x30A49F1 VA: 0x30A48F0
	|-Dictionary<object, Rect>.FindEntry
	|
	|-RVA: 0x30A8000 Offset: 0x30A8101 VA: 0x30A8000
	|-Dictionary<object, RectInt>.FindEntry
	|
	|-RVA: 0x30AB850 Offset: 0x30AB951 VA: 0x30AB850
	|-Dictionary<object, AsyncOperationHandle>.FindEntry
	|
	|-RVA: 0x30AF220 Offset: 0x30AF321 VA: 0x30AF220
	|-Dictionary<object, AsyncOperationHandle<object>>.FindEntry
	|
	|-RVA: 0x30B2A50 Offset: 0x30B2B51 VA: 0x30B2A50
	|-Dictionary<object, Vector2>.FindEntry
	|
	|-RVA: 0x30B6120 Offset: 0x30B6221 VA: 0x30B6120
	|-Dictionary<object, Vector2Int>.FindEntry
	|
	|-RVA: 0x3081E10 Offset: 0x3081F11 VA: 0x3081E10
	|-Dictionary<object, Vector3>.FindEntry
	|
	|-RVA: 0x3085530 Offset: 0x3085631 VA: 0x3085530
	|-Dictionary<object, Vector3Int>.FindEntry
	|
	|-RVA: 0x3088C60 Offset: 0x3088D61 VA: 0x3088C60
	|-Dictionary<object, Vector4>.FindEntry
	|
	|-RVA: 0x308C3C0 Offset: 0x308C4C1 VA: 0x308C3C0
	|-Dictionary<ReadOnlyMemory<object>, object>.FindEntry
	|
	|-RVA: 0x308F990 Offset: 0x308FA91 VA: 0x308F990
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.FindEntry
	|
	|-RVA: 0x3093080 Offset: 0x3093181 VA: 0x3093080
	|-Dictionary<sbyte, object>.FindEntry
	|
	|-RVA: 0x3096B10 Offset: 0x3096C11 VA: 0x3096B10
	|-Dictionary<float, CurveSample>.FindEntry
	|
	|-RVA: 0x309A500 Offset: 0x309A601 VA: 0x309A500
	|-Dictionary<float, object>.FindEntry
	|
	|-RVA: 0x319DA50 Offset: 0x319DB51 VA: 0x319DA50
	|-Dictionary<ushort, object>.FindEntry
	|
	|-RVA: 0x31A0FE0 Offset: 0x31A10E1 VA: 0x31A0FE0
	|-Dictionary<uint, int>.FindEntry
	|
	|-RVA: 0x31A45A0 Offset: 0x31A46A1 VA: 0x31A45A0
	|-Dictionary<uint, Int32Enum>.FindEntry
	|
	|-RVA: 0x31A7BF0 Offset: 0x31A7CF1 VA: 0x31A7BF0
	|-Dictionary<uint, object>.FindEntry
	|
	|-RVA: 0x31AB210 Offset: 0x31AB311 VA: 0x31AB210
	|-Dictionary<ulong, object>.FindEntry
	|
	|-RVA: 0x31AE7C0 Offset: 0x31AE8C1 VA: 0x31AE7C0
	|-Dictionary<EdgeKeyByHash, int>.FindEntry
	|
	|-RVA: 0x31B2150 Offset: 0x31B2251 VA: 0x31B2150
	|-Dictionary<EdgeKeyByHash, CapEdge>.FindEntry
	|
	|-RVA: 0x31B5CD0 Offset: 0x31B5DD1 VA: 0x31B5CD0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.FindEntry
	|
	|-RVA: 0x302DFC0 Offset: 0x302E0C1 VA: 0x302DFC0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.FindEntry
	|
	|-RVA: 0x30317A0 Offset: 0x30318A1 VA: 0x30317A0
	|-Dictionary<MeshDataConnectivity.Face, bool>.FindEntry
	|
	|-RVA: 0x3034E90 Offset: 0x3034F91 VA: 0x3034E90
	|-Dictionary<MeshDataConnectivity.Face, object>.FindEntry
	|
	|-RVA: 0x3038660 Offset: 0x3038761 VA: 0x3038660
	|-Dictionary<Bounds, object>.FindEntry
	|
	|-RVA: 0x303C190 Offset: 0x303C291 VA: 0x303C190
	|-Dictionary<BoundsInt, object>.FindEntry
	|
	|-RVA: 0x303FB90 Offset: 0x303FC91 VA: 0x303FB90
	|-Dictionary<Color, object>.FindEntry
	|
	|-RVA: 0x3043280 Offset: 0x3043381 VA: 0x3043280
	|-Dictionary<Color32, object>.FindEntry
	|
	|-RVA: 0x30468D0 Offset: 0x30469D1 VA: 0x30468D0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.FindEntry
	|
	|-RVA: 0x3065440 Offset: 0x3065541 VA: 0x3065440
	|-Dictionary<GradientAlphaKey, object>.FindEntry
	|
	|-RVA: 0x3068C30 Offset: 0x3068D31 VA: 0x3068C30
	|-Dictionary<GradientColorKey, object>.FindEntry
	|
	|-RVA: 0x306C810 Offset: 0x306C911 VA: 0x306C810
	|-Dictionary<Keyframe, object>.FindEntry
	|
	|-RVA: 0x3070340 Offset: 0x3070441 VA: 0x3070340
	|-Dictionary<LayerMask, object>.FindEntry
	|
	|-RVA: 0x3073CD0 Offset: 0x3073DD1 VA: 0x3073CD0
	|-Dictionary<Matrix4x4, object>.FindEntry
	|
	|-RVA: 0x3077A10 Offset: 0x3077B11 VA: 0x3077A10
	|-Dictionary<IntVec3, object>.FindEntry
	|
	|-RVA: 0x307B100 Offset: 0x307B201 VA: 0x307B100
	|-Dictionary<Quaternion, object>.FindEntry
	|
	|-RVA: 0x307E7E0 Offset: 0x307E8E1 VA: 0x307E7E0
	|-Dictionary<RangeInt, object>.FindEntry
	|
	|-RVA: 0x3049F70 Offset: 0x304A071 VA: 0x3049F70
	|-Dictionary<Rect, object>.FindEntry
	|
	|-RVA: 0x304D6B0 Offset: 0x304D7B1 VA: 0x304D6B0
	|-Dictionary<RectInt, object>.FindEntry
	|
	|-RVA: 0x3050C60 Offset: 0x3050D61 VA: 0x3050C60
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.FindEntry
	|
	|-RVA: 0x3054340 Offset: 0x3054441 VA: 0x3054340
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.FindEntry
	|
	|-RVA: 0x30579A0 Offset: 0x3057AA1 VA: 0x30579A0
	|-Dictionary<Vector2, object>.FindEntry
	|
	|-RVA: 0x305AFE0 Offset: 0x305B0E1 VA: 0x305AFE0
	|-Dictionary<Vector2Int, object>.FindEntry
	|
	|-RVA: 0x305E680 Offset: 0x305E781 VA: 0x305E680
	|-Dictionary<Vector3, object>.FindEntry
	|
	|-RVA: 0x3061D60 Offset: 0x3061E61 VA: 0x3061D60
	|-Dictionary<Vector3Int, object>.FindEntry
	|
	|-RVA: 0x2E3B760 Offset: 0x2E3B861 VA: 0x2E3B760
	|-Dictionary<Vector4, object>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A17340 Offset: 0x2A17441 VA: 0x2A17340
	|-Dictionary<JSONDeserialization.TaskField, object>.Initialize
	|
	|-RVA: 0x2A1A970 Offset: 0x2A1AA71 VA: 0x2A1A970
	|-Dictionary<BitVector32Int, object>.Initialize
	|
	|-RVA: 0x2F79900 Offset: 0x2F79A01 VA: 0x2F79900
	|-Dictionary<EventCheckId, object>.Initialize
	|
	|-RVA: 0x2F7D6B0 Offset: 0x2F7D7B1 VA: 0x2F7D6B0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.Initialize
	|
	|-RVA: 0x2F81500 Offset: 0x2F81601 VA: 0x2F81500
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.Initialize
	|
	|-RVA: 0x2F84E70 Offset: 0x2F84F71 VA: 0x2F84E70
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.Initialize
	|
	|-RVA: 0x2F88570 Offset: 0x2F88671 VA: 0x2F88570
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.Initialize
	|
	|-RVA: 0x2F8BEC0 Offset: 0x2F8BFC1 VA: 0x2F8BEC0
	|-Dictionary<MonsterHutSaveData, object>.Initialize
	|
	|-RVA: 0x2F8F990 Offset: 0x2F8FA91 VA: 0x2F8F990
	|-Dictionary<OrderLotterySaveParameter, object>.Initialize
	|
	|-RVA: 0x2F93360 Offset: 0x2F93461 VA: 0x2F93360
	|-Dictionary<OrderSaveData, object>.Initialize
	|
	|-RVA: 0x2D81390 Offset: 0x2D81491 VA: 0x2D81390
	|-Dictionary<OrderSaveParameter, object>.Initialize
	|
	|-RVA: 0x2D85020 Offset: 0x2D85121 VA: 0x2D85020
	|-Dictionary<Parameter, object>.Initialize
	|
	|-RVA: 0x2D88A20 Offset: 0x2D88B21 VA: 0x2D88A20
	|-Dictionary<bool, object>.Initialize
	|
	|-RVA: 0x2D8C070 Offset: 0x2D8C171 VA: 0x2D8C070
	|-Dictionary<byte, object>.Initialize
	|
	|-RVA: 0x2D8F690 Offset: 0x2D8F791 VA: 0x2D8F690
	|-Dictionary<char, object>.Initialize
	|
	|-RVA: 0x2D92CB0 Offset: 0x2D92DB1 VA: 0x2D92CB0
	|-Dictionary<DateTime, object>.Initialize
	|
	|-RVA: 0x2D962F0 Offset: 0x2D963F1 VA: 0x2D962F0
	|-Dictionary<double, object>.Initialize
	|
	|-RVA: 0x2D99960 Offset: 0x2D99A61 VA: 0x2D99960
	|-Dictionary<Guid, object>.Initialize
	|
	|-RVA: 0x2D9CF60 Offset: 0x2D9D061 VA: 0x2D9CF60
	|-Dictionary<short, object>.Initialize
	|
	|-RVA: 0x2D3B400 Offset: 0x2D3B501 VA: 0x2D3B400
	|-Dictionary<int, CropDataTable>.Initialize
	|
	|-RVA: 0x2D3EEB0 Offset: 0x2D3EFB1 VA: 0x2D3EEB0
	|-Dictionary<int, EffectDataTable>.Initialize
	|
	|-RVA: 0x2D42620 Offset: 0x2D42721 VA: 0x2D42620
	|-Dictionary<int, GimmickLayoutDataTable>.Initialize
	|
	|-RVA: 0x2D45FC0 Offset: 0x2D460C1 VA: 0x2D45FC0
	|-Dictionary<int, MineTypeDataTable>.Initialize
	|
	|-RVA: 0x2D49940 Offset: 0x2D49A41 VA: 0x2D49940
	|-Dictionary<int, MiningDataTable>.Initialize
	|
	|-RVA: 0x2D4CF90 Offset: 0x2D4D091 VA: 0x2D4CF90
	|-Dictionary<int, bool>.Initialize
	|
	|-RVA: 0x2D50560 Offset: 0x2D50661 VA: 0x2D50560
	|-Dictionary<int, char>.Initialize
	|
	|-RVA: 0x2D53B20 Offset: 0x2D53C21 VA: 0x2D53B20
	|-Dictionary<int, int>.Initialize
	|
	|-RVA: 0x2D570E0 Offset: 0x2D571E1 VA: 0x2D570E0
	|-Dictionary<int, Int32Enum>.Initialize
	|
	|-RVA: 0x2F5D210 Offset: 0x2F5D311 VA: 0x2F5D210
	|-Dictionary<int, long>.Initialize
	|
	|-RVA: 0x2F60900 Offset: 0x2F60A01 VA: 0x2F60900
	|-Dictionary<int, object>.Initialize
	|
	|-RVA: 0x2F641A0 Offset: 0x2F642A1 VA: 0x2F641A0
	|-Dictionary<int, DiagnosticEvent>.Initialize
	|
	|-RVA: 0x2F67A40 Offset: 0x2F67B41 VA: 0x2F67A40
	|-Dictionary<int, SceneInstance>.Initialize
	|
	|-RVA: 0x2F6B0B0 Offset: 0x2F6B1B1 VA: 0x2F6B0B0
	|-Dictionary<int, Vector2Int>.Initialize
	|
	|-RVA: 0x2F6E790 Offset: 0x2F6E891 VA: 0x2F6E790
	|-Dictionary<int, Vector3>.Initialize
	|
	|-RVA: 0x2F721F0 Offset: 0x2F722F1 VA: 0x2F721F0
	|-Dictionary<Int32Enum, MonsterDataTable>.Initialize
	|
	|-RVA: 0x2F75E10 Offset: 0x2F75F11 VA: 0x2F75E10
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.Initialize
	|
	|-RVA: 0x2E1D0D0 Offset: 0x2E1D1D1 VA: 0x2E1D0D0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Initialize
	|
	|-RVA: 0x2E20770 Offset: 0x2E20871 VA: 0x2E20770
	|-Dictionary<Int32Enum, bool>.Initialize
	|
	|-RVA: 0x2E23D70 Offset: 0x2E23E71 VA: 0x2E23D70
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.Initialize
	|
	|-RVA: 0x2E273C0 Offset: 0x2E274C1 VA: 0x2E273C0
	|-Dictionary<Int32Enum, int>.Initialize
	|
	|-RVA: 0x2E2A980 Offset: 0x2E2AA81 VA: 0x2E2A980
	|-Dictionary<Int32Enum, Int32Enum>.Initialize
	|
	|-RVA: 0x2E2DFD0 Offset: 0x2E2E0D1 VA: 0x2E2DFD0
	|-Dictionary<Int32Enum, object>.Initialize
	|
	|-RVA: 0x2E31560 Offset: 0x2E31661 VA: 0x2E31560
	|-Dictionary<Int32Enum, float>.Initialize
	|
	|-RVA: 0x2E34BB0 Offset: 0x2E34CB1 VA: 0x2E34BB0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.Initialize
	|
	|-RVA: 0x2E38230 Offset: 0x2E38331 VA: 0x2E38230
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.Initialize
	|
	|-RVA: 0x2F96D90 Offset: 0x2F96E91 VA: 0x2F96D90
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.Initialize
	|
	|-RVA: 0x2F9A4F0 Offset: 0x2F9A5F1 VA: 0x2F9A4F0
	|-Dictionary<long, object>.Initialize
	|
	|-RVA: 0x2F9DB90 Offset: 0x2F9DC91 VA: 0x2F9DB90
	|-Dictionary<Memory<object>, object>.Initialize
	|
	|-RVA: 0x2FA1220 Offset: 0x2FA1321 VA: 0x2FA1220
	|-Dictionary<Nullable<Int32Enum>, object>.Initialize
	|
	|-RVA: 0x2FA4D50 Offset: 0x2FA4E51 VA: 0x2FA4D50
	|-Dictionary<Nullable<Bounds>, object>.Initialize
	|
	|-RVA: 0x2FA8CB0 Offset: 0x2FA8DB1 VA: 0x2FA8CB0
	|-Dictionary<Nullable<BoundsInt>, object>.Initialize
	|
	|-RVA: 0x2FAC8C0 Offset: 0x2FAC9C1 VA: 0x2FAC8C0
	|-Dictionary<Nullable<Color32>, object>.Initialize
	|
	|-RVA: 0x2FB02F0 Offset: 0x2FB03F1 VA: 0x2FB02F0
	|-Dictionary<Nullable<Color>, object>.Initialize
	|
	|-RVA: 0x2F1B220 Offset: 0x2F1B321 VA: 0x2F1B220
	|-Dictionary<Nullable<GradientAlphaKey>, object>.Initialize
	|
	|-RVA: 0x2F1ECB0 Offset: 0x2F1EDB1 VA: 0x2F1ECB0
	|-Dictionary<Nullable<GradientColorKey>, object>.Initialize
	|
	|-RVA: 0x2F229D0 Offset: 0x2F22AD1 VA: 0x2F229D0
	|-Dictionary<Nullable<Keyframe>, object>.Initialize
	|
	|-RVA: 0x2F26490 Offset: 0x2F26591 VA: 0x2F26490
	|-Dictionary<Nullable<LayerMask>, object>.Initialize
	|
	|-RVA: 0x2F2A270 Offset: 0x2F2A371 VA: 0x2F2A270
	|-Dictionary<Nullable<Matrix4x4>, object>.Initialize
	|
	|-RVA: 0x2F2E430 Offset: 0x2F2E531 VA: 0x2F2E430
	|-Dictionary<Nullable<Quaternion>, object>.Initialize
	|
	|-RVA: 0x2F31F70 Offset: 0x2F32071 VA: 0x2F31F70
	|-Dictionary<Nullable<RangeInt>, object>.Initialize
	|
	|-RVA: 0x2F35A00 Offset: 0x2F35B01 VA: 0x2F35A00
	|-Dictionary<Nullable<Rect>, object>.Initialize
	|
	|-RVA: 0x2EFE710 Offset: 0x2EFE811 VA: 0x2EFE710
	|-Dictionary<Nullable<RectInt>, object>.Initialize
	|
	|-RVA: 0x2F02250 Offset: 0x2F02351 VA: 0x2F02250
	|-Dictionary<Nullable<Vector2>, object>.Initialize
	|
	|-RVA: 0x2F05B20 Offset: 0x2F05C21 VA: 0x2F05B20
	|-Dictionary<Nullable<Vector2Int>, object>.Initialize
	|
	|-RVA: 0x2F093D0 Offset: 0x2F094D1 VA: 0x2F093D0
	|-Dictionary<Nullable<Vector3>, object>.Initialize
	|
	|-RVA: 0x2F0CC10 Offset: 0x2F0CD11 VA: 0x2F0CC10
	|-Dictionary<Nullable<Vector3Int>, object>.Initialize
	|
	|-RVA: 0x2F10630 Offset: 0x2F10731 VA: 0x2F10630
	|-Dictionary<Nullable<Vector4>, object>.Initialize
	|
	|-RVA: 0x2F14050 Offset: 0x2F14151 VA: 0x2F14050
	|-Dictionary<object, BitVector32Int>.Initialize
	|
	|-RVA: 0x2F178D0 Offset: 0x2F179D1 VA: 0x2F178D0
	|-Dictionary<object, EventCheckId>.Initialize
	|
	|-RVA: 0x2FF42E0 Offset: 0x2FF43E1 VA: 0x2FF42E0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.Initialize
	|
	|-RVA: 0x2FF7E00 Offset: 0x2FF7F01 VA: 0x2FF7E00
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.Initialize
	|
	|-RVA: 0x2FFB670 Offset: 0x2FFB771 VA: 0x2FFB670
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.Initialize
	|
	|-RVA: 0x2FFED90 Offset: 0x2FFEE91 VA: 0x2FFED90
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.Initialize
	|
	|-RVA: 0x30026C0 Offset: 0x30027C1 VA: 0x30026C0
	|-Dictionary<object, MonsterHutSaveData>.Initialize
	|
	|-RVA: 0x3005FD0 Offset: 0x30060D1 VA: 0x3005FD0
	|-Dictionary<object, OrderLotterySaveParameter>.Initialize
	|
	|-RVA: 0x3009930 Offset: 0x3009A31 VA: 0x3009930
	|-Dictionary<object, OrderSaveData>.Initialize
	|
	|-RVA: 0x300D3D0 Offset: 0x300D4D1 VA: 0x300D3D0
	|-Dictionary<object, OrderSaveParameter>.Initialize
	|
	|-RVA: 0x2DDEC10 Offset: 0x2DDED11 VA: 0x2DDEC10
	|-Dictionary<object, Parameter>.Initialize
	|
	|-RVA: 0x2DE2570 Offset: 0x2DE2671 VA: 0x2DE2570
	|-Dictionary<object, NumberControl.ValueRange>.Initialize
	|
	|-RVA: 0x2DE5C00 Offset: 0x2DE5D01 VA: 0x2DE5C00
	|-Dictionary<object, bool>.Initialize
	|
	|-RVA: 0x2DE92D0 Offset: 0x2DE93D1 VA: 0x2DE92D0
	|-Dictionary<object, byte>.Initialize
	|
	|-RVA: 0x2DEC990 Offset: 0x2DECA91 VA: 0x2DEC990
	|-Dictionary<object, char>.Initialize
	|
	|-RVA: 0x2DF0050 Offset: 0x2DF0151 VA: 0x2DF0050
	|-Dictionary<object, DateTime>.Initialize
	|
	|-RVA: 0x2DF3700 Offset: 0x2DF3801 VA: 0x2DF3700
	|-Dictionary<object, double>.Initialize
	|
	|-RVA: 0x2DF6DC0 Offset: 0x2DF6EC1 VA: 0x2DF6DC0
	|-Dictionary<object, short>.Initialize
	|
	|-RVA: 0x2DFA480 Offset: 0x2DFA581 VA: 0x2DFA480
	|-Dictionary<object, int>.Initialize
	|
	|-RVA: 0x30B9A40 Offset: 0x30B9B41 VA: 0x30B9A40
	|-Dictionary<object, Int32Enum>.Initialize
	|
	|-RVA: 0x30BD100 Offset: 0x30BD201 VA: 0x30BD100
	|-Dictionary<object, long>.Initialize
	|
	|-RVA: 0x30C0810 Offset: 0x30C0911 VA: 0x30C0810
	|-Dictionary<object, Memory<object>>.Initialize
	|
	|-RVA: 0x30C3F80 Offset: 0x30C4081 VA: 0x30C3F80
	|-Dictionary<object, Nullable<Int32Enum>>.Initialize
	|
	|-RVA: 0x30C79F0 Offset: 0x30C7AF1 VA: 0x30C79F0
	|-Dictionary<object, Nullable<Bounds>>.Initialize
	|
	|-RVA: 0x30CB650 Offset: 0x30CB751 VA: 0x30CB650
	|-Dictionary<object, Nullable<BoundsInt>>.Initialize
	|
	|-RVA: 0x30CEFE0 Offset: 0x30CF0E1 VA: 0x30CEFE0
	|-Dictionary<object, Nullable<Color32>>.Initialize
	|
	|-RVA: 0x30D2970 Offset: 0x30D2A71 VA: 0x30D2970
	|-Dictionary<object, Nullable<Color>>.Initialize
	|
	|-RVA: 0x3010D40 Offset: 0x3010E41 VA: 0x3010D40
	|-Dictionary<object, Nullable<GradientAlphaKey>>.Initialize
	|
	|-RVA: 0x30146F0 Offset: 0x30147F1 VA: 0x30146F0
	|-Dictionary<object, Nullable<GradientColorKey>>.Initialize
	|
	|-RVA: 0x3018210 Offset: 0x3018311 VA: 0x3018210
	|-Dictionary<object, Nullable<Keyframe>>.Initialize
	|
	|-RVA: 0x301BB30 Offset: 0x301BC31 VA: 0x301BB30
	|-Dictionary<object, Nullable<LayerMask>>.Initialize
	|
	|-RVA: 0x301F7E0 Offset: 0x301F8E1 VA: 0x301F7E0
	|-Dictionary<object, Nullable<Matrix4x4>>.Initialize
	|
	|-RVA: 0x30234C0 Offset: 0x30235C1 VA: 0x30234C0
	|-Dictionary<object, Nullable<Quaternion>>.Initialize
	|
	|-RVA: 0x3026E50 Offset: 0x3026F51 VA: 0x3026E50
	|-Dictionary<object, Nullable<RangeInt>>.Initialize
	|
	|-RVA: 0x302A810 Offset: 0x302A911 VA: 0x302A810
	|-Dictionary<object, Nullable<Rect>>.Initialize
	|
	|-RVA: 0x2FD7DF0 Offset: 0x2FD7EF1 VA: 0x2FD7DF0
	|-Dictionary<object, Nullable<RectInt>>.Initialize
	|
	|-RVA: 0x2FDB780 Offset: 0x2FDB881 VA: 0x2FDB780
	|-Dictionary<object, Nullable<Vector2>>.Initialize
	|
	|-RVA: 0x2FDEFD0 Offset: 0x2FDF0D1 VA: 0x2FDEFD0
	|-Dictionary<object, Nullable<Vector2Int>>.Initialize
	|
	|-RVA: 0x2FE2810 Offset: 0x2FE2911 VA: 0x2FE2810
	|-Dictionary<object, Nullable<Vector3>>.Initialize
	|
	|-RVA: 0x2FE6000 Offset: 0x2FE6101 VA: 0x2FE6000
	|-Dictionary<object, Nullable<Vector3Int>>.Initialize
	|
	|-RVA: 0x2FE9970 Offset: 0x2FE9A71 VA: 0x2FE9970
	|-Dictionary<object, Nullable<Vector4>>.Initialize
	|
	|-RVA: 0x2FED220 Offset: 0x2FED321 VA: 0x2FED220
	|-Dictionary<object, object>.Initialize
	|
	|-RVA: 0x2FF0830 Offset: 0x2FF0931 VA: 0x2FF0830
	|-Dictionary<object, ReadOnlyMemory<object>>.Initialize
	|
	|-RVA: 0x2DBF2E0 Offset: 0x2DBF3E1 VA: 0x2DBF2E0
	|-Dictionary<object, ResourceLocator>.Initialize
	|
	|-RVA: 0x2DC29A0 Offset: 0x2DC2AA1 VA: 0x2DC29A0
	|-Dictionary<object, sbyte>.Initialize
	|
	|-RVA: 0x2DC6060 Offset: 0x2DC6161 VA: 0x2DC6060
	|-Dictionary<object, float>.Initialize
	|
	|-RVA: 0x2DC9720 Offset: 0x2DC9821 VA: 0x2DC9720
	|-Dictionary<object, ushort>.Initialize
	|
	|-RVA: 0x2DCCDE0 Offset: 0x2DCCEE1 VA: 0x2DCCDE0
	|-Dictionary<object, uint>.Initialize
	|
	|-RVA: 0x2DD04A0 Offset: 0x2DD05A1 VA: 0x2DD04A0
	|-Dictionary<object, ulong>.Initialize
	|
	|-RVA: 0x2DD3D40 Offset: 0x2DD3E41 VA: 0x2DD3D40
	|-Dictionary<object, TransitionTables>.Initialize
	|
	|-RVA: 0x2DD7730 Offset: 0x2DD7831 VA: 0x2DD7730
	|-Dictionary<object, Bounds>.Initialize
	|
	|-RVA: 0x2DDB0F0 Offset: 0x2DDB1F1 VA: 0x2DDB0F0
	|-Dictionary<object, BoundsInt>.Initialize
	|
	|-RVA: 0x30D61D0 Offset: 0x30D62D1 VA: 0x30D61D0
	|-Dictionary<object, Color32>.Initialize
	|
	|-RVA: 0x30D9900 Offset: 0x30D9A01 VA: 0x30D9900
	|-Dictionary<object, Color>.Initialize
	|
	|-RVA: 0x30DCFD0 Offset: 0x30DD0D1 VA: 0x30DCFD0
	|-Dictionary<object, GradientAlphaKey>.Initialize
	|
	|-RVA: 0x30E0870 Offset: 0x30E0971 VA: 0x30E0870
	|-Dictionary<object, GradientColorKey>.Initialize
	|
	|-RVA: 0x30E4310 Offset: 0x30E4411 VA: 0x30E4310
	|-Dictionary<object, Keyframe>.Initialize
	|
	|-RVA: 0x30E7BB0 Offset: 0x30E7CB1 VA: 0x30E7BB0
	|-Dictionary<object, LayerMask>.Initialize
	|
	|-RVA: 0x30EB610 Offset: 0x30EB711 VA: 0x30EB610
	|-Dictionary<object, Matrix4x4>.Initialize
	|
	|-RVA: 0x30EEF80 Offset: 0x30EF081 VA: 0x30EEF80
	|-Dictionary<object, Playable>.Initialize
	|
	|-RVA: 0x309DD90 Offset: 0x309DE91 VA: 0x309DD90
	|-Dictionary<object, Quaternion>.Initialize
	|
	|-RVA: 0x30A1440 Offset: 0x30A1541 VA: 0x30A1440
	|-Dictionary<object, RangeInt>.Initialize
	|
	|-RVA: 0x30A4B60 Offset: 0x30A4C61 VA: 0x30A4B60
	|-Dictionary<object, Rect>.Initialize
	|
	|-RVA: 0x30A8270 Offset: 0x30A8371 VA: 0x30A8270
	|-Dictionary<object, RectInt>.Initialize
	|
	|-RVA: 0x30ABAC0 Offset: 0x30ABBC1 VA: 0x30ABAC0
	|-Dictionary<object, AsyncOperationHandle>.Initialize
	|
	|-RVA: 0x30AF490 Offset: 0x30AF591 VA: 0x30AF490
	|-Dictionary<object, AsyncOperationHandle<object>>.Initialize
	|
	|-RVA: 0x30B2CC0 Offset: 0x30B2DC1 VA: 0x30B2CC0
	|-Dictionary<object, Vector2>.Initialize
	|
	|-RVA: 0x30B6390 Offset: 0x30B6491 VA: 0x30B6390
	|-Dictionary<object, Vector2Int>.Initialize
	|
	|-RVA: 0x3082080 Offset: 0x3082181 VA: 0x3082080
	|-Dictionary<object, Vector3>.Initialize
	|
	|-RVA: 0x30857A0 Offset: 0x30858A1 VA: 0x30857A0
	|-Dictionary<object, Vector3Int>.Initialize
	|
	|-RVA: 0x3088ED0 Offset: 0x3088FD1 VA: 0x3088ED0
	|-Dictionary<object, Vector4>.Initialize
	|
	|-RVA: 0x308C610 Offset: 0x308C711 VA: 0x308C610
	|-Dictionary<ReadOnlyMemory<object>, object>.Initialize
	|
	|-RVA: 0x308FBC0 Offset: 0x308FCC1 VA: 0x308FBC0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.Initialize
	|
	|-RVA: 0x30932B0 Offset: 0x30933B1 VA: 0x30932B0
	|-Dictionary<sbyte, object>.Initialize
	|
	|-RVA: 0x3096D50 Offset: 0x3096E51 VA: 0x3096D50
	|-Dictionary<float, CurveSample>.Initialize
	|
	|-RVA: 0x309A740 Offset: 0x309A841 VA: 0x309A740
	|-Dictionary<float, object>.Initialize
	|
	|-RVA: 0x319DC80 Offset: 0x319DD81 VA: 0x319DC80
	|-Dictionary<ushort, object>.Initialize
	|
	|-RVA: 0x31A1210 Offset: 0x31A1311 VA: 0x31A1210
	|-Dictionary<uint, int>.Initialize
	|
	|-RVA: 0x31A47D0 Offset: 0x31A48D1 VA: 0x31A47D0
	|-Dictionary<uint, Int32Enum>.Initialize
	|
	|-RVA: 0x31A7E20 Offset: 0x31A7F21 VA: 0x31A7E20
	|-Dictionary<uint, object>.Initialize
	|
	|-RVA: 0x31AB440 Offset: 0x31AB541 VA: 0x31AB440
	|-Dictionary<ulong, object>.Initialize
	|
	|-RVA: 0x31AE9F0 Offset: 0x31AEAF1 VA: 0x31AE9F0
	|-Dictionary<EdgeKeyByHash, int>.Initialize
	|
	|-RVA: 0x31B2380 Offset: 0x31B2481 VA: 0x31B2380
	|-Dictionary<EdgeKeyByHash, CapEdge>.Initialize
	|
	|-RVA: 0x31B5F00 Offset: 0x31B6001 VA: 0x31B5F00
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Initialize
	|
	|-RVA: 0x302E1F0 Offset: 0x302E2F1 VA: 0x302E1F0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.Initialize
	|
	|-RVA: 0x30319D0 Offset: 0x3031AD1 VA: 0x30319D0
	|-Dictionary<MeshDataConnectivity.Face, bool>.Initialize
	|
	|-RVA: 0x30350C0 Offset: 0x30351C1 VA: 0x30350C0
	|-Dictionary<MeshDataConnectivity.Face, object>.Initialize
	|
	|-RVA: 0x3038930 Offset: 0x3038A31 VA: 0x3038930
	|-Dictionary<Bounds, object>.Initialize
	|
	|-RVA: 0x303C460 Offset: 0x303C561 VA: 0x303C460
	|-Dictionary<BoundsInt, object>.Initialize
	|
	|-RVA: 0x303FE10 Offset: 0x303FF11 VA: 0x303FE10
	|-Dictionary<Color, object>.Initialize
	|
	|-RVA: 0x30434C0 Offset: 0x30435C1 VA: 0x30434C0
	|-Dictionary<Color32, object>.Initialize
	|
	|-RVA: 0x3046B00 Offset: 0x3046C01 VA: 0x3046B00
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Initialize
	|
	|-RVA: 0x3065690 Offset: 0x3065791 VA: 0x3065690
	|-Dictionary<GradientAlphaKey, object>.Initialize
	|
	|-RVA: 0x3068F00 Offset: 0x3069001 VA: 0x3068F00
	|-Dictionary<GradientColorKey, object>.Initialize
	|
	|-RVA: 0x306CB30 Offset: 0x306CC31 VA: 0x306CB30
	|-Dictionary<Keyframe, object>.Initialize
	|
	|-RVA: 0x3070580 Offset: 0x3070681 VA: 0x3070580
	|-Dictionary<LayerMask, object>.Initialize
	|
	|-RVA: 0x3074030 Offset: 0x3074131 VA: 0x3074030
	|-Dictionary<Matrix4x4, object>.Initialize
	|
	|-RVA: 0x3077C70 Offset: 0x3077D71 VA: 0x3077C70
	|-Dictionary<IntVec3, object>.Initialize
	|
	|-RVA: 0x307B380 Offset: 0x307B481 VA: 0x307B380
	|-Dictionary<Quaternion, object>.Initialize
	|
	|-RVA: 0x307EA10 Offset: 0x307EB11 VA: 0x307EA10
	|-Dictionary<RangeInt, object>.Initialize
	|
	|-RVA: 0x304A1F0 Offset: 0x304A2F1 VA: 0x304A1F0
	|-Dictionary<Rect, object>.Initialize
	|
	|-RVA: 0x304D900 Offset: 0x304DA01 VA: 0x304D900
	|-Dictionary<RectInt, object>.Initialize
	|
	|-RVA: 0x3050E90 Offset: 0x3050F91 VA: 0x3050E90
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.Initialize
	|
	|-RVA: 0x3054570 Offset: 0x3054671 VA: 0x3054570
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Initialize
	|
	|-RVA: 0x3057BF0 Offset: 0x3057CF1 VA: 0x3057BF0
	|-Dictionary<Vector2, object>.Initialize
	|
	|-RVA: 0x305B210 Offset: 0x305B311 VA: 0x305B210
	|-Dictionary<Vector2Int, object>.Initialize
	|
	|-RVA: 0x305E8E0 Offset: 0x305E9E1 VA: 0x305E8E0
	|-Dictionary<Vector3, object>.Initialize
	|
	|-RVA: 0x3061FB0 Offset: 0x30620B1 VA: 0x3061FB0
	|-Dictionary<Vector3Int, object>.Initialize
	|
	|-RVA: 0x2E3B9E0 Offset: 0x2E3BAE1 VA: 0x2E3B9E0
	|-Dictionary<Vector4, object>.Initialize
	*/

	// RVA: -1 Offset: -1
	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A17480 Offset: 0x2A17581 VA: 0x2A17480
	|-Dictionary<JSONDeserialization.TaskField, object>.TryInsert
	|
	|-RVA: 0x2A1AAB0 Offset: 0x2A1ABB1 VA: 0x2A1AAB0
	|-Dictionary<BitVector32Int, object>.TryInsert
	|
	|-RVA: 0x2F79A40 Offset: 0x2F79B41 VA: 0x2F79A40
	|-Dictionary<EventCheckId, object>.TryInsert
	|
	|-RVA: 0x2F7D7F0 Offset: 0x2F7D8F1 VA: 0x2F7D7F0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.TryInsert
	|
	|-RVA: 0x2F81640 Offset: 0x2F81741 VA: 0x2F81640
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.TryInsert
	|
	|-RVA: 0x2F84FB0 Offset: 0x2F850B1 VA: 0x2F84FB0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.TryInsert
	|
	|-RVA: 0x2F886B0 Offset: 0x2F887B1 VA: 0x2F886B0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.TryInsert
	|
	|-RVA: 0x2F8C000 Offset: 0x2F8C101 VA: 0x2F8C000
	|-Dictionary<MonsterHutSaveData, object>.TryInsert
	|
	|-RVA: 0x2F8FAD0 Offset: 0x2F8FBD1 VA: 0x2F8FAD0
	|-Dictionary<OrderLotterySaveParameter, object>.TryInsert
	|
	|-RVA: 0x2F934A0 Offset: 0x2F935A1 VA: 0x2F934A0
	|-Dictionary<OrderSaveData, object>.TryInsert
	|
	|-RVA: 0x2D814D0 Offset: 0x2D815D1 VA: 0x2D814D0
	|-Dictionary<OrderSaveParameter, object>.TryInsert
	|
	|-RVA: 0x2D85160 Offset: 0x2D85261 VA: 0x2D85160
	|-Dictionary<Parameter, object>.TryInsert
	|
	|-RVA: 0x2D88B60 Offset: 0x2D88C61 VA: 0x2D88B60
	|-Dictionary<bool, object>.TryInsert
	|
	|-RVA: 0x2D8C1B0 Offset: 0x2D8C2B1 VA: 0x2D8C1B0
	|-Dictionary<byte, object>.TryInsert
	|
	|-RVA: 0x2D8F7D0 Offset: 0x2D8F8D1 VA: 0x2D8F7D0
	|-Dictionary<char, object>.TryInsert
	|
	|-RVA: 0x2D92DF0 Offset: 0x2D92EF1 VA: 0x2D92DF0
	|-Dictionary<DateTime, object>.TryInsert
	|
	|-RVA: 0x2D96430 Offset: 0x2D96531 VA: 0x2D96430
	|-Dictionary<double, object>.TryInsert
	|
	|-RVA: 0x2D99AA0 Offset: 0x2D99BA1 VA: 0x2D99AA0
	|-Dictionary<Guid, object>.TryInsert
	|
	|-RVA: 0x2D9D0A0 Offset: 0x2D9D1A1 VA: 0x2D9D0A0
	|-Dictionary<short, object>.TryInsert
	|
	|-RVA: 0x2D3B540 Offset: 0x2D3B641 VA: 0x2D3B540
	|-Dictionary<int, CropDataTable>.TryInsert
	|
	|-RVA: 0x2D3EFF0 Offset: 0x2D3F0F1 VA: 0x2D3EFF0
	|-Dictionary<int, EffectDataTable>.TryInsert
	|
	|-RVA: 0x2D42760 Offset: 0x2D42861 VA: 0x2D42760
	|-Dictionary<int, GimmickLayoutDataTable>.TryInsert
	|
	|-RVA: 0x2D46100 Offset: 0x2D46201 VA: 0x2D46100
	|-Dictionary<int, MineTypeDataTable>.TryInsert
	|
	|-RVA: 0x2D49A80 Offset: 0x2D49B81 VA: 0x2D49A80
	|-Dictionary<int, MiningDataTable>.TryInsert
	|
	|-RVA: 0x2D4D0D0 Offset: 0x2D4D1D1 VA: 0x2D4D0D0
	|-Dictionary<int, bool>.TryInsert
	|
	|-RVA: 0x2D506A0 Offset: 0x2D507A1 VA: 0x2D506A0
	|-Dictionary<int, char>.TryInsert
	|
	|-RVA: 0x2D53C60 Offset: 0x2D53D61 VA: 0x2D53C60
	|-Dictionary<int, int>.TryInsert
	|
	|-RVA: 0x2D57220 Offset: 0x2D57321 VA: 0x2D57220
	|-Dictionary<int, Int32Enum>.TryInsert
	|
	|-RVA: 0x2F5D350 Offset: 0x2F5D451 VA: 0x2F5D350
	|-Dictionary<int, long>.TryInsert
	|
	|-RVA: 0x2F60A40 Offset: 0x2F60B41 VA: 0x2F60A40
	|-Dictionary<int, object>.TryInsert
	|
	|-RVA: 0x2F642E0 Offset: 0x2F643E1 VA: 0x2F642E0
	|-Dictionary<int, DiagnosticEvent>.TryInsert
	|
	|-RVA: 0x2F67B80 Offset: 0x2F67C81 VA: 0x2F67B80
	|-Dictionary<int, SceneInstance>.TryInsert
	|
	|-RVA: 0x2F6B1F0 Offset: 0x2F6B2F1 VA: 0x2F6B1F0
	|-Dictionary<int, Vector2Int>.TryInsert
	|
	|-RVA: 0x2F6E8D0 Offset: 0x2F6E9D1 VA: 0x2F6E8D0
	|-Dictionary<int, Vector3>.TryInsert
	|
	|-RVA: 0x2F72330 Offset: 0x2F72431 VA: 0x2F72330
	|-Dictionary<Int32Enum, MonsterDataTable>.TryInsert
	|
	|-RVA: 0x2F75F50 Offset: 0x2F76051 VA: 0x2F75F50
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.TryInsert
	|
	|-RVA: 0x2E1D210 Offset: 0x2E1D311 VA: 0x2E1D210
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.TryInsert
	|
	|-RVA: 0x2E208B0 Offset: 0x2E209B1 VA: 0x2E208B0
	|-Dictionary<Int32Enum, bool>.TryInsert
	|
	|-RVA: 0x2E23EB0 Offset: 0x2E23FB1 VA: 0x2E23EB0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.TryInsert
	|
	|-RVA: 0x2E27500 Offset: 0x2E27601 VA: 0x2E27500
	|-Dictionary<Int32Enum, int>.TryInsert
	|
	|-RVA: 0x2E2AAC0 Offset: 0x2E2ABC1 VA: 0x2E2AAC0
	|-Dictionary<Int32Enum, Int32Enum>.TryInsert
	|
	|-RVA: 0x2E2E110 Offset: 0x2E2E211 VA: 0x2E2E110
	|-Dictionary<Int32Enum, object>.TryInsert
	|
	|-RVA: 0x2E316A0 Offset: 0x2E317A1 VA: 0x2E316A0
	|-Dictionary<Int32Enum, float>.TryInsert
	|
	|-RVA: 0x2E34CF0 Offset: 0x2E34DF1 VA: 0x2E34CF0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.TryInsert
	|
	|-RVA: 0x2E38370 Offset: 0x2E38471 VA: 0x2E38370
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.TryInsert
	|
	|-RVA: 0x2F96ED0 Offset: 0x2F96FD1 VA: 0x2F96ED0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.TryInsert
	|
	|-RVA: 0x2F9A630 Offset: 0x2F9A731 VA: 0x2F9A630
	|-Dictionary<long, object>.TryInsert
	|
	|-RVA: 0x2F9DCD0 Offset: 0x2F9DDD1 VA: 0x2F9DCD0
	|-Dictionary<Memory<object>, object>.TryInsert
	|
	|-RVA: 0x2FA1360 Offset: 0x2FA1461 VA: 0x2FA1360
	|-Dictionary<Nullable<Int32Enum>, object>.TryInsert
	|
	|-RVA: 0x2FA4E90 Offset: 0x2FA4F91 VA: 0x2FA4E90
	|-Dictionary<Nullable<Bounds>, object>.TryInsert
	|
	|-RVA: 0x2FA8DF0 Offset: 0x2FA8EF1 VA: 0x2FA8DF0
	|-Dictionary<Nullable<BoundsInt>, object>.TryInsert
	|
	|-RVA: 0x2FACA00 Offset: 0x2FACB01 VA: 0x2FACA00
	|-Dictionary<Nullable<Color32>, object>.TryInsert
	|
	|-RVA: 0x2FB0430 Offset: 0x2FB0531 VA: 0x2FB0430
	|-Dictionary<Nullable<Color>, object>.TryInsert
	|
	|-RVA: 0x2F1B360 Offset: 0x2F1B461 VA: 0x2F1B360
	|-Dictionary<Nullable<GradientAlphaKey>, object>.TryInsert
	|
	|-RVA: 0x2F1EDF0 Offset: 0x2F1EEF1 VA: 0x2F1EDF0
	|-Dictionary<Nullable<GradientColorKey>, object>.TryInsert
	|
	|-RVA: 0x2F22B10 Offset: 0x2F22C11 VA: 0x2F22B10
	|-Dictionary<Nullable<Keyframe>, object>.TryInsert
	|
	|-RVA: 0x2F265D0 Offset: 0x2F266D1 VA: 0x2F265D0
	|-Dictionary<Nullable<LayerMask>, object>.TryInsert
	|
	|-RVA: 0x2F2A3B0 Offset: 0x2F2A4B1 VA: 0x2F2A3B0
	|-Dictionary<Nullable<Matrix4x4>, object>.TryInsert
	|
	|-RVA: 0x2F2E570 Offset: 0x2F2E671 VA: 0x2F2E570
	|-Dictionary<Nullable<Quaternion>, object>.TryInsert
	|
	|-RVA: 0x2F320B0 Offset: 0x2F321B1 VA: 0x2F320B0
	|-Dictionary<Nullable<RangeInt>, object>.TryInsert
	|
	|-RVA: 0x2F35B40 Offset: 0x2F35C41 VA: 0x2F35B40
	|-Dictionary<Nullable<Rect>, object>.TryInsert
	|
	|-RVA: 0x2EFE850 Offset: 0x2EFE951 VA: 0x2EFE850
	|-Dictionary<Nullable<RectInt>, object>.TryInsert
	|
	|-RVA: 0x2F02390 Offset: 0x2F02491 VA: 0x2F02390
	|-Dictionary<Nullable<Vector2>, object>.TryInsert
	|
	|-RVA: 0x2F05C60 Offset: 0x2F05D61 VA: 0x2F05C60
	|-Dictionary<Nullable<Vector2Int>, object>.TryInsert
	|
	|-RVA: 0x2F09510 Offset: 0x2F09611 VA: 0x2F09510
	|-Dictionary<Nullable<Vector3>, object>.TryInsert
	|
	|-RVA: 0x2F0CD50 Offset: 0x2F0CE51 VA: 0x2F0CD50
	|-Dictionary<Nullable<Vector3Int>, object>.TryInsert
	|
	|-RVA: 0x2F10770 Offset: 0x2F10871 VA: 0x2F10770
	|-Dictionary<Nullable<Vector4>, object>.TryInsert
	|
	|-RVA: 0x2F14190 Offset: 0x2F14291 VA: 0x2F14190
	|-Dictionary<object, BitVector32Int>.TryInsert
	|
	|-RVA: 0x2F17A10 Offset: 0x2F17B11 VA: 0x2F17A10
	|-Dictionary<object, EventCheckId>.TryInsert
	|
	|-RVA: 0x2FF4420 Offset: 0x2FF4521 VA: 0x2FF4420
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.TryInsert
	|
	|-RVA: 0x2FF7F40 Offset: 0x2FF8041 VA: 0x2FF7F40
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.TryInsert
	|
	|-RVA: 0x2FFB7B0 Offset: 0x2FFB8B1 VA: 0x2FFB7B0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.TryInsert
	|
	|-RVA: 0x2FFEED0 Offset: 0x2FFEFD1 VA: 0x2FFEED0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.TryInsert
	|
	|-RVA: 0x3002800 Offset: 0x3002901 VA: 0x3002800
	|-Dictionary<object, MonsterHutSaveData>.TryInsert
	|
	|-RVA: 0x3006110 Offset: 0x3006211 VA: 0x3006110
	|-Dictionary<object, OrderLotterySaveParameter>.TryInsert
	|
	|-RVA: 0x3009A70 Offset: 0x3009B71 VA: 0x3009A70
	|-Dictionary<object, OrderSaveData>.TryInsert
	|
	|-RVA: 0x300D510 Offset: 0x300D611 VA: 0x300D510
	|-Dictionary<object, OrderSaveParameter>.TryInsert
	|
	|-RVA: 0x2DDED50 Offset: 0x2DDEE51 VA: 0x2DDED50
	|-Dictionary<object, Parameter>.TryInsert
	|
	|-RVA: 0x2DE26B0 Offset: 0x2DE27B1 VA: 0x2DE26B0
	|-Dictionary<object, NumberControl.ValueRange>.TryInsert
	|
	|-RVA: 0x2DE5D40 Offset: 0x2DE5E41 VA: 0x2DE5D40
	|-Dictionary<object, bool>.TryInsert
	|
	|-RVA: 0x2DE9410 Offset: 0x2DE9511 VA: 0x2DE9410
	|-Dictionary<object, byte>.TryInsert
	|
	|-RVA: 0x2DECAD0 Offset: 0x2DECBD1 VA: 0x2DECAD0
	|-Dictionary<object, char>.TryInsert
	|
	|-RVA: 0x2DF0190 Offset: 0x2DF0291 VA: 0x2DF0190
	|-Dictionary<object, DateTime>.TryInsert
	|
	|-RVA: 0x2DF3840 Offset: 0x2DF3941 VA: 0x2DF3840
	|-Dictionary<object, double>.TryInsert
	|
	|-RVA: 0x2DF6F00 Offset: 0x2DF7001 VA: 0x2DF6F00
	|-Dictionary<object, short>.TryInsert
	|
	|-RVA: 0x2DFA5C0 Offset: 0x2DFA6C1 VA: 0x2DFA5C0
	|-Dictionary<object, int>.TryInsert
	|
	|-RVA: 0x30B9B80 Offset: 0x30B9C81 VA: 0x30B9B80
	|-Dictionary<object, Int32Enum>.TryInsert
	|
	|-RVA: 0x30BD240 Offset: 0x30BD341 VA: 0x30BD240
	|-Dictionary<object, long>.TryInsert
	|
	|-RVA: 0x30C0950 Offset: 0x30C0A51 VA: 0x30C0950
	|-Dictionary<object, Memory<object>>.TryInsert
	|
	|-RVA: 0x30C40C0 Offset: 0x30C41C1 VA: 0x30C40C0
	|-Dictionary<object, Nullable<Int32Enum>>.TryInsert
	|
	|-RVA: 0x30C7B30 Offset: 0x30C7C31 VA: 0x30C7B30
	|-Dictionary<object, Nullable<Bounds>>.TryInsert
	|
	|-RVA: 0x30CB790 Offset: 0x30CB891 VA: 0x30CB790
	|-Dictionary<object, Nullable<BoundsInt>>.TryInsert
	|
	|-RVA: 0x30CF120 Offset: 0x30CF221 VA: 0x30CF120
	|-Dictionary<object, Nullable<Color32>>.TryInsert
	|
	|-RVA: 0x30D2AB0 Offset: 0x30D2BB1 VA: 0x30D2AB0
	|-Dictionary<object, Nullable<Color>>.TryInsert
	|
	|-RVA: 0x3010E80 Offset: 0x3010F81 VA: 0x3010E80
	|-Dictionary<object, Nullable<GradientAlphaKey>>.TryInsert
	|
	|-RVA: 0x3014830 Offset: 0x3014931 VA: 0x3014830
	|-Dictionary<object, Nullable<GradientColorKey>>.TryInsert
	|
	|-RVA: 0x3018350 Offset: 0x3018451 VA: 0x3018350
	|-Dictionary<object, Nullable<Keyframe>>.TryInsert
	|
	|-RVA: 0x301BC70 Offset: 0x301BD71 VA: 0x301BC70
	|-Dictionary<object, Nullable<LayerMask>>.TryInsert
	|
	|-RVA: 0x301F920 Offset: 0x301FA21 VA: 0x301F920
	|-Dictionary<object, Nullable<Matrix4x4>>.TryInsert
	|
	|-RVA: 0x3023600 Offset: 0x3023701 VA: 0x3023600
	|-Dictionary<object, Nullable<Quaternion>>.TryInsert
	|
	|-RVA: 0x3026F90 Offset: 0x3027091 VA: 0x3026F90
	|-Dictionary<object, Nullable<RangeInt>>.TryInsert
	|
	|-RVA: 0x302A950 Offset: 0x302AA51 VA: 0x302A950
	|-Dictionary<object, Nullable<Rect>>.TryInsert
	|
	|-RVA: 0x2FD7F30 Offset: 0x2FD8031 VA: 0x2FD7F30
	|-Dictionary<object, Nullable<RectInt>>.TryInsert
	|
	|-RVA: 0x2FDB8C0 Offset: 0x2FDB9C1 VA: 0x2FDB8C0
	|-Dictionary<object, Nullable<Vector2>>.TryInsert
	|
	|-RVA: 0x2FDF110 Offset: 0x2FDF211 VA: 0x2FDF110
	|-Dictionary<object, Nullable<Vector2Int>>.TryInsert
	|
	|-RVA: 0x2FE2950 Offset: 0x2FE2A51 VA: 0x2FE2950
	|-Dictionary<object, Nullable<Vector3>>.TryInsert
	|
	|-RVA: 0x2FE6140 Offset: 0x2FE6241 VA: 0x2FE6140
	|-Dictionary<object, Nullable<Vector3Int>>.TryInsert
	|
	|-RVA: 0x2FE9AB0 Offset: 0x2FE9BB1 VA: 0x2FE9AB0
	|-Dictionary<object, Nullable<Vector4>>.TryInsert
	|
	|-RVA: 0x2FED360 Offset: 0x2FED461 VA: 0x2FED360
	|-Dictionary<object, object>.TryInsert
	|
	|-RVA: 0x2FF0970 Offset: 0x2FF0A71 VA: 0x2FF0970
	|-Dictionary<object, ReadOnlyMemory<object>>.TryInsert
	|
	|-RVA: 0x2DBF420 Offset: 0x2DBF521 VA: 0x2DBF420
	|-Dictionary<object, ResourceLocator>.TryInsert
	|
	|-RVA: 0x2DC2AE0 Offset: 0x2DC2BE1 VA: 0x2DC2AE0
	|-Dictionary<object, sbyte>.TryInsert
	|
	|-RVA: 0x2DC61A0 Offset: 0x2DC62A1 VA: 0x2DC61A0
	|-Dictionary<object, float>.TryInsert
	|
	|-RVA: 0x2DC9860 Offset: 0x2DC9961 VA: 0x2DC9860
	|-Dictionary<object, ushort>.TryInsert
	|
	|-RVA: 0x2DCCF20 Offset: 0x2DCD021 VA: 0x2DCCF20
	|-Dictionary<object, uint>.TryInsert
	|
	|-RVA: 0x2DD05E0 Offset: 0x2DD06E1 VA: 0x2DD05E0
	|-Dictionary<object, ulong>.TryInsert
	|
	|-RVA: 0x2DD3E80 Offset: 0x2DD3F81 VA: 0x2DD3E80
	|-Dictionary<object, TransitionTables>.TryInsert
	|
	|-RVA: 0x2DD7870 Offset: 0x2DD7971 VA: 0x2DD7870
	|-Dictionary<object, Bounds>.TryInsert
	|
	|-RVA: 0x2DDB230 Offset: 0x2DDB331 VA: 0x2DDB230
	|-Dictionary<object, BoundsInt>.TryInsert
	|
	|-RVA: 0x30D6310 Offset: 0x30D6411 VA: 0x30D6310
	|-Dictionary<object, Color32>.TryInsert
	|
	|-RVA: 0x30D9A40 Offset: 0x30D9B41 VA: 0x30D9A40
	|-Dictionary<object, Color>.TryInsert
	|
	|-RVA: 0x30DD110 Offset: 0x30DD211 VA: 0x30DD110
	|-Dictionary<object, GradientAlphaKey>.TryInsert
	|
	|-RVA: 0x30E09B0 Offset: 0x30E0AB1 VA: 0x30E09B0
	|-Dictionary<object, GradientColorKey>.TryInsert
	|
	|-RVA: 0x30E4450 Offset: 0x30E4551 VA: 0x30E4450
	|-Dictionary<object, Keyframe>.TryInsert
	|
	|-RVA: 0x30E7CF0 Offset: 0x30E7DF1 VA: 0x30E7CF0
	|-Dictionary<object, LayerMask>.TryInsert
	|
	|-RVA: 0x30EB750 Offset: 0x30EB851 VA: 0x30EB750
	|-Dictionary<object, Matrix4x4>.TryInsert
	|
	|-RVA: 0x30EF0C0 Offset: 0x30EF1C1 VA: 0x30EF0C0
	|-Dictionary<object, Playable>.TryInsert
	|
	|-RVA: 0x309DED0 Offset: 0x309DFD1 VA: 0x309DED0
	|-Dictionary<object, Quaternion>.TryInsert
	|
	|-RVA: 0x30A1580 Offset: 0x30A1681 VA: 0x30A1580
	|-Dictionary<object, RangeInt>.TryInsert
	|
	|-RVA: 0x30A4CA0 Offset: 0x30A4DA1 VA: 0x30A4CA0
	|-Dictionary<object, Rect>.TryInsert
	|
	|-RVA: 0x30A83B0 Offset: 0x30A84B1 VA: 0x30A83B0
	|-Dictionary<object, RectInt>.TryInsert
	|
	|-RVA: 0x30ABC00 Offset: 0x30ABD01 VA: 0x30ABC00
	|-Dictionary<object, AsyncOperationHandle>.TryInsert
	|
	|-RVA: 0x30AF5D0 Offset: 0x30AF6D1 VA: 0x30AF5D0
	|-Dictionary<object, AsyncOperationHandle<object>>.TryInsert
	|
	|-RVA: 0x30B2E00 Offset: 0x30B2F01 VA: 0x30B2E00
	|-Dictionary<object, Vector2>.TryInsert
	|
	|-RVA: 0x30B64D0 Offset: 0x30B65D1 VA: 0x30B64D0
	|-Dictionary<object, Vector2Int>.TryInsert
	|
	|-RVA: 0x30821C0 Offset: 0x30822C1 VA: 0x30821C0
	|-Dictionary<object, Vector3>.TryInsert
	|
	|-RVA: 0x30858E0 Offset: 0x30859E1 VA: 0x30858E0
	|-Dictionary<object, Vector3Int>.TryInsert
	|
	|-RVA: 0x3089010 Offset: 0x3089111 VA: 0x3089010
	|-Dictionary<object, Vector4>.TryInsert
	|
	|-RVA: 0x308C750 Offset: 0x308C851 VA: 0x308C750
	|-Dictionary<ReadOnlyMemory<object>, object>.TryInsert
	|
	|-RVA: 0x308FD00 Offset: 0x308FE01 VA: 0x308FD00
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.TryInsert
	|
	|-RVA: 0x30933F0 Offset: 0x30934F1 VA: 0x30933F0
	|-Dictionary<sbyte, object>.TryInsert
	|
	|-RVA: 0x3096E90 Offset: 0x3096F91 VA: 0x3096E90
	|-Dictionary<float, CurveSample>.TryInsert
	|
	|-RVA: 0x309A880 Offset: 0x309A981 VA: 0x309A880
	|-Dictionary<float, object>.TryInsert
	|
	|-RVA: 0x319DDC0 Offset: 0x319DEC1 VA: 0x319DDC0
	|-Dictionary<ushort, object>.TryInsert
	|
	|-RVA: 0x31A1350 Offset: 0x31A1451 VA: 0x31A1350
	|-Dictionary<uint, int>.TryInsert
	|
	|-RVA: 0x31A4910 Offset: 0x31A4A11 VA: 0x31A4910
	|-Dictionary<uint, Int32Enum>.TryInsert
	|
	|-RVA: 0x31A7F60 Offset: 0x31A8061 VA: 0x31A7F60
	|-Dictionary<uint, object>.TryInsert
	|
	|-RVA: 0x31AB580 Offset: 0x31AB681 VA: 0x31AB580
	|-Dictionary<ulong, object>.TryInsert
	|
	|-RVA: 0x31AEB30 Offset: 0x31AEC31 VA: 0x31AEB30
	|-Dictionary<EdgeKeyByHash, int>.TryInsert
	|
	|-RVA: 0x31B24C0 Offset: 0x31B25C1 VA: 0x31B24C0
	|-Dictionary<EdgeKeyByHash, CapEdge>.TryInsert
	|
	|-RVA: 0x31B6040 Offset: 0x31B6141 VA: 0x31B6040
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.TryInsert
	|
	|-RVA: 0x302E330 Offset: 0x302E431 VA: 0x302E330
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.TryInsert
	|
	|-RVA: 0x3031B10 Offset: 0x3031C11 VA: 0x3031B10
	|-Dictionary<MeshDataConnectivity.Face, bool>.TryInsert
	|
	|-RVA: 0x3035200 Offset: 0x3035301 VA: 0x3035200
	|-Dictionary<MeshDataConnectivity.Face, object>.TryInsert
	|
	|-RVA: 0x3038A70 Offset: 0x3038B71 VA: 0x3038A70
	|-Dictionary<Bounds, object>.TryInsert
	|
	|-RVA: 0x303C5A0 Offset: 0x303C6A1 VA: 0x303C5A0
	|-Dictionary<BoundsInt, object>.TryInsert
	|
	|-RVA: 0x303FF50 Offset: 0x3040051 VA: 0x303FF50
	|-Dictionary<Color, object>.TryInsert
	|
	|-RVA: 0x3043600 Offset: 0x3043701 VA: 0x3043600
	|-Dictionary<Color32, object>.TryInsert
	|
	|-RVA: 0x3046C40 Offset: 0x3046D41 VA: 0x3046C40
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.TryInsert
	|
	|-RVA: 0x30657D0 Offset: 0x30658D1 VA: 0x30657D0
	|-Dictionary<GradientAlphaKey, object>.TryInsert
	|
	|-RVA: 0x3069040 Offset: 0x3069141 VA: 0x3069040
	|-Dictionary<GradientColorKey, object>.TryInsert
	|
	|-RVA: 0x306CC70 Offset: 0x306CD71 VA: 0x306CC70
	|-Dictionary<Keyframe, object>.TryInsert
	|
	|-RVA: 0x30706C0 Offset: 0x30707C1 VA: 0x30706C0
	|-Dictionary<LayerMask, object>.TryInsert
	|
	|-RVA: 0x3074170 Offset: 0x3074271 VA: 0x3074170
	|-Dictionary<Matrix4x4, object>.TryInsert
	|
	|-RVA: 0x3077DB0 Offset: 0x3077EB1 VA: 0x3077DB0
	|-Dictionary<IntVec3, object>.TryInsert
	|
	|-RVA: 0x307B4C0 Offset: 0x307B5C1 VA: 0x307B4C0
	|-Dictionary<Quaternion, object>.TryInsert
	|
	|-RVA: 0x307EB50 Offset: 0x307EC51 VA: 0x307EB50
	|-Dictionary<RangeInt, object>.TryInsert
	|
	|-RVA: 0x304A330 Offset: 0x304A431 VA: 0x304A330
	|-Dictionary<Rect, object>.TryInsert
	|
	|-RVA: 0x304DA40 Offset: 0x304DB41 VA: 0x304DA40
	|-Dictionary<RectInt, object>.TryInsert
	|
	|-RVA: 0x3050FD0 Offset: 0x30510D1 VA: 0x3050FD0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.TryInsert
	|
	|-RVA: 0x30546B0 Offset: 0x30547B1 VA: 0x30546B0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.TryInsert
	|
	|-RVA: 0x3057D30 Offset: 0x3057E31 VA: 0x3057D30
	|-Dictionary<Vector2, object>.TryInsert
	|
	|-RVA: 0x305B350 Offset: 0x305B451 VA: 0x305B350
	|-Dictionary<Vector2Int, object>.TryInsert
	|
	|-RVA: 0x305EA20 Offset: 0x305EB21 VA: 0x305EA20
	|-Dictionary<Vector3, object>.TryInsert
	|
	|-RVA: 0x30620F0 Offset: 0x30621F1 VA: 0x30620F0
	|-Dictionary<Vector3Int, object>.TryInsert
	|
	|-RVA: 0x2E3BB20 Offset: 0x2E3BC21 VA: 0x2E3BB20
	|-Dictionary<Vector4, object>.TryInsert
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A17A50 Offset: 0x2A17B51 VA: 0x2A17A50
	|-Dictionary<JSONDeserialization.TaskField, object>.OnDeserialization
	|
	|-RVA: 0x2A1B080 Offset: 0x2A1B181 VA: 0x2A1B080
	|-Dictionary<BitVector32Int, object>.OnDeserialization
	|
	|-RVA: 0x2E2B050 Offset: 0x2E2B151 VA: 0x2E2B050
	|-Dictionary<Season, Texture>.OnDeserialization
	|-Dictionary<Int32Enum, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x2F7A0A0 Offset: 0x2F7A1A1 VA: 0x2F7A0A0
	|-Dictionary<EventCheckId, object>.OnDeserialization
	|
	|-RVA: 0x2F7DF40 Offset: 0x2F7E041 VA: 0x2F7DF40
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.OnDeserialization
	|
	|-RVA: 0x2F81CA0 Offset: 0x2F81DA1 VA: 0x2F81CA0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.OnDeserialization
	|
	|-RVA: 0x2F85580 Offset: 0x2F85681 VA: 0x2F85580
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.OnDeserialization
	|
	|-RVA: 0x2F88C70 Offset: 0x2F88D71 VA: 0x2F88C70
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.OnDeserialization
	|
	|-RVA: 0x2F8C6C0 Offset: 0x2F8C7C1 VA: 0x2F8C6C0
	|-Dictionary<MonsterHutSaveData, object>.OnDeserialization
	|
	|-RVA: 0x2F900A0 Offset: 0x2F901A1 VA: 0x2F900A0
	|-Dictionary<OrderLotterySaveParameter, object>.OnDeserialization
	|
	|-RVA: 0x2F93B60 Offset: 0x2F93C61 VA: 0x2F93B60
	|-Dictionary<OrderSaveData, object>.OnDeserialization
	|
	|-RVA: 0x2D81B30 Offset: 0x2D81C31 VA: 0x2D81B30
	|-Dictionary<OrderSaveParameter, object>.OnDeserialization
	|
	|-RVA: 0x2D857D0 Offset: 0x2D858D1 VA: 0x2D857D0
	|-Dictionary<Parameter, object>.OnDeserialization
	|
	|-RVA: 0x2D89140 Offset: 0x2D89241 VA: 0x2D89140
	|-Dictionary<bool, object>.OnDeserialization
	|
	|-RVA: 0x2D8C770 Offset: 0x2D8C871 VA: 0x2D8C770
	|-Dictionary<byte, object>.OnDeserialization
	|
	|-RVA: 0x2D8FD90 Offset: 0x2D8FE91 VA: 0x2D8FD90
	|-Dictionary<char, object>.OnDeserialization
	|
	|-RVA: 0x2D933B0 Offset: 0x2D934B1 VA: 0x2D933B0
	|-Dictionary<DateTime, object>.OnDeserialization
	|
	|-RVA: 0x2D969D0 Offset: 0x2D96AD1 VA: 0x2D969D0
	|-Dictionary<double, object>.OnDeserialization
	|
	|-RVA: 0x2D9A060 Offset: 0x2D9A161 VA: 0x2D9A060
	|-Dictionary<Guid, object>.OnDeserialization
	|
	|-RVA: 0x2D9D660 Offset: 0x2D9D761 VA: 0x2D9D660
	|-Dictionary<short, object>.OnDeserialization
	|
	|-RVA: 0x2D3BB20 Offset: 0x2D3BC21 VA: 0x2D3BB20
	|-Dictionary<int, CropDataTable>.OnDeserialization
	|
	|-RVA: 0x2D3F5C0 Offset: 0x2D3F6C1 VA: 0x2D3F5C0
	|-Dictionary<int, EffectDataTable>.OnDeserialization
	|
	|-RVA: 0x2D42CF0 Offset: 0x2D42DF1 VA: 0x2D42CF0
	|-Dictionary<int, GimmickLayoutDataTable>.OnDeserialization
	|
	|-RVA: 0x2D46750 Offset: 0x2D46851 VA: 0x2D46750
	|-Dictionary<int, MineTypeDataTable>.OnDeserialization
	|
	|-RVA: 0x2D4A030 Offset: 0x2D4A131 VA: 0x2D4A030
	|-Dictionary<int, MiningDataTable>.OnDeserialization
	|
	|-RVA: 0x2D4D670 Offset: 0x2D4D771 VA: 0x2D4D670
	|-Dictionary<int, bool>.OnDeserialization
	|
	|-RVA: 0x2D50C30 Offset: 0x2D50D31 VA: 0x2D50C30
	|-Dictionary<int, char>.OnDeserialization
	|
	|-RVA: 0x2D541F0 Offset: 0x2D542F1 VA: 0x2D541F0
	|-Dictionary<int, int>.OnDeserialization
	|
	|-RVA: 0x2D577B0 Offset: 0x2D578B1 VA: 0x2D577B0
	|-Dictionary<int, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x2F5D910 Offset: 0x2F5DA11 VA: 0x2F5D910
	|-Dictionary<int, long>.OnDeserialization
	|
	|-RVA: 0x2F61000 Offset: 0x2F61101 VA: 0x2F61000
	|-Dictionary<int, object>.OnDeserialization
	|-Dictionary<int, TerrainUtility.TerrainMap>.OnDeserialization
	|
	|-RVA: 0x2F648E0 Offset: 0x2F649E1 VA: 0x2F648E0
	|-Dictionary<int, DiagnosticEvent>.OnDeserialization
	|
	|-RVA: 0x2F68130 Offset: 0x2F68231 VA: 0x2F68130
	|-Dictionary<int, SceneInstance>.OnDeserialization
	|
	|-RVA: 0x2F6B7B0 Offset: 0x2F6B8B1 VA: 0x2F6B7B0
	|-Dictionary<int, Vector2Int>.OnDeserialization
	|
	|-RVA: 0x2F6EEA0 Offset: 0x2F6EFA1 VA: 0x2F6EEA0
	|-Dictionary<int, Vector3>.OnDeserialization
	|
	|-RVA: 0x2F72940 Offset: 0x2F72A41 VA: 0x2F72940
	|-Dictionary<Int32Enum, MonsterDataTable>.OnDeserialization
	|
	|-RVA: 0x2F76550 Offset: 0x2F76651 VA: 0x2F76550
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.OnDeserialization
	|
	|-RVA: 0x2E1D7E0 Offset: 0x2E1D8E1 VA: 0x2E1D7E0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.OnDeserialization
	|
	|-RVA: 0x2E20E50 Offset: 0x2E20F51 VA: 0x2E20E50
	|-Dictionary<Int32Enum, bool>.OnDeserialization
	|
	|-RVA: 0x2E24470 Offset: 0x2E24571 VA: 0x2E24470
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.OnDeserialization
	|
	|-RVA: 0x2E27A90 Offset: 0x2E27B91 VA: 0x2E27A90
	|-Dictionary<Int32Enum, int>.OnDeserialization
	|
	|-RVA: 0x2E2E6D0 Offset: 0x2E2E7D1 VA: 0x2E2E6D0
	|-Dictionary<Int32Enum, object>.OnDeserialization
	|
	|-RVA: 0x2E31C30 Offset: 0x2E31D31 VA: 0x2E31C30
	|-Dictionary<Int32Enum, float>.OnDeserialization
	|
	|-RVA: 0x2E352A0 Offset: 0x2E353A1 VA: 0x2E352A0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.OnDeserialization
	|
	|-RVA: 0x2E38930 Offset: 0x2E38A31 VA: 0x2E38930
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.OnDeserialization
	|
	|-RVA: 0x2F974A0 Offset: 0x2F975A1 VA: 0x2F974A0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.OnDeserialization
	|
	|-RVA: 0x2F9ABF0 Offset: 0x2F9ACF1 VA: 0x2F9ABF0
	|-Dictionary<long, object>.OnDeserialization
	|
	|-RVA: 0x2F9E2A0 Offset: 0x2F9E3A1 VA: 0x2F9E2A0
	|-Dictionary<Memory<object>, object>.OnDeserialization
	|
	|-RVA: 0x2FA1980 Offset: 0x2FA1A81 VA: 0x2FA1980
	|-Dictionary<Nullable<Int32Enum>, object>.OnDeserialization
	|
	|-RVA: 0x2FA55D0 Offset: 0x2FA56D1 VA: 0x2FA55D0
	|-Dictionary<Nullable<Bounds>, object>.OnDeserialization
	|
	|-RVA: 0x2FA9530 Offset: 0x2FA9631 VA: 0x2FA9530
	|-Dictionary<Nullable<BoundsInt>, object>.OnDeserialization
	|
	|-RVA: 0x2FAD020 Offset: 0x2FAD121 VA: 0x2FAD020
	|-Dictionary<Nullable<Color32>, object>.OnDeserialization
	|
	|-RVA: 0x2FB0B00 Offset: 0x2FB0C01 VA: 0x2FB0B00
	|-Dictionary<Nullable<Color>, object>.OnDeserialization
	|
	|-RVA: 0x2F1B990 Offset: 0x2F1BA91 VA: 0x2F1B990
	|-Dictionary<Nullable<GradientAlphaKey>, object>.OnDeserialization
	|
	|-RVA: 0x2F1F4C0 Offset: 0x2F1F5C1 VA: 0x2F1F4C0
	|-Dictionary<Nullable<GradientColorKey>, object>.OnDeserialization
	|
	|-RVA: 0x2F231E0 Offset: 0x2F232E1 VA: 0x2F231E0
	|-Dictionary<Nullable<Keyframe>, object>.OnDeserialization
	|
	|-RVA: 0x2F26BF0 Offset: 0x2F26CF1 VA: 0x2F26BF0
	|-Dictionary<Nullable<LayerMask>, object>.OnDeserialization
	|
	|-RVA: 0x2F2ABF0 Offset: 0x2F2ACF1 VA: 0x2F2ABF0
	|-Dictionary<Nullable<Matrix4x4>, object>.OnDeserialization
	|
	|-RVA: 0x2F2EC40 Offset: 0x2F2ED41 VA: 0x2F2EC40
	|-Dictionary<Nullable<Quaternion>, object>.OnDeserialization
	|
	|-RVA: 0x2F326E0 Offset: 0x2F327E1 VA: 0x2F326E0
	|-Dictionary<Nullable<RangeInt>, object>.OnDeserialization
	|
	|-RVA: 0x2F36210 Offset: 0x2F36311 VA: 0x2F36210
	|-Dictionary<Nullable<Rect>, object>.OnDeserialization
	|
	|-RVA: 0x2EFEF20 Offset: 0x2EFF021 VA: 0x2EFEF20
	|-Dictionary<Nullable<RectInt>, object>.OnDeserialization
	|
	|-RVA: 0x2F029C0 Offset: 0x2F02AC1 VA: 0x2F029C0
	|-Dictionary<Nullable<Vector2>, object>.OnDeserialization
	|
	|-RVA: 0x2F06290 Offset: 0x2F06391 VA: 0x2F06290
	|-Dictionary<Nullable<Vector2Int>, object>.OnDeserialization
	|
	|-RVA: 0x2F09B30 Offset: 0x2F09C31 VA: 0x2F09B30
	|-Dictionary<Nullable<Vector3>, object>.OnDeserialization
	|
	|-RVA: 0x2F0D370 Offset: 0x2F0D471 VA: 0x2F0D370
	|-Dictionary<Nullable<Vector3Int>, object>.OnDeserialization
	|
	|-RVA: 0x2F10E40 Offset: 0x2F10F41 VA: 0x2F10E40
	|-Dictionary<Nullable<Vector4>, object>.OnDeserialization
	|
	|-RVA: 0x2F14760 Offset: 0x2F14861 VA: 0x2F14760
	|-Dictionary<object, BitVector32Int>.OnDeserialization
	|
	|-RVA: 0x2F18030 Offset: 0x2F18131 VA: 0x2F18030
	|-Dictionary<object, EventCheckId>.OnDeserialization
	|
	|-RVA: 0x2FF4A80 Offset: 0x2FF4B81 VA: 0x2FF4A80
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.OnDeserialization
	|
	|-RVA: 0x2FF8540 Offset: 0x2FF8641 VA: 0x2FF8540
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.OnDeserialization
	|
	|-RVA: 0x2FFBD70 Offset: 0x2FFBE71 VA: 0x2FFBD70
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.OnDeserialization
	|
	|-RVA: 0x2FFF480 Offset: 0x2FFF581 VA: 0x2FFF480
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.OnDeserialization
	|
	|-RVA: 0x3002E30 Offset: 0x3002F31 VA: 0x3002E30
	|-Dictionary<object, MonsterHutSaveData>.OnDeserialization
	|
	|-RVA: 0x30066D0 Offset: 0x30067D1 VA: 0x30066D0
	|-Dictionary<object, OrderLotterySaveParameter>.OnDeserialization
	|
	|-RVA: 0x300A0B0 Offset: 0x300A1B1 VA: 0x300A0B0
	|-Dictionary<object, OrderSaveData>.OnDeserialization
	|
	|-RVA: 0x300DB30 Offset: 0x300DC31 VA: 0x300DB30
	|-Dictionary<object, OrderSaveParameter>.OnDeserialization
	|
	|-RVA: 0x2DDF350 Offset: 0x2DDF451 VA: 0x2DDF350
	|-Dictionary<object, Parameter>.OnDeserialization
	|
	|-RVA: 0x2DE2C50 Offset: 0x2DE2D51 VA: 0x2DE2C50
	|-Dictionary<object, NumberControl.ValueRange>.OnDeserialization
	|
	|-RVA: 0x2DE6320 Offset: 0x2DE6421 VA: 0x2DE6320
	|-Dictionary<object, bool>.OnDeserialization
	|
	|-RVA: 0x2DE99E0 Offset: 0x2DE9AE1 VA: 0x2DE99E0
	|-Dictionary<object, byte>.OnDeserialization
	|
	|-RVA: 0x2DED0A0 Offset: 0x2DED1A1 VA: 0x2DED0A0
	|-Dictionary<object, char>.OnDeserialization
	|
	|-RVA: 0x2DF0760 Offset: 0x2DF0861 VA: 0x2DF0760
	|-Dictionary<object, DateTime>.OnDeserialization
	|
	|-RVA: 0x2DF3E10 Offset: 0x2DF3F11 VA: 0x2DF3E10
	|-Dictionary<object, double>.OnDeserialization
	|
	|-RVA: 0x2DF74D0 Offset: 0x2DF75D1 VA: 0x2DF74D0
	|-Dictionary<object, short>.OnDeserialization
	|
	|-RVA: 0x2DFAB90 Offset: 0x2DFAC91 VA: 0x2DFAB90
	|-Dictionary<object, int>.OnDeserialization
	|
	|-RVA: 0x30BA150 Offset: 0x30BA251 VA: 0x30BA150
	|-Dictionary<object, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x30BD810 Offset: 0x30BD911 VA: 0x30BD810
	|-Dictionary<object, long>.OnDeserialization
	|
	|-RVA: 0x30C0F20 Offset: 0x30C1021 VA: 0x30C0F20
	|-Dictionary<object, Memory<object>>.OnDeserialization
	|
	|-RVA: 0x30C4690 Offset: 0x30C4791 VA: 0x30C4690
	|-Dictionary<object, Nullable<Int32Enum>>.OnDeserialization
	|
	|-RVA: 0x30C8150 Offset: 0x30C8251 VA: 0x30C8150
	|-Dictionary<object, Nullable<Bounds>>.OnDeserialization
	|
	|-RVA: 0x30CBDB0 Offset: 0x30CBEB1 VA: 0x30CBDB0
	|-Dictionary<object, Nullable<BoundsInt>>.OnDeserialization
	|
	|-RVA: 0x30CF6F0 Offset: 0x30CF7F1 VA: 0x30CF6F0
	|-Dictionary<object, Nullable<Color32>>.OnDeserialization
	|
	|-RVA: 0x30D30B0 Offset: 0x30D31B1 VA: 0x30D30B0
	|-Dictionary<object, Nullable<Color>>.OnDeserialization
	|
	|-RVA: 0x3011440 Offset: 0x3011541 VA: 0x3011440
	|-Dictionary<object, Nullable<GradientAlphaKey>>.OnDeserialization
	|
	|-RVA: 0x3014E30 Offset: 0x3014F31 VA: 0x3014E30
	|-Dictionary<object, Nullable<GradientColorKey>>.OnDeserialization
	|
	|-RVA: 0x3018950 Offset: 0x3018A51 VA: 0x3018950
	|-Dictionary<object, Nullable<Keyframe>>.OnDeserialization
	|
	|-RVA: 0x301C240 Offset: 0x301C341 VA: 0x301C240
	|-Dictionary<object, Nullable<LayerMask>>.OnDeserialization
	|
	|-RVA: 0x301FFA0 Offset: 0x30200A1 VA: 0x301FFA0
	|-Dictionary<object, Nullable<Matrix4x4>>.OnDeserialization
	|
	|-RVA: 0x3023C00 Offset: 0x3023D01 VA: 0x3023C00
	|-Dictionary<object, Nullable<Quaternion>>.OnDeserialization
	|
	|-RVA: 0x3027550 Offset: 0x3027651 VA: 0x3027550
	|-Dictionary<object, Nullable<RangeInt>>.OnDeserialization
	|
	|-RVA: 0x302AF50 Offset: 0x302B051 VA: 0x302AF50
	|-Dictionary<object, Nullable<Rect>>.OnDeserialization
	|
	|-RVA: 0x2FD8530 Offset: 0x2FD8631 VA: 0x2FD8530
	|-Dictionary<object, Nullable<RectInt>>.OnDeserialization
	|
	|-RVA: 0x2FDBE80 Offset: 0x2FDBF81 VA: 0x2FDBE80
	|-Dictionary<object, Nullable<Vector2>>.OnDeserialization
	|
	|-RVA: 0x2FDF6D0 Offset: 0x2FDF7D1 VA: 0x2FDF6D0
	|-Dictionary<object, Nullable<Vector2Int>>.OnDeserialization
	|
	|-RVA: 0x2FE2F00 Offset: 0x2FE3001 VA: 0x2FE2F00
	|-Dictionary<object, Nullable<Vector3>>.OnDeserialization
	|
	|-RVA: 0x2FE66F0 Offset: 0x2FE67F1 VA: 0x2FE66F0
	|-Dictionary<object, Nullable<Vector3Int>>.OnDeserialization
	|
	|-RVA: 0x2FEA0B0 Offset: 0x2FEA1B1 VA: 0x2FEA0B0
	|-Dictionary<object, Nullable<Vector4>>.OnDeserialization
	|
	|-RVA: 0x2FED930 Offset: 0x2FEDA31 VA: 0x2FED930
	|-Dictionary<object, object>.OnDeserialization
	|
	|-RVA: 0x2FF0F40 Offset: 0x2FF1041 VA: 0x2FF0F40
	|-Dictionary<object, ReadOnlyMemory<object>>.OnDeserialization
	|
	|-RVA: 0x2DBF9F0 Offset: 0x2DBFAF1 VA: 0x2DBF9F0
	|-Dictionary<object, ResourceLocator>.OnDeserialization
	|
	|-RVA: 0x2DC30B0 Offset: 0x2DC31B1 VA: 0x2DC30B0
	|-Dictionary<object, sbyte>.OnDeserialization
	|
	|-RVA: 0x2DC6770 Offset: 0x2DC6871 VA: 0x2DC6770
	|-Dictionary<object, float>.OnDeserialization
	|
	|-RVA: 0x2DC9E30 Offset: 0x2DC9F31 VA: 0x2DC9E30
	|-Dictionary<object, ushort>.OnDeserialization
	|
	|-RVA: 0x2DCD4F0 Offset: 0x2DCD5F1 VA: 0x2DCD4F0
	|-Dictionary<object, uint>.OnDeserialization
	|
	|-RVA: 0x2DD0BB0 Offset: 0x2DD0CB1 VA: 0x2DD0BB0
	|-Dictionary<object, ulong>.OnDeserialization
	|
	|-RVA: 0x2DD44A0 Offset: 0x2DD45A1 VA: 0x2DD44A0
	|-Dictionary<object, TransitionTables>.OnDeserialization
	|
	|-RVA: 0x2DD7E70 Offset: 0x2DD7F71 VA: 0x2DD7E70
	|-Dictionary<object, Bounds>.OnDeserialization
	|
	|-RVA: 0x2DDB830 Offset: 0x2DDB931 VA: 0x2DDB830
	|-Dictionary<object, BoundsInt>.OnDeserialization
	|
	|-RVA: 0x30D68E0 Offset: 0x30D69E1 VA: 0x30D68E0
	|-Dictionary<object, Color32>.OnDeserialization
	|
	|-RVA: 0x30DA000 Offset: 0x30DA101 VA: 0x30DA000
	|-Dictionary<object, Color>.OnDeserialization
	|
	|-RVA: 0x30DD6E0 Offset: 0x30DD7E1 VA: 0x30DD6E0
	|-Dictionary<object, GradientAlphaKey>.OnDeserialization
	|
	|-RVA: 0x30E0FB0 Offset: 0x30E10B1 VA: 0x30E0FB0
	|-Dictionary<object, GradientColorKey>.OnDeserialization
	|
	|-RVA: 0x30E4A70 Offset: 0x30E4B71 VA: 0x30E4A70
	|-Dictionary<object, Keyframe>.OnDeserialization
	|
	|-RVA: 0x30E82C0 Offset: 0x30E83C1 VA: 0x30E82C0
	|-Dictionary<object, LayerMask>.OnDeserialization
	|
	|-RVA: 0x30EBD90 Offset: 0x30EBE91 VA: 0x30EBD90
	|-Dictionary<object, Matrix4x4>.OnDeserialization
	|
	|-RVA: 0x30EF670 Offset: 0x30EF771 VA: 0x30EF670
	|-Dictionary<object, Playable>.OnDeserialization
	|
	|-RVA: 0x309E490 Offset: 0x309E591 VA: 0x309E490
	|-Dictionary<object, Quaternion>.OnDeserialization
	|
	|-RVA: 0x30A1B50 Offset: 0x30A1C51 VA: 0x30A1B50
	|-Dictionary<object, RangeInt>.OnDeserialization
	|
	|-RVA: 0x30A5260 Offset: 0x30A5361 VA: 0x30A5260
	|-Dictionary<object, Rect>.OnDeserialization
	|
	|-RVA: 0x30A8960 Offset: 0x30A8A61 VA: 0x30A8960
	|-Dictionary<object, RectInt>.OnDeserialization
	|
	|-RVA: 0x30AC210 Offset: 0x30AC311 VA: 0x30AC210
	|-Dictionary<object, AsyncOperationHandle>.OnDeserialization
	|
	|-RVA: 0x30AFBE0 Offset: 0x30AFCE1 VA: 0x30AFBE0
	|-Dictionary<object, AsyncOperationHandle<object>>.OnDeserialization
	|
	|-RVA: 0x30B33D0 Offset: 0x30B34D1 VA: 0x30B33D0
	|-Dictionary<object, Vector2>.OnDeserialization
	|
	|-RVA: 0x30B6AA0 Offset: 0x30B6BA1 VA: 0x30B6AA0
	|-Dictionary<object, Vector2Int>.OnDeserialization
	|
	|-RVA: 0x3082770 Offset: 0x3082871 VA: 0x3082770
	|-Dictionary<object, Vector3>.OnDeserialization
	|
	|-RVA: 0x3085EA0 Offset: 0x3085FA1 VA: 0x3085EA0
	|-Dictionary<object, Vector3Int>.OnDeserialization
	|
	|-RVA: 0x30895D0 Offset: 0x30896D1 VA: 0x30895D0
	|-Dictionary<object, Vector4>.OnDeserialization
	|
	|-RVA: 0x308CD20 Offset: 0x308CE21 VA: 0x308CD20
	|-Dictionary<ReadOnlyMemory<object>, object>.OnDeserialization
	|
	|-RVA: 0x30902C0 Offset: 0x30903C1 VA: 0x30902C0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.OnDeserialization
	|
	|-RVA: 0x30939B0 Offset: 0x3093AB1 VA: 0x30939B0
	|-Dictionary<sbyte, object>.OnDeserialization
	|
	|-RVA: 0x30974F0 Offset: 0x30975F1 VA: 0x30974F0
	|-Dictionary<float, CurveSample>.OnDeserialization
	|
	|-RVA: 0x309AE20 Offset: 0x309AF21 VA: 0x309AE20
	|-Dictionary<float, object>.OnDeserialization
	|
	|-RVA: 0x319E380 Offset: 0x319E481 VA: 0x319E380
	|-Dictionary<ushort, object>.OnDeserialization
	|
	|-RVA: 0x31A18E0 Offset: 0x31A19E1 VA: 0x31A18E0
	|-Dictionary<uint, int>.OnDeserialization
	|
	|-RVA: 0x31A4EA0 Offset: 0x31A4FA1 VA: 0x31A4EA0
	|-Dictionary<uint, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x31A8520 Offset: 0x31A8621 VA: 0x31A8520
	|-Dictionary<uint, object>.OnDeserialization
	|
	|-RVA: 0x31ABB40 Offset: 0x31ABC41 VA: 0x31ABB40
	|-Dictionary<ulong, object>.OnDeserialization
	|
	|-RVA: 0x31AF0F0 Offset: 0x31AF1F1 VA: 0x31AF0F0
	|-Dictionary<EdgeKeyByHash, int>.OnDeserialization
	|
	|-RVA: 0x31B2AF0 Offset: 0x31B2BF1 VA: 0x31B2AF0
	|-Dictionary<EdgeKeyByHash, CapEdge>.OnDeserialization
	|
	|-RVA: 0x31B6640 Offset: 0x31B6741 VA: 0x31B6640
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.OnDeserialization
	|
	|-RVA: 0x302E920 Offset: 0x302EA21 VA: 0x302E920
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.OnDeserialization
	|
	|-RVA: 0x30320E0 Offset: 0x30321E1 VA: 0x30320E0
	|-Dictionary<MeshDataConnectivity.Face, bool>.OnDeserialization
	|
	|-RVA: 0x30357C0 Offset: 0x30358C1 VA: 0x30357C0
	|-Dictionary<MeshDataConnectivity.Face, object>.OnDeserialization
	|
	|-RVA: 0x30390D0 Offset: 0x30391D1 VA: 0x30390D0
	|-Dictionary<Bounds, object>.OnDeserialization
	|
	|-RVA: 0x303CC00 Offset: 0x303CD01 VA: 0x303CC00
	|-Dictionary<BoundsInt, object>.OnDeserialization
	|
	|-RVA: 0x3040520 Offset: 0x3040621 VA: 0x3040520
	|-Dictionary<Color, object>.OnDeserialization
	|
	|-RVA: 0x3043BD0 Offset: 0x3043CD1 VA: 0x3043BD0
	|-Dictionary<Color32, object>.OnDeserialization
	|
	|-RVA: 0x3047200 Offset: 0x3047301 VA: 0x3047200
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.OnDeserialization
	|
	|-RVA: 0x3065D90 Offset: 0x3065E91 VA: 0x3065D90
	|-Dictionary<GradientAlphaKey, object>.OnDeserialization
	|
	|-RVA: 0x30696A0 Offset: 0x30697A1 VA: 0x30696A0
	|-Dictionary<GradientColorKey, object>.OnDeserialization
	|
	|-RVA: 0x306D330 Offset: 0x306D431 VA: 0x306D330
	|-Dictionary<Keyframe, object>.OnDeserialization
	|
	|-RVA: 0x3070C90 Offset: 0x3070D91 VA: 0x3070C90
	|-Dictionary<LayerMask, object>.OnDeserialization
	|
	|-RVA: 0x3074890 Offset: 0x3074991 VA: 0x3074890
	|-Dictionary<Matrix4x4, object>.OnDeserialization
	|
	|-RVA: 0x3078360 Offset: 0x3078461 VA: 0x3078360
	|-Dictionary<IntVec3, object>.OnDeserialization
	|
	|-RVA: 0x307BA90 Offset: 0x307BB91 VA: 0x307BA90
	|-Dictionary<Quaternion, object>.OnDeserialization
	|
	|-RVA: 0x307F110 Offset: 0x307F211 VA: 0x307F110
	|-Dictionary<RangeInt, object>.OnDeserialization
	|
	|-RVA: 0x304A900 Offset: 0x304AA01 VA: 0x304A900
	|-Dictionary<Rect, object>.OnDeserialization
	|
	|-RVA: 0x304E000 Offset: 0x304E101 VA: 0x304E000
	|-Dictionary<RectInt, object>.OnDeserialization
	|
	|-RVA: 0x3051590 Offset: 0x3051691 VA: 0x3051590
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.OnDeserialization
	|
	|-RVA: 0x3054C70 Offset: 0x3054D71 VA: 0x3054C70
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.OnDeserialization
	|
	|-RVA: 0x30582F0 Offset: 0x30583F1 VA: 0x30582F0
	|-Dictionary<Vector2, object>.OnDeserialization
	|
	|-RVA: 0x305B910 Offset: 0x305BA11 VA: 0x305B910
	|-Dictionary<Vector2Int, object>.OnDeserialization
	|
	|-RVA: 0x305EFD0 Offset: 0x305F0D1 VA: 0x305EFD0
	|-Dictionary<Vector3, object>.OnDeserialization
	|
	|-RVA: 0x30626C0 Offset: 0x30627C1 VA: 0x30626C0
	|-Dictionary<Vector3Int, object>.OnDeserialization
	|
	|-RVA: 0x2E3C0F0 Offset: 0x2E3C1F1 VA: 0x2E3C0F0
	|-Dictionary<Vector4, object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A17F00 Offset: 0x2A18001 VA: 0x2A17F00
	|-Dictionary<JSONDeserialization.TaskField, object>.Resize
	|
	|-RVA: 0x2A1B530 Offset: 0x2A1B631 VA: 0x2A1B530
	|-Dictionary<BitVector32Int, object>.Resize
	|
	|-RVA: 0x2F7A580 Offset: 0x2F7A681 VA: 0x2F7A580
	|-Dictionary<EventCheckId, object>.Resize
	|
	|-RVA: 0x2F7E440 Offset: 0x2F7E541 VA: 0x2F7E440
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.Resize
	|
	|-RVA: 0x2F82180 Offset: 0x2F82281 VA: 0x2F82180
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.Resize
	|
	|-RVA: 0x2F85A40 Offset: 0x2F85B41 VA: 0x2F85A40
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.Resize
	|
	|-RVA: 0x2F89120 Offset: 0x2F89221 VA: 0x2F89120
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.Resize
	|
	|-RVA: 0x2F8CBB0 Offset: 0x2F8CCB1 VA: 0x2F8CBB0
	|-Dictionary<MonsterHutSaveData, object>.Resize
	|
	|-RVA: 0x2F90560 Offset: 0x2F90661 VA: 0x2F90560
	|-Dictionary<OrderLotterySaveParameter, object>.Resize
	|
	|-RVA: 0x2F94050 Offset: 0x2F94151 VA: 0x2F94050
	|-Dictionary<OrderSaveData, object>.Resize
	|
	|-RVA: 0x2D82010 Offset: 0x2D82111 VA: 0x2D82010
	|-Dictionary<OrderSaveParameter, object>.Resize
	|
	|-RVA: 0x2D85CC0 Offset: 0x2D85DC1 VA: 0x2D85CC0
	|-Dictionary<Parameter, object>.Resize
	|
	|-RVA: 0x2D895F0 Offset: 0x2D896F1 VA: 0x2D895F0
	|-Dictionary<bool, object>.Resize
	|
	|-RVA: 0x2D8CC20 Offset: 0x2D8CD21 VA: 0x2D8CC20
	|-Dictionary<byte, object>.Resize
	|
	|-RVA: 0x2D90240 Offset: 0x2D90341 VA: 0x2D90240
	|-Dictionary<char, object>.Resize
	|
	|-RVA: 0x2D93860 Offset: 0x2D93961 VA: 0x2D93860
	|-Dictionary<DateTime, object>.Resize
	|
	|-RVA: 0x2D96E80 Offset: 0x2D96F81 VA: 0x2D96E80
	|-Dictionary<double, object>.Resize
	|
	|-RVA: 0x2D9A510 Offset: 0x2D9A611 VA: 0x2D9A510
	|-Dictionary<Guid, object>.Resize
	|
	|-RVA: 0x2D9DB10 Offset: 0x2D9DC11 VA: 0x2D9DB10
	|-Dictionary<short, object>.Resize
	|
	|-RVA: 0x2D3C010 Offset: 0x2D3C111 VA: 0x2D3C010
	|-Dictionary<int, CropDataTable>.Resize
	|
	|-RVA: 0x2D3FAA0 Offset: 0x2D3FBA1 VA: 0x2D3FAA0
	|-Dictionary<int, EffectDataTable>.Resize
	|
	|-RVA: 0x2D431A0 Offset: 0x2D432A1 VA: 0x2D431A0
	|-Dictionary<int, GimmickLayoutDataTable>.Resize
	|
	|-RVA: 0x2D46C50 Offset: 0x2D46D51 VA: 0x2D46C50
	|-Dictionary<int, MineTypeDataTable>.Resize
	|
	|-RVA: 0x2D4A4E0 Offset: 0x2D4A5E1 VA: 0x2D4A4E0
	|-Dictionary<int, MiningDataTable>.Resize
	|
	|-RVA: 0x2D4DB20 Offset: 0x2D4DC21 VA: 0x2D4DB20
	|-Dictionary<int, bool>.Resize
	|
	|-RVA: 0x2D510E0 Offset: 0x2D511E1 VA: 0x2D510E0
	|-Dictionary<int, char>.Resize
	|
	|-RVA: 0x2D546A0 Offset: 0x2D547A1 VA: 0x2D546A0
	|-Dictionary<int, int>.Resize
	|
	|-RVA: 0x2D57C60 Offset: 0x2D57D61 VA: 0x2D57C60
	|-Dictionary<int, Int32Enum>.Resize
	|
	|-RVA: 0x2F5DDC0 Offset: 0x2F5DEC1 VA: 0x2F5DDC0
	|-Dictionary<int, long>.Resize
	|
	|-RVA: 0x2F614B0 Offset: 0x2F615B1 VA: 0x2F614B0
	|-Dictionary<int, object>.Resize
	|
	|-RVA: 0x2F64DD0 Offset: 0x2F64ED1 VA: 0x2F64DD0
	|-Dictionary<int, DiagnosticEvent>.Resize
	|
	|-RVA: 0x2F685E0 Offset: 0x2F686E1 VA: 0x2F685E0
	|-Dictionary<int, SceneInstance>.Resize
	|
	|-RVA: 0x2F6BC60 Offset: 0x2F6BD61 VA: 0x2F6BC60
	|-Dictionary<int, Vector2Int>.Resize
	|
	|-RVA: 0x2F6F350 Offset: 0x2F6F451 VA: 0x2F6F350
	|-Dictionary<int, Vector3>.Resize
	|
	|-RVA: 0x2F72E30 Offset: 0x2F72F31 VA: 0x2F72E30
	|-Dictionary<Int32Enum, MonsterDataTable>.Resize
	|
	|-RVA: 0x2F76A40 Offset: 0x2F76B41 VA: 0x2F76A40
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.Resize
	|
	|-RVA: 0x2E1DC90 Offset: 0x2E1DD91 VA: 0x2E1DC90
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Resize
	|
	|-RVA: 0x2E21300 Offset: 0x2E21401 VA: 0x2E21300
	|-Dictionary<Int32Enum, bool>.Resize
	|
	|-RVA: 0x2E24920 Offset: 0x2E24A21 VA: 0x2E24920
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.Resize
	|
	|-RVA: 0x2E27F40 Offset: 0x2E28041 VA: 0x2E27F40
	|-Dictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x2E2B500 Offset: 0x2E2B601 VA: 0x2E2B500
	|-Dictionary<Int32Enum, Int32Enum>.Resize
	|
	|-RVA: 0x2E2EB80 Offset: 0x2E2EC81 VA: 0x2E2EB80
	|-Dictionary<Int32Enum, object>.Resize
	|
	|-RVA: 0x2E320E0 Offset: 0x2E321E1 VA: 0x2E320E0
	|-Dictionary<Int32Enum, float>.Resize
	|
	|-RVA: 0x2E35750 Offset: 0x2E35851 VA: 0x2E35750
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.Resize
	|
	|-RVA: 0x2E38DE0 Offset: 0x2E38EE1 VA: 0x2E38DE0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.Resize
	|
	|-RVA: 0x2F97960 Offset: 0x2F97A61 VA: 0x2F97960
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.Resize
	|
	|-RVA: 0x2F9B0A0 Offset: 0x2F9B1A1 VA: 0x2F9B0A0
	|-Dictionary<long, object>.Resize
	|
	|-RVA: 0x2F9E750 Offset: 0x2F9E851 VA: 0x2F9E750
	|-Dictionary<Memory<object>, object>.Resize
	|
	|-RVA: 0x2FA1E90 Offset: 0x2FA1F91 VA: 0x2FA1E90
	|-Dictionary<Nullable<Int32Enum>, object>.Resize
	|
	|-RVA: 0x2FA5B20 Offset: 0x2FA5C21 VA: 0x2FA5B20
	|-Dictionary<Nullable<Bounds>, object>.Resize
	|
	|-RVA: 0x2FA9A80 Offset: 0x2FA9B81 VA: 0x2FA9A80
	|-Dictionary<Nullable<BoundsInt>, object>.Resize
	|
	|-RVA: 0x2FAD530 Offset: 0x2FAD631 VA: 0x2FAD530
	|-Dictionary<Nullable<Color32>, object>.Resize
	|
	|-RVA: 0x2FB1030 Offset: 0x2FB1131 VA: 0x2FB1030
	|-Dictionary<Nullable<Color>, object>.Resize
	|
	|-RVA: 0x2F1BEB0 Offset: 0x2F1BFB1 VA: 0x2F1BEB0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.Resize
	|
	|-RVA: 0x2F1F9F0 Offset: 0x2F1FAF1 VA: 0x2F1F9F0
	|-Dictionary<Nullable<GradientColorKey>, object>.Resize
	|
	|-RVA: 0x2F23710 Offset: 0x2F23811 VA: 0x2F23710
	|-Dictionary<Nullable<Keyframe>, object>.Resize
	|
	|-RVA: 0x2F27100 Offset: 0x2F27201 VA: 0x2F27100
	|-Dictionary<Nullable<LayerMask>, object>.Resize
	|
	|-RVA: 0x2F2B180 Offset: 0x2F2B281 VA: 0x2F2B180
	|-Dictionary<Nullable<Matrix4x4>, object>.Resize
	|
	|-RVA: 0x2F2F170 Offset: 0x2F2F271 VA: 0x2F2F170
	|-Dictionary<Nullable<Quaternion>, object>.Resize
	|
	|-RVA: 0x2F32C00 Offset: 0x2F32D01 VA: 0x2F32C00
	|-Dictionary<Nullable<RangeInt>, object>.Resize
	|
	|-RVA: 0x2F36740 Offset: 0x2F36841 VA: 0x2F36740
	|-Dictionary<Nullable<Rect>, object>.Resize
	|
	|-RVA: 0x2EFF450 Offset: 0x2EFF551 VA: 0x2EFF450
	|-Dictionary<Nullable<RectInt>, object>.Resize
	|
	|-RVA: 0x2F02EE0 Offset: 0x2F02FE1 VA: 0x2F02EE0
	|-Dictionary<Nullable<Vector2>, object>.Resize
	|
	|-RVA: 0x2F067B0 Offset: 0x2F068B1 VA: 0x2F067B0
	|-Dictionary<Nullable<Vector2Int>, object>.Resize
	|
	|-RVA: 0x2F0A040 Offset: 0x2F0A141 VA: 0x2F0A040
	|-Dictionary<Nullable<Vector3>, object>.Resize
	|
	|-RVA: 0x2F0D880 Offset: 0x2F0D981 VA: 0x2F0D880
	|-Dictionary<Nullable<Vector3Int>, object>.Resize
	|
	|-RVA: 0x2F11370 Offset: 0x2F11471 VA: 0x2F11370
	|-Dictionary<Nullable<Vector4>, object>.Resize
	|
	|-RVA: 0x2F14C20 Offset: 0x2F14D21 VA: 0x2F14C20
	|-Dictionary<object, BitVector32Int>.Resize
	|
	|-RVA: 0x2F18530 Offset: 0x2F18631 VA: 0x2F18530
	|-Dictionary<object, EventCheckId>.Resize
	|
	|-RVA: 0x2FF4FA0 Offset: 0x2FF50A1 VA: 0x2FF4FA0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.Resize
	|
	|-RVA: 0x2FF8A30 Offset: 0x2FF8B31 VA: 0x2FF8A30
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.Resize
	|
	|-RVA: 0x2FFC240 Offset: 0x2FFC341 VA: 0x2FFC240
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.Resize
	|
	|-RVA: 0x2FFF950 Offset: 0x2FFFA51 VA: 0x2FFF950
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.Resize
	|
	|-RVA: 0x3003330 Offset: 0x3003431 VA: 0x3003330
	|-Dictionary<object, MonsterHutSaveData>.Resize
	|
	|-RVA: 0x3006BA0 Offset: 0x3006CA1 VA: 0x3006BA0
	|-Dictionary<object, OrderLotterySaveParameter>.Resize
	|
	|-RVA: 0x300A5B0 Offset: 0x300A6B1 VA: 0x300A5B0
	|-Dictionary<object, OrderSaveData>.Resize
	|
	|-RVA: 0x300E020 Offset: 0x300E121 VA: 0x300E020
	|-Dictionary<object, OrderSaveParameter>.Resize
	|
	|-RVA: 0x2DDF860 Offset: 0x2DDF961 VA: 0x2DDF860
	|-Dictionary<object, Parameter>.Resize
	|
	|-RVA: 0x2DE3120 Offset: 0x2DE3221 VA: 0x2DE3120
	|-Dictionary<object, NumberControl.ValueRange>.Resize
	|
	|-RVA: 0x2DE67E0 Offset: 0x2DE68E1 VA: 0x2DE67E0
	|-Dictionary<object, bool>.Resize
	|
	|-RVA: 0x2DE9EA0 Offset: 0x2DE9FA1 VA: 0x2DE9EA0
	|-Dictionary<object, byte>.Resize
	|
	|-RVA: 0x2DED560 Offset: 0x2DED661 VA: 0x2DED560
	|-Dictionary<object, char>.Resize
	|
	|-RVA: 0x2DF0C20 Offset: 0x2DF0D21 VA: 0x2DF0C20
	|-Dictionary<object, DateTime>.Resize
	|
	|-RVA: 0x2DF42D0 Offset: 0x2DF43D1 VA: 0x2DF42D0
	|-Dictionary<object, double>.Resize
	|
	|-RVA: 0x2DF7990 Offset: 0x2DF7A91 VA: 0x2DF7990
	|-Dictionary<object, short>.Resize
	|
	|-RVA: 0x2DFB050 Offset: 0x2DFB151 VA: 0x2DFB050
	|-Dictionary<object, int>.Resize
	|
	|-RVA: 0x30BA610 Offset: 0x30BA711 VA: 0x30BA610
	|-Dictionary<object, Int32Enum>.Resize
	|
	|-RVA: 0x30BDCD0 Offset: 0x30BDDD1 VA: 0x30BDCD0
	|-Dictionary<object, long>.Resize
	|
	|-RVA: 0x30C13F0 Offset: 0x30C14F1 VA: 0x30C13F0
	|-Dictionary<object, Memory<object>>.Resize
	|
	|-RVA: 0x30C4B50 Offset: 0x30C4C51 VA: 0x30C4B50
	|-Dictionary<object, Nullable<Int32Enum>>.Resize
	|
	|-RVA: 0x30C8660 Offset: 0x30C8761 VA: 0x30C8660
	|-Dictionary<object, Nullable<Bounds>>.Resize
	|
	|-RVA: 0x30CC2C0 Offset: 0x30CC3C1 VA: 0x30CC2C0
	|-Dictionary<object, Nullable<BoundsInt>>.Resize
	|
	|-RVA: 0x30CFBB0 Offset: 0x30CFCB1 VA: 0x30CFBB0
	|-Dictionary<object, Nullable<Color32>>.Resize
	|
	|-RVA: 0x30D35A0 Offset: 0x30D36A1 VA: 0x30D35A0
	|-Dictionary<object, Nullable<Color>>.Resize
	|
	|-RVA: 0x3011910 Offset: 0x3011A11 VA: 0x3011910
	|-Dictionary<object, Nullable<GradientAlphaKey>>.Resize
	|
	|-RVA: 0x3015330 Offset: 0x3015431 VA: 0x3015330
	|-Dictionary<object, Nullable<GradientColorKey>>.Resize
	|
	|-RVA: 0x3018E40 Offset: 0x3018F41 VA: 0x3018E40
	|-Dictionary<object, Nullable<Keyframe>>.Resize
	|
	|-RVA: 0x301C700 Offset: 0x301C801 VA: 0x301C700
	|-Dictionary<object, Nullable<LayerMask>>.Resize
	|
	|-RVA: 0x30204D0 Offset: 0x30205D1 VA: 0x30204D0
	|-Dictionary<object, Nullable<Matrix4x4>>.Resize
	|
	|-RVA: 0x30240F0 Offset: 0x30241F1 VA: 0x30240F0
	|-Dictionary<object, Nullable<Quaternion>>.Resize
	|
	|-RVA: 0x3027A20 Offset: 0x3027B21 VA: 0x3027A20
	|-Dictionary<object, Nullable<RangeInt>>.Resize
	|
	|-RVA: 0x302B440 Offset: 0x302B541 VA: 0x302B440
	|-Dictionary<object, Nullable<Rect>>.Resize
	|
	|-RVA: 0x2FD8A20 Offset: 0x2FD8B21 VA: 0x2FD8A20
	|-Dictionary<object, Nullable<RectInt>>.Resize
	|
	|-RVA: 0x2FDC350 Offset: 0x2FDC451 VA: 0x2FDC350
	|-Dictionary<object, Nullable<Vector2>>.Resize
	|
	|-RVA: 0x2FDFBA0 Offset: 0x2FDFCA1 VA: 0x2FDFBA0
	|-Dictionary<object, Nullable<Vector2Int>>.Resize
	|
	|-RVA: 0x2FE33D0 Offset: 0x2FE34D1 VA: 0x2FE33D0
	|-Dictionary<object, Nullable<Vector3>>.Resize
	|
	|-RVA: 0x2FE6BC0 Offset: 0x2FE6CC1 VA: 0x2FE6BC0
	|-Dictionary<object, Nullable<Vector3Int>>.Resize
	|
	|-RVA: 0x2FEA5A0 Offset: 0x2FEA6A1 VA: 0x2FEA5A0
	|-Dictionary<object, Nullable<Vector4>>.Resize
	|
	|-RVA: 0x2FEDDF0 Offset: 0x2FEDEF1 VA: 0x2FEDDF0
	|-Dictionary<object, object>.Resize
	|
	|-RVA: 0x2FF1410 Offset: 0x2FF1511 VA: 0x2FF1410
	|-Dictionary<object, ReadOnlyMemory<object>>.Resize
	|
	|-RVA: 0x2DBFEC0 Offset: 0x2DBFFC1 VA: 0x2DBFEC0
	|-Dictionary<object, ResourceLocator>.Resize
	|
	|-RVA: 0x2DC3570 Offset: 0x2DC3671 VA: 0x2DC3570
	|-Dictionary<object, sbyte>.Resize
	|
	|-RVA: 0x2DC6C30 Offset: 0x2DC6D31 VA: 0x2DC6C30
	|-Dictionary<object, float>.Resize
	|
	|-RVA: 0x2DCA2F0 Offset: 0x2DCA3F1 VA: 0x2DCA2F0
	|-Dictionary<object, ushort>.Resize
	|
	|-RVA: 0x2DCD9B0 Offset: 0x2DCDAB1 VA: 0x2DCD9B0
	|-Dictionary<object, uint>.Resize
	|
	|-RVA: 0x2DD1070 Offset: 0x2DD1171 VA: 0x2DD1070
	|-Dictionary<object, ulong>.Resize
	|
	|-RVA: 0x2DD4990 Offset: 0x2DD4A91 VA: 0x2DD4990
	|-Dictionary<object, TransitionTables>.Resize
	|
	|-RVA: 0x2DD8370 Offset: 0x2DD8471 VA: 0x2DD8370
	|-Dictionary<object, Bounds>.Resize
	|
	|-RVA: 0x2DDBD30 Offset: 0x2DDBE31 VA: 0x2DDBD30
	|-Dictionary<object, BoundsInt>.Resize
	|
	|-RVA: 0x30D6DA0 Offset: 0x30D6EA1 VA: 0x30D6DA0
	|-Dictionary<object, Color32>.Resize
	|
	|-RVA: 0x30DA4D0 Offset: 0x30DA5D1 VA: 0x30DA4D0
	|-Dictionary<object, Color>.Resize
	|
	|-RVA: 0x30DDBB0 Offset: 0x30DDCB1 VA: 0x30DDBB0
	|-Dictionary<object, GradientAlphaKey>.Resize
	|
	|-RVA: 0x30E14A0 Offset: 0x30E15A1 VA: 0x30E14A0
	|-Dictionary<object, GradientColorKey>.Resize
	|
	|-RVA: 0x30E4F80 Offset: 0x30E5081 VA: 0x30E4F80
	|-Dictionary<object, Keyframe>.Resize
	|
	|-RVA: 0x30E8780 Offset: 0x30E8881 VA: 0x30E8780
	|-Dictionary<object, LayerMask>.Resize
	|
	|-RVA: 0x30EC2B0 Offset: 0x30EC3B1 VA: 0x30EC2B0
	|-Dictionary<object, Matrix4x4>.Resize
	|
	|-RVA: 0x30EFB40 Offset: 0x30EFC41 VA: 0x30EFB40
	|-Dictionary<object, Playable>.Resize
	|
	|-RVA: 0x309E960 Offset: 0x309EA61 VA: 0x309E960
	|-Dictionary<object, Quaternion>.Resize
	|
	|-RVA: 0x30A2010 Offset: 0x30A2111 VA: 0x30A2010
	|-Dictionary<object, RangeInt>.Resize
	|
	|-RVA: 0x30A5730 Offset: 0x30A5831 VA: 0x30A5730
	|-Dictionary<object, Rect>.Resize
	|
	|-RVA: 0x30A8E30 Offset: 0x30A8F31 VA: 0x30A8E30
	|-Dictionary<object, RectInt>.Resize
	|
	|-RVA: 0x30AC710 Offset: 0x30AC811 VA: 0x30AC710
	|-Dictionary<object, AsyncOperationHandle>.Resize
	|
	|-RVA: 0x30B00E0 Offset: 0x30B01E1 VA: 0x30B00E0
	|-Dictionary<object, AsyncOperationHandle<object>>.Resize
	|
	|-RVA: 0x30B38A0 Offset: 0x30B39A1 VA: 0x30B38A0
	|-Dictionary<object, Vector2>.Resize
	|
	|-RVA: 0x30B6F60 Offset: 0x30B7061 VA: 0x30B6F60
	|-Dictionary<object, Vector2Int>.Resize
	|
	|-RVA: 0x3082C40 Offset: 0x3082D41 VA: 0x3082C40
	|-Dictionary<object, Vector3>.Resize
	|
	|-RVA: 0x3086370 Offset: 0x3086471 VA: 0x3086370
	|-Dictionary<object, Vector3Int>.Resize
	|
	|-RVA: 0x3089AA0 Offset: 0x3089BA1 VA: 0x3089AA0
	|-Dictionary<object, Vector4>.Resize
	|
	|-RVA: 0x308D1D0 Offset: 0x308D2D1 VA: 0x308D1D0
	|-Dictionary<ReadOnlyMemory<object>, object>.Resize
	|
	|-RVA: 0x3090770 Offset: 0x3090871 VA: 0x3090770
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.Resize
	|
	|-RVA: 0x3093E60 Offset: 0x3093F61 VA: 0x3093E60
	|-Dictionary<sbyte, object>.Resize
	|
	|-RVA: 0x3097A00 Offset: 0x3097B01 VA: 0x3097A00
	|-Dictionary<float, CurveSample>.Resize
	|
	|-RVA: 0x309B2D0 Offset: 0x309B3D1 VA: 0x309B2D0
	|-Dictionary<float, object>.Resize
	|
	|-RVA: 0x319E830 Offset: 0x319E931 VA: 0x319E830
	|-Dictionary<ushort, object>.Resize
	|
	|-RVA: 0x31A1D90 Offset: 0x31A1E91 VA: 0x31A1D90
	|-Dictionary<uint, int>.Resize
	|
	|-RVA: 0x31A5350 Offset: 0x31A5451 VA: 0x31A5350
	|-Dictionary<uint, Int32Enum>.Resize
	|
	|-RVA: 0x31A89D0 Offset: 0x31A8AD1 VA: 0x31A89D0
	|-Dictionary<uint, object>.Resize
	|
	|-RVA: 0x31ABFF0 Offset: 0x31AC0F1 VA: 0x31ABFF0
	|-Dictionary<ulong, object>.Resize
	|
	|-RVA: 0x31AF5A0 Offset: 0x31AF6A1 VA: 0x31AF5A0
	|-Dictionary<EdgeKeyByHash, int>.Resize
	|
	|-RVA: 0x31B2FE0 Offset: 0x31B30E1 VA: 0x31B2FE0
	|-Dictionary<EdgeKeyByHash, CapEdge>.Resize
	|
	|-RVA: 0x31B6B30 Offset: 0x31B6C31 VA: 0x31B6B30
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Resize
	|
	|-RVA: 0x302EE00 Offset: 0x302EF01 VA: 0x302EE00
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.Resize
	|
	|-RVA: 0x3032590 Offset: 0x3032691 VA: 0x3032590
	|-Dictionary<MeshDataConnectivity.Face, bool>.Resize
	|
	|-RVA: 0x3035C70 Offset: 0x3035D71 VA: 0x3035C70
	|-Dictionary<MeshDataConnectivity.Face, object>.Resize
	|
	|-RVA: 0x30395B0 Offset: 0x30396B1 VA: 0x30395B0
	|-Dictionary<Bounds, object>.Resize
	|
	|-RVA: 0x303D0E0 Offset: 0x303D1E1 VA: 0x303D0E0
	|-Dictionary<BoundsInt, object>.Resize
	|
	|-RVA: 0x30409D0 Offset: 0x3040AD1 VA: 0x30409D0
	|-Dictionary<Color, object>.Resize
	|
	|-RVA: 0x3044080 Offset: 0x3044181 VA: 0x3044080
	|-Dictionary<Color32, object>.Resize
	|
	|-RVA: 0x30476B0 Offset: 0x30477B1 VA: 0x30476B0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Resize
	|
	|-RVA: 0x3066240 Offset: 0x3066341 VA: 0x3066240
	|-Dictionary<GradientAlphaKey, object>.Resize
	|
	|-RVA: 0x3069B80 Offset: 0x3069C81 VA: 0x3069B80
	|-Dictionary<GradientColorKey, object>.Resize
	|
	|-RVA: 0x306D820 Offset: 0x306D921 VA: 0x306D820
	|-Dictionary<Keyframe, object>.Resize
	|
	|-RVA: 0x3071140 Offset: 0x3071241 VA: 0x3071140
	|-Dictionary<LayerMask, object>.Resize
	|
	|-RVA: 0x3074D90 Offset: 0x3074E91 VA: 0x3074D90
	|-Dictionary<Matrix4x4, object>.Resize
	|
	|-RVA: 0x3078810 Offset: 0x3078911 VA: 0x3078810
	|-Dictionary<IntVec3, object>.Resize
	|
	|-RVA: 0x307BF40 Offset: 0x307C041 VA: 0x307BF40
	|-Dictionary<Quaternion, object>.Resize
	|
	|-RVA: 0x307F5C0 Offset: 0x307F6C1 VA: 0x307F5C0
	|-Dictionary<RangeInt, object>.Resize
	|
	|-RVA: 0x304ADB0 Offset: 0x304AEB1 VA: 0x304ADB0
	|-Dictionary<Rect, object>.Resize
	|
	|-RVA: 0x304E4B0 Offset: 0x304E5B1 VA: 0x304E4B0
	|-Dictionary<RectInt, object>.Resize
	|
	|-RVA: 0x3051A40 Offset: 0x3051B41 VA: 0x3051A40
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.Resize
	|
	|-RVA: 0x3055120 Offset: 0x3055221 VA: 0x3055120
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Resize
	|
	|-RVA: 0x30587A0 Offset: 0x30588A1 VA: 0x30587A0
	|-Dictionary<Vector2, object>.Resize
	|
	|-RVA: 0x305BDC0 Offset: 0x305BEC1 VA: 0x305BDC0
	|-Dictionary<Vector2Int, object>.Resize
	|
	|-RVA: 0x305F480 Offset: 0x305F581 VA: 0x305F480
	|-Dictionary<Vector3, object>.Resize
	|
	|-RVA: 0x3062B80 Offset: 0x3062C81 VA: 0x3062B80
	|-Dictionary<Vector3Int, object>.Resize
	|
	|-RVA: 0x2E3C5A0 Offset: 0x2E3C6A1 VA: 0x2E3C5A0
	|-Dictionary<Vector4, object>.Resize
	*/

	// RVA: -1 Offset: -1
	private void Resize(int newSize, bool forceNewHashCodes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A17FA0 Offset: 0x2A180A1 VA: 0x2A17FA0
	|-Dictionary<JSONDeserialization.TaskField, object>.Resize
	|
	|-RVA: 0x2A1B5D0 Offset: 0x2A1B6D1 VA: 0x2A1B5D0
	|-Dictionary<BitVector32Int, object>.Resize
	|
	|-RVA: 0x2F7A620 Offset: 0x2F7A721 VA: 0x2F7A620
	|-Dictionary<EventCheckId, object>.Resize
	|
	|-RVA: 0x2F7E4E0 Offset: 0x2F7E5E1 VA: 0x2F7E4E0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.Resize
	|
	|-RVA: 0x2F82220 Offset: 0x2F82321 VA: 0x2F82220
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.Resize
	|
	|-RVA: 0x2F85AE0 Offset: 0x2F85BE1 VA: 0x2F85AE0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.Resize
	|
	|-RVA: 0x2F891C0 Offset: 0x2F892C1 VA: 0x2F891C0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.Resize
	|
	|-RVA: 0x2F8CC50 Offset: 0x2F8CD51 VA: 0x2F8CC50
	|-Dictionary<MonsterHutSaveData, object>.Resize
	|
	|-RVA: 0x2F90600 Offset: 0x2F90701 VA: 0x2F90600
	|-Dictionary<OrderLotterySaveParameter, object>.Resize
	|
	|-RVA: 0x2F940F0 Offset: 0x2F941F1 VA: 0x2F940F0
	|-Dictionary<OrderSaveData, object>.Resize
	|
	|-RVA: 0x2D820B0 Offset: 0x2D821B1 VA: 0x2D820B0
	|-Dictionary<OrderSaveParameter, object>.Resize
	|
	|-RVA: 0x2D85D60 Offset: 0x2D85E61 VA: 0x2D85D60
	|-Dictionary<Parameter, object>.Resize
	|
	|-RVA: 0x2D89690 Offset: 0x2D89791 VA: 0x2D89690
	|-Dictionary<bool, object>.Resize
	|
	|-RVA: 0x2D8CCC0 Offset: 0x2D8CDC1 VA: 0x2D8CCC0
	|-Dictionary<byte, object>.Resize
	|
	|-RVA: 0x2D902E0 Offset: 0x2D903E1 VA: 0x2D902E0
	|-Dictionary<char, object>.Resize
	|
	|-RVA: 0x2D93900 Offset: 0x2D93A01 VA: 0x2D93900
	|-Dictionary<DateTime, object>.Resize
	|
	|-RVA: 0x2D96F20 Offset: 0x2D97021 VA: 0x2D96F20
	|-Dictionary<double, object>.Resize
	|
	|-RVA: 0x2D9A5B0 Offset: 0x2D9A6B1 VA: 0x2D9A5B0
	|-Dictionary<Guid, object>.Resize
	|
	|-RVA: 0x2D9DBB0 Offset: 0x2D9DCB1 VA: 0x2D9DBB0
	|-Dictionary<short, object>.Resize
	|
	|-RVA: 0x2D3C0B0 Offset: 0x2D3C1B1 VA: 0x2D3C0B0
	|-Dictionary<int, CropDataTable>.Resize
	|
	|-RVA: 0x2D3FB40 Offset: 0x2D3FC41 VA: 0x2D3FB40
	|-Dictionary<int, EffectDataTable>.Resize
	|
	|-RVA: 0x2D43240 Offset: 0x2D43341 VA: 0x2D43240
	|-Dictionary<int, GimmickLayoutDataTable>.Resize
	|
	|-RVA: 0x2D46CF0 Offset: 0x2D46DF1 VA: 0x2D46CF0
	|-Dictionary<int, MineTypeDataTable>.Resize
	|
	|-RVA: 0x2D4A580 Offset: 0x2D4A681 VA: 0x2D4A580
	|-Dictionary<int, MiningDataTable>.Resize
	|
	|-RVA: 0x2D4DBC0 Offset: 0x2D4DCC1 VA: 0x2D4DBC0
	|-Dictionary<int, bool>.Resize
	|
	|-RVA: 0x2D51180 Offset: 0x2D51281 VA: 0x2D51180
	|-Dictionary<int, char>.Resize
	|
	|-RVA: 0x2D54740 Offset: 0x2D54841 VA: 0x2D54740
	|-Dictionary<int, int>.Resize
	|
	|-RVA: 0x2D57D00 Offset: 0x2D57E01 VA: 0x2D57D00
	|-Dictionary<int, Int32Enum>.Resize
	|
	|-RVA: 0x2F5DE60 Offset: 0x2F5DF61 VA: 0x2F5DE60
	|-Dictionary<int, long>.Resize
	|
	|-RVA: 0x2F61550 Offset: 0x2F61651 VA: 0x2F61550
	|-Dictionary<int, object>.Resize
	|
	|-RVA: 0x2F64E70 Offset: 0x2F64F71 VA: 0x2F64E70
	|-Dictionary<int, DiagnosticEvent>.Resize
	|
	|-RVA: 0x2F68680 Offset: 0x2F68781 VA: 0x2F68680
	|-Dictionary<int, SceneInstance>.Resize
	|
	|-RVA: 0x2F6BD00 Offset: 0x2F6BE01 VA: 0x2F6BD00
	|-Dictionary<int, Vector2Int>.Resize
	|
	|-RVA: 0x2F6F3F0 Offset: 0x2F6F4F1 VA: 0x2F6F3F0
	|-Dictionary<int, Vector3>.Resize
	|
	|-RVA: 0x2F72ED0 Offset: 0x2F72FD1 VA: 0x2F72ED0
	|-Dictionary<Int32Enum, MonsterDataTable>.Resize
	|
	|-RVA: 0x2F76AE0 Offset: 0x2F76BE1 VA: 0x2F76AE0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.Resize
	|
	|-RVA: 0x2E1DD30 Offset: 0x2E1DE31 VA: 0x2E1DD30
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Resize
	|
	|-RVA: 0x2E213A0 Offset: 0x2E214A1 VA: 0x2E213A0
	|-Dictionary<Int32Enum, bool>.Resize
	|
	|-RVA: 0x2E249C0 Offset: 0x2E24AC1 VA: 0x2E249C0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.Resize
	|
	|-RVA: 0x2E27FE0 Offset: 0x2E280E1 VA: 0x2E27FE0
	|-Dictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x2E2B5A0 Offset: 0x2E2B6A1 VA: 0x2E2B5A0
	|-Dictionary<Int32Enum, Int32Enum>.Resize
	|
	|-RVA: 0x2E2EC20 Offset: 0x2E2ED21 VA: 0x2E2EC20
	|-Dictionary<Int32Enum, object>.Resize
	|
	|-RVA: 0x2E32180 Offset: 0x2E32281 VA: 0x2E32180
	|-Dictionary<Int32Enum, float>.Resize
	|
	|-RVA: 0x2E357F0 Offset: 0x2E358F1 VA: 0x2E357F0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.Resize
	|
	|-RVA: 0x2E38E80 Offset: 0x2E38F81 VA: 0x2E38E80
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.Resize
	|
	|-RVA: 0x2F97A00 Offset: 0x2F97B01 VA: 0x2F97A00
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.Resize
	|
	|-RVA: 0x2F9B140 Offset: 0x2F9B241 VA: 0x2F9B140
	|-Dictionary<long, object>.Resize
	|
	|-RVA: 0x2F9E7F0 Offset: 0x2F9E8F1 VA: 0x2F9E7F0
	|-Dictionary<Memory<object>, object>.Resize
	|
	|-RVA: 0x2FA1F30 Offset: 0x2FA2031 VA: 0x2FA1F30
	|-Dictionary<Nullable<Int32Enum>, object>.Resize
	|
	|-RVA: 0x2FA5BC0 Offset: 0x2FA5CC1 VA: 0x2FA5BC0
	|-Dictionary<Nullable<Bounds>, object>.Resize
	|
	|-RVA: 0x2FA9B20 Offset: 0x2FA9C21 VA: 0x2FA9B20
	|-Dictionary<Nullable<BoundsInt>, object>.Resize
	|
	|-RVA: 0x2FAD5D0 Offset: 0x2FAD6D1 VA: 0x2FAD5D0
	|-Dictionary<Nullable<Color32>, object>.Resize
	|
	|-RVA: 0x2FB10D0 Offset: 0x2FB11D1 VA: 0x2FB10D0
	|-Dictionary<Nullable<Color>, object>.Resize
	|
	|-RVA: 0x2F1BF50 Offset: 0x2F1C051 VA: 0x2F1BF50
	|-Dictionary<Nullable<GradientAlphaKey>, object>.Resize
	|
	|-RVA: 0x2F1FA90 Offset: 0x2F1FB91 VA: 0x2F1FA90
	|-Dictionary<Nullable<GradientColorKey>, object>.Resize
	|
	|-RVA: 0x2F237B0 Offset: 0x2F238B1 VA: 0x2F237B0
	|-Dictionary<Nullable<Keyframe>, object>.Resize
	|
	|-RVA: 0x2F271A0 Offset: 0x2F272A1 VA: 0x2F271A0
	|-Dictionary<Nullable<LayerMask>, object>.Resize
	|
	|-RVA: 0x2F2B220 Offset: 0x2F2B321 VA: 0x2F2B220
	|-Dictionary<Nullable<Matrix4x4>, object>.Resize
	|
	|-RVA: 0x2F2F210 Offset: 0x2F2F311 VA: 0x2F2F210
	|-Dictionary<Nullable<Quaternion>, object>.Resize
	|
	|-RVA: 0x2F32CA0 Offset: 0x2F32DA1 VA: 0x2F32CA0
	|-Dictionary<Nullable<RangeInt>, object>.Resize
	|
	|-RVA: 0x2F367E0 Offset: 0x2F368E1 VA: 0x2F367E0
	|-Dictionary<Nullable<Rect>, object>.Resize
	|
	|-RVA: 0x2EFF4F0 Offset: 0x2EFF5F1 VA: 0x2EFF4F0
	|-Dictionary<Nullable<RectInt>, object>.Resize
	|
	|-RVA: 0x2F02F80 Offset: 0x2F03081 VA: 0x2F02F80
	|-Dictionary<Nullable<Vector2>, object>.Resize
	|
	|-RVA: 0x2F06850 Offset: 0x2F06951 VA: 0x2F06850
	|-Dictionary<Nullable<Vector2Int>, object>.Resize
	|
	|-RVA: 0x2F0A0E0 Offset: 0x2F0A1E1 VA: 0x2F0A0E0
	|-Dictionary<Nullable<Vector3>, object>.Resize
	|
	|-RVA: 0x2F0D920 Offset: 0x2F0DA21 VA: 0x2F0D920
	|-Dictionary<Nullable<Vector3Int>, object>.Resize
	|
	|-RVA: 0x2F11410 Offset: 0x2F11511 VA: 0x2F11410
	|-Dictionary<Nullable<Vector4>, object>.Resize
	|
	|-RVA: 0x2F14CC0 Offset: 0x2F14DC1 VA: 0x2F14CC0
	|-Dictionary<object, BitVector32Int>.Resize
	|
	|-RVA: 0x2F185D0 Offset: 0x2F186D1 VA: 0x2F185D0
	|-Dictionary<object, EventCheckId>.Resize
	|
	|-RVA: 0x2FF5040 Offset: 0x2FF5141 VA: 0x2FF5040
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.Resize
	|
	|-RVA: 0x2FF8AD0 Offset: 0x2FF8BD1 VA: 0x2FF8AD0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.Resize
	|
	|-RVA: 0x2FFC2E0 Offset: 0x2FFC3E1 VA: 0x2FFC2E0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.Resize
	|
	|-RVA: 0x2FFF9F0 Offset: 0x2FFFAF1 VA: 0x2FFF9F0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.Resize
	|
	|-RVA: 0x30033D0 Offset: 0x30034D1 VA: 0x30033D0
	|-Dictionary<object, MonsterHutSaveData>.Resize
	|
	|-RVA: 0x3006C40 Offset: 0x3006D41 VA: 0x3006C40
	|-Dictionary<object, OrderLotterySaveParameter>.Resize
	|
	|-RVA: 0x300A650 Offset: 0x300A751 VA: 0x300A650
	|-Dictionary<object, OrderSaveData>.Resize
	|
	|-RVA: 0x300E0C0 Offset: 0x300E1C1 VA: 0x300E0C0
	|-Dictionary<object, OrderSaveParameter>.Resize
	|
	|-RVA: 0x2DDF900 Offset: 0x2DDFA01 VA: 0x2DDF900
	|-Dictionary<object, Parameter>.Resize
	|
	|-RVA: 0x2DE31C0 Offset: 0x2DE32C1 VA: 0x2DE31C0
	|-Dictionary<object, NumberControl.ValueRange>.Resize
	|
	|-RVA: 0x2DE6880 Offset: 0x2DE6981 VA: 0x2DE6880
	|-Dictionary<object, bool>.Resize
	|
	|-RVA: 0x2DE9F40 Offset: 0x2DEA041 VA: 0x2DE9F40
	|-Dictionary<object, byte>.Resize
	|
	|-RVA: 0x2DED600 Offset: 0x2DED701 VA: 0x2DED600
	|-Dictionary<object, char>.Resize
	|
	|-RVA: 0x2DF0CC0 Offset: 0x2DF0DC1 VA: 0x2DF0CC0
	|-Dictionary<object, DateTime>.Resize
	|
	|-RVA: 0x2DF4370 Offset: 0x2DF4471 VA: 0x2DF4370
	|-Dictionary<object, double>.Resize
	|
	|-RVA: 0x2DF7A30 Offset: 0x2DF7B31 VA: 0x2DF7A30
	|-Dictionary<object, short>.Resize
	|
	|-RVA: 0x2DFB0F0 Offset: 0x2DFB1F1 VA: 0x2DFB0F0
	|-Dictionary<object, int>.Resize
	|
	|-RVA: 0x30BA6B0 Offset: 0x30BA7B1 VA: 0x30BA6B0
	|-Dictionary<object, Int32Enum>.Resize
	|
	|-RVA: 0x30BDD70 Offset: 0x30BDE71 VA: 0x30BDD70
	|-Dictionary<object, long>.Resize
	|
	|-RVA: 0x30C1490 Offset: 0x30C1591 VA: 0x30C1490
	|-Dictionary<object, Memory<object>>.Resize
	|
	|-RVA: 0x30C4BF0 Offset: 0x30C4CF1 VA: 0x30C4BF0
	|-Dictionary<object, Nullable<Int32Enum>>.Resize
	|
	|-RVA: 0x30C8700 Offset: 0x30C8801 VA: 0x30C8700
	|-Dictionary<object, Nullable<Bounds>>.Resize
	|
	|-RVA: 0x30CC360 Offset: 0x30CC461 VA: 0x30CC360
	|-Dictionary<object, Nullable<BoundsInt>>.Resize
	|
	|-RVA: 0x30CFC50 Offset: 0x30CFD51 VA: 0x30CFC50
	|-Dictionary<object, Nullable<Color32>>.Resize
	|
	|-RVA: 0x30D3640 Offset: 0x30D3741 VA: 0x30D3640
	|-Dictionary<object, Nullable<Color>>.Resize
	|
	|-RVA: 0x30119B0 Offset: 0x3011AB1 VA: 0x30119B0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.Resize
	|
	|-RVA: 0x30153D0 Offset: 0x30154D1 VA: 0x30153D0
	|-Dictionary<object, Nullable<GradientColorKey>>.Resize
	|
	|-RVA: 0x3018EE0 Offset: 0x3018FE1 VA: 0x3018EE0
	|-Dictionary<object, Nullable<Keyframe>>.Resize
	|
	|-RVA: 0x301C7A0 Offset: 0x301C8A1 VA: 0x301C7A0
	|-Dictionary<object, Nullable<LayerMask>>.Resize
	|
	|-RVA: 0x3020570 Offset: 0x3020671 VA: 0x3020570
	|-Dictionary<object, Nullable<Matrix4x4>>.Resize
	|
	|-RVA: 0x3024190 Offset: 0x3024291 VA: 0x3024190
	|-Dictionary<object, Nullable<Quaternion>>.Resize
	|
	|-RVA: 0x3027AC0 Offset: 0x3027BC1 VA: 0x3027AC0
	|-Dictionary<object, Nullable<RangeInt>>.Resize
	|
	|-RVA: 0x302B4E0 Offset: 0x302B5E1 VA: 0x302B4E0
	|-Dictionary<object, Nullable<Rect>>.Resize
	|
	|-RVA: 0x2FD8AC0 Offset: 0x2FD8BC1 VA: 0x2FD8AC0
	|-Dictionary<object, Nullable<RectInt>>.Resize
	|
	|-RVA: 0x2FDC3F0 Offset: 0x2FDC4F1 VA: 0x2FDC3F0
	|-Dictionary<object, Nullable<Vector2>>.Resize
	|
	|-RVA: 0x2FDFC40 Offset: 0x2FDFD41 VA: 0x2FDFC40
	|-Dictionary<object, Nullable<Vector2Int>>.Resize
	|
	|-RVA: 0x2FE3470 Offset: 0x2FE3571 VA: 0x2FE3470
	|-Dictionary<object, Nullable<Vector3>>.Resize
	|
	|-RVA: 0x2FE6C60 Offset: 0x2FE6D61 VA: 0x2FE6C60
	|-Dictionary<object, Nullable<Vector3Int>>.Resize
	|
	|-RVA: 0x2FEA640 Offset: 0x2FEA741 VA: 0x2FEA640
	|-Dictionary<object, Nullable<Vector4>>.Resize
	|
	|-RVA: 0x2FEDE90 Offset: 0x2FEDF91 VA: 0x2FEDE90
	|-Dictionary<object, object>.Resize
	|
	|-RVA: 0x2FF14B0 Offset: 0x2FF15B1 VA: 0x2FF14B0
	|-Dictionary<object, ReadOnlyMemory<object>>.Resize
	|
	|-RVA: 0x2DBFF60 Offset: 0x2DC0061 VA: 0x2DBFF60
	|-Dictionary<object, ResourceLocator>.Resize
	|
	|-RVA: 0x2DC3610 Offset: 0x2DC3711 VA: 0x2DC3610
	|-Dictionary<object, sbyte>.Resize
	|
	|-RVA: 0x2DC6CD0 Offset: 0x2DC6DD1 VA: 0x2DC6CD0
	|-Dictionary<object, float>.Resize
	|
	|-RVA: 0x2DCA390 Offset: 0x2DCA491 VA: 0x2DCA390
	|-Dictionary<object, ushort>.Resize
	|
	|-RVA: 0x2DCDA50 Offset: 0x2DCDB51 VA: 0x2DCDA50
	|-Dictionary<object, uint>.Resize
	|
	|-RVA: 0x2DD1110 Offset: 0x2DD1211 VA: 0x2DD1110
	|-Dictionary<object, ulong>.Resize
	|
	|-RVA: 0x2DD4A30 Offset: 0x2DD4B31 VA: 0x2DD4A30
	|-Dictionary<object, TransitionTables>.Resize
	|
	|-RVA: 0x2DD8410 Offset: 0x2DD8511 VA: 0x2DD8410
	|-Dictionary<object, Bounds>.Resize
	|
	|-RVA: 0x2DDBDD0 Offset: 0x2DDBED1 VA: 0x2DDBDD0
	|-Dictionary<object, BoundsInt>.Resize
	|
	|-RVA: 0x30D6E40 Offset: 0x30D6F41 VA: 0x30D6E40
	|-Dictionary<object, Color32>.Resize
	|
	|-RVA: 0x30DA570 Offset: 0x30DA671 VA: 0x30DA570
	|-Dictionary<object, Color>.Resize
	|
	|-RVA: 0x30DDC50 Offset: 0x30DDD51 VA: 0x30DDC50
	|-Dictionary<object, GradientAlphaKey>.Resize
	|
	|-RVA: 0x30E1540 Offset: 0x30E1641 VA: 0x30E1540
	|-Dictionary<object, GradientColorKey>.Resize
	|
	|-RVA: 0x30E5020 Offset: 0x30E5121 VA: 0x30E5020
	|-Dictionary<object, Keyframe>.Resize
	|
	|-RVA: 0x30E8820 Offset: 0x30E8921 VA: 0x30E8820
	|-Dictionary<object, LayerMask>.Resize
	|
	|-RVA: 0x30EC350 Offset: 0x30EC451 VA: 0x30EC350
	|-Dictionary<object, Matrix4x4>.Resize
	|
	|-RVA: 0x30EFBE0 Offset: 0x30EFCE1 VA: 0x30EFBE0
	|-Dictionary<object, Playable>.Resize
	|
	|-RVA: 0x309EA00 Offset: 0x309EB01 VA: 0x309EA00
	|-Dictionary<object, Quaternion>.Resize
	|
	|-RVA: 0x30A20B0 Offset: 0x30A21B1 VA: 0x30A20B0
	|-Dictionary<object, RangeInt>.Resize
	|
	|-RVA: 0x30A57D0 Offset: 0x30A58D1 VA: 0x30A57D0
	|-Dictionary<object, Rect>.Resize
	|
	|-RVA: 0x30A8ED0 Offset: 0x30A8FD1 VA: 0x30A8ED0
	|-Dictionary<object, RectInt>.Resize
	|
	|-RVA: 0x30AC7B0 Offset: 0x30AC8B1 VA: 0x30AC7B0
	|-Dictionary<object, AsyncOperationHandle>.Resize
	|
	|-RVA: 0x30B0180 Offset: 0x30B0281 VA: 0x30B0180
	|-Dictionary<object, AsyncOperationHandle<object>>.Resize
	|
	|-RVA: 0x30B3940 Offset: 0x30B3A41 VA: 0x30B3940
	|-Dictionary<object, Vector2>.Resize
	|
	|-RVA: 0x30B7000 Offset: 0x30B7101 VA: 0x30B7000
	|-Dictionary<object, Vector2Int>.Resize
	|
	|-RVA: 0x3082CE0 Offset: 0x3082DE1 VA: 0x3082CE0
	|-Dictionary<object, Vector3>.Resize
	|
	|-RVA: 0x3086410 Offset: 0x3086511 VA: 0x3086410
	|-Dictionary<object, Vector3Int>.Resize
	|
	|-RVA: 0x3089B40 Offset: 0x3089C41 VA: 0x3089B40
	|-Dictionary<object, Vector4>.Resize
	|
	|-RVA: 0x308D270 Offset: 0x308D371 VA: 0x308D270
	|-Dictionary<ReadOnlyMemory<object>, object>.Resize
	|
	|-RVA: 0x3090810 Offset: 0x3090911 VA: 0x3090810
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.Resize
	|
	|-RVA: 0x3093F00 Offset: 0x3094001 VA: 0x3093F00
	|-Dictionary<sbyte, object>.Resize
	|
	|-RVA: 0x3097AA0 Offset: 0x3097BA1 VA: 0x3097AA0
	|-Dictionary<float, CurveSample>.Resize
	|
	|-RVA: 0x309B370 Offset: 0x309B471 VA: 0x309B370
	|-Dictionary<float, object>.Resize
	|
	|-RVA: 0x319E8D0 Offset: 0x319E9D1 VA: 0x319E8D0
	|-Dictionary<ushort, object>.Resize
	|
	|-RVA: 0x31A1E30 Offset: 0x31A1F31 VA: 0x31A1E30
	|-Dictionary<uint, int>.Resize
	|
	|-RVA: 0x31A53F0 Offset: 0x31A54F1 VA: 0x31A53F0
	|-Dictionary<uint, Int32Enum>.Resize
	|
	|-RVA: 0x31A8A70 Offset: 0x31A8B71 VA: 0x31A8A70
	|-Dictionary<uint, object>.Resize
	|
	|-RVA: 0x31AC090 Offset: 0x31AC191 VA: 0x31AC090
	|-Dictionary<ulong, object>.Resize
	|
	|-RVA: 0x31AF640 Offset: 0x31AF741 VA: 0x31AF640
	|-Dictionary<EdgeKeyByHash, int>.Resize
	|
	|-RVA: 0x31B3080 Offset: 0x31B3181 VA: 0x31B3080
	|-Dictionary<EdgeKeyByHash, CapEdge>.Resize
	|
	|-RVA: 0x31B6BD0 Offset: 0x31B6CD1 VA: 0x31B6BD0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Resize
	|
	|-RVA: 0x302EEA0 Offset: 0x302EFA1 VA: 0x302EEA0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.Resize
	|
	|-RVA: 0x3032630 Offset: 0x3032731 VA: 0x3032630
	|-Dictionary<MeshDataConnectivity.Face, bool>.Resize
	|
	|-RVA: 0x3035D10 Offset: 0x3035E11 VA: 0x3035D10
	|-Dictionary<MeshDataConnectivity.Face, object>.Resize
	|
	|-RVA: 0x3039650 Offset: 0x3039751 VA: 0x3039650
	|-Dictionary<Bounds, object>.Resize
	|
	|-RVA: 0x303D180 Offset: 0x303D281 VA: 0x303D180
	|-Dictionary<BoundsInt, object>.Resize
	|
	|-RVA: 0x3040A70 Offset: 0x3040B71 VA: 0x3040A70
	|-Dictionary<Color, object>.Resize
	|
	|-RVA: 0x3044120 Offset: 0x3044221 VA: 0x3044120
	|-Dictionary<Color32, object>.Resize
	|
	|-RVA: 0x3047750 Offset: 0x3047851 VA: 0x3047750
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Resize
	|
	|-RVA: 0x30662E0 Offset: 0x30663E1 VA: 0x30662E0
	|-Dictionary<GradientAlphaKey, object>.Resize
	|
	|-RVA: 0x3069C20 Offset: 0x3069D21 VA: 0x3069C20
	|-Dictionary<GradientColorKey, object>.Resize
	|
	|-RVA: 0x306D8C0 Offset: 0x306D9C1 VA: 0x306D8C0
	|-Dictionary<Keyframe, object>.Resize
	|
	|-RVA: 0x30711E0 Offset: 0x30712E1 VA: 0x30711E0
	|-Dictionary<LayerMask, object>.Resize
	|
	|-RVA: 0x3074E30 Offset: 0x3074F31 VA: 0x3074E30
	|-Dictionary<Matrix4x4, object>.Resize
	|
	|-RVA: 0x30788B0 Offset: 0x30789B1 VA: 0x30788B0
	|-Dictionary<IntVec3, object>.Resize
	|
	|-RVA: 0x307BFE0 Offset: 0x307C0E1 VA: 0x307BFE0
	|-Dictionary<Quaternion, object>.Resize
	|
	|-RVA: 0x307F660 Offset: 0x307F761 VA: 0x307F660
	|-Dictionary<RangeInt, object>.Resize
	|
	|-RVA: 0x304AE50 Offset: 0x304AF51 VA: 0x304AE50
	|-Dictionary<Rect, object>.Resize
	|
	|-RVA: 0x304E550 Offset: 0x304E651 VA: 0x304E550
	|-Dictionary<RectInt, object>.Resize
	|
	|-RVA: 0x3051AE0 Offset: 0x3051BE1 VA: 0x3051AE0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.Resize
	|
	|-RVA: 0x30551C0 Offset: 0x30552C1 VA: 0x30551C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Resize
	|
	|-RVA: 0x3058840 Offset: 0x3058941 VA: 0x3058840
	|-Dictionary<Vector2, object>.Resize
	|
	|-RVA: 0x305BE60 Offset: 0x305BF61 VA: 0x305BE60
	|-Dictionary<Vector2Int, object>.Resize
	|
	|-RVA: 0x305F520 Offset: 0x305F621 VA: 0x305F520
	|-Dictionary<Vector3, object>.Resize
	|
	|-RVA: 0x3062C20 Offset: 0x3062D21 VA: 0x3062C20
	|-Dictionary<Vector3Int, object>.Resize
	|
	|-RVA: 0x2E3C640 Offset: 0x2E3C741 VA: 0x2E3C640
	|-Dictionary<Vector4, object>.Resize
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEE150 Offset: 0x2FEE251 VA: 0x2FEE150
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>.Remove
	|-Dictionary<BehaviorManager.ThirdPartyTask, object>.Remove
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.Remove
	|-Dictionary<Tween, TweenLink>.Remove
	|-Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>>.Remove
	|-Dictionary<OptionDefinition, OptionsControlBase>.Remove
	|-Dictionary<Action, LinkedListNode<Action>>.Remove
	|-Dictionary<object, BehaviorManager.ThirdPartyTask>.Remove
	|-Dictionary<object, ICollection<OptionDefinition>>.Remove
	|-Dictionary<object, object>.Remove
	|-Dictionary<string, List<TaskCoroutine>>.Remove
	|-Dictionary<string, LocalDataStoreSlot>.Remove
	|-Dictionary<string, WebConnectionGroup>.Remove
	|-Dictionary<string, object>.Remove
	|-Dictionary<Thread, StackTrace>.Remove
	|-Dictionary<TimeParamTable, HashSet<MaterialChangeTime>>.Remove
	|-Dictionary<TimeParamTable, HashSet<ObjectChangeTime>>.Remove
	|-Dictionary<TimeParamTable, HashSet<RendererChangeTime>>.Remove
	|-Dictionary<Canvas, IndexedSet<Graphic>>.Remove
	|-Dictionary<Collider, CharacterBase>.Remove
	|-Dictionary<Collider, CharacterNearCullingController>.Remove
	|-Dictionary<Font, HashSet<Text>>.Remove
	|-Dictionary<GameObject, Renderer[]>.Remove
	|-Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>.Remove
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.Remove
	|
	|-RVA: 0x2A18260 Offset: 0x2A18361 VA: 0x2A18260
	|-Dictionary<JSONDeserialization.TaskField, object>.Remove
	|
	|-RVA: 0x2A1B890 Offset: 0x2A1B991 VA: 0x2A1B890
	|-Dictionary<BitVector32Int, object>.Remove
	|
	|-RVA: 0x2DC6F90 Offset: 0x2DC7091 VA: 0x2DC6F90
	|-Dictionary<Character, float>.Remove
	|-Dictionary<object, float>.Remove
	|
	|-RVA: 0x2E2EEE0 Offset: 0x2E2EFE1 VA: 0x2E2EEE0
	|-Dictionary<ActorID, LifeCycleScriptPlayer>.Remove
	|-Dictionary<ActorID, List<MonsterDataID>>.Remove
	|-Dictionary<ActorID, SphereCollider>.Remove
	|-Dictionary<AttackAttribute, ParticleSystem>.Remove
	|-Dictionary<ToolChargeLevel, ParticleSystem>.Remove
	|-Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox>.Remove
	|-Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox>.Remove
	|-Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox>.Remove
	|-Dictionary<FieldWoodBoxSpawnID, GameObject>.Remove
	|-Dictionary<GateDataID, GateController>.Remove
	|-Dictionary<GimmickLayoutID, HashSet<GimmickBase>>.Remove
	|-Dictionary<ItemID, ItemPoolData>.Remove
	|-Dictionary<Texture, Texture>.Remove
	|-Dictionary<MoveParamID, CharacterMoveParam>.Remove
	|-Dictionary<SoundID, EnvironmentSoundDataTable>.Remove
	|-Dictionary<SoundID, EnvironmentSoundController>.Remove
	|-Dictionary<Int32Enum, object>.Remove
	|
	|-RVA: 0x2E32430 Offset: 0x2E32531 VA: 0x2E32430
	|-Dictionary<ActorID, float>.Remove
	|-Dictionary<AttackAttribute, float>.Remove
	|-Dictionary<Int32Enum, float>.Remove
	|
	|-RVA: 0x2E2B850 Offset: 0x2E2B951 VA: 0x2E2B850
	|-Dictionary<Season, Texture>.Remove
	|-Dictionary<Int32Enum, Int32Enum>.Remove
	|
	|-RVA: 0x2F7A910 Offset: 0x2F7AA11 VA: 0x2F7A910
	|-Dictionary<EventCheckId, object>.Remove
	|
	|-RVA: 0x2F7E800 Offset: 0x2F7E901 VA: 0x2F7E800
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.Remove
	|
	|-RVA: 0x2F82510 Offset: 0x2F82611 VA: 0x2F82510
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.Remove
	|
	|-RVA: 0x2F85DA0 Offset: 0x2F85EA1 VA: 0x2F85DA0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.Remove
	|
	|-RVA: 0x2F89480 Offset: 0x2F89581 VA: 0x2F89480
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.Remove
	|
	|-RVA: 0x2DFB3B0 Offset: 0x2DFB4B1 VA: 0x2DFB3B0
	|-Dictionary<MonsterControllerBase, int>.Remove
	|-Dictionary<OnGroundItem, int>.Remove
	|-Dictionary<ParameterExpression, int>.Remove
	|-Dictionary<object, int>.Remove
	|
	|-RVA: 0x2F8CF50 Offset: 0x2F8D051 VA: 0x2F8CF50
	|-Dictionary<MonsterHutSaveData, object>.Remove
	|
	|-RVA: 0x2F908C0 Offset: 0x2F909C1 VA: 0x2F908C0
	|-Dictionary<OrderLotterySaveParameter, object>.Remove
	|
	|-RVA: 0x2F943F0 Offset: 0x2F944F1 VA: 0x2F943F0
	|-Dictionary<OrderSaveData, object>.Remove
	|
	|-RVA: 0x2D823A0 Offset: 0x2D824A1 VA: 0x2D823A0
	|-Dictionary<OrderSaveParameter, object>.Remove
	|
	|-RVA: 0x2D86060 Offset: 0x2D86161 VA: 0x2D86060
	|-Dictionary<Parameter, object>.Remove
	|
	|-RVA: 0x2D89950 Offset: 0x2D89A51 VA: 0x2D89950
	|-Dictionary<bool, object>.Remove
	|
	|-RVA: 0x2D8CF80 Offset: 0x2D8D081 VA: 0x2D8CF80
	|-Dictionary<byte, object>.Remove
	|
	|-RVA: 0x2D905A0 Offset: 0x2D906A1 VA: 0x2D905A0
	|-Dictionary<char, object>.Remove
	|
	|-RVA: 0x2D93BC0 Offset: 0x2D93CC1 VA: 0x2D93BC0
	|-Dictionary<DateTime, object>.Remove
	|
	|-RVA: 0x2D971E0 Offset: 0x2D972E1 VA: 0x2D971E0
	|-Dictionary<double, object>.Remove
	|
	|-RVA: 0x2D9A870 Offset: 0x2D9A971 VA: 0x2D9A870
	|-Dictionary<Guid, object>.Remove
	|
	|-RVA: 0x2D9DE70 Offset: 0x2D9DF71 VA: 0x2D9DE70
	|-Dictionary<short, object>.Remove
	|
	|-RVA: 0x2F61810 Offset: 0x2F61911 VA: 0x2F61810
	|-Dictionary<int, BehaviorManager.BehaviorTree.ConditionalReevaluate>.Remove
	|-Dictionary<int, BossBehaviorController>.Remove
	|-Dictionary<int, FishSwim>.Remove
	|-Dictionary<int, AssetHandle>.Remove
	|-Dictionary<int, MonsterBehaviorController>.Remove
	|-Dictionary<int, OnGroundItem>.Remove
	|-Dictionary<int, PartnerNPCBehaviorController>.Remove
	|-Dictionary<int, List<object>>.Remove
	|-Dictionary<int, List<TimeManager.JustTimerData>>.Remove
	|-Dictionary<int, object>.Remove
	|-Dictionary<int, string>.Remove
	|-Dictionary<int, Task>.Remove
	|-Dictionary<int, TextureChangeMaterialParam>.Remove
	|-Dictionary<int, DiagnosticInfo>.Remove
	|-Dictionary<int, PointerEventData>.Remove
	|-Dictionary<int, TerrainUtility.TerrainMap>.Remove
	|-Dictionary<int, IAsyncOperation>.Remove
	|-Dictionary<int, Panel>.Remove
	|
	|-RVA: 0x2D3C360 Offset: 0x2D3C461 VA: 0x2D3C360
	|-Dictionary<int, CropDataTable>.Remove
	|
	|-RVA: 0x2D3FDF0 Offset: 0x2D3FEF1 VA: 0x2D3FDF0
	|-Dictionary<int, EffectDataTable>.Remove
	|
	|-RVA: 0x2D434F0 Offset: 0x2D435F1 VA: 0x2D434F0
	|-Dictionary<int, GimmickLayoutDataTable>.Remove
	|
	|-RVA: 0x2D46FB0 Offset: 0x2D470B1 VA: 0x2D46FB0
	|-Dictionary<int, MineTypeDataTable>.Remove
	|
	|-RVA: 0x2D4A830 Offset: 0x2D4A931 VA: 0x2D4A830
	|-Dictionary<int, MiningDataTable>.Remove
	|
	|-RVA: 0x2D4DE70 Offset: 0x2D4DF71 VA: 0x2D4DE70
	|-Dictionary<int, bool>.Remove
	|
	|-RVA: 0x2D51430 Offset: 0x2D51531 VA: 0x2D51430
	|-Dictionary<int, char>.Remove
	|
	|-RVA: 0x2D549F0 Offset: 0x2D54AF1 VA: 0x2D549F0
	|-Dictionary<int, int>.Remove
	|
	|-RVA: 0x2D57FB0 Offset: 0x2D580B1 VA: 0x2D57FB0
	|-Dictionary<int, Int32Enum>.Remove
	|
	|-RVA: 0x2F5E120 Offset: 0x2F5E221 VA: 0x2F5E120
	|-Dictionary<int, long>.Remove
	|
	|-RVA: 0x2F65120 Offset: 0x2F65221 VA: 0x2F65120
	|-Dictionary<int, DiagnosticEvent>.Remove
	|
	|-RVA: 0x2F68930 Offset: 0x2F68A31 VA: 0x2F68930
	|-Dictionary<int, SceneInstance>.Remove
	|
	|-RVA: 0x2F6BFC0 Offset: 0x2F6C0C1 VA: 0x2F6BFC0
	|-Dictionary<int, Vector2Int>.Remove
	|
	|-RVA: 0x2F6F6B0 Offset: 0x2F6F7B1 VA: 0x2F6F6B0
	|-Dictionary<int, Vector3>.Remove
	|
	|-RVA: 0x2F73190 Offset: 0x2F73291 VA: 0x2F73190
	|-Dictionary<Int32Enum, MonsterDataTable>.Remove
	|
	|-RVA: 0x2F76D90 Offset: 0x2F76E91 VA: 0x2F76D90
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.Remove
	|
	|-RVA: 0x2E1DFF0 Offset: 0x2E1E0F1 VA: 0x2E1DFF0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.Remove
	|
	|-RVA: 0x2E21650 Offset: 0x2E21751 VA: 0x2E21650
	|-Dictionary<Int32Enum, bool>.Remove
	|
	|-RVA: 0x2E24C80 Offset: 0x2E24D81 VA: 0x2E24C80
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.Remove
	|
	|-RVA: 0x2E28290 Offset: 0x2E28391 VA: 0x2E28290
	|-Dictionary<Int32Enum, int>.Remove
	|
	|-RVA: 0x2E35AA0 Offset: 0x2E35BA1 VA: 0x2E35AA0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x2E39140 Offset: 0x2E39241 VA: 0x2E39140
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.Remove
	|
	|-RVA: 0x2F97CC0 Offset: 0x2F97DC1 VA: 0x2F97CC0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.Remove
	|
	|-RVA: 0x2F9B400 Offset: 0x2F9B501 VA: 0x2F9B400
	|-Dictionary<long, object>.Remove
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>.Remove
	|
	|-RVA: 0x2F9EAB0 Offset: 0x2F9EBB1 VA: 0x2F9EAB0
	|-Dictionary<Memory<object>, object>.Remove
	|
	|-RVA: 0x2FA21F0 Offset: 0x2FA22F1 VA: 0x2FA21F0
	|-Dictionary<Nullable<Int32Enum>, object>.Remove
	|
	|-RVA: 0x2FA5EC0 Offset: 0x2FA5FC1 VA: 0x2FA5EC0
	|-Dictionary<Nullable<Bounds>, object>.Remove
	|
	|-RVA: 0x2FA9E20 Offset: 0x2FA9F21 VA: 0x2FA9E20
	|-Dictionary<Nullable<BoundsInt>, object>.Remove
	|
	|-RVA: 0x2FAD890 Offset: 0x2FAD991 VA: 0x2FAD890
	|-Dictionary<Nullable<Color32>, object>.Remove
	|
	|-RVA: 0x2FB13C0 Offset: 0x2FB14C1 VA: 0x2FB13C0
	|-Dictionary<Nullable<Color>, object>.Remove
	|
	|-RVA: 0x2F1C210 Offset: 0x2F1C311 VA: 0x2F1C210
	|-Dictionary<Nullable<GradientAlphaKey>, object>.Remove
	|
	|-RVA: 0x2F1FD80 Offset: 0x2F1FE81 VA: 0x2F1FD80
	|-Dictionary<Nullable<GradientColorKey>, object>.Remove
	|
	|-RVA: 0x2F23AA0 Offset: 0x2F23BA1 VA: 0x2F23AA0
	|-Dictionary<Nullable<Keyframe>, object>.Remove
	|
	|-RVA: 0x2F27460 Offset: 0x2F27561 VA: 0x2F27460
	|-Dictionary<Nullable<LayerMask>, object>.Remove
	|
	|-RVA: 0x2F2B560 Offset: 0x2F2B661 VA: 0x2F2B560
	|-Dictionary<Nullable<Matrix4x4>, object>.Remove
	|
	|-RVA: 0x2F2F500 Offset: 0x2F2F601 VA: 0x2F2F500
	|-Dictionary<Nullable<Quaternion>, object>.Remove
	|
	|-RVA: 0x2F32F60 Offset: 0x2F33061 VA: 0x2F32F60
	|-Dictionary<Nullable<RangeInt>, object>.Remove
	|
	|-RVA: 0x2F36AD0 Offset: 0x2F36BD1 VA: 0x2F36AD0
	|-Dictionary<Nullable<Rect>, object>.Remove
	|
	|-RVA: 0x2EFF7E0 Offset: 0x2EFF8E1 VA: 0x2EFF7E0
	|-Dictionary<Nullable<RectInt>, object>.Remove
	|
	|-RVA: 0x2F03240 Offset: 0x2F03341 VA: 0x2F03240
	|-Dictionary<Nullable<Vector2>, object>.Remove
	|
	|-RVA: 0x2F06B10 Offset: 0x2F06C11 VA: 0x2F06B10
	|-Dictionary<Nullable<Vector2Int>, object>.Remove
	|
	|-RVA: 0x2F0A3A0 Offset: 0x2F0A4A1 VA: 0x2F0A3A0
	|-Dictionary<Nullable<Vector3>, object>.Remove
	|
	|-RVA: 0x2F0DBE0 Offset: 0x2F0DCE1 VA: 0x2F0DBE0
	|-Dictionary<Nullable<Vector3Int>, object>.Remove
	|
	|-RVA: 0x2F11700 Offset: 0x2F11801 VA: 0x2F11700
	|-Dictionary<Nullable<Vector4>, object>.Remove
	|
	|-RVA: 0x2F14F80 Offset: 0x2F15081 VA: 0x2F14F80
	|-Dictionary<object, BitVector32Int>.Remove
	|
	|-RVA: 0x2F18890 Offset: 0x2F18991 VA: 0x2F18890
	|-Dictionary<object, EventCheckId>.Remove
	|
	|-RVA: 0x2FF5300 Offset: 0x2FF5401 VA: 0x2FF5300
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.Remove
	|
	|-RVA: 0x2FF8D90 Offset: 0x2FF8E91 VA: 0x2FF8D90
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.Remove
	|
	|-RVA: 0x2FFC590 Offset: 0x2FFC691 VA: 0x2FFC590
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.Remove
	|
	|-RVA: 0x2FFFCA0 Offset: 0x2FFFDA1 VA: 0x2FFFCA0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.Remove
	|
	|-RVA: 0x3003690 Offset: 0x3003791 VA: 0x3003690
	|-Dictionary<object, MonsterHutSaveData>.Remove
	|
	|-RVA: 0x3006EF0 Offset: 0x3006FF1 VA: 0x3006EF0
	|-Dictionary<object, OrderLotterySaveParameter>.Remove
	|
	|-RVA: 0x300A910 Offset: 0x300AA11 VA: 0x300A910
	|-Dictionary<object, OrderSaveData>.Remove
	|
	|-RVA: 0x300E380 Offset: 0x300E481 VA: 0x300E380
	|-Dictionary<object, OrderSaveParameter>.Remove
	|
	|-RVA: 0x2DDFBC0 Offset: 0x2DDFCC1 VA: 0x2DDFBC0
	|-Dictionary<object, Parameter>.Remove
	|
	|-RVA: 0x2DE3470 Offset: 0x2DE3571 VA: 0x2DE3470
	|-Dictionary<object, NumberControl.ValueRange>.Remove
	|
	|-RVA: 0x2DE6B40 Offset: 0x2DE6C41 VA: 0x2DE6B40
	|-Dictionary<object, bool>.Remove
	|
	|-RVA: 0x2DEA200 Offset: 0x2DEA301 VA: 0x2DEA200
	|-Dictionary<object, byte>.Remove
	|
	|-RVA: 0x2DED8C0 Offset: 0x2DED9C1 VA: 0x2DED8C0
	|-Dictionary<object, char>.Remove
	|
	|-RVA: 0x2DF0F80 Offset: 0x2DF1081 VA: 0x2DF0F80
	|-Dictionary<object, DateTime>.Remove
	|
	|-RVA: 0x2DF4630 Offset: 0x2DF4731 VA: 0x2DF4630
	|-Dictionary<object, double>.Remove
	|
	|-RVA: 0x2DF7CF0 Offset: 0x2DF7DF1 VA: 0x2DF7CF0
	|-Dictionary<object, short>.Remove
	|
	|-RVA: 0x30BA970 Offset: 0x30BAA71 VA: 0x30BA970
	|-Dictionary<object, Int32Enum>.Remove
	|-Dictionary<GameObject, Prefab>.Remove
	|
	|-RVA: 0x30BE030 Offset: 0x30BE131 VA: 0x30BE030
	|-Dictionary<object, long>.Remove
	|
	|-RVA: 0x30C1740 Offset: 0x30C1841 VA: 0x30C1740
	|-Dictionary<object, Memory<object>>.Remove
	|
	|-RVA: 0x30C4EB0 Offset: 0x30C4FB1 VA: 0x30C4EB0
	|-Dictionary<object, Nullable<Int32Enum>>.Remove
	|
	|-RVA: 0x30C89C0 Offset: 0x30C8AC1 VA: 0x30C89C0
	|-Dictionary<object, Nullable<Bounds>>.Remove
	|
	|-RVA: 0x30CC620 Offset: 0x30CC721 VA: 0x30CC620
	|-Dictionary<object, Nullable<BoundsInt>>.Remove
	|
	|-RVA: 0x30CFF10 Offset: 0x30D0011 VA: 0x30CFF10
	|-Dictionary<object, Nullable<Color32>>.Remove
	|
	|-RVA: 0x30D3900 Offset: 0x30D3A01 VA: 0x30D3900
	|-Dictionary<object, Nullable<Color>>.Remove
	|
	|-RVA: 0x3011C60 Offset: 0x3011D61 VA: 0x3011C60
	|-Dictionary<object, Nullable<GradientAlphaKey>>.Remove
	|
	|-RVA: 0x3015690 Offset: 0x3015791 VA: 0x3015690
	|-Dictionary<object, Nullable<GradientColorKey>>.Remove
	|
	|-RVA: 0x30191A0 Offset: 0x30192A1 VA: 0x30191A0
	|-Dictionary<object, Nullable<Keyframe>>.Remove
	|
	|-RVA: 0x301CA60 Offset: 0x301CB61 VA: 0x301CA60
	|-Dictionary<object, Nullable<LayerMask>>.Remove
	|
	|-RVA: 0x3020830 Offset: 0x3020931 VA: 0x3020830
	|-Dictionary<object, Nullable<Matrix4x4>>.Remove
	|
	|-RVA: 0x3024450 Offset: 0x3024551 VA: 0x3024450
	|-Dictionary<object, Nullable<Quaternion>>.Remove
	|
	|-RVA: 0x3027D70 Offset: 0x3027E71 VA: 0x3027D70
	|-Dictionary<object, Nullable<RangeInt>>.Remove
	|
	|-RVA: 0x302B7A0 Offset: 0x302B8A1 VA: 0x302B7A0
	|-Dictionary<object, Nullable<Rect>>.Remove
	|
	|-RVA: 0x2FD8D80 Offset: 0x2FD8E81 VA: 0x2FD8D80
	|-Dictionary<object, Nullable<RectInt>>.Remove
	|
	|-RVA: 0x2FDC6A0 Offset: 0x2FDC7A1 VA: 0x2FDC6A0
	|-Dictionary<object, Nullable<Vector2>>.Remove
	|
	|-RVA: 0x2FDFEF0 Offset: 0x2FDFFF1 VA: 0x2FDFEF0
	|-Dictionary<object, Nullable<Vector2Int>>.Remove
	|
	|-RVA: 0x2FE3720 Offset: 0x2FE3821 VA: 0x2FE3720
	|-Dictionary<object, Nullable<Vector3>>.Remove
	|
	|-RVA: 0x2FE6F10 Offset: 0x2FE7011 VA: 0x2FE6F10
	|-Dictionary<object, Nullable<Vector3Int>>.Remove
	|
	|-RVA: 0x2FEA900 Offset: 0x2FEAA01 VA: 0x2FEA900
	|-Dictionary<object, Nullable<Vector4>>.Remove
	|
	|-RVA: 0x2FF1760 Offset: 0x2FF1861 VA: 0x2FF1760
	|-Dictionary<object, ReadOnlyMemory<object>>.Remove
	|
	|-RVA: 0x2DC0210 Offset: 0x2DC0311 VA: 0x2DC0210
	|-Dictionary<object, ResourceLocator>.Remove
	|
	|-RVA: 0x2DC38D0 Offset: 0x2DC39D1 VA: 0x2DC38D0
	|-Dictionary<object, sbyte>.Remove
	|
	|-RVA: 0x2DCA650 Offset: 0x2DCA751 VA: 0x2DCA650
	|-Dictionary<object, ushort>.Remove
	|
	|-RVA: 0x2DCDD10 Offset: 0x2DCDE11 VA: 0x2DCDD10
	|-Dictionary<object, uint>.Remove
	|
	|-RVA: 0x2DD13D0 Offset: 0x2DD14D1 VA: 0x2DD13D0
	|-Dictionary<object, ulong>.Remove
	|
	|-RVA: 0x2DD4CF0 Offset: 0x2DD4DF1 VA: 0x2DD4CF0
	|-Dictionary<object, TransitionTables>.Remove
	|
	|-RVA: 0x2DD86D0 Offset: 0x2DD87D1 VA: 0x2DD86D0
	|-Dictionary<object, Bounds>.Remove
	|
	|-RVA: 0x2DDC090 Offset: 0x2DDC191 VA: 0x2DDC090
	|-Dictionary<object, BoundsInt>.Remove
	|
	|-RVA: 0x30D7100 Offset: 0x30D7201 VA: 0x30D7100
	|-Dictionary<object, Color32>.Remove
	|
	|-RVA: 0x30DA820 Offset: 0x30DA921 VA: 0x30DA820
	|-Dictionary<object, Color>.Remove
	|
	|-RVA: 0x30DDF10 Offset: 0x30DE011 VA: 0x30DDF10
	|-Dictionary<object, GradientAlphaKey>.Remove
	|
	|-RVA: 0x30E1800 Offset: 0x30E1901 VA: 0x30E1800
	|-Dictionary<object, GradientColorKey>.Remove
	|
	|-RVA: 0x30E52E0 Offset: 0x30E53E1 VA: 0x30E52E0
	|-Dictionary<object, Keyframe>.Remove
	|
	|-RVA: 0x30E8AE0 Offset: 0x30E8BE1 VA: 0x30E8AE0
	|-Dictionary<object, LayerMask>.Remove
	|
	|-RVA: 0x30EC610 Offset: 0x30EC711 VA: 0x30EC610
	|-Dictionary<object, Matrix4x4>.Remove
	|
	|-RVA: 0x30EFE90 Offset: 0x30EFF91 VA: 0x30EFE90
	|-Dictionary<object, Playable>.Remove
	|
	|-RVA: 0x309ECB0 Offset: 0x309EDB1 VA: 0x309ECB0
	|-Dictionary<object, Quaternion>.Remove
	|
	|-RVA: 0x30A2370 Offset: 0x30A2471 VA: 0x30A2370
	|-Dictionary<object, RangeInt>.Remove
	|
	|-RVA: 0x30A5A80 Offset: 0x30A5B81 VA: 0x30A5A80
	|-Dictionary<object, Rect>.Remove
	|
	|-RVA: 0x30A9180 Offset: 0x30A9281 VA: 0x30A9180
	|-Dictionary<object, RectInt>.Remove
	|
	|-RVA: 0x30ACA70 Offset: 0x30ACB71 VA: 0x30ACA70
	|-Dictionary<object, AsyncOperationHandle>.Remove
	|
	|-RVA: 0x30B0440 Offset: 0x30B0541 VA: 0x30B0440
	|-Dictionary<object, AsyncOperationHandle<object>>.Remove
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>.Remove
	|
	|-RVA: 0x30B3C00 Offset: 0x30B3D01 VA: 0x30B3C00
	|-Dictionary<object, Vector2>.Remove
	|
	|-RVA: 0x30B72C0 Offset: 0x30B73C1 VA: 0x30B72C0
	|-Dictionary<object, Vector2Int>.Remove
	|
	|-RVA: 0x3082F90 Offset: 0x3083091 VA: 0x3082F90
	|-Dictionary<object, Vector3>.Remove
	|
	|-RVA: 0x30866C0 Offset: 0x30867C1 VA: 0x30866C0
	|-Dictionary<object, Vector3Int>.Remove
	|
	|-RVA: 0x3089DF0 Offset: 0x3089EF1 VA: 0x3089DF0
	|-Dictionary<object, Vector4>.Remove
	|
	|-RVA: 0x308D530 Offset: 0x308D631 VA: 0x308D530
	|-Dictionary<ReadOnlyMemory<object>, object>.Remove
	|
	|-RVA: 0x3090AD0 Offset: 0x3090BD1 VA: 0x3090AD0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.Remove
	|
	|-RVA: 0x30941C0 Offset: 0x30942C1 VA: 0x30941C0
	|-Dictionary<sbyte, object>.Remove
	|
	|-RVA: 0x3097D60 Offset: 0x3097E61 VA: 0x3097D60
	|-Dictionary<float, CurveSample>.Remove
	|
	|-RVA: 0x309B630 Offset: 0x309B731 VA: 0x309B630
	|-Dictionary<float, object>.Remove
	|
	|-RVA: 0x319EB90 Offset: 0x319EC91 VA: 0x319EB90
	|-Dictionary<ushort, object>.Remove
	|
	|-RVA: 0x31A56A0 Offset: 0x31A57A1 VA: 0x31A56A0
	|-Dictionary<uint, ActorID>.Remove
	|-Dictionary<uint, Int32Enum>.Remove
	|
	|-RVA: 0x31A8D30 Offset: 0x31A8E31 VA: 0x31A8D30
	|-Dictionary<uint, FarmMonsterBehaviorController>.Remove
	|-Dictionary<uint, FriendMonsterStatus>.Remove
	|-Dictionary<uint, object>.Remove
	|
	|-RVA: 0x31A20E0 Offset: 0x31A21E1 VA: 0x31A20E0
	|-Dictionary<uint, int>.Remove
	|
	|-RVA: 0x31AC350 Offset: 0x31AC451 VA: 0x31AC350
	|-Dictionary<ulong, object>.Remove
	|
	|-RVA: 0x31AF900 Offset: 0x31AFA01 VA: 0x31AF900
	|-Dictionary<EdgeKeyByHash, int>.Remove
	|
	|-RVA: 0x31B3340 Offset: 0x31B3441 VA: 0x31B3340
	|-Dictionary<EdgeKeyByHash, CapEdge>.Remove
	|
	|-RVA: 0x31B6E80 Offset: 0x31B6F81 VA: 0x31B6E80
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.Remove
	|
	|-RVA: 0x302F160 Offset: 0x302F261 VA: 0x302F160
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.Remove
	|
	|-RVA: 0x30328F0 Offset: 0x30329F1 VA: 0x30328F0
	|-Dictionary<MeshDataConnectivity.Face, bool>.Remove
	|
	|-RVA: 0x3035FD0 Offset: 0x30360D1 VA: 0x3035FD0
	|-Dictionary<MeshDataConnectivity.Face, object>.Remove
	|
	|-RVA: 0x3039940 Offset: 0x3039A41 VA: 0x3039940
	|-Dictionary<Bounds, object>.Remove
	|
	|-RVA: 0x303D470 Offset: 0x303D571 VA: 0x303D470
	|-Dictionary<BoundsInt, object>.Remove
	|
	|-RVA: 0x3040D20 Offset: 0x3040E21 VA: 0x3040D20
	|-Dictionary<Color, object>.Remove
	|
	|-RVA: 0x30443E0 Offset: 0x30444E1 VA: 0x30443E0
	|-Dictionary<Color32, object>.Remove
	|
	|-RVA: 0x3047A10 Offset: 0x3047B11 VA: 0x3047A10
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.Remove
	|
	|-RVA: 0x30665A0 Offset: 0x30666A1 VA: 0x30665A0
	|-Dictionary<GradientAlphaKey, object>.Remove
	|
	|-RVA: 0x3069F10 Offset: 0x306A011 VA: 0x3069F10
	|-Dictionary<GradientColorKey, object>.Remove
	|
	|-RVA: 0x306DBC0 Offset: 0x306DCC1 VA: 0x306DBC0
	|-Dictionary<Keyframe, object>.Remove
	|
	|-RVA: 0x30714A0 Offset: 0x30715A1 VA: 0x30714A0
	|-Dictionary<LayerMask, object>.Remove
	|
	|-RVA: 0x3075150 Offset: 0x3075251 VA: 0x3075150
	|-Dictionary<Matrix4x4, object>.Remove
	|
	|-RVA: 0x3078B60 Offset: 0x3078C61 VA: 0x3078B60
	|-Dictionary<IntVec3, object>.Remove
	|
	|-RVA: 0x307C290 Offset: 0x307C391 VA: 0x307C290
	|-Dictionary<Quaternion, object>.Remove
	|
	|-RVA: 0x307F920 Offset: 0x307FA21 VA: 0x307F920
	|-Dictionary<RangeInt, object>.Remove
	|
	|-RVA: 0x304B100 Offset: 0x304B201 VA: 0x304B100
	|-Dictionary<Rect, object>.Remove
	|
	|-RVA: 0x304E810 Offset: 0x304E911 VA: 0x304E810
	|-Dictionary<RectInt, object>.Remove
	|
	|-RVA: 0x3051DA0 Offset: 0x3051EA1 VA: 0x3051DA0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.Remove
	|
	|-RVA: 0x3055480 Offset: 0x3055581 VA: 0x3055480
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Remove
	|
	|-RVA: 0x3058B00 Offset: 0x3058C01 VA: 0x3058B00
	|-Dictionary<Vector2, object>.Remove
	|
	|-RVA: 0x305C120 Offset: 0x305C221 VA: 0x305C120
	|-Dictionary<Vector2Int, object>.Remove
	|
	|-RVA: 0x305F7D0 Offset: 0x305F8D1 VA: 0x305F7D0
	|-Dictionary<Vector3, object>.Remove
	|
	|-RVA: 0x3062EE0 Offset: 0x3062FE1 VA: 0x3062EE0
	|-Dictionary<Vector3Int, object>.Remove
	|
	|-RVA: 0x2E3C8F0 Offset: 0x2E3C9F1 VA: 0x2E3C8F0
	|-Dictionary<Vector4, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEE500 Offset: 0x2FEE601 VA: 0x2FEE500
	|-Dictionary<Behavior, BehaviorManager.BehaviorTree>.TryGetValue
	|-Dictionary<BehaviorManager.ThirdPartyTask, object>.TryGetValue
	|-Dictionary<Task, Dictionary<string, object>>.TryGetValue
	|-Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>.TryGetValue
	|-Dictionary<ICinemachineCamera, object>.TryGetValue
	|-Dictionary<Tween, TweenLink>.TryGetValue
	|-Dictionary<ObjectSerializationInfo.EmittableMember, FieldInfo>.TryGetValue
	|-Dictionary<Action, LinkedListNode<Action>>.TryGetValue
	|-Dictionary<int[], Terrain>.TryGetValue
	|-Dictionary<ParameterExpression, LocalVariable>.TryGetValue
	|-Dictionary<object, BehaviorManager.ThirdPartyTask>.TryGetValue
	|-Dictionary<object, IList<IResourceLocation>>.TryGetValue
	|-Dictionary<object, object>.TryGetValue
	|-Dictionary<FieldInfo, Dictionary<Type, bool>>.TryGetValue
	|-Dictionary<FieldInfo, Instruction>.TryGetValue
	|-Dictionary<string, ActionCode>.TryGetValue
	|-Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>.TryGetValue
	|-Dictionary<string, ProfileGroupDefinition>.TryGetValue
	|-Dictionary<string, Texture[]>.TryGetValue
	|-Dictionary<string, SimpleCollator>.TryGetValue
	|-Dictionary<string, IList<InfoEntry>>.TryGetValue
	|-Dictionary<string, List<OptionDefinition>>.TryGetValue
	|-Dictionary<string, Delegate>.TryGetValue
	|-Dictionary<string, CultureInfo>.TryGetValue
	|-Dictionary<string, WebConnectionGroup>.TryGetValue
	|-Dictionary<string, object>.TryGetValue
	|-Dictionary<string, ResourceSet>.TryGetValue
	|-Dictionary<string, string>.TryGetValue
	|-Dictionary<string, Tuple<Guid, string>>.TryGetValue
	|-Dictionary<string, Type>.TryGetValue
	|-Dictionary<string, UriParser>.TryGetValue
	|-Dictionary<string, GUIStyle>.TryGetValue
	|-Dictionary<string, GameObject>.TryGetValue
	|-Dictionary<string, Transform>.TryGetValue
	|-Dictionary<IAsyncLocal, object>.TryGetValue
	|-Dictionary<Type, ITweenPlugin>.TryGetValue
	|-Dictionary<Type, AttributeUsageAttribute>.TryGetValue
	|-Dictionary<Type, Dictionary<string, Delegate>>.TryGetValue
	|-Dictionary<Type, IList<SRMonoBehaviourEx.FieldInfo>>.TryGetValue
	|-Dictionary<Type, MonoCustomAttrs.AttributeInfo>.TryGetValue
	|-Dictionary<Type, object>.TryGetValue
	|-Dictionary<Type, FieldInfo[]>.TryGetValue
	|-Dictionary<Type, TypeInformation>.TryGetValue
	|-Dictionary<Type, Type>.TryGetValue
	|-Dictionary<Type, TrackBindingTypeAttribute>.TryGetValue
	|-Dictionary<TimeParamTable, HashSet<MaterialChangeTime>>.TryGetValue
	|-Dictionary<TimeParamTable, HashSet<ObjectChangeTime>>.TryGetValue
	|-Dictionary<TimeParamTable, HashSet<RendererChangeTime>>.TryGetValue
	|-Dictionary<TimeParamTable, HashSet<Material>>.TryGetValue
	|-Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>>.TryGetValue
	|-Dictionary<Camera, Camera>.TryGetValue
	|-Dictionary<Canvas, IndexedSet<Graphic>>.TryGetValue
	|-Dictionary<Collider, CharacterBase>.TryGetValue
	|-Dictionary<Collider, CharacterNearCullingController>.TryGetValue
	|-Dictionary<Collider, FocusInterface>.TryGetValue
	|-Dictionary<Font, HashSet<Text>>.TryGetValue
	|-Dictionary<Transform, TargetPositionCache.CacheEntry>.TryGetValue
	|-Dictionary<Transform, UpdateTracker.UpdateStatus>.TryGetValue
	|-Dictionary<Transform, List<SpringBone>>.TryGetValue
	|
	|-RVA: 0x2A185C0 Offset: 0x2A186C1 VA: 0x2A185C0
	|-Dictionary<JSONDeserialization.TaskField, object>.TryGetValue
	|
	|-RVA: 0x2A1BC00 Offset: 0x2A1BD01 VA: 0x2A1BC00
	|-Dictionary<BitVector32Int, object>.TryGetValue
	|
	|-RVA: 0x2DFB760 Offset: 0x2DFB861 VA: 0x2DFB760
	|-Dictionary<CinemachineVirtualCameraBase, int>.TryGetValue
	|-Dictionary<ParameterExpression, int>.TryGetValue
	|-Dictionary<object, int>.TryGetValue
	|-Dictionary<string, int>.TryGetValue
	|-Dictionary<Type, int>.TryGetValue
	|
	|-RVA: 0x2E2F250 Offset: 0x2E2F351 VA: 0x2E2F250
	|-Dictionary<ActorID, MobTravelerName>.TryGetValue
	|-Dictionary<ActorID, Dictionary<EquipSlotType, HumanEquipItem>>.TryGetValue
	|-Dictionary<ActorID, SphereCollider>.TryGetValue
	|-Dictionary<AttackAttribute, ParticleSystem>.TryGetValue
	|-Dictionary<ConstraintPresetID, List<float>>.TryGetValue
	|-Dictionary<ToolChargeLevel, ParticleSystem>.TryGetValue
	|-Dictionary<VoiceGroup, CharaVoiceGroupData>.TryGetValue
	|-Dictionary<Texture, Texture>.TryGetValue
	|-Dictionary<Int32Enum, object>.TryGetValue
	|
	|-RVA: 0x2E2BB90 Offset: 0x2E2BC91 VA: 0x2E2BB90
	|-Dictionary<ActorID, RF5SystemData.FLAG>.TryGetValue
	|-Dictionary<AttackAttribute, EffectID>.TryGetValue
	|-Dictionary<EmotionType, Prefab>.TryGetValue
	|-Dictionary<Season, Texture>.TryGetValue
	|-Dictionary<Int32Enum, Int32Enum>.TryGetValue
	|
	|-RVA: 0x2E32770 Offset: 0x2E32871 VA: 0x2E32770
	|-Dictionary<AttackAttribute, float>.TryGetValue
	|-Dictionary<CharID, float>.TryGetValue
	|-Dictionary<EmotionType, float>.TryGetValue
	|-Dictionary<Int32Enum, float>.TryGetValue
	|
	|-RVA: 0x2F7AD10 Offset: 0x2F7AE11 VA: 0x2F7AD10
	|-Dictionary<EventCheckId, object>.TryGetValue
	|
	|-RVA: 0x2F7ECB0 Offset: 0x2F7EDB1 VA: 0x2F7ECB0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.TryGetValue
	|
	|-RVA: 0x2F82910 Offset: 0x2F82A11 VA: 0x2F82910
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.TryGetValue
	|
	|-RVA: 0x2F86110 Offset: 0x2F86211 VA: 0x2F86110
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.TryGetValue
	|
	|-RVA: 0x2F897E0 Offset: 0x2F898E1 VA: 0x2F897E0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.TryGetValue
	|
	|-RVA: 0x2F8D3A0 Offset: 0x2F8D4A1 VA: 0x2F8D3A0
	|-Dictionary<MonsterHutSaveData, object>.TryGetValue
	|
	|-RVA: 0x2F90C30 Offset: 0x2F90D31 VA: 0x2F90C30
	|-Dictionary<OrderLotterySaveParameter, object>.TryGetValue
	|
	|-RVA: 0x2F94840 Offset: 0x2F94941 VA: 0x2F94840
	|-Dictionary<OrderSaveData, object>.TryGetValue
	|
	|-RVA: 0x2D827A0 Offset: 0x2D828A1 VA: 0x2D827A0
	|-Dictionary<OrderSaveParameter, object>.TryGetValue
	|
	|-RVA: 0x2D86490 Offset: 0x2D86591 VA: 0x2D86490
	|-Dictionary<Parameter, object>.TryGetValue
	|
	|-RVA: 0x2D89CC0 Offset: 0x2D89DC1 VA: 0x2D89CC0
	|-Dictionary<bool, object>.TryGetValue
	|
	|-RVA: 0x2D8D2F0 Offset: 0x2D8D3F1 VA: 0x2D8D2F0
	|-Dictionary<byte, object>.TryGetValue
	|
	|-RVA: 0x2D90910 Offset: 0x2D90A11 VA: 0x2D90910
	|-Dictionary<char, object>.TryGetValue
	|
	|-RVA: 0x2D93F30 Offset: 0x2D94031 VA: 0x2D93F30
	|-Dictionary<DateTime, object>.TryGetValue
	|
	|-RVA: 0x2D97540 Offset: 0x2D97641 VA: 0x2D97540
	|-Dictionary<double, object>.TryGetValue
	|
	|-RVA: 0x2D9ABD0 Offset: 0x2D9ACD1 VA: 0x2D9ABD0
	|-Dictionary<Guid, MonoTlsProvider>.TryGetValue
	|-Dictionary<Guid, object>.TryGetValue
	|
	|-RVA: 0x2D9E1E0 Offset: 0x2D9E2E1 VA: 0x2D9E1E0
	|-Dictionary<short, object>.TryGetValue
	|
	|-RVA: 0x2F61B80 Offset: 0x2F61C81 VA: 0x2F61B80
	|-Dictionary<int, BehaviorManager.BehaviorTree.ConditionalReevaluate>.TryGetValue
	|-Dictionary<int, ObjectSerializationInfo.EmittableMember>.TryGetValue
	|-Dictionary<int, OnGroundItem>.TryGetValue
	|-Dictionary<int, Dictionary<string, object>>.TryGetValue
	|-Dictionary<int, List<object>>.TryGetValue
	|-Dictionary<int, List<WeakReference>>.TryGetValue
	|-Dictionary<int, CultureInfo>.TryGetValue
	|-Dictionary<int, object>.TryGetValue
	|-Dictionary<int, string>.TryGetValue
	|-Dictionary<int, TMP_ColorGradient>.TryGetValue
	|-Dictionary<int, TMP_FontAsset>.TryGetValue
	|-Dictionary<int, TMP_SpriteAsset>.TryGetValue
	|-Dictionary<int, TMP_Style>.TryGetValue
	|-Dictionary<int, TextureChangeMaterialParam>.TryGetValue
	|-Dictionary<int, DiagnosticInfo>.TryGetValue
	|-Dictionary<int, PointerEventData>.TryGetValue
	|-Dictionary<int, TerrainUtility.TerrainMap>.TryGetValue
	|-Dictionary<int, GUILayoutUtility.LayoutCache>.TryGetValue
	|-Dictionary<int, Material>.TryGetValue
	|-Dictionary<int, IAsyncOperation>.TryGetValue
	|-Dictionary<int, IResourceProvider>.TryGetValue
	|-Dictionary<int, Panel>.TryGetValue
	|
	|-RVA: 0x2D3C6F0 Offset: 0x2D3C7F1 VA: 0x2D3C6F0
	|-Dictionary<int, CropDataTable>.TryGetValue
	|
	|-RVA: 0x2D40150 Offset: 0x2D40251 VA: 0x2D40150
	|-Dictionary<int, EffectDataTable>.TryGetValue
	|
	|-RVA: 0x2D43830 Offset: 0x2D43931 VA: 0x2D43830
	|-Dictionary<int, GimmickLayoutDataTable>.TryGetValue
	|
	|-RVA: 0x2D47320 Offset: 0x2D47421 VA: 0x2D47320
	|-Dictionary<int, MineTypeDataTable>.TryGetValue
	|
	|-RVA: 0x2D4AB80 Offset: 0x2D4AC81 VA: 0x2D4AB80
	|-Dictionary<int, MiningDataTable>.TryGetValue
	|
	|-RVA: 0x2D4E1B0 Offset: 0x2D4E2B1 VA: 0x2D4E1B0
	|-Dictionary<int, bool>.TryGetValue
	|
	|-RVA: 0x2D51770 Offset: 0x2D51871 VA: 0x2D51770
	|-Dictionary<int, char>.TryGetValue
	|
	|-RVA: 0x2D54D30 Offset: 0x2D54E31 VA: 0x2D54D30
	|-Dictionary<int, int>.TryGetValue
	|
	|-RVA: 0x2D582F0 Offset: 0x2D583F1 VA: 0x2D582F0
	|-Dictionary<int, Int32Enum>.TryGetValue
	|
	|-RVA: 0x2F5E490 Offset: 0x2F5E591 VA: 0x2F5E490
	|-Dictionary<int, long>.TryGetValue
	|
	|-RVA: 0x2F65480 Offset: 0x2F65581 VA: 0x2F65480
	|-Dictionary<int, DiagnosticEvent>.TryGetValue
	|
	|-RVA: 0x2F68C80 Offset: 0x2F68D81 VA: 0x2F68C80
	|-Dictionary<int, SceneInstance>.TryGetValue
	|
	|-RVA: 0x2F6C330 Offset: 0x2F6C431 VA: 0x2F6C330
	|-Dictionary<int, Vector2Int>.TryGetValue
	|
	|-RVA: 0x2F6FA20 Offset: 0x2F6FB21 VA: 0x2F6FA20
	|-Dictionary<int, Vector3>.TryGetValue
	|
	|-RVA: 0x2F73530 Offset: 0x2F73631 VA: 0x2F73530
	|-Dictionary<Int32Enum, MonsterDataTable>.TryGetValue
	|
	|-RVA: 0x2F770F0 Offset: 0x2F771F1 VA: 0x2F770F0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.TryGetValue
	|
	|-RVA: 0x2E1E360 Offset: 0x2E1E461 VA: 0x2E1E360
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.TryGetValue
	|
	|-RVA: 0x2E21990 Offset: 0x2E21A91 VA: 0x2E21990
	|-Dictionary<Int32Enum, bool>.TryGetValue
	|
	|-RVA: 0x2E24FF0 Offset: 0x2E250F1 VA: 0x2E24FF0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.TryGetValue
	|
	|-RVA: 0x2E285D0 Offset: 0x2E286D1 VA: 0x2E285D0
	|-Dictionary<Int32Enum, int>.TryGetValue
	|
	|-RVA: 0x2E35DF0 Offset: 0x2E35EF1 VA: 0x2E35DF0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.TryGetValue
	|
	|-RVA: 0x2E394B0 Offset: 0x2E395B1 VA: 0x2E394B0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.TryGetValue
	|
	|-RVA: 0x2F98030 Offset: 0x2F98131 VA: 0x2F98030
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.TryGetValue
	|
	|-RVA: 0x2F9B770 Offset: 0x2F9B871 VA: 0x2F9B770
	|-Dictionary<long, object>.TryGetValue
	|-Dictionary<long, TMP_MaterialManager.FallbackMaterial>.TryGetValue
	|
	|-RVA: 0x2F9EE10 Offset: 0x2F9EF11 VA: 0x2F9EE10
	|-Dictionary<Memory<object>, object>.TryGetValue
	|
	|-RVA: 0x2FA25D0 Offset: 0x2FA26D1 VA: 0x2FA25D0
	|-Dictionary<Nullable<Int32Enum>, object>.TryGetValue
	|
	|-RVA: 0x2FA6390 Offset: 0x2FA6491 VA: 0x2FA6390
	|-Dictionary<Nullable<Bounds>, object>.TryGetValue
	|
	|-RVA: 0x2FAA2F0 Offset: 0x2FAA3F1 VA: 0x2FAA2F0
	|-Dictionary<Nullable<BoundsInt>, object>.TryGetValue
	|
	|-RVA: 0x2FADC70 Offset: 0x2FADD71 VA: 0x2FADC70
	|-Dictionary<Nullable<Color32>, object>.TryGetValue
	|
	|-RVA: 0x2FB1830 Offset: 0x2FB1931 VA: 0x2FB1830
	|-Dictionary<Nullable<Color>, object>.TryGetValue
	|
	|-RVA: 0x2F1C600 Offset: 0x2F1C701 VA: 0x2F1C600
	|-Dictionary<Nullable<GradientAlphaKey>, object>.TryGetValue
	|
	|-RVA: 0x2F201F0 Offset: 0x2F202F1 VA: 0x2F201F0
	|-Dictionary<Nullable<GradientColorKey>, object>.TryGetValue
	|
	|-RVA: 0x2F23F10 Offset: 0x2F24011 VA: 0x2F23F10
	|-Dictionary<Nullable<Keyframe>, object>.TryGetValue
	|
	|-RVA: 0x2F27840 Offset: 0x2F27941 VA: 0x2F27840
	|-Dictionary<Nullable<LayerMask>, object>.TryGetValue
	|
	|-RVA: 0x2F2BAF0 Offset: 0x2F2BBF1 VA: 0x2F2BAF0
	|-Dictionary<Nullable<Matrix4x4>, object>.TryGetValue
	|
	|-RVA: 0x2F2F970 Offset: 0x2F2FA71 VA: 0x2F2F970
	|-Dictionary<Nullable<Quaternion>, object>.TryGetValue
	|
	|-RVA: 0x2F33350 Offset: 0x2F33451 VA: 0x2F33350
	|-Dictionary<Nullable<RangeInt>, object>.TryGetValue
	|
	|-RVA: 0x2F36F40 Offset: 0x2F37041 VA: 0x2F36F40
	|-Dictionary<Nullable<Rect>, object>.TryGetValue
	|
	|-RVA: 0x2EFFC50 Offset: 0x2EFFD51 VA: 0x2EFFC50
	|-Dictionary<Nullable<RectInt>, object>.TryGetValue
	|
	|-RVA: 0x2F03630 Offset: 0x2F03731 VA: 0x2F03630
	|-Dictionary<Nullable<Vector2>, object>.TryGetValue
	|
	|-RVA: 0x2F06F00 Offset: 0x2F07001 VA: 0x2F06F00
	|-Dictionary<Nullable<Vector2Int>, object>.TryGetValue
	|
	|-RVA: 0x2F0A780 Offset: 0x2F0A881 VA: 0x2F0A780
	|-Dictionary<Nullable<Vector3>, object>.TryGetValue
	|
	|-RVA: 0x2F0DFC0 Offset: 0x2F0E0C1 VA: 0x2F0DFC0
	|-Dictionary<Nullable<Vector3Int>, object>.TryGetValue
	|
	|-RVA: 0x2F11B70 Offset: 0x2F11C71 VA: 0x2F11B70
	|-Dictionary<Nullable<Vector4>, object>.TryGetValue
	|
	|-RVA: 0x2F15330 Offset: 0x2F15431 VA: 0x2F15330
	|-Dictionary<object, BitVector32Int>.TryGetValue
	|
	|-RVA: 0x2F18C40 Offset: 0x2F18D41 VA: 0x2F18C40
	|-Dictionary<object, EventCheckId>.TryGetValue
	|
	|-RVA: 0x2FF56B0 Offset: 0x2FF57B1 VA: 0x2FF56B0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.TryGetValue
	|
	|-RVA: 0x2FF9140 Offset: 0x2FF9241 VA: 0x2FF9140
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.TryGetValue
	|
	|-RVA: 0x2FFC920 Offset: 0x2FFCA21 VA: 0x2FFC920
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.TryGetValue
	|
	|-RVA: 0x3000030 Offset: 0x3000131 VA: 0x3000030
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.TryGetValue
	|
	|-RVA: 0x3003A40 Offset: 0x3003B41 VA: 0x3003A40
	|-Dictionary<object, MonsterHutSaveData>.TryGetValue
	|
	|-RVA: 0x3007280 Offset: 0x3007381 VA: 0x3007280
	|-Dictionary<object, OrderLotterySaveParameter>.TryGetValue
	|
	|-RVA: 0x300ACC0 Offset: 0x300ADC1 VA: 0x300ACC0
	|-Dictionary<object, OrderSaveData>.TryGetValue
	|
	|-RVA: 0x300E730 Offset: 0x300E831 VA: 0x300E730
	|-Dictionary<object, OrderSaveParameter>.TryGetValue
	|
	|-RVA: 0x2DDFFA0 Offset: 0x2DE00A1 VA: 0x2DDFFA0
	|-Dictionary<object, Parameter>.TryGetValue
	|
	|-RVA: 0x2DE3800 Offset: 0x2DE3901 VA: 0x2DE3800
	|-Dictionary<object, NumberControl.ValueRange>.TryGetValue
	|-Dictionary<Type, NumberControl.ValueRange>.TryGetValue
	|
	|-RVA: 0x2DE6EF0 Offset: 0x2DE6FF1 VA: 0x2DE6EF0
	|-Dictionary<object, bool>.TryGetValue
	|-Dictionary<Type, bool>.TryGetValue
	|
	|-RVA: 0x2DEA5B0 Offset: 0x2DEA6B1 VA: 0x2DEA5B0
	|-Dictionary<object, byte>.TryGetValue
	|
	|-RVA: 0x2DEDC70 Offset: 0x2DEDD71 VA: 0x2DEDC70
	|-Dictionary<object, char>.TryGetValue
	|
	|-RVA: 0x2DF1330 Offset: 0x2DF1431 VA: 0x2DF1330
	|-Dictionary<object, DateTime>.TryGetValue
	|
	|-RVA: 0x2DF49E0 Offset: 0x2DF4AE1 VA: 0x2DF49E0
	|-Dictionary<object, double>.TryGetValue
	|
	|-RVA: 0x2DF80A0 Offset: 0x2DF81A1 VA: 0x2DF80A0
	|-Dictionary<object, short>.TryGetValue
	|
	|-RVA: 0x30BAD20 Offset: 0x30BAE21 VA: 0x30BAD20
	|-Dictionary<object, Int32Enum>.TryGetValue
	|-Dictionary<string, GameFlagData>.TryGetValue
	|-Dictionary<GameObject, Prefab>.TryGetValue
	|
	|-RVA: 0x30BE3E0 Offset: 0x30BE4E1 VA: 0x30BE3E0
	|-Dictionary<object, long>.TryGetValue
	|
	|-RVA: 0x30C1AD0 Offset: 0x30C1BD1 VA: 0x30C1AD0
	|-Dictionary<object, Memory<object>>.TryGetValue
	|
	|-RVA: 0x30C5260 Offset: 0x30C5361 VA: 0x30C5260
	|-Dictionary<object, Nullable<Int32Enum>>.TryGetValue
	|
	|-RVA: 0x30C8D70 Offset: 0x30C8E71 VA: 0x30C8D70
	|-Dictionary<object, Nullable<Bounds>>.TryGetValue
	|
	|-RVA: 0x30CC9D0 Offset: 0x30CCAD1 VA: 0x30CC9D0
	|-Dictionary<object, Nullable<BoundsInt>>.TryGetValue
	|
	|-RVA: 0x30D02C0 Offset: 0x30D03C1 VA: 0x30D02C0
	|-Dictionary<object, Nullable<Color32>>.TryGetValue
	|
	|-RVA: 0x30D3CB0 Offset: 0x30D3DB1 VA: 0x30D3CB0
	|-Dictionary<object, Nullable<Color>>.TryGetValue
	|
	|-RVA: 0x3011FF0 Offset: 0x30120F1 VA: 0x3011FF0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.TryGetValue
	|
	|-RVA: 0x3015A40 Offset: 0x3015B41 VA: 0x3015A40
	|-Dictionary<object, Nullable<GradientColorKey>>.TryGetValue
	|
	|-RVA: 0x3019550 Offset: 0x3019651 VA: 0x3019550
	|-Dictionary<object, Nullable<Keyframe>>.TryGetValue
	|
	|-RVA: 0x301CE10 Offset: 0x301CF11 VA: 0x301CE10
	|-Dictionary<object, Nullable<LayerMask>>.TryGetValue
	|
	|-RVA: 0x3020BF0 Offset: 0x3020CF1 VA: 0x3020BF0
	|-Dictionary<object, Nullable<Matrix4x4>>.TryGetValue
	|
	|-RVA: 0x3024800 Offset: 0x3024901 VA: 0x3024800
	|-Dictionary<object, Nullable<Quaternion>>.TryGetValue
	|
	|-RVA: 0x3028100 Offset: 0x3028201 VA: 0x3028100
	|-Dictionary<object, Nullable<RangeInt>>.TryGetValue
	|
	|-RVA: 0x302BB50 Offset: 0x302BC51 VA: 0x302BB50
	|-Dictionary<object, Nullable<Rect>>.TryGetValue
	|
	|-RVA: 0x2FD9130 Offset: 0x2FD9231 VA: 0x2FD9130
	|-Dictionary<object, Nullable<RectInt>>.TryGetValue
	|
	|-RVA: 0x2FDCA30 Offset: 0x2FDCB31 VA: 0x2FDCA30
	|-Dictionary<object, Nullable<Vector2>>.TryGetValue
	|
	|-RVA: 0x2FE0280 Offset: 0x2FE0381 VA: 0x2FE0280
	|-Dictionary<object, Nullable<Vector2Int>>.TryGetValue
	|
	|-RVA: 0x2FE3AB0 Offset: 0x2FE3BB1 VA: 0x2FE3AB0
	|-Dictionary<object, Nullable<Vector3>>.TryGetValue
	|
	|-RVA: 0x2FE72A0 Offset: 0x2FE73A1 VA: 0x2FE72A0
	|-Dictionary<object, Nullable<Vector3Int>>.TryGetValue
	|
	|-RVA: 0x2FEACB0 Offset: 0x2FEADB1 VA: 0x2FEACB0
	|-Dictionary<object, Nullable<Vector4>>.TryGetValue
	|
	|-RVA: 0x2FF1AF0 Offset: 0x2FF1BF1 VA: 0x2FF1AF0
	|-Dictionary<object, ReadOnlyMemory<object>>.TryGetValue
	|
	|-RVA: 0x2DC05A0 Offset: 0x2DC06A1 VA: 0x2DC05A0
	|-Dictionary<object, ResourceLocator>.TryGetValue
	|-Dictionary<string, ResourceLocator>.TryGetValue
	|
	|-RVA: 0x2DC3C80 Offset: 0x2DC3D81 VA: 0x2DC3C80
	|-Dictionary<object, sbyte>.TryGetValue
	|
	|-RVA: 0x2DC7340 Offset: 0x2DC7441 VA: 0x2DC7340
	|-Dictionary<object, float>.TryGetValue
	|
	|-RVA: 0x2DCAA00 Offset: 0x2DCAB01 VA: 0x2DCAA00
	|-Dictionary<object, ushort>.TryGetValue
	|
	|-RVA: 0x2DCE0C0 Offset: 0x2DCE1C1 VA: 0x2DCE0C0
	|-Dictionary<object, uint>.TryGetValue
	|
	|-RVA: 0x2DD1780 Offset: 0x2DD1881 VA: 0x2DD1780
	|-Dictionary<object, ulong>.TryGetValue
	|
	|-RVA: 0x2DD50A0 Offset: 0x2DD51A1 VA: 0x2DD50A0
	|-Dictionary<object, TransitionTables>.TryGetValue
	|
	|-RVA: 0x2DD8A80 Offset: 0x2DD8B81 VA: 0x2DD8A80
	|-Dictionary<object, Bounds>.TryGetValue
	|
	|-RVA: 0x2DDC440 Offset: 0x2DDC541 VA: 0x2DDC440
	|-Dictionary<object, BoundsInt>.TryGetValue
	|
	|-RVA: 0x30D74B0 Offset: 0x30D75B1 VA: 0x30D74B0
	|-Dictionary<object, Color32>.TryGetValue
	|
	|-RVA: 0x30DABB0 Offset: 0x30DACB1 VA: 0x30DABB0
	|-Dictionary<object, Color>.TryGetValue
	|
	|-RVA: 0x30DE2C0 Offset: 0x30DE3C1 VA: 0x30DE2C0
	|-Dictionary<object, GradientAlphaKey>.TryGetValue
	|
	|-RVA: 0x30E1BB0 Offset: 0x30E1CB1 VA: 0x30E1BB0
	|-Dictionary<object, GradientColorKey>.TryGetValue
	|
	|-RVA: 0x30E5690 Offset: 0x30E5791 VA: 0x30E5690
	|-Dictionary<object, Keyframe>.TryGetValue
	|
	|-RVA: 0x30E8E90 Offset: 0x30E8F91 VA: 0x30E8E90
	|-Dictionary<object, LayerMask>.TryGetValue
	|
	|-RVA: 0x30EC9C0 Offset: 0x30ECAC1 VA: 0x30EC9C0
	|-Dictionary<object, Matrix4x4>.TryGetValue
	|
	|-RVA: 0x30F0220 Offset: 0x30F0321 VA: 0x30F0220
	|-Dictionary<object, Playable>.TryGetValue
	|-Dictionary<TrackAsset, Playable>.TryGetValue
	|
	|-RVA: 0x309F040 Offset: 0x309F141 VA: 0x309F040
	|-Dictionary<object, Quaternion>.TryGetValue
	|
	|-RVA: 0x30A2720 Offset: 0x30A2821 VA: 0x30A2720
	|-Dictionary<object, RangeInt>.TryGetValue
	|
	|-RVA: 0x30A5E10 Offset: 0x30A5F11 VA: 0x30A5E10
	|-Dictionary<object, Rect>.TryGetValue
	|
	|-RVA: 0x30A9510 Offset: 0x30A9611 VA: 0x30A9510
	|-Dictionary<object, RectInt>.TryGetValue
	|
	|-RVA: 0x30ACE20 Offset: 0x30ACF21 VA: 0x30ACE20
	|-Dictionary<object, AsyncOperationHandle>.TryGetValue
	|
	|-RVA: 0x30B07F0 Offset: 0x30B08F1 VA: 0x30B07F0
	|-Dictionary<object, AsyncOperationHandle<object>>.TryGetValue
	|-Dictionary<GameObject, AsyncOperationHandle<GameObject>>.TryGetValue
	|
	|-RVA: 0x30B3FB0 Offset: 0x30B40B1 VA: 0x30B3FB0
	|-Dictionary<object, Vector2>.TryGetValue
	|
	|-RVA: 0x30B7670 Offset: 0x30B7771 VA: 0x30B7670
	|-Dictionary<object, Vector2Int>.TryGetValue
	|
	|-RVA: 0x3083320 Offset: 0x3083421 VA: 0x3083320
	|-Dictionary<object, Vector3>.TryGetValue
	|
	|-RVA: 0x3086A50 Offset: 0x3086B51 VA: 0x3086A50
	|-Dictionary<object, Vector3Int>.TryGetValue
	|
	|-RVA: 0x308A180 Offset: 0x308A281 VA: 0x308A180
	|-Dictionary<object, Vector4>.TryGetValue
	|
	|-RVA: 0x308D890 Offset: 0x308D991 VA: 0x308D890
	|-Dictionary<ReadOnlyMemory<object>, object>.TryGetValue
	|
	|-RVA: 0x3090E40 Offset: 0x3090F41 VA: 0x3090E40
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.TryGetValue
	|
	|-RVA: 0x3094530 Offset: 0x3094631 VA: 0x3094530
	|-Dictionary<sbyte, object>.TryGetValue
	|
	|-RVA: 0x30980E0 Offset: 0x30981E1 VA: 0x30980E0
	|-Dictionary<float, CurveSample>.TryGetValue
	|
	|-RVA: 0x309B990 Offset: 0x309BA91 VA: 0x309B990
	|-Dictionary<float, object>.TryGetValue
	|
	|-RVA: 0x319EF00 Offset: 0x319F001 VA: 0x319EF00
	|-Dictionary<ushort, object>.TryGetValue
	|
	|-RVA: 0x31A90A0 Offset: 0x31A91A1 VA: 0x31A90A0
	|-Dictionary<uint, Point2DList>.TryGetValue
	|-Dictionary<uint, TriangulationConstraint>.TryGetValue
	|-Dictionary<uint, TriangulationPoint>.TryGetValue
	|-Dictionary<uint, object>.TryGetValue
	|-Dictionary<uint, TMP_Character>.TryGetValue
	|-Dictionary<uint, TMP_GlyphPairAdjustmentRecord>.TryGetValue
	|-Dictionary<uint, TMP_SpriteCharacter>.TryGetValue
	|-Dictionary<uint, Glyph>.TryGetValue
	|
	|-RVA: 0x31A2420 Offset: 0x31A2521 VA: 0x31A2420
	|-Dictionary<uint, int>.TryGetValue
	|
	|-RVA: 0x31A59E0 Offset: 0x31A5AE1 VA: 0x31A59E0
	|-Dictionary<uint, Int32Enum>.TryGetValue
	|
	|-RVA: 0x31AC6C0 Offset: 0x31AC7C1 VA: 0x31AC6C0
	|-Dictionary<ulong, object>.TryGetValue
	|
	|-RVA: 0x31AFC70 Offset: 0x31AFD71 VA: 0x31AFC70
	|-Dictionary<EdgeKeyByHash, int>.TryGetValue
	|
	|-RVA: 0x31B36B0 Offset: 0x31B37B1 VA: 0x31B36B0
	|-Dictionary<EdgeKeyByHash, CapEdge>.TryGetValue
	|
	|-RVA: 0x31B71E0 Offset: 0x31B72E1 VA: 0x31B71E0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.TryGetValue
	|
	|-RVA: 0x302F4D0 Offset: 0x302F5D1 VA: 0x302F4D0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.TryGetValue
	|
	|-RVA: 0x3032C60 Offset: 0x3032D61 VA: 0x3032C60
	|-Dictionary<MeshDataConnectivity.Face, bool>.TryGetValue
	|
	|-RVA: 0x3036340 Offset: 0x3036441 VA: 0x3036340
	|-Dictionary<MeshDataConnectivity.Face, object>.TryGetValue
	|
	|-RVA: 0x3039D40 Offset: 0x3039E41 VA: 0x3039D40
	|-Dictionary<Bounds, object>.TryGetValue
	|
	|-RVA: 0x303D870 Offset: 0x303D971 VA: 0x303D870
	|-Dictionary<BoundsInt, object>.TryGetValue
	|
	|-RVA: 0x30410B0 Offset: 0x30411B1 VA: 0x30410B0
	|-Dictionary<Color, object>.TryGetValue
	|
	|-RVA: 0x3044750 Offset: 0x3044851 VA: 0x3044750
	|-Dictionary<Color32, object>.TryGetValue
	|
	|-RVA: 0x3047D80 Offset: 0x3047E81 VA: 0x3047D80
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.TryGetValue
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain>.TryGetValue
	|
	|-RVA: 0x3066910 Offset: 0x3066A11 VA: 0x3066910
	|-Dictionary<GradientAlphaKey, object>.TryGetValue
	|
	|-RVA: 0x306A310 Offset: 0x306A411 VA: 0x306A310
	|-Dictionary<GradientColorKey, object>.TryGetValue
	|
	|-RVA: 0x306E010 Offset: 0x306E111 VA: 0x306E010
	|-Dictionary<Keyframe, object>.TryGetValue
	|
	|-RVA: 0x3071810 Offset: 0x3071911 VA: 0x3071810
	|-Dictionary<LayerMask, object>.TryGetValue
	|
	|-RVA: 0x30755E0 Offset: 0x30756E1 VA: 0x30755E0
	|-Dictionary<Matrix4x4, object>.TryGetValue
	|
	|-RVA: 0x3078EE0 Offset: 0x3078FE1 VA: 0x3078EE0
	|-Dictionary<IntVec3, List<int>>.TryGetValue
	|-Dictionary<IntVec3, object>.TryGetValue
	|
	|-RVA: 0x307C620 Offset: 0x307C721 VA: 0x307C620
	|-Dictionary<Quaternion, object>.TryGetValue
	|
	|-RVA: 0x307FC90 Offset: 0x307FD91 VA: 0x307FC90
	|-Dictionary<RangeInt, object>.TryGetValue
	|
	|-RVA: 0x304B490 Offset: 0x304B591 VA: 0x304B490
	|-Dictionary<Rect, object>.TryGetValue
	|
	|-RVA: 0x304EB70 Offset: 0x304EC71 VA: 0x304EB70
	|-Dictionary<RectInt, object>.TryGetValue
	|
	|-RVA: 0x3052110 Offset: 0x3052211 VA: 0x3052110
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.TryGetValue
	|
	|-RVA: 0x30557F0 Offset: 0x30558F1 VA: 0x30557F0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.TryGetValue
	|
	|-RVA: 0x3058E70 Offset: 0x3058F71 VA: 0x3058E70
	|-Dictionary<Vector2, object>.TryGetValue
	|
	|-RVA: 0x305C490 Offset: 0x305C591 VA: 0x305C490
	|-Dictionary<Vector2Int, object>.TryGetValue
	|
	|-RVA: 0x305FB50 Offset: 0x305FC51 VA: 0x305FB50
	|-Dictionary<Vector3, object>.TryGetValue
	|
	|-RVA: 0x3063250 Offset: 0x3063351 VA: 0x3063250
	|-Dictionary<Vector3Int, object>.TryGetValue
	|
	|-RVA: 0x2E3CC80 Offset: 0x2E3CD81 VA: 0x2E3CC80
	|-Dictionary<Vector4, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18650 Offset: 0x2A18751 VA: 0x2A18650
	|-Dictionary<JSONDeserialization.TaskField, object>.TryAdd
	|
	|-RVA: 0x2A1BCA0 Offset: 0x2A1BDA1 VA: 0x2A1BCA0
	|-Dictionary<BitVector32Int, object>.TryAdd
	|
	|-RVA: 0x2F7ADE0 Offset: 0x2F7AEE1 VA: 0x2F7ADE0
	|-Dictionary<EventCheckId, object>.TryAdd
	|
	|-RVA: 0x2F7EDA0 Offset: 0x2F7EEA1 VA: 0x2F7EDA0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.TryAdd
	|
	|-RVA: 0x2F829E0 Offset: 0x2F82AE1 VA: 0x2F829E0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.TryAdd
	|
	|-RVA: 0x2F861B0 Offset: 0x2F862B1 VA: 0x2F861B0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.TryAdd
	|
	|-RVA: 0x2F89870 Offset: 0x2F89971 VA: 0x2F89870
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.TryAdd
	|
	|-RVA: 0x2F8D480 Offset: 0x2F8D581 VA: 0x2F8D480
	|-Dictionary<MonsterHutSaveData, object>.TryAdd
	|
	|-RVA: 0x2F90CD0 Offset: 0x2F90DD1 VA: 0x2F90CD0
	|-Dictionary<OrderLotterySaveParameter, object>.TryAdd
	|
	|-RVA: 0x2F94920 Offset: 0x2F94A21 VA: 0x2F94920
	|-Dictionary<OrderSaveData, object>.TryAdd
	|
	|-RVA: 0x2D82870 Offset: 0x2D82971 VA: 0x2D82870
	|-Dictionary<OrderSaveParameter, object>.TryAdd
	|
	|-RVA: 0x2D86560 Offset: 0x2D86661 VA: 0x2D86560
	|-Dictionary<Parameter, object>.TryAdd
	|
	|-RVA: 0x2D89D60 Offset: 0x2D89E61 VA: 0x2D89D60
	|-Dictionary<bool, object>.TryAdd
	|
	|-RVA: 0x2D8D380 Offset: 0x2D8D481 VA: 0x2D8D380
	|-Dictionary<byte, object>.TryAdd
	|
	|-RVA: 0x2D909A0 Offset: 0x2D90AA1 VA: 0x2D909A0
	|-Dictionary<char, object>.TryAdd
	|
	|-RVA: 0x2D93FC0 Offset: 0x2D940C1 VA: 0x2D93FC0
	|-Dictionary<DateTime, object>.TryAdd
	|
	|-RVA: 0x2D975D0 Offset: 0x2D976D1 VA: 0x2D975D0
	|-Dictionary<double, object>.TryAdd
	|
	|-RVA: 0x2D9AC60 Offset: 0x2D9AD61 VA: 0x2D9AC60
	|-Dictionary<Guid, object>.TryAdd
	|
	|-RVA: 0x2D9E270 Offset: 0x2D9E371 VA: 0x2D9E270
	|-Dictionary<short, object>.TryAdd
	|
	|-RVA: 0x2D3C7D0 Offset: 0x2D3C8D1 VA: 0x2D3C7D0
	|-Dictionary<int, CropDataTable>.TryAdd
	|
	|-RVA: 0x2D401F0 Offset: 0x2D402F1 VA: 0x2D401F0
	|-Dictionary<int, EffectDataTable>.TryAdd
	|
	|-RVA: 0x2D438C0 Offset: 0x2D439C1 VA: 0x2D438C0
	|-Dictionary<int, GimmickLayoutDataTable>.TryAdd
	|
	|-RVA: 0x2D473D0 Offset: 0x2D474D1 VA: 0x2D473D0
	|-Dictionary<int, MineTypeDataTable>.TryAdd
	|
	|-RVA: 0x2D4AC20 Offset: 0x2D4AD21 VA: 0x2D4AC20
	|-Dictionary<int, MiningDataTable>.TryAdd
	|
	|-RVA: 0x2D4E240 Offset: 0x2D4E341 VA: 0x2D4E240
	|-Dictionary<int, bool>.TryAdd
	|
	|-RVA: 0x2D51800 Offset: 0x2D51901 VA: 0x2D51800
	|-Dictionary<int, char>.TryAdd
	|
	|-RVA: 0x2D54DC0 Offset: 0x2D54EC1 VA: 0x2D54DC0
	|-Dictionary<int, int>.TryAdd
	|
	|-RVA: 0x2D58380 Offset: 0x2D58481 VA: 0x2D58380
	|-Dictionary<int, Int32Enum>.TryAdd
	|
	|-RVA: 0x2F5E520 Offset: 0x2F5E621 VA: 0x2F5E520
	|-Dictionary<int, long>.TryAdd
	|
	|-RVA: 0x2F61C10 Offset: 0x2F61D11 VA: 0x2F61C10
	|-Dictionary<int, object>.TryAdd
	|
	|-RVA: 0x2F65530 Offset: 0x2F65631 VA: 0x2F65530
	|-Dictionary<int, DiagnosticEvent>.TryAdd
	|
	|-RVA: 0x2F68D20 Offset: 0x2F68E21 VA: 0x2F68D20
	|-Dictionary<int, SceneInstance>.TryAdd
	|
	|-RVA: 0x2F6C3C0 Offset: 0x2F6C4C1 VA: 0x2F6C3C0
	|-Dictionary<int, Vector2Int>.TryAdd
	|
	|-RVA: 0x2F6FAC0 Offset: 0x2F6FBC1 VA: 0x2F6FAC0
	|-Dictionary<int, Vector3>.TryAdd
	|
	|-RVA: 0x2F73600 Offset: 0x2F73701 VA: 0x2F73600
	|-Dictionary<Int32Enum, MonsterDataTable>.TryAdd
	|
	|-RVA: 0x2F771A0 Offset: 0x2F772A1 VA: 0x2F771A0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.TryAdd
	|
	|-RVA: 0x2E1E3F0 Offset: 0x2E1E4F1 VA: 0x2E1E3F0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.TryAdd
	|
	|-RVA: 0x2E21A20 Offset: 0x2E21B21 VA: 0x2E21A20
	|-Dictionary<Int32Enum, bool>.TryAdd
	|
	|-RVA: 0x2E25080 Offset: 0x2E25181 VA: 0x2E25080
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.TryAdd
	|
	|-RVA: 0x2E28660 Offset: 0x2E28761 VA: 0x2E28660
	|-Dictionary<Int32Enum, int>.TryAdd
	|
	|-RVA: 0x2E2BC20 Offset: 0x2E2BD21 VA: 0x2E2BC20
	|-Dictionary<Int32Enum, Int32Enum>.TryAdd
	|
	|-RVA: 0x2E2F2E0 Offset: 0x2E2F3E1 VA: 0x2E2F2E0
	|-Dictionary<Int32Enum, object>.TryAdd
	|
	|-RVA: 0x2E32800 Offset: 0x2E32901 VA: 0x2E32800
	|-Dictionary<Int32Enum, float>.TryAdd
	|
	|-RVA: 0x2E35E90 Offset: 0x2E35F91 VA: 0x2E35E90
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.TryAdd
	|
	|-RVA: 0x2E39540 Offset: 0x2E39641 VA: 0x2E39540
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.TryAdd
	|
	|-RVA: 0x2F980D0 Offset: 0x2F981D1 VA: 0x2F980D0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.TryAdd
	|
	|-RVA: 0x2F9B800 Offset: 0x2F9B901 VA: 0x2F9B800
	|-Dictionary<long, object>.TryAdd
	|
	|-RVA: 0x2F9EEA0 Offset: 0x2F9EFA1 VA: 0x2F9EEA0
	|-Dictionary<Memory<object>, object>.TryAdd
	|
	|-RVA: 0x2FA2660 Offset: 0x2FA2761 VA: 0x2FA2660
	|-Dictionary<Nullable<Int32Enum>, object>.TryAdd
	|
	|-RVA: 0x2FA6470 Offset: 0x2FA6571 VA: 0x2FA6470
	|-Dictionary<Nullable<Bounds>, object>.TryAdd
	|
	|-RVA: 0x2FAA3D0 Offset: 0x2FAA4D1 VA: 0x2FAA3D0
	|-Dictionary<Nullable<BoundsInt>, object>.TryAdd
	|
	|-RVA: 0x2FADD00 Offset: 0x2FADE01 VA: 0x2FADD00
	|-Dictionary<Nullable<Color32>, object>.TryAdd
	|
	|-RVA: 0x2FB1900 Offset: 0x2FB1A01 VA: 0x2FB1900
	|-Dictionary<Nullable<Color>, object>.TryAdd
	|
	|-RVA: 0x2F1C6A0 Offset: 0x2F1C7A1 VA: 0x2F1C6A0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.TryAdd
	|
	|-RVA: 0x2F202C0 Offset: 0x2F203C1 VA: 0x2F202C0
	|-Dictionary<Nullable<GradientColorKey>, object>.TryAdd
	|
	|-RVA: 0x2F23FE0 Offset: 0x2F240E1 VA: 0x2F23FE0
	|-Dictionary<Nullable<Keyframe>, object>.TryAdd
	|
	|-RVA: 0x2F278D0 Offset: 0x2F279D1 VA: 0x2F278D0
	|-Dictionary<Nullable<LayerMask>, object>.TryAdd
	|
	|-RVA: 0x2F2BBF0 Offset: 0x2F2BCF1 VA: 0x2F2BBF0
	|-Dictionary<Nullable<Matrix4x4>, object>.TryAdd
	|
	|-RVA: 0x2F2FA40 Offset: 0x2F2FB41 VA: 0x2F2FA40
	|-Dictionary<Nullable<Quaternion>, object>.TryAdd
	|
	|-RVA: 0x2F333F0 Offset: 0x2F334F1 VA: 0x2F333F0
	|-Dictionary<Nullable<RangeInt>, object>.TryAdd
	|
	|-RVA: 0x2F37010 Offset: 0x2F37111 VA: 0x2F37010
	|-Dictionary<Nullable<Rect>, object>.TryAdd
	|
	|-RVA: 0x2EFFD20 Offset: 0x2EFFE21 VA: 0x2EFFD20
	|-Dictionary<Nullable<RectInt>, object>.TryAdd
	|
	|-RVA: 0x2F036D0 Offset: 0x2F037D1 VA: 0x2F036D0
	|-Dictionary<Nullable<Vector2>, object>.TryAdd
	|
	|-RVA: 0x2F06FA0 Offset: 0x2F070A1 VA: 0x2F06FA0
	|-Dictionary<Nullable<Vector2Int>, object>.TryAdd
	|
	|-RVA: 0x2F0A810 Offset: 0x2F0A911 VA: 0x2F0A810
	|-Dictionary<Nullable<Vector3>, object>.TryAdd
	|
	|-RVA: 0x2F0E050 Offset: 0x2F0E151 VA: 0x2F0E050
	|-Dictionary<Nullable<Vector3Int>, object>.TryAdd
	|
	|-RVA: 0x2F11C40 Offset: 0x2F11D41 VA: 0x2F11C40
	|-Dictionary<Nullable<Vector4>, object>.TryAdd
	|
	|-RVA: 0x2F153C0 Offset: 0x2F154C1 VA: 0x2F153C0
	|-Dictionary<object, BitVector32Int>.TryAdd
	|
	|-RVA: 0x2F18CF0 Offset: 0x2F18DF1 VA: 0x2F18CF0
	|-Dictionary<object, EventCheckId>.TryAdd
	|
	|-RVA: 0x2FF5750 Offset: 0x2FF5851 VA: 0x2FF5750
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.TryAdd
	|
	|-RVA: 0x2FF91E0 Offset: 0x2FF92E1 VA: 0x2FF91E0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.TryAdd
	|
	|-RVA: 0x2FFC9C0 Offset: 0x2FFCAC1 VA: 0x2FFC9C0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.TryAdd
	|
	|-RVA: 0x30000C0 Offset: 0x30001C1 VA: 0x30000C0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.TryAdd
	|
	|-RVA: 0x3003AF0 Offset: 0x3003BF1 VA: 0x3003AF0
	|-Dictionary<object, MonsterHutSaveData>.TryAdd
	|
	|-RVA: 0x3007320 Offset: 0x3007421 VA: 0x3007320
	|-Dictionary<object, OrderLotterySaveParameter>.TryAdd
	|
	|-RVA: 0x300AD70 Offset: 0x300AE71 VA: 0x300AD70
	|-Dictionary<object, OrderSaveData>.TryAdd
	|
	|-RVA: 0x300E7E0 Offset: 0x300E8E1 VA: 0x300E7E0
	|-Dictionary<object, OrderSaveParameter>.TryAdd
	|
	|-RVA: 0x2DE0060 Offset: 0x2DE0161 VA: 0x2DE0060
	|-Dictionary<object, Parameter>.TryAdd
	|
	|-RVA: 0x2DE3890 Offset: 0x2DE3991 VA: 0x2DE3890
	|-Dictionary<object, NumberControl.ValueRange>.TryAdd
	|
	|-RVA: 0x2DE6F80 Offset: 0x2DE7081 VA: 0x2DE6F80
	|-Dictionary<object, bool>.TryAdd
	|
	|-RVA: 0x2DEA640 Offset: 0x2DEA741 VA: 0x2DEA640
	|-Dictionary<object, byte>.TryAdd
	|
	|-RVA: 0x2DEDD00 Offset: 0x2DEDE01 VA: 0x2DEDD00
	|-Dictionary<object, char>.TryAdd
	|
	|-RVA: 0x2DF13C0 Offset: 0x2DF14C1 VA: 0x2DF13C0
	|-Dictionary<object, DateTime>.TryAdd
	|
	|-RVA: 0x2DF4A70 Offset: 0x2DF4B71 VA: 0x2DF4A70
	|-Dictionary<object, double>.TryAdd
	|
	|-RVA: 0x2DF8130 Offset: 0x2DF8231 VA: 0x2DF8130
	|-Dictionary<object, short>.TryAdd
	|
	|-RVA: 0x2DFB7F0 Offset: 0x2DFB8F1 VA: 0x2DFB7F0
	|-Dictionary<object, int>.TryAdd
	|-Dictionary<string, int>.TryAdd
	|
	|-RVA: 0x30BADB0 Offset: 0x30BAEB1 VA: 0x30BADB0
	|-Dictionary<object, Int32Enum>.TryAdd
	|
	|-RVA: 0x30BE470 Offset: 0x30BE571 VA: 0x30BE470
	|-Dictionary<object, long>.TryAdd
	|
	|-RVA: 0x30C1B70 Offset: 0x30C1C71 VA: 0x30C1B70
	|-Dictionary<object, Memory<object>>.TryAdd
	|
	|-RVA: 0x30C52F0 Offset: 0x30C53F1 VA: 0x30C52F0
	|-Dictionary<object, Nullable<Int32Enum>>.TryAdd
	|
	|-RVA: 0x30C8E10 Offset: 0x30C8F11 VA: 0x30C8E10
	|-Dictionary<object, Nullable<Bounds>>.TryAdd
	|
	|-RVA: 0x30CCA70 Offset: 0x30CCB71 VA: 0x30CCA70
	|-Dictionary<object, Nullable<BoundsInt>>.TryAdd
	|
	|-RVA: 0x30D0350 Offset: 0x30D0451 VA: 0x30D0350
	|-Dictionary<object, Nullable<Color32>>.TryAdd
	|
	|-RVA: 0x30D3D50 Offset: 0x30D3E51 VA: 0x30D3D50
	|-Dictionary<object, Nullable<Color>>.TryAdd
	|
	|-RVA: 0x3012090 Offset: 0x3012191 VA: 0x3012090
	|-Dictionary<object, Nullable<GradientAlphaKey>>.TryAdd
	|
	|-RVA: 0x3015AE0 Offset: 0x3015BE1 VA: 0x3015AE0
	|-Dictionary<object, Nullable<GradientColorKey>>.TryAdd
	|
	|-RVA: 0x30195F0 Offset: 0x30196F1 VA: 0x30195F0
	|-Dictionary<object, Nullable<Keyframe>>.TryAdd
	|
	|-RVA: 0x301CEA0 Offset: 0x301CFA1 VA: 0x301CEA0
	|-Dictionary<object, Nullable<LayerMask>>.TryAdd
	|
	|-RVA: 0x3020C90 Offset: 0x3020D91 VA: 0x3020C90
	|-Dictionary<object, Nullable<Matrix4x4>>.TryAdd
	|
	|-RVA: 0x30248A0 Offset: 0x30249A1 VA: 0x30248A0
	|-Dictionary<object, Nullable<Quaternion>>.TryAdd
	|
	|-RVA: 0x30281A0 Offset: 0x30282A1 VA: 0x30281A0
	|-Dictionary<object, Nullable<RangeInt>>.TryAdd
	|
	|-RVA: 0x302BBF0 Offset: 0x302BCF1 VA: 0x302BBF0
	|-Dictionary<object, Nullable<Rect>>.TryAdd
	|
	|-RVA: 0x2FD91D0 Offset: 0x2FD92D1 VA: 0x2FD91D0
	|-Dictionary<object, Nullable<RectInt>>.TryAdd
	|
	|-RVA: 0x2FDCAD0 Offset: 0x2FDCBD1 VA: 0x2FDCAD0
	|-Dictionary<object, Nullable<Vector2>>.TryAdd
	|
	|-RVA: 0x2FE0320 Offset: 0x2FE0421 VA: 0x2FE0320
	|-Dictionary<object, Nullable<Vector2Int>>.TryAdd
	|
	|-RVA: 0x2FE3B40 Offset: 0x2FE3C41 VA: 0x2FE3B40
	|-Dictionary<object, Nullable<Vector3>>.TryAdd
	|
	|-RVA: 0x2FE7330 Offset: 0x2FE7431 VA: 0x2FE7330
	|-Dictionary<object, Nullable<Vector3Int>>.TryAdd
	|
	|-RVA: 0x2FEAD50 Offset: 0x2FEAE51 VA: 0x2FEAD50
	|-Dictionary<object, Nullable<Vector4>>.TryAdd
	|
	|-RVA: 0x2FEE590 Offset: 0x2FEE691 VA: 0x2FEE590
	|-Dictionary<object, object>.TryAdd
	|
	|-RVA: 0x2FF1B90 Offset: 0x2FF1C91 VA: 0x2FF1B90
	|-Dictionary<object, ReadOnlyMemory<object>>.TryAdd
	|
	|-RVA: 0x2DC0640 Offset: 0x2DC0741 VA: 0x2DC0640
	|-Dictionary<object, ResourceLocator>.TryAdd
	|
	|-RVA: 0x2DC3D10 Offset: 0x2DC3E11 VA: 0x2DC3D10
	|-Dictionary<object, sbyte>.TryAdd
	|
	|-RVA: 0x2DC73D0 Offset: 0x2DC74D1 VA: 0x2DC73D0
	|-Dictionary<object, float>.TryAdd
	|
	|-RVA: 0x2DCAA90 Offset: 0x2DCAB91 VA: 0x2DCAA90
	|-Dictionary<object, ushort>.TryAdd
	|
	|-RVA: 0x2DCE150 Offset: 0x2DCE251 VA: 0x2DCE150
	|-Dictionary<object, uint>.TryAdd
	|
	|-RVA: 0x2DD1810 Offset: 0x2DD1911 VA: 0x2DD1810
	|-Dictionary<object, ulong>.TryAdd
	|
	|-RVA: 0x2DD5140 Offset: 0x2DD5241 VA: 0x2DD5140
	|-Dictionary<object, TransitionTables>.TryAdd
	|
	|-RVA: 0x2DD8B20 Offset: 0x2DD8C21 VA: 0x2DD8B20
	|-Dictionary<object, Bounds>.TryAdd
	|
	|-RVA: 0x2DDC4E0 Offset: 0x2DDC5E1 VA: 0x2DDC4E0
	|-Dictionary<object, BoundsInt>.TryAdd
	|
	|-RVA: 0x30D7540 Offset: 0x30D7641 VA: 0x30D7540
	|-Dictionary<object, Color32>.TryAdd
	|
	|-RVA: 0x30DAC40 Offset: 0x30DAD41 VA: 0x30DAC40
	|-Dictionary<object, Color>.TryAdd
	|
	|-RVA: 0x30DE350 Offset: 0x30DE451 VA: 0x30DE350
	|-Dictionary<object, GradientAlphaKey>.TryAdd
	|
	|-RVA: 0x30E1C50 Offset: 0x30E1D51 VA: 0x30E1C50
	|-Dictionary<object, GradientColorKey>.TryAdd
	|
	|-RVA: 0x30E5730 Offset: 0x30E5831 VA: 0x30E5730
	|-Dictionary<object, Keyframe>.TryAdd
	|
	|-RVA: 0x30E8F20 Offset: 0x30E9021 VA: 0x30E8F20
	|-Dictionary<object, LayerMask>.TryAdd
	|
	|-RVA: 0x30ECA60 Offset: 0x30ECB61 VA: 0x30ECA60
	|-Dictionary<object, Matrix4x4>.TryAdd
	|
	|-RVA: 0x30F02B0 Offset: 0x30F03B1 VA: 0x30F02B0
	|-Dictionary<object, Playable>.TryAdd
	|
	|-RVA: 0x309F0D0 Offset: 0x309F1D1 VA: 0x309F0D0
	|-Dictionary<object, Quaternion>.TryAdd
	|
	|-RVA: 0x30A27B0 Offset: 0x30A28B1 VA: 0x30A27B0
	|-Dictionary<object, RangeInt>.TryAdd
	|
	|-RVA: 0x30A5EA0 Offset: 0x30A5FA1 VA: 0x30A5EA0
	|-Dictionary<object, Rect>.TryAdd
	|
	|-RVA: 0x30A95A0 Offset: 0x30A96A1 VA: 0x30A95A0
	|-Dictionary<object, RectInt>.TryAdd
	|
	|-RVA: 0x30ACEC0 Offset: 0x30ACFC1 VA: 0x30ACEC0
	|-Dictionary<object, AsyncOperationHandle>.TryAdd
	|
	|-RVA: 0x30B0890 Offset: 0x30B0991 VA: 0x30B0890
	|-Dictionary<object, AsyncOperationHandle<object>>.TryAdd
	|
	|-RVA: 0x30B4040 Offset: 0x30B4141 VA: 0x30B4040
	|-Dictionary<object, Vector2>.TryAdd
	|
	|-RVA: 0x30B7700 Offset: 0x30B7801 VA: 0x30B7700
	|-Dictionary<object, Vector2Int>.TryAdd
	|
	|-RVA: 0x30833C0 Offset: 0x30834C1 VA: 0x30833C0
	|-Dictionary<object, Vector3>.TryAdd
	|
	|-RVA: 0x3086AF0 Offset: 0x3086BF1 VA: 0x3086AF0
	|-Dictionary<object, Vector3Int>.TryAdd
	|
	|-RVA: 0x308A210 Offset: 0x308A311 VA: 0x308A210
	|-Dictionary<object, Vector4>.TryAdd
	|
	|-RVA: 0x308D920 Offset: 0x308DA21 VA: 0x308D920
	|-Dictionary<ReadOnlyMemory<object>, object>.TryAdd
	|
	|-RVA: 0x3090ED0 Offset: 0x3090FD1 VA: 0x3090ED0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.TryAdd
	|
	|-RVA: 0x30945C0 Offset: 0x30946C1 VA: 0x30945C0
	|-Dictionary<sbyte, object>.TryAdd
	|
	|-RVA: 0x3098180 Offset: 0x3098281 VA: 0x3098180
	|-Dictionary<float, CurveSample>.TryAdd
	|
	|-RVA: 0x309BA20 Offset: 0x309BB21 VA: 0x309BA20
	|-Dictionary<float, object>.TryAdd
	|
	|-RVA: 0x319EF90 Offset: 0x319F091 VA: 0x319EF90
	|-Dictionary<ushort, object>.TryAdd
	|
	|-RVA: 0x31A24B0 Offset: 0x31A25B1 VA: 0x31A24B0
	|-Dictionary<uint, int>.TryAdd
	|
	|-RVA: 0x31A5A70 Offset: 0x31A5B71 VA: 0x31A5A70
	|-Dictionary<uint, Int32Enum>.TryAdd
	|
	|-RVA: 0x31A9130 Offset: 0x31A9231 VA: 0x31A9130
	|-Dictionary<uint, object>.TryAdd
	|
	|-RVA: 0x31AC750 Offset: 0x31AC851 VA: 0x31AC750
	|-Dictionary<ulong, object>.TryAdd
	|
	|-RVA: 0x31AFD00 Offset: 0x31AFE01 VA: 0x31AFD00
	|-Dictionary<EdgeKeyByHash, int>.TryAdd
	|
	|-RVA: 0x31B3750 Offset: 0x31B3851 VA: 0x31B3750
	|-Dictionary<EdgeKeyByHash, CapEdge>.TryAdd
	|
	|-RVA: 0x31B7290 Offset: 0x31B7391 VA: 0x31B7290
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.TryAdd
	|
	|-RVA: 0x302F570 Offset: 0x302F671 VA: 0x302F570
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.TryAdd
	|
	|-RVA: 0x3032CF0 Offset: 0x3032DF1 VA: 0x3032CF0
	|-Dictionary<MeshDataConnectivity.Face, bool>.TryAdd
	|
	|-RVA: 0x30363D0 Offset: 0x30364D1 VA: 0x30363D0
	|-Dictionary<MeshDataConnectivity.Face, object>.TryAdd
	|
	|-RVA: 0x3039E10 Offset: 0x3039F11 VA: 0x3039E10
	|-Dictionary<Bounds, object>.TryAdd
	|
	|-RVA: 0x303D940 Offset: 0x303DA41 VA: 0x303D940
	|-Dictionary<BoundsInt, object>.TryAdd
	|
	|-RVA: 0x3041140 Offset: 0x3041241 VA: 0x3041140
	|-Dictionary<Color, object>.TryAdd
	|
	|-RVA: 0x30447F0 Offset: 0x30448F1 VA: 0x30447F0
	|-Dictionary<Color32, object>.TryAdd
	|
	|-RVA: 0x3047E10 Offset: 0x3047F11 VA: 0x3047E10
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.TryAdd
	|
	|-RVA: 0x30669A0 Offset: 0x3066AA1 VA: 0x30669A0
	|-Dictionary<GradientAlphaKey, object>.TryAdd
	|
	|-RVA: 0x306A3E0 Offset: 0x306A4E1 VA: 0x306A3E0
	|-Dictionary<GradientColorKey, object>.TryAdd
	|
	|-RVA: 0x306E0F0 Offset: 0x306E1F1 VA: 0x306E0F0
	|-Dictionary<Keyframe, object>.TryAdd
	|
	|-RVA: 0x30718B0 Offset: 0x30719B1 VA: 0x30718B0
	|-Dictionary<LayerMask, object>.TryAdd
	|
	|-RVA: 0x30756D0 Offset: 0x30757D1 VA: 0x30756D0
	|-Dictionary<Matrix4x4, object>.TryAdd
	|
	|-RVA: 0x3078F70 Offset: 0x3079071 VA: 0x3078F70
	|-Dictionary<IntVec3, object>.TryAdd
	|
	|-RVA: 0x307C6B0 Offset: 0x307C7B1 VA: 0x307C6B0
	|-Dictionary<Quaternion, object>.TryAdd
	|
	|-RVA: 0x307FD20 Offset: 0x307FE21 VA: 0x307FD20
	|-Dictionary<RangeInt, object>.TryAdd
	|
	|-RVA: 0x304B520 Offset: 0x304B621 VA: 0x304B520
	|-Dictionary<Rect, object>.TryAdd
	|
	|-RVA: 0x304EC00 Offset: 0x304ED01 VA: 0x304EC00
	|-Dictionary<RectInt, object>.TryAdd
	|
	|-RVA: 0x30521A0 Offset: 0x30522A1 VA: 0x30521A0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.TryAdd
	|
	|-RVA: 0x3055880 Offset: 0x3055981 VA: 0x3055880
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.TryAdd
	|
	|-RVA: 0x3058F00 Offset: 0x3059001 VA: 0x3058F00
	|-Dictionary<Vector2, object>.TryAdd
	|
	|-RVA: 0x305C520 Offset: 0x305C621 VA: 0x305C520
	|-Dictionary<Vector2Int, object>.TryAdd
	|
	|-RVA: 0x305FBE0 Offset: 0x305FCE1 VA: 0x305FBE0
	|-Dictionary<Vector3, object>.TryAdd
	|
	|-RVA: 0x30632F0 Offset: 0x30633F1 VA: 0x30632F0
	|-Dictionary<Vector3Int, object>.TryAdd
	|
	|-RVA: 0x2E3CD10 Offset: 0x2E3CE11 VA: 0x2E3CD10
	|-Dictionary<Vector4, object>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18680 Offset: 0x2A18781 VA: 0x2A18680
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2A1BCD0 Offset: 0x2A1BDD1 VA: 0x2A1BCD0
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E2BC50 Offset: 0x2E2BD51 VA: 0x2E2BC50
	|-Dictionary<Season, Texture>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F7AE50 Offset: 0x2F7AF51 VA: 0x2F7AE50
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F7EE30 Offset: 0x2F7EF31 VA: 0x2F7EE30
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F82A50 Offset: 0x2F82B51 VA: 0x2F82A50
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F861E0 Offset: 0x2F862E1 VA: 0x2F861E0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F898A0 Offset: 0x2F899A1 VA: 0x2F898A0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F8D500 Offset: 0x2F8D601 VA: 0x2F8D500
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F90D00 Offset: 0x2F90E01 VA: 0x2F90D00
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F949A0 Offset: 0x2F94AA1 VA: 0x2F949A0
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D828E0 Offset: 0x2D829E1 VA: 0x2D828E0
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D865F0 Offset: 0x2D866F1 VA: 0x2D865F0
	|-Dictionary<Parameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D89D90 Offset: 0x2D89E91 VA: 0x2D89D90
	|-Dictionary<bool, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D8D3B0 Offset: 0x2D8D4B1 VA: 0x2D8D3B0
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D909D0 Offset: 0x2D90AD1 VA: 0x2D909D0
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D93FF0 Offset: 0x2D940F1 VA: 0x2D93FF0
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D97600 Offset: 0x2D97701 VA: 0x2D97600
	|-Dictionary<double, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D9AC90 Offset: 0x2D9AD91 VA: 0x2D9AC90
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D9E2A0 Offset: 0x2D9E3A1 VA: 0x2D9E2A0
	|-Dictionary<short, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D3C870 Offset: 0x2D3C971 VA: 0x2D3C870
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D40260 Offset: 0x2D40361 VA: 0x2D40260
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D438F0 Offset: 0x2D439F1 VA: 0x2D438F0
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D47460 Offset: 0x2D47561 VA: 0x2D47460
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D4AC50 Offset: 0x2D4AD51 VA: 0x2D4AC50
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D4E270 Offset: 0x2D4E371 VA: 0x2D4E270
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D51830 Offset: 0x2D51931 VA: 0x2D51830
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D54DF0 Offset: 0x2D54EF1 VA: 0x2D54DF0
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2D583B0 Offset: 0x2D584B1 VA: 0x2D583B0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F5E550 Offset: 0x2F5E651 VA: 0x2F5E550
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F61C40 Offset: 0x2F61D41 VA: 0x2F61C40
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F655B0 Offset: 0x2F656B1 VA: 0x2F655B0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F68D50 Offset: 0x2F68E51 VA: 0x2F68D50
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F6C3F0 Offset: 0x2F6C4F1 VA: 0x2F6C3F0
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F6FAF0 Offset: 0x2F6FBF1 VA: 0x2F6FAF0
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F736A0 Offset: 0x2F737A1 VA: 0x2F736A0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F77220 Offset: 0x2F77321 VA: 0x2F77220
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E1E420 Offset: 0x2E1E521 VA: 0x2E1E420
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E21A50 Offset: 0x2E21B51 VA: 0x2E21A50
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E250B0 Offset: 0x2E251B1 VA: 0x2E250B0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E28690 Offset: 0x2E28791 VA: 0x2E28690
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E2F310 Offset: 0x2E2F411 VA: 0x2E2F310
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E32830 Offset: 0x2E32931 VA: 0x2E32830
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E35EC0 Offset: 0x2E35FC1 VA: 0x2E35EC0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E39570 Offset: 0x2E39671 VA: 0x2E39570
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F98100 Offset: 0x2F98201 VA: 0x2F98100
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F9B830 Offset: 0x2F9B931 VA: 0x2F9B830
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F9EED0 Offset: 0x2F9EFD1 VA: 0x2F9EED0
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FA2690 Offset: 0x2FA2791 VA: 0x2FA2690
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FA64F0 Offset: 0x2FA65F1 VA: 0x2FA64F0
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FAA450 Offset: 0x2FAA551 VA: 0x2FAA450
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FADD30 Offset: 0x2FADE31 VA: 0x2FADD30
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FB1970 Offset: 0x2FB1A71 VA: 0x2FB1970
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F1C6D0 Offset: 0x2F1C7D1 VA: 0x2F1C6D0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F20330 Offset: 0x2F20431 VA: 0x2F20330
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F24050 Offset: 0x2F24151 VA: 0x2F24050
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F27900 Offset: 0x2F27A01 VA: 0x2F27900
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F2BC90 Offset: 0x2F2BD91 VA: 0x2F2BC90
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F2FAB0 Offset: 0x2F2FBB1 VA: 0x2F2FAB0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F33420 Offset: 0x2F33521 VA: 0x2F33420
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F37080 Offset: 0x2F37181 VA: 0x2F37080
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2EFFD90 Offset: 0x2EFFE91 VA: 0x2EFFD90
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F03700 Offset: 0x2F03801 VA: 0x2F03700
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F06FD0 Offset: 0x2F070D1 VA: 0x2F06FD0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F0A840 Offset: 0x2F0A941 VA: 0x2F0A840
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F0E080 Offset: 0x2F0E181 VA: 0x2F0E080
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F11CB0 Offset: 0x2F11DB1 VA: 0x2F11CB0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F153F0 Offset: 0x2F154F1 VA: 0x2F153F0
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2F18D60 Offset: 0x2F18E61 VA: 0x2F18D60
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FF57E0 Offset: 0x2FF58E1 VA: 0x2FF57E0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FF9250 Offset: 0x2FF9351 VA: 0x2FF9250
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FFC9F0 Offset: 0x2FFCAF1 VA: 0x2FFC9F0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30000F0 Offset: 0x30001F1 VA: 0x30000F0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3003B70 Offset: 0x3003C71 VA: 0x3003B70
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3007350 Offset: 0x3007451 VA: 0x3007350
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x300ADF0 Offset: 0x300AEF1 VA: 0x300ADF0
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x300E850 Offset: 0x300E951 VA: 0x300E850
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DE0100 Offset: 0x2DE0201 VA: 0x2DE0100
	|-Dictionary<object, Parameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DE38C0 Offset: 0x2DE39C1 VA: 0x2DE38C0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DE6FB0 Offset: 0x2DE70B1 VA: 0x2DE6FB0
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DEA670 Offset: 0x2DEA771 VA: 0x2DEA670
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DEDD30 Offset: 0x2DEDE31 VA: 0x2DEDD30
	|-Dictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DF13F0 Offset: 0x2DF14F1 VA: 0x2DF13F0
	|-Dictionary<object, DateTime>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DF4AA0 Offset: 0x2DF4BA1 VA: 0x2DF4AA0
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DF8160 Offset: 0x2DF8261 VA: 0x2DF8160
	|-Dictionary<object, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DFB820 Offset: 0x2DFB921 VA: 0x2DFB820
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30BADE0 Offset: 0x30BAEE1 VA: 0x30BADE0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30BE4A0 Offset: 0x30BE5A1 VA: 0x30BE4A0
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30C1BA0 Offset: 0x30C1CA1 VA: 0x30C1BA0
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30C5320 Offset: 0x30C5421 VA: 0x30C5320
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30C8E90 Offset: 0x30C8F91 VA: 0x30C8E90
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30CCAF0 Offset: 0x30CCBF1 VA: 0x30CCAF0
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30D0380 Offset: 0x30D0481 VA: 0x30D0380
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30D3DC0 Offset: 0x30D3EC1 VA: 0x30D3DC0
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30120C0 Offset: 0x30121C1 VA: 0x30120C0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3015B50 Offset: 0x3015C51 VA: 0x3015B50
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3019660 Offset: 0x3019761 VA: 0x3019660
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x301CED0 Offset: 0x301CFD1 VA: 0x301CED0
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3020D30 Offset: 0x3020E31 VA: 0x3020D30
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3024910 Offset: 0x3024A11 VA: 0x3024910
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30281D0 Offset: 0x30282D1 VA: 0x30281D0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x302BC60 Offset: 0x302BD61 VA: 0x302BC60
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FD9240 Offset: 0x2FD9341 VA: 0x2FD9240
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FDCB00 Offset: 0x2FDCC01 VA: 0x2FDCB00
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FE0350 Offset: 0x2FE0451 VA: 0x2FE0350
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FE3B70 Offset: 0x2FE3C71 VA: 0x2FE3B70
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FE7360 Offset: 0x2FE7461 VA: 0x2FE7360
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FEADC0 Offset: 0x2FEAEC1 VA: 0x2FEADC0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FEE5C0 Offset: 0x2FEE6C1 VA: 0x2FEE5C0
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2FF1BC0 Offset: 0x2FF1CC1 VA: 0x2FF1BC0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DC0670 Offset: 0x2DC0771 VA: 0x2DC0670
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DC3D40 Offset: 0x2DC3E41 VA: 0x2DC3D40
	|-Dictionary<object, sbyte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DC7400 Offset: 0x2DC7501 VA: 0x2DC7400
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DCAAC0 Offset: 0x2DCABC1 VA: 0x2DCAAC0
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DCE180 Offset: 0x2DCE281 VA: 0x2DCE180
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DD1840 Offset: 0x2DD1941 VA: 0x2DD1840
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DD51B0 Offset: 0x2DD52B1 VA: 0x2DD51B0
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DD8B90 Offset: 0x2DD8C91 VA: 0x2DD8B90
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DDC550 Offset: 0x2DDC651 VA: 0x2DDC550
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30D7570 Offset: 0x30D7671 VA: 0x30D7570
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30DAC70 Offset: 0x30DAD71 VA: 0x30DAC70
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30DE380 Offset: 0x30DE481 VA: 0x30DE380
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30E1CC0 Offset: 0x30E1DC1 VA: 0x30E1CC0
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30E57B0 Offset: 0x30E58B1 VA: 0x30E57B0
	|-Dictionary<object, Keyframe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30E8F50 Offset: 0x30E9051 VA: 0x30E8F50
	|-Dictionary<object, LayerMask>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30ECAF0 Offset: 0x30ECBF1 VA: 0x30ECAF0
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30F02E0 Offset: 0x30F03E1 VA: 0x30F02E0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x309F100 Offset: 0x309F201 VA: 0x309F100
	|-Dictionary<object, Quaternion>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30A27E0 Offset: 0x30A28E1 VA: 0x30A27E0
	|-Dictionary<object, RangeInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30A5ED0 Offset: 0x30A5FD1 VA: 0x30A5ED0
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30A95D0 Offset: 0x30A96D1 VA: 0x30A95D0
	|-Dictionary<object, RectInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30ACF30 Offset: 0x30AD031 VA: 0x30ACF30
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30B0900 Offset: 0x30B0A01 VA: 0x30B0900
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30B4070 Offset: 0x30B4171 VA: 0x30B4070
	|-Dictionary<object, Vector2>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30B7730 Offset: 0x30B7831 VA: 0x30B7730
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30833F0 Offset: 0x30834F1 VA: 0x30833F0
	|-Dictionary<object, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3086B20 Offset: 0x3086C21 VA: 0x3086B20
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x308A240 Offset: 0x308A341 VA: 0x308A240
	|-Dictionary<object, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x308D950 Offset: 0x308DA51 VA: 0x308D950
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3090F00 Offset: 0x3091001 VA: 0x3090F00
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30945F0 Offset: 0x30946F1 VA: 0x30945F0
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3098220 Offset: 0x3098321 VA: 0x3098220
	|-Dictionary<float, CurveSample>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x309BA50 Offset: 0x309BB51 VA: 0x309BA50
	|-Dictionary<float, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x319EFC0 Offset: 0x319F0C1 VA: 0x319EFC0
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31A24E0 Offset: 0x31A25E1 VA: 0x31A24E0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31A5AA0 Offset: 0x31A5BA1 VA: 0x31A5AA0
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31A9160 Offset: 0x31A9261 VA: 0x31A9160
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31AC780 Offset: 0x31AC881 VA: 0x31AC780
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31AFD30 Offset: 0x31AFE31 VA: 0x31AFD30
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31B37D0 Offset: 0x31B38D1 VA: 0x31B37D0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x31B7310 Offset: 0x31B7411 VA: 0x31B7310
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x302F5E0 Offset: 0x302F6E1 VA: 0x302F5E0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3032D20 Offset: 0x3032E21 VA: 0x3032D20
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3036400 Offset: 0x3036501 VA: 0x3036400
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3039E80 Offset: 0x3039F81 VA: 0x3039E80
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x303D9B0 Offset: 0x303DAB1 VA: 0x303D9B0
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3041170 Offset: 0x3041271 VA: 0x3041170
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3044820 Offset: 0x3044921 VA: 0x3044820
	|-Dictionary<Color32, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3047E40 Offset: 0x3047F41 VA: 0x3047E40
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30669D0 Offset: 0x3066AD1 VA: 0x30669D0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x306A450 Offset: 0x306A551 VA: 0x306A450
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x306E170 Offset: 0x306E271 VA: 0x306E170
	|-Dictionary<Keyframe, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30718E0 Offset: 0x30719E1 VA: 0x30718E0
	|-Dictionary<LayerMask, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3075760 Offset: 0x3075861 VA: 0x3075760
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3078FA0 Offset: 0x30790A1 VA: 0x3078FA0
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x307C6E0 Offset: 0x307C7E1 VA: 0x307C6E0
	|-Dictionary<Quaternion, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x307FD50 Offset: 0x307FE51 VA: 0x307FD50
	|-Dictionary<RangeInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x304B550 Offset: 0x304B651 VA: 0x304B550
	|-Dictionary<Rect, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x304EC30 Offset: 0x304ED31 VA: 0x304EC30
	|-Dictionary<RectInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30521D0 Offset: 0x30522D1 VA: 0x30521D0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x30558B0 Offset: 0x30559B1 VA: 0x30558B0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3058F30 Offset: 0x3059031 VA: 0x3058F30
	|-Dictionary<Vector2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x305C550 Offset: 0x305C651 VA: 0x305C550
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x305FC10 Offset: 0x305FD11 VA: 0x305FC10
	|-Dictionary<Vector3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3063320 Offset: 0x3063421 VA: 0x3063320
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2E3CD40 Offset: 0x2E3CE41 VA: 0x2E3CD40
	|-Dictionary<Vector4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18690 Offset: 0x2A18791 VA: 0x2A18690
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2A1BCE0 Offset: 0x2A1BDE1 VA: 0x2A1BCE0
	|-Dictionary<BitVector32Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E2BC60 Offset: 0x2E2BD61 VA: 0x2E2BC60
	|-Dictionary<Season, Texture>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F7AE60 Offset: 0x2F7AF61 VA: 0x2F7AE60
	|-Dictionary<EventCheckId, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F7EE40 Offset: 0x2F7EF41 VA: 0x2F7EE40
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F82A60 Offset: 0x2F82B61 VA: 0x2F82A60
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F861F0 Offset: 0x2F862F1 VA: 0x2F861F0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F898B0 Offset: 0x2F899B1 VA: 0x2F898B0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F8D510 Offset: 0x2F8D611 VA: 0x2F8D510
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F90D10 Offset: 0x2F90E11 VA: 0x2F90D10
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F949B0 Offset: 0x2F94AB1 VA: 0x2F949B0
	|-Dictionary<OrderSaveData, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D828F0 Offset: 0x2D829F1 VA: 0x2D828F0
	|-Dictionary<OrderSaveParameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D86600 Offset: 0x2D86701 VA: 0x2D86600
	|-Dictionary<Parameter, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D89DA0 Offset: 0x2D89EA1 VA: 0x2D89DA0
	|-Dictionary<bool, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D8D3C0 Offset: 0x2D8D4C1 VA: 0x2D8D3C0
	|-Dictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D909E0 Offset: 0x2D90AE1 VA: 0x2D909E0
	|-Dictionary<char, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D94000 Offset: 0x2D94101 VA: 0x2D94000
	|-Dictionary<DateTime, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D97610 Offset: 0x2D97711 VA: 0x2D97610
	|-Dictionary<double, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D9ACA0 Offset: 0x2D9ADA1 VA: 0x2D9ACA0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D9E2B0 Offset: 0x2D9E3B1 VA: 0x2D9E2B0
	|-Dictionary<short, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D3C880 Offset: 0x2D3C981 VA: 0x2D3C880
	|-Dictionary<int, CropDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D40270 Offset: 0x2D40371 VA: 0x2D40270
	|-Dictionary<int, EffectDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D43900 Offset: 0x2D43A01 VA: 0x2D43900
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D47470 Offset: 0x2D47571 VA: 0x2D47470
	|-Dictionary<int, MineTypeDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D4AC60 Offset: 0x2D4AD61 VA: 0x2D4AC60
	|-Dictionary<int, MiningDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D4E280 Offset: 0x2D4E381 VA: 0x2D4E280
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D51840 Offset: 0x2D51941 VA: 0x2D51840
	|-Dictionary<int, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D54E00 Offset: 0x2D54F01 VA: 0x2D54E00
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2D583C0 Offset: 0x2D584C1 VA: 0x2D583C0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F5E560 Offset: 0x2F5E661 VA: 0x2F5E560
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F61C50 Offset: 0x2F61D51 VA: 0x2F61C50
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F655C0 Offset: 0x2F656C1 VA: 0x2F655C0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F68D60 Offset: 0x2F68E61 VA: 0x2F68D60
	|-Dictionary<int, SceneInstance>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F6C400 Offset: 0x2F6C501 VA: 0x2F6C400
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F6FB00 Offset: 0x2F6FC01 VA: 0x2F6FB00
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F736B0 Offset: 0x2F737B1 VA: 0x2F736B0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F77230 Offset: 0x2F77331 VA: 0x2F77230
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E1E430 Offset: 0x2E1E531 VA: 0x2E1E430
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E21A60 Offset: 0x2E21B61 VA: 0x2E21A60
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E250C0 Offset: 0x2E251C1 VA: 0x2E250C0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E286A0 Offset: 0x2E287A1 VA: 0x2E286A0
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E2F320 Offset: 0x2E2F421 VA: 0x2E2F320
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E32840 Offset: 0x2E32941 VA: 0x2E32840
	|-Dictionary<Int32Enum, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E35ED0 Offset: 0x2E35FD1 VA: 0x2E35ED0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E39580 Offset: 0x2E39681 VA: 0x2E39580
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F98110 Offset: 0x2F98211 VA: 0x2F98110
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F9B840 Offset: 0x2F9B941 VA: 0x2F9B840
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F9EEE0 Offset: 0x2F9EFE1 VA: 0x2F9EEE0
	|-Dictionary<Memory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FA26A0 Offset: 0x2FA27A1 VA: 0x2FA26A0
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FA6500 Offset: 0x2FA6601 VA: 0x2FA6500
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FAA460 Offset: 0x2FAA561 VA: 0x2FAA460
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FADD40 Offset: 0x2FADE41 VA: 0x2FADD40
	|-Dictionary<Nullable<Color32>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FB1980 Offset: 0x2FB1A81 VA: 0x2FB1980
	|-Dictionary<Nullable<Color>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F1C6E0 Offset: 0x2F1C7E1 VA: 0x2F1C6E0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F20340 Offset: 0x2F20441 VA: 0x2F20340
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F24060 Offset: 0x2F24161 VA: 0x2F24060
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F27910 Offset: 0x2F27A11 VA: 0x2F27910
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F2BCA0 Offset: 0x2F2BDA1 VA: 0x2F2BCA0
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F2FAC0 Offset: 0x2F2FBC1 VA: 0x2F2FAC0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F33430 Offset: 0x2F33531 VA: 0x2F33430
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F37090 Offset: 0x2F37191 VA: 0x2F37090
	|-Dictionary<Nullable<Rect>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2EFFDA0 Offset: 0x2EFFEA1 VA: 0x2EFFDA0
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F03710 Offset: 0x2F03811 VA: 0x2F03710
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F06FE0 Offset: 0x2F070E1 VA: 0x2F06FE0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F0A850 Offset: 0x2F0A951 VA: 0x2F0A850
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F0E090 Offset: 0x2F0E191 VA: 0x2F0E090
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F11CC0 Offset: 0x2F11DC1 VA: 0x2F11CC0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F15400 Offset: 0x2F15501 VA: 0x2F15400
	|-Dictionary<object, BitVector32Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2F18D70 Offset: 0x2F18E71 VA: 0x2F18D70
	|-Dictionary<object, EventCheckId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FF57F0 Offset: 0x2FF58F1 VA: 0x2FF57F0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FF9260 Offset: 0x2FF9361 VA: 0x2FF9260
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FFCA00 Offset: 0x2FFCB01 VA: 0x2FFCA00
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3000100 Offset: 0x3000201 VA: 0x3000100
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3003B80 Offset: 0x3003C81 VA: 0x3003B80
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3007360 Offset: 0x3007461 VA: 0x3007360
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x300AE00 Offset: 0x300AF01 VA: 0x300AE00
	|-Dictionary<object, OrderSaveData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x300E860 Offset: 0x300E961 VA: 0x300E860
	|-Dictionary<object, OrderSaveParameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DE0110 Offset: 0x2DE0211 VA: 0x2DE0110
	|-Dictionary<object, Parameter>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DE38D0 Offset: 0x2DE39D1 VA: 0x2DE38D0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DE6FC0 Offset: 0x2DE70C1 VA: 0x2DE6FC0
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DEA680 Offset: 0x2DEA781 VA: 0x2DEA680
	|-Dictionary<object, byte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DEDD40 Offset: 0x2DEDE41 VA: 0x2DEDD40
	|-Dictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DF1400 Offset: 0x2DF1501 VA: 0x2DF1400
	|-Dictionary<object, DateTime>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DF4AB0 Offset: 0x2DF4BB1 VA: 0x2DF4AB0
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DF8170 Offset: 0x2DF8271 VA: 0x2DF8170
	|-Dictionary<object, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DFB830 Offset: 0x2DFB931 VA: 0x2DFB830
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30BADF0 Offset: 0x30BAEF1 VA: 0x30BADF0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30BE4B0 Offset: 0x30BE5B1 VA: 0x30BE4B0
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30C1BB0 Offset: 0x30C1CB1 VA: 0x30C1BB0
	|-Dictionary<object, Memory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30C5330 Offset: 0x30C5431 VA: 0x30C5330
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30C8EA0 Offset: 0x30C8FA1 VA: 0x30C8EA0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30CCB00 Offset: 0x30CCC01 VA: 0x30CCB00
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30D0390 Offset: 0x30D0491 VA: 0x30D0390
	|-Dictionary<object, Nullable<Color32>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30D3DD0 Offset: 0x30D3ED1 VA: 0x30D3DD0
	|-Dictionary<object, Nullable<Color>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30120D0 Offset: 0x30121D1 VA: 0x30120D0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3015B60 Offset: 0x3015C61 VA: 0x3015B60
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3019670 Offset: 0x3019771 VA: 0x3019670
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x301CEE0 Offset: 0x301CFE1 VA: 0x301CEE0
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3020D40 Offset: 0x3020E41 VA: 0x3020D40
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3024920 Offset: 0x3024A21 VA: 0x3024920
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30281E0 Offset: 0x30282E1 VA: 0x30281E0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x302BC70 Offset: 0x302BD71 VA: 0x302BC70
	|-Dictionary<object, Nullable<Rect>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FD9250 Offset: 0x2FD9351 VA: 0x2FD9250
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FDCB10 Offset: 0x2FDCC11 VA: 0x2FDCB10
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FE0360 Offset: 0x2FE0461 VA: 0x2FE0360
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FE3B80 Offset: 0x2FE3C81 VA: 0x2FE3B80
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FE7370 Offset: 0x2FE7471 VA: 0x2FE7370
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FEADD0 Offset: 0x2FEAED1 VA: 0x2FEADD0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FEE5D0 Offset: 0x2FEE6D1 VA: 0x2FEE5D0
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2FF1BD0 Offset: 0x2FF1CD1 VA: 0x2FF1BD0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DC0680 Offset: 0x2DC0781 VA: 0x2DC0680
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DC3D50 Offset: 0x2DC3E51 VA: 0x2DC3D50
	|-Dictionary<object, sbyte>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DC7410 Offset: 0x2DC7511 VA: 0x2DC7410
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DCAAD0 Offset: 0x2DCABD1 VA: 0x2DCAAD0
	|-Dictionary<object, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DCE190 Offset: 0x2DCE291 VA: 0x2DCE190
	|-Dictionary<object, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DD1850 Offset: 0x2DD1951 VA: 0x2DD1850
	|-Dictionary<object, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DD51C0 Offset: 0x2DD52C1 VA: 0x2DD51C0
	|-Dictionary<object, TransitionTables>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DD8BA0 Offset: 0x2DD8CA1 VA: 0x2DD8BA0
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DDC560 Offset: 0x2DDC661 VA: 0x2DDC560
	|-Dictionary<object, BoundsInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30D7580 Offset: 0x30D7681 VA: 0x30D7580
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30DAC80 Offset: 0x30DAD81 VA: 0x30DAC80
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30DE390 Offset: 0x30DE491 VA: 0x30DE390
	|-Dictionary<object, GradientAlphaKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30E1CD0 Offset: 0x30E1DD1 VA: 0x30E1CD0
	|-Dictionary<object, GradientColorKey>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30E57C0 Offset: 0x30E58C1 VA: 0x30E57C0
	|-Dictionary<object, Keyframe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30E8F60 Offset: 0x30E9061 VA: 0x30E8F60
	|-Dictionary<object, LayerMask>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30ECB00 Offset: 0x30ECC01 VA: 0x30ECB00
	|-Dictionary<object, Matrix4x4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30F02F0 Offset: 0x30F03F1 VA: 0x30F02F0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x309F110 Offset: 0x309F211 VA: 0x309F110
	|-Dictionary<object, Quaternion>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30A27F0 Offset: 0x30A28F1 VA: 0x30A27F0
	|-Dictionary<object, RangeInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30A5EE0 Offset: 0x30A5FE1 VA: 0x30A5EE0
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30A95E0 Offset: 0x30A96E1 VA: 0x30A95E0
	|-Dictionary<object, RectInt>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30ACF40 Offset: 0x30AD041 VA: 0x30ACF40
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30B0910 Offset: 0x30B0A11 VA: 0x30B0910
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30B4080 Offset: 0x30B4181 VA: 0x30B4080
	|-Dictionary<object, Vector2>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30B7740 Offset: 0x30B7841 VA: 0x30B7740
	|-Dictionary<object, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3083400 Offset: 0x3083501 VA: 0x3083400
	|-Dictionary<object, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3086B30 Offset: 0x3086C31 VA: 0x3086B30
	|-Dictionary<object, Vector3Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x308A250 Offset: 0x308A351 VA: 0x308A250
	|-Dictionary<object, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x308D960 Offset: 0x308DA61 VA: 0x308D960
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3090F10 Offset: 0x3091011 VA: 0x3090F10
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3094600 Offset: 0x3094701 VA: 0x3094600
	|-Dictionary<sbyte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3098230 Offset: 0x3098331 VA: 0x3098230
	|-Dictionary<float, CurveSample>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x309BA60 Offset: 0x309BB61 VA: 0x309BA60
	|-Dictionary<float, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x319EFD0 Offset: 0x319F0D1 VA: 0x319EFD0
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31A24F0 Offset: 0x31A25F1 VA: 0x31A24F0
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31A5AB0 Offset: 0x31A5BB1 VA: 0x31A5AB0
	|-Dictionary<uint, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31A9170 Offset: 0x31A9271 VA: 0x31A9170
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31AC790 Offset: 0x31AC891 VA: 0x31AC790
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31AFD40 Offset: 0x31AFE41 VA: 0x31AFD40
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31B37E0 Offset: 0x31B38E1 VA: 0x31B37E0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x31B7320 Offset: 0x31B7421 VA: 0x31B7320
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x302F5F0 Offset: 0x302F6F1 VA: 0x302F5F0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3032D30 Offset: 0x3032E31 VA: 0x3032D30
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3036410 Offset: 0x3036511 VA: 0x3036410
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3039E90 Offset: 0x3039F91 VA: 0x3039E90
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x303D9C0 Offset: 0x303DAC1 VA: 0x303D9C0
	|-Dictionary<BoundsInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3041180 Offset: 0x3041281 VA: 0x3041180
	|-Dictionary<Color, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3044830 Offset: 0x3044931 VA: 0x3044830
	|-Dictionary<Color32, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3047E50 Offset: 0x3047F51 VA: 0x3047E50
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30669E0 Offset: 0x3066AE1 VA: 0x30669E0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x306A460 Offset: 0x306A561 VA: 0x306A460
	|-Dictionary<GradientColorKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x306E180 Offset: 0x306E281 VA: 0x306E180
	|-Dictionary<Keyframe, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30718F0 Offset: 0x30719F1 VA: 0x30718F0
	|-Dictionary<LayerMask, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3075770 Offset: 0x3075871 VA: 0x3075770
	|-Dictionary<Matrix4x4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3078FB0 Offset: 0x30790B1 VA: 0x3078FB0
	|-Dictionary<IntVec3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x307C6F0 Offset: 0x307C7F1 VA: 0x307C6F0
	|-Dictionary<Quaternion, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x307FD60 Offset: 0x307FE61 VA: 0x307FD60
	|-Dictionary<RangeInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x304B560 Offset: 0x304B661 VA: 0x304B560
	|-Dictionary<Rect, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x304EC40 Offset: 0x304ED41 VA: 0x304EC40
	|-Dictionary<RectInt, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30521E0 Offset: 0x30522E1 VA: 0x30521E0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x30558C0 Offset: 0x30559C1 VA: 0x30558C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3058F40 Offset: 0x3059041 VA: 0x3058F40
	|-Dictionary<Vector2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x305C560 Offset: 0x305C661 VA: 0x305C560
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x305FC20 Offset: 0x305FD21 VA: 0x305FC20
	|-Dictionary<Vector3, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x3063330 Offset: 0x3063431 VA: 0x3063330
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2E3CD50 Offset: 0x2E3CE51 VA: 0x2E3CD50
	|-Dictionary<Vector4, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A186C0 Offset: 0x2A187C1 VA: 0x2A186C0
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A1BD10 Offset: 0x2A1BE11 VA: 0x2A1BD10
	|-Dictionary<BitVector32Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E2BC90 Offset: 0x2E2BD91 VA: 0x2E2BC90
	|-Dictionary<Season, Texture>.System.Collections.ICollection.CopyTo
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F7AE90 Offset: 0x2F7AF91 VA: 0x2F7AE90
	|-Dictionary<EventCheckId, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F7EE70 Offset: 0x2F7EF71 VA: 0x2F7EE70
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F82A90 Offset: 0x2F82B91 VA: 0x2F82A90
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F86220 Offset: 0x2F86321 VA: 0x2F86220
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F898E0 Offset: 0x2F899E1 VA: 0x2F898E0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F8D540 Offset: 0x2F8D641 VA: 0x2F8D540
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F90D40 Offset: 0x2F90E41 VA: 0x2F90D40
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F949E0 Offset: 0x2F94AE1 VA: 0x2F949E0
	|-Dictionary<OrderSaveData, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D82920 Offset: 0x2D82A21 VA: 0x2D82920
	|-Dictionary<OrderSaveParameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D86630 Offset: 0x2D86731 VA: 0x2D86630
	|-Dictionary<Parameter, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D89DD0 Offset: 0x2D89ED1 VA: 0x2D89DD0
	|-Dictionary<bool, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D8D3F0 Offset: 0x2D8D4F1 VA: 0x2D8D3F0
	|-Dictionary<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D90A10 Offset: 0x2D90B11 VA: 0x2D90A10
	|-Dictionary<char, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D94030 Offset: 0x2D94131 VA: 0x2D94030
	|-Dictionary<DateTime, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D97640 Offset: 0x2D97741 VA: 0x2D97640
	|-Dictionary<double, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D9ACD0 Offset: 0x2D9ADD1 VA: 0x2D9ACD0
	|-Dictionary<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D9E2E0 Offset: 0x2D9E3E1 VA: 0x2D9E2E0
	|-Dictionary<short, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D3C8B0 Offset: 0x2D3C9B1 VA: 0x2D3C8B0
	|-Dictionary<int, CropDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D402A0 Offset: 0x2D403A1 VA: 0x2D402A0
	|-Dictionary<int, EffectDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D43930 Offset: 0x2D43A31 VA: 0x2D43930
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D474A0 Offset: 0x2D475A1 VA: 0x2D474A0
	|-Dictionary<int, MineTypeDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D4AC90 Offset: 0x2D4AD91 VA: 0x2D4AC90
	|-Dictionary<int, MiningDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D4E2B0 Offset: 0x2D4E3B1 VA: 0x2D4E2B0
	|-Dictionary<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D51870 Offset: 0x2D51971 VA: 0x2D51870
	|-Dictionary<int, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D54E30 Offset: 0x2D54F31 VA: 0x2D54E30
	|-Dictionary<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D583F0 Offset: 0x2D584F1 VA: 0x2D583F0
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F5E590 Offset: 0x2F5E691 VA: 0x2F5E590
	|-Dictionary<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F61C80 Offset: 0x2F61D81 VA: 0x2F61C80
	|-Dictionary<int, object>.System.Collections.ICollection.CopyTo
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F655F0 Offset: 0x2F656F1 VA: 0x2F655F0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F68D90 Offset: 0x2F68E91 VA: 0x2F68D90
	|-Dictionary<int, SceneInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F6C430 Offset: 0x2F6C531 VA: 0x2F6C430
	|-Dictionary<int, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F6FB30 Offset: 0x2F6FC31 VA: 0x2F6FB30
	|-Dictionary<int, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F736E0 Offset: 0x2F737E1 VA: 0x2F736E0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F77260 Offset: 0x2F77361 VA: 0x2F77260
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E1E460 Offset: 0x2E1E561 VA: 0x2E1E460
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E21A90 Offset: 0x2E21B91 VA: 0x2E21A90
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E250F0 Offset: 0x2E251F1 VA: 0x2E250F0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E286D0 Offset: 0x2E287D1 VA: 0x2E286D0
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E2F350 Offset: 0x2E2F451 VA: 0x2E2F350
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E32870 Offset: 0x2E32971 VA: 0x2E32870
	|-Dictionary<Int32Enum, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E35F00 Offset: 0x2E36001 VA: 0x2E35F00
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E395B0 Offset: 0x2E396B1 VA: 0x2E395B0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F98140 Offset: 0x2F98241 VA: 0x2F98140
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F9B870 Offset: 0x2F9B971 VA: 0x2F9B870
	|-Dictionary<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F9EF10 Offset: 0x2F9F011 VA: 0x2F9EF10
	|-Dictionary<Memory<object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FA26D0 Offset: 0x2FA27D1 VA: 0x2FA26D0
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FA6530 Offset: 0x2FA6631 VA: 0x2FA6530
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FAA490 Offset: 0x2FAA591 VA: 0x2FAA490
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FADD70 Offset: 0x2FADE71 VA: 0x2FADD70
	|-Dictionary<Nullable<Color32>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FB19B0 Offset: 0x2FB1AB1 VA: 0x2FB19B0
	|-Dictionary<Nullable<Color>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F1C710 Offset: 0x2F1C811 VA: 0x2F1C710
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F20370 Offset: 0x2F20471 VA: 0x2F20370
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F24090 Offset: 0x2F24191 VA: 0x2F24090
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F27940 Offset: 0x2F27A41 VA: 0x2F27940
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F2BCD0 Offset: 0x2F2BDD1 VA: 0x2F2BCD0
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F2FAF0 Offset: 0x2F2FBF1 VA: 0x2F2FAF0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F33460 Offset: 0x2F33561 VA: 0x2F33460
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F370C0 Offset: 0x2F371C1 VA: 0x2F370C0
	|-Dictionary<Nullable<Rect>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2EFFDD0 Offset: 0x2EFFED1 VA: 0x2EFFDD0
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F03740 Offset: 0x2F03841 VA: 0x2F03740
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F07010 Offset: 0x2F07111 VA: 0x2F07010
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F0A880 Offset: 0x2F0A981 VA: 0x2F0A880
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F0E0C0 Offset: 0x2F0E1C1 VA: 0x2F0E0C0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F11CF0 Offset: 0x2F11DF1 VA: 0x2F11CF0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F15430 Offset: 0x2F15531 VA: 0x2F15430
	|-Dictionary<object, BitVector32Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F18DA0 Offset: 0x2F18EA1 VA: 0x2F18DA0
	|-Dictionary<object, EventCheckId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FF5820 Offset: 0x2FF5921 VA: 0x2FF5820
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FF9290 Offset: 0x2FF9391 VA: 0x2FF9290
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FFCA30 Offset: 0x2FFCB31 VA: 0x2FFCA30
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3000130 Offset: 0x3000231 VA: 0x3000130
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3003BB0 Offset: 0x3003CB1 VA: 0x3003BB0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3007390 Offset: 0x3007491 VA: 0x3007390
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x300AE30 Offset: 0x300AF31 VA: 0x300AE30
	|-Dictionary<object, OrderSaveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x300E890 Offset: 0x300E991 VA: 0x300E890
	|-Dictionary<object, OrderSaveParameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DE0140 Offset: 0x2DE0241 VA: 0x2DE0140
	|-Dictionary<object, Parameter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DE3900 Offset: 0x2DE3A01 VA: 0x2DE3900
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DE6FF0 Offset: 0x2DE70F1 VA: 0x2DE6FF0
	|-Dictionary<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DEA6B0 Offset: 0x2DEA7B1 VA: 0x2DEA6B0
	|-Dictionary<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DEDD70 Offset: 0x2DEDE71 VA: 0x2DEDD70
	|-Dictionary<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DF1430 Offset: 0x2DF1531 VA: 0x2DF1430
	|-Dictionary<object, DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DF4AE0 Offset: 0x2DF4BE1 VA: 0x2DF4AE0
	|-Dictionary<object, double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DF81A0 Offset: 0x2DF82A1 VA: 0x2DF81A0
	|-Dictionary<object, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DFB860 Offset: 0x2DFB961 VA: 0x2DFB860
	|-Dictionary<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30BAE20 Offset: 0x30BAF21 VA: 0x30BAE20
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30BE4E0 Offset: 0x30BE5E1 VA: 0x30BE4E0
	|-Dictionary<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30C1BE0 Offset: 0x30C1CE1 VA: 0x30C1BE0
	|-Dictionary<object, Memory<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30C5360 Offset: 0x30C5461 VA: 0x30C5360
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30C8ED0 Offset: 0x30C8FD1 VA: 0x30C8ED0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30CCB30 Offset: 0x30CCC31 VA: 0x30CCB30
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30D03C0 Offset: 0x30D04C1 VA: 0x30D03C0
	|-Dictionary<object, Nullable<Color32>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30D3E00 Offset: 0x30D3F01 VA: 0x30D3E00
	|-Dictionary<object, Nullable<Color>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3012100 Offset: 0x3012201 VA: 0x3012100
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3015B90 Offset: 0x3015C91 VA: 0x3015B90
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30196A0 Offset: 0x30197A1 VA: 0x30196A0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x301CF10 Offset: 0x301D011 VA: 0x301CF10
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3020D70 Offset: 0x3020E71 VA: 0x3020D70
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3024950 Offset: 0x3024A51 VA: 0x3024950
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3028210 Offset: 0x3028311 VA: 0x3028210
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x302BCA0 Offset: 0x302BDA1 VA: 0x302BCA0
	|-Dictionary<object, Nullable<Rect>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FD9280 Offset: 0x2FD9381 VA: 0x2FD9280
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FDCB40 Offset: 0x2FDCC41 VA: 0x2FDCB40
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FE0390 Offset: 0x2FE0491 VA: 0x2FE0390
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FE3BB0 Offset: 0x2FE3CB1 VA: 0x2FE3BB0
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FE73A0 Offset: 0x2FE74A1 VA: 0x2FE73A0
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FEAE00 Offset: 0x2FEAF01 VA: 0x2FEAE00
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FEE600 Offset: 0x2FEE701 VA: 0x2FEE600
	|-Dictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2FF1C00 Offset: 0x2FF1D01 VA: 0x2FF1C00
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DC06B0 Offset: 0x2DC07B1 VA: 0x2DC06B0
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DC3D80 Offset: 0x2DC3E81 VA: 0x2DC3D80
	|-Dictionary<object, sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DC7440 Offset: 0x2DC7541 VA: 0x2DC7440
	|-Dictionary<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DCAB00 Offset: 0x2DCAC01 VA: 0x2DCAB00
	|-Dictionary<object, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DCE1C0 Offset: 0x2DCE2C1 VA: 0x2DCE1C0
	|-Dictionary<object, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DD1880 Offset: 0x2DD1981 VA: 0x2DD1880
	|-Dictionary<object, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DD51F0 Offset: 0x2DD52F1 VA: 0x2DD51F0
	|-Dictionary<object, TransitionTables>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DD8BD0 Offset: 0x2DD8CD1 VA: 0x2DD8BD0
	|-Dictionary<object, Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DDC590 Offset: 0x2DDC691 VA: 0x2DDC590
	|-Dictionary<object, BoundsInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30D75B0 Offset: 0x30D76B1 VA: 0x30D75B0
	|-Dictionary<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30DACB0 Offset: 0x30DADB1 VA: 0x30DACB0
	|-Dictionary<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30DE3C0 Offset: 0x30DE4C1 VA: 0x30DE3C0
	|-Dictionary<object, GradientAlphaKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30E1D00 Offset: 0x30E1E01 VA: 0x30E1D00
	|-Dictionary<object, GradientColorKey>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30E57F0 Offset: 0x30E58F1 VA: 0x30E57F0
	|-Dictionary<object, Keyframe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30E8F90 Offset: 0x30E9091 VA: 0x30E8F90
	|-Dictionary<object, LayerMask>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30ECB30 Offset: 0x30ECC31 VA: 0x30ECB30
	|-Dictionary<object, Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30F0320 Offset: 0x30F0421 VA: 0x30F0320
	|-Dictionary<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x309F140 Offset: 0x309F241 VA: 0x309F140
	|-Dictionary<object, Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30A2820 Offset: 0x30A2921 VA: 0x30A2820
	|-Dictionary<object, RangeInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30A5F10 Offset: 0x30A6011 VA: 0x30A5F10
	|-Dictionary<object, Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30A9610 Offset: 0x30A9711 VA: 0x30A9610
	|-Dictionary<object, RectInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30ACF70 Offset: 0x30AD071 VA: 0x30ACF70
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30B0940 Offset: 0x30B0A41 VA: 0x30B0940
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30B40B0 Offset: 0x30B41B1 VA: 0x30B40B0
	|-Dictionary<object, Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30B7770 Offset: 0x30B7871 VA: 0x30B7770
	|-Dictionary<object, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3083430 Offset: 0x3083531 VA: 0x3083430
	|-Dictionary<object, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3086B60 Offset: 0x3086C61 VA: 0x3086B60
	|-Dictionary<object, Vector3Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x308A280 Offset: 0x308A381 VA: 0x308A280
	|-Dictionary<object, Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x308D990 Offset: 0x308DA91 VA: 0x308D990
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3090F40 Offset: 0x3091041 VA: 0x3090F40
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3094630 Offset: 0x3094731 VA: 0x3094630
	|-Dictionary<sbyte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3098260 Offset: 0x3098361 VA: 0x3098260
	|-Dictionary<float, CurveSample>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x309BA90 Offset: 0x309BB91 VA: 0x309BA90
	|-Dictionary<float, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x319F000 Offset: 0x319F101 VA: 0x319F000
	|-Dictionary<ushort, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31A2520 Offset: 0x31A2621 VA: 0x31A2520
	|-Dictionary<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31A5AE0 Offset: 0x31A5BE1 VA: 0x31A5AE0
	|-Dictionary<uint, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31A91A0 Offset: 0x31A92A1 VA: 0x31A91A0
	|-Dictionary<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31AC7C0 Offset: 0x31AC8C1 VA: 0x31AC7C0
	|-Dictionary<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31AFD70 Offset: 0x31AFE71 VA: 0x31AFD70
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31B3810 Offset: 0x31B3911 VA: 0x31B3810
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x31B7350 Offset: 0x31B7451 VA: 0x31B7350
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x302F620 Offset: 0x302F721 VA: 0x302F620
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3032D60 Offset: 0x3032E61 VA: 0x3032D60
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3036440 Offset: 0x3036541 VA: 0x3036440
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3039EC0 Offset: 0x3039FC1 VA: 0x3039EC0
	|-Dictionary<Bounds, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x303D9F0 Offset: 0x303DAF1 VA: 0x303D9F0
	|-Dictionary<BoundsInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30411B0 Offset: 0x30412B1 VA: 0x30411B0
	|-Dictionary<Color, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3044860 Offset: 0x3044961 VA: 0x3044860
	|-Dictionary<Color32, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3047E80 Offset: 0x3047F81 VA: 0x3047E80
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3066A10 Offset: 0x3066B11 VA: 0x3066A10
	|-Dictionary<GradientAlphaKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x306A490 Offset: 0x306A591 VA: 0x306A490
	|-Dictionary<GradientColorKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x306E1B0 Offset: 0x306E2B1 VA: 0x306E1B0
	|-Dictionary<Keyframe, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3071920 Offset: 0x3071A21 VA: 0x3071920
	|-Dictionary<LayerMask, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30757A0 Offset: 0x30758A1 VA: 0x30757A0
	|-Dictionary<Matrix4x4, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3078FE0 Offset: 0x30790E1 VA: 0x3078FE0
	|-Dictionary<IntVec3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x307C720 Offset: 0x307C821 VA: 0x307C720
	|-Dictionary<Quaternion, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x307FD90 Offset: 0x307FE91 VA: 0x307FD90
	|-Dictionary<RangeInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x304B590 Offset: 0x304B691 VA: 0x304B590
	|-Dictionary<Rect, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x304EC70 Offset: 0x304ED71 VA: 0x304EC70
	|-Dictionary<RectInt, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3052210 Offset: 0x3052311 VA: 0x3052210
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x30558F0 Offset: 0x30559F1 VA: 0x30558F0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3058F70 Offset: 0x3059071 VA: 0x3058F70
	|-Dictionary<Vector2, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x305C590 Offset: 0x305C691 VA: 0x305C590
	|-Dictionary<Vector2Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x305FC50 Offset: 0x305FD51 VA: 0x305FC50
	|-Dictionary<Vector3, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3063360 Offset: 0x3063461 VA: 0x3063360
	|-Dictionary<Vector3Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E3CD80 Offset: 0x2E3CE81 VA: 0x2E3CD80
	|-Dictionary<Vector4, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18CA0 Offset: 0x2A18DA1 VA: 0x2A18CA0
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A1C300 Offset: 0x2A1C401 VA: 0x2A1C300
	|-Dictionary<BitVector32Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E2C2E0 Offset: 0x2E2C3E1 VA: 0x2E2C2E0
	|-Dictionary<Season, Texture>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7B4C0 Offset: 0x2F7B5C1 VA: 0x2F7B4C0
	|-Dictionary<EventCheckId, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7F4F0 Offset: 0x2F7F5F1 VA: 0x2F7F4F0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F830C0 Offset: 0x2F831C1 VA: 0x2F830C0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F86820 Offset: 0x2F86921 VA: 0x2F86820
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F89EC0 Offset: 0x2F89FC1 VA: 0x2F89EC0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F8DBA0 Offset: 0x2F8DCA1 VA: 0x2F8DBA0
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F91340 Offset: 0x2F91441 VA: 0x2F91340
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F95040 Offset: 0x2F95141 VA: 0x2F95040
	|-Dictionary<OrderSaveData, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D82F60 Offset: 0x2D83061 VA: 0x2D82F60
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D86CB0 Offset: 0x2D86DB1 VA: 0x2D86CB0
	|-Dictionary<Parameter, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D8A3C0 Offset: 0x2D8A4C1 VA: 0x2D8A3C0
	|-Dictionary<bool, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D8D9E0 Offset: 0x2D8DAE1 VA: 0x2D8D9E0
	|-Dictionary<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D91000 Offset: 0x2D91101 VA: 0x2D91000
	|-Dictionary<char, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D94620 Offset: 0x2D94721 VA: 0x2D94620
	|-Dictionary<DateTime, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D97C30 Offset: 0x2D97D31 VA: 0x2D97C30
	|-Dictionary<double, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D9B2B0 Offset: 0x2D9B3B1 VA: 0x2D9B2B0
	|-Dictionary<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D9E8D0 Offset: 0x2D9E9D1 VA: 0x2D9E8D0
	|-Dictionary<short, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D3CFB0 Offset: 0x2D3D0B1 VA: 0x2D3CFB0
	|-Dictionary<int, CropDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D40930 Offset: 0x2D40A31 VA: 0x2D40930
	|-Dictionary<int, EffectDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D43F80 Offset: 0x2D44081 VA: 0x2D43F80
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D47B80 Offset: 0x2D47C81 VA: 0x2D47B80
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D4B2F0 Offset: 0x2D4B3F1 VA: 0x2D4B2F0
	|-Dictionary<int, MiningDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D4E900 Offset: 0x2D4EA01 VA: 0x2D4E900
	|-Dictionary<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D51EC0 Offset: 0x2D51FC1 VA: 0x2D51EC0
	|-Dictionary<int, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D55480 Offset: 0x2D55581 VA: 0x2D55480
	|-Dictionary<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D58A40 Offset: 0x2D58B41 VA: 0x2D58A40
	|-Dictionary<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F5EBF0 Offset: 0x2F5ECF1 VA: 0x2F5EBF0
	|-Dictionary<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F62270 Offset: 0x2F62371 VA: 0x2F62270
	|-Dictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F65CA0 Offset: 0x2F65DA1 VA: 0x2F65CA0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F693F0 Offset: 0x2F694F1 VA: 0x2F693F0
	|-Dictionary<int, SceneInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F6CAA0 Offset: 0x2F6CBA1 VA: 0x2F6CAA0
	|-Dictionary<int, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F701A0 Offset: 0x2F702A1 VA: 0x2F701A0
	|-Dictionary<int, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F73DD0 Offset: 0x2F73ED1 VA: 0x2F73DD0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F77910 Offset: 0x2F77A11 VA: 0x2F77910
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E1EAD0 Offset: 0x2E1EBD1 VA: 0x2E1EAD0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E220E0 Offset: 0x2E221E1 VA: 0x2E220E0
	|-Dictionary<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E25760 Offset: 0x2E25861 VA: 0x2E25760
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E28D20 Offset: 0x2E28E21 VA: 0x2E28D20
	|-Dictionary<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E2F940 Offset: 0x2E2FA41 VA: 0x2E2F940
	|-Dictionary<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E32EC0 Offset: 0x2E32FC1 VA: 0x2E32EC0
	|-Dictionary<Int32Enum, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E36560 Offset: 0x2E36661 VA: 0x2E36560
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E39C20 Offset: 0x2E39D21 VA: 0x2E39C20
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F987B0 Offset: 0x2F988B1 VA: 0x2F987B0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F9BE60 Offset: 0x2F9BF61 VA: 0x2F9BE60
	|-Dictionary<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F9F4F0 Offset: 0x2F9F5F1 VA: 0x2F9F4F0
	|-Dictionary<Memory<object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FA2CC0 Offset: 0x2FA2DC1 VA: 0x2FA2CC0
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FA6B80 Offset: 0x2FA6C81 VA: 0x2FA6B80
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FAAAE0 Offset: 0x2FAABE1 VA: 0x2FAAAE0
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FAE360 Offset: 0x2FAE461 VA: 0x2FAE360
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FB1FE0 Offset: 0x2FB20E1 VA: 0x2FB1FE0
	|-Dictionary<Nullable<Color>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F1CD10 Offset: 0x2F1CE11 VA: 0x2F1CD10
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F209A0 Offset: 0x2F20AA1 VA: 0x2F209A0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F246D0 Offset: 0x2F247D1 VA: 0x2F246D0
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F27F30 Offset: 0x2F28031 VA: 0x2F27F30
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F2C360 Offset: 0x2F2C461 VA: 0x2F2C360
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F30120 Offset: 0x2F30221 VA: 0x2F30120
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F33A60 Offset: 0x2F33B61 VA: 0x2F33A60
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F376F0 Offset: 0x2F377F1 VA: 0x2F376F0
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F00400 Offset: 0x2F00501 VA: 0x2F00400
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F03D40 Offset: 0x2F03E41 VA: 0x2F03D40
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F07610 Offset: 0x2F07711 VA: 0x2F07610
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F0AE60 Offset: 0x2F0AF61 VA: 0x2F0AE60
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F0E6A0 Offset: 0x2F0E7A1 VA: 0x2F0E6A0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F12320 Offset: 0x2F12421 VA: 0x2F12320
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F15A10 Offset: 0x2F15B11 VA: 0x2F15A10
	|-Dictionary<object, BitVector32Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F193B0 Offset: 0x2F194B1 VA: 0x2F193B0
	|-Dictionary<object, EventCheckId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FF5E80 Offset: 0x2FF5F81 VA: 0x2FF5E80
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FF98B0 Offset: 0x2FF99B1 VA: 0x2FF98B0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FFD020 Offset: 0x2FFD121 VA: 0x2FFD020
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3000710 Offset: 0x3000811 VA: 0x3000710
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30041F0 Offset: 0x30042F1 VA: 0x30041F0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3007980 Offset: 0x3007A81 VA: 0x3007980
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x300B470 Offset: 0x300B571 VA: 0x300B470
	|-Dictionary<object, OrderSaveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x300EEC0 Offset: 0x300EFC1 VA: 0x300EEC0
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DE07B0 Offset: 0x2DE08B1 VA: 0x2DE07B0
	|-Dictionary<object, Parameter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DE3EE0 Offset: 0x2DE3FE1 VA: 0x2DE3EE0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DE75D0 Offset: 0x2DE76D1 VA: 0x2DE75D0
	|-Dictionary<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DEAC90 Offset: 0x2DEAD91 VA: 0x2DEAC90
	|-Dictionary<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DEE350 Offset: 0x2DEE451 VA: 0x2DEE350
	|-Dictionary<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DF1A00 Offset: 0x2DF1B01 VA: 0x2DF1A00
	|-Dictionary<object, DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DF50C0 Offset: 0x2DF51C1 VA: 0x2DF50C0
	|-Dictionary<object, double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DF8780 Offset: 0x2DF8881 VA: 0x2DF8780
	|-Dictionary<object, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DFBE40 Offset: 0x2DFBF41 VA: 0x2DFBE40
	|-Dictionary<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30BB400 Offset: 0x30BB501 VA: 0x30BB400
	|-Dictionary<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30BEAB0 Offset: 0x30BEBB1 VA: 0x30BEAB0
	|-Dictionary<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30C21C0 Offset: 0x30C22C1 VA: 0x30C21C0
	|-Dictionary<object, Memory<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30C5930 Offset: 0x30C5A31 VA: 0x30C5930
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30C9510 Offset: 0x30C9611 VA: 0x30C9510
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30CD170 Offset: 0x30CD271 VA: 0x30CD170
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30D0990 Offset: 0x30D0A91 VA: 0x30D0990
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30D4420 Offset: 0x30D4521 VA: 0x30D4420
	|-Dictionary<object, Nullable<Color>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30126F0 Offset: 0x30127F1 VA: 0x30126F0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30161A0 Offset: 0x30162A1 VA: 0x30161A0
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3019CD0 Offset: 0x3019DD1 VA: 0x3019CD0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x301D4E0 Offset: 0x301D5E1 VA: 0x301D4E0
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30213F0 Offset: 0x30214F1 VA: 0x30213F0
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3024F70 Offset: 0x3025071 VA: 0x3024F70
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3028800 Offset: 0x3028901 VA: 0x3028800
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x302C2C0 Offset: 0x302C3C1 VA: 0x302C2C0
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FD98A0 Offset: 0x2FD99A1 VA: 0x2FD98A0
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FDD130 Offset: 0x2FDD231 VA: 0x2FDD130
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FE0980 Offset: 0x2FE0A81 VA: 0x2FE0980
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FE4190 Offset: 0x2FE4291 VA: 0x2FE4190
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FE7980 Offset: 0x2FE7A81 VA: 0x2FE7980
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FEB420 Offset: 0x2FEB521 VA: 0x2FEB420
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FEEB60 Offset: 0x2FEEC61 VA: 0x2FEEB60
	|-Dictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2FF21E0 Offset: 0x2FF22E1 VA: 0x2FF21E0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DC0C90 Offset: 0x2DC0D91 VA: 0x2DC0C90
	|-Dictionary<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DC4360 Offset: 0x2DC4461 VA: 0x2DC4360
	|-Dictionary<object, sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DC7A20 Offset: 0x2DC7B21 VA: 0x2DC7A20
	|-Dictionary<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DCB0E0 Offset: 0x2DCB1E1 VA: 0x2DCB0E0
	|-Dictionary<object, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DCE7A0 Offset: 0x2DCE8A1 VA: 0x2DCE7A0
	|-Dictionary<object, uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DD1E50 Offset: 0x2DD1F51 VA: 0x2DD1E50
	|-Dictionary<object, ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DD5820 Offset: 0x2DD5921 VA: 0x2DD5820
	|-Dictionary<object, TransitionTables>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DD91E0 Offset: 0x2DD92E1 VA: 0x2DD91E0
	|-Dictionary<object, Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DDCBA0 Offset: 0x2DDCCA1 VA: 0x2DDCBA0
	|-Dictionary<object, BoundsInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30D7B90 Offset: 0x30D7C91 VA: 0x30D7B90
	|-Dictionary<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30DB2A0 Offset: 0x30DB3A1 VA: 0x30DB2A0
	|-Dictionary<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30DE9A0 Offset: 0x30DEAA1 VA: 0x30DE9A0
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30E2320 Offset: 0x30E2421 VA: 0x30E2320
	|-Dictionary<object, GradientColorKey>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30E5E30 Offset: 0x30E5F31 VA: 0x30E5E30
	|-Dictionary<object, Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30E9570 Offset: 0x30E9671 VA: 0x30E9570
	|-Dictionary<object, LayerMask>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30ED190 Offset: 0x30ED291 VA: 0x30ED190
	|-Dictionary<object, Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30F0900 Offset: 0x30F0A01 VA: 0x30F0900
	|-Dictionary<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x309F730 Offset: 0x309F831 VA: 0x309F730
	|-Dictionary<object, Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30A2DF0 Offset: 0x30A2EF1 VA: 0x30A2DF0
	|-Dictionary<object, RangeInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30A6500 Offset: 0x30A6601 VA: 0x30A6500
	|-Dictionary<object, Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30A9BF0 Offset: 0x30A9CF1 VA: 0x30A9BF0
	|-Dictionary<object, RectInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30AD580 Offset: 0x30AD681 VA: 0x30AD580
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30B0F50 Offset: 0x30B1051 VA: 0x30B0F50
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30B4690 Offset: 0x30B4791 VA: 0x30B4690
	|-Dictionary<object, Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30B7D40 Offset: 0x30B7E41 VA: 0x30B7D40
	|-Dictionary<object, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3083A20 Offset: 0x3083B21 VA: 0x3083A20
	|-Dictionary<object, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3087150 Offset: 0x3087251 VA: 0x3087150
	|-Dictionary<object, Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x308A870 Offset: 0x308A971 VA: 0x308A870
	|-Dictionary<object, Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x308DF70 Offset: 0x308E071 VA: 0x308DF70
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30915A0 Offset: 0x30916A1 VA: 0x30915A0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3094C20 Offset: 0x3094D21 VA: 0x3094C20
	|-Dictionary<sbyte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3098960 Offset: 0x3098A61 VA: 0x3098960
	|-Dictionary<float, CurveSample>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x309C080 Offset: 0x309C181 VA: 0x309C080
	|-Dictionary<float, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319F5F0 Offset: 0x319F6F1 VA: 0x319F5F0
	|-Dictionary<ushort, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31A2B70 Offset: 0x31A2C71 VA: 0x31A2B70
	|-Dictionary<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31A6130 Offset: 0x31A6231 VA: 0x31A6130
	|-Dictionary<uint, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31A9790 Offset: 0x31A9891 VA: 0x31A9790
	|-Dictionary<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31ACDB0 Offset: 0x31ACEB1 VA: 0x31ACDB0
	|-Dictionary<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31B03E0 Offset: 0x31B04E1 VA: 0x31B03E0
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31B3EE0 Offset: 0x31B3FE1 VA: 0x31B3EE0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31B7A00 Offset: 0x31B7B01 VA: 0x31B7A00
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x302FCD0 Offset: 0x302FDD1 VA: 0x302FCD0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30333D0 Offset: 0x30334D1 VA: 0x30333D0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3036A30 Offset: 0x3036B31 VA: 0x3036A30
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x303A4F0 Offset: 0x303A5F1 VA: 0x303A4F0
	|-Dictionary<Bounds, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x303E020 Offset: 0x303E121 VA: 0x303E020
	|-Dictionary<BoundsInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30417B0 Offset: 0x30418B1 VA: 0x30417B0
	|-Dictionary<Color, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3044E50 Offset: 0x3044F51 VA: 0x3044E50
	|-Dictionary<Color32, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3048470 Offset: 0x3048571 VA: 0x3048470
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3067000 Offset: 0x3067101 VA: 0x3067000
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x306AAC0 Offset: 0x306ABC1 VA: 0x306AAC0
	|-Dictionary<GradientColorKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x306E800 Offset: 0x306E901 VA: 0x306E800
	|-Dictionary<Keyframe, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3071F10 Offset: 0x3072011 VA: 0x3071F10
	|-Dictionary<LayerMask, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3075E20 Offset: 0x3075F21 VA: 0x3075E20
	|-Dictionary<Matrix4x4, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x30795E0 Offset: 0x30796E1 VA: 0x30795E0
	|-Dictionary<IntVec3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x307CD20 Offset: 0x307CE21 VA: 0x307CD20
	|-Dictionary<Quaternion, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3080380 Offset: 0x3080481 VA: 0x3080380
	|-Dictionary<RangeInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x304BB90 Offset: 0x304BC91 VA: 0x304BB90
	|-Dictionary<Rect, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x304F250 Offset: 0x304F351 VA: 0x304F250
	|-Dictionary<RectInt, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3052880 Offset: 0x3052981 VA: 0x3052880
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3055EE0 Offset: 0x3055FE1 VA: 0x3055EE0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3059560 Offset: 0x3059661 VA: 0x3059560
	|-Dictionary<Vector2, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x305CB80 Offset: 0x305CC81 VA: 0x305CB80
	|-Dictionary<Vector2Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3060250 Offset: 0x3060351 VA: 0x3060250
	|-Dictionary<Vector3, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3063960 Offset: 0x3063A61 VA: 0x3063960
	|-Dictionary<Vector3Int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E3D380 Offset: 0x2E3D481 VA: 0x2E3D380
	|-Dictionary<Vector4, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18D30 Offset: 0x2A18E31 VA: 0x2A18D30
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2A1C390 Offset: 0x2A1C491 VA: 0x2A1C390
	|-Dictionary<BitVector32Int, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E2C360 Offset: 0x2E2C461 VA: 0x2E2C360
	|-Dictionary<Season, Texture>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F7B560 Offset: 0x2F7B661 VA: 0x2F7B560
	|-Dictionary<EventCheckId, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F7F5A0 Offset: 0x2F7F6A1 VA: 0x2F7F5A0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F83160 Offset: 0x2F83261 VA: 0x2F83160
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F868B0 Offset: 0x2F869B1 VA: 0x2F868B0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F89F50 Offset: 0x2F8A051 VA: 0x2F89F50
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F8DC40 Offset: 0x2F8DD41 VA: 0x2F8DC40
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F913D0 Offset: 0x2F914D1 VA: 0x2F913D0
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F950E0 Offset: 0x2F951E1 VA: 0x2F950E0
	|-Dictionary<OrderSaveData, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D83000 Offset: 0x2D83101 VA: 0x2D83000
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D86D60 Offset: 0x2D86E61 VA: 0x2D86D60
	|-Dictionary<Parameter, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D8A450 Offset: 0x2D8A551 VA: 0x2D8A450
	|-Dictionary<bool, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D8DA70 Offset: 0x2D8DB71 VA: 0x2D8DA70
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D91090 Offset: 0x2D91191 VA: 0x2D91090
	|-Dictionary<char, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D946B0 Offset: 0x2D947B1 VA: 0x2D946B0
	|-Dictionary<DateTime, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D97CC0 Offset: 0x2D97DC1 VA: 0x2D97CC0
	|-Dictionary<double, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D9B340 Offset: 0x2D9B441 VA: 0x2D9B340
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D9E960 Offset: 0x2D9EA61 VA: 0x2D9E960
	|-Dictionary<short, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D3D050 Offset: 0x2D3D151 VA: 0x2D3D050
	|-Dictionary<int, CropDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D409C0 Offset: 0x2D40AC1 VA: 0x2D409C0
	|-Dictionary<int, EffectDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D44000 Offset: 0x2D44101 VA: 0x2D44000
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D47C30 Offset: 0x2D47D31 VA: 0x2D47C30
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D4B380 Offset: 0x2D4B481 VA: 0x2D4B380
	|-Dictionary<int, MiningDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D4E980 Offset: 0x2D4EA81 VA: 0x2D4E980
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D51F40 Offset: 0x2D52041 VA: 0x2D51F40
	|-Dictionary<int, char>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D55500 Offset: 0x2D55601 VA: 0x2D55500
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2D58AC0 Offset: 0x2D58BC1 VA: 0x2D58AC0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F5EC80 Offset: 0x2F5ED81 VA: 0x2F5EC80
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F62300 Offset: 0x2F62401 VA: 0x2F62300
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F65D50 Offset: 0x2F65E51 VA: 0x2F65D50
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F69480 Offset: 0x2F69581 VA: 0x2F69480
	|-Dictionary<int, SceneInstance>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F6CB20 Offset: 0x2F6CC21 VA: 0x2F6CB20
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F70230 Offset: 0x2F70331 VA: 0x2F70230
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F73E90 Offset: 0x2F73F91 VA: 0x2F73E90
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F779C0 Offset: 0x2F77AC1 VA: 0x2F779C0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E1EB60 Offset: 0x2E1EC61 VA: 0x2E1EB60
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E22160 Offset: 0x2E22261 VA: 0x2E22160
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E257E0 Offset: 0x2E258E1 VA: 0x2E257E0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E28DA0 Offset: 0x2E28EA1 VA: 0x2E28DA0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E2F9D0 Offset: 0x2E2FAD1 VA: 0x2E2F9D0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E32F40 Offset: 0x2E33041 VA: 0x2E32F40
	|-Dictionary<Int32Enum, float>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E365F0 Offset: 0x2E366F1 VA: 0x2E365F0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E39CA0 Offset: 0x2E39DA1 VA: 0x2E39CA0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F98840 Offset: 0x2F98941 VA: 0x2F98840
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F9BEF0 Offset: 0x2F9BFF1 VA: 0x2F9BEF0
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F9F580 Offset: 0x2F9F681 VA: 0x2F9F580
	|-Dictionary<Memory<object>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FA2D50 Offset: 0x2FA2E51 VA: 0x2FA2D50
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FA6C20 Offset: 0x2FA6D21 VA: 0x2FA6C20
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FAAB80 Offset: 0x2FAAC81 VA: 0x2FAAB80
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FAE3F0 Offset: 0x2FAE4F1 VA: 0x2FAE3F0
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FB2080 Offset: 0x2FB2181 VA: 0x2FB2080
	|-Dictionary<Nullable<Color>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F1CDA0 Offset: 0x2F1CEA1 VA: 0x2F1CDA0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F20A40 Offset: 0x2F20B41 VA: 0x2F20A40
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F24770 Offset: 0x2F24871 VA: 0x2F24770
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F27FC0 Offset: 0x2F280C1 VA: 0x2F27FC0
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F2C420 Offset: 0x2F2C521 VA: 0x2F2C420
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F301C0 Offset: 0x2F302C1 VA: 0x2F301C0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F33AF0 Offset: 0x2F33BF1 VA: 0x2F33AF0
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F37790 Offset: 0x2F37891 VA: 0x2F37790
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F004A0 Offset: 0x2F005A1 VA: 0x2F004A0
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F03DD0 Offset: 0x2F03ED1 VA: 0x2F03DD0
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F076A0 Offset: 0x2F077A1 VA: 0x2F076A0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F0AEF0 Offset: 0x2F0AFF1 VA: 0x2F0AEF0
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F0E730 Offset: 0x2F0E831 VA: 0x2F0E730
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F123C0 Offset: 0x2F124C1 VA: 0x2F123C0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F15AA0 Offset: 0x2F15BA1 VA: 0x2F15AA0
	|-Dictionary<object, BitVector32Int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2F19450 Offset: 0x2F19551 VA: 0x2F19450
	|-Dictionary<object, EventCheckId>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FF5F30 Offset: 0x2FF6031 VA: 0x2FF5F30
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FF9950 Offset: 0x2FF9A51 VA: 0x2FF9950
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FFD0B0 Offset: 0x2FFD1B1 VA: 0x2FFD0B0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30007A0 Offset: 0x30008A1 VA: 0x30007A0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3004290 Offset: 0x3004391 VA: 0x3004290
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3007A10 Offset: 0x3007B11 VA: 0x3007A10
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x300B510 Offset: 0x300B611 VA: 0x300B510
	|-Dictionary<object, OrderSaveData>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x300EF60 Offset: 0x300F061 VA: 0x300EF60
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DE0860 Offset: 0x2DE0961 VA: 0x2DE0860
	|-Dictionary<object, Parameter>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DE3F70 Offset: 0x2DE4071 VA: 0x2DE3F70
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DE7660 Offset: 0x2DE7761 VA: 0x2DE7660
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DEAD20 Offset: 0x2DEAE21 VA: 0x2DEAD20
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DEE3E0 Offset: 0x2DEE4E1 VA: 0x2DEE3E0
	|-Dictionary<object, char>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DF1A90 Offset: 0x2DF1B91 VA: 0x2DF1A90
	|-Dictionary<object, DateTime>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DF5150 Offset: 0x2DF5251 VA: 0x2DF5150
	|-Dictionary<object, double>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DF8810 Offset: 0x2DF8911 VA: 0x2DF8810
	|-Dictionary<object, short>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DFBED0 Offset: 0x2DFBFD1 VA: 0x2DFBED0
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30BB490 Offset: 0x30BB591 VA: 0x30BB490
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30BEB40 Offset: 0x30BEC41 VA: 0x30BEB40
	|-Dictionary<object, long>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30C2250 Offset: 0x30C2351 VA: 0x30C2250
	|-Dictionary<object, Memory<object>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30C59C0 Offset: 0x30C5AC1 VA: 0x30C59C0
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30C95B0 Offset: 0x30C96B1 VA: 0x30C95B0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30CD210 Offset: 0x30CD311 VA: 0x30CD210
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30D0A20 Offset: 0x30D0B21 VA: 0x30D0A20
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30D44C0 Offset: 0x30D45C1 VA: 0x30D44C0
	|-Dictionary<object, Nullable<Color>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3012780 Offset: 0x3012881 VA: 0x3012780
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3016240 Offset: 0x3016341 VA: 0x3016240
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3019D70 Offset: 0x3019E71 VA: 0x3019D70
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x301D570 Offset: 0x301D671 VA: 0x301D570
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30214B0 Offset: 0x30215B1 VA: 0x30214B0
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3025010 Offset: 0x3025111 VA: 0x3025010
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3028890 Offset: 0x3028991 VA: 0x3028890
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x302C360 Offset: 0x302C461 VA: 0x302C360
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FD9940 Offset: 0x2FD9A41 VA: 0x2FD9940
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FDD1C0 Offset: 0x2FDD2C1 VA: 0x2FDD1C0
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FE0A10 Offset: 0x2FE0B11 VA: 0x2FE0A10
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FE4220 Offset: 0x2FE4321 VA: 0x2FE4220
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FE7A10 Offset: 0x2FE7B11 VA: 0x2FE7A10
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FEB4C0 Offset: 0x2FEB5C1 VA: 0x2FEB4C0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FEEBF0 Offset: 0x2FEECF1 VA: 0x2FEEBF0
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2FF2270 Offset: 0x2FF2371 VA: 0x2FF2270
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DC0D20 Offset: 0x2DC0E21 VA: 0x2DC0D20
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DC43F0 Offset: 0x2DC44F1 VA: 0x2DC43F0
	|-Dictionary<object, sbyte>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DC7AB0 Offset: 0x2DC7BB1 VA: 0x2DC7AB0
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DCB170 Offset: 0x2DCB271 VA: 0x2DCB170
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DCE830 Offset: 0x2DCE931 VA: 0x2DCE830
	|-Dictionary<object, uint>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DD1EE0 Offset: 0x2DD1FE1 VA: 0x2DD1EE0
	|-Dictionary<object, ulong>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DD58C0 Offset: 0x2DD59C1 VA: 0x2DD58C0
	|-Dictionary<object, TransitionTables>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DD9280 Offset: 0x2DD9381 VA: 0x2DD9280
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DDCC40 Offset: 0x2DDCD41 VA: 0x2DDCC40
	|-Dictionary<object, BoundsInt>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30D7C20 Offset: 0x30D7D21 VA: 0x30D7C20
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30DB330 Offset: 0x30DB431 VA: 0x30DB330
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30DEA30 Offset: 0x30DEB31 VA: 0x30DEA30
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30E23C0 Offset: 0x30E24C1 VA: 0x30E23C0
	|-Dictionary<object, GradientColorKey>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30E5ED0 Offset: 0x30E5FD1 VA: 0x30E5ED0
	|-Dictionary<object, Keyframe>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30E9600 Offset: 0x30E9701 VA: 0x30E9600
	|-Dictionary<object, LayerMask>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30ED240 Offset: 0x30ED341 VA: 0x30ED240
	|-Dictionary<object, Matrix4x4>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30F0990 Offset: 0x30F0A91 VA: 0x30F0990
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x309F7C0 Offset: 0x309F8C1 VA: 0x309F7C0
	|-Dictionary<object, Quaternion>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30A2E80 Offset: 0x30A2F81 VA: 0x30A2E80
	|-Dictionary<object, RangeInt>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30A6590 Offset: 0x30A6691 VA: 0x30A6590
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30A9C80 Offset: 0x30A9D81 VA: 0x30A9C80
	|-Dictionary<object, RectInt>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30AD620 Offset: 0x30AD721 VA: 0x30AD620
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30B0FF0 Offset: 0x30B10F1 VA: 0x30B0FF0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30B4720 Offset: 0x30B4821 VA: 0x30B4720
	|-Dictionary<object, Vector2>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30B7DD0 Offset: 0x30B7ED1 VA: 0x30B7DD0
	|-Dictionary<object, Vector2Int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3083AB0 Offset: 0x3083BB1 VA: 0x3083AB0
	|-Dictionary<object, Vector3>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30871E0 Offset: 0x30872E1 VA: 0x30871E0
	|-Dictionary<object, Vector3Int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x308A900 Offset: 0x308AA01 VA: 0x308A900
	|-Dictionary<object, Vector4>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x308E000 Offset: 0x308E101 VA: 0x308E000
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3091630 Offset: 0x3091731 VA: 0x3091630
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3094CB0 Offset: 0x3094DB1 VA: 0x3094CB0
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3098A10 Offset: 0x3098B11 VA: 0x3098A10
	|-Dictionary<float, CurveSample>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x309C110 Offset: 0x309C211 VA: 0x309C110
	|-Dictionary<float, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x319F680 Offset: 0x319F781 VA: 0x319F680
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31A2BF0 Offset: 0x31A2CF1 VA: 0x31A2BF0
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31A61B0 Offset: 0x31A62B1 VA: 0x31A61B0
	|-Dictionary<uint, Int32Enum>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31A9820 Offset: 0x31A9921 VA: 0x31A9820
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31ACE40 Offset: 0x31ACF41 VA: 0x31ACE40
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31B0460 Offset: 0x31B0561 VA: 0x31B0460
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31B3F80 Offset: 0x31B4081 VA: 0x31B3F80
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x31B7AB0 Offset: 0x31B7BB1 VA: 0x31B7AB0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x302FD60 Offset: 0x302FE61 VA: 0x302FD60
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3033450 Offset: 0x3033551 VA: 0x3033450
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3036AC0 Offset: 0x3036BC1 VA: 0x3036AC0
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x303A590 Offset: 0x303A691 VA: 0x303A590
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x303E0C0 Offset: 0x303E1C1 VA: 0x303E0C0
	|-Dictionary<BoundsInt, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3041840 Offset: 0x3041941 VA: 0x3041840
	|-Dictionary<Color, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3044EE0 Offset: 0x3044FE1 VA: 0x3044EE0
	|-Dictionary<Color32, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3048500 Offset: 0x3048601 VA: 0x3048500
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3067090 Offset: 0x3067191 VA: 0x3067090
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x306AB60 Offset: 0x306AC61 VA: 0x306AB60
	|-Dictionary<GradientColorKey, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x306E8A0 Offset: 0x306E9A1 VA: 0x306E8A0
	|-Dictionary<Keyframe, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3071FA0 Offset: 0x30720A1 VA: 0x3071FA0
	|-Dictionary<LayerMask, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3075ED0 Offset: 0x3075FD1 VA: 0x3075ED0
	|-Dictionary<Matrix4x4, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3079670 Offset: 0x3079771 VA: 0x3079670
	|-Dictionary<IntVec3, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x307CDB0 Offset: 0x307CEB1 VA: 0x307CDB0
	|-Dictionary<Quaternion, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3080410 Offset: 0x3080511 VA: 0x3080410
	|-Dictionary<RangeInt, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x304BC20 Offset: 0x304BD21 VA: 0x304BC20
	|-Dictionary<Rect, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x304F2E0 Offset: 0x304F3E1 VA: 0x304F2E0
	|-Dictionary<RectInt, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3052900 Offset: 0x3052A01 VA: 0x3052900
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3055F70 Offset: 0x3056071 VA: 0x3055F70
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30595F0 Offset: 0x30596F1 VA: 0x30595F0
	|-Dictionary<Vector2, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x305CC10 Offset: 0x305CD11 VA: 0x305CC10
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30602E0 Offset: 0x30603E1 VA: 0x30602E0
	|-Dictionary<Vector3, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x30639F0 Offset: 0x3063AF1 VA: 0x30639F0
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2E3D410 Offset: 0x2E3D511 VA: 0x2E3D410
	|-Dictionary<Vector4, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18D60 Offset: 0x2A18E61 VA: 0x2A18D60
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2A1C3C0 Offset: 0x2A1C4C1 VA: 0x2A1C3C0
	|-Dictionary<BitVector32Int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E2C390 Offset: 0x2E2C491 VA: 0x2E2C390
	|-Dictionary<Season, Texture>.System.Collections.IDictionary.get_Item
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F7B590 Offset: 0x2F7B691 VA: 0x2F7B590
	|-Dictionary<EventCheckId, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F7F5D0 Offset: 0x2F7F6D1 VA: 0x2F7F5D0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F83190 Offset: 0x2F83291 VA: 0x2F83190
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F868E0 Offset: 0x2F869E1 VA: 0x2F868E0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F89F80 Offset: 0x2F8A081 VA: 0x2F89F80
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F8DC70 Offset: 0x2F8DD71 VA: 0x2F8DC70
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F91400 Offset: 0x2F91501 VA: 0x2F91400
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F95110 Offset: 0x2F95211 VA: 0x2F95110
	|-Dictionary<OrderSaveData, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D83030 Offset: 0x2D83131 VA: 0x2D83030
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D86D90 Offset: 0x2D86E91 VA: 0x2D86D90
	|-Dictionary<Parameter, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D8A480 Offset: 0x2D8A581 VA: 0x2D8A480
	|-Dictionary<bool, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D8DAA0 Offset: 0x2D8DBA1 VA: 0x2D8DAA0
	|-Dictionary<byte, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D910C0 Offset: 0x2D911C1 VA: 0x2D910C0
	|-Dictionary<char, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D946E0 Offset: 0x2D947E1 VA: 0x2D946E0
	|-Dictionary<DateTime, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D97CF0 Offset: 0x2D97DF1 VA: 0x2D97CF0
	|-Dictionary<double, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D9B370 Offset: 0x2D9B471 VA: 0x2D9B370
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D9E990 Offset: 0x2D9EA91 VA: 0x2D9E990
	|-Dictionary<short, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D3D080 Offset: 0x2D3D181 VA: 0x2D3D080
	|-Dictionary<int, CropDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D409F0 Offset: 0x2D40AF1 VA: 0x2D409F0
	|-Dictionary<int, EffectDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D44030 Offset: 0x2D44131 VA: 0x2D44030
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D47C60 Offset: 0x2D47D61 VA: 0x2D47C60
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D4B3B0 Offset: 0x2D4B4B1 VA: 0x2D4B3B0
	|-Dictionary<int, MiningDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D4E9B0 Offset: 0x2D4EAB1 VA: 0x2D4E9B0
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D51F70 Offset: 0x2D52071 VA: 0x2D51F70
	|-Dictionary<int, char>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D55530 Offset: 0x2D55631 VA: 0x2D55530
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2D58AF0 Offset: 0x2D58BF1 VA: 0x2D58AF0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F5ECB0 Offset: 0x2F5EDB1 VA: 0x2F5ECB0
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F62330 Offset: 0x2F62431 VA: 0x2F62330
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F65D80 Offset: 0x2F65E81 VA: 0x2F65D80
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F694B0 Offset: 0x2F695B1 VA: 0x2F694B0
	|-Dictionary<int, SceneInstance>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F6CB50 Offset: 0x2F6CC51 VA: 0x2F6CB50
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F70260 Offset: 0x2F70361 VA: 0x2F70260
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F73EC0 Offset: 0x2F73FC1 VA: 0x2F73EC0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F779F0 Offset: 0x2F77AF1 VA: 0x2F779F0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E1EB90 Offset: 0x2E1EC91 VA: 0x2E1EB90
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E22190 Offset: 0x2E22291 VA: 0x2E22190
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E25810 Offset: 0x2E25911 VA: 0x2E25810
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E28DD0 Offset: 0x2E28ED1 VA: 0x2E28DD0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E2FA00 Offset: 0x2E2FB01 VA: 0x2E2FA00
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E32F70 Offset: 0x2E33071 VA: 0x2E32F70
	|-Dictionary<Int32Enum, float>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E36620 Offset: 0x2E36721 VA: 0x2E36620
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E39CD0 Offset: 0x2E39DD1 VA: 0x2E39CD0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F98870 Offset: 0x2F98971 VA: 0x2F98870
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F9BF20 Offset: 0x2F9C021 VA: 0x2F9BF20
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F9F5B0 Offset: 0x2F9F6B1 VA: 0x2F9F5B0
	|-Dictionary<Memory<object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FA2D80 Offset: 0x2FA2E81 VA: 0x2FA2D80
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FA6C50 Offset: 0x2FA6D51 VA: 0x2FA6C50
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FAABB0 Offset: 0x2FAACB1 VA: 0x2FAABB0
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FAE420 Offset: 0x2FAE521 VA: 0x2FAE420
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FB20B0 Offset: 0x2FB21B1 VA: 0x2FB20B0
	|-Dictionary<Nullable<Color>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F1CDD0 Offset: 0x2F1CED1 VA: 0x2F1CDD0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F20A70 Offset: 0x2F20B71 VA: 0x2F20A70
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F247A0 Offset: 0x2F248A1 VA: 0x2F247A0
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F27FF0 Offset: 0x2F280F1 VA: 0x2F27FF0
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F2C450 Offset: 0x2F2C551 VA: 0x2F2C450
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F301F0 Offset: 0x2F302F1 VA: 0x2F301F0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F33B20 Offset: 0x2F33C21 VA: 0x2F33B20
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F377C0 Offset: 0x2F378C1 VA: 0x2F377C0
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F004D0 Offset: 0x2F005D1 VA: 0x2F004D0
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F03E00 Offset: 0x2F03F01 VA: 0x2F03E00
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F076D0 Offset: 0x2F077D1 VA: 0x2F076D0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F0AF20 Offset: 0x2F0B021 VA: 0x2F0AF20
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F0E760 Offset: 0x2F0E861 VA: 0x2F0E760
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F123F0 Offset: 0x2F124F1 VA: 0x2F123F0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F15AD0 Offset: 0x2F15BD1 VA: 0x2F15AD0
	|-Dictionary<object, BitVector32Int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2F19480 Offset: 0x2F19581 VA: 0x2F19480
	|-Dictionary<object, EventCheckId>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FF5F60 Offset: 0x2FF6061 VA: 0x2FF5F60
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FF9980 Offset: 0x2FF9A81 VA: 0x2FF9980
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FFD0E0 Offset: 0x2FFD1E1 VA: 0x2FFD0E0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30007D0 Offset: 0x30008D1 VA: 0x30007D0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30042C0 Offset: 0x30043C1 VA: 0x30042C0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3007A40 Offset: 0x3007B41 VA: 0x3007A40
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x300B540 Offset: 0x300B641 VA: 0x300B540
	|-Dictionary<object, OrderSaveData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x300EF90 Offset: 0x300F091 VA: 0x300EF90
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DE0890 Offset: 0x2DE0991 VA: 0x2DE0890
	|-Dictionary<object, Parameter>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DE3FA0 Offset: 0x2DE40A1 VA: 0x2DE3FA0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DE7690 Offset: 0x2DE7791 VA: 0x2DE7690
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DEAD50 Offset: 0x2DEAE51 VA: 0x2DEAD50
	|-Dictionary<object, byte>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DEE410 Offset: 0x2DEE511 VA: 0x2DEE410
	|-Dictionary<object, char>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DF1AC0 Offset: 0x2DF1BC1 VA: 0x2DF1AC0
	|-Dictionary<object, DateTime>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DF5180 Offset: 0x2DF5281 VA: 0x2DF5180
	|-Dictionary<object, double>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DF8840 Offset: 0x2DF8941 VA: 0x2DF8840
	|-Dictionary<object, short>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DFBF00 Offset: 0x2DFC001 VA: 0x2DFBF00
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30BB4C0 Offset: 0x30BB5C1 VA: 0x30BB4C0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30BEB70 Offset: 0x30BEC71 VA: 0x30BEB70
	|-Dictionary<object, long>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30C2280 Offset: 0x30C2381 VA: 0x30C2280
	|-Dictionary<object, Memory<object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30C59F0 Offset: 0x30C5AF1 VA: 0x30C59F0
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30C95E0 Offset: 0x30C96E1 VA: 0x30C95E0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30CD240 Offset: 0x30CD341 VA: 0x30CD240
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30D0A50 Offset: 0x30D0B51 VA: 0x30D0A50
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30D44F0 Offset: 0x30D45F1 VA: 0x30D44F0
	|-Dictionary<object, Nullable<Color>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30127B0 Offset: 0x30128B1 VA: 0x30127B0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3016270 Offset: 0x3016371 VA: 0x3016270
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3019DA0 Offset: 0x3019EA1 VA: 0x3019DA0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x301D5A0 Offset: 0x301D6A1 VA: 0x301D5A0
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30214E0 Offset: 0x30215E1 VA: 0x30214E0
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3025040 Offset: 0x3025141 VA: 0x3025040
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30288C0 Offset: 0x30289C1 VA: 0x30288C0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x302C390 Offset: 0x302C491 VA: 0x302C390
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FD9970 Offset: 0x2FD9A71 VA: 0x2FD9970
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FDD1F0 Offset: 0x2FDD2F1 VA: 0x2FDD1F0
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FE0A40 Offset: 0x2FE0B41 VA: 0x2FE0A40
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FE4250 Offset: 0x2FE4351 VA: 0x2FE4250
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FE7A40 Offset: 0x2FE7B41 VA: 0x2FE7A40
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FEB4F0 Offset: 0x2FEB5F1 VA: 0x2FEB4F0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FEEC20 Offset: 0x2FEED21 VA: 0x2FEEC20
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2FF22A0 Offset: 0x2FF23A1 VA: 0x2FF22A0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DC0D50 Offset: 0x2DC0E51 VA: 0x2DC0D50
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DC4420 Offset: 0x2DC4521 VA: 0x2DC4420
	|-Dictionary<object, sbyte>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DC7AE0 Offset: 0x2DC7BE1 VA: 0x2DC7AE0
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DCB1A0 Offset: 0x2DCB2A1 VA: 0x2DCB1A0
	|-Dictionary<object, ushort>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DCE860 Offset: 0x2DCE961 VA: 0x2DCE860
	|-Dictionary<object, uint>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DD1F10 Offset: 0x2DD2011 VA: 0x2DD1F10
	|-Dictionary<object, ulong>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DD58F0 Offset: 0x2DD59F1 VA: 0x2DD58F0
	|-Dictionary<object, TransitionTables>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DD92B0 Offset: 0x2DD93B1 VA: 0x2DD92B0
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DDCC70 Offset: 0x2DDCD71 VA: 0x2DDCC70
	|-Dictionary<object, BoundsInt>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30D7C50 Offset: 0x30D7D51 VA: 0x30D7C50
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30DB360 Offset: 0x30DB461 VA: 0x30DB360
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30DEA60 Offset: 0x30DEB61 VA: 0x30DEA60
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30E23F0 Offset: 0x30E24F1 VA: 0x30E23F0
	|-Dictionary<object, GradientColorKey>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30E5F00 Offset: 0x30E6001 VA: 0x30E5F00
	|-Dictionary<object, Keyframe>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30E9630 Offset: 0x30E9731 VA: 0x30E9630
	|-Dictionary<object, LayerMask>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30ED270 Offset: 0x30ED371 VA: 0x30ED270
	|-Dictionary<object, Matrix4x4>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30F09C0 Offset: 0x30F0AC1 VA: 0x30F09C0
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x309F7F0 Offset: 0x309F8F1 VA: 0x309F7F0
	|-Dictionary<object, Quaternion>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30A2EB0 Offset: 0x30A2FB1 VA: 0x30A2EB0
	|-Dictionary<object, RangeInt>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30A65C0 Offset: 0x30A66C1 VA: 0x30A65C0
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30A9CB0 Offset: 0x30A9DB1 VA: 0x30A9CB0
	|-Dictionary<object, RectInt>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30AD650 Offset: 0x30AD751 VA: 0x30AD650
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30B1020 Offset: 0x30B1121 VA: 0x30B1020
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30B4750 Offset: 0x30B4851 VA: 0x30B4750
	|-Dictionary<object, Vector2>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30B7E00 Offset: 0x30B7F01 VA: 0x30B7E00
	|-Dictionary<object, Vector2Int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3083AE0 Offset: 0x3083BE1 VA: 0x3083AE0
	|-Dictionary<object, Vector3>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3087210 Offset: 0x3087311 VA: 0x3087210
	|-Dictionary<object, Vector3Int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x308A930 Offset: 0x308AA31 VA: 0x308A930
	|-Dictionary<object, Vector4>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x308E030 Offset: 0x308E131 VA: 0x308E030
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3091660 Offset: 0x3091761 VA: 0x3091660
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3094CE0 Offset: 0x3094DE1 VA: 0x3094CE0
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3098A40 Offset: 0x3098B41 VA: 0x3098A40
	|-Dictionary<float, CurveSample>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x309C140 Offset: 0x309C241 VA: 0x309C140
	|-Dictionary<float, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x319F6B0 Offset: 0x319F7B1 VA: 0x319F6B0
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31A2C20 Offset: 0x31A2D21 VA: 0x31A2C20
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31A61E0 Offset: 0x31A62E1 VA: 0x31A61E0
	|-Dictionary<uint, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31A9850 Offset: 0x31A9951 VA: 0x31A9850
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31ACE70 Offset: 0x31ACF71 VA: 0x31ACE70
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31B0490 Offset: 0x31B0591 VA: 0x31B0490
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31B3FB0 Offset: 0x31B40B1 VA: 0x31B3FB0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x31B7AE0 Offset: 0x31B7BE1 VA: 0x31B7AE0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x302FD90 Offset: 0x302FE91 VA: 0x302FD90
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3033480 Offset: 0x3033581 VA: 0x3033480
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3036AF0 Offset: 0x3036BF1 VA: 0x3036AF0
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x303A5C0 Offset: 0x303A6C1 VA: 0x303A5C0
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x303E0F0 Offset: 0x303E1F1 VA: 0x303E0F0
	|-Dictionary<BoundsInt, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3041870 Offset: 0x3041971 VA: 0x3041870
	|-Dictionary<Color, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3044F10 Offset: 0x3045011 VA: 0x3044F10
	|-Dictionary<Color32, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3048530 Offset: 0x3048631 VA: 0x3048530
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30670C0 Offset: 0x30671C1 VA: 0x30670C0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x306AB90 Offset: 0x306AC91 VA: 0x306AB90
	|-Dictionary<GradientColorKey, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x306E8D0 Offset: 0x306E9D1 VA: 0x306E8D0
	|-Dictionary<Keyframe, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3071FD0 Offset: 0x30720D1 VA: 0x3071FD0
	|-Dictionary<LayerMask, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3075F00 Offset: 0x3076001 VA: 0x3075F00
	|-Dictionary<Matrix4x4, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x30796A0 Offset: 0x30797A1 VA: 0x30796A0
	|-Dictionary<IntVec3, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x307CDE0 Offset: 0x307CEE1 VA: 0x307CDE0
	|-Dictionary<Quaternion, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3080440 Offset: 0x3080541 VA: 0x3080440
	|-Dictionary<RangeInt, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x304BC50 Offset: 0x304BD51 VA: 0x304BC50
	|-Dictionary<Rect, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x304F310 Offset: 0x304F411 VA: 0x304F310
	|-Dictionary<RectInt, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3052930 Offset: 0x3052A31 VA: 0x3052930
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3055FA0 Offset: 0x30560A1 VA: 0x3055FA0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3059620 Offset: 0x3059721 VA: 0x3059620
	|-Dictionary<Vector2, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x305CC40 Offset: 0x305CD41 VA: 0x305CC40
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3060310 Offset: 0x3060411 VA: 0x3060310
	|-Dictionary<Vector3, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3063A20 Offset: 0x3063B21 VA: 0x3063A20
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2E3D440 Offset: 0x2E3D541 VA: 0x2E3D440
	|-Dictionary<Vector4, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A18E60 Offset: 0x2A18F61 VA: 0x2A18E60
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2A1C4C0 Offset: 0x2A1C5C1 VA: 0x2A1C4C0
	|-Dictionary<BitVector32Int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E2C4B0 Offset: 0x2E2C5B1 VA: 0x2E2C4B0
	|-Dictionary<Season, Texture>.System.Collections.IDictionary.set_Item
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F7B6A0 Offset: 0x2F7B7A1 VA: 0x2F7B6A0
	|-Dictionary<EventCheckId, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F7F700 Offset: 0x2F7F801 VA: 0x2F7F700
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F832A0 Offset: 0x2F833A1 VA: 0x2F832A0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F869E0 Offset: 0x2F86AE1 VA: 0x2F869E0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F8A080 Offset: 0x2F8A181 VA: 0x2F8A080
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F8DD90 Offset: 0x2F8DE91 VA: 0x2F8DD90
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F91500 Offset: 0x2F91601 VA: 0x2F91500
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F95230 Offset: 0x2F95331 VA: 0x2F95230
	|-Dictionary<OrderSaveData, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D83140 Offset: 0x2D83241 VA: 0x2D83140
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D86EA0 Offset: 0x2D86FA1 VA: 0x2D86EA0
	|-Dictionary<Parameter, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D8A580 Offset: 0x2D8A681 VA: 0x2D8A580
	|-Dictionary<bool, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D8DBA0 Offset: 0x2D8DCA1 VA: 0x2D8DBA0
	|-Dictionary<byte, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D911C0 Offset: 0x2D912C1 VA: 0x2D911C0
	|-Dictionary<char, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D947E0 Offset: 0x2D948E1 VA: 0x2D947E0
	|-Dictionary<DateTime, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D97DF0 Offset: 0x2D97EF1 VA: 0x2D97DF0
	|-Dictionary<double, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D9B470 Offset: 0x2D9B571 VA: 0x2D9B470
	|-Dictionary<Guid, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D9EA90 Offset: 0x2D9EB91 VA: 0x2D9EA90
	|-Dictionary<short, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D3D1B0 Offset: 0x2D3D2B1 VA: 0x2D3D1B0
	|-Dictionary<int, CropDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D40B30 Offset: 0x2D40C31 VA: 0x2D40B30
	|-Dictionary<int, EffectDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D44150 Offset: 0x2D44251 VA: 0x2D44150
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D47D90 Offset: 0x2D47E91 VA: 0x2D47D90
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D4B4E0 Offset: 0x2D4B5E1 VA: 0x2D4B4E0
	|-Dictionary<int, MiningDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D4EAD0 Offset: 0x2D4EBD1 VA: 0x2D4EAD0
	|-Dictionary<int, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D52090 Offset: 0x2D52191 VA: 0x2D52090
	|-Dictionary<int, char>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D55650 Offset: 0x2D55751 VA: 0x2D55650
	|-Dictionary<int, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2D58C10 Offset: 0x2D58D11 VA: 0x2D58C10
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F5EDD0 Offset: 0x2F5EED1 VA: 0x2F5EDD0
	|-Dictionary<int, long>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F62430 Offset: 0x2F62531 VA: 0x2F62430
	|-Dictionary<int, object>.System.Collections.IDictionary.set_Item
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F65EB0 Offset: 0x2F65FB1 VA: 0x2F65EB0
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F695E0 Offset: 0x2F696E1 VA: 0x2F695E0
	|-Dictionary<int, SceneInstance>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F6CC70 Offset: 0x2F6CD71 VA: 0x2F6CC70
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F70390 Offset: 0x2F70491 VA: 0x2F70390
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F73FF0 Offset: 0x2F740F1 VA: 0x2F73FF0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F77B20 Offset: 0x2F77C21 VA: 0x2F77B20
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E1ECC0 Offset: 0x2E1EDC1 VA: 0x2E1ECC0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E222B0 Offset: 0x2E223B1 VA: 0x2E222B0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E25930 Offset: 0x2E25A31 VA: 0x2E25930
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E28EF0 Offset: 0x2E28FF1 VA: 0x2E28EF0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E2FB00 Offset: 0x2E2FC01 VA: 0x2E2FB00
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E33090 Offset: 0x2E33191 VA: 0x2E33090
	|-Dictionary<Int32Enum, float>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E36750 Offset: 0x2E36851 VA: 0x2E36750
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E39DF0 Offset: 0x2E39EF1 VA: 0x2E39DF0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F989A0 Offset: 0x2F98AA1 VA: 0x2F989A0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F9C020 Offset: 0x2F9C121 VA: 0x2F9C020
	|-Dictionary<long, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F9F6B0 Offset: 0x2F9F7B1 VA: 0x2F9F6B0
	|-Dictionary<Memory<object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FA2E90 Offset: 0x2FA2F91 VA: 0x2FA2E90
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FA6D80 Offset: 0x2FA6E81 VA: 0x2FA6D80
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FAACE0 Offset: 0x2FAADE1 VA: 0x2FAACE0
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FAE530 Offset: 0x2FAE631 VA: 0x2FAE530
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FB21E0 Offset: 0x2FB22E1 VA: 0x2FB21E0
	|-Dictionary<Nullable<Color>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F1CEE0 Offset: 0x2F1CFE1 VA: 0x2F1CEE0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F20BA0 Offset: 0x2F20CA1 VA: 0x2F20BA0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F248D0 Offset: 0x2F249D1 VA: 0x2F248D0
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F28100 Offset: 0x2F28201 VA: 0x2F28100
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F2C590 Offset: 0x2F2C691 VA: 0x2F2C590
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F30320 Offset: 0x2F30421 VA: 0x2F30320
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F33C30 Offset: 0x2F33D31 VA: 0x2F33C30
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F378F0 Offset: 0x2F379F1 VA: 0x2F378F0
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F00600 Offset: 0x2F00701 VA: 0x2F00600
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F03F10 Offset: 0x2F04011 VA: 0x2F03F10
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F077E0 Offset: 0x2F078E1 VA: 0x2F077E0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F0B030 Offset: 0x2F0B131 VA: 0x2F0B030
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F0E870 Offset: 0x2F0E971 VA: 0x2F0E870
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F12520 Offset: 0x2F12621 VA: 0x2F12520
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F15BF0 Offset: 0x2F15CF1 VA: 0x2F15BF0
	|-Dictionary<object, BitVector32Int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2F195B0 Offset: 0x2F196B1 VA: 0x2F195B0
	|-Dictionary<object, EventCheckId>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FF6090 Offset: 0x2FF6191 VA: 0x2FF6090
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FF9AB0 Offset: 0x2FF9BB1 VA: 0x2FF9AB0
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FFD210 Offset: 0x2FFD311 VA: 0x2FFD210
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3000900 Offset: 0x3000A01 VA: 0x3000900
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30043F0 Offset: 0x30044F1 VA: 0x30043F0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3007B70 Offset: 0x3007C71 VA: 0x3007B70
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x300B670 Offset: 0x300B771 VA: 0x300B670
	|-Dictionary<object, OrderSaveData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x300F0C0 Offset: 0x300F1C1 VA: 0x300F0C0
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DE09C0 Offset: 0x2DE0AC1 VA: 0x2DE09C0
	|-Dictionary<object, Parameter>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DE40D0 Offset: 0x2DE41D1 VA: 0x2DE40D0
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DE77B0 Offset: 0x2DE78B1 VA: 0x2DE77B0
	|-Dictionary<object, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DEAE70 Offset: 0x2DEAF71 VA: 0x2DEAE70
	|-Dictionary<object, byte>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DEE530 Offset: 0x2DEE631 VA: 0x2DEE530
	|-Dictionary<object, char>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DF1BE0 Offset: 0x2DF1CE1 VA: 0x2DF1BE0
	|-Dictionary<object, DateTime>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DF52A0 Offset: 0x2DF53A1 VA: 0x2DF52A0
	|-Dictionary<object, double>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DF8960 Offset: 0x2DF8A61 VA: 0x2DF8960
	|-Dictionary<object, short>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DFC020 Offset: 0x2DFC121 VA: 0x2DFC020
	|-Dictionary<object, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30BB5E0 Offset: 0x30BB6E1 VA: 0x30BB5E0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30BEC90 Offset: 0x30BED91 VA: 0x30BEC90
	|-Dictionary<object, long>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30C23B0 Offset: 0x30C24B1 VA: 0x30C23B0
	|-Dictionary<object, Memory<object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30C5B10 Offset: 0x30C5C11 VA: 0x30C5B10
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30C9720 Offset: 0x30C9821 VA: 0x30C9720
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30CD380 Offset: 0x30CD481 VA: 0x30CD380
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30D0B70 Offset: 0x30D0C71 VA: 0x30D0B70
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30D4620 Offset: 0x30D4721 VA: 0x30D4620
	|-Dictionary<object, Nullable<Color>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30128E0 Offset: 0x30129E1 VA: 0x30128E0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30163A0 Offset: 0x30164A1 VA: 0x30163A0
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3019ED0 Offset: 0x3019FD1 VA: 0x3019ED0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x301D6C0 Offset: 0x301D7C1 VA: 0x301D6C0
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3021610 Offset: 0x3021711 VA: 0x3021610
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3025170 Offset: 0x3025271 VA: 0x3025170
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30289F0 Offset: 0x3028AF1 VA: 0x30289F0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x302C4C0 Offset: 0x302C5C1 VA: 0x302C4C0
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FD9AA0 Offset: 0x2FD9BA1 VA: 0x2FD9AA0
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FDD320 Offset: 0x2FDD421 VA: 0x2FDD320
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FE0B70 Offset: 0x2FE0C71 VA: 0x2FE0B70
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FE4380 Offset: 0x2FE4481 VA: 0x2FE4380
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FE7B70 Offset: 0x2FE7C71 VA: 0x2FE7B70
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FEB620 Offset: 0x2FEB721 VA: 0x2FEB620
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FEED10 Offset: 0x2FEEE11 VA: 0x2FEED10
	|-Dictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2FF23D0 Offset: 0x2FF24D1 VA: 0x2FF23D0
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DC0E80 Offset: 0x2DC0F81 VA: 0x2DC0E80
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DC4540 Offset: 0x2DC4641 VA: 0x2DC4540
	|-Dictionary<object, sbyte>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DC7C00 Offset: 0x2DC7D01 VA: 0x2DC7C00
	|-Dictionary<object, float>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DCB2C0 Offset: 0x2DCB3C1 VA: 0x2DCB2C0
	|-Dictionary<object, ushort>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DCE980 Offset: 0x2DCEA81 VA: 0x2DCE980
	|-Dictionary<object, uint>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DD2030 Offset: 0x2DD2131 VA: 0x2DD2030
	|-Dictionary<object, ulong>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DD5A20 Offset: 0x2DD5B21 VA: 0x2DD5A20
	|-Dictionary<object, TransitionTables>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DD93E0 Offset: 0x2DD94E1 VA: 0x2DD93E0
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DDCDA0 Offset: 0x2DDCEA1 VA: 0x2DDCDA0
	|-Dictionary<object, BoundsInt>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30D7D70 Offset: 0x30D7E71 VA: 0x30D7D70
	|-Dictionary<object, Color32>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30DB490 Offset: 0x30DB591 VA: 0x30DB490
	|-Dictionary<object, Color>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30DEB80 Offset: 0x30DEC81 VA: 0x30DEB80
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30E2520 Offset: 0x30E2621 VA: 0x30E2520
	|-Dictionary<object, GradientColorKey>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30E6040 Offset: 0x30E6141 VA: 0x30E6040
	|-Dictionary<object, Keyframe>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30E9750 Offset: 0x30E9851 VA: 0x30E9750
	|-Dictionary<object, LayerMask>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30ED3A0 Offset: 0x30ED4A1 VA: 0x30ED3A0
	|-Dictionary<object, Matrix4x4>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30F0AF0 Offset: 0x30F0BF1 VA: 0x30F0AF0
	|-Dictionary<object, Playable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x309F920 Offset: 0x309FA21 VA: 0x309F920
	|-Dictionary<object, Quaternion>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30A2FD0 Offset: 0x30A30D1 VA: 0x30A2FD0
	|-Dictionary<object, RangeInt>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30A66F0 Offset: 0x30A67F1 VA: 0x30A66F0
	|-Dictionary<object, Rect>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30A9DE0 Offset: 0x30A9EE1 VA: 0x30A9DE0
	|-Dictionary<object, RectInt>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30AD780 Offset: 0x30AD881 VA: 0x30AD780
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30B1150 Offset: 0x30B1251 VA: 0x30B1150
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30B4870 Offset: 0x30B4971 VA: 0x30B4870
	|-Dictionary<object, Vector2>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30B7F20 Offset: 0x30B8021 VA: 0x30B7F20
	|-Dictionary<object, Vector2Int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3083C10 Offset: 0x3083D11 VA: 0x3083C10
	|-Dictionary<object, Vector3>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3087340 Offset: 0x3087441 VA: 0x3087340
	|-Dictionary<object, Vector3Int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x308AA60 Offset: 0x308AB61 VA: 0x308AA60
	|-Dictionary<object, Vector4>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x308E130 Offset: 0x308E231 VA: 0x308E130
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3091780 Offset: 0x3091881 VA: 0x3091780
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3094DE0 Offset: 0x3094EE1 VA: 0x3094DE0
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3098B70 Offset: 0x3098C71 VA: 0x3098B70
	|-Dictionary<float, CurveSample>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x309C240 Offset: 0x309C341 VA: 0x309C240
	|-Dictionary<float, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x319F7B0 Offset: 0x319F8B1 VA: 0x319F7B0
	|-Dictionary<ushort, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31A2D40 Offset: 0x31A2E41 VA: 0x31A2D40
	|-Dictionary<uint, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31A6300 Offset: 0x31A6401 VA: 0x31A6300
	|-Dictionary<uint, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31A9950 Offset: 0x31A9A51 VA: 0x31A9950
	|-Dictionary<uint, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31ACF70 Offset: 0x31AD071 VA: 0x31ACF70
	|-Dictionary<ulong, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31B05B0 Offset: 0x31B06B1 VA: 0x31B05B0
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31B40E0 Offset: 0x31B41E1 VA: 0x31B40E0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x31B7C10 Offset: 0x31B7D11 VA: 0x31B7C10
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x302FEC0 Offset: 0x302FFC1 VA: 0x302FEC0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30335A0 Offset: 0x30336A1 VA: 0x30335A0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3036BF0 Offset: 0x3036CF1 VA: 0x3036BF0
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x303A6D0 Offset: 0x303A7D1 VA: 0x303A6D0
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x303E200 Offset: 0x303E301 VA: 0x303E200
	|-Dictionary<BoundsInt, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3041970 Offset: 0x3041A71 VA: 0x3041970
	|-Dictionary<Color, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3045010 Offset: 0x3045111 VA: 0x3045010
	|-Dictionary<Color32, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3048630 Offset: 0x3048731 VA: 0x3048630
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30671C0 Offset: 0x30672C1 VA: 0x30671C0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x306ACA0 Offset: 0x306ADA1 VA: 0x306ACA0
	|-Dictionary<GradientColorKey, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x306E9F0 Offset: 0x306EAF1 VA: 0x306E9F0
	|-Dictionary<Keyframe, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30720D0 Offset: 0x30721D1 VA: 0x30720D0
	|-Dictionary<LayerMask, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3076020 Offset: 0x3076121 VA: 0x3076020
	|-Dictionary<Matrix4x4, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30797A0 Offset: 0x30798A1 VA: 0x30797A0
	|-Dictionary<IntVec3, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x307CEE0 Offset: 0x307CFE1 VA: 0x307CEE0
	|-Dictionary<Quaternion, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3080540 Offset: 0x3080641 VA: 0x3080540
	|-Dictionary<RangeInt, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x304BD50 Offset: 0x304BE51 VA: 0x304BD50
	|-Dictionary<Rect, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x304F410 Offset: 0x304F511 VA: 0x304F410
	|-Dictionary<RectInt, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3052A50 Offset: 0x3052B51 VA: 0x3052A50
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x30560A0 Offset: 0x30561A1 VA: 0x30560A0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3059720 Offset: 0x3059821 VA: 0x3059720
	|-Dictionary<Vector2, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x305CD40 Offset: 0x305CE41 VA: 0x305CD40
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3060410 Offset: 0x3060511 VA: 0x3060410
	|-Dictionary<Vector3, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3063B20 Offset: 0x3063C21 VA: 0x3063B20
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2E3D540 Offset: 0x2E3D641 VA: 0x2E3D540
	|-Dictionary<Vector4, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A19200 Offset: 0x2A19301 VA: 0x2A19200
	|-Dictionary<JSONDeserialization.TaskField, object>.IsCompatibleKey
	|
	|-RVA: 0x2A1C860 Offset: 0x2A1C961 VA: 0x2A1C860
	|-Dictionary<BitVector32Int, object>.IsCompatibleKey
	|
	|-RVA: 0x2F7BA60 Offset: 0x2F7BB61 VA: 0x2F7BA60
	|-Dictionary<EventCheckId, object>.IsCompatibleKey
	|
	|-RVA: 0x2F7FAE0 Offset: 0x2F7FBE1 VA: 0x2F7FAE0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.IsCompatibleKey
	|
	|-RVA: 0x2F83660 Offset: 0x2F83761 VA: 0x2F83660
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.IsCompatibleKey
	|
	|-RVA: 0x2F86D90 Offset: 0x2F86E91 VA: 0x2F86D90
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.IsCompatibleKey
	|
	|-RVA: 0x2F8A420 Offset: 0x2F8A521 VA: 0x2F8A420
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.IsCompatibleKey
	|
	|-RVA: 0x2F8E160 Offset: 0x2F8E261 VA: 0x2F8E160
	|-Dictionary<MonsterHutSaveData, object>.IsCompatibleKey
	|
	|-RVA: 0x2F918B0 Offset: 0x2F919B1 VA: 0x2F918B0
	|-Dictionary<OrderLotterySaveParameter, object>.IsCompatibleKey
	|
	|-RVA: 0x2F95600 Offset: 0x2F95701 VA: 0x2F95600
	|-Dictionary<OrderSaveData, object>.IsCompatibleKey
	|
	|-RVA: 0x2D83500 Offset: 0x2D83601 VA: 0x2D83500
	|-Dictionary<OrderSaveParameter, object>.IsCompatibleKey
	|
	|-RVA: 0x2D87260 Offset: 0x2D87361 VA: 0x2D87260
	|-Dictionary<Parameter, object>.IsCompatibleKey
	|
	|-RVA: 0x2D8A920 Offset: 0x2D8AA21 VA: 0x2D8A920
	|-Dictionary<bool, object>.IsCompatibleKey
	|
	|-RVA: 0x2D8DF40 Offset: 0x2D8E041 VA: 0x2D8DF40
	|-Dictionary<byte, object>.IsCompatibleKey
	|
	|-RVA: 0x2D91560 Offset: 0x2D91661 VA: 0x2D91560
	|-Dictionary<char, object>.IsCompatibleKey
	|
	|-RVA: 0x2D94B80 Offset: 0x2D94C81 VA: 0x2D94B80
	|-Dictionary<DateTime, object>.IsCompatibleKey
	|
	|-RVA: 0x2D98190 Offset: 0x2D98291 VA: 0x2D98190
	|-Dictionary<double, object>.IsCompatibleKey
	|
	|-RVA: 0x2D9B810 Offset: 0x2D9B911 VA: 0x2D9B810
	|-Dictionary<Guid, object>.IsCompatibleKey
	|
	|-RVA: 0x2D9EE30 Offset: 0x2D9EF31 VA: 0x2D9EE30
	|-Dictionary<short, object>.IsCompatibleKey
	|
	|-RVA: 0x2D3D590 Offset: 0x2D3D691 VA: 0x2D3D590
	|-Dictionary<int, CropDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2D40F10 Offset: 0x2D41011 VA: 0x2D40F10
	|-Dictionary<int, EffectDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2D44510 Offset: 0x2D44611 VA: 0x2D44510
	|-Dictionary<int, GimmickLayoutDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2D48180 Offset: 0x2D48281 VA: 0x2D48180
	|-Dictionary<int, MineTypeDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2D4B8A0 Offset: 0x2D4B9A1 VA: 0x2D4B8A0
	|-Dictionary<int, MiningDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2D4EE90 Offset: 0x2D4EF91 VA: 0x2D4EE90
	|-Dictionary<int, bool>.IsCompatibleKey
	|
	|-RVA: 0x2D52450 Offset: 0x2D52551 VA: 0x2D52450
	|-Dictionary<int, char>.IsCompatibleKey
	|
	|-RVA: 0x2D55A10 Offset: 0x2D55B11 VA: 0x2D55A10
	|-Dictionary<int, int>.IsCompatibleKey
	|
	|-RVA: 0x2D58FD0 Offset: 0x2D590D1 VA: 0x2D58FD0
	|-Dictionary<int, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x2F5F190 Offset: 0x2F5F291 VA: 0x2F5F190
	|-Dictionary<int, long>.IsCompatibleKey
	|
	|-RVA: 0x2F627D0 Offset: 0x2F628D1 VA: 0x2F627D0
	|-Dictionary<int, object>.IsCompatibleKey
	|
	|-RVA: 0x2F66290 Offset: 0x2F66391 VA: 0x2F66290
	|-Dictionary<int, DiagnosticEvent>.IsCompatibleKey
	|
	|-RVA: 0x2F699A0 Offset: 0x2F69AA1 VA: 0x2F699A0
	|-Dictionary<int, SceneInstance>.IsCompatibleKey
	|
	|-RVA: 0x2F6D030 Offset: 0x2F6D131 VA: 0x2F6D030
	|-Dictionary<int, Vector2Int>.IsCompatibleKey
	|
	|-RVA: 0x2F70760 Offset: 0x2F70861 VA: 0x2F70760
	|-Dictionary<int, Vector3>.IsCompatibleKey
	|
	|-RVA: 0x2F743D0 Offset: 0x2F744D1 VA: 0x2F743D0
	|-Dictionary<Int32Enum, MonsterDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2F77F00 Offset: 0x2F78001 VA: 0x2F77F00
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2E1F080 Offset: 0x2E1F181 VA: 0x2E1F080
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.IsCompatibleKey
	|
	|-RVA: 0x2E22670 Offset: 0x2E22771 VA: 0x2E22670
	|-Dictionary<Int32Enum, bool>.IsCompatibleKey
	|
	|-RVA: 0x2E25CF0 Offset: 0x2E25DF1 VA: 0x2E25CF0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.IsCompatibleKey
	|
	|-RVA: 0x2E292B0 Offset: 0x2E293B1 VA: 0x2E292B0
	|-Dictionary<Int32Enum, int>.IsCompatibleKey
	|
	|-RVA: 0x2E2C870 Offset: 0x2E2C971 VA: 0x2E2C870
	|-Dictionary<Int32Enum, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x2E2FEA0 Offset: 0x2E2FFA1 VA: 0x2E2FEA0
	|-Dictionary<Int32Enum, object>.IsCompatibleKey
	|
	|-RVA: 0x2E33450 Offset: 0x2E33551 VA: 0x2E33450
	|-Dictionary<Int32Enum, float>.IsCompatibleKey
	|
	|-RVA: 0x2E36B10 Offset: 0x2E36C11 VA: 0x2E36B10
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.IsCompatibleKey
	|
	|-RVA: 0x2E3A1B0 Offset: 0x2E3A2B1 VA: 0x2E3A1B0
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.IsCompatibleKey
	|
	|-RVA: 0x2F98D70 Offset: 0x2F98E71 VA: 0x2F98D70
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.IsCompatibleKey
	|
	|-RVA: 0x2F9C3C0 Offset: 0x2F9C4C1 VA: 0x2F9C3C0
	|-Dictionary<long, object>.IsCompatibleKey
	|
	|-RVA: 0x2F9FA50 Offset: 0x2F9FB51 VA: 0x2F9FA50
	|-Dictionary<Memory<object>, object>.IsCompatibleKey
	|
	|-RVA: 0x2FA3230 Offset: 0x2FA3331 VA: 0x2FA3230
	|-Dictionary<Nullable<Int32Enum>, object>.IsCompatibleKey
	|
	|-RVA: 0x2FA7140 Offset: 0x2FA7241 VA: 0x2FA7140
	|-Dictionary<Nullable<Bounds>, object>.IsCompatibleKey
	|
	|-RVA: 0x2FAB0A0 Offset: 0x2FAB1A1 VA: 0x2FAB0A0
	|-Dictionary<Nullable<BoundsInt>, object>.IsCompatibleKey
	|
	|-RVA: 0x2FAE8D0 Offset: 0x2FAE9D1 VA: 0x2FAE8D0
	|-Dictionary<Nullable<Color32>, object>.IsCompatibleKey
	|
	|-RVA: 0x2FB2590 Offset: 0x2FB2691 VA: 0x2FB2590
	|-Dictionary<Nullable<Color>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F1D280 Offset: 0x2F1D381 VA: 0x2F1D280
	|-Dictionary<Nullable<GradientAlphaKey>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F20F50 Offset: 0x2F21051 VA: 0x2F20F50
	|-Dictionary<Nullable<GradientColorKey>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F24C80 Offset: 0x2F24D81 VA: 0x2F24C80
	|-Dictionary<Nullable<Keyframe>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F284A0 Offset: 0x2F285A1 VA: 0x2F284A0
	|-Dictionary<Nullable<LayerMask>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F2C970 Offset: 0x2F2CA71 VA: 0x2F2C970
	|-Dictionary<Nullable<Matrix4x4>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F306D0 Offset: 0x2F307D1 VA: 0x2F306D0
	|-Dictionary<Nullable<Quaternion>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F33FD0 Offset: 0x2F340D1 VA: 0x2F33FD0
	|-Dictionary<Nullable<RangeInt>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F37CA0 Offset: 0x2F37DA1 VA: 0x2F37CA0
	|-Dictionary<Nullable<Rect>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F009B0 Offset: 0x2F00AB1 VA: 0x2F009B0
	|-Dictionary<Nullable<RectInt>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F042B0 Offset: 0x2F043B1 VA: 0x2F042B0
	|-Dictionary<Nullable<Vector2>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F07B80 Offset: 0x2F07C81 VA: 0x2F07B80
	|-Dictionary<Nullable<Vector2Int>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F0B3D0 Offset: 0x2F0B4D1 VA: 0x2F0B3D0
	|-Dictionary<Nullable<Vector3>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F0EC10 Offset: 0x2F0ED11 VA: 0x2F0EC10
	|-Dictionary<Nullable<Vector3Int>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F128D0 Offset: 0x2F129D1 VA: 0x2F128D0
	|-Dictionary<Nullable<Vector4>, object>.IsCompatibleKey
	|
	|-RVA: 0x2F15FB0 Offset: 0x2F160B1 VA: 0x2F15FB0
	|-Dictionary<object, BitVector32Int>.IsCompatibleKey
	|
	|-RVA: 0x2F19980 Offset: 0x2F19A81 VA: 0x2F19980
	|-Dictionary<object, EventCheckId>.IsCompatibleKey
	|
	|-RVA: 0x2FF6480 Offset: 0x2FF6581 VA: 0x2FF6480
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.IsCompatibleKey
	|
	|-RVA: 0x2FF9E80 Offset: 0x2FF9F81 VA: 0x2FF9E80
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.IsCompatibleKey
	|
	|-RVA: 0x2FFD5D0 Offset: 0x2FFD6D1 VA: 0x2FFD5D0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.IsCompatibleKey
	|
	|-RVA: 0x3000CC0 Offset: 0x3000DC1 VA: 0x3000CC0
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.IsCompatibleKey
	|
	|-RVA: 0x30047D0 Offset: 0x30048D1 VA: 0x30047D0
	|-Dictionary<object, MonsterHutSaveData>.IsCompatibleKey
	|
	|-RVA: 0x3007F30 Offset: 0x3008031 VA: 0x3007F30
	|-Dictionary<object, OrderLotterySaveParameter>.IsCompatibleKey
	|
	|-RVA: 0x300BA50 Offset: 0x300BB51 VA: 0x300BA50
	|-Dictionary<object, OrderSaveData>.IsCompatibleKey
	|
	|-RVA: 0x300F490 Offset: 0x300F591 VA: 0x300F490
	|-Dictionary<object, OrderSaveParameter>.IsCompatibleKey
	|
	|-RVA: 0x2DE0D90 Offset: 0x2DE0E91 VA: 0x2DE0D90
	|-Dictionary<object, Parameter>.IsCompatibleKey
	|
	|-RVA: 0x2DE4490 Offset: 0x2DE4591 VA: 0x2DE4490
	|-Dictionary<object, NumberControl.ValueRange>.IsCompatibleKey
	|
	|-RVA: 0x2DE7B70 Offset: 0x2DE7C71 VA: 0x2DE7B70
	|-Dictionary<object, bool>.IsCompatibleKey
	|
	|-RVA: 0x2DEB230 Offset: 0x2DEB331 VA: 0x2DEB230
	|-Dictionary<object, byte>.IsCompatibleKey
	|
	|-RVA: 0x2DEE8F0 Offset: 0x2DEE9F1 VA: 0x2DEE8F0
	|-Dictionary<object, char>.IsCompatibleKey
	|
	|-RVA: 0x2DF1FA0 Offset: 0x2DF20A1 VA: 0x2DF1FA0
	|-Dictionary<object, DateTime>.IsCompatibleKey
	|
	|-RVA: 0x2DF5660 Offset: 0x2DF5761 VA: 0x2DF5660
	|-Dictionary<object, double>.IsCompatibleKey
	|
	|-RVA: 0x2DF8D20 Offset: 0x2DF8E21 VA: 0x2DF8D20
	|-Dictionary<object, short>.IsCompatibleKey
	|
	|-RVA: 0x2DFC3E0 Offset: 0x2DFC4E1 VA: 0x2DFC3E0
	|-Dictionary<object, int>.IsCompatibleKey
	|
	|-RVA: 0x30BB9A0 Offset: 0x30BBAA1 VA: 0x30BB9A0
	|-Dictionary<object, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x30BF050 Offset: 0x30BF151 VA: 0x30BF050
	|-Dictionary<object, long>.IsCompatibleKey
	|
	|-RVA: 0x30C2770 Offset: 0x30C2871 VA: 0x30C2770
	|-Dictionary<object, Memory<object>>.IsCompatibleKey
	|
	|-RVA: 0x30C5EF0 Offset: 0x30C5FF1 VA: 0x30C5EF0
	|-Dictionary<object, Nullable<Int32Enum>>.IsCompatibleKey
	|
	|-RVA: 0x30C9B20 Offset: 0x30C9C21 VA: 0x30C9B20
	|-Dictionary<object, Nullable<Bounds>>.IsCompatibleKey
	|
	|-RVA: 0x30CD780 Offset: 0x30CD881 VA: 0x30CD780
	|-Dictionary<object, Nullable<BoundsInt>>.IsCompatibleKey
	|
	|-RVA: 0x30D0F50 Offset: 0x30D1051 VA: 0x30D0F50
	|-Dictionary<object, Nullable<Color32>>.IsCompatibleKey
	|
	|-RVA: 0x30D4A20 Offset: 0x30D4B21 VA: 0x30D4A20
	|-Dictionary<object, Nullable<Color>>.IsCompatibleKey
	|
	|-RVA: 0x3012CD0 Offset: 0x3012DD1 VA: 0x3012CD0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.IsCompatibleKey
	|
	|-RVA: 0x30167A0 Offset: 0x30168A1 VA: 0x30167A0
	|-Dictionary<object, Nullable<GradientColorKey>>.IsCompatibleKey
	|
	|-RVA: 0x301A2D0 Offset: 0x301A3D1 VA: 0x301A2D0
	|-Dictionary<object, Nullable<Keyframe>>.IsCompatibleKey
	|
	|-RVA: 0x301DAA0 Offset: 0x301DBA1 VA: 0x301DAA0
	|-Dictionary<object, Nullable<LayerMask>>.IsCompatibleKey
	|
	|-RVA: 0x3021A30 Offset: 0x3021B31 VA: 0x3021A30
	|-Dictionary<object, Nullable<Matrix4x4>>.IsCompatibleKey
	|
	|-RVA: 0x3025570 Offset: 0x3025671 VA: 0x3025570
	|-Dictionary<object, Nullable<Quaternion>>.IsCompatibleKey
	|
	|-RVA: 0x3028DE0 Offset: 0x3028EE1 VA: 0x3028DE0
	|-Dictionary<object, Nullable<RangeInt>>.IsCompatibleKey
	|
	|-RVA: 0x302C8C0 Offset: 0x302C9C1 VA: 0x302C8C0
	|-Dictionary<object, Nullable<Rect>>.IsCompatibleKey
	|
	|-RVA: 0x2FD9EA0 Offset: 0x2FD9FA1 VA: 0x2FD9EA0
	|-Dictionary<object, Nullable<RectInt>>.IsCompatibleKey
	|
	|-RVA: 0x2FDD710 Offset: 0x2FDD811 VA: 0x2FDD710
	|-Dictionary<object, Nullable<Vector2>>.IsCompatibleKey
	|
	|-RVA: 0x2FE0F60 Offset: 0x2FE1061 VA: 0x2FE0F60
	|-Dictionary<object, Nullable<Vector2Int>>.IsCompatibleKey
	|
	|-RVA: 0x2FE4760 Offset: 0x2FE4861 VA: 0x2FE4760
	|-Dictionary<object, Nullable<Vector3>>.IsCompatibleKey
	|
	|-RVA: 0x2FE7F50 Offset: 0x2FE8051 VA: 0x2FE7F50
	|-Dictionary<object, Nullable<Vector3Int>>.IsCompatibleKey
	|
	|-RVA: 0x2FEBA20 Offset: 0x2FEBB21 VA: 0x2FEBA20
	|-Dictionary<object, Nullable<Vector4>>.IsCompatibleKey
	|
	|-RVA: 0x2FEF0A0 Offset: 0x2FEF1A1 VA: 0x2FEF0A0
	|-Dictionary<object, object>.IsCompatibleKey
	|
	|-RVA: 0x2FF2790 Offset: 0x2FF2891 VA: 0x2FF2790
	|-Dictionary<object, ReadOnlyMemory<object>>.IsCompatibleKey
	|
	|-RVA: 0x2DC1240 Offset: 0x2DC1341 VA: 0x2DC1240
	|-Dictionary<object, ResourceLocator>.IsCompatibleKey
	|
	|-RVA: 0x2DC4900 Offset: 0x2DC4A01 VA: 0x2DC4900
	|-Dictionary<object, sbyte>.IsCompatibleKey
	|
	|-RVA: 0x2DC7FC0 Offset: 0x2DC80C1 VA: 0x2DC7FC0
	|-Dictionary<object, float>.IsCompatibleKey
	|
	|-RVA: 0x2DCB680 Offset: 0x2DCB781 VA: 0x2DCB680
	|-Dictionary<object, ushort>.IsCompatibleKey
	|
	|-RVA: 0x2DCED40 Offset: 0x2DCEE41 VA: 0x2DCED40
	|-Dictionary<object, uint>.IsCompatibleKey
	|
	|-RVA: 0x2DD23F0 Offset: 0x2DD24F1 VA: 0x2DD23F0
	|-Dictionary<object, ulong>.IsCompatibleKey
	|
	|-RVA: 0x2DD5DF0 Offset: 0x2DD5EF1 VA: 0x2DD5DF0
	|-Dictionary<object, TransitionTables>.IsCompatibleKey
	|
	|-RVA: 0x2DD97B0 Offset: 0x2DD98B1 VA: 0x2DD97B0
	|-Dictionary<object, Bounds>.IsCompatibleKey
	|
	|-RVA: 0x2DDD170 Offset: 0x2DDD271 VA: 0x2DDD170
	|-Dictionary<object, BoundsInt>.IsCompatibleKey
	|
	|-RVA: 0x30D8130 Offset: 0x30D8231 VA: 0x30D8130
	|-Dictionary<object, Color32>.IsCompatibleKey
	|
	|-RVA: 0x30DB850 Offset: 0x30DB951 VA: 0x30DB850
	|-Dictionary<object, Color>.IsCompatibleKey
	|
	|-RVA: 0x30DEF40 Offset: 0x30DF041 VA: 0x30DEF40
	|-Dictionary<object, GradientAlphaKey>.IsCompatibleKey
	|
	|-RVA: 0x30E28F0 Offset: 0x30E29F1 VA: 0x30E28F0
	|-Dictionary<object, GradientColorKey>.IsCompatibleKey
	|
	|-RVA: 0x30E6420 Offset: 0x30E6521 VA: 0x30E6420
	|-Dictionary<object, Keyframe>.IsCompatibleKey
	|
	|-RVA: 0x30E9B10 Offset: 0x30E9C11 VA: 0x30E9B10
	|-Dictionary<object, LayerMask>.IsCompatibleKey
	|
	|-RVA: 0x30ED780 Offset: 0x30ED881 VA: 0x30ED780
	|-Dictionary<object, Matrix4x4>.IsCompatibleKey
	|
	|-RVA: 0x30F0EB0 Offset: 0x30F0FB1 VA: 0x30F0EB0
	|-Dictionary<object, Playable>.IsCompatibleKey
	|
	|-RVA: 0x309FCE0 Offset: 0x309FDE1 VA: 0x309FCE0
	|-Dictionary<object, Quaternion>.IsCompatibleKey
	|
	|-RVA: 0x30A3390 Offset: 0x30A3491 VA: 0x30A3390
	|-Dictionary<object, RangeInt>.IsCompatibleKey
	|
	|-RVA: 0x30A6AB0 Offset: 0x30A6BB1 VA: 0x30A6AB0
	|-Dictionary<object, Rect>.IsCompatibleKey
	|
	|-RVA: 0x30AA1A0 Offset: 0x30AA2A1 VA: 0x30AA1A0
	|-Dictionary<object, RectInt>.IsCompatibleKey
	|
	|-RVA: 0x30ADB50 Offset: 0x30ADC51 VA: 0x30ADB50
	|-Dictionary<object, AsyncOperationHandle>.IsCompatibleKey
	|
	|-RVA: 0x30B1520 Offset: 0x30B1621 VA: 0x30B1520
	|-Dictionary<object, AsyncOperationHandle<object>>.IsCompatibleKey
	|
	|-RVA: 0x30B4C30 Offset: 0x30B4D31 VA: 0x30B4C30
	|-Dictionary<object, Vector2>.IsCompatibleKey
	|
	|-RVA: 0x30B82E0 Offset: 0x30B83E1 VA: 0x30B82E0
	|-Dictionary<object, Vector2Int>.IsCompatibleKey
	|
	|-RVA: 0x3083FD0 Offset: 0x30840D1 VA: 0x3083FD0
	|-Dictionary<object, Vector3>.IsCompatibleKey
	|
	|-RVA: 0x3087700 Offset: 0x3087801 VA: 0x3087700
	|-Dictionary<object, Vector3Int>.IsCompatibleKey
	|
	|-RVA: 0x308AE20 Offset: 0x308AF21 VA: 0x308AE20
	|-Dictionary<object, Vector4>.IsCompatibleKey
	|
	|-RVA: 0x308E4D0 Offset: 0x308E5D1 VA: 0x308E4D0
	|-Dictionary<ReadOnlyMemory<object>, object>.IsCompatibleKey
	|
	|-RVA: 0x3091B40 Offset: 0x3091C41 VA: 0x3091B40
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.IsCompatibleKey
	|
	|-RVA: 0x3095180 Offset: 0x3095281 VA: 0x3095180
	|-Dictionary<sbyte, object>.IsCompatibleKey
	|
	|-RVA: 0x3098F60 Offset: 0x3099061 VA: 0x3098F60
	|-Dictionary<float, CurveSample>.IsCompatibleKey
	|
	|-RVA: 0x309C5E0 Offset: 0x309C6E1 VA: 0x309C5E0
	|-Dictionary<float, object>.IsCompatibleKey
	|
	|-RVA: 0x319FB50 Offset: 0x319FC51 VA: 0x319FB50
	|-Dictionary<ushort, object>.IsCompatibleKey
	|
	|-RVA: 0x31A3100 Offset: 0x31A3201 VA: 0x31A3100
	|-Dictionary<uint, int>.IsCompatibleKey
	|
	|-RVA: 0x31A66C0 Offset: 0x31A67C1 VA: 0x31A66C0
	|-Dictionary<uint, Int32Enum>.IsCompatibleKey
	|
	|-RVA: 0x31A9CF0 Offset: 0x31A9DF1 VA: 0x31A9CF0
	|-Dictionary<uint, object>.IsCompatibleKey
	|
	|-RVA: 0x31AD310 Offset: 0x31AD411 VA: 0x31AD310
	|-Dictionary<ulong, object>.IsCompatibleKey
	|
	|-RVA: 0x31B0970 Offset: 0x31B0A71 VA: 0x31B0970
	|-Dictionary<EdgeKeyByHash, int>.IsCompatibleKey
	|
	|-RVA: 0x31B44D0 Offset: 0x31B45D1 VA: 0x31B44D0
	|-Dictionary<EdgeKeyByHash, CapEdge>.IsCompatibleKey
	|
	|-RVA: 0x31B7FF0 Offset: 0x31B80F1 VA: 0x31B7FF0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.IsCompatibleKey
	|
	|-RVA: 0x30302A0 Offset: 0x30303A1 VA: 0x30302A0
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.IsCompatibleKey
	|
	|-RVA: 0x3033960 Offset: 0x3033A61 VA: 0x3033960
	|-Dictionary<MeshDataConnectivity.Face, bool>.IsCompatibleKey
	|
	|-RVA: 0x3036F90 Offset: 0x3037091 VA: 0x3036F90
	|-Dictionary<MeshDataConnectivity.Face, object>.IsCompatibleKey
	|
	|-RVA: 0x303AA90 Offset: 0x303AB91 VA: 0x303AA90
	|-Dictionary<Bounds, object>.IsCompatibleKey
	|
	|-RVA: 0x303E5C0 Offset: 0x303E6C1 VA: 0x303E5C0
	|-Dictionary<BoundsInt, object>.IsCompatibleKey
	|
	|-RVA: 0x3041D30 Offset: 0x3041E31 VA: 0x3041D30
	|-Dictionary<Color, object>.IsCompatibleKey
	|
	|-RVA: 0x30453B0 Offset: 0x30454B1 VA: 0x30453B0
	|-Dictionary<Color32, object>.IsCompatibleKey
	|
	|-RVA: 0x30489D0 Offset: 0x3048AD1 VA: 0x30489D0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.IsCompatibleKey
	|
	|-RVA: 0x3067560 Offset: 0x3067661 VA: 0x3067560
	|-Dictionary<GradientAlphaKey, object>.IsCompatibleKey
	|
	|-RVA: 0x306B060 Offset: 0x306B161 VA: 0x306B060
	|-Dictionary<GradientColorKey, object>.IsCompatibleKey
	|
	|-RVA: 0x306EDC0 Offset: 0x306EEC1 VA: 0x306EDC0
	|-Dictionary<Keyframe, object>.IsCompatibleKey
	|
	|-RVA: 0x3072470 Offset: 0x3072571 VA: 0x3072470
	|-Dictionary<LayerMask, object>.IsCompatibleKey
	|
	|-RVA: 0x3076400 Offset: 0x3076501 VA: 0x3076400
	|-Dictionary<Matrix4x4, object>.IsCompatibleKey
	|
	|-RVA: 0x3079B50 Offset: 0x3079C51 VA: 0x3079B50
	|-Dictionary<IntVec3, object>.IsCompatibleKey
	|
	|-RVA: 0x307D2A0 Offset: 0x307D3A1 VA: 0x307D2A0
	|-Dictionary<Quaternion, object>.IsCompatibleKey
	|
	|-RVA: 0x30808E0 Offset: 0x30809E1 VA: 0x30808E0
	|-Dictionary<RangeInt, object>.IsCompatibleKey
	|
	|-RVA: 0x304C110 Offset: 0x304C211 VA: 0x304C110
	|-Dictionary<Rect, object>.IsCompatibleKey
	|
	|-RVA: 0x304F7B0 Offset: 0x304F8B1 VA: 0x304F7B0
	|-Dictionary<RectInt, object>.IsCompatibleKey
	|
	|-RVA: 0x3052E10 Offset: 0x3052F11 VA: 0x3052E10
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.IsCompatibleKey
	|
	|-RVA: 0x3056440 Offset: 0x3056541 VA: 0x3056440
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.IsCompatibleKey
	|
	|-RVA: 0x3059AC0 Offset: 0x3059BC1 VA: 0x3059AC0
	|-Dictionary<Vector2, object>.IsCompatibleKey
	|
	|-RVA: 0x305D0E0 Offset: 0x305D1E1 VA: 0x305D0E0
	|-Dictionary<Vector2Int, object>.IsCompatibleKey
	|
	|-RVA: 0x30607C0 Offset: 0x30608C1 VA: 0x30607C0
	|-Dictionary<Vector3, object>.IsCompatibleKey
	|
	|-RVA: 0x3063ED0 Offset: 0x3063FD1 VA: 0x3063ED0
	|-Dictionary<Vector3Int, object>.IsCompatibleKey
	|
	|-RVA: 0x2E3D900 Offset: 0x2E3DA01 VA: 0x2E3D900
	|-Dictionary<Vector4, object>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A192D0 Offset: 0x2A193D1 VA: 0x2A192D0
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2A1C930 Offset: 0x2A1CA31 VA: 0x2A1C930
	|-Dictionary<BitVector32Int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E2C940 Offset: 0x2E2CA41 VA: 0x2E2C940
	|-Dictionary<Season, Texture>.System.Collections.IDictionary.Add
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F7BB30 Offset: 0x2F7BC31 VA: 0x2F7BB30
	|-Dictionary<EventCheckId, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F7FBB0 Offset: 0x2F7FCB1 VA: 0x2F7FBB0
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F83730 Offset: 0x2F83831 VA: 0x2F83730
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F86E60 Offset: 0x2F86F61 VA: 0x2F86E60
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F8A4F0 Offset: 0x2F8A5F1 VA: 0x2F8A4F0
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F8E230 Offset: 0x2F8E331 VA: 0x2F8E230
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F91980 Offset: 0x2F91A81 VA: 0x2F91980
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F956D0 Offset: 0x2F957D1 VA: 0x2F956D0
	|-Dictionary<OrderSaveData, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D835D0 Offset: 0x2D836D1 VA: 0x2D835D0
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D87330 Offset: 0x2D87431 VA: 0x2D87330
	|-Dictionary<Parameter, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D8A9F0 Offset: 0x2D8AAF1 VA: 0x2D8A9F0
	|-Dictionary<bool, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D8E010 Offset: 0x2D8E111 VA: 0x2D8E010
	|-Dictionary<byte, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D91630 Offset: 0x2D91731 VA: 0x2D91630
	|-Dictionary<char, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D94C50 Offset: 0x2D94D51 VA: 0x2D94C50
	|-Dictionary<DateTime, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D98260 Offset: 0x2D98361 VA: 0x2D98260
	|-Dictionary<double, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D9B8E0 Offset: 0x2D9B9E1 VA: 0x2D9B8E0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D9EF00 Offset: 0x2D9F001 VA: 0x2D9EF00
	|-Dictionary<short, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D3D660 Offset: 0x2D3D761 VA: 0x2D3D660
	|-Dictionary<int, CropDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D40FE0 Offset: 0x2D410E1 VA: 0x2D40FE0
	|-Dictionary<int, EffectDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D445E0 Offset: 0x2D446E1 VA: 0x2D445E0
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D48250 Offset: 0x2D48351 VA: 0x2D48250
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D4B970 Offset: 0x2D4BA71 VA: 0x2D4B970
	|-Dictionary<int, MiningDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D4EF60 Offset: 0x2D4F061 VA: 0x2D4EF60
	|-Dictionary<int, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D52520 Offset: 0x2D52621 VA: 0x2D52520
	|-Dictionary<int, char>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D55AE0 Offset: 0x2D55BE1 VA: 0x2D55AE0
	|-Dictionary<int, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2D590A0 Offset: 0x2D591A1 VA: 0x2D590A0
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F5F260 Offset: 0x2F5F361 VA: 0x2F5F260
	|-Dictionary<int, long>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F628A0 Offset: 0x2F629A1 VA: 0x2F628A0
	|-Dictionary<int, object>.System.Collections.IDictionary.Add
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F66360 Offset: 0x2F66461 VA: 0x2F66360
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F69A70 Offset: 0x2F69B71 VA: 0x2F69A70
	|-Dictionary<int, SceneInstance>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F6D100 Offset: 0x2F6D201 VA: 0x2F6D100
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F70830 Offset: 0x2F70931 VA: 0x2F70830
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F744A0 Offset: 0x2F745A1 VA: 0x2F744A0
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F77FD0 Offset: 0x2F780D1 VA: 0x2F77FD0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E1F150 Offset: 0x2E1F251 VA: 0x2E1F150
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E22740 Offset: 0x2E22841 VA: 0x2E22740
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E25DC0 Offset: 0x2E25EC1 VA: 0x2E25DC0
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E29380 Offset: 0x2E29481 VA: 0x2E29380
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E2FF70 Offset: 0x2E30071 VA: 0x2E2FF70
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E33520 Offset: 0x2E33621 VA: 0x2E33520
	|-Dictionary<Int32Enum, float>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E36BE0 Offset: 0x2E36CE1 VA: 0x2E36BE0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E3A280 Offset: 0x2E3A381 VA: 0x2E3A280
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F98E40 Offset: 0x2F98F41 VA: 0x2F98E40
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F9C490 Offset: 0x2F9C591 VA: 0x2F9C490
	|-Dictionary<long, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F9FB20 Offset: 0x2F9FC21 VA: 0x2F9FB20
	|-Dictionary<Memory<object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FA3300 Offset: 0x2FA3401 VA: 0x2FA3300
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FA7210 Offset: 0x2FA7311 VA: 0x2FA7210
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FAB170 Offset: 0x2FAB271 VA: 0x2FAB170
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FAE9A0 Offset: 0x2FAEAA1 VA: 0x2FAE9A0
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FB2660 Offset: 0x2FB2761 VA: 0x2FB2660
	|-Dictionary<Nullable<Color>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F1D350 Offset: 0x2F1D451 VA: 0x2F1D350
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F21020 Offset: 0x2F21121 VA: 0x2F21020
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F24D50 Offset: 0x2F24E51 VA: 0x2F24D50
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F28570 Offset: 0x2F28671 VA: 0x2F28570
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F2CA40 Offset: 0x2F2CB41 VA: 0x2F2CA40
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F307A0 Offset: 0x2F308A1 VA: 0x2F307A0
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F340A0 Offset: 0x2F341A1 VA: 0x2F340A0
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F37D70 Offset: 0x2F37E71 VA: 0x2F37D70
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F00A80 Offset: 0x2F00B81 VA: 0x2F00A80
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F04380 Offset: 0x2F04481 VA: 0x2F04380
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F07C50 Offset: 0x2F07D51 VA: 0x2F07C50
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F0B4A0 Offset: 0x2F0B5A1 VA: 0x2F0B4A0
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F0ECE0 Offset: 0x2F0EDE1 VA: 0x2F0ECE0
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F129A0 Offset: 0x2F12AA1 VA: 0x2F129A0
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F16080 Offset: 0x2F16181 VA: 0x2F16080
	|-Dictionary<object, BitVector32Int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2F19A50 Offset: 0x2F19B51 VA: 0x2F19A50
	|-Dictionary<object, EventCheckId>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FF6550 Offset: 0x2FF6651 VA: 0x2FF6550
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FF9F50 Offset: 0x2FFA051 VA: 0x2FF9F50
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FFD6A0 Offset: 0x2FFD7A1 VA: 0x2FFD6A0
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3000D90 Offset: 0x3000E91 VA: 0x3000D90
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30048A0 Offset: 0x30049A1 VA: 0x30048A0
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3008000 Offset: 0x3008101 VA: 0x3008000
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x300BB20 Offset: 0x300BC21 VA: 0x300BB20
	|-Dictionary<object, OrderSaveData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x300F560 Offset: 0x300F661 VA: 0x300F560
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DE0E60 Offset: 0x2DE0F61 VA: 0x2DE0E60
	|-Dictionary<object, Parameter>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DE4560 Offset: 0x2DE4661 VA: 0x2DE4560
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DE7C40 Offset: 0x2DE7D41 VA: 0x2DE7C40
	|-Dictionary<object, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DEB300 Offset: 0x2DEB401 VA: 0x2DEB300
	|-Dictionary<object, byte>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DEE9C0 Offset: 0x2DEEAC1 VA: 0x2DEE9C0
	|-Dictionary<object, char>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DF2070 Offset: 0x2DF2171 VA: 0x2DF2070
	|-Dictionary<object, DateTime>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DF5730 Offset: 0x2DF5831 VA: 0x2DF5730
	|-Dictionary<object, double>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DF8DF0 Offset: 0x2DF8EF1 VA: 0x2DF8DF0
	|-Dictionary<object, short>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DFC4B0 Offset: 0x2DFC5B1 VA: 0x2DFC4B0
	|-Dictionary<object, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30BBA70 Offset: 0x30BBB71 VA: 0x30BBA70
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30BF120 Offset: 0x30BF221 VA: 0x30BF120
	|-Dictionary<object, long>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30C2840 Offset: 0x30C2941 VA: 0x30C2840
	|-Dictionary<object, Memory<object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30C5FC0 Offset: 0x30C60C1 VA: 0x30C5FC0
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30C9BF0 Offset: 0x30C9CF1 VA: 0x30C9BF0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30CD850 Offset: 0x30CD951 VA: 0x30CD850
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30D1020 Offset: 0x30D1121 VA: 0x30D1020
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30D4AF0 Offset: 0x30D4BF1 VA: 0x30D4AF0
	|-Dictionary<object, Nullable<Color>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3012DA0 Offset: 0x3012EA1 VA: 0x3012DA0
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3016870 Offset: 0x3016971 VA: 0x3016870
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x301A3A0 Offset: 0x301A4A1 VA: 0x301A3A0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x301DB70 Offset: 0x301DC71 VA: 0x301DB70
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3021B00 Offset: 0x3021C01 VA: 0x3021B00
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3025640 Offset: 0x3025741 VA: 0x3025640
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3028EB0 Offset: 0x3028FB1 VA: 0x3028EB0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x302C990 Offset: 0x302CA91 VA: 0x302C990
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FD9F70 Offset: 0x2FDA071 VA: 0x2FD9F70
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FDD7E0 Offset: 0x2FDD8E1 VA: 0x2FDD7E0
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FE1030 Offset: 0x2FE1131 VA: 0x2FE1030
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FE4830 Offset: 0x2FE4931 VA: 0x2FE4830
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FE8020 Offset: 0x2FE8121 VA: 0x2FE8020
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FEBAF0 Offset: 0x2FEBBF1 VA: 0x2FEBAF0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FEF170 Offset: 0x2FEF271 VA: 0x2FEF170
	|-Dictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2FF2860 Offset: 0x2FF2961 VA: 0x2FF2860
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DC1310 Offset: 0x2DC1411 VA: 0x2DC1310
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DC49D0 Offset: 0x2DC4AD1 VA: 0x2DC49D0
	|-Dictionary<object, sbyte>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DC8090 Offset: 0x2DC8191 VA: 0x2DC8090
	|-Dictionary<object, float>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DCB750 Offset: 0x2DCB851 VA: 0x2DCB750
	|-Dictionary<object, ushort>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DCEE10 Offset: 0x2DCEF11 VA: 0x2DCEE10
	|-Dictionary<object, uint>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DD24C0 Offset: 0x2DD25C1 VA: 0x2DD24C0
	|-Dictionary<object, ulong>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DD5EC0 Offset: 0x2DD5FC1 VA: 0x2DD5EC0
	|-Dictionary<object, TransitionTables>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DD9880 Offset: 0x2DD9981 VA: 0x2DD9880
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DDD240 Offset: 0x2DDD341 VA: 0x2DDD240
	|-Dictionary<object, BoundsInt>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30D8200 Offset: 0x30D8301 VA: 0x30D8200
	|-Dictionary<object, Color32>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30DB920 Offset: 0x30DBA21 VA: 0x30DB920
	|-Dictionary<object, Color>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30DF010 Offset: 0x30DF111 VA: 0x30DF010
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30E29C0 Offset: 0x30E2AC1 VA: 0x30E29C0
	|-Dictionary<object, GradientColorKey>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30E64F0 Offset: 0x30E65F1 VA: 0x30E64F0
	|-Dictionary<object, Keyframe>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30E9BE0 Offset: 0x30E9CE1 VA: 0x30E9BE0
	|-Dictionary<object, LayerMask>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30ED850 Offset: 0x30ED951 VA: 0x30ED850
	|-Dictionary<object, Matrix4x4>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30F0F80 Offset: 0x30F1081 VA: 0x30F0F80
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x309FDB0 Offset: 0x309FEB1 VA: 0x309FDB0
	|-Dictionary<object, Quaternion>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30A3460 Offset: 0x30A3561 VA: 0x30A3460
	|-Dictionary<object, RangeInt>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30A6B80 Offset: 0x30A6C81 VA: 0x30A6B80
	|-Dictionary<object, Rect>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30AA270 Offset: 0x30AA371 VA: 0x30AA270
	|-Dictionary<object, RectInt>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30ADC20 Offset: 0x30ADD21 VA: 0x30ADC20
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30B15F0 Offset: 0x30B16F1 VA: 0x30B15F0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30B4D00 Offset: 0x30B4E01 VA: 0x30B4D00
	|-Dictionary<object, Vector2>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30B83B0 Offset: 0x30B84B1 VA: 0x30B83B0
	|-Dictionary<object, Vector2Int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30840A0 Offset: 0x30841A1 VA: 0x30840A0
	|-Dictionary<object, Vector3>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30877D0 Offset: 0x30878D1 VA: 0x30877D0
	|-Dictionary<object, Vector3Int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x308AEF0 Offset: 0x308AFF1 VA: 0x308AEF0
	|-Dictionary<object, Vector4>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x308E5A0 Offset: 0x308E6A1 VA: 0x308E5A0
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3091C10 Offset: 0x3091D11 VA: 0x3091C10
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3095250 Offset: 0x3095351 VA: 0x3095250
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3099030 Offset: 0x3099131 VA: 0x3099030
	|-Dictionary<float, CurveSample>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x309C6B0 Offset: 0x309C7B1 VA: 0x309C6B0
	|-Dictionary<float, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x319FC20 Offset: 0x319FD21 VA: 0x319FC20
	|-Dictionary<ushort, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31A31D0 Offset: 0x31A32D1 VA: 0x31A31D0
	|-Dictionary<uint, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31A6790 Offset: 0x31A6891 VA: 0x31A6790
	|-Dictionary<uint, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31A9DC0 Offset: 0x31A9EC1 VA: 0x31A9DC0
	|-Dictionary<uint, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31AD3E0 Offset: 0x31AD4E1 VA: 0x31AD3E0
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31B0A40 Offset: 0x31B0B41 VA: 0x31B0A40
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31B45A0 Offset: 0x31B46A1 VA: 0x31B45A0
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x31B80C0 Offset: 0x31B81C1 VA: 0x31B80C0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3030370 Offset: 0x3030471 VA: 0x3030370
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3033A30 Offset: 0x3033B31 VA: 0x3033A30
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3037060 Offset: 0x3037161 VA: 0x3037060
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x303AB60 Offset: 0x303AC61 VA: 0x303AB60
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x303E690 Offset: 0x303E791 VA: 0x303E690
	|-Dictionary<BoundsInt, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3041E00 Offset: 0x3041F01 VA: 0x3041E00
	|-Dictionary<Color, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3045480 Offset: 0x3045581 VA: 0x3045480
	|-Dictionary<Color32, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3048AA0 Offset: 0x3048BA1 VA: 0x3048AA0
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3067630 Offset: 0x3067731 VA: 0x3067630
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x306B130 Offset: 0x306B231 VA: 0x306B130
	|-Dictionary<GradientColorKey, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x306EE90 Offset: 0x306EF91 VA: 0x306EE90
	|-Dictionary<Keyframe, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3072540 Offset: 0x3072641 VA: 0x3072540
	|-Dictionary<LayerMask, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30764D0 Offset: 0x30765D1 VA: 0x30764D0
	|-Dictionary<Matrix4x4, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3079C20 Offset: 0x3079D21 VA: 0x3079C20
	|-Dictionary<IntVec3, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x307D370 Offset: 0x307D471 VA: 0x307D370
	|-Dictionary<Quaternion, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x30809B0 Offset: 0x3080AB1 VA: 0x30809B0
	|-Dictionary<RangeInt, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x304C1E0 Offset: 0x304C2E1 VA: 0x304C1E0
	|-Dictionary<Rect, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x304F880 Offset: 0x304F981 VA: 0x304F880
	|-Dictionary<RectInt, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3052EE0 Offset: 0x3052FE1 VA: 0x3052EE0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3056510 Offset: 0x3056611 VA: 0x3056510
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3059B90 Offset: 0x3059C91 VA: 0x3059B90
	|-Dictionary<Vector2, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x305D1B0 Offset: 0x305D2B1 VA: 0x305D1B0
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3060890 Offset: 0x3060991 VA: 0x3060890
	|-Dictionary<Vector3, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x3063FA0 Offset: 0x30640A1 VA: 0x3063FA0
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2E3D9D0 Offset: 0x2E3DAD1 VA: 0x2E3D9D0
	|-Dictionary<Vector4, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A19670 Offset: 0x2A19771 VA: 0x2A19670
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2A1CCD0 Offset: 0x2A1CDD1 VA: 0x2A1CCD0
	|-Dictionary<BitVector32Int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E2CD00 Offset: 0x2E2CE01 VA: 0x2E2CD00
	|-Dictionary<Season, Texture>.System.Collections.IDictionary.Contains
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F7BEF0 Offset: 0x2F7BFF1 VA: 0x2F7BEF0
	|-Dictionary<EventCheckId, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F7FF90 Offset: 0x2F80091 VA: 0x2F7FF90
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F83AF0 Offset: 0x2F83BF1 VA: 0x2F83AF0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F87210 Offset: 0x2F87311 VA: 0x2F87210
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F8A890 Offset: 0x2F8A991 VA: 0x2F8A890
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F8E600 Offset: 0x2F8E701 VA: 0x2F8E600
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F91D30 Offset: 0x2F91E31 VA: 0x2F91D30
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F95AA0 Offset: 0x2F95BA1 VA: 0x2F95AA0
	|-Dictionary<OrderSaveData, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D83990 Offset: 0x2D83A91 VA: 0x2D83990
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D876F0 Offset: 0x2D877F1 VA: 0x2D876F0
	|-Dictionary<Parameter, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D8AD90 Offset: 0x2D8AE91 VA: 0x2D8AD90
	|-Dictionary<bool, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D8E3B0 Offset: 0x2D8E4B1 VA: 0x2D8E3B0
	|-Dictionary<byte, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D919D0 Offset: 0x2D91AD1 VA: 0x2D919D0
	|-Dictionary<char, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D94FF0 Offset: 0x2D950F1 VA: 0x2D94FF0
	|-Dictionary<DateTime, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D98600 Offset: 0x2D98701 VA: 0x2D98600
	|-Dictionary<double, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D9BC80 Offset: 0x2D9BD81 VA: 0x2D9BC80
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D9F2A0 Offset: 0x2D9F3A1 VA: 0x2D9F2A0
	|-Dictionary<short, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D3DA40 Offset: 0x2D3DB41 VA: 0x2D3DA40
	|-Dictionary<int, CropDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D413C0 Offset: 0x2D414C1 VA: 0x2D413C0
	|-Dictionary<int, EffectDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D449A0 Offset: 0x2D44AA1 VA: 0x2D449A0
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D48640 Offset: 0x2D48741 VA: 0x2D48640
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D4BD30 Offset: 0x2D4BE31 VA: 0x2D4BD30
	|-Dictionary<int, MiningDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D4F320 Offset: 0x2D4F421 VA: 0x2D4F320
	|-Dictionary<int, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D528E0 Offset: 0x2D529E1 VA: 0x2D528E0
	|-Dictionary<int, char>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D55EA0 Offset: 0x2D55FA1 VA: 0x2D55EA0
	|-Dictionary<int, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2D59460 Offset: 0x2D59561 VA: 0x2D59460
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F5F620 Offset: 0x2F5F721 VA: 0x2F5F620
	|-Dictionary<int, long>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F62C40 Offset: 0x2F62D41 VA: 0x2F62C40
	|-Dictionary<int, object>.System.Collections.IDictionary.Contains
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F66740 Offset: 0x2F66841 VA: 0x2F66740
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F69E30 Offset: 0x2F69F31 VA: 0x2F69E30
	|-Dictionary<int, SceneInstance>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F6D4C0 Offset: 0x2F6D5C1 VA: 0x2F6D4C0
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F70C00 Offset: 0x2F70D01 VA: 0x2F70C00
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F74880 Offset: 0x2F74981 VA: 0x2F74880
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F783B0 Offset: 0x2F784B1 VA: 0x2F783B0
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E1F510 Offset: 0x2E1F611 VA: 0x2E1F510
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E22B00 Offset: 0x2E22C01 VA: 0x2E22B00
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E26180 Offset: 0x2E26281 VA: 0x2E26180
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E29740 Offset: 0x2E29841 VA: 0x2E29740
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E30310 Offset: 0x2E30411 VA: 0x2E30310
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E338E0 Offset: 0x2E339E1 VA: 0x2E338E0
	|-Dictionary<Int32Enum, float>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E36FA0 Offset: 0x2E370A1 VA: 0x2E36FA0
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E3A640 Offset: 0x2E3A741 VA: 0x2E3A640
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F99210 Offset: 0x2F99311 VA: 0x2F99210
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F9C830 Offset: 0x2F9C931 VA: 0x2F9C830
	|-Dictionary<long, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F9FEC0 Offset: 0x2F9FFC1 VA: 0x2F9FEC0
	|-Dictionary<Memory<object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FA36A0 Offset: 0x2FA37A1 VA: 0x2FA36A0
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FA75D0 Offset: 0x2FA76D1 VA: 0x2FA75D0
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FAB530 Offset: 0x2FAB631 VA: 0x2FAB530
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FAED40 Offset: 0x2FAEE41 VA: 0x2FAED40
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FB2A10 Offset: 0x2FB2B11 VA: 0x2FB2A10
	|-Dictionary<Nullable<Color>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F1D6F0 Offset: 0x2F1D7F1 VA: 0x2F1D6F0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F213D0 Offset: 0x2F214D1 VA: 0x2F213D0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F25100 Offset: 0x2F25201 VA: 0x2F25100
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F28910 Offset: 0x2F28A11 VA: 0x2F28910
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F2CE20 Offset: 0x2F2CF21 VA: 0x2F2CE20
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F30B50 Offset: 0x2F30C51 VA: 0x2F30B50
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F34440 Offset: 0x2F34541 VA: 0x2F34440
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F38120 Offset: 0x2F38221 VA: 0x2F38120
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F00E30 Offset: 0x2F00F31 VA: 0x2F00E30
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F04720 Offset: 0x2F04821 VA: 0x2F04720
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F07FF0 Offset: 0x2F080F1 VA: 0x2F07FF0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F0B840 Offset: 0x2F0B941 VA: 0x2F0B840
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F0F080 Offset: 0x2F0F181 VA: 0x2F0F080
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F12D50 Offset: 0x2F12E51 VA: 0x2F12D50
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F16440 Offset: 0x2F16541 VA: 0x2F16440
	|-Dictionary<object, BitVector32Int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2F19E20 Offset: 0x2F19F21 VA: 0x2F19E20
	|-Dictionary<object, EventCheckId>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FF6940 Offset: 0x2FF6A41 VA: 0x2FF6940
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FFA320 Offset: 0x2FFA421 VA: 0x2FFA320
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FFDA60 Offset: 0x2FFDB61 VA: 0x2FFDA60
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3001150 Offset: 0x3001251 VA: 0x3001150
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3004C80 Offset: 0x3004D81 VA: 0x3004C80
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30083C0 Offset: 0x30084C1 VA: 0x30083C0
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x300BF00 Offset: 0x300C001 VA: 0x300BF00
	|-Dictionary<object, OrderSaveData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x300F930 Offset: 0x300FA31 VA: 0x300F930
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DE1230 Offset: 0x2DE1331 VA: 0x2DE1230
	|-Dictionary<object, Parameter>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DE4920 Offset: 0x2DE4A21 VA: 0x2DE4920
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DE8000 Offset: 0x2DE8101 VA: 0x2DE8000
	|-Dictionary<object, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DEB6C0 Offset: 0x2DEB7C1 VA: 0x2DEB6C0
	|-Dictionary<object, byte>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DEED80 Offset: 0x2DEEE81 VA: 0x2DEED80
	|-Dictionary<object, char>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DF2430 Offset: 0x2DF2531 VA: 0x2DF2430
	|-Dictionary<object, DateTime>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DF5AF0 Offset: 0x2DF5BF1 VA: 0x2DF5AF0
	|-Dictionary<object, double>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DF91B0 Offset: 0x2DF92B1 VA: 0x2DF91B0
	|-Dictionary<object, short>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DFC870 Offset: 0x2DFC971 VA: 0x2DFC870
	|-Dictionary<object, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30BBE30 Offset: 0x30BBF31 VA: 0x30BBE30
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30BF4E0 Offset: 0x30BF5E1 VA: 0x30BF4E0
	|-Dictionary<object, long>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30C2C00 Offset: 0x30C2D01 VA: 0x30C2C00
	|-Dictionary<object, Memory<object>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30C63A0 Offset: 0x30C64A1 VA: 0x30C63A0
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30C9FF0 Offset: 0x30CA0F1 VA: 0x30C9FF0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30CDC50 Offset: 0x30CDD51 VA: 0x30CDC50
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30D1400 Offset: 0x30D1501 VA: 0x30D1400
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30D4EF0 Offset: 0x30D4FF1 VA: 0x30D4EF0
	|-Dictionary<object, Nullable<Color>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3013190 Offset: 0x3013291 VA: 0x3013190
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3016C70 Offset: 0x3016D71 VA: 0x3016C70
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x301A7A0 Offset: 0x301A8A1 VA: 0x301A7A0
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x301DF50 Offset: 0x301E051 VA: 0x301DF50
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3021F20 Offset: 0x3022021 VA: 0x3021F20
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3025A40 Offset: 0x3025B41 VA: 0x3025A40
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30292A0 Offset: 0x30293A1 VA: 0x30292A0
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x302CD90 Offset: 0x302CE91 VA: 0x302CD90
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FDA370 Offset: 0x2FDA471 VA: 0x2FDA370
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FDDBD0 Offset: 0x2FDDCD1 VA: 0x2FDDBD0
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FE1420 Offset: 0x2FE1521 VA: 0x2FE1420
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FE4C10 Offset: 0x2FE4D11 VA: 0x2FE4C10
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FE8400 Offset: 0x2FE8501 VA: 0x2FE8400
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FEBEF0 Offset: 0x2FEBFF1 VA: 0x2FEBEF0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FEF500 Offset: 0x2FEF601 VA: 0x2FEF500
	|-Dictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2FF2C20 Offset: 0x2FF2D21 VA: 0x2FF2C20
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DC16D0 Offset: 0x2DC17D1 VA: 0x2DC16D0
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DC4D90 Offset: 0x2DC4E91 VA: 0x2DC4D90
	|-Dictionary<object, sbyte>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DC8450 Offset: 0x2DC8551 VA: 0x2DC8450
	|-Dictionary<object, float>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DCBB10 Offset: 0x2DCBC11 VA: 0x2DCBB10
	|-Dictionary<object, ushort>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DCF1D0 Offset: 0x2DCF2D1 VA: 0x2DCF1D0
	|-Dictionary<object, uint>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DD2880 Offset: 0x2DD2981 VA: 0x2DD2880
	|-Dictionary<object, ulong>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DD6290 Offset: 0x2DD6391 VA: 0x2DD6290
	|-Dictionary<object, TransitionTables>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DD9C50 Offset: 0x2DD9D51 VA: 0x2DD9C50
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DDD610 Offset: 0x2DDD711 VA: 0x2DDD610
	|-Dictionary<object, BoundsInt>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30D85C0 Offset: 0x30D86C1 VA: 0x30D85C0
	|-Dictionary<object, Color32>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30DBCE0 Offset: 0x30DBDE1 VA: 0x30DBCE0
	|-Dictionary<object, Color>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30DF3D0 Offset: 0x30DF4D1 VA: 0x30DF3D0
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30E2D90 Offset: 0x30E2E91 VA: 0x30E2D90
	|-Dictionary<object, GradientColorKey>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30E68D0 Offset: 0x30E69D1 VA: 0x30E68D0
	|-Dictionary<object, Keyframe>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30E9FA0 Offset: 0x30EA0A1 VA: 0x30E9FA0
	|-Dictionary<object, LayerMask>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30EDC30 Offset: 0x30EDD31 VA: 0x30EDC30
	|-Dictionary<object, Matrix4x4>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30F1340 Offset: 0x30F1441 VA: 0x30F1340
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30A0170 Offset: 0x30A0271 VA: 0x30A0170
	|-Dictionary<object, Quaternion>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30A3820 Offset: 0x30A3921 VA: 0x30A3820
	|-Dictionary<object, RangeInt>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30A6F40 Offset: 0x30A7041 VA: 0x30A6F40
	|-Dictionary<object, Rect>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30AA630 Offset: 0x30AA731 VA: 0x30AA630
	|-Dictionary<object, RectInt>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30ADFF0 Offset: 0x30AE0F1 VA: 0x30ADFF0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30B19C0 Offset: 0x30B1AC1 VA: 0x30B19C0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30B50C0 Offset: 0x30B51C1 VA: 0x30B50C0
	|-Dictionary<object, Vector2>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30B8770 Offset: 0x30B8871 VA: 0x30B8770
	|-Dictionary<object, Vector2Int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3084460 Offset: 0x3084561 VA: 0x3084460
	|-Dictionary<object, Vector3>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3087B90 Offset: 0x3087C91 VA: 0x3087B90
	|-Dictionary<object, Vector3Int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x308B2B0 Offset: 0x308B3B1 VA: 0x308B2B0
	|-Dictionary<object, Vector4>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x308E940 Offset: 0x308EA41 VA: 0x308E940
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3091FD0 Offset: 0x30920D1 VA: 0x3091FD0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30955F0 Offset: 0x30956F1 VA: 0x30955F0
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3099420 Offset: 0x3099521 VA: 0x3099420
	|-Dictionary<float, CurveSample>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x309CA50 Offset: 0x309CB51 VA: 0x309CA50
	|-Dictionary<float, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x319FFC0 Offset: 0x31A00C1 VA: 0x319FFC0
	|-Dictionary<ushort, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31A3590 Offset: 0x31A3691 VA: 0x31A3590
	|-Dictionary<uint, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31A6B50 Offset: 0x31A6C51 VA: 0x31A6B50
	|-Dictionary<uint, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31AA160 Offset: 0x31AA261 VA: 0x31AA160
	|-Dictionary<uint, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31AD780 Offset: 0x31AD881 VA: 0x31AD780
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31B0E00 Offset: 0x31B0F01 VA: 0x31B0E00
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31B4990 Offset: 0x31B4A91 VA: 0x31B4990
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x31B84A0 Offset: 0x31B85A1 VA: 0x31B84A0
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3030750 Offset: 0x3030851 VA: 0x3030750
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3033DF0 Offset: 0x3033EF1 VA: 0x3033DF0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3037400 Offset: 0x3037501 VA: 0x3037400
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x303AF20 Offset: 0x303B021 VA: 0x303AF20
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x303EA50 Offset: 0x303EB51 VA: 0x303EA50
	|-Dictionary<BoundsInt, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30421C0 Offset: 0x30422C1 VA: 0x30421C0
	|-Dictionary<Color, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3045820 Offset: 0x3045921 VA: 0x3045820
	|-Dictionary<Color32, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3048E40 Offset: 0x3048F41 VA: 0x3048E40
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30679D0 Offset: 0x3067AD1 VA: 0x30679D0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x306B4F0 Offset: 0x306B5F1 VA: 0x306B4F0
	|-Dictionary<GradientColorKey, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x306F260 Offset: 0x306F361 VA: 0x306F260
	|-Dictionary<Keyframe, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30728E0 Offset: 0x30729E1 VA: 0x30728E0
	|-Dictionary<LayerMask, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30768B0 Offset: 0x30769B1 VA: 0x30768B0
	|-Dictionary<Matrix4x4, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3079FD0 Offset: 0x307A0D1 VA: 0x3079FD0
	|-Dictionary<IntVec3, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x307D730 Offset: 0x307D831 VA: 0x307D730
	|-Dictionary<Quaternion, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3080D50 Offset: 0x3080E51 VA: 0x3080D50
	|-Dictionary<RangeInt, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x304C5A0 Offset: 0x304C6A1 VA: 0x304C5A0
	|-Dictionary<Rect, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x304FC20 Offset: 0x304FD21 VA: 0x304FC20
	|-Dictionary<RectInt, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30532A0 Offset: 0x30533A1 VA: 0x30532A0
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x30568B0 Offset: 0x30569B1 VA: 0x30568B0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3059F30 Offset: 0x305A031 VA: 0x3059F30
	|-Dictionary<Vector2, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x305D550 Offset: 0x305D651 VA: 0x305D550
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3060C40 Offset: 0x3060D41 VA: 0x3060C40
	|-Dictionary<Vector3, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3064350 Offset: 0x3064451 VA: 0x3064350
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2E3DD90 Offset: 0x2E3DE91 VA: 0x2E3DD90
	|-Dictionary<Vector4, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A19750 Offset: 0x2A19851 VA: 0x2A19750
	|-Dictionary<JSONDeserialization.TaskField, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2A1CDB0 Offset: 0x2A1CEB1 VA: 0x2A1CDB0
	|-Dictionary<BitVector32Int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E2CDE0 Offset: 0x2E2CEE1 VA: 0x2E2CDE0
	|-Dictionary<Season, Texture>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F7BFD0 Offset: 0x2F7C0D1 VA: 0x2F7BFD0
	|-Dictionary<EventCheckId, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F80090 Offset: 0x2F80191 VA: 0x2F80090
	|-Dictionary<FarmManager.RF4_CROP_STATE, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F83BD0 Offset: 0x2F83CD1 VA: 0x2F83BD0
	|-Dictionary<FarmManager.RF4_CROP_STATE_INFO, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F872F0 Offset: 0x2F873F1 VA: 0x2F872F0
	|-Dictionary<FarmManager.RF4_MCROP_INFO, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F8A970 Offset: 0x2F8AA71 VA: 0x2F8A970
	|-Dictionary<FarmManager.RF4_SOIL_INFO, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F8E6F0 Offset: 0x2F8E7F1 VA: 0x2F8E6F0
	|-Dictionary<MonsterHutSaveData, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F91E10 Offset: 0x2F91F11 VA: 0x2F91E10
	|-Dictionary<OrderLotterySaveParameter, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F95B90 Offset: 0x2F95C91 VA: 0x2F95B90
	|-Dictionary<OrderSaveData, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D83A70 Offset: 0x2D83B71 VA: 0x2D83A70
	|-Dictionary<OrderSaveParameter, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D877D0 Offset: 0x2D878D1 VA: 0x2D877D0
	|-Dictionary<Parameter, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D8AE70 Offset: 0x2D8AF71 VA: 0x2D8AE70
	|-Dictionary<bool, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D8E490 Offset: 0x2D8E591 VA: 0x2D8E490
	|-Dictionary<byte, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D91AB0 Offset: 0x2D91BB1 VA: 0x2D91AB0
	|-Dictionary<char, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D950D0 Offset: 0x2D951D1 VA: 0x2D950D0
	|-Dictionary<DateTime, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D986E0 Offset: 0x2D987E1 VA: 0x2D986E0
	|-Dictionary<double, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D9BD60 Offset: 0x2D9BE61 VA: 0x2D9BD60
	|-Dictionary<Guid, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D9F380 Offset: 0x2D9F481 VA: 0x2D9F380
	|-Dictionary<short, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D3DB20 Offset: 0x2D3DC21 VA: 0x2D3DB20
	|-Dictionary<int, CropDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D414A0 Offset: 0x2D415A1 VA: 0x2D414A0
	|-Dictionary<int, EffectDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D44A80 Offset: 0x2D44B81 VA: 0x2D44A80
	|-Dictionary<int, GimmickLayoutDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D48720 Offset: 0x2D48821 VA: 0x2D48720
	|-Dictionary<int, MineTypeDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D4BE10 Offset: 0x2D4BF11 VA: 0x2D4BE10
	|-Dictionary<int, MiningDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D4F400 Offset: 0x2D4F501 VA: 0x2D4F400
	|-Dictionary<int, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D529C0 Offset: 0x2D52AC1 VA: 0x2D529C0
	|-Dictionary<int, char>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D55F80 Offset: 0x2D56081 VA: 0x2D55F80
	|-Dictionary<int, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2D59540 Offset: 0x2D59641 VA: 0x2D59540
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F5F700 Offset: 0x2F5F801 VA: 0x2F5F700
	|-Dictionary<int, long>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F62D20 Offset: 0x2F62E21 VA: 0x2F62D20
	|-Dictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, TerrainUtility.TerrainMap>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F66820 Offset: 0x2F66921 VA: 0x2F66820
	|-Dictionary<int, DiagnosticEvent>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F69F10 Offset: 0x2F6A011 VA: 0x2F69F10
	|-Dictionary<int, SceneInstance>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F6D5A0 Offset: 0x2F6D6A1 VA: 0x2F6D5A0
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F70CE0 Offset: 0x2F70DE1 VA: 0x2F70CE0
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F74960 Offset: 0x2F74A61 VA: 0x2F74960
	|-Dictionary<Int32Enum, MonsterDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F78490 Offset: 0x2F78591 VA: 0x2F78490
	|-Dictionary<Int32Enum, MonsterFootStepEventDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E1F5F0 Offset: 0x2E1F6F1 VA: 0x2E1F5F0
	|-Dictionary<Int32Enum, PartnerNPCWeaponBehaviorDataTable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E22BE0 Offset: 0x2E22CE1 VA: 0x2E22BE0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E26260 Offset: 0x2E26361 VA: 0x2E26260
	|-Dictionary<Int32Enum, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E29820 Offset: 0x2E29921 VA: 0x2E29820
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E303F0 Offset: 0x2E304F1 VA: 0x2E303F0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E339C0 Offset: 0x2E33AC1 VA: 0x2E339C0
	|-Dictionary<Int32Enum, float>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E37080 Offset: 0x2E37181 VA: 0x2E37080
	|-Dictionary<Int32Enum, ValueTuple<object, object>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E3A720 Offset: 0x2E3A821 VA: 0x2E3A720
	|-Dictionary<Int32Enum, ValueTuple<float, float>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F992F0 Offset: 0x2F993F1 VA: 0x2F992F0
	|-Dictionary<Int32Enum, TutorialUnlockFlagData>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F9C910 Offset: 0x2F9CA11 VA: 0x2F9C910
	|-Dictionary<long, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F9FFA0 Offset: 0x2FA00A1 VA: 0x2F9FFA0
	|-Dictionary<Memory<object>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FA3780 Offset: 0x2FA3881 VA: 0x2FA3780
	|-Dictionary<Nullable<Int32Enum>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FA76D0 Offset: 0x2FA77D1 VA: 0x2FA76D0
	|-Dictionary<Nullable<Bounds>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FAB630 Offset: 0x2FAB731 VA: 0x2FAB630
	|-Dictionary<Nullable<BoundsInt>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FAEE20 Offset: 0x2FAEF21 VA: 0x2FAEE20
	|-Dictionary<Nullable<Color32>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FB2B10 Offset: 0x2FB2C11 VA: 0x2FB2B10
	|-Dictionary<Nullable<Color>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F1D7E0 Offset: 0x2F1D8E1 VA: 0x2F1D7E0
	|-Dictionary<Nullable<GradientAlphaKey>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F214D0 Offset: 0x2F215D1 VA: 0x2F214D0
	|-Dictionary<Nullable<GradientColorKey>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F25200 Offset: 0x2F25301 VA: 0x2F25200
	|-Dictionary<Nullable<Keyframe>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F289F0 Offset: 0x2F28AF1 VA: 0x2F289F0
	|-Dictionary<Nullable<LayerMask>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F2CF30 Offset: 0x2F2D031 VA: 0x2F2CF30
	|-Dictionary<Nullable<Matrix4x4>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F30C50 Offset: 0x2F30D51 VA: 0x2F30C50
	|-Dictionary<Nullable<Quaternion>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F34530 Offset: 0x2F34631 VA: 0x2F34530
	|-Dictionary<Nullable<RangeInt>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F38220 Offset: 0x2F38321 VA: 0x2F38220
	|-Dictionary<Nullable<Rect>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F00F30 Offset: 0x2F01031 VA: 0x2F00F30
	|-Dictionary<Nullable<RectInt>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F04810 Offset: 0x2F04911 VA: 0x2F04810
	|-Dictionary<Nullable<Vector2>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F080E0 Offset: 0x2F081E1 VA: 0x2F080E0
	|-Dictionary<Nullable<Vector2Int>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F0B920 Offset: 0x2F0BA21 VA: 0x2F0B920
	|-Dictionary<Nullable<Vector3>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F0F160 Offset: 0x2F0F261 VA: 0x2F0F160
	|-Dictionary<Nullable<Vector3Int>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F12E50 Offset: 0x2F12F51 VA: 0x2F12E50
	|-Dictionary<Nullable<Vector4>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F16520 Offset: 0x2F16621 VA: 0x2F16520
	|-Dictionary<object, BitVector32Int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2F19F00 Offset: 0x2F1A001 VA: 0x2F19F00
	|-Dictionary<object, EventCheckId>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FF6A20 Offset: 0x2FF6B21 VA: 0x2FF6A20
	|-Dictionary<object, FarmManager.RF4_CROP_STATE>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FFA400 Offset: 0x2FFA501 VA: 0x2FFA400
	|-Dictionary<object, FarmManager.RF4_CROP_STATE_INFO>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FFDB40 Offset: 0x2FFDC41 VA: 0x2FFDB40
	|-Dictionary<object, FarmManager.RF4_MCROP_INFO>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3001230 Offset: 0x3001331 VA: 0x3001230
	|-Dictionary<object, FarmManager.RF4_SOIL_INFO>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3004D60 Offset: 0x3004E61 VA: 0x3004D60
	|-Dictionary<object, MonsterHutSaveData>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30084A0 Offset: 0x30085A1 VA: 0x30084A0
	|-Dictionary<object, OrderLotterySaveParameter>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x300BFE0 Offset: 0x300C0E1 VA: 0x300BFE0
	|-Dictionary<object, OrderSaveData>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x300FA10 Offset: 0x300FB11 VA: 0x300FA10
	|-Dictionary<object, OrderSaveParameter>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DE1310 Offset: 0x2DE1411 VA: 0x2DE1310
	|-Dictionary<object, Parameter>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DE4A00 Offset: 0x2DE4B01 VA: 0x2DE4A00
	|-Dictionary<object, NumberControl.ValueRange>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DE80E0 Offset: 0x2DE81E1 VA: 0x2DE80E0
	|-Dictionary<object, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DEB7A0 Offset: 0x2DEB8A1 VA: 0x2DEB7A0
	|-Dictionary<object, byte>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DEEE60 Offset: 0x2DEEF61 VA: 0x2DEEE60
	|-Dictionary<object, char>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DF2510 Offset: 0x2DF2611 VA: 0x2DF2510
	|-Dictionary<object, DateTime>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DF5BD0 Offset: 0x2DF5CD1 VA: 0x2DF5BD0
	|-Dictionary<object, double>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DF9290 Offset: 0x2DF9391 VA: 0x2DF9290
	|-Dictionary<object, short>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DFC950 Offset: 0x2DFCA51 VA: 0x2DFC950
	|-Dictionary<object, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30BBF10 Offset: 0x30BC011 VA: 0x30BBF10
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30BF5C0 Offset: 0x30BF6C1 VA: 0x30BF5C0
	|-Dictionary<object, long>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30C2CE0 Offset: 0x30C2DE1 VA: 0x30C2CE0
	|-Dictionary<object, Memory<object>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30C6480 Offset: 0x30C6581 VA: 0x30C6480
	|-Dictionary<object, Nullable<Int32Enum>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30CA0D0 Offset: 0x30CA1D1 VA: 0x30CA0D0
	|-Dictionary<object, Nullable<Bounds>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30CDD30 Offset: 0x30CDE31 VA: 0x30CDD30
	|-Dictionary<object, Nullable<BoundsInt>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30D14E0 Offset: 0x30D15E1 VA: 0x30D14E0
	|-Dictionary<object, Nullable<Color32>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30D4FD0 Offset: 0x30D50D1 VA: 0x30D4FD0
	|-Dictionary<object, Nullable<Color>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3013270 Offset: 0x3013371 VA: 0x3013270
	|-Dictionary<object, Nullable<GradientAlphaKey>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3016D50 Offset: 0x3016E51 VA: 0x3016D50
	|-Dictionary<object, Nullable<GradientColorKey>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x301A880 Offset: 0x301A981 VA: 0x301A880
	|-Dictionary<object, Nullable<Keyframe>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x301E030 Offset: 0x301E131 VA: 0x301E030
	|-Dictionary<object, Nullable<LayerMask>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3022000 Offset: 0x3022101 VA: 0x3022000
	|-Dictionary<object, Nullable<Matrix4x4>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3025B20 Offset: 0x3025C21 VA: 0x3025B20
	|-Dictionary<object, Nullable<Quaternion>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3029380 Offset: 0x3029481 VA: 0x3029380
	|-Dictionary<object, Nullable<RangeInt>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x302CE70 Offset: 0x302CF71 VA: 0x302CE70
	|-Dictionary<object, Nullable<Rect>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FDA450 Offset: 0x2FDA551 VA: 0x2FDA450
	|-Dictionary<object, Nullable<RectInt>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FDDCB0 Offset: 0x2FDDDB1 VA: 0x2FDDCB0
	|-Dictionary<object, Nullable<Vector2>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FE1500 Offset: 0x2FE1601 VA: 0x2FE1500
	|-Dictionary<object, Nullable<Vector2Int>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FE4CF0 Offset: 0x2FE4DF1 VA: 0x2FE4CF0
	|-Dictionary<object, Nullable<Vector3>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FE84E0 Offset: 0x2FE85E1 VA: 0x2FE84E0
	|-Dictionary<object, Nullable<Vector3Int>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FEBFD0 Offset: 0x2FEC0D1 VA: 0x2FEBFD0
	|-Dictionary<object, Nullable<Vector4>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FEF5E0 Offset: 0x2FEF6E1 VA: 0x2FEF5E0
	|-Dictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2FF2D00 Offset: 0x2FF2E01 VA: 0x2FF2D00
	|-Dictionary<object, ReadOnlyMemory<object>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DC17B0 Offset: 0x2DC18B1 VA: 0x2DC17B0
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DC4E70 Offset: 0x2DC4F71 VA: 0x2DC4E70
	|-Dictionary<object, sbyte>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DC8530 Offset: 0x2DC8631 VA: 0x2DC8530
	|-Dictionary<object, float>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DCBBF0 Offset: 0x2DCBCF1 VA: 0x2DCBBF0
	|-Dictionary<object, ushort>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DCF2B0 Offset: 0x2DCF3B1 VA: 0x2DCF2B0
	|-Dictionary<object, uint>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DD2960 Offset: 0x2DD2A61 VA: 0x2DD2960
	|-Dictionary<object, ulong>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DD6370 Offset: 0x2DD6471 VA: 0x2DD6370
	|-Dictionary<object, TransitionTables>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DD9D30 Offset: 0x2DD9E31 VA: 0x2DD9D30
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DDD6F0 Offset: 0x2DDD7F1 VA: 0x2DDD6F0
	|-Dictionary<object, BoundsInt>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30D86A0 Offset: 0x30D87A1 VA: 0x30D86A0
	|-Dictionary<object, Color32>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30DBDC0 Offset: 0x30DBEC1 VA: 0x30DBDC0
	|-Dictionary<object, Color>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30DF4B0 Offset: 0x30DF5B1 VA: 0x30DF4B0
	|-Dictionary<object, GradientAlphaKey>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30E2E70 Offset: 0x30E2F71 VA: 0x30E2E70
	|-Dictionary<object, GradientColorKey>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30E69B0 Offset: 0x30E6AB1 VA: 0x30E69B0
	|-Dictionary<object, Keyframe>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30EA080 Offset: 0x30EA181 VA: 0x30EA080
	|-Dictionary<object, LayerMask>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30EDD10 Offset: 0x30EDE11 VA: 0x30EDD10
	|-Dictionary<object, Matrix4x4>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30F1420 Offset: 0x30F1521 VA: 0x30F1420
	|-Dictionary<object, Playable>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30A0250 Offset: 0x30A0351 VA: 0x30A0250
	|-Dictionary<object, Quaternion>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30A3900 Offset: 0x30A3A01 VA: 0x30A3900
	|-Dictionary<object, RangeInt>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30A7020 Offset: 0x30A7121 VA: 0x30A7020
	|-Dictionary<object, Rect>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30AA710 Offset: 0x30AA811 VA: 0x30AA710
	|-Dictionary<object, RectInt>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30AE0D0 Offset: 0x30AE1D1 VA: 0x30AE0D0
	|-Dictionary<object, AsyncOperationHandle>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30B1AA0 Offset: 0x30B1BA1 VA: 0x30B1AA0
	|-Dictionary<object, AsyncOperationHandle<object>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30B51A0 Offset: 0x30B52A1 VA: 0x30B51A0
	|-Dictionary<object, Vector2>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30B8850 Offset: 0x30B8951 VA: 0x30B8850
	|-Dictionary<object, Vector2Int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3084540 Offset: 0x3084641 VA: 0x3084540
	|-Dictionary<object, Vector3>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3087C70 Offset: 0x3087D71 VA: 0x3087C70
	|-Dictionary<object, Vector3Int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x308B390 Offset: 0x308B491 VA: 0x308B390
	|-Dictionary<object, Vector4>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x308EA20 Offset: 0x308EB21 VA: 0x308EA20
	|-Dictionary<ReadOnlyMemory<object>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30920B0 Offset: 0x30921B1 VA: 0x30920B0
	|-Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30956D0 Offset: 0x30957D1 VA: 0x30956D0
	|-Dictionary<sbyte, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3099500 Offset: 0x3099601 VA: 0x3099500
	|-Dictionary<float, CurveSample>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x309CB30 Offset: 0x309CC31 VA: 0x309CB30
	|-Dictionary<float, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31A00A0 Offset: 0x31A01A1 VA: 0x31A00A0
	|-Dictionary<ushort, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31A3670 Offset: 0x31A3771 VA: 0x31A3670
	|-Dictionary<uint, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31A6C30 Offset: 0x31A6D31 VA: 0x31A6C30
	|-Dictionary<uint, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31AA240 Offset: 0x31AA341 VA: 0x31AA240
	|-Dictionary<uint, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31AD860 Offset: 0x31AD961 VA: 0x31AD860
	|-Dictionary<ulong, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31B0EE0 Offset: 0x31B0FE1 VA: 0x31B0EE0
	|-Dictionary<EdgeKeyByHash, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31B4A70 Offset: 0x31B4B71 VA: 0x31B4A70
	|-Dictionary<EdgeKeyByHash, CapEdge>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x31B8580 Offset: 0x31B8681 VA: 0x31B8580
	|-Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3030830 Offset: 0x3030931 VA: 0x3030830
	|-Dictionary<EdgeKeyByIndex, ClippedEdge>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3033ED0 Offset: 0x3033FD1 VA: 0x3033ED0
	|-Dictionary<MeshDataConnectivity.Face, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30374E0 Offset: 0x30375E1 VA: 0x30374E0
	|-Dictionary<MeshDataConnectivity.Face, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x303B000 Offset: 0x303B101 VA: 0x303B000
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x303EB30 Offset: 0x303EC31 VA: 0x303EB30
	|-Dictionary<BoundsInt, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30422A0 Offset: 0x30423A1 VA: 0x30422A0
	|-Dictionary<Color, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3045900 Offset: 0x3045A01 VA: 0x3045900
	|-Dictionary<Color32, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3048F20 Offset: 0x3049021 VA: 0x3048F20
	|-Dictionary<TerrainUtility.TerrainMap.TileCoord, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3067AB0 Offset: 0x3067BB1 VA: 0x3067AB0
	|-Dictionary<GradientAlphaKey, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x306B5D0 Offset: 0x306B6D1 VA: 0x306B5D0
	|-Dictionary<GradientColorKey, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x306F350 Offset: 0x306F451 VA: 0x306F350
	|-Dictionary<Keyframe, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30729C0 Offset: 0x3072AC1 VA: 0x30729C0
	|-Dictionary<LayerMask, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x30769A0 Offset: 0x3076AA1 VA: 0x30769A0
	|-Dictionary<Matrix4x4, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x307A0B0 Offset: 0x307A1B1 VA: 0x307A0B0
	|-Dictionary<IntVec3, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x307D810 Offset: 0x307D911 VA: 0x307D810
	|-Dictionary<Quaternion, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3080E30 Offset: 0x3080F31 VA: 0x3080E30
	|-Dictionary<RangeInt, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x304C680 Offset: 0x304C781 VA: 0x304C680
	|-Dictionary<Rect, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x304FD00 Offset: 0x304FE01 VA: 0x304FD00
	|-Dictionary<RectInt, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3053380 Offset: 0x3053481 VA: 0x3053380
	|-Dictionary<StyleSheetCache.SheetHandleKey, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3056990 Offset: 0x3056A91 VA: 0x3056990
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x305A010 Offset: 0x305A111 VA: 0x305A010
	|-Dictionary<Vector2, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x305D630 Offset: 0x305D731 VA: 0x305D630
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3060D20 Offset: 0x3060E21 VA: 0x3060D20
	|-Dictionary<Vector3, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3064430 Offset: 0x3064531 VA: 0x3064430
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2E3DE70 Offset: 0x2E3DF71 VA: 0x2E3DE70
	|-Dictionary<Vector4, object>.System.Collections.IDictionary.GetEnumerator
	*/
}

