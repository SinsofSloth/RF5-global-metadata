public class MagicManager : SingletonMonoBehaviour<MagicManager> // TypeDefIndex: 6719
{
	// Fields
	private const int MagicSpawnerDefaultNum = 8;
	[SerializeField] // RVA: 0x15EFE0 Offset: 0x15F0E1 VA: 0x15EFE0
	private List<AS_MagicController> m_SpawnerList; // 0x18
	private Register<CharacterBase, MagicController> m_Register; // 0x20

	// Methods

	// RVA: 0x1E0CD20 Offset: 0x1E0CE21 VA: 0x1E0CD20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E0CF40 Offset: 0x1E0D041 VA: 0x1E0CF40
	public bool Regist(CharacterBase chara, MagicController controller) { }

	// RVA: 0x1E0CFB0 Offset: 0x1E0D0B1 VA: 0x1E0CFB0
	public bool Remove(CharacterBase chara) { }

	// RVA: 0x1E0D020 Offset: 0x1E0D121 VA: 0x1E0D020
	public MagicController Get(CharacterBase chara) { }

	// RVA: 0x1E0D0D0 Offset: 0x1E0D1D1 VA: 0x1E0D0D0
	private void OnDisable() { }

	// RVA: 0x1E0D330 Offset: 0x1E0D431 VA: 0x1E0D330
	private void OnDestroy() { }

	// RVA: 0x1E0D490 Offset: 0x1E0D591 VA: 0x1E0D490
	private void Update() { }

	// RVA: 0x1E0CDF0 Offset: 0x1E0CEF1 VA: 0x1E0CDF0
	public AS_MagicController CreateSpawner() { }

	// RVA: 0x1E0D5B0 Offset: 0x1E0D6B1 VA: 0x1E0D5B0
	public AS_MagicController GetStoppedSpawner() { }

	// RVA: 0x1E0D790 Offset: 0x1E0D891 VA: 0x1E0D790
	public bool Play(CharacterBase chara, MagicID magicID, int level, AttackAttribute attribute, Vector3 offset, float rpRate) { }

	// RVA: 0x1E0D920 Offset: 0x1E0DA21 VA: 0x1E0D920
	public bool DoStop(CharacterBase chara) { }

	// RVA: 0x1E0CB60 Offset: 0x1E0CC61 VA: 0x1E0CB60
	public bool IsPlaying(CharacterBase chara) { }

	// RVA: 0x1E0DA50 Offset: 0x1E0DB51 VA: 0x1E0DA50
	public List<Collider> GetTargets(CharacterBase chara) { }

	// RVA: 0x1E0D0E0 Offset: 0x1E0D1E1 VA: 0x1E0D0E0
	public void DoStopAll() { }

	// RVA: 0x1E0DB60 Offset: 0x1E0DC61 VA: 0x1E0DB60
	public bool AddBullet(CharacterBase chara, BulletBase bullet) { }

	// RVA: 0x1E0DC90 Offset: 0x1E0DD91 VA: 0x1E0DC90
	public bool StartBulletExtension(CharacterBase chara) { }

	// RVA: 0x1E0DDB0 Offset: 0x1E0DEB1 VA: 0x1E0DDB0
	public bool StopBulletExtension(CharacterBase chara) { }

	// RVA: 0x1E0DED0 Offset: 0x1E0DFD1 VA: 0x1E0DED0
	public void .ctor() { }
}

