public class CharaFishingStateManager : SingletonMonoBehaviour<CharaFishingStateManager> // TypeDefIndex: 6700
{
	// Fields
	private Register<CharacterBase, FishingStateController> m_Register; // 0x18

	// Methods

	// RVA: 0x1D41560 Offset: 0x1D41661 VA: 0x1D41560
	public bool Regist(CharacterBase chara, FishingStateController controller) { }

	// RVA: 0x1D415D0 Offset: 0x1D416D1 VA: 0x1D415D0
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1D41640 Offset: 0x1D41741 VA: 0x1D41640
	public FishingStateController Get(CharacterBase chara) { }

	// RVA: 0x1D416F0 Offset: 0x1D417F1 VA: 0x1D416F0
	public void SetState(CharacterBase chara, FishingState state) { }

	// RVA: 0x1D41820 Offset: 0x1D41921 VA: 0x1D41820
	public void OnExit(CharacterBase chara) { }

	// RVA: 0x1D41940 Offset: 0x1D41A41 VA: 0x1D41940
	public bool DoWkiCast(CharacterBase chara) { }

	// RVA: 0x1D41A60 Offset: 0x1D41B61 VA: 0x1D41A60
	public void .ctor() { }
}

