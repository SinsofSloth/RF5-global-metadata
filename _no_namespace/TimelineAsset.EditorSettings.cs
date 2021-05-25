[Serializable]
public class TimelineAsset.EditorSettings // TypeDefIndex: 4556
{
	// Fields
	internal static readonly float kMinFps; // 0x0
	internal static readonly float kMaxFps; // 0x4
	internal static readonly float kDefaultFps; // 0x8
	[HideInInspector] // RVA: 0x12BDC0 Offset: 0x12BEC1 VA: 0x12BDC0
	[SerializeField] // RVA: 0x12BDC0 Offset: 0x12BEC1 VA: 0x12BDC0
	private float m_Framerate; // 0x10
	[HideInInspector] // RVA: 0x12BE00 Offset: 0x12BF01 VA: 0x12BE00
	[SerializeField] // RVA: 0x12BE00 Offset: 0x12BF01 VA: 0x12BE00
	private bool m_ScenePreview; // 0x14

	// Properties
	public float fps { get; set; }
	public bool scenePreview { get; set; }

	// Methods

	// RVA: 0x1B383A0 Offset: 0x1B384A1 VA: 0x1B383A0
	public float get_fps() { }

	// RVA: 0x1B383B0 Offset: 0x1B384B1 VA: 0x1B383B0
	public void set_fps(float value) { }

	// RVA: 0x1B383E0 Offset: 0x1B384E1 VA: 0x1B383E0
	public bool get_scenePreview() { }

	// RVA: 0x1B383F0 Offset: 0x1B384F1 VA: 0x1B383F0
	public void set_scenePreview(bool value) { }

	// RVA: 0x1B38400 Offset: 0x1B38501 VA: 0x1B38400
	public void .ctor() { }

	// RVA: 0x1B38480 Offset: 0x1B38581 VA: 0x1B38480
	private static void .cctor() { }
}

