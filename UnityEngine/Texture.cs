[NativeHeaderAttribute] // RVA: 0xC5870 Offset: 0xC5971 VA: 0xC5870
[UsedByNativeCodeAttribute] // RVA: 0xC5870 Offset: 0xC5971 VA: 0xC5870
[NativeHeaderAttribute] // RVA: 0xC5870 Offset: 0xC5971 VA: 0xC5870
public class Texture : Object // TypeDefIndex: 2942
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Properties
	public int mipmapCount { get; }
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual TextureDimension dimension { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; set; }
	public FilterMode filterMode { set; }
	public int anisoLevel { set; }
	public Vector2 texelSize { get; }

	// Methods

	// RVA: 0x2A30D00 Offset: 0x2A30E01 VA: 0x2A30D00
	protected void .ctor() { }

	[NativeNameAttribute] // RVA: 0xD3180 Offset: 0xD3281 VA: 0xD3180
	// RVA: 0x2A30D70 Offset: 0x2A30E71 VA: 0x2A30D70
	public int get_mipmapCount() { }

	// RVA: 0x2A30DC0 Offset: 0x2A30EC1 VA: 0x2A30DC0
	private int GetDataWidth() { }

	// RVA: 0x2A30E10 Offset: 0x2A30F11 VA: 0x2A30E10
	private int GetDataHeight() { }

	// RVA: 0x2A30E60 Offset: 0x2A30F61 VA: 0x2A30E60
	private TextureDimension GetDimension() { }

	// RVA: 0x2A30EB0 Offset: 0x2A30FB1 VA: 0x2A30EB0 Slot: 4
	public virtual int get_width() { }

	// RVA: 0x2A30F00 Offset: 0x2A31001 VA: 0x2A30F00 Slot: 5
	public virtual void set_width(int value) { }

	// RVA: 0x2A30F60 Offset: 0x2A31061 VA: 0x2A30F60 Slot: 6
	public virtual int get_height() { }

	// RVA: 0x2A30FB0 Offset: 0x2A310B1 VA: 0x2A30FB0 Slot: 7
	public virtual void set_height(int value) { }

	// RVA: 0x2A31010 Offset: 0x2A31111 VA: 0x2A31010 Slot: 8
	public virtual TextureDimension get_dimension() { }

	// RVA: 0x2A31060 Offset: 0x2A31161 VA: 0x2A31060 Slot: 9
	public virtual void set_dimension(TextureDimension value) { }

	// RVA: 0x2A310C0 Offset: 0x2A311C1 VA: 0x2A310C0 Slot: 10
	public virtual bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0xD31C0 Offset: 0xD32C1 VA: 0xD31C0
	// RVA: 0x2A31110 Offset: 0x2A31211 VA: 0x2A31110
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x2A31160 Offset: 0x2A31261 VA: 0x2A31160
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x2A311B0 Offset: 0x2A312B1 VA: 0x2A311B0
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x2A31200 Offset: 0x2A31301 VA: 0x2A31200
	public void set_anisoLevel(int value) { }

	[NativeNameAttribute] // RVA: 0xD3200 Offset: 0xD3301 VA: 0xD3200
	// RVA: 0x2A31250 Offset: 0x2A31351 VA: 0x2A31250
	public Vector2 get_texelSize() { }

	// RVA: 0x2A31300 Offset: 0x2A31401 VA: 0x2A31300
	public IntPtr GetNativeTexturePtr() { }

	// RVA: 0x2A31350 Offset: 0x2A31451 VA: 0x2A31350
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x2A314C0 Offset: 0x2A315C1 VA: 0x2A314C0
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x2A31640 Offset: 0x2A31741 VA: 0x2A31640
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x2A316E0 Offset: 0x2A317E1 VA: 0x2A316E0
	private static void .cctor() { }

	// RVA: 0x2A312B0 Offset: 0x2A313B1 VA: 0x2A312B0
	private void get_texelSize_Injected(out Vector2 ret) { }
}

