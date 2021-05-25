private class HUDDualWorkSelectInput.DualSelect // TypeDefIndex: 8553
{
	// Fields
	public HumanStatus status; // 0x10
	public int partyNo; // 0x18
	public HUDCharactorStatus charactorStatus; // 0x20
	public bool CanDual; // 0x28
	public float nowGauge; // 0x2C

	// Methods

	// RVA: 0x1EBCE00 Offset: 0x1EBCF01 VA: 0x1EBCE00
	public void .ctor(HumanStatus _status, int _partyNo, HUDCharactorStatus _charactorStatus) { }

	// RVA: 0x1EBDC00 Offset: 0x1EBDD01 VA: 0x1EBDC00
	public bool CheckCanDualChange() { }

	// RVA: 0x1EBDCA0 Offset: 0x1EBDDA1 VA: 0x1EBDCA0
	public void UpdateGauge() { }
}

