public abstract class AS_ToolController : ActionScriptControllerBase // TypeDefIndex: 6161
{
	// Fields
	protected Character _Charactor; // 0x140
	protected bool InfluenceActionSpeed; // 0x148
	private float _MotionSpeed; // 0x14C
	public bool IsCanMove; // 0x150
	[HideInInspector] // RVA: 0x15B970 Offset: 0x15BA71 VA: 0x15B970
	public List<CharacterBase> m_HitList; // 0x158
	private GameObject m_ColliderObject; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x15B980 Offset: 0x15BA81 VA: 0x15B980
	private string <NextActionCodeNameSP>k__BackingField; // 0x168
	public Dictionary<EquipSlotType, AS_ToolController.ToolActionData> m_EquipDatas; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x15B990 Offset: 0x15BA91 VA: 0x15B990
	private EquipSlotType <CurrentSlotType>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x15B9A0 Offset: 0x15BAA1 VA: 0x15B9A0
	private ToolChargeLevel <CurrentChargeLevel>k__BackingField; // 0x17C
	private Dictionary<ToolChargeLevel, ParticleSystem> m_ChargeEffects; // 0x180
	private SEController m_ChargeSound; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x15B9B0 Offset: 0x15BAB1 VA: 0x15B9B0
	private Func<bool> <CanNextCondition>k__BackingField; // 0x190
	protected FocusInterface singleTarget; // 0x198
	protected List<ToolInteractionInterface> multiTargets; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x15B9C0 Offset: 0x15BAC1 VA: 0x15B9C0
	private ToolInteractionInterface <FarmApproachTarget>k__BackingField; // 0x1A8
	private static readonly Dictionary<FarmAction, SkillActionID[]> ChargeFarmActionDic; // 0x0
	private FarmRange SelectedFarmRange; // 0x1B0
	private ToolInteractionInterface RapidFocusedObject; // 0x1B8

	// Properties
	public override Character Character { get; }
	public override float Speed { get; }
	public override float MotionSpeed { get; set; }
	public virtual HumanController Human { get; }
	protected string NextActionCodeNameSP { get; set; }
	public EquipSlotType CurrentSlotType { get; set; }
	public AS_ToolController.ToolActionData CurrentEquipData { get; }
	public ToolChargeLevel CurrentChargeLevel { get; set; }
	public Func<bool> CanNextCondition { get; set; }
	public ToolInteractionInterface FarmApproachTarget { get; set; }

	// Methods

	// RVA: 0x1E67840 Offset: 0x1E67941 VA: 0x1E67840 Slot: 4
	public override Character get_Character() { }

	// RVA: 0x1E678F0 Offset: 0x1E679F1 VA: 0x1E678F0 Slot: 7
	public override float get_Speed() { }

	// RVA: 0x1E679E0 Offset: 0x1E67AE1 VA: 0x1E679E0 Slot: 5
	public override float get_MotionSpeed() { }

	// RVA: 0x1E679F0 Offset: 0x1E67AF1 VA: 0x1E679F0 Slot: 6
	public override void set_MotionSpeed(float value) { }

