public class CharaSoulManager : SingletonMonoBehaviour<CharaSoulManager> // TypeDefIndex: 6703
{
	// Fields
	private Register<CharacterBase, SoulController> m_Register; // 0x18

	// Methods

	// RVA: 0x1D42C20 Offset: 0x1D42D21 VA: 0x1D42C20
	public bool Regist(CharacterBase chara, SoulController controller) { }

	// RVA: 0x1D42C90 Offset: 0x1D42D91 VA: 0x1D42C90
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1D42D00 Offset: 0x1D42E01 VA: 0x1D42D00
	public SoulController Get(CharacterBase chara) { }

	// RVA: 0x1D42DB0 Offset: 0x1D42EB1 VA: 0x1D42DB0
	public bool DoPlay(CharacterBase chara, Collider target, Action collback) { }

	// RVA: 0x1D42EF0 Offset: 0x1D42FF1 VA: 0x1D42EF0
	public void DoEndAll() { }

	// RVA: 0x1D43010 Offset: 0x1D43111 VA: 0x1D43010
	public void .ctor() { }
}

