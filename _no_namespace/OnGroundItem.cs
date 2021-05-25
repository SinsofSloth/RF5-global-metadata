public class OnGroundItem : MonoBehaviour, InteractionInterface, FocusInterface, ItemInteractionInterface, HoldableInterface, PlowInteractionInterface, ToolInteractionInterface, SlashInteractionInterface, SmashInteractionInterface, ChopInteractionInterface // TypeDefIndex: 7685
{
	// Fields
	private const float kBackstepDistance = 0.05;
	[CompilerGeneratedAttribute] // RVA: 0x1688E0 Offset: 0x1689E1 VA: 0x1688E0
	private ItemData <ItemData>k__BackingField; // 0x18
	private Rigidbody Rigidbody; // 0x20
	private SphereCollider HitCollider; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1688F0 Offset: 0x1689F1 VA: 0x1688F0
	private FieldItemSpawnID <FieldItemSpawnID>k__BackingField; // 0x30
	private StateMachine<OnGroundItem.OnGroundItemState> sm; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x168900 Offset: 0x168A01 VA: 0x168900
	private Transform <Models>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x168910 Offset: 0x168A11 VA: 0x168910
	private Renderer[] <ModelsMeshes>k__BackingField; // 0x48
	[SerializeField] // RVA: 0x168920 Offset: 0x168A21 VA: 0x168920
	private MeshFadeController FadeController; // 0x50
	[SerializeField] // RVA: 0x168930 Offset: 0x168A31 VA: 0x168930
	private AnimationCurve DropSpeedXZ; // 0x58
	[SerializeField] // RVA: 0x168940 Offset: 0x168A41 VA: 0x168940
	private AnimationCurve DropSpeedY1; // 0x60
	[SerializeField] // RVA: 0x168950 Offset: 0x168A51 VA: 0x168950
	private AnimationCurve DropSpeedY2; // 0x68
	[SerializeField] // RVA: 0x168960 Offset: 0x168A61 VA: 0x168960
	private AnimationCurve PickupScale; // 0x70
	[SerializeField] // RVA: 0x168970 Offset: 0x168A71 VA: 0x168970
	private ParticleSystem KirakiraEffect; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x168980 Offset: 0x168A81 VA: 0x168980
	private bool <IsEntry>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x168990 Offset: 0x168A91 VA: 0x168990
	private bool <IsHandCuffs>k__BackingField; // 0x81
	private float PhysicsTime; // 0x84
	private float CurrentPhysicsTime; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1689A0 Offset: 0x168AA1 VA: 0x1689A0
	private bool <IsHide>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x1689B0 Offset: 0x168AB1 VA: 0x1689B0
	private ThrowController <ThrowController>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x1689C0 Offset: 0x168AC1 VA: 0x1689C0
	private HoldItemController <HoldItemController>k__BackingField; // 0x98
	private bool IsLoading; // 0xA0
	private static readonly OnGroundItem.OnGroundItemState[] ReasonToState; // 0x0
	private static readonly bool[] ReasonToIsManage; // 0x8
	private OnGroundItem.SpawnReason m_SpawnReason; // 0xA4
	private OnGroundItem.OnGroundItemState InitialState; // 0xA8
	private static GameObject BaseAssetOnGroundItem; // 0x10
	private static TransitionTables[] transitionTables; // 0x18
	private static int stateElementTableCount; // 0x20
	private const float RemoveTime = 4;
	private float RemoveElapsedTime; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x1689D0 Offset: 0x168AD1 VA: 0x1689D0
	private bool <IsRemoveCandidate>k__BackingField; // 0xB0
	private float JustTimer; // 0xB4
	private static readonly float OverJustTimer; // 0x24
	private Vector3 prevPosition; // 0xB8
	private ActorController PickupOwner; // 0xC8
	private Vector3 PickupStartPoint; // 0xD0
	private readonly float PickupTime; // 0xDC
	private readonly float PickupBounceHeight; // 0xE0
	private readonly float BasePickupHeight; // 0xE4
	private float CurrentPickupTime; // 0xE8
	private bool IsPickupRight; // 0xEC
	private Vector3 _DropStartPoint; // 0xF0
	[HideInInspector] // RVA: 0x1689E0 Offset: 0x168AE1 VA: 0x1689E0
	public Vector3 DropEndPoint; // 0xFC
	private float DropTime; // 0x108
	private float DropHeight; // 0x10C
	private AnimationCurve CurrentCurve; // 0x110
	private float CurrentDropTime; // 0x118

	// Properties
	public ItemData ItemData { get; set; }
	public FieldItemSpawnID FieldItemSpawnID { get; set; }
	public Transform Models { get; set; }
	public Renderer[] ModelsMeshes { get; set; }
	private bool IsEntry { get; set; }
	private bool IsHandCuffs { get; set; }
	public string ItemInteractionButtonHint { get; }
	public bool Focusable { get; }
	public bool CanPickup { get; }
	public bool CanManagePosition { get; }
	public HoldMotionType HoldMotionType { get; }
	public bool IsHide { get; set; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }
	public ThrowController ThrowController { get; set; }
	public HoldItemController HoldItemController { get; set; }
	public bool IsRemoveCandidate { get; set; }
	public float FadeAlpha { get; }
	public Vector3 DropStartPoint { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2500 Offset: 0x1A2601 VA: 0x1A2500
	// RVA: 0x1D90020 Offset: 0x1D90121 VA: 0x1D90020
	public ItemData get_ItemData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2510 Offset: 0x1A2611 VA: 0x1A2510
	// RVA: 0x1D90030 Offset: 0x1D90131 VA: 0x1D90030
	private void set_ItemData(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2520 Offset: 0x1A2621 VA: 0x1A2520
	// RVA: 0x1D90040 Offset: 0x1D90141 VA: 0x1D90040
	public FieldItemSpawnID get_FieldItemSpawnID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2530 Offset: 0x1A2631 VA: 0x1A2530
	// RVA: 0x1D90050 Offset: 0x1D90151 VA: 0x1D90050
	public void set_FieldItemSpawnID(FieldItemSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2540 Offset: 0x1A2641 VA: 0x1A2540
	// RVA: 0x1D90060 Offset: 0x1D90161 VA: 0x1D90060
	public Transform get_Models() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2550 Offset: 0x1A2651 VA: 0x1A2550
	// RVA: 0x1D90070 Offset: 0x1D90171 VA: 0x1D90070
	private void set_Models(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2560 Offset: 0x1A2661 VA: 0x1A2560
	// RVA: 0x1D90080 Offset: 0x1D90181 VA: 0x1D90080
	public Renderer[] get_ModelsMeshes() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2570 Offset: 0x1A2671 VA: 0x1A2570
	// RVA: 0x1D90090 Offset: 0x1D90191 VA: 0x1D90090
	private void set_ModelsMeshes(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2580 Offset: 0x1A2681 VA: 0x1A2580
	// RVA: 0x1D900A0 Offset: 0x1D901A1 VA: 0x1D900A0
	private bool get_IsEntry() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2590 Offset: 0x1A2691 VA: 0x1A2590
	// RVA: 0x1D900B0 Offset: 0x1D901B1 VA: 0x1D900B0
	private void set_IsEntry(bool value) { }

	// RVA: 0x1D900C0 Offset: 0x1D901C1 VA: 0x1D900C0
	public void OnNotPickup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A25A0 Offset: 0x1A26A1 VA: 0x1A25A0
	// RVA: 0x1D90150 Offset: 0x1D90251 VA: 0x1D90150
	private bool get_IsHandCuffs() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A25B0 Offset: 0x1A26B1 VA: 0x1A25B0
	// RVA: 0x1D90160 Offset: 0x1D90261 VA: 0x1D90160
	private void set_IsHandCuffs(bool value) { }

	// RVA: 0x1D90170 Offset: 0x1D90271 VA: 0x1D90170
	public void OnAnyPickup(ActorController pickupOwner, bool isHandCuffs) { }

	// RVA: 0x1D90230 Offset: 0x1D90331 VA: 0x1D90230 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1D90280 Offset: 0x1D90381 VA: 0x1D90280
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x1D902D0 Offset: 0x1D903D1 VA: 0x1D902D0 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1D903D0 Offset: 0x1D904D1 VA: 0x1D903D0 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1D90480 Offset: 0x1D90581 VA: 0x1D90480
	public bool get_CanPickup() { }

	// RVA: 0x1D90520 Offset: 0x1D90621 VA: 0x1D90520
	public bool get_CanManagePosition() { }

	// RVA: 0x1D90660 Offset: 0x1D90761 VA: 0x1D90660 Slot: 29
	public HoldMotionType get_HoldMotionType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A25C0 Offset: 0x1A26C1 VA: 0x1A25C0
	// RVA: 0x1D90690 Offset: 0x1D90791 VA: 0x1D90690
	public bool get_IsHide() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A25D0 Offset: 0x1A26D1 VA: 0x1A25D0
	// RVA: 0x1D906A0 Offset: 0x1D907A1 VA: 0x1D906A0
	private void set_IsHide(bool value) { }

	// RVA: 0x1D906B0 Offset: 0x1D907B1 VA: 0x1D906B0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D906C0 Offset: 0x1D907C1 VA: 0x1D906C0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1D906D0 Offset: 0x1D907D1 VA: 0x1D906D0 Slot: 15
	public FocusPointType get_FocusPointType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A25E0 Offset: 0x1A26E1 VA: 0x1A25E0
	// RVA: 0x1D906E0 Offset: 0x1D907E1 VA: 0x1D906E0 Slot: 24
	public ThrowController get_ThrowController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A25F0 Offset: 0x1A26F1 VA: 0x1A25F0
	// RVA: 0x1D906F0 Offset: 0x1D907F1 VA: 0x1D906F0
	private void set_ThrowController(ThrowController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2600 Offset: 0x1A2701 VA: 0x1A2600
	// RVA: 0x1D90700 Offset: 0x1D90801 VA: 0x1D90700
	public HoldItemController get_HoldItemController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2610 Offset: 0x1A2711 VA: 0x1A2610
	// RVA: 0x1D90710 Offset: 0x1D90811 VA: 0x1D90710
	private void set_HoldItemController(HoldItemController value) { }

	// RVA: 0x1D90720 Offset: 0x1D90821 VA: 0x1D90720
	public void UpdateModelPrefab(Action<OnGroundItem> action) { }

	// RVA: 0x1D90BE0 Offset: 0x1D90CE1 VA: 0x1D90BE0 Slot: 22
	public void OnHold() { }

	// RVA: 0x1D90C80 Offset: 0x1D90D81 VA: 0x1D90C80 Slot: 23
	public void OnPutOn() { }

	// RVA: 0x1D90ED0 Offset: 0x1D90FD1 VA: 0x1D90ED0
	public bool DoHoldToDrop() { }

	// RVA: 0x1D91200 Offset: 0x1D91301 VA: 0x1D91200
	public void DestroyByCerberus() { }

	// RVA: 0x1D912A0 Offset: 0x1D913A1 VA: 0x1D912A0
	public void SetHideModel(bool setValue) { }

	// RVA: 0x1D912F0 Offset: 0x1D913F1 VA: 0x1D912F0
	public void RemoveFromManager() { }

	// RVA: 0x1D91300 Offset: 0x1D91401 VA: 0x1D91300
	private void Awake() { }

	// RVA: 0x1D91400 Offset: 0x1D91501 VA: 0x1D91400
	private void OnDestroy() { }

	// RVA: 0x1D915C0 Offset: 0x1D916C1 VA: 0x1D915C0
	public static OnGroundItem CreateOnGroundItem(ItemData itemData, OnGroundItem.SpawnReason reason, Action<OnGroundItem> action) { }

	// RVA: 0x1D91910 Offset: 0x1D91A11 VA: 0x1D91910
	private void Start() { }

	// RVA: 0x1D920D0 Offset: 0x1D921D1 VA: 0x1D920D0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1D920C0 Offset: 0x1D921C1 VA: 0x1D920C0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1D920E0 Offset: 0x1D921E1 VA: 0x1D920E0 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1D92470 Offset: 0x1D92571 VA: 0x1D92470 Slot: 33
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID) { }

	// RVA: 0x1D92990 Offset: 0x1D92A91 VA: 0x1D92990
	private void Hold_Enter() { }

	// RVA: 0x1D92A70 Offset: 0x1D92B71 VA: 0x1D92A70
	private void Hold_Exit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2620 Offset: 0x1A2721 VA: 0x1A2620
	// RVA: 0x1D92A90 Offset: 0x1D92B91 VA: 0x1D92A90
	public bool get_IsRemoveCandidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2630 Offset: 0x1A2731 VA: 0x1A2630
	// RVA: 0x1D92AA0 Offset: 0x1D92BA1 VA: 0x1D92AA0
	private void set_IsRemoveCandidate(bool value) { }

	// RVA: 0x1D92AB0 Offset: 0x1D92BB1 VA: 0x1D92AB0
	private void OnGround_Enter() { }

	// RVA: 0x1D92B30 Offset: 0x1D92C31 VA: 0x1D92B30
	private void OnGround_Update() { }

	// RVA: 0x1D92C60 Offset: 0x1D92D61 VA: 0x1D92C60
	private void OnGround_Exit() { }

	// RVA: 0x1D92C70 Offset: 0x1D92D71 VA: 0x1D92C70
	public float get_FadeAlpha() { }

	// RVA: 0x1D90D40 Offset: 0x1D90E41 VA: 0x1D90D40 Slot: 34
	public void SetAlpha(float alpha) { }

	// RVA: 0x1D92D20 Offset: 0x1D92E21 VA: 0x1D92D20
	private void OnGroundJust_Enter() { }

	// RVA: 0x1D92D80 Offset: 0x1D92E81 VA: 0x1D92D80
	private void OnGroundJust_Update() { }

	// RVA: 0x1D92E70 Offset: 0x1D92F71 VA: 0x1D92E70
	private void Physics_Enter() { }

	// RVA: 0x1D92EF0 Offset: 0x1D92FF1 VA: 0x1D92EF0
	private void Physics_FixedUpdate() { }

	// RVA: 0x1D93090 Offset: 0x1D93191 VA: 0x1D93090
	private void AnyPickup_Enter() { }

	// RVA: 0x1D932E0 Offset: 0x1D933E1 VA: 0x1D932E0
	private void AnyPickup_Update() { }

	// RVA: 0x1D93C70 Offset: 0x1D93D71 VA: 0x1D93C70
	private void AnyPickup_Exit() { }

	// RVA: 0x1D93D50 Offset: 0x1D93E51 VA: 0x1D93D50
	private void NotPickup_Enter() { }

	// RVA: 0x1D93DF0 Offset: 0x1D93EF1 VA: 0x1D93DF0
	private void NotPickup_Update() { }

	// RVA: 0x1D93FA0 Offset: 0x1D940A1 VA: 0x1D93FA0
	private void NotPickup_Exit() { }

	// RVA: 0x1D93FE0 Offset: 0x1D940E1 VA: 0x1D93FE0
	public Vector3 get_DropStartPoint() { }

	// RVA: 0x1D911B0 Offset: 0x1D912B1 VA: 0x1D911B0
	public void set_DropStartPoint(Vector3 value) { }

	// RVA: 0x1D93FF0 Offset: 0x1D940F1 VA: 0x1D93FF0
	private void Drop_Enter() { }

	// RVA: 0x1D940A0 Offset: 0x1D941A1 VA: 0x1D940A0
	private void Drop_Update() { }

	// RVA: 0x1D942D0 Offset: 0x1D943D1 VA: 0x1D942D0
	private void Drop_Exit() { }

	// RVA: 0x1D94380 Offset: 0x1D94481 VA: 0x1D94380
	private void Throw_Enter() { }

	// RVA: 0x1D94420 Offset: 0x1D94521 VA: 0x1D94420 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1D94600 Offset: 0x1D94701 VA: 0x1D94600 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1D94630 Offset: 0x1D94731 VA: 0x1D94630 Slot: 19
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1D92320 Offset: 0x1D92421 VA: 0x1D92320 Slot: 20
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1D94890 Offset: 0x1D94991 VA: 0x1D94890 Slot: 21
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1D928D0 Offset: 0x1D929D1 VA: 0x1D928D0 Slot: 30
	public bool CanPuton() { }

	// RVA: 0x1D948A0 Offset: 0x1D949A1 VA: 0x1D948A0 Slot: 31
	public bool CanRuckIn() { }

	// RVA: 0x1D94960 Offset: 0x1D94A61 VA: 0x1D94960 Slot: 39
	public void DoSmash(HumanController humanController) { }

	// RVA: 0x1D94970 Offset: 0x1D94A71 VA: 0x1D94970 Slot: 40
	public bool CanSmash(HumanController humanController) { }

	// RVA: 0x1D94980 Offset: 0x1D94A81 VA: 0x1D94980 Slot: 41
	public void DoBreak(HumanController humanController) { }

	// RVA: 0x1D94F10 Offset: 0x1D95011 VA: 0x1D94F10 Slot: 42
	public bool CanBreak(HumanController humanController) { }

	// RVA: 0x1D94F40 Offset: 0x1D95041 VA: 0x1D94F40 Slot: 43
	public void DoChop(HumanController humanController) { }

	// RVA: 0x1D95200 Offset: 0x1D95301 VA: 0x1D95200 Slot: 44
	public bool CanChop(HumanController humanController) { }

	// RVA: 0x1D95230 Offset: 0x1D95331 VA: 0x1D95230 Slot: 37
	public void DoSlash(HumanController humanController) { }

	// RVA: 0x1D95390 Offset: 0x1D95491 VA: 0x1D95390 Slot: 38
	public bool CanSlash(HumanController humanController) { }

	// RVA: 0x1D954D0 Offset: 0x1D955D1 VA: 0x1D954D0 Slot: 35
	public void DoPlow(HumanController humanController) { }

	// RVA: 0x1D95660 Offset: 0x1D95761 VA: 0x1D95660 Slot: 36
	public bool CanPlow(HumanController humanController) { }

	// RVA: 0x1D94C40 Offset: 0x1D94D41 VA: 0x1D94C40
	private void ChangeResourceItem(ItemID itemId, bool isSpread = True) { }

	// RVA: 0x1D95750 Offset: 0x1D95851 VA: 0x1D95750 Slot: 32
	public bool OnTakeDamage(DamageResult result) { }

	// RVA: 0x1D91050 Offset: 0x1D91151 VA: 0x1D91050
	private bool DetectFloorLayer(Vector3 origin, out RaycastHit hitResult) { }

	// RVA: 0x1D95770 Offset: 0x1D95871 VA: 0x1D95770 Slot: 25
	public bool CanThrow() { }

	// RVA: 0x1D95780 Offset: 0x1D95881 VA: 0x1D95780 Slot: 26
	public void OnThrow() { }

	// RVA: 0x1D95820 Offset: 0x1D95921 VA: 0x1D95820 Slot: 27
	public bool HitCheck(HitResult result, ThrowController throwController) { }

	// RVA: 0x1D95B70 Offset: 0x1D95C71 VA: 0x1D95B70 Slot: 28
	public void OnPutOnByThrow() { }

	// RVA: 0x1D95C00 Offset: 0x1D95D01 VA: 0x1D95C00 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D95C10 Offset: 0x1D95D11 VA: 0x1D95C10 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D95C20 Offset: 0x1D95D21 VA: 0x1D95C20
	public void .ctor() { }

	// RVA: 0x1D95C50 Offset: 0x1D95D51 VA: 0x1D95C50
	private static void .cctor() { }

	// RVA: 0x1D967D0 Offset: 0x1D968D1 VA: 0x1D967D0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1D967E0 Offset: 0x1D968E1 VA: 0x1D967E0 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

