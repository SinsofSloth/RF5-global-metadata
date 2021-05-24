public class LightningController : MonoBehaviour, ISkyModule // TypeDefIndex: 9694
{
	// Fields
	private SkyProfile m_SkyProfile; // 0x18
	private float m_TimeOfDay; // 0x20
	private List<LightningRenderer> m_LightningRenderers; // 0x28

	// Methods

	// RVA: 0x22B27E0 Offset: 0x22B28E1 VA: 0x22B27E0
	private void Start() { }

	// RVA: 0x22B2980 Offset: 0x22B2A81 VA: 0x22B2980 Slot: 4
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0x22B29C0 Offset: 0x22B2AC1 VA: 0x22B29C0
	public void Update() { }

	// RVA: 0x22B2880 Offset: 0x22B2981 VA: 0x22B2880
	public void ClearLightningRenderers() { }

	// RVA: 0x22B2D80 Offset: 0x22B2E81 VA: 0x22B2D80
	public void CreateLightningRenderers() { }

	// RVA: 0x22B3010 Offset: 0x22B3111 VA: 0x22B3010
	public void .ctor() { }
}

