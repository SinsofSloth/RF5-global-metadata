public class PlayerInput : CharacterInput // TypeDefIndex: 6682
{
	// Fields
	protected PlayerInput.InputState[] m_InputState; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15EBF0 Offset: 0x15ECF1 VA: 0x15EBF0
	private static bool <Enable>k__BackingField; // 0x0
	private bool m_AutoLockon; // 0x28
	private static float m_EnableCounter; // 0x4
	[SerializeField] // RVA: 0x15EC00 Offset: 0x15ED01 VA: 0x15EC00
	private AnimationCurve m_MoveInputPowerCurve; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15EC10 Offset: 0x15ED11 VA: 0x15EC10
	private static PlayerInput <Instance>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x15EC20 Offset: 0x15ED21 VA: 0x15EC20
	private PlayerInput.InputUpdate <inputUpdate>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15EC30 Offset: 0x15ED31 VA: 0x15EC30
	private HumanController <humanController>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15EC40 Offset: 0x15ED41 VA: 0x15EC40
	private MonsterControllerBase <monsterController>k__BackingField; // 0x48
	[SerializeField] // RVA: 0x15EC50 Offset: 0x15ED51 VA: 0x15EC50
	[RangeAttribute] // RVA: 0x15EC50 Offset: 0x15ED51 VA: 0x15EC50
	private float m_AvoidInputTimeLimit; // 0x50

	// Properties
	public static bool Enable { get; set; }
	public static PlayerInput Instance { get; set; }
	private PlayerInput.InputUpdate inputUpdate { get; set; }
	private HumanController humanController { get; set; }
	private MonsterControllerBase monsterController { get; set; }

	// Methods

	// RVA: 0x1FECEE0 Offset: 0x1FECFE1 VA: 0x1FECEE0
	protected void UpdateInputState() { }

	// RVA: 0x1FECF50 Offset: 0x1FED051 VA: 0x1FECF50
	public void ClearAllInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C900 Offset: 0x19CA01 VA: 0x19C900
	// RVA: 0x1FECFC0 Offset: 0x1FED0C1 VA: 0x1FECFC0
	public static bool get_Enable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C910 Offset: 0x19CA11 VA: 0x19C910
	// RVA: 0x1FED030 Offset: 0x1FED131 VA: 0x1FED030
	public static void set_Enable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C920 Offset: 0x19CA21 VA: 0x19C920
	// RVA: 0x1FED0A0 Offset: 0x1FED1A1 VA: 0x1FED0A0
	public static PlayerInput get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C930 Offset: 0x19CA31 VA: 0x19C930
	// RVA: 0x1FED110 Offset: 0x1FED211 VA: 0x1FED110
	private static void set_Instance(PlayerInput value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C940 Offset: 0x19CA41 VA: 0x19C940
	// RVA: 0x1FED180 Offset: 0x1FED281 VA: 0x1FED180
	private PlayerInput.InputUpdate get_inputUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C950 Offset: 0x19CA51 VA: 0x19C950
	// RVA: 0x1FED190 Offset: 0x1FED291 VA: 0x1FED190
	private void set_inputUpdate(PlayerInput.InputUpdate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C960 Offset: 0x19CA61 VA: 0x19C960
	// RVA: 0x1FED1A0 Offset: 0x1FED2A1 VA: 0x1FED1A0
	private HumanController get_humanController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C970 Offset: 0x19CA71 VA: 0x19C970
	// RVA: 0x1FED1B0 Offset: 0x1FED2B1 VA: 0x1FED1B0
	private void set_humanController(HumanController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C980 Offset: 0x19CA81 VA: 0x19C980
	// RVA: 0x1FED1C0 Offset: 0x1FED2C1 VA: 0x1FED1C0
	private MonsterControllerBase get_monsterController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C990 Offset: 0x19CA91 VA: 0x19C990
	// RVA: 0x1FED1D0 Offset: 0x1FED2D1 VA: 0x1FED1D0
	private void set_monsterController(MonsterControllerBase value) { }

	// RVA: 0x1FED1E0 Offset: 0x1FED2E1 VA: 0x1FED1E0 Slot: 6
	public override void SetCharacter(Character character) { }

	// RVA: 0x1FED440 Offset: 0x1FED541 VA: 0x1FED440
	private void Awake() { }

	// RVA: 0x1FED520 Offset: 0x1FED621 VA: 0x1FED520 Slot: 4
	protected override void Start() { }

	// RVA: 0x1FED5F0 Offset: 0x1FED6F1 VA: 0x1FED5F0
	protected void OnDisable() { }

	// RVA: 0x1FED710 Offset: 0x1FED811 VA: 0x1FED710 Slot: 5
	protected override void Reset() { }

	// RVA: 0x1FED720 Offset: 0x1FED821 VA: 0x1FED720
	public bool CanInput() { }

	// RVA: 0x1FEDA30 Offset: 0x1FEDB31 VA: 0x1FEDA30
	private Vector3 InputDirection() { }

	// RVA: 0x1FEDD30 Offset: 0x1FEDE31 VA: 0x1FEDD30
	private void Update() { }

	// RVA: 0x1FEDD40 Offset: 0x1FEDE41 VA: 0x1FEDD40
	public void UpdateInput() { }

	// RVA: 0x1FEDE90 Offset: 0x1FEDF91 VA: 0x1FEDE90
	private void UpdateHumanInput() { }

	// RVA: 0x1FEECF0 Offset: 0x1FEEDF1 VA: 0x1FEECF0
	private void ChangeWeaponSlot(EquipSlotType weaponType) { }

	// RVA: 0x1FEEFC0 Offset: 0x1FEF0C1 VA: 0x1FEEFC0
	public void StartBattleMode(bool attack = False) { }

	// RVA: 0x1FEF030 Offset: 0x1FEF131 VA: 0x1FEF030
	private void UpdateMonsterInput() { }

	// RVA: 0x1FEEF50 Offset: 0x1FEF051 VA: 0x1FEEF50
	public void StartBattleMode() { }

	// RVA: 0x1FEEF10 Offset: 0x1FEF011 VA: 0x1FEEF10
	private void EndBattleMode() { }

	// RVA: 0x1FEEE50 Offset: 0x1FEEF51 VA: 0x1FEEE50
	private void LockonAutoUpdate() { }

	// RVA: 0x1FEEBA0 Offset: 0x1FEECA1 VA: 0x1FEEBA0
	public void ClearLockonTarget() { }

	// RVA: 0x1FEEC30 Offset: 0x1FEED31 VA: 0x1FEEC30
	public void PlayLockonStartSE() { }

	// RVA: 0x1FEEB90 Offset: 0x1FEEC91 VA: 0x1FEEB90
	public void PlayLockonStopSE() { }

	// RVA: 0x1FEF620 Offset: 0x1FEF721 VA: 0x1FEF620
	private void PadDataClear() { }

	// RVA: 0x1FEF740 Offset: 0x1FEF841 VA: 0x1FEF740
	public static void PadReset() { }

	// RVA: 0x1FEF8E0 Offset: 0x1FEF9E1 VA: 0x1FEF8E0
	public static void SetEnable() { }

	// RVA: 0x1FEF9B0 Offset: 0x1FEFAB1 VA: 0x1FEF9B0
	public static void SetDisable() { }

	// RVA: 0x1FEFC10 Offset: 0x1FEFD11 VA: 0x1FEFC10
	public void .ctor() { }

	// RVA: 0x1FEFF60 Offset: 0x1FF0061 VA: 0x1FEFF60
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C9A0 Offset: 0x19CAA1 VA: 0x19C9A0
	// RVA: 0x1FEFF70 Offset: 0x1FF0071 VA: 0x1FEFF70
	private void <UpdateHumanInput>b__40_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C9B0 Offset: 0x19CAB1 VA: 0x19C9B0
	// RVA: 0x1FEFFA0 Offset: 0x1FF00A1 VA: 0x1FEFFA0
	private void <UpdateHumanInput>b__40_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C9C0 Offset: 0x19CAC1 VA: 0x19C9C0
	// RVA: 0x1FEFFD0 Offset: 0x1FF00D1 VA: 0x1FEFFD0
	private void <UpdateMonsterInput>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C9D0 Offset: 0x19CAD1 VA: 0x19C9D0
	// RVA: 0x1FF0000 Offset: 0x1FF0101 VA: 0x1FF0000
	private void <UpdateMonsterInput>b__43_1() { }
}

