[Serializable]
public class NpcController : HumanController, InteractionInterface, FocusInterface, ItemInteractionInterface // TypeDefIndex: 6757
{
	// Fields
	private const float AddCheckShortPlayY = 1;
	private const float CheckShortPlayOnGroundSqrMagnitude = 3600;
	private const float ResetCheckShortPlayOnGroundSqrMagnitude = 4900;
	[HeaderAttribute] // RVA: 0x15F3B0 Offset: 0x15F4B1 VA: 0x15F3B0
	[SerializeField] // RVA: 0x15F3B0 Offset: 0x15F4B1 VA: 0x15F3B0
	public NPCID m_CharaID; // 0x238
	[SerializeField] // RVA: 0x15F400 Offset: 0x15F501 VA: 0x15F400
	public int lookTargetNpcId; // 0x23C
	public string focusName; // 0x240
	public bool focusable; // 0x248
	[SerializeField] // RVA: 0x15F410 Offset: 0x15F511 VA: 0x15F410
	private GameObject FocusIcon; // 0x250
	[SerializeField] // RVA: 0x15F420 Offset: 0x15F521 VA: 0x15F420
	public int NpcId; // 0x258
	[SerializeField] // RVA: 0x15F430 Offset: 0x15F531 VA: 0x15F430
	public Transform NpcLookAtTarget; // 0x260
	public Quaternion ShortPlayRotation; // 0x268
	[SerializeField] // RVA: 0x15F440 Offset: 0x15F541 VA: 0x15F440
	public bool animchk; // 0x278
	private float m_Elapsed; // 0x27C
	private bool Mepati; // 0x280
	[CompilerGeneratedAttribute] // RVA: 0x15F450 Offset: 0x15F551 VA: 0x15F450
	private int <NpcTalkStep>k__BackingField; // 0x284
	private bool IsOrder; // 0x288
	[CompilerGeneratedAttribute] // RVA: 0x15F460 Offset: 0x15F561 VA: 0x15F460
	private bool <IsMotion>k__BackingField; // 0x289
	[CompilerGeneratedAttribute] // RVA: 0x15F470 Offset: 0x15F571 VA: 0x15F470
	private float <CameraDistance>k__BackingField; // 0x28C
	public bool IsFirstTalk; // 0x290
	public float RaycastHitPointY; // 0x294
	private Transform itemPoint_Right; // 0x298
	private Transform itemPoint_Left; // 0x2A0
	private Transform itemPoint_Floor; // 0x2A8
	public Vector3 ItemPoint_Floor_Position; // 0x2B0
	[SerializeField] // RVA: 0x15F480 Offset: 0x15F581 VA: 0x15F480
	[RangeAttribute] // RVA: 0x15F480 Offset: 0x15F581 VA: 0x15F480
	public float HurryMoveSpeed; // 0x2BC
	public float ShortPlayMoveSpeed; // 0x2C0
	public float ShortPlayLocomotion; // 0x2C4
	public float ShortPlayTargetMoveSpeed; // 0x2C8
	public float ShortPlayTargetLocomotion; // 0x2CC
	public bool IsReached; // 0x2D0
	public bool IsRotate; // 0x2D1
	[SerializeField] // RVA: 0x15F4C0 Offset: 0x15F5C1 VA: 0x15F4C0
	public float lookAtSpeed; // 0x2D4
	private LookAtIK lookAtIK; // 0x2D8
	private float headWeight; // 0x2E0
	private float clampWeightHead; // 0x2E4
	private Vector3 m_Offset; // 0x2E8
	private GameObject lookAtGameObject; // 0x2F8
	public Vector3 lookat; // 0x300
	public Vector3 BeforeTransformForward; // 0x30C
	private float EmotionTime; // 0x318
	private bool emotion; // 0x31C
	public float npcAnimatorSpeed; // 0x320
	public bool IsHurry; // 0x324
	private NpcController.CVState _CVState; // 0x328
	private VariationNo RequestVariationNo; // 0x32C
	private VariationNo ChangingVariationNo; // 0x330
	private NpcGrassType GrassType; // 0x334
	public float stateTimerForChangeVariation; // 0x338
	private MaterialPropertyBlock materialPropertyBlock; // 0x340
	private SkinnedMeshRenderer[] SkinnedMeshRenderers; // 0x348
	private float RequestFadeAlpha; // 0x350
	public bool Standby; // 0x354
	public Vector3 PrevTickPosition; // 0x358
	private const string ANIMIDX_NAME = "AnimIdx";
	private NpcData _NpcData; // 0x368
	private NpcData npcData; // 0x370
	private bool IsCheckShortPlayOnGround; // 0x378
	private float SpringBoneSleepTimer; // 0x37C
	private Vector3 m_PrevPosition; // 0x380
	private Quaternion m_PrevRotation; // 0x38C
	private NpcController.StatePrepareForLifecycle _StatePrepare; // 0x39C
	private const float SEC_PREPARE_FADE_DURATION = 0.3;
	private const float SEC_WAITSEC_PREPARE_FADE_START = 1.2;
	private float fadeRateForPrepare; // 0x3A0
	private float goalFadeRateForPrepare; // 0x3A4
	private float curfadeDurationForPrepare; // 0x3A8
	public float stateTimerForStatePrepare; // 0x3AC

