[Serializable]
public class CraftGenreDataTable // TypeDefIndex: 6938
{
	// Fields
	[SerializeField] // RVA: 0x1619B0 Offset: 0x161AB1 VA: 0x1619B0
	public ItemID GenreItem; // 0x10
	[SerializeField] // RVA: 0x1619C0 Offset: 0x161AC1 VA: 0x1619C0
	public ItemID[] CategoryItems; // 0x18
	private static CraftGenreDataTableArray _CraftGenreDataTableArray; // 0x0

	// Methods

	// RVA: 0x1FCBA20 Offset: 0x1FCBB21 VA: 0x1FCBA20
	public static bool IsGenreID(ItemID genreID) { }

	// RVA: 0x1FCBD40 Offset: 0x1FCBE41 VA: 0x1FCBD40
	public static ItemID[] GetItemDatasByCraftGenere(ItemID genreID) { }

	// RVA: 0x1FCBEF0 Offset: 0x1FCBFF1 VA: 0x1FCBEF0
	public static ItemID GetGenreId(ItemID itemID) { }

	// RVA: 0x1FCC090 Offset: 0x1FCC191 VA: 0x1FCC090
	public void .ctor() { }
}

