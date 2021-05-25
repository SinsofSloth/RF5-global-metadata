public class PetUI : FestivalUI // TypeDefIndex: 7405
{
	// Fields
	[SerializeField] // RVA: 0x166330 Offset: 0x166431 VA: 0x166330
	private Image[] battleSprites; // 0x48
	[SerializeField] // RVA: 0x166340 Offset: 0x166441 VA: 0x166340
	private Image imageBattle; // 0x50
	[SerializeField] // RVA: 0x166350 Offset: 0x166451 VA: 0x166350
	private Image imageWin; // 0x58
	[SerializeField] // RVA: 0x166360 Offset: 0x166461 VA: 0x166360
	private Image imageLose; // 0x60

	// Methods

	// RVA: 0x1FE6B70 Offset: 0x1FE6C71 VA: 0x1FE6B70 Slot: 4
	protected override void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0A10 Offset: 0x1A0B11 VA: 0x1A0A10
	// RVA: 0x1FE4920 Offset: 0x1FE4A21 VA: 0x1FE4920
	public IEnumerator OnImageBattle(int _battle_round) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0A80 Offset: 0x1A0B81 VA: 0x1A0A80
	// RVA: 0x1FE6910 Offset: 0x1FE6A11 VA: 0x1FE6910
	public IEnumerator OnImageResult(PetManager.Result _result) { }

	// RVA: 0x1FE6C20 Offset: 0x1FE6D21 VA: 0x1FE6C20
	public void .ctor() { }
}