	// Properties
	public bool Focusable { get; set; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }
	public string ItemInteractionButtonHint { get; }
	public int NpcTalkStep { get; set; }
	public bool IsMotion { get; set; }
	public float CameraDistance { get; set; }
	public Transform ItemPoint_Right { get; }
	public Transform ItemPoint_Left { get; }
	public Transform ItemPoint_Floor { get; }
	public LookAtIK LookAtIK { get; }
	private NpcController.CVState ChangeVariationState { get; set; }
	protected override bool EnableEquipWeaponAndTool { get; }
	public int AnimIdx { get; }
	private NpcData NpcData { get; }
	public override bool IsShortPlay { get; set; }
	public override bool IsShortPlayMove { get; set; }
	public Vector3 NpcEyePosition { get; }
	public FocusObjectType FocusObjectType { get; }
	private NpcController.StatePrepareForLifecycle StatePrepare { get; set; }
	public bool IsWaitPrepare { get; }

	// Methods

	// RVA: 0x1FB7FE0 Offset: 0x1FB80E1 VA: 0x1FB7FE0 Slot: 102
	public string GetFocusName() { }

	// RVA: 0x1FB7FF0 Offset: 0x1FB80F1 VA: 0x1FB7FF0 Slot: 103
	public bool get_Focusable() { }

	// RVA: 0x1FB81A0 Offset: 0x1FB82A1 VA: 0x1FB81A0
	private void set_Focusable(bool value) { }

	// RVA: 0x1FB81B0 Offset: 0x1FB82B1 VA: 0x1FB81B0 Slot: 107
	public int get_FocusPriority() { }

	// RVA: 0x1FB81C0 Offset: 0x1FB82C1 VA: 0x1FB81C0 Slot: 108
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1FB81D0 Offset: 0x1FB82D1 VA: 0x1FB81D0 Slot: 101
	public string GetInteractionButtonHint() { }

