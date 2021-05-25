public class UIWantedClearedPaper : MonoBehaviour // TypeDefIndex: 8775
{
	// Fields
	[SerializeField] // RVA: 0x1735D0 Offset: 0x1736D1 VA: 0x1735D0
	private Image MonsterIcon; // 0x18
	[SerializeField] // RVA: 0x1735E0 Offset: 0x1736E1 VA: 0x1735E0
	private Image[] StarRanks; // 0x20
	[SerializeField] // RVA: 0x1735F0 Offset: 0x1736F1 VA: 0x1735F0
	private Sprite StarOn; // 0x28
	[SerializeField] // RVA: 0x173600 Offset: 0x173701 VA: 0x173600
	private Sprite StarOff; // 0x30
	[SerializeField] // RVA: 0x173610 Offset: 0x173711 VA: 0x173610
	private Text RewardText; // 0x38
	private int monsterSpriteId; // 0x40
	private const int SpriteAtlasId = 19765;
	private AssetHandle<SpriteAtlas> handle; // 0x48

	// Methods

	// RVA: 0x1FF96B0 Offset: 0x1FF97B1 VA: 0x1FF96B0
	public void SetBlock(WantedData wantedData) { }

	// RVA: 0x1FF9820 Offset: 0x1FF9921 VA: 0x1FF9820
	private void Start() { }

	// RVA: 0x1FF9AB0 Offset: 0x1FF9BB1 VA: 0x1FF9AB0
	public void LoadedMonsterIcon(AssetHandle<SpriteAtlas> _handle) { }

	// RVA: 0x1FF9BA0 Offset: 0x1FF9CA1 VA: 0x1FF9BA0
	private void OnDestroy() { }

	// RVA: 0x1FF9C20 Offset: 0x1FF9D21 VA: 0x1FF9C20
	public void .ctor() { }
}

