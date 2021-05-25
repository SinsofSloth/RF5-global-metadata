public class CharaPersonalMotionManager : SingletonMonoBehaviour<CharaPersonalMotionManager> // TypeDefIndex: 6702
{
	// Fields
	private Register<CharacterBase, PersonalMotionController> m_Register; // 0x18

	// Methods

	// RVA: 0x1D427A0 Offset: 0x1D428A1 VA: 0x1D427A0
	public bool Regist(CharacterBase chara, PersonalMotionController controller) { }

	// RVA: 0x1D42810 Offset: 0x1D42911 VA: 0x1D42810
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1D42880 Offset: 0x1D42981 VA: 0x1D42880
	public PersonalMotionController Get(CharacterBase chara) { }

	// RVA: 0x1D42930 Offset: 0x1D42A31 VA: 0x1D42930
	public void SetActivate(CharacterBase chara, bool active) { }

	// RVA: 0x1D42A60 Offset: 0x1D42B61 VA: 0x1D42A60
	public void OnMotionPlay(CharacterBase chara, int no) { }

	// RVA: 0x1D42B90 Offset: 0x1D42C91 VA: 0x1D42B90
	public void .ctor() { }
}

