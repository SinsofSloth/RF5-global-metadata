public class CharaEscapeManager : SingletonMonoBehaviour<CharaEscapeManager> // TypeDefIndex: 6699
{
	// Fields
	[SerializeField] // RVA: 0x15EF10 Offset: 0x15F011 VA: 0x15EF10
	private EscapeShineBall m_ShileBall; // 0x18
	[SerializeField] // RVA: 0x15EF20 Offset: 0x15F021 VA: 0x15EF20
	private ParticleSystem m_AuraEffect; // 0x20
	private Register<CharacterBase, EscapeController> m_Register; // 0x28

	// Properties
	public EscapeShineBall ShineBall { get; }
	public ParticleSystem AuraEffect { get; }

	// Methods

	// RVA: 0x1D40A70 Offset: 0x1D40B71 VA: 0x1D40A70
	public EscapeShineBall get_ShineBall() { }

	// RVA: 0x1D40A80 Offset: 0x1D40B81 VA: 0x1D40A80
	public ParticleSystem get_AuraEffect() { }

	// RVA: 0x1D40A90 Offset: 0x1D40B91 VA: 0x1D40A90
	public bool Regist(CharacterBase chara, EscapeController controller) { }

	// RVA: 0x1D40B00 Offset: 0x1D40C01 VA: 0x1D40B00
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1D40B70 Offset: 0x1D40C71 VA: 0x1D40B70
	public EscapeController Get(CharacterBase chara) { }

	// RVA: 0x1D40C20 Offset: 0x1D40D21 VA: 0x1D40C20
	private void Update() { }

	// RVA: 0x1D40D40 Offset: 0x1D40E41 VA: 0x1D40D40
	public bool DoRise(CharacterBase chara, Action callback) { }

	// RVA: 0x1D40E70 Offset: 0x1D40F71 VA: 0x1D40E70
	public bool DoFall(CharacterBase chara, Action callback) { }

	// RVA: 0x1D40FA0 Offset: 0x1D410A1 VA: 0x1D40FA0
	public bool DoTakeOff(CharacterBase chara) { }

	// RVA: 0x1D410C0 Offset: 0x1D411C1 VA: 0x1D410C0
	public void DoEndAll() { }

	// RVA: 0x1D411E0 Offset: 0x1D412E1 VA: 0x1D411E0
	public bool DoCancel(CharacterBase chara) { }

	// RVA: 0x1D41330 Offset: 0x1D41431 VA: 0x1D41330
	public void .ctor() { }
}

