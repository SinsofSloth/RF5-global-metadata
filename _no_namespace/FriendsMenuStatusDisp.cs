public class FriendsMenuStatusDisp : MonoBehaviour // TypeDefIndex: 8673
{
	// Fields
	[SerializeField] // RVA: 0x172000 Offset: 0x172101 VA: 0x172000
	private Text Txt_Name; // 0x18
	[SerializeField] // RVA: 0x172010 Offset: 0x172111 VA: 0x172010
	private Text Txt_Discription; // 0x20
	[SerializeField] // RVA: 0x172020 Offset: 0x172121 VA: 0x172020
	private UIEquipSlot[] EquipSlot; // 0x28
	[SerializeField] // RVA: 0x172030 Offset: 0x172131 VA: 0x172030
	private Image LoveGauge; // 0x30
	private List<Image> LoveGauges; // 0x38
	[SerializeField] // RVA: 0x172040 Offset: 0x172141 VA: 0x172040
	private Sprite NoLoveSprite; // 0x40
	[SerializeField] // RVA: 0x172050 Offset: 0x172151 VA: 0x172050
	private Sprite LikeSprite; // 0x48
	[SerializeField] // RVA: 0x172060 Offset: 0x172161 VA: 0x172060
	private Sprite LoveSprite; // 0x50
	[SerializeField] // RVA: 0x172070 Offset: 0x172171 VA: 0x172070
	private CursorLinker charaModelCursor; // 0x58
	private readonly List<ActorID> CanbeLoverMaleList; // 0x60
	private readonly List<ActorID> CanbeLoverFemaleList; // 0x68

	// Properties
	public CursorLinker CharaModelCursor { get; }
	private UIModelLoader PlayerEquipModelLoader { get; }

	// Methods

	// RVA: 0x22AE7D0 Offset: 0x22AE8D1 VA: 0x22AE7D0
	public CursorLinker get_CharaModelCursor() { }

	// RVA: 0x22AE7E0 Offset: 0x22AE8E1 VA: 0x22AE7E0
	private void InitLoveGaguge() { }

	// RVA: 0x22AEA70 Offset: 0x22AEB71 VA: 0x22AEA70
	private void SetLoveGauge(int loveLv, bool isCanbeLover) { }

	// RVA: 0x22AEC80 Offset: 0x22AED81 VA: 0x22AEC80
	private UIModelLoader get_PlayerEquipModelLoader() { }

	// RVA: 0x22AECE0 Offset: 0x22AEDE1 VA: 0x22AECE0
	private void OnDisable() { }

	// RVA: 0x22AAC60 Offset: 0x22AAD61 VA: 0x22AAC60
	public void SetStatusNPC(ActorID actor_id) { }

	// RVA: 0x22AB1C0 Offset: 0x22AB2C1 VA: 0x22AB1C0
	public void SetStatusMonster(FriendMonsterStatus FriendMonsterStatusController) { }

	// RVA: 0x22AD210 Offset: 0x22AD311 VA: 0x22AD210
	public void SetStatusMonster(HandCuffsStatus FriendMonsterStatusController, MonsterDataTable monsterDataTable) { }

	// RVA: 0x22AED50 Offset: 0x22AEE51 VA: 0x22AED50
	public void .ctor() { }
}

