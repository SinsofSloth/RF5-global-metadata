public class HateController : SearchCharacterController // TypeDefIndex: 6429
{
	// Fields
	private List<int> HateValueList; // 0xA8
	private float DecreaseTime; // 0xB0
	private float DecreaseTimeOutOfAttackRange; // 0xB4
	private float DecreaseTimeCancelBattleMode; // 0xB8
	private List<int> RemoveHateValueParameterIndexList; // 0xC0
	private List<HateController.HateParameter> HateParamList; // 0xC8
	private int LookTargetSearchType; // 0xD0
	private List<Alliance> TargetAllianceList; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x15C600 Offset: 0x15C701 VA: 0x15C600
	private bool <IsBattleMode>k__BackingField; // 0xE0
	private bool IsForceBattleMode; // 0xE1

	// Properties
	public bool IsBattleMode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B040 Offset: 0x19B141 VA: 0x19B040
	// RVA: 0x22FCF20 Offset: 0x22FD021 VA: 0x22FCF20
	public bool get_IsBattleMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B050 Offset: 0x19B151 VA: 0x19B050
	// RVA: 0x22FCF30 Offset: 0x22FD031 VA: 0x22FCF30
	protected void set_IsBattleMode(bool value) { }

	// RVA: 0x22FCF40 Offset: 0x22FD041 VA: 0x22FCF40
	public void SetLookTargetSearchType(int lookTargetSearchType) { }

	// RVA: 0x22FCF50 Offset: 0x22FD051 VA: 0x22FCF50
	public void SetBattleMode(bool isBattleMode) { }

	// RVA: 0x22FCF60 Offset: 0x22FD061 VA: 0x22FCF60
	public void SetForceBattleMode(bool isForceBattleMode) { }

	// RVA: 0x22FCF70 Offset: 0x22FD071 VA: 0x22FCF70
	public void AddTargetAlliance(Alliance alliance) { }

	// RVA: 0x22FD010 Offset: 0x22FD111 VA: 0x22FD010 Slot: 4
	protected override void OnSetup() { }

	// RVA: 0x22FD080 Offset: 0x22FD181 VA: 0x22FD080 Slot: 5
	protected override void OnBeforeTick() { }

	// RVA: 0x22FD260 Offset: 0x22FD361 VA: 0x22FD260 Slot: 6
	protected override void OnFindCharacter(Character character, int searchParameterType) { }

	// RVA: 0x22FD7C0 Offset: 0x22FD8C1 VA: 0x22FD7C0
	public HateController.HateParameter GetHateParameter(Character character) { }

	// RVA: 0x22FD900 Offset: 0x22FDA01 VA: 0x22FD900
	public Character GetMostHateCharacter() { }

	// RVA: 0x22FDBE0 Offset: 0x22FDCE1 VA: 0x22FDBE0
	public Character FindCharacter(int initValue, Func<HateController.HateParameter, int, int> func) { }

	// RVA: 0x22FD420 Offset: 0x22FD521 VA: 0x22FD420
	public void AddCharacter(Character character) { }

	// RVA: 0x22FDDE0 Offset: 0x22FDEE1 VA: 0x22FDDE0
	public void ClearHateValueDic() { }

	// RVA: 0x22FDEE0 Offset: 0x22FDFE1 VA: 0x22FDEE0
	public void UpdateHateValue() { }

	// RVA: 0x22FD360 Offset: 0x22FD461 VA: 0x22FD360
	public int FindIndexHateParameterListByCharacter(int charactergameobjectInstanceID) { }

	// RVA: 0x22FE2D0 Offset: 0x22FE3D1 VA: 0x22FE2D0
	private void AddHateValue(Character character, HateController.HateValueType hateValueType) { }

	// RVA: 0x22FE1C0 Offset: 0x22FE2C1 VA: 0x22FE1C0
	private void AddHateValue(HateController.HateParameter parameter, HateController.HateValueType hateValueType) { }

	// RVA: 0x22FDB10 Offset: 0x22FDC11 VA: 0x22FDB10
	private bool IsDeleteHate(Character character) { }

	// RVA: 0x22FDDD0 Offset: 0x22FDED1 VA: 0x22FDDD0
	public void Contact(Character character) { }

	// RVA: 0x22FE4A0 Offset: 0x22FE5A1 VA: 0x22FE4A0
	public void Damage(Character character, bool isCritical = False) { }

	// RVA: 0x22FE9B0 Offset: 0x22FEAB1 VA: 0x22FE9B0
	public void .ctor() { }
}

