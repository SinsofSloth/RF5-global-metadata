[RequireComponent] // RVA: 0xC7410 Offset: 0xC7511 VA: 0xC7410
[NativeTypeAttribute] // RVA: 0xC7410 Offset: 0xC7511 VA: 0xC7410
public sealed class SpriteRenderer : Renderer // TypeDefIndex: 3077
{
	// Properties
	internal bool shouldSupportTiling { get; }
	public Sprite sprite { get; set; }
	public SpriteDrawMode drawMode { get; set; }
	public Vector2 size { get; set; }
	public float adaptiveModeThreshold { get; set; }
	public SpriteTileMode tileMode { get; set; }
	public Color color { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public bool flipX { get; set; }
	public bool flipY { get; set; }
	public SpriteSortPoint spriteSortPoint { get; set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xD8AB0 Offset: 0xD8BB1 VA: 0xD8AB0
	// RVA: 0x2A2DE40 Offset: 0x2A2DF41 VA: 0x2A2DE40
	internal bool get_shouldSupportTiling() { }

	// RVA: 0x2A2DE90 Offset: 0x2A2DF91 VA: 0x2A2DE90
	public Sprite get_sprite() { }

	// RVA: 0x2A2DEE0 Offset: 0x2A2DFE1 VA: 0x2A2DEE0
	public void set_sprite(Sprite value) { }

	// RVA: 0x2A2DF30 Offset: 0x2A2E031 VA: 0x2A2DF30
	public SpriteDrawMode get_drawMode() { }

	// RVA: 0x2A2DF80 Offset: 0x2A2E081 VA: 0x2A2DF80
	public void set_drawMode(SpriteDrawMode value) { }

	// RVA: 0x2A2DFD0 Offset: 0x2A2E0D1 VA: 0x2A2DFD0
	public Vector2 get_size() { }

	// RVA: 0x2A2E080 Offset: 0x2A2E181 VA: 0x2A2E080
	public void set_size(Vector2 value) { }

	// RVA: 0x2A2E130 Offset: 0x2A2E231 VA: 0x2A2E130
	public float get_adaptiveModeThreshold() { }

	// RVA: 0x2A2E180 Offset: 0x2A2E281 VA: 0x2A2E180
	public void set_adaptiveModeThreshold(float value) { }

	// RVA: 0x2A2E1D0 Offset: 0x2A2E2D1 VA: 0x2A2E1D0
	public SpriteTileMode get_tileMode() { }

	// RVA: 0x2A2E220 Offset: 0x2A2E321 VA: 0x2A2E220
	public void set_tileMode(SpriteTileMode value) { }

	// RVA: 0x2A2E270 Offset: 0x2A2E371 VA: 0x2A2E270
	public Color get_color() { }

	// RVA: 0x2A2E320 Offset: 0x2A2E421 VA: 0x2A2E320
	public void set_color(Color value) { }

	// RVA: 0x2A2E3D0 Offset: 0x2A2E4D1 VA: 0x2A2E3D0
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x2A2E420 Offset: 0x2A2E521 VA: 0x2A2E420
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x2A2E470 Offset: 0x2A2E571 VA: 0x2A2E470
	public bool get_flipX() { }

	// RVA: 0x2A2E4C0 Offset: 0x2A2E5C1 VA: 0x2A2E4C0
	public void set_flipX(bool value) { }

	// RVA: 0x2A2E510 Offset: 0x2A2E611 VA: 0x2A2E510
	public bool get_flipY() { }

	// RVA: 0x2A2E560 Offset: 0x2A2E661 VA: 0x2A2E560
	public void set_flipY(bool value) { }

	// RVA: 0x2A2E5B0 Offset: 0x2A2E6B1 VA: 0x2A2E5B0
	public SpriteSortPoint get_spriteSortPoint() { }

	// RVA: 0x2A2E600 Offset: 0x2A2E701 VA: 0x2A2E600
	public void set_spriteSortPoint(SpriteSortPoint value) { }

	[NativeMethodAttribute] // RVA: 0xD8AF0 Offset: 0xD8BF1 VA: 0xD8AF0
	// RVA: 0x2A2E650 Offset: 0x2A2E751 VA: 0x2A2E650
	internal Bounds Internal_GetSpriteBounds(SpriteDrawMode mode) { }

	// RVA: 0x2A2E730 Offset: 0x2A2E831 VA: 0x2A2E730
	internal Bounds GetSpriteBounds() { }

	// RVA: 0x2A2E7F0 Offset: 0x2A2E8F1 VA: 0x2A2E7F0
	public void .ctor() { }

	// RVA: 0x2A2E030 Offset: 0x2A2E131 VA: 0x2A2E030
	private void get_size_Injected(out Vector2 ret) { }

	// RVA: 0x2A2E0E0 Offset: 0x2A2E1E1 VA: 0x2A2E0E0
	private void set_size_Injected(ref Vector2 value) { }

	// RVA: 0x2A2E2D0 Offset: 0x2A2E3D1 VA: 0x2A2E2D0
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x2A2E380 Offset: 0x2A2E481 VA: 0x2A2E380
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x2A2E6D0 Offset: 0x2A2E7D1 VA: 0x2A2E6D0
	private void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret) { }
}

