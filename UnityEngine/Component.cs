[NativeClassAttribute] // RVA: 0xC6920 Offset: 0xC6A21 VA: 0xC6920
[NativeHeaderAttribute] // RVA: 0xC6920 Offset: 0xC6A21 VA: 0xC6920
[RequiredByNativeCodeAttribute] // RVA: 0xC6920 Offset: 0xC6A21 VA: 0xC6920
public class Component : Object // TypeDefIndex: 3007
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public string tag { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD5D70 Offset: 0xD5E71 VA: 0xD5D70
	// RVA: 0x2B01360 Offset: 0x2B01461 VA: 0x2B01360
	public Transform get_transform() { }

	[FreeFunctionAttribute] // RVA: 0xD5DC0 Offset: 0xD5EC1 VA: 0xD5DC0
	// RVA: 0x2B013B0 Offset: 0x2B014B1 VA: 0x2B013B0
	public GameObject get_gameObject() { }

	[TypeInferenceRuleAttribute] // RVA: 0xD5E10 Offset: 0xD5F11 VA: 0xD5E10
	// RVA: 0x2B01400 Offset: 0x2B01501 VA: 0x2B01400
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xD5E30 Offset: 0xD5F31 VA: 0xD5E30
	// RVA: 0x2B014E0 Offset: 0x2B015E1 VA: 0x2B014E0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22659B0 Offset: 0x2265AB1 VA: 0x22659B0
	|-Component.GetComponent<ActionScriptControllerBase>
	|-Component.GetComponent<ActorController>
	|-Component.GetComponent<ActorImporter>
	|-Component.GetComponent<ActorVoiceController>
	|-Component.GetComponent<AreaFogAreaTrigger>
	|-Component.GetComponent<AssetCounter>
	|-Component.GetComponent<AudmuraCrystal>
	|-Component.GetComponent<AvoidController>
	|-Component.GetComponent<BadStatusEffectController>
	|-Component.GetComponent<BattleModeController>
	|-Component.GetComponent<BehaviorTree>
	|-Component.GetComponent<BulletColliderBase>
	|-Component.GetComponent<BulletHandCuffs>
	|-Component.GetComponent<ButtonLinker>
	|-Component.GetComponent<CharaFaceController>
	|-Component.GetComponent<Character>
	|-Component.GetComponent<CharacterBase>
	|-Component.GetComponent<CharacterModel>
	|-Component.GetComponent<CharacterMovement>
	|-Component.GetComponent<CharacterNearCullingController>
	|-Component.GetComponent<ChoiceButton>
	|-Component.GetComponent<CinemachinePipeline>
	|-Component.GetComponent<CinemachineSmoothPath>
	|-Component.GetComponent<CinemachineTargetGroup>
	|-Component.GetComponent<CinemachineVirtualCamera>
	|-Component.GetComponent<CinemachineVirtualCameraBase>
	|-Component.GetComponent<ICinemachineTargetGroup>
	|-Component.GetComponent<CursorLinkConnector>
	|-Component.GetComponent<CursorLinker>
	|-Component.GetComponent<DamageActionController>
	|-Component.GetComponent<DateSlotControl>
	|-Component.GetComponent<EmotionController>
	|-Component.GetComponent<EscapeController>
	|-Component.GetComponent<EyeMouthAnimate>
	|-Component.GetComponent<Fade>
	|-Component.GetComponent<CellController>
	|-Component.GetComponent<FishAnimation>
	|-Component.GetComponent<WkiAnimation>
	|-Component.GetComponent<WkiController>
	|-Component.GetComponent<FocusInterface>
	|-Component.GetComponent<FootSteps>
	|-Component.GetComponent<FracturedChunk>
	|-Component.GetComponent<FracturedObject>
	|-Component.GetComponent<RotateBody>
	|-Component.GetComponent<TimeOfDayController>
	|-Component.GetComponent<GimmickSingleSwitch>
	|-Component.GetComponent<GimmickSwitchDoor>
	|-Component.GetComponent<HUDCharactorStatus>
	|-Component.GetComponent<HUDPlayerMoney>
	|-Component.GetComponent<HandCuffsController>
	|-Component.GetComponent<HoldableInterface>
	|-Component.GetComponent<HudPadLock>
	|-Component.GetComponent<HumanController>
	|-Component.GetComponent<HumanEquipment>
	|-Component.GetComponent<HumanItemHold>
	|-Component.GetComponent<HumanLookIK>
	|-Component.GetComponent<HumanMagicMotionController>
	|-Component.GetComponent<HumanModel>
	|-Component.GetComponent<IFade>
	|-Component.GetComponent<IPlayerCamera>
	|-Component.GetComponent<IconLoading>
	|-Component.GetComponent<FurnitureShadow>
	|-Component.GetComponent<PlayerItemFurniture2>
	|-Component.GetComponent<StorageFurniture>
	|-Component.GetComponent<ItemIconLoader>
	|-Component.GetComponent<ItemInteractionInterface>
	|-Component.GetComponent<ItemTextDiscription>
	|-Component.GetComponent<KamereonShaderControl>
	|-Component.GetComponent<LazyController>
	|-Component.GetComponent<MagicMotionController>
	|-Component.GetComponent<MapFieldCollider>
	|-Component.GetComponent<MeshSimplify>
	|-Component.GetComponent<MiningPoint>
	|-Component.GetComponent<MobController>
	|-Component.GetComponent<MonsterControllerBase>
	|-Component.GetComponent<MonsterProjectileActionScriptsController>
	|-Component.GetComponent<MonsterVoiceController>
	|-Component.GetComponent<MoveCloud>
	|-Component.GetComponent<MoviePlayer>
	|-Component.GetComponent<MummyHand>
	|-Component.GetComponent<NonFocusButton>
	|-Component.GetComponent<NpcController>
	|-Component.GetComponent<NpcPatrolPoint>
	|-Component.GetComponent<ObjectPositions>
	|-Component.GetComponent<OnGroundItem>
	|-Component.GetComponent<OrderCursorEvent>
	|-Component.GetComponent<ParticleDestroy>
	|-Component.GetComponent<PlayerInput>
	|-Component.GetComponent<ProjectileBulletBase>
	|-Component.GetComponent<UISubtitleHUDBlock>
	|-Component.GetComponent<UIEMCustomizeCategoryBlock>
	|-Component.GetComponent<RecipeCloseItemPageButton>
	|-Component.GetComponent<RecipeGroupDispBlock>
	|-Component.GetComponent<RecipeIdDispBlock>
	|-Component.GetComponent<RecipeOpenItemPageButton>
	|-Component.GetComponent<MotionBlur>
	|-Component.GetComponent<UnityAudioCapture>
	|-Component.GetComponent<RestraintController>
	|-Component.GetComponent<RideController>
	|-Component.GetComponent<AnimatorController3rdPerson>
	|-Component.GetComponent<CharacterBase>
	|-Component.GetComponent<FPSAiming>
	|-Component.GetComponent<AimIK>
	|-Component.GetComponent<BipedIK>
	|-Component.GetComponent<FullBodyBipedIK>
	|-Component.GetComponent<GrounderBipedIK>
	|-Component.GetComponent<IK>
	|-Component.GetComponent<InteractionSystem>
	|-Component.GetComponent<InteractionTarget>
	|-Component.GetComponent<InteractionTrigger>
	|-Component.GetComponent<LookAtIK>
	|-Component.GetComponent<Poser>
	|-Component.GetComponent<Recoil>
	|-Component.GetComponent<RotationLimit>
	|-Component.GetComponent<VRIK>
	|-Component.GetComponent<VRIKRootController>
	|-Component.GetComponent<TriggerEventBroadcaster>
	|-Component.GetComponent<StyleComponent>
	|-Component.GetComponent<SimpleHpBar>
	|-Component.GetComponent<SimpleTriggerEventDispatcher>
	|-Component.GetComponent<SkullDragonController>
	|-Component.GetComponent<SlowStateController>
	|-Component.GetComponent<SpcController>
	|-Component.GetComponent<Spline>
	|-Component.GetComponent<TCP2_Demo_View>
	|-Component.GetComponent<TMP_SpriteAnimator>
	|-Component.GetComponent<TMP_Text>
	|-Component.GetComponent<TextMeshPro>
	|-Component.GetComponent<TeleportCheckFunc>
	|-Component.GetComponent<ThrowController>
	|-Component.GetComponent<ToolInteractionInterface>
	|-Component.GetComponent<UIBatchSlot>
	|-Component.GetComponent<UIEquipSlot>
	|-Component.GetComponent<UIItemBoxMenu>
	|-Component.GetComponent<UIItemSlot>
	|-Component.GetComponent<UIObjectLoadingCheck>
	|-Component.GetComponent<UIOnOffAnimate>
	|-Component.GetComponent<SpringBonePivot>
	|-Component.GetComponent<UltimateRope>
	|-Component.GetComponent<NavMeshAgent>
	|-Component.GetComponent<Animation>
	|-Component.GetComponent<PositionConstraint>
	|-Component.GetComponent<Animator>
	|-Component.GetComponent<AudioListener>
	|-Component.GetComponent<AudioSource>
	|-Component.GetComponent<BoxCollider>
	|-Component.GetComponent<Camera>
	|-Component.GetComponent<Canvas>
	|-Component.GetComponent<CanvasGroup>
	|-Component.GetComponent<CanvasRenderer>
	|-Component.GetComponent<CapsuleCollider>
	|-Component.GetComponent<CharacterController>
	|-Component.GetComponent<Collider2D>
	|-Component.GetComponent<Collider>
	|-Component.GetComponent<EventSystem>
	|-Component.GetComponent<EventTrigger>
	|-Component.GetComponent<Joint>
	|-Component.GetComponent<MeshCollider>
	|-Component.GetComponent<MeshFilter>
	|-Component.GetComponent<MeshRenderer>
	|-Component.GetComponent<ParticleSystem>
	|-Component.GetComponent<PlayableDirector>
	|-Component.GetComponent<ProBuilderMesh>
	|-Component.GetComponent<Renderer>
	|-Component.GetComponent<Rigidbody2D>
	|-Component.GetComponent<Rigidbody>
	|-Component.GetComponent<SkinnedMeshRenderer>
	|-Component.GetComponent<Skybox>
	|-Component.GetComponent<SphereCollider>
	|-Component.GetComponent<Terrain>
	|-Component.GetComponent<Transform>
	|-Component.GetComponent<CanvasScaler>
	|-Component.GetComponent<Graphic>
	|-Component.GetComponent<ILayoutController>
	|-Component.GetComponent<Image>
	|-Component.GetComponent<LayoutElement>
	|-Component.GetComponent<LayoutGroup>
	|-Component.GetComponent<Mask>
	|-Component.GetComponent<RawImage>
	|-Component.GetComponent<RectMask2D>
	|-Component.GetComponent<ScrollRect>
	|-Component.GetComponent<Scrollbar>
	|-Component.GetComponent<Selectable>
	|-Component.GetComponent<Shadow>
	|-Component.GetComponent<Slider>
	|-Component.GetComponent<Text>
	|-Component.GetComponent<PlanarReflection>
	|-Component.GetComponent<WaterBase>
	|-Component.GetComponent<V_SMC_Handler>
	|-Component.GetComponent<WoodGolemController>
	|-Component.GetComponent<object>
	|-Component.GetComponent<RectTransform>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D08D0 Offset: 0x22D09D1 VA: 0x22D08D0
	|-Component.TryGetComponent<CinemachineVirtualCameraBase>
	|-Component.TryGetComponent<object>
	|-Component.TryGetComponent<Camera>
	|-Component.TryGetComponent<MeshFilter>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xD5E70 Offset: 0xD5F71 VA: 0xD5E70
	// RVA: 0x2B01540 Offset: 0x2B01641 VA: 0x2B01540
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265B50 Offset: 0x2265C51 VA: 0x2265B50
	|-Component.GetComponentInChildren<CharacterModel>
	|-Component.GetComponentInChildren<HUDDamageHpBar>
	|-Component.GetComponentInChildren<HumanModel>
	|-Component.GetComponentInChildren<LastBossBone>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0xD5E90 Offset: 0xD5F91 VA: 0xD5E90
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265A60 Offset: 0x2265B61 VA: 0x2265A60
	|-Component.GetComponentInChildren<AdvDialogControl>
	|-Component.GetComponentInChildren<AreaFogAdjustTrigger>
	|-Component.GetComponentInChildren<AreaFogAreaTrigger>
	|-Component.GetComponentInChildren<CharacterModel>
	|-Component.GetComponentInChildren<CharacterNearCullingController>
	|-Component.GetComponentInChildren<CinemachineDollyCart>
	|-Component.GetComponentInChildren<CinemachineImpulseSource>
	|-Component.GetComponentInChildren<DN17Light>
	|-Component.GetComponentInChildren<UIDualWork>
	|-Component.GetComponentInChildren<DualWorkSetup>
	|-Component.GetComponentInChildren<EmotionController>
	|-Component.GetComponentInChildren<RodAnimation>
	|-Component.GetComponentInChildren<LightningController>
	|-Component.GetComponentInChildren<RainDownfallController>
	|-Component.GetComponentInChildren<RainSplashController>
	|-Component.GetComponentInChildren<WeatherDepthCamera>
	|-Component.GetComponentInChildren<WeatherEnclosureDetector>
	|-Component.GetComponentInChildren<HUDFadeMove>
	|-Component.GetComponentInChildren<HitMaster>
	|-Component.GetComponentInChildren<HumanModel>
	|-Component.GetComponentInChildren<HumanRideSaddle>
	|-Component.GetComponentInChildren<MonsterProjectileActionScriptsController>
	|-Component.GetComponentInChildren<FullBodyBipedIK>
	|-Component.GetComponentInChildren<LookAtIK>
	|-Component.GetComponentInChildren<VRIK>
	|-Component.GetComponentInChildren<SimpleTriggerEventDispatcher>
	|-Component.GetComponentInChildren<SpringManager>
	|-Component.GetComponentInChildren<Animation>
	|-Component.GetComponentInChildren<RotationConstraint>
	|-Component.GetComponentInChildren<Animator>
	|-Component.GetComponentInChildren<LensFlare>
	|-Component.GetComponentInChildren<Light>
	|-Component.GetComponentInChildren<MeshRenderer>
	|-Component.GetComponentInChildren<ParticleSystem>
	|-Component.GetComponentInChildren<Renderer>
	|-Component.GetComponentInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentInChildren<SphereCollider>
	|-Component.GetComponentInChildren<Image>
	|-Component.GetComponentInChildren<Scrollbar>
	|-Component.GetComponentInChildren<Text>
	|-Component.GetComponentInChildren<Toggle>
	|-Component.GetComponentInChildren<YadokariShellController>
	|-Component.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6520 Offset: 0x34F6621 VA: 0x34F6520
	|-Component.GetComponentsInChildren<AttackCollider>
	|-Component.GetComponentsInChildren<CinemachineVirtualCameraBase>
	|-Component.GetComponentsInChildren<DynamicBoneH>
	|-Component.GetComponentsInChildren<EventStartPoint>
	|-Component.GetComponentsInChildren<UIQuestSlotInPoliceBook>
	|-Component.GetComponentsInChildren<SpringBone>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3900 Offset: 0x23E3A01 VA: 0x23E3900
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F64F0 Offset: 0x34F65F1 VA: 0x34F64F0
	|-Component.GetComponentsInChildren<BulletColliderBase>
	|-Component.GetComponentsInChildren<CinemachineCollider>
	|-Component.GetComponentsInChildren<CinemachineExtension>
	|-Component.GetComponentsInChildren<DN17LightArea>
	|-Component.GetComponentsInChildren<DualWorkTrackMute>
	|-Component.GetComponentsInChildren<FishObject>
	|-Component.GetComponentsInChildren<OnGroundItem>
	|-Component.GetComponentsInChildren<IK>
	|-Component.GetComponentsInChildren<InteractionTarget>
	|-Component.GetComponentsInChildren<ProfilerGraphAxisLabel>
	|-Component.GetComponentsInChildren<TMP_SubMesh>
	|-Component.GetComponentsInChildren<TMP_SubMeshUI>
	|-Component.GetComponentsInChildren<UIEMItemslot>
	|-Component.GetComponentsInChildren<NavMeshModifier>
	|-Component.GetComponentsInChildren<NavMeshModifierVolume>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<MeshCollider>
	|-Component.GetComponentsInChildren<MonoBehaviour>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Terrain>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<Image>
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3960 Offset: 0x23E3A61 VA: 0x23E3960
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<Component>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xD5EA0 Offset: 0xD5FA1 VA: 0xD5EA0
	// RVA: 0x2B01630 Offset: 0x2B01731 VA: 0x2B01630
	public Component GetComponentInParent(Type t) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265C40 Offset: 0x2265D41 VA: 0x2265C40
	|-Component.GetComponentInParent<Character>
	|-Component.GetComponentInParent<CharacterNearCullingController>
	|-Component.GetComponentInParent<DualWorkObject>
	|-Component.GetComponentInParent<FesMinimapControl>
	|-Component.GetComponentInParent<HumanController>
	|-Component.GetComponentInParent<FullBodyBipedIK>
	|-Component.GetComponentInParent<VRIK>
	|-Component.GetComponentInParent<StyleRoot>
	|-Component.GetComponentInParent<Spline>
	|-Component.GetComponentInParent<TMP_Dropdown>
	|-Component.GetComponentInParent<TextMeshPro>
	|-Component.GetComponentInParent<TextMeshProUGUI>
	|-Component.GetComponentInParent<Canvas>
	|-Component.GetComponentInParent<CanvasScaler>
	|-Component.GetComponentInParent<Dropdown>
	|-Component.GetComponentInParent<ScrollRect>
	|-Component.GetComponentInParent<YadokariShellController>
	|-Component.GetComponentInParent<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F65A0 Offset: 0x34F66A1 VA: 0x34F65A0
	|-Component.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3990 Offset: 0x23E3A91 VA: 0x23E3990
	|-Component.GetComponentsInParent<object>
	|-Component.GetComponentsInParent<Canvas>
	|-Component.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F6570 Offset: 0x34F6671 VA: 0x34F6570
	|-Component.GetComponentsInParent<BaseRaycaster>
	|-Component.GetComponentsInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xD5EC0 Offset: 0xD5FC1 VA: 0xD5EC0
	// RVA: 0x2B01710 Offset: 0x2B01811 VA: 0x2B01710
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x2B01770 Offset: 0x2B01871 VA: 0x2B01770
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3860 Offset: 0x23E3961 VA: 0x23E3860
	|-Component.GetComponents<object>
	|-Component.GetComponents<CanvasGroup>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInputModule>
	|-Component.GetComponents<IMaterialModifier>
	|-Component.GetComponents<Mask>
	*/

	// RVA: 0x2B017D0 Offset: 0x2B018D1 VA: 0x2B017D0
	public string get_tag() { }

	// RVA: 0x2B018B0 Offset: 0x2B019B1 VA: 0x2B018B0
	public void set_tag(string value) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F64B0 Offset: 0x34F65B1 VA: 0x34F64B0
	|-Component.GetComponents<CinemachineComponentBase>
	|-Component.GetComponents<CinemachineVirtualCameraBase>
	|-Component.GetComponents<Simplifier>
	|-Component.GetComponents<Collider>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInput>
	|-Component.GetComponents<BaseRaycaster>
	|-Component.GetComponents<object>
	*/

	// RVA: 0x2B01990 Offset: 0x2B01A91 VA: 0x2B01990
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xD5F00 Offset: 0xD6001 VA: 0xD5F00
	// RVA: 0x2B01A70 Offset: 0x2B01B71 VA: 0x2B01A70
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x2B01AE0 Offset: 0x2B01BE1 VA: 0x2B01AE0
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x2AF87D0 Offset: 0x2AF88D1 VA: 0x2AF87D0
	public void .ctor() { }
}

