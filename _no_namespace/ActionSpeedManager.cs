public class ActionSpeedManager : SingletonMonoBehaviour<ActionSpeedManager> // TypeDefIndex: 6690
{
	// Fields
	private Register<Character, ActionSpeedController> m_Register; // 0x18

	// Methods

	// RVA: 0x1BE47A0 Offset: 0x1BE48A1 VA: 0x1BE47A0
	public bool Regist(Character chara, ActionSpeedController controller) { }

	// RVA: 0x1BE4810 Offset: 0x1BE4911 VA: 0x1BE4810
	public bool Remove(Character chara) { }

	// RVA: 0x1BE4880 Offset: 0x1BE4981 VA: 0x1BE4880
	public ActionSpeedController Get(Character chara) { }

	// RVA: 0x1BE4930 Offset: 0x1BE4A31 VA: 0x1BE4930
	private void Update() { }

	// RVA: 0x1BE4A90 Offset: 0x1BE4B91 VA: 0x1BE4A90
	public float Speed(Character chara) { }

	// RVA: 0x1BE4450 Offset: 0x1BE4551 VA: 0x1BE4450
	public bool DoPlay(Character chara, float rate, float duration) { }

	// RVA: 0x1BE4BB0 Offset: 0x1BE4CB1 VA: 0x1BE4BB0
	public bool DoStop(Character chara) { }

	// RVA: 0x1BE4CE0 Offset: 0x1BE4DE1 VA: 0x1BE4CE0
	public void .ctor() { }
}