	// RVA: 0x1FB8220 Offset: 0x1FB8321 VA: 0x1FB8220
	public string get_ItemInteractionButtonHint() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD10 Offset: 0x19CE11 VA: 0x19CD10
	// RVA: 0x1FB8270 Offset: 0x1FB8371 VA: 0x1FB8270
	public int get_NpcTalkStep() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD20 Offset: 0x19CE21 VA: 0x19CD20
	// RVA: 0x1FB8280 Offset: 0x1FB8381 VA: 0x1FB8280
	private void set_NpcTalkStep(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD30 Offset: 0x19CE31 VA: 0x19CD30
	// RVA: 0x1FB8290 Offset: 0x1FB8391 VA: 0x1FB8290
	public bool get_IsMotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD40 Offset: 0x19CE41 VA: 0x19CD40
	// RVA: 0x1FB82A0 Offset: 0x1FB83A1 VA: 0x1FB82A0
	private void set_IsMotion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD50 Offset: 0x19CE51 VA: 0x19CD50
	// RVA: 0x1FB82B0 Offset: 0x1FB83B1 VA: 0x1FB82B0
	public float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD60 Offset: 0x19CE61 VA: 0x19CD60
	// RVA: 0x1FB82C0 Offset: 0x1FB83C1 VA: 0x1FB82C0
	private void set_CameraDistance(float value) { }

	// RVA: 0x1FB82D0 Offset: 0x1FB83D1 VA: 0x1FB82D0
	public Transform get_ItemPoint_Right() { }

	// RVA: 0x1FB83A0 Offset: 0x1FB84A1 VA: 0x1FB83A0
	public Transform get_ItemPoint_Left() { }

	// RVA: 0x1FB8470 Offset: 0x1FB8571 VA: 0x1FB8470
	public Transform get_ItemPoint_Floor() { }

	// RVA: 0x1FB8590 Offset: 0x1FB8691 VA: 0x1FB8590
	public LookAtIK get_LookAtIK() { }

	// RVA: 0x1FB8710 Offset: 0x1FB8811 VA: 0x1FB8710
	private NpcController.CVState get_ChangeVariationState() { }

	// RVA: 0x1FB8720 Offset: 0x1FB8821 VA: 0x1FB8720
	private void set_ChangeVariationState(NpcController.CVState value) { }

	// RVA: 0x1FB8730 Offset: 0x1FB8831 VA: 0x1FB8730 Slot: 78
	protected override bool get_EnableEquipWeaponAndTool() { }

	// RVA: 0x1FB8740 Offset: 0x1FB8841 VA: 0x1FB8740
	public int get_AnimIdx() { }

	// RVA: 0x1FB87F0 Offset: 0x1FB88F1 VA: 0x1FB87F0
	private NpcData get_NpcData() { }

	// RVA: 0x1FB8850 Offset: 0x1FB8951 VA: 0x1FB8850
	public NpcData GetNpcData(int NpcId) { }

	// RVA: 0x1FB8900 Offset: 0x1FB8A01 VA: 0x1FB8900
	private void RegistLifecyle() { }

	// RVA: 0x1FB8A70 Offset: 0x1FB8B71 VA: 0x1FB8A70 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1FB8E30 Offset: 0x1FB8F31 VA: 0x1FB8E30 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1FB9420 Offset: 0x1FB9521 VA: 0x1FB9420 Slot: 12
	protected override void Start() { }

	// RVA: 0x1FB9450 Offset: 0x1FB9551 VA: 0x1FB9450
	public void InitStandby(int npcId, bool updateSavePosition = True) { }

	// RVA: 0x1FB9870 Offset: 0x1FB9971 VA: 0x1FB9870 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1FB9930 Offset: 0x1FB9A31 VA: 0x1FB9930
	public void RunSpeedUp() { }

	// RVA: 0x1FB9940 Offset: 0x1FB9A41 VA: 0x1FB9940
	public void RunSpeedOrigin() { }

	// RVA: 0x1FB9950 Offset: 0x1FB9A51 VA: 0x1FB9950 Slot: 104
	public void OnFocus() { }

	// RVA: 0x1FB9A50 Offset: 0x1FB9B51 VA: 0x1FB9A50 Slot: 105
	public void OffFocus() { }

	// RVA: 0x1FB9A60 Offset: 0x1FB9B61 VA: 0x1FB9A60 Slot: 109
	public ushort GetInteractionType() { }

	// RVA: 0x1FB9E70 Offset: 0x1FB9F71 VA: 0x1FB9E70 Slot: 31
	public override bool get_IsShortPlay() { }

	// RVA: 0x1FB9EC0 Offset: 0x1FB9FC1 VA: 0x1FB9EC0 Slot: 32
	public override void set_IsShortPlay(bool value) { }

	// RVA: 0x1FB9F20 Offset: 0x1FBA021 VA: 0x1FB9F20 Slot: 33
	public override bool get_IsShortPlayMove() { }

	// RVA: 0x1FB9F50 Offset: 0x1FBA051 VA: 0x1FB9F50 Slot: 34
	public override void set_IsShortPlayMove(bool value) { }

	// RVA: 0x1FB9F90 Offset: 0x1FBA091 VA: 0x1FB9F90
	public void InitAction(LifecycleState nextState) { }

	// RVA: 0x1FB9FA0 Offset: 0x1FBA0A1 VA: 0x1FB9FA0
	public Vector3 get_NpcEyePosition() { }

	// RVA: 0x1FBA080 Offset: 0x1FBA181 VA: 0x1FBA080 Slot: 106
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1FBA090 Offset: 0x1FBA191 VA: 0x1FBA090
	private NpcController.StatePrepareForLifecycle get_StatePrepare() { }

	// RVA: 0x1FBA0A0 Offset: 0x1FBA1A1 VA: 0x1FBA0A0
	private void set_StatePrepare(NpcController.StatePrepareForLifecycle value) { }

	// RVA: 0x1FBA0B0 Offset: 0x1FBA1B1 VA: 0x1FBA0B0
	public bool get_IsWaitPrepare() { }

	// RVA: 0x1FB8DF0 Offset: 0x1FB8EF1 VA: 0x1FB8DF0
	public void InitPrepare() { }

	// RVA: 0x1FBA0C0 Offset: 0x1FBA1C1 VA: 0x1FBA0C0
	public void SetWaitPrepare() { }

	// RVA: 0x1FBA150 Offset: 0x1FBA251 VA: 0x1FBA150
	public void StartPrepare() { }

	// RVA: 0x1FB8E10 Offset: 0x1FB8F11 VA: 0x1FB8E10
	public void ForcePrepareEnd() { }

	// RVA: 0x1FBA140 Offset: 0x1FBA241 VA: 0x1FBA140
	private void HideModelForPrepare() { }

	// RVA: 0x1FBA1D0 Offset: 0x1FBA2D1 VA: 0x1FBA1D0
	private void DispModelForPrepare() { }

	// RVA: 0x1FBA1E0 Offset: 0x1FBA2E1 VA: 0x1FBA1E0
	private void FadeInModelForPrepare(float duration) { }

	// RVA: 0x1FBA1F0 Offset: 0x1FBA2F1 VA: 0x1FBA1F0
	private void UpdatePrepareForLifecycle() { }

	// RVA: 0x1FBA370 Offset: 0x1FBA471 VA: 0x1FBA370 Slot: 40
	protected override void Update() { }

	// RVA: 0x1FB9350 Offset: 0x1FB9451 VA: 0x1FB9350
	public void AwakeSpringBone() { }

	// RVA: 0x1FBBBB0 Offset: 0x1FBBCB1 VA: 0x1FBBBB0 Slot: 42
	protected override void FixedUpdate() { }

	// RVA: 0x1FBC610 Offset: 0x1FBC711 VA: 0x1FBC610 Slot: 41
	protected override void LateUpdate() { }

	// RVA: 0x1FBC470 Offset: 0x1FBC571 VA: 0x1FBC470
	private void UpdateShortPlayOnGround() { }

	// RVA: 0x1FBC6D0 Offset: 0x1FBC7D1 VA: 0x1FBC6D0
	private void UpdateModelFade() { }

	// RVA: 0x1FBC800 Offset: 0x1FBC901 VA: 0x1FBC800
	private void UpdateChangeVariation() { }

	// RVA: 0x1FB9400 Offset: 0x1FB9501 VA: 0x1FB9400
	public void ClearChangingVariation() { }

	// RVA: 0x1FBCC50 Offset: 0x1FBCD51 VA: 0x1FBCC50
	public void FadeNpc(float fadeAlpha) { }

	// RVA: 0x1FBAF40 Offset: 0x1FBB041 VA: 0x1FBAF40
	private void UpdateWithNpcTalk() { }

	// RVA: 0x1FBCC60 Offset: 0x1FBCD61 VA: 0x1FBCC60 Slot: 62
	public override void SetGrounderIKWeight(float weight) { }

	// RVA: 0x1FBCD20 Offset: 0x1FBCE21 VA: 0x1FBCD20
	public void SetGrounderEnabled(bool enable) { }

	// RVA: 0x1FBCDF0 Offset: 0x1FBCEF1 VA: 0x1FBCDF0
	public void ResetGrounderPosition() { }

	// RVA: 0x1FBB8F0 Offset: 0x1FBB9F1 VA: 0x1FBB8F0
	private void UpdateLookAtRotation() { }

	// RVA: 0x1FBCEB0 Offset: 0x1FBCFB1 VA: 0x1FBCEB0
	private bool CheckUpdateFaceAnimationMepati() { }

	// RVA: 0x1FBB7E0 Offset: 0x1FBB8E1 VA: 0x1FBB7E0
	private void UpdateEyesAnimation() { }

	// RVA: 0x1FBBD40 Offset: 0x1FBBE41 VA: 0x1FBBD40
	public void UpdateNpcOnGround(bool isUpdateCheckShortPlay = False) { }

	// RVA: 0x1FBD090 Offset: 0x1FBD191 VA: 0x1FBD090
	private float GetRaycastHitPointY(Vector3 npcPos) { }

	// RVA: 0x1FBCF80 Offset: 0x1FBD081 VA: 0x1FBCF80
	private float GetDeltaY() { }

	// RVA: 0x1FBBC30 Offset: 0x1FBBD31 VA: 0x1FBBC30
	private void UpdateLifeCycleMoving() { }

	// RVA: 0x1FBD230 Offset: 0x1FBD331 VA: 0x1FBD230
	public void OverridePositionWithNpcModelPosition() { }

	// RVA: 0x1FBAB90 Offset: 0x1FBAC91 VA: 0x1FBAB90
	private void UpdateLocomotionAnimation() { }

	// RVA: 0x1FBCBC0 Offset: 0x1FBCCC1 VA: 0x1FBCBC0
	protected void SetAnimationState(int animIdx) { }

	// RVA: 0x1FBD330 Offset: 0x1FBD431 VA: 0x1FBD330
	public void OnOrder() { }

	// RVA: 0x1FBD340 Offset: 0x1FBD441 VA: 0x1FBD340
	public void OffOrder() { }

	// RVA: 0x1FBD350 Offset: 0x1FBD451 VA: 0x1FBD350
	public bool CanGrabed(HumanController causer) { }

	// RVA: 0x1FB9CE0 Offset: 0x1FB9DE1 VA: 0x1FB9CE0 Slot: 98
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1FBD360 Offset: 0x1FBD461 VA: 0x1FBD360 Slot: 97
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1FBD650 Offset: 0x1FBD751 VA: 0x1FBD650
	public void SetupLucasGrassType() { }

	// RVA: 0x1FBD710 Offset: 0x1FBD811 VA: 0x1FBD710
	public void RequestChangeModel(VariationNo variationNo) { }

	// RVA: 0x1FB97F0 Offset: 0x1FB98F1 VA: 0x1FB97F0
	public void AnimationStart(NpcAnimState animState, bool IsShortPlayCalled, bool immediate = False) { }

	// RVA: 0x1FBD8C0 Offset: 0x1FBD9C1 VA: 0x1FBD8C0
	public void AnimationIdle() { }

	// RVA: 0x1FBD720 Offset: 0x1FBD821 VA: 0x1FBD720
	private void StartAnimationState(NpcAnimState state, bool immediate) { }

	// RVA: 0x1FBD980 Offset: 0x1FBDA81 VA: 0x1FBD980
	private void PlayBaseLayerAnimImmidate(NpcAnimState animState) { }

	// RVA: 0x1FBDA70 Offset: 0x1FBDB71 VA: 0x1FBDA70
	private string GetAnimStateName(NpcAnimState animState) { }

	// RVA: 0x1FB9960 Offset: 0x1FB9A61 VA: 0x1FB9960
	public void PlaySleepVoice() { }

	// RVA: 0x1FB9B40 Offset: 0x1FB9C41 VA: 0x1FB9B40 Slot: 113
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1FBDB10 Offset: 0x1FBDC11 VA: 0x1FBDB10
	public void AnimationBlessing() { }

	// RVA: 0x1FBDBC0 Offset: 0x1FBDCC1 VA: 0x1FBDBC0 Slot: 115
	public virtual void OnCollisionEvent(string str) { }

	// RVA: 0x1FBDBD0 Offset: 0x1FBDCD1 VA: 0x1FBDBD0
	public void OnIdle(string str) { }

	// RVA: 0x1FBDC80 Offset: 0x1FBDD81 VA: 0x1FBDC80
	private void OnAnimatorIK(int layorIndex) { }

	// RVA: 0x1FBDC90 Offset: 0x1FBDD91 VA: 0x1FBDC90
	public void StartWithNpcTalk(NpcData npcData, NpcData targetNpcData) { }

	// RVA: 0x1FBDE20 Offset: 0x1FBDF21 VA: 0x1FBDE20
	public void Stay(int staySec) { }

	// RVA: 0x1FBDEF0 Offset: 0x1FBDFF1 VA: 0x1FBDEF0
	public static bool ReceivePresent(int npcId, HumanController reciever, HumanController causer, ItemData itemData, bool isThrow, bool _script = False) { }

	// RVA: 0x1FBEA50 Offset: 0x1FBEB51 VA: 0x1FBEA50
	private static void RecieveEquipSlot(HumanController reciever, EquipSlotType equipSlotType, ItemData item) { }

	// RVA: 0x1FBEF10 Offset: 0x1FBF011 VA: 0x1FBEF10
	public void ItemConsumption(ItemData itemData, int npcId) { }

	// RVA: 0x1FBF180 Offset: 0x1FBF281 VA: 0x1FBF180
	public void AddLovePoint(int npcID, int itemID, bool isOriginal) { }

	// RVA: 0x1FBF370 Offset: 0x1FBF471 VA: 0x1FBF370 Slot: 112
	public void DoItemInteraction(HumanController causer, ItemData itemData, bool isThrow) { }

	// RVA: 0x1FBF6F0 Offset: 0x1FBF7F1 VA: 0x1FBF6F0
	public bool CheckFesPresent(ItemData item) { }

	// RVA: 0x1FBFFB0 Offset: 0x1FC00B1 VA: 0x1FBFFB0
	private bool CheckLookAtRotation() { }

	// RVA: 0x1FBB1E0 Offset: 0x1FBB2E1 VA: 0x1FBB1E0
	private void UpdateLookAtIK() { }

	// RVA: 0x1FC00F0 Offset: 0x1FC01F1 VA: 0x1FC00F0
	public void ResetLookAtIK() { }

	// RVA: 0x1FB92F0 Offset: 0x1FB93F1 VA: 0x1FB92F0
	public void LookAtIKWeightReset() { }

	// RVA: 0x1FC0090 Offset: 0x1FC0191 VA: 0x1FC0090
	public void SetNpcLookAtTarget(Transform tr, float speed = 1) { }

	// RVA: 0x1FC0120 Offset: 0x1FC0221 VA: 0x1FC0120
	public void SetNpcLookAtTargetVector(Vector3 target, float speed = 1) { }

	// RVA: 0x1FC0100 Offset: 0x1FC0201 VA: 0x1FC0100
	private float GetSpeed(float speed) { }

	// RVA: 0x1FC01E0 Offset: 0x1FC02E1 VA: 0x1FC01E0 Slot: 114
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1FC01F0 Offset: 0x1FC02F1 VA: 0x1FC01F0
	public void SetModel(GameObject model) { }

	// RVA: 0x1FC0400 Offset: 0x1FC0501 VA: 0x1FC0400
	public void SetAnimationUpdateMode(AnimatorUpdateMode mode) { }

	// RVA: 0x1FBD2D0 Offset: 0x1FBD3D1 VA: 0x1FBD2D0
	private bool IsHighHeight() { }

	// RVA: 0x1FBD310 Offset: 0x1FBD411 VA: 0x1FBD310
	private bool IsLowHeight() { }

	// RVA: 0x1FC04C0 Offset: 0x1FC05C1 VA: 0x1FC04C0
	private float LocomitonDifference() { }

	// RVA: 0x1FBED60 Offset: 0x1FBEE61 VA: 0x1FBED60
	public void PlayEmotionEffect(EmotionType emotionType, float dispTime) { }

	// RVA: 0x1FC0520 Offset: 0x1FC0621 VA: 0x1FC0520 Slot: 99
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1FC0780 Offset: 0x1FC0881 VA: 0x1FC0780 Slot: 100
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1FC08C0 Offset: 0x1FC09C1 VA: 0x1FC08C0
	public void .ctor() { }

	// RVA: 0x1FC0A30 Offset: 0x1FC0B31 VA: 0x1FC0A30 Slot: 110
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1FC0A40 Offset: 0x1FC0B41 VA: 0x1FC0A40 Slot: 111
	private Transform FocusInterface.get_transform() { }
}

