public class OrderPopControl : MonoBehaviour // TypeDefIndex: 8593
{
	// Fields
	[SerializeField] // RVA: 0x170FA0 Offset: 0x1710A1 VA: 0x170FA0
	private OrderHUDBlock OrderHUDBlockPrefab; // 0x18
	[SerializeField] // RVA: 0x170FB0 Offset: 0x1710B1 VA: 0x170FB0
	private GameObject PopupParent; // 0x20
	private List<OrderHUDBlock> OrderHUDBlockList; // 0x28
	[SerializeField] // RVA: 0x170FC0 Offset: 0x1710C1 VA: 0x170FC0
	private Sprite[] OrderIconSprites; // 0x30
	private bool hasStock; // 0x38
	private bool parentActiving; // 0x39
	private List<OrderPopControl.StockDoOrder> stockDoOrders; // 0x40

	// Methods

	// RVA: 0x1F21260 Offset: 0x1F21361 VA: 0x1F21260
	public void AddStock(OrderPopControl.StockType _type, OrderHUDBlock _orderHUDBlock, OrderData _data) { }

	// RVA: 0x1F2B820 Offset: 0x1F2B921 VA: 0x1F2B820
	private void ReleaseStock() { }

	// RVA: 0x1F2BC00 Offset: 0x1F2BD01 VA: 0x1F2BC00
	private void LateUpdate() { }

	// RVA: 0x1F2BDB0 Offset: 0x1F2BEB1 VA: 0x1F2BDB0
	private void Awake() { }

	// RVA: 0x1F2BE50 Offset: 0x1F2BF51 VA: 0x1F2BE50
	public OrderHUDBlock AddOrderBlock(OrderData data) { }

	// RVA: 0x1F213A0 Offset: 0x1F214A1 VA: 0x1F213A0
	public void RemoveBlock(OrderHUDBlock orderHUD) { }

	// RVA: 0x1F21720 Offset: 0x1F21821 VA: 0x1F21720
	public int GetNoneUseBlockId() { }

	// RVA: 0x1F2C080 Offset: 0x1F2C181 VA: 0x1F2C080
	public void .ctor() { }
}

