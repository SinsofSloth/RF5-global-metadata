public class AdvShowOneImage : MonoBehaviour // TypeDefIndex: 8417
{
	// Fields
	private Image image; // 0x18
	private const float defaultFadeTime = 0.15;
	private float fadeTime; // 0x20
	private float nowTime; // 0x24
	private bool isOpening; // 0x28
	private bool isEnding; // 0x29
	private float startEndAlpha; // 0x2C
	private float X; // 0x30
	private float Y; // 0x34
	private AdvShowOneImage parent; // 0x38
	private List<AdvShowOneImage.AdvSpriteLoader> AdvSpriteLoaders; // 0x40
	private AdvShowOneImage.AdvSpriteLoader myLoader; // 0x48

	// Methods

	// RVA: 0x2276EA0 Offset: 0x2276FA1 VA: 0x2276EA0
	public void RemoveLoader(AdvShowOneImage.AdvSpriteLoader AdvSpriteLoader) { }

	// RVA: 0x2276F10 Offset: 0x2277011 VA: 0x2276F10
	public void SetInit(AdvShowOneImage AdvShowOneImage, AdvShowOneImage.AdvSpriteLoader _loader, float x, float y, int _time) { }

	// RVA: 0x22770B0 Offset: 0x22771B1 VA: 0x22770B0
	private int GetImageLoaderId(int id) { }

	// RVA: 0x2277230 Offset: 0x2277331 VA: 0x2277230
	public AdvShowOneImage OpenImage(int _imageId, int x, int y, int _time) { }

	// RVA: 0x2277600 Offset: 0x2277701 VA: 0x2277600
	public void EndImage(int _imageId, int _time) { }

	// RVA: 0x22778D0 Offset: 0x22779D1 VA: 0x22778D0
	public void EndAllImage(int _time) { }

	// RVA: 0x22779F0 Offset: 0x2277AF1 VA: 0x22779F0
	public void DoOpenImage(Sprite sprite) { }

	// RVA: 0x2277B60 Offset: 0x2277C61 VA: 0x2277B60
	public void DoEndImage(int _time) { }

	// RVA: 0x2277080 Offset: 0x2277181 VA: 0x2277080
	private void SetFadeTime(int _time) { }

	// RVA: 0x2277BD0 Offset: 0x2277CD1 VA: 0x2277BD0
	private void Update() { }

	// RVA: 0x2277EB0 Offset: 0x2277FB1 VA: 0x2277EB0
	public void .ctor() { }
}

