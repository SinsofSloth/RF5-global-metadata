public class XWeaponTrail : MonoBehaviour // TypeDefIndex: 9107
{
	// Fields
	public static string Version; // 0x0
	public bool UseWith2D; // 0x18
	public string SortingLayerName; // 0x20
	public int SortingOrder; // 0x28
	public Transform PointStart; // 0x30
	public Transform PointEnd; // 0x38
	public int MaxFrame; // 0x40
	public int Granularity; // 0x44
	public float Fps; // 0x48
	public Color MyColor; // 0x4C
	public Material MyMaterial; // 0x60
	protected float mTrailWidth; // 0x68
	protected XWeaponTrail.Element mHeadElem; // 0x70
	protected List<XWeaponTrail.Element> mSnapshotList; // 0x78
	protected XWeaponTrail.ElementPool mElemPool; // 0x80
	protected Spline mSpline; // 0x88
	protected float mFadeT; // 0x90
	protected bool mIsFading; // 0x94
	protected float mFadeTime; // 0x98
	protected float mElapsedTime; // 0x9C
	protected float mFadeElapsedime; // 0xA0
	protected GameObject mMeshObj; // 0xA8
	protected VertexPool mVertexPool; // 0xB0
	protected VertexPool.VertexSegment mVertexSegment; // 0xB8
	protected bool mInited; // 0xC0
	protected bool mActivated; // 0xC1

	// Properties
	public float UpdateInterval { get; }
	public Vector3 CurHeadPos { get; }
	public float TrailWidth { get; }

	// Methods

	// RVA: 0x1D10B00 Offset: 0x1D10C01 VA: 0x1D10B00
	public float get_UpdateInterval() { }

	// RVA: 0x1D10B10 Offset: 0x1D10C11 VA: 0x1D10B10
	public Vector3 get_CurHeadPos() { }

	// RVA: 0x1D10BF0 Offset: 0x1D10CF1 VA: 0x1D10BF0
	public float get_TrailWidth() { }

	// RVA: 0x1D0DB50 Offset: 0x1D0DC51 VA: 0x1D0DB50
	public void Init() { }

	// RVA: 0x1D0E200 Offset: 0x1D0E301 VA: 0x1D0E200
	public void Activate() { }

	// RVA: 0x1D0E1B0 Offset: 0x1D0E2B1 VA: 0x1D0E1B0
	public void Deactivate() { }

	// RVA: 0x1D0E4D0 Offset: 0x1D0E5D1 VA: 0x1D0E4D0
	public void StopSmoothly(float fadeTime) { }

	// RVA: 0x1D117A0 Offset: 0x1D118A1 VA: 0x1D117A0
	private void OnEnable() { }

	// RVA: 0x1D117B0 Offset: 0x1D118B1 VA: 0x1D117B0
	private void OnDisable() { }

	// RVA: 0x1D11800 Offset: 0x1D11901 VA: 0x1D11800
	private void Update() { }

	// RVA: 0x1D11B80 Offset: 0x1D11C81 VA: 0x1D11B80
	private void LateUpdate() { }

	// RVA: 0x1D11BB0 Offset: 0x1D11CB1 VA: 0x1D11BB0
	private void OnDestroy() { }

	// RVA: 0x1D11BD0 Offset: 0x1D11CD1 VA: 0x1D11BD0
	private void Start() { }

	// RVA: 0x1D11BE0 Offset: 0x1D11CE1 VA: 0x1D11BE0
	private void OnDrawGizmos() { }

	// RVA: 0x1D10F30 Offset: 0x1D11031 VA: 0x1D10F30
	private void InitSpline() { }

	// RVA: 0x1D11180 Offset: 0x1D11281 VA: 0x1D11180
	private void RefreshSpline() { }

	// RVA: 0x1D113A0 Offset: 0x1D114A1 VA: 0x1D113A0
	private void UpdateVertex() { }

	// RVA: 0x1D11E00 Offset: 0x1D11F01 VA: 0x1D11E00
	private void UpdateIndices() { }

	// RVA: 0x1D11880 Offset: 0x1D11981 VA: 0x1D11880
	private void UpdateHeadElem() { }

	// RVA: 0x1D11AE0 Offset: 0x1D11BE1 VA: 0x1D11AE0
	private void UpdateFade() { }

	// RVA: 0x1D11940 Offset: 0x1D11A41 VA: 0x1D11940
	private void RecordCurElem() { }

	// RVA: 0x1D10DC0 Offset: 0x1D10EC1 VA: 0x1D10DC0
	private void InitOriginalElements() { }

	// RVA: 0x1D10D00 Offset: 0x1D10E01 VA: 0x1D10D00
	private void InitMeshObj() { }

	// RVA: 0x1D12200 Offset: 0x1D12301 VA: 0x1D12200
	public void .ctor() { }

	// RVA: 0x1D12310 Offset: 0x1D12411 VA: 0x1D12310
	private static void .cctor() { }
}

