public class BloomHelper : Singleton<BloomHelper>, IDisposable // TypeDefIndex: 11722
{
	// Fields
	private static Material _mat; // 0x0
	private BloomHelperParams p; // 0x10
	private int bloomSamples; // 0x18
	private float bloomBlurRadius; // 0x1C

	// Properties
	public static Material Mat { get; }

	// Methods

	// RVA: 0x22A0AA0 Offset: 0x22A0BA1 VA: 0x22A0AA0
	public static Material get_Mat() { }

	// RVA: 0x22A0BA0 Offset: 0x22A0CA1 VA: 0x22A0BA0
	public void SetParams(BloomHelperParams _p) { }

	// RVA: 0x229C6B0 Offset: 0x229C7B1 VA: 0x229C6B0
	public void Init() { }

	// RVA: 0x229F980 Offset: 0x229FA81 VA: 0x229F980
	public void RenderBloomTexture(RenderTexture source, RenderTexture dest) { }

	// RVA: 0x22A0CC0 Offset: 0x22A0DC1 VA: 0x22A0CC0
	public RenderTexture BlurTex(RenderTexture _input, float _spread) { }

	// RVA: 0x22A0BB0 Offset: 0x22A0CB1 VA: 0x22A0BB0
	private float[] CalculateBloomTexFactors(float softness) { }

	// RVA: 0x22A1050 Offset: 0x22A1151 VA: 0x22A1050
	private float[] MakeSumOne(IList<float> _in) { }

	// RVA: 0x229D080 Offset: 0x229D181 VA: 0x229D080 Slot: 4
	public void Dispose() { }

	// RVA: 0x22A1340 Offset: 0x22A1441 VA: 0x22A1340
	public void .ctor() { }
}

