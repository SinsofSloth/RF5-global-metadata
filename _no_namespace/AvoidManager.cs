public class AvoidManager : SingletonMonoBehaviour<AvoidManager> // TypeDefIndex: 6693
{
	// Fields
	private Register<Character, AvoidController> m_Register; // 0x18

	// Methods

	// RVA: 0x2154CF0 Offset: 0x2154DF1 VA: 0x2154CF0
	public bool Regist(Character chara, AvoidController controller) { }

	// RVA: 0x2154D60 Offset: 0x2154E61 VA: 0x2154D60
	public bool Remove(Character chara) { }

	// RVA: 0x2154DD0 Offset: 0x2154ED1 VA: 0x2154DD0
	public AvoidController Get(Character chara) { }

	// RVA: 0x2154E80 Offset: 0x2154F81 VA: 0x2154E80
	private void Update() { }

	// RVA: 0x2154FA0 Offset: 0x21550A1 VA: 0x2154FA0
	public bool CanPlay(Character chara) { }

	// RVA: 0x2154AA0 Offset: 0x2154BA1 VA: 0x2154AA0
	public bool DoPlay(Character chara) { }

	// RVA: 0x21550C0 Offset: 0x21551C1 VA: 0x21550C0
	public bool DoStop(Character chara) { }

	// RVA: 0x21551F0 Offset: 0x21552F1 VA: 0x21551F0
	public void DoCancel(Character chara) { }

	// RVA: 0x2155310 Offset: 0x2155411 VA: 0x2155310
	public void DoCancelAll() { }

	// RVA: 0x2155420 Offset: 0x2155521 VA: 0x2155420
	public bool IsPlaying(Character chara) { }

	// RVA: 0x2155540 Offset: 0x2155641 VA: 0x2155540
	public bool IsAnimation(Character chara) { }

	// RVA: 0x2155660 Offset: 0x2155761 VA: 0x2155660
	public void .ctor() { }
}

