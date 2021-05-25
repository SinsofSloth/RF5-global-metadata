[Serializable]
public class YawnManager : SingletonMonoBehaviour<YawnManager> // TypeDefIndex: 6734
{
	// Fields
	private Register<Character, YawnController> m_Register; // 0x18
	private Dictionary<Character, float> m_PlayOrder; // 0x20
	private List<Character> m_DeleteList; // 0x28

	// Methods

	// RVA: 0x26A2E00 Offset: 0x26A2F01 VA: 0x26A2E00
	public bool Regist(Character chara, YawnController controller) { }

	// RVA: 0x26A2E70 Offset: 0x26A2F71 VA: 0x26A2E70
	public bool Remove(Character chara) { }

	// RVA: 0x26A2EE0 Offset: 0x26A2FE1 VA: 0x26A2EE0
	public YawnController Get(Character chara) { }

	// RVA: 0x26A2F90 Offset: 0x26A3091 VA: 0x26A2F90
	private void Start() { }

	// RVA: 0x26A3100 Offset: 0x26A3201 VA: 0x26A3100
	private void Update() { }

	// RVA: 0x26A35A0 Offset: 0x26A36A1 VA: 0x26A35A0
	private void OnDayCarry(int days) { }

	// RVA: 0x26A3600 Offset: 0x26A3701 VA: 0x26A3600
	private void OnHourCarry(int hours) { }

	// RVA: 0x26A36A0 Offset: 0x26A37A1 VA: 0x26A36A0
	public void DoPlayAll(float duration) { }

	// RVA: 0x26A3470 Offset: 0x26A3571 VA: 0x26A3470
	public bool DoPlay(Character chara, float duration) { }

	// RVA: 0x26A3860 Offset: 0x26A3961 VA: 0x26A3860
	public bool DoStop(Character chara) { }

	// RVA: 0x26A39A0 Offset: 0x26A3AA1 VA: 0x26A39A0
	public void DoStopAll() { }

	// RVA: 0x26A3AE0 Offset: 0x26A3BE1 VA: 0x26A3AE0
	public void .ctor() { }
}

