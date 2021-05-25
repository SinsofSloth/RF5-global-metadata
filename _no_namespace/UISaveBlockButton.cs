public class UISaveBlockButton : UIButtonLinkerInScrollBox // TypeDefIndex: 8722
{
	// Fields
	private UISaveMenuManager UISaveMenuManager; // 0x70
	[SerializeField] // RVA: 0x172C90 Offset: 0x172D91 VA: 0x172C90
	private Image OffImage; // 0x78
	[SerializeField] // RVA: 0x172CA0 Offset: 0x172DA1 VA: 0x172CA0
	private Image OnImage; // 0x80
	[SerializeField] // RVA: 0x172CB0 Offset: 0x172DB1 VA: 0x172CB0
	private Image CharactorImage; // 0x88
	[SerializeField] // RVA: 0x172CC0 Offset: 0x172DC1 VA: 0x172CC0
	private Image MarryCharactorImage; // 0x90
	[SerializeField] // RVA: 0x172CD0 Offset: 0x172DD1 VA: 0x172CD0
	private Image OnlyPlayerCharactorImage; // 0x98
	[SerializeField] // RVA: 0x172CE0 Offset: 0x172DE1 VA: 0x172CE0
	private Text SaveBlockIdText; // 0xA0
	[SerializeField] // RVA: 0x172CF0 Offset: 0x172DF1 VA: 0x172CF0
	private Text CharactorText; // 0xA8
	[SerializeField] // RVA: 0x172D00 Offset: 0x172E01 VA: 0x172D00
	private Text LvText; // 0xB0
	[SerializeField] // RVA: 0x172D10 Offset: 0x172E11 VA: 0x172D10
	private Text DiffText; // 0xB8
	[SerializeField] // RVA: 0x172D20 Offset: 0x172E21 VA: 0x172D20
	private Text PlaceText; // 0xC0
	[SerializeField] // RVA: 0x172D30 Offset: 0x172E31 VA: 0x172D30
	private Text TimeText; // 0xC8
	[SerializeField] // RVA: 0x172D40 Offset: 0x172E41 VA: 0x172D40
	private Text NextMissionText; // 0xD0
	[SerializeField] // RVA: 0x172D50 Offset: 0x172E51 VA: 0x172D50
	private SText NoSaveDataText; // 0xD8
	[SerializeField] // RVA: 0x172D60 Offset: 0x172E61 VA: 0x172D60
	private Sprite MaleCharaSprite; // 0xE0
	[SerializeField] // RVA: 0x172D70 Offset: 0x172E71 VA: 0x172D70
	private Sprite FemaleCharaSprite; // 0xE8
	[SerializeField] // RVA: 0x172D80 Offset: 0x172E81 VA: 0x172D80
	private Sprite[] NPCMaleCharaSprite; // 0xF0
	[SerializeField] // RVA: 0x172D90 Offset: 0x172E91 VA: 0x172D90
	private Sprite[] NPCFemaleCharaSprite; // 0xF8
	private NPCID marriedNPCID; // 0x100
	private bool isPlayerMale; // 0x104
	private bool isSaved; // 0x105
	private readonly string[] SeasonStr; // 0x108

	// Methods

	// RVA: 0x1DD39D0 Offset: 0x1DD3AD1 VA: 0x1DD39D0 Slot: 16
	public override void Init() { }

	// RVA: 0x1DD3A60 Offset: 0x1DD3B61 VA: 0x1DD3A60
	public void SetSaveData(RF5ThumbnailData thumbSaveData, int saveNo, NextTargetDataTable nextTargetDataTable) { }

	// RVA: 0x1DD47B0 Offset: 0x1DD48B1 VA: 0x1DD47B0
	public void SetState(bool state) { }

	// RVA: 0x1DD4FE0 Offset: 0x1DD50E1 VA: 0x1DD4FE0 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1DD5010 Offset: 0x1DD5111 VA: 0x1DD5010 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1DD5040 Offset: 0x1DD5141 VA: 0x1DD5040
	private void OnEnable() { }

	// RVA: 0x1DD5070 Offset: 0x1DD5171 VA: 0x1DD5070 Slot: 12
	protected override bool CanUpdateCursor() { }

	// RVA: 0x1DD50B0 Offset: 0x1DD51B1 VA: 0x1DD50B0 Slot: 13
	protected override void InitInputLayer() { }

	// RVA: 0x1DD50E0 Offset: 0x1DD51E1 VA: 0x1DD50E0 Slot: 14
	protected override void ClearInputLayer() { }

	// RVA: 0x1DD5110 Offset: 0x1DD5211 VA: 0x1DD5110
	public void .ctor() { }
}