	// RVA: 0x1E67A00 Offset: 0x1E67B01 VA: 0x1E67A00 Slot: 24
	public virtual HumanController get_Human() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A330 Offset: 0x19A431 VA: 0x19A330
	// RVA: 0x1E67A90 Offset: 0x1E67B91 VA: 0x1E67A90
	protected string get_NextActionCodeNameSP() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A340 Offset: 0x19A441 VA: 0x19A340
	// RVA: 0x1E67AA0 Offset: 0x1E67BA1 VA: 0x1E67AA0
	protected void set_NextActionCodeNameSP(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A350 Offset: 0x19A451 VA: 0x19A350
	// RVA: 0x1E67AB0 Offset: 0x1E67BB1 VA: 0x1E67AB0
	public EquipSlotType get_CurrentSlotType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A360 Offset: 0x19A461 VA: 0x19A360
	// RVA: 0x1E67AC0 Offset: 0x1E67BC1 VA: 0x1E67AC0
	public void set_CurrentSlotType(EquipSlotType value) { }

	// RVA: 0x1E67AD0 Offset: 0x1E67BD1 VA: 0x1E67AD0
	public AS_ToolController.ToolActionData get_CurrentEquipData() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A370 Offset: 0x19A471 VA: 0x19A370
	// RVA: 0x1E67B50 Offset: 0x1E67C51 VA: 0x1E67B50
	public ToolChargeLevel get_CurrentChargeLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A380 Offset: 0x19A481 VA: 0x19A380
	// RVA: 0x1E67B60 Offset: 0x1E67C61 VA: 0x1E67B60
	protected void set_CurrentChargeLevel(ToolChargeLevel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A390 Offset: 0x19A491 VA: 0x19A390
	// RVA: 0x1E67B70 Offset: 0x1E67C71 VA: 0x1E67B70
	public Func<bool> get_CanNextCondition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A3A0 Offset: 0x19A4A1 VA: 0x19A3A0
	// RVA: 0x1E67B80 Offset: 0x1E67C81 VA: 0x1E67B80
	public void set_CanNextCondition(Func<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A3B0 Offset: 0x19A4B1 VA: 0x19A3B0
	// RVA: 0x1E67B90 Offset: 0x1E67C91 VA: 0x1E67B90
	public ToolInteractionInterface get_FarmApproachTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A3C0 Offset: 0x19A4C1 VA: 0x19A3C0
	// RVA: 0x1E67BA0 Offset: 0x1E67CA1 VA: 0x1E67BA0
	protected void set_FarmApproachTarget(ToolInteractionInterface value) { }

	// RVA: 0x1E67BB0 Offset: 0x1E67CB1 VA: 0x1E67BB0 Slot: 8
	protected override void Awake() { }

	// RVA: 0x1E68060 Offset: 0x1E68161 VA: 0x1E68060 Slot: 25
	protected virtual void OnDisable() { }

	// RVA: 0x1E681A0 Offset: 0x1E682A1 VA: 0x1E681A0
	protected void InitEquipData(EquipSlotType equipSlotType, ItemData itemData, List<ItemEquip> itemEquips) { }

	// RVA: 0x1E68740 Offset: 0x1E68841 VA: 0x1E68740
	protected void UnEquipData(EquipSlotType equipSlotType) { }

	// RVA: 0x1E68880 Offset: 0x1E68981 VA: 0x1E68880 Slot: 10
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable) { }

	// RVA: 0x1E68EB0 Offset: 0x1E68FB1 VA: 0x1E68EB0
	public void DoMove() { }

	// RVA: 0x1E68F90 Offset: 0x1E69091 VA: 0x1E68F90
	private void DoAction(EquipSlotType equipSlotType, string scriptName) { }

	// RVA: 0x1E690B0 Offset: 0x1E691B1 VA: 0x1E690B0
	public void DoSlotAction(int no) { }

	// RVA: 0x1E69430 Offset: 0x1E69531 VA: 0x1E69430 Slot: 12
	public override void DoAction(ActionCode actionCode) { }

	// RVA: 0x1E6A090 Offset: 0x1E6A191 VA: 0x1E6A090 Slot: 14
	public override void GoNext() { }

	// RVA: 0x1E6A390 Offset: 0x1E6A491 VA: 0x1E6A390
	public void DoActionByFishing(string nextActionCodeName) { }

	// RVA: 0x1E6A450 Offset: 0x1E6A551 VA: 0x1E6A450
	private void FishingRodAnime(RodAnimation.RodAnime anime) { }

	// RVA: 0x1E6A510 Offset: 0x1E6A611 VA: 0x1E6A510
	public void DoUniqueActionNPC(string actionscriptName) { }

	// RVA: 0x1E6A5D0 Offset: 0x1E6A6D1 VA: 0x1E6A5D0 Slot: 13
	public override void StopAction() { }

	// RVA: 0x1E6AAE0 Offset: 0x1E6ABE1 VA: 0x1E6AAE0
	public void DoAvoid(EquipSlotType equipSlotType) { }

	// RVA: 0x1E6ABC0 Offset: 0x1E6ACC1 VA: 0x1E6ABC0
	private void StopCharge() { }

	// RVA: 0x1E68090 Offset: 0x1E68191 VA: 0x1E68090
	public void ClearAllPush() { }

	// RVA: 0x1E6B0E0 Offset: 0x1E6B1E1 VA: 0x1E6B0E0
	public int ChargeCount(AS_ToolController.ToolActionData toolActionData) { }

	// RVA: 0x1E6B1E0 Offset: 0x1E6B2E1 VA: 0x1E6B1E0
	public void OnPush(EquipSlotType equipSlotType) { }

	// RVA: 0x1E6B800 Offset: 0x1E6B901 VA: 0x1E6B800
	public ASExecuteType OnRelease(EquipSlotType equipSlotType) { }

	// RVA: 0x1E6BD70 Offset: 0x1E6BE71 VA: 0x1E6BD70
	public bool CheckSkillLevel(ItemCategory itemCategory, int level) { }

	// RVA: 0x1E6BF10 Offset: 0x1E6C011 VA: 0x1E6BF10
	public void DoMagicRA(EquipSlotType equipSlotType) { }

	// RVA: 0x1E6C290 Offset: 0x1E6C391 VA: 0x1E6C290
	public void CanNextInitial(CanNextCommand canNextCommand) { }

	// RVA: 0x1E6C2A0 Offset: 0x1E6C3A1 VA: 0x1E6C2A0
	public void CanNext(CanNextCommand canNextCommand) { }

	// RVA: 0x1E6C600 Offset: 0x1E6C701 VA: 0x1E6C600
	public void MagicCanNextInitial(string nextActionCode) { }

	// RVA: 0x1E6C610 Offset: 0x1E6C711 VA: 0x1E6C610
	public void MagicCanNext(int slot, string nextActionCode) { }

	// RVA: 0x1E6C8D0 Offset: 0x1E6C9D1 VA: 0x1E6C8D0
	public void DoMagicMotion(HumanMagicMotionType motionType, int slot) { }

	// RVA: 0x1E6CAD0 Offset: 0x1E6CBD1 VA: 0x1E6CAD0
	public void InputStart() { }

	// RVA: 0x1E6CB50 Offset: 0x1E6CC51 VA: 0x1E6CB50
	public void InputEnd(InputEndCommand canNextCommand) { }

	// RVA: 0x1E6CC10 Offset: 0x1E6CD11 VA: 0x1E6CC10
	public void CanMove(CanMoveCommand canMoveCommand) { }

	// RVA: 0x1E6CC20 Offset: 0x1E6CD21 VA: 0x1E6CC20
	public void ClearHitList(ClearHitListCommand clearHitListCommand) { }

	// RVA: 0x1E6CC80 Offset: 0x1E6CD81 VA: 0x1E6CC80
	public void OnCollisionTool(OnCollisionToolCommand onCollisionToolCommand) { }

	// RVA: 0x1E6CE10 Offset: 0x1E6CF11 VA: 0x1E6CE10
	public void OffCollisionTool(OnCollisionToolCommand onCollisionCommand) { }

	// RVA: 0x1E6CFF0 Offset: 0x1E6D0F1 VA: 0x1E6CFF0
	public void OffCollisionTool(OffCollisionToolCommand offCollisionCommand) { }

	// RVA: 0x1E6A880 Offset: 0x1E6A981 VA: 0x1E6A880
	private void OffCollisionToolForce() { }

	// RVA: 0x1E6D250 Offset: 0x1E6D351 VA: 0x1E6D250
	public void OnCollisionBox(OnCollisionBoxCommand onCollisionBoxCommand) { }

	// RVA: 0x1E6D810 Offset: 0x1E6D911 VA: 0x1E6D810
	public void OnCollisionSphere(OnCollisionSphereCommand onCollisionSphereCommand) { }

	// RVA: 0x1E6D190 Offset: 0x1E6D291 VA: 0x1E6D190
	public void OffCollision() { }

	// RVA: 0x1E6DD70 Offset: 0x1E6DE71 VA: 0x1E6DD70
	public void PlayToolEffect(int slot, float scale) { }

	// RVA: 0x1E6E130 Offset: 0x1E6E231 VA: 0x1E6E130
	public void OnPlayToolEffect(int slot) { }

	// RVA: 0x1E6E140 Offset: 0x1E6E241 VA: 0x1E6E140
	public void StopToolEffect(int slot) { }

	// RVA: 0x1E6E390 Offset: 0x1E6E491 VA: 0x1E6E390
	public void StopToolEffectAll() { }

	// RVA: 0x1E6E5C0 Offset: 0x1E6E6C1 VA: 0x1E6E5C0
	public void ReleaseNext(SetReleaseNextCommand releaseNextCommand) { }

	// RVA: 0x1E6E610 Offset: 0x1E6E711 VA: 0x1E6E610
	public void DoFarmAction(FarmActionCommand farmActionCommand) { }

	// RVA: 0x1E71600 Offset: 0x1E71701 VA: 0x1E71600
	private void SetFarmRange(FarmAction farmAction, FarmRange farmRange) { }

	// RVA: 0x1E716B0 Offset: 0x1E717B1 VA: 0x1E716B0
	public void SetFarmRange(SetFarmRangeCommand setFarmRangeCommand) { }

	// RVA: 0x1E71790 Offset: 0x1E71891 VA: 0x1E71790
	public bool IsFarmTool() { }

	// RVA: 0x1E718D0 Offset: 0x1E719D1 VA: 0x1E718D0
	public bool IsHammer() { }

	// RVA: 0x1E697F0 Offset: 0x1E698F1 VA: 0x1E697F0
	public ToolInteractionInterface CheckAndSetFarmRapidActionTarget() { }

	// RVA: 0x1E719E0 Offset: 0x1E71AE1 VA: 0x1E719E0
	public void OnUseBrush(BrushToolCommand BrushToolCommand) { }

	// RVA: 0x1E71C50 Offset: 0x1E71D51 VA: 0x1E71C50
	public void OnUseScissors(ScissorsToolCommand ScissorsToolCommand) { }

	// RVA: 0x1E71EC0 Offset: 0x1E71FC1 VA: 0x1E71EC0
	public void DamageCheckStart(DamageCheckStartCommand damageCheckStartCommand) { }

	// RVA: 0x1E72040 Offset: 0x1E72141 VA: 0x1E72040
	public bool DamageCheck(DamageInfo damageInfo) { }

	// RVA: 0x1E72490 Offset: 0x1E72591 VA: 0x1E72490
	public void DamageCheckEnd(DamageCheckEndCommand damageCheckEndCommand) { }

	// RVA: 0x1E72550 Offset: 0x1E72651 VA: 0x1E72550
	public void HitCheckStart(HitCheckStartCommand hitCheckStartCommand) { }

	// RVA: 0x1E729E0 Offset: 0x1E72AE1 VA: 0x1E729E0
	public void HitNext() { }

	// RVA: 0x1E72AD0 Offset: 0x1E72BD1 VA: 0x1E72AD0
	public void HitCheckEnd(HitCheckEndCommand hitCheckEndCommand) { }

	// RVA: 0x1E72B50 Offset: 0x1E72C51 VA: 0x1E72B50 Slot: 23
	protected override void Update() { }

	// RVA: 0x1E6AE60 Offset: 0x1E6AF61 VA: 0x1E6AE60
	private void StopChargeEffect() { }

	// RVA: 0x1E73840 Offset: 0x1E73941 VA: 0x1E73840
	private void StopChargeEffect(ToolChargeLevel level) { }

	// RVA: 0x1E73610 Offset: 0x1E73711 VA: 0x1E73610
	private void PlayChargeEffect(EffectID effectID, ToolChargeLevel level) { }

	// RVA: 0x1E6B040 Offset: 0x1E6B141 VA: 0x1E6B040
	private void StopChargeSound() { }

	// RVA: 0x1E73710 Offset: 0x1E73811 VA: 0x1E73710
	private void PlayChargeSound(SoundID soundID) { }

	// RVA: 0x1E6B6D0 Offset: 0x1E6B7D1 VA: 0x1E6B6D0
	private void ReloadWaterPod() { }

	// RVA: 0x1E73940 Offset: 0x1E73A41 VA: 0x1E73940
	protected void .ctor() { }

	// RVA: 0x1E73A30 Offset: 0x1E73B31 VA: 0x1E73A30
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A3D0 Offset: 0x19A4D1 VA: 0x19A3D0
	// RVA: 0x1E73CC0 Offset: 0x1E73DC1 VA: 0x1E73CC0
	private void <HitCheckStart>b__101_0(Collider other, Vector3 point) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A3E0 Offset: 0x19A4E1 VA: 0x19A3E0
	// RVA: 0x1E73D80 Offset: 0x1E73E81 VA: 0x1E73D80
	private void <Update>b__104_0(ParticleSystem effect) { }
}

