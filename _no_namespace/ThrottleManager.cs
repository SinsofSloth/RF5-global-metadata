public class ThrottleManager : SingletonMonoBehaviour<ThrottleManager> // TypeDefIndex: 6733
{
	// Fields
	private Register<CharacterBase, ThrottleController> m_Register; // 0x18

	// Methods

	// RVA: 0x1D146D0 Offset: 0x1D147D1 VA: 0x1D146D0
	public bool Regist(CharacterBase chara, ThrottleController controller) { }

	// RVA: 0x1D14740 Offset: 0x1D14841 VA: 0x1D14740
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1D147B0 Offset: 0x1D148B1 VA: 0x1D147B0
	public ThrottleController Get(CharacterBase chara) { }

	// RVA: 0x1D14860 Offset: 0x1D14961 VA: 0x1D14860
	private void Update() { }

	// RVA: 0x1D14980 Offset: 0x1D14A81 VA: 0x1D14980
	public bool DoPlay(CharacterBase chara, ThrottleID slot) { }

	// RVA: 0x1D14AB0 Offset: 0x1D14BB1 VA: 0x1D14AB0
	public bool DoStop(CharacterBase chara) { }

	// RVA: 0x1D14BE0 Offset: 0x1D14CE1 VA: 0x1D14BE0
	public bool DoStop(CharacterBase chara, ThrottleID throttleID) { }

	// RVA: 0x1D14D10 Offset: 0x1D14E11 VA: 0x1D14D10
	public void DoStopAll() { }

	// RVA: 0x1D14E20 Offset: 0x1D14F21 VA: 0x1D14E20
	public bool IsPlaying(CharacterBase chara) { }

	// RVA: 0x1D14F40 Offset: 0x1D15041 VA: 0x1D14F40
	public ThrottleID CurrentThrottleID(CharacterBase chara) { }

	// RVA: 0x1D15060 Offset: 0x1D15161 VA: 0x1D15060
	public void .ctor() { }
}

