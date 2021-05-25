public class MonsterTameRateController // TypeDefIndex: 8038
{
	// Fields
	private readonly MonsterControllerBase Owner; // 0x10
	private int BrushCount; // 0x18
	private int PresentItemCount; // 0x1C
	private int FavoritePresentItemCount; // 0x20
	private int FavoritePresentItemRate; // 0x24
	private int TakeDamageLoveAttributeCount; // 0x28

	// Properties
	private int PresentCount { get; }

	// Methods

	// RVA: 0x1CD80E0 Offset: 0x1CD81E1 VA: 0x1CD80E0
	private int get_PresentCount() { }

	// RVA: 0x1CD80F0 Offset: 0x1CD81F1 VA: 0x1CD80F0
	public float GetRate() { }

	// RVA: 0x1CD8220 Offset: 0x1CD8321 VA: 0x1CD8220
	public bool TryBrush() { }

	// RVA: 0x1CD8280 Offset: 0x1CD8381 VA: 0x1CD8280
	public bool TryPresentItem(ItemID itemID, out bool isFavorite) { }

	// RVA: 0x1CD8340 Offset: 0x1CD8441 VA: 0x1CD8340
	public bool IsFavorite(ItemID itemID, out int likePoint) { }

	// RVA: 0x1CD8370 Offset: 0x1CD8471 VA: 0x1CD8370
	public bool TryTakeDamageLoveAttribute() { }

	// RVA: 0x1CD83D0 Offset: 0x1CD84D1 VA: 0x1CD83D0
	public void .ctor(MonsterControllerBase owner) { }
}

