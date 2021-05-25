public abstract class SpriteAssetLoader : SingletonMonoBehaviour<SpriteAssetLoader> // TypeDefIndex: 8932
{
	// Fields
	[SerializeField] // RVA: 0x174C40 Offset: 0x174D41 VA: 0x174C40
	private Sprite LoadingSprite; // 0x18
	[SerializeField] // RVA: 0x174C50 Offset: 0x174D51 VA: 0x174C50
	private Sprite DefaultSprite; // 0x20
	[SerializeField] // RVA: 0x174C60 Offset: 0x174D61 VA: 0x174C60
	private string Path; // 0x28
	private Image Image; // 0x30
	private int SpriteNum; // 0x38
	private IEnumerator SpriteLoadCoroutine; // 0x40
	private bool loading; // 0x48
	private SpriteDataResource SpriteDataResource; // 0x50

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x1A9240 Offset: 0x1A9341 VA: 0x1A9240
	// RVA: 0x2249380 Offset: 0x2249481 VA: 0x2249380
	private IEnumerator LoadData(string path, UnityAction<SpriteDataResource> func) { }

	// RVA: 0x2249450 Offset: 0x2249551 VA: 0x2249450
	public void Load(int spriteNum, Image image) { }

	// RVA: 0x22496D0 Offset: 0x22497D1 VA: 0x22496D0
	private void ImageLoaded(SpriteDataResource spriteDataResource) { }

	// RVA: 0x2249980 Offset: 0x2249A81 VA: 0x2249980
	private void OnDestroy() { }

	// RVA: 0x22499C0 Offset: 0x2249AC1 VA: 0x22499C0
	protected void .ctor() { }
}

