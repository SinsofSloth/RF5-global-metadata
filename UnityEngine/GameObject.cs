[NativeHeaderAttribute] // RVA: 0xC6AD0 Offset: 0xC6BD1 VA: 0xC6AD0
[UsedByNativeCodeAttribute] // RVA: 0xC6AD0 Offset: 0xC6BD1 VA: 0xC6AD0
[ExcludeFromPresetAttribute] // RVA: 0xC6AD0 Offset: 0xC6BD1 VA: 0xC6AD0
public sealed class GameObject : Object // TypeDefIndex: 3014
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	[ObsoleteAttribute] // RVA: 0xDF040 Offset: 0xDF141 VA: 0xDF040
	public bool active { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	internal bool isStaticBatchable { get; }
	public string tag { get; set; }
	public Scene scene { get; }
	public ulong sceneCullingMask { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD5FB0 Offset: 0xD60B1 VA: 0xD5FB0
	// RVA: 0x2B0CF50 Offset: 0x2B0D051 VA: 0x2B0CF50
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2266000 Offset: 0x2266101 VA: 0x2266000
	|-GameObject.GetComponent<ActorImporter>
	|-GameObject.GetComponent<AdvDialogControl>
	|-GameObject.GetComponent<AdvMain>
	|-GameObject.GetComponent<AdvStaffRollControl>
	|-GameObject.GetComponent<AracneFlatWeb>
	|-GameObject.GetComponent<Area>
	|-GameObject.GetComponent<AudmuraCrystal>
	|-GameObject.GetComponent<AutomaticLOD>
	|-GameObject.GetComponent<BeanController>
	|-GameObject.GetComponent<BeanSowingScore>
	|-GameObject.GetComponent<BitBase>
	|-GameObject.GetComponent<BossStageManager>
	|-GameObject.GetComponent<BrushInteractionInterface>
	|-GameObject.GetComponent<BuildIconControl>
	|-GameObject.GetComponent<BulletBase>
	|-GameObject.GetComponent<ButtonLinker>
	|-GameObject.GetComponent<Character>
	|-GameObject.GetComponent<CharacterBase>
	|-GameObject.GetComponent<CharacterModel>
	|-GameObject.GetComponent<ChopInteractionInterface>
	|-GameObject.GetComponent<CinemachineBrain>
	|-GameObject.GetComponent<CinemachineVirtualCameraBase>
	|-GameObject.GetComponent<ColliderStreamerManager>
	|-GameObject.GetComponent<CombinedMesh>
	|-GameObject.GetComponent<CursorLinkConnector>
	|-GameObject.GetComponent<CursorLinker>
	|-GameObject.GetComponent<DoorController>
	|-GameObject.GetComponent<DualWorkTimelineLinker>
	|-GameObject.GetComponent<EmotionEffectController>
	|-GameObject.GetComponent<EventStartPoint>
	|-GameObject.GetComponent<EyeMouthAnimate>
	|-GameObject.GetComponent<FallIce>
	|-GameObject.GetComponent<FallRock>
	|-GameObject.GetComponent<FarmDrugInteractionInterface>
	|-GameObject.GetComponent<FestivalSnowball>
	|-GameObject.GetComponent<FestivalUI>
	|-GameObject.GetComponent<FieldTreasureBox>
	|-GameObject.GetComponent<FishingUI>
	|-GameObject.GetComponent<FlyingNimbus>
	|-GameObject.GetComponent<FracturedChunk>
	|-GameObject.GetComponent<FracturedObject>
	|-GameObject.GetComponent<FxPro>
	|-GameObject.GetComponent<GateController>
	|-GameObject.GetComponent<GateEnemyModelContainer>
	|-GameObject.GetComponent<GimmickBreakeMoveCloudConditions>
	|-GameObject.GetComponent<GimmickBreakeObject>
	|-GameObject.GetComponent<HUDFadeMove>
	|-GameObject.GetComponent<IPooledObejct>
	|-GameObject.GetComponent<InteractionCollider>
	|-GameObject.GetComponent<InteractionInterface>
	|-GameObject.GetComponent<ItemEquip>
	|-GameObject.GetComponent<FurnitureBreakConditions>
	|-GameObject.GetComponent<PlayerItemFurniture2>
	|-GameObject.GetComponent<ItemInteractionInterface>
	|-GameObject.GetComponent<LastBossBone>
	|-GameObject.GetComponent<LifeCycleAdvMain>
	|-GameObject.GetComponent<MapShaderController>
	|-GameObject.GetComponent<MeshSimplify>
	|-GameObject.GetComponent<MiniMapShaderController>
	|-GameObject.GetComponent<MiningPoint>
	|-GameObject.GetComponent<MonsterControllerBase>
	|-GameObject.GetComponent<MonsterModel>
	|-GameObject.GetComponent<MonsterProjectileActionScriptsController>
	|-GameObject.GetComponent<MoveCloud>
	|-GameObject.GetComponent<MovieRoomSkip>
	|-GameObject.GetComponent<MushroomSpore>
	|-GameObject.GetComponent<NpcController>
	|-GameObject.GetComponent<NpcMoveControl>
	|-GameObject.GetComponent<NpcPatrolPoint>
	|-GameObject.GetComponent<ObjectPositions>
	|-GameObject.GetComponent<OnGroundItem>
	|-GameObject.GetComponent<PlayerCharacterController>
	|-GameObject.GetComponent<PlowInteractionInterface>
	|-GameObject.GetComponent<PotInteractionInterface>
	|-GameObject.GetComponent<RF5Streamer>
	|-GameObject.GetComponent<UIOneSceneAnim>
	|-GameObject.GetComponent<RestaurantTimelineLinker>
	|-GameObject.GetComponent<ReviatanIcePillar>
	|-GameObject.GetComponent<RideChair>
	|-GameObject.GetComponent<CharacterThirdPerson>
	|-GameObject.GetComponent<FullBodyBipedIK>
	|-GameObject.GetComponent<GrounderFBBIK>
	|-GameObject.GetComponent<IKJBoneParams>
	|-GameObject.GetComponent<RuneBalls>
	|-GameObject.GetComponent<ScissorsInteractionInterface>
	|-GameObject.GetComponent<Shake>
	|-GameObject.GetComponent<SimpleTriggerEventDispatcher>
	|-GameObject.GetComponent<SlashInteractionInterface>
	|-GameObject.GetComponent<SmashInteractionInterface>
	|-GameObject.GetComponent<SnowmanBox>
	|-GameObject.GetComponent<SowInteractionInterface>
	|-GameObject.GetComponent<SpcController>
	|-GameObject.GetComponent<SpcMonsterController>
	|-GameObject.GetComponent<ExtrusionSegment>
	|-GameObject.GetComponent<MeshBender>
	|-GameObject.GetComponent<SpriteSymbolObject>
	|-GameObject.GetComponent<Streamer>
	|-GameObject.GetComponent<TMP_InputField>
	|-GameObject.GetComponent<TMP_SubMesh>
	|-GameObject.GetComponent<ThrowController>
	|-GameObject.GetComponent<TimelineControl>
	|-GameObject.GetComponent<TitleCanvasControl>
	|-GameObject.GetComponent<ToolInteractionInterface>
	|-GameObject.GetComponent<UICraftSuccess>
	|-GameObject.GetComponent<UIMainManagerAttachObject>
	|-GameObject.GetComponent<UISubtitleMovie>
	|-GameObject.GetComponent<UISubtitleTitle>
	|-GameObject.GetComponent<UISubtitleVoiceComment>
	|-GameObject.GetComponent<DynamicsNull>
	|-GameObject.GetComponent<SpringBone>
	|-GameObject.GetComponent<UltimateRopeLink>
	|-GameObject.GetComponent<NavMeshAgent>
	|-GameObject.GetComponent<NavMeshObstacle>
	|-GameObject.GetComponent<Animation>
	|-GameObject.GetComponent<IConstraint>
	|-GameObject.GetComponent<ParentConstraint>
	|-GameObject.GetComponent<Animator>
	|-GameObject.GetComponent<AudioSource>
	|-GameObject.GetComponent<BoxCollider2D>
	|-GameObject.GetComponent<BoxCollider>
	|-GameObject.GetComponent<Camera>
	|-GameObject.GetComponent<Canvas>
	|-GameObject.GetComponent<CanvasGroup>
	|-GameObject.GetComponent<CanvasRenderer>
	|-GameObject.GetComponent<CapsuleCollider>
	|-GameObject.GetComponent<CharacterController>
	|-GameObject.GetComponent<CircleCollider2D>
	|-GameObject.GetComponent<Collider>
	|-GameObject.GetComponent<ConfigurableJoint>
	|-GameObject.GetComponent<EventTrigger>
	|-GameObject.GetComponent<Joint>
	|-GameObject.GetComponent<LODGroup>
	|-GameObject.GetComponent<Light>
	|-GameObject.GetComponent<Mesh>
	|-GameObject.GetComponent<MeshCollider>
	|-GameObject.GetComponent<MeshFilter>
	|-GameObject.GetComponent<MeshRenderer>
	|-GameObject.GetComponent<ParticleSystem>
	|-GameObject.GetComponent<PlayableDirector>
	|-GameObject.GetComponent<RectTransform>
	|-GameObject.GetComponent<Renderer>
	|-GameObject.GetComponent<DiagnosticEventCollector>
	|-GameObject.GetComponent<Rigidbody2D>
	|-GameObject.GetComponent<Rigidbody>
	|-GameObject.GetComponent<SkinnedMeshRenderer>
	|-GameObject.GetComponent<SphereCollider>
	|-GameObject.GetComponent<SpriteRenderer>
	|-GameObject.GetComponent<Transform>
	|-GameObject.GetComponent<Button>
	|-GameObject.GetComponent<Dropdown>
	|-GameObject.GetComponent<Graphic>
	|-GameObject.GetComponent<Image>
	|-GameObject.GetComponent<InputField>
	|-GameObject.GetComponent<Mask>
	|-GameObject.GetComponent<ScrollRect>
	|-GameObject.GetComponent<Scrollbar>
	|-GameObject.GetComponent<Slider>
	|-GameObject.GetComponent<Text>
	|-GameObject.GetComponent<Toggle>
	|-GameObject.GetComponent<Bloom>
	|-GameObject.GetComponent<WantedField>
	|-GameObject.GetComponent<WarpIconControl>
	|-GameObject.GetComponent<WoodGolemRocketPunchController>
	|-GameObject.GetComponent<WoodenBox>
	|-GameObject.GetComponent<WorldMover>
	|-GameObject.GetComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xD5FF0 Offset: 0xD60F1 VA: 0xD5FF0
	[TypeInferenceRuleAttribute] // RVA: 0xD5FF0 Offset: 0xD60F1 VA: 0xD5FF0
	// RVA: 0x2B01490 Offset: 0x2B01591 VA: 0x2B01490
	public Component GetComponent(Type type) { }

	[NativeWritableSelfAttribute] // RVA: 0xD6060 Offset: 0xD6161 VA: 0xD6060
	[FreeFunctionAttribute] // RVA: 0xD6060 Offset: 0xD6161 VA: 0xD6060
	// RVA: 0x2B0CFA0 Offset: 0x2B0D0A1 VA: 0x2B0CFA0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunctionAttribute] // RVA: 0xD60D0 Offset: 0xD61D1 VA: 0xD60D0
	// RVA: 0x2B0D000 Offset: 0x2B0D101 VA: 0x2B0D000
	internal Component GetComponentByName(string type) { }

	// RVA: 0x2B0D050 Offset: 0x2B0D151 VA: 0x2B0D050
	public Component GetComponent(string type) { }

	[FreeFunctionAttribute] // RVA: 0xD6120 Offset: 0xD6221 VA: 0xD6120
	[TypeInferenceRuleAttribute] // RVA: 0xD6120 Offset: 0xD6221 VA: 0xD6120
	// RVA: 0x2B015D0 Offset: 0x2B016D1 VA: 0x2B015D0
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6190 Offset: 0xD6291 VA: 0xD6190
	// RVA: 0x2B0D0A0 Offset: 0x2B0D1A1 VA: 0x2B0D0A0
	public Component GetComponentInChildren(Type type) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD61B0 Offset: 0xD62B1 VA: 0xD61B0
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22660B0 Offset: 0x22661B1 VA: 0x22660B0
	|-GameObject.GetComponentInChildren<CharacterBase>
	|-GameObject.GetComponentInChildren<FarmController>
	|-GameObject.GetComponentInChildren<FesMinimapControl>
	|-GameObject.GetComponentInChildren<WeatherEnclosure>
	|-GameObject.GetComponentInChildren<FxPro>
	|-GameObject.GetComponentInChildren<GateController>
	|-GameObject.GetComponentInChildren<HUDBadStatusIconDisp>
	|-GameObject.GetComponentInChildren<RollingRock>
	|-GameObject.GetComponentInChildren<TMP_Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<SpringManager>
	|-GameObject.GetComponentInChildren<Animation>
	|-GameObject.GetComponentInChildren<Animator>
	|-GameObject.GetComponentInChildren<Camera>
	|-GameObject.GetComponentInChildren<MeshRenderer>
	|-GameObject.GetComponentInChildren<RectTransform>
	|-GameObject.GetComponentInChildren<Renderer>
	|-GameObject.GetComponentInChildren<SkinnedMeshRenderer>
	|-GameObject.GetComponentInChildren<Terrain>
	|-GameObject.GetComponentInChildren<Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<RawImage>
	|-GameObject.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22660E0 Offset: 0x22661E1 VA: 0x22660E0
	|-GameObject.GetComponentInChildren<Animator>
	|-GameObject.GetComponentInChildren<ParticleSystem>
	|-GameObject.GetComponentInChildren<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xD61C0 Offset: 0xD62C1 VA: 0xD61C0
	[FreeFunctionAttribute] // RVA: 0xD61C0 Offset: 0xD62C1 VA: 0xD61C0
	// RVA: 0x2B016C0 Offset: 0x2B017C1 VA: 0x2B016C0
	public Component GetComponentInParent(Type type) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22661D0 Offset: 0x22662D1 VA: 0x22661D0
	|-GameObject.GetComponentInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xD6230 Offset: 0xD6331 VA: 0xD6230
	// RVA: 0x2B0D100 Offset: 0x2B0D201 VA: 0x2B0D100
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x2B0D190 Offset: 0x2B0D291 VA: 0x2B0D190
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F65F0 Offset: 0x34F66F1 VA: 0x34F65F0
	|-GameObject.GetComponents<AdvCharaAnim>
	|-GameObject.GetComponents<Behavior>
	|-GameObject.GetComponents<BehaviorTree>
	|-GameObject.GetComponents<DynamicBone>
	|-GameObject.GetComponents<DynamicsNull>
	|-GameObject.GetComponents<Simplifier>
	|-GameObject.GetComponents<Behaviour>
	|-GameObject.GetComponents<Collider>
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<IAnimationWindowPreview>
	|-GameObject.GetComponents<INotificationReceiver>
	|-GameObject.GetComponents<object>
	*/

	// RVA: 0x2B0D250 Offset: 0x2B0D351 VA: 0x2B0D250
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E4D10 Offset: 0x23E4E11 VA: 0x23E4D10
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<Component>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0xD6280 Offset: 0xD6381 VA: 0xD6280
	// RVA: 0x2B0D2C0 Offset: 0x2B0D3C1 VA: 0x2B0D2C0
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x2B0D380 Offset: 0x2B0D481 VA: 0x2B0D380
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6720 Offset: 0x34F6821 VA: 0x34F6720
	|-GameObject.GetComponentsInChildren<UIButtonLinkerInScrollBox>
	|-GameObject.GetComponentsInChildren<DynamicsNull>
	|-GameObject.GetComponentsInChildren<SpringBone>
	|-GameObject.GetComponentsInChildren<SpringCapsuleCollider>
	|-GameObject.GetComponentsInChildren<SpringManager>
	|-GameObject.GetComponentsInChildren<SpringPanelCollider>
	|-GameObject.GetComponentsInChildren<SpringSphereCollider>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	|-GameObject.GetComponentsInChildren<Transform>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E4DC0 Offset: 0x23E4EC1 VA: 0x23E4DC0
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F66F0 Offset: 0x34F67F1 VA: 0x34F66F0
	|-GameObject.GetComponentsInChildren<BodyPartsCollision>
	|-GameObject.GetComponentsInChildren<CellController>
	|-GameObject.GetComponentsInChildren<ParticleDestroy>
	|-GameObject.GetComponentsInChildren<StartPoint>
	|-GameObject.GetComponentsInChildren<NavMeshObstacle>
	|-GameObject.GetComponentsInChildren<Animator>
	|-GameObject.GetComponentsInChildren<Collider>
	|-GameObject.GetComponentsInChildren<MonoBehaviour>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	|-GameObject.GetComponentsInChildren<Transform>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E4E80 Offset: 0x23E4F81 VA: 0x23E4E80
	|-GameObject.GetComponentsInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0xD6290 Offset: 0xD6391 VA: 0xD6290
	// RVA: 0x2B0D440 Offset: 0x2B0D541 VA: 0x2B0D440
	public Component[] GetComponentsInParent(Type type) { }

	// RVA: 0x2B0D500 Offset: 0x2B0D601 VA: 0x2B0D500
	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E4EB0 Offset: 0x23E4FB1 VA: 0x23E4EB0
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<Canvas>
	|-GameObject.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6850 Offset: 0x34F6951 VA: 0x34F6850
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6820 Offset: 0x34F6921 VA: 0x34F6820
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D0F20 Offset: 0x22D1021 VA: 0x22D0F20
	|-GameObject.TryGetComponent<object>
	|-GameObject.TryGetComponent<MeshCollider>
	|-GameObject.TryGetComponent<MeshFilter>
	|-GameObject.TryGetComponent<MeshRenderer>
	*/

	// RVA: 0x2B0D5C0 Offset: 0x2B0D6C1 VA: 0x2B0D5C0
	public bool TryGetComponent(Type type, out Component component) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD62A0 Offset: 0xD63A1 VA: 0xD62A0
	[FreeFunctionAttribute] // RVA: 0xD62A0 Offset: 0xD63A1 VA: 0xD62A0
	// RVA: 0x2B0D680 Offset: 0x2B0D781 VA: 0x2B0D680
	internal Component TryGetComponentInternal(Type type) { }

	[NativeWritableSelfAttribute] // RVA: 0xD6310 Offset: 0xD6411 VA: 0xD6310
	[FreeFunctionAttribute] // RVA: 0xD6310 Offset: 0xD6411 VA: 0xD6310
	// RVA: 0x2B0D6D0 Offset: 0x2B0D7D1 VA: 0x2B0D6D0
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x2B0D730 Offset: 0x2B0D831 VA: 0x2B0D730
	public static GameObject FindWithTag(string tag) { }

	// RVA: 0x2B0D7D0 Offset: 0x2B0D8D1 VA: 0x2B0D7D0
	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	// RVA: 0x2B0D8A0 Offset: 0x2B0D9A1 VA: 0x2B0D8A0
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x2B0D970 Offset: 0x2B0DA71 VA: 0x2B0D970
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xD6380 Offset: 0xD6481 VA: 0xD6380
	// RVA: 0x2B0DA40 Offset: 0x2B0DB41 VA: 0x2B0DA40
	internal Component AddComponentInternal(string className) { }

	[FreeFunctionAttribute] // RVA: 0xD63D0 Offset: 0xD64D1 VA: 0xD63D0
	// RVA: 0x2B0DA90 Offset: 0x2B0DB91 VA: 0x2B0DA90
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRuleAttribute] // RVA: 0xD6420 Offset: 0xD6521 VA: 0xD6420
	// RVA: 0x2B0DAE0 Offset: 0x2B0DBE1 VA: 0x2B0DAE0
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265EF0 Offset: 0x2265FF1 VA: 0x2265EF0
	|-GameObject.AddComponent<AS_MagicController>
	|-GameObject.AddComponent<AracneBehaviorController>
	|-GameObject.AddComponent<AriesBehaviorController>
	|-GameObject.AddComponent<AssetCounter>
	|-GameObject.AddComponent<AttackCollision>
	|-GameObject.AddComponent<AudmuraBehaviorController>
	|-GameObject.AddComponent<AutomaticLOD>
	|-GameObject.AddComponent<BaffamoFestivalController>
	|-GameObject.AddComponent<BasiliskBehaviorController>
	|-GameObject.AddComponent<BehaviorManager>
	|-GameObject.AddComponent<CerberusBehaviorController>
	|-GameObject.AddComponent<CheckDynamicCollision>
	|-GameObject.AddComponent<CinemachineComposer>
	|-GameObject.AddComponent<CinemachineOrbitalTransposer>
	|-GameObject.AddComponent<CinemachinePipeline>
	|-GameObject.AddComponent<CinemachineVirtualCamera>
	|-GameObject.AddComponent<GlobalCoroutine>
	|-GameObject.AddComponent<DOTweenComponent>
	|-GameObject.AddComponent<DeadtreeBehaviorController>
	|-GameObject.AddComponent<DeadtreeBullet>
	|-GameObject.AddComponent<DelayDestroy>
	|-GameObject.AddComponent<DieTimer>
	|-GameObject.AddComponent<DragonSisterBehaviorController>
	|-GameObject.AddComponent<EmotionController>
	|-GameObject.AddComponent<FarmMonsterBehaviorController>
	|-GameObject.AddComponent<FishObject>
	|-GameObject.AddComponent<FishObjectPool>
	|-GameObject.AddComponent<FracturedChunk>
	|-GameObject.AddComponent<LightningRenderer>
	|-GameObject.AddComponent<RainSplashRenderer>
	|-GameObject.AddComponent<GandageBehaviorController>
	|-GameObject.AddComponent<GansekiDragonBehaviorController>
	|-GameObject.AddComponent<GimmickMagicArrowShot>
	|-GameObject.AddComponent<GimmickThunderboltShot>
	|-GameObject.AddComponent<HarinezumiBehaviorController>
	|-GameObject.AddComponent<HasibirokouBehaviorController>
	|-GameObject.AddComponent<HekatonkeilBehaviorController>
	|-GameObject.AddComponent<HoldItemController>
	|-GameObject.AddComponent<HumanLookIK>
	|-GameObject.AddComponent<InosisiBehaviorController>
	|-GameObject.AddComponent<FurnitureBreakConditions>
	|-GameObject.AddComponent<KamereonBehaviorController>
	|-GameObject.AddComponent<KrakenBehaviorController>
	|-GameObject.AddComponent<KurageBehaviorController>
	|-GameObject.AddComponent<KurageBubbleBehavior>
	|-GameObject.AddComponent<KurageLightningBehavior>
	|-GameObject.AddComponent<KyubiBehaviorController>
	|-GameObject.AddComponent<LastBossBehaviorController>
	|-GameObject.AddComponent<MeshSimplify>
	|-GameObject.AddComponent<MonsterDoctor>
	|-GameObject.AddComponent<MonsterProjectileActionScriptsController>
	|-GameObject.AddComponent<MummyBehaviorController>
	|-GameObject.AddComponent<NearCameraTarget>
	|-GameObject.AddComponent<OuroborosBehaviorController>
	|-GameObject.AddComponent<OuroborosTornado>
	|-GameObject.AddComponent<ParticleDestroy>
	|-GameObject.AddComponent<PartnerMonsterBehaviorController>
	|-GameObject.AddComponent<PartnerNPCBehaviorController>
	|-GameObject.AddComponent<PlayerSnowball>
	|-GameObject.AddComponent<ProjectileBulletBase>
	|-GameObject.AddComponent<PadSwitch>
	|-GameObject.AddComponent<BGMController>
	|-GameObject.AddComponent<EnvironmentSoundController>
	|-GameObject.AddComponent<SEController>
	|-GameObject.AddComponent<VoiceController>
	|-GameObject.AddComponent<MotionBlur>
	|-GameObject.AddComponent<UnityAudioCapture>
	|-GameObject.AddComponent<ReviatanBehaviorController>
	|-GameObject.AddComponent<FullBodyBipedIK>
	|-GameObject.AddComponent<GrounderFBBIK>
	|-GameObject.AddComponent<IKJBoneParams>
	|-GameObject.AddComponent<VRIKRootController>
	|-GameObject.AddComponent<TriggerEventBroadcaster>
	|-GameObject.AddComponent<ProfilerLateUpdateListener>
	|-GameObject.AddComponent<SasquatchBehaviorController>
	|-GameObject.AddComponent<SceneTransitionManager>
	|-GameObject.AddComponent<SearchSphereCollider>
	|-GameObject.AddComponent<SimpleHpBar>
	|-GameObject.AddComponent<SkillLevelUpEffectController>
	|-GameObject.AddComponent<SkullDragonBehaviorController>
	|-GameObject.AddComponent<SoulBehavior>
	|-GameObject.AddComponent<StateMachineWorker>
	|-GameObject.AddComponent<StatusEffectPointConstraint>
	|-GameObject.AddComponent<TMP_Dropdown.DropdownItem>
	|-GameObject.AddComponent<TMP_Dropdown>
	|-GameObject.AddComponent<TMP_InputField>
	|-GameObject.AddComponent<TMP_SpriteAnimator>
	|-GameObject.AddComponent<TMP_SubMeshUI>
	|-GameObject.AddComponent<TextMeshProUGUI>
	|-GameObject.AddComponent<TutorialManager>
	|-GameObject.AddComponent<DynamicsNull>
	|-GameObject.AddComponent<SpringBone>
	|-GameObject.AddComponent<SpringBonePivot>
	|-GameObject.AddComponent<SpringCapsuleCollider>
	|-GameObject.AddComponent<SpringManager>
	|-GameObject.AddComponent<SpringPanelCollider>
	|-GameObject.AddComponent<SpringSphereCollider>
	|-GameObject.AddComponent<Simplifier>
	|-GameObject.AddComponent<UltimateRopeLink>
	|-GameObject.AddComponent<AudioSource>
	|-GameObject.AddComponent<BoxCollider>
	|-GameObject.AddComponent<Camera>
	|-GameObject.AddComponent<Canvas>
	|-GameObject.AddComponent<CanvasGroup>
	|-GameObject.AddComponent<CanvasRenderer>
	|-GameObject.AddComponent<CapsuleCollider>
	|-GameObject.AddComponent<ConfigurableJoint>
	|-GameObject.AddComponent<BaseInput>
	|-GameObject.AddComponent<EventSystem>
	|-GameObject.AddComponent<EventTrigger>
	|-GameObject.AddComponent<StandaloneInputModule>
	|-GameObject.AddComponent<FixedJoint>
	|-GameObject.AddComponent<FlareLayer>
	|-GameObject.AddComponent<LODGroup>
	|-GameObject.AddComponent<LineRenderer>
	|-GameObject.AddComponent<MeshCollider>
	|-GameObject.AddComponent<MeshFilter>
	|-GameObject.AddComponent<MeshRenderer>
	|-GameObject.AddComponent<ProBuilderMesh>
	|-GameObject.AddComponent<RectTransform>
	|-GameObject.AddComponent<Renderer>
	|-GameObject.AddComponent<Rigidbody>
	|-GameObject.AddComponent<SkinnedMeshRenderer>
	|-GameObject.AddComponent<SphereCollider>
	|-GameObject.AddComponent<Button>
	|-GameObject.AddComponent<Dropdown.DropdownItem>
	|-GameObject.AddComponent<GraphicRaycaster>
	|-GameObject.AddComponent<Image>
	|-GameObject.AddComponent<LayoutElement>
	|-GameObject.AddComponent<Mask>
	|-GameObject.AddComponent<RawImage>
	|-GameObject.AddComponent<RectMask2D>
	|-GameObject.AddComponent<ScrollRect>
	|-GameObject.AddComponent<Scrollbar>
	|-GameObject.AddComponent<Toggle>
	|-GameObject.AddComponent<WoodGolemBehaviorController>
	|-GameObject.AddComponent<YadokariBehaviorController>
	|-GameObject.AddComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xD6440 Offset: 0xD6541 VA: 0xD6440
	// RVA: 0x2B0DB30 Offset: 0x2B0DC31 VA: 0x2B0DB30
	public Transform get_transform() { }

	// RVA: 0x2B0DB80 Offset: 0x2B0DC81 VA: 0x2B0DB80
	public int get_layer() { }

	// RVA: 0x2B0DBD0 Offset: 0x2B0DCD1 VA: 0x2B0DBD0
	public void set_layer(int value) { }

	[NativeMethodAttribute] // RVA: 0xD6490 Offset: 0xD6591 VA: 0xD6490
	// RVA: 0x2B0DC20 Offset: 0x2B0DD21 VA: 0x2B0DC20
	public bool get_active() { }

	[NativeMethodAttribute] // RVA: 0xD64E0 Offset: 0xD65E1 VA: 0xD64E0
	// RVA: 0x2B0DC70 Offset: 0x2B0DD71 VA: 0x2B0DC70
	public void set_active(bool value) { }

	[NativeMethodAttribute] // RVA: 0xD6530 Offset: 0xD6631 VA: 0xD6530
	// RVA: 0x2B0DCC0 Offset: 0x2B0DDC1 VA: 0x2B0DCC0
	public void SetActive(bool value) { }

	[NativeMethodAttribute] // RVA: 0xD6580 Offset: 0xD6681 VA: 0xD6580
	// RVA: 0x2B0DD10 Offset: 0x2B0DE11 VA: 0x2B0DD10
	public bool get_activeSelf() { }

	[NativeMethodAttribute] // RVA: 0xD65D0 Offset: 0xD66D1 VA: 0xD65D0
	// RVA: 0x2B0DD60 Offset: 0x2B0DE61 VA: 0x2B0DD60
	public bool get_activeInHierarchy() { }

	[ObsoleteAttribute] // RVA: 0xD6620 Offset: 0xD6721 VA: 0xD6620
	[NativeMethodAttribute] // RVA: 0xD6620 Offset: 0xD6721 VA: 0xD6620
	// RVA: 0x2B0DDB0 Offset: 0x2B0DEB1 VA: 0x2B0DDB0
	public void SetActiveRecursively(bool state) { }

	[NativeMethodAttribute] // RVA: 0xD6690 Offset: 0xD6791 VA: 0xD6690
	// RVA: 0x2B0DE00 Offset: 0x2B0DF01 VA: 0x2B0DE00
	public bool get_isStatic() { }

	[NativeMethodAttribute] // RVA: 0xD66E0 Offset: 0xD67E1 VA: 0xD66E0
	// RVA: 0x2B0DE50 Offset: 0x2B0DF51 VA: 0x2B0DE50
	public void set_isStatic(bool value) { }

	[NativeMethodAttribute] // RVA: 0xD6730 Offset: 0xD6831 VA: 0xD6730
	// RVA: 0x2B0DEA0 Offset: 0x2B0DFA1 VA: 0x2B0DEA0
	internal bool get_isStaticBatchable() { }

	[FreeFunctionAttribute] // RVA: 0xD6780 Offset: 0xD6881 VA: 0xD6780
	// RVA: 0x2B01860 Offset: 0x2B01961 VA: 0x2B01860
	public string get_tag() { }

	[FreeFunctionAttribute] // RVA: 0xD67D0 Offset: 0xD68D1 VA: 0xD67D0
	// RVA: 0x2B01940 Offset: 0x2B01A41 VA: 0x2B01940
	public void set_tag(string value) { }

	[FreeFunctionAttribute] // RVA: 0xD6820 Offset: 0xD6921 VA: 0xD6820
	// RVA: 0x2B01A20 Offset: 0x2B01B21 VA: 0x2B01A20
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xD6870 Offset: 0xD6971 VA: 0xD6870
	// RVA: 0x2B0D780 Offset: 0x2B0D881 VA: 0x2B0D780
	public static GameObject FindGameObjectWithTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xD68C0 Offset: 0xD69C1 VA: 0xD68C0
	// RVA: 0x2B0DEF0 Offset: 0x2B0DFF1 VA: 0x2B0DEF0
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xD6910 Offset: 0xD6A11 VA: 0xD6910
	// RVA: 0x2B0D830 Offset: 0x2B0D931 VA: 0x2B0D830
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD6960 Offset: 0xD6A61 VA: 0xD6960
	// RVA: 0x2B0DF40 Offset: 0x2B0E041 VA: 0x2B0DF40
	public void SendMessageUpwards(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD6970 Offset: 0xD6A71 VA: 0xD6970
	// RVA: 0x2B0DFA0 Offset: 0x2B0E0A1 VA: 0x2B0DFA0
	public void SendMessageUpwards(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xD6980 Offset: 0xD6A81 VA: 0xD6980
	// RVA: 0x2B0D900 Offset: 0x2B0DA01 VA: 0x2B0D900
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD69D0 Offset: 0xD6AD1 VA: 0xD69D0
	// RVA: 0x2B0E000 Offset: 0x2B0E101 VA: 0x2B0E000
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD69E0 Offset: 0xD6AE1 VA: 0xD69E0
	// RVA: 0x2B0E060 Offset: 0x2B0E161 VA: 0x2B0E060
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xD69F0 Offset: 0xD6AF1 VA: 0xD69F0
	// RVA: 0x2B0D9D0 Offset: 0x2B0DAD1 VA: 0x2B0D9D0
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD6A40 Offset: 0xD6B41 VA: 0xD6A40
	// RVA: 0x2B0E0C0 Offset: 0x2B0E1C1 VA: 0x2B0E0C0
	public void BroadcastMessage(string methodName, object parameter) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD6A50 Offset: 0xD6B51 VA: 0xD6A50
	// RVA: 0x2B0E120 Offset: 0x2B0E221 VA: 0x2B0E120
	public void BroadcastMessage(string methodName) { }

	// RVA: 0x2B0E180 Offset: 0x2B0E281 VA: 0x2B0E180
	public void .ctor(string name) { }

	// RVA: 0x2B0E270 Offset: 0x2B0E371 VA: 0x2B0E270
	public void .ctor() { }

	// RVA: 0x2B0E310 Offset: 0x2B0E411 VA: 0x2B0E310
	public void .ctor(string name, Type[] components) { }

	[FreeFunctionAttribute] // RVA: 0xD6A60 Offset: 0xD6B61 VA: 0xD6A60
	// RVA: 0x2B0E220 Offset: 0x2B0E321 VA: 0x2B0E220
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunctionAttribute] // RVA: 0xD6AB0 Offset: 0xD6BB1 VA: 0xD6AB0
	// RVA: 0x2B0E440 Offset: 0x2B0E541 VA: 0x2B0E440
	public static GameObject Find(string name) { }

	[FreeFunctionAttribute] // RVA: 0xD6B00 Offset: 0xD6C01 VA: 0xD6B00
	// RVA: 0x2B0E490 Offset: 0x2B0E591 VA: 0x2B0E490
	public Scene get_scene() { }

	[FreeFunctionAttribute] // RVA: 0xD6B50 Offset: 0xD6C51 VA: 0xD6B50
	// RVA: 0x2B0E540 Offset: 0x2B0E641 VA: 0x2B0E540
	public ulong get_sceneCullingMask() { }

	// RVA: 0x2B0E590 Offset: 0x2B0E691 VA: 0x2B0E590
	public GameObject get_gameObject() { }

	// RVA: 0x2B0E4F0 Offset: 0x2B0E5F1 VA: 0x2B0E4F0
	private void get_scene_Injected(out Scene ret) { }
}

