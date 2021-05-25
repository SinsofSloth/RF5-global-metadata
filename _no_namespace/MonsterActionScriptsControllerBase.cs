public class MonsterActionScriptsControllerBase : ActionScriptControllerBase // TypeDefIndex: 6230
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15BE40 Offset: 0x15BF41 VA: 0x15BE40
	private MonsterActionCodeDataTableArray <ActionCodeDataTableArray>k__BackingField; // 0x140
	private MonsterControllerBase _Monster; // 0x148
	public UnityEvent OnEndActionScriptEvent; // 0x150
	public MonsterProjectileEvent MonsterProjectileEvent; // 0x158
	public int CurrentActionIndex; // 0x160
	private MonsterVoiceController _MonsterVoiceController; // 0x168
	private List<CharacterBase> HitCharacterBaseList; // 0x170
	private float ClearHitListTime; // 0x178
	private float ClearHitListTimer; // 0x17C

	// Properties
	public MonsterControllerBase Monster { get; }
	public override Character Character { get; }
	public MonsterVoiceController MonsterVoiceController { get; }
	public MonsterActionCodeDataTableArray ActionCodeDataTableArray { get; set; }
	public List<CharacterBase> HitCharacterList { get; }

	// Methods

	// RVA: 0x1CC7710 Offset: 0x1CC7811 VA: 0x1CC7710
	public MonsterControllerBase get_Monster() { }

	// RVA: 0x1CC7BD0 Offset: 0x1CC7CD1 VA: 0x1CC7BD0 Slot: 4
	public override Character get_Character() { }

	// RVA: 0x1CC7C80 Offset: 0x1CC7D81 VA: 0x1CC7C80
	public MonsterVoiceController get_MonsterVoiceController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A800 Offset: 0x19A901 VA: 0x19A800
	// RVA: 0x1CC7D30 Offset: 0x1CC7E31 VA: 0x1CC7D30
	public MonsterActionCodeDataTableArray get_ActionCodeDataTableArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A810 Offset: 0x19A911 VA: 0x19A810
	// RVA: 0x1CC7D40 Offset: 0x1CC7E41 VA: 0x1CC7D40
	protected void set_ActionCodeDataTableArray(MonsterActionCodeDataTableArray value) { }

	// RVA: 0x1CC7D50 Offset: 0x1CC7E51 VA: 0x1CC7D50
	public List<CharacterBase> get_HitCharacterList() { }

	// RVA: 0x1CC7D60 Offset: 0x1CC7E61 VA: 0x1CC7D60
	public void SetNextActionCodeName(string actionCodeName) { }

	// RVA: 0x1CC7D70 Offset: 0x1CC7E71 VA: 0x1CC7D70 Slot: 24
	public virtual void SetActionCodeDataTableArray(MonsterActionCodeDataTableArray array) { }

	// RVA: 0x1CC6900 Offset: 0x1CC6A01 VA: 0x1CC6900 Slot: 25
	public virtual void SharedProjectileControllerParameter(MonsterProjectileActionScriptsController controller) { }

	// RVA: 0x1CC7EE0 Offset: 0x1CC7FE1 VA: 0x1CC7EE0 Slot: 26
	public virtual MonsterProjectileActionScriptsController CreateProjectileBullet() { }

	// RVA: 0x1CC7FB0 Offset: 0x1CC80B1 VA: 0x1CC7FB0 Slot: 10
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable) { }

	// RVA: 0x1CC80D0 Offset: 0x1CC81D1 VA: 0x1CC80D0 Slot: 11
	public override void InternalSetUpActionCode(string actionCodeName) { }

	// RVA: 0x1CC8370 Offset: 0x1CC8471 VA: 0x1CC8370 Slot: 13
	public override void StopAction() { }

	// RVA: 0x1CC83C0 Offset: 0x1CC84C1 VA: 0x1CC83C0 Slot: 12
	public override void DoAction(ActionCode actionCode) { }

	// RVA: 0x1CC84B0 Offset: 0x1CC85B1 VA: 0x1CC84B0 Slot: 23
	protected override void Update() { }

	// RVA: 0x1CC86C0 Offset: 0x1CC87C1 VA: 0x1CC86C0
	public void SetClearHitListTime(float time) { }

	// RVA: 0x1CC8440 Offset: 0x1CC8541 VA: 0x1CC8440
	public void ClearHitList() { }

	// RVA: 0x1CC8600 Offset: 0x1CC8701 VA: 0x1CC8600
	private void UpdateClearHitList() { }

	// RVA: 0x1CC7AA0 Offset: 0x1CC7BA1 VA: 0x1CC7AA0
	public void .ctor() { }
}

