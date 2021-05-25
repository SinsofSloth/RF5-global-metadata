public class MapIconMng : SingletonMonoBehaviour<MapIconMng> // TypeDefIndex: 6834
{
	// Fields
	[SerializeField] // RVA: 0x15FCC0 Offset: 0x15FDC1 VA: 0x15FCC0
	private Sprite[] NPCIconSprites; // 0x18
	[SerializeField] // RVA: 0x15FCD0 Offset: 0x15FDD1 VA: 0x15FCD0
	private Sprite[] BuildIconSprites_OFF; // 0x20
	[SerializeField] // RVA: 0x15FCE0 Offset: 0x15FDE1 VA: 0x15FCE0
	private Sprite[] BuildIconSprites_ON; // 0x28
	[SerializeField] // RVA: 0x15FCF0 Offset: 0x15FDF1 VA: 0x15FCF0
	private Sprite[] BuildNotIconSprites_OFF; // 0x30
	[SerializeField] // RVA: 0x15FD00 Offset: 0x15FE01 VA: 0x15FD00
	private Sprite[] BuildNotIconSprites_ON; // 0x38
	[SerializeField] // RVA: 0x15FD10 Offset: 0x15FE11 VA: 0x15FD10
	private Sprite[] WarpIconSprites_OFF; // 0x40
	[SerializeField] // RVA: 0x15FD20 Offset: 0x15FE21 VA: 0x15FD20
	private Sprite[] WarpIconSprites_ON; // 0x48
	[SerializeField] // RVA: 0x15FD30 Offset: 0x15FE31 VA: 0x15FD30
	private Sprite[] QuestIconSprites; // 0x50
	[SerializeField] // RVA: 0x15FD40 Offset: 0x15FE41 VA: 0x15FD40
	private Sprite[] EnemyIconSprites; // 0x58
	[SerializeField] // RVA: 0x15FD50 Offset: 0x15FE51 VA: 0x15FD50
	private Vector3[] BuildIconPos; // 0x60
	private Sprite[] ChildIconSprites; // 0x68
	private bool[] ChildIconFlg; // 0x70
	private SpriteAtlas childAtlas; // 0x78

	// Methods

	// RVA: 0x1E1D4A0 Offset: 0x1E1D5A1 VA: 0x1E1D4A0
	private void Start() { }

	// RVA: 0x1E1D6C0 Offset: 0x1E1D7C1 VA: 0x1E1D6C0
	private void Update() { }

	// RVA: 0x1E1D6D0 Offset: 0x1E1D7D1 VA: 0x1E1D6D0
	public void setChildIcon(int childNo, int sex, int type, int color) { }

	// RVA: 0x1E1DB90 Offset: 0x1E1DC91 VA: 0x1E1DB90
	public Sprite getChildIcon(int childNo) { }

	// RVA: 0x1E19D40 Offset: 0x1E19E41 VA: 0x1E19D40
	public Sprite getNpcIconNo(int npcNo) { }

	// RVA: 0x1E19800 Offset: 0x1E19901 VA: 0x1E19800
	public Sprite getNpcIcon(int npcId) { }

	// RVA: 0x1E1A690 Offset: 0x1E1A791 VA: 0x1E1A690
	public Sprite getBuildIcon(int iconNo, bool onFlg) { }

	// RVA: 0x1E144E0 Offset: 0x1E145E1 VA: 0x1E144E0
	public Sprite getWarpIcon(int iconNo, bool onFlg) { }

	// RVA: 0x1E1A640 Offset: 0x1E1A741 VA: 0x1E1A640
	public Sprite getQuestIcon(int iconNo) { }

	// RVA: 0x1E1DBE0 Offset: 0x1E1DCE1 VA: 0x1E1DBE0
	public Sprite getEnemyIcon(int iconNo) { }

	// RVA: 0x1E19D90 Offset: 0x1E19E91 VA: 0x1E19D90
	public Sprite getPartnerIcon() { }

	// RVA: 0x1E14A80 Offset: 0x1E14B81 VA: 0x1E14A80
	public Vector3 getBuildIconPos(int iconNo) { }

	// RVA: 0x1E14DC0 Offset: 0x1E14EC1 VA: 0x1E14DC0
	public int getBuildIconMax() { }

	// RVA: 0x1E1D840 Offset: 0x1E1D941 VA: 0x1E1D840
	private Sprite getIconSprite(int sex, int type, int color) { }

	// RVA: 0x1E1D5C0 Offset: 0x1E1D6C1 VA: 0x1E1D5C0
	private void LoadChildSprite() { }

	// RVA: 0x1E1DC30 Offset: 0x1E1DD31 VA: 0x1E1DC30
	private void OnDestroy() { }

	// RVA: 0x1E1DCF0 Offset: 0x1E1DDF1 VA: 0x1E1DCF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D360 Offset: 0x19D461 VA: 0x19D360
	// RVA: 0x1E1DD40 Offset: 0x1E1DE41 VA: 0x1E1DD40
	private void <LoadChildSprite>b__27_0(AssetHandle<SpriteAtlas> handle) { }
}

