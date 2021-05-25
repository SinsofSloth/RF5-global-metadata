public class SlowStateManager : SingletonMonoBehaviour<SlowStateManager> // TypeDefIndex: 6730
{
	// Fields
	private Register<CharacterBase, SlowStateController> m_Register; // 0x18

	// Methods

	// RVA: 0x210CBC0 Offset: 0x210CCC1 VA: 0x210CBC0
	public bool Regist(CharacterBase chara, SlowStateController controller) { }

	// RVA: 0x210CC30 Offset: 0x210CD31 VA: 0x210CC30
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x210CCA0 Offset: 0x210CDA1 VA: 0x210CCA0
	public SlowStateController Get(CharacterBase chara) { }

	// RVA: 0x210CD50 Offset: 0x210CE51 VA: 0x210CD50
	public bool IsSlow(CharacterBase chara) { }

	// RVA: 0x210CE70 Offset: 0x210CF71 VA: 0x210CE70
	public void DoSlow(CharacterBase chara) { }

	// RVA: 0x210CF90 Offset: 0x210D091 VA: 0x210CF90
	private void Update() { }

	// RVA: 0x210D0B0 Offset: 0x210D1B1 VA: 0x210D0B0
	public void .ctor() { }
}

