[Serializable]
public struct MonsterFootStepEventDataTable // TypeDefIndex: 7777
{
	// Fields
	[SerializeField] // RVA: 0x169800 Offset: 0x169901 VA: 0x169800
	public MonsterFootStepEventDataID MonsterFootStepEventDataID; // 0x0
	[SerializeField] // RVA: 0x169810 Offset: 0x169911 VA: 0x169810
	public string[] LegTransformNames; // 0x8
	[SerializeField] // RVA: 0x169820 Offset: 0x169921 VA: 0x169820
	public StepEventSetting[] WalkStepEvents; // 0x10
	[SerializeField] // RVA: 0x169830 Offset: 0x169931 VA: 0x169830
	public StepEventSetting[] DashStepEvents; // 0x18
	[SerializeField] // RVA: 0x169840 Offset: 0x169941 VA: 0x169840
	public float CollapseNormalizeTime; // 0x20
	[SerializeField] // RVA: 0x169850 Offset: 0x169951 VA: 0x169850
	public float FootEffectScale; // 0x24
	[SerializeField] // RVA: 0x169860 Offset: 0x169961 VA: 0x169860
	public float LandingEffectScale; // 0x28
	private static MonsterFootStepEventDataTableArray _MonsterFootStepEventDataTableArray; // 0x0

	// Methods

	// RVA: 0x2165F60 Offset: 0x2166061 VA: 0x2165F60
	public static MonsterFootStepEventDataTable GetDataTable(MonsterFootStepEventDataID monsterDataID) { }
}

