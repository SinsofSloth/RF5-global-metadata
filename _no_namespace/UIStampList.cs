public class UIStampList : UIScrollBoxBase // TypeDefIndex: 8697
{
	// Fields
	[SerializeField] // RVA: 0x172760 Offset: 0x172861 VA: 0x172760
	private Image bigStampIcon; // 0x68
	[SerializeField] // RVA: 0x172770 Offset: 0x172871 VA: 0x172770
	private Text stampProgressText; // 0x70
	[SerializeField] // RVA: 0x172780 Offset: 0x172881 VA: 0x172780
	private Text stampNameText; // 0x78
	[SerializeField] // RVA: 0x172790 Offset: 0x172891 VA: 0x172790
	private Text stampContentText; // 0x80
	private SpriteAtlas stampSpriteAtlas; // 0x88
	private const int STAMP_SPRITE_ATLAS_ID = 19764;
	private StampDataTable stampDataTable; // 0x90
	private Dictionary<string, Sprite> stampSpriteDict; // 0x98

	// Methods

	// RVA: 0x1FF1720 Offset: 0x1FF1821 VA: 0x1FF1720
	private void OnEnable() { }

	// RVA: 0x1FF1E40 Offset: 0x1FF1F41 VA: 0x1FF1E40 Slot: 9
	protected override void Update() { }

	// RVA: 0x1FF31A0 Offset: 0x1FF32A1 VA: 0x1FF31A0 Slot: 10
	protected override void OnDisable() { }

	// RVA: 0x1FF32D0 Offset: 0x1FF33D1 VA: 0x1FF32D0
	public void OnSlotTouch(UIStampSlot _slot) { }

	// RVA: 0x1FF2010 Offset: 0x1FF2111 VA: 0x1FF2010
	private void UpdateFocusStampUI() { }

	// RVA: 0x1FF3400 Offset: 0x1FF3501 VA: 0x1FF3400
	public Sprite GetStampSprite(int _index) { }

	// RVA: 0x1FF1DA0 Offset: 0x1FF1EA1 VA: 0x1FF1DA0
	private void ResetStampUI() { }

	// RVA: 0x1FF1990 Offset: 0x1FF1A91 VA: 0x1FF1990
	private void CheckStampRecord() { }

	// RVA: 0x1FF3640 Offset: 0x1FF3741 VA: 0x1FF3640 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1FF36C0 Offset: 0x1FF37C1 VA: 0x1FF36C0 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1FF3B10 Offset: 0x1FF3C11 VA: 0x1FF3B10 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1FF3B20 Offset: 0x1FF3C21 VA: 0x1FF3B20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A80A0 Offset: 0x1A81A1 VA: 0x1A80A0
	// RVA: 0x1FF3B30 Offset: 0x1FF3C31 VA: 0x1FF3B30
	private void <OnEnable>b__8_0(AssetHandle<SpriteAtlas> handle) { }
}

