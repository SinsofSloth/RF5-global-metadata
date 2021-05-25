public class SpringGeneralManager : SingletonMonoBehaviour<SpringGeneralManager> // TypeDefIndex: 6731
{
	// Fields
	[SerializeField] // RVA: 0x15F270 Offset: 0x15F371 VA: 0x15F270
	private bool m_isPaused; // 0x18
	private Register<Character, SpringManager> m_Register; // 0x20

	// Properties
	public bool IsPaused { get; set; }

	// Methods

	// RVA: 0x2248F40 Offset: 0x2249041 VA: 0x2248F40
	public bool get_IsPaused() { }

	// RVA: 0x2248F50 Offset: 0x2249051 VA: 0x2248F50
	public void set_IsPaused(bool value) { }

	// RVA: 0x2249070 Offset: 0x2249171 VA: 0x2249070
	public bool Regist(Character chara, SpringManager springManager) { }

	// RVA: 0x2249120 Offset: 0x2249221 VA: 0x2249120
	public bool Remove(Character chara) { }

	// RVA: 0x2249240 Offset: 0x2249341 VA: 0x2249240
	public SpringManager Get(Character chara) { }

	// RVA: 0x2248F60 Offset: 0x2249061 VA: 0x2248F60
	private void ApplyPause() { }

	// RVA: 0x22492F0 Offset: 0x22493F1 VA: 0x22492F0
	public void .ctor() { }
}

