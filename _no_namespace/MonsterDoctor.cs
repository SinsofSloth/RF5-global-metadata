public class MonsterDoctor : SingletonMonoBehaviour<MonsterDoctor> // TypeDefIndex: 8096
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16A450 Offset: 0x16A551 VA: 0x16A450
	private int <SelectedPet>k__BackingField; // 0x18
	private List<PartyMonster> monsterPets; // 0x20
	private Dictionary<MonsterDoctor.EvaluationType, string> evaluationText; // 0x28

	// Properties
	public int SelectedPet { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A5C40 Offset: 0x1A5D41 VA: 0x1A5C40
	// RVA: 0x21714A0 Offset: 0x21715A1 VA: 0x21714A0
	public int get_SelectedPet() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5C50 Offset: 0x1A5D51 VA: 0x1A5C50
	// RVA: 0x21714B0 Offset: 0x21715B1 VA: 0x21714B0
	public void set_SelectedPet(int value) { }

	// RVA: 0x21714C0 Offset: 0x21715C1 VA: 0x21714C0
	private void Start() { }

	// RVA: 0x21718F0 Offset: 0x21719F1 VA: 0x21718F0
	public int GetMonsterPetAmount() { }

	// RVA: 0x2171B40 Offset: 0x2171C41 VA: 0x2171B40
	public List<string> GetMonsterPetName() { }

	// RVA: 0x2171C80 Offset: 0x2171D81 VA: 0x2171C80
	public int GetMonsterPetBonus() { }

	// RVA: 0x2171E30 Offset: 0x2171F31 VA: 0x2171E30
	public int GetMonsterPetLevel() { }

	// RVA: 0x2171EE0 Offset: 0x2171FE1 VA: 0x2171EE0
	public int GetMonsterPetLove() { }

	// RVA: 0x2171FB0 Offset: 0x21720B1 VA: 0x2171FB0
	public List<string> GetAttributeResistance() { }

	// RVA: 0x2172290 Offset: 0x2172391 VA: 0x2172290
	public List<string> GetBadStatusAttack() { }

	// RVA: 0x2172570 Offset: 0x2172671 VA: 0x2172570
	public List<string> GetBadStatusDefence() { }

	// RVA: 0x2172850 Offset: 0x2172951 VA: 0x2172850
	public List<string> GetSpecialStatus() { }

	// RVA: 0x2171AD0 Offset: 0x2171BD1 VA: 0x2171AD0
	private void Clear() { }

	// RVA: 0x2172AE0 Offset: 0x2172BE1 VA: 0x2172AE0
	public void .ctor() { }
}

