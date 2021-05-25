public abstract class ActionScriptControllerBase : MonoBehaviour // TypeDefIndex: 6168
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15BB60 Offset: 0x15BC61 VA: 0x15BB60
	private ActionCode <CurrentActionCode>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15BB70 Offset: 0x15BC71 VA: 0x15BB70
	private string <NextActionCodeName>k__BackingField; // 0x20
	protected Dictionary<string, ActionCode> ActionCodes; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15BB80 Offset: 0x15BC81 VA: 0x15BB80
	private UnityEvent <OnInitActionCodeEvent>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15BB90 Offset: 0x15BC91 VA: 0x15BB90
	private UnityEvent <OnStopActionCodeEvent>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15BBA0 Offset: 0x15BCA1 VA: 0x15BBA0
	private UnityEvent <OnDestroyEvent>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15BBB0 Offset: 0x15BCB1 VA: 0x15BBB0
	private UnityEventBullet <OnBulletCreateEvent>k__BackingField; // 0x48
	public DamageInfo DamageInfo; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15BBC0 Offset: 0x15BCC1 VA: 0x15BBC0
	private Transform <CreateTransform>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x15BBD0 Offset: 0x15BCD1 VA: 0x15BBD0
	private List<Transform> <CreateTransformList>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x15BBE0 Offset: 0x15BCE1 VA: 0x15BBE0
	private bool <IsMagicUseCreateTransform>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x15BBF0 Offset: 0x15BCF1 VA: 0x15BBF0
	private ActionScriptControllerBase.TransformOffset <TransformOffsetValue>k__BackingField; // 0xE8
	private bool IsBulletShot; // 0xF0
	private List<Collider> SearchEnemyList; // 0xF8
	private int ChangeMoveType; // 0x100
	private bool IsRandomRange; // 0x104
	private Vector2 MinRandomRange; // 0x108
	private Vector2 MaxRandomRange; // 0x110
	private bool IsLoopShot; // 0x118
	private float LoopShotTime; // 0x11C
	private float LoopShotSpace; // 0x120
	private GameObject BulletParent; // 0x128
	private bool IsSetBulletHold; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x15BC00 Offset: 0x15BD01 VA: 0x15BC00
	private SkillActionID <CurrentSkillAction>k__BackingField; // 0x134
	protected const float kPowerRateSmall = 0.2;
	protected const float kPowerRateMiddle = 0.6;
	protected const float kPowerRateLarge = 1;
	protected EquipSlotType CallRuneAbility; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x15BC10 Offset: 0x15BD11 VA: 0x15BC10
	private bool <IsPause>k__BackingField; // 0x13C

	// Properties
	public abstract Character Character { get; }
	public ActionCode CurrentActionCode { get; set; }
	public string NextActionCodeName { get; set; }
	public bool IsAction { get; }
	public virtual float MotionSpeed { get; set; }
	public virtual float Speed { get; }
	public UnityEvent OnInitActionCodeEvent { get; set; }
	public UnityEvent OnStopActionCodeEvent { get; set; }
	public UnityEvent OnDestroyEvent { get; set; }
	public UnityEventBullet OnBulletCreateEvent { get; set; }
	public Transform CreateTransform { get; set; }
	public List<Transform> CreateTransformList { get; set; }
	public bool IsMagicUseCreateTransform { get; set; }
	public ActionScriptControllerBase.TransformOffset TransformOffsetValue { get; set; }
	public SkillActionID CurrentSkillAction { get; set; }
	public bool IsPause { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A490 Offset: 0x19A591 VA: 0x19A490
	// RVA: 0x1E7CD70 Offset: 0x1E7CE71 VA: 0x1E7CD70
	public ActionCode get_CurrentActionCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A4A0 Offset: 0x19A5A1 VA: 0x19A4A0
	// RVA: 0x1E7CD80 Offset: 0x1E7CE81 VA: 0x1E7CD80
	private void set_CurrentActionCode(ActionCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A4B0 Offset: 0x19A5B1 VA: 0x19A4B0
	// RVA: 0x1E7CD90 Offset: 0x1E7CE91 VA: 0x1E7CD90
	public string get_NextActionCodeName() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A4C0 Offset: 0x19A5C1 VA: 0x19A4C0
	// RVA: 0x1E7CDA0 Offset: 0x1E7CEA1 VA: 0x1E7CDA0
	public void set_NextActionCodeName(string value) { }

	// RVA: 0x1E68F70 Offset: 0x1E69071 VA: 0x1E68F70
	public bool get_IsAction() { }

	// RVA: 0x1E7CDB0 Offset: 0x1E7CEB1 VA: 0x1E7CDB0 Slot: 5
	public virtual float get_MotionSpeed() { }

	// RVA: 0x1E7CDE0 Offset: 0x1E7CEE1 VA: 0x1E7CDE0 Slot: 6
	public virtual void set_MotionSpeed(float value) { }

	// RVA: 0x1E7CE20 Offset: 0x1E7CF21 VA: 0x1E7CE20 Slot: 7
	public virtual float get_Speed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A4D0 Offset: 0x19A5D1 VA: 0x19A4D0
	// RVA: 0x1E7CE30 Offset: 0x1E7CF31 VA: 0x1E7CE30
	public UnityEvent get_OnInitActionCodeEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A4E0 Offset: 0x19A5E1 VA: 0x19A4E0
	// RVA: 0x1E7CE40 Offset: 0x1E7CF41 VA: 0x1E7CE40
	public void set_OnInitActionCodeEvent(UnityEvent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A4F0 Offset: 0x19A5F1 VA: 0x19A4F0
	// RVA: 0x1E7CE50 Offset: 0x1E7CF51 VA: 0x1E7CE50
	public UnityEvent get_OnStopActionCodeEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A500 Offset: 0x19A601 VA: 0x19A500
	// RVA: 0x1E7CE60 Offset: 0x1E7CF61 VA: 0x1E7CE60
	public void set_OnStopActionCodeEvent(UnityEvent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A510 Offset: 0x19A611 VA: 0x19A510
	// RVA: 0x1E7CE70 Offset: 0x1E7CF71 VA: 0x1E7CE70
	public UnityEvent get_OnDestroyEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A520 Offset: 0x19A621 VA: 0x19A520
	// RVA: 0x1E7CE80 Offset: 0x1E7CF81 VA: 0x1E7CE80
	public void set_OnDestroyEvent(UnityEvent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A530 Offset: 0x19A631 VA: 0x19A530
	// RVA: 0x1E7CE90 Offset: 0x1E7CF91 VA: 0x1E7CE90
	public UnityEventBullet get_OnBulletCreateEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A540 Offset: 0x19A641 VA: 0x19A540
	// RVA: 0x1E7CEA0 Offset: 0x1E7CFA1 VA: 0x1E7CEA0
	public void set_OnBulletCreateEvent(UnityEventBullet value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A550 Offset: 0x19A651 VA: 0x19A550
	// RVA: 0x1E7CEB0 Offset: 0x1E7CFB1 VA: 0x1E7CEB0
	public Transform get_CreateTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A560 Offset: 0x19A661 VA: 0x19A560
	// RVA: 0x1E7CEC0 Offset: 0x1E7CFC1 VA: 0x1E7CEC0
	public void set_CreateTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A570 Offset: 0x19A671 VA: 0x19A570
	// RVA: 0x1E7CED0 Offset: 0x1E7CFD1 VA: 0x1E7CED0
	public List<Transform> get_CreateTransformList() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A580 Offset: 0x19A681 VA: 0x19A580
	// RVA: 0x1E7CEE0 Offset: 0x1E7CFE1 VA: 0x1E7CEE0
	public void set_CreateTransformList(List<Transform> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A590 Offset: 0x19A691 VA: 0x19A590
	// RVA: 0x1E7CEF0 Offset: 0x1E7CFF1 VA: 0x1E7CEF0
	public bool get_IsMagicUseCreateTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A5A0 Offset: 0x19A6A1 VA: 0x19A5A0
	// RVA: 0x1E7CF00 Offset: 0x1E7D001 VA: 0x1E7CF00
	private void set_IsMagicUseCreateTransform(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A5B0 Offset: 0x19A6B1 VA: 0x19A5B0
	// RVA: 0x1E7CF10 Offset: 0x1E7D011 VA: 0x1E7CF10
	public ActionScriptControllerBase.TransformOffset get_TransformOffsetValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A5C0 Offset: 0x19A6C1 VA: 0x19A5C0
	// RVA: 0x1E7CF20 Offset: 0x1E7D021 VA: 0x1E7CF20
	private void set_TransformOffsetValue(ActionScriptControllerBase.TransformOffset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A5D0 Offset: 0x19A6D1 VA: 0x19A5D0
	// RVA: 0x1E7CF30 Offset: 0x1E7D031 VA: 0x1E7CF30
	public SkillActionID get_CurrentSkillAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A5E0 Offset: 0x19A6E1 VA: 0x19A5E0
	// RVA: 0x1E7CF40 Offset: 0x1E7D041 VA: 0x1E7CF40
	public void set_CurrentSkillAction(SkillActionID value) { }

	// RVA: 0x1E67F00 Offset: 0x1E68001 VA: 0x1E67F00 Slot: 8
	protected virtual void Awake() { }

	// RVA: 0x1E7CF50 Offset: 0x1E7D051 VA: 0x1E7CF50 Slot: 9
	protected virtual void OnDestroy() { }

	// RVA: 0x1E7D100 Offset: 0x1E7D201 VA: 0x1E7D100 Slot: 10
	protected virtual ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable) { }

	// RVA: 0x1E7D220 Offset: 0x1E7D321 VA: 0x1E7D220 Slot: 11
	public virtual void InternalSetUpActionCode(string actionCodeName) { }

	// RVA: 0x1E64760 Offset: 0x1E64861 VA: 0x1E64760 Slot: 12
	public virtual void DoAction(ActionCode actionCode) { }

	// RVA: 0x1E6A740 Offset: 0x1E6A841 VA: 0x1E6A740 Slot: 13
	public virtual void StopAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A5F0 Offset: 0x19A6F1 VA: 0x19A5F0
	// RVA: 0x1E7D520 Offset: 0x1E7D621 VA: 0x1E7D520
	public bool get_IsPause() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A600 Offset: 0x19A701 VA: 0x19A600
	// RVA: 0x1E7D530 Offset: 0x1E7D631 VA: 0x1E7D530
	private void set_IsPause(bool value) { }

	// RVA: 0x1E7D540 Offset: 0x1E7D641 VA: 0x1E7D540
	public void Pause() { }

	// RVA: 0x1E7D550 Offset: 0x1E7D651 VA: 0x1E7D550
	public void Resume() { }

	// RVA: 0x1E6A300 Offset: 0x1E6A401 VA: 0x1E6A300 Slot: 14
	public virtual void GoNext() { }

	// RVA: 0x1E7D4D0 Offset: 0x1E7D5D1 VA: 0x1E7D4D0
	public void ResetCreateTransform() { }

	// RVA: 0x1E7D560 Offset: 0x1E7D661 VA: 0x1E7D560
	public void ClearCreateTransformList() { }

	// RVA: 0x1E7D5C0 Offset: 0x1E7D6C1 VA: 0x1E7D5C0
	public void SetCreateTransform(string boneName, bool isMagicUse) { }

	// RVA: 0x1E7D7F0 Offset: 0x1E7D8F1 VA: 0x1E7D7F0
	public void SetOffsetPosition(Vector3 position) { }

	// RVA: 0x1E7D820 Offset: 0x1E7D921 VA: 0x1E7D820
	public void SetOffsetRotation(Vector3 rotation) { }

	// RVA: 0x1E7D850 Offset: 0x1E7D951 VA: 0x1E7D850
	public void SetOffsetScale(Vector3 scale) { }

	// RVA: 0x1E7D880 Offset: 0x1E7D981 VA: 0x1E7D880
	public void UpdateCreateObjectTransform(Transform createObjectTransform, bool useRotate = True) { }

	// RVA: 0x1E7DA80 Offset: 0x1E7DB81 VA: 0x1E7DA80
	public void NextInitial(NextCommand nextCommand) { }

	// RVA: 0x1E7DAC0 Offset: 0x1E7DBC1 VA: 0x1E7DAC0
	public void NextRandomInitial(NextRandomCommand nextRandomCommand) { }

	// RVA: 0x1E67450 Offset: 0x1E67551 VA: 0x1E67450
	public void DoMagic(MagicID magicID, int level, AttackAttribute attribute) { }

	// RVA: 0x1E7DD80 Offset: 0x1E7DE81 VA: 0x1E7DD80 Slot: 15
	public virtual void OnBulletLoad(BulletLoadCommand bulletLoadCmmand) { }

	// RVA: 0x1E7DD90 Offset: 0x1E7DE91 VA: 0x1E7DD90
	public void OnBulletShoot(ProjectileActionMagicCommand onProjectileActionCommand) { }

	[IteratorStateMachineAttribute] // RVA: 0x19A610 Offset: 0x19A711 VA: 0x19A610
	// RVA: 0x1E7DF00 Offset: 0x1E7E001 VA: 0x1E7DF00
	private IEnumerator BulletShot_Loop(ProjectileActionMagicCommand onProjectileActionCommand) { }

	// RVA: 0x1E7DFA0 Offset: 0x1E7E0A1 VA: 0x1E7DFA0 Slot: 16
	protected virtual void BulletShot(ProjectileActionMagicCommand onProjectileActionCommand, Collider targetCollider) { }

	// RVA: 0x1E7E370 Offset: 0x1E7E471 VA: 0x1E7E370 Slot: 17
	protected virtual void CreateBullet(BulletID bulletID, Character chara, Vector3 offset, Quaternion rotation, bool isTargetParent, bool isLateral) { }

	// RVA: 0x1E7E710 Offset: 0x1E7E811 VA: 0x1E7E710
	public void OnGreeting(GreetingCommand onGreetingCommand) { }

	// RVA: 0x1E7EEB0 Offset: 0x1E7EFB1 VA: 0x1E7EEB0
	public void OnSearchEnemy(SearchEnemyActionCommand onProjectileActionCommand) { }

	// RVA: 0x1E7F060 Offset: 0x1E7F161 VA: 0x1E7F060
	public void OnChangeMoveType(ChangeMoveTypeActionCommand onChangeMoveTypeActionCommand) { }

	// RVA: 0x1E7F0A0 Offset: 0x1E7F1A1 VA: 0x1E7F0A0
	public void OnRandomRange(RandomRangeActionCommand onRandomRangeActionCommand) { }

	// RVA: 0x1E7F150 Offset: 0x1E7F251 VA: 0x1E7F150
	public void OnSetLoopShot(SetLoopShotActionCommand onRandomRangeActionCommand) { }

	// RVA: 0x1E7F1A0 Offset: 0x1E7F2A1 VA: 0x1E7F1A0
	public void OnSetBulletParent(SetBulletParentActionCommand onRandomRangeActionCommand) { }

	// RVA: 0x1E7F1B0 Offset: 0x1E7F2B1 VA: 0x1E7F1B0
	public void OnSetBulletHold(SetBulletHoldActionCommand onSetBulletHoldActionCommand) { }

	// RVA: 0x1E7F1C0 Offset: 0x1E7F2C1 VA: 0x1E7F1C0 Slot: 18
	public virtual void DoMagicPlay(MagicID magicID, Vector3 offset) { }

	// RVA: 0x1E65230 Offset: 0x1E65331 VA: 0x1E65230 Slot: 19
	public virtual void DoMagicEfficacy(MagicParamID magicParamID, int level) { }

	// RVA: 0x1E65E70 Offset: 0x1E65F71 VA: 0x1E65E70 Slot: 20
	public virtual void DoMagicMedi(MagicParamID magicParamID1, MagicParamID magicParamID2, MagicParamID magicParamID3, int level) { }

	// RVA: 0x1E7F2E0 Offset: 0x1E7F3E1 VA: 0x1E7F2E0 Slot: 21
	public virtual void DoCallBit(BitID bitID, int level) { }

	// RVA: 0x1E668D0 Offset: 0x1E669D1 VA: 0x1E668D0 Slot: 22
	public virtual void DoScore(ScoreType scoreType, int level) { }

	// RVA: 0x1E7F3E0 Offset: 0x1E7F4E1 VA: 0x1E7F3E0
	public void OnPlayVoice(VoiceGroup group, ActorID overrideActorID) { }

	// RVA: 0x1E7F4D0 Offset: 0x1E7F5D1 VA: 0x1E7F4D0
	public void OnFootSteps(int footIndex, bool effectPlay) { }

	// RVA: 0x1E6D7A0 Offset: 0x1E6D8A1 VA: 0x1E6D7A0
	public void GetKnockbackInfo(EquipToolDamageAction damageAction, ItemDataTable itemDataTable, ref float knockbackPower, ref int blowPower) { }

	// RVA: 0x1E73460 Offset: 0x1E73561 VA: 0x1E73460 Slot: 23
	protected virtual void Update() { }

	// RVA: 0x1E64E80 Offset: 0x1E64F81 VA: 0x1E64E80
	protected void .ctor() { }
}

