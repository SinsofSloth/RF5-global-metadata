public class SubEventData // TypeDefIndex: 7278
{
	// Fields
	public SubEventMasterDataBase MasterData; // 0x10
	public SubEventSaveParameter SaveParameter; // 0x18
	public Dictionary<int, int> NpcAdvSteps; // 0x20
	public string Title; // 0x28
	public string Explain; // 0x30
	private List<int> tempList; // 0x38

	// Methods

	// RVA: 0x22519A0 Offset: 0x2251AA1 VA: 0x22519A0
	public void .ctor() { }

	// RVA: 0x2251AA0 Offset: 0x2251BA1 VA: 0x2251AA0
	private void NpcAdvStepOff() { }

	// RVA: 0x2251D00 Offset: 0x2251E01 VA: 0x2251D00
	public void ChangeStep(int step, Action<SubEventMasterDataBase, int> call) { }

	// RVA: 0x2251DC0 Offset: 0x2251EC1 VA: 0x2251DC0
	public void InitializeNpcAdvSteps() { }

	// RVA: 0x2251E70 Offset: 0x2251F71 VA: 0x2251E70
	public void UpdateNpcAdvSteps() { }

	// RVA: 0x2251E80 Offset: 0x2251F81 VA: 0x2251E80
	public void ApplyNpcAdvSteps() { }

	// RVA: 0x2251E90 Offset: 0x2251F91 VA: 0x2251E90
	public void ApplyText() { }
}

