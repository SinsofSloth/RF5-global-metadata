public class Matrix.Stacker // TypeDefIndex: 9720
{
	// Fields
	public CoordRect smallRect; // 0x10
	public CoordRect bigRect; // 0x20
	public bool preserveDetail; // 0x30
	private Matrix downscaled; // 0x38
	private Matrix upscaled; // 0x40
	private Matrix difference; // 0x48
	private bool isDownscaled; // 0x50

	// Properties
	public Matrix matrix { get; }

	// Methods

	// RVA: 0x1C17650 Offset: 0x1C17751 VA: 0x1C17650
	public void .ctor(CoordRect smallRect, CoordRect bigRect) { }

	// RVA: 0x1C17900 Offset: 0x1C17A01 VA: 0x1C17900
	public Matrix get_matrix() { }

	// RVA: 0x1C17920 Offset: 0x1C17A21 VA: 0x1C17920
	public void ToSmall() { }

	// RVA: 0x1C17A00 Offset: 0x1C17B01 VA: 0x1C17A00
	public void ToBig() { }
}

