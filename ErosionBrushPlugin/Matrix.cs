[Serializable]
public class Matrix : Matrix2<float> // TypeDefIndex: 9719
{
	// Methods

	// RVA: 0x1C10600 Offset: 0x1C10701 VA: 0x1C10600
	public float GetInterpolatedValue(Vector2 pos) { }

	// RVA: 0x1C10760 Offset: 0x1C10861 VA: 0x1C10760
	public float GetAveragedValue(int x, int z, int steps) { }

	// RVA: 0x1C10870 Offset: 0x1C10971 VA: 0x1C10870
	public void .ctor() { }

	// RVA: 0x1C10920 Offset: 0x1C10A21 VA: 0x1C10920
	public void .ctor(CoordRect rect, float[] array) { }

	// RVA: 0x1C10BA0 Offset: 0x1C10CA1 VA: 0x1C10BA0
	public void .ctor(Coord offset, Coord size, float[] array) { }

	// RVA: 0x1C10E40 Offset: 0x1C10F41 VA: 0x1C10E40 Slot: 5
	public override object Clone() { }

	// RVA: 0x1C10E50 Offset: 0x1C10F51 VA: 0x1C10E50
	public Matrix Copy(Matrix result) { }

	// RVA: 0x1C10FF0 Offset: 0x1C110F1 VA: 0x1C10FF0
	public bool[] InRect(CoordRect area) { }

	// RVA: 0x1C11120 Offset: 0x1C11221 VA: 0x1C11120
	public void Fill(float[,] array, CoordRect arrayRect) { }

	// RVA: 0x1C11280 Offset: 0x1C11381 VA: 0x1C11280
	public void Pour(float[,] array, CoordRect arrayRect) { }

	// RVA: 0x1C11400 Offset: 0x1C11501 VA: 0x1C11400
	public void Pour(float[,,] array, int channel, CoordRect arrayRect) { }

	// RVA: 0x1C115A0 Offset: 0x1C116A1 VA: 0x1C115A0
	public float[,] ReadHeighmap(TerrainData data, float height = 1) { }

	// RVA: 0x1C11780 Offset: 0x1C11881 VA: 0x1C11780
	public void WriteHeightmap(TerrainData data, float[,] array, float brushFallof = 0.5, bool delayLod = False) { }

	// RVA: 0x1C11BE0 Offset: 0x1C11CE1 VA: 0x1C11BE0
	public float[,,] ReadSplatmap(TerrainData data, int channel, float[,,] array) { }

	// RVA: 0x1C11DE0 Offset: 0x1C11EE1 VA: 0x1C11DE0
	public static void AddSplatmaps(TerrainData data, Matrix[] matrices, int[] channels, float[] opacity, float[,,] array, float brushFallof = 0.5) { }

	// RVA: 0x1C125F0 Offset: 0x1C126F1 VA: 0x1C125F0
	public void ToTexture(Texture2D texture, Color[] colors, float rangeMin = 0, float rangeMax = 1, bool resizeTexture = False) { }

	// RVA: 0x1C12980 Offset: 0x1C12A81 VA: 0x1C12980
	public void FromTexture(Texture2D texture) { }

	// RVA: 0x1C12B40 Offset: 0x1C12C41 VA: 0x1C12B40
	public void FromTextureTiled(Texture2D texture) { }

	// RVA: 0x1C12CC0 Offset: 0x1C12DC1 VA: 0x1C12CC0
	public Texture2D SimpleToTexture(Texture2D texture, Color[] colors, float rangeMin = 0, float rangeMax = 1, string savePath) { }

	// RVA: 0x1C12F20 Offset: 0x1C13021 VA: 0x1C12F20
	public void SimpleFromTexture(Texture2D texture) { }

	// RVA: 0x1C13070 Offset: 0x1C13171 VA: 0x1C13070
	public void ImportRaw(string path) { }

	// RVA: 0x1C132E0 Offset: 0x1C133E1 VA: 0x1C132E0
	public void Replicate(Matrix source, bool tile = False) { }

	// RVA: 0x1C134A0 Offset: 0x1C135A1 VA: 0x1C134A0
	public float GetArea(int x, int z, int range) { }

	// RVA: 0x1C13610 Offset: 0x1C13711 VA: 0x1C13610
	public float GetInterpolated(float x, float z) { }

	// RVA: 0x1C13740 Offset: 0x1C13841 VA: 0x1C13740
	public Matrix Resize(CoordRect newRect, Matrix result) { }

	// RVA: 0x1C13910 Offset: 0x1C13A11 VA: 0x1C13910
	public Matrix Downscale(int factor, Matrix result) { }

	// RVA: 0x1C13960 Offset: 0x1C13A61 VA: 0x1C13960
	public Matrix Upscale(int factor, Matrix result) { }

