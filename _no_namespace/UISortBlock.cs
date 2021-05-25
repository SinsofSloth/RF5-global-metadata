public class UISortBlock : MonoBehaviour // TypeDefIndex: 8620
{
	// Fields
	[SerializeField] // RVA: 0x171290 Offset: 0x171391 VA: 0x171290
	private Image ArrowImage; // 0x18
	[SerializeField] // RVA: 0x1712A0 Offset: 0x1713A1 VA: 0x1712A0
	private Text SortText; // 0x20
	private readonly bool[] SortTypeUseArrowImageTable; // 0x28
	private readonly string[] SortTypeStringTable; // 0x30
	private readonly string[] ShippingSortTypeStringTable; // 0x38
	private readonly string[] FRIENDLY_SORT_TEXT; // 0x40
	private readonly string RECIPE_SORT_TEXT; // 0x48

	// Methods

	// RVA: 0x1FF0940 Offset: 0x1FF0A41 VA: 0x1FF0940
	public void SetSortType(SubSortType subSortType, bool isArrowUp = False) { }

	// RVA: 0x1FF0BC0 Offset: 0x1FF0CC1 VA: 0x1FF0BC0
	public void SetSortType(SORTTYPE subSortType, bool isArrowUp = False) { }

	// RVA: 0x1FF0E20 Offset: 0x1FF0F21 VA: 0x1FF0E20
	public void SetSortType(GenerateFriendlistButton.SortType subSortType, bool isArrowUp = False) { }

	// RVA: 0x1FF1080 Offset: 0x1FF1181 VA: 0x1FF1080
	public void SetSortType(bool isArrowUp = False) { }

	// RVA: 0x1FF12B0 Offset: 0x1FF13B1 VA: 0x1FF12B0
	public void .ctor() { }
}

