public class CharaLazyManager : SingletonMonoBehaviour<CharaLazyManager> // TypeDefIndex: 6701
{
	// Fields
	[SerializeField] // RVA: 0x15EF30 Offset: 0x15F031 VA: 0x15EF30
	private bool m_isLazy; // 0x18
	private Register<Character, LazyController> m_Register; // 0x20

	// Methods

	// RVA: 0x1D41AF0 Offset: 0x1D41BF1 VA: 0x1D41AF0
	public bool Regist(Character chara, LazyController controller) { }

	// RVA: 0x1D41BA0 Offset: 0x1D41CA1 VA: 0x1D41BA0
	public bool Remove(Character chara) { }

	// RVA: 0x1D41C10 Offset: 0x1D41D11 VA: 0x1D41C10
	public LazyController Get(Character chara) { }

	// RVA: 0x1D41CC0 Offset: 0x1D41DC1 VA: 0x1D41CC0
	public void SetLazy(bool isLazy) { }

	// RVA: 0x1D41E00 Offset: 0x1D41F01 VA: 0x1D41E00
	public void ResetLazy(Character chara) { }

	// RVA: 0x1D41F20 Offset: 0x1D42021 VA: 0x1D41F20
	public bool IsLasy(Character chara) { }

	// RVA: 0x1D42040 Offset: 0x1D42141 VA: 0x1D42040
	public bool DoUpdateEmotion(Character chara) { }

	// RVA: 0x1D42170 Offset: 0x1D42271 VA: 0x1D42170
	private void OnValidate() { }

	// RVA: 0x1D42180 Offset: 0x1D42281 VA: 0x1D42180
	public void .ctor() { }
}