	// RVA: 0x1C139B0 Offset: 0x1C13AB1 VA: 0x1C139B0
	public Matrix BlurredUpscale(int factor) { }

	// RVA: 0x1C14100 Offset: 0x1C14201 VA: 0x1C14100
	public Matrix OutdatedResize(CoordRect newRect, float smoothness = 1, Matrix result) { }

	// RVA: 0x1C146A0 Offset: 0x1C147A1 VA: 0x1C146A0
	public Matrix OutdatedUpscale(int factor, Matrix result) { }

	// RVA: 0x1C15050 Offset: 0x1C15151 VA: 0x1C15050
	public float OutdatedGetInterpolated(float x, float z) { }

	// RVA: 0x1C15170 Offset: 0x1C15271 VA: 0x1C15170
	public Matrix TestResize(CoordRect newRect) { }

	// RVA: 0x1C14A60 Offset: 0x1C14B61 VA: 0x1C14A60
	public Matrix OutdatedDownscale(int factor = 2, float smoothness = 1, Matrix result) { }

	// RVA: 0x1C15320 Offset: 0x1C15421 VA: 0x1C15320
	public void Spread(float strength = 0.5, int iterations = 4, Matrix copy) { }

	// RVA: 0x1C159F0 Offset: 0x1C15AF1 VA: 0x1C159F0
	public void Spread(Func<float, float, float> spreadFn, int iterations = 4) { }

	// RVA: 0x1C13BE0 Offset: 0x1C13CE1 VA: 0x1C13BE0
	public void Blur(Func<float, float, float, float> blurFn, float intensity = 0.666, bool additive = False, bool takemax = False, bool horizontal = True, bool vertical = True, Matrix reference) { }

	// RVA: 0x1C15E30 Offset: 0x1C15F31 VA: 0x1C15E30
	public void LossBlur(int step = 2, bool horizontal = True, bool vertical = True, Matrix reference) { }

	// RVA: 0x1C16330 Offset: 0x1C16431 VA: 0x1C16330
	public static void BlendLayers(Matrix[] matrices, float[] opacity) { }

	// RVA: 0x1C164F0 Offset: 0x1C165F1 VA: 0x1C164F0
	public static void NormalizeLayers(Matrix[] matrices, float[] opacity) { }

	// RVA: 0x1C11AA0 Offset: 0x1C11BA1 VA: 0x1C11AA0
	public float Fallof(int x, int z, float fallof) { }

	// RVA: 0x1C16690 Offset: 0x1C16791 VA: 0x1C16690
	public void FillEmpty() { }

	// RVA: 0x1C16910 Offset: 0x1C16A11 VA: 0x1C16910
	public static void Blend(Matrix src, Matrix dst, float factor) { }

	// RVA: 0x1C16A40 Offset: 0x1C16B41 VA: 0x1C16A40
	public static void Mask(Matrix src, Matrix dst, Matrix mask) { }

	// RVA: 0x1C16C80 Offset: 0x1C16D81 VA: 0x1C16C80
	public static void SafeBorders(Matrix src, Matrix dst, int safeBorders) { }

	// RVA: 0x1C16F20 Offset: 0x1C17021 VA: 0x1C16F20
	public void Add(Matrix add) { }

	// RVA: 0x1C16FC0 Offset: 0x1C170C1 VA: 0x1C16FC0
	public void Add(Matrix add, Matrix mask) { }

	// RVA: 0x1C170A0 Offset: 0x1C171A1 VA: 0x1C170A0
	public void Add(float add) { }

	// RVA: 0x1C17110 Offset: 0x1C17211 VA: 0x1C17110
	public void Subtract(Matrix m) { }

	// RVA: 0x1C171B0 Offset: 0x1C172B1 VA: 0x1C171B0
	public void InvSubtract(Matrix m) { }

	// RVA: 0x1C17240 Offset: 0x1C17341 VA: 0x1C17240
	public void ClampSubtract(Matrix m) { }

	// RVA: 0x1C17360 Offset: 0x1C17461 VA: 0x1C17360
	public void Multiply(Matrix m) { }

	// RVA: 0x1C17400 Offset: 0x1C17501 VA: 0x1C17400
	public void Multiply(float m) { }

	// RVA: 0x1C17470 Offset: 0x1C17571 VA: 0x1C17470
	public bool CheckRange(float min, float max) { }

	// RVA: 0x1C174F0 Offset: 0x1C175F1 VA: 0x1C174F0
	public void Invert() { }

	// RVA: 0x1C17560 Offset: 0x1C17661 VA: 0x1C17560
	public void InvertOne() { }

	// RVA: 0x1C175D0 Offset: 0x1C176D1 VA: 0x1C175D0
	public void Clamp01() { }
}

