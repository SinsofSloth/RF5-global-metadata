public class RestraintManager : SingletonMonoBehaviour<RestraintManager> // TypeDefIndex: 6727
{
	// Fields
	private Register<Character, RestraintController> m_Register; // 0x18

	// Methods

	// RVA: 0x232BF50 Offset: 0x232C051 VA: 0x232BF50
	private void Update() { }

	// RVA: 0x232C070 Offset: 0x232C171 VA: 0x232C070
	public bool Regist(Character chara, RestraintController controller) { }

	// RVA: 0x232C0E0 Offset: 0x232C1E1 VA: 0x232C0E0
	public bool Remove(Character chara) { }

	// RVA: 0x232C150 Offset: 0x232C251 VA: 0x232C150
	public RestraintController Get(Character chara) { }

	// RVA: 0x232C200 Offset: 0x232C301 VA: 0x232C200
	public bool IsRestraint(Character chara) { }

	// RVA: 0x232C320 Offset: 0x232C421 VA: 0x232C320
	public void OnRestraint(Character chara) { }

	// RVA: 0x232C440 Offset: 0x232C541 VA: 0x232C440
	public void .ctor() { }
}

