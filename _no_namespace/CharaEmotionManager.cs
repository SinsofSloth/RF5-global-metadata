public class CharaEmotionManager : SingletonMonoBehaviour<CharaEmotionManager> // TypeDefIndex: 6698
{
	// Fields
	private Register<CharacterBase, EmotionController> m_Register; // 0x18

	// Methods

	// RVA: 0x1D40290 Offset: 0x1D40391 VA: 0x1D40290
	public bool Regist(CharacterBase chara, EmotionController controller) { }

	// RVA: 0x1D40300 Offset: 0x1D40401 VA: 0x1D40300
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1D40370 Offset: 0x1D40471 VA: 0x1D40370
	public EmotionController Get(CharacterBase chara) { }

	// RVA: 0x1D40420 Offset: 0x1D40521 VA: 0x1D40420
	public bool IsPlaying(CharacterBase chara) { }

	// RVA: 0x1D40540 Offset: 0x1D40641 VA: 0x1D40540
	public EmotionType CurrentEmotionType(CharacterBase chara) { }

	// RVA: 0x1D40660 Offset: 0x1D40761 VA: 0x1D40660
	public bool DoPlay(CharacterBase chara, EmotionType emotionType, Action callback) { }

	// RVA: 0x1D407A0 Offset: 0x1D408A1 VA: 0x1D407A0
	public bool DoStop(CharacterBase chara) { }

	// RVA: 0x1D408C0 Offset: 0x1D409C1 VA: 0x1D408C0
	public void DoStopAll() { }

	// RVA: 0x1D409E0 Offset: 0x1D40AE1 VA: 0x1D409E0
	public void .ctor() { }
}

