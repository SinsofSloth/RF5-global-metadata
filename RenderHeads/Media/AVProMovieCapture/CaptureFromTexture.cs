[AddComponentMenu] // RVA: 0x148F70 Offset: 0x149071 VA: 0x148F70
public class CaptureFromTexture : CaptureBase // TypeDefIndex: 9597
{
	// Fields
	[TooltipAttribute] // RVA: 0x17D290 Offset: 0x17D391 VA: 0x17D290
	[SerializeField] // RVA: 0x17D290 Offset: 0x17D391 VA: 0x17D290
	private bool _manualUpdate; // 0x1B0
	private Texture _sourceTexture; // 0x1B8
	private RenderTexture _renderTexture; // 0x1C0
	private IntPtr _targetNativePointer; // 0x1C8
	public bool _isSourceTextureChanged; // 0x1D0

	// Methods

	// RVA: 0x231D720 Offset: 0x231D821 VA: 0x231D720
	public void SetSourceTexture(Texture texture) { }

	// RVA: 0x231D990 Offset: 0x231DA91 VA: 0x231D990
	public void UpdateSourceTexture() { }

	// RVA: 0x231D9A0 Offset: 0x231DAA1 VA: 0x231D9A0
	private bool ShouldCaptureFrame() { }

	// RVA: 0x231DA30 Offset: 0x231DB31 VA: 0x231DA30
	private bool HasSourceTextureChanged() { }

	// RVA: 0x231DA50 Offset: 0x231DB51 VA: 0x231DA50 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC4D0 Offset: 0x1AC5D1 VA: 0x1AC4D0
	// RVA: 0x231DB00 Offset: 0x231DC01 VA: 0x231DB00
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x231DB80 Offset: 0x231DC81 VA: 0x231DB80
	private void Capture() { }

	// RVA: 0x231DF20 Offset: 0x231E021 VA: 0x231DF20
	private void AccumulateMotionBlur() { }

	// RVA: 0x231E030 Offset: 0x231E131 VA: 0x231E030 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231E0E0 Offset: 0x231E1E1 VA: 0x231E0E0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231E310 Offset: 0x231E411 VA: 0x231E310 Slot: 10
	public override void UnprepareCapture() { }

	// RVA: 0x231E430 Offset: 0x231E531 VA: 0x231E430
	public void .ctor() { }
}

