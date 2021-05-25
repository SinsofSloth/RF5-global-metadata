public class SuperArmorManager : SingletonMonoBehaviour<SuperArmorManager> // TypeDefIndex: 6732
{
	// Fields
	private Register<Character, SuperArmorController> m_Register; // 0x18

	// Methods

	// RVA: 0x1C62F10 Offset: 0x1C63011 VA: 0x1C62F10
	public bool Regist(Character chara, SuperArmorController controller) { }

	// RVA: 0x1C62F80 Offset: 0x1C63081 VA: 0x1C62F80
	public bool Remove(Character chara) { }

	// RVA: 0x1C62FF0 Offset: 0x1C630F1 VA: 0x1C62FF0
	public SuperArmorController Get(Character chara) { }

	// RVA: 0x1C630A0 Offset: 0x1C631A1 VA: 0x1C630A0
	private void Update() { }

	// RVA: 0x1C62CA0 Offset: 0x1C62DA1 VA: 0x1C62CA0
	public bool DoPlay(Character chara, float duration) { }

	// RVA: 0x1C63200 Offset: 0x1C63301 VA: 0x1C63200
	public bool DoStop(Character chara) { }

	// RVA: 0x1C63330 Offset: 0x1C63431 VA: 0x1C63330
	public void .ctor() { }
}

