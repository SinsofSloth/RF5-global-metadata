[ExecuteInEditMode] // RVA: 0x143550 Offset: 0x143651 VA: 0x143550
[AddComponentMenu] // RVA: 0x143550 Offset: 0x143651 VA: 0x143550
[RequireComponent] // RVA: 0x143550 Offset: 0x143651 VA: 0x143550
public class MotionBlur : ImageEffectBase // TypeDefIndex: 6034
{
	// Fields
	[RangeAttribute] // RVA: 0x1441B0 Offset: 0x1442B1 VA: 0x1441B0
	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30

	// Methods

	// RVA: 0x1A5BBE0 Offset: 0x1A5BCE1 VA: 0x1A5BBE0 Slot: 4
	protected override void Start() { }

	// RVA: 0x1A5BBF0 Offset: 0x1A5BCF1 VA: 0x1A5BBF0 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x1A5BC70 Offset: 0x1A5BD71 VA: 0x1A5BC70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A5C000 Offset: 0x1A5C101 VA: 0x1A5C000
	public void .ctor() { }
}

