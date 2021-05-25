public class UIShipmentItemList : UIScrollBoxBase // TypeDefIndex: 8819
{
	// Fields
	[SerializeField] // RVA: 0x173C10 Offset: 0x173D11 VA: 0x173C10
	private Text HeadText; // 0x68
	[SerializeField] // RVA: 0x173C20 Offset: 0x173D21 VA: 0x173C20
	private UISortBlock UISortBlock; // 0x70
	private ShippingCategory shippingCategory; // 0x78
	private SORTTYPE sortType; // 0x7C
	private bool sortRevert; // 0x80
	[SerializeField] // RVA: 0x173C30 Offset: 0x173D31 VA: 0x173C30
	private Sprite BronzeCrownSprite; // 0x88
	[SerializeField] // RVA: 0x173C40 Offset: 0x173D41 VA: 0x173C40
	private Sprite SilverCrownSprite; // 0x90
	[SerializeField] // RVA: 0x173C50 Offset: 0x173D51 VA: 0x173C50
	private Sprite GoldCrownSprite; // 0x98
	[SerializeField] // RVA: 0x173C60 Offset: 0x173D61 VA: 0x173C60
	private ItemTextDiscription ItemTextDiscription; // 0xA0
	private List<ShipmentItemRecords> ItemRecordList; // 0xA8
	private List<FishShipmentRecords> _FishRecordList; // 0xB0

	// Properties
	private List<FishShipmentRecords> FishRecordList { get; }

	// Methods

	// RVA: 0x1DDB050 Offset: 0x1DDB151 VA: 0x1DDB050
	private List<FishShipmentRecords> get_FishRecordList() { }

	// RVA: 0x1DDB160 Offset: 0x1DDB261 VA: 0x1DDB160
	private void SetSort() { }

	// RVA: 0x1DDB590 Offset: 0x1DDB691 VA: 0x1DDB590
	private Sprite GetCrownImage(CROWNTYPE type) { }

	// RVA: 0x1DDB5E0 Offset: 0x1DDB6E1 VA: 0x1DDB5E0
	public bool OpenCategory(ShippingCategory _shippingCategory, SORTTYPE _sortType) { }

	// RVA: 0x1DDB7A0 Offset: 0x1DDB8A1 VA: 0x1DDB7A0
	public void ChangeSort(SORTTYPE _sortType, bool _sortRevert) { }

	// RVA: 0x1DDB7E0 Offset: 0x1DDB8E1 VA: 0x1DDB7E0 Slot: 9
	protected override void Update() { }

	// RVA: 0x1DDB7F0 Offset: 0x1DDB8F1 VA: 0x1DDB7F0 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1DDB870 Offset: 0x1DDB971 VA: 0x1DDB870 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1DDBB70 Offset: 0x1DDBC71 VA: 0x1DDBB70 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1DDBC00 Offset: 0x1DDBD01 VA: 0x1DDBC00
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8850 Offset: 0x1A8951 VA: 0x1A8850
	// RVA: 0x1DDBC20 Offset: 0x1DDBD21 VA: 0x1DDBC20
	private bool <get_FishRecordList>b__12_0(FishShipmentRecords a) { }
}

