public class BattleModeManager : SingletonMonoBehaviour<BattleModeManager> // TypeDefIndex: 6694
{
	// Fields
	private Register<Character, BattleModeController> m_Register; // 0x18

	// Methods

	// RVA: 0x20D5480 Offset: 0x20D5581 VA: 0x20D5480
	public bool Regist(Character chara, BattleModeController controller) { }

	// RVA: 0x20D54F0 Offset: 0x20D55F1 VA: 0x20D54F0
	public bool Remove(Character chara) { }

	// RVA: 0x20D5560 Offset: 0x20D5661 VA: 0x20D5560
	public BattleModeController Get(Character chara) { }

	// RVA: 0x20D5610 Offset: 0x20D5711 VA: 0x20D5610
	public bool CanStart(Character chara) { }

	// RVA: 0x20D5730 Offset: 0x20D5831 VA: 0x20D5730
	public bool DoStart(Character chara, bool Immediate) { }

	// RVA: 0x20D5860 Offset: 0x20D5961 VA: 0x20D5860
	public bool DoEnd(Character chara, bool Immediate) { }

	// RVA: 0x20D5990 Offset: 0x20D5A91 VA: 0x20D5990
	public bool IsBattleMode(Character chara) { }

	// RVA: 0x20D5AB0 Offset: 0x20D5BB1 VA: 0x20D5AB0
	public void .ctor() { }
}

