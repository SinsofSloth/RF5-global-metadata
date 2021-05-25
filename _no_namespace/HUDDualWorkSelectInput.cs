public class HUDDualWorkSelectInput : SingletonMonoBehaviour<HUDDualWorkSelectInput> // TypeDefIndex: 8552
{
	// Fields
	private List<HUDDualWorkSelectInput.DualSelect> canDualSelects; // 0x18
	private List<HUDDualWorkSelectInput.DualSelect> dualSelects; // 0x20
	private int selectingPartyNo; // 0x28
	private int selecting; // 0x2C
	private HashSet<Collider> m_DeleteHash; // 0x30
	private HashSet<CharacterBase> m_CheckedHash; // 0x38
	[TupleElementNamesAttribute] // RVA: 0x1707F0 Offset: 0x1708F1 VA: 0x1707F0
	private List<ValueTuple<CharacterBase, float>> m_WorkList; // 0x40
	private Dictionary<Collider, CharacterBase> m_TargetDic; // 0x48
	private List<CharacterBase> m_TargetList; // 0x50

	// Properties
	public ActorID SelectedActor { get; }

	// Methods

	// RVA: 0x1EBCD40 Offset: 0x1EBCE41 VA: 0x1EBCD40
	public ActorID get_SelectedActor() { }

	// RVA: 0x1EB8CC0 Offset: 0x1EB8DC1 VA: 0x1EB8CC0
	public void SetAddPartie(int partyNo, HUDCharactorStatus charactorStatus) { }

	// RVA: 0x1EBCE70 Offset: 0x1EBCF71 VA: 0x1EBCE70
	private void removeCanDualParties(int partyNo) { }

	// RVA: 0x1EB87E0 Offset: 0x1EB88E1 VA: 0x1EB87E0
	public void removeParties(int partyNo) { }

	// RVA: 0x1EBD0F0 Offset: 0x1EBD1F1 VA: 0x1EBD0F0
	private void Update() { }

	// RVA: 0x1EBDEE0 Offset: 0x1EBDFE1 VA: 0x1EBDEE0
	private void SearchDualSkillTarget() { }

	// RVA: 0x1EBEB80 Offset: 0x1EBEC81 VA: 0x1EBEB80
	private bool CheckDualSkillTarget(CharacterBase target) { }

	// RVA: 0x1EBEDB0 Offset: 0x1EBEEB1 VA: 0x1EBEDB0
	public bool GetDualSkillTarget(out CharacterBase outTarget) { }

	// RVA: 0x1EBEF30 Offset: 0x1EBF031 VA: 0x1EBEF30
	public bool CheckStatus(ActorID actorID) { }

	// RVA: 0x1EBF360 Offset: 0x1EBF461 VA: 0x1EBF360
	public bool CanPlayDualSkill(ActorID _actor) { }

	// RVA: 0x1EBDD70 Offset: 0x1EBDE71 VA: 0x1EBDD70
	private bool OnPlayDualSkill() { }

	// RVA: 0x1EBF3C0 Offset: 0x1EBF4C1 VA: 0x1EBF3C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7C40 Offset: 0x1A7D41 VA: 0x1A7C40
	// RVA: 0x1EBF580 Offset: 0x1EBF681 VA: 0x1EBF580
	private bool <Update>b__10_1(HUDDualWorkSelectInput.DualSelect a) { }
}

