[RequireComponent] // RVA: 0x143B00 Offset: 0x143C01 VA: 0x143B00
[AddComponentMenu] // RVA: 0x143B00 Offset: 0x143C01 VA: 0x143B00
internal class TiltShift : PostEffectsBase // TypeDefIndex: 6049
{
	// Fields
	public TiltShift.TiltShiftMode mode; // 0x28
	public TiltShift.TiltShiftQuality quality; // 0x2C
	[RangeAttribute] // RVA: 0x144410 Offset: 0x144511 VA: 0x144410
	public float blurArea; // 0x30
	[RangeAttribute] // RVA: 0x144430 Offset: 0x144531 VA: 0x144430
	public float maxBlurSize; // 0x34
	[RangeAttribute] // RVA: 0x144450 Offset: 0x144551 VA: 0x144450
	public int downsample; // 0x38
	public Shader tiltShiftShader; // 0x40
	private Material tiltShiftMaterial; // 0x48

	// Methods

	// RVA: 0x1B71290 Offset: 0x1B71391 VA: 0x1B71290 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1B71310 Offset: 0x1B71411 VA: 0x1B71310
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B715A0 Offset: 0x1B716A1 VA: 0x1B715A0
	public void .ctor() { }
}

