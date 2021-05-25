public class RainDownfallController : MonoBehaviour, ISkyModule // TypeDefIndex: 9697
{
	// Fields
	public MeshRenderer rainMeshRenderer; // 0x18
	public Material rainMaterial; // 0x20
	private MaterialPropertyBlock m_PropertyBlock; // 0x28
	private float m_TimeOfDay; // 0x30
	private SkyProfile m_SkyProfile; // 0x38

	// Methods

	// RVA: 0x22B6950 Offset: 0x22B6A51 VA: 0x22B6950
	public void SetWeatherEnclosure(WeatherEnclosure enclosure) { }

	// RVA: 0x22B71B0 Offset: 0x22B72B1 VA: 0x22B71B0
	private void Update() { }

	// RVA: 0x22B6BA0 Offset: 0x22B6CA1 VA: 0x22B6BA0 Slot: 4
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0x22B7320 Offset: 0x22B7421 VA: 0x22B7320
	public void .ctor() { }
}

