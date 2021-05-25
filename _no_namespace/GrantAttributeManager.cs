public class GrantAttributeManager : SingletonMonoBehaviour<GrantAttributeManager> // TypeDefIndex: 6715
{
	// Fields
	protected const float DefaultDuration = 2;
	private Register<Character, GrantAttributeController> m_Register; // 0x18

	// Methods

	// RVA: 0x1EB2A50 Offset: 0x1EB2B51 VA: 0x1EB2A50
	public bool Regist(Character chara, GrantAttributeController controller) { }

	// RVA: 0x1EB2AC0 Offset: 0x1EB2BC1 VA: 0x1EB2AC0
	public bool Remove(Character chara) { }

	// RVA: 0x1EB2B30 Offset: 0x1EB2C31 VA: 0x1EB2B30
	public GrantAttributeController Get(Character chara) { }

	// RVA: 0x1EB2BE0 Offset: 0x1EB2CE1 VA: 0x1EB2BE0
	private void Update() { }

	// RVA: 0x1EB2D00 Offset: 0x1EB2E01 VA: 0x1EB2D00
	public bool DoSet(Character chara, AttackAttribute attribute, float duraion = 2) { }

	// RVA: 0x1EB2E50 Offset: 0x1EB2F51 VA: 0x1EB2E50
	public bool DoAdd(Character chara) { }

	// RVA: 0x1EB2F70 Offset: 0x1EB3071 VA: 0x1EB2F70
	public void DoRemove(Character chara, AttackAttribute attribute) { }

	// RVA: 0x1EB30A0 Offset: 0x1EB31A1 VA: 0x1EB30A0
	public void DoClear(Character chara) { }

	// RVA: 0x1EB31C0 Offset: 0x1EB32C1 VA: 0x1EB31C0
	public AttackAttribute GetAttribute(Character chara) { }

	// RVA: 0x1EB32E0 Offset: 0x1EB33E1 VA: 0x1EB32E0
	public void .ctor() { }
}

